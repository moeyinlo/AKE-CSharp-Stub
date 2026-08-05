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
using UnityEngine.Playables;
using UnityEngine.Scripting;
using UnityEngine.Serialization;
using UnityEngine.Timeline;

// Image 45: Unity.Timeline.dll - Assembly: Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59726-59921
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

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 59921
{
	// Methods
	internal static uint ComputeStringHash(string s); // 0x000000018687A850-0x000000018687A8A4
}

namespace Beyond.Gameplay.Core
{
	[AttributeUsage(AttributeTargets.Class)]
	public class DontAutoBindAttribute : DontAutoBindRuntimeAttribute // TypeDefIndex: 59741
	{
		// Constructors
		public DontAutoBindAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class DontAutoBindRuntimeAttribute : Attribute // TypeDefIndex: 59742
	{
		// Constructors
		public DontAutoBindRuntimeAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class BeyondUseAutoBindingPlayableAsset : PlayableAsset // TypeDefIndex: 59743
	{
		// Fields
		[HideInInspector]
		public bool useAutoBinding; // 0x18
		[HideInInspector]
		public string autoBindingPath; // 0x20
		[NonSerialized]
		protected GameObject m_bindingGo; // 0x28
	
		// Properties
		protected virtual bool showBaseParam { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public virtual GameObject bindingGameObject { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
	
		// Constructors
		public BeyondUseAutoBindingPlayableAsset(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		public void SetBindingGameObject(GameObject tBindingGameObject); // 0x000000018B33E76C-0x000000018B33E794
		protected virtual void OnBindGoChanged(); // 0x00000001841E1670-0x00000001841E1680
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018B33E720-0x000000018B33E76C
	}

	public class RuntimeJumpBehaviour : PlayableBehaviour // TypeDefIndex: 59744
	{
		// Constructors
		public RuntimeJumpBehaviour(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class RuntimeJumpClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 59745
	{
		// Fields
		public bool isReverseJump; // 0x18
		public bool needChangeOptionAfterJump; // 0x19
		public int optionIndexAfterJump; // 0x1C
		public double crossFadeDurationAfterJump; // 0x20
		public bool isJumpFirst; // 0x28
	
		// Properties
		public ClipCaps clipCaps { get; } // 0x0000000184DBA570-0x0000000184DBA580 
	
		// Constructors
		public RuntimeJumpClip(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018B33F664-0x000000018B33F6FC
	}

	[CombineToTopPlayable]
	[System.ComponentModel.DisplayName("Beyond/RuntimeJumpTrack")]
	[SupportsChildTracks(null, 2147483647)]
	[TrackClipType(typeof(RuntimeJumpClip))]
	public class RuntimeJumpTrack : TrackAsset // TypeDefIndex: 59746
	{
		// Constructors
		public RuntimeJumpTrack(); // 0x000000018B33F6FC-0x000000018B33F748
	}

	public class RuntimeLoopBehaviour : PlayableBehaviour // TypeDefIndex: 59747
	{
		// Constructors
		public RuntimeLoopBehaviour(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class RuntimeLoopClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 59748
	{
		// Fields
		public double crossFadeDuration; // 0x18
	
		// Properties
		public ClipCaps clipCaps { get; } // 0x0000000184DB8E50-0x0000000184DB8E60 
	
		// Constructors
		public RuntimeLoopClip(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018B33F748-0x000000018B33F7E0
	}

	[CombineToTopPlayable]
	[System.ComponentModel.DisplayName("Beyond/RuntimeLoopTrack")]
	[SupportsChildTracks(null, 2147483647)]
	[TrackClipType(typeof(RuntimeLoopClip))]
	public class RuntimeLoopTrack : TrackAsset // TypeDefIndex: 59749
	{
		// Constructors
		public RuntimeLoopTrack(); // 0x000000018B33F7E0-0x000000018B33F82C
	}

	[ExecuteInEditMode]
	public class TimelineNPCLookAtController : MonoBehaviour // TypeDefIndex: 59750
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
		public static IEnumerable<TimelineNPCLookAtController> Instances { get; } // 0x000000018B342314-0x000000018B342364 
		public bool lookAtDirty { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public float lookAtWeight { get; set; } // 0x000000018B342B08-0x000000018B342BA0 0x000000018B3432B8-0x000000018B343350
		public float lookAtBodyWeight { get; set; } // 0x000000018B3425D8-0x000000018B342674 0x000000018B342E0C-0x000000018B342EAC
		public float lookAtBlendWeight { get; set; } // 0x000000018B342564-0x000000018B3425D8 0x000000018B342D94-0x000000018B342E0C
		public float lookAtOverrideWeight { get; } // 0x000000018B342888-0x000000018B342924 
		public float lookAtAdditiveWeight { get; } // 0x000000018B3424E4-0x000000018B342564 
		public float lookAtRoll { get; set; } // 0x000000018B342924-0x000000018B3429C0 0x000000018B3430C8-0x000000018B343168
		public float lookAtHorizontal { get; set; } // 0x000000018B3427D0-0x000000018B342888 0x000000018B343014-0x000000018B3430C8
		public float lookAtVertical { get; set; } // 0x000000018B342A50-0x000000018B342B08 0x000000018B343204-0x000000018B3432B8
		public float lookAtEyeWeight { get; set; } // 0x000000018B342754-0x000000018B3427D0 0x000000018B342F9C-0x000000018B343014
		public bool lookAtUseDegree { get; set; } // 0x000000018B3429C0-0x000000018B342A50 0x000000018B343168-0x000000018B343204
		public bool EyeUseDegree { get; set; } // 0x000000018B3422A8-0x000000018B342314 0x000000018B342BA0-0x000000018B342C18
		public float lookAtEyeUp { get; set; } // 0x000000018B3426E4-0x000000018B342754 0x000000018B342F24-0x000000018B342F9C
		public float lookAtEyeDown { get; set; } // 0x000000018B342674-0x000000018B3426E4 0x000000018B342EAC-0x000000018B342F24
		public Vector3 finalPosition { get; set; } // 0x000000018B342410-0x000000018B3424E4 0x000000018B342CB8-0x000000018B342D94
		public Vector3 finalEyePosition { get; set; } // 0x000000018B342364-0x000000018B342410 0x000000018B342C18-0x000000018B342CB8
	
		// Constructors
		public TimelineNPCLookAtController(); // 0x000000018B34228C-0x000000018B3422A8
		static TimelineNPCLookAtController(); // 0x000000018B342200-0x000000018B34228C
	
		// Methods
		private void OnEnable(); // 0x000000018B342190-0x000000018B342200
		private void OnDisable(); // 0x000000018B342120-0x000000018B342190
		public void MarkLookAtDirty(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 59736
	{
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 59737
	{
		// Constructors
		public ECSComponentAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 59738
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 59739
	{
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 59740
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace Events
{
	public interface INotificationTrack // TypeDefIndex: 59734
	{
	}

	public interface ITimelineNotification // TypeDefIndex: 59735
	{
		// Methods
		void OnNotify(ITimelineRootMarker root);
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 59727
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace ScriptAnimation
{
	[UseScriptDefaultValueWhenExport]
	public class TimelineNPCClothWeightController : MonoBehaviour // TypeDefIndex: 59728
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
		public TimelineNPCClothWeightController(); // 0x000000018B3420EC-0x000000018B342120
	}

	[UseScriptDefaultValueWhenExport]
	public class TimelineNPCLookAtEyeTarget : MonoBehaviour // TypeDefIndex: 59729
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
		public TimelineNPCLookAtEyeTarget(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void ResetLookAtWeight(); // 0x0000000184D9A6D0-0x0000000184D9A6E0
	}

	[UseScriptDefaultValueWhenExport]
	public class TimelineNPCLookAtTarget : MonoBehaviour // TypeDefIndex: 59730
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
		public TimelineNPCLookAtTarget(); // 0x000000018B343350-0x000000018B343380
	}

	[UseScriptDefaultValueWhenExport]
	public class TimelineNPCLookAtTargetV2 : MonoBehaviour // TypeDefIndex: 59731
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
		public TimelineNPCLookAtTargetV2(); // 0x000000018B343350-0x000000018B343380
	}
}

namespace ScriptAnimation.ScriptAnimationApply
{
	public class ScriptAnimationApplyBehaviour : PlayableBehaviour // TypeDefIndex: 59732
	{
		// Fields
		private static readonly ProfilerMarker s_calcLayerMainStreamMarker; // 0x00
		private IScriptAnimationJobSync m_JobSync; // 0x10
	
		// Constructors
		public ScriptAnimationApplyBehaviour(); // 0x00000001841E1670-0x00000001841E1680
		static ScriptAnimationApplyBehaviour(); // 0x0000000182EC7070-0x0000000182EC7680
	
		// Methods
		public override void PrepareFrame(Playable playable, FrameData info); // 0x000000018B33F82C-0x000000018B33F980
		public void InitBehaviour(IScriptAnimationJobSync jobSync); // 0x00000001853908C0-0x00000001853908D0
	}

	public class ScriptAnimationApplyPlayable : PlayableAsset // TypeDefIndex: 59733
	{
		// Constructors
		public ScriptAnimationApplyPlayable(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018B33F980-0x000000018B33FA18
	}
}

namespace UnityEngine
{
	public static class PlayerLoopChecker // TypeDefIndex: 59751
	{
	}
}

namespace UnityEngine.Timeline
{
	internal class ActivationMixerPlayable : PlayableBehaviour // TypeDefIndex: 59752
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
		public ActivationTrack.PostPlaybackState postPlaybackState { set; } // 0x00000001814F51F0-0x00000001814F5220
	
		// Constructors
		public ActivationMixerPlayable(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static ScriptPlayable<ActivationMixerPlayable> Create(PlayableGraph graph, int inputCount); // 0x000000018B33AA78-0x000000018B33AB04
		public void SetBoundGameObject(GameObject go); // 0x000000018B33AD24-0x000000018B33ADB4
		public void SetAutoBindingData(bool useAutoBinding, ITimelineRootMarker rootMarker, string uniqueId); // 0x000000018B33ACFC-0x000000018B33AD24
		public override void OnPlayableDestroy(Playable playable); // 0x00000001841E1670-0x00000001841E1680
		public override void OnBehaviourPause(Playable playable, FrameData info); // 0x000000018B33AB04-0x000000018B33AB48
		public override void ProcessFrame(Playable playable, FrameData info, object playerData); // 0x000000018B33AC1C-0x000000018B33ACFC
		public override void PrepareFrame(Playable playable, FrameData info); // 0x000000018B33AB48-0x000000018B33AC1C
		private void _DoSetActive(Playable playable, FrameData info, object playerData = null); // 0x000000018B33ADB4-0x000000018B33B024
	}

	public class ActivationPlayableAsset : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 59753
	{
		// Properties
		public ClipCaps clipCaps { get; } // 0x00000001811EC580-0x00000001811EC590 
	
		// Constructors
		public ActivationPlayableAsset(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go); // 0x000000018B33B024-0x000000018B33B090
	}

	[Serializable]
	[ExcludeFromPreset]
	[TrackBindingType(typeof(GameObject))]
	[TrackClipType(typeof(ActivationPlayableAsset))]
	public class ActivationTrack : TrackAsset // TypeDefIndex: 59755
	{
		// Fields
		[SerializeField]
		private PostPlaybackState m_PostPlaybackState; // 0xC0
		private ActivationMixerPlayable m_ActivationMixer; // 0xC8
	
		// Properties
		public PostPlaybackState postPlaybackState { get; set; } // 0x0000000184DA4B70-0x0000000184DA4B80 0x000000018B33B540-0x000000018B33B550
	
		// Nested types
		public enum PostPlaybackState // TypeDefIndex: 59754
		{
			Active = 0,
			Inactive = 1,
			Revert = 2,
			LeaveAsIs = 3
		}
	
		// Constructors
		public ActivationTrack(); // 0x000000018B33B4EC-0x000000018B33B540
	
		// Methods
		internal override bool CanCompileClips(); // 0x000000018B33B090-0x000000018B33B0C0
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount); // 0x000000018B33B0C0-0x000000018B33B28C
		private void _BindUniqueId(PlayableGraph graph); // 0x000000018B33B498-0x000000018B33B4EC
		internal GameObject GetBinding(PlayableDirector director); // 0x000000018B33B32C-0x000000018B33B42C
		internal void UpdateTrackMode(); // 0x000000018B33B47C-0x000000018B33B498
		public override void GatherProperties(PlayableDirector director, IPropertyCollector driver); // 0x000000018B33B28C-0x000000018B33B32C
		protected override void OnCreateClip(TimelineClip clip); // 0x000000018B33B42C-0x000000018B33B47C
	}

	internal class AnimationOutputWeightProcessor : ITimelineEvaluateCallback // TypeDefIndex: 59757
	{
		// Fields
		private Animator m_outputAnimator; // 0x10
		private AnimationPlayableOutput m_Output; // 0x18
		private readonly List<WeightInfo> m_Mixers; // 0x28
	
		// Nested types
		private struct WeightInfo // TypeDefIndex: 59756
		{
			// Fields
			public Playable mixer; // 0x00
			public Playable parentMixer; // 0x10
			public int port; // 0x20
		}
	
		// Constructors
		public AnimationOutputWeightProcessor(AnimationPlayableOutput output, Animator animator); // 0x0000000183E117C0-0x0000000183E118A0
	
		// Methods
		private void FindMixers(); // 0x0000000183E10EA0-0x0000000183E10FB0
		private void FindMixers(Playable parent, int port, Playable node); // 0x0000000183E0FE10-0x0000000183E10160
		public void Evaluate(); // 0x0000000183E118A0-0x0000000183E11A60
	}

	[Serializable]
	[UnityEngine.Timeline.NotKeyable]
	public class AnimationPlayableAsset : PlayableAsset, ITimelineClipAsset, IPropertyPreview, ICustomControlBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 59765
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
		[Range(0f, 1f)]
		[SerializeField]
		private float m_AnimationEventTriggerWeightThreshold; // 0x54
		[SerializeField]
		private AnimationEventTriggerMode m_CustomFootStepTriggerMode; // 0x58
		[Range(0f, 1f)]
		[SerializeField]
		private float m_CustomFootStepTriggerWeightThreshold; // 0x5C
		[SerializeField]
		private ClipEndAudioBehaviour m_ClipEndAudioBehaviour; // 0x60
		[SerializeField]
		private int m_ClipEndAudioFadeOutTimeMs; // 0x64
		[SerializeField]
		private bool m_MixWitherAnotherClip; // 0x68
		[Range(0f, 1f)]
		[SerializeField]
		private float m_MainClipMixWeight; // 0x6C
		[SerializeField]
		private AnimationClip m_AnotherClip; // 0x70
		[SerializeField]
		private AnimationClip m_blendShapeControlClip; // 0x78
		[SerializeField]
		private bool m_UseTimeRemapCurve; // 0x80
		[SerializeField]
		private AnimationCurve m_TimeRemapCurve; // 0x88
		[CompilerGenerated]
		private bool _useAnotherClipTimeAdapter_k__BackingField; // 0x90
		public bool DisableBlendShapeControl; // 0x91
		[CompilerGenerated]
		private AppliedOffsetMode _appliedOffsetMode_k__BackingField; // 0x94
		[CompilerGenerated]
		private ITimelineAnimationEventContextBinding _TimelineAnimationEventContextBinding_k__BackingField; // 0x98
		private static readonly int k_LatestVersion; // 0x00
		[HideInInspector]
		[SerializeField]
		private int m_Version; // 0xA0
		[HideInInspector]
		[Obsolete("Use m_RotationEuler Instead", false)]
		[SerializeField]
		private Quaternion m_Rotation; // 0xA4
	
		// Properties
		internal bool useAnotherClipTimeAdapter { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182EC6590-0x0000000182EC65A0 0x0000000182EC65A0-0x0000000182EC65B0
		public Vector3 position { get; set; } // 0x0000000184D90830-0x0000000184D90850 0x0000000184D90820-0x0000000184D90830
		public Quaternion rotation { get; set; } // 0x000000018B33BE88-0x000000018B33BEC4 0x000000018B33BF94-0x000000018B33BFBC
		public Vector3 eulerAngles { get; set; } // 0x0000000184D90540-0x0000000184D90560 0x0000000184D90510-0x0000000184D90520
		public bool useTrackMatchFields { get; set; } // 0x00000001811F2A70-0x00000001811F2A80 0x00000001811F2A80-0x00000001811F2A90
		public MatchTargetFields matchTargetFields { get; set; } // 0x0000000184D86640-0x0000000184D86650 0x0000000184D86670-0x0000000184D86680
		public bool removeStartOffset { get; set; } // 0x0000000182D480A0-0x0000000182D480B0 0x0000000182D480B0-0x0000000182D480C0
		public bool applyFootIK { get; set; } // 0x0000000184D86F40-0x0000000184D86F50 0x0000000184D86F60-0x0000000184D86F70
		public LoopMode loop { get; set; } // 0x0000000184D86530-0x0000000184D86540 0x0000000184D86580-0x0000000184D86590
		public bool IgniteOnce { get; set; } // 0x0000000184D867D0-0x0000000184D867E0 0x0000000184D86810-0x0000000184D86820
		public bool OnlyDeltaTime { get; set; } // 0x0000000184D867E0-0x0000000184D867F0 0x0000000184D86820-0x0000000184D86830
		public bool DynamicLink { get; set; } // 0x0000000184D86F10-0x0000000184D86F20 0x0000000184D86F20-0x0000000184D86F30
		public bool MixWithAnotherClip { get; set; } // 0x0000000184D86B40-0x0000000184D86B50 0x0000000184D86BA0-0x0000000184D86BB0
		public AnimationClip AnotherClip { get; set; } // 0x0000000184D862B0-0x0000000184D862C0 0x00000001863AD760-0x00000001863AD770
		public AnimationClip BlendShapeControlClip { get; internal set; } // 0x0000000184D862A0-0x0000000184D862B0 0x0000000186402320-0x0000000186402330
		public bool useTimeRemapCurve { get; set; } // 0x0000000184D8D1F0-0x0000000184D8D200 0x0000000184D8D200-0x0000000184D8D210
		public AnimationCurve timeRemapCurve { get; set; } // 0x0000000184D861F0-0x0000000184D86200 0x0000000185395D30-0x0000000185395D44
		public float MainClipMixWeight { get; set; } // 0x0000000184DA3230-0x0000000184DA3240 0x0000000184DA3330-0x0000000184DA3340
		internal bool hasRootTransforms { get; } // 0x0000000183FA5BC0-0x0000000183FA5C80 
		internal AppliedOffsetMode appliedOffsetMode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86B20-0x0000000184D86B30 0x0000000184D86B80-0x0000000184D86B90
		internal ITimelineAnimationEventContextBinding TimelineAnimationEventContextBinding { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x0000000186352D0C-0x0000000186352D20
		public AnimationClip clip { get; set; } // 0x000000018385B100-0x000000018385B110 0x000000018B33BEC4-0x000000018B33BF94
		public override double duration { get; } // 0x000000018B33BDB0-0x000000018B33BE18 
		public ClothResetOption clothResetOption { get; set; } // 0x0000000184D86600-0x0000000184D86610 0x0000000184D86630-0x0000000184D86640
		public AnimationEventTriggerMode animationEventTriggerMode { get; set; } // 0x0000000184D86550-0x0000000184D86560 0x0000000184D865A0-0x0000000184D865B0
		public float animationEventTriggerWeightThreshold { get; set; } // 0x0000000184D86E00-0x0000000184D86E10 0x0000000184D86E10-0x0000000184D86E20
		public AnimationEventTriggerMode customFootStepTriggerMode { get; set; } // 0x0000000184D86570-0x0000000184D86580 0x0000000184D865D0-0x0000000184D865E0
		public float customFootStepTriggerWeightThreshold { get; set; } // 0x0000000184D91500-0x0000000184D91510 0x0000000184D91510-0x0000000184D91520
		public ClipEndAudioBehaviour clipEndAudioBehaviour { get; set; } // 0x0000000184D86790-0x0000000184D867A0 0x0000000184D86D50-0x0000000184D86D60
		public int clipEndAudioFadeOutTimeMs { get; set; } // 0x0000000184D88110-0x0000000184D88120 0x0000000184D88120-0x0000000184D88130
		public override IEnumerable<PlayableBinding> outputs { [IteratorStateMachine(typeof(_get_outputs_d__123))] get; } // 0x000000018B33BE18-0x000000018B33BE88 
		public ClipCaps clipCaps { get; } // 0x00000001839F6DB0-0x00000001839F6F80 
	
		// Nested types
		public enum LoopMode // TypeDefIndex: 59758
		{
			UseSourceAsset = 0,
			On = 1,
			Off = 2
		}
	
		public enum ClothResetOption // TypeDefIndex: 59759
		{
			SoftReset = 0,
			UseClothRelativeTeleport = 1,
			UseStablizationTime = 2,
			DisablePhysics = 3
		}
	
		public enum AnimationEventTriggerMode // TypeDefIndex: 59760
		{
			Default = 0,
			MuteAllEvents = 1,
			SeekAllEvents = 2
		}
	
		public enum ClipEndAudioBehaviour // TypeDefIndex: 59761
		{
			Default = 0,
			MuteAll = 1
		}
	
		private enum Versions // TypeDefIndex: 59762
		{
			Initial = 0,
			RotationAsEuler = 1
		}
	
		private static class AnimationPlayableAssetUpgrade // TypeDefIndex: 59763
		{
			// Methods
			public static void ConvertRotationToEuler(AnimationPlayableAsset asset); // 0x000000018B33B550-0x000000018B33B58C
		}
	
		[CompilerGenerated]
		private sealed class _get_outputs_d__123 : IEnumerable<PlayableBinding>, IEnumerator<PlayableBinding> // TypeDefIndex: 59764
		{
			// Fields
			private int __1__state; // 0x10
			private PlayableBinding __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			public AnimationPlayableAsset __4__this; // 0x40
	
			// Properties
			PlayableBinding IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { [DebuggerHidden] get; } // 0x0000000182EC7B40-0x0000000182EC7B60 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182EC7BC0-0x0000000182EC7ED0 
	
			// Constructors
			[DebuggerHidden]
			public _get_outputs_d__123(int __1__state); // 0x0000000183A10F90-0x0000000183A10FB0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000182EC7680-0x0000000182EC77A0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000182EC7B70-0x0000000182EC7BC0
			[DebuggerHidden]
			IEnumerator<PlayableBinding> IEnumerable<PlayableBinding>.GetEnumerator(); // 0x0000000182EC77A0-0x0000000182EC7B40
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000182EC7B60-0x0000000182EC7B70
		}
	
		// Constructors
		public AnimationPlayableAsset(); // 0x00000001839F4BC0-0x00000001839F4CC0
		static AnimationPlayableAsset(); // 0x0000000184D7AE50-0x0000000184D7AE90
	
		// Methods
		public float EvaluateTimeRemap(float normalizedTime); // 0x000000018B33B8C4-0x000000018B33B8FC
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go); // 0x0000000183FC5360-0x0000000183FC53E0
		internal static Playable CreatePlayable(PlayableGraph graph, AnimationClip clip, Vector3 positionOffset, Vector3 eulerOffset, bool removeStartOffset, AppliedOffsetMode mode, bool applyFootIK, LoopMode loop); // 0x000000018B33B5AC-0x000000018B33B8C4
		internal static Playable CreatePlayable(PlayableGraph graph, AnimationPlayableAsset playableAsset); // 0x000000018315BC80-0x000000018315EF90
		internal static AnimationClipPlayable CreateAnimationClipPlayable(PlayableGraph graph, AnimationClip clip, bool removeStartOffset, bool applyFootIK, LoopMode loop); // 0x0000000184CDB250-0x0000000184CDB2E0
		private static bool ShouldApplyOffset(AppliedOffsetMode mode, AnimationClip clip); // 0x0000000183FA56B0-0x0000000183FA5720
		private static bool ShouldApplyEventControl(AnimationPlayableAsset playableAsset); // 0x0000000184D2D300-0x0000000184D2D420
		internal static Playable TryApplyAnimationEventControl(PlayableGraph graph, Playable root, AnimationPlayableAsset playableAsset); // 0x000000018B33BB38-0x000000018B33BD54
		private static bool ShouldApplyScaleRemove(AppliedOffsetMode mode); // 0x0000000184D7F830-0x0000000184D7F850
		public void ResetOffsets(); // 0x000000018B33BB14-0x000000018B33BB38
		public void GatherProperties(PlayableDirector director, IPropertyCollector driver); // 0x000000018B33B8FC-0x000000018B33B94C
		internal static bool HasRootTransforms(AnimationClip clip); // 0x0000000183FA5C80-0x0000000183FA5D50
		public AnimationEvent[] CollectAnimationEvents(); // 0x000000018B33B58C-0x000000018B33B5AC
		public void OnClipEnable(Playable playable, FrameData info); // 0x00000001841E1670-0x00000001841E1680
		public void OnClipDisable(Playable playable, FrameData info); // 0x000000018B33B94C-0x000000018B33BB04
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018B33BD54-0x000000018B33BDB0
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x0000000184A05920-0x0000000184A05990
		private void OnUpgradeFromVersion(int oldVersion); // 0x000000018B33BB04-0x000000018B33BB14
	}

	internal class AnotherClipTimeAdapterBehaviour : PlayableBehaviour // TypeDefIndex: 59766
	{
		// Fields
		private Playable m_AnotherClipPlayable; // 0x10
		private bool m_Initialized; // 0x20
		private double m_Time; // 0x28
	
		// Constructors
		public AnotherClipTimeAdapterBehaviour(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Initialize(Playable anotherClipPlayable); // 0x0000000182EC65B0-0x0000000182EC65D0
		public override void PrepareFrame(Playable playable, FrameData info); // 0x0000000182EC65D0-0x0000000182EC7070
	}

	internal class AnimationPreviewUpdateCallback // TypeDefIndex: 59767
	{
	}

	[Flags]
	public enum MatchTargetFields // TypeDefIndex: 59768
	{
		PositionX = 1,
		PositionY = 2,
		PositionZ = 4,
		RotationX = 8,
		RotationY = 16,
		RotationZ = 32
	}

	public enum TrackOffset // TypeDefIndex: 59769
	{
		ApplyTransformOffsets = 0,
		ApplySceneOffsets = 1,
		Auto = 2
	}

	internal enum AppliedOffsetMode // TypeDefIndex: 59770
	{
		NoRootTransform = 0,
		TransformOffset = 1,
		SceneOffset = 2,
		TransformOffsetLegacy = 3,
		SceneOffsetLegacy = 4,
		SceneOffsetEditor = 5,
		SceneOffsetLegacyEditor = 6
	}

	internal static class MatchTargetFieldConstants // TypeDefIndex: 59771
	{
		// Fields
		public static MatchTargetFields All; // 0x00
		public static MatchTargetFields None; // 0x04
		public static MatchTargetFields Position; // 0x08
		public static MatchTargetFields Rotation; // 0x0C
	
		// Constructors
		static MatchTargetFieldConstants(); // 0x0000000184D35AB0-0x0000000184D35B30
	}

	[Serializable]
	[ExcludeFromPreset]
	[TrackBindingType(typeof(Animator))]
	[TrackClipType(typeof(AnimationPlayableAsset), false)]
	public class AnimationTrack : TrackAsset, ILayerable // TypeDefIndex: 59774
	{
		// Fields
		private const string k_DefaultInfiniteClipName = "Recorded"; // Metadata: 0x0234D156
		private const string k_DefaultRecordableClipName = "Recorded"; // Metadata: 0x0234D15F
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
		private bool m_UseLookAtV2; // 0x149
		[SerializeField]
		private bool m_WriteTransformDefAsPostProcess; // 0x14A
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
		public Vector3 position { get; set; } // 0x0000000184DBA4A0-0x0000000184DBA4C0 0x0000000184DBA550-0x0000000184DBA570
		public Quaternion rotation { get; set; } // 0x000000018B33D7C4-0x000000018B33D804 0x000000018B33D8B0-0x000000018B33D8E0
		public Vector3 eulerAngles { get; set; } // 0x0000000184DBA430-0x0000000184DBA450 0x0000000184DBA4C0-0x0000000184DBA4E0
		[Obsolete("applyOffset is deprecated. Use trackOffset instead", true)]
		public bool applyOffsets { get; set; } // 0x00000001812081B0-0x0000000181208610 0x00000001841E1670-0x00000001841E1680
		public TrackOffset trackOffset { get; set; } // 0x0000000184DB9B70-0x0000000184DB9B80 0x0000000184DB9C20-0x0000000184DB9C30
		public MatchTargetFields matchTargetFields { get; set; } // 0x0000000184D885B0-0x0000000184D885C0 0x000000018B33D834-0x000000018B33D890
		public AnimationClip infiniteClip { get; internal set; } // 0x0000000184D8DC70-0x0000000184D8DC80 0x00000001853971C0-0x00000001853971D4
		internal bool infiniteClipRemoveOffset { get; set; } // 0x0000000184D8C8C0-0x0000000184D8C8D0 0x0000000184D8C8F0-0x0000000184D8C900
		public AvatarMask avatarMask { get; set; } // 0x0000000184D8D1B0-0x0000000184D8D1C0 0x0000000185397170-0x0000000185397184
		public bool applyAvatarMask { get; set; } // 0x0000000184D92E30-0x0000000184D92E40 0x0000000184D92E40-0x0000000184D92E50
		public bool disableFloatCurveOnMask { get; set; } // 0x0000000184D8E510-0x0000000184D8E520 0x0000000184D8E540-0x0000000184D8E550
		public bool isUsingScriptAnimAddon { get; set; } // 0x0000000184DBA490-0x0000000184DBA4A0 0x0000000184DBA540-0x0000000184DBA550
		public bool lookAtUseAdditive { get; set; } // 0x0000000184D8FE60-0x0000000184D8FE70 0x0000000184D8FE90-0x0000000184D8FEA0
		public bool useLookAtV2 { get; set; } // 0x0000000184D8FE50-0x0000000184D8FE60 0x0000000184D8FE80-0x0000000184D8FE90
		public override IEnumerable<PlayableBinding> outputs { [IteratorStateMachine(typeof(_get_outputs_d__76))] get; } // 0x0000000184B87C60-0x0000000184B87CD0 
		public bool inClipMode { get; } // 0x00000001839F4E60-0x00000001839F4EB0 
		public Vector3 infiniteClipOffsetPosition { get; set; } // 0x0000000184DBA470-0x0000000184DBA490 0x0000000184DBA510-0x0000000184DBA530
		public Quaternion infiniteClipOffsetRotation { get; set; } // 0x000000018B33D75C-0x000000018B33D79C 0x000000018B33D804-0x000000018B33D834
		public Vector3 infiniteClipOffsetEulerAngles { get; set; } // 0x0000000184DBA450-0x0000000184DBA470 0x0000000184DBA4F0-0x0000000184DBA510
		internal bool infiniteClipApplyFootIK { get; set; } // 0x0000000184DAA0F0-0x0000000184DAA100 0x0000000184DBA4E0-0x0000000184DBA4F0
		internal double infiniteClipTimeOffset { get; set; } // 0x0000000184DA03A0-0x0000000184DA03B0 0x0000000184DBA530-0x0000000184DBA540
		public TimelineClip.ClipExtrapolation infiniteClipPreExtrapolation { get; set; } // 0x0000000184DA4B70-0x0000000184DA4B80 0x0000000184DA5DC0-0x0000000184DA5DD0
		public TimelineClip.ClipExtrapolation infiniteClipPostExtrapolation { get; set; } // 0x0000000184D9DF00-0x0000000184D9DF10 0x0000000184D9DFC0-0x0000000184D9DFD0
		internal AnimationPlayableAsset.LoopMode infiniteClipLoop { get; set; } // 0x0000000184D9DF40-0x0000000184D9DF50 0x0000000184D9E020-0x0000000184D9E030
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("openClipOffsetPosition has been deprecated. Use infiniteClipOffsetPosition instead. (UnityUpgradable) -> infiniteClipOffsetPosition", true)]
		public Vector3 openClipOffsetPosition { get; set; } // 0x0000000184DBA470-0x0000000184DBA490 0x0000000184DBA510-0x0000000184DBA530
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("openClipOffsetRotation has been deprecated. Use infiniteClipOffsetRotation instead. (UnityUpgradable) -> infiniteClipOffsetRotation", true)]
		public Quaternion openClipOffsetRotation { get; set; } // 0x000000018B33D79C-0x000000018B33D7C4 0x000000018B33D890-0x000000018B33D8B0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("openClipOffsetEulerAngles has been deprecated. Use infiniteClipOffsetEulerAngles instead. (UnityUpgradable) -> infiniteClipOffsetEulerAngles", true)]
		public Vector3 openClipOffsetEulerAngles { get; set; } // 0x0000000184DBA450-0x0000000184DBA470 0x0000000184DBA4F0-0x0000000184DBA510
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("openClipPreExtrapolation has been deprecated. Use infiniteClipPreExtrapolation instead. (UnityUpgradable) -> infiniteClipPreExtrapolation", true)]
		public TimelineClip.ClipExtrapolation openClipPreExtrapolation { get; set; } // 0x0000000184DA4B70-0x0000000184DA4B80 0x0000000184DA5DC0-0x0000000184DA5DD0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("openClipPostExtrapolation has been deprecated. Use infiniteClipPostExtrapolation instead. (UnityUpgradable) -> infiniteClipPostExtrapolation", true)]
		public TimelineClip.ClipExtrapolation openClipPostExtrapolation { get; set; } // 0x0000000184D9DF00-0x0000000184D9DF10 0x0000000184D9DFC0-0x0000000184D9DFD0
	
		// Nested types
		private static class AnimationTrackUpgrade // TypeDefIndex: 59772
		{
			// Methods
			public static void ConvertRotationsToEuler(AnimationTrack track); // 0x000000018B33C064-0x000000018B33C0CC
			public static void ConvertRootMotion(AnimationTrack track); // 0x000000018B33BFFC-0x000000018B33C064
			public static void ConvertInfiniteTrack(AnimationTrack track); // 0x000000018B33BFBC-0x000000018B33BFFC
		}
	
		[CompilerGenerated]
		private sealed class _get_outputs_d__76 : IEnumerable<PlayableBinding>, IEnumerator<PlayableBinding> // TypeDefIndex: 59773
		{
			// Fields
			private int __1__state; // 0x10
			private PlayableBinding __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			public AnimationTrack __4__this; // 0x40
	
			// Properties
			PlayableBinding IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { [DebuggerHidden] get; } // 0x0000000182EC7B40-0x0000000182EC7B60 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018B345DE4-0x000000018B3465FC 
	
			// Constructors
			[DebuggerHidden]
			public _get_outputs_d__76(int __1__state); // 0x0000000183A10F90-0x0000000183A10FB0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018441D910-0x000000018441D9A0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B345D98-0x000000018B345DE4
			[DebuggerHidden]
			IEnumerator<PlayableBinding> IEnumerable<PlayableBinding>.GetEnumerator(); // 0x0000000184CE4250-0x0000000184CE42B0
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B345D90-0x000000018B345D98
		}
	
		// Constructors
		public AnimationTrack(); // 0x00000001839F4CC0-0x00000001839F4E60
		static AnimationTrack(); // 0x0000000184D11C90-0x0000000184D11D50
	
		// Methods
		public bool IsControlByThisTrack(RuntimeElement element); // 0x000000018B33D584-0x000000018B33D5E0
		internal override bool CanCompileClips(); // 0x0000000184B30E40-0x0000000184B30EC0
		[ContextMenu("Reset Offsets")]
		private void ResetOffsets(); // 0x000000018B33D658-0x000000018B33D688
		public TimelineClip CreateClip(AnimationClip clip); // 0x000000018B33CA00-0x000000018B33CA94
		public void CreateInfiniteClip(string infiniteClipName); // 0x000000018B33CA94-0x000000018B33CB80
		public TimelineClip CreateRecordableClip(string animClipName); // 0x000000018B33CEE8-0x000000018B33CFF4
		protected override void OnCreateClip(TimelineClip clip); // 0x000000018B33D5E0-0x000000018B33D618
		protected internal override int CalculateItemsHash(); // 0x0000000184970AF0-0x0000000184970B70
		internal void UpdateClipOffsets(); // 0x00000001841E1670-0x00000001841E1680
		private Playable _CreatePlayableFromClip(TimelineClip c, PlayableGraph graph, GameObject go, AppliedOffsetMode mode, ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding); // 0x0000000183FC53E0-0x0000000183FC60A0
		private Playable CompileTrackPlayable(PlayableGraph graph, AnimationTrack track, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode, ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding); // 0x0000000183FA6280-0x0000000183FA6B30
		private bool ShouldLinkWithMainTrackMixer(AnimationTrack animationTrack); // 0x000000018B33D688-0x000000018B33D70C
		private Playable ApplyScriptAnimationPlayable(PlayableGraph graph, AnimationLayerMixerPlayable mixer, GameObject go); // 0x000000018B33C0CC-0x000000018B33C6E4
		Playable ILayerable.CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount); // 0x000000018B33D70C-0x000000018B33D75C
		internal override Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree); // 0x0000000183FA7330-0x0000000183FA9170
		private void AttachCustomBlend(PlayableGraph graph, AnimationLayerMixerPlayable layerMixer); // 0x00000001841E1670-0x00000001841E1680
		private void AttachLastAdditiveClip(PlayableGraph graph, AnimationLayerMixerPlayable layerMixer, GameObject go, IntervalTree<RuntimeElement> tree, List<AnimationTrack> flattenTracks, ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding); // 0x0000000184A1F7B0-0x0000000184A1FC60
		private int GetDefaultBlendCount(); // 0x0000000184D85B80-0x0000000184D85B90
		private void AttachDefaultBlend(PlayableGraph graph, AnimationLayerMixerPlayable mixer, bool requireOffset, Animator animator); // 0x00000001841E1670-0x00000001841E1680
		private Playable AttachOffsetPlayable(PlayableGraph graph, Playable playable, Vector3 pos, Quaternion rot); // 0x000000018B33C8C8-0x000000018B33CA00
		private bool RequiresMotionXPlayable(AppliedOffsetMode mode, GameObject gameObject); // 0x0000000183FA91A0-0x0000000183FA9210
		private static bool UsesAbsoluteMotion(AppliedOffsetMode mode); // 0x0000000183FA6270-0x0000000183FA6280
		private bool HasController(GameObject gameObject); // 0x000000018B33D4A4-0x000000018B33D584
		internal Animator GetBinding(PlayableDirector director); // 0x0000000183FA6B90-0x0000000183FA6DB0
		private static AnimationLayerMixerPlayable CreateGroupMixer(PlayableGraph graph, GameObject go, int inputCount); // 0x0000000183FA7170-0x0000000183FA7230
		private Playable CreateInfiniteTrackPlayable(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode); // 0x000000018B33CB80-0x000000018B33CEE8
		private Playable ApplyTrackOffset(PlayableGraph graph, Playable root, GameObject go, AppliedOffsetMode mode); // 0x000000018315B9B0-0x000000018315BC10
		private void _AddClipIntoTree(IntervalTree<RuntimeElement> tree, RuntimeClip clip); // 0x0000000183FA5F20-0x0000000183FA5FB0
		internal override void GetEvaluationTime(out double outStart, out double outDuration); // 0x0000000184D38A60-0x0000000184D38AD0
		internal override void GetSequenceTime(out double outStart, out double outDuration); // 0x0000000184864F30-0x0000000184864FB0
		private void AssignAnimationClip(TimelineClip clip, AnimationClip animClip); // 0x000000018B33C6E4-0x000000018B33C8C8
		public override void GatherProperties(PlayableDirector director, IPropertyCollector driver); // 0x00000001841E1670-0x00000001841E1680
		private void GetAnimationClips(List<AnimationClip> animClips); // 0x000000018B33D1B4-0x000000018B33D4A4
		private AppliedOffsetMode GetOffsetMode(GameObject go, bool animatesRootTransform); // 0x0000000183FA9170-0x0000000183FA91A0
		private bool IsRootTransformDisabledByMask(GameObject gameObject, Transform genericRootNode); // 0x0000000183FA9210-0x0000000183FA92E0
		private Transform GetGenericRootNode(GameObject gameObject); // 0x0000000183FA6E00-0x0000000183FA6FB0
		internal bool AnimatesRootTransform(); // 0x0000000183FA5720-0x0000000183FA5BC0
		private static Transform FindInHierarchyBreadthFirst(Transform t, string name); // 0x000000018B33CFF4-0x000000018B33D1B4
		internal override void OnUpgradeFromVersion(int oldVersion); // 0x000000018B33D618-0x000000018B33D658
	}

	internal interface ICurvesOwner // TypeDefIndex: 59775
	{
		// Properties
		string defaultCurvesName { get; }
		UnityEngine.Object asset { get; }
		UnityEngine.Object assetOwner { get; }
		TrackAsset targetTrack { get; }
	}

	[Serializable]
	public class TimelineClip : ICurvesOwner, ISerializationCallbackReceiver // TypeDefIndex: 59780
	{
		// Fields
		private const int k_LatestVersion = 1; // Metadata: 0x0234D168
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
		public double timeScale { get; } // 0x00000001839F6A20-0x00000001839F6B10 
		public double start { get; set; } // 0x0000000184D86360-0x0000000184D86370 0x000000018B342000-0x000000018B3420EC
		public double duration { get; set; } // 0x0000000184D86A10-0x0000000184D86A20 0x000000018B341D2C-0x000000018B341DC0
		public double end { get; } // 0x0000000184DBA5B0-0x0000000184DBA5C0 
		public double clipIn { get; } // 0x00000001839F6B10-0x00000001839F6B40 
		public string displayName { get; set; } // 0x0000000184D86250-0x0000000184D86260 0x0000000184D84CE0-0x0000000184D84D00
		public double clipAssetDuration { get; } // 0x000000018B341BD0-0x000000018B341C28 
		public AnimationClip curves { get; } // 0x0000000184D861F0-0x0000000184D86200 
		string ICurvesOwner.defaultCurvesName { get; } // 0x000000018B341B00-0x000000018B341B50 
		public UnityEngine.Object asset { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		UnityEngine.Object ICurvesOwner.assetOwner { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		TrackAsset ICurvesOwner.targetTrack { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		public double easeInDuration { get; set; } // 0x00000001847A2B30-0x00000001847A2BE0 0x000000018B341DC0-0x000000018B341EA4
		public double easeOutDuration { get; set; } // 0x00000001847A2C40-0x00000001847A2CF0 0x000000018B341EA4-0x000000018B341F88
		public double blendInDuration { get; } // 0x000000018B341B88-0x000000018B341BAC 
		public double blendOutDuration { get; } // 0x000000018B341BAC-0x000000018B341BD0 
		public bool hasBlendIn { get; } // 0x00000001847A2BE0-0x00000001847A2C10 
		public bool hasBlendOut { get; } // 0x00000001847A2CF0-0x00000001847A2D20 
		public AnimationCurve mixInCurve { get; set; } // 0x000000018B341C28-0x000000018B341C90 0x000000018485F170-0x000000018485F180
		public double mixInDuration { get; } // 0x00000001847A2B00-0x00000001847A2B30 
		public AnimationCurve mixOutCurve { get; set; } // 0x000000018B341C90-0x000000018B341CF8 0x00000001863AD760-0x00000001863AD770
		public double mixOutTime { get; } // 0x000000018B341CF8-0x000000018B341D2C 
		public double mixOutDuration { get; } // 0x00000001847A2C10-0x00000001847A2C40 
		public bool recordable { get; internal set; } // 0x0000000182EC6590-0x0000000182EC65A0 0x0000000182EC65A0-0x0000000182EC65B0
		public ClipCaps clipCaps { get; } // 0x00000001839F6B40-0x00000001839F6D70 
		public ClipExtrapolation postExtrapolationMode { get; set; } // 0x00000001839F6630-0x00000001839F6660 0x000000018B341F88-0x000000018B341FC4
		public ClipExtrapolation preExtrapolationMode { get; set; } // 0x00000001839F66A0-0x00000001839F66D0 0x000000018B341FC4-0x000000018B342000
		public double extrapolatedStart { get; } // 0x0000000184891CD0-0x0000000184891CF0 
		public double extrapolatedDuration { get; } // 0x00000001839F7450-0x00000001839F7540 
	
		// Nested types
		private enum Versions // TypeDefIndex: 59776
		{
			Initial = 0,
			ClipInFromGlobalToLocal = 1
		}
	
		private static class TimelineClipUpgrade // TypeDefIndex: 59777
		{
			// Methods
			public static void UpgradeClipInFromGlobalToLocal(TimelineClip clip); // 0x000000018B341458-0x000000018B341494
		}
	
		public enum ClipExtrapolation // TypeDefIndex: 59778
		{
			None = 0,
			Hold = 1,
			Loop = 2,
			PingPong = 3,
			Continue = 4
		}
	
		public enum BlendCurveMode // TypeDefIndex: 59779
		{
			Auto = 0,
			Manual = 1
		}
	
		// Constructors
		internal TimelineClip(TrackAsset parent); // 0x000000018B341B60-0x000000018B341B88
		static TimelineClip(); // 0x0000000184CC6370-0x0000000184CC6470
	
		// Methods
		private void UpgradeToLatestVersion(); // 0x000000018B341B50-0x000000018B341B60
		public TrackAsset GetParentTrack(); // 0x0000000184D85A60-0x0000000184D85A70
		internal void SetParentTrack_Internal(TrackAsset newParentTrack); // 0x000000018B3418A4-0x000000018B341984
		internal int Hash(); // 0x0000000183AC40C0-0x0000000183AC4200
		public float EvaluateMixOut(double time); // 0x00000001839F75E0-0x00000001839F7660
		public float EvaluateMixOutAtGivenTime(double time, double mixOutTime, double mixOutDuration); // 0x000000018B341558-0x000000018B34161C
		public float EvaluateMixIn(double time); // 0x00000001839F76E0-0x00000001839F7760
		public float EvaluateMixInAtGivenTime(double time, double runtimeMixInTime, double mixInDuration); // 0x000000018B341494-0x000000018B341558
		private static AnimationCurve GetDefaultMixInCurve(); // 0x000000018B34161C-0x000000018B341644
		private static AnimationCurve GetDefaultMixOutCurve(); // 0x000000018B341644-0x000000018B34166C
		public double ToLocalTime(double time); // 0x00000001839F5D40-0x00000001839F5E10
		private static double SanitizeTimeValue(double value, double defaultValue); // 0x000000018B3417AC-0x000000018B3418A4
		internal void SetPostExtrapolationTime(double time); // 0x0000000184DBA590-0x0000000184DBA5A0
		internal void SetPreExtrapolationTime(double time); // 0x0000000184DBA5A0-0x0000000184DBA5B0
		public bool IsPreExtrapolatedTime(double sequenceTime); // 0x00000001839F6660-0x00000001839F66A0
		public bool IsPostExtrapolatedTime(double sequenceTime); // 0x00000001839F65F0-0x00000001839F6630
		private static double GetExtrapolatedTime(double time, ClipExtrapolation mode, double duration); // 0x000000018B34166C-0x000000018B3417AC
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x0000000184D89110-0x0000000184D89120
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x0000000184CC60D0-0x0000000184CC60F0
		public override string ToString(); // 0x000000018B341984-0x000000018B341B00
		private void UpdateDirty(double oldValue, double newValue); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	[ExcludeFromPreset]
	public class TimelineAsset : PlayableAsset, ISerializationCallbackReceiver, ITimelineClipAsset, IPropertyPreview // TypeDefIndex: 59787
	{
		// Fields
		private const int k_LatestVersion = 0; // Metadata: 0x0234D172
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
		public EditorSettings editorSettings { get; } // 0x0000000184D86270-0x0000000184D86280 
		public override double duration { get; } // 0x00000001839F2D40-0x00000001839F2DE0 
		public double fixedDuration { get; set; } // 0x000000018B341310-0x000000018B341390 0x000000018B341400-0x000000018B341458
		public DurationMode durationMode { get; set; } // 0x0000000184D86570-0x0000000184D86580 0x0000000184D865D0-0x0000000184D865E0
		public override IEnumerable<PlayableBinding> outputs { [IteratorStateMachine(typeof(_get_outputs_d__28))] get; } // 0x00000001848FD6E0-0x00000001848FD760 
		public ClipCaps clipCaps { get; } // 0x000000018B34105C-0x000000018B341310 
		public int outputTrackCount { get; } // 0x000000018B341390-0x000000018B3413B8 
		public int rootTrackCount { get; } // 0x000000018B3413B8-0x000000018B341400 
		internal TrackAsset[] flattenedTracks { get; } // 0x00000001839F35B0-0x00000001839F3720 
		public MarkerTrack markerTrack { get; } // 0x0000000184D86280-0x0000000184D86290 
		internal List<ScriptableObject> trackObjects { get; } // 0x0000000184D862C0-0x0000000184D862D0 
	
		// Nested types
		private enum Versions // TypeDefIndex: 59781
		{
			Initial = 0
		}
	
		private static class TimelineAssetUpgrade // TypeDefIndex: 59782
		{
		}
	
		[Obsolete("MediaType has been deprecated. It is no longer required, and will be removed in a future release.", false)]
		public enum MediaType // TypeDefIndex: 59783
		{
			Animation = 0,
			Audio = 1,
			Texture = 2,
			Video = 2,
			Script = 3,
			Hybrid = 4,
			Group = 5
		}
	
		public enum DurationMode // TypeDefIndex: 59784
		{
			BasedOnClips = 0,
			FixedLength = 1
		}
	
		[Serializable]
		public class EditorSettings // TypeDefIndex: 59785
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
			public double frameRate { get; set; } // 0x0000000184D96320-0x0000000184D96330 0x000000018B33F644-0x000000018B33F664
	
			// Constructors
			public EditorSettings(); // 0x00000001839F4B00-0x00000001839F4B70
			static EditorSettings(); // 0x0000000184D1DB60-0x0000000184D1DC10
		}
	
		[CompilerGenerated]
		private sealed class _get_outputs_d__28 : IEnumerable<PlayableBinding>, IEnumerator<PlayableBinding> // TypeDefIndex: 59786
		{
			// Fields
			private int __1__state; // 0x10
			private PlayableBinding __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			public TimelineAsset __4__this; // 0x40
			private IEnumerator<TrackAsset> __7__wrap1; // 0x48
			private IEnumerator<PlayableBinding> __7__wrap2; // 0x50
	
			// Properties
			PlayableBinding IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { [DebuggerHidden] get; } // 0x0000000182EC7B40-0x0000000182EC7B60 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018B345B6C-0x000000018B345BBC 
	
			// Constructors
			[DebuggerHidden]
			public _get_outputs_d__28(int __1__state); // 0x0000000183A10F90-0x0000000183A10FB0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000184CD8100-0x0000000184CD8180
			private bool MoveNext(); // 0x0000000183FC8FA0-0x0000000183FC9770
			private void __m__Finally1(); // 0x0000000183FC8DD0-0x0000000183FC8E30
			private void __m__Finally2(); // 0x0000000183FC8F40-0x0000000183FC8FA0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B345B20-0x000000018B345B6C
			[DebuggerHidden]
			IEnumerator<PlayableBinding> IEnumerable<PlayableBinding>.GetEnumerator(); // 0x0000000184A21450-0x0000000184A214B0
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B345B18-0x000000018B345B20
		}
	
		// Constructors
		public TimelineAsset(); // 0x00000001839F4A90-0x00000001839F4B00
	
		// Methods
		private void UpgradeToLatestVersion(); // 0x00000001841E1670-0x00000001841E1680
		private void OnValidate(); // 0x000000018B340F0C-0x000000018B340F40
		public TrackAsset GetRootTrack(int index); // 0x000000018B340A30-0x000000018B340A8C
		public IEnumerable<TrackAsset> GetRootTracks(); // 0x000000018B340A8C-0x000000018B340AA8
		public TrackAsset GetOutputTrack(int index); // 0x000000018B3409EC-0x000000018B340A30
		public IEnumerable<TrackAsset> GetOutputTracks(); // 0x00000001853947BC-0x00000001853947D8
		public IEnumerable<GroupTrack> GetGroupTracks(); // 0x0000000185396C14-0x0000000185396C30
		private static double GetValidFrameRate(double frameRate); // 0x000000018B340AA8-0x000000018B340B48
		private void UpdateRootTrackCache(); // 0x00000001839F3DE0-0x00000001839F40B0
		private void UpdateOutputTrackCache(); // 0x00000001839F2A60-0x00000001839F2D40
		public TrackAsset[] GetAllTracks(); // 0x000000018B3409E4-0x000000018B3409EC
		internal void AddTrackInternal(TrackAsset track); // 0x000000018B33FA18-0x000000018B33FA88
		internal void RemoveTrack(TrackAsset track); // 0x000000018B340F40-0x000000018B341000
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go); // 0x0000000183FC6180-0x0000000183FC6800
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x0000000184DBA580-0x0000000184DBA590
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001839ED100-0x00000001839ED110
		private void __internalAwake(); // 0x00000001845A5340-0x00000001845A54A0
		public void GatherProperties(PlayableDirector director, IPropertyCollector driver); // 0x000000018B340880-0x000000018B3409E4
		public void CreateMarkerTrack(); // 0x000000018B33FCE4-0x000000018B33FDB8
		internal void Invalidate(); // 0x00000001839ED6C0-0x00000001839ED700
		internal void UpdateFixedDurationWithItemsDuration(); // 0x000000018B341000-0x000000018B34105C
		private DiscreteTime CalculateItemsDuration(); // 0x00000001839F2E40-0x00000001839F2FC0
		private static void AddSubTracksRecursive(TrackAsset track, ref List<TrackAsset> allTracks); // 0x00000001839F3730-0x00000001839F3990
		public TrackAsset CreateTrack(System.Type type, TrackAsset parent, string name); // 0x000000018B33FDB8-0x000000018B3400D4
		public T CreateTrack<T>(TrackAsset parent, string trackName)
			where T : TrackAsset, new();
		public T CreateTrack<T>(string trackName)
			where T : TrackAsset, new();
		public T CreateTrack<T>()
			where T : TrackAsset, new();
		public bool DeleteClip(TimelineClip clip); // 0x000000018B3400D4-0x000000018B340270
		public bool DeleteTrack(TrackAsset track); // 0x000000018B3404F4-0x000000018B340880
		internal void MoveLastTrackBefore(TrackAsset asset); // 0x000000018B340B48-0x000000018B340D04
		public void MoveTrackAfter(TrackAsset trackToMove, TrackAsset targetTrack); // 0x000000018B340D04-0x000000018B340F0C
		private TrackAsset AllocateTrack(TrackAsset trackAssetParent, string trackName, System.Type trackType); // 0x000000018B33FA88-0x000000018B33FCE4
		private void DeleteRecordedAnimation(TrackAsset track); // 0x000000018B340270-0x000000018B340374
		private void DeleteRecordedAnimation(TimelineClip clip); // 0x000000018B340374-0x000000018B3404F4
	}

	[Serializable]
	[IgnoreOnPlayableTrack]
	[SupportsChildTracks(null, 2147483647)]
	public abstract class TrackAsset : PlayableAsset, ISerializationCallbackReceiver, IPropertyPreview, ICurvesOwner, IDynamicBinding // TypeDefIndex: 59793
	{
		// Fields
		private const int k_LatestVersion = 3; // Metadata: 0x0234D17D
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
		public int uiBindingType; // 0x40
		private static TransientBuildData s_BuildData; // 0x00
		internal const string kDefaultCurvesName = "Track Parameters"; // Metadata: 0x0234D17E
		[CompilerGenerated]
		private static Action<TimelineClip, GameObject, Playable> OnClipPlayableCreate; // 0x18
		[CompilerGenerated]
		private static Action<TrackAsset, GameObject, Playable> OnTrackAnimationPlayableCreate; // 0x20
		private bool m_RuntimeMuted; // 0x44
		[HideInInspector]
		[SerializeField]
		private bool m_Locked; // 0x45
		[HideInInspector]
		[SerializeField]
		private bool m_Muted; // 0x46
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
		public double start { get; } // 0x000000018B34574C-0x000000018B34579C 
		public double end { get; } // 0x00000001839F2DE0-0x00000001839F2E40 
		public sealed override double duration { get; } // 0x000000018B3455C0-0x000000018B345624 
		public virtual bool muted { get; set; } // 0x00000001839F34A0-0x00000001839F34C0 0x0000000184D90900-0x0000000184D90910
		public virtual bool runtimeMuted { get; set; } // 0x0000000184D86A30-0x0000000184D86A40 0x0000000184D86A40-0x0000000184D86A50
		public bool mutedInHierarchy { get; } // 0x00000001839F33B0-0x00000001839F34A0 
		public TimelineAsset timelineAsset { get; } // 0x00000001839ED500-0x00000001839ED6C0 
		public PlayableAsset parent { get; set; } // 0x0000000182E56440-0x0000000182E56460 0x00000001836E5590-0x00000001836E55A0
		internal TimelineClip[] clips { get; } // 0x00000001839F4650-0x00000001839F46F0 
		public virtual bool isEmpty { get; } // 0x000000018B345624-0x000000018B345660 
		public bool hasClips { get; } // 0x000000018468DAA0-0x000000018468DAF0 
		public bool hasCurves { get; } // 0x0000000183E0E860-0x0000000183E0E900 
		public bool isSubTrack { get; } // 0x00000001839F40B0-0x00000001839F4170 
		public override IEnumerable<PlayableBinding> outputs { [IteratorStateMachine(typeof(_get_outputs_d__75))] get; } // 0x0000000183A10EB0-0x0000000183A10F30 
		internal string customPlayableTypename { get; set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
		public AnimationClip curves { get; internal set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		string ICurvesOwner.defaultCurvesName { get; } // 0x000000018B3451FC-0x000000018B345228 
		UnityEngine.Object ICurvesOwner.asset { get; } // 0x000000018464E630-0x000000018464E640 
		UnityEngine.Object ICurvesOwner.assetOwner { get; } // 0x000000018B3451F4-0x000000018B3451FC 
		TrackAsset ICurvesOwner.targetTrack { get; } // 0x000000018464E630-0x000000018464E640 
		internal List<ScriptableObject> subTracksObjects { get; } // 0x0000000184D86280-0x0000000184D86290 
		public bool locked { get; set; } // 0x0000000184D86EF0-0x0000000184D86F00 0x0000000184D86F00-0x0000000184D86F10
		public bool lockedInHierarchy { get; } // 0x000000018B345660-0x000000018B34574C 
		public bool supportsNotifications { get; } // 0x00000001839EDE90-0x00000001839EDF20 
	
		// Events
		internal static event Action<TimelineClip, GameObject, Playable> OnClipPlayableCreate {
			add; // 0x000000018B345430-0x000000018B3454F8
			remove; // 0x000000018B34579C-0x000000018B345864
		}
		internal static event Action<TrackAsset, GameObject, Playable> OnTrackAnimationPlayableCreate {
			add; // 0x000000018B3454F8-0x000000018B3455C0
			remove; // 0x000000018B345864-0x000000018B34592C
		}
	
		// Nested types
		internal enum Versions // TypeDefIndex: 59788
		{
			Initial = 0,
			RotationAsEuler = 1,
			RootMotionUpgrade = 2,
			AnimatedTrackProperties = 3
		}
	
		private static class TrackAssetUpgrade // TypeDefIndex: 59789
		{
		}
	
		private struct TransientBuildData // TypeDefIndex: 59790
		{
			// Fields
			public List<TrackAsset> trackList; // 0x00
			public List<TimelineClip> clipList; // 0x08
			public List<IMarker> markerList; // 0x10
	
			// Methods
			public static TransientBuildData Create(); // 0x00000001848BB060-0x00000001848BB190
			public void Clear(); // 0x00000001839EDBA0-0x00000001839EDC30
		}
	
		[CompilerGenerated]
		private sealed class _get_outputs_d__75 : IEnumerable<PlayableBinding>, IEnumerator<PlayableBinding> // TypeDefIndex: 59791
		{
			// Fields
			private int __1__state; // 0x10
			private PlayableBinding __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			public TrackAsset __4__this; // 0x40
	
			// Properties
			PlayableBinding IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { [DebuggerHidden] get; } // 0x0000000182EC7B40-0x0000000182EC7B60 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018B345D40-0x000000018B345D90 
	
			// Constructors
			[DebuggerHidden]
			public _get_outputs_d__75(int __1__state); // 0x0000000183A10F90-0x0000000183A10FB0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018441DAE0-0x000000018441DD30
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B345CF4-0x000000018B345D40
			[DebuggerHidden]
			IEnumerator<PlayableBinding> IEnumerable<PlayableBinding>.GetEnumerator(); // 0x0000000183A10FB0-0x0000000183A11010
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B345CEC-0x000000018B345CF4
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 59792
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<TimelineClip> __9__132_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000184D489D0-0x0000000184D48A30
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _SortClips_b__132_0(TimelineClip clip1, TimelineClip clip2); // 0x000000018B34592C-0x000000018B345968
		}
	
		// Constructors
		protected TrackAsset(); // 0x00000001839F3990-0x00000001839F3AA0
		static TrackAsset(); // 0x00000001848BAF40-0x00000001848BB060
	
		// Methods
		protected virtual void OnBeforeTrackSerialize(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnAfterTrackDeserialize(); // 0x00000001841E1670-0x00000001841E1680
		internal virtual void OnUpgradeFromVersion(int oldVersion); // 0x00000001841E1670-0x00000001841E1680
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018B3450E0-0x000000018B3451F4
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001839ED110-0x00000001839ED390
		private void UpgradeToLatestVersion(); // 0x00000001841E1670-0x00000001841E1680
		public IEnumerable<TimelineClip> GetClips(); // 0x00000001853947D8-0x00000001853947E0
		public IEnumerable<TrackAsset> GetChildTracks(); // 0x00000001853947E0-0x0000000185394800
		private void __internalAwake(); // 0x00000001847FDE30-0x00000001847FDEC0
		public void CreateCurves(string curvesClipName); // 0x000000018B343DAC-0x000000018B343E4C
		public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount); // 0x0000000183E0EB60-0x0000000183E0EC40
		public sealed override Playable CreatePlayable(PlayableGraph graph, GameObject go); // 0x000000018B34440C-0x000000018B34445C
		public TimelineClip CreateDefaultClip(); // 0x000000018B343E4C-0x000000018B34406C
		public TimelineClip CreateClip<T>()
			where T : ScriptableObject, IPlayableAsset;
		public bool DeleteClip(TimelineClip clip); // 0x000000018B34445C-0x000000018B34456C
		public IMarker CreateMarker(System.Type type, double time); // 0x000000018B3441AC-0x000000018B3441D0
		public T CreateMarker<T>(double time)
			where T : ScriptableObject, IMarker;
		public bool DeleteMarker(IMarker marker); // 0x000000018B3445AC-0x000000018B3445BC
		public IEnumerable<IMarker> GetMarkers(); // 0x00000001839ED390-0x00000001839ED440
		public IEnumerable<IMarker> GetClipMarkers(); // 0x000000018B344938-0x000000018B344B34
		public int GetMarkerCount(); // 0x000000018B344C40-0x000000018B344C50
		public IMarker GetMarker(int idx); // 0x000000018B344C50-0x000000018B344C60
		internal TimelineClip CreateClip(System.Type requestedType); // 0x000000018B343C90-0x000000018B343DAC
		internal TimelineClip CreateAndAddNewClipOfType(System.Type requestedType); // 0x000000018B3435DC-0x000000018B343610
		internal TimelineClip CreateClipOfType(System.Type requestedType); // 0x000000018B343A78-0x000000018B343C90
		internal TimelineClip CreateClipFromPlayableAsset(IPlayableAsset asset); // 0x000000018B343834-0x000000018B343A78
		private TimelineClip CreateClipFromAsset(ScriptableObject playableAsset); // 0x000000018B343610-0x000000018B343834
		internal IEnumerable<ScriptableObject> GetMarkersRaw(); // 0x0000000184D86210-0x0000000184D86220
		internal void ClearMarkers(); // 0x000000018B34354C-0x000000018B34355C
		internal void AddMarker(ScriptableObject e); // 0x000000018B3434B0-0x000000018B3434C0
		internal bool DeleteMarkerRaw(ScriptableObject marker); // 0x000000018B34456C-0x000000018B3445AC
		private int GetTimeRangeHash(); // 0x0000000183AC3FA0-0x0000000183AC4070
		internal void AddClip(TimelineClip newClip); // 0x000000018B34341C-0x000000018B3434B0
		private Playable CreateNotificationsPlayable(PlayableGraph graph, Playable mixerPlayable, GameObject go, Playable timelinePlayable); // 0x00000001839ECE10-0x00000001839ED100
		internal Playable CreatePlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, Playable timelinePlayable); // 0x0000000183433C20-0x0000000183433E70
		internal virtual Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree); // 0x0000000183E0DAE0-0x0000000183E0DEC0
		private void GatherCompilableTracks(IList<TrackAsset> tracks); // 0x0000000184683BA0-0x0000000184683DB0
		private void GatherNotifications(List<IMarker> markers); // 0x00000001839EDC30-0x00000001839EDE60
		internal virtual Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree); // 0x00000001839F4170-0x00000001839F4650
		internal void ConfigureTrackAnimation(IntervalTree<RuntimeElement> tree, GameObject go, Playable blend); // 0x0000000183E0E7D0-0x0000000183E0E860
		internal void SortClips(); // 0x00000001839F46F0-0x00000001839F4860
		internal void ClearClipsInternal(); // 0x000000018B3434C0-0x000000018B34354C
		internal void ClearSubTracksInternal(); // 0x000000018B34355C-0x000000018B3435DC
		internal void OnClipMove(); // 0x0000000184DA66E0-0x0000000184DA66F0
		internal TimelineClip CreateNewClipContainerInternal(); // 0x000000018B3441D0-0x000000018B34440C
		internal void AddChild(TrackAsset child); // 0x000000018B343380-0x000000018B34341C
		internal void MoveLastTrackBefore(TrackAsset asset); // 0x000000018B344E40-0x000000018B344FFC
		internal bool RemoveSubTrack(TrackAsset child); // 0x000000018B345064-0x000000018B3450E0
		internal void RemoveClip(TimelineClip clip); // 0x000000018B344FFC-0x000000018B345064
		internal virtual void GetEvaluationTime(out double outStart, out double outDuration); // 0x00000001839F5F70-0x00000001839F6160
		internal virtual void GetSequenceTime(out double outStart, out double outDuration); // 0x0000000184864FB0-0x0000000184864FD0
		public virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver); // 0x000000018B3445BC-0x000000018B344938
		internal GameObject GetGameObjectBinding(PlayableDirector director); // 0x000000018B344B34-0x000000018B344C40
		internal bool ValidateClipType(System.Type clipType); // 0x000000018B345228-0x000000018B345430
		protected virtual void OnCreateClip(TimelineClip clip); // 0x00000001841E1670-0x00000001841E1680
		private void UpdateDuration(); // 0x00000001839F34C0-0x00000001839F35B0
		protected internal virtual int CalculateItemsHash(); // 0x0000000183AC2060-0x0000000183AC2110
		protected virtual Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip); // 0x0000000183E0DEC0-0x0000000183E0E2C0
		internal void Invalidate(); // 0x00000001839ED440-0x00000001839ED500
		internal double GetNotificationDuration(); // 0x000000018B344C60-0x000000018B344DB4
		internal virtual bool CanCompileClips(); // 0x000000018468DA80-0x000000018468DAA0
		public bool HasChildTracks(); // 0x000000018B344DB4-0x000000018B344DFC
		public virtual bool CanCreateTrackMixer(); // 0x0000000185394800-0x0000000185394810
		internal bool IsCompilable(); // 0x00000001839F4860-0x00000001839F4A90
		private void UpdateChildTrackCache(); // 0x00000001845D14E0-0x00000001845D15D0
		internal virtual int Hash(); // 0x000000018B344DFC-0x000000018B344E40
		private int GetClipsHash(); // 0x0000000183AC42F0-0x0000000183AC44E0
		protected static int GetAnimationClipHash(AnimationClip clip); // 0x0000000183AC2110-0x0000000183AC21A0
		private bool HasNotifications(); // 0x00000001839EC510-0x00000001839EC5B0
		private bool CanCompileNotifications(); // 0x00000001839EDE60-0x00000001839EDE90
		private bool CanCreateMixerRecursive(); // 0x0000000184A28E30-0x0000000184A28F80
		public Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount); // 0x000000018B34406C-0x000000018B3441AC
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ForbidScriptDefaultValueWhenExportAttribute : Attribute // TypeDefIndex: 59794
	{
		// Constructors
		public ForbidScriptDefaultValueWhenExportAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Conditional("UNITY_EDITOR")]
	internal class TimelineHelpURLAttribute : Attribute // TypeDefIndex: 59795
	{
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class TrackColorAttribute : Attribute // TypeDefIndex: 59796
	{
		// Fields
		private UnityEngine.Color m_Color; // 0x10
	
		// Constructors
		public TrackColorAttribute(float r, float g, float b); // 0x00000001847F9F60-0x00000001847F9FA0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class UseScriptDefaultValueWhenExportAttribute : Attribute // TypeDefIndex: 59797
	{
		// Constructors
		public UseScriptDefaultValueWhenExportAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	[UnityEngine.Timeline.NotKeyable]
	internal class AudioClipProperties : PlayableBehaviour // TypeDefIndex: 59798
	{
		// Fields
		[Range(0f, 1f)]
		public float volume; // 0x10
	
		// Constructors
		public AudioClipProperties(); // 0x0000000184D87330-0x0000000184D87340
	}

	[Serializable]
	internal class AudioMixerProperties : PlayableBehaviour // TypeDefIndex: 59799
	{
		// Fields
		[Range(0f, 1f)]
		public float volume; // 0x10
		[Range(-1f, 1f)]
		public float stereoPan; // 0x14
		[Range(0f, 1f)]
		public float spatialBlend; // 0x18
	
		// Constructors
		public AudioMixerProperties(); // 0x0000000184D87330-0x0000000184D87340
	
		// Methods
		public override void PrepareFrame(Playable playable, FrameData info); // 0x000000018B33D8E0-0x000000018B33DB70
	}

	[Serializable]
	public class AudioPlayableAsset : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 59801
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
		internal float bufferingTime { get; set; } // 0x0000000184D89850-0x0000000184D89860 0x0000000184D89860-0x0000000184D89870
		public AudioClip clip { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public bool loop { get; set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0
		public override double duration { get; } // 0x000000018B33DD04-0x000000018B33DDAC 
		public override IEnumerable<PlayableBinding> outputs { [IteratorStateMachine(typeof(_get_outputs_d__16))] get; } // 0x000000018B33DDAC-0x000000018B33DE1C 
		public ClipCaps clipCaps { get; } // 0x000000018B33DCF4-0x000000018B33DD04 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _get_outputs_d__16 : IEnumerable<PlayableBinding>, IEnumerator<PlayableBinding> // TypeDefIndex: 59800
		{
			// Fields
			private int __1__state; // 0x10
			private PlayableBinding __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			public AudioPlayableAsset __4__this; // 0x40
	
			// Properties
			PlayableBinding IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { [DebuggerHidden] get; } // 0x0000000182EC7B40-0x0000000182EC7B60 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018B345AC8-0x000000018B345B18 
	
			// Constructors
			[DebuggerHidden]
			public _get_outputs_d__16(int __1__state); // 0x0000000183A10F90-0x0000000183A10FB0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B345968-0x000000018B3459E8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B345A7C-0x000000018B345AC8
			[DebuggerHidden]
			IEnumerator<PlayableBinding> IEnumerable<PlayableBinding>.GetEnumerator(); // 0x000000018B3459E8-0x000000018B345A74
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B345A74-0x000000018B345A7C
		}
	
		// Constructors
		public AudioPlayableAsset(); // 0x000000018B33DC8C-0x000000018B33DCF4
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go); // 0x000000018B33DB70-0x000000018B33DC8C
	}

	[Serializable]
	[ExcludeFromPreset]
	[TrackBindingType(typeof(AudioSource))]
	[TrackClipType(typeof(AudioPlayableAsset), false)]
	public class AudioTrack : TrackAsset // TypeDefIndex: 59803
	{
		// Fields
		[SerializeField]
		private AudioMixerProperties m_TrackProperties; // 0xC0
	
		// Properties
		public override IEnumerable<PlayableBinding> outputs { [IteratorStateMachine(typeof(_get_outputs_d__4))] get; } // 0x000000018B33E550-0x000000018B33E5C0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _get_outputs_d__4 : IEnumerable<PlayableBinding>, IEnumerator<PlayableBinding> // TypeDefIndex: 59802
		{
			// Fields
			private int __1__state; // 0x10
			private PlayableBinding __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			public AudioTrack __4__this; // 0x40
	
			// Properties
			PlayableBinding IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { [DebuggerHidden] get; } // 0x0000000182EC7B40-0x0000000182EC7B60 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018B345C9C-0x000000018B345CEC 
	
			// Constructors
			[DebuggerHidden]
			public _get_outputs_d__4(int __1__state); // 0x0000000183A10F90-0x0000000183A10FB0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B345968-0x000000018B3459E8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B345C50-0x000000018B345C9C
			[DebuggerHidden]
			IEnumerator<PlayableBinding> IEnumerable<PlayableBinding>.GetEnumerator(); // 0x000000018B345BBC-0x000000018B345C48
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B345C48-0x000000018B345C50
		}
	
		// Constructors
		public AudioTrack(); // 0x000000018B33E4D0-0x000000018B33E550
	
		// Methods
		public TimelineClip CreateClip(AudioClip clip); // 0x000000018B33E350-0x000000018B33E464
		internal override Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree); // 0x000000018B33DE1C-0x000000018B33E350
		private void OnValidate(); // 0x000000018B33E464-0x000000018B33E4D0
	}

	[Serializable]
	public struct ACConditionDescriptor // TypeDefIndex: 59804
	{
		// Fields
		private int m_ConditionMode; // 0x00
		private string m_ConditionEvent; // 0x08
		private float m_EventTreshold; // 0x10
	}

	public class ACTransitionDescriptor // TypeDefIndex: 59805
	{
		// Constructors
		public ACTransitionDescriptor(); // 0x00000001841E1670-0x00000001841E1680
	}

	public enum DialogTimelineTrackType // TypeDefIndex: 59806
	{
		Default = 0,
		Morph = 1,
		Animation = 2,
		Offset = 3,
		LookAt = 4
	}

	public static class BeyondCommunicator // TypeDefIndex: 59807
	{
		// Fields
		public static bool setAddonLayerAdditive; // 0x00
		[CompilerGenerated]
		private static Action<Animator, AnimationLayerMixerPlayable, AnimationTrack, ScriptableObject, Transform, CommunicatorParam> _ConnectToJobSync_k__BackingField; // 0x08
		[CompilerGenerated]
		private static Func<ITimelineRootMarker, GameObject, string, bool, bool> _TrySetTrackBindingEntityVisible_k__BackingField; // 0x10
	
		// Properties
		public static Action<Animator, AnimationLayerMixerPlayable, AnimationTrack, ScriptableObject, Transform, CommunicatorParam> ConnectToJobSync { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018B33E5C0-0x000000018B33E610 0x000000018B33E660-0x000000018B33E6C0
		public static Func<ITimelineRootMarker, GameObject, string, bool, bool> TrySetTrackBindingEntityVisible { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018B33E610-0x000000018B33E660 0x000000018B33E6C0-0x000000018B33E720
	
		// Constructors
		static BeyondCommunicator(); // 0x0000000184D7AC90-0x0000000184D7ACD0
	}

	[Serializable]
	public class BlendMotionDescriptor // TypeDefIndex: 59808
	{
		// Fields
		public AnimationClip motion; // 0x10
		public string poseTimerParam; // 0x18
		public string blendParam; // 0x20
		public float threshold; // 0x28
	
		// Constructors
		public BlendMotionDescriptor(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class BlendTreeDescriptor // TypeDefIndex: 59810
	{
		// Fields
		public DescriptorBlendTreeType blendType; // 0x10
		public List<BlendMotionDescriptor> motionDescriptorList; // 0x18
		[CompilerGenerated]
		private string _speedParameter_k__BackingField; // 0x20
		[CompilerGenerated]
		private bool _speedParameterActive_k__BackingField; // 0x28
	
		// Nested types
		public enum DescriptorBlendTreeType // TypeDefIndex: 59809
		{
			Direct = 0,
			Simple1D = 1,
			Simple2D = 2,
			Complex2D = 3
		}
	
		// Constructors
		public BlendTreeDescriptor(); // 0x00000001841E1670-0x00000001841E1680
	}

	public interface ITimelineRootMarker // TypeDefIndex: 59811
	{
		// Properties
		PlayableDirector topDirector { get; }
		GameObject rootGo { get; }
		bool useEarlyUpdate { get; }
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
	public class LayerDescriptor : ScriptableObject // TypeDefIndex: 59812
	{
		// Fields
		public string layerName; // 0x18
		public AvatarMask avatarMask; // 0x20
		public bool isAdditive; // 0x28
		public List<StateDescriptor> stateDescriptors; // 0x30
	
		// Constructors
		public LayerDescriptor(); // 0x0000000183573370-0x0000000183573380
	}

	[Serializable]
	public class MotionDescriptor // TypeDefIndex: 59813
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
		public MotionDescriptor(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class StateDescriptor // TypeDefIndex: 59814
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
		public StateDescriptor(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Flags]
	public enum ClipCaps // TypeDefIndex: 59815
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

	internal static class TimelineClipCapsExtensions // TypeDefIndex: 59816
	{
		// Extension methods
		public static bool SupportsExtrapolation(this TimelineClip clip); // 0x0000000184B074C0-0x0000000184B074E0
		public static bool HasAny(this ClipCaps caps, ClipCaps flags); // 0x00000001839F6DA0-0x00000001839F6DB0
	}

	[Serializable]
	[UnityEngine.Timeline.NotKeyable]
	public class ControlPlayableAsset : BeyondUseAutoBindingPlayableAsset, IPropertyPreview, ITimelineClipAsset // TypeDefIndex: 59818
	{
		// Fields
		private const int k_MaxRandInt = 10000; // Metadata: 0x0234D1BC
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
		public override GameObject bindingGameObject { get; } // 0x0000000184A30BD0-0x0000000184A30C90 
		internal bool controllingDirectors { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8FEE0-0x0000000184D8FEF0 0x0000000184D8FEF0-0x0000000184D8FF00
		public bool controllingParticles { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184DA5E30-0x0000000184DA5E40 0x0000000184DA5E60-0x0000000184DA5E70
		public bool OnlyDeltaTime { get; set; } // 0x0000000184D86B40-0x0000000184D86B50 0x0000000184D86BA0-0x0000000184D86BB0
		public bool IgniteOnce { get; set; } // 0x0000000184D86B10-0x0000000184D86B20 0x0000000184D86B70-0x0000000184D86B80
		public override double duration { get; } // 0x0000000184D86E70-0x0000000184D86E80 
		public virtual ClipCaps clipCaps { get; } // 0x00000001839F6D70-0x00000001839F6DA0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetControlableScripts_d__53 : IEnumerable<MonoBehaviour>, IEnumerator<MonoBehaviour> // TypeDefIndex: 59817
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
			MonoBehaviour IEnumerator<UnityEngine.MonoBehaviour>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _GetControlableScripts_d__53(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018470FB40-0x000000018470FCB0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B3521C8-0x000000018B352214
			[DebuggerHidden]
			IEnumerator<MonoBehaviour> IEnumerable<MonoBehaviour>.GetEnumerator(); // 0x00000001849D6A30-0x00000001849D6AB0
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B3521C0-0x000000018B3521C8
		}
	
		// Constructors
		public ControlPlayableAsset(); // 0x00000001847D9DB0-0x00000001847D9E60
		static ControlPlayableAsset(); // 0x00000001849C5970-0x00000001849C5BA0
	
		// Methods
		public void OnEnable(); // 0x0000000184CEBB80-0x0000000184CEBBA0
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go); // 0x00000001839F0970-0x00000001839F2290
		private static Playable ConnectPlayablesToMixer(PlayableGraph graph, List<Playable> playables); // 0x0000000183E0E320-0x0000000183E0E520
		private void CreateActivationPlayable(GameObject root, PlayableGraph graph, List<Playable> outplayables); // 0x000000018450F390-0x000000018450F4F0
		protected virtual void SearchHierarchyAndConnectParticleSystem(IEnumerable<ParticleSystem> particleSystems, float clipIn, float speedMultiplier, PlayableGraph graph, List<Playable> outplayables); // 0x00000001847C3FF0-0x00000001847C4430
		private void SearchHierarchyAndConnectDirector(IEnumerable<PlayableDirector> directors, PlayableGraph graph, List<Playable> outplayables, bool disableSelfReferences); // 0x000000018450F680-0x000000018450FBA0
		private static void SearchHierarchyAndConnectControlableScripts(IEnumerable<MonoBehaviour> controlableScripts, PlayableGraph graph, List<Playable> outplayables); // 0x00000001847DABD0-0x00000001847DAF10
		private static void ConnectMixerAndPlayable(PlayableGraph graph, Playable mixer, Playable playable, int portIndex); // 0x0000000183E0E520-0x0000000183E0E630
		protected virtual GameObject ResolveSourceGameObject(IExposedPropertyTable resolver); // 0x0000000184892110-0x0000000184892200
		internal IList<T> GetComponent<T>(GameObject gameObject);
		internal IList<PlayableDirector> GetControllableDirectors(GameObject gameObject); // 0x00000001849722F0-0x0000000184972400
		[IteratorStateMachine(typeof(_GetControlableScripts_d__53))]
		internal static IEnumerable<MonoBehaviour> GetControlableScripts(GameObject root); // 0x00000001849B3AA0-0x00000001849B3B20
		internal void UpdateDurationAndLoopFlag(IList<PlayableDirector> directors, IList<ParticleSystem> particleSystems); // 0x00000001839EFB70-0x00000001839F07B0
		private IList<ParticleSystem> GetControllableParticleSystems(GameObject go); // 0x0000000184898B60-0x0000000184898DC0
		private static void GetControllableParticleSystems(Transform t, ICollection<ParticleSystem> roots, HashSet<ParticleSystem> subEmitters); // 0x000000018B33EAF8-0x000000018B33EC48
		private static void CacheSubEmitters(ParticleSystem ps, HashSet<ParticleSystem> subEmitters); // 0x000000018B33E794-0x000000018B33E86C
		public void GatherProperties(PlayableDirector director, IPropertyCollector driver); // 0x000000018B33E86C-0x000000018B33EAF8
		internal void PreviewParticlesWithControlPlayableAsset(IPropertyCollector driver, IEnumerable<ParticleSystem> particles); // 0x000000018B33EF6C-0x000000018B33EFC8
		internal static void PreviewParticles(IPropertyCollector driver, IEnumerable<ParticleSystem> particles); // 0x000000018B33EFC8-0x000000018B33F16C
		internal static void PreviewActivation(IPropertyCollector driver, IEnumerable<GameObject> objects); // 0x000000018B33EC48-0x000000018B33ED94
		internal static void PreviewTimeControl(IPropertyCollector driver, PlayableDirector director, IEnumerable<MonoBehaviour> scripts); // 0x000000018B33F16C-0x000000018B33F644
		internal static void PreviewDirectors(IPropertyCollector driver, IEnumerable<PlayableDirector> directors); // 0x000000018B33ED94-0x000000018B33EF6C
	}

	[ExcludeFromPreset]
	[SupportsChildTracks(null, 2147483647)]
	[TrackClipType(typeof(ControlPlayableAsset), false)]
	public class ControlTrack : TrackAsset // TypeDefIndex: 59819
	{
		// Constructors
		public ControlTrack(); // 0x00000001839F4B70-0x00000001839F4BC0
	}

	[ExecuteAlways]
	public class AdditiveAnimApplyMono : MonoBehaviour // TypeDefIndex: 59821
	{
		// Fields
		private Dictionary<Transform, TransformAdditive> pendingAdditives; // 0x18
		private bool hasnewPendingUpdates; // 0x20
		private ITimelineRootMarker _parentTimelineRoot; // 0x28
	
		// Nested types
		public class TransformAdditive // TypeDefIndex: 59820
		{
			// Fields
			public Vector3 position; // 0x10
			public Vector3 rotationEuler; // 0x1C
			public Vector3 scale; // 0x28
	
			// Constructors
			public TransformAdditive(); // 0x000000018B3521B8-0x000000018B3521C0
	
			// Methods
			public void Reset(); // 0x000000018B352158-0x000000018B3521B8
		}
	
		// Constructors
		public AdditiveAnimApplyMono(); // 0x000000018B346F08-0x000000018B346F88
	
		// Methods
		private void Awake(); // 0x000000018B346AF0-0x000000018B346B68
		public void RecordAdditiveTransform(Transform bone, Vector3 position, Vector3 rotationEuler, Vector3 scale); // 0x000000018B346D2C-0x000000018B346E88
		private void LateUpdate(); // 0x000000018B346CBC-0x000000018B346CE8
		public void ApplyPendingTransforms(); // 0x000000018B34672C-0x000000018B346AF0
		public void ClearPendingTransforms(); // 0x000000018B346B68-0x000000018B346CBC
		private void NotifyCutsceneRootToUpdateVFXTools(); // 0x000000018B346CE8-0x000000018B346D2C
		public void RegisterRootComponent(); // 0x000000018B346E88-0x000000018B346F08
	}

	public class AdditiveAnimMixer : PlayableBehaviour // TypeDefIndex: 59823
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
		private class TransformAdditive // TypeDefIndex: 59822
		{
			// Fields
			public Vector3 position; // 0x10
			public Vector3 rotationEular; // 0x1C
			public Vector3 scale; // 0x28
	
			// Constructors
			public TransformAdditive(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Reset(); // 0x000000018B352158-0x000000018B3521B8
		}
	
		// Constructors
		public AdditiveAnimMixer(); // 0x000000018B347D48-0x000000018B347E54
	
		// Methods
		public override void PrepareFrame(Playable playable, FrameData info); // 0x0000000184D90CE0-0x0000000184D90CF0
		public override void ProcessFrame(Playable playable, FrameData info, object playerData); // 0x000000018B346F88-0x000000018B347338
		private void _AddToAdditiveCache(AdditiveAnimPlayable additiveAnimPlayable, float clipTime, float weight); // 0x000000018B347338-0x000000018B347A88
		private void _ApplyAdditive(); // 0x000000018B347A88-0x000000018B347D48
	}

	public class AdditiveAnimPlayable : PlayableBehaviour // TypeDefIndex: 59824
	{
		// Fields
		public List<AdditiveAnimPlayableAsset.AnimationCurveInfo> extractedCurves; // 0x10
		private Dictionary<string, List<AdditiveAnimPlayableAsset.AnimationCurveInfo>> _curveCache; // 0x18
	
		// Constructors
		public AdditiveAnimPlayable(); // 0x000000018B3483D0-0x000000018B348448
	
		// Methods
		public override void OnPlayableCreate(Playable playable); // 0x000000018B348358-0x000000018B3483D0
		public void InitializeCurveCache(); // 0x000000018B3480C8-0x000000018B348358
	}

	[Serializable]
	public class AdditiveAnimPlayableAsset : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 59826
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
		public bool OnlyDeltaTime { get; set; } // 0x00000001811F2A70-0x00000001811F2A80 0x00000001811F2A80-0x00000001811F2A90
		public bool IgniteOnce { get; set; } // 0x0000000184D86650-0x0000000184D86660 0x0000000184D86680-0x0000000184D86690
		public ClipCaps clipCaps { get; } // 0x000000018B3480A4-0x000000018B3480C8 
	
		// Nested types
		[Serializable]
		public class AnimationCurveInfo // TypeDefIndex: 59825
		{
			// Fields
			public string path; // 0x10
			public string propertyName; // 0x18
			public AnimationCurve curve; // 0x20
	
			// Constructors
			public AnimationCurveInfo(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public AdditiveAnimPlayableAsset(); // 0x000000018B348024-0x000000018B3480A4
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018B347E54-0x000000018B347F80
		private void _InitializeBehaviourCurveCache(); // 0x000000018B347F80-0x000000018B348024
	}

	[System.ComponentModel.DisplayName("Beyond/AdditiveAnimationTrack")]
	[TrackBindingType(typeof(GameObject))]
	[TrackClipType(typeof(AdditiveAnimPlayableAsset))]
	public class AdditiveAnimTrack : TrackAsset // TypeDefIndex: 59827
	{
		// Fields
		private const string k_DefaultRecordableClipName = "Recorded Additive"; // Metadata: 0x0234D1C0
		[HideInInspector]
		[SerializeField]
		private bool m_InfiniteClip; // 0xC0
		[HideInInspector]
		[SerializeField]
		private AnimationClip m_RecordableClip; // 0xC8
	
		// Constructors
		public AdditiveAnimTrack(); // 0x000000018B348744-0x000000018B348790
	
		// Methods
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount); // 0x000000018B348470-0x000000018B34856C
		public override void GatherProperties(PlayableDirector director, IPropertyCollector driver); // 0x000000018B34856C-0x000000018B348744
		public TimelineClip CreateRecordableClip(string animClipName); // 0x000000018B348448-0x000000018B348470
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class CombineToTopPlayableAttribute : Attribute // TypeDefIndex: 59828
	{
		// Constructors
		public CombineToTopPlayableAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class CustomControlPlayableAsset : PlayableAsset, ITimelineClipAsset, ICustomControlBehaviour // TypeDefIndex: 59829
	{
		// Fields
		protected CustomControlPlayableBehaviour m_CustomControlBehaviour; // 0x18
	
		// Properties
		public ClipCaps clipCaps { get; } // 0x000000018B348E50-0x000000018B348E6C 
		protected virtual ClipCaps extraClipCaps { get; } // 0x00000001811EC580-0x00000001811EC590 
	
		// Constructors
		public CustomControlPlayableAsset(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018B348D48-0x000000018B348D98
		public virtual void OnClipEnable(Playable playable, FrameData info); // 0x000000018B348DF4-0x000000018B348E50
		public virtual void OnClipDisable(Playable playable, FrameData info); // 0x000000018B348D98-0x000000018B348DF4
	}

	public class CustomControlPlayableBehaviour : PlayableBehaviour, ICustomControlBehaviour // TypeDefIndex: 59830
	{
		// Constructors
		public CustomControlPlayableBehaviour(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public virtual void OnClipEnable(Playable playable, FrameData info); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnClipDisable(Playable playable, FrameData info); // 0x00000001841E1670-0x00000001841E1680
	}

	public interface ICustomControlBehaviour // TypeDefIndex: 59831
	{
		// Methods
		void OnClipEnable(Playable playable, FrameData info);
		void OnClipDisable(Playable playable, FrameData info);
	}

	public interface IDynamicBinding // TypeDefIndex: 59832
	{
	}

	public interface ITimelineAnimationEventContextBinding // TypeDefIndex: 59833
	{
		// Methods
		void RegisterAnimationEventRuntimeContext(int playableId, AnimationEvent[] animationEvents, AnimationPlayableAsset.AnimationEventTriggerMode postAudioEventTriggerMode, float postAudioEventTriggerThreshold, AnimationPlayableAsset.AnimationEventTriggerMode customFootStepTriggerMode, float customFootStepTriggerThreshold, float curClipTime, float curWeight, AnimationPlayableAsset.ClipEndAudioBehaviour clipEndAudioBehaviour = AnimationPlayableAsset.ClipEndAudioBehaviour.Default /* Metadata: 0x0234D1D2 */);
		void UnregisterAnimationEventRuntimeContext(int playableId, AnimationEvent[] animationEvents);
		void UpdateClipInfo(int playableId, float curClipTime, float curClipWeight);
		void StopAllAudioForPlayable(int playableId, int fadeOutTimeMs = 100 /* Metadata: 0x0234D1D3 */);
	}

	public class SegmentLoopPlayableBehaviour : PlayableBehaviour // TypeDefIndex: 59834
	{
		// Constructors
		public SegmentLoopPlayableBehaviour(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class SegmentLoopPlayableClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 59835
	{
		// Fields
		public string loopSegmentKey; // 0x18
	
		// Properties
		public ClipCaps clipCaps { get; } // 0x0000000184DB8E50-0x0000000184DB8E60 
	
		// Constructors
		public SegmentLoopPlayableClip(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018B34BF90-0x000000018B34C03C
	}

	[CombineToTopPlayable]
	[System.ComponentModel.DisplayName("Beyond/SegmentLoopTrack")]
	[TrackClipType(typeof(SegmentLoopPlayableClip))]
	public class SegmentLoopTrack : TrackAsset // TypeDefIndex: 59836
	{
		// Constructors
		public SegmentLoopTrack(); // 0x000000018B34C03C-0x000000018B34C088
	}

	internal struct DiscreteTime : IComparable // TypeDefIndex: 59837
	{
		// Fields
		private const double k_Tick = 1E-12; // Metadata: 0x0234D1D5
		public static readonly DiscreteTime kMaxTime; // 0x00
		private readonly long m_DiscreteTime; // 0x00
	
		// Properties
		public static double tickValue { get; } // 0x0000000184DBA600-0x0000000184DBA610 
	
		// Constructors
		private DiscreteTime(long time); // 0x0000000184D88B60-0x0000000184D88B70
		public DiscreteTime(double time); // 0x00000001839F3020-0x00000001839F3080
		public DiscreteTime(int time); // 0x00000001839F30E0-0x00000001839F3140
		static DiscreteTime(); // 0x0000000184D75940-0x0000000184D75980
	
		// Methods
		public DiscreteTime OneTickBefore(); // 0x0000000184DBA5D0-0x0000000184DBA5E0
		public DiscreteTime OneTickAfter(); // 0x0000000184DBA5C0-0x0000000184DBA5D0
		public static DiscreteTime FromTicks(long ticks); // 0x000000018464E630-0x000000018464E640
		public int CompareTo(object obj); // 0x000000018B348FC0-0x000000018B349028
		public bool Equals(DiscreteTime other); // 0x0000000182EECF30-0x0000000182EECF40
		public override bool Equals(object obj); // 0x000000018B349028-0x000000018B349094
		private static long DoubleToDiscreteTime(double time); // 0x00000001839F31A0-0x00000001839F3210
		private static long IntToDiscreteTime(int time); // 0x00000001839F3140-0x00000001839F31A0
		private static double ToDouble(long time); // 0x0000000184DBA5E0-0x0000000184DBA600
		public static explicit operator double(DiscreteTime b); // 0x00000001839F3080-0x00000001839F30E0
		public static explicit operator DiscreteTime(double time); // 0x00000001839F2FF0-0x00000001839F3020
		public static implicit operator DiscreteTime(int time); // 0x00000001839F2FC0-0x00000001839F2FF0
		public static bool operator ==(DiscreteTime lhs, DiscreteTime rhs); // 0x0000000182FB1840-0x0000000182FB1850
		public static bool operator !=(DiscreteTime lhs, DiscreteTime rhs); // 0x000000018B34909C-0x000000018B3490E8
		public static bool operator <=(DiscreteTime lhs, DiscreteTime rhs); // 0x00000001839F3720-0x00000001839F3730
		public static bool operator >=(DiscreteTime lhs, DiscreteTime rhs); // 0x0000000182FCE050-0x0000000182FCE060
		public static DiscreteTime operator -(DiscreteTime lhs, DiscreteTime rhs); // 0x0000000184DBA610-0x0000000184DBA620
		public override string ToString(); // 0x000000018B349094-0x000000018B34909C
		public override int GetHashCode(); // 0x0000000184DA4FD0-0x0000000184DA4FE0
		public static DiscreteTime Max(DiscreteTime lhs, DiscreteTime rhs); // 0x00000001839F3210-0x00000001839F3270
		public static long GetNearestTick(double time); // 0x00000001839F2A00-0x00000001839F2A60
	}

	internal class InfiniteRuntimeClip : RuntimeElement // TypeDefIndex: 59838
	{
		// Fields
		private Playable m_Playable; // 0x18
		private static readonly long kIntervalEnd; // 0x00
		[CompilerGenerated]
		private int _optionIndex_k__BackingField; // 0x28
	
		// Properties
		public override long intervalStart { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override long intervalEnd { get; } // 0x000000018B349590-0x000000018B3495E0 
		public override int optionIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
		public override bool enable { set; } // 0x000000018B3495E0-0x000000018B349644
	
		// Constructors
		public InfiniteRuntimeClip(Playable playable); // 0x0000000184D890D0-0x0000000184D890E0
		static InfiniteRuntimeClip(); // 0x000000018B349500-0x000000018B349590
	
		// Methods
		public override void EvaluateAt(double localTime, FrameData frameData, ITimelineRootMarker timelineRoot = null); // 0x000000018B3494A8-0x000000018B349500
		public override void DisableAt(double localTime, double rootDuration, FrameData frameData); // 0x000000018B349448-0x000000018B3494A8
	}

	internal interface IInterval // TypeDefIndex: 59839
	{
		// Properties
		long intervalStart { get; }
		long intervalEnd { get; }
	}

	internal interface IRuntimeReset // TypeDefIndex: 59840
	{
		// Methods
		void RuntimeReset();
	}

	internal interface IOption // TypeDefIndex: 59841
	{
	}

	internal struct IntervalTreeNode // TypeDefIndex: 59842
	{
		// Fields
		public long center; // 0x00
		public int first; // 0x08
		public int last; // 0x0C
		public int left; // 0x10
		public int right; // 0x14
	}

	internal class IntervalTree<T> // TypeDefIndex: 59844
		where T : IInterval, IRuntimeReset
	{
		// Fields
		private const int kMinNodeSize = 10; // Metadata: 0x0234D1DD
		private const int kInvalidNode = -1; // Metadata: 0x0234D1DE
		private const long kCenterUnknown = 9223372036854775807; // Metadata: 0x0234D1DF
		private readonly List<Entry> m_Entries;
		private readonly List<IntervalTreeNode> m_Nodes;
		[CompilerGenerated]
		private bool _dirty_k__BackingField;
	
		// Properties
		public bool dirty { [CompilerGenerated] get; [CompilerGenerated] internal set; }
	
		// Nested types
		internal struct Entry // TypeDefIndex: 59843
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

	public class RuntimeClip : RuntimeClipBase // TypeDefIndex: 59845
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
		[CompilerGenerated]
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
		public override int optionIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86560-0x0000000184D86570 0x0000000184D865C0-0x0000000184D865D0
		public bool dynamicLink { get; } // 0x0000000184B09EB0-0x0000000184B09EE0 
		public bool customBehaviourControl { get; } // 0x0000000184B09EE0-0x0000000184B09F10 
		public override double start { get; } // 0x0000000184891CA0-0x0000000184891CD0 
		public override double end { get; } // 0x000000018B34B9B0-0x000000018B34BA08 
		public override double duration { get; } // 0x00000001839F7540-0x00000001839F7570 
		public TimelineClip clip { get; } // 0x0000000184D86230-0x0000000184D86240 
		public Playable mixer { get; } // 0x0000000184D90620-0x0000000184D90630 
		public Playable playable { get; } // 0x0000000184D8FD40-0x0000000184D8FD50 
		public override long intervalStart { get; } // 0x00000001845C5CC0-0x00000001845C5D30 
		public override long intervalEnd { get; } // 0x00000001845C5D30-0x00000001845C5DC0 
		public override bool enable { set; } // 0x00000001839F5E10-0x00000001839F5F70
		public bool isEnabling { get; } // 0x0000000184D88020-0x0000000184D88030 
	
		// Constructors
		public RuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer, int originalPort); // 0x0000000183E0E630-0x0000000183E0E690
	
		// Methods
		private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer, int originalPort); // 0x0000000183E0E690-0x0000000183E0E7D0
		public void SetTime(double time); // 0x00000001839F7020-0x00000001839F7080
		public void SetDuration(double duration); // 0x0000000183E0E2C0-0x0000000183E0E320
		public override void EvaluateAt(double localTime, FrameData frameData, ITimelineRootMarker timelineRoot = null); // 0x00000001839F7080-0x00000001839F72E0
		public float EvaluateMixIn(float localTime); // 0x00000001839F7660-0x00000001839F76E0
		public float EvaluateMixOut(float localTime); // 0x00000001839F7570-0x00000001839F75E0
		public double ToLocalTime(double localTime, FrameData frameData, ITimelineRootMarker timelineRoot); // 0x00000001839F72E0-0x00000001839F73A0
		private double ApplyTimeRemapCurve(double localTime, double clipTime); // 0x00000001839F73A0-0x00000001839F7450
		public override void DisableAt(double localTime, double rootDuration, FrameData frameData); // 0x000000018B34B508-0x000000018B34B6A8
		public override bool CheckIfRuntimeTimeLoop(out bool canSkip, out double reverseTime); // 0x000000018489D700-0x000000018489D750
		public override bool CheckIfRuntimeTimeJump(out double jumpTime, out bool isReverseJump); // 0x000000018B34B3DC-0x000000018B34B508
		public override void RuntimeLoopOver(); // 0x000000018B34B8B8-0x000000018B34B8E8
		public override void RuntimeLoopOn(); // 0x000000018B34B888-0x000000018B34B8B8
		public override void GetRuntimeCrossFadeDuration(out double duration, out double jumpTargetTime); // 0x000000018B34B6A8-0x000000018B34B7CC
		public override void RecalculateRuntimeCrossFadeMixIn(double mixInTime, double mixInDuration); // 0x000000018B34B7CC-0x000000018B34B81C
		public override void RecalculateRuntimeCrossFadeMixOut(double curTime, double mixStartTime, double mixDuration); // 0x000000018B34B81C-0x000000018B34B888
		public bool TryGetJumpClip(out RuntimeJumpClip jumpClip); // 0x000000018B34B8E8-0x000000018B34B9B0
		public override void RuntimeReset(); // 0x00000001839F66D0-0x00000001839F6A20
	}

	public abstract class RuntimeClipBase : RuntimeElement // TypeDefIndex: 59846
	{
		// Fields
		[CompilerGenerated]
		private int _optionIndex_k__BackingField; // 0x18
	
		// Properties
		public abstract double start { get; }
		public abstract double duration { get; }
		public abstract double end { get; }
		public override int optionIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public override long intervalStart { get; } // 0x000000018B34B380-0x000000018B34B3DC 
		public override long intervalEnd { get; } // 0x000000018B34B308-0x000000018B34B380 
	
		// Constructors
		protected RuntimeClipBase(); // 0x00000001841E1670-0x00000001841E1680
	}

	public abstract class RuntimeElement : IInterval, IOption, IRuntimeReset // TypeDefIndex: 59847
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
		public int intervalBit { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
		public bool isLooping { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8EE50-0x0000000184D8EE60 0x0000000184D8EE70-0x0000000184D8EE80
		public abstract bool enable { set; }
	
		// Constructors
		protected RuntimeElement(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public abstract void EvaluateAt(double localTime, FrameData frameData, ITimelineRootMarker timelineRoot = null);
		public abstract void DisableAt(double localTime, double rootDuration, FrameData frameData);
		public virtual bool CheckIfRuntimeTimeLoop(out bool canSkip, out double reverseTime); // 0x0000000184DBA6E0-0x0000000184DBA6F0
		public virtual bool CheckIfRuntimeTimeJump(out double jumpTime, out bool isReverseJump); // 0x0000000184DBA6D0-0x0000000184DBA6E0
		public virtual void RuntimeLoopOver(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void RuntimeLoopOn(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void GetRuntimeCrossFadeDuration(out double duration, out double jumpTargetTime); // 0x0000000184DBA6F0-0x0000000184DBA700
		public virtual void RecalculateRuntimeCrossFadeMixIn(double mixInTime, double mixDuration); // 0x00000001841E1670-0x00000001841E1680
		public virtual void RecalculateRuntimeCrossFadeMixOut(double curTime, double mixStartTime, double mixDuration); // 0x00000001841E1670-0x00000001841E1680
		public virtual void RuntimeReset(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal class ScheduleRuntimeClip : RuntimeClipBase // TypeDefIndex: 59848
	{
		// Fields
		private TimelineClip m_Clip; // 0x20
		private Playable m_Playable; // 0x28
		private Playable m_ParentMixer; // 0x38
		private double m_StartDelay; // 0x48
		private double m_FinishTail; // 0x50
		private bool m_Started; // 0x58
	
		// Properties
		public override double start { get; } // 0x000000018B34BE20-0x000000018B34BE98 
		public override double duration { get; } // 0x000000018B34BD9C-0x000000018B34BDE4 
		public override double end { get; } // 0x000000018B34BDE4-0x000000018B34BE20 
		public TimelineClip clip { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public Playable mixer { get; } // 0x0000000184D8FD20-0x0000000184D8FD30 
		public Playable playable { get; } // 0x0000000184D8FAD0-0x0000000184D8FAE0 
		public override bool enable { set; } // 0x000000018B34BE98-0x000000018B34BF90
	
		// Constructors
		public ScheduleRuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay = 0.2 /* Metadata: 0x0234D1E7 */, double finishTail = 0.1 /* Metadata: 0x0234D1EF */); // 0x000000018B34BD4C-0x000000018B34BD9C
	
		// Methods
		private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay, double finishTail); // 0x000000018B34BA08-0x000000018B34BAA0
		public override void EvaluateAt(double localTime, FrameData frameData, ITimelineRootMarker timelineRoot = null); // 0x000000018B34BAA0-0x000000018B34BD4C
		public override void DisableAt(double localTime, double rootDuration, FrameData frameData); // 0x00000001869734E8-0x00000001869734F8
	}

	public interface IMarker // TypeDefIndex: 59849
	{
		// Properties
		double time { get; set; }
		TrackAsset parent { get; }
	
		// Methods
		void Initialize(TrackAsset parent);
	}

	public interface INotificationOptionProvider // TypeDefIndex: 59850
	{
		// Properties
		NotificationFlags flags { get; }
	}

	public abstract class Marker : ScriptableObject, IMarker // TypeDefIndex: 59851
	{
		// Fields
		[SerializeField]
		[TimeField(TimeFieldAttribute.UseEditMode.ApplyEditMode)]
		[Tooltip("Time for the marker")]
		private double m_Time; // 0x18
		[CompilerGenerated]
		private TrackAsset _parent_k__BackingField; // 0x20
	
		// Properties
		public TrackAsset parent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public double time { get; set; } // 0x0000000184D86360-0x0000000184D86370 0x000000018B349E4C-0x000000018B349EA4
	
		// Constructors
		protected Marker(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		void IMarker.Initialize(TrackAsset parentTrack); // 0x000000018B349D2C-0x000000018B349E4C
		public virtual void OnInitialize(TrackAsset aPent); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	internal struct MarkerList : ISerializationCallbackReceiver // TypeDefIndex: 59852
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
		public List<IMarker> markers { get; } // 0x0000000185394794-0x00000001853947B0 
		public int Count { get; } // 0x0000000183AC4070-0x0000000183AC40C0 
		public IMarker this[int idx] { get => default; } // 0x000000018B349B28-0x000000018B349B84 
	
		// Constructors
		public MarkerList(int capacity); // 0x00000001839F3AA0-0x00000001839F3B80
	
		// Methods
		public void Add(ScriptableObject item); // 0x000000018B349644-0x000000018B3496C8
		public bool Remove(IMarker item); // 0x000000018B349974-0x000000018B349A78
		public bool Remove(ScriptableObject item, TimelineAsset timelineAsset, PlayableAsset thingToDirty); // 0x000000018B349A78-0x000000018B349B28
		public void Clear(); // 0x000000018B3496C8-0x000000018B349714
		public IEnumerable<IMarker> GetMarkers(); // 0x0000000185394794-0x00000001853947B0
		public List<ScriptableObject> GetRawMarkerList(); // 0x0000000182B76770-0x0000000182B76780
		public IMarker CreateMarker(System.Type type, double time, TrackAsset owner); // 0x000000018B349714-0x000000018B349974
		public bool HasNotifications(); // 0x0000000185394778-0x0000000185394794
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x00000001841E1670-0x00000001841E1680
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001815EFCD0-0x00000001815EFCE0
		private void BuildCache(); // 0x00000001839F3B80-0x00000001839F3DE0
	}

	[Serializable]
	[ExcludeFromPreset]
	[HideInMenu]
	[TrackBindingType(typeof(GameObject))]
	public class MarkerTrack : TrackAsset, INotificationTrack // TypeDefIndex: 59853
	{
		// Properties
		public override IEnumerable<PlayableBinding> outputs { get; } // 0x000000018B349BD0-0x000000018B349D2C 
	
		// Constructors
		public MarkerTrack(); // 0x000000018B349B84-0x000000018B349BD0
	}

	internal class CustomSignalEventDrawer : PropertyAttribute // TypeDefIndex: 59854
	{
		// Constructors
		public CustomSignalEventDrawer(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AssetFileNameExtension("signal", new string[0])]
	public class SignalAsset : ScriptableObject // TypeDefIndex: 59855
	{
		// Fields
		[CompilerGenerated]
		private static Action<SignalAsset> OnEnableCallback; // 0x00
	
		// Events
		internal static event Action<SignalAsset> OnEnableCallback {
			add; // 0x000000018B34C0D8-0x000000018B34C174
			remove; // 0x000000018B34C174-0x000000018B34C210
		}
	
		// Constructors
		public SignalAsset(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		private void OnEnable(); // 0x000000018B34C088-0x000000018B34C0D8
	}

	[Serializable]
	[CustomStyle("SignalEmitter")]
	[ExcludeFromPreset]
	public class SignalEmitter : Marker, INotification, INotificationOptionProvider // TypeDefIndex: 59856
	{
		// Fields
		[SerializeField]
		private bool m_Retroactive; // 0x28
		[SerializeField]
		private bool m_EmitOnce; // 0x29
		[SerializeField]
		private SignalAsset m_Asset; // 0x30
	
		// Properties
		public bool retroactive { get; set; } // 0x00000001811F33C0-0x00000001811F33D0 0x00000001811F33D0-0x00000001811F33E0
		public bool emitOnce { get; set; } // 0x0000000184D867B0-0x0000000184D867C0 0x0000000184D867C0-0x0000000184D867D0
		public SignalAsset asset { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		PropertyName INotification.id { get; } // 0x000000018B34C210-0x000000018B34C2B4 
		NotificationFlags INotificationOptionProvider.flags { get; } // 0x000000018B34C2B4-0x000000018B34C2DC 
	
		// Constructors
		public SignalEmitter(); // 0x0000000183573370-0x0000000183573380
	}

	public class SignalReceiver : MonoBehaviour, INotificationReceiver // TypeDefIndex: 59858
	{
		// Fields
		[SerializeField]
		private EventKeyValue m_Events; // 0x18
	
		// Nested types
		[Serializable]
		private class EventKeyValue // TypeDefIndex: 59857
		{
			// Fields
			[SerializeField]
			private List<SignalAsset> m_Signals; // 0x10
			[CustomSignalEventDrawer]
			[SerializeField]
			private List<UnityEvent> m_Events; // 0x18
	
			// Properties
			public List<SignalAsset> signals { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
			public List<UnityEvent> events { get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			public EventKeyValue(); // 0x000000018B349338-0x000000018B3493F8
	
			// Methods
			public bool TryGetValue(SignalAsset key, out UnityEvent value); // 0x000000018B349290-0x000000018B349338
			public void Append(SignalAsset key, UnityEvent value); // 0x000000018B3490E8-0x000000018B349170
			public void Remove(int idx); // 0x000000018B349214-0x000000018B349290
			public void Remove(SignalAsset key); // 0x000000018B349170-0x000000018B349214
		}
	
		// Constructors
		public SignalReceiver(); // 0x000000018B34CC20-0x000000018B34CC90
	
		// Methods
		public void OnNotify(Playable origin, INotification notification, object context); // 0x000000018B34C9D0-0x000000018B34CAB0
		public void AddReaction(SignalAsset asset, UnityEvent reaction); // 0x000000018B34C348-0x000000018B34C4A4
		public int AddEmptyReaction(UnityEvent reaction); // 0x000000018B34C2DC-0x000000018B34C348
		public void Remove(SignalAsset asset); // 0x000000018B34CB58-0x000000018B34CC20
		public IEnumerable<SignalAsset> GetRegisteredSignals(); // 0x000000018A8DA4D0-0x000000018A8DA4EC
		public UnityEvent GetReaction(SignalAsset key); // 0x000000018B34C8DC-0x000000018B34C914
		public int Count(); // 0x000000018B34C7D8-0x000000018B34C820
		public void ChangeSignalAtIndex(int idx, SignalAsset newKey); // 0x000000018B34C570-0x000000018B34C7D8
		public void RemoveAtIndex(int idx); // 0x000000018B34CAB0-0x000000018B34CB58
		public void ChangeReactionAtIndex(int idx, UnityEvent reaction); // 0x000000018B34C4A4-0x000000018B34C570
		public UnityEvent GetReactionAtIndex(int idx); // 0x000000018B34C820-0x000000018B34C8DC
		public SignalAsset GetSignalAssetAtIndex(int idx); // 0x000000018B34C914-0x000000018B34C9D0
		private void OnEnable(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	[ExcludeFromPreset]
	[TrackBindingType(typeof(SignalReceiver))]
	[TrackColor(0.25f, 0.25f, 0.25f)]
	public class SignalTrack : MarkerTrack // TypeDefIndex: 59859
	{
		// Constructors
		public SignalTrack(); // 0x000000018B34CC90-0x000000018B34CC98
	}

	public static class TrackAssetExtensions // TypeDefIndex: 59860
	{
	}

	[Serializable]
	[ExcludeFromPreset]
	[SupportsChildTracks(null, 2147483647)]
	[TrackClipType(typeof(TrackAsset))]
	public class GroupTrack : TrackAsset // TypeDefIndex: 59861
	{
		// Fields
		public TimelineConditionBase enableOnCondition; // 0xC0
	
		// Properties
		public override IEnumerable<PlayableBinding> outputs { get; } // 0x000000018B3493F8-0x000000018B349448 
	
		// Constructors
		public GroupTrack(); // 0x0000000184D5DEB0-0x0000000184D5DF00
	
		// Methods
		public void CalculateRuntimeMuted(); // 0x0000000184D35910-0x0000000184D359B0
		internal override bool CanCompileClips(); // 0x00000001812081B0-0x0000000181208610
	}

	public interface ILayerable // TypeDefIndex: 59862
	{
		// Methods
		Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount);
	}

	public interface ITimeDilationListener // TypeDefIndex: 59863
	{
		// Methods
		void OnTimeDilationChanged(float timeDilation);
	}

	public class ActivationControlPlayable : ControlPlayableBehaviour // TypeDefIndex: 59866
	{
		// Fields
		public GameObject gameObject; // 0x10
		public PostPlaybackState postPlayback; // 0x18
		private InitialState m_InitialState; // 0x1C
	
		// Nested types
		public enum PostPlaybackState // TypeDefIndex: 59864
		{
			Active = 0,
			Inactive = 1,
			Revert = 2
		}
	
		private enum InitialState // TypeDefIndex: 59865
		{
			Unset = 0,
			Active = 1,
			Inactive = 2
		}
	
		// Constructors
		public ActivationControlPlayable(); // 0x0000000184D8D750-0x0000000184D8D760
	
		// Methods
		public static ScriptPlayable<ActivationControlPlayable> Create(PlayableGraph graph, GameObject gameObject, PostPlaybackState postPlaybackState); // 0x000000018450F4F0-0x000000018450F680
		public override void OnBehaviourPlay(Playable playable, FrameData info); // 0x0000000184A052D0-0x0000000184A05380
		public override void OnBehaviourPause(Playable playable, FrameData info); // 0x000000018B3465FC-0x000000018B346688
		public override void ProcessFrame(Playable playable, FrameData info, object userData); // 0x0000000184A05220-0x0000000184A052D0
		public override void OnGraphStart(Playable playable); // 0x0000000184972880-0x0000000184972940
		public override void OnPlayableDestroy(Playable playable); // 0x000000018B346688-0x000000018B34672C
		public override void RuntimeReset(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class AnimationEventRuntimeContextPlayable : PlayableBehaviour // TypeDefIndex: 59867
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
		public AnimationEventRuntimeContextPlayable(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static ScriptPlayable<AnimationEventRuntimeContextPlayable> Create(PlayableGraph graph, ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding, AnimationPlayableAsset.AnimationEventTriggerMode postAudioEventTriggerMode, float postAudioEventTriggerThreshold, AnimationPlayableAsset.AnimationEventTriggerMode customFootStepTriggerMode, float customFootStepTriggerThreshold, AnimationEvent[] cachedAnimationEvents, float clipDuration = 0f /* Metadata: 0x0234D1FD */, AnimationPlayableAsset.ClipEndAudioBehaviour clipEndAudioBehaviour = AnimationPlayableAsset.ClipEndAudioBehaviour.Default /* Metadata: 0x0234D201 */, int inputCount = 1 /* Metadata: 0x0234D202 */); // 0x000000018B348790-0x000000018B348908
		public void Initialize(ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding, AnimationPlayableAsset.AnimationEventTriggerMode postAudioEventTriggerMode, float postAudioEventTriggerThreshold, AnimationPlayableAsset.AnimationEventTriggerMode customFootStepTriggerMode, float customFootStepTriggerThreshold, AnimationEvent[] cachedAnimationEvents, float clipDuration, AnimationPlayableAsset.ClipEndAudioBehaviour clipEndAudioBehaviour = AnimationPlayableAsset.ClipEndAudioBehaviour.Default /* Metadata: 0x0234D203 */); // 0x000000018B348908-0x000000018B348970
		public void ResetRegistration(Playable playable); // 0x000000018B348B18-0x000000018B348BE8
		public override void PrepareFrame(Playable playable, FrameData info); // 0x000000018B348970-0x000000018B348B18
	}

	[Serializable]
	[Obsolete("For best performance use PlayableAsset and PlayableBehaviour.")]
	public class BasicPlayableBehaviour : ScriptableObject, IPlayableAsset, IPlayableBehaviour // TypeDefIndex: 59868
	{
		// Properties
		public virtual double duration { get; } // 0x000000018B348CA8-0x000000018B348CF8 
		public virtual IEnumerable<PlayableBinding> outputs { get; } // 0x000000018B348CF8-0x000000018B348D48 
	
		// Constructors
		public BasicPlayableBehaviour(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		public virtual void OnGraphStart(Playable playable); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnGraphStop(Playable playable); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnPlayableCreate(Playable playable); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnPlayableDestroy(Playable playable); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnBehaviourPlay(Playable playable, FrameData info); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnBehaviourPause(Playable playable, FrameData info); // 0x00000001841E1670-0x00000001841E1680
		public virtual void PrepareFrame(Playable playable, FrameData info); // 0x00000001841E1670-0x00000001841E1680
		public virtual void ProcessFrame(Playable playable, FrameData info, object playerData); // 0x00000001841E1670-0x00000001841E1680
		public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018B348BE8-0x000000018B348CA8
	}

	public class ControlPlayableBehaviour : PlayableBehaviour, IBehaviourRuntimeReset // TypeDefIndex: 59869
	{
		// Constructors
		public ControlPlayableBehaviour(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public virtual void RuntimeReset(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class DirectorControlPlayable : ControlPlayableBehaviour // TypeDefIndex: 59870
	{
		// Fields
		public PlayableDirector director; // 0x10
		public ITimelineRootMarker rootMarker; // 0x18
		private const float SYNC_START_FORBID_THRESHOLD = 0.016666668f; // Metadata: 0x0234D204
		private bool m_SyncTime; // 0x20
		private double m_AssetDuration; // 0x28
		private TimelinePlayable m_TimelinePlayable; // 0x30
	
		// Constructors
		public DirectorControlPlayable(); // 0x0000000184D77940-0x0000000184D77950
	
		// Methods
		public static ScriptPlayable<DirectorControlPlayable> Create(PlayableGraph graph, PlayableDirector director); // 0x00000001839F7760-0x00000001839F7A20
		public override void OnPlayableDestroy(Playable playable); // 0x000000018B348F24-0x000000018B348FC0
		public override void PrepareFrame(Playable playable, FrameData info); // 0x0000000183E0D6A0-0x0000000183E0D8F0
		public override void OnBehaviourPlay(Playable playable, FrameData info); // 0x00000001839EE7D0-0x00000001839EE930
		public override void OnBehaviourPause(Playable playable, FrameData info); // 0x000000018B348E6C-0x000000018B348F24
		public override void ProcessFrame(Playable playable, FrameData info, object playerData); // 0x0000000183E0D8F0-0x0000000183E0DAE0
		private void SyncSpeed(double speed); // 0x0000000183E0E900-0x0000000183E0E9D0
		private void SyncStart(PlayableGraph graph, double time); // 0x0000000183E0D590-0x0000000183E0D610
		private void SyncStop(PlayableGraph graph, double time); // 0x0000000183E0D610-0x0000000183E0D660
		public override void RuntimeReset(); // 0x00000001841E1670-0x00000001841E1680
	}

	public interface ITimeControl // TypeDefIndex: 59871
	{
		// Methods
		void SetTime(double time);
		void OnControlTimeStart();
		void OnControlTimeStop();
	}

	[Serializable]
	[Flags]
	public enum NotificationFlags : short // TypeDefIndex: 59872
	{
		TriggerInEditMode = 1,
		Retroactive = 2,
		TriggerOnce = 4
	}

	public class ParticleControlPlayable : ControlPlayableBehaviour, ITimeDilationListener // TypeDefIndex: 59873
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
		public ParticleSystem particleSystem { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		private bool shouldSimulate { get; } // 0x000000018B34A95C-0x000000018B34A984 
	
		// Constructors
		public ParticleControlPlayable(); // 0x0000000184DBA6A0-0x0000000184DBA6D0
	
		// Methods
		public static ScriptPlayable<ParticleControlPlayable> Create(PlayableGraph graph, ParticleSystem component, uint randomSeed, float clipIn, float speedMultiplier, bool forceRuntimeSimulate); // 0x000000018B349EB4-0x000000018B34A048
		public void Initialize(ParticleSystem ps, uint randomSeed, float clipIn, float simulateSpeed, bool forceRuntimeSimulate); // 0x000000018B34A048-0x000000018B34A108
		private void SetOriginalSimulateSpeed(ParticleSystem particleSystem, double simulateSpeed); // 0x000000018B34A3C4-0x000000018B34A4FC
		private static void SetRandomSeed(ParticleSystem particleSystem, uint randomSeed); // 0x000000018B34A4FC-0x000000018B34A5F8
		public override void PrepareFrame(Playable playable, FrameData data); // 0x000000018B34A220-0x000000018B34A3C4
		private void _SimulateParticle(float time, float particleTime, bool previewMode); // 0x000000018B34A8D0-0x000000018B34A95C
		public override void OnBehaviourPlay(Playable playable, FrameData info); // 0x0000000184DBA680-0x0000000184DBA690
		private void _PlayOrQueuedParticleSystem(); // 0x000000018B34A7B8-0x000000018B34A8D0
		public override void OnBehaviourPause(Playable playable, FrameData info); // 0x000000018B34A108-0x000000018B34A1C4
		private void Simulate(float time, bool restart); // 0x000000018B34A5F8-0x000000018B34A7B8
		public override void RuntimeReset(); // 0x0000000184DBA690-0x0000000184DBA6A0
		public void OnTimeDilationChanged(float timeScale); // 0x000000018B34A1C4-0x000000018B34A220
	}

	public class PrefabControlPlayable : ControlPlayableBehaviour // TypeDefIndex: 59874
	{
		// Fields
		private GameObject m_Instance; // 0x10
	
		// Properties
		public GameObject prefabInstance { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	
		// Constructors
		public PrefabControlPlayable(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static ScriptPlayable<PrefabControlPlayable> Create(PlayableGraph graph, GameObject prefabGameObject, Transform parentTransform); // 0x000000018B34ABD8-0x000000018B34AD08
		public GameObject Initialize(GameObject prefabGameObject, Transform parentTransform); // 0x000000018B34AD08-0x000000018B34AF5C
		public override void OnPlayableDestroy(Playable playable); // 0x000000018B34B058-0x000000018B34B0E0
		public override void OnBehaviourPlay(Playable playable, FrameData info); // 0x000000018B34AFE8-0x000000018B34B058
		public override void OnBehaviourPause(Playable playable, FrameData info); // 0x000000018B34AF5C-0x000000018B34AFE8
		private static void SetHideFlagsRecursive(GameObject gameObject); // 0x000000018B34B0E0-0x000000018B34B308
	}

	public class TimeControlPlayable : ControlPlayableBehaviour // TypeDefIndex: 59875
	{
		// Fields
		private ITimeControl m_timeControl; // 0x10
		private bool m_started; // 0x18
	
		// Constructors
		public TimeControlPlayable(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static ScriptPlayable<TimeControlPlayable> Create(PlayableGraph graph, ITimeControl timeControl); // 0x000000018B34CC98-0x000000018B34CD88
		public void Initialize(ITimeControl timeControl); // 0x00000001853908C0-0x00000001853908D0
		public override void PrepareFrame(Playable playable, FrameData info); // 0x000000018B34CE30-0x000000018B34CEA8
		public override void OnBehaviourPlay(Playable playable, FrameData info); // 0x000000018B34CDDC-0x000000018B34CE30
		public override void OnBehaviourPause(Playable playable, FrameData info); // 0x000000018B34CD88-0x000000018B34CDDC
		public override void RuntimeReset(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class TimeNotificationBehaviour : PlayableBehaviour // TypeDefIndex: 59878
	{
		// Fields
		private readonly List<NotificationEntry> m_Notifications; // 0x10
		private double m_PreviousTime; // 0x18
		private bool m_NeedSortNotifications; // 0x20
		private bool m_IsManualUpdate; // 0x21
		private Playable m_TimeSource; // 0x28
	
		// Properties
		public Playable timeSource { set; } // 0x0000000184D8FAE0-0x0000000184D8FAF0
		public bool isManualUpdate { set; } // 0x0000000184D86860-0x0000000184D86870
	
		// Nested types
		private struct NotificationEntry // TypeDefIndex: 59876
		{
			// Fields
			public double time; // 0x00
			public INotification payload; // 0x08
			public bool notificationFired; // 0x10
			public NotificationFlags flags; // 0x12
	
			// Properties
			public bool triggerInEditor { get; } // 0x000000018AE0AE18-0x000000018AE0AE20 
			public bool prewarm { get; } // 0x000000018B349EA4-0x000000018B349EAC 
			public bool triggerOnce { get; } // 0x000000018B349EAC-0x000000018B349EB4 
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 59877
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<NotificationEntry> __9__15_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018B3522CC-0x000000018B352424
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _SortNotifications_b__15_0(NotificationEntry x, NotificationEntry y); // 0x000000018B352214-0x000000018B352230
		}
	
		// Constructors
		public TimeNotificationBehaviour(); // 0x000000018B34DD40-0x000000018B34DDB8
	
		// Methods
		public static ScriptPlayable<TimeNotificationBehaviour> Create(PlayableGraph graph, double duration, DirectorWrapMode loopMode); // 0x000000018B34CF8C-0x000000018B34D09C
		public void AddNotification(double time, INotification payload, NotificationFlags flags = NotificationFlags.Retroactive /* Metadata: 0x0234D20E */); // 0x000000018B34CEA8-0x000000018B34CF5C
		public override void OnGraphStart(Playable playable); // 0x000000018B34D244-0x000000018B34D3E4
		public override void OnBehaviourPause(Playable playable, FrameData info); // 0x000000018B34D09C-0x000000018B34D244
		public override void PrepareFrame(Playable playable, FrameData info); // 0x000000018B34D3E4-0x000000018B34D818
		private void SortNotifications(); // 0x000000018B34D818-0x000000018B34D940
		private static bool CanRestoreNotification(NotificationEntry e, FrameData info, double currentTime, double previousTime); // 0x000000018B34CF5C-0x000000018B34CF8C
		private void TriggerNotificationsInRange(double start, double end, FrameData info, Playable playable, bool checkState); // 0x000000018B34DA20-0x000000018B34DC00
		private void SyncDurationWithExternalSource(Playable playable); // 0x000000018B34D940-0x000000018B34DA20
		private static void Trigger_internal(Playable playable, PlayableOutput output, ref NotificationEntry e); // 0x000000018B34DC00-0x000000018B34DC7C
		private static void Restore_internal(ref NotificationEntry e); // 0x0000000184D8CCB0-0x0000000184D8CCC0
		private static double _GetPlayableTime(Playable playable); // 0x000000018B34DC7C-0x000000018B34DD40
	}

	public interface IAsyncScriptAnimationJobSyncInit // TypeDefIndex: 59879
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

	public class CommunicatorParam // TypeDefIndex: 59880
	{
		// Fields
		public IScriptAnimationJobSync jobSync; // 0x10
		public IAsyncScriptAnimationJobSyncInit asyncJobSyncInit; // 0x18
		public string uniqueId; // 0x20
		public bool lookAtUseAdditive; // 0x28
		public bool useLookAtV2; // 0x29
		public bool useAsyncJobSyncInit; // 0x2A
	
		// Constructors
		public CommunicatorParam(); // 0x00000001841E1670-0x00000001841E1680
	}

	public interface IAutoGenMono // TypeDefIndex: 59881
	{
	}

	public interface IBehaviourRuntimeReset // TypeDefIndex: 59882
	{
	}

	public interface IScriptAnimationJobSync : IAutoGenMono // TypeDefIndex: 59883
	{
		// Methods
		void ProcessRootMotion(AnimationStream stream);
		void CalcLayerMainStream(float deltaTime);
		void ResetCloth(List<RuntimeElement> activeRuntimeElements, bool useSoftReset = true /* Metadata: 0x0234D210 */, bool keepPose = false /* Metadata: 0x0234D211 */, bool useRelativeTeleport = false /* Metadata: 0x0234D212 */);
	}

	public struct TimelineScriptAnimationJob : IAnimationJob // TypeDefIndex: 59884
	{
		// Fields
		private static readonly ProfilerMarker s_processRootMotionMarker; // 0x00
		public IScriptAnimationJobSync bindedScriptAnimationJobSync; // 0x00
		public Animator bindedAnimator; // 0x08
	
		// Constructors
		public TimelineScriptAnimationJob(IScriptAnimationJobSync job, Animator animator); // 0x00000001839CF630-0x00000001839CF660
		static TimelineScriptAnimationJob(); // 0x0000000182ED08A0-0x0000000182ED1AA0
	
		// Methods
		public void ProcessAnimation(AnimationStream stream); // 0x00000001841E1670-0x00000001841E1680
		public void ProcessRootMotion(AnimationStream stream); // 0x000000018B351F80-0x000000018B3520F8
	}

	[Serializable]
	public class PlayableTrack : TrackAsset // TypeDefIndex: 59885
	{
		// Constructors
		public PlayableTrack(); // 0x000000018B34AB8C-0x000000018B34ABD8
	
		// Methods
		protected override void OnCreateClip(TimelineClip clip); // 0x000000018B34AAF4-0x000000018B34AB8C
	}

	[AttributeUsage(AttributeTargets.Class)]
	[Obsolete("TrackMediaType has been deprecated. It is no longer required, and will be removed in a future release.", false)]
	public class TrackMediaType : Attribute // TypeDefIndex: 59886
	{
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public class TrackClipTypeAttribute : Attribute // TypeDefIndex: 59887
	{
		// Fields
		public readonly System.Type inspectedType; // 0x10
		public readonly bool allowAutoCreate; // 0x18
	
		// Constructors
		public TrackClipTypeAttribute(System.Type clipClass); // 0x0000000184774A10-0x0000000184774A30
		public TrackClipTypeAttribute(System.Type clipClass, bool allowAutoCreate); // 0x0000000184D831B0-0x0000000184D831C0
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
	public class NotKeyableAttribute : Attribute // TypeDefIndex: 59888
	{
		// Constructors
		public NotKeyableAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Flags]
	public enum TrackBindingFlags // TypeDefIndex: 59889
	{
		None = 0,
		AllowCreateComponent = 1,
		All = 1
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class TrackBindingTypeAttribute : Attribute // TypeDefIndex: 59890
	{
		// Fields
		public readonly System.Type type; // 0x10
		public readonly TrackBindingFlags flags; // 0x18
	
		// Constructors
		public TrackBindingTypeAttribute(System.Type type); // 0x0000000184824300-0x0000000184824330
		public TrackBindingTypeAttribute(System.Type type, TrackBindingFlags flags); // 0x0000000183B46FF0-0x0000000183B47040
	}

	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public class SupportsChildTracksAttribute : Attribute // TypeDefIndex: 59891
	{
		// Fields
		public readonly System.Type childType; // 0x10
		public readonly int levels; // 0x18
	
		// Constructors
		public SupportsChildTracksAttribute(System.Type childType = null, int levels = 2147483647 /* Metadata: 0x0234D216 */); // 0x0000000183B46FF0-0x0000000183B47040
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	internal class IgnoreOnPlayableTrackAttribute : Attribute // TypeDefIndex: 59892
	{
		// Constructors
		public IgnoreOnPlayableTrackAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal class TimeFieldAttribute : PropertyAttribute // TypeDefIndex: 59894
	{
		// Fields
		[CompilerGenerated]
		private readonly UseEditMode _useEditMode_k__BackingField; // 0x10
	
		// Nested types
		public enum UseEditMode // TypeDefIndex: 59893
		{
			None = 0,
			ApplyEditMode = 1
		}
	
		// Constructors
		public TimeFieldAttribute(UseEditMode useEditMode = UseEditMode.ApplyEditMode /* Metadata: 0x0234D217 */); // 0x00000001814F51F0-0x00000001814F5220
	}

	internal class FrameRateFieldAttribute : PropertyAttribute // TypeDefIndex: 59895
	{
		// Constructors
		public FrameRateFieldAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public class HideInMenuAttribute : Attribute // TypeDefIndex: 59896
	{
		// Constructors
		public HideInMenuAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class CustomStyleAttribute : Attribute // TypeDefIndex: 59897
	{
		// Fields
		public readonly string ussStyle; // 0x10
	
		// Constructors
		public CustomStyleAttribute(string ussStyle); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class MenuCategoryAttribute : Attribute // TypeDefIndex: 59898
	{
	}

	public interface ITimelineClipAsset // TypeDefIndex: 59899
	{
		// Properties
		ClipCaps clipCaps { get; }
	}

	public interface ITimelineEvaluateCallback // TypeDefIndex: 59900
	{
		// Methods
		void Evaluate();
	}

	public class TimelinePlayable : PlayableBehaviour // TypeDefIndex: 59901
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
		private bool m_isAsyncCompileEnabled; // 0xA8
		private bool m_isAsyncCompileComplete; // 0xA9
		private bool m_isAsyncCompileFailed; // 0xAA
		private PlayableGraph m_AsyncCompileGraph; // 0xB0
		private Playable m_AsyncTimelinePlayable; // 0xC0
		private List<TrackAsset> m_AsyncOutputTrackList; // 0xD0
		private GameObject m_AsyncCompileGo; // 0xD8
		private bool m_AsyncAutoRebalance; // 0xE0
		private bool m_AsyncCreateOutputs; // 0xE1
		private int m_AsyncOutputTrackIndex; // 0xE4
		private bool m_AsyncCombineToTopCompiled; // 0xE8
		private PlayableOutput m_AsyncCompileDummyOutput; // 0xF0
		private static readonly ProfilerMarker s_compileSingleTrackMarker; // 0x00
		private static readonly ProfilerMarker s_prepareFrameMarker; // 0x08
		private static readonly ProfilerMarker s_evaluateMarker; // 0x10
		private static readonly ProfilerMarker s_queryActiveClipsMarker; // 0x18
		private static readonly ProfilerMarker s_filterActiveClipsMarker; // 0x20
		private static readonly ProfilerMarker s_disableInactiveClipsMarker; // 0x28
		private static readonly ProfilerMarker s_evaluateActiveClipsMarker; // 0x30
		private static readonly ProfilerMarker s_evaluateCallbacksMarker; // 0x38
		private static readonly ProfilerMarker s_resetScriptAnimationJobSyncsMarker; // 0x40
		private static readonly ProfilerMarker s_evaluateTwiceMarker; // 0x48
		internal static bool muteAudioScrubbing; // 0x50
		private double m_timeForNextFrame; // 0x100
	
		// Properties
		public double timeForNextFrame { get; } // 0x0000000184D925A0-0x0000000184D925B0 
		public ITimelineRootMarker timelineRootMarker { get; } // 0x0000000184D86220-0x0000000184D86230 
		public bool isAsyncCompileComplete { get; } // 0x0000000182ED0880-0x0000000182ED0890 
		public bool isAsyncCompileFailed { get; } // 0x0000000182ED0890-0x0000000182ED08A0 
		public bool enableLoop { get; } // 0x000000018B34F3AC-0x000000018B34F3F8 
	
		// Constructors
		public TimelinePlayable(); // 0x0000000183FC8600-0x0000000183FC8960
		static TimelinePlayable(); // 0x0000000184D77960-0x0000000184D79440
	
		// Methods
		public static ScriptPlayable<TimelinePlayable> Create(PlayableGraph graph, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs); // 0x0000000183FC6800-0x0000000183FC7E20
		public void Compile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs); // 0x0000000183FC7E20-0x0000000183FC7F60
		public void BeginAsyncCompile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs); // 0x0000000182EC7ED0-0x0000000182EC7F90
		public bool StepAsyncCompile(int outputGroupBudget, bool isInBurstMode = false /* Metadata: 0x0234D21A */); // 0x0000000182ECFD60-0x0000000182ED0880
		private void InitializeCompileContext(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs); // 0x0000000182ECCBB0-0x0000000182ECF130
		private void FinalizeCompile(); // 0x00000001841E1670-0x00000001841E1680
		private void CreateAsyncCompileDummyOutput(PlayableGraph graph); // 0x0000000182EC9CD0-0x0000000182ECA7B0
		private void ClearAsyncCompileDummyOutput(); // 0x0000000182EC7F90-0x0000000182EC86D0
		public void MarkTimelineEnd(); // 0x0000000184DBA700-0x0000000184DBA710
		public bool IsTimelineEnded(); // 0x0000000184DAA1E0-0x0000000184DAA1F0
		private void CompileCombineTopTopTrackList(PlayableGraph graph, Playable timelinePlayable, bool createOutputs); // 0x00000001839EF290-0x00000001839EFB40
		private static void CollectCombineToTopTracksRecursive(TrackAsset track, List<TrackAsset> combineTracks); // 0x00000001839F4EB0-0x00000001839F5080
		private void CompileTrackList(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool createOutputs, bool isCompilingCombineToTopTracks); // 0x00000001839F5080-0x00000001839F5D40
		private bool CompileSingleTrack(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, bool createOutputs, bool isCompilingCombineToTopTracks); // 0x0000000182EC86D0-0x0000000182EC9CD0
		private static bool IsAsyncCompileFrameBarrierTrack(TrackAsset track); // 0x0000000182ECF130-0x0000000182ECF440
		private void CreateTrackOutput(PlayableGraph graph, TrackAsset track, GameObject go, Playable playable, int port); // 0x0000000183FC97E0-0x0000000183FCC860
		private void EvaluateWeightsForAnimationPlayableOutput(TrackAsset track, AnimationPlayableOutput animOutput, Animator animator); // 0x0000000183E11710-0x0000000183E117C0
		private Playable CreateTrackPlayable(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, bool createOutputs); // 0x0000000183433E70-0x0000000183434290
		public void UpdateIntervalTree(); // 0x000000018B34EEB4-0x000000018B34EEFC
		public void RuntimeResetIntervalTree(); // 0x000000018B34EC78-0x000000018B34ECC0
		public bool IsDynamicLinkAnimationOutput(PlayableOutput output); // 0x0000000182ECF440-0x0000000182ECFD60
		private static bool HasDynamicLinkAnimationClip(TrackAsset track); // 0x0000000182ECA7B0-0x0000000182ECCBB0
		public override void PrepareFrame(Playable playable, FrameData info); // 0x0000000183E0B9F0-0x0000000183E0D590
		private void _ResetScriptAnimationJobySyncs(); // 0x000000018B34F1A4-0x000000018B34F3AC
		private void _EvaluateTwice(); // 0x000000018B34EEFC-0x000000018B34F058
		public List<RuntimeElement> GetCurrentActiveClips(); // 0x0000000184D85A60-0x0000000184D85A70
		public List<RuntimeElement> GetActiveClipsAtGivenTime(double givenTime, List<RuntimeElement> activeClips = null); // 0x000000018489B450-0x000000018489B510
		public List<RuntimeElement> GetActiveClipsAtGivenTimeRange(double startTime, double endTime, List<RuntimeElement> activeClips = null); // 0x000000018B34EAC4-0x000000018B34EBC0
		protected virtual void Evaluate(Playable playable, FrameData frameData); // 0x00000001839F7A20-0x00000001839FB100
		private bool DoReverseLoop(double reverseTime); // 0x000000018B34E854-0x000000018B34EAC4
		private bool DoReverseJump(RuntimeClip runtimeClip, double jumpTime); // 0x000000018B34E778-0x000000018B34E854
		private bool DoJump(RuntimeClip runtimeClip, double localTime, double jumpTime); // 0x000000018B34E6C0-0x000000018B34E778
		private bool _CheckIfTimeJumping(FrameData frameData, double localTime); // 0x00000001839EC880-0x00000001839ECDF0
		private void CacheTrack(TrackAsset track, Playable playable, int port, Playable parent); // 0x00000001849CB200-0x00000001849CB280
		public void SetTimeForNextFrame(double newTime); // 0x0000000184D925E0-0x0000000184D925F0
		public void RegisterTimeDilationListener(ITimeDilationListener listener); // 0x000000018B34EC24-0x000000018B34EC78
		public void MarkMixerForbidPostProcess(Playable mixer); // 0x000000018B34EBC0-0x000000018B34EC24
		public bool CheckIfMixerForbidPostProcess(Playable mixer); // 0x0000000183E10BF0-0x0000000183E10C60
		public void SetTimeScale(float usingTimeScale); // 0x000000018B34ECC0-0x000000018B34EEB4
		private void _NotifyTimeScaleChanged(float usingTimeScale); // 0x000000018B34F058-0x000000018B34F1A4
	}

	public static class AnimationPreviewUtilities // TypeDefIndex: 59902
	{
	}

	internal static class Extrapolation // TypeDefIndex: 59904
	{
		// Fields
		internal static readonly double kMinExtrapolationTime; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 59903
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<TimelineClip> __9__2_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000184D47230-0x0000000184D47290
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _SortClipsByStartTime_b__2_0(TimelineClip clip1, TimelineClip clip2); // 0x000000018B34592C-0x000000018B345968
		}
	
		// Constructors
		static Extrapolation(); // 0x0000000183B0C320-0x0000000183B0C3A0
	
		// Methods
		private static TimelineClip[] SortClipsByStartTime(TimelineClip[] clips); // 0x0000000184B20B90-0x0000000184B20CF0
	
		// Extension methods
		internal static void CalculateExtrapolationTimes(this TrackAsset asset); // 0x00000001839F6420-0x00000001839F65F0
	}

	internal static class HashUtility // TypeDefIndex: 59905
	{
		// Methods
		public static int CombineHash(int h1, int h2, int h3); // 0x0000000184DBA620-0x0000000184DBA660
		public static int CombineHash(int h1, int h2, int h3, int h4); // 0x0000000183AC42A0-0x0000000183AC42F0
		public static int CombineHash(int h1, int h2, int h3, int h4, int h5); // 0x0000000183AC4260-0x0000000183AC42A0
		public static int CombineHash(int h1, int h2, int h3, int h4, int h5, int h6); // 0x0000000183AC4200-0x0000000183AC4260
	
		// Extension methods
		public static int CombineHash(this int h1, int h2); // 0x0000000184DBA660-0x0000000184DBA680
	}

	public interface IPropertyCollector // TypeDefIndex: 59906
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

	public interface IPropertyPreview // TypeDefIndex: 59907
	{
		// Methods
		void GatherProperties(PlayableDirector director, IPropertyCollector driver);
	}

	internal static class NotificationUtilities // TypeDefIndex: 59908
	{
		// Methods
		public static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, double duration, DirectorWrapMode extrapolationMode); // 0x00000001839ED700-0x00000001839EDB60
		public static bool TrackTypeSupportsNotifications(System.Type type); // 0x00000001839EE2D0-0x00000001839EE3F0
	}

	public static class PlayableDirectorUtility // TypeDefIndex: 59909
	{
		// Methods
		public static void SetOptionIndexSingleDirector(PlayableDirector director, int curOptionIndex, int lastOptionIndex); // 0x000000018B34AAC4-0x000000018B34AAF4
		public static TimelinePlayable GetTimelinePlayable(PlayableDirector director); // 0x000000018B34AA48-0x000000018B34AAC4
		public static TimelinePlayable GetTimelinePlayable(PlayableGraph graph); // 0x0000000183E10640-0x0000000183E10710
		public static TimelinePlayable GetTimelinePlayableFromChildPlayable(Playable playable); // 0x0000000183E103D0-0x0000000183E10490
		public static bool CheckIfTimelineFunctional(Playable playable); // 0x000000018B34A984-0x000000018B34AA48
	}

	public static class TimelineClipExtensions // TypeDefIndex: 59910
	{
		// Fields
		private static readonly string k_UndoSetParentTrackText; // 0x00
	
		// Constructors
		static TimelineClipExtensions(); // 0x000000018B34DE8C-0x000000018B34DEE8
	}

	public static class TimelineCreateUtilities // TypeDefIndex: 59913
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 59911
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GenerateUniqueActorName_b__0(ScriptableObject x); // 0x000000018B352230-0x000000018B352268
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_1 // TypeDefIndex: 59912
		{
			// Fields
			public string result; // 0x10
	
			// Constructors
			public __c__DisplayClass0_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GenerateUniqueActorName_b__1(ScriptableObject x); // 0x000000018B352230-0x000000018B352268
		}
	
		// Methods
		public static string GenerateUniqueActorName(List<ScriptableObject> tracks, string name); // 0x000000018B34E128-0x000000018B34E3DC
		public static void SaveAssetIntoObject(UnityEngine.Object childAsset, UnityEngine.Object masterAsset); // 0x000000018B34E3DC-0x000000018B34E49C
		public static AnimationClip CreateAnimationClipForTrack(string name, TrackAsset track, bool isLegacy); // 0x000000018B34DF84-0x000000018B34E128
		public static bool ValidateParentTrack(TrackAsset parent, System.Type childType); // 0x000000018B34E49C-0x000000018B34E6C0
	}

	public class TimelineRuntimeUtils // TypeDefIndex: 59914
	{
		// Constructors
		public TimelineRuntimeUtils(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static double GetTimelineDeltaTime(Playable playable, FrameData frameData); // 0x0000000183E105E0-0x0000000183E10640
		public static bool CheckWillRuntimeElementEnabled(RuntimeElement element, int curOptionIndex, int lastOptionIndex, long curDiscreteTime); // 0x000000018B34F3F8-0x000000018B34F49C
		public static void DoReverseJump(RuntimeClip jumpClip, ITimelineRootMarker timelineRoot, double curTime, double jumpTime, double mixDuration, int curOptionIndex, int lastOptionIndex, bool needChangeOptionAfterJump, int newOptionIndex); // 0x000000018B3504A0-0x000000018B35149C
		public static void DoJump(RuntimeClip jumpClip, ITimelineRootMarker timelineRoot, double curTime, double jumpTime, double mixDuration, int curOptionIndex, int lastOptionIndex, bool needChangeOptionAfterJump, int optionIndexChangingTo); // 0x000000018B34F49C-0x000000018B3504A0
		public static double GetSubDirectorTimeForDirectorControl(Playable playable, PlayableDirector director); // 0x000000018B351940-0x000000018B351A98
		public static void SetNewTimeForCutsceneRoot(ITimelineRootMarker timelineRoot, double newTime, bool useThisTimeNextFrame = false /* Metadata: 0x0234D21B */); // 0x000000018B351CC0-0x000000018B351F80
		public static AnimationClip FindTPoseClipFromLayerDescriptors(List<LayerDescriptor> layerDescriptors); // 0x000000018B35149C-0x000000018B351940
		public static void LinkDefaultTPoseIfNeeded(AnimationLayerMixerPlayable mixer, List<LayerDescriptor> layerDescriptors, string gameObjectName, bool disableBaseTPoseClip = false /* Metadata: 0x0234D21C */); // 0x000000018B351C34-0x000000018B351CC0
		public static void LinkDefaultTPoseClip(AnimationLayerMixerPlayable mixer, AnimationClip tposeClip, string gameObjectName); // 0x000000018B351A98-0x000000018B351C34
	}

	internal static class TimelineUndo // TypeDefIndex: 59915
	{
		// Methods
		public static void PushDestroyUndo(TimelineAsset timeline, UnityEngine.Object thingToDirty, UnityEngine.Object objectToDestroy); // 0x000000018B3520F8-0x000000018B352158
	}

	public enum StandardFrameRates // TypeDefIndex: 59916
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

	internal static class TimeUtility // TypeDefIndex: 59918
	{
		// Fields
		public static readonly double kTimeEpsilon; // 0x00
		public static readonly double kFrameRateEpsilon; // 0x08
		public static readonly double k_MaxTimelineDurationInSeconds; // 0x10
		public static readonly double kFrameRateRounding; // 0x18
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 59917
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x000000018B352268-0x000000018B3522CC
			public __c(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		static TimeUtility(); // 0x0000000184D27990-0x0000000184D27A30
	
		// Methods
		public static double GetAnimationClipLength(AnimationClip clip); // 0x000000018B34DDB8-0x000000018B34DE8C
	}

	internal static class WeightUtility // TypeDefIndex: 59919
	{
		// Methods
		public static float NormalizeMixer(Playable mixer); // 0x0000000183E11A60-0x0000000183E11BE0
	}
}

namespace UnityEngine.Timeline.Condition
{
	[ExecuteAlways]
	public class TimelineConditionControlMono : MonoBehaviour // TypeDefIndex: 59920
	{
		// Fields
		public TimelineConditionBase condition; // 0x18
	
		// Constructors
		public TimelineConditionControlMono(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void RefreshOnCondition(); // 0x000000018B34DEE8-0x000000018B34DF84
	}
}
