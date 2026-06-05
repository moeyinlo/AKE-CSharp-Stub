/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Reflection;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Events;

// Image 123: DOTweenPro.dll - Assembly: DOTweenPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61066-61078

namespace DG.Tweening
{
	public class DOTweenVisualManager : MonoBehaviour // TypeDefIndex: 61067
	{
		// Fields
		public VisualManagerPreset preset; // 0x18
		public OnEnableBehaviour onEnableBehaviour; // 0x1C
		public OnDisableBehaviour onDisableBehaviour; // 0x20
		private bool _requiresRestartFromSpawnPoint; // 0x24
		private ABSAnimationComponent _animComponent; // 0x28
	
		// Constructors
		public DOTweenVisualManager() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Awake() {} // 0x0000000187908DD0-0x0000000187908E18
		private void Update() {} // 0x0000000187909078-0x00000001879090F4
		private void OnEnable() {} // 0x0000000187908FC0-0x0000000187909078
		private void OnDisable() {} // 0x0000000187908E18-0x0000000187908FC0
	}

	public enum HandlesDrawMode // TypeDefIndex: 61068
	{
		Orthographic = 0,
		Perspective = 1
	}

	public enum HandlesType // TypeDefIndex: 61069
	{
		Free = 0,
		Full = 1
	}

	public enum DOTweenInspectorMode // TypeDefIndex: 61070
	{
		Default = 0,
		InfoAndWaypointsOnly = 1,
		Developer = 2,
		OnlyPath = 3
	}

	public class DOTweenPath : ABSAnimationComponent // TypeDefIndex: 61071
	{
		// Fields
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
		public static event Action<DOTweenPath> OnReset;
	
		// Constructors
		public DOTweenPath() {} // 0x0000000187908A1C-0x0000000187908C98
	
		// Methods
		private static void Dispatch_OnReset(DOTweenPath path) {} // 0x0000000187908340-0x0000000187908390
		private void Awake() {} // 0x00000001879073C8-0x0000000187908108
		private void Reset() {} // 0x00000001879088F0-0x0000000187908A08
		private void OnDestroy() {} // 0x00000001879085D8-0x0000000187908618
		public override void DOPlay() {} // 0x0000000187908274-0x00000001879082B0
		public void DOPlayById(string id) {} // 0x0000000187908208-0x0000000187908268
		public void DOPlayAllById(string id) {} // 0x00000001879081B0-0x00000001879081FC
		public override void DOPlayBackwards() {} // 0x00000001879081FC-0x0000000187908208
		public override void DOPlayForward() {} // 0x0000000187908268-0x0000000187908274
		public override void DOPause() {} // 0x0000000187908174-0x00000001879081B0
		public override void DOTogglePause() {} // 0x0000000187908334-0x0000000187908340
		public override void DORewind() {} // 0x0000000187908324-0x0000000187908334
		public override void DORestart() {} // 0x00000001879082B0-0x00000001879082C0
		public override void DORestart(bool fromHere) {} // 0x00000001879082C0-0x0000000187908324
		public override void DOComplete() {} // 0x0000000187908108-0x0000000187908118
		public override void DOKill() {} // 0x0000000187908164-0x0000000187908174
		public void DOKillAllById(string id) {} // 0x0000000187908118-0x0000000187908164
		public DG.Tweening.Tween GetTween() => default; // 0x0000000187908590-0x00000001879085D8
		public Vector3[] GetDrawPoints() => default; // 0x0000000187908390-0x000000018790840C
		internal Vector3[] GetFullWps() => default; // 0x000000018790840C-0x0000000187908590
		private void ReEvaluateRelativeTween() {} // 0x0000000187908618-0x00000001879088F0
		private void _Awake_b__44_0() {} // 0x0000000187908A08-0x0000000187908A1C
	}

	public enum SpiralMode // TypeDefIndex: 61072
	{
		Expand = 0,
		ExpandThenContract = 1
	}
}

namespace DG.Tweening.Core
{
	public abstract class ABSAnimationComponent : MonoBehaviour // TypeDefIndex: 61075
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
		protected ABSAnimationComponent() {} // 0x000000018646DB20-0x000000018646DB28
	
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

	public enum OnDisableBehaviour // TypeDefIndex: 61076
	{
		None = 0,
		Pause = 1,
		Rewind = 2,
		Kill = 3,
		KillAndComplete = 4,
		DestroyGameObject = 5
	}

	public enum OnEnableBehaviour // TypeDefIndex: 61077
	{
		None = 0,
		Play = 1,
		Restart = 2,
		RestartFromSpawnPoint = 3
	}

	public enum VisualManagerPreset // TypeDefIndex: 61078
	{
		Custom = 0,
		PoolingSystem = 1
	}
}

namespace DG.Tweening.Plugins
{
	public struct SpiralOptions : IPlugOptions // TypeDefIndex: 61073
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
		public void Reset() {} // 0x0000000185FB6870-0x0000000185FB6880
	}

	public class SpiralPlugin : ABSTweenPlugin<Vector3, Vector3, SpiralOptions> // TypeDefIndex: 61074
	{
		// Fields
		public static readonly Vector3 DefaultDirection; // 0x00
	
		// Constructors
		public SpiralPlugin() {} // 0x000000018790954C-0x0000000187909574
		static SpiralPlugin() {} // 0x00000001879094FC-0x000000018790954C
	
		// Methods
		public override void Reset(TweenerCore<Vector3, Vector3, SpiralOptions> t) {} // 0x0000000185492010-0x0000000185492020
		public override void SetFrom(TweenerCore<Vector3, Vector3, SpiralOptions> t, bool isRelative) {} // 0x0000000185492010-0x0000000185492020
		public override void SetFrom(TweenerCore<Vector3, Vector3, SpiralOptions> t, Vector3 fromValue, bool setImmediately, bool isRelative) {} // 0x0000000185492010-0x0000000185492020
		public static ABSTweenPlugin<Vector3, Vector3, SpiralOptions> Get() => default; // 0x000000018790943C-0x000000018790946C
		public override Vector3 ConvertToStartValue(TweenerCore<Vector3, Vector3, SpiralOptions> t, Vector3 value) => default; // 0x0000000185FB6880-0x0000000185FB68A0
		public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3, SpiralOptions> t) {} // 0x0000000185492010-0x0000000185492020
		public override void SetChangeValue(TweenerCore<Vector3, Vector3, SpiralOptions> t) {} // 0x000000018790946C-0x00000001879094FC
		public override float GetSpeedBasedDuration(SpiralOptions options, float unitsXSecond, Vector3 changeValue) => default; // 0x0000000185FB68A0-0x0000000185FB68B0
		public override void EvaluateAndApply(SpiralOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x00000001879090F4-0x000000018790943C
	}
}
