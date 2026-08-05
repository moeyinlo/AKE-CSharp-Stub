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

// Image 41: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59195-59395
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

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 59395
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_50 _4EF0676A416B9CCF117C378BDCB6C5CA0EA9505154E3F0F7CC8570285DB79663; // 0x00 // Static value (base64): QQBCAEMARABFAEYARwBIAEkASgBLAEwATQBOAE8AUABRAFIAUwBUAFUAVgBYAFkAWgA= - Metadata: 0x0234C91C
	internal static readonly __StaticArrayInitTypeSize_20 _921D53955C220A863C9C5D33DD45329C6F74471C522EA5D46EA838D8D4838055; // 0x32 // Static value (base64): MQAyADMANAA1ADYANwA4ADkAMAA= - Metadata: 0x0234C954
	internal static readonly __StaticArrayInitTypeSize_120 A203B1199E78DE3BB75B28FC520ED2F86ADB2749BFC52E3ACA275A3BE2587678; // 0x46 // Static value (base64): QQBCAEMARABFAEYARwBIAEkASgBLAEwATQBOAE8AUABRAFIAUwBUAFUAVgBYAFkAWgBhAGIAYwBkAGUAZgBnAGgAaQBqAGsAbABtAG4AbwBwAHEAcgBzAHQAdQB2AHgAeQB6ADEAMgAzADQANQA2ADcAOAA5ADAA - Metadata: 0x0234C96C
	internal static readonly __StaticArrayInitTypeSize_50 C845A807AA8EC73757DC1B07EA49311061FEDECA35AFFE91C5474E0814925020; // 0xBE // Static value (base64): YQBiAGMAZABlAGYAZwBoAGkAagBrAGwAbQBuAG8AcABxAHIAcwB0AHUAdgB4AHkAegA= - Metadata: 0x0234C9EC

	// Nested types
	private struct __StaticArrayInitTypeSize_20 // TypeDefIndex: 59392
	{
	}

	private struct __StaticArrayInitTypeSize_50 // TypeDefIndex: 59393
	{
	}

	private struct __StaticArrayInitTypeSize_120 // TypeDefIndex: 59394
	{
	}
}

namespace DG.Tweening
{
	public enum AutoPlay // TypeDefIndex: 59196
	{
		None = 0,
		AutoPlaySequences = 1,
		AutoPlayTweeners = 2,
		All = 3
	}

	[Flags]
	public enum AxisConstraint // TypeDefIndex: 59197
	{
		None = 0,
		X = 2,
		Y = 4,
		Z = 8,
		W = 16
	}

	public struct Color2 // TypeDefIndex: 59198
	{
		// Fields
		public UnityEngine.Color ca; // 0x00
		public UnityEngine.Color cb; // 0x10
	
		// Constructors
		public Color2(UnityEngine.Color ca, UnityEngine.Color cb); // 0x0000000184D8C810-0x0000000184D8C820
	
		// Methods
		public static Color2 operator +(Color2 c1, Color2 c2); // 0x000000018695A918-0x000000018695A994
		public static Color2 operator -(Color2 c1, Color2 c2); // 0x000000018695A9F4-0x000000018695AA70
		public static Color2 operator *(Color2 c1, float f); // 0x000000018695A994-0x000000018695A9F4
	}

	public delegate void TweenCallback(); // TypeDefIndex: 59199; 0x00000001853DEDB8-0x00000001853DEDC8

	public delegate void TweenCallback<in T>(T value); // TypeDefIndex: 59200; 0x00000000-0x00000000

	public delegate float EaseFunction(float time, float duration, float overshootOrAmplitude, float period); // TypeDefIndex: 59201; 0x000000018695F0D4-0x000000018695F0E8

	public static class DOCurve // TypeDefIndex: 59203
	{
		// Nested types
		public static class CubicBezier // TypeDefIndex: 59202
		{
			// Methods
			public static Vector3 GetPointOnSegment(Vector3 startPoint, Vector3 startControlPoint, Vector3 endPoint, Vector3 endControlPoint, float factor); // 0x000000018695AA70-0x000000018695AC00
			public static Vector3[] GetSegmentPointCloud(Vector3 startPoint, Vector3 startControlPoint, Vector3 endPoint, Vector3 endControlPoint, int resolution = 10 /* Metadata: 0x0234C632 */); // 0x000000018695AC00-0x000000018695AD64
			public static void GetSegmentPointCloud(List<Vector3> addToList, Vector3 startPoint, Vector3 startControlPoint, Vector3 endPoint, Vector3 endControlPoint, int resolution = 10 /* Metadata: 0x0234C633 */); // 0x000000018695AD64-0x000000018695AEB4
		}
	}

	public class DOTween // TypeDefIndex: 59205
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
		public static LogBehaviour logBehaviour { get; set; } // 0x000000018695DDA8-0x000000018695DDF8 0x0000000184709CA0-0x0000000184709D40
		public static bool debugStoreTargetId { get; set; } // 0x000000018429EC00-0x000000018429EC40 0x000000018695DDF8-0x000000018695DE4C
		internal static bool isQuitting { get; set; } // 0x0000000184D2B300-0x0000000184D2B360 0x000000018695DE4C-0x000000018695DEC0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass67_0 // TypeDefIndex: 59204
		{
			// Fields
			public float v; // 0x10
			public DOSetter<float> setter; // 0x18
	
			// Constructors
			public __c__DisplayClass67_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _To_b__0(); // 0x0000000184D85F70-0x0000000184D85F80
			internal void _To_b__1(float x); // 0x000000018696B4E8-0x000000018696B50C
		}
	
		// Constructors
		public DOTween(); // 0x00000001841E1670-0x00000001841E1680
		static DOTween(); // 0x00000001849DE140-0x00000001849DE3B0
	
		// Methods
		public static IDOTweenInit Init(bool? recycleAllByDefault = default, bool? useSafeMode = default, LogBehaviour? logBehaviour = default); // 0x000000018695B624-0x000000018695B730
		private static void AutoInit(); // 0x00000001841A7160-0x00000001841A7230
		private static IDOTweenInit Init(DOTweenSettings settings, bool? recycleAllByDefault, bool? useSafeMode, LogBehaviour? logBehaviour); // 0x00000001847097F0-0x0000000184709CA0
		public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity); // 0x000000018695C5C0-0x000000018695C618
		public static void Clear(bool destroy = false /* Metadata: 0x0234C634 */); // 0x000000018695B188-0x000000018695B1D4
		internal static void Clear(bool destroy, bool isApplicationQuitting); // 0x000000018695AEF4-0x000000018695B188
		public static void ClearCachedTweens(); // 0x000000018695AEB4-0x000000018695AEF4
		public static int Validate(); // 0x000000018695DD68-0x000000018695DDA8
		public static void ManualUpdate(float deltaTime, float unscaledDeltaTime); // 0x000000018695B948-0x000000018695BA40
		public static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration); // 0x00000001832EE410-0x00000001832EE490
		public static TweenerCore<double, double, NoOptions> To(DOGetter<double> getter, DOSetter<double> setter, double endValue, float duration); // 0x000000018695D8E0-0x000000018695D96C
		public static TweenerCore<int, int, NoOptions> To(DOGetter<int> getter, DOSetter<int> setter, int endValue, float duration); // 0x000000018695D7B4-0x000000018695D840
		public static TweenerCore<uint, uint, UintOptions> To(DOGetter<uint> getter, DOSetter<uint> setter, uint endValue, float duration); // 0x000000018695D388-0x000000018695D414
		public static TweenerCore<long, long, NoOptions> To(DOGetter<long> getter, DOSetter<long> setter, long endValue, float duration); // 0x000000018695D144-0x000000018695D1D0
		public static TweenerCore<ulong, ulong, NoOptions> To(DOGetter<ulong> getter, DOSetter<ulong> setter, ulong endValue, float duration); // 0x000000018695D5C4-0x000000018695D650
		public static TweenerCore<string, string, StringOptions> To(DOGetter<string> getter, DOSetter<string> setter, string endValue, float duration); // 0x000000018695D414-0x000000018695D4A0
		public static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration); // 0x000000018396B590-0x000000018396B610
		public static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration); // 0x000000018695D1D0-0x000000018695D260
		public static TweenerCore<Vector4, Vector4, VectorOptions> To(DOGetter<Vector4> getter, DOSetter<Vector4> setter, Vector4 endValue, float duration); // 0x000000018695D96C-0x000000018695DA04
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration); // 0x000000018695D260-0x000000018695D300
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> To(DOGetter<UnityEngine.Color> getter, DOSetter<UnityEngine.Color> setter, UnityEngine.Color endValue, float duration); // 0x000000018695D300-0x000000018695D388
		public static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration); // 0x000000018695D52C-0x000000018695D5C4
		public static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration); // 0x000000018695D4A0-0x000000018695D52C
		public static TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration)
			where TPlugOptions : struct, IPlugOptions;
		public static TweenerCore<Vector3, Vector3, VectorOptions> ToAxis(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float endValue, float duration, AxisConstraint axisConstraint = AxisConstraint.None | AxisConstraint.X /* Metadata: 0x0234C635 */); // 0x000000018695D098-0x000000018695D144
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> ToAlpha(DOGetter<UnityEngine.Color> getter, DOSetter<UnityEngine.Color> setter, float endValue, float duration); // 0x00000001845E32F0-0x00000001845E33D0
		public static Tweener To(DOSetter<float> setter, float startValue, float endValue, float duration); // 0x000000018695D650-0x000000018695D7B4
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10 /* Metadata: 0x0234C636 */, float elasticity = 1f /* Metadata: 0x0234C637 */); // 0x000000018695BFB8-0x000000018695C304
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3f /* Metadata: 0x0234C63B */, int vibrato = 10 /* Metadata: 0x0234C63F */, float randomness = 90f /* Metadata: 0x0234C640 */, bool ignoreZAxis = true /* Metadata: 0x0234C644 */, bool fadeOut = true /* Metadata: 0x0234C645 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0234C646 */); // 0x000000018695CCFC-0x000000018695CDD0
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x0234C647 */, float randomness = 90f /* Metadata: 0x0234C648 */, bool fadeOut = true /* Metadata: 0x0234C64C */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0234C64D */); // 0x000000018695CC30-0x000000018695CCFC
		private static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut, ShakeRandomnessMode randomnessMode); // 0x000000018695C618-0x000000018695CC30
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3[] endValues, float[] durations); // 0x000000018695CE9C-0x000000018695D098
		internal static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration); // 0x000000018695D840-0x000000018695D8E0
		public static DG.Tweening.Sequence Sequence(); // 0x0000000183969080-0x00000001839690E0
		public static DG.Tweening.Sequence Sequence(object target); // 0x000000018695C564-0x000000018695C5C0
		public static int CompleteAll(bool withCallbacks = false /* Metadata: 0x0234C64E */); // 0x000000018695B1D4-0x000000018695B23C
		public static int Complete(object targetOrId, bool withCallbacks = false /* Metadata: 0x0234C64F */); // 0x000000018695B3EC-0x000000018695B468
		internal static int CompleteAndReturnKilledTot(); // 0x000000018695B310-0x000000018695B36C
		internal static int CompleteAndReturnKilledTot(object targetOrId); // 0x000000018695B2A0-0x000000018695B310
		internal static int CompleteAndReturnKilledTot(object target, object id); // 0x000000018695B36C-0x000000018695B3EC
		internal static int CompleteAndReturnKilledTotExceptFor(params object[] excludeTargetsOrIds); // 0x000000018695B23C-0x000000018695B2A0
		public static int FlipAll(); // 0x000000018695B468-0x000000018695B4C4
		public static int Flip(object targetOrId); // 0x000000018695B4C4-0x000000018695B534
		public static int GotoAll(float to, bool andPlay = false /* Metadata: 0x0234C650 */); // 0x000000018695B534-0x000000018695B5A0
		public static int Goto(object targetOrId, float to, bool andPlay = false /* Metadata: 0x0234C651 */); // 0x000000018695B5A0-0x000000018695B624
		public static int KillAll(bool complete = false /* Metadata: 0x0234C652 */); // 0x0000000183C12410-0x0000000183C12470
		public static int KillAll(bool complete, params object[] idsOrTargetsToExclude); // 0x000000018695B7A8-0x000000018695B888
		public static int Kill(object targetOrId, bool complete = false /* Metadata: 0x0234C653 */); // 0x00000001836D4610-0x00000001836D4690
		public static int Kill(object target, object id, bool complete = false /* Metadata: 0x0234C654 */); // 0x000000018695B888-0x000000018695B948
		public static int PauseAll(); // 0x000000018695BA40-0x000000018695BA9C
		public static int Pause(object targetOrId); // 0x000000018695BA9C-0x000000018695BB0C
		public static int PlayAll(); // 0x000000018695BB70-0x000000018695BBCC
		public static int Play(object targetOrId); // 0x000000018695BE64-0x000000018695BED4
		public static int Play(object target, object id); // 0x000000018695BED4-0x000000018695BF54
		public static int PlayBackwardsAll(); // 0x000000018695BBCC-0x000000018695BC28
		public static int PlayBackwards(object targetOrId); // 0x000000018695BC28-0x000000018695BC98
		public static int PlayBackwards(object target, object id); // 0x000000018695BC98-0x000000018695BD18
		public static int PlayForwardAll(); // 0x000000018695BD18-0x000000018695BD74
		public static int PlayForward(object targetOrId); // 0x000000018695BD74-0x000000018695BDE4
		public static int PlayForward(object target, object id); // 0x000000018695BDE4-0x000000018695BE64
		public static int RestartAll(bool includeDelay = true /* Metadata: 0x0234C655 */); // 0x000000018695C304-0x000000018695C368
		public static int Restart(object targetOrId, bool includeDelay = true /* Metadata: 0x0234C656 */, float changeDelayTo = -1f /* Metadata: 0x0234C657 */); // 0x000000018695C400-0x000000018695C484
		public static int Restart(object target, object id, bool includeDelay = true /* Metadata: 0x0234C65B */, float changeDelayTo = -1f /* Metadata: 0x0234C65C */); // 0x000000018695C368-0x000000018695C400
		public static int RewindAll(bool includeDelay = true /* Metadata: 0x0234C660 */); // 0x000000018695C484-0x000000018695C4E8
		public static int Rewind(object targetOrId, bool includeDelay = true /* Metadata: 0x0234C661 */); // 0x000000018695C4E8-0x000000018695C564
		public static int SmoothRewindAll(); // 0x000000018695CDD0-0x000000018695CE2C
		public static int SmoothRewind(object targetOrId); // 0x000000018695CE2C-0x000000018695CE9C
		public static int TogglePauseAll(); // 0x000000018695DA04-0x000000018695DA60
		public static int TogglePause(object targetOrId); // 0x000000018695DA60-0x000000018695DAD0
		public static bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying = false /* Metadata: 0x0234C662 */); // 0x000000018695B730-0x000000018695B7A8
		public static int TotalActiveTweens(); // 0x000000018695DB70-0x000000018695DBC0
		public static int TotalActiveTweeners(); // 0x000000018695DB20-0x000000018695DB70
		public static int TotalActiveSequences(); // 0x000000018695DAD0-0x000000018695DB20
		public static int TotalPlayingTweens(); // 0x000000018695DBC0-0x000000018695DC00
		public static int TotalTweensById(object id, bool playingOnly = false /* Metadata: 0x0234C663 */); // 0x000000018695DC00-0x000000018695DC5C
		public static List<DG.Tweening.Tween> PlayingTweens(List<DG.Tweening.Tween> fillableList = null); // 0x000000018695BF54-0x000000018695BFB8
		public static List<DG.Tweening.Tween> PausedTweens(List<DG.Tweening.Tween> fillableList = null); // 0x000000018695BB0C-0x000000018695BB70
		public static List<DG.Tweening.Tween> TweensById(object id, bool playingOnly = false /* Metadata: 0x0234C664 */, List<DG.Tweening.Tween> fillableList = null); // 0x000000018695DC5C-0x000000018695DCE8
		public static List<DG.Tweening.Tween> TweensByTarget(object target, bool playingOnly = false /* Metadata: 0x0234C665 */, List<DG.Tweening.Tween> fillableList = null); // 0x000000018695DCE8-0x000000018695DD68
		private static void InitCheck(); // 0x0000000183969420-0x00000001839694B0
		private static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null)
			where TPlugOptions : struct, IPlugOptions;
	}

	public static class DOVirtual // TypeDefIndex: 59210
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 59206
		{
			// Fields
			public float val; // 0x10
			public TweenCallback<float> onVirtualUpdate; // 0x18
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _Float_b__0(); // 0x0000000184D85F70-0x0000000184D85F80
			internal void _Float_b__1(float x); // 0x0000000184D88280-0x0000000184D88290
			internal void _Float_b__2(); // 0x000000018696A6A4-0x000000018696A6CC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 59207
		{
			// Fields
			public int val; // 0x10
			public TweenCallback<int> onVirtualUpdate; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _Int_b__0(); // 0x0000000182B2E2D0-0x0000000182B2E2E0
			internal void _Int_b__1(int x); // 0x00000001814F51F0-0x00000001814F5220
			internal void _Int_b__2(); // 0x000000018696AA60-0x000000018696AA88
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 59208
		{
			// Fields
			public Vector3 val; // 0x10
			public TweenCallback<Vector3> onVirtualUpdate; // 0x20
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _Vector3_b__0(); // 0x0000000184D8C950-0x0000000184D8C970
			internal void _Vector3_b__1(Vector3 x); // 0x0000000184D8C970-0x0000000184D8C980
			internal void _Vector3_b__2(); // 0x000000018696ADF0-0x000000018696AE2C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 59209
		{
			// Fields
			public UnityEngine.Color val; // 0x10
			public TweenCallback<UnityEngine.Color> onVirtualUpdate; // 0x20
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal UnityEngine.Color _Color_b__0(); // 0x0000000182B2D510-0x0000000182B2D520
			internal void _Color_b__1(UnityEngine.Color x); // 0x0000000184D8C980-0x0000000184D8C990
			internal void _Color_b__2(); // 0x000000018696AFE8-0x000000018696B01C
		}
	
		// Methods
		public static Tweener Float(float from, float to, float duration, TweenCallback<float> onVirtualUpdate); // 0x000000018695E8F0-0x000000018695EAA4
		public static Tweener Int(int from, int to, float duration, TweenCallback<int> onVirtualUpdate); // 0x000000018695EAA4-0x000000018695EC44
		public static Tweener Vector3(Vector3 from, Vector3 to, float duration, TweenCallback<Vector3> onVirtualUpdate); // 0x000000018695EC44-0x000000018695EE08
		public static Tweener Color(UnityEngine.Color from, UnityEngine.Color to, float duration, TweenCallback<UnityEngine.Color> onVirtualUpdate); // 0x000000018695DEC0-0x000000018695E074
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType); // 0x0000000183154E30-0x0000000183154F00
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float overshoot); // 0x000000018695E4BC-0x000000018695E56C
		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float amplitude, float period); // 0x000000018695E888-0x000000018695E8F0
		public static float EasedValue(float from, float to, float lifetimePercentage, AnimationCurve easeCurve); // 0x000000018695E23C-0x000000018695E374
		public static Vector3 EasedValue(Vector3 from, Vector3 to, float lifetimePercentage, Ease easeType); // 0x000000018695E740-0x000000018695E888
		public static Vector3 EasedValue(Vector3 from, Vector3 to, float lifetimePercentage, Ease easeType, float overshoot); // 0x000000018695E374-0x000000018695E4BC
		public static Vector3 EasedValue(Vector3 from, Vector3 to, float lifetimePercentage, Ease easeType, float amplitude, float period); // 0x000000018695E134-0x000000018695E23C
		public static Vector3 EasedValue(Vector3 from, Vector3 to, float lifetimePercentage, AnimationCurve easeCurve); // 0x000000018695E56C-0x000000018695E740
		public static DG.Tweening.Tween DelayedCall(float delay, TweenCallback callback, bool ignoreTimeScale = true /* Metadata: 0x0234C666 */); // 0x000000018695E074-0x000000018695E134
	}

	public enum Ease // TypeDefIndex: 59211
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

	public class EaseFactory // TypeDefIndex: 59213
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 59212
		{
			// Fields
			public float motionDelay; // 0x10
			public EaseFunction customEase; // 0x18
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _StopMotion_b__0(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018696AD84-0x000000018696ADF0
		}
	
		// Constructors
		public EaseFactory(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static EaseFunction StopMotion(int motionFps, Ease? ease = default); // 0x000000018695EECC-0x000000018695EF68
		public static EaseFunction StopMotion(int motionFps, AnimationCurve animCurve); // 0x000000018695EF68-0x000000018695F020
		public static EaseFunction StopMotion(int motionFps, EaseFunction customEase); // 0x000000018695EE08-0x000000018695EECC
	}

	public interface IDOTweenInit // TypeDefIndex: 59214
	{
		// Methods
		IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity);
	}

	public enum LinkBehaviour // TypeDefIndex: 59215
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

	public enum PathMode // TypeDefIndex: 59216
	{
		Ignore = 0,
		Full3D = 1,
		TopDown2D = 2,
		Sidescroller2D = 3
	}

	public enum PathType // TypeDefIndex: 59217
	{
		Linear = 0,
		CatmullRom = 1,
		CubicBezier = 2
	}

	public enum RotateMode // TypeDefIndex: 59218
	{
		Fast = 0,
		FastBeyond360 = 1,
		WorldAxisAdd = 2,
		LocalAxisAdd = 3
	}

	public enum ScrambleMode // TypeDefIndex: 59219
	{
		None = 0,
		All = 1,
		Uppercase = 2,
		Lowercase = 3,
		Numerals = 4,
		Custom = 5
	}

	public enum ShakeRandomnessMode // TypeDefIndex: 59220
	{
		Full = 0,
		Harmonic = 1
	}

	public static class TweenExtensions // TypeDefIndex: 59221
	{
		// Methods
		private static void DoGoto(DG.Tweening.Tween t, float to, bool andPlay, bool withCallbacks); // 0x0000000183D307A0-0x0000000183D308C0
	
		// Extension methods
		public static void Complete(this DG.Tweening.Tween t); // 0x00000001869680D4-0x00000001869680E0
		public static void Complete(this DG.Tweening.Tween t, bool withCallbacks); // 0x00000001869680E0-0x0000000186968190
		public static void Flip(this DG.Tweening.Tween t); // 0x0000000186968478-0x000000018696851C
		public static void ForceInit(this DG.Tweening.Tween t); // 0x000000018696851C-0x00000001869685C4
		public static void Goto(this DG.Tweening.Tween t, float to, bool andPlay = false /* Metadata: 0x0234C6AB */); // 0x0000000186968848-0x0000000186968864
		public static void GotoWithCallbacks(this DG.Tweening.Tween t, float to, bool andPlay = false /* Metadata: 0x0234C6AC */); // 0x000000018696882C-0x0000000186968848
		public static void Kill(this DG.Tweening.Tween t, bool complete = false /* Metadata: 0x0234C6AD */); // 0x00000001839698F0-0x0000000183969A70
		public static void ManualUpdate(this DG.Tweening.Tween t, float deltaTime, float unscaledDeltaTime); // 0x0000000186968924-0x00000001869689E4
		public static T Pause<T>(this T t)
			where T : DG.Tweening.Tween;
		public static T Play<T>(this T t)
			where T : DG.Tweening.Tween;
		public static void PlayBackwards(this DG.Tweening.Tween t); // 0x0000000186968D60-0x0000000186968E04
		public static void PlayForward(this DG.Tweening.Tween t); // 0x0000000186968E04-0x0000000186968EA8
		public static void Restart(this DG.Tweening.Tween t, bool includeDelay = true /* Metadata: 0x0234C6AE */, float changeDelayTo = -1f /* Metadata: 0x0234C6AF */); // 0x0000000183542AF0-0x0000000183542B70
		public static void Rewind(this DG.Tweening.Tween t, bool includeDelay = true /* Metadata: 0x0234C6B3 */); // 0x0000000186968EA8-0x0000000186968F54
		public static void SmoothRewind(this DG.Tweening.Tween t); // 0x0000000186968F54-0x0000000186968FF8
		public static void TogglePause(this DG.Tweening.Tween t); // 0x0000000186968FF8-0x000000018696909C
		public static void GotoWaypoint(this DG.Tweening.Tween t, int waypointIndex, bool andPlay = false /* Metadata: 0x0234C6B4 */); // 0x00000001869685C4-0x000000018696882C
		public static YieldInstruction WaitForCompletion(this DG.Tweening.Tween t); // 0x000000018696909C-0x000000018696913C
		public static YieldInstruction WaitForRewind(this DG.Tweening.Tween t); // 0x000000018696933C-0x00000001869693DC
		public static YieldInstruction WaitForKill(this DG.Tweening.Tween t); // 0x00000001869691EC-0x000000018696928C
		public static YieldInstruction WaitForElapsedLoops(this DG.Tweening.Tween t, int elapsedLoops); // 0x000000018696913C-0x00000001869691EC
		public static YieldInstruction WaitForPosition(this DG.Tweening.Tween t, float position); // 0x000000018696928C-0x000000018696933C
		public static Coroutine WaitForStart(this DG.Tweening.Tween t); // 0x00000001869693DC-0x000000018696947C
		public static int CompletedLoops(this DG.Tweening.Tween t); // 0x0000000186968190-0x00000001869681D0
		public static float Delay(this DG.Tweening.Tween t); // 0x00000001869681D0-0x0000000186968214
		public static float ElapsedDelay(this DG.Tweening.Tween t); // 0x0000000186968284-0x00000001869682C8
		public static float Duration(this DG.Tweening.Tween t, bool includeLoops = true /* Metadata: 0x0234C6B5 */); // 0x0000000186968214-0x0000000186968284
		public static float Elapsed(this DG.Tweening.Tween t, bool includeLoops = true /* Metadata: 0x0234C6B6 */); // 0x0000000186968408-0x0000000186968478
		public static float ElapsedPercentage(this DG.Tweening.Tween t, bool includeLoops = true /* Metadata: 0x0234C6B7 */); // 0x0000000186968368-0x0000000186968408
		public static float ElapsedDirectionalPercentage(this DG.Tweening.Tween t); // 0x00000001869682C8-0x0000000186968368
		public static bool IsActive(this DG.Tweening.Tween t); // 0x0000000183405760-0x0000000183405770
		public static bool IsBackwards(this DG.Tweening.Tween t); // 0x0000000186968864-0x00000001869688A4
		public static bool IsComplete(this DG.Tweening.Tween t); // 0x0000000183405770-0x00000001834057A0
		public static bool IsInitialized(this DG.Tweening.Tween t); // 0x00000001869688A4-0x00000001869688E4
		public static bool IsPlaying(this DG.Tweening.Tween t); // 0x00000001835432E0-0x0000000183543310
		public static int Loops(this DG.Tweening.Tween t); // 0x00000001869688E4-0x0000000186968924
		public static Vector3 PathGetPoint(this DG.Tweening.Tween t, float pathPercentage); // 0x0000000186968AF4-0x0000000186968C58
		public static Vector3[] PathGetDrawPoints(this DG.Tweening.Tween t, int subdivisionsXSegment = 10 /* Metadata: 0x0234C6B8 */); // 0x00000001869689E4-0x0000000186968AF4
		public static float PathLength(this DG.Tweening.Tween t); // 0x0000000186968C58-0x0000000186968D60
	}

	public enum LoopType // TypeDefIndex: 59222
	{
		Restart = 0,
		Yoyo = 1,
		Incremental = 2
	}

	public sealed class Sequence : DG.Tweening.Tween // TypeDefIndex: 59223
	{
		// Fields
		internal readonly List<DG.Tweening.Tween> sequencedTweens; // 0x120
		private readonly List<ABSSequentiable> _sequencedObjs; // 0x128
		internal float lastTweenInsertTime; // 0x130
	
		// Constructors
		internal Sequence(); // 0x00000001839694B0-0x0000000183969580
	
		// Methods
		internal static Sequence DoPrepend(Sequence inSequence, DG.Tweening.Tween t); // 0x000000018695F1C0-0x000000018695F2FC
		internal static Sequence DoInsert(Sequence inSequence, DG.Tweening.Tween t, float atPosition); // 0x00000001839696A0-0x00000001839697F0
		internal static Sequence DoAppendInterval(Sequence inSequence, float interval); // 0x000000018396A870-0x000000018396A8F0
		internal static Sequence DoPrependInterval(Sequence inSequence, float interval); // 0x000000018695F0E8-0x000000018695F1C0
		internal static Sequence DoInsertCallback(Sequence inSequence, TweenCallback callback, float atPosition); // 0x00000001845E3440-0x00000001845E3510
		internal override float UpdateDelay(float elapsed); // 0x000000018695F2FC-0x000000018695F32C
		internal override void Reset(); // 0x0000000183C7B430-0x0000000183C7B490
		internal override bool Validate(); // 0x000000018695F32C-0x000000018695F3D0
		internal override bool Startup(); // 0x0000000183D308C0-0x0000000183D308D0
		internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, UpdateNotice updateNotice); // 0x0000000183D30AE0-0x0000000183D30B00
		internal static void Setup(Sequence s); // 0x0000000183969580-0x00000001839696A0
		internal static bool DoStartup(Sequence s); // 0x0000000183D308D0-0x0000000183D309C0
		internal static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode); // 0x0000000183D30B00-0x0000000183D30E10
		private static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, DG.Tweening.Core.Enums.UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = false /* Metadata: 0x0234C6BC */); // 0x0000000183D30E10-0x0000000183D311B0
		private static void StableSortSequencedObjs(List<ABSSequentiable> list); // 0x0000000183D309C0-0x0000000183D30A80
		private static bool IsAnyCallbackSet(Sequence s); // 0x0000000183D30A80-0x0000000183D30AE0
	}

	public static class ShortcutExtensions // TypeDefIndex: 59300
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 59224
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _DOAspect_b__0(); // 0x000000018696A664-0x000000018696A684
			internal void _DOAspect_b__1(float x); // 0x000000018696A684-0x000000018696A6A4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 59225
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal UnityEngine.Color _DOColor_b__0(); // 0x000000018696A9FC-0x000000018696AA30
			internal void _DOColor_b__1(UnityEngine.Color x); // 0x000000018696AA30-0x000000018696AA60
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 59226
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _DOFarClipPlane_b__0(); // 0x000000018696AD44-0x000000018696AD64
			internal void _DOFarClipPlane_b__1(float x); // 0x000000018696AD64-0x000000018696AD84
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 59227
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _DOFieldOfView_b__0(); // 0x000000018696B01C-0x000000018696B03C
			internal void _DOFieldOfView_b__1(float x); // 0x000000018696B03C-0x000000018696B05C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 59228
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _DONearClipPlane_b__0(); // 0x000000018696B198-0x000000018696B1B8
			internal void _DONearClipPlane_b__1(float x); // 0x000000018696B1B8-0x000000018696B1D8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 59229
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _DOOrthoSize_b__0(); // 0x000000018696B268-0x000000018696B288
			internal void _DOOrthoSize_b__1(float x); // 0x000000018696B288-0x000000018696B2A8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 59230
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Rect _DOPixelRect_b__0(); // 0x000000018696B654-0x000000018696B688
			internal void _DOPixelRect_b__1(Rect x); // 0x000000018696B688-0x000000018696B6B8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 59231
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Rect _DORect_b__0(); // 0x000000018696BE80-0x000000018696BEB4
			internal void _DORect_b__1(Rect x); // 0x000000018696BEB4-0x000000018696BEE4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 59232
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOShakePosition_b__0(); // 0x000000018696BEE4-0x000000018696BF30
			internal void _DOShakePosition_b__1(Vector3 x); // 0x000000018696BF30-0x000000018696BF7C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 59233
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOShakePosition_b__0(); // 0x000000018696BEE4-0x000000018696BF30
			internal void _DOShakePosition_b__1(Vector3 x); // 0x000000018696BF30-0x000000018696BF7C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 59234
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOShakeRotation_b__0(); // 0x000000018696A6CC-0x000000018696A718
			internal void _DOShakeRotation_b__1(Vector3 x); // 0x000000018696A718-0x000000018696A790
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 59235
		{
			// Fields
			public Camera target; // 0x10
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOShakeRotation_b__0(); // 0x000000018696A6CC-0x000000018696A718
			internal void _DOShakeRotation_b__1(Vector3 x); // 0x000000018696A718-0x000000018696A790
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 59236
		{
			// Fields
			public Light target; // 0x10
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal UnityEngine.Color _DOColor_b__0(); // 0x000000018696A790-0x000000018696A7C4
			internal void _DOColor_b__1(UnityEngine.Color x); // 0x000000018696A7C4-0x000000018696A7F4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 59237
		{
			// Fields
			public Light target; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _DOIntensity_b__0(); // 0x000000018696A7F4-0x000000018696A814
			internal void _DOIntensity_b__1(float x); // 0x000000018696A814-0x000000018696A834
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 59238
		{
			// Fields
			public Light target; // 0x10
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _DOShadowStrength_b__0(); // 0x000000018696A834-0x000000018696A854
			internal void _DOShadowStrength_b__1(float x); // 0x000000018696A854-0x000000018696A874
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 59239
		{
			// Fields
			public Color2 startValue; // 0x10
			public LineRenderer target; // 0x30
	
			// Constructors
			public __c__DisplayClass15_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Color2 _DOColor_b__0(); // 0x0000000182A8F1C0-0x0000000182A8F1E0
			internal void _DOColor_b__1(Color2 x); // 0x000000018696A874-0x000000018696A8B0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 59240
		{
			// Fields
			public Material target; // 0x10
	
			// Constructors
			public __c__DisplayClass16_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal UnityEngine.Color _DOColor_b__0(); // 0x000000018696A8B0-0x000000018696A8E4
			internal void _DOColor_b__1(UnityEngine.Color x); // 0x000000018696A8E4-0x000000018696A914
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 59241
		{
			// Fields
			public Material target; // 0x10
			public string property; // 0x18
	
			// Constructors
			public __c__DisplayClass17_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal UnityEngine.Color _DOColor_b__0(); // 0x000000018696A914-0x000000018696A950
			internal void _DOColor_b__1(UnityEngine.Color x); // 0x000000018696A950-0x000000018696A988
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0 // TypeDefIndex: 59242
		{
			// Fields
			public Material target; // 0x10
			public int propertyID; // 0x18
	
			// Constructors
			public __c__DisplayClass18_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal UnityEngine.Color _DOColor_b__0(); // 0x000000018696A988-0x000000018696A9C4
			internal void _DOColor_b__1(UnityEngine.Color x); // 0x000000018696A9C4-0x000000018696A9FC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 59243
		{
			// Fields
			public Material target; // 0x10
	
			// Constructors
			public __c__DisplayClass19_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal UnityEngine.Color _DOFade_b__0(); // 0x000000018696A8B0-0x000000018696A8E4
			internal void _DOFade_b__1(UnityEngine.Color x); // 0x000000018696A8E4-0x000000018696A914
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 59244
		{
			// Fields
			public Material target; // 0x10
			public string property; // 0x18
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal UnityEngine.Color _DOFade_b__0(); // 0x000000018696A914-0x000000018696A950
			internal void _DOFade_b__1(UnityEngine.Color x); // 0x000000018696A950-0x000000018696A988
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 59245
		{
			// Fields
			public Material target; // 0x10
			public int propertyID; // 0x18
	
			// Constructors
			public __c__DisplayClass21_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal UnityEngine.Color _DOFade_b__0(); // 0x000000018696A988-0x000000018696A9C4
			internal void _DOFade_b__1(UnityEngine.Color x); // 0x000000018696A9C4-0x000000018696A9FC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0 // TypeDefIndex: 59246
		{
			// Fields
			public Material target; // 0x10
			public string property; // 0x18
	
			// Constructors
			public __c__DisplayClass22_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _DOFloat_b__0(); // 0x000000018696AA88-0x000000018696AAB0
			internal void _DOFloat_b__1(float x); // 0x000000018696AAB0-0x000000018696AADC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0 // TypeDefIndex: 59247
		{
			// Fields
			public Material target; // 0x10
			public int propertyID; // 0x18
	
			// Constructors
			public __c__DisplayClass23_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _DOFloat_b__0(); // 0x000000018696AADC-0x000000018696AB04
			internal void _DOFloat_b__1(float x); // 0x000000018696AB04-0x000000018696AB2C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 59248
		{
			// Fields
			public Material target; // 0x10
	
			// Constructors
			public __c__DisplayClass24_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector2 _DOOffset_b__0(); // 0x000000018696AB2C-0x000000018696AB4C
			internal void _DOOffset_b__1(Vector2 x); // 0x000000018696AB4C-0x000000018696AB6C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 59249
		{
			// Fields
			public Material target; // 0x10
			public string property; // 0x18
	
			// Constructors
			public __c__DisplayClass25_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector2 _DOOffset_b__0(); // 0x000000018696AB6C-0x000000018696AB94
			internal void _DOOffset_b__1(Vector2 x); // 0x000000018696AB94-0x000000018696ABC4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0 // TypeDefIndex: 59250
		{
			// Fields
			public Material target; // 0x10
	
			// Constructors
			public __c__DisplayClass26_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector2 _DOTiling_b__0(); // 0x000000018696ABC4-0x000000018696ABE4
			internal void _DOTiling_b__1(Vector2 x); // 0x000000018696ABE4-0x000000018696AC04
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0 // TypeDefIndex: 59251
		{
			// Fields
			public Material target; // 0x10
			public string property; // 0x18
	
			// Constructors
			public __c__DisplayClass27_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector2 _DOTiling_b__0(); // 0x000000018696AC04-0x000000018696AC2C
			internal void _DOTiling_b__1(Vector2 x); // 0x000000018696AC2C-0x000000018696AC5C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0 // TypeDefIndex: 59252
		{
			// Fields
			public Material target; // 0x10
			public string property; // 0x18
	
			// Constructors
			public __c__DisplayClass28_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector4 _DOVector_b__0(); // 0x000000018696AC5C-0x000000018696AC98
			internal void _DOVector_b__1(Vector4 x); // 0x000000018696AC98-0x000000018696ACD0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0 // TypeDefIndex: 59253
		{
			// Fields
			public Material target; // 0x10
			public int propertyID; // 0x18
	
			// Constructors
			public __c__DisplayClass29_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector4 _DOVector_b__0(); // 0x000000018696ACD0-0x000000018696AD0C
			internal void _DOVector_b__1(Vector4 x); // 0x000000018696AD0C-0x000000018696AD44
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0 // TypeDefIndex: 59254
		{
			// Fields
			public TrailRenderer target; // 0x10
	
			// Constructors
			public __c__DisplayClass30_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector2 _DOResize_b__0(); // 0x000000018696AE2C-0x000000018696AE78
			internal void _DOResize_b__1(Vector2 x); // 0x000000018696AE78-0x000000018696AEC0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 59255
		{
			// Fields
			public TrailRenderer target; // 0x10
	
			// Constructors
			public __c__DisplayClass31_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _DOTime_b__0(); // 0x000000018696AEC0-0x000000018696AEE0
			internal void _DOTime_b__1(float x); // 0x000000018696AEE0-0x000000018696AF00
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0 // TypeDefIndex: 59256
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass32_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOMove_b__0(); // 0x000000018696AF00-0x000000018696AF3C
			internal void _DOMove_b__1(Vector3 x); // 0x000000018696AF3C-0x000000018696AF74
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 59257
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass33_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOMoveX_b__0(); // 0x000000018696AF00-0x000000018696AF3C
			internal void _DOMoveX_b__1(Vector3 x); // 0x000000018696AF3C-0x000000018696AF74
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0 // TypeDefIndex: 59258
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass34_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOMoveY_b__0(); // 0x000000018696AF00-0x000000018696AF3C
			internal void _DOMoveY_b__1(Vector3 x); // 0x000000018696AF3C-0x000000018696AF74
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0 // TypeDefIndex: 59259
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass35_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOMoveZ_b__0(); // 0x000000018696AF00-0x000000018696AF3C
			internal void _DOMoveZ_b__1(Vector3 x); // 0x000000018696AF3C-0x000000018696AF74
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_0 // TypeDefIndex: 59260
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass36_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOLocalMove_b__0(); // 0x000000018696AF74-0x000000018696AFB0
			internal void _DOLocalMove_b__1(Vector3 x); // 0x000000018696AFB0-0x000000018696AFE8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0 // TypeDefIndex: 59261
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass37_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOLocalMoveX_b__0(); // 0x000000018696AF74-0x000000018696AFB0
			internal void _DOLocalMoveX_b__1(Vector3 x); // 0x000000018696AFB0-0x000000018696AFE8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0 // TypeDefIndex: 59262
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass38_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOLocalMoveY_b__0(); // 0x000000018696AF74-0x000000018696AFB0
			internal void _DOLocalMoveY_b__1(Vector3 x); // 0x000000018696AFB0-0x000000018696AFE8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass39_0 // TypeDefIndex: 59263
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass39_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOLocalMoveZ_b__0(); // 0x000000018696AF74-0x000000018696AFB0
			internal void _DOLocalMoveZ_b__1(Vector3 x); // 0x000000018696AFB0-0x000000018696AFE8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0 // TypeDefIndex: 59264
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass40_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Quaternion _DORotate_b__0(); // 0x000000018696B05C-0x000000018696B090
			internal void _DORotate_b__1(Quaternion x); // 0x000000018696B090-0x000000018696B0C0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0 // TypeDefIndex: 59265
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass41_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Quaternion _DORotateQuaternion_b__0(); // 0x000000018696B05C-0x000000018696B090
			internal void _DORotateQuaternion_b__1(Quaternion x); // 0x000000018696B090-0x000000018696B0C0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass42_0 // TypeDefIndex: 59266
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass42_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Quaternion _DOLocalRotate_b__0(); // 0x000000018696B0C0-0x000000018696B0F4
			internal void _DOLocalRotate_b__1(Quaternion x); // 0x000000018696B0F4-0x000000018696B124
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0 // TypeDefIndex: 59267
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass43_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Quaternion _DOLocalRotateQuaternion_b__0(); // 0x00000001846383D0-0x0000000184638410
			internal void _DOLocalRotateQuaternion_b__1(Quaternion x); // 0x00000001836CBD00-0x00000001836CBDF0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0 // TypeDefIndex: 59268
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass44_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOScale_b__0(); // 0x000000018696B124-0x000000018696B160
			internal void _DOScale_b__1(Vector3 x); // 0x000000018696B160-0x000000018696B198
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0 // TypeDefIndex: 59269
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass45_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOScale_b__0(); // 0x000000018696B124-0x000000018696B160
			internal void _DOScale_b__1(Vector3 x); // 0x000000018696B160-0x000000018696B198
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0 // TypeDefIndex: 59270
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass46_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOScaleX_b__0(); // 0x000000018696B124-0x000000018696B160
			internal void _DOScaleX_b__1(Vector3 x); // 0x000000018696B160-0x000000018696B198
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass47_0 // TypeDefIndex: 59271
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass47_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOScaleY_b__0(); // 0x000000018696B124-0x000000018696B160
			internal void _DOScaleY_b__1(Vector3 x); // 0x000000018696B160-0x000000018696B198
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_0 // TypeDefIndex: 59272
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass48_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOScaleZ_b__0(); // 0x000000018696B124-0x000000018696B160
			internal void _DOScaleZ_b__1(Vector3 x); // 0x000000018696B160-0x000000018696B198
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass51_0 // TypeDefIndex: 59273
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass51_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Quaternion _LookAt_b__0(); // 0x000000018696B05C-0x000000018696B090
			internal void _LookAt_b__1(Quaternion x); // 0x000000018696B090-0x000000018696B0C0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0 // TypeDefIndex: 59274
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass52_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOPunchPosition_b__0(); // 0x000000018696AF74-0x000000018696AFB0
			internal void _DOPunchPosition_b__1(Vector3 x); // 0x000000018696AFB0-0x000000018696AFE8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_0 // TypeDefIndex: 59275
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass53_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOPunchScale_b__0(); // 0x000000018696B124-0x000000018696B160
			internal void _DOPunchScale_b__1(Vector3 x); // 0x000000018696B160-0x000000018696B198
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_0 // TypeDefIndex: 59276
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass54_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOPunchRotation_b__0(); // 0x000000018696B1D8-0x000000018696B214
			internal void _DOPunchRotation_b__1(Vector3 x); // 0x000000018696B214-0x000000018696B268
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass55_0 // TypeDefIndex: 59277
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass55_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOShakePosition_b__0(); // 0x000000018696AF74-0x000000018696AFB0
			internal void _DOShakePosition_b__1(Vector3 x); // 0x000000018696AFB0-0x000000018696AFE8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass56_0 // TypeDefIndex: 59278
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass56_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOShakePosition_b__0(); // 0x000000018696AF74-0x000000018696AFB0
			internal void _DOShakePosition_b__1(Vector3 x); // 0x000000018696AFB0-0x000000018696AFE8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass57_0 // TypeDefIndex: 59279
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass57_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOShakeRotation_b__0(); // 0x000000018696B1D8-0x000000018696B214
			internal void _DOShakeRotation_b__1(Vector3 x); // 0x000000018696B214-0x000000018696B268
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0 // TypeDefIndex: 59280
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass58_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOShakeRotation_b__0(); // 0x000000018696B1D8-0x000000018696B214
			internal void _DOShakeRotation_b__1(Vector3 x); // 0x000000018696B214-0x000000018696B268
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass59_0 // TypeDefIndex: 59281
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass59_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOShakeScale_b__0(); // 0x000000018696B124-0x000000018696B160
			internal void _DOShakeScale_b__1(Vector3 x); // 0x000000018696B160-0x000000018696B198
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass60_0 // TypeDefIndex: 59282
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass60_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOShakeScale_b__0(); // 0x000000018696B124-0x000000018696B160
			internal void _DOShakeScale_b__1(Vector3 x); // 0x000000018696B160-0x000000018696B198
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_0 // TypeDefIndex: 59283
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
			public __c__DisplayClass61_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOJump_b__0(); // 0x000000018696AF00-0x000000018696AF3C
			internal void _DOJump_b__1(Vector3 x); // 0x000000018696AF3C-0x000000018696AF74
			internal void _DOJump_b__2(); // 0x000000018696B2A8-0x000000018696B2DC
			internal Vector3 _DOJump_b__3(); // 0x000000018696AF00-0x000000018696AF3C
			internal void _DOJump_b__4(Vector3 x); // 0x000000018696AF3C-0x000000018696AF74
			internal Vector3 _DOJump_b__5(); // 0x000000018696AF00-0x000000018696AF3C
			internal void _DOJump_b__6(Vector3 x); // 0x000000018696AF3C-0x000000018696AF74
			internal void _DOJump_b__7(); // 0x000000018696B2DC-0x000000018696B3B8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_0 // TypeDefIndex: 59284
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
			public __c__DisplayClass62_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOLocalJump_b__0(); // 0x000000018696AF74-0x000000018696AFB0
			internal void _DOLocalJump_b__1(Vector3 x); // 0x000000018696AFB0-0x000000018696AFE8
			internal void _DOLocalJump_b__2(); // 0x000000018696B3B8-0x000000018696B3EC
			internal Vector3 _DOLocalJump_b__3(); // 0x000000018696AF74-0x000000018696AFB0
			internal void _DOLocalJump_b__4(Vector3 x); // 0x000000018696AFB0-0x000000018696AFE8
			internal Vector3 _DOLocalJump_b__5(); // 0x000000018696AF74-0x000000018696AFB0
			internal void _DOLocalJump_b__6(Vector3 x); // 0x000000018696AFB0-0x000000018696AFE8
			internal void _DOLocalJump_b__7(); // 0x000000018696B3EC-0x000000018696B4C8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass63_0 // TypeDefIndex: 59285
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass63_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOPath_b__0(); // 0x000000018696AF00-0x000000018696AF3C
			internal void _DOPath_b__1(Vector3 x); // 0x000000018696AF3C-0x000000018696AF74
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass64_0 // TypeDefIndex: 59286
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass64_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOLocalPath_b__0(); // 0x000000018696AF74-0x000000018696AFB0
			internal void _DOLocalPath_b__1(Vector3 x); // 0x000000018696AFB0-0x000000018696AFE8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass65_0 // TypeDefIndex: 59287
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass65_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOPath_b__0(); // 0x000000018696AF00-0x000000018696AF3C
			internal void _DOPath_b__1(Vector3 x); // 0x000000018696AF3C-0x000000018696AF74
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass66_0 // TypeDefIndex: 59288
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass66_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOLocalPath_b__0(); // 0x000000018696AF74-0x000000018696AFB0
			internal void _DOLocalPath_b__1(Vector3 x); // 0x000000018696AFB0-0x000000018696AFE8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass67_0 // TypeDefIndex: 59289
		{
			// Fields
			public DG.Tweening.Tween target; // 0x10
	
			// Constructors
			public __c__DisplayClass67_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _DOTimeScale_b__0(); // 0x000000018696B4C8-0x000000018696B4E8
			internal void _DOTimeScale_b__1(float x); // 0x00000001853958D0-0x00000001853958F0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass68_0 // TypeDefIndex: 59290
		{
			// Fields
			public UnityEngine.Color to; // 0x10
			public Light target; // 0x20
	
			// Constructors
			public __c__DisplayClass68_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal UnityEngine.Color _DOBlendableColor_b__0(); // 0x0000000182B2D510-0x0000000182B2D520
			internal void _DOBlendableColor_b__1(UnityEngine.Color x); // 0x000000018696B50C-0x000000018696B5B0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass69_0 // TypeDefIndex: 59291
		{
			// Fields
			public UnityEngine.Color to; // 0x10
			public Material target; // 0x20
	
			// Constructors
			public __c__DisplayClass69_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal UnityEngine.Color _DOBlendableColor_b__0(); // 0x0000000182B2D510-0x0000000182B2D520
			internal void _DOBlendableColor_b__1(UnityEngine.Color x); // 0x000000018696B5B0-0x000000018696B654
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass70_0 // TypeDefIndex: 59292
		{
			// Fields
			public UnityEngine.Color to; // 0x10
			public Material target; // 0x20
			public string property; // 0x28
	
			// Constructors
			public __c__DisplayClass70_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal UnityEngine.Color _DOBlendableColor_b__0(); // 0x0000000182B2D510-0x0000000182B2D520
			internal void _DOBlendableColor_b__1(UnityEngine.Color x); // 0x000000018696B6B8-0x000000018696B770
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass71_0 // TypeDefIndex: 59293
		{
			// Fields
			public UnityEngine.Color to; // 0x10
			public Material target; // 0x20
			public int propertyID; // 0x28
	
			// Constructors
			public __c__DisplayClass71_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal UnityEngine.Color _DOBlendableColor_b__0(); // 0x0000000182B2D510-0x0000000182B2D520
			internal void _DOBlendableColor_b__1(UnityEngine.Color x); // 0x000000018696B770-0x000000018696B824
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass72_0 // TypeDefIndex: 59294
		{
			// Fields
			public Vector3 to; // 0x10
			public Transform target; // 0x20
	
			// Constructors
			public __c__DisplayClass72_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOBlendableMoveBy_b__0(); // 0x0000000184D8C950-0x0000000184D8C970
			internal void _DOBlendableMoveBy_b__1(Vector3 x); // 0x000000018696B824-0x000000018696B8F0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_0 // TypeDefIndex: 59295
		{
			// Fields
			public Vector3 to; // 0x10
			public Transform target; // 0x20
	
			// Constructors
			public __c__DisplayClass73_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOBlendableLocalMoveBy_b__0(); // 0x0000000184D8C950-0x0000000184D8C970
			internal void _DOBlendableLocalMoveBy_b__1(Vector3 x); // 0x000000018696B8F0-0x000000018696B9BC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass74_0 // TypeDefIndex: 59296
		{
			// Fields
			public Quaternion to; // 0x10
			public Transform target; // 0x20
	
			// Constructors
			public __c__DisplayClass74_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Quaternion _DOBlendableRotateBy_b__0(); // 0x0000000182B2D510-0x0000000182B2D520
			internal void _DOBlendableRotateBy_b__1(Quaternion x); // 0x000000018696B9BC-0x000000018696BAFC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass75_0 // TypeDefIndex: 59297
		{
			// Fields
			public Quaternion to; // 0x10
			public Transform target; // 0x20
	
			// Constructors
			public __c__DisplayClass75_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Quaternion _DOBlendableLocalRotateBy_b__0(); // 0x0000000182B2D510-0x0000000182B2D520
			internal void _DOBlendableLocalRotateBy_b__1(Quaternion x); // 0x000000018696BAFC-0x000000018696BC3C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_0 // TypeDefIndex: 59298
		{
			// Fields
			public Vector3 to; // 0x10
			public Transform target; // 0x20
	
			// Constructors
			public __c__DisplayClass76_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOBlendablePunchRotation_b__0(); // 0x0000000184D8C950-0x0000000184D8C970
			internal void _DOBlendablePunchRotation_b__1(Vector3 v); // 0x000000018696BC3C-0x000000018696BDB4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass77_0 // TypeDefIndex: 59299
		{
			// Fields
			public Vector3 to; // 0x10
			public Transform target; // 0x20
	
			// Constructors
			public __c__DisplayClass77_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOBlendableScaleBy_b__0(); // 0x0000000184D8C950-0x0000000184D8C970
			internal void _DOBlendableScaleBy_b__1(Vector3 x); // 0x000000018696BDB4-0x000000018696BE80
		}
	
		// Extension methods
		public static TweenerCore<float, float, FloatOptions> DOAspect(this Camera target, float endValue, float duration); // 0x000000018695F3D0-0x000000018695F52C
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(this Camera target, UnityEngine.Color endValue, float duration); // 0x0000000186960D74-0x0000000186960EDC
		public static TweenerCore<float, float, FloatOptions> DOFarClipPlane(this Camera target, float endValue, float duration); // 0x000000018696163C-0x0000000186961798
		public static TweenerCore<float, float, FloatOptions> DOFieldOfView(this Camera target, float endValue, float duration); // 0x0000000186961798-0x00000001869618F4
		public static TweenerCore<float, float, FloatOptions> DONearClipPlane(this Camera target, float endValue, float duration); // 0x0000000186963C30-0x0000000186963D8C
		public static TweenerCore<float, float, FloatOptions> DOOrthoSize(this Camera target, float endValue, float duration); // 0x000000018696409C-0x00000001869641F8
		public static TweenerCore<Rect, Rect, RectOptions> DOPixelRect(this Camera target, Rect endValue, float duration); // 0x0000000186964638-0x00000001869647A0
		public static TweenerCore<Rect, Rect, RectOptions> DORect(this Camera target, Rect endValue, float duration); // 0x0000000186964F10-0x0000000186965078
		public static Tweener DOShakePosition(this Camera target, float duration, float strength = 3f /* Metadata: 0x0234C6BD */, int vibrato = 10 /* Metadata: 0x0234C6C1 */, float randomness = 90f /* Metadata: 0x0234C6C2 */, bool fadeOut = true /* Metadata: 0x0234C6C6 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0234C6C7 */); // 0x0000000186966190-0x0000000186966390
		public static Tweener DOShakePosition(this Camera target, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x0234C6C8 */, float randomness = 90f /* Metadata: 0x0234C6C9 */, bool fadeOut = true /* Metadata: 0x0234C6CD */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0234C6CE */); // 0x00000001869665A4-0x00000001869667B8
		public static Tweener DOShakeRotation(this Camera target, float duration, float strength = 90f /* Metadata: 0x0234C6CF */, int vibrato = 10 /* Metadata: 0x0234C6D3 */, float randomness = 90f /* Metadata: 0x0234C6D4 */, bool fadeOut = true /* Metadata: 0x0234C6D8 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0234C6D9 */); // 0x0000000186966DE0-0x0000000186966FE0
		public static Tweener DOShakeRotation(this Camera target, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x0234C6DA */, float randomness = 90f /* Metadata: 0x0234C6DB */, bool fadeOut = true /* Metadata: 0x0234C6DF */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0234C6E0 */); // 0x00000001869667B8-0x00000001869669CC
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(this Light target, UnityEngine.Color endValue, float duration); // 0x0000000186960C0C-0x0000000186960D74
		public static TweenerCore<float, float, FloatOptions> DOIntensity(this Light target, float endValue, float duration); // 0x0000000186961D94-0x0000000186961EF0
		public static TweenerCore<float, float, FloatOptions> DOShadowStrength(this Light target, float endValue, float duration); // 0x0000000186965E10-0x0000000186965F6C
		public static Tweener DOColor(this LineRenderer target, Color2 startValue, Color2 endValue, float duration); // 0x0000000186960780-0x00000001869608FC
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(this Material target, UnityEngine.Color endValue, float duration); // 0x00000001869608FC-0x0000000186960A64
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(this Material target, UnityEngine.Color endValue, string property, float duration); // 0x0000000186960EDC-0x0000000186961094
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(this Material target, UnityEngine.Color endValue, int propertyID, float duration); // 0x0000000186960A64-0x0000000186960C0C
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOFade(this Material target, float endValue, float duration); // 0x0000000186961198-0x00000001869612F4
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOFade(this Material target, float endValue, string property, float duration); // 0x0000000186961490-0x000000018696163C
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOFade(this Material target, float endValue, int propertyID, float duration); // 0x00000001869612F4-0x0000000186961490
		public static TweenerCore<float, float, FloatOptions> DOFloat(this Material target, float endValue, string property, float duration); // 0x0000000186961B28-0x0000000186961CD4
		public static TweenerCore<float, float, FloatOptions> DOFloat(this Material target, float endValue, int propertyID, float duration); // 0x000000018696198C-0x0000000186961B28
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, float duration); // 0x0000000186963D8C-0x0000000186963EEC
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, string property, float duration); // 0x0000000186963EEC-0x000000018696409C
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, float duration); // 0x00000001869674D8-0x0000000186967638
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, string property, float duration); // 0x0000000186967638-0x00000001869677E8
		public static TweenerCore<Vector4, Vector4, VectorOptions> DOVector(this Material target, Vector4 endValue, string property, float duration); // 0x0000000186967CE0-0x0000000186967E98
		public static TweenerCore<Vector4, Vector4, VectorOptions> DOVector(this Material target, Vector4 endValue, int propertyID, float duration); // 0x0000000186967B38-0x0000000186967CE0
		public static Tweener DOResize(this TrailRenderer target, float toStartWidth, float toEndWidth, float duration); // 0x0000000186965078-0x00000001869651E4
		public static TweenerCore<float, float, FloatOptions> DOTime(this TrailRenderer target, float endValue, float duration); // 0x0000000186967944-0x0000000186967AA0
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Transform target, Vector3 endValue, float duration, bool snapping = false /* Metadata: 0x0234C6E1 */); // 0x0000000186963AA0-0x0000000186963C30
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x0234C6E2 */); // 0x00000001869635B8-0x0000000186963758
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x0234C6E3 */); // 0x0000000186963758-0x00000001869638FC
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x0234C6E4 */); // 0x00000001869638FC-0x0000000186963AA0
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMove(this Transform target, Vector3 endValue, float duration, bool snapping = false /* Metadata: 0x0234C6E5 */); // 0x0000000186962E94-0x0000000186963024
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveX(this Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x0234C6E6 */); // 0x00000001869629AC-0x0000000186962B4C
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveY(this Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x0234C6E7 */); // 0x0000000186962B4C-0x0000000186962CF0
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveZ(this Transform target, float endValue, float duration, bool snapping = false /* Metadata: 0x0234C6E8 */); // 0x0000000186962CF0-0x0000000186962E94
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Transform target, Vector3 endValue, float duration, DG.Tweening.RotateMode mode = DG.Tweening.RotateMode.Fast /* Metadata: 0x0234C6E9 */); // 0x00000001869654D8-0x0000000186965668
		public static TweenerCore<Quaternion, Quaternion, NoOptions> DORotateQuaternion(this Transform target, Quaternion endValue, float duration); // 0x000000018696534C-0x00000001869654D8
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLocalRotate(this Transform target, Vector3 endValue, float duration, DG.Tweening.RotateMode mode = DG.Tweening.RotateMode.Fast /* Metadata: 0x0234C6EA */); // 0x00000001869633DC-0x000000018696356C
		public static TweenerCore<Quaternion, Quaternion, NoOptions> DOLocalRotateQuaternion(this Transform target, Quaternion endValue, float duration); // 0x0000000184860390-0x0000000184860530
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(this Transform target, Vector3 endValue, float duration); // 0x0000000186965CA0-0x0000000186965E10
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(this Transform target, float endValue, float duration); // 0x0000000186965B30-0x0000000186965CA0
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleX(this Transform target, float endValue, float duration); // 0x0000000186965668-0x0000000186965800
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleY(this Transform target, float endValue, float duration); // 0x0000000186965800-0x0000000186965998
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleZ(this Transform target, float endValue, float duration); // 0x0000000186965998-0x0000000186965B30
		public static Tweener DOLookAt(this Transform target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None /* Metadata: 0x0234C6EB */, Vector3? up = default); // 0x000000018696356C-0x00000001869635B8
		public static Tweener DODynamicLookAt(this Transform target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None /* Metadata: 0x0234C6EC */, Vector3? up = default); // 0x000000018696114C-0x0000000186961198
		private static Tweener LookAt(this Transform target, Vector3 towards, float duration, AxisConstraint axisConstraint, Vector3? up, bool dynamic); // 0x0000000186967E98-0x00000001869680D4
		public static Tweener DOPunchPosition(this Transform target, Vector3 punch, float duration, int vibrato = 10 /* Metadata: 0x0234C6ED */, float elasticity = 1f /* Metadata: 0x0234C6EE */, bool snapping = false /* Metadata: 0x0234C6F2 */); // 0x0000000186964968-0x0000000186964B58
		public static Tweener DOPunchScale(this Transform target, Vector3 punch, float duration, int vibrato = 10 /* Metadata: 0x0234C6F3 */, float elasticity = 1f /* Metadata: 0x0234C6F4 */); // 0x0000000186964D34-0x0000000186964F10
		public static Tweener DOPunchRotation(this Transform target, Vector3 punch, float duration, int vibrato = 10 /* Metadata: 0x0234C6F8 */, float elasticity = 1f /* Metadata: 0x0234C6F9 */); // 0x0000000186964B58-0x0000000186964D34
		public static Tweener DOShakePosition(this Transform target, float duration, float strength = 1f /* Metadata: 0x0234C6FD */, int vibrato = 10 /* Metadata: 0x0234C701 */, float randomness = 90f /* Metadata: 0x0234C702 */, bool snapping = false /* Metadata: 0x0234C706 */, bool fadeOut = true /* Metadata: 0x0234C707 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0234C708 */); // 0x0000000186966390-0x00000001869665A4
		public static Tweener DOShakePosition(this Transform target, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x0234C709 */, float randomness = 90f /* Metadata: 0x0234C70A */, bool snapping = false /* Metadata: 0x0234C70E */, bool fadeOut = true /* Metadata: 0x0234C70F */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0234C710 */); // 0x0000000186965F6C-0x0000000186966190
		public static Tweener DOShakeRotation(this Transform target, float duration, float strength = 90f /* Metadata: 0x0234C711 */, int vibrato = 10 /* Metadata: 0x0234C715 */, float randomness = 90f /* Metadata: 0x0234C716 */, bool fadeOut = true /* Metadata: 0x0234C71A */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0234C71B */); // 0x00000001869669CC-0x0000000186966BCC
		public static Tweener DOShakeRotation(this Transform target, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x0234C71C */, float randomness = 90f /* Metadata: 0x0234C71D */, bool fadeOut = true /* Metadata: 0x0234C721 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0234C722 */); // 0x0000000186966BCC-0x0000000186966DE0
		public static Tweener DOShakeScale(this Transform target, float duration, float strength = 1f /* Metadata: 0x0234C723 */, int vibrato = 10 /* Metadata: 0x0234C727 */, float randomness = 90f /* Metadata: 0x0234C728 */, bool fadeOut = true /* Metadata: 0x0234C72C */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0234C72D */); // 0x00000001869671F4-0x0000000186967440
		public static Tweener DOShakeScale(this Transform target, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x0234C72E */, float randomness = 90f /* Metadata: 0x0234C72F */, bool fadeOut = true /* Metadata: 0x0234C733 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x0234C734 */); // 0x0000000186966FE0-0x00000001869671F4
		public static DG.Tweening.Sequence DOJump(this Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false /* Metadata: 0x0234C735 */); // 0x0000000186961EF0-0x0000000186962420
		public static DG.Tweening.Sequence DOLocalJump(this Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false /* Metadata: 0x0234C736 */); // 0x000000018696247C-0x00000001869629AC
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Transform target, Vector3[] path, float duration, PathType pathType = PathType.Linear /* Metadata: 0x0234C737 */, PathMode pathMode = PathMode.Full3D /* Metadata: 0x0234C738 */, int resolution = 10 /* Metadata: 0x0234C739 */, UnityEngine.Color? gizmoColor = default); // 0x000000018696438C-0x00000001869645A0
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Transform target, Vector3[] path, float duration, PathType pathType = PathType.Linear /* Metadata: 0x0234C73A */, PathMode pathMode = PathMode.Full3D /* Metadata: 0x0234C73B */, int resolution = 10 /* Metadata: 0x0234C73C */, UnityEngine.Color? gizmoColor = default); // 0x0000000186963024-0x0000000186963240
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Transform target, Path path, float duration, PathMode pathMode = PathMode.Full3D /* Metadata: 0x0234C73D */); // 0x00000001869641F8-0x000000018696438C
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Transform target, Path path, float duration, PathMode pathMode = PathMode.Full3D /* Metadata: 0x0234C73E */); // 0x0000000186963240-0x00000001869633DC
		public static TweenerCore<float, float, FloatOptions> DOTimeScale(this DG.Tweening.Tween target, float endValue, float duration); // 0x00000001869677E8-0x0000000186967944
		public static Tweener DOBlendableColor(this Light target, UnityEngine.Color endValue, float duration); // 0x000000018695F73C-0x000000018695F908
		public static Tweener DOBlendableColor(this Material target, UnityEngine.Color endValue, float duration); // 0x000000018695FB28-0x000000018695FCF4
		public static Tweener DOBlendableColor(this Material target, UnityEngine.Color endValue, string property, float duration); // 0x000000018695F908-0x000000018695FB28
		public static Tweener DOBlendableColor(this Material target, UnityEngine.Color endValue, int propertyID, float duration); // 0x000000018695F52C-0x000000018695F73C
		public static Tweener DOBlendableMoveBy(this Transform target, Vector3 byValue, float duration, bool snapping = false /* Metadata: 0x0234C73F */); // 0x0000000186960064-0x0000000186960220
		public static Tweener DOBlendableLocalMoveBy(this Transform target, Vector3 byValue, float duration, bool snapping = false /* Metadata: 0x0234C740 */); // 0x000000018695FCF4-0x000000018695FEB0
		public static Tweener DOBlendableRotateBy(this Transform target, Vector3 byValue, float duration, DG.Tweening.RotateMode mode = DG.Tweening.RotateMode.Fast /* Metadata: 0x0234C741 */); // 0x000000018696042C-0x00000001869605E0
		public static Tweener DOBlendableLocalRotateBy(this Transform target, Vector3 byValue, float duration, DG.Tweening.RotateMode mode = DG.Tweening.RotateMode.Fast /* Metadata: 0x0234C742 */); // 0x000000018695FEB0-0x0000000186960064
		public static Tweener DOBlendablePunchRotation(this Transform target, Vector3 punch, float duration, int vibrato = 10 /* Metadata: 0x0234C743 */, float elasticity = 1f /* Metadata: 0x0234C744 */); // 0x0000000186960220-0x000000018696042C
		public static Tweener DOBlendableScaleBy(this Transform target, Vector3 byValue, float duration); // 0x00000001869605E0-0x0000000186960780
		public static int DOComplete(this Component target, bool withCallbacks = false /* Metadata: 0x0234C748 */); // 0x00000001869610F0-0x000000018696114C
		public static int DOComplete(this Material target, bool withCallbacks = false /* Metadata: 0x0234C749 */); // 0x0000000186961094-0x00000001869610F0
		public static int DOKill(this Component target, bool complete = false /* Metadata: 0x0234C74A */); // 0x00000001836D45D0-0x00000001836D4610
		public static int DOKill(this Material target, bool complete = false /* Metadata: 0x0234C74B */); // 0x0000000186962420-0x000000018696247C
		public static int DOFlip(this Component target); // 0x00000001869618F4-0x0000000186961940
		public static int DOFlip(this Material target); // 0x0000000186961940-0x000000018696198C
		public static int DOGoto(this Component target, float to, bool andPlay = false /* Metadata: 0x0234C74C */); // 0x0000000186961D34-0x0000000186961D94
		public static int DOGoto(this Material target, float to, bool andPlay = false /* Metadata: 0x0234C74D */); // 0x0000000186961CD4-0x0000000186961D34
		public static int DOPause(this Component target); // 0x00000001869645A0-0x00000001869645EC
		public static int DOPause(this Material target); // 0x00000001869645EC-0x0000000186964638
		public static int DOPlay(this Component target); // 0x000000018696491C-0x0000000186964968
		public static int DOPlay(this Material target); // 0x00000001869648D0-0x000000018696491C
		public static int DOPlayBackwards(this Component target); // 0x00000001869647A0-0x00000001869647EC
		public static int DOPlayBackwards(this Material target); // 0x00000001869647EC-0x0000000186964838
		public static int DOPlayForward(this Component target); // 0x0000000186964884-0x00000001869648D0
		public static int DOPlayForward(this Material target); // 0x0000000186964838-0x0000000186964884
		public static int DORestart(this Component target, bool includeDelay = true /* Metadata: 0x0234C74E */); // 0x00000001869651E4-0x000000018696523C
		public static int DORestart(this Material target, bool includeDelay = true /* Metadata: 0x0234C74F */); // 0x000000018696523C-0x0000000186965294
		public static int DORewind(this Component target, bool includeDelay = true /* Metadata: 0x0234C750 */); // 0x00000001869652F0-0x000000018696534C
		public static int DORewind(this Material target, bool includeDelay = true /* Metadata: 0x0234C751 */); // 0x0000000186965294-0x00000001869652F0
		public static int DOSmoothRewind(this Component target); // 0x0000000186967440-0x000000018696748C
		public static int DOSmoothRewind(this Material target); // 0x000000018696748C-0x00000001869674D8
		public static int DOTogglePause(this Component target); // 0x0000000186967AA0-0x0000000186967AEC
		public static int DOTogglePause(this Material target); // 0x0000000186967AEC-0x0000000186967B38
	}

	public class TweenParams // TypeDefIndex: 59301
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
		public TweenParams(); // 0x0000000186969AA0-0x0000000186969AB0
		static TweenParams(); // 0x0000000186969A30-0x0000000186969AA0
	
		// Methods
		public TweenParams Clear(); // 0x000000018696947C-0x0000000186969620
		public TweenParams SetAutoKill(bool autoKillOnCompletion = true /* Metadata: 0x0234C752 */); // 0x0000000184D8C820-0x0000000184D8C830
		public TweenParams SetId(object objectId); // 0x00000001869698F4-0x0000000186969910
		public TweenParams SetId(string stringId); // 0x0000000186969910-0x000000018696992C
		public TweenParams SetId(int intId); // 0x0000000184D8C840-0x0000000184D8C850
		public TweenParams SetTarget(object target); // 0x00000001869699B4-0x00000001869699D0
		public TweenParams SetLoops(int loops, LoopType? loopType = default); // 0x000000018696992C-0x00000001869699B4
		public TweenParams SetEase(Ease ease, float? overshootOrAmplitude = default, float? period = default); // 0x00000001869697CC-0x00000001869698C8
		public TweenParams SetEase(AnimationCurve animCurve); // 0x0000000186969700-0x00000001869697CC
		public TweenParams SetEase(EaseFunction customEase); // 0x00000001869698C8-0x00000001869698F4
		public TweenParams SetRecyclable(bool recyclable = true /* Metadata: 0x0234C753 */); // 0x0000000184D8C850-0x0000000184D8C860
		public TweenParams SetUpdate(bool isIndependentUpdate); // 0x00000001869699D0-0x0000000186969A30
		public TweenParams SetUpdate(DG.Tweening.UpdateType updateType, bool isIndependentUpdate = false /* Metadata: 0x0234C754 */); // 0x0000000184D8C880-0x0000000184D8C890
		public TweenParams OnStart(TweenCallback action); // 0x0000000186969690-0x00000001869696AC
		public TweenParams OnPlay(TweenCallback action); // 0x0000000186969658-0x0000000186969674
		public TweenParams OnRewind(TweenCallback action); // 0x0000000186969674-0x0000000186969690
		public TweenParams OnUpdate(TweenCallback action); // 0x00000001869696C8-0x00000001869696E4
		public TweenParams OnStepComplete(TweenCallback action); // 0x00000001869696AC-0x00000001869696C8
		public TweenParams OnComplete(TweenCallback action); // 0x0000000186969620-0x000000018696963C
		public TweenParams OnKill(TweenCallback action); // 0x000000018696963C-0x0000000186969658
		public TweenParams OnWaypointChange(TweenCallback<int> action); // 0x00000001869696E4-0x0000000186969700
		public TweenParams SetDelay(float delay); // 0x0000000184D8C830-0x0000000184D8C840
		public TweenParams SetRelative(bool isRelative = true /* Metadata: 0x0234C755 */); // 0x0000000184D8C860-0x0000000184D8C870
		public TweenParams SetSpeedBased(bool isSpeedBased = true /* Metadata: 0x0234C756 */); // 0x0000000184D8C870-0x0000000184D8C880
	}

	public static class TweenSettingsExtensions // TypeDefIndex: 59302
	{
		// Methods
		private static bool ValidateAddToSequence(DG.Tweening.Sequence s, DG.Tweening.Tween t, bool ignoreTween = false /* Metadata: 0x0234C757 */); // 0x000000018396A7D0-0x000000018396A830
	
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
		public static DG.Tweening.Sequence Append(this DG.Tweening.Sequence s, DG.Tweening.Tween t); // 0x0000000183969030-0x0000000183969080
		public static DG.Tweening.Sequence Prepend(this DG.Tweening.Sequence s, DG.Tweening.Tween t); // 0x0000000186969DE4-0x0000000186969E20
		public static DG.Tweening.Sequence Join(this DG.Tweening.Sequence s, DG.Tweening.Tween t); // 0x000000018396B270-0x000000018396B2C0
		public static DG.Tweening.Sequence Insert(this DG.Tweening.Sequence s, float atPosition, DG.Tweening.Tween t); // 0x0000000186969D0C-0x0000000186969D5C
		public static DG.Tweening.Sequence AppendInterval(this DG.Tweening.Sequence s, float interval); // 0x000000018396A830-0x000000018396A870
		public static DG.Tweening.Sequence PrependInterval(this DG.Tweening.Sequence s, float interval); // 0x0000000186969DA4-0x0000000186969DE4
		public static DG.Tweening.Sequence AppendCallback(this DG.Tweening.Sequence s, TweenCallback callback); // 0x00000001845E33F0-0x00000001845E3440
		public static DG.Tweening.Sequence PrependCallback(this DG.Tweening.Sequence s, TweenCallback callback); // 0x0000000186969D5C-0x0000000186969DA4
		public static DG.Tweening.Sequence InsertCallback(this DG.Tweening.Sequence s, float atPosition, TweenCallback callback); // 0x0000000186969CB8-0x0000000186969D0C
		public static T From<T>(this T t)
			where T : Tweener;
		public static T From<T>(this T t, bool isRelative)
			where T : Tweener;
		public static T From<T>(this T t, bool setImmediately, bool isRelative)
			where T : Tweener;
		public static TweenerCore<T1, T2, TPlugOptions> From<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately = true /* Metadata: 0x0234C758 */, bool isRelative = false /* Metadata: 0x0234C759 */)
			where TPlugOptions : struct, IPlugOptions;
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> From(this TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t, float fromAlphaValue, bool setImmediately = true /* Metadata: 0x0234C75A */, bool isRelative = false /* Metadata: 0x0234C75B */); // 0x0000000186969AB0-0x0000000186969B6C
		public static TweenerCore<Vector3, Vector3, VectorOptions> From(this TweenerCore<Vector3, Vector3, VectorOptions> t, float fromValue, bool setImmediately = true /* Metadata: 0x0234C75C */, bool isRelative = false /* Metadata: 0x0234C75D */); // 0x0000000186969B6C-0x0000000186969C18
		public static TweenerCore<Vector2, Vector2, CircleOptions> From(this TweenerCore<Vector2, Vector2, CircleOptions> t, float fromValueDegrees, bool setImmediately = true /* Metadata: 0x0234C75E */, bool isRelative = false /* Metadata: 0x0234C75F */); // 0x0000000186969C18-0x0000000186969CB8
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
		public static Tweener SetOptions(this TweenerCore<float, float, FloatOptions> t, bool snapping); // 0x000000018696A37C-0x000000018696A394
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, bool snapping); // 0x000000018396B570-0x000000018396B590
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x0234C760 */); // 0x00000001846AE4E0-0x00000001846AE500
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, bool snapping); // 0x000000018696A344-0x000000018696A35C
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x0234C761 */); // 0x000000018696A35C-0x000000018696A37C
		public static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, bool snapping); // 0x000000018696A1E4-0x000000018696A1FC
		public static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x0234C762 */); // 0x000000018696A1C4-0x000000018696A1E4
		public static Tweener SetOptions(this TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool useShortest360Route = true /* Metadata: 0x0234C763 */); // 0x000000018696A1FC-0x000000018696A21C
		public static Tweener SetOptions(this TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t, bool alphaOnly); // 0x00000001845E33D0-0x00000001845E33F0
		public static Tweener SetOptions(this TweenerCore<Rect, Rect, RectOptions> t, bool snapping); // 0x00000001845E33D0-0x00000001845E33F0
		public static Tweener SetOptions(this TweenerCore<string, string, StringOptions> t, bool richTextEnabled, ScrambleMode scrambleMode = ScrambleMode.None /* Metadata: 0x0234C764 */, string scrambleChars = null); // 0x000000018696A21C-0x000000018696A2F4
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool snapping); // 0x000000018396B570-0x000000018396B590
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x0234C765 */); // 0x00000001846AE4E0-0x00000001846AE500
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, CircleOptions> t, float endValueDegrees, bool relativeCenter = true /* Metadata: 0x0234C766 */, bool snapping = false /* Metadata: 0x0234C767 */); // 0x000000018696A31C-0x000000018696A344
		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, AxisConstraint lockPosition, AxisConstraint lockRotation = AxisConstraint.None /* Metadata: 0x0234C768 */); // 0x000000018696A394-0x000000018696A3B4
		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, bool closePath, AxisConstraint lockPosition = AxisConstraint.None /* Metadata: 0x0234C769 */, AxisConstraint lockRotation = AxisConstraint.None /* Metadata: 0x0234C76A */); // 0x000000018696A2F4-0x000000018696A31C
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, Vector3? forwardDirection = default, Vector3? up = default); // 0x0000000186969F24-0x0000000186969F94
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, bool stableZRotation); // 0x000000018696A014-0x000000018696A080
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, Vector3? forwardDirection = default, Vector3? up = default); // 0x0000000186969E9C-0x0000000186969F24
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, bool stableZRotation); // 0x000000018696A080-0x000000018696A104
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, Vector3? forwardDirection = default, Vector3? up = default); // 0x0000000186969F94-0x000000018696A014
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, bool stableZRotation); // 0x0000000186969E20-0x0000000186969E9C
		private static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, OrientType orientType, Vector3 lookAtPosition, Transform lookAtTransform, float lookAhead, Vector3? forwardDirection = default, Vector3? up = default, bool stableZRotation = false /* Metadata: 0x0234C76B */); // 0x000000018696A104-0x000000018696A1C4
		private static void SetPathForwardDirection(this TweenerCore<Vector3, Path, PathOptions> t, Vector3? forwardDirection = default, Vector3? up = default); // 0x000000018696A3B4-0x000000018696A648
	}

	public enum LogBehaviour // TypeDefIndex: 59303
	{
		Default = 0,
		Verbose = 1,
		ErrorsOnly = 2
	}

	public abstract class Tween : ABSSequentiable // TypeDefIndex: 59304
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
		public bool isRelative { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184D88CC0-0x0000000184D88CD0 0x0000000184D88D20-0x0000000184D88D30
		public bool active { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184D8C8C0-0x0000000184D8C8D0 0x0000000184D8C8F0-0x0000000184D8C900
		public float fullPosition { get; set; } // 0x000000018696A648-0x000000018696A654 0x000000018696A654-0x000000018696A664
		public bool hasLoops { get; } // 0x0000000183153250-0x0000000183153270 
		public bool playedOnce { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8C8D0-0x0000000184D8C8E0 0x0000000184D8C900-0x0000000184D8C910
		public float position { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000184D8C8E0-0x0000000184D8C8F0 0x0000000184D8C910-0x0000000184D8C920
	
		// Constructors
		protected Tween(); // 0x0000000184D8C890-0x0000000184D8C8C0
	
		// Methods
		internal virtual void Reset(); // 0x0000000183C7B680-0x0000000183C7B800
		internal abstract bool Validate();
		internal virtual float UpdateDelay(float elapsed); // 0x0000000184D879D0-0x0000000184D879E0
		internal abstract bool Startup();
		internal abstract bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, UpdateNotice updateNotice);
		internal static bool DoGoto(Tween t, float toPosition, int toCompletedLoops, DG.Tweening.Core.Enums.UpdateMode updateMode); // 0x0000000183152DF0-0x0000000183153250
		internal static bool OnTweenCallback(TweenCallback callback, Tween t); // 0x00000001835450A0-0x0000000183545240
		internal static bool OnTweenCallback<T>(TweenCallback<T> callback, Tween t, T param);
	}

	public abstract class Tweener : DG.Tweening.Tween // TypeDefIndex: 59305
	{
		// Fields
		internal bool hasManuallySetStartValue; // 0x120
		internal bool isFromAllowed; // 0x121
	
		// Constructors
		internal Tweener(); // 0x0000000184D8C920-0x0000000184D8C950
	
		// Methods
		public abstract Tweener ChangeStartValue(object newStartValue, float newDuration = -1f /* Metadata: 0x0234C76F */);
		public abstract Tweener ChangeEndValue(object newEndValue, float newDuration = -1f /* Metadata: 0x0234C773 */, bool snapStartValue = false /* Metadata: 0x0234C777 */);
		public abstract Tweener ChangeEndValue(object newEndValue, bool snapStartValue);
		public abstract Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1f /* Metadata: 0x0234C778 */);
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

	public enum TweenType // TypeDefIndex: 59306
	{
		Tweener = 0,
		Sequence = 1,
		Callback = 2
	}

	public enum UpdateType // TypeDefIndex: 59307
	{
		Normal = 0,
		Late = 1,
		Fixed = 2,
		Manual = 3
	}
}

namespace DG.Tweening.Core
{
	public abstract class ABSSequentiable // TypeDefIndex: 59353
	{
		// Fields
		internal TweenType tweenType; // 0x10
		internal float sequencedPosition; // 0x14
		internal float sequencedEndPosition; // 0x18
		internal TweenCallback onStart; // 0x20
	
		// Constructors
		protected ABSSequentiable(); // 0x00000001841E1670-0x00000001841E1680
	}

	public delegate T DOGetter<out T>(); // TypeDefIndex: 59354; 0x00000000-0x00000000

	public delegate void DOSetter<in T>(T pNewValue); // TypeDefIndex: 59355; 0x00000000-0x00000000

	public static class Debugger // TypeDefIndex: 59357
	{
		// Fields
		private static int _logPriority; // 0x00
		private const string _LogPrefix = "<color=#0099bc><b>DOTWEEN \u25BA </b></color>"; // Metadata: 0x0234C78E
	
		// Properties
		public static int logPriority { get; } // 0x000000018697ACE0-0x000000018697AD18 
	
		// Nested types
		internal static class Sequence // TypeDefIndex: 59356
		{
			// Methods
			public static void LogAddToNullSequence(); // 0x0000000186981D60-0x0000000186981D98
			public static void LogAddToInactiveSequence(); // 0x0000000186981CF0-0x0000000186981D28
			public static void LogAddToLockedSequence(); // 0x0000000186981D28-0x0000000186981D60
			public static void LogAddNullTween(); // 0x0000000186981CB8-0x0000000186981CF0
			public static void LogAddInactiveTween(DG.Tweening.Tween t); // 0x0000000186981C7C-0x0000000186981CB8
			public static void LogAddAlreadySequencedTween(DG.Tweening.Tween t); // 0x0000000186981C40-0x0000000186981C7C
		}
	
		// Methods
		public static void Log(object message); // 0x000000018697AB7C-0x000000018697AC6C
		public static void LogWarning(object message, DG.Tweening.Tween t = null); // 0x00000001840BA870-0x00000001840BA980
		public static void LogError(object message, DG.Tweening.Tween t = null); // 0x000000018697A4BC-0x000000018697A610
		public static void LogSafeModeCapturedError(object message, DG.Tweening.Tween t = null); // 0x000000018697A8E8-0x000000018697AA9C
		public static void LogReport(object message); // 0x000000018697A808-0x000000018697A8E8
		public static void LogSafeModeReport(object message); // 0x000000018697AA9C-0x000000018697AB7C
		public static void LogInvalidTween(DG.Tweening.Tween t); // 0x000000018697A610-0x000000018697A648
		public static void LogNestedTween(DG.Tweening.Tween t); // 0x000000018697A700-0x000000018697A73C
		public static void LogNullTween(DG.Tweening.Tween t); // 0x000000018697A778-0x000000018697A7B0
		public static void LogNonPathTween(DG.Tweening.Tween t); // 0x000000018697A73C-0x000000018697A778
		public static void LogMissingMaterialProperty(string propertyName); // 0x000000018697A648-0x000000018697A694
		public static void LogMissingMaterialProperty(int propertyId); // 0x000000018697A694-0x000000018697A700
		public static void LogRemoveActiveTweenError(string errorInfo, DG.Tweening.Tween t); // 0x000000018697A7B0-0x000000018697A808
		public static void LogAddActiveTweenError(string errorInfo, DG.Tweening.Tween t); // 0x000000018697A464-0x000000018697A4BC
		public static void SetLogPriority(LogBehaviour logBehaviour); // 0x0000000184709D40-0x0000000184709D90
		public static bool ShouldLogSafeModeCapturedError(); // 0x000000018697AC6C-0x000000018697ACE0
		private static string GetDebugDataMessage(DG.Tweening.Tween t); // 0x000000018697A418-0x000000018697A464
		private static void AddDebugDataToMessage(ref string message, DG.Tweening.Tween t); // 0x000000018697A250-0x000000018697A418
	}

	[AddComponentMenu("")]
	public class DOTweenComponent : MonoBehaviour, IDOTweenInit // TypeDefIndex: 59364
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
		private sealed class _WaitForCompletion_d__17 : IEnumerator<object> // TypeDefIndex: 59358
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DG.Tweening.Tween t; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForCompletion_d__17(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000186984EBC-0x0000000186984F10
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000186984F10-0x0000000186984F5C
		}
	
		[CompilerGenerated]
		private sealed class _WaitForRewind_d__18 : IEnumerator<object> // TypeDefIndex: 59359
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DG.Tweening.Tween t; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForRewind_d__18(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000186985158-0x00000001869851D4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001869851D4-0x0000000186985220
		}
	
		[CompilerGenerated]
		private sealed class _WaitForKill_d__19 : IEnumerator<object> // TypeDefIndex: 59360
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DG.Tweening.Tween t; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForKill_d__19(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000186985004-0x0000000186985050
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000186985050-0x000000018698509C
		}
	
		[CompilerGenerated]
		private sealed class _WaitForElapsedLoops_d__20 : IEnumerator<object> // TypeDefIndex: 59361
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DG.Tweening.Tween t; // 0x20
			public int elapsedLoops; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForElapsedLoops_d__20(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000186984F5C-0x0000000186984FB8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000186984FB8-0x0000000186985004
		}
	
		[CompilerGenerated]
		private sealed class _WaitForPosition_d__21 : IEnumerator<object> // TypeDefIndex: 59362
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DG.Tweening.Tween t; // 0x20
			public float position; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForPosition_d__21(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018698509C-0x000000018698510C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018698510C-0x0000000186985158
		}
	
		[CompilerGenerated]
		private sealed class _WaitForStart_d__22 : IEnumerator<object> // TypeDefIndex: 59363
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public DG.Tweening.Tween t; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForStart_d__22(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000186985220-0x0000000186985274
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000186985274-0x00000001869852C0
		}
	
		// Constructors
		public DOTweenComponent(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Awake(); // 0x0000000184961210-0x00000001849613C0
		private void Start(); // 0x0000000184D267A0-0x0000000184D26840
		private void Update(); // 0x0000000183152600-0x00000001831527C0
		private void LateUpdate(); // 0x0000000183EFA010-0x0000000183EFA060
		private void FixedUpdate(); // 0x0000000183E62500-0x0000000183E62540
		private void OnDrawGizmos(); // 0x0000000186979D10-0x0000000186979E30
		private void OnDestroy(); // 0x0000000186979914-0x0000000186979D10
		public void OnApplicationPause(bool pauseStatus); // 0x0000000183F262A0-0x0000000183F262C0
		private void OnApplicationQuit(); // 0x00000001869798C8-0x0000000186979914
		public IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity); // 0x0000000186979E30-0x0000000186979E90
		internal IEnumerator WaitForCompletion(DG.Tweening.Tween t); // 0x0000000186979E90-0x0000000186979EEC
		internal IEnumerator WaitForRewind(DG.Tweening.Tween t); // 0x000000018697A020-0x000000018697A07C
		internal IEnumerator WaitForKill(DG.Tweening.Tween t); // 0x0000000186979F58-0x0000000186979FB4
		internal IEnumerator WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops); // 0x0000000186979EEC-0x0000000186979F58
		internal IEnumerator WaitForPosition(DG.Tweening.Tween t, float position); // 0x0000000186979FB4-0x000000018697A020
		internal IEnumerator WaitForStart(DG.Tweening.Tween t); // 0x000000018697A07C-0x000000018697A0D8
		internal static void Create(); // 0x0000000184709D90-0x0000000184709F10
		internal static void DestroyInstance(); // 0x00000001869797D8-0x00000001869798C8
	}

	public class DOTweenSettings : ScriptableObject // TypeDefIndex: 59368
	{
		// Fields
		public const string AssetName = "DOTweenSettings"; // Metadata: 0x0234C7B9
		public const string AssetFullFilename = "DOTweenSettings.asset"; // Metadata: 0x0234C7C9
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
		public enum SettingsLocation // TypeDefIndex: 59365
		{
			AssetsDirectory = 0,
			DOTweenDirectory = 1,
			DemigiantDirectory = 2
		}
	
		[Serializable]
		public class SafeModeOptions // TypeDefIndex: 59366
		{
			// Fields
			public SafeModeLogBehaviour logBehaviour; // 0x10
			public NestedTweenFailureBehaviour nestedTweenFailureBehaviour; // 0x14
	
			// Constructors
			public SafeModeOptions(); // 0x0000000184D8CAB0-0x0000000184D8CAC0
		}
	
		[Serializable]
		public class ModulesSetup // TypeDefIndex: 59367
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
			public ModulesSetup(); // 0x0000000184D8CA00-0x0000000184D8CA10
		}
	
		// Constructors
		public DOTweenSettings(); // 0x0000000184CA69F0-0x0000000184CA6AC0
	}

	public static class Extensions // TypeDefIndex: 59369
	{
		// Extension methods
		public static T SetSpecialStartupMode<T>(this T t, SpecialStartupMode mode)
			where T : DG.Tweening.Tween;
		public static TweenerCore<T1, T2, TPlugOptions> Blendable<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t)
			where TPlugOptions : struct, IPlugOptions;
		public static TweenerCore<T1, T2, TPlugOptions> NoFrom<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t)
			where TPlugOptions : struct, IPlugOptions;
	}

	public static class DOTweenExternalCommand // TypeDefIndex: 59370
	{
		// Fields
		[CompilerGenerated]
		private static Action<PathOptions, DG.Tweening.Tween, Quaternion, Transform> SetOrientationOnPath; // 0x00
	
		// Events
		public static event Action<PathOptions, DG.Tweening.Tween, Quaternion, Transform> SetOrientationOnPath {
			add; // 0x0000000184B42310-0x0000000184B423B0
			remove; // 0x000000018697A1B4-0x000000018697A250
		}
	
		// Methods
		internal static void Dispatch_SetOrientationOnPath(PathOptions options, DG.Tweening.Tween t, Quaternion newRot, Transform trans); // 0x000000018697A0D8-0x000000018697A1B4
	}

	internal struct SafeModeReport // TypeDefIndex: 59372
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
		public int totMissingTargetOrFieldErrors { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B77620-0x0000000182B77630 0x0000000184D86140-0x0000000184D86150
		public int totCallbackErrors { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88B20-0x0000000184D88B30 0x0000000184D88B50-0x0000000184D88B60
		public int totStartupErrors { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88B10-0x0000000184D88B20 0x0000000184D88B40-0x0000000184D88B50
		public int totUnsetErrors { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8CAD0-0x0000000184D8CAE0 0x0000000184D8CAE0-0x0000000184D8CAF0
	
		// Nested types
		internal enum SafeModeReportType // TypeDefIndex: 59371
		{
			Unset = 0,
			TargetOrFieldMissing = 1,
			Callback = 2,
			StartupFailure = 3
		}
	
		// Methods
		public void Add(SafeModeReportType type); // 0x0000000186981C20-0x0000000186981C40
		public int GetTotErrors(); // 0x0000000184D8CAC0-0x0000000184D8CAD0
	}

	internal class SequenceCallback : ABSSequentiable // TypeDefIndex: 59373
	{
		// Constructors
		public SequenceCallback(float sequencedPosition, TweenCallback callback); // 0x00000001845E3510-0x00000001845E3530
	}

	internal class TweenLink // TypeDefIndex: 59374
	{
		// Fields
		public readonly GameObject target; // 0x10
		public readonly LinkBehaviour behaviour; // 0x18
		public bool lastSeenActive; // 0x1C
	
		// Constructors
		public TweenLink(GameObject target, LinkBehaviour behaviour); // 0x000000018698382C-0x000000018698386C
	}

	internal static class TweenManager // TypeDefIndex: 59376
	{
		// Fields
		private const int _DefaultMaxTweeners = 200; // Metadata: 0x0234C7F3
		private const int _DefaultMaxSequences = 50; // Metadata: 0x0234C7F5
		private const string _MaxTweensReached = "Max Tweens reached: capacity has automatically been increased from #0 to #1. Use DOTween.SetTweensCapacity to set it manually at startup"; // Metadata: 0x0234C7F6
		private const float _EpsilonVsTimeCheck = 1E-06f; // Metadata: 0x0234C880
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
		internal enum CapacityIncreaseMode // TypeDefIndex: 59375
		{
			TweenersAndSequences = 0,
			TweenersOnly = 1,
			SequencesOnly = 2
		}
	
		// Constructors
		static TweenManager(); // 0x00000001849B6DE0-0x00000001849B7080
	
		// Methods
		internal static TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>()
			where TPlugOptions : struct, IPlugOptions;
		internal static DG.Tweening.Sequence GetSequence(); // 0x00000001839690E0-0x0000000183969320
		internal static void SetUpdateType(DG.Tweening.Tween t, DG.Tweening.UpdateType updateType, bool isIndependentUpdate); // 0x00000001845D4790-0x00000001845D4800
		internal static void AddActiveTweenToSequence(DG.Tweening.Tween t); // 0x0000000183969860-0x0000000183969890
		internal static int DespawnAll(); // 0x000000018396A8F0-0x000000018396ABD0
		internal static void Despawn(DG.Tweening.Tween t, bool modifyActiveLists = true /* Metadata: 0x0234C7E6 */); // 0x0000000183969BC0-0x0000000183969D50
		internal static void PurgeAll(bool isApplicationQuitting); // 0x000000018698446C-0x00000001869846B8
		internal static void PurgePools(); // 0x00000001869846B8-0x00000001869847B4
		internal static void AddTweenLink(DG.Tweening.Tween t, TweenLink tweenLink); // 0x000000018698386C-0x00000001869839D0
		private static void RemoveTweenLink(DG.Tweening.Tween t); // 0x00000001869847B4-0x000000018698487C
		internal static void ResetCapacities(); // 0x000000018698487C-0x00000001869848C8
		internal static void SetCapacities(int tweenersCapacity, int sequencesCapacity); // 0x00000001869848C8-0x00000001869849D8
		internal static int Validate(); // 0x0000000186984D34-0x0000000186984EBC
		internal static void Update(DG.Tweening.UpdateType updateType, float deltaTime, float independentTime); // 0x0000000183152990-0x0000000183152C20
		internal static bool Update(DG.Tweening.Tween t, float deltaTime, float independentTime, bool isSingleTweenManualUpdate); // 0x0000000183152C20-0x0000000183152DF0
		internal static int FilteredOperation(DG.Tweening.Core.Enums.OperationType operationType, DG.Tweening.Core.Enums.FilterType filterType, object id, bool optionalBool, float optionalFloat, object optionalObj = null, object[] optionalArray = null); // 0x00000001831527C0-0x0000000183152990
		internal static bool Complete(DG.Tweening.Tween t, bool modifyActiveLists = true /* Metadata: 0x0234C7E7 */, DG.Tweening.Core.Enums.UpdateMode updateMode = DG.Tweening.Core.Enums.UpdateMode.Goto /* Metadata: 0x0234C7E8 */); // 0x0000000183969A70-0x0000000183969B40
		internal static bool Flip(DG.Tweening.Tween t); // 0x0000000186983E18-0x0000000186983E38
		internal static void ForceInit(DG.Tweening.Tween t, bool isSequenced = false /* Metadata: 0x0234C7E9 */); // 0x0000000183D312E0-0x0000000183D31330
		internal static bool Goto(DG.Tweening.Tween t, float to, bool andPlay = false /* Metadata: 0x0234C7EA */, DG.Tweening.Core.Enums.UpdateMode updateMode = DG.Tweening.Core.Enums.UpdateMode.Goto /* Metadata: 0x0234C7EB */); // 0x0000000183D311B0-0x0000000183D312E0
		internal static bool Pause(DG.Tweening.Tween t); // 0x00000001844781A0-0x00000001844781E0
		internal static bool Play(DG.Tweening.Tween t); // 0x0000000184CE17D0-0x0000000184CE1800
		internal static bool PlayBackwards(DG.Tweening.Tween t); // 0x0000000186984330-0x00000001869843E0
		internal static bool PlayForward(DG.Tweening.Tween t); // 0x00000001869843E0-0x000000018698446C
		internal static bool Restart(DG.Tweening.Tween t, bool includeDelay = true /* Metadata: 0x0234C7EC */, float changeDelayTo = -1f /* Metadata: 0x0234C7ED */); // 0x0000000183542B70-0x0000000183542C20
		internal static bool Rewind(DG.Tweening.Tween t, bool includeDelay = true /* Metadata: 0x0234C7F1 */); // 0x0000000183542C20-0x0000000183542CE0
		internal static bool SmoothRewind(DG.Tweening.Tween t); // 0x00000001869849D8-0x0000000186984AC4
		internal static bool TogglePause(DG.Tweening.Tween t); // 0x0000000186984AC4-0x0000000186984B2C
		internal static int TotalPooledTweens(); // 0x0000000186984C3C-0x0000000186984C90
		internal static int TotalPlayingTweens(); // 0x0000000186984B2C-0x0000000186984C3C
		internal static int TotalTweensById(object id, bool playingOnly); // 0x0000000186984C90-0x0000000186984D34
		internal static List<DG.Tweening.Tween> GetActiveTweens(bool playing, List<DG.Tweening.Tween> fillableList = null); // 0x0000000186983E38-0x0000000186983FD0
		internal static List<DG.Tweening.Tween> GetTweensById(object id, bool playingOnly, List<DG.Tweening.Tween> fillableList = null); // 0x0000000186983FD0-0x0000000186984104
		private static int DoGetTweensById(object id, bool playingOnly, bool addToList, List<DG.Tweening.Tween> fillableList); // 0x00000001869839D0-0x0000000186983B90
		internal static List<DG.Tweening.Tween> GetTweensByTarget(object target, bool playingOnly, List<DG.Tweening.Tween> fillableList = null); // 0x0000000186984104-0x00000001869842AC
		private static void MarkForKilling(DG.Tweening.Tween t, bool isSingleTweenManualUpdate = false /* Metadata: 0x0234C7F2 */); // 0x00000001839697F0-0x0000000183969860
		private static void EvaluateTweenLink(DG.Tweening.Tween t); // 0x0000000186983B90-0x0000000186983E18
		private static void AddActiveTween(DG.Tweening.Tween t); // 0x000000018396A1F0-0x000000018396A4B0
		private static void ReorganizeActiveTweens(); // 0x000000018396A4B0-0x000000018396A7D0
		private static void DespawnActiveTweens(List<DG.Tweening.Tween> tweens); // 0x0000000183969B40-0x0000000183969BC0
		private static void RemoveActiveTween(DG.Tweening.Tween t); // 0x0000000183969EA0-0x000000018396A1F0
		private static void ClearTweenArray(DG.Tweening.Tween[] tweens); // 0x0000000183969890-0x00000001839698F0
		private static void IncreaseCapacities(CapacityIncreaseMode increaseMode); // 0x0000000184A29580-0x0000000184A29740
		private static void ManageOnRewindCallbackWhenAlreadyRewinded(DG.Tweening.Tween t, bool isPlayBackwardsOrSmoothRewind); // 0x00000001869842AC-0x0000000186984330
	}

	public static class DOTweenUtils // TypeDefIndex: 59377
	{
		// Fields
		private static Assembly[] _loadedAssemblies; // 0x00
		private static readonly string[] _defAssembliesToQuery; // 0x08
	
		// Constructors
		static DOTweenUtils(); // 0x0000000184CA48F0-0x0000000184CA49D0
	
		// Methods
		internal static Vector3 Vector3FromAngle(float degrees, float magnitude); // 0x0000000184D8CB00-0x0000000184D8CB60
		internal static float Angle2D(Vector3 from, Vector3 to); // 0x0000000186987E28-0x0000000186987F28
		internal static Vector3 RotateAroundPivot(Vector3 point, Vector3 pivot, Quaternion rotation); // 0x0000000186987FAC-0x000000018698806C
		public static Vector2 GetPointOnCircle(Vector2 center, float radius, float degrees); // 0x0000000186987F28-0x0000000186987FAC
		internal static bool Vector3AreApproximatelyEqual(Vector3 a, Vector3 b); // 0x000000018698806C-0x0000000186988130
		internal static System.Type GetLooseScriptType(string typeName); // 0x00000001849613C0-0x0000000184961500
	}

	public class TweenerCore<T1, T2, TPlugOptions> : Tweener // TypeDefIndex: 59378
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
		private const string _TxtCantChangeSequencedValues = "You cannot change the values of a tween contained inside a Sequence"; // Metadata: 0x0234C8A1
		private System.Type _colorType;
		private System.Type _color32Type;
	
		// Constructors
		internal TweenerCore();
	
		// Methods
		public override Tweener ChangeStartValue(object newStartValue, float newDuration = -1f /* Metadata: 0x0234C887 */);
		public override Tweener ChangeEndValue(object newEndValue, bool snapStartValue);
		public override Tweener ChangeEndValue(object newEndValue, float newDuration = -1f /* Metadata: 0x0234C88B */, bool snapStartValue = false /* Metadata: 0x0234C88F */);
		public override Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1f /* Metadata: 0x0234C890 */);
		public TweenerCore<T1, T2, TPlugOptions> ChangeStartValue(T2 newStartValue, float newDuration = -1f /* Metadata: 0x0234C894 */);
		public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, bool snapStartValue);
		public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, float newDuration = -1f /* Metadata: 0x0234C898 */, bool snapStartValue = false /* Metadata: 0x0234C89C */);
		public TweenerCore<T1, T2, TPlugOptions> ChangeValues(T2 newStartValue, T2 newEndValue, float newDuration = -1f /* Metadata: 0x0234C89D */);
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
	public static class Bounce // TypeDefIndex: 59387
	{
		// Methods
		public static float EaseIn(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod); // 0x0000000186987D4C-0x0000000186987D88
		public static float EaseOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod); // 0x0000000186987D88-0x0000000186987E28
		public static float EaseInOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod); // 0x0000000186987CD8-0x0000000186987D4C
	}

	public static class EaseManager // TypeDefIndex: 59389
	{
		// Fields
		private const float _PiOver2 = 1.5707964f; // Metadata: 0x0234C90C
		private const float _TwoPi = 6.2831855f; // Metadata: 0x0234C910
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 59388
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
			static __c(); // 0x000000018698AD38-0x000000018698AD9C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _ToEaseFunction_b__4_0(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000186989EC8-0x0000000186989ED0
			internal float _ToEaseFunction_b__4_1(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698A290-0x000000018698A308
			internal float _ToEaseFunction_b__4_2(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698AA80-0x000000018698AAE8
			internal float _ToEaseFunction_b__4_3(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698ABF4-0x000000018698AC6C
			internal float _ToEaseFunction_b__4_4(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000184D8CB60-0x0000000184D8CB70
			internal float _ToEaseFunction_b__4_5(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698ABD8-0x000000018698ABF4
			internal float _ToEaseFunction_b__4_6(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698AC6C-0x000000018698ACB8
			internal float _ToEaseFunction_b__4_7(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698ACB8-0x000000018698ACC8
			internal float _ToEaseFunction_b__4_8(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698ACC8-0x000000018698ACE8
			internal float _ToEaseFunction_b__4_9(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698ACE8-0x000000018698AD38
			internal float _ToEaseFunction_b__4_10(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000186989ED0-0x0000000186989EE4
			internal float _ToEaseFunction_b__4_11(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000186989EE4-0x0000000186989F10
			internal float _ToEaseFunction_b__4_12(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000186989F10-0x0000000186989F6C
			internal float _ToEaseFunction_b__4_13(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000186989F6C-0x0000000186989F84
			internal float _ToEaseFunction_b__4_14(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000186989F84-0x0000000186989FAC
			internal float _ToEaseFunction_b__4_15(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000186989FAC-0x000000018698A00C
			internal float _ToEaseFunction_b__4_16(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698A00C-0x000000018698A094
			internal float _ToEaseFunction_b__4_17(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698A094-0x000000018698A124
			internal float _ToEaseFunction_b__4_18(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698A124-0x000000018698A214
			internal float _ToEaseFunction_b__4_19(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698A214-0x000000018698A290
			internal float _ToEaseFunction_b__4_20(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698A308-0x000000018698A378
			internal float _ToEaseFunction_b__4_21(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698A378-0x000000018698A434
			internal float _ToEaseFunction_b__4_22(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698A434-0x000000018698A5B8
			internal float _ToEaseFunction_b__4_23(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698A5B8-0x000000018698A744
			internal float _ToEaseFunction_b__4_24(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698A744-0x000000018698A95C
			internal float _ToEaseFunction_b__4_25(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698A95C-0x000000018698A97C
			internal float _ToEaseFunction_b__4_26(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698A97C-0x000000018698A9A8
			internal float _ToEaseFunction_b__4_27(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698A9A8-0x000000018698AA10
			internal float _ToEaseFunction_b__4_28(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698AA10-0x000000018698AA50
			internal float _ToEaseFunction_b__4_29(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698AA50-0x000000018698AA80
			internal float _ToEaseFunction_b__4_30(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698AAE8-0x000000018698AB18
			internal float _ToEaseFunction_b__4_31(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698AB18-0x000000018698AB48
			internal float _ToEaseFunction_b__4_32(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698AB48-0x000000018698AB78
			internal float _ToEaseFunction_b__4_33(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698AB78-0x000000018698ABA8
			internal float _ToEaseFunction_b__4_34(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698ABA8-0x000000018698ABD8
			internal float _ToEaseFunction_b__4_35(float time, float duration, float overshootOrAmplitude, float period); // 0x000000018698ABD8-0x000000018698ABF4
		}
	
		// Methods
		public static float Evaluate(DG.Tweening.Tween t, float time, float duration, float overshootOrAmplitude, float period); // 0x0000000186988130-0x0000000186988174
		public static float Evaluate(Ease easeType, EaseFunction customEase, float time, float duration, float overshootOrAmplitude, float period); // 0x00000001831534F0-0x0000000183153720
		public static EaseFunction ToEaseFunction(Ease ease); // 0x0000000186988174-0x0000000186989A20
		internal static bool IsFlashEase(Ease ease); // 0x0000000183FD4B60-0x0000000183FD4B70
	}

	public class EaseCurve // TypeDefIndex: 59390
	{
		// Fields
		private readonly AnimationCurve _animCurve; // 0x10
	
		// Constructors
		public EaseCurve(AnimationCurve animCurve); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public float Evaluate(float time, float duration, float unusedOvershoot, float unusedPeriod); // 0x0000000183DF0AC0-0x0000000183DF0B50
	}

	public static class Flash // TypeDefIndex: 59391
	{
		// Methods
		public static float Ease(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000186989CB8-0x0000000186989D74
		public static float EaseIn(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000186989B24-0x0000000186989BE4
		public static float EaseOut(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000186989BE4-0x0000000186989CB8
		public static float EaseInOut(float time, float duration, float overshootOrAmplitude, float period); // 0x0000000186989A20-0x0000000186989B24
		private static float WeightedEase(float overshootOrAmplitude, float period, int stepIndex, float stepDuration, float dir, float res); // 0x0000000186989D74-0x0000000186989EC8
	}
}

namespace DG.Tweening.Core.Enums
{
	internal enum FilterType // TypeDefIndex: 59379
	{
		All = 0,
		TargetOrId = 1,
		TargetAndId = 2,
		AllExceptTargetsOrIds = 3,
		DOGetter = 4
	}

	public enum NestedTweenFailureBehaviour // TypeDefIndex: 59380
	{
		TryToPreserveSequence = 0,
		KillWholeSequence = 1
	}

	internal enum OperationType // TypeDefIndex: 59381
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

	public enum SafeModeLogBehaviour // TypeDefIndex: 59382
	{
		None = 0,
		Normal = 1,
		Warning = 2,
		Error = 3
	}

	public enum SpecialStartupMode // TypeDefIndex: 59383
	{
		None = 0,
		SetLookAt = 1,
		SetShake = 2,
		SetPunch = 3,
		SetCameraShakePosition = 4
	}

	public enum UpdateNotice // TypeDefIndex: 59384
	{
		None = 0,
		RewindStep = 1
	}

	internal enum UpdateMode // TypeDefIndex: 59385
	{
		Update = 0,
		Goto = 1,
		IgnoreOnUpdate = 2,
		IgnoreOnComplete = 3
	}

	public enum RewindCallbackMode // TypeDefIndex: 59386
	{
		FireIfPositionChanged = 0,
		FireAlwaysWithRewind = 1,
		FireAlways = 2
	}
}

namespace DG.Tweening.CustomPlugins
{
	public class PureQuaternionPlugin : ABSTweenPlugin<Quaternion, Quaternion, NoOptions> // TypeDefIndex: 59352
	{
		// Fields
		private static PureQuaternionPlugin _plug; // 0x00
	
		// Constructors
		public PureQuaternionPlugin(); // 0x00000001848605D0-0x0000000184860600
	
		// Methods
		public static PureQuaternionPlugin Plug(); // 0x0000000184860530-0x00000001848605D0
		public override void Reset(TweenerCore<Quaternion, Quaternion, NoOptions> t); // 0x00000001841E1670-0x00000001841E1680
		public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, bool isRelative); // 0x000000018697F3C4-0x000000018697F474
		public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion fromValue, bool setImmediately, bool isRelative); // 0x000000018697F2D0-0x000000018697F3C4
		public override Quaternion ConvertToStartValue(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion value); // 0x0000000184D8C9D0-0x0000000184D8C9E0
		public override void SetRelativeEndValue(TweenerCore<Quaternion, Quaternion, NoOptions> t); // 0x000000018697F474-0x000000018697F4C8
		public override void SetChangeValue(TweenerCore<Quaternion, Quaternion, NoOptions> t); // 0x0000000184820800-0x0000000184820830
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, Quaternion changeValue); // 0x000000018697F28C-0x000000018697F2D0
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Quaternion startValue, Quaternion changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000184404610-0x0000000184404700
	}
}

namespace DG.Tweening.Plugins
{
	public struct CircleOptions : IPlugOptions // TypeDefIndex: 59308
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
		public void Reset(); // 0x0000000184D8C7D0-0x0000000184D8C7E0
		public void Initialize(Vector2 startValue, Vector2 endValue); // 0x0000000186959A1C-0x0000000186959AE8
	}

	public class CirclePlugin : ABSTweenPlugin<Vector2, Vector2, CircleOptions> // TypeDefIndex: 59309
	{
		// Constructors
		public CirclePlugin(); // 0x000000018695A150-0x000000018695A178
	
		// Methods
		public override void Reset(TweenerCore<Vector2, Vector2, CircleOptions> t); // 0x00000001841E1670-0x00000001841E1680
		public override void SetFrom(TweenerCore<Vector2, Vector2, CircleOptions> t, bool isRelative); // 0x0000000186959F8C-0x000000018695A0D4
		public override void SetFrom(TweenerCore<Vector2, Vector2, CircleOptions> t, Vector2 fromValue, bool setImmediately, bool isRelative); // 0x0000000186959E30-0x0000000186959F8C
		public static ABSTweenPlugin<Vector2, Vector2, CircleOptions> Get(); // 0x0000000186959D7C-0x0000000186959DAC
		public override Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, CircleOptions> t, Vector2 value); // 0x0000000184D8C7E0-0x0000000184D8C7F0
		public override void SetRelativeEndValue(TweenerCore<Vector2, Vector2, CircleOptions> t); // 0x000000018695A0D4-0x000000018695A150
		public override void SetChangeValue(TweenerCore<Vector2, Vector2, CircleOptions> t); // 0x0000000186959DAC-0x0000000186959E30
		public override float GetSpeedBasedDuration(CircleOptions options, float unitsXSecond, Vector2 changeValue); // 0x0000000186959D64-0x0000000186959D7C
		public override void EvaluateAndApply(CircleOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000186959AE8-0x0000000186959C8C
		public Vector2 GetPositionOnCircle(CircleOptions options, float degrees); // 0x0000000186959C8C-0x0000000186959D64
	}

	internal class Color2Plugin : ABSTweenPlugin<Color2, Color2, ColorOptions> // TypeDefIndex: 59310
	{
		// Constructors
		public Color2Plugin(); // 0x000000018695A8F0-0x000000018695A918
	
		// Methods
		public override void Reset(TweenerCore<Color2, Color2, ColorOptions> t); // 0x00000001841E1670-0x00000001841E1680
		public override void SetFrom(TweenerCore<Color2, Color2, ColorOptions> t, bool isRelative); // 0x000000018695A6F4-0x000000018695A874
		public override void SetFrom(TweenerCore<Color2, Color2, ColorOptions> t, Color2 fromValue, bool setImmediately, bool isRelative); // 0x000000018695A564-0x000000018695A6F4
		public override Color2 ConvertToStartValue(TweenerCore<Color2, Color2, ColorOptions> t, Color2 value); // 0x0000000184D8C7F0-0x0000000184D8C810
		public override void SetRelativeEndValue(TweenerCore<Color2, Color2, ColorOptions> t); // 0x000000018695A874-0x000000018695A8F0
		public override void SetChangeValue(TweenerCore<Color2, Color2, ColorOptions> t); // 0x000000018695A4E8-0x000000018695A564
		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color2 changeValue); // 0x000000018695A4D8-0x000000018695A4E8
		public override void EvaluateAndApply(ColorOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Color2> getter, DOSetter<Color2> setter, float elapsed, Color2 startValue, Color2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x000000018695A178-0x000000018695A4D8
	}

	public class DoublePlugin : ABSTweenPlugin<double, double, NoOptions> // TypeDefIndex: 59311
	{
		// Constructors
		public DoublePlugin(); // 0x000000018697B018-0x000000018697B040
	
		// Methods
		public override void Reset(TweenerCore<double, double, NoOptions> t); // 0x00000001841E1670-0x00000001841E1680
		public override void SetFrom(TweenerCore<double, double, NoOptions> t, bool isRelative); // 0x000000018697AEC4-0x000000018697AF50
		public override void SetFrom(TweenerCore<double, double, NoOptions> t, double fromValue, bool setImmediately, bool isRelative); // 0x000000018697AF50-0x000000018697AFEC
		public override double ConvertToStartValue(TweenerCore<double, double, NoOptions> t, double value); // 0x0000000184D8C9C0-0x0000000184D8C9D0
		public override void SetRelativeEndValue(TweenerCore<double, double, NoOptions> t); // 0x000000018697AFEC-0x000000018697B018
		public override void SetChangeValue(TweenerCore<double, double, NoOptions> t); // 0x000000018697AE98-0x000000018697AEC4
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, double changeValue); // 0x000000018697AE7C-0x000000018697AE98
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<double> getter, DOSetter<double> setter, float elapsed, double startValue, double changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x000000018697AD18-0x000000018697AE7C
	}

	public class LongPlugin : ABSTweenPlugin<long, long, NoOptions> // TypeDefIndex: 59312
	{
		// Constructors
		public LongPlugin(); // 0x000000018697BC38-0x000000018697BC60
	
		// Methods
		public override void Reset(TweenerCore<long, long, NoOptions> t); // 0x00000001841E1670-0x00000001841E1680
		public override void SetFrom(TweenerCore<long, long, NoOptions> t, bool isRelative); // 0x000000018697BB04-0x000000018697BB88
		public override void SetFrom(TweenerCore<long, long, NoOptions> t, long fromValue, bool setImmediately, bool isRelative); // 0x000000018697BB88-0x000000018697BC14
		public override long ConvertToStartValue(TweenerCore<long, long, NoOptions> t, long value); // 0x0000000184D8C7E0-0x0000000184D8C7F0
		public override void SetRelativeEndValue(TweenerCore<long, long, NoOptions> t); // 0x000000018697BC14-0x000000018697BC38
		public override void SetChangeValue(TweenerCore<long, long, NoOptions> t); // 0x000000018697BAD8-0x000000018697BB04
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, long changeValue); // 0x000000018697BABC-0x000000018697BAD8
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<long> getter, DOSetter<long> setter, float elapsed, long startValue, long changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x000000018697B924-0x000000018697BABC
	}

	public class UlongPlugin : ABSTweenPlugin<ulong, ulong, NoOptions> // TypeDefIndex: 59313
	{
		// Constructors
		public UlongPlugin(); // 0x0000000186985864-0x000000018698588C
	
		// Methods
		public override void Reset(TweenerCore<ulong, ulong, NoOptions> t); // 0x00000001841E1670-0x00000001841E1680
		public override void SetFrom(TweenerCore<ulong, ulong, NoOptions> t, bool isRelative); // 0x00000001869857E0-0x0000000186985864
		public override void SetFrom(TweenerCore<ulong, ulong, NoOptions> t, ulong fromValue, bool setImmediately, bool isRelative); // 0x000000018697BB88-0x000000018697BC14
		public override ulong ConvertToStartValue(TweenerCore<ulong, ulong, NoOptions> t, ulong value); // 0x0000000184D8C7E0-0x0000000184D8C7F0
		public override void SetRelativeEndValue(TweenerCore<ulong, ulong, NoOptions> t); // 0x000000018697BC14-0x000000018697BC38
		public override void SetChangeValue(TweenerCore<ulong, ulong, NoOptions> t); // 0x000000018697BAD8-0x000000018697BB04
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, ulong changeValue); // 0x00000001869857A0-0x00000001869857E0
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<ulong> getter, DOSetter<ulong> setter, float elapsed, ulong startValue, ulong changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x00000001869855A4-0x00000001869857A0
	}

	public class Vector3ArrayPlugin : ABSTweenPlugin<Vector3, Vector3[], Vector3ArrayOptions> // TypeDefIndex: 59314
	{
		// Constructors
		public Vector3ArrayPlugin(); // 0x0000000186986760-0x0000000186986788
	
		// Methods
		public override void Reset(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t); // 0x0000000186980CE0-0x0000000186980D34
		public override void SetFrom(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool isRelative); // 0x00000001841E1670-0x00000001841E1680
		public override void SetFrom(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, Vector3[] fromValue, bool setImmediately, bool isRelative); // 0x00000001841E1670-0x00000001841E1680
		public override Vector3[] ConvertToStartValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, Vector3 value); // 0x0000000186985C50-0x0000000186985D54
		public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t); // 0x0000000186986600-0x0000000186986760
		public override void SetChangeValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t); // 0x00000001869864BC-0x0000000186986600
		public override float GetSpeedBasedDuration(Vector3ArrayOptions options, float unitsXSecond, Vector3[] changeValue); // 0x0000000186986428-0x00000001869864BC
		public override void EvaluateAndApply(Vector3ArrayOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3[] startValue, Vector3[] changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000186985D54-0x0000000186986428
	}

	public class PathPlugin : ABSTweenPlugin<Vector3, Path, PathOptions> // TypeDefIndex: 59315
	{
		// Fields
		public const float MinLookAhead = 0.0001f; // Metadata: 0x0234C783
	
		// Constructors
		public PathPlugin(); // 0x000000018697D898-0x000000018697D8C0
	
		// Methods
		public override void Reset(TweenerCore<Vector3, Path, PathOptions> t); // 0x000000018697C198-0x000000018697C200
		public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, bool isRelative); // 0x00000001841E1670-0x00000001841E1680
		public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, Path fromValue, bool setImmediately, bool isRelative); // 0x00000001841E1670-0x00000001841E1680
		public static ABSTweenPlugin<Vector3, Path, PathOptions> Get(); // 0x000000018697C168-0x000000018697C198
		public override Path ConvertToStartValue(TweenerCore<Vector3, Path, PathOptions> t, Vector3 value); // 0x000000018697BCF8-0x000000018697BD14
		public override void SetRelativeEndValue(TweenerCore<Vector3, Path, PathOptions> t); // 0x000000018697D790-0x000000018697D898
		public override void SetChangeValue(TweenerCore<Vector3, Path, PathOptions> t); // 0x000000018697C200-0x000000018697C6BC
		public override float GetSpeedBasedDuration(PathOptions options, float unitsXSecond, Path changeValue); // 0x000000018697C148-0x000000018697C168
		public override void EvaluateAndApply(PathOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Path startValue, Path changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x000000018697BD48-0x000000018697C148
		public void SetOrientation(PathOptions options, DG.Tweening.Tween t, Path path, float pathPerc, Vector3 tPos, UpdateNotice updateNotice); // 0x000000018697C6BC-0x000000018697D790
		private Vector3 DivideVectorByVector(Vector3 vector, Vector3 byVector); // 0x000000018697BD14-0x000000018697BD48
		private Vector3 MultiplyVectorByVector(Vector3 vector, Vector3 byVector); // 0x0000000184D8CA10-0x0000000184D8CA50
	}

	public class ColorPlugin : ABSTweenPlugin<UnityEngine.Color, UnityEngine.Color, ColorOptions> // TypeDefIndex: 59316
	{
		// Constructors
		public ColorPlugin(); // 0x00000001846FB340-0x00000001846FB370
	
		// Methods
		public override void Reset(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t); // 0x00000001841E1670-0x00000001841E1680
		public override void SetFrom(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t, bool isRelative); // 0x00000001869785F8-0x00000001869786DC
		public override void SetFrom(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t, UnityEngine.Color fromValue, bool setImmediately, bool isRelative); // 0x00000001869786DC-0x0000000186978814
		public override UnityEngine.Color ConvertToStartValue(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t, UnityEngine.Color value); // 0x0000000184D8C9D0-0x0000000184D8C9E0
		public override void SetRelativeEndValue(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t); // 0x0000000186978814-0x0000000186978868
		public override void SetChangeValue(TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> t); // 0x00000001849E2C60-0x00000001849E2CB0
		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, UnityEngine.Color changeValue); // 0x000000018695A4D8-0x000000018695A4E8
		public override void EvaluateAndApply(ColorOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<UnityEngine.Color> getter, DOSetter<UnityEngine.Color> setter, float elapsed, UnityEngine.Color startValue, UnityEngine.Color changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000183C7AFE0-0x0000000183C7B130
	}

	public class IntPlugin : ABSTweenPlugin<int, int, NoOptions> // TypeDefIndex: 59317
	{
		// Constructors
		public IntPlugin(); // 0x000000018697B520-0x000000018697B548
	
		// Methods
		public override void Reset(TweenerCore<int, int, NoOptions> t); // 0x00000001841E1670-0x00000001841E1680
		public override void SetFrom(TweenerCore<int, int, NoOptions> t, bool isRelative); // 0x000000018697B484-0x000000018697B500
		public override void SetFrom(TweenerCore<int, int, NoOptions> t, int fromValue, bool setImmediately, bool isRelative); // 0x000000018697B3FC-0x000000018697B484
		public override int ConvertToStartValue(TweenerCore<int, int, NoOptions> t, int value); // 0x0000000184D8C9F0-0x0000000184D8CA00
		public override void SetRelativeEndValue(TweenerCore<int, int, NoOptions> t); // 0x000000018697B500-0x000000018697B520
		public override void SetChangeValue(TweenerCore<int, int, NoOptions> t); // 0x000000018697B3D4-0x000000018697B3FC
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, int changeValue); // 0x000000018697B3B8-0x000000018697B3D4
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<int> getter, DOSetter<int> setter, float elapsed, int startValue, int changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x000000018697B230-0x000000018697B3B8
	}

	public class QuaternionPlugin : ABSTweenPlugin<Quaternion, Vector3, QuaternionOptions> // TypeDefIndex: 59318
	{
		// Constructors
		public QuaternionPlugin(); // 0x00000001869804D4-0x00000001869804FC
	
		// Methods
		public override void Reset(TweenerCore<Quaternion, Vector3, QuaternionOptions> t); // 0x00000001841E1670-0x00000001841E1680
		public override void SetFrom(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool isRelative); // 0x000000018697FFC8-0x00000001869802B4
		public override void SetFrom(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Vector3 fromValue, bool setImmediately, bool isRelative); // 0x00000001869802B4-0x0000000186980460
		public override Vector3 ConvertToStartValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Quaternion value); // 0x000000018697F514-0x000000018697F544
		public override void SetRelativeEndValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t); // 0x0000000186980460-0x00000001869804D4
		public override void SetChangeValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t); // 0x000000018697FD40-0x000000018697FFC8
		public override float GetSpeedBasedDuration(QuaternionOptions options, float unitsXSecond, Vector3 changeValue); // 0x000000018697FD1C-0x000000018697FD40
		public override void EvaluateAndApply(QuaternionOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x000000018697F544-0x000000018697F9FC
		private Vector3 GetEulerValForCalculations(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Vector3 val, Vector3 counterVal); // 0x000000018697F9FC-0x000000018697FD1C
		private Vector3 FlipEulerAngles(Vector3 euler); // 0x0000000184D8CA70-0x0000000184D8CAB0
	}

	public class RectOffsetPlugin : ABSTweenPlugin<RectOffset, RectOffset, NoOptions> // TypeDefIndex: 59319
	{
		// Fields
		private static RectOffset _r; // 0x00
	
		// Constructors
		public RectOffsetPlugin(); // 0x000000018698140C-0x0000000186981434
		static RectOffsetPlugin(); // 0x0000000186981390-0x000000018698140C
	
		// Methods
		public override void Reset(TweenerCore<RectOffset, RectOffset, NoOptions> t); // 0x0000000186980CE0-0x0000000186980D34
		public override void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, bool isRelative); // 0x0000000186980EB0-0x0000000186981050
		public override void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset fromValue, bool setImmediately, bool isRelative); // 0x0000000186981050-0x000000018698126C
		public override RectOffset ConvertToStartValue(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset value); // 0x00000001869804FC-0x00000001869805C0
		public override void SetRelativeEndValue(TweenerCore<RectOffset, RectOffset, NoOptions> t); // 0x000000018698126C-0x0000000186981390
		public override void SetChangeValue(TweenerCore<RectOffset, RectOffset, NoOptions> t); // 0x0000000186980D34-0x0000000186980EB0
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, RectOffset changeValue); // 0x0000000186980C0C-0x0000000186980CE0
		public override void EvaluateAndApply(NoOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, float elapsed, RectOffset startValue, RectOffset changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x00000001869805C0-0x0000000186980C0C
	}

	public class RectPlugin : ABSTweenPlugin<Rect, Rect, RectOptions> // TypeDefIndex: 59320
	{
		// Constructors
		public RectPlugin(); // 0x0000000186981BF8-0x0000000186981C20
	
		// Methods
		public override void Reset(TweenerCore<Rect, Rect, RectOptions> t); // 0x00000001841E1670-0x00000001841E1680
		public override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, bool isRelative); // 0x0000000186981824-0x00000001869819C4
		public override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, Rect fromValue, bool setImmediately, bool isRelative); // 0x00000001869819C4-0x0000000186981B84
		public override Rect ConvertToStartValue(TweenerCore<Rect, Rect, RectOptions> t, Rect value); // 0x0000000184D8C9D0-0x0000000184D8C9E0
		public override void SetRelativeEndValue(TweenerCore<Rect, Rect, RectOptions> t); // 0x0000000186981B84-0x0000000186981BF8
		public override void SetChangeValue(TweenerCore<Rect, Rect, RectOptions> t); // 0x00000001869817A8-0x0000000186981824
		public override float GetSpeedBasedDuration(RectOptions options, float unitsXSecond, Rect changeValue); // 0x0000000186981724-0x00000001869817A8
		public override void EvaluateAndApply(RectOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Rect> getter, DOSetter<Rect> setter, float elapsed, Rect startValue, Rect changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000186981434-0x0000000186981724
	}

	public class UintPlugin : ABSTweenPlugin<uint, uint, UintOptions> // TypeDefIndex: 59321
	{
		// Constructors
		public UintPlugin(); // 0x000000018698557C-0x00000001869855A4
	
		// Methods
		public override void Reset(TweenerCore<uint, uint, UintOptions> t); // 0x00000001841E1670-0x00000001841E1680
		public override void SetFrom(TweenerCore<uint, uint, UintOptions> t, bool isRelative); // 0x0000000186985500-0x000000018698557C
		public override void SetFrom(TweenerCore<uint, uint, UintOptions> t, uint fromValue, bool setImmediately, bool isRelative); // 0x000000018697B3FC-0x000000018697B484
		public override uint ConvertToStartValue(TweenerCore<uint, uint, UintOptions> t, uint value); // 0x0000000184D8C9F0-0x0000000184D8CA00
		public override void SetRelativeEndValue(TweenerCore<uint, uint, UintOptions> t); // 0x000000018697B500-0x000000018697B520
		public override void SetChangeValue(TweenerCore<uint, uint, UintOptions> t); // 0x00000001869854B0-0x0000000186985500
		public override float GetSpeedBasedDuration(UintOptions options, float unitsXSecond, uint changeValue); // 0x000000018698548C-0x00000001869854B0
		public override void EvaluateAndApply(UintOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<uint> getter, DOSetter<uint> setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x00000001869852C0-0x000000018698548C
	}

	public class Vector2Plugin : ABSTweenPlugin<Vector2, Vector2, VectorOptions> // TypeDefIndex: 59322
	{
		// Constructors
		public Vector2Plugin(); // 0x000000018437E8B0-0x000000018437E8E0
	
		// Methods
		public override void Reset(TweenerCore<Vector2, Vector2, VectorOptions> t); // 0x00000001841E1670-0x00000001841E1680
		public override void SetFrom(TweenerCore<Vector2, Vector2, VectorOptions> t, bool isRelative); // 0x0000000186985A74-0x0000000186985BCC
		public override void SetFrom(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 fromValue, bool setImmediately, bool isRelative); // 0x00000001869858B8-0x0000000186985A74
		public override Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 value); // 0x0000000184D8C7E0-0x0000000184D8C7F0
		public override void SetRelativeEndValue(TweenerCore<Vector2, Vector2, VectorOptions> t); // 0x0000000186985BCC-0x0000000186985C3C
		public override void SetChangeValue(TweenerCore<Vector2, Vector2, VectorOptions> t); // 0x0000000183C7B800-0x0000000183C7B8B0
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector2 changeValue); // 0x000000018698588C-0x00000001869858B8
		public override void EvaluateAndApply(VectorOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000183154F80-0x0000000183155140
	}

	public class Vector4Plugin : ABSTweenPlugin<Vector4, Vector4, VectorOptions> // TypeDefIndex: 59323
	{
		// Constructors
		public Vector4Plugin(); // 0x0000000186987CB0-0x0000000186987CD8
	
		// Methods
		public override void Reset(TweenerCore<Vector4, Vector4, VectorOptions> t); // 0x00000001841E1670-0x00000001841E1680
		public override void SetFrom(TweenerCore<Vector4, Vector4, VectorOptions> t, bool isRelative); // 0x0000000186987778-0x0000000186987964
		public override void SetFrom(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 fromValue, bool setImmediately, bool isRelative); // 0x0000000186987964-0x0000000186987CB0
		public override Vector4 ConvertToStartValue(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 value); // 0x0000000184D8C9D0-0x0000000184D8C9E0
		public override void SetRelativeEndValue(TweenerCore<Vector4, Vector4, VectorOptions> t); // 0x0000000186978814-0x0000000186978868
		public override void SetChangeValue(TweenerCore<Vector4, Vector4, VectorOptions> t); // 0x0000000186987668-0x0000000186987778
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector4 changeValue); // 0x0000000186987644-0x0000000186987668
		public override void EvaluateAndApply(VectorOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector4> getter, DOSetter<Vector4> setter, float elapsed, Vector4 startValue, Vector4 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x000000018698713C-0x0000000186987644
	}

	public class StringPlugin : ABSTweenPlugin<string, string, StringOptions> // TypeDefIndex: 59324
	{
		// Fields
		private static readonly StringBuilder _Buffer; // 0x00
		private static readonly List<char> _OpenedTags; // 0x08
	
		// Constructors
		public StringPlugin(); // 0x0000000186983804-0x000000018698382C
		static StringPlugin(); // 0x0000000186983724-0x0000000186983804
	
		// Methods
		public override void SetFrom(TweenerCore<string, string, StringOptions> t, bool isRelative); // 0x000000018698369C-0x0000000186983724
		public override void SetFrom(TweenerCore<string, string, StringOptions> t, string fromValue, bool setImmediately, bool isRelative); // 0x00000001869835D4-0x000000018698369C
		public override void Reset(TweenerCore<string, string, StringOptions> t); // 0x0000000186983228-0x00000001869832A0
		public override string ConvertToStartValue(TweenerCore<string, string, StringOptions> t, string value); // 0x0000000184D8C7E0-0x0000000184D8C7F0
		public override void SetRelativeEndValue(TweenerCore<string, string, StringOptions> t); // 0x00000001841E1670-0x00000001841E1680
		public override void SetChangeValue(TweenerCore<string, string, StringOptions> t); // 0x000000018698336C-0x00000001869835D4
		public override float GetSpeedBasedDuration(StringOptions options, float unitsXSecond, string changeValue); // 0x00000001869831D4-0x0000000186983228
		public override void EvaluateAndApply(StringOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<string> getter, DOSetter<string> setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000186982D3C-0x00000001869831D4
		private StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled); // 0x00000001869826D8-0x0000000186982D3C
		private char[] ScrambledCharsToUse(StringOptions options); // 0x00000001869832A0-0x000000018698336C
	}

	internal static class StringPluginExtensions // TypeDefIndex: 59325
	{
		// Fields
		public static readonly char[] ScrambledCharsAll; // 0x00
		public static readonly char[] ScrambledCharsUppercase; // 0x08
		public static readonly char[] ScrambledCharsLowercase; // 0x10
		public static readonly char[] ScrambledCharsNumerals; // 0x18
		private static int _lastRndSeed; // 0x20
	
		// Constructors
		static StringPluginExtensions(); // 0x00000001869824D8-0x00000001869826D8
	
		// Extension methods
		internal static void ScrambleChars(this char[] chars); // 0x000000018698244C-0x00000001869824D8
		internal static StringBuilder AppendScrambledChars(this StringBuilder buffer, int length, char[] chars); // 0x0000000186982318-0x000000018698244C
	}

	public class FloatPlugin : ABSTweenPlugin<float, float, FloatOptions> // TypeDefIndex: 59326
	{
		// Constructors
		public FloatPlugin(); // 0x0000000183ECA1F0-0x0000000183ECA220
	
		// Methods
		public override void Reset(TweenerCore<float, float, FloatOptions> t); // 0x00000001841E1670-0x00000001841E1680
		public override void SetFrom(TweenerCore<float, float, FloatOptions> t, bool isRelative); // 0x000000018697B058-0x000000018697B124
		public override void SetFrom(TweenerCore<float, float, FloatOptions> t, float fromValue, bool setImmediately, bool isRelative); // 0x000000018697B124-0x000000018697B204
		public override float ConvertToStartValue(TweenerCore<float, float, FloatOptions> t, float value); // 0x0000000184D8C9C0-0x0000000184D8C9D0
		public override void SetRelativeEndValue(TweenerCore<float, float, FloatOptions> t); // 0x000000018697B204-0x000000018697B230
		public override void SetChangeValue(TweenerCore<float, float, FloatOptions> t); // 0x0000000184192F50-0x0000000184192F80
		public override float GetSpeedBasedDuration(FloatOptions options, float unitsXSecond, float changeValue); // 0x000000018697B040-0x000000018697B058
		public override void EvaluateAndApply(FloatOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<float> getter, DOSetter<float> setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000183153400-0x00000001831534F0
	}

	public class Vector3Plugin : ABSTweenPlugin<Vector3, Vector3, VectorOptions> // TypeDefIndex: 59327
	{
		// Constructors
		public Vector3Plugin(); // 0x0000000186987114-0x000000018698713C
	
		// Methods
		public override void Reset(TweenerCore<Vector3, Vector3, VectorOptions> t); // 0x00000001841E1670-0x00000001841E1680
		public override void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, bool isRelative); // 0x0000000186986C98-0x0000000186986E98
		public override void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 fromValue, bool setImmediately, bool isRelative); // 0x0000000186986E98-0x0000000186987114
		public override Vector3 ConvertToStartValue(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 value); // 0x0000000184D8C9A0-0x0000000184D8C9C0
		public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3, VectorOptions> t); // 0x0000000186980460-0x00000001869804D4
		public override void SetChangeValue(TweenerCore<Vector3, Vector3, VectorOptions> t); // 0x0000000186986BB4-0x0000000186986C98
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector3 changeValue); // 0x000000018697FD1C-0x000000018697FD40
		public override void EvaluateAndApply(VectorOptions options, DG.Tweening.Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice); // 0x0000000186986788-0x0000000186986BB4
	}
}

namespace DG.Tweening.Plugins.Core
{
	public interface ITPlugin<T1, out T2, out TPlugOptions, TPlugin> // TypeDefIndex: 59340
	{
	}

	internal static class SpecialPluginsUtils // TypeDefIndex: 59341
	{
		// Methods
		internal static bool SetLookAt(TweenerCore<Quaternion, Vector3, QuaternionOptions> t); // 0x0000000186981FBC-0x000000018698210C
		internal static bool SetPunch(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t); // 0x000000018698210C-0x00000001869822B8
		internal static bool SetShake(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t); // 0x00000001869822B8-0x00000001869822F0
		internal static bool SetCameraShakePosition(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t); // 0x0000000186981D98-0x0000000186981FBC
	}

	public interface IPlugSetter<T1, out T2, TPlugin, out TPlugOptions> // TypeDefIndex: 59342
	{
		// Methods
		DOGetter<T1> Getter();
		DOSetter<T1> Setter();
		T2 EndValue();
		TPlugOptions GetOptions();
	}

	public interface ITweenPlugin // TypeDefIndex: 59343
	{
	}

	public abstract class ABSTweenPlugin<T1, T2, TPlugOptions> : ITweenPlugin // TypeDefIndex: 59344
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

	internal static class PluginsManager // TypeDefIndex: 59345
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
		private const int _MaxCustomPlugins = 20; // Metadata: 0x0234C78B
		private static Dictionary<System.Type, ITweenPlugin> _customPlugins; // 0x80
	
		// Methods
		internal static ABSTweenPlugin<T1, T2, TPlugOptions> GetDefaultPlugin<T1, T2, TPlugOptions>()
			where TPlugOptions : struct, IPlugOptions;
		public static ABSTweenPlugin<T1, T2, TPlugOptions> GetCustomPlugin<TPlugin, T1, T2, TPlugOptions>()
			where TPlugin : ITweenPlugin, new()
			where TPlugOptions : struct, IPlugOptions;
		internal static void PurgeAll(); // 0x000000018697EFC8-0x000000018697F28C
	}
}

namespace DG.Tweening.Plugins.Core.PathCore
{
	internal class CubicBezierDecoder : ABSPathDecoder // TypeDefIndex: 59346
	{
		// Fields
		private static readonly ControlPoint[] _PartialControlPs; // 0x00
		private static readonly Vector3[] _PartialWps; // 0x08
	
		// Properties
		internal override int minInputWaypoints { get; } // 0x0000000184D8C9E0-0x0000000184D8C9F0 
	
		// Constructors
		public CubicBezierDecoder(); // 0x00000001841E1670-0x00000001841E1680
		static CubicBezierDecoder(); // 0x000000018697972C-0x00000001869797D8
	
		// Methods
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath); // 0x0000000186978A04-0x0000000186978F4C
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints); // 0x0000000186978F4C-0x00000001869791E4
		internal void SetTimeToLengthTables(Path p, int subdivisions); // 0x00000001869791E4-0x00000001869793DC
		internal void SetWaypointsLengths(Path p, int subdivisions); // 0x00000001869793DC-0x000000018697972C
	}

	[Serializable]
	public struct ControlPoint // TypeDefIndex: 59347
	{
		// Fields
		public Vector3 a; // 0x00
		public Vector3 b; // 0x0C
	
		// Constructors
		public ControlPoint(Vector3 a, Vector3 b); // 0x0000000184D871E0-0x0000000184D87200
	
		// Methods
		public static ControlPoint operator +(ControlPoint cp, Vector3 v); // 0x0000000186978958-0x0000000186978A04
		public override string ToString(); // 0x0000000186978868-0x0000000186978958
	}

	internal abstract class ABSPathDecoder // TypeDefIndex: 59348
	{
		// Properties
		internal abstract int minInputWaypoints { get; }
	
		// Constructors
		protected ABSPathDecoder(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		internal abstract void FinalizePath(Path p, Vector3[] wps, bool isClosedPath);
		internal abstract Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints);
	}

	internal class CatmullRomDecoder : ABSPathDecoder // TypeDefIndex: 59349
	{
		// Fields
		private static readonly ControlPoint[] _PartialControlPs; // 0x00
		private static readonly Vector3[] _PartialWps; // 0x08
	
		// Properties
		internal override int minInputWaypoints { get; } // 0x0000000184D85B80-0x0000000184D85B90 
	
		// Constructors
		public CatmullRomDecoder(); // 0x00000001841E1670-0x00000001841E1680
		static CatmullRomDecoder(); // 0x000000018697854C-0x00000001869785F8
	
		// Methods
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath); // 0x0000000186977788-0x0000000186977A74
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints); // 0x0000000186977A74-0x0000000186977F58
		internal void SetTimeToLengthTables(Path p, int subdivisions); // 0x0000000186977F58-0x0000000186978150
		internal void SetWaypointsLengths(Path p, int subdivisions); // 0x0000000186978150-0x000000018697854C
	}

	internal class LinearDecoder : ABSPathDecoder // TypeDefIndex: 59350
	{
		// Properties
		internal override int minInputWaypoints { get; } // 0x0000000184D85B80-0x0000000184D85B90 
	
		// Constructors
		public LinearDecoder(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath); // 0x000000018697B548-0x000000018697B594
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints); // 0x000000018697B594-0x000000018697B768
		internal void SetTimeToLengthTables(Path p, int subdivisions); // 0x000000018697B768-0x000000018697B924
		internal void SetWaypointsLengths(Path p, int subdivisions); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class Path // TypeDefIndex: 59351
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
		internal int minInputWaypoints { get; } // 0x000000018697EFA4-0x000000018697EFC8 
	
		// Constructors
		public Path(PathType type, Vector3[] waypoints, int subdivisionsXSegment, UnityEngine.Color? gizmoColor = default); // 0x000000018697EE24-0x000000018697EFA4
		internal Path(); // 0x0000000184D8CA50-0x0000000184D8CA70
	
		// Methods
		internal void FinalizePath(bool isClosedPath, AxisConstraint lockPositionAxes, Vector3 currTargetVal); // 0x000000018697EA10-0x000000018697EB18
		internal Vector3 GetPoint(float perc, bool convertToConstantPerc = false /* Metadata: 0x0234C78C */); // 0x000000018697EC10-0x000000018697EC88
		internal float ConvertToConstantPathPerc(float perc); // 0x000000018697E168-0x000000018697E290
		internal int GetWaypointIndexFromPerc(float perc, bool isMovingForward); // 0x000000018697EC88-0x000000018697ED1C
		internal static Vector3[] GetDrawPoints(Path p, int drawSubdivisionsXSegment); // 0x000000018697EB18-0x000000018697EC10
		internal static void RefreshNonLinearDrawWps(Path p); // 0x000000018697ED1C-0x000000018697EE24
		internal void Destroy(); // 0x000000018697E358-0x000000018697E4A0
		internal Path CloneIncremental(int loopIncrement); // 0x000000018697DB34-0x000000018697E168
		internal void AssignWaypoints(Vector3[] newWps, bool cloneWps = false /* Metadata: 0x0234C78D */); // 0x000000018697DA4C-0x000000018697DB34
		internal void AssignDecoder(PathType pathType); // 0x000000018697D8C0-0x000000018697DA4C
		internal void Draw(); // 0x000000018697EA08-0x000000018697EA10
		private static void Draw(Path p); // 0x000000018697E4A0-0x000000018697EA08
		private static Vector3 ConvertToDrawPoint(Vector3 wp, PathOptions plugOptions); // 0x000000018697E290-0x000000018697E358
	}
}

namespace DG.Tweening.Plugins.Options
{
	public interface IPlugOptions // TypeDefIndex: 59328
	{
		// Methods
		void Reset();
	}

	public enum OrientType // TypeDefIndex: 59329
	{
		None = 0,
		ToPath = 1,
		LookAtTransform = 2,
		LookAtPosition = 3
	}

	public struct PathOptions : IPlugOptions // TypeDefIndex: 59330
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
		public void Reset(); // 0x000000018697BC60-0x000000018697BCF8
	}

	public struct QuaternionOptions : IPlugOptions // TypeDefIndex: 59331
	{
		// Fields
		public DG.Tweening.RotateMode rotateMode; // 0x00
		public AxisConstraint axisConstraint; // 0x04
		public Vector3 up; // 0x08
		public bool dynamicLookAt; // 0x14
		public Vector3 dynamicLookAtWorldPosition; // 0x18
	
		// Methods
		public void Reset(); // 0x000000018697F4C8-0x000000018697F514
	}

	public struct UintOptions : IPlugOptions // TypeDefIndex: 59332
	{
		// Fields
		public bool isNegativeChangeValue; // 0x00
	
		// Methods
		public void Reset(); // 0x0000000184D87170-0x0000000184D87180
	}

	public struct Vector3ArrayOptions : IPlugOptions // TypeDefIndex: 59333
	{
		// Fields
		public AxisConstraint axisConstraint; // 0x00
		public bool snapping; // 0x04
		internal float[] durations; // 0x08
	
		// Methods
		public void Reset(); // 0x0000000186985C3C-0x0000000186985C50
	}

	public struct NoOptions : IPlugOptions // TypeDefIndex: 59334
	{
		// Methods
		public void Reset(); // 0x00000001841E1670-0x00000001841E1680
	}

	public struct ColorOptions : IPlugOptions // TypeDefIndex: 59335
	{
		// Fields
		public bool alphaOnly; // 0x00
	
		// Methods
		public void Reset(); // 0x0000000184D87170-0x0000000184D87180
	}

	public struct FloatOptions : IPlugOptions // TypeDefIndex: 59336
	{
		// Fields
		public bool snapping; // 0x00
	
		// Methods
		public void Reset(); // 0x0000000184D87170-0x0000000184D87180
	}

	public struct RectOptions : IPlugOptions // TypeDefIndex: 59337
	{
		// Fields
		public bool snapping; // 0x00
	
		// Methods
		public void Reset(); // 0x0000000184D87170-0x0000000184D87180
	}

	public struct StringOptions : IPlugOptions // TypeDefIndex: 59338
	{
		// Fields
		public bool richTextEnabled; // 0x00
		public ScrambleMode scrambleMode; // 0x04
		public char[] scrambledChars; // 0x08
		internal int startValueStrippedLength; // 0x10
		internal int changeValueStrippedLength; // 0x14
	
		// Methods
		public void Reset(); // 0x00000001869822F0-0x0000000186982318
	}

	public struct VectorOptions : IPlugOptions // TypeDefIndex: 59339
	{
		// Fields
		public AxisConstraint axisConstraint; // 0x00
		public bool snapping; // 0x04
	
		// Methods
		public void Reset(); // 0x0000000184D8CAF0-0x0000000184D8CB00
	}
}
