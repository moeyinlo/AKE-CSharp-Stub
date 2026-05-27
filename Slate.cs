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

// Image 35: Slate.dll - Assembly: Slate, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 54553-54825
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Slate
{
	public class DirectorCamera : MonoBehaviour, IDirectableCamera // TypeDefIndex: 54554
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
		public const float MAX_DAMP = 3f; // Metadata: 0x01FD66E0
		private static DirectorCamera _current; // 0x18
		private static Camera _cam; // 0x20
		private static IDirectableCamera lastTargetShot; // 0x28
		private static float noiseTimer; // 0x3C
		private static Vector3 noisePosOffset; // 0x40
		private static Vector3 noiseRotOffset; // 0x4C
		private static Vector3 noiseTargetPosOffset; // 0x58
		private static Vector3 noiseTargetRotOffset; // 0x64
		private static Vector3 noiseCamPosVel; // 0x70
		private static Vector3 noiseCamRotVel; // 0x7C
	
		// Properties
		public static DirectorCamera current { get => default; } // 0x0000000189683E4C-0x0000000189684030 
		public Camera cam { get => default; } // 0x0000000189683D1C-0x0000000189683E4C 
		public Vector3 position { get => default; set {} } // 0x0000000189684160-0x00000001896841B4 0x00000001896845C8-0x000000018968461C
		public Quaternion rotation { get => default; set {} } // 0x00000001896841D8-0x0000000189684224 0x000000018968461C-0x0000000189684668
		public float fieldOfView { get => default; set {} } // 0x0000000189684050-0x00000001896840B0 0x0000000189684488-0x00000001896844F0
		public float focalDistance { get; set; } // 0x0000000183D4F2E0-0x0000000183D4F2F0 0x0000000183D4F2F0-0x0000000183D4F300
		public float focalLength { get; set; } // 0x0000000183D524F0-0x0000000183D52500 0x0000000183D52500-0x0000000183D52510
		public float focalAperture { get; set; } // 0x0000000183D4F480-0x0000000183D4F490 0x0000000183D4F490-0x0000000183D4F4A0
		public static bool matchMainWhenActive { get => default; set {} } // 0x0000000189684140-0x0000000189684160 0x00000001896845A4-0x00000001896845C8
		public static bool setMainWhenActive { get => default; set {} } // 0x0000000189684224-0x0000000189684244 0x0000000189684668-0x000000018968468C
		public static bool autoHandleActiveState { get => default; set {} } // 0x0000000189683CFC-0x0000000189683D1C 0x0000000189684440-0x0000000189684464
		public static bool ignoreFOVChanges { get => default; set {} } // 0x00000001896840E8-0x0000000189684108 0x0000000189684544-0x0000000189684568
		public static bool dontDestroyOnLoad { get => default; set {} } // 0x0000000189684030-0x0000000189684050 0x0000000189684464-0x0000000189684488
		public static Camera renderCamera { get => default; } // 0x00000001896841B4-0x00000001896841D8 
		public static GameCamera gameCamera { get; set; } // 0x00000001896840B0-0x00000001896840E8 0x00000001896844F0-0x0000000189684544
		public static bool isEnabled { get; private set; } // 0x0000000189684108-0x0000000189684140 0x0000000189684568-0x00000001896845A4
		GameObject IDirectableCamera.gameObject { get => default; } // 0x000000018426FB4C-0x000000018426FB54 
	
		// Events
		public static event Action<IDirectableCamera> onCut;
		public static event Action onActivate;
		public static event Action onDeactivate;
	
		// Constructors
		public DirectorCamera() {} // 0x0000000183D42A90-0x0000000183D42AB0
	
		// Methods
		private void Awake() {} // 0x0000000189682C28-0x0000000189682D4C
		private Camera CreateRenderCamera() => default; // 0x0000000189682D4C-0x0000000189682EE4
		public static void Enable() {} // 0x000000018968300C-0x0000000189683428
		public static void Disable() {} // 0x0000000189682EE4-0x000000018968300C
		public static void Update(IDirectableCamera source, IDirectableCamera target, Slate.EaseType interpolation, float weight, float damping = 0f /* Metadata: 0x01FD66DC */) {} // 0x0000000189683428-0x0000000189683B00
		public static void ApplyNoise(float magnitude, float weight) {} // 0x000000018968283C-0x0000000189682C28
	}

	[ExecuteInEditMode]
	public class DirectorGUI : MonoBehaviour // TypeDefIndex: 54561
	{
		// Fields
		[NonSerialized]
		private static DirectorGUI _current; // 0x40
	
		// Properties
		public static DirectorGUI current { get => default; } // 0x0000000189685138-0x00000001896852C4 
		public static UnityEngine.Color lastFadeColor { get; private set; } // 0x00000001896852C4-0x0000000189685308 0x0000000189685880-0x00000001896858C0
	
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
		public delegate void SubtitlesGUIDelegate(string text, UnityEngine.Color color); // TypeDefIndex: 54555; 0x00000001829CE1E0-0x00000001829CE210
	
		public delegate void TextOverlayGUIDelegate(string text, UnityEngine.Color color, float size, TextAnchor alignment, Vector2 position); // TypeDefIndex: 54556; 0x0000000189687EE4-0x0000000189687F2C
	
		public delegate void ImageOverlayGUIDelegate(Texture texture, UnityEngine.Color color, Vector2 scale, Vector2 position); // TypeDefIndex: 54557; 0x000000018968683C-0x0000000189686874
	
		public delegate void ScreenFadeGUIDelegate(UnityEngine.Color color); // TypeDefIndex: 54558; 0x0000000183D490A0-0x0000000183D490D0
	
		public delegate void LetterboxGUIDelegate(float completion); // TypeDefIndex: 54559; 0x0000000182149960-0x0000000182149970
	
		public delegate void CameraDissolveDelegate(Texture texture, float completion); // TypeDefIndex: 54560; 0x0000000182065C10-0x0000000182065C20
	
		// Constructors
		public DirectorGUI() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Awake() {} // 0x000000018968468C-0x000000018968476C
		private void OnEnable() {} // 0x0000000189684880-0x00000001896848C4
		private void OnDisable() {} // 0x000000018968476C-0x0000000189684880
		public static void UpdateLetterbox(float completion) {} // 0x00000001896849B8-0x0000000189684A14
		public static void UpdateDissolve(Texture texture, float completion) {} // 0x00000001896848C4-0x0000000189684928
		public static void UpdateFade(UnityEngine.Color color) {} // 0x0000000189684928-0x00000001896849B8
		public static void UpdateSubtitles(string text, UnityEngine.Color color) {} // 0x0000000189684B54-0x0000000189684BC0
		public static void UpdateOverlayText(string text, UnityEngine.Color color, float size, TextAnchor anchor, Vector2 pos) {} // 0x0000000189684AB0-0x0000000189684B54
		public static void UpdateOverlayImage(Texture texture, UnityEngine.Color color, Vector2 scale, Vector2 positionOffset) {} // 0x0000000189684A14-0x0000000189684AB0
	}

	[Serializable]
	public class DynamicCameraController // TypeDefIndex: 54567
	{
		// Fields
		private const float MIN_DAMP = 0.5f; // Metadata: 0x01FD66E4
		private const float MAX_DAMP = 10f; // Metadata: 0x01FD66E8
		[SerializeField]
		private Transposer _transposer; // 0x10
		[SerializeField]
		private Composer _composer; // 0x18
		private int lastUpdateFrame; // 0x20
	
		// Properties
		public Transposer transposer { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public Composer composer { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public bool controlsPosition { get => default; } // 0x0000000189686660-0x0000000189686678 
		public bool controlsRotation { get => default; } // 0x0000000189686678-0x0000000189686690 
		public bool controlsFieldOfView { get => default; } // 0x0000000189686644-0x0000000189686660 
	
		// Nested types
		[Serializable]
		public class Transposer // TypeDefIndex: 54564
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
			public enum TrackingMode // TypeDefIndex: 54562
			{
				None = 0,
				OffsetTracking = 1,
				RailTracking = 2
			}
	
			public enum OffsetMode // TypeDefIndex: 54563
			{
				LocalSpace = 0,
				WorldSpace = 1
			}
	
			// Constructors
			public Transposer() {} // 0x0000000183D74FD0-0x0000000183D75030
		}
	
		[Serializable]
		public class Composer // TypeDefIndex: 54566
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
			public enum TrackingMode // TypeDefIndex: 54565
			{
				None = 0,
				FrameComposition = 1
			}
	
			// Constructors
			public Composer() {} // 0x0000000183D74F40-0x0000000183D74F60
		}
	
		// Constructors
		public DynamicCameraController() {} // 0x0000000189686598-0x0000000189686644
	
		// Methods
		public void UpdateControllerHard(IDirectableCamera directableCamera, IDirectable directable) {} // 0x0000000189685938-0x0000000189685954
		public void UpdateControllerSoft(IDirectableCamera directableCamera, IDirectable directable) {} // 0x0000000189685954-0x0000000189685970
		private void UpdateController(IDirectableCamera directableCamera, IDirectable directable, bool isHard) {} // 0x0000000189685970-0x0000000189686598
	}

	public class GameCamera : MonoBehaviour, IDirectableCamera // TypeDefIndex: 54568
	{
		// Fields
		private Camera _cam; // 0x18
	
		// Properties
		public Camera cam { get => default; } // 0x0000000189686690-0x000000018968671C 
		public Vector3 position { get => default; set {} } // 0x00000001885BEE50-0x00000001885BEE98 0x000000018350B670-0x000000018350B680
		public Quaternion rotation { get => default; set {} } // 0x00000001885BEE98-0x00000001885BEEDC 0x000000018350B670-0x000000018350B680
		public float fieldOfView { get => default; set {} } // 0x000000018968671C-0x000000018968677C 0x000000018350B670-0x000000018350B680
		public float focalDistance { get => default; set {} } // 0x0000000183D5E210-0x0000000183D5E220 0x000000018350B670-0x000000018350B680
		public float focalLength { get => default; set {} } // 0x0000000183D74FC0-0x0000000183D74FD0 0x000000018350B670-0x000000018350B680
		public float focalAperture { get => default; set {} } // 0x0000000183D74FB0-0x0000000183D74FC0 0x000000018350B670-0x000000018350B680
		GameObject IDirectableCamera.gameObject { get => default; } // 0x000000018426FB4C-0x000000018426FB54 
	
		// Constructors
		public GameCamera() {} // 0x000000018426FE60-0x000000018426FE68
	}

	public interface IDirectableCamera // TypeDefIndex: 54569
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
	public class ShotCamera : MonoBehaviour, IDirectableCamera // TypeDefIndex: 54571
	{
		// Fields
		public const string DEFAULT_NAME = "Shot Camera"; // Metadata: 0x01FD66F3
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
		public Camera cam { get => default; } // 0x0000000189687994-0x0000000189687A20 
		public Vector3 position { get => default; set {} } // 0x00000001885BEE50-0x00000001885BEE98 0x00000001859185D4-0x0000000185918618
		public Quaternion rotation { get => default; set {} } // 0x00000001885BEE98-0x00000001885BEEDC 0x00000001859162F0-0x000000018591632C
		public Vector3 localPosition { get => default; set {} } // 0x0000000189687B3C-0x0000000189687B84 0x0000000189687C50-0x0000000189687C94
		public Vector3 localEulerAngles { get => default; set {} } // 0x0000000189687AC8-0x0000000189687B3C 0x0000000189687BDC-0x0000000189687C50
		public float fieldOfView { get => default; set {} } // 0x0000000189687A68-0x0000000189687AC8 0x0000000189687B84-0x0000000189687BDC
		public float focalDistance { get => default; set {} } // 0x0000000183D4F2E0-0x0000000183D4F2F0 0x0000000183D4F2F0-0x0000000183D4F300
		public float focalLength { get => default; set {} } // 0x0000000183D524F0-0x0000000183D52500 0x0000000183D52500-0x0000000183D52510
		public float focalAperture { get => default; set {} } // 0x0000000183D4F480-0x0000000183D4F490 0x0000000183D4F490-0x0000000183D4F4A0
		public DynamicCameraController dynamicController { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public bool dynamicControlledPosition { get => default; } // 0x0000000189687A38-0x0000000189687A50 
		public bool dynamicControlledRotation { get => default; } // 0x0000000189687A50-0x0000000189687A68 
		public bool dynamicControlledFieldOfView { get => default; } // 0x0000000189687A20-0x0000000189687A38 
		GameObject IDirectableCamera.gameObject { get => default; } // 0x000000018426FB4C-0x000000018426FB54 
	
		// Constructors
		public ShotCamera() {} // 0x0000000189687910-0x0000000189687994
	
		// Methods
		private void Awake() {} // 0x0000000189687248-0x000000018968733C
		public void UpdateDynamicControllerHard(IDirectable directable) {} // 0x00000001896878C0-0x00000001896878E8
		public void UpdateDynamicControllerSoft(IDirectable directable) {} // 0x00000001896878E8-0x0000000189687910
		public void SetDynamicControllerTargets(Transform target) {} // 0x00000001896878B4-0x00000001896878C0
		public void SetDynamicControllerTargets(Transform transposerTarget, Transform composerTarget) {} // 0x0000000189687860-0x00000001896878B4
		public RenderTexture GetRenderTexture(int width, int height) => default; // 0x00000001896876BC-0x0000000189687860
		public static ShotCamera Create(Transform targetParent = null) => default; // 0x000000018968733C-0x00000001896875C4
		public static ShotCamera Find(string shotName) => default; // 0x00000001896875C4-0x00000001896876BC
	}

	[Serializable]
	public class BlendShape // TypeDefIndex: 54572
	{
		// Fields
		[SerializeField]
		private SkinnedMeshRenderer _skin; // 0x10
		[SerializeField]
		private string _name; // 0x18
		[SerializeField]
		private float _weight; // 0x20
	
		// Properties
		public SkinnedMeshRenderer skin { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public string name { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public float weight { get => default; set {} } // 0x0000000183D4F2E0-0x0000000183D4F2F0 0x0000000183D4F2F0-0x0000000183D4F300
	
		// Constructors
		public BlendShape() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void SetRealWeight(float modWeight) {} // 0x000000018967B6CC-0x000000018967B798
		public override string ToString() => default; // 0x0000000181041090-0x00000001810410A0
	}

	[Serializable]
	public class BlendShapeGroup // TypeDefIndex: 54573
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
		public string UID { get => default; private set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public string name { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public float weight { get => default; set {} } // 0x0000000183D4F2E0-0x0000000183D4F2F0 0x000000018967B6C0-0x000000018967B6CC
		public List<BlendShape> blendShapes { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Constructors
		public BlendShapeGroup() {} // 0x000000018967B5F4-0x000000018967B6C0
	
		// Methods
		private void SetBlendWeights() {} // 0x000000018967B574-0x000000018967B5F4
		public override string ToString() => default; // 0x0000000181041090-0x00000001810410A0
	}

	[AddComponentMenu("SLATE/Character")]
	public class Character : MonoBehaviour // TypeDefIndex: 54576
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
		public Transform neck { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public Transform head { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public Vector3 upVector { get => default; set {} } // 0x0000000183D51B80-0x0000000183D51BA0 0x0000000183D51BB0-0x0000000183D51BC0
		public Vector3 rotationOffset { get => default; set {} } // 0x0000000183D51B60-0x0000000183D51B80 0x0000000183D51BA0-0x0000000183D51BB0
		public List<BlendShapeGroup> expressions { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public Character() {} // 0x000000018967D918-0x000000018967D9C4
	
		// Methods
		public BlendShapeGroup FindExpressionByName(string name) => default; // 0x000000018967D690-0x000000018967D760
		public BlendShapeGroup FindExpressionByUID(string UID) => default; // 0x000000018967D760-0x000000018967D830
		public void SetExpressionWeightByName(string name, float weight) {} // 0x000000018967D8B0-0x000000018967D8E4
		public void SetExpressionWeightByUID(string UID, float weight) {} // 0x000000018967D8E4-0x000000018967D918
		public void ResetExpressions() {} // 0x000000018967D830-0x000000018967D8B0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class NameAttribute : Attribute // TypeDefIndex: 54577
	{
		// Fields
		public readonly string name; // 0x10
	
		// Constructors
		public NameAttribute() {} // Dummy constructor
		public NameAttribute(string name) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class CategoryAttribute : Attribute // TypeDefIndex: 54578
	{
		// Fields
		public readonly string category; // 0x10
	
		// Constructors
		public CategoryAttribute() {} // Dummy constructor
		public CategoryAttribute(string category) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class DescriptionAttribute : Attribute // TypeDefIndex: 54579
	{
		// Fields
		public readonly string description; // 0x10
	
		// Constructors
		public DescriptionAttribute() {} // Dummy constructor
		public DescriptionAttribute(string description) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class IconAttribute : Attribute // TypeDefIndex: 54580
	{
		// Fields
		public readonly string iconName; // 0x10
		public readonly System.Type fromType; // 0x18
	
		// Constructors
		public IconAttribute() {} // Dummy constructor
		public IconAttribute(string iconName) {} // 0x000000018426FEE0-0x000000018426FEF0
		public IconAttribute(System.Type fromType) {} // 0x00000001822C3A90-0x00000001822C3AA0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class AttachableAttribute : Attribute // TypeDefIndex: 54581
	{
		// Fields
		public readonly System.Type[] types; // 0x10
	
		// Constructors
		public AttachableAttribute() {} // Dummy constructor
		public AttachableAttribute(params System.Type[] types) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class UniqueElementAttribute : Attribute // TypeDefIndex: 54582
	{
		// Constructors
		public UniqueElementAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class ShowTrajectoryAttribute : Attribute // TypeDefIndex: 54583
	{
		// Constructors
		public ShowTrajectoryAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class PositionHandleAttribute : Attribute // TypeDefIndex: 54584
	{
		// Constructors
		public PositionHandleAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class RotationHandleAttribute : Attribute // TypeDefIndex: 54585
	{
		// Fields
		public readonly string positionPropertyName; // 0x10
	
		// Constructors
		public RotationHandleAttribute() {} // Dummy constructor
		public RotationHandleAttribute(string positionPropertyName) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class AnimatableParameterAttribute : PropertyAttribute // TypeDefIndex: 54586
	{
		// Fields
		public string link; // 0x10
		public readonly float? min; // 0x18
		public readonly float? max; // 0x20
		public readonly string customName; // 0x28
	
		// Constructors
		public AnimatableParameterAttribute() {} // 0x000000018350B670-0x000000018350B680
		public AnimatableParameterAttribute(string customName) {} // 0x0000000182C92F10-0x0000000182C92F20
		public AnimatableParameterAttribute(string customName, float min, float max) {} // 0x0000000189672234-0x00000001896722C8
		public AnimatableParameterAttribute(float min, float max) {} // 0x00000001896722C8-0x0000000189672344
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class ParseAnimatableParametersAttribute : PropertyAttribute // TypeDefIndex: 54587
	{
		// Constructors
		public ParseAnimatableParametersAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ShaderPropertyPopupAttribute : PropertyAttribute // TypeDefIndex: 54588
	{
		// Fields
		public readonly System.Type propertyType; // 0x10
	
		// Constructors
		public ShaderPropertyPopupAttribute() {} // 0x000000018350B670-0x000000018350B680
		public ShaderPropertyPopupAttribute(System.Type propertyType) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class LeftToggleAttribute : PropertyAttribute // TypeDefIndex: 54589
	{
		// Constructors
		public LeftToggleAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class MinAttribute : PropertyAttribute // TypeDefIndex: 54590
	{
		// Fields
		public readonly float min; // 0x10
	
		// Constructors
		public MinAttribute() {} // Dummy constructor
		public MinAttribute(float min) {} // 0x0000000183D50CA0-0x0000000183D50CB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ExampleTextAttribute : PropertyAttribute // TypeDefIndex: 54591
	{
		// Fields
		public readonly string text; // 0x10
	
		// Constructors
		public ExampleTextAttribute() {} // Dummy constructor
		public ExampleTextAttribute(string text) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class HelpBoxAttribute : PropertyAttribute // TypeDefIndex: 54592
	{
		// Fields
		public readonly string text; // 0x10
	
		// Constructors
		public HelpBoxAttribute() {} // Dummy constructor
		public HelpBoxAttribute(string text) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ShowIfAttribute : PropertyAttribute // TypeDefIndex: 54593
	{
		// Fields
		public readonly string propertyName; // 0x10
		public readonly int value; // 0x18
	
		// Constructors
		public ShowIfAttribute() {} // Dummy constructor
		public ShowIfAttribute(string propertyName, int value) {} // 0x0000000182738A30-0x0000000182738A50
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class EnabledIfAttribute : PropertyAttribute // TypeDefIndex: 54594
	{
		// Fields
		public readonly string propertyName; // 0x10
		public readonly int value; // 0x18
	
		// Constructors
		public EnabledIfAttribute() {} // Dummy constructor
		public EnabledIfAttribute(string propertyName, int value) {} // 0x0000000182738A30-0x0000000182738A50
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class CallbackAttribute : PropertyAttribute // TypeDefIndex: 54595
	{
		// Fields
		public readonly string methodName; // 0x10
	
		// Constructors
		public CallbackAttribute() {} // Dummy constructor
		public CallbackAttribute(string methodName) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class RequiredAttribute : PropertyAttribute // TypeDefIndex: 54596
	{
		// Constructors
		public RequiredAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class PlaybackProtectedAttribute : PropertyAttribute // TypeDefIndex: 54597
	{
		// Constructors
		public PlaybackProtectedAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ReadOnlyAttribute : PropertyAttribute // TypeDefIndex: 54598
	{
		// Constructors
		public ReadOnlyAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class SortingLayerAttribute : PropertyAttribute // TypeDefIndex: 54599
	{
		// Constructors
		public SortingLayerAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class ActorGroupPopupAttribute : PropertyAttribute // TypeDefIndex: 54600
	{
		// Constructors
		public ActorGroupPopupAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[Attachable(new System.Type[1] {typeof(DirectorActionTrack) })]
	public abstract class DirectorActionClip : ActionClip // TypeDefIndex: 54601
	{
		// Constructors
		protected DirectorActionClip() {} // 0x000000018426FE60-0x000000018426FE68
	}

	public interface IEvent // TypeDefIndex: 54602
	{
		// Properties
		string name { get; }
	
		// Methods
		void Invoke();
	}

	public enum TransformSpace // TypeDefIndex: 54603
	{
		CutsceneSpace = 0,
		ActorSpace = 1,
		WorldSpace = 2,
		ParentSpace = 3
	}

	public enum MiniTransformSpace // TypeDefIndex: 54604
	{
		CutsceneSpace = 0,
		WorldSpace = 2,
		ParentSpace = 3
	}

	public enum ActiveState // TypeDefIndex: 54605
	{
		Disable = 0,
		Enable = 1,
		Toggle = 2
	}

	[Attachable(new System.Type[1] {typeof(CameraTrack) })]
	[Description("Camera Shots can be animated directly within this clip. You don\'t need to create an Actor Group to animate the shot (even though you can if desired).")]
	public class CameraShot : DirectorActionClip // TypeDefIndex: 54609
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
	
		// Properties
		public override string info { get => default; } // 0x000000018967C648-0x000000018967C6C8 
		public override bool isValid { get => default; } // 0x000000018967C6C8-0x000000018967C718 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override bool canCrossBlend { get => default; } // 0x0000000185CB8870-0x0000000185CB8878 
		public new GameObject actor { get => default; } // 0x000000018967C410-0x000000018967C484 
		public CameraShot previousShot { get; private set; } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000184270264-0x0000000184270278
		public ShotCamera targetShot { get => default; set {} } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x000000018967CBA8-0x000000018967CC24
		private CameraTrack track { get => default; } // 0x000000018967C848-0x000000018967C884 
		[AnimatableParameter]
		public Vector3 position { get => default; set {} } // 0x000000018967C718-0x000000018967C7B0 0x000000018967CA88-0x000000018967CB18
		[AnimatableParameter]
		public Vector3 rotation { get => default; set {} } // 0x000000018967C7B0-0x000000018967C848 0x000000018967CB18-0x000000018967CBA8
		[AnimatableParameter(0.01f, 170f)]
		public float fieldOfView { get => default; set {} } // 0x000000018967C484-0x000000018967C4F8 0x000000018967C884-0x000000018967C920
		[AnimatableParameter("Focal Distance")]
		public float focalPoint { get => default; set {} } // 0x000000018967C568-0x000000018967C5D8 0x000000018967C998-0x000000018967CA10
		[AnimatableParameter("Focal Length", 1f, 300f)]
		public float focalRange { get => default; set {} } // 0x000000018967C5D8-0x000000018967C648 0x000000018967CA10-0x000000018967CA88
		[AnimatableParameter(0.1f, 32f)]
		public float focalAperture { get => default; set {} } // 0x000000018967C4F8-0x000000018967C568 0x000000018967C920-0x000000018967C998
	
		// Nested types
		public enum BlendInEffectType // TypeDefIndex: 54606
		{
			None = 0,
			FadeFromColor = 1,
			CrossDissolve = 2,
			EaseIn = 3
		}
	
		public enum BlendOutEffectType // TypeDefIndex: 54607
		{
			None = 0,
			FadeToColor = 1
		}
	
		// Constructors
		public CameraShot() {} // 0x000000018967C3D0-0x000000018967C410
	
		// Methods
		protected override void OnAfterValidate() {} // 0x000000018967B940-0x000000018967BD24
		protected override void OnRootEnabled() {} // 0x000000018967BF14-0x000000018967BFA0
		protected override void OnRootDisabled() {} // 0x000000018967BE88-0x000000018967BF14
		protected override void OnRootUpdated(float time, float previousTime) {} // 0x000000018967BFA0-0x000000018967C02C
		public void TryUpdateShotTargetOverride() {} // 0x000000018967C2FC-0x000000018967C3D0
		protected override bool OnInitialize() => default; // 0x000000018967BE10-0x000000018967BE24
		protected override void OnEnter() {} // 0x000000018967BD24-0x000000018967BE10
		protected override void OnUpdate(float time, float previousTime) {} // 0x000000018967C02C-0x000000018967C2FC
		protected override void OnReverse() {} // 0x000000018967BE24-0x000000018967BE88
	}

	[Attachable(new System.Type[1] {typeof(VideoTrack) })]
	[Description("Play an imported Video Clip on the render camera.")]
	[Name("Video Clip")]
	public class PlayVideo : ActionClip // TypeDefIndex: 54610
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
		public override bool isValid { get => default; } // 0x0000000189686E70-0x0000000189686EC0 
		public override string info { get => default; } // 0x0000000189686DF0-0x0000000189686E70 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		private VideoTrack track { get => default; } // 0x0000000189686EC0-0x0000000189686EFC 
	
		// Constructors
		public PlayVideo() {} // 0x0000000189686DD4-0x0000000189686DF0
	
		// Methods
		protected override void OnEnter() {} // 0x0000000189686CC4-0x0000000189686CCC
		protected override void OnReverseEnter() {} // 0x0000000189686CC4-0x0000000189686CCC
		protected override void OnReverse() {} // 0x0000000189686CCC-0x0000000189686CD4
		protected override void OnExit() {} // 0x0000000189686CCC-0x0000000189686CD4
		private void Enable() {} // 0x0000000189686C4C-0x0000000189686CC4
		protected override void OnUpdate(float time, float previousTime) {} // 0x0000000189686CD4-0x0000000189686DD4
		private void Disable() {} // 0x0000000189686C20-0x0000000189686C4C
	}

	[Description("All tracks of an Actor Group affect a specific actor GameObject or one of it\'s Components. Specifying a name manually comes in handy if you want to set the target actor of this group via scripting. The ReferenceMode along with InitialCoordinates are essential when you are working with prefab actors.")]
	public class ActorGroup : CutsceneGroup // TypeDefIndex: 54611
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
		public override string name { get => default; set {} } // 0x0000000189671F14-0x0000000189671FAC 0x000000018519C3C8-0x000000018519C3D8
		public override GameObject actor { get => default; set {} } // 0x0000000189671F08-0x0000000189671F14 0x0000000189671FAC-0x000000018967201C
		public override ActorReferenceMode referenceMode { get => default; set {} } // 0x0000000183D4EC20-0x0000000183D4EC30 0x0000000183D4ECA0-0x0000000183D4ECB0
		public override ActorInitialTransformation initialTransformation { get => default; set {} } // 0x0000000183D4F370-0x0000000183D4F380 0x0000000183D4F390-0x0000000183D4F3A0
		public override Vector3 initialLocalPosition { get => default; set {} } // 0x0000000183D74EC0-0x0000000183D74EE0 0x0000000183D74EE0-0x0000000183D74F00
		public override Vector3 initialLocalRotation { get => default; set {} } // 0x0000000183D5B040-0x0000000183D5B060 0x0000000183D5B060-0x0000000183D5B080
		public override bool displayVirtualMeshGizmo { get => default; set {} } // 0x0000000183D50A40-0x0000000183D50A50 0x0000000183D50A60-0x0000000183D50A70
	
		// Constructors
		public ActorGroup() {} // 0x0000000189671EB8-0x0000000189671F08
	}

	[Description("The DirectorGroup is the master group of the Cutscene. There is always one and can\'t be removed. The target actor of this group is always the \'Director Camera\', thus it\'s possible to add a PropertiesTrack to animate any of the components attached on the DirectorCamera game object. Usualy Image Effects.")]
	public class DirectorGroup : CutsceneGroup // TypeDefIndex: 54612
	{
		// Properties
		public override string name { get => default; set {} } // 0x000000018968590C-0x0000000189685938 0x000000018350B670-0x000000018350B680
		public override GameObject actor { get => default; set {} } // 0x0000000185DB5C08-0x0000000185DB5C2C 0x000000018350B670-0x000000018350B680
		public override ActorReferenceMode referenceMode { get => default; set {} } // 0x0000000181002730-0x0000000181002740 0x000000018350B670-0x000000018350B680
		public override ActorInitialTransformation initialTransformation { get => default; set {} } // 0x0000000181002730-0x0000000181002740 0x000000018350B670-0x000000018350B680
		public override Vector3 initialLocalPosition { get => default; set {} } // 0x0000000184274B08-0x0000000184274B20 0x000000018350B670-0x000000018350B680
		public override Vector3 initialLocalRotation { get => default; set {} } // 0x0000000184274B08-0x0000000184274B20 0x000000018350B670-0x000000018350B680
		public override bool displayVirtualMeshGizmo { get => default; set {} } // 0x000000018115F4C0-0x000000018115F530 0x000000018350B670-0x000000018350B680
	
		// Constructors
		public DirectorGroup() {} // 0x00000001896858C0-0x000000018968590C
	}

	[Description("Action Tracks are generic purpose tracks. Once an Action Clip has been placed, the Action Track will lock to accept only clips of the same category.")]
	[Icon(typeof(CircleCollider2D))]
	[Name("Action Track")]
	public abstract class ActionTrack : CutsceneTrack // TypeDefIndex: 54613
	{
		// Constructors
		protected ActionTrack() {} // 0x0000000189671E98-0x0000000189671EA0
	}

	[Attachable(new System.Type[1] {typeof(ActorGroup) })]
	public class ActorActionTrack : ActionTrack // TypeDefIndex: 54614
	{
		// Constructors
		public ActorActionTrack() {} // 0x0000000189671E98-0x0000000189671EA0
	}

	[Attachable(new System.Type[1] {typeof(ActorGroup) })]
	public class ActorAudioTrack : Slate.AudioTrack // TypeDefIndex: 54615
	{
		// Fields
		[SerializeField]
		protected bool _useAudioSourceOnActor; // 0x90
	
		// Properties
		public override bool useAudioSourceOnActor { get => default; } // 0x0000000183D58A70-0x0000000183D58A80 
	
		// Constructors
		public ActorAudioTrack() {} // 0x0000000189671EA0-0x0000000189671EB8
	}

	[Attachable(new System.Type[1] {typeof(ActorGroup) })]
	public class ActorPropertiesTrack : PropertiesTrack // TypeDefIndex: 54616
	{
		// Constructors
		public ActorPropertiesTrack() {} // 0x0000000189672104-0x000000018967210C
	
		// Methods
		protected override void OnCreate() {} // 0x000000018967201C-0x0000000189672104
	}

	[Attachable(new System.Type[1] {typeof(ActorGroup) })]
	[Category("Legacy")]
	[Description("The Animation Track works with the legacy \'Animation\' Component. Each Animation Track represents a different layer of the animation system. The zero layered track (bottom) will blend in/out with the default animation clip set on the Animation Component of the actor if any, while all other Animation Tracks will play above.")]
	[Icon(typeof(NavMeshAgent))]
	public class AnimationTrack : CutsceneTrack // TypeDefIndex: 54617
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
		public override string info { get => default; } // 0x0000000189679038-0x0000000189679138 
		public override float blendIn { get => default; } // 0x0000000183D4F670-0x0000000183D4F680 
		public override float blendOut { get => default; } // 0x0000000183D51080-0x0000000183D51090 
		public float weight { get => default; } // 0x0000000183D51C90-0x0000000183D51CA0 
		public AnimationBlendMode animationBlendMode { get => default; private set {} } // 0x0000000183D4EEF0-0x0000000183D4EF00 0x0000000183D4EF40-0x0000000183D4EF50
		public string mixTransformName { get => default; private set {} } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
	
		// Constructors
		public AnimationTrack() {} // 0x0000000189678FD4-0x0000000189679038
	
		// Methods
		protected override bool OnInitialize() => default; // 0x0000000189678DE0-0x0000000189678EBC
		protected override void OnEnter() {} // 0x0000000189678BCC-0x0000000189678DA0
		protected override void OnUpdate(float time, float previousTime) {} // 0x0000000189678EFC-0x0000000189678F9C
		protected override void OnExit() {} // 0x0000000189678DA0-0x0000000189678DE0
		protected override void OnReverseEnter() {} // 0x0000000189678EBC-0x0000000189678EFC
		protected override void OnReverse() {} // 0x0000000189678DA0-0x0000000189678DE0
		public Transform GetMixTransform() => default; // 0x0000000189678A4C-0x0000000189678BCC
	}

	[Attachable(new System.Type[1] {typeof(ActorGroup) })]
	[Description("The Animator Track works with an \'Animator\' Component attached on the actor, but does not require or use the Controller assigned. Instead animation clips can be played directly.\n\nMultiple Animator Tracks can also be added each representing a different animation layer. Root Motion will only be used in Animator Track of Layer 0 (if enabled), which is always the first (bottom) Track.")]
	[Icon(typeof(Animator))]
	public class AnimatorTrack : CutsceneTrack // TypeDefIndex: 54619
	{
		// Fields
		private const int ROOTMOTION_FRAMERATE = 30; // Metadata: 0x01FD670F
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
		public Animator animator { get => default; } // 0x000000018967AEA0-0x000000018967AF94 
		public override string info { get => default; } // 0x000000018967AFAC-0x000000018967B0DC 
		public override bool isLocked { get => default; } // 0x000000018967B124-0x000000018967B154 
		public AnimatorTrack masterTrack { get => default; } // 0x000000018967B15C-0x000000018967B1A8 
		public bool isMasterTrack { get => default; } // 0x000000018967B154-0x000000018967B15C 
		public bool isLastTrack { get => default; } // 0x000000018967B0DC-0x000000018967B124 
		public float compoundTrackWeight { get => default; } // 0x000000018967AF94-0x000000018967AFAC 
	
		// Constructors
		public AnimatorTrack() {} // 0x000000018967AE8C-0x000000018967AEA0
	
		// Methods
		protected override bool OnInitialize() => default; // 0x000000018967A658-0x000000018967A868
		protected override void OnEnter() {} // 0x000000018967A4C0-0x000000018967A618
		protected override void OnUpdate(float time, float previousTime) {} // 0x000000018967A990-0x000000018967AA90
		private void PostUpdateMasterTrack(float time, float previousTime) {} // 0x000000018967AB48-0x000000018967AD30
		protected override void OnReverseEnter() {} // 0x000000018967A868-0x000000018967A904
		protected override void OnExit() {} // 0x000000018967A618-0x000000018967A658
		private void PostExitMasterTrack() {} // 0x000000018967AA90-0x000000018967AB48
		protected override void OnReverse() {} // 0x000000018967A904-0x000000018967A990
		public void EnableClip(PlayAnimatorClip playAnimClip, float blendWeight, float subClipWeight) {} // 0x000000018967A0B8-0x000000018967A174
		public void UpdateClip(PlayAnimatorClip playAnimClip, float clipTime, float clipPrevious, float blendWeight, float subClipWeight) {} // 0x000000018967AD80-0x000000018967AE8C
		public void DisableClip(PlayAnimatorClip playAnimClip, float blendWeight, float subClipWeight) {} // 0x000000018967A010-0x000000018967A0B8
		private void CreateAndPlayTree() {} // 0x0000000189679990-0x0000000189679D3C
		private Playable CreateClipsMixer(PlayableGraph graph) => default; // 0x0000000189679D3C-0x000000018967A010
		public void PreBakeRootMotion() {} // 0x000000018967AD30-0x000000018967AD80
		public void ClearPreBakeRootMotion() {} // 0x00000001896798CC-0x0000000189679990
		private void BakeRootMotion() {} // 0x0000000189679408-0x00000001896798CC
		private void EvaluateTrackClips(float time, float previousTime, ref int tempActiveClips) {} // 0x000000018967A174-0x000000018967A4C0
		private void ApplyBakedRootMotion(float time) {} // 0x0000000189679138-0x0000000189679408
	}

	[Attachable(new System.Type[1] {typeof(ActorGroup) })]
	[Category("Legacy")]
	[Description("** This Track is deprecated. Please use Animator Track instead. **\n\nThe Mecanim Track works with an \'Animator\' component attached on the actor and with it\'s assigned Controller by modifying the Controller\'s parameters.\n\nConsider working with the new Animator Track instead to playback animation clips directly without the need of a Controller, which is more intuitive for animations.")]
	[Icon(typeof(Animator))]
	public class MecanimTrack : CutsceneTrack // TypeDefIndex: 54620
	{
		// Fields
		private Animator animator; // 0x50
	
		// Constructors
		public MecanimTrack() {} // 0x0000000189671E98-0x0000000189671EA0
	
		// Methods
		protected override bool OnInitialize() => default; // 0x0000000189686AB4-0x0000000189686C20
		protected override void OnReverse() {} // 0x0000000189686AAC-0x0000000189686AB4
		protected override void OnExit() {} // 0x0000000189686AAC-0x0000000189686AB4
		private void DestroyDispatcher() {} // 0x0000000189686A18-0x0000000189686AAC
	}

	[Description("All audio clips played by this track will be send to the selected AudioMixer if any.")]
	[Icon(typeof(AudioClip))]
	[Name("Audio Track")]
	public abstract class AudioTrack : CutsceneTrack // TypeDefIndex: 54621
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
	
		// Properties
		public override string info { get; } // 0x000000018967B4A4-0x000000018967B574 
		public AudioSource source { get; private set; } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
		public AudioSampler.SampleSettings sampleSettings { get; private set; } // 0x0000000183D74F00-0x0000000183D74F20 0x0000000183D74F20-0x0000000183D74F40
		public AudioMixerGroup mixer { get; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		public virtual bool useAudioSourceOnActor { get; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		protected AudioTrack() {} // 0x0000000189671EA0-0x0000000189671EB8
	
		// Methods
		protected override void OnEnter() {} // 0x000000018967B2E4-0x000000018967B2EC
		protected override void OnReverseEnter() {} // 0x000000018967B2E4-0x000000018967B2EC
		protected override void OnUpdate(float time, float previousTime) {} // 0x000000018967B2F4-0x000000018967B3F8
		protected override void OnExit() {} // 0x000000018967B2EC-0x000000018967B2F4
		protected override void OnReverse() {} // 0x000000018967B2EC-0x000000018967B2F4
		private void Enable() {} // 0x000000018967B208-0x000000018967B2E4
		private void Disable() {} // 0x000000018967B1A8-0x000000018967B208
		private void SetAndApplySettings() {} // 0x000000018967B3F8-0x000000018967B498
		public void SetVolume(float volume) {} // 0x000000018967B498-0x000000018967B4A4
	}

	[Attachable(new System.Type[1] {typeof(DirectorGroup) })]
	[Description("The Camera Track is the track within wich you create your camera shots and moves. Once the Camera Track becomes active, the Director Camera will be enabled. You can control when the Director Camera takes effect by setting the \'Active Time Offset\', while the Blend In/Out parameters control the ammount of blending there will be from the game camera to the first and the last shot of the track.\nIf you don\'t want a cinematic letterbox effect, you can set CineBox Fade Time to 0.\nIf you don\'t want to use Slate Camera features, you can simply disable or delete this track.")]
	[Icon(typeof(Camera))]
	[UniqueElement]
	public class CameraTrack : CutsceneTrack // TypeDefIndex: 54622
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
	
		// Properties
		public CameraShot firstShot { get; private set; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 0x00000001851DFC94-0x00000001851DFCA4
		public CameraShot lastShot { get; private set; } // 0x0000000183D4EA60-0x0000000183D4EA70 0x0000000184274DA0-0x0000000184274DB4
		public CameraShot currentShot { get; set; } // 0x0000000183D4EA90-0x0000000183D4EAA0 0x00000001851DFCB4-0x00000001851DFCC8
		public override string info { get => default; } // 0x000000018967D564-0x000000018967D5C8 
		public override float startTime { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x000000018967D63C-0x000000018967D690
		public override float endTime { get => default; set {} } // 0x000000018967D538-0x000000018967D564 0x000000018967D5C8-0x000000018967D63C
		public override float blendIn { get => default; set {} } // 0x000000018967D3E4-0x000000018967D48C 0x0000000183D510B0-0x0000000183D510C0
		public override float blendOut { get => default; set {} } // 0x000000018967D48C-0x000000018967D538 0x0000000183D5BDF0-0x0000000183D5BE00
	
		// Constructors
		public CameraTrack() {} // 0x000000018967D3CC-0x000000018967D3E4
	
		// Methods
		protected override void OnEnter() {} // 0x000000018967CC24-0x000000018967CE40
		protected override void OnUpdate(float time, float previousTime) {} // 0x000000018967D014-0x000000018967D34C
		protected override void OnExit() {} // 0x000000018967CE40-0x000000018967CEDC
		protected override void OnReverseEnter() {} // 0x000000018967CEDC-0x000000018967CF78
		protected override void OnReverse() {} // 0x000000018967CF78-0x000000018967D014
	}

	[Attachable(new System.Type[1] {typeof(DirectorGroup) })]
	public class DirectorActionTrack : ActionTrack // TypeDefIndex: 54623
	{
		// Constructors
		public DirectorActionTrack() {} // 0x0000000189671E98-0x0000000189671EA0
	}

	[Attachable(new System.Type[1] {typeof(DirectorGroup) })]
	public class DirectorAudioTrack : Slate.AudioTrack // TypeDefIndex: 54624
	{
		// Constructors
		public DirectorAudioTrack() {} // 0x0000000189671EA0-0x0000000189671EB8
	}

	[Attachable(new System.Type[1] {typeof(DirectorGroup) })]
	[Description("Use the Director Properties Track to animate any component property of the Director Camera. This is particularly useful to animate image effects rather than transforms, since transforms are handled by the CameraTrack and it\'s Shot Clips. You can still animate transforms if you are after a one-take, by having a CameraTrack without shot clips.")]
	public class DirectorPropertiesTrack : PropertiesTrack // TypeDefIndex: 54625
	{
		// Constructors
		public DirectorPropertiesTrack() {} // 0x0000000189672104-0x000000018967210C
	}

	[Attachable(new System.Type[1] {typeof(DirectorGroup) })]
	[Description("Plays video clips on the render camera. Please note that scrubbing might be choppy, but playing is not.")]
	[Icon(typeof(VideoPlayer))]
	[UniqueElement]
	public class VideoTrack : CutsceneTrack // TypeDefIndex: 54626
	{
		// Fields
		public VideoSampler.VideoRenderTarget renderTarget; // 0x50
		public VideoAspectRatio aspectRatio; // 0x54
	
		// Properties
		public VideoPlayer source { get; private set; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000183081D30-0x0000000183081D40
		public override string info { get => default; } // 0x00000001896883F8-0x0000000189688FCC 
	
		// Constructors
		public VideoTrack() {} // 0x00000001896883E8-0x00000001896883F8
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896883D8-0x00000001896883E0
		protected override void OnReverseEnter() {} // 0x00000001896883D8-0x00000001896883E0
		protected override void OnReverse() {} // 0x00000001896883E0-0x00000001896883E8
		protected override void OnExit() {} // 0x00000001896883E0-0x00000001896883E8
		private void Enable() {} // 0x0000000189688374-0x00000001896883D8
		private void Disable() {} // 0x0000000189688328-0x0000000189688374
	}

	[Category("Legacy")]
	[Description("With the Properties Track, you can select to animate any supported type property or field on any component on the actor, or within it\'s whole transform hierarchy.\n\nNote, that you can do exactly the same, by using the \'Animate Properties\' ActionClip added in an \'Action Track\'.")]
	[Name("Properties Track")]
	[UniqueElement]
	public abstract class PropertiesTrack : CutsceneTrack, IKeyable // TypeDefIndex: 54627
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private AnimationDataCollection _animationData; // 0x50
	
		// Properties
		public AnimationDataCollection animationData { get; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		public object animatedParametersTarget { get; } // 0x0000000189687048-0x0000000189687050 
	
		// Constructors
		protected PropertiesTrack() {} // 0x0000000189686FF0-0x0000000189687048
	
		// Methods
		protected override void OnAfterValidate() {} // 0x0000000189686EFC-0x0000000189686F24
		protected override void OnEnter() {} // 0x0000000189686F24-0x0000000189686F78
		protected override void OnUpdate(float time, float previousTime) {} // 0x0000000189686F98-0x0000000189686FF0
		protected override void OnReverse() {} // 0x0000000189686F78-0x0000000189686F98
	}

	[Attachable(new System.Type[1] {typeof(ActionTrack) })]
	public abstract class ActionClip : MonoBehaviour, IKeyable // TypeDefIndex: 54628
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _startTime; // 0x18
		[HideInInspector]
		[SerializeField]
		private AnimationDataCollection _animationData; // 0x20
		[NonSerialized]
		private string[] _cachedAnimParamPaths; // 0x38
	
		// Properties
		public IDirector root { get; } // 0x0000000189671BA0-0x0000000189671BC0 
		public IDirectable parent { get; private set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public GameObject actor { get; } // 0x000000018967188C-0x00000001896718AC 
		IEnumerable<IDirectable> IDirectable.children { get; } // 0x0000000181002730-0x0000000181002740 
		public AnimationDataCollection animationData { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public float startTime { get; set; } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000189671D9C-0x0000000189671E98
		public float endTime { get; set; } // 0x00000001896718E4-0x0000000189671910 0x0000000189671C80-0x0000000189671D9C
		public bool isActive { get; } // 0x0000000189671A94-0x0000000189671AD0 
		public bool isCollapsed { get; } // 0x0000000189671AD0-0x0000000189671AF0 
		public bool isLocked { get; } // 0x0000000189671AF0-0x0000000189671B10 
		public virtual float length { get; set; } // 0x0000000183D503F0-0x0000000183D50400 0x000000018350B670-0x000000018350B680
		public virtual float blendIn { get; set; } // 0x0000000183D503F0-0x0000000183D50400 0x000000018350B670-0x000000018350B680
		public virtual float blendOut { get; set; } // 0x0000000183D503F0-0x0000000183D50400 0x000000018350B670-0x000000018350B680
		public virtual bool canCrossBlend { get; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual string info { get; } // 0x00000001896719F0-0x0000000189671A94 
		public virtual bool isValid { get; } // 0x0000000189671B30-0x0000000189671B80 
		public virtual UnityEngine.Color color { get; } // 0x0000000185F47B78-0x0000000185F47B98 
		public virtual UnityEngine.Color textColor { get; } // 0x000000018426F8FC-0x000000018426F91C 
		public virtual int textSizeInner { get; } // 0x0000000183D55730-0x0000000183D55740 
		public virtual int textSizeOuter { get; } // 0x0000000183D55810-0x0000000183D55820 
		public virtual float interval { get; } // 0x0000000183D503F0-0x0000000183D50400 
		public virtual string url { get; } // 0x0000000189671BC0-0x0000000189671C80 
		public virtual bool isHighlight { get; set; } // 0x0000000183D4EF60-0x0000000183D4EF70 0x0000000183D4EF70-0x0000000183D4EF80
		public bool isReadOnly { get; } // 0x0000000189671B10-0x0000000189671B30 
		public virtual TransformSpace defaultTransformSpace { get; } // 0x0000000181002730-0x0000000181002740 
		private string[] animatedParameterPaths { get; } // 0x00000001896718AC-0x00000001896718E4 
		private bool handleParametersRegistrationManually { get; } // 0x0000000189671910-0x0000000189671934 
		public virtual object animatedParametersTarget { get; } // 0x000000018339AE90-0x000000018339AEA0 
		public virtual Slate.EaseType animatedParametersInterpolation { get; } // 0x0000000181002730-0x0000000181002740 
		public virtual bool useWeightInParameters { get; } // 0x000000018115F4C0-0x000000018115F530 
		public bool hasParameters { get; } // 0x00000001896719D8-0x00000001896719F0 
		public bool hasActiveParameters { get; } // 0x0000000189671934-0x00000001896719D8 
		public virtual bool needActor { get; } // 0x0000000189671B80-0x0000000189671BA0 
		public virtual bool canSample { get; } // 0x000000018232EB60-0x000000018232EB70 
		public virtual int updateOrder { get; } // 0x0000000183D5A950-0x0000000183D5A960 
		string IDirectable.name { get; } // 0x0000000184276114-0x000000018427611C 
	
		// Constructors
		protected ActionClip() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		bool IDirectable.Initialize() => default; // 0x0000000189671204-0x0000000189671214
		void IDirectable.Enter() {} // 0x00000001896711D0-0x00000001896711F4
		void IDirectable.Update(float time, float previousTime) {} // 0x0000000189671294-0x00000001896712D8
		void IDirectable.Exit() {} // 0x00000001896711F4-0x0000000189671204
		void IDirectable.ReverseEnter() {} // 0x0000000189671214-0x0000000189671224
		void IDirectable.Reverse() {} // 0x0000000189671224-0x0000000189671248
		void IDirectable.RootEnabled() {} // 0x0000000189671260-0x0000000189671278
		void IDirectable.RootDisabled() {} // 0x0000000189671248-0x0000000189671260
		void IDirectable.RootUpdated(float time, float previousTime) {} // 0x0000000189671278-0x0000000189671294
		void IDirectable.RootDestroyed() {} // 0x0000000183D4B9D0-0x0000000183D4B9E0
		public void PostCreate(IDirectable parent) {} // 0x0000000189671080-0x00000001896710B4
		public void Validate() {} // 0x0000000189671838-0x0000000189671848
		public void Validate(IDirector root, IDirectable parent) {} // 0x0000000189671848-0x000000018967188C
		protected virtual bool OnInitialize() => default; // 0x000000018232EB60-0x000000018232EB70
		protected virtual void OnEnter() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnUpdate(float time, float previousTime) {} // 0x0000000189671070-0x0000000189671080
		protected virtual void OnUpdate(float time) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnExit() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnReverse() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnReverseEnter() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnDrawGizmosSelected() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnSceneGUI() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnCreate() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnAfterValidate() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnRootEnabled() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnRootDisabled() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnRootUpdated(float time, float previousTime) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnRootDestroyed() {} // 0x000000018350B670-0x000000018350B680
		public bool RootTimeWithinRange() => default; // 0x0000000189671100-0x0000000189671108
		public Vector3 TransformPosition(Vector3 point, TransformSpace space) => default; // 0x00000001896712D8-0x0000000189671324
		public Vector3 InverseTransformPosition(Vector3 point, TransformSpace space) => default; // 0x0000000189670FE0-0x000000018967102C
		public Quaternion TransformRotation(Vector3 euler, TransformSpace space) => default; // 0x0000000189671324-0x0000000189671368
		public Vector3 InverseTransformRotation(Quaternion rot, TransformSpace space) => default; // 0x000000018967102C-0x0000000189671070
		public Vector3 ActorPositionInSpace(TransformSpace space) => default; // 0x0000000189670D70-0x0000000189670DA0
		public Transform GetSpaceTransform(TransformSpace space, GameObject actorOverride = null) => default; // 0x0000000189670FD8-0x0000000189670FE0
		public ActionClip GetPreviousClip() => default; // 0x0000000189670F9C-0x0000000189670FD8
		public ActionClip GetNextClip() => default; // 0x0000000189670F40-0x0000000189670F7C
		public float GetClipWeight() => default; // 0x0000000189670E7C-0x0000000189670EB8
		public float GetClipWeight(float time) => default; // 0x0000000189670EE4-0x0000000189670F40
		public float GetClipWeight(float time, float blendInOut) => default; // 0x0000000189670EB8-0x0000000189670ED4
		public float GetClipWeight(float time, float blendIn, float blendOut) => default; // 0x0000000189670ED4-0x0000000189670EE4
		public void TryMatchSubClipLength() {} // 0x00000001896714A4-0x0000000189671560
		public void TryMatchPreviousSubClipLoop() {} // 0x000000018967143C-0x00000001896714A4
		public void TryMatchNexSubClipLoop() {} // 0x0000000189671368-0x000000018967143C
		private string GetParameterName<T, TResult>(Expression<Func<T, TResult>> func) => default;
		public AnimatedParameter GetParameter<T, TResult>(Expression<Func<T, TResult>> func) => default;
		public AnimatedParameter GetParameter(string paramName) => default; // 0x0000000189670F7C-0x0000000189670F9C
		public void SetParameterEnabled<T, TResult>(Expression<Func<T, TResult>> func, bool enabled) {}
		public void SetParameterEnabled(string paramName, bool enabled) {} // 0x0000000189671168-0x00000001896711D0
		public void ResetAnimatedParameters() {} // 0x00000001896710B4-0x00000001896710C8
		private void CreateAnimationDataCollection() {} // 0x0000000189670DA0-0x0000000189670E7C
		private void ValidateAnimParams() {} // 0x000000018967163C-0x0000000189671838
		private void SetAnimParamsSnapshot() {} // 0x0000000189671108-0x0000000189671168
		private void UpdateAnimParams(float time, float previousTime) {} // 0x0000000189671560-0x000000018967163C
		private void RestoreAnimParamsSnapshot() {} // 0x00000001896710C8-0x0000000189671100
	}

	[Serializable]
	public class AnimatedParameter : IAnimatableData, ISerializationCallbackReceiver // TypeDefIndex: 54632
	{
		// Fields
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
		private static Dictionary<System.Type, System.Type> parameterModelsMap; // 0x08
		public static readonly System.Type[] supportedTypes; // 0x10
		[NonSerialized]
		private object _animatableAttribute; // 0x60
		[NonSerialized]
		private object _resolvedMemberObject; // 0x68
	
		// Properties
		public bool enabled { get => default; } // 0x0000000183D032E0-0x0000000183D032F0 
		private string serializedData { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		private SerializationMetaData data { get => default; } // 0x000000018967455C-0x00000001896745C8 
		public IAnimatedParameterModel parameterModel { get => default; } // 0x00000001896746C0-0x00000001896747AC 
		public AnimationCurve[] curves { get => default; private set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public string scriptExpression { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000189674910-0x0000000189674948
		public bool hasActiveExpression { get => default; } // 0x0000000189674608-0x0000000189674620 
		public string parameterName { get => default; } // 0x00000001896747AC-0x00000001896747CC 
		public System.Type animatedType { get => default; } // 0x000000018967453C-0x000000018967455C 
		public ParameterType parameterType { get => default; } // 0x00000001896747CC-0x00000001896747EC 
		public string transformHierarchyPath { get => default; } // 0x000000018967482C-0x000000018967484C 
		public System.Type declaringType { get => default; } // 0x00000001896745C8-0x00000001896745E8 
		public PropertyInfo property { get => default; } // 0x00000001896747EC-0x000000018967480C 
		public System.Reflection.FieldInfo field { get => default; } // 0x00000001896745E8-0x0000000189674608 
		public bool isProperty { get => default; } // 0x0000000189674638-0x0000000189674650 
		public IKeyable keyable { get; private set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		private float[] snapshot { get; set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		private float[] lastEval { get; set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		private Transform virtualTransformParent { get; set; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000183081D30-0x0000000183081D40
		public object targetObject { get => default; } // 0x000000018967480C-0x000000018967482C 
		public AnimatableParameterAttribute animatableAttribute { get => default; } // 0x0000000189674464-0x000000018967453C 
		public bool isExternal { get => default; } // 0x0000000189674620-0x0000000189674638 
		public bool isValid { get => default; } // 0x0000000189674650-0x00000001896746C0 
	
		// Events
		public static event Action<IAnimatableData> onParameterChanged;
	
		// Nested types
		[Serializable]
		private class SerializationMetaData // TypeDefIndex: 54629
		{
			// Fields
			public string parameterName; // 0x10
			public string declaringTypeName; // 0x18
			public string transformHierarchyPath; // 0x20
			public ParameterType parameterType; // 0x28
	
			// Properties
			public System.Type declaringType { get; private set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
			public PropertyInfo property { get; private set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
			public System.Reflection.FieldInfo field { get; private set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
			public System.Type animatedType { get; private set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
	
			// Constructors
			public SerializationMetaData() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void Deserialize() {} // 0x00000001896870D0-0x0000000189687248
		}
	
		public enum ParameterType // TypeDefIndex: 54630
		{
			NotSet = 0,
			Property = 1,
			Field = 2
		}
	
		// Constructors
		public AnimatedParameter() {} // Dummy constructor
		static AnimatedParameter() {} // 0x0000000189673FE0-0x0000000189674250
		public AnimatedParameter(IKeyable keyable, System.Type type, string memberPath, string transformPath) {} // 0x0000000189674250-0x00000001896743A0
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000189673FB0-0x0000000189673FE0
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x0000000189673F74-0x0000000189673FB0
		public void SetEnabled(bool value, float time) {} // 0x0000000189673D50-0x0000000189673DBC
		private void ConstructWithField(System.Reflection.FieldInfo targetField, System.Type type, string memberPath, string transformPath) {} // 0x0000000189672478-0x0000000189672648
		private void ConstructWithProperty(PropertyInfo targetProperty, System.Type type, string memberPath, string transformPath) {} // 0x0000000189672648-0x000000018967288C
		public MemberInfo GetMemberInfo() => default; // 0x00000001896732D0-0x0000000189673314
		public AnimationCurve[] GetCurves() => default; // 0x0000000183D4EB40-0x0000000183D4EB50
		public bool CompareTo(AnimatedParameter other) => default; // 0x00000001896723A4-0x0000000189672478
		private void InitializeCurves() {} // 0x00000001896733A8-0x0000000189673484
		public void Validate(IKeyable keyable) {} // 0x0000000183CB2D80-0x0000000183CB2D90
		public void SetVirtualTransformParent(Transform virtualTransformParent) {} // 0x0000000183081D30-0x0000000183081D40
		public void SetSnapshot() {} // 0x0000000189673E9C-0x0000000189673F0C
		public bool TryAutoKey(float time) => default; // 0x0000000189673F14-0x0000000189673F74
		public void Evaluate(float time, float previousTime, float weight = 1f /* Metadata: 0x01FD6710 */) {} // 0x0000000189672978-0x0000000189672A04
		private void Evaluate_1_Curves(float time, float previousTime, float weight = 1f /* Metadata: 0x01FD6714 */) {} // 0x000000018967288C-0x0000000189672978
		private bool Evaluate_2_Expression(float time, float previousTime, float weight = 1f /* Metadata: 0x01FD6718 */) => default; // 0x000000018115F4C0-0x000000018115F530
		public void RestoreSnapshot() {} // 0x0000000189673888-0x00000001896738E8
		public object GetEvalValue(float time) => default; // 0x00000001896730C8-0x000000018967319C
		public object ResolvedMemberObject() => default; // 0x0000000189673654-0x0000000189673888
		public object GetCurrentValueAsObject() => default; // 0x0000000189673084-0x00000001896730C8
		private float[] GetCurrentValueAsFloats() => default; // 0x0000000189672C84-0x0000000189673084
		public void SetCurrentValue(object value) {} // 0x00000001896738E8-0x0000000189673930
		private void SetCurrentValue(float[] floats) {} // 0x0000000189673930-0x0000000189673D50
		public bool HasChanged() => default; // 0x0000000189673320-0x0000000189673398
		public bool HasAnyKey() => default; // 0x0000000189673314-0x0000000189673320
		public bool HasKey(float time) => default; // 0x0000000189673398-0x00000001896733A8
		public float GetKeyNext(float time) => default; // 0x00000001896732B0-0x00000001896732C0
		public float GetKeyPrevious(float time) => default; // 0x00000001896732C0-0x00000001896732D0
		public bool TryKeyIdentity(float time) => default; // 0x000000018115F4C0-0x000000018115F530
		public void SetKeyCurrent(float time) {} // 0x000000018350B670-0x000000018350B680
		public void RemoveKey(float time) {} // 0x000000018350B670-0x000000018350B680
		public void SetPreWrapMode(UnityEngine.WrapMode mode) {} // 0x0000000189673E2C-0x0000000189673E9C
		public void SetPostWrapMode(UnityEngine.WrapMode mode) {} // 0x0000000189673DBC-0x0000000189673E2C
		public void OffsetValue(object deltaValue) {} // 0x00000001896734FC-0x000000018967358C
		public void Reset() {} // 0x000000018967358C-0x0000000189673654
		public void ChangeMemberType(ParameterType newType) {} // 0x0000000189672344-0x00000001896723A4
		public override string ToString() => default; // 0x0000000189673F0C-0x0000000189673F14
		public string FriendlyName() => default; // 0x0000000189672A04-0x0000000189672C84
		public string GetKeyLabel(float time) => default; // 0x000000018967319C-0x00000001896732B0
		private void RecordUndo() {} // 0x000000018350B670-0x000000018350B680
		private void NotifyChange() {} // 0x0000000189673484-0x00000001896734FC
	}

	public interface IAnimatedParameterModel // TypeDefIndex: 54633
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
	public struct Animated_Bool : IAnimatedParameterModel // TypeDefIndex: 54634
	{
		// Fields
		private Action<object, bool> setter; // 0x00
	
		// Methods
		public bool ForceStepMode() => default; // 0x000000018232EB60-0x000000018232EB70
		public int RequiredCurvesCount() => default; // 0x0000000181168950-0x0000000181168960
		public object ConvertToObject(params float[] floats) => default; // 0x00000001896749E4-0x0000000189674A48
		public float[] ConvertToFloats(object value) => default; // 0x0000000189674948-0x00000001896749E4
		public string GetKeyLabel(params float[] floats) => default; // 0x0000000189674B1C-0x0000000189674BA0
		public void SetDirect(object target, MemberInfo info, params float[] floats) {} // 0x0000000189674BA0-0x0000000189674C64
		public float[] GetDirect(object target, MemberInfo info) => default; // 0x0000000189674A48-0x0000000189674B1C
	}

	[Decorator(typeof(int))]
	public struct Animated_Int : IAnimatedParameterModel // TypeDefIndex: 54635
	{
		// Fields
		private Action<object, int> setter; // 0x00
	
		// Methods
		public bool ForceStepMode() => default; // 0x000000018232EB60-0x000000018232EB70
		public int RequiredCurvesCount() => default; // 0x0000000181168950-0x0000000181168960
		public object ConvertToObject(params float[] floats) => default; // 0x0000000189675B58-0x0000000189675BB4
		public float[] ConvertToFloats(object value) => default; // 0x0000000189675ACC-0x0000000189675B58
		public string GetKeyLabel(params float[] floats) => default; // 0x0000000189675C74-0x0000000189675CF0
		public void SetDirect(object target, MemberInfo info, params float[] floats) {} // 0x0000000189675CF0-0x0000000189675DA8
		public float[] GetDirect(object target, MemberInfo info) => default; // 0x0000000189675BB4-0x0000000189675C74
	}

	[Decorator(typeof(float))]
	public struct Animated_Float : IAnimatedParameterModel // TypeDefIndex: 54636
	{
		// Fields
		private Action<object, float> setter; // 0x00
	
		// Methods
		public bool ForceStepMode() => default; // 0x000000018115F4C0-0x000000018115F530
		public int RequiredCurvesCount() => default; // 0x0000000181168950-0x0000000181168960
		public object ConvertToObject(params float[] floats) => default; // 0x0000000189675878-0x00000001896758D8
		public float[] ConvertToFloats(object value) => default; // 0x00000001896757F0-0x0000000189675878
		public string GetKeyLabel(params float[] floats) => default; // 0x0000000189675998-0x0000000189675A14
		public void SetDirect(object target, MemberInfo info, params float[] floats) {} // 0x0000000189675A14-0x0000000189675ACC
		public float[] GetDirect(object target, MemberInfo info) => default; // 0x00000001896758D8-0x0000000189675998
	}

	[Decorator(typeof(Vector2))]
	public struct Animated_Vector2 : IAnimatedParameterModel // TypeDefIndex: 54637
	{
		// Fields
		private Action<object, Vector2> setter; // 0x00
	
		// Methods
		public bool ForceStepMode() => default; // 0x000000018115F4C0-0x000000018115F530
		public int RequiredCurvesCount() => default; // 0x0000000182102C70-0x0000000182102C80
		public object ConvertToObject(params float[] floats) => default; // 0x00000001896767EC-0x0000000189676858
		public float[] ConvertToFloats(object value) => default; // 0x0000000189676750-0x00000001896767EC
		public string GetKeyLabel(params float[] floats) => default; // 0x000000018967692C-0x00000001896769DC
		public void SetDirect(object target, MemberInfo info, params float[] floats) {} // 0x00000001896769DC-0x0000000189676AA8
		public float[] GetDirect(object target, MemberInfo info) => default; // 0x0000000189676858-0x000000018967692C
	}

	[Decorator(typeof(Vector3))]
	public struct Animated_Vector3 : IAnimatedParameterModel // TypeDefIndex: 54638
	{
		// Fields
		private Action<object, Vector3> setter; // 0x00
	
		// Methods
		public bool ForceStepMode() => default; // 0x000000018115F4C0-0x000000018115F530
		public int RequiredCurvesCount() => default; // 0x0000000183D555E0-0x0000000183D555F0
		public object ConvertToObject(params float[] floats) => default; // 0x0000000189676B48-0x0000000189676BC8
		public float[] ConvertToFloats(object value) => default; // 0x0000000189676AA8-0x0000000189676B48
		public string GetKeyLabel(params float[] floats) => default; // 0x0000000189676CA0-0x0000000189676D84
		public void SetDirect(object target, MemberInfo info, params float[] floats) {} // 0x0000000189676D84-0x0000000189676E64
		public float[] GetDirect(object target, MemberInfo info) => default; // 0x0000000189676BC8-0x0000000189676CA0
	}

	[Decorator(typeof(UnityEngine.Color))]
	public struct Animated_Color : IAnimatedParameterModel // TypeDefIndex: 54639
	{
		// Fields
		private Action<object, UnityEngine.Color> setter; // 0x00
	
		// Methods
		public bool ForceStepMode() => default; // 0x000000018115F4C0-0x000000018115F530
		public int RequiredCurvesCount() => default; // 0x0000000183D50CD0-0x0000000183D50CE0
		public object ConvertToObject(params float[] floats) => default; // 0x000000018967541C-0x00000001896754B8
		public float[] ConvertToFloats(object value) => default; // 0x0000000189675368-0x000000018967541C
		public string GetKeyLabel(params float[] floats) => default; // 0x00000001896755A4-0x00000001896756F0
		public void SetDirect(object target, MemberInfo info, params float[] floats) {} // 0x00000001896756F0-0x00000001896757F0
		public float[] GetDirect(object target, MemberInfo info) => default; // 0x00000001896754B8-0x00000001896755A4
	}

	[Decorator(typeof(Vector4))]
	public struct Animated_Vector4 : IAnimatedParameterModel // TypeDefIndex: 54640
	{
		// Fields
		private Action<object, Vector4> setter; // 0x00
	
		// Methods
		public bool ForceStepMode() => default; // 0x000000018115F4C0-0x000000018115F530
		public int RequiredCurvesCount() => default; // 0x0000000183D50CD0-0x0000000183D50CE0
		public object ConvertToObject(params float[] floats) => default; // 0x0000000189676F18-0x0000000189676FB4
		public float[] ConvertToFloats(object value) => default; // 0x0000000189676E64-0x0000000189676F18
		public string GetKeyLabel(params float[] floats) => default; // 0x00000001896770A0-0x0000000189677238
		public void SetDirect(object target, MemberInfo info, params float[] floats) {} // 0x0000000189677238-0x0000000189677338
		public float[] GetDirect(object target, MemberInfo info) => default; // 0x0000000189676FB4-0x00000001896770A0
	}

	[Decorator(typeof(Quaternion))]
	public struct Animated_Quaternion : IAnimatedParameterModel // TypeDefIndex: 54641
	{
		// Fields
		private Action<object, Quaternion> setter; // 0x00
	
		// Methods
		public bool ForceStepMode() => default; // 0x000000018115F4C0-0x000000018115F530
		public int RequiredCurvesCount() => default; // 0x0000000183D50CD0-0x0000000183D50CE0
		public object ConvertToObject(params float[] floats) => default; // 0x0000000189675E5C-0x0000000189675EF8
		public float[] ConvertToFloats(object value) => default; // 0x0000000189675DA8-0x0000000189675E5C
		public string GetKeyLabel(params float[] floats) => default; // 0x0000000189675FE4-0x000000018967617C
		public void SetDirect(object target, MemberInfo info, params float[] floats) {} // 0x000000018967617C-0x000000018967627C
		public float[] GetDirect(object target, MemberInfo info) => default; // 0x0000000189675EF8-0x0000000189675FE4
	}

	[Decorator(typeof(Rect))]
	public struct Animated_Rect : IAnimatedParameterModel // TypeDefIndex: 54642
	{
		// Fields
		private Action<object, Rect> setter; // 0x00
	
		// Methods
		public bool ForceStepMode() => default; // 0x000000018115F4C0-0x000000018115F530
		public int RequiredCurvesCount() => default; // 0x0000000183D50CD0-0x0000000183D50CE0
		public object ConvertToObject(params float[] floats) => default; // 0x0000000189676330-0x00000001896763CC
		public float[] ConvertToFloats(object value) => default; // 0x000000018967627C-0x0000000189676330
		public string GetKeyLabel(params float[] floats) => default; // 0x00000001896764B8-0x0000000189676650
		public void SetDirect(object target, MemberInfo info, params float[] floats) {} // 0x0000000189676650-0x0000000189676750
		public float[] GetDirect(object target, MemberInfo info) => default; // 0x00000001896763CC-0x00000001896764B8
	}

	[Decorator(typeof(Bounds))]
	public struct Animated_Bounds : IAnimatedParameterModel // TypeDefIndex: 54643
	{
		// Fields
		private Action<object, Bounds> setter; // 0x00
	
		// Methods
		public bool ForceStepMode() => default; // 0x000000018115F4C0-0x000000018115F530
		public int RequiredCurvesCount() => default; // 0x0000000183D51110-0x0000000183D51120
		public object ConvertToObject(params float[] floats) => default; // 0x0000000189674D88-0x0000000189674E88
		public float[] ConvertToFloats(object value) => default; // 0x0000000189674C64-0x0000000189674D88
		public string GetKeyLabel(params float[] floats) => default; // 0x0000000189674FE8-0x00000001896751FC
		public void SetDirect(object target, MemberInfo info, params float[] floats) {} // 0x00000001896751FC-0x0000000189675368
		public float[] GetDirect(object target, MemberInfo info) => default; // 0x0000000189674E88-0x0000000189674FE8
	}

	[Serializable]
	public class AnimationDataCollection : IAnimatableData // TypeDefIndex: 54651
	{
		// Fields
		[SerializeField]
		private List<AnimatedParameter> _animatedParameters; // 0x10
	
		// Properties
		public List<AnimatedParameter> animatedParameters { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public bool isValid { get => default; } // 0x0000000189678A08-0x0000000189678A4C 
		public AnimatedParameter this[int i] { get => default; } // 0x0000000189678998-0x0000000189678A00 
		public AnimatedParameter this[string name] { get => default; } // 0x0000000189678A00-0x0000000189678A08 
	
		// Nested types
		public delegate bool AddParameterDelegate(System.Type type, string memberPath, string transformPath); // TypeDefIndex: 54644; 0x0000000181035ED0-0x0000000181035EF0
	
		// Constructors
		public AnimationDataCollection() {} // 0x000000018350B670-0x000000018350B680
		public AnimationDataCollection(IKeyable keyable, System.Type type, string[] memberPaths, string transformPath) {} // 0x0000000189678914-0x0000000189678998
	
		// Methods
		public bool TryAddParameter(IKeyable keyable, System.Type type, string memberPath, string transformPath) => default; // 0x000000018967850C-0x0000000189678748
		public void RemoveParameter(AnimatedParameter animParam) {} // 0x000000018967805C-0x00000001896780B0
		public void ReOrderParameters() {} // 0x0000000189677DF0-0x0000000189677FE4
		public AnimatedParameter GetParameterOfName(string name) => default; // 0x0000000189677A10-0x0000000189677AE8
		public AnimationCurve[] GetCurves() => default; // 0x00000001896773FC-0x0000000189677408
		public AnimationCurve[] GetCurvesAll() => default; // 0x00000001896773F0-0x00000001896773FC
		private AnimationCurve[] Internal_GetCurves(bool enabledParamsOnly) => default; // 0x0000000189677C9C-0x0000000189677DF0
		public void Validate(IKeyable keyable) {} // 0x0000000189678880-0x0000000189678914
		public void SetVirtualTransformParent(Transform virtualTransformParent) {} // 0x00000001896783D4-0x0000000189678468
		public void SetSnapshot() {} // 0x0000000189678350-0x00000001896783D4
		public bool TryAutoKey(float time) => default; // 0x0000000189678748-0x0000000189678804
		public void Evaluate(float time, float previousTime, float weight = 1f /* Metadata: 0x01FD671F */) {} // 0x0000000189677338-0x00000001896773F0
		public void RestoreSnapshot() {} // 0x0000000189678134-0x00000001896781B8
		public bool TryKeyIdentity(float time) => default; // 0x0000000189678804-0x0000000189678880
		public void RemoveKey(float time) {} // 0x0000000189677FE4-0x000000018967805C
		public bool HasChanged() => default; // 0x0000000189677B74-0x0000000189677C00
		public bool HasKey(float time) => default; // 0x0000000189677C00-0x0000000189677C9C
		public bool HasAnyKey() => default; // 0x0000000189677AE8-0x0000000189677B74
		public void SetKeyCurrent(float time) {} // 0x00000001896781B8-0x0000000189678230
		public float GetKeyNext(float time) => default; // 0x00000001896775B8-0x00000001896777E4
		public float GetKeyPrevious(float time) => default; // 0x00000001896777E4-0x0000000189677A10
		public string GetKeyLabel(float time) => default; // 0x0000000189677408-0x00000001896775B8
		public void SetPreWrapMode(UnityEngine.WrapMode mode) {} // 0x00000001896782C0-0x0000000189678350
		public void SetPostWrapMode(UnityEngine.WrapMode mode) {} // 0x0000000189678230-0x00000001896782C0
		public void Reset() {} // 0x00000001896780B0-0x0000000189678134
		public override string ToString() => default; // 0x0000000189678468-0x000000018967850C
	}

	[DisallowMultipleComponent]
	public class Cutscene : MonoBehaviour, IDirector // TypeDefIndex: 54661
	{
		// Fields
		public const float VERSION_NUMBER = 2.15f; // Metadata: 0x01FD6726
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
	
		// Properties
		public Transform groupsRoot { get => default; } // 0x00000001896821F4-0x00000001896823A8 
		public UpdateMode updateMode { get => default; set {} } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
		public WrapMode defaultWrapMode { get => default; set {} } // 0x0000000183D4EE00-0x0000000183D4EE10 0x0000000183D4EE40-0x0000000183D4EE50
		public StopMode defaultStopMode { get => default; set {} } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000183D4ECB0-0x0000000183D4ECC0
		public bool playOnStart { get => default; set {} } // 0x0000000183D4EE90-0x0000000183D4EEA0 0x0000000183D4EEB0-0x0000000183D4EEC0
		public bool explicitActiveLayers { get => default; set {} } // 0x0000000183D4F7B0-0x0000000183D4F7C0 0x0000000183D4F7D0-0x0000000183D4F7E0
		public LayerMask activeLayers { get => default; set {} } // 0x0000000183D4EE80-0x0000000183D4EE90 0x0000000183D4EEA0-0x0000000183D4EEB0
		public DirectorGroup directorGroup { get => default; } // 0x000000018968204C-0x00000001896821F4 
		public ActorGroup actorGroup { get => default; } // 0x0000000189681DE8-0x0000000189681F10 
		public virtual bool abortDirectorCamera { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual bool multiSelectOverlapCheck { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public bool isBakingRootMotion { get; set; } // 0x0000000183D51D70-0x0000000183D51D80 0x0000000183D74F90-0x0000000183D74FA0
		public CameraTrack cameraTrack { get => default; } // 0x0000000189681F10-0x000000018968204C 
		public float currentTime { get => default; set {} } // 0x0000000183D56C10-0x0000000183D56C20 0x000000018968270C-0x0000000189682730
		public virtual float length { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000189682730-0x0000000189682740
		public float viewTimeMin { get => default; set {} } // 0x0000000183D4F670-0x0000000183D4F680 0x0000000189682818-0x000000018968283C
		public float viewTimeMax { get => default; set {} } // 0x0000000183D51080-0x0000000183D51090 0x000000018968278C-0x0000000189682818
		public float playTimeMin { get => default; set {} } // 0x0000000183D50D50-0x0000000183D50D60 0x0000000189682768-0x000000018968278C
		public float playTimeMax { get => default; set {} } // 0x0000000183D50D60-0x0000000183D50D70 0x0000000189682740-0x0000000189682768
		public float playbackSpeed { get => default; set {} } // 0x0000000183D4EC60-0x0000000183D4EC70 0x0000000183D4ECE0-0x0000000183D4ECF0
		public PlayingDirection playingDirection { get; set; } // 0x0000000183D4F3D0-0x0000000183D4F3E0 0x0000000183D4F420-0x0000000183D4F430
		public WrapMode playingWrapMode { get; set; } // 0x0000000183D4FB60-0x0000000183D4FB70 0x0000000183D4FB70-0x0000000183D4FB80
		public List<IDirectable> directables { get; private set; } // 0x00000001811AC510-0x00000001811AC520 0x00000001851417AC-0x00000001851417C0
		public bool isActive { get; private set; } // 0x0000000183D50A40-0x0000000183D50A50 0x0000000183D50A60-0x0000000183D50A70
		public bool isPaused { get; private set; } // 0x0000000183D50A50-0x0000000183D50A60 0x0000000183D50A70-0x0000000183D50A80
		public float previousTime { get; private set; } // 0x0000000183D56EE0-0x0000000183D56EF0 0x0000000183D74FA0-0x0000000183D74FB0
		bool IDirector.isReSampleFrame { get => default; } // 0x0000000183D51D10-0x0000000183D51D20 
		GameObject IDirector.context { get => default; } // 0x0000000189680D70-0x0000000189680DCC 
		IEnumerable<IDirectable> IDirector.children { get => default; } // 0x0000000189680D34-0x0000000189680D70 
		public float remainingTime { get => default; } // 0x00000001896823A8-0x00000001896823D4 
	
		// Events
		public static event Action<Cutscene> OnCutsceneStarted;
		public static event Action<Cutscene> OnCutsceneStopped;
		public event Action<Section> OnSectionReached;
		public event Action<string, object> OnGlobalMessageSend;
		public event Action OnStop;
	
		// Nested types
		public enum WrapMode // TypeDefIndex: 54652
		{
			Once = 0,
			Loop = 1,
			PingPong = 2
		}
	
		public enum StopMode // TypeDefIndex: 54653
		{
			Skip = 0,
			Rewind = 1,
			Hold = 2,
			SkipRewindNoUndo = 3
		}
	
		public enum UpdateMode // TypeDefIndex: 54654
		{
			Normal = 0,
			AnimatePhysics = 1,
			UnscaledTime = 2,
			Manual = 3
		}
	
		public enum PlayingDirection // TypeDefIndex: 54655
		{
			Forwards = 0,
			Backwards = 1
		}
	
		// Constructors
		public Cutscene() {} // 0x0000000189681A18-0x0000000189681AB0
		static Cutscene() {} // 0x0000000189681984-0x0000000189681A18
	
		// Methods
		protected void Awake() {} // 0x000000018967D9C4-0x000000018967DAFC
		protected void Start() {} // 0x0000000189680DCC-0x0000000189680DE0
		protected void OnDestroy() {} // 0x000000018967F5D4-0x000000018967F6D0
		public void ManualUpdate(float deltaTime) {} // 0x000000018967F5A0-0x000000018967F5D4
		protected void LateUpdate() {} // 0x000000018967F53C-0x000000018967F5A0
		protected void FixedUpdate() {} // 0x000000018967DFBC-0x000000018967E004
		private void DirectorSectionReached(Section section) {} // 0x000000018967DB54-0x000000018967DC24
		public IEnumerable<GameObject> GetAffectedActors() => default; // 0x000000018967E004-0x000000018967E12C
		public float[] GetPointerTimes() => default; // 0x000000018967E270-0x000000018967E3A4
		public void Play() {} // 0x0000000189680290-0x000000018968029C
		public void Play(Action callback) {} // 0x000000018967FFFC-0x000000018968000C
		public void Play(float startTime) {} // 0x000000018968000C-0x0000000189680034
		public void Play(float startTime, Action callback) {} // 0x000000018967FDF4-0x000000018967FE1C
		public void Play(float startTime, float endTime, WrapMode wrapMode = WrapMode.Once /* Metadata: 0x01FD6723 */, Action callback = null, PlayingDirection playDirection = PlayingDirection.Forwards /* Metadata: 0x01FD6724 */) {} // 0x0000000189680034-0x0000000189680290
		public void Stop() {} // 0x0000000189680FA4-0x0000000189680FB0
		public void Stop(StopMode stopMode) {} // 0x0000000189680E78-0x0000000189680FA4
		public void PlayReverse() {} // 0x000000018967FBEC-0x000000018967FBFC
		public void PlayReverse(float startTime, float endTime) {} // 0x000000018967FBFC-0x000000018967FC24
		public void Pause() {} // 0x0000000183D74F70-0x0000000183D74F80
		public void Resume() {} // 0x0000000183D74F80-0x0000000183D74F90
		public void SkipAll() {} // 0x0000000189680C74-0x0000000189680CA0
		public void Rewind() {} // 0x00000001896805F4-0x0000000189680624
		public void RewindNoUndo() {} // 0x00000001896805B0-0x00000001896805F4
		public void BreakCutsceneLoop() {} // 0x0000000183D74F60-0x0000000183D74F70
		public void BreakSectionLoop(bool alsoSkip = false /* Metadata: 0x01FD6725 */) {} // 0x000000018967DAFC-0x000000018967DB54
		[Obsolete("Use \'SkipCurrentSection\' instead")]
		public void Skip() {} // 0x0000000189680D2C-0x0000000189680D34
		public void SkipCurrentSection() {} // 0x0000000189680CA0-0x0000000189680D2C
		public bool JumpToSection(string name) => default; // 0x000000018967F518-0x000000018967F53C
		public bool JumpToSection(Section section) => default; // 0x000000018967F490-0x000000018967F518
		public bool PlayFromSection(string name) => default; // 0x000000018967FAA8-0x000000018967FAC8
		public bool PlayFromSection(string name, WrapMode wrap, Action callback = null) => default; // 0x000000018967FAE8-0x000000018967FB34
		public bool PlayFromSection(Section section) => default; // 0x000000018967FAC8-0x000000018967FAE8
		public bool PlayFromSection(Section section, WrapMode wrap, Action callback = null) => default; // 0x000000018967FB34-0x000000018967FBEC
		public bool PlaySection(string name) => default; // 0x000000018967FD74-0x000000018967FDA8
		public bool PlaySection(string name, WrapMode wrap, Action callback = null) => default; // 0x000000018967FD08-0x000000018967FD54
		public bool PlaySection(Section section) => default; // 0x000000018967FD54-0x000000018967FD74
		public bool PlaySection(Section section, WrapMode wrap, Action callback = null) => default; // 0x000000018967FC24-0x000000018967FD08
		public void Sample() {} // 0x0000000189680624-0x0000000189680634
		public void Sample(float time) {} // 0x0000000189680634-0x0000000189680744
		private void Internal_SamplePointers(float currentTime, float previousTime) {} // 0x000000018967F098-0x000000018967F490
		public void ReSample() {} // 0x00000001896802BC-0x000000018968032C
		public void Validate() {} // 0x0000000189681198-0x0000000189681984
		private void InitializeTimePointers() {} // 0x000000018967E614-0x000000018967EFFC
		private void OnSampleStarted() {} // 0x000000018967F890-0x000000018967FAA8
		private void OnSampleEnded() {} // 0x000000018967F6D0-0x000000018967F890
		private void SetLayersActive() {} // 0x0000000189680B24-0x0000000189680C74
		private void RestoreLayersActive() {} // 0x0000000189680424-0x00000001896805B0
		private void UpdateCutscene(float delta) {} // 0x0000000189680FF8-0x0000000189681198
		public static Cutscene Play(string name) => default; // 0x000000018967FDA8-0x000000018967FDF4
		public static Cutscene Play(string name, Action callback) => default; // 0x000000018967FE1C-0x000000018967FFFC
		public static Cutscene FindFromResources(string name) => default; // 0x000000018967DDA8-0x000000018967DEF0
		public static Cutscene Find(string name) => default; // 0x000000018967DEF0-0x000000018967DFBC
		public static void StopAllCutscenes() {} // 0x0000000189680DE0-0x0000000189680E78
		public void SendGlobalMessage(string message, object value = null) {} // 0x0000000189680744-0x0000000189680940
		public void SetGroupActorOfName(string groupName, GameObject newActor) {} // 0x0000000189680940-0x0000000189680B24
		public T FindElement<T>(string path)
			where T : IDirectable => default;
		public IDirectable FindElement(string path) => default; // 0x000000018967DC24-0x000000018967DDA8
		public override string ToString() => default; // 0x0000000189680FB0-0x0000000189680FF8
		public Section GetSectionByName(string name) => default; // 0x000000018967E3A4-0x000000018967E3D4
		public Section GetSectionByUID(string UID) => default; // 0x000000018967E3D4-0x000000018967E404
		public Section[] GetSections() => default; // 0x000000018967E5C0-0x000000018967E614
		public float GetSectionLength(string name) => default; // 0x000000018967E404-0x000000018967E488
		public string[] GetSectionNames() => default; // 0x000000018967E488-0x000000018967E5C0
		public string[] GetDefinedEventNames() => default; // 0x000000018967E12C-0x000000018967E270
		public void PreInitialize() {} // 0x000000018968029C-0x00000001896802BC
		public void RenderCutscene(int width, int height, int frameRate, Action<Texture2D[]> callback) {} // 0x000000018968032C-0x0000000189680424
		[IteratorStateMachine(typeof(_Internal_RenderCutscene_d__194))]
		private IEnumerator Internal_RenderCutscene(int width, int height, int frameRate, Action<Texture2D[]> callback) => default; // 0x000000018967EFFC-0x000000018967F098
	}

	public abstract class CutsceneGroup : MonoBehaviour, IDirectable // TypeDefIndex: 54670
	{
		// Fields
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
	
		// Properties
		public abstract new string name { get; set; }
		public abstract GameObject actor { get; set; }
		public abstract ActorReferenceMode referenceMode { get; set; }
		public abstract ActorInitialTransformation initialTransformation { get; set; }
		public abstract Vector3 initialLocalPosition { get; set; }
		public abstract Vector3 initialLocalRotation { get; set; }
		public abstract bool displayVirtualMeshGizmo { get; set; }
		public virtual bool needActor { get; } // 0x000000018232EB60-0x000000018232EB70 
		public virtual int updateOrder { get; } // 0x0000000183D5A950-0x0000000183D5A960 
		public bool customToggleValid { get; } // 0x000000018968F1A8-0x000000018968F214 
		public List<CutsceneTrack> tracks { get; set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public List<Section> sections { get; set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		IEnumerable<IDirectable> IDirectable.children { get; } // 0x000000018968E174-0x000000018968E1B0 
		float IDirectable.startTime { get; } // 0x0000000183D503F0-0x0000000183D50400 
		float IDirectable.endTime { get; } // 0x000000018968E1B0-0x000000018968E1CC 
		float IDirectable.blendIn { get; } // 0x0000000183D503F0-0x0000000183D50400 
		float IDirectable.blendOut { get; } // 0x0000000183D503F0-0x0000000183D50400 
		bool IDirectable.canCrossBlend { get; } // 0x000000018115F4C0-0x000000018115F530 
		IDirectable IDirectable.parent { get; } // 0x0000000181002730-0x0000000181002740 
		public IDirector root { get; private set; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
		public bool isActive { get; set; } // 0x0000000183D4F2C0-0x0000000183D4F2D0 0x000000018968F2B0-0x000000018968F2CC
		public bool isCollapsed { get; set; } // 0x0000000183D4EF60-0x0000000183D4EF70 0x0000000183D4EF70-0x0000000183D4EF80
		public bool isLocked { get; set; } // 0x000000018968F214-0x000000018968F224 0x0000000183D4F640-0x0000000183D4F650
		public bool isReadOnly { get; set; } // 0x0000000183D75040-0x0000000183D75050 0x0000000183D75050-0x0000000183D75060
	
		// Events
		public event Action<Section> OnSectionReached;
	
		// Nested types
		public enum ActorReferenceMode // TypeDefIndex: 54662
		{
			UseOriginal = 0,
			UseInstanceHideOriginal = 1
		}
	
		public enum ActorInitialTransformation // TypeDefIndex: 54663
		{
			UseOriginal = 0,
			UseLocal = 1
		}
	
		[Serializable]
		public class CustomToggleInfo // TypeDefIndex: 54664
		{
			// Fields
			public int startIndex; // 0x10
			public int endIndex; // 0x14
			public string desc; // 0x18
			public bool isCollapsed; // 0x20
	
			// Properties
			public int index { get; set; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
			public CutsceneGroup group { get; set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
	
			// Constructors
			public CustomToggleInfo() {} // 0x0000000183D68FC0-0x0000000183D68FD0
	
			// Methods
			private void _OnToggleChanged() {} // 0x000000018968D5CC-0x000000018968D5E4
			public IEnumerable _GetAllTrackNames() => default; // 0x000000018968D47C-0x000000018968D5CC
		}
	
		// Constructors
		protected CutsceneGroup() {} // 0x000000018968EF6C-0x000000018968F11C
		static CutsceneGroup() {} // 0x000000018968EF30-0x000000018968EF6C
	
		// Methods
		public void SetCustomToggleDirty() {} // 0x000000018968DDB8-0x000000018968DDC4
		private void _OnCustomToggleValueChanged() {} // 0x000000018968E72C-0x000000018968E888
		public bool CheckCustomCollapsed(int index) => default; // 0x000000018968D5E4-0x000000018968D774
		private void _TryRefreshCustomToggleInfo() {} // 0x000000018968E888-0x000000018968EF30
		public override string ToString() => default; // 0x000000018968E2B8-0x000000018968E2C8
		public void Validate(IDirector root, IDirectable parent) {} // 0x000000018968E438-0x000000018968E72C
		public Section GetSectionByName(string name) => default; // 0x000000018968D90C-0x000000018968DA5C
		public Section GetSectionByUID(string UID) => default; // 0x000000018968DA5C-0x000000018968DB2C
		public Section GetSectionAfter(float time) => default; // 0x000000018968D774-0x000000018968D840
		public Section GetSectionBefore(float time) => default; // 0x000000018968D840-0x000000018968D90C
		bool IDirectable.Initialize() => default; // 0x000000018968DE98-0x000000018968DF7C
		void IDirectable.Enter() {} // 0x000000018968DDC4-0x000000018968DE38
		void IDirectable.Reverse() {} // 0x000000018968DFDC-0x000000018968E03C
		void IDirectable.Update(float time, float previousTime) {} // 0x000000018968E03C-0x000000018968E174
		void IDirectable.Exit() {} // 0x000000018968DE38-0x000000018968DE98
		void IDirectable.ReverseEnter() {} // 0x000000018968DF7C-0x000000018968DFDC
		void IDirectable.RootEnabled() {} // 0x000000018350B670-0x000000018350B680
		void IDirectable.RootDisabled() {} // 0x000000018350B670-0x000000018350B680
		void IDirectable.RootUpdated(float time, float previousTime) {} // 0x000000018350B670-0x000000018350B680
		void IDirectable.RootDestroyed() {} // 0x000000018350B670-0x000000018350B680
		private void StoreActorState() {} // 0x000000018968E1CC-0x000000018968E2B8
		private void RestoreActorState() {} // 0x000000018968DC3C-0x000000018968DC8C
		private void TryInstantiateLocalActor() {} // 0x000000018968E2C8-0x000000018968E438
		private void ReleaseLocalActorInstance() {} // 0x000000018968DB2C-0x000000018968DBD0
		private void SetActorLocalCoords() {} // 0x000000018968DC8C-0x000000018968DDB8
		protected GameObject ResolveActor(GameObject original) => default; // 0x000000018968DBD0-0x000000018968DC3C
	}

	public abstract class CutsceneTrack : MonoBehaviour, IDirectable // TypeDefIndex: 54673
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
	
		// Properties
		public GameObject actor { get; } // 0x000000018968FE18-0x000000018968FE38 
		public new string name { get; set; } // 0x000000018968FF78-0x000000018968FFBC 0x000000018969005C-0x00000001896900A4
		public UnityEngine.Color color { get; } // 0x000000018968FE38-0x000000018968FE70 
		public List<ActionClip> clips { get; set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		public virtual string info { get; } // 0x000000018968FE90-0x000000018968FEC8 
		IEnumerable<IDirectable> IDirectable.children { get; } // 0x000000018968FA64-0x000000018968FAA0 
		public int layerOrder { get; private set; } // 0x0000000183D4EE80-0x0000000183D4EE90 0x0000000183D4EEA0-0x0000000183D4EEB0
		public IDirector root { get; } // 0x000000018968FFDC-0x000000018968FFFC 
		public IDirectable parent { get; private set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public virtual bool isCollapsed { get; } // 0x000000018968FEF4-0x000000018968FF14 
		public virtual bool isActive { get; set; } // 0x000000018968FEC8-0x000000018968FEF4 0x000000018969001C-0x000000018969005C
		public virtual bool isLocked { get; set; } // 0x000000018968FF14-0x000000018968FF48 0x0000000183D4F2D0-0x0000000183D4F2E0
		public virtual float startTime { get; set; } // 0x000000018968FFFC-0x000000018969001C 0x000000018350B670-0x000000018350B680
		public virtual float endTime { get; set; } // 0x000000018968FE70-0x000000018968FE90 0x000000018350B670-0x000000018350B680
		public virtual float blendIn { get; set; } // 0x0000000183D503F0-0x0000000183D50400 0x000000018350B670-0x000000018350B680
		public virtual float blendOut { get; set; } // 0x0000000183D503F0-0x0000000183D50400 0x000000018350B670-0x000000018350B680
		public bool canCrossBlend { get; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual bool needActor { get; } // 0x000000018968FFBC-0x000000018968FFDC 
		public virtual int updateOrder { get; } // 0x0000000183D5A950-0x0000000183D5A960 
		public bool isReadOnly { get; set; } // 0x000000018968FF48-0x000000018968FF78 0x0000000183D4EEB0-0x0000000183D4EEC0
	
		// Constructors
		protected CutsceneTrack() {} // 0x000000018968FD80-0x000000018968FE18
	
		// Methods
		bool IDirectable.Initialize() => default; // 0x000000018968FA20-0x000000018968FA30
		void IDirectable.Enter() {} // 0x000000018968FA00-0x000000018968FA10
		void IDirectable.Update(float time, float previousTime) {} // 0x000000018968FA50-0x000000018968FA64
		void IDirectable.Exit() {} // 0x000000018968FA10-0x000000018968FA20
		void IDirectable.ReverseEnter() {} // 0x000000018968FA30-0x000000018968FA40
		void IDirectable.Reverse() {} // 0x000000018968FA40-0x000000018968FA50
		void IDirectable.RootEnabled() {} // 0x000000018350B670-0x000000018350B680
		void IDirectable.RootDisabled() {} // 0x000000018350B670-0x000000018350B680
		void IDirectable.RootUpdated(float time, float previousTime) {} // 0x000000018350B670-0x000000018350B680
		void IDirectable.RootDestroyed() {} // 0x000000018350B670-0x000000018350B680
		public void PostCreate(IDirectable parent) {} // 0x000000018968F9D8-0x000000018968FA00
		public void Validate(IDirector root, IDirectable parent) {} // 0x000000018968FB24-0x000000018968FD80
		protected virtual void OnCreate() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnAfterValidate() {} // 0x000000018350B670-0x000000018350B680
		protected virtual bool OnInitialize() => default; // 0x000000018232EB60-0x000000018232EB70
		protected virtual void OnEnter() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnUpdate(float time, float previousTime) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnExit() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnReverseEnter() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnReverse() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnDrawGizmosSelected() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnSceneGUI() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnRootEnabled() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnRootDisabled() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnRootUpdated(float time, float previousTime) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnRootDestroyed() {} // 0x000000018350B670-0x000000018350B680
		public float GetTrackWeight() => default; // 0x000000018968F940-0x000000018968F9D8
		public float GetTrackWeight(float time) => default; // 0x000000018968F8E4-0x000000018968F940
		public float GetTrackWeight(float time, float blendInOut) => default; // 0x0000000189670EB8-0x0000000189670ED4
		public float GetTrackWeight(float time, float blendIn, float blendOut) => default; // 0x0000000189670ED4-0x0000000189670EE4
		public T AddAction<T>(float time)
			where T : ActionClip => default;
		public ActionClip AddAction(System.Type type, float time) => default; // 0x000000018968F604-0x000000018968F8E4
	}

	public interface IAnimatableData // TypeDefIndex: 54674
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

	public interface IDirectable // TypeDefIndex: 54675
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

	public interface IKeyable : IDirectable // TypeDefIndex: 54676
	{
		// Properties
		AnimationDataCollection animationData { get; }
		object animatedParametersTarget { get; }
	}

	public interface ISubClipContainable : IDirectable // TypeDefIndex: 54677
	{
		// Properties
		float subClipOffset { get; set; }
		float subClipSpeed { get; }
		float subClipLength { get; }
	}

	public static class IDirectableExtensions // TypeDefIndex: 54681
	{
		// Extension methods
		public static float GetLength(this IDirectable directable) => default; // 0x0000000189692620-0x000000018969265C
		public static float RootTimeToLocalTime(this IDirectable directable) => default; // 0x0000000189692E74-0x0000000189692EB0
		public static float RootTimeToLocalTimeUnclamped(this IDirectable directable) => default; // 0x0000000189692E38-0x0000000189692E74
		public static bool IsRootTimeWithinClip(this IDirectable directable) => default; // 0x0000000189692DB0-0x0000000189692DEC
		public static float ToLocalTime(this IDirectable directable, float time) => default; // 0x0000000189692EE0-0x0000000189692F40
		public static float ToLocalTimeUnclamped(this IDirectable directable, float time) => default; // 0x0000000189692EB0-0x0000000189692EE0
		public static bool IsTimeWithinClip(this IDirectable directable, float time) => default; // 0x0000000189692DEC-0x0000000189692E38
		public static bool CanCrossBlend(this IDirectable directable, IDirectable other) => default; // 0x0000000189692338-0x00000001896923C4
		public static bool CanBlendIn(this IDirectable directable) => default; // 0x0000000189692148-0x0000000189692240
		public static bool CanBlendOut(this IDirectable directable) => default; // 0x0000000189692240-0x0000000189692338
		public static bool CanScale(this IDirectable directable) => default; // 0x00000001896923C4-0x00000001896924AC
		public static bool WithinBufferTriggerRange(this IDirectable directable, float time, float previousTime, bool bypass = false /* Metadata: 0x01FD673B */) => default; // 0x0000000189693124-0x00000001896931B4
		public static IDirectable FindChild(this IDirectable directable, string name) => default; // 0x00000001896924AC-0x0000000189692594
		public static T GetPreviousSibling<T>(this IDirectable directable)
			where T : IDirectable => default;
		public static IDirectable GetPreviousSibling(this IDirectable directable) => default; // 0x0000000189692888-0x0000000189692984
		public static T GetNextSibling<T>(this IDirectable directable)
			where T : IDirectable => default;
		public static IDirectable GetNextSibling(this IDirectable directable) => default; // 0x00000001896926FC-0x00000001896927F8
		public static T GetFirstParentOfType<T>(this IDirectable directable)
			where T : IDirectable => default;
		public static float GetWeight(this IDirectable directable) => default; // 0x0000000189692BB4-0x0000000189692BD8
		public static float GetWeight(this IDirectable directable, float time) => default; // 0x0000000189692AC8-0x0000000189692B20
		public static float GetWeight(this IDirectable directable, float time, float blendInOut) => default; // 0x0000000189670EB8-0x0000000189670ED4
		public static float GetWeight(this IDirectable directable, float time, float blendIn, float blendOut) => default; // 0x0000000189692B20-0x0000000189692BB4
		public static Transform GetSpaceTransform(this IDirectable directable, TransformSpace space, GameObject actorOverride = null) => default; // 0x0000000189692984-0x0000000189692AC8
		public static Vector3 TransformPosition(this IDirectable directable, Vector3 point, TransformSpace space) => default; // 0x0000000189692F40-0x000000018969300C
		public static Vector3 InverseTransformPosition(this IDirectable directable, Vector3 point, TransformSpace space) => default; // 0x0000000189692BD8-0x0000000189692CA4
		public static Quaternion TransformRotation(this IDirectable directable, Vector3 euler, TransformSpace space) => default; // 0x000000018969300C-0x0000000189693124
		public static Vector3 InverseTransformRotation(this IDirectable directable, Quaternion rot, TransformSpace space) => default; // 0x0000000189692CA4-0x0000000189692DB0
		public static Vector3 ActorPositionInSpace(this IDirectable directable, TransformSpace space) => default; // 0x0000000189692014-0x0000000189692148
		public static float GetPreviousLoopLocalTime(this ISubClipContainable clip) => default; // 0x00000001896927F8-0x0000000189692888
		public static float GetNextLoopLocalTime(this ISubClipContainable clip) => default; // 0x000000018969265C-0x00000001896926FC
		public static AnimationCurve[] GetCurvesAll(this IKeyable keyable) => default; // 0x0000000189692594-0x0000000189692620
	}

	public interface IDirector // TypeDefIndex: 54682
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
	public class Section // TypeDefIndex: 54684
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
	
		// Properties
		public int currentLoopIteration { get; private set; } // 0x0000000183D4ED80-0x0000000183D4ED90 0x0000000183D4EDB0-0x0000000183D4EDC0
		public string UID { get => default; private set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public string name { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public float time { get => default; set {} } // 0x0000000183D4F2E0-0x0000000183D4F2F0 0x0000000183D4F2F0-0x0000000183D4F300
		public ExitMode exitMode { get => default; set {} } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
		public int loopCount { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
		public UnityEngine.Color color { get => default; set {} } // 0x00000001896982A0-0x0000000189698310 0x0000000183D56F80-0x0000000183D56F90
		public bool colorizeBackground { get => default; set {} } // 0x0000000183D4F460-0x0000000183D4F470 0x0000000183D4F470-0x0000000183D4F480
	
		// Nested types
		public enum ExitMode // TypeDefIndex: 54683
		{
			Continue = 0,
			Loop = 1
		}
	
		// Constructors
		public Section() {} // Dummy constructor
		public Section(string name, float time) {} // 0x00000001896981F0-0x00000001896982A0
		static Section() {} // 0x0000000189698184-0x00000001896981F0
	
		// Methods
		public void ResetLoops() {} // 0x0000000183D750C0-0x0000000183D750D0
		public void BreakLoop() {} // 0x0000000183D750B0-0x0000000183D750C0
		public bool TryUpdateLoop() => default; // 0x0000000189698164-0x0000000189698184
		public override string ToString() => default; // 0x00000001896980F0-0x0000000189698164
	}

	public interface IDirectableTimePointer // TypeDefIndex: 54685
	{
		// Properties
		IDirectable target { get; }
		float time { get; }
	
		// Methods
		void TriggerForward(float currentTime, float previousTime);
		void TriggerBackward(float currentTime, float previousTime);
		void Update(float currentTime, float previousTime);
	}

	public struct StartTimePointer : IDirectableTimePointer // TypeDefIndex: 54686
	{
		// Fields
		private bool triggered; // 0x00
		private float lastTargetStartTime; // 0x04
	
		// Properties
		public IDirectable target { [IsReadOnly] get; private set; } // 0x0000000183D50DE0-0x0000000183D50DF0 0x000000018558FF08-0x000000018558FF18
		float IDirectableTimePointer.time { get => default; } // 0x00000001896995B8-0x00000001896995D4 
	
		// Constructors
		public StartTimePointer(IDirectable target) : this() {
			triggered = default;
			lastTargetStartTime = default;
		} // 0x00000001896995D4-0x0000000189699610
	
		// Methods
		void IDirectableTimePointer.TriggerForward(float currentTime, float previousTime) {} // 0x00000001896993EC-0x0000000189699468
		void IDirectableTimePointer.Update(float currentTime, float previousTime) {} // 0x0000000189699468-0x00000001896995B8
		void IDirectableTimePointer.TriggerBackward(float currentTime, float previousTime) {} // 0x0000000189699350-0x00000001896993EC
	}

	public struct EndTimePointer : IDirectableTimePointer // TypeDefIndex: 54687
	{
		// Fields
		private bool triggered; // 0x00
	
		// Properties
		public IDirectable target { [IsReadOnly] get; private set; } // 0x0000000183D50DE0-0x0000000183D50DF0 0x000000018558FF08-0x000000018558FF18
		float IDirectableTimePointer.time { get => default; } // 0x00000001896919A4-0x00000001896919C0 
	
		// Constructors
		public EndTimePointer(IDirectable target) : this() {
			triggered = default;
		} // 0x00000001896919C0-0x00000001896919E0
	
		// Methods
		void IDirectableTimePointer.TriggerForward(float currentTime, float previousTime) {} // 0x00000001896918C4-0x0000000189691958
		void IDirectableTimePointer.Update(float currentTime, float previousTime) {} // 0x0000000189691958-0x00000001896919A4
		void IDirectableTimePointer.TriggerBackward(float currentTime, float previousTime) {} // 0x000000018969183C-0x00000001896918C4
	}

	[AddComponentMenu("SLATE/Path")]
	public class BezierPath : Path // TypeDefIndex: 54688
	{
		// Fields
		[Range(0f, 100f)]
		public int resolution; // 0x18
		[SerializeField]
		private List<Slate.BezierPoint> _points; // 0x20
		private Vector3[] _sampledPathPoints; // 0x28
		private float _length; // 0x30
	
		// Properties
		public List<Slate.BezierPoint> points { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public Slate.BezierPoint this[int index] { get => default; } // 0x000000018968BA1C-0x000000018968BA70 
		public int pointCount { get => default; } // 0x000000018968BA70-0x000000018968BAB0 
		public override float length { get => default; } // 0x0000000183D4F5D0-0x0000000183D4F5E0 
	
		// Constructors
		public BezierPath() {} // 0x000000018968B994-0x000000018968BA1C
	
		// Methods
		private void Awake() {} // 0x000000018968B140-0x000000018968B150
		private void OnValidate() {} // 0x000000018968B140-0x000000018968B150
		public override void Compute() {} // 0x000000018968B2DC-0x000000018968B304
		public void SetDirty() {} // 0x000000018968B140-0x000000018968B150
		private void ComputeLength() {} // 0x000000018968B150-0x000000018968B170
		private void ComputeSampledPathPoints() {} // 0x000000018968B170-0x000000018968B2DC
		public static BezierPath Create(Transform targetParent = null) => default; // 0x000000018968B304-0x000000018968B5CC
		public Slate.BezierPoint AddPointAt(Vector3 position, int index = -1 /* Metadata: 0x01FD673E */) => default; // 0x000000018968B058-0x000000018968B140
		public void RemovePoint(Slate.BezierPoint point) {} // 0x000000018968B934-0x000000018968B994
		public int GetPointIndex(Slate.BezierPoint point) => default; // 0x000000018968B5CC-0x000000018968B650
		public static Vector3[] GetSampledPathPositions(Slate.BezierPoint p1, Slate.BezierPoint p2, int resolution) => default; // 0x000000018968B828-0x000000018968B934
		public override Vector3 GetPositionAt(float t) => default; // 0x000000018968B758-0x000000018968B828
		public static Vector3 GetPositionAt(Slate.BezierPoint p1, Slate.BezierPoint p2, float t) => default; // 0x000000018968B650-0x000000018968B758
	}

	[Serializable]
	public class BezierPoint // TypeDefIndex: 54690
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
		public HandleStyle handleStyle { get => default; set {} } // 0x0000000183D4ED90-0x0000000183D4EDA0 0x0000000183D4EDC0-0x0000000183D4EDD0
		public BezierPath path { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public Vector3 position { get => default; set {} } // 0x000000018968BC48-0x000000018968BCB8 0x000000018968BFA0-0x000000018968C00C
		public Vector3 handle1LocalPosition { get => default; private set {} } // 0x0000000183D59780-0x0000000183D597A0 0x000000018968BCB8-0x000000018968BD70
		public Vector3 handle2LocalPosition { get => default; private set {} } // 0x0000000183D51B80-0x0000000183D51BA0 0x000000018968BE2C-0x000000018968BEE4
		public Vector3 handle1Position { get => default; set {} } // 0x000000018968BAF0-0x000000018968BB9C 0x000000018968BD70-0x000000018968BE2C
		public Vector3 handle2Position { get => default; set {} } // 0x000000018968BB9C-0x000000018968BC48 0x000000018968BEE4-0x000000018968BFA0
	
		// Nested types
		public enum HandleStyle // TypeDefIndex: 54689
		{
			Connected = 0,
			Broken = 1
		}
	
		// Constructors
		public BezierPoint() {} // Dummy constructor
		public BezierPoint(BezierPath path, Vector3 position) {} // 0x000000018968BAB0-0x000000018968BAF0
	}

	public abstract class Path : MonoBehaviour // TypeDefIndex: 54691
	{
		// Properties
		public abstract float length { get; }
	
		// Constructors
		protected Path() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public abstract Vector3 GetPositionAt(float t);
		public abstract void Compute();
		public static Vector3 GetPositionAlongCurve(Vector3 from, Vector3 to, Vector3 fromTangent, Vector3 toTangent, float t) => default; // 0x0000000189693BF4-0x0000000189693DEC
		public static Vector3 GetPosition(float t, params Vector3[] path) => default; // 0x0000000189693DEC-0x0000000189693FF0
		public static float GetLength(Vector3[] path) => default; // 0x0000000189693B48-0x0000000189693BF4
	}

	public static class AnimationDataUtility // TypeDefIndex: 54692
	{
		// Methods
		public static string[] GetAnimatableMemberPaths(object root) => default; // 0x000000018968A178-0x000000018968A1D4
		private static string[] Internal_GetAnimatableMemberPaths(System.Type type, string path) => default; // 0x000000018968A1D4-0x000000018968A54C
	}

	[ExecuteInEditMode]
	public class AnimatorDispatcher : MonoBehaviour // TypeDefIndex: 54693
	{
		// Fields
		private Animator _animator; // 0x20
	
		// Properties
		private Animator animator { get => default; } // 0x000000018968A5EC-0x000000018968A678 
	
		// Events
		public event Action<int> onAnimatorIK;
	
		// Constructors
		public AnimatorDispatcher() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void OnAnimatorIK(int index) {} // 0x000000018968A54C-0x000000018968A560
	}

	public static class AudioSampler // TypeDefIndex: 54695
	{
		// Fields
		private const string ROOT_NAME = "_AudioSources"; // Metadata: 0x01FD6741
		private static GameObject root; // 0x00
		private static Dictionary<object, AudioSource> sources; // 0x08
	
		// Nested types
		[Serializable]
		public struct SampleSettings // TypeDefIndex: 54694
		{
			// Fields
			public float volume; // 0x00
			public float pitch; // 0x04
			public float pan; // 0x08
			public float spatialBlend; // 0x0C
			public bool ignoreTimescale; // 0x10
			public bool bypassReverb; // 0x11
	
			// Methods
			public static SampleSettings Default() => default; // 0x0000000183D75060-0x0000000183D75080
		}
	
		// Constructors
		static AudioSampler() {} // 0x000000018968AFC4-0x000000018968B058
	
		// Methods
		public static AudioSource GetSourceForID(object keyID) => default; // 0x000000018968A704-0x000000018968A9E0
		public static void ReleaseSourceForID(object keyID) {} // 0x000000018968A9E0-0x000000018968AB6C
		public static void SampleForID(object keyID, AudioClip clip, float time, float previousTime, float volume) {} // 0x000000018968AB6C-0x000000018968AC30
		public static void SampleForID(object keyID, AudioClip clip, float time, float previousTime, SampleSettings settings) {} // 0x000000018968AC30-0x000000018968ACD4
		public static void Sample(AudioSource source, AudioClip clip, float time, float previousTime, float volume) {} // 0x000000018968ACD4-0x000000018968AD98
		public static void Sample(AudioSource source, AudioClip clip, float time, float previousTime, SampleSettings settings) {} // 0x000000018968AD98-0x000000018968AFC4
	}

	public static class ColorUtility // TypeDefIndex: 54696
	{
		// Methods
		public static UnityEngine.Color Grey(float value) => default; // 0x0000000183D71F80-0x0000000183D71FA0
	
		// Extension methods
		public static UnityEngine.Color WithAlpha(this UnityEngine.Color color, float alpha) => default; // 0x0000000183D71FA0-0x0000000183D71FC0
	}

	public enum TangentMode // TypeDefIndex: 54697
	{
		Editable = 0,
		Smooth = 1,
		Linear = 2,
		Constant = 3
	}

	public static class CurveUtility // TypeDefIndex: 54702
	{
		// Fields
		private const float KEY_PROXIMITY_TOLERANCE = 0.001f; // Metadata: 0x01FD6753
	
		// Methods
		public static float GetKeyNext(float time, params AnimationCurve[] curves) => default; // 0x000000018968CB4C-0x000000018968CD98
		public static float GetKeyPrevious(float time, params AnimationCurve[] curves) => default; // 0x000000018968CD98-0x000000018968D000
		public static bool HasKey(float time, params AnimationCurve[] curves) => default; // 0x000000018968D054-0x000000018968D198
		public static bool HasAnyKey(params AnimationCurve[] curves) => default; // 0x000000018968D000-0x000000018968D054
	
		// Extension methods
		public static void OffsetCurveValue(this AnimationCurve curve, float deltaValue) {} // 0x000000018968D288-0x000000018968D328
		public static void OffsetCurveTime(this AnimationCurve curve, float deltaTime) {} // 0x000000018968D198-0x000000018968D288
		public static void RemoveNegativeKeys(this AnimationCurve curve) {} // 0x000000018968D468-0x000000018968D47C
		public static void RemoveKeysOffRange(this AnimationCurve curve, float min, float max) {} // 0x000000018968D328-0x000000018968D468
	}

	public class DecoratorAttribute : Attribute // TypeDefIndex: 54703
	{
		// Fields
		public readonly System.Type targetType; // 0x10
	
		// Constructors
		public DecoratorAttribute() {} // Dummy constructor
		public DecoratorAttribute(System.Type targetType) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	public interface IDecorator // TypeDefIndex: 54704
	{
		// Properties
		object Target { get; set; }
	}

	public static class DecoratorFactory // TypeDefIndex: 54705
	{
		// Fields
		private static Dictionary<System.Type, System.Type> decoratorsTypeMap; // 0x00
		private static Dictionary<object, IDecorator> decoratorsInstanceMap; // 0x08
	
		// Constructors
		static DecoratorFactory() {} // 0x00000001896900A4-0x0000000189690198
	
		// Methods
		public static T GetDecorator<T>(object target)
			where T : IDecorator => default;
		private static T CreateDecorator<T>(System.Type targetType)
			where T : IDecorator => default;
	
		// Extension methods
		public static T Decorator<T>(this object target)
			where T : IDecorator => default;
	}

	public enum EaseType // TypeDefIndex: 54706
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

	public static class Easing // TypeDefIndex: 54707
	{
		// Methods
		public static float Ease(Slate.EaseType type, float from, float to, float t) => default; // 0x0000000189690E24-0x0000000189690EA8
		public static Vector3 Ease(Slate.EaseType type, Vector3 from, Vector3 to, float t) => default; // 0x0000000189691028-0x000000018969110C
		public static Quaternion Ease(Slate.EaseType type, Quaternion from, Quaternion to, float t) => default; // 0x0000000189690EA8-0x0000000189690F6C
		public static UnityEngine.Color Ease(Slate.EaseType type, UnityEngine.Color from, UnityEngine.Color to, float t) => default; // 0x0000000189690F6C-0x0000000189691028
		public static Func<float, float> Function(Slate.EaseType type) => default; // 0x000000018969110C-0x000000018969183C
		public static float Linear(float t) => default; // 0x000000018350B670-0x000000018350B680
		public static float QuadraticIn(float t) => default; // 0x0000000183D51490-0x0000000183D514A0
		public static float QuadraticOut(float t) => default; // 0x0000000183D721C0-0x0000000183D721E0
		public static float QuadraticInOut(float t) => default; // 0x00000001893BB5FC-0x00000001893BB658
		public static float QuarticIn(float t) => default; // 0x0000000183D721E0-0x0000000183D721F0
		public static float QuarticOut(float t) => default; // 0x0000000183D721F0-0x0000000183D72220
		public static float QuarticInOut(float t) => default; // 0x00000001893BB658-0x00000001893BB6AC
		public static float QuinticIn(float t) => default; // 0x0000000183D72220-0x0000000183D72240
		public static float QuinticOut(float t) => default; // 0x0000000183D72240-0x0000000183D72270
		public static float QuinticInOut(float t) => default; // 0x00000001893BB6AC-0x00000001893BB708
		public static float CubicIn(float t) => default; // 0x0000000183D525D0-0x0000000183D525E0
		public static float CubicOut(float t) => default; // 0x0000000183D720B0-0x0000000183D720D0
		public static float CubicInOut(float t) => default; // 0x00000001893BA9AC-0x00000001893BAA14
		public static float SinusoidalIn(float t) => default; // 0x00000001893BB708-0x00000001893BB738
		public static float SinusoidalOut(float t) => default; // 0x00000001893BB738-0x00000001893BB750
		public static float SinusoidalInOut(float t) => default; // 0x0000000183D72270-0x0000000183D722A0
		public static float ExponentialIn(float t) => default; // 0x00000001893BAE5C-0x00000001893BAE88
		public static float ExponentialOut(float t) => default; // 0x00000001893BAE88-0x00000001893BAECC
		public static float ExponentialInOut(float t) => default; // 0x00000001893BADDC-0x00000001893BAE5C
		public static float CircularIn(float t) => default; // 0x0000000183D72020-0x0000000183D72080
		public static float CircularOut(float t) => default; // 0x0000000183D72080-0x0000000183D720B0
		public static float CircularInOut(float t) => default; // 0x00000001893BA948-0x00000001893BA9AC
		public static float ElasticIn(float t) => default; // 0x0000000183D720D0-0x0000000183D72150
		public static float ElasticOut(float t) => default; // 0x0000000183D72150-0x0000000183D721C0
		public static float ElasticInOut(float t) => default; // 0x00000001893BACFC-0x00000001893BADDC
		public static float BounceIn(float t) => default; // 0x00000001893BA87C-0x00000001893BA8B0
		public static float BounceOut(float t) => default; // 0x00000001893BA8B0-0x00000001893BA948
		public static float BounceInOut(float t) => default; // 0x00000001893BA810-0x00000001893BA87C
		public static float BackIn(float t) => default; // 0x0000000183D71FD0-0x0000000183D71FF0
		public static float BackOut(float t) => default; // 0x0000000183D71FF0-0x0000000183D72020
		public static float BackInOut(float t) => default; // 0x00000001893BA7A8-0x00000001893BA810
	}

	public interface ITransformRefParameter // TypeDefIndex: 54708
	{
		// Properties
		Transform transform { get; }
		TransformSpace space { get; }
		bool useAnimation { get; }
	}

	public class ObjectSnapshot // TypeDefIndex: 54709
	{
		// Fields
		private static List<System.Type> ignoreTypes; // 0x00
		private Dictionary<UnityEngine.Object, string> serialized; // 0x10
	
		// Constructors
		public ObjectSnapshot() {} // Dummy constructor
		public ObjectSnapshot(UnityEngine.Object target, bool fullObjectHierarchy = false /* Metadata: 0x01FD6776 */) {} // 0x0000000189693AA8-0x0000000189693B48
		static ObjectSnapshot() {} // 0x0000000189693A1C-0x0000000189693AA8
	
		// Methods
		public static void AppendIgnoreType(System.Type type) {} // 0x0000000189693470-0x0000000189693520
		public void Store(UnityEngine.Object target, bool fullObjectHierarchy = false /* Metadata: 0x01FD6777 */) {} // 0x0000000189693760-0x0000000189693A1C
		public void Restore() {} // 0x0000000189693520-0x0000000189693760
	}

	public static class RectUtility // TypeDefIndex: 54710
	{
		// Methods
		public static Rect GetBoundRect(params Rect[] rects) => default; // 0x00000001893AB5C4-0x00000001893AB6E4
		public static Rect GetBoundRect(params Vector2[] positions) => default; // 0x00000001893AB6E4-0x00000001893AB7F4
	
		// Extension methods
		public static bool Encapsulates(this Rect a, Rect b) => default; // 0x0000000189695A80-0x0000000189695B38
		public static Rect ExpandBy(this Rect rect, float margin) => default; // 0x0000000189695B9C-0x0000000189695BD8
		public static Rect ExpandBy(this Rect rect, float xMargin, float yMargin) => default; // 0x0000000189695B38-0x0000000189695B9C
		public static Rect TransformSpace(this Rect rect, Rect oldContainer, Rect newContainer) => default; // 0x00000001893AB874-0x00000001893AB9AC
		public static Rect ToViewRect(this Bounds b, Camera cam) => default; // 0x0000000189695BD8-0x000000018969634C
	}

	public static class ReflectionTools // TypeDefIndex: 54713
	{
		// Fields
		private const System.Reflection.BindingFlags flagsEverything = System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic; // Metadata: 0x01FD677B
		private static List<Assembly> _loadedAssemblies; // 0x00
		private static Dictionary<string, System.Type> typeMap; // 0x08
		private static Dictionary<System.Type, System.Type[]> subTypesMap; // 0x10
	
		// Properties
		private static List<Assembly> loadedAssemblies { get; } // 0x0000000189698020-0x00000001896980F0 
	
		// Constructors
		static ReflectionTools() {} // 0x0000000189697F24-0x0000000189698020
	
		// Methods
		public static System.Type GetType(string typeName) => default; // 0x000000018969728C-0x0000000189697868
		public static System.Type[] GetAllTypes() => default; // 0x000000018969643C-0x000000018969668C
		public static System.Type[] GetImplementationsOf(System.Type type) => default; // 0x000000018969668C-0x0000000189696B3C
		public static Action<T, TValue> GetFieldOrPropSetter<T, TValue>(MemberInfo info) => default;
		public static MemberInfo GetRelativeMember(object root, string path) => default; // 0x0000000189697218-0x000000018969728C
		public static MemberInfo GetRelativeMember(System.Type type, string path) => default; // 0x00000001896970C4-0x0000000189697218
		public static object GetRelativeMemberParent(object root, string path) => default; // 0x0000000189696F80-0x00000001896970C4
		public static string GetMemberPath<T, TResult>(Expression<Func<T, TResult>> func) => default;
		public static string[] GetMemberPaths(System.Type type, Predicate<System.Type> shouldInclude, Predicate<System.Type> shouldContinue, string currentPath = "" /* Metadata: 0x01FD677A */, List<System.Type> recursionCheck = null) => default; // 0x0000000189696B3C-0x0000000189696F80
	
		// Extension methods
		private static System.Type[] RTGetExportedTypes(this Assembly asm) => default; // 0x0000000189697868-0x0000000189697888
		public static string FriendlyName(this System.Type type) => default; // 0x000000018969634C-0x000000018969643C
		public static bool RTIsStatic(this PropertyInfo propertyInfo) => default; // 0x0000000189697CF0-0x0000000189697DA0
		public static bool RTIsAbstract(this System.Type type) => default; // 0x000000018939B954-0x000000018939B970
		public static bool RTIsSubclassOf(this System.Type type, System.Type other) => default; // 0x000000018939BBB0-0x000000018939BBD4
		public static bool RTIsAssignableFrom(this System.Type type, System.Type second) => default; // 0x0000000189697CCC-0x0000000189697CF0
		public static System.Reflection.FieldInfo RTGetField(this System.Type type, string name) => default; // 0x0000000189697B38-0x0000000189697B5C
		public static PropertyInfo RTGetProperty(this System.Type type, string name) => default; // 0x0000000189697CA8-0x0000000189697CCC
		public static MethodInfo RTGetMethod(this System.Type type, string name) => default; // 0x0000000189697C60-0x0000000189697C84
		public static System.Reflection.FieldInfo[] RTGetFields(this System.Type type) => default; // 0x0000000189697C3C-0x0000000189697C60
		public static PropertyInfo[] RTGetProperties(this System.Type type) => default; // 0x0000000189697C84-0x0000000189697CA8
		public static MethodInfo RTGetGetMethod(this PropertyInfo prop) => default; // 0x000000018939B3A4-0x000000018939B3C0
		public static MethodInfo RTGetSetMethod(this PropertyInfo prop) => default; // 0x000000018939B938-0x000000018939B954
		public static System.Type RTReflectedType(this System.Type type) => default; // 0x0000000189697DA0-0x0000000189697DC0
		public static System.Type RTReflectedType(this MemberInfo member) => default; // 0x0000000189697DA0-0x0000000189697DC0
		public static T RTGetAttribute<T>(this System.Type type, bool inherited)
			where T : Attribute => default;
		public static T RTGetAttribute<T>(this MemberInfo member, bool inherited)
			where T : Attribute => default;
		public static bool RTIsDefined<T>(this MemberInfo member, bool inherited)
			where T : Attribute => default;
		public static T RTCreateDelegate<T>(this MethodInfo method, object instance) => default;
		public static MemberInfo[] RTGetFieldsAndProps(this System.Type type) => default; // 0x0000000189697B5C-0x0000000189697C3C
		public static MemberInfo RTGetFieldOrProp(this System.Type type, string name) => default; // 0x0000000189697AA8-0x0000000189697B38
		public static object RTGetFieldOrPropValue(this MemberInfo member, object instance, int index = -1 /* Metadata: 0x01FD6778 */) => default; // 0x000000018969794C-0x0000000189697AA8
		public static void RTSetFieldOrPropValue(this MemberInfo member, object instance, object value, int index = -1 /* Metadata: 0x01FD6779 */) {} // 0x0000000189697DC0-0x0000000189697F24
		public static System.Type RTGetFieldOrPropType(this MemberInfo member) => default; // 0x0000000189697888-0x000000018969794C
	}

	public static class StringUtility // TypeDefIndex: 54714
	{
		// Methods
		public static string AbsToRelativePath(string absolutepath) => default; // 0x00000001896998FC-0x00000001896999D8
	
		// Extension methods
		public static string SplitCamelCase(this string s) => default; // 0x00000001896999D8-0x0000000189699ADC
	}

	[Serializable]
	public struct TransformRefPosition : ITransformRefParameter // TypeDefIndex: 54715
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
		public bool useAnimation { get => default; } // 0x0000000189699FB4-0x000000018969A060 
		public CutsceneGroup group { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public Transform transform { get => default; set {} } // 0x0000000189699EFC-0x0000000189699FB4 0x000000018558FF08-0x000000018558FF18
		public Vector3 value { get => default; set {} } // 0x000000018969A060-0x000000018969A0CC 0x0000000183D55570-0x0000000183D55580
		public TransformSpace space { get => default; private set {} } // 0x0000000189699ED8-0x0000000189699EFC 0x0000000183D4EBC0-0x0000000183D4EBD0
	
		// Methods
		public override string ToString() => default; // 0x0000000189699E50-0x0000000189699ED8
	}

	[Serializable]
	public struct TransformRefPositionRotation : ITransformRefParameter // TypeDefIndex: 54716
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
		public bool useAnimation { get => default; } // 0x0000000189699DA4-0x0000000189699E50 
		public CutsceneGroup group { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public Transform transform { get => default; set {} } // 0x0000000189699CEC-0x0000000189699DA4 0x000000018558FF08-0x000000018558FF18
		public Vector3 position { get => default; set {} } // 0x0000000189699BF0-0x0000000189699C5C 0x0000000183D55570-0x0000000183D55580
		public Vector3 rotation { get => default; set {} } // 0x0000000189699C5C-0x0000000189699CC8 0x0000000183D5CBC0-0x0000000183D5CBD0
		public TransformSpace space { get => default; private set {} } // 0x0000000189699CC8-0x0000000189699CEC 0x0000000183D4EBA0-0x0000000183D4EBB0
	
		// Methods
		public override string ToString() => default; // 0x0000000189699B38-0x0000000189699BF0
	}

	public class TransformSnapshot // TypeDefIndex: 54719
	{
		// Fields
		private List<TransformData> data; // 0x10
	
		// Nested types
		public enum StoreMode // TypeDefIndex: 54717
		{
			All = 0,
			RootOnly = 1,
			ChildrenOnly = 2
		}
	
		private struct TransformData // TypeDefIndex: 54718
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
			} // 0x0000000189699ADC-0x0000000189699B38
		}
	
		// Constructors
		public TransformSnapshot() {} // Dummy constructor
		public TransformSnapshot(GameObject root, StoreMode mode) {} // 0x000000018969A5E0-0x000000018969A680
	
		// Methods
		public void Store(GameObject root, StoreMode mode) {} // 0x000000018969A23C-0x000000018969A5E0
		public void Restore() {} // 0x000000018969A0CC-0x000000018969A23C
	}

	public static class UnityObjectUtility // TypeDefIndex: 54721
	{
		// Fields
		private static MethodInfo _getLocalEulerAngles; // 0x00
		private static MethodInfo _setLocalEulerAngles; // 0x08
		private static PropertyInfo _rotationOrder; // 0x10
		private static object[] _rotationOrderArgGet; // 0x18
		private static object[] _rotationOrderArgSet; // 0x20
	
		// Constructors
		static UnityObjectUtility() {} // 0x000000018969BCC4-0x000000018969BE8C
	
		// Extension methods
		public static Vector3 GetLocalEulerAngles(this Transform transform) => default; // 0x000000018969B6E8-0x000000018969B808
		public static void SetLocalEulerAngles(this Transform transform, Vector3 value) {} // 0x000000018969BB64-0x000000018969BCC4
		public static string CalculateTransformPath(this Transform root, Transform child) => default; // 0x000000018969B19C-0x000000018969B350
		public static Transform ResolveTransformPath(this Transform root, string path) => default; // 0x000000018969B984-0x000000018969BAA8
		public static Transform FindInChildren(this Transform root, string name, bool includeHidden) => default; // 0x000000018969B350-0x000000018969B48C
		public static void ResetLocalCoords(this Transform transform, bool includeScale = true /* Metadata: 0x01FD677F */) {} // 0x000000018969B8E0-0x000000018969B984
		public static void SetLocalCoordsFrom(this Transform transform, Transform source) {} // 0x000000018969BAA8-0x000000018969BB64
		public static Transform InsertParentInChain(this Transform transform, string name) => default; // 0x000000018969B808-0x000000018969B8E0
		public static T GetAddComponent<T>(this GameObject go)
			where T : Component => default;
		public static T GetAddComponent<T>(this Component comp)
			where T : Component => default;
		public static Component GetAddComponent(this GameObject go, System.Type type) => default; // 0x000000018969B48C-0x000000018969B51C
		public static List<string> GetBlendShapeNames(this SkinnedMeshRenderer skinnedMesh) => default; // 0x000000018969B5E0-0x000000018969B6E8
		public static int GetBlendShapeIndex(this SkinnedMeshRenderer skinnedMesh, string shapeName) => default; // 0x000000018969B51C-0x000000018969B5E0
	}

	public static class VideoSampler // TypeDefIndex: 54724
	{
		// Fields
		private const string ROOT_NAME = "_VideoSources"; // Metadata: 0x01FD6780
		private static GameObject root; // 0x00
		private static Dictionary<object, VideoPlayer> sources; // 0x08
	
		// Nested types
		public enum VideoRenderTarget // TypeDefIndex: 54722
		{
			CameraBackground = 0,
			CameraForeground = 1
		}
	
		[Serializable]
		public struct SampleSettings // TypeDefIndex: 54723
		{
			// Fields
			public VideoRenderTarget renderTarget; // 0x00
			public float playbackSpeed; // 0x04
			public float alpha; // 0x08
			public VideoAspectRatio aspectRatio; // 0x0C
			public float audioVolume; // 0x10
	
			// Methods
			public static SampleSettings Default() => default; // 0x0000000183D75080-0x0000000183D750B0
		}
	
		// Constructors
		static VideoSampler() {} // 0x000000018969C62C-0x000000018969C784
	
		// Methods
		public static VideoPlayer GetSourceForID(object keyID) => default; // 0x000000018969BE8C-0x000000018969C1D4
		public static void ReleaseSourceForID(object keyID) {} // 0x000000018969C1D4-0x000000018969C388
		public static void SampleForID(object keyID, VideoClip clip, float time, float previousTime, SampleSettings settings) {} // 0x000000018969C388-0x000000018969C42C
		public static void Sample(VideoPlayer source, VideoClip clip, float time, float previousTime, SampleSettings settings) {} // 0x000000018969C42C-0x000000018969C62C
	}

	public class CutsceneSequencePlayer : MonoBehaviour // TypeDefIndex: 54725
	{
		// Fields
		public bool playOnStart; // 0x18
		public List<Cutscene> cutscenes; // 0x20
		public UnityEvent onFinish; // 0x28
		private int currentIndex; // 0x30
		private bool isPlaying; // 0x34
	
		// Constructors
		public CutsceneSequencePlayer() {} // 0x00000001842726E8-0x00000001842726F4
	
		// Methods
		private void Start() {} // 0x000000018968F584-0x000000018968F594
		public void Play() {} // 0x000000018968F4B0-0x000000018968F584
		public void Stop() {} // 0x000000018968F594-0x000000018968F5FC
		private void MoveNext() {} // 0x000000018968F34C-0x000000018968F4B0
		public static GameObject Create() => default; // 0x000000018968F2CC-0x000000018968F34C
	}

	[ExecuteInEditMode]
	public class DirectorGUITemplate : MonoBehaviour // TypeDefIndex: 54726
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
		public DirectorGUITemplate() {} // 0x00000001842726E8-0x00000001842726F4
	
		// Methods
		private void Awake() {} // 0x0000000189690198-0x00000001896902B8
		[ContextMenu("Show All")]
		private void ShowAll() {} // 0x0000000189690D28-0x0000000189690DD0
		[ContextMenu("Hide All")]
		private void HideAll() {} // 0x00000001896902B8-0x0000000189690348
		private void OnEnable() {} // 0x000000018969064C-0x0000000189690868
		private void OnDisable() {} // 0x0000000189690430-0x000000018969064C
		private void Update() {} // 0x0000000189690DD0-0x0000000189690E24
		private void OnCameraDissolve(Texture texture, float completion) {} // 0x0000000189690348-0x0000000189690430
		private void OnImageOverlayGUI(Texture texture, UnityEngine.Color color, Vector2 scale, Vector2 position) {} // 0x0000000189690868-0x00000001896909D0
		private void OnLetterboxGUI(float completion) {} // 0x00000001896909D0-0x0000000189690B60
		private void OnScreenFadeGUI(UnityEngine.Color color) {} // 0x0000000189690B60-0x0000000189690BB8
		private void OnTextOverlayGUI(string text, UnityEngine.Color color, float size, TextAnchor anchor, Vector2 position) {} // 0x0000000189690C3C-0x0000000189690D28
		private void OnSubtitlesGUI(string text, UnityEngine.Color color) {} // 0x0000000189690BB8-0x0000000189690C3C
	}

	[AddComponentMenu("SLATE/Play Cutscene On Click")]
	public class PlayCutsceneOnClick : MonoBehaviour // TypeDefIndex: 54727
	{
		// Fields
		public Cutscene cutscene; // 0x18
		public float startTime; // 0x20
		public UnityEvent onFinish; // 0x28
	
		// Constructors
		public PlayCutsceneOnClick() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void OnMouseDown() {} // 0x00000001896953CC-0x00000001896954E0
		private void Reset() {} // 0x00000001896954E0-0x0000000189695580
		public static GameObject Create() => default; // 0x000000018969535C-0x00000001896953CC
	}

	[AddComponentMenu("SLATE/Play Cutscene On Start")]
	public class PlayCutsceneOnStart : MonoBehaviour // TypeDefIndex: 54728
	{
		// Fields
		public Cutscene cutscene; // 0x18
		public float startTime; // 0x20
		public UnityEvent onFinish; // 0x28
	
		// Constructors
		public PlayCutsceneOnStart() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Start() {} // 0x000000018969562C-0x0000000189695740
		public static GameObject Create() => default; // 0x00000001896955A0-0x000000018969562C
	}

	[AddComponentMenu("SLATE/Play Cutscene On Trigger")]
	public class PlayCutsceneOnTrigger : MonoBehaviour // TypeDefIndex: 54729
	{
		// Fields
		public Cutscene cutscene; // 0x18
		public float startTime; // 0x20
		public bool checkSpecificTagOnly; // 0x24
		public string tagName; // 0x28
		public bool once; // 0x30
		public UnityEvent onFinish; // 0x38
	
		// Constructors
		public PlayCutsceneOnTrigger() {} // 0x0000000189695A34-0x0000000189695A80
	
		// Methods
		private void OnTriggerEnter(Collider other) {} // 0x00000001896957CC-0x0000000189695944
		private void Reset() {} // 0x0000000189695944-0x00000001896959BC
		public static GameObject Create() => default; // 0x0000000189695740-0x00000001896957CC
	}

	[AddComponentMenu("SLATE/Stop Cutscene On Click")]
	public class StopCutsceneOnClick : MonoBehaviour // TypeDefIndex: 54730
	{
		// Fields
		public Cutscene cutscene; // 0x18
		public Cutscene.StopMode stopMode; // 0x20
	
		// Constructors
		public StopCutsceneOnClick() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void OnMouseDown() {} // 0x0000000189699610-0x00000001896996C4
		private void Reset() {} // 0x00000001896996C4-0x0000000189699724
	}

	[AddComponentMenu("SLATE/Stop Cutscene On Trigger")]
	public class StopCutsceneOnTrigger : MonoBehaviour // TypeDefIndex: 54731
	{
		// Fields
		public Cutscene cutscene; // 0x18
		public bool checkSpecificTagOnly; // 0x20
		public string tagName; // 0x28
		public Cutscene.StopMode stopMode; // 0x30
	
		// Constructors
		public StopCutsceneOnTrigger() {} // 0x00000001896998B0-0x00000001896998FC
	
		// Methods
		private void OnTriggerEnter(Collider other) {} // 0x0000000189699724-0x0000000189699838
		private void Reset() {} // 0x0000000189699838-0x00000001896998B0
	}
}

namespace Slate.ActionClips
{
	[Attachable(new System.Type[1] {typeof(ActorActionTrack) })]
	public abstract class ActorActionClip : ActionClip // TypeDefIndex: 54732
	{
		// Constructors
		protected ActorActionClip() {} // 0x000000018426FE60-0x000000018426FE68
	}

	[Attachable(new System.Type[1] {typeof(ActorActionTrack) })]
	public abstract class ActorActionClip<T> : ActionClip // TypeDefIndex: 54733
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

	[Attachable(new System.Type[2] {typeof(ActorActionTrack), typeof(DirectorActionTrack) })]
	[Description("Animate any number of properties on any component of the actor, or within it\'s hierarchy.\nThis is identical to using a Properties Track, but instead the animated properties are stored within the clip and thus can be moved around as a group easier.\nYou can also use the Clip\'s Blend In/Out to optionally smooth blend from current property values over to the keyframed ones and back.")]
	public class AnimateProperties : ActionClip // TypeDefIndex: 54734
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
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override bool isValid { get => default; } // 0x00000001896719D8-0x00000001896719F0 
		public override string info { get => default; } // 0x000000018968A108-0x000000018968A178 
		public override object animatedParametersTarget { get => default; } // 0x000000018968A100-0x000000018968A108 
		public override Slate.EaseType animatedParametersInterpolation { get => default; } // 0x0000000183D4EF00-0x0000000183D4EF10 
		public override bool useWeightInParameters { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Constructors
		public AnimateProperties() {} // 0x000000018968A0E8-0x000000018968A100
	}

	[Category("Character")]
	[Description("Animates a single blend shape chosen from within the whole actor gameobject hierarchy.")]
	public class AnimateBlendShape : ActorActionClip // TypeDefIndex: 54735
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
		public override string info { get => default; } // 0x00000001896892A0-0x00000001896892E0 
		public override bool isValid { get => default; } // 0x00000001896892E0-0x0000000189689388 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override bool canCrossBlend { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public string skinName { get => default; set {} } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x00000001896894E0-0x000000018968950C
		public string shapeName { get => default; set {} } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000183081D30-0x0000000183081D40
		private SkinnedMeshRenderer skinnedMesh { get => default; } // 0x0000000189689388-0x00000001896894E0 
	
		// Constructors
		public AnimateBlendShape() {} // 0x000000018968927C-0x00000001896892A0
	
		// Methods
		protected override void OnEnter() {} // 0x000000018968909C-0x0000000189689180
		protected override void OnUpdate(float deltaTime) {} // 0x00000001896891BC-0x0000000189689244
		protected override void OnReverse() {} // 0x0000000189689180-0x00000001896891BC
	}

	[Category("Character")]
	[Description("Sets a collection of BlendShapes (an expression), which you can create in the Character Component Inspector of the actor.")]
	public class CharacterExpression : ActorActionClip<Slate.Character> // TypeDefIndex: 54736
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
		public override string info { get => default; } // 0x000000018968C1D0-0x000000018968C284 
		public override bool isValid { get => default; } // 0x000000018968C284-0x000000018968C2E8 
		public override float length { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override float blendIn { get => default; set {} } // 0x0000000183D50200-0x0000000183D50210 0x0000000183D5E680-0x0000000183D5E690
		public override float blendOut { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
		public override bool canCrossBlend { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Constructors
		public CharacterExpression() {} // 0x000000018968C180-0x000000018968C1D0
	
		// Methods
		private BlendShapeGroup ResolveExpression() => default; // 0x000000018968C0F4-0x000000018968C180
		protected override void OnEnter() {} // 0x000000018968C00C-0x000000018968C040
		protected override void OnUpdate(float deltaTime) {} // 0x000000018968C084-0x000000018968C0F4
		protected override void OnReverse() {} // 0x000000018968C040-0x000000018968C084
	}

	[Category("Character")]
	[Description("This ActionClip is recommended to be used above an animation track.")]
	[Name("Character Head Look At")]
	public class CharacterLookAt : ActorActionClip<Slate.Character> // TypeDefIndex: 54737
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
		public Vector3 targetPositionVector { get => default; set {} } // 0x000000018968CB18-0x000000018968CB4C 0x0000000183D75030-0x0000000183D75040
		public override string info { get => default; } // 0x000000018968C9C0-0x000000018968CA38 
		public override bool isValid { get => default; } // 0x000000018968CA38-0x000000018968CB18 
		public override float length { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override float blendIn { get => default; set {} } // 0x0000000183D50200-0x0000000183D50210 0x0000000183D5E680-0x0000000183D5E690
		public override float blendOut { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
	
		// Constructors
		public CharacterLookAt() {} // 0x000000018968C96C-0x000000018968C9C0
	
		// Methods
		protected override void OnCreate() {} // 0x000000018968C334-0x000000018968C3FC
		protected override void OnAfterValidate() {} // 0x000000018968C2E8-0x000000018968C334
		protected override void OnEnter() {} // 0x000000018968C3FC-0x000000018968C49C
		protected override void OnUpdate(float time) {} // 0x000000018968C53C-0x000000018968C96C
		protected override void OnReverse() {} // 0x000000018968C49C-0x000000018968C53C
	}

	public abstract class SendMessage<T> : SendMessage // TypeDefIndex: 54738
	{
		// Fields
		[Tooltip("The parameter value to use when calling the method")]
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

	[Category("Events")]
	[Description("Send a Unity Message to the actor")]
	public class SendMessage : ActorActionClip // TypeDefIndex: 54739
	{
		// Fields
		[Required]
		[Tooltip("The method name to call")]
		public string message; // 0x40
		[Tooltip("If multiple components of the same type exist on gameobject you can specify the index of the component to use here. Leave at -1 to call all found instances")]
		public int componentIndex; // 0x48
	
		// Properties
		public override string info { get => default; } // 0x00000001896986F0-0x0000000189698730 
		public override bool isValid { get => default; } // 0x0000000187C21C88-0x0000000187C21CA0 
		public virtual System.Type parameterType { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public SendMessage() {} // 0x0000000187C20DB4-0x0000000187C20DC4
	
		// Methods
		protected override void OnEnter() {} // 0x000000018969843C-0x00000001896986F0
	}

	public class SendMessageBoolean : SendMessage<bool> // TypeDefIndex: 54740
	{
		// Constructors
		public SendMessageBoolean() {} // 0x0000000189698310-0x000000018969834C
	}

	public class SendMessageFloat : SendMessage<float> // TypeDefIndex: 54741
	{
		// Constructors
		public SendMessageFloat() {} // 0x000000018969834C-0x0000000189698388
	}

	public class SendMessageInteger : SendMessage<int> // TypeDefIndex: 54742
	{
		// Constructors
		public SendMessageInteger() {} // 0x0000000189698388-0x00000001896983C4
	}

	public class SendMessageObject : SendMessage<UnityEngine.Object> // TypeDefIndex: 54743
	{
		// Constructors
		public SendMessageObject() {} // 0x00000001896983C4-0x0000000189698400
	}

	public class SendMessageString : SendMessage<string> // TypeDefIndex: 54744
	{
		// Constructors
		public SendMessageString() {} // 0x0000000189698400-0x000000018969843C
	}

	[Category("GameObject")]
	[Description("Set or animate the actor gameobject visibility.")]
	public class AnimateActorVisibility : ActorActionClip // TypeDefIndex: 54745
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		[AnimatableParameter]
		public bool visible; // 0x44
		private bool wasVisible; // 0x45
	
		// Properties
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
	
		// Constructors
		public AnimateActorVisibility() {} // 0x000000018968908C-0x000000018968909C
	
		// Methods
		protected override void OnCreate() {} // 0x0000000189688FCC-0x0000000189688FFC
		protected override void OnEnter() {} // 0x0000000189688FFC-0x000000018968902C
		protected override void OnUpdate(float time) {} // 0x000000018968905C-0x000000018968908C
		protected override void OnReverse() {} // 0x000000018968902C-0x000000018968905C
	}

	[Category("GameObject")]
	[Description("Make the actor target for the currently active Dynamic Shot Controller (if used by the current active Camera Shot in the cutscene).")]
	public class MakeCameraTarget : ActorActionClip // TypeDefIndex: 54746
	{
		// Fields
		public bool setTransposerTarget; // 0x40
		public bool setComposerTarget; // 0x41
		private Transform wasTransposerTarget; // 0x48
		private Transform wasComposerTarget; // 0x50
	
		// Constructors
		public MakeCameraTarget() {} // 0x0000000189693460-0x0000000189693470
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896931B4-0x0000000189693340
		protected override void OnReverse() {} // 0x0000000189693340-0x0000000189693460
	}

	[Category("GameObject")]
	[Description("Set the actor active state (visibility) for a period of time or permantentely if length is zero.")]
	public class SetActorActiveState : ActorActionClip // TypeDefIndex: 54747
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
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override string info { get => default; } // 0x00000001896988B0-0x0000000189698910 
	
		// Constructors
		public SetActorActiveState() {} // 0x00000001896988A0-0x00000001896988B0
	
		// Methods
		protected override void OnEnter() {} // 0x0000000189698730-0x00000001896987F8
		protected override void OnExit() {} // 0x00000001896987F8-0x0000000189698834
		protected override void OnReverseEnter() {} // 0x0000000189698834-0x0000000189698870
		protected override void OnReverse() {} // 0x0000000189698870-0x00000001896988A0
	}

	[Category("GameObject")]
	[Obsolete("Use \'Set Actor Visibility\'")]
	public class SetActorVisibilityTemporary : ActorActionClip // TypeDefIndex: 54748
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
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override string info { get => default; } // 0x0000000189698928-0x0000000189698988 
	
		// Constructors
		public SetActorVisibilityTemporary() {} // 0x0000000189698910-0x0000000189698928
	
		// Methods
		protected override void OnEnter() {} // 0x0000000189698730-0x00000001896987F8
		protected override void OnExit() {} // 0x00000001896987F8-0x0000000189698834
		protected override void OnReverseEnter() {} // 0x0000000189698834-0x0000000189698870
		protected override void OnReverse() {} // 0x0000000189698870-0x00000001896988A0
	}

	[Category("GameObject")]
	[Description("The selected Behaviours will be Enabled or Disable (based on state option) on the actor if they are not already")]
	public class SetBehavioursActiveState : ActorActionClip // TypeDefIndex: 54749
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
		public override string info { get => default; } // 0x0000000189699294-0x0000000189699350 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
	
		// Constructors
		public SetBehavioursActiveState() {} // 0x000000018969920C-0x0000000189699294
	
		// Methods
		protected override void OnEnter() {} // 0x0000000189698988-0x0000000189698CA8
		protected override void OnExit() {} // 0x0000000189698CA8-0x0000000189698E5C
		protected override void OnReverseEnter() {} // 0x0000000189698E5C-0x000000018969900C
		protected override void OnReverse() {} // 0x000000018969900C-0x0000000189699194
	}

	[Category("Paths")]
	[Description("Animate the actor\'s position and look at target position on a Path. For example, a \'PositionOnPath\' value of 0 means start of path, while a value of 1 means end of path.")]
	public class AnimateOnPath : ActorActionClip // TypeDefIndex: 54750
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
		public override string info { get => default; } // 0x0000000189689FF8-0x000000018968A098 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override bool isValid { get => default; } // 0x000000018968A098-0x000000018968A0E8 
	
		// Constructors
		public AnimateOnPath() {} // 0x0000000189689FE0-0x0000000189689FF8
	
		// Methods
		protected override void OnEnter() {} // 0x0000000189689BB8-0x0000000189689C58
		protected override void OnUpdate(float time) {} // 0x0000000189689CE4-0x0000000189689FE0
		protected override void OnReverse() {} // 0x0000000189689C58-0x0000000189689CE4
	}

	[Category("Paths")]
	[Description("Put the actor on a path to follow for the duration of the clip from path start to path end, or by using speed if \'Use Speed\' is true. If you want the actor to look ahead of the path, set \'Look Ahead\' to any value other than 0.")]
	public class FollowPath : ActorActionClip // TypeDefIndex: 54751
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
		public override string info { get => default; } // 0x0000000189691E98-0x0000000189691F38 
		public override float length { get => default; set {} } // 0x0000000189691F88-0x0000000189692014 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override bool isValid { get => default; } // 0x0000000189691F38-0x0000000189691F88 
	
		// Constructors
		public FollowPath() {} // 0x0000000189691E60-0x0000000189691E98
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896919E0-0x0000000189691A84
		protected override void OnUpdate(float time) {} // 0x0000000189691B14-0x0000000189691E60
		protected override void OnReverse() {} // 0x0000000189691A84-0x0000000189691B14
	}

	[Category("Paths")]
	[Description("For this clip to work you only need to have a baked NavMesh. The actor does NOT need, or use a NavMeshAgent Component. The length of the clip is determined by the path\'s length and the speed parameter set, while the Blend In parameter is used only for the initial look ahead blending")]
	public class PathfindFromTo : ActorActionClip // TypeDefIndex: 54752
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
		public override string info { get => default; } // 0x0000000189694930-0x0000000189694978 
		public override float length { get => default; } // 0x0000000189694978-0x00000001896949BC 
		public override float blendIn { get => default; set {} } // 0x0000000189694900-0x0000000189694930 0x0000000183D4ECF0-0x0000000183D4ED00
	
		// Constructors
		public PathfindFromTo() {} // 0x00000001896948E8-0x0000000189694900
	
		// Methods
		protected override void OnEnter() {} // 0x0000000189693FF0-0x00000001896941A4
		protected override void OnUpdate(float time) {} // 0x0000000189694250-0x000000018969468C
		protected override void OnReverse() {} // 0x00000001896941A4-0x0000000189694250
		private void TryCalculatePath() {} // 0x000000018969468C-0x00000001896948E8
	}

	[Category("Paths")]
	[Description("For this clip to work you only need to have a baked NavMesh. The actor does NOT need, or use a NavMeshAgent Component. The length of the clip is determined by the path\'s length and the speed parameter set, while the Blend In parameter is used only for the initial look ahead blending")]
	public class PathfindTo : ActorActionClip // TypeDefIndex: 54753
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
		public override string info { get => default; } // 0x00000001896952D4-0x000000018969531C 
		public override float length { get => default; } // 0x000000018969531C-0x000000018969535C 
		public override float blendIn { get => default; set {} } // 0x0000000189694900-0x0000000189694930 0x0000000183D4ECF0-0x0000000183D4ED00
	
		// Constructors
		public PathfindTo() {} // 0x00000001896948E8-0x0000000189694900
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896949BC-0x0000000189694B5C
		protected override void OnUpdate(float time) {} // 0x0000000189694BF4-0x0000000189695018
		protected override void OnReverse() {} // 0x0000000189694B5C-0x0000000189694BF4
		private void TryCalculatePath() {} // 0x0000000189695018-0x00000001896952D4
	}

	[Category("Renderer")]
	public class AnimateMaterialColor : ActorActionClip<Renderer> // TypeDefIndex: 54754
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
		public override string info { get => default; } // 0x00000001896896C4-0x0000000189689704 
		public override bool isValid { get => default; } // 0x0000000189689704-0x00000001896897F0 
		public override float length { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override float blendIn { get => default; set {} } // 0x0000000183D50200-0x0000000183D50210 0x0000000183D5E680-0x0000000183D5E690
		public override float blendOut { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
		private Material targetMaterial { get => default; } // 0x00000001896897F0-0x0000000189689898 
	
		// Constructors
		public AnimateMaterialColor() {} // 0x0000000189689644-0x00000001896896C4
	
		// Methods
		protected override void OnEnter() {} // 0x0000000189689588-0x0000000189689590
		protected override void OnReverseEnter() {} // 0x0000000189689588-0x0000000189689590
		protected override void OnUpdate(float time) {} // 0x0000000189689598-0x0000000189689644
		protected override void OnReverse() {} // 0x0000000189689590-0x0000000189689598
		protected override void OnExit() {} // 0x0000000189689590-0x0000000189689598
		private void DoSet() {} // 0x000000018968954C-0x0000000189689588
		private void DoReset() {} // 0x000000018968950C-0x000000018968954C
	}

	[Category("Renderer")]
	public class AnimateMaterialFloat : ActorActionClip<Renderer> // TypeDefIndex: 54755
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
		public override string info { get => default; } // 0x00000001896899E4-0x0000000189689A24 
		public override bool isValid { get => default; } // 0x0000000189689A24-0x0000000189689B10 
		public override float length { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override float blendIn { get => default; set {} } // 0x0000000183D50200-0x0000000183D50210 0x0000000183D5E680-0x0000000183D5E690
		public override float blendOut { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
		private Material targetMaterial { get => default; } // 0x0000000189689B10-0x0000000189689BB8 
	
		// Constructors
		public AnimateMaterialFloat() {} // 0x0000000189689994-0x00000001896899E4
	
		// Methods
		protected override void OnEnter() {} // 0x0000000189689904-0x000000018968990C
		protected override void OnReverseEnter() {} // 0x0000000189689904-0x000000018968990C
		protected override void OnUpdate(float time) {} // 0x0000000189689914-0x0000000189689994
		protected override void OnReverse() {} // 0x000000018968990C-0x0000000189689914
		protected override void OnExit() {} // 0x000000018968990C-0x0000000189689914
		private void DoSet() {} // 0x00000001896898CC-0x0000000189689904
		private void DoReset() {} // 0x0000000189689898-0x00000001896898CC
	}

	[Category("Renderer")]
	[Description("Animate a material\'s texture offset and scale over time")]
	public class AnimateMaterialTexture : ActorActionClip<Renderer> // TypeDefIndex: 54756
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
		public override string info { get => default; } // 0x000000018969F004-0x000000018969F044 
		public override bool isValid { get => default; } // 0x000000018969F044-0x000000018969F130 
		public override float length { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override float blendIn { get => default; set {} } // 0x0000000183D50200-0x0000000183D50210 0x0000000183D5E680-0x0000000183D5E690
		public override float blendOut { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
		private Material targetMaterial { get => default; } // 0x000000018969F130-0x000000018969F1D8 
	
		// Constructors
		public AnimateMaterialTexture() {} // 0x000000018969EF8C-0x000000018969F004
	
		// Methods
		protected override void OnEnter() {} // 0x000000018969EDC0-0x000000018969EDC8
		protected override void OnReverseEnter() {} // 0x000000018969EDC0-0x000000018969EDC8
		protected override void OnUpdate(float time) {} // 0x000000018969EDD0-0x000000018969EF8C
		protected override void OnReverse() {} // 0x000000018969EDC8-0x000000018969EDD0
		protected override void OnExit() {} // 0x000000018969EDC8-0x000000018969EDD0
		private void DoSet() {} // 0x000000018969ED38-0x000000018969EDC0
		private void DoReset() {} // 0x000000018969ECC4-0x000000018969ED38
	}

	[Category("Renderer")]
	[Description("Scroll/Offset the material texture. Usefull for scrolling backgrounds, screens, or other similar effects.")]
	public class ScrollMaterialTexture : ActorActionClip<Renderer> // TypeDefIndex: 54757
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
		public override string info { get => default; } // 0x00000001896A5CF4-0x00000001896A5D58 
		public override bool isValid { get => default; } // 0x00000001896A5D58-0x00000001896A5E04 
		public override float length { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override float blendIn { get => default; } // 0x000000018969FD10-0x000000018969FD20 
		private Material targetMaterial { get => default; } // 0x00000001896A5E04-0x00000001896A5EAC 
	
		// Constructors
		public ScrollMaterialTexture() {} // 0x00000001896A5C84-0x00000001896A5CF4
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A5A78-0x00000001896A5AC4
		protected override void OnUpdate(float time) {} // 0x00000001896A5B08-0x00000001896A5C84
		protected override void OnReverse() {} // 0x00000001896A5AC4-0x00000001896A5B08
	}

	[Category("Renderer")]
	public class SetMaterial : ActorActionClip<Renderer> // TypeDefIndex: 54758
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		public Material material; // 0x50
		private Material sharedMat; // 0x58
		private bool temporary; // 0x60
	
		// Properties
		public override string info { get => default; } // 0x00000001896A650C-0x00000001896A65AC 
		public override float length { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
	
		// Constructors
		public SetMaterial() {} // 0x00000001896A64D8-0x00000001896A650C
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A647C-0x00000001896A64B0
		protected override void OnReverseEnter() {} // 0x00000001896A64C0-0x00000001896A64D0
		protected override void OnReverse() {} // 0x00000001896A64D0-0x00000001896A64D8
		protected override void OnExit() {} // 0x00000001896A64B0-0x00000001896A64C0
		private void DoSet() {} // 0x00000001896A63FC-0x00000001896A647C
		private void DoReset() {} // 0x00000001896A63A8-0x00000001896A63FC
	}

	[Category("Renderer")]
	public class SetMaterialTexture : ActorActionClip<Renderer> // TypeDefIndex: 54759
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
		public override string info { get => default; } // 0x00000001896A6174-0x00000001896A6214 
		public override bool isValid { get => default; } // 0x00000001896A6214-0x00000001896A6300 
		public override float length { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		private Material targetMaterial { get => default; } // 0x00000001896A6300-0x00000001896A63A8 
	
		// Constructors
		public SetMaterialTexture() {} // 0x00000001896A6120-0x00000001896A6174
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A60C4-0x00000001896A60F8
		protected override void OnReverseEnter() {} // 0x00000001896A6108-0x00000001896A6118
		protected override void OnReverse() {} // 0x00000001896A6118-0x00000001896A6120
		protected override void OnExit() {} // 0x00000001896A60F8-0x00000001896A6108
		private void DoSet() {} // 0x00000001896A6064-0x00000001896A60C4
		private void DoReset() {} // 0x00000001896A6030-0x00000001896A6064
	}

	[Category("Sprites")]
	[Description("Change sorting layer and order for sprite renderer.")]
	public class SetSortingLayer : ActorActionClip<SpriteRenderer> // TypeDefIndex: 54760
	{
		// Fields
		public int sortingOrder; // 0x48
		[SortingLayer]
		public int sortingLayerID; // 0x4C
		private string _lastLayer; // 0x50
		private int _lastOrder; // 0x58
	
		// Properties
		public override string info { get => default; } // 0x00000001896A6B8C-0x00000001896A6C44 
	
		// Constructors
		public SetSortingLayer() {} // 0x00000001896A6B58-0x00000001896A6B8C
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A6A1C-0x00000001896A6AE0
		protected override void OnReverse() {} // 0x00000001896A6AE0-0x00000001896A6B58
	}

	[Category("Sprites")]
	public class SetSprite : ActorActionClip<SpriteRenderer> // TypeDefIndex: 54761
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
		public override string info { get => default; } // 0x00000001896A6FD4-0x00000001896A7054 
	
		// Constructors
		public SetSprite() {} // 0x00000001896A6F8C-0x00000001896A6FD4
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A6C44-0x00000001896A6E68
		protected override void OnReverse() {} // 0x00000001896A6E68-0x00000001896A6F8C
	}

	[Category("Sprites")]
	[Description("Animate a sprite object by altering between different sprites in order")]
	public class SpriteFlipbook : ActorActionClip<SpriteRenderer> // TypeDefIndex: 54762
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
		public override string info { get => default; } // 0x00000001896A7C08-0x00000001896A7CC8 
		public override float length { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override bool isValid { get => default; } // 0x00000001896A7CC8-0x00000001896A7D5C 
	
		// Constructors
		public SpriteFlipbook() {} // 0x00000001896A7B68-0x00000001896A7C08
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A7900-0x00000001896A795C
		protected override void OnUpdate(float deltaTime) {} // 0x00000001896A7A0C-0x00000001896A7B68
		protected override void OnExit() {} // 0x00000001896A795C-0x00000001896A79B8
		protected override void OnReverse() {} // 0x00000001896A79B8-0x00000001896A7A0C
	}

	[Category("Transform")]
	[Description("Attach an object to a child transform of the actor (or the actor itself) either permantentely or temporary if length is greater than zero.")]
	public class AttachObject : ActorActionClip // TypeDefIndex: 54763
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
		public override bool isValid { get => default; } // 0x000000018969FAD0-0x000000018969FB20 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
	
		// Constructors
		public AttachObject() {} // 0x000000018969F7A4-0x000000018969F7CC
	
		// Methods
		protected override void OnEnter() {} // 0x000000018969FA48-0x000000018969FA7C
		protected override void OnReverseEnter() {} // 0x000000018969FA90-0x000000018969FAA4
		protected override void OnExit() {} // 0x000000018969FA7C-0x000000018969FA90
		protected override void OnReverse() {} // 0x000000018969FAA4-0x000000018969FAAC
		private void Do() {} // 0x000000018969F81C-0x000000018969FA48
		private void UnDo() {} // 0x000000018969FAAC-0x000000018969FAD0
	}

	[Category("Transform")]
	[Description("Instantiate and attach a prefab object to a child transform of the actor (or the actor itself) either permantentely or temporary if length is greater than zero.")]
	public class AttachObjectPrefab : ActorActionClip // TypeDefIndex: 54764
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
		public override bool isValid { get => default; } // 0x000000018969F7CC-0x000000018969F81C 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
	
		// Constructors
		public AttachObjectPrefab() {} // 0x000000018969F7A4-0x000000018969F7CC
	
		// Methods
		protected override void OnEnter() {} // 0x000000018969F6A0-0x000000018969F6D4
		protected override void OnReverseEnter() {} // 0x000000018969F6E8-0x000000018969F6FC
		protected override void OnExit() {} // 0x000000018969F6D4-0x000000018969F6E8
		protected override void OnReverse() {} // 0x000000018969F6FC-0x000000018969F704
		private void Do() {} // 0x000000018969F494-0x000000018969F6A0
		private void UnDo() {} // 0x000000018969F704-0x000000018969F7A4
	}

	[Category("Transform")]
	[Description("Rotate actor transform to look at specified target position for a period of time or permanentely if blend out is zero")]
	public class LookAt : ActorActionClip // TypeDefIndex: 54765
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
		public Vector3 targetPositionVector { get => default; set {} } // 0x00000001896A144C-0x00000001896A1480 0x0000000183D71C40-0x0000000183D71C50
		public override string info { get => default; } // 0x00000001896A13D4-0x00000001896A144C 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
	
		// Constructors
		public LookAt() {} // 0x00000001896A13B0-0x00000001896A13D4
	
		// Methods
		protected override void OnCreate() {} // 0x00000001896A10C4-0x00000001896A1100
		protected override void OnAfterValidate() {} // 0x00000001896A1078-0x00000001896A10C4
		protected override void OnEnter() {} // 0x00000001896A1100-0x00000001896A114C
		protected override void OnUpdate(float deltaTime) {} // 0x00000001896A1198-0x00000001896A13B0
		protected override void OnReverse() {} // 0x00000001896A114C-0x00000001896A1198
	}

	[Category("Transform")]
	[Description("Smoothly match the selected transforms of the actor and to the target for a period of time and then back again to their original values. If you don\'t want to smooth back to the original values, set BlendOut to 0.")]
	public class MatchTransformsToTarget : ActorActionClip // TypeDefIndex: 54766
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
		public override string info { get => default; } // 0x00000001896A1B74-0x00000001896A1C14 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override bool isValid { get => default; } // 0x00000001896A1C14-0x00000001896A1C64 
	
		// Constructors
		public MatchTransformsToTarget() {} // 0x00000001896A1B48-0x00000001896A1B74
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A1480-0x00000001896A155C
		protected override void OnUpdate(float deltaTime) {} // 0x00000001896A1640-0x00000001896A1B48
		protected override void OnReverse() {} // 0x00000001896A155C-0x00000001896A1640
	}

	[Category("Transform")]
	public class Noise : ActorActionClip // TypeDefIndex: 54767
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
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
	
		// Constructors
		public Noise() {} // 0x00000001896A2298-0x00000001896A22D4
	
		// Methods
		protected override void OnCreate() {} // 0x00000001896A1FF8-0x00000001896A2070
		protected override void OnEnter() {} // 0x00000001896A2070-0x00000001896A20C0
		protected override void OnUpdate(float time, float previousTime) {} // 0x00000001896A20C0-0x00000001896A2298
	}

	[Category("Transform")]
	[Description("Rotate the actor around target position or object by specified degrees and optionaly per second.")]
	public class RotateAround : ActorActionClip // TypeDefIndex: 54768
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
		public Vector3 targetPositionVector { get => default; set {} } // 0x00000001896A144C-0x00000001896A1480 0x0000000183D71C40-0x0000000183D71C50
		public override string info { get => default; } // 0x00000001896A4770-0x00000001896A4858 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; } // 0x000000018969FD10-0x000000018969FD20 
	
		// Constructors
		public RotateAround() {} // 0x00000001896A4740-0x00000001896A4770
	
		// Methods
		protected override void OnAfterValidate() {} // 0x00000001896A4184-0x00000001896A41D0
		protected override void OnEnter() {} // 0x00000001896A41D0-0x00000001896A42DC
		protected override void OnUpdate(float time) {} // 0x00000001896A436C-0x00000001896A4740
		protected override void OnReverse() {} // 0x00000001896A42DC-0x00000001896A436C
	}

	[Category("Transform")]
	[Description("Rotate the actor by specified degrees and optionaly per second")]
	public class RotateBy : ActorActionClip // TypeDefIndex: 54769
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
		public override string info { get => default; } // 0x00000001896A4B3C-0x00000001896A4BEC 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; } // 0x000000018969FD10-0x000000018969FD20 
	
		// Constructors
		public RotateBy() {} // 0x00000001896A4B0C-0x00000001896A4B3C
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A4858-0x00000001896A48DC
		protected override void OnUpdate(float time) {} // 0x00000001896A496C-0x00000001896A4B0C
		protected override void OnReverse() {} // 0x00000001896A48DC-0x00000001896A496C
	}

	[Category("Transform")]
	public class RotateTo : ActorActionClip // TypeDefIndex: 54770
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		public Vector3 targetRotation; // 0x44
		public Slate.EaseType interpolation; // 0x50
		private Vector3 originalRot; // 0x54
	
		// Properties
		public override string info { get => default; } // 0x00000001896A4DF0-0x00000001896A4E5C 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; } // 0x000000018969FD10-0x000000018969FD20 
	
		// Constructors
		public RotateTo() {} // 0x000000018969F300-0x000000018969F318
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A4BEC-0x00000001896A4C3C
		protected override void OnUpdate(float deltaTime) {} // 0x00000001896A4C90-0x00000001896A4DF0
		protected override void OnReverse() {} // 0x00000001896A4C3C-0x00000001896A4C90
	}

	[Category("Transform")]
	[Description("Scale the actor by specified value and optionlay per second")]
	public class ScaleBy : ActorActionClip // TypeDefIndex: 54771
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
		public override string info { get => default; } // 0x00000001896A5660-0x00000001896A5710 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; } // 0x000000018969FD10-0x000000018969FD20 
	
		// Constructors
		public ScaleBy() {} // 0x00000001896A5630-0x00000001896A5660
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A540C-0x00000001896A545C
		protected override void OnUpdate(float deltaTime) {} // 0x00000001896A54B0-0x00000001896A5630
		protected override void OnReverse() {} // 0x00000001896A545C-0x00000001896A54B0
	}

	[Category("Transform")]
	public class ScaleTo : ActorActionClip // TypeDefIndex: 54772
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		public Vector3 targetScale; // 0x44
		public Slate.EaseType interpolation; // 0x50
		private Vector3 originalPos; // 0x54
	
		// Properties
		public override string info { get => default; } // 0x00000001896A5914-0x00000001896A5980 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; } // 0x000000018969FD10-0x000000018969FD20 
	
		// Constructors
		public ScaleTo() {} // 0x000000018969F300-0x000000018969F318
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A5710-0x00000001896A5760
		protected override void OnUpdate(float deltaTime) {} // 0x00000001896A57B4-0x00000001896A5914
		protected override void OnReverse() {} // 0x00000001896A5760-0x00000001896A57B4
	}

	[Category("Transform")]
	[Obsolete("Use Set Parent")]
	public class SetParentTemporary : ActorActionClip // TypeDefIndex: 54773
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
		public override string info { get => default; } // 0x00000001896A697C-0x00000001896A6A1C 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
	
		// Constructors
		public SetParentTemporary() {} // 0x000000018968908C-0x000000018968909C
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A65AC-0x00000001896A66B8
		protected override void OnUpdate(float deltaTime) {} // 0x00000001896A67C8-0x00000001896A697C
		protected override void OnReverse() {} // 0x00000001896A66B8-0x00000001896A67C8
	}

	[Category("Transform")]
	[Description("Set the parent of the actor gameobject temporarily, or permanently if length is zero")]
	public class SetTransformParent : ActorActionClip // TypeDefIndex: 54774
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
		public override string info { get => default; } // 0x00000001896A7314-0x00000001896A73B4 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
	
		// Constructors
		public SetTransformParent() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A72B0-0x00000001896A72E4
		protected override void OnReverseEnter() {} // 0x00000001896A72F8-0x00000001896A730C
		protected override void OnExit() {} // 0x00000001896A72E4-0x00000001896A72F8
		protected override void OnReverse() {} // 0x00000001896A730C-0x00000001896A7314
		private void Do() {} // 0x00000001896A7054-0x00000001896A72B0
		private void UnDo() {} // 0x00000001896A66B8-0x00000001896A67C8
	}

	[Category("Transform")]
	[Description("Instantely set the transforms of the actor.")]
	public class SetTransformValues : ActorActionClip // TypeDefIndex: 54775
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
		public SetTransformValues() {} // 0x00000001896A75A0-0x00000001896A75C4
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A73B4-0x00000001896A7580
		protected override void OnReverse() {} // 0x00000001896A7580-0x00000001896A75A0
	}

	[Category("Transform")]
	[Description("Grounds the actor gameobject to the nearest collider object beneath it up to the set Max Distance")]
	public class SimpleGrounder : ActorActionClip // TypeDefIndex: 54776
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
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
	
		// Constructors
		public SimpleGrounder() {} // 0x00000001896A78E4-0x00000001896A7900
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A75C4-0x00000001896A761C
		protected override void OnUpdate(float time) {} // 0x00000001896A7674-0x00000001896A78E4
		protected override void OnReverse() {} // 0x00000001896A761C-0x00000001896A7674
	}

	[Category("Transform")]
	[Description("Translate the actor by specified value and optionaly per second")]
	public class TranslateBy : ActorActionClip // TypeDefIndex: 54777
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
		public override string info { get => default; } // 0x00000001896A85B0-0x00000001896A8660 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; } // 0x000000018969FD10-0x000000018969FD20 
	
		// Constructors
		public TranslateBy() {} // 0x00000001896A8580-0x00000001896A85B0
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A835C-0x00000001896A83AC
		protected override void OnUpdate(float deltaTime) {} // 0x00000001896A8400-0x00000001896A8580
		protected override void OnReverse() {} // 0x00000001896A83AC-0x00000001896A8400
	}

	[Category("Transform")]
	public class TranslateTo : ActorActionClip // TypeDefIndex: 54778
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
		public override string info { get => default; } // 0x00000001896A8898-0x00000001896A8904 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; } // 0x000000018969FD10-0x000000018969FD20 
	
		// Constructors
		public TranslateTo() {} // 0x00000001896A8880-0x00000001896A8898
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A8660-0x00000001896A86B0
		protected override void OnUpdate(float time) {} // 0x00000001896A8704-0x00000001896A8880
		protected override void OnReverse() {} // 0x00000001896A86B0-0x00000001896A8704
	}

	[Category("Composition")]
	[Description("Additive load a Scene for a duration of time, or permanentely if length is zero.\n\nIf \'Update Root Cutscenes\' is true, all root cutscenes objects of that scene will also be updated for the duration of the clip with an optional time offset provided.")]
	public class AdditiveScene : DirectorActionClip, ISubClipContainable // TypeDefIndex: 54779
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
		float ISubClipContainable.subClipOffset { get => default; set {} } // 0x0000000183D56C00-0x0000000183D56C10 0x0000000183D5BD20-0x0000000183D5BD30
		float ISubClipContainable.subClipLength { get => default; } // 0x0000000183D503F0-0x0000000183D50400 
		float ISubClipContainable.subClipSpeed { get => default; } // 0x0000000183D503F0-0x0000000183D50400 
		public override bool isValid { get => default; } // 0x000000018969D004-0x000000018969D01C 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		new string IDirectable.name { get => default; } // 0x0000000184276114-0x000000018427611C 
	
		// Constructors
		public AdditiveScene() {} // 0x000000018969CFF0-0x000000018969D004
	
		// Methods
		protected override void OnEnter() {} // 0x000000018969CE74-0x000000018969CEA8
		protected override void OnReverseEnter() {} // 0x000000018969CEDC-0x000000018969CEF0
		protected override void OnUpdate(float time) {} // 0x000000018969CF14-0x000000018969CFF0
		protected override void OnExit() {} // 0x000000018969CEA8-0x000000018969CEDC
		protected override void OnReverse() {} // 0x000000018969CEF0-0x000000018969CF14
		private void Activate() {} // 0x000000018969C784-0x000000018969C818
		private void Deactivate() {} // 0x000000018969C89C-0x000000018969C910
		private string CleanPath(string path) => default; // 0x000000018969C818-0x000000018969C89C
		private void InitializeSubSceneCutscenes() {} // 0x000000018969CADC-0x000000018969CE74
		private void DenitializeSubSceneCutscenes(bool forward) {} // 0x000000018969C910-0x000000018969CADC
	}

	[Category("Composition")]
	[Description("SubCutscenes are used for organization. Notice that the CameraTrack of the SubCutscene is ignored if this Cutscene already has an active CameraTrack.")]
	public class SubCutscene : DirectorActionClip, ISubClipContainable // TypeDefIndex: 54780
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
		public override string info { get => default; } // 0x00000001896A8140-0x00000001896A8208 
		public override bool isValid { get => default; } // 0x00000001896A8208-0x00000001896A8274 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public new GameObject actor { get => default; } // 0x00000001896A80FC-0x00000001896A8140 
		float ISubClipContainable.subClipOffset { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
		float ISubClipContainable.subClipLength { get => default; } // 0x00000001896A8084-0x00000001896A80C0 
		float ISubClipContainable.subClipSpeed { get => default; } // 0x00000001896A80C0-0x00000001896A80FC 
		new string IDirectable.name { get => default; } // 0x0000000184276114-0x000000018427611C 
	
		// Constructors
		public SubCutscene() {} // 0x000000018968908C-0x000000018968909C
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A7D5C-0x00000001896A7E24
		protected override void OnReverseEnter() {} // 0x00000001896A7ECC-0x00000001896A7F98
		protected override void OnExit() {} // 0x00000001896A7E24-0x00000001896A7ECC
		protected override void OnReverse() {} // 0x00000001896A7F98-0x00000001896A8038
		protected override void OnUpdate(float time, float previousTime) {} // 0x00000001896A8038-0x00000001896A8084
	}

	[Category("Control")]
	[Description("Destroy all gameobjects in the list (PlayMode only).\nYou should NOT use this clip to destroy actors.")]
	public class DestroyGameObjects : DirectorActionClip // TypeDefIndex: 54781
	{
		// Fields
		public List<GameObject> targetObjects; // 0x40
	
		// Properties
		public override string info { get => default; } // 0x00000001896A0014-0x00000001896A0090 
	
		// Constructors
		public DestroyGameObjects() {} // 0x000000018969FF94-0x00000001896A0014
	
		// Methods
		protected override void OnEnter() {} // 0x000000018969FE40-0x000000018969FF94
	}

	[Category("Control")]
	[Description("All gameobjects in the list will be disabled if not already")]
	[Name("Disable Game Objects")]
	public class DirectorDisableGameObjects : DirectorActionClip // TypeDefIndex: 54782
	{
		// Fields
		public List<GameObject> targetObjects; // 0x40
		private Dictionary<GameObject, bool> states; // 0x48
	
		// Properties
		public override string info { get => default; } // 0x00000001896A0464-0x00000001896A04E0 
	
		// Constructors
		public DirectorDisableGameObjects() {} // 0x00000001896A03E4-0x00000001896A0464
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A0090-0x00000001896A0258
		protected override void OnReverse() {} // 0x00000001896A0258-0x00000001896A03E4
	}

	[Category("Control")]
	[Description("All gameobjects in the list will be enabled if not already")]
	[Name("Enable Game Objects")]
	public class DirectorEnableGameObjects : DirectorActionClip // TypeDefIndex: 54783
	{
		// Fields
		public List<GameObject> targetObjects; // 0x40
		private Dictionary<GameObject, bool> states; // 0x48
	
		// Properties
		public override string info { get => default; } // 0x00000001896A08B4-0x00000001896A0930 
	
		// Constructors
		public DirectorEnableGameObjects() {} // 0x00000001896A0834-0x00000001896A08B4
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A04E0-0x00000001896A06A8
		protected override void OnReverse() {} // 0x00000001896A06A8-0x00000001896A0834
	}

	[Category("Control")]
	[Description("Instantiates an object with optional popup animation if BlendIn is higher than zero. You can optionaly \'popdown\' and destroy the object after a period of time, if you also set a BlendOut value higher than zero.")]
	public class InstantiateObject : DirectorActionClip // TypeDefIndex: 54784
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
		public override bool isValid { get => default; } // 0x00000001896A1028-0x00000001896A1078 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override string info { get => default; } // 0x00000001896A0F88-0x00000001896A1028 
		private new GameObject actor { get => default; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 
	
		// Constructors
		public InstantiateObject() {} // 0x00000001896A0F70-0x00000001896A0F88
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A0A20-0x00000001896A0D30
		protected override void OnUpdate(float time) {} // 0x00000001896A0E20-0x00000001896A0F70
		protected override void OnExit() {} // 0x00000001896A0D30-0x00000001896A0D94
		protected override void OnReverseEnter() {} // 0x00000001896A0D94-0x00000001896A0DCC
		protected override void OnReverse() {} // 0x00000001896A0DCC-0x00000001896A0E20
	}

	[Category("Control")]
	public class SampleParticleSystem : DirectorActionClip // TypeDefIndex: 54785
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
		public override string info { get => default; } // 0x00000001896A5110-0x00000001896A5228 
		public override bool isValid { get => default; } // 0x00000001896A5228-0x00000001896A5278 
		public override float length { get => default; set {} } // 0x00000001896A5278-0x00000001896A5308 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendOut { get => default; } // 0x00000001896A5044-0x00000001896A508C 
		private bool loop { get => default; } // 0x00000001896A5308-0x00000001896A5388 
		private float duration { get => default; } // 0x00000001896A508C-0x00000001896A5110 
		private float startLifetime { get => default; } // 0x00000001896A5388-0x00000001896A540C 
	
		// Constructors
		public SampleParticleSystem() {} // 0x00000001896A5030-0x00000001896A5044
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A4E5C-0x00000001896A4E64
		protected override void OnReverseEnter() {} // 0x00000001896A4E5C-0x00000001896A4E64
		protected override void OnExit() {} // 0x00000001896A4E64-0x00000001896A4E6C
		protected override void OnReverse() {} // 0x00000001896A4E64-0x00000001896A4E6C
		protected override void OnRootEnabled() {} // 0x00000001896A4EB8-0x00000001896A4F08
		protected override void OnRootDisabled() {} // 0x00000001896A4E6C-0x00000001896A4EB8
		private void Play() {} // 0x00000001896A4F74-0x00000001896A4FF0
		protected override void OnUpdate(float time) {} // 0x00000001896A4F08-0x00000001896A4F74
		private void Stop() {} // 0x00000001896A4FF0-0x00000001896A5030
	}

	[Category("Control")]
	[Description("Will transit the given audio mixer to the given snapshot")]
	public class TransitAudioMixerSnapshot : DirectorActionClip // TypeDefIndex: 54786
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x40
		public AudioMixer audioMixer; // 0x48
		public string snapshotName; // 0x50
		private AudioMixerSnapshot snapshot; // 0x58
	
		// Properties
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; } // 0x000000018969FD10-0x000000018969FD20 
		public override bool isValid { get => default; } // 0x00000001896A830C-0x00000001896A835C 
	
		// Constructors
		public TransitAudioMixerSnapshot() {} // 0x000000018968908C-0x000000018968909C
	
		// Methods
		protected override void OnReverseEnter() {} // 0x00000001896A8304-0x00000001896A830C
		protected override void OnEnter() {} // 0x00000001896A8304-0x00000001896A830C
		private void Do() {} // 0x00000001896A8274-0x00000001896A8304
	}

	[Category("Environment")]
	public class AnimateAmbientLighting : DirectorActionClip // TypeDefIndex: 54787
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
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
	
		// Constructors
		public AnimateAmbientLighting() {} // 0x000000018968908C-0x000000018968909C
	
		// Methods
		protected override void OnCreate() {} // 0x000000018969D01C-0x000000018969D04C
		protected override void OnEnter() {} // 0x000000018969D04C-0x000000018969D07C
		protected override void OnUpdate(float time) {} // 0x000000018969D0AC-0x000000018969D12C
		protected override void OnReverse() {} // 0x000000018969D07C-0x000000018969D0AC
	}

	[Category("Environment")]
	public class AnimateFog : DirectorActionClip // TypeDefIndex: 54788
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
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
	
		// Constructors
		public AnimateFog() {} // 0x000000018968908C-0x000000018968909C
	
		// Methods
		protected override void OnCreate() {} // 0x000000018969D540-0x000000018969D588
		protected override void OnEnter() {} // 0x000000018969D588-0x000000018969D5D4
		protected override void OnUpdate(float time) {} // 0x000000018969D620-0x000000018969D6D4
		protected override void OnReverse() {} // 0x000000018969D5D4-0x000000018969D620
	}

	[Category("Environment")]
	[Description("Animate the gravity physics are using for Rigidbodies. This applies to both 2D and 3D Physics.")]
	public class AnimateGravity : DirectorActionClip // TypeDefIndex: 54789
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
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
	
		// Constructors
		public AnimateGravity() {} // 0x000000018968908C-0x000000018968909C
	
		// Methods
		protected override void OnCreate() {} // 0x000000018969D6D4-0x000000018969D700
		protected override void OnEnter() {} // 0x000000018969D700-0x000000018969D72C
		protected override void OnUpdate(float time) {} // 0x000000018969D7B8-0x000000018969D89C
		protected override void OnReverse() {} // 0x000000018969D72C-0x000000018969D7B8
	}

	[Category("Environment")]
	public class AnimateTimeScale : DirectorActionClip // TypeDefIndex: 54790
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
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
	
		// Constructors
		public AnimateTimeScale() {} // 0x000000018969F300-0x000000018969F318
	
		// Methods
		protected override void OnCreate() {} // 0x000000018969F318-0x000000018969F334
		protected override void OnEnter() {} // 0x000000018969F334-0x000000018969F350
		protected override void OnUpdate(float time) {} // 0x000000018969F35C-0x000000018969F3CC
		protected override void OnReverse() {} // 0x000000018969F350-0x000000018969F35C
	}

	[Category("Environment")]
	[Description("A quick way to create a slow-motion time effect.")]
	[Obsolete]
	public class EasySlowMotion : DirectorActionClip // TypeDefIndex: 54791
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
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override string info { get => default; } // 0x00000001896A09C4-0x00000001896A0A20 
	
		// Constructors
		public EasySlowMotion() {} // 0x00000001896A0998-0x00000001896A09C4
	
		// Methods
		protected override void OnEnter() {} // 0x000000018969F334-0x000000018969F350
		protected override void OnUpdate(float deltaTime) {} // 0x00000001896A0930-0x00000001896A0998
		protected override void OnReverse() {} // 0x000000018969F350-0x000000018969F35C
	}

	[Category("Events")]
	[Description("Raise a Unity Event when the time is moving forwards and another when the time is moving backwards. This is helpfull if you want to use these events with UI to reverse their state, both in runtime and in editor.")]
	public class RaiseUnityEvent : DirectorActionClip // TypeDefIndex: 54792
	{
		// Fields
		public string customLabel; // 0x40
		public UnityEvent forwardEvent; // 0x48
		public UnityEvent reverseEvent; // 0x50
	
		// Properties
		public override string info { get => default; } // 0x00000001896A3F60-0x00000001896A4184 
	
		// Constructors
		public RaiseUnityEvent() {} // 0x00000001896A3EC4-0x00000001896A3F60
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A3E84-0x00000001896A3EA4
		protected override void OnReverse() {} // 0x00000001896A3EA4-0x00000001896A3EC4
	}

	public abstract class SendGlobalMessage<T> : SendGlobalMessage // TypeDefIndex: 54793
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

	[Category("Events")]
	[Description("Send a Unity Message to all actors of this Cutscene, including the Director Camera, as well as the Cutscene itself.")]
	public class SendGlobalMessage : DirectorActionClip, IEvent // TypeDefIndex: 54794
	{
		// Fields
		[Required]
		public string message; // 0x40
	
		// Properties
		public override string info { get => default; } // 0x00000001896A5FF0-0x00000001896A6030 
		public override bool isValid { get => default; } // 0x0000000187C21C88-0x0000000187C21CA0 
		string IEvent.name { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
	
		// Constructors
		public SendGlobalMessage() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		void IEvent.Invoke() {} // 0x00000001892CE85C-0x00000001892CE86C
		protected override void OnEnter() {} // 0x00000001896A5FB0-0x00000001896A5FF0
	}

	public class SendGlobalMessageBoolean : SendGlobalMessage<bool> // TypeDefIndex: 54795
	{
		// Constructors
		public SendGlobalMessageBoolean() {} // 0x00000001896A5EAC-0x00000001896A5EE0
	}

	public class SendGlobalMessageFloat : SendGlobalMessage<float> // TypeDefIndex: 54796
	{
		// Constructors
		public SendGlobalMessageFloat() {} // 0x00000001896A5EE0-0x00000001896A5F14
	}

	public class SendGlobalMessageInteger : SendGlobalMessage<int> // TypeDefIndex: 54797
	{
		// Constructors
		public SendGlobalMessageInteger() {} // 0x00000001896A5F14-0x00000001896A5F48
	}

	public class SendGlobalMessageObject : SendGlobalMessage<UnityEngine.Object> // TypeDefIndex: 54798
	{
		// Constructors
		public SendGlobalMessageObject() {} // 0x00000001896A5F48-0x00000001896A5F7C
	}

	public class SendGlobalMessageString : SendGlobalMessage<string> // TypeDefIndex: 54799
	{
		// Constructors
		public SendGlobalMessageString() {} // 0x00000001896A5F7C-0x00000001896A5FB0
	}

	[Category("Rendering")]
	[Description("Shows closed captions at the bottom of the screen. Note that the Play Audio clips of the Audio Track are also able to show subtitles in sync with the audio. Use this for non audible subtitles or captions.")]
	public class Captions : DirectorActionClip // TypeDefIndex: 54800
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
		public override string info { get => default; } // 0x000000018969FC08-0x000000018969FC48 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
	
		// Constructors
		public Captions() {} // 0x000000018969FB94-0x000000018969FC08
	
		// Methods
		protected override void OnUpdate(float deltaTime) {} // 0x000000018969FB20-0x000000018969FB94
	}

	[Category("Rendering")]
	[Description("Controls the visibility of the Cinematic Letterbox. This is only usefull if you want a Cinematic Letterbox only in some parts of your cutscene. For this to work correctly, you should set the CineBox effect in the Cutscene CameraTrack to 0, so that the effect is not overriden.")]
	public class CineBox : DirectorActionClip // TypeDefIndex: 54801
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
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
	
		// Constructors
		public CineBox() {} // 0x000000018969FC60-0x000000018969FC7C
	
		// Methods
		protected override void OnUpdate(float time) {} // 0x000000018969FC48-0x000000018969FC60
	}

	[Category("Rendering")]
	[Description("Show text on screen")]
	public class OverlayText : DirectorActionClip // TypeDefIndex: 54802
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
		public override string info { get => default; } // 0x00000001896A23EC-0x00000001896A242C 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
	
		// Constructors
		public OverlayText() {} // 0x00000001896A2368-0x00000001896A23EC
	
		// Methods
		protected override void OnUpdate(float time) {} // 0x00000001896A22D4-0x00000001896A2368
	}

	[Category("Rendering")]
	[Description("Displays a texture overlay")]
	public class OverlayTexture : DirectorActionClip // TypeDefIndex: 54803
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
		public override string info { get => default; } // 0x00000001896A2518-0x00000001896A25B8 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
	
		// Constructors
		public OverlayTexture() {} // 0x00000001896A24C8-0x00000001896A2518
	
		// Methods
		protected override void OnUpdate(float deltaTime) {} // 0x00000001896A242C-0x00000001896A24C8
	}

	[Category("Rendering")]
	[Description("An alternative way to fade the screen. Fade out/in can also be done through the Camera Shot clip in the Camera Track, but with this clip, more effects can be achieved.")]
	public class ScreenFader : DirectorActionClip // TypeDefIndex: 54804
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
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
	
		// Constructors
		public ScreenFader() {} // 0x00000001896A5A2C-0x00000001896A5A78
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A5980-0x00000001896A59A0
		protected override void OnUpdate(float deltaTime) {} // 0x00000001896A59C0-0x00000001896A5A2C
		protected override void OnReverse() {} // 0x00000001896A59A0-0x00000001896A59C0
	}

	[Category("Utility")]
	[Description("Animates the playback speed of the cutscene")]
	public class AnimatePlaybackSpeed : DirectorActionClip // TypeDefIndex: 54805
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
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
	
		// Constructors
		public AnimatePlaybackSpeed() {} // 0x000000018969F300-0x000000018969F318
	
		// Methods
		protected override void OnCreate() {} // 0x000000018969F1D8-0x000000018969F208
		protected override void OnEnter() {} // 0x000000018969F208-0x000000018969F238
		protected override void OnUpdate(float time) {} // 0x000000018969F268-0x000000018969F300
		protected override void OnReverse() {} // 0x000000018969F238-0x000000018969F268
	}

	[Category("Utility")]
	public class DebugLog : DirectorActionClip // TypeDefIndex: 54806
	{
		// Fields
		[LeftToggle]
		public bool neverSkip; // 0x40
		public string text; // 0x48
	
		// Properties
		public override string info { get => default; } // 0x000000018969FE00-0x000000018969FE40 
	
		// Constructors
		public DebugLog() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void OnEnter() {} // 0x000000018969FD60-0x000000018969FE00
	}

	[Category("Utility")]
	[Description("Pauses the Cutscene (PlayMode Only). It\'s up to other scripts to resume it.")]
	public class PauseCutscene : DirectorActionClip // TypeDefIndex: 54807
	{
		// Constructors
		public PauseCutscene() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A25B8-0x00000001896A2684
	}

	[Category("Utilities")]
	[Description("Render the cutscene in an image-sequence for the selected duration of the clip. Rendering is done in playmode only.")]
	[Obsolete("Use the new \'Render\' feature")]
	public class ScreenCapture : DirectorActionClip // TypeDefIndex: 54808
	{
		// Constructors
		public ScreenCapture() {} // 0x000000018426FE60-0x000000018426FE68
	}

	[Attachable(new System.Type[1] {typeof(AnimationTrack) })]
	[Description("All animation clips in the same track, will play at an animation layer equal to their track layer order. Thus, animations in tracks on top will play over animations in tracks bellow. You can trim or loop the animation by scaling the clip.")]
	[Name("Animation Clip")]
	public class PlayAnimationClip : ActorActionClip<Animation>, ISubClipContainable // TypeDefIndex: 54809
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
		float ISubClipContainable.subClipOffset { get => default; set {} } // 0x0000000183D50D50-0x0000000183D50D60 0x0000000183D50D80-0x0000000183D50D90
		float ISubClipContainable.subClipLength { get => default; } // 0x00000001896A2C74-0x00000001896A2CE4 
		float ISubClipContainable.subClipSpeed { get => default; } // 0x0000000183D50D60-0x0000000183D50D70 
		public override string info { get => default; } // 0x00000001896A2D28-0x00000001896A2D9C 
		public override bool isValid { get => default; } // 0x00000001896A2D9C-0x00000001896A2E2C 
		public override float length { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override float blendIn { get => default; set {} } // 0x0000000183D50200-0x0000000183D50210 0x0000000183D5E680-0x0000000183D5E690
		public override float blendOut { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
		public override bool canCrossBlend { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		private AnimationTrack track { get => default; } // 0x00000001896A2E2C-0x00000001896A2E68 
		new string IDirectable.name { get => default; } // 0x0000000184276114-0x000000018427611C 
	
		// Constructors
		public PlayAnimationClip() {} // 0x00000001896A2CE4-0x00000001896A2D28
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A2684-0x00000001896A286C
		protected override void OnUpdate(float time) {} // 0x00000001896A2934-0x00000001896A2C74
		protected override void OnReverse() {} // 0x00000001896A28B4-0x00000001896A2934
		protected override void OnExit() {} // 0x00000001896A286C-0x00000001896A2890
		protected override void OnReverseEnter() {} // 0x00000001896A2890-0x00000001896A28B4
	}

	[Attachable(new System.Type[1] {typeof(AnimatorTrack) })]
	[Description("Play an Animation Clip on target actor with Animator component attached.\nIf this is the Layer 0 Animator Track, you can choose to explicitely set a \'Starting Position\' and a \'Starting Rotation\' for when the clip starts. This also takes into account Root Motion if enabled in the Animator Track.")]
	[Name("Animation Clip")]
	public class PlayAnimatorClip : ActorActionClip, ISubClipContainable // TypeDefIndex: 54812
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
		private bool isMasterAndManualSet { get => default; } // 0x00000001896A3780-0x00000001896A37A4 
		float ISubClipContainable.subClipOffset { get => default; set {} } // 0x0000000183D51080-0x0000000183D51090 0x0000000183D510B0-0x0000000183D510C0
		float ISubClipContainable.subClipLength { get => default; } // 0x00000001896A3658-0x00000001896A36C8 
		float ISubClipContainable.subClipSpeed { get => default; } // 0x0000000183D50D60-0x0000000183D50D70 
		public override string info { get => default; } // 0x00000001896A3708-0x00000001896A3780 
		public override bool isValid { get => default; } // 0x00000001896A37C8-0x00000001896A3874 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override bool canCrossBlend { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		protected AnimatorTrack track { get => default; } // 0x00000001896A3874-0x00000001896A38B0 
		protected Animator animator { get => default; } // 0x00000001896A36E4-0x00000001896A3708 
		protected bool isMasterTrack { get => default; } // 0x00000001896A37A4-0x00000001896A37C8 
		new string IDirectable.name { get => default; } // 0x0000000184276114-0x000000018427611C 
	
		// Nested types
		public enum StartingTransformsMode // TypeDefIndex: 54810
		{
			AutoMatchTransforms = 0,
			ManualSetTransforms = 1
		}
	
		public enum ClipWrapMode // TypeDefIndex: 54811
		{
			Loop = 0,
			PingPong = 1
		}
	
		// Constructors
		public PlayAnimatorClip() {} // 0x00000001896A36C8-0x00000001896A36E4
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A2E68-0x00000001896A308C
		protected override void OnReverseEnter() {} // 0x00000001896A30F0-0x00000001896A3154
		protected override void OnUpdate(float time, float previousTime) {} // 0x00000001896A3234-0x00000001896A3658
		protected override void OnExit() {} // 0x00000001896A308C-0x00000001896A30F0
		protected override void OnReverse() {} // 0x00000001896A3154-0x00000001896A3234
	}

	[Attachable(new System.Type[2] {typeof(ActorAudioTrack), typeof(DirectorAudioTrack) })]
	[Description("The audio clip will be send to the AudioMixer selected in it\'s track if any. You can trim or loop the audio by scaling the clip and you can optionaly show subtitles as well.")]
	[Name("Audio Clip")]
	public class PlayAudio : ActionClip, ISubClipContainable // TypeDefIndex: 54813
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
		float ISubClipContainable.subClipOffset { get => default; set {} } // 0x0000000183D50D60-0x0000000183D50D70 0x0000000183D50D70-0x0000000183D50D80
		float ISubClipContainable.subClipLength { get => default; } // 0x00000001896A3C14-0x00000001896A3C84 
		float ISubClipContainable.subClipSpeed { get => default; } // 0x0000000183D51A60-0x0000000183D51A70 
		public override float length { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
		public override float blendIn { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public override float blendOut { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override bool isValid { get => default; } // 0x00000001896A3DD8-0x00000001896A3E28 
		public override string info { get => default; } // 0x00000001896A3D50-0x00000001896A3DD8 
		private Slate.AudioTrack track { get => default; } // 0x00000001896A3E48-0x00000001896A3E84 
		private AudioSource source { get => default; } // 0x00000001896A3E28-0x00000001896A3E48 
		new string IDirectable.name { get => default; } // 0x0000000184276114-0x000000018427611C 
	
		// Constructors
		public PlayAudio() {} // 0x00000001896A3D04-0x00000001896A3D50
	
		// Methods
		protected override void OnEnter() {} // 0x00000001896A3934-0x00000001896A393C
		protected override void OnReverseEnter() {} // 0x00000001896A3934-0x00000001896A393C
		protected override void OnExit() {} // 0x00000001896A393C-0x00000001896A3944
		protected override void OnReverse() {} // 0x00000001896A393C-0x00000001896A3944
		private void Do() {} // 0x00000001896A38B0-0x00000001896A3934
		protected override void OnUpdate(float time, float previousTime) {} // 0x00000001896A3944-0x00000001896A3C14
		private void Undo() {} // 0x00000001896A3C84-0x00000001896A3D04
	}

	[Description("Animate a bool Animator parameter and reset it back to previous value after a period of time.")]
	public class AnimateBoolParameter : MecanimBaseClip // TypeDefIndex: 54814
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
		public override bool isValid { get => default; } // 0x000000018969D304-0x000000018969D334 
		public override string info { get => default; } // 0x000000018969D2C4-0x000000018969D304 
		public override float length { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
	
		// Constructors
		public AnimateBoolParameter() {} // 0x000000018969D2B0-0x000000018969D2C4
	
		// Methods
		protected override void OnEnter() {} // 0x000000018969D12C-0x000000018969D184
		protected override void OnUpdate(float time) {} // 0x000000018969D258-0x000000018969D2B0
		protected override void OnExit() {} // 0x000000018969D184-0x000000018969D1F4
		protected override void OnReverse() {} // 0x000000018969D1F4-0x000000018969D258
	}

	[Description("Animate a float Animator parameter to a value and back to previous value gradualy over a period of time.")]
	public class AnimateFloatParameter : MecanimBaseClip // TypeDefIndex: 54815
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
		public override bool isValid { get => default; } // 0x000000018969D510-0x000000018969D540 
		public override string info { get => default; } // 0x000000018969D4D0-0x000000018969D510 
		public override float length { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override float blendIn { get => default; set {} } // 0x0000000183D50200-0x0000000183D50210 0x0000000183D5E680-0x0000000183D5E690
		public override float blendOut { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
	
		// Constructors
		public AnimateFloatParameter() {} // 0x000000018969D4AC-0x000000018969D4D0
	
		// Methods
		protected override void OnEnter() {} // 0x000000018969D334-0x000000018969D390
		protected override void OnUpdate(float deltaTime) {} // 0x000000018969D3F4-0x000000018969D4AC
		protected override void OnReverse() {} // 0x000000018969D390-0x000000018969D3F4
	}

	[Description("Animate an integer Animator parameter to a value and back to previous value gradualy over a period of time.")]
	public class AnimateIntegerParameter : MecanimBaseClip // TypeDefIndex: 54816
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
		public override bool isValid { get => default; } // 0x000000018969D510-0x000000018969D540 
		public override string info { get => default; } // 0x000000018969DA30-0x000000018969DA70 
		public override float length { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override float blendIn { get => default; set {} } // 0x0000000183D50200-0x0000000183D50210 0x0000000183D5E680-0x0000000183D5E690
		public override float blendOut { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
	
		// Constructors
		public AnimateIntegerParameter() {} // 0x000000018969DA14-0x000000018969DA30
	
		// Methods
		protected override void OnEnter() {} // 0x000000018969D89C-0x000000018969D8F4
		protected override void OnUpdate(float deltaTime) {} // 0x000000018969D958-0x000000018969DA14
		protected override void OnReverse() {} // 0x000000018969D8F4-0x000000018969D958
	}

	[Description("Animate an Animator layer weight to a value and back to previous value gradualy over a period of time.")]
	public class AnimateLayerWeight : MecanimBaseClip // TypeDefIndex: 54817
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
		public override string info { get => default; } // 0x000000018969DC08-0x000000018969DC68 
		public override float length { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override float blendIn { get => default; set {} } // 0x0000000183D50200-0x0000000183D50210 0x0000000183D5E680-0x0000000183D5E690
		public override float blendOut { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
	
		// Constructors
		public AnimateLayerWeight() {} // 0x000000018969DBE4-0x000000018969DC08
	
		// Methods
		protected override void OnEnter() {} // 0x000000018969DA70-0x000000018969DAC8
		protected override void OnUpdate(float deltaTime) {} // 0x000000018969DB2C-0x000000018969DBE4
		protected override void OnReverse() {} // 0x000000018969DAC8-0x000000018969DB2C
	}

	[Attachable(new System.Type[1] {typeof(ActorActionTrack) })]
	[Category("Animator IK Control")]
	[Description("Animate an actor IK Goal. Please note that the Animator needs to have a Controller assigned and \'IK Pass\' must be enabled in that Controller.")]
	public class AnimateLimbIK : ActorActionClip<Animator> // TypeDefIndex: 54819
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
		public Vector3 targetPosition { get => default; set {} } // 0x000000018969E508-0x000000018969E53C 0x0000000183D75030-0x0000000183D75040
		[AnimatableParameter(link = "IKTarget")]
		[RotationHandle("targetPosition")]
		public Vector3 targetRotation { get => default; set {} } // 0x000000018969E53C-0x000000018969E570 0x0000000183D750E0-0x0000000183D75100
		public override string info { get => default; } // 0x000000018969E498-0x000000018969E508 
		public override float length { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override float blendIn { get => default; set {} } // 0x0000000183D50200-0x0000000183D50210 0x0000000183D5E680-0x0000000183D5E690
		public override float blendOut { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
	
		// Constructors
		public AnimateLimbIK() {} // 0x000000018969E444-0x000000018969E498
	
		// Methods
		protected override void OnCreate() {} // 0x000000018969E078-0x000000018969E0B4
		protected override void OnAfterValidate() {} // 0x000000018969DC68-0x000000018969DEB4
		protected override void OnEnter() {} // 0x000000018969E0B4-0x000000018969E1AC
		protected override void OnReverseEnter() {} // 0x000000018969E240-0x000000018969E338
		protected override void OnReverse() {} // 0x000000018969E338-0x000000018969E3CC
		protected override void OnExit() {} // 0x000000018969E1AC-0x000000018969E240
		protected override void OnRootDisabled() {} // 0x000000018969E3CC-0x000000018969E444
		private void OnAnimatorIK(int index) {} // 0x000000018969DEB4-0x000000018969E078
	}

	[Attachable(new System.Type[1] {typeof(ActorActionTrack) })]
	[Category("Animator IK Control")]
	[Description("Make the actor look at target position. Please note that the Animator needs to have a Controller assigned and \'IK Pass\' must be enabled in that Controller.")]
	public class AnimateLookAtIK : ActorActionClip<Animator> // TypeDefIndex: 54821
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
		public Vector3 targetPositionVector { get => default; set {} } // 0x000000018969EC90-0x000000018969ECC4 0x0000000183D75100-0x0000000183D75120
		public override string info { get => default; } // 0x000000018969EC64-0x000000018969EC90 
		public override float length { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override float blendIn { get => default; set {} } // 0x0000000183D50200-0x0000000183D50210 0x0000000183D5E680-0x0000000183D5E690
		public override float blendOut { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
	
		// Constructors
		public AnimateLookAtIK() {} // 0x000000018969EC08-0x000000018969EC64
	
		// Methods
		protected override void OnCreate() {} // 0x000000018969E838-0x000000018969E878
		protected override void OnAfterValidate() {} // 0x000000018969E570-0x000000018969E6F4
		protected override void OnEnter() {} // 0x000000018969E878-0x000000018969E970
		protected override void OnReverseEnter() {} // 0x000000018969EA04-0x000000018969EAFC
		protected override void OnReverse() {} // 0x000000018969EAFC-0x000000018969EB90
		protected override void OnExit() {} // 0x000000018969E970-0x000000018969EA04
		protected override void OnRootDisabled() {} // 0x000000018969EB90-0x000000018969EC08
		private void OnAnimatorIK(int index) {} // 0x000000018969E6F4-0x000000018969E838
	}

	public class AnimateTrigger : MecanimBaseClip // TypeDefIndex: 54822
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		public string triggerName; // 0x50
		[AnimatableParameter]
		public bool value; // 0x58
	
		// Properties
		public override bool isValid { get => default; } // 0x000000018969D304-0x000000018969D334 
		public override string info { get => default; } // 0x000000018969F454-0x000000018969F494 
		public override float length { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
	
		// Constructors
		public AnimateTrigger() {} // 0x000000018969F444-0x000000018969F454
	
		// Methods
		protected override void OnUpdate(float time) {} // 0x000000018969F3CC-0x000000018969F444
	}

	[Description("CrossFades to an Animator state within a period of time.")]
	public class CrossFadeState : MecanimBaseClip // TypeDefIndex: 54823
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _length; // 0x48
		[Required]
		public string stateName; // 0x50
	
		// Properties
		public override string info { get => default; } // 0x000000018969FD20-0x000000018969FD60 
		public override float length { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public override float blendIn { get => default; } // 0x000000018969FD10-0x000000018969FD20 
	
		// Constructors
		public CrossFadeState() {} // 0x000000018969F444-0x000000018969F454
	
		// Methods
		protected override void OnEnter() {} // 0x000000018969FC7C-0x000000018969FD10
	}

	[Attachable(new System.Type[1] {typeof(MecanimTrack) })]
	public abstract class MecanimBaseClip : ActorActionClip<Animator> // TypeDefIndex: 54825
	{
		// Properties
		public override bool isValid { get; } // 0x00000001896A1F44-0x00000001896A1FF8 
	
		// Constructors
		protected MecanimBaseClip() {} // 0x00000001896A1F10-0x00000001896A1F44
	
		// Methods
		protected bool HasParameter(string name) => default; // 0x00000001896A1C64-0x00000001896A1F10
	}
}
