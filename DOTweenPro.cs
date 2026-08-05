/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Events;

// Image 125: DOTweenPro.dll - Assembly: DOTweenPro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63702-63714
[assembly: AssemblyCompany("Demigiant")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCopyright("Copyright \u00A9 Daniele Giardini, 2014")]
[assembly: AssemblyDescription("Additional DOTween shorcuts that require Unity 4.3 or later")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyProduct("DOTweenPro")]
[assembly: AssemblyTitle("DOTweenPro")]
[assembly: AssemblyTrademark("")]
[assembly: CompilationRelaxations(8)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: Guid("807e068c-2a0e-4c81-a303-4b4fd3924511")]
[assembly: InternalsVisibleTo("DOTweenProEditor")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace DG.Tweening
{
	[AddComponentMenu("")]
	public class DOTweenVisualManager : MonoBehaviour // TypeDefIndex: 63703
	{
		// Fields
		public VisualManagerPreset preset; // 0x18
		public OnEnableBehaviour onEnableBehaviour; // 0x1C
		public OnDisableBehaviour onDisableBehaviour; // 0x20
		private bool _requiresRestartFromSpawnPoint; // 0x24
		private ABSAnimationComponent _animComponent; // 0x28
	
		// Constructors
		public DOTweenVisualManager(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Awake(); // 0x0000000186974008-0x0000000186974050
		private void Update(); // 0x00000001869742B0-0x000000018697432C
		private void OnEnable(); // 0x00000001869741F8-0x00000001869742B0
		private void OnDisable(); // 0x0000000186974050-0x00000001869741F8
	}

	public enum HandlesDrawMode // TypeDefIndex: 63704
	{
		Orthographic = 0,
		Perspective = 1
	}

	public enum HandlesType // TypeDefIndex: 63705
	{
		Free = 0,
		Full = 1
	}

	public enum DOTweenInspectorMode // TypeDefIndex: 63706
	{
		Default = 0,
		InfoAndWaypointsOnly = 1,
		Developer = 2,
		OnlyPath = 3
	}

	[AddComponentMenu("DOTween/DOTween Path")]
	public class DOTweenPath : ABSAnimationComponent // TypeDefIndex: 63707
	{
		// Fields
		[CompilerGenerated]
		private static Action<DOTweenPath> OnReset; // 0x00
		public float delay; // 0x68
		public float duration; // 0x6C
		public Ease easeType; // 0x70
		public AnimationCurve easeCurve; // 0x78
		public int loops; // 0x80
		public string id; // 0x88
		public LoopType loopType; // 0x90
		public OrientType orientType; // 0x94
		public Transform lookAtTransform; // 0x98
		public Vector3 lookAtPosition; // 0xA0
		public float lookAhead; // 0xAC
		public bool autoPlay; // 0xB0
		public bool autoKill; // 0xB1
		public bool relative; // 0xB2
		public bool isLocal; // 0xB3
		public bool isClosedPath; // 0xB4
		public int pathResolution; // 0xB8
		public PathMode pathMode; // 0xBC
		public AxisConstraint lockRotation; // 0xC0
		public bool assignForwardAndUp; // 0xC4
		public Vector3 forwardDirection; // 0xC8
		public Vector3 upDirection; // 0xD4
		public bool tweenRigidbody; // 0xE0
		public List<Vector3> wps; // 0xE8
		public List<Vector3> fullWps; // 0xF0
		public Path path; // 0xF8
		public DOTweenInspectorMode inspectorMode; // 0x100
		public PathType pathType; // 0x104
		public HandlesType handlesType; // 0x108
		public bool livePreview; // 0x10C
		public HandlesDrawMode handlesDrawMode; // 0x110
		public float perspectiveHandleSize; // 0x114
		public bool showIndexes; // 0x118
		public bool showWpLength; // 0x119
		public UnityEngine.Color pathColor; // 0x11C
		public Vector3 lastSrcPosition; // 0x12C
		public Quaternion lastSrcRotation; // 0x138
		public bool wpsDropdown; // 0x148
		public float dropToFloorOffset; // 0x14C
		private static MethodInfo _miCreateTween; // 0x08
	
		// Events
		public static event Action<DOTweenPath> OnReset {
			add; // 0x0000000186973ED0-0x0000000186973F6C
			remove; // 0x0000000186973F6C-0x0000000186974008
		}
	
		// Constructors
		public DOTweenPath(); // 0x0000000186973C54-0x0000000186973ED0
	
		// Methods
		private static void Dispatch_OnReset(DOTweenPath path); // 0x0000000186973578-0x00000001869735C8
		private void Awake(); // 0x0000000186972600-0x0000000186973340
		private void Reset(); // 0x0000000186973B28-0x0000000186973C40
		private void OnDestroy(); // 0x0000000186973810-0x0000000186973850
		public override void DOPlay(); // 0x00000001869734AC-0x00000001869734E8
		public void DOPlayById(string id); // 0x0000000186973440-0x00000001869734A0
		public void DOPlayAllById(string id); // 0x00000001869733E8-0x0000000186973434
		public override void DOPlayBackwards(); // 0x0000000186973434-0x0000000186973440
		public override void DOPlayForward(); // 0x00000001869734A0-0x00000001869734AC
		public override void DOPause(); // 0x00000001869733AC-0x00000001869733E8
		public override void DOTogglePause(); // 0x000000018697356C-0x0000000186973578
		public override void DORewind(); // 0x000000018697355C-0x000000018697356C
		public override void DORestart(); // 0x00000001869734E8-0x00000001869734F8
		public override void DORestart(bool fromHere); // 0x00000001869734F8-0x000000018697355C
		public override void DOComplete(); // 0x0000000186973340-0x0000000186973350
		public override void DOKill(); // 0x000000018697339C-0x00000001869733AC
		public void DOKillAllById(string id); // 0x0000000186973350-0x000000018697339C
		public DG.Tweening.Tween GetTween(); // 0x00000001869737C8-0x0000000186973810
		public Vector3[] GetDrawPoints(); // 0x00000001869735C8-0x0000000186973644
		internal Vector3[] GetFullWps(); // 0x0000000186973644-0x00000001869737C8
		private void ReEvaluateRelativeTween(); // 0x0000000186973850-0x0000000186973B28
		[CompilerGenerated]
		private void _Awake_b__44_0(); // 0x0000000186973C40-0x0000000186973C54
	}

	public enum SpiralMode // TypeDefIndex: 63708
	{
		Expand = 0,
		ExpandThenContract = 1
	}
}

namespace DG.Tweening.Core
{
	[AddComponentMenu("")]
	public abstract class ABSAnimationComponent : MonoBehaviour // TypeDefIndex: 63711
	{
		// Fields
		public DG.Tweening.UpdateType updateType; // 0x18
		public bool isSpeedBased; // 0x1C
		public bool hasOnStart; // 0x1D
		public bool hasOnPlay; // 0x1E
		public bool hasOnUpdate; // 0x1F
		public bool hasOnStepComplete; // 0x20
		public bool hasOnComplete; // 0x21
		public bool hasOnTweenCreated; // 0x22
		public bool hasOnRewind; // 0x23
		public UnityEvent onStart; // 0x28
		public UnityEvent onPlay; // 0x30
		public UnityEvent onUpdate; // 0x38
		public UnityEvent onStepComplete; // 0x40
		public UnityEvent onComplete; // 0x48
		public UnityEvent onTweenCreated; // 0x50
		public UnityEvent onRewind; // 0x58
		[NonSerialized]
		public DG.Tweening.Tween tween; // 0x60
	
		// Constructors
		protected ABSAnimationComponent(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public abstract void DOPlay();
		public abstract void DOPlayBackwards();
		public abstract void DOPlayForward();
		public abstract void DOPause();
		public abstract void DOTogglePause();
		public abstract void DORewind();
		public abstract void DORestart();
		public abstract void DORestart(bool fromHere);
		public abstract void DOComplete();
		public abstract void DOKill();
	}

	public enum OnDisableBehaviour // TypeDefIndex: 63712
	{
		None = 0,
		Pause = 1,
		Rewind = 2,
		Kill = 3,
		KillAndComplete = 4,
		DestroyGameObject = 5
	}

	public enum OnEnableBehaviour // TypeDefIndex: 63713
	{
		None = 0,
		Play = 1,
		Restart = 2,
		RestartFromSpawnPoint = 3
	}

	public enum VisualManagerPreset // TypeDefIndex: 63714
	{
		Custom = 0,
		PoolingSystem = 1
	}
}

namespace DG.Tweening.Plugins
{
	public struct SpiralOptions : IPlugOptions // TypeDefIndex: 63709
	{
		// Fields
		public float depth; // 0x00
		public float frequency; // 0x04
		public float speed; // 0x08
		public SpiralMode mode; // 0x0C
		public bool snapping; // 0x10
		internal float unit; // 0x14
		internal Quaternion axisQ; // 0x18
	
		// Methods
		public void Reset(); // 0x0000000184D8C990-0x0000000184D8C9A0
	}

	public class SpiralPlugin : ABSTweenPlugin<Vector3, Vector3, SpiralOptions> // TypeDefIndex: 63710
	{
		// Fields
		public static readonly Vector3 DefaultDirection; // 0x00
	
		// Constructors
		public SpiralPlugin(); // 0x0000000186974784-0x00000001869747AC
		static SpiralPlugin(); // 0x0000000186974734-0x0000000186974784
	
		// Methods
		public override void Reset(TweenerCore<Vector3, Vector3, SpiralOptions> t); // 0x00000001841E1670-0x00000001841E1680
		public override void SetFrom(TweenerCore<Vector3, Vector3, SpiralOptions> t, bool isRelative); // 0x00000001841E1670-0x00000001841E1680
		public override void SetFrom(TweenerCore<Vector3, Vector3, SpiralOptions> t, Vector3 fromValue, bool setImmediately, bool isRelative); // 0x00000001841E1670-0x00000001841E1680
		public static ABSTweenPlugin<Vector3, Vector3, SpiralOptions> Get(); // 0x0000000186974674-0x00000001869746A4
		public override Vector3 ConvertToStartValue(TweenerCore<Vector3, Vector3, SpiralOptions> t, Vector3 value); // 0x0000000184D8C9A0-0x0000000184D8C9C0
		public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3, SpiralOptions> t); // 0x00000001841E1670-0x00000001841E1680
		public override void SetChangeValue(TweenerCore<Vector3, Vector3, SpiralOptions> t); // 0x00000001869746A4-0x0000000186974734
		public override float GetSpeedBasedDuration(SpiralOptions options, float unitsXSecond, Vector3 changeValue); // 0x0000000184D8C9C0-0x0000000184D8C9D0
		public override void EvaluateAndApply(SpiralOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x000000018697432C-0x0000000186974674
	}
}
