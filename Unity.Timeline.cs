/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Beyond.Gameplay.Core;
using Beyond.PackageBridge.Timeline;
using Events;
using ScriptAnimation;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Events;
using UnityEngine.Experimental.Animations;
using UnityEngine.Playables;
using UnityEngine.Scripting;
using UnityEngine.Serialization;
using UnityEngine.Timeline;

// Image 40: Unity.Timeline.dll - Assembly: Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 85895-86108

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 86108
{
	// Methods
	internal static uint ComputeStringHash(string s); // 0x0000000188B56950-0x0000000188B569A4
}

namespace Beyond.Gameplay.Core
{
	[AttributeUsage(AttributeTargets.Class)]
	public class DontAutoBindAttribute : DontAutoBindRuntimeAttribute // TypeDefIndex: 85912
	{
		// Constructors
		public DontAutoBindAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class DontAutoBindRuntimeAttribute : Attribute // TypeDefIndex: 85913
	{
		// Constructors
		public DontAutoBindRuntimeAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class BeyondUseAutoBindingPlayableAsset : PlayableAsset // TypeDefIndex: 85914
	{
		// Fields
		[HideInInspector]
		public bool useAutoBinding; // 0x18
		[HideInInspector]
		public string autoBindingPath; // 0x20
		[NonSerialized]
		protected GameObject m_bindingGo; // 0x28
	
		// Properties
		protected virtual bool showBaseParam { get; } // 0x00000001851A4410-0x00000001851A4420 
		public virtual GameObject bindingGameObject { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
	
		// Constructors
		public BeyondUseAutoBindingPlayableAsset(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		public void SetBindingGameObject(GameObject tBindingGameObject); // 0x000000018D451144-0x000000018D45116C
		protected virtual void OnBindGoChanged(); // 0x0000000186805BA0-0x0000000186805BB0
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018D4510F8-0x000000018D451144
	}

	public class RuntimeJumpBehaviour : PlayableBehaviour // TypeDefIndex: 85915
	{
		// Constructors
		public RuntimeJumpBehaviour(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class RuntimeJumpClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 85916
	{
		// Fields
		public bool isReverseJump; // 0x18
		public bool needChangeOptionAfterJump; // 0x19
		public int optionIndexAfterJump; // 0x1C
		public double crossFadeDurationAfterJump; // 0x20
		public bool isJumpFirst; // 0x28
	
		// Properties
		public ClipCaps clipCaps { get; } // 0x000000018725FA40-0x000000018725FA50 
	
		// Constructors
		public RuntimeJumpClip(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018D45118C-0x000000018D451224
	}

	[System.ComponentModel.DisplayName("Beyond/RuntimeJumpTrack")]
	[SupportsChildTracks(null, 2147483647)]
	[TrackClipType(typeof(RuntimeJumpClip))]
	public class RuntimeJumpTrack : TrackAsset, ICombineToTopPlayableTrack // TypeDefIndex: 85917
	{
		// Constructors
		public RuntimeJumpTrack(); // 0x000000018D451224-0x000000018D451270
	}

	public class RuntimeLoopBehaviour : PlayableBehaviour // TypeDefIndex: 85918
	{
		// Constructors
		public RuntimeLoopBehaviour(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class RuntimeLoopClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 85919
	{
		// Fields
		public double crossFadeDuration; // 0x18
	
		// Properties
		public ClipCaps clipCaps { get; } // 0x000000018725E380-0x000000018725E390 
	
		// Constructors
		public RuntimeLoopClip(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018D451270-0x000000018D451308
	}

	[System.ComponentModel.DisplayName("Beyond/RuntimeLoopTrack")]
	[SupportsChildTracks(null, 2147483647)]
	[TrackClipType(typeof(RuntimeLoopClip))]
	public class RuntimeLoopTrack : TrackAsset, ICombineToTopPlayableTrack // TypeDefIndex: 85920
	{
		// Constructors
		public RuntimeLoopTrack(); // 0x000000018D451308-0x000000018D451354
	}

	[ExecuteInEditMode]
	public class TimelineNPCLookAtController : MonoBehaviour // TypeDefIndex: 85921
	{
		// Fields
		private static readonly HashSet<TimelineNPCLookAtController> s_instances; // 0x00
		[NonSerialized]
		public bool m_lookAtDirty; // 0x18
		public TimelineNPCLookAtTarget lookAtTarget; // 0x20
		public TimelineNPCLookAtEyeTarget lookAtEyeTarget; // 0x28
		public TimelineNPCLookAtTargetV2 lookAtTargetV2; // 0x30
		[NonSerialized]
		public bool lookAtEnabled; // 0x38
		[NonSerialized]
		public bool lookAtEyeEnabled; // 0x39
	
		// Properties
		public static IEnumerable<TimelineNPCLookAtController> Instances { get; } // 0x000000018D455404-0x000000018D455454 
		public bool lookAtDirty { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public float lookAtWeight { get; set; } // 0x000000018D455BF8-0x000000018D455C90 0x000000018D4563A8-0x000000018D456440
		public float lookAtBodyWeight { get; set; } // 0x000000018D4556C8-0x000000018D455764 0x000000018D455EFC-0x000000018D455F9C
		public float lookAtBlendWeight { get; set; } // 0x000000018D455654-0x000000018D4556C8 0x000000018D455E84-0x000000018D455EFC
		public float lookAtOverrideWeight { get; } // 0x000000018D455978-0x000000018D455A14 
		public float lookAtAdditiveWeight { get; } // 0x000000018D4555D4-0x000000018D455654 
		public float lookAtRoll { get; set; } // 0x000000018D455A14-0x000000018D455AB0 0x000000018D4561B8-0x000000018D456258
		public float lookAtHorizontal { get; set; } // 0x000000018D4558C0-0x000000018D455978 0x000000018D456104-0x000000018D4561B8
		public float lookAtVertical { get; set; } // 0x000000018D455B40-0x000000018D455BF8 0x000000018D4562F4-0x000000018D4563A8
		public float lookAtEyeWeight { get; set; } // 0x000000018D455844-0x000000018D4558C0 0x000000018D45608C-0x000000018D456104
		public bool lookAtUseDegree { get; set; } // 0x000000018D455AB0-0x000000018D455B40 0x000000018D456258-0x000000018D4562F4
		public bool EyeUseDegree { get; set; } // 0x000000018D455398-0x000000018D455404 0x000000018D455C90-0x000000018D455D08
		public float lookAtEyeUp { get; set; } // 0x000000018D4557D4-0x000000018D455844 0x000000018D456014-0x000000018D45608C
		public float lookAtEyeDown { get; set; } // 0x000000018D455764-0x000000018D4557D4 0x000000018D455F9C-0x000000018D456014
		public Vector3 finalPosition { get; set; } // 0x000000018D455500-0x000000018D4555D4 0x000000018D455DA8-0x000000018D455E84
		public Vector3 finalEyePosition { get; set; } // 0x000000018D455454-0x000000018D455500 0x000000018D455D08-0x000000018D455DA8
	
		// Constructors
		public TimelineNPCLookAtController(); // 0x000000018D45537C-0x000000018D455398
		static TimelineNPCLookAtController(); // 0x000000018D4552F0-0x000000018D45537C
	
		// Methods
		private void OnEnable(); // 0x000000018D455280-0x000000018D4552F0
		private void OnDisable(); // 0x000000018D455210-0x000000018D455280
		public void MarkLookAtDirty(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 85905
	{
		// Constructors
		public ECSComponentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 85906
	{
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 85907
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class SwapRuntimeStateAttribute : Attribute // TypeDefIndex: 85908
	{
		// Constructors
		public SwapRuntimeStateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class ResetOnSwapAttribute : Attribute // TypeDefIndex: 85909
	{
		// Constructors
		public ResetOnSwapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 85910
	{
		// Constructors
		public DataNAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 85911
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace Events
{
	public interface INotificationTrack // TypeDefIndex: 85903
	{
	}

	public interface ITimelineNotification // TypeDefIndex: 85904
	{
		// Methods
		void OnNotify(ITimelineRootMarker root);
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 85896
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace ScriptAnimation
{
	[UseScriptDefaultValueWhenExport]
	public class TimelineNPCClothWeightController : MonoBehaviour // TypeDefIndex: 85897
	{
		// Fields
		public bool forceSetPhysicsClothWeight; // 0x18
		[Range(0f, 1f)]
		public float physicsClothWeight; // 0x1C
		public bool forceSetPhysicsClothPart1Weight; // 0x20
		[Range(0f, 1f)]
		public float physicsClothPart1Weight; // 0x24
		public bool forceSetPhysicsClothPart2Weight; // 0x28
		[Range(0f, 1f)]
		public float physicsClothPart2Weight; // 0x2C
		public bool forceSetLoopBodyAddWeight; // 0x30
		[Range(0f, 1f)]
		public float loopBodyAddWeight; // 0x34
	
		// Constructors
		public TimelineNPCClothWeightController(); // 0x000000018D4551DC-0x000000018D455210
	}

	[UseScriptDefaultValueWhenExport]
	public class TimelineNPCLookAtEyeTarget : MonoBehaviour // TypeDefIndex: 85898
	{
		// Fields
		[Range(0f, 1f)]
		public float lookAtWeight; // 0x18
		[FormerlySerializedAs("lookAtUseDegree")]
		public bool useDegree; // 0x1C
		[Range(-1f, 1f)]
		public float lookAtUp; // 0x20
		[Range(-1f, 1f)]
		public float lookAtDown; // 0x24
	
		// Constructors
		public TimelineNPCLookAtEyeTarget(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void ResetLookAtWeight(); // 0x0000000187248930-0x0000000187248940
	}

	[UseScriptDefaultValueWhenExport]
	public class TimelineNPCLookAtTarget : MonoBehaviour // TypeDefIndex: 85899
	{
		// Fields
		[Range(0f, 1f)]
		public float lookAtWeight; // 0x18
		[Range(0f, 1f)]
		public float lookAtBodyWeight; // 0x1C
		public bool useDegree; // 0x20
		[Range(0f, 1f)]
		public float lookAtHorizontal; // 0x24
		[Range(-1f, 1f)]
		public float lookAtVertical; // 0x28
		[Range(0f, 1f)]
		public float lookAtRoll; // 0x2C
	
		// Constructors
		public TimelineNPCLookAtTarget(); // 0x000000018D456440-0x000000018D456470
	}

	[UseScriptDefaultValueWhenExport]
	public class TimelineNPCLookAtTargetV2 : MonoBehaviour // TypeDefIndex: 85900
	{
		// Fields
		[Range(-1f, 1f)]
		public float lookAtBlendWeight; // 0x18
		[Range(0f, 1f)]
		public float lookAtBodyWeight; // 0x1C
		public bool useDegree; // 0x20
		[Range(0f, 1f)]
		public float lookAtHorizontal; // 0x24
		[Range(-1f, 1f)]
		public float lookAtVertical; // 0x28
		[Range(0f, 1f)]
		public float lookAtRoll; // 0x2C
	
		// Constructors
		public TimelineNPCLookAtTargetV2(); // 0x000000018D456440-0x000000018D456470
	}
}

namespace ScriptAnimation.ScriptAnimationApply
{
	public class ScriptAnimationApplyBehaviour : PlayableBehaviour // TypeDefIndex: 85901
	{
		// Fields
		private static readonly ProfilerMarker s_calcLayerMainStreamMarker; // 0x00
		private IScriptAnimationJobSync m_JobSync; // 0x10
	
		// Constructors
		public ScriptAnimationApplyBehaviour(); // 0x0000000186805BA0-0x0000000186805BB0
		static ScriptAnimationApplyBehaviour(); // 0x000000018D4514E4-0x000000018D451548
	
		// Methods
		public override void PrepareFrame(Playable playable, FrameData info); // 0x000000018D451354-0x000000018D4514E4
		public void InitBehaviour(IScriptAnimationJobSync jobSync); // 0x0000000184FD2410-0x0000000184FD2420
	}

	public class ScriptAnimationApplyPlayable : PlayableAsset // TypeDefIndex: 85902
	{
		// Constructors
		public ScriptAnimationApplyPlayable(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018D451548-0x000000018D4515E0
	}
}

namespace UnityEngine
{
	public static class PlayerLoopChecker // TypeDefIndex: 85922
	{
	}
}

namespace UnityEngine.Timeline
{
	internal class ActivationMixerPlayable : PlayableBehaviour // TypeDefIndex: 85923
	{
		// Fields
		private ActivationTrack.PostPlaybackState m_PostPlaybackState; // 0x10
		private bool m_BoundGameObjectInitialStateIsActive; // 0x14
		private bool m_useAutoBinding; // 0x15
		private ITimelineRootMarker m_RootMarker; // 0x18
		private string m_uniqueId; // 0x20
		private IReadOnlyList<string> m_childUniqueIds; // 0x28
		private bool? m_lastEntityActive; // 0x30
		private GameObject m_BoundGameObject; // 0x38
		private bool m_IsControlTrackMode; // 0x40
		private ActivationControlPlayable.PostPlaybackState m_ControlTrackPostPlayback; // 0x44
		private bool? m_ControlTrackLastActive; // 0x48
		private bool m_ControlTrackGraphStarted; // 0x4A
	
		// Properties
		public ActivationTrack.PostPlaybackState postPlaybackState { set; } // 0x0000000182234E90-0x0000000182234EA0
	
		// Constructors
		public ActivationMixerPlayable(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static ScriptPlayable<ActivationMixerPlayable> Create(PlayableGraph graph, int inputCount); // 0x000000018D448774-0x000000018D448800
		public void SetBoundGameObject(GameObject go); // 0x000000018D448D48-0x000000018D448DD8
		public void SetControlTrackMode(GameObject gameObject, ActivationControlPlayable.PostPlaybackState postPlayback); // 0x0000000184F53360-0x0000000184F53390
		public void SetAutoBindingData(bool useAutoBinding, ITimelineRootMarker rootMarker, string uniqueId, IReadOnlyList<string> childUniqueIds); // 0x000000018D448D0C-0x000000018D448D48
		public override void OnPlayableDestroy(Playable playable); // 0x000000018D448800-0x000000018D448B30
		public override void OnGraphStart(Playable playable); // 0x0000000184F52FB0-0x0000000184F53360
		public override void OnBehaviourPause(Playable playable, FrameData info); // 0x0000000186805BA0-0x0000000186805BB0
		public override void ProcessFrame(Playable playable, FrameData info, object playerData); // 0x000000018D448C24-0x000000018D448D0C
		public override void PrepareFrame(Playable playable, FrameData info); // 0x000000018D448B30-0x000000018D448C24
		private void _DoSetControlTrackActive(Playable playable); // 0x0000000184F53730-0x0000000184F54850
		private void _ApplyControlTrackPostPlayback(); // 0x0000000184F53390-0x0000000184F53730
		private void _DoSetActive(Playable playable, FrameData info, object playerData = null); // 0x000000018D448DD8-0x000000018D449038
		private bool _HasBindingUniqueIds(); // 0x000000018D449038-0x000000018D449098
		private bool _TrySetBindingEntitiesVisible(bool visible); // 0x000000018D449098-0x000000018D449208
	}

	public class ActivationPlayableAsset : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 85924
	{
		// Properties
		public ClipCaps clipCaps { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	
		// Constructors
		public ActivationPlayableAsset(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go); // 0x000000018D449208-0x000000018D449274
	}

	[Serializable]
	[ExcludeFromPreset]
	[TrackBindingType(typeof(GameObject))]
	[TrackClipType(typeof(ActivationPlayableAsset))]
	public class ActivationTrack : TrackAsset // TypeDefIndex: 85926
	{
		// Fields
		[SerializeField]
		private PostPlaybackState m_PostPlaybackState; // 0xC8
		private ActivationMixerPlayable m_ActivationMixer; // 0xD0
	
		// Properties
		public PostPlaybackState postPlaybackState { get; set; } // 0x0000000187235AE0-0x0000000187235AF0 0x000000018D449710-0x000000018D449720
	
		// Nested types
		public enum PostPlaybackState // TypeDefIndex: 85925
		{
			Active = 0,
			Inactive = 1,
			Revert = 2,
			LeaveAsIs = 3
		}
	
		// Constructors
		public ActivationTrack(); // 0x0000000186253C20-0x0000000186253C80
	
		// Methods
		internal override bool CanCompileClips(); // 0x000000018D449274-0x000000018D4492A4
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount); // 0x000000018D4492A4-0x000000018D449498
		private void _BindUniqueId(PlayableGraph graph); // 0x000000018D4496B0-0x000000018D449710
		internal GameObject GetBinding(PlayableDirector director); // 0x000000018D449544-0x000000018D449644
		internal void UpdateTrackMode(); // 0x000000018D449694-0x000000018D4496B0
		public override void GatherProperties(PlayableDirector director, IPropertyCollector driver); // 0x000000018D449498-0x000000018D449544
		protected override void OnCreateClip(TimelineClip clip); // 0x000000018D449644-0x000000018D449694
	}

	[Serializable]
	[UnityEngine.Timeline.NotKeyable]
	public sealed class AnimationFakeRootMotionPlayableAsset : AnimationPlayableAsset // TypeDefIndex: 85927
	{
		// Fields
		[SerializeField]
		private bool m_EnableFakeRootMotion; // 0xC0
		[Min(0f)]
		[SerializeField]
		private float m_DistancePerCycle; // 0xC4
		[SerializeField]
		private double m_TimeOrigin; // 0xC8
		[SerializeField]
		private Vector3 m_LocalMotionPerMeter; // 0xD0
	
		// Properties
		public bool enableFakeRootMotion { get; set; } // 0x0000000184F560B0-0x0000000184F560C0 0x0000000184F56110-0x0000000184F56120
		public float distancePerCycle { get; set; } // 0x0000000184F560A0-0x0000000184F560B0 0x0000000184F560F0-0x0000000184F56110
		public double timeOrigin { get; set; } // 0x0000000184F560E0-0x0000000184F560F0 0x0000000184F56140-0x0000000184F56150
		public Vector3 localMotionPerMeter { get; set; } // 0x0000000184F560C0-0x0000000184F560E0 0x0000000184F56120-0x0000000184F56140
	
		// Constructors
		public AnimationFakeRootMotionPlayableAsset(); // 0x0000000184F55D60-0x0000000184F560A0
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go); // 0x0000000184F552D0-0x0000000184F55D60
	}

	internal static class AnimationFakeRootMotionPlayable // TypeDefIndex: 85928
	{
		// Methods
		internal static bool InsertBeforeClipOffset(PlayableGraph graph, Playable root, float cycleDuration, float distancePerCycle, double timeOrigin, Vector3 localMotionPerMeter); // 0x0000000184F56150-0x0000000184F584A0
		private static bool TryFindClipOffset(Playable root, out AnimationOffsetPlayable clipOffset); // 0x0000000184F584A0-0x0000000184F595E0
	}

	internal sealed class AnimationFakeRootMotionBehaviour : PlayableBehaviour // TypeDefIndex: 85929
	{
		// Fields
		private AnimationOffsetPlayable m_FakeOffset; // 0x10
		private double m_TimeOrigin; // 0x20
		private float m_Speed; // 0x28
		private Vector3 m_LocalMotionPerMeter; // 0x2C
	
		// Constructors
		public AnimationFakeRootMotionBehaviour(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		internal void Initialize(AnimationOffsetPlayable fakeOffset, float cycleDuration, float distancePerCycle, double timeOrigin, Vector3 localMotionPerMeter); // 0x0000000184F54850-0x0000000184F54890
		public override void PrepareFrame(Playable playable, FrameData info); // 0x0000000184F54890-0x0000000184F552D0
	}

	internal class AnimationOutputWeightProcessor : ITimelineEvaluateCallback // TypeDefIndex: 85931
	{
		// Fields
		private Animator m_outputAnimator; // 0x10
		private AnimationPlayableOutput m_Output; // 0x18
		private readonly bool m_OnlyEvaluateOutputWeight; // 0x28
		private readonly Func<Playable, bool> m_ShouldExcludeFromWeightProcessorCalc; // 0x30
		private readonly List<WeightInfo> m_Mixers; // 0x38
	
		// Nested types
		private struct WeightInfo // TypeDefIndex: 85930
		{
			// Fields
			public Playable mixer; // 0x00
			public Playable parentMixer; // 0x10
			public int port; // 0x20
		}
	
		// Constructors
		public AnimationOutputWeightProcessor(AnimationPlayableOutput output, Animator animator); // 0x000000018D449EBC-0x000000018D449EE8
		public AnimationOutputWeightProcessor(AnimationPlayableOutput output, Animator animator, bool onlyEvaluateOutputWeight, Func<Playable, bool> shouldExcludeFromWeightProcessorCalc); // 0x000000018D449EE8-0x000000018D449FDC
	
		// Methods
		private void FindMixers(); // 0x000000018D449AE4-0x000000018D449BE0
		private void FindMixers(Playable parent, int port, Playable node); // 0x000000018D449BE0-0x000000018D449EBC
		public void Evaluate(); // 0x000000018D449720-0x000000018D449AE4
	}

	[Serializable]
	[UnityEngine.Timeline.NotKeyable]
	public class AnimationPlayableAsset : PlayableAsset, ITimelineClipAsset, IPropertyPreview, ICustomControlBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 85939
	{
		// Fields
		[SerializeField]
		private AnimationClip m_Clip; // 0x18
		[SerializeField]
		private Vector3 m_Position; // 0x20
		[SerializeField]
		private Vector3 m_EulerAngles; // 0x2C
		[SerializeField]
		private bool m_UseTrackMatchFields; // 0x38
		[SerializeField]
		private MatchTargetFields m_MatchTargetFields; // 0x3C
		[SerializeField]
		private bool m_RemoveStartOffset; // 0x40
		[SerializeField]
		private bool m_ApplyFootIK; // 0x41
		[SerializeField]
		private LoopMode m_Loop; // 0x44
		[SerializeField]
		private bool m_IgniteOnce; // 0x48
		[SerializeField]
		private bool m_OnlyDeltaTime; // 0x49
		[SerializeField]
		private bool m_SeekFirstOnlyDeltaTime; // 0x4A
		[SerializeField]
		private bool m_ReversePlayback; // 0x4B
		[SerializeField]
		private bool m_DynamicLink; // 0x4C
		[SerializeField]
		private ClothResetOption m_ClothResetOption; // 0x50
		[SerializeField]
		private AnimationEventTriggerMode m_AnimationEventTriggerMode; // 0x54
		[Range(0f, 1f)]
		[SerializeField]
		private float m_AnimationEventTriggerWeightThreshold; // 0x58
		[SerializeField]
		private AnimationEventTriggerMode m_CustomFootStepTriggerMode; // 0x5C
		[Range(0f, 1f)]
		[SerializeField]
		private float m_CustomFootStepTriggerWeightThreshold; // 0x60
		[SerializeField]
		private ClipEndAudioBehaviour m_ClipEndAudioBehaviour; // 0x64
		[SerializeField]
		private int m_ClipEndAudioFadeOutTimeMs; // 0x68
		[SerializeField]
		private bool m_MixWitherAnotherClip; // 0x6C
		[Range(0f, 1f)]
		[SerializeField]
		private float m_MainClipMixWeight; // 0x70
		[SerializeField]
		private AnimationClip m_AnotherClip; // 0x78
		[SerializeField]
		private AnimationClip m_blendShapeControlClip; // 0x80
		[SerializeField]
		private bool m_UseTimeRemapCurve; // 0x88
		[SerializeField]
		private AnimationCurve m_TimeRemapCurve; // 0x90
		[CompilerGenerated]
		private bool _useAnotherClipTimeAdapter_k__BackingField; // 0x98
		public bool DisableBlendShapeControl; // 0x99
		[CompilerGenerated]
		private AppliedOffsetMode _appliedOffsetMode_k__BackingField; // 0x9C
		[CompilerGenerated]
		private ITimelineAnimationEventContextBinding _TimelineAnimationEventContextBinding_k__BackingField; // 0xA0
		private static readonly int k_LatestVersion; // 0x00
		[HideInInspector]
		[SerializeField]
		private int m_Version; // 0xA8
		[HideInInspector]
		[Obsolete("Use m_RotationEuler Instead", false)]
		[SerializeField]
		private Quaternion m_Rotation; // 0xAC
	
		// Properties
		internal bool useAnotherClipTimeAdapter { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271B80-0x0000000182271B90 0x0000000182271B90-0x0000000182271BA0
		public Vector3 position { get; set; } // 0x000000018723E710-0x000000018723E730 0x000000018723E700-0x000000018723E710
		public Quaternion rotation { get; set; } // 0x000000018D44B818-0x000000018D44B854 0x000000018D44B93C-0x000000018D44B964
		public Vector3 eulerAngles { get; set; } // 0x0000000187233AD0-0x0000000187233AF0 0x0000000187233B00-0x0000000187233B10
		public bool useTrackMatchFields { get; set; } // 0x000000018225E070-0x000000018225E080 0x000000018225E080-0x000000018225E090
		public MatchTargetFields matchTargetFields { get; set; } // 0x000000018226F000-0x000000018226F010 0x000000018226F010-0x000000018226F020
		public bool removeStartOffset { get; set; } // 0x000000018225DFB0-0x000000018225DFC0 0x000000018225DFC0-0x000000018225DFD0
		public bool applyFootIK { get; set; } // 0x000000018226EE60-0x000000018226EE70 0x000000018226EE70-0x000000018226EE80
		public LoopMode loop { get; set; } // 0x0000000182271C40-0x0000000182271C50 0x0000000182271C60-0x0000000182271C70
		public bool IgniteOnce { get; set; } // 0x000000018223CB60-0x000000018223CB70 0x000000018223CB70-0x000000018223CB80
		public bool OnlyDeltaTime { get; set; } // 0x0000000182271C20-0x0000000182271C30 0x000000018D44B854-0x000000018D44B860
		public bool SeekFirstOnlyDeltaTime { get; set; } // 0x00000001872338D0-0x00000001872338E0 0x000000018D44B860-0x000000018D44B86C
		public bool ReversePlayback { get; set; } // 0x0000000182308F30-0x0000000182308F40 0x0000000182308F40-0x0000000182308F50
		public bool DynamicLink { get; set; } // 0x000000018226EC80-0x000000018226EC90 0x000000018226EC90-0x000000018226ECA0
		public bool MixWithAnotherClip { get; set; } // 0x000000018723CA20-0x000000018723CA30 0x0000000187234ED0-0x0000000187234EE0
		public AnimationClip AnotherClip { get; set; } // 0x00000001829CD170-0x00000001829CD180 0x0000000188800CC0-0x0000000188800CD0
		public AnimationClip BlendShapeControlClip { get; internal set; } // 0x00000001828D49D0-0x00000001828D49E0 0x00000001870EAAE0-0x00000001870EAAF0
		public bool useTimeRemapCurve { get; set; } // 0x000000018236FC60-0x000000018236FC70 0x000000018236FC70-0x000000018236FC80
		public AnimationCurve timeRemapCurve { get; set; } // 0x0000000182271B70-0x0000000182271B80 0x0000000188800C9C-0x0000000188800CB0
		public float MainClipMixWeight { get; set; } // 0x000000018723E550-0x000000018723E560 0x000000018723E540-0x000000018723E550
		internal bool hasRootTransforms { get; } // 0x000000018D44B728-0x000000018D44B7A8 
		internal AppliedOffsetMode appliedOffsetMode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271AF0-0x0000000182271B00 0x0000000182271B40-0x0000000182271B50
		internal ITimelineAnimationEventContextBinding TimelineAnimationEventContextBinding { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232F60-0x0000000187232F70 0x0000000188800C88-0x0000000188800C9C
		public AnimationClip clip { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x000000018D44B86C-0x000000018D44B93C
		public override double duration { get; } // 0x000000018D44B6C0-0x000000018D44B728 
		public ClothResetOption clothResetOption { get; set; } // 0x0000000187233280-0x0000000187233290 0x00000001854CCF30-0x00000001854CCF40
		public AnimationEventTriggerMode animationEventTriggerMode { get; set; } // 0x00000001872336F0-0x0000000187233700 0x0000000187233700-0x0000000187233710
		public float animationEventTriggerWeightThreshold { get; set; } // 0x00000001872353B0-0x00000001872353C0 0x00000001872353E0-0x00000001872353F0
		public AnimationEventTriggerMode customFootStepTriggerMode { get; set; } // 0x0000000187233600-0x0000000187233610 0x0000000187233630-0x0000000187233640
		public float customFootStepTriggerWeightThreshold { get; set; } // 0x00000001872352B0-0x00000001872352C0 0x00000001872352D0-0x00000001872352E0
		public ClipEndAudioBehaviour clipEndAudioBehaviour { get; set; } // 0x0000000187233670-0x0000000187233680 0x0000000187233690-0x00000001872336A0
		public int clipEndAudioFadeOutTimeMs { get; set; } // 0x0000000182271AE0-0x0000000182271AF0 0x0000000185B8E660-0x0000000185B8E8A0
		public override IEnumerable<PlayableBinding> outputs { [IteratorStateMachine(typeof(_get_outputs_d__131))] get; } // 0x000000018D44B7A8-0x000000018D44B818 
		public ClipCaps clipCaps { get; } // 0x000000018D44B564-0x000000018D44B6C0 
	
		// Nested types
		public enum LoopMode // TypeDefIndex: 85932
		{
			UseSourceAsset = 0,
			On = 1,
			Off = 2
		}
	
		public enum ClothResetOption // TypeDefIndex: 85933
		{
			SoftReset = 0,
			UseClothRelativeTeleport = 1,
			UseStablizationTime = 2,
			SoftResetKeepPose = 3,
			DisablePhysics = 4
		}
	
		public enum AnimationEventTriggerMode // TypeDefIndex: 85934
		{
			Default = 0,
			MuteAllEvents = 1,
			SeekAllEvents = 2
		}
	
		public enum ClipEndAudioBehaviour // TypeDefIndex: 85935
		{
			Default = 0,
			MuteAll = 1
		}
	
		private enum Versions // TypeDefIndex: 85936
		{
			Initial = 0,
			RotationAsEuler = 1
		}
	
		private static class AnimationPlayableAssetUpgrade // TypeDefIndex: 85937
		{
			// Methods
			public static void ConvertRotationToEuler(AnimationPlayableAsset asset); // 0x000000018D449FDC-0x000000018D44A018
		}
	
		[CompilerGenerated]
		private sealed class _get_outputs_d__131 : IEnumerable<PlayableBinding>, IEnumerator<PlayableBinding> // TypeDefIndex: 85938
		{
			// Fields
			private int __1__state; // 0x10
			private PlayableBinding __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			public AnimationPlayableAsset __4__this; // 0x40
	
			// Properties
			PlayableBinding IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { [DebuggerHidden] get; } // 0x00000001872438D0-0x00000001872438F0 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018D45B858-0x000000018D45B8A8 
	
			// Constructors
			[DebuggerHidden]
			public _get_outputs_d__131(int __1__state); // 0x000000018D45B8A8-0x000000018D45B8C4
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D45B6F0-0x000000018D45B774
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D45B80C-0x000000018D45B858
			[DebuggerHidden]
			IEnumerator<PlayableBinding> IEnumerable<PlayableBinding>.GetEnumerator(); // 0x000000018D45B774-0x000000018D45B804
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D45B804-0x000000018D45B80C
		}
	
		// Constructors
		public AnimationPlayableAsset(); // 0x0000000186253E90-0x0000000186253F90
		static AnimationPlayableAsset(); // 0x0000000187220CB0-0x0000000187220CF0
	
		// Methods
		public float EvaluateTimeRemap(float normalizedTime); // 0x000000018D44ADD0-0x000000018D44AE08
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go); // 0x000000018D44AD58-0x000000018D44ADD0
		internal static Playable CreatePlayable(PlayableGraph graph, AnimationClip clip, Vector3 positionOffset, Vector3 eulerOffset, bool removeStartOffset, AppliedOffsetMode mode, bool applyFootIK, LoopMode loop); // 0x000000018D44AA34-0x000000018D44AD58
		internal static Playable CreatePlayable(PlayableGraph graph, AnimationPlayableAsset playableAsset); // 0x000000018D44A0BC-0x000000018D44AA34
		internal static AnimationClipPlayable CreateAnimationClipPlayable(PlayableGraph graph, AnimationClip clip, bool removeStartOffset, bool applyFootIK, LoopMode loop); // 0x000000018D44A038-0x000000018D44A0BC
		private static bool ShouldApplyOffset(AppliedOffsetMode mode, AnimationClip clip); // 0x000000018D44B234-0x000000018D44B290
		private static bool ShouldApplyEventControl(AnimationPlayableAsset playableAsset); // 0x000000018D44B168-0x000000018D44B234
		private static AnimationEventTriggerMode GetEffectiveAnimationEventTriggerMode(AnimationPlayableAsset playableAsset, AnimationEventTriggerMode triggerMode); // 0x000000018D44AE58-0x000000018D44AED4
		internal static Playable TryApplyAnimationEventControl(PlayableGraph graph, Playable root, AnimationPlayableAsset playableAsset); // 0x000000018D44B2A4-0x000000018D44B508
		private static bool ShouldApplyScaleRemove(AppliedOffsetMode mode); // 0x000000018D44B290-0x000000018D44B2A4
		public void ResetOffsets(); // 0x000000018D44B144-0x000000018D44B168
		public void GatherProperties(PlayableDirector director, IPropertyCollector driver); // 0x000000018D44AE08-0x000000018D44AE58
		internal static bool HasRootTransforms(AnimationClip clip); // 0x000000018D44AED4-0x000000018D44AF74
		public AnimationEvent[] CollectAnimationEvents(); // 0x000000018D44A018-0x000000018D44A038
		public void OnClipEnable(Playable playable, FrameData info); // 0x0000000186805BA0-0x0000000186805BB0
		public void OnClipDisable(Playable playable, FrameData info); // 0x000000018D44AF74-0x000000018D44B134
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018D44B508-0x000000018D44B564
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x0000000186AAD0B0-0x0000000186AAD120
		private void OnUpgradeFromVersion(int oldVersion); // 0x000000018D44B134-0x000000018D44B144
	}

	internal class AnotherClipTimeAdapterBehaviour : PlayableBehaviour // TypeDefIndex: 85940
	{
		// Fields
		private Playable m_AnotherClipPlayable; // 0x10
		private bool m_Initialized; // 0x20
		private double m_Time; // 0x28
	
		// Constructors
		public AnotherClipTimeAdapterBehaviour(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Initialize(Playable anotherClipPlayable); // 0x000000018725FA20-0x000000018725FA40
		public override void PrepareFrame(Playable playable, FrameData info); // 0x000000018D450344-0x000000018D450404
	}

	internal class AnimationPreviewUpdateCallback // TypeDefIndex: 85941
	{
	}

	[Flags]
	public enum MatchTargetFields // TypeDefIndex: 85942
	{
		PositionX = 1,
		PositionY = 2,
		PositionZ = 4,
		RotationX = 8,
		RotationY = 16,
		RotationZ = 32
	}

	public enum TrackOffset // TypeDefIndex: 85943
	{
		ApplyTransformOffsets = 0,
		ApplySceneOffsets = 1,
		Auto = 2
	}

	internal enum AppliedOffsetMode // TypeDefIndex: 85944
	{
		NoRootTransform = 0,
		TransformOffset = 1,
		SceneOffset = 2,
		TransformOffsetLegacy = 3,
		SceneOffsetLegacy = 4,
		SceneOffsetEditor = 5,
		SceneOffsetLegacyEditor = 6
	}

	internal static class MatchTargetFieldConstants // TypeDefIndex: 85945
	{
		// Fields
		public static MatchTargetFields All; // 0x00
		public static MatchTargetFields None; // 0x04
		public static MatchTargetFields Position; // 0x08
		public static MatchTargetFields Rotation; // 0x0C
	
		// Constructors
		static MatchTargetFieldConstants(); // 0x00000001871D6FD0-0x00000001871D7050
	}

	public interface IAnimationTrackClipWeightReceiver // TypeDefIndex: 85946
	{
		// Methods
		void SetAnimationTrackClipWeight(float weight);
	}

	internal sealed class AnimationTrackClipWeightBehaviour : PlayableBehaviour // TypeDefIndex: 85947
	{
		// Fields
		private IAnimationTrackClipWeightReceiver m_Receiver; // 0x10
	
		// Constructors
		public AnimationTrackClipWeightBehaviour(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Initialize(IAnimationTrackClipWeightReceiver receiver); // 0x0000000184FD2410-0x0000000184FD2420
		public override void PrepareFrame(Playable playable, FrameData info); // 0x000000018D44B9E0-0x000000018D44BB24
		public override void OnGraphStop(Playable playable); // 0x000000018D44B9D8-0x000000018D44B9E0
		public override void OnPlayableDestroy(Playable playable); // 0x000000018D44B9D8-0x000000018D44B9E0
		private bool HasReceiver(); // 0x000000018D44B964-0x000000018D44B9D8
		private void ResetWeight(); // 0x000000018D44BB24-0x000000018D44BB5C
	}

	[Serializable]
	[ExcludeFromPreset]
	[TrackBindingType(typeof(Animator))]
	[TrackClipType(typeof(AnimationPlayableAsset), false)]
	public class AnimationTrack : TrackAsset, ILayerable // TypeDefIndex: 85950
	{
		// Fields
		private const string k_DefaultInfiniteClipName = "Recorded"; // Metadata: 0x0264537D
		private const string k_DefaultRecordableClipName = "Recorded"; // Metadata: 0x02645386
		[FormerlySerializedAs("m_OpenClipPreExtrapolation")]
		[SerializeField]
		private TimelineClip.ClipExtrapolation m_InfiniteClipPreExtrapolation; // 0xC8
		[FormerlySerializedAs("m_OpenClipPostExtrapolation")]
		[SerializeField]
		private TimelineClip.ClipExtrapolation m_InfiniteClipPostExtrapolation; // 0xCC
		[FormerlySerializedAs("m_OpenClipOffsetPosition")]
		[SerializeField]
		private Vector3 m_InfiniteClipOffsetPosition; // 0xD0
		[FormerlySerializedAs("m_OpenClipOffsetEulerAngles")]
		[SerializeField]
		private Vector3 m_InfiniteClipOffsetEulerAngles; // 0xDC
		[FormerlySerializedAs("m_OpenClipTimeOffset")]
		[SerializeField]
		private double m_InfiniteClipTimeOffset; // 0xE8
		[FormerlySerializedAs("m_OpenClipRemoveOffset")]
		[SerializeField]
		private bool m_InfiniteClipRemoveOffset; // 0xF0
		[SerializeField]
		private bool m_InfiniteClipApplyFootIK; // 0xF1
		[HideInInspector]
		[SerializeField]
		private AnimationPlayableAsset.LoopMode mInfiniteClipLoop; // 0xF4
		[SerializeField]
		private MatchTargetFields m_MatchTargetFields; // 0xF8
		[SerializeField]
		private Vector3 m_Position; // 0xFC
		[SerializeField]
		private Vector3 m_EulerAngles; // 0x108
		[SerializeField]
		private AvatarMask m_AvatarMask; // 0x118
		[SerializeField]
		private bool m_ApplyAvatarMask; // 0x120
		[SerializeField]
		private bool m_DisableFloatCurveOnMask; // 0x121
		[SerializeField]
		private TrackOffset m_TrackOffset; // 0x124
		[SerializeField]
		private AnimationStreamSource m_AnimationStreamSource; // 0x128
		[SerializeField]
		private bool m_UseTakeOver; // 0x12C
		[SerializeField]
		private string m_TakeOverNpcProxyId; // 0x130
		[HideInInspector]
		[SerializeField]
		private AnimationClip m_InfiniteClip; // 0x138
		[SerializeField]
		private bool m_IsAdditive; // 0x140
		[SerializeField]
		private bool m_IsAdditiveToLast; // 0x141
		[NonSerialized]
		public bool muteScriptAnimAddon; // 0x142
		[SerializeField]
		private bool m_UseScriptAnimAddon; // 0x143
		[SerializeField]
		private bool m_useTPoseAsDefaultPose; // 0x144
		[SerializeField]
		private bool m_DisableDefaultValuesForceUseDefaultPose; // 0x145
		[SerializeField]
		private AnimationClip m_TPoseClip; // 0x148
		[SerializeField]
		private ScriptableObject m_TimelineNPCDescriptor; // 0x150
		[SerializeField]
		private string m_LookAtTargetPath; // 0x158
		[SerializeField]
		private bool m_LookAtUseAdditive; // 0x160
		[SerializeField]
		private bool m_UseLookAtV2; // 0x161
		[SerializeField]
		private bool m_WriteTransformDefAsPostProcess; // 0x162
		private Transform m_LookAtTarget; // 0x168
		[NonSerialized]
		private HashSet<RuntimeElement> m_allRuntimeClipUnderTrack; // 0x170
		private static readonly Queue<Transform> s_CachedQueue; // 0x00
		[HideInInspector]
		[Obsolete("Use m_InfiniteClipOffsetEulerAngles Instead", false)]
		[SerializeField]
		private Quaternion m_OpenClipOffsetRotation; // 0x178
		[HideInInspector]
		[Obsolete("Use m_RotationEuler Instead", false)]
		[SerializeField]
		private Quaternion m_Rotation; // 0x188
		[HideInInspector]
		[Obsolete("Use m_RootTransformOffsetMode", false)]
		[SerializeField]
		private bool m_ApplyOffsets; // 0x198
	
		// Properties
		public Vector3 position { get; set; } // 0x0000000187253E30-0x0000000187253E50 0x0000000187253E50-0x0000000187253E70
		public Quaternion rotation { get; set; } // 0x000000018D450228-0x000000018D450268 0x000000018D450314-0x000000018D450344
		public Vector3 eulerAngles { get; set; } // 0x000000018723F960-0x000000018723F980 0x000000018723F9A0-0x000000018723F9C0
		[Obsolete("applyOffset is deprecated. Use trackOffset instead", true)]
		public bool applyOffsets { get; set; } // 0x00000001843FFFF0-0x0000000184400000 0x0000000186805BA0-0x0000000186805BB0
		public TrackOffset trackOffset { get; set; } // 0x0000000187240800-0x0000000187240810 0x0000000187240820-0x0000000187240830
		public AnimationStreamSource animationStreamSource { get; set; } // 0x000000018723D530-0x000000018723D540 0x000000018723D5C0-0x000000018723D5D0
		public bool useTakeOver { get; set; } // 0x000000018723B260-0x000000018723B270 0x000000018725FA10-0x000000018725FA20
		public string takeOverNpcProxyId { get; set; } // 0x000000018723B420-0x000000018723B430 0x000000018783BF78-0x000000018783BF8C
		public MatchTargetFields matchTargetFields { get; set; } // 0x00000001828A9D40-0x00000001828A9D50 0x000000018D450298-0x000000018D4502F4
		public AnimationClip infiniteClip { get; internal set; } // 0x000000018723B5C0-0x000000018723B5D0 0x000000018783BF8C-0x000000018783BFA0
		internal bool infiniteClipRemoveOffset { get; set; } // 0x000000018723B8D0-0x000000018723B8E0 0x000000018723B900-0x000000018723B910
		public AvatarMask avatarMask { get; set; } // 0x0000000187232D10-0x0000000187232D20 0x000000018783BFA0-0x000000018783BFB4
		public bool applyAvatarMask { get; set; } // 0x00000001872406E0-0x00000001872406F0 0x0000000187240740-0x0000000187240750
		public bool disableFloatCurveOnMask { get; set; } // 0x000000018725F9A0-0x000000018725F9B0 0x000000018725F9D0-0x000000018725F9E0
		public bool isUsingScriptAnimAddon { get; set; } // 0x000000018725F9C0-0x000000018725F9D0 0x000000018725FA00-0x000000018725FA10
		public bool disableDefaultValuesForceUseDefaultPose { get; set; } // 0x0000000187241310-0x0000000187241320 0x0000000187241330-0x0000000187241340
		public bool lookAtUseAdditive { get; set; } // 0x000000018723E1F0-0x000000018723E200 0x000000018723E260-0x000000018723E270
		public bool useLookAtV2 { get; set; } // 0x000000018723E360-0x000000018723E370 0x000000018723E3D0-0x000000018723E3E0
		public override IEnumerable<PlayableBinding> outputs { [IteratorStateMachine(typeof(_get_outputs_d__93))] get; } // 0x000000018D4501B8-0x000000018D450228 
		public bool inClipMode { get; } // 0x000000018D450108-0x000000018D450150 
		public Vector3 infiniteClipOffsetPosition { get; set; } // 0x0000000184F560C0-0x0000000184F560E0 0x0000000184F56120-0x0000000184F56140
		public Quaternion infiniteClipOffsetRotation { get; set; } // 0x000000018D450150-0x000000018D450190 0x000000018D450268-0x000000018D450298
		public Vector3 infiniteClipOffsetEulerAngles { get; set; } // 0x00000001872577E0-0x0000000187257800 0x0000000187257800-0x0000000187257820
		internal bool infiniteClipApplyFootIK { get; set; } // 0x0000000187249830-0x0000000187249840 0x000000018724BF90-0x000000018724BFA0
		internal double infiniteClipTimeOffset { get; set; } // 0x000000018724ED50-0x000000018724ED60 0x000000018725F9F0-0x000000018725FA00
		public TimelineClip.ClipExtrapolation infiniteClipPreExtrapolation { get; set; } // 0x0000000187235AE0-0x0000000187235AF0 0x0000000187235AF0-0x0000000187235B00
		public TimelineClip.ClipExtrapolation infiniteClipPostExtrapolation { get; set; } // 0x00000001872406D0-0x00000001872406E0 0x0000000187240720-0x0000000187240730
		internal AnimationPlayableAsset.LoopMode infiniteClipLoop { get; set; } // 0x000000018725F9B0-0x000000018725F9C0 0x000000018725F9E0-0x000000018725F9F0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("openClipOffsetPosition has been deprecated. Use infiniteClipOffsetPosition instead. (UnityUpgradable) -> infiniteClipOffsetPosition", true)]
		public Vector3 openClipOffsetPosition { get; set; } // 0x0000000184F560C0-0x0000000184F560E0 0x0000000184F56120-0x0000000184F56140
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("openClipOffsetRotation has been deprecated. Use infiniteClipOffsetRotation instead. (UnityUpgradable) -> infiniteClipOffsetRotation", true)]
		public Quaternion openClipOffsetRotation { get; set; } // 0x000000018D450190-0x000000018D4501B8 0x000000018D4502F4-0x000000018D450314
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("openClipOffsetEulerAngles has been deprecated. Use infiniteClipOffsetEulerAngles instead. (UnityUpgradable) -> infiniteClipOffsetEulerAngles", true)]
		public Vector3 openClipOffsetEulerAngles { get; set; } // 0x00000001872577E0-0x0000000187257800 0x0000000187257800-0x0000000187257820
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("openClipPreExtrapolation has been deprecated. Use infiniteClipPreExtrapolation instead. (UnityUpgradable) -> infiniteClipPreExtrapolation", true)]
		public TimelineClip.ClipExtrapolation openClipPreExtrapolation { get; set; } // 0x0000000187235AE0-0x0000000187235AF0 0x0000000187235AF0-0x0000000187235B00
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("openClipPostExtrapolation has been deprecated. Use infiniteClipPostExtrapolation instead. (UnityUpgradable) -> infiniteClipPostExtrapolation", true)]
		public TimelineClip.ClipExtrapolation openClipPostExtrapolation { get; set; } // 0x00000001872406D0-0x00000001872406E0 0x0000000187240720-0x0000000187240730
	
		// Nested types
		private static class AnimationTrackUpgrade // TypeDefIndex: 85948
		{
			// Methods
			public static void ConvertRotationsToEuler(AnimationTrack track); // 0x000000018D44BC04-0x000000018D44BC6C
			public static void ConvertRootMotion(AnimationTrack track); // 0x000000018D44BB9C-0x000000018D44BC04
			public static void ConvertInfiniteTrack(AnimationTrack track); // 0x000000018D44BB5C-0x000000018D44BB9C
		}
	
		[CompilerGenerated]
		private sealed class _get_outputs_d__93 : IEnumerable<PlayableBinding>, IEnumerator<PlayableBinding> // TypeDefIndex: 85949
		{
			// Fields
			private int __1__state; // 0x10
			private PlayableBinding __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			public AnimationTrack __4__this; // 0x40
	
			// Properties
			PlayableBinding IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { [DebuggerHidden] get; } // 0x00000001872438D0-0x00000001872438F0 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018D45C5D8-0x000000018D45CEC0 
	
			// Constructors
			[DebuggerHidden]
			public _get_outputs_d__93(int __1__state); // 0x000000018D45B8A8-0x000000018D45B8C4
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D45B6F0-0x000000018D45B774
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D45C58C-0x000000018D45C5D8
			[DebuggerHidden]
			IEnumerator<PlayableBinding> IEnumerable<PlayableBinding>.GetEnumerator(); // 0x000000018D45C4F4-0x000000018D45C584
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D45C584-0x000000018D45C58C
		}
	
		// Constructors
		public AnimationTrack(); // 0x0000000186253CF0-0x0000000186253E90
		static AnimationTrack(); // 0x000000018716E520-0x000000018716E5E0
	
		// Methods
		public override bool ShouldDeferCompile(); // 0x000000018723B260-0x000000018723B270
		public bool IsControlByThisTrack(RuntimeElement element); // 0x000000018D44F9D4-0x000000018D44FA30
		internal override bool CanCompileClips(); // 0x000000018D44D2D8-0x000000018D44D390
		[ContextMenu("Reset Offsets")]
		private void ResetOffsets(); // 0x000000018D44FDDC-0x000000018D44FE0C
		public TimelineClip CreateClip(AnimationClip clip); // 0x000000018D44DB74-0x000000018D44DC08
		public void CreateInfiniteClip(string infiniteClipName); // 0x000000018D44DC80-0x000000018D44DD6C
		public TimelineClip CreateRecordableClip(string animClipName); // 0x000000018D44EE2C-0x000000018D44EF38
		protected override void OnCreateClip(TimelineClip clip); // 0x000000018D44FC80-0x000000018D44FCB8
		protected internal override int CalculateItemsHash(); // 0x000000018D44D264-0x000000018D44D2D8
		internal void UpdateClipOffsets(); // 0x0000000186805BA0-0x0000000186805BB0
		private Playable _CreatePlayableFromClip(TimelineClip c, PlayableGraph graph, GameObject go, AppliedOffsetMode mode, ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding); // 0x000000018D44FF78-0x000000018D450108
		private Playable CompileTrackPlayable(PlayableGraph graph, AnimationTrack track, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode, ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding); // 0x000000018D44D390-0x000000018D44DB74
		private Playable ApplyClipWeightReceiver(PlayableGraph graph, Playable mixer, GameObject go); // 0x000000018D44C0EC-0x000000018D44C398
		private bool ShouldLinkWithMainTrackMixer(AnimationTrack animationTrack); // 0x000000018D44FE0C-0x000000018D44FE90
		private Playable ApplyScriptAnimationPlayable(PlayableGraph graph, AnimationLayerMixerPlayable mixer, GameObject go); // 0x000000018D44C398-0x000000018D44C948
		Playable ILayerable.CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount); // 0x000000018D44FE90-0x000000018D44FEE0
		internal override Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree); // 0x000000018D44E0D4-0x000000018D44EE2C
		private void AttachCustomBlend(PlayableGraph graph, AnimationLayerMixerPlayable layerMixer); // 0x0000000186805BA0-0x0000000186805BB0
		private void AttachLastAdditiveClip(PlayableGraph graph, AnimationLayerMixerPlayable layerMixer, GameObject go, IntervalTree<RuntimeElement> tree, List<AnimationTrack> flattenTracks, ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding); // 0x000000018D44CCB4-0x000000018D44D124
		private int GetDefaultBlendCount(); // 0x00000001872328C0-0x00000001872328D0
		private void AttachDefaultBlend(PlayableGraph graph, AnimationLayerMixerPlayable mixer, bool requireOffset, Animator animator); // 0x0000000186805BA0-0x0000000186805BB0
		private Playable AttachOffsetPlayable(PlayableGraph graph, Playable playable, Vector3 pos, Quaternion rot); // 0x000000018D44D124-0x000000018D44D264
		private bool RequiresMotionXPlayable(AppliedOffsetMode mode, GameObject gameObject); // 0x000000018D44FCF8-0x000000018D44FDDC
		private static bool UsesAbsoluteMotion(AppliedOffsetMode mode); // 0x000000018D44FEE0-0x000000018D44FEF0
		private bool HasController(GameObject gameObject); // 0x000000018D44F8F4-0x000000018D44F9D4
		internal Animator GetBinding(PlayableDirector director); // 0x000000018D44F40C-0x000000018D44F584
		private static AnimationLayerMixerPlayable CreateGroupMixer(PlayableGraph graph, GameObject go, int inputCount); // 0x000000018D44DC08-0x000000018D44DC80
		private Playable CreateInfiniteTrackPlayable(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode); // 0x000000018D44DD6C-0x000000018D44E0D4
		private Playable ApplyTrackOffset(PlayableGraph graph, Playable root, GameObject go, AppliedOffsetMode mode); // 0x000000018D44C948-0x000000018D44CAD0
		private void _AddClipIntoTree(IntervalTree<RuntimeElement> tree, RuntimeClip clip); // 0x000000018D44FEF0-0x000000018D44FF78
		internal override void GetEvaluationTime(out double outStart, out double outDuration); // 0x000000018D44F584-0x000000018D44F614
		internal override void GetSequenceTime(out double outStart, out double outDuration); // 0x000000018D44F820-0x000000018D44F8F4
		private void AssignAnimationClip(TimelineClip clip, AnimationClip animClip); // 0x000000018D44CAD0-0x000000018D44CCB4
		public override void GatherProperties(PlayableDirector director, IPropertyCollector driver); // 0x0000000186805BA0-0x0000000186805BB0
		private void GetAnimationClips(List<AnimationClip> animClips); // 0x000000018D44F0F8-0x000000018D44F40C
		private AppliedOffsetMode GetOffsetMode(GameObject go, bool animatesRootTransform); // 0x000000018D44F7BC-0x000000018D44F820
		private bool IsRootTransformDisabledByMask(GameObject gameObject, Transform genericRootNode); // 0x000000018D44FA30-0x000000018D44FC80
		private Transform GetGenericRootNode(GameObject gameObject); // 0x000000018D44F614-0x000000018D44F7BC
		internal bool AnimatesRootTransform(); // 0x000000018D44BC6C-0x000000018D44C0EC
		private static Transform FindInHierarchyBreadthFirst(Transform t, string name); // 0x000000018D44EF38-0x000000018D44F0F8
		internal override void OnUpgradeFromVersion(int oldVersion); // 0x000000018D44FCB8-0x000000018D44FCF8
	}

	internal interface ICurvesOwner // TypeDefIndex: 85951
	{
		// Properties
		string defaultCurvesName { get; }
		UnityEngine.Object asset { get; }
		UnityEngine.Object assetOwner { get; }
		TrackAsset targetTrack { get; }
	}

	internal sealed class TakeOverAnimationOutputWeightProcessor : ITimelineEvaluateCallback // TypeDefIndex: 85952
	{
		// Fields
		private readonly PlayableOutput m_output; // 0x10
		private readonly Animator m_animator; // 0x20
		private readonly ITimelineRootMarker m_timelineRoot; // 0x28
	
		// Constructors
		public TakeOverAnimationOutputWeightProcessor(AnimationPlayableOutput output, Animator animator, ITimelineRootMarker timelineRoot); // 0x0000000184F59C60-0x0000000184F59D20
	
		// Methods
		public void Evaluate(); // 0x0000000184F595E0-0x0000000184F59C60
	}

	[Serializable]
	public class TimelineClip : ICurvesOwner, ISerializationCallbackReceiver // TypeDefIndex: 85957
	{
		// Fields
		private const int k_LatestVersion = 1; // Metadata: 0x0264538F
		[HideInInspector]
		[SerializeField]
		private int m_Version; // 0x10
		public static readonly ClipCaps kDefaultClipCaps; // 0x00
		public static readonly float kDefaultClipDurationInSeconds; // 0x04
		public static readonly double kTimeScaleMin; // 0x08
		public static readonly double kTimeScaleMax; // 0x10
		internal static readonly string kDefaultCurvesName; // 0x18
		internal static readonly double kMinDuration; // 0x20
		internal static readonly double kMaxTimeValue; // 0x28
		public int optionIndex; // 0x14
		[SerializeField]
		private double m_Start; // 0x18
		[SerializeField]
		private double m_ClipIn; // 0x20
		[SerializeField]
		private UnityEngine.Object m_Asset; // 0x28
		[FormerlySerializedAs("m_HackDuration")]
		[SerializeField]
		private double m_Duration; // 0x30
		[SerializeField]
		private double m_TimeScale; // 0x38
		[SerializeField]
		private TrackAsset m_ParentTrack; // 0x40
		[SerializeField]
		private double m_EaseInDuration; // 0x48
		[SerializeField]
		private double m_EaseOutDuration; // 0x50
		[SerializeField]
		private double m_BlendInDuration; // 0x58
		[SerializeField]
		private double m_BlendOutDuration; // 0x60
		[SerializeField]
		private AnimationCurve m_MixInCurve; // 0x68
		[SerializeField]
		private AnimationCurve m_MixOutCurve; // 0x70
		[SerializeField]
		private BlendCurveMode m_BlendInCurveMode; // 0x78
		[SerializeField]
		private BlendCurveMode m_BlendOutCurveMode; // 0x7C
		[SerializeField]
		private List<string> m_ExposedParameterNames; // 0x80
		[SerializeField]
		private AnimationClip m_AnimationCurves; // 0x88
		[SerializeField]
		private bool m_Recordable; // 0x90
		[SerializeField]
		private ClipExtrapolation m_PostExtrapolationMode; // 0x94
		[SerializeField]
		private ClipExtrapolation m_PreExtrapolationMode; // 0x98
		[SerializeField]
		private double m_PostExtrapolationTime; // 0xA0
		[SerializeField]
		private double m_PreExtrapolationTime; // 0xA8
		[SerializeField]
		private string m_DisplayName; // 0xB0
	
		// Properties
		public double timeScale { get; } // 0x000000018D454D58-0x000000018D454E1C 
		public double start { get; set; } // 0x0000000187233020-0x0000000187233030 0x000000018D4550F0-0x000000018D4551DC
		public double duration { get; set; } // 0x0000000187233310-0x0000000187233320 0x000000018D454E1C-0x000000018D454EB0
		public double end { get; } // 0x000000018725FA80-0x000000018725FA90 
		public double clipIn { get; } // 0x000000018D454924-0x000000018D454948 
		public string displayName { get; set; } // 0x0000000187232F90-0x0000000187232FA0 0x0000000185017130-0x0000000185017150
		public double clipAssetDuration { get; } // 0x000000018D454854-0x000000018D4548AC 
		public AnimationClip curves { get; } // 0x0000000187232F50-0x0000000187232F60 
		string ICurvesOwner.defaultCurvesName { get; } // 0x000000018D454784-0x000000018D4547D4 
		public UnityEngine.Object asset { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		UnityEngine.Object ICurvesOwner.assetOwner { get; } // 0x000000018226EEA0-0x000000018226EEB0 
		TrackAsset ICurvesOwner.targetTrack { get; } // 0x000000018226EEA0-0x000000018226EEB0 
		public double easeInDuration { get; set; } // 0x000000018D454948-0x000000018D4549DC 0x000000018D454EB0-0x000000018D454F94
		public double easeOutDuration { get; set; } // 0x000000018D4549DC-0x000000018D454A70 0x000000018D454F94-0x000000018D455078
		public double blendInDuration { get; } // 0x000000018D45480C-0x000000018D454830 
		public double blendOutDuration { get; } // 0x000000018D454830-0x000000018D454854 
		public bool hasBlendIn { get; } // 0x000000018D454B4C-0x000000018D454B7C 
		public bool hasBlendOut { get; } // 0x000000018D454B7C-0x000000018D454BAC 
		public AnimationCurve mixInCurve { get; set; } // 0x000000018D454BAC-0x000000018D454C14 0x0000000186B19440-0x0000000186B19450
		public double mixInDuration { get; } // 0x000000018D454C14-0x000000018D454C44 
		public AnimationCurve mixOutCurve { get; set; } // 0x000000018D454C44-0x000000018D454CAC 0x0000000188800CD0-0x0000000188800CE0
		public double mixOutTime { get; } // 0x000000018D454CDC-0x000000018D454D10 
		public double mixOutDuration { get; } // 0x000000018D454CAC-0x000000018D454CDC 
		public bool recordable { get; internal set; } // 0x000000018226EDA0-0x000000018226EDB0 0x000000018226EDB0-0x000000018226EDC0
		public ClipCaps clipCaps { get; } // 0x000000018D4548AC-0x000000018D454924 
		public ClipExtrapolation postExtrapolationMode { get; set; } // 0x000000018D454D10-0x000000018D454D34 0x000000018D455078-0x000000018D4550B4
		public ClipExtrapolation preExtrapolationMode { get; set; } // 0x000000018D454D34-0x000000018D454D58 0x000000018D4550B4-0x000000018D4550F0
		public double extrapolatedStart { get; } // 0x000000018D454B34-0x000000018D454B4C 
		public double extrapolatedDuration { get; } // 0x000000018D454A70-0x000000018D454B34 
	
		// Nested types
		private enum Versions // TypeDefIndex: 85953
		{
			Initial = 0,
			ClipInFromGlobalToLocal = 1
		}
	
		private static class TimelineClipUpgrade // TypeDefIndex: 85954
		{
			// Methods
			public static void UpgradeClipInFromGlobalToLocal(TimelineClip clip); // 0x000000018D453E8C-0x000000018D453EC8
		}
	
		public enum ClipExtrapolation // TypeDefIndex: 85955
		{
			None = 0,
			Hold = 1,
			Loop = 2,
			PingPong = 3,
			Continue = 4
		}
	
		public enum BlendCurveMode // TypeDefIndex: 85956
		{
			Auto = 0,
			Manual = 1
		}
	
		// Constructors
		internal TimelineClip(TrackAsset parent); // 0x000000018D4547E4-0x000000018D45480C
		static TimelineClip(); // 0x00000001870BDE70-0x00000001870BDF70
	
		// Methods
		private void UpgradeToLatestVersion(); // 0x000000018D4547D4-0x000000018D4547E4
		public TrackAsset GetParentTrack(); // 0x000000018226EEA0-0x000000018226EEB0
		internal void SetParentTrack_Internal(TrackAsset newParentTrack); // 0x000000018D45441C-0x000000018D4544FC
		internal int Hash(); // 0x000000018D4541D8-0x000000018D454284
		public float EvaluateMixOut(double time); // 0x000000018D453F84-0x000000018D454048
		public float EvaluateMixIn(double time); // 0x000000018D453EC8-0x000000018D453F84
		private static AnimationCurve GetDefaultMixInCurve(); // 0x000000018D454048-0x000000018D454070
		private static AnimationCurve GetDefaultMixOutCurve(); // 0x000000018D454070-0x000000018D454098
		public double ToLocalTime(double time); // 0x000000018D4544FC-0x000000018D454608
		private static double SanitizeTimeValue(double value, double defaultValue); // 0x000000018D454324-0x000000018D45441C
		internal void SetPostExtrapolationTime(double time); // 0x000000018725FA60-0x000000018725FA70
		internal void SetPreExtrapolationTime(double time); // 0x000000018725FA70-0x000000018725FA80
		public bool IsPreExtrapolatedTime(double sequenceTime); // 0x000000018D4542DC-0x000000018D454324
		public bool IsPostExtrapolatedTime(double sequenceTime); // 0x000000018D454284-0x000000018D4542DC
		private static double GetExtrapolatedTime(double time, ClipExtrapolation mode, double duration); // 0x000000018D454098-0x000000018D4541D8
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x0000000187236030-0x0000000187236040
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x0000000186A9C4A0-0x0000000186A9C4C0
		public override string ToString(); // 0x000000018D454608-0x000000018D454784
		private void UpdateDirty(double oldValue, double newValue); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	[ExcludeFromPreset]
	public class TimelineAsset : PlayableAsset, ISerializationCallbackReceiver, ITimelineClipAsset, IPropertyPreview // TypeDefIndex: 85964
	{
		// Fields
		private const int k_LatestVersion = 0; // Metadata: 0x02645399
		[HideInInspector]
		[SerializeField]
		private int m_Version; // 0x18
		[HideInInspector]
		[SerializeField]
		private List<ScriptableObject> m_Tracks; // 0x20
		[HideInInspector]
		[SerializeField]
		private double m_FixedDuration; // 0x28
		[NonSerialized]
		[HideInInspector]
		private TrackAsset[] m_CacheOutputTracks; // 0x30
		[NonSerialized]
		[HideInInspector]
		private GroupTrack[] m_CacheGroupTracks; // 0x38
		[NonSerialized]
		[HideInInspector]
		private List<TrackAsset> m_CacheRootTracks; // 0x40
		[NonSerialized]
		[HideInInspector]
		private TrackAsset[] m_CacheFlattenedTracks; // 0x48
		[HideInInspector]
		[SerializeField]
		private EditorSettings m_EditorSettings; // 0x50
		[SerializeField]
		private DurationMode m_DurationMode; // 0x58
		[HideInInspector]
		[SerializeField]
		private MarkerTrack m_MarkerTrack; // 0x60
	
		// Properties
		public EditorSettings editorSettings { get; } // 0x000000018226EBD0-0x000000018226EBE0 
		public override double duration { get; } // 0x000000018D453AF4-0x000000018D453B74 
		public double fixedDuration { get; set; } // 0x000000018D453B74-0x000000018D453BF4 0x000000018D453E34-0x000000018D453E8C
		public DurationMode durationMode { get; set; } // 0x00000001872331A0-0x00000001872331B0 0x0000000185B8E8A0-0x0000000185B8EB10
		public override IEnumerable<PlayableBinding> outputs { [IteratorStateMachine(typeof(_get_outputs_d__28))] get; } // 0x000000018D453D7C-0x000000018D453DEC 
		public ClipCaps clipCaps { get; } // 0x000000018D4538D4-0x000000018D453AF4 
		public int outputTrackCount { get; } // 0x000000018D453D54-0x000000018D453D7C 
		public int rootTrackCount { get; } // 0x000000018D453DEC-0x000000018D453E34 
		internal TrackAsset[] flattenedTracks { get; } // 0x000000018D453BF4-0x000000018D453D54 
		public MarkerTrack markerTrack { get; } // 0x0000000187232FA0-0x0000000187232FB0 
		internal List<ScriptableObject> trackObjects { get; } // 0x000000018225E800-0x000000018225E810 
	
		// Nested types
		private enum Versions // TypeDefIndex: 85958
		{
			Initial = 0
		}
	
		private static class TimelineAssetUpgrade // TypeDefIndex: 85959
		{
		}
	
		[Obsolete("MediaType has been deprecated. It is no longer required, and will be removed in a future release.", false)]
		public enum MediaType // TypeDefIndex: 85960
		{
			Animation = 0,
			Audio = 1,
			Texture = 2,
			Video = 2,
			Script = 3,
			Hybrid = 4,
			Group = 5
		}
	
		public enum DurationMode // TypeDefIndex: 85961
		{
			BasedOnClips = 0,
			FixedLength = 1
		}
	
		[Serializable]
		public class EditorSettings // TypeDefIndex: 85962
		{
			// Fields
			internal static readonly double kMinFrameRate; // 0x00
			internal static readonly double kMaxFrameRate; // 0x08
			internal static readonly double kDefaultFrameRate; // 0x10
			[FrameRateField]
			[HideInInspector]
			[SerializeField]
			private double m_Framerate; // 0x10
			[HideInInspector]
			[SerializeField]
			private bool m_ScenePreview; // 0x18
	
			// Properties
			public double frameRate { get; set; } // 0x0000000187244520-0x0000000187244530 0x000000018D45116C-0x000000018D45118C
	
			// Constructors
			public EditorSettings(); // 0x00000001862544E0-0x0000000186254550
			static EditorSettings(); // 0x000000018717B870-0x000000018717B920
		}
	
		[CompilerGenerated]
		private sealed class _get_outputs_d__28 : IEnumerable<PlayableBinding>, IEnumerator<PlayableBinding> // TypeDefIndex: 85963
		{
			// Fields
			private int __1__state; // 0x10
			private PlayableBinding __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			public TimelineAsset __4__this; // 0x40
			private IEnumerator<TrackAsset> __7__wrap1; // 0x48
			private IEnumerator<PlayableBinding> __7__wrap2; // 0x50
	
			// Properties
			PlayableBinding IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { [DebuggerHidden] get; } // 0x00000001872438D0-0x00000001872438F0 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018D45BFE8-0x000000018D45C038 
	
			// Constructors
			[DebuggerHidden]
			public _get_outputs_d__28(int __1__state); // 0x000000018D45B8A8-0x000000018D45B8C4
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018D45C038-0x000000018D45C128
			private bool MoveNext(); // 0x000000018D45BA7C-0x000000018D45BF04
			private void __m__Finally1(); // 0x000000018D45C128-0x000000018D45C174
			private void __m__Finally2(); // 0x000000018D45C174-0x000000018D45C1C0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D45BF9C-0x000000018D45BFE8
			[DebuggerHidden]
			IEnumerator<PlayableBinding> IEnumerable<PlayableBinding>.GetEnumerator(); // 0x000000018D45BF04-0x000000018D45BF94
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D45BF94-0x000000018D45BF9C
		}
	
		// Constructors
		public TimelineAsset(); // 0x0000000186253C80-0x0000000186253CF0
	
		// Methods
		private void UpgradeToLatestVersion(); // 0x0000000186805BA0-0x0000000186805BB0
		private void OnValidate(); // 0x000000018D453290-0x000000018D4532C4
		public TrackAsset GetRootTrack(int index); // 0x000000018D452CEC-0x000000018D452D48
		public IEnumerable<TrackAsset> GetRootTracks(); // 0x000000018D452D48-0x000000018D452D64
		public TrackAsset GetOutputTrack(int index); // 0x000000018D452C8C-0x000000018D452CD0
		public IEnumerable<TrackAsset> GetOutputTracks(); // 0x000000018D452CD0-0x000000018D452CEC
		public IEnumerable<GroupTrack> GetGroupTracks(); // 0x000000018D452C70-0x000000018D452C8C
		private static double GetValidFrameRate(double frameRate); // 0x000000018D452D64-0x000000018D452E04
		private void UpdateRootTrackCache(); // 0x000000018D45363C-0x000000018D4538D4
		private void UpdateOutputTrackCache(); // 0x000000018D4533E0-0x000000018D45363C
		public TrackAsset[] GetAllTracks(); // 0x000000018D452C68-0x000000018D452C70
		internal void AddTrackInternal(TrackAsset track); // 0x000000018D4517C4-0x000000018D451834
		internal void RemoveTrack(TrackAsset track); // 0x000000018D4532C4-0x000000018D453384
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go); // 0x000000018D451CA0-0x000000018D451FB0
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018725FA50-0x000000018725FA60
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001861EFF80-0x00000001861EFF90
		private void __internalAwake(); // 0x000000018699AAF0-0x000000018699ACF0
		public void GatherProperties(PlayableDirector director, IPropertyCollector driver); // 0x000000018D452AF8-0x000000018D452C68
		public void CreateMarkerTrack(); // 0x000000018D451BCC-0x000000018D451CA0
		internal void Invalidate(); // 0x00000001861F0580-0x00000001861F05C0
		internal void UpdateFixedDurationWithItemsDuration(); // 0x000000018D453384-0x000000018D4533E0
		private DiscreteTime CalculateItemsDuration(); // 0x000000018D451A90-0x000000018D451BCC
		private static void AddSubTracksRecursive(TrackAsset track, ref List<TrackAsset> allTracks); // 0x000000018D4515E0-0x000000018D4517C4
		public TrackAsset CreateTrack(System.Type type, TrackAsset parent, string name); // 0x000000018D451FB0-0x000000018D4522D0
		public T CreateTrack<T>(TrackAsset parent, string trackName)
			where T : TrackAsset, new();
		public T CreateTrack<T>(string trackName)
			where T : TrackAsset, new();
		public T CreateTrack<T>()
			where T : TrackAsset, new();
		public bool DeleteClip(TimelineClip clip); // 0x000000018D4522D0-0x000000018D45246C
		public bool DeleteTrack(TrackAsset track); // 0x000000018D45275C-0x000000018D452AF8
		internal void MoveLastTrackBefore(TrackAsset asset); // 0x000000018D452E04-0x000000018D452FC0
		public void MoveTrackAfter(TrackAsset trackToMove, TrackAsset targetTrack); // 0x000000018D4530A0-0x000000018D453290
		private static bool MoveTrackAfterInList(List<ScriptableObject> siblingTracks, TrackAsset trackToMove, TrackAsset targetTrack); // 0x000000018D452FC0-0x000000018D4530A0
		private TrackAsset AllocateTrack(TrackAsset trackAssetParent, string trackName, System.Type trackType); // 0x000000018D451834-0x000000018D451A90
		private void DeleteRecordedAnimation(TrackAsset track); // 0x000000018D45246C-0x000000018D452570
		private void DeleteRecordedAnimation(TimelineClip clip); // 0x000000018D452570-0x000000018D45275C
	}

	[Serializable]
	[IgnoreOnPlayableTrack]
	[SupportsChildTracks(null, 2147483647)]
	public abstract class TrackAsset : PlayableAsset, ISerializationCallbackReceiver, IPropertyPreview, ICurvesOwner, IDynamicBinding // TypeDefIndex: 85970
	{
		// Fields
		private const int k_LatestVersion = 3; // Metadata: 0x026453A4
		[HideInInspector]
		[SerializeField]
		private int m_Version; // 0x18
		[FormerlySerializedAs("m_animClip")]
		[HideInInspector]
		[Obsolete("Please use m_InfiniteClip (on AnimationTrack) instead.", false)]
		[SerializeField]
		internal AnimationClip m_AnimClip; // 0x20
		public bool useAutoBinding; // 0x28
		public string autoBindingPath; // 0x30
		public string uniqueId; // 0x38
		public List<string> childUniqueIds; // 0x40
		public int uiBindingType; // 0x48
		private static TransientBuildData s_BuildData; // 0x00
		internal const string kDefaultCurvesName = "Track Parameters"; // Metadata: 0x026453A5
		[CompilerGenerated]
		private static Action<TimelineClip, GameObject, Playable> OnClipPlayableCreate; // 0x18
		[CompilerGenerated]
		private static Action<TrackAsset, GameObject, Playable> OnTrackAnimationPlayableCreate; // 0x20
		private bool m_RuntimeMuted; // 0x4C
		[HideInInspector]
		[SerializeField]
		private bool m_Locked; // 0x4D
		[HideInInspector]
		[SerializeField]
		private bool m_Muted; // 0x4E
		[HideInInspector]
		[SerializeField]
		private string m_CustomPlayableFullTypename; // 0x50
		[HideInInspector]
		[SerializeField]
		private AnimationClip m_Curves; // 0x58
		[HideInInspector]
		[SerializeField]
		private PlayableAsset m_Parent; // 0x60
		[HideInInspector]
		[SerializeField]
		private List<ScriptableObject> m_Children; // 0x68
		[NonSerialized]
		private int m_ItemsHash; // 0x70
		[NonSerialized]
		private TimelineClip[] m_ClipsCache; // 0x78
		private DiscreteTime m_Start; // 0x80
		private DiscreteTime m_End; // 0x88
		private bool m_CacheSorted; // 0x90
		private bool? m_SupportsNotifications; // 0x91
		private static TrackAsset[] s_EmptyCache; // 0x28
		private IEnumerable<TrackAsset> m_ChildTrackCache; // 0x98
		private static Dictionary<System.Type, TrackBindingTypeAttribute> s_TrackBindingTypeAttributeCache; // 0x30
		[HideInInspector]
		[SerializeField]
		protected internal List<TimelineClip> m_Clips; // 0xA0
		[HideInInspector]
		[SerializeField]
		private MarkerList m_Markers; // 0xA8
		public int OptionIndex; // 0xC0
		[NonSerialized]
		public bool useRuntimeMuted; // 0xC4
	
		// Properties
		public double start { get; } // 0x000000018D45B35C-0x000000018D45B3B0 
		public double end { get; } // 0x000000018D45AED8-0x000000018D45AF2C 
		public sealed override double duration { get; } // 0x000000018D45AE74-0x000000018D45AED8 
		public virtual bool muted { get; set; } // 0x000000018D45B2C4-0x000000018D45B2EC 0x0000000187253830-0x0000000187253840
		public virtual bool runtimeMuted { get; set; } // 0x000000018226EC80-0x000000018226EC90 0x000000018226EC90-0x000000018226ECA0
		public bool mutedInHierarchy { get; } // 0x000000018D45B1CC-0x000000018D45B2C4 
		public TimelineAsset timelineAsset { get; } // 0x00000001861F0380-0x00000001861F0580 
		public PlayableAsset parent { get; set; } // 0x0000000187232FA0-0x0000000187232FB0 0x0000000188800CB0-0x0000000188800CC0
		internal TimelineClip[] clips { get; } // 0x000000018D45ADA8-0x000000018D45AE74 
		public virtual bool isEmpty { get; } // 0x000000018D45AFE4-0x000000018D45B020 
		public bool hasClips { get; } // 0x000000018D45AF2C-0x000000018D45AF74 
		public bool hasCurves { get; } // 0x000000018D45AF74-0x000000018D45AFE4 
		public bool isSubTrack { get; } // 0x000000018D45B020-0x000000018D45B0E0 
		public override IEnumerable<PlayableBinding> outputs { [IteratorStateMachine(typeof(_get_outputs_d__77))] get; } // 0x000000018D45B2EC-0x000000018D45B35C 
		internal string customPlayableTypename { get; set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		public AnimationClip curves { get; internal set; } // 0x0000000187232F70-0x0000000187232F80 0x00000001856B9750-0x00000001856B9760
		string ICurvesOwner.defaultCurvesName { get; } // 0x000000018D45A788-0x000000018D45A7B4 
		UnityEngine.Object ICurvesOwner.asset { get; } // 0x0000000185BD80B0-0x0000000185BD80C0 
		UnityEngine.Object ICurvesOwner.assetOwner { get; } // 0x000000018D45A780-0x000000018D45A788 
		TrackAsset ICurvesOwner.targetTrack { get; } // 0x0000000185BD80B0-0x0000000185BD80C0 
		internal List<ScriptableObject> subTracksObjects { get; } // 0x0000000187232F80-0x0000000187232F90 
		public bool locked { get; set; } // 0x0000000182308F10-0x0000000182308F20 0x0000000182308F20-0x0000000182308F30
		public bool lockedInHierarchy { get; } // 0x000000018D45B0E0-0x000000018D45B1CC 
		public bool supportsNotifications { get; } // 0x000000018D45B3B0-0x000000018D45B438 
	
		// Events
		internal static event Action<TimelineClip, GameObject, Playable> OnClipPlayableCreate {
			add; // 0x000000018D45AC18-0x000000018D45ACE0
			remove; // 0x000000018D45B438-0x000000018D45B500
		}
		internal static event Action<TrackAsset, GameObject, Playable> OnTrackAnimationPlayableCreate {
			add; // 0x000000018D45ACE0-0x000000018D45ADA8
			remove; // 0x000000018D45B500-0x000000018D45B5C8
		}
	
		// Nested types
		internal enum Versions // TypeDefIndex: 85965
		{
			Initial = 0,
			RotationAsEuler = 1,
			RootMotionUpgrade = 2,
			AnimatedTrackProperties = 3
		}
	
		private static class TrackAssetUpgrade // TypeDefIndex: 85966
		{
		}
	
		private struct TransientBuildData // TypeDefIndex: 85967
		{
			// Fields
			public List<TrackAsset> trackList; // 0x00
			public List<TimelineClip> clipList; // 0x08
			public List<IMarker> markerList; // 0x10
	
			// Methods
			public static TransientBuildData Create(); // 0x0000000186253A80-0x0000000186253BB0
			public void Clear(); // 0x000000018D45B5C8-0x000000018D45B650
		}
	
		[CompilerGenerated]
		private sealed class _get_outputs_d__77 : IEnumerable<PlayableBinding>, IEnumerator<PlayableBinding> // TypeDefIndex: 85968
		{
			// Fields
			private int __1__state; // 0x10
			private PlayableBinding __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			public TrackAsset __4__this; // 0x40
	
			// Properties
			PlayableBinding IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { [DebuggerHidden] get; } // 0x00000001872438D0-0x00000001872438F0 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018D45C4A4-0x000000018D45C4F4 
	
			// Constructors
			[DebuggerHidden]
			public _get_outputs_d__77(int __1__state); // 0x000000018D45B8A8-0x000000018D45B8C4
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D45C1C0-0x000000018D45C3C0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D45C458-0x000000018D45C4A4
			[DebuggerHidden]
			IEnumerator<PlayableBinding> IEnumerable<PlayableBinding>.GetEnumerator(); // 0x000000018D45C3C0-0x000000018D45C450
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D45C450-0x000000018D45C458
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 85969
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<TimelineClip> __9__134_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D45B68C-0x000000018D45B6F0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _SortClips_b__134_0(TimelineClip clip1, TimelineClip clip2); // 0x000000018D45B650-0x000000018D45B68C
		}
	
		// Constructors
		protected TrackAsset(); // 0x0000000186254030-0x0000000186254180
		static TrackAsset(); // 0x0000000186253960-0x0000000186253A80
	
		// Methods
		protected virtual void OnBeforeTrackSerialize(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnAfterTrackDeserialize(); // 0x0000000186805BA0-0x0000000186805BB0
		internal virtual void OnUpgradeFromVersion(int oldVersion); // 0x0000000186805BA0-0x0000000186805BB0
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018D45A66C-0x000000018D45A780
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001861EFF90-0x00000001861F0210
		private void UpgradeToLatestVersion(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual bool ShouldDeferCompile(); // 0x00000001843FFFF0-0x0000000184400000
		public IEnumerable<TimelineClip> GetClips(); // 0x000000018D459954-0x000000018D45995C
		public IEnumerable<TrackAsset> GetChildTracks(); // 0x000000018D4595DC-0x000000018D4595FC
		private void __internalAwake(); // 0x000000018668B5B0-0x000000018668B640
		public void CreateCurves(string curvesClipName); // 0x000000018D4575FC-0x000000018D45769C
		public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount); // 0x000000018D458BE4-0x000000018D458C54
		public sealed override Playable CreatePlayable(PlayableGraph graph, GameObject go); // 0x000000018D458920-0x000000018D458970
		public TimelineClip CreateDefaultClip(); // 0x000000018D45769C-0x000000018D4578C0
		public TimelineClip CreateClip<T>()
			where T : ScriptableObject, IPlayableAsset;
		public bool DeleteClip(TimelineClip clip); // 0x000000018D458C54-0x000000018D458D64
		public IMarker CreateMarker(System.Type type, double time); // 0x000000018D457A00-0x000000018D457A24
		public T CreateMarker<T>(double time)
			where T : ScriptableObject, IMarker;
		public bool DeleteMarker(IMarker marker); // 0x000000018D458DA4-0x000000018D458DB4
		public IEnumerable<IMarker> GetMarkers(); // 0x00000001861F0210-0x00000001861F02C0
		public IEnumerable<IMarker> GetClipMarkers(); // 0x000000018D4595FC-0x000000018D45980C
		public int GetMarkerCount(); // 0x000000018D459C90-0x000000018D459CA0
		public IMarker GetMarker(int idx); // 0x000000018D459CA0-0x000000018D459CB0
		internal TimelineClip CreateClip(System.Type requestedType); // 0x000000018D4574DC-0x000000018D4575FC
		internal TimelineClip CreateAndAddNewClipOfType(System.Type requestedType); // 0x000000018D456E24-0x000000018D456E58
		internal TimelineClip CreateClipOfType(System.Type requestedType); // 0x000000018D4572C0-0x000000018D4574DC
		internal TimelineClip CreateClipFromPlayableAsset(IPlayableAsset asset); // 0x000000018D45707C-0x000000018D4572C0
		private TimelineClip CreateClipFromAsset(ScriptableObject playableAsset); // 0x000000018D456E58-0x000000018D45707C
		internal IEnumerable<ScriptableObject> GetMarkersRaw(); // 0x0000000187232FB0-0x0000000187232FC0
		internal void ClearMarkers(); // 0x000000018D4568B0-0x000000018D4568C0
		internal void AddMarker(ScriptableObject e); // 0x000000018D4565A0-0x000000018D4565B0
		internal bool DeleteMarkerRaw(ScriptableObject marker); // 0x000000018D458D64-0x000000018D458DA4
		private int GetTimeRangeHash(); // 0x000000018D459E1C-0x000000018D459F64
		internal void AddClip(TimelineClip newClip); // 0x000000018D45650C-0x000000018D4565A0
		private Playable CreateNotificationsPlayable(PlayableGraph graph, Playable mixerPlayable, GameObject go, Playable timelinePlayable); // 0x000000018D458310-0x000000018D458670
		internal Playable CreatePlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, Playable timelinePlayable); // 0x000000018D458670-0x000000018D458920
		internal virtual Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree); // 0x000000018D456940-0x000000018D456CE8
		private void GatherCompilableTracks(IList<TrackAsset> tracks); // 0x000000018D458DB4-0x000000018D458F84
		private void GatherNotifications(List<IMarker> markers); // 0x000000018D458F84-0x000000018D459190
		internal virtual Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree); // 0x000000018D457A24-0x000000018D4580CC
		internal void ConfigureTrackAnimation(IntervalTree<RuntimeElement> tree, GameObject go, Playable blend); // 0x000000018D456CE8-0x000000018D456E24
		internal void SortClips(); // 0x000000018D45A52C-0x000000018D45A66C
		internal void ClearClipsInternal(); // 0x000000018D456824-0x000000018D4568B0
		internal void ClearSubTracksInternal(); // 0x000000018D4568C0-0x000000018D456940
		internal void OnClipMove(); // 0x000000018723FD20-0x000000018723FD30
		internal TimelineClip CreateNewClipContainerInternal(); // 0x000000018D4580CC-0x000000018D458310
		internal void AddChild(TrackAsset child); // 0x000000018D456470-0x000000018D45650C
		internal void MoveLastTrackBefore(TrackAsset asset); // 0x000000018D45A288-0x000000018D45A444
		internal bool RemoveSubTrack(TrackAsset child); // 0x000000018D45A4AC-0x000000018D45A52C
		internal void RemoveClip(TimelineClip clip); // 0x000000018D45A444-0x000000018D45A4AC
		internal virtual void GetEvaluationTime(out double outStart, out double outDuration); // 0x000000018D45995C-0x000000018D459B84
		internal virtual void GetSequenceTime(out double outStart, out double outDuration); // 0x000000018D459E04-0x000000018D459E1C
		public virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver); // 0x000000018D459190-0x000000018D45951C
		internal GameObject GetGameObjectBinding(PlayableDirector director); // 0x000000018D459B84-0x000000018D459C90
		internal bool ValidateClipType(System.Type clipType); // 0x000000018D45AA10-0x000000018D45AC18
		protected virtual void OnCreateClip(TimelineClip clip); // 0x0000000186805BA0-0x0000000186805BB0
		private void UpdateDuration(); // 0x000000018D45A940-0x000000018D45AA10
		protected internal virtual int CalculateItemsHash(); // 0x000000018D4565B0-0x000000018D456648
		protected virtual Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip); // 0x000000018D458970-0x000000018D458BE4
		internal virtual Playable AfterCompileClips(PlayableGraph graph, GameObject gameObject, IList<TimelineClip> clips, IntervalTree<RuntimeElement> tree, Playable trackRoot); // 0x0000000184F59D20-0x0000000184F59D60
		internal void Invalidate(); // 0x00000001861F02C0-0x00000001861F0380
		internal double GetNotificationDuration(); // 0x000000018D459CB0-0x000000018D459E04
		internal virtual bool CanCompileClips(); // 0x000000018D456648-0x000000018D456684
		public bool HasChildTracks(); // 0x000000018D459F64-0x000000018D459FAC
		public virtual bool CanCreateTrackMixer(); // 0x000000018D456814-0x000000018D456824
		internal bool IsCompilable(); // 0x000000018D45A080-0x000000018D45A288
		private void UpdateChildTrackCache(); // 0x000000018D45A7B4-0x000000018D45A940
		internal virtual int Hash(); // 0x000000018D45A03C-0x000000018D45A080
		private int GetClipsHash(); // 0x000000018D45980C-0x000000018D459954
		protected static int GetAnimationClipHash(AnimationClip clip); // 0x000000018D45951C-0x000000018D4595DC
		private bool HasNotifications(); // 0x000000018D459FAC-0x000000018D45A03C
		private bool CanCompileNotifications(); // 0x000000018D456684-0x000000018D4566B0
		private bool CanCreateMixerRecursive(); // 0x000000018D4566B0-0x000000018D456814
		public Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount); // 0x000000018D4578C0-0x000000018D457A00
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ForbidScriptDefaultValueWhenExportAttribute : Attribute // TypeDefIndex: 85971
	{
		// Constructors
		public ForbidScriptDefaultValueWhenExportAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Conditional("UNITY_EDITOR")]
	internal class TimelineHelpURLAttribute : Attribute // TypeDefIndex: 85972
	{
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class TrackColorAttribute : Attribute // TypeDefIndex: 85973
	{
		// Fields
		private UnityEngine.Color m_Color; // 0x10
	
		// Constructors
		public TrackColorAttribute(float r, float g, float b); // 0x0000000186C1A930-0x0000000186C1A970
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class UseScriptDefaultValueWhenExportAttribute : Attribute // TypeDefIndex: 85974
	{
		// Constructors
		public UseScriptDefaultValueWhenExportAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	[UnityEngine.Timeline.NotKeyable]
	internal class AudioClipProperties : PlayableBehaviour // TypeDefIndex: 85975
	{
		// Fields
		[Range(0f, 1f)]
		public float volume; // 0x10
	
		// Constructors
		public AudioClipProperties(); // 0x0000000187233CE0-0x0000000187233CF0
	}

	[Serializable]
	internal class AudioMixerProperties : PlayableBehaviour // TypeDefIndex: 85976
	{
		// Fields
		[Range(0f, 1f)]
		public float volume; // 0x10
		[Range(-1f, 1f)]
		public float stereoPan; // 0x14
		[Range(0f, 1f)]
		public float spatialBlend; // 0x18
	
		// Constructors
		public AudioMixerProperties(); // 0x0000000187233CE0-0x0000000187233CF0
	
		// Methods
		public override void PrepareFrame(Playable playable, FrameData info); // 0x000000018D450404-0x000000018D450694
	}

	[Serializable]
	public class AudioPlayableAsset : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 85978
	{
		// Fields
		[SerializeField]
		private AudioClip m_Clip; // 0x18
		[SerializeField]
		private bool m_Loop; // 0x20
		[HideInInspector]
		[SerializeField]
		private float m_bufferingTime; // 0x24
		[SerializeField]
		private AudioClipProperties m_ClipProperties; // 0x28
	
		// Properties
		internal float bufferingTime { get; set; } // 0x0000000187236710-0x0000000187236720 0x0000000187236720-0x0000000187236730
		public AudioClip clip { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public bool loop { get; set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
		public override double duration { get; } // 0x000000018D450834-0x000000018D4508DC 
		public override IEnumerable<PlayableBinding> outputs { [IteratorStateMachine(typeof(_get_outputs_d__16))] get; } // 0x000000018D4508DC-0x000000018D45094C 
		public ClipCaps clipCaps { get; } // 0x000000018D450824-0x000000018D450834 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _get_outputs_d__16 : IEnumerable<PlayableBinding>, IEnumerator<PlayableBinding> // TypeDefIndex: 85977
		{
			// Fields
			private int __1__state; // 0x10
			private PlayableBinding __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			public AudioPlayableAsset __4__this; // 0x40
	
			// Properties
			PlayableBinding IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { [DebuggerHidden] get; } // 0x00000001872438D0-0x00000001872438F0 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018D45BA2C-0x000000018D45BA7C 
	
			// Constructors
			[DebuggerHidden]
			public _get_outputs_d__16(int __1__state); // 0x000000018D45B8A8-0x000000018D45B8C4
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D45B8C4-0x000000018D45B948
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D45B9E0-0x000000018D45BA2C
			[DebuggerHidden]
			IEnumerator<PlayableBinding> IEnumerable<PlayableBinding>.GetEnumerator(); // 0x000000018D45B948-0x000000018D45B9D8
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D45B9D8-0x000000018D45B9E0
		}
	
		// Constructors
		public AudioPlayableAsset(); // 0x000000018D4507BC-0x000000018D450824
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go); // 0x000000018D450694-0x000000018D4507BC
	}

	[Serializable]
	[ExcludeFromPreset]
	[TrackBindingType(typeof(AudioSource))]
	[TrackClipType(typeof(AudioPlayableAsset), false)]
	public class AudioTrack : TrackAsset // TypeDefIndex: 85980
	{
		// Fields
		[SerializeField]
		private AudioMixerProperties m_TrackProperties; // 0xC8
	
		// Properties
		public override IEnumerable<PlayableBinding> outputs { [IteratorStateMachine(typeof(_get_outputs_d__4))] get; } // 0x000000018D451088-0x000000018D4510F8 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _get_outputs_d__4 : IEnumerable<PlayableBinding>, IEnumerator<PlayableBinding> // TypeDefIndex: 85979
		{
			// Fields
			private int __1__state; // 0x10
			private PlayableBinding __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			public AudioTrack __4__this; // 0x40
	
			// Properties
			PlayableBinding IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { [DebuggerHidden] get; } // 0x00000001872438D0-0x00000001872438F0 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018D474570-0x000000018D4746D4 
	
			// Constructors
			[DebuggerHidden]
			public _get_outputs_d__4(int __1__state); // 0x000000018D45B8A8-0x000000018D45B8C4
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D45B8C4-0x000000018D45B948
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D474524-0x000000018D474570
			[DebuggerHidden]
			IEnumerator<PlayableBinding> IEnumerable<PlayableBinding>.GetEnumerator(); // 0x000000018D47448C-0x000000018D47451C
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D47451C-0x000000018D474524
		}
	
		// Constructors
		public AudioTrack(); // 0x000000018D451008-0x000000018D451088
	
		// Methods
		public TimelineClip CreateClip(AudioClip clip); // 0x000000018D450E88-0x000000018D450F9C
		internal override Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree); // 0x000000018D45094C-0x000000018D450E88
		private void OnValidate(); // 0x000000018D450F9C-0x000000018D451008
	}

	[Serializable]
	public struct ACConditionDescriptor // TypeDefIndex: 85981
	{
		// Fields
		private int m_ConditionMode; // 0x00
		private string m_ConditionEvent; // 0x08
		private float m_EventTreshold; // 0x10
	}

	public class ACTransitionDescriptor // TypeDefIndex: 85982
	{
		// Constructors
		public ACTransitionDescriptor(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public enum DialogTimelineTrackType // TypeDefIndex: 85983
	{
		Default = 0,
		Morph = 1,
		Animation = 2,
		Offset = 3,
		LookAt = 4
	}

	public static class BeyondCommunicator // TypeDefIndex: 85984
	{
		// Fields
		public static bool setAddonLayerAdditive; // 0x00
		[CompilerGenerated]
		private static Action<Animator, AnimationLayerMixerPlayable, AnimationTrack, ScriptableObject, Transform, CommunicatorParam> _ConnectToJobSync_k__BackingField; // 0x08
		[CompilerGenerated]
		private static Action<ITimelineRootMarker, Animator, float> _TakeOverAnimationOutputWeightEvaluated_k__BackingField; // 0x10
		[CompilerGenerated]
		private static Func<ITimelineRootMarker, object, GameObject, string, bool, bool> _TrySetTrackBindingEntityVisible_k__BackingField; // 0x18
		[CompilerGenerated]
		private static Func<ITimelineRootMarker, object, IReadOnlyList<string>, bool, bool> _TrySetTrackBindingChildEntitiesVisible_k__BackingField; // 0x20
		[CompilerGenerated]
		private static Action<ITimelineRootMarker, object> _ReleaseTrackBindingEntityVisibility_k__BackingField; // 0x28
		[CompilerGenerated]
		private static Func<ITimelineRootMarker, bool> _TimelineGraphPrepared_k__BackingField; // 0x30
	
		// Properties
		public static Action<Animator, AnimationLayerMixerPlayable, AnimationTrack, ScriptableObject, Transform, CommunicatorParam> ConnectToJobSync { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018D460500-0x000000018D460550 0x000000018D4605A0-0x000000018D460600
		public static Action<ITimelineRootMarker, Animator, float> TakeOverAnimationOutputWeightEvaluated { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184F5A090-0x0000000184F5A3A0 0x0000000184F5AD30-0x0000000184F5B0A0
		public static Func<ITimelineRootMarker, object, GameObject, string, bool, bool> TrySetTrackBindingEntityVisible { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184F5A6B0-0x0000000184F5A9C0 0x0000000184F5B410-0x0000000184F5B780
		public static Func<ITimelineRootMarker, object, IReadOnlyList<string>, bool, bool> TrySetTrackBindingChildEntitiesVisible { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184F5A3A0-0x0000000184F5A6B0 0x0000000184F5B0A0-0x0000000184F5B410
		public static Action<ITimelineRootMarker, object> ReleaseTrackBindingEntityVisibility { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184F59D80-0x0000000184F5A090 0x0000000184F5A9C0-0x0000000184F5AD30
		public static Func<ITimelineRootMarker, bool> TimelineGraphPrepared { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018D460550-0x000000018D4605A0 0x000000018D460600-0x000000018D460660
	
		// Constructors
		static BeyondCommunicator(); // 0x0000000187220AF0-0x0000000187220B30
	}

	[Serializable]
	public class BlendMotionDescriptor // TypeDefIndex: 85985
	{
		// Fields
		public AnimationClip motion; // 0x10
		public string poseTimerParam; // 0x18
		public string blendParam; // 0x20
		public float threshold; // 0x28
	
		// Constructors
		public BlendMotionDescriptor(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class BlendTreeDescriptor // TypeDefIndex: 85987
	{
		// Fields
		public DescriptorBlendTreeType blendType; // 0x10
		public List<BlendMotionDescriptor> motionDescriptorList; // 0x18
		[CompilerGenerated]
		private string _speedParameter_k__BackingField; // 0x20
		[CompilerGenerated]
		private bool _speedParameterActive_k__BackingField; // 0x28
	
		// Nested types
		public enum DescriptorBlendTreeType // TypeDefIndex: 85986
		{
			Direct = 0,
			Simple1D = 1,
			Simple2D = 2,
			Complex2D = 3
		}
	
		// Constructors
		public BlendTreeDescriptor(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public interface ITimelineRootMarker // TypeDefIndex: 85988
	{
		// Properties
		PlayableDirector topDirector { get; }
		GameObject rootGo { get; }
		bool allowRuntimeClipReset { get; }
		bool useEarlyUpdate { get; }
		bool enableControlActivationMixer { get; }
		bool enableLoop { get; }
		bool isOptimizingHolding { get; }
		bool enableTimelineAsyncCompile { get; }
		bool isTimelineAsyncCompiling { get; }
		bool isTimelineAsyncCompileComplete { get; }
		bool onlyEvaluateTopDirector { get; }
		float fixedFrameRate { get; }
		float manualTickDeltaTime { get; }
		bool isManualTicking { get; }
		Dictionary<PlayableDirector, ScriptPlayable<DirectorControlPlayable>> director2ControlPlayable { get; set; }
	
		// Methods
		void RegisterLoopSegmentRuntimeClip(string key, RuntimeClip runtimeClip);
		void UpdateAllVFXFollowBoneTools();
		void RegisterAsyncScriptAnimationJobSyncInit(IAsyncScriptAnimationJobSyncInit sync);
	}

	[Serializable]
	public class LayerDescriptor : ScriptableObject // TypeDefIndex: 85989
	{
		// Fields
		public string layerName; // 0x18
		public AvatarMask avatarMask; // 0x20
		public bool isAdditive; // 0x28
		public List<StateDescriptor> stateDescriptors; // 0x30
	
		// Constructors
		public LayerDescriptor(); // 0x0000000185DD6260-0x0000000185DD6270
	}

	[Serializable]
	public class MotionDescriptor // TypeDefIndex: 85990
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
		public MotionDescriptor(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class StateDescriptor // TypeDefIndex: 85991
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
		public StateDescriptor(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Flags]
	public enum ClipCaps // TypeDefIndex: 85992
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
		ConditionBlend = 16385,
		SeekFirstOnlyDeltaTime = 32768
	}

	internal static class TimelineClipCapsExtensions // TypeDefIndex: 85993
	{
		// Extension methods
		public static bool SupportsExtrapolation(this TimelineClip clip); // 0x000000018D46D07C-0x000000018D46D09C
		public static bool HasAny(this ClipCaps caps, ClipCaps flags); // 0x00000001892560F4-0x00000001892560FC
	}

	[Serializable]
	[UnityEngine.Timeline.NotKeyable]
	public class ControlPlayableAsset : BeyondUseAutoBindingPlayableAsset, IPropertyPreview, ITimelineClipAsset // TypeDefIndex: 85995
	{
		// Fields
		private const int k_MaxRandInt = 10000; // Metadata: 0x026453E7
		private static readonly List<PlayableDirector> k_EmptyDirectorsList; // 0x00
		private static readonly List<ParticleSystem> k_EmptyParticlesList; // 0x08
		private static readonly HashSet<ParticleSystem> s_SubEmitterCollector; // 0x10
		[SerializeField]
		public ExposedReference<GameObject> sourceGameObject; // 0x30
		[SerializeField]
		public GameObject prefabGameObject; // 0x40
		[SerializeField]
		public bool updateParticle; // 0x48
		[SerializeField]
		public uint particleRandomSeed; // 0x4C
		[SerializeField]
		public bool forceRuntimeSimulate; // 0x50
		[SerializeField]
		public bool updateDirector; // 0x51
		[SerializeField]
		public string directorControlPath; // 0x58
		[SerializeField]
		public bool updateITimeControl; // 0x60
		[SerializeField]
		public bool searchHierarchy; // 0x61
		[SerializeField]
		public bool active; // 0x62
		[SerializeField]
		public ActivationControlPlayable.PostPlaybackState postPlayback; // 0x64
		[SerializeField]
		private bool m_OnlyDeltaTime; // 0x68
		[SerializeField]
		private bool m_IgniteOnce; // 0x69
		private PlayableAsset m_ControlDirectorAsset; // 0x70
		private double m_Duration; // 0x78
		private bool m_SupportLoop; // 0x80
		private static HashSet<PlayableDirector> s_ProcessedDirectors; // 0x18
		private static HashSet<GameObject> s_CreatedPrefabs; // 0x20
		[CompilerGenerated]
		private bool _controllingDirectors_k__BackingField; // 0x81
		[CompilerGenerated]
		private bool _controllingParticles_k__BackingField; // 0x82
	
		// Properties
		public override GameObject bindingGameObject { get; } // 0x000000018D4633D0-0x000000018D463460 
		internal bool controllingDirectors { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723DD20-0x000000018723DD30 0x000000018723DD30-0x000000018723DD40
		public bool controllingParticles { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187253A90-0x0000000187253AA0 0x0000000187253AC0-0x0000000187253AD0
		public bool OnlyDeltaTime { get; set; } // 0x000000018226EF80-0x000000018226EF90 0x000000018226EF90-0x000000018226EFA0
		public bool IgniteOnce { get; set; } // 0x0000000187233360-0x0000000187233370 0x00000001872333C0-0x00000001872333D0
		public override double duration { get; } // 0x00000001872337B0-0x00000001872337C0 
		public virtual ClipCaps clipCaps { get; } // 0x000000018D463460-0x000000018D463494 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetControlableScripts_d__55 : IEnumerable<MonoBehaviour>, IEnumerator<MonoBehaviour> // TypeDefIndex: 85994
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
			MonoBehaviour IEnumerator<UnityEngine.MonoBehaviour>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _GetControlableScripts_d__55(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000184F6AC00-0x0000000184F6B620
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000184F6B9B0-0x0000000184F6C390
			[DebuggerHidden]
			IEnumerator<MonoBehaviour> IEnumerable<MonoBehaviour>.GetEnumerator(); // 0x0000000184F6B620-0x0000000184F6B9A0
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000184F6B9A0-0x0000000184F6B9B0
		}
	
		// Constructors
		public ControlPlayableAsset(); // 0x0000000186643B10-0x0000000186643BC0
		static ControlPlayableAsset(); // 0x0000000186E228E0-0x0000000186E22B10
	
		// Methods
		public void OnEnable(); // 0x0000000186A5FE70-0x0000000186A5FE90
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go); // 0x000000018D460958-0x000000018D461470
		internal static bool ShouldUseControlActivationMixer(GameObject gameObject); // 0x0000000184F5EB50-0x0000000184F5F170
		private static Playable ConnectPlayablesToMixer(PlayableGraph graph, List<Playable> playables); // 0x000000018D4607F8-0x000000018D460958
		private void CreateActivationPlayable(GameObject root, PlayableGraph graph, List<Playable> outplayables, bool useControlActivationMixer); // 0x0000000184F5BE00-0x0000000184F5D3E0
		internal GameObject ResolveControlActivationTarget(PlayableGraph graph, Playable clipRoot); // 0x0000000184F5D3E0-0x0000000184F5EB50
		protected virtual void SearchHierarchyAndConnectParticleSystem(IEnumerable<ParticleSystem> particleSystems, float clipIn, float speedMultiplier, PlayableGraph graph, List<Playable> outplayables); // 0x000000018D462C40-0x000000018D462EBC
		private void SearchHierarchyAndConnectDirector(IEnumerable<PlayableDirector> directors, PlayableGraph graph, List<Playable> outplayables, bool disableSelfReferences); // 0x000000018D46299C-0x000000018D462C40
		private static void SearchHierarchyAndConnectControlableScripts(IEnumerable<MonoBehaviour> controlableScripts, PlayableGraph graph, List<Playable> outplayables); // 0x000000018D462784-0x000000018D46299C
		private static void ConnectMixerAndPlayable(PlayableGraph graph, Playable mixer, Playable playable, int portIndex); // 0x000000018D460738-0x000000018D4607F8
		protected virtual GameObject ResolveSourceGameObject(IExposedPropertyTable resolver); // 0x000000018D462650-0x000000018D462784
		internal IList<T> GetComponent<T>(GameObject gameObject);
		internal IList<PlayableDirector> GetControllableDirectors(GameObject gameObject); // 0x000000018D46176C-0x000000018D4618E4
		[IteratorStateMachine(typeof(_GetControlableScripts_d__55))]
		internal static IEnumerable<MonoBehaviour> GetControlableScripts(GameObject root); // 0x000000018D4616FC-0x000000018D46176C
		internal void UpdateDurationAndLoopFlag(IList<PlayableDirector> directors, IList<ParticleSystem> particleSystems); // 0x000000018D462EBC-0x000000018D4633D0
		private IList<ParticleSystem> GetControllableParticleSystems(GameObject go); // 0x000000018D4618E4-0x000000018D461A30
		private static void GetControllableParticleSystems(Transform t, ICollection<ParticleSystem> roots, HashSet<ParticleSystem> subEmitters); // 0x000000018D461A30-0x000000018D461B80
		private static void CacheSubEmitters(ParticleSystem ps, HashSet<ParticleSystem> subEmitters); // 0x000000018D460660-0x000000018D460738
		public void GatherProperties(PlayableDirector director, IPropertyCollector driver); // 0x000000018D461470-0x000000018D4616FC
		internal void PreviewParticlesWithControlPlayableAsset(IPropertyCollector driver, IEnumerable<ParticleSystem> particles); // 0x000000018D461EC8-0x000000018D461F24
		internal static void PreviewParticles(IPropertyCollector driver, IEnumerable<ParticleSystem> particles); // 0x000000018D461F24-0x000000018D4620D4
		internal static void PreviewActivation(IPropertyCollector driver, IEnumerable<GameObject> objects); // 0x000000018D461B80-0x000000018D461CE4
		internal static void PreviewTimeControl(IPropertyCollector driver, PlayableDirector director, IEnumerable<MonoBehaviour> scripts); // 0x000000018D4620D4-0x000000018D462650
		internal static void PreviewDirectors(IPropertyCollector driver, IEnumerable<PlayableDirector> directors); // 0x000000018D461CE4-0x000000018D461EC8
	}

	[ExcludeFromPreset]
	[SupportsChildTracks(null, 2147483647)]
	[TrackClipType(typeof(ControlPlayableAsset), false)]
	public class ControlTrack : TrackAsset // TypeDefIndex: 85997
	{
		// Nested types
		private sealed class ControlActivationClipGroup // TypeDefIndex: 85996
		{
			// Fields
			public readonly GameObject target; // 0x10
			public readonly List<TimelineClip> clips; // 0x18
			public ActivationControlPlayable.PostPlaybackState postPlayback; // 0x20
	
			// Constructors
			public ControlActivationClipGroup(GameObject target, ActivationControlPlayable.PostPlaybackState postPlayback); // 0x0000000184F5B780-0x0000000184F5BE00
		}
	
		// Constructors
		public ControlTrack(); // 0x0000000186253FE0-0x0000000186254030
	
		// Methods
		internal override Playable AfterCompileClips(PlayableGraph graph, GameObject gameObject, IList<TimelineClip> clips, IntervalTree<RuntimeElement> tree, Playable trackRoot); // 0x0000000184F5F170-0x0000000184F619D0
		private ScriptPlayable<ActivationMixerPlayable> _CreateControlActivationSidecar(PlayableGraph graph, ControlActivationClipGroup group, IntervalTree<RuntimeElement> tree); // 0x0000000184F619D0-0x0000000184F63EF0
		private static ControlActivationClipGroup _FindControlActivationGroup(List<ControlActivationClipGroup> groups, GameObject target); // 0x0000000184F63EF0-0x0000000184F64820
	}

	[ExecuteAlways]
	public class AdditiveAnimApplyMono : MonoBehaviour // TypeDefIndex: 86000
	{
		// Fields
		public const int OverrideAxisPosX = 1; // Metadata: 0x026453EB
		public const int OverrideAxisPosY = 2; // Metadata: 0x026453EC
		public const int OverrideAxisPosZ = 4; // Metadata: 0x026453ED
		public const int OverrideAxisRotX = 8; // Metadata: 0x026453EE
		public const int OverrideAxisRotY = 16; // Metadata: 0x026453EF
		public const int OverrideAxisRotZ = 32; // Metadata: 0x026453F0
		public const int OverrideAxisScaleX = 64; // Metadata: 0x026453F1
		public const int OverrideAxisScaleY = 128; // Metadata: 0x026453F3
		public const int OverrideAxisScaleZ = 256; // Metadata: 0x026453F5
		private Dictionary<Transform, TransformAdditive> pendingAdditives; // 0x18
		private Dictionary<Transform, TransformOverride> pendingOverrides; // 0x20
		private bool hasNewPendingAdditiveUpdates; // 0x28
		private bool hasNewPendingOverrideUpdates; // 0x29
		private ITimelineRootMarker _parentTimelineRoot; // 0x30
	
		// Nested types
		public class TransformAdditive // TypeDefIndex: 85998
		{
			// Fields
			public Vector3 position; // 0x10
			public Vector3 rotationEuler; // 0x1C
			public Vector3 scale; // 0x28
	
			// Constructors
			public TransformAdditive(); // 0x000000018D474258-0x000000018D474260
	
			// Methods
			public void Reset(); // 0x000000018D4741F8-0x000000018D474258
		}
	
		public class TransformOverride // TypeDefIndex: 85999
		{
			// Fields
			public Vector3 position; // 0x10
			public Vector3 rotationEuler; // 0x1C
			public Vector3 scale; // 0x28
			public Vector3 positionWeight; // 0x34
			public Vector3 rotationWeight; // 0x40
			public Vector3 scaleWeight; // 0x4C
			public int axisMask; // 0x58
	
			// Constructors
			public TransformOverride(); // 0x000000018D474404-0x000000018D47440C
	
			// Methods
			public void Reset(); // 0x000000018D474260-0x000000018D474318
		}
	
		// Constructors
		public AdditiveAnimApplyMono(); // 0x000000018D45E3EC-0x000000018D45E4B4
	
		// Methods
		private void Awake(); // 0x000000018D45DAA4-0x000000018D45DB64
		public void RecordAdditiveTransform(Transform bone, Vector3 position, Vector3 rotationEuler, Vector3 scale); // 0x000000018D45DEAC-0x000000018D45E00C
		public void RecordOverrideTransform(Transform bone, Vector3 position, Vector3 rotationEuler, Vector3 scale, Vector3 positionWeight, Vector3 rotationWeight, Vector3 scaleWeight, int axisMask); // 0x000000018D45E00C-0x000000018D45E1EC
		private void LateUpdate(); // 0x000000018D45DE2C-0x000000018D45DE68
		public void ApplyPendingOverrideTransforms(); // 0x000000018D45D524-0x000000018D45D6C0
		private static void ApplyOverrideTransform(Transform bone, TransformOverride transformOverride); // 0x000000018D45D288-0x000000018D45D524
		private static float _BlendAxis(float baseValue, float overrideValue, float weight); // 0x000000018D45E304-0x000000018D45E328
		private static float _BlendRotationAxis(float baseValue, float overrideValue, float weight); // 0x000000018D45E328-0x000000018D45E3EC
		internal static void AccumulateRotationAngle(float angle, float weight, ref float sinSum, ref float cosSum); // 0x000000018725FA90-0x000000018725FB00
		internal static float ResolveRotationAngle(float sinSum, float cosSum, float fallback); // 0x000000018D45E274-0x000000018D45E304
		public void ApplyPendingTransforms(); // 0x000000018D45D6C0-0x000000018D45DAA4
		public void ClearPendingTransforms(); // 0x000000018D45DCC8-0x000000018D45DE2C
		public void ClearPendingOverrideTransforms(); // 0x000000018D45DB64-0x000000018D45DCC8
		public void RequestReleaseOverrideAnim(PlayableDirector director, bool evaluateInEditor); // 0x000000018D45E26C-0x000000018D45E274
		private void NotifyCutsceneRootToUpdateVFXTools(); // 0x000000018D45DE68-0x000000018D45DEAC
		public void RegisterRootComponent(); // 0x000000018D45E1EC-0x000000018D45E26C
	}

	public class AdditiveAnimMixer : PlayableBehaviour // TypeDefIndex: 86002
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
		private class TransformAdditive // TypeDefIndex: 86001
		{
			// Fields
			public Vector3 position; // 0x10
			public Vector3 rotationEular; // 0x1C
			public Vector3 scale; // 0x28
	
			// Constructors
			public TransformAdditive(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Reset(); // 0x000000018D4741F8-0x000000018D474258
		}
	
		// Constructors
		public AdditiveAnimMixer(); // 0x000000018D45F488-0x000000018D45F594
	
		// Methods
		public override void PrepareFrame(Playable playable, FrameData info); // 0x000000018723ECF0-0x000000018723ED00
		public override void ProcessFrame(Playable playable, FrameData info, object playerData); // 0x000000018D45E4B4-0x000000018D45E878
		private void _AddToAdditiveCache(AdditiveAnimPlayable additiveAnimPlayable, float clipTime, float weight); // 0x000000018D45EAB0-0x000000018D45F1A8
		private void _ApplyAdditive(); // 0x000000018D45F1A8-0x000000018D45F488
		internal static void ReleaseTrackAdditiveAnim(AdditiveAnimTrack track); // 0x000000018D45E878-0x000000018D45EAB0
	}

	public class AdditiveAnimPlayable : PlayableBehaviour // TypeDefIndex: 86003
	{
		// Fields
		public List<AdditiveAnimPlayableAsset.AnimationCurveInfo> extractedCurves; // 0x10
		private Dictionary<string, List<AdditiveAnimPlayableAsset.AnimationCurveInfo>> _curveCache; // 0x18
	
		// Constructors
		public AdditiveAnimPlayable(); // 0x000000018D45FB10-0x000000018D45FB88
	
		// Methods
		public override void OnPlayableCreate(Playable playable); // 0x000000018D45FA98-0x000000018D45FB10
		public void InitializeCurveCache(); // 0x000000018D45F808-0x000000018D45FA98
	}

	[Serializable]
	public class AdditiveAnimPlayableAsset : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 86005
	{
		// Fields
		public AnimationClip additiveClip; // 0x18
		private ScriptPlayable<AdditiveAnimPlayable> additiveAnimPlayable; // 0x20
		[HideInInspector]
		public List<AnimationCurveInfo> extractedCurves; // 0x30
		[SerializeField]
		private bool m_OnlyDeltaTime; // 0x38
		[SerializeField]
		private bool m_IgniteOnce; // 0x39
		[NonSerialized]
		private AnimationClip _lastProcessedClip; // 0x40
	
		// Properties
		public bool OnlyDeltaTime { get; set; } // 0x000000018225E070-0x000000018225E080 0x000000018225E080-0x000000018225E090
		public bool IgniteOnce { get; set; } // 0x000000018226ED20-0x000000018226ED30 0x000000018226ED30-0x000000018226ED40
		public ClipCaps clipCaps { get; } // 0x000000018D45F7E4-0x000000018D45F808 
	
		// Nested types
		[Serializable]
		public class AnimationCurveInfo // TypeDefIndex: 86004
		{
			// Fields
			public string path; // 0x10
			public string propertyName; // 0x18
			public AnimationCurve curve; // 0x20
	
			// Constructors
			public AnimationCurveInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public AdditiveAnimPlayableAsset(); // 0x000000018D45F764-0x000000018D45F7E4
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018D45F594-0x000000018D45F6C0
		private void _InitializeBehaviourCurveCache(); // 0x000000018D45F6C0-0x000000018D45F764
	}

	[System.ComponentModel.DisplayName("Beyond/AdditiveAnimationTrack")]
	[TrackBindingType(typeof(GameObject))]
	[TrackClipType(typeof(AdditiveAnimPlayableAsset))]
	public class AdditiveAnimTrack : TrackAsset // TypeDefIndex: 86006
	{
		// Fields
		private const string k_DefaultRecordableClipName = "Recorded Additive"; // Metadata: 0x026453F7
		[HideInInspector]
		[SerializeField]
		private bool m_InfiniteClip; // 0xC8
		[HideInInspector]
		[SerializeField]
		private AnimationClip m_RecordableClip; // 0xD0
		[SerializeField]
		private bool m_UseTakeOver; // 0xD8
	
		// Properties
		public bool useTakeOver { get; set; } // 0x0000000184F59D60-0x0000000184F59D70 0x0000000184F59D70-0x0000000184F59D80
		public override bool muted { get; set; } // 0x000000018D45FEF0-0x000000018D45FEF8 0x000000018D45FEF8-0x000000018D45FF38
		public override bool runtimeMuted { get; set; } // 0x000000018226EC80-0x000000018226EC90 0x000000018D45FF38-0x000000018D45FF78
	
		// Constructors
		public AdditiveAnimTrack(); // 0x000000018D45FEA4-0x000000018D45FEF0
	
		// Methods
		public override bool ShouldDeferCompile(); // 0x0000000184F59D60-0x0000000184F59D70
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount); // 0x000000018D45FBB0-0x000000018D45FCB4
		public override void GatherProperties(PlayableDirector director, IPropertyCollector driver); // 0x000000018D45FCB4-0x000000018D45FEA4
		public TimelineClip CreateRecordableClip(string animClipName); // 0x000000018D45FB88-0x000000018D45FBB0
	}

	public class CustomControlPlayableAsset : PlayableAsset, ITimelineClipAsset, ICustomControlBehaviour // TypeDefIndex: 86007
	{
		// Fields
		protected CustomControlPlayableBehaviour m_CustomControlBehaviour; // 0x18
	
		// Properties
		public ClipCaps clipCaps { get; } // 0x000000018D46359C-0x000000018D4635B8 
		protected virtual ClipCaps extraClipCaps { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	
		// Constructors
		public CustomControlPlayableAsset(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018D463494-0x000000018D4634E4
		public virtual void OnClipEnable(Playable playable, FrameData info); // 0x000000018D463540-0x000000018D46359C
		public virtual void OnClipDisable(Playable playable, FrameData info); // 0x000000018D4634E4-0x000000018D463540
	}

	public class CustomControlPlayableBehaviour : PlayableBehaviour, ICustomControlBehaviour // TypeDefIndex: 86008
	{
		// Constructors
		public CustomControlPlayableBehaviour(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public virtual void OnClipEnable(Playable playable, FrameData info); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnClipDisable(Playable playable, FrameData info); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public interface ICombineToTopPlayableTrack // TypeDefIndex: 86009
	{
	}

	public interface ICustomControlBehaviour // TypeDefIndex: 86010
	{
		// Methods
		void OnClipEnable(Playable playable, FrameData info);
		void OnClipDisable(Playable playable, FrameData info);
	}

	public interface IDynamicBinding // TypeDefIndex: 86011
	{
	}

	public interface ITimelineAnimationEventContextBinding // TypeDefIndex: 86012
	{
		// Methods
		void RegisterAnimationEventRuntimeContext(int playableId, AnimationEvent[] animationEvents, AnimationPlayableAsset.AnimationEventTriggerMode postAudioEventTriggerMode, float postAudioEventTriggerThreshold, AnimationPlayableAsset.AnimationEventTriggerMode customFootStepTriggerMode, float customFootStepTriggerThreshold, float curClipTime, float curWeight, AnimationPlayableAsset.ClipEndAudioBehaviour clipEndAudioBehaviour = AnimationPlayableAsset.ClipEndAudioBehaviour.Default /* Metadata: 0x02645409 */);
		void UnregisterAnimationEventRuntimeContext(int playableId, AnimationEvent[] animationEvents);
		void UpdateClipInfo(int playableId, float curClipTime, float curClipWeight);
		void StopAllAudioForPlayable(int playableId, int fadeOutTimeMs = 100 /* Metadata: 0x0264540A */);
	}

	public class OverrideAnimMixer : PlayableBehaviour // TypeDefIndex: 86015
	{
		// Fields
		private GameObject _bindingGo; // 0x10
		private bool _thisFrameAlreadyCalculated; // 0x18
		private bool _hadActiveOverrideLastFrame; // 0x19
		private bool _ownsBinding; // 0x1A
		private bool _duplicateBindingLogged; // 0x1B
		private int _bindingInstanceId; // 0x1C
		private AdditiveAnimApplyMono _cachedApplyMono; // 0x20
		private PlayableDirector _cachedDirector; // 0x28
		private static readonly Dictionary<int, OverrideAnimMixer> s_activeMixersByBinding; // 0x00
		private readonly Dictionary<Transform, TransformOverride> _overrideCache; // 0x30
		private readonly Dictionary<string, Transform> _bonePaths; // 0x38
		private readonly HashSet<string> _notFoundBonePaths; // 0x40
	
		// Nested types
		[Flags]
		private enum OverrideChannelMask // TypeDefIndex: 86013
		{
			None = 0,
			Position = 1,
			Rotation = 2,
			Scale = 4
		}
	
		private class TransformOverride // TypeDefIndex: 86014
		{
			// Fields
			public Vector3 position; // 0x10
			public Vector3 rotationEuler; // 0x1C
			public Vector3 rotationSin; // 0x28
			public Vector3 rotationCos; // 0x34
			public Vector3 scale; // 0x40
			public OverrideChannelMask channelMask; // 0x4C
			public Vector3 positionWeight; // 0x50
			public Vector3 rotationWeight; // 0x5C
			public Vector3 scaleWeight; // 0x68
	
			// Constructors
			public TransformOverride(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Reset(); // 0x000000018D474318-0x000000018D474404
		}
	
		// Constructors
		public OverrideAnimMixer(); // 0x000000018D467394-0x000000018D4674A0
		static OverrideAnimMixer(); // 0x000000018D467308-0x000000018D467394
	
		// Methods
		public override void PrepareFrame(Playable playable, FrameData info); // 0x000000018723F9D0-0x000000018723F9E0
		public override void OnBehaviourPause(Playable playable, FrameData info); // 0x000000018D4653DC-0x000000018D4653F0
		public override void OnPlayableDestroy(Playable playable); // 0x000000018D4653F0-0x000000018D465414
		public override void ProcessFrame(Playable playable, FrameData info, object playerData); // 0x000000018D465414-0x000000018D465888
		private bool _AddToOverrideCache(OverrideAnimPlayable overrideAnimPlayable, float clipTime, float weight, float clipDuration); // 0x000000018D465AC0-0x000000018D466368
		private bool _TryGetCurveSampleTime(OverrideAnimPlayableAsset.AnimationCurveInfo curveInfo, float clipTime, float clipDuration, out float sampleTime); // 0x000000018D4671F8-0x000000018D467308
		private void _ApplyOverride(); // 0x000000018D466368-0x000000018D466A1C
		private static Vector3 _ClampAxisWeights(Vector3 axisWeights); // 0x000000018D466D20-0x000000018D466D58
		private static int _ResolveOverrideAxis(float accumulatedValue, float axisWeight, ref float overrideValue, int axisBit); // 0x000000018D467098-0x000000018D4670B0
		private static int _ResolveOverrideRotationAxis(float accumulatedValue, float accumulatedSin, float accumulatedCos, float axisWeight, ref float overrideValue, int axisBit); // 0x000000018D4670B0-0x000000018D4670F8
		private Transform _ResolveBoneTransform(string bonePath); // 0x000000018D466EF0-0x000000018D467098
		private bool _TryAcquireBindingOwnership(); // 0x000000018D4670F8-0x000000018D4671F8
		private void _ReleaseBindingOwnership(); // 0x000000018D466D58-0x000000018D466E30
		private void _CacheDirector(Playable playable); // 0x000000018D466A1C-0x000000018D466D20
		private void _ReleaseOverrideAnim(bool evaluateInEditor); // 0x000000018D466E30-0x000000018D466EF0
		internal static void ReleaseTrackOverrideAnim(OverrideAnimTrack track); // 0x000000018D465888-0x000000018D465AC0
	}

	public class OverrideAnimPlayable : PlayableBehaviour // TypeDefIndex: 86016
	{
		// Fields
		public List<OverrideAnimPlayableAsset.AnimationCurveInfo> extractedCurves; // 0x10
		private Dictionary<string, List<OverrideAnimPlayableAsset.AnimationCurveInfo>> _curveCache; // 0x18
	
		// Constructors
		public OverrideAnimPlayable(); // 0x000000018D4679F0-0x000000018D467A68
	
		// Methods
		public override void OnPlayableCreate(Playable playable); // 0x000000018D467978-0x000000018D4679F0
		public void InitializeCurveCache(); // 0x000000018D4676E8-0x000000018D467978
	}

	[Serializable]
	public class OverrideAnimPlayableAsset : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 86018
	{
		// Fields
		public AnimationClip overrideClip; // 0x18
		[HideInInspector]
		public List<AnimationCurveInfo> extractedCurves; // 0x20
		[SerializeField]
		private bool m_OnlyDeltaTime; // 0x28
		[SerializeField]
		private bool m_IgniteOnce; // 0x29
		private ScriptPlayable<OverrideAnimPlayable> overrideAnimPlayable; // 0x30
	
		// Properties
		public bool OnlyDeltaTime { get; set; } // 0x000000018225DF70-0x000000018225DF80 0x000000018225DF80-0x000000018225DF90
		public bool IgniteOnce { get; set; } // 0x000000018225E0D0-0x000000018225E0E0 0x000000018225E0E0-0x000000018225E0F0
		public ClipCaps clipCaps { get; } // 0x000000018D4676C4-0x000000018D4676E8 
	
		// Nested types
		[Serializable]
		public class AnimationCurveInfo // TypeDefIndex: 86017
		{
			// Fields
			public string path; // 0x10
			public string propertyName; // 0x18
			public AnimationCurve curve; // 0x20
	
			// Constructors
			public AnimationCurveInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public OverrideAnimPlayableAsset(); // 0x000000018D467644-0x000000018D4676C4
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018D4674A0-0x000000018D4675A0
		private void _InitializeBehaviourCurveCache(); // 0x000000018D4675A0-0x000000018D467644
	}

	[System.ComponentModel.DisplayName("Beyond/OverrideAnimationTrack")]
	[TrackBindingType(typeof(GameObject))]
	[TrackClipType(typeof(OverrideAnimPlayableAsset))]
	public class OverrideAnimTrack : TrackAsset // TypeDefIndex: 86019
	{
		// Fields
		private const string DEFAULT_RECORDABLE_CLIP_NAME = "Recorded Override"; // Metadata: 0x02645410
		[HideInInspector]
		[SerializeField]
		private bool _infiniteClip; // 0xC8
		[HideInInspector]
		[SerializeField]
		private AnimationClip _recordableClip; // 0xD0
	
		// Properties
		public override bool muted { get; set; } // 0x000000018D45FEF0-0x000000018D45FEF8 0x000000018D467D64-0x000000018D467DCC
		public override bool runtimeMuted { get; set; } // 0x000000018226EC80-0x000000018226EC90 0x000000018D467DCC-0x000000018D467E34
	
		// Constructors
		public OverrideAnimTrack(); // 0x000000018D467D18-0x000000018D467D64
	
		// Methods
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount); // 0x000000018D467A90-0x000000018D467B3C
		public override void GatherProperties(PlayableDirector director, IPropertyCollector driver); // 0x000000018D467B3C-0x000000018D467D18
		public TimelineClip CreateRecordableClip(string animClipName); // 0x000000018D467A68-0x000000018D467A90
	}

	public class SegmentLoopPlayableBehaviour : PlayableBehaviour // TypeDefIndex: 86020
	{
		// Constructors
		public SegmentLoopPlayableBehaviour(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class SegmentLoopPlayableClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 86021
	{
		// Fields
		public string loopSegmentKey; // 0x18
	
		// Properties
		public ClipCaps clipCaps { get; } // 0x000000018725E380-0x000000018725E390 
	
		// Constructors
		public SegmentLoopPlayableClip(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018D46B238-0x000000018D46B2E4
	}

	[System.ComponentModel.DisplayName("Beyond/SegmentLoopTrack")]
	[TrackClipType(typeof(SegmentLoopPlayableClip))]
	public class SegmentLoopTrack : TrackAsset, ICombineToTopPlayableTrack // TypeDefIndex: 86022
	{
		// Constructors
		public SegmentLoopTrack(); // 0x000000018D46B2E4-0x000000018D46B330
	}

	internal struct DiscreteTime : IComparable // TypeDefIndex: 86023
	{
		// Fields
		private const double k_Tick = 1E-12; // Metadata: 0x02645422
		public static readonly DiscreteTime kMaxTime; // 0x00
		private readonly long m_DiscreteTime; // 0x00
	
		// Properties
		public static double tickValue { get; } // 0x000000018725FB50-0x000000018725FB60 
	
		// Constructors
		private DiscreteTime(long time); // 0x000000018561B5B0-0x000000018561B5C0
		public DiscreteTime(double time); // 0x000000018D4643BC-0x000000018D464418
		public DiscreteTime(int time); // 0x000000018D464364-0x000000018D4643BC
		static DiscreteTime(); // 0x000000018D464324-0x000000018D464364
	
		// Methods
		public DiscreteTime OneTickBefore(); // 0x000000018725FB20-0x000000018725FB30
		public DiscreteTime OneTickAfter(); // 0x000000018725FB10-0x000000018725FB20
		public static DiscreteTime FromTicks(long ticks); // 0x0000000185BD80B0-0x0000000185BD80C0
		public int CompareTo(object obj); // 0x000000018D46409C-0x000000018D464104
		public bool Equals(DiscreteTime other); // 0x000000018502F140-0x000000018502FC50
		public override bool Equals(object obj); // 0x000000018D4641B8-0x000000018D464224
		private static long DoubleToDiscreteTime(double time); // 0x000000018D464104-0x000000018D4641B8
		private static long IntToDiscreteTime(int time); // 0x000000018D464274-0x000000018D4642C4
		private static double ToDouble(long time); // 0x000000018725FB30-0x000000018725FB50
		public static explicit operator double(DiscreteTime b); // 0x000000018D464418-0x000000018D464468
		public static explicit operator DiscreteTime(double time); // 0x000000018D464468-0x000000018D464490
		public static implicit operator DiscreteTime(int time); // 0x000000018D464490-0x000000018D4644B8
		public static bool operator ==(DiscreteTime lhs, DiscreteTime rhs); // 0x0000000184F9DDF0-0x0000000184F9DE00
		public static bool operator !=(DiscreteTime lhs, DiscreteTime rhs); // 0x000000018D4644B8-0x000000018D464504
		public static bool operator <=(DiscreteTime lhs, DiscreteTime rhs); // 0x000000018D464504-0x000000018D46450C
		public static bool operator >=(DiscreteTime lhs, DiscreteTime rhs); // 0x000000018508B1C0-0x000000018508B1D0
		public static DiscreteTime operator -(DiscreteTime lhs, DiscreteTime rhs); // 0x000000018725FB60-0x000000018725FB70
		public override string ToString(); // 0x000000018D46431C-0x000000018D464324
		public override int GetHashCode(); // 0x0000000187252ED0-0x0000000187252EE0
		public static DiscreteTime Max(DiscreteTime lhs, DiscreteTime rhs); // 0x000000018D4642C4-0x000000018D46431C
		public static long GetNearestTick(double time); // 0x000000018D464224-0x000000018D464274
	}

	internal class InfiniteRuntimeClip : RuntimeElement // TypeDefIndex: 86024
	{
		// Fields
		private Playable m_Playable; // 0x18
		private static readonly long kIntervalEnd; // 0x00
		[CompilerGenerated]
		private int _optionIndex_k__BackingField; // 0x28
	
		// Properties
		public override long intervalStart { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override long intervalEnd { get; } // 0x000000018D464A50-0x000000018D464AA0 
		public override int optionIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		public override bool enable { set; } // 0x000000018D464AA0-0x000000018D464B04
	
		// Constructors
		public InfiniteRuntimeClip(Playable playable); // 0x0000000187235FF0-0x0000000187236000
		static InfiniteRuntimeClip(); // 0x000000018D4649C0-0x000000018D464A50
	
		// Methods
		public override void EvaluateAt(double localTime, FrameData frameData, ITimelineRootMarker timelineRoot = null); // 0x000000018D464968-0x000000018D4649C0
		public override void DisableAt(double localTime, double rootDuration, FrameData frameData); // 0x000000018D464908-0x000000018D464968
	}

	internal interface IInterval // TypeDefIndex: 86025
	{
		// Properties
		long intervalStart { get; }
		long intervalEnd { get; }
	}

	internal interface IRuntimeReset // TypeDefIndex: 86026
	{
		// Methods
		void RuntimeReset();
	}

	internal interface IOption // TypeDefIndex: 86027
	{
	}

	internal struct IntervalTreeNode // TypeDefIndex: 86028
	{
		// Fields
		public long center; // 0x00
		public int first; // 0x08
		public int last; // 0x0C
		public int left; // 0x10
		public int right; // 0x14
	}

	internal class IntervalTree<T> // TypeDefIndex: 86030
		where T : IInterval, IRuntimeReset
	{
		// Fields
		private const int kMinNodeSize = 10; // Metadata: 0x0264542A
		private const int kInvalidNode = -1; // Metadata: 0x0264542B
		private const long kCenterUnknown = 9223372036854775807; // Metadata: 0x0264542C
		private readonly List<Entry> m_Entries;
		private readonly List<IntervalTreeNode> m_Nodes;
		[CompilerGenerated]
		private bool _dirty_k__BackingField;
	
		// Properties
		public bool dirty { [CompilerGenerated] get; [CompilerGenerated] internal set; }
	
		// Nested types
		internal struct Entry // TypeDefIndex: 86029
		{
			// Fields
			public long intervalStart;
			public long intervalEnd;
			public T item;
		}
	
		// Constructors
		public IntervalTree();
	
		// Methods
		public void Add(T item);
		public void IntersectsWith(long value, List<T> results);
		public void IntersectsWithRange(long start, long end, List<T> results);
		public void UpdateIntervals();
		public void RuntimeReset();
		private void Query(IntervalTreeNode intervalTreeNode, long value, List<T> results);
		private void QueryRange(IntervalTreeNode intervalTreeNode, long start, long end, List<T> results);
		public void Rebuild();
		private int Rebuild(int start, int end);
	}

	public class RuntimeClip : RuntimeClipBase // TypeDefIndex: 86031
	{
		// Fields
		public double runtimeLocalTimeOffset; // 0x20
		public double runtimeMixOutTime; // 0x28
		public double runtimeMixOutDuration; // 0x30
		public double runtimeMixInTime; // 0x38
		public double runtimeMixInDuration; // 0x40
		public float runtimeMixOutStartWeight; // 0x48
		public bool runtimeLooping; // 0x4C
		public bool runtimeLoopingMute; // 0x4D
		private bool _isInMixIn; // 0x4E
		private bool _isMixIn; // 0x4F
		private bool _hadIgniteOnce; // 0x50
		private bool _skipIgniteOnceOnNextDisable; // 0x51
		private double lastTickTime; // 0x58
		private bool _onlyDeltaTimeLooped; // 0x60
		[CompilerGenerated]
		private int _optionIndex_k__BackingField; // 0x64
		private int m_originalPort; // 0x68
		private bool _hadClipEnabled; // 0x6C
		public bool isRuntimeJumpExhaust; // 0x6D
		private TimelineClip m_Clip; // 0x70
		private AnimationPlayableAsset m_AnimationPlayableAsset; // 0x78
		private Playable m_Playable; // 0x80
		private Playable m_ParentMixer; // 0x90
		private Playable m_RootPlayable; // 0xA0
		private bool m_enabled; // 0xB0
	
		// Properties
		private bool useOnlyDeltaTime { get; } // 0x000000018D46A9F4-0x000000018D46AA1C 
		private bool useSeekFirstOnlyDeltaTime { get; } // 0x000000018D46AA1C-0x000000018D46AA44 
		private bool useDeltaTimeSampling { get; } // 0x000000018D46A9C4-0x000000018D46A9F4 
		public override int optionIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233670-0x0000000187233680 0x0000000187233690-0x00000001872336A0
		public bool dynamicLink { get; } // 0x000000018D46A844-0x000000018D46A86C 
		public bool customBehaviourControl { get; } // 0x000000018D46A7F0-0x000000018D46A818 
		public override double start { get; } // 0x000000018D46A998-0x000000018D46A9C4 
		public override double end { get; } // 0x000000018D46A86C-0x000000018D46A8C4 
		public override double duration { get; } // 0x000000018D46A818-0x000000018D46A844 
		public TimelineClip clip { get; } // 0x0000000187232FC0-0x0000000187232FD0 
		public Playable mixer { get; } // 0x000000018724BCC0-0x000000018724BCD0 
		public Playable playable { get; } // 0x000000018723E560-0x000000018723E570 
		public override long intervalStart { get; } // 0x000000018D46A93C-0x000000018D46A998 
		public override long intervalEnd { get; } // 0x000000018D46A8C4-0x000000018D46A93C 
		public override bool enable { set; } // 0x000000018D46AA44-0x000000018D46ACB8
		public bool isEnabling { get; } // 0x000000018225E0F0-0x000000018225E100 
	
		// Constructors
		public RuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer, int originalPort); // 0x000000018D46A78C-0x000000018D46A7F0
	
		// Methods
		private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer, int originalPort); // 0x000000018D469528-0x000000018D469684
		public void SetTime(double time); // 0x000000018D46A438-0x000000018D46A4E8
		private double ReverseClipTime(double time); // 0x000000018D469EF4-0x000000018D46A068
		public void SetDuration(double duration); // 0x000000018D46A3E0-0x000000018D46A438
		public override void EvaluateAt(double localTime, FrameData frameData, ITimelineRootMarker timelineRoot = null); // 0x000000018D469830-0x000000018D469B00
		private float _EvaluateWeight(double localTime); // 0x0000000184F64E10-0x0000000184F64F90
		public float EvaluateMixIn(float localTime); // 0x000000018D469B00-0x000000018D469C04
		public float EvaluateMixOut(float localTime); // 0x000000018D469C04-0x000000018D469CB8
		public double ToLocalTime(double localTime, FrameData frameData, ITimelineRootMarker timelineRoot, bool justEnabled = false /* Metadata: 0x02645434 */); // 0x000000018D46A4E8-0x000000018D46A6C0
		private double ApplyTimeRemapCurve(double localTime, double clipTime); // 0x000000018D46924C-0x000000018D4693AC
		public override void DisableAt(double localTime, double rootDuration, FrameData frameData); // 0x000000018D469684-0x000000018D469830
		public override bool CheckIfRuntimeTimeLoop(out bool canSkip, out double reverseTime); // 0x000000018D4694DC-0x000000018D469528
		public override bool CheckIfRuntimeTimeJump(out double jumpTime, out bool isReverseJump); // 0x000000018D4693AC-0x000000018D4694DC
		public override void RuntimeLoopOver(); // 0x000000018D46A098-0x000000018D46A0C8
		public override void RuntimeLoopOn(); // 0x000000018D46A068-0x000000018D46A098
		public override void GetRuntimeCrossFadeDuration(out double duration, out double jumpTargetTime); // 0x000000018D469CB8-0x000000018D469DE0
		public override void RecalculateRuntimeCrossFadeMixIn(double mixInTime, double mixInDuration); // 0x000000018D469DE0-0x000000018D469E58
		public override void RecalculateRuntimeCrossFadeMixOut(double curTime, double mixStartTime, double mixDuration); // 0x000000018D469E58-0x000000018D469EF4
		private void _CacheRuntimeMixClip(); // 0x0000000184F64820-0x0000000184F64E10
		private TimelinePlayable _GetTimelinePlayable(); // 0x0000000184F64F90-0x0000000184F65C50
		public bool TryGetJumpClip(out RuntimeJumpClip jumpClip); // 0x000000018D46A6C0-0x000000018D46A78C
		public override void RuntimeReset(); // 0x000000018D46A0C8-0x000000018D46A3E0
	}

	public abstract class RuntimeClipBase : RuntimeElement // TypeDefIndex: 86032
	{
		// Fields
		[CompilerGenerated]
		private int _optionIndex_k__BackingField; // 0x18
	
		// Properties
		public abstract double start { get; }
		public abstract double duration { get; }
		public abstract double end { get; }
		public override int optionIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public override long intervalStart { get; } // 0x000000018D4691F0-0x000000018D46924C 
		public override long intervalEnd { get; } // 0x000000018D469178-0x000000018D4691F0 
	
		// Constructors
		protected RuntimeClipBase(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public abstract class RuntimeElement : IInterval, IOption, IRuntimeReset // TypeDefIndex: 86033
	{
		// Fields
		[CompilerGenerated]
		private int _intervalBit_k__BackingField; // 0x10
		[CompilerGenerated]
		private bool _isLooping_k__BackingField; // 0x14
	
		// Properties
		public abstract long intervalStart { get; }
		public abstract long intervalEnd { get; }
		public abstract int optionIndex { get; set; }
		public int intervalBit { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
		public bool isLooping { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187239C50-0x0000000187239C60 0x000000018723C800-0x000000018723C810
		public abstract bool enable { set; }
	
		// Constructors
		protected RuntimeElement(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public abstract void EvaluateAt(double localTime, FrameData frameData, ITimelineRootMarker timelineRoot = null);
		public abstract void DisableAt(double localTime, double rootDuration, FrameData frameData);
		public virtual bool CheckIfRuntimeTimeLoop(out bool canSkip, out double reverseTime); // 0x000000018725FBD0-0x000000018725FBE0
		public virtual bool CheckIfRuntimeTimeJump(out double jumpTime, out bool isReverseJump); // 0x000000018725FBC0-0x000000018725FBD0
		public virtual void RuntimeLoopOver(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void RuntimeLoopOn(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void GetRuntimeCrossFadeDuration(out double duration, out double jumpTargetTime); // 0x000000018725FBE0-0x000000018725FBF0
		public virtual void RecalculateRuntimeCrossFadeMixIn(double mixInTime, double mixDuration); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void RecalculateRuntimeCrossFadeMixOut(double curTime, double mixStartTime, double mixDuration); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void RuntimeReset(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal class ScheduleRuntimeClip : RuntimeClipBase // TypeDefIndex: 86034
	{
		// Fields
		private TimelineClip m_Clip; // 0x20
		private Playable m_Playable; // 0x28
		private Playable m_ParentMixer; // 0x38
		private double m_StartDelay; // 0x48
		private double m_FinishTail; // 0x50
		private bool m_Started; // 0x58
	
		// Properties
		public override double start { get; } // 0x000000018D46B0C8-0x000000018D46B140 
		public override double duration { get; } // 0x000000018D46B044-0x000000018D46B08C 
		public override double end { get; } // 0x000000018D46B08C-0x000000018D46B0C8 
		public TimelineClip clip { get; } // 0x000000018225E800-0x000000018225E810 
		public Playable mixer { get; } // 0x000000018723DAB0-0x000000018723DAC0 
		public Playable playable { get; } // 0x000000018723D770-0x000000018723D780 
		public override bool enable { set; } // 0x000000018D46B140-0x000000018D46B238
	
		// Constructors
		public ScheduleRuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay = 0.2 /* Metadata: 0x02645435 */, double finishTail = 0.1 /* Metadata: 0x0264543D */); // 0x000000018D46AFF4-0x000000018D46B044
	
		// Methods
		private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay, double finishTail); // 0x000000018D46ACB8-0x000000018D46AD50
		public override void EvaluateAt(double localTime, FrameData frameData, ITimelineRootMarker timelineRoot = null); // 0x000000018D46AD50-0x000000018D46AFF4
		public override void DisableAt(double localTime, double rootDuration, FrameData frameData); // 0x0000000188C93124-0x0000000188C93134
	}

	public interface IMarker // TypeDefIndex: 86035
	{
		// Properties
		double time { get; set; }
		TrackAsset parent { get; }
	
		// Methods
		void Initialize(TrackAsset parent);
	}

	public interface INotificationOptionProvider // TypeDefIndex: 86036
	{
		// Properties
		NotificationFlags flags { get; }
	}

	public abstract class Marker : ScriptableObject, IMarker // TypeDefIndex: 86037
	{
		// Fields
		[SerializeField]
		[TimeField(TimeFieldAttribute.UseEditMode.ApplyEditMode)]
		[Tooltip("Time for the marker")]
		private double m_Time; // 0x18
		[CompilerGenerated]
		private TrackAsset _parent_k__BackingField; // 0x20
	
		// Properties
		public TrackAsset parent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public double time { get; set; } // 0x0000000187233020-0x0000000187233030 0x000000018D465374-0x000000018D4653CC
	
		// Constructors
		protected Marker(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		void IMarker.Initialize(TrackAsset parentTrack); // 0x000000018D465254-0x000000018D465374
		public virtual void OnInitialize(TrackAsset aPent); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	internal struct MarkerList : ISerializationCallbackReceiver // TypeDefIndex: 86038
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private List<ScriptableObject> m_Objects; // 0x00
		[NonSerialized]
		[HideInInspector]
		private List<IMarker> m_Cache; // 0x08
		private bool m_CacheDirty; // 0x10
		private bool m_HasNotifications; // 0x11
	
		// Properties
		public List<IMarker> markers { get; } // 0x000000018783BB64-0x000000018783BB80 
		public int Count { get; } // 0x000000018D465008-0x000000018D465050 
		public IMarker this[int idx] { get => default; } // 0x000000018D465050-0x000000018D4650AC 
	
		// Constructors
		public MarkerList(int capacity); // 0x0000000186254180-0x0000000186254260
	
		// Methods
		public void Add(ScriptableObject item); // 0x000000018D464B04-0x000000018D464B88
		public bool Remove(IMarker item); // 0x000000018D464E50-0x000000018D464F58
		public bool Remove(ScriptableObject item, TimelineAsset timelineAsset, PlayableAsset thingToDirty); // 0x000000018D464F58-0x000000018D465008
		public void Clear(); // 0x000000018D464B88-0x000000018D464BD4
		public IEnumerable<IMarker> GetMarkers(); // 0x000000018783BB64-0x000000018783BB80
		public List<ScriptableObject> GetRawMarkerList(); // 0x0000000184431970-0x0000000184431980
		public IMarker CreateMarker(System.Type type, double time, TrackAsset owner); // 0x000000018D464BD4-0x000000018D464E34
		public bool HasNotifications(); // 0x000000018D464E34-0x000000018D464E50
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x0000000186805BA0-0x0000000186805BB0
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001829D07F0-0x00000001829D0800
		private void BuildCache(); // 0x0000000186254260-0x00000001862544E0
	}

	[Serializable]
	[ExcludeFromPreset]
	[HideInMenu]
	[TrackBindingType(typeof(GameObject))]
	public class MarkerTrack : TrackAsset, INotificationTrack // TypeDefIndex: 86039
	{
		// Properties
		public override IEnumerable<PlayableBinding> outputs { get; } // 0x000000018D4650F8-0x000000018D465254 
	
		// Constructors
		public MarkerTrack(); // 0x000000018D4650AC-0x000000018D4650F8
	}

	internal class CustomSignalEventDrawer : PropertyAttribute // TypeDefIndex: 86040
	{
		// Constructors
		public CustomSignalEventDrawer(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AssetFileNameExtension("signal", new string[0])]
	public class SignalAsset : ScriptableObject // TypeDefIndex: 86041
	{
		// Fields
		[CompilerGenerated]
		private static Action<SignalAsset> OnEnableCallback; // 0x00
	
		// Events
		internal static event Action<SignalAsset> OnEnableCallback {
			add; // 0x000000018D46B380-0x000000018D46B41C
			remove; // 0x000000018D46B41C-0x000000018D46B4B8
		}
	
		// Constructors
		public SignalAsset(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		private void OnEnable(); // 0x000000018D46B330-0x000000018D46B380
	}

	[Serializable]
	[CustomStyle("SignalEmitter")]
	[ExcludeFromPreset]
	public class SignalEmitter : Marker, INotification, INotificationOptionProvider // TypeDefIndex: 86042
	{
		// Fields
		[SerializeField]
		private bool m_Retroactive; // 0x28
		[SerializeField]
		private bool m_EmitOnce; // 0x29
		[SerializeField]
		private SignalAsset m_Asset; // 0x30
	
		// Properties
		public bool retroactive { get; set; } // 0x000000018225DF70-0x000000018225DF80 0x000000018225DF80-0x000000018225DF90
		public bool emitOnce { get; set; } // 0x000000018225E0D0-0x000000018225E0E0 0x000000018225E0E0-0x000000018225E0F0
		public SignalAsset asset { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		PropertyName INotification.id { get; } // 0x000000018D46B4B8-0x000000018D46B560 
		NotificationFlags INotificationOptionProvider.flags { get; } // 0x000000018D46B560-0x000000018D46B588 
	
		// Constructors
		public SignalEmitter(); // 0x0000000185DD6260-0x0000000185DD6270
	}

	public class SignalReceiver : MonoBehaviour, INotificationReceiver // TypeDefIndex: 86044
	{
		// Fields
		[SerializeField]
		private EventKeyValue m_Events; // 0x18
	
		// Nested types
		[Serializable]
		private class EventKeyValue // TypeDefIndex: 86043
		{
			// Fields
			[SerializeField]
			private List<SignalAsset> m_Signals; // 0x10
			[CustomSignalEventDrawer]
			[SerializeField]
			private List<UnityEvent> m_Events; // 0x18
	
			// Properties
			public List<SignalAsset> signals { get; } // 0x00000001829260F0-0x0000000182926100 
			public List<UnityEvent> events { get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			public EventKeyValue(); // 0x000000018D464760-0x000000018D464820
	
			// Methods
			public bool TryGetValue(SignalAsset key, out UnityEvent value); // 0x000000018D4646B4-0x000000018D464760
			public void Append(SignalAsset key, UnityEvent value); // 0x000000018D46450C-0x000000018D464594
			public void Remove(int idx); // 0x000000018D464638-0x000000018D4646B4
			public void Remove(SignalAsset key); // 0x000000018D464594-0x000000018D464638
		}
	
		// Constructors
		public SignalReceiver(); // 0x000000018D46BECC-0x000000018D46BF3C
	
		// Methods
		public void OnNotify(Playable origin, INotification notification, object context); // 0x000000018D46BC7C-0x000000018D46BD5C
		public void AddReaction(SignalAsset asset, UnityEvent reaction); // 0x000000018D46B5F4-0x000000018D46B750
		public int AddEmptyReaction(UnityEvent reaction); // 0x000000018D46B588-0x000000018D46B5F4
		public void Remove(SignalAsset asset); // 0x000000018D46BE04-0x000000018D46BECC
		public IEnumerable<SignalAsset> GetRegisteredSignals(); // 0x000000018CA8CC08-0x000000018CA8CC24
		public UnityEvent GetReaction(SignalAsset key); // 0x000000018D46BB88-0x000000018D46BBC0
		public int Count(); // 0x000000018D46BA84-0x000000018D46BACC
		public void ChangeSignalAtIndex(int idx, SignalAsset newKey); // 0x000000018D46B81C-0x000000018D46BA84
		public void RemoveAtIndex(int idx); // 0x000000018D46BD5C-0x000000018D46BE04
		public void ChangeReactionAtIndex(int idx, UnityEvent reaction); // 0x000000018D46B750-0x000000018D46B81C
		public UnityEvent GetReactionAtIndex(int idx); // 0x000000018D46BACC-0x000000018D46BB88
		public SignalAsset GetSignalAssetAtIndex(int idx); // 0x000000018D46BBC0-0x000000018D46BC7C
		private void OnEnable(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	[ExcludeFromPreset]
	[TrackBindingType(typeof(SignalReceiver))]
	[TrackColor(0.25f, 0.25f, 0.25f)]
	public class SignalTrack : MarkerTrack // TypeDefIndex: 86045
	{
		// Constructors
		public SignalTrack(); // 0x000000018D46BF3C-0x000000018D46BF44
	}

	public static class TrackAssetExtensions // TypeDefIndex: 86046
	{
	}

	[Serializable]
	[ExcludeFromPreset]
	[SupportsChildTracks(null, 2147483647)]
	[TrackClipType(typeof(TrackAsset))]
	public class GroupTrack : TrackAsset // TypeDefIndex: 86047
	{
		// Fields
		public TimelineConditionBase enableOnCondition; // 0xC8
	
		// Properties
		public override IEnumerable<PlayableBinding> outputs { get; } // 0x000000018D4648B8-0x000000018D464908 
	
		// Constructors
		public GroupTrack(); // 0x0000000186253F90-0x0000000186253FE0
	
		// Methods
		public void CalculateRuntimeMuted(); // 0x000000018D464820-0x000000018D4648B8
		internal override bool CanCompileClips(); // 0x00000001843FFFF0-0x0000000184400000
	}

	public interface ILayerable // TypeDefIndex: 86048
	{
		// Methods
		Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount);
	}

	public interface ITimeDilationListener // TypeDefIndex: 86049
	{
		// Methods
		void OnTimeDilationChanged(float timeDilation);
	}

	public class ActivationControlPlayable : ControlPlayableBehaviour // TypeDefIndex: 86052
	{
		// Fields
		public GameObject gameObject; // 0x10
		public PostPlaybackState postPlayback; // 0x18
		private InitialState m_InitialState; // 0x1C
	
		// Nested types
		public enum PostPlaybackState // TypeDefIndex: 86050
		{
			Active = 0,
			Inactive = 1,
			Revert = 2
		}
	
		private enum InitialState // TypeDefIndex: 86051
		{
			Unset = 0,
			Active = 1,
			Inactive = 2
		}
	
		// Constructors
		public ActivationControlPlayable(); // 0x000000018723B480-0x000000018723B490
	
		// Methods
		public static ScriptPlayable<ActivationControlPlayable> Create(PlayableGraph graph, GameObject gameObject, PostPlaybackState postPlaybackState); // 0x000000018D45CEC0-0x000000018D45CFFC
		public override void OnBehaviourPlay(Playable playable, FrameData info); // 0x000000018D45D088-0x000000018D45D0F8
		public override void OnBehaviourPause(Playable playable, FrameData info); // 0x000000018D45CFFC-0x000000018D45D088
		public override void ProcessFrame(Playable playable, FrameData info, object userData); // 0x000000018D45D218-0x000000018D45D288
		public override void OnGraphStart(Playable playable); // 0x000000018D45D0F8-0x000000018D45D174
		public override void OnPlayableDestroy(Playable playable); // 0x000000018D45D174-0x000000018D45D218
		public override void RuntimeReset(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class AnimationEventRuntimeContextPlayable : PlayableBehaviour // TypeDefIndex: 86053
	{
		// Fields
		private ITimelineAnimationEventContextBinding m_TimelineAnimationEventContextBinding; // 0x10
		private AnimationPlayableAsset.AnimationEventTriggerMode m_PostAudioEventTriggerMode; // 0x18
		private AnimationPlayableAsset.AnimationEventTriggerMode m_CustomFootStepTriggerMode; // 0x1C
		private AnimationPlayableAsset.ClipEndAudioBehaviour m_ClipEndAudioBehaviour; // 0x20
		private AnimationEvent[] m_CachedAnimationEvents; // 0x28
		private float m_ClipDuration; // 0x30
		private float m_PostAudioEventTriggerThreshold; // 0x34
		private float m_CustomFootStepTriggerThreshold; // 0x38
		private bool m_IsRegistered; // 0x3C
		private bool m_HasRegisteredOnce; // 0x3D
	
		// Constructors
		public AnimationEventRuntimeContextPlayable(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static ScriptPlayable<AnimationEventRuntimeContextPlayable> Create(PlayableGraph graph, ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding, AnimationPlayableAsset.AnimationEventTriggerMode postAudioEventTriggerMode, float postAudioEventTriggerThreshold, AnimationPlayableAsset.AnimationEventTriggerMode customFootStepTriggerMode, float customFootStepTriggerThreshold, AnimationEvent[] cachedAnimationEvents, float clipDuration = 0f /* Metadata: 0x0264544B */, AnimationPlayableAsset.ClipEndAudioBehaviour clipEndAudioBehaviour = AnimationPlayableAsset.ClipEndAudioBehaviour.Default /* Metadata: 0x0264544F */, int inputCount = 1 /* Metadata: 0x02645450 */); // 0x000000018D45FF78-0x000000018D4600F4
		public void Initialize(ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding, AnimationPlayableAsset.AnimationEventTriggerMode postAudioEventTriggerMode, float postAudioEventTriggerThreshold, AnimationPlayableAsset.AnimationEventTriggerMode customFootStepTriggerMode, float customFootStepTriggerThreshold, AnimationEvent[] cachedAnimationEvents, float clipDuration, AnimationPlayableAsset.ClipEndAudioBehaviour clipEndAudioBehaviour = AnimationPlayableAsset.ClipEndAudioBehaviour.Default /* Metadata: 0x02645451 */); // 0x000000018D4600F4-0x000000018D46015C
		public void ResetRegistration(Playable playable); // 0x000000018D4602D0-0x000000018D4603A0
		public override void PrepareFrame(Playable playable, FrameData info); // 0x000000018D46015C-0x000000018D4602D0
	}

	[Serializable]
	[Obsolete("For best performance use PlayableAsset and PlayableBehaviour.")]
	public class BasicPlayableBehaviour : ScriptableObject, IPlayableAsset, IPlayableBehaviour // TypeDefIndex: 86054
	{
		// Properties
		public virtual double duration { get; } // 0x000000018D460460-0x000000018D4604B0 
		public virtual IEnumerable<PlayableBinding> outputs { get; } // 0x000000018D4604B0-0x000000018D460500 
	
		// Constructors
		public BasicPlayableBehaviour(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		public virtual void OnGraphStart(Playable playable); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnGraphStop(Playable playable); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnPlayableCreate(Playable playable); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnPlayableDestroy(Playable playable); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnBehaviourPlay(Playable playable, FrameData info); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnBehaviourPause(Playable playable, FrameData info); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void PrepareFrame(Playable playable, FrameData info); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void ProcessFrame(Playable playable, FrameData info, object playerData); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018D4603A0-0x000000018D460460
	}

	public class ControlPlayableBehaviour : PlayableBehaviour, IBehaviourRuntimeReset // TypeDefIndex: 86055
	{
		// Constructors
		public ControlPlayableBehaviour(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public virtual void RuntimeReset(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class DirectorControlPlayable : ControlPlayableBehaviour // TypeDefIndex: 86056
	{
		// Fields
		public PlayableDirector director; // 0x10
		public ITimelineRootMarker rootMarker; // 0x18
		private const float SYNC_START_FORBID_THRESHOLD = 0.016666668f; // Metadata: 0x02645452
		private bool m_SyncTime; // 0x20
		private double m_AssetDuration; // 0x28
		private TimelinePlayable m_TimelinePlayable; // 0x30
	
		// Constructors
		public DirectorControlPlayable(); // 0x000000018725FB00-0x000000018725FB10
	
		// Methods
		public static ScriptPlayable<DirectorControlPlayable> Create(PlayableGraph graph, PlayableDirector director); // 0x000000018D4635B8-0x000000018D463808
		public override void OnPlayableDestroy(Playable playable); // 0x000000018D463978-0x000000018D463A14
		public override void PrepareFrame(Playable playable, FrameData info); // 0x000000018D463A14-0x000000018D463C38
		public override void OnBehaviourPlay(Playable playable, FrameData info); // 0x000000018D4638C0-0x000000018D463978
		public override void OnBehaviourPause(Playable playable, FrameData info); // 0x000000018D463808-0x000000018D4638C0
		public override void ProcessFrame(Playable playable, FrameData info, object playerData); // 0x000000018D463C38-0x000000018D463D68
		private void SyncSpeed(double speed); // 0x000000018D463D68-0x000000018D463EB4
		private void SyncStart(PlayableGraph graph, double time); // 0x000000018D463EB4-0x000000018D463FD8
		private void SyncStop(PlayableGraph graph, double time); // 0x000000018D463FD8-0x000000018D46409C
		public override void RuntimeReset(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public interface ITimeControl // TypeDefIndex: 86057
	{
		// Methods
		void SetTime(double time);
		void OnControlTimeStart();
		void OnControlTimeStop();
	}

	[Serializable]
	[Flags]
	public enum NotificationFlags : short // TypeDefIndex: 86058
	{
		TriggerInEditMode = 1,
		Retroactive = 2,
		TriggerOnce = 4
	}

	public class ParticleControlPlayable : ControlPlayableBehaviour, ITimeDilationListener // TypeDefIndex: 86059
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
		[CompilerGenerated]
		private ParticleSystem _particleSystem_k__BackingField; // 0x30
		private bool m_hadIgnite; // 0x38
		private bool m_hadSimulate; // 0x39
		private bool m_hadPlayed; // 0x3A
	
		// Properties
		public ParticleSystem particleSystem { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		private bool shouldSimulate { get; } // 0x000000018D468930-0x000000018D468958 
	
		// Constructors
		public ParticleControlPlayable(); // 0x000000018725FB90-0x000000018725FBC0
	
		// Methods
		public static ScriptPlayable<ParticleControlPlayable> Create(PlayableGraph graph, ParticleSystem component, uint randomSeed, float clipIn, float speedMultiplier, bool forceRuntimeSimulate); // 0x000000018D467E34-0x000000018D467FD4
		public void Initialize(ParticleSystem ps, uint randomSeed, float clipIn, float simulateSpeed, bool forceRuntimeSimulate); // 0x000000018D467FD4-0x000000018D468094
		private void SetOriginalSimulateSpeed(ParticleSystem particleSystem, double simulateSpeed); // 0x000000018D468380-0x000000018D4684BC
		private static void SetRandomSeed(ParticleSystem particleSystem, uint randomSeed); // 0x000000018D4684BC-0x000000018D4685B8
		public override void PrepareFrame(Playable playable, FrameData data); // 0x000000018D4681B8-0x000000018D468380
		private void _SimulateParticle(float time, float particleTime, bool previewMode); // 0x000000018D4688A4-0x000000018D468930
		public override void OnBehaviourPlay(Playable playable, FrameData info); // 0x000000018725FB70-0x000000018725FB80
		private void _PlayOrQueuedParticleSystem(); // 0x000000018D46878C-0x000000018D4688A4
		public override void OnBehaviourPause(Playable playable, FrameData info); // 0x000000018D468094-0x000000018D468150
		private void Simulate(float time, bool restart); // 0x000000018D4685B8-0x000000018D46878C
		public override void RuntimeReset(); // 0x000000018725FB80-0x000000018725FB90
		public void OnTimeDilationChanged(float timeScale); // 0x000000018D468150-0x000000018D4681B8
	}

	public class PrefabControlPlayable : ControlPlayableBehaviour // TypeDefIndex: 86060
	{
		// Fields
		private GameObject m_Instance; // 0x10
	
		// Properties
		public GameObject prefabInstance { get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Constructors
		public PrefabControlPlayable(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static ScriptPlayable<PrefabControlPlayable> Create(PlayableGraph graph, GameObject prefabGameObject, Transform parentTransform); // 0x000000018D468A3C-0x000000018D468B74
		public GameObject Initialize(GameObject prefabGameObject, Transform parentTransform); // 0x000000018D468B74-0x000000018D468DC8
		public override void OnPlayableDestroy(Playable playable); // 0x000000018D468EC4-0x000000018D468F4C
		public override void OnBehaviourPlay(Playable playable, FrameData info); // 0x000000018D468E54-0x000000018D468EC4
		public override void OnBehaviourPause(Playable playable, FrameData info); // 0x000000018D468DC8-0x000000018D468E54
		private static void SetHideFlagsRecursive(GameObject gameObject); // 0x000000018D468F4C-0x000000018D469178
	}

	public class TimeControlPlayable : ControlPlayableBehaviour // TypeDefIndex: 86061
	{
		// Fields
		private ITimeControl m_timeControl; // 0x10
		private bool m_started; // 0x18
	
		// Constructors
		public TimeControlPlayable(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static ScriptPlayable<TimeControlPlayable> Create(PlayableGraph graph, ITimeControl timeControl); // 0x000000018D46BF44-0x000000018D46C03C
		public void Initialize(ITimeControl timeControl); // 0x0000000184FD2410-0x0000000184FD2420
		public override void PrepareFrame(Playable playable, FrameData info); // 0x000000018D46C0E4-0x000000018D46C15C
		public override void OnBehaviourPlay(Playable playable, FrameData info); // 0x000000018D46C090-0x000000018D46C0E4
		public override void OnBehaviourPause(Playable playable, FrameData info); // 0x000000018D46C03C-0x000000018D46C090
		public override void RuntimeReset(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class TimeNotificationBehaviour : PlayableBehaviour // TypeDefIndex: 86064
	{
		// Fields
		private readonly List<NotificationEntry> m_Notifications; // 0x10
		private double m_PreviousTime; // 0x18
		private bool m_NeedSortNotifications; // 0x20
		private bool m_IsManualUpdate; // 0x21
		private Playable m_TimeSource; // 0x28
	
		// Properties
		public Playable timeSource { set; } // 0x000000018723D780-0x000000018723D790
		public bool isManualUpdate { set; } // 0x000000018225E0A0-0x000000018225E0B0
	
		// Nested types
		private struct NotificationEntry // TypeDefIndex: 86062
		{
			// Fields
			public double time; // 0x00
			public INotification payload; // 0x08
			public bool notificationFired; // 0x10
			public NotificationFlags flags; // 0x12
	
			// Properties
			public bool triggerInEditor { get; } // 0x000000018CFCB7FC-0x000000018CFCB804 
			public bool prewarm { get; } // 0x000000018D4653CC-0x000000018D4653D4 
			public bool triggerOnce { get; } // 0x000000018D4653D4-0x000000018D4653DC 
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86063
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<NotificationEntry> __9__15_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D474428-0x000000018D47448C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _SortNotifications_b__15_0(NotificationEntry x, NotificationEntry y); // 0x000000018D47440C-0x000000018D474428
		}
	
		// Constructors
		public TimeNotificationBehaviour(); // 0x000000018D46D004-0x000000018D46D07C
	
		// Methods
		public static ScriptPlayable<TimeNotificationBehaviour> Create(PlayableGraph graph, double duration, DirectorWrapMode loopMode); // 0x000000018D46C240-0x000000018D46C350
		public void AddNotification(double time, INotification payload, NotificationFlags flags = NotificationFlags.Retroactive /* Metadata: 0x0264545C */); // 0x000000018D46C15C-0x000000018D46C210
		public override void OnGraphStart(Playable playable); // 0x000000018D46C4F8-0x000000018D46C698
		public override void OnBehaviourPause(Playable playable, FrameData info); // 0x000000018D46C350-0x000000018D46C4F8
		public override void PrepareFrame(Playable playable, FrameData info); // 0x000000018D46C698-0x000000018D46CADC
		private void SortNotifications(); // 0x000000018D46CADC-0x000000018D46CC04
		private static bool CanRestoreNotification(NotificationEntry e, FrameData info, double currentTime, double previousTime); // 0x000000018D46C210-0x000000018D46C240
		private void TriggerNotificationsInRange(double start, double end, FrameData info, Playable playable, bool checkState); // 0x000000018D46CCE4-0x000000018D46CEC4
		private void SyncDurationWithExternalSource(Playable playable); // 0x000000018D46CC04-0x000000018D46CCE4
		private static void Trigger_internal(Playable playable, PlayableOutput output, ref NotificationEntry e); // 0x000000018D46CEC4-0x000000018D46CF40
		private static void Restore_internal(ref NotificationEntry e); // 0x000000018275FD80-0x000000018275FD90
		private static double _GetPlayableTime(Playable playable); // 0x000000018D46CF40-0x000000018D46D004
	}

	public interface IAsyncScriptAnimationJobSyncInit // TypeDefIndex: 86065
	{
		// Properties
		bool isAsyncInitPending { get; }
		bool isAsyncBindStreamPropertiesComplete { get; }
		bool isAsyncBuildNecessaryLayersComplete { get; }
	
		// Methods
		bool StepAsyncBindStreamProperties(ref int bindCountBudget);
		bool StepAsyncBuildNecessaryLayers();
		bool StepAsyncFinishInit();
		void ClearAsyncInitState();
	}

	public class CommunicatorParam // TypeDefIndex: 86066
	{
		// Fields
		public IScriptAnimationJobSync jobSync; // 0x10
		public IAsyncScriptAnimationJobSyncInit asyncJobSyncInit; // 0x18
		public ITimelineRootMarker timelineRoot; // 0x20
		public string uniqueId; // 0x28
		public bool lookAtUseAdditive; // 0x30
		public bool useLookAtV2; // 0x31
		public bool useAsyncJobSyncInit; // 0x32
	
		// Constructors
		public CommunicatorParam(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public interface IAutoGenMono // TypeDefIndex: 86067
	{
	}

	public interface IBehaviourRuntimeReset // TypeDefIndex: 86068
	{
	}

	public interface IScriptAnimationJobSync : IAutoGenMono // TypeDefIndex: 86069
	{
		// Methods
		void ProcessRootMotion(AnimationStream stream);
		void CalcLayerMainStream(float deltaTime);
		void ResetCloth(List<RuntimeElement> activeRuntimeElements, bool useSoftReset = true /* Metadata: 0x0264545E */, bool keepPose = false /* Metadata: 0x0264545F */, bool useRelativeTeleport = false /* Metadata: 0x02645460 */);
	}

	public struct TimelineScriptAnimationJob : IAnimationJob // TypeDefIndex: 86070
	{
		// Fields
		private static readonly ProfilerMarker s_processRootMotionMarker; // 0x00
		public IScriptAnimationJobSync bindedScriptAnimationJobSync; // 0x00
		public Animator bindedAnimator; // 0x08
	
		// Constructors
		public TimelineScriptAnimationJob(IScriptAnimationJobSync job, Animator animator); // 0x0000000185B2C340-0x0000000185B2C370
		static TimelineScriptAnimationJob(); // 0x000000018D474194-0x000000018D4741F8
	
		// Methods
		public void ProcessAnimation(AnimationStream stream); // 0x0000000186805BA0-0x0000000186805BB0
		public void ProcessRootMotion(AnimationStream stream); // 0x000000018D47403C-0x000000018D474194
	}

	[Serializable]
	public class PlayableTrack : TrackAsset // TypeDefIndex: 86071
	{
		// Constructors
		public PlayableTrack(); // 0x000000018D4689F0-0x000000018D468A3C
	
		// Methods
		protected override void OnCreateClip(TimelineClip clip); // 0x000000018D468958-0x000000018D4689F0
	}

	[AttributeUsage(AttributeTargets.Class)]
	[Obsolete("TrackMediaType has been deprecated. It is no longer required, and will be removed in a future release.", false)]
	public class TrackMediaType : Attribute // TypeDefIndex: 86072
	{
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public class TrackClipTypeAttribute : Attribute // TypeDefIndex: 86073
	{
		// Fields
		public readonly System.Type inspectedType; // 0x10
		public readonly bool allowAutoCreate; // 0x18
	
		// Constructors
		public TrackClipTypeAttribute(System.Type clipClass); // 0x0000000186BD2A70-0x0000000186BD2A90
		public TrackClipTypeAttribute(System.Type clipClass, bool allowAutoCreate); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
	public class NotKeyableAttribute : Attribute // TypeDefIndex: 86074
	{
		// Constructors
		public NotKeyableAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Flags]
	public enum TrackBindingFlags // TypeDefIndex: 86075
	{
		None = 0,
		AllowCreateComponent = 1,
		All = 1
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class TrackBindingTypeAttribute : Attribute // TypeDefIndex: 86076
	{
		// Fields
		public readonly System.Type type; // 0x10
		public readonly TrackBindingFlags flags; // 0x18
	
		// Constructors
		public TrackBindingTypeAttribute(System.Type type); // 0x0000000186C89460-0x0000000186C89490
		public TrackBindingTypeAttribute(System.Type type, TrackBindingFlags flags); // 0x00000001856B50C0-0x00000001856B50E0
	}

	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public class SupportsChildTracksAttribute : Attribute // TypeDefIndex: 86077
	{
		// Fields
		public readonly System.Type childType; // 0x10
		public readonly int levels; // 0x18
	
		// Constructors
		public SupportsChildTracksAttribute(System.Type childType = null, int levels = 2147483647 /* Metadata: 0x02645464 */); // 0x00000001856B50C0-0x00000001856B50E0
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	internal class IgnoreOnPlayableTrackAttribute : Attribute // TypeDefIndex: 86078
	{
		// Constructors
		public IgnoreOnPlayableTrackAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal class TimeFieldAttribute : PropertyAttribute // TypeDefIndex: 86080
	{
		// Fields
		[CompilerGenerated]
		private readonly UseEditMode _useEditMode_k__BackingField; // 0x10
	
		// Nested types
		public enum UseEditMode // TypeDefIndex: 86079
		{
			None = 0,
			ApplyEditMode = 1
		}
	
		// Constructors
		public TimeFieldAttribute(UseEditMode useEditMode = UseEditMode.ApplyEditMode /* Metadata: 0x02645465 */); // 0x0000000182234E90-0x0000000182234EA0
	}

	internal class FrameRateFieldAttribute : PropertyAttribute // TypeDefIndex: 86081
	{
		// Constructors
		public FrameRateFieldAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public class HideInMenuAttribute : Attribute // TypeDefIndex: 86082
	{
		// Constructors
		public HideInMenuAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class CustomStyleAttribute : Attribute // TypeDefIndex: 86083
	{
		// Fields
		public readonly string ussStyle; // 0x10
	
		// Constructors
		public CustomStyleAttribute(string ussStyle); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class MenuCategoryAttribute : Attribute // TypeDefIndex: 86084
	{
	}

	public interface ITimelineClipAsset // TypeDefIndex: 86085
	{
		// Properties
		ClipCaps clipCaps { get; }
	}

	public interface ITimelineEvaluateCallback // TypeDefIndex: 86086
	{
		// Methods
		void Evaluate();
	}

	public class TimelineGraphPrepared : ITimelineEvaluateCallback // TypeDefIndex: 86087
	{
		// Fields
		private readonly ITimelineRootMarker m_TimelineRoot; // 0x10
		private bool m_hasEvaluated; // 0x18
	
		// Constructors
		public TimelineGraphPrepared(ITimelineRootMarker timelineRoot); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public void Evaluate(); // 0x000000018D46D09C-0x000000018D46D0F8
	}

	public class TimelinePlayable : PlayableBehaviour // TypeDefIndex: 86088
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
		private readonly HashSet<RuntimeElement> m_RuntimeMixCache; // 0x58
		private bool m_RuntimeMixNeedsIntervalUpdate; // 0x60
		private List<ITimeDilationListener> m_timeDialationListeners; // 0x68
		private int m_ActiveBit; // 0x70
		private bool m_needEvaluateTwice; // 0x74
		private bool m_isTimelineEnded; // 0x75
		private List<ITimelineEvaluateCallback> m_EvaluateCallbacks; // 0x78
		private ITimelineEvaluateCallback m_TimelineGraphPreparedCallback; // 0x80
		private bool m_hasCompletedFirstEvaluate; // 0x88
		private bool m_hasExplicitInitialOption; // 0x89
		private HashSet<Animator> m_PreviousInputBaseAnimationOutputAnimators; // 0x90
		private HashSet<Animator> m_TakeOverAnimationOutputAnimators; // 0x98
		private Dictionary<TrackAsset, Playable> m_PlayableCache; // 0xA0
		private PlayableDirector m_TopDirector; // 0xA8
		private List<PlayableDirector> m_AllDirectorUnderRoot; // 0xB0
		private PlayableDirector m_DirectorHoldingThisPlayable; // 0xB8
		private ITimelineRootMarker m_RootMarker; // 0xC0
		private List<IScriptAnimationJobSync> m_ScriptAnimationJobSyncs; // 0xC8
		private HashSet<Playable> m_forbidPostProcessMixers; // 0xD0
		private HashSet<Playable> m_excludeFromWeightProcessorCalcInputs; // 0xD8
		private bool m_isAsyncCompileEnabled; // 0xE0
		private bool m_isAsyncCompileComplete; // 0xE1
		private bool m_isAsyncCompileFailed; // 0xE2
		private PlayableGraph m_AsyncCompileGraph; // 0xE8
		private Playable m_AsyncTimelinePlayable; // 0xF8
		private List<TrackAsset> m_AsyncOutputTrackList; // 0x108
		private GameObject m_AsyncCompileGo; // 0x110
		private bool m_AsyncAutoRebalance; // 0x118
		private bool m_AsyncCreateOutputs; // 0x119
		private int m_AsyncOutputTrackIndex; // 0x11C
		private bool m_AsyncCombineToTopCompiled; // 0x120
		private PlayableOutput m_AsyncCompileDummyOutput; // 0x128
		private readonly List<TrackAsset> m_DeferredTrackList; // 0x138
		private static readonly ProfilerMarker s_compileSingleTrackMarker; // 0x00
		private static readonly ProfilerMarker s_compileDeferredTracksMarker; // 0x08
		private static readonly ProfilerMarker s_prepareFrameMarker; // 0x10
		private static readonly ProfilerMarker s_evaluateMarker; // 0x18
		private static readonly ProfilerMarker s_queryActiveClipsMarker; // 0x20
		private static readonly ProfilerMarker s_filterActiveClipsMarker; // 0x28
		private static readonly ProfilerMarker s_disableInactiveClipsMarker; // 0x30
		private static readonly ProfilerMarker s_evaluateActiveClipsMarker; // 0x38
		private static readonly ProfilerMarker s_evaluateCallbacksMarker; // 0x40
		private static readonly ProfilerMarker s_resetScriptAnimationJobSyncsMarker; // 0x48
		private static readonly ProfilerMarker s_evaluateTwiceMarker; // 0x50
		internal static bool muteAudioScrubbing; // 0x58
		private double m_timeForNextFrame; // 0x140
		[CompilerGenerated]
		private bool _allowRuntimeClipReset_k__BackingField; // 0x148
	
		// Properties
		public double timeForNextFrame { get; } // 0x000000018725FC10-0x000000018725FC20 
		public ITimelineRootMarker timelineRootMarker { get; } // 0x0000000187236200-0x0000000187236210 
		public bool allowRuntimeClipReset { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184F6ABE0-0x0000000184F6ABF0 0x0000000184F6ABF0-0x0000000184F6AC00
		public bool isAsyncCompileComplete { get; } // 0x00000001872354D0-0x00000001872354E0 
		public bool isAsyncCompileFailed { get; } // 0x00000001872354E0-0x00000001872354F0 
		public bool enableLoop { get; } // 0x000000018D473FF0-0x000000018D47403C 
	
		// Constructors
		public TimelinePlayable(); // 0x000000018D4737A4-0x000000018D473FF0
		static TimelinePlayable(); // 0x000000018D473508-0x000000018D4737A4
	
		// Methods
		public void SetNewOptionIndex(int optionIndex); // 0x000000018D472758-0x000000018D472764
		public void SetAllOptionIndex(int currentOptionIndex, int previousOptionIndex); // 0x000000018D472744-0x000000018D472758
		private void _TryMarkInitialOptionForFirstEvaluate(); // 0x000000018D473390-0x000000018D47340C
		public static ScriptPlayable<TimelinePlayable> Create(PlayableGraph graph, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs); // 0x000000018D46F054-0x000000018D46F398
		public void Compile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs); // 0x000000018D46DE78-0x000000018D46DF98
		public void BeginAsyncCompile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs); // 0x000000018D46D0F8-0x000000018D46D1B0
		public bool StepAsyncCompile(int outputGroupBudget, bool isInBurstMode = false /* Metadata: 0x02645468 */); // 0x000000018D472B9C-0x000000018D472E70
		private void InitializeCompileContext(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs); // 0x000000018D470ED4-0x000000018D471928
		private void FinalizeCompile(); // 0x000000018D4709E4-0x000000018D4709EC
		private bool ShouldKeepDeferredTracksPending(); // 0x000000018D472AF8-0x000000018D472B9C
		public void DiscardDeferredTrack(TrackAsset track); // 0x000000018D46F398-0x000000018D46F41C
		public int CompileDeferredTracks(); // 0x000000018D46D9B0-0x000000018D46DA94
		private int CompileDeferredTrackList(); // 0x0000000184F65F70-0x0000000184F67530
		private bool ShouldDiscardUnboundTakeOverTrack(TrackAsset track); // 0x000000018D472950-0x000000018D472A94
		private void CreateAsyncCompileDummyOutput(PlayableGraph graph); // 0x000000018D46DF98-0x000000018D46E040
		private void ClearAsyncCompileDummyOutput(); // 0x000000018D46D288-0x000000018D46D31C
		private void _TryRegisterTimelineGraphPreparedCallback(); // 0x000000018D47340C-0x000000018D473508
		public void MarkTimelineEnd(); // 0x000000018725FBF0-0x000000018725FC00
		public bool IsTimelineEnded(); // 0x000000018226EFE0-0x000000018226EFF0
		private void CompileCombineTopTopTrackList(PlayableGraph graph, Playable timelinePlayable, bool createOutputs); // 0x000000018D46D4DC-0x000000018D46D9B0
		private static void CollectCombineToTopTracksRecursive(TrackAsset track, List<TrackAsset> combineTracks); // 0x000000018D46D31C-0x000000018D46D4DC
		private void CompileTrackList(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool createOutputs, bool isCompilingCombineToTopTracks); // 0x000000018D46DCB0-0x000000018D46DE78
		private bool CompileSingleTrack(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, bool createOutputs, bool isCompilingCombineToTopTracks); // 0x000000018D46DA94-0x000000018D46DCB0
		private static bool IsAsyncCompileFrameBarrierTrack(TrackAsset track); // 0x000000018D471928-0x000000018D471970
		private void CreateTrackOutput(PlayableGraph graph, TrackAsset track, GameObject go, Playable playable, int port); // 0x000000018D46E100-0x000000018D46EBA8
		private void EvaluateWeightsForAnimationPlayableOutput(TrackAsset track, AnimationPlayableOutput animOutput, Animator animator); // 0x000000018D46F740-0x000000018D46F7EC
		private void EvaluateWeightsForTakeOverAnimationPlayableOutput(AnimationTrack animationTrack, AnimationPlayableOutput animOutput, Animator animator); // 0x000000018D46F7EC-0x000000018D46F978
		private void RegisterTakeOverAnimationOutputBasePolicy(AnimationTrack animationTrack, GameObject go); // 0x000000018D471F7C-0x000000018D47202C
		private void RegisterTakeOverAnimationOutputBasePolicy(AnimationTrack animationTrack, Animator animator); // 0x000000018D471EA8-0x000000018D471F7C
		public bool ShouldExcludeScriptAddonFromTakeOverOutputWeight(Animator animator); // 0x0000000184F67B90-0x0000000184F681C0
		private Playable CreateTrackPlayable(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, bool createOutputs); // 0x000000018D46EBA8-0x000000018D46F054
		private Playable CreateTakeOverTrackPlayableGraph(PlayableGraph graph, Playable timelinePlayable, AnimationTrack animationTrack, GameObject go); // 0x000000018D46E040-0x000000018D46E100
		public void UpdateIntervalTree(); // 0x000000018D472E70-0x000000018D472EB8
		public void RuntimeResetIntervalTree(); // 0x000000018D472080-0x000000018D472744
		internal void CacheRuntimeMixClip(RuntimeClip clip); // 0x0000000184F65C50-0x0000000184F65F70
		public bool IsDynamicLinkAnimationOutput(PlayableOutput output); // 0x000000018D471970-0x000000018D4719F0
		private static bool HasDynamicLinkAnimationClip(TrackAsset track); // 0x000000018D470BB8-0x000000018D470ED4
		public override void PrepareFrame(Playable playable, FrameData info); // 0x000000018D471AA8-0x000000018D471EA8
		private void _ResetScriptAnimationJobySyncs(); // 0x000000018D47317C-0x000000018D473390
		private void _EvaluateTwice(); // 0x000000018D472EB8-0x000000018D473020
		public List<RuntimeElement> GetCurrentActiveClips(); // 0x000000018226EEA0-0x000000018226EEB0
		public List<RuntimeElement> GetActiveClipsAtGivenTime(double givenTime, List<RuntimeElement> activeClips = null); // 0x000000018D470AE8-0x000000018D470BB8
		public List<RuntimeElement> GetActiveClipsAtGivenTimeRange(double startTime, double endTime, List<RuntimeElement> activeClips = null); // 0x000000018D4709EC-0x000000018D470AE8
		protected virtual void Evaluate(Playable playable, FrameData frameData); // 0x000000018D46F978-0x000000018D4709E4
		private bool DoReverseLoop(double reverseTime); // 0x000000018D46F4D8-0x000000018D46F740
		private bool DoReverseJump(RuntimeClip runtimeClip, double jumpTime, double? deferredSeekSourceTime = default); // 0x0000000184F67530-0x0000000184F67B90
		private bool DoJump(RuntimeClip runtimeClip, double localTime, double jumpTime); // 0x000000018D46F41C-0x000000018D46F4D8
		private bool _CheckIfTimeJumping(FrameData frameData, double localTime, bool allowInitialOptionJump = false /* Metadata: 0x02645469 */, double? deferredSeekSourceTime = default); // 0x0000000184F681C0-0x0000000184F6ABE0
		private void CacheTrack(TrackAsset track, Playable playable, int port, Playable parent); // 0x000000018D46D1B0-0x000000018D46D224
		public void SetTimeForNextFrame(double newTime); // 0x000000018725FC00-0x000000018725FC10
		public void RegisterTimeDilationListener(ITimeDilationListener listener); // 0x000000018D47202C-0x000000018D472080
		public void MarkMixerForbidPostProcess(Playable mixer); // 0x000000018D471A4C-0x000000018D471AA8
		public void MarkExcludeFromWeightProcessorCalc(Playable playable); // 0x000000018D4719F0-0x000000018D471A4C
		public bool CheckIfMixerForbidPostProcess(Playable mixer); // 0x000000018D46D224-0x000000018D46D288
		public bool ShouldExcludeFromWeightProcessorCalc(Playable playable); // 0x000000018D472A94-0x000000018D472AF8
		public void SetTimeScale(float usingTimeScale); // 0x000000018D472764-0x000000018D472950
		private void _NotifyTimeScaleChanged(float usingTimeScale); // 0x000000018D473020-0x000000018D47317C
	}

	public static class AnimationPreviewUtilities // TypeDefIndex: 86089
	{
	}

	internal static class Extrapolation // TypeDefIndex: 86091
	{
		// Fields
		internal static readonly double kMinExtrapolationTime; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86090
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<TimelineClip> __9__2_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D478F20-0x000000018D478F84
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _SortClipsByStartTime_b__2_0(TimelineClip clip1, TimelineClip clip2); // 0x000000018D45B650-0x000000018D45B68C
		}
	
		// Constructors
		static Extrapolation(); // 0x000000018D474BEC-0x000000018D474C58
	
		// Methods
		private static TimelineClip[] SortClipsByStartTime(TimelineClip[] clips); // 0x000000018D474AA8-0x000000018D474BEC
	
		// Extension methods
		internal static void CalculateExtrapolationTimes(this TrackAsset asset); // 0x000000018D4746D4-0x000000018D474AA8
	}

	internal static class HashUtility // TypeDefIndex: 86092
	{
		// Methods
		public static int CombineHash(int h1, int h2, int h3); // 0x000000018725FC70-0x000000018725FCB0
		public static int CombineHash(int h1, int h2, int h3, int h4); // 0x000000018725FC20-0x000000018725FC70
		public static int CombineHash(int h1, int h2, int h3, int h4, int h5); // 0x000000018D474C58-0x000000018D474C90
		public static int CombineHash(int h1, int h2, int h3, int h4, int h5, int h6); // 0x000000018D474C90-0x000000018D474CE4
	
		// Extension methods
		public static int CombineHash(this int h1, int h2); // 0x000000018725FCB0-0x000000018725FCD0
	}

	public interface IPropertyCollector // TypeDefIndex: 86093
	{
		// Methods
		void PushActiveGameObject(GameObject gameObject);
		void PopActiveGameObject();
		void AddFromClip(AnimationClip clip);
		void AddFromName<T>(string name)
			where T : UnityEngine.Component;
		void AddFromName<T>(GameObject obj, string name)
			where T : UnityEngine.Component;
		void AddFromName(GameObject obj, string name);
		void AddFromName(UnityEngine.Component component, string name);
		void AddFromComponent(GameObject obj, UnityEngine.Component component);
		void AddObjectProperties(UnityEngine.Object obj, AnimationClip clip);
	}

	public interface IPropertyPreview // TypeDefIndex: 86094
	{
		// Methods
		void GatherProperties(PlayableDirector director, IPropertyCollector driver);
	}

	internal static class NotificationUtilities // TypeDefIndex: 86095
	{
		// Methods
		public static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, double duration, DirectorWrapMode extrapolationMode); // 0x000000018D474CE4-0x000000018D4750C8
		public static bool TrackTypeSupportsNotifications(System.Type type); // 0x000000018D4750C8-0x000000018D4751E8
	}

	public static class PlayableDirectorUtility // TypeDefIndex: 86096
	{
		// Methods
		public static void SetOptionIndexAllTimeline(PlayableDirector director, int lastOptionIndex, int curOptionIndex); // 0x000000018D47548C-0x000000018D475738
		public static void SetOptionIndexSingleDirector(PlayableDirector director, int curOptionIndex, int lastOptionIndex); // 0x000000018D475738-0x000000018D475774
		public static TimelinePlayable GetTimelinePlayable(PlayableDirector director); // 0x000000018D475410-0x000000018D47548C
		public static TimelinePlayable GetTimelinePlayable(PlayableGraph graph); // 0x000000018D475358-0x000000018D475410
		public static TimelinePlayable GetTimelinePlayableFromChildPlayable(Playable playable); // 0x000000018D4752AC-0x000000018D475358
		public static bool CheckIfTimelineFunctional(Playable playable); // 0x000000018D4751E8-0x000000018D4752AC
	}

	public static class TimelineClipExtensions // TypeDefIndex: 86097
	{
		// Fields
		private static readonly string k_UndoSetParentTrackText; // 0x00
	
		// Constructors
		static TimelineClipExtensions(); // 0x000000018D475848-0x000000018D4758A4
	}

	public static class TimelineCreateUtilities // TypeDefIndex: 86100
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 86098
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GenerateUniqueActorName_b__0(ScriptableObject x); // 0x000000018D478E84-0x000000018D478EBC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_1 // TypeDefIndex: 86099
		{
			// Fields
			public string result; // 0x10
	
			// Constructors
			public __c__DisplayClass0_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GenerateUniqueActorName_b__1(ScriptableObject x); // 0x000000018D478E84-0x000000018D478EBC
		}
	
		// Methods
		public static string GenerateUniqueActorName(List<ScriptableObject> tracks, string name); // 0x000000018D475AE4-0x000000018D475DA4
		public static void SaveAssetIntoObject(UnityEngine.Object childAsset, UnityEngine.Object masterAsset); // 0x000000018D475DA4-0x000000018D475E64
		public static AnimationClip CreateAnimationClipForTrack(string name, TrackAsset track, bool isLegacy); // 0x000000018D475940-0x000000018D475AE4
		public static bool ValidateParentTrack(TrackAsset parent, System.Type childType); // 0x000000018D475E64-0x000000018D476088
	}

	public class TimelineRuntimeUtils // TypeDefIndex: 86101
	{
		// Constructors
		public TimelineRuntimeUtils(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static double GetTimelineDeltaTime(Playable playable, FrameData frameData); // 0x000000018D478440-0x000000018D4784B8
		public static bool TrySetNewOptionIndex(ITimelineRootMarker timelineRoot, int newOptionIndex); // 0x000000018D478B04-0x000000018D478D70
		private static bool TrySetNewOptionIndex(PlayableDirector director, int newOptionIndex, bool logFailure); // 0x000000018D478D70-0x000000018D478E24
		public static bool TrySetAllOptionIndex(ITimelineRootMarker timelineRoot, int curOptionIndex, int lastOptionIndex); // 0x000000018D478A74-0x000000018D478B04
		public static bool TrySetAllOptionIndex(PlayableDirector director, int curOptionIndex, int lastOptionIndex); // 0x000000018D4789C8-0x000000018D478A74
		public static bool CheckWillRuntimeElementEnabled(RuntimeElement element, int curOptionIndex, int lastOptionIndex, long curDiscreteTime); // 0x000000018D476088-0x000000018D47612C
		public static void DoReverseJump(RuntimeClip jumpClip, ITimelineRootMarker timelineRoot, double curTime, double jumpTime, double mixDuration, int curOptionIndex, int lastOptionIndex, bool needChangeOptionAfterJump, int newOptionIndex); // 0x000000018D476FB8-0x000000018D477E3C
		public static void DoJump(RuntimeClip jumpClip, ITimelineRootMarker timelineRoot, double curTime, double jumpTime, double mixDuration, int curOptionIndex, int lastOptionIndex, bool needChangeOptionAfterJump, int optionIndexChangingTo); // 0x000000018D47612C-0x000000018D476FB8
		public static double GetSubDirectorTimeForDirectorControl(Playable playable, PlayableDirector director); // 0x000000018D4782F8-0x000000018D478440
		public static void SetNewTimeForCutsceneRoot(ITimelineRootMarker timelineRoot, double newTime, bool useThisTimeNextFrame = false /* Metadata: 0x0264546A */); // 0x000000018D478714-0x000000018D4789C8
		public static AnimationClip FindTPoseClipFromLayerDescriptors(List<LayerDescriptor> layerDescriptors); // 0x000000018D477E3C-0x000000018D4782F8
		public static int LinkDefaultTPoseIfNeeded(AnimationLayerMixerPlayable mixer, List<LayerDescriptor> layerDescriptors, string gameObjectName); // 0x000000018D478684-0x000000018D478714
		public static int LinkDefaultTPoseClip(AnimationLayerMixerPlayable mixer, AnimationClip tposeClip, string gameObjectName); // 0x000000018D4784B8-0x000000018D478684
	}

	internal static class TimelineUndo // TypeDefIndex: 86102
	{
		// Methods
		public static void PushDestroyUndo(TimelineAsset timeline, UnityEngine.Object thingToDirty, UnityEngine.Object objectToDestroy); // 0x000000018D478E24-0x000000018D478E84
	}

	public enum StandardFrameRates // TypeDefIndex: 86103
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

	internal static class TimeUtility // TypeDefIndex: 86105
	{
		// Fields
		public static readonly double kTimeEpsilon; // 0x00
		public static readonly double kFrameRateEpsilon; // 0x08
		public static readonly double k_MaxTimelineDurationInSeconds; // 0x10
		public static readonly double kFrameRateRounding; // 0x18
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86104
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x000000018D478EBC-0x000000018D478F20
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		static TimeUtility(); // 0x00000001871892E0-0x0000000187189380
	
		// Methods
		public static double GetAnimationClipLength(AnimationClip clip); // 0x000000018D475774-0x000000018D475848
	}

	internal static class WeightUtility // TypeDefIndex: 86106
	{
		// Methods
		public static float NormalizeMixer(Playable mixer); // 0x000000018D479190-0x000000018D479414
		public static float NormalizeMixerForTakeOver(Playable mixer, Func<Playable, bool> shouldExcludeFromWeightProcessorCalc); // 0x000000018D478F84-0x000000018D479190
	}
}

namespace UnityEngine.Timeline.Condition
{
	[ExecuteAlways]
	public class TimelineConditionControlMono : MonoBehaviour // TypeDefIndex: 86107
	{
		// Fields
		public TimelineConditionBase condition; // 0x18
	
		// Constructors
		public TimelineConditionControlMono(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void RefreshOnCondition(); // 0x000000018D4758A4-0x000000018D475940
	}
}
