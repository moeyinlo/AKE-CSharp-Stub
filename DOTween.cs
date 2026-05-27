/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;

// Image 41: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 55695-55895
[assembly: AssemblyCompany("Demigiant")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCopyright("Copyright \u00A9 Daniele Giardini, 2014")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyProduct("DOTween")]
[assembly: AssemblyTitle("DOTween")]
[assembly: AssemblyTrademark("")]
[assembly: CompilationRelaxations(8)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: Guid("807e068c-2a0e-4c81-a303-4b4fd3924511")]
[assembly: InternalsVisibleTo("DOTweenEditor")]
[assembly: InternalsVisibleTo("DOTween43")]
[assembly: InternalsVisibleTo("DOTween46")]
[assembly: InternalsVisibleTo("DOTween50")]
[assembly: InternalsVisibleTo("DOTweenPro")]
[assembly: InternalsVisibleTo("DOTweenProEditor")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace DG.Tweening
{
	public enum AutoPlay // TypeDefIndex: 55696
	{
		None = 0,
		AutoPlaySequences = 1,
		AutoPlayTweeners = 2,
		All = 3
	}

	[Flags]
	public enum AxisConstraint // TypeDefIndex: 55697
	{
		None = 0,
		X = 2,
		Y = 4,
		Z = 8,
		W = 16
	}

	public struct Color2 // TypeDefIndex: 55698
	{
		// Fields
		public UnityEngine.Color ca; // 0x00
		public UnityEngine.Color cb; // 0x10
	
		// Constructors
		public Color2(UnityEngine.Color ca, UnityEngine.Color cb) {
			this.ca = default;
			this.cb = default;
		} // 0x0000000183D553F0-0x0000000183D55400
	
		// Methods
		public static Color2 operator +(Color2 c1, Color2 c2) => default; // 0x000000018573D1D4-0x000000018573D250
		public static Color2 operator -(Color2 c1, Color2 c2) => default; // 0x000000018573D2B0-0x000000018573D32C
		public static Color2 operator *(Color2 c1, float f) => default; // 0x000000018573D250-0x000000018573D2B0
	}

	public delegate void TweenCallback(); // TypeDefIndex: 55699; 0x00000001842BE03C-0x00000001842BE04C

	public delegate void TweenCallback<in T>(T value); // TypeDefIndex: 55700; 0x00000000-0x00000000

	public delegate float EaseFunction(float time, float duration, float overshootOrAmplitude, float period); // TypeDefIndex: 55701; 0x0000000185741860-0x0000000185741874

	public static class DOCurve // TypeDefIndex: 55703
	{
		// Nested types
		public static class CubicBezier // TypeDefIndex: 55702
		{
			// Methods
			public static Vector3 GetPointOnSegment(Vector3 startPoint, Vector3 startControlPoint, Vector3 endPoint, Vector3 endControlPoint, float factor) => default; // 0x000000018573D32C-0x000000018573D4BC
			public static Vector3[] GetSegmentPointCloud(Vector3 startPoint, Vector3 startControlPoint, Vector3 endPoint, Vector3 endControlPoint, int resolution = 10 /* Metadata: 0x01FD755F */) => default; // 0x000000018573D4BC-0x000000018573D620
			public static void GetSegmentPointCloud(List<Vector3> addToList, Vector3 startPoint, Vector3 startControlPoint, Vector3 endPoint, Vector3 endControlPoint, int resolution = 10 /* Metadata: 0x01FD7560 */) {} // 0x000000018573D620-0x000000018573D770
		}
	}

	public class DOTween // TypeDefIndex: 55705
	{
		// Fields
		public static readonly string Version; // 0x00
		public static bool useSafeMode; // 0x08
		public static SafeModeLogBehaviour safeModeLogBehaviour; // 0x0C
		public static NestedTweenFailureBehaviour nestedTweenFailureBehaviour; // 0x10
		public static bool showUnityEditorReport; // 0x14
		public static float timeScale; // 0x18
		public static float unscaledTimeScale; // 0x1C
		public static bool useSmoothDeltaTime; // 0x20
		public static float maxSmoothUnscaledTime; // 0x24
		internal static RewindCallbackMode rewindCallbackMode; // 0x28
		private static LogBehaviour _logBehaviour; // 0x2C
		public static Func<UnityEngine.LogType, object, bool> onWillLog; // 0x30
		public static bool drawGizmos; // 0x38
		public static bool debugMode; // 0x39
		private static bool _fooDebugStoreTargetId; // 0x3A
		public static DG.Tweening.UpdateType defaultUpdateType; // 0x3C
		public static bool defaultTimeScaleIndependent; // 0x40
		public static AutoPlay defaultAutoPlay; // 0x44
		public static bool defaultAutoKill; // 0x48
		public static LoopType defaultLoopType; // 0x4C
		public static bool defaultRecyclable; // 0x50
		public static Ease defaultEaseType; // 0x54
		public static float defaultEaseOvershootOrAmplitude; // 0x58
		public static float defaultEasePeriod; // 0x5C
		public static DOTweenComponent instance; // 0x60
		private static bool _foo_isQuitting; // 0x68
		internal static int maxActiveTweenersReached; // 0x6C
		internal static int maxActiveSequencesReached; // 0x70
		internal static SafeModeReport safeModeReport; // 0x74
		internal static readonly List<TweenCallback> GizmosDelegates; // 0x88
		internal static bool initialized; // 0x90
		private static int _isQuittingFrame; // 0x94
	
		// Properties
		public static LogBehaviour logBehaviour { get => default; set {} } // 0x0000000185740534-0x0000000185740584 0x0000000182968CB0-0x0000000182968D50
		public static bool debugStoreTargetId { get => default; set {} } // 0x00000001834728C0-0x0000000183472920 0x0000000185740584-0x00000001857405D8
		internal static bool isQuitting { get => default; set {} } // 0x0000000182968DA0-0x0000000182968EA0 0x00000001857405D8-0x000000018574064C
	
		// Constructors
		public DOTween() {} // 0x000000018350B670-0x000000018350B680
		static DOTween() {} // 0x00000001839D7090-0x00000001839D7300
	
		// Methods
		public static IDOTweenInit Init(bool? recycleAllByDefault = default, bool? useSafeMode = default, LogBehaviour? logBehaviour = default) => default; // 0x000000018573DEE0-0x000000018573DFEC
		private static void AutoInit() {} // 0x00000001829695E0-0x00000001829696B0
		private static IDOTweenInit Init(DOTweenSettings settings, bool? recycleAllByDefault, bool? useSafeMode, LogBehaviour? logBehaviour) => default; // 0x0000000182968EA0-0x00000001829692D0
		public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity) {} // 0x000000018573EE7C-0x000000018573EED4
		public static void Clear(bool destroy = false /* Metadata: 0x01FD7561 */) {} // 0x000000018573DA44-0x000000018573DA90
		internal static void Clear(bool destroy, bool isApplicationQuitting) {} // 0x000000018573D7B0-0x000000018573DA44
		public static void ClearCachedTweens() {} // 0x000000018573D770-0x000000018573D7B0
		public static int Validate() => default; // 0x00000001857404F4-0x0000000185740534
		public static void ManualUpdate(float deltaTime, float unscaledDeltaTime) {} // 0x000000018573E204-0x000000018573E2FC
		public static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration) => default; // 0x00000001825CBEF0-0x00000001825CBF90
		public static TweenerCore<double, double, NoOptions> To(DOGetter<double> getter, DOSetter<double> setter, double endValue, float duration) => default; // 0x000000018574006C-0x00000001857400F8
		public static TweenerCore<int, int, NoOptions> To(DOGetter<int> getter, DOSetter<int> setter, int endValue, float duration) => default; // 0x000000018573FF40-0x000000018573FFCC
		public static TweenerCore<uint, uint, UintOptions> To(DOGetter<uint> getter, DOSetter<uint> setter, uint endValue, float duration) => default; // 0x000000018573FB14-0x000000018573FBA0
		public static TweenerCore<long, long, NoOptions> To(DOGetter<long> getter, DOSetter<long> setter, long endValue, float duration) => default; // 0x000000018573FA00-0x000000018573FA8C
		public static TweenerCore<ulong, ulong, NoOptions> To(DOGetter<ulong> getter, DOSetter<ulong> setter, ulong endValue, float duration) => default; // 0x000000018573FD50-0x000000018573FDDC
		public static TweenerCore<string, string, StringOptions> To(DOGetter<string> getter, DOSetter<string> setter, string endValue, float duration) => default; // 0x000000018573FBA0-0x000000018573FC2C
		public static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration) => default; // 0x0000000182D50350-0x0000000182D503F0
		public static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration) => default; // 0x0000000182D4C810-0x0000000182D4C8C0
		public static TweenerCore<Vector4, Vector4, VectorOptions> To(DOGetter<Vector4> getter, DOSetter<Vector4> setter, Vector4 endValue, float duration) => default; // 0x00000001857400F8-0x0000000185740190
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration) => default; // 0x0000000182D4B2D0-0x0000000182D4B380
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> To(DOGetter<UnityEngine.Color> getter, DOSetter<UnityEngine.Color> setter, UnityEngine.Color endValue, float duration) => default; // 0x000000018573FA8C-0x000000018573FB14
		public static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration) => default; // 0x000000018573FCB8-0x000000018573FD50
		public static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration) => default; // 0x000000018573FC2C-0x000000018573FCB8
		public static TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration)
			where TPlugOptions : struct, IPlugOptions => default;
		public static TweenerCore<Vector3, Vector3, VectorOptions> ToAxis(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float endValue, float duration, AxisConstraint axisConstraint = AxisConstraint.None | AxisConstraint.X /* Metadata: 0x01FD7562 */) => default; // 0x000000018573F954-0x000000018573FA00
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> ToAlpha(DOGetter<UnityEngine.Color> getter, DOSetter<UnityEngine.Color> setter, float endValue, float duration) => default; // 0x0000000182D4CD30-0x0000000182D4CE10
		public static Tweener To(DOSetter<float> setter, float startValue, float endValue, float duration) => default; // 0x000000018573FDDC-0x000000018573FF40
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10 /* Metadata: 0x01FD7563 */, float elasticity = 1f /* Metadata: 0x01FD7564 */) => default; // 0x000000018573E874-0x000000018573EBC0
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3f /* Metadata: 0x01FD7568 */, int vibrato = 10 /* Metadata: 0x01FD756C */, float randomness = 90f /* Metadata: 0x01FD756D */, bool ignoreZAxis = true /* Metadata: 0x01FD7571 */, bool fadeOut = true /* Metadata: 0x01FD7572 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x01FD7573 */) => default; // 0x000000018573F5B8-0x000000018573F68C
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x01FD7574 */, float randomness = 90f /* Metadata: 0x01FD7575 */, bool fadeOut = true /* Metadata: 0x01FD7579 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x01FD757A */) => default; // 0x000000018573F4EC-0x000000018573F5B8
		private static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut, ShakeRandomnessMode randomnessMode) => default; // 0x000000018573EED4-0x000000018573F4EC
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3[] endValues, float[] durations) => default; // 0x000000018573F758-0x000000018573F954
		internal static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration) => default; // 0x000000018573FFCC-0x000000018574006C
		public static DG.Tweening.Sequence Sequence() => default; // 0x0000000182D4F770-0x0000000182D4F800
		public static DG.Tweening.Sequence Sequence(object target) => default; // 0x000000018573EE20-0x000000018573EE7C
		public static int CompleteAll(bool withCallbacks = false /* Metadata: 0x01FD757B */) => default; // 0x000000018573DA90-0x000000018573DAF8
		public static int Complete(object targetOrId, bool withCallbacks = false /* Metadata: 0x01FD757C */) => default; // 0x000000018573DCA8-0x000000018573DD24
		internal static int CompleteAndReturnKilledTot() => default; // 0x000000018573DBCC-0x000000018573DC28
		internal static int CompleteAndReturnKilledTot(object targetOrId) => default; // 0x000000018573DB5C-0x000000018573DBCC
		internal static int CompleteAndReturnKilledTot(object target, object id) => default; // 0x000000018573DC28-0x000000018573DCA8
		internal static int CompleteAndReturnKilledTotExceptFor(params object[] excludeTargetsOrIds) => default; // 0x000000018573DAF8-0x000000018573DB5C
		public static int FlipAll() => default; // 0x000000018573DD24-0x000000018573DD80
		public static int Flip(object targetOrId) => default; // 0x000000018573DD80-0x000000018573DDF0
		public static int GotoAll(float to, bool andPlay = false /* Metadata: 0x01FD757D */) => default; // 0x000000018573DDF0-0x000000018573DE5C
		public static int Goto(object targetOrId, float to, bool andPlay = false /* Metadata: 0x01FD757E */) => default; // 0x000000018573DE5C-0x000000018573DEE0
		public static int KillAll(bool complete = false /* Metadata: 0x01FD757F */) => default; // 0x0000000182C35F70-0x0000000182C35FD0
		public static int KillAll(bool complete, params object[] idsOrTargetsToExclude) => default; // 0x000000018573E064-0x000000018573E144
		public static int Kill(object targetOrId, bool complete = false /* Metadata: 0x01FD7580 */) => default; // 0x00000001825CF710-0x00000001825CF7C0
		public static int Kill(object target, object id, bool complete = false /* Metadata: 0x01FD7581 */) => default; // 0x000000018573E144-0x000000018573E204
		public static int PauseAll() => default; // 0x000000018573E2FC-0x000000018573E358
		public static int Pause(object targetOrId) => default; // 0x000000018573E358-0x000000018573E3C8
		public static int PlayAll() => default; // 0x000000018573E42C-0x000000018573E488
		public static int Play(object targetOrId) => default; // 0x000000018573E720-0x000000018573E790
		public static int Play(object target, object id) => default; // 0x000000018573E790-0x000000018573E810
		public static int PlayBackwardsAll() => default; // 0x000000018573E488-0x000000018573E4E4
		public static int PlayBackwards(object targetOrId) => default; // 0x000000018573E4E4-0x000000018573E554
		public static int PlayBackwards(object target, object id) => default; // 0x000000018573E554-0x000000018573E5D4
		public static int PlayForwardAll() => default; // 0x000000018573E5D4-0x000000018573E630
		public static int PlayForward(object targetOrId) => default; // 0x000000018573E630-0x000000018573E6A0
		public static int PlayForward(object target, object id) => default; // 0x000000018573E6A0-0x000000018573E720
		public static int RestartAll(bool includeDelay = true /* Metadata: 0x01FD7582 */) => default; // 0x000000018573EBC0-0x000000018573EC24
		public static int Restart(object targetOrId, bool includeDelay = true /* Metadata: 0x01FD7583 */, float changeDelayTo = -1f /* Metadata: 0x01FD7584 */) => default; // 0x000000018573ECBC-0x000000018573ED40
		public static int Restart(object target, object id, bool includeDelay = true /* Metadata: 0x01FD7588 */, float changeDelayTo = -1f /* Metadata: 0x01FD7589 */) => default; // 0x000000018573EC24-0x000000018573ECBC
		public static int RewindAll(bool includeDelay = true /* Metadata: 0x01FD758D */) => default; // 0x000000018573ED40-0x000000018573EDA4
		public static int Rewind(object targetOrId, bool includeDelay = true /* Metadata: 0x01FD758E */) => default; // 0x000000018573EDA4-0x000000018573EE20
		public static int SmoothRewindAll() => default; // 0x000000018573F68C-0x000000018573F6E8
		public static int SmoothRewind(object targetOrId) => default; // 0x000000018573F6E8-0x000000018573F758
		public static int TogglePauseAll() => default; // 0x0000000185740190-0x00000001857401EC
		public static int TogglePause(object targetOrId) => default; // 0x00000001857401EC-0x000000018574025C
		public static bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying = false /* Metadata: 0x01FD758F */) => default; // 0x000000018573DFEC-0x000000018573E064
		public static int TotalActiveTweens() => default; // 0x00000001857402FC-0x000000018574034C
		public static int TotalActiveTweeners() => default; // 0x00000001857402AC-0x00000001857402FC
		public static int TotalActiveSequences() => default; // 0x000000018574025C-0x00000001857402AC
		public static int TotalPlayingTweens() => default; // 0x000000018574034C-0x000000018574038C
		public static int TotalTweensById(object id, bool playingOnly = false /* Metadata: 0x01FD7590 */) => default; // 0x000000018574038C-0x00000001857403E8
		public static List<DG.Tweening.Tween> PlayingTweens(List<DG.Tweening.Tween> fillableList = null) => default; // 0x000000018573E810-0x000000018573E874
		public static List<DG.Tweening.Tween> PausedTweens(List<DG.Tweening.Tween> fillableList = null) => default; // 0x000000018573E3C8-0x000000018573E42C
		public static List<DG.Tweening.Tween> TweensById(object id, bool playingOnly = false /* Metadata: 0x01FD7591 */, List<DG.Tweening.Tween> fillableList = null) => default; // 0x00000001857403E8-0x0000000185740474
		public static List<DG.Tweening.Tween> TweensByTarget(object target, bool playingOnly = false /* Metadata: 0x01FD7592 */, List<DG.Tweening.Tween> fillableList = null) => default; // 0x0000000185740474-0x00000001857404F4
		private static void InitCheck() {} // 0x0000000182D4FD00-0x0000000182D4FDB0
		private static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null)
			where TPlugOptions : struct, IPlugOptions => default;
	}

	public static class DOVirtual // TypeDefIndex: 55710
	{
		// Methods
		public static Tweener Float(float from, float to, float duration, TweenCallback<float> onVirtualUpdate) => default; // 0x000000018574107C-0x0000000185741230
		public static Tweener Int(int from, int to, float duration, TweenCallback<int> onVirtualUpdate) => default; // 0x0000000185741230-0x00000001857413D0
		public static Tweener Vector3(Vector3 from, Vector3 to, float duration, TweenCallback<Vector3> onVirtualUpdate) => default; // 0x00000001857413D0-0x0000000185741594
		public static Tweener Color(UnityEngine.Color from, UnityEngine.Color to, float duration, TweenCallback<UnityEngine.Color> onVirtualUpdate) => default; // 0x000000018574064C-0x0000000185740800
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType) => default; // 0x00000001825D0DE0-0x00000001825D0EB0
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float overshoot) => default; // 0x0000000185740C48-0x0000000185740CF8
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float amplitude, float period) => default; // 0x0000000185741014-0x000000018574107C
		public static float EasedValue(float from, float to, float lifetimePercentage, AnimationCurve easeCurve) => default; // 0x00000001857409C8-0x0000000185740B00
		public static Vector3 EasedValue(Vector3 from, Vector3 to, float lifetimePercentage, Ease easeType) => default; // 0x0000000185740ECC-0x0000000185741014
		public static Vector3 EasedValue(Vector3 from, Vector3 to, float lifetimePercentage, Ease easeType, float overshoot) => default; // 0x0000000185740B00-0x0000000185740C48
		public static Vector3 EasedValue(Vector3 from, Vector3 to, float lifetimePercentage, Ease easeType, float amplitude, float period) => default; // 0x00000001857408C0-0x00000001857409C8
		public static Vector3 EasedValue(Vector3 from, Vector3 to, float lifetimePercentage, AnimationCurve easeCurve) => default; // 0x0000000185740CF8-0x0000000185740ECC
		public static DG.Tweening.Tween DelayedCall(float delay, TweenCallback callback, bool ignoreTimeScale = true /* Metadata: 0x01FD7593 */) => default; // 0x0000000185740800-0x00000001857408C0
	}

	public enum Ease // TypeDefIndex: 55711
	{
		Unset = 0,
		Linear = 1,
		InSine = 2,
		OutSine = 3,
		InOutSine = 4,
		InQuad = 5,
		OutQuad = 6,
		InOutQuad = 7,
		InCubic = 8,
		OutCubic = 9,
		InOutCubic = 10,
		InQuart = 11,
		OutQuart = 12,
		InOutQuart = 13,
		InQuint = 14,
		OutQuint = 15,
		InOutQuint = 16,
		InExpo = 17,
		OutExpo = 18,
		InOutExpo = 19,
		InCirc = 20,
		OutCirc = 21,
		InOutCirc = 22,
		InElastic = 23,
		OutElastic = 24,
		InOutElastic = 25,
		InBack = 26,
		OutBack = 27,
		InOutBack = 28,
		InBounce = 29,
		OutBounce = 30,
		InOutBounce = 31,
		Flash = 32,
		InFlash = 33,
		OutFlash = 34,
		InOutFlash = 35,
		INTERNAL_Zero = 36,
		INTERNAL_Custom = 37
	}

	public class EaseFactory // TypeDefIndex: 55713
	{
		// Constructors
		public EaseFactory() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static EaseFunction StopMotion(int motionFps, Ease? ease = default) => default; // 0x0000000185741658-0x00000001857416F4
		public static EaseFunction StopMotion(int motionFps, AnimationCurve animCurve) => default; // 0x00000001857416F4-0x00000001857417AC
		public static EaseFunction StopMotion(int motionFps, EaseFunction customEase) => default; // 0x0000000185741594-0x0000000185741658
	}

	public interface IDOTweenInit // TypeDefIndex: 55714
	{
		// Methods
		IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity);
	}

	public enum LinkBehaviour // TypeDefIndex: 55715
	{
		PauseOnDisable = 0,
		PauseOnDisablePlayOnEnable = 1,
		PauseOnDisableRestartOnEnable = 2,
		PlayOnEnable = 3,
		RestartOnEnable = 4,
		KillOnDisable = 5,
		KillOnDestroy = 6,
		CompleteOnDisable = 7,
		CompleteAndKillOnDisable = 8,
		RewindOnDisable = 9,
		RewindAndKillOnDisable = 10
	}

	public enum PathMode // TypeDefIndex: 55716
	{
		Ignore = 0,
		Full3D = 1,
		TopDown2D = 2,
		Sidescroller2D = 3
	}

	public enum PathType // TypeDefIndex: 55717
	{
		Linear = 0,
		CatmullRom = 1,
		CubicBezier = 2
	}

	public enum RotateMode // TypeDefIndex: 55718
	{
		Fast = 0,
		FastBeyond360 = 1,
		WorldAxisAdd = 2,
		LocalAxisAdd = 3
	}

	public enum ScrambleMode // TypeDefIndex: 55719
	{
		None = 0,
		All = 1,
		Uppercase = 2,
		Lowercase = 3,
		Numerals = 4,
		Custom = 5
	}

	public enum ShakeRandomnessMode // TypeDefIndex: 55720
	{
		Full = 0,
		Harmonic = 1
	}

	public static class TweenExtensions // TypeDefIndex: 55721
	{
		// Methods
		private static void DoGoto(DG.Tweening.Tween t, float to, bool andPlay, bool withCallbacks) {} // 0x000000018574A680-0x000000018574A788
	
		// Extension methods
		public static void Complete(this DG.Tweening.Tween t) {} // 0x000000018574A540-0x000000018574A54C
		public static void Complete(this DG.Tweening.Tween t, bool withCallbacks) {} // 0x000000018574A54C-0x000000018574A5FC
		public static void Flip(this DG.Tweening.Tween t) {} // 0x000000018574A9EC-0x000000018574AA90
		public static void ForceInit(this DG.Tweening.Tween t) {} // 0x000000018574AA90-0x000000018574AB38
		public static void Goto(this DG.Tweening.Tween t, float to, bool andPlay = false /* Metadata: 0x01FD75D8 */) {} // 0x000000018574ADBC-0x000000018574ADD8
		public static void GotoWithCallbacks(this DG.Tweening.Tween t, float to, bool andPlay = false /* Metadata: 0x01FD75D9 */) {} // 0x000000018574ADA0-0x000000018574ADBC
		public static void Kill(this DG.Tweening.Tween t, bool complete = false /* Metadata: 0x01FD75DA */) {} // 0x00000001825CE6A0-0x00000001825CE850
		public static void ManualUpdate(this DG.Tweening.Tween t, float deltaTime, float unscaledDeltaTime) {} // 0x000000018574AE98-0x000000018574AF58
		public static T Pause<T>(this T t)
			where T : DG.Tweening.Tween => default;
		public static T Play<T>(this T t)
			where T : DG.Tweening.Tween => default;
		public static void PlayBackwards(this DG.Tweening.Tween t) {} // 0x000000018574B2D4-0x000000018574B378
		public static void PlayForward(this DG.Tweening.Tween t) {} // 0x000000018574B378-0x000000018574B41C
		public static void Restart(this DG.Tweening.Tween t, bool includeDelay = true /* Metadata: 0x01FD75DB */, float changeDelayTo = -1f /* Metadata: 0x01FD75DC */) {} // 0x000000018351A7E0-0x000000018351A880
		public static void Rewind(this DG.Tweening.Tween t, bool includeDelay = true /* Metadata: 0x01FD75E0 */) {} // 0x000000018574B41C-0x000000018574B4C8
		public static void SmoothRewind(this DG.Tweening.Tween t) {} // 0x000000018574B4C8-0x000000018574B56C
		public static void TogglePause(this DG.Tweening.Tween t) {} // 0x000000018574B56C-0x000000018574B610
		public static void GotoWaypoint(this DG.Tweening.Tween t, int waypointIndex, bool andPlay = false /* Metadata: 0x01FD75E1 */) {} // 0x000000018574AB38-0x000000018574ADA0
		public static YieldInstruction WaitForCompletion(this DG.Tweening.Tween t) => default; // 0x000000018574B610-0x000000018574B6B0
		public static YieldInstruction WaitForRewind(this DG.Tweening.Tween t) => default; // 0x000000018574B8B0-0x000000018574B950
		public static YieldInstruction WaitForKill(this DG.Tweening.Tween t) => default; // 0x000000018574B760-0x000000018574B800
		public static YieldInstruction WaitForElapsedLoops(this DG.Tweening.Tween t, int elapsedLoops) => default; // 0x000000018574B6B0-0x000000018574B760
		public static YieldInstruction WaitForPosition(this DG.Tweening.Tween t, float position) => default; // 0x000000018574B800-0x000000018574B8B0
		public static Coroutine WaitForStart(this DG.Tweening.Tween t) => default; // 0x000000018574B950-0x000000018574B9F0
		public static int CompletedLoops(this DG.Tweening.Tween t) => default; // 0x000000018574A5FC-0x000000018574A63C
		public static float Delay(this DG.Tweening.Tween t) => default; // 0x000000018574A63C-0x000000018574A680
		public static float ElapsedDelay(this DG.Tweening.Tween t) => default; // 0x000000018574A7F8-0x000000018574A83C
		public static float Duration(this DG.Tweening.Tween t, bool includeLoops = true /* Metadata: 0x01FD75E2 */) => default; // 0x000000018574A788-0x000000018574A7F8
		public static float Elapsed(this DG.Tweening.Tween t, bool includeLoops = true /* Metadata: 0x01FD75E3 */) => default; // 0x000000018574A97C-0x000000018574A9EC
		public static float ElapsedPercentage(this DG.Tweening.Tween t, bool includeLoops = true /* Metadata: 0x01FD75E4 */) => default; // 0x000000018574A8DC-0x000000018574A97C
		public static float ElapsedDirectionalPercentage(this DG.Tweening.Tween t) => default; // 0x000000018574A83C-0x000000018574A8DC
		public static bool IsActive(this DG.Tweening.Tween t) => default; // 0x00000001828C0DA0-0x00000001828C0DB0
		public static bool IsBackwards(this DG.Tweening.Tween t) => default; // 0x000000018574ADD8-0x000000018574AE18
		public static bool IsComplete(this DG.Tweening.Tween t) => default; // 0x000000018284E8C0-0x000000018284E8F0
		public static bool IsInitialized(this DG.Tweening.Tween t) => default; // 0x000000018574AE18-0x000000018574AE58
		public static bool IsPlaying(this DG.Tweening.Tween t) => default; // 0x00000001828C0140-0x00000001828C0170
		public static int Loops(this DG.Tweening.Tween t) => default; // 0x000000018574AE58-0x000000018574AE98
		public static Vector3 PathGetPoint(this DG.Tweening.Tween t, float pathPercentage) => default; // 0x000000018574B068-0x000000018574B1CC
		public static Vector3[] PathGetDrawPoints(this DG.Tweening.Tween t, int subdivisionsXSegment = 10 /* Metadata: 0x01FD75E5 */) => default; // 0x000000018574AF58-0x000000018574B068
		public static float PathLength(this DG.Tweening.Tween t) => default; // 0x000000018574B1CC-0x000000018574B2D4
	}

	public enum LoopType // TypeDefIndex: 55722
	{
		Restart = 0,
		Yoyo = 1,
		Incremental = 2
	}

	public sealed class Sequence : DG.Tweening.Tween // TypeDefIndex: 55723
	{
		// Fields
		internal readonly List<DG.Tweening.Tween> sequencedTweens; // 0x120
		private readonly List<ABSSequentiable> _sequencedObjs; // 0x128
		internal float lastTweenInsertTime; // 0x130
	
		// Constructors
		internal Sequence() {} // 0x0000000182D4FDB0-0x0000000182D4FEC0
	
		// Methods
		internal static Sequence DoPrepend(Sequence inSequence, DG.Tweening.Tween t) => default; // 0x000000018574194C-0x0000000185741A88
		internal static Sequence DoInsert(Sequence inSequence, DG.Tweening.Tween t, float atPosition) => default; // 0x0000000182D4F4D0-0x0000000182D4F670
		internal static Sequence DoAppendInterval(Sequence inSequence, float interval) => default; // 0x0000000182D4DFF0-0x0000000182D4E030
		internal static Sequence DoPrependInterval(Sequence inSequence, float interval) => default; // 0x0000000185741874-0x000000018574194C
		internal static Sequence DoInsertCallback(Sequence inSequence, TweenCallback callback, float atPosition) => default; // 0x0000000182D4C8E0-0x0000000182D4C9B0
		internal override float UpdateDelay(float elapsed) => default; // 0x0000000185741A88-0x0000000185741AB8
		internal override void Reset() {} // 0x0000000182FBDC70-0x0000000182FBDD00
		internal override bool Validate() => default; // 0x0000000185741AB8-0x0000000185741B5C
		internal override bool Startup() => default; // 0x00000001835311E0-0x00000001835311F0
		internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, UpdateNotice updateNotice) => default; // 0x00000001825D25C0-0x00000001825D25E0
		internal static void Setup(Sequence s) {} // 0x0000000182D4FEC0-0x0000000182D50010
		internal static bool DoStartup(Sequence s) => default; // 0x00000001835311F0-0x0000000183531340
		internal static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode) => default; // 0x00000001825D25E0-0x00000001825D2930
		private static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, DG.Tweening.Core.Enums.UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = false /* Metadata: 0x01FD75E9 */) => default; // 0x00000001825D2930-0x00000001825D2DC0
		private static void StableSortSequencedObjs(List<ABSSequentiable> list) {} // 0x0000000183531340-0x0000000183531440
		private static bool IsAnyCallbackSet(Sequence s) => default; // 0x0000000183531440-0x00000001835314A0
	}

	public static class ShortcutExtensions // TypeDefIndex: 55800
	{
		// Extension methods
		public static TweenerCore<float, float, FloatOptions> DOAspect(this Camera target, float endValue, float duration) => default; // 0x0000000185741B5C-0x0000000185741CB8
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(this Camera target, UnityEngine.Color endValue, float duration) => default; // 0x0000000185743500-0x0000000185743668
		public static TweenerCore<float, float, FloatOptions> DOFarClipPlane(this Camera target, float endValue, float duration) => default; // 0x0000000185743DC8-0x0000000185743F24
		public static TweenerCore<float, float, FloatOptions> DOFieldOfView(this Camera target, float endValue, float duration) => default; // 0x0000000185743F24-0x0000000185744080
		public static TweenerCore<float, float, FloatOptions> DONearClipPlane(this Camera target, float endValue, float duration) => default; // 0x000000018574622C-0x0000000185746388
		public static TweenerCore<float, float, FloatOptions> DOOrthoSize(this Camera target, float endValue, float duration) => default; // 0x0000000185746698-0x00000001857467F4
		public static TweenerCore<Rect, Rect, RectOptions> DOPixelRect(this Camera target, Rect endValue, float duration) => default; // 0x0000000185746C34-0x0000000185746D9C
		public static TweenerCore<Rect, Rect, RectOptions> DORect(this Camera target, Rect endValue, float duration) => default; // 0x000000018574750C-0x0000000185747674
		public static Tweener DOShakePosition(this Camera target, float duration, float strength = 3f /* Metadata: 0x01FD75EA */, int vibrato = 10 /* Metadata: 0x01FD75EE */, float randomness = 90f /* Metadata: 0x01FD75EF */, bool fadeOut = true /* Metadata: 0x01FD75F3 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x01FD75F4 */) => default; // 0x00000001857485FC-0x00000001857487FC
		public static Tweener DOShakePosition(this Camera target, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x01FD75F5 */, float randomness = 90f /* Metadata: 0x01FD75F6 */, bool fadeOut = true /* Metadata: 0x01FD75FA */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x01FD75FB */) => default; // 0x0000000185748A10-0x0000000185748C24
		public static Tweener DOShakeRotation(this Camera target, float duration, float strength = 90f /* Metadata: 0x01FD75FC */, int vibrato = 10 /* Metadata: 0x01FD7600 */, float randomness = 90f /* Metadata: 0x01FD7601 */, bool fadeOut = true /* Metadata: 0x01FD7605 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x01FD7606 */) => default; // 0x000000018574924C-0x000000018574944C
		public static Tweener DOShakeRotation(this Camera target, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x01FD7607 */, float randomness = 90f /* Metadata: 0x01FD7608 */, bool fadeOut = true /* Metadata: 0x01FD760C */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x01FD760D */) => default; // 0x0000000185748C24-0x0000000185748E38
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(this Light target, UnityEngine.Color endValue, float duration) => default; // 0x0000000185743398-0x0000000185743500
		public static TweenerCore<float, float, FloatOptions> DOIntensity(this Light target, float endValue, float duration) => default; // 0x0000000185744520-0x000000018574467C
		public static TweenerCore<float, float, FloatOptions> DOShadowStrength(this Light target, float endValue, float duration) => default; // 0x000000018574827C-0x00000001857483D8
		public static Tweener DOColor(this LineRenderer target, Color2 startValue, Color2 endValue, float duration) => default; // 0x0000000185742F0C-0x0000000185743088
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(this Material target, UnityEngine.Color endValue, float duration) => default; // 0x0000000185743088-0x00000001857431F0
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(this Material target, UnityEngine.Color endValue, string property, float duration) => default; // 0x0000000185743668-0x0000000185743820
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(this Material target, UnityEngine.Color endValue, int propertyID, float duration) => default; // 0x00000001857431F0-0x0000000185743398
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOFade(this Material target, float endValue, float duration) => default; // 0x0000000185743924-0x0000000185743A80
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOFade(this Material target, float endValue, string property, float duration) => default; // 0x0000000185743C1C-0x0000000185743DC8
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOFade(this Material target, float endValue, int propertyID, float duration) => default; // 0x0000000185743A80-0x0000000185743C1C
		public static TweenerCore<float, float, FloatOptions> DOFloat(this Material target, float endValue, string property, float duration) => default; // 0x00000001857442B4-0x0000000185744460
		public static TweenerCore<float, float, FloatOptions> DOFloat(this Material target, float endValue, int propertyID, float duration) => default; // 0x0000000185744118-0x00000001857442B4
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, float duration) => default; // 0x0000000185746388-0x00000001857464E8
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, string property, float duration) => default; // 0x00000001857464E8-0x0000000185746698
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, float duration) => default; // 0x0000000185749944-0x0000000185749AA4
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, string property, float duration) => default; // 0x0000000185749AA4-0x0000000185749C54
		public static TweenerCore<Vector4, Vector4, VectorOptions> DOVector(this Material target, Vector4 endValue, string property, float duration) => default; // 0x000000018574A14C-0x000000018574A304
		public static TweenerCore<Vector4, Vector4, VectorOptions> DOVector(this Material target, Vector4 endValue, int propertyID, float duration) => default; // 0x0000000185749FA4-0x000000018574A14C
		public static Tweener DOResize(this TrailRenderer target, float toStartWidth, float toEndWidth, float duration) => default; // 0x0000000185747674-0x00000001857477E0
		public static TweenerCore<float, float, FloatOptions> DOTime(this TrailRenderer target, float endValue, float duration) => default; // 0x0000000185749DB0-0x0000000185749F0C
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Transform target, Vector3 endValue, float duration, bool snapping = false /* Metadata: 0x01FD760E */) => default; // 0x0000000182D4B380-0x0000000182D4B520
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x01FD760F */) => default; // 0x0000000185745D44-0x0000000185745EE4
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x01FD7610 */) => default; // 0x0000000185745EE4-0x0000000185746088
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x01FD7611 */) => default; // 0x0000000185746088-0x000000018574622C
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMove(this Transform target, Vector3 endValue, float duration, bool snapping = false /* Metadata: 0x01FD7612 */) => default; // 0x0000000185745620-0x00000001857457B0
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveX(this Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x01FD7613 */) => default; // 0x0000000185745138-0x00000001857452D8
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveY(this Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x01FD7614 */) => default; // 0x00000001857452D8-0x000000018574547C
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveZ(this Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x01FD7615 */) => default; // 0x000000018574547C-0x0000000185745620
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Transform target, Vector3 endValue, float duration, DG.Tweening.RotateMode mode = DG.Tweening.RotateMode.Fast /* Metadata: 0x01FD7616 */) => default; // 0x0000000182D4B130-0x0000000182D4B2D0
		public static TweenerCore<Quaternion, Quaternion, NoOptions> DORotateQuaternion(this Transform target, Quaternion endValue, float duration) => default; // 0x0000000185747948-0x0000000185747AD4
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLocalRotate(this Transform target, Vector3 endValue, float duration, DG.Tweening.RotateMode mode = DG.Tweening.RotateMode.Fast /* Metadata: 0x01FD7617 */) => default; // 0x0000000185745B68-0x0000000185745CF8
		public static TweenerCore<Quaternion, Quaternion, NoOptions> DOLocalRotateQuaternion(this Transform target, Quaternion endValue, float duration) => default; // 0x0000000182D4AEC0-0x0000000182D4B060
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(this Transform target, Vector3 endValue, float duration) => default; // 0x000000018574810C-0x000000018574827C
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(this Transform target, float endValue, float duration) => default; // 0x0000000185747F9C-0x000000018574810C
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleX(this Transform target, float endValue, float duration) => default; // 0x0000000185747AD4-0x0000000185747C6C
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleY(this Transform target, float endValue, float duration) => default; // 0x0000000185747C6C-0x0000000185747E04
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleZ(this Transform target, float endValue, float duration) => default; // 0x0000000185747E04-0x0000000185747F9C
		public static Tweener DOLookAt(this Transform target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None /* Metadata: 0x01FD7618 */, Vector3? up = default) => default; // 0x0000000185745CF8-0x0000000185745D44
		public static Tweener DODynamicLookAt(this Transform target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None /* Metadata: 0x01FD7619 */, Vector3? up = default) => default; // 0x00000001857438D8-0x0000000185743924
		private static Tweener LookAt(this Transform target, Vector3 towards, float duration, AxisConstraint axisConstraint, Vector3? up, bool dynamic) => default; // 0x000000018574A304-0x000000018574A540
		public static Tweener DOPunchPosition(this Transform target, Vector3 punch, float duration, int vibrato = 10 /* Metadata: 0x01FD761A */, float elasticity = 1f /* Metadata: 0x01FD761B */, bool snapping = false /* Metadata: 0x01FD761F */) => default; // 0x0000000185746F64-0x0000000185747154
		public static Tweener DOPunchScale(this Transform target, Vector3 punch, float duration, int vibrato = 10 /* Metadata: 0x01FD7620 */, float elasticity = 1f /* Metadata: 0x01FD7621 */) => default; // 0x0000000185747330-0x000000018574750C
		public static Tweener DOPunchRotation(this Transform target, Vector3 punch, float duration, int vibrato = 10 /* Metadata: 0x01FD7625 */, float elasticity = 1f /* Metadata: 0x01FD7626 */) => default; // 0x0000000185747154-0x0000000185747330
		public static Tweener DOShakePosition(this Transform target, float duration, float strength = 1f /* Metadata: 0x01FD762A */, int vibrato = 10 /* Metadata: 0x01FD762E */, float randomness = 90f /* Metadata: 0x01FD762F */, bool snapping = false /* Metadata: 0x01FD7633 */, bool fadeOut = true /* Metadata: 0x01FD7634 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x01FD7635 */) => default; // 0x00000001857487FC-0x0000000185748A10
		public static Tweener DOShakePosition(this Transform target, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x01FD7636 */, float randomness = 90f /* Metadata: 0x01FD7637 */, bool snapping = false /* Metadata: 0x01FD763B */, bool fadeOut = true /* Metadata: 0x01FD763C */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x01FD763D */) => default; // 0x00000001857483D8-0x00000001857485FC
		public static Tweener DOShakeRotation(this Transform target, float duration, float strength = 90f /* Metadata: 0x01FD763E */, int vibrato = 10 /* Metadata: 0x01FD7642 */, float randomness = 90f /* Metadata: 0x01FD7643 */, bool fadeOut = true /* Metadata: 0x01FD7647 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x01FD7648 */) => default; // 0x0000000185748E38-0x0000000185749038
		public static Tweener DOShakeRotation(this Transform target, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x01FD7649 */, float randomness = 90f /* Metadata: 0x01FD764A */, bool fadeOut = true /* Metadata: 0x01FD764E */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x01FD764F */) => default; // 0x0000000185749038-0x000000018574924C
		public static Tweener DOShakeScale(this Transform target, float duration, float strength = 1f /* Metadata: 0x01FD7650 */, int vibrato = 10 /* Metadata: 0x01FD7654 */, float randomness = 90f /* Metadata: 0x01FD7655 */, bool fadeOut = true /* Metadata: 0x01FD7659 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x01FD765A */) => default; // 0x0000000185749660-0x00000001857498AC
		public static Tweener DOShakeScale(this Transform target, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x01FD765B */, float randomness = 90f /* Metadata: 0x01FD765C */, bool fadeOut = true /* Metadata: 0x01FD7660 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x01FD7661 */) => default; // 0x000000018574944C-0x0000000185749660
		public static DG.Tweening.Sequence DOJump(this Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false /* Metadata: 0x01FD7662 */) => default; // 0x000000018574467C-0x0000000185744BAC
		public static DG.Tweening.Sequence DOLocalJump(this Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false /* Metadata: 0x01FD7663 */) => default; // 0x0000000185744C08-0x0000000185745138
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Transform target, Vector3[] path, float duration, PathType pathType = PathType.Linear /* Metadata: 0x01FD7664 */, PathMode pathMode = PathMode.Full3D /* Metadata: 0x01FD7665 */, int resolution = 10 /* Metadata: 0x01FD7666 */, UnityEngine.Color? gizmoColor = default) => default; // 0x0000000185746988-0x0000000185746B9C
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Transform target, Vector3[] path, float duration, PathType pathType = PathType.Linear /* Metadata: 0x01FD7667 */, PathMode pathMode = PathMode.Full3D /* Metadata: 0x01FD7668 */, int resolution = 10 /* Metadata: 0x01FD7669 */, UnityEngine.Color? gizmoColor = default) => default; // 0x00000001857457B0-0x00000001857459CC
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Transform target, Path path, float duration, PathMode pathMode = PathMode.Full3D /* Metadata: 0x01FD766A */) => default; // 0x00000001857467F4-0x0000000185746988
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Transform target, Path path, float duration, PathMode pathMode = PathMode.Full3D /* Metadata: 0x01FD766B */) => default; // 0x00000001857459CC-0x0000000185745B68
		public static TweenerCore<float, float, FloatOptions> DOTimeScale(this DG.Tweening.Tween target, float endValue, float duration) => default; // 0x0000000185749C54-0x0000000185749DB0
		public static Tweener DOBlendableColor(this Light target, UnityEngine.Color endValue, float duration) => default; // 0x0000000185741EC8-0x0000000185742094
		public static Tweener DOBlendableColor(this Material target, UnityEngine.Color endValue, float duration) => default; // 0x00000001857422B4-0x0000000185742480
		public static Tweener DOBlendableColor(this Material target, UnityEngine.Color endValue, string property, float duration) => default; // 0x0000000185742094-0x00000001857422B4
		public static Tweener DOBlendableColor(this Material target, UnityEngine.Color endValue, int propertyID, float duration) => default; // 0x0000000185741CB8-0x0000000185741EC8
		public static Tweener DOBlendableMoveBy(this Transform target, Vector3 byValue, float duration, bool snapping = false /* Metadata: 0x01FD766C */) => default; // 0x00000001857427F0-0x00000001857429AC
		public static Tweener DOBlendableLocalMoveBy(this Transform target, Vector3 byValue, float duration, bool snapping = false /* Metadata: 0x01FD766D */) => default; // 0x0000000185742480-0x000000018574263C
		public static Tweener DOBlendableRotateBy(this Transform target, Vector3 byValue, float duration, DG.Tweening.RotateMode mode = DG.Tweening.RotateMode.Fast /* Metadata: 0x01FD766E */) => default; // 0x0000000185742BB8-0x0000000185742D6C
		public static Tweener DOBlendableLocalRotateBy(this Transform target, Vector3 byValue, float duration, DG.Tweening.RotateMode mode = DG.Tweening.RotateMode.Fast /* Metadata: 0x01FD766F */) => default; // 0x000000018574263C-0x00000001857427F0
		public static Tweener DOBlendablePunchRotation(this Transform target, Vector3 punch, float duration, int vibrato = 10 /* Metadata: 0x01FD7670 */, float elasticity = 1f /* Metadata: 0x01FD7671 */) => default; // 0x00000001857429AC-0x0000000185742BB8
		public static Tweener DOBlendableScaleBy(this Transform target, Vector3 byValue, float duration) => default; // 0x0000000185742D6C-0x0000000185742F0C
		public static int DOComplete(this Component target, bool withCallbacks = false /* Metadata: 0x01FD7675 */) => default; // 0x000000018574387C-0x00000001857438D8
		public static int DOComplete(this Material target, bool withCallbacks = false /* Metadata: 0x01FD7676 */) => default; // 0x0000000185743820-0x000000018574387C
		public static int DOKill(this Component target, bool complete = false /* Metadata: 0x01FD7677 */) => default; // 0x00000001825CF6B0-0x00000001825CF710
		public static int DOKill(this Material target, bool complete = false /* Metadata: 0x01FD7678 */) => default; // 0x0000000185744BAC-0x0000000185744C08
		public static int DOFlip(this Component target) => default; // 0x0000000185744080-0x00000001857440CC
		public static int DOFlip(this Material target) => default; // 0x00000001857440CC-0x0000000185744118
		public static int DOGoto(this Component target, float to, bool andPlay = false /* Metadata: 0x01FD7679 */) => default; // 0x00000001857444C0-0x0000000185744520
		public static int DOGoto(this Material target, float to, bool andPlay = false /* Metadata: 0x01FD767A */) => default; // 0x0000000185744460-0x00000001857444C0
		public static int DOPause(this Component target) => default; // 0x0000000185746B9C-0x0000000185746BE8
		public static int DOPause(this Material target) => default; // 0x0000000185746BE8-0x0000000185746C34
		public static int DOPlay(this Component target) => default; // 0x0000000185746F18-0x0000000185746F64
		public static int DOPlay(this Material target) => default; // 0x0000000185746ECC-0x0000000185746F18
		public static int DOPlayBackwards(this Component target) => default; // 0x0000000185746D9C-0x0000000185746DE8
		public static int DOPlayBackwards(this Material target) => default; // 0x0000000185746DE8-0x0000000185746E34
		public static int DOPlayForward(this Component target) => default; // 0x0000000185746E80-0x0000000185746ECC
		public static int DOPlayForward(this Material target) => default; // 0x0000000185746E34-0x0000000185746E80
		public static int DORestart(this Component target, bool includeDelay = true /* Metadata: 0x01FD767B */) => default; // 0x00000001857477E0-0x0000000185747838
		public static int DORestart(this Material target, bool includeDelay = true /* Metadata: 0x01FD767C */) => default; // 0x0000000185747838-0x0000000185747890
		public static int DORewind(this Component target, bool includeDelay = true /* Metadata: 0x01FD767D */) => default; // 0x00000001857478EC-0x0000000185747948
		public static int DORewind(this Material target, bool includeDelay = true /* Metadata: 0x01FD767E */) => default; // 0x0000000185747890-0x00000001857478EC
		public static int DOSmoothRewind(this Component target) => default; // 0x00000001857498AC-0x00000001857498F8
		public static int DOSmoothRewind(this Material target) => default; // 0x00000001857498F8-0x0000000185749944
		public static int DOTogglePause(this Component target) => default; // 0x0000000185749F0C-0x0000000185749F58
		public static int DOTogglePause(this Material target) => default; // 0x0000000185749F58-0x0000000185749FA4
	}

	public class TweenParams // TypeDefIndex: 55801
	{
		// Fields
		public static readonly TweenParams Params; // 0x00
		internal object id; // 0x10
		internal string stringId; // 0x18
		internal int intId; // 0x20
		internal object target; // 0x28
		internal DG.Tweening.UpdateType updateType; // 0x30
		internal bool isIndependentUpdate; // 0x34
		internal TweenCallback onStart; // 0x38
		internal TweenCallback onPlay; // 0x40
		internal TweenCallback onRewind; // 0x48
		internal TweenCallback onUpdate; // 0x50
		internal TweenCallback onStepComplete; // 0x58
		internal TweenCallback onComplete; // 0x60
		internal TweenCallback onKill; // 0x68
		internal TweenCallback<int> onWaypointChange; // 0x70
		internal bool isRecyclable; // 0x78
		internal bool isSpeedBased; // 0x79
		internal bool autoKill; // 0x7A
		internal int loops; // 0x7C
		internal LoopType loopType; // 0x80
		internal float delay; // 0x84
		internal bool isRelative; // 0x88
		internal Ease easeType; // 0x8C
		internal EaseFunction customEase; // 0x90
		internal float easeOvershootOrAmplitude; // 0x98
		internal float easePeriod; // 0x9C
	
		// Constructors
		public TweenParams() {} // 0x000000018574C014-0x000000018574C024
		static TweenParams() {} // 0x000000018574BFA4-0x000000018574C014
	
		// Methods
		public TweenParams Clear() => default; // 0x000000018574B9F0-0x000000018574BB94
		public TweenParams SetAutoKill(bool autoKillOnCompletion = true /* Metadata: 0x01FD767F */) => default; // 0x0000000183D55400-0x0000000183D55410
		public TweenParams SetId(object objectId) => default; // 0x000000018574BE68-0x000000018574BE84
		public TweenParams SetId(string stringId) => default; // 0x000000018574BE84-0x000000018574BEA0
		public TweenParams SetId(int intId) => default; // 0x0000000183D55420-0x0000000183D55430
		public TweenParams SetTarget(object target) => default; // 0x000000018574BF28-0x000000018574BF44
		public TweenParams SetLoops(int loops, LoopType? loopType = default) => default; // 0x000000018574BEA0-0x000000018574BF28
		public TweenParams SetEase(Ease ease, float? overshootOrAmplitude = default, float? period = default) => default; // 0x000000018574BD40-0x000000018574BE3C
		public TweenParams SetEase(AnimationCurve animCurve) => default; // 0x000000018574BC74-0x000000018574BD40
		public TweenParams SetEase(EaseFunction customEase) => default; // 0x000000018574BE3C-0x000000018574BE68
		public TweenParams SetRecyclable(bool recyclable = true /* Metadata: 0x01FD7680 */) => default; // 0x0000000183D55430-0x0000000183D55440
		public TweenParams SetUpdate(bool isIndependentUpdate) => default; // 0x000000018574BF44-0x000000018574BFA4
		public TweenParams SetUpdate(DG.Tweening.UpdateType updateType, bool isIndependentUpdate = false /* Metadata: 0x01FD7681 */) => default; // 0x0000000183D55460-0x0000000183D55470
		public TweenParams OnStart(TweenCallback action) => default; // 0x000000018574BC04-0x000000018574BC20
		public TweenParams OnPlay(TweenCallback action) => default; // 0x000000018574BBCC-0x000000018574BBE8
		public TweenParams OnRewind(TweenCallback action) => default; // 0x000000018574BBE8-0x000000018574BC04
		public TweenParams OnUpdate(TweenCallback action) => default; // 0x000000018574BC3C-0x000000018574BC58
		public TweenParams OnStepComplete(TweenCallback action) => default; // 0x000000018574BC20-0x000000018574BC3C
		public TweenParams OnComplete(TweenCallback action) => default; // 0x000000018574BB94-0x000000018574BBB0
		public TweenParams OnKill(TweenCallback action) => default; // 0x000000018574BBB0-0x000000018574BBCC
		public TweenParams OnWaypointChange(TweenCallback<int> action) => default; // 0x000000018574BC58-0x000000018574BC74
		public TweenParams SetDelay(float delay) => default; // 0x0000000183D55410-0x0000000183D55420
		public TweenParams SetRelative(bool isRelative = true /* Metadata: 0x01FD7682 */) => default; // 0x0000000183D55440-0x0000000183D55450
		public TweenParams SetSpeedBased(bool isSpeedBased = true /* Metadata: 0x01FD7683 */) => default; // 0x0000000183D55450-0x0000000183D55460
	}

	public static class TweenSettingsExtensions // TypeDefIndex: 55802
	{
		// Methods
		private static bool ValidateAddToSequence(DG.Tweening.Sequence s, DG.Tweening.Tween t, bool ignoreTween = false /* Metadata: 0x01FD7684 */) => default; // 0x0000000182D4F6C0-0x0000000182D4F720
	
		// Extension methods
		public static T SetAutoKill<T>(this T t)
			where T : DG.Tweening.Tween => default;
		public static T SetAutoKill<T>(this T t, bool autoKillOnCompletion)
			where T : DG.Tweening.Tween => default;
		public static T SetId<T>(this T t, object objectId)
			where T : DG.Tweening.Tween => default;
		public static T SetId<T>(this T t, string stringId)
			where T : DG.Tweening.Tween => default;
		public static T SetId<T>(this T t, int intId)
			where T : DG.Tweening.Tween => default;
		public static T SetLink<T>(this T t, GameObject gameObject)
			where T : DG.Tweening.Tween => default;
		public static T SetLink<T>(this T t, GameObject gameObject, LinkBehaviour behaviour)
			where T : DG.Tweening.Tween => default;
		public static T SetTarget<T>(this T t, object target)
			where T : DG.Tweening.Tween => default;
		public static T SetLoops<T>(this T t, int loops)
			where T : DG.Tweening.Tween => default;
		public static T SetLoops<T>(this T t, int loops, LoopType loopType)
			where T : DG.Tweening.Tween => default;
		public static T SetEase<T>(this T t, Ease ease)
			where T : DG.Tweening.Tween => default;
		public static T SetEase<T>(this T t, Ease ease, float overshoot)
			where T : DG.Tweening.Tween => default;
		public static T SetEase<T>(this T t, Ease ease, float amplitude, float period)
			where T : DG.Tweening.Tween => default;
		public static T SetEase<T>(this T t, AnimationCurve animCurve)
			where T : DG.Tweening.Tween => default;
		public static T SetEase<T>(this T t, EaseFunction customEase)
			where T : DG.Tweening.Tween => default;
		public static T SetRecyclable<T>(this T t)
			where T : DG.Tweening.Tween => default;
		public static T SetRecyclable<T>(this T t, bool recyclable)
			where T : DG.Tweening.Tween => default;
		public static T SetUpdate<T>(this T t, bool isIndependentUpdate)
			where T : DG.Tweening.Tween => default;
		public static T SetUpdate<T>(this T t, DG.Tweening.UpdateType updateType)
			where T : DG.Tweening.Tween => default;
		public static T SetUpdate<T>(this T t, DG.Tweening.UpdateType updateType, bool isIndependentUpdate)
			where T : DG.Tweening.Tween => default;
		public static T SetInverted<T>(this T t)
			where T : DG.Tweening.Tween => default;
		public static T SetInverted<T>(this T t, bool inverted)
			where T : DG.Tweening.Tween => default;
		public static T OnStart<T>(this T t, TweenCallback action)
			where T : DG.Tweening.Tween => default;
		public static T OnPlay<T>(this T t, TweenCallback action)
			where T : DG.Tweening.Tween => default;
		public static T OnPause<T>(this T t, TweenCallback action)
			where T : DG.Tweening.Tween => default;
		public static T OnRewind<T>(this T t, TweenCallback action)
			where T : DG.Tweening.Tween => default;
		public static T OnUpdate<T>(this T t, TweenCallback action)
			where T : DG.Tweening.Tween => default;
		public static T OnStepComplete<T>(this T t, TweenCallback action)
			where T : DG.Tweening.Tween => default;
		public static T OnComplete<T>(this T t, TweenCallback action)
			where T : DG.Tweening.Tween => default;
		public static T OnKill<T>(this T t, TweenCallback action)
			where T : DG.Tweening.Tween => default;
		public static T OnWaypointChange<T>(this T t, TweenCallback<int> action)
			where T : DG.Tweening.Tween => default;
		public static T SetAs<T>(this T t, DG.Tweening.Tween asTween)
			where T : DG.Tweening.Tween => default;
		public static T SetAs<T>(this T t, TweenParams tweenParams)
			where T : DG.Tweening.Tween => default;
		public static DG.Tweening.Sequence Append(this DG.Tweening.Sequence s, DG.Tweening.Tween t) => default; // 0x0000000182D4F480-0x0000000182D4F4D0
		public static DG.Tweening.Sequence Prepend(this DG.Tweening.Sequence s, DG.Tweening.Tween t) => default; // 0x000000018574C358-0x000000018574C394
		public static DG.Tweening.Sequence Join(this DG.Tweening.Sequence s, DG.Tweening.Tween t) => default; // 0x0000000182D4F720-0x0000000182D4F770
		public static DG.Tweening.Sequence Insert(this DG.Tweening.Sequence s, float atPosition, DG.Tweening.Tween t) => default; // 0x000000018574C280-0x000000018574C2D0
		public static DG.Tweening.Sequence AppendInterval(this DG.Tweening.Sequence s, float interval) => default; // 0x0000000182D4DFB0-0x0000000182D4DFF0
		public static DG.Tweening.Sequence PrependInterval(this DG.Tweening.Sequence s, float interval) => default; // 0x000000018574C318-0x000000018574C358
		public static DG.Tweening.Sequence AppendCallback(this DG.Tweening.Sequence s, TweenCallback callback) => default; // 0x0000000182D4C9B0-0x0000000182D4CA00
		public static DG.Tweening.Sequence PrependCallback(this DG.Tweening.Sequence s, TweenCallback callback) => default; // 0x000000018574C2D0-0x000000018574C318
		public static DG.Tweening.Sequence InsertCallback(this DG.Tweening.Sequence s, float atPosition, TweenCallback callback) => default; // 0x000000018574C22C-0x000000018574C280
		public static T From<T>(this T t)
			where T : Tweener => default;
		public static T From<T>(this T t, bool isRelative)
			where T : Tweener => default;
		public static T From<T>(this T t, bool setImmediately, bool isRelative)
			where T : Tweener => default;
		public static TweenerCore<T1, T2, TPlugOptions> From<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately = true /* Metadata: 0x01FD7685 */, bool isRelative = false /* Metadata: 0x01FD7686 */)
			where TPlugOptions : struct, IPlugOptions => default;
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> From(this TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t, float fromAlphaValue, bool setImmediately = true /* Metadata: 0x01FD7687 */, bool isRelative = false /* Metadata: 0x01FD7688 */) => default; // 0x000000018574C024-0x000000018574C0E0
		public static TweenerCore<Vector3, Vector3, VectorOptions> From(this TweenerCore<Vector3, Vector3, VectorOptions> t, float fromValue, bool setImmediately = true /* Metadata: 0x01FD7689 */, bool isRelative = false /* Metadata: 0x01FD768A */) => default; // 0x000000018574C0E0-0x000000018574C18C
		public static TweenerCore<Vector2, Vector2, CircleOptions> From(this TweenerCore<Vector2, Vector2, CircleOptions> t, float fromValueDegrees, bool setImmediately = true /* Metadata: 0x01FD768B */, bool isRelative = false /* Metadata: 0x01FD768C */) => default; // 0x000000018574C18C-0x000000018574C22C
		public static T SetDelay<T>(this T t, float delay)
			where T : DG.Tweening.Tween => default;
		public static T SetDelay<T>(this T t, float delay, bool asPrependedIntervalIfSequence)
			where T : DG.Tweening.Tween => default;
		public static T SetRelative<T>(this T t)
			where T : DG.Tweening.Tween => default;
		public static T SetRelative<T>(this T t, bool isRelative)
			where T : DG.Tweening.Tween => default;
		public static T SetSpeedBased<T>(this T t)
			where T : DG.Tweening.Tween => default;
		public static T SetSpeedBased<T>(this T t, bool isSpeedBased)
			where T : DG.Tweening.Tween => default;
		public static Tweener SetOptions(this TweenerCore<float, float, FloatOptions> t, bool snapping) => default; // 0x000000018574C8D8-0x000000018574C8F0
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, bool snapping) => default; // 0x0000000182D50330-0x0000000182D50350
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x01FD768D */) => default; // 0x0000000183864530-0x0000000183864550
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, bool snapping) => default; // 0x0000000182D4B520-0x0000000182D4B540
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x01FD768E */) => default; // 0x000000018574C8B8-0x000000018574C8D8
		public static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, bool snapping) => default; // 0x000000018574C758-0x000000018574C770
		public static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x01FD768F */) => default; // 0x000000018574C738-0x000000018574C758
		public static Tweener SetOptions(this TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool useShortest360Route = true /* Metadata: 0x01FD7690 */) => default; // 0x000000018574C770-0x000000018574C790
		public static Tweener SetOptions(this TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t, bool alphaOnly) => default; // 0x0000000182D4CE10-0x0000000182D4CE30
		public static Tweener SetOptions(this TweenerCore<Rect, Rect, RectOptions> t, bool snapping) => default; // 0x0000000182D4CE10-0x0000000182D4CE30
		public static Tweener SetOptions(this TweenerCore<string, string, StringOptions> t, bool richTextEnabled, ScrambleMode scrambleMode = ScrambleMode.None /* Metadata: 0x01FD7691 */, string scrambleChars = null) => default; // 0x000000018574C790-0x000000018574C868
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool snapping) => default; // 0x0000000182D50330-0x0000000182D50350
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x01FD7692 */) => default; // 0x0000000183864530-0x0000000183864550
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, CircleOptions> t, float endValueDegrees, bool relativeCenter = true /* Metadata: 0x01FD7693 */, bool snapping = false /* Metadata: 0x01FD7694 */) => default; // 0x000000018574C890-0x000000018574C8B8
		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, AxisConstraint lockPosition, AxisConstraint lockRotation = AxisConstraint.None /* Metadata: 0x01FD7695 */) => default; // 0x000000018574C8F0-0x000000018574C910
		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, bool closePath, AxisConstraint lockPosition = AxisConstraint.None /* Metadata: 0x01FD7696 */, AxisConstraint lockRotation = AxisConstraint.None /* Metadata: 0x01FD7697 */) => default; // 0x000000018574C868-0x000000018574C890
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, Vector3? forwardDirection = default, Vector3? up = default) => default; // 0x000000018574C498-0x000000018574C508
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, bool stableZRotation) => default; // 0x000000018574C588-0x000000018574C5F4
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, Vector3? forwardDirection = default, Vector3? up = default) => default; // 0x000000018574C410-0x000000018574C498
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, bool stableZRotation) => default; // 0x000000018574C5F4-0x000000018574C678
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, Vector3? forwardDirection = default, Vector3? up = default) => default; // 0x000000018574C508-0x000000018574C588
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, bool stableZRotation) => default; // 0x000000018574C394-0x000000018574C410
		private static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, OrientType orientType, Vector3 lookAtPosition, Transform lookAtTransform, float lookAhead, Vector3? forwardDirection = default, Vector3? up = default, bool stableZRotation = false /* Metadata: 0x01FD7698 */) => default; // 0x000000018574C678-0x000000018574C738
		private static void SetPathForwardDirection(this TweenerCore<Vector3, Path, PathOptions> t, Vector3? forwardDirection = default, Vector3? up = default) {} // 0x000000018574C910-0x000000018574CBA4
	}

	public enum LogBehaviour // TypeDefIndex: 55803
	{
		Default = 0,
		Verbose = 1,
		ErrorsOnly = 2
	}

	public abstract class Tween : ABSSequentiable // TypeDefIndex: 55804
	{
		// Fields
		public float timeScale; // 0x28
		public bool isBackwards; // 0x2C
		internal bool isInverted; // 0x2D
		public object id; // 0x30
		public string stringId; // 0x38
		public int intId; // 0x40
		public object target; // 0x48
		internal DG.Tweening.UpdateType updateType; // 0x50
		internal bool isIndependentUpdate; // 0x54
		public TweenCallback onPlay; // 0x58
		public TweenCallback onPause; // 0x60
		public TweenCallback onRewind; // 0x68
		public TweenCallback onUpdate; // 0x70
		public TweenCallback onStepComplete; // 0x78
		public TweenCallback onComplete; // 0x80
		public TweenCallback onKill; // 0x88
		public TweenCallback<int> onWaypointChange; // 0x90
		internal bool isFrom; // 0x98
		internal bool isBlendable; // 0x99
		internal bool isRecyclable; // 0x9A
		internal bool isSpeedBased; // 0x9B
		internal bool autoKill; // 0x9C
		internal float duration; // 0xA0
		internal int loops; // 0xA4
		internal LoopType loopType; // 0xA8
		internal float delay; // 0xAC
		internal Ease easeType; // 0xB4
		internal EaseFunction customEase; // 0xB8
		public float easeOvershootOrAmplitude; // 0xC0
		public float easePeriod; // 0xC4
		public string debugTargetId; // 0xC8
		internal System.Type typeofT1; // 0xD0
		internal System.Type typeofT2; // 0xD8
		internal System.Type typeofTPlugOptions; // 0xE0
		internal bool isSequenced; // 0xE9
		internal DG.Tweening.Sequence sequenceParent; // 0xF0
		internal int activeId; // 0xF8
		internal SpecialStartupMode specialStartupMode; // 0xFC
		internal bool creationLocked; // 0x100
		internal bool startupDone; // 0x101
		internal float fullDuration; // 0x108
		internal int completedLoops; // 0x10C
		internal bool isPlaying; // 0x110
		internal bool isComplete; // 0x111
		internal float elapsedDelay; // 0x114
		internal bool delayComplete; // 0x118
		internal int miscInt; // 0x11C
	
		// Properties
		public bool isRelative { get; internal set; } // 0x0000000181151530-0x0000000181151540 0x0000000181151540-0x0000000181151550
		public bool active { get; internal set; } // 0x0000000183D554A0-0x0000000183D554B0 0x0000000183D554D0-0x0000000183D554E0
		public float fullPosition { get; set; } // 0x000000018574CBA4-0x000000018574CBB0 0x000000018574CBB0-0x000000018574CBC0
		public bool hasLoops { get; } // 0x00000001825D1AB0-0x00000001825D1AD0 
		public bool playedOnce { get; private set; } // 0x0000000183D554B0-0x0000000183D554C0 0x0000000183D554E0-0x0000000183D554F0
		public float position { get; internal set; } // 0x0000000183D554C0-0x0000000183D554D0 0x0000000183D554F0-0x0000000183D55500
	
		// Constructors
		protected Tween() {} // 0x0000000183D55470-0x0000000183D554A0
	
		// Methods
		internal virtual void Reset() {} // 0x0000000182FBDF90-0x0000000182FBE110
		internal abstract bool Validate();
		internal virtual float UpdateDelay(float elapsed) => default; // 0x0000000183D503F0-0x0000000183D50400
		internal abstract bool Startup();
		internal abstract bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, UpdateNotice updateNotice);
		internal static bool DoGoto(Tween t, float toPosition, int toCompletedLoops, DG.Tweening.Core.Enums.UpdateMode updateMode) => default; // 0x00000001825D1640-0x00000001825D1AB0
		internal static bool OnTweenCallback(TweenCallback callback, Tween t) => default; // 0x00000001825D2470-0x00000001825D25C0
		internal static bool OnTweenCallback<T>(TweenCallback<T> callback, Tween t, T param) => default;
	}

	public abstract class Tweener : DG.Tweening.Tween // TypeDefIndex: 55805
	{
		// Fields
		internal bool hasManuallySetStartValue; // 0x120
		internal bool isFromAllowed; // 0x121
	
		// Constructors
		internal Tweener() {} // 0x0000000183D55500-0x0000000183D55530
	
		// Methods
		public abstract Tweener ChangeStartValue(object newStartValue, float newDuration = -1f /* Metadata: 0x01FD769C */);
		public abstract Tweener ChangeEndValue(object newEndValue, float newDuration = -1f /* Metadata: 0x01FD76A0 */, bool snapStartValue = false /* Metadata: 0x01FD76A4 */);
		public abstract Tweener ChangeEndValue(object newEndValue, bool snapStartValue);
		public abstract Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1f /* Metadata: 0x01FD76A5 */);
		internal abstract Tweener SetFrom(bool relative);
		internal static bool Setup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null)
			where TPlugOptions : struct, IPlugOptions => default;
		internal static float DoUpdateDelay<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, float elapsed)
			where TPlugOptions : struct, IPlugOptions => default;
		internal static bool DoStartup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t)
			where TPlugOptions : struct, IPlugOptions => default;
		internal static TweenerCore<T1, T2, TPlugOptions> DoChangeStartValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, float newDuration)
			where TPlugOptions : struct, IPlugOptions => default;
		internal static TweenerCore<T1, T2, TPlugOptions> DoChangeEndValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newEndValue, float newDuration, bool snapStartValue)
			where TPlugOptions : struct, IPlugOptions => default;
		internal static TweenerCore<T1, T2, TPlugOptions> DoChangeValues<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, T2 newEndValue, float newDuration)
			where TPlugOptions : struct, IPlugOptions => default;
		private static bool DOStartupSpecials<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t)
			where TPlugOptions : struct, IPlugOptions => default;
		private static void DOStartupDurationBased<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t)
			where TPlugOptions : struct, IPlugOptions {}
	}

	public enum TweenType // TypeDefIndex: 55806
	{
		Tweener = 0,
		Sequence = 1,
		Callback = 2
	}

	public enum UpdateType // TypeDefIndex: 55807
	{
		Normal = 0,
		Late = 1,
		Fixed = 2,
		Manual = 3
	}
}

namespace DG.Tweening.Core
{
	public abstract class ABSSequentiable // TypeDefIndex: 55853
	{
		// Fields
		internal TweenType tweenType; // 0x10
		internal float sequencedPosition; // 0x14
		internal float sequencedEndPosition; // 0x18
		internal TweenCallback onStart; // 0x20
	
		// Constructors
		protected ABSSequentiable() {} // 0x000000018350B670-0x000000018350B680
	}

	public delegate T DOGetter<out T>(); // TypeDefIndex: 55854; 0x00000000-0x00000000

	public delegate void DOSetter<in T>(T pNewValue); // TypeDefIndex: 55855; 0x00000000-0x00000000

	public static class Debugger // TypeDefIndex: 55857
	{
		// Fields
		private static int _logPriority; // 0x00
		private const string _LogPrefix = "<color=#0099bc><b>DOTWEEN \u25BA </b></color>"; // Metadata: 0x01FD76BB
	
		// Properties
		public static int logPriority { get; } // 0x000000018575CF24-0x000000018575CF5C 
	
		// Nested types
		internal static class Sequence // TypeDefIndex: 55856
		{
			// Methods
			public static void LogAddToNullSequence() {} // 0x00000001857634A4-0x00000001857634DC
			public static void LogAddToInactiveSequence() {} // 0x0000000185763434-0x000000018576346C
			public static void LogAddToLockedSequence() {} // 0x000000018576346C-0x00000001857634A4
			public static void LogAddNullTween() {} // 0x00000001857633FC-0x0000000185763434
			public static void LogAddInactiveTween(DG.Tweening.Tween t) {} // 0x00000001857633C0-0x00000001857633FC
			public static void LogAddAlreadySequencedTween(DG.Tweening.Tween t) {} // 0x0000000185763384-0x00000001857633C0
		}
	
		// Methods
		public static void Log(object message) {} // 0x000000018575CDC0-0x000000018575CEB0
		public static void LogWarning(object message, DG.Tweening.Tween t = null) {} // 0x0000000182A4EBA0-0x0000000182A4ECB0
		public static void LogError(object message, DG.Tweening.Tween t = null) {} // 0x000000018575C700-0x000000018575C854
		public static void LogSafeModeCapturedError(object message, DG.Tweening.Tween t = null) {} // 0x000000018575CB2C-0x000000018575CCE0
		public static void LogReport(object message) {} // 0x000000018575CA4C-0x000000018575CB2C
		public static void LogSafeModeReport(object message) {} // 0x000000018575CCE0-0x000000018575CDC0
		public static void LogInvalidTween(DG.Tweening.Tween t) {} // 0x000000018575C854-0x000000018575C88C
		public static void LogNestedTween(DG.Tweening.Tween t) {} // 0x000000018575C944-0x000000018575C980
		public static void LogNullTween(DG.Tweening.Tween t) {} // 0x000000018575C9BC-0x000000018575C9F4
		public static void LogNonPathTween(DG.Tweening.Tween t) {} // 0x000000018575C980-0x000000018575C9BC
		public static void LogMissingMaterialProperty(string propertyName) {} // 0x000000018575C88C-0x000000018575C8D8
		public static void LogMissingMaterialProperty(int propertyId) {} // 0x000000018575C8D8-0x000000018575C944
		public static void LogRemoveActiveTweenError(string errorInfo, DG.Tweening.Tween t) {} // 0x000000018575C9F4-0x000000018575CA4C
		public static void LogAddActiveTweenError(string errorInfo, DG.Tweening.Tween t) {} // 0x000000018575C6A8-0x000000018575C700
		public static void SetLogPriority(LogBehaviour logBehaviour) {} // 0x0000000182968D50-0x0000000182968DA0
		public static bool ShouldLogSafeModeCapturedError() => default; // 0x000000018575CEB0-0x000000018575CF24
		private static string GetDebugDataMessage(DG.Tweening.Tween t) => default; // 0x000000018575C65C-0x000000018575C6A8
		private static void AddDebugDataToMessage(ref string message, DG.Tweening.Tween t) {} // 0x000000018575C494-0x000000018575C65C
	}

	[AddComponentMenu("")]
	public class DOTweenComponent : MonoBehaviour, IDOTweenInit // TypeDefIndex: 55864
	{
		// Fields
		public int inspectorUpdater; // 0x18
		private float _unscaledTime; // 0x1C
		private float _unscaledDeltaTime; // 0x20
		private bool _paused; // 0x24
		private float _pausedTime; // 0x28
		private bool _isQuitting; // 0x2C
		private bool _duplicateToDestroy; // 0x2D
	
		// Constructors
		public DOTweenComponent() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Awake() {} // 0x000000018397EF80-0x000000018397F110
		private void Start() {} // 0x0000000183CF5D70-0x0000000183CF5E10
		private void Update() {} // 0x0000000182460810-0x0000000182460A10
		private void LateUpdate() {} // 0x000000018314E680-0x000000018314E6F0
		private void FixedUpdate() {} // 0x00000001830CBB00-0x00000001830CBB70
		private void OnDrawGizmos() {} // 0x000000018575BF54-0x000000018575C074
		private void OnDestroy() {} // 0x000000018575BB58-0x000000018575BF54
		public void OnApplicationPause(bool pauseStatus) {} // 0x0000000183134AD0-0x0000000183134AF0
		private void OnApplicationQuit() {} // 0x000000018575BB0C-0x000000018575BB58
		public IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity) => default; // 0x000000018575C074-0x000000018575C0D4
		internal IEnumerator WaitForCompletion(DG.Tweening.Tween t) => default; // 0x000000018575C0D4-0x000000018575C130
		internal IEnumerator WaitForRewind(DG.Tweening.Tween t) => default; // 0x000000018575C264-0x000000018575C2C0
		internal IEnumerator WaitForKill(DG.Tweening.Tween t) => default; // 0x000000018575C19C-0x000000018575C1F8
		internal IEnumerator WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops) => default; // 0x000000018575C130-0x000000018575C19C
		internal IEnumerator WaitForPosition(DG.Tweening.Tween t, float position) => default; // 0x000000018575C1F8-0x000000018575C264
		internal IEnumerator WaitForStart(DG.Tweening.Tween t) => default; // 0x000000018575C2C0-0x000000018575C31C
		internal static void Create() {} // 0x0000000182968B60-0x0000000182968CB0
		internal static void DestroyInstance() {} // 0x000000018575BA1C-0x000000018575BB0C
	}

	public class DOTweenSettings : ScriptableObject // TypeDefIndex: 55868
	{
		// Fields
		public const string AssetName = "DOTweenSettings"; // Metadata: 0x01FD76E6
		public const string AssetFullFilename = "DOTweenSettings.asset"; // Metadata: 0x01FD76F6
		public bool useSafeMode; // 0x18
		public SafeModeOptions safeModeOptions; // 0x20
		public float timeScale; // 0x28
		public float unscaledTimeScale; // 0x2C
		public bool useSmoothDeltaTime; // 0x30
		public float maxSmoothUnscaledTime; // 0x34
		public RewindCallbackMode rewindCallbackMode; // 0x38
		public bool showUnityEditorReport; // 0x3C
		public LogBehaviour logBehaviour; // 0x40
		public bool drawGizmos; // 0x44
		public bool defaultRecyclable; // 0x45
		public AutoPlay defaultAutoPlay; // 0x48
		public DG.Tweening.UpdateType defaultUpdateType; // 0x4C
		public bool defaultTimeScaleIndependent; // 0x50
		public Ease defaultEaseType; // 0x54
		public float defaultEaseOvershootOrAmplitude; // 0x58
		public float defaultEasePeriod; // 0x5C
		public bool defaultAutoKill; // 0x60
		public LoopType defaultLoopType; // 0x64
		public bool debugMode; // 0x68
		public bool debugStoreTargetId; // 0x69
		public bool showPreviewPanel; // 0x6A
		public SettingsLocation storeSettingsLocation; // 0x6C
		public ModulesSetup modules; // 0x70
		public bool createASMDEF; // 0x78
		public bool showPlayingTweens; // 0x79
		public bool showPausedTweens; // 0x7A
	
		// Nested types
		public enum SettingsLocation // TypeDefIndex: 55865
		{
			AssetsDirectory = 0,
			DOTweenDirectory = 1,
			DemigiantDirectory = 2
		}
	
		[Serializable]
		public class SafeModeOptions // TypeDefIndex: 55866
		{
			// Fields
			public SafeModeLogBehaviour logBehaviour; // 0x10
			public NestedTweenFailureBehaviour nestedTweenFailureBehaviour; // 0x14
	
			// Constructors
			public SafeModeOptions() {} // 0x0000000183D55670-0x0000000183D55680
		}
	
		[Serializable]
		public class ModulesSetup // TypeDefIndex: 55867
		{
			// Fields
			public bool showPanel; // 0x10
			public bool audioEnabled; // 0x11
			public bool physicsEnabled; // 0x12
			public bool physics2DEnabled; // 0x13
			public bool spriteEnabled; // 0x14
			public bool uiEnabled; // 0x15
			public bool textMeshProEnabled; // 0x16
			public bool tk2DEnabled; // 0x17
			public bool deAudioEnabled; // 0x18
			public bool deUnityExtendedEnabled; // 0x19
			public bool epoOutlineEnabled; // 0x1A
	
			// Constructors
			public ModulesSetup() {} // 0x0000000183D55600-0x0000000183D55610
		}
	
		// Constructors
		public DOTweenSettings() {} // 0x0000000183C7CE70-0x0000000183C7CF40
	}

	public static class Extensions // TypeDefIndex: 55869
	{
		// Extension methods
		public static T SetSpecialStartupMode<T>(this T t, SpecialStartupMode mode)
			where T : DG.Tweening.Tween => default;
		public static TweenerCore<T1, T2, TPlugOptions> Blendable<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t)
			where TPlugOptions : struct, IPlugOptions => default;
		public static TweenerCore<T1, T2, TPlugOptions> NoFrom<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t)
			where TPlugOptions : struct, IPlugOptions => default;
	}

	public static class DOTweenExternalCommand // TypeDefIndex: 55870
	{
		// Events
		public static event Action<PathOptions, DG.Tweening.Tween, Quaternion, Transform> SetOrientationOnPath;
	
		// Methods
		internal static void Dispatch_SetOrientationOnPath(PathOptions options, DG.Tweening.Tween t, Quaternion newRot, Transform trans) {} // 0x000000018575C31C-0x000000018575C3F8
	}

	internal struct SafeModeReport // TypeDefIndex: 55872
	{
		// Properties
		public int totMissingTargetOrFieldErrors { get; private set; } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public int totCallbackErrors { get; private set; } // 0x0000000183D4E990-0x0000000183D4E9A0 0x0000000183D51720-0x0000000183D51730
		public int totStartupErrors { get; private set; } // 0x0000000183D516F0-0x0000000183D51700 0x0000000183D51710-0x0000000183D51720
		public int totUnsetErrors { get; private set; } // 0x0000000183D4FBF0-0x0000000183D4FC00 0x0000000183D55690-0x0000000183D556A0
	
		// Nested types
		internal enum SafeModeReportType // TypeDefIndex: 55871
		{
			Unset = 0,
			TargetOrFieldMissing = 1,
			Callback = 2,
			StartupFailure = 3
		}
	
		// Methods
		public void Add(SafeModeReportType type) {} // 0x0000000185763364-0x0000000185763384
		public int GetTotErrors() => default; // 0x0000000183D55680-0x0000000183D55690
	}

	internal class SequenceCallback : ABSSequentiable // TypeDefIndex: 55873
	{
		// Constructors
		public SequenceCallback() {} // Dummy constructor
		public SequenceCallback(float sequencedPosition, TweenCallback callback) {} // 0x0000000182D4C8C0-0x0000000182D4C8E0
	}

	internal class TweenLink // TypeDefIndex: 55874
	{
		// Fields
		public readonly GameObject target; // 0x10
		public readonly LinkBehaviour behaviour; // 0x18
		public bool lastSeenActive; // 0x1C
	
		// Constructors
		public TweenLink() {} // Dummy constructor
		public TweenLink(GameObject target, LinkBehaviour behaviour) {} // 0x0000000185764F70-0x0000000185764FB0
	}

	internal static class TweenManager // TypeDefIndex: 55876
	{
		// Fields
		private const int _DefaultMaxTweeners = 200; // Metadata: 0x01FD7720
		private const int _DefaultMaxSequences = 50; // Metadata: 0x01FD7722
		private const string _MaxTweensReached = "Max Tweens reached: capacity has automatically been increased from #0 to #1. Use DOTween.SetTweensCapacity to set it manually at startup"; // Metadata: 0x01FD7723
		private const float _EpsilonVsTimeCheck = 1E-06f; // Metadata: 0x01FD77AD
		internal static bool isUnityEditor; // 0x00
		internal static bool isDebugBuild; // 0x01
		internal static int maxActive; // 0x04
		internal static int maxTweeners; // 0x08
		internal static int maxSequences; // 0x0C
		internal static bool hasActiveTweens; // 0x10
		internal static bool hasActiveDefaultTweens; // 0x11
		internal static bool hasActiveLateTweens; // 0x12
		internal static bool hasActiveFixedTweens; // 0x13
		internal static bool hasActiveManualTweens; // 0x14
		internal static int totActiveTweens; // 0x18
		internal static int totActiveDefaultTweens; // 0x1C
		internal static int totActiveLateTweens; // 0x20
		internal static int totActiveFixedTweens; // 0x24
		internal static int totActiveManualTweens; // 0x28
		internal static int totActiveTweeners; // 0x2C
		internal static int totActiveSequences; // 0x30
		internal static int totPooledTweeners; // 0x34
		internal static int totPooledSequences; // 0x38
		internal static int totTweeners; // 0x3C
		internal static int totSequences; // 0x40
		internal static bool isUpdateLoop; // 0x44
		internal static DG.Tweening.Tween[] _activeTweens; // 0x48
		private static DG.Tweening.Tween[] _pooledTweeners; // 0x50
		private static readonly Stack<DG.Tweening.Tween> _PooledSequences; // 0x58
		private static readonly List<DG.Tweening.Tween> _KillList; // 0x60
		private static readonly Dictionary<DG.Tweening.Tween, TweenLink> _TweenLinks; // 0x68
		private static int _totTweenLinks; // 0x70
		private static int _maxActiveLookupId; // 0x74
		private static bool _requiresActiveReorganization; // 0x78
		private static int _reorganizeFromId; // 0x7C
		private static int _minPooledTweenerId; // 0x80
		private static int _maxPooledTweenerId; // 0x84
		private static bool _despawnAllCalledFromUpdateLoopCallback; // 0x88
	
		// Nested types
		internal enum CapacityIncreaseMode // TypeDefIndex: 55875
		{
			TweenersAndSequences = 0,
			TweenersOnly = 1,
			SequencesOnly = 2
		}
	
		// Constructors
		static TweenManager() {} // 0x00000001839B00B0-0x00000001839B0350
	
		// Methods
		internal static TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>()
			where TPlugOptions : struct, IPlugOptions => default;
		internal static DG.Tweening.Sequence GetSequence() => default; // 0x0000000182D4F800-0x0000000182D4FAB0
		internal static void SetUpdateType(DG.Tweening.Tween t, DG.Tweening.UpdateType updateType, bool isIndependentUpdate) {} // 0x00000001836ABCD0-0x00000001836ABD40
		internal static void AddActiveTweenToSequence(DG.Tweening.Tween t) {} // 0x0000000182D4F670-0x0000000182D4F6C0
		internal static int DespawnAll() => default; // 0x0000000182C35FD0-0x0000000182C362B0
		internal static void Despawn(DG.Tweening.Tween t, bool modifyActiveLists = true /* Metadata: 0x01FD7713 */) {} // 0x00000001825CF7C0-0x00000001825CF9B0
		internal static void PurgeAll(bool isApplicationQuitting) {} // 0x0000000185765BB0-0x0000000185765DFC
		internal static void PurgePools() {} // 0x0000000185765DFC-0x0000000185765EF8
		internal static void AddTweenLink(DG.Tweening.Tween t, TweenLink tweenLink) {} // 0x0000000185764FB0-0x0000000185765114
		private static void RemoveTweenLink(DG.Tweening.Tween t) {} // 0x0000000185765EF8-0x0000000185765FC0
		internal static void ResetCapacities() {} // 0x0000000185765FC0-0x000000018576600C
		internal static void SetCapacities(int tweenersCapacity, int sequencesCapacity) {} // 0x000000018576600C-0x000000018576611C
		internal static int Validate() => default; // 0x0000000185766478-0x0000000185766600
		internal static void Update(DG.Tweening.UpdateType updateType, float deltaTime, float independentTime) {} // 0x00000001825D1150-0x00000001825D1420
		internal static bool Update(DG.Tweening.Tween t, float deltaTime, float independentTime, bool isSingleTweenManualUpdate) => default; // 0x00000001825D1420-0x00000001825D1640
		internal static int FilteredOperation(DG.Tweening.Core.Enums.OperationType operationType, DG.Tweening.Core.Enums.FilterType filterType, object id, bool optionalBool, float optionalFloat, object optionalObj = null, object[] optionalArray = null) => default; // 0x00000001825D0EB0-0x00000001825D1150
		internal static bool Complete(DG.Tweening.Tween t, bool modifyActiveLists = true /* Metadata: 0x01FD7714 */, DG.Tweening.Core.Enums.UpdateMode updateMode = DG.Tweening.Core.Enums.UpdateMode.Goto /* Metadata: 0x01FD7715 */) => default; // 0x00000001825CE850-0x00000001825CE950
		internal static bool Flip(DG.Tweening.Tween t) => default; // 0x000000018576555C-0x000000018576557C
		internal static void ForceInit(DG.Tweening.Tween t, bool isSequenced = false /* Metadata: 0x01FD7716 */) {} // 0x0000000183A255D0-0x0000000183A25640
		internal static bool Goto(DG.Tweening.Tween t, float to, bool andPlay = false /* Metadata: 0x01FD7717 */, DG.Tweening.Core.Enums.UpdateMode updateMode = DG.Tweening.Core.Enums.UpdateMode.Goto /* Metadata: 0x01FD7718 */) => default; // 0x00000001825D2DC0-0x00000001825D2F00
		internal static bool Pause(DG.Tweening.Tween t) => default; // 0x0000000183574A20-0x0000000183574A60
		internal static bool Play(DG.Tweening.Tween t) => default; // 0x0000000183CB1EB0-0x0000000183CB1EE0
		internal static bool PlayBackwards(DG.Tweening.Tween t) => default; // 0x0000000185765A74-0x0000000185765B24
		internal static bool PlayForward(DG.Tweening.Tween t) => default; // 0x0000000185765B24-0x0000000185765BB0
		internal static bool Restart(DG.Tweening.Tween t, bool includeDelay = true /* Metadata: 0x01FD7719 */, float changeDelayTo = -1f /* Metadata: 0x01FD771A */) => default; // 0x000000018351A880-0x000000018351A960
		internal static bool Rewind(DG.Tweening.Tween t, bool includeDelay = true /* Metadata: 0x01FD771E */) => default; // 0x000000018351A960-0x000000018351AA60
		internal static bool SmoothRewind(DG.Tweening.Tween t) => default; // 0x000000018576611C-0x0000000185766208
		internal static bool TogglePause(DG.Tweening.Tween t) => default; // 0x0000000185766208-0x0000000185766270
		internal static int TotalPooledTweens() => default; // 0x0000000185766380-0x00000001857663D4
		internal static int TotalPlayingTweens() => default; // 0x0000000185766270-0x0000000185766380
		internal static int TotalTweensById(object id, bool playingOnly) => default; // 0x00000001857663D4-0x0000000185766478
		internal static List<DG.Tweening.Tween> GetActiveTweens(bool playing, List<DG.Tweening.Tween> fillableList = null) => default; // 0x000000018576557C-0x0000000185765714
		internal static List<DG.Tweening.Tween> GetTweensById(object id, bool playingOnly, List<DG.Tweening.Tween> fillableList = null) => default; // 0x0000000185765714-0x0000000185765848
		private static int DoGetTweensById(object id, bool playingOnly, bool addToList, List<DG.Tweening.Tween> fillableList) => default; // 0x0000000185765114-0x00000001857652D4
		internal static List<DG.Tweening.Tween> GetTweensByTarget(object target, bool playingOnly, List<DG.Tweening.Tween> fillableList = null) => default; // 0x0000000185765848-0x00000001857659F0
		private static void MarkForKilling(DG.Tweening.Tween t, bool isSingleTweenManualUpdate = false /* Metadata: 0x01FD771F */) {} // 0x00000001825CF5B0-0x00000001825CF650
		private static void EvaluateTweenLink(DG.Tweening.Tween t) {} // 0x00000001857652D4-0x000000018576555C
		private static void AddActiveTween(DG.Tweening.Tween t) {} // 0x00000001825CFF30-0x00000001825D0230
		private static void ReorganizeActiveTweens() {} // 0x00000001825D0230-0x00000001825D0550
		private static void DespawnActiveTweens(List<DG.Tweening.Tween> tweens) {} // 0x00000001825CF4F0-0x00000001825CF5B0
		private static void RemoveActiveTween(DG.Tweening.Tween t) {} // 0x00000001825CFB60-0x00000001825CFF30
		private static void ClearTweenArray(DG.Tweening.Tween[] tweens) {} // 0x00000001825CF650-0x00000001825CF6B0
		private static void IncreaseCapacities(CapacityIncreaseMode increaseMode) {} // 0x0000000183A31300-0x0000000183A314C0
		private static void ManageOnRewindCallbackWhenAlreadyRewinded(DG.Tweening.Tween t, bool isPlayBackwardsOrSmoothRewind) {} // 0x00000001857659F0-0x0000000185765A74
	}

	public static class DOTweenUtils // TypeDefIndex: 55877
	{
		// Fields
		private static Assembly[] _loadedAssemblies; // 0x00
		private static readonly string[] _defAssembliesToQuery; // 0x08
	
		// Constructors
		static DOTweenUtils() {} // 0x0000000183C7B5E0-0x0000000183C7B6C0
	
		// Methods
		internal static Vector3 Vector3FromAngle(float degrees, float magnitude) => default; // 0x0000000183D556B0-0x0000000183D55710
		internal static float Angle2D(Vector3 from, Vector3 to) => default; // 0x0000000185769034-0x0000000185769134
		internal static Vector3 RotateAroundPivot(Vector3 point, Vector3 pivot, Quaternion rotation) => default; // 0x00000001857691B8-0x0000000185769278
		public static Vector2 GetPointOnCircle(Vector2 center, float radius, float degrees) => default; // 0x0000000185769134-0x00000001857691B8
		internal static bool Vector3AreApproximatelyEqual(Vector3 a, Vector3 b) => default; // 0x0000000185769278-0x00000001857692CC
		internal static System.Type GetLooseScriptType(string typeName) => default; // 0x000000018397F110-0x000000018397F250
	}

	public class TweenerCore<T1, T2, TPlugOptions> : Tweener // TypeDefIndex: 55878
		where TPlugOptions : struct, IPlugOptions
	{
		// Fields
		public T2 startValue;
		public T2 endValue;
		public T2 changeValue;
		public TPlugOptions plugOptions;
		public DOGetter<T1> getter;
		public DOSetter<T1> setter;
		internal ABSTweenPlugin<T1, T2, TPlugOptions> tweenPlugin;
		private const string _TxtCantChangeSequencedValues = "You cannot change the values of a tween contained inside a Sequence"; // Metadata: 0x01FD77CE
		private System.Type _colorType;
		private System.Type _color32Type;
	
		// Constructors
		internal TweenerCore() {}
	
		// Methods
		public override Tweener ChangeStartValue(object newStartValue, float newDuration = -1f /* Metadata: 0x01FD77B4 */) => default;
		public override Tweener ChangeEndValue(object newEndValue, bool snapStartValue) => default;
		public override Tweener ChangeEndValue(object newEndValue, float newDuration = -1f /* Metadata: 0x01FD77B8 */, bool snapStartValue = false /* Metadata: 0x01FD77BC */) => default;
		public override Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1f /* Metadata: 0x01FD77BD */) => default;
		public TweenerCore<T1, T2, TPlugOptions> ChangeStartValue(T2 newStartValue, float newDuration = -1f /* Metadata: 0x01FD77C1 */) => default;
		public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, bool snapStartValue) => default;
		public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, float newDuration = -1f /* Metadata: 0x01FD77C5 */, bool snapStartValue = false /* Metadata: 0x01FD77C9 */) => default;
		public TweenerCore<T1, T2, TPlugOptions> ChangeValues(T2 newStartValue, T2 newEndValue, float newDuration = -1f /* Metadata: 0x01FD77CA */) => default;
		internal override Tweener SetFrom(bool relative) => default;
		internal Tweener SetFrom(T2 fromValue, bool setImmediately, bool relative) => default;
		internal sealed override void Reset() {}
		internal override bool Validate() => default;
		private bool ValidateChangeValueType(System.Type newType, out bool isColor32ToColor) {
			isColor32ToColor = default;
			return default;
		}
		internal override float UpdateDelay(float elapsed) => default;
		internal override bool Startup() => default;
		internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, UpdateNotice updateNotice) => default;
	}
}

namespace DG.Tweening.Core.Easing
{
	public static class Bounce // TypeDefIndex: 55887
	{
		// Methods
		public static float EaseIn(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod) => default; // 0x0000000185768F58-0x0000000185768F94
		public static float EaseOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod) => default; // 0x0000000185768F94-0x0000000185769034
		public static float EaseInOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod) => default; // 0x0000000185768EE4-0x0000000185768F58
	}

	public static class EaseManager // TypeDefIndex: 55889
	{
		// Fields
		private const float _PiOver2 = 1.5707964f; // Metadata: 0x01FD7839
		private const float _TwoPi = 6.2831855f; // Metadata: 0x01FD783D
	
		// Methods
		public static float Evaluate(DG.Tweening.Tween t, float time, float duration, float overshootOrAmplitude, float period) => default; // 0x00000001857692CC-0x0000000185769310
		public static float Evaluate(Ease easeType, EaseFunction customEase, float time, float duration, float overshootOrAmplitude, float period) => default; // 0x00000001825D1DA0-0x00000001825D2030
		public static EaseFunction ToEaseFunction(Ease ease) => default; // 0x0000000185769310-0x000000018576ABBC
		internal static bool IsFlashEase(Ease ease) => default; // 0x00000001832C9BF0-0x00000001832C9C00
	}

	public class EaseCurve // TypeDefIndex: 55890
	{
		// Fields
		private readonly AnimationCurve _animCurve; // 0x10
	
		// Constructors
		public EaseCurve() {} // Dummy constructor
		public EaseCurve(AnimationCurve animCurve) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public float Evaluate(float time, float duration, float unusedOvershoot, float unusedPeriod) => default; // 0x0000000183703370-0x0000000183703400
	}

	public static class Flash // TypeDefIndex: 55891
	{
		// Methods
		public static float Ease(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018576AE54-0x000000018576AF10
		public static float EaseIn(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018576ACC0-0x000000018576AD80
		public static float EaseOut(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018576AD80-0x000000018576AE54
		public static float EaseInOut(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018576ABBC-0x000000018576ACC0
		private static float WeightedEase(float overshootOrAmplitude, float period, int stepIndex, float stepDuration, float dir, float res) => default; // 0x000000018576AF10-0x000000018576B064
	}
}

namespace DG.Tweening.Core.Enums
{
	internal enum FilterType // TypeDefIndex: 55879
	{
		All = 0,
		TargetOrId = 1,
		TargetAndId = 2,
		AllExceptTargetsOrIds = 3,
		DOGetter = 4
	}

	public enum NestedTweenFailureBehaviour // TypeDefIndex: 55880
	{
		TryToPreserveSequence = 0,
		KillWholeSequence = 1
	}

	internal enum OperationType // TypeDefIndex: 55881
	{
		Complete = 0,
		Despawn = 1,
		Flip = 2,
		Goto = 3,
		Pause = 4,
		Play = 5,
		PlayForward = 6,
		PlayBackwards = 7,
		Rewind = 8,
		SmoothRewind = 9,
		Restart = 10,
		TogglePause = 11,
		IsTweening = 12
	}

	public enum SafeModeLogBehaviour // TypeDefIndex: 55882
	{
		None = 0,
		Normal = 1,
		Warning = 2,
		Error = 3
	}

	public enum SpecialStartupMode // TypeDefIndex: 55883
	{
		None = 0,
		SetLookAt = 1,
		SetShake = 2,
		SetPunch = 3,
		SetCameraShakePosition = 4
	}

	public enum UpdateNotice // TypeDefIndex: 55884
	{
		None = 0,
		RewindStep = 1
	}

	internal enum UpdateMode // TypeDefIndex: 55885
	{
		Update = 0,
		Goto = 1,
		IgnoreOnUpdate = 2,
		IgnoreOnComplete = 3
	}

	public enum RewindCallbackMode // TypeDefIndex: 55886
	{
		FireIfPositionChanged = 0,
		FireAlwaysWithRewind = 1,
		FireAlways = 2
	}
}

namespace DG.Tweening.CustomPlugins
{
	public class PureQuaternionPlugin : ABSTweenPlugin<Quaternion, Quaternion, NoOptions> // TypeDefIndex: 55852
	{
		// Fields
		private static PureQuaternionPlugin _plug; // 0x00
	
		// Constructors
		public PureQuaternionPlugin() {} // 0x0000000182D4B100-0x0000000182D4B130
	
		// Methods
		public static PureQuaternionPlugin Plug() => default; // 0x0000000182D4B060-0x0000000182D4B100
		public override void Reset(TweenerCore<Quaternion, Quaternion, NoOptions> t) {} // 0x000000018350B670-0x000000018350B680
		public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, bool isRelative) {} // 0x000000018576160C-0x00000001857616BC
		public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion fromValue, bool setImmediately, bool isRelative) {} // 0x0000000185761518-0x000000018576160C
		public override Quaternion ConvertToStartValue(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion value) => default; // 0x0000000183D555D0-0x0000000183D555E0
		public override void SetRelativeEndValue(TweenerCore<Quaternion, Quaternion, NoOptions> t) {} // 0x00000001857616BC-0x0000000185761710
		public override void SetChangeValue(TweenerCore<Quaternion, Quaternion, NoOptions> t) {} // 0x00000001838C7280-0x00000001838C72B0
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, Quaternion changeValue) => default; // 0x00000001857614D4-0x0000000185761518
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Quaternion startValue, Quaternion changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x0000000183502120-0x0000000183502210
	}
}

namespace DG.Tweening.Plugins
{
	public struct CircleOptions : IPlugOptions // TypeDefIndex: 55808
	{
		// Fields
		public float endValueDegrees; // 0x00
		public bool relativeCenter; // 0x04
		public bool snapping; // 0x05
		internal Vector2 center; // 0x08
		internal float radius; // 0x10
		internal float startValueDegrees; // 0x14
		internal bool initialized; // 0x18
	
		// Methods
		public void Reset() {} // 0x0000000183D553B0-0x0000000183D553C0
		public void Initialize(Vector2 startValue, Vector2 endValue) {} // 0x000000018573C2D8-0x000000018573C3A4
	}

	public class CirclePlugin : ABSTweenPlugin<Vector2, Vector2, CircleOptions> // TypeDefIndex: 55809
	{
		// Constructors
		public CirclePlugin() {} // 0x000000018573CA0C-0x000000018573CA34
	
		// Methods
		public override void Reset(TweenerCore<Vector2, Vector2, CircleOptions> t) {} // 0x000000018350B670-0x000000018350B680
		public override void SetFrom(TweenerCore<Vector2, Vector2, CircleOptions> t, bool isRelative) {} // 0x000000018573C848-0x000000018573C990
		public override void SetFrom(TweenerCore<Vector2, Vector2, CircleOptions> t, Vector2 fromValue, bool setImmediately, bool isRelative) {} // 0x000000018573C6EC-0x000000018573C848
		public static ABSTweenPlugin<Vector2, Vector2, CircleOptions> Get() => default; // 0x000000018573C638-0x000000018573C668
		public override Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, CircleOptions> t, Vector2 value) => default; // 0x0000000183D553C0-0x0000000183D553D0
		public override void SetRelativeEndValue(TweenerCore<Vector2, Vector2, CircleOptions> t) {} // 0x000000018573C990-0x000000018573CA0C
		public override void SetChangeValue(TweenerCore<Vector2, Vector2, CircleOptions> t) {} // 0x000000018573C668-0x000000018573C6EC
		public override float GetSpeedBasedDuration(CircleOptions options, float unitsXSecond, Vector2 changeValue) => default; // 0x000000018573C620-0x000000018573C638
		public override void EvaluateAndApply(CircleOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x000000018573C3A4-0x000000018573C548
		public Vector2 GetPositionOnCircle(CircleOptions options, float degrees) => default; // 0x000000018573C548-0x000000018573C620
	}

	internal class Color2Plugin : ABSTweenPlugin<Color2, Color2, ColorOptions> // TypeDefIndex: 55810
	{
		// Constructors
		public Color2Plugin() {} // 0x000000018573D1AC-0x000000018573D1D4
	
		// Methods
		public override void Reset(TweenerCore<Color2, Color2, ColorOptions> t) {} // 0x000000018350B670-0x000000018350B680
		public override void SetFrom(TweenerCore<Color2, Color2, ColorOptions> t, bool isRelative) {} // 0x000000018573CFB0-0x000000018573D130
		public override void SetFrom(TweenerCore<Color2, Color2, ColorOptions> t, Color2 fromValue, bool setImmediately, bool isRelative) {} // 0x000000018573CE20-0x000000018573CFB0
		public override Color2 ConvertToStartValue(TweenerCore<Color2, Color2, ColorOptions> t, Color2 value) => default; // 0x0000000183D553D0-0x0000000183D553F0
		public override void SetRelativeEndValue(TweenerCore<Color2, Color2, ColorOptions> t) {} // 0x000000018573D130-0x000000018573D1AC
		public override void SetChangeValue(TweenerCore<Color2, Color2, ColorOptions> t) {} // 0x000000018573CDA4-0x000000018573CE20
		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color2 changeValue) => default; // 0x000000018573CD94-0x000000018573CDA4
		public override void EvaluateAndApply(ColorOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Color2> getter, DOSetter<Color2> setter, float elapsed, Color2 startValue, Color2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x000000018573CA34-0x000000018573CD94
	}

	public class DoublePlugin : ABSTweenPlugin<double, double, NoOptions> // TypeDefIndex: 55811
	{
		// Constructors
		public DoublePlugin() {} // 0x000000018575D25C-0x000000018575D284
	
		// Methods
		public override void Reset(TweenerCore<double, double, NoOptions> t) {} // 0x000000018350B670-0x000000018350B680
		public override void SetFrom(TweenerCore<double, double, NoOptions> t, bool isRelative) {} // 0x000000018575D108-0x000000018575D194
		public override void SetFrom(TweenerCore<double, double, NoOptions> t, double fromValue, bool setImmediately, bool isRelative) {} // 0x000000018575D194-0x000000018575D230
		public override double ConvertToStartValue(TweenerCore<double, double, NoOptions> t, double value) => default; // 0x0000000183D555C0-0x0000000183D555D0
		public override void SetRelativeEndValue(TweenerCore<double, double, NoOptions> t) {} // 0x000000018575D230-0x000000018575D25C
		public override void SetChangeValue(TweenerCore<double, double, NoOptions> t) {} // 0x000000018575D0DC-0x000000018575D108
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, double changeValue) => default; // 0x000000018575D0C0-0x000000018575D0DC
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<double> getter, DOSetter<double> setter, float elapsed, double startValue, double changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x000000018575CF5C-0x000000018575D0C0
	}

	public class LongPlugin : ABSTweenPlugin<long, long, NoOptions> // TypeDefIndex: 55812
	{
		// Constructors
		public LongPlugin() {} // 0x000000018575DE7C-0x000000018575DEA4
	
		// Methods
		public override void Reset(TweenerCore<long, long, NoOptions> t) {} // 0x000000018350B670-0x000000018350B680
		public override void SetFrom(TweenerCore<long, long, NoOptions> t, bool isRelative) {} // 0x000000018575DD48-0x000000018575DDCC
		public override void SetFrom(TweenerCore<long, long, NoOptions> t, long fromValue, bool setImmediately, bool isRelative) {} // 0x000000018575DDCC-0x000000018575DE58
		public override long ConvertToStartValue(TweenerCore<long, long, NoOptions> t, long value) => default; // 0x0000000183D553C0-0x0000000183D553D0
		public override void SetRelativeEndValue(TweenerCore<long, long, NoOptions> t) {} // 0x000000018575DE58-0x000000018575DE7C
		public override void SetChangeValue(TweenerCore<long, long, NoOptions> t) {} // 0x000000018575DD1C-0x000000018575DD48
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, long changeValue) => default; // 0x000000018575DD00-0x000000018575DD1C
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<long> getter, DOSetter<long> setter, float elapsed, long startValue, long changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x000000018575DB68-0x000000018575DD00
	}

	public class UlongPlugin : ABSTweenPlugin<ulong, ulong, NoOptions> // TypeDefIndex: 55813
	{
		// Constructors
		public UlongPlugin() {} // 0x0000000185766FA8-0x0000000185766FD0
	
		// Methods
		public override void Reset(TweenerCore<ulong, ulong, NoOptions> t) {} // 0x000000018350B670-0x000000018350B680
		public override void SetFrom(TweenerCore<ulong, ulong, NoOptions> t, bool isRelative) {} // 0x0000000185766F24-0x0000000185766FA8
		public override void SetFrom(TweenerCore<ulong, ulong, NoOptions> t, ulong fromValue, bool setImmediately, bool isRelative) {} // 0x000000018575DDCC-0x000000018575DE58
		public override ulong ConvertToStartValue(TweenerCore<ulong, ulong, NoOptions> t, ulong value) => default; // 0x0000000183D553C0-0x0000000183D553D0
		public override void SetRelativeEndValue(TweenerCore<ulong, ulong, NoOptions> t) {} // 0x000000018575DE58-0x000000018575DE7C
		public override void SetChangeValue(TweenerCore<ulong, ulong, NoOptions> t) {} // 0x000000018575DD1C-0x000000018575DD48
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, ulong changeValue) => default; // 0x0000000185766EE4-0x0000000185766F24
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<ulong> getter, DOSetter<ulong> setter, float elapsed, ulong startValue, ulong changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x0000000185766CE8-0x0000000185766EE4
	}

	public class Vector3ArrayPlugin : ABSTweenPlugin<Vector3, Vector3[], Vector3ArrayOptions> // TypeDefIndex: 55814
	{
		// Constructors
		public Vector3ArrayPlugin() {} // 0x0000000185767EA4-0x0000000185767ECC
	
		// Methods
		public override void Reset(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) {} // 0x0000000185762424-0x0000000185762478
		public override void SetFrom(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool isRelative) {} // 0x000000018350B670-0x000000018350B680
		public override void SetFrom(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, Vector3[] fromValue, bool setImmediately, bool isRelative) {} // 0x000000018350B670-0x000000018350B680
		public override Vector3[] ConvertToStartValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, Vector3 value) => default; // 0x0000000185767394-0x0000000185767498
		public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) {} // 0x0000000185767D44-0x0000000185767EA4
		public override void SetChangeValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) {} // 0x0000000185767C00-0x0000000185767D44
		public override float GetSpeedBasedDuration(Vector3ArrayOptions options, float unitsXSecond, Vector3[] changeValue) => default; // 0x0000000185767B6C-0x0000000185767C00
		public override void EvaluateAndApply(Vector3ArrayOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3[] startValue, Vector3[] changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x0000000185767498-0x0000000185767B6C
	}

	public class PathPlugin : ABSTweenPlugin<Vector3, Path, PathOptions> // TypeDefIndex: 55815
	{
		// Fields
		public const float MinLookAhead = 0.0001f; // Metadata: 0x01FD76B0
	
		// Constructors
		public PathPlugin() {} // 0x000000018575FADC-0x000000018575FB04
	
		// Methods
		public override void Reset(TweenerCore<Vector3, Path, PathOptions> t) {} // 0x000000018575E3DC-0x000000018575E444
		public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, bool isRelative) {} // 0x000000018350B670-0x000000018350B680
		public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, Path fromValue, bool setImmediately, bool isRelative) {} // 0x000000018350B670-0x000000018350B680
		public static ABSTweenPlugin<Vector3, Path, PathOptions> Get() => default; // 0x000000018575E3AC-0x000000018575E3DC
		public override Path ConvertToStartValue(TweenerCore<Vector3, Path, PathOptions> t, Vector3 value) => default; // 0x000000018575DF3C-0x000000018575DF58
		public override void SetRelativeEndValue(TweenerCore<Vector3, Path, PathOptions> t) {} // 0x000000018575F9D4-0x000000018575FADC
		public override void SetChangeValue(TweenerCore<Vector3, Path, PathOptions> t) {} // 0x000000018575E444-0x000000018575E900
		public override float GetSpeedBasedDuration(PathOptions options, float unitsXSecond, Path changeValue) => default; // 0x000000018575E38C-0x000000018575E3AC
		public override void EvaluateAndApply(PathOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Path startValue, Path changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x000000018575DF8C-0x000000018575E38C
		public void SetOrientation(PathOptions options, DG.Tweening.Tween t, Path path, float pathPerc, Vector3 tPos, UpdateNotice updateNotice) {} // 0x000000018575E900-0x000000018575F9D4
		private Vector3 DivideVectorByVector(Vector3 vector, Vector3 byVector) => default; // 0x000000018575DF58-0x000000018575DF8C
		private Vector3 MultiplyVectorByVector(Vector3 vector, Vector3 byVector) => default; // 0x0000000183D55610-0x0000000183D55650
	}

	public class ColorPlugin : ABSTweenPlugin<UnityEngine.Color, UnityEngine.Color, ColorOptions> // TypeDefIndex: 55816
	{
		// Constructors
		public ColorPlugin() {} // 0x0000000183790A40-0x0000000183790A70
	
		// Methods
		public override void Reset(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t) {} // 0x000000018350B670-0x000000018350B680
		public override void SetFrom(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t, bool isRelative) {} // 0x000000018575A83C-0x000000018575A920
		public override void SetFrom(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t, UnityEngine.Color fromValue, bool setImmediately, bool isRelative) {} // 0x000000018575A920-0x000000018575AA58
		public override UnityEngine.Color ConvertToStartValue(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t, UnityEngine.Color value) => default; // 0x0000000183D555D0-0x0000000183D555E0
		public override void SetRelativeEndValue(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t) {} // 0x000000018575AA58-0x000000018575AAAC
		public override void SetChangeValue(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t) {} // 0x00000001839DCF80-0x00000001839DCFD0
		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, UnityEngine.Color changeValue) => default; // 0x000000018573CD94-0x000000018573CDA4
		public override void EvaluateAndApply(ColorOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<UnityEngine.Color> getter, DOSetter<UnityEngine.Color> setter, float elapsed, UnityEngine.Color startValue, UnityEngine.Color changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x0000000182FBCF20-0x0000000182FBD070
	}

	public class IntPlugin : ABSTweenPlugin<int, int, NoOptions> // TypeDefIndex: 55817
	{
		// Constructors
		public IntPlugin() {} // 0x000000018575D764-0x000000018575D78C
	
		// Methods
		public override void Reset(TweenerCore<int, int, NoOptions> t) {} // 0x000000018350B670-0x000000018350B680
		public override void SetFrom(TweenerCore<int, int, NoOptions> t, bool isRelative) {} // 0x000000018575D6C8-0x000000018575D744
		public override void SetFrom(TweenerCore<int, int, NoOptions> t, int fromValue, bool setImmediately, bool isRelative) {} // 0x000000018575D640-0x000000018575D6C8
		public override int ConvertToStartValue(TweenerCore<int, int, NoOptions> t, int value) => default; // 0x0000000183D555F0-0x0000000183D55600
		public override void SetRelativeEndValue(TweenerCore<int, int, NoOptions> t) {} // 0x000000018575D744-0x000000018575D764
		public override void SetChangeValue(TweenerCore<int, int, NoOptions> t) {} // 0x000000018575D618-0x000000018575D640
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, int changeValue) => default; // 0x000000018575D5FC-0x000000018575D618
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<int> getter, DOSetter<int> setter, float elapsed, int startValue, int changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x000000018575D474-0x000000018575D5FC
	}

	public class QuaternionPlugin : ABSTweenPlugin<Quaternion, Vector3, QuaternionOptions> // TypeDefIndex: 55818
	{
		// Constructors
		public QuaternionPlugin() {} // 0x00000001839E0EA0-0x00000001839E0FC0
	
		// Methods
		public override void Reset(TweenerCore<Quaternion, Vector3, QuaternionOptions> t) {} // 0x000000018350B670-0x000000018350B680
		public override void SetFrom(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool isRelative) {} // 0x0000000185761734-0x0000000185761A20
		public override void SetFrom(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Vector3 fromValue, bool setImmediately, bool isRelative) {} // 0x0000000185761A20-0x0000000185761BCC
		public override Vector3 ConvertToStartValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Quaternion value) => default; // 0x0000000182FBC090-0x0000000182FBC0C0
		public override void SetRelativeEndValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t) {} // 0x0000000185761BCC-0x0000000185761C40
		public override void SetChangeValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t) {} // 0x0000000182FBBC30-0x0000000182FBBE10
		public override float GetSpeedBasedDuration(QuaternionOptions options, float unitsXSecond, Vector3 changeValue) => default; // 0x0000000185761710-0x0000000185761734
		public override void EvaluateAndApply(QuaternionOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x0000000183501F40-0x0000000183502120
		private Vector3 GetEulerValForCalculations(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Vector3 val, Vector3 counterVal) => default; // 0x0000000182FBBE10-0x0000000182FBBF60
		private Vector3 FlipEulerAngles(Vector3 euler) => default; // 0x0000000182FBBF60-0x0000000182FBBFA0
	}

	public class RectOffsetPlugin : ABSTweenPlugin<RectOffset, RectOffset, NoOptions> // TypeDefIndex: 55819
	{
		// Fields
		private static RectOffset _r; // 0x00
	
		// Constructors
		public RectOffsetPlugin() {} // 0x0000000185762B50-0x0000000185762B78
		static RectOffsetPlugin() {} // 0x0000000185762AD4-0x0000000185762B50
	
		// Methods
		public override void Reset(TweenerCore<RectOffset, RectOffset, NoOptions> t) {} // 0x0000000185762424-0x0000000185762478
		public override void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, bool isRelative) {} // 0x00000001857625F4-0x0000000185762794
		public override void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset fromValue, bool setImmediately, bool isRelative) {} // 0x0000000185762794-0x00000001857629B0
		public override RectOffset ConvertToStartValue(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset value) => default; // 0x0000000185761C40-0x0000000185761D04
		public override void SetRelativeEndValue(TweenerCore<RectOffset, RectOffset, NoOptions> t) {} // 0x00000001857629B0-0x0000000185762AD4
		public override void SetChangeValue(TweenerCore<RectOffset, RectOffset, NoOptions> t) {} // 0x0000000185762478-0x00000001857625F4
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, RectOffset changeValue) => default; // 0x0000000185762350-0x0000000185762424
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, float elapsed, RectOffset startValue, RectOffset changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x0000000185761D04-0x0000000185762350
	}

	public class RectPlugin : ABSTweenPlugin<Rect, Rect, RectOptions> // TypeDefIndex: 55820
	{
		// Constructors
		public RectPlugin() {} // 0x000000018576333C-0x0000000185763364
	
		// Methods
		public override void Reset(TweenerCore<Rect, Rect, RectOptions> t) {} // 0x000000018350B670-0x000000018350B680
		public override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, bool isRelative) {} // 0x0000000185762F68-0x0000000185763108
		public override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, Rect fromValue, bool setImmediately, bool isRelative) {} // 0x0000000185763108-0x00000001857632C8
		public override Rect ConvertToStartValue(TweenerCore<Rect, Rect, RectOptions> t, Rect value) => default; // 0x0000000183D555D0-0x0000000183D555E0
		public override void SetRelativeEndValue(TweenerCore<Rect, Rect, RectOptions> t) {} // 0x00000001857632C8-0x000000018576333C
		public override void SetChangeValue(TweenerCore<Rect, Rect, RectOptions> t) {} // 0x0000000185762EEC-0x0000000185762F68
		public override float GetSpeedBasedDuration(RectOptions options, float unitsXSecond, Rect changeValue) => default; // 0x0000000185762E68-0x0000000185762EEC
		public override void EvaluateAndApply(RectOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Rect> getter, DOSetter<Rect> setter, float elapsed, Rect startValue, Rect changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x0000000185762B78-0x0000000185762E68
	}

	public class UintPlugin : ABSTweenPlugin<uint, uint, UintOptions> // TypeDefIndex: 55821
	{
		// Constructors
		public UintPlugin() {} // 0x0000000185766CC0-0x0000000185766CE8
	
		// Methods
		public override void Reset(TweenerCore<uint, uint, UintOptions> t) {} // 0x000000018350B670-0x000000018350B680
		public override void SetFrom(TweenerCore<uint, uint, UintOptions> t, bool isRelative) {} // 0x0000000185766C44-0x0000000185766CC0
		public override void SetFrom(TweenerCore<uint, uint, UintOptions> t, uint fromValue, bool setImmediately, bool isRelative) {} // 0x000000018575D640-0x000000018575D6C8
		public override uint ConvertToStartValue(TweenerCore<uint, uint, UintOptions> t, uint value) => default; // 0x0000000183D555F0-0x0000000183D55600
		public override void SetRelativeEndValue(TweenerCore<uint, uint, UintOptions> t) {} // 0x000000018575D744-0x000000018575D764
		public override void SetChangeValue(TweenerCore<uint, uint, UintOptions> t) {} // 0x0000000185766BF4-0x0000000185766C44
		public override float GetSpeedBasedDuration(UintOptions options, float unitsXSecond, uint changeValue) => default; // 0x0000000185766BD0-0x0000000185766BF4
		public override void EvaluateAndApply(UintOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<uint> getter, DOSetter<uint> setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x0000000185766A04-0x0000000185766BD0
	}

	public class Vector2Plugin : ABSTweenPlugin<Vector2, Vector2, VectorOptions> // TypeDefIndex: 55822
	{
		// Constructors
		public Vector2Plugin() {} // 0x000000018346A030-0x000000018346A060
	
		// Methods
		public override void Reset(TweenerCore<Vector2, Vector2, VectorOptions> t) {} // 0x000000018350B670-0x000000018350B680
		public override void SetFrom(TweenerCore<Vector2, Vector2, VectorOptions> t, bool isRelative) {} // 0x00000001857671B8-0x0000000185767310
		public override void SetFrom(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 fromValue, bool setImmediately, bool isRelative) {} // 0x0000000185766FFC-0x00000001857671B8
		public override Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 value) => default; // 0x0000000183D553C0-0x0000000183D553D0
		public override void SetRelativeEndValue(TweenerCore<Vector2, Vector2, VectorOptions> t) {} // 0x0000000185767310-0x0000000185767380
		public override void SetChangeValue(TweenerCore<Vector2, Vector2, VectorOptions> t) {} // 0x0000000182FBE110-0x0000000182FBE1C0
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector2 changeValue) => default; // 0x0000000185766FD0-0x0000000185766FFC
		public override void EvaluateAndApply(VectorOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x00000001825D20A0-0x00000001825D2290
	}

	public class Vector4Plugin : ABSTweenPlugin<Vector4, Vector4, VectorOptions> // TypeDefIndex: 55823
	{
		// Constructors
		public Vector4Plugin() {} // 0x0000000185768EBC-0x0000000185768EE4
	
		// Methods
		public override void Reset(TweenerCore<Vector4, Vector4, VectorOptions> t) {} // 0x000000018350B670-0x000000018350B680
		public override void SetFrom(TweenerCore<Vector4, Vector4, VectorOptions> t, bool isRelative) {} // 0x0000000185768984-0x0000000185768B70
		public override void SetFrom(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 fromValue, bool setImmediately, bool isRelative) {} // 0x0000000185768B70-0x0000000185768EBC
		public override Vector4 ConvertToStartValue(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 value) => default; // 0x0000000183D555D0-0x0000000183D555E0
		public override void SetRelativeEndValue(TweenerCore<Vector4, Vector4, VectorOptions> t) {} // 0x000000018575AA58-0x000000018575AAAC
		public override void SetChangeValue(TweenerCore<Vector4, Vector4, VectorOptions> t) {} // 0x0000000185768874-0x0000000185768984
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector4 changeValue) => default; // 0x0000000185768850-0x0000000185768874
		public override void EvaluateAndApply(VectorOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector4> getter, DOSetter<Vector4> setter, float elapsed, Vector4 startValue, Vector4 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x0000000185768348-0x0000000185768850
	}

	public class StringPlugin : ABSTweenPlugin<string, string, StringOptions> // TypeDefIndex: 55824
	{
		// Fields
		private static readonly StringBuilder _Buffer; // 0x00
		private static readonly List<char> _OpenedTags; // 0x08
	
		// Constructors
		public StringPlugin() {} // 0x0000000185764F48-0x0000000185764F70
		static StringPlugin() {} // 0x0000000185764E68-0x0000000185764F48
	
		// Methods
		public override void SetFrom(TweenerCore<string, string, StringOptions> t, bool isRelative) {} // 0x0000000185764DE0-0x0000000185764E68
		public override void SetFrom(TweenerCore<string, string, StringOptions> t, string fromValue, bool setImmediately, bool isRelative) {} // 0x0000000185764D18-0x0000000185764DE0
		public override void Reset(TweenerCore<string, string, StringOptions> t) {} // 0x000000018576496C-0x00000001857649E4
		public override string ConvertToStartValue(TweenerCore<string, string, StringOptions> t, string value) => default; // 0x0000000183D553C0-0x0000000183D553D0
		public override void SetRelativeEndValue(TweenerCore<string, string, StringOptions> t) {} // 0x000000018350B670-0x000000018350B680
		public override void SetChangeValue(TweenerCore<string, string, StringOptions> t) {} // 0x0000000185764AB0-0x0000000185764D18
		public override float GetSpeedBasedDuration(StringOptions options, float unitsXSecond, string changeValue) => default; // 0x0000000185764918-0x000000018576496C
		public override void EvaluateAndApply(StringOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<string> getter, DOSetter<string> setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x0000000185764480-0x0000000185764918
		private StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled) => default; // 0x0000000185763E1C-0x0000000185764480
		private char[] ScrambledCharsToUse(StringOptions options) => default; // 0x00000001857649E4-0x0000000185764AB0
	}

	internal static class StringPluginExtensions // TypeDefIndex: 55825
	{
		// Fields
		public static readonly char[] ScrambledCharsAll; // 0x00
		public static readonly char[] ScrambledCharsUppercase; // 0x08
		public static readonly char[] ScrambledCharsLowercase; // 0x10
		public static readonly char[] ScrambledCharsNumerals; // 0x18
		private static int _lastRndSeed; // 0x20
	
		// Constructors
		static StringPluginExtensions() {} // 0x0000000185763C1C-0x0000000185763E1C
	
		// Extension methods
		internal static void ScrambleChars(this char[] chars) {} // 0x0000000185763B90-0x0000000185763C1C
		internal static StringBuilder AppendScrambledChars(this StringBuilder buffer, int length, char[] chars) => default; // 0x0000000185763A5C-0x0000000185763B90
	}

	public class FloatPlugin : ABSTweenPlugin<float, float, FloatOptions> // TypeDefIndex: 55826
	{
		// Constructors
		public FloatPlugin() {} // 0x000000018318DB50-0x000000018318DB80
	
		// Methods
		public override void Reset(TweenerCore<float, float, FloatOptions> t) {} // 0x000000018350B670-0x000000018350B680
		public override void SetFrom(TweenerCore<float, float, FloatOptions> t, bool isRelative) {} // 0x000000018575D29C-0x000000018575D368
		public override void SetFrom(TweenerCore<float, float, FloatOptions> t, float fromValue, bool setImmediately, bool isRelative) {} // 0x000000018575D368-0x000000018575D448
		public override float ConvertToStartValue(TweenerCore<float, float, FloatOptions> t, float value) => default; // 0x0000000183D555C0-0x0000000183D555D0
		public override void SetRelativeEndValue(TweenerCore<float, float, FloatOptions> t) {} // 0x000000018575D448-0x000000018575D474
		public override void SetChangeValue(TweenerCore<float, float, FloatOptions> t) {} // 0x0000000183456610-0x0000000183456640
		public override float GetSpeedBasedDuration(FloatOptions options, float unitsXSecond, float changeValue) => default; // 0x000000018575D284-0x000000018575D29C
		public override void EvaluateAndApply(FloatOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<float> getter, DOSetter<float> setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x00000001825D1C80-0x00000001825D1DA0
	}

	public class Vector3Plugin : ABSTweenPlugin<Vector3, Vector3, VectorOptions> // TypeDefIndex: 55827
	{
		// Constructors
		public Vector3Plugin() {} // 0x000000018399F4A0-0x000000018399F4D0
	
		// Methods
		public override void Reset(TweenerCore<Vector3, Vector3, VectorOptions> t) {} // 0x000000018350B670-0x000000018350B680
		public override void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, bool isRelative) {} // 0x0000000185767ECC-0x00000001857680CC
		public override void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 fromValue, bool setImmediately, bool isRelative) {} // 0x00000001857680CC-0x0000000185768348
		public override Vector3 ConvertToStartValue(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 value) => default; // 0x0000000183D555A0-0x0000000183D555C0
		public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3, VectorOptions> t) {} // 0x0000000185761BCC-0x0000000185761C40
		public override void SetChangeValue(TweenerCore<Vector3, Vector3, VectorOptions> t) {} // 0x0000000182FBC880-0x0000000182FBC920
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector3 changeValue) => default; // 0x0000000185761710-0x0000000185761734
		public override void EvaluateAndApply(VectorOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x000000018353D330-0x000000018353D4B0
	}
}

namespace DG.Tweening.Plugins.Core
{
	public interface ITPlugin<T1, out T2, out TPlugOptions, TPlugin> // TypeDefIndex: 55840
	{
	}

	internal static class SpecialPluginsUtils // TypeDefIndex: 55841
	{
		// Methods
		internal static bool SetLookAt(TweenerCore<Quaternion, Vector3, QuaternionOptions> t) => default; // 0x0000000185763700-0x0000000185763850
		internal static bool SetPunch(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) => default; // 0x0000000185763850-0x00000001857639FC
		internal static bool SetShake(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) => default; // 0x00000001857639FC-0x0000000185763A34
		internal static bool SetCameraShakePosition(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) => default; // 0x00000001857634DC-0x0000000185763700
	}

	public interface IPlugSetter<T1, out T2, TPlugin, out TPlugOptions> // TypeDefIndex: 55842
	{
		// Methods
		DOGetter<T1> Getter();
		DOSetter<T1> Setter();
		T2 EndValue();
		TPlugOptions GetOptions();
	}

	public interface ITweenPlugin // TypeDefIndex: 55843
	{
	}

	public abstract class ABSTweenPlugin<T1, T2, TPlugOptions> : ITweenPlugin // TypeDefIndex: 55844
		where TPlugOptions : struct, IPlugOptions
	{
		// Constructors
		protected ABSTweenPlugin() {}
	
		// Methods
		public abstract void Reset(TweenerCore<T1, T2, TPlugOptions> t);
		public abstract void SetFrom(TweenerCore<T1, T2, TPlugOptions> t, bool isRelative);
		public abstract void SetFrom(TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately, bool isRelative);
		public abstract T2 ConvertToStartValue(TweenerCore<T1, T2, TPlugOptions> t, T1 value);
		public abstract void SetRelativeEndValue(TweenerCore<T1, T2, TPlugOptions> t);
		public abstract void SetChangeValue(TweenerCore<T1, T2, TPlugOptions> t);
		public abstract float GetSpeedBasedDuration(TPlugOptions options, float unitsXSecond, T2 changeValue);
		public abstract void EvaluateAndApply(TPlugOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<T1> getter, DOSetter<T1> setter, float elapsed, T2 startValue, T2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice);
	}

	internal static class PluginsManager // TypeDefIndex: 55845
	{
		// Fields
		private static ITweenPlugin _floatPlugin; // 0x00
		private static ITweenPlugin _doublePlugin; // 0x08
		private static ITweenPlugin _intPlugin; // 0x10
		private static ITweenPlugin _uintPlugin; // 0x18
		private static ITweenPlugin _longPlugin; // 0x20
		private static ITweenPlugin _ulongPlugin; // 0x28
		private static ITweenPlugin _vector2Plugin; // 0x30
		private static ITweenPlugin _vector3Plugin; // 0x38
		private static ITweenPlugin _vector4Plugin; // 0x40
		private static ITweenPlugin _quaternionPlugin; // 0x48
		private static ITweenPlugin _colorPlugin; // 0x50
		private static ITweenPlugin _rectPlugin; // 0x58
		private static ITweenPlugin _rectOffsetPlugin; // 0x60
		private static ITweenPlugin _stringPlugin; // 0x68
		private static ITweenPlugin _vector3ArrayPlugin; // 0x70
		private static ITweenPlugin _color2Plugin; // 0x78
		private const int _MaxCustomPlugins = 20; // Metadata: 0x01FD76B8
		private static Dictionary<System.Type, ITweenPlugin> _customPlugins; // 0x80
	
		// Methods
		internal static ABSTweenPlugin<T1, T2, TPlugOptions> GetDefaultPlugin<T1, T2, TPlugOptions>()
			where TPlugOptions : struct, IPlugOptions => default;
		public static ABSTweenPlugin<T1, T2, TPlugOptions> GetCustomPlugin<TPlugin, T1, T2, TPlugOptions>()
			where TPlugin : ITweenPlugin, new()
			where TPlugOptions : struct, IPlugOptions => default;
		internal static void PurgeAll() {} // 0x0000000185761210-0x00000001857614D4
	}
}

namespace DG.Tweening.Plugins.Core.PathCore
{
	internal class CubicBezierDecoder : ABSPathDecoder // TypeDefIndex: 55846
	{
		// Fields
		private static readonly ControlPoint[] _PartialControlPs; // 0x00
		private static readonly Vector3[] _PartialWps; // 0x08
	
		// Properties
		internal override int minInputWaypoints { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
	
		// Constructors
		public CubicBezierDecoder() {} // 0x000000018350B670-0x000000018350B680
		static CubicBezierDecoder() {} // 0x000000018575B970-0x000000018575BA1C
	
		// Methods
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath) {} // 0x000000018575AC48-0x000000018575B190
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints) => default; // 0x000000018575B190-0x000000018575B428
		internal void SetTimeToLengthTables(Path p, int subdivisions) {} // 0x000000018575B428-0x000000018575B620
		internal void SetWaypointsLengths(Path p, int subdivisions) {} // 0x000000018575B620-0x000000018575B970
	}

	[Serializable]
	public struct ControlPoint // TypeDefIndex: 55847
	{
		// Fields
		public Vector3 a; // 0x00
		public Vector3 b; // 0x0C
	
		// Constructors
		public ControlPoint(Vector3 a, Vector3 b) {
			this.a = default;
			this.b = default;
		} // 0x0000000183D4FF30-0x0000000183D4FF50
	
		// Methods
		public static ControlPoint operator +(ControlPoint cp, Vector3 v) => default; // 0x000000018575AB9C-0x000000018575AC48
		public override string ToString() => default; // 0x000000018575AAAC-0x000000018575AB9C
	}

	internal abstract class ABSPathDecoder // TypeDefIndex: 55848
	{
		// Properties
		internal abstract int minInputWaypoints { get; }
	
		// Constructors
		protected ABSPathDecoder() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal abstract void FinalizePath(Path p, Vector3[] wps, bool isClosedPath);
		internal abstract Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints);
	}

	internal class CatmullRomDecoder : ABSPathDecoder // TypeDefIndex: 55849
	{
		// Fields
		private static readonly ControlPoint[] _PartialControlPs; // 0x00
		private static readonly Vector3[] _PartialWps; // 0x08
	
		// Properties
		internal override int minInputWaypoints { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public CatmullRomDecoder() {} // 0x000000018350B670-0x000000018350B680
		static CatmullRomDecoder() {} // 0x000000018575A790-0x000000018575A83C
	
		// Methods
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath) {} // 0x00000001857599CC-0x0000000185759CB8
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints) => default; // 0x0000000185759CB8-0x000000018575A19C
		internal void SetTimeToLengthTables(Path p, int subdivisions) {} // 0x000000018575A19C-0x000000018575A394
		internal void SetWaypointsLengths(Path p, int subdivisions) {} // 0x000000018575A394-0x000000018575A790
	}

	internal class LinearDecoder : ABSPathDecoder // TypeDefIndex: 55850
	{
		// Properties
		internal override int minInputWaypoints { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public LinearDecoder() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath) {} // 0x000000018575D78C-0x000000018575D7D8
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints) => default; // 0x000000018575D7D8-0x000000018575D9AC
		internal void SetTimeToLengthTables(Path p, int subdivisions) {} // 0x000000018575D9AC-0x000000018575DB68
		internal void SetWaypointsLengths(Path p, int subdivisions) {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class Path // TypeDefIndex: 55851
	{
		// Fields
		private static CatmullRomDecoder _catmullRomDecoder; // 0x00
		private static LinearDecoder _linearDecoder; // 0x08
		private static CubicBezierDecoder _cubicBezierDecoder; // 0x10
		public float[] wpLengths; // 0x10
		[SerializeField]
		public Vector3[] wps; // 0x18
		[SerializeField]
		internal PathType type; // 0x20
		[SerializeField]
		internal int subdivisionsXSegment; // 0x24
		[SerializeField]
		internal int subdivisions; // 0x28
		[SerializeField]
		internal ControlPoint[] controlPoints; // 0x30
		[SerializeField]
		internal float length; // 0x38
		[SerializeField]
		internal bool isFinalized; // 0x3C
		[SerializeField]
		internal float[] timesTable; // 0x40
		[SerializeField]
		internal float[] lengthsTable; // 0x48
		internal int linearWPIndex; // 0x50
		internal bool addedExtraStartWp; // 0x54
		internal bool addedExtraEndWp; // 0x55
		internal PathOptions plugOptions; // 0x58
		private Path _incrementalClone; // 0xC8
		private int _incrementalIndex; // 0xD0
		private ABSPathDecoder _decoder; // 0xD8
		private bool _changed; // 0xE0
		internal Vector3[] nonLinearDrawWps; // 0xE8
		internal Vector3 targetPosition; // 0xF0
		internal Vector3? lookAtPosition; // 0xFC
		internal UnityEngine.Color gizmoColor; // 0x10C
	
		// Properties
		internal int minInputWaypoints { get => default; } // 0x00000001857611EC-0x0000000185761210 
	
		// Constructors
		public Path(PathType type, Vector3[] waypoints, int subdivisionsXSegment, UnityEngine.Color? gizmoColor = default) {} // 0x000000018576106C-0x00000001857611EC
		internal Path() {} // 0x0000000183D55650-0x0000000183D55670
	
		// Methods
		internal void FinalizePath(bool isClosedPath, AxisConstraint lockPositionAxes, Vector3 currTargetVal) {} // 0x0000000185760C58-0x0000000185760D60
		internal Vector3 GetPoint(float perc, bool convertToConstantPerc = false /* Metadata: 0x01FD76B9 */) => default; // 0x0000000185760E58-0x0000000185760ED0
		internal float ConvertToConstantPathPerc(float perc) => default; // 0x00000001857603AC-0x00000001857604D4
		internal int GetWaypointIndexFromPerc(float perc, bool isMovingForward) => default; // 0x0000000185760ED0-0x0000000185760F64
		internal static Vector3[] GetDrawPoints(Path p, int drawSubdivisionsXSegment) => default; // 0x0000000185760D60-0x0000000185760E58
		internal static void RefreshNonLinearDrawWps(Path p) {} // 0x0000000185760F64-0x000000018576106C
		internal void Destroy() {} // 0x000000018576059C-0x00000001857606E4
		internal Path CloneIncremental(int loopIncrement) => default; // 0x000000018575FD78-0x00000001857603AC
		internal void AssignWaypoints(Vector3[] newWps, bool cloneWps = false /* Metadata: 0x01FD76BA */) {} // 0x000000018575FC90-0x000000018575FD78
		internal void AssignDecoder(PathType pathType) {} // 0x000000018575FB04-0x000000018575FC90
		internal void Draw() {} // 0x0000000185760C50-0x0000000185760C58
		private static void Draw(Path p) {} // 0x00000001857606E4-0x0000000185760C50
		private static Vector3 ConvertToDrawPoint(Vector3 wp, PathOptions plugOptions) => default; // 0x00000001857604D4-0x000000018576059C
	}
}

namespace DG.Tweening.Plugins.Options
{
	public interface IPlugOptions // TypeDefIndex: 55828
	{
		// Methods
		void Reset();
	}

	public enum OrientType // TypeDefIndex: 55829
	{
		None = 0,
		ToPath = 1,
		LookAtTransform = 2,
		LookAtPosition = 3
	}

	public struct PathOptions : IPlugOptions // TypeDefIndex: 55830
	{
		// Fields
		public PathMode mode; // 0x00
		public OrientType orientType; // 0x04
		public AxisConstraint lockPositionAxis; // 0x08
		public AxisConstraint lockRotationAxis; // 0x0C
		public bool isClosedPath; // 0x10
		public Vector3 lookAtPosition; // 0x14
		public Transform lookAtTransform; // 0x20
		public float lookAhead; // 0x28
		public bool hasCustomForwardDirection; // 0x2C
		public Quaternion forward; // 0x30
		public bool useLocalPosition; // 0x40
		public Transform parent; // 0x48
		public bool isRigidbody; // 0x50
		public bool isRigidbody2D; // 0x51
		public bool stableZRotation; // 0x52
		internal Quaternion startupRot; // 0x54
		internal float startupZRot; // 0x64
		internal bool addedExtraStartWp; // 0x68
		internal bool addedExtraEndWp; // 0x69
	
		// Methods
		public void Reset() {} // 0x000000018575DEA4-0x000000018575DF3C
	}

	public struct QuaternionOptions : IPlugOptions // TypeDefIndex: 55831
	{
		// Fields
		public DG.Tweening.RotateMode rotateMode; // 0x00
		public AxisConstraint axisConstraint; // 0x04
		public Vector3 up; // 0x08
		public bool dynamicLookAt; // 0x14
		public Vector3 dynamicLookAtWorldPosition; // 0x18
	
		// Methods
		public void Reset() {} // 0x0000000182FBC060-0x0000000182FBC090
	}

	public struct UintOptions : IPlugOptions // TypeDefIndex: 55832
	{
		// Fields
		public bool isNegativeChangeValue; // 0x00
	
		// Methods
		public void Reset() {} // 0x0000000183D4F9C0-0x0000000183D4F9D0
	}

	public struct Vector3ArrayOptions : IPlugOptions // TypeDefIndex: 55833
	{
		// Fields
		public AxisConstraint axisConstraint; // 0x00
		public bool snapping; // 0x04
		internal float[] durations; // 0x08
	
		// Methods
		public void Reset() {} // 0x0000000185767380-0x0000000185767394
	}

	public struct NoOptions : IPlugOptions // TypeDefIndex: 55834
	{
		// Methods
		public void Reset() {} // 0x000000018350B670-0x000000018350B680
	}

	public struct ColorOptions : IPlugOptions // TypeDefIndex: 55835
	{
		// Fields
		public bool alphaOnly; // 0x00
	
		// Methods
		public void Reset() {} // 0x0000000183D4F9C0-0x0000000183D4F9D0
	}

	public struct FloatOptions : IPlugOptions // TypeDefIndex: 55836
	{
		// Fields
		public bool snapping; // 0x00
	
		// Methods
		public void Reset() {} // 0x0000000183D4F9C0-0x0000000183D4F9D0
	}

	public struct RectOptions : IPlugOptions // TypeDefIndex: 55837
	{
		// Fields
		public bool snapping; // 0x00
	
		// Methods
		public void Reset() {} // 0x0000000183D4F9C0-0x0000000183D4F9D0
	}

	public struct StringOptions : IPlugOptions // TypeDefIndex: 55838
	{
		// Fields
		public bool richTextEnabled; // 0x00
		public ScrambleMode scrambleMode; // 0x04
		public char[] scrambledChars; // 0x08
		internal int startValueStrippedLength; // 0x10
		internal int changeValueStrippedLength; // 0x14
	
		// Methods
		public void Reset() {} // 0x0000000185763A34-0x0000000185763A5C
	}

	public struct VectorOptions : IPlugOptions // TypeDefIndex: 55839
	{
		// Fields
		public AxisConstraint axisConstraint; // 0x00
		public bool snapping; // 0x04
	
		// Methods
		public void Reset() {} // 0x0000000183D556A0-0x0000000183D556B0
	}
}
