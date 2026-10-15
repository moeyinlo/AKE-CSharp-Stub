/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.Rendering;

// Image 68: CW.Common.dll - Assembly: CW.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 89477-89510

namespace CW.Common
{
	[AddComponentMenu("Common/CW Camera Look")]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwCameraLook")]
	public class CwCameraLook : MonoBehaviour // TypeDefIndex: 89478
	{
		// Fields
		[SerializeField]
		private bool listen; // 0x18
		[SerializeField]
		private float damping; // 0x1C
		[SerializeField]
		private float sensitivity; // 0x20
		[SerializeField]
		private CwInputManager.Axis pitchControls; // 0x24
		[SerializeField]
		private CwInputManager.Axis yawControls; // 0x48
		[SerializeField]
		private CwInputManager.Axis rollControls; // 0x6C
		[NonSerialized]
		private Quaternion remainingDelta; // 0x90
	
		// Properties
		public bool Listen { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public float Damping { get; set; } // 0x0000000187233410-0x0000000187233420 0x0000000187233420-0x0000000187233430
		public float Sensitivity { get; set; } // 0x00000001872332C0-0x00000001872332D0 0x00000001872332D0-0x00000001872332E0
		public CwInputManager.Axis PitchControls { get; set; } // 0x0000000187236360-0x0000000187236380 0x00000001872363C0-0x00000001872363E0
		public CwInputManager.Axis YawControls { get; set; } // 0x00000001872363A0-0x00000001872363C0 0x0000000187236400-0x0000000187236420
		public CwInputManager.Axis RollControls { get; set; } // 0x0000000187236380-0x00000001872363A0 0x00000001872363E0-0x0000000187236400
	
		// Constructors
		public CwCameraLook(); // 0x0000000188C29E18-0x0000000188C29EFC
	
		// Methods
		protected virtual void Start(); // 0x0000000188C29DB0-0x0000000188C29DF0
		protected virtual void OnDisable(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void Update(); // 0x0000000188C29DF0-0x0000000188C29E18
		protected virtual void OnApplicationFocus(bool focus); // 0x0000000186805BA0-0x0000000186805BB0
		private void AddToDelta(); // 0x0000000188C29A24-0x0000000188C29C34
		private void DampenDelta(); // 0x0000000188C29C34-0x0000000188C29DB0
	}

	[AddComponentMenu("Common/CW Camera Move")]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwCameraMove")]
	public class CwCameraMove : MonoBehaviour // TypeDefIndex: 89479
	{
		// Fields
		[SerializeField]
		private bool listen; // 0x18
		[SerializeField]
		private float damping; // 0x1C
		[SerializeField]
		private float sensitivity; // 0x20
		[SerializeField]
		private CwInputManager.Axis horizontalControls; // 0x24
		[SerializeField]
		private CwInputManager.Axis depthControls; // 0x48
		[SerializeField]
		private CwInputManager.Axis verticalControls; // 0x6C
		[NonSerialized]
		private Vector3 remainingDelta; // 0x90
	
		// Properties
		public bool Listen { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public float Damping { get; set; } // 0x0000000187233410-0x0000000187233420 0x0000000187233420-0x0000000187233430
		public float Sensitivity { get; set; } // 0x00000001872332C0-0x00000001872332D0 0x00000001872332D0-0x00000001872332E0
		public CwInputManager.Axis HorizontalControls { get; set; } // 0x0000000187236360-0x0000000187236380 0x00000001872363C0-0x00000001872363E0
		public CwInputManager.Axis DepthControls { get; set; } // 0x00000001872363A0-0x00000001872363C0 0x0000000187236400-0x0000000187236420
		public CwInputManager.Axis VerticalControls { get; set; } // 0x0000000187236380-0x00000001872363A0 0x00000001872363E0-0x0000000187236400
	
		// Constructors
		public CwCameraMove(); // 0x0000000188C2A318-0x0000000188C2A3F4
	
		// Methods
		protected virtual void Start(); // 0x0000000188C2A2B0-0x0000000188C2A2F0
		protected virtual void Update(); // 0x0000000188C2A2F0-0x0000000188C2A318
		private void AddToDelta(); // 0x0000000188C29EFC-0x0000000188C2A120
		private void DampenDelta(); // 0x0000000188C2A120-0x0000000188C2A2B0
	}

	[AddComponentMenu("Common/CW Camera Pivot")]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwCameraPivot")]
	public class CwCameraPivot : MonoBehaviour // TypeDefIndex: 89480
	{
		// Fields
		[SerializeField]
		private bool listen; // 0x18
		[SerializeField]
		private float damping; // 0x1C
		[SerializeField]
		private CwInputManager.Axis pitchControls; // 0x20
		[SerializeField]
		private CwInputManager.Axis yawControls; // 0x44
		[NonSerialized]
		private Vector3 remainingDelta; // 0x68
	
		// Properties
		public bool Listen { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public float Damping { get; set; } // 0x0000000187233410-0x0000000187233420 0x0000000187233420-0x0000000187233430
		public CwInputManager.Axis PitchControls { get; set; } // 0x0000000187236420-0x0000000187236440 0x0000000187236460-0x0000000187236480
		public CwInputManager.Axis YawControls { get; set; } // 0x0000000187236440-0x0000000187236460 0x0000000187236480-0x00000001872364A0
	
		// Constructors
		public CwCameraPivot(); // 0x0000000188C2A69C-0x0000000188C2A724
	
		// Methods
		protected virtual void OnEnable(); // 0x0000000188C2A634-0x0000000188C2A674
		protected virtual void Update(); // 0x0000000188C2A674-0x0000000188C2A69C
		private void AddToDelta(); // 0x0000000188C2A3F4-0x0000000188C2A458
		private void DampenDelta(); // 0x0000000188C2A458-0x0000000188C2A634
	}

	[AddComponentMenu("")]
	[ExecuteInEditMode]
	public class CwDemo : MonoBehaviour // TypeDefIndex: 89481
	{
		// Fields
		[SerializeField]
		private bool upgradeInputModule; // 0x18
		[SerializeField]
		private bool changeExposureInHDRP; // 0x19
		[SerializeField]
		private bool changeVisualEnvironmentInHDRP; // 0x1A
		[SerializeField]
		private bool changeFogInHDRP; // 0x1B
		[SerializeField]
		private bool changeCloudsInHDRP; // 0x1C
		[SerializeField]
		private bool changeMotionBlurInHDRP; // 0x1D
		[SerializeField]
		private bool upgradeLightsInHDRP; // 0x1E
		[SerializeField]
		private bool upgradeCamerasInHDRP; // 0x1F
	
		// Properties
		public bool UpgradeInputModule { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public bool ChangeExposureInHDRP { get; set; } // 0x000000018225E010-0x000000018225E020 0x000000018225E020-0x000000018225E030
		public bool ChangeVisualEnvironmentInHDRP { get; set; } // 0x000000018226EDC0-0x000000018226EDD0 0x000000018226EDD0-0x000000018226EDE0
		public bool ChangeFogInHDRP { get; set; } // 0x00000001872364A0-0x00000001872364B0 0x00000001872364D0-0x00000001872364E0
		public bool ChangeCloudsInHDRP { get; set; } // 0x000000018226EB80-0x000000018226EB90 0x000000018226EB90-0x000000018226EBA0
		public bool ChangeMotionBlurInHDRP { get; set; } // 0x000000018226ED00-0x000000018226ED10 0x000000018226ED10-0x000000018226ED20
		public bool UpgradeLightsInHDRP { get; set; } // 0x00000001872364C0-0x00000001872364D0 0x00000001872364F0-0x0000000187236500
		public bool UpgradeCamerasInHDRP { get; set; } // 0x00000001872364B0-0x00000001872364C0 0x00000001872364E0-0x00000001872364F0
	
		// Constructors
		public CwDemo(); // 0x0000000188C2B2E4-0x0000000188C2B308
	
		// Methods
		protected virtual void OnEnable(); // 0x0000000188C2B2D4-0x0000000188C2B2E4
		protected virtual void TryApplyURP(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void TryApplyHDRP(); // 0x000000018722B770-0x000000018722B780
		private void TryCreateVolume(); // 0x0000000186805BA0-0x0000000186805BB0
		private void TryUpgradeLights(); // 0x0000000186805BA0-0x0000000186805BB0
		private void TryUpgradeCameras(); // 0x0000000186805BA0-0x0000000186805BB0
		private void TryUpgradeEventSystem(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AddComponentMenu("Common/CW Demo Button")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwDemoButton")]
	public class CwDemoButton : MonoBehaviour, IPointerDownHandler // TypeDefIndex: 89484
	{
		// Fields
		[SerializeField]
		private LinkType link; // 0x18
		[SerializeField]
		private string urlTarget; // 0x20
		[SerializeField]
		private Transform isolateTarget; // 0x28
		[SerializeField]
		private ToggleType isolateToggle; // 0x30
		[NonSerialized]
		private CanvasGroup cachedCanvasGroup; // 0x38
		[NonSerialized]
		private Transform previousChild; // 0x40
	
		// Properties
		public LinkType Link { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public string UrlTarget { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public Transform IsolateTarget { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public ToggleType IsolateToggle { get; set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
	
		// Nested types
		public enum LinkType // TypeDefIndex: 89482
		{
			PreviousScene = 0,
			NextScene = 1,
			Publisher = 2,
			URL = 3,
			Isolate = 4
		}
	
		public enum ToggleType // TypeDefIndex: 89483
		{
			KeepSelected = 0,
			ToggleSelection = 1,
			SelectPrevious = 2
		}
	
		// Constructors
		public CwDemoButton(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		protected virtual void OnEnable(); // 0x0000000188C2AC08-0x0000000188C2AC50
		protected virtual void Update(); // 0x0000000188C2B18C-0x0000000188C2B2D4
		public void OnPointerDown(PointerEventData eventData); // 0x0000000188C2AC50-0x0000000188C2B18C
		private static int GetCurrentLevel(); // 0x0000000188C2AB0C-0x0000000188C2AB80
		private static int GetLevelCount(); // 0x0000000188C2AB80-0x0000000188C2ABC0
		private static void LoadLevel(int index); // 0x0000000188C2ABC0-0x0000000188C2AC08
	}

	[AddComponentMenu("Common/CW Demo Button Builder")]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwDemoButtonBuilder")]
	public class CwDemoButtonBuilder : MonoBehaviour // TypeDefIndex: 89485
	{
		// Fields
		[SerializeField]
		private GameObject buttonPrefab; // 0x18
		[SerializeField]
		private RectTransform buttonRoot; // 0x20
		[SerializeField]
		private Sprite icon; // 0x28
		[SerializeField]
		private UnityEngine.Color color; // 0x30
		[Multiline(3)]
		[SerializeField]
		private string overrideName; // 0x40
		[SerializeField]
		private GameObject clone; // 0x48
	
		// Properties
		public GameObject ButtonPrefab { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public RectTransform ButtonRoot { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public Sprite Icon { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public UnityEngine.Color Color { get; set; } // 0x0000000187234010-0x0000000187234020 0x0000000187234020-0x0000000187234030
		public string OverrideName { get; set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
	
		// Constructors
		public CwDemoButtonBuilder(); // 0x0000000188C2AAD4-0x0000000188C2AB0C
	
		// Methods
		[ContextMenu("Build")]
		public void Build(); // 0x0000000188C2A848-0x0000000188C2AA6C
		[ContextMenu("Build All")]
		public void BuildAll(); // 0x0000000188C2A7A0-0x0000000188C2A848
		private GameObject DoInstantiate(); // 0x0000000188C2AA6C-0x0000000188C2AAD4
	}

	[AddComponentMenu("Common/CW Light Intensity")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwLightIntensity")]
	[RequireComponent(typeof(Light))]
	public class CwLightIntensity : MonoBehaviour // TypeDefIndex: 89486
	{
		// Fields
		[SerializeField]
		private float multiplier; // 0x18
		[SerializeField]
		private float intensityInStandard; // 0x1C
		[SerializeField]
		private float intensityInURP; // 0x20
		[SerializeField]
		private float intensityInHDRP; // 0x24
		[NonSerialized]
		private Light cachedLight; // 0x28
		[NonSerialized]
		private bool cachedLightSet; // 0x30
	
		// Properties
		public float Multiplier { get; set; } // 0x0000000187233050-0x0000000187233060 0x0000000187233060-0x0000000187233070
		public float IntensityInStandard { get; set; } // 0x0000000187233410-0x0000000187233420 0x0000000187233420-0x0000000187233430
		public float IntensityInURP { get; set; } // 0x00000001872332C0-0x00000001872332D0 0x00000001872332D0-0x00000001872332E0
		public float IntensityInHDRP { get; set; } // 0x0000000187236710-0x0000000187236720 0x0000000187236720-0x0000000187236730
		public Light CachedLight { get; } // 0x0000000188C30594-0x0000000188C305EC 
	
		// Constructors
		public CwLightIntensity(); // 0x0000000188C30560-0x0000000188C30594
	
		// Methods
		protected virtual void Update(); // 0x0000000188C30500-0x0000000188C30560
		private void ApplyIntensity(float intensity); // 0x0000000188C30478-0x0000000188C30500
	}

	[AddComponentMenu("Common/CW Rotate")]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwRotate")]
	public class CwRotate : MonoBehaviour // TypeDefIndex: 89487
	{
		// Fields
		[SerializeField]
		private Vector3 angularVelocity; // 0x18
		[SerializeField]
		private UnityEngine.Space relativeTo; // 0x24
	
		// Properties
		public Vector3 AngularVelocity { get; set; } // 0x0000000187236730-0x0000000187236750 0x0000000187236750-0x0000000187236760
		public UnityEngine.Space RelativeTo { get; set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
	
		// Constructors
		public CwRotate(); // 0x0000000188C30BE8-0x0000000188C30C18
	
		// Methods
		protected virtual void Update(); // 0x0000000188C30B54-0x0000000188C30BE8
	}

	public abstract class CwChild : MonoBehaviour // TypeDefIndex: 89489
	{
		// Nested types
		public interface IHasChildren // TypeDefIndex: 89488
		{
			// Methods
			bool HasChild(CwChild child);
		}
	
		// Constructors
		protected CwChild(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void DestroyGameObjectIfInvalid(); // 0x0000000188C2A724-0x0000000188C2A7A0
		protected abstract IHasChildren GetParent();
		protected virtual void Start(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AddComponentMenu("Common/CW Depth Texture Mode")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwDepthTextureMode")]
	[RequireComponent(typeof(Camera))]
	public class CwDepthTextureMode : MonoBehaviour // TypeDefIndex: 89490
	{
		// Fields
		[SerializeField]
		private DepthTextureMode depthMode; // 0x18
		[NonSerialized]
		private Camera cachedCamera; // 0x20
	
		// Properties
		public DepthTextureMode DepthMode { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x0000000188C2B3A8-0x0000000188C2B3B4
	
		// Constructors
		public CwDepthTextureMode(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void UpdateDepthMode(); // 0x0000000188C2B308-0x0000000188C2B3A0
		protected virtual void Update(); // 0x0000000188C2B3A0-0x0000000188C2B3A8
	}

	[AddComponentMenu("Common/CW Follow")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwFollow")]
	public class CwFollow : MonoBehaviour // TypeDefIndex: 89493
	{
		// Fields
		[SerializeField]
		private FollowType follow; // 0x18
		[SerializeField]
		private Transform target; // 0x20
		[SerializeField]
		private float damping; // 0x28
		[SerializeField]
		private bool rotate; // 0x2C
		[SerializeField]
		private bool ignoreZ; // 0x2D
		[SerializeField]
		private UpdateType followIn; // 0x30
		[SerializeField]
		private Vector3 localPosition; // 0x34
		[SerializeField]
		private Vector3 localRotation; // 0x40
	
		// Properties
		public FollowType Follow { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public Transform Target { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public float Damping { get; set; } // 0x0000000187233430-0x0000000187233440 0x0000000187233440-0x0000000187233450
		public bool Rotate { get; set; } // 0x000000018224A5F0-0x000000018224A600 0x000000018224A600-0x000000018224A610
		public bool IgnoreZ { get; set; } // 0x000000018225E0B0-0x000000018225E0C0 0x000000018225E0C0-0x000000018225E0D0
		public UpdateType FollowIn { get; set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
		public Vector3 LocalPosition { get; set; } // 0x0000000187236500-0x0000000187236520 0x0000000187236540-0x0000000187236550
		public Vector3 LocalRotation { get; set; } // 0x0000000187236520-0x0000000187236540 0x0000000187236550-0x0000000187236560
	
		// Nested types
		public enum FollowType // TypeDefIndex: 89491
		{
			TargetTransform = 0,
			MainCamera = 1
		}
	
		public enum UpdateType // TypeDefIndex: 89492
		{
			Update = 0,
			LateUpdate = 1
		}
	
		// Constructors
		public CwFollow(); // 0x0000000188C2B698-0x0000000188C2B6C0
	
		// Methods
		[ContextMenu("UpdatePosition")]
		public void UpdatePosition(); // 0x0000000188C2B3C4-0x0000000188C2B688
		protected virtual void Update(); // 0x0000000188C2B688-0x0000000188C2B698
		protected virtual void LateUpdate(); // 0x0000000188C2B3B4-0x0000000188C2B3C4
	}

	[AddComponentMenu("Common/CW Input Manager")]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwInputManager")]
	public class CwInputManager : MonoBehaviour // TypeDefIndex: 89499
	{
		// Fields
		[SerializeField]
		private LayerMask guiLayers; // 0x18
		[CompilerGenerated]
		private static Action<Finger> OnFingerDown; // 0x00
		[CompilerGenerated]
		private static Action<Finger> OnFingerUpdate; // 0x08
		[CompilerGenerated]
		private static Action<Finger> OnFingerUp; // 0x10
		public const int MOUSE_FINGER_INDEX = -1; // Metadata: 0x0264912D
		public const int HOVER_FINGER_INDEX = -1337; // Metadata: 0x0264912E
		private static List<RaycastResult> tempRaycastResults; // 0x18
		private static PointerEventData tempPointerEventData; // 0x20
		private static EventSystem tempEventSystem; // 0x28
		private static List<Finger> fingers; // 0x30
		private static List<Finger> filteredFingers; // 0x38
		private static Stack<Finger> pool; // 0x40
	
		// Properties
		public LayerMask GuiLayers { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public static List<Finger> Fingers { get; } // 0x0000000188C2FB24-0x0000000188C2FB74 
		public static float ScaleFactor { get; } // 0x0000000188C2FB74-0x0000000188C2FBA0 
	
		// Events
		public static event Action<Finger> OnFingerDown {
			add; // 0x0000000188C2F8D0-0x0000000188C2F994
			remove; // 0x0000000188C2FBA0-0x0000000188C2FC64
		}
		public static event Action<Finger> OnFingerUpdate {
			add; // 0x0000000188C2FA5C-0x0000000188C2FB24
			remove; // 0x0000000188C2FD2C-0x0000000188C2FDF4
		}
		public static event Action<Finger> OnFingerUp {
			add; // 0x0000000188C2F994-0x0000000188C2FA5C
			remove; // 0x0000000188C2FC64-0x0000000188C2FD2C
		}
	
		// Nested types
		public enum AxisGesture // TypeDefIndex: 89494
		{
			HorizontalDrag = 0,
			VerticalDrag = 1,
			Twist = 2,
			HorizontalPull = 3,
			VerticalPull = 4
		}
	
		[Serializable]
		public struct Axis // TypeDefIndex: 89495
		{
			// Fields
			public int FingerCount; // 0x00
			public bool FingerInvert; // 0x04
			public AxisGesture FingerGesture; // 0x08
			public float FingerSensitivity; // 0x0C
			public KeyCode KeyNegative; // 0x10
			public KeyCode KeyPositive; // 0x14
			public KeyCode KeyNegativeAlt; // 0x18
			public KeyCode KeyPositiveAlt; // 0x1C
			public float KeySensitivity; // 0x20
	
			// Constructors
			public Axis(int fCount, bool fInvert, AxisGesture fGesture, float fSensitivty, KeyCode kNegative, KeyCode kPositive, KeyCode kNegativeAlt, KeyCode kPositiveAlt, float kSensitivity); // 0x0000000187236320-0x0000000187236360
	
			// Methods
			public float GetValue(float delta); // 0x0000000188C29754-0x0000000188C29A24
		}
	
		[Serializable]
		public struct Trigger // TypeDefIndex: 89496
		{
			// Fields
			public bool UseFinger; // 0x00
			public bool UseMouse; // 0x01
			public KeyCode UseKey; // 0x04
	
			// Constructors
			public Trigger(bool uFinger, bool uMouse, KeyCode uKey); // 0x0000000187236760-0x0000000187236770
	
			// Methods
			public bool WentDown(Finger finger); // 0x0000000188C3117C-0x0000000188C3121C
			public bool IsDown(Finger finger); // 0x0000000188C310DC-0x0000000188C3117C
			public bool WentUp(Finger finger, bool useAnyFinger = false /* Metadata: 0x02649135 */); // 0x0000000188C3121C-0x0000000188C312DC
		}
	
		public abstract class Link // TypeDefIndex: 89497
		{
			// Fields
			public Finger Finger; // 0x10
	
			// Constructors
			protected Link(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public static T Find<T>(List<T> links, Finger finger)
				where T : Link, new();
			public static T Create<T>(ref List<T> links, Finger finger)
				where T : Link, new();
			public static void ClearAll<T>(List<T> links)
				where T : Link;
			public static void ClearAndRemove<T>(List<T> links, T link)
				where T : Link;
			public virtual void Clear(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public class Finger // TypeDefIndex: 89498
		{
			// Fields
			public int Index; // 0x10
			public float Pressure; // 0x14
			public bool Down; // 0x18
			public bool Up; // 0x19
			public float Age; // 0x1C
			public bool StartedOverGui; // 0x20
			public Vector2 StartScreenPosition; // 0x24
			public Vector2 ScreenPosition; // 0x2C
			public Vector2 ScreenPositionOld; // 0x34
			public Vector2 ScreenPositionOldOld; // 0x3C
			public Vector2 ScreenPositionOldOldOld; // 0x44
	
			// Properties
			public float SmoothScreenPositionDelta { get; } // 0x0000000188C31044-0x0000000188C31080 
	
			// Constructors
			public Finger(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public Vector2 GetSmoothScreenPosition(float t); // 0x0000000188C30F04-0x0000000188C31044
		}
	
		// Constructors
		public CwInputManager(); // 0x0000000188C2F8B0-0x0000000188C2F8D0
		static CwInputManager(); // 0x0000000188C2F6F8-0x0000000188C2F8B0
	
		// Methods
		public static List<Finger> GetFingers(bool ignoreStartedOverGui = false /* Metadata: 0x02649129 */, bool ignoreHover = false /* Metadata: 0x0264912A */); // 0x0000000188C2EA98-0x0000000188C2ECB0
		public static bool PointOverGui(Vector2 screenPosition, int guiLayers = 32 /* Metadata: 0x0264912B */); // 0x0000000188C2EDC4-0x0000000188C2EE38
		public static List<RaycastResult> RaycastGui(Vector2 screenPosition, int guiLayers = 32 /* Metadata: 0x0264912C */); // 0x0000000188C2EE38-0x0000000188C2F1D0
		public static Vector2 GetAveragePosition(List<Finger> fingers); // 0x0000000188C2E430-0x0000000188C2E5F0
		public static Vector2 GetAverageOldPosition(List<Finger> fingers); // 0x0000000188C2E270-0x0000000188C2E430
		public static Vector2 GetAveragePullScaled(List<Finger> fingers); // 0x0000000188C2E5F0-0x0000000188C2E7F0
		public static Vector2 GetAverageDeltaScaled(List<Finger> fingers); // 0x0000000188C2E070-0x0000000188C2E270
		public static float GetAverageTwistRadians(List<Finger> fingers); // 0x0000000188C2E7F0-0x0000000188C2E9D4
		public static void EnsureThisComponentExists(); // 0x0000000188C2DE1C-0x0000000188C2DF2C
		protected virtual void Update(); // 0x0000000188C2F1D0-0x0000000188C2F6F8
		private Finger FindFinger(int index); // 0x0000000188C2DF2C-0x0000000188C2E070
		private void AddFinger(int index, Vector2 screenPosition, float pressure, bool set); // 0x0000000188C2DBEC-0x0000000188C2DE1C
		private static Vector2 Hermite(Vector2 a, Vector2 b, Vector2 c, Vector2 d, float t); // 0x0000000188C2ECB0-0x0000000188C2EDC4
		private static float HermiteInterpolate(float y0, float y1, float y2, float y3, float mu, float mu2, float mu3); // 0x00000001872365F0-0x0000000187236710
		private static float GetRadians(Vector2 screenPosition, Vector2 referencePoint); // 0x00000001872365C0-0x00000001872365F0
		private static float GetDeltaRadians(Finger finger, Vector2 referencePoint, Vector2 lastReferencePoint); // 0x0000000188C2E9D4-0x0000000188C2EA98
	}

	[AddComponentMenu("Common/CW Render Texture Manager")]
	[DefaultExecutionOrder(1000)]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwRenderTextureManager")]
	public class CwRenderTextureManager : MonoBehaviour // TypeDefIndex: 89500
	{
		// Fields
		[SerializeField]
		private int lifetime; // 0x18
	
		// Properties
		public int Lifetime { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
	
		// Constructors
		public CwRenderTextureManager(); // 0x0000000188C30708-0x0000000188C30724
	
		// Methods
		public static RenderTexture GetTemporary(RenderTextureDescriptor desc, string title); // 0x0000000188C305EC-0x0000000188C3069C
		public static RenderTexture ReleaseTemporary(RenderTexture renderTexture); // 0x0000000188C3069C-0x0000000188C30708
	}

	[AddComponentMenu("Common/CW Root")]
	[DefaultExecutionOrder(-100)]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwRoot")]
	public class CwRoot : MonoBehaviour // TypeDefIndex: 89501
	{
		// Fields
		private static List<CwRoot> instances; // 0x00
	
		// Properties
		public static bool Exists { get; } // 0x0000000188C30A48-0x0000000188C30AA8 
		public static Transform Root { get; } // 0x0000000188C30AA8-0x0000000188C30B54 
	
		// Constructors
		public CwRoot(); // 0x00000001878364A0-0x00000001878364B8
		static CwRoot(); // 0x0000000188C309BC-0x0000000188C30A48
	
		// Methods
		public static Transform GetRoot(); // 0x0000000188C30724-0x0000000188C30830
		protected virtual void OnEnable(); // 0x0000000188C308A0-0x0000000188C309BC
		protected virtual void OnDisable(); // 0x0000000188C30830-0x0000000188C308A0
	}

	public class CwSeedAttribute : PropertyAttribute // TypeDefIndex: 89502
	{
		// Constructors
		public CwSeedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal static class CwShared // TypeDefIndex: 89503
	{
		// Fields
		public const string HelpUrlPrefix = "https://carloswilkes.com/Documentation/Common#"; // Metadata: 0x02649136
		public const string ComponentMenuPrefix = "Common/CW "; // Metadata: 0x02649165
		public const string GameObjectMenuPrefix = "GameObject/CW/Common/"; // Metadata: 0x02649170
	}

	public class CwGuide : ScriptableObject // TypeDefIndex: 89504
	{
		// Fields
		public string LongName; // 0x18
		public string ShortName; // 0x20
		public TextAsset Documentation; // 0x28
		[NonSerialized]
		private Texture2D icon; // 0x30
		[NonSerialized]
		private string version; // 0x38
	
		// Properties
		public Texture2D Icon { get; } // 0x0000000188C2B6C0-0x0000000188C2B7A4 
		public string Version { get; } // 0x0000000188C2B7A4-0x0000000188C2B8A0 
	
		// Constructors
		public CwGuide(); // 0x0000000185DD6260-0x0000000185DD6270
	}

	public static class CwHelper // TypeDefIndex: 89506
	{
		// Fields
		private static Stack<UnityEngine.Random.State> seedStates; // 0x00
		public static List<Material> tempMaterials; // 0x08
		public static List<MaterialPropertyBlock> tempProperties; // 0x10
		[CompilerGenerated]
		private static Action<Camera> OnCameraPreRender; // 0x18
		[CompilerGenerated]
		private static Action<Camera> OnCameraPostRender; // 0x20
		private static Stack<RenderTexture> actives; // 0x28
		private static int uniqueSeed; // 0x30
		private static List<Material> materials; // 0x38
	
		// Events
		public static event Action<Camera> OnCameraPreRender {
			add; // 0x0000000188C2D994-0x0000000188C2DA5C
			remove; // 0x0000000188C2DB24-0x0000000188C2DBEC
		}
		public static event Action<Camera> OnCameraPostRender {
			add; // 0x0000000188C2D8CC-0x0000000188C2D994
			remove; // 0x0000000188C2DA5C-0x0000000188C2DB24
		}
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 89505
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x0000000188C314CC-0x0000000188C31530
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _.cctor_b__11_0(Camera camera); // 0x0000000188C312DC-0x0000000188C31358
			internal void _.cctor_b__11_1(Camera camera); // 0x0000000188C31358-0x0000000188C313D4
			internal void _.cctor_b__11_2(ScriptableRenderContext context, Camera camera); // 0x0000000188C313D4-0x0000000188C31450
			internal void _.cctor_b__11_3(ScriptableRenderContext context, Camera camera); // 0x0000000188C31450-0x0000000188C314CC
		}
	
		// Constructors
		static CwHelper(); // 0x0000000188C2D3F8-0x0000000188C2D8CC
	
		// Methods
		public static T GetOrAddComponent<T>(GameObject gameObject, bool recordUndo = true /* Metadata: 0x02649186 */)
			where T : Component;
		public static T AddComponent<T>(GameObject gameObject, bool recordUndo = true /* Metadata: 0x02649187 */)
			where T : Component;
		public static bool IndexInMask(int index, int mask); // 0x0000000188C2C934-0x0000000188C2C944
		public static Camera GetCamera(Camera currentCamera, GameObject gameObject = null); // 0x0000000188C2C574-0x0000000188C2C638
		public static Vector3 GetObserverPosition(Transform observer); // 0x0000000188C2C638-0x0000000188C2C704
		public static bool Enabled(UnityEngine.Behaviour b); // 0x0000000188C2C41C-0x0000000188C2C480
		public static void BeginSeed(); // 0x0000000188C2BCF0-0x0000000188C2BD74
		public static void BeginSeed(int newSeed); // 0x0000000188C2BC58-0x0000000188C2BCF0
		public static void EndSeed(); // 0x0000000188C2C4F0-0x0000000188C2C574
		public static UnityEngine.Color Brighten(UnityEngine.Color color, float brightness, bool convertToGamma = true /* Metadata: 0x02649188 */); // 0x0000000188C2BD74-0x0000000188C2BE24
		public static UnityEngine.Color Premultiply(UnityEngine.Color color); // 0x0000000187236580-0x00000001872365C0
		public static float Saturate(float c); // 0x0000000188C2CE30-0x0000000188C2CE5C
		public static UnityEngine.Color Saturate(UnityEngine.Color c); // 0x0000000188C2CE5C-0x0000000188C2CEEC
		public static void Resize<T>(List<T> list, int size);
		public static float Sharpness(float a, float p); // 0x0000000188C2D268-0x0000000188C2D2B4
		public static UnityEngine.Color ToLinear(UnityEngine.Color gamma); // 0x0000000188C2D32C-0x0000000188C2D370
		public static float ToLinear(float gamma); // 0x0000000188C2D370-0x0000000188C2D3A4
		public static UnityEngine.Color ToGamma(UnityEngine.Color linear); // 0x0000000188C2D2E8-0x0000000188C2D32C
		public static float ToGamma(float linear); // 0x0000000188C2D2B4-0x0000000188C2D2E8
		public static float UniformScale(Vector3 scale); // 0x0000000188C2D3A4-0x0000000188C2D3F8
		public static void BeginActive(RenderTexture renderTexture); // 0x0000000188C2BBCC-0x0000000188C2BC58
		public static void EndActive(); // 0x0000000188C2C480-0x0000000188C2C4F0
		public static void SetTempMaterial(Material material); // 0x0000000188C2CEEC-0x0000000188C2CFB8
		public static void SetTempMaterial(Material material1, Material material2); // 0x0000000188C2CFB8-0x0000000188C2D0BC
		public static void SetTempMaterial(List<Material> materials); // 0x0000000188C2D0BC-0x0000000188C2D19C
		public static void SetTempMaterial(MaterialPropertyBlock properties); // 0x0000000188C2D19C-0x0000000188C2D268
		public static void AddMaterial(Renderer r, Material m); // 0x0000000188C2B978-0x0000000188C2BBCC
		public static void ReplaceMaterial(Renderer r, Material m); // 0x0000000188C2CBAC-0x0000000188C2CE30
		public static void RemoveMaterial(Renderer r, Material m); // 0x0000000188C2C9B8-0x0000000188C2CBAC
		public static Texture2D CreateTempTexture2D(string name, int width, int height, TextureFormat format = TextureFormat.ARGB32 /* Metadata: 0x02649189 */, bool mips = false /* Metadata: 0x0264918A */, bool linear = false /* Metadata: 0x0264918B */); // 0x0000000188C2C274-0x0000000188C2C334
		public static Material CreateTempMaterial(string materialName, string shaderName); // 0x0000000188C2C114-0x0000000188C2C1E8
		public static Material CreateTempMaterial(string materialName, Shader shader); // 0x0000000188C2C1E8-0x0000000188C2C274
		public static Material CreateTempMaterial(string materialName, Material source); // 0x0000000188C2C088-0x0000000188C2C114
		public static T Destroy<T>(T o)
			where T : UnityEngine.Object;
		public static GameObject CreateGameObject(string name, int layer, Transform parent = null, string recordUndo = null); // 0x0000000188C2BF7C-0x0000000188C2C088
		public static GameObject CreateGameObject(string name, int layer, Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale, string recordUndo = null); // 0x0000000188C2BE24-0x0000000188C2BF7C
		public static T CreateElement<T>(Transform parent)
			where T : Component;
		public static float Reciprocal(float v); // 0x0000000188C2C980-0x0000000188C2C99C
		public static double Reciprocal(double v); // 0x0000000188C2C99C-0x0000000188C2C9B8
		public static float Divide(float a, float b); // 0x0000000188C2C3F4-0x0000000188C2C408
		public static double Divide(double a, double b); // 0x0000000188C2C408-0x0000000188C2C41C
		public static float Acos(float v); // 0x0000000188C2B90C-0x0000000188C2B978
		public static double Acos(double v); // 0x0000000188C2B8A0-0x0000000188C2B90C
		public static float DampenFactor(float speed, float elapsed); // 0x0000000188C2C3AC-0x0000000188C2C3F4
		public static float DampenFactor(float damping, float deltaTime, float linear); // 0x0000000188C2C334-0x0000000188C2C3AC
		public static float Atan2(Vector2 xy); // 0x0000000187236560-0x0000000187236580
		public static int Mod(int a, int b); // 0x0000000188C2C944-0x0000000188C2C958
		public static float Mod(float a, float b); // 0x0000000188C2C958-0x0000000188C2C980
		public static Texture2D GetReadableCopy(Texture texture, TextureFormat format = TextureFormat.ARGB32 /* Metadata: 0x0264918C */, bool mipMaps = false /* Metadata: 0x0264918D */, int width = 0 /* Metadata: 0x0264918E */, int height = 0 /* Metadata: 0x0264918F */); // 0x0000000188C2C704-0x0000000188C2C934
	}

	public static class CwInput // TypeDefIndex: 89507
	{
		// Fields
		private static Dictionary<KeyCode, UnityEngine.InputSystem.Key> keyMapping; // 0x00
	
		// Constructors
		static CwInput(); // 0x0000000186A20B40-0x0000000186A21960
	
		// Methods
		[RuntimeInitializeOnLoadMethod]
		private static void Enable(); // 0x0000000187231540-0x0000000187231550
		private static ButtonControl GetMouseButtonControl(int index); // 0x0000000188C30054-0x0000000188C300EC
		private static ButtonControl GetButtonControl(KeyCode oldKey); // 0x0000000188C2FDF4-0x0000000188C2FF44
		public static int GetTouchCount(); // 0x0000000188C302D0-0x0000000188C3033C
		public static void GetTouch(int index, out int id, out Vector2 position, out float pressure, out bool set); // 0x0000000188C3033C-0x0000000188C30478
		public static Vector2 GetMousePosition(); // 0x0000000188C30154-0x0000000188C301B4
		public static bool GetKeyWentDown(KeyCode oldKey); // 0x0000000188C2FF98-0x0000000188C2FFEC
		public static bool GetKeyIsHeld(KeyCode oldKey); // 0x0000000188C2FF44-0x0000000188C2FF98
		public static bool GetKeyWentUp(KeyCode oldKey); // 0x0000000188C2FFEC-0x0000000188C30040
		public static bool GetMouseWentDown(int index); // 0x0000000188C301B4-0x0000000188C30208
		public static bool GetMouseIsHeld(int index); // 0x0000000188C30100-0x0000000188C30154
		public static bool GetMouseWentUp(int index); // 0x0000000188C30208-0x0000000188C3025C
		public static float GetMouseWheelDelta(); // 0x0000000188C3025C-0x0000000188C302D0
		public static bool GetMouseExists(); // 0x0000000188C300EC-0x0000000188C30100
		public static bool GetKeyboardExists(); // 0x0000000188C30040-0x0000000188C30054
	}

	public class CwShaderBundle : ScriptableObject // TypeDefIndex: 89510
	{
		// Fields
		[SerializeField]
		private string title; // 0x18
		[SerializeField]
		private Shader target; // 0x20
		[SerializeField]
		private int variantHash; // 0x28
		[SerializeField]
		private int projectHash; // 0x2C
		[SerializeField]
		private List<ShaderVariant> variants; // 0x30
	
		// Properties
		public string Title { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public Shader Target { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public int VariantHash { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		public int ProjectHash { get; set; } // 0x0000000182271A80-0x0000000182271A90 0x0000000182271AB0-0x0000000182271AC0
		public List<ShaderVariant> Variants { get; } // 0x0000000188C30E80-0x0000000188C30F04 
		public bool Dirty { get; } // 0x0000000188C30D64-0x0000000188C30E80 
	
		// Nested types
		public enum Pipeline // TypeDefIndex: 89508
		{
			Invalid = -1,
			Standard = 0,
			URP2019 = 1,
			URP2020 = 2,
			URP2021 = 3,
			HDRP2019 = 4,
			HDRP2020 = 5,
			HDRP2021 = 6,
			COUNT = 7
		}
	
		[Serializable]
		public class ShaderVariant // TypeDefIndex: 89509
		{
			// Fields
			public Pipeline Pipe; // 0x10
			public string Code; // 0x18
			public int Hash; // 0x20
			public bool Dirty; // 0x24
	
			// Properties
			public string HashString { get; } // 0x0000000188C31080-0x0000000188C310DC 
	
			// Constructors
			public ShaderVariant(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public CwShaderBundle(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		public static int GetProjectHash(); // 0x0000000188C30CC0-0x0000000188C30D08
		public static Pipeline DetectProjectPipeline(); // 0x0000000188C30C18-0x0000000188C30CC0
		public static bool IsStandard(Pipeline pipe); // 0x0000000188C30D48-0x0000000188C30D50
		public static bool IsScriptable(Pipeline pipe); // 0x0000000188C30D1C-0x0000000188C30D48
		public static bool IsURP(Pipeline pipe); // 0x0000000188C30D50-0x0000000188C30D64
		public static bool IsHDRP(Pipeline pipe); // 0x0000000188C30D08-0x0000000188C30D1C
	}
}
