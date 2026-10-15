/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using UnityEngine;

// Image 116: DOTweenPro.Runtime.dll - Assembly: DOTweenPro.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91003-91009

namespace DG.Tweening
{
	[AddComponentMenu("DOTween/DOTween Animation")]
	public class DOTweenAnimation : ABSAnimationComponent // TypeDefIndex: 91006
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
			add; // 0x0000000188C96EAC-0x0000000188C96F48
			remove; // 0x0000000188C96F48-0x0000000188C96FE4
		}
	
		// Nested types
		public enum AnimationType // TypeDefIndex: 91004
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
	
		public enum TargetType // TypeDefIndex: 91005
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
		public DOTweenAnimation(); // 0x0000000188C96CE0-0x0000000188C96EAC
	
		// Methods
		private static void Dispatch_OnReset(DOTweenAnimation anim); // 0x0000000188C965B8-0x0000000188C96608
		private void Awake(); // 0x0000000188C943E8-0x0000000188C94434
		private void Start(); // 0x0000000188C96AEC-0x0000000188C96B30
		private void Reset(); // 0x0000000188C96994-0x0000000188C9699C
		private void OnDestroy(); // 0x0000000188C9344C-0x0000000188C9348C
		public void RewindThenRecreateTween(); // 0x0000000188C969DC-0x0000000188C96A1C
		public void RewindThenRecreateTweenAndPlay(); // 0x0000000188C9699C-0x0000000188C969DC
		public void RecreateTween(); // 0x0000000188C96984-0x0000000188C96994
		public void RecreateTweenAndPlay(); // 0x0000000188C96974-0x0000000188C96984
		public void CreateTween(bool regenerateIfExists = false /* Metadata: 0x0264B1FD */, bool andPlay = true /* Metadata: 0x0264B1FE */); // 0x0000000188C9446C-0x0000000188C95C2C
		public List<Tween> GetTweens(); // 0x0000000188C96640-0x0000000188C9673C
		public void SetAnimationTarget(Component tweenTarget, bool useTweenTargetGameObjectForGroupOperations = true /* Metadata: 0x0264B1FF */); // 0x0000000188C96A1C-0x0000000188C96AEC
		public override void DOPlay(); // 0x0000000188C961DC-0x0000000188C9622C
		public override void DOPlayBackwards(); // 0x0000000188C95F28-0x0000000188C95F78
		public override void DOPlayForward(); // 0x0000000188C96084-0x0000000188C960D4
		public override void DOPause(); // 0x0000000188C95DE0-0x0000000188C95E30
		public override void DOTogglePause(); // 0x0000000188C96568-0x0000000188C965B8
		public override void DORewind(); // 0x0000000188C96480-0x0000000188C96568
		public override void DORestart(); // 0x0000000188C93124-0x0000000188C93134
		public override void DORestart(bool fromHere); // 0x0000000188C9630C-0x0000000188C963B4
		public override void DOComplete(); // 0x0000000188C95C2C-0x0000000188C95C7C
		public override void DOKill(); // 0x0000000188C95D28-0x0000000188C95D94
		public void DOPlayById(string id); // 0x0000000188C95F78-0x0000000188C95FD8
		public void DOPlayAllById(string id); // 0x0000000188C95E30-0x0000000188C95E7C
		public void DOPauseAllById(string id); // 0x0000000188C95D94-0x0000000188C95DE0
		public void DOPlayBackwardsById(string id); // 0x0000000188C95EC8-0x0000000188C95F28
		public void DOPlayBackwardsAllById(string id); // 0x0000000188C95E7C-0x0000000188C95EC8
		public void DOPlayForwardById(string id); // 0x0000000188C96024-0x0000000188C96084
		public void DOPlayForwardAllById(string id); // 0x0000000188C95FD8-0x0000000188C96024
		public void DOPlayNext(); // 0x0000000188C960D4-0x0000000188C961DC
		public void DORewindAndPlayNext(); // 0x0000000188C96410-0x0000000188C96480
		public void DORewindAllById(string id); // 0x0000000188C963B4-0x0000000188C96410
		public void DORestartById(string id); // 0x0000000188C96290-0x0000000188C9630C
		public void DORestartAllById(string id); // 0x0000000188C9622C-0x0000000188C96290
		public void DOKillById(string id); // 0x0000000188C95CC8-0x0000000188C95D28
		public void DOKillAllById(string id); // 0x0000000188C95C7C-0x0000000188C95CC8
		public static TargetType TypeToDOTargetType(System.Type t); // 0x0000000188C96B30-0x0000000188C96CE0
		public Tween CreateEditorPreview(); // 0x0000000188C94434-0x0000000188C9446C
		private GameObject GetTweenGO(); // 0x0000000188C96608-0x0000000188C96624
		private GameObject GetTweenTarget(); // 0x0000000188C96624-0x0000000188C96640
		private void ReEvaluateRelativeTween(); // 0x0000000188C9673C-0x0000000188C96974
		[CompilerGenerated]
		private void _CreateTween_b__54_0(); // 0x0000000188C93880-0x0000000188C93894
	}

	public static class DOTweenAnimationExtensions // TypeDefIndex: 91007
	{
		// Extension methods
		public static bool IsSameOrSubclassOf<T>(this Component t);
	}

	public static class DOTweenProShortcuts // TypeDefIndex: 91009
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 91008
		{
			// Fields
			public Transform target; // 0x10
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector3 _DOSpiral_b__0(); // 0x000000018691C000-0x000000018691C040
			internal void _DOSpiral_b__1(Vector3 x); // 0x0000000188C8AA8C-0x0000000188C8AAC4
		}
	
		// Constructors
		static DOTweenProShortcuts(); // 0x0000000188C97318-0x0000000188C97360
	
		// Extension methods
		public static Tweener DOSpiral(this Transform target, float duration, Vector3? axis = default, SpiralMode mode = SpiralMode.Expand /* Metadata: 0x0264B226 */, float speed = 1f /* Metadata: 0x0264B227 */, float frequency = 10f /* Metadata: 0x0264B22B */, float depth = 0f /* Metadata: 0x0264B22F */, bool snapping = false /* Metadata: 0x0264B233 */); // 0x0000000188C96FE4-0x0000000188C97318
	}
}
