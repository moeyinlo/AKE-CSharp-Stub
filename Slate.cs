/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using Slate;
using Slate.ActionClips;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.Video;

// Image 36: Slate.dll - Assembly: Slate, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58187-58459
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Slate
{
	public class DirectorCamera : MonoBehaviour, IDirectableCamera // TypeDefIndex: 58188
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private bool _matchMainWhenActive; // 0x18
		[HideInInspector]
		[SerializeField]
		private bool _setMainWhenActive; // 0x19
		[HideInInspector]
		[SerializeField]
		private bool _autoHandleActiveState; // 0x1A
		[HideInInspector]
		[SerializeField]
		private bool _ignoreFOVChanges; // 0x1B
		[HideInInspector]
		[SerializeField]
		private bool _dontDestroyOnLoad; // 0x1C
		public const float MAX_DAMP = 3f; // Metadata: 0x0234BBBC
		[CompilerGenerated]
		private static Action<IDirectableCamera> onCut; // 0x00
		[CompilerGenerated]
		private static Action onActivate; // 0x08
		[CompilerGenerated]
		private static Action onDeactivate; // 0x10
		private static DirectorCamera _current; // 0x18
		private static Camera _cam; // 0x20
		private static IDirectableCamera lastTargetShot; // 0x28
		[CompilerGenerated]
		private float _focalDistance_k__BackingField; // 0x20
		[CompilerGenerated]
		private float _focalLength_k__BackingField; // 0x24
		[CompilerGenerated]
		private float _focalAperture_k__BackingField; // 0x28
		[CompilerGenerated]
		private static GameCamera _gameCamera_k__BackingField; // 0x30
		[CompilerGenerated]
		private static bool _isEnabled_k__BackingField; // 0x38
		private static float noiseTimer; // 0x3C
		private static Vector3 noisePosOffset; // 0x40
		private static Vector3 noiseRotOffset; // 0x4C
		private static Vector3 noiseTargetPosOffset; // 0x58
		private static Vector3 noiseTargetRotOffset; // 0x64
		private static Vector3 noiseCamPosVel; // 0x70
		private static Vector3 noiseCamRotVel; // 0x7C
	
		// Properties
		public static DirectorCamera current { get; } // 0x000000018AC62EEC-0x000000018AC630D0 
		public Camera cam { get; } // 0x000000018AC62DBC-0x000000018AC62EEC 
		public Vector3 position { get; set; } // 0x000000018AC63200-0x000000018AC63254 0x000000018AC63668-0x000000018AC636BC
		public Quaternion rotation { get; set; } // 0x000000018AC63278-0x000000018AC632C4 0x000000018AC636BC-0x000000018AC63708
		public float fieldOfView { get; set; } // 0x000000018AC630F0-0x000000018AC63150 0x000000018AC63528-0x000000018AC63590
		public float focalDistance { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811EC8A0-0x00000001811EC8B0 0x00000001811EC9E0-0x00000001811EC9F0
		public float focalLength { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D89850-0x0000000184D89860 0x0000000184D89860-0x0000000184D89870
		public float focalAperture { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86BF0-0x0000000184D86C00 0x0000000184D86C00-0x0000000184D86C10
		public static bool matchMainWhenActive { get; set; } // 0x000000018AC631E0-0x000000018AC63200 0x000000018AC63644-0x000000018AC63668
		public static bool setMainWhenActive { get; set; } // 0x000000018AC632C4-0x000000018AC632E4 0x000000018AC63708-0x000000018AC6372C
		public static bool autoHandleActiveState { get; set; } // 0x000000018AC62D9C-0x000000018AC62DBC 0x000000018AC634E0-0x000000018AC63504
		public static bool ignoreFOVChanges { get; set; } // 0x000000018AC63188-0x000000018AC631A8 0x000000018AC635E4-0x000000018AC63608
		public static bool dontDestroyOnLoad { get; set; } // 0x000000018AC630D0-0x000000018AC630F0 0x000000018AC63504-0x000000018AC63528
		public static Camera renderCamera { get; } // 0x000000018AC63254-0x000000018AC63278 
		public static GameCamera gameCamera { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018AC63150-0x000000018AC63188 0x000000018AC63590-0x000000018AC635E4
		public static bool isEnabled { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018AC631A8-0x000000018AC631E0 0x000000018AC63608-0x000000018AC63644
		GameObject IDirectableCamera.gameObject { get; } // 0x00000001853916BC-0x00000001853916C4 
	
		// Events
		public static event Action<IDirectableCamera> onCut {
			add; // 0x000000018AC62C50-0x000000018AC62CEC
			remove; // 0x000000018AC63394-0x000000018AC63430
		}
		public static event Action onActivate {
			add; // 0x000000018AC62BA0-0x000000018AC62C50
			remove; // 0x000000018AC632E4-0x000000018AC63394
		}
		public static event Action onDeactivate {
			add; // 0x000000018AC62CEC-0x000000018AC62D9C
			remove; // 0x000000018AC63430-0x000000018AC634E0
		}
	
		// Constructors
		public DirectorCamera(); // 0x0000000184D77850-0x0000000184D77870
	
		// Methods
		private void Awake(); // 0x000000018AC61CC8-0x000000018AC61DEC
		private Camera CreateRenderCamera(); // 0x000000018AC61DEC-0x000000018AC61F84
		public static void Enable(); // 0x000000018AC620AC-0x000000018AC624C8
		public static void Disable(); // 0x000000018AC61F84-0x000000018AC620AC
		public static void Update(IDirectableCamera source, IDirectableCamera target, Slate.EaseType interpolation, float weight, float damping = 0f /* Metadata: 0x0234BBB8 */); // 0x000000018AC624C8-0x000000018AC62BA0
		public static void ApplyNoise(float magnitude, float weight); // 0x000000018AC618DC-0x000000018AC61CC8
	}

	[ExecuteInEditMode]
	public class DirectorGUI : MonoBehaviour // TypeDefIndex: 58195
	{
		// Fields
		[CompilerGenerated]
		private static SubtitlesGUIDelegate OnSubtitlesGUI; // 0x00
		[CompilerGenerated]
		private static TextOverlayGUIDelegate OnTextOverlayGUI; // 0x08
		[CompilerGenerated]
		private static ImageOverlayGUIDelegate OnImageOverlayGUI; // 0x10
		[CompilerGenerated]
		private static ScreenFadeGUIDelegate OnScreenFadeGUI; // 0x18
		[CompilerGenerated]
		private static LetterboxGUIDelegate OnLetterboxGUI; // 0x20
		[CompilerGenerated]
		private static CameraDissolveDelegate OnCameraDissolve; // 0x28
		[CompilerGenerated]
		private static Action OnGUIEnable; // 0x30
		[CompilerGenerated]
		private static Action OnGUIDisable; // 0x38
		[NonSerialized]
		private static DirectorGUI _current; // 0x40
		[CompilerGenerated]
		private static UnityEngine.Color _lastFadeColor_k__BackingField; // 0x48
	
		// Properties
		public static DirectorGUI current { get; } // 0x000000018AC641D8-0x000000018AC64364 
		public static UnityEngine.Color lastFadeColor { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018AC64364-0x000000018AC643A8 0x000000018AC64920-0x000000018AC64960
	
		// Events
		public static event SubtitlesGUIDelegate OnSubtitlesGUI {
			add; // 0x000000018AC64080-0x000000018AC64128
			remove; // 0x000000018AC647C8-0x000000018AC64870
		}
		public static event TextOverlayGUIDelegate OnTextOverlayGUI {
			add; // 0x000000018AC64128-0x000000018AC641D8
			remove; // 0x000000018AC64870-0x000000018AC64920
		}
		public static event ImageOverlayGUIDelegate OnImageOverlayGUI {
			add; // 0x000000018AC63E70-0x000000018AC63F20
			remove; // 0x000000018AC645B8-0x000000018AC64668
		}
		public static event ScreenFadeGUIDelegate OnScreenFadeGUI {
			add; // 0x000000018AC63FD0-0x000000018AC64080
			remove; // 0x000000018AC64718-0x000000018AC647C8
		}
		public static event LetterboxGUIDelegate OnLetterboxGUI {
			add; // 0x000000018AC63F20-0x000000018AC63FD0
			remove; // 0x000000018AC64668-0x000000018AC64718
		}
		public static event CameraDissolveDelegate OnCameraDissolve {
			add; // 0x000000018AC63C60-0x000000018AC63D10
			remove; // 0x000000018AC643A8-0x000000018AC64458
		}
		public static event Action OnGUIEnable {
			add; // 0x000000018AC63DC0-0x000000018AC63E70
			remove; // 0x000000018AC64508-0x000000018AC645B8
		}
		public static event Action OnGUIDisable {
			add; // 0x000000018AC63D10-0x000000018AC63DC0
			remove; // 0x000000018AC64458-0x000000018AC64508
		}
	
		// Nested types
		public delegate void SubtitlesGUIDelegate(string text, UnityEngine.Color color); // TypeDefIndex: 58189; 0x0000000183A1B910-0x0000000183A1B940
	
		public delegate void TextOverlayGUIDelegate(string text, UnityEngine.Color color, float size, TextAnchor alignment, Vector2 position); // TypeDefIndex: 58190; 0x000000018AC670AC-0x000000018AC670F4
	
		public delegate void ImageOverlayGUIDelegate(Texture texture, UnityEngine.Color color, Vector2 scale, Vector2 position); // TypeDefIndex: 58191; 0x000000018AC659B0-0x000000018AC659E8
	
		public delegate void ScreenFadeGUIDelegate(UnityEngine.Color color); // TypeDefIndex: 58192; 0x0000000182B0B020-0x0000000182B0B050
	
		public delegate void LetterboxGUIDelegate(float completion); // TypeDefIndex: 58193; 0x0000000182B46B90-0x0000000182B46BA0
	
		public delegate void CameraDissolveDelegate(Texture texture, float completion); // TypeDefIndex: 58194; 0x00000001838E1420-0x00000001838E1430
	
		// Constructors
		public DirectorGUI(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Awake(); // 0x000000018AC6372C-0x000000018AC6380C
		private void OnEnable(); // 0x000000018AC63920-0x000000018AC63964
		private void OnDisable(); // 0x000000018AC6380C-0x000000018AC63920
		public static void UpdateLetterbox(float completion); // 0x000000018AC63A58-0x000000018AC63AB4
		public static void UpdateDissolve(Texture texture, float completion); // 0x000000018AC63964-0x000000018AC639C8
		public static void UpdateFade(UnityEngine.Color color); // 0x000000018AC639C8-0x000000018AC63A58
		public static void UpdateSubtitles(string text, UnityEngine.Color color); // 0x000000018AC63BF4-0x000000018AC63C60
		public static void UpdateOverlayText(string text, UnityEngine.Color color, float size, TextAnchor anchor, Vector2 pos); // 0x000000018AC63B50-0x000000018AC63BF4
		public static void UpdateOverlayImage(Texture texture, UnityEngine.Color color, Vector2 scale, Vector2 positionOffset); // 0x000000018AC63AB4-0x000000018AC63B50
	}

	[Serializable]
	public class DynamicCameraController // TypeDefIndex: 58201
	{
		// Fields
		private const float MIN_DAMP = 0.5f; // Metadata: 0x0234BBC0
		private const float MAX_DAMP = 10f; // Metadata: 0x0234BBC4
		[SerializeField]
		private Transposer _transposer; // 0x10
		[SerializeField]
		private Composer _composer; // 0x18
		private int lastUpdateFrame; // 0x20
	
		// Properties
		public Transposer transposer { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public Composer composer { get; } // 0x000000018385B100-0x000000018385B110 
		public bool controlsPosition { get; } // 0x000000018AC65748-0x000000018AC65760 
		public bool controlsRotation { get; } // 0x000000018AC65760-0x000000018AC65778 
		public bool controlsFieldOfView { get; } // 0x000000018AC6572C-0x000000018AC65748 
	
		// Nested types
		[Serializable]
		public class Transposer // TypeDefIndex: 58198
		{
			// Fields
			public TrackingMode trackingMode; // 0x10
			[Tooltip("The Target from which an offset will be applied.")]
			public Transform target; // 0x18
			[Tooltip("The offset from the target to mount the camera to.")]
			public Vector3 targetOffset; // 0x20
			[Tooltip("Is the offset relative to the target\'s Local or World Space?")]
			public OffsetMode offsetMode; // 0x2C
			[Tooltip("The starting point of the rail")]
			public Vector3 railStart; // 0x30
			[Tooltip("The end point of the rail")]
			public Vector3 railEnd; // 0x3C
			[Tooltip("Optional forwards/backwards offset on the rail")]
			public float railOffset; // 0x48
			[Range(0.5f, 10f)]
			[Tooltip("The smoothness to be applied.")]
			public float smoothDamping; // 0x4C
	
			// Nested types
			public enum TrackingMode // TypeDefIndex: 58196
			{
				None = 0,
				OffsetTracking = 1,
				RailTracking = 2
			}
	
			public enum OffsetMode // TypeDefIndex: 58197
			{
				LocalSpace = 0,
				WorldSpace = 1
			}
	
			// Constructors
			public Transposer(); // 0x0000000184DA9C30-0x0000000184DA9C90
		}
	
		[Serializable]
		public class Composer // TypeDefIndex: 58200
		{
			// Fields
			public TrackingMode trackingMode; // 0x10
			[Tooltip("The target subject we want to stay within the composition frame.")]
			public Transform target; // 0x18
			[Tooltip("The point of interest offset from the target in it\'s local space we actually care about to stay within the composition frame.")]
			public Vector3 targetOffset; // 0x20
			[Slate.Min(0f)]
			[Tooltip("The point of interest area size to stay within the composition frame.")]
			public float targetSize; // 0x2C
			[Tooltip("The center of the view frame")]
			public Vector2 frameCenter; // 0x30
			[Tooltip("The extends/size of the view frame")]
			public Vector2 frameExtends; // 0x38
			[Range(-80f, 80f)]
			[Tooltip("Tilt camera angles")]
			public float dutchTilt; // 0x40
			[Tooltip("Will try zoom to match view frame with target interest frame")]
			public bool zoomAtTargetFrame; // 0x44
			[Range(0.5f, 10f)]
			[Tooltip("The smoothness to be applied.")]
			public float smoothDamping; // 0x48
	
			// Nested types
			public enum TrackingMode // TypeDefIndex: 58199
			{
				None = 0,
				FrameComposition = 1
			}
	
			// Constructors
			public Composer(); // 0x0000000184DA9B90-0x0000000184DA9BB0
		}
	
		// Constructors
		public DynamicCameraController(); // 0x000000018AC65680-0x000000018AC6572C
	
		// Methods
		public void UpdateControllerHard(IDirectableCamera directableCamera, IDirectable directable); // 0x000000018AC649FC-0x000000018AC64A18
		public void UpdateControllerSoft(IDirectableCamera directableCamera, IDirectable directable); // 0x000000018AC64A18-0x000000018AC64A34
		private void UpdateController(IDirectableCamera directableCamera, IDirectable directable, bool isHard); // 0x000000018AC64A34-0x000000018AC65680
	}

	public class GameCamera : MonoBehaviour, IDirectableCamera // TypeDefIndex: 58202
	{
		// Fields
		private Camera _cam; // 0x18
	
		// Properties
		public Camera cam { get; } // 0x000000018AC65778-0x000000018AC65804 
		public Vector3 position { get; set; } // 0x000000018AC65864-0x000000018AC658AC 0x00000001841E1670-0x00000001841E1680
		public Quaternion rotation { get; set; } // 0x000000018AC658AC-0x000000018AC658F0 0x00000001841E1670-0x00000001841E1680
		public float fieldOfView { get; set; } // 0x000000018AC65804-0x000000018AC65864 0x00000001841E1670-0x00000001841E1680
		public float focalDistance { get; set; } // 0x0000000184DA9C10-0x0000000184DA9C20 0x00000001841E1670-0x00000001841E1680
		public float focalLength { get; set; } // 0x0000000184DA9C20-0x0000000184DA9C30 0x00000001841E1670-0x00000001841E1680
		public float focalAperture { get; set; } // 0x0000000184DA9C00-0x0000000184DA9C10 0x00000001841E1670-0x00000001841E1680
		GameObject IDirectableCamera.gameObject { get; } // 0x00000001853916BC-0x00000001853916C4 
	
		// Constructors
		public GameCamera(); // 0x0000000185393520-0x0000000185393538
	}

	public interface IDirectableCamera // TypeDefIndex: 58203
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

	[AddComponentMenu("SLATE/Shot Camera")]
	[RequireComponent(typeof(Camera))]
	public class ShotCamera : MonoBehaviour, IDirectableCamera // TypeDefIndex: 58205
	{
		// Fields
		public const string DEFAULT_NAME = "Shot Camera"; // Metadata: 0x0234BBCF
		[SerializeField]
		private DynamicCameraController _dynamicController; // 0x18
		[FormerlySerializedAs("_focalPoint")]
		[SerializeField]
		private float _focalDistance; // 0x20
		[FormerlySerializedAs("_focalRange")]
		[SerializeField]
		private float _focalLength; // 0x24
		[SerializeField]
		private float _focalAperture; // 0x28
		private Camera _cam; // 0x30
	
		// Properties
		public Camera cam { get; } // 0x000000018AC66B18-0x000000018AC66BA4 
		public Vector3 position { get; set; } // 0x000000018AC65864-0x000000018AC658AC 0x000000018AC66E18-0x000000018AC66E5C
		public Quaternion rotation { get; set; } // 0x000000018AC658AC-0x000000018AC658F0 0x0000000186C5993C-0x0000000186C59978
		public Vector3 localPosition { get; set; } // 0x000000018AC66CC0-0x000000018AC66D08 0x000000018AC66DD4-0x000000018AC66E18
		public Vector3 localEulerAngles { get; set; } // 0x000000018AC66C4C-0x000000018AC66CC0 0x000000018AC66D60-0x000000018AC66DD4
		public float fieldOfView { get; set; } // 0x000000018AC66BEC-0x000000018AC66C4C 0x000000018AC66D08-0x000000018AC66D60
		public float focalDistance { get; set; } // 0x00000001811EC8A0-0x00000001811EC8B0 0x00000001811EC9E0-0x00000001811EC9F0
		public float focalLength { get; set; } // 0x0000000184D89850-0x0000000184D89860 0x0000000184D89860-0x0000000184D89870
		public float focalAperture { get; set; } // 0x0000000184D86BF0-0x0000000184D86C00 0x0000000184D86C00-0x0000000184D86C10
		public DynamicCameraController dynamicController { get; } // 0x000000018385B100-0x000000018385B110 
		public bool dynamicControlledPosition { get; } // 0x000000018AC66BBC-0x000000018AC66BD4 
		public bool dynamicControlledRotation { get; } // 0x000000018AC66BD4-0x000000018AC66BEC 
		public bool dynamicControlledFieldOfView { get; } // 0x000000018AC66BA4-0x000000018AC66BBC 
		GameObject IDirectableCamera.gameObject { get; } // 0x00000001853916BC-0x00000001853916C4 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass47_0 // TypeDefIndex: 58204
		{
			// Fields
			public string shotName; // 0x10
	
			// Constructors
			public __c__DisplayClass47_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _Find_b__0(ShotCamera s); // 0x000000018AC6738C-0x000000018AC673C4
		}
	
		// Constructors
		public ShotCamera(); // 0x000000018AC66A94-0x000000018AC66B18
	
		// Methods
		private void Awake(); // 0x000000018AC663CC-0x000000018AC664C0
		public void UpdateDynamicControllerHard(IDirectable directable); // 0x000000018AC66A44-0x000000018AC66A6C
		public void UpdateDynamicControllerSoft(IDirectable directable); // 0x000000018AC66A6C-0x000000018AC66A94
		public void SetDynamicControllerTargets(Transform target); // 0x000000018AC66A38-0x000000018AC66A44
		public void SetDynamicControllerTargets(Transform transposerTarget, Transform composerTarget); // 0x000000018AC669E4-0x000000018AC66A38
		public RenderTexture GetRenderTexture(int width, int height); // 0x000000018AC66840-0x000000018AC669E4
		public static ShotCamera Create(Transform targetParent = null); // 0x000000018AC664C0-0x000000018AC66748
		public static ShotCamera Find(string shotName); // 0x000000018AC66748-0x000000018AC66840
	}

	[Serializable]
	public class BlendShape // TypeDefIndex: 58206
	{
		// Fields
		[SerializeField]
		private SkinnedMeshRenderer _skin; // 0x10
		[SerializeField]
		private string _name; // 0x18
		[SerializeField]
		private float _weight; // 0x20
	
		// Properties
		public SkinnedMeshRenderer skin { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public string name { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public float weight { get; set; } // 0x00000001811EC8A0-0x00000001811EC8B0 0x00000001811EC9E0-0x00000001811EC9F0
	
		// Constructors
		public BlendShape(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void SetRealWeight(float modWeight); // 0x000000018AC5A754-0x000000018AC5A820
		public override string ToString(); // 0x000000018385B100-0x000000018385B110
	}

	[Serializable]
	public class BlendShapeGroup // TypeDefIndex: 58207
	{
		// Fields
		[SerializeField]
		private string _UID; // 0x10
		[SerializeField]
		private string _name; // 0x18
		[SerializeField]
		private float _weight; // 0x20
		[SerializeField]
		private List<BlendShape> _blendShapes; // 0x28
	
		// Properties
		public string UID { get; private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public string name { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public float weight { get; set; } // 0x00000001811EC8A0-0x00000001811EC8B0 0x000000018AC5A748-0x000000018AC5A754
		public List<BlendShape> blendShapes { get; } // 0x0000000184D86240-0x0000000184D86250 
	
		// Constructors
		public BlendShapeGroup(); // 0x000000018AC5A67C-0x000000018AC5A748
	
		// Methods
		private void SetBlendWeights(); // 0x000000018AC5A5FC-0x000000018AC5A67C
		public override string ToString(); // 0x000000018385B100-0x000000018385B110
	}

	[AddComponentMenu("SLATE/Character")]
	public class Character : MonoBehaviour // TypeDefIndex: 58210
	{
		// Fields
		[SerializeField]
		private List<BlendShapeGroup> _expressions; // 0x18
		[SerializeField]
		private Transform _neckTransform; // 0x20
		[SerializeField]
		private Transform _headTransform; // 0x28
		[SerializeField]
		private Vector3 _upVector; // 0x30
		[SerializeField]
		private Vector3 _rotationOffset; // 0x3C
	
		// Properties
		public Transform neck { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public Transform head { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public Vector3 upVector { get; set; } // 0x0000000184D88ED0-0x0000000184D88EF0 0x0000000184D88F10-0x0000000184D88F20
		public Vector3 rotationOffset { get; set; } // 0x0000000184D88EB0-0x0000000184D88ED0 0x0000000184D88F00-0x0000000184D88F10
		public List<BlendShapeGroup> expressions { get; } // 0x000000018385B100-0x000000018385B110 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 58208
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass19_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _FindExpressionByName_b__0(BlendShapeGroup x); // 0x000000018AC672D4-0x000000018AC672F0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 58209
		{
			// Fields
			public string UID; // 0x10
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _FindExpressionByUID_b__0(BlendShapeGroup x); // 0x000000018AC672F0-0x000000018AC6730C
		}
	
		// Constructors
		public Character(); // 0x000000018AC5C9B8-0x000000018AC5CA64
	
		// Methods
		public BlendShapeGroup FindExpressionByName(string name); // 0x000000018AC5C730-0x000000018AC5C800
		public BlendShapeGroup FindExpressionByUID(string UID); // 0x000000018AC5C800-0x000000018AC5C8D0
		public void SetExpressionWeightByName(string name, float weight); // 0x000000018AC5C950-0x000000018AC5C984
		public void SetExpressionWeightByUID(string UID, float weight); // 0x000000018AC5C984-0x000000018AC5C9B8
		public void ResetExpressions(); // 0x000000018AC5C8D0-0x000000018AC5C950
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class NameAttribute : Attribute // TypeDefIndex: 58211
	{
		// Fields
		public readonly string name; // 0x10
	
		// Constructors
		public NameAttribute(string name); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class CategoryAttribute : Attribute // TypeDefIndex: 58212
	{
		// Fields
		public readonly string category; // 0x10
	
		// Constructors
		public CategoryAttribute(string category); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class DescriptionAttribute : Attribute // TypeDefIndex: 58213
	{
		// Fields
		public readonly string description; // 0x10
	
		// Constructors
		public DescriptionAttribute(string description); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class IconAttribute : Attribute // TypeDefIndex: 58214
	{
		// Fields
		public readonly string iconName; // 0x10
		public readonly System.Type fromType; // 0x18
	
		// Constructors
		public IconAttribute(string iconName); // 0x00000001853908C0-0x00000001853908D0
		public IconAttribute(System.Type fromType); // 0x0000000185392C40-0x0000000185392C50
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class AttachableAttribute : Attribute // TypeDefIndex: 58215
	{
		// Fields
		public readonly System.Type[] types; // 0x10
	
		// Constructors
		public AttachableAttribute(params System.Type[] types); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class UniqueElementAttribute : Attribute // TypeDefIndex: 58216
	{
		// Constructors
		public UniqueElementAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class ShowTrajectoryAttribute : Attribute // TypeDefIndex: 58217
	{
		// Constructors
		public ShowTrajectoryAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class PositionHandleAttribute : Attribute // TypeDefIndex: 58218
	{
		// Constructors
		public PositionHandleAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class RotationHandleAttribute : Attribute // TypeDefIndex: 58219
	{
		// Fields
		public readonly string positionPropertyName; // 0x10
	
		// Constructors
		public RotationHandleAttribute(string positionPropertyName); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class AnimatableParameterAttribute : PropertyAttribute // TypeDefIndex: 58220
	{
		// Fields
		public string link; // 0x10
		public readonly float? min; // 0x18
		public readonly float? max; // 0x20
		public readonly string customName; // 0x28
	
		// Constructors
		public AnimatableParameterAttribute(); // 0x00000001841E1670-0x00000001841E1680
		public AnimatableParameterAttribute(string customName); // 0x0000000182FDB880-0x0000000182FDB890
		public AnimatableParameterAttribute(string customName, float min, float max); // 0x000000018AC51244-0x000000018AC512D8
		public AnimatableParameterAttribute(float min, float max); // 0x000000018AC512D8-0x000000018AC51354
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class ParseAnimatableParametersAttribute : PropertyAttribute // TypeDefIndex: 58221
	{
		// Constructors
		public ParseAnimatableParametersAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ShaderPropertyPopupAttribute : PropertyAttribute // TypeDefIndex: 58222
	{
		// Fields
		public readonly System.Type propertyType; // 0x10
	
		// Constructors
		public ShaderPropertyPopupAttribute(); // 0x00000001841E1670-0x00000001841E1680
		public ShaderPropertyPopupAttribute(System.Type propertyType); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class LeftToggleAttribute : PropertyAttribute // TypeDefIndex: 58223
	{
		// Constructors
		public LeftToggleAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class MinAttribute : PropertyAttribute // TypeDefIndex: 58224
	{
		// Fields
		public readonly float min; // 0x10
	
		// Constructors
		public MinAttribute(float min); // 0x0000000184D88280-0x0000000184D88290
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ExampleTextAttribute : PropertyAttribute // TypeDefIndex: 58225
	{
		// Fields
		public readonly string text; // 0x10
	
		// Constructors
		public ExampleTextAttribute(string text); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class HelpBoxAttribute : PropertyAttribute // TypeDefIndex: 58226
	{
		// Fields
		public readonly string text; // 0x10
	
		// Constructors
		public HelpBoxAttribute(string text); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ShowIfAttribute : PropertyAttribute // TypeDefIndex: 58227
	{
		// Fields
		public readonly string propertyName; // 0x10
		public readonly int value; // 0x18
	
		// Constructors
		public ShowIfAttribute(string propertyName, int value); // 0x0000000183B46FF0-0x0000000183B47040
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class EnabledIfAttribute : PropertyAttribute // TypeDefIndex: 58228
	{
		// Fields
		public readonly string propertyName; // 0x10
		public readonly int value; // 0x18
	
		// Constructors
		public EnabledIfAttribute(string propertyName, int value); // 0x0000000183B46FF0-0x0000000183B47040
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class CallbackAttribute : PropertyAttribute // TypeDefIndex: 58229
	{
		// Fields
		public readonly string methodName; // 0x10
	
		// Constructors
		public CallbackAttribute(string methodName); // 0x00000001853908C0-0x00000001853908D0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class RequiredAttribute : PropertyAttribute // TypeDefIndex: 58230
	{
		// Constructors
		public RequiredAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class PlaybackProtectedAttribute : PropertyAttribute // TypeDefIndex: 58231
	{
		// Constructors
		public PlaybackProtectedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ReadOnlyAttribute : PropertyAttribute // TypeDefIndex: 58232
	{
		// Constructors
		public ReadOnlyAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class SortingLayerAttribute : PropertyAttribute // TypeDefIndex: 58233
	{
		// Constructors
		public SortingLayerAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ActorGroupPopupAttribute : PropertyAttribute // TypeDefIndex: 58234
	{
		// Constructors
		public ActorGroupPopupAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Attachable(new System.Type[1] {typeof(DirectorActionTrack) })]
	public abstract class DirectorActionClip : ActionClip // TypeDefIndex: 58235
	{
		// Constructors
		protected DirectorActionClip(); // 0x0000000185393520-0x0000000185393538
	}

	public interface IEvent // TypeDefIndex: 58236
	{
		// Properties
		string name { get; }
	
		// Methods
		void Invoke();
	}

	public enum TransformSpace // TypeDefIndex: 58237
	{
		CutsceneSpace = 0,
		ActorSpace = 1,
		WorldSpace = 2,
		ParentSpace = 3
	}

	public enum MiniTransformSpace // TypeDefIndex: 58238
	{
		CutsceneSpace = 0,
		WorldSpace = 2,
		ParentSpace = 3
	}

	public enum ActiveState // TypeDefIndex: 58239
	{
		Disable = 0,
		Enable = 1,
		Toggle = 2
	}

	[Attachable(new System.Type[1] {typeof(CameraTrack) })]
	[Description("Camera Shots can be animated directly within this clip. You don\'t need to create an Actor Group to animate the shot (even though you can if desired).")]
	public class CameraShot : DirectorActionClip // TypeDefIndex: 58243
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
		[HideInInspector]
		[SerializeField]
		private ShotCamera _targetShot; // 0x50
		[HideInInspector]
		public BlendInEffectType blendInEffect; // 0x58
		[HideInInspector]
		public BlendOutEffectType blendOutEffect; // 0x5C
		[HideInInspector]
		[Range(0f, 1f)]
		public float steadyCamEffect; // 0x60
		[HideInInspector]
		public UnityEngine.Color fadeToColor; // 0x64
		[HideInInspector]
		public UnityEngine.Color fadeFromColor; // 0x74
		[ActorGroupPopup]
		[HideInInspector]
		public ActorGroup overrideShotTargetActorGroup; // 0x88
		private UnityEngine.Color lastFadeColor; // 0x90
		[CompilerGenerated]
		private CameraShot _previousShot_k__BackingField; // 0xA0
	
		// Properties
		public override string info { get; } // 0x000000018AC5B6E8-0x000000018AC5B768 
		public override bool isValid { get; } // 0x000000018AC5B768-0x000000018AC5B7B8 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override bool canCrossBlend { get; } // 0x000000018AC5B51C-0x000000018AC5B524 
		public new GameObject actor { get; } // 0x000000018AC5B4A8-0x000000018AC5B51C 
		public CameraShot previousShot { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86210-0x0000000184D86220 0x0000000185391334-0x0000000185391348
		public ShotCamera targetShot { get; set; } // 0x0000000184D86270-0x0000000184D86280 0x000000018AC5BC48-0x000000018AC5BCC4
		private CameraTrack track { get; } // 0x000000018AC5B8E8-0x000000018AC5B924 
		[AnimatableParameter]
		public Vector3 position { get; set; } // 0x000000018AC5B7B8-0x000000018AC5B850 0x000000018AC5BB28-0x000000018AC5BBB8
		[AnimatableParameter]
		public Vector3 rotation { get; set; } // 0x000000018AC5B850-0x000000018AC5B8E8 0x000000018AC5BBB8-0x000000018AC5BC48
		[AnimatableParameter(0.01f, 170f)]
		public float fieldOfView { get; set; } // 0x000000018AC5B524-0x000000018AC5B598 0x000000018AC5B924-0x000000018AC5B9C0
		[AnimatableParameter("Focal Distance")]
		public float focalPoint { get; set; } // 0x000000018AC5B608-0x000000018AC5B678 0x000000018AC5BA38-0x000000018AC5BAB0
		[AnimatableParameter("Focal Length", 1f, 300f)]
		public float focalRange { get; set; } // 0x000000018AC5B678-0x000000018AC5B6E8 0x000000018AC5BAB0-0x000000018AC5BB28
		[AnimatableParameter(0.1f, 32f)]
		public float focalAperture { get; set; } // 0x000000018AC5B598-0x000000018AC5B608 0x000000018AC5B9C0-0x000000018AC5BA38
	
		// Nested types
		public enum BlendInEffectType // TypeDefIndex: 58240
		{
			None = 0,
			FadeFromColor = 1,
			CrossDissolve = 2,
			EaseIn = 3
		}
	
		public enum BlendOutEffectType // TypeDefIndex: 58241
		{
			None = 0,
			FadeToColor = 1
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58242
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x000000018AC67428-0x000000018AC6748C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public CameraShot(); // 0x000000018AC5B458-0x000000018AC5B4A8
	
		// Methods
		protected override void OnAfterValidate(); // 0x000000018AC5A9C8-0x000000018AC5ADAC
		protected override void OnRootEnabled(); // 0x000000018AC5AF9C-0x000000018AC5B028
		protected override void OnRootDisabled(); // 0x000000018AC5AF10-0x000000018AC5AF9C
		protected override void OnRootUpdated(float time, float previousTime); // 0x000000018AC5B028-0x000000018AC5B0B4
		public void TryUpdateShotTargetOverride(); // 0x000000018AC5B384-0x000000018AC5B458
		protected override bool OnInitialize(); // 0x000000018AC5AE98-0x000000018AC5AEAC
		protected override void OnEnter(); // 0x000000018AC5ADAC-0x000000018AC5AE98
		protected override void OnUpdate(float time, float previousTime); // 0x000000018AC5B0B4-0x000000018AC5B384
		protected override void OnReverse(); // 0x000000018AC5AEAC-0x000000018AC5AF10
	}

	[Attachable(new System.Type[1] {typeof(VideoTrack) })]
	[Description("Play an imported Video Clip on the render camera.")]
	[Name("Video Clip")]
	public class PlayVideo : ActionClip // TypeDefIndex: 58244
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
		[Required]
		public VideoClip videoClip; // 0x50
		private VideoSampler.SampleSettings settings; // 0x58
	
		// Properties
		public override bool isValid { get; } // 0x000000018AC65FF4-0x000000018AC66044 
		public override string info { get; } // 0x000000018AC65F74-0x000000018AC65FF4 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		private VideoTrack track { get; } // 0x000000018AC66044-0x000000018AC66080 
	
		// Constructors
		public PlayVideo(); // 0x000000018AC65F48-0x000000018AC65F74
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC65E38-0x000000018AC65E40
		protected override void OnReverseEnter(); // 0x000000018AC65E38-0x000000018AC65E40
		protected override void OnReverse(); // 0x000000018AC65E40-0x000000018AC65E48
		protected override void OnExit(); // 0x000000018AC65E40-0x000000018AC65E48
		private void Enable(); // 0x000000018AC65DC0-0x000000018AC65E38
		protected override void OnUpdate(float time, float previousTime); // 0x000000018AC65E48-0x000000018AC65F48
		private void Disable(); // 0x000000018AC65D94-0x000000018AC65DC0
	}

	[Description("All tracks of an Actor Group affect a specific actor GameObject or one of it\'s Components. Specifying a name manually comes in handy if you want to set the target actor of this group via scripting. The ReferenceMode along with InitialCoordinates are essential when you are working with prefab actors.")]
	public class ActorGroup : CutsceneGroup // TypeDefIndex: 58245
	{
		// Fields
		[SerializeField]
		private string _name; // 0x70
		[SerializeField]
		private GameObject _actor; // 0x78
		[SerializeField]
		private ActorReferenceMode _referenceMode; // 0x80
		[FormerlySerializedAs("_initialTransformation")]
		[SerializeField]
		private ActorInitialTransformation _initialCoordinates; // 0x84
		[SerializeField]
		[ShowIf("_initialCoordinates", 1)]
		private Vector3 _initialLocalPosition; // 0x88
		[SerializeField]
		[ShowIf("_initialCoordinates", 1)]
		private Vector3 _initialLocalRotation; // 0x94
		[SerializeField]
		[ShowIf("_initialCoordinates", 1)]
		private bool _displayVirtualMeshGizmo; // 0xA0
	
		// Properties
		public override string name { get; set; } // 0x000000018AC50F24-0x000000018AC50FBC 0x00000001863AD760-0x00000001863AD770
		public override GameObject actor { get; set; } // 0x000000018AC50F18-0x000000018AC50F24 0x000000018AC50FBC-0x000000018AC5102C
		public override ActorReferenceMode referenceMode { get; set; } // 0x0000000184D863A0-0x0000000184D863B0 0x0000000184D86420-0x0000000184D86430
		public override ActorInitialTransformation initialTransformation { get; set; } // 0x0000000184D8FCE0-0x0000000184D8FCF0 0x0000000184D8FCF0-0x0000000184D8FD00
		public override Vector3 initialLocalPosition { get; set; } // 0x0000000184DA9AD0-0x0000000184DA9AF0 0x0000000184DA9B10-0x0000000184DA9B30
		public override Vector3 initialLocalRotation { get; set; } // 0x0000000184DA9AF0-0x0000000184DA9B10 0x0000000184DA9B30-0x0000000184DA9B50
		public override bool displayVirtualMeshGizmo { get; set; } // 0x0000000184D88020-0x0000000184D88030 0x0000000184D88040-0x0000000184D88050
	
		// Constructors
		public ActorGroup(); // 0x000000018AC50EC8-0x000000018AC50F18
	}

	[Description("The DirectorGroup is the master group of the Cutscene. There is always one and can\'t be removed. The target actor of this group is always the \'Director Camera\', thus it\'s possible to add a PropertiesTrack to animate any of the components attached on the DirectorCamera game object. Usualy Image Effects.")]
	public class DirectorGroup : CutsceneGroup // TypeDefIndex: 58246
	{
		// Properties
		public override string name { get; set; } // 0x000000018AC649D0-0x000000018AC649FC 0x00000001841E1670-0x00000001841E1680
		public override GameObject actor { get; set; } // 0x000000018AC649AC-0x000000018AC649D0 0x00000001841E1670-0x00000001841E1680
		public override ActorReferenceMode referenceMode { get; set; } // 0x00000001811EC580-0x00000001811EC590 0x00000001841E1670-0x00000001841E1680
		public override ActorInitialTransformation initialTransformation { get; set; } // 0x00000001811EC580-0x00000001811EC590 0x00000001841E1670-0x00000001841E1680
		public override Vector3 initialLocalPosition { get; set; } // 0x0000000189D954F8-0x0000000189D95510 0x00000001841E1670-0x00000001841E1680
		public override Vector3 initialLocalRotation { get; set; } // 0x0000000189D954F8-0x0000000189D95510 0x00000001841E1670-0x00000001841E1680
		public override bool displayVirtualMeshGizmo { get; set; } // 0x00000001812081B0-0x0000000181208610 0x00000001841E1670-0x00000001841E1680
	
		// Constructors
		public DirectorGroup(); // 0x000000018AC64960-0x000000018AC649AC
	}

	[Description("Action Tracks are generic purpose tracks. Once an Action Clip has been placed, the Action Track will lock to accept only clips of the same category.")]
	[Icon(typeof(CircleCollider2D))]
	[Name("Action Track")]
	public abstract class ActionTrack : CutsceneTrack // TypeDefIndex: 58247
	{
		// Constructors
		protected ActionTrack(); // 0x000000018AC50EA8-0x000000018AC50EB0
	}

	[Attachable(new System.Type[1] {typeof(ActorGroup) })]
	public class ActorActionTrack : ActionTrack // TypeDefIndex: 58248
	{
		// Constructors
		public ActorActionTrack(); // 0x000000018AC50EA8-0x000000018AC50EB0
	}

	[Attachable(new System.Type[1] {typeof(ActorGroup) })]
	public class ActorAudioTrack : Slate.AudioTrack // TypeDefIndex: 58249
	{
		// Fields
		[SerializeField]
		protected bool _useAudioSourceOnActor; // 0x90
	
		// Properties
		public override bool useAudioSourceOnActor { get; } // 0x0000000182EC6590-0x0000000182EC65A0 
	
		// Constructors
		public ActorAudioTrack(); // 0x000000018AC50EB0-0x000000018AC50EC8
	}

	[Attachable(new System.Type[1] {typeof(ActorGroup) })]
	public class ActorPropertiesTrack : PropertiesTrack // TypeDefIndex: 58250
	{
		// Constructors
		public ActorPropertiesTrack(); // 0x000000018AC51114-0x000000018AC5111C
	
		// Methods
		protected override void OnCreate(); // 0x000000018AC5102C-0x000000018AC51114
	}

	[Attachable(new System.Type[1] {typeof(ActorGroup) })]
	[Category("Legacy")]
	[Description("The Animation Track works with the legacy \'Animation\' Component. Each Animation Track represents a different layer of the animation system. The zero layered track (bottom) will blend in/out with the default animation clip set on the Animation Component of the actor if any, while all other Animation Tracks will play above.")]
	[Icon(typeof(NavMeshAgent))]
	public class AnimationTrack : CutsceneTrack // TypeDefIndex: 58251
	{
		// Fields
		[Range(0f, 1f)]
		[SerializeField]
		private float _weight; // 0x50
		[Range(0f, 1f)]
		[SerializeField]
		private float _blendIn; // 0x54
		[Range(0f, 1f)]
		[SerializeField]
		private float _blendOut; // 0x58
		[SerializeField]
		private AnimationBlendMode _animationBlendMode; // 0x5C
		[SerializeField]
		private string _mixTransformName; // 0x60
		private Animation anim; // 0x68
		private UnityEngine.AnimationState state; // 0x70
	
		// Properties
		public override string info { get; } // 0x000000018AC580C0-0x000000018AC581C0 
		public override float blendIn { get; } // 0x0000000184D86E00-0x0000000184D86E10 
		public override float blendOut { get; } // 0x0000000184D88400-0x0000000184D88410 
		public float weight { get; } // 0x0000000184D885A0-0x0000000184D885B0 
		public AnimationBlendMode animationBlendMode { get; private set; } // 0x0000000184D86560-0x0000000184D86570 0x0000000184D865C0-0x0000000184D865D0
		public string mixTransformName { get; private set; } // 0x0000000184D86280-0x0000000184D86290 0x00000001863CC164-0x00000001863CC174
	
		// Constructors
		public AnimationTrack(); // 0x000000018AC5805C-0x000000018AC580C0
	
		// Methods
		protected override bool OnInitialize(); // 0x000000018AC57E68-0x000000018AC57F44
		protected override void OnEnter(); // 0x000000018AC57C54-0x000000018AC57E28
		protected override void OnUpdate(float time, float previousTime); // 0x000000018AC57F84-0x000000018AC58024
		protected override void OnExit(); // 0x000000018AC57E28-0x000000018AC57E68
		protected override void OnReverseEnter(); // 0x000000018AC57F44-0x000000018AC57F84
		protected override void OnReverse(); // 0x000000018AC57E28-0x000000018AC57E68
		public Transform GetMixTransform(); // 0x000000018AC57AD4-0x000000018AC57C54
		[CompilerGenerated]
		private bool _GetMixTransform_b__27_0(Transform t); // 0x000000018AC58024-0x000000018AC5805C
	}

	[Attachable(new System.Type[1] {typeof(ActorGroup) })]
	[Description("The Animator Track works with an \'Animator\' Component attached on the actor, but does not require or use the Controller assigned. Instead animation clips can be played directly.\n\nMultiple Animator Tracks can also be added each representing a different animation layer. Root Motion will only be used in Animator Track of Layer 0 (if enabled), which is always the first (bottom) Track.")]
	[Icon(typeof(Animator))]
	public class AnimatorTrack : CutsceneTrack // TypeDefIndex: 58253
	{
		// Fields
		private const int ROOTMOTION_FRAMERATE = 30; // Metadata: 0x0234BBEB
		public AvatarMask mask; // 0x50
		public AnimationBlendMode blendMode; // 0x58
		[Range(0f, 1f)]
		public float weight; // 0x5C
		public bool useRootMotion; // 0x60
		[ShowIf("isMasterTrack", 1)]
		public bool applyFootIK; // 0x61
		[HideInInspector]
		[SerializeField]
		public bool isRootMotionPreBaked; // 0x62
		[HideInInspector]
		[SerializeField]
		private List<Vector3> rmPositions; // 0x68
		[HideInInspector]
		[SerializeField]
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
		public Animator animator { get; } // 0x000000018AC59F28-0x000000018AC5A01C 
		public override string info { get; } // 0x000000018AC5A034-0x000000018AC5A164 
		public override bool isLocked { get; } // 0x000000018AC5A1AC-0x000000018AC5A1DC 
		public AnimatorTrack masterTrack { get; } // 0x000000018AC5A1E4-0x000000018AC5A230 
		public bool isMasterTrack { get; } // 0x000000018AC5A1DC-0x000000018AC5A1E4 
		public bool isLastTrack { get; } // 0x000000018AC5A164-0x000000018AC5A1AC 
		public float compoundTrackWeight { get; } // 0x000000018AC5A01C-0x000000018AC5A034 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58252
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<AnimatorTrack, bool> __9__36_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018AC6748C-0x000000018AC674F0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _OnInitialize_b__36_0(AnimatorTrack t); // 0x000000018AC671C8-0x000000018AC671E8
		}
	
		// Constructors
		public AnimatorTrack(); // 0x000000018AC59F14-0x000000018AC59F28
	
		// Methods
		protected override bool OnInitialize(); // 0x000000018AC596E0-0x000000018AC598F0
		protected override void OnEnter(); // 0x000000018AC59548-0x000000018AC596A0
		protected override void OnUpdate(float time, float previousTime); // 0x000000018AC59A18-0x000000018AC59B18
		private void PostUpdateMasterTrack(float time, float previousTime); // 0x000000018AC59BD0-0x000000018AC59DB8
		protected override void OnReverseEnter(); // 0x000000018AC598F0-0x000000018AC5998C
		protected override void OnExit(); // 0x000000018AC596A0-0x000000018AC596E0
		private void PostExitMasterTrack(); // 0x000000018AC59B18-0x000000018AC59BD0
		protected override void OnReverse(); // 0x000000018AC5998C-0x000000018AC59A18
		public void EnableClip(PlayAnimatorClip playAnimClip, float blendWeight, float subClipWeight); // 0x000000018AC59140-0x000000018AC591FC
		public void UpdateClip(PlayAnimatorClip playAnimClip, float clipTime, float clipPrevious, float blendWeight, float subClipWeight); // 0x000000018AC59E08-0x000000018AC59F14
		public void DisableClip(PlayAnimatorClip playAnimClip, float blendWeight, float subClipWeight); // 0x000000018AC59098-0x000000018AC59140
		private void CreateAndPlayTree(); // 0x000000018AC58A18-0x000000018AC58DC4
		private Playable CreateClipsMixer(PlayableGraph graph); // 0x000000018AC58DC4-0x000000018AC59098
		public void PreBakeRootMotion(); // 0x000000018AC59DB8-0x000000018AC59E08
		public void ClearPreBakeRootMotion(); // 0x000000018AC58954-0x000000018AC58A18
		private void BakeRootMotion(); // 0x000000018AC58490-0x000000018AC58954
		private void EvaluateTrackClips(float time, float previousTime, ref int tempActiveClips); // 0x000000018AC591FC-0x000000018AC59548
		private void ApplyBakedRootMotion(float time); // 0x000000018AC581C0-0x000000018AC58490
	}

	[Attachable(new System.Type[1] {typeof(ActorGroup) })]
	[Category("Legacy")]
	[Description("** This Track is deprecated. Please use Animator Track instead. **\n\nThe Mecanim Track works with an \'Animator\' component attached on the actor and with it\'s assigned Controller by modifying the Controller\'s parameters.\n\nConsider working with the new Animator Track instead to playback animation clips directly without the need of a Controller, which is more intuitive for animations.")]
	[Icon(typeof(Animator))]
	public class MecanimTrack : CutsceneTrack // TypeDefIndex: 58254
	{
		// Fields
		private Animator animator; // 0x50
	
		// Constructors
		public MecanimTrack(); // 0x000000018AC50EA8-0x000000018AC50EB0
	
		// Methods
		protected override bool OnInitialize(); // 0x000000018AC65C28-0x000000018AC65D94
		protected override void OnReverse(); // 0x000000018AC65C20-0x000000018AC65C28
		protected override void OnExit(); // 0x000000018AC65C20-0x000000018AC65C28
		private void DestroyDispatcher(); // 0x000000018AC65B8C-0x000000018AC65C20
	}

	[Description("All audio clips played by this track will be send to the selected AudioMixer if any.")]
	[Icon(typeof(AudioClip))]
	[Name("Audio Track")]
	public abstract class AudioTrack : CutsceneTrack // TypeDefIndex: 58255
	{
		// Fields
		[SerializeField]
		protected AudioMixerGroup _outputMixer; // 0x50
		[Range(0f, 1f)]
		[SerializeField]
		protected float _masterVolume; // 0x58
		[Range(-3f, 3f)]
		[SerializeField]
		protected float _masterPitch; // 0x5C
		[Range(-1f, 1f)]
		[SerializeField]
		protected float _masterStereoPan; // 0x60
		[Range(0f, 1f)]
		[SerializeField]
		protected float _masterSpatialBlend; // 0x64
		[SerializeField]
		protected bool _ignoreTimeScale; // 0x68
		[SerializeField]
		protected bool _bypassReverb; // 0x69
		[CompilerGenerated]
		private AudioSource _source_k__BackingField; // 0x70
		[CompilerGenerated]
		private AudioSampler.SampleSettings _sampleSettings_k__BackingField; // 0x78
	
		// Properties
		public override string info { get; } // 0x000000018AC5A52C-0x000000018AC5A5FC 
		public AudioSource source { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862B0-0x0000000184D862C0 0x00000001863AD760-0x00000001863AD770
		public AudioSampler.SampleSettings sampleSettings { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA9B50-0x0000000184DA9B70 0x0000000184DA9B70-0x0000000184DA9B90
		public AudioMixerGroup mixer { get; } // 0x0000000184D86270-0x0000000184D86280 
		public virtual bool useAudioSourceOnActor { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Constructors
		protected AudioTrack(); // 0x000000018AC50EB0-0x000000018AC50EC8
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC5A36C-0x000000018AC5A374
		protected override void OnReverseEnter(); // 0x000000018AC5A36C-0x000000018AC5A374
		protected override void OnUpdate(float time, float previousTime); // 0x000000018AC5A37C-0x000000018AC5A480
		protected override void OnExit(); // 0x000000018AC5A374-0x000000018AC5A37C
		protected override void OnReverse(); // 0x000000018AC5A374-0x000000018AC5A37C
		private void Enable(); // 0x000000018AC5A290-0x000000018AC5A36C
		private void Disable(); // 0x000000018AC5A230-0x000000018AC5A290
		private void SetAndApplySettings(); // 0x000000018AC5A480-0x000000018AC5A520
		public void SetVolume(float volume); // 0x000000018AC5A520-0x000000018AC5A52C
	}

	[Attachable(new System.Type[1] {typeof(DirectorGroup) })]
	[Description("The Camera Track is the track within wich you create your camera shots and moves. Once the Camera Track becomes active, the Director Camera will be enabled. You can control when the Director Camera takes effect by setting the \'Active Time Offset\', while the Blend In/Out parameters control the ammount of blending there will be from the game camera to the first and the last shot of the track.\nIf you don\'t want a cinematic letterbox effect, you can set CineBox Fade Time to 0.\nIf you don\'t want to use Slate Camera features, you can simply disable or delete this track.")]
	[Icon(typeof(Camera))]
	[UniqueElement]
	public class CameraTrack : CutsceneTrack // TypeDefIndex: 58256
	{
		// Fields
		private static CameraTrack activeCameraTrack; // 0x00
		[HideInInspector]
		[SerializeField]
		private float _startTimeOffset; // 0x50
		[HideInInspector]
		[SerializeField]
		private float _endTimeOffset; // 0x54
		[HideInInspector]
		[Slate.Min(0f)]
		public float _blendIn; // 0x58
		[HideInInspector]
		[Slate.Min(0f)]
		public float _blendOut; // 0x5C
		[HideInInspector]
		public Slate.EaseType interpolation; // 0x60
		[HideInInspector]
		[Range(0f, 1f)]
		public float cineBoxFadeTime; // 0x64
		[HideInInspector]
		public float appliedSmoothing; // 0x68
		[HideInInspector]
		public Camera exitCameraOverride; // 0x70
		private GameCamera entryCamera; // 0x78
		[CompilerGenerated]
		private CameraShot _firstShot_k__BackingField; // 0x80
		[CompilerGenerated]
		private CameraShot _lastShot_k__BackingField; // 0x88
		[CompilerGenerated]
		private CameraShot _currentShot_k__BackingField; // 0x90
	
		// Properties
		public CameraShot firstShot { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86260-0x0000000184D86270 0x0000000184CD9970-0x0000000184CD9980
		public CameraShot lastShot { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D861F0-0x0000000184D86200 0x0000000185395D30-0x0000000185395D44
		public CameraShot currentShot { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86220-0x0000000184D86230 0x0000000186402330-0x0000000186402344
		public override string info { get; } // 0x000000018AC5C604-0x000000018AC5C668 
		public override float startTime { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x000000018AC5C6DC-0x000000018AC5C730
		public override float endTime { get; set; } // 0x000000018AC5C5D8-0x000000018AC5C604 0x000000018AC5C668-0x000000018AC5C6DC
		public override float blendIn { get; set; } // 0x000000018AC5C484-0x000000018AC5C52C 0x0000000184D88430-0x0000000184D88440
		public override float blendOut { get; set; } // 0x000000018AC5C52C-0x000000018AC5C5D8 0x0000000184D91510-0x0000000184D91520
	
		// Constructors
		public CameraTrack(); // 0x000000018AC5C46C-0x000000018AC5C484
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC5BCC4-0x000000018AC5BEE0
		protected override void OnUpdate(float time, float previousTime); // 0x000000018AC5C0B4-0x000000018AC5C3EC
		protected override void OnExit(); // 0x000000018AC5BEE0-0x000000018AC5BF7C
		protected override void OnReverseEnter(); // 0x000000018AC5BF7C-0x000000018AC5C018
		protected override void OnReverse(); // 0x000000018AC5C018-0x000000018AC5C0B4
		[CompilerGenerated]
		private bool _OnEnter_b__36_0(ActionClip s); // 0x000000018AC5C3EC-0x000000018AC5C424
		[CompilerGenerated]
		private bool _OnEnter_b__36_1(ActionClip s); // 0x000000018AC5C424-0x000000018AC5C46C
	}

	[Attachable(new System.Type[1] {typeof(DirectorGroup) })]
	public class DirectorActionTrack : ActionTrack // TypeDefIndex: 58257
	{
		// Constructors
		public DirectorActionTrack(); // 0x000000018AC50EA8-0x000000018AC50EB0
	}

	[Attachable(new System.Type[1] {typeof(DirectorGroup) })]
	public class DirectorAudioTrack : Slate.AudioTrack // TypeDefIndex: 58258
	{
		// Constructors
		public DirectorAudioTrack(); // 0x000000018AC50EB0-0x000000018AC50EC8
	}

	[Attachable(new System.Type[1] {typeof(DirectorGroup) })]
	[Description("Use the Director Properties Track to animate any component property of the Director Camera. This is particularly useful to animate image effects rather than transforms, since transforms are handled by the CameraTrack and it\'s Shot Clips. You can still animate transforms if you are after a one-take, by having a CameraTrack without shot clips.")]
	public class DirectorPropertiesTrack : PropertiesTrack // TypeDefIndex: 58259
	{
		// Constructors
		public DirectorPropertiesTrack(); // 0x000000018AC51114-0x000000018AC5111C
	}

	[Attachable(new System.Type[1] {typeof(DirectorGroup) })]
	[Description("Plays video clips on the render camera. Please note that scrubbing might be choppy, but playing is not.")]
	[Icon(typeof(VideoPlayer))]
	[UniqueElement]
	public class VideoTrack : CutsceneTrack // TypeDefIndex: 58260
	{
		// Fields
		public VideoSampler.VideoRenderTarget renderTarget; // 0x50
		public VideoAspectRatio aspectRatio; // 0x54
		[CompilerGenerated]
		private VideoPlayer _source_k__BackingField; // 0x58
	
		// Properties
		public VideoPlayer source { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182E56440-0x0000000182E56460 0x00000001836E5590-0x00000001836E55A0
		public override string info { get; } // 0x000000018AC675C0-0x000000018AC67E58 
	
		// Constructors
		public VideoTrack(); // 0x000000018AC675B0-0x000000018AC675C0
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC675A0-0x000000018AC675A8
		protected override void OnReverseEnter(); // 0x000000018AC675A0-0x000000018AC675A8
		protected override void OnReverse(); // 0x000000018AC675A8-0x000000018AC675B0
		protected override void OnExit(); // 0x000000018AC675A8-0x000000018AC675B0
		private void Enable(); // 0x000000018AC6753C-0x000000018AC675A0
		private void Disable(); // 0x000000018AC674F0-0x000000018AC6753C
	}

	[Category("Legacy")]
	[Description("With the Properties Track, you can select to animate any supported type property or field on any component on the actor, or within it\'s whole transform hierarchy.\n\nNote, that you can do exactly the same, by using the \'Animate Properties\' ActionClip added in an \'Action Track\'.")]
	[Name("Properties Track")]
	[UniqueElement]
	public abstract class PropertiesTrack : CutsceneTrack, IKeyable // TypeDefIndex: 58261
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private AnimationDataCollection _animationData; // 0x50
	
		// Properties
		public AnimationDataCollection animationData { get; } // 0x0000000184D86270-0x0000000184D86280 
		public object animatedParametersTarget { get; } // 0x000000018AC661CC-0x000000018AC661D4 
	
		// Constructors
		protected PropertiesTrack(); // 0x000000018AC66174-0x000000018AC661CC
	
		// Methods
		protected override void OnAfterValidate(); // 0x000000018AC66080-0x000000018AC660A8
		protected override void OnEnter(); // 0x000000018AC660A8-0x000000018AC660FC
		protected override void OnUpdate(float time, float previousTime); // 0x000000018AC6611C-0x000000018AC66174
		protected override void OnReverse(); // 0x000000018AC660FC-0x000000018AC6611C
	}

	[Attachable(new System.Type[1] {typeof(ActionTrack) })]
	public abstract class ActionClip : MonoBehaviour, IKeyable // TypeDefIndex: 58262
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _startTime; // 0x18
		[HideInInspector]
		[SerializeField]
		private AnimationDataCollection _animationData; // 0x20
		[CompilerGenerated]
		private IDirectable _parent_k__BackingField; // 0x28
		[CompilerGenerated]
		private bool _isHighlight_k__BackingField; // 0x30
		[NonSerialized]
		private string[] _cachedAnimParamPaths; // 0x38
	
		// Properties
		public IDirector root { get; } // 0x000000018AC50B90-0x000000018AC50BB0 
		public IDirectable parent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public GameObject actor { get; } // 0x000000018AC5087C-0x000000018AC5089C 
		IEnumerable<IDirectable> IDirectable.children { get; } // 0x00000001811EC580-0x00000001811EC590 
		public AnimationDataCollection animationData { get; private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public float startTime { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x000000018AC50DAC-0x000000018AC50EA8
		public float endTime { get; set; } // 0x000000018AC508D4-0x000000018AC50900 0x000000018AC50C90-0x000000018AC50DAC
		public bool isActive { get; } // 0x000000018AC50A84-0x000000018AC50AC0 
		public bool isCollapsed { get; } // 0x000000018AC50AC0-0x000000018AC50AE0 
		public bool isLocked { get; } // 0x000000018AC50AE0-0x000000018AC50B00 
		public virtual float length { get; set; } // 0x0000000184D879D0-0x0000000184D879E0 0x00000001841E1670-0x00000001841E1680
		public virtual float blendIn { get; set; } // 0x0000000184D879D0-0x0000000184D879E0 0x00000001841E1670-0x00000001841E1680
		public virtual float blendOut { get; set; } // 0x0000000184D879D0-0x0000000184D879E0 0x00000001841E1670-0x00000001841E1680
		public virtual bool canCrossBlend { get; } // 0x00000001812081B0-0x0000000181208610 
		public virtual string info { get; } // 0x000000018AC509E0-0x000000018AC50A84 
		public virtual bool isValid { get; } // 0x000000018AC50B20-0x000000018AC50B70 
		public virtual UnityEngine.Color color { get; } // 0x000000018A96C614-0x000000018A96C634 
		public virtual UnityEngine.Color textColor { get; } // 0x000000018AC50BB0-0x000000018AC50BD0 
		public virtual int textSizeInner { get; } // 0x0000000184DA5360-0x0000000184DA5370 
		public virtual int textSizeOuter { get; } // 0x0000000184DA4FC0-0x0000000184DA4FD0 
		public virtual float interval { get; } // 0x0000000184D879D0-0x0000000184D879E0 
		public virtual string url { get; } // 0x000000018AC50BD0-0x000000018AC50C90 
		public virtual bool isHighlight { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D865F0-0x0000000184D86600 0x0000000184D86620-0x0000000184D86630
		public bool isReadOnly { get; } // 0x000000018AC50B00-0x000000018AC50B20 
		public virtual TransformSpace defaultTransformSpace { get; } // 0x00000001811EC580-0x00000001811EC590 
		private string[] animatedParameterPaths { get; } // 0x000000018AC5089C-0x000000018AC508D4 
		private bool handleParametersRegistrationManually { get; } // 0x000000018AC50900-0x000000018AC50924 
		public virtual object animatedParametersTarget { get; } // 0x000000018464E630-0x000000018464E640 
		public virtual Slate.EaseType animatedParametersInterpolation { get; } // 0x00000001811EC580-0x00000001811EC590 
		public virtual bool useWeightInParameters { get; } // 0x00000001812081B0-0x0000000181208610 
		public bool hasParameters { get; } // 0x000000018AC509C8-0x000000018AC509E0 
		public bool hasActiveParameters { get; } // 0x000000018AC50924-0x000000018AC509C8 
		public virtual bool needActor { get; } // 0x000000018AC50B70-0x000000018AC50B90 
		public virtual bool canSample { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public virtual int updateOrder { get; } // 0x0000000184DA3400-0x0000000184DA3410 
		string IDirectable.name { get; } // 0x0000000185396F58-0x0000000185396F60 
	
		// Constructors
		protected ActionClip(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		bool IDirectable.Initialize(); // 0x000000018AC501F4-0x000000018AC50204
		void IDirectable.Enter(); // 0x000000018AC501C0-0x000000018AC501E4
		void IDirectable.Update(float time, float previousTime); // 0x000000018AC50284-0x000000018AC502C8
		void IDirectable.Exit(); // 0x000000018AC501E4-0x000000018AC501F4
		void IDirectable.ReverseEnter(); // 0x000000018AC50204-0x000000018AC50214
		void IDirectable.Reverse(); // 0x000000018AC50214-0x000000018AC50238
		void IDirectable.RootEnabled(); // 0x000000018AC50250-0x000000018AC50268
		void IDirectable.RootDisabled(); // 0x000000018AC50238-0x000000018AC50250
		void IDirectable.RootUpdated(float time, float previousTime); // 0x000000018AC50268-0x000000018AC50284
		void IDirectable.RootDestroyed(); // 0x0000000184D83230-0x0000000184D83240
		public void PostCreate(IDirectable parent); // 0x000000018AC50070-0x000000018AC500A4
		public void Validate(); // 0x000000018AC50828-0x000000018AC50838
		public void Validate(IDirector root, IDirectable parent); // 0x000000018AC50838-0x000000018AC5087C
		protected virtual bool OnInitialize(); // 0x0000000182FFF600-0x0000000182FFF610
		protected virtual void OnEnter(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnUpdate(float time, float previousTime); // 0x000000018AC50060-0x000000018AC50070
		protected virtual void OnUpdate(float time); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnExit(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnReverse(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnReverseEnter(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnDrawGizmosSelected(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnSceneGUI(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnCreate(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnAfterValidate(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnRootEnabled(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnRootDisabled(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnRootUpdated(float time, float previousTime); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnRootDestroyed(); // 0x00000001841E1670-0x00000001841E1680
		public bool RootTimeWithinRange(); // 0x000000018AC500F0-0x000000018AC500F8
		public Vector3 TransformPosition(Vector3 point, TransformSpace space); // 0x000000018AC502C8-0x000000018AC50314
		public Vector3 InverseTransformPosition(Vector3 point, TransformSpace space); // 0x000000018AC4FFD0-0x000000018AC5001C
		public Quaternion TransformRotation(Vector3 euler, TransformSpace space); // 0x000000018AC50314-0x000000018AC50358
		public Vector3 InverseTransformRotation(Quaternion rot, TransformSpace space); // 0x000000018AC5001C-0x000000018AC50060
		public Vector3 ActorPositionInSpace(TransformSpace space); // 0x000000018AC4FD60-0x000000018AC4FD90
		public Transform GetSpaceTransform(TransformSpace space, GameObject actorOverride = null); // 0x000000018AC4FFC8-0x000000018AC4FFD0
		public ActionClip GetPreviousClip(); // 0x000000018AC4FF8C-0x000000018AC4FFC8
		public ActionClip GetNextClip(); // 0x000000018AC4FF30-0x000000018AC4FF6C
		public float GetClipWeight(); // 0x000000018AC4FE6C-0x000000018AC4FEA8
		public float GetClipWeight(float time); // 0x000000018AC4FED4-0x000000018AC4FF30
		public float GetClipWeight(float time, float blendInOut); // 0x000000018AC4FEA8-0x000000018AC4FEC4
		public float GetClipWeight(float time, float blendIn, float blendOut); // 0x000000018AC4FEC4-0x000000018AC4FED4
		public void TryMatchSubClipLength(); // 0x000000018AC50494-0x000000018AC50550
		public void TryMatchPreviousSubClipLoop(); // 0x000000018AC5042C-0x000000018AC50494
		public void TryMatchNexSubClipLoop(); // 0x000000018AC50358-0x000000018AC5042C
		private string GetParameterName<T, TResult>(Expression<Func<T, TResult>> func);
		public AnimatedParameter GetParameter<T, TResult>(Expression<Func<T, TResult>> func);
		public AnimatedParameter GetParameter(string paramName); // 0x000000018AC4FF6C-0x000000018AC4FF8C
		public void SetParameterEnabled<T, TResult>(Expression<Func<T, TResult>> func, bool enabled);
		public void SetParameterEnabled(string paramName, bool enabled); // 0x000000018AC50158-0x000000018AC501C0
		public void ResetAnimatedParameters(); // 0x000000018AC500A4-0x000000018AC500B8
		private void CreateAnimationDataCollection(); // 0x000000018AC4FD90-0x000000018AC4FE6C
		private void ValidateAnimParams(); // 0x000000018AC5062C-0x000000018AC50828
		private void SetAnimParamsSnapshot(); // 0x000000018AC500F8-0x000000018AC50158
		private void UpdateAnimParams(float time, float previousTime); // 0x000000018AC50550-0x000000018AC5062C
		private void RestoreAnimParamsSnapshot(); // 0x000000018AC500B8-0x000000018AC500F0
	}

	[Serializable]
	public class AnimatedParameter : IAnimatableData, ISerializationCallbackReceiver // TypeDefIndex: 58266
	{
		// Fields
		[CompilerGenerated]
		private static Action<IAnimatableData> onParameterChanged; // 0x00
		[SerializeField]
		private string _serializedData; // 0x10
		[SerializeField]
		private bool _isDisabled; // 0x18
		[SerializeField]
		private AnimationCurve[] _curves; // 0x20
		[SerializeField]
		private string _scriptExpression; // 0x28
		[NonSerialized]
		private SerializationMetaData _data; // 0x30
		[NonSerialized]
		private IAnimatedParameterModel _parameterModel; // 0x38
		[CompilerGenerated]
		private IKeyable _keyable_k__BackingField; // 0x40
		[CompilerGenerated]
		private float[] _snapshot_k__BackingField; // 0x48
		[CompilerGenerated]
		private float[] _lastEval_k__BackingField; // 0x50
		[CompilerGenerated]
		private Transform _virtualTransformParent_k__BackingField; // 0x58
		private static Dictionary<System.Type, System.Type> parameterModelsMap; // 0x08
		public static readonly System.Type[] supportedTypes; // 0x10
		[NonSerialized]
		private object _animatableAttribute; // 0x60
		[NonSerialized]
		private object _resolvedMemberObject; // 0x68
	
		// Properties
		public bool enabled { get; } // 0x000000018AA1EEF0-0x000000018AA1EEF8 
		private string serializedData { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		private SerializationMetaData data { get; } // 0x000000018AC535E4-0x000000018AC53650 
		public IAnimatedParameterModel parameterModel { get; } // 0x000000018AC53748-0x000000018AC53834 
		public AnimationCurve[] curves { get; private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public string scriptExpression { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x000000018AC53998-0x000000018AC539D0
		public bool hasActiveExpression { get; } // 0x000000018AC53690-0x000000018AC536A8 
		public string parameterName { get; } // 0x000000018AC53834-0x000000018AC53854 
		public System.Type animatedType { get; } // 0x000000018AC535C4-0x000000018AC535E4 
		public ParameterType parameterType { get; } // 0x000000018AC53854-0x000000018AC53874 
		public string transformHierarchyPath { get; } // 0x000000018AC538B4-0x000000018AC538D4 
		public System.Type declaringType { get; } // 0x000000018AC53650-0x000000018AC53670 
		public PropertyInfo property { get; } // 0x000000018AC53874-0x000000018AC53894 
		public System.Reflection.FieldInfo field { get; } // 0x000000018AC53670-0x000000018AC53690 
		public bool isProperty { get; } // 0x000000018AC536C0-0x000000018AC536D8 
		public IKeyable keyable { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		private float[] snapshot { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
		private float[] lastEval { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		private Transform virtualTransformParent { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182E56440-0x0000000182E56460 0x00000001836E5590-0x00000001836E55A0
		public object targetObject { get; } // 0x000000018AC53894-0x000000018AC538B4 
		public AnimatableParameterAttribute animatableAttribute { get; } // 0x000000018AC534EC-0x000000018AC535C4 
		public bool isExternal { get; } // 0x000000018AC536A8-0x000000018AC536C0 
		public bool isValid { get; } // 0x000000018AC536D8-0x000000018AC53748 
	
		// Events
		public static event Action<IAnimatableData> onParameterChanged {
			add; // 0x000000018AC53428-0x000000018AC534EC
			remove; // 0x000000018AC538D4-0x000000018AC53998
		}
	
		// Nested types
		[Serializable]
		private class SerializationMetaData // TypeDefIndex: 58263
		{
			// Fields
			public string parameterName; // 0x10
			public string declaringTypeName; // 0x18
			public string transformHierarchyPath; // 0x20
			public ParameterType parameterType; // 0x28
			[CompilerGenerated]
			private System.Type _declaringType_k__BackingField; // 0x30
			[CompilerGenerated]
			private PropertyInfo _property_k__BackingField; // 0x38
			[CompilerGenerated]
			private System.Reflection.FieldInfo _field_k__BackingField; // 0x40
			[CompilerGenerated]
			private System.Type _animatedType_k__BackingField; // 0x48
	
			// Properties
			public System.Type declaringType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
			public PropertyInfo property { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
			public System.Reflection.FieldInfo field { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
			public System.Type animatedType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
	
			// Constructors
			public SerializationMetaData(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Deserialize(); // 0x000000018AC66254-0x000000018AC663CC
		}
	
		public enum ParameterType // TypeDefIndex: 58264
		{
			NotSet = 0,
			Property = 1,
			Field = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass112_0 // TypeDefIndex: 58265
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass112_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _GetKeyLabel_b__0(AnimationCurve c); // 0x000000018AC67228-0x000000018AC6724C
		}
	
		// Constructors
		static AnimatedParameter(); // 0x000000018AC53068-0x000000018AC532D8
		public AnimatedParameter(IKeyable keyable, System.Type type, string memberPath, string transformPath); // 0x000000018AC532D8-0x000000018AC53428
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018AC53038-0x000000018AC53068
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018AC52FFC-0x000000018AC53038
		public void SetEnabled(bool value, float time); // 0x000000018AC52DD8-0x000000018AC52E44
		private void ConstructWithField(System.Reflection.FieldInfo targetField, System.Type type, string memberPath, string transformPath); // 0x000000018AC51488-0x000000018AC51658
		private void ConstructWithProperty(PropertyInfo targetProperty, System.Type type, string memberPath, string transformPath); // 0x000000018AC51658-0x000000018AC5189C
		public MemberInfo GetMemberInfo(); // 0x000000018AC522E0-0x000000018AC52324
		public AnimationCurve[] GetCurves(); // 0x0000000184D862C0-0x0000000184D862D0
		public bool CompareTo(AnimatedParameter other); // 0x000000018AC513B4-0x000000018AC51488
		private void InitializeCurves(); // 0x000000018AC523B8-0x000000018AC5250C
		public void Validate(IKeyable keyable); // 0x00000001842B4AE0-0x00000001842B4AF0
		public void SetVirtualTransformParent(Transform virtualTransformParent); // 0x00000001836E5590-0x00000001836E55A0
		public void SetSnapshot(); // 0x000000018AC52F24-0x000000018AC52F94
		public bool TryAutoKey(float time); // 0x000000018AC52F9C-0x000000018AC52FFC
		public void Evaluate(float time, float previousTime, float weight = 1f /* Metadata: 0x0234BBEC */); // 0x000000018AC51988-0x000000018AC51A14
		private void Evaluate_1_Curves(float time, float previousTime, float weight = 1f /* Metadata: 0x0234BBF0 */); // 0x000000018AC5189C-0x000000018AC51988
		private bool Evaluate_2_Expression(float time, float previousTime, float weight = 1f /* Metadata: 0x0234BBF4 */); // 0x00000001812081B0-0x0000000181208610
		public void RestoreSnapshot(); // 0x000000018AC52910-0x000000018AC52970
		public object GetEvalValue(float time); // 0x000000018AC520D8-0x000000018AC521AC
		public object ResolvedMemberObject(); // 0x000000018AC526DC-0x000000018AC52910
		public object GetCurrentValueAsObject(); // 0x000000018AC52094-0x000000018AC520D8
		private float[] GetCurrentValueAsFloats(); // 0x000000018AC51C94-0x000000018AC52094
		public void SetCurrentValue(object value); // 0x000000018AC52970-0x000000018AC529B8
		private void SetCurrentValue(float[] floats); // 0x000000018AC529B8-0x000000018AC52DD8
		public bool HasChanged(); // 0x000000018AC52330-0x000000018AC523A8
		public bool HasAnyKey(); // 0x000000018AC52324-0x000000018AC52330
		public bool HasKey(float time); // 0x000000018AC523A8-0x000000018AC523B8
		public float GetKeyNext(float time); // 0x000000018AC522C0-0x000000018AC522D0
		public float GetKeyPrevious(float time); // 0x000000018AC522D0-0x000000018AC522E0
		public bool TryKeyIdentity(float time); // 0x00000001812081B0-0x0000000181208610
		public void SetKeyCurrent(float time); // 0x00000001841E1670-0x00000001841E1680
		public void RemoveKey(float time); // 0x00000001841E1670-0x00000001841E1680
		public void SetPreWrapMode(UnityEngine.WrapMode mode); // 0x000000018AC52EB4-0x000000018AC52F24
		public void SetPostWrapMode(UnityEngine.WrapMode mode); // 0x000000018AC52E44-0x000000018AC52EB4
		public void OffsetValue(object deltaValue); // 0x000000018AC52584-0x000000018AC52614
		public void Reset(); // 0x000000018AC52614-0x000000018AC526DC
		public void ChangeMemberType(ParameterType newType); // 0x000000018AC51354-0x000000018AC513B4
		public override string ToString(); // 0x000000018AC52F94-0x000000018AC52F9C
		public string FriendlyName(); // 0x000000018AC51A14-0x000000018AC51C94
		public string GetKeyLabel(float time); // 0x000000018AC521AC-0x000000018AC522C0
		private void RecordUndo(); // 0x00000001841E1670-0x00000001841E1680
		private void NotifyChange(); // 0x000000018AC5250C-0x000000018AC52584
	}

	public interface IAnimatedParameterModel // TypeDefIndex: 58267
	{
		// Methods
		bool ForceStepMode();
		int RequiredCurvesCount();
		object ConvertToObject(params float[] floats);
		float[] ConvertToFloats(object value);
		string GetKeyLabel(params float[] floats);
		void SetDirect(object target, MemberInfo info, params float[] floats);
		float[] GetDirect(object target, MemberInfo info);
	}

	[Decorator(typeof(bool))]
	public struct Animated_Bool : IAnimatedParameterModel // TypeDefIndex: 58268
	{
		// Fields
		private Action<object, bool> setter; // 0x00
	
		// Methods
		public bool ForceStepMode(); // 0x0000000182FFF600-0x0000000182FFF610
		public int RequiredCurvesCount(); // 0x0000000184D85B80-0x0000000184D85B90
		public object ConvertToObject(params float[] floats); // 0x000000018AC53A6C-0x000000018AC53AD0
		public float[] ConvertToFloats(object value); // 0x000000018AC539D0-0x000000018AC53A6C
		public string GetKeyLabel(params float[] floats); // 0x000000018AC53BA4-0x000000018AC53C28
		public void SetDirect(object target, MemberInfo info, params float[] floats); // 0x000000018AC53C28-0x000000018AC53CEC
		public float[] GetDirect(object target, MemberInfo info); // 0x000000018AC53AD0-0x000000018AC53BA4
	}

	[Decorator(typeof(int))]
	public struct Animated_Int : IAnimatedParameterModel // TypeDefIndex: 58269
	{
		// Fields
		private Action<object, int> setter; // 0x00
	
		// Methods
		public bool ForceStepMode(); // 0x0000000182FFF600-0x0000000182FFF610
		public int RequiredCurvesCount(); // 0x0000000184D85B80-0x0000000184D85B90
		public object ConvertToObject(params float[] floats); // 0x000000018AC54BE0-0x000000018AC54C3C
		public float[] ConvertToFloats(object value); // 0x000000018AC54B54-0x000000018AC54BE0
		public string GetKeyLabel(params float[] floats); // 0x000000018AC54CFC-0x000000018AC54D78
		public void SetDirect(object target, MemberInfo info, params float[] floats); // 0x000000018AC54D78-0x000000018AC54E30
		public float[] GetDirect(object target, MemberInfo info); // 0x000000018AC54C3C-0x000000018AC54CFC
	}

	[Decorator(typeof(float))]
	public struct Animated_Float : IAnimatedParameterModel // TypeDefIndex: 58270
	{
		// Fields
		private Action<object, float> setter; // 0x00
	
		// Methods
		public bool ForceStepMode(); // 0x00000001812081B0-0x0000000181208610
		public int RequiredCurvesCount(); // 0x0000000184D85B80-0x0000000184D85B90
		public object ConvertToObject(params float[] floats); // 0x000000018AC54900-0x000000018AC54960
		public float[] ConvertToFloats(object value); // 0x000000018AC54878-0x000000018AC54900
		public string GetKeyLabel(params float[] floats); // 0x000000018AC54A20-0x000000018AC54A9C
		public void SetDirect(object target, MemberInfo info, params float[] floats); // 0x000000018AC54A9C-0x000000018AC54B54
		public float[] GetDirect(object target, MemberInfo info); // 0x000000018AC54960-0x000000018AC54A20
	}

	[Decorator(typeof(Vector2))]
	public struct Animated_Vector2 : IAnimatedParameterModel // TypeDefIndex: 58271
	{
		// Fields
		private Action<object, Vector2> setter; // 0x00
	
		// Methods
		public bool ForceStepMode(); // 0x00000001812081B0-0x0000000181208610
		public int RequiredCurvesCount(); // 0x0000000182BBE540-0x0000000182BBE550
		public object ConvertToObject(params float[] floats); // 0x000000018AC55874-0x000000018AC558E0
		public float[] ConvertToFloats(object value); // 0x000000018AC557D8-0x000000018AC55874
		public string GetKeyLabel(params float[] floats); // 0x000000018AC559B4-0x000000018AC55A64
		public void SetDirect(object target, MemberInfo info, params float[] floats); // 0x000000018AC55A64-0x000000018AC55B30
		public float[] GetDirect(object target, MemberInfo info); // 0x000000018AC558E0-0x000000018AC559B4
	}

	[Decorator(typeof(Vector3))]
	public struct Animated_Vector3 : IAnimatedParameterModel // TypeDefIndex: 58272
	{
		// Fields
		private Action<object, Vector3> setter; // 0x00
	
		// Methods
		public bool ForceStepMode(); // 0x00000001812081B0-0x0000000181208610
		public int RequiredCurvesCount(); // 0x0000000184D8C9E0-0x0000000184D8C9F0
		public object ConvertToObject(params float[] floats); // 0x000000018AC55BD0-0x000000018AC55C50
		public float[] ConvertToFloats(object value); // 0x000000018AC55B30-0x000000018AC55BD0
		public string GetKeyLabel(params float[] floats); // 0x000000018AC55D28-0x000000018AC55E0C
		public void SetDirect(object target, MemberInfo info, params float[] floats); // 0x000000018AC55E0C-0x000000018AC55EEC
		public float[] GetDirect(object target, MemberInfo info); // 0x000000018AC55C50-0x000000018AC55D28
	}

	[Decorator(typeof(UnityEngine.Color))]
	public struct Animated_Color : IAnimatedParameterModel // TypeDefIndex: 58273
	{
		// Fields
		private Action<object, UnityEngine.Color> setter; // 0x00
	
		// Methods
		public bool ForceStepMode(); // 0x00000001812081B0-0x0000000181208610
		public int RequiredCurvesCount(); // 0x0000000184D882B0-0x0000000184D882C0
		public object ConvertToObject(params float[] floats); // 0x000000018AC544A4-0x000000018AC54540
		public float[] ConvertToFloats(object value); // 0x000000018AC543F0-0x000000018AC544A4
		public string GetKeyLabel(params float[] floats); // 0x000000018AC5462C-0x000000018AC54778
		public void SetDirect(object target, MemberInfo info, params float[] floats); // 0x000000018AC54778-0x000000018AC54878
		public float[] GetDirect(object target, MemberInfo info); // 0x000000018AC54540-0x000000018AC5462C
	}

	[Decorator(typeof(Vector4))]
	public struct Animated_Vector4 : IAnimatedParameterModel // TypeDefIndex: 58274
	{
		// Fields
		private Action<object, Vector4> setter; // 0x00
	
		// Methods
		public bool ForceStepMode(); // 0x00000001812081B0-0x0000000181208610
		public int RequiredCurvesCount(); // 0x0000000184D882B0-0x0000000184D882C0
		public object ConvertToObject(params float[] floats); // 0x000000018AC55FA0-0x000000018AC5603C
		public float[] ConvertToFloats(object value); // 0x000000018AC55EEC-0x000000018AC55FA0
		public string GetKeyLabel(params float[] floats); // 0x000000018AC56128-0x000000018AC562C0
		public void SetDirect(object target, MemberInfo info, params float[] floats); // 0x000000018AC562C0-0x000000018AC563C0
		public float[] GetDirect(object target, MemberInfo info); // 0x000000018AC5603C-0x000000018AC56128
	}

	[Decorator(typeof(Quaternion))]
	public struct Animated_Quaternion : IAnimatedParameterModel // TypeDefIndex: 58275
	{
		// Fields
		private Action<object, Quaternion> setter; // 0x00
	
		// Methods
		public bool ForceStepMode(); // 0x00000001812081B0-0x0000000181208610
		public int RequiredCurvesCount(); // 0x0000000184D882B0-0x0000000184D882C0
		public object ConvertToObject(params float[] floats); // 0x000000018AC54EE4-0x000000018AC54F80
		public float[] ConvertToFloats(object value); // 0x000000018AC54E30-0x000000018AC54EE4
		public string GetKeyLabel(params float[] floats); // 0x000000018AC5506C-0x000000018AC55204
		public void SetDirect(object target, MemberInfo info, params float[] floats); // 0x000000018AC55204-0x000000018AC55304
		public float[] GetDirect(object target, MemberInfo info); // 0x000000018AC54F80-0x000000018AC5506C
	}

	[Decorator(typeof(Rect))]
	public struct Animated_Rect : IAnimatedParameterModel // TypeDefIndex: 58276
	{
		// Fields
		private Action<object, Rect> setter; // 0x00
	
		// Methods
		public bool ForceStepMode(); // 0x00000001812081B0-0x0000000181208610
		public int RequiredCurvesCount(); // 0x0000000184D882B0-0x0000000184D882C0
		public object ConvertToObject(params float[] floats); // 0x000000018AC553B8-0x000000018AC55454
		public float[] ConvertToFloats(object value); // 0x000000018AC55304-0x000000018AC553B8
		public string GetKeyLabel(params float[] floats); // 0x000000018AC55540-0x000000018AC556D8
		public void SetDirect(object target, MemberInfo info, params float[] floats); // 0x000000018AC556D8-0x000000018AC557D8
		public float[] GetDirect(object target, MemberInfo info); // 0x000000018AC55454-0x000000018AC55540
	}

	[Decorator(typeof(Bounds))]
	public struct Animated_Bounds : IAnimatedParameterModel // TypeDefIndex: 58277
	{
		// Fields
		private Action<object, Bounds> setter; // 0x00
	
		// Methods
		public bool ForceStepMode(); // 0x00000001812081B0-0x0000000181208610
		public int RequiredCurvesCount(); // 0x0000000184D9EC60-0x0000000184D9EC70
		public object ConvertToObject(params float[] floats); // 0x000000018AC53E10-0x000000018AC53F10
		public float[] ConvertToFloats(object value); // 0x000000018AC53CEC-0x000000018AC53E10
		public string GetKeyLabel(params float[] floats); // 0x000000018AC54070-0x000000018AC54284
		public void SetDirect(object target, MemberInfo info, params float[] floats); // 0x000000018AC54284-0x000000018AC543F0
		public float[] GetDirect(object target, MemberInfo info); // 0x000000018AC53F10-0x000000018AC54070
	}

	[Serializable]
	public class AnimationDataCollection : IAnimatableData // TypeDefIndex: 58285
	{
		// Fields
		[SerializeField]
		private List<AnimatedParameter> _animatedParameters; // 0x10
	
		// Properties
		public List<AnimatedParameter> animatedParameters { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public bool isValid { get; } // 0x000000018AC57A90-0x000000018AC57AD4 
		public AnimatedParameter this[int i] { get => default; } // 0x000000018AC57A20-0x000000018AC57A88 
		public AnimatedParameter this[string name] { get => default; } // 0x000000018AC57A88-0x000000018AC57A90 
	
		// Nested types
		public delegate bool AddParameterDelegate(System.Type type, string memberPath, string transformPath); // TypeDefIndex: 58278; 0x00000001814F3120-0x00000001814F3140
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 58279
		{
			// Fields
			public AnimatedParameter newParam; // 0x10
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _TryAddParameter_b__0(AnimatedParameter p); // 0x000000018AC6724C-0x000000018AC67274
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58280
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<AnimatedParameter, string> __9__14_0; // 0x08
			public static Func<AnimatedParameter, string> __9__14_1; // 0x10
			public static Func<float, float> __9__31_1; // 0x18
			public static Func<float, float> __9__32_1; // 0x20
	
			// Constructors
			static __c(); // 0x000000018AC673C4-0x000000018AC67428
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _ReOrderParameters_b__14_0(AnimatedParameter p); // 0x000000018AC671E8-0x000000018AC67208
			internal string _ReOrderParameters_b__14_1(AnimatedParameter p); // 0x000000018AC67208-0x000000018AC67228
			internal float _GetKeyNext_b__31_1(float t); // 0x0000000184D9A920-0x0000000184D9A930
			internal float _GetKeyPrevious_b__32_1(float t); // 0x0000000184D9A920-0x0000000184D9A930
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 58281
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass15_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetParameterOfName_b__0(AnimatedParameter d); // 0x000000018AC67274-0x000000018AC672D4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 58282
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass31_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _GetKeyNext_b__0(AnimatedParameter p); // 0x000000018AC6730C-0x000000018AC67330
			internal bool _GetKeyNext_b__2(float t); // 0x000000018AC67330-0x000000018AC67338
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0 // TypeDefIndex: 58283
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass32_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _GetKeyPrevious_b__0(AnimatedParameter p); // 0x000000018AC67338-0x000000018AC6735C
			internal bool _GetKeyPrevious_b__2(float t); // 0x000000018AC6735C-0x000000018AC67368
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 58284
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass33_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetKeyLabel_b__0(AnimatedParameter p); // 0x000000018AC67368-0x000000018AC6738C
		}
	
		// Constructors
		public AnimationDataCollection(); // 0x00000001841E1670-0x00000001841E1680
		public AnimationDataCollection(IKeyable keyable, System.Type type, string[] memberPaths, string transformPath); // 0x000000018AC5799C-0x000000018AC57A20
	
		// Methods
		public bool TryAddParameter(IKeyable keyable, System.Type type, string memberPath, string transformPath); // 0x000000018AC57594-0x000000018AC577D0
		public void RemoveParameter(AnimatedParameter animParam); // 0x000000018AC570E4-0x000000018AC57138
		public void ReOrderParameters(); // 0x000000018AC56E78-0x000000018AC5706C
		public AnimatedParameter GetParameterOfName(string name); // 0x000000018AC56A98-0x000000018AC56B70
		public AnimationCurve[] GetCurves(); // 0x000000018AC56484-0x000000018AC56490
		public AnimationCurve[] GetCurvesAll(); // 0x000000018AC56478-0x000000018AC56484
		private AnimationCurve[] Internal_GetCurves(bool enabledParamsOnly); // 0x000000018AC56D24-0x000000018AC56E78
		public void Validate(IKeyable keyable); // 0x000000018AC57908-0x000000018AC5799C
		public void SetVirtualTransformParent(Transform virtualTransformParent); // 0x000000018AC5745C-0x000000018AC574F0
		public void SetSnapshot(); // 0x000000018AC573D8-0x000000018AC5745C
		public bool TryAutoKey(float time); // 0x000000018AC577D0-0x000000018AC5788C
		public void Evaluate(float time, float previousTime, float weight = 1f /* Metadata: 0x0234BBFB */); // 0x000000018AC563C0-0x000000018AC56478
		public void RestoreSnapshot(); // 0x000000018AC571BC-0x000000018AC57240
		public bool TryKeyIdentity(float time); // 0x000000018AC5788C-0x000000018AC57908
		public void RemoveKey(float time); // 0x000000018AC5706C-0x000000018AC570E4
		public bool HasChanged(); // 0x000000018AC56BFC-0x000000018AC56C88
		public bool HasKey(float time); // 0x000000018AC56C88-0x000000018AC56D24
		public bool HasAnyKey(); // 0x000000018AC56B70-0x000000018AC56BFC
		public void SetKeyCurrent(float time); // 0x000000018AC57240-0x000000018AC572B8
		public float GetKeyNext(float time); // 0x000000018AC56640-0x000000018AC5686C
		public float GetKeyPrevious(float time); // 0x000000018AC5686C-0x000000018AC56A98
		public string GetKeyLabel(float time); // 0x000000018AC56490-0x000000018AC56640
		public void SetPreWrapMode(UnityEngine.WrapMode mode); // 0x000000018AC57348-0x000000018AC573D8
		public void SetPostWrapMode(UnityEngine.WrapMode mode); // 0x000000018AC572B8-0x000000018AC57348
		public void Reset(); // 0x000000018AC57138-0x000000018AC571BC
		public override string ToString(); // 0x000000018AC574F0-0x000000018AC57594
	}

	[DisallowMultipleComponent]
	public class Cutscene : MonoBehaviour, IDirector // TypeDefIndex: 58295
	{
		// Fields
		public const float VERSION_NUMBER = 2.15f; // Metadata: 0x0234BC02
		[CompilerGenerated]
		private static Action<Cutscene> OnCutsceneStarted; // 0x00
		[CompilerGenerated]
		private static Action<Cutscene> OnCutsceneStopped; // 0x08
		[CompilerGenerated]
		private Action<Section> OnSectionReached; // 0x18
		[CompilerGenerated]
		private Action<string, object> OnGlobalMessageSend; // 0x20
		[CompilerGenerated]
		private Action OnStop; // 0x28
		[HideInInspector]
		[SerializeField]
		private UpdateMode _updateMode; // 0x30
		[HideInInspector]
		[SerializeField]
		private WrapMode _defaultWrapMode; // 0x34
		[HideInInspector]
		[SerializeField]
		private StopMode _defaultStopMode; // 0x38
		[HideInInspector]
		[SerializeField]
		private float _playbackSpeed; // 0x3C
		[HideInInspector]
		[SerializeField]
		private bool _playOnStart; // 0x40
		[HideInInspector]
		[SerializeField]
		private bool _explicitActiveLayers; // 0x41
		[HideInInspector]
		[SerializeField]
		private LayerMask _activeLayers; // 0x44
		[HideInInspector]
		[SerializeField]
		public List<CutsceneGroup> groups; // 0x48
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x50
		[HideInInspector]
		[SerializeField]
		private float _viewTimeMin; // 0x54
		[HideInInspector]
		[SerializeField]
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
		[CompilerGenerated]
		private bool _isBakingRootMotion_k__BackingField; // 0x8A
		[CompilerGenerated]
		private PlayingDirection _playingDirection_k__BackingField; // 0x8C
		[CompilerGenerated]
		private WrapMode _playingWrapMode_k__BackingField; // 0x90
		[CompilerGenerated]
		private List<IDirectable> _directables_k__BackingField; // 0x98
		[CompilerGenerated]
		private bool _isActive_k__BackingField; // 0xA0
		[CompilerGenerated]
		private bool _isPaused_k__BackingField; // 0xA1
		[CompilerGenerated]
		private float _previousTime_k__BackingField; // 0xA4
	
		// Properties
		public Transform groupsRoot { get; } // 0x000000018AC61294-0x000000018AC61448 
		public UpdateMode updateMode { get; set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
		public WrapMode defaultWrapMode { get; set; } // 0x0000000184D86730-0x0000000184D86740 0x0000000184D86760-0x0000000184D86770
		public StopMode defaultStopMode { get; set; } // 0x0000000184D863B0-0x0000000184D863C0 0x0000000184D86430-0x0000000184D86440
		public bool playOnStart { get; set; } // 0x0000000182D480A0-0x0000000182D480B0 0x0000000182D480B0-0x0000000182D480C0
		public bool explicitActiveLayers { get; set; } // 0x0000000184D86F40-0x0000000184D86F50 0x0000000184D86F60-0x0000000184D86F70
		public LayerMask activeLayers { get; set; } // 0x0000000184D86530-0x0000000184D86540 0x0000000184D86580-0x0000000184D86590
		public DirectorGroup directorGroup { get; } // 0x000000018AC610EC-0x000000018AC61294 
		public ActorGroup actorGroup { get; } // 0x000000018AC60E88-0x000000018AC60FB0 
		public virtual bool abortDirectorCamera { get; } // 0x00000001812081B0-0x0000000181208610 
		public virtual bool multiSelectOverlapCheck { get; } // 0x00000001812081B0-0x0000000181208610 
		public bool isBakingRootMotion { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D890B0-0x0000000184D890C0 0x0000000184DA9BE0-0x0000000184DA9BF0
		public CameraTrack cameraTrack { get; } // 0x000000018AC60FB0-0x000000018AC610EC 
		public float currentTime { get; set; } // 0x0000000184D91500-0x0000000184D91510 0x000000018AC617AC-0x000000018AC617D0
		public virtual float length { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x000000018AC617D0-0x000000018AC617E0
		public float viewTimeMin { get; set; } // 0x0000000184D86E00-0x0000000184D86E10 0x000000018AC618B8-0x000000018AC618DC
		public float viewTimeMax { get; set; } // 0x0000000184D88400-0x0000000184D88410 0x000000018AC6182C-0x000000018AC618B8
		public float playTimeMin { get; set; } // 0x0000000184D88480-0x0000000184D88490 0x000000018AC61808-0x000000018AC6182C
		public float playTimeMax { get; set; } // 0x0000000184D88470-0x0000000184D88480 0x000000018AC617E0-0x000000018AC61808
		public float playbackSpeed { get; set; } // 0x0000000184D863E0-0x0000000184D863F0 0x0000000184D86460-0x0000000184D86470
		public PlayingDirection playingDirection { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D90C40-0x0000000184D90C50 0x0000000184D90C60-0x0000000184D90C70
		public WrapMode playingWrapMode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86B60-0x0000000184D86B70 0x0000000184D86BC0-0x0000000184D86BD0
		public List<IDirectable> directables { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x0000000186352D0C-0x0000000186352D20
		public bool isActive { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88020-0x0000000184D88030 0x0000000184D88040-0x0000000184D88050
		public bool isPaused { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88030-0x0000000184D88040 0x0000000184D88050-0x0000000184D88060
		public float previousTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA94B0-0x0000000184DA94C0 0x0000000184DA9BF0-0x0000000184DA9C00
		bool IDirector.isReSampleFrame { get; } // 0x0000000184D89060-0x0000000184D89070 
		GameObject IDirector.context { get; } // 0x000000018AC5FE10-0x000000018AC5FE6C 
		IEnumerable<IDirectable> IDirector.children { get; } // 0x000000018AC5FDD4-0x000000018AC5FE10 
		public float remainingTime { get; } // 0x000000018AC61448-0x000000018AC61474 
	
		// Events
		public static event Action<Cutscene> OnCutsceneStarted {
			add; // 0x000000018AC60B50-0x000000018AC60C14
			remove; // 0x000000018AC61474-0x000000018AC61538
		}
		public static event Action<Cutscene> OnCutsceneStopped {
			add; // 0x000000018AC60C14-0x000000018AC60CDC
			remove; // 0x000000018AC61538-0x000000018AC61600
		}
		public event Action<Section> OnSectionReached {
			add; // 0x000000018AC60D68-0x000000018AC60DF4
			remove; // 0x000000018AC6168C-0x000000018AC61718
		}
		public event Action<string, object> OnGlobalMessageSend {
			add; // 0x000000018AC60CDC-0x000000018AC60D68
			remove; // 0x000000018AC61600-0x000000018AC6168C
		}
		public event Action OnStop {
			add; // 0x000000018AC60DF4-0x000000018AC60E88
			remove; // 0x000000018AC61718-0x000000018AC617AC
		}
	
		// Nested types
		public enum WrapMode // TypeDefIndex: 58286
		{
			Once = 0,
			Loop = 1,
			PingPong = 2
		}
	
		public enum StopMode // TypeDefIndex: 58287
		{
			Skip = 0,
			Rewind = 1,
			Hold = 2,
			SkipRewindNoUndo = 3
		}
	
		public enum UpdateMode // TypeDefIndex: 58288
		{
			Normal = 0,
			AnimatePhysics = 1,
			UnscaledTime = 2,
			Manual = 3
		}
	
		public enum PlayingDirection // TypeDefIndex: 58289
		{
			Forwards = 0,
			Backwards = 1
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58290
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
			static __c(); // 0x000000018AC79E58-0x000000018AC79EBC
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _get_directorGroup_b__62_0(CutsceneGroup g); // 0x000000018AC79954-0x000000018AC79994
			internal bool _get_actorGroup_b__64_0(CutsceneGroup g); // 0x000000018AC798D4-0x000000018AC79914
			internal bool _get_cameraTrack_b__74_0(CutsceneTrack t); // 0x000000018AC79914-0x000000018AC79954
			internal GameObject _GetAffectedActors_b__135_0(ActorGroup g); // 0x000000018AC796DC-0x000000018AC796FC
			internal float _GetPointerTimes_b__136_0(IDirectableTimePointer t); // 0x000000018AC79738-0x000000018AC79754
			internal int _InitializeTimePointers_b__170_0(IDirectableTimePointer a, IDirectableTimePointer b); // 0x000000018AC79754-0x000000018AC79850
			internal string _GetSectionNames_b__190_0(Section s); // 0x0000000186C08908-0x0000000186C08920
			internal string _GetDefinedEventNames_b__191_0(IEvent d); // 0x000000018AC796FC-0x000000018AC79738
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass177_0 // TypeDefIndex: 58291
		{
			// Fields
			public Action callback; // 0x10
			public Cutscene instance; // 0x18
	
			// Constructors
			public __c__DisplayClass177_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Play_b__0(); // 0x000000018AC79AF0-0x000000018AC79B98
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass182_0 // TypeDefIndex: 58292
		{
			// Fields
			public string groupName; // 0x10
	
			// Constructors
			public __c__DisplayClass182_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _SetGroupActorOfName_b__0(ActorGroup g); // 0x000000018AC79B98-0x000000018AC79BF4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass184_0 // TypeDefIndex: 58293
		{
			// Fields
			public string[] split; // 0x10
	
			// Constructors
			public __c__DisplayClass184_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _FindElement_b__0(CutsceneGroup g); // 0x000000018AC79BF4-0x000000018AC79C68
		}
	
		[CompilerGenerated]
		private sealed class _Internal_RenderCutscene_d__194 : IEnumerator<object> // TypeDefIndex: 58294
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Internal_RenderCutscene_d__194(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018AC79450-0x000000018AC79690
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018AC79690-0x000000018AC796DC
		}
	
		// Constructors
		public Cutscene(); // 0x000000018AC60AB8-0x000000018AC60B50
		static Cutscene(); // 0x000000018AC60A24-0x000000018AC60AB8
	
		// Methods
		protected void Awake(); // 0x000000018AC5CA64-0x000000018AC5CB9C
		protected void Start(); // 0x000000018AC5FE6C-0x000000018AC5FE80
		protected void OnDestroy(); // 0x000000018AC5E674-0x000000018AC5E770
		public void ManualUpdate(float deltaTime); // 0x000000018AC5E640-0x000000018AC5E674
		protected void LateUpdate(); // 0x000000018AC5E5DC-0x000000018AC5E640
		protected void FixedUpdate(); // 0x000000018AC5D05C-0x000000018AC5D0A4
		private void DirectorSectionReached(Section section); // 0x000000018AC5CBF4-0x000000018AC5CCC4
		public IEnumerable<GameObject> GetAffectedActors(); // 0x000000018AC5D0A4-0x000000018AC5D1CC
		public float[] GetPointerTimes(); // 0x000000018AC5D310-0x000000018AC5D444
		public void Play(); // 0x000000018AC5F330-0x000000018AC5F33C
		public void Play(Action callback); // 0x000000018AC5F09C-0x000000018AC5F0AC
		public void Play(float startTime); // 0x000000018AC5F0AC-0x000000018AC5F0D4
		public void Play(float startTime, Action callback); // 0x000000018AC5EE94-0x000000018AC5EEBC
		public void Play(float startTime, float endTime, WrapMode wrapMode = WrapMode.Once /* Metadata: 0x0234BBFF */, Action callback = null, PlayingDirection playDirection = PlayingDirection.Forwards /* Metadata: 0x0234BC00 */); // 0x000000018AC5F0D4-0x000000018AC5F330
		public void Stop(); // 0x000000018AC60044-0x000000018AC60050
		public void Stop(StopMode stopMode); // 0x000000018AC5FF18-0x000000018AC60044
		public void PlayReverse(); // 0x000000018AC5EC8C-0x000000018AC5EC9C
		public void PlayReverse(float startTime, float endTime); // 0x000000018AC5EC9C-0x000000018AC5ECC4
		public void Pause(); // 0x0000000184DA9BC0-0x0000000184DA9BD0
		public void Resume(); // 0x0000000184DA9BD0-0x0000000184DA9BE0
		public void SkipAll(); // 0x000000018AC5FD14-0x000000018AC5FD40
		public void Rewind(); // 0x000000018AC5F694-0x000000018AC5F6C4
		public void RewindNoUndo(); // 0x000000018AC5F650-0x000000018AC5F694
		public void BreakCutsceneLoop(); // 0x0000000184DA9BB0-0x0000000184DA9BC0
		public void BreakSectionLoop(bool alsoSkip = false /* Metadata: 0x0234BC01 */); // 0x000000018AC5CB9C-0x000000018AC5CBF4
		[Obsolete("Use \'SkipCurrentSection\' instead")]
		public void Skip(); // 0x000000018AC5FDCC-0x000000018AC5FDD4
		public void SkipCurrentSection(); // 0x000000018AC5FD40-0x000000018AC5FDCC
		public bool JumpToSection(string name); // 0x000000018AC5E5B8-0x000000018AC5E5DC
		public bool JumpToSection(Section section); // 0x000000018AC5E530-0x000000018AC5E5B8
		public bool PlayFromSection(string name); // 0x000000018AC5EB48-0x000000018AC5EB68
		public bool PlayFromSection(string name, WrapMode wrap, Action callback = null); // 0x000000018AC5EB88-0x000000018AC5EBD4
		public bool PlayFromSection(Section section); // 0x000000018AC5EB68-0x000000018AC5EB88
		public bool PlayFromSection(Section section, WrapMode wrap, Action callback = null); // 0x000000018AC5EBD4-0x000000018AC5EC8C
		public bool PlaySection(string name); // 0x000000018AC5EE14-0x000000018AC5EE48
		public bool PlaySection(string name, WrapMode wrap, Action callback = null); // 0x000000018AC5EDA8-0x000000018AC5EDF4
		public bool PlaySection(Section section); // 0x000000018AC5EDF4-0x000000018AC5EE14
		public bool PlaySection(Section section, WrapMode wrap, Action callback = null); // 0x000000018AC5ECC4-0x000000018AC5EDA8
		public void Sample(); // 0x000000018AC5F6C4-0x000000018AC5F6D4
		public void Sample(float time); // 0x000000018AC5F6D4-0x000000018AC5F7E4
		private void Internal_SamplePointers(float currentTime, float previousTime); // 0x000000018AC5E138-0x000000018AC5E530
		public void ReSample(); // 0x000000018AC5F35C-0x000000018AC5F3CC
		public void Validate(); // 0x000000018AC60238-0x000000018AC60A24
		private void InitializeTimePointers(); // 0x000000018AC5D6B4-0x000000018AC5E09C
		private void OnSampleStarted(); // 0x000000018AC5E930-0x000000018AC5EB48
		private void OnSampleEnded(); // 0x000000018AC5E770-0x000000018AC5E930
		private void SetLayersActive(); // 0x000000018AC5FBC4-0x000000018AC5FD14
		private void RestoreLayersActive(); // 0x000000018AC5F4C4-0x000000018AC5F650
		private void UpdateCutscene(float delta); // 0x000000018AC60098-0x000000018AC60238
		public static Cutscene Play(string name); // 0x000000018AC5EE48-0x000000018AC5EE94
		public static Cutscene Play(string name, Action callback); // 0x000000018AC5EEBC-0x000000018AC5F09C
		public static Cutscene FindFromResources(string name); // 0x000000018AC5CE48-0x000000018AC5CF90
		public static Cutscene Find(string name); // 0x000000018AC5CF90-0x000000018AC5D05C
		public static void StopAllCutscenes(); // 0x000000018AC5FE80-0x000000018AC5FF18
		public void SendGlobalMessage(string message, object value = null); // 0x000000018AC5F7E4-0x000000018AC5F9E0
		public void SetGroupActorOfName(string groupName, GameObject newActor); // 0x000000018AC5F9E0-0x000000018AC5FBC4
		public T FindElement<T>(string path)
			where T : IDirectable;
		public IDirectable FindElement(string path); // 0x000000018AC5CCC4-0x000000018AC5CE48
		public override string ToString(); // 0x000000018AC60050-0x000000018AC60098
		public Section GetSectionByName(string name); // 0x000000018AC5D444-0x000000018AC5D474
		public Section GetSectionByUID(string UID); // 0x000000018AC5D474-0x000000018AC5D4A4
		public Section[] GetSections(); // 0x000000018AC5D660-0x000000018AC5D6B4
		public float GetSectionLength(string name); // 0x000000018AC5D4A4-0x000000018AC5D528
		public string[] GetSectionNames(); // 0x000000018AC5D528-0x000000018AC5D660
		public string[] GetDefinedEventNames(); // 0x000000018AC5D1CC-0x000000018AC5D310
		public void PreInitialize(); // 0x000000018AC5F33C-0x000000018AC5F35C
		public void RenderCutscene(int width, int height, int frameRate, Action<Texture2D[]> callback); // 0x000000018AC5F3CC-0x000000018AC5F4C4
		[IteratorStateMachine(typeof(_Internal_RenderCutscene_d__194))]
		private IEnumerator Internal_RenderCutscene(int width, int height, int frameRate, Action<Texture2D[]> callback); // 0x000000018AC5E09C-0x000000018AC5E138
	}

	public abstract class CutsceneGroup : MonoBehaviour, IDirectable // TypeDefIndex: 58304
	{
		// Fields
		[CompilerGenerated]
		private Action<Section> OnSectionReached; // 0x18
		[HideInInspector]
		[SerializeField]
		private List<CutsceneTrack> _tracks; // 0x20
		[HideInInspector]
		[SerializeField]
		private List<Section> _sections; // 0x28
		[HideInInspector]
		[SerializeField]
		private bool _isCollapsed; // 0x30
		[HideInInspector]
		[SerializeField]
		private bool _active; // 0x31
		[HideInInspector]
		[SerializeField]
		private bool _isLocked; // 0x32
		private bool _isReadOnly; // 0x33
		private TransformSnapshot transformSnapshot; // 0x38
		private ObjectSnapshot objectSnapshot; // 0x40
		private GameObject refDuplicateActor; // 0x48
		private static int totalCustomToggleNum; // 0x00
		[HideInInspector]
		[SerializeField]
		public List<CustomToggleInfo> customToggle; // 0x50
		private bool m_customToggleValid; // 0x58
		private bool m_customToggleCheckDirty; // 0x59
		[NonSerialized]
		public Dictionary<int, CustomToggleInfo> customInfoCache; // 0x60
		[CompilerGenerated]
		private IDirector _root_k__BackingField; // 0x68
	
		// Properties
		public abstract new string name { get; set; }
		public abstract GameObject actor { get; set; }
		public abstract ActorReferenceMode referenceMode { get; set; }
		public abstract ActorInitialTransformation initialTransformation { get; set; }
		public abstract Vector3 initialLocalPosition { get; set; }
		public abstract Vector3 initialLocalRotation { get; set; }
		public abstract bool displayVirtualMeshGizmo { get; set; }
		public virtual bool needActor { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public virtual int updateOrder { get; } // 0x0000000184DA3400-0x0000000184DA3410 
		public bool customToggleValid { get; } // 0x000000018AC6E080-0x000000018AC6E0EC 
		public List<CutsceneTrack> tracks { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public List<Section> sections { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		IEnumerable<IDirectable> IDirectable.children { get; } // 0x000000018AC6D04C-0x000000018AC6D088 
		float IDirectable.startTime { get; } // 0x0000000184D879D0-0x0000000184D879E0 
		float IDirectable.endTime { get; } // 0x000000018AC6D088-0x000000018AC6D0A4 
		float IDirectable.blendIn { get; } // 0x0000000184D879D0-0x0000000184D879E0 
		float IDirectable.blendOut { get; } // 0x0000000184D879D0-0x0000000184D879E0 
		bool IDirectable.canCrossBlend { get; } // 0x00000001812081B0-0x0000000181208610 
		IDirectable IDirectable.parent { get; } // 0x00000001811EC580-0x00000001811EC590 
		public IDirector root { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86230-0x0000000184D86240 0x000000018485F170-0x000000018485F180
		public bool isActive { get; set; } // 0x0000000184D86AB0-0x0000000184D86AC0 0x000000018AC6E188-0x000000018AC6E1A4
		public bool isCollapsed { get; set; } // 0x0000000184D865F0-0x0000000184D86600 0x0000000184D86620-0x0000000184D86630
		public bool isLocked { get; set; } // 0x000000018AC6E0EC-0x000000018AC6E0FC 0x0000000184D86DD0-0x0000000184D86DE0
		public bool isReadOnly { get; set; } // 0x0000000184DA9CA0-0x0000000184DA9CB0 0x0000000184DA9CB0-0x0000000184DA9CC0
	
		// Events
		public event Action<Section> OnSectionReached {
			add; // 0x000000018AC6DFF4-0x000000018AC6E080
			remove; // 0x000000018AC6E0FC-0x000000018AC6E188
		}
	
		// Nested types
		public enum ActorReferenceMode // TypeDefIndex: 58296
		{
			UseOriginal = 0,
			UseInstanceHideOriginal = 1
		}
	
		public enum ActorInitialTransformation // TypeDefIndex: 58297
		{
			UseOriginal = 0,
			UseLocal = 1
		}
	
		[Serializable]
		public class CustomToggleInfo // TypeDefIndex: 58298
		{
			// Fields
			public int startIndex; // 0x10
			public int endIndex; // 0x14
			public string desc; // 0x18
			public bool isCollapsed; // 0x20
			[CompilerGenerated]
			private int _index_k__BackingField; // 0x24
			[CompilerGenerated]
			private CutsceneGroup _group_k__BackingField; // 0x28
	
			// Properties
			public int index { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
			public CutsceneGroup group { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
	
			// Constructors
			public CustomToggleInfo(); // 0x0000000184D9E080-0x0000000184D9E090
	
			// Methods
			private void _OnToggleChanged(); // 0x000000018AC6C4A4-0x000000018AC6C4BC
			public IEnumerable _GetAllTrackNames(); // 0x000000018AC6C354-0x000000018AC6C4A4
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58299
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<CustomToggleInfo, int> __9__48_0; // 0x08
			public static Func<CutsceneTrack, bool> __9__88_0; // 0x10
			public static Func<Section, float> __9__88_1; // 0x18
	
			// Constructors
			static __c(); // 0x000000018AC79F20-0x000000018AC79F84
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int __OnCustomToggleValueChanged_b__48_0(CustomToggleInfo t); // 0x000000018AA421AC-0x000000018AA421C4
			internal bool _Validate_b__88_0(CutsceneTrack t); // 0x000000018AC7986C-0x000000018AC798B8
			internal float _Validate_b__88_1(Section s); // 0x000000018AC798B8-0x000000018AC798D4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass89_0 // TypeDefIndex: 58300
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass89_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetSectionByName_b__0(Section s); // 0x000000018AC79CC0-0x000000018AC79D14
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass90_0 // TypeDefIndex: 58301
		{
			// Fields
			public string UID; // 0x10
	
			// Constructors
			public __c__DisplayClass90_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetSectionByUID_b__0(Section s); // 0x0000000186CC7538-0x0000000186CC7560
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass91_0 // TypeDefIndex: 58302
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass91_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetSectionAfter_b__0(Section s); // 0x000000018AC79D88-0x000000018AC79DA8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass92_0 // TypeDefIndex: 58303
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass92_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetSectionBefore_b__0(Section s); // 0x000000018AC79DD4-0x000000018AC79DF4
		}
	
		// Constructors
		protected CutsceneGroup(); // 0x000000018AC6DE44-0x000000018AC6DFF4
		static CutsceneGroup(); // 0x000000018AC6DE08-0x000000018AC6DE44
	
		// Methods
		public void SetCustomToggleDirty(); // 0x000000018AC6CC90-0x000000018AC6CC9C
		private void _OnCustomToggleValueChanged(); // 0x000000018AC6D604-0x000000018AC6D760
		public bool CheckCustomCollapsed(int index); // 0x000000018AC6C4BC-0x000000018AC6C64C
		private void _TryRefreshCustomToggleInfo(); // 0x000000018AC6D760-0x000000018AC6DE08
		public override string ToString(); // 0x000000018AC6D190-0x000000018AC6D1A0
		public void Validate(IDirector root, IDirectable parent); // 0x000000018AC6D310-0x000000018AC6D604
		public Section GetSectionByName(string name); // 0x000000018AC6C7E4-0x000000018AC6C934
		public Section GetSectionByUID(string UID); // 0x000000018AC6C934-0x000000018AC6CA04
		public Section GetSectionAfter(float time); // 0x000000018AC6C64C-0x000000018AC6C718
		public Section GetSectionBefore(float time); // 0x000000018AC6C718-0x000000018AC6C7E4
		bool IDirectable.Initialize(); // 0x000000018AC6CD70-0x000000018AC6CE54
		void IDirectable.Enter(); // 0x000000018AC6CC9C-0x000000018AC6CD10
		void IDirectable.Reverse(); // 0x000000018AC6CEB4-0x000000018AC6CF14
		void IDirectable.Update(float time, float previousTime); // 0x000000018AC6CF14-0x000000018AC6D04C
		void IDirectable.Exit(); // 0x000000018AC6CD10-0x000000018AC6CD70
		void IDirectable.ReverseEnter(); // 0x000000018AC6CE54-0x000000018AC6CEB4
		void IDirectable.RootEnabled(); // 0x00000001841E1670-0x00000001841E1680
		void IDirectable.RootDisabled(); // 0x00000001841E1670-0x00000001841E1680
		void IDirectable.RootUpdated(float time, float previousTime); // 0x00000001841E1670-0x00000001841E1680
		void IDirectable.RootDestroyed(); // 0x00000001841E1670-0x00000001841E1680
		private void StoreActorState(); // 0x000000018AC6D0A4-0x000000018AC6D190
		private void RestoreActorState(); // 0x000000018AC6CB14-0x000000018AC6CB64
		private void TryInstantiateLocalActor(); // 0x000000018AC6D1A0-0x000000018AC6D310
		private void ReleaseLocalActorInstance(); // 0x000000018AC6CA04-0x000000018AC6CAA8
		private void SetActorLocalCoords(); // 0x000000018AC6CB64-0x000000018AC6CC90
		protected GameObject ResolveActor(GameObject original); // 0x000000018AC6CAA8-0x000000018AC6CB14
	}

	public abstract class CutsceneTrack : MonoBehaviour, IDirectable // TypeDefIndex: 58307
	{
		// Fields
		[SerializeField]
		private string _name; // 0x18
		[HideInInspector]
		[SerializeField]
		private UnityEngine.Color _color; // 0x20
		[HideInInspector]
		[SerializeField]
		private bool _active; // 0x30
		[HideInInspector]
		[SerializeField]
		private bool _isLocked; // 0x31
		[HideInInspector]
		[SerializeField]
		private List<ActionClip> _actionClips; // 0x38
		private bool _isReadOnly; // 0x40
		[CompilerGenerated]
		private int _layerOrder_k__BackingField; // 0x44
		[CompilerGenerated]
		private IDirectable _parent_k__BackingField; // 0x48
	
		// Properties
		public GameObject actor { get; } // 0x000000018AC6ECE0-0x000000018AC6ED00 
		public new string name { get; set; } // 0x000000018AC6EE48-0x000000018AC6EE8C 0x000000018AC6EF2C-0x000000018AC6EF74
		public UnityEngine.Color color { get; } // 0x000000018AC6ED08-0x000000018AC6ED40 
		public List<ActionClip> clips { get; set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		public virtual string info { get; } // 0x000000018AC6ED60-0x000000018AC6ED98 
		IEnumerable<IDirectable> IDirectable.children { get; } // 0x000000018AC6E92C-0x000000018AC6E968 
		public int layerOrder { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86530-0x0000000184D86540 0x0000000184D86580-0x0000000184D86590
		public IDirector root { get; } // 0x000000018AC6EEAC-0x000000018AC6EECC 
		public IDirectable parent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
		public virtual bool isCollapsed { get; } // 0x000000018AC6EDC4-0x000000018AC6EDE4 
		public virtual bool isActive { get; set; } // 0x000000018AC6ED98-0x000000018AC6EDC4 0x000000018AC6EEEC-0x000000018AC6EF2C
		public virtual bool isLocked { get; set; } // 0x000000018AC6EDE4-0x000000018AC6EE18 0x0000000184D86AC0-0x0000000184D86AD0
		public virtual float startTime { get; set; } // 0x000000018AC6EECC-0x000000018AC6EEEC 0x00000001841E1670-0x00000001841E1680
		public virtual float endTime { get; set; } // 0x000000018AC6ED40-0x000000018AC6ED60 0x00000001841E1670-0x00000001841E1680
		public virtual float blendIn { get; set; } // 0x0000000184D879D0-0x0000000184D879E0 0x00000001841E1670-0x00000001841E1680
		public virtual float blendOut { get; set; } // 0x0000000184D879D0-0x0000000184D879E0 0x00000001841E1670-0x00000001841E1680
		public bool canCrossBlend { get; } // 0x00000001812081B0-0x0000000181208610 
		public virtual bool needActor { get; } // 0x000000018AC6EE8C-0x000000018AC6EEAC 
		public virtual int updateOrder { get; } // 0x0000000184DA3400-0x0000000184DA3410 
		public bool isReadOnly { get; set; } // 0x000000018AC6EE18-0x000000018AC6EE48 0x0000000182D480B0-0x0000000182D480C0
		public virtual bool canDelete { get; } // 0x000000018AC6ED00-0x000000018AC6ED08 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58305
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ActionClip, float> __9__72_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018AC79EBC-0x000000018AC79F20
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _Validate_b__72_0(ActionClip a); // 0x000000018AC79850-0x000000018AC7986C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass92_0 // TypeDefIndex: 58306
		{
			// Fields
			public ActionClip newAction; // 0x10
	
			// Constructors
			public __c__DisplayClass92_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _AddAction_b__0(ActionClip a); // 0x000000018AC79DA8-0x000000018AC79DD4
		}
	
		// Constructors
		protected CutsceneTrack(); // 0x000000018AC6EC48-0x000000018AC6ECE0
	
		// Methods
		bool IDirectable.Initialize(); // 0x000000018AC6E8F8-0x000000018AC6E908
		void IDirectable.Enter(); // 0x000000018AC6E8D8-0x000000018AC6E8E8
		void IDirectable.Update(float time, float previousTime); // 0x000000018AC6E918-0x000000018AC6E92C
		void IDirectable.Exit(); // 0x000000018AC6E8E8-0x000000018AC6E8F8
		void IDirectable.ReverseEnter(); // 0x000000018AC6E908-0x000000018AC6E918
		void IDirectable.Reverse(); // 0x00000001885D1220-0x00000001885D1230
		void IDirectable.RootEnabled(); // 0x00000001841E1670-0x00000001841E1680
		void IDirectable.RootDisabled(); // 0x00000001841E1670-0x00000001841E1680
		void IDirectable.RootUpdated(float time, float previousTime); // 0x00000001841E1670-0x00000001841E1680
		void IDirectable.RootDestroyed(); // 0x00000001841E1670-0x00000001841E1680
		public void PostCreate(IDirectable parent); // 0x000000018AC6E8B0-0x000000018AC6E8D8
		public void Validate(IDirector root, IDirectable parent); // 0x000000018AC6E9EC-0x000000018AC6EC48
		protected virtual void OnCreate(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnAfterValidate(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual bool OnInitialize(); // 0x0000000182FFF600-0x0000000182FFF610
		protected virtual void OnEnter(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnUpdate(float time, float previousTime); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnExit(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnReverseEnter(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnReverse(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnDrawGizmosSelected(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnSceneGUI(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnRootEnabled(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnRootDisabled(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnRootUpdated(float time, float previousTime); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnRootDestroyed(); // 0x00000001841E1670-0x00000001841E1680
		public float GetTrackWeight(); // 0x000000018AC6E818-0x000000018AC6E8B0
		public float GetTrackWeight(float time); // 0x000000018AC6E7BC-0x000000018AC6E818
		public float GetTrackWeight(float time, float blendInOut); // 0x000000018AC4FEA8-0x000000018AC4FEC4
		public float GetTrackWeight(float time, float blendIn, float blendOut); // 0x000000018AC4FEC4-0x000000018AC4FED4
		public T AddAction<T>(float time)
			where T : ActionClip;
		public ActionClip AddAction(System.Type type, float time); // 0x000000018AC6E4DC-0x000000018AC6E7BC
		[CompilerGenerated]
		private bool _Validate_b__72_1(IDirectable t); // 0x000000018AC6E968-0x000000018AC6E9EC
	}

	public interface IAnimatableData // TypeDefIndex: 58308
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

	public interface IDirectable // TypeDefIndex: 58309
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

	public interface IKeyable : IDirectable // TypeDefIndex: 58310
	{
		// Properties
		AnimationDataCollection animationData { get; }
		object animatedParametersTarget { get; }
	}

	public interface ISubClipContainable : IDirectable // TypeDefIndex: 58311
	{
		// Properties
		float subClipOffset { get; set; }
		float subClipSpeed { get; }
		float subClipLength { get; }
	}

	public static class IDirectableExtensions // TypeDefIndex: 58315
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 58312
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _FindChild_b__0(IDirectable d); // 0x000000018AC799F4-0x000000018AC79A50
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 58313
		{
			// Fields
			public IDirectable directable; // 0x10
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetPreviousSibling_b__0(IDirectable d); // 0x000000018AC79A50-0x000000018AC79AA0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 58314
		{
			// Fields
			public IDirectable directable; // 0x10
	
			// Constructors
			public __c__DisplayClass16_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetNextSibling_b__0(IDirectable d); // 0x000000018AC79AA0-0x000000018AC79AF0
		}
	
		// Extension methods
		public static float GetLength(this IDirectable directable); // 0x000000018AC71500-0x000000018AC7153C
		public static float RootTimeToLocalTime(this IDirectable directable); // 0x000000018AC71D54-0x000000018AC71D90
		public static float RootTimeToLocalTimeUnclamped(this IDirectable directable); // 0x000000018AC71D18-0x000000018AC71D54
		public static bool IsRootTimeWithinClip(this IDirectable directable); // 0x000000018AC71C90-0x000000018AC71CCC
		public static float ToLocalTime(this IDirectable directable, float time); // 0x000000018AC71DC0-0x000000018AC71E20
		public static float ToLocalTimeUnclamped(this IDirectable directable, float time); // 0x000000018AC71D90-0x000000018AC71DC0
		public static bool IsTimeWithinClip(this IDirectable directable, float time); // 0x000000018AC71CCC-0x000000018AC71D18
		public static bool CanCrossBlend(this IDirectable directable, IDirectable other); // 0x000000018AC71218-0x000000018AC712A4
		public static bool CanBlendIn(this IDirectable directable); // 0x000000018AC71028-0x000000018AC71120
		public static bool CanBlendOut(this IDirectable directable); // 0x000000018AC71120-0x000000018AC71218
		public static bool CanScale(this IDirectable directable); // 0x000000018AC712A4-0x000000018AC7138C
		public static bool WithinBufferTriggerRange(this IDirectable directable, float time, float previousTime, bool bypass = false /* Metadata: 0x0234BC17 */); // 0x000000018AC72004-0x000000018AC72094
		public static IDirectable FindChild(this IDirectable directable, string name); // 0x000000018AC7138C-0x000000018AC71474
		public static T GetPreviousSibling<T>(this IDirectable directable)
			where T : IDirectable;
		public static IDirectable GetPreviousSibling(this IDirectable directable); // 0x000000018AC71768-0x000000018AC71864
		public static T GetNextSibling<T>(this IDirectable directable)
			where T : IDirectable;
		public static IDirectable GetNextSibling(this IDirectable directable); // 0x000000018AC715DC-0x000000018AC716D8
		public static T GetFirstParentOfType<T>(this IDirectable directable)
			where T : IDirectable;
		public static float GetWeight(this IDirectable directable); // 0x000000018AC71A94-0x000000018AC71AB8
		public static float GetWeight(this IDirectable directable, float time); // 0x000000018AC719A8-0x000000018AC71A00
		public static float GetWeight(this IDirectable directable, float time, float blendInOut); // 0x000000018AC4FEA8-0x000000018AC4FEC4
		public static float GetWeight(this IDirectable directable, float time, float blendIn, float blendOut); // 0x000000018AC71A00-0x000000018AC71A94
		public static Transform GetSpaceTransform(this IDirectable directable, TransformSpace space, GameObject actorOverride = null); // 0x000000018AC71864-0x000000018AC719A8
		public static Vector3 TransformPosition(this IDirectable directable, Vector3 point, TransformSpace space); // 0x000000018AC71E20-0x000000018AC71EEC
		public static Vector3 InverseTransformPosition(this IDirectable directable, Vector3 point, TransformSpace space); // 0x000000018AC71AB8-0x000000018AC71B84
		public static Quaternion TransformRotation(this IDirectable directable, Vector3 euler, TransformSpace space); // 0x000000018AC71EEC-0x000000018AC72004
		public static Vector3 InverseTransformRotation(this IDirectable directable, Quaternion rot, TransformSpace space); // 0x000000018AC71B84-0x000000018AC71C90
		public static Vector3 ActorPositionInSpace(this IDirectable directable, TransformSpace space); // 0x000000018AC70EF4-0x000000018AC71028
		public static float GetPreviousLoopLocalTime(this ISubClipContainable clip); // 0x000000018AC716D8-0x000000018AC71768
		public static float GetNextLoopLocalTime(this ISubClipContainable clip); // 0x000000018AC7153C-0x000000018AC715DC
		public static AnimationCurve[] GetCurvesAll(this IKeyable keyable); // 0x000000018AC71474-0x000000018AC71500
	}

	public interface IDirector // TypeDefIndex: 58316
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
	public class Section // TypeDefIndex: 58318
	{
		// Fields
		public static readonly UnityEngine.Color DEFAULT_COLOR; // 0x00
		[SerializeField]
		private string _UID; // 0x10
		[SerializeField]
		private string _name; // 0x18
		[SerializeField]
		private float _time; // 0x20
		[SerializeField]
		private ExitMode _exitMode; // 0x24
		[SerializeField]
		private int _loopCount; // 0x28
		[SerializeField]
		private UnityEngine.Color _color; // 0x2C
		[SerializeField]
		private bool _colorizeBackground; // 0x3C
		[CompilerGenerated]
		private int _currentLoopIteration_k__BackingField; // 0x40
	
		// Properties
		public int currentLoopIteration { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D865E0-0x0000000184D865F0 0x0000000184D86610-0x0000000184D86620
		public string UID { get; private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public string name { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public float time { get; set; } // 0x00000001811EC8A0-0x00000001811EC8B0 0x00000001811EC9E0-0x00000001811EC9F0
		public ExitMode exitMode { get; set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
		public int loopCount { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
		public UnityEngine.Color color { get; set; } // 0x000000018AC77064-0x000000018AC770D4 0x0000000184D8D3A0-0x0000000184D8D3B0
		public bool colorizeBackground { get; set; } // 0x0000000184D86BD0-0x0000000184D86BE0 0x0000000184D86BE0-0x0000000184D86BF0
	
		// Nested types
		public enum ExitMode // TypeDefIndex: 58317
		{
			Continue = 0,
			Loop = 1
		}
	
		// Constructors
		public Section(string name, float time); // 0x000000018AC76FB4-0x000000018AC77064
		static Section(); // 0x000000018AC76F48-0x000000018AC76FB4
	
		// Methods
		public void ResetLoops(); // 0x0000000184DA9D20-0x0000000184DA9D30
		public void BreakLoop(); // 0x0000000184DA9D10-0x0000000184DA9D20
		public bool TryUpdateLoop(); // 0x000000018AC76F28-0x000000018AC76F48
		public override string ToString(); // 0x000000018AC76EB4-0x000000018AC76F28
	}

	public interface IDirectableTimePointer // TypeDefIndex: 58319
	{
		// Properties
		IDirectable target { get; }
		float time { get; }
	
		// Methods
		void TriggerForward(float currentTime, float previousTime);
		void TriggerBackward(float currentTime, float previousTime);
		void Update(float currentTime, float previousTime);
	}

	public struct StartTimePointer : IDirectableTimePointer // TypeDefIndex: 58320
	{
		// Fields
		private bool triggered; // 0x00
		private float lastTargetStartTime; // 0x04
		[CompilerGenerated]
		private IDirectable _target_k__BackingField; // 0x08
	
		// Properties
		public IDirectable target { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000184D88320-0x0000000184D88330 0x00000001867D5E9C-0x00000001867D5EAC
		float IDirectableTimePointer.time { get; } // 0x000000018AC78388-0x000000018AC783A4 
	
		// Constructors
		public StartTimePointer(IDirectable target); // 0x000000018AC783A4-0x000000018AC783E0
	
		// Methods
		void IDirectableTimePointer.TriggerForward(float currentTime, float previousTime); // 0x000000018AC781BC-0x000000018AC78238
		void IDirectableTimePointer.Update(float currentTime, float previousTime); // 0x000000018AC78238-0x000000018AC78388
		void IDirectableTimePointer.TriggerBackward(float currentTime, float previousTime); // 0x000000018AC78120-0x000000018AC781BC
	}

	public struct EndTimePointer : IDirectableTimePointer // TypeDefIndex: 58321
	{
		// Fields
		private bool triggered; // 0x00
		[CompilerGenerated]
		private IDirectable _target_k__BackingField; // 0x08
	
		// Properties
		public IDirectable target { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000184D88320-0x0000000184D88330 0x00000001867D5E9C-0x00000001867D5EAC
		float IDirectableTimePointer.time { get; } // 0x000000018AC70874-0x000000018AC70890 
	
		// Constructors
		public EndTimePointer(IDirectable target); // 0x000000018AC70890-0x000000018AC708B0
	
		// Methods
		void IDirectableTimePointer.TriggerForward(float currentTime, float previousTime); // 0x000000018AC70794-0x000000018AC70828
		void IDirectableTimePointer.Update(float currentTime, float previousTime); // 0x000000018AC70828-0x000000018AC70874
		void IDirectableTimePointer.TriggerBackward(float currentTime, float previousTime); // 0x000000018AC7070C-0x000000018AC70794
	}

	[AddComponentMenu("SLATE/Path")]
	public class BezierPath : Path // TypeDefIndex: 58322
	{
		// Fields
		[Range(0f, 100f)]
		public int resolution; // 0x18
		[SerializeField]
		private List<Slate.BezierPoint> _points; // 0x20
		private Vector3[] _sampledPathPoints; // 0x28
		private float _length; // 0x30
	
		// Properties
		public List<Slate.BezierPoint> points { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public Slate.BezierPoint this[int index] { get => default; } // 0x000000018AC6A8DC-0x000000018AC6A930 
		public int pointCount { get; } // 0x000000018AC6A930-0x000000018AC6A970 
		public override float length { get; } // 0x0000000184D86E20-0x0000000184D86E30 
	
		// Constructors
		public BezierPath(); // 0x000000018AC6A854-0x000000018AC6A8DC
	
		// Methods
		private void Awake(); // 0x0000000189DEBAEC-0x0000000189DEBAFC
		private void OnValidate(); // 0x0000000189DEBAEC-0x0000000189DEBAFC
		public override void Compute(); // 0x000000018AC6A19C-0x000000018AC6A1C4
		public void SetDirty(); // 0x0000000189DEBAEC-0x0000000189DEBAFC
		private void ComputeLength(); // 0x000000018AC6A010-0x000000018AC6A030
		private void ComputeSampledPathPoints(); // 0x000000018AC6A030-0x000000018AC6A19C
		public static BezierPath Create(Transform targetParent = null); // 0x000000018AC6A1C4-0x000000018AC6A48C
		public Slate.BezierPoint AddPointAt(Vector3 position, int index = -1 /* Metadata: 0x0234BC1A */); // 0x000000018AC69F28-0x000000018AC6A010
		public void RemovePoint(Slate.BezierPoint point); // 0x000000018AC6A7F4-0x000000018AC6A854
		public int GetPointIndex(Slate.BezierPoint point); // 0x000000018AC6A48C-0x000000018AC6A510
		public static Vector3[] GetSampledPathPositions(Slate.BezierPoint p1, Slate.BezierPoint p2, int resolution); // 0x000000018AC6A6E8-0x000000018AC6A7F4
		public override Vector3 GetPositionAt(float t); // 0x000000018AC6A618-0x000000018AC6A6E8
		public static Vector3 GetPositionAt(Slate.BezierPoint p1, Slate.BezierPoint p2, float t); // 0x000000018AC6A510-0x000000018AC6A618
	}

	[Serializable]
	public class BezierPoint // TypeDefIndex: 58324
	{
		// Fields
		[ReadOnly]
		[SerializeField]
		private BezierPath _path; // 0x10
		[SerializeField]
		public Vector3 _position; // 0x18
		[SerializeField]
		private Vector3 _handle1; // 0x24
		[SerializeField]
		private Vector3 _handle2; // 0x30
		[SerializeField]
		private HandleStyle _handleStyle; // 0x3C
	
		// Properties
		public HandleStyle handleStyle { get; set; } // 0x0000000184D86640-0x0000000184D86650 0x0000000184D86670-0x0000000184D86680
		public BezierPath path { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public Vector3 position { get; set; } // 0x000000018AC6AB08-0x000000018AC6AB78 0x000000018AC6AE60-0x000000018AC6AECC
		public Vector3 handle1LocalPosition { get; private set; } // 0x0000000184D905E0-0x0000000184D90600 0x000000018AC6AB78-0x000000018AC6AC30
		public Vector3 handle2LocalPosition { get; private set; } // 0x0000000184D88ED0-0x0000000184D88EF0 0x000000018AC6ACEC-0x000000018AC6ADA4
		public Vector3 handle1Position { get; set; } // 0x000000018AC6A9B0-0x000000018AC6AA5C 0x000000018AC6AC30-0x000000018AC6ACEC
		public Vector3 handle2Position { get; set; } // 0x000000018AC6AA5C-0x000000018AC6AB08 0x000000018AC6ADA4-0x000000018AC6AE60
	
		// Nested types
		public enum HandleStyle // TypeDefIndex: 58323
		{
			Connected = 0,
			Broken = 1
		}
	
		// Constructors
		public BezierPoint(BezierPath path, Vector3 position); // 0x000000018AC6A970-0x000000018AC6A9B0
	}

	public abstract class Path : MonoBehaviour // TypeDefIndex: 58325
	{
		// Properties
		public abstract float length { get; }
	
		// Constructors
		protected Path(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public abstract Vector3 GetPositionAt(float t);
		public abstract void Compute();
		public static Vector3 GetPositionAlongCurve(Vector3 from, Vector3 to, Vector3 fromTangent, Vector3 toTangent, float t); // 0x000000018AC72AE0-0x000000018AC72CD8
		public static Vector3 GetPosition(float t, params Vector3[] path); // 0x000000018AC72CD8-0x000000018AC72EDC
		public static float GetLength(Vector3[] path); // 0x000000018AC72A34-0x000000018AC72AE0
	}

	public static class AnimationDataUtility // TypeDefIndex: 58326
	{
		// Methods
		public static string[] GetAnimatableMemberPaths(object root); // 0x000000018AC69048-0x000000018AC690A4
		private static string[] Internal_GetAnimatableMemberPaths(System.Type type, string path); // 0x000000018AC690A4-0x000000018AC6941C
	}

	[ExecuteInEditMode]
	public class AnimatorDispatcher : MonoBehaviour // TypeDefIndex: 58327
	{
		// Fields
		[CompilerGenerated]
		private Action<int> onAnimatorIK; // 0x18
		private Animator _animator; // 0x20
	
		// Properties
		private Animator animator { get; } // 0x000000018AC694BC-0x000000018AC69548 
	
		// Events
		public event Action<int> onAnimatorIK {
			add; // 0x000000018AC69430-0x000000018AC694BC
			remove; // 0x000000018AC69548-0x000000018AC695D4
		}
	
		// Constructors
		public AnimatorDispatcher(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void OnAnimatorIK(int index); // 0x000000018AC6941C-0x000000018AC69430
	}

	public static class AudioSampler // TypeDefIndex: 58329
	{
		// Fields
		private const string ROOT_NAME = "_AudioSources"; // Metadata: 0x0234BC1D
		private static GameObject root; // 0x00
		private static Dictionary<object, AudioSource> sources; // 0x08
	
		// Nested types
		[Serializable]
		public struct SampleSettings // TypeDefIndex: 58328
		{
			// Fields
			public float volume; // 0x00
			public float pitch; // 0x04
			public float pan; // 0x08
			public float spatialBlend; // 0x0C
			public bool ignoreTimescale; // 0x10
			public bool bypassReverb; // 0x11
	
			// Methods
			public static SampleSettings Default(); // 0x0000000184DA9CC0-0x0000000184DA9CE0
		}
	
		// Constructors
		static AudioSampler(); // 0x000000018AC69E94-0x000000018AC69F28
	
		// Methods
		public static AudioSource GetSourceForID(object keyID); // 0x000000018AC695D4-0x000000018AC698B0
		public static void ReleaseSourceForID(object keyID); // 0x000000018AC698B0-0x000000018AC69A3C
		public static void SampleForID(object keyID, AudioClip clip, float time, float previousTime, float volume); // 0x000000018AC69A3C-0x000000018AC69B00
		public static void SampleForID(object keyID, AudioClip clip, float time, float previousTime, SampleSettings settings); // 0x000000018AC69B00-0x000000018AC69BA4
		public static void Sample(AudioSource source, AudioClip clip, float time, float previousTime, float volume); // 0x000000018AC69BA4-0x000000018AC69C68
		public static void Sample(AudioSource source, AudioClip clip, float time, float previousTime, SampleSettings settings); // 0x000000018AC69C68-0x000000018AC69E94
	}

	public static class ColorUtility // TypeDefIndex: 58330
	{
		// Methods
		public static UnityEngine.Color Grey(float value); // 0x0000000184DA6870-0x0000000184DA6890
	
		// Extension methods
		public static UnityEngine.Color WithAlpha(this UnityEngine.Color color, float alpha); // 0x0000000184DA6890-0x0000000184DA68B0
	}

	public enum TangentMode // TypeDefIndex: 58331
	{
		Editable = 0,
		Smooth = 1,
		Linear = 2,
		Constant = 3
	}

	public static class CurveUtility // TypeDefIndex: 58336
	{
		// Fields
		private const float KEY_PROXIMITY_TOLERANCE = 0.001f; // Metadata: 0x0234BC2F
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 58332
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetKeyNext_b__1(Keyframe k); // 0x000000018AC79C68-0x000000018AC79C84
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58333
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Keyframe, float> __9__1_0; // 0x08
			public static Func<Keyframe, float> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018AC79DF4-0x000000018AC79E58
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _GetKeyNext_b__1_0(Keyframe k); // 0x0000000184DA9D30-0x0000000184DA9D40
			internal float _GetKeyPrevious_b__2_0(Keyframe k); // 0x0000000184DA9D30-0x0000000184DA9D40
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 58334
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetKeyPrevious_b__1(Keyframe k); // 0x000000018AC79C84-0x000000018AC79C9C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 58335
		{
			// Fields
			public float time; // 0x10
			public Func<Keyframe, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _HasKey_b__0(Keyframe k); // 0x000000018AC79C9C-0x000000018AC79CC0
		}
	
		// Methods
		public static float GetKeyNext(float time, params AnimationCurve[] curves); // 0x000000018AC6BA24-0x000000018AC6BC70
		public static float GetKeyPrevious(float time, params AnimationCurve[] curves); // 0x000000018AC6BC70-0x000000018AC6BED8
		public static bool HasKey(float time, params AnimationCurve[] curves); // 0x000000018AC6BF2C-0x000000018AC6C070
		public static bool HasAnyKey(params AnimationCurve[] curves); // 0x000000018AC6BED8-0x000000018AC6BF2C
	
		// Extension methods
		public static void OffsetCurveValue(this AnimationCurve curve, float deltaValue); // 0x000000018AC6C160-0x000000018AC6C200
		public static void OffsetCurveTime(this AnimationCurve curve, float deltaTime); // 0x000000018AC6C070-0x000000018AC6C160
		public static void RemoveNegativeKeys(this AnimationCurve curve); // 0x000000018AC6C340-0x000000018AC6C354
		public static void RemoveKeysOffRange(this AnimationCurve curve, float min, float max); // 0x000000018AC6C200-0x000000018AC6C340
	}

	public class DecoratorAttribute : Attribute // TypeDefIndex: 58337
	{
		// Fields
		public readonly System.Type targetType; // 0x10
	
		// Constructors
		public DecoratorAttribute(System.Type targetType); // 0x00000001853908C0-0x00000001853908D0
	}

	public interface IDecorator // TypeDefIndex: 58338
	{
		// Properties
		object Target { get; set; }
	}

	public static class DecoratorFactory // TypeDefIndex: 58339
	{
		// Fields
		private static Dictionary<System.Type, System.Type> decoratorsTypeMap; // 0x00
		private static Dictionary<object, IDecorator> decoratorsInstanceMap; // 0x08
	
		// Constructors
		static DecoratorFactory(); // 0x000000018AC6EF74-0x000000018AC6F068
	
		// Methods
		public static T GetDecorator<T>(object target)
			where T : IDecorator;
		private static T CreateDecorator<T>(System.Type targetType)
			where T : IDecorator;
	
		// Extension methods
		public static T Decorator<T>(this object target)
			where T : IDecorator;
	}

	public enum EaseType // TypeDefIndex: 58340
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

	public static class Easing // TypeDefIndex: 58341
	{
		// Methods
		public static float Ease(Slate.EaseType type, float from, float to, float t); // 0x000000018AC6FCF4-0x000000018AC6FD78
		public static Vector3 Ease(Slate.EaseType type, Vector3 from, Vector3 to, float t); // 0x000000018AC6FEF8-0x000000018AC6FFDC
		public static Quaternion Ease(Slate.EaseType type, Quaternion from, Quaternion to, float t); // 0x000000018AC6FD78-0x000000018AC6FE3C
		public static UnityEngine.Color Ease(Slate.EaseType type, UnityEngine.Color from, UnityEngine.Color to, float t); // 0x000000018AC6FE3C-0x000000018AC6FEF8
		public static Func<float, float> Function(Slate.EaseType type); // 0x000000018AC6FFDC-0x000000018AC7070C
		public static float Linear(float t); // 0x00000001841E1670-0x00000001841E1680
		public static float QuadraticIn(float t); // 0x0000000184D886E0-0x0000000184D886F0
		public static float QuadraticOut(float t); // 0x0000000184DA6AB0-0x0000000184DA6AD0
		public static float QuadraticInOut(float t); // 0x000000018A9A0E30-0x000000018A9A0E8C
		public static float QuarticIn(float t); // 0x0000000184DA6AD0-0x0000000184DA6AE0
		public static float QuarticOut(float t); // 0x0000000184DA6AE0-0x0000000184DA6B10
		public static float QuarticInOut(float t); // 0x000000018A9A0E8C-0x000000018A9A0EE0
		public static float QuinticIn(float t); // 0x0000000184DA6B10-0x0000000184DA6B30
		public static float QuinticOut(float t); // 0x0000000184DA6B30-0x0000000184DA6B60
		public static float QuinticInOut(float t); // 0x000000018A9A0EE0-0x000000018A9A0F3C
		public static float CubicIn(float t); // 0x0000000184D89930-0x0000000184D89940
		public static float CubicOut(float t); // 0x0000000184DA69A0-0x0000000184DA69C0
		public static float CubicInOut(float t); // 0x000000018A9A01E0-0x000000018A9A0248
		public static float SinusoidalIn(float t); // 0x000000018A9A0F3C-0x000000018A9A0F6C
		public static float SinusoidalOut(float t); // 0x000000018A9A0F6C-0x000000018A9A0F84
		public static float SinusoidalInOut(float t); // 0x0000000184DA6B60-0x0000000184DA6B90
		public static float ExponentialIn(float t); // 0x000000018A9A0690-0x000000018A9A06BC
		public static float ExponentialOut(float t); // 0x000000018A9A06BC-0x000000018A9A0700
		public static float ExponentialInOut(float t); // 0x000000018A9A0610-0x000000018A9A0690
		public static float CircularIn(float t); // 0x0000000184DA6910-0x0000000184DA6970
		public static float CircularOut(float t); // 0x0000000184DA6970-0x0000000184DA69A0
		public static float CircularInOut(float t); // 0x000000018A9A017C-0x000000018A9A01E0
		public static float ElasticIn(float t); // 0x0000000184DA69C0-0x0000000184DA6A40
		public static float ElasticOut(float t); // 0x0000000184DA6A40-0x0000000184DA6AB0
		public static float ElasticInOut(float t); // 0x000000018A9A0530-0x000000018A9A0610
		public static float BounceIn(float t); // 0x000000018A9A00B0-0x000000018A9A00E4
		public static float BounceOut(float t); // 0x000000018A9A00E4-0x000000018A9A017C
		public static float BounceInOut(float t); // 0x000000018A9A0044-0x000000018A9A00B0
		public static float BackIn(float t); // 0x0000000184DA68C0-0x0000000184DA68E0
		public static float BackOut(float t); // 0x0000000184DA68E0-0x0000000184DA6910
		public static float BackInOut(float t); // 0x000000018A99FFDC-0x000000018A9A0044
	}

	public interface ITransformRefParameter // TypeDefIndex: 58342
	{
		// Properties
		Transform transform { get; }
		TransformSpace space { get; }
		bool useAnimation { get; }
	}

	public class ObjectSnapshot // TypeDefIndex: 58343
	{
		// Fields
		private static List<System.Type> ignoreTypes; // 0x00
		private Dictionary<UnityEngine.Object, string> serialized; // 0x10
	
		// Constructors
		public ObjectSnapshot(UnityEngine.Object target, bool fullObjectHierarchy = false /* Metadata: 0x0234BC52 */); // 0x000000018AC72994-0x000000018AC72A34
		static ObjectSnapshot(); // 0x000000018AC72908-0x000000018AC72994
	
		// Methods
		public static void AppendIgnoreType(System.Type type); // 0x000000018AC7235C-0x000000018AC7240C
		public void Store(UnityEngine.Object target, bool fullObjectHierarchy = false /* Metadata: 0x0234BC53 */); // 0x000000018AC7264C-0x000000018AC72908
		public void Restore(); // 0x000000018AC7240C-0x000000018AC7264C
	}

	public static class RectUtility // TypeDefIndex: 58344
	{
		// Methods
		public static Rect GetBoundRect(params Rect[] rects); // 0x000000018A996768-0x000000018A996888
		public static Rect GetBoundRect(params Vector2[] positions); // 0x000000018A996888-0x000000018A996998
	
		// Extension methods
		public static bool Encapsulates(this Rect a, Rect b); // 0x000000018AC74978-0x000000018AC74A30
		public static Rect ExpandBy(this Rect rect, float margin); // 0x000000018AC74A94-0x000000018AC74AD0
		public static Rect ExpandBy(this Rect rect, float xMargin, float yMargin); // 0x000000018AC74A30-0x000000018AC74A94
		public static Rect TransformSpace(this Rect rect, Rect oldContainer, Rect newContainer); // 0x000000018A996A18-0x000000018A996B50
		public static Rect ToViewRect(this Bounds b, Camera cam); // 0x000000018AC74AD0-0x000000018AC75244
	}

	public static class ReflectionTools // TypeDefIndex: 58347
	{
		// Fields
		private const System.Reflection.BindingFlags flagsEverything = System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic; // Metadata: 0x0234BC57
		private static List<Assembly> _loadedAssemblies; // 0x00
		private static Dictionary<string, System.Type> typeMap; // 0x08
		private static Dictionary<System.Type, System.Type[]> subTypesMap; // 0x10
	
		// Properties
		private static List<Assembly> loadedAssemblies { get; } // 0x000000018AC76DE4-0x000000018AC76EB4 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 58345
		{
			// Fields
			public System.Type type; // 0x10
			public Func<System.Type, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetImplementationsOf_b__0(System.Type t); // 0x000000018AC79D14-0x000000018AC79D88
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0<T, TValue> // TypeDefIndex: 58346
		{
			// Fields
			public MemberInfo info;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _GetFieldOrPropSetter_b__0(T x, TValue v);
		}
	
		// Constructors
		static ReflectionTools(); // 0x000000018AC76CE8-0x000000018AC76DE4
	
		// Methods
		public static System.Type GetType(string typeName); // 0x000000018AC76184-0x000000018AC7662C
		public static System.Type[] GetAllTypes(); // 0x000000018AC75334-0x000000018AC75584
		public static System.Type[] GetImplementationsOf(System.Type type); // 0x000000018AC75584-0x000000018AC75A34
		public static Action<T, TValue> GetFieldOrPropSetter<T, TValue>(MemberInfo info);
		public static MemberInfo GetRelativeMember(object root, string path); // 0x000000018AC76110-0x000000018AC76184
		public static MemberInfo GetRelativeMember(System.Type type, string path); // 0x000000018AC75FBC-0x000000018AC76110
		public static object GetRelativeMemberParent(object root, string path); // 0x000000018AC75E78-0x000000018AC75FBC
		public static string GetMemberPath<T, TResult>(Expression<Func<T, TResult>> func);
		public static string[] GetMemberPaths(System.Type type, Predicate<System.Type> shouldInclude, Predicate<System.Type> shouldContinue, string currentPath = "" /* Metadata: 0x0234BC56 */, List<System.Type> recursionCheck = null); // 0x000000018AC75A34-0x000000018AC75E78
	
		// Extension methods
		private static System.Type[] RTGetExportedTypes(this Assembly asm); // 0x000000018AC7662C-0x000000018AC7664C
		public static string FriendlyName(this System.Type type); // 0x000000018AC75244-0x000000018AC75334
		public static bool RTIsStatic(this PropertyInfo propertyInfo); // 0x000000018AC76AB4-0x000000018AC76B64
		public static bool RTIsAbstract(this System.Type type); // 0x000000018A989920-0x000000018A98993C
		public static bool RTIsSubclassOf(this System.Type type, System.Type other); // 0x000000018A9899E8-0x000000018A989A0C
		public static bool RTIsAssignableFrom(this System.Type type, System.Type second); // 0x000000018AC76A90-0x000000018AC76AB4
		public static System.Reflection.FieldInfo RTGetField(this System.Type type, string name); // 0x000000018AC768FC-0x000000018AC76920
		public static PropertyInfo RTGetProperty(this System.Type type, string name); // 0x000000018AC76A6C-0x000000018AC76A90
		public static MethodInfo RTGetMethod(this System.Type type, string name); // 0x000000018AC76A24-0x000000018AC76A48
		public static System.Reflection.FieldInfo[] RTGetFields(this System.Type type); // 0x000000018AC76A00-0x000000018AC76A24
		public static PropertyInfo[] RTGetProperties(this System.Type type); // 0x000000018AC76A48-0x000000018AC76A6C
		public static MethodInfo RTGetGetMethod(this PropertyInfo prop); // 0x000000018A989524-0x000000018A989540
		public static MethodInfo RTGetSetMethod(this PropertyInfo prop); // 0x000000018A989904-0x000000018A989920
		public static System.Type RTReflectedType(this System.Type type); // 0x000000018AC76B64-0x000000018AC76B84
		public static System.Type RTReflectedType(this MemberInfo member); // 0x000000018AC76B64-0x000000018AC76B84
		public static T RTGetAttribute<T>(this System.Type type, bool inherited)
			where T : Attribute;
		public static T RTGetAttribute<T>(this MemberInfo member, bool inherited)
			where T : Attribute;
		public static bool RTIsDefined<T>(this MemberInfo member, bool inherited)
			where T : Attribute;
		public static T RTCreateDelegate<T>(this MethodInfo method, object instance);
		public static MemberInfo[] RTGetFieldsAndProps(this System.Type type); // 0x000000018AC76920-0x000000018AC76A00
		public static MemberInfo RTGetFieldOrProp(this System.Type type, string name); // 0x000000018AC7686C-0x000000018AC768FC
		public static object RTGetFieldOrPropValue(this MemberInfo member, object instance, int index = -1 /* Metadata: 0x0234BC54 */); // 0x000000018AC76710-0x000000018AC7686C
		public static void RTSetFieldOrPropValue(this MemberInfo member, object instance, object value, int index = -1 /* Metadata: 0x0234BC55 */); // 0x000000018AC76B84-0x000000018AC76CE8
		public static System.Type RTGetFieldOrPropType(this MemberInfo member); // 0x000000018AC7664C-0x000000018AC76710
	}

	public static class StringUtility // TypeDefIndex: 58348
	{
		// Methods
		public static string AbsToRelativePath(string absolutepath); // 0x000000018AC786CC-0x000000018AC787A8
	
		// Extension methods
		public static string SplitCamelCase(this string s); // 0x000000018AC787A8-0x000000018AC788AC
	}

	[Serializable]
	public struct TransformRefPosition : ITransformRefParameter // TypeDefIndex: 58349
	{
		// Fields
		[ActorGroupPopup]
		[SerializeField]
		private CutsceneGroup _group; // 0x00
		[FormerlySerializedAs("transform")]
		[SerializeField]
		private Transform _transform; // 0x08
		[FormerlySerializedAs("vector")]
		[SerializeField]
		private Vector3 _vector; // 0x10
		[SerializeField]
		private TransformSpace _space; // 0x1C
	
		// Properties
		public bool useAnimation { get; } // 0x000000018AC78D84-0x000000018AC78E30 
		public CutsceneGroup group { get; set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
		public Transform transform { get; set; } // 0x000000018AC78CCC-0x000000018AC78D84 0x00000001867D5E9C-0x00000001867D5EAC
		public Vector3 value { get; set; } // 0x000000018AC78E30-0x000000018AC78E9C 0x0000000184D8C970-0x0000000184D8C980
		public TransformSpace space { get; private set; } // 0x000000018AC78CA8-0x000000018AC78CCC 0x0000000184D86320-0x0000000184D86330
	
		// Methods
		public override string ToString(); // 0x000000018AC78C20-0x000000018AC78CA8
	}

	[Serializable]
	public struct TransformRefPositionRotation : ITransformRefParameter // TypeDefIndex: 58350
	{
		// Fields
		[ActorGroupPopup]
		[SerializeField]
		private CutsceneGroup _group; // 0x00
		[SerializeField]
		private Transform _transform; // 0x08
		[SerializeField]
		private Vector3 _position; // 0x10
		[SerializeField]
		private Vector3 _rotation; // 0x1C
		[SerializeField]
		private TransformSpace _space; // 0x28
	
		// Properties
		public bool useAnimation { get; } // 0x000000018AC78B74-0x000000018AC78C20 
		public CutsceneGroup group { get; set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
		public Transform transform { get; set; } // 0x000000018AC78ABC-0x000000018AC78B74 0x00000001867D5E9C-0x00000001867D5EAC
		public Vector3 position { get; set; } // 0x000000018AC789C0-0x000000018AC78A2C 0x0000000184D8C970-0x0000000184D8C980
		public Vector3 rotation { get; set; } // 0x000000018AC78A2C-0x000000018AC78A98 0x0000000184D90500-0x0000000184D90510
		public TransformSpace space { get; private set; } // 0x000000018AC78A98-0x000000018AC78ABC 0x00000001811F2AA0-0x00000001811F2AB0
	
		// Methods
		public override string ToString(); // 0x000000018AC78908-0x000000018AC789C0
	}

	public class TransformSnapshot // TypeDefIndex: 58353
	{
		// Fields
		private List<TransformData> data; // 0x10
	
		// Nested types
		public enum StoreMode // TypeDefIndex: 58351
		{
			All = 0,
			RootOnly = 1,
			ChildrenOnly = 2
		}
	
		private struct TransformData // TypeDefIndex: 58352
		{
			// Fields
			public Transform transform; // 0x00
			public Transform parent; // 0x08
			public Vector3 pos; // 0x10
			public Quaternion rot; // 0x1C
			public Vector3 scale; // 0x2C
	
			// Constructors
			public TransformData(Transform transform, Transform parent, Vector3 pos, Quaternion rot, Vector3 scale); // 0x000000018AC788AC-0x000000018AC78908
		}
	
		// Constructors
		public TransformSnapshot(GameObject root, StoreMode mode); // 0x000000018AC793B0-0x000000018AC79450
	
		// Methods
		public void Store(GameObject root, StoreMode mode); // 0x000000018AC7900C-0x000000018AC793B0
		public void Restore(); // 0x000000018AC78E9C-0x000000018AC7900C
	}

	public static class UnityObjectUtility // TypeDefIndex: 58355
	{
		// Fields
		private static MethodInfo _getLocalEulerAngles; // 0x00
		private static MethodInfo _setLocalEulerAngles; // 0x08
		private static PropertyInfo _rotationOrder; // 0x10
		private static object[] _rotationOrderArgGet; // 0x18
		private static object[] _rotationOrderArgSet; // 0x20
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 58354
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _FindInChildren_b__0(Transform t); // 0x000000018AC79994-0x000000018AC799F4
		}
	
		// Constructors
		static UnityObjectUtility(); // 0x000000018AC7AAAC-0x000000018AC7AC74
	
		// Extension methods
		public static Vector3 GetLocalEulerAngles(this Transform transform); // 0x000000018AC7A4D0-0x000000018AC7A5F0
		public static void SetLocalEulerAngles(this Transform transform, Vector3 value); // 0x000000018AC7A94C-0x000000018AC7AAAC
		public static string CalculateTransformPath(this Transform root, Transform child); // 0x000000018AC79F84-0x000000018AC7A138
		public static Transform ResolveTransformPath(this Transform root, string path); // 0x000000018AC7A76C-0x000000018AC7A890
		public static Transform FindInChildren(this Transform root, string name, bool includeHidden); // 0x000000018AC7A138-0x000000018AC7A274
		public static void ResetLocalCoords(this Transform transform, bool includeScale = true /* Metadata: 0x0234BC5B */); // 0x000000018AC7A6C8-0x000000018AC7A76C
		public static void SetLocalCoordsFrom(this Transform transform, Transform source); // 0x000000018AC7A890-0x000000018AC7A94C
		public static Transform InsertParentInChain(this Transform transform, string name); // 0x000000018AC7A5F0-0x000000018AC7A6C8
		public static T GetAddComponent<T>(this GameObject go)
			where T : Component;
		public static T GetAddComponent<T>(this Component comp)
			where T : Component;
		public static Component GetAddComponent(this GameObject go, System.Type type); // 0x000000018AC7A274-0x000000018AC7A304
		public static List<string> GetBlendShapeNames(this SkinnedMeshRenderer skinnedMesh); // 0x000000018AC7A3C8-0x000000018AC7A4D0
		public static int GetBlendShapeIndex(this SkinnedMeshRenderer skinnedMesh, string shapeName); // 0x000000018AC7A304-0x000000018AC7A3C8
	}

	public static class VideoSampler // TypeDefIndex: 58358
	{
		// Fields
		private const string ROOT_NAME = "_VideoSources"; // Metadata: 0x0234BC5C
		private static GameObject root; // 0x00
		private static Dictionary<object, VideoPlayer> sources; // 0x08
	
		// Nested types
		public enum VideoRenderTarget // TypeDefIndex: 58356
		{
			CameraBackground = 0,
			CameraForeground = 1
		}
	
		[Serializable]
		public struct SampleSettings // TypeDefIndex: 58357
		{
			// Fields
			public VideoRenderTarget renderTarget; // 0x00
			public float playbackSpeed; // 0x04
			public float alpha; // 0x08
			public VideoAspectRatio aspectRatio; // 0x0C
			public float audioVolume; // 0x10
	
			// Methods
			public static SampleSettings Default(); // 0x0000000184DA9CE0-0x0000000184DA9D10
		}
	
		// Constructors
		static VideoSampler(); // 0x000000018AC7B414-0x000000018AC7B4E4
	
		// Methods
		public static VideoPlayer GetSourceForID(object keyID); // 0x000000018AC7AC74-0x000000018AC7AFBC
		public static void ReleaseSourceForID(object keyID); // 0x000000018AC7AFBC-0x000000018AC7B170
		public static void SampleForID(object keyID, VideoClip clip, float time, float previousTime, SampleSettings settings); // 0x000000018AC7B170-0x000000018AC7B214
		public static void Sample(VideoPlayer source, VideoClip clip, float time, float previousTime, SampleSettings settings); // 0x000000018AC7B214-0x000000018AC7B414
	}

	public class CutsceneSequencePlayer : MonoBehaviour // TypeDefIndex: 58359
	{
		// Fields
		public bool playOnStart; // 0x18
		public List<Cutscene> cutscenes; // 0x20
		public UnityEvent onFinish; // 0x28
		private int currentIndex; // 0x30
		private bool isPlaying; // 0x34
	
		// Constructors
		public CutsceneSequencePlayer(); // 0x0000000185394740-0x000000018539475C
	
		// Methods
		private void Start(); // 0x000000018AC6E45C-0x000000018AC6E46C
		public void Play(); // 0x000000018AC6E388-0x000000018AC6E45C
		public void Stop(); // 0x000000018AC6E46C-0x000000018AC6E4D4
		private void MoveNext(); // 0x000000018AC6E224-0x000000018AC6E388
		public static GameObject Create(); // 0x000000018AC6E1A4-0x000000018AC6E224
		[CompilerGenerated]
		private void _MoveNext_b__8_0(); // 0x000000018AC6E4D4-0x000000018AC6E4DC
	}

	[ExecuteInEditMode]
	public class DirectorGUITemplate : MonoBehaviour // TypeDefIndex: 58360
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
		public DirectorGUITemplate(); // 0x0000000185394740-0x000000018539475C
	
		// Methods
		private void Awake(); // 0x000000018AC6F068-0x000000018AC6F188
		[ContextMenu("Show All")]
		private void ShowAll(); // 0x000000018AC6FBF8-0x000000018AC6FCA0
		[ContextMenu("Hide All")]
		private void HideAll(); // 0x000000018AC6F188-0x000000018AC6F218
		private void OnEnable(); // 0x000000018AC6F51C-0x000000018AC6F738
		private void OnDisable(); // 0x000000018AC6F300-0x000000018AC6F51C
		private void Update(); // 0x000000018AC6FCA0-0x000000018AC6FCF4
		private void OnCameraDissolve(Texture texture, float completion); // 0x000000018AC6F218-0x000000018AC6F300
		private void OnImageOverlayGUI(Texture texture, UnityEngine.Color color, Vector2 scale, Vector2 position); // 0x000000018AC6F738-0x000000018AC6F8A0
		private void OnLetterboxGUI(float completion); // 0x000000018AC6F8A0-0x000000018AC6FA30
		private void OnScreenFadeGUI(UnityEngine.Color color); // 0x000000018AC6FA30-0x000000018AC6FA88
		private void OnTextOverlayGUI(string text, UnityEngine.Color color, float size, TextAnchor anchor, Vector2 position); // 0x000000018AC6FB0C-0x000000018AC6FBF8
		private void OnSubtitlesGUI(string text, UnityEngine.Color color); // 0x000000018AC6FA88-0x000000018AC6FB0C
	}

	[AddComponentMenu("SLATE/Play Cutscene On Click")]
	public class PlayCutsceneOnClick : MonoBehaviour // TypeDefIndex: 58361
	{
		// Fields
		public Cutscene cutscene; // 0x18
		public float startTime; // 0x20
		public UnityEvent onFinish; // 0x28
	
		// Constructors
		public PlayCutsceneOnClick(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void OnMouseDown(); // 0x000000018AC742C4-0x000000018AC743D8
		private void Reset(); // 0x000000018AC743D8-0x000000018AC74478
		public static GameObject Create(); // 0x000000018AC74254-0x000000018AC742C4
		[CompilerGenerated]
		private void _OnMouseDown_b__3_0(); // 0x000000018AC74478-0x000000018AC74498
	}

	[AddComponentMenu("SLATE/Play Cutscene On Start")]
	public class PlayCutsceneOnStart : MonoBehaviour // TypeDefIndex: 58362
	{
		// Fields
		public Cutscene cutscene; // 0x18
		public float startTime; // 0x20
		public UnityEvent onFinish; // 0x28
	
		// Constructors
		public PlayCutsceneOnStart(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Start(); // 0x000000018AC74524-0x000000018AC74638
		public static GameObject Create(); // 0x000000018AC74498-0x000000018AC74524
		[CompilerGenerated]
		private void _Start_b__3_0(); // 0x000000018AC74478-0x000000018AC74498
	}

	[AddComponentMenu("SLATE/Play Cutscene On Trigger")]
	public class PlayCutsceneOnTrigger : MonoBehaviour // TypeDefIndex: 58363
	{
		// Fields
		public Cutscene cutscene; // 0x18
		public float startTime; // 0x20
		public bool checkSpecificTagOnly; // 0x24
		public string tagName; // 0x28
		public bool once; // 0x30
		public UnityEvent onFinish; // 0x38
	
		// Constructors
		public PlayCutsceneOnTrigger(); // 0x000000018AC7492C-0x000000018AC74978
	
		// Methods
		private void OnTriggerEnter(Collider other); // 0x000000018AC746C4-0x000000018AC7483C
		private void Reset(); // 0x000000018AC7483C-0x000000018AC748B4
		public static GameObject Create(); // 0x000000018AC74638-0x000000018AC746C4
		[CompilerGenerated]
		private void _OnTriggerEnter_b__6_0(); // 0x000000018AC748B4-0x000000018AC7492C
	}

	[AddComponentMenu("SLATE/Stop Cutscene On Click")]
	public class StopCutsceneOnClick : MonoBehaviour // TypeDefIndex: 58364
	{
		// Fields
		public Cutscene cutscene; // 0x18
		public Cutscene.StopMode stopMode; // 0x20
	
		// Constructors
		public StopCutsceneOnClick(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void OnMouseDown(); // 0x000000018AC783E0-0x000000018AC78494
		private void Reset(); // 0x000000018AC78494-0x000000018AC784F4
	}

	[AddComponentMenu("SLATE/Stop Cutscene On Trigger")]
	public class StopCutsceneOnTrigger : MonoBehaviour // TypeDefIndex: 58365
	{
		// Fields
		public Cutscene cutscene; // 0x18
		public bool checkSpecificTagOnly; // 0x20
		public string tagName; // 0x28
		public Cutscene.StopMode stopMode; // 0x30
	
		// Constructors
		public StopCutsceneOnTrigger(); // 0x000000018AC78680-0x000000018AC786CC
	
		// Methods
		private void OnTriggerEnter(Collider other); // 0x000000018AC784F4-0x000000018AC78608
		private void Reset(); // 0x000000018AC78608-0x000000018AC78680
	}
}

namespace Slate.ActionClips
{
	[Attachable(new System.Type[1] {typeof(ActorActionTrack) })]
	public abstract class ActorActionClip : ActionClip // TypeDefIndex: 58366
	{
		// Constructors
		protected ActorActionClip(); // 0x0000000185393520-0x0000000185393538
	}

	[Attachable(new System.Type[1] {typeof(ActorActionTrack) })]
	public abstract class ActorActionClip<T> : ActionClip // TypeDefIndex: 58367
		where T : Component
	{
		// Fields
		[NonSerialized]
		private T _actorComponent;
	
		// Properties
		public new T actor { get; }
		public override bool isValid { get; }
	
		// Constructors
		protected ActorActionClip();
	}

	[Attachable(new System.Type[2] {typeof(ActorActionTrack), typeof(DirectorActionTrack) })]
	[Description("Animate any number of properties on any component of the actor, or within it\'s hierarchy.\nThis is identical to using a Properties Track, but instead the animated properties are stored within the clip and thus can be moved around as a group easier.\nYou can also use the Clip\'s Blend In/Out to optionally smooth blend from current property values over to the keyframed ones and back.")]
	public class AnimateProperties : ActionClip // TypeDefIndex: 58368
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
		[SerializeField]
		protected string _name; // 0x50
		public Slate.EaseType interpolation; // 0x58
	
		// Properties
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override bool isValid { get; } // 0x000000018AC509C8-0x000000018AC509E0 
		public override string info { get; } // 0x000000018AC68FD8-0x000000018AC69048 
		public override object animatedParametersTarget { get; } // 0x000000018AC68FD0-0x000000018AC68FD8 
		public override Slate.EaseType animatedParametersInterpolation { get; } // 0x0000000184D86570-0x0000000184D86580 
		public override bool useWeightInParameters { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	
		// Constructors
		public AnimateProperties(); // 0x000000018AC68FAC-0x000000018AC68FD0
	}

	[Category("Character")]
	[Description("Animates a single blend shape chosen from within the whole actor gameobject hierarchy.")]
	public class AnimateBlendShape : ActorActionClip // TypeDefIndex: 58369
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
		[HideInInspector]
		[SerializeField]
		private string _skinName; // 0x50
		[HideInInspector]
		[SerializeField]
		private string _shapeName; // 0x58
		[AnimatableParameter(-1f, 2f)]
		public float weight; // 0x60
		private float originalWeight; // 0x64
		private int index; // 0x68
		private SkinnedMeshRenderer _skinnedMesh; // 0x70
	
		// Properties
		public override string info { get; } // 0x000000018AC68148-0x000000018AC68188 
		public override bool isValid { get; } // 0x000000018AC68188-0x000000018AC68230 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override bool canCrossBlend { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public string skinName { get; set; } // 0x0000000184D86270-0x0000000184D86280 0x000000018AC68388-0x000000018AC683B4
		public string shapeName { get; set; } // 0x0000000182E56440-0x0000000182E56460 0x00000001836E5590-0x00000001836E55A0
		private SkinnedMeshRenderer skinnedMesh { get; } // 0x000000018AC68230-0x000000018AC68388 
	
		// Constructors
		public AnimateBlendShape(); // 0x000000018AC68114-0x000000018AC68148
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC67F34-0x000000018AC68018
		protected override void OnUpdate(float deltaTime); // 0x000000018AC68054-0x000000018AC680DC
		protected override void OnReverse(); // 0x000000018AC68018-0x000000018AC68054
		[CompilerGenerated]
		private bool _get_skinnedMesh_b__31_0(SkinnedMeshRenderer s); // 0x000000018AC680DC-0x000000018AC68114
	}

	[Category("Character")]
	[Description("Sets a collection of BlendShapes (an expression), which you can create in the Character Component Inspector of the actor.")]
	public class CharacterExpression : ActorActionClip<Slate.Character> // TypeDefIndex: 58370
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x4C
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x50
		[HideInInspector]
		public string expressionName; // 0x58
		[HideInInspector]
		public string expressionUID; // 0x60
		[AnimatableParameter(0f, 1f)]
		public float weight; // 0x68
		private float originalWeight; // 0x6C
		private BlendShapeGroup expression; // 0x70
	
		// Properties
		public override string info { get; } // 0x000000018AC6B0A4-0x000000018AC6B158 
		public override bool isValid { get; } // 0x000000018AC6B158-0x000000018AC6B1BC 
		public override float length { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override float blendIn { get; set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000184D91480-0x0000000184D91490
		public override float blendOut { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
		public override bool canCrossBlend { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	
		// Constructors
		public CharacterExpression(); // 0x000000018AC6B040-0x000000018AC6B0A4
	
		// Methods
		private BlendShapeGroup ResolveExpression(); // 0x000000018AC6AFB4-0x000000018AC6B040
		protected override void OnEnter(); // 0x000000018AC6AECC-0x000000018AC6AF00
		protected override void OnUpdate(float deltaTime); // 0x000000018AC6AF44-0x000000018AC6AFB4
		protected override void OnReverse(); // 0x000000018AC6AF00-0x000000018AC6AF44
	}

	[Category("Character")]
	[Description("This ActionClip is recommended to be used above an animation track.")]
	[Name("Character Head Look At")]
	public class CharacterLookAt : ActorActionClip<Slate.Character> // TypeDefIndex: 58371
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x4C
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x50
		public Slate.EaseType interpolation; // 0x54
		[AnimatableParameter(0f, 1f)]
		public float weight; // 0x58
		public TransformRefPosition targetPosition; // 0x60
		private Quaternion wasNeckRot; // 0x80
		private Quaternion wasHeadRot; // 0x90
	
		// Properties
		[AnimatableParameter(link = "targetPosition")]
		[PositionHandle]
		[ShowTrajectory]
		public Vector3 targetPositionVector { get; set; } // 0x000000018AC6B9F0-0x000000018AC6BA24 0x0000000184DA9C90-0x0000000184DA9CA0
		public override string info { get; } // 0x000000018AC6B898-0x000000018AC6B910 
		public override bool isValid { get; } // 0x000000018AC6B910-0x000000018AC6B9F0 
		public override float length { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override float blendIn { get; set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000184D91480-0x0000000184D91490
		public override float blendOut { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
	
		// Constructors
		public CharacterLookAt(); // 0x000000018AC6B840-0x000000018AC6B898
	
		// Methods
		protected override void OnCreate(); // 0x000000018AC6B208-0x000000018AC6B2D0
		protected override void OnAfterValidate(); // 0x000000018AC6B1BC-0x000000018AC6B208
		protected override void OnEnter(); // 0x000000018AC6B2D0-0x000000018AC6B370
		protected override void OnUpdate(float time); // 0x000000018AC6B410-0x000000018AC6B840
		protected override void OnReverse(); // 0x000000018AC6B370-0x000000018AC6B410
	}

	public abstract class SendMessage<T> : SendMessage // TypeDefIndex: 58372
	{
		// Fields
		[Tooltip("The parameter value to use when calling the method")]
		public T value;
	
		// Properties
		public override string info { get; }
		public override bool isValid { get; }
		public override System.Type parameterType { get; }
	
		// Constructors
		protected SendMessage();
	
		// Methods
		protected override void OnEnter();
	}

	[Category("Events")]
	[Description("Send a Unity Message to the actor")]
	public class SendMessage : ActorActionClip // TypeDefIndex: 58373
	{
		// Fields
		[Required]
		[Tooltip("The method name to call")]
		public string message; // 0x40
		[Tooltip("If multiple components of the same type exist on gameobject you can specify the index of the component to use here. Leave at -1 to call all found instances")]
		public int componentIndex; // 0x48
	
		// Properties
		public override string info { get; } // 0x000000018AC774A8-0x000000018AC774E8 
		public override bool isValid { get; } // 0x00000001891DE054-0x00000001891DE06C 
		public virtual System.Type parameterType { get; } // 0x00000001811EC580-0x00000001811EC590 
	
		// Constructors
		public SendMessage(); // 0x000000018AC7748C-0x000000018AC774A8
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC771D8-0x000000018AC7748C
	}

	public class SendMessageBoolean : SendMessage<bool> // TypeDefIndex: 58374
	{
		// Constructors
		public SendMessageBoolean(); // 0x000000018AC770D4-0x000000018AC77108
	}

	public class SendMessageFloat : SendMessage<float> // TypeDefIndex: 58375
	{
		// Constructors
		public SendMessageFloat(); // 0x000000018AC77108-0x000000018AC7713C
	}

	public class SendMessageInteger : SendMessage<int> // TypeDefIndex: 58376
	{
		// Constructors
		public SendMessageInteger(); // 0x000000018AC7713C-0x000000018AC77170
	}

	public class SendMessageObject : SendMessage<UnityEngine.Object> // TypeDefIndex: 58377
	{
		// Constructors
		public SendMessageObject(); // 0x000000018AC77170-0x000000018AC771A4
	}

	public class SendMessageString : SendMessage<string> // TypeDefIndex: 58378
	{
		// Constructors
		public SendMessageString(); // 0x000000018AC771A4-0x000000018AC771D8
	}

	[Category("GameObject")]
	[Description("Set or animate the actor gameobject visibility.")]
	public class AnimateActorVisibility : ActorActionClip // TypeDefIndex: 58379
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[AnimatableParameter]
		public bool visible; // 0x44
		private bool wasVisible; // 0x45
	
		// Properties
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
	
		// Constructors
		public AnimateActorVisibility(); // 0x000000018AC67F18-0x000000018AC67F34
	
		// Methods
		protected override void OnCreate(); // 0x000000018AC67E58-0x000000018AC67E88
		protected override void OnEnter(); // 0x000000018AC67E88-0x000000018AC67EB8
		protected override void OnUpdate(float time); // 0x000000018AC67EE8-0x000000018AC67F18
		protected override void OnReverse(); // 0x000000018AC67EB8-0x000000018AC67EE8
	}

	[Category("GameObject")]
	[Description("Make the actor target for the currently active Dynamic Shot Controller (if used by the current active Camera Shot in the cutscene).")]
	public class MakeCameraTarget : ActorActionClip // TypeDefIndex: 58380
	{
		// Fields
		public bool setTransposerTarget; // 0x40
		public bool setComposerTarget; // 0x41
		private Transform wasTransposerTarget; // 0x48
		private Transform wasComposerTarget; // 0x50
	
		// Constructors
		public MakeCameraTarget(); // 0x000000018AC72340-0x000000018AC7235C
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC72094-0x000000018AC72220
		protected override void OnReverse(); // 0x000000018AC72220-0x000000018AC72340
	}

	[Category("GameObject")]
	[Description("Set the actor active state (visibility) for a period of time or permantentely if length is zero.")]
	public class SetActorActiveState : ActorActionClip // TypeDefIndex: 58381
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		public ActiveState activeState; // 0x44
		private bool lastState; // 0x48
		private bool currentState; // 0x49
		private bool temporary; // 0x4A
	
		// Properties
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override string info { get; } // 0x000000018AC77674-0x000000018AC776D4 
	
		// Constructors
		public SetActorActiveState(); // 0x000000018AC77658-0x000000018AC77674
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC774E8-0x000000018AC775B0
		protected override void OnExit(); // 0x000000018AC775B0-0x000000018AC775EC
		protected override void OnReverseEnter(); // 0x000000018AC775EC-0x000000018AC77628
		protected override void OnReverse(); // 0x000000018AC77628-0x000000018AC77658
	}

	[Category("GameObject")]
	[Obsolete("Use \'Set Actor Visibility\'")]
	public class SetActorVisibilityTemporary : ActorActionClip // TypeDefIndex: 58382
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		public ActiveState activeState; // 0x44
		private bool lastState; // 0x48
		private bool currentState; // 0x49
		private bool temporary; // 0x4A
	
		// Properties
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override string info { get; } // 0x000000018AC776F8-0x000000018AC77758 
	
		// Constructors
		public SetActorVisibilityTemporary(); // 0x000000018AC776D4-0x000000018AC776F8
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC774E8-0x000000018AC775B0
		protected override void OnExit(); // 0x000000018AC775B0-0x000000018AC775EC
		protected override void OnReverseEnter(); // 0x000000018AC775EC-0x000000018AC77628
		protected override void OnReverse(); // 0x000000018AC77628-0x000000018AC77658
	}

	[Category("GameObject")]
	[Description("The selected Behaviours will be Enabled or Disable (based on state option) on the actor if they are not already")]
	public class SetBehavioursActiveState : ActorActionClip // TypeDefIndex: 58383
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		public List<string> behaviourNames; // 0x48
		public ActiveState activeState; // 0x50
		private Dictionary<UnityEngine.Behaviour, bool> originalStates; // 0x58
		private Dictionary<UnityEngine.Behaviour, bool> currentStates; // 0x60
		private bool temporary; // 0x68
	
		// Properties
		public override string info { get; } // 0x000000018AC78064-0x000000018AC78120 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
	
		// Constructors
		public SetBehavioursActiveState(); // 0x000000018AC77FDC-0x000000018AC78064
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC77758-0x000000018AC77A78
		protected override void OnExit(); // 0x000000018AC77A78-0x000000018AC77C2C
		protected override void OnReverseEnter(); // 0x000000018AC77C2C-0x000000018AC77DDC
		protected override void OnReverse(); // 0x000000018AC77DDC-0x000000018AC77F64
		[CompilerGenerated]
		private bool _OnEnter_b__11_0(UnityEngine.Behaviour c); // 0x000000018AC77F64-0x000000018AC77FDC
	}

	[Category("Paths")]
	[Description("Animate the actor\'s position and look at target position on a Path. For example, a \'PositionOnPath\' value of 0 means start of path, while a value of 1 means end of path.")]
	public class AnimateOnPath : ActorActionClip // TypeDefIndex: 58384
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[Required]
		public Path path; // 0x48
		[AnimatableParameter(0f, 1f)]
		public float positionOnPath; // 0x50
		[AnimatableParameter]
		[PositionHandle]
		[ShowTrajectory]
		public Vector3 lookAtTargetPosition; // 0x54
		public Slate.EaseType blendInterpolation; // 0x60
		private Vector3 wasPosition; // 0x64
		private Quaternion wasRotation; // 0x70
	
		// Properties
		public override string info { get; } // 0x000000018AC68EBC-0x000000018AC68F5C 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override bool isValid { get; } // 0x000000018AC68F5C-0x000000018AC68FAC 
	
		// Constructors
		public AnimateOnPath(); // 0x000000018AC68E98-0x000000018AC68EBC
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC68A70-0x000000018AC68B10
		protected override void OnUpdate(float time); // 0x000000018AC68B9C-0x000000018AC68E98
		protected override void OnReverse(); // 0x000000018AC68B10-0x000000018AC68B9C
	}

	[Category("Paths")]
	[Description("Put the actor on a path to follow for the duration of the clip from path start to path end, or by using speed if \'Use Speed\' is true. If you want the actor to look ahead of the path, set \'Look Ahead\' to any value other than 0.")]
	public class FollowPath : ActorActionClip // TypeDefIndex: 58385
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
		[Required]
		public Path path; // 0x50
		public bool useSpeed; // 0x58
		[ShowIf("useSpeed", 1)]
		public float speed; // 0x5C
		[Range(0f, 1f)]
		public float lookAhead; // 0x60
		public Vector3 upVector; // 0x64
		public Slate.EaseType blendInterpolation; // 0x70
		private Vector3 lastPos; // 0x74
		private Quaternion lastRot; // 0x80
	
		// Properties
		public override string info { get; } // 0x000000018AC70D78-0x000000018AC70E18 
		public override float length { get; set; } // 0x000000018AC70E68-0x000000018AC70EF4 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override bool isValid { get; } // 0x000000018AC70E18-0x000000018AC70E68 
	
		// Constructors
		public FollowPath(); // 0x000000018AC70D30-0x000000018AC70D78
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC708B0-0x000000018AC70954
		protected override void OnUpdate(float time); // 0x000000018AC709E4-0x000000018AC70D30
		protected override void OnReverse(); // 0x000000018AC70954-0x000000018AC709E4
	}

	[Category("Paths")]
	[Description("For this clip to work you only need to have a baked NavMesh. The actor does NOT need, or use a NavMeshAgent Component. The length of the clip is determined by the path\'s length and the speed parameter set, while the Blend In parameter is used only for the initial look ahead blending")]
	public class PathfindFromTo : ActorActionClip // TypeDefIndex: 58386
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x40
		[Slate.Min(0.01f)]
		public float speed; // 0x44
		public TransformRefPosition sourcePosition; // 0x48
		public TransformRefPosition targetPosition; // 0x68
		private Vector3[] pathPoints; // 0x88
		private Vector3 wasPosition; // 0x90
		private Quaternion wasRotation; // 0x9C
		private Vector3 lastFrom; // 0xAC
		private Vector3 lastTo; // 0xB8
	
		// Properties
		public override string info { get; } // 0x000000018AC73828-0x000000018AC73870 
		public override float length { get; } // 0x000000018AC73870-0x000000018AC738B4 
		public override float blendIn { get; set; } // 0x000000018AC737F8-0x000000018AC73828 0x0000000184D86470-0x0000000184D86480
	
		// Constructors
		public PathfindFromTo(); // 0x000000018AC737D4-0x000000018AC737F8
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC72EDC-0x000000018AC73090
		protected override void OnUpdate(float time); // 0x000000018AC7313C-0x000000018AC73578
		protected override void OnReverse(); // 0x000000018AC73090-0x000000018AC7313C
		private void TryCalculatePath(); // 0x000000018AC73578-0x000000018AC737D4
	}

	[Category("Paths")]
	[Description("For this clip to work you only need to have a baked NavMesh. The actor does NOT need, or use a NavMeshAgent Component. The length of the clip is determined by the path\'s length and the speed parameter set, while the Blend In parameter is used only for the initial look ahead blending")]
	public class PathfindTo : ActorActionClip // TypeDefIndex: 58387
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x40
		[Slate.Min(0.01f)]
		public float speed; // 0x44
		public TransformRefPosition targetPosition; // 0x48
		private Vector3[] pathPoints; // 0x68
		private Vector3 wasPosition; // 0x70
		private Quaternion wasRotation; // 0x7C
		private Vector3 lastFrom; // 0x8C
		private Vector3 lastTo; // 0x98
	
		// Properties
		public override string info { get; } // 0x000000018AC741CC-0x000000018AC74214 
		public override float length { get; } // 0x000000018AC74214-0x000000018AC74254 
		public override float blendIn { get; set; } // 0x000000018AC737F8-0x000000018AC73828 0x0000000184D86470-0x0000000184D86480
	
		// Constructors
		public PathfindTo(); // 0x000000018AC737D4-0x000000018AC737F8
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC738B4-0x000000018AC73A54
		protected override void OnUpdate(float time); // 0x000000018AC73AEC-0x000000018AC73F10
		protected override void OnReverse(); // 0x000000018AC73A54-0x000000018AC73AEC
		private void TryCalculatePath(); // 0x000000018AC73F10-0x000000018AC741CC
	}

	[Category("Renderer")]
	public class AnimateMaterialColor : ActorActionClip<Renderer> // TypeDefIndex: 58388
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x4C
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x50
		[ShaderPropertyPopup(typeof(UnityEngine.Color))]
		public string propertyName; // 0x58
		[AnimatableParameter]
		public UnityEngine.Color color; // 0x60
		public Slate.EaseType interpolation; // 0x70
		private UnityEngine.Color originalColor; // 0x74
	
		// Properties
		public override string info { get; } // 0x000000018AC68568-0x000000018AC685A8 
		public override bool isValid { get; } // 0x000000018AC685A8-0x000000018AC68694 
		public override float length { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override float blendIn { get; set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000184D91480-0x0000000184D91490
		public override float blendOut { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
		private Material targetMaterial { get; } // 0x000000018AC68694-0x000000018AC6873C 
	
		// Constructors
		public AnimateMaterialColor(); // 0x000000018AC684EC-0x000000018AC68568
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC68430-0x000000018AC68438
		protected override void OnReverseEnter(); // 0x000000018AC68430-0x000000018AC68438
		protected override void OnUpdate(float time); // 0x000000018AC68440-0x000000018AC684EC
		protected override void OnReverse(); // 0x000000018AC68438-0x000000018AC68440
		protected override void OnExit(); // 0x000000018AC68438-0x000000018AC68440
		private void DoSet(); // 0x000000018AC683F4-0x000000018AC68430
		private void DoReset(); // 0x000000018AC683B4-0x000000018AC683F4
	}

	[Category("Renderer")]
	public class AnimateMaterialFloat : ActorActionClip<Renderer> // TypeDefIndex: 58389
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x4C
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x50
		[ShaderPropertyPopup(typeof(float))]
		public string propertyName; // 0x58
		[AnimatableParameter]
		public float value; // 0x60
		public Slate.EaseType interpolation; // 0x64
		private float originalValue; // 0x68
	
		// Properties
		public override string info { get; } // 0x000000018AC6889C-0x000000018AC688DC 
		public override bool isValid { get; } // 0x000000018AC688DC-0x000000018AC689C8 
		public override float length { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override float blendIn { get; set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000184D91480-0x0000000184D91490
		public override float blendOut { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
		private Material targetMaterial { get; } // 0x000000018AC689C8-0x000000018AC68A70 
	
		// Constructors
		public AnimateMaterialFloat(); // 0x000000018AC68838-0x000000018AC6889C
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC687A8-0x000000018AC687B0
		protected override void OnReverseEnter(); // 0x000000018AC687A8-0x000000018AC687B0
		protected override void OnUpdate(float time); // 0x000000018AC687B8-0x000000018AC68838
		protected override void OnReverse(); // 0x000000018AC687B0-0x000000018AC687B8
		protected override void OnExit(); // 0x000000018AC687B0-0x000000018AC687B8
		private void DoSet(); // 0x000000018AC68770-0x000000018AC687A8
		private void DoReset(); // 0x000000018AC6873C-0x000000018AC68770
	}

	[Category("Renderer")]
	[Description("Animate a material\'s texture offset and scale over time")]
	public class AnimateMaterialTexture : ActorActionClip<Renderer> // TypeDefIndex: 58390
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x4C
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x50
		[ShaderPropertyPopup(typeof(Texture))]
		public string propertyName; // 0x58
		[AnimatableParameter]
		public Vector2 offset; // 0x60
		[AnimatableParameter]
		public Vector2 scale; // 0x68
		public Slate.EaseType interpolation; // 0x70
		private Vector2 originalOffset; // 0x74
		private Vector2 originalScale; // 0x7C
	
		// Properties
		public override string info { get; } // 0x000000018AC7DD38-0x000000018AC7DD78 
		public override bool isValid { get; } // 0x000000018AC7DD78-0x000000018AC7DE64 
		public override float length { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override float blendIn { get; set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000184D91480-0x0000000184D91490
		public override float blendOut { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
		private Material targetMaterial { get; } // 0x000000018AC7DE64-0x000000018AC7DF0C 
	
		// Constructors
		public AnimateMaterialTexture(); // 0x000000018AC7DCC4-0x000000018AC7DD38
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC7DAF8-0x000000018AC7DB00
		protected override void OnReverseEnter(); // 0x000000018AC7DAF8-0x000000018AC7DB00
		protected override void OnUpdate(float time); // 0x000000018AC7DB08-0x000000018AC7DCC4
		protected override void OnReverse(); // 0x000000018AC7DB00-0x000000018AC7DB08
		protected override void OnExit(); // 0x000000018AC7DB00-0x000000018AC7DB08
		private void DoSet(); // 0x000000018AC7DA70-0x000000018AC7DAF8
		private void DoReset(); // 0x000000018AC7D9FC-0x000000018AC7DA70
	}

	[Category("Renderer")]
	[Description("Scroll/Offset the material texture. Usefull for scrolling backgrounds, screens, or other similar effects.")]
	public class ScrollMaterialTexture : ActorActionClip<Renderer> // TypeDefIndex: 58391
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		[ShaderPropertyPopup(typeof(Texture))]
		public string propertyName; // 0x50
		public Vector2 speed; // 0x58
		public Slate.EaseType interpolation; // 0x60
		private Vector2 originalOffset; // 0x64
	
		// Properties
		public override string info { get; } // 0x000000018AC84B3C-0x000000018AC84BA0 
		public override bool isValid { get; } // 0x000000018AC84BA0-0x000000018AC84C4C 
		public override float length { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override float blendIn { get; } // 0x000000018AC7EA6C-0x000000018AC7EA7C 
		private Material targetMaterial { get; } // 0x000000018AC84C4C-0x000000018AC84CF4 
	
		// Constructors
		public ScrollMaterialTexture(); // 0x000000018AC84AD4-0x000000018AC84B3C
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC848C8-0x000000018AC84914
		protected override void OnUpdate(float time); // 0x000000018AC84958-0x000000018AC84AD4
		protected override void OnReverse(); // 0x000000018AC84914-0x000000018AC84958
	}

	[Category("Renderer")]
	public class SetMaterial : ActorActionClip<Renderer> // TypeDefIndex: 58392
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		public Material material; // 0x50
		private Material sharedMat; // 0x58
		private bool temporary; // 0x60
	
		// Properties
		public override string info { get; } // 0x000000018AC853A8-0x000000018AC85448 
		public override float length { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
	
		// Constructors
		public SetMaterial(); // 0x000000018AC85368-0x000000018AC853A8
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC8530C-0x000000018AC85340
		protected override void OnReverseEnter(); // 0x000000018AC85350-0x000000018AC85360
		protected override void OnReverse(); // 0x000000018AC85360-0x000000018AC85368
		protected override void OnExit(); // 0x000000018AC85340-0x000000018AC85350
		private void DoSet(); // 0x000000018AC8528C-0x000000018AC8530C
		private void DoReset(); // 0x000000018AC85238-0x000000018AC8528C
	}

	[Category("Renderer")]
	public class SetMaterialTexture : ActorActionClip<Renderer> // TypeDefIndex: 58393
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		[ShaderPropertyPopup(typeof(Texture))]
		public string propertyName; // 0x50
		public Texture texture; // 0x58
		private Texture originalTexture; // 0x60
		private bool temporary; // 0x68
	
		// Properties
		public override string info { get; } // 0x000000018AC85004-0x000000018AC850A4 
		public override bool isValid { get; } // 0x000000018AC850A4-0x000000018AC85190 
		public override float length { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		private Material targetMaterial { get; } // 0x000000018AC85190-0x000000018AC85238 
	
		// Constructors
		public SetMaterialTexture(); // 0x000000018AC84FB4-0x000000018AC85004
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC84F58-0x000000018AC84F8C
		protected override void OnReverseEnter(); // 0x000000018AC84F9C-0x000000018AC84FAC
		protected override void OnReverse(); // 0x000000018AC84FAC-0x000000018AC84FB4
		protected override void OnExit(); // 0x000000018AC84F8C-0x000000018AC84F9C
		private void DoSet(); // 0x000000018AC84EF8-0x000000018AC84F58
		private void DoReset(); // 0x000000018AC84EC4-0x000000018AC84EF8
	}

	[Category("Sprites")]
	[Description("Change sorting layer and order for sprite renderer.")]
	public class SetSortingLayer : ActorActionClip<SpriteRenderer> // TypeDefIndex: 58394
	{
		// Fields
		public int sortingOrder; // 0x48
		[SortingLayer]
		public int sortingLayerID; // 0x4C
		private string _lastLayer; // 0x50
		private int _lastOrder; // 0x58
	
		// Properties
		public override string info { get; } // 0x000000018AC85A34-0x000000018AC85AEC 
	
		// Constructors
		public SetSortingLayer(); // 0x000000018AC859F4-0x000000018AC85A34
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC858B8-0x000000018AC8597C
		protected override void OnReverse(); // 0x000000018AC8597C-0x000000018AC859F4
	}

	[Category("Sprites")]
	public class SetSprite : ActorActionClip<SpriteRenderer> // TypeDefIndex: 58395
	{
		// Fields
		[Header("Basic")]
		public Sprite sprite; // 0x48
		public UnityEngine.Color color; // 0x50
		public bool flipX; // 0x60
		public bool flipY; // 0x61
		[Header("Sorting")]
		public bool changeSorting; // 0x62
		[SortingLayer]
		public int sortingLayerID; // 0x64
		public int sortingOrder; // 0x68
		private Sprite lastSprite; // 0x70
		private UnityEngine.Color lastColor; // 0x78
		private bool lastFlipX; // 0x88
		private bool lastFlipY; // 0x89
		private int lastSortingLayerID; // 0x8C
		private int lastSortingOrder; // 0x90
	
		// Properties
		public override string info { get; } // 0x000000018AC85E8C-0x000000018AC85F0C 
	
		// Constructors
		public SetSprite(); // 0x000000018AC85E34-0x000000018AC85E8C
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC85AEC-0x000000018AC85D10
		protected override void OnReverse(); // 0x000000018AC85D10-0x000000018AC85E34
	}

	[Category("Sprites")]
	[Description("Animate a sprite object by altering between different sprites in order")]
	public class SpriteFlipbook : ActorActionClip<SpriteRenderer> // TypeDefIndex: 58396
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		[Slate.Min(1f)]
		public int loops; // 0x4C
		public List<Sprite> sprites; // 0x50
		public bool endWithPrevious; // 0x58
		private Sprite lastSprite; // 0x60
	
		// Properties
		public override string info { get; } // 0x000000018AC86AD8-0x000000018AC86B98 
		public override float length { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override bool isValid { get; } // 0x000000018AC86B98-0x000000018AC86C2C 
	
		// Constructors
		public SpriteFlipbook(); // 0x000000018AC86A40-0x000000018AC86AD8
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC867D8-0x000000018AC86834
		protected override void OnUpdate(float deltaTime); // 0x000000018AC868E4-0x000000018AC86A40
		protected override void OnExit(); // 0x000000018AC86834-0x000000018AC86890
		protected override void OnReverse(); // 0x000000018AC86890-0x000000018AC868E4
	}

	[Category("Transform")]
	[Description("Attach an object to a child transform of the actor (or the actor itself) either permantentely or temporary if length is greater than zero.")]
	public class AttachObject : ActorActionClip // TypeDefIndex: 58397
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[Required]
		public Transform targetObject; // 0x48
		public string childTransformName; // 0x50
		public Vector3 localPosition; // 0x58
		public Vector3 localRotation; // 0x64
		public Vector3 localScale; // 0x70
		private TransformSnapshot snapshot; // 0x80
		private bool temporary; // 0x88
	
		// Properties
		public override bool isValid { get; } // 0x000000018AC7E81C-0x000000018AC7E86C 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
	
		// Constructors
		public AttachObject(); // 0x000000018AC7E4E4-0x000000018AC7E518
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC7E794-0x000000018AC7E7C8
		protected override void OnReverseEnter(); // 0x000000018AC7E7DC-0x000000018AC7E7F0
		protected override void OnExit(); // 0x000000018AC7E7C8-0x000000018AC7E7DC
		protected override void OnReverse(); // 0x000000018AC7E7F0-0x000000018AC7E7F8
		private void Do(); // 0x000000018AC7E568-0x000000018AC7E794
		private void UnDo(); // 0x000000018AC7E7F8-0x000000018AC7E81C
	}

	[Category("Transform")]
	[Description("Instantiate and attach a prefab object to a child transform of the actor (or the actor itself) either permantentely or temporary if length is greater than zero.")]
	public class AttachObjectPrefab : ActorActionClip // TypeDefIndex: 58398
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[Required]
		public Transform targetPrefab; // 0x48
		public string childTransformName; // 0x50
		public Vector3 localPosition; // 0x58
		public Vector3 localRotation; // 0x64
		public Vector3 localScale; // 0x70
		private Transform instance; // 0x80
		private TransformSnapshot snapshot; // 0x88
		private bool temporary; // 0x90
	
		// Properties
		public override bool isValid { get; } // 0x000000018AC7E518-0x000000018AC7E568 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
	
		// Constructors
		public AttachObjectPrefab(); // 0x000000018AC7E4E4-0x000000018AC7E518
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC7E3E0-0x000000018AC7E414
		protected override void OnReverseEnter(); // 0x000000018AC7E428-0x000000018AC7E43C
		protected override void OnExit(); // 0x000000018AC7E414-0x000000018AC7E428
		protected override void OnReverse(); // 0x000000018AC7E43C-0x000000018AC7E444
		private void Do(); // 0x000000018AC7E1D4-0x000000018AC7E3E0
		private void UnDo(); // 0x000000018AC7E444-0x000000018AC7E4E4
	}

	[Category("Transform")]
	[Description("Rotate actor transform to look at specified target position for a period of time or permanentely if blend out is zero")]
	public class LookAt : ActorActionClip // TypeDefIndex: 58399
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
		public bool verticalOnly; // 0x4C
		public Slate.EaseType interpolation; // 0x50
		public TransformRefPosition targetPosition; // 0x58
		private Quaternion wasRotation; // 0x78
	
		// Properties
		[AnimatableParameter(link = "targetPosition")]
		[PositionHandle]
		[ShowTrajectory]
		public Vector3 targetPositionVector { get; set; } // 0x000000018AC801D0-0x000000018AC80204 0x0000000184D91E40-0x0000000184D91E50
		public override string info { get; } // 0x000000018AC80158-0x000000018AC801D0 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
	
		// Constructors
		public LookAt(); // 0x000000018AC80124-0x000000018AC80158
	
		// Methods
		protected override void OnCreate(); // 0x000000018AC7FE38-0x000000018AC7FE74
		protected override void OnAfterValidate(); // 0x000000018AC7FDEC-0x000000018AC7FE38
		protected override void OnEnter(); // 0x000000018AC7FE74-0x000000018AC7FEC0
		protected override void OnUpdate(float deltaTime); // 0x000000018AC7FF0C-0x000000018AC80124
		protected override void OnReverse(); // 0x000000018AC7FEC0-0x000000018AC7FF0C
	}

	[Category("Transform")]
	[Description("Smoothly match the selected transforms of the actor and to the target for a period of time and then back again to their original values. If you don\'t want to smooth back to the original values, set BlendOut to 0.")]
	public class MatchTransformsToTarget : ActorActionClip // TypeDefIndex: 58400
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
		[Required]
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
		public override string info { get; } // 0x000000018AC80908-0x000000018AC809A8 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override bool isValid { get; } // 0x000000018AC809A8-0x000000018AC809F8 
	
		// Constructors
		public MatchTransformsToTarget(); // 0x000000018AC808CC-0x000000018AC80908
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC80204-0x000000018AC802E0
		protected override void OnUpdate(float deltaTime); // 0x000000018AC803C4-0x000000018AC808CC
		protected override void OnReverse(); // 0x000000018AC802E0-0x000000018AC803C4
	}

	[Category("Transform")]
	public class Noise : ActorActionClip // TypeDefIndex: 58401
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
		public Vector3 seed; // 0x4C
		public Vector3 amplitude; // 0x58
		public float frequency; // 0x64
		private Vector3 wasPosition; // 0x68
	
		// Properties
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
	
		// Constructors
		public Noise(); // 0x000000018AC81038-0x000000018AC81084
	
		// Methods
		protected override void OnCreate(); // 0x000000018AC80D98-0x000000018AC80E10
		protected override void OnEnter(); // 0x000000018AC80E10-0x000000018AC80E60
		protected override void OnUpdate(float time, float previousTime); // 0x000000018AC80E60-0x000000018AC81038
	}

	[Category("Transform")]
	[Description("Rotate the actor around target position or object by specified degrees and optionaly per second.")]
	public class RotateAround : ActorActionClip // TypeDefIndex: 58402
	{
		// Fields
		[HideInInspector]
		[SerializeField]
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
		[AnimatableParameter(link = "targetPosition")]
		[PositionHandle]
		[ShowTrajectory]
		public Vector3 targetPositionVector { get; set; } // 0x000000018AC801D0-0x000000018AC80204 0x0000000184D91E40-0x0000000184D91E50
		public override string info { get; } // 0x000000018AC83588-0x000000018AC83670 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; } // 0x000000018AC7EA6C-0x000000018AC7EA7C 
	
		// Constructors
		public RotateAround(); // 0x000000018AC83548-0x000000018AC83588
	
		// Methods
		protected override void OnAfterValidate(); // 0x000000018AC82F8C-0x000000018AC82FD8
		protected override void OnEnter(); // 0x000000018AC82FD8-0x000000018AC830E4
		protected override void OnUpdate(float time); // 0x000000018AC83174-0x000000018AC83548
		protected override void OnReverse(); // 0x000000018AC830E4-0x000000018AC83174
	}

	[Category("Transform")]
	[Description("Rotate the actor by specified degrees and optionaly per second")]
	public class RotateBy : ActorActionClip // TypeDefIndex: 58403
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		public Vector3 rotation; // 0x44
		public bool perSecond; // 0x50
		public Slate.EaseType interpolation; // 0x54
		private Vector3 originalRot; // 0x58
	
		// Properties
		public override string info { get; } // 0x000000018AC83964-0x000000018AC83A14 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; } // 0x000000018AC7EA6C-0x000000018AC7EA7C 
	
		// Constructors
		public RotateBy(); // 0x000000018AC83924-0x000000018AC83964
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC83670-0x000000018AC836F4
		protected override void OnUpdate(float time); // 0x000000018AC83784-0x000000018AC83924
		protected override void OnReverse(); // 0x000000018AC836F4-0x000000018AC83784
	}

	[Category("Transform")]
	public class RotateTo : ActorActionClip // TypeDefIndex: 58404
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		public Vector3 targetRotation; // 0x44
		public Slate.EaseType interpolation; // 0x50
		private Vector3 originalRot; // 0x54
	
		// Properties
		public override string info { get; } // 0x000000018AC83C18-0x000000018AC83C84 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; } // 0x000000018AC7EA6C-0x000000018AC7EA7C 
	
		// Constructors
		public RotateTo(); // 0x000000018AC7E034-0x000000018AC7E058
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC83A14-0x000000018AC83A64
		protected override void OnUpdate(float deltaTime); // 0x000000018AC83AB8-0x000000018AC83C18
		protected override void OnReverse(); // 0x000000018AC83A64-0x000000018AC83AB8
	}

	[Category("Transform")]
	[Description("Scale the actor by specified value and optionlay per second")]
	public class ScaleBy : ActorActionClip // TypeDefIndex: 58405
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		public Vector3 scale; // 0x44
		public bool perSecond; // 0x50
		public Slate.EaseType interpolation; // 0x54
		private Vector3 originalScale; // 0x58
	
		// Properties
		public override string info { get; } // 0x000000018AC844A0-0x000000018AC84550 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; } // 0x000000018AC7EA6C-0x000000018AC7EA7C 
	
		// Constructors
		public ScaleBy(); // 0x000000018AC84464-0x000000018AC844A0
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC84240-0x000000018AC84290
		protected override void OnUpdate(float deltaTime); // 0x000000018AC842E4-0x000000018AC84464
		protected override void OnReverse(); // 0x000000018AC84290-0x000000018AC842E4
	}

	[Category("Transform")]
	public class ScaleTo : ActorActionClip // TypeDefIndex: 58406
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		public Vector3 targetScale; // 0x44
		public Slate.EaseType interpolation; // 0x50
		private Vector3 originalPos; // 0x54
	
		// Properties
		public override string info { get; } // 0x000000018AC84754-0x000000018AC847C0 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; } // 0x000000018AC7EA6C-0x000000018AC7EA7C 
	
		// Constructors
		public ScaleTo(); // 0x000000018AC7E034-0x000000018AC7E058
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC84550-0x000000018AC845A0
		protected override void OnUpdate(float deltaTime); // 0x000000018AC845F4-0x000000018AC84754
		protected override void OnReverse(); // 0x000000018AC845A0-0x000000018AC845F4
	}

	[Category("Transform")]
	[Obsolete("Use Set Parent")]
	public class SetParentTemporary : ActorActionClip // TypeDefIndex: 58407
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
		public override string info { get; } // 0x000000018AC85818-0x000000018AC858B8 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
	
		// Constructors
		public SetParentTemporary(); // 0x000000018AC67F18-0x000000018AC67F34
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC85448-0x000000018AC85554
		protected override void OnUpdate(float deltaTime); // 0x000000018AC85664-0x000000018AC85818
		protected override void OnReverse(); // 0x000000018AC85554-0x000000018AC85664
	}

	[Category("Transform")]
	[Description("Set the parent of the actor gameobject temporarily, or permanently if length is zero")]
	public class SetTransformParent : ActorActionClip // TypeDefIndex: 58408
	{
		// Fields
		[HideInInspector]
		[SerializeField]
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
		public override string info { get; } // 0x000000018AC861CC-0x000000018AC8626C 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
	
		// Constructors
		public SetTransformParent(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC86168-0x000000018AC8619C
		protected override void OnReverseEnter(); // 0x000000018AC861B0-0x000000018AC861C4
		protected override void OnExit(); // 0x000000018AC8619C-0x000000018AC861B0
		protected override void OnReverse(); // 0x000000018AC861C4-0x000000018AC861CC
		private void Do(); // 0x000000018AC85F0C-0x000000018AC86168
		private void UnDo(); // 0x000000018AC85554-0x000000018AC85664
	}

	[Category("Transform")]
	[Description("Instantely set the transforms of the actor.")]
	public class SetTransformValues : ActorActionClip // TypeDefIndex: 58409
	{
		// Fields
		[HelpBox("Transform Space affects both Position and Rotation, but not Scale")]
		public MiniTransformSpace space; // 0x40
		public bool setPosition; // 0x44
		public Vector3 position; // 0x48
		public bool setRotation; // 0x54
		public Vector3 rotation; // 0x58
		public bool setScale; // 0x64
		public Vector3 scale; // 0x68
		private TransformSnapshot undo; // 0x78
	
		// Constructors
		public SetTransformValues(); // 0x000000018AC86458-0x000000018AC8648C
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC8626C-0x000000018AC86438
		protected override void OnReverse(); // 0x000000018AC86438-0x000000018AC86458
	}

	[Category("Transform")]
	[Description("Grounds the actor gameobject to the nearest collider object beneath it up to the set Max Distance")]
	public class SimpleGrounder : ActorActionClip // TypeDefIndex: 58410
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[Range(1f, 100f)]
		public float maxCheckDistance; // 0x44
		[Slate.Min(0f)]
		public float offset; // 0x48
		private RaycastHit hit; // 0x50
		private Vector3 lastPos; // 0x90
	
		// Properties
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
	
		// Constructors
		public SimpleGrounder(); // 0x000000018AC867AC-0x000000018AC867D8
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC8648C-0x000000018AC864E4
		protected override void OnUpdate(float time); // 0x000000018AC8653C-0x000000018AC867AC
		protected override void OnReverse(); // 0x000000018AC864E4-0x000000018AC8653C
	}

	[Category("Transform")]
	[Description("Translate the actor by specified value and optionaly per second")]
	public class TranslateBy : ActorActionClip // TypeDefIndex: 58411
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		public Vector3 translation; // 0x44
		public bool perSecond; // 0x50
		public Slate.EaseType interpolation; // 0x54
		private Vector3 originalPos; // 0x58
	
		// Properties
		public override string info { get; } // 0x000000018AC87490-0x000000018AC87540 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; } // 0x000000018AC7EA6C-0x000000018AC7EA7C 
	
		// Constructors
		public TranslateBy(); // 0x000000018AC87450-0x000000018AC87490
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC8722C-0x000000018AC8727C
		protected override void OnUpdate(float deltaTime); // 0x000000018AC872D0-0x000000018AC87450
		protected override void OnReverse(); // 0x000000018AC8727C-0x000000018AC872D0
	}

	[Category("Transform")]
	public class TranslateTo : ActorActionClip // TypeDefIndex: 58412
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		public Vector3 targetPosition; // 0x44
		public MiniTransformSpace space; // 0x50
		public Slate.EaseType interpolation; // 0x54
		private Vector3 wasPosition; // 0x58
	
		// Properties
		public override string info { get; } // 0x000000018AC87784-0x000000018AC877F0 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; } // 0x000000018AC7EA6C-0x000000018AC7EA7C 
	
		// Constructors
		public TranslateTo(); // 0x000000018AC87760-0x000000018AC87784
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC87540-0x000000018AC87590
		protected override void OnUpdate(float time); // 0x000000018AC875E4-0x000000018AC87760
		protected override void OnReverse(); // 0x000000018AC87590-0x000000018AC875E4
	}

	[Category("Composition")]
	[Description("Additive load a Scene for a duration of time, or permanentely if length is zero.\n\nIf \'Update Root Cutscenes\' is true, all root cutscenes objects of that scene will also be updated for the duration of the clip with an optional time offset provided.")]
	public class AdditiveScene : DirectorActionClip, ISubClipContainable // TypeDefIndex: 58413
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		protected string _scenePath; // 0x48
		[Tooltip("The position to spawn the SubScene at")]
		public Vector3 scenePosition; // 0x50
		[Tooltip("The rotation to spawn the SubScene at")]
		public Vector3 sceneRotation; // 0x5C
		[Tooltip("The Space used for ScenePosition and SceneRotation")]
		public MiniTransformSpace space; // 0x68
		[Tooltip("Should root cutscenes found be updated?")]
		public bool updateRootCutscenes; // 0x6C
		[ShowIf("updateRootCutscenes", 1)]
		[Tooltip("Update offset of root cutscenes")]
		public float timeOffset; // 0x70
		private Scene subScene; // 0x74
		private List<Cutscene> rootCutscenes; // 0x78
		private bool temporary; // 0x80
		private bool waitLoad; // 0x81
	
		// Properties
		float ISubClipContainable.subClipOffset { get; set; } // 0x0000000184D90610-0x0000000184D90620 0x0000000184D90600-0x0000000184D90610
		float ISubClipContainable.subClipLength { get; } // 0x0000000184D879D0-0x0000000184D879E0 
		float ISubClipContainable.subClipSpeed { get; } // 0x0000000184D879D0-0x0000000184D879E0 
		public override bool isValid { get; } // 0x000000018AC7BD48-0x000000018AC7BD60 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		new string IDirectable.name { get; } // 0x0000000185396F58-0x0000000185396F60 
	
		// Constructors
		public AdditiveScene(); // 0x000000018AC7BD28-0x000000018AC7BD48
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC7BBAC-0x000000018AC7BBE0
		protected override void OnReverseEnter(); // 0x000000018AC7BC14-0x000000018AC7BC28
		protected override void OnUpdate(float time); // 0x000000018AC7BC4C-0x000000018AC7BD28
		protected override void OnExit(); // 0x000000018AC7BBE0-0x000000018AC7BC14
		protected override void OnReverse(); // 0x000000018AC7BC28-0x000000018AC7BC4C
		private void Activate(); // 0x000000018AC7B4E4-0x000000018AC7B578
		private void Deactivate(); // 0x000000018AC7B5FC-0x000000018AC7B670
		private string CleanPath(string path); // 0x000000018AC7B578-0x000000018AC7B5FC
		private void InitializeSubSceneCutscenes(); // 0x000000018AC7B83C-0x000000018AC7BBAC
		private void DenitializeSubSceneCutscenes(bool forward); // 0x000000018AC7B670-0x000000018AC7B83C
	}

	[Category("Composition")]
	[Description("SubCutscenes are used for organization. Notice that the CameraTrack of the SubCutscene is ignored if this Cutscene already has an active CameraTrack.")]
	public class SubCutscene : DirectorActionClip, ISubClipContainable // TypeDefIndex: 58414
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[FormerlySerializedAs("cutscene")]
		[Required]
		public Cutscene subCutscene; // 0x48
		public float subCutsceneTimeOffset; // 0x50
		private bool wasCamTrackActive; // 0x54
	
		// Properties
		public override string info { get; } // 0x000000018AC87010-0x000000018AC870D8 
		public override bool isValid { get; } // 0x000000018AC870D8-0x000000018AC87144 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public new GameObject actor { get; } // 0x000000018AC86FCC-0x000000018AC87010 
		float ISubClipContainable.subClipOffset { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
		float ISubClipContainable.subClipLength { get; } // 0x000000018AC86F54-0x000000018AC86F90 
		float ISubClipContainable.subClipSpeed { get; } // 0x000000018AC86F90-0x000000018AC86FCC 
		new string IDirectable.name { get; } // 0x0000000185396F58-0x0000000185396F60 
	
		// Constructors
		public SubCutscene(); // 0x000000018AC67F18-0x000000018AC67F34
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC86C2C-0x000000018AC86CF4
		protected override void OnReverseEnter(); // 0x000000018AC86D9C-0x000000018AC86E68
		protected override void OnExit(); // 0x000000018AC86CF4-0x000000018AC86D9C
		protected override void OnReverse(); // 0x000000018AC86E68-0x000000018AC86F08
		protected override void OnUpdate(float time, float previousTime); // 0x000000018AC86F08-0x000000018AC86F54
	}

	[Category("Control")]
	[Description("Destroy all gameobjects in the list (PlayMode only).\nYou should NOT use this clip to destroy actors.")]
	public class DestroyGameObjects : DirectorActionClip // TypeDefIndex: 58415
	{
		// Fields
		public List<GameObject> targetObjects; // 0x40
	
		// Properties
		public override string info { get; } // 0x000000018AC7ED70-0x000000018AC7EDEC 
	
		// Constructors
		public DestroyGameObjects(); // 0x000000018AC7ECF0-0x000000018AC7ED70
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC7EB9C-0x000000018AC7ECF0
	}

	[Category("Control")]
	[Description("All gameobjects in the list will be disabled if not already")]
	[Name("Disable Game Objects")]
	public class DirectorDisableGameObjects : DirectorActionClip // TypeDefIndex: 58416
	{
		// Fields
		public List<GameObject> targetObjects; // 0x40
		private Dictionary<GameObject, bool> states; // 0x48
	
		// Properties
		public override string info { get; } // 0x000000018AC7F1C0-0x000000018AC7F23C 
	
		// Constructors
		public DirectorDisableGameObjects(); // 0x000000018AC7F140-0x000000018AC7F1C0
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC7EDEC-0x000000018AC7EFB4
		protected override void OnReverse(); // 0x000000018AC7EFB4-0x000000018AC7F140
	}

	[Category("Control")]
	[Description("All gameobjects in the list will be enabled if not already")]
	[Name("Enable Game Objects")]
	public class DirectorEnableGameObjects : DirectorActionClip // TypeDefIndex: 58417
	{
		// Fields
		public List<GameObject> targetObjects; // 0x40
		private Dictionary<GameObject, bool> states; // 0x48
	
		// Properties
		public override string info { get; } // 0x000000018AC7F610-0x000000018AC7F68C 
	
		// Constructors
		public DirectorEnableGameObjects(); // 0x000000018AC7F590-0x000000018AC7F610
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC7F23C-0x000000018AC7F404
		protected override void OnReverse(); // 0x000000018AC7F404-0x000000018AC7F590
	}

	[Category("Control")]
	[Description("Instantiates an object with optional popup animation if BlendIn is higher than zero. You can optionaly \'popdown\' and destroy the object after a period of time, if you also set a BlendOut value higher than zero.")]
	public class InstantiateObject : DirectorActionClip // TypeDefIndex: 58418
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
		[PlaybackProtected]
		[Required]
		public GameObject targetObject; // 0x50
		public Transform optionalParent; // 0x58
		public Vector3 targetPosition; // 0x60
		public Vector3 targetRotation; // 0x6C
		public MiniTransformSpace space; // 0x78
		public Slate.EaseType popupInterpolation; // 0x7C
		private GameObject instance; // 0x80
		private Vector3 wasScale; // 0x88
	
		// Properties
		public override bool isValid { get; } // 0x000000018AC7FD9C-0x000000018AC7FDEC 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override string info { get; } // 0x000000018AC7FCFC-0x000000018AC7FD9C 
		private new GameObject actor { get; } // 0x0000000184D86260-0x0000000184D86270 
	
		// Constructors
		public InstantiateObject(); // 0x000000018AC7FCD8-0x000000018AC7FCFC
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC7F788-0x000000018AC7FA98
		protected override void OnUpdate(float time); // 0x000000018AC7FB88-0x000000018AC7FCD8
		protected override void OnExit(); // 0x000000018AC7FA98-0x000000018AC7FAFC
		protected override void OnReverseEnter(); // 0x000000018AC7FAFC-0x000000018AC7FB34
		protected override void OnReverse(); // 0x000000018AC7FB34-0x000000018AC7FB88
	}

	[Category("Control")]
	public class SampleParticleSystem : DirectorActionClip // TypeDefIndex: 58419
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[Required]
		public ParticleSystem particles; // 0x48
		[Tooltip("If true, then particles simulation will be time synced with the cutscene, otherwise simulation will take place independently")]
		public bool simulationSync; // 0x50
		private ParticleSystem.EmissionModule em; // 0x58
	
		// Properties
		public override string info { get; } // 0x000000018AC83F44-0x000000018AC8405C 
		public override bool isValid { get; } // 0x000000018AC8405C-0x000000018AC840AC 
		public override float length { get; set; } // 0x000000018AC840AC-0x000000018AC8413C 0x0000000184D86470-0x0000000184D86480
		public override float blendOut { get; } // 0x000000018AC83E78-0x000000018AC83EC0 
		private bool loop { get; } // 0x000000018AC8413C-0x000000018AC841BC 
		private float duration { get; } // 0x000000018AC83EC0-0x000000018AC83F44 
		private float startLifetime { get; } // 0x000000018AC841BC-0x000000018AC84240 
	
		// Constructors
		public SampleParticleSystem(); // 0x000000018AC83E58-0x000000018AC83E78
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC83C84-0x000000018AC83C8C
		protected override void OnReverseEnter(); // 0x000000018AC83C84-0x000000018AC83C8C
		protected override void OnExit(); // 0x000000018AC83C8C-0x000000018AC83C94
		protected override void OnReverse(); // 0x000000018AC83C8C-0x000000018AC83C94
		protected override void OnRootEnabled(); // 0x000000018AC83CE0-0x000000018AC83D30
		protected override void OnRootDisabled(); // 0x000000018AC83C94-0x000000018AC83CE0
		private void Play(); // 0x000000018AC83D9C-0x000000018AC83E18
		protected override void OnUpdate(float time); // 0x000000018AC83D30-0x000000018AC83D9C
		private void Stop(); // 0x000000018AC83E18-0x000000018AC83E58
	}

	[Category("Control")]
	[Description("Will transit the given audio mixer to the given snapshot")]
	public class TransitAudioMixerSnapshot : DirectorActionClip // TypeDefIndex: 58420
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		public AudioMixer audioMixer; // 0x48
		public string snapshotName; // 0x50
		private AudioMixerSnapshot snapshot; // 0x58
	
		// Properties
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; } // 0x000000018AC7EA6C-0x000000018AC7EA7C 
		public override bool isValid { get; } // 0x000000018AC871DC-0x000000018AC8722C 
	
		// Constructors
		public TransitAudioMixerSnapshot(); // 0x000000018AC67F18-0x000000018AC67F34
	
		// Methods
		protected override void OnReverseEnter(); // 0x000000018AC871D4-0x000000018AC871DC
		protected override void OnEnter(); // 0x000000018AC871D4-0x000000018AC871DC
		private void Do(); // 0x000000018AC87144-0x000000018AC871D4
	}

	[Category("Environment")]
	public class AnimateAmbientLighting : DirectorActionClip // TypeDefIndex: 58421
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
		[AnimatableParameter(0f, 10f)]
		public float ambientIntensity; // 0x4C
		[AnimatableParameter]
		public UnityEngine.Color ambientColor; // 0x50
		private float wasIntensity; // 0x60
		private UnityEngine.Color wasColor; // 0x64
	
		// Properties
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
	
		// Constructors
		public AnimateAmbientLighting(); // 0x000000018AC67F18-0x000000018AC67F34
	
		// Methods
		protected override void OnCreate(); // 0x000000018AC7BD60-0x000000018AC7BD90
		protected override void OnEnter(); // 0x000000018AC7BD90-0x000000018AC7BDC0
		protected override void OnUpdate(float time); // 0x000000018AC7BDF0-0x000000018AC7BE70
		protected override void OnReverse(); // 0x000000018AC7BDC0-0x000000018AC7BDF0
	}

	[Category("Environment")]
	public class AnimateFog : DirectorActionClip // TypeDefIndex: 58422
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
		[AnimatableParameter]
		public UnityEngine.Color fogColor; // 0x4C
		[AnimatableParameter]
		public float fogDensity; // 0x5C
		[AnimatableParameter]
		public float linearFogStartDistance; // 0x60
		[AnimatableParameter]
		public float linearFogEndDistance; // 0x64
		private UnityEngine.Color wasColor; // 0x68
		private float wasDensity; // 0x78
		private float wasStartDistance; // 0x7C
		private float wasEndDistance; // 0x80
	
		// Properties
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
	
		// Constructors
		public AnimateFog(); // 0x000000018AC67F18-0x000000018AC67F34
	
		// Methods
		protected override void OnCreate(); // 0x000000018AC7C284-0x000000018AC7C2CC
		protected override void OnEnter(); // 0x000000018AC7C2CC-0x000000018AC7C318
		protected override void OnUpdate(float time); // 0x000000018AC7C364-0x000000018AC7C418
		protected override void OnReverse(); // 0x000000018AC7C318-0x000000018AC7C364
	}

	[Category("Environment")]
	[Description("Animate the gravity physics are using for Rigidbodies. This applies to both 2D and 3D Physics.")]
	public class AnimateGravity : DirectorActionClip // TypeDefIndex: 58423
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
		[AnimatableParameter]
		public Vector3 gravity; // 0x4C
		private Vector3 wasGravity; // 0x58
	
		// Properties
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
	
		// Constructors
		public AnimateGravity(); // 0x000000018AC67F18-0x000000018AC67F34
	
		// Methods
		protected override void OnCreate(); // 0x000000018AC7C418-0x000000018AC7C444
		protected override void OnEnter(); // 0x000000018AC7C444-0x000000018AC7C470
		protected override void OnUpdate(float time); // 0x000000018AC7C4FC-0x000000018AC7C5E0
		protected override void OnReverse(); // 0x000000018AC7C470-0x000000018AC7C4FC
	}

	[Category("Environment")]
	public class AnimateTimeScale : DirectorActionClip // TypeDefIndex: 58424
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
		[AnimatableParameter(0.01f, 10f)]
		public float timeScale; // 0x4C
		public Slate.EaseType interpolation; // 0x50
		private float wasScale; // 0x54
	
		// Properties
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
	
		// Constructors
		public AnimateTimeScale(); // 0x000000018AC7E034-0x000000018AC7E058
	
		// Methods
		protected override void OnCreate(); // 0x000000018AC7E058-0x000000018AC7E074
		protected override void OnEnter(); // 0x000000018AC7E074-0x000000018AC7E090
		protected override void OnUpdate(float time); // 0x000000018AC7E09C-0x000000018AC7E10C
		protected override void OnReverse(); // 0x000000018AC7E090-0x000000018AC7E09C
	}

	[Category("Environment")]
	[Description("A quick way to create a slow-motion time effect.")]
	[Obsolete]
	public class EasySlowMotion : DirectorActionClip // TypeDefIndex: 58425
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
		[Range(0.05f, 1f)]
		public float timeScale; // 0x4C
		public Slate.EaseType interpolation; // 0x50
		private float lastTimeScale; // 0x54
	
		// Properties
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override string info { get; } // 0x000000018AC7F72C-0x000000018AC7F788 
	
		// Constructors
		public EasySlowMotion(); // 0x000000018AC7F6F4-0x000000018AC7F72C
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC7E074-0x000000018AC7E090
		protected override void OnUpdate(float deltaTime); // 0x000000018AC7F68C-0x000000018AC7F6F4
		protected override void OnReverse(); // 0x000000018AC7E090-0x000000018AC7E09C
	}

	[Category("Events")]
	[Description("Raise a Unity Event when the time is moving forwards and another when the time is moving backwards. This is helpfull if you want to use these events with UI to reverse their state, both in runtime and in editor.")]
	public class RaiseUnityEvent : DirectorActionClip // TypeDefIndex: 58426
	{
		// Fields
		public string customLabel; // 0x40
		public UnityEvent forwardEvent; // 0x48
		public UnityEvent reverseEvent; // 0x50
	
		// Properties
		public override string info { get; } // 0x000000018AC82D68-0x000000018AC82F8C 
	
		// Constructors
		public RaiseUnityEvent(); // 0x000000018AC82CCC-0x000000018AC82D68
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC82C8C-0x000000018AC82CAC
		protected override void OnReverse(); // 0x000000018AC82CAC-0x000000018AC82CCC
	}

	public abstract class SendGlobalMessage<T> : SendGlobalMessage // TypeDefIndex: 58427
	{
		// Fields
		public T value;
	
		// Properties
		public override string info { get; }
	
		// Constructors
		protected SendGlobalMessage();
	
		// Methods
		protected override void OnEnter();
	}

	[Category("Events")]
	[Description("Send a Unity Message to all actors of this Cutscene, including the Director Camera, as well as the Cutscene itself.")]
	public class SendGlobalMessage : DirectorActionClip, IEvent // TypeDefIndex: 58428
	{
		// Fields
		[Required]
		public string message; // 0x40
	
		// Properties
		public override string info { get; } // 0x000000018AC84E84-0x000000018AC84EC4 
		public override bool isValid { get; } // 0x00000001891DE054-0x00000001891DE06C 
		string IEvent.name { get; } // 0x0000000184D85A60-0x0000000184D85A70 
	
		// Constructors
		public SendGlobalMessage(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		void IEvent.Invoke(); // 0x000000018AC84E74-0x000000018AC84E84
		protected override void OnEnter(); // 0x000000018AC84E34-0x000000018AC84E74
	}

	public class SendGlobalMessageBoolean : SendGlobalMessage<bool> // TypeDefIndex: 58429
	{
		// Constructors
		public SendGlobalMessageBoolean(); // 0x000000018AC84CF4-0x000000018AC84D34
	}

	public class SendGlobalMessageFloat : SendGlobalMessage<float> // TypeDefIndex: 58430
	{
		// Constructors
		public SendGlobalMessageFloat(); // 0x000000018AC84D34-0x000000018AC84D74
	}

	public class SendGlobalMessageInteger : SendGlobalMessage<int> // TypeDefIndex: 58431
	{
		// Constructors
		public SendGlobalMessageInteger(); // 0x000000018AC84D74-0x000000018AC84DB4
	}

	public class SendGlobalMessageObject : SendGlobalMessage<UnityEngine.Object> // TypeDefIndex: 58432
	{
		// Constructors
		public SendGlobalMessageObject(); // 0x000000018AC84DB4-0x000000018AC84DF4
	}

	public class SendGlobalMessageString : SendGlobalMessage<string> // TypeDefIndex: 58433
	{
		// Constructors
		public SendGlobalMessageString(); // 0x000000018AC84DF4-0x000000018AC84E34
	}

	[Category("Rendering")]
	[Description("Shows closed captions at the bottom of the screen. Note that the Play Audio clips of the Audio Track are also able to show subtitles in sync with the audio. Use this for non audible subtitles or captions.")]
	public class Captions : DirectorActionClip // TypeDefIndex: 58434
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
		[Multiline(5)]
		public string text; // 0x50
		public UnityEngine.Color color; // 0x58
		public Slate.EaseType interpolation; // 0x68
	
		// Properties
		public override string info { get; } // 0x000000018AC7E954-0x000000018AC7E994 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
	
		// Constructors
		public Captions(); // 0x000000018AC7E8E0-0x000000018AC7E954
	
		// Methods
		protected override void OnUpdate(float deltaTime); // 0x000000018AC7E86C-0x000000018AC7E8E0
	}

	[Category("Rendering")]
	[Description("Controls the visibility of the Cinematic Letterbox. This is only usefull if you want a Cinematic Letterbox only in some parts of your cutscene. For this to work correctly, you should set the CineBox effect in the Cutscene CameraTrack to 0, so that the effect is not overriden.")]
	public class CineBox : DirectorActionClip // TypeDefIndex: 58435
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
	
		// Properties
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
	
		// Constructors
		public CineBox(); // 0x000000018AC7E9AC-0x000000018AC7E9D8
	
		// Methods
		protected override void OnUpdate(float time); // 0x000000018AC7E994-0x000000018AC7E9AC
	}

	[Category("Rendering")]
	[Description("Show text on screen")]
	public class OverlayText : DirectorActionClip // TypeDefIndex: 58436
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
		[Multiline(5)]
		public string text; // 0x50
		public TextAnchor anchor; // 0x58
		public Slate.EaseType interpolation; // 0x5C
		[AnimatableParameter]
		public UnityEngine.Color color; // 0x60
		[AnimatableParameter]
		public float size; // 0x70
		[AnimatableParameter]
		public Vector2 position; // 0x74
	
		// Properties
		public override string info { get; } // 0x000000018AC8119C-0x000000018AC811DC 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
	
		// Constructors
		public OverlayText(); // 0x000000018AC81118-0x000000018AC8119C
	
		// Methods
		protected override void OnUpdate(float time); // 0x000000018AC81084-0x000000018AC81118
	}

	[Category("Rendering")]
	[Description("Displays a texture overlay")]
	public class OverlayTexture : DirectorActionClip // TypeDefIndex: 58437
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
		public Texture texture; // 0x50
		[AnimatableParameter]
		public UnityEngine.Color color; // 0x58
		[AnimatableParameter]
		public Vector2 scale; // 0x68
		[AnimatableParameter]
		public Vector2 position; // 0x70
		public Slate.EaseType interpolation; // 0x78
	
		// Properties
		public override string info { get; } // 0x000000018AC812C8-0x000000018AC81368 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
	
		// Constructors
		public OverlayTexture(); // 0x000000018AC81278-0x000000018AC812C8
	
		// Methods
		protected override void OnUpdate(float deltaTime); // 0x000000018AC811DC-0x000000018AC81278
	}

	[Category("Rendering")]
	[Description("An alternative way to fade the screen. Fade out/in can also be done through the Camera Shot clip in the Camera Track, but with this clip, more effects can be achieved.")]
	public class ScreenFader : DirectorActionClip // TypeDefIndex: 58438
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
		[AnimatableParameter(0f, 1f)]
		public float fade; // 0x4C
		[AnimatableParameter("Color")]
		public UnityEngine.Color outColor; // 0x50
		public Slate.EaseType interpolation; // 0x60
		private UnityEngine.Color lastColor; // 0x64
	
		// Properties
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
	
		// Constructors
		public ScreenFader(); // 0x000000018AC8486C-0x000000018AC848C8
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC847C0-0x000000018AC847E0
		protected override void OnUpdate(float deltaTime); // 0x000000018AC84800-0x000000018AC8486C
		protected override void OnReverse(); // 0x000000018AC847E0-0x000000018AC84800
	}

	[Category("Utility")]
	[Description("Animates the playback speed of the cutscene")]
	public class AnimatePlaybackSpeed : DirectorActionClip // TypeDefIndex: 58439
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
		[AnimatableParameter(0.01f, 10f)]
		public float speed; // 0x4C
		public Slate.EaseType interpolation; // 0x50
		private float wasSpeed; // 0x54
	
		// Properties
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
	
		// Constructors
		public AnimatePlaybackSpeed(); // 0x000000018AC7E034-0x000000018AC7E058
	
		// Methods
		protected override void OnCreate(); // 0x000000018AC7DF0C-0x000000018AC7DF3C
		protected override void OnEnter(); // 0x000000018AC7DF3C-0x000000018AC7DF6C
		protected override void OnUpdate(float time); // 0x000000018AC7DF9C-0x000000018AC7E034
		protected override void OnReverse(); // 0x000000018AC7DF6C-0x000000018AC7DF9C
	}

	[Category("Utility")]
	public class DebugLog : DirectorActionClip // TypeDefIndex: 58440
	{
		// Fields
		[LeftToggle]
		public bool neverSkip; // 0x40
		public string text; // 0x48
	
		// Properties
		public override string info { get; } // 0x000000018AC7EB5C-0x000000018AC7EB9C 
	
		// Constructors
		public DebugLog(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC7EABC-0x000000018AC7EB5C
	}

	[Category("Utility")]
	[Description("Pauses the Cutscene (PlayMode Only). It\'s up to other scripts to resume it.")]
	public class PauseCutscene : DirectorActionClip // TypeDefIndex: 58441
	{
		// Constructors
		public PauseCutscene(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC81368-0x000000018AC8145C
	}

	[Category("Utilities")]
	[Description("Render the cutscene in an image-sequence for the selected duration of the clip. Rendering is done in playmode only.")]
	[Obsolete("Use the new \'Render\' feature")]
	public class ScreenCapture : DirectorActionClip // TypeDefIndex: 58442
	{
		// Constructors
		public ScreenCapture(); // 0x0000000185393520-0x0000000185393538
	}

	[Attachable(new System.Type[1] {typeof(AnimationTrack) })]
	[Description("All animation clips in the same track, will play at an animation layer equal to their track layer order. Thus, animations in tracks on top will play over animations in tracks bellow. You can trim or loop the animation by scaling the clip.")]
	[Name("Animation Clip")]
	public class PlayAnimationClip : ActorActionClip<Animation>, ISubClipContainable // TypeDefIndex: 58443
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x4C
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x50
		[Required]
		public AnimationClip animationClip; // 0x58
		public float clipOffset; // 0x60
		[Range(0.1f, 5f)]
		public float playbackSpeed; // 0x64
		private TransformSnapshot snapShot; // 0x68
		private Transform mixTransform; // 0x70
		private UnityEngine.AnimationState state; // 0x78
		private bool isListClip; // 0x80
	
		// Properties
		float ISubClipContainable.subClipOffset { get; set; } // 0x0000000184D88480-0x0000000184D88490 0x0000000184D884A0-0x0000000184D884B0
		float ISubClipContainable.subClipLength { get; } // 0x000000018AC81A4C-0x000000018AC81ABC 
		float ISubClipContainable.subClipSpeed { get; } // 0x0000000184D88470-0x0000000184D88480 
		public override string info { get; } // 0x000000018AC81B10-0x000000018AC81B84 
		public override bool isValid { get; } // 0x000000018AC81B84-0x000000018AC81C14 
		public override float length { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override float blendIn { get; set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000184D91480-0x0000000184D91490
		public override float blendOut { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
		public override bool canCrossBlend { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		private AnimationTrack track { get; } // 0x000000018AC81C14-0x000000018AC81C50 
		new string IDirectable.name { get; } // 0x0000000185396F58-0x0000000185396F60 
	
		// Constructors
		public PlayAnimationClip(); // 0x000000018AC81ABC-0x000000018AC81B10
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC8145C-0x000000018AC81644
		protected override void OnUpdate(float time); // 0x000000018AC8170C-0x000000018AC81A4C
		protected override void OnReverse(); // 0x000000018AC8168C-0x000000018AC8170C
		protected override void OnExit(); // 0x000000018AC81644-0x000000018AC81668
		protected override void OnReverseEnter(); // 0x000000018AC81668-0x000000018AC8168C
	}

	[Attachable(new System.Type[1] {typeof(AnimatorTrack) })]
	[Description("Play an Animation Clip on target actor with Animator component attached.\nIf this is the Layer 0 Animator Track, you can choose to explicitely set a \'Starting Position\' and a \'Starting Rotation\' for when the clip starts. This also takes into account Root Motion if enabled in the Animator Track.")]
	[Name("Animation Clip")]
	public class PlayAnimatorClip : ActorActionClip, ISubClipContainable // TypeDefIndex: 58446
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
		[Header("Animation Clip Settings")]
		[Required]
		public AnimationClip animationClip; // 0x50
		public float clipOffset; // 0x58
		public ClipWrapMode clipWrapMode; // 0x5C
		[Range(0f, 1f)]
		public float clipWeight; // 0x60
		[Range(-5f, 5f)]
		public float playbackSpeed; // 0x64
		[EnabledIf("isMasterTrack", 1)]
		[Header("Starting Transforms Settings")]
		public StartingTransformsMode startingTransformsMode; // 0x68
		[EnabledIf("isMasterAndManualSet", 1)]
		public MiniTransformSpace transformSpace; // 0x6C
		[EnabledIf("isMasterAndManualSet", 1)]
		public Vector3 startingPosition; // 0x70
		[EnabledIf("isMasterAndManualSet", 1)]
		public Vector3 startingRotation; // 0x7C
		[AnimatableParameter("Local Rotation Offset")]
		[Header("---")]
		[HelpBox("\'Local Rotation Offset\' is only used if this clip is part of the Layer 0 Track and RootMotion is enabled in that Track.\nYou can animate this parameter to rotate the actor while using it\'s RootMotion within the Animation Clip.\nThis can be very useful for animations like Walk or Run. Most of the times, simply animating \'Y\' will suffice.")]
		public Vector2 steerLocalRotation; // 0x88
		protected Vector3 wasPosition; // 0x90
		protected Quaternion wasRotation; // 0x9C
	
		// Properties
		private bool isMasterAndManualSet { get; } // 0x000000018AC82578-0x000000018AC8259C 
		float ISubClipContainable.subClipOffset { get; set; } // 0x0000000184D88400-0x0000000184D88410 0x0000000184D88430-0x0000000184D88440
		float ISubClipContainable.subClipLength { get; } // 0x000000018AC82440-0x000000018AC824B0 
		float ISubClipContainable.subClipSpeed { get; } // 0x0000000184D88470-0x0000000184D88480 
		public override string info { get; } // 0x000000018AC82500-0x000000018AC82578 
		public override bool isValid { get; } // 0x000000018AC825C0-0x000000018AC8266C 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override bool canCrossBlend { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		protected AnimatorTrack track { get; } // 0x000000018AC8266C-0x000000018AC826A8 
		protected Animator animator { get; } // 0x000000018AC824DC-0x000000018AC82500 
		protected bool isMasterTrack { get; } // 0x000000018AC8259C-0x000000018AC825C0 
		new string IDirectable.name { get; } // 0x0000000185396F58-0x0000000185396F60 
	
		// Nested types
		public enum StartingTransformsMode // TypeDefIndex: 58444
		{
			AutoMatchTransforms = 0,
			ManualSetTransforms = 1
		}
	
		public enum ClipWrapMode // TypeDefIndex: 58445
		{
			Loop = 0,
			PingPong = 1
		}
	
		// Constructors
		public PlayAnimatorClip(); // 0x000000018AC824B0-0x000000018AC824DC
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC81C50-0x000000018AC81E74
		protected override void OnReverseEnter(); // 0x000000018AC81ED8-0x000000018AC81F3C
		protected override void OnUpdate(float time, float previousTime); // 0x000000018AC8201C-0x000000018AC82440
		protected override void OnExit(); // 0x000000018AC81E74-0x000000018AC81ED8
		protected override void OnReverse(); // 0x000000018AC81F3C-0x000000018AC8201C
	}

	[Attachable(new System.Type[2] {typeof(ActorAudioTrack), typeof(DirectorAudioTrack) })]
	[Description("The audio clip will be send to the AudioMixer selected in it\'s track if any. You can trim or loop the audio by scaling the clip and you can optionaly show subtitles as well.")]
	[Name("Audio Clip")]
	public class PlayAudio : ActionClip, ISubClipContainable // TypeDefIndex: 58447
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x44
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x48
		[Required]
		public AudioClip audioClip; // 0x50
		[AnimatableParameter(0f, 1f)]
		public float volume; // 0x58
		[AnimatableParameter(-3f, 3f)]
		public float pitch; // 0x5C
		[AnimatableParameter(-1f, 1f)]
		public float stereoPan; // 0x60
		public float clipOffset; // 0x64
		[Multiline(5)]
		public string subtitlesText; // 0x68
		public UnityEngine.Color subtitlesColor; // 0x70
	
		// Properties
		float ISubClipContainable.subClipOffset { get; set; } // 0x0000000184D88470-0x0000000184D88480 0x0000000184D88490-0x0000000184D884A0
		float ISubClipContainable.subClipLength { get; } // 0x000000018AC82A0C-0x000000018AC82A7C 
		float ISubClipContainable.subClipSpeed { get; } // 0x0000000184D88DD0-0x0000000184D88DE0 
		public override float length { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public override float blendIn { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		public override float blendOut { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override bool isValid { get; } // 0x000000018AC82BE0-0x000000018AC82C30 
		public override string info { get; } // 0x000000018AC82B58-0x000000018AC82BE0 
		private Slate.AudioTrack track { get; } // 0x000000018AC82C50-0x000000018AC82C8C 
		private AudioSource source { get; } // 0x000000018AC82C30-0x000000018AC82C50 
		new string IDirectable.name { get; } // 0x0000000185396F58-0x0000000185396F60 
	
		// Constructors
		public PlayAudio(); // 0x000000018AC82AFC-0x000000018AC82B58
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC8272C-0x000000018AC82734
		protected override void OnReverseEnter(); // 0x000000018AC8272C-0x000000018AC82734
		protected override void OnExit(); // 0x000000018AC82734-0x000000018AC8273C
		protected override void OnReverse(); // 0x000000018AC82734-0x000000018AC8273C
		private void Do(); // 0x000000018AC826A8-0x000000018AC8272C
		protected override void OnUpdate(float time, float previousTime); // 0x000000018AC8273C-0x000000018AC82A0C
		private void Undo(); // 0x000000018AC82A7C-0x000000018AC82AFC
	}

	[Description("Animate a bool Animator parameter and reset it back to previous value after a period of time.")]
	public class AnimateBoolParameter : MecanimBaseClip // TypeDefIndex: 58448
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		public string parameterName; // 0x50
		[AnimatableParameter]
		public bool value; // 0x58
		private bool lastValue; // 0x59
	
		// Properties
		public override bool isValid { get; } // 0x000000018AC7C048-0x000000018AC7C078 
		public override string info { get; } // 0x000000018AC7C008-0x000000018AC7C048 
		public override float length { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
	
		// Constructors
		public AnimateBoolParameter(); // 0x000000018AC7BFF4-0x000000018AC7C008
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC7BE70-0x000000018AC7BEC8
		protected override void OnUpdate(float time); // 0x000000018AC7BF9C-0x000000018AC7BFF4
		protected override void OnExit(); // 0x000000018AC7BEC8-0x000000018AC7BF38
		protected override void OnReverse(); // 0x000000018AC7BF38-0x000000018AC7BF9C
	}

	[Description("Animate a float Animator parameter to a value and back to previous value gradualy over a period of time.")]
	public class AnimateFloatParameter : MecanimBaseClip // TypeDefIndex: 58449
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x4C
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x50
		public string parameterName; // 0x58
		[AnimatableParameter]
		public float value; // 0x60
		private float lastValue; // 0x64
	
		// Properties
		public override bool isValid { get; } // 0x000000018AC7C254-0x000000018AC7C284 
		public override string info { get; } // 0x000000018AC7C214-0x000000018AC7C254 
		public override float length { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override float blendIn { get; set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000184D91480-0x0000000184D91490
		public override float blendOut { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
	
		// Constructors
		public AnimateFloatParameter(); // 0x000000018AC7C1F0-0x000000018AC7C214
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC7C078-0x000000018AC7C0D4
		protected override void OnUpdate(float deltaTime); // 0x000000018AC7C138-0x000000018AC7C1F0
		protected override void OnReverse(); // 0x000000018AC7C0D4-0x000000018AC7C138
	}

	[Description("Animate an integer Animator parameter to a value and back to previous value gradualy over a period of time.")]
	public class AnimateIntegerParameter : MecanimBaseClip // TypeDefIndex: 58450
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x4C
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x50
		public string parameterName; // 0x58
		[AnimatableParameter]
		public int value; // 0x60
		private int lastValue; // 0x64
	
		// Properties
		public override bool isValid { get; } // 0x000000018AC7C254-0x000000018AC7C284 
		public override string info { get; } // 0x000000018AC7C774-0x000000018AC7C7B4 
		public override float length { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override float blendIn { get; set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000184D91480-0x0000000184D91490
		public override float blendOut { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
	
		// Constructors
		public AnimateIntegerParameter(); // 0x000000018AC7C758-0x000000018AC7C774
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC7C5E0-0x000000018AC7C638
		protected override void OnUpdate(float deltaTime); // 0x000000018AC7C69C-0x000000018AC7C758
		protected override void OnReverse(); // 0x000000018AC7C638-0x000000018AC7C69C
	}

	[Description("Animate an Animator layer weight to a value and back to previous value gradualy over a period of time.")]
	public class AnimateLayerWeight : MecanimBaseClip // TypeDefIndex: 58451
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x4C
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x50
		public int layerIndex; // 0x54
		[AnimatableParameter(0f, 1f)]
		public float weight; // 0x58
		private float lastValue; // 0x5C
	
		// Properties
		public override string info { get; } // 0x000000018AC7C94C-0x000000018AC7C9AC 
		public override float length { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override float blendIn { get; set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000184D91480-0x0000000184D91490
		public override float blendOut { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
	
		// Constructors
		public AnimateLayerWeight(); // 0x000000018AC7C928-0x000000018AC7C94C
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC7C7B4-0x000000018AC7C80C
		protected override void OnUpdate(float deltaTime); // 0x000000018AC7C870-0x000000018AC7C928
		protected override void OnReverse(); // 0x000000018AC7C80C-0x000000018AC7C870
	}

	[Attachable(new System.Type[1] {typeof(ActorActionTrack) })]
	[Category("Animator IK Control")]
	[Description("Animate an actor IK Goal. Please note that the Animator needs to have a Controller assigned and \'IK Pass\' must be enabled in that Controller.")]
	public class AnimateLimbIK : ActorActionClip<Animator> // TypeDefIndex: 58453
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x4C
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x50
		public AvatarIKGoal IKGoal; // 0x54
		[AnimatableParameter(0f, 1f)]
		public float weight; // 0x58
		public TransformRefPositionRotation IKTarget; // 0x60
		private AnimatorDispatcher dispatcher; // 0x90
	
		// Properties
		[AnimatableParameter(link = "IKTarget")]
		[PositionHandle]
		[ShowTrajectory]
		public Vector3 targetPosition { get; set; } // 0x000000018AC7D244-0x000000018AC7D278 0x0000000184DA9C90-0x0000000184DA9CA0
		[AnimatableParameter(link = "IKTarget")]
		[RotationHandle("targetPosition")]
		public Vector3 targetRotation { get; set; } // 0x000000018AC7D278-0x000000018AC7D2AC 0x0000000184DA9D40-0x0000000184DA9D60
		public override string info { get; } // 0x000000018AC7D1D4-0x000000018AC7D244 
		public override float length { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override float blendIn { get; set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000184D91480-0x0000000184D91490
		public override float blendOut { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58452
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x000000018AC87854-0x000000018AC878B8
			public __c(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public AnimateLimbIK(); // 0x000000018AC7D188-0x000000018AC7D1D4
	
		// Methods
		protected override void OnCreate(); // 0x000000018AC7CDBC-0x000000018AC7CDF8
		protected override void OnAfterValidate(); // 0x000000018AC7C9AC-0x000000018AC7CBF8
		protected override void OnEnter(); // 0x000000018AC7CDF8-0x000000018AC7CEF0
		protected override void OnReverseEnter(); // 0x000000018AC7CF84-0x000000018AC7D07C
		protected override void OnReverse(); // 0x000000018AC7D07C-0x000000018AC7D110
		protected override void OnExit(); // 0x000000018AC7CEF0-0x000000018AC7CF84
		protected override void OnRootDisabled(); // 0x000000018AC7D110-0x000000018AC7D188
		private void OnAnimatorIK(int index); // 0x000000018AC7CBF8-0x000000018AC7CDBC
	}

	[Attachable(new System.Type[1] {typeof(ActorActionTrack) })]
	[Category("Animator IK Control")]
	[Description("Make the actor look at target position. Please note that the Animator needs to have a Controller assigned and \'IK Pass\' must be enabled in that Controller.")]
	public class AnimateLookAtIK : ActorActionClip<Animator> // TypeDefIndex: 58455
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		[HideInInspector]
		[SerializeField]
		private float _blendIn; // 0x4C
		[HideInInspector]
		[SerializeField]
		private float _blendOut; // 0x50
		[AnimatableParameter(0f, 1f)]
		public float weight; // 0x54
		[AnimatableParameter(0f, 1f)]
		public float bodyWeight; // 0x58
		[AnimatableParameter(0f, 1f)]
		public float headWeight; // 0x5C
		[AnimatableParameter(0f, 1f)]
		public float eyesWeight; // 0x60
		public TransformRefPosition targetPosition; // 0x68
		private AnimatorDispatcher dispatcher; // 0x88
	
		// Properties
		[AnimatableParameter(link = "targetPosition")]
		[PositionHandle]
		[ShowTrajectory]
		public Vector3 targetPositionVector { get; set; } // 0x000000018AC7D9C8-0x000000018AC7D9FC 0x0000000184DA9D60-0x0000000184DA9D80
		public override string info { get; } // 0x000000018AC7D99C-0x000000018AC7D9C8 
		public override float length { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override float blendIn { get; set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000184D91480-0x0000000184D91490
		public override float blendOut { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58454
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x000000018AC877F0-0x000000018AC87854
			public __c(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public AnimateLookAtIK(); // 0x000000018AC7D944-0x000000018AC7D99C
	
		// Methods
		protected override void OnCreate(); // 0x000000018AC7D574-0x000000018AC7D5B4
		protected override void OnAfterValidate(); // 0x000000018AC7D2AC-0x000000018AC7D430
		protected override void OnEnter(); // 0x000000018AC7D5B4-0x000000018AC7D6AC
		protected override void OnReverseEnter(); // 0x000000018AC7D740-0x000000018AC7D838
		protected override void OnReverse(); // 0x000000018AC7D838-0x000000018AC7D8CC
		protected override void OnExit(); // 0x000000018AC7D6AC-0x000000018AC7D740
		protected override void OnRootDisabled(); // 0x000000018AC7D8CC-0x000000018AC7D944
		private void OnAnimatorIK(int index); // 0x000000018AC7D430-0x000000018AC7D574
	}

	public class AnimateTrigger : MecanimBaseClip // TypeDefIndex: 58456
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		public string triggerName; // 0x50
		[AnimatableParameter]
		public bool value; // 0x58
	
		// Properties
		public override bool isValid { get; } // 0x000000018AC7C048-0x000000018AC7C078 
		public override string info { get; } // 0x000000018AC7E194-0x000000018AC7E1D4 
		public override float length { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
	
		// Constructors
		public AnimateTrigger(); // 0x000000018AC7E184-0x000000018AC7E194
	
		// Methods
		protected override void OnUpdate(float time); // 0x000000018AC7E10C-0x000000018AC7E184
	}

	[Description("CrossFades to an Animator state within a period of time.")]
	public class CrossFadeState : MecanimBaseClip // TypeDefIndex: 58457
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		[Required]
		public string stateName; // 0x50
	
		// Properties
		public override string info { get; } // 0x000000018AC7EA7C-0x000000018AC7EABC 
		public override float length { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public override float blendIn { get; } // 0x000000018AC7EA6C-0x000000018AC7EA7C 
	
		// Constructors
		public CrossFadeState(); // 0x000000018AC7E184-0x000000018AC7E194
	
		// Methods
		protected override void OnEnter(); // 0x000000018AC7E9D8-0x000000018AC7EA6C
	}

	[Attachable(new System.Type[1] {typeof(MecanimTrack) })]
	public abstract class MecanimBaseClip : ActorActionClip<Animator> // TypeDefIndex: 58459
	{
		// Properties
		public override bool isValid { get; } // 0x000000018AC80CE4-0x000000018AC80D98 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 58458
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _HasParameter_b__0(AnimatorControllerParameter p); // 0x0000000186CC7538-0x0000000186CC7560
		}
	
		// Constructors
		protected MecanimBaseClip(); // 0x000000018AC80CA4-0x000000018AC80CE4
	
		// Methods
		protected bool HasParameter(string name); // 0x000000018AC809F8-0x000000018AC80CA4
	}
}
