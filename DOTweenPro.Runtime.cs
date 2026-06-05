/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using DG.Tweening.Core;
using UnityEngine;

// Image 113: DOTweenPro.Runtime.dll - Assembly: DOTweenPro.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60908-60914

namespace DG.Tweening
{
	public class DOTweenAnimation : ABSAnimationComponent // TypeDefIndex: 60911
	{
		// Fields
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
		public static event Action<DOTweenAnimation> OnReset;
	
		// Nested types
		public enum AnimationType // TypeDefIndex: 60909
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
	
		public enum TargetType // TypeDefIndex: 60910
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
		public DOTweenAnimation() {} // 0x000000018790BDA4-0x000000018790BF6C
	
		// Methods
		private static void Dispatch_OnReset(DOTweenAnimation anim) {} // 0x000000018790B68C-0x000000018790B6DC
		private void Awake() {} // 0x0000000187909574-0x00000001879095C0
		private void Start() {} // 0x000000018790BBB0-0x000000018790BBF4
		private void Reset() {} // 0x000000018790BA58-0x000000018790BA60
		private void OnDestroy() {} // 0x00000001879085D8-0x0000000187908618
		public void RewindThenRecreateTween() {} // 0x000000018790BAA0-0x000000018790BAE0
		public void RewindThenRecreateTweenAndPlay() {} // 0x000000018790BA60-0x000000018790BAA0
		public void RecreateTween() {} // 0x000000018790BA48-0x000000018790BA58
		public void RecreateTweenAndPlay() {} // 0x000000018790BA38-0x000000018790BA48
		public void CreateTween(bool regenerateIfExists = false /* Metadata: 0x02082B8F */, bool andPlay = true /* Metadata: 0x02082B90 */) {} // 0x00000001879095F8-0x000000018790AD44
		public List<Tween> GetTweens() => default; // 0x000000018790B714-0x000000018790B800
		public void SetAnimationTarget(Component tweenTarget, bool useTweenTargetGameObjectForGroupOperations = true /* Metadata: 0x02082B91 */) {} // 0x000000018790BAE0-0x000000018790BBB0
		public override void DOPlay() {} // 0x000000018790B2F0-0x000000018790B340
		public override void DOPlayBackwards() {} // 0x000000018790B03C-0x000000018790B08C
		public override void DOPlayForward() {} // 0x000000018790B198-0x000000018790B1E8
		public override void DOPause() {} // 0x000000018790AEF4-0x000000018790AF44
		public override void DOTogglePause() {} // 0x000000018790B63C-0x000000018790B68C
		public override void DORewind() {} // 0x000000018790B57C-0x000000018790B63C
		public override void DORestart() {} // 0x00000001879082B0-0x00000001879082C0
		public override void DORestart(bool fromHere) {} // 0x000000018790B414-0x000000018790B4B8
		public override void DOComplete() {} // 0x000000018790AD44-0x000000018790AD94
		public override void DOKill() {} // 0x000000018790AE40-0x000000018790AEA8
		public void DOPlayById(string id) {} // 0x000000018790B08C-0x000000018790B0EC
		public void DOPlayAllById(string id) {} // 0x000000018790AF44-0x000000018790AF90
		public void DOPauseAllById(string id) {} // 0x000000018790AEA8-0x000000018790AEF4
		public void DOPlayBackwardsById(string id) {} // 0x000000018790AFDC-0x000000018790B03C
		public void DOPlayBackwardsAllById(string id) {} // 0x000000018790AF90-0x000000018790AFDC
		public void DOPlayForwardById(string id) {} // 0x000000018790B138-0x000000018790B198
		public void DOPlayForwardAllById(string id) {} // 0x000000018790B0EC-0x000000018790B138
		public void DOPlayNext() {} // 0x000000018790B1E8-0x000000018790B2F0
		public void DORewindAndPlayNext() {} // 0x000000018790B510-0x000000018790B57C
		public void DORewindAllById(string id) {} // 0x000000018790B4B8-0x000000018790B510
		public void DORestartById(string id) {} // 0x000000018790B3A0-0x000000018790B414
		public void DORestartAllById(string id) {} // 0x000000018790B340-0x000000018790B3A0
		public void DOKillById(string id) {} // 0x000000018790ADE0-0x000000018790AE40
		public void DOKillAllById(string id) {} // 0x000000018790AD94-0x000000018790ADE0
		public static TargetType TypeToDOTargetType(System.Type t) => default; // 0x000000018790BBF4-0x000000018790BDA4
		public Tween CreateEditorPreview() => default; // 0x00000001879095C0-0x00000001879095F8
		private GameObject GetTweenGO() => default; // 0x000000018790B6DC-0x000000018790B6F8
		private GameObject GetTweenTarget() => default; // 0x000000018790B6F8-0x000000018790B714
		private void ReEvaluateRelativeTween() {} // 0x000000018790B800-0x000000018790BA38
		private void _CreateTween_b__54_0() {} // 0x0000000187908A08-0x0000000187908A1C
	}

	public static class DOTweenAnimationExtensions // TypeDefIndex: 60912
	{
		// Methods
		public static bool IsSameOrSubclassOf<T>(Component t) => default;
	}

	public static class DOTweenProShortcuts // TypeDefIndex: 60914
	{
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 60913
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass1_0() {} // 0x000000018790C39C-0x000000018790C3E4
	
			// Methods
			internal Vector3 _DOSpiral_b__0() => default; // 0x000000018790C0A4-0x000000018790C39C
			internal void _DOSpiral_b__1(Vector3 x) {} // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		static DOTweenProShortcuts() {} // 0x00000001878FFF2C-0x00000001878FFF68
	
		// Methods
		public static Tweener DOSpiral(Transform target, float duration, Vector3? axis = default, SpiralMode mode = SpiralMode.Expand /* Metadata: 0x02082BB8 */, float speed = 1f /* Metadata: 0x02082BB9 */, float frequency = 10f /* Metadata: 0x02082BBD */, float depth = 0f /* Metadata: 0x02082BC1 */, bool snapping = false /* Metadata: 0x02082BC5 */) => default; // 0x00000001878FFF68-0x00000001878FFFA0
	}
}
