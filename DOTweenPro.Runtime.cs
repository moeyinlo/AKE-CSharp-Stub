/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using UnityEngine;

// Image 110: DOTweenPro.Runtime.dll - Assembly: DOTweenPro.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59804-59810
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace DG.Tweening
{
	[AddComponentMenu("DOTween/DOTween Animation")]
	public class DOTweenAnimation : ABSAnimationComponent // TypeDefIndex: 59807
	{
		// Fields
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
		public static event Action<DOTweenAnimation> OnReset;
	
		// Nested types
		public enum AnimationType // TypeDefIndex: 59805
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
	
		public enum TargetType // TypeDefIndex: 59806
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
		public DOTweenAnimation() {} // 0x000000018575930C-0x00000001857594D4
	
		// Methods
		private static void Dispatch_OnReset(DOTweenAnimation anim) {} // 0x0000000185758BF4-0x0000000185758C44
		private void Awake() {} // 0x0000000185756ADC-0x0000000185756B28
		private void Start() {} // 0x0000000185759118-0x000000018575915C
		private void Reset() {} // 0x0000000185758FC0-0x0000000185758FC8
		private void OnDestroy() {} // 0x0000000185755B40-0x0000000185755B80
		public void RewindThenRecreateTween() {} // 0x0000000185759008-0x0000000185759048
		public void RewindThenRecreateTweenAndPlay() {} // 0x0000000185758FC8-0x0000000185759008
		public void RecreateTween() {} // 0x0000000185758FB0-0x0000000185758FC0
		public void RecreateTweenAndPlay() {} // 0x0000000185758FA0-0x0000000185758FB0
		public void CreateTween(bool regenerateIfExists = false /* Metadata: 0x01FDD2A3 */, bool andPlay = true /* Metadata: 0x01FDD2A4 */) {} // 0x0000000185756B60-0x00000001857582AC
		public List<Tween> GetTweens() => default; // 0x0000000185758C7C-0x0000000185758D68
		public void SetAnimationTarget(Component tweenTarget, bool useTweenTargetGameObjectForGroupOperations = true /* Metadata: 0x01FDD2A5 */) {} // 0x0000000185759048-0x0000000185759118
		public override void DOPlay() {} // 0x0000000185758858-0x00000001857588A8
		public override void DOPlayBackwards() {} // 0x00000001857585A4-0x00000001857585F4
		public override void DOPlayForward() {} // 0x0000000185758700-0x0000000185758750
		public override void DOPause() {} // 0x000000018575845C-0x00000001857584AC
		public override void DOTogglePause() {} // 0x0000000185758BA4-0x0000000185758BF4
		public override void DORewind() {} // 0x0000000185758AE4-0x0000000185758BA4
		public override void DORestart() {} // 0x0000000185755818-0x0000000185755828
		public override void DORestart(bool fromHere) {} // 0x000000018575897C-0x0000000185758A20
		public override void DOComplete() {} // 0x00000001857582AC-0x00000001857582FC
		public override void DOKill() {} // 0x00000001857583A8-0x0000000185758410
		public void DOPlayById(string id) {} // 0x00000001857585F4-0x0000000185758654
		public void DOPlayAllById(string id) {} // 0x00000001857584AC-0x00000001857584F8
		public void DOPauseAllById(string id) {} // 0x0000000185758410-0x000000018575845C
		public void DOPlayBackwardsById(string id) {} // 0x0000000185758544-0x00000001857585A4
		public void DOPlayBackwardsAllById(string id) {} // 0x00000001857584F8-0x0000000185758544
		public void DOPlayForwardById(string id) {} // 0x00000001857586A0-0x0000000185758700
		public void DOPlayForwardAllById(string id) {} // 0x0000000185758654-0x00000001857586A0
		public void DOPlayNext() {} // 0x0000000185758750-0x0000000185758858
		public void DORewindAndPlayNext() {} // 0x0000000185758A78-0x0000000185758AE4
		public void DORewindAllById(string id) {} // 0x0000000185758A20-0x0000000185758A78
		public void DORestartById(string id) {} // 0x0000000185758908-0x000000018575897C
		public void DORestartAllById(string id) {} // 0x00000001857588A8-0x0000000185758908
		public void DOKillById(string id) {} // 0x0000000185758348-0x00000001857583A8
		public void DOKillAllById(string id) {} // 0x00000001857582FC-0x0000000185758348
		public static TargetType TypeToDOTargetType(System.Type t) => default; // 0x000000018575915C-0x000000018575930C
		public Tween CreateEditorPreview() => default; // 0x0000000185756B28-0x0000000185756B60
		private GameObject GetTweenGO() => default; // 0x0000000185758C44-0x0000000185758C60
		private GameObject GetTweenTarget() => default; // 0x0000000185758C60-0x0000000185758C7C
		private void ReEvaluateRelativeTween() {} // 0x0000000185758D68-0x0000000185758FA0
	}

	public static class DOTweenAnimationExtensions // TypeDefIndex: 59808
	{
		// Extension methods
		public static bool IsSameOrSubclassOf<T>(this Component t) => default;
	}

	public static class DOTweenProShortcuts // TypeDefIndex: 59810
	{
		// Constructors
		static DOTweenProShortcuts() {} // 0x0000000185759904-0x000000018575994C
	
		// Extension methods
		public static Tweener DOSpiral(this Transform target, float duration, Vector3? axis = default, SpiralMode mode = SpiralMode.Expand /* Metadata: 0x01FDD2CC */, float speed = 1f /* Metadata: 0x01FDD2CD */, float frequency = 10f /* Metadata: 0x01FDD2D1 */, float depth = 0f /* Metadata: 0x01FDD2D5 */, bool snapping = false /* Metadata: 0x01FDD2D9 */) => default; // 0x000000018575960C-0x0000000185759904
	}
}
