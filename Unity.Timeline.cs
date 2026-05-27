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
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Scripting;
using UnityEngine.Serialization;
using UnityEngine.Timeline;

// Image 46: Unity.Timeline.dll - Assembly: Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 56384-56574
[assembly: AssemblyCompany("Unity Technologies")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCopyright("Copyright \uFFFD 2016")]
[assembly: AssemblyDescription("Unity Timeline")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyProduct("UnityEngine.Timeline")]
[assembly: AssemblyTitle("UnityEngine.Timeline")]
[assembly: AssemblyTrademark("")]
[assembly: CompilationRelaxations(8)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: Guid("6A10B290-9283-487F-913B-00D94CD3FAF5")]
[assembly: InternalsVisibleTo("Unity.Timeline.Editor")]
[assembly: InternalsVisibleTo("Assembly-CSharp-testable")]
[assembly: InternalsVisibleTo("Assembly-CSharp-Editor-testable")]
[assembly: InternalsVisibleTo("Unity.Timeline.EditorTests")]
[assembly: InternalsVisibleTo("Unity.Timeline.Tests")]
[assembly: InternalsVisibleTo("Unity.Timeline.Tests.Common")]
[assembly: InternalsVisibleTo("Unity.Timeline.Tests.Performance")]
[assembly: InternalsVisibleTo("Unity.Timeline.Tests.Performance.Editor")]
[assembly: UnityEngine.Scripting.Preserve]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Gameplay.Core
{
	[AttributeUsage(AttributeTargets.Class)]
	public class DontAutoBindAttribute : DontAutoBindRuntimeAttribute // TypeDefIndex: 56398
	{
		// Constructors
		public DontAutoBindAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class DontAutoBindRuntimeAttribute : Attribute // TypeDefIndex: 56399
	{
		// Constructors
		public DontAutoBindRuntimeAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public class BeyondUseAutoBindingPlayableAsset : PlayableAsset // TypeDefIndex: 56400
	{
		// Fields
		[HideInInspector]
		public bool useAutoBinding; // 0x18
		[HideInInspector]
		public string autoBindingPath; // 0x20
		[NonSerialized]
		protected GameObject m_bindingGo; // 0x28
	
		// Properties
		public virtual GameObject bindingGameObject { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
	
		// Constructors
		public BeyondUseAutoBindingPlayableAsset() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		public void SetBindingGameObject(GameObject tBindingGameObject) {} // 0x0000000189D26F30-0x0000000189D26F58
		protected virtual void OnBindGoChanged() {} // 0x000000018350B670-0x000000018350B680
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x0000000189D26EE4-0x0000000189D26F30
	}

	public class RuntimeJumpBehaviour : PlayableBehaviour // TypeDefIndex: 56401
	{
		// Constructors
		public RuntimeJumpBehaviour() {} // 0x000000018350B670-0x000000018350B680
	}

	public class RuntimeJumpClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 56402
	{
		// Fields
		public bool isReverseJump; // 0x18
		public bool needChangeOptionAfterJump; // 0x19
		public int optionIndexAfterJump; // 0x1C
		public double crossFadeDurationAfterJump; // 0x20
		public bool isJumpFirst; // 0x28
	
		// Properties
		public ClipCaps clipCaps { get => default; } // 0x0000000183D5CA10-0x0000000183D5CA20 
	
		// Constructors
		public RuntimeJumpClip() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x0000000189D29FFC-0x0000000189D2A094
	}

	[CombineToTopPlayable]
	[System.ComponentModel.DisplayName("Beyond/RuntimeJumpTrack")]
	[SupportsChildTracks(null, 2147483647)]
	[TrackClipType(typeof(RuntimeJumpClip))]
	public class RuntimeJumpTrack : TrackAsset // TypeDefIndex: 56403
	{
		// Constructors
		public RuntimeJumpTrack() {} // 0x0000000189D2A094-0x0000000189D2A0E0
	}

	public class RuntimeLoopBehaviour : PlayableBehaviour // TypeDefIndex: 56404
	{
		// Constructors
		public RuntimeLoopBehaviour() {} // 0x000000018350B670-0x000000018350B680
	}

	public class RuntimeLoopClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 56405
	{
		// Fields
		public double crossFadeDuration; // 0x18
	
		// Properties
		public ClipCaps clipCaps { get => default; } // 0x0000000183D567A0-0x0000000183D567B0 
	
		// Constructors
		public RuntimeLoopClip() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x0000000189D2A0E0-0x0000000189D2A178
	}

	[CombineToTopPlayable]
	[System.ComponentModel.DisplayName("Beyond/RuntimeLoopTrack")]
	[SupportsChildTracks(null, 2147483647)]
	[TrackClipType(typeof(RuntimeLoopClip))]
	public class RuntimeLoopTrack : TrackAsset // TypeDefIndex: 56406
	{
		// Constructors
		public RuntimeLoopTrack() {} // 0x0000000189D2A178-0x0000000189D2A1C4
	}

	[ExecuteInEditMode]
	public class TimelineNPCLookAtController : MonoBehaviour // TypeDefIndex: 56407
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
		public static IEnumerable<TimelineNPCLookAtController> Instances { get => default; } // 0x0000000189D2E11C-0x0000000189D2E16C 
		public bool lookAtDirty { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public float lookAtWeight { get => default; set {} } // 0x0000000189D2E67C-0x0000000189D2E6F0 0x0000000189D2EC70-0x0000000189D2ECE8
		public float lookAtBodyWeight { get => default; set {} } // 0x0000000189D2E2C4-0x0000000189D2E338 0x0000000189D2E8A8-0x0000000189D2E920
		public float lookAtRoll { get => default; set {} } // 0x0000000189D2E518-0x0000000189D2E58C 0x0000000189D2EB04-0x0000000189D2EB7C
		public float lookAtHorizontal { get => default; set {} } // 0x0000000189D2E494-0x0000000189D2E518 0x0000000189D2EA88-0x0000000189D2EB04
		public float lookAtVertical { get => default; set {} } // 0x0000000189D2E5F8-0x0000000189D2E67C 0x0000000189D2EBF4-0x0000000189D2EC70
		public float lookAtEyeWeight { get => default; set {} } // 0x0000000189D2E418-0x0000000189D2E494 0x0000000189D2EA10-0x0000000189D2EA88
		public bool lookAtUseDegree { get => default; set {} } // 0x0000000189D2E58C-0x0000000189D2E5F8 0x0000000189D2EB7C-0x0000000189D2EBF4
		public bool EyeUseDegree { get => default; set {} } // 0x0000000189D2E0B0-0x0000000189D2E11C 0x0000000189D2E6F0-0x0000000189D2E768
		public float lookAtEyeUp { get => default; set {} } // 0x0000000189D2E3A8-0x0000000189D2E418 0x0000000189D2E998-0x0000000189D2EA10
		public float lookAtEyeDown { get => default; set {} } // 0x0000000189D2E338-0x0000000189D2E3A8 0x0000000189D2E920-0x0000000189D2E998
		public Vector3 finalPosition { get => default; set {} } // 0x0000000189D2E218-0x0000000189D2E2C4 0x0000000189D2E808-0x0000000189D2E8A8
		public Vector3 finalEyePosition { get => default; set {} } // 0x0000000189D2E16C-0x0000000189D2E218 0x0000000189D2E768-0x0000000189D2E808
	
		// Constructors
		public TimelineNPCLookAtController() {} // 0x0000000189D2E0A0-0x0000000189D2E0B0
		static TimelineNPCLookAtController() {} // 0x0000000189D2E014-0x0000000189D2E0A0
	
		// Methods
		private void OnEnable() {} // 0x0000000189D2DFA4-0x0000000189D2E014
		private void OnDisable() {} // 0x0000000189D2DF34-0x0000000189D2DFA4
		public void MarkLookAtDirty() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 56393
	{
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 56394
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 56395
	{
		// Constructors
		public DataNAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 56396
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 56397
	{
		// Constructors
		public ECSComponentAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace Events
{
	public interface INotificationTrack // TypeDefIndex: 56391
	{
	}

	public interface ITimelineNotification // TypeDefIndex: 56392
	{
		// Methods
		void OnNotify(ITimelineRootMarker root);
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 56385
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace ScriptAnimation
{
	[UseScriptDefaultValueWhenExport]
	public class TimelineNPCClothWeightController : MonoBehaviour // TypeDefIndex: 56386
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
		public TimelineNPCClothWeightController() {} // 0x0000000189D2DF10-0x0000000189D2DF34
	}

	[UseScriptDefaultValueWhenExport]
	public class TimelineNPCLookAtEyeTarget : MonoBehaviour // TypeDefIndex: 56387
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
		public TimelineNPCLookAtEyeTarget() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void ResetLookAtWeight() {} // 0x0000000183D65C60-0x0000000183D65C70
	}

	[UseScriptDefaultValueWhenExport]
	public class TimelineNPCLookAtTarget : MonoBehaviour // TypeDefIndex: 56388
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
		public TimelineNPCLookAtTarget() {} // 0x0000000189D2ECE8-0x0000000189D2ED08
	
		// Methods
		public void ResetLookAtWeight() {} // 0x0000000183D85650-0x0000000183D85660
	}
}

namespace ScriptAnimation.ScriptAnimationApply
{
	public class ScriptAnimationApplyBehaviour : PlayableBehaviour // TypeDefIndex: 56389
	{
		// Fields
		private IScriptAnimationJobSync m_JobSync; // 0x10
	
		// Constructors
		public ScriptAnimationApplyBehaviour() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x0000000189D2A1C4-0x0000000189D2A234
		public void InitBehaviour(IScriptAnimationJobSync jobSync) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	public class ScriptAnimationApplyPlayable : PlayableAsset // TypeDefIndex: 56390
	{
		// Constructors
		public ScriptAnimationApplyPlayable() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x0000000189D2A234-0x0000000189D2A2CC
	}
}

namespace UnityEngine
{
	public static class PlayerLoopChecker // TypeDefIndex: 56408
	{
	}
}

namespace UnityEngine.Timeline
{
	internal class ActivationMixerPlayable : PlayableBehaviour // TypeDefIndex: 56409
	{
		// Fields
		private ActivationTrack.PostPlaybackState m_PostPlaybackState; // 0x10
		private bool m_BoundGameObjectInitialStateIsActive; // 0x14
		private GameObject m_BoundGameObject; // 0x18
	
		// Properties
		public ActivationTrack.PostPlaybackState postPlaybackState { set {} } // 0x00000001810410F0-0x0000000181041100
	
		// Constructors
		public ActivationMixerPlayable() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static ScriptPlayable<ActivationMixerPlayable> Create(PlayableGraph graph, int inputCount) => default; // 0x0000000189D1DF24-0x0000000189D1DFB0
		public void SetBoundGameObject(GameObject go) {} // 0x0000000189D1E1A8-0x0000000189D1E238
		public override void OnPlayableDestroy(Playable playable) {} // 0x000000018350B670-0x000000018350B680
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x0000000189D1DFB0-0x0000000189D1DFF4
		public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x0000000189D1E0C8-0x0000000189D1E1A8
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x0000000189D1DFF4-0x0000000189D1E0C8
		private void _DoSetActive(Playable playable, FrameData info, object playerData = null) {} // 0x0000000189D1E238-0x0000000189D1E3BC
	}

	public class ActivationPlayableAsset : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 56410
	{
		// Properties
		public ClipCaps clipCaps { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public ActivationPlayableAsset() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go) => default; // 0x0000000189D1E3BC-0x0000000189D1E428
	}

	[Serializable]
	[ExcludeFromPreset]
	[TrackBindingType(typeof(GameObject))]
	[TrackClipType(typeof(ActivationPlayableAsset))]
	public class ActivationTrack : TrackAsset // TypeDefIndex: 56412
	{
		// Fields
		[SerializeField]
		private PostPlaybackState m_PostPlaybackState; // 0xC0
		private ActivationMixerPlayable m_ActivationMixer; // 0xC8
	
		// Properties
		public PostPlaybackState postPlaybackState { get => default; set {} } // 0x0000000183D57EF0-0x0000000183D57F00 0x0000000189D1E7F4-0x0000000189D1E804
	
		// Nested types
		public enum PostPlaybackState // TypeDefIndex: 56411
		{
			Active = 0,
			Inactive = 1,
			Revert = 2,
			LeaveAsIs = 3
		}
	
		// Constructors
		public ActivationTrack() {} // 0x00000001831514D0-0x0000000183151530
	
		// Methods
		internal override bool CanCompileClips() => default; // 0x0000000189D1E428-0x0000000189D1E458
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) => default; // 0x0000000189D1E458-0x0000000189D1E5E8
		internal GameObject GetBinding(PlayableDirector director) => default; // 0x0000000189D1E688-0x0000000189D1E788
		internal void UpdateTrackMode() {} // 0x0000000189D1E7D8-0x0000000189D1E7F4
		public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) {} // 0x0000000189D1E5E8-0x0000000189D1E688
		protected override void OnCreateClip(TimelineClip clip) {} // 0x0000000189D1E788-0x0000000189D1E7D8
	}

	internal class AnimationOutputWeightProcessor : ITimelineEvaluateCallback // TypeDefIndex: 56414
	{
		// Fields
		private Animator m_outputAnimator; // 0x10
		private AnimationPlayableOutput m_Output; // 0x18
		private readonly List<WeightInfo> m_Mixers; // 0x28
	
		// Nested types
		private struct WeightInfo // TypeDefIndex: 56413
		{
			// Fields
			public Playable mixer; // 0x00
			public Playable parentMixer; // 0x10
			public int port; // 0x20
		}
	
		// Constructors
		public AnimationOutputWeightProcessor() {} // Dummy constructor
		public AnimationOutputWeightProcessor(AnimationPlayableOutput output, Animator animator) {} // 0x0000000189D20768-0x0000000189D20838
	
		// Methods
		private void FindMixers() {} // 0x0000000189D203A0-0x0000000189D20494
		private void FindMixers(Playable parent, int port, Playable node) {} // 0x0000000189D20494-0x0000000189D20768
		public void Evaluate() {} // 0x0000000189D201A4-0x0000000189D203A0
	}

	[Serializable]
	[UnityEngine.Timeline.NotKeyable]
	public class AnimationPlayableAsset : PlayableAsset, ITimelineClipAsset, IPropertyPreview, ISerializationCallbackReceiver // TypeDefIndex: 56421
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
		private bool m_DynamicLink; // 0x4A
		[SerializeField]
		private ClothResetOption m_ClothResetOption; // 0x4C
		[SerializeField]
		private AnimationEventTriggerMode m_AnimationEventTriggerMode; // 0x50
		[SerializeField]
		private bool m_MixWitherAnotherClip; // 0x54
		[Range(0f, 1f)]
		[SerializeField]
		private float m_MainClipMixWeight; // 0x58
		[SerializeField]
		private AnimationClip m_AnotherClip; // 0x60
		private static readonly int k_LatestVersion; // 0x00
		[HideInInspector]
		[SerializeField]
		private int m_Version; // 0x78
		[HideInInspector]
		[Obsolete("Use m_RotationEuler Instead", false)]
		[SerializeField]
		private Quaternion m_Rotation; // 0x7C
	
		// Properties
		public Vector3 position { get => default; set {} } // 0x0000000183D59660-0x0000000183D59680 0x0000000183D5AE00-0x0000000183D5AE10
		public Quaternion rotation { get => default; set {} } // 0x0000000189D21A38-0x0000000189D21A74 0x0000000189D21B18-0x0000000189D21B40
		public Vector3 eulerAngles { get => default; set {} } // 0x0000000183D59800-0x0000000183D59820 0x0000000183D5BF30-0x0000000183D5BF40
		public bool useTrackMatchFields { get => default; set {} } // 0x0000000183D4F190-0x0000000183D4F1A0 0x0000000183D4E280-0x0000000183D4E290
		public MatchTargetFields matchTargetFields { get => default; set {} } // 0x0000000183D4ED90-0x0000000183D4EDA0 0x0000000183D4EDC0-0x0000000183D4EDD0
		public bool removeStartOffset { get => default; set {} } // 0x0000000183D4EE90-0x0000000183D4EEA0 0x0000000183D4EEB0-0x0000000183D4EEC0
		public bool applyFootIK { get => default; set {} } // 0x0000000183D4F7B0-0x0000000183D4F7C0 0x0000000183D4F7D0-0x0000000183D4F7E0
		public LoopMode loop { get => default; set {} } // 0x0000000183D4EE80-0x0000000183D4EE90 0x0000000183D4EEA0-0x0000000183D4EEB0
		public bool IgniteOnce { get => default; set {} } // 0x0000000183D4EFE0-0x0000000183D4EFF0 0x0000000183D4F010-0x0000000183D4F020
		public bool OnlyDeltaTime { get => default; set {} } // 0x0000000183D4EFF0-0x0000000183D4F000 0x0000000183D4F020-0x0000000183D4F030
		public bool DynamicLink { get => default; set {} } // 0x0000000183D4F780-0x0000000183D4F790 0x0000000183D4F790-0x0000000183D4F7A0
		public bool MixWithAnotherClip { get => default; set {} } // 0x0000000183D4F320-0x0000000183D4F330 0x0000000183D4F350-0x0000000183D4F360
		public AnimationClip AnotherClip { get => default; set {} } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
		public float MainClipMixWeight { get => default; set {} } // 0x0000000183D51080-0x0000000183D51090 0x0000000183D510B0-0x0000000183D510C0
		internal bool hasRootTransforms { get => default; } // 0x0000000189D21948-0x0000000189D219C8 
		internal AppliedOffsetMode appliedOffsetMode { get; set; } // 0x0000000183D4EEE0-0x0000000183D4EEF0 0x0000000183D4EF30-0x0000000183D4EF40
		internal ITimelineAnimationEventContextBinding TimelineAnimationEventContextBinding { get; set; } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
		public AnimationClip clip { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x0000000189D21A74-0x0000000189D21B18
		public override double duration { get => default; } // 0x0000000189D218E0-0x0000000189D21948 
		public ClothResetOption clothResetOption { get => default; set {} } // 0x0000000183D4EDF0-0x0000000183D4EE00 0x0000000183D4EE30-0x0000000183D4EE40
		public AnimationEventTriggerMode animationEventTriggerMode { get => default; set {} } // 0x0000000183D4EED0-0x0000000183D4EEE0 0x0000000183D4EF20-0x0000000183D4EF30
		public override IEnumerable<PlayableBinding> outputs { [IteratorStateMachine(typeof(_get_outputs_d__83))] get => default; } // 0x0000000189D219C8-0x0000000189D21A38 
		public ClipCaps clipCaps { get => default; } // 0x0000000189D217F0-0x0000000189D218E0 
	
		// Nested types
		public enum LoopMode // TypeDefIndex: 56415
		{
			UseSourceAsset = 0,
			On = 1,
			Off = 2
		}
	
		public enum ClothResetOption // TypeDefIndex: 56416
		{
			SoftReset = 0,
			UseClothRelativeTeleport = 1,
			UseStablizationTime = 2,
			DisablePhysics = 3
		}
	
		public enum AnimationEventTriggerMode // TypeDefIndex: 56417
		{
			Default = 0,
			MuteAllEvents = 1,
			SeekAllEvents = 2
		}
	
		private enum Versions // TypeDefIndex: 56418
		{
			Initial = 0,
			RotationAsEuler = 1
		}
	
		private static class AnimationPlayableAssetUpgrade // TypeDefIndex: 56419
		{
			// Methods
			public static void ConvertRotationToEuler(AnimationPlayableAsset asset) {} // 0x0000000189D20838-0x0000000189D20870
		}
	
		// Constructors
		public AnimationPlayableAsset() {} // 0x0000000189D21744-0x0000000189D217F0
		static AnimationPlayableAsset() {} // 0x0000000189D21708-0x0000000189D21744
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go) => default; // 0x0000000189D211EC-0x0000000189D21264
		internal static Playable CreatePlayable(PlayableGraph graph, AnimationClip clip, Vector3 positionOffset, Vector3 eulerOffset, bool removeStartOffset, AppliedOffsetMode mode, bool applyFootIK, LoopMode loop) => default; // 0x0000000189D20ED4-0x0000000189D211EC
		internal static Playable CreatePlayable(PlayableGraph graph, AnimationPlayableAsset playableAsset) => default; // 0x0000000189D20914-0x0000000189D20ED4
		internal static AnimationClipPlayable CreateAnimationClipPlayable(PlayableGraph graph, AnimationClip clip, bool removeStartOffset, bool applyFootIK, LoopMode loop) => default; // 0x0000000189D20890-0x0000000189D20914
		private static bool ShouldApplyOffset(AppliedOffsetMode mode, AnimationClip clip) => default; // 0x0000000189D213F0-0x0000000189D2144C
		private static bool ShouldApplyEventControl(AnimationPlayableAsset playableAsset) => default; // 0x0000000189D21388-0x0000000189D213F0
		internal static Playable TryApplyAnimationEventControl(PlayableGraph graph, Playable root, AnimationPlayableAsset playableAsset) => default; // 0x0000000189D21460-0x0000000189D2164C
		private static bool ShouldApplyScaleRemove(AppliedOffsetMode mode) => default; // 0x0000000189D2144C-0x0000000189D21460
		public void ResetOffsets() {} // 0x0000000189D21364-0x0000000189D21388
		public void GatherProperties(PlayableDirector director, IPropertyCollector driver) {} // 0x0000000189D21264-0x0000000189D212B4
		internal static bool HasRootTransforms(AnimationClip clip) => default; // 0x0000000189D212B4-0x0000000189D21354
		public AnimationEvent[] CollectAnimationEvents() => default; // 0x0000000189D20870-0x0000000189D20890
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000189D216B0-0x0000000189D21708
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x0000000189D2164C-0x0000000189D216B0
		private void OnUpgradeFromVersion(int oldVersion) {} // 0x0000000189D21354-0x0000000189D21364
	}

	internal class AnimationPreviewUpdateCallback // TypeDefIndex: 56422
	{
		// Constructors
		public AnimationPreviewUpdateCallback() {} // Dummy constructor
	}

	[Flags]
	public enum MatchTargetFields // TypeDefIndex: 56423
	{
		PositionX = 1,
		PositionY = 2,
		PositionZ = 4,
		RotationX = 8,
		RotationY = 16,
		RotationZ = 32
	}

	public enum TrackOffset // TypeDefIndex: 56424
	{
		ApplyTransformOffsets = 0,
		ApplySceneOffsets = 1,
		Auto = 2
	}

	internal enum AppliedOffsetMode // TypeDefIndex: 56425
	{
		NoRootTransform = 0,
		TransformOffset = 1,
		SceneOffset = 2,
		TransformOffsetLegacy = 3,
		SceneOffsetLegacy = 4,
		SceneOffsetEditor = 5,
		SceneOffsetLegacyEditor = 6
	}

	internal static class MatchTargetFieldConstants // TypeDefIndex: 56426
	{
		// Fields
		public static MatchTargetFields All; // 0x00
		public static MatchTargetFields None; // 0x04
		public static MatchTargetFields Position; // 0x08
		public static MatchTargetFields Rotation; // 0x0C
	
		// Constructors
		static MatchTargetFieldConstants() {} // 0x0000000189D29F84-0x0000000189D29FFC
	}

	[Serializable]
	[ExcludeFromPreset]
	[TrackBindingType(typeof(Animator))]
	[TrackClipType(typeof(AnimationPlayableAsset), false)]
	public class AnimationTrack : TrackAsset, ILayerable // TypeDefIndex: 56429
	{
		// Fields
		private const string k_DefaultInfiniteClipName = "Recorded"; // Metadata: 0x01FD8064
		private const string k_DefaultRecordableClipName = "Recorded"; // Metadata: 0x01FD806D
		[FormerlySerializedAs("m_OpenClipPreExtrapolation")]
		[SerializeField]
		private TimelineClip.ClipExtrapolation m_InfiniteClipPreExtrapolation; // 0xC0
		[FormerlySerializedAs("m_OpenClipPostExtrapolation")]
		[SerializeField]
		private TimelineClip.ClipExtrapolation m_InfiniteClipPostExtrapolation; // 0xC4
		[FormerlySerializedAs("m_OpenClipOffsetPosition")]
		[SerializeField]
		private Vector3 m_InfiniteClipOffsetPosition; // 0xC8
		[FormerlySerializedAs("m_OpenClipOffsetEulerAngles")]
		[SerializeField]
		private Vector3 m_InfiniteClipOffsetEulerAngles; // 0xD4
		[FormerlySerializedAs("m_OpenClipTimeOffset")]
		[SerializeField]
		private double m_InfiniteClipTimeOffset; // 0xE0
		[FormerlySerializedAs("m_OpenClipRemoveOffset")]
		[SerializeField]
		private bool m_InfiniteClipRemoveOffset; // 0xE8
		[SerializeField]
		private bool m_InfiniteClipApplyFootIK; // 0xE9
		[HideInInspector]
		[SerializeField]
		private AnimationPlayableAsset.LoopMode mInfiniteClipLoop; // 0xEC
		[SerializeField]
		private MatchTargetFields m_MatchTargetFields; // 0xF0
		[SerializeField]
		private Vector3 m_Position; // 0xF4
		[SerializeField]
		private Vector3 m_EulerAngles; // 0x100
		[SerializeField]
		private AvatarMask m_AvatarMask; // 0x110
		[SerializeField]
		private bool m_ApplyAvatarMask; // 0x118
		[SerializeField]
		private bool m_DisableFloatCurveOnMask; // 0x119
		[SerializeField]
		private TrackOffset m_TrackOffset; // 0x11C
		[HideInInspector]
		[SerializeField]
		private AnimationClip m_InfiniteClip; // 0x120
		[SerializeField]
		private bool m_IsAdditive; // 0x128
		[SerializeField]
		private bool m_IsAdditiveToLast; // 0x129
		[NonSerialized]
		public bool muteScriptAnimAddon; // 0x12A
		[SerializeField]
		private bool m_UseScriptAnimAddon; // 0x12B
		[SerializeField]
		private bool m_useTPoseAsDefaultPose; // 0x12C
		[SerializeField]
		private AnimationClip m_TPoseClip; // 0x130
		[SerializeField]
		private ScriptableObject m_TimelineNPCDescriptor; // 0x138
		[SerializeField]
		private string m_LookAtTargetPath; // 0x140
		[SerializeField]
		private bool m_LookAtUseAdditive; // 0x148
		[SerializeField]
		private bool m_WriteTransformDefAsPostProcess; // 0x149
		private Transform m_LookAtTarget; // 0x150
		[NonSerialized]
		private HashSet<RuntimeElement> m_allRuntimeClipUnderTrack; // 0x158
		private static readonly Queue<Transform> s_CachedQueue; // 0x00
		[HideInInspector]
		[Obsolete("Use m_InfiniteClipOffsetEulerAngles Instead", false)]
		[SerializeField]
		private Quaternion m_OpenClipOffsetRotation; // 0x160
		[HideInInspector]
		[Obsolete("Use m_RotationEuler Instead", false)]
		[SerializeField]
		private Quaternion m_Rotation; // 0x170
		[HideInInspector]
		[Obsolete("Use m_RootTransformOffsetMode", false)]
		[SerializeField]
		private bool m_ApplyOffsets; // 0x180
	
		// Properties
		public Vector3 position { get => default; set {} } // 0x0000000183D85530-0x0000000183D85550 0x0000000183D855F0-0x0000000183D85610
		public Quaternion rotation { get => default; set {} } // 0x0000000189D26038-0x0000000189D26078 0x0000000189D26124-0x0000000189D26154
		public Vector3 eulerAngles { get => default; set {} } // 0x0000000183D854C0-0x0000000183D854E0 0x0000000183D85560-0x0000000183D85580
		[Obsolete("applyOffset is deprecated. Use trackOffset instead", true)]
		public bool applyOffsets { get => default; set {} } // 0x000000018115F4C0-0x000000018115F530 0x000000018350B670-0x000000018350B680
		public TrackOffset trackOffset { get => default; set {} } // 0x0000000183D5D760-0x0000000183D5D770 0x0000000183D5D770-0x0000000183D5D780
		public MatchTargetFields matchTargetFields { get => default; set {} } // 0x0000000183D50F00-0x0000000183D50F10 0x0000000189D260A8-0x0000000189D26104
		public AnimationClip infiniteClip { get => default; internal set {} } // 0x0000000183D56D50-0x0000000183D56D60 0x0000000184275CA4-0x0000000184275CB8
		internal bool infiniteClipRemoveOffset { get => default; set {} } // 0x0000000183D554A0-0x0000000183D554B0 0x0000000183D554D0-0x0000000183D554E0
		public AvatarMask avatarMask { get => default; set {} } // 0x0000000183D56CF0-0x0000000183D56D00 0x0000000184275CF4-0x0000000184275D08
		public bool applyAvatarMask { get => default; set {} } // 0x0000000183D57B90-0x0000000183D57BA0 0x0000000183D5E110-0x0000000183D5E120
		public bool disableFloatCurveOnMask { get => default; set {} } // 0x0000000183D854B0-0x0000000183D854C0 0x0000000183D85550-0x0000000183D85560
		public bool isUsingScriptAnimAddon { get => default; set {} } // 0x0000000183D85520-0x0000000183D85530 0x0000000183D855E0-0x0000000183D855F0
		public bool lookAtUseAdditive { get => default; set {} } // 0x0000000183D57CB0-0x0000000183D57CC0 0x0000000183D5A1F0-0x0000000183D5A200
		public override IEnumerable<PlayableBinding> outputs { [IteratorStateMachine(typeof(_get_outputs_d__72))] get => default; } // 0x0000000189D25FC8-0x0000000189D26038 
		public bool inClipMode { get => default; } // 0x0000000189D25F18-0x0000000189D25F60 
		public Vector3 infiniteClipOffsetPosition { get => default; set {} } // 0x0000000183D85500-0x0000000183D85520 0x0000000183D855B0-0x0000000183D855D0
		public Quaternion infiniteClipOffsetRotation { get => default; set {} } // 0x0000000189D25F60-0x0000000189D25FA0 0x0000000189D26078-0x0000000189D260A8
		public Vector3 infiniteClipOffsetEulerAngles { get => default; set {} } // 0x0000000183D854E0-0x0000000183D85500 0x0000000183D85590-0x0000000183D855B0
		internal bool infiniteClipApplyFootIK { get => default; set {} } // 0x0000000183D58EB0-0x0000000183D58EC0 0x0000000183D85580-0x0000000183D85590
		internal double infiniteClipTimeOffset { get => default; set {} } // 0x0000000183D6B260-0x0000000183D6B270 0x0000000183D855D0-0x0000000183D855E0
		public TimelineClip.ClipExtrapolation infiniteClipPreExtrapolation { get => default; set {} } // 0x0000000183D57EF0-0x0000000183D57F00 0x0000000183D57F70-0x0000000183D57F80
		public TimelineClip.ClipExtrapolation infiniteClipPostExtrapolation { get => default; set {} } // 0x0000000183D68ED0-0x0000000183D68EE0 0x0000000183D68F40-0x0000000183D68F50
		internal AnimationPlayableAsset.LoopMode infiniteClipLoop { get => default; set {} } // 0x0000000183D58150-0x0000000183D58160 0x0000000183D68F50-0x0000000183D68F60
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("openClipOffsetPosition has been deprecated. Use infiniteClipOffsetPosition instead. (UnityUpgradable) -> infiniteClipOffsetPosition", true)]
		public Vector3 openClipOffsetPosition { get => default; set {} } // 0x0000000183D85500-0x0000000183D85520 0x0000000183D855B0-0x0000000183D855D0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("openClipOffsetRotation has been deprecated. Use infiniteClipOffsetRotation instead. (UnityUpgradable) -> infiniteClipOffsetRotation", true)]
		public Quaternion openClipOffsetRotation { get => default; set {} } // 0x0000000189D25FA0-0x0000000189D25FC8 0x0000000189D26104-0x0000000189D26124
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("openClipOffsetEulerAngles has been deprecated. Use infiniteClipOffsetEulerAngles instead. (UnityUpgradable) -> infiniteClipOffsetEulerAngles", true)]
		public Vector3 openClipOffsetEulerAngles { get => default; set {} } // 0x0000000183D854E0-0x0000000183D85500 0x0000000183D85590-0x0000000183D855B0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("openClipPreExtrapolation has been deprecated. Use infiniteClipPreExtrapolation instead. (UnityUpgradable) -> infiniteClipPreExtrapolation", true)]
		public TimelineClip.ClipExtrapolation openClipPreExtrapolation { get => default; set {} } // 0x0000000183D57EF0-0x0000000183D57F00 0x0000000183D57F70-0x0000000183D57F80
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("openClipPostExtrapolation has been deprecated. Use infiniteClipPostExtrapolation instead. (UnityUpgradable) -> infiniteClipPostExtrapolation", true)]
		public TimelineClip.ClipExtrapolation openClipPostExtrapolation { get => default; set {} } // 0x0000000183D68ED0-0x0000000183D68EE0 0x0000000183D68F40-0x0000000183D68F50
	
		// Nested types
		private static class AnimationTrackUpgrade // TypeDefIndex: 56427
		{
			// Methods
			public static void ConvertRotationsToEuler(AnimationTrack track) {} // 0x0000000189D21BE8-0x0000000189D21C50
			public static void ConvertRootMotion(AnimationTrack track) {} // 0x0000000189D21B80-0x0000000189D21BE8
			public static void ConvertInfiniteTrack(AnimationTrack track) {} // 0x0000000189D21B40-0x0000000189D21B80
		}
	
		// Constructors
		public AnimationTrack() {} // 0x0000000189D25D94-0x0000000189D25F18
		static AnimationTrack() {} // 0x0000000189D25D00-0x0000000189D25D94
	
		// Methods
		public bool IsControlByThisTrack(RuntimeElement element) => default; // 0x0000000189D2559C-0x0000000189D255F8
		internal override bool CanCompileClips() => default; // 0x0000000189D22EB8-0x0000000189D22F6C
		[ContextMenu("Reset Offsets")]
		private void ResetOffsets() {} // 0x0000000189D25A00-0x0000000189D25A30
		public TimelineClip CreateClip(AnimationClip clip) => default; // 0x0000000189D2379C-0x0000000189D23830
		public void CreateInfiniteClip(string infiniteClipName) {} // 0x0000000189D238A8-0x0000000189D23994
		public TimelineClip CreateRecordableClip(string animClipName) => default; // 0x0000000189D24A20-0x0000000189D24B2C
		protected override void OnCreateClip(TimelineClip clip) {} // 0x0000000189D258A4-0x0000000189D258DC
		protected internal override int CalculateItemsHash() => default; // 0x0000000189D22E44-0x0000000189D22EB8
		internal void UpdateClipOffsets() {} // 0x000000018350B670-0x000000018350B680
		private Playable _CreatePlayableFromClip(TimelineClip c, PlayableGraph graph, GameObject go, AppliedOffsetMode mode, ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding) => default; // 0x0000000189D25B9C-0x0000000189D25D00
		private Playable CompileTrackPlayable(PlayableGraph graph, AnimationTrack track, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode, ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding) => default; // 0x0000000189D22F6C-0x0000000189D2379C
		private bool ShouldLinkWithMainTrackMixer(AnimationTrack animationTrack) => default; // 0x0000000189D25A30-0x0000000189D25AB4
		private Playable ApplyScriptAnimationPlayable(PlayableGraph graph, AnimationLayerMixerPlayable mixer, GameObject go) => default; // 0x0000000189D220A0-0x0000000189D22550
		Playable ILayerable.CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount) => default; // 0x0000000189D25AB4-0x0000000189D25B04
		internal override Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree) => default; // 0x0000000189D23CFC-0x0000000189D24A20
		private void AttachCustomBlend(PlayableGraph graph, AnimationLayerMixerPlayable layerMixer) {} // 0x000000018350B670-0x000000018350B680
		private void AttachLastAdditiveClip(PlayableGraph graph, AnimationLayerMixerPlayable layerMixer, GameObject go, IntervalTree<RuntimeElement> tree, List<AnimationTrack> flattenTracks, ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding) {} // 0x0000000189D228B8-0x0000000189D22D0C
		private int GetDefaultBlendCount() => default; // 0x0000000181168950-0x0000000181168960
		private void AttachDefaultBlend(PlayableGraph graph, AnimationLayerMixerPlayable mixer, bool requireOffset, Animator animator) {} // 0x000000018350B670-0x000000018350B680
		private Playable AttachOffsetPlayable(PlayableGraph graph, Playable playable, Vector3 pos, Quaternion rot) => default; // 0x0000000189D22D0C-0x0000000189D22E44
		private bool RequiresMotionXPlayable(AppliedOffsetMode mode, GameObject gameObject) => default; // 0x0000000189D2591C-0x0000000189D25A00
		private static bool UsesAbsoluteMotion(AppliedOffsetMode mode) => default; // 0x0000000189D25B04-0x0000000189D25B14
		private bool HasController(GameObject gameObject) => default; // 0x0000000189D254BC-0x0000000189D2559C
		internal Animator GetBinding(PlayableDirector director) => default; // 0x0000000189D24FDC-0x0000000189D25154
		private static AnimationLayerMixerPlayable CreateGroupMixer(PlayableGraph graph, GameObject go, int inputCount) => default; // 0x0000000189D23830-0x0000000189D238A8
		private Playable CreateInfiniteTrackPlayable(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode) => default; // 0x0000000189D23994-0x0000000189D23CFC
		private Playable ApplyTrackOffset(PlayableGraph graph, Playable root, GameObject go, AppliedOffsetMode mode) => default; // 0x0000000189D22550-0x0000000189D226D4
		private void _AddClipIntoTree(IntervalTree<RuntimeElement> tree, RuntimeClip clip) {} // 0x0000000189D25B14-0x0000000189D25B9C
		internal override void GetEvaluationTime(out double outStart, out double outDuration) {
			outStart = default;
			outDuration = default;
		} // 0x0000000189D25154-0x0000000189D251E0
		internal override void GetSequenceTime(out double outStart, out double outDuration) {
			outStart = default;
			outDuration = default;
		} // 0x0000000189D253EC-0x0000000189D254BC
		private void AssignAnimationClip(TimelineClip clip, AnimationClip animClip) {} // 0x0000000189D226D4-0x0000000189D228B8
		public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) {} // 0x000000018350B670-0x000000018350B680
		private void GetAnimationClips(List<AnimationClip> animClips) {} // 0x0000000189D24CEC-0x0000000189D24FDC
		private AppliedOffsetMode GetOffsetMode(GameObject go, bool animatesRootTransform) => default; // 0x0000000189D25388-0x0000000189D253EC
		private bool IsRootTransformDisabledByMask(GameObject gameObject, Transform genericRootNode) => default; // 0x0000000189D255F8-0x0000000189D258A4
		private Transform GetGenericRootNode(GameObject gameObject) => default; // 0x0000000189D251E0-0x0000000189D25388
		internal bool AnimatesRootTransform() => default; // 0x0000000189D21C50-0x0000000189D220A0
		private static Transform FindInHierarchyBreadthFirst(Transform t, string name) => default; // 0x0000000189D24B2C-0x0000000189D24CEC
		internal override void OnUpgradeFromVersion(int oldVersion) {} // 0x0000000189D258DC-0x0000000189D2591C
	}

	internal interface ICurvesOwner // TypeDefIndex: 56430
	{
		// Properties
		string defaultCurvesName { get; }
		UnityEngine.Object asset { get; }
		UnityEngine.Object assetOwner { get; }
		TrackAsset targetTrack { get; }
	}

	[Serializable]
	public class TimelineClip : ICurvesOwner, ISerializationCallbackReceiver // TypeDefIndex: 56435
	{
		// Fields
		private const int k_LatestVersion = 1; // Metadata: 0x01FD8076
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
		public double timeScale { get => default; } // 0x0000000189D2DA8C-0x0000000189D2DB50 
		public double start { get => default; set {} } // 0x0000000183D4EBD0-0x0000000183D4EBE0 0x0000000189D2DE24-0x0000000189D2DF10
		public double duration { get => default; set {} } // 0x0000000183D4F240-0x0000000183D4F250 0x0000000189D2DB50-0x0000000189D2DBE4
		public double end { get => default; } // 0x0000000183D85640-0x0000000183D85650 
		public double clipIn { get => default; } // 0x0000000189D2D658-0x0000000189D2D67C 
		public string displayName { get => default; set {} } // 0x0000000183D4EAD0-0x0000000183D4EAE0 0x0000000182B47080-0x0000000182B470A0
		public double clipAssetDuration { get => default; } // 0x0000000189D2D588-0x0000000189D2D5E0 
		public AnimationClip curves { get => default; } // 0x0000000183D4EA60-0x0000000183D4EA70 
		string ICurvesOwner.defaultCurvesName { get => default; } // 0x0000000189D2D4B8-0x0000000189D2D508 
		public UnityEngine.Object asset { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		UnityEngine.Object ICurvesOwner.assetOwner { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		TrackAsset ICurvesOwner.targetTrack { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		public double easeInDuration { get => default; set {} } // 0x0000000189D2D67C-0x0000000189D2D710 0x0000000189D2DBE4-0x0000000189D2DCC8
		public double easeOutDuration { get => default; set {} } // 0x0000000189D2D710-0x0000000189D2D7A4 0x0000000189D2DCC8-0x0000000189D2DDAC
		public double blendInDuration { get => default; } // 0x0000000189D2D540-0x0000000189D2D564 
		public double blendOutDuration { get => default; } // 0x0000000189D2D564-0x0000000189D2D588 
		public bool hasBlendIn { get => default; } // 0x0000000189D2D880-0x0000000189D2D8B0 
		public bool hasBlendOut { get => default; } // 0x0000000189D2D8B0-0x0000000189D2D8E0 
		public AnimationCurve mixInCurve { get => default; set {} } // 0x0000000189D2D8E0-0x0000000189D2D948 0x00000001838C5570-0x00000001838C5580
		public double mixInDuration { get => default; } // 0x0000000189D2D948-0x0000000189D2D978 
		public AnimationCurve mixOutCurve { get => default; set {} } // 0x0000000189D2D978-0x0000000189D2D9E0 0x000000018519C3C8-0x000000018519C3D8
		public double mixOutTime { get => default; } // 0x0000000189D2DA10-0x0000000189D2DA44 
		public double mixOutDuration { get => default; } // 0x0000000189D2D9E0-0x0000000189D2DA10 
		public bool recordable { get => default; internal set {} } // 0x0000000183D58A70-0x0000000183D58A80 0x0000000183D58AB0-0x0000000183D58AC0
		public ClipCaps clipCaps { get => default; } // 0x0000000189D2D5E0-0x0000000189D2D658 
		public ClipExtrapolation postExtrapolationMode { get => default; set {} } // 0x0000000189D2DA44-0x0000000189D2DA68 0x0000000189D2DDAC-0x0000000189D2DDE8
		public ClipExtrapolation preExtrapolationMode { get => default; set {} } // 0x0000000189D2DA68-0x0000000189D2DA8C 0x0000000189D2DDE8-0x0000000189D2DE24
		public double extrapolatedStart { get => default; } // 0x0000000189D2D868-0x0000000189D2D880 
		public double extrapolatedDuration { get => default; } // 0x0000000189D2D7A4-0x0000000189D2D868 
	
		// Nested types
		private enum Versions // TypeDefIndex: 56431
		{
			Initial = 0,
			ClipInFromGlobalToLocal = 1
		}
	
		private static class TimelineClipUpgrade // TypeDefIndex: 56432
		{
			// Methods
			public static void UpgradeClipInFromGlobalToLocal(TimelineClip clip) {} // 0x0000000189D2C9F0-0x0000000189D2CA2C
		}
	
		public enum ClipExtrapolation // TypeDefIndex: 56433
		{
			None = 0,
			Hold = 1,
			Loop = 2,
			PingPong = 3,
			Continue = 4
		}
	
		public enum BlendCurveMode // TypeDefIndex: 56434
		{
			Auto = 0,
			Manual = 1
		}
	
		// Constructors
		public TimelineClip() {} // Dummy constructor
		internal TimelineClip(TrackAsset parent) {} // 0x0000000189D2D518-0x0000000189D2D540
		static TimelineClip() {} // 0x0000000183C916F0-0x0000000183C917F0
	
		// Methods
		private void UpgradeToLatestVersion() {} // 0x0000000189D2D508-0x0000000189D2D518
		public TrackAsset GetParentTrack() => default; // 0x0000000183D4E2B0-0x0000000183D4E2C0
		internal void SetParentTrack_Internal(TrackAsset newParentTrack) {} // 0x0000000189D2D148-0x0000000189D2D228
		internal int Hash() => default; // 0x0000000189D2CF04-0x0000000189D2CFB0
		public float EvaluateMixOut(double time) => default; // 0x0000000189D2CC90-0x0000000189D2CD74
		public float EvaluateMixOutAtGivenTime(double time, double mixOutTime, double mixOutDuration) => default; // 0x0000000189D2CBCC-0x0000000189D2CC90
		public float EvaluateMixIn(double time) => default; // 0x0000000189D2CAF0-0x0000000189D2CBCC
		public float EvaluateMixInAtGivenTime(double time, double runtimeMixInTime, double mixInDuration) => default; // 0x0000000189D2CA2C-0x0000000189D2CAF0
		private static AnimationCurve GetDefaultMixInCurve() => default; // 0x0000000189D2CD74-0x0000000189D2CD9C
		private static AnimationCurve GetDefaultMixOutCurve() => default; // 0x0000000189D2CD9C-0x0000000189D2CDC4
		public double ToLocalTime(double time) => default; // 0x0000000189D2D228-0x0000000189D2D33C
		private static double SanitizeTimeValue(double value, double defaultValue) => default; // 0x0000000189D2D050-0x0000000189D2D148
		internal void SetPostExtrapolationTime(double time) {} // 0x0000000183D85620-0x0000000183D85630
		internal void SetPreExtrapolationTime(double time) {} // 0x0000000183D85630-0x0000000183D85640
		public bool IsPreExtrapolatedTime(double sequenceTime) => default; // 0x0000000189D2D008-0x0000000189D2D050
		public bool IsPostExtrapolatedTime(double sequenceTime) => default; // 0x0000000189D2CFB0-0x0000000189D2D008
		private static double GetExtrapolatedTime(double time, ClipExtrapolation mode, double duration) => default; // 0x0000000189D2CDC4-0x0000000189D2CF04
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000183D51DD0-0x0000000183D51DE0
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x0000000183528C50-0x0000000183528C70
		public override string ToString() => default; // 0x0000000189D2D33C-0x0000000189D2D4B8
		private void UpdateDirty(double oldValue, double newValue) {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	[ExcludeFromPreset]
	public class TimelineAsset : PlayableAsset, ISerializationCallbackReceiver, ITimelineClipAsset, IPropertyPreview // TypeDefIndex: 56442
	{
		// Fields
		private const int k_LatestVersion = 0; // Metadata: 0x01FD8080
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
		public EditorSettings editorSettings { get => default; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		public override double duration { get => default; } // 0x0000000189D2C640-0x0000000189D2C6C0 
		public double fixedDuration { get => default; set {} } // 0x0000000189D2C6C0-0x0000000189D2C740 0x0000000189D2C978-0x0000000189D2C9D0
		public DurationMode durationMode { get => default; set {} } // 0x0000000183D4EF00-0x0000000183D4EF10 0x0000000183D4EF50-0x0000000183D4EF60
		public override IEnumerable<PlayableBinding> outputs { [IteratorStateMachine(typeof(_get_outputs_d__28))] get => default; } // 0x0000000189D2C8C0-0x0000000189D2C930 
		public ClipCaps clipCaps { get => default; } // 0x0000000189D2C42C-0x0000000189D2C640 
		public int outputTrackCount { get => default; } // 0x0000000189D2C898-0x0000000189D2C8C0 
		public int rootTrackCount { get => default; } // 0x0000000189D2C930-0x0000000189D2C978 
		internal TrackAsset[] flattenedTracks { get => default; } // 0x0000000189D2C740-0x0000000189D2C898 
		public MarkerTrack markerTrack { get => default; } // 0x0000000183D4EB00-0x0000000183D4EB10 
		internal List<ScriptableObject> trackObjects { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Nested types
		private enum Versions // TypeDefIndex: 56436
		{
			Initial = 0
		}
	
		private static class TimelineAssetUpgrade // TypeDefIndex: 56437
		{
		}
	
		[Obsolete("MediaType has been deprecated. It is no longer required, and will be removed in a future release.", false)]
		public enum MediaType // TypeDefIndex: 56438
		{
			Animation = 0,
			Audio = 1,
			Texture = 2,
			Video = 2,
			Script = 3,
			Hybrid = 4,
			Group = 5
		}
	
		public enum DurationMode // TypeDefIndex: 56439
		{
			BasedOnClips = 0,
			FixedLength = 1
		}
	
		[Serializable]
		public class EditorSettings // TypeDefIndex: 56440
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
			public double frameRate { get => default; set {} } // 0x0000000183D61CF0-0x0000000183D61D00 0x0000000189D29F64-0x0000000189D29F84
	
			// Constructors
			public EditorSettings() {} // 0x0000000183151BE0-0x0000000183151C50
			static EditorSettings() {} // 0x0000000183CEE6F0-0x0000000183CEE7A0
		}
	
		// Constructors
		public TimelineAsset() {} // 0x0000000183151690-0x0000000183151700
	
		// Methods
		private void UpgradeToLatestVersion() {} // 0x000000018350B670-0x000000018350B680
		private void OnValidate() {} // 0x0000000189D2BE0C-0x0000000189D2BE40
		public TrackAsset GetRootTrack(int index) => default; // 0x0000000189D2B930-0x0000000189D2B98C
		public IEnumerable<TrackAsset> GetRootTracks() => default; // 0x0000000189D2B98C-0x0000000189D2B9A8
		public TrackAsset GetOutputTrack(int index) => default; // 0x0000000189D2B8D0-0x0000000189D2B914
		public IEnumerable<TrackAsset> GetOutputTracks() => default; // 0x0000000189D2B914-0x0000000189D2B930
		public IEnumerable<GroupTrack> GetGroupTracks() => default; // 0x0000000189D2B8B4-0x0000000189D2B8D0
		private static double GetValidFrameRate(double frameRate) => default; // 0x0000000189D2B9A8-0x0000000189D2BA48
		private void UpdateRootTrackCache() {} // 0x0000000189D2C1A4-0x0000000189D2C42C
		private void UpdateOutputTrackCache() {} // 0x0000000189D2BF5C-0x0000000189D2C1A4
		public TrackAsset[] GetAllTracks() => default; // 0x0000000189D2B8AC-0x0000000189D2B8B4
		internal void AddTrackInternal(TrackAsset track) {} // 0x0000000189D2A4A4-0x0000000189D2A514
		internal void RemoveTrack(TrackAsset track) {} // 0x0000000189D2BE40-0x0000000189D2BF00
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go) => default; // 0x0000000189D2A978-0x0000000189D2AC80
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000183D85610-0x0000000183D85620
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x0000000183190890-0x00000001831908A0
		private void __internalAwake() {} // 0x000000018336A0D0-0x000000018336A1F0
		public void GatherProperties(PlayableDirector director, IPropertyCollector driver) {} // 0x0000000189D2B748-0x0000000189D2B8AC
		public void CreateMarkerTrack() {} // 0x0000000189D2A8A4-0x0000000189D2A978
		internal void Invalidate() {} // 0x0000000183190D90-0x0000000183190DD0
		internal void UpdateFixedDurationWithItemsDuration() {} // 0x0000000189D2BF00-0x0000000189D2BF5C
		private DiscreteTime CalculateItemsDuration() => default; // 0x0000000189D2A770-0x0000000189D2A8A4
		private static void AddSubTracksRecursive(TrackAsset track, ref List<TrackAsset> allTracks) {} // 0x0000000189D2A2CC-0x0000000189D2A4A4
		public TrackAsset CreateTrack(System.Type type, TrackAsset parent, string name) => default; // 0x0000000189D2AC80-0x0000000189D2AF9C
		public T CreateTrack<T>(TrackAsset parent, string trackName)
			where T : TrackAsset, new() => default;
		public T CreateTrack<T>(string trackName)
			where T : TrackAsset, new() => default;
		public T CreateTrack<T>()
			where T : TrackAsset, new() => default;
		public bool DeleteClip(TimelineClip clip) => default; // 0x0000000189D2AF9C-0x0000000189D2B138
		public bool DeleteTrack(TrackAsset track) => default; // 0x0000000189D2B3BC-0x0000000189D2B748
		internal void MoveLastTrackBefore(TrackAsset asset) {} // 0x0000000189D2BA48-0x0000000189D2BC04
		public void MoveTrackAfter(TrackAsset trackToMove, TrackAsset targetTrack) {} // 0x0000000189D2BC04-0x0000000189D2BE0C
		private TrackAsset AllocateTrack(TrackAsset trackAssetParent, string trackName, System.Type trackType) => default; // 0x0000000189D2A514-0x0000000189D2A770
		private void DeleteRecordedAnimation(TrackAsset track) {} // 0x0000000189D2B138-0x0000000189D2B23C
		private void DeleteRecordedAnimation(TimelineClip clip) {} // 0x0000000189D2B23C-0x0000000189D2B3BC
	}

	[Serializable]
	[IgnoreOnPlayableTrack]
	[SupportsChildTracks(null, 2147483647)]
	public abstract class TrackAsset : PlayableAsset, ISerializationCallbackReceiver, IPropertyPreview, ICurvesOwner, IDynamicBinding // TypeDefIndex: 56448
	{
		// Fields
		private const int k_LatestVersion = 3; // Metadata: 0x01FD808B
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
		private static TransientBuildData s_BuildData; // 0x00
		internal const string kDefaultCurvesName = "Track Parameters"; // Metadata: 0x01FD808C
		private bool m_RuntimeMuted; // 0x40
		[HideInInspector]
		[SerializeField]
		private bool m_Locked; // 0x41
		[HideInInspector]
		[SerializeField]
		private bool m_Muted; // 0x42
		[HideInInspector]
		[SerializeField]
		private string m_CustomPlayableFullTypename; // 0x48
		[HideInInspector]
		[SerializeField]
		private AnimationClip m_Curves; // 0x50
		[HideInInspector]
		[SerializeField]
		private PlayableAsset m_Parent; // 0x58
		[HideInInspector]
		[SerializeField]
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
		[HideInInspector]
		[SerializeField]
		protected internal List<TimelineClip> m_Clips; // 0x98
		[HideInInspector]
		[SerializeField]
		private MarkerList m_Markers; // 0xA0
		public int OptionIndex; // 0xB8
		[NonSerialized]
		public bool useRuntimeMuted; // 0xBC
	
		// Properties
		public double start { get; } // 0x0000000189D33AD8-0x0000000189D33B28 
		public double end { get; } // 0x0000000189D3366C-0x0000000189D336C0 
		public sealed override double duration { get; } // 0x0000000189D33608-0x0000000189D3366C 
		public virtual bool muted { get; set; } // 0x0000000189D33A54-0x0000000189D33A68 0x0000000183D4F7C0-0x0000000183D4F7D0
		public virtual bool runtimeMuted { get; set; } // 0x0000000183D4EE90-0x0000000183D4EEA0 0x0000000183D4EEB0-0x0000000183D4EEC0
		public bool mutedInHierarchy { get; } // 0x0000000189D33960-0x0000000189D33A54 
		public TimelineAsset timelineAsset { get; } // 0x0000000183190C70-0x0000000183190D90 
		public PlayableAsset parent { get; set; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000183081D30-0x0000000183081D40
		internal TimelineClip[] clips { get; } // 0x0000000189D3353C-0x0000000189D33608 
		public virtual bool isEmpty { get; } // 0x0000000189D33778-0x0000000189D337B4 
		public bool hasClips { get; } // 0x0000000189D336C0-0x0000000189D33708 
		public bool hasCurves { get; } // 0x0000000189D33708-0x0000000189D33778 
		public bool isSubTrack { get; } // 0x0000000189D337B4-0x0000000189D33874 
		public override IEnumerable<PlayableBinding> outputs { [IteratorStateMachine(typeof(_get_outputs_d__74))] get; } // 0x0000000189D33A68-0x0000000189D33AD8 
		internal string customPlayableTypename { get; set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public AnimationClip curves { get; internal set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		string ICurvesOwner.defaultCurvesName { get; } // 0x0000000189D32F20-0x0000000189D32F4C 
		UnityEngine.Object ICurvesOwner.asset { get; } // 0x000000018339AE90-0x000000018339AEA0 
		UnityEngine.Object ICurvesOwner.assetOwner { get; } // 0x0000000189D32F18-0x0000000189D32F20 
		TrackAsset ICurvesOwner.targetTrack { get; } // 0x000000018339AE90-0x000000018339AEA0 
		internal List<ScriptableObject> subTracksObjects { get; } // 0x0000000183D4EB00-0x0000000183D4EB10 
		public bool locked { get; set; } // 0x0000000183D4F7B0-0x0000000183D4F7C0 0x0000000183D4F7D0-0x0000000183D4F7E0
		public bool lockedInHierarchy { get; } // 0x0000000189D33874-0x0000000189D33960 
		public bool supportsNotifications { get; } // 0x0000000189D33B28-0x0000000189D33BB0 
	
		// Events
		internal static event Action<TimelineClip, GameObject, Playable> OnClipPlayableCreate;
		internal static event Action<TrackAsset, GameObject, Playable> OnTrackAnimationPlayableCreate;
	
		// Nested types
		internal enum Versions // TypeDefIndex: 56443
		{
			Initial = 0,
			RotationAsEuler = 1,
			RootMotionUpgrade = 2,
			AnimatedTrackProperties = 3
		}
	
		private static class TrackAssetUpgrade // TypeDefIndex: 56444
		{
		}
	
		private struct TransientBuildData // TypeDefIndex: 56445
		{
			// Fields
			public List<TrackAsset> trackList; // 0x00
			public List<TimelineClip> clipList; // 0x08
			public List<IMarker> markerList; // 0x10
	
			// Methods
			public static TransientBuildData Create() => default; // 0x00000001831513A0-0x00000001831514D0
			public void Clear() {} // 0x0000000189D33EC4-0x0000000189D33F4C
		}
	
		// Constructors
		protected TrackAsset() {} // 0x0000000183151700-0x0000000183151810
		static TrackAsset() {} // 0x0000000183151280-0x00000001831513A0
	
		// Methods
		protected virtual void OnBeforeTrackSerialize() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnAfterTrackDeserialize() {} // 0x000000018350B670-0x000000018350B680
		internal virtual void OnUpgradeFromVersion(int oldVersion) {} // 0x000000018350B670-0x000000018350B680
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000189D32E04-0x0000000189D32F18
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x00000001831908A0-0x0000000183190B20
		private void UpgradeToLatestVersion() {} // 0x000000018350B670-0x000000018350B680
		public IEnumerable<TimelineClip> GetClips() => default; // 0x0000000189D32120-0x0000000189D32128
		public IEnumerable<TrackAsset> GetChildTracks() => default; // 0x0000000189D31DBC-0x0000000189D31DDC
		private void __internalAwake() {} // 0x0000000183504410-0x0000000183504500
		public void CreateCurves(string curvesClipName) {} // 0x0000000189D2FE38-0x0000000189D2FED8
		public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) => default; // 0x0000000189D313F4-0x0000000189D31464
		public sealed override Playable CreatePlayable(PlayableGraph graph, GameObject go) => default; // 0x0000000189D31138-0x0000000189D31188
		public TimelineClip CreateDefaultClip() => default; // 0x0000000189D2FED8-0x0000000189D300F8
		public TimelineClip CreateClip<T>()
			where T : ScriptableObject, IPlayableAsset => default;
		public bool DeleteClip(TimelineClip clip) => default; // 0x0000000189D31464-0x0000000189D31574
		public IMarker CreateMarker(System.Type type, double time) => default; // 0x0000000189D30238-0x0000000189D3025C
		public T CreateMarker<T>(double time)
			where T : ScriptableObject, IMarker => default;
		public bool DeleteMarker(IMarker marker) => default; // 0x0000000189D315B4-0x0000000189D315C4
		public IEnumerable<IMarker> GetMarkers() => default; // 0x0000000183190B20-0x0000000183190BD0
		public IEnumerable<IMarker> GetClipMarkers() => default; // 0x0000000189D31DDC-0x0000000189D31FD8
		public int GetMarkerCount() => default; // 0x0000000189D32440-0x0000000189D32450
		public IMarker GetMarker(int idx) => default; // 0x0000000189D32450-0x0000000189D32460
		internal TimelineClip CreateClip(System.Type requestedType) => default; // 0x0000000189D2FD1C-0x0000000189D2FE38
		internal TimelineClip CreateAndAddNewClipOfType(System.Type requestedType) => default; // 0x0000000189D2F668-0x0000000189D2F69C
		internal TimelineClip CreateClipOfType(System.Type requestedType) => default; // 0x0000000189D2FB04-0x0000000189D2FD1C
		internal TimelineClip CreateClipFromPlayableAsset(IPlayableAsset asset) => default; // 0x0000000189D2F8C0-0x0000000189D2FB04
		private TimelineClip CreateClipFromAsset(ScriptableObject playableAsset) => default; // 0x0000000189D2F69C-0x0000000189D2F8C0
		internal IEnumerable<ScriptableObject> GetMarkersRaw() => default; // 0x0000000183D4EA80-0x0000000183D4EA90
		internal void ClearMarkers() {} // 0x0000000189D2F13C-0x0000000189D2F14C
		internal void AddMarker(ScriptableObject e) {} // 0x0000000189D2EE38-0x0000000189D2EE48
		internal bool DeleteMarkerRaw(ScriptableObject marker) => default; // 0x0000000189D31574-0x0000000189D315B4
		private int GetTimeRangeHash() => default; // 0x0000000189D325CC-0x0000000189D32714
		internal void AddClip(TimelineClip newClip) {} // 0x0000000189D2EDA4-0x0000000189D2EE38
		private Playable CreateNotificationsPlayable(PlayableGraph graph, Playable mixerPlayable, GameObject go, Playable timelinePlayable) => default; // 0x0000000189D30B34-0x0000000189D30E8C
		internal Playable CreatePlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, Playable timelinePlayable) => default; // 0x0000000189D30E8C-0x0000000189D31138
		internal virtual Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree) => default; // 0x0000000189D2F1CC-0x0000000189D2F530
		private void GatherCompilableTracks(IList<TrackAsset> tracks) {} // 0x0000000189D315C4-0x0000000189D31784
		private void GatherNotifications(List<IMarker> markers) {} // 0x0000000189D31784-0x0000000189D31980
		internal virtual Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree) => default; // 0x0000000189D3025C-0x0000000189D308F8
		internal void ConfigureTrackAnimation(IntervalTree<RuntimeElement> tree, GameObject go, Playable blend) {} // 0x0000000189D2F530-0x0000000189D2F668
		internal void SortClips() {} // 0x0000000189D32CC4-0x0000000189D32E04
		internal void ClearClipsInternal() {} // 0x0000000189D2F0B0-0x0000000189D2F13C
		internal void ClearSubTracksInternal() {} // 0x0000000189D2F14C-0x0000000189D2F1CC
		internal void OnClipMove() {} // 0x0000000183D71DF0-0x0000000183D71E00
		internal TimelineClip CreateNewClipContainerInternal() => default; // 0x0000000189D308F8-0x0000000189D30B34
		internal void AddChild(TrackAsset child) {} // 0x0000000189D2ED08-0x0000000189D2EDA4
		internal void MoveLastTrackBefore(TrackAsset asset) {} // 0x0000000189D32A24-0x0000000189D32BE0
		internal bool RemoveSubTrack(TrackAsset child) => default; // 0x0000000189D32C48-0x0000000189D32CC4
		internal void RemoveClip(TimelineClip clip) {} // 0x0000000189D32BE0-0x0000000189D32C48
		internal virtual void GetEvaluationTime(out double outStart, out double outDuration) {
			outStart = default;
			outDuration = default;
		} // 0x0000000189D32128-0x0000000189D32334
		internal virtual void GetSequenceTime(out double outStart, out double outDuration) {
			outStart = default;
			outDuration = default;
		} // 0x0000000189D325B4-0x0000000189D325CC
		public virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver) {} // 0x0000000189D31980-0x0000000189D31CFC
		internal GameObject GetGameObjectBinding(PlayableDirector director) => default; // 0x0000000189D32334-0x0000000189D32440
		internal bool ValidateClipType(System.Type clipType) => default; // 0x0000000189D331A4-0x0000000189D333AC
		protected virtual void OnCreateClip(TimelineClip clip) {} // 0x000000018350B670-0x000000018350B680
		private void UpdateDuration() {} // 0x0000000189D330D8-0x0000000189D331A4
		protected internal virtual int CalculateItemsHash() => default; // 0x0000000189D2EE48-0x0000000189D2EEE0
		protected virtual Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip) => default; // 0x0000000189D31188-0x0000000189D313F4
		internal void Invalidate() {} // 0x0000000183190BD0-0x0000000183190C70
		internal double GetNotificationDuration() => default; // 0x0000000189D32460-0x0000000189D325B4
		internal virtual bool CanCompileClips() => default; // 0x0000000189D2EEE0-0x0000000189D2EF1C
		public bool HasChildTracks() => default; // 0x0000000189D32714-0x0000000189D3275C
		public virtual bool CanCreateTrackMixer() => default; // 0x0000000189D2F0A0-0x0000000189D2F0B0
		internal bool IsCompilable() => default; // 0x0000000189D32824-0x0000000189D32A24
		private void UpdateChildTrackCache() {} // 0x0000000189D32F4C-0x0000000189D330D8
		internal virtual int Hash() => default; // 0x0000000189D327E0-0x0000000189D32824
		private int GetClipsHash() => default; // 0x0000000189D31FD8-0x0000000189D32120
		protected static int GetAnimationClipHash(AnimationClip clip) => default; // 0x0000000189D31CFC-0x0000000189D31DBC
		private bool HasNotifications() => default; // 0x0000000189D3275C-0x0000000189D327E0
		private bool CanCompileNotifications() => default; // 0x0000000189D2EF1C-0x0000000189D2EF48
		private bool CanCreateMixerRecursive() => default; // 0x0000000189D2EF48-0x0000000189D2F0A0
		public Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount) => default; // 0x0000000189D300F8-0x0000000189D30238
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ForbidScriptDefaultValueWhenExportAttribute : Attribute // TypeDefIndex: 56449
	{
		// Constructors
		public ForbidScriptDefaultValueWhenExportAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[Conditional("UNITY_EDITOR")]
	internal class TimelineHelpURLAttribute : Attribute // TypeDefIndex: 56450
	{
		// Constructors
		public TimelineHelpURLAttribute() {} // Dummy constructor
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class TrackColorAttribute : Attribute // TypeDefIndex: 56451
	{
		// Fields
		private UnityEngine.Color m_Color; // 0x10
	
		// Constructors
		public TrackColorAttribute() {} // Dummy constructor
		public TrackColorAttribute(float r, float g, float b) {} // 0x0000000183871E00-0x0000000183871E40
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class UseScriptDefaultValueWhenExportAttribute : Attribute // TypeDefIndex: 56452
	{
		// Constructors
		public UseScriptDefaultValueWhenExportAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	[UnityEngine.Timeline.NotKeyable]
	internal class AudioClipProperties : PlayableBehaviour // TypeDefIndex: 56453
	{
		// Fields
		[Range(0f, 1f)]
		public float volume; // 0x10
	
		// Constructors
		public AudioClipProperties() {} // 0x0000000183D4FB80-0x0000000183D4FB90
	}

	[Serializable]
	internal class AudioMixerProperties : PlayableBehaviour // TypeDefIndex: 56454
	{
		// Fields
		[Range(0f, 1f)]
		public float volume; // 0x10
		[Range(-1f, 1f)]
		public float stereoPan; // 0x14
		[Range(0f, 1f)]
		public float spatialBlend; // 0x18
	
		// Constructors
		public AudioMixerProperties() {} // 0x0000000183D4FB80-0x0000000183D4FB90
	
		// Methods
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x0000000189D26154-0x0000000189D263E4
	}

	[Serializable]
	public class AudioPlayableAsset : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 56456
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
		internal float bufferingTime { get => default; set {} } // 0x0000000183D524F0-0x0000000183D52500 0x0000000183D52500-0x0000000183D52510
		public AudioClip clip { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public bool loop { get => default; set {} } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x0000000183D4EFC0-0x0000000183D4EFD0
		public override double duration { get => default; } // 0x0000000189D26578-0x0000000189D26620 
		public override IEnumerable<PlayableBinding> outputs { [IteratorStateMachine(typeof(_get_outputs_d__16))] get => default; } // 0x0000000189D26620-0x0000000189D26690 
		public ClipCaps clipCaps { get => default; } // 0x0000000189D26568-0x0000000189D26578 
	
		// Constructors
		public AudioPlayableAsset() {} // 0x0000000189D26500-0x0000000189D26568
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go) => default; // 0x0000000189D263E4-0x0000000189D26500
	}

	[Serializable]
	[ExcludeFromPreset]
	[TrackBindingType(typeof(AudioSource))]
	[TrackClipType(typeof(AudioPlayableAsset), false)]
	public class AudioTrack : TrackAsset // TypeDefIndex: 56458
	{
		// Fields
		[SerializeField]
		private AudioMixerProperties m_TrackProperties; // 0xC0
	
		// Properties
		public override IEnumerable<PlayableBinding> outputs { [IteratorStateMachine(typeof(_get_outputs_d__4))] get => default; } // 0x0000000189D26DC4-0x0000000189D26E34 
	
		// Constructors
		public AudioTrack() {} // 0x0000000189D26D44-0x0000000189D26DC4
	
		// Methods
		public TimelineClip CreateClip(AudioClip clip) => default; // 0x0000000189D26BC4-0x0000000189D26CD8
		internal override Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree) => default; // 0x0000000189D26690-0x0000000189D26BC4
		private void OnValidate() {} // 0x0000000189D26CD8-0x0000000189D26D44
	}

	[Serializable]
	public struct ACConditionDescriptor // TypeDefIndex: 56459
	{
		// Fields
		private int m_ConditionMode; // 0x00
		private string m_ConditionEvent; // 0x08
		private float m_EventTreshold; // 0x10
	}

	public class ACTransitionDescriptor // TypeDefIndex: 56460
	{
		// Constructors
		public ACTransitionDescriptor() {} // 0x000000018350B670-0x000000018350B680
	}

	public static class BeyondCommunicator // TypeDefIndex: 56461
	{
		// Fields
		public static bool setAddonLayerAdditive; // 0x00
	
		// Properties
		public static Action<Animator, AnimationLayerMixerPlayable, AnimationTrack, ScriptableObject, Transform, CommunicatorParam> ConnectToJobSync { get; set; } // 0x0000000189D26E34-0x0000000189D26E84 0x0000000189D26E84-0x0000000189D26EE4
	
		// Constructors
		static BeyondCommunicator() {} // 0x0000000183D44B60-0x0000000183D44BA0
	}

	[Serializable]
	public class BlendMotionDescriptor // TypeDefIndex: 56462
	{
		// Fields
		public AnimationClip motion; // 0x10
		public string poseTimerParam; // 0x18
		public string blendParam; // 0x20
		public float threshold; // 0x28
	
		// Constructors
		public BlendMotionDescriptor() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class BlendTreeDescriptor // TypeDefIndex: 56464
	{
		// Fields
		public DescriptorBlendTreeType blendType; // 0x10
		public List<BlendMotionDescriptor> motionDescriptorList; // 0x18
	
		// Nested types
		public enum DescriptorBlendTreeType // TypeDefIndex: 56463
		{
			Direct = 0,
			Simple1D = 1,
			Simple2D = 2,
			Complex2D = 3
		}
	
		// Constructors
		public BlendTreeDescriptor() {} // 0x000000018350B670-0x000000018350B680
	}

	public interface ITimelineRootMarker // TypeDefIndex: 56465
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
	public class LayerDescriptor : ScriptableObject // TypeDefIndex: 56466
	{
		// Fields
		public string layerName; // 0x18
		public AvatarMask avatarMask; // 0x20
		public bool isAdditive; // 0x28
		public List<StateDescriptor> stateDescriptors; // 0x30
	
		// Constructors
		public LayerDescriptor() {} // 0x000000018286F540-0x000000018286F550
	}

	[Serializable]
	public class MotionDescriptor // TypeDefIndex: 56467
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
		public MotionDescriptor() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class StateDescriptor // TypeDefIndex: 56468
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
		public StateDescriptor() {} // 0x000000018350B670-0x000000018350B680
	}

	[Flags]
	public enum ClipCaps // TypeDefIndex: 56469
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

	internal static class TimelineClipCapsExtensions // TypeDefIndex: 56470
	{
		// Extension methods
		public static bool SupportsExtrapolation(this TimelineClip clip) => default; // 0x0000000189D2C9D0-0x0000000189D2C9F0
		public static bool HasAny(this ClipCaps caps, ClipCaps flags) => default; // 0x0000000185D658E8-0x0000000185D658F0
	}

	[Serializable]
	[UnityEngine.Timeline.NotKeyable]
	public class ControlPlayableAsset : BeyondUseAutoBindingPlayableAsset, IPropertyPreview, ITimelineClipAsset // TypeDefIndex: 56472
	{
		// Fields
		private const int k_MaxRandInt = 10000; // Metadata: 0x01FD80C5
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
		public bool updateITimeControl; // 0x52
		[SerializeField]
		public bool searchHierarchy; // 0x53
		[SerializeField]
		public bool active; // 0x54
		[SerializeField]
		public ActivationControlPlayable.PostPlaybackState postPlayback; // 0x58
		[SerializeField]
		private bool m_OnlyDeltaTime; // 0x5C
		[SerializeField]
		private bool m_IgniteOnce; // 0x5D
		private PlayableAsset m_ControlDirectorAsset; // 0x60
		private double m_Duration; // 0x68
		private bool m_SupportLoop; // 0x70
		private static HashSet<PlayableDirector> s_ProcessedDirectors; // 0x18
		private static HashSet<GameObject> s_CreatedPrefabs; // 0x20
	
		// Properties
		public override GameObject bindingGameObject { get => default; } // 0x0000000189D29E58-0x0000000189D29EE8 
		protected virtual bool showBaseParam { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		internal bool controllingDirectors { get; private set; } // 0x0000000183D51CF0-0x0000000183D51D00 0x0000000183D51D00-0x0000000183D51D10
		public bool controllingParticles { get; protected set; } // 0x0000000183D5BFA0-0x0000000183D5BFB0 0x0000000183D5BFD0-0x0000000183D5BFE0
		public bool OnlyDeltaTime { get => default; set {} } // 0x0000000183D4F600-0x0000000183D4F610 0x0000000183D4F620-0x0000000183D4F630
		public bool IgniteOnce { get => default; set {} } // 0x0000000183D71350-0x0000000183D71360 0x0000000183D71390-0x0000000183D713A0
		public override double duration { get => default; } // 0x0000000183D4F6E0-0x0000000183D4F6F0 
		public virtual ClipCaps clipCaps { get => default; } // 0x0000000189D29EE8-0x0000000189D29F18 
	
		// Constructors
		public ControlPlayableAsset() {} // 0x0000000189D29DEC-0x0000000189D29E58
		static ControlPlayableAsset() {} // 0x0000000189D29BB8-0x0000000189D29DEC
	
		// Methods
		public void OnEnable() {} // 0x0000000189D28454-0x0000000189D28480
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go) => default; // 0x0000000189D27360-0x0000000189D27EBC
		private static Playable ConnectPlayablesToMixer(PlayableGraph graph, List<Playable> playables) => default; // 0x0000000189D270F0-0x0000000189D2724C
		private void CreateActivationPlayable(GameObject root, PlayableGraph graph, List<Playable> outplayables) {} // 0x0000000189D2724C-0x0000000189D27360
		protected virtual void SearchHierarchyAndConnectParticleSystem(IEnumerable<ParticleSystem> particleSystems, float clipIn, float speedMultiplier, PlayableGraph graph, List<Playable> outplayables) {} // 0x0000000189D29454-0x0000000189D296BC
		private void SearchHierarchyAndConnectDirector(IEnumerable<PlayableDirector> directors, PlayableGraph graph, List<Playable> outplayables, bool disableSelfReferences) {} // 0x0000000189D291C0-0x0000000189D29454
		private static void SearchHierarchyAndConnectControlableScripts(IEnumerable<MonoBehaviour> controlableScripts, PlayableGraph graph, List<Playable> outplayables) {} // 0x0000000189D28FC0-0x0000000189D291C0
		private static void ConnectMixerAndPlayable(PlayableGraph graph, Playable mixer, Playable playable, int portIndex) {} // 0x0000000189D27030-0x0000000189D270F0
		protected virtual GameObject ResolveSourceGameObject(IExposedPropertyTable resolver) => default; // 0x0000000189D28E6C-0x0000000189D28FC0
		internal IList<T> GetComponent<T>(GameObject gameObject) => default;
		[IteratorStateMachine(typeof(_GetControlableScripts_d__53))]
		internal static IEnumerable<MonoBehaviour> GetControlableScripts(GameObject root) => default; // 0x0000000189D28148-0x0000000189D281B8
		internal void UpdateDurationAndLoopFlag(IList<PlayableDirector> directors, IList<ParticleSystem> particleSystems) {} // 0x0000000189D296BC-0x0000000189D29BB8
		private IList<ParticleSystem> GetControllableParticleSystems(GameObject go) => default; // 0x0000000189D281B8-0x0000000189D28304
		private static void GetControllableParticleSystems(Transform t, ICollection<ParticleSystem> roots, HashSet<ParticleSystem> subEmitters) {} // 0x0000000189D28304-0x0000000189D28454
		private static void CacheSubEmitters(ParticleSystem ps, HashSet<ParticleSystem> subEmitters) {} // 0x0000000189D26F58-0x0000000189D27030
		public void GatherProperties(PlayableDirector director, IPropertyCollector driver) {} // 0x0000000189D27EBC-0x0000000189D28148
		internal void PreviewParticlesWithControlPlayableAsset(IPropertyCollector driver, IEnumerable<ParticleSystem> particles) {} // 0x0000000189D287A4-0x0000000189D28800
		internal static void PreviewParticles(IPropertyCollector driver, IEnumerable<ParticleSystem> particles) {} // 0x0000000189D28800-0x0000000189D289A4
		internal static void PreviewActivation(IPropertyCollector driver, IEnumerable<GameObject> objects) {} // 0x0000000189D28480-0x0000000189D285CC
		internal static void PreviewTimeControl(IPropertyCollector driver, PlayableDirector director, IEnumerable<MonoBehaviour> scripts) {} // 0x0000000189D289A4-0x0000000189D28E6C
		internal static void PreviewDirectors(IPropertyCollector driver, IEnumerable<PlayableDirector> directors) {} // 0x0000000189D285CC-0x0000000189D287A4
	}

	[ExcludeFromPreset]
	[SupportsChildTracks(null, 2147483647)]
	[TrackClipType(typeof(ControlPlayableAsset), false)]
	public class ControlTrack : TrackAsset // TypeDefIndex: 56473
	{
		// Constructors
		public ControlTrack() {} // 0x0000000189D29F18-0x0000000189D29F64
	}

	[ExecuteAlways]
	public class AdditiveAnimApplyMono : MonoBehaviour // TypeDefIndex: 56475
	{
		// Fields
		private Dictionary<Transform, TransformAdditive> pendingAdditives; // 0x18
		private bool hasnewPendingUpdates; // 0x20
		private ITimelineRootMarker _parentTimelineRoot; // 0x28
	
		// Nested types
		public class TransformAdditive // TypeDefIndex: 56474
		{
			// Fields
			public Vector3 position; // 0x10
			public Vector3 rotationEuler; // 0x1C
			public Vector3 scale; // 0x28
	
			// Constructors
			public TransformAdditive() {} // 0x0000000189D33EBC-0x0000000189D33EC4
	
			// Methods
			public void Reset() {} // 0x0000000189D33E5C-0x0000000189D33EBC
			public bool HasChanges() => default; // 0x0000000189D33D40-0x0000000189D33E5C
		}
	
		// Constructors
		public AdditiveAnimApplyMono() {} // 0x0000000189D1F0A8-0x0000000189D1F128
	
		// Methods
		private void Awake() {} // 0x0000000189D1EC60-0x0000000189D1ECD8
		public void RecordAdditiveTransform(Transform bone, Vector3 position, Vector3 rotationEuler, Vector3 scale) {} // 0x0000000189D1EECC-0x0000000189D1F028
		private void LateUpdate() {} // 0x0000000189D1EE2C-0x0000000189D1EE58
		public void ApplyPendingTransforms() {} // 0x0000000189D1E804-0x0000000189D1EC60
		public void ClearPendingTransforms() {} // 0x0000000189D1ECD8-0x0000000189D1EE2C
		private void NotifyCutsceneRootToUpdateVFXTools() {} // 0x0000000189D1EE58-0x0000000189D1EECC
		public void RegisterRootComponent() {} // 0x0000000189D1F028-0x0000000189D1F0A8
	}

	public class AdditiveAnimMixer : PlayableBehaviour // TypeDefIndex: 56477
	{
		// Fields
		public AdditiveAnimTrack track; // 0x10
		private GameObject bindingGo; // 0x18
		private bool thisFrameAlreadyCalcualted; // 0x20
		private Dictionary<Transform, TransformAdditive> additiveCache; // 0x28
		private Dictionary<string, Transform> bonePaths; // 0x30
		private HashSet<string> notFoundBonePaths; // 0x38
	
		// Nested types
		private class TransformAdditive // TypeDefIndex: 56476
		{
			// Fields
			public Vector3 position; // 0x10
			public Vector3 rotationEular; // 0x1C
			public Vector3 scale; // 0x28
	
			// Constructors
			public TransformAdditive() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void Reset() {} // 0x0000000189D33E5C-0x0000000189D33EBC
		}
	
		// Constructors
		public AdditiveAnimMixer() {} // 0x0000000189D20098-0x0000000189D201A4
	
		// Methods
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x0000000183D5B630-0x0000000183D5B640
		public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x0000000189D1F128-0x0000000189D1F4D8
		private void _AddToAdditiveCache(AdditiveAnimPlayable additiveAnimPlayable, float clipTime, float weight) {} // 0x0000000189D1F4D8-0x0000000189D1FE00
		private void _ApplyAdditive() {} // 0x0000000189D1FE00-0x0000000189D20098
	}

	public class AdditiveAnimPlayable : PlayableBehaviour // TypeDefIndex: 56478
	{
		// Fields
		public List<AdditiveAnimPlayableAsset.AnimationCurveInfo> extractedCurves; // 0x10
		private Dictionary<string, List<AdditiveAnimPlayableAsset.AnimationCurveInfo>> _curveCache; // 0x18
	
		// Constructors
		public AdditiveAnimPlayable() {} // 0x0000000189D366C4-0x0000000189D3673C
	
		// Methods
		public override void OnPlayableCreate(Playable playable) {} // 0x0000000189D3664C-0x0000000189D366C4
		public void InitializeCurveCache() {} // 0x0000000189D363BC-0x0000000189D3664C
		public AnimationCurve GetCurve(string path, string propertyName) => default; // 0x0000000189D36214-0x0000000189D363BC
		public float EvaluateCurve(string path, string propertyName, float time) => default; // 0x0000000189D361DC-0x0000000189D36214
	}

	[Serializable]
	public class AdditiveAnimPlayableAsset : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 56480
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
		public bool OnlyDeltaTime { get => default; set {} } // 0x0000000183D4F190-0x0000000183D4F1A0 0x0000000183D4E280-0x0000000183D4E290
		public bool IgniteOnce { get => default; set {} } // 0x0000000183D4F300-0x0000000183D4F310 0x0000000183D4F330-0x0000000183D4F340
		public ClipCaps clipCaps { get => default; } // 0x0000000189D361B8-0x0000000189D361DC 
	
		// Nested types
		[Serializable]
		public class AnimationCurveInfo // TypeDefIndex: 56479
		{
			// Fields
			public string path; // 0x10
			public string propertyName; // 0x18
			public AnimationCurve curve; // 0x20
	
			// Constructors
			public AnimationCurveInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public AdditiveAnimPlayableAsset() {} // 0x0000000189D36138-0x0000000189D361B8
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x0000000189D35F68-0x0000000189D36094
		private void _InitializeBehaviourCurveCache() {} // 0x0000000189D36094-0x0000000189D36138
	}

	[System.ComponentModel.DisplayName("Beyond/AdditiveAnimationTrack")]
	[TrackBindingType(typeof(GameObject))]
	[TrackClipType(typeof(AdditiveAnimPlayableAsset))]
	public class AdditiveAnimTrack : TrackAsset // TypeDefIndex: 56481
	{
		// Fields
		private const string k_DefaultRecordableClipName = "Recorded Additive"; // Metadata: 0x01FD80C9
		[HideInInspector]
		[SerializeField]
		private bool m_InfiniteClip; // 0xC0
		[HideInInspector]
		[SerializeField]
		private AnimationClip m_RecordableClip; // 0xC8
	
		// Constructors
		public AdditiveAnimTrack() {} // 0x0000000189D36A38-0x0000000189D36A84
	
		// Methods
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) => default; // 0x0000000189D36764-0x0000000189D36860
		public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) {} // 0x0000000189D36860-0x0000000189D36A38
		public TimelineClip CreateRecordableClip(string animClipName) => default; // 0x0000000189D3673C-0x0000000189D36764
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class CombineToTopPlayableAttribute : Attribute // TypeDefIndex: 56482
	{
		// Constructors
		public CombineToTopPlayableAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public class CustomControlPlayableAsset : PlayableAsset, ITimelineClipAsset, ICustomControlBehaviour // TypeDefIndex: 56483
	{
		// Fields
		protected CustomControlPlayableBehaviour m_CustomControlBehaviour; // 0x18
	
		// Properties
		public ClipCaps clipCaps { get => default; } // 0x0000000189D370C4-0x0000000189D370E0 
		protected virtual ClipCaps extraClipCaps { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public CustomControlPlayableAsset() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x0000000189D36FBC-0x0000000189D3700C
		public virtual void OnClipEnable(Playable playable, FrameData info) {} // 0x0000000189D37068-0x0000000189D370C4
		public virtual void OnClipDisable(Playable playable, FrameData info) {} // 0x0000000189D3700C-0x0000000189D37068
	}

	public class CustomControlPlayableBehaviour : PlayableBehaviour, ICustomControlBehaviour // TypeDefIndex: 56484
	{
		// Constructors
		public CustomControlPlayableBehaviour() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual void OnClipEnable(Playable playable, FrameData info) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnClipDisable(Playable playable, FrameData info) {} // 0x000000018350B670-0x000000018350B680
	}

	public interface ICustomControlBehaviour // TypeDefIndex: 56485
	{
		// Methods
		void OnClipEnable(Playable playable, FrameData info);
		void OnClipDisable(Playable playable, FrameData info);
	}

	public interface IDynamicBinding // TypeDefIndex: 56486
	{
	}

	public interface ITimelineAnimationEventContextBinding // TypeDefIndex: 56487
	{
		// Methods
		void RegisterAnimationEventRuntimeContext(int playableId, AnimationEvent[] animationEvents, AnimationPlayableAsset.AnimationEventTriggerMode triggerMode, float curClipTime);
		void UnregisterAnimationEventRuntimeContext(int playableId, AnimationEvent[] animationEvents);
		void UpdateClipTime(int playableId, float curClipTime);
	}

	public class SegmentLoopPlayableBehaviour : PlayableBehaviour // TypeDefIndex: 56488
	{
		// Constructors
		public SegmentLoopPlayableBehaviour() {} // 0x000000018350B670-0x000000018350B680
	}

	public class SegmentLoopPlayableClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 56489
	{
		// Fields
		public string loopSegmentKey; // 0x18
	
		// Properties
		public ClipCaps clipCaps { get => default; } // 0x0000000183D567A0-0x0000000183D567B0 
	
		// Constructors
		public SegmentLoopPlayableClip() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x0000000189D3CAA8-0x0000000189D3CB54
	}

	[CombineToTopPlayable]
	[System.ComponentModel.DisplayName("Beyond/SegmentLoopTrack")]
	[TrackClipType(typeof(SegmentLoopPlayableClip))]
	public class SegmentLoopTrack : TrackAsset // TypeDefIndex: 56490
	{
		// Constructors
		public SegmentLoopTrack() {} // 0x0000000189D3CB54-0x0000000189D3CBA0
	}

	internal struct DiscreteTime : IComparable // TypeDefIndex: 56491
	{
		// Fields
		private const double k_Tick = 1E-12; // Metadata: 0x01FD80DB
		public static readonly DiscreteTime kMaxTime; // 0x00
		private readonly long m_DiscreteTime; // 0x00
	
		// Properties
		public static double tickValue { get => default; } // 0x0000000183D856B0-0x0000000183D856C0 
	
		// Constructors
		private DiscreteTime(long time) : this() {
			m_DiscreteTime = default;
		} // 0x0000000183D51730-0x0000000183D51740
		public DiscreteTime(double time) : this() {
			m_DiscreteTime = default;
		} // 0x0000000189D37F00-0x0000000189D37F5C
		public DiscreteTime(int time) : this() {
			m_DiscreteTime = default;
		} // 0x0000000189D37EA8-0x0000000189D37F00
		static DiscreteTime() {
			kMaxTime = default;
		} // 0x0000000189D37E68-0x0000000189D37EA8
	
		// Methods
		public DiscreteTime OneTickBefore() => default; // 0x0000000183D85680-0x0000000183D85690
		public DiscreteTime OneTickAfter() => default; // 0x0000000183D85670-0x0000000183D85680
		public static DiscreteTime FromTicks(long ticks) => default; // 0x000000018339AE90-0x000000018339AEA0
		public int CompareTo(object obj) => default; // 0x0000000189D37BE0-0x0000000189D37C48
		public bool Equals(DiscreteTime other) => default; // 0x00000001822A9C20-0x00000001822A9C30
		public override bool Equals(object obj) => default; // 0x0000000189D37CFC-0x0000000189D37D68
		private static long DoubleToDiscreteTime(double time) => default; // 0x0000000189D37C48-0x0000000189D37CFC
		private static long IntToDiscreteTime(int time) => default; // 0x0000000189D37DB8-0x0000000189D37E08
		private static double ToDouble(long time) => default; // 0x0000000183D85690-0x0000000183D856B0
		public static explicit operator double(DiscreteTime b) => default; // 0x0000000189D37F5C-0x0000000189D37FAC
		public static explicit operator DiscreteTime(double time) => default; // 0x0000000189D37FAC-0x0000000189D37FD4
		public static implicit operator DiscreteTime(int time) => default; // 0x0000000189D37FD4-0x0000000189D37FFC
		public static bool operator ==(DiscreteTime lhs, DiscreteTime rhs) => default; // 0x000000018232CE30-0x000000018232CE40
		public static bool operator !=(DiscreteTime lhs, DiscreteTime rhs) => default; // 0x0000000189D37FFC-0x0000000189D38048
		public static bool operator <=(DiscreteTime lhs, DiscreteTime rhs) => default; // 0x000000018925CFFC-0x000000018925D004
		public static bool operator >=(DiscreteTime lhs, DiscreteTime rhs) => default; // 0x00000001822E54E0-0x00000001822E54F0
		public static DiscreteTime operator -(DiscreteTime lhs, DiscreteTime rhs) => default; // 0x0000000183D856C0-0x0000000183D856D0
		public override string ToString() => default; // 0x0000000189D37E60-0x0000000189D37E68
		public override int GetHashCode() => default; // 0x0000000183D70930-0x0000000183D70940
		public static DiscreteTime Max(DiscreteTime lhs, DiscreteTime rhs) => default; // 0x0000000189D37E08-0x0000000189D37E60
		public static long GetNearestTick(double time) => default; // 0x0000000189D37D68-0x0000000189D37DB8
	}

	internal class InfiniteRuntimeClip : RuntimeElement // TypeDefIndex: 56492
	{
		// Fields
		private Playable m_Playable; // 0x18
		private static readonly long kIntervalEnd; // 0x00
	
		// Properties
		public override long intervalStart { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override long intervalEnd { get => default; } // 0x0000000189D38B74-0x0000000189D38BC4 
		public override int optionIndex { get; set; } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
		public override bool enable { set {} } // 0x0000000189D38BC4-0x0000000189D38C28
	
		// Constructors
		public InfiniteRuntimeClip() {} // Dummy constructor
		public InfiniteRuntimeClip(Playable playable) {} // 0x0000000183D51D90-0x0000000183D51DA0
		static InfiniteRuntimeClip() {} // 0x0000000189D38AE4-0x0000000189D38B74
	
		// Methods
		public override void EvaluateAt(double localTime, FrameData frameData, ITimelineRootMarker timelineRoot = null) {} // 0x0000000189D38A8C-0x0000000189D38AE4
		public override void DisableAt(double localTime, double rootDuration, FrameData frameData) {} // 0x0000000189D38A2C-0x0000000189D38A8C
	}

	internal interface IInterval // TypeDefIndex: 56493
	{
		// Properties
		long intervalStart { get; }
		long intervalEnd { get; }
	}

	internal interface IRuntimeReset // TypeDefIndex: 56494
	{
		// Methods
		void RuntimeReset();
	}

	internal interface IOption // TypeDefIndex: 56495
	{
	}

	internal struct IntervalTreeNode // TypeDefIndex: 56496
	{
		// Fields
		public long center; // 0x00
		public int first; // 0x08
		public int last; // 0x0C
		public int left; // 0x10
		public int right; // 0x14
	}

	internal class IntervalTree<T> // TypeDefIndex: 56498
		where T : IInterval, IRuntimeReset
	{
		// Fields
		private const int kMinNodeSize = 10; // Metadata: 0x01FD80E3
		private const int kInvalidNode = -1; // Metadata: 0x01FD80E4
		private const long kCenterUnknown = 9223372036854775807; // Metadata: 0x01FD80E5
		private readonly List<Entry> m_Entries;
		private readonly List<IntervalTreeNode> m_Nodes;
	
		// Properties
		public bool dirty { get; internal set; }
	
		// Nested types
		internal struct Entry // TypeDefIndex: 56497
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

	public class RuntimeClip : RuntimeClipBase // TypeDefIndex: 56499
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
		private int m_originalPort; // 0x60
		private bool _hadClipEnabled; // 0x64
		public bool isRuntimeJumpExhaust; // 0x65
		private TimelineClip m_Clip; // 0x68
		private Playable m_Playable; // 0x70
		private Playable m_ParentMixer; // 0x80
		private Playable m_RootPlayable; // 0x90
		private bool m_enabled; // 0xA0
	
		// Properties
		public override int optionIndex { get; set; } // 0x0000000183D4EEF0-0x0000000183D4EF00 0x0000000183D4EF40-0x0000000183D4EF50
		public bool dynamicLink { get => default; } // 0x0000000189D3C164-0x0000000189D3C18C 
		public bool customBehaviourControl { get => default; } // 0x0000000189D3C110-0x0000000189D3C138 
		public override double start { get => default; } // 0x0000000189D3C2B8-0x0000000189D3C2E4 
		public override double end { get => default; } // 0x0000000189D3C18C-0x0000000189D3C1E4 
		public override double duration { get => default; } // 0x0000000189D3C138-0x0000000189D3C164 
		public TimelineClip clip { get => default; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 
		public Playable mixer { get => default; } // 0x0000000183D5AAF0-0x0000000183D5AB00 
		public Playable playable { get => default; } // 0x0000000183D5AAE0-0x0000000183D5AAF0 
		public override long intervalStart { get => default; } // 0x0000000189D3C25C-0x0000000189D3C2B8 
		public override long intervalEnd { get => default; } // 0x0000000189D3C1E4-0x0000000189D3C25C 
		public override bool enable { set {} } // 0x0000000189D3C2E4-0x0000000189D3C520
		public bool isEnabling { get => default; } // 0x0000000183D50A40-0x0000000183D50A50 
	
		// Constructors
		public RuntimeClip() {} // Dummy constructor
		public RuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer, int originalPort) {} // 0x0000000189D3C0B8-0x0000000189D3C110
	
		// Methods
		private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer, int originalPort) {} // 0x0000000189D3B1C8-0x0000000189D3B2DC
		public void SetTime(double time) {} // 0x0000000189D3BE10-0x0000000189D3BE68
		public void SetDuration(double duration) {} // 0x0000000189D3BDB8-0x0000000189D3BE10
		public override void EvaluateAt(double localTime, FrameData frameData, ITimelineRootMarker timelineRoot = null) {} // 0x0000000189D3B47C-0x0000000189D3B7CC
		public float EvaluateMixIn(float localTime) => default; // 0x0000000189D3B7CC-0x0000000189D3B888
		public float EvaluateMixOut(float localTime) => default; // 0x0000000189D3B888-0x0000000189D3B918
		public double ToLocalTime(double localTime, FrameData frameData, ITimelineRootMarker timelineRoot) => default; // 0x0000000189D3BE68-0x0000000189D3BFF0
		public override void DisableAt(double localTime, double rootDuration, FrameData frameData) {} // 0x0000000189D3B2DC-0x0000000189D3B47C
		public override bool CheckIfRuntimeTimeLoop(out bool canSkip, out double reverseTime) {
			canSkip = default;
			reverseTime = default;
			return default;
		} // 0x0000000189D3B17C-0x0000000189D3B1C8
		public override bool CheckIfRuntimeTimeJump(out double jumpTime, out bool isReverseJump) {
			jumpTime = default;
			isReverseJump = default;
			return default;
		} // 0x0000000189D3B050-0x0000000189D3B17C
		public override void RuntimeLoopOver() {} // 0x0000000189D3BB28-0x0000000189D3BB58
		public override void RuntimeLoopOn() {} // 0x0000000189D3BAF8-0x0000000189D3BB28
		public override void GetRuntimeCrossFadeDuration(out double duration, out double jumpTargetTime) {
			duration = default;
			jumpTargetTime = default;
		} // 0x0000000189D3B918-0x0000000189D3BA3C
		public override void RecalculateRuntimeCrossFadeMixIn(double mixInTime, double mixInDuration) {} // 0x0000000189D3BA3C-0x0000000189D3BA8C
		public override void RecalculateRuntimeCrossFadeMixOut(double curTime, double mixStartTime, double mixDuration) {} // 0x0000000189D3BA8C-0x0000000189D3BAF8
		public bool TryGetJumpClip(out RuntimeJumpClip jumpClip) {
			jumpClip = default;
			return default;
		} // 0x0000000189D3BFF0-0x0000000189D3C0B8
		public override void RuntimeReset() {} // 0x0000000189D3BB58-0x0000000189D3BDB8
	}

	public abstract class RuntimeClipBase : RuntimeElement // TypeDefIndex: 56500
	{
		// Properties
		public abstract double start { get; }
		public abstract double duration { get; }
		public abstract double end { get; }
		public override int optionIndex { get; set; } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public override long intervalStart { get; } // 0x0000000189D3AFF4-0x0000000189D3B050 
		public override long intervalEnd { get; } // 0x0000000189D3AF7C-0x0000000189D3AFF4 
	
		// Constructors
		protected RuntimeClipBase() {} // 0x000000018350B670-0x000000018350B680
	}

	public abstract class RuntimeElement : IInterval, IOption, IRuntimeReset // TypeDefIndex: 56501
	{
		// Properties
		public abstract long intervalStart { get; }
		public abstract long intervalEnd { get; }
		public abstract int optionIndex { get; set; }
		public int intervalBit { get; set; } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
		public bool isLooping { get; set; } // 0x0000000183D58C00-0x0000000183D58C10 0x0000000183D58C20-0x0000000183D58C30
		public abstract bool enable { get; set; }
	
		// Constructors
		protected RuntimeElement() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract void EvaluateAt(double localTime, FrameData frameData, ITimelineRootMarker timelineRoot = null);
		public abstract void DisableAt(double localTime, double rootDuration, FrameData frameData);
		public virtual bool CheckIfRuntimeTimeLoop(out bool canSkip, out double reverseTime) {
			canSkip = default;
			reverseTime = default;
			return default;
		} // 0x0000000183D857E0-0x0000000183D857F0
		public virtual bool CheckIfRuntimeTimeJump(out double jumpTime, out bool isReverseJump) {
			jumpTime = default;
			isReverseJump = default;
			return default;
		} // 0x0000000183D857D0-0x0000000183D857E0
		public virtual void RuntimeLoopOver() {} // 0x000000018350B670-0x000000018350B680
		public virtual void RuntimeLoopOn() {} // 0x000000018350B670-0x000000018350B680
		public virtual void GetRuntimeCrossFadeDuration(out double duration, out double jumpTargetTime) {
			duration = default;
			jumpTargetTime = default;
		} // 0x0000000183D857F0-0x0000000183D85800
		public virtual void RecalculateRuntimeCrossFadeMixIn(double mixInTime, double mixDuration) {} // 0x000000018350B670-0x000000018350B680
		public virtual void RecalculateRuntimeCrossFadeMixOut(double curTime, double mixStartTime, double mixDuration) {} // 0x000000018350B670-0x000000018350B680
		public virtual void RuntimeReset() {} // 0x000000018350B670-0x000000018350B680
	}

	internal class ScheduleRuntimeClip : RuntimeClipBase // TypeDefIndex: 56502
	{
		// Fields
		private TimelineClip m_Clip; // 0x20
		private Playable m_Playable; // 0x28
		private Playable m_ParentMixer; // 0x38
		private double m_StartDelay; // 0x48
		private double m_FinishTail; // 0x50
		private bool m_Started; // 0x58
	
		// Properties
		public override double start { get => default; } // 0x0000000189D3C938-0x0000000189D3C9B0 
		public override double duration { get => default; } // 0x0000000189D3C8B4-0x0000000189D3C8FC 
		public override double end { get => default; } // 0x0000000189D3C8FC-0x0000000189D3C938 
		public TimelineClip clip { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public Playable mixer { get => default; } // 0x0000000183D5A120-0x0000000183D5A130 
		public Playable playable { get => default; } // 0x0000000183D59E20-0x0000000183D59E30 
		public override bool enable { set {} } // 0x0000000189D3C9B0-0x0000000189D3CAA8
	
		// Constructors
		public ScheduleRuntimeClip() {} // Dummy constructor
		public ScheduleRuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay = 0.2 /* Metadata: 0x01FD80ED */, double finishTail = 0.1 /* Metadata: 0x01FD80F5 */) {} // 0x0000000189D3C864-0x0000000189D3C8B4
	
		// Methods
		private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay, double finishTail) {} // 0x0000000189D3C520-0x0000000189D3C5B8
		public override void EvaluateAt(double localTime, FrameData frameData, ITimelineRootMarker timelineRoot = null) {} // 0x0000000189D3C5B8-0x0000000189D3C864
		public override void DisableAt(double localTime, double rootDuration, FrameData frameData) {} // 0x0000000185755818-0x0000000185755828
	}

	public interface IMarker // TypeDefIndex: 56503
	{
		// Properties
		double time { get; set; }
		TrackAsset parent { get; }
	
		// Methods
		void Initialize(TrackAsset parent);
	}

	public interface INotificationOptionProvider // TypeDefIndex: 56504
	{
		// Properties
		NotificationFlags flags { get; }
	}

	public abstract class Marker : ScriptableObject, IMarker // TypeDefIndex: 56505
	{
		// Fields
		[SerializeField]
		[TimeField(TimeFieldAttribute.UseEditMode.ApplyEditMode)]
		[Tooltip("Time for the marker")]
		private double m_Time; // 0x18
	
		// Properties
		public TrackAsset parent { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public double time { get; set; } // 0x0000000183D4EBD0-0x0000000183D4EBE0 0x0000000189D39494-0x0000000189D394EC
	
		// Constructors
		protected Marker() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		void IMarker.Initialize(TrackAsset parentTrack) {} // 0x0000000189D39374-0x0000000189D39494
		public virtual void OnInitialize(TrackAsset aPent) {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	internal struct MarkerList : ISerializationCallbackReceiver // TypeDefIndex: 56506
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
		public List<IMarker> markers { get => default; } // 0x0000000184275B08-0x0000000184275B24 
		public int Count { get => default; } // 0x0000000189D39128-0x0000000189D39170 
		public IMarker this[int idx] { get => default; } // 0x0000000189D39170-0x0000000189D391CC 
	
		// Constructors
		public MarkerList(int capacity) : this() {
			m_Objects = default;
			m_Cache = default;
			m_CacheDirty = default;
			m_HasNotifications = default;
		} // 0x0000000183151860-0x0000000183151940
	
		// Methods
		public void Add(ScriptableObject item) {} // 0x0000000189D38C28-0x0000000189D38CAC
		public bool Remove(IMarker item) => default; // 0x0000000189D38F74-0x0000000189D39078
		public bool Remove(ScriptableObject item, TimelineAsset timelineAsset, PlayableAsset thingToDirty) => default; // 0x0000000189D39078-0x0000000189D39128
		public void Clear() {} // 0x0000000189D38CAC-0x0000000189D38CF8
		public IEnumerable<IMarker> GetMarkers() => default; // 0x0000000184275B08-0x0000000184275B24
		public List<ScriptableObject> GetRawMarkerList() => default; // 0x00000001820C61B0-0x00000001820C61C0
		public IMarker CreateMarker(System.Type type, double time, TrackAsset owner) => default; // 0x0000000189D38CF8-0x0000000189D38F58
		public bool HasNotifications() => default; // 0x0000000189D38F58-0x0000000189D38F74
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018350B670-0x000000018350B680
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x0000000181168960-0x0000000181168970
		private void BuildCache() {} // 0x0000000183151940-0x0000000183151BE0
	}

	[Serializable]
	[ExcludeFromPreset]
	[HideInMenu]
	[TrackBindingType(typeof(GameObject))]
	public class MarkerTrack : TrackAsset, INotificationTrack // TypeDefIndex: 56507
	{
		// Properties
		public override IEnumerable<PlayableBinding> outputs { get => default; } // 0x0000000189D39218-0x0000000189D39374 
	
		// Constructors
		public MarkerTrack() {} // 0x0000000189D391CC-0x0000000189D39218
	}

	internal class CustomSignalEventDrawer : PropertyAttribute // TypeDefIndex: 56508
	{
		// Constructors
		public CustomSignalEventDrawer() {} // 0x000000018350B670-0x000000018350B680
	}

	[AssetFileNameExtension("signal", new string[0])]
	public class SignalAsset : ScriptableObject // TypeDefIndex: 56509
	{
		// Events
		internal static event Action<SignalAsset> OnEnableCallback;
	
		// Constructors
		public SignalAsset() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		private void OnEnable() {} // 0x0000000189D3CBA0-0x0000000189D3CBF0
	}

	[Serializable]
	[CustomStyle("SignalEmitter")]
	[ExcludeFromPreset]
	public class SignalEmitter : Marker, INotification, INotificationOptionProvider // TypeDefIndex: 56510
	{
		// Fields
		[SerializeField]
		private bool m_Retroactive; // 0x28
		[SerializeField]
		private bool m_EmitOnce; // 0x29
		[SerializeField]
		private SignalAsset m_Asset; // 0x30
	
		// Properties
		public bool retroactive { get => default; set {} } // 0x0000000183D4ED50-0x0000000183D4ED60 0x0000000183D4ED60-0x0000000183D4ED70
		public bool emitOnce { get => default; set {} } // 0x0000000183D4F2A0-0x0000000183D4F2B0 0x0000000183D4F2B0-0x0000000183D4F2C0
		public SignalAsset asset { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		PropertyName INotification.id { get => default; } // 0x0000000189D3CD28-0x0000000189D3CDCC 
		NotificationFlags INotificationOptionProvider.flags { get => default; } // 0x0000000189D3CDCC-0x0000000189D3CDF4 
	
		// Constructors
		public SignalEmitter() {} // 0x000000018286F540-0x000000018286F550
	}

	public class SignalReceiver : MonoBehaviour, INotificationReceiver // TypeDefIndex: 56512
	{
		// Fields
		[SerializeField]
		private EventKeyValue m_Events; // 0x18
	
		// Nested types
		[Serializable]
		private class EventKeyValue // TypeDefIndex: 56511
		{
			// Fields
			[SerializeField]
			private List<SignalAsset> m_Signals; // 0x10
			[CustomSignalEventDrawer]
			[SerializeField]
			private List<UnityEvent> m_Events; // 0x18
	
			// Properties
			public List<SignalAsset> signals { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
			public List<UnityEvent> events { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
			// Constructors
			public EventKeyValue() {} // 0x0000000189D38298-0x0000000189D38358
	
			// Methods
			public bool TryGetValue(SignalAsset key, out UnityEvent value) {
				value = default;
				return default;
			} // 0x0000000189D381F0-0x0000000189D38298
			public void Append(SignalAsset key, UnityEvent value) {} // 0x0000000189D38048-0x0000000189D380D0
			public void Remove(int idx) {} // 0x0000000189D38174-0x0000000189D381F0
			public void Remove(SignalAsset key) {} // 0x0000000189D380D0-0x0000000189D38174
		}
	
		// Constructors
		public SignalReceiver() {} // 0x0000000189D3D738-0x0000000189D3D7A8
	
		// Methods
		public void OnNotify(Playable origin, INotification notification, object context) {} // 0x0000000189D3D4E8-0x0000000189D3D5C8
		public void AddReaction(SignalAsset asset, UnityEvent reaction) {} // 0x0000000189D3CE60-0x0000000189D3CFBC
		public int AddEmptyReaction(UnityEvent reaction) => default; // 0x0000000189D3CDF4-0x0000000189D3CE60
		public void Remove(SignalAsset asset) {} // 0x0000000189D3D670-0x0000000189D3D738
		public IEnumerable<SignalAsset> GetRegisteredSignals() => default; // 0x00000001892E734C-0x00000001892E7368
		public UnityEvent GetReaction(SignalAsset key) => default; // 0x0000000189D3D3F4-0x0000000189D3D42C
		public int Count() => default; // 0x0000000189D3D2F0-0x0000000189D3D338
		public void ChangeSignalAtIndex(int idx, SignalAsset newKey) {} // 0x0000000189D3D088-0x0000000189D3D2F0
		public void RemoveAtIndex(int idx) {} // 0x0000000189D3D5C8-0x0000000189D3D670
		public void ChangeReactionAtIndex(int idx, UnityEvent reaction) {} // 0x0000000189D3CFBC-0x0000000189D3D088
		public UnityEvent GetReactionAtIndex(int idx) => default; // 0x0000000189D3D338-0x0000000189D3D3F4
		public SignalAsset GetSignalAssetAtIndex(int idx) => default; // 0x0000000189D3D42C-0x0000000189D3D4E8
		private void OnEnable() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	[ExcludeFromPreset]
	[TrackBindingType(typeof(SignalReceiver))]
	[TrackColor(0.25f, 0.25f, 0.25f)]
	public class SignalTrack : MarkerTrack // TypeDefIndex: 56513
	{
		// Constructors
		public SignalTrack() {} // 0x0000000189D3D7A8-0x0000000189D3D7B0
	}

	public static class TrackAssetExtensions // TypeDefIndex: 56514
	{
	}

	[Serializable]
	[ExcludeFromPreset]
	[SupportsChildTracks(null, 2147483647)]
	[TrackClipType(typeof(TrackAsset))]
	public class GroupTrack : TrackAsset // TypeDefIndex: 56515
	{
		// Fields
		public TimelineConditionBase enableOnCondition; // 0xC0
	
		// Properties
		public override IEnumerable<PlayableBinding> outputs { get => default; } // 0x0000000189D38950-0x0000000189D389A0 
	
		// Constructors
		public GroupTrack() {} // 0x0000000183151580-0x00000001831515D0
	
		// Methods
		public void CalculateRuntimeMuted() {} // 0x0000000189D388C8-0x0000000189D38950
		internal override bool CanCompileClips() => default; // 0x000000018115F4C0-0x000000018115F530
	}

	public interface ILayerable // TypeDefIndex: 56516
	{
		// Methods
		Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount);
	}

	public interface ITimeDilationListener // TypeDefIndex: 56517
	{
		// Methods
		void OnTimeDilationChanged(float timeDilation);
	}

	public class ActivationControlPlayable : ControlPlayableBehaviour // TypeDefIndex: 56520
	{
		// Fields
		public GameObject gameObject; // 0x10
		public PostPlaybackState postPlayback; // 0x18
		private InitialState m_InitialState; // 0x1C
	
		// Nested types
		public enum PostPlaybackState // TypeDefIndex: 56518
		{
			Active = 0,
			Inactive = 1,
			Revert = 2
		}
	
		private enum InitialState // TypeDefIndex: 56519
		{
			Unset = 0,
			Active = 1,
			Inactive = 2
		}
	
		// Constructors
		public ActivationControlPlayable() {} // 0x0000000183D56C80-0x0000000183D56C90
	
		// Methods
		public static ScriptPlayable<ActivationControlPlayable> Create(PlayableGraph graph, GameObject gameObject, PostPlaybackState postPlaybackState) => default; // 0x0000000189D35BA8-0x0000000189D35CDC
		public override void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x0000000189D35D68-0x0000000189D35DD8
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x0000000189D35CDC-0x0000000189D35D68
		public override void ProcessFrame(Playable playable, FrameData info, object userData) {} // 0x0000000189D35EF8-0x0000000189D35F68
		public override void OnGraphStart(Playable playable) {} // 0x0000000189D35DD8-0x0000000189D35E54
		public override void OnPlayableDestroy(Playable playable) {} // 0x0000000189D35E54-0x0000000189D35EF8
		public override void RuntimeReset() {} // 0x000000018350B670-0x000000018350B680
	}

	public class AnimationEventRuntimeContextPlayable : PlayableBehaviour // TypeDefIndex: 56521
	{
		// Fields
		private ITimelineAnimationEventContextBinding m_TimelineAnimationEventContextBinding; // 0x10
		private AnimationPlayableAsset.AnimationEventTriggerMode m_TriggerMode; // 0x18
		private AnimationEvent[] m_CachedAnimationEvents; // 0x20
		private float m_ClipDuration; // 0x28
		private bool m_IsRegistered; // 0x2C
		private bool m_HasRegisteredOnce; // 0x2D
	
		// Constructors
		public AnimationEventRuntimeContextPlayable() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static ScriptPlayable<AnimationEventRuntimeContextPlayable> Create(PlayableGraph graph, ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding, AnimationPlayableAsset.AnimationEventTriggerMode triggerMode, AnimationEvent[] cachedAnimationEvents, float clipDuration = 0f /* Metadata: 0x01FD8103 */, int inputCount = 1 /* Metadata: 0x01FD8107 */) => default; // 0x0000000189D36A84-0x0000000189D36BC8
		public void Initialize(ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding, AnimationPlayableAsset.AnimationEventTriggerMode triggerMode, AnimationEvent[] cachedAnimationEvents, float clipDuration) {} // 0x0000000189D36BC8-0x0000000189D36C08
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x0000000189D36C08-0x0000000189D36D38
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x0000000189D36D38-0x0000000189D36E5C
	}

	[Serializable]
	[Obsolete("For best performance use PlayableAsset and PlayableBehaviour.")]
	public class BasicPlayableBehaviour : ScriptableObject, IPlayableAsset, IPlayableBehaviour // TypeDefIndex: 56522
	{
		// Properties
		public virtual double duration { get => default; } // 0x0000000189D36F1C-0x0000000189D36F6C 
		public virtual IEnumerable<PlayableBinding> outputs { get => default; } // 0x0000000189D36F6C-0x0000000189D36FBC 
	
		// Constructors
		public BasicPlayableBehaviour() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		public virtual void OnGraphStart(Playable playable) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnGraphStop(Playable playable) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnPlayableCreate(Playable playable) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnPlayableDestroy(Playable playable) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnBehaviourPause(Playable playable, FrameData info) {} // 0x000000018350B670-0x000000018350B680
		public virtual void PrepareFrame(Playable playable, FrameData info) {} // 0x000000018350B670-0x000000018350B680
		public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x000000018350B670-0x000000018350B680
		public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x0000000189D36E5C-0x0000000189D36F1C
	}

	public class ControlPlayableBehaviour : PlayableBehaviour, IBehaviourRuntimeReset // TypeDefIndex: 56523
	{
		// Constructors
		public ControlPlayableBehaviour() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual void RuntimeReset() {} // 0x000000018350B670-0x000000018350B680
	}

	public class DirectorControlPlayable : ControlPlayableBehaviour // TypeDefIndex: 56524
	{
		// Fields
		public PlayableDirector director; // 0x10
		public ITimelineRootMarker rootMarker; // 0x18
		private const float SYNC_START_FORBID_THRESHOLD = 0.016666668f; // Metadata: 0x01FD8108
		private bool m_SyncTime; // 0x20
		private double m_AssetDuration; // 0x28
		private TimelinePlayable m_TimelinePlayable; // 0x30
	
		// Constructors
		public DirectorControlPlayable() {} // 0x0000000183D85660-0x0000000183D85670
	
		// Methods
		public static ScriptPlayable<DirectorControlPlayable> Create(PlayableGraph graph, PlayableDirector director) => default; // 0x0000000189D370E0-0x0000000189D37348
		public override void OnPlayableDestroy(Playable playable) {} // 0x0000000189D374B8-0x0000000189D37554
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x0000000189D37554-0x0000000189D3777C
		public override void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x0000000189D37400-0x0000000189D374B8
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x0000000189D37348-0x0000000189D37400
		public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x0000000189D3777C-0x0000000189D378AC
		private void SyncSpeed(double speed) {} // 0x0000000189D378AC-0x0000000189D379F8
		private void SyncStart(PlayableGraph graph, double time) {} // 0x0000000189D379F8-0x0000000189D37B1C
		private void SyncStop(PlayableGraph graph, double time) {} // 0x0000000189D37B1C-0x0000000189D37BE0
		public override void RuntimeReset() {} // 0x000000018350B670-0x000000018350B680
	}

	public interface ITimeControl // TypeDefIndex: 56525
	{
		// Methods
		void SetTime(double time);
		void OnControlTimeStart();
		void OnControlTimeStop();
	}

	[Serializable]
	[Flags]
	public enum NotificationFlags : short // TypeDefIndex: 56526
	{
		TriggerInEditMode = 1,
		Retroactive = 2,
		TriggerOnce = 4
	}

	public class ParticleControlPlayable : ControlPlayableBehaviour, ITimeDilationListener // TypeDefIndex: 56527
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
		private bool m_hadIgnite; // 0x38
		private bool m_hadSimulate; // 0x39
		private bool m_hadPlayed; // 0x3A
	
		// Properties
		public ParticleSystem particleSystem { get; private set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		private bool shouldSimulate { get => default; } // 0x0000000189D3A474-0x0000000189D3A49C 
	
		// Constructors
		public ParticleControlPlayable() {} // 0x0000000183D857A0-0x0000000183D857D0
	
		// Methods
		public static ScriptPlayable<ParticleControlPlayable> Create(PlayableGraph graph, ParticleSystem component, uint randomSeed, float clipIn, float speedMultiplier, bool forceRuntimeSimulate) => default; // 0x0000000189D399EC-0x0000000189D39B80
		public void Initialize(ParticleSystem ps, uint randomSeed, float clipIn, float simulateSpeed, bool forceRuntimeSimulate) {} // 0x0000000189D39B80-0x0000000189D39C40
		private void SetOriginalSimulateSpeed(ParticleSystem particleSystem, double simulateSpeed) {} // 0x0000000189D39EF4-0x0000000189D3A02C
		private static void SetRandomSeed(ParticleSystem particleSystem, uint randomSeed) {} // 0x0000000189D3A02C-0x0000000189D3A128
		public override void PrepareFrame(Playable playable, FrameData data) {} // 0x0000000189D39D50-0x0000000189D39EF4
		private void _SimulateParticle(float time, float particleTime, bool previewMode) {} // 0x0000000189D3A400-0x0000000189D3A474
		public override void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x0000000183D85780-0x0000000183D85790
		private void _PlayOrQueuedParticleSystem() {} // 0x0000000189D3A2E8-0x0000000189D3A400
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x0000000189D39C40-0x0000000189D39CFC
		private void Simulate(float time, bool restart) {} // 0x0000000189D3A128-0x0000000189D3A2E8
		public override void RuntimeReset() {} // 0x0000000183D85790-0x0000000183D857A0
		public void OnTimeDilationChanged(float timeScale) {} // 0x0000000189D39CFC-0x0000000189D39D50
	}

	public class PrefabControlPlayable : PlayableBehaviour // TypeDefIndex: 56528
	{
		// Fields
		private GameObject m_Instance; // 0x10
	
		// Properties
		public GameObject prefabInstance { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public PrefabControlPlayable() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static ScriptPlayable<PrefabControlPlayable> Create(PlayableGraph graph, GameObject prefabGameObject, Transform parentTransform) => default; // 0x0000000189D3A84C-0x0000000189D3A97C
		public GameObject Initialize(GameObject prefabGameObject, Transform parentTransform) => default; // 0x0000000189D3A97C-0x0000000189D3ABD0
		public override void OnPlayableDestroy(Playable playable) {} // 0x0000000189D3ACCC-0x0000000189D3AD54
		public override void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x0000000189D3AC5C-0x0000000189D3ACCC
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x0000000189D3ABD0-0x0000000189D3AC5C
		private static void SetHideFlagsRecursive(GameObject gameObject) {} // 0x0000000189D3AD54-0x0000000189D3AF7C
	}

	public class TimeControlPlayable : ControlPlayableBehaviour // TypeDefIndex: 56529
	{
		// Fields
		private ITimeControl m_timeControl; // 0x10
		private bool m_started; // 0x18
	
		// Constructors
		public TimeControlPlayable() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static ScriptPlayable<TimeControlPlayable> Create(PlayableGraph graph, ITimeControl timeControl) => default; // 0x0000000189D3D7B0-0x0000000189D3D8A0
		public void Initialize(ITimeControl timeControl) {} // 0x000000018426FEE0-0x000000018426FEF0
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x0000000189D3D948-0x0000000189D3D9C0
		public override void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x0000000189D3D8F4-0x0000000189D3D948
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x0000000189D3D8A0-0x0000000189D3D8F4
		public override void RuntimeReset() {} // 0x000000018350B670-0x000000018350B680
	}

	public class TimeNotificationBehaviour : PlayableBehaviour // TypeDefIndex: 56532
	{
		// Fields
		private readonly List<NotificationEntry> m_Notifications; // 0x10
		private double m_PreviousTime; // 0x18
		private bool m_NeedSortNotifications; // 0x20
		private bool m_IsManualUpdate; // 0x21
		private Playable m_TimeSource; // 0x28
	
		// Properties
		public Playable timeSource { set {} } // 0x0000000183D59E30-0x0000000183D59E40
		public bool isManualUpdate { set {} } // 0x0000000183D4F080-0x0000000183D4F090
	
		// Nested types
		private struct NotificationEntry // TypeDefIndex: 56530
		{
			// Fields
			public double time; // 0x00
			public INotification payload; // 0x08
			public bool notificationFired; // 0x10
			public NotificationFlags flags; // 0x12
	
			// Properties
			public bool triggerInEditor { get => default; } // 0x0000000189D394F4-0x0000000189D394FC 
			public bool prewarm { get => default; } // 0x0000000189D394EC-0x0000000189D394F4 
			public bool triggerOnce { get => default; } // 0x0000000189D394FC-0x0000000189D39504 
		}
	
		// Constructors
		public TimeNotificationBehaviour() {} // 0x0000000189D3E7F8-0x0000000189D3E870
	
		// Methods
		public static ScriptPlayable<TimeNotificationBehaviour> Create(PlayableGraph graph, double duration, DirectorWrapMode loopMode) => default; // 0x0000000189D3DAA4-0x0000000189D3DBB4
		public void AddNotification(double time, INotification payload, NotificationFlags flags = NotificationFlags.Retroactive /* Metadata: 0x01FD8112 */) {} // 0x0000000189D3D9C0-0x0000000189D3DA74
		public override void OnGraphStart(Playable playable) {} // 0x0000000189D3DD5C-0x0000000189D3DEFC
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x0000000189D3DBB4-0x0000000189D3DD5C
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x0000000189D3DEFC-0x0000000189D3E2D0
		private void SortNotifications() {} // 0x0000000189D3E2D0-0x0000000189D3E3F8
		private static bool CanRestoreNotification(NotificationEntry e, FrameData info, double currentTime, double previousTime) => default; // 0x0000000189D3DA74-0x0000000189D3DAA4
		private void TriggerNotificationsInRange(double start, double end, FrameData info, Playable playable, bool checkState) {} // 0x0000000189D3E4D8-0x0000000189D3E6B8
		private void SyncDurationWithExternalSource(Playable playable) {} // 0x0000000189D3E3F8-0x0000000189D3E4D8
		private static void Trigger_internal(Playable playable, PlayableOutput output, ref NotificationEntry e) {} // 0x0000000189D3E6B8-0x0000000189D3E734
		private static void Restore_internal(ref NotificationEntry e) {} // 0x0000000183D557C0-0x0000000183D557D0
		private static double _GetPlayableTime(Playable playable) => default; // 0x0000000189D3E734-0x0000000189D3E7F8
	}

	public class CommunicatorParam // TypeDefIndex: 56533
	{
		// Fields
		public IScriptAnimationJobSync jobSync; // 0x10
		public string uniqueId; // 0x18
		public bool lookAtUseAdditive; // 0x20
	
		// Constructors
		public CommunicatorParam() {} // 0x000000018350B670-0x000000018350B680
	}

	public interface IAutoGenMono // TypeDefIndex: 56534
	{
	}

	public interface IBehaviourRuntimeReset // TypeDefIndex: 56535
	{
	}

	public interface IScriptAnimationJobSync : IAutoGenMono // TypeDefIndex: 56536
	{
		// Methods
		void ProcessRootMotion(AnimationStream stream);
		void CalcLayerMainStream(float deltaTime);
		void ResetCloth(List<RuntimeElement> activeRuntimeElements, bool useSoftReset = true /* Metadata: 0x01FD8114 */, bool keepPose = false /* Metadata: 0x01FD8115 */, bool useRelativeTeleport = false /* Metadata: 0x01FD8116 */);
	}

	public struct TimelineScriptAnimationJob : IAnimationJob // TypeDefIndex: 56537
	{
		// Fields
		public IScriptAnimationJobSync bindedScriptAnimationJobSync; // 0x00
		public Animator bindedAnimator; // 0x08
	
		// Constructors
		public TimelineScriptAnimationJob(IScriptAnimationJobSync job, Animator animator) {
			bindedScriptAnimationJobSync = default;
			bindedAnimator = default;
		} // 0x00000001832C7BF0-0x00000001832C7C20
	
		// Methods
		public void ProcessAnimation(AnimationStream stream) {} // 0x000000018350B670-0x000000018350B680
		public void ProcessRootMotion(AnimationStream stream) {} // 0x0000000189D45FE0-0x0000000189D46028
	}

	[Serializable]
	public class PlayableTrack : TrackAsset // TypeDefIndex: 56538
	{
		// Constructors
		public PlayableTrack() {} // 0x0000000189D3A800-0x0000000189D3A84C
	
		// Methods
		protected override void OnCreateClip(TimelineClip clip) {} // 0x0000000189D3A768-0x0000000189D3A800
	}

	[AttributeUsage(AttributeTargets.Class)]
	[Obsolete("TrackMediaType has been deprecated. It is no longer required, and will be removed in a future release.", false)]
	public class TrackMediaType : Attribute // TypeDefIndex: 56539
	{
		// Constructors
		public TrackMediaType() {} // Dummy constructor
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public class TrackClipTypeAttribute : Attribute // TypeDefIndex: 56540
	{
		// Fields
		public readonly System.Type inspectedType; // 0x10
		public readonly bool allowAutoCreate; // 0x18
	
		// Constructors
		public TrackClipTypeAttribute() {} // Dummy constructor
		public TrackClipTypeAttribute(System.Type clipClass) {} // 0x0000000183809A70-0x0000000183809A90
		public TrackClipTypeAttribute(System.Type clipClass, bool allowAutoCreate) {} // 0x0000000183D4D900-0x0000000183D4D910
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
	public class NotKeyableAttribute : Attribute // TypeDefIndex: 56541
	{
		// Constructors
		public NotKeyableAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[Flags]
	public enum TrackBindingFlags // TypeDefIndex: 56542
	{
		None = 0,
		AllowCreateComponent = 1,
		All = 1
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class TrackBindingTypeAttribute : Attribute // TypeDefIndex: 56543
	{
		// Fields
		public readonly System.Type type; // 0x10
		public readonly TrackBindingFlags flags; // 0x18
	
		// Constructors
		public TrackBindingTypeAttribute() {} // Dummy constructor
		public TrackBindingTypeAttribute(System.Type type) {} // 0x00000001838BA920-0x00000001838BA950
		public TrackBindingTypeAttribute(System.Type type, TrackBindingFlags flags) {} // 0x0000000182738A30-0x0000000182738A50
	}

	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public class SupportsChildTracksAttribute : Attribute // TypeDefIndex: 56544
	{
		// Fields
		public readonly System.Type childType; // 0x10
		public readonly int levels; // 0x18
	
		// Constructors
		public SupportsChildTracksAttribute() {} // Dummy constructor
		public SupportsChildTracksAttribute(System.Type childType = null, int levels = 2147483647 /* Metadata: 0x01FD811A */) {} // 0x0000000183CBB760-0x0000000183CBB780
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	internal class IgnoreOnPlayableTrackAttribute : Attribute // TypeDefIndex: 56545
	{
		// Constructors
		public IgnoreOnPlayableTrackAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal class TimeFieldAttribute : PropertyAttribute // TypeDefIndex: 56547
	{
		// Nested types
		public enum UseEditMode // TypeDefIndex: 56546
		{
			None = 0,
			ApplyEditMode = 1
		}
	
		// Constructors
		public TimeFieldAttribute() {} // Dummy constructor
		public TimeFieldAttribute(UseEditMode useEditMode = UseEditMode.ApplyEditMode /* Metadata: 0x01FD811B */) {} // 0x00000001810410F0-0x0000000181041100
	}

	internal class FrameRateFieldAttribute : PropertyAttribute // TypeDefIndex: 56548
	{
		// Constructors
		public FrameRateFieldAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public class HideInMenuAttribute : Attribute // TypeDefIndex: 56549
	{
		// Constructors
		public HideInMenuAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class CustomStyleAttribute : Attribute // TypeDefIndex: 56550
	{
		// Fields
		public readonly string ussStyle; // 0x10
	
		// Constructors
		public CustomStyleAttribute() {} // Dummy constructor
		public CustomStyleAttribute(string ussStyle) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class MenuCategoryAttribute : Attribute // TypeDefIndex: 56551
	{
		// Constructors
		public MenuCategoryAttribute() {} // Dummy constructor
	}

	public interface ITimelineClipAsset // TypeDefIndex: 56552
	{
		// Properties
		ClipCaps clipCaps { get; }
	}

	internal interface ITimelineEvaluateCallback // TypeDefIndex: 56553
	{
		// Methods
		void Evaluate();
	}

	public class TimelinePlayable : PlayableBehaviour // TypeDefIndex: 56554
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
		public double timeForNextFrame { get => default; } // 0x0000000183D85810-0x0000000183D85820 
		public ITimelineRootMarker timelineRootMarker { get => default; } // 0x0000000183D4EA90-0x0000000183D4EAA0 
		public bool enableLoop { get => default; } // 0x0000000189D43324-0x0000000189D43398 
	
		// Constructors
		public TimelinePlayable() {} // 0x0000000189D42FD4-0x0000000189D43324
		static TimelinePlayable() {} // 0x0000000189D42F9C-0x0000000189D42FD4
	
		// Methods
		public static ScriptPlayable<TimelinePlayable> Create(PlayableGraph graph, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs) => default; // 0x0000000189D40E4C-0x0000000189D4109C
		public void Compile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs) {} // 0x0000000189D3FB34-0x0000000189D400B4
		public void MarkTimelineEnd() {} // 0x0000000183D85800-0x0000000183D85810
		public bool IsTimelineEnded() => default; // 0x0000000183D5CA70-0x0000000183D5CA80
		private void CompileCombineTopTopTrackList(PlayableGraph graph, Playable timelinePlayable, bool createOutputs) {} // 0x0000000189D3F418-0x0000000189D3F8E0
		private static void CollectCombineToTopTracksRecursive(TrackAsset track, List<TrackAsset> combineTracks) {} // 0x0000000189D3F24C-0x0000000189D3F418
		private void CompileTrackList(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool createOutputs, bool isCompilingCombineToTopTracks) {} // 0x0000000189D3F8E0-0x0000000189D3FB34
		private void CreateTrackOutput(PlayableGraph graph, TrackAsset track, GameObject go, Playable playable, int port) {} // 0x0000000189D400B4-0x0000000189D40A14
		private void EvaluateWeightsForAnimationPlayableOutput(TrackAsset track, AnimationPlayableOutput animOutput, Animator animator) {} // 0x0000000189D414A0-0x0000000189D4154C
		private Playable CreateTrackPlayable(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, bool createOutputs) => default; // 0x0000000189D40A14-0x0000000189D40E4C
		public void UpdateIntervalTree() {} // 0x0000000189D42734-0x0000000189D4277C
		public void RuntimeResetIntervalTree() {} // 0x0000000189D424F8-0x0000000189D42540
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x0000000189D42158-0x0000000189D424A4
		private void _ResetScriptAnimationJobySyncs() {} // 0x0000000189D42E20-0x0000000189D42F9C
		private void _EvaluateTwice() {} // 0x0000000189D42C54-0x0000000189D42D04
		public List<RuntimeElement> GetCurrentActiveClips() => default; // 0x0000000183D4E2B0-0x0000000183D4E2C0
		public List<RuntimeElement> GetActiveClipsAtGivenTime(double givenTime, List<RuntimeElement> activeClips = null) => default; // 0x0000000189D42024-0x0000000189D420F4
		public List<RuntimeElement> GetActiveClipsAtGivenTimeRange(double startTime, double endTime, List<RuntimeElement> activeClips = null) => default; // 0x0000000189D41F28-0x0000000189D42024
		protected virtual void Evaluate(Playable playable, FrameData frameData) {} // 0x0000000189D4154C-0x0000000189D41F28
		private bool DoReverseLoop(double reverseTime) => default; // 0x0000000189D41230-0x0000000189D414A0
		private bool DoReverseJump(RuntimeClip runtimeClip, double jumpTime) => default; // 0x0000000189D41154-0x0000000189D41230
		private bool DoJump(RuntimeClip runtimeClip, double localTime, double jumpTime) => default; // 0x0000000189D4109C-0x0000000189D41154
		private bool _CheckIfTimeJumping(FrameData frameData, double localTime) => default; // 0x0000000189D4277C-0x0000000189D42C54
		private void CacheTrack(TrackAsset track, Playable playable, int port, Playable parent) {} // 0x0000000189D3F178-0x0000000189D3F1E8
		public void SetTimeForNextFrame(double newTime) {} // 0x0000000183D85630-0x0000000183D85640
		public void RegisterTimeDilationListener(ITimeDilationListener listener) {} // 0x0000000189D424A4-0x0000000189D424F8
		public void MarkMixerForbidPostProcess(Playable mixer) {} // 0x0000000189D420F4-0x0000000189D42158
		public bool CheckIfMixerForbidPostProcess(Playable mixer) => default; // 0x0000000189D3F1E8-0x0000000189D3F24C
		public void SetTimeScale(float usingTimeScale) {} // 0x0000000189D42540-0x0000000189D42734
		private void _NotifyTimeScaleChanged(float usingTimeScale) {} // 0x0000000189D42D04-0x0000000189D42E20
	}

	public static class AnimationPreviewUtilities // TypeDefIndex: 56555
	{
	}

	internal static class Extrapolation // TypeDefIndex: 56557
	{
		// Fields
		internal static readonly double kMinExtrapolationTime; // 0x00
	
		// Constructors
		static Extrapolation() {} // 0x0000000189D3885C-0x0000000189D388C8
	
		// Methods
		private static TimelineClip[] SortClipsByStartTime(TimelineClip[] clips) => default; // 0x0000000189D38718-0x0000000189D3885C
	
		// Extension methods
		internal static void CalculateExtrapolationTimes(this TrackAsset asset) {} // 0x0000000189D38358-0x0000000189D38718
	}

	internal static class HashUtility // TypeDefIndex: 56558
	{
		// Methods
		public static int CombineHash(int h1, int h2, int h3) => default; // 0x0000000183D85720-0x0000000183D85760
		public static int CombineHash(int h1, int h2, int h3, int h4) => default; // 0x0000000183D856D0-0x0000000183D85720
		public static int CombineHash(int h1, int h2, int h3, int h4, int h5) => default; // 0x0000000189D389A0-0x0000000189D389D8
		public static int CombineHash(int h1, int h2, int h3, int h4, int h5, int h6) => default; // 0x0000000189D389D8-0x0000000189D38A2C
	
		// Extension methods
		public static int CombineHash(this int h1, int h2) => default; // 0x0000000183D85760-0x0000000183D85780
	}

	public interface IPropertyCollector // TypeDefIndex: 56559
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
		void AddFromComponent(GameObject obj, UnityEngine.Component component);
		void AddObjectProperties(UnityEngine.Object obj, AnimationClip clip);
	}

	public interface IPropertyPreview // TypeDefIndex: 56560
	{
		// Methods
		void GatherProperties(PlayableDirector director, IPropertyCollector driver);
	}

	internal static class NotificationUtilities // TypeDefIndex: 56561
	{
		// Methods
		public static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, double duration, DirectorWrapMode extrapolationMode) => default; // 0x0000000189D39504-0x0000000189D398CC
		public static bool TrackTypeSupportsNotifications(System.Type type) => default; // 0x0000000189D398CC-0x0000000189D399EC
	}

	public static class PlayableDirectorUtility // TypeDefIndex: 56562
	{
		// Methods
		public static void SetOptionIndexSingleDirector(PlayableDirector director, int curOptionIndex, int lastOptionIndex) {} // 0x0000000189D3A738-0x0000000189D3A768
		public static TimelinePlayable GetTimelinePlayable(PlayableDirector director) => default; // 0x0000000189D3A6BC-0x0000000189D3A738
		public static TimelinePlayable GetTimelinePlayable(PlayableGraph graph) => default; // 0x0000000189D3A60C-0x0000000189D3A6BC
		public static TimelinePlayable GetTimelinePlayableFromChildPlayable(Playable playable) => default; // 0x0000000189D3A560-0x0000000189D3A60C
		public static bool CheckIfTimelineFunctional(Playable playable) => default; // 0x0000000189D3A49C-0x0000000189D3A560
	}

	public static class TimelineClipExtensions // TypeDefIndex: 56563
	{
		// Fields
		private static readonly string k_UndoSetParentTrackText; // 0x00
	
		// Constructors
		static TimelineClipExtensions() {} // 0x0000000189D3E944-0x0000000189D3E9A0
	}

	public static class TimelineCreateUtilities // TypeDefIndex: 56566
	{
		// Methods
		public static string GenerateUniqueActorName(List<ScriptableObject> tracks, string name) => default; // 0x0000000189D3EBE0-0x0000000189D3EE94
		public static void SaveAssetIntoObject(UnityEngine.Object childAsset, UnityEngine.Object masterAsset) {} // 0x0000000189D3EE94-0x0000000189D3EF54
		public static AnimationClip CreateAnimationClipForTrack(string name, TrackAsset track, bool isLegacy) => default; // 0x0000000189D3EA3C-0x0000000189D3EBE0
		public static bool ValidateParentTrack(TrackAsset parent, System.Type childType) => default; // 0x0000000189D3EF54-0x0000000189D3F178
	}

	public class TimelineRuntimeUtils // TypeDefIndex: 56567
	{
		// Constructors
		public TimelineRuntimeUtils() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static double GetTimelineDeltaTime(Playable playable, FrameData frameData) => default; // 0x0000000189D45A38-0x0000000189D45AB0
		public static bool CheckWillRuntimeElementEnabled(RuntimeElement element, int curOptionIndex, int lastOptionIndex, long curDiscreteTime) => default; // 0x0000000189D43398-0x0000000189D4343C
		public static void DoReverseJump(RuntimeClip jumpClip, ITimelineRootMarker timelineRoot, double curTime, double jumpTime, double mixDuration, int curOptionIndex, int lastOptionIndex, bool needChangeOptionAfterJump, int newOptionIndex) {} // 0x0000000189D44440-0x0000000189D4543C
		public static void DoJump(RuntimeClip jumpClip, ITimelineRootMarker timelineRoot, double curTime, double jumpTime, double mixDuration, int curOptionIndex, int lastOptionIndex, bool needChangeOptionAfterJump, int optionIndexChangingTo) {} // 0x0000000189D4343C-0x0000000189D44440
		public static double GetSubDirectorTimeForDirectorControl(Playable playable, PlayableDirector director) => default; // 0x0000000189D458E0-0x0000000189D45A38
		public static void SetNewTimeForCutsceneRoot(ITimelineRootMarker timelineRoot, double newTime, bool useThisTimeNextFrame = false /* Metadata: 0x01FD811E */) {} // 0x0000000189D45D20-0x0000000189D45FE0
		public static AnimationClip FindTPoseClipFromLayerDescriptors(List<LayerDescriptor> layerDescriptors) => default; // 0x0000000189D4543C-0x0000000189D458E0
		public static void LinkDefaultTPoseIfNeeded(AnimationLayerMixerPlayable mixer, List<LayerDescriptor> layerDescriptors, string gameObjectName, bool disableBaseTPoseClip = false /* Metadata: 0x01FD811F */) {} // 0x0000000189D45C4C-0x0000000189D45D20
		public static void LinkDefaultTPoseClip(AnimationLayerMixerPlayable mixer, AnimationClip tposeClip, string gameObjectName) {} // 0x0000000189D45AB0-0x0000000189D45C4C
	}

	internal static class TimelineUndo // TypeDefIndex: 56568
	{
		// Methods
		public static void PushDestroyUndo(TimelineAsset timeline, UnityEngine.Object thingToDirty, UnityEngine.Object objectToDestroy) {} // 0x0000000189D46028-0x0000000189D46088
	}

	public enum StandardFrameRates // TypeDefIndex: 56569
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

	internal static class TimeUtility // TypeDefIndex: 56571
	{
		// Fields
		public static readonly double kTimeEpsilon; // 0x00
		public static readonly double kFrameRateEpsilon; // 0x08
		public static readonly double k_MaxTimelineDurationInSeconds; // 0x10
		public static readonly double kFrameRateRounding; // 0x18
	
		// Constructors
		static TimeUtility() {} // 0x0000000183CF7830-0x0000000183CF78D0
	
		// Methods
		public static double GetAnimationClipLength(AnimationClip clip) => default; // 0x0000000189D3E870-0x0000000189D3E944
	}

	internal static class WeightUtility // TypeDefIndex: 56572
	{
		// Methods
		public static float NormalizeMixer(Playable mixer) => default; // 0x0000000189D46208-0x0000000189D4648C
	}
}

namespace UnityEngine.Timeline.Condition
{
	[ExecuteAlways]
	public class TimelineConditionControlMono : MonoBehaviour // TypeDefIndex: 56573
	{
		// Fields
		public TimelineConditionBase condition; // 0x18
	
		// Constructors
		public TimelineConditionControlMono() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void RefreshOnCondition() {} // 0x0000000189D3E9A0-0x0000000189D3EA3C
	}
}
