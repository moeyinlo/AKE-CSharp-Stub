/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;

// Image 41: DOTween.dll - Assembly: DOTween, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 56696-56896

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 56896
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_50 _4EF0676A416B9CCF117C378BDCB6C5CA0EA9505154E3F0F7CC8570285DB79663; // 0x00 // Static value (base64): QQBCAEMARABFAEYARwBIAEkASgBLAEwATQBOAE8AUABRAFIAUwBUAFUAVgBYAFkAWgA= - Metadata: 0x0207D0EC
	internal static readonly __StaticArrayInitTypeSize_20 _921D53955C220A863C9C5D33DD45329C6F74471C522EA5D46EA838D8D4838055; // 0x32 // Static value (base64): MQAyADMANAA1ADYANwA4ADkAMAA= - Metadata: 0x0207D124
	internal static readonly __StaticArrayInitTypeSize_120 A203B1199E78DE3BB75B28FC520ED2F86ADB2749BFC52E3ACA275A3BE2587678; // 0x46 // Static value (base64): QQBCAEMARABFAEYARwBIAEkASgBLAEwATQBOAE8AUABRAFIAUwBUAFUAVgBYAFkAWgBhAGIAYwBkAGUAZgBnAGgAaQBqAGsAbABtAG4AbwBwAHEAcgBzAHQAdQB2AHgAeQB6ADEAMgAzADQANQA2ADcAOAA5ADAA - Metadata: 0x0207D13C
	internal static readonly __StaticArrayInitTypeSize_50 C845A807AA8EC73757DC1B07EA49311061FEDECA35AFFE91C5474E0814925020; // 0xBE // Static value (base64): YQBiAGMAZABlAGYAZwBoAGkAagBrAGwAbQBuAG8AcABxAHIAcwB0AHUAdgB4AHkAegA= - Metadata: 0x0207D1BC

	// Nested types
	private struct __StaticArrayInitTypeSize_20 // TypeDefIndex: 56893
	{
	}

	private struct __StaticArrayInitTypeSize_50 // TypeDefIndex: 56894
	{
	}

	private struct __StaticArrayInitTypeSize_120 // TypeDefIndex: 56895
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace DG.Tweening
{
	public enum AutoPlay // TypeDefIndex: 56697
	{
		None = 0,
		AutoPlaySequences = 1,
		AutoPlayTweeners = 2,
		All = 3
	}

	public enum AxisConstraint // TypeDefIndex: 56698
	{
		None = 0,
		X = 2,
		Y = 4,
		Z = 8,
		W = 16
	}

	public struct Color2 // TypeDefIndex: 56699
	{
		// Fields
		public UnityEngine.Color ca; // 0x00
		public UnityEngine.Color cb; // 0x10
	
		// Constructors
		public Color2(UnityEngine.Color ca, UnityEngine.Color cb) {
			this.ca = default;
			this.cb = default;
		} // 0x0000000185FB6710-0x0000000185FB6720
	
		// Methods
		public static Color2 operator +(Color2 c1, Color2 c2) => default; // 0x00000001878EFC5C-0x00000001878EFCD8
		public static Color2 operator -(Color2 c1, Color2 c2) => default; // 0x00000001878EFD38-0x00000001878EFDB4
		public static Color2 operator *(Color2 c1, float f) => default; // 0x00000001878EFCD8-0x00000001878EFD38
	}

	public delegate void TweenCallback(); // TypeDefIndex: 56700; 0x00000001864BC320-0x00000001864BC330

	public delegate void TweenCallback<in T>(T value); // TypeDefIndex: 56701; 0x00000000-0x00000000

	public delegate float EaseFunction(float time, float duration, float overshootOrAmplitude, float period); // TypeDefIndex: 56702; 0x00000001878F42F8-0x00000001878F430C

	public static class DOCurve // TypeDefIndex: 56704
	{
		// Nested types
		public static class CubicBezier // TypeDefIndex: 56703
		{
			// Methods
			public static Vector3 GetPointOnSegment(Vector3 startPoint, Vector3 startControlPoint, Vector3 endPoint, Vector3 endControlPoint, float factor) => default; // 0x00000001878EFDB4-0x00000001878EFF44
			public static Vector3[] GetSegmentPointCloud(Vector3 startPoint, Vector3 startControlPoint, Vector3 endPoint, Vector3 endControlPoint, int resolution = 10 /* Metadata: 0x0207CE02 */) => default; // 0x00000001878EFF44-0x00000001878F00A8
			public static void GetSegmentPointCloud(List<Vector3> addToList, Vector3 startPoint, Vector3 startControlPoint, Vector3 endPoint, Vector3 endControlPoint, int resolution = 10 /* Metadata: 0x0207CE03 */) {} // 0x00000001878F00A8-0x00000001878F01F8
		}
	}

	public class DOTween // TypeDefIndex: 56706
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
		public static LogBehaviour logBehaviour { get => default; set {} } // 0x00000001878F301C-0x00000001878F3070 0x0000000185625AB0-0x0000000185625B10
		public static bool debugStoreTargetId { get => default; set {} } // 0x00000001878F3070-0x00000001878F30E4 0x00000001878F0968-0x00000001878F0A74
		internal static bool isQuitting { get => default; set {} } // 0x0000000185625260-0x0000000185625330 0x00000001856255E0-0x0000000185625AB0
	
		// Nested types
		private sealed class __c__DisplayClass67_0 // TypeDefIndex: 56705
		{
			// Fields
			public float v; // 0x10
			public DOSetter<float> setter; // 0x18
	
			// Constructors
			public __c__DisplayClass67_0() {} // 0x00000001878F2FCC-0x00000001878F301C
	
			// Methods
			internal float _To_b__0() => default; // 0x0000000185625B10-0x0000000185625BB0
			internal void _To_b__1(float x) {} // 0x000000018545E1D0-0x000000018545E290
		}
	
		// Constructors
		public DOTween() {} // 0x0000000181DCCCE0-0x0000000181DCCCF0
		static DOTween() {} // 0x000000018790046C-0x0000000187900490
	
		// Methods
		public static IDOTweenInit Init(bool? recycleAllByDefault = default, bool? useSafeMode = default, LogBehaviour? logBehaviour = default) => default; // 0x00000001878F1904-0x00000001878F195C
		private static void AutoInit() {} // 0x00000001878F04CC-0x00000001878F0518
		private static IDOTweenInit Init(DOTweenSettings settings, bool? recycleAllByDefault, bool? useSafeMode, LogBehaviour? logBehaviour) => default; // 0x00000001878F0238-0x00000001878F04CC
		public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity) {} // 0x00000001878F01F8-0x00000001878F0238
		public static void Clear(bool destroy = false /* Metadata: 0x0207CE04 */) {} // 0x00000001878F2F8C-0x00000001878F2FCC
		internal static void Clear(bool destroy, bool isApplicationQuitting) {} // 0x00000001878F0C8C-0x00000001878F0D84
		public static void ClearCachedTweens() {} // 0x00000001844A7970-0x00000001844A7A10
		public static int Validate() => default; // 0x00000001878F2B04-0x00000001878F2B90
		public static void ManualUpdate(float deltaTime, float unscaledDeltaTime) {} // 0x00000001878F29D8-0x00000001878F2A64
		public static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration) => default; // 0x00000001878F25AC-0x00000001878F2638
		public static TweenerCore<double, double, NoOptions> To(DOGetter<double> getter, DOSetter<double> setter, double endValue, float duration) => default; // 0x00000001878F2488-0x00000001878F2514
		public static TweenerCore<int, int, NoOptions> To(DOGetter<int> getter, DOSetter<int> setter, int endValue, float duration) => default; // 0x00000001878F27E8-0x00000001878F2874
		public static TweenerCore<uint, uint, UintOptions> To(DOGetter<uint> getter, DOSetter<uint> setter, uint endValue, float duration) => default; // 0x00000001878F2638-0x00000001878F26C4
		public static TweenerCore<long, long, NoOptions> To(DOGetter<long> getter, DOSetter<long> setter, long endValue, float duration) => default; // 0x00000001844A6110-0x00000001844A61B0
		public static TweenerCore<ulong, ulong, NoOptions> To(DOGetter<ulong> getter, DOSetter<ulong> setter, ulong endValue, float duration) => default; // 0x0000000184973670-0x0000000184973720
		public static TweenerCore<string, string, StringOptions> To(DOGetter<string> getter, DOSetter<string> setter, string endValue, float duration) => default; // 0x00000001878F2B90-0x00000001878F2C28
		public static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration) => default; // 0x0000000184973AB0-0x0000000184973B60
		public static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration) => default; // 0x00000001878F2514-0x00000001878F25AC
		public static TweenerCore<Vector4, Vector4, VectorOptions> To(DOGetter<Vector4> getter, DOSetter<Vector4> setter, Vector4 endValue, float duration) => default; // 0x00000001878F2750-0x00000001878F27E8
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration) => default; // 0x00000001878F26C4-0x00000001878F2750
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> To(DOGetter<UnityEngine.Color> getter, DOSetter<UnityEngine.Color> setter, UnityEngine.Color endValue, float duration) => default;
		public static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration) => default; // 0x00000001878F23DC-0x00000001878F2488
		public static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration) => default; // 0x00000001844A4770-0x00000001844A4850
		public static TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration)
			where TPlugOptions : struct, IPlugOptions => default; // 0x00000001878F2874-0x00000001878F29D8
		public static TweenerCore<Vector3, Vector3, VectorOptions> ToAxis(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float endValue, float duration, AxisConstraint axisConstraint = AxisConstraint.X /* Metadata: 0x0207CE05 */) => default; // 0x00000001878F12FC-0x00000001878F1648
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> ToAlpha(DOGetter<UnityEngine.Color> getter, DOSetter<UnityEngine.Color> setter, float endValue, float duration) => default; // 0x00000001878F2040-0x00000001878F2114
		public static Tweener To(DOSetter<float> setter, float startValue, float endValue, float duration) => default; // 0x00000001878F1F74-0x00000001878F2040
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10 /* Metadata: 0x0207CE06 */, float elasticity = 1f /* Metadata: 0x0207CE07 */) => default; // 0x00000001878F195C-0x00000001878F1F74
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3f /* Metadata: 0x0207CE0B */, int vibrato = 10 /* Metadata: 0x0207CE0F */, float randomness = 90f /* Metadata: 0x0207CE10 */, bool ignoreZAxis = true /* Metadata: 0x0207CE14 */, bool fadeOut = true /* Metadata: 0x0207CE15 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0207CE16 */) => default; // 0x00000001878F21E0-0x00000001878F23DC
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x0207CE17 */, float randomness = 90f /* Metadata: 0x0207CE18 */, bool fadeOut = true /* Metadata: 0x0207CE1C */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0207CE1D */) => default; // 0x00000001878F2A64-0x00000001878F2B04
		private static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut, ShakeRandomnessMode randomnessMode) => default; // 0x00000001844A68F0-0x00000001844A6980
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3[] endValues, float[] durations) => default; // 0x00000001878F18A8-0x00000001878F1904
		internal static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration) => default; // 0x00000001878F0518-0x00000001878F0580
		public static DG.Tweening.Sequence Sequence() => default; // 0x00000001878F0730-0x00000001878F07AC
		public static DG.Tweening.Sequence Sequence(object target) => default; // 0x00000001878F0654-0x00000001878F06B0
		public static int CompleteAll(bool withCallbacks = false /* Metadata: 0x0207CE1E */) => default; // 0x00000001878F05E4-0x00000001878F0654
		public static int Complete(object targetOrId, bool withCallbacks = false /* Metadata: 0x0207CE1F */) => default; // 0x00000001878F06B0-0x00000001878F0730
		internal static int CompleteAndReturnKilledTot() => default; // 0x00000001878F0580-0x00000001878F05E4
		internal static int CompleteAndReturnKilledTot(object targetOrId) => default; // 0x00000001878F07AC-0x00000001878F0808
		internal static int CompleteAndReturnKilledTot(object target, object id) => default; // 0x00000001878F0808-0x00000001878F0878
		internal static int CompleteAndReturnKilledTotExceptFor(object[] excludeTargetsOrIds) => default; // 0x00000001878F0878-0x00000001878F08E4
		public static int FlipAll() => default; // 0x00000001878F08E4-0x00000001878F0968
		public static int Flip(object targetOrId) => default; // 0x00000001852D4D20-0x00000001852D4D80
		public static int GotoAll(float to, bool andPlay = false /* Metadata: 0x0207CE20 */) => default; // 0x00000001878F0AEC-0x00000001878F0BCC
		public static int Goto(object targetOrId, float to, bool andPlay = false /* Metadata: 0x0207CE21 */) => default; // 0x00000001844AB340-0x00000001844AB3F0
		public static int KillAll(bool complete = false /* Metadata: 0x0207CE22 */) => default; // 0x00000001878F0BCC-0x00000001878F0C8C
		public static int KillAll(bool complete, object[] idsOrTargetsToExclude) => default; // 0x00000001878F0D84-0x00000001878F0DE0
		public static int Kill(object targetOrId, bool complete = false /* Metadata: 0x0207CE23 */) => default; // 0x00000001878F0DE0-0x00000001878F0E50
		public static int Kill(object target, object id, bool complete = false /* Metadata: 0x0207CE24 */) => default; // 0x00000001878F0EB4-0x00000001878F0F10
		public static int PauseAll() => default; // 0x00000001878F11A8-0x00000001878F1218
		public static int Pause(object targetOrId) => default; // 0x00000001878F1218-0x00000001878F1298
		public static int PlayAll() => default; // 0x00000001878F0F10-0x00000001878F0F6C
		public static int Play(object targetOrId) => default; // 0x00000001878F0F6C-0x00000001878F0FDC
		public static int Play(object target, object id) => default; // 0x00000001878F0FDC-0x00000001878F105C
		public static int PlayBackwardsAll() => default; // 0x00000001878F105C-0x00000001878F10B8
		public static int PlayBackwards(object targetOrId) => default; // 0x00000001878F10B8-0x00000001878F1128
		public static int PlayBackwards(object target, object id) => default; // 0x00000001878F1128-0x00000001878F11A8
		public static int PlayForwardAll() => default; // 0x00000001878F1648-0x00000001878F16AC
		public static int PlayForward(object targetOrId) => default; // 0x00000001878F1744-0x00000001878F17C8
		public static int PlayForward(object target, object id) => default; // 0x00000001878F16AC-0x00000001878F1744
		public static int RestartAll(bool includeDelay = true /* Metadata: 0x0207CE25 */) => default; // 0x00000001878F17C8-0x00000001878F182C
		public static int Restart(object targetOrId, bool includeDelay = true /* Metadata: 0x0207CE26 */, float changeDelayTo = -1f /* Metadata: 0x0207CE27 */) => default; // 0x00000001878F182C-0x00000001878F18A8
		public static int Restart(object target, object id, bool includeDelay = true /* Metadata: 0x0207CE2B */, float changeDelayTo = -1f /* Metadata: 0x0207CE2C */) => default; // 0x00000001878F2114-0x00000001878F2170
		public static int RewindAll(bool includeDelay = true /* Metadata: 0x0207CE30 */) => default; // 0x00000001878F2170-0x00000001878F21E0
		public static int Rewind(object targetOrId, bool includeDelay = true /* Metadata: 0x0207CE31 */) => default; // 0x00000001878F2C28-0x00000001878F2C84
		public static int SmoothRewindAll() => default; // 0x00000001878F2C84-0x00000001878F2CF4
		public static int SmoothRewind(object targetOrId) => default; // 0x00000001878F0A74-0x00000001878F0AEC
		public static int TogglePauseAll() => default; // 0x00000001878F2D94-0x00000001878F2DE4
		public static int TogglePause(object targetOrId) => default; // 0x00000001878F2D44-0x00000001878F2D94
		public static bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying = false /* Metadata: 0x0207CE32 */) => default; // 0x00000001878F2CF4-0x00000001878F2D44
		public static int TotalActiveTweens() => default; // 0x00000001878F2DE4-0x00000001878F2E24
		public static int TotalActiveTweeners() => default; // 0x00000001878F2E24-0x00000001878F2E80
		public static int TotalActiveSequences() => default; // 0x00000001878F1298-0x00000001878F12FC
		public static int TotalPlayingTweens() => default; // 0x00000001878F0E50-0x00000001878F0EB4
		public static int TotalTweensById(object id, bool playingOnly = false /* Metadata: 0x0207CE33 */) => default; // 0x00000001878F2E80-0x00000001878F2F0C
		public static List<DG.Tweening.Tween> PlayingTweens(List<DG.Tweening.Tween> fillableList = null) => default; // 0x00000001878F2F0C-0x00000001878F2F8C
		public static List<DG.Tweening.Tween> PausedTweens(List<DG.Tweening.Tween> fillableList = null) => default; // 0x00000001844A6E80-0x00000001844A6F30
		public static List<DG.Tweening.Tween> TweensById(object id, bool playingOnly = false /* Metadata: 0x0207CE34 */, List<DG.Tweening.Tween> fillableList = null) => default;
		public static List<DG.Tweening.Tween> TweensByTarget(object target, bool playingOnly = false /* Metadata: 0x0207CE35 */, List<DG.Tweening.Tween> fillableList = null) => default; // 0x0000000185492010-0x0000000185492020
		private static void InitCheck() {} // 0x0000000185BBEB30-0x0000000185BBEDA0
		private static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null)
			where TPlugOptions : struct, IPlugOptions => default; // 0x0000000185492010-0x0000000185492020
	}

	public static class DOVirtual // TypeDefIndex: 56711
	{
		// Nested types
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 56707
		{
			// Fields
			public float val; // 0x10
			public TweenCallback<float> onVirtualUpdate; // 0x18
	
			// Constructors
			public __c__DisplayClass0_0() {} // 0x00000001878F3B14-0x00000001878F3CC8
	
			// Methods
			internal float _Float_b__0() => default; // 0x00000001878F3CC8-0x00000001878F3E68
			internal void _Float_b__1(float x) {} // 0x00000001878F3E68-0x00000001878F402C
			internal void _Float_b__2() {} // 0x00000001878F30E4-0x00000001878F3298
		}
	
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 56708
		{
			// Fields
			public int val; // 0x10
			public TweenCallback<int> onVirtualUpdate; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0() {} // 0x00000001844ACA00-0x00000001844ACAD0
	
			// Methods
			internal int _Int_b__0() => default; // 0x00000001878F36E0-0x00000001878F3790
			internal void _Int_b__1(int x) {} // 0x00000001878F3AAC-0x00000001878F3B14
			internal void _Int_b__2() {} // 0x00000001878F3460-0x00000001878F3598
		}
	
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 56709
		{
			// Fields
			public Vector3 val; // 0x10
			public TweenCallback<Vector3> onVirtualUpdate; // 0x20
	
			// Constructors
			public __c__DisplayClass2_0() {} // 0x00000001878F3964-0x00000001878F3AAC
	
			// Methods
			internal Vector3 _Vector3_b__0() => default; // 0x00000001878F3598-0x00000001878F36E0
			internal void _Vector3_b__1(Vector3 x) {} // 0x00000001878F3358-0x00000001878F3460
			internal void _Vector3_b__2() {} // 0x00000001878F3790-0x00000001878F3964
		}
	
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 56710
		{
			// Fields
			public UnityEngine.Color val; // 0x10
			public TweenCallback<UnityEngine.Color> onVirtualUpdate; // 0x20
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x00000001878F3298-0x00000001878F3358
	
			// Methods
			internal UnityEngine.Color _Color_b__0() => default; // 0x0000000185492010-0x0000000185492020
			internal void _Color_b__1(UnityEngine.Color x) {} // 0x0000000181DCCCE0-0x0000000181DCCCF0
			internal void _Color_b__2() {} // 0x0000000181A6E380-0x0000000181A6E390
		}
	
		// Methods
		public static Tweener Float(float from, float to, float duration, TweenCallback<float> onVirtualUpdate) => default; // 0x00000001878FF698-0x00000001878FF6C0
		public static Tweener Int(int from, int to, float duration, TweenCallback<int> onVirtualUpdate) => default; // 0x0000000185492010-0x0000000185492020
		public static Tweener Vector3(Vector3 from, Vector3 to, float duration, TweenCallback<Vector3> onVirtualUpdate) => default; // 0x0000000181C0BBD0-0x0000000181C0BBE0
		public static Tweener Color(UnityEngine.Color from, UnityEngine.Color to, float duration, TweenCallback<UnityEngine.Color> onVirtualUpdate) => default; // 0x0000000181378230-0x0000000181378240
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType) => default; // 0x00000001878FFA54-0x00000001878FFA7C
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float overshoot) => default; // 0x0000000185492010-0x0000000185492020
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float amplitude, float period) => default; // 0x00000001834AE2B0-0x00000001834AE2D0
		public static float EasedValue(float from, float to, float lifetimePercentage, AnimationCurve easeCurve) => default; // 0x0000000185FB6850-0x0000000185FB6860
		public static Vector3 EasedValue(Vector3 from, Vector3 to, float lifetimePercentage, Ease easeType) => default; // 0x00000001878FFDE4-0x00000001878FFE20
		public static Vector3 EasedValue(Vector3 from, Vector3 to, float lifetimePercentage, Ease easeType, float overshoot) => default; // 0x0000000185492010-0x0000000185492020
		public static Vector3 EasedValue(Vector3 from, Vector3 to, float lifetimePercentage, Ease easeType, float amplitude, float period) => default; // 0x00000001834A7540-0x00000001834A7550
		public static Vector3 EasedValue(Vector3 from, Vector3 to, float lifetimePercentage, AnimationCurve easeCurve) => default; // 0x0000000185FB6860-0x0000000185FB6870
		public static DG.Tweening.Tween DelayedCall(float delay, TweenCallback callback, bool ignoreTimeScale = true /* Metadata: 0x0207CE36 */) => default; // 0x00000001878FFFA0-0x00000001878FFFD4
	}

	public enum Ease // TypeDefIndex: 56712
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

	public class EaseFactory // TypeDefIndex: 56714
	{
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 56713
		{
			// Fields
			public float motionDelay; // 0x10
			public EaseFunction customEase; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0() {} // 0x00000001878F40F0-0x00000001878F418C
	
			// Methods
			internal float _StopMotion_b__0(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x00000001878F418C-0x00000001878F4244
		}
	
		// Constructors
		public EaseFactory() {} // 0x00000001878FFD78-0x00000001878FFDE4
	
		// Methods
		public static EaseFunction StopMotion(int motionFps, Ease? ease = default) => default; // 0x00000001878F402C-0x00000001878F40F0
		public static EaseFunction StopMotion(int motionFps, AnimationCurve animCurve) => default; // 0x0000000185492010-0x0000000185492020
		public static EaseFunction StopMotion(int motionFps, EaseFunction customEase) => default; // 0x0000000185492010-0x0000000185492020
	}

	public interface IDOTweenInit // TypeDefIndex: 56715
	{
		// Methods
		IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity);
	}

	public enum LinkBehaviour // TypeDefIndex: 56716
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

	public enum PathMode // TypeDefIndex: 56717
	{
		Ignore = 0,
		Full3D = 1,
		TopDown2D = 2,
		Sidescroller2D = 3
	}

	public enum PathType // TypeDefIndex: 56718
	{
		Linear = 0,
		CatmullRom = 1,
		CubicBezier = 2
	}

	public enum RotateMode // TypeDefIndex: 56719
	{
		Fast = 0,
		FastBeyond360 = 1,
		WorldAxisAdd = 2,
		LocalAxisAdd = 3
	}

	public enum ScrambleMode // TypeDefIndex: 56720
	{
		None = 0,
		All = 1,
		Uppercase = 2,
		Lowercase = 3,
		Numerals = 4,
		Custom = 5
	}

	public enum ShakeRandomnessMode // TypeDefIndex: 56721
	{
		Full = 0,
		Harmonic = 1
	}

	public static class TweenExtensions // TypeDefIndex: 56722
	{
		// Methods
		public static void Complete(DG.Tweening.Tween t) {} // 0x00000001878FCFD8-0x00000001878FCFE4
		public static void Complete(DG.Tweening.Tween t, bool withCallbacks) {} // 0x00000001878FCFE4-0x00000001878FD094
		public static void Flip(DG.Tweening.Tween t) {} // 0x00000001878FD484-0x00000001878FD528
		public static void ForceInit(DG.Tweening.Tween t) {} // 0x00000001878FD528-0x00000001878FD5D0
		public static void Goto(DG.Tweening.Tween t, float to, bool andPlay = false /* Metadata: 0x0207CE7B */) {} // 0x00000001878FD854-0x00000001878FD870
		public static void GotoWithCallbacks(DG.Tweening.Tween t, float to, bool andPlay = false /* Metadata: 0x0207CE7C */) {} // 0x00000001878FD838-0x00000001878FD854
		private static void DoGoto(DG.Tweening.Tween t, float to, bool andPlay, bool withCallbacks) {} // 0x00000001878FD118-0x00000001878FD220
		public static void Kill(DG.Tweening.Tween t, bool complete = false /* Metadata: 0x0207CE7D */) {} // 0x00000001844AA2D0-0x00000001844AA480
		public static void ManualUpdate(DG.Tweening.Tween t, float deltaTime, float unscaledDeltaTime) {} // 0x00000001878FD930-0x00000001878FD9F0
		public static T Pause<T>(T t)
			where T : DG.Tweening.Tween => default;
		public static T Play<T>(T t)
			where T : DG.Tweening.Tween => default;
		public static void PlayBackwards(DG.Tweening.Tween t) {} // 0x00000001878FDD6C-0x00000001878FDE10
		public static void PlayForward(DG.Tweening.Tween t) {} // 0x00000001878FDE10-0x00000001878FDEB4
		public static void Restart(DG.Tweening.Tween t, bool includeDelay = true /* Metadata: 0x0207CE7E */, float changeDelayTo = -1f /* Metadata: 0x0207CE7F */) {} // 0x000000018415BEB0-0x000000018415BF50
		public static void Rewind(DG.Tweening.Tween t, bool includeDelay = true /* Metadata: 0x0207CE83 */) {} // 0x00000001878FDEB4-0x00000001878FDF60
		public static void SmoothRewind(DG.Tweening.Tween t) {} // 0x00000001878FDF60-0x00000001878FE004
		public static void TogglePause(DG.Tweening.Tween t) {} // 0x00000001878FE004-0x00000001878FE0A8
		public static void GotoWaypoint(DG.Tweening.Tween t, int waypointIndex, bool andPlay = false /* Metadata: 0x0207CE84 */) {} // 0x00000001878FD5D0-0x00000001878FD838
		public static YieldInstruction WaitForCompletion(DG.Tweening.Tween t) => default; // 0x00000001878FE0A8-0x00000001878FE148
		public static YieldInstruction WaitForRewind(DG.Tweening.Tween t) => default; // 0x00000001878FE348-0x00000001878FE3E8
		public static YieldInstruction WaitForKill(DG.Tweening.Tween t) => default; // 0x00000001878FE1F8-0x00000001878FE298
		public static YieldInstruction WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops) => default; // 0x00000001878FE148-0x00000001878FE1F8
		public static YieldInstruction WaitForPosition(DG.Tweening.Tween t, float position) => default; // 0x00000001878FE298-0x00000001878FE348
		public static Coroutine WaitForStart(DG.Tweening.Tween t) => default; // 0x00000001878FE3E8-0x00000001878FE488
		public static int CompletedLoops(DG.Tweening.Tween t) => default; // 0x00000001878FD094-0x00000001878FD0D4
		public static float Delay(DG.Tweening.Tween t) => default; // 0x00000001878FD0D4-0x00000001878FD118
		public static float ElapsedDelay(DG.Tweening.Tween t) => default; // 0x00000001878FD290-0x00000001878FD2D4
		public static float Duration(DG.Tweening.Tween t, bool includeLoops = true /* Metadata: 0x0207CE85 */) => default; // 0x00000001878FD220-0x00000001878FD290
		public static float Elapsed(DG.Tweening.Tween t, bool includeLoops = true /* Metadata: 0x0207CE86 */) => default; // 0x00000001878FD414-0x00000001878FD484
		public static float ElapsedPercentage(DG.Tweening.Tween t, bool includeLoops = true /* Metadata: 0x0207CE87 */) => default; // 0x00000001878FD374-0x00000001878FD414
		public static float ElapsedDirectionalPercentage(DG.Tweening.Tween t) => default; // 0x00000001878FD2D4-0x00000001878FD374
		public static bool IsActive(DG.Tweening.Tween t) => default; // 0x0000000184B8E4A0-0x0000000184B8E4B0
		public static bool IsBackwards(DG.Tweening.Tween t) => default; // 0x00000001878FD870-0x00000001878FD8B0
		public static bool IsComplete(DG.Tweening.Tween t) => default; // 0x0000000184B8E9D0-0x0000000184B8EA00
		public static bool IsInitialized(DG.Tweening.Tween t) => default; // 0x00000001878FD8B0-0x00000001878FD8F0
		public static bool IsPlaying(DG.Tweening.Tween t) => default; // 0x000000018415DBD0-0x000000018415DC00
		public static int Loops(DG.Tweening.Tween t) => default; // 0x00000001878FD8F0-0x00000001878FD930
		public static Vector3 PathGetPoint(DG.Tweening.Tween t, float pathPercentage) => default; // 0x00000001878FDB00-0x00000001878FDC64
		public static Vector3[] PathGetDrawPoints(DG.Tweening.Tween t, int subdivisionsXSegment = 10 /* Metadata: 0x0207CE88 */) => default; // 0x00000001878FD9F0-0x00000001878FDB00
		public static float PathLength(DG.Tweening.Tween t) => default; // 0x00000001878FDC64-0x00000001878FDD6C
	}

	public enum LoopType // TypeDefIndex: 56723
	{
		Restart = 0,
		Yoyo = 1,
		Incremental = 2
	}

	public sealed class Sequence : DG.Tweening.Tween // TypeDefIndex: 56724
	{
		// Fields
		internal readonly List<DG.Tweening.Tween> sequencedTweens; // 0x120
		private readonly List<ABSSequentiable> _sequencedObjs; // 0x128
		internal float lastTweenInsertTime; // 0x130
	
		// Constructors
		internal Sequence() {} // 0x00000001844A6F30-0x00000001844A7040
	
		// Methods
		internal static Sequence DoPrepend(Sequence inSequence, DG.Tweening.Tween t) => default; // 0x00000001878F43E4-0x00000001878F4520
		internal static Sequence DoInsert(Sequence inSequence, DG.Tweening.Tween t, float atPosition) => default; // 0x00000001844A6650-0x00000001844A67F0
		internal static Sequence DoAppendInterval(Sequence inSequence, float interval) => default; // 0x00000001844A4C70-0x00000001844A4CB0
		internal static Sequence DoPrependInterval(Sequence inSequence, float interval) => default; // 0x00000001878F430C-0x00000001878F43E4
		internal static Sequence DoInsertCallback(Sequence inSequence, TweenCallback callback, float atPosition) => default; // 0x0000000185D24030-0x0000000185D24100
		internal override float UpdateDelay(float elapsed) => default; // 0x00000001878F4520-0x00000001878F4550
		internal override void Reset() {} // 0x0000000184E15CA0-0x0000000184E15D30
		internal override bool Validate() => default; // 0x00000001878F4550-0x00000001878F45F4
		internal override bool Startup() => default; // 0x0000000185577490-0x00000001855774A0
		internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, UpdateNotice updateNotice) => default; // 0x00000001844AE1C0-0x00000001844AE1E0
		internal static void Setup(Sequence s) {} // 0x00000001844A7040-0x00000001844A7190
		internal static bool DoStartup(Sequence s) => default; // 0x00000001855774A0-0x00000001855775F0
		internal static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode) => default; // 0x00000001844AE1E0-0x00000001844AE530
		private static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, DG.Tweening.Core.Enums.UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = false /* Metadata: 0x0207CE8C */) => default; // 0x00000001844AE530-0x00000001844AE9C0
		private static void StableSortSequencedObjs(List<ABSSequentiable> list) {} // 0x00000001855775F0-0x00000001855776F0
		private static bool IsAnyCallbackSet(Sequence s) => default; // 0x00000001855776F0-0x0000000185577750
	}

	public static class ShortcutExtensions // TypeDefIndex: 56801
	{
		// Nested types
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 56725
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass0_0() {} // 0x00000001878F45F4-0x00000001878F4750
	
			// Methods
			internal float _DOAspect_b__0() => default; // 0x00000001878F5F98-0x00000001878F6100
			internal void _DOAspect_b__1(float x) {} // 0x00000001878F6860-0x00000001878F69BC
		}
	
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 56726
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass1_0() {} // 0x00000001878F69BC-0x00000001878F6B18
	
			// Methods
			internal UnityEngine.Color _DOColor_b__0() => default; // 0x00000001878F8CC4-0x00000001878F8E20
			internal void _DOColor_b__1(UnityEngine.Color x) {} // 0x00000001878F9130-0x00000001878F928C
		}
	
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 56727
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0() {} // 0x00000001878F96CC-0x00000001878F9834
	
			// Methods
			internal float _DOFarClipPlane_b__0() => default; // 0x00000001878F9FA4-0x00000001878FA10C
			internal void _DOFarClipPlane_b__1(float x) {} // 0x00000001878FB094-0x00000001878FB294
		}
	
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 56728
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x00000001878FB4A8-0x00000001878FB6BC
	
			// Methods
			internal float _DOFieldOfView_b__0() => default; // 0x00000001878FBCE4-0x00000001878FBEE4
			internal void _DOFieldOfView_b__1(float x) {} // 0x00000001878FB6BC-0x00000001878FB8D0
		}
	
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 56729
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x00000001878F5E30-0x00000001878F5F98
	
			// Methods
			internal float _DONearClipPlane_b__0() => default; // 0x00000001878F6FB8-0x00000001878F7114
			internal void _DONearClipPlane_b__1(float x) {} // 0x00000001878FAD14-0x00000001878FAE70
		}
	
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 56730
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0() {} // 0x00000001878F59A4-0x00000001878F5B20
	
			// Methods
			internal float _DOOrthoSize_b__0() => default; // 0x00000001878F5B20-0x00000001878F5C88
			internal void _DOOrthoSize_b__1(float x) {} // 0x00000001878F6100-0x00000001878F62B8
		}
	
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 56731
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass6_0() {} // 0x00000001878F5C88-0x00000001878F5E30
	
			// Methods
			internal Rect _DOPixelRect_b__0() => default; // 0x00000001878F63BC-0x00000001878F6518
			internal void _DOPixelRect_b__1(Rect x) {} // 0x00000001878F66B4-0x00000001878F6860
		}
	
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 56732
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0() {} // 0x00000001878F6518-0x00000001878F66B4
	
			// Methods
			internal Rect _DORect_b__0() => default; // 0x00000001878F6D4C-0x00000001878F6EF8
			internal void _DORect_b__1(Rect x) {} // 0x00000001878F6BB0-0x00000001878F6D4C
		}
	
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 56733
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass8_0() {} // 0x00000001878F8E20-0x00000001878F8F80
	
			// Methods
			internal Vector3 _DOShakePosition_b__0() => default; // 0x00000001878F8F80-0x00000001878F9130
			internal void _DOShakePosition_b__1(Vector3 x) {} // 0x00000001878FC3DC-0x00000001878FC53C
		}
	
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 56734
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass9_0() {} // 0x00000001878FC53C-0x00000001878FC6EC
	
			// Methods
			internal Vector3 _DOShakePosition_b__0() => default; // 0x00000001878FCBE4-0x00000001878FCD9C
			internal void _DOShakePosition_b__1(Vector3 x) {} // 0x00000001878FCA3C-0x00000001878FCBE4
		}
	
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 56735
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass10_0() {} // 0x00000001878FA10C-0x00000001878FA278
	
			// Methods
			internal Vector3 _DOShakeRotation_b__0() => default; // 0x00000001878FC848-0x00000001878FC9A4
			internal void _DOShakeRotation_b__1(Vector3 x) {} // 0x0000000184973750-0x00000001849738F0
		}
	
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 56736
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass11_0() {} // 0x00000001878F87DC-0x00000001878F897C
	
			// Methods
			internal Vector3 _DOShakeRotation_b__0() => default; // 0x00000001878F897C-0x00000001878F8B20
			internal void _DOShakeRotation_b__1(Vector3 x) {} // 0x00000001878F8B20-0x00000001878F8CC4
		}
	
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 56737
		{
			// Fields
			public Light target; // 0x10
	
			// Constructors
			public __c__DisplayClass12_0() {} // 0x00000001878F80B8-0x00000001878F8248
	
			// Methods
			internal UnityEngine.Color _DOColor_b__0() => default; // 0x00000001878F7BD0-0x00000001878F7D70
			internal void _DOColor_b__1(UnityEngine.Color x) {} // 0x00000001878F7D70-0x00000001878F7F14
		}
	
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 56738
		{
			// Fields
			public Light target; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0() {} // 0x00000001878F7F14-0x00000001878F80B8
	
			// Methods
			internal float _DOIntensity_b__0() => default; // 0x0000000184973910-0x0000000184973AB0
			internal void _DOIntensity_b__1(float x) {} // 0x00000001878FA3E0-0x00000001878FA56C
		}
	
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 56739
		{
			// Fields
			public Light target; // 0x10
	
			// Constructors
			public __c__DisplayClass14_0() {} // 0x00000001878F8600-0x00000001878F8790
	
			// Methods
			internal float _DOShadowStrength_b__0() => default; // 0x0000000184973B60-0x0000000184973D00
			internal void _DOShadowStrength_b__1(float x) {} // 0x00000001878FABA4-0x00000001878FAD14
		}
	
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 56740
		{
			// Fields
			public Color2 startValue; // 0x10
			public LineRenderer target; // 0x30
	
			// Constructors
			public __c__DisplayClass15_0() {} // 0x00000001878FAA34-0x00000001878FABA4
	
			// Methods
			internal Color2 _DOColor_b__0() => default; // 0x00000001878FA56C-0x00000001878FA704
			internal void _DOColor_b__1(Color2 x) {} // 0x00000001878FA704-0x00000001878FA89C
		}
	
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 56741
		{
			// Fields
			public Material target; // 0x10
	
			// Constructors
			public __c__DisplayClass16_0() {} // 0x00000001878FA89C-0x00000001878FAA34
	
			// Methods
			internal UnityEngine.Color _DOColor_b__0() => default; // 0x00000001878F8790-0x00000001878F87DC
			internal void _DOColor_b__1(UnityEngine.Color x) {} // 0x00000001878F6370-0x00000001878F63BC
		}
	
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 56742
		{
			// Fields
			public Material target; // 0x10
			public string property; // 0x18
	
			// Constructors
			public __c__DisplayClass17_0() {} // 0x00000001878FCD9C-0x00000001878FCFD8
	
			// Methods
			internal UnityEngine.Color _DOColor_b__0() => default; // 0x00000001878F99FC-0x00000001878F9BEC
			internal void _DOColor_b__1(UnityEngine.Color x) {} // 0x00000001878F9DC8-0x00000001878F9FA4
		}
	
		private sealed class __c__DisplayClass18_0 // TypeDefIndex: 56743
		{
			// Fields
			public Material target; // 0x10
			public int propertyID; // 0x18
	
			// Constructors
			public __c__DisplayClass18_0() {} // 0x00000001878F9BEC-0x00000001878F9DC8
	
			// Methods
			internal UnityEngine.Color _DOColor_b__0() => default; // 0x00000001878FB294-0x00000001878FB4A8
			internal void _DOColor_b__1(UnityEngine.Color x) {} // 0x00000001878FAE70-0x00000001878FB094
		}
	
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 56744
		{
			// Fields
			public Material target; // 0x10
	
			// Constructors
			public __c__DisplayClass19_0() {} // 0x00000001878FB8D0-0x00000001878FBAD0
	
			// Methods
			internal UnityEngine.Color _DOFade_b__0() => default; // 0x00000001878FBAD0-0x00000001878FBCE4
			internal void _DOFade_b__1(UnityEngine.Color x) {} // 0x00000001878FC0F8-0x00000001878FC344
		}
	
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 56745
		{
			// Fields
			public Material target; // 0x10
			public string property; // 0x18
	
			// Constructors
			public __c__DisplayClass20_0() {} // 0x00000001878FBEE4-0x00000001878FC0F8
	
			// Methods
			internal UnityEngine.Color _DOFade_b__0() => default; // 0x00000001878F7114-0x00000001878F7644
			internal void _DOFade_b__1(UnityEngine.Color x) {} // 0x00000001878F76A0-0x00000001878F7BD0
		}
	
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 56746
		{
			// Fields
			public Material target; // 0x10
			public int propertyID; // 0x18
	
			// Constructors
			public __c__DisplayClass21_0() {} // 0x00000001878F9420-0x00000001878F9634
	
			// Methods
			internal UnityEngine.Color _DOFade_b__0() => default; // 0x00000001878F8248-0x00000001878F8464
			internal void _DOFade_b__1(UnityEngine.Color x) {} // 0x00000001878F928C-0x00000001878F9420
		}
	
		private sealed class __c__DisplayClass22_0 // TypeDefIndex: 56747
		{
			// Fields
			public Material target; // 0x10
			public string property; // 0x18
	
			// Constructors
			public __c__DisplayClass22_0() {} // 0x00000001878F8464-0x00000001878F8600
	
			// Methods
			internal float _DOFloat_b__0() => default; // 0x00000001878FC6EC-0x00000001878FC848
			internal void _DOFloat_b__1(float x) {} // 0x00000001878F4960-0x00000001878F4B2C
		}
	
		private sealed class __c__DisplayClass23_0 // TypeDefIndex: 56748
		{
			// Fields
			public Material target; // 0x10
			public int propertyID; // 0x18
	
			// Constructors
			public __c__DisplayClass23_0() {} // 0x00000001878F4D4C-0x00000001878F4F18
	
			// Methods
			internal float _DOFloat_b__0() => default; // 0x00000001878F4B2C-0x00000001878F4D4C
			internal void _DOFloat_b__1(float x) {} // 0x00000001878F4750-0x00000001878F4960
		}
	
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 56749
		{
			// Fields
			public Material target; // 0x10
	
			// Constructors
			public __c__DisplayClass24_0() {} // 0x00000001878F5288-0x00000001878F5444
	
			// Methods
			internal Vector2 _DOOffset_b__0() => default; // 0x00000001878F4F18-0x00000001878F50D4
			internal void _DOOffset_b__1(Vector2 x) {} // 0x00000001878F5650-0x00000001878F5804
		}
	
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 56750
		{
			// Fields
			public Material target; // 0x10
			public string property; // 0x18
	
			// Constructors
			public __c__DisplayClass25_0() {} // 0x00000001878F50D4-0x00000001878F5288
	
			// Methods
			internal Vector2 _DOOffset_b__0() => default; // 0x00000001878F5444-0x00000001878F5650
			internal void _DOOffset_b__1(Vector2 x) {} // 0x00000001878F5804-0x00000001878F59A4
		}
	
		private sealed class __c__DisplayClass26_0 // TypeDefIndex: 56751
		{
			// Fields
			public Material target; // 0x10
	
			// Constructors
			public __c__DisplayClass26_0() {} // 0x00000001878F6314-0x00000001878F6370
	
			// Methods
			internal Vector2 _DOTiling_b__0() => default; // 0x00000001878F62B8-0x00000001878F6314
			internal void _DOTiling_b__1(Vector2 x) {} // 0x00000001844AB2E0-0x00000001844AB340
		}
	
		private sealed class __c__DisplayClass27_0 // TypeDefIndex: 56752
		{
			// Fields
			public Material target; // 0x10
			public string property; // 0x18
	
			// Constructors
			public __c__DisplayClass27_0() {} // 0x00000001878F7644-0x00000001878F76A0
	
			// Methods
			internal Vector2 _DOTiling_b__0() => default; // 0x00000001878F6B18-0x00000001878F6B64
			internal void _DOTiling_b__1(Vector2 x) {} // 0x00000001878F6B64-0x00000001878F6BB0
		}
	
		private sealed class __c__DisplayClass28_0 // TypeDefIndex: 56753
		{
			// Fields
			public Material target; // 0x10
			public string property; // 0x18
	
			// Constructors
			public __c__DisplayClass28_0() {} // 0x00000001878F6F58-0x00000001878F6FB8
	
			// Methods
			internal Vector4 _DOVector_b__0() => default; // 0x00000001878F6EF8-0x00000001878F6F58
			internal void _DOVector_b__1(Vector4 x) {} // 0x00000001878F9634-0x00000001878F9680
		}
	
		private sealed class __c__DisplayClass29_0 // TypeDefIndex: 56754
		{
			// Fields
			public Material target; // 0x10
			public int propertyID; // 0x18
	
			// Constructors
			public __c__DisplayClass29_0() {} // 0x00000001878F9680-0x00000001878F96CC
	
			// Methods
			internal Vector4 _DOVector_b__0() => default; // 0x00000001878F99B0-0x00000001878F99FC
			internal void _DOVector_b__1(Vector4 x) {} // 0x00000001878F9964-0x00000001878F99B0
		}
	
		private sealed class __c__DisplayClass30_0 // TypeDefIndex: 56755
		{
			// Fields
			public TrailRenderer target; // 0x10
	
			// Constructors
			public __c__DisplayClass30_0() {} // 0x00000001878F9834-0x00000001878F9880
	
			// Methods
			internal Vector2 _DOResize_b__0() => default; // 0x00000001878F9880-0x00000001878F98CC
			internal void _DOResize_b__1(Vector2 x) {} // 0x00000001878F9918-0x00000001878F9964
		}
	
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 56756
		{
			// Fields
			public TrailRenderer target; // 0x10
	
			// Constructors
			public __c__DisplayClass31_0() {} // 0x00000001878F98CC-0x00000001878F9918
	
			// Methods
			internal float _DOTime_b__0() => default; // 0x00000001878FA278-0x00000001878FA2D0
			internal void _DOTime_b__1(float x) {} // 0x00000001878FA2D0-0x00000001878FA328
		}
	
		private sealed class __c__DisplayClass32_0 // TypeDefIndex: 56757
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass32_0() {} // 0x00000001878FA384-0x00000001878FA3E0
	
			// Methods
			internal Vector3 _DOMove_b__0() => default; // 0x00000001878FA328-0x00000001878FA384
			internal void _DOMove_b__1(Vector3 x) {} // 0x00000001878FC344-0x00000001878FC390
		}
	
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 56758
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass33_0() {} // 0x00000001878FC390-0x00000001878FC3DC
	
			// Methods
			internal Vector3 _DOMoveX_b__0() => default; // 0x00000001878FC9A4-0x00000001878FC9F0
			internal void _DOMoveX_b__1(Vector3 x) {} // 0x00000001878FC9F0-0x00000001878FCA3C
		}
	
		private sealed class __c__DisplayClass34_0 // TypeDefIndex: 56759
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass34_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOMoveY_b__0() => default; // 0x00000001878FF658-0x00000001878FF678
			internal void _DOMoveY_b__1(Vector3 x) {} // 0x00000001878FF678-0x00000001878FF698
		}
	
		private sealed class __c__DisplayClass35_0 // TypeDefIndex: 56760
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass35_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOMoveZ_b__0() => default; // 0x00000001878FF9F0-0x00000001878FFA24
			internal void _DOMoveZ_b__1(Vector3 x) {} // 0x00000001878FFA24-0x00000001878FFA54
		}
	
		private sealed class __c__DisplayClass36_0 // TypeDefIndex: 56761
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass36_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOLocalMove_b__0() => default; // 0x00000001878FFD38-0x00000001878FFD58
			internal void _DOLocalMove_b__1(Vector3 x) {} // 0x00000001878FFD58-0x00000001878FFD78
		}
	
		private sealed class __c__DisplayClass37_0 // TypeDefIndex: 56762
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass37_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOLocalMoveX_b__0() => default; // 0x00000001878FFFD4-0x00000001878FFFF4
			internal void _DOLocalMoveX_b__1(Vector3 x) {} // 0x00000001878FFFF4-0x0000000187900014
		}
	
		private sealed class __c__DisplayClass38_0 // TypeDefIndex: 56763
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass38_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOLocalMoveY_b__0() => default; // 0x000000018790011C-0x000000018790013C
			internal void _DOLocalMoveY_b__1(Vector3 x) {} // 0x000000018790013C-0x000000018790015C
		}
	
		private sealed class __c__DisplayClass39_0 // TypeDefIndex: 56764
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass39_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOLocalMoveZ_b__0() => default; // 0x00000001879001EC-0x000000018790020C
			internal void _DOLocalMoveZ_b__1(Vector3 x) {} // 0x000000018790020C-0x000000018790022C
		}
	
		private sealed class __c__DisplayClass40_0 // TypeDefIndex: 56765
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass40_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Quaternion _DORotate_b__0() => default; // 0x00000001879005D8-0x000000018790060C
			internal void _DORotate_b__1(Quaternion x) {} // 0x000000018790060C-0x000000018790063C
		}
	
		private sealed class __c__DisplayClass41_0 // TypeDefIndex: 56766
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass41_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Quaternion _DORotateQuaternion_b__0() => default; // 0x0000000187900E04-0x0000000187900E38
			internal void _DORotateQuaternion_b__1(Quaternion x) {} // 0x0000000187900E38-0x0000000187900E68
		}
	
		private sealed class __c__DisplayClass42_0 // TypeDefIndex: 56767
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass42_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Quaternion _DOLocalRotate_b__0() => default; // 0x0000000187900E68-0x0000000187900EB4
			internal void _DOLocalRotate_b__1(Quaternion x) {} // 0x0000000187900EB4-0x0000000187900F00
		}
	
		private sealed class __c__DisplayClass43_0 // TypeDefIndex: 56768
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass43_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Quaternion _DOLocalRotateQuaternion_b__0() => default; // 0x0000000187900E68-0x0000000187900EB4
			internal void _DOLocalRotateQuaternion_b__1(Quaternion x) {} // 0x0000000187900EB4-0x0000000187900F00
		}
	
		private sealed class __c__DisplayClass44_0 // TypeDefIndex: 56769
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass44_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOScale_b__0() => default; // 0x00000001878FF6C0-0x00000001878FF70C
			internal void _DOScale_b__1(Vector3 x) {} // 0x00000001878FF70C-0x00000001878FF784
		}
	
		private sealed class __c__DisplayClass45_0 // TypeDefIndex: 56770
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass45_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOScale_b__0() => default; // 0x00000001878FF6C0-0x00000001878FF70C
			internal void _DOScale_b__1(Vector3 x) {} // 0x00000001878FF70C-0x00000001878FF784
		}
	
		private sealed class __c__DisplayClass46_0 // TypeDefIndex: 56771
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass46_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOScaleX_b__0() => default; // 0x00000001878FF784-0x00000001878FF7B8
			internal void _DOScaleX_b__1(Vector3 x) {} // 0x00000001878FF7B8-0x00000001878FF7E8
		}
	
		private sealed class __c__DisplayClass47_0 // TypeDefIndex: 56772
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass47_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOScaleY_b__0() => default; // 0x00000001878FF7E8-0x00000001878FF808
			internal void _DOScaleY_b__1(Vector3 x) {} // 0x00000001878FF808-0x00000001878FF828
		}
	
		private sealed class __c__DisplayClass48_0 // TypeDefIndex: 56773
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass48_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOScaleZ_b__0() => default; // 0x00000001878FF828-0x00000001878FF848
			internal void _DOScaleZ_b__1(Vector3 x) {} // 0x00000001878FF848-0x00000001878FF868
		}
	
		private sealed class __c__DisplayClass51_0 // TypeDefIndex: 56774
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass51_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Quaternion _LookAt_b__0() => default; // 0x0000000181DD1520-0x0000000181DD1540
			internal void _LookAt_b__1(Quaternion x) {} // 0x00000001878FF868-0x00000001878FF8A4
		}
	
		private sealed class __c__DisplayClass52_0 // TypeDefIndex: 56775
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass52_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOPunchPosition_b__0() => default; // 0x00000001878FF8A4-0x00000001878FF8D8
			internal void _DOPunchPosition_b__1(Vector3 x) {} // 0x00000001878FF8D8-0x00000001878FF908
		}
	
		private sealed class __c__DisplayClass53_0 // TypeDefIndex: 56776
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass53_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOPunchScale_b__0() => default; // 0x00000001878FF908-0x00000001878FF944
			internal void _DOPunchScale_b__1(Vector3 x) {} // 0x00000001878FF944-0x00000001878FF97C
		}
	
		private sealed class __c__DisplayClass54_0 // TypeDefIndex: 56777
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass54_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOPunchRotation_b__0() => default; // 0x00000001878FF97C-0x00000001878FF9B8
			internal void _DOPunchRotation_b__1(Vector3 x) {} // 0x00000001878FF9B8-0x00000001878FF9F0
		}
	
		private sealed class __c__DisplayClass55_0 // TypeDefIndex: 56778
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass55_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOShakePosition_b__0() => default; // 0x00000001878FF8A4-0x00000001878FF8D8
			internal void _DOShakePosition_b__1(Vector3 x) {} // 0x00000001878FF8D8-0x00000001878FF908
		}
	
		private sealed class __c__DisplayClass56_0 // TypeDefIndex: 56779
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass56_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOShakePosition_b__0() => default; // 0x00000001878FF908-0x00000001878FF944
			internal void _DOShakePosition_b__1(Vector3 x) {} // 0x00000001878FF944-0x00000001878FF97C
		}
	
		private sealed class __c__DisplayClass57_0 // TypeDefIndex: 56780
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass57_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOShakeRotation_b__0() => default; // 0x00000001878FF97C-0x00000001878FF9B8
			internal void _DOShakeRotation_b__1(Vector3 x) {} // 0x00000001878FF9B8-0x00000001878FF9F0
		}
	
		private sealed class __c__DisplayClass58_0 // TypeDefIndex: 56781
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass58_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOShakeRotation_b__0() => default; // 0x00000001878FFA7C-0x00000001878FFAA4
			internal void _DOShakeRotation_b__1(Vector3 x) {} // 0x00000001878FFAA4-0x00000001878FFAD0
		}
	
		private sealed class __c__DisplayClass59_0 // TypeDefIndex: 56782
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass59_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOShakeScale_b__0() => default; // 0x00000001878FFAD0-0x00000001878FFAF8
			internal void _DOShakeScale_b__1(Vector3 x) {} // 0x00000001878FFAF8-0x00000001878FFB20
		}
	
		private sealed class __c__DisplayClass60_0 // TypeDefIndex: 56783
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass60_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOShakeScale_b__0() => default; // 0x00000001878FFB20-0x00000001878FFB40
			internal void _DOShakeScale_b__1(Vector3 x) {} // 0x00000001878FFB40-0x00000001878FFB60
		}
	
		private sealed class __c__DisplayClass61_0 // TypeDefIndex: 56784
		{
			// Fields
			public Transform target; // 0x10
			public float startPosY; // 0x18
			public bool offsetYSet; // 0x1C
			public float offsetY; // 0x20
			public DG.Tweening.Sequence s; // 0x28
			public Vector3 endValue; // 0x30
			public DG.Tweening.Tween yTween; // 0x40
	
			// Constructors
			public __c__DisplayClass61_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOJump_b__0() => default; // 0x00000001878FFB60-0x00000001878FFB88
			internal void _DOJump_b__1(Vector3 x) {} // 0x00000001878FFB88-0x00000001878FFBB8
			internal void _DOJump_b__2() {} // 0x0000000185492010-0x0000000185492020
			internal Vector3 _DOJump_b__3() => default; // 0x00000001878FFBB8-0x00000001878FFBD8
			internal void _DOJump_b__4(Vector3 x) {} // 0x00000001878FFBD8-0x00000001878FFBF8
			internal Vector3 _DOJump_b__5() => default; // 0x0000000185492010-0x0000000185492020
			internal void _DOJump_b__6(Vector3 x) {} // 0x00000001878FFBF8-0x00000001878FFC20
			internal void _DOJump_b__7() {} // 0x00000001878FFC20-0x00000001878FFC50
		}
	
		private sealed class __c__DisplayClass62_0 // TypeDefIndex: 56785
		{
			// Fields
			public Transform target; // 0x10
			public float startPosY; // 0x18
			public bool offsetYSet; // 0x1C
			public float offsetY; // 0x20
			public DG.Tweening.Sequence s; // 0x28
			public Vector3 endValue; // 0x30
			public DG.Tweening.Tween yTween; // 0x40
	
			// Constructors
			public __c__DisplayClass62_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOLocalJump_b__0() => default; // 0x00000001878FFC50-0x00000001878FFC8C
			internal void _DOLocalJump_b__1(Vector3 x) {} // 0x00000001878FFC8C-0x00000001878FFCC4
			internal void _DOLocalJump_b__2() {} // 0x0000000185492010-0x0000000185492020
			internal Vector3 _DOLocalJump_b__3() => default; // 0x00000001878FFCC4-0x00000001878FFD00
			internal void _DOLocalJump_b__4(Vector3 x) {} // 0x00000001878FFD00-0x00000001878FFD38
			internal Vector3 _DOLocalJump_b__5() => default; // 0x0000000185492010-0x0000000185492020
			internal void _DOLocalJump_b__6(Vector3 x) {} // 0x00000001878FFE20-0x00000001878FFE6C
			internal void _DOLocalJump_b__7() {} // 0x00000001878FFE6C-0x00000001878FFEB4
		}
	
		private sealed class __c__DisplayClass63_0 // TypeDefIndex: 56786
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass63_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOPath_b__0() => default; // 0x00000001878FFEB4-0x00000001878FFED4
			internal void _DOPath_b__1(Vector3 x) {} // 0x00000001878FFED4-0x00000001878FFEF4
		}
	
		private sealed class __c__DisplayClass64_0 // TypeDefIndex: 56787
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass64_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOLocalPath_b__0() => default; // 0x0000000185EF8D90-0x0000000185EF8DD0
			internal void _DOLocalPath_b__1(Vector3 x) {} // 0x0000000185EE1B70-0x0000000185EE1BD0
		}
	
		private sealed class __c__DisplayClass65_0 // TypeDefIndex: 56788
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass65_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOPath_b__0() => default; // 0x0000000185EF8D90-0x0000000185EF8DD0
			internal void _DOPath_b__1(Vector3 x) {} // 0x00000001878FFEF4-0x00000001878FFF2C
		}
	
		private sealed class __c__DisplayClass66_0 // TypeDefIndex: 56789
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass66_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOLocalPath_b__0() => default; // 0x0000000185EF8D90-0x0000000185EF8DD0
			internal void _DOLocalPath_b__1(Vector3 x) {} // 0x00000001878FFEF4-0x00000001878FFF2C
		}
	
		private sealed class __c__DisplayClass67_0 // TypeDefIndex: 56790
		{
			// Fields
			public DG.Tweening.Tween target; // 0x10
	
			// Constructors
			public __c__DisplayClass67_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal float _DOTimeScale_b__0() => default; // 0x0000000185EF8D90-0x0000000185EF8DD0
			internal void _DOTimeScale_b__1(float x) {} // 0x00000001878FFEF4-0x00000001878FFF2C
		}
	
		private sealed class __c__DisplayClass68_0 // TypeDefIndex: 56791
		{
			// Fields
			public UnityEngine.Color to; // 0x10
			public Light target; // 0x20
	
			// Constructors
			public __c__DisplayClass68_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal UnityEngine.Color _DOBlendableColor_b__0() => default; // 0x00000001878FFF2C-0x00000001878FFF68
			internal void _DOBlendableColor_b__1(UnityEngine.Color x) {} // 0x00000001878FFF68-0x00000001878FFFA0
		}
	
		private sealed class __c__DisplayClass69_0 // TypeDefIndex: 56792
		{
			// Fields
			public UnityEngine.Color to; // 0x10
			public Material target; // 0x20
	
			// Constructors
			public __c__DisplayClass69_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal UnityEngine.Color _DOBlendableColor_b__0() => default; // 0x00000001878FFF2C-0x00000001878FFF68
			internal void _DOBlendableColor_b__1(UnityEngine.Color x) {} // 0x00000001878FFF68-0x00000001878FFFA0
		}
	
		private sealed class __c__DisplayClass70_0 // TypeDefIndex: 56793
		{
			// Fields
			public UnityEngine.Color to; // 0x10
			public Material target; // 0x20
			public string property; // 0x28
	
			// Constructors
			public __c__DisplayClass70_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal UnityEngine.Color _DOBlendableColor_b__0() => default; // 0x00000001878FFF2C-0x00000001878FFF68
			internal void _DOBlendableColor_b__1(UnityEngine.Color x) {} // 0x00000001878FFF68-0x00000001878FFFA0
		}
	
		private sealed class __c__DisplayClass71_0 // TypeDefIndex: 56794
		{
			// Fields
			public UnityEngine.Color to; // 0x10
			public Material target; // 0x20
			public int propertyID; // 0x28
	
			// Constructors
			public __c__DisplayClass71_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal UnityEngine.Color _DOBlendableColor_b__0() => default; // 0x00000001878FFF2C-0x00000001878FFF68
			internal void _DOBlendableColor_b__1(UnityEngine.Color x) {} // 0x00000001878FFF68-0x00000001878FFFA0
		}
	
		private sealed class __c__DisplayClass72_0 // TypeDefIndex: 56795
		{
			// Fields
			public Vector3 to; // 0x10
			public Transform target; // 0x20
	
			// Constructors
			public __c__DisplayClass72_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOBlendableMoveBy_b__0() => default; // 0x000000018584B690-0x000000018584B6D0
			internal void _DOBlendableMoveBy_b__1(Vector3 x) {} // 0x0000000185F08C30-0x0000000185F08C90
		}
	
		private sealed class __c__DisplayClass73_0 // TypeDefIndex: 56796
		{
			// Fields
			public Vector3 to; // 0x10
			public Transform target; // 0x20
	
			// Constructors
			public __c__DisplayClass73_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOBlendableLocalMoveBy_b__0() => default; // 0x000000018584B690-0x000000018584B6D0
			internal void _DOBlendableLocalMoveBy_b__1(Vector3 x) {} // 0x0000000187900014-0x0000000187900044
		}
	
		private sealed class __c__DisplayClass74_0 // TypeDefIndex: 56797
		{
			// Fields
			public Quaternion to; // 0x10
			public Transform target; // 0x20
	
			// Constructors
			public __c__DisplayClass74_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Quaternion _DOBlendableRotateBy_b__0() => default; // 0x0000000187900044-0x0000000187900078
			internal void _DOBlendableRotateBy_b__1(Quaternion x) {} // 0x0000000187900078-0x00000001879000A8
		}
	
		private sealed class __c__DisplayClass75_0 // TypeDefIndex: 56798
		{
			// Fields
			public Quaternion to; // 0x10
			public Transform target; // 0x20
	
			// Constructors
			public __c__DisplayClass75_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Quaternion _DOBlendableLocalRotateBy_b__0() => default; // 0x000000018584B650-0x000000018584B690
			internal void _DOBlendableLocalRotateBy_b__1(Quaternion x) {} // 0x0000000185847C30-0x0000000185847C70
		}
	
		private sealed class __c__DisplayClass76_0 // TypeDefIndex: 56799
		{
			// Fields
			public Vector3 to; // 0x10
			public Transform target; // 0x20
	
			// Constructors
			public __c__DisplayClass76_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOBlendablePunchRotation_b__0() => default; // 0x00000001879000A8-0x00000001879000E4
			internal void _DOBlendablePunchRotation_b__1(Vector3 v) {} // 0x00000001879000E4-0x000000018790011C
		}
	
		private sealed class __c__DisplayClass77_0 // TypeDefIndex: 56800
		{
			// Fields
			public Vector3 to; // 0x10
			public Transform target; // 0x20
	
			// Constructors
			public __c__DisplayClass77_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal Vector3 _DOBlendableScaleBy_b__0() => default; // 0x00000001879000A8-0x00000001879000E4
			internal void _DOBlendableScaleBy_b__1(Vector3 x) {} // 0x00000001879000E4-0x000000018790011C
		}
	
		// Methods
		public static TweenerCore<float, float, FloatOptions> DOAspect(Camera target, float endValue, float duration) => default; // 0x0000000185492010-0x0000000185492020
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(Camera target, UnityEngine.Color endValue, float duration) => default; // 0x00000001879000A8-0x00000001879000E4
		public static TweenerCore<float, float, FloatOptions> DOFarClipPlane(Camera target, float endValue, float duration) => default; // 0x00000001879000E4-0x000000018790011C
		public static TweenerCore<float, float, FloatOptions> DOFieldOfView(Camera target, float endValue, float duration) => default; // 0x0000000185492010-0x0000000185492020
		public static TweenerCore<float, float, FloatOptions> DONearClipPlane(Camera target, float endValue, float duration) => default; // 0x00000001879000A8-0x00000001879000E4
		public static TweenerCore<float, float, FloatOptions> DOOrthoSize(Camera target, float endValue, float duration) => default; // 0x00000001879000E4-0x000000018790011C
		public static TweenerCore<Rect, Rect, RectOptions> DOPixelRect(Camera target, Rect endValue, float duration) => default; // 0x0000000185492010-0x0000000185492020
		public static TweenerCore<Rect, Rect, RectOptions> DORect(Camera target, Rect endValue, float duration) => default; // 0x00000001879000A8-0x00000001879000E4
		public static Tweener DOShakePosition(Camera target, float duration, float strength = 3f /* Metadata: 0x0207CE8D */, int vibrato = 10 /* Metadata: 0x0207CE91 */, float randomness = 90f /* Metadata: 0x0207CE92 */, bool fadeOut = true /* Metadata: 0x0207CE96 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0207CE97 */) => default; // 0x00000001879000E4-0x000000018790011C
		public static Tweener DOShakePosition(Camera target, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x0207CE98 */, float randomness = 90f /* Metadata: 0x0207CE99 */, bool fadeOut = true /* Metadata: 0x0207CE9D */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0207CE9E */) => default; // 0x0000000185492010-0x0000000185492020
		public static Tweener DOShakeRotation(Camera target, float duration, float strength = 90f /* Metadata: 0x0207CE9F */, int vibrato = 10 /* Metadata: 0x0207CEA3 */, float randomness = 90f /* Metadata: 0x0207CEA4 */, bool fadeOut = true /* Metadata: 0x0207CEA8 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0207CEA9 */) => default; // 0x000000018584B690-0x000000018584B6D0
		public static Tweener DOShakeRotation(Camera target, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x0207CEAA */, float randomness = 90f /* Metadata: 0x0207CEAB */, bool fadeOut = true /* Metadata: 0x0207CEAF */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0207CEB0 */) => default; // 0x0000000187900014-0x0000000187900044
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(Light target, UnityEngine.Color endValue, float duration) => default; // 0x0000000185492010-0x0000000185492020
		public static TweenerCore<float, float, FloatOptions> DOIntensity(Light target, float endValue, float duration) => default; // 0x00000001878FFF2C-0x00000001878FFF68
		public static TweenerCore<float, float, FloatOptions> DOShadowStrength(Light target, float endValue, float duration) => default; // 0x00000001878FFF68-0x00000001878FFFA0
		public static Tweener DOColor(LineRenderer target, Color2 startValue, Color2 endValue, float duration) => default; // 0x0000000185492010-0x0000000185492020
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(Material target, UnityEngine.Color endValue, float duration) => default; // 0x00000001879000A8-0x00000001879000E4
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(Material target, UnityEngine.Color endValue, string property, float duration) => default; // 0x00000001879000E4-0x000000018790011C
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(Material target, UnityEngine.Color endValue, int propertyID, float duration) => default; // 0x0000000185492010-0x0000000185492020
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOFade(Material target, float endValue, float duration) => default; // 0x000000018790015C-0x0000000187900198
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOFade(Material target, float endValue, string property, float duration) => default; // 0x0000000187900198-0x00000001879001EC
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOFade(Material target, float endValue, int propertyID, float duration) => default; // 0x0000000185492010-0x0000000185492020
		public static TweenerCore<float, float, FloatOptions> DOFloat(Material target, float endValue, string property, float duration) => default; // 0x00000001878FFF2C-0x00000001878FFF68
		public static TweenerCore<float, float, FloatOptions> DOFloat(Material target, float endValue, int propertyID, float duration) => default; // 0x00000001878FFF68-0x00000001878FFFA0
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(Material target, Vector2 endValue, float duration) => default; // 0x0000000185492010-0x0000000185492020
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(Material target, Vector2 endValue, string property, float duration) => default; // 0x00000001878FFF2C-0x00000001878FFF68
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(Material target, Vector2 endValue, float duration) => default; // 0x00000001878FFF68-0x00000001878FFFA0
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(Material target, Vector2 endValue, string property, float duration) => default; // 0x0000000185492010-0x0000000185492020
		public static TweenerCore<Vector4, Vector4, VectorOptions> DOVector(Material target, Vector4 endValue, string property, float duration) => default; // 0x000000018790015C-0x0000000187900198
		public static TweenerCore<Vector4, Vector4, VectorOptions> DOVector(Material target, Vector4 endValue, int propertyID, float duration) => default; // 0x0000000187900198-0x00000001879001EC
		public static Tweener DOResize(TrailRenderer target, float toStartWidth, float toEndWidth, float duration) => default; // 0x0000000185492010-0x0000000185492020
		public static TweenerCore<float, float, FloatOptions> DOTime(TrailRenderer target, float endValue, float duration) => default; // 0x000000018790015C-0x0000000187900198
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(Transform target, Vector3 endValue, float duration, bool snapping = false /* Metadata: 0x0207CEB1 */) => default; // 0x0000000187900198-0x00000001879001EC
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x0207CEB2 */) => default; // 0x0000000185492010-0x0000000185492020
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x0207CEB3 */) => default; // 0x00000001879000A8-0x00000001879000E4
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x0207CEB4 */) => default; // 0x00000001879000E4-0x000000018790011C
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMove(Transform target, Vector3 endValue, float duration, bool snapping = false /* Metadata: 0x0207CEB5 */) => default; // 0x0000000185492010-0x0000000185492020
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveX(Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x0207CEB6 */) => default; // 0x00000001879000A8-0x00000001879000E4
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveY(Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x0207CEB7 */) => default; // 0x00000001879000E4-0x000000018790011C
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveZ(Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x0207CEB8 */) => default; // 0x0000000185492010-0x0000000185492020
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(Transform target, Vector3 endValue, float duration, DG.Tweening.RotateMode mode = DG.Tweening.RotateMode.Fast /* Metadata: 0x0207CEB9 */) => default; // 0x0000000185EF8D90-0x0000000185EF8DD0
		public static TweenerCore<Quaternion, Quaternion, NoOptions> DORotateQuaternion(Transform target, Quaternion endValue, float duration) => default; // 0x00000001878FFEF4-0x00000001878FFF2C
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLocalRotate(Transform target, Vector3 endValue, float duration, DG.Tweening.RotateMode mode = DG.Tweening.RotateMode.Fast /* Metadata: 0x0207CEBA */) => default; // 0x000000018790022C-0x0000000187900260
		public static TweenerCore<Quaternion, Quaternion, NoOptions> DOLocalRotateQuaternion(Transform target, Quaternion endValue, float duration) => default; // 0x0000000185EF8D90-0x0000000185EF8DD0
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(Transform target, Vector3 endValue, float duration) => default; // 0x00000001878FFEF4-0x00000001878FFF2C
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(Transform target, float endValue, float duration) => default; // 0x0000000185EF8D90-0x0000000185EF8DD0
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleX(Transform target, float endValue, float duration) => default; // 0x00000001878FFEF4-0x00000001878FFF2C
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleY(Transform target, float endValue, float duration) => default; // 0x0000000187900260-0x000000018790033C
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleZ(Transform target, float endValue, float duration) => default; // 0x0000000185492010-0x0000000185492020
		public static Tweener DOLookAt(Transform target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None /* Metadata: 0x0207CEBB */, Vector3? up = default) => default; // 0x00000001878FFF2C-0x00000001878FFF68
		public static Tweener DODynamicLookAt(Transform target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None /* Metadata: 0x0207CEBC */, Vector3? up = default) => default; // 0x00000001878FFF68-0x00000001878FFFA0
		private static Tweener LookAt(Transform target, Vector3 towards, float duration, AxisConstraint axisConstraint, Vector3? up, bool dynamic) => default; // 0x000000018790033C-0x0000000187900370
		public static Tweener DOPunchPosition(Transform target, Vector3 punch, float duration, int vibrato = 10 /* Metadata: 0x0207CEBD */, float elasticity = 1f /* Metadata: 0x0207CEBE */, bool snapping = false /* Metadata: 0x0207CEC2 */) => default; // 0x00000001878FFF2C-0x00000001878FFF68
		public static Tweener DOPunchScale(Transform target, Vector3 punch, float duration, int vibrato = 10 /* Metadata: 0x0207CEC3 */, float elasticity = 1f /* Metadata: 0x0207CEC4 */) => default; // 0x00000001878FFF68-0x00000001878FFFA0
		public static Tweener DOPunchRotation(Transform target, Vector3 punch, float duration, int vibrato = 10 /* Metadata: 0x0207CEC8 */, float elasticity = 1f /* Metadata: 0x0207CEC9 */) => default; // 0x00000001878FFF2C-0x00000001878FFF68
		public static Tweener DOShakePosition(Transform target, float duration, float strength = 1f /* Metadata: 0x0207CECD */, int vibrato = 10 /* Metadata: 0x0207CED1 */, float randomness = 90f /* Metadata: 0x0207CED2 */, bool snapping = false /* Metadata: 0x0207CED6 */, bool fadeOut = true /* Metadata: 0x0207CED7 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0207CED8 */) => default; // 0x00000001878FFF68-0x00000001878FFFA0
		public static Tweener DOShakePosition(Transform target, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x0207CED9 */, float randomness = 90f /* Metadata: 0x0207CEDA */, bool snapping = false /* Metadata: 0x0207CEDE */, bool fadeOut = true /* Metadata: 0x0207CEDF */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0207CEE0 */) => default; // 0x0000000187900370-0x000000018790044C
		public static Tweener DOShakeRotation(Transform target, float duration, float strength = 90f /* Metadata: 0x0207CEE1 */, int vibrato = 10 /* Metadata: 0x0207CEE5 */, float randomness = 90f /* Metadata: 0x0207CEE6 */, bool fadeOut = true /* Metadata: 0x0207CEEA */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0207CEEB */) => default; // 0x0000000185492010-0x0000000185492020
		public static Tweener DOShakeRotation(Transform target, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x0207CEEC */, float randomness = 90f /* Metadata: 0x0207CEED */, bool fadeOut = true /* Metadata: 0x0207CEF1 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0207CEF2 */) => default; // 0x0000000185EF8D90-0x0000000185EF8DD0
		public static Tweener DOShakeScale(Transform target, float duration, float strength = 1f /* Metadata: 0x0207CEF3 */, int vibrato = 10 /* Metadata: 0x0207CEF7 */, float randomness = 90f /* Metadata: 0x0207CEF8 */, bool fadeOut = true /* Metadata: 0x0207CEFC */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0207CEFD */) => default; // 0x00000001878FFEF4-0x00000001878FFF2C
		public static Tweener DOShakeScale(Transform target, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x0207CEFE */, float randomness = 90f /* Metadata: 0x0207CEFF */, bool fadeOut = true /* Metadata: 0x0207CF03 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0207CF04 */) => default; // 0x0000000185492010-0x0000000185492020
		public static DG.Tweening.Sequence DOJump(Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false /* Metadata: 0x0207CF05 */) => default; // 0x00000001878FFF2C-0x00000001878FFF68
		public static DG.Tweening.Sequence DOLocalJump(Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false /* Metadata: 0x0207CF06 */) => default; // 0x00000001878FFF68-0x00000001878FFFA0
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(Transform target, Vector3[] path, float duration, PathType pathType = PathType.Linear /* Metadata: 0x0207CF07 */, PathMode pathMode = PathMode.Full3D /* Metadata: 0x0207CF08 */, int resolution = 10 /* Metadata: 0x0207CF09 */, UnityEngine.Color? gizmoColor = default) => default; // 0x0000000185492010-0x0000000185492020
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(Transform target, Vector3[] path, float duration, PathType pathType = PathType.Linear /* Metadata: 0x0207CF0A */, PathMode pathMode = PathMode.Full3D /* Metadata: 0x0207CF0B */, int resolution = 10 /* Metadata: 0x0207CF0C */, UnityEngine.Color? gizmoColor = default) => default; // 0x0000000185EF8D90-0x0000000185EF8DD0
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(Transform target, Path path, float duration, PathMode pathMode = PathMode.Full3D /* Metadata: 0x0207CF0D */) => default; // 0x00000001878FFEF4-0x00000001878FFF2C
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(Transform target, Path path, float duration, PathMode pathMode = PathMode.Full3D /* Metadata: 0x0207CF0E */) => default; // 0x0000000185492010-0x0000000185492020
		public static TweenerCore<float, float, FloatOptions> DOTimeScale(DG.Tweening.Tween target, float endValue, float duration) => default; // 0x00000001878FFF2C-0x00000001878FFF68
		public static Tweener DOBlendableColor(Light target, UnityEngine.Color endValue, float duration) => default; // 0x00000001878FFF68-0x00000001878FFFA0
		public static Tweener DOBlendableColor(Material target, UnityEngine.Color endValue, float duration) => default; // 0x0000000185492010-0x0000000185492020
		public static Tweener DOBlendableColor(Material target, UnityEngine.Color endValue, string property, float duration) => default; // 0x000000018790044C-0x000000018790046C
		public static Tweener DOBlendableColor(Material target, UnityEngine.Color endValue, int propertyID, float duration) => default; // 0x0000000186471394-0x00000001864713B4
		public static Tweener DOBlendableMoveBy(Transform target, Vector3 byValue, float duration, bool snapping = false /* Metadata: 0x0207CF0F */) => default; // 0x0000000185492010-0x0000000185492020
		public static Tweener DOBlendableLocalMoveBy(Transform target, Vector3 byValue, float duration, bool snapping = false /* Metadata: 0x0207CF10 */) => default; // 0x00000001834A7540-0x00000001834A7550
		public static Tweener DOBlendableRotateBy(Transform target, Vector3 byValue, float duration, DG.Tweening.RotateMode mode = DG.Tweening.RotateMode.Fast /* Metadata: 0x0207CF11 */) => default; // 0x0000000187900490-0x0000000187900534
		public static Tweener DOBlendableLocalRotateBy(Transform target, Vector3 byValue, float duration, DG.Tweening.RotateMode mode = DG.Tweening.RotateMode.Fast /* Metadata: 0x0207CF12 */) => default; // 0x0000000185492010-0x0000000185492020
		public static Tweener DOBlendablePunchRotation(Transform target, Vector3 punch, float duration, int vibrato = 10 /* Metadata: 0x0207CF13 */, float elasticity = 1f /* Metadata: 0x0207CF14 */) => default; // 0x00000001834A7540-0x00000001834A7550
		public static Tweener DOBlendableScaleBy(Transform target, Vector3 byValue, float duration) => default; // 0x0000000187900534-0x00000001879005D8
		public static int DOComplete(Component target, bool withCallbacks = false /* Metadata: 0x0207CF18 */) => default; // 0x0000000185492010-0x0000000185492020
		public static int DOComplete(Material target, bool withCallbacks = false /* Metadata: 0x0207CF19 */) => default; // 0x00000001834A7540-0x00000001834A7550
		public static int DOKill(Component target, bool complete = false /* Metadata: 0x0207CF1A */) => default; // 0x000000018790063C-0x00000001879006F4
		public static int DOKill(Material target, bool complete = false /* Metadata: 0x0207CF1B */) => default; // 0x0000000185492010-0x0000000185492020
		public static int DOFlip(Component target) => default; // 0x00000001834A7540-0x00000001834A7550
		public static int DOFlip(Material target) => default; // 0x00000001879006F4-0x00000001879007A8
		public static int DOGoto(Component target, float to, bool andPlay = false /* Metadata: 0x0207CF1C */) => default; // 0x0000000185492010-0x0000000185492020
		public static int DOGoto(Material target, float to, bool andPlay = false /* Metadata: 0x0207CF1D */) => default; // 0x00000001834AE2B0-0x00000001834AE2D0
		public static int DOPause(Component target) => default; // 0x00000001879007A8-0x0000000187900874
		public static int DOPause(Material target) => default; // 0x0000000185492010-0x0000000185492020
		public static int DOPlay(Component target) => default; // 0x00000001834AE2B0-0x00000001834AE2D0
		public static int DOPlay(Material target) => default; // 0x0000000187900874-0x0000000187900940
		public static int DOPlayBackwards(Component target) => default; // 0x0000000185492010-0x0000000185492020
		public static int DOPlayBackwards(Material target) => default; // 0x00000001834A7540-0x00000001834A7550
		public static int DOPlayForward(Component target) => default; // 0x0000000187900940-0x0000000187900A80
		public static int DOPlayForward(Material target) => default; // 0x0000000185492010-0x0000000185492020
		public static int DORestart(Component target, bool includeDelay = true /* Metadata: 0x0207CF1E */) => default; // 0x00000001834A7540-0x00000001834A7550
		public static int DORestart(Material target, bool includeDelay = true /* Metadata: 0x0207CF1F */) => default; // 0x0000000187900A80-0x0000000187900BC0
		public static int DORewind(Component target, bool includeDelay = true /* Metadata: 0x0207CF20 */) => default; // 0x0000000185492010-0x0000000185492020
		public static int DORewind(Material target, bool includeDelay = true /* Metadata: 0x0207CF21 */) => default; // 0x00000001834AE2B0-0x00000001834AE2D0
		public static int DOSmoothRewind(Component target) => default; // 0x0000000187900BC0-0x0000000187900D38
		public static int DOSmoothRewind(Material target) => default; // 0x0000000185492010-0x0000000185492020
		public static int DOTogglePause(Component target) => default; // 0x00000001834AE2B0-0x00000001834AE2D0
		public static int DOTogglePause(Material target) => default; // 0x0000000187900D38-0x0000000187900E04
	}

	public class TweenParams // TypeDefIndex: 56802
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
		public TweenParams() {} // 0x00000001878FEAAC-0x00000001878FEABC
		static TweenParams() {} // 0x00000001878FEA3C-0x00000001878FEAAC
	
		// Methods
		public TweenParams Clear() => default; // 0x00000001878FE488-0x00000001878FE62C
		public TweenParams SetAutoKill(bool autoKillOnCompletion = true /* Metadata: 0x0207CF22 */) => default; // 0x0000000185FB6720-0x0000000185FB6730
		public TweenParams SetId(object objectId) => default; // 0x00000001878FE900-0x00000001878FE91C
		public TweenParams SetId(string stringId) => default; // 0x00000001878FE91C-0x00000001878FE938
		public TweenParams SetId(int intId) => default; // 0x0000000185FB6740-0x0000000185FB6750
		public TweenParams SetTarget(object target) => default; // 0x00000001878FE9C0-0x00000001878FE9DC
		public TweenParams SetLoops(int loops, LoopType? loopType = default) => default; // 0x00000001878FE938-0x00000001878FE9C0
		public TweenParams SetEase(Ease ease, float? overshootOrAmplitude = default, float? period = default) => default; // 0x00000001878FE7D8-0x00000001878FE8D4
		public TweenParams SetEase(AnimationCurve animCurve) => default; // 0x00000001878FE70C-0x00000001878FE7D8
		public TweenParams SetEase(EaseFunction customEase) => default; // 0x00000001878FE8D4-0x00000001878FE900
		public TweenParams SetRecyclable(bool recyclable = true /* Metadata: 0x0207CF23 */) => default; // 0x0000000185FB6750-0x0000000185FB6760
		public TweenParams SetUpdate(bool isIndependentUpdate) => default; // 0x00000001878FE9DC-0x00000001878FEA3C
		public TweenParams SetUpdate(DG.Tweening.UpdateType updateType, bool isIndependentUpdate = false /* Metadata: 0x0207CF24 */) => default; // 0x0000000185FB6780-0x0000000185FB6790
		public TweenParams OnStart(TweenCallback action) => default; // 0x00000001878FE69C-0x00000001878FE6B8
		public TweenParams OnPlay(TweenCallback action) => default; // 0x00000001878FE664-0x00000001878FE680
		public TweenParams OnRewind(TweenCallback action) => default; // 0x00000001878FE680-0x00000001878FE69C
		public TweenParams OnUpdate(TweenCallback action) => default; // 0x00000001878FE6D4-0x00000001878FE6F0
		public TweenParams OnStepComplete(TweenCallback action) => default; // 0x00000001878FE6B8-0x00000001878FE6D4
		public TweenParams OnComplete(TweenCallback action) => default; // 0x00000001878FE62C-0x00000001878FE648
		public TweenParams OnKill(TweenCallback action) => default; // 0x00000001878FE648-0x00000001878FE664
		public TweenParams OnWaypointChange(TweenCallback<int> action) => default; // 0x00000001878FE6F0-0x00000001878FE70C
		public TweenParams SetDelay(float delay) => default; // 0x0000000185FB6730-0x0000000185FB6740
		public TweenParams SetRelative(bool isRelative = true /* Metadata: 0x0207CF25 */) => default; // 0x0000000185FB6760-0x0000000185FB6770
		public TweenParams SetSpeedBased(bool isSpeedBased = true /* Metadata: 0x0207CF26 */) => default; // 0x0000000185FB6770-0x0000000185FB6780
	}

	public static class TweenSettingsExtensions // TypeDefIndex: 56803
	{
		// Methods
		public static T SetAutoKill<T>(T t)
			where T : DG.Tweening.Tween => default;
		public static T SetAutoKill<T>(T t, bool autoKillOnCompletion)
			where T : DG.Tweening.Tween => default;
		public static T SetId<T>(T t, object objectId)
			where T : DG.Tweening.Tween => default;
		public static T SetId<T>(T t, string stringId)
			where T : DG.Tweening.Tween => default;
		public static T SetId<T>(T t, int intId)
			where T : DG.Tweening.Tween => default;
		public static T SetLink<T>(T t, GameObject gameObject)
			where T : DG.Tweening.Tween => default;
		public static T SetLink<T>(T t, GameObject gameObject, LinkBehaviour behaviour)
			where T : DG.Tweening.Tween => default;
		public static T SetTarget<T>(T t, object target)
			where T : DG.Tweening.Tween => default;
		public static T SetLoops<T>(T t, int loops)
			where T : DG.Tweening.Tween => default;
		public static T SetLoops<T>(T t, int loops, LoopType loopType)
			where T : DG.Tweening.Tween => default;
		public static T SetEase<T>(T t, Ease ease)
			where T : DG.Tweening.Tween => default;
		public static T SetEase<T>(T t, Ease ease, float overshoot)
			where T : DG.Tweening.Tween => default;
		public static T SetEase<T>(T t, Ease ease, float amplitude, float period)
			where T : DG.Tweening.Tween => default;
		public static T SetEase<T>(T t, AnimationCurve animCurve)
			where T : DG.Tweening.Tween => default;
		public static T SetEase<T>(T t, EaseFunction customEase)
			where T : DG.Tweening.Tween => default;
		public static T SetRecyclable<T>(T t)
			where T : DG.Tweening.Tween => default;
		public static T SetRecyclable<T>(T t, bool recyclable)
			where T : DG.Tweening.Tween => default;
		public static T SetUpdate<T>(T t, bool isIndependentUpdate)
			where T : DG.Tweening.Tween => default;
		public static T SetUpdate<T>(T t, DG.Tweening.UpdateType updateType)
			where T : DG.Tweening.Tween => default;
		public static T SetUpdate<T>(T t, DG.Tweening.UpdateType updateType, bool isIndependentUpdate)
			where T : DG.Tweening.Tween => default;
		public static T SetInverted<T>(T t)
			where T : DG.Tweening.Tween => default;
		public static T SetInverted<T>(T t, bool inverted)
			where T : DG.Tweening.Tween => default;
		public static T OnStart<T>(T t, TweenCallback action)
			where T : DG.Tweening.Tween => default;
		public static T OnPlay<T>(T t, TweenCallback action)
			where T : DG.Tweening.Tween => default;
		public static T OnPause<T>(T t, TweenCallback action)
			where T : DG.Tweening.Tween => default;
		public static T OnRewind<T>(T t, TweenCallback action)
			where T : DG.Tweening.Tween => default;
		public static T OnUpdate<T>(T t, TweenCallback action)
			where T : DG.Tweening.Tween => default;
		public static T OnStepComplete<T>(T t, TweenCallback action)
			where T : DG.Tweening.Tween => default;
		public static T OnComplete<T>(T t, TweenCallback action)
			where T : DG.Tweening.Tween => default;
		public static T OnKill<T>(T t, TweenCallback action)
			where T : DG.Tweening.Tween => default;
		public static T OnWaypointChange<T>(T t, TweenCallback<int> action)
			where T : DG.Tweening.Tween => default;
		public static T SetAs<T>(T t, DG.Tweening.Tween asTween)
			where T : DG.Tweening.Tween => default;
		public static T SetAs<T>(T t, TweenParams tweenParams)
			where T : DG.Tweening.Tween => default;
		public static DG.Tweening.Sequence Append(DG.Tweening.Sequence s, DG.Tweening.Tween t) => default; // 0x00000001844A6600-0x00000001844A6650
		public static DG.Tweening.Sequence Prepend(DG.Tweening.Sequence s, DG.Tweening.Tween t) => default; // 0x00000001878FEDF0-0x00000001878FEE2C
		public static DG.Tweening.Sequence Join(DG.Tweening.Sequence s, DG.Tweening.Tween t) => default; // 0x00000001844A68A0-0x00000001844A68F0
		public static DG.Tweening.Sequence Insert(DG.Tweening.Sequence s, float atPosition, DG.Tweening.Tween t) => default; // 0x00000001878FED18-0x00000001878FED68
		public static DG.Tweening.Sequence AppendInterval(DG.Tweening.Sequence s, float interval) => default; // 0x00000001844A4C30-0x00000001844A4C70
		public static DG.Tweening.Sequence PrependInterval(DG.Tweening.Sequence s, float interval) => default; // 0x00000001878FEDB0-0x00000001878FEDF0
		public static DG.Tweening.Sequence AppendCallback(DG.Tweening.Sequence s, TweenCallback callback) => default; // 0x0000000185D23FE0-0x0000000185D24030
		public static DG.Tweening.Sequence PrependCallback(DG.Tweening.Sequence s, TweenCallback callback) => default; // 0x00000001878FED68-0x00000001878FEDB0
		public static DG.Tweening.Sequence InsertCallback(DG.Tweening.Sequence s, float atPosition, TweenCallback callback) => default; // 0x00000001878FECC4-0x00000001878FED18
		private static bool ValidateAddToSequence(DG.Tweening.Sequence s, DG.Tweening.Tween t, bool ignoreTween = false /* Metadata: 0x0207CF27 */) => default; // 0x00000001844A6840-0x00000001844A68A0
		public static T From<T>(T t)
			where T : Tweener => default;
		public static T From<T>(T t, bool isRelative)
			where T : Tweener => default;
		public static T From<T>(T t, bool setImmediately, bool isRelative)
			where T : Tweener => default;
		public static TweenerCore<T1, T2, TPlugOptions> From<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately = true /* Metadata: 0x0207CF28 */, bool isRelative = false /* Metadata: 0x0207CF29 */)
			where TPlugOptions : struct, IPlugOptions => default;
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> From(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t, float fromAlphaValue, bool setImmediately = true /* Metadata: 0x0207CF2A */, bool isRelative = false /* Metadata: 0x0207CF2B */) => default; // 0x00000001878FEABC-0x00000001878FEB78
		public static TweenerCore<Vector3, Vector3, VectorOptions> From(TweenerCore<Vector3, Vector3, VectorOptions> t, float fromValue, bool setImmediately = true /* Metadata: 0x0207CF2C */, bool isRelative = false /* Metadata: 0x0207CF2D */) => default; // 0x00000001878FEB78-0x00000001878FEC24
		public static TweenerCore<Vector2, Vector2, CircleOptions> From(TweenerCore<Vector2, Vector2, CircleOptions> t, float fromValueDegrees, bool setImmediately = true /* Metadata: 0x0207CF2E */, bool isRelative = false /* Metadata: 0x0207CF2F */) => default; // 0x00000001878FEC24-0x00000001878FECC4
		public static T SetDelay<T>(T t, float delay)
			where T : DG.Tweening.Tween => default;
		public static T SetDelay<T>(T t, float delay, bool asPrependedIntervalIfSequence)
			where T : DG.Tweening.Tween => default;
		public static T SetRelative<T>(T t)
			where T : DG.Tweening.Tween => default;
		public static T SetRelative<T>(T t, bool isRelative)
			where T : DG.Tweening.Tween => default;
		public static T SetSpeedBased<T>(T t)
			where T : DG.Tweening.Tween => default;
		public static T SetSpeedBased<T>(T t, bool isSpeedBased)
			where T : DG.Tweening.Tween => default;
		public static Tweener SetOptions(TweenerCore<float, float, FloatOptions> t, bool snapping) => default; // 0x00000001878FF370-0x00000001878FF388
		public static Tweener SetOptions(TweenerCore<Vector2, Vector2, VectorOptions> t, bool snapping) => default; // 0x00000001844A60F0-0x00000001844A6110
		public static Tweener SetOptions(TweenerCore<Vector2, Vector2, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x0207CF30 */) => default; // 0x00000001859D9810-0x00000001859D9830
		public static Tweener SetOptions(TweenerCore<Vector3, Vector3, VectorOptions> t, bool snapping) => default; // 0x00000001849738F0-0x0000000184973910
		public static Tweener SetOptions(TweenerCore<Vector3, Vector3, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x0207CF31 */) => default; // 0x00000001878FF350-0x00000001878FF370
		public static Tweener SetOptions(TweenerCore<Vector4, Vector4, VectorOptions> t, bool snapping) => default; // 0x00000001878FF1F0-0x00000001878FF208
		public static Tweener SetOptions(TweenerCore<Vector4, Vector4, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x0207CF32 */) => default; // 0x00000001878FF1D0-0x00000001878FF1F0
		public static Tweener SetOptions(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool useShortest360Route = true /* Metadata: 0x0207CF33 */) => default; // 0x00000001878FF208-0x00000001878FF228
		public static Tweener SetOptions(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t, bool alphaOnly) => default; // 0x00000001844A4850-0x00000001844A4870
		public static Tweener SetOptions(TweenerCore<Rect, Rect, RectOptions> t, bool snapping) => default; // 0x00000001844A4850-0x00000001844A4870
		public static Tweener SetOptions(TweenerCore<string, string, StringOptions> t, bool richTextEnabled, ScrambleMode scrambleMode = ScrambleMode.None /* Metadata: 0x0207CF34 */, string scrambleChars = null) => default; // 0x00000001878FF228-0x00000001878FF300
		public static Tweener SetOptions(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool snapping) => default; // 0x00000001844A60F0-0x00000001844A6110
		public static Tweener SetOptions(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x0207CF35 */) => default; // 0x00000001859D9810-0x00000001859D9830
		public static Tweener SetOptions(TweenerCore<Vector2, Vector2, CircleOptions> t, float endValueDegrees, bool relativeCenter = true /* Metadata: 0x0207CF36 */, bool snapping = false /* Metadata: 0x0207CF37 */) => default; // 0x00000001878FF328-0x00000001878FF350
		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(TweenerCore<Vector3, Path, PathOptions> t, AxisConstraint lockPosition, AxisConstraint lockRotation = AxisConstraint.None /* Metadata: 0x0207CF38 */) => default; // 0x00000001878FF388-0x00000001878FF3A8
		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(TweenerCore<Vector3, Path, PathOptions> t, bool closePath, AxisConstraint lockPosition = AxisConstraint.None /* Metadata: 0x0207CF39 */, AxisConstraint lockRotation = AxisConstraint.None /* Metadata: 0x0207CF3A */) => default; // 0x00000001878FF300-0x00000001878FF328
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, Vector3? forwardDirection = default, Vector3? up = default) => default; // 0x00000001878FEF30-0x00000001878FEFA0
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, bool stableZRotation) => default; // 0x00000001878FF020-0x00000001878FF08C
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, Vector3? forwardDirection = default, Vector3? up = default) => default; // 0x00000001878FEEA8-0x00000001878FEF30
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, bool stableZRotation) => default; // 0x00000001878FF08C-0x00000001878FF110
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, Vector3? forwardDirection = default, Vector3? up = default) => default; // 0x00000001878FEFA0-0x00000001878FF020
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, bool stableZRotation) => default; // 0x00000001878FEE2C-0x00000001878FEEA8
		private static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, OrientType orientType, Vector3 lookAtPosition, Transform lookAtTransform, float lookAhead, Vector3? forwardDirection = default, Vector3? up = default, bool stableZRotation = false /* Metadata: 0x0207CF3B */) => default; // 0x00000001878FF110-0x00000001878FF1D0
		private static void SetPathForwardDirection(TweenerCore<Vector3, Path, PathOptions> t, Vector3? forwardDirection = default, Vector3? up = default) {} // 0x00000001878FF3A8-0x00000001878FF63C
	}

	public enum LogBehaviour // TypeDefIndex: 56804
	{
		Default = 0,
		Verbose = 1,
		ErrorsOnly = 2
	}

	public abstract class Tween : ABSSequentiable // TypeDefIndex: 56805
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
		private bool _isRelative_k__BackingField; // 0xB0
		internal Ease easeType; // 0xB4
		internal EaseFunction customEase; // 0xB8
		public float easeOvershootOrAmplitude; // 0xC0
		public float easePeriod; // 0xC4
		public string debugTargetId; // 0xC8
		internal System.Type typeofT1; // 0xD0
		internal System.Type typeofT2; // 0xD8
		internal System.Type typeofTPlugOptions; // 0xE0
		private bool _active_k__BackingField; // 0xE8
		internal bool isSequenced; // 0xE9
		internal DG.Tweening.Sequence sequenceParent; // 0xF0
		internal int activeId; // 0xF8
		internal SpecialStartupMode specialStartupMode; // 0xFC
		internal bool creationLocked; // 0x100
		internal bool startupDone; // 0x101
		private bool _playedOnce_k__BackingField; // 0x102
		private float _position_k__BackingField; // 0x104
		internal float fullDuration; // 0x108
		internal int completedLoops; // 0x10C
		internal bool isPlaying; // 0x110
		internal bool isComplete; // 0x111
		internal float elapsedDelay; // 0x114
		internal bool delayComplete; // 0x118
		internal int miscInt; // 0x11C
	
		// Properties
		public bool isRelative { get; internal set; } // 0x0000000181B10450-0x0000000181B10460 0x0000000181B10460-0x0000000181B10470
		public bool active { get; internal set; } // 0x0000000185FB67C0-0x0000000185FB67D0 0x0000000185FB67F0-0x0000000185FB6800
		public float fullPosition { get; set; } // 0x00000001878FF63C-0x00000001878FF648 0x00000001878FF648-0x00000001878FF658
		public bool hasLoops { get; } // 0x00000001844AD6D0-0x00000001844AD6F0 
		public bool playedOnce { get; private set; } // 0x0000000185FB67D0-0x0000000185FB67E0 0x0000000185FB6800-0x0000000185FB6810
		public float position { get; internal set; } // 0x0000000185FB67E0-0x0000000185FB67F0 0x0000000185FB6810-0x0000000185FB6820
	
		// Constructors
		protected Tween() {} // 0x0000000185FB6790-0x0000000185FB67C0
	
		// Methods
		internal virtual void Reset() {} // 0x0000000184E15FC0-0x0000000184E16140
		internal abstract bool Validate();
		internal virtual float UpdateDelay(float elapsed) => default; // 0x0000000183908D00-0x0000000183908D10
		internal abstract bool Startup();
		internal abstract bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, UpdateNotice updateNotice);
		internal static bool DoGoto(Tween t, float toPosition, int toCompletedLoops, DG.Tweening.Core.Enums.UpdateMode updateMode) => default; // 0x00000001844AD260-0x00000001844AD6D0
		internal static bool OnTweenCallback(TweenCallback callback, Tween t) => default; // 0x00000001844AE090-0x00000001844AE1C0
		internal static bool OnTweenCallback<T>(TweenCallback<T> callback, Tween t, T param) => default;
	}

	public abstract class Tweener : DG.Tweening.Tween // TypeDefIndex: 56806
	{
		// Fields
		internal bool hasManuallySetStartValue; // 0x120
		internal bool isFromAllowed; // 0x121
	
		// Constructors
		internal Tweener() {} // 0x0000000185FB6820-0x0000000185FB6850
	
		// Methods
		public abstract Tweener ChangeStartValue(object newStartValue, float newDuration = -1f /* Metadata: 0x0207CF3F */);
		public abstract Tweener ChangeEndValue(object newEndValue, float newDuration = -1f /* Metadata: 0x0207CF43 */, bool snapStartValue = false /* Metadata: 0x0207CF47 */);
		public abstract Tweener ChangeEndValue(object newEndValue, bool snapStartValue);
		public abstract Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1f /* Metadata: 0x0207CF48 */);
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

	public enum TweenType // TypeDefIndex: 56807
	{
		Tweener = 0,
		Sequence = 1,
		Callback = 2
	}

	public enum UpdateType // TypeDefIndex: 56808
	{
		Normal = 0,
		Late = 1,
		Fixed = 2,
		Manual = 3
	}
}

namespace DG.Tweening.Core
{
	public abstract class ABSSequentiable // TypeDefIndex: 56854
	{
		// Fields
		internal TweenType tweenType; // 0x10
		internal float sequencedPosition; // 0x14
		internal float sequencedEndPosition; // 0x18
		internal TweenCallback onStart; // 0x20
	
		// Constructors
		protected ABSSequentiable() {} // 0x0000000185492010-0x0000000185492020
	}

	public delegate T DOGetter<out T>(); // TypeDefIndex: 56855; 0x00000000-0x00000000

	public delegate void DOSetter<in T>(T pNewValue); // TypeDefIndex: 56856; 0x00000000-0x00000000

	public static class Debugger // TypeDefIndex: 56858
	{
		// Fields
		private static int _logPriority; // 0x00
		private const string _LogPrefix = "<color=#0099bc><b>DOTWEEN \u25BA </b></color>"; // Metadata: 0x0207CF5E
	
		// Properties
		public static int logPriority { get; } // 0x000000018790F778-0x000000018790F858 
	
		// Nested types
		internal static class Sequence // TypeDefIndex: 56857
		{
			// Methods
			public static void LogAddToNullSequence() {} // 0x000000018790F9BC-0x000000018790F9F4
			public static void LogAddToInactiveSequence() {} // 0x000000018790F858-0x000000018790F948
			public static void LogAddToLockedSequence() {} // 0x00000001856B5510-0x00000001856B5620
			public static void LogAddNullTween() {} // 0x000000018790F198-0x000000018790F2EC
			public static void LogAddInactiveTween(DG.Tweening.Tween t) {} // 0x000000018790F5C4-0x000000018790F778
			public static void LogAddAlreadySequencedTween(DG.Tweening.Tween t) {} // 0x000000018790F4E4-0x000000018790F5C4
		}
	
		// Methods
		public static void Log(object message) {} // 0x000000018790F2EC-0x000000018790F324
		public static void LogWarning(object message, DG.Tweening.Tween t = null) {} // 0x000000018790F3DC-0x000000018790F418
		public static void LogError(object message, DG.Tweening.Tween t = null) {} // 0x000000018790F454-0x000000018790F48C
		public static void LogSafeModeCapturedError(object message, DG.Tweening.Tween t = null) {} // 0x000000018790F418-0x000000018790F454
		public static void LogReport(object message) {} // 0x000000018790F324-0x000000018790F370
		public static void LogSafeModeReport(object message) {} // 0x000000018790F370-0x000000018790F3DC
		public static void LogInvalidTween(DG.Tweening.Tween t) {} // 0x000000018790F48C-0x000000018790F4E4
		public static void LogNestedTween(DG.Tweening.Tween t) {} // 0x000000018790F140-0x000000018790F198
		public static void LogNullTween(DG.Tweening.Tween t) {} // 0x0000000185625BB0-0x0000000185625C00
		public static void LogNonPathTween(DG.Tweening.Tween t) {} // 0x000000018790F948-0x000000018790F9BC
		public static void LogMissingMaterialProperty(string propertyName) {} // 0x000000018790F0F4-0x000000018790F140
		public static void LogMissingMaterialProperty(int propertyId) {} // 0x000000018790EF2C-0x000000018790F0F4
		public static void LogRemoveActiveTweenError(string errorInfo, DG.Tweening.Tween t) {} // 0x0000000187915F3C-0x0000000187915F74
		public static void LogAddActiveTweenError(string errorInfo, DG.Tweening.Tween t) {} // 0x0000000187915ECC-0x0000000187915F04
		public static void SetLogPriority(LogBehaviour logBehaviour) {} // 0x0000000187915F04-0x0000000187915F3C
		public static bool ShouldLogSafeModeCapturedError() => default; // 0x0000000187915E94-0x0000000187915ECC
		private static string GetDebugDataMessage(DG.Tweening.Tween t) => default; // 0x0000000187915E58-0x0000000187915E94
		private static void AddDebugDataToMessage(ref string message, DG.Tweening.Tween t) {} // 0x0000000187915E1C-0x0000000187915E58
	}

	public class DOTweenComponent : MonoBehaviour, IDOTweenInit // TypeDefIndex: 56865
	{
		// Fields
		public int inspectorUpdater; // 0x18
		private float _unscaledTime; // 0x1C
		private float _unscaledDeltaTime; // 0x20
		private bool _paused; // 0x24
		private float _pausedTime; // 0x28
		private bool _isQuitting; // 0x2C
		private bool _duplicateToDestroy; // 0x2D
	
		// Nested types
		private sealed class _WaitForCompletion_d__17 : IEnumerator<object> // TypeDefIndex: 56859
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DG.Tweening.Tween t; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x00000001850A5380-0x00000001850A53F0 
			object IEnumerator.Current { get => default; } // 0x000000018790E9EC-0x000000018790EB0C 
	
			// Constructors
			public _WaitForCompletion_d__17() {} // Dummy constructor
			public _WaitForCompletion_d__17(int __1__state) {} // 0x0000000185B407F0-0x0000000185B40980
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185F52020-0x0000000185F520C0
			private bool MoveNext() => default; // 0x00000001841B0E60-0x00000001841B1060
			void IEnumerator.Reset() {} // 0x0000000184FCB610-0x0000000184FCB680
		}
	
		private sealed class _WaitForRewind_d__18 : IEnumerator<object> // TypeDefIndex: 56860
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DG.Tweening.Tween t; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018790EB0C-0x000000018790EB6C 
			object IEnumerator.Current { get => default; } // 0x000000018790ECFC-0x000000018790ED58 
	
			// Constructors
			public _WaitForRewind_d__18() {} // Dummy constructor
			public _WaitForRewind_d__18(int __1__state) {} // 0x000000018790E5F0-0x000000018790E9EC
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018509B8E0-0x000000018509B900
			private bool MoveNext() => default; // 0x000000018790E5A4-0x000000018790E5F0
			void IEnumerator.Reset() {} // 0x000000018790EB6C-0x000000018790EBC8
		}
	
		private sealed class _WaitForKill_d__19 : IEnumerator<object> // TypeDefIndex: 56861
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DG.Tweening.Tween t; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018790ED58-0x000000018790EDB4 
			object IEnumerator.Current { get => default; } // 0x000000018790E4B4-0x000000018790E5A4 
	
			// Constructors
			public _WaitForKill_d__19() {} // Dummy constructor
			public _WaitForKill_d__19(int __1__state) {} // 0x000000018790EC34-0x000000018790EC90
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018790EBC8-0x000000018790EC34
			private bool MoveNext() => default; // 0x000000018790EC90-0x000000018790ECFC
			void IEnumerator.Reset() {} // 0x0000000185625C00-0x0000000185625D50
		}
	
		private sealed class _WaitForElapsedLoops_d__20 : IEnumerator<object> // TypeDefIndex: 56862
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DG.Tweening.Tween t; // 0x20
			public int elapsedLoops; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018791909C-0x00000001879190F0 
			object IEnumerator.Current { get => default; } // 0x00000001879190F0-0x000000018791913C 
	
			// Constructors
			public _WaitForElapsedLoops_d__20() {} // Dummy constructor
			public _WaitForElapsedLoops_d__20(int __1__state) {} // 0x000000018646DB20-0x000000018646DB28
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000181378230-0x0000000181378240
			private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
			void IEnumerator.Reset() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		private sealed class _WaitForPosition_d__21 : IEnumerator<object> // TypeDefIndex: 56863
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DG.Tweening.Tween t; // 0x20
			public float position; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000187919338-0x00000001879193B4 
			object IEnumerator.Current { get => default; } // 0x00000001879193B4-0x0000000187919400 
	
			// Constructors
			public _WaitForPosition_d__21() {} // Dummy constructor
			public _WaitForPosition_d__21(int __1__state) {} // 0x0000000181377E40-0x0000000181377E50
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000181378230-0x0000000181378240
			private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
			void IEnumerator.Reset() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		private sealed class _WaitForStart_d__22 : IEnumerator<object> // TypeDefIndex: 56864
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DG.Tweening.Tween t; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x00000001879191E4-0x0000000187919230 
			object IEnumerator.Current { get => default; } // 0x0000000187919230-0x000000018791927C 
	
			// Constructors
			public _WaitForStart_d__22() {} // Dummy constructor
			public _WaitForStart_d__22(int __1__state) {} // 0x0000000181377E40-0x0000000181377E50
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000181378230-0x0000000181378240
			private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
			void IEnumerator.Reset() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		// Constructors
		public DOTweenComponent() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		private void Awake() {} // 0x0000000181377E40-0x0000000181377E50
		private void Start() {} // 0x0000000181378230-0x0000000181378240
		private void Update() {} // 0x0000000185492010-0x0000000185492020
		private void LateUpdate() {} // 0x000000018791913C-0x0000000187919198
		private void FixedUpdate() {} // 0x0000000181377E40-0x0000000181377E50
		private void OnDrawGizmos() {} // 0x0000000187919198-0x00000001879191E4
		private void OnDestroy() {} // 0x0000000181377E40-0x0000000181377E50
		public void OnApplicationPause(bool pauseStatus) {} // 0x0000000181378230-0x0000000181378240
		private void OnApplicationQuit() {} // 0x0000000185492010-0x0000000185492020
		public IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity) => default; // 0x000000018791927C-0x00000001879192EC
		internal IEnumerator WaitForCompletion(DG.Tweening.Tween t) => default; // 0x0000000181377E40-0x0000000181377E50
		internal IEnumerator WaitForRewind(DG.Tweening.Tween t) => default; // 0x00000001879192EC-0x0000000187919338
		internal IEnumerator WaitForKill(DG.Tweening.Tween t) => default; // 0x0000000181377E40-0x0000000181377E50
		internal IEnumerator WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops) => default; // 0x0000000181378230-0x0000000181378240
		internal IEnumerator WaitForPosition(DG.Tweening.Tween t, float position) => default; // 0x0000000185492010-0x0000000185492020
		internal IEnumerator WaitForStart(DG.Tweening.Tween t) => default; // 0x0000000187919400-0x0000000187919454
		internal static void Create() {} // 0x0000000181377E40-0x0000000181377E50
		internal static void DestroyInstance() {} // 0x0000000187919454-0x00000001879194A0
	}

	public class DOTweenSettings : ScriptableObject // TypeDefIndex: 56869
	{
		// Fields
		public const string AssetName = "DOTweenSettings"; // Metadata: 0x0207CF89
		public const string AssetFullFilename = "DOTweenSettings.asset"; // Metadata: 0x0207CF99
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
		public enum SettingsLocation // TypeDefIndex: 56866
		{
			AssetsDirectory = 0,
			DOTweenDirectory = 1,
			DemigiantDirectory = 2
		}
	
		[Serializable]
		public class SafeModeOptions // TypeDefIndex: 56867
		{
			// Fields
			public SafeModeLogBehaviour logBehaviour; // 0x10
			public NestedTweenFailureBehaviour nestedTweenFailureBehaviour; // 0x14
	
			// Constructors
			public SafeModeOptions() {} // 0x0000000185EBACD0-0x0000000185EBADA0
		}
	
		[Serializable]
		public class ModulesSetup // TypeDefIndex: 56868
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
			public ModulesSetup() {} // 0x0000000185FB6940-0x0000000185FB6950
		}
	
		// Constructors
		public DOTweenSettings() {} // 0x0000000185FB68D0-0x0000000185FB68E0
	}

	public static class Extensions // TypeDefIndex: 56870
	{
		// Methods
		public static T SetSpecialStartupMode<T>(T t, SpecialStartupMode mode)
			where T : DG.Tweening.Tween => default;
		public static TweenerCore<T1, T2, TPlugOptions> Blendable<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t)
			where TPlugOptions : struct, IPlugOptions => default;
		public static TweenerCore<T1, T2, TPlugOptions> NoFrom<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t)
			where TPlugOptions : struct, IPlugOptions => default;
	}

	public static class DOTweenExternalCommand // TypeDefIndex: 56871
	{
		// Fields
		private static Action<PathOptions, DG.Tweening.Tween, Quaternion, Transform> SetOrientationOnPath; // 0x00
	
		// Events
		public static event Action<PathOptions, DG.Tweening.Tween, Quaternion, Transform> SetOrientationOnPath;
	
		// Methods
		internal static void Dispatch_SetOrientationOnPath(PathOptions options, DG.Tweening.Tween t, Quaternion newRot, Transform trans) {} // 0x000000018790EDB4-0x000000018790EE90
	}

	internal struct SafeModeReport // TypeDefIndex: 56873
	{
		// Fields
		private int _totMissingTargetOrFieldErrors_k__BackingField; // 0x00
		private int _totCallbackErrors_k__BackingField; // 0x04
		private int _totStartupErrors_k__BackingField; // 0x08
		private int _totUnsetErrors_k__BackingField; // 0x0C
	
		// Properties
		public int totMissingTargetOrFieldErrors { get; private set; } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public int totCallbackErrors { get; private set; } // 0x000000018357CBC0-0x000000018357CBD0 0x0000000185FB2BA0-0x0000000185FB2BB0
		public int totStartupErrors { get; private set; } // 0x0000000181B7E450-0x0000000181B7E460 0x0000000185FB2B90-0x0000000185FB2BA0
		public int totUnsetErrors { get; private set; } // 0x00000001834AFB70-0x00000001834AFB80 0x0000000185FB6960-0x0000000185FB6970
	
		// Nested types
		internal enum SafeModeReportType // TypeDefIndex: 56872
		{
			Unset = 0,
			TargetOrFieldMissing = 1,
			Callback = 2,
			StartupFailure = 3
		}
	
		// Methods
		public void Add(SafeModeReportType type) {} // 0x0000000187915DFC-0x0000000187915E1C
		public int GetTotErrors() => default; // 0x0000000185FB6950-0x0000000185FB6960
	}

	internal class SequenceCallback : ABSSequentiable // TypeDefIndex: 56874
	{
		// Constructors
		public SequenceCallback() {} // Dummy constructor
		public SequenceCallback(float sequencedPosition, TweenCallback callback) {} // 0x0000000185D24100-0x0000000185D24120
	}

	internal class TweenLink // TypeDefIndex: 56875
	{
		// Fields
		public readonly GameObject target; // 0x10
		public readonly LinkBehaviour behaviour; // 0x18
		public bool lastSeenActive; // 0x1C
	
		// Constructors
		public TweenLink() {} // Dummy constructor
		public TweenLink(GameObject target, LinkBehaviour behaviour) {} // 0x0000000187917A08-0x0000000187917A48
	}

	internal static class TweenManager // TypeDefIndex: 56877
	{
		// Fields
		private const int _DefaultMaxTweeners = 200; // Metadata: 0x0207CFC3
		private const int _DefaultMaxSequences = 50; // Metadata: 0x0207CFC5
		private const string _MaxTweensReached = "Max Tweens reached: capacity has automatically been increased from #0 to #1. Use DOTween.SetTweensCapacity to set it manually at startup"; // Metadata: 0x0207CFC6
		private const float _EpsilonVsTimeCheck = 1E-06f; // Metadata: 0x0207D050
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
		internal enum CapacityIncreaseMode // TypeDefIndex: 56876
		{
			TweenersAndSequences = 0,
			TweenersOnly = 1,
			SequencesOnly = 2
		}
	
		// Constructors
		static TweenManager() {} // 0x0000000185B91DC0-0x0000000185B92060
	
		// Methods
		internal static TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>()
			where TPlugOptions : struct, IPlugOptions => default;
		internal static DG.Tweening.Sequence GetSequence() => default; // 0x00000001844A6980-0x00000001844A6C30
		internal static void SetUpdateType(DG.Tweening.Tween t, DG.Tweening.UpdateType updateType, bool isIndependentUpdate) {} // 0x0000000185792650-0x00000001857926C0
		internal static void AddActiveTweenToSequence(DG.Tweening.Tween t) {} // 0x00000001844A67F0-0x00000001844A6840
		internal static int DespawnAll() => default; // 0x00000001852D4D80-0x00000001852D5060
		internal static void Despawn(DG.Tweening.Tween t, bool modifyActiveLists = true /* Metadata: 0x0207CFB6 */) {} // 0x00000001844AB3F0-0x00000001844AB5E0
		internal static void PurgeAll(bool isApplicationQuitting) {} // 0x000000018791864C-0x0000000187918898
		internal static void PurgePools() {} // 0x0000000187918898-0x0000000187918994
		internal static void AddTweenLink(DG.Tweening.Tween t, TweenLink tweenLink) {} // 0x0000000187917A48-0x0000000187917BAC
		private static void RemoveTweenLink(DG.Tweening.Tween t) {} // 0x0000000187918994-0x0000000187918A5C
		internal static void ResetCapacities() {} // 0x0000000187918A5C-0x0000000187918AA8
		internal static void SetCapacities(int tweenersCapacity, int sequencesCapacity) {} // 0x0000000187918AA8-0x0000000187918BB8
		internal static int Validate() => default; // 0x0000000187918F14-0x000000018791909C
		internal static void Update(DG.Tweening.UpdateType updateType, float deltaTime, float independentTime) {} // 0x00000001844ACD70-0x00000001844AD040
		internal static bool Update(DG.Tweening.Tween t, float deltaTime, float independentTime, bool isSingleTweenManualUpdate) => default; // 0x00000001844AD040-0x00000001844AD260
		internal static int FilteredOperation(DG.Tweening.Core.Enums.OperationType operationType, DG.Tweening.Core.Enums.FilterType filterType, object id, bool optionalBool, float optionalFloat, object optionalObj = null, object[] optionalArray = null) => default; // 0x00000001844ACAD0-0x00000001844ACD70
		internal static bool Complete(DG.Tweening.Tween t, bool modifyActiveLists = true /* Metadata: 0x0207CFB7 */, DG.Tweening.Core.Enums.UpdateMode updateMode = DG.Tweening.Core.Enums.UpdateMode.Goto /* Metadata: 0x0207CFB8 */) => default; // 0x00000001844AA480-0x00000001844AA580
		internal static bool Flip(DG.Tweening.Tween t) => default; // 0x0000000187917FF4-0x0000000187918014
		internal static void ForceInit(DG.Tweening.Tween t, bool isSequenced = false /* Metadata: 0x0207CFB9 */) {} // 0x0000000185C294B0-0x0000000185C29520
		internal static bool Goto(DG.Tweening.Tween t, float to, bool andPlay = false /* Metadata: 0x0207CFBA */, DG.Tweening.Core.Enums.UpdateMode updateMode = DG.Tweening.Core.Enums.UpdateMode.Goto /* Metadata: 0x0207CFBB */) => default; // 0x00000001844AE9C0-0x00000001844AEB00
		internal static bool Pause(DG.Tweening.Tween t) => default; // 0x00000001855EA490-0x00000001855EA4D0
		internal static bool Play(DG.Tweening.Tween t) => default; // 0x0000000185F04D30-0x0000000185F04D60
		internal static bool PlayBackwards(DG.Tweening.Tween t) => default; // 0x0000000187918510-0x00000001879185C0
		internal static bool PlayForward(DG.Tweening.Tween t) => default; // 0x00000001879185C0-0x000000018791864C
		internal static bool Restart(DG.Tweening.Tween t, bool includeDelay = true /* Metadata: 0x0207CFBC */, float changeDelayTo = -1f /* Metadata: 0x0207CFBD */) => default; // 0x000000018415BF50-0x000000018415C030
		internal static bool Rewind(DG.Tweening.Tween t, bool includeDelay = true /* Metadata: 0x0207CFC1 */) => default; // 0x000000018415C030-0x000000018415C130
		internal static bool SmoothRewind(DG.Tweening.Tween t) => default; // 0x0000000187918BB8-0x0000000187918CA4
		internal static bool TogglePause(DG.Tweening.Tween t) => default; // 0x0000000187918CA4-0x0000000187918D0C
		internal static int TotalPooledTweens() => default; // 0x0000000187918E1C-0x0000000187918E70
		internal static int TotalPlayingTweens() => default; // 0x0000000187918D0C-0x0000000187918E1C
		internal static int TotalTweensById(object id, bool playingOnly) => default; // 0x0000000187918E70-0x0000000187918F14
		internal static List<DG.Tweening.Tween> GetActiveTweens(bool playing, List<DG.Tweening.Tween> fillableList = null) => default; // 0x0000000187918014-0x00000001879181AC
		internal static List<DG.Tweening.Tween> GetTweensById(object id, bool playingOnly, List<DG.Tweening.Tween> fillableList = null) => default; // 0x00000001879181AC-0x00000001879182E0
		private static int DoGetTweensById(object id, bool playingOnly, bool addToList, List<DG.Tweening.Tween> fillableList) => default; // 0x0000000187917BAC-0x0000000187917D6C
		internal static List<DG.Tweening.Tween> GetTweensByTarget(object target, bool playingOnly, List<DG.Tweening.Tween> fillableList = null) => default; // 0x00000001879182E0-0x0000000187918488
		private static void MarkForKilling(DG.Tweening.Tween t, bool isSingleTweenManualUpdate = false /* Metadata: 0x0207CFC2 */) {} // 0x00000001844AB1E0-0x00000001844AB280
		private static void EvaluateTweenLink(DG.Tweening.Tween t) {} // 0x0000000187917D6C-0x0000000187917FF4
		private static void AddActiveTween(DG.Tweening.Tween t) {} // 0x00000001844ABB60-0x00000001844ABE50
		private static void ReorganizeActiveTweens() {} // 0x00000001844ABE50-0x00000001844AC170
		private static void DespawnActiveTweens(List<DG.Tweening.Tween> tweens) {} // 0x00000001844AB120-0x00000001844AB1E0
		private static void RemoveActiveTween(DG.Tweening.Tween t) {} // 0x00000001844AB790-0x00000001844ABB60
		private static void ClearTweenArray(DG.Tweening.Tween[] tweens) {} // 0x00000001844AB280-0x00000001844AB2E0
		private static void IncreaseCapacities(CapacityIncreaseMode increaseMode) {} // 0x0000000185C35940-0x0000000185C35B00
		private static void ManageOnRewindCallbackWhenAlreadyRewinded(DG.Tweening.Tween t, bool isPlayBackwardsOrSmoothRewind) {} // 0x0000000187918488-0x0000000187918510
	}

	public static class DOTweenUtils // TypeDefIndex: 56878
	{
		// Fields
		private static Assembly[] _loadedAssemblies; // 0x00
		private static readonly string[] _defAssembliesToQuery; // 0x08
	
		// Constructors
		static DOTweenUtils() {} // 0x0000000185EB8290-0x0000000185EB8370
	
		// Methods
		internal static Vector3 Vector3FromAngle(float degrees, float magnitude) => default; // 0x0000000185FB6980-0x0000000185FB69E0
		internal static float Angle2D(Vector3 from, Vector3 to) => default; // 0x000000018791BAD0-0x000000018791BBD0
		internal static Vector3 RotateAroundPivot(Vector3 point, Vector3 pivot, Quaternion rotation) => default; // 0x000000018791BC54-0x000000018791BD14
		public static Vector2 GetPointOnCircle(Vector2 center, float radius, float degrees) => default; // 0x000000018791BBD0-0x000000018791BC54
		internal static bool Vector3AreApproximatelyEqual(Vector3 a, Vector3 b) => default; // 0x000000018791BD14-0x000000018791BD68
		internal static System.Type GetLooseScriptType(string typeName) => default; // 0x0000000185B40980-0x0000000185B40AC0
	}

	public class TweenerCore<T1, T2, TPlugOptions> : Tweener // TypeDefIndex: 56879
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
		private const string _TxtCantChangeSequencedValues = "You cannot change the values of a tween contained inside a Sequence"; // Metadata: 0x0207D071
		private System.Type _colorType;
		private System.Type _color32Type;
	
		// Constructors
		internal TweenerCore() {}
	
		// Methods
		public override Tweener ChangeStartValue(object newStartValue, float newDuration = -1f /* Metadata: 0x0207D057 */) => default;
		public override Tweener ChangeEndValue(object newEndValue, bool snapStartValue) => default;
		public override Tweener ChangeEndValue(object newEndValue, float newDuration = -1f /* Metadata: 0x0207D05B */, bool snapStartValue = false /* Metadata: 0x0207D05F */) => default;
		public override Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1f /* Metadata: 0x0207D060 */) => default;
		public TweenerCore<T1, T2, TPlugOptions> ChangeStartValue(T2 newStartValue, float newDuration = -1f /* Metadata: 0x0207D064 */) => default;
		public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, bool snapStartValue) => default;
		public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, float newDuration = -1f /* Metadata: 0x0207D068 */, bool snapStartValue = false /* Metadata: 0x0207D06C */) => default;
		public TweenerCore<T1, T2, TPlugOptions> ChangeValues(T2 newStartValue, T2 newEndValue, float newDuration = -1f /* Metadata: 0x0207D06D */) => default;
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
	public static class Bounce // TypeDefIndex: 56888
	{
		// Methods
		public static float EaseIn(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod) => default; // 0x000000018791B9F4-0x000000018791BA30
		public static float EaseOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod) => default; // 0x000000018791BA30-0x000000018791BAD0
		public static float EaseInOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod) => default; // 0x000000018791B980-0x000000018791B9F4
	}

	public static class EaseManager // TypeDefIndex: 56890
	{
		// Fields
		private const float _PiOver2 = 1.5707964f; // Metadata: 0x0207D0DC
		private const float _TwoPi = 6.2831855f; // Metadata: 0x0207D0E0
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 56889
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static EaseFunction __9__4_0; // 0x08
			public static EaseFunction __9__4_1; // 0x10
			public static EaseFunction __9__4_2; // 0x18
			public static EaseFunction __9__4_3; // 0x20
			public static EaseFunction __9__4_4; // 0x28
			public static EaseFunction __9__4_5; // 0x30
			public static EaseFunction __9__4_6; // 0x38
			public static EaseFunction __9__4_7; // 0x40
			public static EaseFunction __9__4_8; // 0x48
			public static EaseFunction __9__4_9; // 0x50
			public static EaseFunction __9__4_10; // 0x58
			public static EaseFunction __9__4_11; // 0x60
			public static EaseFunction __9__4_12; // 0x68
			public static EaseFunction __9__4_13; // 0x70
			public static EaseFunction __9__4_14; // 0x78
			public static EaseFunction __9__4_15; // 0x80
			public static EaseFunction __9__4_16; // 0x88
			public static EaseFunction __9__4_17; // 0x90
			public static EaseFunction __9__4_18; // 0x98
			public static EaseFunction __9__4_19; // 0xA0
			public static EaseFunction __9__4_20; // 0xA8
			public static EaseFunction __9__4_21; // 0xB0
			public static EaseFunction __9__4_22; // 0xB8
			public static EaseFunction __9__4_23; // 0xC0
			public static EaseFunction __9__4_24; // 0xC8
			public static EaseFunction __9__4_25; // 0xD0
			public static EaseFunction __9__4_26; // 0xD8
			public static EaseFunction __9__4_27; // 0xE0
			public static EaseFunction __9__4_28; // 0xE8
			public static EaseFunction __9__4_29; // 0xF0
			public static EaseFunction __9__4_30; // 0xF8
			public static EaseFunction __9__4_31; // 0x100
			public static EaseFunction __9__4_32; // 0x108
			public static EaseFunction __9__4_33; // 0x110
			public static EaseFunction __9__4_34; // 0x118
			public static EaseFunction __9__4_35; // 0x120
	
			// Constructors
			static __c() {} // 0x000000018791BD68-0x000000018791BDAC
			public __c() {} // 0x00000001844AD9C0-0x00000001844ADC50
	
			// Methods
			internal float _ToEaseFunction_b__4_0(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791BDAC-0x000000018791D658
			internal float _ToEaseFunction_b__4_1(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x0000000185240050-0x0000000185240060
			internal float _ToEaseFunction_b__4_2(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791E970-0x000000018791EB08
			internal float _ToEaseFunction_b__4_3(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x0000000185492010-0x0000000185492020
			internal float _ToEaseFunction_b__4_4(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791DB00-0x000000018791DB08
			internal float _ToEaseFunction_b__4_5(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791DEC8-0x000000018791DF40
			internal float _ToEaseFunction_b__4_6(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791E6B8-0x000000018791E720
			internal float _ToEaseFunction_b__4_7(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791E82C-0x000000018791E8A4
			internal float _ToEaseFunction_b__4_8(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x0000000185FB69E0-0x0000000185FB69F0
			internal float _ToEaseFunction_b__4_9(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791E810-0x000000018791E82C
			internal float _ToEaseFunction_b__4_10(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791E8A4-0x000000018791E8F0
			internal float _ToEaseFunction_b__4_11(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791E8F0-0x000000018791E900
			internal float _ToEaseFunction_b__4_12(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791E900-0x000000018791E920
			internal float _ToEaseFunction_b__4_13(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791E920-0x000000018791E970
			internal float _ToEaseFunction_b__4_14(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791DB08-0x000000018791DB1C
			internal float _ToEaseFunction_b__4_15(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791DB1C-0x000000018791DB48
			internal float _ToEaseFunction_b__4_16(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791DB48-0x000000018791DBA4
			internal float _ToEaseFunction_b__4_17(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791DBA4-0x000000018791DBBC
			internal float _ToEaseFunction_b__4_18(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791DBBC-0x000000018791DBE4
			internal float _ToEaseFunction_b__4_19(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791DBE4-0x000000018791DC44
			internal float _ToEaseFunction_b__4_20(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791DC44-0x000000018791DCCC
			internal float _ToEaseFunction_b__4_21(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791DCCC-0x000000018791DD5C
			internal float _ToEaseFunction_b__4_22(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791DD5C-0x000000018791DE4C
			internal float _ToEaseFunction_b__4_23(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791DE4C-0x000000018791DEC8
			internal float _ToEaseFunction_b__4_24(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791DF40-0x000000018791DFB0
			internal float _ToEaseFunction_b__4_25(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791DFB0-0x000000018791E06C
			internal float _ToEaseFunction_b__4_26(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791E06C-0x000000018791E1F0
			internal float _ToEaseFunction_b__4_27(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791E1F0-0x000000018791E37C
			internal float _ToEaseFunction_b__4_28(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791E37C-0x000000018791E594
			internal float _ToEaseFunction_b__4_29(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791E594-0x000000018791E5B4
			internal float _ToEaseFunction_b__4_30(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791E5B4-0x000000018791E5E0
			internal float _ToEaseFunction_b__4_31(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791E5E0-0x000000018791E648
			internal float _ToEaseFunction_b__4_32(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791E648-0x000000018791E688
			internal float _ToEaseFunction_b__4_33(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791E688-0x000000018791E6B8
			internal float _ToEaseFunction_b__4_34(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791E720-0x000000018791E750
			internal float _ToEaseFunction_b__4_35(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791E750-0x000000018791E780
		}
	
		// Methods
		public static float Evaluate(DG.Tweening.Tween t, float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791E780-0x000000018791E7B0
		public static float Evaluate(Ease easeType, EaseFunction customEase, float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791E7B0-0x000000018791E7E0
		public static EaseFunction ToEaseFunction(Ease ease) => default; // 0x000000018791E7E0-0x000000018791E810
		internal static bool IsFlashEase(Ease ease) => default; // 0x000000018791E810-0x000000018791E82C
	}

	public class EaseCurve // TypeDefIndex: 56891
	{
		// Fields
		private readonly AnimationCurve _animCurve; // 0x10
	
		// Constructors
		public EaseCurve() {} // Dummy constructor
		public EaseCurve(AnimationCurve animCurve) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public float Evaluate(float time, float duration, float unusedOvershoot, float unusedPeriod) => default; // 0x0000000184879570-0x0000000184879600
	}

	public static class Flash // TypeDefIndex: 56892
	{
		// Methods
		public static float Ease(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791D8F0-0x000000018791D9AC
		public static float EaseIn(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791D75C-0x000000018791D81C
		public static float EaseOut(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791D81C-0x000000018791D8F0
		public static float EaseInOut(float time, float duration, float overshootOrAmplitude, float period) => default; // 0x000000018791D658-0x000000018791D75C
		private static float WeightedEase(float overshootOrAmplitude, float period, int stepIndex, float stepDuration, float dir, float res) => default; // 0x000000018791D9AC-0x000000018791DB00
	}
}

namespace DG.Tweening.Core.Enums
{
	internal enum FilterType // TypeDefIndex: 56880
	{
		All = 0,
		TargetOrId = 1,
		TargetAndId = 2,
		AllExceptTargetsOrIds = 3,
		DOGetter = 4
	}

	public enum NestedTweenFailureBehaviour // TypeDefIndex: 56881
	{
		TryToPreserveSequence = 0,
		KillWholeSequence = 1
	}

	internal enum OperationType // TypeDefIndex: 56882
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

	public enum SafeModeLogBehaviour // TypeDefIndex: 56883
	{
		None = 0,
		Normal = 1,
		Warning = 2,
		Error = 3
	}

	public enum SpecialStartupMode // TypeDefIndex: 56884
	{
		None = 0,
		SetLookAt = 1,
		SetShake = 2,
		SetPunch = 3,
		SetCameraShakePosition = 4
	}

	public enum UpdateNotice // TypeDefIndex: 56885
	{
		None = 0,
		RewindStep = 1
	}

	internal enum UpdateMode // TypeDefIndex: 56886
	{
		Update = 0,
		Goto = 1,
		IgnoreOnUpdate = 2,
		IgnoreOnComplete = 3
	}

	public enum RewindCallbackMode // TypeDefIndex: 56887
	{
		FireIfPositionChanged = 0,
		FireAlwaysWithRewind = 1,
		FireAlways = 2
	}
}

namespace DG.Tweening.CustomPlugins
{
	public class PureQuaternionPlugin : ABSTweenPlugin<Quaternion, Quaternion, NoOptions> // TypeDefIndex: 56853
	{
		// Fields
		private static PureQuaternionPlugin _plug; // 0x00
	
		// Constructors
		public PureQuaternionPlugin() {} // 0x0000000184973DA0-0x0000000184973DD0
	
		// Methods
		public static PureQuaternionPlugin Plug() => default; // 0x0000000184973D00-0x0000000184973DA0
		public override void Reset(TweenerCore<Quaternion, Quaternion, NoOptions> t) {} // 0x0000000185492010-0x0000000185492020
		public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, bool isRelative) {} // 0x00000001879140A4-0x0000000187914154
		public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion fromValue, bool setImmediately, bool isRelative) {} // 0x0000000187913FB0-0x00000001879140A4
		public override Quaternion ConvertToStartValue(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion value) => default; // 0x0000000185FB68B0-0x0000000185FB68C0
		public override void SetRelativeEndValue(TweenerCore<Quaternion, Quaternion, NoOptions> t) {} // 0x0000000187914154-0x00000001879141A8
		public override void SetChangeValue(TweenerCore<Quaternion, Quaternion, NoOptions> t) {} // 0x0000000185A66440-0x0000000185A66470
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, Quaternion changeValue) => default; // 0x0000000187913F6C-0x0000000187913FB0
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Quaternion startValue, Quaternion changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x0000000185545FB0-0x00000001855460A0
	}
}

namespace DG.Tweening.Plugins
{
	public struct CircleOptions : IPlugOptions // TypeDefIndex: 56809
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
		public void Reset() {} // 0x0000000185FB66D0-0x0000000185FB66E0
		public void Initialize(Vector2 startValue, Vector2 endValue) {} // 0x00000001878EED60-0x00000001878EEE2C
	}

	public class CirclePlugin : ABSTweenPlugin<Vector2, Vector2, CircleOptions> // TypeDefIndex: 56810
	{
		// Constructors
		public CirclePlugin() {} // 0x00000001878EF494-0x00000001878EF4BC
	
		// Methods
		public override void Reset(TweenerCore<Vector2, Vector2, CircleOptions> t) {} // 0x0000000185492010-0x0000000185492020
		public override void SetFrom(TweenerCore<Vector2, Vector2, CircleOptions> t, bool isRelative) {} // 0x00000001878EF2D0-0x00000001878EF418
		public override void SetFrom(TweenerCore<Vector2, Vector2, CircleOptions> t, Vector2 fromValue, bool setImmediately, bool isRelative) {} // 0x00000001878EF174-0x00000001878EF2D0
		public static ABSTweenPlugin<Vector2, Vector2, CircleOptions> Get() => default; // 0x00000001878EF0C0-0x00000001878EF0F0
		public override Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, CircleOptions> t, Vector2 value) => default; // 0x0000000185FB66E0-0x0000000185FB66F0
		public override void SetRelativeEndValue(TweenerCore<Vector2, Vector2, CircleOptions> t) {} // 0x00000001878EF418-0x00000001878EF494
		public override void SetChangeValue(TweenerCore<Vector2, Vector2, CircleOptions> t) {} // 0x00000001878EF0F0-0x00000001878EF174
		public override float GetSpeedBasedDuration(CircleOptions options, float unitsXSecond, Vector2 changeValue) => default; // 0x00000001878EF0A8-0x00000001878EF0C0
		public override void EvaluateAndApply(CircleOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x00000001878EEE2C-0x00000001878EEFD0
		public Vector2 GetPositionOnCircle(CircleOptions options, float degrees) => default; // 0x00000001878EEFD0-0x00000001878EF0A8
	}

	internal class Color2Plugin : ABSTweenPlugin<Color2, Color2, ColorOptions> // TypeDefIndex: 56811
	{
		// Constructors
		public Color2Plugin() {} // 0x00000001878EFC34-0x00000001878EFC5C
	
		// Methods
		public override void Reset(TweenerCore<Color2, Color2, ColorOptions> t) {} // 0x0000000185492010-0x0000000185492020
		public override void SetFrom(TweenerCore<Color2, Color2, ColorOptions> t, bool isRelative) {} // 0x00000001878EFA38-0x00000001878EFBB8
		public override void SetFrom(TweenerCore<Color2, Color2, ColorOptions> t, Color2 fromValue, bool setImmediately, bool isRelative) {} // 0x00000001878EF8A8-0x00000001878EFA38
		public override Color2 ConvertToStartValue(TweenerCore<Color2, Color2, ColorOptions> t, Color2 value) => default; // 0x0000000185FB66F0-0x0000000185FB6710
		public override void SetRelativeEndValue(TweenerCore<Color2, Color2, ColorOptions> t) {} // 0x00000001878EFBB8-0x00000001878EFC34
		public override void SetChangeValue(TweenerCore<Color2, Color2, ColorOptions> t) {} // 0x00000001878EF82C-0x00000001878EF8A8
		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color2 changeValue) => default; // 0x00000001878EF81C-0x00000001878EF82C
		public override void EvaluateAndApply(ColorOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Color2> getter, DOSetter<Color2> setter, float elapsed, Color2 startValue, Color2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x00000001878EF4BC-0x00000001878EF81C
	}

	public class DoublePlugin : ABSTweenPlugin<double, double, NoOptions> // TypeDefIndex: 56812
	{
		// Constructors
		public DoublePlugin() {} // 0x000000018790FCF4-0x000000018790FD1C
	
		// Methods
		public override void Reset(TweenerCore<double, double, NoOptions> t) {} // 0x0000000185492010-0x0000000185492020
		public override void SetFrom(TweenerCore<double, double, NoOptions> t, bool isRelative) {} // 0x000000018790FBA0-0x000000018790FC2C
		public override void SetFrom(TweenerCore<double, double, NoOptions> t, double fromValue, bool setImmediately, bool isRelative) {} // 0x000000018790FC2C-0x000000018790FCC8
		public override double ConvertToStartValue(TweenerCore<double, double, NoOptions> t, double value) => default; // 0x0000000185FB68A0-0x0000000185FB68B0
		public override void SetRelativeEndValue(TweenerCore<double, double, NoOptions> t) {} // 0x000000018790FCC8-0x000000018790FCF4
		public override void SetChangeValue(TweenerCore<double, double, NoOptions> t) {} // 0x000000018790FB74-0x000000018790FBA0
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, double changeValue) => default; // 0x000000018790FB58-0x000000018790FB74
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<double> getter, DOSetter<double> setter, float elapsed, double startValue, double changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x000000018790F9F4-0x000000018790FB58
	}

	public class LongPlugin : ABSTweenPlugin<long, long, NoOptions> // TypeDefIndex: 56813
	{
		// Constructors
		public LongPlugin() {} // 0x0000000187910914-0x000000018791093C
	
		// Methods
		public override void Reset(TweenerCore<long, long, NoOptions> t) {} // 0x0000000185492010-0x0000000185492020
		public override void SetFrom(TweenerCore<long, long, NoOptions> t, bool isRelative) {} // 0x00000001879107E0-0x0000000187910864
		public override void SetFrom(TweenerCore<long, long, NoOptions> t, long fromValue, bool setImmediately, bool isRelative) {} // 0x0000000187910864-0x00000001879108F0
		public override long ConvertToStartValue(TweenerCore<long, long, NoOptions> t, long value) => default; // 0x0000000185FB66E0-0x0000000185FB66F0
		public override void SetRelativeEndValue(TweenerCore<long, long, NoOptions> t) {} // 0x00000001879108F0-0x0000000187910914
		public override void SetChangeValue(TweenerCore<long, long, NoOptions> t) {} // 0x00000001879107B4-0x00000001879107E0
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, long changeValue) => default; // 0x0000000187910798-0x00000001879107B4
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<long> getter, DOSetter<long> setter, float elapsed, long startValue, long changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x0000000187910600-0x0000000187910798
	}

	public class UlongPlugin : ABSTweenPlugin<ulong, ulong, NoOptions> // TypeDefIndex: 56814
	{
		// Constructors
		public UlongPlugin() {} // 0x0000000187919A44-0x0000000187919A6C
	
		// Methods
		public override void Reset(TweenerCore<ulong, ulong, NoOptions> t) {} // 0x0000000185492010-0x0000000185492020
		public override void SetFrom(TweenerCore<ulong, ulong, NoOptions> t, bool isRelative) {} // 0x00000001879199C0-0x0000000187919A44
		public override void SetFrom(TweenerCore<ulong, ulong, NoOptions> t, ulong fromValue, bool setImmediately, bool isRelative) {} // 0x0000000187910864-0x00000001879108F0
		public override ulong ConvertToStartValue(TweenerCore<ulong, ulong, NoOptions> t, ulong value) => default; // 0x0000000185FB66E0-0x0000000185FB66F0
		public override void SetRelativeEndValue(TweenerCore<ulong, ulong, NoOptions> t) {} // 0x00000001879108F0-0x0000000187910914
		public override void SetChangeValue(TweenerCore<ulong, ulong, NoOptions> t) {} // 0x00000001879107B4-0x00000001879107E0
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, ulong changeValue) => default; // 0x0000000187919980-0x00000001879199C0
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<ulong> getter, DOSetter<ulong> setter, float elapsed, ulong startValue, ulong changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x0000000187919784-0x0000000187919980
	}

	public class Vector3ArrayPlugin : ABSTweenPlugin<Vector3, Vector3[], Vector3ArrayOptions> // TypeDefIndex: 56815
	{
		// Constructors
		public Vector3ArrayPlugin() {} // 0x000000018791A940-0x000000018791A968
	
		// Methods
		public override void Reset(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) {} // 0x0000000187914EBC-0x0000000187914F10
		public override void SetFrom(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool isRelative) {} // 0x0000000185492010-0x0000000185492020
		public override void SetFrom(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, Vector3[] fromValue, bool setImmediately, bool isRelative) {} // 0x0000000185492010-0x0000000185492020
		public override Vector3[] ConvertToStartValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, Vector3 value) => default; // 0x0000000187919E30-0x0000000187919F34
		public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) {} // 0x000000018791A7E0-0x000000018791A940
		public override void SetChangeValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) {} // 0x000000018791A69C-0x000000018791A7E0
		public override float GetSpeedBasedDuration(Vector3ArrayOptions options, float unitsXSecond, Vector3[] changeValue) => default; // 0x000000018791A608-0x000000018791A69C
		public override void EvaluateAndApply(Vector3ArrayOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3[] startValue, Vector3[] changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x0000000187919F34-0x000000018791A608
	}

	public class PathPlugin : ABSTweenPlugin<Vector3, Path, PathOptions> // TypeDefIndex: 56816
	{
		// Fields
		public const float MinLookAhead = 0.0001f; // Metadata: 0x0207CF53
	
		// Constructors
		public PathPlugin() {} // 0x0000000187912574-0x000000018791259C
	
		// Methods
		public override void Reset(TweenerCore<Vector3, Path, PathOptions> t) {} // 0x0000000187910E74-0x0000000187910EDC
		public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, bool isRelative) {} // 0x0000000185492010-0x0000000185492020
		public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, Path fromValue, bool setImmediately, bool isRelative) {} // 0x0000000185492010-0x0000000185492020
		public static ABSTweenPlugin<Vector3, Path, PathOptions> Get() => default; // 0x0000000187910E44-0x0000000187910E74
		public override Path ConvertToStartValue(TweenerCore<Vector3, Path, PathOptions> t, Vector3 value) => default; // 0x00000001879109D4-0x00000001879109F0
		public override void SetRelativeEndValue(TweenerCore<Vector3, Path, PathOptions> t) {} // 0x000000018791246C-0x0000000187912574
		public override void SetChangeValue(TweenerCore<Vector3, Path, PathOptions> t) {} // 0x0000000187910EDC-0x0000000187911398
		public override float GetSpeedBasedDuration(PathOptions options, float unitsXSecond, Path changeValue) => default; // 0x0000000187910E24-0x0000000187910E44
		public override void EvaluateAndApply(PathOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Path startValue, Path changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x0000000187910A24-0x0000000187910E24
		public void SetOrientation(PathOptions options, DG.Tweening.Tween t, Path path, float pathPerc, Vector3 tPos, UpdateNotice updateNotice) {} // 0x0000000187911398-0x000000018791246C
		private Vector3 DivideVectorByVector(Vector3 vector, Vector3 byVector) => default; // 0x00000001879109F0-0x0000000187910A24
		private Vector3 MultiplyVectorByVector(Vector3 vector, Vector3 byVector) => default; // 0x0000000185FB68E0-0x0000000185FB6920
	}

	public class ColorPlugin : ABSTweenPlugin<UnityEngine.Color, UnityEngine.Color, ColorOptions> // TypeDefIndex: 56817
	{
		// Constructors
		public ColorPlugin() {} // 0x00000001858B1210-0x00000001858B1240
	
		// Methods
		public override void Reset(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t) {} // 0x0000000185492010-0x0000000185492020
		public override void SetFrom(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t, bool isRelative) {} // 0x000000018790D2D4-0x000000018790D3B8
		public override void SetFrom(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t, UnityEngine.Color fromValue, bool setImmediately, bool isRelative) {} // 0x000000018790D3B8-0x000000018790D4F0
		public override UnityEngine.Color ConvertToStartValue(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t, UnityEngine.Color value) => default; // 0x0000000185FB68B0-0x0000000185FB68C0
		public override void SetRelativeEndValue(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t) {} // 0x000000018790D4F0-0x000000018790D544
		public override void SetChangeValue(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t) {} // 0x0000000185BC58D0-0x0000000185BC5920
		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, UnityEngine.Color changeValue) => default; // 0x00000001878EF81C-0x00000001878EF82C
		public override void EvaluateAndApply(ColorOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<UnityEngine.Color> getter, DOSetter<UnityEngine.Color> setter, float elapsed, UnityEngine.Color startValue, UnityEngine.Color changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x0000000184E15930-0x0000000184E15A80
	}

	public class IntPlugin : ABSTweenPlugin<int, int, NoOptions> // TypeDefIndex: 56818
	{
		// Constructors
		public IntPlugin() {} // 0x00000001879101FC-0x0000000187910224
	
		// Methods
		public override void Reset(TweenerCore<int, int, NoOptions> t) {} // 0x0000000185492010-0x0000000185492020
		public override void SetFrom(TweenerCore<int, int, NoOptions> t, bool isRelative) {} // 0x0000000187910160-0x00000001879101DC
		public override void SetFrom(TweenerCore<int, int, NoOptions> t, int fromValue, bool setImmediately, bool isRelative) {} // 0x00000001879100D8-0x0000000187910160
		public override int ConvertToStartValue(TweenerCore<int, int, NoOptions> t, int value) => default; // 0x0000000185FB68C0-0x0000000185FB68D0
		public override void SetRelativeEndValue(TweenerCore<int, int, NoOptions> t) {} // 0x00000001879101DC-0x00000001879101FC
		public override void SetChangeValue(TweenerCore<int, int, NoOptions> t) {} // 0x00000001879100B0-0x00000001879100D8
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, int changeValue) => default; // 0x0000000187910094-0x00000001879100B0
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<int> getter, DOSetter<int> setter, float elapsed, int startValue, int changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x000000018790FF0C-0x0000000187910094
	}

	public class QuaternionPlugin : ABSTweenPlugin<Quaternion, Vector3, QuaternionOptions> // TypeDefIndex: 56819
	{
		// Constructors
		public QuaternionPlugin() {} // 0x0000000185BC9680-0x0000000185BC96B0
	
		// Methods
		public override void Reset(TweenerCore<Quaternion, Vector3, QuaternionOptions> t) {} // 0x0000000185492010-0x0000000185492020
		public override void SetFrom(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool isRelative) {} // 0x00000001879141CC-0x00000001879144B8
		public override void SetFrom(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Vector3 fromValue, bool setImmediately, bool isRelative) {} // 0x00000001879144B8-0x0000000187914664
		public override Vector3 ConvertToStartValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Quaternion value) => default; // 0x0000000184E14C20-0x0000000184E14C50
		public override void SetRelativeEndValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t) {} // 0x0000000187914664-0x00000001879146D8
		public override void SetChangeValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t) {} // 0x0000000184E148B0-0x0000000184E14A90
		public override float GetSpeedBasedDuration(QuaternionOptions options, float unitsXSecond, Vector3 changeValue) => default; // 0x00000001879141A8-0x00000001879141CC
		public override void EvaluateAndApply(QuaternionOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x0000000185545DD0-0x0000000185545FB0
		private Vector3 GetEulerValForCalculations(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Vector3 val, Vector3 counterVal) => default; // 0x0000000184E14A90-0x0000000184E14BE0
		private Vector3 FlipEulerAngles(Vector3 euler) => default; // 0x0000000184E14BE0-0x0000000184E14C20
	}

	public class RectOffsetPlugin : ABSTweenPlugin<RectOffset, RectOffset, NoOptions> // TypeDefIndex: 56820
	{
		// Fields
		private static RectOffset _r; // 0x00
	
		// Constructors
		public RectOffsetPlugin() {} // 0x00000001879155E8-0x0000000187915610
		static RectOffsetPlugin() {} // 0x000000018791556C-0x00000001879155E8
	
		// Methods
		public override void Reset(TweenerCore<RectOffset, RectOffset, NoOptions> t) {} // 0x0000000187914EBC-0x0000000187914F10
		public override void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, bool isRelative) {} // 0x000000018791508C-0x000000018791522C
		public override void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset fromValue, bool setImmediately, bool isRelative) {} // 0x000000018791522C-0x0000000187915448
		public override RectOffset ConvertToStartValue(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset value) => default; // 0x00000001879146D8-0x000000018791479C
		public override void SetRelativeEndValue(TweenerCore<RectOffset, RectOffset, NoOptions> t) {} // 0x0000000187915448-0x000000018791556C
		public override void SetChangeValue(TweenerCore<RectOffset, RectOffset, NoOptions> t) {} // 0x0000000187914F10-0x000000018791508C
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, RectOffset changeValue) => default; // 0x0000000187914DE8-0x0000000187914EBC
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, float elapsed, RectOffset startValue, RectOffset changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x000000018791479C-0x0000000187914DE8
	}

	public class RectPlugin : ABSTweenPlugin<Rect, Rect, RectOptions> // TypeDefIndex: 56821
	{
		// Constructors
		public RectPlugin() {} // 0x0000000187915DD4-0x0000000187915DFC
	
		// Methods
		public override void Reset(TweenerCore<Rect, Rect, RectOptions> t) {} // 0x0000000185492010-0x0000000185492020
		public override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, bool isRelative) {} // 0x0000000187915A00-0x0000000187915BA0
		public override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, Rect fromValue, bool setImmediately, bool isRelative) {} // 0x0000000187915BA0-0x0000000187915D60
		public override Rect ConvertToStartValue(TweenerCore<Rect, Rect, RectOptions> t, Rect value) => default; // 0x0000000185FB68B0-0x0000000185FB68C0
		public override void SetRelativeEndValue(TweenerCore<Rect, Rect, RectOptions> t) {} // 0x0000000187915D60-0x0000000187915DD4
		public override void SetChangeValue(TweenerCore<Rect, Rect, RectOptions> t) {} // 0x0000000187915984-0x0000000187915A00
		public override float GetSpeedBasedDuration(RectOptions options, float unitsXSecond, Rect changeValue) => default; // 0x0000000187915900-0x0000000187915984
		public override void EvaluateAndApply(RectOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Rect> getter, DOSetter<Rect> setter, float elapsed, Rect startValue, Rect changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x0000000187915610-0x0000000187915900
	}

	public class UintPlugin : ABSTweenPlugin<uint, uint, UintOptions> // TypeDefIndex: 56822
	{
		// Constructors
		public UintPlugin() {} // 0x000000018791975C-0x0000000187919784
	
		// Methods
		public override void Reset(TweenerCore<uint, uint, UintOptions> t) {} // 0x0000000185492010-0x0000000185492020
		public override void SetFrom(TweenerCore<uint, uint, UintOptions> t, bool isRelative) {} // 0x00000001879196E0-0x000000018791975C
		public override void SetFrom(TweenerCore<uint, uint, UintOptions> t, uint fromValue, bool setImmediately, bool isRelative) {} // 0x00000001879100D8-0x0000000187910160
		public override uint ConvertToStartValue(TweenerCore<uint, uint, UintOptions> t, uint value) => default; // 0x0000000185FB68C0-0x0000000185FB68D0
		public override void SetRelativeEndValue(TweenerCore<uint, uint, UintOptions> t) {} // 0x00000001879101DC-0x00000001879101FC
		public override void SetChangeValue(TweenerCore<uint, uint, UintOptions> t) {} // 0x0000000187919690-0x00000001879196E0
		public override float GetSpeedBasedDuration(UintOptions options, float unitsXSecond, uint changeValue) => default; // 0x000000018791966C-0x0000000187919690
		public override void EvaluateAndApply(UintOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<uint> getter, DOSetter<uint> setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x00000001879194A0-0x000000018791966C
	}

	public class Vector2Plugin : ABSTweenPlugin<Vector2, Vector2, VectorOptions> // TypeDefIndex: 56823
	{
		// Constructors
		public Vector2Plugin() {} // 0x000000018545A610-0x000000018545A640
	
		// Methods
		public override void Reset(TweenerCore<Vector2, Vector2, VectorOptions> t) {} // 0x0000000185492010-0x0000000185492020
		public override void SetFrom(TweenerCore<Vector2, Vector2, VectorOptions> t, bool isRelative) {} // 0x0000000187919C54-0x0000000187919DAC
		public override void SetFrom(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 fromValue, bool setImmediately, bool isRelative) {} // 0x0000000187919A98-0x0000000187919C54
		public override Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 value) => default; // 0x0000000185FB66E0-0x0000000185FB66F0
		public override void SetRelativeEndValue(TweenerCore<Vector2, Vector2, VectorOptions> t) {} // 0x0000000187919DAC-0x0000000187919E1C
		public override void SetChangeValue(TweenerCore<Vector2, Vector2, VectorOptions> t) {} // 0x0000000184E16140-0x0000000184E161F0
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector2 changeValue) => default; // 0x0000000187919A6C-0x0000000187919A98
		public override void EvaluateAndApply(VectorOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x00000001844ADCC0-0x00000001844ADEB0
	}

	public class Vector4Plugin : ABSTweenPlugin<Vector4, Vector4, VectorOptions> // TypeDefIndex: 56824
	{
		// Constructors
		public Vector4Plugin() {} // 0x000000018791B958-0x000000018791B980
	
		// Methods
		public override void Reset(TweenerCore<Vector4, Vector4, VectorOptions> t) {} // 0x0000000185492010-0x0000000185492020
		public override void SetFrom(TweenerCore<Vector4, Vector4, VectorOptions> t, bool isRelative) {} // 0x000000018791B420-0x000000018791B60C
		public override void SetFrom(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 fromValue, bool setImmediately, bool isRelative) {} // 0x000000018791B60C-0x000000018791B958
		public override Vector4 ConvertToStartValue(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 value) => default; // 0x0000000185FB68B0-0x0000000185FB68C0
		public override void SetRelativeEndValue(TweenerCore<Vector4, Vector4, VectorOptions> t) {} // 0x000000018790D4F0-0x000000018790D544
		public override void SetChangeValue(TweenerCore<Vector4, Vector4, VectorOptions> t) {} // 0x000000018791B310-0x000000018791B420
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector4 changeValue) => default; // 0x000000018791B2EC-0x000000018791B310
		public override void EvaluateAndApply(VectorOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector4> getter, DOSetter<Vector4> setter, float elapsed, Vector4 startValue, Vector4 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x000000018791ADE4-0x000000018791B2EC
	}

	public class StringPlugin : ABSTweenPlugin<string, string, StringOptions> // TypeDefIndex: 56825
	{
		// Fields
		private static readonly StringBuilder _Buffer; // 0x00
		private static readonly List<char> _OpenedTags; // 0x08
	
		// Constructors
		public StringPlugin() {} // 0x00000001879179E0-0x0000000187917A08
		static StringPlugin() {} // 0x0000000187917900-0x00000001879179E0
	
		// Methods
		public override void SetFrom(TweenerCore<string, string, StringOptions> t, bool isRelative) {} // 0x0000000187917878-0x0000000187917900
		public override void SetFrom(TweenerCore<string, string, StringOptions> t, string fromValue, bool setImmediately, bool isRelative) {} // 0x00000001879177B0-0x0000000187917878
		public override void Reset(TweenerCore<string, string, StringOptions> t) {} // 0x0000000187917404-0x000000018791747C
		public override string ConvertToStartValue(TweenerCore<string, string, StringOptions> t, string value) => default; // 0x0000000185FB66E0-0x0000000185FB66F0
		public override void SetRelativeEndValue(TweenerCore<string, string, StringOptions> t) {} // 0x0000000185492010-0x0000000185492020
		public override void SetChangeValue(TweenerCore<string, string, StringOptions> t) {} // 0x0000000187917548-0x00000001879177B0
		public override float GetSpeedBasedDuration(StringOptions options, float unitsXSecond, string changeValue) => default; // 0x00000001879173B0-0x0000000187917404
		public override void EvaluateAndApply(StringOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<string> getter, DOSetter<string> setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x0000000187916F18-0x00000001879173B0
		private StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled) => default; // 0x00000001879168B4-0x0000000187916F18
		private char[] ScrambledCharsToUse(StringOptions options) => default; // 0x000000018791747C-0x0000000187917548
	}

	internal static class StringPluginExtensions // TypeDefIndex: 56826
	{
		// Fields
		public static readonly char[] ScrambledCharsAll; // 0x00
		public static readonly char[] ScrambledCharsUppercase; // 0x08
		public static readonly char[] ScrambledCharsLowercase; // 0x10
		public static readonly char[] ScrambledCharsNumerals; // 0x18
		private static int _lastRndSeed; // 0x20
	
		// Constructors
		static StringPluginExtensions() {} // 0x00000001879166B4-0x00000001879168B4
	
		// Methods
		internal static void ScrambleChars(char[] chars) {} // 0x0000000187916628-0x00000001879166B4
		internal static StringBuilder AppendScrambledChars(StringBuilder buffer, int length, char[] chars) => default; // 0x00000001879164F4-0x0000000187916628
	}

	public class FloatPlugin : ABSTweenPlugin<float, float, FloatOptions> // TypeDefIndex: 56827
	{
		// Constructors
		public FloatPlugin() {} // 0x00000001850FC120-0x00000001850FC150
	
		// Methods
		public override void Reset(TweenerCore<float, float, FloatOptions> t) {} // 0x0000000185492010-0x0000000185492020
		public override void SetFrom(TweenerCore<float, float, FloatOptions> t, bool isRelative) {} // 0x000000018790FD34-0x000000018790FE00
		public override void SetFrom(TweenerCore<float, float, FloatOptions> t, float fromValue, bool setImmediately, bool isRelative) {} // 0x000000018790FE00-0x000000018790FEE0
		public override float ConvertToStartValue(TweenerCore<float, float, FloatOptions> t, float value) => default; // 0x0000000185FB68A0-0x0000000185FB68B0
		public override void SetRelativeEndValue(TweenerCore<float, float, FloatOptions> t) {} // 0x000000018790FEE0-0x000000018790FF0C
		public override void SetChangeValue(TweenerCore<float, float, FloatOptions> t) {} // 0x000000018543A3C0-0x000000018543A3F0
		public override float GetSpeedBasedDuration(FloatOptions options, float unitsXSecond, float changeValue) => default; // 0x000000018790FD1C-0x000000018790FD34
		public override void EvaluateAndApply(FloatOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<float> getter, DOSetter<float> setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x00000001844AD8A0-0x00000001844AD9C0
	}

	public class Vector3Plugin : ABSTweenPlugin<Vector3, Vector3, VectorOptions> // TypeDefIndex: 56828
	{
		// Constructors
		public Vector3Plugin() {} // 0x0000000185B6E1C0-0x0000000185B6E1F0
	
		// Methods
		public override void Reset(TweenerCore<Vector3, Vector3, VectorOptions> t) {} // 0x0000000185492010-0x0000000185492020
		public override void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, bool isRelative) {} // 0x000000018791A968-0x000000018791AB68
		public override void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 fromValue, bool setImmediately, bool isRelative) {} // 0x000000018791AB68-0x000000018791ADE4
		public override Vector3 ConvertToStartValue(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 value) => default; // 0x0000000185FB6880-0x0000000185FB68A0
		public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3, VectorOptions> t) {} // 0x0000000187914664-0x00000001879146D8
		public override void SetChangeValue(TweenerCore<Vector3, Vector3, VectorOptions> t) {} // 0x0000000184E15290-0x0000000184E15330
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector3 changeValue) => default; // 0x00000001879141A8-0x00000001879141CC
		public override void EvaluateAndApply(VectorOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice) {} // 0x0000000185586CB0-0x0000000185586E30
	}
}

namespace DG.Tweening.Plugins.Core
{
	public interface ITPlugin<T1, out T2, out TPlugOptions, TPlugin> // TypeDefIndex: 56841
	{
	}

	internal static class SpecialPluginsUtils // TypeDefIndex: 56842
	{
		// Methods
		internal static bool SetLookAt(TweenerCore<Quaternion, Vector3, QuaternionOptions> t) => default; // 0x0000000187916198-0x00000001879162E8
		internal static bool SetPunch(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) => default; // 0x00000001879162E8-0x0000000187916494
		internal static bool SetShake(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) => default; // 0x0000000187916494-0x00000001879164CC
		internal static bool SetCameraShakePosition(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) => default; // 0x0000000187915F74-0x0000000187916198
	}

	public interface IPlugSetter<T1, out T2, TPlugin, out TPlugOptions> // TypeDefIndex: 56843
	{
		// Methods
		DOGetter<T1> Getter();
		DOSetter<T1> Setter();
		T2 EndValue();
		TPlugOptions GetOptions();
	}

	public interface ITweenPlugin // TypeDefIndex: 56844
	{
	}

	public abstract class ABSTweenPlugin<T1, T2, TPlugOptions> : ITweenPlugin // TypeDefIndex: 56845
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

	internal static class PluginsManager // TypeDefIndex: 56846
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
		private const int _MaxCustomPlugins = 20; // Metadata: 0x0207CF5B
		private static Dictionary<System.Type, ITweenPlugin> _customPlugins; // 0x80
	
		// Methods
		internal static ABSTweenPlugin<T1, T2, TPlugOptions> GetDefaultPlugin<T1, T2, TPlugOptions>()
			where TPlugOptions : struct, IPlugOptions => default;
		public static ABSTweenPlugin<T1, T2, TPlugOptions> GetCustomPlugin<TPlugin, T1, T2, TPlugOptions>()
			where TPlugin : ITweenPlugin, new()
			where TPlugOptions : struct, IPlugOptions => default;
		internal static void PurgeAll() {} // 0x0000000187913CA8-0x0000000187913F6C
	}
}

namespace DG.Tweening.Plugins.Core.PathCore
{
	internal class CubicBezierDecoder : ABSPathDecoder // TypeDefIndex: 56847
	{
		// Fields
		private static readonly ControlPoint[] _PartialControlPs; // 0x00
		private static readonly Vector3[] _PartialWps; // 0x08
	
		// Properties
		internal override int minInputWaypoints { get => default; } // 0x0000000181D1CE70-0x0000000181D1CE80 
	
		// Constructors
		public CubicBezierDecoder() {} // 0x0000000185492010-0x0000000185492020
		static CubicBezierDecoder() {} // 0x000000018790E408-0x000000018790E4B4
	
		// Methods
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath) {} // 0x000000018790D6E0-0x000000018790DC28
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints) => default; // 0x000000018790DC28-0x000000018790DEC0
		internal void SetTimeToLengthTables(Path p, int subdivisions) {} // 0x000000018790DEC0-0x000000018790E0B8
		internal void SetWaypointsLengths(Path p, int subdivisions) {} // 0x000000018790E0B8-0x000000018790E408
	}

	[Serializable]
	public struct ControlPoint // TypeDefIndex: 56848
	{
		// Fields
		public Vector3 a; // 0x00
		public Vector3 b; // 0x0C
	
		// Constructors
		public ControlPoint(Vector3 a, Vector3 b) {
			this.a = default;
			this.b = default;
		} // 0x0000000185FB1480-0x0000000185FB14A0
	
		// Methods
		public static ControlPoint operator +(ControlPoint cp, Vector3 v) => default; // 0x000000018790D634-0x000000018790D6E0
		public override string ToString() => default; // 0x000000018790D544-0x000000018790D634
	}

	internal abstract class ABSPathDecoder // TypeDefIndex: 56849
	{
		// Properties
		internal abstract int minInputWaypoints { get; }
	
		// Constructors
		protected ABSPathDecoder() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		internal abstract void FinalizePath(Path p, Vector3[] wps, bool isClosedPath);
		internal abstract Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints);
	}

	internal class CatmullRomDecoder : ABSPathDecoder // TypeDefIndex: 56850
	{
		// Fields
		private static readonly ControlPoint[] _PartialControlPs; // 0x00
		private static readonly Vector3[] _PartialWps; // 0x08
	
		// Properties
		internal override int minInputWaypoints { get => default; } // 0x0000000181B87DE0-0x0000000181B87DF0 
	
		// Constructors
		public CatmullRomDecoder() {} // 0x0000000185492010-0x0000000185492020
		static CatmullRomDecoder() {} // 0x000000018790D228-0x000000018790D2D4
	
		// Methods
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath) {} // 0x000000018790C464-0x000000018790C750
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints) => default; // 0x000000018790C750-0x000000018790CC34
		internal void SetTimeToLengthTables(Path p, int subdivisions) {} // 0x000000018790CC34-0x000000018790CE2C
		internal void SetWaypointsLengths(Path p, int subdivisions) {} // 0x000000018790CE2C-0x000000018790D228
	}

	internal class LinearDecoder : ABSPathDecoder // TypeDefIndex: 56851
	{
		// Properties
		internal override int minInputWaypoints { get => default; } // 0x0000000181B87DE0-0x0000000181B87DF0 
	
		// Constructors
		public LinearDecoder() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath) {} // 0x0000000187910224-0x0000000187910270
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints) => default; // 0x0000000187910270-0x0000000187910444
		internal void SetTimeToLengthTables(Path p, int subdivisions) {} // 0x0000000187910444-0x0000000187910600
		internal void SetWaypointsLengths(Path p, int subdivisions) {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class Path // TypeDefIndex: 56852
	{
		// Fields
		private static CatmullRomDecoder _catmullRomDecoder; // 0x00
		private static LinearDecoder _linearDecoder; // 0x08
		private static CubicBezierDecoder _cubicBezierDecoder; // 0x10
		public float[] wpLengths; // 0x10
		public Vector3[] wps; // 0x18
		internal PathType type; // 0x20
		internal int subdivisionsXSegment; // 0x24
		internal int subdivisions; // 0x28
		internal ControlPoint[] controlPoints; // 0x30
		internal float length; // 0x38
		internal bool isFinalized; // 0x3C
		internal float[] timesTable; // 0x40
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
		internal int minInputWaypoints { get => default; } // 0x0000000187913C84-0x0000000187913CA8 
	
		// Constructors
		public Path(PathType type, Vector3[] waypoints, int subdivisionsXSegment, UnityEngine.Color? gizmoColor = default) {} // 0x0000000187913B04-0x0000000187913C84
		internal Path() {} // 0x0000000185FB6920-0x0000000185FB6940
	
		// Methods
		internal void FinalizePath(bool isClosedPath, AxisConstraint lockPositionAxes, Vector3 currTargetVal) {} // 0x00000001879136F0-0x00000001879137F8
		internal Vector3 GetPoint(float perc, bool convertToConstantPerc = false /* Metadata: 0x0207CF5C */) => default; // 0x00000001879138F0-0x0000000187913968
		internal float ConvertToConstantPathPerc(float perc) => default; // 0x0000000187912E44-0x0000000187912F6C
		internal int GetWaypointIndexFromPerc(float perc, bool isMovingForward) => default; // 0x0000000187913968-0x00000001879139FC
		internal static Vector3[] GetDrawPoints(Path p, int drawSubdivisionsXSegment) => default; // 0x00000001879137F8-0x00000001879138F0
		internal static void RefreshNonLinearDrawWps(Path p) {} // 0x00000001879139FC-0x0000000187913B04
		internal void Destroy() {} // 0x0000000187913034-0x000000018791317C
		internal Path CloneIncremental(int loopIncrement) => default; // 0x0000000187912810-0x0000000187912E44
		internal void AssignWaypoints(Vector3[] newWps, bool cloneWps = false /* Metadata: 0x0207CF5D */) {} // 0x0000000187912728-0x0000000187912810
		internal void AssignDecoder(PathType pathType) {} // 0x000000018791259C-0x0000000187912728
		internal void Draw() {} // 0x00000001879136E8-0x00000001879136F0
		private static void Draw(Path p) {} // 0x000000018791317C-0x00000001879136E8
		private static Vector3 ConvertToDrawPoint(Vector3 wp, PathOptions plugOptions) => default; // 0x0000000187912F6C-0x0000000187913034
	}
}

namespace DG.Tweening.Plugins.Options
{
	public interface IPlugOptions // TypeDefIndex: 56829
	{
		// Methods
		void Reset();
	}

	public enum OrientType // TypeDefIndex: 56830
	{
		None = 0,
		ToPath = 1,
		LookAtTransform = 2,
		LookAtPosition = 3
	}

	public struct PathOptions : IPlugOptions // TypeDefIndex: 56831
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
		public void Reset() {} // 0x000000018791093C-0x00000001879109D4
	}

	public struct QuaternionOptions : IPlugOptions // TypeDefIndex: 56832
	{
		// Fields
		public DG.Tweening.RotateMode rotateMode; // 0x00
		public AxisConstraint axisConstraint; // 0x04
		public Vector3 up; // 0x08
		public bool dynamicLookAt; // 0x14
		public Vector3 dynamicLookAtWorldPosition; // 0x18
	
		// Methods
		public void Reset() {} // 0x0000000184E14EC0-0x0000000184E14EF0
	}

	public struct UintOptions : IPlugOptions // TypeDefIndex: 56833
	{
		// Fields
		public bool isNegativeChangeValue; // 0x00
	
		// Methods
		public void Reset() {} // 0x0000000185FB0F50-0x0000000185FB0F60
	}

	public struct Vector3ArrayOptions : IPlugOptions // TypeDefIndex: 56834
	{
		// Fields
		public AxisConstraint axisConstraint; // 0x00
		public bool snapping; // 0x04
		internal float[] durations; // 0x08
	
		// Methods
		public void Reset() {} // 0x0000000187919E1C-0x0000000187919E30
	}

	public struct NoOptions : IPlugOptions // TypeDefIndex: 56835
	{
		// Methods
		public void Reset() {} // 0x0000000185492010-0x0000000185492020
	}

	public struct ColorOptions : IPlugOptions // TypeDefIndex: 56836
	{
		// Fields
		public bool alphaOnly; // 0x00
	
		// Methods
		public void Reset() {} // 0x0000000185FB0F50-0x0000000185FB0F60
	}

	public struct FloatOptions : IPlugOptions // TypeDefIndex: 56837
	{
		// Fields
		public bool snapping; // 0x00
	
		// Methods
		public void Reset() {} // 0x0000000185FB0F50-0x0000000185FB0F60
	}

	public struct RectOptions : IPlugOptions // TypeDefIndex: 56838
	{
		// Fields
		public bool snapping; // 0x00
	
		// Methods
		public void Reset() {} // 0x0000000185FB0F50-0x0000000185FB0F60
	}

	public struct StringOptions : IPlugOptions // TypeDefIndex: 56839
	{
		// Fields
		public bool richTextEnabled; // 0x00
		public ScrambleMode scrambleMode; // 0x04
		public char[] scrambledChars; // 0x08
		internal int startValueStrippedLength; // 0x10
		internal int changeValueStrippedLength; // 0x14
	
		// Methods
		public void Reset() {} // 0x00000001879164CC-0x00000001879164F4
	}

	public struct VectorOptions : IPlugOptions // TypeDefIndex: 56840
	{
		// Fields
		public AxisConstraint axisConstraint; // 0x00
		public bool snapping; // 0x04
	
		// Methods
		public void Reset() {} // 0x0000000185FB6970-0x0000000185FB6980
	}
}
