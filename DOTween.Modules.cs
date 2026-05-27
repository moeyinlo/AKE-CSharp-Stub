/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DG.Tweening.Core;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Image 91: DOTween.Modules.dll - Assembly: DOTween.Modules, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59363-59424
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace DG.Tweening
{
	public static class DOTweenModuleUI // TypeDefIndex: 59406
	{
		// Nested types
		public static class Utils // TypeDefIndex: 59364
		{
			// Methods
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to) => default; // 0x00000001857545B4-0x0000000185754788
		}
	
		// Extension methods
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration) => default; // 0x0000000182D50010-0x0000000182D50190
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(this Graphic target, UnityEngine.Color endValue, float duration) => default; // 0x000000018574F7A8-0x000000018574F910
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration) => default; // 0x000000018574FEDC-0x0000000185750038
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(this Image target, UnityEngine.Color endValue, float duration) => default; // 0x000000018574F910-0x000000018574FA78
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOFade(this Image target, float endValue, float duration) => default; // 0x0000000182D4CBB0-0x0000000182D4CD30
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration) => default; // 0x0000000183A2D5C0-0x0000000183A2D740
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration) => default; // 0x00000001857501B8-0x0000000185750374
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false /* Metadata: 0x01FDD030 */) => default; // 0x0000000185750038-0x00000001857501B8
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false /* Metadata: 0x01FDD031 */) => default; // 0x00000001857508FC-0x0000000185750A7C
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false /* Metadata: 0x01FDD032 */) => default; // 0x0000000185751054-0x00000001857511D4
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(this Outline target, UnityEngine.Color endValue, float duration) => default; // 0x000000018574F4D8-0x000000018574F640
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOFade(this Outline target, float endValue, float duration) => default; // 0x000000018574FD80-0x000000018574FEDC
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration) => default; // 0x0000000185751390-0x00000001857514F0
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false /* Metadata: 0x01FDD033 */) => default; // 0x00000001822C45E0-0x00000001822C4770
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false /* Metadata: 0x01FDD034 */) => default; // 0x0000000183864380-0x0000000183864530
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false /* Metadata: 0x01FDD035 */) => default; // 0x000000018574EDE0-0x000000018574EF68
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false /* Metadata: 0x01FDD036 */) => default; // 0x000000018574EC50-0x000000018574EDE0
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false /* Metadata: 0x01FDD037 */) => default; // 0x000000018574E768-0x000000018574E908
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false /* Metadata: 0x01FDD038 */) => default; // 0x000000018574E908-0x000000018574EAAC
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false /* Metadata: 0x01FDD039 */) => default; // 0x000000018574EAAC-0x000000018574EC50
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false /* Metadata: 0x01FDD03A */) => default; // 0x000000018574E468-0x000000018574E5E8
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false /* Metadata: 0x01FDD03B */) => default; // 0x000000018574E5E8-0x000000018574E768
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration) => default; // 0x0000000185750EF4-0x0000000185751054
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration) => default; // 0x0000000185750BF0-0x0000000185750D78
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration) => default; // 0x0000000185750D78-0x0000000185750EF4
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false /* Metadata: 0x01FDD03C */) => default; // 0x0000000182D50190-0x0000000182D50330
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10 /* Metadata: 0x01FDD03D */, float elasticity = 1f /* Metadata: 0x01FDD03E */, bool snapping = false /* Metadata: 0x01FDD042 */) => default; // 0x00000001857511D4-0x0000000185751390
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f /* Metadata: 0x01FDD043 */, int vibrato = 10 /* Metadata: 0x01FDD047 */, float randomness = 90f /* Metadata: 0x01FDD048 */, bool snapping = false /* Metadata: 0x01FDD04C */, bool fadeOut = true /* Metadata: 0x01FDD04D */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x01FDD04E */) => default; // 0x00000001857516E8-0x00000001857518B0
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10 /* Metadata: 0x01FDD04F */, float randomness = 90f /* Metadata: 0x01FDD050 */, bool snapping = false /* Metadata: 0x01FDD054 */, bool fadeOut = true /* Metadata: 0x01FDD055 */, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full /* Metadata: 0x01FDD056 */) => default; // 0x00000001857514F0-0x00000001857516E8
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false /* Metadata: 0x01FDD057 */) => default; // 0x00000001857504E4-0x00000001857508FC
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false /* Metadata: 0x01FDD058 */) => default; // 0x0000000185750A7C-0x0000000185750BF0
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false /* Metadata: 0x01FDD059 */) => default; // 0x0000000185750374-0x00000001857504E4
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false /* Metadata: 0x01FDD05A */) => default; // 0x0000000185751DB0-0x0000000185751F20
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false /* Metadata: 0x01FDD05B */) => default; // 0x0000000185751C38-0x0000000185751DB0
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOColor(this UnityEngine.UI.Text target, UnityEngine.Color endValue, float duration) => default; // 0x000000018574F640-0x000000018574F7A8
		public static TweenerCore<int, int, NoOptions> DOCounter(this UnityEngine.UI.Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true /* Metadata: 0x01FDD05C */, CultureInfo culture = null) => default; // 0x000000018574FA78-0x000000018574FC24
		public static TweenerCore<UnityEngine.Color, UnityEngine.Color, ColorOptions> DOFade(this UnityEngine.UI.Text target, float endValue, float duration) => default; // 0x000000018574FC24-0x000000018574FD80
		public static TweenerCore<string, string, StringOptions> DOText(this UnityEngine.UI.Text target, string endValue, float duration, bool richTextEnabled = true /* Metadata: 0x01FDD05D */, ScrambleMode scrambleMode = ScrambleMode.None /* Metadata: 0x01FDD05E */, string scrambleChars = null) => default; // 0x0000000185751A70-0x0000000185751C38
		public static Tweener DOBlendableColor(this Graphic target, UnityEngine.Color endValue, float duration) => default; // 0x000000018574F138-0x000000018574F308
		public static Tweener DOBlendableColor(this Image target, UnityEngine.Color endValue, float duration) => default; // 0x000000018574EF68-0x000000018574F138
		public static Tweener DOBlendableColor(this UnityEngine.UI.Text target, UnityEngine.Color endValue, float duration) => default; // 0x000000018574F308-0x000000018574F4D8
		public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false /* Metadata: 0x01FDD05F */, bool snapping = false /* Metadata: 0x01FDD060 */) => default; // 0x00000001857518B0-0x0000000185751A70
	}

	public static class DOTweenModuleUnityVersion // TypeDefIndex: 59415
	{
		// Extension methods
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration) => default; // 0x0000000185752534-0x00000001857526F0
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration) => default; // 0x0000000185752368-0x0000000185752534
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction) => default; // 0x0000000185752A30-0x0000000185752AB4
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction) => default; // 0x0000000185752C60-0x0000000185752CE4
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction) => default; // 0x0000000185752B48-0x0000000185752BCC
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction) => default; // 0x0000000185752AB4-0x0000000185752B48
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction) => default; // 0x0000000185752BCC-0x0000000185752C60
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction) => default; // 0x0000000185752CE4-0x0000000185752D68
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration) => default; // 0x00000001857526F0-0x0000000185752890
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration) => default; // 0x0000000185752890-0x0000000185752A30
		public static async System.Threading.Tasks.Task AsyncWaitForCompletion(this Tween t) => default; // 0x0000000185751F20-0x0000000185751FD0
		public static async System.Threading.Tasks.Task AsyncWaitForRewind(this Tween t) => default; // 0x0000000185752208-0x00000001857522B8
		public static async System.Threading.Tasks.Task AsyncWaitForKill(this Tween t) => default; // 0x0000000185752090-0x0000000185752140
		public static async System.Threading.Tasks.Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops) => default; // 0x0000000185751FD0-0x0000000185752090
		public static async System.Threading.Tasks.Task AsyncWaitForPosition(this Tween t, float position) => default; // 0x0000000185752140-0x0000000185752208
		public static async System.Threading.Tasks.Task AsyncWaitForStart(this Tween t) => default; // 0x00000001857522B8-0x0000000185752368
	}

	public static class DOTweenCYInstruction // TypeDefIndex: 59422
	{
		// Nested types
		public class WaitForCompletion : CustomYieldInstruction // TypeDefIndex: 59416
		{
			// Fields
			private readonly Tween t; // 0x10
	
			// Properties
			public override bool keepWaiting { get => default; } // 0x0000000185754788-0x00000001857547BC 
	
			// Constructors
			public WaitForCompletion() {} // Dummy constructor
			public WaitForCompletion(Tween tween) {} // 0x000000018426FEE0-0x000000018426FEF0
		}
	
		public class WaitForRewind : CustomYieldInstruction // TypeDefIndex: 59417
		{
			// Fields
			private readonly Tween t; // 0x10
	
			// Properties
			public override bool keepWaiting { get => default; } // 0x0000000185754898-0x0000000185754900 
	
			// Constructors
			public WaitForRewind() {} // Dummy constructor
			public WaitForRewind(Tween tween) {} // 0x000000018426FEE0-0x000000018426FEF0
		}
	
		public class WaitForKill : CustomYieldInstruction // TypeDefIndex: 59418
		{
			// Fields
			private readonly Tween t; // 0x10
	
			// Properties
			public override bool keepWaiting { get => default; } // 0x00000001857547F8-0x0000000185754818 
	
			// Constructors
			public WaitForKill() {} // Dummy constructor
			public WaitForKill(Tween tween) {} // 0x000000018426FEE0-0x000000018426FEF0
		}
	
		public class WaitForElapsedLoops : CustomYieldInstruction // TypeDefIndex: 59419
		{
			// Fields
			private readonly Tween t; // 0x10
			private readonly int elapsedLoops; // 0x18
	
			// Properties
			public override bool keepWaiting { get => default; } // 0x00000001857547BC-0x00000001857547F8 
	
			// Constructors
			public WaitForElapsedLoops() {} // Dummy constructor
			public WaitForElapsedLoops(Tween tween, int elapsedLoops) {} // 0x0000000182738A30-0x0000000182738A50
		}
	
		public class WaitForPosition : CustomYieldInstruction // TypeDefIndex: 59420
		{
			// Fields
			private readonly Tween t; // 0x10
			private readonly float position; // 0x18
	
			// Properties
			public override bool keepWaiting { get => default; } // 0x0000000185754838-0x0000000185754898 
	
			// Constructors
			public WaitForPosition() {} // Dummy constructor
			public WaitForPosition(Tween tween, float position) {} // 0x0000000185754818-0x0000000185754838
		}
	
		public class WaitForStart : CustomYieldInstruction // TypeDefIndex: 59421
		{
			// Fields
			private readonly Tween t; // 0x10
	
			// Properties
			public override bool keepWaiting { get => default; } // 0x0000000185754900-0x0000000185754930 
	
			// Constructors
			public WaitForStart() {} // Dummy constructor
			public WaitForStart(Tween tween) {} // 0x000000018426FEE0-0x000000018426FEF0
		}
	}

	public static class DOTweenModuleUtils // TypeDefIndex: 59424
	{
		// Fields
		private static bool _initialized; // 0x00
	
		// Nested types
		public static class Physics // TypeDefIndex: 59423
		{
			// Methods
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans) {} // 0x0000000185752E64-0x0000000185752E94
			public static bool HasRigidbody2D(Component target) => default; // 0x000000018115F4C0-0x000000018115F530
			[UnityEngine.Scripting.Preserve]
			public static bool HasRigidbody(Component target) => default; // 0x000000018115F4C0-0x000000018115F530
			[UnityEngine.Scripting.Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode) => default; // 0x0000000185752DF8-0x0000000185752E64
		}
	
		// Methods
		[UnityEngine.Scripting.Preserve]
		public static void Init() {} // 0x0000000183B36420-0x0000000183B364C0
		[UnityEngine.Scripting.Preserve]
		private static void Preserver() {} // 0x0000000185752D68-0x0000000185752DF8
	}
}
