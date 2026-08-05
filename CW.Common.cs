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

// Image 69: CW.Common.dll - Assembly: CW.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 62167-62200
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace CW.Common
{
	[AddComponentMenu("Common/CW Camera Look")]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwCameraLook")]
	public class CwCameraLook : MonoBehaviour // TypeDefIndex: 62168
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
		public bool Listen { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public float Damping { get; set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000184D86900-0x0000000184D86910
		public float Sensitivity { get; set; } // 0x00000001811EC8A0-0x00000001811EC8B0 0x00000001811EC9E0-0x00000001811EC9F0
		public CwInputManager.Axis PitchControls { get; set; } // 0x0000000184D89490-0x0000000184D894B0 0x0000000184D894F0-0x0000000184D89510
		public CwInputManager.Axis YawControls { get; set; } // 0x0000000184D894D0-0x0000000184D894F0 0x0000000184D89530-0x0000000184D89550
		public CwInputManager.Axis RollControls { get; set; } // 0x0000000184D894B0-0x0000000184D894D0 0x0000000184D89510-0x0000000184D89530
	
		// Constructors
		public CwCameraLook(); // 0x000000018690AFE8-0x000000018690B0CC
	
		// Methods
		protected virtual void Start(); // 0x000000018690AF80-0x000000018690AFC0
		protected virtual void OnDisable(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void Update(); // 0x000000018690AFC0-0x000000018690AFE8
		protected virtual void OnApplicationFocus(bool focus); // 0x00000001841E1670-0x00000001841E1680
		private void AddToDelta(); // 0x000000018690ABFC-0x000000018690AE08
		private void DampenDelta(); // 0x000000018690AE08-0x000000018690AF80
	}

	[AddComponentMenu("Common/CW Camera Move")]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwCameraMove")]
	public class CwCameraMove : MonoBehaviour // TypeDefIndex: 62169
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
		public bool Listen { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public float Damping { get; set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000184D86900-0x0000000184D86910
		public float Sensitivity { get; set; } // 0x00000001811EC8A0-0x00000001811EC8B0 0x00000001811EC9E0-0x00000001811EC9F0
		public CwInputManager.Axis HorizontalControls { get; set; } // 0x0000000184D89490-0x0000000184D894B0 0x0000000184D894F0-0x0000000184D89510
		public CwInputManager.Axis DepthControls { get; set; } // 0x0000000184D894D0-0x0000000184D894F0 0x0000000184D89530-0x0000000184D89550
		public CwInputManager.Axis VerticalControls { get; set; } // 0x0000000184D894B0-0x0000000184D894D0 0x0000000184D89510-0x0000000184D89530
	
		// Constructors
		public CwCameraMove(); // 0x000000018690B4E8-0x000000018690B5C4
	
		// Methods
		protected virtual void Start(); // 0x000000018690B480-0x000000018690B4C0
		protected virtual void Update(); // 0x000000018690B4C0-0x000000018690B4E8
		private void AddToDelta(); // 0x000000018690B0CC-0x000000018690B2F0
		private void DampenDelta(); // 0x000000018690B2F0-0x000000018690B480
	}

	[AddComponentMenu("Common/CW Camera Pivot")]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwCameraPivot")]
	public class CwCameraPivot : MonoBehaviour // TypeDefIndex: 62170
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
		public bool Listen { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public float Damping { get; set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000184D86900-0x0000000184D86910
		public CwInputManager.Axis PitchControls { get; set; } // 0x0000000184D89550-0x0000000184D89570 0x0000000184D89590-0x0000000184D895B0
		public CwInputManager.Axis YawControls { get; set; } // 0x0000000184D89570-0x0000000184D89590 0x0000000184D895B0-0x0000000184D895D0
	
		// Constructors
		public CwCameraPivot(); // 0x000000018690B86C-0x000000018690B8F4
	
		// Methods
		protected virtual void OnEnable(); // 0x000000018690B804-0x000000018690B844
		protected virtual void Update(); // 0x000000018690B844-0x000000018690B86C
		private void AddToDelta(); // 0x000000018690B5C4-0x000000018690B628
		private void DampenDelta(); // 0x000000018690B628-0x000000018690B804
	}

	[AddComponentMenu("")]
	[ExecuteInEditMode]
	public class CwDemo : MonoBehaviour // TypeDefIndex: 62171
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
		public bool UpgradeInputModule { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
		public bool ChangeExposureInHDRP { get; set; } // 0x0000000184D866A0-0x0000000184D866B0 0x0000000184D866C0-0x0000000184D866D0
		public bool ChangeVisualEnvironmentInHDRP { get; set; } // 0x00000001815AF940-0x00000001815AF950 0x0000000184D866E0-0x0000000184D866F0
		public bool ChangeFogInHDRP { get; set; } // 0x0000000184D895D0-0x0000000184D895E0 0x0000000184D89600-0x0000000184D89610
		public bool ChangeCloudsInHDRP { get; set; } // 0x0000000184D86150-0x0000000184D86160 0x0000000184D86160-0x0000000184D86170
		public bool ChangeMotionBlurInHDRP { get; set; } // 0x0000000184D88310-0x0000000184D88320 0x0000000184D89610-0x0000000184D89620
		public bool UpgradeLightsInHDRP { get; set; } // 0x0000000184D895F0-0x0000000184D89600 0x0000000184D89630-0x0000000184D89640
		public bool UpgradeCamerasInHDRP { get; set; } // 0x0000000184D895E0-0x0000000184D895F0 0x0000000184D89620-0x0000000184D89630
	
		// Constructors
		public CwDemo(); // 0x000000018690C4A8-0x000000018690C4CC
	
		// Methods
		protected virtual void OnEnable(); // 0x000000018690C498-0x000000018690C4A8
		protected virtual void TryApplyURP(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void TryApplyHDRP(); // 0x0000000184D83230-0x0000000184D83240
		private void TryCreateVolume(); // 0x00000001841E1670-0x00000001841E1680
		private void TryUpgradeLights(); // 0x00000001841E1670-0x00000001841E1680
		private void TryUpgradeCameras(); // 0x00000001841E1670-0x00000001841E1680
		private void TryUpgradeEventSystem(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AddComponentMenu("Common/CW Demo Button")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwDemoButton")]
	public class CwDemoButton : MonoBehaviour, IPointerDownHandler // TypeDefIndex: 62174
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
		public LinkType Link { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public string UrlTarget { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public Transform IsolateTarget { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public ToggleType IsolateToggle { get; set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
	
		// Nested types
		public enum LinkType // TypeDefIndex: 62172
		{
			PreviousScene = 0,
			NextScene = 1,
			Publisher = 2,
			URL = 3,
			Isolate = 4
		}
	
		public enum ToggleType // TypeDefIndex: 62173
		{
			KeepSelected = 0,
			ToggleSelection = 1,
			SelectPrevious = 2
		}
	
		// Constructors
		public CwDemoButton(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected virtual void OnEnable(); // 0x000000018690BDC8-0x000000018690BE10
		protected virtual void Update(); // 0x000000018690C350-0x000000018690C498
		public void OnPointerDown(PointerEventData eventData); // 0x000000018690BE10-0x000000018690C350
		private static int GetCurrentLevel(); // 0x000000018690BCCC-0x000000018690BD40
		private static int GetLevelCount(); // 0x000000018690BD40-0x000000018690BD80
		private static void LoadLevel(int index); // 0x000000018690BD80-0x000000018690BDC8
	}

	[AddComponentMenu("Common/CW Demo Button Builder")]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwDemoButtonBuilder")]
	public class CwDemoButtonBuilder : MonoBehaviour // TypeDefIndex: 62175
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
		public GameObject ButtonPrefab { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public RectTransform ButtonRoot { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public Sprite Icon { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public UnityEngine.Color Color { get; set; } // 0x0000000184D87480-0x0000000184D87490 0x0000000184D87490-0x0000000184D874A0
		public string OverrideName { get; set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
	
		// Constructors
		public CwDemoButtonBuilder(); // 0x000000018690BC94-0x000000018690BCCC
	
		// Methods
		[ContextMenu("Build")]
		public void Build(); // 0x000000018690BA08-0x000000018690BC2C
		[ContextMenu("Build All")]
		public void BuildAll(); // 0x000000018690B970-0x000000018690BA08
		private GameObject DoInstantiate(); // 0x000000018690BC2C-0x000000018690BC94
	}

	[AddComponentMenu("Common/CW Light Intensity")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwLightIntensity")]
	[RequireComponent(typeof(Light))]
	public class CwLightIntensity : MonoBehaviour // TypeDefIndex: 62176
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
		public float Multiplier { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x0000000184D86390-0x0000000184D863A0
		public float IntensityInStandard { get; set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000184D86900-0x0000000184D86910
		public float IntensityInURP { get; set; } // 0x00000001811EC8A0-0x00000001811EC8B0 0x00000001811EC9E0-0x00000001811EC9F0
		public float IntensityInHDRP { get; set; } // 0x0000000184D89850-0x0000000184D89860 0x0000000184D89860-0x0000000184D89870
		public Light CachedLight { get; } // 0x0000000186911748-0x00000001869117A0 
	
		// Constructors
		public CwLightIntensity(); // 0x0000000186911714-0x0000000186911748
	
		// Methods
		protected virtual void Update(); // 0x00000001869116B4-0x0000000186911714
		private void ApplyIntensity(float intensity); // 0x000000018691162C-0x00000001869116B4
	}

	[AddComponentMenu("Common/CW Rotate")]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwRotate")]
	public class CwRotate : MonoBehaviour // TypeDefIndex: 62177
	{
		// Fields
		[SerializeField]
		private Vector3 angularVelocity; // 0x18
		[SerializeField]
		private UnityEngine.Space relativeTo; // 0x24
	
		// Properties
		public Vector3 AngularVelocity { get; set; } // 0x0000000184D89870-0x0000000184D89890 0x0000000184D89890-0x0000000184D898A0
		public UnityEngine.Space RelativeTo { get; set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
	
		// Constructors
		public CwRotate(); // 0x0000000186911D98-0x0000000186911DC8
	
		// Methods
		protected virtual void Update(); // 0x0000000186911D04-0x0000000186911D98
	}

	public abstract class CwChild : MonoBehaviour // TypeDefIndex: 62179
	{
		// Nested types
		public interface IHasChildren // TypeDefIndex: 62178
		{
			// Methods
			bool HasChild(CwChild child);
		}
	
		// Constructors
		protected CwChild(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void DestroyGameObjectIfInvalid(); // 0x000000018690B8F4-0x000000018690B970
		protected abstract IHasChildren GetParent();
		protected virtual void Start(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AddComponentMenu("Common/CW Depth Texture Mode")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwDepthTextureMode")]
	[RequireComponent(typeof(Camera))]
	public class CwDepthTextureMode : MonoBehaviour // TypeDefIndex: 62180
	{
		// Fields
		[SerializeField]
		private DepthTextureMode depthMode; // 0x18
		[NonSerialized]
		private Camera cachedCamera; // 0x20
	
		// Properties
		public DepthTextureMode DepthMode { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x000000018690C56C-0x000000018690C578
	
		// Constructors
		public CwDepthTextureMode(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void UpdateDepthMode(); // 0x000000018690C4CC-0x000000018690C564
		protected virtual void Update(); // 0x000000018690C564-0x000000018690C56C
	}

	[AddComponentMenu("Common/CW Follow")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwFollow")]
	public class CwFollow : MonoBehaviour // TypeDefIndex: 62183
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
		public FollowType Follow { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public Transform Target { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public float Damping { get; set; } // 0x0000000184D86BF0-0x0000000184D86C00 0x0000000184D86C00-0x0000000184D86C10
		public bool Rotate { get; set; } // 0x0000000184D869F0-0x0000000184D86A00 0x0000000184D86A00-0x0000000184D86A10
		public bool IgnoreZ { get; set; } // 0x0000000184D86CB0-0x0000000184D86CC0 0x0000000184D86CE0-0x0000000184D86CF0
		public UpdateType FollowIn { get; set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
		public Vector3 LocalPosition { get; set; } // 0x0000000184D89640-0x0000000184D89660 0x0000000184D89680-0x0000000184D89690
		public Vector3 LocalRotation { get; set; } // 0x0000000184D89660-0x0000000184D89680 0x0000000184D89690-0x0000000184D896A0
	
		// Nested types
		public enum FollowType // TypeDefIndex: 62181
		{
			TargetTransform = 0,
			MainCamera = 1
		}
	
		public enum UpdateType // TypeDefIndex: 62182
		{
			Update = 0,
			LateUpdate = 1
		}
	
		// Constructors
		public CwFollow(); // 0x000000018690C858-0x000000018690C880
	
		// Methods
		[ContextMenu("UpdatePosition")]
		public void UpdatePosition(); // 0x000000018690C588-0x000000018690C848
		protected virtual void Update(); // 0x000000018690C848-0x000000018690C858
		protected virtual void LateUpdate(); // 0x000000018690C578-0x000000018690C588
	}

	[AddComponentMenu("Common/CW Input Manager")]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwInputManager")]
	public class CwInputManager : MonoBehaviour // TypeDefIndex: 62189
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
		public const int MOUSE_FINGER_INDEX = -1; // Metadata: 0x02350734
		public const int HOVER_FINGER_INDEX = -1337; // Metadata: 0x02350735
		private static List<RaycastResult> tempRaycastResults; // 0x18
		private static PointerEventData tempPointerEventData; // 0x20
		private static EventSystem tempEventSystem; // 0x28
		private static List<Finger> fingers; // 0x30
		private static List<Finger> filteredFingers; // 0x38
		private static Stack<Finger> pool; // 0x40
	
		// Properties
		public LayerMask GuiLayers { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public static List<Finger> Fingers { get; } // 0x0000000186910CDC-0x0000000186910D2C 
		public static float ScaleFactor { get; } // 0x0000000186910D2C-0x0000000186910D58 
	
		// Events
		public static event Action<Finger> OnFingerDown {
			add; // 0x0000000186910A88-0x0000000186910B4C
			remove; // 0x0000000186910D58-0x0000000186910E1C
		}
		public static event Action<Finger> OnFingerUpdate {
			add; // 0x0000000186910C14-0x0000000186910CDC
			remove; // 0x0000000186910EE4-0x0000000186910FAC
		}
		public static event Action<Finger> OnFingerUp {
			add; // 0x0000000186910B4C-0x0000000186910C14
			remove; // 0x0000000186910E1C-0x0000000186910EE4
		}
	
		// Nested types
		public enum AxisGesture // TypeDefIndex: 62184
		{
			HorizontalDrag = 0,
			VerticalDrag = 1,
			Twist = 2,
			HorizontalPull = 3,
			VerticalPull = 4
		}
	
		[Serializable]
		public struct Axis // TypeDefIndex: 62185
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
			public Axis(int fCount, bool fInvert, AxisGesture fGesture, float fSensitivty, KeyCode kNegative, KeyCode kPositive, KeyCode kNegativeAlt, KeyCode kPositiveAlt, float kSensitivity); // 0x0000000184D89450-0x0000000184D89490
	
			// Methods
			public float GetValue(float delta); // 0x000000018690A92C-0x000000018690ABFC
		}
	
		[Serializable]
		public struct Trigger // TypeDefIndex: 62186
		{
			// Fields
			public bool UseFinger; // 0x00
			public bool UseMouse; // 0x01
			public KeyCode UseKey; // 0x04
	
			// Constructors
			public Trigger(bool uFinger, bool uMouse, KeyCode uKey); // 0x0000000184D898A0-0x0000000184D898B0
	
			// Methods
			public bool WentDown(Finger finger); // 0x000000018691231C-0x00000001869123BC
			public bool IsDown(Finger finger); // 0x000000018691227C-0x000000018691231C
			public bool WentUp(Finger finger, bool useAnyFinger = false /* Metadata: 0x0235073C */); // 0x00000001869123BC-0x000000018691247C
		}
	
		public abstract class Link // TypeDefIndex: 62187
		{
			// Fields
			public Finger Finger; // 0x10
	
			// Constructors
			protected Link(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public static T Find<T>(List<T> links, Finger finger)
				where T : Link, new();
			public static T Create<T>(ref List<T> links, Finger finger)
				where T : Link, new();
			public static void ClearAll<T>(List<T> links)
				where T : Link;
			public static void ClearAndRemove<T>(List<T> links, T link)
				where T : Link;
			public virtual void Clear(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public class Finger // TypeDefIndex: 62188
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
			public float SmoothScreenPositionDelta { get; } // 0x00000001869121E0-0x0000000186912220 
	
			// Constructors
			public Finger(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public Vector2 GetSmoothScreenPosition(float t); // 0x00000001869120A4-0x00000001869121E0
		}
	
		// Constructors
		public CwInputManager(); // 0x0000000186910A68-0x0000000186910A88
		static CwInputManager(); // 0x00000001869108B0-0x0000000186910A68
	
		// Methods
		public static List<Finger> GetFingers(bool ignoreStartedOverGui = false /* Metadata: 0x02350730 */, bool ignoreHover = false /* Metadata: 0x02350731 */); // 0x000000018690FC48-0x000000018690FE5C
		public static bool PointOverGui(Vector2 screenPosition, int guiLayers = 32 /* Metadata: 0x02350732 */); // 0x000000018690FF6C-0x000000018690FFE0
		public static List<RaycastResult> RaycastGui(Vector2 screenPosition, int guiLayers = 32 /* Metadata: 0x02350733 */); // 0x000000018690FFE0-0x0000000186910378
		public static Vector2 GetAveragePosition(List<Finger> fingers); // 0x000000018690F5C8-0x000000018690F784
		public static Vector2 GetAverageOldPosition(List<Finger> fingers); // 0x000000018690F40C-0x000000018690F5C8
		public static Vector2 GetAveragePullScaled(List<Finger> fingers); // 0x000000018690F784-0x000000018690F97C
		public static Vector2 GetAverageDeltaScaled(List<Finger> fingers); // 0x000000018690F214-0x000000018690F40C
		public static float GetAverageTwistRadians(List<Finger> fingers); // 0x000000018690F97C-0x000000018690FB60
		public static void EnsureThisComponentExists(); // 0x000000018690EFC4-0x000000018690F0D4
		protected virtual void Update(); // 0x0000000186910378-0x00000001869108B0
		private Finger FindFinger(int index); // 0x000000018690F0D4-0x000000018690F214
		private void AddFinger(int index, Vector2 screenPosition, float pressure, bool set); // 0x000000018690EDA0-0x000000018690EFC4
		private static Vector2 Hermite(Vector2 a, Vector2 b, Vector2 c, Vector2 d, float t); // 0x000000018690FE5C-0x000000018690FF6C
		private static float HermiteInterpolate(float y0, float y1, float y2, float y3, float mu, float mu2, float mu3); // 0x0000000184D89730-0x0000000184D89850
		private static float GetRadians(Vector2 screenPosition, Vector2 referencePoint); // 0x0000000184D89700-0x0000000184D89730
		private static float GetDeltaRadians(Finger finger, Vector2 referencePoint, Vector2 lastReferencePoint); // 0x000000018690FB60-0x000000018690FC48
	}

	[AddComponentMenu("Common/CW Render Texture Manager")]
	[DefaultExecutionOrder(1000)]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwRenderTextureManager")]
	public class CwRenderTextureManager : MonoBehaviour // TypeDefIndex: 62190
	{
		// Fields
		[SerializeField]
		private int lifetime; // 0x18
	
		// Properties
		public int Lifetime { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
	
		// Constructors
		public CwRenderTextureManager(); // 0x00000001869118BC-0x00000001869118D8
	
		// Methods
		public static RenderTexture GetTemporary(RenderTextureDescriptor desc, string title); // 0x00000001869117A0-0x0000000186911850
		public static RenderTexture ReleaseTemporary(RenderTexture renderTexture); // 0x0000000186911850-0x00000001869118BC
	}

	[AddComponentMenu("Common/CW Root")]
	[DefaultExecutionOrder(-100)]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwRoot")]
	public class CwRoot : MonoBehaviour // TypeDefIndex: 62191
	{
		// Fields
		private static List<CwRoot> instances; // 0x00
	
		// Properties
		public static bool Exists { get; } // 0x0000000186911BF8-0x0000000186911C58 
		public static Transform Root { get; } // 0x0000000186911C58-0x0000000186911D04 
	
		// Constructors
		public CwRoot(); // 0x0000000185393520-0x0000000185393538
		static CwRoot(); // 0x0000000186911B6C-0x0000000186911BF8
	
		// Methods
		public static Transform GetRoot(); // 0x00000001869118D8-0x00000001869119E0
		protected virtual void OnEnable(); // 0x0000000186911A50-0x0000000186911B6C
		protected virtual void OnDisable(); // 0x00000001869119E0-0x0000000186911A50
	}

	public class CwSeedAttribute : PropertyAttribute // TypeDefIndex: 62192
	{
		// Constructors
		public CwSeedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal static class CwShared // TypeDefIndex: 62193
	{
		// Fields
		public const string HelpUrlPrefix = "https://carloswilkes.com/Documentation/Common#"; // Metadata: 0x0235073D
		public const string ComponentMenuPrefix = "Common/CW "; // Metadata: 0x0235076C
		public const string GameObjectMenuPrefix = "GameObject/CW/Common/"; // Metadata: 0x02350777
	}

	public class CwGuide : ScriptableObject // TypeDefIndex: 62194
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
		public Texture2D Icon { get; } // 0x000000018690C880-0x000000018690C964 
		public string Version { get; } // 0x000000018690C964-0x000000018690CA60 
	
		// Constructors
		public CwGuide(); // 0x0000000183573370-0x0000000183573380
	}

	public static class CwHelper // TypeDefIndex: 62196
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
			add; // 0x000000018690EB48-0x000000018690EC10
			remove; // 0x000000018690ECD8-0x000000018690EDA0
		}
		public static event Action<Camera> OnCameraPostRender {
			add; // 0x000000018690EA80-0x000000018690EB48
			remove; // 0x000000018690EC10-0x000000018690ECD8
		}
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62195
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x000000018691266C-0x00000001869126D0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _.cctor_b__11_0(Camera camera); // 0x000000018691247C-0x00000001869124F8
			internal void _.cctor_b__11_1(Camera camera); // 0x00000001869124F8-0x0000000186912574
			internal void _.cctor_b__11_2(ScriptableRenderContext context, Camera camera); // 0x0000000186912574-0x00000001869125F0
			internal void _.cctor_b__11_3(ScriptableRenderContext context, Camera camera); // 0x00000001869125F0-0x000000018691266C
		}
	
		// Constructors
		static CwHelper(); // 0x000000018690E5AC-0x000000018690EA80
	
		// Methods
		public static T GetOrAddComponent<T>(GameObject gameObject, bool recordUndo = true /* Metadata: 0x0235078D */)
			where T : Component;
		public static T AddComponent<T>(GameObject gameObject, bool recordUndo = true /* Metadata: 0x0235078E */)
			where T : Component;
		public static bool IndexInMask(int index, int mask); // 0x000000018690DAE4-0x000000018690DAF4
		public static Camera GetCamera(Camera currentCamera, GameObject gameObject = null); // 0x000000018690D728-0x000000018690D7EC
		public static Vector3 GetObserverPosition(Transform observer); // 0x000000018690D7EC-0x000000018690D8B8
		public static bool Enabled(UnityEngine.Behaviour b); // 0x000000018690D5D0-0x000000018690D634
		public static void BeginSeed(); // 0x000000018690CEAC-0x000000018690CF30
		public static void BeginSeed(int newSeed); // 0x000000018690CE14-0x000000018690CEAC
		public static void EndSeed(); // 0x000000018690D6A4-0x000000018690D728
		public static UnityEngine.Color Brighten(UnityEngine.Color color, float brightness, bool convertToGamma = true /* Metadata: 0x0235078F */); // 0x000000018690CF30-0x000000018690CFE0
		public static UnityEngine.Color Premultiply(UnityEngine.Color color); // 0x0000000184D896C0-0x0000000184D89700
		public static float Saturate(float c); // 0x000000018690DFE4-0x000000018690E010
		public static UnityEngine.Color Saturate(UnityEngine.Color c); // 0x000000018690E010-0x000000018690E0A0
		public static void Resize<T>(List<T> list, int size);
		public static float Sharpness(float a, float p); // 0x000000018690E41C-0x000000018690E468
		public static UnityEngine.Color ToLinear(UnityEngine.Color gamma); // 0x000000018690E4E0-0x000000018690E524
		public static float ToLinear(float gamma); // 0x000000018690E524-0x000000018690E558
		public static UnityEngine.Color ToGamma(UnityEngine.Color linear); // 0x000000018690E49C-0x000000018690E4E0
		public static float ToGamma(float linear); // 0x000000018690E468-0x000000018690E49C
		public static float UniformScale(Vector3 scale); // 0x000000018690E558-0x000000018690E5AC
		public static void BeginActive(RenderTexture renderTexture); // 0x000000018690CD88-0x000000018690CE14
		public static void EndActive(); // 0x000000018690D634-0x000000018690D6A4
		public static void SetTempMaterial(Material material); // 0x000000018690E0A0-0x000000018690E16C
		public static void SetTempMaterial(Material material1, Material material2); // 0x000000018690E16C-0x000000018690E270
		public static void SetTempMaterial(List<Material> materials); // 0x000000018690E270-0x000000018690E350
		public static void SetTempMaterial(MaterialPropertyBlock properties); // 0x000000018690E350-0x000000018690E41C
		public static void AddMaterial(Renderer r, Material m); // 0x000000018690CB38-0x000000018690CD88
		public static void ReplaceMaterial(Renderer r, Material m); // 0x000000018690DD60-0x000000018690DFE4
		public static void RemoveMaterial(Renderer r, Material m); // 0x000000018690DB68-0x000000018690DD60
		public static Texture2D CreateTempTexture2D(string name, int width, int height, TextureFormat format = TextureFormat.ARGB32 /* Metadata: 0x02350790 */, bool mips = false /* Metadata: 0x02350791 */, bool linear = false /* Metadata: 0x02350792 */); // 0x000000018690D42C-0x000000018690D4E8
		public static Material CreateTempMaterial(string materialName, string shaderName); // 0x000000018690D2CC-0x000000018690D3A0
		public static Material CreateTempMaterial(string materialName, Shader shader); // 0x000000018690D3A0-0x000000018690D42C
		public static Material CreateTempMaterial(string materialName, Material source); // 0x000000018690D240-0x000000018690D2CC
		public static T Destroy<T>(T o)
			where T : UnityEngine.Object;
		public static GameObject CreateGameObject(string name, int layer, Transform parent = null, string recordUndo = null); // 0x000000018690D138-0x000000018690D240
		public static GameObject CreateGameObject(string name, int layer, Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale, string recordUndo = null); // 0x000000018690CFE0-0x000000018690D138
		public static T CreateElement<T>(Transform parent)
			where T : Component;
		public static float Reciprocal(float v); // 0x000000018690DB30-0x000000018690DB4C
		public static double Reciprocal(double v); // 0x000000018690DB4C-0x000000018690DB68
		public static float Divide(float a, float b); // 0x000000018690D5A8-0x000000018690D5BC
		public static double Divide(double a, double b); // 0x000000018690D5BC-0x000000018690D5D0
		public static float Acos(float v); // 0x000000018690CACC-0x000000018690CB38
		public static double Acos(double v); // 0x000000018690CA60-0x000000018690CACC
		public static float DampenFactor(float speed, float elapsed); // 0x000000018690D560-0x000000018690D5A8
		public static float DampenFactor(float damping, float deltaTime, float linear); // 0x000000018690D4E8-0x000000018690D560
		public static float Atan2(Vector2 xy); // 0x0000000184D896A0-0x0000000184D896C0
		public static int Mod(int a, int b); // 0x000000018690DAF4-0x000000018690DB08
		public static float Mod(float a, float b); // 0x000000018690DB08-0x000000018690DB30
		public static Texture2D GetReadableCopy(Texture texture, TextureFormat format = TextureFormat.ARGB32 /* Metadata: 0x02350793 */, bool mipMaps = false /* Metadata: 0x02350794 */, int width = 0 /* Metadata: 0x02350795 */, int height = 0 /* Metadata: 0x02350796 */); // 0x000000018690D8B8-0x000000018690DAE4
	}

	public static class CwInput // TypeDefIndex: 62197
	{
		// Fields
		private static Dictionary<KeyCode, UnityEngine.InputSystem.Key> keyMapping; // 0x00
	
		// Constructors
		static CwInput(); // 0x0000000184548E40-0x0000000184549C60
	
		// Methods
		[RuntimeInitializeOnLoadMethod]
		private static void Enable(); // 0x0000000183DFA4A0-0x0000000183DFA4B0
		private static ButtonControl GetMouseButtonControl(int index); // 0x0000000186911208-0x00000001869112A0
		private static ButtonControl GetButtonControl(KeyCode oldKey); // 0x0000000186910FAC-0x00000001869110F8
		public static int GetTouchCount(); // 0x0000000186911484-0x00000001869114F0
		public static void GetTouch(int index, out int id, out Vector2 position, out float pressure, out bool set); // 0x00000001869114F0-0x000000018691162C
		public static Vector2 GetMousePosition(); // 0x0000000186911308-0x0000000186911368
		public static bool GetKeyWentDown(KeyCode oldKey); // 0x000000018691114C-0x00000001869111A0
		public static bool GetKeyIsHeld(KeyCode oldKey); // 0x00000001869110F8-0x000000018691114C
		public static bool GetKeyWentUp(KeyCode oldKey); // 0x00000001869111A0-0x00000001869111F4
		public static bool GetMouseWentDown(int index); // 0x0000000186911368-0x00000001869113BC
		public static bool GetMouseIsHeld(int index); // 0x00000001869112B4-0x0000000186911308
		public static bool GetMouseWentUp(int index); // 0x00000001869113BC-0x0000000186911410
		public static float GetMouseWheelDelta(); // 0x0000000186911410-0x0000000186911484
		public static bool GetMouseExists(); // 0x00000001869112A0-0x00000001869112B4
		public static bool GetKeyboardExists(); // 0x00000001869111F4-0x0000000186911208
	}

	public class CwShaderBundle : ScriptableObject // TypeDefIndex: 62200
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
		public string Title { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public Shader Target { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public int VariantHash { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
		public int ProjectHash { get; set; } // 0x0000000184D86710-0x0000000184D86720 0x0000000184D86720-0x0000000184D86730
		public List<ShaderVariant> Variants { get; } // 0x0000000186912020-0x00000001869120A4 
		public bool Dirty { get; } // 0x0000000186911F14-0x0000000186912020 
	
		// Nested types
		public enum Pipeline // TypeDefIndex: 62198
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
		public class ShaderVariant // TypeDefIndex: 62199
		{
			// Fields
			public Pipeline Pipe; // 0x10
			public string Code; // 0x18
			public int Hash; // 0x20
			public bool Dirty; // 0x24
	
			// Properties
			public string HashString { get; } // 0x0000000186912220-0x000000018691227C 
	
			// Constructors
			public ShaderVariant(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public CwShaderBundle(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		public static int GetProjectHash(); // 0x0000000186911E70-0x0000000186911EB8
		public static Pipeline DetectProjectPipeline(); // 0x0000000186911DC8-0x0000000186911E70
		public static bool IsStandard(Pipeline pipe); // 0x0000000186911EF8-0x0000000186911F00
		public static bool IsScriptable(Pipeline pipe); // 0x0000000186911ECC-0x0000000186911EF8
		public static bool IsURP(Pipeline pipe); // 0x0000000186911F00-0x0000000186911F14
		public static bool IsHDRP(Pipeline pipe); // 0x0000000186911EB8-0x0000000186911ECC
	}
}
