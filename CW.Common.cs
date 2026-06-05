/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.Rendering;

// Image 66: CW.Common.dll - Assembly: CW.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59393-59426

namespace CW.Common
{
	public class CwCameraLook : MonoBehaviour // TypeDefIndex: 59394
	{
		// Fields
		private bool listen; // 0x18
		private float damping; // 0x1C
		private float sensitivity; // 0x20
		private CwInputManager.Axis pitchControls; // 0x24
		private CwInputManager.Axis yawControls; // 0x48
		private CwInputManager.Axis rollControls; // 0x6C
		[NonSerialized]
		private Quaternion remainingDelta; // 0x90
	
		// Properties
		public bool Listen { get => default; set {} } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
		public float Damping { get => default; set {} } // 0x0000000185FB0850-0x0000000185FB0860 0x0000000183B7E5A0-0x0000000183B7E5B0
		public float Sensitivity { get => default; set {} } // 0x0000000181C9AC70-0x0000000181C9AC80 0x0000000181C9A5B0-0x0000000181C9A5C0
		public CwInputManager.Axis PitchControls { get => default; set {} } // 0x0000000185FB3450-0x0000000185FB3470 0x0000000185FB34B0-0x0000000185FB34D0
		public CwInputManager.Axis YawControls { get => default; set {} } // 0x0000000185FB3490-0x0000000185FB34B0 0x0000000185FB34F0-0x0000000185FB3510
		public CwInputManager.Axis RollControls { get => default; set {} } // 0x0000000185FB3470-0x0000000185FB3490 0x0000000185FB34D0-0x0000000185FB34F0
	
		// Constructors
		public CwCameraLook() {} // 0x00000001878A0E90-0x00000001878A0F74
	
		// Methods
		protected virtual void Start() {} // 0x00000001878A0E28-0x00000001878A0E68
		protected virtual void OnDisable() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void Update() {} // 0x00000001878A0E68-0x00000001878A0E90
		protected virtual void OnApplicationFocus(bool focus) {} // 0x0000000185492010-0x0000000185492020
		private void AddToDelta() {} // 0x00000001878A0AA4-0x00000001878A0CB0
		private void DampenDelta() {} // 0x00000001878A0CB0-0x00000001878A0E28
	}

	public class CwCameraMove : MonoBehaviour // TypeDefIndex: 59395
	{
		// Fields
		private bool listen; // 0x18
		private float damping; // 0x1C
		private float sensitivity; // 0x20
		private CwInputManager.Axis horizontalControls; // 0x24
		private CwInputManager.Axis depthControls; // 0x48
		private CwInputManager.Axis verticalControls; // 0x6C
		[NonSerialized]
		private Vector3 remainingDelta; // 0x90
	
		// Properties
		public bool Listen { get => default; set {} } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
		public float Damping { get => default; set {} } // 0x0000000185FB0850-0x0000000185FB0860 0x0000000183B7E5A0-0x0000000183B7E5B0
		public float Sensitivity { get => default; set {} } // 0x0000000181C9AC70-0x0000000181C9AC80 0x0000000181C9A5B0-0x0000000181C9A5C0
		public CwInputManager.Axis HorizontalControls { get => default; set {} } // 0x0000000185FB3450-0x0000000185FB3470 0x0000000185FB34B0-0x0000000185FB34D0
		public CwInputManager.Axis DepthControls { get => default; set {} } // 0x0000000185FB3490-0x0000000185FB34B0 0x0000000185FB34F0-0x0000000185FB3510
		public CwInputManager.Axis VerticalControls { get => default; set {} } // 0x0000000185FB3470-0x0000000185FB3490 0x0000000185FB34D0-0x0000000185FB34F0
	
		// Constructors
		public CwCameraMove() {} // 0x00000001878A1390-0x00000001878A146C
	
		// Methods
		protected virtual void Start() {} // 0x00000001878A1328-0x00000001878A1368
		protected virtual void Update() {} // 0x00000001878A1368-0x00000001878A1390
		private void AddToDelta() {} // 0x00000001878A0F74-0x00000001878A1198
		private void DampenDelta() {} // 0x00000001878A1198-0x00000001878A1328
	}

	public class CwCameraPivot : MonoBehaviour // TypeDefIndex: 59396
	{
		// Fields
		private bool listen; // 0x18
		private float damping; // 0x1C
		private CwInputManager.Axis pitchControls; // 0x20
		private CwInputManager.Axis yawControls; // 0x44
		[NonSerialized]
		private Vector3 remainingDelta; // 0x68
	
		// Properties
		public bool Listen { get => default; set {} } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
		public float Damping { get => default; set {} } // 0x0000000185FB0850-0x0000000185FB0860 0x0000000183B7E5A0-0x0000000183B7E5B0
		public CwInputManager.Axis PitchControls { get => default; set {} } // 0x0000000185FB3510-0x0000000185FB3530 0x0000000185FB3550-0x0000000185FB3570
		public CwInputManager.Axis YawControls { get => default; set {} } // 0x0000000185FB3530-0x0000000185FB3550 0x0000000185FB3570-0x0000000185FB3590
	
		// Constructors
		public CwCameraPivot() {} // 0x00000001878A1714-0x00000001878A179C
	
		// Methods
		protected virtual void OnEnable() {} // 0x00000001878A16AC-0x00000001878A16EC
		protected virtual void Update() {} // 0x00000001878A16EC-0x00000001878A1714
		private void AddToDelta() {} // 0x00000001878A146C-0x00000001878A14D0
		private void DampenDelta() {} // 0x00000001878A14D0-0x00000001878A16AC
	}

	public class CwDemo : MonoBehaviour // TypeDefIndex: 59397
	{
		// Fields
		private bool upgradeInputModule; // 0x18
		private bool changeExposureInHDRP; // 0x19
		private bool changeVisualEnvironmentInHDRP; // 0x1A
		private bool changeFogInHDRP; // 0x1B
		private bool changeCloudsInHDRP; // 0x1C
		private bool changeMotionBlurInHDRP; // 0x1D
		private bool upgradeLightsInHDRP; // 0x1E
		private bool upgradeCamerasInHDRP; // 0x1F
	
		// Properties
		public bool UpgradeInputModule { get => default; set {} } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
		public bool ChangeExposureInHDRP { get => default; set {} } // 0x0000000181A73E90-0x0000000181A73EA0 0x0000000181A73EB0-0x0000000181A73EC0
		public bool ChangeVisualEnvironmentInHDRP { get => default; set {} } // 0x0000000185FB0730-0x0000000185FB0740 0x0000000185FB0740-0x0000000185FB0750
		public bool ChangeFogInHDRP { get => default; set {} } // 0x0000000185FB3590-0x0000000185FB35A0 0x0000000185FB35C0-0x0000000185FB35D0
		public bool ChangeCloudsInHDRP { get => default; set {} } // 0x00000001814088D0-0x00000001814088E0 0x0000000181408D10-0x0000000181408D20
		public bool ChangeMotionBlurInHDRP { get => default; set {} } // 0x0000000185FB2240-0x0000000185FB2250 0x0000000185FB35D0-0x0000000185FB35E0
		public bool UpgradeLightsInHDRP { get => default; set {} } // 0x0000000185FB35B0-0x0000000185FB35C0 0x0000000185FB35F0-0x0000000185FB3600
		public bool UpgradeCamerasInHDRP { get => default; set {} } // 0x0000000185FB35A0-0x0000000185FB35B0 0x0000000185FB35E0-0x0000000185FB35F0
	
		// Constructors
		public CwDemo() {} // 0x00000001878A2340-0x00000001878A2358
	
		// Methods
		protected virtual void OnEnable() {} // 0x00000001878A2330-0x00000001878A2340
		protected virtual void TryApplyURP() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void TryApplyHDRP() {} // 0x0000000185FACE20-0x0000000185FACE30
		private void TryCreateVolume() {} // 0x0000000185492010-0x0000000185492020
		private void TryUpgradeLights() {} // 0x0000000185492010-0x0000000185492020
		private void TryUpgradeCameras() {} // 0x0000000185492010-0x0000000185492020
		private void TryUpgradeEventSystem() {} // 0x0000000185492010-0x0000000185492020
	}

	public class CwDemoButton : MonoBehaviour, IPointerDownHandler // TypeDefIndex: 59400
	{
		// Fields
		private LinkType link; // 0x18
		private string urlTarget; // 0x20
		private Transform isolateTarget; // 0x28
		private ToggleType isolateToggle; // 0x30
		[NonSerialized]
		private CanvasGroup cachedCanvasGroup; // 0x38
		[NonSerialized]
		private Transform previousChild; // 0x40
	
		// Properties
		public LinkType Link { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public string UrlTarget { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public Transform IsolateTarget { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public ToggleType IsolateToggle { get => default; set {} } // 0x00000001813CFF60-0x00000001813CFF70 0x00000001813D0A90-0x00000001813D0AA0
	
		// Nested types
		public enum LinkType // TypeDefIndex: 59398
		{
			PreviousScene = 0,
			NextScene = 1,
			Publisher = 2,
			URL = 3,
			Isolate = 4
		}
	
		public enum ToggleType // TypeDefIndex: 59399
		{
			KeepSelected = 0,
			ToggleSelection = 1,
			SelectPrevious = 2
		}
	
		// Constructors
		public CwDemoButton() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected virtual void OnEnable() {} // 0x00000001878A1C60-0x00000001878A1CA8
		protected virtual void Update() {} // 0x00000001878A21E8-0x00000001878A2330
		public void OnPointerDown(PointerEventData eventData) {} // 0x00000001878A1CA8-0x00000001878A21E8
		private static int GetCurrentLevel() => default; // 0x00000001878A1B64-0x00000001878A1BD8
		private static int GetLevelCount() => default; // 0x00000001878A1BD8-0x00000001878A1C18
		private static void LoadLevel(int index) {} // 0x00000001878A1C18-0x00000001878A1C60
	}

	public class CwDemoButtonBuilder : MonoBehaviour // TypeDefIndex: 59401
	{
		// Fields
		private GameObject buttonPrefab; // 0x18
		private RectTransform buttonRoot; // 0x20
		private Sprite icon; // 0x28
		private UnityEngine.Color color; // 0x30
		private string overrideName; // 0x40
		private GameObject clone; // 0x48
	
		// Properties
		public GameObject ButtonPrefab { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public RectTransform ButtonRoot { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public Sprite Icon { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public UnityEngine.Color Color { get => default; set {} } // 0x0000000185FB1290-0x0000000185FB12A0 0x0000000185FB12A0-0x0000000185FB12B0
		public string OverrideName { get => default; set {} } // 0x00000001813FF010-0x00000001813FF020 0x0000000185F05C80-0x0000000185F05C90
	
		// Constructors
		public CwDemoButtonBuilder() {} // 0x00000001878A1B3C-0x00000001878A1B64
	
		// Methods
		public void Build() {} // 0x00000001878A18B0-0x00000001878A1AD4
		public void BuildAll() {} // 0x00000001878A1818-0x00000001878A18B0
		private GameObject DoInstantiate() => default; // 0x00000001878A1AD4-0x00000001878A1B3C
	}

	public class CwLightIntensity : MonoBehaviour // TypeDefIndex: 59402
	{
		// Fields
		private float multiplier; // 0x18
		private float intensityInStandard; // 0x1C
		private float intensityInURP; // 0x20
		private float intensityInHDRP; // 0x24
		[NonSerialized]
		private Light cachedLight; // 0x28
		[NonSerialized]
		private bool cachedLightSet; // 0x30
	
		// Properties
		public float Multiplier { get => default; set {} } // 0x0000000181C9AC50-0x0000000181C9AC60 0x0000000181C9A5A0-0x0000000181C9A5B0
		public float IntensityInStandard { get => default; set {} } // 0x0000000185FB0850-0x0000000185FB0860 0x0000000183B7E5A0-0x0000000183B7E5B0
		public float IntensityInURP { get => default; set {} } // 0x0000000181C9AC70-0x0000000181C9AC80 0x0000000181C9A5B0-0x0000000181C9A5C0
		public float IntensityInHDRP { get => default; set {} } // 0x0000000185FB3810-0x0000000185FB3820 0x0000000185FB3820-0x0000000185FB3830
		public Light CachedLight { get => default; } // 0x00000001878A75A0-0x00000001878A75F8 
	
		// Constructors
		public CwLightIntensity() {} // 0x00000001878A757C-0x00000001878A75A0
	
		// Methods
		protected virtual void Update() {} // 0x00000001878A751C-0x00000001878A757C
		private void ApplyIntensity(float intensity) {} // 0x00000001878A7494-0x00000001878A751C
	}

	public class CwRotate : MonoBehaviour // TypeDefIndex: 59403
	{
		// Fields
		private Vector3 angularVelocity; // 0x18
		private UnityEngine.Space relativeTo; // 0x24
	
		// Properties
		public Vector3 AngularVelocity { get => default; set {} } // 0x0000000185FB3830-0x0000000185FB3850 0x0000000185FB3850-0x0000000185FB3860
		public UnityEngine.Space RelativeTo { get => default; set {} } // 0x0000000181424480-0x0000000181424490 0x0000000181424940-0x0000000181424950
	
		// Constructors
		public CwRotate() {} // 0x00000001878A7BE4-0x00000001878A7C08
	
		// Methods
		protected virtual void Update() {} // 0x00000001878A7B50-0x00000001878A7BE4
	}

	public abstract class CwChild : MonoBehaviour // TypeDefIndex: 59405
	{
		// Nested types
		public interface IHasChildren // TypeDefIndex: 59404
		{
			// Methods
			bool HasChild(CwChild child); // 0x00000001878A179C-0x00000001878A1818
		}
	
		// Constructors
		protected CwChild() {}
	
		// Methods
		public void DestroyGameObjectIfInvalid() {}
		protected abstract IHasChildren GetParent(); // 0x0000000185492010-0x0000000185492020
		protected virtual void Start() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public class CwDepthTextureMode : MonoBehaviour // TypeDefIndex: 59406
	{
		// Fields
		private DepthTextureMode depthMode; // 0x18
		[NonSerialized]
		private Camera cachedCamera; // 0x20
	
		// Properties
		public DepthTextureMode DepthMode { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001878A23F8-0x00000001878A2404
	
		// Constructors
		public CwDepthTextureMode() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void UpdateDepthMode() {} // 0x00000001878A2358-0x00000001878A23F0
		protected virtual void Update() {} // 0x00000001878A23F0-0x00000001878A23F8
	}

	public class CwFollow : MonoBehaviour // TypeDefIndex: 59409
	{
		// Fields
		private FollowType follow; // 0x18
		private Transform target; // 0x20
		private float damping; // 0x28
		private bool rotate; // 0x2C
		private bool ignoreZ; // 0x2D
		private UpdateType followIn; // 0x30
		private Vector3 localPosition; // 0x34
		private Vector3 localRotation; // 0x40
	
		// Properties
		public FollowType Follow { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public Transform Target { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public float Damping { get => default; set {} } // 0x0000000185FB0A50-0x0000000185FB0A60 0x0000000185FB0A60-0x0000000185FB0A70
		public bool Rotate { get => default; set {} } // 0x0000000185FB08C0-0x0000000185FB08D0 0x0000000185FB08D0-0x0000000185FB08E0
		public bool IgnoreZ { get => default; set {} } // 0x0000000185FB0AD0-0x0000000185FB0AE0 0x0000000185FB0AF0-0x0000000185FB0B00
		public UpdateType FollowIn { get => default; set {} } // 0x00000001813CFF60-0x00000001813CFF70 0x00000001813D0A90-0x00000001813D0AA0
		public Vector3 LocalPosition { get => default; set {} } // 0x0000000185FB3600-0x0000000185FB3620 0x0000000185FB3640-0x0000000185FB3650
		public Vector3 LocalRotation { get => default; set {} } // 0x0000000185FB3620-0x0000000185FB3640 0x0000000185FB3650-0x0000000185FB3660
	
		// Nested types
		public enum FollowType // TypeDefIndex: 59407
		{
			TargetTransform = 0,
			MainCamera = 1
		}
	
		public enum UpdateType // TypeDefIndex: 59408
		{
			Update = 0,
			LateUpdate = 1
		}
	
		// Constructors
		public CwFollow() {} // 0x00000001878A26E4-0x00000001878A2700
	
		// Methods
		public void UpdatePosition() {} // 0x00000001878A2414-0x00000001878A26D4
		protected virtual void Update() {} // 0x00000001878A26D4-0x00000001878A26E4
		protected virtual void LateUpdate() {} // 0x00000001878A2404-0x00000001878A2414
	}

	public class CwInputManager : MonoBehaviour // TypeDefIndex: 59415
	{
		// Fields
		private LayerMask guiLayers; // 0x18
		private static Action<Finger> OnFingerDown; // 0x00
		private static Action<Finger> OnFingerUpdate; // 0x08
		private static Action<Finger> OnFingerUp; // 0x10
		public const int MOUSE_FINGER_INDEX = -1; // Metadata: 0x02080B99
		public const int HOVER_FINGER_INDEX = -1337; // Metadata: 0x02080B9A
		private static List<RaycastResult> tempRaycastResults; // 0x18
		private static PointerEventData tempPointerEventData; // 0x20
		private static EventSystem tempEventSystem; // 0x28
		private static List<Finger> fingers; // 0x30
		private static List<Finger> filteredFingers; // 0x38
		private static Stack<Finger> pool; // 0x40
	
		// Properties
		public LayerMask GuiLayers { get => default; set {} } // 0x00000001878A5094-0x00000001878A528C 0x00000001878A5604-0x00000001878A57FC
		public static List<Finger> Fingers { get => default; } // 0x0000000185FB36F0-0x0000000185FB3810 
		public static float ScaleFactor { get => default; } // 0x0000000185FB36C0-0x0000000185FB36F0 
	
		// Events
		public static event Action<Finger> OnFingerDown;
		public static event Action<Finger> OnFingerUpdate;
		public static event Action<Finger> OnFingerUp;
	
		// Nested types
		public enum AxisGesture // TypeDefIndex: 59410
		{
			HorizontalDrag = 0,
			VerticalDrag = 1,
			Twist = 2,
			HorizontalPull = 3,
			VerticalPull = 4
		}
	
		[Serializable]
		public struct Axis // TypeDefIndex: 59411
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
			} // 0x00000001813AE9C0-0x00000001813AE9D0
	
			// Methods
			public float GetValue(float delta) => default; // 0x00000001813AE560-0x00000001813AE570
		}
	
		[Serializable]
		public struct Trigger // TypeDefIndex: 59412
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
			} // 0x00000001878A68F8-0x00000001878A69BC
	
			// Methods
			public bool WentDown(Finger finger) => default; // 0x00000001878A6BC8-0x00000001878A6C8C
			public bool IsDown(Finger finger) => default; // 0x00000001878A6A84-0x00000001878A6B4C
			public bool WentUp(Finger finger, bool useAnyFinger = false /* Metadata: 0x02080BA1 */) => default; // 0x00000001878A6D54-0x00000001878A6E1C
		}
	
		public abstract class Link // TypeDefIndex: 59413
		{
			// Fields
			public Finger Finger; // 0x10
	
			// Constructors
			protected Link() {} // 0x00000001878A5DEC-0x00000001878A5E60
	
			// Methods
			public static T Find<T>(List<T> links, Finger finger)
				where T : Link, new() => default; // 0x00000001878A69BC-0x00000001878A6A84
			public static T Create<T>(ref List<T> links, Finger finger)
				where T : Link, new() => default; // 0x00000001878A6C8C-0x00000001878A6D54
			public static void ClearAll<T>(List<T> links)
				where T : Link {} // 0x00000001878A6B4C-0x00000001878A6B9C
			public static void ClearAndRemove<T>(List<T> links, T link)
				where T : Link {} // 0x00000001878A6B9C-0x00000001878A6BC8
			public virtual void Clear() {} // 0x00000001878A5AC8-0x00000001878A5CDC
		}
	
		public class Finger // TypeDefIndex: 59414
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
			public float SmoothScreenPositionDelta { get => default; } // 0x00000001878A5E60-0x00000001878A61F8 
	
			// Constructors
			public Finger() {} // 0x00000001878A528C-0x00000001878A5448
	
			// Methods
			public Vector2 GetSmoothScreenPosition(float t) => default; // 0x00000001878A5448-0x00000001878A5604
		}
	
		// Constructors
		public CwInputManager() {} // 0x00000001878A7EE4-0x00000001878A8020
		static CwInputManager() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static List<Finger> GetFingers(bool ignoreStartedOverGui = false /* Metadata: 0x02080B95 */, bool ignoreHover = false /* Metadata: 0x02080B96 */) => default; // 0x00000001878A59E0-0x00000001878A5AC8
		public static bool PointOverGui(Vector2 screenPosition, int guiLayers = 32 /* Metadata: 0x02080B97 */) => default; // 0x00000001878A68E8-0x00000001878A68F8
		public static List<RaycastResult> RaycastGui(Vector2 screenPosition, int guiLayers = 32 /* Metadata: 0x02080B98 */) => default; // 0x00000001878A6730-0x00000001878A68E8
		public static Vector2 GetAveragePosition(List<Finger> fingers) => default; // 0x0000000185FB3410-0x0000000185FB3450
		public static Vector2 GetAverageOldPosition(List<Finger> fingers) => default; // 0x00000001878A07D4-0x00000001878A0AA4
		public static Vector2 GetAveragePullScaled(List<Finger> fingers) => default; // 0x0000000185FB3860-0x0000000185FB3870
		public static Vector2 GetAverageDeltaScaled(List<Finger> fingers) => default; // 0x00000001878A815C-0x00000001878A81FC
		public static float GetAverageTwistRadians(List<Finger> fingers) => default; // 0x00000001878A80BC-0x00000001878A815C
		public static void EnsureThisComponentExists() {} // 0x00000001878A81FC-0x00000001878A82BC
		protected virtual void Update() {}
		private Finger FindFinger(int index) => default;
		private void AddFinger(int index, Vector2 screenPosition, float pressure, bool set) {}
		private static Vector2 Hermite(Vector2 a, Vector2 b, Vector2 c, Vector2 d, float t) => default;
		private static float HermiteInterpolate(float y0, float y1, float y2, float y3, float mu, float mu2, float mu3) => default; // 0x0000000185492010-0x0000000185492020
		private static float GetRadians(Vector2 screenPosition, Vector2 referencePoint) => default; // 0x0000000185492010-0x0000000185492020
		private static float GetDeltaRadians(Finger finger, Vector2 referencePoint, Vector2 lastReferencePoint) => default; // 0x00000001878A8020-0x00000001878A8060
	}

	public class CwRenderTextureManager : MonoBehaviour // TypeDefIndex: 59416
	{
		// Fields
		private int lifetime; // 0x18
	
		// Properties
		public int Lifetime { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
	
		// Constructors
		public CwRenderTextureManager() {} // 0x00000001878A7714-0x00000001878A7724
	
		// Methods
		public static RenderTexture GetTemporary(RenderTextureDescriptor desc, string title) => default; // 0x00000001878A75F8-0x00000001878A76A8
		public static RenderTexture ReleaseTemporary(RenderTexture renderTexture) => default; // 0x00000001878A76A8-0x00000001878A7714
	}

	public class CwRoot : MonoBehaviour // TypeDefIndex: 59417
	{
		// Fields
		private static List<CwRoot> instances; // 0x00
	
		// Properties
		public static bool Exists { get => default; } // 0x00000001878A7A44-0x00000001878A7AA4 
		public static Transform Root { get => default; } // 0x00000001878A7AA4-0x00000001878A7B50 
	
		// Constructors
		public CwRoot() {} // 0x000000018646DB20-0x000000018646DB28
		static CwRoot() {} // 0x00000001878A79B8-0x00000001878A7A44
	
		// Methods
		public static Transform GetRoot() => default; // 0x00000001878A7724-0x00000001878A782C
		protected virtual void OnEnable() {} // 0x00000001878A789C-0x00000001878A79B8
		protected virtual void OnDisable() {} // 0x00000001878A782C-0x00000001878A789C
	}

	public class CwSeedAttribute : PropertyAttribute // TypeDefIndex: 59418
	{
		// Constructors
		public CwSeedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class CwShared // TypeDefIndex: 59419
	{
		// Fields
		public const string HelpUrlPrefix = "https://carloswilkes.com/Documentation/Common#"; // Metadata: 0x02080BA2
		public const string ComponentMenuPrefix = "Common/CW "; // Metadata: 0x02080BD1
		public const string GameObjectMenuPrefix = "GameObject/CW/Common/"; // Metadata: 0x02080BDC
	}

	public class CwGuide : ScriptableObject // TypeDefIndex: 59420
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
		public Texture2D Icon { get => default; } // 0x00000001878A2700-0x00000001878A27E4 
		public string Version { get => default; } // 0x00000001878A27E4-0x00000001878A28E0 
	
		// Constructors
		public CwGuide() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	}

	public static class CwHelper // TypeDefIndex: 59422
	{
		// Fields
		private static Stack<UnityEngine.Random.State> seedStates; // 0x00
		public static List<Material> tempMaterials; // 0x08
		public static List<MaterialPropertyBlock> tempProperties; // 0x10
		private static Action<Camera> OnCameraPreRender; // 0x18
		private static Action<Camera> OnCameraPostRender; // 0x20
		private static Stack<RenderTexture> actives; // 0x28
		private static int uniqueSeed; // 0x30
		private static List<Material> materials; // 0x38
	
		// Events
		public static event Action<Camera> OnCameraPreRender;
		public static event Action<Camera> OnCameraPostRender;
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 59421
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x00000001878A49C8-0x00000001878A4A90
			public __c() {} // 0x00000001878A4B58-0x00000001878A4C20
	
			// Methods
			internal void _.cctor_b__11_0(Camera camera) {} // 0x00000001878A4900-0x00000001878A49C8
			internal void _.cctor_b__11_1(Camera camera) {} // 0x00000001878A4A90-0x00000001878A4B58
			internal void _.cctor_b__11_2(ScriptableRenderContext context, Camera camera) {} // 0x00000001878A442C-0x00000001878A4900
			internal void _.cctor_b__11_3(ScriptableRenderContext context, Camera camera) {}
		}
	
		// Constructors
		static CwHelper() {} // 0x00000001878A3450-0x00000001878A34B4
	
		// Methods
		public static T GetOrAddComponent<T>(GameObject gameObject, bool recordUndo = true /* Metadata: 0x02080BF2 */)
			where T : Component => default; // 0x00000001878A2D2C-0x00000001878A2DB0
		public static T AddComponent<T>(GameObject gameObject, bool recordUndo = true /* Metadata: 0x02080BF3 */)
			where T : Component => default; // 0x00000001878A2C94-0x00000001878A2D2C
		public static bool IndexInMask(int index, int mask) => default; // 0x00000001878A3524-0x00000001878A35A8
		public static Camera GetCamera(Camera currentCamera, GameObject gameObject = null) => default; // 0x00000001878A2DB0-0x00000001878A2E60
		public static Vector3 GetObserverPosition(Transform observer) => default; // 0x0000000185FB3680-0x0000000185FB36C0
		public static bool Enabled(UnityEngine.Behaviour b) => default; // 0x00000001878A3E64-0x00000001878A3E90
		public static void BeginSeed() {} // 0x00000001878A3E90-0x00000001878A3F20
		public static void BeginSeed(int newSeed) {}
		public static void EndSeed() {} // 0x00000001878A429C-0x00000001878A42E8
		public static UnityEngine.Color Brighten(UnityEngine.Color color, float brightness, bool convertToGamma = true /* Metadata: 0x02080BF4 */) => default; // 0x00000001878A4360-0x00000001878A43A4
		public static UnityEngine.Color Premultiply(UnityEngine.Color color) => default; // 0x00000001878A43A4-0x00000001878A43D8
		public static float Saturate(float c) => default; // 0x00000001878A431C-0x00000001878A4360
		public static UnityEngine.Color Saturate(UnityEngine.Color c) => default; // 0x00000001878A42E8-0x00000001878A431C
		public static void Resize<T>(List<T> list, int size) {} // 0x00000001878A43D8-0x00000001878A442C
		public static float Sharpness(float a, float p) => default; // 0x00000001878A2C08-0x00000001878A2C94
		public static UnityEngine.Color ToLinear(UnityEngine.Color gamma) => default; // 0x00000001878A34B4-0x00000001878A3524
		public static float ToLinear(float gamma) => default; // 0x00000001878A3F20-0x00000001878A3FEC
		public static UnityEngine.Color ToGamma(UnityEngine.Color linear) => default; // 0x00000001878A3FEC-0x00000001878A40F0
		public static float ToGamma(float linear) => default; // 0x00000001878A40F0-0x00000001878A41D0
		public static float UniformScale(Vector3 scale) => default; // 0x00000001878A41D0-0x00000001878A429C
		public static void BeginActive(RenderTexture renderTexture) {} // 0x00000001878A29B8-0x00000001878A2C08
		public static void EndActive() {} // 0x00000001878A3BE0-0x00000001878A3E64
		public static void SetTempMaterial(Material material) {} // 0x00000001878A39E8-0x00000001878A3BE0
		public static void SetTempMaterial(Material material1, Material material2) {} // 0x00000001878A32AC-0x00000001878A3368
		public static void SetTempMaterial(List<Material> materials) {} // 0x00000001878A314C-0x00000001878A3220
		public static void SetTempMaterial(MaterialPropertyBlock properties) {} // 0x00000001878A3220-0x00000001878A32AC
		public static void AddMaterial(Renderer r, Material m) {} // 0x00000001878A30C0-0x00000001878A314C
		public static void ReplaceMaterial(Renderer r, Material m) {}
		public static void RemoveMaterial(Renderer r, Material m) {} // 0x00000001878A2FB8-0x00000001878A30C0
		public static Texture2D CreateTempTexture2D(string name, int width, int height, TextureFormat format = TextureFormat.ARGB32 /* Metadata: 0x02080BF5 */, bool mips = false /* Metadata: 0x02080BF6 */, bool linear = false /* Metadata: 0x02080BF7 */) => default; // 0x00000001878A2E60-0x00000001878A2FB8
		public static Material CreateTempMaterial(string materialName, string shaderName) => default;
		public static Material CreateTempMaterial(string materialName, Shader shader) => default; // 0x00000001878A39B0-0x00000001878A39CC
		public static Material CreateTempMaterial(string materialName, Material source) => default; // 0x00000001878A39CC-0x00000001878A39E8
		public static T Destroy<T>(T o)
			where T : UnityEngine.Object => default; // 0x00000001878A3428-0x00000001878A343C
		public static GameObject CreateGameObject(string name, int layer, Transform parent = null, string recordUndo = null) => default; // 0x00000001878A343C-0x00000001878A3450
		public static GameObject CreateGameObject(string name, int layer, Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale, string recordUndo = null) => default; // 0x00000001878A294C-0x00000001878A29B8
		public static T CreateElement<T>(Transform parent)
			where T : Component => default; // 0x00000001878A28E0-0x00000001878A294C
		public static float Reciprocal(float v) => default; // 0x00000001878A33E0-0x00000001878A3428
		public static double Reciprocal(double v) => default; // 0x00000001878A3368-0x00000001878A33E0
		public static float Divide(float a, float b) => default; // 0x0000000185FB3660-0x0000000185FB3680
		public static double Divide(double a, double b) => default; // 0x00000001878A3974-0x00000001878A3988
		public static float Acos(float v) => default; // 0x00000001878A3988-0x00000001878A39B0
		public static double Acos(double v) => default; // 0x00000001878A3738-0x00000001878A3964
		public static float DampenFactor(float speed, float elapsed) => default; // 0x00000001878A84AC-0x00000001878A8510
		public static float DampenFactor(float damping, float deltaTime, float linear) => default; // 0x0000000185492010-0x0000000185492020
		public static float Atan2(Vector2 xy) => default; // 0x00000001878A82BC-0x00000001878A8338
		public static int Mod(int a, int b) => default; // 0x00000001878A8338-0x00000001878A83B4
		public static float Mod(float a, float b) => default; // 0x00000001878A83B4-0x00000001878A8430
		public static Texture2D GetReadableCopy(Texture texture, TextureFormat format = TextureFormat.ARGB32 /* Metadata: 0x02080BF8 */, bool mipMaps = false /* Metadata: 0x02080BF9 */, int width = 0 /* Metadata: 0x02080BFA */, int height = 0 /* Metadata: 0x02080BFB */) => default; // 0x00000001878A8430-0x00000001878A84AC
	}

	public static class CwInput // TypeDefIndex: 59423
	{
		// Fields
		private static Dictionary<KeyCode, UnityEngine.InputSystem.Key> keyMapping; // 0x00
	
		// Constructors
		static CwInput() {} // 0x00000001856F0A50-0x00000001856F1870
	
		// Methods
		private static void Enable() {} // 0x0000000184111660-0x0000000184111670
		private static ButtonControl GetMouseButtonControl(int index) => default; // 0x00000001878A7078-0x00000001878A7110
		private static ButtonControl GetButtonControl(KeyCode oldKey) => default; // 0x00000001878A6E1C-0x00000001878A6F68
		public static int GetTouchCount() => default; // 0x00000001878A72F4-0x00000001878A7358
		public static void GetTouch(int index, out int id, out Vector2 position, out float pressure, out bool set) {
			id = default;
			position = default;
			pressure = default;
			set = default;
		} // 0x00000001878A7358-0x00000001878A7494
		public static Vector2 GetMousePosition() => default; // 0x00000001878A7178-0x00000001878A71D8
		public static bool GetKeyWentDown(KeyCode oldKey) => default; // 0x00000001878A6FBC-0x00000001878A7010
		public static bool GetKeyIsHeld(KeyCode oldKey) => default; // 0x00000001878A6F68-0x00000001878A6FBC
		public static bool GetKeyWentUp(KeyCode oldKey) => default; // 0x00000001878A7010-0x00000001878A7064
		public static bool GetMouseWentDown(int index) => default; // 0x00000001878A71D8-0x00000001878A722C
		public static bool GetMouseIsHeld(int index) => default; // 0x00000001878A7124-0x00000001878A7178
		public static bool GetMouseWentUp(int index) => default; // 0x00000001878A722C-0x00000001878A7280
		public static float GetMouseWheelDelta() => default; // 0x00000001878A7280-0x00000001878A72F4
		public static bool GetMouseExists() => default; // 0x00000001878A7110-0x00000001878A7124
		public static bool GetKeyboardExists() => default; // 0x00000001878A7064-0x00000001878A7078
	}

	public class CwShaderBundle : ScriptableObject // TypeDefIndex: 59426
	{
		// Fields
		private string title; // 0x18
		private Shader target; // 0x20
		private int variantHash; // 0x28
		private int projectHash; // 0x2C
		private List<ShaderVariant> variants; // 0x30
	
		// Properties
		public string Title { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public Shader Target { get => default; set {} } // 0x0000000181C9AC80-0x0000000181C9AC90 0x0000000181C9A5C0-0x0000000181C9A5D0
		public int VariantHash { get => default; set {} } // 0x0000000185FB0630-0x0000000185FB0640 0x0000000185FB0640-0x0000000185FB0650
		public int ProjectHash { get => default; set {} } // 0x00000001878A7D54-0x00000001878A7E60 0x00000001878A7E60-0x00000001878A7EE4
		public List<ShaderVariant> Variants { get => default; } // 0x00000001878A7CB0-0x00000001878A7CF8 
		public bool Dirty { get => default; } // 0x00000001878A7C08-0x00000001878A7CB0 
	
		// Nested types
		public enum Pipeline // TypeDefIndex: 59424
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
		public class ShaderVariant // TypeDefIndex: 59425
		{
			// Fields
			public Pipeline Pipe; // 0x10
			public string Code; // 0x18
			public int Hash; // 0x20
			public bool Dirty; // 0x24
	
			// Properties
			public string HashString { get => default; } // 0x0000000184088E70-0x0000000184088E80 
	
			// Constructors
			public ShaderVariant() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		// Constructors
		public CwShaderBundle() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static int GetProjectHash() => default; // 0x00000001878A7D38-0x00000001878A7D40
		public static Pipeline DetectProjectPipeline() => default; // 0x00000001878A7D0C-0x00000001878A7D38
		public static bool IsStandard(Pipeline pipe) => default; // 0x00000001878A7D40-0x00000001878A7D54
		public static bool IsScriptable(Pipeline pipe) => default; // 0x00000001878A7CF8-0x00000001878A7D0C
		public static bool IsURP(Pipeline pipe) => default; // 0x0000000184BBD7B0-0x0000000184BBD7C0
		public static bool IsHDRP(Pipeline pipe) => default; // 0x00000001878A8060-0x00000001878A80BC
	}
}
