/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Slate;
using Slate.ActionClips;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

// Image 35: Slate.dll - Assembly: Slate, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 55546-55818

namespace Slate
{
	public class DirectorCamera : MonoBehaviour, IDirectableCamera // TypeDefIndex: 55547
	{
		// Fields
		private bool _matchMainWhenActive; // 0x18
		private bool _setMainWhenActive; // 0x19
		private bool _autoHandleActiveState; // 0x1A
		private bool _ignoreFOVChanges; // 0x1B
		private bool _dontDestroyOnLoad; // 0x1C
		public const float MAX_DAMP = 3f; // Metadata: 0x0207BF0C
		private static Action<IDirectableCamera> onCut; // 0x00
		private static Action onActivate; // 0x08
		private static Action onDeactivate; // 0x10
		private static DirectorCamera _current; // 0x18
		private static Camera _cam; // 0x20
		private static IDirectableCamera lastTargetShot; // 0x28
		private float _focalDistance_k__BackingField; // 0x20
		private float _focalLength_k__BackingField; // 0x24
		private float _focalAperture_k__BackingField; // 0x28
		private static GameCamera _gameCamera_k__BackingField; // 0x30
		private static bool _isEnabled_k__BackingField; // 0x38
		private static float noiseTimer; // 0x3C
		private static Vector3 noisePosOffset; // 0x40
		private static Vector3 noiseRotOffset; // 0x4C
		private static Vector3 noiseTargetPosOffset; // 0x58
		private static Vector3 noiseTargetRotOffset; // 0x64
		private static Vector3 noiseCamPosVel; // 0x70
		private static Vector3 noiseCamRotVel; // 0x7C
	
		// Properties
		public static DirectorCamera current { get => default; } // 0x000000018B7A9F68-0x000000018B7AA14C 
		public Camera cam { get => default; } // 0x000000018B7A9E38-0x000000018B7A9F68 
		public Vector3 position { get => default; set {} } // 0x000000018B7AA27C-0x000000018B7AA2D0 0x000000018B7AA6E4-0x000000018B7AA738
		public Quaternion rotation { get => default; set {} } // 0x000000018B7AA2F4-0x000000018B7AA340 0x000000018B7AA738-0x000000018B7AA784
		public float fieldOfView { get => default; set {} } // 0x000000018B7AA16C-0x000000018B7AA1CC 0x000000018B7AA5A4-0x000000018B7AA60C
		public float focalDistance { get; set; } // 0x0000000181C9AC70-0x0000000181C9AC80 0x0000000181C9A5B0-0x0000000181C9A5C0
		public float focalLength { get; set; } // 0x0000000185FB3810-0x0000000185FB3820 0x0000000185FB3820-0x0000000185FB3830
		public float focalAperture { get; set; } // 0x0000000185FB0A50-0x0000000185FB0A60 0x0000000185FB0A60-0x0000000185FB0A70
		public static bool matchMainWhenActive { get => default; set {} } // 0x000000018B7AA25C-0x000000018B7AA27C 0x000000018B7AA6C0-0x000000018B7AA6E4
		public static bool setMainWhenActive { get => default; set {} } // 0x000000018B7AA340-0x000000018B7AA360 0x000000018B7AA784-0x000000018B7AA7A8
		public static bool autoHandleActiveState { get => default; set {} } // 0x000000018B7A9E18-0x000000018B7A9E38 0x000000018B7AA55C-0x000000018B7AA580
		public static bool ignoreFOVChanges { get => default; set {} } // 0x000000018B7AA204-0x000000018B7AA224 0x000000018B7AA660-0x000000018B7AA684
		public static bool dontDestroyOnLoad { get => default; set {} } // 0x000000018B7AA14C-0x000000018B7AA16C 0x000000018B7AA580-0x000000018B7AA5A4
		public static Camera renderCamera { get => default; } // 0x000000018B7AA2D0-0x000000018B7AA2F4 
		public static GameCamera gameCamera { get; set; } // 0x000000018B7AA1CC-0x000000018B7AA204 0x000000018B7AA60C-0x000000018B7AA660
		public static bool isEnabled { get; private set; } // 0x000000018B7AA224-0x000000018B7AA25C 0x000000018B7AA684-0x000000018B7AA6C0
		GameObject IDirectableCamera.gameObject { get => default; } // 0x000000018646E428-0x000000018646E430 
	
		// Events
		public static event Action<IDirectableCamera> onCut;
		public static event Action onActivate;
		public static event Action onDeactivate;
	
		// Constructors
		public DirectorCamera() {} // 0x0000000185FA29A0-0x0000000185FA29C0
	
		// Methods
		private void Awake() {} // 0x000000018B7A8D44-0x000000018B7A8E68
		private Camera CreateRenderCamera() => default; // 0x000000018B7A8E68-0x000000018B7A9000
		public static void Enable() {} // 0x000000018B7A9128-0x000000018B7A9544
		public static void Disable() {} // 0x000000018B7A9000-0x000000018B7A9128
		public static void Update(IDirectableCamera source, IDirectableCamera target, Slate.EaseType interpolation, float weight, float damping = 0f /* Metadata: 0x0207BF08 */) {} // 0x000000018B7A9544-0x000000018B7A9C1C
		public static void ApplyNoise(float magnitude, float weight) {} // 0x000000018B7A8958-0x000000018B7A8D44
	}

	public class DirectorGUI : MonoBehaviour // TypeDefIndex: 55554
	{
		// Fields
		private static SubtitlesGUIDelegate OnSubtitlesGUI; // 0x00
		private static TextOverlayGUIDelegate OnTextOverlayGUI; // 0x08
		private static ImageOverlayGUIDelegate OnImageOverlayGUI; // 0x10
		private static ScreenFadeGUIDelegate OnScreenFadeGUI; // 0x18
		private static LetterboxGUIDelegate OnLetterboxGUI; // 0x20
		private static CameraDissolveDelegate OnCameraDissolve; // 0x28
		private static Action OnGUIEnable; // 0x30
		private static Action OnGUIDisable; // 0x38
		[NonSerialized]
		private static DirectorGUI _current; // 0x40
		private static UnityEngine.Color _lastFadeColor_k__BackingField; // 0x48
	
		// Properties
		public static DirectorGUI current { get => default; } // 0x00000001864BB614-0x00000001864BB734 
		public static UnityEngine.Color lastFadeColor { get; private set; } // 0x00000001833EEC70-0x00000001833EEC80 0x000000018B7ACAB8-0x000000018B7ACB34
	
		// Events
		public static event SubtitlesGUIDelegate OnSubtitlesGUI;
		public static event TextOverlayGUIDelegate OnTextOverlayGUI;
		public static event ImageOverlayGUIDelegate OnImageOverlayGUI;
		public static event ScreenFadeGUIDelegate OnScreenFadeGUI;
		public static event LetterboxGUIDelegate OnLetterboxGUI;
		public static event CameraDissolveDelegate OnCameraDissolve;
		public static event Action OnGUIEnable;
		public static event Action OnGUIDisable;
	
		// Nested types
		public delegate void SubtitlesGUIDelegate(string text, UnityEngine.Color color); // TypeDefIndex: 55548; 0x000000018B7AB844-0x000000018B7AB8EC
	
		public delegate void TextOverlayGUIDelegate(string text, UnityEngine.Color color, float size, TextAnchor alignment, Vector2 position); // TypeDefIndex: 55549; 0x000000018B7AB634-0x000000018B7AB6E4
	
		public delegate void ImageOverlayGUIDelegate(Texture texture, UnityEngine.Color color, Vector2 scale, Vector2 position); // TypeDefIndex: 55550; 0x000000018B7AB6E4-0x000000018B7AB794
	
		public delegate void ScreenFadeGUIDelegate(UnityEngine.Color color); // TypeDefIndex: 55551; 0x000000018B7AB584-0x000000018B7AB634
	
		public delegate void LetterboxGUIDelegate(float completion); // TypeDefIndex: 55552; 0x000000018B7AA7A8-0x000000018B7AA888
	
		public delegate void CameraDissolveDelegate(Texture texture, float completion); // TypeDefIndex: 55553; 0x000000018B7AA9E0-0x000000018B7AAA44
	
		// Constructors
		public DirectorGUI() {} // 0x00000001864BB614-0x00000001864BB734
	
		// Methods
		private void Awake() {} // 0x00000001889CC0A8-0x00000001889CC170
		private void OnEnable() {} // 0x0000000185FA9450-0x0000000185FA9480
		private void OnDisable() {} // 0x000000018B7AD16C-0x000000018B7AD1EC
		public static void UpdateLetterbox(float completion) {} // 0x00000001864BB614-0x00000001864BB734
		public static void UpdateDissolve(Texture texture, float completion) {} // 0x0000000189EDDCC4-0x0000000189EDDD8C
		public static void UpdateFade(UnityEngine.Color color) {} // 0x00000001864BB614-0x00000001864BB734
		public static void UpdateSubtitles(string text, UnityEngine.Color color) {} // 0x000000018B7A1934-0x000000018B7A1A5C
		public static void UpdateOverlayText(string text, UnityEngine.Color color, float size, TextAnchor anchor, Vector2 pos) {} // 0x00000001831C5680-0x00000001831C5690
		public static void UpdateOverlayImage(Texture texture, UnityEngine.Color color, Vector2 scale, Vector2 positionOffset) {} // 0x000000018B7A18B4-0x000000018B7A1934
	}

	[Serializable]
	public class DynamicCameraController // TypeDefIndex: 55560
	{
		// Fields
		private const float MIN_DAMP = 0.5f; // Metadata: 0x0207BF10
		private const float MAX_DAMP = 10f; // Metadata: 0x0207BF14
		private Transposer _transposer; // 0x10
		private Composer _composer; // 0x18
		private int lastUpdateFrame; // 0x20
	
		// Properties
		public Transposer transposer { get => default; } // 0x000000018B7AC77C-0x000000018B7AC794 
		public Composer composer { get => default; } // 0x000000018B7AC794-0x000000018B7AC7AC 
		public bool controlsPosition { get => default; } // 0x000000018B7AC760-0x000000018B7AC77C 
		public bool controlsRotation { get => default; } // 0x000000018B7ABA54-0x000000018B7ABA70 
		public bool controlsFieldOfView { get => default; } // 0x000000018B7ABA70-0x000000018B7ABA8C 
	
		// Nested types
		[Serializable]
		public class Transposer // TypeDefIndex: 55557
		{
			// Fields
			public TrackingMode trackingMode; // 0x10
			public Transform target; // 0x18
			public Vector3 targetOffset; // 0x20
			public OffsetMode offsetMode; // 0x2C
			public Vector3 railStart; // 0x30
			public Vector3 railEnd; // 0x3C
			public float railOffset; // 0x48
			public float smoothDamping; // 0x4C
	
			// Nested types
			public enum TrackingMode // TypeDefIndex: 55555
			{
				None = 0,
				OffsetTracking = 1,
				RailTracking = 2
			}
	
			public enum OffsetMode // TypeDefIndex: 55556
			{
				LocalSpace = 0,
				WorldSpace = 1
			}
	
			// Constructors
			public Transposer() {} // 0x000000018346D130-0x000000018346D140
		}
	
		[Serializable]
		public class Composer // TypeDefIndex: 55559
		{
			// Fields
			public TrackingMode trackingMode; // 0x10
			public Transform target; // 0x18
			public Vector3 targetOffset; // 0x20
			public float targetSize; // 0x2C
			public Vector2 frameCenter; // 0x30
			public Vector2 frameExtends; // 0x38
			public float dutchTilt; // 0x40
			public bool zoomAtTargetFrame; // 0x44
			public float smoothDamping; // 0x48
	
			// Nested types
			public enum TrackingMode // TypeDefIndex: 55558
			{
				None = 0,
				FrameComposition = 1
			}
	
			// Constructors
			public Composer() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		// Constructors
		public DynamicCameraController() {} // 0x0000000185FD5BA0-0x0000000185FD5BC0
	
		// Methods
		public void UpdateControllerHard(IDirectableCamera directableCamera, IDirectable directable) {} // 0x000000018B7ABA8C-0x000000018B7AC6B4
		public void UpdateControllerSoft(IDirectableCamera directableCamera, IDirectable directable) {} // 0x000000018B7AC6B4-0x000000018B7AC760
		private void UpdateController(IDirectableCamera directableCamera, IDirectable directable, bool isHard) {} // 0x0000000185FD5C20-0x0000000185FD5C80
	}

	public class GameCamera : MonoBehaviour, IDirectableCamera // TypeDefIndex: 55561
	{
		// Fields
		private Camera _cam; // 0x18
	
		// Properties
		public Camera cam { get => default; } // 0x000000018B7AC7AC-0x000000018B7AC838 
		public Vector3 position { get => default; set {} } // 0x000000018A6E8BAC-0x000000018A6E8BF4 0x0000000185492010-0x0000000185492020
		public Quaternion rotation { get => default; set {} } // 0x000000018A6E8BF4-0x000000018A6E8C38 0x0000000185492010-0x0000000185492020
		public float fieldOfView { get => default; set {} } // 0x000000018B7AC838-0x000000018B7AC898 0x0000000185492010-0x0000000185492020
		public float focalDistance { get => default; set {} } // 0x0000000185FBF670-0x0000000185FBF680 0x0000000185492010-0x0000000185492020
		public float focalLength { get => default; set {} } // 0x0000000185FD5C10-0x0000000185FD5C20 0x0000000185492010-0x0000000185492020
		public float focalAperture { get => default; set {} } // 0x00000001831FB170-0x00000001831FB180 0x0000000185492010-0x0000000185492020
		GameObject IDirectableCamera.gameObject { get => default; } // 0x000000018646E428-0x000000018646E430 
	
		// Constructors
		public GameCamera() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public interface IDirectableCamera // TypeDefIndex: 55562
	{
		// Properties
		GameObject gameObject { get; }
		Camera cam { get; }
		Vector3 position { get; set; }
		Quaternion rotation { get; set; }
		float fieldOfView { get; set; }
		float focalDistance { get; set; }
		float focalLength { get; set; }
		float focalAperture { get; set; }
	}

	public class ShotCamera : MonoBehaviour, IDirectableCamera // TypeDefIndex: 55564
	{
		// Fields
		public const string DEFAULT_NAME = "Shot Camera"; // Metadata: 0x0207BF1F
		private DynamicCameraController _dynamicController; // 0x18
		private float _focalDistance; // 0x20
		private float _focalLength; // 0x24
		private float _focalAperture; // 0x28
		private Camera _cam; // 0x30
	
		// Properties
		public Camera cam { get => default; } // 0x0000000187AF3598-0x0000000187AF35DC 
		public Vector3 position { get => default; set {} } // 0x000000018A6E8BF4-0x000000018A6E8C38 0x0000000187AF117C-0x0000000187AF11B8
		public Quaternion rotation { get => default; set {} } // 0x000000018B7ADC58-0x000000018B7ADCA0 0x000000018B7ADD6C-0x000000018B7ADDB0
		public Vector3 localPosition { get => default; set {} } // 0x000000018B7ADBE4-0x000000018B7ADC58 0x000000018B7ADCF8-0x000000018B7ADD6C
		public Vector3 localEulerAngles { get => default; set {} } // 0x000000018B7ADB84-0x000000018B7ADBE4 0x000000018B7ADCA0-0x000000018B7ADCF8
		public float fieldOfView { get => default; set {} } // 0x0000000181C9AC70-0x0000000181C9AC80 0x0000000181C9A5B0-0x0000000181C9A5C0
		public float focalDistance { get => default; set {} } // 0x0000000185FB3810-0x0000000185FB3820 0x0000000185FB3820-0x0000000185FB3830
		public float focalLength { get => default; set {} } // 0x0000000185FB0A50-0x0000000185FB0A60 0x0000000185FB0A60-0x0000000185FB0A70
		public float focalAperture { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x000000018B7ADB54-0x000000018B7ADB6C
		public DynamicCameraController dynamicController { get => default; } // 0x000000018B7ADB6C-0x000000018B7ADB84 
		public bool dynamicControlledPosition { get => default; } // 0x000000018B7ADB3C-0x000000018B7ADB54 
		public bool dynamicControlledRotation { get => default; } // 0x000000018B7AD364-0x000000018B7AD458 
		public bool dynamicControlledFieldOfView { get => default; } // 0x000000018B7AD9DC-0x000000018B7ADA04 
		GameObject IDirectableCamera.gameObject { get => default; } // 0x000000018B7AE2E0-0x000000018B7AE318 
	
		// Nested types
		private sealed class __c__DisplayClass47_0 // TypeDefIndex: 55563
		{
			// Fields
			public string shotName; // 0x10
	
			// Constructors
			public __c__DisplayClass47_0() {} // 0x000000018B7ADAB0-0x000000018B7ADB3C
	
			// Methods
			internal bool _Find_b__0(ShotCamera s) => default; // 0x000000018A6E8BAC-0x000000018A6E8BF4
		}
	
		// Constructors
		public ShotCamera() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private void Awake() {} // 0x000000018B7ADA04-0x000000018B7ADA2C
		public void UpdateDynamicControllerHard(IDirectable directable) {} // 0x000000018B7AD9D0-0x000000018B7AD9DC
		public void UpdateDynamicControllerSoft(IDirectable directable) {} // 0x000000018B7AD97C-0x000000018B7AD9D0
		public void SetDynamicControllerTargets(Transform target) {} // 0x000000018B7AD7D8-0x000000018B7AD97C
		public void SetDynamicControllerTargets(Transform transposerTarget, Transform composerTarget) {} // 0x000000018B7AD458-0x000000018B7AD6E0
		public RenderTexture GetRenderTexture(int width, int height) => default; // 0x000000018B7AD6E0-0x000000018B7AD7D8
		public static ShotCamera Create(Transform targetParent = null) => default; // 0x000000018B7ADA2C-0x000000018B7ADAB0
		public static ShotCamera Find(string shotName) => default; // 0x000000018646E428-0x000000018646E430
	}

	[Serializable]
	public class BlendShape // TypeDefIndex: 55565
	{
		// Fields
		private SkinnedMeshRenderer _skin; // 0x10
		private string _name; // 0x18
		private float _weight; // 0x20
	
		// Properties
		public SkinnedMeshRenderer skin { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public string name { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public float weight { get => default; set {} } // 0x0000000181C9AC70-0x0000000181C9AC80 0x0000000181C9A5B0-0x0000000181C9A5C0
	
		// Constructors
		public BlendShape() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void SetRealWeight(float modWeight) {} // 0x000000018B7A17E8-0x000000018B7A18B4
		public override string ToString() => default; // 0x0000000181377E40-0x0000000181377E50
	}

	[Serializable]
	public class BlendShapeGroup // TypeDefIndex: 55566
	{
		// Fields
		private string _UID; // 0x10
		private string _name; // 0x18
		private float _weight; // 0x20
		private List<BlendShape> _blendShapes; // 0x28
	
		// Properties
		public string UID { get => default; private set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public string name { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public float weight { get => default; set {} } // 0x0000000181C9AC70-0x0000000181C9AC80 0x000000018B7A17DC-0x000000018B7A17E8
		public List<BlendShape> blendShapes { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
	
		// Constructors
		public BlendShapeGroup() {} // 0x000000018B7A1710-0x000000018B7A17DC
	
		// Methods
		private void SetBlendWeights() {} // 0x000000018B7A1690-0x000000018B7A1710
		public override string ToString() => default; // 0x0000000181377E40-0x0000000181377E50
	}

	public class Character : MonoBehaviour // TypeDefIndex: 55569
	{
		// Fields
		private List<BlendShapeGroup> _expressions; // 0x18
		private Transform _neckTransform; // 0x20
		private Transform _headTransform; // 0x28
		private Vector3 _upVector; // 0x30
		private Vector3 _rotationOffset; // 0x3C
	
		// Properties
		public Transform neck { get => default; set {} } // 0x0000000185FB2EF0-0x0000000185FB2F10 0x0000000185FB2F20-0x0000000185FB2F30
		public Transform head { get => default; set {} } // 0x0000000185FB2ED0-0x0000000185FB2EF0 0x0000000185FB2F10-0x0000000185FB2F20
		public Vector3 upVector { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x000000018B7A37AC-0x000000018B7A387C
		public Vector3 rotationOffset { get => default; set {} } // 0x000000018B7A387C-0x000000018B7A394C 0x000000018B7A39CC-0x000000018B7A3A00
		public List<BlendShapeGroup> expressions { get => default; } // 0x000000018B7A3A00-0x000000018B7A3A34 
	
		// Nested types
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 55567
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass19_0() {} // 0x00000001813B31A0-0x00000001813B31B0
	
			// Methods
			internal bool _FindExpressionByName_b__0(BlendShapeGroup x) => default; // 0x000000018646EE40-0x000000018646EE50
		}
	
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 55568
		{
			// Fields
			public string UID; // 0x10
	
			// Constructors
			public __c__DisplayClass20_0() {} // 0x00000001813B8590-0x00000001813B85A0
	
			// Methods
			internal bool _FindExpressionByUID_b__0(BlendShapeGroup x) => default; // 0x0000000184A4EDC0-0x0000000184A4EDD0
		}
	
		// Constructors
		public Character() {} // 0x000000018B7AE244-0x000000018B7AE260
	
		// Methods
		public BlendShapeGroup FindExpressionByName(string name) => default; // 0x000000018B7A394C-0x000000018B7A39CC
		public BlendShapeGroup FindExpressionByUID(string UID) => default; // 0x000000018B7A3A34-0x000000018B7A3AE0
		public void SetExpressionWeightByName(string name, float weight) {} // 0x0000000185492010-0x0000000185492020
		public void SetExpressionWeightByUID(string UID, float weight) {} // 0x000000018B7AE228-0x000000018B7AE244
		public void ResetExpressions() {} // 0x0000000185492010-0x0000000185492020
	}

	public class NameAttribute : Attribute // TypeDefIndex: 55570
	{
		// Fields
		public readonly string name; // 0x10
	
		// Constructors
		public NameAttribute() {} // Dummy constructor
		public NameAttribute(string name) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class CategoryAttribute : Attribute // TypeDefIndex: 55571
	{
		// Fields
		public readonly string category; // 0x10
	
		// Constructors
		public CategoryAttribute() {} // Dummy constructor
		public CategoryAttribute(string category) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class DescriptionAttribute : Attribute // TypeDefIndex: 55572
	{
		// Fields
		public readonly string description; // 0x10
	
		// Constructors
		public DescriptionAttribute() {} // Dummy constructor
		public DescriptionAttribute(string description) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class IconAttribute : Attribute // TypeDefIndex: 55573
	{
		// Fields
		public readonly string iconName; // 0x10
		public readonly System.Type fromType; // 0x18
	
		// Constructors
		public IconAttribute() {} // Dummy constructor
		public IconAttribute(string iconName) {} // 0x0000000184096E30-0x0000000184096EF0
		public IconAttribute(System.Type fromType) {} // 0x0000000184088E70-0x0000000184088E80
	}

	public class AttachableAttribute : Attribute // TypeDefIndex: 55574
	{
		// Fields
		public readonly System.Type[] types; // 0x10
	
		// Constructors
		public AttachableAttribute() {} // Dummy constructor
		public AttachableAttribute(System.Type[] types) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class UniqueElementAttribute : Attribute // TypeDefIndex: 55575
	{
		// Constructors
		public UniqueElementAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class ShowTrajectoryAttribute : Attribute // TypeDefIndex: 55576
	{
		// Constructors
		public ShowTrajectoryAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class PositionHandleAttribute : Attribute // TypeDefIndex: 55577
	{
		// Constructors
		public PositionHandleAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class RotationHandleAttribute : Attribute // TypeDefIndex: 55578
	{
		// Fields
		public readonly string positionPropertyName; // 0x10
	
		// Constructors
		public RotationHandleAttribute() {} // Dummy constructor
		public RotationHandleAttribute(string positionPropertyName) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class AnimatableParameterAttribute : PropertyAttribute // TypeDefIndex: 55579
	{
		// Fields
		public string link; // 0x10
		public readonly float? min; // 0x18
		public readonly float? max; // 0x20
		public readonly string customName; // 0x28
	
		// Constructors
		public AnimatableParameterAttribute() {} // 0x0000000185492010-0x0000000185492020
		public AnimatableParameterAttribute(string customName) {} // 0x0000000184A4EDC0-0x0000000184A4EDD0
		public AnimatableParameterAttribute(string customName, float min, float max) {} // 0x000000018B798350-0x000000018B7983E4
		public AnimatableParameterAttribute(float min, float max) {} // 0x000000018B7983E4-0x000000018B798460
	}

	public class ParseAnimatableParametersAttribute : PropertyAttribute // TypeDefIndex: 55580
	{
		// Constructors
		public ParseAnimatableParametersAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class ShaderPropertyPopupAttribute : PropertyAttribute // TypeDefIndex: 55581
	{
		// Fields
		public readonly System.Type propertyType; // 0x10
	
		// Constructors
		public ShaderPropertyPopupAttribute() {} // 0x0000000185492010-0x0000000185492020
		public ShaderPropertyPopupAttribute(System.Type propertyType) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	internal class LeftToggleAttribute : PropertyAttribute // TypeDefIndex: 55582
	{
		// Constructors
		public LeftToggleAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class MinAttribute : PropertyAttribute // TypeDefIndex: 55583
	{
		// Fields
		public readonly float min; // 0x10
	
		// Constructors
		public MinAttribute() {} // Dummy constructor
		public MinAttribute(float min) {} // 0x0000000181A6E380-0x0000000181A6E390
	}

	public class ExampleTextAttribute : PropertyAttribute // TypeDefIndex: 55584
	{
		// Fields
		public readonly string text; // 0x10
	
		// Constructors
		public ExampleTextAttribute() {} // Dummy constructor
		public ExampleTextAttribute(string text) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class HelpBoxAttribute : PropertyAttribute // TypeDefIndex: 55585
	{
		// Fields
		public readonly string text; // 0x10
	
		// Constructors
		public HelpBoxAttribute() {} // Dummy constructor
		public HelpBoxAttribute(string text) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class ShowIfAttribute : PropertyAttribute // TypeDefIndex: 55586
	{
		// Fields
		public readonly string propertyName; // 0x10
		public readonly int value; // 0x18
	
		// Constructors
		public ShowIfAttribute() {} // Dummy constructor
		public ShowIfAttribute(string propertyName, int value) {} // 0x00000001845D7850-0x00000001845D7870
	}

	public class EnabledIfAttribute : PropertyAttribute // TypeDefIndex: 55587
	{
		// Fields
		public readonly string propertyName; // 0x10
		public readonly int value; // 0x18
	
		// Constructors
		public EnabledIfAttribute() {} // Dummy constructor
		public EnabledIfAttribute(string propertyName, int value) {} // 0x00000001845D7850-0x00000001845D7870
	}

	public class CallbackAttribute : PropertyAttribute // TypeDefIndex: 55588
	{
		// Fields
		public readonly string methodName; // 0x10
	
		// Constructors
		public CallbackAttribute() {} // Dummy constructor
		public CallbackAttribute(string methodName) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class RequiredAttribute : PropertyAttribute // TypeDefIndex: 55589
	{
		// Constructors
		public RequiredAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class PlaybackProtectedAttribute : PropertyAttribute // TypeDefIndex: 55590
	{
		// Constructors
		public PlaybackProtectedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class ReadOnlyAttribute : PropertyAttribute // TypeDefIndex: 55591
	{
		// Constructors
		public ReadOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class SortingLayerAttribute : PropertyAttribute // TypeDefIndex: 55592
	{
		// Constructors
		public SortingLayerAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class ActorGroupPopupAttribute : PropertyAttribute // TypeDefIndex: 55593
	{
		// Constructors
		public ActorGroupPopupAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class DirectorActionClip : ActionClip // TypeDefIndex: 55594
	{
		// Constructors
		protected DirectorActionClip() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public interface IEvent // TypeDefIndex: 55595
	{
		// Properties
		string name { get; }
	
		// Methods
		void Invoke();
	}

	public enum TransformSpace // TypeDefIndex: 55596
	{
		CutsceneSpace = 0,
		ActorSpace = 1,
		WorldSpace = 2,
		ParentSpace = 3
	}

	public enum MiniTransformSpace // TypeDefIndex: 55597
	{
		CutsceneSpace = 0,
		WorldSpace = 2,
		ParentSpace = 3
	}

	public enum ActiveState // TypeDefIndex: 55598
	{
		Disable = 0,
		Enable = 1,
		Toggle = 2
	}

	public class CameraShot : DirectorActionClip // TypeDefIndex: 55602
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
		private ShotCamera _targetShot; // 0x50
		public BlendInEffectType blendInEffect; // 0x58
		public BlendOutEffectType blendOutEffect; // 0x5C
		public float steadyCamEffect; // 0x60
		public UnityEngine.Color fadeToColor; // 0x64
		public UnityEngine.Color fadeFromColor; // 0x74
		public ActorGroup overrideShotTargetActorGroup; // 0x88
		private UnityEngine.Color lastFadeColor; // 0x90
		private CameraShot _previousShot_k__BackingField; // 0xA0
	
		// Properties
		public override string info { get => default; } // 0x0000000185FB0590-0x0000000185FB05A0 
		public override bool isValid { get => default; } // 0x0000000185FB05F0-0x0000000185FB0600 
		public override float length { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendIn { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public override float blendOut { get => default; set {} } // 0x0000000187E75D4C-0x0000000187E75D54 0x000000018B7A252C-0x000000018B7A25A0
		public override bool canCrossBlend { get => default; } // 0x0000000185FB0520-0x0000000185FB0530 
		public new GameObject actor { get => default; } // 0x000000018646EBCC-0x000000018646EBE0 
		public CameraShot previousShot { get; private set; } // 0x0000000181460F60-0x0000000181460F70 0x000000018B7A2CC4-0x000000018B7A2D40
		public ShotCamera targetShot { get => default; set {} } // 0x000000018B7A2964-0x000000018B7A29A0 0x000000018B7A2834-0x000000018B7A28CC
		private CameraTrack track { get => default; } // 0x000000018B7A2BA4-0x000000018B7A2C34 
		public Vector3 position { get => default; set {} } // 0x000000018B7A28CC-0x000000018B7A2964 0x000000018B7A2C34-0x000000018B7A2CC4
		public Vector3 rotation { get => default; set {} } // 0x000000018B7A25A0-0x000000018B7A2614 0x000000018B7A29A0-0x000000018B7A2A3C
		public float fieldOfView { get => default; set {} } // 0x000000018B7A2684-0x000000018B7A26F4 0x000000018B7A2AB4-0x000000018B7A2B2C
		public float focalPoint { get => default; set {} } // 0x000000018B7A26F4-0x000000018B7A2764 0x000000018B7A2B2C-0x000000018B7A2BA4
		public float focalRange { get => default; set {} } // 0x000000018B7A2614-0x000000018B7A2684 0x000000018B7A2A3C-0x000000018B7A2AB4
		public float focalAperture { get => default; set {} } // 0x000000018B7A1A5C-0x000000018B7A1E40 0x000000018B7A2030-0x000000018B7A20BC
	
		// Nested types
		public enum BlendInEffectType // TypeDefIndex: 55599
		{
			None = 0,
			FadeFromColor = 1,
			CrossDissolve = 2,
			EaseIn = 3
		}
	
		public enum BlendOutEffectType // TypeDefIndex: 55600
		{
			None = 0,
			FadeToColor = 1
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 55601
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018B7A2764-0x000000018B7A27E4
			public __c() {} // 0x000000018B7A27E4-0x000000018B7A2834
		}
	
		// Constructors
		public CameraShot() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void OnAfterValidate() {} // 0x000000018B7A1FA4-0x000000018B7A2030
		protected override void OnRootEnabled() {} // 0x000000018B7A20BC-0x000000018B7A2148
		protected override void OnRootDisabled() {} // 0x000000018B7A2418-0x000000018B7A24EC
		protected override void OnRootUpdated(float time, float previousTime) {} // 0x000000018B7A1F2C-0x000000018B7A1F40
		public void TryUpdateShotTargetOverride() {} // 0x000000018B7A1E40-0x000000018B7A1F2C
		protected override bool OnInitialize() => default; // 0x000000018B7A2148-0x000000018B7A2418
		protected override void OnEnter() {} // 0x000000018B7A1F40-0x000000018B7A1FA4
		protected override void OnUpdate(float time, float previousTime) {} // 0x000000018B7A24EC-0x000000018B7A252C
		protected override void OnReverse() {} // 0x000000018B7AE37C-0x000000018B7AE3E0
	}

	public class PlayVideo : ActionClip // TypeDefIndex: 55603
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
		public VideoClip videoClip; // 0x50
		private VideoSampler.SampleSettings settings; // 0x58
	
		// Properties
		public override bool isValid { get => default; } // 0x000000018B7ACF8C-0x000000018B7ACFDC 
		public override string info { get => default; } // 0x000000018B7ACF0C-0x000000018B7ACF8C 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendOut { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		private VideoTrack track { get => default; } // 0x000000018B7ACFDC-0x000000018B7AD018 
	
		// Constructors
		public PlayVideo() {} // 0x000000018B7ACEF0-0x000000018B7ACF0C
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7ACDE0-0x000000018B7ACDE8
		protected override void OnReverseEnter() {} // 0x000000018B7ACDE0-0x000000018B7ACDE8
		protected override void OnReverse() {} // 0x000000018B7ACDE8-0x000000018B7ACDF0
		protected override void OnExit() {} // 0x000000018B7ACDE8-0x000000018B7ACDF0
		private void Enable() {} // 0x000000018B7ACD68-0x000000018B7ACDE0
		protected override void OnUpdate(float time, float previousTime) {} // 0x000000018B7ACDF0-0x000000018B7ACEF0
		private void Disable() {} // 0x000000018B7ACD3C-0x000000018B7ACD68
	}

	public class ActorGroup : CutsceneGroup // TypeDefIndex: 55604
	{
		// Fields
		private string _name; // 0x70
		private GameObject _actor; // 0x78
		private ActorReferenceMode _referenceMode; // 0x80
		private ActorInitialTransformation _initialCoordinates; // 0x84
		private Vector3 _initialLocalPosition; // 0x88
		private Vector3 _initialLocalRotation; // 0x94
		private bool _displayVirtualMeshGizmo; // 0xA0
	
		// Properties
		public override string name { get => default; set {} } // 0x000000018B798030-0x000000018B7980C8 0x00000001874BE90C-0x00000001874BE91C
		public override GameObject actor { get => default; set {} } // 0x000000018B798024-0x000000018B798030 0x000000018B7980C8-0x000000018B798138
		public override ActorReferenceMode referenceMode { get => default; set {} } // 0x000000018140C930-0x000000018140C940 0x000000018140C940-0x000000018140C950
		public override ActorInitialTransformation initialTransformation { get => default; set {} } // 0x0000000182FB0000-0x0000000182FB0010 0x0000000185FBB860-0x0000000185FBB870
		public override Vector3 initialLocalPosition { get => default; set {} } // 0x0000000185FD5B20-0x0000000185FD5B40 0x0000000185FD5B40-0x0000000185FD5B60
		public override Vector3 initialLocalRotation { get => default; set {} } // 0x0000000185FBC980-0x0000000185FBC9A0 0x0000000185FBC9A0-0x0000000185FBC9C0
		public override bool displayVirtualMeshGizmo { get => default; set {} } // 0x000000018346D900-0x000000018346D910 0x00000001834A2240-0x00000001834A2250
	
		// Constructors
		public ActorGroup() {} // 0x000000018B797FD4-0x000000018B798024
	}

	public class DirectorGroup : CutsceneGroup // TypeDefIndex: 55605
	{
		// Properties
		public override string name { get => default; set {} } // 0x000000018B7ABA28-0x000000018B7ABA54 0x0000000185492010-0x0000000185492020
		public override GameObject actor { get => default; set {} } // 0x0000000187F717D8-0x0000000187F717FC 0x0000000185492010-0x0000000185492020
		public override ActorReferenceMode referenceMode { get => default; set {} } // 0x00000001813AE580-0x00000001813AE590 0x0000000185492010-0x0000000185492020
		public override ActorInitialTransformation initialTransformation { get => default; set {} } // 0x00000001813AE580-0x00000001813AE590 0x0000000185492010-0x0000000185492020
		public override Vector3 initialLocalPosition { get => default; set {} } // 0x0000000186472A7C-0x0000000186472A94 0x0000000185492010-0x0000000185492020
		public override Vector3 initialLocalRotation { get => default; set {} } // 0x0000000186472A7C-0x0000000186472A94 0x0000000185492010-0x0000000185492020
		public override bool displayVirtualMeshGizmo { get => default; set {} } // 0x00000001814A81B0-0x00000001814A81C0 0x0000000185492010-0x0000000185492020
	
		// Constructors
		public DirectorGroup() {} // 0x000000018B7AB9DC-0x000000018B7ABA28
	}

	public abstract class ActionTrack : CutsceneTrack // TypeDefIndex: 55606
	{
		// Constructors
		protected ActionTrack() {} // 0x000000018B797FB4-0x000000018B797FBC
	}

	public class ActorActionTrack : ActionTrack // TypeDefIndex: 55607
	{
		// Constructors
		public ActorActionTrack() {} // 0x000000018B797FB4-0x000000018B797FBC
	}

	public class ActorAudioTrack : Slate.AudioTrack // TypeDefIndex: 55608
	{
		// Fields
		protected bool _useAudioSourceOnActor; // 0x90
	
		// Properties
		public override bool useAudioSourceOnActor { get => default; } // 0x0000000185FB2250-0x0000000185FB2260 
	
		// Constructors
		public ActorAudioTrack() {} // 0x000000018B797FBC-0x000000018B797FD4
	}

	public class ActorPropertiesTrack : PropertiesTrack // TypeDefIndex: 55609
	{
		// Constructors
		public ActorPropertiesTrack() {} // 0x000000018B798220-0x000000018B798228
	
		// Methods
		protected override void OnCreate() {} // 0x000000018B798138-0x000000018B798220
	}

	public class AnimationTrack : CutsceneTrack // TypeDefIndex: 55610
	{
		// Fields
		private float _weight; // 0x50
		private float _blendIn; // 0x54
		private float _blendOut; // 0x58
		private AnimationBlendMode _animationBlendMode; // 0x5C
		private string _mixTransformName; // 0x60
		private Animation anim; // 0x68
		private UnityEngine.AnimationState state; // 0x70
	
		// Properties
		public override string info { get => default; } // 0x000000018B79F154-0x000000018B79F254 
		public override float blendIn { get => default; } // 0x0000000183F80440-0x0000000183F80450 
		public override float blendOut { get => default; } // 0x0000000181DE2580-0x0000000181DE2590 
		public float weight { get => default; } // 0x0000000185FB3000-0x0000000185FB3010 
		public AnimationBlendMode animationBlendMode { get => default; private set {} } // 0x0000000183F80460-0x0000000183F80470 0x0000000183F804F0-0x0000000183F80500
		public string mixTransformName { get => default; private set {} } // 0x0000000185FB0530-0x0000000185FB0540 0x0000000185AE8FE0-0x0000000185AE8FF0
	
		// Constructors
		public AnimationTrack() {} // 0x000000018B79F0F0-0x000000018B79F154
	
		// Methods
		protected override bool OnInitialize() => default; // 0x000000018B79EEFC-0x000000018B79EFD8
		protected override void OnEnter() {} // 0x000000018B79ECE8-0x000000018B79EEBC
		protected override void OnUpdate(float time, float previousTime) {} // 0x000000018B79F018-0x000000018B79F0B8
		protected override void OnExit() {} // 0x000000018B79EEBC-0x000000018B79EEFC
		protected override void OnReverseEnter() {} // 0x000000018B79EFD8-0x000000018B79F018
		protected override void OnReverse() {} // 0x000000018B79EEBC-0x000000018B79EEFC
		public Transform GetMixTransform() => default; // 0x000000018B79EB68-0x000000018B79ECE8
		private bool _GetMixTransform_b__27_0(Transform t) => default; // 0x000000018B79F0B8-0x000000018B79F0F0
	}

	public class AnimatorTrack : CutsceneTrack // TypeDefIndex: 55612
	{
		// Fields
		private const int ROOTMOTION_FRAMERATE = 30; // Metadata: 0x0207BF3B
		public AvatarMask mask; // 0x50
		public AnimationBlendMode blendMode; // 0x58
		public float weight; // 0x5C
		public bool useRootMotion; // 0x60
		public bool applyFootIK; // 0x61
		public bool isRootMotionPreBaked; // 0x62
		private List<Vector3> rmPositions; // 0x68
		private List<Quaternion> rmRotations; // 0x70
		private int activeClips; // 0x78
		private float activeClipsWeight; // 0x7C
		private Dictionary<PlayAnimatorClip, int> ports; // 0x80
		private PlayableGraph graph; // 0x88
		private AnimationPlayableOutput animationOutput; // 0x98
		private AnimationLayerMixerPlayable masterMixer; // 0xA8
		private AnimationMixerPlayable clipsMixer; // 0xB8
		private AnimatorControllerPlayable animatorPlayable; // 0xC8
		private List<AnimatorTrack> siblingTracks; // 0xD8
		private bool wasRootMotion; // 0xE0
		private AnimatorCullingMode wasCullingMode; // 0xE4
		private bool useBakedRootMotion; // 0xE8
		private Animator _animator; // 0xF0
	
		// Properties
		public Animator animator { get => default; } // 0x000000018B7A1278-0x000000018B7A12C4 
		public override string info { get => default; } // 0x000000018B7A1270-0x000000018B7A1278 
		public override bool isLocked { get => default; } // 0x000000018B7A11F8-0x000000018B7A1240 
		public AnimatorTrack masterTrack { get => default; } // 0x000000018B7A10B0-0x000000018B7A10C8 
		public bool isMasterTrack { get => default; } // 0x000000018B7A0774-0x000000018B7A0984 
		public bool isLastTrack { get => default; } // 0x000000018B7A05DC-0x000000018B7A0734 
		public float compoundTrackWeight { get => default; } // 0x000000018B7A0AAC-0x000000018B7A0BAC 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 55611
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<AnimatorTrack, bool> __9__36_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018B7A0FBC-0x000000018B7A10B0
			public __c() {} // 0x000000018B7A10C8-0x000000018B7A11F8
	
			// Methods
			internal bool _OnInitialize_b__36_0(AnimatorTrack t) => default; // 0x000000018B7A1240-0x000000018B7A1270
		}
	
		// Constructors
		public AnimatorTrack() {} // 0x000000018B7AE11C-0x000000018B7AE13C
	
		// Methods
		protected override bool OnInitialize() => default; // 0x000000018B7A0C64-0x000000018B7A0E4C
		protected override void OnEnter() {} // 0x000000018B7A0984-0x000000018B7A0A20
		protected override void OnUpdate(float time, float previousTime) {} // 0x000000018B7A0734-0x000000018B7A0774
		private void PostUpdateMasterTrack(float time, float previousTime) {} // 0x000000018B7A0BAC-0x000000018B7A0C64
		protected override void OnReverseEnter() {} // 0x000000018B7A0A20-0x000000018B7A0AAC
		protected override void OnExit() {} // 0x000000018B7A01D4-0x000000018B7A0290
		private void PostExitMasterTrack() {} // 0x000000018B7A0E9C-0x000000018B7A0FA8
		protected override void OnReverse() {} // 0x000000018B7A012C-0x000000018B7A01D4
		public void EnableClip(PlayAnimatorClip playAnimClip, float blendWeight, float subClipWeight) {} // 0x000000018B79FAAC-0x000000018B79FE58
		public void UpdateClip(PlayAnimatorClip playAnimClip, float clipTime, float clipPrevious, float blendWeight, float subClipWeight) {} // 0x000000018B79FE58-0x000000018B7A012C
		public void DisableClip(PlayAnimatorClip playAnimClip, float blendWeight, float subClipWeight) {} // 0x000000018B7A0E4C-0x000000018B7A0E9C
		private void CreateAndPlayTree() {} // 0x000000018B79F9E8-0x000000018B79FAAC
		private Playable CreateClipsMixer(PlayableGraph graph) => default; // 0x000000018B79F524-0x000000018B79F9E8
		public void PreBakeRootMotion() {} // 0x000000018B7A0290-0x000000018B7A05DC
		public void ClearPreBakeRootMotion() {} // 0x000000018B79F254-0x000000018B79F524
		private void BakeRootMotion() {} // 0x000000018B7A0FA8-0x000000018B7A0FBC
		private void EvaluateTrackClips(float time, float previousTime, ref int tempActiveClips) {} // 0x000000018B7AE3E0-0x000000018B7AE444
		private void ApplyBakedRootMotion(float time) {} // 0x0000000185492010-0x0000000185492020
	}

	public class MecanimTrack : CutsceneTrack // TypeDefIndex: 55613
	{
		// Fields
		private Animator animator; // 0x50
	
		// Constructors
		public MecanimTrack() {} // 0x000000018B797FB4-0x000000018B797FBC
	
		// Methods
		protected override bool OnInitialize() => default; // 0x000000018B7ACBD0-0x000000018B7ACD3C
		protected override void OnReverse() {} // 0x000000018B7ACBC8-0x000000018B7ACBD0
		protected override void OnExit() {} // 0x000000018B7ACBC8-0x000000018B7ACBD0
		private void DestroyDispatcher() {} // 0x000000018B7ACB34-0x000000018B7ACBC8
	}

	public abstract class AudioTrack : CutsceneTrack // TypeDefIndex: 55614
	{
		// Fields
		protected AudioMixerGroup _outputMixer; // 0x50
		protected float _masterVolume; // 0x58
		protected float _masterPitch; // 0x5C
		protected float _masterStereoPan; // 0x60
		protected float _masterSpatialBlend; // 0x64
		protected bool _ignoreTimeScale; // 0x68
		protected bool _bypassReverb; // 0x69
		private AudioSource _source_k__BackingField; // 0x70
		private AudioSampler.SampleSettings _sampleSettings_k__BackingField; // 0x78
	
		// Properties
		public override string info { get; } // 0x000000018B7A15C0-0x000000018B7A1690 
		public AudioSource source { get; private set; } // 0x0000000181460F70-0x0000000181460F80 0x00000001874BE90C-0x00000001874BE91C
		public AudioSampler.SampleSettings sampleSettings { get; private set; } // 0x0000000185FD5B60-0x0000000185FD5B80 0x0000000185FD5B80-0x0000000185FD5BA0
		public AudioMixerGroup mixer { get; } // 0x0000000181460F60-0x0000000181460F70 
		public virtual bool useAudioSourceOnActor { get; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		protected AudioTrack() {} // 0x000000018B797FBC-0x000000018B797FD4
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7A1400-0x000000018B7A1408
		protected override void OnReverseEnter() {} // 0x000000018B7A1400-0x000000018B7A1408
		protected override void OnUpdate(float time, float previousTime) {} // 0x000000018B7A1410-0x000000018B7A1514
		protected override void OnExit() {} // 0x000000018B7A1408-0x000000018B7A1410
		protected override void OnReverse() {} // 0x000000018B7A1408-0x000000018B7A1410
		private void Enable() {} // 0x000000018B7A1324-0x000000018B7A1400
		private void Disable() {} // 0x000000018B7A12C4-0x000000018B7A1324
		private void SetAndApplySettings() {} // 0x000000018B7A1514-0x000000018B7A15B4
		public void SetVolume(float volume) {} // 0x000000018B7A15B4-0x000000018B7A15C0
	}

	public class CameraTrack : CutsceneTrack // TypeDefIndex: 55615
	{
		// Fields
		private static CameraTrack activeCameraTrack; // 0x00
		private float _startTimeOffset; // 0x50
		private float _endTimeOffset; // 0x54
		public float _blendIn; // 0x58
		public float _blendOut; // 0x5C
		public Slate.EaseType interpolation; // 0x60
		public float cineBoxFadeTime; // 0x64
		public float appliedSmoothing; // 0x68
		public Camera exitCameraOverride; // 0x70
		private GameCamera entryCamera; // 0x78
		private CameraShot _firstShot_k__BackingField; // 0x80
		private CameraShot _lastShot_k__BackingField; // 0x88
		private CameraShot _currentShot_k__BackingField; // 0x90
	
		// Properties
		public CameraShot firstShot { get; private set; } // 0x000000018140CF50-0x000000018140CF60 0x00000001873CBE98-0x00000001873CBEA8
		public CameraShot lastShot { get; private set; } // 0x0000000185FB0510-0x0000000185FB0520 0x0000000186472AA8-0x0000000186472ABC
		public CameraShot currentShot { get; set; } // 0x0000000181B5FFD0-0x0000000181B5FFE0 0x00000001873CBEA8-0x00000001873CBEBC
		public override string info { get => default; } // 0x000000018B7A3680-0x000000018B7A36E4 
		public override float startTime { get => default; set {} } // 0x0000000185FB3000-0x0000000185FB3010 0x000000018B7A3758-0x000000018B7A37AC
		public override float endTime { get => default; set {} } // 0x000000018B7A3654-0x000000018B7A3680 0x000000018B7A36E4-0x000000018B7A3758
		public override float blendIn { get => default; set {} } // 0x000000018B7A3500-0x000000018B7A35A8 0x0000000181DE28C0-0x0000000181DE28D0
		public override float blendOut { get => default; set {} } // 0x000000018B7A35A8-0x000000018B7A3654 0x0000000185FBD3C0-0x0000000185FBD3D0
	
		// Constructors
		public CameraTrack() {} // 0x000000018B7A34E8-0x000000018B7A3500
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7A2D40-0x000000018B7A2F5C
		protected override void OnUpdate(float time, float previousTime) {} // 0x000000018B7A3130-0x000000018B7A3468
		protected override void OnExit() {} // 0x000000018B7A2F5C-0x000000018B7A2FF8
		protected override void OnReverseEnter() {} // 0x000000018B7A2FF8-0x000000018B7A3094
		protected override void OnReverse() {} // 0x000000018B7A3094-0x000000018B7A3130
		private bool _OnEnter_b__36_0(ActionClip s) => default; // 0x000000018B7A3468-0x000000018B7A34A0
		private bool _OnEnter_b__36_1(ActionClip s) => default; // 0x000000018B7A34A0-0x000000018B7A34E8
	}

	public class DirectorActionTrack : ActionTrack // TypeDefIndex: 55616
	{
		// Constructors
		public DirectorActionTrack() {} // 0x000000018B797FB4-0x000000018B797FBC
	}

	public class DirectorAudioTrack : Slate.AudioTrack // TypeDefIndex: 55617
	{
		// Constructors
		public DirectorAudioTrack() {} // 0x000000018B797FBC-0x000000018B797FD4
	}

	public class DirectorPropertiesTrack : PropertiesTrack // TypeDefIndex: 55618
	{
		// Constructors
		public DirectorPropertiesTrack() {} // 0x000000018B798220-0x000000018B798228
	}

	public class VideoTrack : CutsceneTrack // TypeDefIndex: 55619
	{
		// Fields
		public VideoSampler.VideoRenderTarget renderTarget; // 0x50
		public VideoAspectRatio aspectRatio; // 0x54
		private VideoPlayer _source_k__BackingField; // 0x58
	
		// Properties
		public VideoPlayer source { get; private set; } // 0x00000001813F1630-0x00000001813F1640 0x0000000186472DB0-0x0000000186472DC0
		public override string info { get => default; } // 0x000000018B7AE514-0x000000018B7AF0E8 
	
		// Constructors
		public VideoTrack() {} // 0x000000018B7AE504-0x000000018B7AE514
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7AE4F4-0x000000018B7AE4FC
		protected override void OnReverseEnter() {} // 0x000000018B7AE4F4-0x000000018B7AE4FC
		protected override void OnReverse() {} // 0x000000018B7AE4FC-0x000000018B7AE504
		protected override void OnExit() {} // 0x000000018B7AE4FC-0x000000018B7AE504
		private void Enable() {} // 0x000000018B7AE490-0x000000018B7AE4F4
		private void Disable() {} // 0x000000018B7AE444-0x000000018B7AE490
	}

	public abstract class PropertiesTrack : CutsceneTrack, IKeyable // TypeDefIndex: 55620
	{
		// Fields
		private AnimationDataCollection _animationData; // 0x50
	
		// Properties
		public AnimationDataCollection animationData { get; } // 0x0000000181460F60-0x0000000181460F70 
		public object animatedParametersTarget { get; } // 0x000000018B7AD164-0x000000018B7AD16C 
	
		// Constructors
		protected PropertiesTrack() {} // 0x000000018B7AD10C-0x000000018B7AD164
	
		// Methods
		protected override void OnAfterValidate() {} // 0x000000018B7AD018-0x000000018B7AD040
		protected override void OnEnter() {} // 0x000000018B7AD040-0x000000018B7AD094
		protected override void OnUpdate(float time, float previousTime) {} // 0x000000018B7AD0B4-0x000000018B7AD10C
		protected override void OnReverse() {} // 0x000000018B7AD094-0x000000018B7AD0B4
	}

	public abstract class ActionClip : MonoBehaviour, IKeyable // TypeDefIndex: 55621
	{
		// Fields
		private float _startTime; // 0x18
		private AnimationDataCollection _animationData; // 0x20
		private IDirectable _parent_k__BackingField; // 0x28
		private bool _isHighlight_k__BackingField; // 0x30
		[NonSerialized]
		private string[] _cachedAnimParamPaths; // 0x38
	
		// Properties
		public IDirector root { get; } // 0x000000018B797CBC-0x000000018B797CDC 
		public IDirectable parent { get; private set; } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public GameObject actor { get; } // 0x000000018B7979A8-0x000000018B7979C8 
		IEnumerable<IDirectable> IDirectable.children { get; } // 0x00000001813AE580-0x00000001813AE590 
		public AnimationDataCollection animationData { get; private set; } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public float startTime { get; set; } // 0x0000000181C9AC50-0x0000000181C9AC60 0x000000018B797EB8-0x000000018B797FB4
		public float endTime { get; set; } // 0x000000018B797A00-0x000000018B797A2C 0x000000018B797D9C-0x000000018B797EB8
		public bool isActive { get; } // 0x000000018B797BB0-0x000000018B797BEC 
		public bool isCollapsed { get; } // 0x000000018B797BEC-0x000000018B797C0C 
		public bool isLocked { get; } // 0x000000018B797C0C-0x000000018B797C2C 
		public virtual float length { get; set; } // 0x0000000183908D00-0x0000000183908D10 0x0000000185492010-0x0000000185492020
		public virtual float blendIn { get; set; } // 0x0000000183908D00-0x0000000183908D10 0x0000000185492010-0x0000000185492020
		public virtual float blendOut { get; set; } // 0x0000000183908D00-0x0000000183908D10 0x0000000185492010-0x0000000185492020
		public virtual bool canCrossBlend { get; } // 0x00000001814A81B0-0x00000001814A81C0 
		public virtual string info { get; } // 0x000000018B797B0C-0x000000018B797BB0 
		public virtual bool isValid { get; } // 0x000000018B797C4C-0x000000018B797C9C 
		public virtual UnityEngine.Color color { get; } // 0x00000001880C4FCC-0x00000001880C4FEC 
		public virtual UnityEngine.Color textColor { get; } // 0x000000018646DC68-0x000000018646DC88 
		public virtual int textSizeInner { get; } // 0x0000000185FB6A00-0x0000000185FB6A10 
		public virtual int textSizeOuter { get; } // 0x0000000183056920-0x0000000183056930 
		public virtual float interval { get; } // 0x0000000183908D00-0x0000000183908D10 
		public virtual string url { get; } // 0x000000018B797CDC-0x000000018B797D9C 
		public virtual bool isHighlight { get; set; } // 0x00000001814294C0-0x00000001814294D0 0x000000018142A360-0x000000018142A370
		public bool isReadOnly { get; } // 0x000000018B797C2C-0x000000018B797C4C 
		public virtual TransformSpace defaultTransformSpace { get; } // 0x00000001813AE580-0x00000001813AE590 
		private string[] animatedParameterPaths { get; } // 0x000000018B7979C8-0x000000018B797A00 
		private bool handleParametersRegistrationManually { get; } // 0x000000018B797A2C-0x000000018B797A50 
		public virtual object animatedParametersTarget { get; } // 0x0000000185779060-0x0000000185779070 
		public virtual Slate.EaseType animatedParametersInterpolation { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual bool useWeightInParameters { get; } // 0x00000001814A81B0-0x00000001814A81C0 
		public bool hasParameters { get; } // 0x000000018B797AF4-0x000000018B797B0C 
		public bool hasActiveParameters { get; } // 0x000000018B797A50-0x000000018B797AF4 
		public virtual bool needActor { get; } // 0x000000018B797C9C-0x000000018B797CBC 
		public virtual bool canSample { get; } // 0x00000001840A27C0-0x00000001840A27D0 
		public virtual int updateOrder { get; } // 0x0000000185FBBF90-0x0000000185FBBFA0 
		string IDirectable.name { get; } // 0x00000001864746E4-0x00000001864746EC 
	
		// Constructors
		protected ActionClip() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		bool IDirectable.Initialize() => default; // 0x000000018B797320-0x000000018B797330
		void IDirectable.Enter() {} // 0x000000018B7972EC-0x000000018B797310
		void IDirectable.Update(float time, float previousTime) {} // 0x000000018B7973B0-0x000000018B7973F4
		void IDirectable.Exit() {} // 0x000000018B797310-0x000000018B797320
		void IDirectable.ReverseEnter() {} // 0x000000018B797330-0x000000018B797340
		void IDirectable.Reverse() {} // 0x000000018B797340-0x000000018B797364
		void IDirectable.RootEnabled() {} // 0x000000018B79737C-0x000000018B797394
		void IDirectable.RootDisabled() {} // 0x000000018B797364-0x000000018B79737C
		void IDirectable.RootUpdated(float time, float previousTime) {} // 0x000000018B797394-0x000000018B7973B0
		void IDirectable.RootDestroyed() {} // 0x0000000185FACE20-0x0000000185FACE30
		public void PostCreate(IDirectable parent) {} // 0x000000018B79719C-0x000000018B7971D0
		public void Validate() {} // 0x000000018B797954-0x000000018B797964
		public void Validate(IDirector root, IDirectable parent) {} // 0x000000018B797964-0x000000018B7979A8
		protected virtual bool OnInitialize() => default; // 0x00000001840A27C0-0x00000001840A27D0
		protected virtual void OnEnter() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnUpdate(float time, float previousTime) {} // 0x000000018B79718C-0x000000018B79719C
		protected virtual void OnUpdate(float time) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnExit() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnReverse() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnReverseEnter() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnDrawGizmosSelected() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnSceneGUI() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnCreate() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnAfterValidate() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnRootEnabled() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnRootDisabled() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnRootUpdated(float time, float previousTime) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnRootDestroyed() {} // 0x0000000185492010-0x0000000185492020
		public bool RootTimeWithinRange() => default; // 0x000000018B79721C-0x000000018B797224
		public Vector3 TransformPosition(Vector3 point, TransformSpace space) => default; // 0x000000018B7973F4-0x000000018B797440
		public Vector3 InverseTransformPosition(Vector3 point, TransformSpace space) => default; // 0x000000018B7970FC-0x000000018B797148
		public Quaternion TransformRotation(Vector3 euler, TransformSpace space) => default; // 0x000000018B797440-0x000000018B797484
		public Vector3 InverseTransformRotation(Quaternion rot, TransformSpace space) => default; // 0x000000018B797148-0x000000018B79718C
		public Vector3 ActorPositionInSpace(TransformSpace space) => default; // 0x000000018B796E8C-0x000000018B796EBC
		public Transform GetSpaceTransform(TransformSpace space, GameObject actorOverride = null) => default; // 0x000000018B7970F4-0x000000018B7970FC
		public ActionClip GetPreviousClip() => default; // 0x000000018B7970B8-0x000000018B7970F4
		public ActionClip GetNextClip() => default; // 0x000000018B79705C-0x000000018B797098
		public float GetClipWeight() => default; // 0x000000018B796F98-0x000000018B796FD4
		public float GetClipWeight(float time) => default; // 0x000000018B797000-0x000000018B79705C
		public float GetClipWeight(float time, float blendInOut) => default; // 0x000000018B796FD4-0x000000018B796FF0
		public float GetClipWeight(float time, float blendIn, float blendOut) => default; // 0x000000018B796FF0-0x000000018B797000
		public void TryMatchSubClipLength() {} // 0x000000018B7975C0-0x000000018B79767C
		public void TryMatchPreviousSubClipLoop() {} // 0x000000018B797558-0x000000018B7975C0
		public void TryMatchNexSubClipLoop() {} // 0x000000018B797484-0x000000018B797558
		private string GetParameterName<T, TResult>(Expression<Func<T, TResult>> func) => default;
		public AnimatedParameter GetParameter<T, TResult>(Expression<Func<T, TResult>> func) => default;
		public AnimatedParameter GetParameter(string paramName) => default; // 0x000000018B797098-0x000000018B7970B8
		public void SetParameterEnabled<T, TResult>(Expression<Func<T, TResult>> func, bool enabled) {}
		public void SetParameterEnabled(string paramName, bool enabled) {} // 0x000000018B797284-0x000000018B7972EC
		public void ResetAnimatedParameters() {} // 0x000000018B7971D0-0x000000018B7971E4
		private void CreateAnimationDataCollection() {} // 0x000000018B796EBC-0x000000018B796F98
		private void ValidateAnimParams() {} // 0x000000018B797758-0x000000018B797954
		private void SetAnimParamsSnapshot() {} // 0x000000018B797224-0x000000018B797284
		private void UpdateAnimParams(float time, float previousTime) {} // 0x000000018B79767C-0x000000018B797758
		private void RestoreAnimParamsSnapshot() {} // 0x000000018B7971E4-0x000000018B79721C
	}

	[Serializable]
	public class AnimatedParameter : IAnimatableData, ISerializationCallbackReceiver // TypeDefIndex: 55625
	{
		// Fields
		private static Action<IAnimatableData> onParameterChanged; // 0x00
		private string _serializedData; // 0x10
		private bool _isDisabled; // 0x18
		private AnimationCurve[] _curves; // 0x20
		private string _scriptExpression; // 0x28
		[NonSerialized]
		private SerializationMetaData _data; // 0x30
		[NonSerialized]
		private IAnimatedParameterModel _parameterModel; // 0x38
		private IKeyable _keyable_k__BackingField; // 0x40
		private float[] _snapshot_k__BackingField; // 0x48
		private float[] _lastEval_k__BackingField; // 0x50
		private Transform _virtualTransformParent_k__BackingField; // 0x58
		private static Dictionary<System.Type, System.Type> parameterModelsMap; // 0x08
		public static readonly System.Type[] supportedTypes; // 0x10
		[NonSerialized]
		private object _animatableAttribute; // 0x60
		[NonSerialized]
		private object _resolvedMemberObject; // 0x68
	
		// Properties
		public bool enabled { get => default; } // 0x000000018B79A658-0x000000018B79A678 
		private string serializedData { get => default; set {} } // 0x000000018B79A948-0x000000018B79A968 0x000000018B79A6E4-0x000000018B79A704
		private SerializationMetaData data { get => default; } // 0x000000018B79A908-0x000000018B79A928 
		public IAnimatedParameterModel parameterModel { get => default; } // 0x000000018B79A704-0x000000018B79A724 
		public AnimationCurve[] curves { get => default; private set {} } // 0x000000018B79A754-0x000000018B79A76C 0x00000001813FF010-0x00000001813FF020
		public string scriptExpression { get => default; set {} } // 0x0000000185F05C80-0x0000000185F05C90 0x00000001813ECF20-0x00000001813ECF30
		public bool hasActiveExpression { get => default; } // 0x000000018571FEC0-0x000000018571FED0 
		public string parameterName { get => default; } // 0x0000000181460F60-0x0000000181460F70 
		public System.Type animatedType { get => default; } // 0x0000000184A4E570-0x0000000184A4E580 
		public ParameterType parameterType { get => default; } // 0x00000001813F1630-0x00000001813F1640 
		public string transformHierarchyPath { get => default; } // 0x0000000186472DB0-0x0000000186472DC0 
		public System.Type declaringType { get => default; } // 0x000000018B79A928-0x000000018B79A948 
		public PropertyInfo property { get => default; } // 0x000000018B79A580-0x000000018B79A658 
		public System.Reflection.FieldInfo field { get => default; } // 0x000000018B79A73C-0x000000018B79A754 
		public bool isProperty { get => default; } // 0x000000018B79A76C-0x000000018B79A7DC 
		public IKeyable keyable { get; private set; } // 0x000000018B79A0FC-0x000000018B79A36C 0x000000018B79A36C-0x000000018B79A4BC
		private float[] snapshot { get; set; } // 0x000000018B798594-0x000000018B798764 0x000000018B798764-0x000000018B7989A8
		private float[] lastEval { get; set; } // 0x000000018B7993EC-0x000000018B799430 0x00000001813B31A0-0x00000001813B31B0
		private Transform virtualTransformParent { get; set; } // 0x000000018B7984C0-0x000000018B798594 0x000000018B7994C4-0x000000018B7995A0
		public object targetObject { get => default; } // 0x0000000185F05C80-0x0000000185F05C90 
		public AnimatableParameterAttribute animatableAttribute { get => default; } // 0x0000000186472DB0-0x0000000186472DC0 
		public bool isExternal { get => default; } // 0x000000018B799FB8-0x000000018B79A028 
		public bool isValid { get => default; } // 0x000000018B79A030-0x000000018B79A090 
	
		// Events
		public static event Action<IAnimatableData> onParameterChanged;
	
		// Nested types
		[Serializable]
		private class SerializationMetaData // TypeDefIndex: 55622
		{
			// Fields
			public string parameterName; // 0x10
			public string declaringTypeName; // 0x18
			public string transformHierarchyPath; // 0x20
			public ParameterType parameterType; // 0x28
			private System.Type _declaringType_k__BackingField; // 0x30
			private PropertyInfo _property_k__BackingField; // 0x38
			private System.Reflection.FieldInfo _field_k__BackingField; // 0x40
			private System.Type _animatedType_k__BackingField; // 0x48
	
			// Properties
			public System.Type declaringType { get; private set; } // 0x000000018B79A0CC-0x000000018B79A0FC 0x000000018B79A090-0x000000018B79A0CC
			public PropertyInfo property { get; private set; } // 0x000000018B79A4BC-0x000000018B79A580 0x000000018B79A968-0x000000018B79AA2C
			public System.Reflection.FieldInfo field { get; private set; } // 0x0000000185F61D60-0x0000000185F61D70 0x000000018B799E6C-0x000000018B799ED8
			public System.Type animatedType { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
	
			// Constructors
			public SerializationMetaData() {} // 0x000000018B79A7DC-0x000000018B79A8C8
	
			// Methods
			public void Deserialize() {} // 0x000000018B79A678-0x000000018B79A6E4
		}
	
		public enum ParameterType // TypeDefIndex: 55623
		{
			NotSet = 0,
			Property = 1,
			Field = 2
		}
	
		private sealed class __c__DisplayClass112_0 // TypeDefIndex: 55624
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass112_0() {} // 0x00000001813B31A0-0x00000001813B31B0
	
			// Methods
			internal float _GetKeyLabel_b__0(AnimationCurve c) => default; // 0x000000018646EE40-0x000000018646EE50
		}
	
		// Constructors
		public AnimatedParameter() {} // Dummy constructor
		static AnimatedParameter() {} // 0x000000018B798A94-0x000000018B798B20
		public AnimatedParameter(IKeyable keyable, System.Type type, string memberPath, string transformPath) {} // 0x000000018B7989A8-0x000000018B798A94
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x00000001813B8590-0x00000001813B85A0
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018B79AA2C-0x000000018B79AA64
		public void SetEnabled(bool value, float time) {} // 0x000000018B79A8E8-0x000000018B79A908
		private void ConstructWithField(System.Reflection.FieldInfo targetField, System.Type type, string memberPath, string transformPath) {} // 0x00000001814A81B0-0x00000001814A81C0
		private void ConstructWithProperty(PropertyInfo targetProperty, System.Type type, string memberPath, string transformPath) {} // 0x000000018B7999A4-0x000000018B799A04
		public MemberInfo GetMemberInfo() => default; // 0x000000018B7991E4-0x000000018B7992B8
		public AnimationCurve[] GetCurves() => default; // 0x000000018B799770-0x000000018B7999A4
		public bool CompareTo(AnimatedParameter other) => default; // 0x000000018B7991A0-0x000000018B7991E4
		private void InitializeCurves() {} // 0x000000018B798DA0-0x000000018B7991A0
		public void Validate(IKeyable keyable) {} // 0x000000018B799A04-0x000000018B799A4C
		public void SetVirtualTransformParent(Transform virtualTransformParent) {} // 0x000000018B799A4C-0x000000018B799E6C
		public void SetSnapshot() {} // 0x000000018B79943C-0x000000018B7994B4
		public bool TryAutoKey(float time) => default; // 0x000000018B799430-0x000000018B79943C
		public void Evaluate(float time, float previousTime, float weight = 1f /* Metadata: 0x0207BF3C */) {} // 0x000000018B7994B4-0x000000018B7994C4
		private void Evaluate_1_Curves(float time, float previousTime, float weight = 1f /* Metadata: 0x0207BF40 */) {} // 0x000000018B7993CC-0x000000018B7993DC
		private bool Evaluate_2_Expression(float time, float previousTime, float weight = 1f /* Metadata: 0x0207BF44 */) => default; // 0x000000018B7993DC-0x000000018B7993EC
		public void RestoreSnapshot() {} // 0x00000001814A81B0-0x00000001814A81C0
		public object GetEvalValue(float time) => default; // 0x0000000185492010-0x0000000185492020
		public object ResolvedMemberObject() => default; // 0x0000000185492010-0x0000000185492020
		public object GetCurrentValueAsObject() => default; // 0x000000018B799F48-0x000000018B799FB8
		private float[] GetCurrentValueAsFloats() => default; // 0x000000018B799ED8-0x000000018B799F48
		public void SetCurrentValue(object value) {} // 0x000000018B799618-0x000000018B7996A8
		private void SetCurrentValue(float[] floats) {} // 0x000000018B7996A8-0x000000018B799770
		public bool HasChanged() => default; // 0x000000018B798460-0x000000018B7984C0
		public bool HasAnyKey() => default; // 0x000000018B79A028-0x000000018B79A030
		public bool HasKey(float time) => default; // 0x000000018B798B20-0x000000018B798DA0
		public float GetKeyNext(float time) => default; // 0x000000018B7992B8-0x000000018B7993CC
		public float GetKeyPrevious(float time) => default; // 0x0000000185492010-0x0000000185492020
		public bool TryKeyIdentity(float time) => default; // 0x000000018B7995A0-0x000000018B799618
		public void SetKeyCurrent(float time) {} // 0x00000001813B51D0-0x00000001813B51E0
		public void RemoveKey(float time) {} // 0x00000001864721F0-0x0000000186472200
		public void SetPreWrapMode(UnityEngine.WrapMode mode) {} // 0x00000001813ECBC0-0x00000001813ECBD0
		public void SetPostWrapMode(UnityEngine.WrapMode mode) {} // 0x0000000185A16440-0x0000000185A16450
		public void OffsetValue(object deltaValue) {} // 0x00000001813FF010-0x00000001813FF020
		public void Reset() {} // 0x0000000185F05C80-0x0000000185F05C90
		public void ChangeMemberType(ParameterType newType) {} // 0x00000001813ECF20-0x00000001813ECF30
		public override string ToString() => default; // 0x000000018571FEC0-0x000000018571FED0
		public string FriendlyName() => default; // 0x000000018B7AD1EC-0x000000018B7AD364
		public string GetKeyLabel(float time) => default; // 0x0000000185492010-0x0000000185492020
		private void RecordUndo() {} // 0x0000000185492010-0x0000000185492020
		private void NotifyChange() {} // 0x000000018B7AE17C-0x000000018B7AE1A0
	}

	public interface IAnimatedParameterModel // TypeDefIndex: 55626
	{
		// Methods
		bool ForceStepMode();
		int RequiredCurvesCount();
		object ConvertToObject(float[] floats);
		float[] ConvertToFloats(object value);
		string GetKeyLabel(float[] floats);
		void SetDirect(object target, MemberInfo info, float[] floats);
		float[] GetDirect(object target, MemberInfo info);
	}

	public struct Animated_Bool : IAnimatedParameterModel // TypeDefIndex: 55627
	{
		// Fields
		private Action<object, bool> setter; // 0x00
	
		// Methods
		public bool ForceStepMode() => default; // 0x00000001840A27C0-0x00000001840A27D0
		public int RequiredCurvesCount() => default; // 0x0000000181B87DE0-0x0000000181B87DF0
		public object ConvertToObject(float[] floats) => default; // 0x000000018B79AB00-0x000000018B79AB64
		public float[] ConvertToFloats(object value) => default; // 0x000000018B79AA64-0x000000018B79AB00
		public string GetKeyLabel(float[] floats) => default; // 0x000000018B79AC38-0x000000018B79ACBC
		public void SetDirect(object target, MemberInfo info, float[] floats) {} // 0x000000018B79ACBC-0x000000018B79AD80
		public float[] GetDirect(object target, MemberInfo info) => default; // 0x000000018B79AB64-0x000000018B79AC38
	}

	public struct Animated_Int : IAnimatedParameterModel // TypeDefIndex: 55628
	{
		// Fields
		private Action<object, int> setter; // 0x00
	
		// Methods
		public bool ForceStepMode() => default; // 0x00000001840A27C0-0x00000001840A27D0
		public int RequiredCurvesCount() => default; // 0x0000000181B87DE0-0x0000000181B87DF0
		public object ConvertToObject(float[] floats) => default; // 0x000000018B79BC74-0x000000018B79BCD0
		public float[] ConvertToFloats(object value) => default; // 0x000000018B79BBE8-0x000000018B79BC74
		public string GetKeyLabel(float[] floats) => default; // 0x000000018B79BD90-0x000000018B79BE0C
		public void SetDirect(object target, MemberInfo info, float[] floats) {} // 0x000000018B79BE0C-0x000000018B79BEC4
		public float[] GetDirect(object target, MemberInfo info) => default; // 0x000000018B79BCD0-0x000000018B79BD90
	}

	public struct Animated_Float : IAnimatedParameterModel // TypeDefIndex: 55629
	{
		// Fields
		private Action<object, float> setter; // 0x00
	
		// Methods
		public bool ForceStepMode() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public int RequiredCurvesCount() => default; // 0x0000000181B87DE0-0x0000000181B87DF0
		public object ConvertToObject(float[] floats) => default; // 0x000000018B79B994-0x000000018B79B9F4
		public float[] ConvertToFloats(object value) => default; // 0x000000018B79B90C-0x000000018B79B994
		public string GetKeyLabel(float[] floats) => default; // 0x000000018B79BAB4-0x000000018B79BB30
		public void SetDirect(object target, MemberInfo info, float[] floats) {} // 0x000000018B79BB30-0x000000018B79BBE8
		public float[] GetDirect(object target, MemberInfo info) => default; // 0x000000018B79B9F4-0x000000018B79BAB4
	}

	public struct Animated_Vector2 : IAnimatedParameterModel // TypeDefIndex: 55630
	{
		// Fields
		private Action<object, Vector2> setter; // 0x00
	
		// Methods
		public bool ForceStepMode() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public int RequiredCurvesCount() => default; // 0x0000000181C6A970-0x0000000181C6A980
		public object ConvertToObject(float[] floats) => default; // 0x000000018B79C908-0x000000018B79C974
		public float[] ConvertToFloats(object value) => default; // 0x000000018B79C86C-0x000000018B79C908
		public string GetKeyLabel(float[] floats) => default; // 0x000000018B79CA48-0x000000018B79CAF8
		public void SetDirect(object target, MemberInfo info, float[] floats) {} // 0x000000018B79CAF8-0x000000018B79CBC4
		public float[] GetDirect(object target, MemberInfo info) => default; // 0x000000018B79C974-0x000000018B79CA48
	}

	public struct Animated_Vector3 : IAnimatedParameterModel // TypeDefIndex: 55631
	{
		// Fields
		private Action<object, Vector3> setter; // 0x00
	
		// Methods
		public bool ForceStepMode() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public int RequiredCurvesCount() => default; // 0x0000000181D1CE70-0x0000000181D1CE80
		public object ConvertToObject(float[] floats) => default; // 0x000000018B79CC64-0x000000018B79CCE4
		public float[] ConvertToFloats(object value) => default; // 0x000000018B79CBC4-0x000000018B79CC64
		public string GetKeyLabel(float[] floats) => default; // 0x000000018B79CDBC-0x000000018B79CEA0
		public void SetDirect(object target, MemberInfo info, float[] floats) {} // 0x000000018B79CEA0-0x000000018B79CF80
		public float[] GetDirect(object target, MemberInfo info) => default; // 0x000000018B79CCE4-0x000000018B79CDBC
	}

	public struct Animated_Color : IAnimatedParameterModel // TypeDefIndex: 55632
	{
		// Fields
		private Action<object, UnityEngine.Color> setter; // 0x00
	
		// Methods
		public bool ForceStepMode() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public int RequiredCurvesCount() => default; // 0x0000000181C44E90-0x0000000181C44EA0
		public object ConvertToObject(float[] floats) => default; // 0x000000018B79B538-0x000000018B79B5D4
		public float[] ConvertToFloats(object value) => default; // 0x000000018B79B484-0x000000018B79B538
		public string GetKeyLabel(float[] floats) => default; // 0x000000018B79B6C0-0x000000018B79B80C
		public void SetDirect(object target, MemberInfo info, float[] floats) {} // 0x000000018B79B80C-0x000000018B79B90C
		public float[] GetDirect(object target, MemberInfo info) => default; // 0x000000018B79B5D4-0x000000018B79B6C0
	}

	public struct Animated_Vector4 : IAnimatedParameterModel // TypeDefIndex: 55633
	{
		// Fields
		private Action<object, Vector4> setter; // 0x00
	
		// Methods
		public bool ForceStepMode() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public int RequiredCurvesCount() => default; // 0x0000000181C44E90-0x0000000181C44EA0
		public object ConvertToObject(float[] floats) => default; // 0x000000018B79D034-0x000000018B79D0D0
		public float[] ConvertToFloats(object value) => default; // 0x000000018B79CF80-0x000000018B79D034
		public string GetKeyLabel(float[] floats) => default; // 0x000000018B79D1BC-0x000000018B79D354
		public void SetDirect(object target, MemberInfo info, float[] floats) {} // 0x000000018B79D354-0x000000018B79D454
		public float[] GetDirect(object target, MemberInfo info) => default; // 0x000000018B79D0D0-0x000000018B79D1BC
	}

	public struct Animated_Quaternion : IAnimatedParameterModel // TypeDefIndex: 55634
	{
		// Fields
		private Action<object, Quaternion> setter; // 0x00
	
		// Methods
		public bool ForceStepMode() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public int RequiredCurvesCount() => default; // 0x0000000181C44E90-0x0000000181C44EA0
		public object ConvertToObject(float[] floats) => default; // 0x000000018B79BF78-0x000000018B79C014
		public float[] ConvertToFloats(object value) => default; // 0x000000018B79BEC4-0x000000018B79BF78
		public string GetKeyLabel(float[] floats) => default; // 0x000000018B79C100-0x000000018B79C298
		public void SetDirect(object target, MemberInfo info, float[] floats) {} // 0x000000018B79C298-0x000000018B79C398
		public float[] GetDirect(object target, MemberInfo info) => default; // 0x000000018B79C014-0x000000018B79C100
	}

	public struct Animated_Rect : IAnimatedParameterModel // TypeDefIndex: 55635
	{
		// Fields
		private Action<object, Rect> setter; // 0x00
	
		// Methods
		public bool ForceStepMode() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public int RequiredCurvesCount() => default; // 0x0000000181C44E90-0x0000000181C44EA0
		public object ConvertToObject(float[] floats) => default; // 0x000000018B79C44C-0x000000018B79C4E8
		public float[] ConvertToFloats(object value) => default; // 0x000000018B79C398-0x000000018B79C44C
		public string GetKeyLabel(float[] floats) => default; // 0x000000018B79C5D4-0x000000018B79C76C
		public void SetDirect(object target, MemberInfo info, float[] floats) {} // 0x000000018B79C76C-0x000000018B79C86C
		public float[] GetDirect(object target, MemberInfo info) => default; // 0x000000018B79C4E8-0x000000018B79C5D4
	}

	public struct Animated_Bounds : IAnimatedParameterModel // TypeDefIndex: 55636
	{
		// Fields
		private Action<object, Bounds> setter; // 0x00
	
		// Methods
		public bool ForceStepMode() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public int RequiredCurvesCount() => default; // 0x0000000181D409B0-0x0000000181D40CF0
		public object ConvertToObject(float[] floats) => default; // 0x000000018B79AEA4-0x000000018B79AFA4
		public float[] ConvertToFloats(object value) => default; // 0x000000018B79AD80-0x000000018B79AEA4
		public string GetKeyLabel(float[] floats) => default; // 0x000000018B79B104-0x000000018B79B318
		public void SetDirect(object target, MemberInfo info, float[] floats) {} // 0x000000018B79B318-0x000000018B79B484
		public float[] GetDirect(object target, MemberInfo info) => default; // 0x000000018B79AFA4-0x000000018B79B104
	}

	[Serializable]
	public class AnimationDataCollection : IAnimatableData // TypeDefIndex: 55644
	{
		// Fields
		private List<AnimatedParameter> _animatedParameters; // 0x10
	
		// Properties
		public List<AnimatedParameter> animatedParameters { get => default; } // 0x000000018B79DD1C-0x000000018B79DDB8 
		public bool isValid { get => default; } // 0x000000018B79DC04-0x000000018B79DC90 
		public AnimatedParameter this[int i] { get => default; } // 0x000000018B79E2D4-0x000000018B79E34C 
		public AnimatedParameter this[string name] { get => default; } // 0x000000018B79D6D4-0x000000018B79D900 
	
		// Nested types
		public delegate bool AddParameterDelegate(System.Type type, string memberPath, string transformPath); // TypeDefIndex: 55637; 0x000000018B79EB24-0x000000018B79EB68
	
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 55638
		{
			// Fields
			public AnimatedParameter newParam; // 0x10
	
			// Constructors
			public __c__DisplayClass12_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal bool _TryAddParameter_b__0(AnimatedParameter p) => default; // 0x000000018B79EA30-0x000000018B79EAB4
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 55639
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<AnimatedParameter, string> __9__14_0; // 0x08
			public static Func<AnimatedParameter, string> __9__14_1; // 0x10
			public static Func<float, float> __9__31_1; // 0x18
			public static Func<float, float> __9__32_1; // 0x20
	
			// Constructors
			static __c() {} // 0x000000018B79E628-0x000000018B79E864
			public __c() {} // 0x000000018B79E178-0x000000018B79E1CC
	
			// Methods
			internal string _ReOrderParameters_b__14_0(AnimatedParameter p) => default; // 0x000000018B79DF0C-0x000000018B79E100
			internal string _ReOrderParameters_b__14_1(AnimatedParameter p) => default; // 0x000000018B79DB2C-0x000000018B79DC04
			internal float _GetKeyNext_b__31_1(float t) => default; // 0x000000018B79D518-0x000000018B79D524
			internal float _GetKeyPrevious_b__32_1(float t) => default; // 0x000000018B79D50C-0x000000018B79D518
		}
	
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 55640
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass15_0() {} // 0x000000018B79DDB8-0x000000018B79DF0C
	
			// Methods
			internal bool _GetParameterOfName_b__0(AnimatedParameter d) => default; // 0x000000018B79E99C-0x000000018B79EA30
		}
	
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 55641
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass31_0() {} // 0x000000018B79E4F0-0x000000018B79E584
	
			// Methods
			internal float _GetKeyNext_b__0(AnimatedParameter p) => default; // 0x000000018B79E46C-0x000000018B79E4F0
			internal bool _GetKeyNext_b__2(float t) => default; // 0x000000018B79E864-0x000000018B79E920
		}
	
		private sealed class __c__DisplayClass32_0 // TypeDefIndex: 55642
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass32_0() {} // 0x000000018B79D454-0x000000018B79D50C
	
			// Methods
			internal float _GetKeyPrevious_b__0(AnimatedParameter p) => default; // 0x000000018B79E250-0x000000018B79E2D4
			internal bool _GetKeyPrevious_b__2(float t) => default; // 0x000000018B79E920-0x000000018B79E99C
		}
	
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 55643
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass33_0() {} // 0x000000018B79E100-0x000000018B79E178
	
			// Methods
			internal bool _GetKeyLabel_b__0(AnimatedParameter p) => default; // 0x000000018B79DC90-0x000000018B79DD1C
		}
	
		// Constructors
		public AnimationDataCollection() {} // 0x000000018B79D900-0x000000018B79DB2C
		public AnimationDataCollection(IKeyable keyable, System.Type type, string[] memberPaths, string transformPath) {} // 0x000000018B79D524-0x000000018B79D6D4
	
		// Methods
		public bool TryAddParameter(IKeyable keyable, System.Type type, string memberPath, string transformPath) => default; // 0x000000018B79E3DC-0x000000018B79E46C
		public void RemoveParameter(AnimatedParameter animParam) {} // 0x000000018B79E34C-0x000000018B79E3DC
		public void ReOrderParameters() {} // 0x000000018B79E1CC-0x000000018B79E250
		public AnimatedParameter GetParameterOfName(string name) => default; // 0x000000018B79E584-0x000000018B79E628
		public AnimationCurve[] GetCurves() => default; // 0x000000018B798228-0x000000018B798350
		public AnimationCurve[] GetCurvesAll() => default; // 0x00000001817E31E0-0x00000001817E3200
		private AnimationCurve[] Internal_GetCurves(bool enabledParamsOnly) => default; // 0x0000000187206B7C-0x0000000187206BB4
		public void Validate(IKeyable keyable) {} // 0x00000001864BBBD0-0x00000001864BBD00
		public void SetVirtualTransformParent(Transform virtualTransformParent) {} // 0x0000000185492010-0x0000000185492020
		public void SetSnapshot() {} // 0x000000018B7AE1A0-0x000000018B7AE1C8
		public bool TryAutoKey(float time) => default; // 0x000000018B7AE318-0x000000018B7AE37C
		public void Evaluate(float time, float previousTime, float weight = 1f /* Metadata: 0x0207BF4B */) {} // 0x0000000185492010-0x0000000185492020
		public void RestoreSnapshot() {} // 0x000000018B7AE13C-0x000000018B7AE15C
		public bool TryKeyIdentity(float time) => default; // 0x000000018B7AE15C-0x000000018B7AE17C
		public void RemoveKey(float time) {} // 0x0000000183667B80-0x0000000183667B90
		public bool HasChanged() => default; // 0x0000000183667B80-0x0000000183667B90
		public bool HasKey(float time) => default; // 0x0000000185492010-0x0000000185492020
		public bool HasAnyKey() => default; // 0x000000018B7AE1C8-0x000000018B7AE228
		public void SetKeyCurrent(float time) {} // 0x0000000185492010-0x0000000185492020
		public float GetKeyNext(float time) => default; // 0x000000018B7AE260-0x000000018B7AE284
		public float GetKeyPrevious(float time) => default; // 0x000000018B7AE284-0x000000018B7AE28C
		public string GetKeyLabel(float time) => default; // 0x0000000185492010-0x0000000185492020
		public void SetPreWrapMode(UnityEngine.WrapMode mode) {} // 0x000000018B7AE28C-0x000000018B7AE2B0
		public void SetPostWrapMode(UnityEngine.WrapMode mode) {} // 0x000000018B7AE2B0-0x000000018B7AE2BC
		public void Reset() {} // 0x0000000185492010-0x0000000185492020
		public override string ToString() => default; // 0x000000018B7AE2BC-0x000000018B7AE2E0
	}

	public class Cutscene : MonoBehaviour, IDirector // TypeDefIndex: 55654
	{
		// Fields
		public const float VERSION_NUMBER = 2.15f; // Metadata: 0x0207BF52
		private static Action<Cutscene> OnCutsceneStarted; // 0x00
		private static Action<Cutscene> OnCutsceneStopped; // 0x08
		private Action<Section> OnSectionReached; // 0x18
		private Action<string, object> OnGlobalMessageSend; // 0x20
		private Action OnStop; // 0x28
		private UpdateMode _updateMode; // 0x30
		private WrapMode _defaultWrapMode; // 0x34
		private StopMode _defaultStopMode; // 0x38
		private float _playbackSpeed; // 0x3C
		private bool _playOnStart; // 0x40
		private bool _explicitActiveLayers; // 0x41
		private LayerMask _activeLayers; // 0x44
		public List<CutsceneGroup> groups; // 0x48
		private float _length; // 0x50
		private float _viewTimeMin; // 0x54
		private float _viewTimeMax; // 0x58
		[NonSerialized]
		private float _currentTime; // 0x5C
		[NonSerialized]
		private float _playTimeMin; // 0x60
		[NonSerialized]
		private float _playTimeMax; // 0x64
		[NonSerialized]
		private Transform _groupsRoot; // 0x68
		[NonSerialized]
		private List<IDirectableTimePointer> timePointers; // 0x70
		[NonSerialized]
		private List<IDirectableTimePointer> unsortedStartTimePointers; // 0x78
		[NonSerialized]
		private Dictionary<GameObject, bool> affectedLayerGOStates; // 0x80
		[NonSerialized]
		private static Dictionary<string, Cutscene> allSceneCutscenes; // 0x10
		[NonSerialized]
		private bool preInitialized; // 0x88
		[NonSerialized]
		private bool _isReSampleFrame; // 0x89
		private bool _isBakingRootMotion_k__BackingField; // 0x8A
		private PlayingDirection _playingDirection_k__BackingField; // 0x8C
		private WrapMode _playingWrapMode_k__BackingField; // 0x90
		private List<IDirectable> _directables_k__BackingField; // 0x98
		private bool _isActive_k__BackingField; // 0xA0
		private bool _isPaused_k__BackingField; // 0xA1
		private float _previousTime_k__BackingField; // 0xA4
	
		// Properties
		public Transform groupsRoot { get => default; } // 0x0000000185FB3000-0x0000000185FB3010 
		public UpdateMode updateMode { get => default; set {} } // 0x000000018B7A884C-0x000000018B7A885C 0x0000000183F80440-0x0000000183F80450
		public WrapMode defaultWrapMode { get => default; set {} } // 0x000000018B7A8934-0x000000018B7A8958 0x0000000181DE2580-0x0000000181DE2590
		public StopMode defaultStopMode { get => default; set {} } // 0x000000018B7A88A8-0x000000018B7A8934 0x0000000185FB2200-0x0000000185FB2210
		public bool playOnStart { get => default; set {} } // 0x000000018B7A8884-0x000000018B7A88A8 0x0000000185FB2210-0x0000000185FB2220
		public bool explicitActiveLayers { get => default; set {} } // 0x000000018B7A885C-0x000000018B7A8884 0x0000000185FB0580-0x0000000185FB0590
		public LayerMask activeLayers { get => default; set {} } // 0x0000000185FB05E0-0x0000000185FB05F0 0x000000018349D720-0x000000018349D730
		public DirectorGroup directorGroup { get => default; } // 0x00000001834A21B0-0x00000001834A21C0 
		public ActorGroup actorGroup { get => default; } // 0x00000001834A0D50-0x00000001834A0D60 
		public virtual bool abortDirectorCamera { get => default; } // 0x00000001834A2260-0x00000001834A2270 
		public virtual bool multiSelectOverlapCheck { get => default; } // 0x0000000181E336C0-0x0000000181E336D0 
		public bool isBakingRootMotion { get; set; } // 0x00000001873350D4-0x00000001873350E8 0x000000018346D900-0x000000018346D910
		public CameraTrack cameraTrack { get => default; } // 0x00000001834A2240-0x00000001834A2250 
		public float currentTime { get => default; set {} } // 0x000000018349D660-0x000000018349D670 0x00000001834A2080-0x00000001834A2090
		public virtual float length { get => default; set {} } // 0x0000000185FB8C30-0x0000000185FB8C40 0x0000000185FD5C00-0x0000000185FD5C10
		public float viewTimeMin { get => default; set {} } // 0x0000000185FB3080-0x0000000185FB3090 0x000000018B7A6E8C-0x000000018B7A6EE8
		public float viewTimeMax { get => default; set {} } // 0x000000018B7A6E50-0x000000018B7A6E8C 0x000000018B7A84C4-0x000000018B7A84F0
		public float playTimeMin { get => default; set {} } // 0x000000018B7A3AE0-0x000000018B7A3C18 0x000000018B7A6EE8-0x000000018B7A6EFC
		public float playTimeMax { get => default; set {} } // 0x000000018B7A56F0-0x000000018B7A57EC 0x000000018B7A56BC-0x000000018B7A56F0
		public float playbackSpeed { get => default; set {} } // 0x000000018B7A5658-0x000000018B7A56BC 0x000000018B7A40D8-0x000000018B7A4120
		public PlayingDirection playingDirection { get; set; } // 0x000000018B7A3C70-0x000000018B7A3D40 0x000000018B7A4120-0x000000018B7A4248
		public WrapMode playingWrapMode { get; set; } // 0x000000018B7A438C-0x000000018B7A44C0 0x000000018B7A63AC-0x000000018B7A63B8
		public List<IDirectable> directables { get; private set; } // 0x000000018B7A6118-0x000000018B7A6128 0x000000018B7A6128-0x000000018B7A6150
		public bool isActive { get; private set; } // 0x000000018B7A5F10-0x000000018B7A5F38 0x000000018B7A6150-0x000000018B7A63AC
		public bool isPaused { get; private set; } // 0x000000018B7A70C0-0x000000018B7A70CC 0x000000018B7A6F94-0x000000018B7A70C0
		public float previousTime { get; private set; } // 0x000000018B7A5D08-0x000000018B7A5D18 0x000000018B7A5D18-0x000000018B7A5D40
		bool IDirector.isReSampleFrame { get => default; } // 0x0000000185FD5BD0-0x0000000185FD5BE0 
		GameObject IDirector.context { get => default; } // 0x0000000185FD5BE0-0x0000000185FD5BF0 
		IEnumerable<IDirectable> IDirector.children { get => default; } // 0x000000018B7A6D90-0x000000018B7A6DBC 
		public float remainingTime { get => default; } // 0x000000018B7A6710-0x000000018B7A6740 
	
		// Events
		public static event Action<Cutscene> OnCutsceneStarted;
		public static event Action<Cutscene> OnCutsceneStopped;
		public event Action<Section> OnSectionReached;
		public event Action<string, object> OnGlobalMessageSend;
		public event Action OnStop;
	
		// Nested types
		public enum WrapMode // TypeDefIndex: 55645
		{
			Once = 0,
			Loop = 1,
			PingPong = 2
		}
	
		public enum StopMode // TypeDefIndex: 55646
		{
			Skip = 0,
			Rewind = 1,
			Hold = 2,
			SkipRewindNoUndo = 3
		}
	
		public enum UpdateMode // TypeDefIndex: 55647
		{
			Normal = 0,
			AnimatePhysics = 1,
			UnscaledTime = 2,
			Manual = 3
		}
	
		public enum PlayingDirection // TypeDefIndex: 55648
		{
			Forwards = 0,
			Backwards = 1
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 55649
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<CutsceneGroup> __9__62_0; // 0x08
			public static Predicate<CutsceneGroup> __9__64_0; // 0x10
			public static Predicate<CutsceneTrack> __9__74_0; // 0x18
			public static Func<ActorGroup, GameObject> __9__135_0; // 0x20
			public static Func<IDirectableTimePointer, float> __9__136_0; // 0x28
			public static Comparison<IDirectableTimePointer> __9__170_0; // 0x30
			public static Func<Section, string> __9__190_0; // 0x38
			public static Func<IEvent, string> __9__191_0; // 0x40
	
			// Constructors
			static __c() {} // 0x000000018B7A7BCC-0x000000018B7A7C90
			public __c() {} // 0x000000018B7A84F0-0x000000018B7A85B4
	
			// Methods
			internal bool _get_directorGroup_b__62_0(CutsceneGroup g) => default; // 0x000000018B7A7C90-0x000000018B7A7D58
			internal bool _get_actorGroup_b__64_0(CutsceneGroup g) => default; // 0x000000018B7A85B4-0x000000018B7A867C
			internal bool _get_cameraTrack_b__74_0(CutsceneTrack t) => default; // 0x000000018B7A7DE4-0x000000018B7A7E70
			internal GameObject _GetAffectedActors_b__135_0(ActorGroup g) => default; // 0x000000018B7A8708-0x000000018B7A8794
			internal float _GetPointerTimes_b__136_0(IDirectableTimePointer t) => default; // 0x000000018B7A7D58-0x000000018B7A7DE4
			internal int _InitializeTimePointers_b__170_0(IDirectableTimePointer a, IDirectableTimePointer b) => default; // 0x000000018B7A867C-0x000000018B7A8708
			internal string _GetSectionNames_b__190_0(Section s) => default; // 0x000000018B7A7E70-0x000000018B7A7F04
			internal string _GetDefinedEventNames_b__191_0(IEvent d) => default; // 0x000000018B7A8794-0x000000018B7A8828
		}
	
		private sealed class __c__DisplayClass177_0 // TypeDefIndex: 55650
		{
			// Fields
			public Action callback; // 0x10
			public Cutscene instance; // 0x18
	
			// Constructors
			public __c__DisplayClass177_0() {} // 0x000000018B7A8310-0x000000018B7A84C4
	
			// Methods
			internal void _Play_b__0() {} // 0x00000001813CFF60-0x00000001813CFF70
		}
	
		private sealed class __c__DisplayClass182_0 // TypeDefIndex: 55651
		{
			// Fields
			public string groupName; // 0x10
	
			// Constructors
			public __c__DisplayClass182_0() {} // 0x00000001813D0A90-0x00000001813D0AA0
	
			// Methods
			internal bool _SetGroupActorOfName_b__0(ActorGroup g) => default; // 0x0000000185FB07C0-0x0000000185FB07D0
		}
	
		private sealed class __c__DisplayClass184_0 // TypeDefIndex: 55652
		{
			// Fields
			public string[] split; // 0x10
	
			// Constructors
			public __c__DisplayClass184_0() {} // 0x0000000185FB07E0-0x0000000185FB07F0
	
			// Methods
			internal bool _FindElement_b__0(CutsceneGroup g) => default; // 0x00000001813E5E30-0x00000001813E5E40
		}
	
		private sealed class _Internal_RenderCutscene_d__194 : IEnumerator<object> // TypeDefIndex: 55653
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public int frameRate; // 0x20
			public Cutscene __4__this; // 0x28
			public int width; // 0x30
			public int height; // 0x34
			public Action<Texture2D[]> callback; // 0x38
			private List<Texture2D> _renderSequence_5__2; // 0x40
			private float _sampleRate_5__3; // 0x48
			private float _i_5__4; // 0x4C
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185FB0D70-0x0000000185FB0D80 
			object IEnumerator.Current { get => default; } // 0x0000000183908D10-0x0000000183908D20 
	
			// Constructors
			public _Internal_RenderCutscene_d__194() {} // Dummy constructor
			public _Internal_RenderCutscene_d__194(int __1__state) {} // 0x00000001813E6F50-0x00000001813E6F60
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FB0650-0x0000000185FB0660
			private bool MoveNext() => default; // 0x0000000185FB0660-0x0000000185FB0670
			void IEnumerator.Reset() {} // 0x0000000185FB0D90-0x0000000185FB0DA0
		}
	
		// Constructors
		public Cutscene() {} // 0x000000018B7C09CC-0x000000018B7C0A18
		static Cutscene() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		protected void Awake() {} // 0x000000018B7A66CC-0x000000018B7A6710
		protected void Start() {} // 0x0000000185FD5BC0-0x0000000185FD5BD0
		protected void OnDestroy() {} // 0x000000018B7A3C18-0x000000018B7A3C70
		public void ManualUpdate(float deltaTime) {} // 0x000000018B7A6E48-0x000000018B7A6E50
		protected void LateUpdate() {} // 0x000000018B7A6DBC-0x000000018B7A6E48
		protected void FixedUpdate() {} // 0x000000018B7A5634-0x000000018B7A5658
		private void DirectorSectionReached(Section section) {} // 0x000000018B7A55AC-0x000000018B7A5634
		public IEnumerable<GameObject> GetAffectedActors() => default; // 0x000000018B7A5BC4-0x000000018B7A5BE4
		public float[] GetPointerTimes() => default; // 0x000000018B7A5C04-0x000000018B7A5C50
		public void Play() {} // 0x000000018B7A5BE4-0x000000018B7A5C04
		public void Play(Action callback) {} // 0x000000018B7A5C50-0x000000018B7A5D08
		public void Play(float startTime) {} // 0x000000018B7A5E90-0x000000018B7A5EC4
		public void Play(float startTime, Action callback) {} // 0x000000018B7A5E24-0x000000018B7A5E70
		public void Play(float startTime, float endTime, WrapMode wrapMode = WrapMode.Once /* Metadata: 0x0207BF4F */, Action callback = null, PlayingDirection playDirection = PlayingDirection.Forwards /* Metadata: 0x0207BF50 */) {} // 0x000000018B7A5E70-0x000000018B7A5E90
		public void Stop() {} // 0x000000018B7A5D40-0x000000018B7A5E24
		public void Stop(StopMode stopMode) {} // 0x000000018B7A6740-0x000000018B7A6750
		public void PlayReverse() {} // 0x000000018B7A6750-0x000000018B7A6860
		public void PlayReverse(float startTime, float endTime) {} // 0x000000018B7A51B4-0x000000018B7A55AC
		public void Pause() {} // 0x000000018B7A63D8-0x000000018B7A6448
		public void Resume() {} // 0x000000018B7A72B4-0x000000018B7A7AA0
		public void SkipAll() {} // 0x000000018B7A4730-0x000000018B7A5118
		public void Rewind() {} // 0x000000018B7A59AC-0x000000018B7A5BC4
		public void RewindNoUndo() {} // 0x000000018B7A57EC-0x000000018B7A59AC
		public void BreakCutsceneLoop() {} // 0x000000018B7A6C40-0x000000018B7A6D90
		public void BreakSectionLoop(bool alsoSkip = false /* Metadata: 0x0207BF51 */) {} // 0x000000018B7A6540-0x000000018B7A66CC
		public void Skip() {} // 0x000000018B7A7114-0x000000018B7A72B4
		public void SkipCurrentSection() {} // 0x000000018B7A5EC4-0x000000018B7A5F10
		public bool JumpToSection(string name) => default; // 0x000000018B7A5F38-0x000000018B7A6118
		public bool JumpToSection(Section section) => default; // 0x000000018B7A3EC4-0x000000018B7A400C
		public bool PlayFromSection(string name) => default; // 0x000000018B7A400C-0x000000018B7A40D8
		public bool PlayFromSection(string name, WrapMode wrap, Action callback = null) => default; // 0x000000018B7A6EFC-0x000000018B7A6F94
		public bool PlayFromSection(Section section) => default; // 0x000000018B7A6860-0x000000018B7A6A5C
		public bool PlayFromSection(Section section, WrapMode wrap, Action callback = null) => default; // 0x000000018B7A6A5C-0x000000018B7A6C40
		public bool PlaySection(string name) => default;
		public bool PlaySection(string name, WrapMode wrap, Action callback = null) => default; // 0x000000018B7A3D40-0x000000018B7A3EC4
		public bool PlaySection(Section section) => default; // 0x000000018B7A70CC-0x000000018B7A7114
		public bool PlaySection(Section section, WrapMode wrap, Action callback = null) => default; // 0x000000018B7A44C0-0x000000018B7A44F0
		public void Sample() {} // 0x000000018B7A44F0-0x000000018B7A4520
		public void Sample(float time) {} // 0x000000018B7A46DC-0x000000018B7A4730
		private void Internal_SamplePointers(float currentTime, float previousTime) {} // 0x000000018B7A4520-0x000000018B7A45A4
		public void ReSample() {} // 0x000000018B7A45A4-0x000000018B7A46DC
		public void Validate() {} // 0x000000018B7A4248-0x000000018B7A438C
		private void InitializeTimePointers() {} // 0x000000018B7A63B8-0x000000018B7A63D8
		private void OnSampleStarted() {} // 0x000000018B7A6448-0x000000018B7A6540
		private void OnSampleEnded() {} // 0x000000018B7A5118-0x000000018B7A51B4
		private void SetLayersActive() {} // 0x000000018B7A7B34-0x000000018B7A7BCC
		private void RestoreLayersActive() {} // 0x000000018B7A7AA0-0x000000018B7A7B34
		private void UpdateCutscene(float delta) {} // 0x000000018B7C117C-0x000000018B7C11E0
		public static Cutscene Play(string name) => default; // 0x0000000185492010-0x0000000185492020
		public static Cutscene Play(string name, Action callback) => default; // 0x000000018B7C0C78-0x000000018B7C0CB8
		public static Cutscene FindFromResources(string name) => default; // 0x000000018B7C0BF8-0x000000018B7C0C38
		public static Cutscene Find(string name) => default; // 0x000000018B7C0C38-0x000000018B7C0C78
		public static void StopAllCutscenes() {} // 0x000000018B7C0A18-0x000000018B7C0A38
		public void SendGlobalMessage(string message, object value = null) {} // 0x000000018B7C0A94-0x000000018B7C0AB0
		public void SetGroupActorOfName(string groupName, GameObject newActor) {} // 0x000000018B7C0AB0-0x000000018B7C0B74
		public T FindElement<T>(string path)
			where T : IDirectable => default; // 0x0000000187AD0B74-0x0000000187AD0B8C
		public IDirectable FindElement(string path) => default; // 0x000000018B7C0A38-0x000000018B7C0A94
		public override string ToString() => default; // 0x0000000185492010-0x0000000185492020
		public Section GetSectionByName(string name) => default; // 0x000000018B7C0E14-0x000000018B7C0EBC
		public Section GetSectionByUID(string UID) => default; // 0x0000000185492010-0x0000000185492020
		public Section[] GetSections() => default; // 0x000000018B7C0EBC-0x000000018B7C0F18
		public float GetSectionLength(string name) => default; // 0x0000000185492010-0x0000000185492020
		public string[] GetSectionNames() => default; // 0x000000018B7C0F18-0x000000018B7C0F8C
		public string[] GetDefinedEventNames() => default; // 0x0000000181378230-0x0000000181378240
		public void PreInitialize() {} // 0x0000000185492010-0x0000000185492020
		public void RenderCutscene(int width, int height, int frameRate, Action<Texture2D[]> callback) {} // 0x000000018B7C078C-0x000000018B7C09CC
		private IEnumerator Internal_RenderCutscene(int width, int height, int frameRate, Action<Texture2D[]> callback) => default; // 0x0000000181377E40-0x0000000181377E50
	}

	public abstract class CutsceneGroup : MonoBehaviour, IDirectable // TypeDefIndex: 55663
	{
		// Fields
		private Action<Section> OnSectionReached; // 0x18
		private List<CutsceneTrack> _tracks; // 0x20
		private List<Section> _sections; // 0x28
		private bool _isCollapsed; // 0x30
		private bool _active; // 0x31
		private bool _isLocked; // 0x32
		private bool _isReadOnly; // 0x33
		private TransformSnapshot transformSnapshot; // 0x38
		private ObjectSnapshot objectSnapshot; // 0x40
		private GameObject refDuplicateActor; // 0x48
		private static int totalCustomToggleNum; // 0x00
		public List<CustomToggleInfo> customToggle; // 0x50
		private bool m_customToggleValid; // 0x58
		private bool m_customToggleCheckDirty; // 0x59
		[NonSerialized]
		public Dictionary<int, CustomToggleInfo> customInfoCache; // 0x60
		private IDirector _root_k__BackingField; // 0x68
	
		// Properties
		public abstract new string name { get; set; } // 0x000000018B7B4994-0x000000018B7B503C 0x00000001813B31A0-0x00000001813B31B0
		public abstract GameObject actor { get; set; } // 0x000000018646EE40-0x000000018646EE50 0x00000001813B8590-0x00000001813B85A0
		public abstract ActorReferenceMode referenceMode { get; set; } // 0x0000000184A4EDC0-0x0000000184A4EDD0 0x000000018B7B4280-0x000000018B7B42BC
		public abstract ActorInitialTransformation initialTransformation { get; set; } // 0x0000000183908D00-0x0000000183908D10 0x000000018B7B42BC-0x000000018B7B42D8
		public abstract Vector3 initialLocalPosition { get; set; } // 0x0000000183908D00-0x0000000183908D10 0x0000000183908D00-0x0000000183908D10
		public abstract Vector3 initialLocalRotation { get; set; } // 0x00000001814A81B0-0x00000001814A81C0 0x00000001813AE580-0x00000001813AE590
		public abstract bool displayVirtualMeshGizmo { get; set; } // 0x00000001813AC280-0x00000001813AC290 0x0000000185A62990-0x0000000185A629A0
		public virtual bool needActor { get; } // 0x0000000185FB0980-0x0000000185FB0990 
		public virtual int updateOrder { get; } // 0x000000018B7B53BC-0x000000018B7B53D8 
		public bool customToggleValid { get; } // 0x000000018142A360-0x000000018142A370 
		public List<CutsceneTrack> tracks { get; set; } // 0x0000000185FD5CA0-0x0000000185FD5CB0 0x000000018B7B43C4-0x000000018B7B43D4
		public List<Section> sections { get; set; } // 0x000000018B7B4544-0x000000018B7B4838 0x000000018B7B3A18-0x000000018B7B3B68
		IEnumerable<IDirectable> IDirectable.children { get; } // 0x000000018B7B3B68-0x000000018B7B3C38 
		float IDirectable.startTime { get; } // 0x000000018B7B3880-0x000000018B7B394C 
		float IDirectable.endTime { get; } // 0x000000018B7B394C-0x000000018B7B3A18 
		float IDirectable.blendIn { get; } // 0x000000018B7B3FA4-0x000000018B7B4088 
		float IDirectable.blendOut { get; } // 0x000000018B7B3ED0-0x000000018B7B3F44 
		bool IDirectable.canCrossBlend { get; } // 0x000000018B7B40E8-0x000000018B7B4148 
		IDirectable IDirectable.parent { get; } // 0x000000018B7B4148-0x000000018B7B4280 
		public IDirector root { get; private set; } // 0x000000018B7B3F44-0x000000018B7B3FA4 0x000000018B7B4088-0x000000018B7B40E8
		public bool isActive { get; set; } // 0x0000000185492010-0x0000000185492020 0x0000000185492010-0x0000000185492020
		public bool isCollapsed { get; set; } // 0x0000000185492010-0x0000000185492020 0x0000000185492010-0x0000000185492020
		public bool isLocked { get; set; } // 0x000000018B7B42D8-0x000000018B7B43C4 0x000000018B7B3D48-0x000000018B7B3D98
		public bool isReadOnly { get; set; } // 0x000000018B7B43D4-0x000000018B7B4544 0x000000018B7B3C38-0x000000018B7B3CDC
	
		// Events
		public event Action<Section> OnSectionReached;
	
		// Nested types
		public enum ActorReferenceMode // TypeDefIndex: 55655
		{
			UseOriginal = 0,
			UseInstanceHideOriginal = 1
		}
	
		public enum ActorInitialTransformation // TypeDefIndex: 55656
		{
			UseOriginal = 0,
			UseLocal = 1
		}
	
		[Serializable]
		public class CustomToggleInfo // TypeDefIndex: 55657
		{
			// Fields
			public int startIndex; // 0x10
			public int endIndex; // 0x14
			public string desc; // 0x18
			public bool isCollapsed; // 0x20
			private int _index_k__BackingField; // 0x24
			private CutsceneGroup _group_k__BackingField; // 0x28
	
			// Properties
			public int index { get; set; } // 0x000000018B7B5228-0x000000018B7B52B4 0x000000018B7B5330-0x000000018B7B53BC
			public CutsceneGroup group { get; set; }
	
			// Constructors
			public CustomToggleInfo() {}
	
			// Methods
			private void _OnToggleChanged() {}
			public IEnumerable _GetAllTrackNames() => default;
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 55658
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<CustomToggleInfo, int> __9__48_0; // 0x08
			public static Func<CutsceneTrack, bool> __9__88_0; // 0x10
			public static Func<Section, float> __9__88_1; // 0x18
	
			// Constructors
			static __c() {}
			public __c() {}
	
			// Methods
			internal int __OnCustomToggleValueChanged_b__48_0(CustomToggleInfo t) => default;
			internal bool _Validate_b__88_0(CutsceneTrack t) => default;
			internal float _Validate_b__88_1(Section s) => default;
		}
	
		private sealed class __c__DisplayClass89_0 // TypeDefIndex: 55659
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass89_0() {}
	
			// Methods
			internal bool _GetSectionByName_b__0(Section s) => default;
		}
	
		private sealed class __c__DisplayClass90_0 // TypeDefIndex: 55660
		{
			// Fields
			public string UID; // 0x10
	
			// Constructors
			public __c__DisplayClass90_0() {}
	
			// Methods
			internal bool _GetSectionByUID_b__0(Section s) => default;
		}
	
		private sealed class __c__DisplayClass91_0 // TypeDefIndex: 55661
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass91_0() {} // 0x00000001840A27C0-0x00000001840A27D0
	
			// Methods
			internal bool _GetSectionAfter_b__0(Section s) => default; // 0x0000000185FBBF90-0x0000000185FBBFA0
		}
	
		private sealed class __c__DisplayClass92_0 // TypeDefIndex: 55662
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass92_0() {} // 0x000000018B7B3EC4-0x000000018B7B3ED0
	
			// Methods
			internal bool _GetSectionBefore_b__0(Section s) => default; // 0x000000018B7B52B4-0x000000018B7B5320
		}
	
		// Constructors
		protected CutsceneGroup() {} // 0x0000000185492010-0x0000000185492020
		static CutsceneGroup() {} // 0x000000018B7C10F8-0x000000018B7C1118
	
		// Methods
		public void SetCustomToggleDirty() {} // 0x00000001814294C0-0x00000001814294D0
		private void _OnCustomToggleValueChanged() {} // 0x000000018B7B5320-0x000000018B7B5330
		public bool CheckCustomCollapsed(int index) => default; // 0x0000000185FB0C50-0x0000000185FB0C60
		private void _TryRefreshCustomToggleInfo() {} // 0x0000000185FD5C90-0x0000000185FD5CA0
		public override string ToString() => default; // 0x000000018B7B3D98-0x000000018B7B3EC4
		public void Validate(IDirector root, IDirectable parent) {} // 0x000000018B7B3CDC-0x000000018B7B3D48
		public Section GetSectionByName(string name) => default; // 0x000000018B7B5078-0x000000018B7B5228
		public Section GetSectionByUID(string UID) => default; // 0x000000018B7B503C-0x000000018B7B5078
		public Section GetSectionAfter(float time) => default; // 0x0000000181424480-0x0000000181424490
		public Section GetSectionBefore(float time) => default; // 0x0000000181424940-0x0000000181424950
		bool IDirectable.Initialize() => default; // 0x00000001813B8590-0x00000001813B85A0
		void IDirectable.Enter() {} // 0x0000000184A4EDC0-0x0000000184A4EDD0
		void IDirectable.Reverse() {} // 0x000000018B7B36D8-0x000000018B7B36F0
		void IDirectable.Update(float time, float previousTime) {} // 0x000000018B7B3588-0x000000018B7B36D8
		void IDirectable.Exit() {} // 0x0000000185FC9DC0-0x0000000185FC9DD0
		void IDirectable.ReverseEnter() {} // 0x000000018B7C1244-0x000000018B7C12A8
		void IDirectable.RootEnabled() {} // 0x0000000185492010-0x0000000185492020
		void IDirectable.RootDisabled() {} // 0x000000018B584038-0x000000018B584050
		void IDirectable.RootUpdated(float time, float previousTime) {} // 0x000000018B7C0B90-0x000000018B7C0BDC
		void IDirectable.RootDestroyed() {} // 0x000000018B7C0BDC-0x000000018B7C0BF8
		private void StoreActorState() {} // 0x0000000185492010-0x0000000185492020
		private void RestoreActorState() {} // 0x000000018B7C0FE4-0x000000018B7C1038
		private void TryInstantiateLocalActor() {} // 0x0000000185492010-0x0000000185492020
		private void ReleaseLocalActorInstance() {} // 0x0000000187C26954-0x0000000187C2697C
		private void SetActorLocalCoords() {} // 0x0000000185492010-0x0000000185492020
		protected GameObject ResolveActor(GameObject original) => default; // 0x000000018B7C10D8-0x000000018B7C10F8
	}

	public abstract class CutsceneTrack : MonoBehaviour, IDirectable // TypeDefIndex: 55666
	{
		// Fields
		private string _name; // 0x18
		private UnityEngine.Color _color; // 0x20
		private bool _active; // 0x30
		private bool _isLocked; // 0x31
		private List<ActionClip> _actionClips; // 0x38
		private bool _isReadOnly; // 0x40
		private int _layerOrder_k__BackingField; // 0x44
		private IDirectable _parent_k__BackingField; // 0x48
	
		// Properties
		public GameObject actor { get; } // 0x0000000185A16440-0x0000000185A16450 
		public new string name { get; set; } // 0x000000018B7B5F9C-0x000000018B7B5FD4 0x000000018B7B5B70-0x000000018B7B5BAC
		public UnityEngine.Color color { get; } // 0x0000000183908D10-0x0000000183908D20 
		public List<ActionClip> clips { get; set; } // 0x0000000183909010-0x0000000183909020 0x000000018B7B60E8-0x000000018B7B6108
		public virtual string info { get; } // 0x00000001813ECF20-0x00000001813ECF30 
		IEnumerable<IDirectable> IDirectable.children { get; } // 0x000000018571FEC0-0x000000018571FED0 
		public int layerOrder { get; private set; } // 0x000000018B7B6000-0x000000018B7B6020 0x000000018B7B5FD4-0x000000018B7B6000
		public IDirector root { get; } // 0x000000018B7B6128-0x000000018B7B6168 
		public IDirectable parent { get; private set; } // 0x000000018B7B6020-0x000000018B7B6054 0x0000000185FB0990-0x0000000185FB09A0
		public virtual bool isCollapsed { get; } // 0x000000018B7B6108-0x000000018B7B6128 
		public virtual bool isActive { get; set; } // 0x0000000185492010-0x0000000185492020 0x000000018B7B5F7C-0x000000018B7B5F9C
		public virtual bool isLocked { get; set; } // 0x0000000185492010-0x0000000185492020 0x0000000183908D00-0x0000000183908D10
		public virtual float startTime { get; set; } // 0x0000000185492010-0x0000000185492020 0x0000000183908D00-0x0000000183908D10
		public virtual float endTime { get; set; } // 0x0000000185492010-0x0000000185492020 0x00000001814A81B0-0x00000001814A81C0
		public virtual float blendIn { get; set; } // 0x000000018B7B60C8-0x000000018B7B60E8 0x0000000185FBBF90-0x0000000185FBBFA0
		public virtual float blendOut { get; set; } // 0x000000018B7B6054-0x000000018B7B6084 0x0000000185FB0660-0x0000000185FB0670
		public bool canCrossBlend { get; } // 0x000000018B7B5B2C-0x000000018B7B5B3C 
		public virtual bool needActor { get; } // 0x000000018B7B5B0C-0x000000018B7B5B1C 
		public virtual int updateOrder { get; } // 0x000000018B7B5B5C-0x000000018B7B5B70 
		public bool isReadOnly { get; set; } // 0x000000018B7B5B1C-0x000000018B7B5B2C 0x000000018B7B5B3C-0x000000018B7B5B4C
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 55664
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ActionClip, float> __9__70_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018B7B5F24-0x000000018B7B5F44
			public __c() {} // 0x000000018B7B6084-0x000000018B7B60C8
	
			// Methods
			internal float _Validate_b__70_0(ActionClip a) => default; // 0x000000018B7B6168-0x000000018B7B61B0
		}
	
		private sealed class __c__DisplayClass90_0 // TypeDefIndex: 55665
		{
			// Fields
			public ActionClip newAction; // 0x10
	
			// Constructors
			public __c__DisplayClass90_0() {} // 0x000000018B7B5F44-0x000000018B7B5F7C
	
			// Methods
			internal bool _AddAction_b__0(ActionClip a) => default; // 0x00000001813ECBC0-0x00000001813ECBD0
		}
	
		// Constructors
		protected CutsceneTrack() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		bool IDirectable.Initialize() => default; // 0x000000018B7B5B4C-0x000000018B7B5B5C
		void IDirectable.Enter() {} // 0x0000000185492010-0x0000000185492020
		void IDirectable.Update(float time, float previousTime) {} // 0x0000000185492010-0x0000000185492020
		void IDirectable.Exit() {} // 0x0000000185492010-0x0000000185492020
		void IDirectable.ReverseEnter() {} // 0x0000000185492010-0x0000000185492020
		void IDirectable.Reverse() {} // 0x000000018B7B5AE4-0x000000018B7B5B0C
		void IDirectable.RootEnabled() {} // 0x000000018B7B5C30-0x000000018B7B5E8C
		void IDirectable.RootDisabled() {} // 0x0000000185492010-0x0000000185492020
		void IDirectable.RootUpdated(float time, float previousTime) {} // 0x0000000185492010-0x0000000185492020
		void IDirectable.RootDestroyed() {} // 0x00000001840A27C0-0x00000001840A27D0
		public void PostCreate(IDirectable parent) {} // 0x0000000185492010-0x0000000185492020
		public void Validate(IDirector root, IDirectable parent) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnCreate() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnAfterValidate() {} // 0x0000000185492010-0x0000000185492020
		protected virtual bool OnInitialize() => default; // 0x0000000185492010-0x0000000185492020
		protected virtual void OnEnter() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnUpdate(float time, float previousTime) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnExit() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnReverseEnter() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnReverse() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnDrawGizmosSelected() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnSceneGUI() {} // 0x000000018B7B5A4C-0x000000018B7B5AE4
		protected virtual void OnRootEnabled() {} // 0x000000018B7B59F0-0x000000018B7B5A4C
		protected virtual void OnRootDisabled() {} // 0x000000018B796FD4-0x000000018B796FF0
		protected virtual void OnRootUpdated(float time, float previousTime) {} // 0x000000018B796FF0-0x000000018B797000
		protected virtual void OnRootDestroyed() {}
		public float GetTrackWeight() => default; // 0x000000018B7B5710-0x000000018B7B59F0
		public float GetTrackWeight(float time) => default; // 0x000000018B7B5E8C-0x000000018B7B5F24
		public float GetTrackWeight(float time, float blendInOut) => default; // 0x000000018B7B5BAC-0x000000018B7B5C30
		public float GetTrackWeight(float time, float blendIn, float blendOut) => default; // 0x000000018B7C11E0-0x000000018B7C1244
		public T AddAction<T>(float time)
			where T : ActionClip => default; // 0x0000000185492010-0x0000000185492020
		public ActionClip AddAction(System.Type type, float time) => default; // 0x000000018B7C0B74-0x000000018B7C0B90
		private bool _Validate_b__70_1(IDirectable t) => default; // 0x000000018B7C10AC-0x000000018B7C10D8
	}

	public interface IAnimatableData // TypeDefIndex: 55667
	{
		// Properties
		bool isValid { get; }
	
		// Methods
		AnimationCurve[] GetCurves();
		void Validate(IKeyable keyable);
		void SetVirtualTransformParent(Transform virtualTransformParent);
		void SetSnapshot();
		void Evaluate(float time, float previousTime, float weight);
		void RestoreSnapshot();
		void SetKeyCurrent(float time);
		bool TryAutoKey(float time);
		bool TryKeyIdentity(float time);
		void RemoveKey(float time);
		bool HasKey(float time);
		bool HasAnyKey();
		bool HasChanged();
		float GetKeyNext(float time);
		float GetKeyPrevious(float time);
		string GetKeyLabel(float time);
		void SetPreWrapMode(UnityEngine.WrapMode mode);
		void SetPostWrapMode(UnityEngine.WrapMode mode);
		void Reset();
	}

	public interface IDirectable // TypeDefIndex: 55668
	{
		// Properties
		IDirector root { get; }
		IDirectable parent { get; }
		IEnumerable<IDirectable> children { get; }
		GameObject actor { get; }
		string name { get; }
		bool isActive { get; }
		bool isCollapsed { get; }
		bool isLocked { get; }
		float startTime { get; }
		float endTime { get; }
		float blendIn { get; }
		float blendOut { get; }
		bool canCrossBlend { get; }
		bool needActor { get; }
		int updateOrder { get; }
		bool isReadOnly { get; }
	
		// Methods
		void Validate(IDirector root, IDirectable parent);
		bool Initialize();
		void Enter();
		void Exit();
		void Update(float time, float previousTime);
		void ReverseEnter();
		void Reverse();
		void RootEnabled();
		void RootUpdated(float time, float previousTime);
		void RootDisabled();
		void RootDestroyed();
	}

	public interface IKeyable : IDirectable // TypeDefIndex: 55669
	{
		// Properties
		AnimationDataCollection animationData { get; }
		object animatedParametersTarget { get; }
	}

	public interface ISubClipContainable : IDirectable // TypeDefIndex: 55670
	{
		// Properties
		float subClipOffset { get; set; }
		float subClipSpeed { get; }
		float subClipLength { get; }
	}

	public static class IDirectableExtensions // TypeDefIndex: 55674
	{
		// Nested types
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 55671
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass12_0() {} // 0x000000018B7B872C-0x000000018B7B8768
	
			// Methods
			internal bool _FindChild_b__0(IDirectable d) => default; // 0x000000018B7B8F80-0x000000018B7B8FBC
		}
	
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 55672
		{
			// Fields
			public IDirectable directable; // 0x10
	
			// Constructors
			public __c__DisplayClass14_0() {} // 0x000000018B7B8F44-0x000000018B7B8F80
	
			// Methods
			internal bool _GetPreviousSibling_b__0(IDirectable d) => default; // 0x000000018B7B8EBC-0x000000018B7B8EF8
		}
	
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 55673
		{
			// Fields
			public IDirectable directable; // 0x10
	
			// Constructors
			public __c__DisplayClass16_0() {} // 0x000000018B7B8FEC-0x000000018B7B904C
	
			// Methods
			internal bool _GetNextSibling_b__0(IDirectable d) => default; // 0x000000018B7B8FBC-0x000000018B7B8FEC
		}
	
		// Methods
		public static float GetLength(IDirectable directable) => default; // 0x000000018B7B8EF8-0x000000018B7B8F44
		public static float RootTimeToLocalTime(IDirectable directable) => default; // 0x000000018B7B8444-0x000000018B7B84D0
		public static float RootTimeToLocalTimeUnclamped(IDirectable directable) => default; // 0x000000018B7B8254-0x000000018B7B834C
		public static bool IsRootTimeWithinClip(IDirectable directable) => default; // 0x000000018B7B834C-0x000000018B7B8444
		public static float ToLocalTime(IDirectable directable, float time) => default; // 0x000000018B7B84D0-0x000000018B7B85B8
		public static float ToLocalTimeUnclamped(IDirectable directable, float time) => default; // 0x000000018B7B9230-0x000000018B7B92C0
		public static bool IsTimeWithinClip(IDirectable directable, float time) => default; // 0x000000018B7B85B8-0x000000018B7B86A0
		public static bool CanCrossBlend(IDirectable directable, IDirectable other) => default;
		public static bool CanBlendIn(IDirectable directable) => default; // 0x000000018B7B8994-0x000000018B7B8A90
		public static bool CanBlendOut(IDirectable directable) => default;
		public static bool CanScale(IDirectable directable) => default; // 0x000000018B7B8808-0x000000018B7B8904
		public static bool WithinBufferTriggerRange(IDirectable directable, float time, float previousTime, bool bypass = false /* Metadata: 0x0207BF67 */) => default;
		public static IDirectable FindChild(IDirectable directable, string name) => default; // 0x000000018B7B8CC0-0x000000018B7B8CE4
		public static T GetPreviousSibling<T>(IDirectable directable)
			where T : IDirectable => default; // 0x000000018B7B8BD4-0x000000018B7B8C2C
		public static IDirectable GetPreviousSibling(IDirectable directable) => default; // 0x000000018B796FD4-0x000000018B796FF0
		public static T GetNextSibling<T>(IDirectable directable)
			where T : IDirectable => default; // 0x000000018B7B8C2C-0x000000018B7B8CC0
		public static IDirectable GetNextSibling(IDirectable directable) => default; // 0x000000018B7B8A90-0x000000018B7B8BD4
		public static T GetFirstParentOfType<T>(IDirectable directable)
			where T : IDirectable => default; // 0x000000018B7B904C-0x000000018B7B9118
		public static float GetWeight(IDirectable directable) => default; // 0x000000018B7B8CE4-0x000000018B7B8DB0
		public static float GetWeight(IDirectable directable, float time) => default; // 0x000000018B7B9118-0x000000018B7B9230
		public static float GetWeight(IDirectable directable, float time, float blendInOut) => default; // 0x000000018B7B8DB0-0x000000018B7B8EBC
		public static float GetWeight(IDirectable directable, float time, float blendIn, float blendOut) => default; // 0x000000018B7B8120-0x000000018B7B8254
		public static Transform GetSpaceTransform(IDirectable directable, TransformSpace space, GameObject actorOverride = null) => default; // 0x000000018B7B8904-0x000000018B7B8994
		public static Vector3 TransformPosition(IDirectable directable, Vector3 point, TransformSpace space) => default; // 0x000000018B7B8768-0x000000018B7B8808
		public static Vector3 InverseTransformPosition(IDirectable directable, Vector3 point, TransformSpace space) => default; // 0x000000018B7B86A0-0x000000018B7B872C
		public static Quaternion TransformRotation(IDirectable directable, Vector3 euler, TransformSpace space) => default; // 0x0000000185492010-0x0000000185492020
		public static Vector3 InverseTransformRotation(IDirectable directable, Quaternion rot, TransformSpace space) => default; // 0x000000018B7C0D18-0x000000018B7C0D74
		public static Vector3 ActorPositionInSpace(IDirectable directable, TransformSpace space) => default; // 0x0000000185492010-0x0000000185492020
		public static float GetPreviousLoopLocalTime(ISubClipContainable clip) => default; // 0x000000018B7C0D74-0x000000018B7C0DC4
		public static float GetNextLoopLocalTime(ISubClipContainable clip) => default; // 0x0000000185492010-0x0000000185492020
		public static AnimationCurve[] GetCurvesAll(IKeyable keyable) => default; // 0x000000018B7C0DC4-0x000000018B7C0E14
	}

	public interface IDirector // TypeDefIndex: 55675
	{
		// Properties
		IEnumerable<IDirectable> children { get; }
		GameObject context { get; }
		float length { get; }
		float currentTime { get; set; }
		float previousTime { get; }
		float playbackSpeed { get; set; }
		bool isActive { get; }
		bool isPaused { get; }
		bool isReSampleFrame { get; }
	
		// Methods
		IEnumerable<GameObject> GetAffectedActors();
		void Play();
		void Pause();
		void Stop();
		void Sample(float time);
		void ReSample();
		void Validate();
		void SendGlobalMessage(string message, object value);
	}

	[Serializable]
	public class Section // TypeDefIndex: 55677
	{
		// Fields
		public static readonly UnityEngine.Color DEFAULT_COLOR; // 0x00
		private string _UID; // 0x10
		private string _name; // 0x18
		private float _time; // 0x20
		private ExitMode _exitMode; // 0x24
		private int _loopCount; // 0x28
		private UnityEngine.Color _color; // 0x2C
		private bool _colorizeBackground; // 0x3C
		private int _currentLoopIteration_k__BackingField; // 0x40
	
		// Properties
		public int currentLoopIteration { get; private set; } // 0x00000001813ECF10-0x00000001813ECF20 0x00000001813EE9C0-0x00000001813EE9D0
		public string UID { get => default; private set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public string name { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public float time { get => default; set {} } // 0x0000000181C9AC70-0x0000000181C9AC80 0x0000000181C9A5B0-0x0000000181C9A5C0
		public ExitMode exitMode { get => default; set {} } // 0x0000000181424480-0x0000000181424490 0x0000000181424940-0x0000000181424950
		public int loopCount { get => default; set {} } // 0x0000000181C9AC80-0x0000000181C9AC90 0x0000000181C9A5C0-0x0000000181C9A5D0
		public UnityEngine.Color color { get => default; set {} } // 0x000000018B7BE3AC-0x000000018B7BE41C 0x0000000185FB8CB0-0x0000000185FB8CC0
		public bool colorizeBackground { get => default; set {} } // 0x0000000185FB0A40-0x0000000185FB0A50 0x0000000183AC91F0-0x0000000183AC9200
	
		// Nested types
		public enum ExitMode // TypeDefIndex: 55676
		{
			Continue = 0,
			Loop = 1
		}
	
		// Constructors
		public Section() {} // Dummy constructor
		public Section(string name, float time) {} // 0x000000018B7BE2FC-0x000000018B7BE3AC
		static Section() {} // 0x000000018B7BE290-0x000000018B7BE2FC
	
		// Methods
		public void ResetLoops() {} // 0x0000000185FD5D10-0x0000000185FD5D20
		public void BreakLoop() {} // 0x0000000185FD5D00-0x0000000185FD5D10
		public bool TryUpdateLoop() => default; // 0x000000018B7BE270-0x000000018B7BE290
		public override string ToString() => default; // 0x000000018B7BE1FC-0x000000018B7BE270
	}

	public interface IDirectableTimePointer // TypeDefIndex: 55678
	{
		// Properties
		IDirectable target { get; }
		float time { get; }
	
		// Methods
		void TriggerForward(float currentTime, float previousTime);
		void TriggerBackward(float currentTime, float previousTime);
		void Update(float currentTime, float previousTime);
	}

	public struct StartTimePointer : IDirectableTimePointer // TypeDefIndex: 55679
	{
		// Fields
		private bool triggered; // 0x00
		private float lastTargetStartTime; // 0x04
		private IDirectable _target_k__BackingField; // 0x08
	
		// Properties
		public IDirectable target { get; private set; } // 0x000000018357A260-0x000000018357A270 0x00000001877900A4-0x00000001877900B4
		float IDirectableTimePointer.time { get => default; } // 0x000000018B7BF6C4-0x000000018B7BF6E0 
	
		// Constructors
		public StartTimePointer(IDirectable target) : this() {
			triggered = default;
			lastTargetStartTime = default;
			<target>k__BackingField = default;
		} // 0x000000018B7BF6E0-0x000000018B7BF71C
	
		// Methods
		void IDirectableTimePointer.TriggerForward(float currentTime, float previousTime) {} // 0x000000018B7BF4F8-0x000000018B7BF574
		void IDirectableTimePointer.Update(float currentTime, float previousTime) {} // 0x000000018B7BF574-0x000000018B7BF6C4
		void IDirectableTimePointer.TriggerBackward(float currentTime, float previousTime) {} // 0x000000018B7BF45C-0x000000018B7BF4F8
	}

	public struct EndTimePointer : IDirectableTimePointer // TypeDefIndex: 55680
	{
		// Fields
		private bool triggered; // 0x00
		private IDirectable _target_k__BackingField; // 0x08
	
		// Properties
		public IDirectable target { get; private set; } // 0x000000018357A260-0x000000018357A270 0x00000001877900A4-0x00000001877900B4
		float IDirectableTimePointer.time { get => default; } // 0x000000018B7B7AB0-0x000000018B7B7ACC 
	
		// Constructors
		public EndTimePointer(IDirectable target) : this() {
			triggered = default;
			<target>k__BackingField = default;
		} // 0x000000018B7B7ACC-0x000000018B7B7AEC
	
		// Methods
		void IDirectableTimePointer.TriggerForward(float currentTime, float previousTime) {} // 0x000000018B7B79D0-0x000000018B7B7A64
		void IDirectableTimePointer.Update(float currentTime, float previousTime) {} // 0x000000018B7B7A64-0x000000018B7B7AB0
		void IDirectableTimePointer.TriggerBackward(float currentTime, float previousTime) {} // 0x000000018B7B7948-0x000000018B7B79D0
	}

	public class BezierPath : Path // TypeDefIndex: 55681
	{
		// Fields
		public int resolution; // 0x18
		private List<Slate.BezierPoint> _points; // 0x20
		private Vector3[] _sampledPathPoints; // 0x28
		private float _length; // 0x30
	
		// Properties
		public List<Slate.BezierPoint> points { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
		public Slate.BezierPoint this[int index] { get => default; } // 0x000000018B7B1B28-0x000000018B7B1B7C 
		public int pointCount { get => default; } // 0x000000018B7B1B7C-0x000000018B7B1BBC 
		public override float length { get => default; } // 0x0000000185FB0BE0-0x0000000185FB0BF0 
	
		// Constructors
		public BezierPath() {} // 0x000000018B7B1AA0-0x000000018B7B1B28
	
		// Methods
		private void Awake() {} // 0x00000001839CCD40-0x00000001839CCD50
		private void OnValidate() {} // 0x00000001839CCD40-0x00000001839CCD50
		public override void Compute() {} // 0x000000018B7B13E8-0x000000018B7B1410
		public void SetDirty() {} // 0x00000001839CCD40-0x00000001839CCD50
		private void ComputeLength() {} // 0x000000018B7B125C-0x000000018B7B127C
		private void ComputeSampledPathPoints() {} // 0x000000018B7B127C-0x000000018B7B13E8
		public static BezierPath Create(Transform targetParent = null) => default; // 0x000000018B7B1410-0x000000018B7B16D8
		public Slate.BezierPoint AddPointAt(Vector3 position, int index = -1 /* Metadata: 0x0207BF6A */) => default; // 0x000000018B7B1174-0x000000018B7B125C
		public void RemovePoint(Slate.BezierPoint point) {} // 0x000000018B7B1A40-0x000000018B7B1AA0
		public int GetPointIndex(Slate.BezierPoint point) => default; // 0x000000018B7B16D8-0x000000018B7B175C
		public static Vector3[] GetSampledPathPositions(Slate.BezierPoint p1, Slate.BezierPoint p2, int resolution) => default; // 0x000000018B7B1934-0x000000018B7B1A40
		public override Vector3 GetPositionAt(float t) => default; // 0x000000018B7B1864-0x000000018B7B1934
		public static Vector3 GetPositionAt(Slate.BezierPoint p1, Slate.BezierPoint p2, float t) => default; // 0x000000018B7B175C-0x000000018B7B1864
	}

	[Serializable]
	public class BezierPoint // TypeDefIndex: 55683
	{
		// Fields
		private BezierPath _path; // 0x10
		public Vector3 _position; // 0x18
		private Vector3 _handle1; // 0x24
		private Vector3 _handle2; // 0x30
		private HandleStyle _handleStyle; // 0x3C
	
		// Properties
		public HandleStyle handleStyle { get => default; set {} } // 0x0000000185FB0790-0x0000000185FB07A0 0x0000000185FB07A0-0x0000000185FB07B0
		public BezierPath path { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public Vector3 position { get => default; set {} } // 0x000000018B7B1D54-0x000000018B7B1DC4 0x000000018B7B20AC-0x000000018B7B2118
		public Vector3 handle1LocalPosition { get => default; private set {} } // 0x0000000185FB8980-0x0000000185FB89A0 0x000000018B7B1DC4-0x000000018B7B1E7C
		public Vector3 handle2LocalPosition { get => default; private set {} } // 0x0000000185FB2EF0-0x0000000185FB2F10 0x000000018B7B1F38-0x000000018B7B1FF0
		public Vector3 handle1Position { get => default; set {} } // 0x000000018B7B1BFC-0x000000018B7B1CA8 0x000000018B7B1E7C-0x000000018B7B1F38
		public Vector3 handle2Position { get => default; set {} } // 0x000000018B7B1CA8-0x000000018B7B1D54 0x000000018B7B1FF0-0x000000018B7B20AC
	
		// Nested types
		public enum HandleStyle // TypeDefIndex: 55682
		{
			Connected = 0,
			Broken = 1
		}
	
		// Constructors
		public BezierPoint() {} // Dummy constructor
		public BezierPoint(BezierPath path, Vector3 position) {} // 0x000000018B7B1BBC-0x000000018B7B1BFC
	}

	public abstract class Path : MonoBehaviour // TypeDefIndex: 55684
	{
		// Properties
		public abstract float length { get; }
	
		// Constructors
		protected Path() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public abstract Vector3 GetPositionAt(float t);
		public abstract void Compute();
		public static Vector3 GetPositionAlongCurve(Vector3 from, Vector3 to, Vector3 fromTangent, Vector3 toTangent, float t) => default; // 0x000000018B7B9D00-0x000000018B7B9EF8
		public static Vector3 GetPosition(float t, Vector3[] path) => default; // 0x000000018B7B9EF8-0x000000018B7BA0FC
		public static float GetLength(Vector3[] path) => default; // 0x000000018B7B9C54-0x000000018B7B9D00
	}

	public static class AnimationDataUtility // TypeDefIndex: 55685
	{
		// Methods
		public static string[] GetAnimatableMemberPaths(object root) => default; // 0x000000018B7B0294-0x000000018B7B02F0
		private static string[] Internal_GetAnimatableMemberPaths(System.Type type, string path) => default; // 0x000000018B7B02F0-0x000000018B7B0668
	}

	public class AnimatorDispatcher : MonoBehaviour // TypeDefIndex: 55686
	{
		// Fields
		private Action<int> onAnimatorIK; // 0x18
		private Animator _animator; // 0x20
	
		// Properties
		private Animator animator { get => default; } // 0x000000018B7B0708-0x000000018B7B0794 
	
		// Events
		public event Action<int> onAnimatorIK;
	
		// Constructors
		public AnimatorDispatcher() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void OnAnimatorIK(int index) {} // 0x000000018B7B0668-0x000000018B7B067C
	}

	public static class AudioSampler // TypeDefIndex: 55688
	{
		// Fields
		private const string ROOT_NAME = "_AudioSources"; // Metadata: 0x0207BF6D
		private static GameObject root; // 0x00
		private static Dictionary<object, AudioSource> sources; // 0x08
	
		// Nested types
		[Serializable]
		public struct SampleSettings // TypeDefIndex: 55687
		{
			// Fields
			public float volume; // 0x00
			public float pitch; // 0x04
			public float pan; // 0x08
			public float spatialBlend; // 0x0C
			public bool ignoreTimescale; // 0x10
			public bool bypassReverb; // 0x11
	
			// Methods
			public static SampleSettings Default() => default; // 0x000000018B7B0820-0x000000018B7B0AFC
		}
	
		// Constructors
		static AudioSampler() {} // 0x0000000185FD5CB0-0x0000000185FD5CD0
	
		// Methods
		public static AudioSource GetSourceForID(object keyID) => default; // 0x000000018B7B0AFC-0x000000018B7B0C88
		public static void ReleaseSourceForID(object keyID) {} // 0x000000018B7B0C88-0x000000018B7B0D4C
		public static void SampleForID(object keyID, AudioClip clip, float time, float previousTime, float volume) {} // 0x000000018B7B0D4C-0x000000018B7B0DF0
		public static void SampleForID(object keyID, AudioClip clip, float time, float previousTime, SampleSettings settings) {} // 0x000000018B7B0DF0-0x000000018B7B0EB4
		public static void Sample(AudioSource source, AudioClip clip, float time, float previousTime, float volume) {} // 0x000000018B7B0EB4-0x000000018B7B10E0
		public static void Sample(AudioSource source, AudioClip clip, float time, float previousTime, SampleSettings settings) {} // 0x000000018B7B10E0-0x000000018B7B1174
	}

	public static class ColorUtility // TypeDefIndex: 55689
	{
		// Methods
		public static UnityEngine.Color Grey(float value) => default; // 0x0000000185FD2BE0-0x0000000185FD2C00
		public static UnityEngine.Color WithAlpha(UnityEngine.Color color, float alpha) => default; // 0x0000000185FD2C00-0x0000000185FD2C20
	}

	public enum TangentMode // TypeDefIndex: 55690
	{
		Editable = 0,
		Smooth = 1,
		Linear = 2,
		Constant = 3
	}

	public static class CurveUtility // TypeDefIndex: 55695
	{
		// Fields
		private const float KEY_PROXIMITY_TOLERANCE = 0.001f; // Metadata: 0x0207BF7F
	
		// Nested types
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 55691
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass1_0() {} // 0x000000018B7B2C58-0x000000018B7B2EA4
	
			// Methods
			internal bool _GetKeyNext_b__1(Keyframe k) => default; // 0x000000018B7B2EA4-0x000000018B7B310C
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 55692
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Keyframe, float> __9__1_0; // 0x08
			public static Func<Keyframe, float> __9__2_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018B7B3160-0x000000018B7B32A4
			public __c() {} // 0x000000018B7B310C-0x000000018B7B3160
	
			// Methods
			internal float _GetKeyNext_b__1_0(Keyframe k) => default; // 0x000000018B7B3394-0x000000018B7B3434
			internal float _GetKeyPrevious_b__2_0(Keyframe k) => default; // 0x000000018B7B32A4-0x000000018B7B3394
		}
	
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 55693
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0() {} // 0x000000018B7B3574-0x000000018B7B3588
	
			// Methods
			internal bool _GetKeyPrevious_b__1(Keyframe k) => default; // 0x000000018B7B3434-0x000000018B7B3574
		}
	
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 55694
		{
			// Fields
			public float time; // 0x10
			public Func<Keyframe, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal bool _HasKey_b__0(Keyframe k) => default; // 0x000000018B7C0F8C-0x000000018B7C0FA8
		}
	
		// Methods
		public static float GetKeyNext(float time, AnimationCurve[] curves) => default; // 0x000000018B7C1118-0x000000018B7C117C
		public static float GetKeyPrevious(float time, AnimationCurve[] curves) => default; // 0x0000000185492010-0x0000000185492020
		public static bool HasKey(float time, AnimationCurve[] curves) => default; // 0x0000000185FD5D20-0x0000000185FD5D30
		public static bool HasAnyKey(AnimationCurve[] curves) => default; // 0x0000000185FD5D20-0x0000000185FD5D30
		public static void OffsetCurveValue(AnimationCurve curve, float deltaValue) {} // 0x0000000185492010-0x0000000185492020
		public static void OffsetCurveTime(AnimationCurve curve, float deltaTime) {} // 0x000000018B7C0FA8-0x000000018B7C0FC0
		public static void RemoveNegativeKeys(AnimationCurve curve) {} // 0x0000000185492010-0x0000000185492020
		public static void RemoveKeysOffRange(AnimationCurve curve, float min, float max) {} // 0x000000018B7C0FC0-0x000000018B7C0FE4
	}

	public class DecoratorAttribute : Attribute // TypeDefIndex: 55696
	{
		// Fields
		public readonly System.Type targetType; // 0x10
	
		// Constructors
		public DecoratorAttribute() {} // Dummy constructor
		public DecoratorAttribute(System.Type targetType) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public interface IDecorator // TypeDefIndex: 55697
	{
		// Properties
		object Target { get; set; }
	}

	public static class DecoratorFactory // TypeDefIndex: 55698
	{
		// Fields
		private static Dictionary<System.Type, System.Type> decoratorsTypeMap; // 0x00
		private static Dictionary<object, IDecorator> decoratorsInstanceMap; // 0x08
	
		// Constructors
		static DecoratorFactory() {} // 0x000000018B7B61B0-0x000000018B7B62A4
	
		// Methods
		public static T Decorator<T>(object target)
			where T : IDecorator => default;
		public static T GetDecorator<T>(object target)
			where T : IDecorator => default;
		private static T CreateDecorator<T>(System.Type targetType)
			where T : IDecorator => default;
	}

	public enum EaseType // TypeDefIndex: 55699
	{
		Linear = 0,
		QuadraticIn = 1,
		QuadraticOut = 2,
		QuadraticInOut = 3,
		QuarticIn = 4,
		QuarticOut = 5,
		QuarticInOut = 6,
		QuinticIn = 7,
		QuinticOut = 8,
		QuinticInOut = 9,
		CubicIn = 10,
		CubicOut = 11,
		CubicInOut = 12,
		ExponentialIn = 13,
		ExponentialOut = 14,
		ExponentialInOut = 15,
		CircularIn = 16,
		CircularOut = 17,
		CircularInOut = 18,
		SinusoidalIn = 19,
		SinusoidalOut = 20,
		SinusoidalInOut = 21,
		ElasticIn = 22,
		ElasticOut = 23,
		ElasticInOut = 24,
		BounceIn = 25,
		BounceOut = 26,
		BounceInOut = 27,
		BackIn = 28,
		BackOut = 29,
		BackInOut = 30
	}

	public static class Easing // TypeDefIndex: 55700
	{
		// Methods
		public static float Ease(Slate.EaseType type, float from, float to, float t) => default; // 0x000000018B7B6F30-0x000000018B7B6FB4
		public static Vector3 Ease(Slate.EaseType type, Vector3 from, Vector3 to, float t) => default; // 0x000000018B7B7134-0x000000018B7B7218
		public static Quaternion Ease(Slate.EaseType type, Quaternion from, Quaternion to, float t) => default; // 0x000000018B7B6FB4-0x000000018B7B7078
		public static UnityEngine.Color Ease(Slate.EaseType type, UnityEngine.Color from, UnityEngine.Color to, float t) => default; // 0x000000018B7B7078-0x000000018B7B7134
		public static Func<float, float> Function(Slate.EaseType type) => default; // 0x000000018B7B7218-0x000000018B7B7948
		public static float Linear(float t) => default; // 0x0000000185492010-0x0000000185492020
		public static float QuadraticIn(float t) => default; // 0x0000000185FB2920-0x0000000185FB2930
		public static float QuadraticOut(float t) => default; // 0x0000000185FD2E20-0x0000000185FD2E40
		public static float QuadraticInOut(float t) => default; // 0x000000018B4E14BC-0x000000018B4E1518
		public static float QuarticIn(float t) => default; // 0x0000000185FD2E40-0x0000000185FD2E50
		public static float QuarticOut(float t) => default; // 0x0000000185FD2E50-0x0000000185FD2E80
		public static float QuarticInOut(float t) => default; // 0x000000018B4E1518-0x000000018B4E156C
		public static float QuinticIn(float t) => default; // 0x0000000185FD2E80-0x0000000185FD2EA0
		public static float QuinticOut(float t) => default; // 0x0000000185FD2EA0-0x0000000185FD2ED0
		public static float QuinticInOut(float t) => default; // 0x000000018B4E156C-0x000000018B4E15C8
		public static float CubicIn(float t) => default; // 0x0000000185FB38F0-0x0000000185FB3900
		public static float CubicOut(float t) => default; // 0x0000000185FD2D10-0x0000000185FD2D30
		public static float CubicInOut(float t) => default; // 0x000000018B4E086C-0x000000018B4E08D4
		public static float SinusoidalIn(float t) => default; // 0x000000018B4E15C8-0x000000018B4E15F8
		public static float SinusoidalOut(float t) => default; // 0x000000018B4E15F8-0x000000018B4E1610
		public static float SinusoidalInOut(float t) => default; // 0x0000000185FD2ED0-0x0000000185FD2F00
		public static float ExponentialIn(float t) => default; // 0x000000018B4E0D1C-0x000000018B4E0D48
		public static float ExponentialOut(float t) => default; // 0x000000018B4E0D48-0x000000018B4E0D8C
		public static float ExponentialInOut(float t) => default; // 0x000000018B4E0C9C-0x000000018B4E0D1C
		public static float CircularIn(float t) => default; // 0x0000000185FD2C80-0x0000000185FD2CE0
		public static float CircularOut(float t) => default; // 0x0000000185FD2CE0-0x0000000185FD2D10
		public static float CircularInOut(float t) => default; // 0x000000018B4E0808-0x000000018B4E086C
		public static float ElasticIn(float t) => default; // 0x0000000185FD2D30-0x0000000185FD2DB0
		public static float ElasticOut(float t) => default; // 0x0000000185FD2DB0-0x0000000185FD2E20
		public static float ElasticInOut(float t) => default; // 0x000000018B4E0BBC-0x000000018B4E0C9C
		public static float BounceIn(float t) => default; // 0x000000018B4E073C-0x000000018B4E0770
		public static float BounceOut(float t) => default; // 0x000000018B4E0770-0x000000018B4E0808
		public static float BounceInOut(float t) => default; // 0x000000018B4E06D0-0x000000018B4E073C
		public static float BackIn(float t) => default; // 0x0000000185FD2C30-0x0000000185FD2C50
		public static float BackOut(float t) => default; // 0x0000000185FD2C50-0x0000000185FD2C80
		public static float BackInOut(float t) => default; // 0x000000018B4E0668-0x000000018B4E06D0
	}

	public interface ITransformRefParameter // TypeDefIndex: 55701
	{
		// Properties
		Transform transform { get; }
		TransformSpace space { get; }
		bool useAnimation { get; }
	}

	public class ObjectSnapshot // TypeDefIndex: 55702
	{
		// Fields
		private static List<System.Type> ignoreTypes; // 0x00
		private Dictionary<UnityEngine.Object, string> serialized; // 0x10
	
		// Constructors
		public ObjectSnapshot() {} // Dummy constructor
		public ObjectSnapshot(UnityEngine.Object target, bool fullObjectHierarchy = false /* Metadata: 0x0207BFA2 */) {} // 0x000000018B7B9BB4-0x000000018B7B9C54
		static ObjectSnapshot() {} // 0x000000018B7B9B28-0x000000018B7B9BB4
	
		// Methods
		public static void AppendIgnoreType(System.Type type) {} // 0x000000018B7B957C-0x000000018B7B962C
		public void Store(UnityEngine.Object target, bool fullObjectHierarchy = false /* Metadata: 0x0207BFA3 */) {} // 0x000000018B7B986C-0x000000018B7B9B28
		public void Restore() {} // 0x000000018B7B962C-0x000000018B7B986C
	}

	public static class RectUtility // TypeDefIndex: 55703
	{
		// Methods
		public static Rect GetBoundRect(Rect[] rects) => default; // 0x000000018B4D1494-0x000000018B4D15B4
		public static Rect GetBoundRect(Vector2[] positions) => default; // 0x000000018B4D15B4-0x000000018B4D16C4
		public static bool Encapsulates(Rect a, Rect b) => default; // 0x000000018B7BBB8C-0x000000018B7BBC44
		public static Rect ExpandBy(Rect rect, float margin) => default; // 0x000000018B7BBCA8-0x000000018B7BBCE4
		public static Rect ExpandBy(Rect rect, float xMargin, float yMargin) => default; // 0x000000018B7BBC44-0x000000018B7BBCA8
		public static Rect TransformSpace(Rect rect, Rect oldContainer, Rect newContainer) => default; // 0x000000018B4D1744-0x000000018B4D187C
		public static Rect ToViewRect(Bounds b, Camera cam) => default; // 0x000000018B7BBCE4-0x000000018B7BC458
	}

	public static class ReflectionTools // TypeDefIndex: 55706
	{
		// Fields
		private const System.Reflection.BindingFlags flagsEverything = (System.Reflection.BindingFlags) 60; // Metadata: 0x0207BFA7
		private static List<Assembly> _loadedAssemblies; // 0x00
		private static Dictionary<string, System.Type> typeMap; // 0x08
		private static Dictionary<System.Type, System.Type[]> subTypesMap; // 0x10
	
		// Properties
		private static List<Assembly> loadedAssemblies { get; } // 0x000000018B7BD974-0x000000018B7BD994 
	
		// Nested types
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 55704
		{
			// Fields
			public System.Type type; // 0x10
			public Func<System.Type, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass8_0() {} // 0x000000018B7BE12C-0x000000018B7BE1FC
	
			// Methods
			internal bool _GetImplementationsOf_b__0(System.Type t) => default; // 0x000000018B7BD398-0x000000018B7BD974
		}
	
		private sealed class __c__DisplayClass28_0<T, TValue> // TypeDefIndex: 55705
		{
			// Fields
			public MemberInfo info;
	
			// Constructors
			public __c__DisplayClass28_0() {} // 0x000000018B7BC548-0x000000018B7BC798
	
			// Methods
			internal void _GetFieldOrPropSetter_b__0(T x, TValue v) {} // 0x000000018B7BC798-0x000000018B7BCC48
		}
	
		// Constructors
		static ReflectionTools() {}
	
		// Methods
		public static System.Type GetType(string typeName) => default; // 0x000000018B7BC458-0x000000018B7BC548
		public static System.Type[] GetAllTypes() => default; // 0x000000018B7BDDFC-0x000000018B7BDEAC
		public static System.Type[] GetImplementationsOf(System.Type type) => default; // 0x000000018B4C1954-0x000000018B4C1970
		private static System.Type[] RTGetExportedTypes(Assembly asm) => default; // 0x000000018B4C1BB0-0x000000018B4C1BD4
		public static string FriendlyName(System.Type type) => default; // 0x000000018B7BDDD8-0x000000018B7BDDFC
		public static bool RTIsStatic(PropertyInfo propertyInfo) => default; // 0x000000018B7BDC44-0x000000018B7BDC68
		public static bool RTIsAbstract(System.Type type) => default; // 0x000000018B7BDDB4-0x000000018B7BDDD8
		public static bool RTIsSubclassOf(System.Type type, System.Type other) => default; // 0x000000018B7BDD6C-0x000000018B7BDD90
		public static bool RTIsAssignableFrom(System.Type type, System.Type second) => default; // 0x000000018B7BDD48-0x000000018B7BDD6C
		public static System.Reflection.FieldInfo RTGetField(System.Type type, string name) => default; // 0x000000018B7BDD90-0x000000018B7BDDB4
		public static PropertyInfo RTGetProperty(System.Type type, string name) => default; // 0x000000018B4C13A4-0x000000018B4C13C0
		public static MethodInfo RTGetMethod(System.Type type, string name) => default; // 0x000000018B4C1938-0x000000018B4C1954
		public static System.Reflection.FieldInfo[] RTGetFields(System.Type type) => default; // 0x000000018B7BDEAC-0x000000018B7BDECC
		public static PropertyInfo[] RTGetProperties(System.Type type) => default; // 0x000000018B7BDEAC-0x000000018B7BDECC
		public static MethodInfo RTGetGetMethod(PropertyInfo prop) => default;
		public static MethodInfo RTGetSetMethod(PropertyInfo prop) => default;
		public static System.Type RTReflectedType(System.Type type) => default;
		public static System.Type RTReflectedType(MemberInfo member) => default;
		public static T RTGetAttribute<T>(System.Type type, bool inherited)
			where T : Attribute => default;
		public static T RTGetAttribute<T>(MemberInfo member, bool inherited)
			where T : Attribute => default; // 0x000000018B7BDC68-0x000000018B7BDD48
		public static bool RTIsDefined<T>(MemberInfo member, bool inherited)
			where T : Attribute => default; // 0x000000018B7BDBB4-0x000000018B7BDC44
		public static T RTCreateDelegate<T>(MethodInfo method, object instance) => default; // 0x000000018B7BDA58-0x000000018B7BDBB4
		public static Action<T, TValue> GetFieldOrPropSetter<T, TValue>(MemberInfo info) => default; // 0x000000018B7BDECC-0x000000018B7BE030
		public static MemberInfo[] RTGetFieldsAndProps(System.Type type) => default; // 0x000000018B7BD994-0x000000018B7BDA58
		public static MemberInfo RTGetFieldOrProp(System.Type type, string name) => default; // 0x000000018B7BD324-0x000000018B7BD398
		public static object RTGetFieldOrPropValue(MemberInfo member, object instance, int index = -1 /* Metadata: 0x0207BFA4 */) => default; // 0x000000018B7BD1D0-0x000000018B7BD324
		public static void RTSetFieldOrPropValue(MemberInfo member, object instance, object value, int index = -1 /* Metadata: 0x0207BFA5 */) {} // 0x000000018B7BD08C-0x000000018B7BD1D0
		public static System.Type RTGetFieldOrPropType(MemberInfo member) => default;
		public static MemberInfo GetRelativeMember(object root, string path) => default; // 0x000000018B7BCC48-0x000000018B7BD08C
		public static MemberInfo GetRelativeMember(System.Type type, string path) => default; // 0x000000018B7BE030-0x000000018B7BE12C
		public static object GetRelativeMemberParent(object root, string path) => default; // 0x0000000185492010-0x0000000185492020
		public static string GetMemberPath<T, TResult>(Expression<Func<T, TResult>> func) => default; // 0x000000018B7C1038-0x000000018B7C10AC
		public static string[] GetMemberPaths(System.Type type, Predicate<System.Type> shouldInclude, Predicate<System.Type> shouldContinue, string currentPath = "" /* Metadata: 0x0207BFA6 */, List<System.Type> recursionCheck = null) => default;
	}

	public static class StringUtility // TypeDefIndex: 55707
	{
		// Methods
		public static string SplitCamelCase(string s) => default; // 0x000000018B7BFAE4-0x000000018B7BFBE8
		public static string AbsToRelativePath(string absolutepath) => default; // 0x000000018B7BFA08-0x000000018B7BFAE4
	}

	[Serializable]
	public struct TransformRefPosition : ITransformRefParameter // TypeDefIndex: 55708
	{
		// Fields
		private CutsceneGroup _group; // 0x00
		private Transform _transform; // 0x08
		private Vector3 _vector; // 0x10
		private TransformSpace _space; // 0x1C
	
		// Properties
		public bool useAnimation { get => default; } // 0x000000018B7C00C0-0x000000018B7C016C 
		public CutsceneGroup group { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x000000018646FE2C-0x000000018646FE34
		public Transform transform { get => default; set {} } // 0x000000018B7C0008-0x000000018B7C00C0 0x00000001877900A4-0x00000001877900B4
		public Vector3 value { get => default; set {} } // 0x000000018B7C016C-0x000000018B7C01D8 0x0000000185FB6850-0x0000000185FB6860
		public TransformSpace space { get => default; private set {} } // 0x000000018B7BFFE4-0x000000018B7C0008 0x00000001813AE9D0-0x00000001813AE9E0
	
		// Methods
		public override string ToString() => default; // 0x000000018B7BFF5C-0x000000018B7BFFE4
	}

	[Serializable]
	public struct TransformRefPositionRotation : ITransformRefParameter // TypeDefIndex: 55709
	{
		// Fields
		private CutsceneGroup _group; // 0x00
		private Transform _transform; // 0x08
		private Vector3 _position; // 0x10
		private Vector3 _rotation; // 0x1C
		private TransformSpace _space; // 0x28
	
		// Properties
		public bool useAnimation { get => default; } // 0x000000018B7BFEB0-0x000000018B7BFF5C 
		public CutsceneGroup group { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x000000018646FE2C-0x000000018646FE34
		public Transform transform { get => default; set {} } // 0x000000018B7BFDF8-0x000000018B7BFEB0 0x00000001877900A4-0x00000001877900B4
		public Vector3 position { get => default; set {} } // 0x000000018B7BFCFC-0x000000018B7BFD68 0x0000000185FB6850-0x0000000185FB6860
		public Vector3 rotation { get => default; set {} } // 0x000000018B7BFD68-0x000000018B7BFDD4 0x0000000185FBE140-0x0000000185FBE150
		public TransformSpace space { get => default; private set {} } // 0x000000018B7BFDD4-0x000000018B7BFDF8 0x0000000181C9A5C0-0x0000000181C9A5D0
	
		// Methods
		public override string ToString() => default; // 0x000000018B7BFC44-0x000000018B7BFCFC
	}

	public class TransformSnapshot // TypeDefIndex: 55712
	{
		// Fields
		private List<TransformData> data; // 0x10
	
		// Nested types
		public enum StoreMode // TypeDefIndex: 55710
		{
			All = 0,
			RootOnly = 1,
			ChildrenOnly = 2
		}
	
		private struct TransformData // TypeDefIndex: 55711
		{
			// Fields
			public Transform transform; // 0x00
			public Transform parent; // 0x08
			public Vector3 pos; // 0x10
			public Quaternion rot; // 0x1C
			public Vector3 scale; // 0x2C
	
			// Constructors
			public TransformData(Transform transform, Transform parent, Vector3 pos, Quaternion rot, Vector3 scale) {
				this.transform = default;
				this.parent = default;
				this.pos = default;
				this.rot = default;
				this.scale = default;
			} // 0x000000018B7C06EC-0x000000018B7C078C
		}
	
		// Constructors
		public TransformSnapshot() {} // Dummy constructor
		public TransformSnapshot(GameObject root, StoreMode mode) {} // 0x000000018B7C0348-0x000000018B7C06EC
	
		// Methods
		public void Store(GameObject root, StoreMode mode) {} // 0x000000018B7C01D8-0x000000018B7C0348
		public void Restore() {} // 0x000000018B7BFBE8-0x000000018B7BFC44
	}

	public static class UnityObjectUtility // TypeDefIndex: 55714
	{
		// Fields
		private static MethodInfo _getLocalEulerAngles; // 0x00
		private static MethodInfo _setLocalEulerAngles; // 0x08
		private static PropertyInfo _rotationOrder; // 0x10
		private static object[] _rotationOrderArgGet; // 0x18
		private static object[] _rotationOrderArgSet; // 0x20
	
		// Nested types
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 55713
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass10_0() {} // 0x000000018B7C1DD0-0x000000018B7C1F98
	
			// Methods
			internal bool _FindInChildren_b__0(Transform t) => default; // 0x000000018B7C17F4-0x000000018B7C1914
		}
	
		// Constructors
		static UnityObjectUtility() {} // 0x000000018B7C1C70-0x000000018B7C1DD0
	
		// Methods
		public static Vector3 GetLocalEulerAngles(Transform transform) => default; // 0x000000018B7C12A8-0x000000018B7C145C
		public static void SetLocalEulerAngles(Transform transform, Vector3 value) {} // 0x000000018B7C1A90-0x000000018B7C1BB4
		public static string CalculateTransformPath(Transform root, Transform child) => default; // 0x000000018B7C145C-0x000000018B7C1598
		public static Transform ResolveTransformPath(Transform root, string path) => default; // 0x000000018B7C19EC-0x000000018B7C1A90
		public static Transform FindInChildren(Transform root, string name, bool includeHidden) => default; // 0x000000018B7C1BB4-0x000000018B7C1C70
		public static void ResetLocalCoords(Transform transform, bool includeScale = true /* Metadata: 0x0207BFAB */) {} // 0x000000018B7C1914-0x000000018B7C19EC
		public static void SetLocalCoordsFrom(Transform transform, Transform source) {}
		public static Transform InsertParentInChain(Transform transform, string name) => default;
		public static T GetAddComponent<T>(GameObject go)
			where T : Component => default; // 0x000000018B7C1598-0x000000018B7C1628
		public static T GetAddComponent<T>(Component comp)
			where T : Component => default; // 0x000000018B7C16EC-0x000000018B7C17F4
		public static Component GetAddComponent(GameObject go, System.Type type) => default; // 0x000000018B7C1628-0x000000018B7C16EC
		public static List<string> GetBlendShapeNames(SkinnedMeshRenderer skinnedMesh) => default; // 0x0000000185492010-0x0000000185492020
		public static int GetBlendShapeIndex(SkinnedMeshRenderer skinnedMesh, string shapeName) => default; // 0x000000018B7C0CB8-0x000000018B7C0D18
	}

	public static class VideoSampler // TypeDefIndex: 55717
	{
		// Fields
		private const string ROOT_NAME = "_VideoSources"; // Metadata: 0x0207BFAC
		private static GameObject root; // 0x00
		private static Dictionary<object, VideoPlayer> sources; // 0x08
	
		// Nested types
		public enum VideoRenderTarget // TypeDefIndex: 55715
		{
			CameraBackground = 0,
			CameraForeground = 1
		}
	
		[Serializable]
		public struct SampleSettings // TypeDefIndex: 55716
		{
			// Fields
			public VideoRenderTarget renderTarget; // 0x00
			public float playbackSpeed; // 0x04
			public float alpha; // 0x08
			public VideoAspectRatio aspectRatio; // 0x0C
			public float audioVolume; // 0x10
	
			// Methods
			public static SampleSettings Default() => default; // 0x000000018B7C1F98-0x000000018B7C22E0
		}
	
		// Constructors
		static VideoSampler() {} // 0x0000000185FD5CD0-0x0000000185FD5D00
	
		// Methods
		public static VideoPlayer GetSourceForID(object keyID) => default; // 0x000000018B7C22E0-0x000000018B7C2494
		public static void ReleaseSourceForID(object keyID) {} // 0x000000018B7C2494-0x000000018B7C2538
		public static void SampleForID(object keyID, VideoClip clip, float time, float previousTime, SampleSettings settings) {} // 0x000000018B7C2538-0x000000018B7C2738
		public static void Sample(VideoPlayer source, VideoClip clip, float time, float previousTime, SampleSettings settings) {} // 0x000000018B7C2738-0x000000018B7C2890
	}

	public class CutsceneSequencePlayer : MonoBehaviour // TypeDefIndex: 55718
	{
		// Fields
		public bool playOnStart; // 0x18
		public List<Cutscene> cutscenes; // 0x20
		public UnityEvent onFinish; // 0x28
		private int currentIndex; // 0x30
		private bool isPlaying; // 0x34
	
		// Constructors
		public CutsceneSequencePlayer() {} // 0x00000001864717D0-0x00000001864717DC
	
		// Methods
		private void Start() {} // 0x000000018B7B5690-0x000000018B7B56A0
		public void Play() {} // 0x000000018B7B55BC-0x000000018B7B5690
		public void Stop() {} // 0x000000018B7B56A0-0x000000018B7B5708
		private void MoveNext() {} // 0x000000018B7B5458-0x000000018B7B55BC
		public static GameObject Create() => default; // 0x000000018B7B53D8-0x000000018B7B5458
		private void _MoveNext_b__8_0() {} // 0x000000018B7B5708-0x000000018B7B5710
	}

	public class DirectorGUITemplate : MonoBehaviour // TypeDefIndex: 55719
	{
		// Fields
		public bool dontDestroyOnLoad; // 0x18
		public CanvasScaler absScaler; // 0x20
		public CanvasScaler refScaler; // 0x28
		public CanvasGroup cameraDissolveGroup; // 0x30
		public RawImage dissolverImage; // 0x38
		public CanvasGroup letterboxGroup; // 0x40
		public RawImage letterboxTop; // 0x48
		public RawImage letterboxBottom; // 0x50
		public CanvasGroup screenFadeGroup; // 0x58
		public RawImage screenFadeImage; // 0x60
		public CanvasGroup overlayImageGroup; // 0x68
		public RawImage overlayImage; // 0x70
		public CanvasGroup overlayTextGroup; // 0x78
		public UnityEngine.UI.Text overlayText; // 0x80
		public CanvasGroup subtitlesGroup; // 0x88
		public UnityEngine.UI.Text subtitlesText; // 0x90
		private static DirectorGUITemplate _current; // 0x00
	
		// Constructors
		public DirectorGUITemplate() {} // 0x00000001864717D0-0x00000001864717DC
	
		// Methods
		private void Awake() {} // 0x000000018B7B62A4-0x000000018B7B63C4
		private void ShowAll() {} // 0x000000018B7B6E34-0x000000018B7B6EDC
		private void HideAll() {} // 0x000000018B7B63C4-0x000000018B7B6454
		private void OnEnable() {} // 0x000000018B7B6758-0x000000018B7B6974
		private void OnDisable() {} // 0x000000018B7B653C-0x000000018B7B6758
		private void Update() {} // 0x000000018B7B6EDC-0x000000018B7B6F30
		private void OnCameraDissolve(Texture texture, float completion) {} // 0x000000018B7B6454-0x000000018B7B653C
		private void OnImageOverlayGUI(Texture texture, UnityEngine.Color color, Vector2 scale, Vector2 position) {} // 0x000000018B7B6974-0x000000018B7B6ADC
		private void OnLetterboxGUI(float completion) {} // 0x000000018B7B6ADC-0x000000018B7B6C6C
		private void OnScreenFadeGUI(UnityEngine.Color color) {} // 0x000000018B7B6C6C-0x000000018B7B6CC4
		private void OnTextOverlayGUI(string text, UnityEngine.Color color, float size, TextAnchor anchor, Vector2 position) {} // 0x000000018B7B6D48-0x000000018B7B6E34
		private void OnSubtitlesGUI(string text, UnityEngine.Color color) {} // 0x000000018B7B6CC4-0x000000018B7B6D48
	}

	public class PlayCutsceneOnClick : MonoBehaviour // TypeDefIndex: 55720
	{
		// Fields
		public Cutscene cutscene; // 0x18
		public float startTime; // 0x20
		public UnityEvent onFinish; // 0x28
	
		// Constructors
		public PlayCutsceneOnClick() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void OnMouseDown() {} // 0x000000018B7BB4D8-0x000000018B7BB5EC
		private void Reset() {} // 0x000000018B7BB5EC-0x000000018B7BB68C
		public static GameObject Create() => default; // 0x000000018B7BB468-0x000000018B7BB4D8
		private void _OnMouseDown_b__3_0() {} // 0x000000018B7BB68C-0x000000018B7BB6AC
	}

	public class PlayCutsceneOnStart : MonoBehaviour // TypeDefIndex: 55721
	{
		// Fields
		public Cutscene cutscene; // 0x18
		public float startTime; // 0x20
		public UnityEvent onFinish; // 0x28
	
		// Constructors
		public PlayCutsceneOnStart() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Start() {} // 0x000000018B7BB738-0x000000018B7BB84C
		public static GameObject Create() => default; // 0x000000018B7BB6AC-0x000000018B7BB738
		private void _Start_b__3_0() {} // 0x000000018B7BB68C-0x000000018B7BB6AC
	}

	public class PlayCutsceneOnTrigger : MonoBehaviour // TypeDefIndex: 55722
	{
		// Fields
		public Cutscene cutscene; // 0x18
		public float startTime; // 0x20
		public bool checkSpecificTagOnly; // 0x24
		public string tagName; // 0x28
		public bool once; // 0x30
		public UnityEvent onFinish; // 0x38
	
		// Constructors
		public PlayCutsceneOnTrigger() {} // 0x000000018B7BBB40-0x000000018B7BBB8C
	
		// Methods
		private void OnTriggerEnter(Collider other) {} // 0x000000018B7BB8D8-0x000000018B7BBA50
		private void Reset() {} // 0x000000018B7BBA50-0x000000018B7BBAC8
		public static GameObject Create() => default; // 0x000000018B7BB84C-0x000000018B7BB8D8
		private void _OnTriggerEnter_b__6_0() {} // 0x000000018B7BBAC8-0x000000018B7BBB40
	}

	public class StopCutsceneOnClick : MonoBehaviour // TypeDefIndex: 55723
	{
		// Fields
		public Cutscene cutscene; // 0x18
		public Cutscene.StopMode stopMode; // 0x20
	
		// Constructors
		public StopCutsceneOnClick() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void OnMouseDown() {} // 0x000000018B7BF71C-0x000000018B7BF7D0
		private void Reset() {} // 0x000000018B7BF7D0-0x000000018B7BF830
	}

	public class StopCutsceneOnTrigger : MonoBehaviour // TypeDefIndex: 55724
	{
		// Fields
		public Cutscene cutscene; // 0x18
		public bool checkSpecificTagOnly; // 0x20
		public string tagName; // 0x28
		public Cutscene.StopMode stopMode; // 0x30
	
		// Constructors
		public StopCutsceneOnTrigger() {} // 0x000000018B7BF9BC-0x000000018B7BFA08
	
		// Methods
		private void OnTriggerEnter(Collider other) {} // 0x000000018B7BF830-0x000000018B7BF944
		private void Reset() {} // 0x000000018B7BF944-0x000000018B7BF9BC
	}
}

namespace Slate.ActionClips
{
	public abstract class ActorActionClip : ActionClip // TypeDefIndex: 55725
	{
		// Constructors
		protected ActorActionClip() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public abstract class ActorActionClip<T> : ActionClip // TypeDefIndex: 55726
		where T : Component
	{
		// Fields
		[NonSerialized]
		private T _actorComponent;
	
		// Properties
		public new T actor { get; }
		public override bool isValid { get; }
	
		// Constructors
		protected ActorActionClip() {}
	}

	public class AnimateProperties : ActionClip // TypeDefIndex: 55727
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
		protected string _name; // 0x50
		public Slate.EaseType interpolation; // 0x58
	
		// Properties
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendOut { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public override bool isValid { get => default; } // 0x000000018B797AF4-0x000000018B797B0C 
		public override string info { get => default; } // 0x000000018B7B0224-0x000000018B7B0294 
		public override object animatedParametersTarget { get => default; } // 0x000000018B7B021C-0x000000018B7B0224 
		public override Slate.EaseType animatedParametersInterpolation { get => default; } // 0x0000000183F80450-0x0000000183F80460 
		public override bool useWeightInParameters { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
	
		// Constructors
		public AnimateProperties() {} // 0x000000018B7B0204-0x000000018B7B021C
	}

	public class AnimateBlendShape : ActorActionClip // TypeDefIndex: 55728
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
		private string _skinName; // 0x50
		private string _shapeName; // 0x58
		public float weight; // 0x60
		private float originalWeight; // 0x64
		private int index; // 0x68
		private SkinnedMeshRenderer _skinnedMesh; // 0x70
	
		// Properties
		public override string info { get => default; } // 0x000000018B7AF3BC-0x000000018B7AF3FC 
		public override bool isValid { get => default; } // 0x000000018B7AF3FC-0x000000018B7AF4A4 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendOut { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public override bool canCrossBlend { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public string skinName { get => default; set {} } // 0x0000000181460F60-0x0000000181460F70 0x000000018B7AF5FC-0x000000018B7AF628
		public string shapeName { get => default; set {} } // 0x00000001813F1630-0x00000001813F1640 0x0000000186472DB0-0x0000000186472DC0
		private SkinnedMeshRenderer skinnedMesh { get => default; } // 0x000000018B7AF4A4-0x000000018B7AF5FC 
	
		// Constructors
		public AnimateBlendShape() {} // 0x000000018B7AF398-0x000000018B7AF3BC
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7AF1B8-0x000000018B7AF29C
		protected override void OnUpdate(float deltaTime) {} // 0x000000018B7AF2D8-0x000000018B7AF360
		protected override void OnReverse() {} // 0x000000018B7AF29C-0x000000018B7AF2D8
		private bool _get_skinnedMesh_b__31_0(SkinnedMeshRenderer s) => default; // 0x000000018B7AF360-0x000000018B7AF398
	}

	public class CharacterExpression : ActorActionClip<Slate.Character> // TypeDefIndex: 55729
	{
		// Fields
		private float _length; // 0x48
		private float _blendIn; // 0x4C
		private float _blendOut; // 0x50
		public string expressionName; // 0x58
		public string expressionUID; // 0x60
		public float weight; // 0x68
		private float originalWeight; // 0x6C
		private BlendShapeGroup expression; // 0x70
	
		// Properties
		public override string info { get => default; } // 0x000000018B7B22DC-0x000000018B7B2390 
		public override bool isValid { get => default; } // 0x000000018B7B2390-0x000000018B7B23F4 
		public override float length { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public override float blendIn { get => default; set {} } // 0x0000000185FB1750-0x0000000185FB1760 0x0000000185FBFAC0-0x0000000185FBFAD0
		public override float blendOut { get => default; set {} } // 0x0000000185FB3000-0x0000000185FB3010 0x0000000185FB3010-0x0000000185FB3020
		public override bool canCrossBlend { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
	
		// Constructors
		public CharacterExpression() {} // 0x000000018B7B228C-0x000000018B7B22DC
	
		// Methods
		private BlendShapeGroup ResolveExpression() => default; // 0x000000018B7B2200-0x000000018B7B228C
		protected override void OnEnter() {} // 0x000000018B7B2118-0x000000018B7B214C
		protected override void OnUpdate(float deltaTime) {} // 0x000000018B7B2190-0x000000018B7B2200
		protected override void OnReverse() {} // 0x000000018B7B214C-0x000000018B7B2190
	}

	public class CharacterLookAt : ActorActionClip<Slate.Character> // TypeDefIndex: 55730
	{
		// Fields
		private float _length; // 0x48
		private float _blendIn; // 0x4C
		private float _blendOut; // 0x50
		public Slate.EaseType interpolation; // 0x54
		public float weight; // 0x58
		public TransformRefPosition targetPosition; // 0x60
		private Quaternion wasNeckRot; // 0x80
		private Quaternion wasHeadRot; // 0x90
	
		// Properties
		public Vector3 targetPositionVector { get => default; set {} } // 0x000000018B7B2C24-0x000000018B7B2C58 0x0000000185FD5C80-0x0000000185FD5C90
		public override string info { get => default; } // 0x000000018B7B2ACC-0x000000018B7B2B44 
		public override bool isValid { get => default; } // 0x000000018B7B2B44-0x000000018B7B2C24 
		public override float length { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public override float blendIn { get => default; set {} } // 0x0000000185FB1750-0x0000000185FB1760 0x0000000185FBFAC0-0x0000000185FBFAD0
		public override float blendOut { get => default; set {} } // 0x0000000185FB3000-0x0000000185FB3010 0x0000000185FB3010-0x0000000185FB3020
	
		// Constructors
		public CharacterLookAt() {} // 0x000000018B7B2A78-0x000000018B7B2ACC
	
		// Methods
		protected override void OnCreate() {} // 0x000000018B7B2440-0x000000018B7B2508
		protected override void OnAfterValidate() {} // 0x000000018B7B23F4-0x000000018B7B2440
		protected override void OnEnter() {} // 0x000000018B7B2508-0x000000018B7B25A8
		protected override void OnUpdate(float time) {} // 0x000000018B7B2648-0x000000018B7B2A78
		protected override void OnReverse() {} // 0x000000018B7B25A8-0x000000018B7B2648
	}

	public abstract class SendMessage<T> : SendMessage // TypeDefIndex: 55731
	{
		// Fields
		public T value;
	
		// Properties
		public override string info { get; }
		public override bool isValid { get; }
		public override System.Type parameterType { get; }
	
		// Constructors
		protected SendMessage() {}
	
		// Methods
		protected override void OnEnter() {}
	}

	public class SendMessage : ActorActionClip // TypeDefIndex: 55732
	{
		// Fields
		public string message; // 0x40
		public int componentIndex; // 0x48
	
		// Properties
		public override string info { get => default; } // 0x000000018B7BE7FC-0x000000018B7BE83C 
		public override bool isValid { get => default; } // 0x0000000189D8F4C0-0x0000000189D8F4D8 
		public virtual System.Type parameterType { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Constructors
		public SendMessage() {} // 0x0000000189D8E5EC-0x0000000189D8E5FC
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7BE548-0x000000018B7BE7FC
	}

	public class SendMessageBoolean : SendMessage<bool> // TypeDefIndex: 55733
	{
		// Constructors
		public SendMessageBoolean() {} // 0x000000018B7BE41C-0x000000018B7BE458
	}

	public class SendMessageFloat : SendMessage<float> // TypeDefIndex: 55734
	{
		// Constructors
		public SendMessageFloat() {} // 0x000000018B7BE458-0x000000018B7BE494
	}

	public class SendMessageInteger : SendMessage<int> // TypeDefIndex: 55735
	{
		// Constructors
		public SendMessageInteger() {} // 0x000000018B7BE494-0x000000018B7BE4D0
	}

	public class SendMessageObject : SendMessage<UnityEngine.Object> // TypeDefIndex: 55736
	{
		// Constructors
		public SendMessageObject() {} // 0x000000018B7BE4D0-0x000000018B7BE50C
	}

	public class SendMessageString : SendMessage<string> // TypeDefIndex: 55737
	{
		// Constructors
		public SendMessageString() {} // 0x000000018B7BE50C-0x000000018B7BE548
	}

	public class AnimateActorVisibility : ActorActionClip // TypeDefIndex: 55738
	{
		// Fields
		private float _length; // 0x40
		public bool visible; // 0x44
		private bool wasVisible; // 0x45
	
		// Properties
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
	
		// Constructors
		public AnimateActorVisibility() {} // 0x000000018B7AF1A8-0x000000018B7AF1B8
	
		// Methods
		protected override void OnCreate() {} // 0x000000018B7AF0E8-0x000000018B7AF118
		protected override void OnEnter() {} // 0x000000018B7AF118-0x000000018B7AF148
		protected override void OnUpdate(float time) {} // 0x000000018B7AF178-0x000000018B7AF1A8
		protected override void OnReverse() {} // 0x000000018B7AF148-0x000000018B7AF178
	}

	public class MakeCameraTarget : ActorActionClip // TypeDefIndex: 55739
	{
		// Fields
		public bool setTransposerTarget; // 0x40
		public bool setComposerTarget; // 0x41
		private Transform wasTransposerTarget; // 0x48
		private Transform wasComposerTarget; // 0x50
	
		// Constructors
		public MakeCameraTarget() {} // 0x000000018B7B956C-0x000000018B7B957C
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7B92C0-0x000000018B7B944C
		protected override void OnReverse() {} // 0x000000018B7B944C-0x000000018B7B956C
	}

	public class SetActorActiveState : ActorActionClip // TypeDefIndex: 55740
	{
		// Fields
		private float _length; // 0x40
		public ActiveState activeState; // 0x44
		private bool lastState; // 0x48
		private bool currentState; // 0x49
		private bool temporary; // 0x4A
	
		// Properties
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override string info { get => default; } // 0x000000018B7BE9BC-0x000000018B7BEA1C 
	
		// Constructors
		public SetActorActiveState() {} // 0x000000018B7BE9AC-0x000000018B7BE9BC
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7BE83C-0x000000018B7BE904
		protected override void OnExit() {} // 0x000000018B7BE904-0x000000018B7BE940
		protected override void OnReverseEnter() {} // 0x000000018B7BE940-0x000000018B7BE97C
		protected override void OnReverse() {} // 0x000000018B7BE97C-0x000000018B7BE9AC
	}

	public class SetActorVisibilityTemporary : ActorActionClip // TypeDefIndex: 55741
	{
		// Fields
		private float _length; // 0x40
		public ActiveState activeState; // 0x44
		private bool lastState; // 0x48
		private bool currentState; // 0x49
		private bool temporary; // 0x4A
	
		// Properties
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override string info { get => default; } // 0x000000018B7BEA34-0x000000018B7BEA94 
	
		// Constructors
		public SetActorVisibilityTemporary() {} // 0x000000018B7BEA1C-0x000000018B7BEA34
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7BE83C-0x000000018B7BE904
		protected override void OnExit() {} // 0x000000018B7BE904-0x000000018B7BE940
		protected override void OnReverseEnter() {} // 0x000000018B7BE940-0x000000018B7BE97C
		protected override void OnReverse() {} // 0x000000018B7BE97C-0x000000018B7BE9AC
	}

	public class SetBehavioursActiveState : ActorActionClip // TypeDefIndex: 55742
	{
		// Fields
		private float _length; // 0x40
		public List<string> behaviourNames; // 0x48
		public ActiveState activeState; // 0x50
		private Dictionary<UnityEngine.Behaviour, bool> originalStates; // 0x58
		private Dictionary<UnityEngine.Behaviour, bool> currentStates; // 0x60
		private bool temporary; // 0x68
	
		// Properties
		public override string info { get => default; } // 0x000000018B7BF3A0-0x000000018B7BF45C 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
	
		// Constructors
		public SetBehavioursActiveState() {} // 0x000000018B7BF318-0x000000018B7BF3A0
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7BEA94-0x000000018B7BEDB4
		protected override void OnExit() {} // 0x000000018B7BEDB4-0x000000018B7BEF68
		protected override void OnReverseEnter() {} // 0x000000018B7BEF68-0x000000018B7BF118
		protected override void OnReverse() {} // 0x000000018B7BF118-0x000000018B7BF2A0
		private bool _OnEnter_b__11_0(UnityEngine.Behaviour c) => default; // 0x000000018B7BF2A0-0x000000018B7BF318
	}

	public class AnimateOnPath : ActorActionClip // TypeDefIndex: 55743
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		public Path path; // 0x48
		public float positionOnPath; // 0x50
		public Vector3 lookAtTargetPosition; // 0x54
		public Slate.EaseType blendInterpolation; // 0x60
		private Vector3 wasPosition; // 0x64
		private Quaternion wasRotation; // 0x70
	
		// Properties
		public override string info { get => default; } // 0x000000018B7B0114-0x000000018B7B01B4 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override bool isValid { get => default; } // 0x000000018B7B01B4-0x000000018B7B0204 
	
		// Constructors
		public AnimateOnPath() {} // 0x000000018B7B00FC-0x000000018B7B0114
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7AFCD4-0x000000018B7AFD74
		protected override void OnUpdate(float time) {} // 0x000000018B7AFE00-0x000000018B7B00FC
		protected override void OnReverse() {} // 0x000000018B7AFD74-0x000000018B7AFE00
	}

	public class FollowPath : ActorActionClip // TypeDefIndex: 55744
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
		public Path path; // 0x50
		public bool useSpeed; // 0x58
		public float speed; // 0x5C
		public float lookAhead; // 0x60
		public Vector3 upVector; // 0x64
		public Slate.EaseType blendInterpolation; // 0x70
		private Vector3 lastPos; // 0x74
		private Quaternion lastRot; // 0x80
	
		// Properties
		public override string info { get => default; } // 0x000000018B7B7FA4-0x000000018B7B8044 
		public override float length { get => default; set {} } // 0x000000018B7B8094-0x000000018B7B8120 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendOut { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public override bool isValid { get => default; } // 0x000000018B7B8044-0x000000018B7B8094 
	
		// Constructors
		public FollowPath() {} // 0x000000018B7B7F6C-0x000000018B7B7FA4
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7B7AEC-0x000000018B7B7B90
		protected override void OnUpdate(float time) {} // 0x000000018B7B7C20-0x000000018B7B7F6C
		protected override void OnReverse() {} // 0x000000018B7B7B90-0x000000018B7B7C20
	}

	public class PathfindFromTo : ActorActionClip // TypeDefIndex: 55745
	{
		// Fields
		private float _blendIn; // 0x40
		public float speed; // 0x44
		public TransformRefPosition sourcePosition; // 0x48
		public TransformRefPosition targetPosition; // 0x68
		private Vector3[] pathPoints; // 0x88
		private Vector3 wasPosition; // 0x90
		private Quaternion wasRotation; // 0x9C
		private Vector3 lastFrom; // 0xAC
		private Vector3 lastTo; // 0xB8
	
		// Properties
		public override string info { get => default; } // 0x000000018B7BAA3C-0x000000018B7BAA84 
		public override float length { get => default; } // 0x000000018B7BAA84-0x000000018B7BAAC8 
		public override float blendIn { get => default; set {} } // 0x000000018B7BAA0C-0x000000018B7BAA3C 0x0000000185FB05F0-0x0000000185FB0600
	
		// Constructors
		public PathfindFromTo() {} // 0x000000018B7BA9F4-0x000000018B7BAA0C
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7BA0FC-0x000000018B7BA2B0
		protected override void OnUpdate(float time) {} // 0x000000018B7BA35C-0x000000018B7BA798
		protected override void OnReverse() {} // 0x000000018B7BA2B0-0x000000018B7BA35C
		private void TryCalculatePath() {} // 0x000000018B7BA798-0x000000018B7BA9F4
	}

	public class PathfindTo : ActorActionClip // TypeDefIndex: 55746
	{
		// Fields
		private float _blendIn; // 0x40
		public float speed; // 0x44
		public TransformRefPosition targetPosition; // 0x48
		private Vector3[] pathPoints; // 0x68
		private Vector3 wasPosition; // 0x70
		private Quaternion wasRotation; // 0x7C
		private Vector3 lastFrom; // 0x8C
		private Vector3 lastTo; // 0x98
	
		// Properties
		public override string info { get => default; } // 0x000000018B7BB3E0-0x000000018B7BB428 
		public override float length { get => default; } // 0x000000018B7BB428-0x000000018B7BB468 
		public override float blendIn { get => default; set {} } // 0x000000018B7BAA0C-0x000000018B7BAA3C 0x0000000185FB05F0-0x0000000185FB0600
	
		// Constructors
		public PathfindTo() {} // 0x000000018B7BA9F4-0x000000018B7BAA0C
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7BAAC8-0x000000018B7BAC68
		protected override void OnUpdate(float time) {} // 0x000000018B7BAD00-0x000000018B7BB124
		protected override void OnReverse() {} // 0x000000018B7BAC68-0x000000018B7BAD00
		private void TryCalculatePath() {} // 0x000000018B7BB124-0x000000018B7BB3E0
	}

	public class AnimateMaterialColor : ActorActionClip<Renderer> // TypeDefIndex: 55747
	{
		// Fields
		private float _length; // 0x48
		private float _blendIn; // 0x4C
		private float _blendOut; // 0x50
		public string propertyName; // 0x58
		public UnityEngine.Color color; // 0x60
		public Slate.EaseType interpolation; // 0x70
		private UnityEngine.Color originalColor; // 0x74
	
		// Properties
		public override string info { get => default; } // 0x000000018B7AF7E0-0x000000018B7AF820 
		public override bool isValid { get => default; } // 0x000000018B7AF820-0x000000018B7AF90C 
		public override float length { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public override float blendIn { get => default; set {} } // 0x0000000185FB1750-0x0000000185FB1760 0x0000000185FBFAC0-0x0000000185FBFAD0
		public override float blendOut { get => default; set {} } // 0x0000000185FB3000-0x0000000185FB3010 0x0000000185FB3010-0x0000000185FB3020
		private Material targetMaterial { get => default; } // 0x000000018B7AF90C-0x000000018B7AF9B4 
	
		// Constructors
		public AnimateMaterialColor() {} // 0x000000018B7AF760-0x000000018B7AF7E0
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7AF6A4-0x000000018B7AF6AC
		protected override void OnReverseEnter() {} // 0x000000018B7AF6A4-0x000000018B7AF6AC
		protected override void OnUpdate(float time) {} // 0x000000018B7AF6B4-0x000000018B7AF760
		protected override void OnReverse() {} // 0x000000018B7AF6AC-0x000000018B7AF6B4
		protected override void OnExit() {} // 0x000000018B7AF6AC-0x000000018B7AF6B4
		private void DoSet() {} // 0x000000018B7AF668-0x000000018B7AF6A4
		private void DoReset() {} // 0x000000018B7AF628-0x000000018B7AF668
	}

	public class AnimateMaterialFloat : ActorActionClip<Renderer> // TypeDefIndex: 55748
	{
		// Fields
		private float _length; // 0x48
		private float _blendIn; // 0x4C
		private float _blendOut; // 0x50
		public string propertyName; // 0x58
		public float value; // 0x60
		public Slate.EaseType interpolation; // 0x64
		private float originalValue; // 0x68
	
		// Properties
		public override string info { get => default; } // 0x000000018B7AFB00-0x000000018B7AFB40 
		public override bool isValid { get => default; } // 0x000000018B7AFB40-0x000000018B7AFC2C 
		public override float length { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public override float blendIn { get => default; set {} } // 0x0000000185FB1750-0x0000000185FB1760 0x0000000185FBFAC0-0x0000000185FBFAD0
		public override float blendOut { get => default; set {} } // 0x0000000185FB3000-0x0000000185FB3010 0x0000000185FB3010-0x0000000185FB3020
		private Material targetMaterial { get => default; } // 0x000000018B7AFC2C-0x000000018B7AFCD4 
	
		// Constructors
		public AnimateMaterialFloat() {} // 0x000000018B7AFAB0-0x000000018B7AFB00
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7AFA20-0x000000018B7AFA28
		protected override void OnReverseEnter() {} // 0x000000018B7AFA20-0x000000018B7AFA28
		protected override void OnUpdate(float time) {} // 0x000000018B7AFA30-0x000000018B7AFAB0
		protected override void OnReverse() {} // 0x000000018B7AFA28-0x000000018B7AFA30
		protected override void OnExit() {} // 0x000000018B7AFA28-0x000000018B7AFA30
		private void DoSet() {} // 0x000000018B7AF9E8-0x000000018B7AFA20
		private void DoReset() {} // 0x000000018B7AF9B4-0x000000018B7AF9E8
	}

	public class AnimateMaterialTexture : ActorActionClip<Renderer> // TypeDefIndex: 55749
	{
		// Fields
		private float _length; // 0x48
		private float _blendIn; // 0x4C
		private float _blendOut; // 0x50
		public string propertyName; // 0x58
		public Vector2 offset; // 0x60
		public Vector2 scale; // 0x68
		public Slate.EaseType interpolation; // 0x70
		private Vector2 originalOffset; // 0x74
		private Vector2 originalScale; // 0x7C
	
		// Properties
		public override string info { get => default; } // 0x000000018B7C5110-0x000000018B7C5150 
		public override bool isValid { get => default; } // 0x000000018B7C5150-0x000000018B7C523C 
		public override float length { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public override float blendIn { get => default; set {} } // 0x0000000185FB1750-0x0000000185FB1760 0x0000000185FBFAC0-0x0000000185FBFAD0
		public override float blendOut { get => default; set {} } // 0x0000000185FB3000-0x0000000185FB3010 0x0000000185FB3010-0x0000000185FB3020
		private Material targetMaterial { get => default; } // 0x000000018B7C523C-0x000000018B7C52E4 
	
		// Constructors
		public AnimateMaterialTexture() {} // 0x000000018B7C5098-0x000000018B7C5110
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7C4ECC-0x000000018B7C4ED4
		protected override void OnReverseEnter() {} // 0x000000018B7C4ECC-0x000000018B7C4ED4
		protected override void OnUpdate(float time) {} // 0x000000018B7C4EDC-0x000000018B7C5098
		protected override void OnReverse() {} // 0x000000018B7C4ED4-0x000000018B7C4EDC
		protected override void OnExit() {} // 0x000000018B7C4ED4-0x000000018B7C4EDC
		private void DoSet() {} // 0x000000018B7C4E44-0x000000018B7C4ECC
		private void DoReset() {} // 0x000000018B7C4DD0-0x000000018B7C4E44
	}

	public class ScrollMaterialTexture : ActorActionClip<Renderer> // TypeDefIndex: 55750
	{
		// Fields
		private float _length; // 0x48
		public string propertyName; // 0x50
		public Vector2 speed; // 0x58
		public Slate.EaseType interpolation; // 0x60
		private Vector2 originalOffset; // 0x64
	
		// Properties
		public override string info { get => default; } // 0x000000018B7CBE00-0x000000018B7CBE64 
		public override bool isValid { get => default; } // 0x000000018B7CBE64-0x000000018B7CBF10 
		public override float length { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public override float blendIn { get => default; } // 0x000000018B7C5E1C-0x000000018B7C5E2C 
		private Material targetMaterial { get => default; } // 0x000000018B7CBF10-0x000000018B7CBFB8 
	
		// Constructors
		public ScrollMaterialTexture() {} // 0x000000018B7CBD90-0x000000018B7CBE00
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7CBB84-0x000000018B7CBBD0
		protected override void OnUpdate(float time) {} // 0x000000018B7CBC14-0x000000018B7CBD90
		protected override void OnReverse() {} // 0x000000018B7CBBD0-0x000000018B7CBC14
	}

	public class SetMaterial : ActorActionClip<Renderer> // TypeDefIndex: 55751
	{
		// Fields
		private float _length; // 0x48
		public Material material; // 0x50
		private Material sharedMat; // 0x58
		private bool temporary; // 0x60
	
		// Properties
		public override string info { get => default; } // 0x000000018B7CC618-0x000000018B7CC6B8 
		public override float length { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
	
		// Constructors
		public SetMaterial() {} // 0x000000018B7CC5E4-0x000000018B7CC618
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7CC588-0x000000018B7CC5BC
		protected override void OnReverseEnter() {} // 0x000000018B7CC5CC-0x000000018B7CC5DC
		protected override void OnReverse() {} // 0x000000018B7CC5DC-0x000000018B7CC5E4
		protected override void OnExit() {} // 0x000000018B7CC5BC-0x000000018B7CC5CC
		private void DoSet() {} // 0x000000018B7CC508-0x000000018B7CC588
		private void DoReset() {} // 0x000000018B7CC4B4-0x000000018B7CC508
	}

	public class SetMaterialTexture : ActorActionClip<Renderer> // TypeDefIndex: 55752
	{
		// Fields
		private float _length; // 0x48
		public string propertyName; // 0x50
		public Texture texture; // 0x58
		private Texture originalTexture; // 0x60
		private bool temporary; // 0x68
	
		// Properties
		public override string info { get => default; } // 0x000000018B7CC280-0x000000018B7CC320 
		public override bool isValid { get => default; } // 0x000000018B7CC320-0x000000018B7CC40C 
		public override float length { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		private Material targetMaterial { get => default; } // 0x000000018B7CC40C-0x000000018B7CC4B4 
	
		// Constructors
		public SetMaterialTexture() {} // 0x000000018B7CC22C-0x000000018B7CC280
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7CC1D0-0x000000018B7CC204
		protected override void OnReverseEnter() {} // 0x000000018B7CC214-0x000000018B7CC224
		protected override void OnReverse() {} // 0x000000018B7CC224-0x000000018B7CC22C
		protected override void OnExit() {} // 0x000000018B7CC204-0x000000018B7CC214
		private void DoSet() {} // 0x000000018B7CC170-0x000000018B7CC1D0
		private void DoReset() {} // 0x000000018B7CC13C-0x000000018B7CC170
	}

	public class SetSortingLayer : ActorActionClip<SpriteRenderer> // TypeDefIndex: 55753
	{
		// Fields
		public int sortingOrder; // 0x48
		public int sortingLayerID; // 0x4C
		private string _lastLayer; // 0x50
		private int _lastOrder; // 0x58
	
		// Properties
		public override string info { get => default; } // 0x000000018B7CCC98-0x000000018B7CCD50 
	
		// Constructors
		public SetSortingLayer() {} // 0x000000018B7CCC64-0x000000018B7CCC98
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7CCB28-0x000000018B7CCBEC
		protected override void OnReverse() {} // 0x000000018B7CCBEC-0x000000018B7CCC64
	}

	public class SetSprite : ActorActionClip<SpriteRenderer> // TypeDefIndex: 55754
	{
		// Fields
		public Sprite sprite; // 0x48
		public UnityEngine.Color color; // 0x50
		public bool flipX; // 0x60
		public bool flipY; // 0x61
		public bool changeSorting; // 0x62
		public int sortingLayerID; // 0x64
		public int sortingOrder; // 0x68
		private Sprite lastSprite; // 0x70
		private UnityEngine.Color lastColor; // 0x78
		private bool lastFlipX; // 0x88
		private bool lastFlipY; // 0x89
		private int lastSortingLayerID; // 0x8C
		private int lastSortingOrder; // 0x90
	
		// Properties
		public override string info { get => default; } // 0x000000018B7CD0E0-0x000000018B7CD160 
	
		// Constructors
		public SetSprite() {} // 0x000000018B7CD098-0x000000018B7CD0E0
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7CCD50-0x000000018B7CCF74
		protected override void OnReverse() {} // 0x000000018B7CCF74-0x000000018B7CD098
	}

	public class SpriteFlipbook : ActorActionClip<SpriteRenderer> // TypeDefIndex: 55755
	{
		// Fields
		private float _length; // 0x48
		public int loops; // 0x4C
		public List<Sprite> sprites; // 0x50
		public bool endWithPrevious; // 0x58
		private Sprite lastSprite; // 0x60
	
		// Properties
		public override string info { get => default; } // 0x000000018B7CDD14-0x000000018B7CDDD4 
		public override float length { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public override bool isValid { get => default; } // 0x000000018B7CDDD4-0x000000018B7CDE68 
	
		// Constructors
		public SpriteFlipbook() {} // 0x000000018B7CDC74-0x000000018B7CDD14
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7CDA0C-0x000000018B7CDA68
		protected override void OnUpdate(float deltaTime) {} // 0x000000018B7CDB18-0x000000018B7CDC74
		protected override void OnExit() {} // 0x000000018B7CDA68-0x000000018B7CDAC4
		protected override void OnReverse() {} // 0x000000018B7CDAC4-0x000000018B7CDB18
	}

	public class AttachObject : ActorActionClip // TypeDefIndex: 55756
	{
		// Fields
		private float _length; // 0x40
		public Transform targetObject; // 0x48
		public string childTransformName; // 0x50
		public Vector3 localPosition; // 0x58
		public Vector3 localRotation; // 0x64
		public Vector3 localScale; // 0x70
		private TransformSnapshot snapshot; // 0x80
		private bool temporary; // 0x88
	
		// Properties
		public override bool isValid { get => default; } // 0x000000018B7C5BDC-0x000000018B7C5C2C 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
	
		// Constructors
		public AttachObject() {} // 0x000000018B7C58B0-0x000000018B7C58D8
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7C5B54-0x000000018B7C5B88
		protected override void OnReverseEnter() {} // 0x000000018B7C5B9C-0x000000018B7C5BB0
		protected override void OnExit() {} // 0x000000018B7C5B88-0x000000018B7C5B9C
		protected override void OnReverse() {} // 0x000000018B7C5BB0-0x000000018B7C5BB8
		private void Do() {} // 0x000000018B7C5928-0x000000018B7C5B54
		private void UnDo() {} // 0x000000018B7C5BB8-0x000000018B7C5BDC
	}

	public class AttachObjectPrefab : ActorActionClip // TypeDefIndex: 55757
	{
		// Fields
		private float _length; // 0x40
		public Transform targetPrefab; // 0x48
		public string childTransformName; // 0x50
		public Vector3 localPosition; // 0x58
		public Vector3 localRotation; // 0x64
		public Vector3 localScale; // 0x70
		private Transform instance; // 0x80
		private TransformSnapshot snapshot; // 0x88
		private bool temporary; // 0x90
	
		// Properties
		public override bool isValid { get => default; } // 0x000000018B7C58D8-0x000000018B7C5928 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
	
		// Constructors
		public AttachObjectPrefab() {} // 0x000000018B7C58B0-0x000000018B7C58D8
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7C57AC-0x000000018B7C57E0
		protected override void OnReverseEnter() {} // 0x000000018B7C57F4-0x000000018B7C5808
		protected override void OnExit() {} // 0x000000018B7C57E0-0x000000018B7C57F4
		protected override void OnReverse() {} // 0x000000018B7C5808-0x000000018B7C5810
		private void Do() {} // 0x000000018B7C55A0-0x000000018B7C57AC
		private void UnDo() {} // 0x000000018B7C5810-0x000000018B7C58B0
	}

	public class LookAt : ActorActionClip // TypeDefIndex: 55758
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
		public bool verticalOnly; // 0x4C
		public Slate.EaseType interpolation; // 0x50
		public TransformRefPosition targetPosition; // 0x58
		private Quaternion wasRotation; // 0x78
	
		// Properties
		public Vector3 targetPositionVector { get => default; set {} } // 0x000000018B7C7558-0x000000018B7C758C 0x0000000185FD28A0-0x0000000185FD28B0
		public override string info { get => default; } // 0x000000018B7C74E0-0x000000018B7C7558 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendOut { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
	
		// Constructors
		public LookAt() {} // 0x000000018B7C74BC-0x000000018B7C74E0
	
		// Methods
		protected override void OnCreate() {} // 0x000000018B7C71D0-0x000000018B7C720C
		protected override void OnAfterValidate() {} // 0x000000018B7C7184-0x000000018B7C71D0
		protected override void OnEnter() {} // 0x000000018B7C720C-0x000000018B7C7258
		protected override void OnUpdate(float deltaTime) {} // 0x000000018B7C72A4-0x000000018B7C74BC
		protected override void OnReverse() {} // 0x000000018B7C7258-0x000000018B7C72A4
	}

	public class MatchTransformsToTarget : ActorActionClip // TypeDefIndex: 55759
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
		public Transform targetObject; // 0x50
		public Slate.EaseType interpolation; // 0x58
		public bool matchPosition; // 0x5C
		public Vector3 positionOffset; // 0x60
		public bool matchRotation; // 0x6C
		public Vector3 rotationOffset; // 0x70
		public bool matchScale; // 0x7C
		public Vector3 scaleOffset; // 0x80
		private Vector3 lastPos; // 0x8C
		private Quaternion lastRot; // 0x98
		private Vector3 lastScale; // 0xA8
	
		// Properties
		public override string info { get => default; } // 0x000000018B7C7C80-0x000000018B7C7D20 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendOut { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public override bool isValid { get => default; } // 0x000000018B7C7D20-0x000000018B7C7D70 
	
		// Constructors
		public MatchTransformsToTarget() {} // 0x000000018B7C7C54-0x000000018B7C7C80
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7C758C-0x000000018B7C7668
		protected override void OnUpdate(float deltaTime) {} // 0x000000018B7C774C-0x000000018B7C7C54
		protected override void OnReverse() {} // 0x000000018B7C7668-0x000000018B7C774C
	}

	public class Noise : ActorActionClip // TypeDefIndex: 55760
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
		public Vector3 seed; // 0x4C
		public Vector3 amplitude; // 0x58
		public float frequency; // 0x64
		private Vector3 wasPosition; // 0x68
	
		// Properties
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendOut { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
	
		// Constructors
		public Noise() {} // 0x000000018B7C83A4-0x000000018B7C83E0
	
		// Methods
		protected override void OnCreate() {} // 0x000000018B7C8104-0x000000018B7C817C
		protected override void OnEnter() {} // 0x000000018B7C817C-0x000000018B7C81CC
		protected override void OnUpdate(float time, float previousTime) {} // 0x000000018B7C81CC-0x000000018B7C83A4
	}

	public class RotateAround : ActorActionClip // TypeDefIndex: 55761
	{
		// Fields
		private float _length; // 0x40
		public Vector3 rotation; // 0x44
		public bool perSecond; // 0x50
		public bool lookTarget; // 0x51
		public Slate.EaseType interpolation; // 0x54
		public TransformRefPosition targetPosition; // 0x58
		private Vector3 wasPosition; // 0x78
		private Quaternion wasRotation; // 0x84
		private Vector3 targetWasPosition; // 0x94
	
		// Properties
		public Vector3 targetPositionVector { get => default; set {} } // 0x000000018B7C7558-0x000000018B7C758C 0x0000000185FD28A0-0x0000000185FD28B0
		public override string info { get => default; } // 0x000000018B7CA87C-0x000000018B7CA964 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; } // 0x000000018B7C5E1C-0x000000018B7C5E2C 
	
		// Constructors
		public RotateAround() {} // 0x000000018B7CA84C-0x000000018B7CA87C
	
		// Methods
		protected override void OnAfterValidate() {} // 0x000000018B7CA290-0x000000018B7CA2DC
		protected override void OnEnter() {} // 0x000000018B7CA2DC-0x000000018B7CA3E8
		protected override void OnUpdate(float time) {} // 0x000000018B7CA478-0x000000018B7CA84C
		protected override void OnReverse() {} // 0x000000018B7CA3E8-0x000000018B7CA478
	}

	public class RotateBy : ActorActionClip // TypeDefIndex: 55762
	{
		// Fields
		private float _length; // 0x40
		public Vector3 rotation; // 0x44
		public bool perSecond; // 0x50
		public Slate.EaseType interpolation; // 0x54
		private Vector3 originalRot; // 0x58
	
		// Properties
		public override string info { get => default; } // 0x000000018B7CAC48-0x000000018B7CACF8 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; } // 0x000000018B7C5E1C-0x000000018B7C5E2C 
	
		// Constructors
		public RotateBy() {} // 0x000000018B7CAC18-0x000000018B7CAC48
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7CA964-0x000000018B7CA9E8
		protected override void OnUpdate(float time) {} // 0x000000018B7CAA78-0x000000018B7CAC18
		protected override void OnReverse() {} // 0x000000018B7CA9E8-0x000000018B7CAA78
	}

	public class RotateTo : ActorActionClip // TypeDefIndex: 55763
	{
		// Fields
		private float _length; // 0x40
		public Vector3 targetRotation; // 0x44
		public Slate.EaseType interpolation; // 0x50
		private Vector3 originalRot; // 0x54
	
		// Properties
		public override string info { get => default; } // 0x000000018B7CAEFC-0x000000018B7CAF68 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; } // 0x000000018B7C5E1C-0x000000018B7C5E2C 
	
		// Constructors
		public RotateTo() {} // 0x000000018B7C540C-0x000000018B7C5424
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7CACF8-0x000000018B7CAD48
		protected override void OnUpdate(float deltaTime) {} // 0x000000018B7CAD9C-0x000000018B7CAEFC
		protected override void OnReverse() {} // 0x000000018B7CAD48-0x000000018B7CAD9C
	}

	public class ScaleBy : ActorActionClip // TypeDefIndex: 55764
	{
		// Fields
		private float _length; // 0x40
		public Vector3 scale; // 0x44
		public bool perSecond; // 0x50
		public Slate.EaseType interpolation; // 0x54
		private Vector3 originalScale; // 0x58
	
		// Properties
		public override string info { get => default; } // 0x000000018B7CB76C-0x000000018B7CB81C 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; } // 0x000000018B7C5E1C-0x000000018B7C5E2C 
	
		// Constructors
		public ScaleBy() {} // 0x000000018B7CB73C-0x000000018B7CB76C
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7CB518-0x000000018B7CB568
		protected override void OnUpdate(float deltaTime) {} // 0x000000018B7CB5BC-0x000000018B7CB73C
		protected override void OnReverse() {} // 0x000000018B7CB568-0x000000018B7CB5BC
	}

	public class ScaleTo : ActorActionClip // TypeDefIndex: 55765
	{
		// Fields
		private float _length; // 0x40
		public Vector3 targetScale; // 0x44
		public Slate.EaseType interpolation; // 0x50
		private Vector3 originalPos; // 0x54
	
		// Properties
		public override string info { get => default; } // 0x000000018B7CBA20-0x000000018B7CBA8C 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; } // 0x000000018B7C5E1C-0x000000018B7C5E2C 
	
		// Constructors
		public ScaleTo() {} // 0x000000018B7C540C-0x000000018B7C5424
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7CB81C-0x000000018B7CB86C
		protected override void OnUpdate(float deltaTime) {} // 0x000000018B7CB8C0-0x000000018B7CBA20
		protected override void OnReverse() {} // 0x000000018B7CB86C-0x000000018B7CB8C0
	}

	public class SetParentTemporary : ActorActionClip // TypeDefIndex: 55766
	{
		// Fields
		public float _length; // 0x40
		public Transform newParent; // 0x48
		public bool matchPosition; // 0x50
		public bool matchRotation; // 0x51
		public bool matchScale; // 0x52
		private Transform originalParent; // 0x58
		private Vector3 originalPos; // 0x60
		private Quaternion originalRot; // 0x6C
		private Vector3 originalScale; // 0x7C
	
		// Properties
		public override string info { get => default; } // 0x000000018B7CCA88-0x000000018B7CCB28 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
	
		// Constructors
		public SetParentTemporary() {} // 0x000000018B7AF1A8-0x000000018B7AF1B8
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7CC6B8-0x000000018B7CC7C4
		protected override void OnUpdate(float deltaTime) {} // 0x000000018B7CC8D4-0x000000018B7CCA88
		protected override void OnReverse() {} // 0x000000018B7CC7C4-0x000000018B7CC8D4
	}

	public class SetTransformParent : ActorActionClip // TypeDefIndex: 55767
	{
		// Fields
		private float _length; // 0x40
		public Transform newParent; // 0x48
		public bool resetPosition; // 0x50
		public bool resetRotation; // 0x51
		public bool resetScale; // 0x52
		private Transform originalParent; // 0x58
		private Vector3 originalPos; // 0x60
		private Quaternion originalRot; // 0x6C
		private Vector3 originalScale; // 0x7C
		private bool temporary; // 0x88
	
		// Properties
		public override string info { get => default; } // 0x000000018B7CD420-0x000000018B7CD4C0 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
	
		// Constructors
		public SetTransformParent() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7CD3BC-0x000000018B7CD3F0
		protected override void OnReverseEnter() {} // 0x000000018B7CD404-0x000000018B7CD418
		protected override void OnExit() {} // 0x000000018B7CD3F0-0x000000018B7CD404
		protected override void OnReverse() {} // 0x000000018B7CD418-0x000000018B7CD420
		private void Do() {} // 0x000000018B7CD160-0x000000018B7CD3BC
		private void UnDo() {} // 0x000000018B7CC7C4-0x000000018B7CC8D4
	}

	public class SetTransformValues : ActorActionClip // TypeDefIndex: 55768
	{
		// Fields
		public MiniTransformSpace space; // 0x40
		public bool setPosition; // 0x44
		public Vector3 position; // 0x48
		public bool setRotation; // 0x54
		public Vector3 rotation; // 0x58
		public bool setScale; // 0x64
		public Vector3 scale; // 0x68
		private TransformSnapshot undo; // 0x78
	
		// Constructors
		public SetTransformValues() {} // 0x000000018B7CD6AC-0x000000018B7CD6D0
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7CD4C0-0x000000018B7CD68C
		protected override void OnReverse() {} // 0x000000018B7CD68C-0x000000018B7CD6AC
	}

	public class SimpleGrounder : ActorActionClip // TypeDefIndex: 55769
	{
		// Fields
		private float _length; // 0x40
		public float maxCheckDistance; // 0x44
		public float offset; // 0x48
		private RaycastHit hit; // 0x50
		private Vector3 lastPos; // 0x90
	
		// Properties
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
	
		// Constructors
		public SimpleGrounder() {} // 0x000000018B7CD9F0-0x000000018B7CDA0C
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7CD6D0-0x000000018B7CD728
		protected override void OnUpdate(float time) {} // 0x000000018B7CD780-0x000000018B7CD9F0
		protected override void OnReverse() {} // 0x000000018B7CD728-0x000000018B7CD780
	}

	public class TranslateBy : ActorActionClip // TypeDefIndex: 55770
	{
		// Fields
		private float _length; // 0x40
		public Vector3 translation; // 0x44
		public bool perSecond; // 0x50
		public Slate.EaseType interpolation; // 0x54
		private Vector3 originalPos; // 0x58
	
		// Properties
		public override string info { get => default; } // 0x000000018B7CE6BC-0x000000018B7CE76C 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; } // 0x000000018B7C5E1C-0x000000018B7C5E2C 
	
		// Constructors
		public TranslateBy() {} // 0x000000018B7CE68C-0x000000018B7CE6BC
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7CE468-0x000000018B7CE4B8
		protected override void OnUpdate(float deltaTime) {} // 0x000000018B7CE50C-0x000000018B7CE68C
		protected override void OnReverse() {} // 0x000000018B7CE4B8-0x000000018B7CE50C
	}

	public class TranslateTo : ActorActionClip // TypeDefIndex: 55771
	{
		// Fields
		private float _length; // 0x40
		public Vector3 targetPosition; // 0x44
		public MiniTransformSpace space; // 0x50
		public Slate.EaseType interpolation; // 0x54
		private Vector3 wasPosition; // 0x58
	
		// Properties
		public override string info { get => default; } // 0x000000018B7CE9A4-0x000000018B7CEA10 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; } // 0x000000018B7C5E1C-0x000000018B7C5E2C 
	
		// Constructors
		public TranslateTo() {} // 0x000000018B7CE98C-0x000000018B7CE9A4
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7CE76C-0x000000018B7CE7BC
		protected override void OnUpdate(float time) {} // 0x000000018B7CE810-0x000000018B7CE98C
		protected override void OnReverse() {} // 0x000000018B7CE7BC-0x000000018B7CE810
	}

	public class AdditiveScene : DirectorActionClip, ISubClipContainable // TypeDefIndex: 55772
	{
		// Fields
		private float _length; // 0x40
		protected string _scenePath; // 0x48
		public Vector3 scenePosition; // 0x50
		public Vector3 sceneRotation; // 0x5C
		public MiniTransformSpace space; // 0x68
		public bool updateRootCutscenes; // 0x6C
		public float timeOffset; // 0x70
		private Scene subScene; // 0x74
		private List<Cutscene> rootCutscenes; // 0x78
		private bool temporary; // 0x80
		private bool waitLoad; // 0x81
	
		// Properties
		float ISubClipContainable.subClipOffset { get => default; set {} } // 0x0000000185FB89C0-0x0000000185FB89D0 0x0000000185FBD310-0x0000000185FBD320
		float ISubClipContainable.subClipLength { get => default; } // 0x0000000183908D00-0x0000000183908D10 
		float ISubClipContainable.subClipSpeed { get => default; } // 0x0000000183908D00-0x0000000183908D10 
		public override bool isValid { get => default; } // 0x000000018B7C3110-0x000000018B7C3128 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		new string IDirectable.name { get => default; } // 0x00000001864746E4-0x00000001864746EC 
	
		// Constructors
		public AdditiveScene() {} // 0x000000018B7C30FC-0x000000018B7C3110
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7C2F80-0x000000018B7C2FB4
		protected override void OnReverseEnter() {} // 0x000000018B7C2FE8-0x000000018B7C2FFC
		protected override void OnUpdate(float time) {} // 0x000000018B7C3020-0x000000018B7C30FC
		protected override void OnExit() {} // 0x000000018B7C2FB4-0x000000018B7C2FE8
		protected override void OnReverse() {} // 0x000000018B7C2FFC-0x000000018B7C3020
		private void Activate() {} // 0x000000018B7C2890-0x000000018B7C2924
		private void Deactivate() {} // 0x000000018B7C29A8-0x000000018B7C2A1C
		private string CleanPath(string path) => default; // 0x000000018B7C2924-0x000000018B7C29A8
		private void InitializeSubSceneCutscenes() {} // 0x000000018B7C2BE8-0x000000018B7C2F80
		private void DenitializeSubSceneCutscenes(bool forward) {} // 0x000000018B7C2A1C-0x000000018B7C2BE8
	}

	public class SubCutscene : DirectorActionClip, ISubClipContainable // TypeDefIndex: 55773
	{
		// Fields
		private float _length; // 0x40
		public Cutscene subCutscene; // 0x48
		public float subCutsceneTimeOffset; // 0x50
		private bool wasCamTrackActive; // 0x54
	
		// Properties
		public override string info { get => default; } // 0x000000018B7CE24C-0x000000018B7CE314 
		public override bool isValid { get => default; } // 0x000000018B7CE314-0x000000018B7CE380 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public new GameObject actor { get => default; } // 0x000000018B7CE208-0x000000018B7CE24C 
		float ISubClipContainable.subClipOffset { get => default; set {} } // 0x0000000185FB3000-0x0000000185FB3010 0x0000000185FB3010-0x0000000185FB3020
		float ISubClipContainable.subClipLength { get => default; } // 0x000000018B7CE190-0x000000018B7CE1CC 
		float ISubClipContainable.subClipSpeed { get => default; } // 0x000000018B7CE1CC-0x000000018B7CE208 
		new string IDirectable.name { get => default; } // 0x00000001864746E4-0x00000001864746EC 
	
		// Constructors
		public SubCutscene() {} // 0x000000018B7AF1A8-0x000000018B7AF1B8
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7CDE68-0x000000018B7CDF30
		protected override void OnReverseEnter() {} // 0x000000018B7CDFD8-0x000000018B7CE0A4
		protected override void OnExit() {} // 0x000000018B7CDF30-0x000000018B7CDFD8
		protected override void OnReverse() {} // 0x000000018B7CE0A4-0x000000018B7CE144
		protected override void OnUpdate(float time, float previousTime) {} // 0x000000018B7CE144-0x000000018B7CE190
	}

	public class DestroyGameObjects : DirectorActionClip // TypeDefIndex: 55774
	{
		// Fields
		public List<GameObject> targetObjects; // 0x40
	
		// Properties
		public override string info { get => default; } // 0x000000018B7C6120-0x000000018B7C619C 
	
		// Constructors
		public DestroyGameObjects() {} // 0x000000018B7C60A0-0x000000018B7C6120
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7C5F4C-0x000000018B7C60A0
	}

	public class DirectorDisableGameObjects : DirectorActionClip // TypeDefIndex: 55775
	{
		// Fields
		public List<GameObject> targetObjects; // 0x40
		private Dictionary<GameObject, bool> states; // 0x48
	
		// Properties
		public override string info { get => default; } // 0x000000018B7C6570-0x000000018B7C65EC 
	
		// Constructors
		public DirectorDisableGameObjects() {} // 0x000000018B7C64F0-0x000000018B7C6570
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7C619C-0x000000018B7C6364
		protected override void OnReverse() {} // 0x000000018B7C6364-0x000000018B7C64F0
	}

	public class DirectorEnableGameObjects : DirectorActionClip // TypeDefIndex: 55776
	{
		// Fields
		public List<GameObject> targetObjects; // 0x40
		private Dictionary<GameObject, bool> states; // 0x48
	
		// Properties
		public override string info { get => default; } // 0x000000018B7C69C0-0x000000018B7C6A3C 
	
		// Constructors
		public DirectorEnableGameObjects() {} // 0x000000018B7C6940-0x000000018B7C69C0
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7C65EC-0x000000018B7C67B4
		protected override void OnReverse() {} // 0x000000018B7C67B4-0x000000018B7C6940
	}

	public class InstantiateObject : DirectorActionClip // TypeDefIndex: 55777
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
		public GameObject targetObject; // 0x50
		public Transform optionalParent; // 0x58
		public Vector3 targetPosition; // 0x60
		public Vector3 targetRotation; // 0x6C
		public MiniTransformSpace space; // 0x78
		public Slate.EaseType popupInterpolation; // 0x7C
		private GameObject instance; // 0x80
		private Vector3 wasScale; // 0x88
	
		// Properties
		public override bool isValid { get => default; } // 0x000000018B7C7134-0x000000018B7C7184 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendOut { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public override string info { get => default; } // 0x000000018B7C7094-0x000000018B7C7134 
		private new GameObject actor { get => default; } // 0x000000018140CF50-0x000000018140CF60 
	
		// Constructors
		public InstantiateObject() {} // 0x000000018B7C707C-0x000000018B7C7094
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7C6B2C-0x000000018B7C6E3C
		protected override void OnUpdate(float time) {} // 0x000000018B7C6F2C-0x000000018B7C707C
		protected override void OnExit() {} // 0x000000018B7C6E3C-0x000000018B7C6EA0
		protected override void OnReverseEnter() {} // 0x000000018B7C6EA0-0x000000018B7C6ED8
		protected override void OnReverse() {} // 0x000000018B7C6ED8-0x000000018B7C6F2C
	}

	public class SampleParticleSystem : DirectorActionClip // TypeDefIndex: 55778
	{
		// Fields
		private float _length; // 0x40
		public ParticleSystem particles; // 0x48
		public bool simulationSync; // 0x50
		private ParticleSystem.EmissionModule em; // 0x58
	
		// Properties
		public override string info { get => default; } // 0x000000018B7CB21C-0x000000018B7CB334 
		public override bool isValid { get => default; } // 0x000000018B7CB334-0x000000018B7CB384 
		public override float length { get => default; set {} } // 0x000000018B7CB384-0x000000018B7CB414 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendOut { get => default; } // 0x000000018B7CB150-0x000000018B7CB198 
		private bool loop { get => default; } // 0x000000018B7CB414-0x000000018B7CB494 
		private float duration { get => default; } // 0x000000018B7CB198-0x000000018B7CB21C 
		private float startLifetime { get => default; } // 0x000000018B7CB494-0x000000018B7CB518 
	
		// Constructors
		public SampleParticleSystem() {} // 0x000000018B7CB13C-0x000000018B7CB150
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7CAF68-0x000000018B7CAF70
		protected override void OnReverseEnter() {} // 0x000000018B7CAF68-0x000000018B7CAF70
		protected override void OnExit() {} // 0x000000018B7CAF70-0x000000018B7CAF78
		protected override void OnReverse() {} // 0x000000018B7CAF70-0x000000018B7CAF78
		protected override void OnRootEnabled() {} // 0x000000018B7CAFC4-0x000000018B7CB014
		protected override void OnRootDisabled() {} // 0x000000018B7CAF78-0x000000018B7CAFC4
		private void Play() {} // 0x000000018B7CB080-0x000000018B7CB0FC
		protected override void OnUpdate(float time) {} // 0x000000018B7CB014-0x000000018B7CB080
		private void Stop() {} // 0x000000018B7CB0FC-0x000000018B7CB13C
	}

	public class TransitAudioMixerSnapshot : DirectorActionClip // TypeDefIndex: 55779
	{
		// Fields
		private float _length; // 0x40
		public AudioMixer audioMixer; // 0x48
		public string snapshotName; // 0x50
		private AudioMixerSnapshot snapshot; // 0x58
	
		// Properties
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; } // 0x000000018B7C5E1C-0x000000018B7C5E2C 
		public override bool isValid { get => default; } // 0x000000018B7CE418-0x000000018B7CE468 
	
		// Constructors
		public TransitAudioMixerSnapshot() {} // 0x000000018B7AF1A8-0x000000018B7AF1B8
	
		// Methods
		protected override void OnReverseEnter() {} // 0x000000018B7CE410-0x000000018B7CE418
		protected override void OnEnter() {} // 0x000000018B7CE410-0x000000018B7CE418
		private void Do() {} // 0x000000018B7CE380-0x000000018B7CE410
	}

	public class AnimateAmbientLighting : DirectorActionClip // TypeDefIndex: 55780
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
		public float ambientIntensity; // 0x4C
		public UnityEngine.Color ambientColor; // 0x50
		private float wasIntensity; // 0x60
		private UnityEngine.Color wasColor; // 0x64
	
		// Properties
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendOut { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
	
		// Constructors
		public AnimateAmbientLighting() {} // 0x000000018B7AF1A8-0x000000018B7AF1B8
	
		// Methods
		protected override void OnCreate() {} // 0x000000018B7C3128-0x000000018B7C3158
		protected override void OnEnter() {} // 0x000000018B7C3158-0x000000018B7C3188
		protected override void OnUpdate(float time) {} // 0x000000018B7C31B8-0x000000018B7C3238
		protected override void OnReverse() {} // 0x000000018B7C3188-0x000000018B7C31B8
	}

	public class AnimateFog : DirectorActionClip // TypeDefIndex: 55781
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
		public UnityEngine.Color fogColor; // 0x4C
		public float fogDensity; // 0x5C
		public float linearFogStartDistance; // 0x60
		public float linearFogEndDistance; // 0x64
		private UnityEngine.Color wasColor; // 0x68
		private float wasDensity; // 0x78
		private float wasStartDistance; // 0x7C
		private float wasEndDistance; // 0x80
	
		// Properties
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendOut { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
	
		// Constructors
		public AnimateFog() {} // 0x000000018B7AF1A8-0x000000018B7AF1B8
	
		// Methods
		protected override void OnCreate() {} // 0x000000018B7C364C-0x000000018B7C3694
		protected override void OnEnter() {} // 0x000000018B7C3694-0x000000018B7C36E0
		protected override void OnUpdate(float time) {} // 0x000000018B7C372C-0x000000018B7C37E0
		protected override void OnReverse() {} // 0x000000018B7C36E0-0x000000018B7C372C
	}

	public class AnimateGravity : DirectorActionClip // TypeDefIndex: 55782
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
		public Vector3 gravity; // 0x4C
		private Vector3 wasGravity; // 0x58
	
		// Properties
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendOut { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
	
		// Constructors
		public AnimateGravity() {} // 0x000000018B7AF1A8-0x000000018B7AF1B8
	
		// Methods
		protected override void OnCreate() {} // 0x000000018B7C37E0-0x000000018B7C380C
		protected override void OnEnter() {} // 0x000000018B7C380C-0x000000018B7C3838
		protected override void OnUpdate(float time) {} // 0x000000018B7C38C4-0x000000018B7C39A8
		protected override void OnReverse() {} // 0x000000018B7C3838-0x000000018B7C38C4
	}

	public class AnimateTimeScale : DirectorActionClip // TypeDefIndex: 55783
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
		public float timeScale; // 0x4C
		public Slate.EaseType interpolation; // 0x50
		private float wasScale; // 0x54
	
		// Properties
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendOut { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
	
		// Constructors
		public AnimateTimeScale() {} // 0x000000018B7C540C-0x000000018B7C5424
	
		// Methods
		protected override void OnCreate() {} // 0x000000018B7C5424-0x000000018B7C5440
		protected override void OnEnter() {} // 0x000000018B7C5440-0x000000018B7C545C
		protected override void OnUpdate(float time) {} // 0x000000018B7C5468-0x000000018B7C54D8
		protected override void OnReverse() {} // 0x000000018B7C545C-0x000000018B7C5468
	}

	public class EasySlowMotion : DirectorActionClip // TypeDefIndex: 55784
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
		public float timeScale; // 0x4C
		public Slate.EaseType interpolation; // 0x50
		private float lastTimeScale; // 0x54
	
		// Properties
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendOut { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public override string info { get => default; } // 0x000000018B7C6AD0-0x000000018B7C6B2C 
	
		// Constructors
		public EasySlowMotion() {} // 0x000000018B7C6AA4-0x000000018B7C6AD0
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7C5440-0x000000018B7C545C
		protected override void OnUpdate(float deltaTime) {} // 0x000000018B7C6A3C-0x000000018B7C6AA4
		protected override void OnReverse() {} // 0x000000018B7C545C-0x000000018B7C5468
	}

	public class RaiseUnityEvent : DirectorActionClip // TypeDefIndex: 55785
	{
		// Fields
		public string customLabel; // 0x40
		public UnityEvent forwardEvent; // 0x48
		public UnityEvent reverseEvent; // 0x50
	
		// Properties
		public override string info { get => default; } // 0x000000018B7CA06C-0x000000018B7CA290 
	
		// Constructors
		public RaiseUnityEvent() {} // 0x000000018B7C9FD0-0x000000018B7CA06C
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7C9F90-0x000000018B7C9FB0
		protected override void OnReverse() {} // 0x000000018B7C9FB0-0x000000018B7C9FD0
	}

	public abstract class SendGlobalMessage<T> : SendGlobalMessage // TypeDefIndex: 55786
	{
		// Fields
		public T value;
	
		// Properties
		public override string info { get; }
	
		// Constructors
		protected SendGlobalMessage() {}
	
		// Methods
		protected override void OnEnter() {}
	}

	public class SendGlobalMessage : DirectorActionClip, IEvent // TypeDefIndex: 55787
	{
		// Fields
		public string message; // 0x40
	
		// Properties
		public override string info { get => default; } // 0x000000018B7CC0FC-0x000000018B7CC13C 
		public override bool isValid { get => default; } // 0x0000000189D8F4C0-0x0000000189D8F4D8 
		string IEvent.name { get => default; } // 0x00000001813FF010-0x00000001813FF020 
	
		// Constructors
		public SendGlobalMessage() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		void IEvent.Invoke() {} // 0x000000018B3F462C-0x000000018B3F463C
		protected override void OnEnter() {} // 0x000000018B7CC0BC-0x000000018B7CC0FC
	}

	public class SendGlobalMessageBoolean : SendGlobalMessage<bool> // TypeDefIndex: 55788
	{
		// Constructors
		public SendGlobalMessageBoolean() {} // 0x000000018B7CBFB8-0x000000018B7CBFEC
	}

	public class SendGlobalMessageFloat : SendGlobalMessage<float> // TypeDefIndex: 55789
	{
		// Constructors
		public SendGlobalMessageFloat() {} // 0x000000018B7CBFEC-0x000000018B7CC020
	}

	public class SendGlobalMessageInteger : SendGlobalMessage<int> // TypeDefIndex: 55790
	{
		// Constructors
		public SendGlobalMessageInteger() {} // 0x000000018B7CC020-0x000000018B7CC054
	}

	public class SendGlobalMessageObject : SendGlobalMessage<UnityEngine.Object> // TypeDefIndex: 55791
	{
		// Constructors
		public SendGlobalMessageObject() {} // 0x000000018B7CC054-0x000000018B7CC088
	}

	public class SendGlobalMessageString : SendGlobalMessage<string> // TypeDefIndex: 55792
	{
		// Constructors
		public SendGlobalMessageString() {} // 0x000000018B7CC088-0x000000018B7CC0BC
	}

	public class Captions : DirectorActionClip // TypeDefIndex: 55793
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
		public string text; // 0x50
		public UnityEngine.Color color; // 0x58
		public Slate.EaseType interpolation; // 0x68
	
		// Properties
		public override string info { get => default; } // 0x000000018B7C5D14-0x000000018B7C5D54 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendOut { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
	
		// Constructors
		public Captions() {} // 0x000000018B7C5CA0-0x000000018B7C5D14
	
		// Methods
		protected override void OnUpdate(float deltaTime) {} // 0x000000018B7C5C2C-0x000000018B7C5CA0
	}

	public class CineBox : DirectorActionClip // TypeDefIndex: 55794
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
	
		// Properties
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendOut { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
	
		// Constructors
		public CineBox() {} // 0x000000018B7C5D6C-0x000000018B7C5D88
	
		// Methods
		protected override void OnUpdate(float time) {} // 0x000000018B7C5D54-0x000000018B7C5D6C
	}

	public class OverlayText : DirectorActionClip // TypeDefIndex: 55795
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
		public string text; // 0x50
		public TextAnchor anchor; // 0x58
		public Slate.EaseType interpolation; // 0x5C
		public UnityEngine.Color color; // 0x60
		public float size; // 0x70
		public Vector2 position; // 0x74
	
		// Properties
		public override string info { get => default; } // 0x000000018B7C84F8-0x000000018B7C8538 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendOut { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
	
		// Constructors
		public OverlayText() {} // 0x000000018B7C8474-0x000000018B7C84F8
	
		// Methods
		protected override void OnUpdate(float time) {} // 0x000000018B7C83E0-0x000000018B7C8474
	}

	public class OverlayTexture : DirectorActionClip // TypeDefIndex: 55796
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
		public Texture texture; // 0x50
		public UnityEngine.Color color; // 0x58
		public Vector2 scale; // 0x68
		public Vector2 position; // 0x70
		public Slate.EaseType interpolation; // 0x78
	
		// Properties
		public override string info { get => default; } // 0x000000018B7C8624-0x000000018B7C86C4 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendOut { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
	
		// Constructors
		public OverlayTexture() {} // 0x000000018B7C85D4-0x000000018B7C8624
	
		// Methods
		protected override void OnUpdate(float deltaTime) {} // 0x000000018B7C8538-0x000000018B7C85D4
	}

	public class ScreenFader : DirectorActionClip // TypeDefIndex: 55797
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
		public float fade; // 0x4C
		public UnityEngine.Color outColor; // 0x50
		public Slate.EaseType interpolation; // 0x60
		private UnityEngine.Color lastColor; // 0x64
	
		// Properties
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendOut { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
	
		// Constructors
		public ScreenFader() {} // 0x000000018B7CBB38-0x000000018B7CBB84
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7CBA8C-0x000000018B7CBAAC
		protected override void OnUpdate(float deltaTime) {} // 0x000000018B7CBACC-0x000000018B7CBB38
		protected override void OnReverse() {} // 0x000000018B7CBAAC-0x000000018B7CBACC
	}

	public class AnimatePlaybackSpeed : DirectorActionClip // TypeDefIndex: 55798
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
		public float speed; // 0x4C
		public Slate.EaseType interpolation; // 0x50
		private float wasSpeed; // 0x54
	
		// Properties
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendOut { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
	
		// Constructors
		public AnimatePlaybackSpeed() {} // 0x000000018B7C540C-0x000000018B7C5424
	
		// Methods
		protected override void OnCreate() {} // 0x000000018B7C52E4-0x000000018B7C5314
		protected override void OnEnter() {} // 0x000000018B7C5314-0x000000018B7C5344
		protected override void OnUpdate(float time) {} // 0x000000018B7C5374-0x000000018B7C540C
		protected override void OnReverse() {} // 0x000000018B7C5344-0x000000018B7C5374
	}

	public class DebugLog : DirectorActionClip // TypeDefIndex: 55799
	{
		// Fields
		public bool neverSkip; // 0x40
		public string text; // 0x48
	
		// Properties
		public override string info { get => default; } // 0x000000018B7C5F0C-0x000000018B7C5F4C 
	
		// Constructors
		public DebugLog() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7C5E6C-0x000000018B7C5F0C
	}

	public class PauseCutscene : DirectorActionClip // TypeDefIndex: 55800
	{
		// Constructors
		public PauseCutscene() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7C86C4-0x000000018B7C8790
	}

	public class ScreenCapture : DirectorActionClip // TypeDefIndex: 55801
	{
		// Constructors
		public ScreenCapture() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public class PlayAnimationClip : ActorActionClip<Animation>, ISubClipContainable // TypeDefIndex: 55802
	{
		// Fields
		private float _length; // 0x48
		private float _blendIn; // 0x4C
		private float _blendOut; // 0x50
		public AnimationClip animationClip; // 0x58
		public float clipOffset; // 0x60
		public float playbackSpeed; // 0x64
		private TransformSnapshot snapShot; // 0x68
		private Transform mixTransform; // 0x70
		private UnityEngine.AnimationState state; // 0x78
		private bool isListClip; // 0x80
	
		// Properties
		float ISubClipContainable.subClipOffset { get => default; set {} } // 0x0000000185FB2200-0x0000000185FB2210 0x0000000185FB2230-0x0000000185FB2240
		float ISubClipContainable.subClipLength { get => default; } // 0x000000018B7C8D80-0x000000018B7C8DF0 
		float ISubClipContainable.subClipSpeed { get => default; } // 0x0000000185FB2210-0x0000000185FB2220 
		public override string info { get => default; } // 0x000000018B7C8E34-0x000000018B7C8EA8 
		public override bool isValid { get => default; } // 0x000000018B7C8EA8-0x000000018B7C8F38 
		public override float length { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public override float blendIn { get => default; set {} } // 0x0000000185FB1750-0x0000000185FB1760 0x0000000185FBFAC0-0x0000000185FBFAD0
		public override float blendOut { get => default; set {} } // 0x0000000185FB3000-0x0000000185FB3010 0x0000000185FB3010-0x0000000185FB3020
		public override bool canCrossBlend { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		private AnimationTrack track { get => default; } // 0x000000018B7C8F38-0x000000018B7C8F74 
		new string IDirectable.name { get => default; } // 0x00000001864746E4-0x00000001864746EC 
	
		// Constructors
		public PlayAnimationClip() {} // 0x000000018B7C8DF0-0x000000018B7C8E34
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7C8790-0x000000018B7C8978
		protected override void OnUpdate(float time) {} // 0x000000018B7C8A40-0x000000018B7C8D80
		protected override void OnReverse() {} // 0x000000018B7C89C0-0x000000018B7C8A40
		protected override void OnExit() {} // 0x000000018B7C8978-0x000000018B7C899C
		protected override void OnReverseEnter() {} // 0x000000018B7C899C-0x000000018B7C89C0
	}

	public class PlayAnimatorClip : ActorActionClip, ISubClipContainable // TypeDefIndex: 55805
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
		public AnimationClip animationClip; // 0x50
		public float clipOffset; // 0x58
		public ClipWrapMode clipWrapMode; // 0x5C
		public float clipWeight; // 0x60
		public float playbackSpeed; // 0x64
		public StartingTransformsMode startingTransformsMode; // 0x68
		public MiniTransformSpace transformSpace; // 0x6C
		public Vector3 startingPosition; // 0x70
		public Vector3 startingRotation; // 0x7C
		public Vector2 steerLocalRotation; // 0x88
		protected Vector3 wasPosition; // 0x90
		protected Quaternion wasRotation; // 0x9C
	
		// Properties
		private bool isMasterAndManualSet { get => default; } // 0x000000018B7C988C-0x000000018B7C98B0 
		float ISubClipContainable.subClipOffset { get => default; set {} } // 0x0000000181DE2580-0x0000000181DE2590 0x0000000181DE28C0-0x0000000181DE28D0
		float ISubClipContainable.subClipLength { get => default; } // 0x000000018B7C9764-0x000000018B7C97D4 
		float ISubClipContainable.subClipSpeed { get => default; } // 0x0000000185FB2210-0x0000000185FB2220 
		public override string info { get => default; } // 0x000000018B7C9814-0x000000018B7C988C 
		public override bool isValid { get => default; } // 0x000000018B7C98D4-0x000000018B7C9980 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendOut { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public override bool canCrossBlend { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		protected AnimatorTrack track { get => default; } // 0x000000018B7C9980-0x000000018B7C99BC 
		protected Animator animator { get => default; } // 0x000000018B7C97F0-0x000000018B7C9814 
		protected bool isMasterTrack { get => default; } // 0x000000018B7C98B0-0x000000018B7C98D4 
		new string IDirectable.name { get => default; } // 0x00000001864746E4-0x00000001864746EC 
	
		// Nested types
		public enum StartingTransformsMode // TypeDefIndex: 55803
		{
			AutoMatchTransforms = 0,
			ManualSetTransforms = 1
		}
	
		public enum ClipWrapMode // TypeDefIndex: 55804
		{
			Loop = 0,
			PingPong = 1
		}
	
		// Constructors
		public PlayAnimatorClip() {} // 0x000000018B7C97D4-0x000000018B7C97F0
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7C8F74-0x000000018B7C9198
		protected override void OnReverseEnter() {} // 0x000000018B7C91FC-0x000000018B7C9260
		protected override void OnUpdate(float time, float previousTime) {} // 0x000000018B7C9340-0x000000018B7C9764
		protected override void OnExit() {} // 0x000000018B7C9198-0x000000018B7C91FC
		protected override void OnReverse() {} // 0x000000018B7C9260-0x000000018B7C9340
	}

	public class PlayAudio : ActionClip, ISubClipContainable // TypeDefIndex: 55806
	{
		// Fields
		private float _length; // 0x40
		private float _blendIn; // 0x44
		private float _blendOut; // 0x48
		public AudioClip audioClip; // 0x50
		public float volume; // 0x58
		public float pitch; // 0x5C
		public float stereoPan; // 0x60
		public float clipOffset; // 0x64
		public string subtitlesText; // 0x68
		public UnityEngine.Color subtitlesColor; // 0x70
	
		// Properties
		float ISubClipContainable.subClipOffset { get => default; set {} } // 0x0000000185FB2210-0x0000000185FB2220 0x0000000185FB2220-0x0000000185FB2230
		float ISubClipContainable.subClipLength { get => default; } // 0x000000018B7C9D20-0x000000018B7C9D90 
		float ISubClipContainable.subClipSpeed { get => default; } // 0x0000000185FB2DD0-0x0000000185FB2DE0 
		public override float length { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
		public override float blendIn { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public override float blendOut { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public override bool isValid { get => default; } // 0x000000018B7C9EE4-0x000000018B7C9F34 
		public override string info { get => default; } // 0x000000018B7C9E5C-0x000000018B7C9EE4 
		private Slate.AudioTrack track { get => default; } // 0x000000018B7C9F54-0x000000018B7C9F90 
		private AudioSource source { get => default; } // 0x000000018B7C9F34-0x000000018B7C9F54 
		new string IDirectable.name { get => default; } // 0x00000001864746E4-0x00000001864746EC 
	
		// Constructors
		public PlayAudio() {} // 0x000000018B7C9E10-0x000000018B7C9E5C
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7C9A40-0x000000018B7C9A48
		protected override void OnReverseEnter() {} // 0x000000018B7C9A40-0x000000018B7C9A48
		protected override void OnExit() {} // 0x000000018B7C9A48-0x000000018B7C9A50
		protected override void OnReverse() {} // 0x000000018B7C9A48-0x000000018B7C9A50
		private void Do() {} // 0x000000018B7C99BC-0x000000018B7C9A40
		protected override void OnUpdate(float time, float previousTime) {} // 0x000000018B7C9A50-0x000000018B7C9D20
		private void Undo() {} // 0x000000018B7C9D90-0x000000018B7C9E10
	}

	public class AnimateBoolParameter : MecanimBaseClip // TypeDefIndex: 55807
	{
		// Fields
		private float _length; // 0x48
		public string parameterName; // 0x50
		public bool value; // 0x58
		private bool lastValue; // 0x59
	
		// Properties
		public override bool isValid { get => default; } // 0x000000018B7C3410-0x000000018B7C3440 
		public override string info { get => default; } // 0x000000018B7C33D0-0x000000018B7C3410 
		public override float length { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
	
		// Constructors
		public AnimateBoolParameter() {} // 0x000000018B7C33BC-0x000000018B7C33D0
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7C3238-0x000000018B7C3290
		protected override void OnUpdate(float time) {} // 0x000000018B7C3364-0x000000018B7C33BC
		protected override void OnExit() {} // 0x000000018B7C3290-0x000000018B7C3300
		protected override void OnReverse() {} // 0x000000018B7C3300-0x000000018B7C3364
	}

	public class AnimateFloatParameter : MecanimBaseClip // TypeDefIndex: 55808
	{
		// Fields
		private float _length; // 0x48
		private float _blendIn; // 0x4C
		private float _blendOut; // 0x50
		public string parameterName; // 0x58
		public float value; // 0x60
		private float lastValue; // 0x64
	
		// Properties
		public override bool isValid { get => default; } // 0x000000018B7C361C-0x000000018B7C364C 
		public override string info { get => default; } // 0x000000018B7C35DC-0x000000018B7C361C 
		public override float length { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public override float blendIn { get => default; set {} } // 0x0000000185FB1750-0x0000000185FB1760 0x0000000185FBFAC0-0x0000000185FBFAD0
		public override float blendOut { get => default; set {} } // 0x0000000185FB3000-0x0000000185FB3010 0x0000000185FB3010-0x0000000185FB3020
	
		// Constructors
		public AnimateFloatParameter() {} // 0x000000018B7C35B8-0x000000018B7C35DC
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7C3440-0x000000018B7C349C
		protected override void OnUpdate(float deltaTime) {} // 0x000000018B7C3500-0x000000018B7C35B8
		protected override void OnReverse() {} // 0x000000018B7C349C-0x000000018B7C3500
	}

	public class AnimateIntegerParameter : MecanimBaseClip // TypeDefIndex: 55809
	{
		// Fields
		private float _length; // 0x48
		private float _blendIn; // 0x4C
		private float _blendOut; // 0x50
		public string parameterName; // 0x58
		public int value; // 0x60
		private int lastValue; // 0x64
	
		// Properties
		public override bool isValid { get => default; } // 0x000000018B7C361C-0x000000018B7C364C 
		public override string info { get => default; } // 0x000000018B7C3B3C-0x000000018B7C3B7C 
		public override float length { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public override float blendIn { get => default; set {} } // 0x0000000185FB1750-0x0000000185FB1760 0x0000000185FBFAC0-0x0000000185FBFAD0
		public override float blendOut { get => default; set {} } // 0x0000000185FB3000-0x0000000185FB3010 0x0000000185FB3010-0x0000000185FB3020
	
		// Constructors
		public AnimateIntegerParameter() {} // 0x000000018B7C3B20-0x000000018B7C3B3C
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7C39A8-0x000000018B7C3A00
		protected override void OnUpdate(float deltaTime) {} // 0x000000018B7C3A64-0x000000018B7C3B20
		protected override void OnReverse() {} // 0x000000018B7C3A00-0x000000018B7C3A64
	}

	public class AnimateLayerWeight : MecanimBaseClip // TypeDefIndex: 55810
	{
		// Fields
		private float _length; // 0x48
		private float _blendIn; // 0x4C
		private float _blendOut; // 0x50
		public int layerIndex; // 0x54
		public float weight; // 0x58
		private float lastValue; // 0x5C
	
		// Properties
		public override string info { get => default; } // 0x000000018B7C3D14-0x000000018B7C3D74 
		public override float length { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public override float blendIn { get => default; set {} } // 0x0000000185FB1750-0x0000000185FB1760 0x0000000185FBFAC0-0x0000000185FBFAD0
		public override float blendOut { get => default; set {} } // 0x0000000185FB3000-0x0000000185FB3010 0x0000000185FB3010-0x0000000185FB3020
	
		// Constructors
		public AnimateLayerWeight() {} // 0x000000018B7C3CF0-0x000000018B7C3D14
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7C3B7C-0x000000018B7C3BD4
		protected override void OnUpdate(float deltaTime) {} // 0x000000018B7C3C38-0x000000018B7C3CF0
		protected override void OnReverse() {} // 0x000000018B7C3BD4-0x000000018B7C3C38
	}

	public class AnimateLimbIK : ActorActionClip<Animator> // TypeDefIndex: 55812
	{
		// Fields
		private float _length; // 0x48
		private float _blendIn; // 0x4C
		private float _blendOut; // 0x50
		public AvatarIKGoal IKGoal; // 0x54
		public float weight; // 0x58
		public TransformRefPositionRotation IKTarget; // 0x60
		private AnimatorDispatcher dispatcher; // 0x90
	
		// Properties
		public Vector3 targetPosition { get => default; set {} } // 0x000000018B7C4648-0x000000018B7C467C 0x0000000185FD5D30-0x0000000185FD5D50
		public Vector3 targetRotation { get => default; set {} } // 0x000000018B7C45A4-0x000000018B7C4614 0x0000000185FB80E0-0x0000000185FB80F0
		public override string info { get => default; } // 0x0000000185FBCE20-0x0000000185FBCE30 
		public override float length { get => default; set {} } // 0x0000000185FB1750-0x0000000185FB1760 0x0000000185FBFAC0-0x0000000185FBFAD0
		public override float blendIn { get => default; set {} } // 0x0000000185FB3000-0x0000000185FB3010 0x0000000185FB3010-0x0000000185FB3020
		public override float blendOut { get => default; set {} } // 0x000000018B7C4184-0x000000018B7C41C0 0x000000018B7C3D74-0x000000018B7C3FC0
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 55811
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018B7C4614-0x000000018B7C4648
			public __c() {} // 0x0000000185FD5C80-0x0000000185FD5C90
		}
	
		// Constructors
		public AnimateLimbIK() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void OnCreate() {} // 0x000000018B7C41C0-0x000000018B7C42B8
		protected override void OnAfterValidate() {} // 0x000000018B7C434C-0x000000018B7C4444
		protected override void OnEnter() {} // 0x000000018B7C4444-0x000000018B7C44D8
		protected override void OnReverseEnter() {} // 0x000000018B7C42B8-0x000000018B7C434C
		protected override void OnReverse() {} // 0x000000018B7C44D8-0x000000018B7C4550
		protected override void OnExit() {} // 0x000000018B7C3FC0-0x000000018B7C4184
		protected override void OnRootDisabled() {} // 0x000000018B7C4550-0x000000018B7C45A4
		private void OnAnimatorIK(int index) {} // 0x000000018B7CEA74-0x000000018B7CEAD8
	}

	public class AnimateLookAtIK : ActorActionClip<Animator> // TypeDefIndex: 55814
	{
		// Fields
		private float _length; // 0x48
		private float _blendIn; // 0x4C
		private float _blendOut; // 0x50
		public float weight; // 0x54
		public float bodyWeight; // 0x58
		public float headWeight; // 0x5C
		public float eyesWeight; // 0x60
		public TransformRefPosition targetPosition; // 0x68
		private AnimatorDispatcher dispatcher; // 0x88
	
		// Properties
		public Vector3 targetPositionVector { get => default; set {} } // 0x000000018B7C4D70-0x000000018B7C4D9C 0x0000000185FB80E0-0x0000000185FB80F0
		public override string info { get => default; } // 0x0000000185FBCE20-0x0000000185FBCE30 
		public override float length { get => default; set {} } // 0x0000000185FB1750-0x0000000185FB1760 0x0000000185FBFAC0-0x0000000185FBFAD0
		public override float blendIn { get => default; set {} } // 0x0000000185FB3000-0x0000000185FB3010 0x0000000185FB3010-0x0000000185FB3020
		public override float blendOut { get => default; set {} } // 0x000000018B7C4944-0x000000018B7C4984 0x000000018B7C467C-0x000000018B7C4800
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 55813
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018B7C4D9C-0x000000018B7C4DD0
			public __c() {} // 0x0000000185FD5D50-0x0000000185FD5D70
		}
	
		// Constructors
		public AnimateLookAtIK() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void OnCreate() {} // 0x000000018B7C4984-0x000000018B7C4A7C
		protected override void OnAfterValidate() {} // 0x000000018B7C4B10-0x000000018B7C4C08
		protected override void OnEnter() {} // 0x000000018B7C4C08-0x000000018B7C4C9C
		protected override void OnReverseEnter() {} // 0x000000018B7C4A7C-0x000000018B7C4B10
		protected override void OnReverse() {} // 0x000000018B7C4C9C-0x000000018B7C4D14
		protected override void OnExit() {} // 0x000000018B7C4800-0x000000018B7C4944
		protected override void OnRootDisabled() {} // 0x000000018B7C4D14-0x000000018B7C4D70
		private void OnAnimatorIK(int index) {} // 0x000000018B7CEA10-0x000000018B7CEA74
	}

	public class AnimateTrigger : MecanimBaseClip // TypeDefIndex: 55815
	{
		// Fields
		private float _length; // 0x48
		public string triggerName; // 0x50
		public bool value; // 0x58
	
		// Properties
		public override bool isValid { get => default; } // 0x000000018B7C3410-0x000000018B7C3440 
		public override string info { get => default; } // 0x000000018B7C5560-0x000000018B7C55A0 
		public override float length { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
	
		// Constructors
		public AnimateTrigger() {} // 0x000000018B7C5550-0x000000018B7C5560
	
		// Methods
		protected override void OnUpdate(float time) {} // 0x000000018B7C54D8-0x000000018B7C5550
	}

	public class CrossFadeState : MecanimBaseClip // TypeDefIndex: 55816
	{
		// Fields
		private float _length; // 0x48
		public string stateName; // 0x50
	
		// Properties
		public override string info { get => default; } // 0x000000018B7C5E2C-0x000000018B7C5E6C 
		public override float length { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public override float blendIn { get => default; } // 0x000000018B7C5E1C-0x000000018B7C5E2C 
	
		// Constructors
		public CrossFadeState() {} // 0x000000018B7C5550-0x000000018B7C5560
	
		// Methods
		protected override void OnEnter() {} // 0x000000018B7C5D88-0x000000018B7C5E1C
	}

	public abstract class MecanimBaseClip : ActorActionClip<Animator> // TypeDefIndex: 55818
	{
		// Properties
		public override bool isValid { get; } // 0x000000018B7C801C-0x000000018B7C8050 
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 55817
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0() {} // 0x000000018B7C8050-0x000000018B7C8104
	
			// Methods
			internal bool _HasParameter_b__0(AnimatorControllerParameter p) => default; // 0x000000018B7C7D70-0x000000018B7C801C
		}
	
		// Constructors
		protected MecanimBaseClip() {} // 0x0000000187C26954-0x0000000187C2697C
	
		// Methods
		protected bool HasParameter(string name) => default; // 0x0000000185492010-0x0000000185492020
	}
}
