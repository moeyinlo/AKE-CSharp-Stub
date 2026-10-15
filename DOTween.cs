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

// Image 42: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 86369-86569

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 86569
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_50 _4EF0676A416B9CCF117C378BDCB6C5CA0EA9505154E3F0F7CC8570285DB79663; // 0x00 // Static value (base64): QQBCAEMARABFAEYARwBIAEkASgBLAEwATQBOAE8AUABRAFIAUwBUAFUAVgBYAFkAWgA= - Metadata: 0x02645798
	internal static readonly __StaticArrayInitTypeSize_20 _921D53955C220A863C9C5D33DD45329C6F74471C522EA5D46EA838D8D4838055; // 0x32 // Static value (base64): MQAyADMANAA1ADYANwA4ADkAMAA= - Metadata: 0x026457D0
	internal static readonly __StaticArrayInitTypeSize_120 A203B1199E78DE3BB75B28FC520ED2F86ADB2749BFC52E3ACA275A3BE2587678; // 0x46 // Static value (base64): QQBCAEMARABFAEYARwBIAEkASgBLAEwATQBOAE8AUABRAFIAUwBUAFUAVgBYAFkAWgBhAGIAYwBkAGUAZgBnAGgAaQBqAGsAbABtAG4AbwBwAHEAcgBzAHQAdQB2AHgAeQB6ADEAMgAzADQANQA2ADcAOAA5ADAA - Metadata: 0x026457E8
	internal static readonly __StaticArrayInitTypeSize_50 C845A807AA8EC73757DC1B07EA49311061FEDECA35AFFE91C5474E0814925020; // 0xBE // Static value (base64): YQBiAGMAZABlAGYAZwBoAGkAagBrAGwAbQBuAG8AcABxAHIAcwB0AHUAdgB4AHkAegA= - Metadata: 0x02645868

	// Nested types
	private struct __StaticArrayInitTypeSize_20 // TypeDefIndex: 86566
	{
	}

	private struct __StaticArrayInitTypeSize_50 // TypeDefIndex: 86567
	{
	}

	private struct __StaticArrayInitTypeSize_120 // TypeDefIndex: 86568
	{
	}
}

namespace DG.Tweening
{
	public enum AutoPlay // TypeDefIndex: 86370
	{
		None = 0,
		AutoPlaySequences = 1,
		AutoPlayTweeners = 2,
		All = 3
	}

	[Flags]
	public enum AxisConstraint // TypeDefIndex: 86371
	{
		None = 0,
		X = 2,
		Y = 4,
		Z = 8,
		W = 16
	}

	public struct Color2 // TypeDefIndex: 86372
	{
		// Fields
		public UnityEngine.Color ca; // 0x00
		public UnityEngine.Color cb; // 0x10
	
		// Constructors
		public Color2(UnityEngine.Color ca, UnityEngine.Color cb); // 0x0000000187239550-0x0000000187239560
	
		// Methods
		public static Color2 operator +(Color2 c1, Color2 c2); // 0x0000000188C7A72C-0x0000000188C7A7A8
		public static Color2 operator -(Color2 c1, Color2 c2); // 0x0000000188C7A808-0x0000000188C7A884
		public static Color2 operator *(Color2 c1, float f); // 0x0000000188C7A7A8-0x0000000188C7A808
	}

	public delegate void TweenCallback(); // TypeDefIndex: 86373; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void TweenCallback<in T>(T value); // TypeDefIndex: 86374; 0x00000000-0x00000000

	public delegate float EaseFunction(float time, float duration, float overshootOrAmplitude, float period); // TypeDefIndex: 86375; 0x00000001812750F0-0x0000000181275110

	public static class DOCurve // TypeDefIndex: 86377
	{
		// Nested types
		public static class CubicBezier // TypeDefIndex: 86376
		{
			// Methods
			public static Vector3 GetPointOnSegment(Vector3 startPoint, Vector3 startControlPoint, Vector3 endPoint, Vector3 endControlPoint, float factor); // 0x0000000188C7A884-0x0000000188C7AA14
			public static Vector3[] GetSegmentPointCloud(Vector3 startPoint, Vector3 startControlPoint, Vector3 endPoint, Vector3 endControlPoint, int resolution = 10 /* Metadata: 0x026454AE */); // 0x0000000188C7AA14-0x0000000188C7AB7C
			public static void GetSegmentPointCloud(List<Vector3> addToList, Vector3 startPoint, Vector3 startControlPoint, Vector3 endPoint, Vector3 endControlPoint, int resolution = 10 /* Metadata: 0x026454AF */); // 0x0000000188C7AB7C-0x0000000188C7ACD0
		}
	}

	public class DOTween // TypeDefIndex: 86379
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
		public static LogBehaviour logBehaviour { get; set; } // 0x0000000188C7DCBC-0x0000000188C7DD0C 0x00000001852D7E90-0x00000001852D7F30
		public static bool debugStoreTargetId { get; set; } // 0x00000001865642C0-0x0000000186564300 0x0000000188C7DD0C-0x0000000188C7DD60
		internal static bool isQuitting { get; set; } // 0x00000001852D81B0-0x00000001852D8270 0x0000000188C7DD60-0x0000000188C7DDD4
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass67_0 // TypeDefIndex: 86378
		{
			// Fields
			public float v; // 0x10
			public DOSetter<float> setter; // 0x18
	
			// Constructors
			public __c__DisplayClass67_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _To_b__0(); // 0x0000000187232D00-0x0000000187232D10
			internal void _To_b__1(float x); // 0x0000000188C8AFCC-0x0000000188C8AFF0
		}
	
		// Constructors
		public DOTween(); // 0x0000000186805BA0-0x0000000186805BB0
		static DOTween(); // 0x0000000186E58500-0x0000000186E58770
	
		// Methods
		public static IDOTweenInit Init(bool? recycleAllByDefault = default, bool? useSafeMode = default, LogBehaviour? logBehaviour = default); // 0x0000000188C7B494-0x0000000188C7B5A4
		private static void AutoInit(); // 0x00000001852D8E90-0x00000001852D8F60
		private static IDOTweenInit Init(DOTweenSettings settings, bool? recycleAllByDefault, bool? useSafeMode, LogBehaviour? logBehaviour); // 0x00000001852D8640-0x00000001852D8A90
		public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity); // 0x0000000188C7C544-0x0000000188C7C59C
		public static void Clear(bool destroy = false /* Metadata: 0x026454B0 */); // 0x0000000188C7AFA4-0x0000000188C7AFF0
		internal static void Clear(bool destroy, bool isApplicationQuitting); // 0x0000000188C7AD10-0x0000000188C7AFA4
		public static void ClearCachedTweens(); // 0x0000000188C7ACD0-0x0000000188C7AD10
		public static int Validate(); // 0x0000000188C7DC7C-0x0000000188C7DCBC
		public static void ManualUpdate(float deltaTime, float unscaledDeltaTime); // 0x0000000188C7B838-0x0000000188C7B930
		public static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration); // 0x0000000185090180-0x00000001850902A0
		public static TweenerCore<double, double, NoOptions> To(DOGetter<double> getter, DOSetter<double> setter, double endValue, float duration); // 0x0000000188C7D7D8-0x0000000188C7D868
		public static TweenerCore<int, int, NoOptions> To(DOGetter<int> getter, DOSetter<int> setter, int endValue, float duration); // 0x0000000188C7D6A4-0x0000000188C7D734
		public static TweenerCore<uint, uint, UintOptions> To(DOGetter<uint> getter, DOSetter<uint> setter, uint endValue, float duration); // 0x0000000188C7D260-0x0000000188C7D2F0
		public static TweenerCore<long, long, NoOptions> To(DOGetter<long> getter, DOSetter<long> setter, long endValue, float duration); // 0x0000000188C7D12C-0x0000000188C7D1BC
		public static TweenerCore<ulong, ulong, NoOptions> To(DOGetter<ulong> getter, DOSetter<ulong> setter, ulong endValue, float duration); // 0x0000000188C7D4AC-0x0000000188C7D53C
		public static TweenerCore<string, string, StringOptions> To(DOGetter<string> getter, DOSetter<string> setter, string endValue, float duration); // 0x0000000188C7D2F0-0x0000000188C7D380
		public static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration); // 0x0000000185C89C40-0x0000000185C89CC0
		public static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration); // 0x0000000185FBBC90-0x0000000185FBBD40
		public static TweenerCore<Vector4, Vector4, VectorOptions> To(DOGetter<Vector4> getter, DOSetter<Vector4> setter, Vector4 endValue, float duration); // 0x0000000188C7D868-0x0000000188C7D904
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration); // 0x0000000188C7D1BC-0x0000000188C7D260
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> To(DOGetter<UnityEngine.Color> getter, DOSetter<UnityEngine.Color> setter, UnityEngine.Color endValue, float duration); // 0x00000001869E6300-0x00000001869E63B0
		public static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration); // 0x0000000188C7D410-0x0000000188C7D4AC
		public static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration); // 0x0000000188C7D380-0x0000000188C7D410
		public static TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration)
			where TPlugOptions : struct, IPlugOptions;
		public static TweenerCore<Vector3, Vector3, VectorOptions> ToAxis(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float endValue, float duration, AxisConstraint axisConstraint = AxisConstraint.None | AxisConstraint.X /* Metadata: 0x026454B1 */); // 0x0000000188C7D080-0x0000000188C7D12C
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> ToAlpha(DOGetter<UnityEngine.Color> getter, DOSetter<UnityEngine.Color> setter, float endValue, float duration); // 0x00000001869E6200-0x00000001869E62E0
		public static Tweener To(DOSetter<float> setter, float startValue, float endValue, float duration); // 0x0000000188C7D53C-0x0000000188C7D6A4
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10 /* Metadata: 0x026454B2 */, float elasticity = 1f /* Metadata: 0x026454B3 */); // 0x0000000188C7BF04-0x0000000188C7C260
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3f /* Metadata: 0x026454B7 */, int vibrato = 10 /* Metadata: 0x026454BB */, float randomness = 90f /* Metadata: 0x026454BC */, bool ignoreZAxis = true /* Metadata: 0x026454C0 */, bool fadeOut = true /* Metadata: 0x026454C1 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x026454C2 */); // 0x0000000188C7CC8C-0x0000000188C7CD60
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x026454C3 */, float randomness = 90f /* Metadata: 0x026454C4 */, bool fadeOut = true /* Metadata: 0x026454C8 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x026454C9 */); // 0x0000000188C7CBC0-0x0000000188C7CC8C
		private static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut, ShakeRandomnessMode randomnessMode); // 0x0000000188C7C59C-0x0000000188C7CBC0
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3[] endValues, float[] durations); // 0x0000000188C7CE40-0x0000000188C7D080
		internal static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration); // 0x0000000188C7D734-0x0000000188C7D7D8
		public static DG.Tweening.Sequence Sequence(); // 0x0000000185C890A0-0x0000000185C89100
		public static DG.Tweening.Sequence Sequence(object target); // 0x0000000188C7C4E8-0x0000000188C7C544
		public static int CompleteAll(bool withCallbacks = false /* Metadata: 0x026454CA */); // 0x0000000188C7AFF0-0x0000000188C7B060
		public static int Complete(object targetOrId, bool withCallbacks = false /* Metadata: 0x026454CB */); // 0x0000000188C7B228-0x0000000188C7B2B0
		internal static int CompleteAndReturnKilledTot(); // 0x0000000188C7B140-0x0000000188C7B1A4
		internal static int CompleteAndReturnKilledTot(object targetOrId); // 0x0000000188C7B0C8-0x0000000188C7B140
		internal static int CompleteAndReturnKilledTot(object target, object id); // 0x0000000188C7B1A4-0x0000000188C7B228
		internal static int CompleteAndReturnKilledTotExceptFor(params object[] excludeTargetsOrIds); // 0x0000000188C7B060-0x0000000188C7B0C8
		public static int FlipAll(); // 0x0000000188C7B2B0-0x0000000188C7B318
		public static int Flip(object targetOrId); // 0x0000000188C7B318-0x0000000188C7B390
		public static int GotoAll(float to, bool andPlay = false /* Metadata: 0x026454CC */); // 0x0000000188C7B390-0x0000000188C7B404
		public static int Goto(object targetOrId, float to, bool andPlay = false /* Metadata: 0x026454CD */); // 0x0000000188C7B404-0x0000000188C7B494
		public static int KillAll(bool complete = false /* Metadata: 0x026454CE */); // 0x0000000188C7B704-0x0000000188C7B774
		public static int KillAll(bool complete, params object[] idsOrTargetsToExclude); // 0x0000000188C7B624-0x0000000188C7B704
		public static int Kill(object targetOrId, bool complete = false /* Metadata: 0x026454CF */); // 0x0000000185093400-0x0000000185093480
		public static int Kill(object target, object id, bool complete = false /* Metadata: 0x026454D0 */); // 0x0000000188C7B774-0x0000000188C7B838
		public static int PauseAll(); // 0x0000000188C7B930-0x0000000188C7B998
		public static int Pause(object targetOrId); // 0x0000000188C7B998-0x0000000188C7BA10
		public static int PlayAll(); // 0x0000000188C7BA74-0x0000000188C7BADC
		public static int Play(object targetOrId); // 0x0000000188C7BDA4-0x0000000188C7BE1C
		public static int Play(object target, object id); // 0x0000000188C7BE1C-0x0000000188C7BEA0
		public static int PlayBackwardsAll(); // 0x0000000188C7BADC-0x0000000188C7BB44
		public static int PlayBackwards(object targetOrId); // 0x0000000188C7BB44-0x0000000188C7BBBC
		public static int PlayBackwards(object target, object id); // 0x0000000188C7BBBC-0x0000000188C7BC40
		public static int PlayForwardAll(); // 0x0000000188C7BC40-0x0000000188C7BCA8
		public static int PlayForward(object targetOrId); // 0x0000000188C7BCA8-0x0000000188C7BD20
		public static int PlayForward(object target, object id); // 0x0000000188C7BD20-0x0000000188C7BDA4
		public static int RestartAll(bool includeDelay = true /* Metadata: 0x026454D1 */); // 0x0000000188C7C260-0x0000000188C7C2CC
		public static int Restart(object targetOrId, bool includeDelay = true /* Metadata: 0x026454D2 */, float changeDelayTo = -1f /* Metadata: 0x026454D3 */); // 0x0000000188C7C368-0x0000000188C7C3F8
		public static int Restart(object target, object id, bool includeDelay = true /* Metadata: 0x026454D7 */, float changeDelayTo = -1f /* Metadata: 0x026454D8 */); // 0x0000000188C7C2CC-0x0000000188C7C368
		public static int RewindAll(bool includeDelay = true /* Metadata: 0x026454DC */); // 0x0000000188C7C3F8-0x0000000188C7C464
		public static int Rewind(object targetOrId, bool includeDelay = true /* Metadata: 0x026454DD */); // 0x0000000188C7C464-0x0000000188C7C4E8
		public static int SmoothRewindAll(); // 0x0000000188C7CD60-0x0000000188C7CDC8
		public static int SmoothRewind(object targetOrId); // 0x0000000188C7CDC8-0x0000000188C7CE40
		public static int TogglePauseAll(); // 0x0000000188C7D904-0x0000000188C7D96C
		public static int TogglePause(object targetOrId); // 0x0000000188C7D96C-0x0000000188C7D9E4
		public static bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying = false /* Metadata: 0x026454DE */); // 0x0000000188C7B5A4-0x0000000188C7B624
		public static int TotalActiveTweens(); // 0x0000000188C7DA84-0x0000000188C7DAD4
		public static int TotalActiveTweeners(); // 0x0000000188C7DA34-0x0000000188C7DA84
		public static int TotalActiveSequences(); // 0x0000000188C7D9E4-0x0000000188C7DA34
		public static int TotalPlayingTweens(); // 0x0000000188C7DAD4-0x0000000188C7DB14
		public static int TotalTweensById(object id, bool playingOnly = false /* Metadata: 0x026454DF */); // 0x0000000188C7DB14-0x0000000188C7DB70
		public static List<DG.Tweening.Tween> PlayingTweens(List<DG.Tweening.Tween> fillableList = null); // 0x0000000188C7BEA0-0x0000000188C7BF04
		public static List<DG.Tweening.Tween> PausedTweens(List<DG.Tweening.Tween> fillableList = null); // 0x0000000188C7BA10-0x0000000188C7BA74
		public static List<DG.Tweening.Tween> TweensById(object id, bool playingOnly = false /* Metadata: 0x026454E0 */, List<DG.Tweening.Tween> fillableList = null); // 0x0000000188C7DB70-0x0000000188C7DBFC
		public static List<DG.Tweening.Tween> TweensByTarget(object target, bool playingOnly = false /* Metadata: 0x026454E1 */, List<DG.Tweening.Tween> fillableList = null); // 0x0000000188C7DBFC-0x0000000188C7DC7C
		private static void InitCheck(); // 0x0000000185C89440-0x0000000185C894D0
		private static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null)
			where TPlugOptions : struct, IPlugOptions;
	}

	public static class DOVirtual // TypeDefIndex: 86384
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 86380
		{
			// Fields
			public float val; // 0x10
			public TweenCallback<float> onVirtualUpdate; // 0x18
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _Float_b__0(); // 0x0000000187232D00-0x0000000187232D10
			internal void _Float_b__1(float x); // 0x0000000187235230-0x0000000187235240
			internal void _Float_b__2(); // 0x0000000188C8A1B4-0x0000000188C8A1E0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 86381
		{
			// Fields
			public int val; // 0x10
			public TweenCallback<int> onVirtualUpdate; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _Int_b__0(); // 0x00000001828BC2B0-0x00000001828BC2C0
			internal void _Int_b__1(int x); // 0x0000000182234E90-0x0000000182234EA0
			internal void _Int_b__2(); // 0x0000000188C8A574-0x0000000188C8A5A0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 86382
		{
			// Fields
			public Vector3 val; // 0x10
			public TweenCallback<Vector3> onVirtualUpdate; // 0x20
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _Vector3_b__0(); // 0x0000000184432B70-0x0000000184432B90
			internal void _Vector3_b__1(Vector3 x); // 0x0000000187239670-0x0000000187239680
			internal void _Vector3_b__2(); // 0x0000000188C8A908-0x0000000188C8A944
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 86383
		{
			// Fields
			public UnityEngine.Color val; // 0x10
			public TweenCallback<UnityEngine.Color> onVirtualUpdate; // 0x20
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal UnityEngine.Color _Color_b__0(); // 0x0000000184430480-0x0000000184430490
			internal void _Color_b__1(UnityEngine.Color x); // 0x0000000187239680-0x0000000187239690
			internal void _Color_b__2(); // 0x0000000188C8AAC4-0x0000000188C8AAF8
		}
	
		// Methods
		public static Tweener Float(float from, float to, float duration, TweenCallback<float> onVirtualUpdate); // 0x0000000188C7E820-0x0000000188C7E9D4
		public static Tweener Int(int from, int to, float duration, TweenCallback<int> onVirtualUpdate); // 0x0000000188C7E9D4-0x0000000188C7EB78
		public static Tweener Vector3(Vector3 from, Vector3 to, float duration, TweenCallback<Vector3> onVirtualUpdate); // 0x0000000188C7EB78-0x0000000188C7ED40
		public static Tweener Color(UnityEngine.Color from, UnityEngine.Color to, float duration, TweenCallback<UnityEngine.Color> onVirtualUpdate); // 0x0000000188C7DDD4-0x0000000188C7DF8C
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType); // 0x0000000185094A10-0x0000000185094AE0
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float overshoot); // 0x0000000188C7E3E0-0x0000000188C7E494
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float amplitude, float period); // 0x0000000188C7E7B8-0x0000000188C7E820
		public static float EasedValue(float from, float to, float lifetimePercentage, AnimationCurve easeCurve); // 0x0000000188C7E158-0x0000000188C7E294
		public static Vector3 EasedValue(Vector3 from, Vector3 to, float lifetimePercentage, Ease easeType); // 0x0000000188C7E66C-0x0000000188C7E7B8
		public static Vector3 EasedValue(Vector3 from, Vector3 to, float lifetimePercentage, Ease easeType, float overshoot); // 0x0000000188C7E294-0x0000000188C7E3E0
		public static Vector3 EasedValue(Vector3 from, Vector3 to, float lifetimePercentage, Ease easeType, float amplitude, float period); // 0x0000000188C7E04C-0x0000000188C7E158
		public static Vector3 EasedValue(Vector3 from, Vector3 to, float lifetimePercentage, AnimationCurve easeCurve); // 0x0000000188C7E494-0x0000000188C7E66C
		public static DG.Tweening.Tween DelayedCall(float delay, TweenCallback callback, bool ignoreTimeScale = true /* Metadata: 0x026454E2 */); // 0x0000000188C7DF8C-0x0000000188C7E04C
	}

	public enum Ease // TypeDefIndex: 86385
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

	public class EaseFactory // TypeDefIndex: 86387
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 86386
		{
			// Fields
			public float motionDelay; // 0x10
			public EaseFunction customEase; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _StopMotion_b__0(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188C8A89C-0x0000000188C8A908
		}
	
		// Constructors
		public EaseFactory(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static EaseFunction StopMotion(int motionFps, Ease? ease = default); // 0x0000000188C7EE04-0x0000000188C7EEA0
		public static EaseFunction StopMotion(int motionFps, AnimationCurve animCurve); // 0x0000000188C7EEA0-0x0000000188C7EF58
		public static EaseFunction StopMotion(int motionFps, EaseFunction customEase); // 0x0000000188C7ED40-0x0000000188C7EE04
	}

	public interface IDOTweenInit // TypeDefIndex: 86388
	{
		// Methods
		IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity);
	}

	public enum LinkBehaviour // TypeDefIndex: 86389
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

	public enum PathMode // TypeDefIndex: 86390
	{
		Ignore = 0,
		Full3D = 1,
		TopDown2D = 2,
		Sidescroller2D = 3
	}

	public enum PathType // TypeDefIndex: 86391
	{
		Linear = 0,
		CatmullRom = 1,
		CubicBezier = 2
	}

	public enum RotateMode // TypeDefIndex: 86392
	{
		Fast = 0,
		FastBeyond360 = 1,
		WorldAxisAdd = 2,
		LocalAxisAdd = 3
	}

	public enum ScrambleMode // TypeDefIndex: 86393
	{
		None = 0,
		All = 1,
		Uppercase = 2,
		Lowercase = 3,
		Numerals = 4,
		Custom = 5
	}

	public enum ShakeRandomnessMode // TypeDefIndex: 86394
	{
		Full = 0,
		Harmonic = 1
	}

	public static class TweenExtensions // TypeDefIndex: 86395
	{
		// Methods
		private static void DoGoto(DG.Tweening.Tween t, float to, bool andPlay, bool withCallbacks); // 0x0000000185E208D0-0x0000000185E209F0
	
		// Extension methods
		public static void Complete(this DG.Tweening.Tween t); // 0x0000000188C87C5C-0x0000000188C87C68
		public static void Complete(this DG.Tweening.Tween t, bool withCallbacks); // 0x0000000188C87C68-0x0000000188C87D18
		public static void Flip(this DG.Tweening.Tween t); // 0x0000000188C87F60-0x0000000188C88004
		public static void ForceInit(this DG.Tweening.Tween t); // 0x0000000188C88004-0x0000000188C880AC
		public static void Goto(this DG.Tweening.Tween t, float to, bool andPlay = false /* Metadata: 0x02645527 */); // 0x0000000188C88340-0x0000000188C8835C
		public static void GotoWithCallbacks(this DG.Tweening.Tween t, float to, bool andPlay = false /* Metadata: 0x02645528 */); // 0x0000000188C88324-0x0000000188C88340
		public static void Kill(this DG.Tweening.Tween t, bool complete = false /* Metadata: 0x02645529 */); // 0x0000000185092F00-0x0000000185093080
		public static void ManualUpdate(this DG.Tweening.Tween t, float deltaTime, float unscaledDeltaTime); // 0x0000000188C8841C-0x0000000188C884E0
		public static T Pause<T>(this T t)
			where T : DG.Tweening.Tween;
		public static T Play<T>(this T t)
			where T : DG.Tweening.Tween;
		public static void PlayBackwards(this DG.Tweening.Tween t); // 0x0000000188C88864-0x0000000188C88908
		public static void PlayForward(this DG.Tweening.Tween t); // 0x0000000188C88908-0x0000000188C889AC
		public static void Restart(this DG.Tweening.Tween t, bool includeDelay = true /* Metadata: 0x0264552A */, float changeDelayTo = -1f /* Metadata: 0x0264552B */); // 0x000000018519A2E0-0x000000018519A360
		public static void Rewind(this DG.Tweening.Tween t, bool includeDelay = true /* Metadata: 0x0264552F */); // 0x0000000188C889AC-0x0000000188C88A58
		public static void SmoothRewind(this DG.Tweening.Tween t); // 0x0000000188C88A58-0x0000000188C88AFC
		public static void TogglePause(this DG.Tweening.Tween t); // 0x0000000188C88AFC-0x0000000188C88BA0
		public static void GotoWaypoint(this DG.Tweening.Tween t, int waypointIndex, bool andPlay = false /* Metadata: 0x02645530 */); // 0x0000000188C880AC-0x0000000188C88324
		public static YieldInstruction WaitForCompletion(this DG.Tweening.Tween t); // 0x0000000188C88BA0-0x0000000188C88C40
		public static YieldInstruction WaitForRewind(this DG.Tweening.Tween t); // 0x0000000188C88E40-0x0000000188C88EE0
		public static YieldInstruction WaitForKill(this DG.Tweening.Tween t); // 0x0000000188C88CF0-0x0000000188C88D90
		public static YieldInstruction WaitForElapsedLoops(this DG.Tweening.Tween t, int elapsedLoops); // 0x0000000188C88C40-0x0000000188C88CF0
		public static YieldInstruction WaitForPosition(this DG.Tweening.Tween t, float position); // 0x0000000188C88D90-0x0000000188C88E40
		public static Coroutine WaitForStart(this DG.Tweening.Tween t); // 0x0000000188C88EE0-0x0000000188C88F80
		public static int CompletedLoops(this DG.Tweening.Tween t); // 0x0000000188C87D18-0x0000000188C87D58
		public static float Delay(this DG.Tweening.Tween t); // 0x0000000188C87D58-0x0000000188C87D9C
		public static float ElapsedDelay(this DG.Tweening.Tween t); // 0x0000000188C87E0C-0x0000000188C87E50
		public static float Duration(this DG.Tweening.Tween t, bool includeLoops = true /* Metadata: 0x02645531 */); // 0x0000000188C87D9C-0x0000000188C87E0C
		public static float Elapsed(this DG.Tweening.Tween t, bool includeLoops = true /* Metadata: 0x02645532 */); // 0x0000000188C87EF0-0x0000000188C87F60
		public static float ElapsedPercentage(this DG.Tweening.Tween t, bool includeLoops = true /* Metadata: 0x02645533 */); // 0x0000000185E82660-0x0000000185E826E0
		public static float ElapsedDirectionalPercentage(this DG.Tweening.Tween t); // 0x0000000188C87E50-0x0000000188C87EF0
		public static bool IsActive(this DG.Tweening.Tween t); // 0x0000000185198FA0-0x0000000185198FB0
		public static bool IsBackwards(this DG.Tweening.Tween t); // 0x0000000188C8835C-0x0000000188C8839C
		public static bool IsComplete(this DG.Tweening.Tween t); // 0x0000000185198FB0-0x0000000185198FE0
		public static bool IsInitialized(this DG.Tweening.Tween t); // 0x0000000188C8839C-0x0000000188C883DC
		public static bool IsPlaying(this DG.Tweening.Tween t); // 0x000000018519A2B0-0x000000018519A2E0
		public static int Loops(this DG.Tweening.Tween t); // 0x0000000188C883DC-0x0000000188C8841C
		public static Vector3 PathGetPoint(this DG.Tweening.Tween t, float pathPercentage); // 0x0000000188C885F0-0x0000000188C8875C
		public static Vector3[] PathGetDrawPoints(this DG.Tweening.Tween t, int subdivisionsXSegment = 10 /* Metadata: 0x02645534 */); // 0x0000000188C884E0-0x0000000188C885F0
		public static float PathLength(this DG.Tweening.Tween t); // 0x0000000188C8875C-0x0000000188C88864
	}

	public enum LoopType // TypeDefIndex: 86396
	{
		Restart = 0,
		Yoyo = 1,
		Incremental = 2
	}

	public sealed class Sequence : DG.Tweening.Tween // TypeDefIndex: 86397
	{
		// Fields
		internal readonly List<DG.Tweening.Tween> sequencedTweens; // 0x120
		private readonly List<ABSSequentiable> _sequencedObjs; // 0x128
		internal float lastTweenInsertTime; // 0x130
	
		// Constructors
		internal Sequence(); // 0x0000000185C894D0-0x0000000185C895A0
	
		// Methods
		internal static Sequence DoPrepend(Sequence inSequence, DG.Tweening.Tween t); // 0x0000000188C7F0E8-0x0000000188C7F224
		internal static Sequence DoInsert(Sequence inSequence, DG.Tweening.Tween t, float atPosition); // 0x0000000185C89720-0x0000000185C89870
		internal static Sequence DoAppendInterval(Sequence inSequence, float interval); // 0x0000000185C88AD0-0x0000000185C88B10
		internal static Sequence DoPrependInterval(Sequence inSequence, float interval); // 0x0000000188C7F00C-0x0000000188C7F0E8
		internal static Sequence DoInsertCallback(Sequence inSequence, TweenCallback callback, float atPosition); // 0x00000001869E6400-0x00000001869E64D0
		internal override float UpdateDelay(float elapsed); // 0x0000000188C7F224-0x0000000188C7F254
		internal override void Reset(); // 0x0000000185E0F140-0x0000000185E0F1A0
		internal override bool Validate(); // 0x0000000188C7F254-0x0000000188C7F2F8
		internal override bool Startup(); // 0x0000000185E209F0-0x0000000185E20A00
		internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, UpdateNotice updateNotice); // 0x0000000185E20C10-0x0000000185E20C30
		internal static void Setup(Sequence s); // 0x0000000185C895A0-0x0000000185C896B0
		internal static bool DoStartup(Sequence s); // 0x0000000185E20A00-0x0000000185E20AF0
		internal static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode); // 0x0000000185E20C30-0x0000000185E20F50
		private static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, DG.Tweening.Core.Enums.UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = false /* Metadata: 0x02645538 */); // 0x0000000185E20F50-0x0000000185E21330
		private static void StableSortSequencedObjs(List<ABSSequentiable> list); // 0x0000000185E20AF0-0x0000000185E20BB0
		private static bool IsAnyCallbackSet(Sequence s); // 0x0000000185E20BB0-0x0000000185E20C10
	}

	public static class ShortcutExtensions // TypeDefIndex: 86474
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 86398
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _DOAspect_b__0(); // 0x0000000188C8A174-0x0000000188C8A194
			internal void _DOAspect_b__1(float x); // 0x0000000188C8A194-0x0000000188C8A1B4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 86399
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal UnityEngine.Color _DOColor_b__0(); // 0x0000000188C8A510-0x0000000188C8A544
			internal void _DOColor_b__1(UnityEngine.Color x); // 0x0000000188C8A544-0x0000000188C8A574
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 86400
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _DOFarClipPlane_b__0(); // 0x0000000188C8A85C-0x0000000188C8A87C
			internal void _DOFarClipPlane_b__1(float x); // 0x0000000188C8A87C-0x0000000188C8A89C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 86401
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _DOFieldOfView_b__0(); // 0x0000000188C8AAF8-0x0000000188C8AB18
			internal void _DOFieldOfView_b__1(float x); // 0x0000000188C8AB18-0x0000000188C8AB38
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 86402
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _DONearClipPlane_b__0(); // 0x0000000188C8AC74-0x0000000188C8AC94
			internal void _DONearClipPlane_b__1(float x); // 0x0000000188C8AC94-0x0000000188C8ACB4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 86403
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _DOOrthoSize_b__0(); // 0x0000000188C8AD44-0x0000000188C8AD64
			internal void _DOOrthoSize_b__1(float x); // 0x0000000188C8AD64-0x0000000188C8AD84
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 86404
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Rect _DOPixelRect_b__0(); // 0x0000000188C8B138-0x0000000188C8B16C
			internal void _DOPixelRect_b__1(Rect x); // 0x0000000188C8B16C-0x0000000188C8B19C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 86405
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Rect _DORect_b__0(); // 0x0000000188C8B964-0x0000000188C8B998
			internal void _DORect_b__1(Rect x); // 0x0000000188C8B998-0x0000000188C8B9C8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 86406
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOShakePosition_b__0(); // 0x0000000188C8B9C8-0x0000000188C8BA14
			internal void _DOShakePosition_b__1(Vector3 x); // 0x0000000188C8BA14-0x0000000188C8BA60
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 86407
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOShakePosition_b__0(); // 0x0000000188C8B9C8-0x0000000188C8BA14
			internal void _DOShakePosition_b__1(Vector3 x); // 0x0000000188C8BA14-0x0000000188C8BA60
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 86408
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOShakeRotation_b__0(); // 0x0000000188C8A1E0-0x0000000188C8A22C
			internal void _DOShakeRotation_b__1(Vector3 x); // 0x0000000188C8A22C-0x0000000188C8A2A4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 86409
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOShakeRotation_b__0(); // 0x0000000188C8A1E0-0x0000000188C8A22C
			internal void _DOShakeRotation_b__1(Vector3 x); // 0x0000000188C8A22C-0x0000000188C8A2A4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 86410
		{
			// Fields
			public Light target; // 0x10
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal UnityEngine.Color _DOColor_b__0(); // 0x0000000188C8A2A4-0x0000000188C8A2D8
			internal void _DOColor_b__1(UnityEngine.Color x); // 0x0000000188C8A2D8-0x0000000188C8A308
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 86411
		{
			// Fields
			public Light target; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _DOIntensity_b__0(); // 0x0000000188C8A308-0x0000000188C8A328
			internal void _DOIntensity_b__1(float x); // 0x0000000188C8A328-0x0000000188C8A348
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 86412
		{
			// Fields
			public Light target; // 0x10
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _DOShadowStrength_b__0(); // 0x0000000188C8A348-0x0000000188C8A368
			internal void _DOShadowStrength_b__1(float x); // 0x0000000188C8A368-0x0000000188C8A388
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 86413
		{
			// Fields
			public Color2 startValue; // 0x10
			public LineRenderer target; // 0x30
	
			// Constructors
			public __c__DisplayClass15_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Color2 _DOColor_b__0(); // 0x00000001844327F0-0x0000000184432810
			internal void _DOColor_b__1(Color2 x); // 0x0000000188C8A388-0x0000000188C8A3C4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 86414
		{
			// Fields
			public Material target; // 0x10
	
			// Constructors
			public __c__DisplayClass16_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal UnityEngine.Color _DOColor_b__0(); // 0x0000000188C8A3C4-0x0000000188C8A3F8
			internal void _DOColor_b__1(UnityEngine.Color x); // 0x0000000188C8A3F8-0x0000000188C8A428
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 86415
		{
			// Fields
			public Material target; // 0x10
			public string property; // 0x18
	
			// Constructors
			public __c__DisplayClass17_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal UnityEngine.Color _DOColor_b__0(); // 0x0000000188C8A428-0x0000000188C8A464
			internal void _DOColor_b__1(UnityEngine.Color x); // 0x0000000188C8A464-0x0000000188C8A49C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0 // TypeDefIndex: 86416
		{
			// Fields
			public Material target; // 0x10
			public int propertyID; // 0x18
	
			// Constructors
			public __c__DisplayClass18_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal UnityEngine.Color _DOColor_b__0(); // 0x0000000188C8A49C-0x0000000188C8A4D8
			internal void _DOColor_b__1(UnityEngine.Color x); // 0x0000000188C8A4D8-0x0000000188C8A510
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 86417
		{
			// Fields
			public Material target; // 0x10
	
			// Constructors
			public __c__DisplayClass19_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal UnityEngine.Color _DOFade_b__0(); // 0x0000000188C8A3C4-0x0000000188C8A3F8
			internal void _DOFade_b__1(UnityEngine.Color x); // 0x0000000188C8A3F8-0x0000000188C8A428
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 86418
		{
			// Fields
			public Material target; // 0x10
			public string property; // 0x18
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal UnityEngine.Color _DOFade_b__0(); // 0x0000000188C8A428-0x0000000188C8A464
			internal void _DOFade_b__1(UnityEngine.Color x); // 0x0000000188C8A464-0x0000000188C8A49C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 86419
		{
			// Fields
			public Material target; // 0x10
			public int propertyID; // 0x18
	
			// Constructors
			public __c__DisplayClass21_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal UnityEngine.Color _DOFade_b__0(); // 0x0000000188C8A49C-0x0000000188C8A4D8
			internal void _DOFade_b__1(UnityEngine.Color x); // 0x0000000188C8A4D8-0x0000000188C8A510
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0 // TypeDefIndex: 86420
		{
			// Fields
			public Material target; // 0x10
			public string property; // 0x18
	
			// Constructors
			public __c__DisplayClass22_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _DOFloat_b__0(); // 0x0000000188C8A5A0-0x0000000188C8A5C8
			internal void _DOFloat_b__1(float x); // 0x0000000188C8A5C8-0x0000000188C8A5F4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0 // TypeDefIndex: 86421
		{
			// Fields
			public Material target; // 0x10
			public int propertyID; // 0x18
	
			// Constructors
			public __c__DisplayClass23_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _DOFloat_b__0(); // 0x0000000188C8A5F4-0x0000000188C8A61C
			internal void _DOFloat_b__1(float x); // 0x0000000188C8A61C-0x0000000188C8A644
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 86422
		{
			// Fields
			public Material target; // 0x10
	
			// Constructors
			public __c__DisplayClass24_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector2 _DOOffset_b__0(); // 0x0000000188C8A644-0x0000000188C8A664
			internal void _DOOffset_b__1(Vector2 x); // 0x0000000188C8A664-0x0000000188C8A684
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 86423
		{
			// Fields
			public Material target; // 0x10
			public string property; // 0x18
	
			// Constructors
			public __c__DisplayClass25_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector2 _DOOffset_b__0(); // 0x0000000188C8A684-0x0000000188C8A6AC
			internal void _DOOffset_b__1(Vector2 x); // 0x0000000188C8A6AC-0x0000000188C8A6DC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0 // TypeDefIndex: 86424
		{
			// Fields
			public Material target; // 0x10
	
			// Constructors
			public __c__DisplayClass26_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector2 _DOTiling_b__0(); // 0x0000000188C8A6DC-0x0000000188C8A6FC
			internal void _DOTiling_b__1(Vector2 x); // 0x0000000188C8A6FC-0x0000000188C8A71C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0 // TypeDefIndex: 86425
		{
			// Fields
			public Material target; // 0x10
			public string property; // 0x18
	
			// Constructors
			public __c__DisplayClass27_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector2 _DOTiling_b__0(); // 0x0000000188C8A71C-0x0000000188C8A744
			internal void _DOTiling_b__1(Vector2 x); // 0x0000000188C8A744-0x0000000188C8A774
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0 // TypeDefIndex: 86426
		{
			// Fields
			public Material target; // 0x10
			public string property; // 0x18
	
			// Constructors
			public __c__DisplayClass28_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector4 _DOVector_b__0(); // 0x0000000188C8A774-0x0000000188C8A7B0
			internal void _DOVector_b__1(Vector4 x); // 0x0000000188C8A7B0-0x0000000188C8A7E8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0 // TypeDefIndex: 86427
		{
			// Fields
			public Material target; // 0x10
			public int propertyID; // 0x18
	
			// Constructors
			public __c__DisplayClass29_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector4 _DOVector_b__0(); // 0x0000000188C8A7E8-0x0000000188C8A824
			internal void _DOVector_b__1(Vector4 x); // 0x0000000188C8A824-0x0000000188C8A85C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0 // TypeDefIndex: 86428
		{
			// Fields
			public TrailRenderer target; // 0x10
	
			// Constructors
			public __c__DisplayClass30_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector2 _DOResize_b__0(); // 0x0000000188C8A944-0x0000000188C8A990
			internal void _DOResize_b__1(Vector2 x); // 0x0000000188C8A990-0x0000000188C8A9D8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 86429
		{
			// Fields
			public TrailRenderer target; // 0x10
	
			// Constructors
			public __c__DisplayClass31_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _DOTime_b__0(); // 0x0000000188C8A9D8-0x0000000188C8A9F8
			internal void _DOTime_b__1(float x); // 0x0000000188C8A9F8-0x0000000188C8AA18
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0 // TypeDefIndex: 86430
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass32_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOMove_b__0(); // 0x0000000188C8AA18-0x0000000188C8AA54
			internal void _DOMove_b__1(Vector3 x); // 0x0000000188C8AA54-0x0000000188C8AA8C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 86431
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass33_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOMoveX_b__0(); // 0x0000000188C8AA18-0x0000000188C8AA54
			internal void _DOMoveX_b__1(Vector3 x); // 0x0000000188C8AA54-0x0000000188C8AA8C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0 // TypeDefIndex: 86432
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass34_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOMoveY_b__0(); // 0x0000000188C8AA18-0x0000000188C8AA54
			internal void _DOMoveY_b__1(Vector3 x); // 0x0000000188C8AA54-0x0000000188C8AA8C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0 // TypeDefIndex: 86433
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass35_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOMoveZ_b__0(); // 0x0000000188C8AA18-0x0000000188C8AA54
			internal void _DOMoveZ_b__1(Vector3 x); // 0x0000000188C8AA54-0x0000000188C8AA8C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_0 // TypeDefIndex: 86434
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass36_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOLocalMove_b__0(); // 0x000000018691C000-0x000000018691C040
			internal void _DOLocalMove_b__1(Vector3 x); // 0x0000000186E60520-0x0000000186E60580
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0 // TypeDefIndex: 86435
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass37_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOLocalMoveX_b__0(); // 0x000000018691C000-0x000000018691C040
			internal void _DOLocalMoveX_b__1(Vector3 x); // 0x0000000188C8AA8C-0x0000000188C8AAC4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0 // TypeDefIndex: 86436
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass38_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOLocalMoveY_b__0(); // 0x000000018691C000-0x000000018691C040
			internal void _DOLocalMoveY_b__1(Vector3 x); // 0x0000000188C8AA8C-0x0000000188C8AAC4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_0 // TypeDefIndex: 86437
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass39_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOLocalMoveZ_b__0(); // 0x000000018691C000-0x000000018691C040
			internal void _DOLocalMoveZ_b__1(Vector3 x); // 0x0000000188C8AA8C-0x0000000188C8AAC4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0 // TypeDefIndex: 86438
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass40_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Quaternion _DORotate_b__0(); // 0x0000000188C8AB38-0x0000000188C8AB6C
			internal void _DORotate_b__1(Quaternion x); // 0x0000000188C8AB6C-0x0000000188C8AB9C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0 // TypeDefIndex: 86439
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass41_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Quaternion _DORotateQuaternion_b__0(); // 0x000000018647D810-0x000000018647D850
			internal void _DORotateQuaternion_b__1(Quaternion x); // 0x0000000185A59900-0x0000000185A59A20
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass42_0 // TypeDefIndex: 86440
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass42_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Quaternion _DOLocalRotate_b__0(); // 0x0000000188C8AB9C-0x0000000188C8ABD0
			internal void _DOLocalRotate_b__1(Quaternion x); // 0x0000000188C8ABD0-0x0000000188C8AC00
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0 // TypeDefIndex: 86441
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass43_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Quaternion _DOLocalRotateQuaternion_b__0(); // 0x000000018647D7B0-0x000000018647D810
			internal void _DOLocalRotateQuaternion_b__1(Quaternion x); // 0x000000018642DF30-0x000000018642E020
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0 // TypeDefIndex: 86442
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass44_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOScale_b__0(); // 0x000000018691BFC0-0x000000018691C000
			internal void _DOScale_b__1(Vector3 x); // 0x0000000186B55940-0x0000000186B559A0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0 // TypeDefIndex: 86443
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass45_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOScale_b__0(); // 0x0000000188C8AC00-0x0000000188C8AC3C
			internal void _DOScale_b__1(Vector3 x); // 0x0000000188C8AC3C-0x0000000188C8AC74
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0 // TypeDefIndex: 86444
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass46_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOScaleX_b__0(); // 0x0000000188C8AC00-0x0000000188C8AC3C
			internal void _DOScaleX_b__1(Vector3 x); // 0x0000000188C8AC3C-0x0000000188C8AC74
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass47_0 // TypeDefIndex: 86445
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass47_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOScaleY_b__0(); // 0x0000000188C8AC00-0x0000000188C8AC3C
			internal void _DOScaleY_b__1(Vector3 x); // 0x0000000188C8AC3C-0x0000000188C8AC74
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_0 // TypeDefIndex: 86446
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass48_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOScaleZ_b__0(); // 0x0000000188C8AC00-0x0000000188C8AC3C
			internal void _DOScaleZ_b__1(Vector3 x); // 0x0000000188C8AC3C-0x0000000188C8AC74
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass51_0 // TypeDefIndex: 86447
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass51_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Quaternion _LookAt_b__0(); // 0x0000000188C8AB38-0x0000000188C8AB6C
			internal void _LookAt_b__1(Quaternion x); // 0x0000000188C8AB6C-0x0000000188C8AB9C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0 // TypeDefIndex: 86448
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass52_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOPunchPosition_b__0(); // 0x000000018691C000-0x000000018691C040
			internal void _DOPunchPosition_b__1(Vector3 x); // 0x0000000188C8AA8C-0x0000000188C8AAC4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_0 // TypeDefIndex: 86449
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass53_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOPunchScale_b__0(); // 0x0000000188C8AC00-0x0000000188C8AC3C
			internal void _DOPunchScale_b__1(Vector3 x); // 0x0000000188C8AC3C-0x0000000188C8AC74
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_0 // TypeDefIndex: 86450
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass54_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOPunchRotation_b__0(); // 0x0000000188C8ACB4-0x0000000188C8ACF0
			internal void _DOPunchRotation_b__1(Vector3 x); // 0x0000000188C8ACF0-0x0000000188C8AD44
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass55_0 // TypeDefIndex: 86451
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass55_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOShakePosition_b__0(); // 0x000000018691C000-0x000000018691C040
			internal void _DOShakePosition_b__1(Vector3 x); // 0x0000000188C8AA8C-0x0000000188C8AAC4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass56_0 // TypeDefIndex: 86452
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass56_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOShakePosition_b__0(); // 0x000000018691C000-0x000000018691C040
			internal void _DOShakePosition_b__1(Vector3 x); // 0x0000000188C8AA8C-0x0000000188C8AAC4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass57_0 // TypeDefIndex: 86453
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass57_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOShakeRotation_b__0(); // 0x0000000188C8ACB4-0x0000000188C8ACF0
			internal void _DOShakeRotation_b__1(Vector3 x); // 0x0000000188C8ACF0-0x0000000188C8AD44
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0 // TypeDefIndex: 86454
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass58_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOShakeRotation_b__0(); // 0x0000000188C8ACB4-0x0000000188C8ACF0
			internal void _DOShakeRotation_b__1(Vector3 x); // 0x0000000188C8ACF0-0x0000000188C8AD44
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass59_0 // TypeDefIndex: 86455
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass59_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOShakeScale_b__0(); // 0x0000000188C8AC00-0x0000000188C8AC3C
			internal void _DOShakeScale_b__1(Vector3 x); // 0x0000000188C8AC3C-0x0000000188C8AC74
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass60_0 // TypeDefIndex: 86456
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass60_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOShakeScale_b__0(); // 0x0000000188C8AC00-0x0000000188C8AC3C
			internal void _DOShakeScale_b__1(Vector3 x); // 0x0000000188C8AC3C-0x0000000188C8AC74
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_0 // TypeDefIndex: 86457
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
			public __c__DisplayClass61_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOJump_b__0(); // 0x0000000188C8AA18-0x0000000188C8AA54
			internal void _DOJump_b__1(Vector3 x); // 0x0000000188C8AA54-0x0000000188C8AA8C
			internal void _DOJump_b__2(); // 0x0000000188C8AD84-0x0000000188C8ADB8
			internal Vector3 _DOJump_b__3(); // 0x0000000188C8AA18-0x0000000188C8AA54
			internal void _DOJump_b__4(Vector3 x); // 0x0000000188C8AA54-0x0000000188C8AA8C
			internal Vector3 _DOJump_b__5(); // 0x0000000188C8AA18-0x0000000188C8AA54
			internal void _DOJump_b__6(Vector3 x); // 0x0000000188C8AA54-0x0000000188C8AA8C
			internal void _DOJump_b__7(); // 0x0000000188C8ADB8-0x0000000188C8AE98
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_0 // TypeDefIndex: 86458
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
			public __c__DisplayClass62_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOLocalJump_b__0(); // 0x000000018691C000-0x000000018691C040
			internal void _DOLocalJump_b__1(Vector3 x); // 0x0000000188C8AA8C-0x0000000188C8AAC4
			internal void _DOLocalJump_b__2(); // 0x0000000188C8AE98-0x0000000188C8AECC
			internal Vector3 _DOLocalJump_b__3(); // 0x000000018691C000-0x000000018691C040
			internal void _DOLocalJump_b__4(Vector3 x); // 0x0000000188C8AA8C-0x0000000188C8AAC4
			internal Vector3 _DOLocalJump_b__5(); // 0x000000018691C000-0x000000018691C040
			internal void _DOLocalJump_b__6(Vector3 x); // 0x0000000188C8AA8C-0x0000000188C8AAC4
			internal void _DOLocalJump_b__7(); // 0x0000000188C8AECC-0x0000000188C8AFAC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass63_0 // TypeDefIndex: 86459
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass63_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOPath_b__0(); // 0x0000000188C8AA18-0x0000000188C8AA54
			internal void _DOPath_b__1(Vector3 x); // 0x0000000188C8AA54-0x0000000188C8AA8C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass64_0 // TypeDefIndex: 86460
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass64_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOLocalPath_b__0(); // 0x000000018691C000-0x000000018691C040
			internal void _DOLocalPath_b__1(Vector3 x); // 0x0000000188C8AA8C-0x0000000188C8AAC4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass65_0 // TypeDefIndex: 86461
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass65_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOPath_b__0(); // 0x0000000188C8AA18-0x0000000188C8AA54
			internal void _DOPath_b__1(Vector3 x); // 0x0000000188C8AA54-0x0000000188C8AA8C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass66_0 // TypeDefIndex: 86462
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass66_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOLocalPath_b__0(); // 0x000000018691C000-0x000000018691C040
			internal void _DOLocalPath_b__1(Vector3 x); // 0x0000000188C8AA8C-0x0000000188C8AAC4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass67_0 // TypeDefIndex: 86463
		{
			// Fields
			public DG.Tweening.Tween target; // 0x10
	
			// Constructors
			public __c__DisplayClass67_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _DOTimeScale_b__0(); // 0x0000000188C8AFAC-0x0000000188C8AFCC
			internal void _DOTimeScale_b__1(float x); // 0x0000000187835430-0x0000000187835450
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass68_0 // TypeDefIndex: 86464
		{
			// Fields
			public UnityEngine.Color to; // 0x10
			public Light target; // 0x20
	
			// Constructors
			public __c__DisplayClass68_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal UnityEngine.Color _DOBlendableColor_b__0(); // 0x0000000184430480-0x0000000184430490
			internal void _DOBlendableColor_b__1(UnityEngine.Color x); // 0x0000000188C8AFF0-0x0000000188C8B094
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass69_0 // TypeDefIndex: 86465
		{
			// Fields
			public UnityEngine.Color to; // 0x10
			public Material target; // 0x20
	
			// Constructors
			public __c__DisplayClass69_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal UnityEngine.Color _DOBlendableColor_b__0(); // 0x0000000184430480-0x0000000184430490
			internal void _DOBlendableColor_b__1(UnityEngine.Color x); // 0x0000000188C8B094-0x0000000188C8B138
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass70_0 // TypeDefIndex: 86466
		{
			// Fields
			public UnityEngine.Color to; // 0x10
			public Material target; // 0x20
			public string property; // 0x28
	
			// Constructors
			public __c__DisplayClass70_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal UnityEngine.Color _DOBlendableColor_b__0(); // 0x0000000184430480-0x0000000184430490
			internal void _DOBlendableColor_b__1(UnityEngine.Color x); // 0x0000000188C8B19C-0x0000000188C8B254
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass71_0 // TypeDefIndex: 86467
		{
			// Fields
			public UnityEngine.Color to; // 0x10
			public Material target; // 0x20
			public int propertyID; // 0x28
	
			// Constructors
			public __c__DisplayClass71_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal UnityEngine.Color _DOBlendableColor_b__0(); // 0x0000000184430480-0x0000000184430490
			internal void _DOBlendableColor_b__1(UnityEngine.Color x); // 0x0000000188C8B254-0x0000000188C8B308
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass72_0 // TypeDefIndex: 86468
		{
			// Fields
			public Vector3 to; // 0x10
			public Transform target; // 0x20
	
			// Constructors
			public __c__DisplayClass72_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOBlendableMoveBy_b__0(); // 0x0000000184432B70-0x0000000184432B90
			internal void _DOBlendableMoveBy_b__1(Vector3 x); // 0x0000000188C8B308-0x0000000188C8B3D4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_0 // TypeDefIndex: 86469
		{
			// Fields
			public Vector3 to; // 0x10
			public Transform target; // 0x20
	
			// Constructors
			public __c__DisplayClass73_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOBlendableLocalMoveBy_b__0(); // 0x0000000184432B70-0x0000000184432B90
			internal void _DOBlendableLocalMoveBy_b__1(Vector3 x); // 0x0000000188C8B3D4-0x0000000188C8B4A0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass74_0 // TypeDefIndex: 86470
		{
			// Fields
			public Quaternion to; // 0x10
			public Transform target; // 0x20
	
			// Constructors
			public __c__DisplayClass74_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Quaternion _DOBlendableRotateBy_b__0(); // 0x0000000184430480-0x0000000184430490
			internal void _DOBlendableRotateBy_b__1(Quaternion x); // 0x0000000188C8B4A0-0x0000000188C8B5E0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass75_0 // TypeDefIndex: 86471
		{
			// Fields
			public Quaternion to; // 0x10
			public Transform target; // 0x20
	
			// Constructors
			public __c__DisplayClass75_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Quaternion _DOBlendableLocalRotateBy_b__0(); // 0x0000000184430480-0x0000000184430490
			internal void _DOBlendableLocalRotateBy_b__1(Quaternion x); // 0x0000000188C8B5E0-0x0000000188C8B720
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_0 // TypeDefIndex: 86472
		{
			// Fields
			public Vector3 to; // 0x10
			public Transform target; // 0x20
	
			// Constructors
			public __c__DisplayClass76_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOBlendablePunchRotation_b__0(); // 0x0000000184432B70-0x0000000184432B90
			internal void _DOBlendablePunchRotation_b__1(Vector3 v); // 0x0000000188C8B720-0x0000000188C8B898
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass77_0 // TypeDefIndex: 86473
		{
			// Fields
			public Vector3 to; // 0x10
			public Transform target; // 0x20
	
			// Constructors
			public __c__DisplayClass77_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOBlendableScaleBy_b__0(); // 0x0000000184432B70-0x0000000184432B90
			internal void _DOBlendableScaleBy_b__1(Vector3 x); // 0x0000000188C8B898-0x0000000188C8B964
		}
	
		// Extension methods
		public static TweenerCore<float, float, FloatOptions> DOAspect(this Camera target, float endValue, float duration); // 0x0000000188C7F2F8-0x0000000188C7F458
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(this Camera target, UnityEngine.Color endValue, float duration); // 0x0000000188C80CDC-0x0000000188C80E48
		public static TweenerCore<float, float, FloatOptions> DOFarClipPlane(this Camera target, float endValue, float duration); // 0x0000000188C815B0-0x0000000188C81710
		public static TweenerCore<float, float, FloatOptions> DOFieldOfView(this Camera target, float endValue, float duration); // 0x0000000188C81710-0x0000000188C81870
		public static TweenerCore<float, float, FloatOptions> DONearClipPlane(this Camera target, float endValue, float duration); // 0x0000000188C83A50-0x0000000188C83BB0
		public static TweenerCore<float, float, FloatOptions> DOOrthoSize(this Camera target, float endValue, float duration); // 0x0000000188C83EC4-0x0000000188C84024
		public static TweenerCore<Rect, Rect, RectOptions> DOPixelRect(this Camera target, Rect endValue, float duration); // 0x0000000188C84468-0x0000000188C845D4
		public static TweenerCore<Rect, Rect, RectOptions> DORect(this Camera target, Rect endValue, float duration); // 0x0000000188C84D4C-0x0000000188C84EB8
		public static Tweener DOShakePosition(this Camera target, float duration, float strength = 3f /* Metadata: 0x02645539 */, int vibrato = 10 /* Metadata: 0x0264553D */, float randomness = 90f /* Metadata: 0x0264553E */, bool fadeOut = true /* Metadata: 0x02645542 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x02645543 */); // 0x0000000188C85CF4-0x0000000188C85EF8
		public static Tweener DOShakePosition(this Camera target, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x02645544 */, float randomness = 90f /* Metadata: 0x02645545 */, bool fadeOut = true /* Metadata: 0x02645549 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0264554A */); // 0x0000000188C86110-0x0000000188C86324
		public static Tweener DOShakeRotation(this Camera target, float duration, float strength = 90f /* Metadata: 0x0264554B */, int vibrato = 10 /* Metadata: 0x0264554F */, float randomness = 90f /* Metadata: 0x02645550 */, bool fadeOut = true /* Metadata: 0x02645554 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x02645555 */); // 0x0000000188C86950-0x0000000188C86B54
		public static Tweener DOShakeRotation(this Camera target, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x02645556 */, float randomness = 90f /* Metadata: 0x02645557 */, bool fadeOut = true /* Metadata: 0x0264555B */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0264555C */); // 0x0000000188C86324-0x0000000188C86538
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(this Light target, UnityEngine.Color endValue, float duration); // 0x0000000188C80B70-0x0000000188C80CDC
		public static TweenerCore<float, float, FloatOptions> DOIntensity(this Light target, float endValue, float duration); // 0x0000000188C81D14-0x0000000188C81E74
		public static TweenerCore<float, float, FloatOptions> DOShadowStrength(this Light target, float endValue, float duration); // 0x0000000188C8596C-0x0000000188C85ACC
		public static Tweener DOColor(this LineRenderer target, Color2 startValue, Color2 endValue, float duration); // 0x0000000188C806D8-0x0000000188C80858
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(this Material target, UnityEngine.Color endValue, float duration); // 0x0000000188C80858-0x0000000188C809C4
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(this Material target, UnityEngine.Color endValue, string property, float duration); // 0x0000000188C80E48-0x0000000188C81000
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(this Material target, UnityEngine.Color endValue, int propertyID, float duration); // 0x0000000188C809C4-0x0000000188C80B70
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOFade(this Material target, float endValue, float duration); // 0x0000000188C81104-0x0000000188C81264
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOFade(this Material target, float endValue, string property, float duration); // 0x0000000188C81404-0x0000000188C815B0
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOFade(this Material target, float endValue, int propertyID, float duration); // 0x0000000188C81264-0x0000000188C81404
		public static TweenerCore<float, float, FloatOptions> DOFloat(this Material target, float endValue, string property, float duration); // 0x0000000188C81AA8-0x0000000188C81C54
		public static TweenerCore<float, float, FloatOptions> DOFloat(this Material target, float endValue, int propertyID, float duration); // 0x0000000188C81908-0x0000000188C81AA8
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, float duration); // 0x0000000188C83BB0-0x0000000188C83D14
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, string property, float duration); // 0x0000000188C83D14-0x0000000188C83EC4
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, float duration); // 0x0000000188C8704C-0x0000000188C871B0
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, string property, float duration); // 0x0000000188C871B0-0x0000000188C87360
		public static TweenerCore<Vector4, Vector4, VectorOptions> DOVector(this Material target, Vector4 endValue, string property, float duration); // 0x0000000188C87864-0x0000000188C87A1C
		public static TweenerCore<Vector4, Vector4, VectorOptions> DOVector(this Material target, Vector4 endValue, int propertyID, float duration); // 0x0000000188C876B8-0x0000000188C87864
		public static Tweener DOResize(this TrailRenderer target, float toStartWidth, float toEndWidth, float duration); // 0x0000000188C84EB8-0x0000000188C85028
		public static TweenerCore<float, float, FloatOptions> DOTime(this TrailRenderer target, float endValue, float duration); // 0x0000000188C874C0-0x0000000188C87620
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Transform target, Vector3 endValue, float duration, bool snapping = false /* Metadata: 0x0264555D */); // 0x0000000188C838BC-0x0000000188C83A50
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x0264555E */); // 0x0000000188C833C8-0x0000000188C8356C
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x0264555F */); // 0x0000000188C8356C-0x0000000188C83714
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x02645560 */); // 0x0000000188C83714-0x0000000188C838BC
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMove(this Transform target, Vector3 endValue, float duration, bool snapping = false /* Metadata: 0x02645561 */); // 0x0000000185FBA3C0-0x0000000185FBA560
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveX(this Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x02645562 */); // 0x0000000188C82938-0x0000000188C82ADC
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveY(this Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x02645563 */); // 0x0000000188C82ADC-0x0000000188C82C84
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveZ(this Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x02645564 */); // 0x0000000188C82C84-0x0000000188C82E2C
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Transform target, Vector3 endValue, float duration, DG.Tweening.RotateMode mode = DG.Tweening.RotateMode.Fast /* Metadata: 0x02645565 */); // 0x0000000188C85190-0x0000000188C85324
		public static TweenerCore<Quaternion, Quaternion, NoOptions> DORotateQuaternion(this Transform target, Quaternion endValue, float duration); // 0x0000000185A5B360-0x0000000185A5B520
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLocalRotate(this Transform target, Vector3 endValue, float duration, DG.Tweening.RotateMode mode = DG.Tweening.RotateMode.Fast /* Metadata: 0x02645566 */); // 0x0000000188C831E8-0x0000000188C8337C
		public static TweenerCore<Quaternion, Quaternion, NoOptions> DOLocalRotateQuaternion(this Transform target, Quaternion endValue, float duration); // 0x0000000185A5B520-0x0000000185A5B6E0
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(this Transform target, Vector3 endValue, float duration); // 0x0000000185FBBAF0-0x0000000185FBBC90
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(this Transform target, float endValue, float duration); // 0x0000000188C857F4-0x0000000188C8596C
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleX(this Transform target, float endValue, float duration); // 0x0000000188C85324-0x0000000188C854BC
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleY(this Transform target, float endValue, float duration); // 0x0000000188C854BC-0x0000000188C85658
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleZ(this Transform target, float endValue, float duration); // 0x0000000188C85658-0x0000000188C857F4
		public static Tweener DOLookAt(this Transform target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None /* Metadata: 0x02645567 */, Vector3? up = default); // 0x0000000188C8337C-0x0000000188C833C8
		public static Tweener DODynamicLookAt(this Transform target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None /* Metadata: 0x02645568 */, Vector3? up = default); // 0x0000000188C810B8-0x0000000188C81104
		private static Tweener LookAt(this Transform target, Vector3 towards, float duration, AxisConstraint axisConstraint, Vector3? up, bool dynamic); // 0x0000000188C87A1C-0x0000000188C87C5C
		public static Tweener DOPunchPosition(this Transform target, Vector3 punch, float duration, int vibrato = 10 /* Metadata: 0x02645569 */, float elasticity = 1f /* Metadata: 0x0264556A */, bool snapping = false /* Metadata: 0x0264556E */); // 0x0000000188C8479C-0x0000000188C8498C
		public static Tweener DOPunchScale(this Transform target, Vector3 punch, float duration, int vibrato = 10 /* Metadata: 0x0264556F */, float elasticity = 1f /* Metadata: 0x02645570 */); // 0x0000000188C84B6C-0x0000000188C84D4C
		public static Tweener DOPunchRotation(this Transform target, Vector3 punch, float duration, int vibrato = 10 /* Metadata: 0x02645574 */, float elasticity = 1f /* Metadata: 0x02645575 */); // 0x0000000188C8498C-0x0000000188C84B6C
		public static Tweener DOShakePosition(this Transform target, float duration, float strength = 1f /* Metadata: 0x02645579 */, int vibrato = 10 /* Metadata: 0x0264557D */, float randomness = 90f /* Metadata: 0x0264557E */, bool snapping = false /* Metadata: 0x02645582 */, bool fadeOut = true /* Metadata: 0x02645583 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x02645584 */); // 0x0000000188C85EF8-0x0000000188C86110
		public static Tweener DOShakePosition(this Transform target, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x02645585 */, float randomness = 90f /* Metadata: 0x02645586 */, bool snapping = false /* Metadata: 0x0264558A */, bool fadeOut = true /* Metadata: 0x0264558B */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0264558C */); // 0x0000000188C85ACC-0x0000000188C85CF4
		public static Tweener DOShakeRotation(this Transform target, float duration, float strength = 90f /* Metadata: 0x0264558D */, int vibrato = 10 /* Metadata: 0x02645591 */, float randomness = 90f /* Metadata: 0x02645592 */, bool fadeOut = true /* Metadata: 0x02645596 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x02645597 */); // 0x0000000188C86538-0x0000000188C8673C
		public static Tweener DOShakeRotation(this Transform target, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x02645598 */, float randomness = 90f /* Metadata: 0x02645599 */, bool fadeOut = true /* Metadata: 0x0264559D */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0264559E */); // 0x0000000188C8673C-0x0000000188C86950
		public static Tweener DOShakeScale(this Transform target, float duration, float strength = 1f /* Metadata: 0x0264559F */, int vibrato = 10 /* Metadata: 0x026455A3 */, float randomness = 90f /* Metadata: 0x026455A4 */, bool fadeOut = true /* Metadata: 0x026455A8 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x026455A9 */); // 0x0000000188C86D68-0x0000000188C86FB4
		public static Tweener DOShakeScale(this Transform target, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x026455AA */, float randomness = 90f /* Metadata: 0x026455AB */, bool fadeOut = true /* Metadata: 0x026455AF */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x026455B0 */); // 0x0000000188C86B54-0x0000000188C86D68
		public static DG.Tweening.Sequence DOJump(this Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false /* Metadata: 0x026455B1 */); // 0x0000000188C81E74-0x0000000188C823A8
		public static DG.Tweening.Sequence DOLocalJump(this Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false /* Metadata: 0x026455B2 */); // 0x0000000188C82404-0x0000000188C82938
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Transform target, Vector3[] path, float duration, PathType pathType = PathType.Linear /* Metadata: 0x026455B3 */, PathMode pathMode = PathMode.Full3D /* Metadata: 0x026455B4 */, int resolution = 10 /* Metadata: 0x026455B5 */, UnityEngine.Color? gizmoColor = default); // 0x0000000188C841B8-0x0000000188C843D0
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Transform target, Vector3[] path, float duration, PathType pathType = PathType.Linear /* Metadata: 0x026455B6 */, PathMode pathMode = PathMode.Full3D /* Metadata: 0x026455B7 */, int resolution = 10 /* Metadata: 0x026455B8 */, UnityEngine.Color? gizmoColor = default); // 0x0000000188C82E2C-0x0000000188C8304C
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Transform target, Path path, float duration, PathMode pathMode = PathMode.Full3D /* Metadata: 0x026455B9 */); // 0x0000000188C84024-0x0000000188C841B8
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Transform target, Path path, float duration, PathMode pathMode = PathMode.Full3D /* Metadata: 0x026455BA */); // 0x0000000188C8304C-0x0000000188C831E8
		public static TweenerCore<float, float, FloatOptions> DOTimeScale(this DG.Tweening.Tween target, float endValue, float duration); // 0x0000000188C87360-0x0000000188C874C0
		public static Tweener DOBlendableColor(this Light target, UnityEngine.Color endValue, float duration); // 0x0000000188C7F66C-0x0000000188C7F840
		public static Tweener DOBlendableColor(this Material target, UnityEngine.Color endValue, float duration); // 0x0000000188C7FA60-0x0000000188C7FC34
		public static Tweener DOBlendableColor(this Material target, UnityEngine.Color endValue, string property, float duration); // 0x0000000188C7F840-0x0000000188C7FA60
		public static Tweener DOBlendableColor(this Material target, UnityEngine.Color endValue, int propertyID, float duration); // 0x0000000188C7F458-0x0000000188C7F66C
		public static Tweener DOBlendableMoveBy(this Transform target, Vector3 byValue, float duration, bool snapping = false /* Metadata: 0x026455BB */); // 0x0000000188C7FFAC-0x0000000188C8016C
		public static Tweener DOBlendableLocalMoveBy(this Transform target, Vector3 byValue, float duration, bool snapping = false /* Metadata: 0x026455BC */); // 0x0000000188C7FC34-0x0000000188C7FDF4
		public static Tweener DOBlendableRotateBy(this Transform target, Vector3 byValue, float duration, DG.Tweening.RotateMode mode = DG.Tweening.RotateMode.Fast /* Metadata: 0x026455BD */); // 0x0000000188C8037C-0x0000000188C80534
		public static Tweener DOBlendableLocalRotateBy(this Transform target, Vector3 byValue, float duration, DG.Tweening.RotateMode mode = DG.Tweening.RotateMode.Fast /* Metadata: 0x026455BE */); // 0x0000000188C7FDF4-0x0000000188C7FFAC
		public static Tweener DOBlendablePunchRotation(this Transform target, Vector3 punch, float duration, int vibrato = 10 /* Metadata: 0x026455BF */, float elasticity = 1f /* Metadata: 0x026455C0 */); // 0x0000000188C8016C-0x0000000188C8037C
		public static Tweener DOBlendableScaleBy(this Transform target, Vector3 byValue, float duration); // 0x0000000188C80534-0x0000000188C806D8
		public static int DOComplete(this Component target, bool withCallbacks = false /* Metadata: 0x026455C4 */); // 0x0000000188C8105C-0x0000000188C810B8
		public static int DOComplete(this Material target, bool withCallbacks = false /* Metadata: 0x026455C5 */); // 0x0000000188C81000-0x0000000188C8105C
		public static int DOKill(this Component target, bool complete = false /* Metadata: 0x026455C6 */); // 0x00000001850933C0-0x0000000185093400
		public static int DOKill(this Material target, bool complete = false /* Metadata: 0x026455C7 */); // 0x0000000188C823A8-0x0000000188C82404
		public static int DOFlip(this Component target); // 0x0000000188C81870-0x0000000188C818BC
		public static int DOFlip(this Material target); // 0x0000000188C818BC-0x0000000188C81908
		public static int DOGoto(this Component target, float to, bool andPlay = false /* Metadata: 0x026455C8 */); // 0x0000000188C81CB4-0x0000000188C81D14
		public static int DOGoto(this Material target, float to, bool andPlay = false /* Metadata: 0x026455C9 */); // 0x0000000188C81C54-0x0000000188C81CB4
		public static int DOPause(this Component target); // 0x0000000188C843D0-0x0000000188C8441C
		public static int DOPause(this Material target); // 0x0000000188C8441C-0x0000000188C84468
		public static int DOPlay(this Component target); // 0x0000000188C84750-0x0000000188C8479C
		public static int DOPlay(this Material target); // 0x0000000188C84704-0x0000000188C84750
		public static int DOPlayBackwards(this Component target); // 0x0000000188C845D4-0x0000000188C84620
		public static int DOPlayBackwards(this Material target); // 0x0000000188C84620-0x0000000188C8466C
		public static int DOPlayForward(this Component target); // 0x0000000188C846B8-0x0000000188C84704
		public static int DOPlayForward(this Material target); // 0x0000000188C8466C-0x0000000188C846B8
		public static int DORestart(this Component target, bool includeDelay = true /* Metadata: 0x026455CA */); // 0x0000000188C85028-0x0000000188C85080
		public static int DORestart(this Material target, bool includeDelay = true /* Metadata: 0x026455CB */); // 0x0000000188C85080-0x0000000188C850D8
		public static int DORewind(this Component target, bool includeDelay = true /* Metadata: 0x026455CC */); // 0x0000000188C85134-0x0000000188C85190
		public static int DORewind(this Material target, bool includeDelay = true /* Metadata: 0x026455CD */); // 0x0000000188C850D8-0x0000000188C85134
		public static int DOSmoothRewind(this Component target); // 0x0000000188C86FB4-0x0000000188C87000
		public static int DOSmoothRewind(this Material target); // 0x0000000188C87000-0x0000000188C8704C
		public static int DOTogglePause(this Component target); // 0x0000000188C87620-0x0000000188C8766C
		public static int DOTogglePause(this Material target); // 0x0000000188C8766C-0x0000000188C876B8
	}

	public class TweenParams // TypeDefIndex: 86475
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
		public TweenParams(); // 0x0000000188C895A8-0x0000000188C895B8
		static TweenParams(); // 0x0000000188C89538-0x0000000188C895A8
	
		// Methods
		public TweenParams Clear(); // 0x0000000188C88F80-0x0000000188C89124
		public TweenParams SetAutoKill(bool autoKillOnCompletion = true /* Metadata: 0x026455CE */); // 0x0000000187239560-0x0000000187239570
		public TweenParams SetId(object objectId); // 0x0000000188C893FC-0x0000000188C89418
		public TweenParams SetId(string stringId); // 0x0000000188C89418-0x0000000188C89434
		public TweenParams SetId(int intId); // 0x0000000187239580-0x0000000187239590
		public TweenParams SetTarget(object target); // 0x0000000188C894BC-0x0000000188C894D8
		public TweenParams SetLoops(int loops, LoopType? loopType = default); // 0x0000000188C89434-0x0000000188C894BC
		public TweenParams SetEase(Ease ease, float? overshootOrAmplitude = default, float? period = default); // 0x0000000188C892D0-0x0000000188C893D0
		public TweenParams SetEase(AnimationCurve animCurve); // 0x0000000188C89204-0x0000000188C892D0
		public TweenParams SetEase(EaseFunction customEase); // 0x0000000188C893D0-0x0000000188C893FC
		public TweenParams SetRecyclable(bool recyclable = true /* Metadata: 0x026455CF */); // 0x0000000187239590-0x00000001872395A0
		public TweenParams SetUpdate(bool isIndependentUpdate); // 0x0000000188C894D8-0x0000000188C89538
		public TweenParams SetUpdate(DG.Tweening.UpdateType updateType, bool isIndependentUpdate = false /* Metadata: 0x026455D0 */); // 0x00000001872395C0-0x00000001872395D0
		public TweenParams OnStart(TweenCallback action); // 0x0000000188C89194-0x0000000188C891B0
		public TweenParams OnPlay(TweenCallback action); // 0x0000000188C8915C-0x0000000188C89178
		public TweenParams OnRewind(TweenCallback action); // 0x0000000188C89178-0x0000000188C89194
		public TweenParams OnUpdate(TweenCallback action); // 0x0000000188C891CC-0x0000000188C891E8
		public TweenParams OnStepComplete(TweenCallback action); // 0x0000000188C891B0-0x0000000188C891CC
		public TweenParams OnComplete(TweenCallback action); // 0x0000000188C89124-0x0000000188C89140
		public TweenParams OnKill(TweenCallback action); // 0x0000000188C89140-0x0000000188C8915C
		public TweenParams OnWaypointChange(TweenCallback<int> action); // 0x0000000188C891E8-0x0000000188C89204
		public TweenParams SetDelay(float delay); // 0x0000000187239570-0x0000000187239580
		public TweenParams SetRelative(bool isRelative = true /* Metadata: 0x026455D1 */); // 0x00000001872395A0-0x00000001872395B0
		public TweenParams SetSpeedBased(bool isSpeedBased = true /* Metadata: 0x026455D2 */); // 0x00000001872395B0-0x00000001872395C0
	}

	public static class TweenSettingsExtensions // TypeDefIndex: 86476
	{
		// Methods
		private static bool ValidateAddToSequence(DG.Tweening.Sequence s, DG.Tweening.Tween t, bool ignoreTween = false /* Metadata: 0x026455D3 */); // 0x0000000185C89910-0x0000000185C89970
	
		// Extension methods
		public static T SetAutoKill<T>(this T t)
			where T : DG.Tweening.Tween;
		public static T SetAutoKill<T>(this T t, bool autoKillOnCompletion)
			where T : DG.Tweening.Tween;
		public static T SetId<T>(this T t, object objectId)
			where T : DG.Tweening.Tween;
		public static T SetId<T>(this T t, string stringId)
			where T : DG.Tweening.Tween;
		public static T SetId<T>(this T t, int intId)
			where T : DG.Tweening.Tween;
		public static T SetLink<T>(this T t, GameObject gameObject)
			where T : DG.Tweening.Tween;
		public static T SetLink<T>(this T t, GameObject gameObject, LinkBehaviour behaviour)
			where T : DG.Tweening.Tween;
		public static T SetTarget<T>(this T t, object target)
			where T : DG.Tweening.Tween;
		public static T SetLoops<T>(this T t, int loops)
			where T : DG.Tweening.Tween;
		public static T SetLoops<T>(this T t, int loops, LoopType loopType)
			where T : DG.Tweening.Tween;
		public static T SetEase<T>(this T t, Ease ease)
			where T : DG.Tweening.Tween;
		public static T SetEase<T>(this T t, Ease ease, float overshoot)
			where T : DG.Tweening.Tween;
		public static T SetEase<T>(this T t, Ease ease, float amplitude, float period)
			where T : DG.Tweening.Tween;
		public static T SetEase<T>(this T t, AnimationCurve animCurve)
			where T : DG.Tweening.Tween;
		public static T SetEase<T>(this T t, EaseFunction customEase)
			where T : DG.Tweening.Tween;
		public static T SetRecyclable<T>(this T t)
			where T : DG.Tweening.Tween;
		public static T SetRecyclable<T>(this T t, bool recyclable)
			where T : DG.Tweening.Tween;
		public static T SetUpdate<T>(this T t, bool isIndependentUpdate)
			where T : DG.Tweening.Tween;
		public static T SetUpdate<T>(this T t, DG.Tweening.UpdateType updateType)
			where T : DG.Tweening.Tween;
		public static T SetUpdate<T>(this T t, DG.Tweening.UpdateType updateType, bool isIndependentUpdate)
			where T : DG.Tweening.Tween;
		public static T SetInverted<T>(this T t)
			where T : DG.Tweening.Tween;
		public static T SetInverted<T>(this T t, bool inverted)
			where T : DG.Tweening.Tween;
		public static T OnStart<T>(this T t, TweenCallback action)
			where T : DG.Tweening.Tween;
		public static T OnPlay<T>(this T t, TweenCallback action)
			where T : DG.Tweening.Tween;
		public static T OnPause<T>(this T t, TweenCallback action)
			where T : DG.Tweening.Tween;
		public static T OnRewind<T>(this T t, TweenCallback action)
			where T : DG.Tweening.Tween;
		public static T OnUpdate<T>(this T t, TweenCallback action)
			where T : DG.Tweening.Tween;
		public static T OnStepComplete<T>(this T t, TweenCallback action)
			where T : DG.Tweening.Tween;
		public static T OnComplete<T>(this T t, TweenCallback action)
			where T : DG.Tweening.Tween;
		public static T OnKill<T>(this T t, TweenCallback action)
			where T : DG.Tweening.Tween;
		public static T OnWaypointChange<T>(this T t, TweenCallback<int> action)
			where T : DG.Tweening.Tween;
		public static T SetAs<T>(this T t, DG.Tweening.Tween asTween)
			where T : DG.Tweening.Tween;
		public static T SetAs<T>(this T t, TweenParams tweenParams)
			where T : DG.Tweening.Tween;
		public static DG.Tweening.Sequence Append(this DG.Tweening.Sequence s, DG.Tweening.Tween t); // 0x0000000185C896B0-0x0000000185C89720
		public static DG.Tweening.Sequence Prepend(this DG.Tweening.Sequence s, DG.Tweening.Tween t); // 0x0000000188C898EC-0x0000000188C89928
		public static DG.Tweening.Sequence Join(this DG.Tweening.Sequence s, DG.Tweening.Tween t); // 0x0000000185C88810-0x0000000185C88860
		public static DG.Tweening.Sequence Insert(this DG.Tweening.Sequence s, float atPosition, DG.Tweening.Tween t); // 0x0000000188C89814-0x0000000188C89864
		public static DG.Tweening.Sequence AppendInterval(this DG.Tweening.Sequence s, float interval); // 0x0000000185C88A90-0x0000000185C88AD0
		public static DG.Tweening.Sequence PrependInterval(this DG.Tweening.Sequence s, float interval); // 0x0000000188C898AC-0x0000000188C898EC
		public static DG.Tweening.Sequence AppendCallback(this DG.Tweening.Sequence s, TweenCallback callback); // 0x00000001869E63B0-0x00000001869E6400
		public static DG.Tweening.Sequence PrependCallback(this DG.Tweening.Sequence s, TweenCallback callback); // 0x0000000188C89864-0x0000000188C898AC
		public static DG.Tweening.Sequence InsertCallback(this DG.Tweening.Sequence s, float atPosition, TweenCallback callback); // 0x0000000188C897C0-0x0000000188C89814
		public static T From<T>(this T t)
			where T : Tweener;
		public static T From<T>(this T t, bool isRelative)
			where T : Tweener;
		public static T From<T>(this T t, bool setImmediately, bool isRelative)
			where T : Tweener;
		public static TweenerCore<T1, T2, TPlugOptions> From<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately = true /* Metadata: 0x026455D4 */, bool isRelative = false /* Metadata: 0x026455D5 */)
			where TPlugOptions : struct, IPlugOptions;
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> From(this TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t, float fromAlphaValue, bool setImmediately = true /* Metadata: 0x026455D6 */, bool isRelative = false /* Metadata: 0x026455D7 */); // 0x0000000188C895B8-0x0000000188C89674
		public static TweenerCore<Vector3, Vector3, VectorOptions> From(this TweenerCore<Vector3, Vector3, VectorOptions> t, float fromValue, bool setImmediately = true /* Metadata: 0x026455D8 */, bool isRelative = false /* Metadata: 0x026455D9 */); // 0x0000000188C89674-0x0000000188C89720
		public static TweenerCore<Vector2, Vector2, CircleOptions> From(this TweenerCore<Vector2, Vector2, CircleOptions> t, float fromValueDegrees, bool setImmediately = true /* Metadata: 0x026455DA */, bool isRelative = false /* Metadata: 0x026455DB */); // 0x0000000188C89720-0x0000000188C897C0
		public static T SetDelay<T>(this T t, float delay)
			where T : DG.Tweening.Tween;
		public static T SetDelay<T>(this T t, float delay, bool asPrependedIntervalIfSequence)
			where T : DG.Tweening.Tween;
		public static T SetRelative<T>(this T t)
			where T : DG.Tweening.Tween;
		public static T SetRelative<T>(this T t, bool isRelative)
			where T : DG.Tweening.Tween;
		public static T SetSpeedBased<T>(this T t)
			where T : DG.Tweening.Tween;
		public static T SetSpeedBased<T>(this T t, bool isSpeedBased)
			where T : DG.Tweening.Tween;
		public static Tweener SetOptions(this TweenerCore<float, float, FloatOptions> t, bool snapping); // 0x0000000188C89E78-0x0000000188C89E90
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, bool snapping); // 0x0000000185C89C20-0x0000000185C89C40
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x026455DC */); // 0x0000000188C89EB0-0x0000000188C89ED0
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, bool snapping); // 0x0000000185FBA560-0x0000000185FBA580
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x026455DD */); // 0x0000000188C89E58-0x0000000188C89E78
		public static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, bool snapping); // 0x0000000188C89CF8-0x0000000188C89D10
		public static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x026455DE */); // 0x0000000188C89CD8-0x0000000188C89CF8
		public static Tweener SetOptions(this TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool useShortest360Route = true /* Metadata: 0x026455DF */); // 0x0000000188C89D10-0x0000000188C89D30
		public static Tweener SetOptions(this TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t, bool alphaOnly); // 0x00000001869E62E0-0x00000001869E6300
		public static Tweener SetOptions(this TweenerCore<Rect, Rect, RectOptions> t, bool snapping); // 0x00000001869E62E0-0x00000001869E6300
		public static Tweener SetOptions(this TweenerCore<string, string, StringOptions> t, bool richTextEnabled, ScrambleMode scrambleMode = ScrambleMode.None /* Metadata: 0x026455E0 */, string scrambleChars = null); // 0x0000000188C89D30-0x0000000188C89E08
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool snapping); // 0x0000000185C89C20-0x0000000185C89C40
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x026455E1 */); // 0x0000000188C89EB0-0x0000000188C89ED0
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, CircleOptions> t, float endValueDegrees, bool relativeCenter = true /* Metadata: 0x026455E2 */, bool snapping = false /* Metadata: 0x026455E3 */); // 0x0000000188C89E30-0x0000000188C89E58
		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, AxisConstraint lockPosition, AxisConstraint lockRotation = AxisConstraint.None /* Metadata: 0x026455E4 */); // 0x0000000188C89E90-0x0000000188C89EB0
		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, bool closePath, AxisConstraint lockPosition = AxisConstraint.None /* Metadata: 0x026455E5 */, AxisConstraint lockRotation = AxisConstraint.None /* Metadata: 0x026455E6 */); // 0x0000000188C89E08-0x0000000188C89E30
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, Vector3? forwardDirection = default, Vector3? up = default); // 0x0000000188C89A34-0x0000000188C89AA8
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, bool stableZRotation); // 0x0000000188C89B28-0x0000000188C89B94
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, Vector3? forwardDirection = default, Vector3? up = default); // 0x0000000188C899A8-0x0000000188C89A34
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, bool stableZRotation); // 0x0000000188C89B94-0x0000000188C89C18
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, Vector3? forwardDirection = default, Vector3? up = default); // 0x0000000188C89AA8-0x0000000188C89B28
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, bool stableZRotation); // 0x0000000188C89928-0x0000000188C899A8
		private static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, OrientType orientType, Vector3 lookAtPosition, Transform lookAtTransform, float lookAhead, Vector3? forwardDirection = default, Vector3? up = default, bool stableZRotation = false /* Metadata: 0x026455E7 */); // 0x0000000188C89C18-0x0000000188C89CD8
		private static void SetPathForwardDirection(this TweenerCore<Vector3, Path, PathOptions> t, Vector3? forwardDirection = default, Vector3? up = default); // 0x0000000188C89ED0-0x0000000188C8A158
	}

	public enum LogBehaviour // TypeDefIndex: 86477
	{
		Default = 0,
		Verbose = 1,
		ErrorsOnly = 2
	}

	public abstract class Tween : ABSSequentiable // TypeDefIndex: 86478
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
		[CompilerGenerated]
		private bool _isRelative_k__BackingField; // 0xB0
		internal Ease easeType; // 0xB4
		internal EaseFunction customEase; // 0xB8
		public float easeOvershootOrAmplitude; // 0xC0
		public float easePeriod; // 0xC4
		public string debugTargetId; // 0xC8
		internal System.Type typeofT1; // 0xD0
		internal System.Type typeofT2; // 0xD8
		internal System.Type typeofTPlugOptions; // 0xE0
		[CompilerGenerated]
		private bool _active_k__BackingField; // 0xE8
		internal bool isSequenced; // 0xE9
		internal DG.Tweening.Sequence sequenceParent; // 0xF0
		internal int activeId; // 0xF8
		internal SpecialStartupMode specialStartupMode; // 0xFC
		internal bool creationLocked; // 0x100
		internal bool startupDone; // 0x101
		[CompilerGenerated]
		private bool _playedOnce_k__BackingField; // 0x102
		[CompilerGenerated]
		private float _position_k__BackingField; // 0x104
		internal float fullDuration; // 0x108
		internal int completedLoops; // 0x10C
		internal bool isPlaying; // 0x110
		internal bool isComplete; // 0x111
		internal float elapsedDelay; // 0x114
		internal bool delayComplete; // 0x118
		internal int miscInt; // 0x11C
	
		// Properties
		public bool isRelative { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x000000018225E0F0-0x000000018225E100 0x000000018225E100-0x000000018225E110
		public bool active { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x000000018299E130-0x000000018299E140 0x000000018299E140-0x000000018299E150
		public float fullPosition { get; set; } // 0x0000000188C8A158-0x0000000188C8A164 0x0000000188C8A164-0x0000000188C8A174
		public bool hasLoops { get; } // 0x0000000185095E40-0x0000000185095E60 
		public bool playedOnce { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187239600-0x0000000187239610 0x0000000187239620-0x0000000187239630
		public float position { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000187239610-0x0000000187239620 0x0000000187239630-0x0000000187239640
	
		// Constructors
		protected Tween(); // 0x00000001872395D0-0x0000000187239600
	
		// Methods
		internal virtual void Reset(); // 0x0000000185E0F490-0x0000000185E0F610
		internal abstract bool Validate();
		internal virtual float UpdateDelay(float elapsed); // 0x0000000187234CD0-0x0000000187234CE0
		internal abstract bool Startup();
		internal abstract bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, UpdateNotice updateNotice);
		internal static bool DoGoto(Tween t, float toPosition, int toCompletedLoops, DG.Tweening.Core.Enums.UpdateMode updateMode); // 0x00000001850959D0-0x0000000185095E40
		internal static bool OnTweenCallback(TweenCallback callback, Tween t); // 0x0000000185CE06A0-0x0000000185CE0810
		internal static bool OnTweenCallback<T>(TweenCallback<T> callback, Tween t, T param);
	}

	public abstract class Tweener : DG.Tweening.Tween // TypeDefIndex: 86479
	{
		// Fields
		internal bool hasManuallySetStartValue; // 0x120
		internal bool isFromAllowed; // 0x121
	
		// Constructors
		internal Tweener(); // 0x0000000187239640-0x0000000187239670
	
		// Methods
		public abstract Tweener ChangeStartValue(object newStartValue, float newDuration = -1f /* Metadata: 0x026455EB */);
		public abstract Tweener ChangeEndValue(object newEndValue, float newDuration = -1f /* Metadata: 0x026455EF */, bool snapStartValue = false /* Metadata: 0x026455F3 */);
		public abstract Tweener ChangeEndValue(object newEndValue, bool snapStartValue);
		public abstract Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1f /* Metadata: 0x026455F4 */);
		internal abstract Tweener SetFrom(bool relative);
		internal static bool Setup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null)
			where TPlugOptions : struct, IPlugOptions;
		internal static float DoUpdateDelay<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, float elapsed)
			where TPlugOptions : struct, IPlugOptions;
		internal static bool DoStartup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t)
			where TPlugOptions : struct, IPlugOptions;
		internal static TweenerCore<T1, T2, TPlugOptions> DoChangeStartValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, float newDuration)
			where TPlugOptions : struct, IPlugOptions;
		internal static TweenerCore<T1, T2, TPlugOptions> DoChangeEndValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newEndValue, float newDuration, bool snapStartValue)
			where TPlugOptions : struct, IPlugOptions;
		internal static TweenerCore<T1, T2, TPlugOptions> DoChangeValues<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, T2 newEndValue, float newDuration)
			where TPlugOptions : struct, IPlugOptions;
		private static bool DOStartupSpecials<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t)
			where TPlugOptions : struct, IPlugOptions;
		private static void DOStartupDurationBased<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t)
			where TPlugOptions : struct, IPlugOptions;
	}

	public enum TweenType // TypeDefIndex: 86480
	{
		Tweener = 0,
		Sequence = 1,
		Callback = 2
	}

	public enum UpdateType // TypeDefIndex: 86481
	{
		Normal = 0,
		Late = 1,
		Fixed = 2,
		Manual = 3
	}
}

namespace DG.Tweening.Core
{
	public abstract class ABSSequentiable // TypeDefIndex: 86527
	{
		// Fields
		internal TweenType tweenType; // 0x10
		internal float sequencedPosition; // 0x14
		internal float sequencedEndPosition; // 0x18
		internal TweenCallback onStart; // 0x20
	
		// Constructors
		protected ABSSequentiable(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public delegate T DOGetter<out T>(); // TypeDefIndex: 86528; 0x00000000-0x00000000

	public delegate void DOSetter<in T>(T pNewValue); // TypeDefIndex: 86529; 0x00000000-0x00000000

	public static class Debugger // TypeDefIndex: 86531
	{
		// Fields
		private static int _logPriority; // 0x00
		private const string _LogPrefix = "<color=#0099bc><b>DOTWEEN \u25BA </b></color>"; // Metadata: 0x0264560A
	
		// Properties
		public static int logPriority { get; } // 0x0000000188C9A9F8-0x0000000188C9AA30 
	
		// Nested types
		internal static class Sequence // TypeDefIndex: 86530
		{
			// Methods
			public static void LogAddToNullSequence(); // 0x0000000188CA1AB4-0x0000000188CA1AEC
			public static void LogAddToInactiveSequence(); // 0x0000000188CA1A44-0x0000000188CA1A7C
			public static void LogAddToLockedSequence(); // 0x0000000188CA1A7C-0x0000000188CA1AB4
			public static void LogAddNullTween(); // 0x0000000188CA1A0C-0x0000000188CA1A44
			public static void LogAddInactiveTween(DG.Tweening.Tween t); // 0x0000000188CA19D0-0x0000000188CA1A0C
			public static void LogAddAlreadySequencedTween(DG.Tweening.Tween t); // 0x0000000188CA1994-0x0000000188CA19D0
		}
	
		// Methods
		public static void Log(object message); // 0x0000000188C9A894-0x0000000188C9A984
		public static void LogWarning(object message, DG.Tweening.Tween t = null); // 0x0000000186144C20-0x0000000186144D60
		public static void LogError(object message, DG.Tweening.Tween t = null); // 0x0000000188C9A1D4-0x0000000188C9A328
		public static void LogSafeModeCapturedError(object message, DG.Tweening.Tween t = null); // 0x0000000188C9A600-0x0000000188C9A7B4
		public static void LogReport(object message); // 0x0000000188C9A520-0x0000000188C9A600
		public static void LogSafeModeReport(object message); // 0x0000000188C9A7B4-0x0000000188C9A894
		public static void LogInvalidTween(DG.Tweening.Tween t); // 0x0000000188C9A328-0x0000000188C9A360
		public static void LogNestedTween(DG.Tweening.Tween t); // 0x0000000188C9A418-0x0000000188C9A454
		public static void LogNullTween(DG.Tweening.Tween t); // 0x0000000188C9A490-0x0000000188C9A4C8
		public static void LogNonPathTween(DG.Tweening.Tween t); // 0x0000000188C9A454-0x0000000188C9A490
		public static void LogMissingMaterialProperty(string propertyName); // 0x0000000188C9A360-0x0000000188C9A3AC
		public static void LogMissingMaterialProperty(int propertyId); // 0x0000000188C9A3AC-0x0000000188C9A418
		public static void LogRemoveActiveTweenError(string errorInfo, DG.Tweening.Tween t); // 0x0000000188C9A4C8-0x0000000188C9A520
		public static void LogAddActiveTweenError(string errorInfo, DG.Tweening.Tween t); // 0x0000000188C9A17C-0x0000000188C9A1D4
		public static void SetLogPriority(LogBehaviour logBehaviour); // 0x00000001852D7F30-0x00000001852D7F80
		public static bool ShouldLogSafeModeCapturedError(); // 0x0000000188C9A984-0x0000000188C9A9F8
		private static string GetDebugDataMessage(DG.Tweening.Tween t); // 0x0000000188C9A130-0x0000000188C9A17C
		private static void AddDebugDataToMessage(ref string message, DG.Tweening.Tween t); // 0x0000000188C99F68-0x0000000188C9A130
	}

	[AddComponentMenu("")]
	public class DOTweenComponent : MonoBehaviour, IDOTweenInit // TypeDefIndex: 86538
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
		[CompilerGenerated]
		private sealed class _WaitForCompletion_d__17 : IEnumerator<object> // TypeDefIndex: 86532
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DG.Tweening.Tween t; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForCompletion_d__17(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CA4B00-0x0000000188CA4B5C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CA4B5C-0x0000000188CA4BA8
		}
	
		[CompilerGenerated]
		private sealed class _WaitForRewind_d__18 : IEnumerator<object> // TypeDefIndex: 86533
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DG.Tweening.Tween t; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForRewind_d__18(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CA4DC4-0x0000000188CA4E48
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CA4E48-0x0000000188CA4E94
		}
	
		[CompilerGenerated]
		private sealed class _WaitForKill_d__19 : IEnumerator<object> // TypeDefIndex: 86534
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DG.Tweening.Tween t; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForKill_d__19(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CA4C58-0x0000000188CA4CB0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CA4CB0-0x0000000188CA4CFC
		}
	
		[CompilerGenerated]
		private sealed class _WaitForElapsedLoops_d__20 : IEnumerator<object> // TypeDefIndex: 86535
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DG.Tweening.Tween t; // 0x20
			public int elapsedLoops; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForElapsedLoops_d__20(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CA4BA8-0x0000000188CA4C0C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CA4C0C-0x0000000188CA4C58
		}
	
		[CompilerGenerated]
		private sealed class _WaitForPosition_d__21 : IEnumerator<object> // TypeDefIndex: 86536
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DG.Tweening.Tween t; // 0x20
			public float position; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForPosition_d__21(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CA4CFC-0x0000000188CA4D78
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CA4D78-0x0000000188CA4DC4
		}
	
		[CompilerGenerated]
		private sealed class _WaitForStart_d__22 : IEnumerator<object> // TypeDefIndex: 86537
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DG.Tweening.Tween t; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForStart_d__22(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000188CA4E94-0x0000000188CA4EF0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188CA4EF0-0x0000000188CA4F3C
		}
	
		// Constructors
		public DOTweenComponent(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void Awake(); // 0x0000000186DBD7A0-0x0000000186DBD950
		private void Start(); // 0x00000001871869F0-0x0000000187186A90
		private void Update(); // 0x0000000185096530-0x0000000185096A00
		private void LateUpdate(); // 0x00000001861F8CA0-0x00000001861F8CF0
		private void FixedUpdate(); // 0x00000001861583B0-0x00000001861583F0
		private void OnDrawGizmos(); // 0x0000000188C99A20-0x0000000188C99B40
		private void OnDestroy(); // 0x0000000188C99620-0x0000000188C99A20
		public void OnApplicationPause(bool pauseStatus); // 0x000000018722DAA0-0x000000018722DAC0
		private void OnApplicationQuit(); // 0x0000000188C995D4-0x0000000188C99620
		public IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity); // 0x0000000188C99B40-0x0000000188C99BA0
		internal IEnumerator WaitForCompletion(DG.Tweening.Tween t); // 0x0000000188C99BA0-0x0000000188C99BFC
		internal IEnumerator WaitForRewind(DG.Tweening.Tween t); // 0x0000000188C99D34-0x0000000188C99D90
		internal IEnumerator WaitForKill(DG.Tweening.Tween t); // 0x0000000188C99C68-0x0000000188C99CC4
		internal IEnumerator WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops); // 0x0000000188C99BFC-0x0000000188C99C68
		internal IEnumerator WaitForPosition(DG.Tweening.Tween t, float position); // 0x0000000188C99CC4-0x0000000188C99D34
		internal IEnumerator WaitForStart(DG.Tweening.Tween t); // 0x0000000188C99D90-0x0000000188C99DEC
		internal static void Create(); // 0x00000001852D7D10-0x00000001852D7E90
		internal static void DestroyInstance(); // 0x0000000188C994E4-0x0000000188C995D4
	}

	public class DOTweenSettings : ScriptableObject // TypeDefIndex: 86542
	{
		// Fields
		public const string AssetName = "DOTweenSettings"; // Metadata: 0x02645635
		public const string AssetFullFilename = "DOTweenSettings.asset"; // Metadata: 0x02645645
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
		public enum SettingsLocation // TypeDefIndex: 86539
		{
			AssetsDirectory = 0,
			DOTweenDirectory = 1,
			DemigiantDirectory = 2
		}
	
		[Serializable]
		public class SafeModeOptions // TypeDefIndex: 86540
		{
			// Fields
			public SafeModeLogBehaviour logBehaviour; // 0x10
			public NestedTweenFailureBehaviour nestedTweenFailureBehaviour; // 0x14
	
			// Constructors
			public SafeModeOptions(); // 0x00000001872397B0-0x00000001872397C0
		}
	
		[Serializable]
		public class ModulesSetup // TypeDefIndex: 86541
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
			public ModulesSetup(); // 0x0000000187239700-0x0000000187239710
		}
	
		// Constructors
		public DOTweenSettings(); // 0x0000000187085950-0x0000000187085A20
	}

	public static class Extensions // TypeDefIndex: 86543
	{
		// Extension methods
		public static T SetSpecialStartupMode<T>(this T t, SpecialStartupMode mode)
			where T : DG.Tweening.Tween;
		public static TweenerCore<T1, T2, TPlugOptions> Blendable<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t)
			where TPlugOptions : struct, IPlugOptions;
		public static TweenerCore<T1, T2, TPlugOptions> NoFrom<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t)
			where TPlugOptions : struct, IPlugOptions;
	}

	public static class DOTweenExternalCommand // TypeDefIndex: 86544
	{
		// Fields
		[CompilerGenerated]
		private static Action<PathOptions, DG.Tweening.Tween, Quaternion, Transform> SetOrientationOnPath; // 0x00
	
		// Events
		public static event Action<PathOptions, DG.Tweening.Tween, Quaternion, Transform> SetOrientationOnPath {
			add; // 0x0000000186FBAE70-0x0000000186FBAF10
			remove; // 0x0000000188C99ECC-0x0000000188C99F68
		}
	
		// Methods
		internal static void Dispatch_SetOrientationOnPath(PathOptions options, DG.Tweening.Tween t, Quaternion newRot, Transform trans); // 0x0000000188C99DEC-0x0000000188C99ECC
	}

	internal struct SafeModeReport // TypeDefIndex: 86546
	{
		// Fields
		[CompilerGenerated]
		private int _totMissingTargetOrFieldErrors_k__BackingField; // 0x00
		[CompilerGenerated]
		private int _totCallbackErrors_k__BackingField; // 0x04
		[CompilerGenerated]
		private int _totStartupErrors_k__BackingField; // 0x08
		[CompilerGenerated]
		private int _totUnsetErrors_k__BackingField; // 0x0C
	
		// Properties
		public int totMissingTargetOrFieldErrors { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public int totCallbackErrors { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872342E0-0x00000001872342F0 0x0000000187235AB0-0x0000000187235AC0
		public int totStartupErrors { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184431A70-0x0000000184431A80 0x0000000187235AA0-0x0000000187235AB0
		public int totUnsetErrors { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184431980-0x0000000184431990 0x00000001872397D0-0x00000001872397E0
	
		// Nested types
		internal enum SafeModeReportType // TypeDefIndex: 86545
		{
			Unset = 0,
			TargetOrFieldMissing = 1,
			Callback = 2,
			StartupFailure = 3
		}
	
		// Methods
		public void Add(SafeModeReportType type); // 0x0000000188CA1974-0x0000000188CA1994
		public int GetTotErrors(); // 0x00000001872397C0-0x00000001872397D0
	}

	internal class SequenceCallback : ABSSequentiable // TypeDefIndex: 86547
	{
		// Constructors
		public SequenceCallback(float sequencedPosition, TweenCallback callback); // 0x00000001869E64D0-0x00000001869E64F0
	}

	internal class TweenLink // TypeDefIndex: 86548
	{
		// Fields
		public readonly GameObject target; // 0x10
		public readonly LinkBehaviour behaviour; // 0x18
		public bool lastSeenActive; // 0x1C
	
		// Constructors
		public TweenLink(GameObject target, LinkBehaviour behaviour); // 0x00000001866FFD80-0x00000001866FFDC0
	}

	internal static class TweenManager // TypeDefIndex: 86550
	{
		// Fields
		private const int _DefaultMaxTweeners = 200; // Metadata: 0x0264566F
		private const int _DefaultMaxSequences = 50; // Metadata: 0x02645671
		private const string _MaxTweensReached = "Max Tweens reached: capacity has automatically been increased from #0 to #1. Use DOTween.SetTweensCapacity to set it manually at startup"; // Metadata: 0x02645672
		private const float _EpsilonVsTimeCheck = 1E-06f; // Metadata: 0x026456FC
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
		internal enum CapacityIncreaseMode // TypeDefIndex: 86549
		{
			TweenersAndSequences = 0,
			TweenersOnly = 1,
			SequencesOnly = 2
		}
	
		// Constructors
		static TweenManager(); // 0x0000000186E0EE90-0x0000000186E0F130
	
		// Methods
		internal static TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>()
			where TPlugOptions : struct, IPlugOptions;
		internal static DG.Tweening.Sequence GetSequence(); // 0x0000000185C89100-0x0000000185C89340
		internal static void SetUpdateType(DG.Tweening.Tween t, DG.Tweening.UpdateType updateType, bool isIndependentUpdate); // 0x0000000186AB47E0-0x0000000186AB4850
		internal static void AddActiveTweenToSequence(DG.Tweening.Tween t); // 0x0000000185C898E0-0x0000000185C89910
		internal static int DespawnAll(); // 0x0000000188CA360C-0x0000000188CA38C0
		internal static void Despawn(DG.Tweening.Tween t, bool modifyActiveLists = true /* Metadata: 0x02645662 */); // 0x0000000185093730-0x00000001850938C0
		internal static void PurgeAll(bool isApplicationQuitting); // 0x0000000188CA4140-0x0000000188CA439C
		internal static void PurgePools(); // 0x0000000188CA439C-0x0000000188CA44A0
		internal static void AddTweenLink(DG.Tweening.Tween t, TweenLink tweenLink); // 0x00000001866FFDC0-0x00000001866FFF00
		private static void RemoveTweenLink(DG.Tweening.Tween t); // 0x00000001850938C0-0x00000001850939B0
		internal static void ResetCapacities(); // 0x0000000188CA44A0-0x0000000188CA44EC
		internal static void SetCapacities(int tweenersCapacity, int sequencesCapacity); // 0x0000000188CA44EC-0x0000000188CA45FC
		internal static int Validate(); // 0x0000000188CA4968-0x0000000188CA4B00
		internal static void Update(DG.Tweening.UpdateType updateType, float deltaTime, float independentTime); // 0x0000000185095330-0x00000001850955F0
		internal static bool Update(DG.Tweening.Tween t, float deltaTime, float independentTime, bool isSingleTweenManualUpdate); // 0x00000001850955F0-0x0000000185095800
		internal static int FilteredOperation(DG.Tweening.Core.Enums.OperationType operationType, DG.Tweening.Core.Enums.FilterType filterType, object id, bool optionalBool, float optionalFloat, object optionalObj = null, object[] optionalArray = null); // 0x0000000185094FA0-0x0000000185095330
		internal static bool Complete(DG.Tweening.Tween t, bool modifyActiveLists = true /* Metadata: 0x02645663 */, DG.Tweening.Core.Enums.UpdateMode updateMode = DG.Tweening.Core.Enums.UpdateMode.Goto /* Metadata: 0x02645664 */); // 0x0000000185093080-0x0000000185093150
		internal static bool Flip(DG.Tweening.Tween t); // 0x0000000188CA3AA8-0x0000000188CA3AC8
		internal static void ForceInit(DG.Tweening.Tween t, bool isSequenced = false /* Metadata: 0x02645665 */); // 0x0000000185E21460-0x0000000185E214B0
		internal static bool Goto(DG.Tweening.Tween t, float to, bool andPlay = false /* Metadata: 0x02645666 */, DG.Tweening.Core.Enums.UpdateMode updateMode = DG.Tweening.Core.Enums.UpdateMode.Goto /* Metadata: 0x02645667 */); // 0x0000000185E21330-0x0000000185E21460
		internal static bool Pause(DG.Tweening.Tween t); // 0x00000001867DAEB0-0x00000001867DAEF0
		internal static bool Play(DG.Tweening.Tween t); // 0x00000001869FF550-0x00000001869FF580
		internal static bool PlayBackwards(DG.Tweening.Tween t); // 0x0000000188CA4004-0x0000000188CA40B4
		internal static bool PlayForward(DG.Tweening.Tween t); // 0x0000000188CA40B4-0x0000000188CA4140
		internal static bool Restart(DG.Tweening.Tween t, bool includeDelay = true /* Metadata: 0x02645668 */, float changeDelayTo = -1f /* Metadata: 0x02645669 */); // 0x000000018519A360-0x000000018519A400
		internal static bool Rewind(DG.Tweening.Tween t, bool includeDelay = true /* Metadata: 0x0264566D */); // 0x000000018519A400-0x000000018519A4D0
		internal static bool SmoothRewind(DG.Tweening.Tween t); // 0x0000000188CA45FC-0x0000000188CA46EC
		internal static bool TogglePause(DG.Tweening.Tween t); // 0x0000000188CA46EC-0x0000000188CA4754
		internal static int TotalPooledTweens(); // 0x0000000188CA4870-0x0000000188CA48C4
		internal static int TotalPlayingTweens(); // 0x0000000188CA4754-0x0000000188CA4870
		internal static int TotalTweensById(object id, bool playingOnly); // 0x0000000188CA48C4-0x0000000188CA4968
		internal static List<DG.Tweening.Tween> GetActiveTweens(bool playing, List<DG.Tweening.Tween> fillableList = null); // 0x0000000188CA3AC8-0x0000000188CA3C80
		internal static List<DG.Tweening.Tween> GetTweensById(object id, bool playingOnly, List<DG.Tweening.Tween> fillableList = null); // 0x0000000188CA3C80-0x0000000188CA3DB8
		private static int DoGetTweensById(object id, bool playingOnly, bool addToList, List<DG.Tweening.Tween> fillableList); // 0x0000000188CA38C0-0x0000000188CA3AA8
		internal static List<DG.Tweening.Tween> GetTweensByTarget(object target, bool playingOnly, List<DG.Tweening.Tween> fillableList = null); // 0x0000000188CA3DB8-0x0000000188CA3F7C
		private static void MarkForKilling(DG.Tweening.Tween t, bool isSingleTweenManualUpdate = false /* Metadata: 0x0264566E */); // 0x0000000185C89870-0x0000000185C898E0
		private static void EvaluateTweenLink(DG.Tweening.Tween t); // 0x0000000185095800-0x00000001850959D0
		private static void AddActiveTween(DG.Tweening.Tween t); // 0x0000000185093D20-0x0000000185094020
		private static void ReorganizeActiveTweens(); // 0x0000000185094C20-0x0000000185094FA0
		private static void DespawnActiveTweens(List<DG.Tweening.Tween> tweens); // 0x0000000185093340-0x00000001850933C0
		private static void RemoveActiveTween(DG.Tweening.Tween t); // 0x00000001850939B0-0x0000000185093D20
		private static void ClearTweenArray(DG.Tweening.Tween[] tweens); // 0x0000000188CA35BC-0x0000000188CA360C
		private static void IncreaseCapacities(CapacityIncreaseMode increaseMode); // 0x0000000186D307F0-0x0000000186D30A00
		private static void ManageOnRewindCallbackWhenAlreadyRewinded(DG.Tweening.Tween t, bool isPlayBackwardsOrSmoothRewind); // 0x0000000188CA3F7C-0x0000000188CA4004
	}

	public static class DOTweenUtils // TypeDefIndex: 86551
	{
		// Fields
		private static Assembly[] _loadedAssemblies; // 0x00
		private static readonly string[] _defAssembliesToQuery; // 0x08
	
		// Constructors
		static DOTweenUtils(); // 0x0000000187083BB0-0x0000000187083C90
	
		// Methods
		internal static Vector3 Vector3FromAngle(float degrees, float magnitude); // 0x00000001872397F0-0x0000000187239850
		internal static float Angle2D(Vector3 from, Vector3 to); // 0x0000000188CA7544-0x0000000188CA764C
		internal static Vector3 RotateAroundPivot(Vector3 point, Vector3 pivot, Quaternion rotation); // 0x0000000188CA76D0-0x0000000188CA7790
		public static Vector2 GetPointOnCircle(Vector2 center, float radius, float degrees); // 0x0000000188CA764C-0x0000000188CA76D0
		internal static bool Vector3AreApproximatelyEqual(Vector3 a, Vector3 b); // 0x0000000188CA7790-0x0000000188CA7854
		internal static System.Type GetLooseScriptType(string typeName); // 0x0000000186DBD950-0x0000000186DBDAA0
	}

	public class TweenerCore<T1, T2, TPlugOptions> : Tweener // TypeDefIndex: 86552
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
		private const string _TxtCantChangeSequencedValues = "You cannot change the values of a tween contained inside a Sequence"; // Metadata: 0x0264571D
		private System.Type _colorType;
		private System.Type _color32Type;
	
		// Constructors
		internal TweenerCore();
	
		// Methods
		public override Tweener ChangeStartValue(object newStartValue, float newDuration = -1f /* Metadata: 0x02645703 */);
		public override Tweener ChangeEndValue(object newEndValue, bool snapStartValue);
		public override Tweener ChangeEndValue(object newEndValue, float newDuration = -1f /* Metadata: 0x02645707 */, bool snapStartValue = false /* Metadata: 0x0264570B */);
		public override Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1f /* Metadata: 0x0264570C */);
		public TweenerCore<T1, T2, TPlugOptions> ChangeStartValue(T2 newStartValue, float newDuration = -1f /* Metadata: 0x02645710 */);
		public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, bool snapStartValue);
		public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, float newDuration = -1f /* Metadata: 0x02645714 */, bool snapStartValue = false /* Metadata: 0x02645718 */);
		public TweenerCore<T1, T2, TPlugOptions> ChangeValues(T2 newStartValue, T2 newEndValue, float newDuration = -1f /* Metadata: 0x02645719 */);
		internal override Tweener SetFrom(bool relative);
		internal Tweener SetFrom(T2 fromValue, bool setImmediately, bool relative);
		internal sealed override void Reset();
		internal override bool Validate();
		private bool ValidateChangeValueType(System.Type newType, out bool isColor32ToColor);
		internal override float UpdateDelay(float elapsed);
		internal override bool Startup();
		internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, UpdateNotice updateNotice);
	}
}

namespace DG.Tweening.Core.Easing
{
	public static class Bounce // TypeDefIndex: 86561
	{
		// Methods
		public static float EaseIn(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod); // 0x0000000188CA7468-0x0000000188CA74A4
		public static float EaseOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod); // 0x0000000188CA74A4-0x0000000188CA7544
		public static float EaseInOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod); // 0x0000000188CA73F0-0x0000000188CA7468
	}

	public static class EaseManager // TypeDefIndex: 86563
	{
		// Fields
		private const float _PiOver2 = 1.5707964f; // Metadata: 0x02645788
		private const float _TwoPi = 6.2831855f; // Metadata: 0x0264578C
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86562
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
			static __c(); // 0x0000000188CAA4B0-0x0000000188CAA514
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _ToEaseFunction_b__4_0(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA9638-0x0000000188CA9640
			internal float _ToEaseFunction_b__4_1(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA9A00-0x0000000188CA9A78
			internal float _ToEaseFunction_b__4_2(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CAA1F8-0x0000000188CAA260
			internal float _ToEaseFunction_b__4_3(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CAA36C-0x0000000188CAA3E4
			internal float _ToEaseFunction_b__4_4(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000187239850-0x0000000187239860
			internal float _ToEaseFunction_b__4_5(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CAA350-0x0000000188CAA36C
			internal float _ToEaseFunction_b__4_6(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CAA3E4-0x0000000188CAA430
			internal float _ToEaseFunction_b__4_7(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CAA430-0x0000000188CAA440
			internal float _ToEaseFunction_b__4_8(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CAA440-0x0000000188CAA460
			internal float _ToEaseFunction_b__4_9(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CAA460-0x0000000188CAA4B0
			internal float _ToEaseFunction_b__4_10(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA9640-0x0000000188CA9654
			internal float _ToEaseFunction_b__4_11(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA9654-0x0000000188CA9680
			internal float _ToEaseFunction_b__4_12(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA9680-0x0000000188CA96DC
			internal float _ToEaseFunction_b__4_13(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA96DC-0x0000000188CA96F4
			internal float _ToEaseFunction_b__4_14(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA96F4-0x0000000188CA971C
			internal float _ToEaseFunction_b__4_15(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA971C-0x0000000188CA977C
			internal float _ToEaseFunction_b__4_16(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA977C-0x0000000188CA9804
			internal float _ToEaseFunction_b__4_17(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA9804-0x0000000188CA9894
			internal float _ToEaseFunction_b__4_18(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA9894-0x0000000188CA9984
			internal float _ToEaseFunction_b__4_19(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA9984-0x0000000188CA9A00
			internal float _ToEaseFunction_b__4_20(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA9A78-0x0000000188CA9AE8
			internal float _ToEaseFunction_b__4_21(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA9AE8-0x0000000188CA9BA4
			internal float _ToEaseFunction_b__4_22(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA9BA4-0x0000000188CA9D28
			internal float _ToEaseFunction_b__4_23(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA9D28-0x0000000188CA9EB4
			internal float _ToEaseFunction_b__4_24(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA9EB4-0x0000000188CAA0CC
			internal float _ToEaseFunction_b__4_25(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CAA0CC-0x0000000188CAA0EC
			internal float _ToEaseFunction_b__4_26(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CAA0EC-0x0000000188CAA118
			internal float _ToEaseFunction_b__4_27(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CAA118-0x0000000188CAA188
			internal float _ToEaseFunction_b__4_28(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CAA188-0x0000000188CAA1C8
			internal float _ToEaseFunction_b__4_29(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CAA1C8-0x0000000188CAA1F8
			internal float _ToEaseFunction_b__4_30(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CAA260-0x0000000188CAA290
			internal float _ToEaseFunction_b__4_31(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CAA290-0x0000000188CAA2C0
			internal float _ToEaseFunction_b__4_32(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CAA2C0-0x0000000188CAA2F0
			internal float _ToEaseFunction_b__4_33(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CAA2F0-0x0000000188CAA320
			internal float _ToEaseFunction_b__4_34(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CAA320-0x0000000188CAA350
			internal float _ToEaseFunction_b__4_35(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CAA350-0x0000000188CAA36C
		}
	
		// Methods
		public static float Evaluate(DG.Tweening.Tween t, float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA7854-0x0000000188CA789C
		public static float Evaluate(Ease easeType, EaseFunction customEase, float time, float duration, float overshootOrAmplitude, float period); // 0x00000001850962E0-0x0000000185096530
		public static EaseFunction ToEaseFunction(Ease ease); // 0x0000000188CA789C-0x0000000188CA9154
		internal static bool IsFlashEase(Ease ease); // 0x00000001861D9030-0x00000001861D9040
	}

	public class EaseCurve // TypeDefIndex: 86564
	{
		// Fields
		private readonly AnimationCurve _animCurve; // 0x10
	
		// Constructors
		public EaseCurve(AnimationCurve animCurve); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public float Evaluate(float time, float duration, float unusedOvershoot, float unusedPeriod); // 0x0000000185930CA0-0x0000000185930D30
	}

	public static class Flash // TypeDefIndex: 86565
	{
		// Methods
		public static float Ease(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA9418-0x0000000188CA94E4
		public static float EaseIn(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA9268-0x0000000188CA9338
		public static float EaseOut(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA9338-0x0000000188CA9418
		public static float EaseInOut(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000188CA9154-0x0000000188CA9268
		private static float WeightedEase(float overshootOrAmplitude, float period, int stepIndex, float stepDuration, float dir, float res); // 0x0000000188CA94E4-0x0000000188CA9638
	}
}

namespace DG.Tweening.Core.Enums
{
	internal enum FilterType // TypeDefIndex: 86553
	{
		All = 0,
		TargetOrId = 1,
		TargetAndId = 2,
		AllExceptTargetsOrIds = 3,
		DOGetter = 4
	}

	public enum NestedTweenFailureBehaviour // TypeDefIndex: 86554
	{
		TryToPreserveSequence = 0,
		KillWholeSequence = 1
	}

	internal enum OperationType // TypeDefIndex: 86555
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

	public enum SafeModeLogBehaviour // TypeDefIndex: 86556
	{
		None = 0,
		Normal = 1,
		Warning = 2,
		Error = 3
	}

	public enum SpecialStartupMode // TypeDefIndex: 86557
	{
		None = 0,
		SetLookAt = 1,
		SetShake = 2,
		SetPunch = 3,
		SetCameraShakePosition = 4
	}

	public enum UpdateNotice // TypeDefIndex: 86558
	{
		None = 0,
		RewindStep = 1
	}

	internal enum UpdateMode // TypeDefIndex: 86559
	{
		Update = 0,
		Goto = 1,
		IgnoreOnUpdate = 2,
		IgnoreOnComplete = 3
	}

	public enum RewindCallbackMode // TypeDefIndex: 86560
	{
		FireIfPositionChanged = 0,
		FireAlwaysWithRewind = 1,
		FireAlways = 2
	}
}

namespace DG.Tweening.CustomPlugins
{
	public class PureQuaternionPlugin : ABSTweenPlugin<Quaternion, Quaternion, NoOptions> // TypeDefIndex: 86526
	{
		// Fields
		private static PureQuaternionPlugin _plug; // 0x00
	
		// Constructors
		public PureQuaternionPlugin(); // 0x0000000187225920-0x0000000187225950
	
		// Methods
		public static PureQuaternionPlugin Plug(); // 0x0000000185A5B6E0-0x0000000185A5B780
		public override void Reset(TweenerCore<Quaternion, Quaternion, NoOptions> t); // 0x0000000186805BA0-0x0000000186805BB0
		public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, bool isRelative); // 0x0000000188C9F128-0x0000000188C9F1D8
		public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion fromValue, bool setImmediately, bool isRelative); // 0x0000000188C9F034-0x0000000188C9F128
		public override Quaternion ConvertToStartValue(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion value); // 0x00000001872396D0-0x00000001872396E0
		public override void SetRelativeEndValue(TweenerCore<Quaternion, Quaternion, NoOptions> t); // 0x0000000188C9F1D8-0x0000000188C9F22C
		public override void SetChangeValue(TweenerCore<Quaternion, Quaternion, NoOptions> t); // 0x00000001865DFBB0-0x00000001865DFBE0
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, Quaternion changeValue); // 0x0000000188C9EFF0-0x0000000188C9F034
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Quaternion startValue, Quaternion changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x00000001854AC2E0-0x00000001854AC3D0
	}
}

namespace DG.Tweening.Plugins
{
	public struct CircleOptions : IPlugOptions // TypeDefIndex: 86482
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
		public void Reset(); // 0x0000000187239510-0x0000000187239520
		public void Initialize(Vector2 startValue, Vector2 endValue); // 0x0000000188C79864-0x0000000188C79930
	}

	public class CirclePlugin : ABSTweenPlugin<Vector2, Vector2, CircleOptions> // TypeDefIndex: 86483
	{
		// Constructors
		public CirclePlugin(); // 0x0000000188C79F7C-0x0000000188C79FA4
	
		// Methods
		public override void Reset(TweenerCore<Vector2, Vector2, CircleOptions> t); // 0x0000000186805BA0-0x0000000186805BB0
		public override void SetFrom(TweenerCore<Vector2, Vector2, CircleOptions> t, bool isRelative); // 0x0000000188C79DB8-0x0000000188C79F00
		public override void SetFrom(TweenerCore<Vector2, Vector2, CircleOptions> t, Vector2 fromValue, bool setImmediately, bool isRelative); // 0x0000000188C79C58-0x0000000188C79DB8
		public static ABSTweenPlugin<Vector2, Vector2, CircleOptions> Get(); // 0x0000000188C79BA4-0x0000000188C79BD4
		public override Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, CircleOptions> t, Vector2 value); // 0x0000000187239520-0x0000000187239530
		public override void SetRelativeEndValue(TweenerCore<Vector2, Vector2, CircleOptions> t); // 0x0000000188C79F00-0x0000000188C79F7C
		public override void SetChangeValue(TweenerCore<Vector2, Vector2, CircleOptions> t); // 0x0000000188C79BD4-0x0000000188C79C58
		public override float GetSpeedBasedDuration(CircleOptions options, float unitsXSecond, Vector2 changeValue); // 0x0000000188C79B8C-0x0000000188C79BA4
		public override void EvaluateAndApply(CircleOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000188C79930-0x0000000188C79AB4
		public Vector2 GetPositionOnCircle(CircleOptions options, float degrees); // 0x0000000188C79AB4-0x0000000188C79B8C
	}

	internal class Color2Plugin : ABSTweenPlugin<Color2, Color2, ColorOptions> // TypeDefIndex: 86484
	{
		// Constructors
		public Color2Plugin(); // 0x0000000188C7A704-0x0000000188C7A72C
	
		// Methods
		public override void Reset(TweenerCore<Color2, Color2, ColorOptions> t); // 0x0000000186805BA0-0x0000000186805BB0
		public override void SetFrom(TweenerCore<Color2, Color2, ColorOptions> t, bool isRelative); // 0x0000000188C7A508-0x0000000188C7A688
		public override void SetFrom(TweenerCore<Color2, Color2, ColorOptions> t, Color2 fromValue, bool setImmediately, bool isRelative); // 0x0000000188C7A378-0x0000000188C7A508
		public override Color2 ConvertToStartValue(TweenerCore<Color2, Color2, ColorOptions> t, Color2 value); // 0x0000000187239530-0x0000000187239550
		public override void SetRelativeEndValue(TweenerCore<Color2, Color2, ColorOptions> t); // 0x0000000188C7A688-0x0000000188C7A704
		public override void SetChangeValue(TweenerCore<Color2, Color2, ColorOptions> t); // 0x0000000188C7A2FC-0x0000000188C7A378
		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color2 changeValue); // 0x0000000188C7A2EC-0x0000000188C7A2FC
		public override void EvaluateAndApply(ColorOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Color2> getter, DOSetter<Color2> setter, float elapsed, Color2 startValue, Color2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000188C79FA4-0x0000000188C7A2EC
	}

	public class DoublePlugin : ABSTweenPlugin<double, double, NoOptions> // TypeDefIndex: 86485
	{
		// Constructors
		public DoublePlugin(); // 0x0000000188C9AD20-0x0000000188C9AD48
	
		// Methods
		public override void Reset(TweenerCore<double, double, NoOptions> t); // 0x0000000186805BA0-0x0000000186805BB0
		public override void SetFrom(TweenerCore<double, double, NoOptions> t, bool isRelative); // 0x0000000188C9ABC8-0x0000000188C9AC58
		public override void SetFrom(TweenerCore<double, double, NoOptions> t, double fromValue, bool setImmediately, bool isRelative); // 0x0000000188C9AC58-0x0000000188C9ACF4
		public override double ConvertToStartValue(TweenerCore<double, double, NoOptions> t, double value); // 0x00000001872396C0-0x00000001872396D0
		public override void SetRelativeEndValue(TweenerCore<double, double, NoOptions> t); // 0x0000000188C9ACF4-0x0000000188C9AD20
		public override void SetChangeValue(TweenerCore<double, double, NoOptions> t); // 0x0000000188C9AB9C-0x0000000188C9ABC8
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, double changeValue); // 0x0000000188C9AB80-0x0000000188C9AB9C
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<double> getter, DOSetter<double> setter, float elapsed, double startValue, double changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000188C9AA30-0x0000000188C9AB80
	}

	public class LongPlugin : ABSTweenPlugin<long, long, NoOptions> // TypeDefIndex: 86486
	{
		// Constructors
		public LongPlugin(); // 0x0000000188C9B950-0x0000000188C9B978
	
		// Methods
		public override void Reset(TweenerCore<long, long, NoOptions> t); // 0x0000000186805BA0-0x0000000186805BB0
		public override void SetFrom(TweenerCore<long, long, NoOptions> t, bool isRelative); // 0x0000000188C9B810-0x0000000188C9B894
		public override void SetFrom(TweenerCore<long, long, NoOptions> t, long fromValue, bool setImmediately, bool isRelative); // 0x0000000188C9B894-0x0000000188C9B924
		public override long ConvertToStartValue(TweenerCore<long, long, NoOptions> t, long value); // 0x0000000187239520-0x0000000187239530
		public override void SetRelativeEndValue(TweenerCore<long, long, NoOptions> t); // 0x0000000188C9B924-0x0000000188C9B950
		public override void SetChangeValue(TweenerCore<long, long, NoOptions> t); // 0x0000000188C9B7E4-0x0000000188C9B810
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, long changeValue); // 0x0000000188C9B7C8-0x0000000188C9B7E4
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<long> getter, DOSetter<long> setter, float elapsed, long startValue, long changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000188C9B644-0x0000000188C9B7C8
	}

	public class UlongPlugin : ABSTweenPlugin<ulong, ulong, NoOptions> // TypeDefIndex: 86487
	{
		// Constructors
		public UlongPlugin(); // 0x0000000188CA5498-0x0000000188CA54C0
	
		// Methods
		public override void Reset(TweenerCore<ulong, ulong, NoOptions> t); // 0x0000000186805BA0-0x0000000186805BB0
		public override void SetFrom(TweenerCore<ulong, ulong, NoOptions> t, bool isRelative); // 0x0000000188CA5414-0x0000000188CA5498
		public override void SetFrom(TweenerCore<ulong, ulong, NoOptions> t, ulong fromValue, bool setImmediately, bool isRelative); // 0x0000000188C9B894-0x0000000188C9B924
		public override ulong ConvertToStartValue(TweenerCore<ulong, ulong, NoOptions> t, ulong value); // 0x0000000187239520-0x0000000187239530
		public override void SetRelativeEndValue(TweenerCore<ulong, ulong, NoOptions> t); // 0x0000000188C9B924-0x0000000188C9B950
		public override void SetChangeValue(TweenerCore<ulong, ulong, NoOptions> t); // 0x0000000188C9B7E4-0x0000000188C9B810
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, ulong changeValue); // 0x0000000188CA53D4-0x0000000188CA5414
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<ulong> getter, DOSetter<ulong> setter, float elapsed, ulong startValue, ulong changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000188CA51F4-0x0000000188CA53D4
	}

	public class Vector3ArrayPlugin : ABSTweenPlugin<Vector3, Vector3[], Vector3ArrayOptions> // TypeDefIndex: 86488
	{
		// Constructors
		public Vector3ArrayPlugin(); // 0x0000000188CA63B4-0x0000000188CA63DC
	
		// Methods
		public override void Reset(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t); // 0x0000000188CA0A40-0x0000000188CA0A94
		public override void SetFrom(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool isRelative); // 0x0000000186805BA0-0x0000000186805BB0
		public override void SetFrom(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, Vector3[] fromValue, bool setImmediately, bool isRelative); // 0x0000000186805BA0-0x0000000186805BB0
		public override Vector3[] ConvertToStartValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, Vector3 value); // 0x0000000188CA5888-0x0000000188CA598C
		public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t); // 0x0000000188CA6254-0x0000000188CA63B4
		public override void SetChangeValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t); // 0x0000000188CA6110-0x0000000188CA6254
		public override float GetSpeedBasedDuration(Vector3ArrayOptions options, float unitsXSecond, Vector3[] changeValue); // 0x0000000188CA606C-0x0000000188CA6110
		public override void EvaluateAndApply(Vector3ArrayOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3[] startValue, Vector3[] changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000188CA598C-0x0000000188CA606C
	}

	public class PathPlugin : ABSTweenPlugin<Vector3, Path, PathOptions> // TypeDefIndex: 86489
	{
		// Fields
		public const float MinLookAhead = 0.0001f; // Metadata: 0x026455FF
	
		// Constructors
		public PathPlugin(); // 0x0000000188C9D5D0-0x0000000188C9D5F8
	
		// Methods
		public override void Reset(TweenerCore<Vector3, Path, PathOptions> t); // 0x0000000188C9BEB0-0x0000000188C9BF24
		public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, bool isRelative); // 0x0000000186805BA0-0x0000000186805BB0
		public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, Path fromValue, bool setImmediately, bool isRelative); // 0x0000000186805BA0-0x0000000186805BB0
		public static ABSTweenPlugin<Vector3, Path, PathOptions> Get(); // 0x0000000188C9BE80-0x0000000188C9BEB0
		public override Path ConvertToStartValue(TweenerCore<Vector3, Path, PathOptions> t, Vector3 value); // 0x0000000188C9BA10-0x0000000188C9BA2C
		public override void SetRelativeEndValue(TweenerCore<Vector3, Path, PathOptions> t); // 0x0000000188C9D4C8-0x0000000188C9D5D0
		public override void SetChangeValue(TweenerCore<Vector3, Path, PathOptions> t); // 0x0000000188C9BF24-0x0000000188C9C3E0
		public override float GetSpeedBasedDuration(PathOptions options, float unitsXSecond, Path changeValue); // 0x0000000188C9BE60-0x0000000188C9BE80
		public override void EvaluateAndApply(PathOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Path startValue, Path changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000188C9BA60-0x0000000188C9BE60
		public void SetOrientation(PathOptions options, DG.Tweening.Tween t, Path path, float pathPerc, Vector3 tPos, UpdateNotice updateNotice); // 0x0000000188C9C3E0-0x0000000188C9D4C8
		private Vector3 DivideVectorByVector(Vector3 vector, Vector3 byVector); // 0x0000000188C9BA2C-0x0000000188C9BA60
		private Vector3 MultiplyVectorByVector(Vector3 vector, Vector3 byVector); // 0x0000000187239710-0x0000000187239750
	}

	public class ColorPlugin : ABSTweenPlugin<UnityEngine.Color, UnityEngine.Color, ColorOptions> // TypeDefIndex: 86490
	{
		// Constructors
		public ColorPlugin(); // 0x0000000186AF0DE0-0x0000000186AF0E10
	
		// Methods
		public override void Reset(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t); // 0x0000000186805BA0-0x0000000186805BB0
		public override void SetFrom(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t, bool isRelative); // 0x0000000188C982B8-0x0000000188C9839C
		public override void SetFrom(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t, UnityEngine.Color fromValue, bool setImmediately, bool isRelative); // 0x0000000188C9839C-0x0000000188C984D4
		public override UnityEngine.Color ConvertToStartValue(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t, UnityEngine.Color value); // 0x00000001872396D0-0x00000001872396E0
		public override void SetRelativeEndValue(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t); // 0x0000000188C984D4-0x0000000188C98528
		public override void SetChangeValue(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t); // 0x0000000186CCD4A0-0x0000000186CCD4F0
		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, UnityEngine.Color changeValue); // 0x0000000188C7A2EC-0x0000000188C7A2FC
		public override void EvaluateAndApply(ColorOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<UnityEngine.Color> getter, DOSetter<UnityEngine.Color> setter, float elapsed, UnityEngine.Color startValue, UnityEngine.Color changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000185E0ED90-0x0000000185E0EF30
	}

	public class IntPlugin : ABSTweenPlugin<int, int, NoOptions> // TypeDefIndex: 86491
	{
		// Constructors
		public IntPlugin(); // 0x0000000188C9B224-0x0000000188C9B24C
	
		// Methods
		public override void Reset(TweenerCore<int, int, NoOptions> t); // 0x0000000186805BA0-0x0000000186805BB0
		public override void SetFrom(TweenerCore<int, int, NoOptions> t, bool isRelative); // 0x0000000188C9B17C-0x0000000188C9B1FC
		public override void SetFrom(TweenerCore<int, int, NoOptions> t, int fromValue, bool setImmediately, bool isRelative); // 0x0000000188C9B0F0-0x0000000188C9B17C
		public override int ConvertToStartValue(TweenerCore<int, int, NoOptions> t, int value); // 0x00000001872396F0-0x0000000187239700
		public override void SetRelativeEndValue(TweenerCore<int, int, NoOptions> t); // 0x0000000188C9B1FC-0x0000000188C9B224
		public override void SetChangeValue(TweenerCore<int, int, NoOptions> t); // 0x0000000188C9B0C8-0x0000000188C9B0F0
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, int changeValue); // 0x0000000188C9B0AC-0x0000000188C9B0C8
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<int> getter, DOSetter<int> setter, float elapsed, int startValue, int changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000188C9AF38-0x0000000188C9B0AC
	}

	public class QuaternionPlugin : ABSTweenPlugin<Quaternion, Vector3, QuaternionOptions> // TypeDefIndex: 86492
	{
		// Constructors
		public QuaternionPlugin(); // 0x0000000188CA0240-0x0000000188CA0268
	
		// Methods
		public override void Reset(TweenerCore<Quaternion, Vector3, QuaternionOptions> t); // 0x0000000186805BA0-0x0000000186805BB0
		public override void SetFrom(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool isRelative); // 0x0000000188C9FD2C-0x0000000188CA001C
		public override void SetFrom(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Vector3 fromValue, bool setImmediately, bool isRelative); // 0x0000000188CA001C-0x0000000188CA01CC
		public override Vector3 ConvertToStartValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Quaternion value); // 0x0000000188C9F278-0x0000000188C9F2A8
		public override void SetRelativeEndValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t); // 0x0000000188CA01CC-0x0000000188CA0240
		public override void SetChangeValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t); // 0x0000000188C9FAA0-0x0000000188C9FD2C
		public override float GetSpeedBasedDuration(QuaternionOptions options, float unitsXSecond, Vector3 changeValue); // 0x0000000188C9FA7C-0x0000000188C9FAA0
		public override void EvaluateAndApply(QuaternionOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000188C9F2A8-0x0000000188C9F758
		private Vector3 GetEulerValForCalculations(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Vector3 val, Vector3 counterVal); // 0x0000000188C9F758-0x0000000188C9FA7C
		private Vector3 FlipEulerAngles(Vector3 euler); // 0x0000000187239770-0x00000001872397B0
	}

	public class RectOffsetPlugin : ABSTweenPlugin<RectOffset, RectOffset, NoOptions> // TypeDefIndex: 86493
	{
		// Fields
		private static RectOffset _r; // 0x00
	
		// Constructors
		public RectOffsetPlugin(); // 0x0000000188CA1178-0x0000000188CA11A0
		static RectOffsetPlugin(); // 0x0000000188CA10FC-0x0000000188CA1178
	
		// Methods
		public override void Reset(TweenerCore<RectOffset, RectOffset, NoOptions> t); // 0x0000000188CA0A40-0x0000000188CA0A94
		public override void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, bool isRelative); // 0x0000000188CA0C14-0x0000000188CA0DB8
		public override void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset fromValue, bool setImmediately, bool isRelative); // 0x0000000188CA0DB8-0x0000000188CA0FD8
		public override RectOffset ConvertToStartValue(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset value); // 0x0000000188CA0268-0x0000000188CA0330
		public override void SetRelativeEndValue(TweenerCore<RectOffset, RectOffset, NoOptions> t); // 0x0000000188CA0FD8-0x0000000188CA10FC
		public override void SetChangeValue(TweenerCore<RectOffset, RectOffset, NoOptions> t); // 0x0000000188CA0A94-0x0000000188CA0C14
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, RectOffset changeValue); // 0x0000000188CA096C-0x0000000188CA0A40
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, float elapsed, RectOffset startValue, RectOffset changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000188CA0330-0x0000000188CA096C
	}

	public class RectPlugin : ABSTweenPlugin<Rect, Rect, RectOptions> // TypeDefIndex: 86494
	{
		// Constructors
		public RectPlugin(); // 0x0000000188CA194C-0x0000000188CA1974
	
		// Methods
		public override void Reset(TweenerCore<Rect, Rect, RectOptions> t); // 0x0000000186805BA0-0x0000000186805BB0
		public override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, bool isRelative); // 0x0000000188CA1578-0x0000000188CA1718
		public override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, Rect fromValue, bool setImmediately, bool isRelative); // 0x0000000188CA1718-0x0000000188CA18D8
		public override Rect ConvertToStartValue(TweenerCore<Rect, Rect, RectOptions> t, Rect value); // 0x00000001872396D0-0x00000001872396E0
		public override void SetRelativeEndValue(TweenerCore<Rect, Rect, RectOptions> t); // 0x0000000188CA18D8-0x0000000188CA194C
		public override void SetChangeValue(TweenerCore<Rect, Rect, RectOptions> t); // 0x0000000188CA14FC-0x0000000188CA1578
		public override float GetSpeedBasedDuration(RectOptions options, float unitsXSecond, Rect changeValue); // 0x0000000188CA1478-0x0000000188CA14FC
		public override void EvaluateAndApply(RectOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Rect> getter, DOSetter<Rect> setter, float elapsed, Rect startValue, Rect changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000188CA11A0-0x0000000188CA1478
	}

	public class UintPlugin : ABSTweenPlugin<uint, uint, UintOptions> // TypeDefIndex: 86495
	{
		// Constructors
		public UintPlugin(); // 0x0000000188CA51CC-0x0000000188CA51F4
	
		// Methods
		public override void Reset(TweenerCore<uint, uint, UintOptions> t); // 0x0000000186805BA0-0x0000000186805BB0
		public override void SetFrom(TweenerCore<uint, uint, UintOptions> t, bool isRelative); // 0x0000000188CA514C-0x0000000188CA51CC
		public override void SetFrom(TweenerCore<uint, uint, UintOptions> t, uint fromValue, bool setImmediately, bool isRelative); // 0x0000000188C9B0F0-0x0000000188C9B17C
		public override uint ConvertToStartValue(TweenerCore<uint, uint, UintOptions> t, uint value); // 0x00000001872396F0-0x0000000187239700
		public override void SetRelativeEndValue(TweenerCore<uint, uint, UintOptions> t); // 0x0000000188C9B1FC-0x0000000188C9B224
		public override void SetChangeValue(TweenerCore<uint, uint, UintOptions> t); // 0x0000000188CA50FC-0x0000000188CA514C
		public override float GetSpeedBasedDuration(UintOptions options, float unitsXSecond, uint changeValue); // 0x0000000188CA50D8-0x0000000188CA50FC
		public override void EvaluateAndApply(UintOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<uint> getter, DOSetter<uint> setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000188CA4F3C-0x0000000188CA50D8
	}

	public class Vector2Plugin : ABSTweenPlugin<Vector2, Vector2, VectorOptions> // TypeDefIndex: 86496
	{
		// Constructors
		public Vector2Plugin(); // 0x000000018663FD30-0x000000018663FD60
	
		// Methods
		public override void Reset(TweenerCore<Vector2, Vector2, VectorOptions> t); // 0x0000000186805BA0-0x0000000186805BB0
		public override void SetFrom(TweenerCore<Vector2, Vector2, VectorOptions> t, bool isRelative); // 0x0000000188CA56AC-0x0000000188CA5804
		public override void SetFrom(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 fromValue, bool setImmediately, bool isRelative); // 0x0000000188CA54EC-0x0000000188CA56AC
		public override Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 value); // 0x0000000187239520-0x0000000187239530
		public override void SetRelativeEndValue(TweenerCore<Vector2, Vector2, VectorOptions> t); // 0x0000000188CA5804-0x0000000188CA5874
		public override void SetChangeValue(TweenerCore<Vector2, Vector2, VectorOptions> t); // 0x0000000185E0F7A0-0x0000000185E0F820
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector2 changeValue); // 0x0000000188CA54C0-0x0000000188CA54EC
		public override void EvaluateAndApply(VectorOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x000000018604A870-0x000000018604A9D0
	}

	public class Vector4Plugin : ABSTweenPlugin<Vector4, Vector4, VectorOptions> // TypeDefIndex: 86497
	{
		// Constructors
		public Vector4Plugin(); // 0x0000000188CA73C8-0x0000000188CA73F0
	
		// Methods
		public override void Reset(TweenerCore<Vector4, Vector4, VectorOptions> t); // 0x0000000186805BA0-0x0000000186805BB0
		public override void SetFrom(TweenerCore<Vector4, Vector4, VectorOptions> t, bool isRelative); // 0x0000000188CA6E90-0x0000000188CA707C
		public override void SetFrom(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 fromValue, bool setImmediately, bool isRelative); // 0x0000000188CA707C-0x0000000188CA73C8
		public override Vector4 ConvertToStartValue(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 value); // 0x00000001872396D0-0x00000001872396E0
		public override void SetRelativeEndValue(TweenerCore<Vector4, Vector4, VectorOptions> t); // 0x0000000188C984D4-0x0000000188C98528
		public override void SetChangeValue(TweenerCore<Vector4, Vector4, VectorOptions> t); // 0x0000000188CA6D70-0x0000000188CA6E90
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector4 changeValue); // 0x0000000188CA6D4C-0x0000000188CA6D70
		public override void EvaluateAndApply(VectorOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector4> getter, DOSetter<Vector4> setter, float elapsed, Vector4 startValue, Vector4 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000188CA6860-0x0000000188CA6D4C
	}

	public class StringPlugin : ABSTweenPlugin<string, string, StringOptions> // TypeDefIndex: 86498
	{
		// Fields
		private static readonly StringBuilder _Buffer; // 0x00
		private static readonly List<char> _OpenedTags; // 0x08
	
		// Constructors
		public StringPlugin(); // 0x0000000188CA3594-0x0000000188CA35BC
		static StringPlugin(); // 0x0000000188CA34B4-0x0000000188CA3594
	
		// Methods
		public override void SetFrom(TweenerCore<string, string, StringOptions> t, bool isRelative); // 0x0000000188CA3428-0x0000000188CA34B4
		public override void SetFrom(TweenerCore<string, string, StringOptions> t, string fromValue, bool setImmediately, bool isRelative); // 0x0000000188CA3360-0x0000000188CA3428
		public override void Reset(TweenerCore<string, string, StringOptions> t); // 0x0000000188CA2FB4-0x0000000188CA302C
		public override string ConvertToStartValue(TweenerCore<string, string, StringOptions> t, string value); // 0x0000000187239520-0x0000000187239530
		public override void SetRelativeEndValue(TweenerCore<string, string, StringOptions> t); // 0x0000000186805BA0-0x0000000186805BB0
		public override void SetChangeValue(TweenerCore<string, string, StringOptions> t); // 0x0000000188CA30F8-0x0000000188CA3360
		public override float GetSpeedBasedDuration(StringOptions options, float unitsXSecond, string changeValue); // 0x0000000188CA2F60-0x0000000188CA2FB4
		public override void EvaluateAndApply(StringOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<string> getter, DOSetter<string> setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000188CA2AB4-0x0000000188CA2F60
		private StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled); // 0x0000000188CA2450-0x0000000188CA2AB4
		private char[] ScrambledCharsToUse(StringOptions options); // 0x0000000188CA302C-0x0000000188CA30F8
	}

	internal static class StringPluginExtensions // TypeDefIndex: 86499
	{
		// Fields
		public static readonly char[] ScrambledCharsAll; // 0x00
		public static readonly char[] ScrambledCharsUppercase; // 0x08
		public static readonly char[] ScrambledCharsLowercase; // 0x10
		public static readonly char[] ScrambledCharsNumerals; // 0x18
		private static int _lastRndSeed; // 0x20
	
		// Constructors
		static StringPluginExtensions(); // 0x0000000188CA2250-0x0000000188CA2450
	
		// Extension methods
		internal static void ScrambleChars(this char[] chars); // 0x0000000188CA21B8-0x0000000188CA2250
		internal static StringBuilder AppendScrambledChars(this StringBuilder buffer, int length, char[] chars); // 0x0000000188CA2074-0x0000000188CA21B8
	}

	public class FloatPlugin : ABSTweenPlugin<float, float, FloatOptions> // TypeDefIndex: 86500
	{
		// Constructors
		public FloatPlugin(); // 0x00000001860A0F00-0x00000001860A0F30
	
		// Methods
		public override void Reset(TweenerCore<float, float, FloatOptions> t); // 0x0000000186805BA0-0x0000000186805BB0
		public override void SetFrom(TweenerCore<float, float, FloatOptions> t, bool isRelative); // 0x0000000188C9AD60-0x0000000188C9AE2C
		public override void SetFrom(TweenerCore<float, float, FloatOptions> t, float fromValue, bool setImmediately, bool isRelative); // 0x0000000188C9AE2C-0x0000000188C9AF0C
		public override float ConvertToStartValue(TweenerCore<float, float, FloatOptions> t, float value); // 0x00000001872396C0-0x00000001872396D0
		public override void SetRelativeEndValue(TweenerCore<float, float, FloatOptions> t); // 0x0000000188C9AF0C-0x0000000188C9AF38
		public override void SetChangeValue(TweenerCore<float, float, FloatOptions> t); // 0x00000001863C2330-0x00000001863C2360
		public override float GetSpeedBasedDuration(FloatOptions options, float unitsXSecond, float changeValue); // 0x0000000188C9AD48-0x0000000188C9AD60
		public override void EvaluateAndApply(FloatOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<float> getter, DOSetter<float> setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000185095FF0-0x00000001850962E0
	}

	public class Vector3Plugin : ABSTweenPlugin<Vector3, Vector3, VectorOptions> // TypeDefIndex: 86501
	{
		// Constructors
		public Vector3Plugin(); // 0x0000000186A79B90-0x0000000186A79BC0
	
		// Methods
		public override void Reset(TweenerCore<Vector3, Vector3, VectorOptions> t); // 0x0000000186805BA0-0x0000000186805BB0
		public override void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, bool isRelative); // 0x0000000188CA63DC-0x0000000188CA65DC
		public override void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 fromValue, bool setImmediately, bool isRelative); // 0x0000000188CA65DC-0x0000000188CA6860
		public override Vector3 ConvertToStartValue(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 value); // 0x00000001872396A0-0x00000001872396C0
		public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3, VectorOptions> t); // 0x0000000188CA01CC-0x0000000188CA0240
		public override void SetChangeValue(TweenerCore<Vector3, Vector3, VectorOptions> t); // 0x0000000185E0FBE0-0x0000000185E0FC80
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector3 changeValue); // 0x0000000188C9FA7C-0x0000000188C9FAA0
		public override void EvaluateAndApply(VectorOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x00000001861D46B0-0x00000001861D47F0
	}
}

namespace DG.Tweening.Plugins.Core
{
	public interface ITPlugin<T1, out T2, out TPlugOptions, TPlugin> // TypeDefIndex: 86514
	{
	}

	internal static class SpecialPluginsUtils // TypeDefIndex: 86515
	{
		// Methods
		internal static bool SetLookAt(TweenerCore<Quaternion, Vector3, QuaternionOptions> t); // 0x0000000188CA1D10-0x0000000188CA1E68
		internal static bool SetPunch(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t); // 0x0000000188CA1E68-0x0000000188CA2014
		internal static bool SetShake(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t); // 0x0000000188CA2014-0x0000000188CA204C
		internal static bool SetCameraShakePosition(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t); // 0x0000000188CA1AEC-0x0000000188CA1D10
	}

	public interface IPlugSetter<T1, out T2, TPlugin, out TPlugOptions> // TypeDefIndex: 86516
	{
		// Methods
		DOGetter<T1> Getter();
		DOSetter<T1> Setter();
		T2 EndValue();
		TPlugOptions GetOptions();
	}

	public interface ITweenPlugin // TypeDefIndex: 86517
	{
	}

	public abstract class ABSTweenPlugin<T1, T2, TPlugOptions> : ITweenPlugin // TypeDefIndex: 86518
		where TPlugOptions : struct, IPlugOptions
	{
		// Constructors
		protected ABSTweenPlugin();
	
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

	internal static class PluginsManager // TypeDefIndex: 86519
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
		private const int _MaxCustomPlugins = 20; // Metadata: 0x02645607
		private static Dictionary<System.Type, ITweenPlugin> _customPlugins; // 0x80
	
		// Methods
		internal static ABSTweenPlugin<T1, T2, TPlugOptions> GetDefaultPlugin<T1, T2, TPlugOptions>()
			where TPlugOptions : struct, IPlugOptions;
		public static ABSTweenPlugin<T1, T2, TPlugOptions> GetCustomPlugin<TPlugin, T1, T2, TPlugOptions>()
			where TPlugin : ITweenPlugin, new()
			where TPlugOptions : struct, IPlugOptions;
		internal static void PurgeAll(); // 0x0000000188C9ED2C-0x0000000188C9EFF0
	}
}

namespace DG.Tweening.Plugins.Core.PathCore
{
	internal class CubicBezierDecoder : ABSPathDecoder // TypeDefIndex: 86520
	{
		// Fields
		private static readonly ControlPoint[] _PartialControlPs; // 0x00
		private static readonly Vector3[] _PartialWps; // 0x08
	
		// Properties
		internal override int minInputWaypoints { get; } // 0x00000001872396E0-0x00000001872396F0 
	
		// Constructors
		public CubicBezierDecoder(); // 0x0000000186805BA0-0x0000000186805BB0
		static CubicBezierDecoder(); // 0x0000000188C99438-0x0000000188C994E4
	
		// Methods
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath); // 0x0000000188C986C4-0x0000000188C98C20
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints); // 0x0000000188C98C20-0x0000000188C98EB8
		internal void SetTimeToLengthTables(Path p, int subdivisions); // 0x0000000188C98EB8-0x0000000188C990C0
		internal void SetWaypointsLengths(Path p, int subdivisions); // 0x0000000188C990C0-0x0000000188C99438
	}

	[Serializable]
	public struct ControlPoint // TypeDefIndex: 86521
	{
		// Fields
		public Vector3 a; // 0x00
		public Vector3 b; // 0x0C
	
		// Constructors
		public ControlPoint(Vector3 a, Vector3 b); // 0x0000000187233BB0-0x0000000187233BD0
	
		// Methods
		public static ControlPoint operator +(ControlPoint cp, Vector3 v); // 0x0000000188C98618-0x0000000188C986C4
		public override string ToString(); // 0x0000000188C98528-0x0000000188C98618
	}

	internal abstract class ABSPathDecoder // TypeDefIndex: 86522
	{
		// Properties
		internal abstract int minInputWaypoints { get; }
	
		// Constructors
		protected ABSPathDecoder(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		internal abstract void FinalizePath(Path p, Vector3[] wps, bool isClosedPath);
		internal abstract Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints);
	}

	internal class CatmullRomDecoder : ABSPathDecoder // TypeDefIndex: 86523
	{
		// Fields
		private static readonly ControlPoint[] _PartialControlPs; // 0x00
		private static readonly Vector3[] _PartialWps; // 0x08
	
		// Properties
		internal override int minInputWaypoints { get; } // 0x00000001872328C0-0x00000001872328D0 
	
		// Constructors
		public CatmullRomDecoder(); // 0x0000000186805BA0-0x0000000186805BB0
		static CatmullRomDecoder(); // 0x0000000188C9820C-0x0000000188C982B8
	
		// Methods
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath); // 0x0000000188C973E0-0x0000000188C976F4
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints); // 0x0000000188C976F4-0x0000000188C97BD8
		internal void SetTimeToLengthTables(Path p, int subdivisions); // 0x0000000188C97BD8-0x0000000188C97DE0
		internal void SetWaypointsLengths(Path p, int subdivisions); // 0x0000000188C97DE0-0x0000000188C9820C
	}

	internal class LinearDecoder : ABSPathDecoder // TypeDefIndex: 86524
	{
		// Properties
		internal override int minInputWaypoints { get; } // 0x00000001872328C0-0x00000001872328D0 
	
		// Constructors
		public LinearDecoder(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath); // 0x0000000188C9B24C-0x0000000188C9B29C
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints); // 0x0000000188C9B29C-0x0000000188C9B45C
		internal void SetTimeToLengthTables(Path p, int subdivisions); // 0x0000000188C9B45C-0x0000000188C9B644
		internal void SetWaypointsLengths(Path p, int subdivisions); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class Path // TypeDefIndex: 86525
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
		internal int minInputWaypoints { get; } // 0x0000000188C9ED08-0x0000000188C9ED2C 
	
		// Constructors
		public Path(PathType type, Vector3[] waypoints, int subdivisionsXSegment, UnityEngine.Color? gizmoColor = default); // 0x0000000188C9EB84-0x0000000188C9ED08
		internal Path(); // 0x0000000187239750-0x0000000187239770
	
		// Methods
		internal void FinalizePath(bool isClosedPath, AxisConstraint lockPositionAxes, Vector3 currTargetVal); // 0x0000000188C9E764-0x0000000188C9E86C
		internal Vector3 GetPoint(float perc, bool convertToConstantPerc = false /* Metadata: 0x02645608 */); // 0x0000000188C9E964-0x0000000188C9E9DC
		internal float ConvertToConstantPathPerc(float perc); // 0x0000000188C9DEA0-0x0000000188C9DFD0
		internal int GetWaypointIndexFromPerc(float perc, bool isMovingForward); // 0x0000000188C9E9DC-0x0000000188C9EA7C
		internal static Vector3[] GetDrawPoints(Path p, int drawSubdivisionsXSegment); // 0x0000000188C9E86C-0x0000000188C9E964
		internal static void RefreshNonLinearDrawWps(Path p); // 0x0000000188C9EA7C-0x0000000188C9EB84
		internal void Destroy(); // 0x0000000188C9E098-0x0000000188C9E1F4
		internal Path CloneIncremental(int loopIncrement); // 0x0000000188C9D86C-0x0000000188C9DEA0
		internal void AssignWaypoints(Vector3[] newWps, bool cloneWps = false /* Metadata: 0x02645609 */); // 0x0000000188C9D784-0x0000000188C9D86C
		internal void AssignDecoder(PathType pathType); // 0x0000000188C9D5F8-0x0000000188C9D784
		internal void Draw(); // 0x0000000188C9E75C-0x0000000188C9E764
		private static void Draw(Path p); // 0x0000000188C9E1F4-0x0000000188C9E75C
		private static Vector3 ConvertToDrawPoint(Vector3 wp, PathOptions plugOptions); // 0x0000000188C9DFD0-0x0000000188C9E098
	}
}

namespace DG.Tweening.Plugins.Options
{
	public interface IPlugOptions // TypeDefIndex: 86502
	{
		// Methods
		void Reset();
	}

	public enum OrientType // TypeDefIndex: 86503
	{
		None = 0,
		ToPath = 1,
		LookAtTransform = 2,
		LookAtPosition = 3
	}

	public struct PathOptions : IPlugOptions // TypeDefIndex: 86504
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
		public void Reset(); // 0x0000000188C9B978-0x0000000188C9BA10
	}

	public struct QuaternionOptions : IPlugOptions // TypeDefIndex: 86505
	{
		// Fields
		public DG.Tweening.RotateMode rotateMode; // 0x00
		public AxisConstraint axisConstraint; // 0x04
		public Vector3 up; // 0x08
		public bool dynamicLookAt; // 0x14
		public Vector3 dynamicLookAtWorldPosition; // 0x18
	
		// Methods
		public void Reset(); // 0x0000000188C9F22C-0x0000000188C9F278
	}

	public struct UintOptions : IPlugOptions // TypeDefIndex: 86506
	{
		// Fields
		public bool isNegativeChangeValue; // 0x00
	
		// Methods
		public void Reset(); // 0x0000000187233BD0-0x0000000187233BE0
	}

	public struct Vector3ArrayOptions : IPlugOptions // TypeDefIndex: 86507
	{
		// Fields
		public AxisConstraint axisConstraint; // 0x00
		public bool snapping; // 0x04
		internal float[] durations; // 0x08
	
		// Methods
		public void Reset(); // 0x0000000188CA5874-0x0000000188CA5888
	}

	public struct NoOptions : IPlugOptions // TypeDefIndex: 86508
	{
		// Methods
		public void Reset(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public struct ColorOptions : IPlugOptions // TypeDefIndex: 86509
	{
		// Fields
		public bool alphaOnly; // 0x00
	
		// Methods
		public void Reset(); // 0x0000000187233BD0-0x0000000187233BE0
	}

	public struct FloatOptions : IPlugOptions // TypeDefIndex: 86510
	{
		// Fields
		public bool snapping; // 0x00
	
		// Methods
		public void Reset(); // 0x0000000187233BD0-0x0000000187233BE0
	}

	public struct RectOptions : IPlugOptions // TypeDefIndex: 86511
	{
		// Fields
		public bool snapping; // 0x00
	
		// Methods
		public void Reset(); // 0x0000000187233BD0-0x0000000187233BE0
	}

	public struct StringOptions : IPlugOptions // TypeDefIndex: 86512
	{
		// Fields
		public bool richTextEnabled; // 0x00
		public ScrambleMode scrambleMode; // 0x04
		public char[] scrambledChars; // 0x08
		internal int startValueStrippedLength; // 0x10
		internal int changeValueStrippedLength; // 0x14
	
		// Methods
		public void Reset(); // 0x0000000188CA204C-0x0000000188CA2074
	}

	public struct VectorOptions : IPlugOptions // TypeDefIndex: 86513
	{
		// Fields
		public AxisConstraint axisConstraint; // 0x00
		public bool snapping; // 0x04
	
		// Methods
		public void Reset(); // 0x00000001872397E0-0x00000001872397F0
	}
}
