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

// Image 65: CW.Common.dll - Assembly: CW.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58245-58278
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace CW.Common
{
	[AddComponentMenu("Common/CW Camera Look")]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwCameraLook")]
	public class CwCameraLook : MonoBehaviour // TypeDefIndex: 58246
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
		public bool Listen { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public float Damping { get => default; set {} } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000183D4F120-0x0000000183D4F130
		public float Sensitivity { get => default; set {} } // 0x0000000183D4F2E0-0x0000000183D4F2F0 0x0000000183D4F2F0-0x0000000183D4F300
		public CwInputManager.Axis PitchControls { get => default; set {} } // 0x0000000183D52130-0x0000000183D52150 0x0000000183D52190-0x0000000183D521B0
		public CwInputManager.Axis YawControls { get => default; set {} } // 0x0000000183D52170-0x0000000183D52190 0x0000000183D521D0-0x0000000183D521F0
		public CwInputManager.Axis RollControls { get => default; set {} } // 0x0000000183D52150-0x0000000183D52170 0x0000000183D521B0-0x0000000183D521D0
	
		// Constructors
		public CwCameraLook() {} // 0x00000001856EE3F4-0x00000001856EE4D8
	
		// Methods
		protected virtual void Start() {} // 0x00000001856EE38C-0x00000001856EE3CC
		protected virtual void OnDisable() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void Update() {} // 0x00000001856EE3CC-0x00000001856EE3F4
		protected virtual void OnApplicationFocus(bool focus) {} // 0x000000018350B670-0x000000018350B680
		private void AddToDelta() {} // 0x00000001856EE008-0x00000001856EE214
		private void DampenDelta() {} // 0x00000001856EE214-0x00000001856EE38C
	}

	[AddComponentMenu("Common/CW Camera Move")]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwCameraMove")]
	public class CwCameraMove : MonoBehaviour // TypeDefIndex: 58247
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
		public bool Listen { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public float Damping { get => default; set {} } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000183D4F120-0x0000000183D4F130
		public float Sensitivity { get => default; set {} } // 0x0000000183D4F2E0-0x0000000183D4F2F0 0x0000000183D4F2F0-0x0000000183D4F300
		public CwInputManager.Axis HorizontalControls { get => default; set {} } // 0x0000000183D52130-0x0000000183D52150 0x0000000183D52190-0x0000000183D521B0
		public CwInputManager.Axis DepthControls { get => default; set {} } // 0x0000000183D52170-0x0000000183D52190 0x0000000183D521D0-0x0000000183D521F0
		public CwInputManager.Axis VerticalControls { get => default; set {} } // 0x0000000183D52150-0x0000000183D52170 0x0000000183D521B0-0x0000000183D521D0
	
		// Constructors
		public CwCameraMove() {} // 0x00000001856EE8F4-0x00000001856EE9D0
	
		// Methods
		protected virtual void Start() {} // 0x00000001856EE88C-0x00000001856EE8CC
		protected virtual void Update() {} // 0x00000001856EE8CC-0x00000001856EE8F4
		private void AddToDelta() {} // 0x00000001856EE4D8-0x00000001856EE6FC
		private void DampenDelta() {} // 0x00000001856EE6FC-0x00000001856EE88C
	}

	[AddComponentMenu("Common/CW Camera Pivot")]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwCameraPivot")]
	public class CwCameraPivot : MonoBehaviour // TypeDefIndex: 58248
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
		public bool Listen { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public float Damping { get => default; set {} } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000183D4F120-0x0000000183D4F130
		public CwInputManager.Axis PitchControls { get => default; set {} } // 0x0000000183D521F0-0x0000000183D52210 0x0000000183D52230-0x0000000183D52250
		public CwInputManager.Axis YawControls { get => default; set {} } // 0x0000000183D52210-0x0000000183D52230 0x0000000183D52250-0x0000000183D52270
	
		// Constructors
		public CwCameraPivot() {} // 0x00000001856EEC78-0x00000001856EED00
	
		// Methods
		protected virtual void OnEnable() {} // 0x00000001856EEC10-0x00000001856EEC50
		protected virtual void Update() {} // 0x00000001856EEC50-0x00000001856EEC78
		private void AddToDelta() {} // 0x00000001856EE9D0-0x00000001856EEA34
		private void DampenDelta() {} // 0x00000001856EEA34-0x00000001856EEC10
	}

	[AddComponentMenu("")]
	[ExecuteInEditMode]
	public class CwDemo : MonoBehaviour // TypeDefIndex: 58249
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
		public bool UpgradeInputModule { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public bool ChangeExposureInHDRP { get => default; set {} } // 0x0000000183D4EF80-0x0000000183D4EF90 0x0000000183D4EFB0-0x0000000183D4EFC0
		public bool ChangeVisualEnvironmentInHDRP { get => default; set {} } // 0x0000000183D4EFA0-0x0000000183D4EFB0 0x0000000183D4EFD0-0x0000000183D4EFE0
		public bool ChangeFogInHDRP { get => default; set {} } // 0x0000000183D52270-0x0000000183D52280 0x0000000183D522A0-0x0000000183D522B0
		public bool ChangeCloudsInHDRP { get => default; set {} } // 0x0000000183D4E9A0-0x0000000183D4E9B0 0x0000000183D4E9B0-0x0000000183D4E9C0
		public bool ChangeMotionBlurInHDRP { get => default; set {} } // 0x0000000183D50D90-0x0000000183D50DA0 0x0000000183D522B0-0x0000000183D522C0
		public bool UpgradeLightsInHDRP { get => default; set {} } // 0x0000000183D52290-0x0000000183D522A0 0x0000000183D522D0-0x0000000183D522E0
		public bool UpgradeCamerasInHDRP { get => default; set {} } // 0x0000000183D52280-0x0000000183D52290 0x0000000183D522C0-0x0000000183D522D0
	
		// Constructors
		public CwDemo() {} // 0x00000001856EF8A4-0x00000001856EF8BC
	
		// Methods
		protected virtual void OnEnable() {} // 0x00000001856EF894-0x00000001856EF8A4
		protected virtual void TryApplyURP() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void TryApplyHDRP() {} // 0x0000000183D4B9D0-0x0000000183D4B9E0
		private void TryCreateVolume() {} // 0x000000018350B670-0x000000018350B680
		private void TryUpgradeLights() {} // 0x000000018350B670-0x000000018350B680
		private void TryUpgradeCameras() {} // 0x000000018350B670-0x000000018350B680
		private void TryUpgradeEventSystem() {} // 0x000000018350B670-0x000000018350B680
	}

	[AddComponentMenu("Common/CW Demo Button")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwDemoButton")]
	public class CwDemoButton : MonoBehaviour, IPointerDownHandler // TypeDefIndex: 58252
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
		public LinkType Link { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public string UrlTarget { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public Transform IsolateTarget { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public ToggleType IsolateToggle { get => default; set {} } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
	
		// Nested types
		public enum LinkType // TypeDefIndex: 58250
		{
			PreviousScene = 0,
			NextScene = 1,
			Publisher = 2,
			URL = 3,
			Isolate = 4
		}
	
		public enum ToggleType // TypeDefIndex: 58251
		{
			KeepSelected = 0,
			ToggleSelection = 1,
			SelectPrevious = 2
		}
	
		// Constructors
		public CwDemoButton() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected virtual void OnEnable() {} // 0x00000001856EF1C4-0x00000001856EF20C
		protected virtual void Update() {} // 0x00000001856EF74C-0x00000001856EF894
		public void OnPointerDown(PointerEventData eventData) {} // 0x00000001856EF20C-0x00000001856EF74C
		private static int GetCurrentLevel() => default; // 0x00000001856EF0C8-0x00000001856EF13C
		private static int GetLevelCount() => default; // 0x00000001856EF13C-0x00000001856EF17C
		private static void LoadLevel(int index) {} // 0x00000001856EF17C-0x00000001856EF1C4
	}

	[AddComponentMenu("Common/CW Demo Button Builder")]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwDemoButtonBuilder")]
	public class CwDemoButtonBuilder : MonoBehaviour // TypeDefIndex: 58253
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
		public GameObject ButtonPrefab { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public RectTransform ButtonRoot { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public Sprite Icon { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public UnityEngine.Color Color { get => default; set {} } // 0x0000000183D4FD30-0x0000000183D4FD40 0x0000000183D4FD40-0x0000000183D4FD50
		public string OverrideName { get => default; set {} } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
	
		// Constructors
		public CwDemoButtonBuilder() {} // 0x00000001856EF0A0-0x00000001856EF0C8
	
		// Methods
		[ContextMenu("Build")]
		public void Build() {} // 0x00000001856EEE14-0x00000001856EF038
		[ContextMenu("Build All")]
		public void BuildAll() {} // 0x00000001856EED7C-0x00000001856EEE14
		private GameObject DoInstantiate() => default; // 0x00000001856EF038-0x00000001856EF0A0
	}

	[AddComponentMenu("Common/CW Light Intensity")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwLightIntensity")]
	[RequireComponent(typeof(Light))]
	public class CwLightIntensity : MonoBehaviour // TypeDefIndex: 58254
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
		public float Multiplier { get => default; set {} } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000183D4EC00-0x0000000183D4EC10
		public float IntensityInStandard { get => default; set {} } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000183D4F120-0x0000000183D4F130
		public float IntensityInURP { get => default; set {} } // 0x0000000183D4F2E0-0x0000000183D4F2F0 0x0000000183D4F2F0-0x0000000183D4F300
		public float IntensityInHDRP { get => default; set {} } // 0x0000000183D524F0-0x0000000183D52500 0x0000000183D52500-0x0000000183D52510
		public Light CachedLight { get => default; } // 0x00000001856F4B04-0x00000001856F4B5C 
	
		// Constructors
		public CwLightIntensity() {} // 0x00000001856F4AE0-0x00000001856F4B04
	
		// Methods
		protected virtual void Update() {} // 0x00000001856F4A80-0x00000001856F4AE0
		private void ApplyIntensity(float intensity) {} // 0x00000001856F49F8-0x00000001856F4A80
	}

	[AddComponentMenu("Common/CW Rotate")]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwRotate")]
	public class CwRotate : MonoBehaviour // TypeDefIndex: 58255
	{
		// Fields
		[SerializeField]
		private Vector3 angularVelocity; // 0x18
		[SerializeField]
		private UnityEngine.Space relativeTo; // 0x24
	
		// Properties
		public Vector3 AngularVelocity { get => default; set {} } // 0x0000000183D52510-0x0000000183D52530 0x0000000183D52530-0x0000000183D52540
		public UnityEngine.Space RelativeTo { get => default; set {} } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
	
		// Constructors
		public CwRotate() {} // 0x00000001856F5148-0x00000001856F516C
	
		// Methods
		protected virtual void Update() {} // 0x00000001856F50B4-0x00000001856F5148
	}

	public abstract class CwChild : MonoBehaviour // TypeDefIndex: 58257
	{
		// Nested types
		public interface IHasChildren // TypeDefIndex: 58256
		{
			// Methods
			bool HasChild(CwChild child);
		}
	
		// Constructors
		protected CwChild() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void DestroyGameObjectIfInvalid() {} // 0x00000001856EED00-0x00000001856EED7C
		protected abstract IHasChildren GetParent();
		protected virtual void Start() {} // 0x000000018350B670-0x000000018350B680
	}

	[AddComponentMenu("Common/CW Depth Texture Mode")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwDepthTextureMode")]
	[RequireComponent(typeof(Camera))]
	public class CwDepthTextureMode : MonoBehaviour // TypeDefIndex: 58258
	{
		// Fields
		[SerializeField]
		private DepthTextureMode depthMode; // 0x18
		[NonSerialized]
		private Camera cachedCamera; // 0x20
	
		// Properties
		public DepthTextureMode DepthMode { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x00000001856EF95C-0x00000001856EF968
	
		// Constructors
		public CwDepthTextureMode() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void UpdateDepthMode() {} // 0x00000001856EF8BC-0x00000001856EF954
		protected virtual void Update() {} // 0x00000001856EF954-0x00000001856EF95C
	}

	[AddComponentMenu("Common/CW Follow")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwFollow")]
	public class CwFollow : MonoBehaviour // TypeDefIndex: 58261
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
		public FollowType Follow { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public Transform Target { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public float Damping { get => default; set {} } // 0x0000000183D4F480-0x0000000183D4F490 0x0000000183D4F490-0x0000000183D4F4A0
		public bool Rotate { get => default; set {} } // 0x0000000183D4F1A0-0x0000000183D4F1B0 0x0000000183D4F1B0-0x0000000183D4F1C0
		public bool IgnoreZ { get => default; set {} } // 0x0000000183D4F4C0-0x0000000183D4F4D0 0x0000000183D4F4F0-0x0000000183D4F500
		public UpdateType FollowIn { get => default; set {} } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
		public Vector3 LocalPosition { get => default; set {} } // 0x0000000183D522E0-0x0000000183D52300 0x0000000183D52320-0x0000000183D52330
		public Vector3 LocalRotation { get => default; set {} } // 0x0000000183D52300-0x0000000183D52320 0x0000000183D52330-0x0000000183D52340
	
		// Nested types
		public enum FollowType // TypeDefIndex: 58259
		{
			TargetTransform = 0,
			MainCamera = 1
		}
	
		public enum UpdateType // TypeDefIndex: 58260
		{
			Update = 0,
			LateUpdate = 1
		}
	
		// Constructors
		public CwFollow() {} // 0x00000001856EFC48-0x00000001856EFC64
	
		// Methods
		[ContextMenu("UpdatePosition")]
		public void UpdatePosition() {} // 0x00000001856EF978-0x00000001856EFC38
		protected virtual void Update() {} // 0x00000001856EFC38-0x00000001856EFC48
		protected virtual void LateUpdate() {} // 0x00000001856EF968-0x00000001856EF978
	}

	[AddComponentMenu("Common/CW Input Manager")]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwInputManager")]
	public class CwInputManager : MonoBehaviour // TypeDefIndex: 58267
	{
		// Fields
		[SerializeField]
		private LayerMask guiLayers; // 0x18
		public const int MOUSE_FINGER_INDEX = -1; // Metadata: 0x01FDB205
		public const int HOVER_FINGER_INDEX = -1337; // Metadata: 0x01FDB206
		private static List<RaycastResult> tempRaycastResults; // 0x18
		private static PointerEventData tempPointerEventData; // 0x20
		private static EventSystem tempEventSystem; // 0x28
		private static List<Finger> fingers; // 0x30
		private static List<Finger> filteredFingers; // 0x38
		private static Stack<Finger> pool; // 0x40
	
		// Properties
		public LayerMask GuiLayers { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public static List<Finger> Fingers { get => default; } // 0x00000001856F40B0-0x00000001856F4100 
		public static float ScaleFactor { get => default; } // 0x00000001856F4100-0x00000001856F412C 
	
		// Events
		public static event Action<Finger> OnFingerDown;
		public static event Action<Finger> OnFingerUpdate;
		public static event Action<Finger> OnFingerUp;
	
		// Nested types
		public enum AxisGesture // TypeDefIndex: 58262
		{
			HorizontalDrag = 0,
			VerticalDrag = 1,
			Twist = 2,
			HorizontalPull = 3,
			VerticalPull = 4
		}
	
		[Serializable]
		public struct Axis // TypeDefIndex: 58263
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
			public Axis(int fCount, bool fInvert, AxisGesture fGesture, float fSensitivty, KeyCode kNegative, KeyCode kPositive, KeyCode kNegativeAlt, KeyCode kPositiveAlt, float kSensitivity) {
				FingerCount = default;
				FingerInvert = default;
				FingerGesture = default;
				FingerSensitivity = default;
				KeyNegative = default;
				KeyPositive = default;
				KeyNegativeAlt = default;
				KeyPositiveAlt = default;
				KeySensitivity = default;
			} // 0x0000000183D520F0-0x0000000183D52130
	
			// Methods
			public float GetValue(float delta) => default; // 0x00000001856EDD38-0x00000001856EE008
		}
	
		[Serializable]
		public struct Trigger // TypeDefIndex: 58264
		{
			// Fields
			public bool UseFinger; // 0x00
			public bool UseMouse; // 0x01
			public KeyCode UseKey; // 0x04
	
			// Constructors
			public Trigger(bool uFinger, bool uMouse, KeyCode uKey) {
				UseFinger = default;
				UseMouse = default;
				UseKey = default;
			} // 0x0000000183D52540-0x0000000183D52550
	
			// Methods
			public bool WentDown(Finger finger) => default; // 0x00000001856F56C0-0x00000001856F5760
			public bool IsDown(Finger finger) => default; // 0x00000001856F5620-0x00000001856F56C0
			public bool WentUp(Finger finger, bool useAnyFinger = false /* Metadata: 0x01FDB20D */) => default; // 0x00000001856F5760-0x00000001856F5820
		}
	
		public abstract class Link // TypeDefIndex: 58265
		{
			// Fields
			public Finger Finger; // 0x10
	
			// Constructors
			protected Link() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public static T Find<T>(List<T> links, Finger finger)
				where T : Link, new() => default;
			public static T Create<T>(ref List<T> links, Finger finger)
				where T : Link, new() => default;
			public static void ClearAll<T>(List<T> links)
				where T : Link {}
			public static void ClearAndRemove<T>(List<T> links, T link)
				where T : Link {}
			public virtual void Clear() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public class Finger // TypeDefIndex: 58266
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
			public float SmoothScreenPositionDelta { get => default; } // 0x00000001856F5584-0x00000001856F55C4 
	
			// Constructors
			public Finger() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public Vector2 GetSmoothScreenPosition(float t) => default; // 0x00000001856F5448-0x00000001856F5584
		}
	
		// Constructors
		public CwInputManager() {} // 0x00000001856F3E4C-0x00000001856F3E5C
		static CwInputManager() {} // 0x00000001856F3C94-0x00000001856F3E4C
	
		// Methods
		public static List<Finger> GetFingers(bool ignoreStartedOverGui = false /* Metadata: 0x01FDB201 */, bool ignoreHover = false /* Metadata: 0x01FDB202 */) => default; // 0x00000001856F302C-0x00000001856F3240
		public static bool PointOverGui(Vector2 screenPosition, int guiLayers = 32 /* Metadata: 0x01FDB203 */) => default; // 0x00000001856F3350-0x00000001856F33C4
		public static List<RaycastResult> RaycastGui(Vector2 screenPosition, int guiLayers = 32 /* Metadata: 0x01FDB204 */) => default; // 0x00000001856F33C4-0x00000001856F375C
		public static Vector2 GetAveragePosition(List<Finger> fingers) => default; // 0x00000001856F29AC-0x00000001856F2B68
		public static Vector2 GetAverageOldPosition(List<Finger> fingers) => default; // 0x00000001856F27F0-0x00000001856F29AC
		public static Vector2 GetAveragePullScaled(List<Finger> fingers) => default; // 0x00000001856F2B68-0x00000001856F2D60
		public static Vector2 GetAverageDeltaScaled(List<Finger> fingers) => default; // 0x00000001856F25F8-0x00000001856F27F0
		public static float GetAverageTwistRadians(List<Finger> fingers) => default; // 0x00000001856F2D60-0x00000001856F2F44
		public static void EnsureThisComponentExists() {} // 0x00000001856F23A8-0x00000001856F24B8
		protected virtual void Update() {} // 0x00000001856F375C-0x00000001856F3C94
		private Finger FindFinger(int index) => default; // 0x00000001856F24B8-0x00000001856F25F8
		private void AddFinger(int index, Vector2 screenPosition, float pressure, bool set) {} // 0x00000001856F2184-0x00000001856F23A8
		private static Vector2 Hermite(Vector2 a, Vector2 b, Vector2 c, Vector2 d, float t) => default; // 0x00000001856F3240-0x00000001856F3350
		private static float HermiteInterpolate(float y0, float y1, float y2, float y3, float mu, float mu2, float mu3) => default; // 0x0000000183D523D0-0x0000000183D524F0
		private static float GetRadians(Vector2 screenPosition, Vector2 referencePoint) => default; // 0x0000000183D523A0-0x0000000183D523D0
		private static float GetDeltaRadians(Finger finger, Vector2 referencePoint, Vector2 lastReferencePoint) => default; // 0x00000001856F2F44-0x00000001856F302C
	}

	[AddComponentMenu("Common/CW Render Texture Manager")]
	[DefaultExecutionOrder(1000)]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwRenderTextureManager")]
	public class CwRenderTextureManager : MonoBehaviour // TypeDefIndex: 58268
	{
		// Fields
		[SerializeField]
		private int lifetime; // 0x18
	
		// Properties
		public int Lifetime { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
	
		// Constructors
		public CwRenderTextureManager() {} // 0x00000001856F4C78-0x00000001856F4C88
	
		// Methods
		public static RenderTexture GetTemporary(RenderTextureDescriptor desc, string title) => default; // 0x00000001856F4B5C-0x00000001856F4C0C
		public static RenderTexture ReleaseTemporary(RenderTexture renderTexture) => default; // 0x00000001856F4C0C-0x00000001856F4C78
	}

	[AddComponentMenu("Common/CW Root")]
	[DefaultExecutionOrder(-100)]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.com/Documentation/Common#CwRoot")]
	public class CwRoot : MonoBehaviour // TypeDefIndex: 58269
	{
		// Fields
		private static List<CwRoot> instances; // 0x00
	
		// Properties
		public static bool Exists { get => default; } // 0x00000001856F4FA8-0x00000001856F5008 
		public static Transform Root { get => default; } // 0x00000001856F5008-0x00000001856F50B4 
	
		// Constructors
		public CwRoot() {} // 0x000000018426FE60-0x000000018426FE68
		static CwRoot() {} // 0x00000001856F4F1C-0x00000001856F4FA8
	
		// Methods
		public static Transform GetRoot() => default; // 0x00000001856F4C88-0x00000001856F4D90
		protected virtual void OnEnable() {} // 0x00000001856F4E00-0x00000001856F4F1C
		protected virtual void OnDisable() {} // 0x00000001856F4D90-0x00000001856F4E00
	}

	public class CwSeedAttribute : PropertyAttribute // TypeDefIndex: 58270
	{
		// Constructors
		public CwSeedAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal static class CwShared // TypeDefIndex: 58271
	{
		// Fields
		public const string HelpUrlPrefix = "https://carloswilkes.com/Documentation/Common#"; // Metadata: 0x01FDB20E
		public const string ComponentMenuPrefix = "Common/CW "; // Metadata: 0x01FDB23D
		public const string GameObjectMenuPrefix = "GameObject/CW/Common/"; // Metadata: 0x01FDB248
	}

	public class CwGuide : ScriptableObject // TypeDefIndex: 58272
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
		public Texture2D Icon { get => default; } // 0x00000001856EFC64-0x00000001856EFD48 
		public string Version { get => default; } // 0x00000001856EFD48-0x00000001856EFE44 
	
		// Constructors
		public CwGuide() {} // 0x000000018286F540-0x000000018286F550
	}

	public static class CwHelper // TypeDefIndex: 58274
	{
		// Fields
		private static Stack<UnityEngine.Random.State> seedStates; // 0x00
		public static List<Material> tempMaterials; // 0x08
		public static List<MaterialPropertyBlock> tempProperties; // 0x10
		private static Stack<RenderTexture> actives; // 0x28
		private static int uniqueSeed; // 0x30
		private static List<Material> materials; // 0x38
	
		// Events
		public static event Action<Camera> OnCameraPreRender;
		public static event Action<Camera> OnCameraPostRender;
	
		// Constructors
		static CwHelper() {} // 0x00000001856F1990-0x00000001856F1E64
	
		// Methods
		public static T GetOrAddComponent<T>(GameObject gameObject, bool recordUndo = true /* Metadata: 0x01FDB25E */)
			where T : Component => default;
		public static T AddComponent<T>(GameObject gameObject, bool recordUndo = true /* Metadata: 0x01FDB25F */)
			where T : Component => default;
		public static bool IndexInMask(int index, int mask) => default; // 0x00000001856F0EC8-0x00000001856F0ED8
		public static Camera GetCamera(Camera currentCamera, GameObject gameObject = null) => default; // 0x00000001856F0B0C-0x00000001856F0BD0
		public static Vector3 GetObserverPosition(Transform observer) => default; // 0x00000001856F0BD0-0x00000001856F0C9C
		public static bool Enabled(UnityEngine.Behaviour b) => default; // 0x00000001856F09B4-0x00000001856F0A18
		public static void BeginSeed() {} // 0x00000001856F0290-0x00000001856F0314
		public static void BeginSeed(int newSeed) {} // 0x00000001856F01F8-0x00000001856F0290
		public static void EndSeed() {} // 0x00000001856F0A88-0x00000001856F0B0C
		public static UnityEngine.Color Brighten(UnityEngine.Color color, float brightness, bool convertToGamma = true /* Metadata: 0x01FDB260 */) => default; // 0x00000001856F0314-0x00000001856F03C4
		public static UnityEngine.Color Premultiply(UnityEngine.Color color) => default; // 0x0000000183D52360-0x0000000183D523A0
		public static float Saturate(float c) => default; // 0x00000001856F13C8-0x00000001856F13F4
		public static UnityEngine.Color Saturate(UnityEngine.Color c) => default; // 0x00000001856F13F4-0x00000001856F1484
		public static void Resize<T>(List<T> list, int size) {}
		public static float Sharpness(float a, float p) => default; // 0x00000001856F1800-0x00000001856F184C
		public static UnityEngine.Color ToLinear(UnityEngine.Color gamma) => default; // 0x00000001856F18C4-0x00000001856F1908
		public static float ToLinear(float gamma) => default; // 0x00000001856F1908-0x00000001856F193C
		public static UnityEngine.Color ToGamma(UnityEngine.Color linear) => default; // 0x00000001856F1880-0x00000001856F18C4
		public static float ToGamma(float linear) => default; // 0x00000001856F184C-0x00000001856F1880
		public static float UniformScale(Vector3 scale) => default; // 0x00000001856F193C-0x00000001856F1990
		public static void BeginActive(RenderTexture renderTexture) {} // 0x00000001856F016C-0x00000001856F01F8
		public static void EndActive() {} // 0x00000001856F0A18-0x00000001856F0A88
		public static void SetTempMaterial(Material material) {} // 0x00000001856F1484-0x00000001856F1550
		public static void SetTempMaterial(Material material1, Material material2) {} // 0x00000001856F1550-0x00000001856F1654
		public static void SetTempMaterial(List<Material> materials) {} // 0x00000001856F1654-0x00000001856F1734
		public static void SetTempMaterial(MaterialPropertyBlock properties) {} // 0x00000001856F1734-0x00000001856F1800
		public static void AddMaterial(Renderer r, Material m) {} // 0x00000001856EFF1C-0x00000001856F016C
		public static void ReplaceMaterial(Renderer r, Material m) {} // 0x00000001856F1144-0x00000001856F13C8
		public static void RemoveMaterial(Renderer r, Material m) {} // 0x00000001856F0F4C-0x00000001856F1144
		public static Texture2D CreateTempTexture2D(string name, int width, int height, TextureFormat format = TextureFormat.ARGB32 /* Metadata: 0x01FDB261 */, bool mips = false /* Metadata: 0x01FDB262 */, bool linear = false /* Metadata: 0x01FDB263 */) => default; // 0x00000001856F0810-0x00000001856F08CC
		public static Material CreateTempMaterial(string materialName, string shaderName) => default; // 0x00000001856F06B0-0x00000001856F0784
		public static Material CreateTempMaterial(string materialName, Shader shader) => default; // 0x00000001856F0784-0x00000001856F0810
		public static Material CreateTempMaterial(string materialName, Material source) => default; // 0x00000001856F0624-0x00000001856F06B0
		public static T Destroy<T>(T o)
			where T : UnityEngine.Object => default;
		public static GameObject CreateGameObject(string name, int layer, Transform parent = null, string recordUndo = null) => default; // 0x00000001856F051C-0x00000001856F0624
		public static GameObject CreateGameObject(string name, int layer, Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale, string recordUndo = null) => default; // 0x00000001856F03C4-0x00000001856F051C
		public static T CreateElement<T>(Transform parent)
			where T : Component => default;
		public static float Reciprocal(float v) => default; // 0x00000001856F0F14-0x00000001856F0F30
		public static double Reciprocal(double v) => default; // 0x00000001856F0F30-0x00000001856F0F4C
		public static float Divide(float a, float b) => default; // 0x00000001856F098C-0x00000001856F09A0
		public static double Divide(double a, double b) => default; // 0x00000001856F09A0-0x00000001856F09B4
		public static float Acos(float v) => default; // 0x00000001856EFEB0-0x00000001856EFF1C
		public static double Acos(double v) => default; // 0x00000001856EFE44-0x00000001856EFEB0
		public static float DampenFactor(float speed, float elapsed) => default; // 0x00000001856F0944-0x00000001856F098C
		public static float DampenFactor(float damping, float deltaTime, float linear) => default; // 0x00000001856F08CC-0x00000001856F0944
		public static float Atan2(Vector2 xy) => default; // 0x0000000183D52340-0x0000000183D52360
		public static int Mod(int a, int b) => default; // 0x00000001856F0ED8-0x00000001856F0EEC
		public static float Mod(float a, float b) => default; // 0x00000001856F0EEC-0x00000001856F0F14
		public static Texture2D GetReadableCopy(Texture texture, TextureFormat format = TextureFormat.ARGB32 /* Metadata: 0x01FDB264 */, bool mipMaps = false /* Metadata: 0x01FDB265 */, int width = 0 /* Metadata: 0x01FDB266 */, int height = 0 /* Metadata: 0x01FDB267 */) => default; // 0x00000001856F0C9C-0x00000001856F0EC8
	}

	public static class CwInput // TypeDefIndex: 58275
	{
		// Fields
		private static Dictionary<KeyCode, UnityEngine.InputSystem.Key> keyMapping; // 0x00
	
		// Constructors
		static CwInput() {} // 0x0000000183633F00-0x0000000183634D20
	
		// Methods
		[RuntimeInitializeOnLoadMethod]
		private static void Enable() {} // 0x000000018235C360-0x000000018235C370
		private static ButtonControl GetMouseButtonControl(int index) => default; // 0x00000001856F45DC-0x00000001856F4674
		private static ButtonControl GetButtonControl(KeyCode oldKey) => default; // 0x00000001856F4380-0x00000001856F44CC
		public static int GetTouchCount() => default; // 0x00000001856F4858-0x00000001856F48BC
		public static void GetTouch(int index, out int id, out Vector2 position, out float pressure, out bool set) {
			id = default;
			position = default;
			pressure = default;
			set = default;
		} // 0x00000001856F48BC-0x00000001856F49F8
		public static Vector2 GetMousePosition() => default; // 0x00000001856F46DC-0x00000001856F473C
		public static bool GetKeyWentDown(KeyCode oldKey) => default; // 0x00000001856F4520-0x00000001856F4574
		public static bool GetKeyIsHeld(KeyCode oldKey) => default; // 0x00000001856F44CC-0x00000001856F4520
		public static bool GetKeyWentUp(KeyCode oldKey) => default; // 0x00000001856F4574-0x00000001856F45C8
		public static bool GetMouseWentDown(int index) => default; // 0x00000001856F473C-0x00000001856F4790
		public static bool GetMouseIsHeld(int index) => default; // 0x00000001856F4688-0x00000001856F46DC
		public static bool GetMouseWentUp(int index) => default; // 0x00000001856F4790-0x00000001856F47E4
		public static float GetMouseWheelDelta() => default; // 0x00000001856F47E4-0x00000001856F4858
		public static bool GetMouseExists() => default; // 0x00000001856F4674-0x00000001856F4688
		public static bool GetKeyboardExists() => default; // 0x00000001856F45C8-0x00000001856F45DC
	}

	public class CwShaderBundle : ScriptableObject // TypeDefIndex: 58278
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
		public string Title { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public Shader Target { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public int VariantHash { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
		public int ProjectHash { get => default; set {} } // 0x0000000183D4EDD0-0x0000000183D4EDE0 0x0000000183D4EDE0-0x0000000183D4EDF0
		public List<ShaderVariant> Variants { get => default; } // 0x00000001856F53C4-0x00000001856F5448 
		public bool Dirty { get => default; } // 0x00000001856F52B8-0x00000001856F53C4 
	
		// Nested types
		public enum Pipeline // TypeDefIndex: 58276
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
		public class ShaderVariant // TypeDefIndex: 58277
		{
			// Fields
			public Pipeline Pipe; // 0x10
			public string Code; // 0x18
			public int Hash; // 0x20
			public bool Dirty; // 0x24
	
			// Properties
			public string HashString { get => default; } // 0x00000001856F55C4-0x00000001856F5620 
	
			// Constructors
			public ShaderVariant() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public CwShaderBundle() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		public static int GetProjectHash() => default; // 0x00000001856F5214-0x00000001856F525C
		public static Pipeline DetectProjectPipeline() => default; // 0x00000001856F516C-0x00000001856F5214
		public static bool IsStandard(Pipeline pipe) => default; // 0x00000001856F529C-0x00000001856F52A4
		public static bool IsScriptable(Pipeline pipe) => default; // 0x00000001856F5270-0x00000001856F529C
		public static bool IsURP(Pipeline pipe) => default; // 0x00000001856F52A4-0x00000001856F52B8
		public static bool IsHDRP(Pipeline pipe) => default; // 0x00000001856F525C-0x00000001856F5270
	}
}
