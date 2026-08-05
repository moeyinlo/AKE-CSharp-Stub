/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using UnityEngine;

// Image 116: DOTweenPro.Runtime.dll - Assembly: DOTweenPro.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63559-63565
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace DG.Tweening
{
	[AddComponentMenu("DOTween/DOTween Animation")]
	public class DOTweenAnimation : ABSAnimationComponent // TypeDefIndex: 63562
	{
		// Fields
		[CompilerGenerated]
		private static Action<DOTweenAnimation> OnReset; // 0x00
		public bool targetIsSelf; // 0x68
		public GameObject targetGO; // 0x70
		public bool tweenTargetIsTargetGO; // 0x78
		public float delay; // 0x7C
		public float duration; // 0x80
		public Ease easeType; // 0x84
		public AnimationCurve easeCurve; // 0x88
		public LoopType loopType; // 0x90
		public int loops; // 0x94
		public string id; // 0x98
		public bool isRelative; // 0xA0
		public bool isFrom; // 0xA1
		public bool isIndependentUpdate; // 0xA2
		public bool autoKill; // 0xA3
		public bool autoGenerate; // 0xA4
		public bool isActive; // 0xA5
		public bool isValid; // 0xA6
		public Component target; // 0xA8
		public AnimationType animationType; // 0xB0
		public TargetType targetType; // 0xB4
		public TargetType forcedTargetType; // 0xB8
		public bool autoPlay; // 0xBC
		public bool useTargetAsV3; // 0xBD
		public float endValueFloat; // 0xC0
		public Vector3 endValueV3; // 0xC4
		public Vector2 endValueV2; // 0xD0
		public UnityEngine.Color endValueColor; // 0xD8
		public string endValueString; // 0xE8
		public Rect endValueRect; // 0xF0
		public Transform endValueTransform; // 0x100
		public bool optionalBool0; // 0x108
		public bool optionalBool1; // 0x109
		public float optionalFloat0; // 0x10C
		public int optionalInt0; // 0x110
		public RotateMode optionalRotationMode; // 0x114
		public ScrambleMode optionalScrambleMode; // 0x118
		public ShakeRandomnessMode optionalShakeRandomnessMode; // 0x11C
		public string optionalString; // 0x120
		private bool _tweenAutoGenerationCalled; // 0x128
		private int _playCount; // 0x12C
	
		// Events
		public static event Action<DOTweenAnimation> OnReset {
			add; // 0x0000000186977254-0x00000001869772F0
			remove; // 0x00000001869772F0-0x000000018697738C
		}
	
		// Nested types
		public enum AnimationType // TypeDefIndex: 63560
		{
			None = 0,
			Move = 1,
			LocalMove = 2,
			Rotate = 3,
			LocalRotate = 4,
			Scale = 5,
			Color = 6,
			Fade = 7,
			Text = 8,
			PunchPosition = 9,
			PunchRotation = 10,
			PunchScale = 11,
			ShakePosition = 12,
			ShakeRotation = 13,
			ShakeScale = 14,
			CameraAspect = 15,
			CameraBackgroundColor = 16,
			CameraFieldOfView = 17,
			CameraOrthoSize = 18,
			CameraPixelRect = 19,
			CameraRect = 20,
			UIWidthHeight = 21
		}
	
		public enum TargetType // TypeDefIndex: 63561
		{
			Unset = 0,
			Camera = 1,
			CanvasGroup = 2,
			Image = 3,
			Light = 4,
			RectTransform = 5,
			Renderer = 6,
			SpriteRenderer = 7,
			Rigidbody = 8,
			Rigidbody2D = 9,
			Text = 10,
			Transform = 11,
			tk2dBaseSprite = 12,
			tk2dTextMesh = 13,
			TextMeshPro = 14,
			TextMeshProUGUI = 15
		}
	
		// Constructors
		public DOTweenAnimation(); // 0x000000018697708C-0x0000000186977254
	
		// Methods
		private static void Dispatch_OnReset(DOTweenAnimation anim); // 0x0000000186976974-0x00000001869769C4
		private void Awake(); // 0x00000001869747AC-0x00000001869747F8
		private void Start(); // 0x0000000186976E98-0x0000000186976EDC
		private void Reset(); // 0x0000000186976D40-0x0000000186976D48
		private void OnDestroy(); // 0x0000000186973810-0x0000000186973850
		public void RewindThenRecreateTween(); // 0x0000000186976D88-0x0000000186976DC8
		public void RewindThenRecreateTweenAndPlay(); // 0x0000000186976D48-0x0000000186976D88
		public void RecreateTween(); // 0x0000000186976D30-0x0000000186976D40
		public void RecreateTweenAndPlay(); // 0x0000000186976D20-0x0000000186976D30
		public void CreateTween(bool regenerateIfExists = false /* Metadata: 0x02352877 */, bool andPlay = true /* Metadata: 0x02352878 */); // 0x0000000186974830-0x000000018697602C
		public List<Tween> GetTweens(); // 0x00000001869769FC-0x0000000186976AE8
		public void SetAnimationTarget(Component tweenTarget, bool useTweenTargetGameObjectForGroupOperations = true /* Metadata: 0x02352879 */); // 0x0000000186976DC8-0x0000000186976E98
		public override void DOPlay(); // 0x00000001869765D8-0x0000000186976628
		public override void DOPlayBackwards(); // 0x0000000186976324-0x0000000186976374
		public override void DOPlayForward(); // 0x0000000186976480-0x00000001869764D0
		public override void DOPause(); // 0x00000001869761DC-0x000000018697622C
		public override void DOTogglePause(); // 0x0000000186976924-0x0000000186976974
		public override void DORewind(); // 0x0000000186976864-0x0000000186976924
		public override void DORestart(); // 0x00000001869734E8-0x00000001869734F8
		public override void DORestart(bool fromHere); // 0x00000001869766FC-0x00000001869767A0
		public override void DOComplete(); // 0x000000018697602C-0x000000018697607C
		public override void DOKill(); // 0x0000000186976128-0x0000000186976190
		public void DOPlayById(string id); // 0x0000000186976374-0x00000001869763D4
		public void DOPlayAllById(string id); // 0x000000018697622C-0x0000000186976278
		public void DOPauseAllById(string id); // 0x0000000186976190-0x00000001869761DC
		public void DOPlayBackwardsById(string id); // 0x00000001869762C4-0x0000000186976324
		public void DOPlayBackwardsAllById(string id); // 0x0000000186976278-0x00000001869762C4
		public void DOPlayForwardById(string id); // 0x0000000186976420-0x0000000186976480
		public void DOPlayForwardAllById(string id); // 0x00000001869763D4-0x0000000186976420
		public void DOPlayNext(); // 0x00000001869764D0-0x00000001869765D8
		public void DORewindAndPlayNext(); // 0x00000001869767F8-0x0000000186976864
		public void DORewindAllById(string id); // 0x00000001869767A0-0x00000001869767F8
		public void DORestartById(string id); // 0x0000000186976688-0x00000001869766FC
		public void DORestartAllById(string id); // 0x0000000186976628-0x0000000186976688
		public void DOKillById(string id); // 0x00000001869760C8-0x0000000186976128
		public void DOKillAllById(string id); // 0x000000018697607C-0x00000001869760C8
		public static TargetType TypeToDOTargetType(System.Type t); // 0x0000000186976EDC-0x000000018697708C
		public Tween CreateEditorPreview(); // 0x00000001869747F8-0x0000000186974830
		private GameObject GetTweenGO(); // 0x00000001869769C4-0x00000001869769E0
		private GameObject GetTweenTarget(); // 0x00000001869769E0-0x00000001869769FC
		private void ReEvaluateRelativeTween(); // 0x0000000186976AE8-0x0000000186976D20
		[CompilerGenerated]
		private void _CreateTween_b__54_0(); // 0x0000000186973C40-0x0000000186973C54
	}

	public static class DOTweenAnimationExtensions // TypeDefIndex: 63563
	{
		// Extension methods
		public static bool IsSameOrSubclassOf<T>(this Component t);
	}

	public static class DOTweenProShortcuts // TypeDefIndex: 63565
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 63564
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector3 _DOSpiral_b__0(); // 0x000000018696AF74-0x000000018696AFB0
			internal void _DOSpiral_b__1(Vector3 x); // 0x000000018696AFB0-0x000000018696AFE8
		}
	
		// Constructors
		static DOTweenProShortcuts(); // 0x00000001869776C0-0x0000000186977708
	
		// Extension methods
		public static Tweener DOSpiral(this Transform target, float duration, Vector3? axis = default, SpiralMode mode = SpiralMode.Expand /* Metadata: 0x023528A0 */, float speed = 1f /* Metadata: 0x023528A1 */, float frequency = 10f /* Metadata: 0x023528A5 */, float depth = 0f /* Metadata: 0x023528A9 */, bool snapping = false /* Metadata: 0x023528AD */); // 0x000000018697738C-0x00000001869776C0
	}
}
