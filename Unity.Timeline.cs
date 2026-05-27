/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ScriptAnimation;
using UnityEngine;
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
