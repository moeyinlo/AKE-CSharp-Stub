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

// Image 35: Slate.dll - Assembly: Slate, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 84705-84977

namespace Slate
{
	public class DirectorCamera : MonoBehaviour, IDirectableCamera // TypeDefIndex: 84706
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
		public const float MAX_DAMP = 3f; // Metadata: 0x02644688
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
		public static DirectorCamera current { get; } // 0x000000018CE54B30-0x000000018CE54D14 
		public Camera cam { get; } // 0x000000018CE54A00-0x000000018CE54B30 
		public Vector3 position { get; set; } // 0x000000018CE54E44-0x000000018CE54E98 0x000000018CE552AC-0x000000018CE55300
		public Quaternion rotation { get; set; } // 0x000000018CE54EBC-0x000000018CE54F08 0x000000018CE55300-0x000000018CE5534C
		public float fieldOfView { get; set; } // 0x000000018CE54D34-0x000000018CE54D94 0x000000018CE5516C-0x000000018CE551D4
		public float focalDistance { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872332C0-0x00000001872332D0 0x00000001872332D0-0x00000001872332E0
		public float focalLength { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187236710-0x0000000187236720 0x0000000187236720-0x0000000187236730
		public float focalAperture { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233430-0x0000000187233440 0x0000000187233440-0x0000000187233450
		public static bool matchMainWhenActive { get; set; } // 0x000000018CE54E24-0x000000018CE54E44 0x000000018CE55288-0x000000018CE552AC
		public static bool setMainWhenActive { get; set; } // 0x000000018CE54F08-0x000000018CE54F28 0x000000018CE5534C-0x000000018CE55370
		public static bool autoHandleActiveState { get; set; } // 0x000000018CE549E0-0x000000018CE54A00 0x000000018CE55124-0x000000018CE55148
		public static bool ignoreFOVChanges { get; set; } // 0x000000018CE54DCC-0x000000018CE54DEC 0x000000018CE55228-0x000000018CE5524C
		public static bool dontDestroyOnLoad { get; set; } // 0x000000018CE54D14-0x000000018CE54D34 0x000000018CE55148-0x000000018CE5516C
		public static Camera renderCamera { get; } // 0x000000018CE54E98-0x000000018CE54EBC 
		public static GameCamera gameCamera { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018CE54D94-0x000000018CE54DCC 0x000000018CE551D4-0x000000018CE55228
		public static bool isEnabled { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018CE54DEC-0x000000018CE54E24 0x000000018CE5524C-0x000000018CE55288
		GameObject IDirectableCamera.gameObject { get; } // 0x0000000187834B68-0x0000000187834B70 
	
		// Events
		public static event Action<IDirectableCamera> onCut {
			add; // 0x000000018CE54894-0x000000018CE54930
			remove; // 0x000000018CE54FD8-0x000000018CE55074
		}
		public static event Action onActivate {
			add; // 0x000000018CE547E4-0x000000018CE54894
			remove; // 0x000000018CE54F28-0x000000018CE54FD8
		}
		public static event Action onDeactivate {
			add; // 0x000000018CE54930-0x000000018CE549E0
			remove; // 0x000000018CE55074-0x000000018CE55124
		}
	
		// Constructors
		public DirectorCamera(); // 0x000000018721F1F0-0x000000018721F210
	
		// Methods
		private void Awake(); // 0x000000018CE538E0-0x000000018CE53A04
		private Camera CreateRenderCamera(); // 0x000000018CE53A04-0x000000018CE53B9C
		public static void Enable(); // 0x000000018CE53CC4-0x000000018CE540E4
		public static void Disable(); // 0x000000018CE53B9C-0x000000018CE53CC4
		public static void Update(IDirectableCamera source, IDirectableCamera target, Slate.EaseType interpolation, float weight, float damping = 0f /* Metadata: 0x02644684 */); // 0x000000018CE540E4-0x000000018CE547E4
		public static void ApplyNoise(float magnitude, float weight); // 0x000000018CE534F4-0x000000018CE538E0
	}

	[ExecuteInEditMode]
	public class DirectorGUI : MonoBehaviour // TypeDefIndex: 84713
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
		public static DirectorGUI current { get; } // 0x000000018CE55E34-0x000000018CE55FC0 
		public static UnityEngine.Color lastFadeColor { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018CE55FC0-0x000000018CE56004 0x000000018CE5657C-0x000000018CE565BC
	
		// Events
		public static event SubtitlesGUIDelegate OnSubtitlesGUI {
			add; // 0x000000018CE55CDC-0x000000018CE55D84
			remove; // 0x000000018CE56424-0x000000018CE564CC
		}
		public static event TextOverlayGUIDelegate OnTextOverlayGUI {
			add; // 0x000000018CE55D84-0x000000018CE55E34
			remove; // 0x000000018CE564CC-0x000000018CE5657C
		}
		public static event ImageOverlayGUIDelegate OnImageOverlayGUI {
			add; // 0x000000018CE55ACC-0x000000018CE55B7C
			remove; // 0x000000018CE56214-0x000000018CE562C4
		}
		public static event ScreenFadeGUIDelegate OnScreenFadeGUI {
			add; // 0x000000018CE55C2C-0x000000018CE55CDC
			remove; // 0x000000018CE56374-0x000000018CE56424
		}
		public static event LetterboxGUIDelegate OnLetterboxGUI {
			add; // 0x000000018CE55B7C-0x000000018CE55C2C
			remove; // 0x000000018CE562C4-0x000000018CE56374
		}
		public static event CameraDissolveDelegate OnCameraDissolve {
			add; // 0x000000018CE558BC-0x000000018CE5596C
			remove; // 0x000000018CE56004-0x000000018CE560B4
		}
		public static event Action OnGUIEnable {
			add; // 0x000000018CE55A1C-0x000000018CE55ACC
			remove; // 0x000000018CE56164-0x000000018CE56214
		}
		public static event Action OnGUIDisable {
			add; // 0x000000018CE5596C-0x000000018CE55A1C
			remove; // 0x000000018CE560B4-0x000000018CE56164
		}
	
		// Nested types
		public delegate void SubtitlesGUIDelegate(string text, UnityEngine.Color color); // TypeDefIndex: 84707; 0x00000001857E4CE0-0x00000001857E4D10
	
		public delegate void TextOverlayGUIDelegate(string text, UnityEngine.Color color, float size, TextAnchor alignment, Vector2 position); // TypeDefIndex: 84708; 0x000000018CE58C98-0x000000018CE58CE0
	
		public delegate void ImageOverlayGUIDelegate(Texture texture, UnityEngine.Color color, Vector2 scale, Vector2 position); // TypeDefIndex: 84709; 0x000000018CE57614-0x000000018CE5764C
	
		public delegate void ScreenFadeGUIDelegate(UnityEngine.Color color); // TypeDefIndex: 84710; 0x0000000186A4F2D0-0x0000000186A4F300
	
		public delegate void LetterboxGUIDelegate(float completion); // TypeDefIndex: 84711; 0x0000000185B78EA0-0x0000000185B78EB0
	
		public delegate void CameraDissolveDelegate(Texture texture, float completion); // TypeDefIndex: 84712; 0x00000001859B7730-0x00000001859B7740
	
		// Constructors
		public DirectorGUI(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void Awake(); // 0x000000018CE55370-0x000000018CE55450
		private void OnEnable(); // 0x000000018CE5556C-0x000000018CE555B0
		private void OnDisable(); // 0x000000018CE55450-0x000000018CE5556C
		public static void UpdateLetterbox(float completion); // 0x000000018CE556A8-0x000000018CE55704
		public static void UpdateDissolve(Texture texture, float completion); // 0x000000018CE555B0-0x000000018CE55618
		public static void UpdateFade(UnityEngine.Color color); // 0x000000018CE55618-0x000000018CE556A8
		public static void UpdateSubtitles(string text, UnityEngine.Color color); // 0x000000018CE5584C-0x000000018CE558BC
		public static void UpdateOverlayText(string text, UnityEngine.Color color, float size, TextAnchor anchor, Vector2 pos); // 0x000000018CE557A4-0x000000018CE5584C
		public static void UpdateOverlayImage(Texture texture, UnityEngine.Color color, Vector2 scale, Vector2 positionOffset); // 0x000000018CE55704-0x000000018CE557A4
	}

	[Serializable]
	public class DynamicCameraController // TypeDefIndex: 84719
	{
		// Fields
		private const float MIN_DAMP = 0.5f; // Metadata: 0x0264468C
		private const float MAX_DAMP = 10f; // Metadata: 0x02644690
		[SerializeField]
		private Transposer _transposer; // 0x10
		[SerializeField]
		private Composer _composer; // 0x18
		private int lastUpdateFrame; // 0x20
	
		// Properties
		public Transposer transposer { get; } // 0x00000001829260F0-0x0000000182926100 
		public Composer composer { get; } // 0x0000000182234E30-0x0000000182234E40 
		public bool controlsPosition { get; } // 0x000000018CE573A8-0x000000018CE573C0 
		public bool controlsRotation { get; } // 0x000000018CE573C0-0x000000018CE573D8 
		public bool controlsFieldOfView { get; } // 0x000000018CE5738C-0x000000018CE573A8 
	
		// Nested types
		[Serializable]
		public class Transposer // TypeDefIndex: 84716
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
			public enum TrackingMode // TypeDefIndex: 84714
			{
				None = 0,
				OffsetTracking = 1,
				RailTracking = 2
			}
	
			public enum OffsetMode // TypeDefIndex: 84715
			{
				LocalSpace = 0,
				WorldSpace = 1
			}
	
			// Constructors
			public Transposer(); // 0x0000000187257CE0-0x0000000187257D40
		}
	
		[Serializable]
		public class Composer // TypeDefIndex: 84718
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
			public enum TrackingMode // TypeDefIndex: 84717
			{
				None = 0,
				FrameComposition = 1
			}
	
			// Constructors
			public Composer(); // 0x0000000187257C50-0x0000000187257C70
		}
	
		// Constructors
		public DynamicCameraController(); // 0x000000018CE572DC-0x000000018CE5738C
	
		// Methods
		public void UpdateControllerHard(IDirectableCamera directableCamera, IDirectable directable); // 0x000000018CE56658-0x000000018CE56674
		public void UpdateControllerSoft(IDirectableCamera directableCamera, IDirectable directable); // 0x000000018CE56674-0x000000018CE56690
		private void UpdateController(IDirectableCamera directableCamera, IDirectable directable, bool isHard); // 0x000000018CE56690-0x000000018CE572DC
	}

	public class GameCamera : MonoBehaviour, IDirectableCamera // TypeDefIndex: 84720
	{
		// Fields
		private Camera _cam; // 0x18
	
		// Properties
		public Camera cam { get; } // 0x000000018CE573D8-0x000000018CE57464 
		public Vector3 position { get; set; } // 0x000000018CE574C4-0x000000018CE5750C 0x0000000186805BA0-0x0000000186805BB0
		public Quaternion rotation { get; set; } // 0x000000018CE5750C-0x000000018CE57550 0x0000000186805BA0-0x0000000186805BB0
		public float fieldOfView { get; set; } // 0x000000018CE57464-0x000000018CE574C4 0x0000000186805BA0-0x0000000186805BB0
		public float focalDistance { get; set; } // 0x0000000187257CC0-0x0000000187257CD0 0x0000000186805BA0-0x0000000186805BB0
		public float focalLength { get; set; } // 0x0000000187257CD0-0x0000000187257CE0 0x0000000186805BA0-0x0000000186805BB0
		public float focalAperture { get; set; } // 0x0000000187257CB0-0x0000000187257CC0 0x0000000186805BA0-0x0000000186805BB0
		GameObject IDirectableCamera.gameObject { get; } // 0x0000000187834B68-0x0000000187834B70 
	
		// Constructors
		public GameCamera(); // 0x00000001878364A0-0x00000001878364B8
	}

	public interface IDirectableCamera // TypeDefIndex: 84721
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
	public class ShotCamera : MonoBehaviour, IDirectableCamera // TypeDefIndex: 84723
	{
		// Fields
		public const string DEFAULT_NAME = "Shot Camera"; // Metadata: 0x0264469B
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
		public Camera cam { get; } // 0x000000018CE58714-0x000000018CE587A0 
		public Vector3 position { get; set; } // 0x000000018CE574C4-0x000000018CE5750C 0x000000018CE58A14-0x000000018CE58A58
		public Quaternion rotation { get; set; } // 0x000000018CE5750C-0x000000018CE57550 0x0000000188DECFD4-0x0000000188DED010
		public Vector3 localPosition { get; set; } // 0x000000018CE588BC-0x000000018CE58904 0x000000018CE589D0-0x000000018CE58A14
		public Vector3 localEulerAngles { get; set; } // 0x000000018CE58848-0x000000018CE588BC 0x000000018CE5895C-0x000000018CE589D0
		public float fieldOfView { get; set; } // 0x000000018CE587E8-0x000000018CE58848 0x000000018CE58904-0x000000018CE5895C
		public float focalDistance { get; set; } // 0x00000001872332C0-0x00000001872332D0 0x00000001872332D0-0x00000001872332E0
		public float focalLength { get; set; } // 0x0000000187236710-0x0000000187236720 0x0000000187236720-0x0000000187236730
		public float focalAperture { get; set; } // 0x0000000187233430-0x0000000187233440 0x0000000187233440-0x0000000187233450
		public DynamicCameraController dynamicController { get; } // 0x0000000182234E30-0x0000000182234E40 
		public bool dynamicControlledPosition { get; } // 0x000000018CE587B8-0x000000018CE587D0 
		public bool dynamicControlledRotation { get; } // 0x000000018CE587D0-0x000000018CE587E8 
		public bool dynamicControlledFieldOfView { get; } // 0x000000018CE587A0-0x000000018CE587B8 
		GameObject IDirectableCamera.gameObject { get; } // 0x0000000187834B68-0x0000000187834B70 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass47_0 // TypeDefIndex: 84722
		{
			// Fields
			public string shotName; // 0x10
	
			// Constructors
			public __c__DisplayClass47_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _Find_b__0(ShotCamera s); // 0x000000018CE58F64-0x000000018CE58F9C
		}
	
		// Constructors
		public ShotCamera(); // 0x000000018CE58690-0x000000018CE58714
	
		// Methods
		private void Awake(); // 0x000000018CE5802C-0x000000018CE58120
		public void UpdateDynamicControllerHard(IDirectable directable); // 0x000000018CE58640-0x000000018CE58668
		public void UpdateDynamicControllerSoft(IDirectable directable); // 0x000000018CE58668-0x000000018CE58690
		public void SetDynamicControllerTargets(Transform target); // 0x000000018CE58634-0x000000018CE58640
		public void SetDynamicControllerTargets(Transform transposerTarget, Transform composerTarget); // 0x000000018CE585E0-0x000000018CE58634
		public RenderTexture GetRenderTexture(int width, int height); // 0x000000018CE58438-0x000000018CE585E0
		public static ShotCamera Create(Transform targetParent = null); // 0x000000018CE58120-0x000000018CE58340
		public static ShotCamera Find(string shotName); // 0x000000018CE58340-0x000000018CE58438
	}

	[Serializable]
	public class BlendShape // TypeDefIndex: 84724
	{
		// Fields
		[SerializeField]
		private SkinnedMeshRenderer _skin; // 0x10
		[SerializeField]
		private string _name; // 0x18
		[SerializeField]
		private float _weight; // 0x20
	
		// Properties
		public SkinnedMeshRenderer skin { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public string name { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public float weight { get; set; } // 0x00000001872332C0-0x00000001872332D0 0x00000001872332D0-0x00000001872332E0
	
		// Constructors
		public BlendShape(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void SetRealWeight(float modWeight); // 0x000000018CE4C33C-0x000000018CE4C408
		public override string ToString(); // 0x0000000182234E30-0x0000000182234E40
	}

	[Serializable]
	public class BlendShapeGroup // TypeDefIndex: 84725
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
		public string UID { get; private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public string name { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public float weight { get; set; } // 0x00000001872332C0-0x00000001872332D0 0x000000018CE4C330-0x000000018CE4C33C
		public List<BlendShape> blendShapes { get; } // 0x0000000182262130-0x0000000182262140 
	
		// Constructors
		public BlendShapeGroup(); // 0x000000018CE4C24C-0x000000018CE4C330
	
		// Methods
		private void SetBlendWeights(); // 0x000000018CE4C1CC-0x000000018CE4C24C
		public override string ToString(); // 0x0000000182234E30-0x0000000182234E40
	}

	[AddComponentMenu("SLATE/Character")]
	public class Character : MonoBehaviour // TypeDefIndex: 84728
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
		public Transform neck { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public Transform head { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public Vector3 upVector { get; set; } // 0x0000000187235E20-0x0000000187235E40 0x0000000187235E60-0x0000000187235E70
		public Vector3 rotationOffset { get; set; } // 0x0000000187235E00-0x0000000187235E20 0x0000000187235E50-0x0000000187235E60
		public List<BlendShapeGroup> expressions { get; } // 0x0000000182234E30-0x0000000182234E40 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 84726
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass19_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _FindExpressionByName_b__0(BlendShapeGroup x); // 0x000000018CE58EAC-0x000000018CE58EC8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 84727
		{
			// Fields
			public string UID; // 0x10
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _FindExpressionByUID_b__0(BlendShapeGroup x); // 0x000000018CE58EC8-0x000000018CE58EE4
		}
	
		// Constructors
		public Character(); // 0x000000018CE4E5B4-0x000000018CE4E660
	
		// Methods
		public BlendShapeGroup FindExpressionByName(string name); // 0x000000018CE4E32C-0x000000018CE4E3FC
		public BlendShapeGroup FindExpressionByUID(string UID); // 0x000000018CE4E3FC-0x000000018CE4E4CC
		public void SetExpressionWeightByName(string name, float weight); // 0x000000018CE4E54C-0x000000018CE4E580
		public void SetExpressionWeightByUID(string UID, float weight); // 0x000000018CE4E580-0x000000018CE4E5B4
		public void ResetExpressions(); // 0x000000018CE4E4CC-0x000000018CE4E54C
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class NameAttribute : Attribute // TypeDefIndex: 84729
	{
		// Fields
		public readonly string name; // 0x10
	
		// Constructors
		public NameAttribute(string name); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class CategoryAttribute : Attribute // TypeDefIndex: 84730
	{
		// Fields
		public readonly string category; // 0x10
	
		// Constructors
		public CategoryAttribute(string category); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class DescriptionAttribute : Attribute // TypeDefIndex: 84731
	{
		// Fields
		public readonly string description; // 0x10
	
		// Constructors
		public DescriptionAttribute(string description); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class IconAttribute : Attribute // TypeDefIndex: 84732
	{
		// Fields
		public readonly string iconName; // 0x10
		public readonly System.Type fromType; // 0x18
	
		// Constructors
		public IconAttribute(string iconName); // 0x0000000184FD2410-0x0000000184FD2420
		public IconAttribute(System.Type fromType); // 0x0000000187835500-0x0000000187835510
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class AttachableAttribute : Attribute // TypeDefIndex: 84733
	{
		// Fields
		public readonly System.Type[] types; // 0x10
	
		// Constructors
		public AttachableAttribute(params System.Type[] types); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class UniqueElementAttribute : Attribute // TypeDefIndex: 84734
	{
		// Constructors
		public UniqueElementAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class ShowTrajectoryAttribute : Attribute // TypeDefIndex: 84735
	{
		// Constructors
		public ShowTrajectoryAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class PositionHandleAttribute : Attribute // TypeDefIndex: 84736
	{
		// Constructors
		public PositionHandleAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class RotationHandleAttribute : Attribute // TypeDefIndex: 84737
	{
		// Fields
		public readonly string positionPropertyName; // 0x10
	
		// Constructors
		public RotationHandleAttribute(string positionPropertyName); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class AnimatableParameterAttribute : PropertyAttribute // TypeDefIndex: 84738
	{
		// Fields
		public string link; // 0x10
		public readonly float? min; // 0x18
		public readonly float? max; // 0x20
		public readonly string customName; // 0x28
	
		// Constructors
		public AnimatableParameterAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
		public AnimatableParameterAttribute(string customName); // 0x0000000185CA30F0-0x0000000185CA3100
		public AnimatableParameterAttribute(string customName, float min, float max); // 0x000000018CE42D18-0x000000018CE42DB0
		public AnimatableParameterAttribute(float min, float max); // 0x000000018CE42DB0-0x000000018CE42E30
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class ParseAnimatableParametersAttribute : PropertyAttribute // TypeDefIndex: 84739
	{
		// Constructors
		public ParseAnimatableParametersAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ShaderPropertyPopupAttribute : PropertyAttribute // TypeDefIndex: 84740
	{
		// Fields
		public readonly System.Type propertyType; // 0x10
	
		// Constructors
		public ShaderPropertyPopupAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
		public ShaderPropertyPopupAttribute(System.Type propertyType); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class LeftToggleAttribute : PropertyAttribute // TypeDefIndex: 84741
	{
		// Constructors
		public LeftToggleAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class MinAttribute : PropertyAttribute // TypeDefIndex: 84742
	{
		// Fields
		public readonly float min; // 0x10
	
		// Constructors
		public MinAttribute(float min); // 0x0000000187235230-0x0000000187235240
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ExampleTextAttribute : PropertyAttribute // TypeDefIndex: 84743
	{
		// Fields
		public readonly string text; // 0x10
	
		// Constructors
		public ExampleTextAttribute(string text); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class HelpBoxAttribute : PropertyAttribute // TypeDefIndex: 84744
	{
		// Fields
		public readonly string text; // 0x10
	
		// Constructors
		public HelpBoxAttribute(string text); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ShowIfAttribute : PropertyAttribute // TypeDefIndex: 84745
	{
		// Fields
		public readonly string propertyName; // 0x10
		public readonly int value; // 0x18
	
		// Constructors
		public ShowIfAttribute(string propertyName, int value); // 0x00000001856B50C0-0x00000001856B50E0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class EnabledIfAttribute : PropertyAttribute // TypeDefIndex: 84746
	{
		// Fields
		public readonly string propertyName; // 0x10
		public readonly int value; // 0x18
	
		// Constructors
		public EnabledIfAttribute(string propertyName, int value); // 0x00000001856B50C0-0x00000001856B50E0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class CallbackAttribute : PropertyAttribute // TypeDefIndex: 84747
	{
		// Fields
		public readonly string methodName; // 0x10
	
		// Constructors
		public CallbackAttribute(string methodName); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class RequiredAttribute : PropertyAttribute // TypeDefIndex: 84748
	{
		// Constructors
		public RequiredAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class PlaybackProtectedAttribute : PropertyAttribute // TypeDefIndex: 84749
	{
		// Constructors
		public PlaybackProtectedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ReadOnlyAttribute : PropertyAttribute // TypeDefIndex: 84750
	{
		// Constructors
		public ReadOnlyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class SortingLayerAttribute : PropertyAttribute // TypeDefIndex: 84751
	{
		// Constructors
		public SortingLayerAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ActorGroupPopupAttribute : PropertyAttribute // TypeDefIndex: 84752
	{
		// Constructors
		public ActorGroupPopupAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Attachable(new System.Type[1] {typeof(DirectorActionTrack) })]
	public abstract class DirectorActionClip : ActionClip // TypeDefIndex: 84753
	{
		// Constructors
		protected DirectorActionClip(); // 0x00000001878364A0-0x00000001878364B8
	}

	public interface IEvent // TypeDefIndex: 84754
	{
		// Properties
		string name { get; }
	
		// Methods
		void Invoke();
	}

	public enum TransformSpace // TypeDefIndex: 84755
	{
		CutsceneSpace = 0,
		ActorSpace = 1,
		WorldSpace = 2,
		ParentSpace = 3
	}

	public enum MiniTransformSpace // TypeDefIndex: 84756
	{
		CutsceneSpace = 0,
		WorldSpace = 2,
		ParentSpace = 3
	}

	public enum ActiveState // TypeDefIndex: 84757
	{
		Disable = 0,
		Enable = 1,
		Toggle = 2
	}

	[Attachable(new System.Type[1] {typeof(CameraTrack) })]
	[Description("Camera Shots can be animated directly within this clip. You don\'t need to create an Actor Group to animate the shot (even though you can if desired).")]
	public class CameraShot : DirectorActionClip // TypeDefIndex: 84761
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
		public override string info { get; } // 0x000000018CE4D2D0-0x000000018CE4D350 
		public override bool isValid { get; } // 0x000000018CE4D350-0x000000018CE4D3A0 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override bool canCrossBlend { get; } // 0x000000018CE4D104-0x000000018CE4D10C 
		public new GameObject actor { get; } // 0x000000018CE4D090-0x000000018CE4D104 
		public CameraShot previousShot { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232F60-0x0000000187232F70 0x0000000188800C88-0x0000000188800C9C
		public ShotCamera targetShot { get; set; } // 0x000000018226EBD0-0x000000018226EBE0 0x000000018CE4D830-0x000000018CE4D8AC
		private CameraTrack track { get; } // 0x000000018CE4D4D0-0x000000018CE4D50C 
		[AnimatableParameter]
		public Vector3 position { get; set; } // 0x000000018CE4D3A0-0x000000018CE4D438 0x000000018CE4D710-0x000000018CE4D7A0
		[AnimatableParameter]
		public Vector3 rotation { get; set; } // 0x000000018CE4D438-0x000000018CE4D4D0 0x000000018CE4D7A0-0x000000018CE4D830
		[AnimatableParameter(0.01f, 170f)]
		public float fieldOfView { get; set; } // 0x000000018CE4D10C-0x000000018CE4D180 0x000000018CE4D50C-0x000000018CE4D5A8
		[AnimatableParameter("Focal Distance")]
		public float focalPoint { get; set; } // 0x000000018CE4D1F0-0x000000018CE4D260 0x000000018CE4D620-0x000000018CE4D698
		[AnimatableParameter("Focal Length", 1f, 300f)]
		public float focalRange { get; set; } // 0x000000018CE4D260-0x000000018CE4D2D0 0x000000018CE4D698-0x000000018CE4D710
		[AnimatableParameter(0.1f, 32f)]
		public float focalAperture { get; set; } // 0x000000018CE4D180-0x000000018CE4D1F0 0x000000018CE4D5A8-0x000000018CE4D620
	
		// Nested types
		public enum BlendInEffectType // TypeDefIndex: 84758
		{
			None = 0,
			FadeFromColor = 1,
			CrossDissolve = 2,
			EaseIn = 3
		}
	
		public enum BlendOutEffectType // TypeDefIndex: 84759
		{
			None = 0,
			FadeToColor = 1
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 84760
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x000000018CE59000-0x000000018CE59064
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public CameraShot(); // 0x000000018CE4D040-0x000000018CE4D090
	
		// Methods
		protected override void OnAfterValidate(); // 0x000000018CE4C5A8-0x000000018CE4C98C
		protected override void OnRootEnabled(); // 0x000000018CE4CB7C-0x000000018CE4CC08
		protected override void OnRootDisabled(); // 0x000000018CE4CAF0-0x000000018CE4CB7C
		protected override void OnRootUpdated(float time, float previousTime); // 0x000000018CE4CC08-0x000000018CE4CC94
		public void TryUpdateShotTargetOverride(); // 0x000000018CE4CF6C-0x000000018CE4D040
		protected override bool OnInitialize(); // 0x000000018CE4CA78-0x000000018CE4CA8C
		protected override void OnEnter(); // 0x000000018CE4C98C-0x000000018CE4CA78
		protected override void OnUpdate(float time, float previousTime); // 0x000000018CE4CC94-0x000000018CE4CF6C
		protected override void OnReverse(); // 0x000000018CE4CA8C-0x000000018CE4CAF0
	}

	[Attachable(new System.Type[1] {typeof(VideoTrack) })]
	[Description("Play an imported Video Clip on the render camera.")]
	[Name("Video Clip")]
	public class PlayVideo : ActionClip // TypeDefIndex: 84762
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
		public override bool isValid { get; } // 0x000000018CE57C50-0x000000018CE57CA0 
		public override string info { get; } // 0x000000018CE57BD0-0x000000018CE57C50 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		private VideoTrack track { get; } // 0x000000018CE57CA0-0x000000018CE57CDC 
	
		// Constructors
		public PlayVideo(); // 0x000000018CE57BA4-0x000000018CE57BD0
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE57A90-0x000000018CE57A98
		protected override void OnReverseEnter(); // 0x000000018CE57A90-0x000000018CE57A98
		protected override void OnReverse(); // 0x000000018CE57A98-0x000000018CE57AA0
		protected override void OnExit(); // 0x000000018CE57A98-0x000000018CE57AA0
		private void Enable(); // 0x000000018CE57A18-0x000000018CE57A90
		protected override void OnUpdate(float time, float previousTime); // 0x000000018CE57AA0-0x000000018CE57BA4
		private void Disable(); // 0x000000018CE579EC-0x000000018CE57A18
	}

	[Description("All tracks of an Actor Group affect a specific actor GameObject or one of it\'s Components. Specifying a name manually comes in handy if you want to set the target actor of this group via scripting. The ReferenceMode along with InitialCoordinates are essential when you are working with prefab actors.")]
	public class ActorGroup : CutsceneGroup // TypeDefIndex: 84763
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
		public override string name { get; set; } // 0x000000018CE429F8-0x000000018CE42A90 0x0000000188800CD0-0x0000000188800CE0
		public override GameObject actor { get; set; } // 0x000000018CE429EC-0x000000018CE429F8 0x000000018CE42A90-0x000000018CE42B00
		public override ActorReferenceMode referenceMode { get; set; } // 0x0000000187233080-0x0000000187233090 0x00000001872330F0-0x0000000187233100
		public override ActorInitialTransformation initialTransformation { get; set; } // 0x000000018723DA60-0x000000018723DA70 0x000000018723DA70-0x000000018723DA80
		public override Vector3 initialLocalPosition { get; set; } // 0x0000000187257B90-0x0000000187257BB0 0x0000000187257BD0-0x0000000187257BF0
		public override Vector3 initialLocalRotation { get; set; } // 0x0000000187257BB0-0x0000000187257BD0 0x0000000187257BF0-0x0000000187257C10
		public override bool displayVirtualMeshGizmo { get; set; } // 0x0000000182271B00-0x0000000182271B10 0x0000000182271B10-0x0000000182271B20
	
		// Constructors
		public ActorGroup(); // 0x000000018CE4299C-0x000000018CE429EC
	}

	[Description("The DirectorGroup is the master group of the Cutscene. There is always one and can\'t be removed. The target actor of this group is always the \'Director Camera\', thus it\'s possible to add a PropertiesTrack to animate any of the components attached on the DirectorCamera game object. Usualy Image Effects.")]
	public class DirectorGroup : CutsceneGroup // TypeDefIndex: 84764
	{
		// Properties
		public override string name { get; set; } // 0x000000018CE5662C-0x000000018CE56658 0x0000000186805BA0-0x0000000186805BB0
		public override GameObject actor { get; set; } // 0x000000018CE56608-0x000000018CE5662C 0x0000000186805BA0-0x0000000186805BB0
		public override ActorReferenceMode referenceMode { get; set; } // 0x0000000185829EC0-0x0000000185829ED0 0x0000000186805BA0-0x0000000186805BB0
		public override ActorInitialTransformation initialTransformation { get; set; } // 0x0000000185829EC0-0x0000000185829ED0 0x0000000186805BA0-0x0000000186805BB0
		public override Vector3 initialLocalPosition { get; set; } // 0x000000018C1DC668-0x000000018C1DC680 0x0000000186805BA0-0x0000000186805BB0
		public override Vector3 initialLocalRotation { get; set; } // 0x000000018C1DC668-0x000000018C1DC680 0x0000000186805BA0-0x0000000186805BB0
		public override bool displayVirtualMeshGizmo { get; set; } // 0x00000001843FFFF0-0x0000000184400000 0x0000000186805BA0-0x0000000186805BB0
	
		// Constructors
		public DirectorGroup(); // 0x000000018CE565BC-0x000000018CE56608
	}

	[Description("Action Tracks are generic purpose tracks. Once an Action Clip has been placed, the Action Track will lock to accept only clips of the same category.")]
	[Icon(typeof(CircleCollider2D))]
	[Name("Action Track")]
	public abstract class ActionTrack : CutsceneTrack // TypeDefIndex: 84765
	{
		// Constructors
		protected ActionTrack(); // 0x000000018CE4297C-0x000000018CE42984
	}

	[Attachable(new System.Type[1] {typeof(ActorGroup) })]
	public class ActorActionTrack : ActionTrack // TypeDefIndex: 84766
	{
		// Constructors
		public ActorActionTrack(); // 0x000000018CE4297C-0x000000018CE42984
	}

	[Attachable(new System.Type[1] {typeof(ActorGroup) })]
	public class ActorAudioTrack : Slate.AudioTrack // TypeDefIndex: 84767
	{
		// Fields
		[SerializeField]
		protected bool _useAudioSourceOnActor; // 0x90
	
		// Properties
		public override bool useAudioSourceOnActor { get; } // 0x000000018226EDA0-0x000000018226EDB0 
	
		// Constructors
		public ActorAudioTrack(); // 0x000000018CE42984-0x000000018CE4299C
	}

	[Attachable(new System.Type[1] {typeof(ActorGroup) })]
	public class ActorPropertiesTrack : PropertiesTrack // TypeDefIndex: 84768
	{
		// Constructors
		public ActorPropertiesTrack(); // 0x000000018CE42BF4-0x000000018CE42BFC
	
		// Methods
		protected override void OnCreate(); // 0x000000018CE42B00-0x000000018CE42BF4
	}

	[Attachable(new System.Type[1] {typeof(ActorGroup) })]
	[Category("Legacy")]
	[Description("The Animation Track works with the legacy \'Animation\' Component. Each Animation Track represents a different layer of the animation system. The zero layered track (bottom) will blend in/out with the default animation clip set on the Animation Component of the actor if any, while all other Animation Tracks will play above.")]
	[Icon(typeof(NavMeshAgent))]
	public class AnimationTrack : CutsceneTrack // TypeDefIndex: 84769
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
		public override string info { get; } // 0x000000018CE49C58-0x000000018CE49D58 
		public override float blendIn { get; } // 0x0000000187233590-0x00000001872335A0 
		public override float blendOut { get; } // 0x00000001872353B0-0x00000001872353C0 
		public float weight { get; } // 0x000000018226EE90-0x000000018226EEA0 
		public AnimationBlendMode animationBlendMode { get; private set; } // 0x0000000187233600-0x0000000187233610 0x0000000187233630-0x0000000187233640
		public string mixTransformName { get; private set; } // 0x0000000187232FA0-0x0000000187232FB0 0x0000000188800CB0-0x0000000188800CC0
	
		// Constructors
		public AnimationTrack(); // 0x000000018CE49BF4-0x000000018CE49C58
	
		// Methods
		protected override bool OnInitialize(); // 0x000000018CE49A00-0x000000018CE49ADC
		protected override void OnEnter(); // 0x000000018CE497E8-0x000000018CE499C0
		protected override void OnUpdate(float time, float previousTime); // 0x000000018CE49B1C-0x000000018CE49BBC
		protected override void OnExit(); // 0x000000018CE499C0-0x000000018CE49A00
		protected override void OnReverseEnter(); // 0x000000018CE49ADC-0x000000018CE49B1C
		protected override void OnReverse(); // 0x000000018CE499C0-0x000000018CE49A00
		public Transform GetMixTransform(); // 0x000000018CE49668-0x000000018CE497E8
		[CompilerGenerated]
		private bool _GetMixTransform_b__27_0(Transform t); // 0x000000018CE49BBC-0x000000018CE49BF4
	}

	[Attachable(new System.Type[1] {typeof(ActorGroup) })]
	[Description("The Animator Track works with an \'Animator\' Component attached on the actor, but does not require or use the Controller assigned. Instead animation clips can be played directly.\n\nMultiple Animator Tracks can also be added each representing a different animation layer. Root Motion will only be used in Animator Track of Layer 0 (if enabled), which is always the first (bottom) Track.")]
	[Icon(typeof(Animator))]
	public class AnimatorTrack : CutsceneTrack // TypeDefIndex: 84771
	{
		// Fields
		private const int ROOTMOTION_FRAMERATE = 30; // Metadata: 0x026446B7
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
		public Animator animator { get; } // 0x000000018CE4BAF0-0x000000018CE4BBE4 
		public override string info { get; } // 0x000000018CE4BBFC-0x000000018CE4BD30 
		public override bool isLocked { get; } // 0x000000018CE4BD78-0x000000018CE4BDA8 
		public AnimatorTrack masterTrack { get; } // 0x000000018CE4BDB0-0x000000018CE4BDFC 
		public bool isMasterTrack { get; } // 0x000000018CE4BDA8-0x000000018CE4BDB0 
		public bool isLastTrack { get; } // 0x000000018CE4BD30-0x000000018CE4BD78 
		public float compoundTrackWeight { get; } // 0x000000018CE4BBE4-0x000000018CE4BBFC 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 84770
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<AnimatorTrack, bool> __9__36_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CE59064-0x000000018CE590C8
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _OnInitialize_b__36_0(AnimatorTrack t); // 0x000000018CE58DA0-0x000000018CE58DC0
		}
	
		// Constructors
		public AnimatorTrack(); // 0x000000018CE4BADC-0x000000018CE4BAF0
	
		// Methods
		protected override bool OnInitialize(); // 0x000000018CE4B2A4-0x000000018CE4B4B4
		protected override void OnEnter(); // 0x000000018CE4B104-0x000000018CE4B264
		protected override void OnUpdate(float time, float previousTime); // 0x000000018CE4B5E0-0x000000018CE4B6E0
		private void PostUpdateMasterTrack(float time, float previousTime); // 0x000000018CE4B798-0x000000018CE4B980
		protected override void OnReverseEnter(); // 0x000000018CE4B4B4-0x000000018CE4B554
		protected override void OnExit(); // 0x000000018CE4B264-0x000000018CE4B2A4
		private void PostExitMasterTrack(); // 0x000000018CE4B6E0-0x000000018CE4B798
		protected override void OnReverse(); // 0x000000018CE4B554-0x000000018CE4B5E0
		public void EnableClip(PlayAnimatorClip playAnimClip, float blendWeight, float subClipWeight); // 0x000000018CE4ACE8-0x000000018CE4ADA4
		public void UpdateClip(PlayAnimatorClip playAnimClip, float clipTime, float clipPrevious, float blendWeight, float subClipWeight); // 0x000000018CE4B9D0-0x000000018CE4BADC
		public void DisableClip(PlayAnimatorClip playAnimClip, float blendWeight, float subClipWeight); // 0x000000018CE4AC40-0x000000018CE4ACE8
		private void CreateAndPlayTree(); // 0x000000018CE4A5B8-0x000000018CE4A968
		private Playable CreateClipsMixer(PlayableGraph graph); // 0x000000018CE4A968-0x000000018CE4AC40
		public void PreBakeRootMotion(); // 0x000000018CE4B980-0x000000018CE4B9D0
		public void ClearPreBakeRootMotion(); // 0x000000018CE4A4F4-0x000000018CE4A5B8
		private void BakeRootMotion(); // 0x000000018CE4A02C-0x000000018CE4A4F4
		private void EvaluateTrackClips(float time, float previousTime, ref int tempActiveClips); // 0x000000018CE4ADA4-0x000000018CE4B104
		private void ApplyBakedRootMotion(float time); // 0x000000018CE49D58-0x000000018CE4A02C
	}

	[Attachable(new System.Type[1] {typeof(ActorGroup) })]
	[Category("Legacy")]
	[Description("** This Track is deprecated. Please use Animator Track instead. **\n\nThe Mecanim Track works with an \'Animator\' component attached on the actor and with it\'s assigned Controller by modifying the Controller\'s parameters.\n\nConsider working with the new Animator Track instead to playback animation clips directly without the need of a Controller, which is more intuitive for animations.")]
	[Icon(typeof(Animator))]
	public class MecanimTrack : CutsceneTrack // TypeDefIndex: 84772
	{
		// Fields
		private Animator animator; // 0x50
	
		// Constructors
		public MecanimTrack(); // 0x000000018CE4297C-0x000000018CE42984
	
		// Methods
		protected override bool OnInitialize(); // 0x000000018CE57880-0x000000018CE579EC
		protected override void OnReverse(); // 0x000000018CE57878-0x000000018CE57880
		protected override void OnExit(); // 0x000000018CE57878-0x000000018CE57880
		private void DestroyDispatcher(); // 0x000000018CE577E4-0x000000018CE57878
	}

	[Description("All audio clips played by this track will be send to the selected AudioMixer if any.")]
	[Icon(typeof(AudioClip))]
	[Name("Audio Track")]
	public abstract class AudioTrack : CutsceneTrack // TypeDefIndex: 84773
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
		public override string info { get; } // 0x000000018CE4C0FC-0x000000018CE4C1CC 
		public AudioSource source { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232FC0-0x0000000187232FD0 0x0000000188800CD0-0x0000000188800CE0
		public AudioSampler.SampleSettings sampleSettings { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187257C10-0x0000000187257C30 0x0000000187257C30-0x0000000187257C50
		public AudioMixerGroup mixer { get; } // 0x000000018226EBD0-0x000000018226EBE0 
		public virtual bool useAudioSourceOnActor { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		protected AudioTrack(); // 0x000000018CE42984-0x000000018CE4299C
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE4BF3C-0x000000018CE4BF44
		protected override void OnReverseEnter(); // 0x000000018CE4BF3C-0x000000018CE4BF44
		protected override void OnUpdate(float time, float previousTime); // 0x000000018CE4BF4C-0x000000018CE4C050
		protected override void OnExit(); // 0x000000018CE4BF44-0x000000018CE4BF4C
		protected override void OnReverse(); // 0x000000018CE4BF44-0x000000018CE4BF4C
		private void Enable(); // 0x000000018CE4BE60-0x000000018CE4BF3C
		private void Disable(); // 0x000000018CE4BDFC-0x000000018CE4BE60
		private void SetAndApplySettings(); // 0x000000018CE4C050-0x000000018CE4C0F0
		public void SetVolume(float volume); // 0x000000018CE4C0F0-0x000000018CE4C0FC
	}

	[Attachable(new System.Type[1] {typeof(DirectorGroup) })]
	[Description("The Camera Track is the track within wich you create your camera shots and moves. Once the Camera Track becomes active, the Director Camera will be enabled. You can control when the Director Camera takes effect by setting the \'Active Time Offset\', while the Blend In/Out parameters control the ammount of blending there will be from the game camera to the first and the last shot of the track.\nIf you don\'t want a cinematic letterbox effect, you can set CineBox Fade Time to 0.\nIf you don\'t want to use Slate Camera features, you can simply disable or delete this track.")]
	[Icon(typeof(Camera))]
	[UniqueElement]
	public class CameraTrack : CutsceneTrack // TypeDefIndex: 84774
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
		public CameraShot firstShot { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001828D49D0-0x00000001828D49E0 0x00000001870EAAE0-0x00000001870EAAF0
		public CameraShot lastShot { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232F50-0x0000000187232F60 0x0000000188800C74-0x0000000188800C88
		public CameraShot currentShot { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271B70-0x0000000182271B80 0x0000000188800C9C-0x0000000188800CB0
		public override string info { get; } // 0x000000018CE4E200-0x000000018CE4E264 
		public override float startTime { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018CE4E2D8-0x000000018CE4E32C
		public override float endTime { get; set; } // 0x000000018CE4E1D4-0x000000018CE4E200 0x000000018CE4E264-0x000000018CE4E2D8
		public override float blendIn { get; set; } // 0x000000018CE4E080-0x000000018CE4E128 0x00000001872353E0-0x00000001872353F0
		public override float blendOut { get; set; } // 0x000000018CE4E128-0x000000018CE4E1D4 0x00000001826DD0C0-0x00000001826DD0D0
	
		// Constructors
		public CameraTrack(); // 0x000000018CE4E068-0x000000018CE4E080
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE4D8AC-0x000000018CE4DAC8
		protected override void OnUpdate(float time, float previousTime); // 0x000000018CE4DCA4-0x000000018CE4DFE4
		protected override void OnExit(); // 0x000000018CE4DAC8-0x000000018CE4DB68
		protected override void OnReverseEnter(); // 0x000000018CE4DB68-0x000000018CE4DC04
		protected override void OnReverse(); // 0x000000018CE4DC04-0x000000018CE4DCA4
		[CompilerGenerated]
		private bool _OnEnter_b__36_0(ActionClip s); // 0x000000018CE4DFE4-0x000000018CE4E020
		[CompilerGenerated]
		private bool _OnEnter_b__36_1(ActionClip s); // 0x000000018CE4E020-0x000000018CE4E068
	}

	[Attachable(new System.Type[1] {typeof(DirectorGroup) })]
	public class DirectorActionTrack : ActionTrack // TypeDefIndex: 84775
	{
		// Constructors
		public DirectorActionTrack(); // 0x000000018CE4297C-0x000000018CE42984
	}

	[Attachable(new System.Type[1] {typeof(DirectorGroup) })]
	public class DirectorAudioTrack : Slate.AudioTrack // TypeDefIndex: 84776
	{
		// Constructors
		public DirectorAudioTrack(); // 0x000000018CE42984-0x000000018CE4299C
	}

	[Attachable(new System.Type[1] {typeof(DirectorGroup) })]
	[Description("Use the Director Properties Track to animate any component property of the Director Camera. This is particularly useful to animate image effects rather than transforms, since transforms are handled by the CameraTrack and it\'s Shot Clips. You can still animate transforms if you are after a one-take, by having a CameraTrack without shot clips.")]
	public class DirectorPropertiesTrack : PropertiesTrack // TypeDefIndex: 84777
	{
		// Constructors
		public DirectorPropertiesTrack(); // 0x000000018CE42BF4-0x000000018CE42BFC
	}

	[Attachable(new System.Type[1] {typeof(DirectorGroup) })]
	[Description("Plays video clips on the render camera. Please note that scrubbing might be choppy, but playing is not.")]
	[Icon(typeof(VideoPlayer))]
	[UniqueElement]
	public class VideoTrack : CutsceneTrack // TypeDefIndex: 84778
	{
		// Fields
		public VideoSampler.VideoRenderTarget renderTarget; // 0x50
		public VideoAspectRatio aspectRatio; // 0x54
		[CompilerGenerated]
		private VideoPlayer _source_k__BackingField; // 0x58
	
		// Properties
		public VideoPlayer source { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232F70-0x0000000187232F80 0x00000001856B9750-0x00000001856B9760
		public override string info { get; } // 0x000000018CE59198-0x000000018CE59A34 
	
		// Constructors
		public VideoTrack(); // 0x000000018CE59188-0x000000018CE59198
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE59178-0x000000018CE59180
		protected override void OnReverseEnter(); // 0x000000018CE59178-0x000000018CE59180
		protected override void OnReverse(); // 0x000000018CE59180-0x000000018CE59188
		protected override void OnExit(); // 0x000000018CE59180-0x000000018CE59188
		private void Enable(); // 0x000000018CE59114-0x000000018CE59178
		private void Disable(); // 0x000000018CE590C8-0x000000018CE59114
	}

	[Category("Legacy")]
	[Description("With the Properties Track, you can select to animate any supported type property or field on any component on the actor, or within it\'s whole transform hierarchy.\n\nNote, that you can do exactly the same, by using the \'Animate Properties\' ActionClip added in an \'Action Track\'.")]
	[Name("Properties Track")]
	[UniqueElement]
	public abstract class PropertiesTrack : CutsceneTrack, IKeyable // TypeDefIndex: 84779
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private AnimationDataCollection _animationData; // 0x50
	
		// Properties
		public AnimationDataCollection animationData { get; } // 0x000000018226EBD0-0x000000018226EBE0 
		public object animatedParametersTarget { get; } // 0x000000018CE57E28-0x000000018CE57E30 
	
		// Constructors
		protected PropertiesTrack(); // 0x000000018CE57DD0-0x000000018CE57E28
	
		// Methods
		protected override void OnAfterValidate(); // 0x000000018CE57CDC-0x000000018CE57D04
		protected override void OnEnter(); // 0x000000018CE57D04-0x000000018CE57D58
		protected override void OnUpdate(float time, float previousTime); // 0x000000018CE57D78-0x000000018CE57DD0
		protected override void OnReverse(); // 0x000000018CE57D58-0x000000018CE57D78
	}

	[Attachable(new System.Type[1] {typeof(ActionTrack) })]
	public abstract class ActionClip : MonoBehaviour, IKeyable // TypeDefIndex: 84780
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
		public IDirector root { get; } // 0x000000018CE42664-0x000000018CE42684 
		public IDirectable parent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public GameObject actor { get; } // 0x000000018CE42350-0x000000018CE42370 
		IEnumerable<IDirectable> IDirectable.children { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public AnimationDataCollection animationData { get; private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public float startTime { get; set; } // 0x0000000187233050-0x0000000187233060 0x000000018CE42880-0x000000018CE4297C
		public float endTime { get; set; } // 0x000000018CE423A8-0x000000018CE423D4 0x000000018CE42764-0x000000018CE42880
		public bool isActive { get; } // 0x000000018CE42558-0x000000018CE42594 
		public bool isCollapsed { get; } // 0x000000018CE42594-0x000000018CE425B4 
		public bool isLocked { get; } // 0x000000018CE425B4-0x000000018CE425D4 
		public virtual float length { get; set; } // 0x0000000187234CD0-0x0000000187234CE0 0x0000000186805BA0-0x0000000186805BB0
		public virtual float blendIn { get; set; } // 0x0000000187234CD0-0x0000000187234CE0 0x0000000186805BA0-0x0000000186805BB0
		public virtual float blendOut { get; set; } // 0x0000000187234CD0-0x0000000187234CE0 0x0000000186805BA0-0x0000000186805BB0
		public virtual bool canCrossBlend { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public virtual string info { get; } // 0x000000018CE424B4-0x000000018CE42558 
		public virtual bool isValid { get; } // 0x000000018CE425F4-0x000000018CE42644 
		public virtual UnityEngine.Color color { get; } // 0x000000018CB1F4E8-0x000000018CB1F508 
		public virtual UnityEngine.Color textColor { get; } // 0x000000018CE42684-0x000000018CE426A4 
		public virtual int textSizeInner { get; } // 0x0000000187239CD0-0x0000000187239CE0 
		public virtual int textSizeOuter { get; } // 0x0000000187239CC0-0x0000000187239CD0 
		public virtual float interval { get; } // 0x0000000187234CD0-0x0000000187234CE0 
		public virtual string url { get; } // 0x000000018CE426A4-0x000000018CE42764 
		public virtual bool isHighlight { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001822434B0-0x00000001822434C0 0x00000001822434C0-0x00000001822434D0
		public bool isReadOnly { get; } // 0x000000018CE425D4-0x000000018CE425F4 
		public virtual TransformSpace defaultTransformSpace { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		private string[] animatedParameterPaths { get; } // 0x000000018CE42370-0x000000018CE423A8 
		private bool handleParametersRegistrationManually { get; } // 0x000000018CE423D4-0x000000018CE423F8 
		public virtual object animatedParametersTarget { get; } // 0x0000000185BD80B0-0x0000000185BD80C0 
		public virtual Slate.EaseType animatedParametersInterpolation { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public virtual bool useWeightInParameters { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public bool hasParameters { get; } // 0x000000018CE4249C-0x000000018CE424B4 
		public bool hasActiveParameters { get; } // 0x000000018CE423F8-0x000000018CE4249C 
		public virtual bool needActor { get; } // 0x000000018CE42644-0x000000018CE42664 
		public virtual bool canSample { get; } // 0x00000001851A4410-0x00000001851A4420 
		public virtual int updateOrder { get; } // 0x0000000187250FE0-0x0000000187250FF0 
		string IDirectable.name { get; } // 0x0000000187835674-0x000000018783567C 
	
		// Constructors
		protected ActionClip(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		bool IDirectable.Initialize(); // 0x000000018CE41CB0-0x000000018CE41CC0
		void IDirectable.Enter(); // 0x000000018CE41C7C-0x000000018CE41CA0
		void IDirectable.Update(float time, float previousTime); // 0x000000018CE41D40-0x000000018CE41D84
		void IDirectable.Exit(); // 0x000000018CE41CA0-0x000000018CE41CB0
		void IDirectable.ReverseEnter(); // 0x000000018CE41CC0-0x000000018CE41CD0
		void IDirectable.Reverse(); // 0x000000018CE41CD0-0x000000018CE41CF4
		void IDirectable.RootEnabled(); // 0x000000018CE41D0C-0x000000018CE41D24
		void IDirectable.RootDisabled(); // 0x000000018CE41CF4-0x000000018CE41D0C
		void IDirectable.RootUpdated(float time, float previousTime); // 0x000000018CE41D24-0x000000018CE41D40
		void IDirectable.RootDestroyed(); // 0x000000018722B770-0x000000018722B780
		public void PostCreate(IDirectable parent); // 0x000000018CE41B2C-0x000000018CE41B60
		public void Validate(); // 0x000000018CE422FC-0x000000018CE4230C
		public void Validate(IDirector root, IDirectable parent); // 0x000000018CE4230C-0x000000018CE42350
		protected virtual bool OnInitialize(); // 0x00000001851A4410-0x00000001851A4420
		protected virtual void OnEnter(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnUpdate(float time, float previousTime); // 0x000000018CE41B1C-0x000000018CE41B2C
		protected virtual void OnUpdate(float time); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnExit(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnReverse(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnReverseEnter(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnDrawGizmosSelected(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnSceneGUI(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnCreate(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnAfterValidate(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnRootEnabled(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnRootDisabled(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnRootUpdated(float time, float previousTime); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnRootDestroyed(); // 0x0000000186805BA0-0x0000000186805BB0
		public bool RootTimeWithinRange(); // 0x000000018CE41BAC-0x000000018CE41BB4
		public Vector3 TransformPosition(Vector3 point, TransformSpace space); // 0x000000018CE41D84-0x000000018CE41DD0
		public Vector3 InverseTransformPosition(Vector3 point, TransformSpace space); // 0x000000018CE41A8C-0x000000018CE41AD8
		public Quaternion TransformRotation(Vector3 euler, TransformSpace space); // 0x000000018CE41DD0-0x000000018CE41E14
		public Vector3 InverseTransformRotation(Quaternion rot, TransformSpace space); // 0x000000018CE41AD8-0x000000018CE41B1C
		public Vector3 ActorPositionInSpace(TransformSpace space); // 0x000000018CE41810-0x000000018CE41840
		public Transform GetSpaceTransform(TransformSpace space, GameObject actorOverride = null); // 0x000000018CE41A84-0x000000018CE41A8C
		public ActionClip GetPreviousClip(); // 0x000000018CE41A48-0x000000018CE41A84
		public ActionClip GetNextClip(); // 0x000000018CE419EC-0x000000018CE41A28
		public float GetClipWeight(); // 0x000000018CE41924-0x000000018CE41960
		public float GetClipWeight(float time); // 0x000000018CE4198C-0x000000018CE419EC
		public float GetClipWeight(float time, float blendInOut); // 0x000000018CE41960-0x000000018CE4197C
		public float GetClipWeight(float time, float blendIn, float blendOut); // 0x000000018CE4197C-0x000000018CE4198C
		public void TryMatchSubClipLength(); // 0x000000018CE41F50-0x000000018CE4200C
		public void TryMatchPreviousSubClipLoop(); // 0x000000018CE41EE8-0x000000018CE41F50
		public void TryMatchNexSubClipLoop(); // 0x000000018CE41E14-0x000000018CE41EE8
		private string GetParameterName<T, TResult>(Expression<Func<T, TResult>> func);
		public AnimatedParameter GetParameter<T, TResult>(Expression<Func<T, TResult>> func);
		public AnimatedParameter GetParameter(string paramName); // 0x000000018CE41A28-0x000000018CE41A48
		public void SetParameterEnabled<T, TResult>(Expression<Func<T, TResult>> func, bool enabled);
		public void SetParameterEnabled(string paramName, bool enabled); // 0x000000018CE41C14-0x000000018CE41C7C
		public void ResetAnimatedParameters(); // 0x000000018CE41B60-0x000000018CE41B74
		private void CreateAnimationDataCollection(); // 0x000000018CE41840-0x000000018CE41924
		private void ValidateAnimParams(); // 0x000000018CE420F0-0x000000018CE422FC
		private void SetAnimParamsSnapshot(); // 0x000000018CE41BB4-0x000000018CE41C14
		private void UpdateAnimParams(float time, float previousTime); // 0x000000018CE4200C-0x000000018CE420F0
		private void RestoreAnimParamsSnapshot(); // 0x000000018CE41B74-0x000000018CE41BAC
	}

	[Serializable]
	public class AnimatedParameter : IAnimatableData, ISerializationCallbackReceiver // TypeDefIndex: 84784
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
		public bool enabled { get; } // 0x000000018CC0F914-0x000000018CC0F91C 
		private string serializedData { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		private SerializationMetaData data { get; } // 0x000000018CE45158-0x000000018CE451C4 
		public IAnimatedParameterModel parameterModel { get; } // 0x000000018CE452BC-0x000000018CE453A8 
		public AnimationCurve[] curves { get; private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public string scriptExpression { get; set; } // 0x0000000182262130-0x0000000182262140 0x000000018CE4550C-0x000000018CE45544
		public bool hasActiveExpression { get; } // 0x000000018CE45204-0x000000018CE4521C 
		public string parameterName { get; } // 0x000000018CE453A8-0x000000018CE453C8 
		public System.Type animatedType { get; } // 0x000000018CE45138-0x000000018CE45158 
		public ParameterType parameterType { get; } // 0x000000018CE453C8-0x000000018CE453E8 
		public string transformHierarchyPath { get; } // 0x000000018CE45428-0x000000018CE45448 
		public System.Type declaringType { get; } // 0x000000018CE451C4-0x000000018CE451E4 
		public PropertyInfo property { get; } // 0x000000018CE453E8-0x000000018CE45408 
		public System.Reflection.FieldInfo field { get; } // 0x000000018CE451E4-0x000000018CE45204 
		public bool isProperty { get; } // 0x000000018CE45234-0x000000018CE4524C 
		public IKeyable keyable { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		private float[] snapshot { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
		private float[] lastEval { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		private Transform virtualTransformParent { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232F70-0x0000000187232F80 0x00000001856B9750-0x00000001856B9760
		public object targetObject { get; } // 0x000000018CE45408-0x000000018CE45428 
		public AnimatableParameterAttribute animatableAttribute { get; } // 0x000000018CE45060-0x000000018CE45138 
		public bool isExternal { get; } // 0x000000018CE4521C-0x000000018CE45234 
		public bool isValid { get; } // 0x000000018CE4524C-0x000000018CE452BC 
	
		// Events
		public static event Action<IAnimatableData> onParameterChanged {
			add; // 0x000000018CE44F9C-0x000000018CE45060
			remove; // 0x000000018CE45448-0x000000018CE4550C
		}
	
		// Nested types
		[Serializable]
		private class SerializationMetaData // TypeDefIndex: 84781
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
			public System.Type declaringType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
			public PropertyInfo property { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
			public System.Reflection.FieldInfo field { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
			public System.Type animatedType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
	
			// Constructors
			public SerializationMetaData(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Deserialize(); // 0x000000018CE57EB4-0x000000018CE5802C
		}
	
		public enum ParameterType // TypeDefIndex: 84782
		{
			NotSet = 0,
			Property = 1,
			Field = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass112_0 // TypeDefIndex: 84783
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass112_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _GetKeyLabel_b__0(AnimationCurve c); // 0x000000018CE58E00-0x000000018CE58E24
		}
	
		// Constructors
		static AnimatedParameter(); // 0x000000018CE44BCC-0x000000018CE44E48
		public AnimatedParameter(IKeyable keyable, System.Type type, string memberPath, string transformPath); // 0x000000018CE44E48-0x000000018CE44F9C
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018CE44B9C-0x000000018CE44BCC
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018CE44B60-0x000000018CE44B9C
		public void SetEnabled(bool value, float time); // 0x000000018CE4491C-0x000000018CE44988
		private void ConstructWithField(System.Reflection.FieldInfo targetField, System.Type type, string memberPath, string transformPath); // 0x000000018CE42F64-0x000000018CE43134
		private void ConstructWithProperty(PropertyInfo targetProperty, System.Type type, string memberPath, string transformPath); // 0x000000018CE43134-0x000000018CE43378
		public MemberInfo GetMemberInfo(); // 0x000000018CE43DEC-0x000000018CE43E30
		public AnimationCurve[] GetCurves(); // 0x000000018225E800-0x000000018225E810
		public bool CompareTo(AnimatedParameter other); // 0x000000018CE42E90-0x000000018CE42F64
		private void InitializeCurves(); // 0x000000018CE43EC8-0x000000018CE4401C
		public void Validate(IKeyable keyable); // 0x00000001870EAAD0-0x00000001870EAAE0
		public void SetVirtualTransformParent(Transform virtualTransformParent); // 0x00000001856B9750-0x00000001856B9760
		public void SetSnapshot(); // 0x000000018CE44A88-0x000000018CE44AF8
		public bool TryAutoKey(float time); // 0x000000018CE44B00-0x000000018CE44B60
		public void Evaluate(float time, float previousTime, float weight = 1f /* Metadata: 0x026446B8 */); // 0x000000018CE4347C-0x000000018CE43508
		private void Evaluate_1_Curves(float time, float previousTime, float weight = 1f /* Metadata: 0x026446BC */); // 0x000000018CE43378-0x000000018CE4347C
		private bool Evaluate_2_Expression(float time, float previousTime, float weight = 1f /* Metadata: 0x026446C0 */); // 0x00000001843FFFF0-0x0000000184400000
		public void RestoreSnapshot(); // 0x000000018CE4444C-0x000000018CE444B4
		public object GetEvalValue(float time); // 0x000000018CE43BCC-0x000000018CE43CB8
		public object ResolvedMemberObject(); // 0x000000018CE44218-0x000000018CE4444C
		public object GetCurrentValueAsObject(); // 0x000000018CE43B88-0x000000018CE43BCC
		private float[] GetCurrentValueAsFloats(); // 0x000000018CE43788-0x000000018CE43B88
		public void SetCurrentValue(object value); // 0x000000018CE444B4-0x000000018CE444FC
		private void SetCurrentValue(float[] floats); // 0x000000018CE444FC-0x000000018CE4491C
		public bool HasChanged(); // 0x000000018CE43E3C-0x000000018CE43EB8
		public bool HasAnyKey(); // 0x000000018CE43E30-0x000000018CE43E3C
		public bool HasKey(float time); // 0x000000018CE43EB8-0x000000018CE43EC8
		public float GetKeyNext(float time); // 0x000000018CE43DCC-0x000000018CE43DDC
		public float GetKeyPrevious(float time); // 0x000000018CE43DDC-0x000000018CE43DEC
		public bool TryKeyIdentity(float time); // 0x00000001843FFFF0-0x0000000184400000
		public void SetKeyCurrent(float time); // 0x0000000186805BA0-0x0000000186805BB0
		public void RemoveKey(float time); // 0x0000000186805BA0-0x0000000186805BB0
		public void SetPreWrapMode(UnityEngine.WrapMode mode); // 0x000000018CE44A08-0x000000018CE44A88
		public void SetPostWrapMode(UnityEngine.WrapMode mode); // 0x000000018CE44988-0x000000018CE44A08
		public void OffsetValue(object deltaValue); // 0x000000018CE44094-0x000000018CE44140
		public void Reset(); // 0x000000018CE44140-0x000000018CE44218
		public void ChangeMemberType(ParameterType newType); // 0x000000018CE42E30-0x000000018CE42E90
		public override string ToString(); // 0x000000018CE44AF8-0x000000018CE44B00
		public string FriendlyName(); // 0x000000018CE43508-0x000000018CE43788
		public string GetKeyLabel(float time); // 0x000000018CE43CB8-0x000000018CE43DCC
		private void RecordUndo(); // 0x0000000186805BA0-0x0000000186805BB0
		private void NotifyChange(); // 0x000000018CE4401C-0x000000018CE44094
	}

	public interface IAnimatedParameterModel // TypeDefIndex: 84785
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
	public struct Animated_Bool : IAnimatedParameterModel // TypeDefIndex: 84786
	{
		// Fields
		private Action<object, bool> setter; // 0x00
	
		// Methods
		public bool ForceStepMode(); // 0x00000001851A4410-0x00000001851A4420
		public int RequiredCurvesCount(); // 0x00000001872328C0-0x00000001872328D0
		public object ConvertToObject(params float[] floats); // 0x000000018CE455E0-0x000000018CE45644
		public float[] ConvertToFloats(object value); // 0x000000018CE45544-0x000000018CE455E0
		public string GetKeyLabel(params float[] floats); // 0x000000018CE45718-0x000000018CE4579C
		public void SetDirect(object target, MemberInfo info, params float[] floats); // 0x000000018CE4579C-0x000000018CE45860
		public float[] GetDirect(object target, MemberInfo info); // 0x000000018CE45644-0x000000018CE45718
	}

	[Decorator(typeof(int))]
	public struct Animated_Int : IAnimatedParameterModel // TypeDefIndex: 84787
	{
		// Fields
		private Action<object, int> setter; // 0x00
	
		// Methods
		public bool ForceStepMode(); // 0x00000001851A4410-0x00000001851A4420
		public int RequiredCurvesCount(); // 0x00000001872328C0-0x00000001872328D0
		public object ConvertToObject(params float[] floats); // 0x000000018CE46758-0x000000018CE467B4
		public float[] ConvertToFloats(object value); // 0x000000018CE466CC-0x000000018CE46758
		public string GetKeyLabel(params float[] floats); // 0x000000018CE46874-0x000000018CE468F0
		public void SetDirect(object target, MemberInfo info, params float[] floats); // 0x000000018CE468F0-0x000000018CE469A8
		public float[] GetDirect(object target, MemberInfo info); // 0x000000018CE467B4-0x000000018CE46874
	}

	[Decorator(typeof(float))]
	public struct Animated_Float : IAnimatedParameterModel // TypeDefIndex: 84788
	{
		// Fields
		private Action<object, float> setter; // 0x00
	
		// Methods
		public bool ForceStepMode(); // 0x00000001843FFFF0-0x0000000184400000
		public int RequiredCurvesCount(); // 0x00000001872328C0-0x00000001872328D0
		public object ConvertToObject(params float[] floats); // 0x000000018CE46478-0x000000018CE464D8
		public float[] ConvertToFloats(object value); // 0x000000018CE463F0-0x000000018CE46478
		public string GetKeyLabel(params float[] floats); // 0x000000018CE46598-0x000000018CE46614
		public void SetDirect(object target, MemberInfo info, params float[] floats); // 0x000000018CE46614-0x000000018CE466CC
		public float[] GetDirect(object target, MemberInfo info); // 0x000000018CE464D8-0x000000018CE46598
	}

	[Decorator(typeof(Vector2))]
	public struct Animated_Vector2 : IAnimatedParameterModel // TypeDefIndex: 84789
	{
		// Fields
		private Action<object, Vector2> setter; // 0x00
	
		// Methods
		public bool ForceStepMode(); // 0x00000001843FFFF0-0x0000000184400000
		public int RequiredCurvesCount(); // 0x00000001845AFFB0-0x00000001845AFFC0
		public object ConvertToObject(params float[] floats); // 0x000000018CE473EC-0x000000018CE47458
		public float[] ConvertToFloats(object value); // 0x000000018CE47350-0x000000018CE473EC
		public string GetKeyLabel(params float[] floats); // 0x000000018CE4752C-0x000000018CE475DC
		public void SetDirect(object target, MemberInfo info, params float[] floats); // 0x000000018CE475DC-0x000000018CE476A8
		public float[] GetDirect(object target, MemberInfo info); // 0x000000018CE47458-0x000000018CE4752C
	}

	[Decorator(typeof(Vector3))]
	public struct Animated_Vector3 : IAnimatedParameterModel // TypeDefIndex: 84790
	{
		// Fields
		private Action<object, Vector3> setter; // 0x00
	
		// Methods
		public bool ForceStepMode(); // 0x00000001843FFFF0-0x0000000184400000
		public int RequiredCurvesCount(); // 0x00000001872396E0-0x00000001872396F0
		public object ConvertToObject(params float[] floats); // 0x000000018CE47748-0x000000018CE477C8
		public float[] ConvertToFloats(object value); // 0x000000018CE476A8-0x000000018CE47748
		public string GetKeyLabel(params float[] floats); // 0x000000018CE478A0-0x000000018CE47988
		public void SetDirect(object target, MemberInfo info, params float[] floats); // 0x000000018CE47988-0x000000018CE47A68
		public float[] GetDirect(object target, MemberInfo info); // 0x000000018CE477C8-0x000000018CE478A0
	}

	[Decorator(typeof(UnityEngine.Color))]
	public struct Animated_Color : IAnimatedParameterModel // TypeDefIndex: 84791
	{
		// Fields
		private Action<object, UnityEngine.Color> setter; // 0x00
	
		// Methods
		public bool ForceStepMode(); // 0x00000001843FFFF0-0x0000000184400000
		public int RequiredCurvesCount(); // 0x00000001845BA780-0x00000001845BA790
		public object ConvertToObject(params float[] floats); // 0x000000018CE46018-0x000000018CE460B4
		public float[] ConvertToFloats(object value); // 0x000000018CE45F64-0x000000018CE46018
		public string GetKeyLabel(params float[] floats); // 0x000000018CE461A0-0x000000018CE462F0
		public void SetDirect(object target, MemberInfo info, params float[] floats); // 0x000000018CE462F0-0x000000018CE463F0
		public float[] GetDirect(object target, MemberInfo info); // 0x000000018CE460B4-0x000000018CE461A0
	}

	[Decorator(typeof(Vector4))]
	public struct Animated_Vector4 : IAnimatedParameterModel // TypeDefIndex: 84792
	{
		// Fields
		private Action<object, Vector4> setter; // 0x00
	
		// Methods
		public bool ForceStepMode(); // 0x00000001843FFFF0-0x0000000184400000
		public int RequiredCurvesCount(); // 0x00000001845BA780-0x00000001845BA790
		public object ConvertToObject(params float[] floats); // 0x000000018CE47B1C-0x000000018CE47BB8
		public float[] ConvertToFloats(object value); // 0x000000018CE47A68-0x000000018CE47B1C
		public string GetKeyLabel(params float[] floats); // 0x000000018CE47CA4-0x000000018CE47E3C
		public void SetDirect(object target, MemberInfo info, params float[] floats); // 0x000000018CE47E3C-0x000000018CE47F3C
		public float[] GetDirect(object target, MemberInfo info); // 0x000000018CE47BB8-0x000000018CE47CA4
	}

	[Decorator(typeof(Quaternion))]
	public struct Animated_Quaternion : IAnimatedParameterModel // TypeDefIndex: 84793
	{
		// Fields
		private Action<object, Quaternion> setter; // 0x00
	
		// Methods
		public bool ForceStepMode(); // 0x00000001843FFFF0-0x0000000184400000
		public int RequiredCurvesCount(); // 0x00000001845BA780-0x00000001845BA790
		public object ConvertToObject(params float[] floats); // 0x000000018CE46A5C-0x000000018CE46AF8
		public float[] ConvertToFloats(object value); // 0x000000018CE469A8-0x000000018CE46A5C
		public string GetKeyLabel(params float[] floats); // 0x000000018CE46BE4-0x000000018CE46D7C
		public void SetDirect(object target, MemberInfo info, params float[] floats); // 0x000000018CE46D7C-0x000000018CE46E7C
		public float[] GetDirect(object target, MemberInfo info); // 0x000000018CE46AF8-0x000000018CE46BE4
	}

	[Decorator(typeof(Rect))]
	public struct Animated_Rect : IAnimatedParameterModel // TypeDefIndex: 84794
	{
		// Fields
		private Action<object, Rect> setter; // 0x00
	
		// Methods
		public bool ForceStepMode(); // 0x00000001843FFFF0-0x0000000184400000
		public int RequiredCurvesCount(); // 0x00000001845BA780-0x00000001845BA790
		public object ConvertToObject(params float[] floats); // 0x000000018CE46F30-0x000000018CE46FCC
		public float[] ConvertToFloats(object value); // 0x000000018CE46E7C-0x000000018CE46F30
		public string GetKeyLabel(params float[] floats); // 0x000000018CE470B8-0x000000018CE47250
		public void SetDirect(object target, MemberInfo info, params float[] floats); // 0x000000018CE47250-0x000000018CE47350
		public float[] GetDirect(object target, MemberInfo info); // 0x000000018CE46FCC-0x000000018CE470B8
	}

	[Decorator(typeof(Bounds))]
	public struct Animated_Bounds : IAnimatedParameterModel // TypeDefIndex: 84795
	{
		// Fields
		private Action<object, Bounds> setter; // 0x00
	
		// Methods
		public bool ForceStepMode(); // 0x00000001843FFFF0-0x0000000184400000
		public int RequiredCurvesCount(); // 0x0000000187239C80-0x0000000187239C90
		public object ConvertToObject(params float[] floats); // 0x000000018CE45984-0x000000018CE45A84
		public float[] ConvertToFloats(object value); // 0x000000018CE45860-0x000000018CE45984
		public string GetKeyLabel(params float[] floats); // 0x000000018CE45BE4-0x000000018CE45DF8
		public void SetDirect(object target, MemberInfo info, params float[] floats); // 0x000000018CE45DF8-0x000000018CE45F64
		public float[] GetDirect(object target, MemberInfo info); // 0x000000018CE45A84-0x000000018CE45BE4
	}

	[Serializable]
	public class AnimationDataCollection : IAnimatableData // TypeDefIndex: 84803
	{
		// Fields
		[SerializeField]
		private List<AnimatedParameter> _animatedParameters; // 0x10
	
		// Properties
		public List<AnimatedParameter> animatedParameters { get; } // 0x00000001829260F0-0x0000000182926100 
		public bool isValid { get; } // 0x000000018CE49624-0x000000018CE49668 
		public AnimatedParameter this[int i] { get => default; } // 0x000000018CE495B4-0x000000018CE4961C 
		public AnimatedParameter this[string name] { get => default; } // 0x000000018CE4961C-0x000000018CE49624 
	
		// Nested types
		public delegate bool AddParameterDelegate(System.Type type, string memberPath, string transformPath); // TypeDefIndex: 84796; 0x00000001811DF7F0-0x00000001811DF810
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 84797
		{
			// Fields
			public AnimatedParameter newParam; // 0x10
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _TryAddParameter_b__0(AnimatedParameter p); // 0x000000018CE58E24-0x000000018CE58E4C
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 84798
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<AnimatedParameter, string> __9__14_0; // 0x08
			public static Func<AnimatedParameter, string> __9__14_1; // 0x10
			public static Func<float, float> __9__31_1; // 0x18
			public static Func<float, float> __9__32_1; // 0x20
	
			// Constructors
			static __c(); // 0x000000018CE58F9C-0x000000018CE59000
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _ReOrderParameters_b__14_0(AnimatedParameter p); // 0x000000018CE58DC0-0x000000018CE58DE0
			internal string _ReOrderParameters_b__14_1(AnimatedParameter p); // 0x000000018CE58DE0-0x000000018CE58E00
			internal float _GetKeyNext_b__31_1(float t); // 0x0000000187248B60-0x0000000187248B70
			internal float _GetKeyPrevious_b__32_1(float t); // 0x0000000187248B60-0x0000000187248B70
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 84799
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass15_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetParameterOfName_b__0(AnimatedParameter d); // 0x000000018CE58E4C-0x000000018CE58EAC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 84800
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass31_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _GetKeyNext_b__0(AnimatedParameter p); // 0x000000018CE58EE4-0x000000018CE58F08
			internal bool _GetKeyNext_b__2(float t); // 0x000000018CE58F08-0x000000018CE58F10
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0 // TypeDefIndex: 84801
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass32_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _GetKeyPrevious_b__0(AnimatedParameter p); // 0x000000018CE58F10-0x000000018CE58F34
			internal bool _GetKeyPrevious_b__2(float t); // 0x000000018CE58F34-0x000000018CE58F40
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 84802
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass33_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetKeyLabel_b__0(AnimatedParameter p); // 0x000000018CE58F40-0x000000018CE58F64
		}
	
		// Constructors
		public AnimationDataCollection(); // 0x0000000186805BA0-0x0000000186805BB0
		public AnimationDataCollection(IKeyable keyable, System.Type type, string[] memberPaths, string transformPath); // 0x000000018CE49520-0x000000018CE495B4
	
		// Methods
		public bool TryAddParameter(IKeyable keyable, System.Type type, string memberPath, string transformPath); // 0x000000018CE49114-0x000000018CE49354
		public void RemoveParameter(AnimatedParameter animParam); // 0x000000018CE48C64-0x000000018CE48CB8
		public void ReOrderParameters(); // 0x000000018CE489F8-0x000000018CE48BEC
		public AnimatedParameter GetParameterOfName(string name); // 0x000000018CE48618-0x000000018CE486F0
		public AnimationCurve[] GetCurves(); // 0x000000018CE48004-0x000000018CE48010
		public AnimationCurve[] GetCurvesAll(); // 0x000000018CE47FF8-0x000000018CE48004
		private AnimationCurve[] Internal_GetCurves(bool enabledParamsOnly); // 0x000000018CE488A4-0x000000018CE489F8
		public void Validate(IKeyable keyable); // 0x000000018CE4948C-0x000000018CE49520
		public void SetVirtualTransformParent(Transform virtualTransformParent); // 0x000000018CE48FDC-0x000000018CE49070
		public void SetSnapshot(); // 0x000000018CE48F58-0x000000018CE48FDC
		public bool TryAutoKey(float time); // 0x000000018CE49354-0x000000018CE49410
		public void Evaluate(float time, float previousTime, float weight = 1f /* Metadata: 0x026446C7 */); // 0x000000018CE47F3C-0x000000018CE47FF8
		public void RestoreSnapshot(); // 0x000000018CE48D3C-0x000000018CE48DC0
		public bool TryKeyIdentity(float time); // 0x000000018CE49410-0x000000018CE4948C
		public void RemoveKey(float time); // 0x000000018CE48BEC-0x000000018CE48C64
		public bool HasChanged(); // 0x000000018CE4877C-0x000000018CE48808
		public bool HasKey(float time); // 0x000000018CE48808-0x000000018CE488A4
		public bool HasAnyKey(); // 0x000000018CE486F0-0x000000018CE4877C
		public void SetKeyCurrent(float time); // 0x000000018CE48DC0-0x000000018CE48E38
		public float GetKeyNext(float time); // 0x000000018CE481C0-0x000000018CE483EC
		public float GetKeyPrevious(float time); // 0x000000018CE483EC-0x000000018CE48618
		public string GetKeyLabel(float time); // 0x000000018CE48010-0x000000018CE481C0
		public void SetPreWrapMode(UnityEngine.WrapMode mode); // 0x000000018CE48EC8-0x000000018CE48F58
		public void SetPostWrapMode(UnityEngine.WrapMode mode); // 0x000000018CE48E38-0x000000018CE48EC8
		public void Reset(); // 0x000000018CE48CB8-0x000000018CE48D3C
		public override string ToString(); // 0x000000018CE49070-0x000000018CE49114
	}

	[DisallowMultipleComponent]
	public class Cutscene : MonoBehaviour, IDirector // TypeDefIndex: 84813
	{
		// Fields
		public const float VERSION_NUMBER = 2.15f; // Metadata: 0x026446CE
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
		public Transform groupsRoot { get; } // 0x000000018CE52F0C-0x000000018CE53060 
		public UpdateMode updateMode { get; set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
		public WrapMode defaultWrapMode { get; set; } // 0x0000000182271A70-0x0000000182271A80 0x0000000182271AA0-0x0000000182271AB0
		public StopMode defaultStopMode { get; set; } // 0x00000001829600C0-0x00000001829600D0 0x0000000185E3C070-0x0000000185E3C080
		public bool playOnStart { get; set; } // 0x000000018225DFB0-0x000000018225DFC0 0x000000018225DFC0-0x000000018225DFD0
		public bool explicitActiveLayers { get; set; } // 0x000000018226EE60-0x000000018226EE70 0x000000018226EE70-0x000000018226EE80
		public LayerMask activeLayers { get; set; } // 0x0000000182271C40-0x0000000182271C50 0x0000000182271C60-0x0000000182271C70
		public DirectorGroup directorGroup { get; } // 0x000000018CE52D64-0x000000018CE52F0C 
		public ActorGroup actorGroup { get; } // 0x000000018CE52B00-0x000000018CE52C28 
		public virtual bool abortDirectorCamera { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public virtual bool multiSelectOverlapCheck { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public bool isBakingRootMotion { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187235FE0-0x0000000187235FF0 0x0000000187257CA0-0x0000000187257CB0
		public CameraTrack cameraTrack { get; } // 0x000000018CE52C28-0x000000018CE52D64 
		public float currentTime { get; set; } // 0x00000001826DD0B0-0x00000001826DD0C0 0x000000018CE533C4-0x000000018CE533E8
		public virtual float length { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018CE533E8-0x000000018CE533F8
		public float viewTimeMin { get; set; } // 0x0000000187233590-0x00000001872335A0 0x000000018CE534D0-0x000000018CE534F4
		public float viewTimeMax { get; set; } // 0x00000001872353B0-0x00000001872353C0 0x000000018CE53444-0x000000018CE534D0
		public float playTimeMin { get; set; } // 0x00000001872352B0-0x00000001872352C0 0x000000018CE53420-0x000000018CE53444
		public float playTimeMax { get; set; } // 0x00000001872352A0-0x00000001872352B0 0x000000018CE533F8-0x000000018CE53420
		public float playbackSpeed { get; set; } // 0x00000001872330B0-0x00000001872330C0 0x0000000187233110-0x0000000187233120
		public PlayingDirection playingDirection { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233660-0x0000000187233670 0x0000000187233680-0x0000000187233690
		public WrapMode playingWrapMode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872333B0-0x00000001872333C0 0x0000000185FD6920-0x0000000185FD6930
		public List<IDirectable> directables { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232C70-0x0000000187232C80 0x00000001887DE51C-0x00000001887DE530
		public bool isActive { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182271B00-0x0000000182271B10 0x0000000182271B10-0x0000000182271B20
		public bool isPaused { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187235000-0x0000000187235010 0x0000000187235010-0x0000000187235020
		public float previousTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723F320-0x000000018723F330 0x000000018723F330-0x000000018723F340
		bool IDirector.isReSampleFrame { get; } // 0x0000000187235FA0-0x0000000187235FB0 
		GameObject IDirector.context { get; } // 0x000000018CE51A64-0x000000018CE51AC0 
		IEnumerable<IDirectable> IDirector.children { get; } // 0x000000018CE51A28-0x000000018CE51A64 
		public float remainingTime { get; } // 0x000000018CE53060-0x000000018CE5308C 
	
		// Events
		public static event Action<Cutscene> OnCutsceneStarted {
			add; // 0x000000018CE527C8-0x000000018CE5288C
			remove; // 0x000000018CE5308C-0x000000018CE53150
		}
		public static event Action<Cutscene> OnCutsceneStopped {
			add; // 0x000000018CE5288C-0x000000018CE52954
			remove; // 0x000000018CE53150-0x000000018CE53218
		}
		public event Action<Section> OnSectionReached {
			add; // 0x000000018CE529E0-0x000000018CE52A6C
			remove; // 0x000000018CE532A4-0x000000018CE53330
		}
		public event Action<string, object> OnGlobalMessageSend {
			add; // 0x000000018CE52954-0x000000018CE529E0
			remove; // 0x000000018CE53218-0x000000018CE532A4
		}
		public event Action OnStop {
			add; // 0x000000018CE52A6C-0x000000018CE52B00
			remove; // 0x000000018CE53330-0x000000018CE533C4
		}
	
		// Nested types
		public enum WrapMode // TypeDefIndex: 84804
		{
			Once = 0,
			Loop = 1,
			PingPong = 2
		}
	
		public enum StopMode // TypeDefIndex: 84805
		{
			Skip = 0,
			Rewind = 1,
			Hold = 2,
			SkipRewindNoUndo = 3
		}
	
		public enum UpdateMode // TypeDefIndex: 84806
		{
			Normal = 0,
			AnimatePhysics = 1,
			UnscaledTime = 2,
			Manual = 3
		}
	
		public enum PlayingDirection // TypeDefIndex: 84807
		{
			Forwards = 0,
			Backwards = 1
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 84808
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
			static __c(); // 0x000000018CE6BC48-0x000000018CE6BCAC
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _get_directorGroup_b__62_0(CutsceneGroup g); // 0x000000018CE6B744-0x000000018CE6B784
			internal bool _get_actorGroup_b__64_0(CutsceneGroup g); // 0x000000018CE6B6C4-0x000000018CE6B704
			internal bool _get_cameraTrack_b__74_0(CutsceneTrack t); // 0x000000018CE6B704-0x000000018CE6B744
			internal GameObject _GetAffectedActors_b__135_0(ActorGroup g); // 0x000000018CE6B4E8-0x000000018CE6B508
			internal float _GetPointerTimes_b__136_0(IDirectableTimePointer t); // 0x000000018CE6B544-0x000000018CE6B560
			internal int _InitializeTimePointers_b__170_0(IDirectableTimePointer a, IDirectableTimePointer b); // 0x000000018CE6B560-0x000000018CE6B65C
			internal string _GetSectionNames_b__190_0(Section s); // 0x0000000188E4BE2C-0x0000000188E4BE44
			internal string _GetDefinedEventNames_b__191_0(IEvent d); // 0x000000018CE6B508-0x000000018CE6B544
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass177_0 // TypeDefIndex: 84809
		{
			// Fields
			public Action callback; // 0x10
			public Cutscene instance; // 0x18
	
			// Constructors
			public __c__DisplayClass177_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Play_b__0(); // 0x000000018CE6B8E0-0x000000018CE6B988
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass182_0 // TypeDefIndex: 84810
		{
			// Fields
			public string groupName; // 0x10
	
			// Constructors
			public __c__DisplayClass182_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _SetGroupActorOfName_b__0(ActorGroup g); // 0x000000018CE6B988-0x000000018CE6B9E4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass184_0 // TypeDefIndex: 84811
		{
			// Fields
			public string[] split; // 0x10
	
			// Constructors
			public __c__DisplayClass184_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _FindElement_b__0(CutsceneGroup g); // 0x000000018CE6B9E4-0x000000018CE6BA58
		}
	
		[CompilerGenerated]
		private sealed class _Internal_RenderCutscene_d__194 : IEnumerator<object> // TypeDefIndex: 84812
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Internal_RenderCutscene_d__194(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CE6B250-0x000000018CE6B49C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CE6B49C-0x000000018CE6B4E8
		}
	
		// Constructors
		public Cutscene(); // 0x000000018CE5272C-0x000000018CE527C8
		static Cutscene(); // 0x000000018CE52698-0x000000018CE5272C
	
		// Methods
		protected void Awake(); // 0x000000018CE4E660-0x000000018CE4E798
		protected void Start(); // 0x000000018CE51AC0-0x000000018CE51AD4
		protected void OnDestroy(); // 0x000000018CE50294-0x000000018CE50390
		public void ManualUpdate(float deltaTime); // 0x000000018CE50260-0x000000018CE50294
		protected void LateUpdate(); // 0x000000018CE501FC-0x000000018CE50260
		protected void FixedUpdate(); // 0x000000018CE4EC68-0x000000018CE4ECB0
		private void DirectorSectionReached(Section section); // 0x000000018CE4E7F0-0x000000018CE4E8C0
		public IEnumerable<GameObject> GetAffectedActors(); // 0x000000018CE4ECB0-0x000000018CE4EDD8
		public float[] GetPointerTimes(); // 0x000000018CE4EF1C-0x000000018CE4F050
		public void Play(); // 0x000000018CE50F5C-0x000000018CE50F68
		public void Play(Action callback); // 0x000000018CE50CC8-0x000000018CE50CD8
		public void Play(float startTime); // 0x000000018CE50CD8-0x000000018CE50D00
		public void Play(float startTime, Action callback); // 0x000000018CE50AC0-0x000000018CE50AE8
		public void Play(float startTime, float endTime, WrapMode wrapMode = WrapMode.Once /* Metadata: 0x026446CB */, Action callback = null, PlayingDirection playDirection = PlayingDirection.Forwards /* Metadata: 0x026446CC */); // 0x000000018CE50D00-0x000000018CE50F5C
		public void Stop(); // 0x000000018CE51CA8-0x000000018CE51CB4
		public void Stop(StopMode stopMode); // 0x000000018CE51B78-0x000000018CE51CA8
		public void PlayReverse(); // 0x000000018CE508B0-0x000000018CE508C0
		public void PlayReverse(float startTime, float endTime); // 0x000000018CE508C0-0x000000018CE508E8
		public void Pause(); // 0x0000000187257C80-0x0000000187257C90
		public void Resume(); // 0x0000000187257C90-0x0000000187257CA0
		public void SkipAll(); // 0x000000018CE51968-0x000000018CE51994
		public void Rewind(); // 0x000000018CE512C8-0x000000018CE512F8
		public void RewindNoUndo(); // 0x000000018CE51284-0x000000018CE512C8
		public void BreakCutsceneLoop(); // 0x0000000187257C70-0x0000000187257C80
		public void BreakSectionLoop(bool alsoSkip = false /* Metadata: 0x026446CD */); // 0x000000018CE4E798-0x000000018CE4E7F0
		[Obsolete("Use \'SkipCurrentSection\' instead")]
		public void Skip(); // 0x000000018CE51A20-0x000000018CE51A28
		public void SkipCurrentSection(); // 0x000000018CE51994-0x000000018CE51A20
		public bool JumpToSection(string name); // 0x000000018CE501D8-0x000000018CE501FC
		public bool JumpToSection(Section section); // 0x000000018CE50150-0x000000018CE501D8
		public bool PlayFromSection(string name); // 0x000000018CE50768-0x000000018CE50788
		public bool PlayFromSection(string name, WrapMode wrap, Action callback = null); // 0x000000018CE507A8-0x000000018CE507F4
		public bool PlayFromSection(Section section); // 0x000000018CE50788-0x000000018CE507A8
		public bool PlayFromSection(Section section, WrapMode wrap, Action callback = null); // 0x000000018CE507F4-0x000000018CE508B0
		public bool PlaySection(string name); // 0x000000018CE50A40-0x000000018CE50A74
		public bool PlaySection(string name, WrapMode wrap, Action callback = null); // 0x000000018CE509D4-0x000000018CE50A20
		public bool PlaySection(Section section); // 0x000000018CE50A20-0x000000018CE50A40
		public bool PlaySection(Section section, WrapMode wrap, Action callback = null); // 0x000000018CE508E8-0x000000018CE509D4
		public void Sample(); // 0x000000018CE512F8-0x000000018CE51308
		public void Sample(float time); // 0x000000018CE51308-0x000000018CE51418
		private void Internal_SamplePointers(float currentTime, float previousTime); // 0x000000018CE4FD5C-0x000000018CE50150
		public void ReSample(); // 0x000000018CE50F88-0x000000018CE50FF8
		public void Validate(); // 0x000000018CE51E9C-0x000000018CE52698
		private void InitializeTimePointers(); // 0x000000018CE4F2C0-0x000000018CE4FCBC
		private void OnSampleStarted(); // 0x000000018CE50550-0x000000018CE50768
		private void OnSampleEnded(); // 0x000000018CE50390-0x000000018CE50550
		private void SetLayersActive(); // 0x000000018CE51808-0x000000018CE51968
		private void RestoreLayersActive(); // 0x000000018CE510F4-0x000000018CE51284
		private void UpdateCutscene(float delta); // 0x000000018CE51CFC-0x000000018CE51E9C
		public static Cutscene Play(string name); // 0x000000018CE50A74-0x000000018CE50AC0
		public static Cutscene Play(string name, Action callback); // 0x000000018CE50AE8-0x000000018CE50CC8
		public static Cutscene FindFromResources(string name); // 0x000000018CE4EA50-0x000000018CE4EB98
		public static Cutscene Find(string name); // 0x000000018CE4EB98-0x000000018CE4EC68
		public static void StopAllCutscenes(); // 0x000000018CE51AD4-0x000000018CE51B78
		public void SendGlobalMessage(string message, object value = null); // 0x000000018CE51418-0x000000018CE51624
		public void SetGroupActorOfName(string groupName, GameObject newActor); // 0x000000018CE51624-0x000000018CE51808
		public T FindElement<T>(string path)
			where T : IDirectable;
		public IDirectable FindElement(string path); // 0x000000018CE4E8C0-0x000000018CE4EA50
		public override string ToString(); // 0x000000018CE51CB4-0x000000018CE51CFC
		public Section GetSectionByName(string name); // 0x000000018CE4F050-0x000000018CE4F080
		public Section GetSectionByUID(string UID); // 0x000000018CE4F080-0x000000018CE4F0B0
		public Section[] GetSections(); // 0x000000018CE4F26C-0x000000018CE4F2C0
		public float GetSectionLength(string name); // 0x000000018CE4F0B0-0x000000018CE4F134
		public string[] GetSectionNames(); // 0x000000018CE4F134-0x000000018CE4F26C
		public string[] GetDefinedEventNames(); // 0x000000018CE4EDD8-0x000000018CE4EF1C
		public void PreInitialize(); // 0x000000018CE50F68-0x000000018CE50F88
		public void RenderCutscene(int width, int height, int frameRate, Action<Texture2D[]> callback); // 0x000000018CE50FF8-0x000000018CE510F4
		[IteratorStateMachine(typeof(_Internal_RenderCutscene_d__194))]
		private IEnumerator Internal_RenderCutscene(int width, int height, int frameRate, Action<Texture2D[]> callback); // 0x000000018CE4FCBC-0x000000018CE4FD5C
	}

	public abstract class CutsceneGroup : MonoBehaviour, IDirectable // TypeDefIndex: 84822
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
		public virtual bool needActor { get; } // 0x00000001851A4410-0x00000001851A4420 
		public virtual int updateOrder { get; } // 0x0000000187250FE0-0x0000000187250FF0 
		public bool customToggleValid { get; } // 0x000000018CE5FCA0-0x000000018CE5FD08 
		public List<CutsceneTrack> tracks { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public List<Section> sections { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		IEnumerable<IDirectable> IDirectable.children { get; } // 0x000000018CE5EC60-0x000000018CE5EC9C 
		float IDirectable.startTime { get; } // 0x0000000187234CD0-0x0000000187234CE0 
		float IDirectable.endTime { get; } // 0x000000018CE5EC9C-0x000000018CE5ECB8 
		float IDirectable.blendIn { get; } // 0x0000000187234CD0-0x0000000187234CE0 
		float IDirectable.blendOut { get; } // 0x0000000187234CD0-0x0000000187234CE0 
		bool IDirectable.canCrossBlend { get; } // 0x00000001843FFFF0-0x0000000184400000 
		IDirectable IDirectable.parent { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public IDirector root { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232F80-0x0000000187232F90 0x0000000186B19440-0x0000000186B19450
		public bool isActive { get; set; } // 0x0000000182260CA0-0x0000000182260CB0 0x000000018CE5FDA4-0x000000018CE5FDC0
		public bool isCollapsed { get; set; } // 0x00000001822434B0-0x00000001822434C0 0x00000001822434C0-0x00000001822434D0
		public bool isLocked { get; set; } // 0x000000018CE5FD08-0x000000018CE5FD18 0x000000018226EE30-0x000000018226EE40
		public bool isReadOnly { get; set; } // 0x0000000182271CA0-0x0000000182271CB0 0x0000000182271CB0-0x0000000182271CC0
	
		// Events
		public event Action<Section> OnSectionReached {
			add; // 0x000000018CE5FC14-0x000000018CE5FCA0
			remove; // 0x000000018CE5FD18-0x000000018CE5FDA4
		}
	
		// Nested types
		public enum ActorReferenceMode // TypeDefIndex: 84814
		{
			UseOriginal = 0,
			UseInstanceHideOriginal = 1
		}
	
		public enum ActorInitialTransformation // TypeDefIndex: 84815
		{
			UseOriginal = 0,
			UseLocal = 1
		}
	
		[Serializable]
		public class CustomToggleInfo // TypeDefIndex: 84816
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
			public int index { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
			public CutsceneGroup group { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
	
			// Constructors
			public CustomToggleInfo(); // 0x000000018723FF00-0x000000018723FF10
	
			// Methods
			private void _OnToggleChanged(); // 0x000000018CE5E094-0x000000018CE5E0AC
			public IEnumerable _GetAllTrackNames(); // 0x000000018CE5DF44-0x000000018CE5E094
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 84817
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<CustomToggleInfo, int> __9__48_0; // 0x08
			public static Func<CutsceneTrack, bool> __9__88_0; // 0x10
			public static Func<Section, float> __9__88_1; // 0x18
	
			// Constructors
			static __c(); // 0x000000018CE6BD10-0x000000018CE6BD74
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int __OnCustomToggleValueChanged_b__48_0(CustomToggleInfo t); // 0x000000018CC33418-0x000000018CC33430
			internal bool _Validate_b__88_0(CutsceneTrack t); // 0x000000018CE6B678-0x000000018CE6B6C4
			internal float _Validate_b__88_1(Section s); // 0x000000018929C660-0x000000018929C67C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass89_0 // TypeDefIndex: 84818
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass89_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetSectionByName_b__0(Section s); // 0x000000018CE6BAB0-0x000000018CE6BB04
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass90_0 // TypeDefIndex: 84819
		{
			// Fields
			public string UID; // 0x10
	
			// Constructors
			public __c__DisplayClass90_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetSectionByUID_b__0(Section s); // 0x0000000185624DA0-0x0000000185624DD0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass91_0 // TypeDefIndex: 84820
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass91_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetSectionAfter_b__0(Section s); // 0x000000018CE6BB78-0x000000018CE6BB98
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass92_0 // TypeDefIndex: 84821
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass92_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetSectionBefore_b__0(Section s); // 0x000000018CE6BB98-0x000000018CE6BBB8
		}
	
		// Constructors
		protected CutsceneGroup(); // 0x000000018CE5FA64-0x000000018CE5FC14
		static CutsceneGroup(); // 0x000000018CE5FA28-0x000000018CE5FA64
	
		// Methods
		public void SetCustomToggleDirty(); // 0x000000018CE5E8A0-0x000000018CE5E8AC
		private void _OnCustomToggleValueChanged(); // 0x000000018CE5F214-0x000000018CE5F370
		public bool CheckCustomCollapsed(int index); // 0x000000018CE5E0AC-0x000000018CE5E250
		private void _TryRefreshCustomToggleInfo(); // 0x000000018CE5F370-0x000000018CE5FA28
		public override string ToString(); // 0x000000018CE5EDA4-0x000000018CE5EDB4
		public void Validate(IDirector root, IDirectable parent); // 0x000000018CE5EF24-0x000000018CE5F214
		public Section GetSectionByName(string name); // 0x000000018CE5E3E8-0x000000018CE5E538
		public Section GetSectionByUID(string UID); // 0x000000018CE5E538-0x000000018CE5E608
		public Section GetSectionAfter(float time); // 0x000000018CE5E250-0x000000018CE5E31C
		public Section GetSectionBefore(float time); // 0x000000018CE5E31C-0x000000018CE5E3E8
		bool IDirectable.Initialize(); // 0x000000018CE5E980-0x000000018CE5EA64
		void IDirectable.Enter(); // 0x000000018CE5E8AC-0x000000018CE5E920
		void IDirectable.Reverse(); // 0x000000018CE5EAC4-0x000000018CE5EB24
		void IDirectable.Update(float time, float previousTime); // 0x000000018CE5EB24-0x000000018CE5EC60
		void IDirectable.Exit(); // 0x000000018CE5E920-0x000000018CE5E980
		void IDirectable.ReverseEnter(); // 0x000000018CE5EA64-0x000000018CE5EAC4
		void IDirectable.RootEnabled(); // 0x0000000186805BA0-0x0000000186805BB0
		void IDirectable.RootDisabled(); // 0x0000000186805BA0-0x0000000186805BB0
		void IDirectable.RootUpdated(float time, float previousTime); // 0x0000000186805BA0-0x0000000186805BB0
		void IDirectable.RootDestroyed(); // 0x0000000186805BA0-0x0000000186805BB0
		private void StoreActorState(); // 0x000000018CE5ECB8-0x000000018CE5EDA4
		private void RestoreActorState(); // 0x000000018CE5E718-0x000000018CE5E770
		private void TryInstantiateLocalActor(); // 0x000000018CE5EDB4-0x000000018CE5EF24
		private void ReleaseLocalActorInstance(); // 0x000000018CE5E608-0x000000018CE5E6AC
		private void SetActorLocalCoords(); // 0x000000018CE5E770-0x000000018CE5E8A0
		protected GameObject ResolveActor(GameObject original); // 0x000000018CE5E6AC-0x000000018CE5E718
	}

	public abstract class CutsceneTrack : MonoBehaviour, IDirectable // TypeDefIndex: 84825
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
		public GameObject actor { get; } // 0x000000018CE60904-0x000000018CE60924 
		public new string name { get; set; } // 0x000000018CE60A6C-0x000000018CE60AB0 0x000000018CE60B50-0x000000018CE60B98
		public UnityEngine.Color color { get; } // 0x000000018CE6092C-0x000000018CE60964 
		public List<ActionClip> clips { get; set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		public virtual string info { get; } // 0x000000018CE60984-0x000000018CE609BC 
		IEnumerable<IDirectable> IDirectable.children { get; } // 0x000000018CE60550-0x000000018CE6058C 
		public int layerOrder { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182271C40-0x0000000182271C50 0x0000000182271C60-0x0000000182271C70
		public IDirector root { get; } // 0x000000018CE60AD0-0x000000018CE60AF0 
		public IDirectable parent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
		public virtual bool isCollapsed { get; } // 0x000000018CE609E8-0x000000018CE60A08 
		public virtual bool isActive { get; set; } // 0x000000018CE609BC-0x000000018CE609E8 0x000000018CE60B10-0x000000018CE60B50
		public virtual bool isLocked { get; set; } // 0x000000018CE60A08-0x000000018CE60A3C 0x0000000182260CB0-0x0000000182260CC0
		public virtual float startTime { get; set; } // 0x000000018CE60AF0-0x000000018CE60B10 0x0000000186805BA0-0x0000000186805BB0
		public virtual float endTime { get; set; } // 0x000000018CE60964-0x000000018CE60984 0x0000000186805BA0-0x0000000186805BB0
		public virtual float blendIn { get; set; } // 0x0000000187234CD0-0x0000000187234CE0 0x0000000186805BA0-0x0000000186805BB0
		public virtual float blendOut { get; set; } // 0x0000000187234CD0-0x0000000187234CE0 0x0000000186805BA0-0x0000000186805BB0
		public bool canCrossBlend { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public virtual bool needActor { get; } // 0x000000018CE60AB0-0x000000018CE60AD0 
		public virtual int updateOrder { get; } // 0x0000000187250FE0-0x0000000187250FF0 
		public bool isReadOnly { get; set; } // 0x000000018CE60A3C-0x000000018CE60A6C 0x000000018225DFC0-0x000000018225DFD0
		public virtual bool canDelete { get; } // 0x000000018CE60924-0x000000018CE6092C 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 84823
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ActionClip, float> __9__72_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CE6BCAC-0x000000018CE6BD10
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _Validate_b__72_0(ActionClip a); // 0x000000018CE6B65C-0x000000018CE6B678
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass93_0 // TypeDefIndex: 84824
		{
			// Fields
			public ActionClip newAction; // 0x10
	
			// Constructors
			public __c__DisplayClass93_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _AddAction_b__0(ActionClip a); // 0x000000018CE6BBB8-0x000000018CE6BBE4
		}
	
		// Constructors
		protected CutsceneTrack(); // 0x000000018CE6086C-0x000000018CE60904
	
		// Methods
		bool IDirectable.Initialize(); // 0x000000018CE6051C-0x000000018CE6052C
		void IDirectable.Enter(); // 0x000000018CE604FC-0x000000018CE6050C
		void IDirectable.Update(float time, float previousTime); // 0x000000018CE6053C-0x000000018CE60550
		void IDirectable.Exit(); // 0x000000018CE6050C-0x000000018CE6051C
		void IDirectable.ReverseEnter(); // 0x000000018CE6052C-0x000000018CE6053C
		void IDirectable.Reverse(); // 0x000000018AAB1624-0x000000018AAB1634
		void IDirectable.RootEnabled(); // 0x0000000186805BA0-0x0000000186805BB0
		void IDirectable.RootDisabled(); // 0x0000000186805BA0-0x0000000186805BB0
		void IDirectable.RootUpdated(float time, float previousTime); // 0x0000000186805BA0-0x0000000186805BB0
		void IDirectable.RootDestroyed(); // 0x0000000186805BA0-0x0000000186805BB0
		public void PostCreate(IDirectable parent); // 0x000000018CE604D4-0x000000018CE604FC
		public void Validate(IDirector root, IDirectable parent); // 0x000000018CE60610-0x000000018CE6086C
		protected virtual void OnCreate(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnAfterValidate(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual bool OnInitialize(); // 0x00000001851A4410-0x00000001851A4420
		protected virtual void OnEnter(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnUpdate(float time, float previousTime); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnExit(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnReverseEnter(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnReverse(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnDrawGizmosSelected(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnSceneGUI(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnRootEnabled(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnRootDisabled(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnRootUpdated(float time, float previousTime); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnRootDestroyed(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnDuplicate(); // 0x0000000186805BA0-0x0000000186805BB0
		public float GetTrackWeight(); // 0x000000018CE60438-0x000000018CE604D4
		public float GetTrackWeight(float time); // 0x000000018CE603D8-0x000000018CE60438
		public float GetTrackWeight(float time, float blendInOut); // 0x000000018CE41960-0x000000018CE4197C
		public float GetTrackWeight(float time, float blendIn, float blendOut); // 0x000000018CE4197C-0x000000018CE4198C
		public T AddAction<T>(float time)
			where T : ActionClip;
		public ActionClip AddAction(System.Type type, float time); // 0x000000018CE600F8-0x000000018CE603D8
		[CompilerGenerated]
		private bool _Validate_b__72_1(IDirectable t); // 0x000000018CE6058C-0x000000018CE60610
	}

	public interface IAnimatableData // TypeDefIndex: 84826
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

	public interface IDirectable // TypeDefIndex: 84827
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

	public interface IKeyable : IDirectable // TypeDefIndex: 84828
	{
		// Properties
		AnimationDataCollection animationData { get; }
		object animatedParametersTarget { get; }
	}

	public interface ISubClipContainable : IDirectable // TypeDefIndex: 84829
	{
		// Properties
		float subClipOffset { get; set; }
		float subClipSpeed { get; }
		float subClipLength { get; }
	}

	public static class IDirectableExtensions // TypeDefIndex: 84833
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 84830
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _FindChild_b__0(IDirectable d); // 0x000000018CE6B7E4-0x000000018CE6B840
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 84831
		{
			// Fields
			public IDirectable directable; // 0x10
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetPreviousSibling_b__0(IDirectable d); // 0x000000018CE6B840-0x000000018CE6B890
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 84832
		{
			// Fields
			public IDirectable directable; // 0x10
	
			// Constructors
			public __c__DisplayClass16_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetNextSibling_b__0(IDirectable d); // 0x000000018CE6B890-0x000000018CE6B8E0
		}
	
		// Extension methods
		public static float GetLength(this IDirectable directable); // 0x000000018CE63134-0x000000018CE63170
		public static float RootTimeToLocalTime(this IDirectable directable); // 0x000000018CE6398C-0x000000018CE639C8
		public static float RootTimeToLocalTimeUnclamped(this IDirectable directable); // 0x000000018CE63950-0x000000018CE6398C
		public static bool IsRootTimeWithinClip(this IDirectable directable); // 0x000000018CE638C8-0x000000018CE63904
		public static float ToLocalTime(this IDirectable directable, float time); // 0x000000018CE639F8-0x000000018CE63A58
		public static float ToLocalTimeUnclamped(this IDirectable directable, float time); // 0x000000018CE639C8-0x000000018CE639F8
		public static bool IsTimeWithinClip(this IDirectable directable, float time); // 0x000000018CE63904-0x000000018CE63950
		public static bool CanCrossBlend(this IDirectable directable, IDirectable other); // 0x000000018CE62E4C-0x000000018CE62ED8
		public static bool CanBlendIn(this IDirectable directable); // 0x000000018CE62C5C-0x000000018CE62D54
		public static bool CanBlendOut(this IDirectable directable); // 0x000000018CE62D54-0x000000018CE62E4C
		public static bool CanScale(this IDirectable directable); // 0x000000018CE62ED8-0x000000018CE62FC0
		public static bool WithinBufferTriggerRange(this IDirectable directable, float time, float previousTime, bool bypass = false /* Metadata: 0x026446E3 */); // 0x000000018CE63C3C-0x000000018CE63CC8
		public static IDirectable FindChild(this IDirectable directable, string name); // 0x000000018CE62FC0-0x000000018CE630A8
		public static T GetPreviousSibling<T>(this IDirectable directable)
			where T : IDirectable;
		public static IDirectable GetPreviousSibling(this IDirectable directable); // 0x000000018CE6339C-0x000000018CE63498
		public static T GetNextSibling<T>(this IDirectable directable)
			where T : IDirectable;
		public static IDirectable GetNextSibling(this IDirectable directable); // 0x000000018CE63210-0x000000018CE6330C
		public static T GetFirstParentOfType<T>(this IDirectable directable)
			where T : IDirectable;
		public static float GetWeight(this IDirectable directable); // 0x000000018CE636CC-0x000000018CE636F0
		public static float GetWeight(this IDirectable directable, float time); // 0x000000018CE635DC-0x000000018CE63638
		public static float GetWeight(this IDirectable directable, float time, float blendInOut); // 0x000000018CE41960-0x000000018CE4197C
		public static float GetWeight(this IDirectable directable, float time, float blendIn, float blendOut); // 0x000000018CE63638-0x000000018CE636CC
		public static Transform GetSpaceTransform(this IDirectable directable, TransformSpace space, GameObject actorOverride = null); // 0x000000018CE63498-0x000000018CE635DC
		public static Vector3 TransformPosition(this IDirectable directable, Vector3 point, TransformSpace space); // 0x000000018CE63A58-0x000000018CE63B24
		public static Vector3 InverseTransformPosition(this IDirectable directable, Vector3 point, TransformSpace space); // 0x000000018CE636F0-0x000000018CE637BC
		public static Quaternion TransformRotation(this IDirectable directable, Vector3 euler, TransformSpace space); // 0x000000018CE63B24-0x000000018CE63C3C
		public static Vector3 InverseTransformRotation(this IDirectable directable, Quaternion rot, TransformSpace space); // 0x000000018CE637BC-0x000000018CE638C8
		public static Vector3 ActorPositionInSpace(this IDirectable directable, TransformSpace space); // 0x000000018CE62B24-0x000000018CE62C5C
		public static float GetPreviousLoopLocalTime(this ISubClipContainable clip); // 0x000000018CE6330C-0x000000018CE6339C
		public static float GetNextLoopLocalTime(this ISubClipContainable clip); // 0x000000018CE63170-0x000000018CE63210
		public static AnimationCurve[] GetCurvesAll(this IKeyable keyable); // 0x000000018CE630A8-0x000000018CE63134
	}

	public interface IDirector // TypeDefIndex: 84834
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
	public class Section // TypeDefIndex: 84836
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
		public int currentLoopIteration { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182271C50-0x0000000182271C60 0x0000000182271C70-0x0000000182271C80
		public string UID { get; private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public string name { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public float time { get; set; } // 0x00000001872332C0-0x00000001872332D0 0x00000001872332D0-0x00000001872332E0
		public ExitMode exitMode { get; set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
		public int loopCount { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		public UnityEngine.Color color { get; set; } // 0x000000018CE68DFC-0x000000018CE68E6C 0x000000018723B660-0x000000018723B670
		public bool colorizeBackground { get; set; } // 0x000000018226ECA0-0x000000018226ECB0 0x000000018226ECB0-0x000000018226ECC0
	
		// Nested types
		public enum ExitMode // TypeDefIndex: 84835
		{
			Continue = 0,
			Loop = 1
		}
	
		// Constructors
		public Section(string name, float time); // 0x000000018CE68D34-0x000000018CE68DFC
		static Section(); // 0x000000018CE68CC8-0x000000018CE68D34
	
		// Methods
		public void ResetLoops(); // 0x0000000187257DB0-0x0000000187257DC0
		public void BreakLoop(); // 0x0000000187257DA0-0x0000000187257DB0
		public bool TryUpdateLoop(); // 0x000000018CE68CA8-0x000000018CE68CC8
		public override string ToString(); // 0x000000018CE68C34-0x000000018CE68CA8
	}

	public interface IDirectableTimePointer // TypeDefIndex: 84837
	{
		// Properties
		IDirectable target { get; }
		float time { get; }
	
		// Methods
		void TriggerForward(float currentTime, float previousTime);
		void TriggerBackward(float currentTime, float previousTime);
		void Update(float currentTime, float previousTime);
	}

	public struct StartTimePointer : IDirectableTimePointer // TypeDefIndex: 84838
	{
		// Fields
		private bool triggered; // 0x00
		private float lastTargetStartTime; // 0x04
		[CompilerGenerated]
		private IDirectable _target_k__BackingField; // 0x08
	
		// Properties
		public IDirectable target { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x00000001844AFA30-0x00000001844AFA40 0x0000000188AC06FC-0x0000000188AC070C
		float IDirectableTimePointer.time { get; } // 0x000000018CE6A174-0x000000018CE6A190 
	
		// Constructors
		public StartTimePointer(IDirectable target); // 0x000000018CE6A190-0x000000018CE6A1CC
	
		// Methods
		void IDirectableTimePointer.TriggerForward(float currentTime, float previousTime); // 0x000000018CE69FC0-0x000000018CE6A03C
		void IDirectableTimePointer.Update(float currentTime, float previousTime); // 0x000000018CE6A03C-0x000000018CE6A174
		void IDirectableTimePointer.TriggerBackward(float currentTime, float previousTime); // 0x000000018CE69F24-0x000000018CE69FC0
	}

	public struct EndTimePointer : IDirectableTimePointer // TypeDefIndex: 84839
	{
		// Fields
		private bool triggered; // 0x00
		[CompilerGenerated]
		private IDirectable _target_k__BackingField; // 0x08
	
		// Properties
		public IDirectable target { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x00000001844AFA30-0x00000001844AFA40 0x0000000188AC06FC-0x0000000188AC070C
		float IDirectableTimePointer.time { get; } // 0x000000018CE624A0-0x000000018CE624BC 
	
		// Constructors
		public EndTimePointer(IDirectable target); // 0x000000018CE624BC-0x000000018CE624DC
	
		// Methods
		void IDirectableTimePointer.TriggerForward(float currentTime, float previousTime); // 0x000000018CE623C0-0x000000018CE62454
		void IDirectableTimePointer.Update(float currentTime, float previousTime); // 0x000000018CE62454-0x000000018CE624A0
		void IDirectableTimePointer.TriggerBackward(float currentTime, float previousTime); // 0x000000018CE62338-0x000000018CE623C0
	}

	[AddComponentMenu("SLATE/Path")]
	public class BezierPath : Path // TypeDefIndex: 84840
	{
		// Fields
		[Range(0f, 100f)]
		public int resolution; // 0x18
		[SerializeField]
		private List<Slate.BezierPoint> _points; // 0x20
		private Vector3[] _sampledPathPoints; // 0x28
		private float _length; // 0x30
	
		// Properties
		public List<Slate.BezierPoint> points { get; } // 0x000000018225E800-0x000000018225E810 
		public Slate.BezierPoint this[int index] { get => default; } // 0x000000018CE5C494-0x000000018CE5C4E8 
		public int pointCount { get; } // 0x000000018CE5C4E8-0x000000018CE5C528 
		public override float length { get; } // 0x0000000187233870-0x0000000187233880 
	
		// Constructors
		public BezierPath(); // 0x000000018CE5C40C-0x000000018CE5C494
	
		// Methods
		private void Awake(); // 0x000000018C2326A0-0x000000018C2326B0
		private void OnValidate(); // 0x000000018C2326A0-0x000000018C2326B0
		public override void Compute(); // 0x000000018CE5BDB4-0x000000018CE5BDDC
		public void SetDirty(); // 0x000000018C2326A0-0x000000018C2326B0
		private void ComputeLength(); // 0x000000018CE5BC28-0x000000018CE5BC48
		private void ComputeSampledPathPoints(); // 0x000000018CE5BC48-0x000000018CE5BDB4
		public static BezierPath Create(Transform targetParent = null); // 0x000000018CE5BDDC-0x000000018CE5C03C
		public Slate.BezierPoint AddPointAt(Vector3 position, int index = -1 /* Metadata: 0x026446E6 */); // 0x000000018CE5BB40-0x000000018CE5BC28
		public void RemovePoint(Slate.BezierPoint point); // 0x000000018CE5C3AC-0x000000018CE5C40C
		public int GetPointIndex(Slate.BezierPoint point); // 0x000000018CE5C03C-0x000000018CE5C0C0
		public static Vector3[] GetSampledPathPositions(Slate.BezierPoint p1, Slate.BezierPoint p2, int resolution); // 0x000000018CE5C29C-0x000000018CE5C3AC
		public override Vector3 GetPositionAt(float t); // 0x000000018CE5C1CC-0x000000018CE5C29C
		public static Vector3 GetPositionAt(Slate.BezierPoint p1, Slate.BezierPoint p2, float t); // 0x000000018CE5C0C0-0x000000018CE5C1CC
	}

	[Serializable]
	public class BezierPoint // TypeDefIndex: 84842
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
		public HandleStyle handleStyle { get; set; } // 0x000000018226F000-0x000000018226F010 0x000000018226F010-0x000000018226F020
		public BezierPath path { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public Vector3 position { get; set; } // 0x000000018CE5C6C0-0x000000018CE5C730 0x000000018CE5CA18-0x000000018CE5CA84
		public Vector3 handle1LocalPosition { get; private set; } // 0x000000018723E4F0-0x000000018723E510 0x000000018CE5C730-0x000000018CE5C7E8
		public Vector3 handle2LocalPosition { get; private set; } // 0x0000000187235E20-0x0000000187235E40 0x000000018CE5C8A4-0x000000018CE5C95C
		public Vector3 handle1Position { get; set; } // 0x000000018CE5C568-0x000000018CE5C614 0x000000018CE5C7E8-0x000000018CE5C8A4
		public Vector3 handle2Position { get; set; } // 0x000000018CE5C614-0x000000018CE5C6C0 0x000000018CE5C95C-0x000000018CE5CA18
	
		// Nested types
		public enum HandleStyle // TypeDefIndex: 84841
		{
			Connected = 0,
			Broken = 1
		}
	
		// Constructors
		public BezierPoint(BezierPath path, Vector3 position); // 0x000000018CE5C528-0x000000018CE5C568
	}

	public abstract class Path : MonoBehaviour // TypeDefIndex: 84843
	{
		// Properties
		public abstract float length { get; }
	
		// Constructors
		protected Path(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public abstract Vector3 GetPositionAt(float t);
		public abstract void Compute();
		public static Vector3 GetPositionAlongCurve(Vector3 from, Vector3 to, Vector3 fromTangent, Vector3 toTangent, float t); // 0x000000018CE64738-0x000000018CE64930
		public static Vector3 GetPosition(float t, params Vector3[] path); // 0x000000018CE64930-0x000000018CE64B34
		public static float GetLength(Vector3[] path); // 0x000000018CE6468C-0x000000018CE64738
	}

	public static class AnimationDataUtility // TypeDefIndex: 84844
	{
		// Methods
		public static string[] GetAnimatableMemberPaths(object root); // 0x000000018CE5AC38-0x000000018CE5AC94
		private static string[] Internal_GetAnimatableMemberPaths(System.Type type, string path); // 0x000000018CE5AC94-0x000000018CE5B020
	}

	[ExecuteInEditMode]
	public class AnimatorDispatcher : MonoBehaviour // TypeDefIndex: 84845
	{
		// Fields
		[CompilerGenerated]
		private Action<int> onAnimatorIK; // 0x18
		private Animator _animator; // 0x20
	
		// Properties
		private Animator animator { get; } // 0x000000018CE5B0C0-0x000000018CE5B14C 
	
		// Events
		public event Action<int> onAnimatorIK {
			add; // 0x000000018CE5B034-0x000000018CE5B0C0
			remove; // 0x000000018CE5B14C-0x000000018CE5B1D8
		}
	
		// Constructors
		public AnimatorDispatcher(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void OnAnimatorIK(int index); // 0x000000018CE5B020-0x000000018CE5B034
	}

	public static class AudioSampler // TypeDefIndex: 84847
	{
		// Fields
		private const string ROOT_NAME = "_AudioSources"; // Metadata: 0x026446E9
		private static GameObject root; // 0x00
		private static Dictionary<object, AudioSource> sources; // 0x08
	
		// Nested types
		[Serializable]
		public struct SampleSettings // TypeDefIndex: 84846
		{
			// Fields
			public float volume; // 0x00
			public float pitch; // 0x04
			public float pan; // 0x08
			public float spatialBlend; // 0x0C
			public bool ignoreTimescale; // 0x10
			public bool bypassReverb; // 0x11
	
			// Methods
			public static SampleSettings Default(); // 0x0000000187257D50-0x0000000187257D70
		}
	
		// Constructors
		static AudioSampler(); // 0x000000018CE5BAAC-0x000000018CE5BB40
	
		// Methods
		public static AudioSource GetSourceForID(object keyID); // 0x000000018CE5B1D8-0x000000018CE5B4B8
		public static void ReleaseSourceForID(object keyID); // 0x000000018CE5B4B8-0x000000018CE5B648
		public static void SampleForID(object keyID, AudioClip clip, float time, float previousTime, float volume); // 0x000000018CE5B648-0x000000018CE5B710
		public static void SampleForID(object keyID, AudioClip clip, float time, float previousTime, SampleSettings settings); // 0x000000018CE5B710-0x000000018CE5B7B8
		public static void Sample(AudioSource source, AudioClip clip, float time, float previousTime, float volume); // 0x000000018CE5B7B8-0x000000018CE5B880
		public static void Sample(AudioSource source, AudioClip clip, float time, float previousTime, SampleSettings settings); // 0x000000018CE5B880-0x000000018CE5BAAC
	}

	public static class ColorUtility // TypeDefIndex: 84848
	{
		// Methods
		public static UnityEngine.Color Grey(float value); // 0x0000000187254460-0x0000000187254480
	
		// Extension methods
		public static UnityEngine.Color WithAlpha(this UnityEngine.Color color, float alpha); // 0x0000000187254480-0x00000001872544A0
	}

	public enum TangentMode // TypeDefIndex: 84849
	{
		Editable = 0,
		Smooth = 1,
		Linear = 2,
		Constant = 3
	}

	public static class CurveUtility // TypeDefIndex: 84854
	{
		// Fields
		private const float KEY_PROXIMITY_TOLERANCE = 0.001f; // Metadata: 0x026446FB
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 84850
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetKeyNext_b__1(Keyframe k); // 0x000000018CE6BA58-0x000000018CE6BA74
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 84851
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Keyframe, float> __9__1_0; // 0x08
			public static Func<Keyframe, float> __9__2_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018CE6BBE4-0x000000018CE6BC48
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _GetKeyNext_b__1_0(Keyframe k); // 0x0000000187257DC0-0x0000000187257DD0
			internal float _GetKeyPrevious_b__2_0(Keyframe k); // 0x0000000187257DC0-0x0000000187257DD0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 84852
		{
			// Fields
			public float time; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetKeyPrevious_b__1(Keyframe k); // 0x000000018CE6BA74-0x000000018CE6BA8C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 84853
		{
			// Fields
			public float time; // 0x10
			public Func<Keyframe, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _HasKey_b__0(Keyframe k); // 0x000000018CE6BA8C-0x000000018CE6BAB0
		}
	
		// Methods
		public static float GetKeyNext(float time, params AnimationCurve[] curves); // 0x000000018CE5D5EC-0x000000018CE5D844
		public static float GetKeyPrevious(float time, params AnimationCurve[] curves); // 0x000000018CE5D844-0x000000018CE5DAB8
		public static bool HasKey(float time, params AnimationCurve[] curves); // 0x000000018CE5DB1C-0x000000018CE5DC60
		public static bool HasAnyKey(params AnimationCurve[] curves); // 0x000000018CE5DAB8-0x000000018CE5DB1C
	
		// Extension methods
		public static void OffsetCurveValue(this AnimationCurve curve, float deltaValue); // 0x000000018CE5DD50-0x000000018CE5DDF0
		public static void OffsetCurveTime(this AnimationCurve curve, float deltaTime); // 0x000000018CE5DC60-0x000000018CE5DD50
		public static void RemoveNegativeKeys(this AnimationCurve curve); // 0x000000018CE5DF30-0x000000018CE5DF44
		public static void RemoveKeysOffRange(this AnimationCurve curve, float min, float max); // 0x000000018CE5DDF0-0x000000018CE5DF30
	}

	public class DecoratorAttribute : Attribute // TypeDefIndex: 84855
	{
		// Fields
		public readonly System.Type targetType; // 0x10
	
		// Constructors
		public DecoratorAttribute(System.Type targetType); // 0x0000000184FD2410-0x0000000184FD2420
	}

	public interface IDecorator // TypeDefIndex: 84856
	{
		// Properties
		object Target { get; set; }
	}

	public static class DecoratorFactory // TypeDefIndex: 84857
	{
		// Fields
		private static Dictionary<System.Type, System.Type> decoratorsTypeMap; // 0x00
		private static Dictionary<object, IDecorator> decoratorsInstanceMap; // 0x08
	
		// Constructors
		static DecoratorFactory(); // 0x000000018CE60B98-0x000000018CE60C8C
	
		// Methods
		public static T GetDecorator<T>(object target)
			where T : IDecorator;
		private static T CreateDecorator<T>(System.Type targetType)
			where T : IDecorator;
	
		// Extension methods
		public static T Decorator<T>(this object target)
			where T : IDecorator;
	}

	public enum EaseType // TypeDefIndex: 84858
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

	public static class Easing // TypeDefIndex: 84859
	{
		// Methods
		public static float Ease(Slate.EaseType type, float from, float to, float t); // 0x000000018CE61920-0x000000018CE619A4
		public static Vector3 Ease(Slate.EaseType type, Vector3 from, Vector3 to, float t); // 0x000000018CE61B24-0x000000018CE61C08
		public static Quaternion Ease(Slate.EaseType type, Quaternion from, Quaternion to, float t); // 0x000000018CE619A4-0x000000018CE61A68
		public static UnityEngine.Color Ease(Slate.EaseType type, UnityEngine.Color from, UnityEngine.Color to, float t); // 0x000000018CE61A68-0x000000018CE61B24
		public static Func<float, float> Function(Slate.EaseType type); // 0x000000018CE61C08-0x000000018CE62338
		public static float Linear(float t); // 0x0000000186805BA0-0x0000000186805BB0
		public static float QuadraticIn(float t); // 0x00000001872355E0-0x00000001872355F0
		public static float QuadraticOut(float t); // 0x00000001872546A0-0x00000001872546C0
		public static float QuadraticInOut(float t); // 0x000000018CB51C2C-0x000000018CB51C88
		public static float QuarticIn(float t); // 0x00000001872546C0-0x00000001872546D0
		public static float QuarticOut(float t); // 0x00000001872546D0-0x0000000187254700
		public static float QuarticInOut(float t); // 0x000000018CB51C88-0x000000018CB51CDC
		public static float QuinticIn(float t); // 0x0000000187254700-0x0000000187254720
		public static float QuinticOut(float t); // 0x0000000187254720-0x0000000187254750
		public static float QuinticInOut(float t); // 0x000000018CB51CDC-0x000000018CB51D38
		public static float CubicIn(float t); // 0x00000001872367F0-0x0000000187236800
		public static float CubicOut(float t); // 0x0000000187254590-0x00000001872545B0
		public static float CubicInOut(float t); // 0x000000018CB50FDC-0x000000018CB51044
		public static float SinusoidalIn(float t); // 0x000000018CB51D38-0x000000018CB51D68
		public static float SinusoidalOut(float t); // 0x000000018CB51D68-0x000000018CB51D80
		public static float SinusoidalInOut(float t); // 0x0000000187254750-0x0000000187254780
		public static float ExponentialIn(float t); // 0x000000018CB5148C-0x000000018CB514B8
		public static float ExponentialOut(float t); // 0x000000018CB514B8-0x000000018CB514FC
		public static float ExponentialInOut(float t); // 0x000000018CB5140C-0x000000018CB5148C
		public static float CircularIn(float t); // 0x0000000187254500-0x0000000187254560
		public static float CircularOut(float t); // 0x0000000187254560-0x0000000187254590
		public static float CircularInOut(float t); // 0x000000018CB50F78-0x000000018CB50FDC
		public static float ElasticIn(float t); // 0x00000001872545B0-0x0000000187254630
		public static float ElasticOut(float t); // 0x0000000187254630-0x00000001872546A0
		public static float ElasticInOut(float t); // 0x000000018CB5132C-0x000000018CB5140C
		public static float BounceIn(float t); // 0x000000018CB50EAC-0x000000018CB50EE0
		public static float BounceOut(float t); // 0x000000018CB50EE0-0x000000018CB50F78
		public static float BounceInOut(float t); // 0x000000018CB50E40-0x000000018CB50EAC
		public static float BackIn(float t); // 0x00000001872544B0-0x00000001872544D0
		public static float BackOut(float t); // 0x00000001872544D0-0x0000000187254500
		public static float BackInOut(float t); // 0x000000018CB50DD8-0x000000018CB50E40
	}

	public interface ITransformRefParameter // TypeDefIndex: 84860
	{
		// Properties
		Transform transform { get; }
		TransformSpace space { get; }
		bool useAnimation { get; }
	}

	public class ObjectSnapshot // TypeDefIndex: 84861
	{
		// Fields
		private static List<System.Type> ignoreTypes; // 0x00
		private Dictionary<UnityEngine.Object, string> serialized; // 0x10
	
		// Constructors
		public ObjectSnapshot(UnityEngine.Object target, bool fullObjectHierarchy = false /* Metadata: 0x0264471E */); // 0x000000018CE645EC-0x000000018CE6468C
		static ObjectSnapshot(); // 0x000000018CE64560-0x000000018CE645EC
	
		// Methods
		public static void AppendIgnoreType(System.Type type); // 0x000000018CE63F90-0x000000018CE64040
		public void Store(UnityEngine.Object target, bool fullObjectHierarchy = false /* Metadata: 0x0264471F */); // 0x000000018CE64298-0x000000018CE64560
		public void Restore(); // 0x000000018CE64040-0x000000018CE64298
	}

	public static class RectUtility // TypeDefIndex: 84862
	{
		// Methods
		public static Rect GetBoundRect(params Rect[] rects); // 0x000000018CB474DC-0x000000018CB475FC
		public static Rect GetBoundRect(params Vector2[] positions); // 0x000000018CB475FC-0x000000018CB47710
	
		// Extension methods
		public static bool Encapsulates(this Rect a, Rect b); // 0x000000018CE66600-0x000000018CE666B8
		public static Rect ExpandBy(this Rect rect, float margin); // 0x000000018CE6671C-0x000000018CE66758
		public static Rect ExpandBy(this Rect rect, float xMargin, float yMargin); // 0x000000018CE666B8-0x000000018CE6671C
		public static Rect TransformSpace(this Rect rect, Rect oldContainer, Rect newContainer); // 0x000000018CB47790-0x000000018CB478C8
		public static Rect ToViewRect(this Bounds b, Camera cam); // 0x000000018CE66758-0x000000018CE66E38
	}

	public static class ReflectionTools // TypeDefIndex: 84865
	{
		// Fields
		private const System.Reflection.BindingFlags flagsEverything = System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic; // Metadata: 0x02644723
		private static List<Assembly> _loadedAssemblies; // 0x00
		private static Dictionary<string, System.Type> typeMap; // 0x08
		private static Dictionary<System.Type, System.Type[]> subTypesMap; // 0x10
	
		// Properties
		private static List<Assembly> loadedAssemblies { get; } // 0x000000018CE68B64-0x000000018CE68C34 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 84863
		{
			// Fields
			public System.Type type; // 0x10
			public Func<System.Type, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetImplementationsOf_b__0(System.Type t); // 0x000000018CE6BB04-0x000000018CE6BB78
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0<T, TValue> // TypeDefIndex: 84864
		{
			// Fields
			public MemberInfo info;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _GetFieldOrPropSetter_b__0(T x, TValue v);
		}
	
		// Constructors
		static ReflectionTools(); // 0x000000018CE68A68-0x000000018CE68B64
	
		// Methods
		public static System.Type GetType(string typeName); // 0x000000018CE67E08-0x000000018CE683A8
		public static System.Type[] GetAllTypes(); // 0x000000018CE66F28-0x000000018CE6717C
		public static System.Type[] GetImplementationsOf(System.Type type); // 0x000000018CE6717C-0x000000018CE67674
		public static Action<T, TValue> GetFieldOrPropSetter<T, TValue>(MemberInfo info);
		public static MemberInfo GetRelativeMember(object root, string path); // 0x000000018CE67D94-0x000000018CE67E08
		public static MemberInfo GetRelativeMember(System.Type type, string path); // 0x000000018CE67C40-0x000000018CE67D94
		public static object GetRelativeMemberParent(object root, string path); // 0x000000018CE67AF8-0x000000018CE67C40
		public static string GetMemberPath<T, TResult>(Expression<Func<T, TResult>> func);
		public static string[] GetMemberPaths(System.Type type, Predicate<System.Type> shouldInclude, Predicate<System.Type> shouldContinue, string currentPath = "" /* Metadata: 0x02644722 */, List<System.Type> recursionCheck = null); // 0x000000018CE67674-0x000000018CE67AF8
	
		// Extension methods
		private static System.Type[] RTGetExportedTypes(this Assembly asm); // 0x000000018CE683A8-0x000000018CE683C8
		public static string FriendlyName(this System.Type type); // 0x000000018CE66E38-0x000000018CE66F28
		public static bool RTIsStatic(this PropertyInfo propertyInfo); // 0x000000018CE68830-0x000000018CE688E0
		public static bool RTIsAbstract(this System.Type type); // 0x000000018CB3AFD0-0x000000018CB3AFEC
		public static bool RTIsSubclassOf(this System.Type type, System.Type other); // 0x000000018CB5D5D0-0x000000018CB5D5F4
		public static bool RTIsAssignableFrom(this System.Type type, System.Type second); // 0x000000018CE6880C-0x000000018CE68830
		public static System.Reflection.FieldInfo RTGetField(this System.Type type, string name); // 0x000000018CE68678-0x000000018CE6869C
		public static PropertyInfo RTGetProperty(this System.Type type, string name); // 0x000000018CE687E8-0x000000018CE6880C
		public static MethodInfo RTGetMethod(this System.Type type, string name); // 0x000000018CE687A0-0x000000018CE687C4
		public static System.Reflection.FieldInfo[] RTGetFields(this System.Type type); // 0x000000018CE6877C-0x000000018CE687A0
		public static PropertyInfo[] RTGetProperties(this System.Type type); // 0x000000018CE687C4-0x000000018CE687E8
		public static MethodInfo RTGetGetMethod(this PropertyInfo prop); // 0x000000018CB3AB74-0x000000018CB3AB90
		public static MethodInfo RTGetSetMethod(this PropertyInfo prop); // 0x000000018CB3AFB4-0x000000018CB3AFD0
		public static System.Type RTReflectedType(this System.Type type); // 0x000000018CE688E0-0x000000018CE68900
		public static System.Type RTReflectedType(this MemberInfo member); // 0x000000018CE688E0-0x000000018CE68900
		public static T RTGetAttribute<T>(this System.Type type, bool inherited)
			where T : Attribute;
		public static T RTGetAttribute<T>(this MemberInfo member, bool inherited)
			where T : Attribute;
		public static bool RTIsDefined<T>(this MemberInfo member, bool inherited)
			where T : Attribute;
		public static T RTCreateDelegate<T>(this MethodInfo method, object instance);
		public static MemberInfo[] RTGetFieldsAndProps(this System.Type type); // 0x000000018CE6869C-0x000000018CE6877C
		public static MemberInfo RTGetFieldOrProp(this System.Type type, string name); // 0x000000018CE685E8-0x000000018CE68678
		public static object RTGetFieldOrPropValue(this MemberInfo member, object instance, int index = -1 /* Metadata: 0x02644720 */); // 0x000000018CE6848C-0x000000018CE685E8
		public static void RTSetFieldOrPropValue(this MemberInfo member, object instance, object value, int index = -1 /* Metadata: 0x02644721 */); // 0x000000018CE68900-0x000000018CE68A68
		public static System.Type RTGetFieldOrPropType(this MemberInfo member); // 0x000000018CE683C8-0x000000018CE6848C
	}

	public static class StringUtility // TypeDefIndex: 84866
	{
		// Methods
		public static string AbsToRelativePath(string absolutepath); // 0x000000018CE6A4B8-0x000000018CE6A594
	
		// Extension methods
		public static string SplitCamelCase(this string s); // 0x000000018CE6A594-0x000000018CE6A698
	}

	[Serializable]
	public struct TransformRefPosition : ITransformRefParameter // TypeDefIndex: 84867
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
		public bool useAnimation { get; } // 0x000000018CE6AB70-0x000000018CE6AC1C 
		public CutsceneGroup group { get; set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public Transform transform { get; set; } // 0x000000018CE6AAB8-0x000000018CE6AB70 0x0000000188AC06FC-0x0000000188AC070C
		public Vector3 value { get; set; } // 0x000000018CE6AC1C-0x000000018CE6AC88 0x0000000187239670-0x0000000187239680
		public TransformSpace space { get; private set; } // 0x000000018CE6AA94-0x000000018CE6AAB8 0x0000000187233010-0x0000000187233020
	
		// Methods
		public override string ToString(); // 0x000000018CE6AA0C-0x000000018CE6AA94
	}

	[Serializable]
	public struct TransformRefPositionRotation : ITransformRefParameter // TypeDefIndex: 84868
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
		public bool useAnimation { get; } // 0x000000018CE6A960-0x000000018CE6AA0C 
		public CutsceneGroup group { get; set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public Transform transform { get; set; } // 0x000000018CE6A8A8-0x000000018CE6A960 0x0000000188AC06FC-0x0000000188AC070C
		public Vector3 position { get; set; } // 0x000000018CE6A7AC-0x000000018CE6A818 0x0000000187239670-0x0000000187239680
		public Vector3 rotation { get; set; } // 0x000000018CE6A818-0x000000018CE6A884 0x000000018723E2A0-0x000000018723E2B0
		public TransformSpace space { get; private set; } // 0x000000018CE6A884-0x000000018CE6A8A8 0x0000000182271A90-0x0000000182271AA0
	
		// Methods
		public override string ToString(); // 0x000000018CE6A6F4-0x000000018CE6A7AC
	}

	public class TransformSnapshot // TypeDefIndex: 84871
	{
		// Fields
		private List<TransformData> data; // 0x10
	
		// Nested types
		public enum StoreMode // TypeDefIndex: 84869
		{
			All = 0,
			RootOnly = 1,
			ChildrenOnly = 2
		}
	
		private struct TransformData // TypeDefIndex: 84870
		{
			// Fields
			public Transform transform; // 0x00
			public Transform parent; // 0x08
			public Vector3 pos; // 0x10
			public Quaternion rot; // 0x1C
			public Vector3 scale; // 0x2C
	
			// Constructors
			public TransformData(Transform transform, Transform parent, Vector3 pos, Quaternion rot, Vector3 scale); // 0x000000018CE6A698-0x000000018CE6A6F4
		}
	
		// Constructors
		public TransformSnapshot(GameObject root, StoreMode mode); // 0x000000018CE6B1B0-0x000000018CE6B250
	
		// Methods
		public void Store(GameObject root, StoreMode mode); // 0x000000018CE6ADF8-0x000000018CE6B1B0
		public void Restore(); // 0x000000018CE6AC88-0x000000018CE6ADF8
	}

	public static class UnityObjectUtility // TypeDefIndex: 84873
	{
		// Fields
		private static MethodInfo _getLocalEulerAngles; // 0x00
		private static MethodInfo _setLocalEulerAngles; // 0x08
		private static PropertyInfo _rotationOrder; // 0x10
		private static object[] _rotationOrderArgGet; // 0x18
		private static object[] _rotationOrderArgSet; // 0x20
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 84872
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _FindInChildren_b__0(Transform t); // 0x000000018CE6B784-0x000000018CE6B7E4
		}
	
		// Constructors
		static UnityObjectUtility(); // 0x000000018CE6C848-0x000000018CE6CA10
	
		// Extension methods
		public static Vector3 GetLocalEulerAngles(this Transform transform); // 0x000000018CE6C2C4-0x000000018CE6C3E4
		public static void SetLocalEulerAngles(this Transform transform, Vector3 value); // 0x000000018CE6C6E8-0x000000018CE6C848
		public static string CalculateTransformPath(this Transform root, Transform child); // 0x000000018CE6BD74-0x000000018CE6BF2C
		public static Transform ResolveTransformPath(this Transform root, string path); // 0x000000018CE6C560-0x000000018CE6C62C
		public static Transform FindInChildren(this Transform root, string name, bool includeHidden); // 0x000000018CE6BF2C-0x000000018CE6C068
		public static void ResetLocalCoords(this Transform transform, bool includeScale = true /* Metadata: 0x02644727 */); // 0x000000018CE6C4BC-0x000000018CE6C560
		public static void SetLocalCoordsFrom(this Transform transform, Transform source); // 0x000000018CE6C62C-0x000000018CE6C6E8
		public static Transform InsertParentInChain(this Transform transform, string name); // 0x000000018CE6C3E4-0x000000018CE6C4BC
		public static T GetAddComponent<T>(this GameObject go)
			where T : Component;
		public static T GetAddComponent<T>(this Component comp)
			where T : Component;
		public static Component GetAddComponent(this GameObject go, System.Type type); // 0x000000018CE6C068-0x000000018CE6C0F8
		public static List<string> GetBlendShapeNames(this SkinnedMeshRenderer skinnedMesh); // 0x000000018CE6C1BC-0x000000018CE6C2C4
		public static int GetBlendShapeIndex(this SkinnedMeshRenderer skinnedMesh, string shapeName); // 0x000000018CE6C0F8-0x000000018CE6C1BC
	}

	public static class VideoSampler // TypeDefIndex: 84876
	{
		// Fields
		private const string ROOT_NAME = "_VideoSources"; // Metadata: 0x02644728
		private static GameObject root; // 0x00
		private static Dictionary<object, VideoPlayer> sources; // 0x08
	
		// Nested types
		public enum VideoRenderTarget // TypeDefIndex: 84874
		{
			CameraBackground = 0,
			CameraForeground = 1
		}
	
		[Serializable]
		public struct SampleSettings // TypeDefIndex: 84875
		{
			// Fields
			public VideoRenderTarget renderTarget; // 0x00
			public float playbackSpeed; // 0x04
			public float alpha; // 0x08
			public VideoAspectRatio aspectRatio; // 0x0C
			public float audioVolume; // 0x10
	
			// Methods
			public static SampleSettings Default(); // 0x0000000187257D70-0x0000000187257DA0
		}
	
		// Constructors
		static VideoSampler(); // 0x000000018CE6D1B8-0x000000018CE6D288
	
		// Methods
		public static VideoPlayer GetSourceForID(object keyID); // 0x000000018CE6CA10-0x000000018CE6CD58
		public static void ReleaseSourceForID(object keyID); // 0x000000018CE6CD58-0x000000018CE6CF10
		public static void SampleForID(object keyID, VideoClip clip, float time, float previousTime, SampleSettings settings); // 0x000000018CE6CF10-0x000000018CE6CFB8
		public static void Sample(VideoPlayer source, VideoClip clip, float time, float previousTime, SampleSettings settings); // 0x000000018CE6CFB8-0x000000018CE6D1B8
	}

	public class CutsceneSequencePlayer : MonoBehaviour // TypeDefIndex: 84877
	{
		// Fields
		public bool playOnStart; // 0x18
		public List<Cutscene> cutscenes; // 0x20
		public UnityEvent onFinish; // 0x28
		private int currentIndex; // 0x30
		private bool isPlaying; // 0x34
	
		// Constructors
		public CutsceneSequencePlayer(); // 0x0000000187836ABC-0x0000000187836AD8
	
		// Methods
		private void Start(); // 0x000000018CE60078-0x000000018CE60088
		public void Play(); // 0x000000018CE5FFA4-0x000000018CE60078
		public void Stop(); // 0x000000018CE60088-0x000000018CE600F0
		private void MoveNext(); // 0x000000018CE5FE40-0x000000018CE5FFA4
		public static GameObject Create(); // 0x000000018CE5FDC0-0x000000018CE5FE40
		[CompilerGenerated]
		private void _MoveNext_b__8_0(); // 0x000000018CE600F0-0x000000018CE600F8
	}

	[ExecuteInEditMode]
	public class DirectorGUITemplate : MonoBehaviour // TypeDefIndex: 84878
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
		public DirectorGUITemplate(); // 0x0000000187836ABC-0x0000000187836AD8
	
		// Methods
		private void Awake(); // 0x000000018CE60C8C-0x000000018CE60DAC
		[ContextMenu("Show All")]
		private void ShowAll(); // 0x000000018CE61824-0x000000018CE618CC
		[ContextMenu("Hide All")]
		private void HideAll(); // 0x000000018CE60DAC-0x000000018CE60E3C
		private void OnEnable(); // 0x000000018CE61140-0x000000018CE6135C
		private void OnDisable(); // 0x000000018CE60F24-0x000000018CE61140
		private void Update(); // 0x000000018CE618CC-0x000000018CE61920
		private void OnCameraDissolve(Texture texture, float completion); // 0x000000018CE60E3C-0x000000018CE60F24
		private void OnImageOverlayGUI(Texture texture, UnityEngine.Color color, Vector2 scale, Vector2 position); // 0x000000018CE6135C-0x000000018CE614C4
		private void OnLetterboxGUI(float completion); // 0x000000018CE614C4-0x000000018CE6165C
		private void OnScreenFadeGUI(UnityEngine.Color color); // 0x000000018CE6165C-0x000000018CE616B4
		private void OnTextOverlayGUI(string text, UnityEngine.Color color, float size, TextAnchor anchor, Vector2 position); // 0x000000018CE61738-0x000000018CE61824
		private void OnSubtitlesGUI(string text, UnityEngine.Color color); // 0x000000018CE616B4-0x000000018CE61738
	}

	[AddComponentMenu("SLATE/Play Cutscene On Click")]
	public class PlayCutsceneOnClick : MonoBehaviour // TypeDefIndex: 84879
	{
		// Fields
		public Cutscene cutscene; // 0x18
		public float startTime; // 0x20
		public UnityEvent onFinish; // 0x28
	
		// Constructors
		public PlayCutsceneOnClick(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void OnMouseDown(); // 0x000000018CE65F4C-0x000000018CE66060
		private void Reset(); // 0x000000018CE66060-0x000000018CE66100
		public static GameObject Create(); // 0x000000018CE65EDC-0x000000018CE65F4C
		[CompilerGenerated]
		private void _OnMouseDown_b__3_0(); // 0x000000018CE66100-0x000000018CE66120
	}

	[AddComponentMenu("SLATE/Play Cutscene On Start")]
	public class PlayCutsceneOnStart : MonoBehaviour // TypeDefIndex: 84880
	{
		// Fields
		public Cutscene cutscene; // 0x18
		public float startTime; // 0x20
		public UnityEvent onFinish; // 0x28
	
		// Constructors
		public PlayCutsceneOnStart(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void Start(); // 0x000000018CE661AC-0x000000018CE662C0
		public static GameObject Create(); // 0x000000018CE66120-0x000000018CE661AC
		[CompilerGenerated]
		private void _Start_b__3_0(); // 0x000000018CE66100-0x000000018CE66120
	}

	[AddComponentMenu("SLATE/Play Cutscene On Trigger")]
	public class PlayCutsceneOnTrigger : MonoBehaviour // TypeDefIndex: 84881
	{
		// Fields
		public Cutscene cutscene; // 0x18
		public float startTime; // 0x20
		public bool checkSpecificTagOnly; // 0x24
		public string tagName; // 0x28
		public bool once; // 0x30
		public UnityEvent onFinish; // 0x38
	
		// Constructors
		public PlayCutsceneOnTrigger(); // 0x000000018CE665B4-0x000000018CE66600
	
		// Methods
		private void OnTriggerEnter(Collider other); // 0x000000018CE6634C-0x000000018CE664C4
		private void Reset(); // 0x000000018CE664C4-0x000000018CE6653C
		public static GameObject Create(); // 0x000000018CE662C0-0x000000018CE6634C
		[CompilerGenerated]
		private void _OnTriggerEnter_b__6_0(); // 0x000000018CE6653C-0x000000018CE665B4
	}

	[AddComponentMenu("SLATE/Stop Cutscene On Click")]
	public class StopCutsceneOnClick : MonoBehaviour // TypeDefIndex: 84882
	{
		// Fields
		public Cutscene cutscene; // 0x18
		public Cutscene.StopMode stopMode; // 0x20
	
		// Constructors
		public StopCutsceneOnClick(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void OnMouseDown(); // 0x000000018CE6A1CC-0x000000018CE6A280
		private void Reset(); // 0x000000018CE6A280-0x000000018CE6A2E0
	}

	[AddComponentMenu("SLATE/Stop Cutscene On Trigger")]
	public class StopCutsceneOnTrigger : MonoBehaviour // TypeDefIndex: 84883
	{
		// Fields
		public Cutscene cutscene; // 0x18
		public bool checkSpecificTagOnly; // 0x20
		public string tagName; // 0x28
		public Cutscene.StopMode stopMode; // 0x30
	
		// Constructors
		public StopCutsceneOnTrigger(); // 0x000000018CE6A46C-0x000000018CE6A4B8
	
		// Methods
		private void OnTriggerEnter(Collider other); // 0x000000018CE6A2E0-0x000000018CE6A3F4
		private void Reset(); // 0x000000018CE6A3F4-0x000000018CE6A46C
	}
}

namespace Slate.ActionClips
{
	[Attachable(new System.Type[1] {typeof(ActorActionTrack) })]
	public abstract class ActorActionClip : ActionClip // TypeDefIndex: 84884
	{
		// Constructors
		protected ActorActionClip(); // 0x00000001878364A0-0x00000001878364B8
	}

	[Attachable(new System.Type[1] {typeof(ActorActionTrack) })]
	public abstract class ActorActionClip<T> : ActionClip // TypeDefIndex: 84885
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
	public class AnimateProperties : ActionClip // TypeDefIndex: 84886
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
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override bool isValid { get; } // 0x000000018CE4249C-0x000000018CE424B4 
		public override string info { get; } // 0x000000018CE5ABC8-0x000000018CE5AC38 
		public override object animatedParametersTarget { get; } // 0x000000018CE5ABC0-0x000000018CE5ABC8 
		public override Slate.EaseType animatedParametersInterpolation { get; } // 0x00000001872331A0-0x00000001872331B0 
		public override bool useWeightInParameters { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		public AnimateProperties(); // 0x000000018CE5AB9C-0x000000018CE5ABC0
	}

	[Category("Character")]
	[Description("Animates a single blend shape chosen from within the whole actor gameobject hierarchy.")]
	public class AnimateBlendShape : ActorActionClip // TypeDefIndex: 84887
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
		public override string info { get; } // 0x000000018CE59D28-0x000000018CE59D68 
		public override bool isValid { get; } // 0x000000018CE59D68-0x000000018CE59E10 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override bool canCrossBlend { get; } // 0x00000001851A4410-0x00000001851A4420 
		public string skinName { get; set; } // 0x000000018226EBD0-0x000000018226EBE0 0x000000018CE59F68-0x000000018CE59F94
		public string shapeName { get; set; } // 0x0000000187232F70-0x0000000187232F80 0x00000001856B9750-0x00000001856B9760
		private SkinnedMeshRenderer skinnedMesh { get; } // 0x000000018CE59E10-0x000000018CE59F68 
	
		// Constructors
		public AnimateBlendShape(); // 0x000000018CE59CF4-0x000000018CE59D28
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE59B10-0x000000018CE59BF8
		protected override void OnUpdate(float deltaTime); // 0x000000018CE59C34-0x000000018CE59CBC
		protected override void OnReverse(); // 0x000000018CE59BF8-0x000000018CE59C34
		[CompilerGenerated]
		private bool _get_skinnedMesh_b__31_0(SkinnedMeshRenderer s); // 0x000000018CE59CBC-0x000000018CE59CF4
	}

	[Category("Character")]
	[Description("Sets a collection of BlendShapes (an expression), which you can create in the Character Component Inspector of the actor.")]
	public class CharacterExpression : ActorActionClip<Slate.Character> // TypeDefIndex: 84888
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
		public override string info { get; } // 0x000000018CE5CC60-0x000000018CE5CD14 
		public override bool isValid { get; } // 0x000000018CE5CD14-0x000000018CE5CD78 
		public override float length { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override float blendIn { get; set; } // 0x0000000187234790-0x00000001872347A0 0x000000018723F3C0-0x000000018723F3D0
		public override float blendOut { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
		public override bool canCrossBlend { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		public CharacterExpression(); // 0x000000018CE5CBFC-0x000000018CE5CC60
	
		// Methods
		private BlendShapeGroup ResolveExpression(); // 0x000000018CE5CB70-0x000000018CE5CBFC
		protected override void OnEnter(); // 0x000000018CE5CA84-0x000000018CE5CAB8
		protected override void OnUpdate(float deltaTime); // 0x000000018CE5CAFC-0x000000018CE5CB70
		protected override void OnReverse(); // 0x000000018CE5CAB8-0x000000018CE5CAFC
	}

	[Category("Character")]
	[Description("This ActionClip is recommended to be used above an animation track.")]
	[Name("Character Head Look At")]
	public class CharacterLookAt : ActorActionClip<Slate.Character> // TypeDefIndex: 84889
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
		public Vector3 targetPositionVector { get; set; } // 0x000000018CE5D5B8-0x000000018CE5D5EC 0x0000000187257D40-0x0000000187257D50
		public override string info { get; } // 0x000000018CE5D460-0x000000018CE5D4D8 
		public override bool isValid { get; } // 0x000000018CE5D4D8-0x000000018CE5D5B8 
		public override float length { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override float blendIn { get; set; } // 0x0000000187234790-0x00000001872347A0 0x000000018723F3C0-0x000000018723F3D0
		public override float blendOut { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
	
		// Constructors
		public CharacterLookAt(); // 0x000000018CE5D408-0x000000018CE5D460
	
		// Methods
		protected override void OnCreate(); // 0x000000018CE5CDC4-0x000000018CE5CE90
		protected override void OnAfterValidate(); // 0x000000018CE5CD78-0x000000018CE5CDC4
		protected override void OnEnter(); // 0x000000018CE5CE90-0x000000018CE5CF30
		protected override void OnUpdate(float time); // 0x000000018CE5CFD0-0x000000018CE5D408
		protected override void OnReverse(); // 0x000000018CE5CF30-0x000000018CE5CFD0
	}

	public abstract class SendMessage<T> : SendMessage // TypeDefIndex: 84890
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
	public class SendMessage : ActorActionClip // TypeDefIndex: 84891
	{
		// Fields
		[Required]
		[Tooltip("The method name to call")]
		public string message; // 0x40
		[Tooltip("If multiple components of the same type exist on gameobject you can specify the index of the component to use here. Leave at -1 to call all found instances")]
		public int componentIndex; // 0x48
	
		// Properties
		public override string info { get; } // 0x000000018CE69258-0x000000018CE69298 
		public override bool isValid { get; } // 0x000000018B73449C-0x000000018B7344B4 
		public virtual System.Type parameterType { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	
		// Constructors
		public SendMessage(); // 0x000000018CE6923C-0x000000018CE69258
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE68F70-0x000000018CE6923C
	}

	public class SendMessageBoolean : SendMessage<bool> // TypeDefIndex: 84892
	{
		// Constructors
		public SendMessageBoolean(); // 0x000000018CE68E6C-0x000000018CE68EA0
	}

	public class SendMessageFloat : SendMessage<float> // TypeDefIndex: 84893
	{
		// Constructors
		public SendMessageFloat(); // 0x000000018CE68EA0-0x000000018CE68ED4
	}

	public class SendMessageInteger : SendMessage<int> // TypeDefIndex: 84894
	{
		// Constructors
		public SendMessageInteger(); // 0x000000018CE68ED4-0x000000018CE68F08
	}

	public class SendMessageObject : SendMessage<UnityEngine.Object> // TypeDefIndex: 84895
	{
		// Constructors
		public SendMessageObject(); // 0x000000018CE68F08-0x000000018CE68F3C
	}

	public class SendMessageString : SendMessage<string> // TypeDefIndex: 84896
	{
		// Constructors
		public SendMessageString(); // 0x000000018CE68F3C-0x000000018CE68F70
	}

	[Category("GameObject")]
	[Description("Set or animate the actor gameobject visibility.")]
	public class AnimateActorVisibility : ActorActionClip // TypeDefIndex: 84897
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[AnimatableParameter]
		public bool visible; // 0x44
		private bool wasVisible; // 0x45
	
		// Properties
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
	
		// Constructors
		public AnimateActorVisibility(); // 0x000000018CE59AF4-0x000000018CE59B10
	
		// Methods
		protected override void OnCreate(); // 0x000000018CE59A34-0x000000018CE59A64
		protected override void OnEnter(); // 0x000000018CE59A64-0x000000018CE59A94
		protected override void OnUpdate(float time); // 0x000000018CE59AC4-0x000000018CE59AF4
		protected override void OnReverse(); // 0x000000018CE59A94-0x000000018CE59AC4
	}

	[Category("GameObject")]
	[Description("Make the actor target for the currently active Dynamic Shot Controller (if used by the current active Camera Shot in the cutscene).")]
	public class MakeCameraTarget : ActorActionClip // TypeDefIndex: 84898
	{
		// Fields
		public bool setTransposerTarget; // 0x40
		public bool setComposerTarget; // 0x41
		private Transform wasTransposerTarget; // 0x48
		private Transform wasComposerTarget; // 0x50
	
		// Constructors
		public MakeCameraTarget(); // 0x000000018CE63F74-0x000000018CE63F90
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE63CC8-0x000000018CE63E54
		protected override void OnReverse(); // 0x000000018CE63E54-0x000000018CE63F74
	}

	[Category("GameObject")]
	[Description("Set the actor active state (visibility) for a period of time or permantentely if length is zero.")]
	public class SetActorActiveState : ActorActionClip // TypeDefIndex: 84899
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
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override string info { get; } // 0x000000018CE69424-0x000000018CE69484 
	
		// Constructors
		public SetActorActiveState(); // 0x000000018CE69408-0x000000018CE69424
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE69298-0x000000018CE69360
		protected override void OnExit(); // 0x000000018CE69360-0x000000018CE6939C
		protected override void OnReverseEnter(); // 0x000000018CE6939C-0x000000018CE693D8
		protected override void OnReverse(); // 0x000000018CE693D8-0x000000018CE69408
	}

	[Category("GameObject")]
	[Obsolete("Use \'Set Actor Visibility\'")]
	public class SetActorVisibilityTemporary : ActorActionClip // TypeDefIndex: 84900
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
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override string info { get; } // 0x000000018CE694A8-0x000000018CE69508 
	
		// Constructors
		public SetActorVisibilityTemporary(); // 0x000000018CE69484-0x000000018CE694A8
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE69298-0x000000018CE69360
		protected override void OnExit(); // 0x000000018CE69360-0x000000018CE6939C
		protected override void OnReverseEnter(); // 0x000000018CE6939C-0x000000018CE693D8
		protected override void OnReverse(); // 0x000000018CE693D8-0x000000018CE69408
	}

	[Category("GameObject")]
	[Description("The selected Behaviours will be Enabled or Disable (based on state option) on the actor if they are not already")]
	public class SetBehavioursActiveState : ActorActionClip // TypeDefIndex: 84901
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
		public override string info { get; } // 0x000000018CE69E64-0x000000018CE69F24 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
	
		// Constructors
		public SetBehavioursActiveState(); // 0x000000018CE69DDC-0x000000018CE69E64
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE69508-0x000000018CE69834
		protected override void OnExit(); // 0x000000018CE69834-0x000000018CE699FC
		protected override void OnReverseEnter(); // 0x000000018CE699FC-0x000000018CE69BC4
		protected override void OnReverse(); // 0x000000018CE69BC4-0x000000018CE69D64
		[CompilerGenerated]
		private bool _OnEnter_b__11_0(UnityEngine.Behaviour c); // 0x000000018CE69D64-0x000000018CE69DDC
	}

	[Category("Paths")]
	[Description("Animate the actor\'s position and look at target position on a Path. For example, a \'PositionOnPath\' value of 0 means start of path, while a value of 1 means end of path.")]
	public class AnimateOnPath : ActorActionClip // TypeDefIndex: 84902
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
		public override string info { get; } // 0x000000018CE5AAAC-0x000000018CE5AB4C 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override bool isValid { get; } // 0x000000018CE5AB4C-0x000000018CE5AB9C 
	
		// Constructors
		public AnimateOnPath(); // 0x000000018CE5AA88-0x000000018CE5AAAC
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE5A658-0x000000018CE5A6F8
		protected override void OnUpdate(float time); // 0x000000018CE5A784-0x000000018CE5AA88
		protected override void OnReverse(); // 0x000000018CE5A6F8-0x000000018CE5A784
	}

	[Category("Paths")]
	[Description("Put the actor on a path to follow for the duration of the clip from path start to path end, or by using speed if \'Use Speed\' is true. If you want the actor to look ahead of the path, set \'Look Ahead\' to any value other than 0.")]
	public class FollowPath : ActorActionClip // TypeDefIndex: 84903
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
		public override string info { get; } // 0x000000018CE629A8-0x000000018CE62A48 
		public override float length { get; set; } // 0x000000018CE62A98-0x000000018CE62B24 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override bool isValid { get; } // 0x000000018CE62A48-0x000000018CE62A98 
	
		// Constructors
		public FollowPath(); // 0x000000018CE62960-0x000000018CE629A8
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE624DC-0x000000018CE62580
		protected override void OnUpdate(float time); // 0x000000018CE62610-0x000000018CE62960
		protected override void OnReverse(); // 0x000000018CE62580-0x000000018CE62610
	}

	[Category("Paths")]
	[Description("For this clip to work you only need to have a baked NavMesh. The actor does NOT need, or use a NavMeshAgent Component. The length of the clip is determined by the path\'s length and the speed parameter set, while the Blend In parameter is used only for the initial look ahead blending")]
	public class PathfindFromTo : ActorActionClip // TypeDefIndex: 84904
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
		public override string info { get; } // 0x000000018CE65498-0x000000018CE654E0 
		public override float length { get; } // 0x000000018CE654E0-0x000000018CE65524 
		public override float blendIn { get; set; } // 0x000000018CE65468-0x000000018CE65498 0x0000000187233120-0x0000000187233130
	
		// Constructors
		public PathfindFromTo(); // 0x000000018CE65444-0x000000018CE65468
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE64B34-0x000000018CE64CE8
		protected override void OnUpdate(float time); // 0x000000018CE64D9C-0x000000018CE651E0
		protected override void OnReverse(); // 0x000000018CE64CE8-0x000000018CE64D9C
		private void TryCalculatePath(); // 0x000000018CE651E0-0x000000018CE65444
	}

	[Category("Paths")]
	[Description("For this clip to work you only need to have a baked NavMesh. The actor does NOT need, or use a NavMeshAgent Component. The length of the clip is determined by the path\'s length and the speed parameter set, while the Blend In parameter is used only for the initial look ahead blending")]
	public class PathfindTo : ActorActionClip // TypeDefIndex: 84905
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
		public override string info { get; } // 0x000000018CE65E54-0x000000018CE65E9C 
		public override float length { get; } // 0x000000018CE65E9C-0x000000018CE65EDC 
		public override float blendIn { get; set; } // 0x000000018CE65468-0x000000018CE65498 0x0000000187233120-0x0000000187233130
	
		// Constructors
		public PathfindTo(); // 0x000000018CE65444-0x000000018CE65468
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE65524-0x000000018CE656C4
		protected override void OnUpdate(float time); // 0x000000018CE65764-0x000000018CE65B90
		protected override void OnReverse(); // 0x000000018CE656C4-0x000000018CE65764
		private void TryCalculatePath(); // 0x000000018CE65B90-0x000000018CE65E54
	}

	[Category("Renderer")]
	public class AnimateMaterialColor : ActorActionClip<Renderer> // TypeDefIndex: 84906
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
		public override string info { get; } // 0x000000018CE5A14C-0x000000018CE5A18C 
		public override bool isValid { get; } // 0x000000018CE5A18C-0x000000018CE5A278 
		public override float length { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override float blendIn { get; set; } // 0x0000000187234790-0x00000001872347A0 0x000000018723F3C0-0x000000018723F3D0
		public override float blendOut { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
		private Material targetMaterial { get; } // 0x000000018CE5A278-0x000000018CE5A320 
	
		// Constructors
		public AnimateMaterialColor(); // 0x000000018CE5A0D0-0x000000018CE5A14C
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE5A010-0x000000018CE5A018
		protected override void OnReverseEnter(); // 0x000000018CE5A010-0x000000018CE5A018
		protected override void OnUpdate(float time); // 0x000000018CE5A020-0x000000018CE5A0D0
		protected override void OnReverse(); // 0x000000018CE5A018-0x000000018CE5A020
		protected override void OnExit(); // 0x000000018CE5A018-0x000000018CE5A020
		private void DoSet(); // 0x000000018CE59FD4-0x000000018CE5A010
		private void DoReset(); // 0x000000018CE59F94-0x000000018CE59FD4
	}

	[Category("Renderer")]
	public class AnimateMaterialFloat : ActorActionClip<Renderer> // TypeDefIndex: 84907
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
		public override string info { get; } // 0x000000018CE5A484-0x000000018CE5A4C4 
		public override bool isValid { get; } // 0x000000018CE5A4C4-0x000000018CE5A5B0 
		public override float length { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override float blendIn { get; set; } // 0x0000000187234790-0x00000001872347A0 0x000000018723F3C0-0x000000018723F3D0
		public override float blendOut { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
		private Material targetMaterial { get; } // 0x000000018CE5A5B0-0x000000018CE5A658 
	
		// Constructors
		public AnimateMaterialFloat(); // 0x000000018CE5A420-0x000000018CE5A484
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE5A38C-0x000000018CE5A394
		protected override void OnReverseEnter(); // 0x000000018CE5A38C-0x000000018CE5A394
		protected override void OnUpdate(float time); // 0x000000018CE5A39C-0x000000018CE5A420
		protected override void OnReverse(); // 0x000000018CE5A394-0x000000018CE5A39C
		protected override void OnExit(); // 0x000000018CE5A394-0x000000018CE5A39C
		private void DoSet(); // 0x000000018CE5A354-0x000000018CE5A38C
		private void DoReset(); // 0x000000018CE5A320-0x000000018CE5A354
	}

	[Category("Renderer")]
	[Description("Animate a material\'s texture offset and scale over time")]
	public class AnimateMaterialTexture : ActorActionClip<Renderer> // TypeDefIndex: 84908
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
		public override string info { get; } // 0x000000018CE6FAC4-0x000000018CE6FB04 
		public override bool isValid { get; } // 0x000000018CE6FB04-0x000000018CE6FBF0 
		public override float length { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override float blendIn { get; set; } // 0x0000000187234790-0x00000001872347A0 0x000000018723F3C0-0x000000018723F3D0
		public override float blendOut { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
		private Material targetMaterial { get; } // 0x000000018CE6FBF0-0x000000018CE6FC98 
	
		// Constructors
		public AnimateMaterialTexture(); // 0x000000018CE6FA50-0x000000018CE6FAC4
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE6F89C-0x000000018CE6F8A4
		protected override void OnReverseEnter(); // 0x000000018CE6F89C-0x000000018CE6F8A4
		protected override void OnUpdate(float time); // 0x000000018CE6F8AC-0x000000018CE6FA50
		protected override void OnReverse(); // 0x000000018CE6F8A4-0x000000018CE6F8AC
		protected override void OnExit(); // 0x000000018CE6F8A4-0x000000018CE6F8AC
		private void DoSet(); // 0x000000018CE6F814-0x000000018CE6F89C
		private void DoReset(); // 0x000000018CE6F7A0-0x000000018CE6F814
	}

	[Category("Renderer")]
	[Description("Scroll/Offset the material texture. Usefull for scrolling backgrounds, screens, or other similar effects.")]
	public class ScrollMaterialTexture : ActorActionClip<Renderer> // TypeDefIndex: 84909
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
		public override string info { get; } // 0x000000018CE7692C-0x000000018CE76990 
		public override bool isValid { get; } // 0x000000018CE76990-0x000000018CE76A3C 
		public override float length { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override float blendIn { get; } // 0x000000018CE7080C-0x000000018CE7081C 
		private Material targetMaterial { get; } // 0x000000018CE76A3C-0x000000018CE76AE4 
	
		// Constructors
		public ScrollMaterialTexture(); // 0x000000018CE768C8-0x000000018CE7692C
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE766BC-0x000000018CE76708
		protected override void OnUpdate(float time); // 0x000000018CE7674C-0x000000018CE768C8
		protected override void OnReverse(); // 0x000000018CE76708-0x000000018CE7674C
	}

	[Category("Renderer")]
	public class SetMaterial : ActorActionClip<Renderer> // TypeDefIndex: 84910
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		public Material material; // 0x50
		private Material sharedMat; // 0x58
		private bool temporary; // 0x60
	
		// Properties
		public override string info { get; } // 0x000000018CE77198-0x000000018CE77238 
		public override float length { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
	
		// Constructors
		public SetMaterial(); // 0x000000018CE77158-0x000000018CE77198
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE770FC-0x000000018CE77130
		protected override void OnReverseEnter(); // 0x000000018CE77140-0x000000018CE77150
		protected override void OnReverse(); // 0x000000018CE77150-0x000000018CE77158
		protected override void OnExit(); // 0x000000018CE77130-0x000000018CE77140
		private void DoSet(); // 0x000000018CE7707C-0x000000018CE770FC
		private void DoReset(); // 0x000000018CE77028-0x000000018CE7707C
	}

	[Category("Renderer")]
	public class SetMaterialTexture : ActorActionClip<Renderer> // TypeDefIndex: 84911
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
		public override string info { get; } // 0x000000018CE76DF4-0x000000018CE76E94 
		public override bool isValid { get; } // 0x000000018CE76E94-0x000000018CE76F80 
		public override float length { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		private Material targetMaterial { get; } // 0x000000018CE76F80-0x000000018CE77028 
	
		// Constructors
		public SetMaterialTexture(); // 0x000000018CE76DA4-0x000000018CE76DF4
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE76D48-0x000000018CE76D7C
		protected override void OnReverseEnter(); // 0x000000018CE76D8C-0x000000018CE76D9C
		protected override void OnReverse(); // 0x000000018CE76D9C-0x000000018CE76DA4
		protected override void OnExit(); // 0x000000018CE76D7C-0x000000018CE76D8C
		private void DoSet(); // 0x000000018CE76CE8-0x000000018CE76D48
		private void DoReset(); // 0x000000018CE76CB4-0x000000018CE76CE8
	}

	[Category("Sprites")]
	[Description("Change sorting layer and order for sprite renderer.")]
	public class SetSortingLayer : ActorActionClip<SpriteRenderer> // TypeDefIndex: 84912
	{
		// Fields
		public int sortingOrder; // 0x48
		[SortingLayer]
		public int sortingLayerID; // 0x4C
		private string _lastLayer; // 0x50
		private int _lastOrder; // 0x58
	
		// Properties
		public override string info { get; } // 0x000000018CE77824-0x000000018CE778DC 
	
		// Constructors
		public SetSortingLayer(); // 0x000000018CE777E4-0x000000018CE77824
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE776A8-0x000000018CE7776C
		protected override void OnReverse(); // 0x000000018CE7776C-0x000000018CE777E4
	}

	[Category("Sprites")]
	public class SetSprite : ActorActionClip<SpriteRenderer> // TypeDefIndex: 84913
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
		public override string info { get; } // 0x000000018CE77C7C-0x000000018CE77CFC 
	
		// Constructors
		public SetSprite(); // 0x000000018CE77C24-0x000000018CE77C7C
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE778DC-0x000000018CE77B00
		protected override void OnReverse(); // 0x000000018CE77B00-0x000000018CE77C24
	}

	[Category("Sprites")]
	[Description("Animate a sprite object by altering between different sprites in order")]
	public class SpriteFlipbook : ActorActionClip<SpriteRenderer> // TypeDefIndex: 84914
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
		public override string info { get; } // 0x000000018CE788CC-0x000000018CE7898C 
		public override float length { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override bool isValid { get; } // 0x000000018CE7898C-0x000000018CE78A20 
	
		// Constructors
		public SpriteFlipbook(); // 0x000000018CE78834-0x000000018CE788CC
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE785CC-0x000000018CE78628
		protected override void OnUpdate(float deltaTime); // 0x000000018CE786D8-0x000000018CE78834
		protected override void OnExit(); // 0x000000018CE78628-0x000000018CE78684
		protected override void OnReverse(); // 0x000000018CE78684-0x000000018CE786D8
	}

	[Category("Transform")]
	[Description("Attach an object to a child transform of the actor (or the actor itself) either permantentely or temporary if length is greater than zero.")]
	public class AttachObject : ActorActionClip // TypeDefIndex: 84915
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
		public override bool isValid { get; } // 0x000000018CE705B4-0x000000018CE70604 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
	
		// Constructors
		public AttachObject(); // 0x000000018CE7027C-0x000000018CE702B0
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE7052C-0x000000018CE70560
		protected override void OnReverseEnter(); // 0x000000018CE70574-0x000000018CE70588
		protected override void OnExit(); // 0x000000018CE70560-0x000000018CE70574
		protected override void OnReverse(); // 0x000000018CE70588-0x000000018CE70590
		private void Do(); // 0x000000018CE70300-0x000000018CE7052C
		private void UnDo(); // 0x000000018CE70590-0x000000018CE705B4
	}

	[Category("Transform")]
	[Description("Instantiate and attach a prefab object to a child transform of the actor (or the actor itself) either permantentely or temporary if length is greater than zero.")]
	public class AttachObjectPrefab : ActorActionClip // TypeDefIndex: 84916
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
		public override bool isValid { get; } // 0x000000018CE702B0-0x000000018CE70300 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
	
		// Constructors
		public AttachObjectPrefab(); // 0x000000018CE7027C-0x000000018CE702B0
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE70174-0x000000018CE701A8
		protected override void OnReverseEnter(); // 0x000000018CE701BC-0x000000018CE701D0
		protected override void OnExit(); // 0x000000018CE701A8-0x000000018CE701BC
		protected override void OnReverse(); // 0x000000018CE701D0-0x000000018CE701D8
		private void Do(); // 0x000000018CE6FF68-0x000000018CE70174
		private void UnDo(); // 0x000000018CE701D8-0x000000018CE7027C
	}

	[Category("Transform")]
	[Description("Rotate actor transform to look at specified target position for a period of time or permanentely if blend out is zero")]
	public class LookAt : ActorActionClip // TypeDefIndex: 84917
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
		public Vector3 targetPositionVector { get; set; } // 0x000000018CE71F7C-0x000000018CE71FB0 0x0000000187254130-0x0000000187254140
		public override string info { get; } // 0x000000018CE71F04-0x000000018CE71F7C 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
	
		// Constructors
		public LookAt(); // 0x000000018CE71ED0-0x000000018CE71F04
	
		// Methods
		protected override void OnCreate(); // 0x000000018CE71BE0-0x000000018CE71C1C
		protected override void OnAfterValidate(); // 0x000000018CE71B94-0x000000018CE71BE0
		protected override void OnEnter(); // 0x000000018CE71C1C-0x000000018CE71C68
		protected override void OnUpdate(float deltaTime); // 0x000000018CE71CB4-0x000000018CE71ED0
		protected override void OnReverse(); // 0x000000018CE71C68-0x000000018CE71CB4
	}

	[Category("Transform")]
	[Description("Smoothly match the selected transforms of the actor and to the target for a period of time and then back again to their original values. If you don\'t want to smooth back to the original values, set BlendOut to 0.")]
	public class MatchTransformsToTarget : ActorActionClip // TypeDefIndex: 84918
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
		public override string info { get; } // 0x000000018CE726BC-0x000000018CE7275C 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override bool isValid { get; } // 0x000000018CE7275C-0x000000018CE727AC 
	
		// Constructors
		public MatchTransformsToTarget(); // 0x000000018CE72680-0x000000018CE726BC
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE71FB0-0x000000018CE7208C
		protected override void OnUpdate(float deltaTime); // 0x000000018CE72170-0x000000018CE72680
		protected override void OnReverse(); // 0x000000018CE7208C-0x000000018CE72170
	}

	[Category("Transform")]
	public class Noise : ActorActionClip // TypeDefIndex: 84919
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
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
	
		// Constructors
		public Noise(); // 0x000000018CE72DEC-0x000000018CE72E38
	
		// Methods
		protected override void OnCreate(); // 0x000000018CE72B4C-0x000000018CE72BC4
		protected override void OnEnter(); // 0x000000018CE72BC4-0x000000018CE72C14
		protected override void OnUpdate(float time, float previousTime); // 0x000000018CE72C14-0x000000018CE72DEC
	}

	[Category("Transform")]
	[Description("Rotate the actor around target position or object by specified degrees and optionaly per second.")]
	public class RotateAround : ActorActionClip // TypeDefIndex: 84920
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
		public Vector3 targetPositionVector { get; set; } // 0x000000018CE71F7C-0x000000018CE71FB0 0x0000000187254130-0x0000000187254140
		public override string info { get; } // 0x000000018CE75354-0x000000018CE75440 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; } // 0x000000018CE7080C-0x000000018CE7081C 
	
		// Constructors
		public RotateAround(); // 0x000000018CE75314-0x000000018CE75354
	
		// Methods
		protected override void OnAfterValidate(); // 0x000000018CE74D50-0x000000018CE74D9C
		protected override void OnEnter(); // 0x000000018CE74D9C-0x000000018CE74EAC
		protected override void OnUpdate(float time); // 0x000000018CE74F3C-0x000000018CE75314
		protected override void OnReverse(); // 0x000000018CE74EAC-0x000000018CE74F3C
	}

	[Category("Transform")]
	[Description("Rotate the actor by specified degrees and optionaly per second")]
	public class RotateBy : ActorActionClip // TypeDefIndex: 84921
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
		public override string info { get; } // 0x000000018CE75738-0x000000018CE757E8 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; } // 0x000000018CE7080C-0x000000018CE7081C 
	
		// Constructors
		public RotateBy(); // 0x000000018CE756F8-0x000000018CE75738
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE75440-0x000000018CE754C4
		protected override void OnUpdate(float time); // 0x000000018CE75554-0x000000018CE756F8
		protected override void OnReverse(); // 0x000000018CE754C4-0x000000018CE75554
	}

	[Category("Transform")]
	public class RotateTo : ActorActionClip // TypeDefIndex: 84922
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		public Vector3 targetRotation; // 0x44
		public Slate.EaseType interpolation; // 0x50
		private Vector3 originalRot; // 0x54
	
		// Properties
		public override string info { get; } // 0x000000018CE759F0-0x000000018CE75A5C 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; } // 0x000000018CE7080C-0x000000018CE7081C 
	
		// Constructors
		public RotateTo(); // 0x000000018CE6FDC4-0x000000018CE6FDE8
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE757E8-0x000000018CE75838
		protected override void OnUpdate(float deltaTime); // 0x000000018CE7588C-0x000000018CE759F0
		protected override void OnReverse(); // 0x000000018CE75838-0x000000018CE7588C
	}

	[Category("Transform")]
	[Description("Scale the actor by specified value and optionlay per second")]
	public class ScaleBy : ActorActionClip // TypeDefIndex: 84923
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
		public override string info { get; } // 0x000000018CE76290-0x000000018CE76340 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; } // 0x000000018CE7080C-0x000000018CE7081C 
	
		// Constructors
		public ScaleBy(); // 0x000000018CE76254-0x000000018CE76290
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE76030-0x000000018CE76080
		protected override void OnUpdate(float deltaTime); // 0x000000018CE760D4-0x000000018CE76254
		protected override void OnReverse(); // 0x000000018CE76080-0x000000018CE760D4
	}

	[Category("Transform")]
	public class ScaleTo : ActorActionClip // TypeDefIndex: 84924
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		public Vector3 targetScale; // 0x44
		public Slate.EaseType interpolation; // 0x50
		private Vector3 originalPos; // 0x54
	
		// Properties
		public override string info { get; } // 0x000000018CE76548-0x000000018CE765B4 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; } // 0x000000018CE7080C-0x000000018CE7081C 
	
		// Constructors
		public ScaleTo(); // 0x000000018CE6FDC4-0x000000018CE6FDE8
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE76340-0x000000018CE76390
		protected override void OnUpdate(float deltaTime); // 0x000000018CE763E4-0x000000018CE76548
		protected override void OnReverse(); // 0x000000018CE76390-0x000000018CE763E4
	}

	[Category("Transform")]
	[Obsolete("Use Set Parent")]
	public class SetParentTemporary : ActorActionClip // TypeDefIndex: 84925
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
		public override string info { get; } // 0x000000018CE77608-0x000000018CE776A8 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
	
		// Constructors
		public SetParentTemporary(); // 0x000000018CE59AF4-0x000000018CE59B10
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE77238-0x000000018CE77344
		protected override void OnUpdate(float deltaTime); // 0x000000018CE77454-0x000000018CE77608
		protected override void OnReverse(); // 0x000000018CE77344-0x000000018CE77454
	}

	[Category("Transform")]
	[Description("Set the parent of the actor gameobject temporarily, or permanently if length is zero")]
	public class SetTransformParent : ActorActionClip // TypeDefIndex: 84926
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
		public override string info { get; } // 0x000000018CE77FBC-0x000000018CE7805C 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
	
		// Constructors
		public SetTransformParent(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE77F58-0x000000018CE77F8C
		protected override void OnReverseEnter(); // 0x000000018CE77FA0-0x000000018CE77FB4
		protected override void OnExit(); // 0x000000018CE77F8C-0x000000018CE77FA0
		protected override void OnReverse(); // 0x000000018CE77FB4-0x000000018CE77FBC
		private void Do(); // 0x000000018CE77CFC-0x000000018CE77F58
		private void UnDo(); // 0x000000018CE77344-0x000000018CE77454
	}

	[Category("Transform")]
	[Description("Instantely set the transforms of the actor.")]
	public class SetTransformValues : ActorActionClip // TypeDefIndex: 84927
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
		public SetTransformValues(); // 0x000000018CE7824C-0x000000018CE78280
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE7805C-0x000000018CE7822C
		protected override void OnReverse(); // 0x000000018CE7822C-0x000000018CE7824C
	}

	[Category("Transform")]
	[Description("Grounds the actor gameobject to the nearest collider object beneath it up to the set Max Distance")]
	public class SimpleGrounder : ActorActionClip // TypeDefIndex: 84928
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
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
	
		// Constructors
		public SimpleGrounder(); // 0x000000018CE785A0-0x000000018CE785CC
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE78280-0x000000018CE782D8
		protected override void OnUpdate(float time); // 0x000000018CE78330-0x000000018CE785A0
		protected override void OnReverse(); // 0x000000018CE782D8-0x000000018CE78330
	}

	[Category("Transform")]
	[Description("Translate the actor by specified value and optionaly per second")]
	public class TranslateBy : ActorActionClip // TypeDefIndex: 84929
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
		public override string info { get; } // 0x000000018CE79284-0x000000018CE79334 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; } // 0x000000018CE7080C-0x000000018CE7081C 
	
		// Constructors
		public TranslateBy(); // 0x000000018CE79244-0x000000018CE79284
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE79020-0x000000018CE79070
		protected override void OnUpdate(float deltaTime); // 0x000000018CE790C4-0x000000018CE79244
		protected override void OnReverse(); // 0x000000018CE79070-0x000000018CE790C4
	}

	[Category("Transform")]
	public class TranslateTo : ActorActionClip // TypeDefIndex: 84930
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
		public override string info { get; } // 0x000000018CE79580-0x000000018CE795EC 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; } // 0x000000018CE7080C-0x000000018CE7081C 
	
		// Constructors
		public TranslateTo(); // 0x000000018CE7955C-0x000000018CE79580
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE79334-0x000000018CE79384
		protected override void OnUpdate(float time); // 0x000000018CE793D8-0x000000018CE7955C
		protected override void OnReverse(); // 0x000000018CE79384-0x000000018CE793D8
	}

	[Category("Composition")]
	[Description("Additive load a Scene for a duration of time, or permanentely if length is zero.\n\nIf \'Update Root Cutscenes\' is true, all root cutscenes objects of that scene will also be updated for the duration of the clip with an optional time offset provided.")]
	public class AdditiveScene : DirectorActionClip, ISubClipContainable // TypeDefIndex: 84931
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
		float ISubClipContainable.subClipOffset { get; set; } // 0x000000018723E550-0x000000018723E560 0x000000018723E540-0x000000018723E550
		float ISubClipContainable.subClipLength { get; } // 0x0000000187234CD0-0x0000000187234CE0 
		float ISubClipContainable.subClipSpeed { get; } // 0x0000000187234CD0-0x0000000187234CE0 
		public override bool isValid { get; } // 0x000000018CE6DB00-0x000000018CE6DB18 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		new string IDirectable.name { get; } // 0x0000000187835674-0x000000018783567C 
	
		// Constructors
		public AdditiveScene(); // 0x000000018CE6DAE0-0x000000018CE6DB00
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE6D964-0x000000018CE6D998
		protected override void OnReverseEnter(); // 0x000000018CE6D9CC-0x000000018CE6D9E0
		protected override void OnUpdate(float time); // 0x000000018CE6DA04-0x000000018CE6DAE0
		protected override void OnExit(); // 0x000000018CE6D998-0x000000018CE6D9CC
		protected override void OnReverse(); // 0x000000018CE6D9E0-0x000000018CE6DA04
		private void Activate(); // 0x000000018CE6D288-0x000000018CE6D31C
		private void Deactivate(); // 0x000000018CE6D3A0-0x000000018CE6D414
		private string CleanPath(string path); // 0x000000018CE6D31C-0x000000018CE6D3A0
		private void InitializeSubSceneCutscenes(); // 0x000000018CE6D5E8-0x000000018CE6D964
		private void DenitializeSubSceneCutscenes(bool forward); // 0x000000018CE6D414-0x000000018CE6D5E8
	}

	[Category("Composition")]
	[Description("SubCutscenes are used for organization. Notice that the CameraTrack of the SubCutscene is ignored if this Cutscene already has an active CameraTrack.")]
	public class SubCutscene : DirectorActionClip, ISubClipContainable // TypeDefIndex: 84932
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
		public override string info { get; } // 0x000000018CE78E04-0x000000018CE78ECC 
		public override bool isValid { get; } // 0x000000018CE78ECC-0x000000018CE78F38 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public new GameObject actor { get; } // 0x000000018CE78DC0-0x000000018CE78E04 
		float ISubClipContainable.subClipOffset { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
		float ISubClipContainable.subClipLength { get; } // 0x000000018CE78D48-0x000000018CE78D84 
		float ISubClipContainable.subClipSpeed { get; } // 0x000000018CE78D84-0x000000018CE78DC0 
		new string IDirectable.name { get; } // 0x0000000187835674-0x000000018783567C 
	
		// Constructors
		public SubCutscene(); // 0x000000018CE59AF4-0x000000018CE59B10
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE78A20-0x000000018CE78AE8
		protected override void OnReverseEnter(); // 0x000000018CE78B90-0x000000018CE78C5C
		protected override void OnExit(); // 0x000000018CE78AE8-0x000000018CE78B90
		protected override void OnReverse(); // 0x000000018CE78C5C-0x000000018CE78CFC
		protected override void OnUpdate(float time, float previousTime); // 0x000000018CE78CFC-0x000000018CE78D48
	}

	[Category("Control")]
	[Description("Destroy all gameobjects in the list (PlayMode only).\nYou should NOT use this clip to destroy actors.")]
	public class DestroyGameObjects : DirectorActionClip // TypeDefIndex: 84933
	{
		// Fields
		public List<GameObject> targetObjects; // 0x40
	
		// Properties
		public override string info { get; } // 0x000000018CE70B18-0x000000018CE70B94 
	
		// Constructors
		public DestroyGameObjects(); // 0x000000018CE70A98-0x000000018CE70B18
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE70940-0x000000018CE70A98
	}

	[Category("Control")]
	[Description("All gameobjects in the list will be disabled if not already")]
	[Name("Disable Game Objects")]
	public class DirectorDisableGameObjects : DirectorActionClip // TypeDefIndex: 84934
	{
		// Fields
		public List<GameObject> targetObjects; // 0x40
		private Dictionary<GameObject, bool> states; // 0x48
	
		// Properties
		public override string info { get; } // 0x000000018CE70F64-0x000000018CE70FE0 
	
		// Constructors
		public DirectorDisableGameObjects(); // 0x000000018CE70EE4-0x000000018CE70F64
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE70B94-0x000000018CE70D54
		protected override void OnReverse(); // 0x000000018CE70D54-0x000000018CE70EE4
	}

	[Category("Control")]
	[Description("All gameobjects in the list will be enabled if not already")]
	[Name("Enable Game Objects")]
	public class DirectorEnableGameObjects : DirectorActionClip // TypeDefIndex: 84935
	{
		// Fields
		public List<GameObject> targetObjects; // 0x40
		private Dictionary<GameObject, bool> states; // 0x48
	
		// Properties
		public override string info { get; } // 0x000000018CE713B0-0x000000018CE7142C 
	
		// Constructors
		public DirectorEnableGameObjects(); // 0x000000018CE71330-0x000000018CE713B0
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE70FE0-0x000000018CE711A0
		protected override void OnReverse(); // 0x000000018CE711A0-0x000000018CE71330
	}

	[Category("Control")]
	[Description("Instantiates an object with optional popup animation if BlendIn is higher than zero. You can optionaly \'popdown\' and destroy the object after a period of time, if you also set a BlendOut value higher than zero.")]
	public class InstantiateObject : DirectorActionClip // TypeDefIndex: 84936
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
		public override bool isValid { get; } // 0x000000018CE71B44-0x000000018CE71B94 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override string info { get; } // 0x000000018CE71AA4-0x000000018CE71B44 
		private new GameObject actor { get; } // 0x00000001828D49D0-0x00000001828D49E0 
	
		// Constructors
		public InstantiateObject(); // 0x000000018CE71A80-0x000000018CE71AA4
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE7152C-0x000000018CE7183C
		protected override void OnUpdate(float time); // 0x000000018CE7192C-0x000000018CE71A80
		protected override void OnExit(); // 0x000000018CE7183C-0x000000018CE718A0
		protected override void OnReverseEnter(); // 0x000000018CE718A0-0x000000018CE718D8
		protected override void OnReverse(); // 0x000000018CE718D8-0x000000018CE7192C
	}

	[Category("Control")]
	public class SampleParticleSystem : DirectorActionClip // TypeDefIndex: 84937
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
		public override string info { get; } // 0x000000018CE75D24-0x000000018CE75E3C 
		public override bool isValid { get; } // 0x000000018CE75E3C-0x000000018CE75E8C 
		public override float length { get; set; } // 0x000000018CE75E8C-0x000000018CE75F1C 0x0000000187233120-0x0000000187233130
		public override float blendOut { get; } // 0x000000018CE75C50-0x000000018CE75C98 
		private bool loop { get; } // 0x000000018CE75F1C-0x000000018CE75FA4 
		private float duration { get; } // 0x000000018CE75C98-0x000000018CE75D24 
		private float startLifetime { get; } // 0x000000018CE75FA4-0x000000018CE76030 
	
		// Constructors
		public SampleParticleSystem(); // 0x000000018CE75C30-0x000000018CE75C50
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE75A5C-0x000000018CE75A64
		protected override void OnReverseEnter(); // 0x000000018CE75A5C-0x000000018CE75A64
		protected override void OnExit(); // 0x000000018CE75A64-0x000000018CE75A6C
		protected override void OnReverse(); // 0x000000018CE75A64-0x000000018CE75A6C
		protected override void OnRootEnabled(); // 0x000000018CE75AB8-0x000000018CE75B08
		protected override void OnRootDisabled(); // 0x000000018CE75A6C-0x000000018CE75AB8
		private void Play(); // 0x000000018CE75B74-0x000000018CE75BF0
		protected override void OnUpdate(float time); // 0x000000018CE75B08-0x000000018CE75B74
		private void Stop(); // 0x000000018CE75BF0-0x000000018CE75C30
	}

	[Category("Control")]
	[Description("Will transit the given audio mixer to the given snapshot")]
	public class TransitAudioMixerSnapshot : DirectorActionClip // TypeDefIndex: 84938
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		public AudioMixer audioMixer; // 0x48
		public string snapshotName; // 0x50
		private AudioMixerSnapshot snapshot; // 0x58
	
		// Properties
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; } // 0x000000018CE7080C-0x000000018CE7081C 
		public override bool isValid { get; } // 0x000000018CE78FD0-0x000000018CE79020 
	
		// Constructors
		public TransitAudioMixerSnapshot(); // 0x000000018CE59AF4-0x000000018CE59B10
	
		// Methods
		protected override void OnReverseEnter(); // 0x000000018CE78FC8-0x000000018CE78FD0
		protected override void OnEnter(); // 0x000000018CE78FC8-0x000000018CE78FD0
		private void Do(); // 0x000000018CE78F38-0x000000018CE78FC8
	}

	[Category("Environment")]
	public class AnimateAmbientLighting : DirectorActionClip // TypeDefIndex: 84939
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
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
	
		// Constructors
		public AnimateAmbientLighting(); // 0x000000018CE59AF4-0x000000018CE59B10
	
		// Methods
		protected override void OnCreate(); // 0x000000018CE6DB18-0x000000018CE6DB48
		protected override void OnEnter(); // 0x000000018CE6DB48-0x000000018CE6DB78
		protected override void OnUpdate(float time); // 0x000000018CE6DBA8-0x000000018CE6DC28
		protected override void OnReverse(); // 0x000000018CE6DB78-0x000000018CE6DBA8
	}

	[Category("Environment")]
	public class AnimateFog : DirectorActionClip // TypeDefIndex: 84940
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
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
	
		// Constructors
		public AnimateFog(); // 0x000000018CE59AF4-0x000000018CE59B10
	
		// Methods
		protected override void OnCreate(); // 0x000000018CE6E03C-0x000000018CE6E084
		protected override void OnEnter(); // 0x000000018CE6E084-0x000000018CE6E0D0
		protected override void OnUpdate(float time); // 0x000000018CE6E11C-0x000000018CE6E1D0
		protected override void OnReverse(); // 0x000000018CE6E0D0-0x000000018CE6E11C
	}

	[Category("Environment")]
	[Description("Animate the gravity physics are using for Rigidbodies. This applies to both 2D and 3D Physics.")]
	public class AnimateGravity : DirectorActionClip // TypeDefIndex: 84941
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
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
	
		// Constructors
		public AnimateGravity(); // 0x000000018CE59AF4-0x000000018CE59B10
	
		// Methods
		protected override void OnCreate(); // 0x000000018CE6E1D0-0x000000018CE6E1FC
		protected override void OnEnter(); // 0x000000018CE6E1FC-0x000000018CE6E228
		protected override void OnUpdate(float time); // 0x000000018CE6E2AC-0x000000018CE6E388
		protected override void OnReverse(); // 0x000000018CE6E228-0x000000018CE6E2AC
	}

	[Category("Environment")]
	public class AnimateTimeScale : DirectorActionClip // TypeDefIndex: 84942
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
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
	
		// Constructors
		public AnimateTimeScale(); // 0x000000018CE6FDC4-0x000000018CE6FDE8
	
		// Methods
		protected override void OnCreate(); // 0x000000018CE6FDE8-0x000000018CE6FE04
		protected override void OnEnter(); // 0x000000018CE6FE04-0x000000018CE6FE20
		protected override void OnUpdate(float time); // 0x000000018CE6FE2C-0x000000018CE6FEA0
		protected override void OnReverse(); // 0x000000018CE6FE20-0x000000018CE6FE2C
	}

	[Category("Environment")]
	[Description("A quick way to create a slow-motion time effect.")]
	[Obsolete]
	public class EasySlowMotion : DirectorActionClip // TypeDefIndex: 84943
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
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override string info { get; } // 0x000000018CE714D0-0x000000018CE7152C 
	
		// Constructors
		public EasySlowMotion(); // 0x000000018CE71498-0x000000018CE714D0
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE6FE04-0x000000018CE6FE20
		protected override void OnUpdate(float deltaTime); // 0x000000018CE7142C-0x000000018CE71498
		protected override void OnReverse(); // 0x000000018CE6FE20-0x000000018CE6FE2C
	}

	[Category("Events")]
	[Description("Raise a Unity Event when the time is moving forwards and another when the time is moving backwards. This is helpfull if you want to use these events with UI to reverse their state, both in runtime and in editor.")]
	public class RaiseUnityEvent : DirectorActionClip // TypeDefIndex: 84944
	{
		// Fields
		public string customLabel; // 0x40
		public UnityEvent forwardEvent; // 0x48
		public UnityEvent reverseEvent; // 0x50
	
		// Properties
		public override string info { get; } // 0x000000018CE74B2C-0x000000018CE74D50 
	
		// Constructors
		public RaiseUnityEvent(); // 0x000000018CE74A90-0x000000018CE74B2C
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE74A50-0x000000018CE74A70
		protected override void OnReverse(); // 0x000000018CE74A70-0x000000018CE74A90
	}

	public abstract class SendGlobalMessage<T> : SendGlobalMessage // TypeDefIndex: 84945
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
	public class SendGlobalMessage : DirectorActionClip, IEvent // TypeDefIndex: 84946
	{
		// Fields
		[Required]
		public string message; // 0x40
	
		// Properties
		public override string info { get; } // 0x000000018CE76C74-0x000000018CE76CB4 
		public override bool isValid { get; } // 0x000000018B73449C-0x000000018B7344B4 
		string IEvent.name { get; } // 0x000000018226EEA0-0x000000018226EEB0 
	
		// Constructors
		public SendGlobalMessage(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		void IEvent.Invoke(); // 0x000000018CE76C64-0x000000018CE76C74
		protected override void OnEnter(); // 0x000000018CE76C24-0x000000018CE76C64
	}

	public class SendGlobalMessageBoolean : SendGlobalMessage<bool> // TypeDefIndex: 84947
	{
		// Constructors
		public SendGlobalMessageBoolean(); // 0x000000018CE76AE4-0x000000018CE76B24
	}

	public class SendGlobalMessageFloat : SendGlobalMessage<float> // TypeDefIndex: 84948
	{
		// Constructors
		public SendGlobalMessageFloat(); // 0x000000018CE76B24-0x000000018CE76B64
	}

	public class SendGlobalMessageInteger : SendGlobalMessage<int> // TypeDefIndex: 84949
	{
		// Constructors
		public SendGlobalMessageInteger(); // 0x000000018CE76B64-0x000000018CE76BA4
	}

	public class SendGlobalMessageObject : SendGlobalMessage<UnityEngine.Object> // TypeDefIndex: 84950
	{
		// Constructors
		public SendGlobalMessageObject(); // 0x000000018CE76BA4-0x000000018CE76BE4
	}

	public class SendGlobalMessageString : SendGlobalMessage<string> // TypeDefIndex: 84951
	{
		// Constructors
		public SendGlobalMessageString(); // 0x000000018CE76BE4-0x000000018CE76C24
	}

	[Category("Rendering")]
	[Description("Shows closed captions at the bottom of the screen. Note that the Play Audio clips of the Audio Track are also able to show subtitles in sync with the audio. Use this for non audible subtitles or captions.")]
	public class Captions : DirectorActionClip // TypeDefIndex: 84952
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
		public override string info { get; } // 0x000000018CE706F0-0x000000018CE70730 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
	
		// Constructors
		public Captions(); // 0x000000018CE7067C-0x000000018CE706F0
	
		// Methods
		protected override void OnUpdate(float deltaTime); // 0x000000018CE70604-0x000000018CE7067C
	}

	[Category("Rendering")]
	[Description("Controls the visibility of the Cinematic Letterbox. This is only usefull if you want a Cinematic Letterbox only in some parts of your cutscene. For this to work correctly, you should set the CineBox effect in the Cutscene CameraTrack to 0, so that the effect is not overriden.")]
	public class CineBox : DirectorActionClip // TypeDefIndex: 84953
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
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
	
		// Constructors
		public CineBox(); // 0x000000018CE70748-0x000000018CE70774
	
		// Methods
		protected override void OnUpdate(float time); // 0x000000018CE70730-0x000000018CE70748
	}

	[Category("Rendering")]
	[Description("Show text on screen")]
	public class OverlayText : DirectorActionClip // TypeDefIndex: 84954
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
		public override string info { get; } // 0x000000018CE72F54-0x000000018CE72F94 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
	
		// Constructors
		public OverlayText(); // 0x000000018CE72ED0-0x000000018CE72F54
	
		// Methods
		protected override void OnUpdate(float time); // 0x000000018CE72E38-0x000000018CE72ED0
	}

	[Category("Rendering")]
	[Description("Displays a texture overlay")]
	public class OverlayTexture : DirectorActionClip // TypeDefIndex: 84955
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
		public override string info { get; } // 0x000000018CE73084-0x000000018CE73124 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
	
		// Constructors
		public OverlayTexture(); // 0x000000018CE73034-0x000000018CE73084
	
		// Methods
		protected override void OnUpdate(float deltaTime); // 0x000000018CE72F94-0x000000018CE73034
	}

	[Category("Rendering")]
	[Description("An alternative way to fade the screen. Fade out/in can also be done through the Camera Shot clip in the Camera Track, but with this clip, more effects can be achieved.")]
	public class ScreenFader : DirectorActionClip // TypeDefIndex: 84956
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
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
	
		// Constructors
		public ScreenFader(); // 0x000000018CE76660-0x000000018CE766BC
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE765B4-0x000000018CE765D4
		protected override void OnUpdate(float deltaTime); // 0x000000018CE765F4-0x000000018CE76660
		protected override void OnReverse(); // 0x000000018CE765D4-0x000000018CE765F4
	}

	[Category("Utility")]
	[Description("Animates the playback speed of the cutscene")]
	public class AnimatePlaybackSpeed : DirectorActionClip // TypeDefIndex: 84957
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
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
	
		// Constructors
		public AnimatePlaybackSpeed(); // 0x000000018CE6FDC4-0x000000018CE6FDE8
	
		// Methods
		protected override void OnCreate(); // 0x000000018CE6FC98-0x000000018CE6FCC8
		protected override void OnEnter(); // 0x000000018CE6FCC8-0x000000018CE6FCF8
		protected override void OnUpdate(float time); // 0x000000018CE6FD28-0x000000018CE6FDC4
		protected override void OnReverse(); // 0x000000018CE6FCF8-0x000000018CE6FD28
	}

	[Category("Utility")]
	public class DebugLog : DirectorActionClip // TypeDefIndex: 84958
	{
		// Fields
		[LeftToggle]
		public bool neverSkip; // 0x40
		public string text; // 0x48
	
		// Properties
		public override string info { get; } // 0x000000018CE70900-0x000000018CE70940 
	
		// Constructors
		public DebugLog(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE7085C-0x000000018CE70900
	}

	[Category("Utility")]
	[Description("Pauses the Cutscene (PlayMode Only). It\'s up to other scripts to resume it.")]
	public class PauseCutscene : DirectorActionClip // TypeDefIndex: 84959
	{
		// Constructors
		public PauseCutscene(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE73124-0x000000018CE73218
	}

	[Category("Utilities")]
	[Description("Render the cutscene in an image-sequence for the selected duration of the clip. Rendering is done in playmode only.")]
	[Obsolete("Use the new \'Render\' feature")]
	public class ScreenCapture : DirectorActionClip // TypeDefIndex: 84960
	{
		// Constructors
		public ScreenCapture(); // 0x00000001878364A0-0x00000001878364B8
	}

	[Attachable(new System.Type[1] {typeof(AnimationTrack) })]
	[Description("All animation clips in the same track, will play at an animation layer equal to their track layer order. Thus, animations in tracks on top will play over animations in tracks bellow. You can trim or loop the animation by scaling the clip.")]
	[Name("Animation Clip")]
	public class PlayAnimationClip : ActorActionClip<Animation>, ISubClipContainable // TypeDefIndex: 84961
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
		float ISubClipContainable.subClipOffset { get; set; } // 0x00000001872352B0-0x00000001872352C0 0x00000001872352D0-0x00000001872352E0
		float ISubClipContainable.subClipLength { get; } // 0x000000018CE737FC-0x000000018CE7386C 
		float ISubClipContainable.subClipSpeed { get; } // 0x00000001872352A0-0x00000001872352B0 
		public override string info { get; } // 0x000000018CE738C0-0x000000018CE73934 
		public override bool isValid { get; } // 0x000000018CE73934-0x000000018CE739C4 
		public override float length { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override float blendIn { get; set; } // 0x0000000187234790-0x00000001872347A0 0x000000018723F3C0-0x000000018723F3D0
		public override float blendOut { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
		public override bool canCrossBlend { get; } // 0x00000001851A4410-0x00000001851A4420 
		private AnimationTrack track { get; } // 0x000000018CE739C4-0x000000018CE73A00 
		new string IDirectable.name { get; } // 0x0000000187835674-0x000000018783567C 
	
		// Constructors
		public PlayAnimationClip(); // 0x000000018CE7386C-0x000000018CE738C0
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE73218-0x000000018CE73400
		protected override void OnUpdate(float time); // 0x000000018CE734C8-0x000000018CE737FC
		protected override void OnReverse(); // 0x000000018CE73448-0x000000018CE734C8
		protected override void OnExit(); // 0x000000018CE73400-0x000000018CE73424
		protected override void OnReverseEnter(); // 0x000000018CE73424-0x000000018CE73448
	}

	[Attachable(new System.Type[1] {typeof(AnimatorTrack) })]
	[Description("Play an Animation Clip on target actor with Animator component attached.\nIf this is the Layer 0 Animator Track, you can choose to explicitely set a \'Starting Position\' and a \'Starting Rotation\' for when the clip starts. This also takes into account Root Motion if enabled in the Animator Track.")]
	[Name("Animation Clip")]
	public class PlayAnimatorClip : ActorActionClip, ISubClipContainable // TypeDefIndex: 84964
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
		private bool isMasterAndManualSet { get; } // 0x000000018CE74334-0x000000018CE74358 
		float ISubClipContainable.subClipOffset { get; set; } // 0x00000001872353B0-0x00000001872353C0 0x00000001872353E0-0x00000001872353F0
		float ISubClipContainable.subClipLength { get; } // 0x000000018CE741FC-0x000000018CE7426C 
		float ISubClipContainable.subClipSpeed { get; } // 0x00000001872352A0-0x00000001872352B0 
		public override string info { get; } // 0x000000018CE742BC-0x000000018CE74334 
		public override bool isValid { get; } // 0x000000018CE7437C-0x000000018CE74428 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override bool canCrossBlend { get; } // 0x00000001851A4410-0x00000001851A4420 
		protected AnimatorTrack track { get; } // 0x000000018CE74428-0x000000018CE74464 
		protected Animator animator { get; } // 0x000000018CE74298-0x000000018CE742BC 
		protected bool isMasterTrack { get; } // 0x000000018CE74358-0x000000018CE7437C 
		new string IDirectable.name { get; } // 0x0000000187835674-0x000000018783567C 
	
		// Nested types
		public enum StartingTransformsMode // TypeDefIndex: 84962
		{
			AutoMatchTransforms = 0,
			ManualSetTransforms = 1
		}
	
		public enum ClipWrapMode // TypeDefIndex: 84963
		{
			Loop = 0,
			PingPong = 1
		}
	
		// Constructors
		public PlayAnimatorClip(); // 0x000000018CE7426C-0x000000018CE74298
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE73A00-0x000000018CE73C24
		protected override void OnReverseEnter(); // 0x000000018CE73C88-0x000000018CE73CEC
		protected override void OnUpdate(float time, float previousTime); // 0x000000018CE73DCC-0x000000018CE741FC
		protected override void OnExit(); // 0x000000018CE73C24-0x000000018CE73C88
		protected override void OnReverse(); // 0x000000018CE73CEC-0x000000018CE73DCC
	}

	[Attachable(new System.Type[2] {typeof(ActorAudioTrack), typeof(DirectorAudioTrack) })]
	[Description("The audio clip will be send to the AudioMixer selected in it\'s track if any. You can trim or loop the audio by scaling the clip and you can optionaly show subtitles as well.")]
	[Name("Audio Clip")]
	public class PlayAudio : ActionClip, ISubClipContainable // TypeDefIndex: 84965
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
		float ISubClipContainable.subClipOffset { get; set; } // 0x00000001872352A0-0x00000001872352B0 0x00000001872352C0-0x00000001872352D0
		float ISubClipContainable.subClipLength { get; } // 0x000000018CE747D0-0x000000018CE74840 
		float ISubClipContainable.subClipSpeed { get; } // 0x0000000187235D20-0x0000000187235D30 
		public override float length { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public override float blendIn { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public override float blendOut { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override bool isValid { get; } // 0x000000018CE749A4-0x000000018CE749F4 
		public override string info { get; } // 0x000000018CE7491C-0x000000018CE749A4 
		private Slate.AudioTrack track { get; } // 0x000000018CE74A14-0x000000018CE74A50 
		private AudioSource source { get; } // 0x000000018CE749F4-0x000000018CE74A14 
		new string IDirectable.name { get; } // 0x0000000187835674-0x000000018783567C 
	
		// Constructors
		public PlayAudio(); // 0x000000018CE748C0-0x000000018CE7491C
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE744E8-0x000000018CE744F0
		protected override void OnReverseEnter(); // 0x000000018CE744E8-0x000000018CE744F0
		protected override void OnExit(); // 0x000000018CE744F0-0x000000018CE744F8
		protected override void OnReverse(); // 0x000000018CE744F0-0x000000018CE744F8
		private void Do(); // 0x000000018CE74464-0x000000018CE744E8
		protected override void OnUpdate(float time, float previousTime); // 0x000000018CE744F8-0x000000018CE747D0
		private void Undo(); // 0x000000018CE74840-0x000000018CE748C0
	}

	[Description("Animate a bool Animator parameter and reset it back to previous value after a period of time.")]
	public class AnimateBoolParameter : MecanimBaseClip // TypeDefIndex: 84966
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
		public override bool isValid { get; } // 0x000000018CE6DE00-0x000000018CE6DE30 
		public override string info { get; } // 0x000000018CE6DDC0-0x000000018CE6DE00 
		public override float length { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
	
		// Constructors
		public AnimateBoolParameter(); // 0x000000018CE6DDAC-0x000000018CE6DDC0
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE6DC28-0x000000018CE6DC80
		protected override void OnUpdate(float time); // 0x000000018CE6DD54-0x000000018CE6DDAC
		protected override void OnExit(); // 0x000000018CE6DC80-0x000000018CE6DCF0
		protected override void OnReverse(); // 0x000000018CE6DCF0-0x000000018CE6DD54
	}

	[Description("Animate a float Animator parameter to a value and back to previous value gradualy over a period of time.")]
	public class AnimateFloatParameter : MecanimBaseClip // TypeDefIndex: 84967
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
		public override bool isValid { get; } // 0x000000018CE6E00C-0x000000018CE6E03C 
		public override string info { get; } // 0x000000018CE6DFCC-0x000000018CE6E00C 
		public override float length { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override float blendIn { get; set; } // 0x0000000187234790-0x00000001872347A0 0x000000018723F3C0-0x000000018723F3D0
		public override float blendOut { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
	
		// Constructors
		public AnimateFloatParameter(); // 0x000000018CE6DFA8-0x000000018CE6DFCC
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE6DE30-0x000000018CE6DE8C
		protected override void OnUpdate(float deltaTime); // 0x000000018CE6DEF0-0x000000018CE6DFA8
		protected override void OnReverse(); // 0x000000018CE6DE8C-0x000000018CE6DEF0
	}

	[Description("Animate an integer Animator parameter to a value and back to previous value gradualy over a period of time.")]
	public class AnimateIntegerParameter : MecanimBaseClip // TypeDefIndex: 84968
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
		public override bool isValid { get; } // 0x000000018CE6E00C-0x000000018CE6E03C 
		public override string info { get; } // 0x000000018CE6E51C-0x000000018CE6E55C 
		public override float length { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override float blendIn { get; set; } // 0x0000000187234790-0x00000001872347A0 0x000000018723F3C0-0x000000018723F3D0
		public override float blendOut { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
	
		// Constructors
		public AnimateIntegerParameter(); // 0x000000018CE6E500-0x000000018CE6E51C
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE6E388-0x000000018CE6E3E0
		protected override void OnUpdate(float deltaTime); // 0x000000018CE6E444-0x000000018CE6E500
		protected override void OnReverse(); // 0x000000018CE6E3E0-0x000000018CE6E444
	}

	[Description("Animate an Animator layer weight to a value and back to previous value gradualy over a period of time.")]
	public class AnimateLayerWeight : MecanimBaseClip // TypeDefIndex: 84969
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
		public override string info { get; } // 0x000000018CE6E6F4-0x000000018CE6E754 
		public override float length { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override float blendIn { get; set; } // 0x0000000187234790-0x00000001872347A0 0x000000018723F3C0-0x000000018723F3D0
		public override float blendOut { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
	
		// Constructors
		public AnimateLayerWeight(); // 0x000000018CE6E6D0-0x000000018CE6E6F4
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE6E55C-0x000000018CE6E5B4
		protected override void OnUpdate(float deltaTime); // 0x000000018CE6E618-0x000000018CE6E6D0
		protected override void OnReverse(); // 0x000000018CE6E5B4-0x000000018CE6E618
	}

	[Attachable(new System.Type[1] {typeof(ActorActionTrack) })]
	[Category("Animator IK Control")]
	[Description("Animate an actor IK Goal. Please note that the Animator needs to have a Controller assigned and \'IK Pass\' must be enabled in that Controller.")]
	public class AnimateLimbIK : ActorActionClip<Animator> // TypeDefIndex: 84971
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
		public Vector3 targetPosition { get; set; } // 0x000000018CE6EFF4-0x000000018CE6F028 0x0000000187257D40-0x0000000187257D50
		[AnimatableParameter(link = "IKTarget")]
		[RotationHandle("targetPosition")]
		public Vector3 targetRotation { get; set; } // 0x000000018CE6F028-0x000000018CE6F05C 0x0000000187257DD0-0x0000000187257DF0
		public override string info { get; } // 0x000000018CE6EF84-0x000000018CE6EFF4 
		public override float length { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override float blendIn { get; set; } // 0x0000000187234790-0x00000001872347A0 0x000000018723F3C0-0x000000018723F3D0
		public override float blendOut { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 84970
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x000000018CE79650-0x000000018CE796B4
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public AnimateLimbIK(); // 0x000000018CE6EF38-0x000000018CE6EF84
	
		// Methods
		protected override void OnCreate(); // 0x000000018CE6EB6C-0x000000018CE6EBA8
		protected override void OnAfterValidate(); // 0x000000018CE6E754-0x000000018CE6E9A0
		protected override void OnEnter(); // 0x000000018CE6EBA8-0x000000018CE6ECA0
		protected override void OnReverseEnter(); // 0x000000018CE6ED34-0x000000018CE6EE2C
		protected override void OnReverse(); // 0x000000018CE6EE2C-0x000000018CE6EEC0
		protected override void OnExit(); // 0x000000018CE6ECA0-0x000000018CE6ED34
		protected override void OnRootDisabled(); // 0x000000018CE6EEC0-0x000000018CE6EF38
		private void OnAnimatorIK(int index); // 0x000000018CE6E9A0-0x000000018CE6EB6C
	}

	[Attachable(new System.Type[1] {typeof(ActorActionTrack) })]
	[Category("Animator IK Control")]
	[Description("Make the actor look at target position. Please note that the Animator needs to have a Controller assigned and \'IK Pass\' must be enabled in that Controller.")]
	public class AnimateLookAtIK : ActorActionClip<Animator> // TypeDefIndex: 84973
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
		public Vector3 targetPositionVector { get; set; } // 0x000000018CE6F76C-0x000000018CE6F7A0 0x000000018723FD80-0x000000018723FDA0
		public override string info { get; } // 0x000000018CE6F740-0x000000018CE6F76C 
		public override float length { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override float blendIn { get; set; } // 0x0000000187234790-0x00000001872347A0 0x000000018723F3C0-0x000000018723F3D0
		public override float blendOut { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 84972
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x000000018CE795EC-0x000000018CE79650
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public AnimateLookAtIK(); // 0x000000018CE6F6E8-0x000000018CE6F740
	
		// Methods
		protected override void OnCreate(); // 0x000000018CE6F318-0x000000018CE6F358
		protected override void OnAfterValidate(); // 0x000000018CE6F05C-0x000000018CE6F1E0
		protected override void OnEnter(); // 0x000000018CE6F358-0x000000018CE6F450
		protected override void OnReverseEnter(); // 0x000000018CE6F4E4-0x000000018CE6F5DC
		protected override void OnReverse(); // 0x000000018CE6F5DC-0x000000018CE6F670
		protected override void OnExit(); // 0x000000018CE6F450-0x000000018CE6F4E4
		protected override void OnRootDisabled(); // 0x000000018CE6F670-0x000000018CE6F6E8
		private void OnAnimatorIK(int index); // 0x000000018CE6F1E0-0x000000018CE6F318
	}

	public class AnimateTrigger : MecanimBaseClip // TypeDefIndex: 84974
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		public string triggerName; // 0x50
		[AnimatableParameter]
		public bool value; // 0x58
	
		// Properties
		public override bool isValid { get; } // 0x000000018CE6DE00-0x000000018CE6DE30 
		public override string info { get; } // 0x000000018CE6FF28-0x000000018CE6FF68 
		public override float length { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
	
		// Constructors
		public AnimateTrigger(); // 0x000000018CE6FF18-0x000000018CE6FF28
	
		// Methods
		protected override void OnUpdate(float time); // 0x000000018CE6FEA0-0x000000018CE6FF18
	}

	[Description("CrossFades to an Animator state within a period of time.")]
	public class CrossFadeState : MecanimBaseClip // TypeDefIndex: 84975
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		[Required]
		public string stateName; // 0x50
	
		// Properties
		public override string info { get; } // 0x000000018CE7081C-0x000000018CE7085C 
		public override float length { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public override float blendIn { get; } // 0x000000018CE7080C-0x000000018CE7081C 
	
		// Constructors
		public CrossFadeState(); // 0x000000018CE6FF18-0x000000018CE6FF28
	
		// Methods
		protected override void OnEnter(); // 0x000000018CE70774-0x000000018CE7080C
	}

	[Attachable(new System.Type[1] {typeof(MecanimTrack) })]
	public abstract class MecanimBaseClip : ActorActionClip<Animator> // TypeDefIndex: 84977
	{
		// Properties
		public override bool isValid { get; } // 0x000000018CE72A98-0x000000018CE72B4C 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 84976
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _HasParameter_b__0(AnimatorControllerParameter p); // 0x0000000185624DA0-0x0000000185624DD0
		}
	
		// Constructors
		protected MecanimBaseClip(); // 0x000000018CE72A58-0x000000018CE72A98
	
		// Methods
		protected bool HasParameter(string name); // 0x000000018CE727AC-0x000000018CE72A58
	}
}
