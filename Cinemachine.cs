/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Beyond.Gameplay.Core;
using Cinemachine;
using Cinemachine.Utility;
using ClipperLib;
using HG.Rendering.Runtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.Timeline;
using UnityEngine.UI;

// Image 34: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 54349-54552
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("com.unity.cinemachine.editor")]
[assembly: InternalsVisibleTo("com.unity.cinemachine.Tests")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[AddComponentMenu("")]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/api/Cinemachine.CinemachineCameraOffset.html")]
[SaveDuringPlay]
public class CinemachineCameraOffset : CinemachineExtension // TypeDefIndex: 54350
{
	// Fields
	[Tooltip("Offset the camera\'s position by this much (camera space)")]
	public Vector3 m_Offset; // 0x28
	[Tooltip("When to apply the offset")]
	public CinemachineCore.Stage m_ApplyAfter; // 0x34
	[Tooltip("If applying offset after aim, re-adjust the aim to preserve the screen position of the LookAt target as much as possible")]
	public bool m_PreserveComposition; // 0x38

	// Constructors
	public CinemachineCameraOffset() {} // 0x000000018554B724-0x000000018554B748

	// Methods
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x000000018554B3FC-0x000000018554B724
}

[AddComponentMenu("")]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineRecomposer.html")]
[SaveDuringPlay]
public class CinemachineRecomposer : CinemachineExtension // TypeDefIndex: 54351
{
	// Fields
	[Tooltip("When to apply the adjustment")]
	public CinemachineCore.Stage m_ApplyAfter; // 0x28
	[Tooltip("Tilt the camera by this much")]
	public float m_Tilt; // 0x2C
	[Tooltip("Pan the camera by this much")]
	public float m_Pan; // 0x30
	[Tooltip("Roll the camera by this much")]
	public float m_Dutch; // 0x34
	[Tooltip("Scale the zoom by this amount (normal = 1)")]
	public float m_ZoomScale; // 0x38
	[Range(0f, 1f)]
	[Tooltip("Lowering this value relaxes the camera\'s attention to the Follow target (normal = 1)")]
	public float m_FollowAttachment; // 0x3C
	[Range(0f, 1f)]
	[Tooltip("Lowering this value relaxes the camera\'s attention to the LookAt target (normal = 1)")]
	public float m_LookAtAttachment; // 0x40

	// Constructors
	public CinemachineRecomposer() {} // 0x000000018426FE60-0x000000018426FE68

	// Methods
	private void Reset() {} // 0x0000000183D50400-0x0000000183D50430
	private void OnValidate() {} // 0x0000000185557980-0x00000001855579BC
	public override void PrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState curState, float deltaTime) {} // 0x00000001833417D0-0x0000000183341800
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x0000000182744A90-0x0000000182744D10
}

public static class CinemachineBeyondCommunicator // TypeDefIndex: 54352
{
	// Properties
	public static Func<CinemachineVirtualCameraBase> GetLevelCamera { get; set; } // 0x00000001855491E4-0x000000018554921C 0x000000018554921C-0x000000018554926C
}

public class CinemachineTouchInputMapper : MonoBehaviour // TypeDefIndex: 54353
{
	// Fields
	[Tooltip("Sensitivity multiplier for x-axis")]
	public float TouchSensitivityX; // 0x18
	[Tooltip("Sensitivity multiplier for y-axis")]
	public float TouchSensitivityY; // 0x1C
	[Tooltip("Input channel to spoof for X axis")]
	public string TouchXInputMapTo; // 0x20
	[Tooltip("Input channel to spoof for Y axis")]
	public string TouchYInputMapTo; // 0x28

	// Constructors
	public CinemachineTouchInputMapper() {} // 0x0000000185558014-0x0000000185558088

	// Methods
	private void Start() {} // 0x0000000185557F64-0x0000000185558014
	private float GetInputAxis(string axisName) => default; // 0x0000000185557EC4-0x0000000185557F64
}

internal sealed class CinemachineMixer : PlayableBehaviour // TypeDefIndex: 54354
{
	// Fields
	private CinemachineBrain mBrain; // 0x10
	private int mBrainOverrideId; // 0x18
	private bool mPreviewPlay; // 0x1C

	// Constructors
	public CinemachineMixer() {} // 0x0000000183D50330-0x0000000183D50340

	// Methods
	public override void OnPlayableDestroy(Playable playable) {} // 0x0000000185555914-0x0000000185555988
	public override void PrepareFrame(Playable playable, FrameData info) {} // 0x0000000183D50320-0x0000000183D50330
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x0000000185555988-0x0000000185555F54
	private float GetDeltaTime(float deltaTime) => default; // 0x00000001855558C4-0x0000000185555914
}

public sealed class CinemachineShot : PlayableAsset, IPropertyPreview, ITimelineClipAsset // TypeDefIndex: 54355
{
	// Fields
	[SerializeField]
	public bool DisableEvaluateTwiceWhenEnabled; // 0x18
	public bool UseVcamBeforeTimeline; // 0x19
	public bool UseLevelCamera; // 0x1A
	public string DisplayName; // 0x20
	public ExposedReference<CinemachineVirtualCameraBase> VirtualCamera; // 0x28

	// Properties
	public ClipCaps clipCaps { get => default; } // 0x0000000185557EB0-0x0000000185557EC4 

	// Constructors
	public CinemachineShot() {} // 0x000000018286F540-0x000000018286F550

	// Methods
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x0000000185557A0C-0x0000000185557D14
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver) {} // 0x0000000185557D14-0x0000000185557EB0
}

internal sealed class CinemachineShotPlayable : PlayableBehaviour // TypeDefIndex: 54356
{
	// Fields
	public CinemachineVirtualCameraBase VirtualCamera; // 0x10

	// Properties
	public bool IsValid { get => default; } // 0x00000001855579BC-0x0000000185557A0C 

	// Constructors
	public CinemachineShotPlayable() {} // 0x000000018350B670-0x000000018350B680
}

[Serializable]
[DontAutoBind]
[SupportsChildTracks(null, 2147483647)]
[TrackBindingType(typeof(CinemachineBrain), TrackBindingFlags.None)]
[TrackClipType(typeof(CinemachineShot))]
[TrackColor(0.53f, 0f, 0.08f)]
public class CinemachineTrack : TrackAsset // TypeDefIndex: 54357
{
	// Constructors
	public CinemachineTrack() {} // 0x0000000185558168-0x00000001855581B4

	// Methods
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) => default; // 0x0000000185558088-0x0000000185558168
}

namespace Cinemachine
{
	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[SaveDuringPlay]
	public class Cinemachine3rdPersonAim : CinemachineExtension // TypeDefIndex: 54358
	{
		// Fields
		[Header("Aim Target Detection")]
		[Tooltip("Objects on these layers will be detected")]
		public LayerMask AimCollisionFilter; // 0x28
		[TagField]
		[Tooltip("Objects with this tag will be ignored.  It is a good idea to set this field to the target\'s tag")]
		public string IgnoreTag; // 0x30
		[Tooltip("How far to project the object detection ray")]
		public float AimDistance; // 0x38
		[Tooltip("This 2D object will be positioned in the game view over the raycast hit point, if any, or will remain in the center of the screen if no hit point is detected.  May be null, in which case no on-screen indicator will appear")]
		public RectTransform AimTargetReticle; // 0x40
	
		// Properties
		private Vector3 AimTarget { get; set; } // 0x0000000183D50020-0x0000000183D50040 0x0000000183D50040-0x0000000183D50050
	
		// Constructors
		public Cinemachine3rdPersonAim() {} // 0x0000000185549190-0x00000001855491E4
	
		// Methods
		private void OnValidate() {} // 0x0000000185548F0C-0x0000000185548F24
		private void Reset() {} // 0x000000018554912C-0x0000000185549190
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) => default; // 0x0000000185548DE0-0x0000000185548F0C
		private void DrawReticle(CinemachineBrain brain) {} // 0x0000000185548C24-0x0000000185548DE0
		private Vector3 ComputeLookAtPoint(Vector3 camPos, Transform player) => default; // 0x0000000185548920-0x0000000185548C24
		private Vector3 ComputeAimTarget(Vector3 cameraLookAt, Transform player) => default; // 0x0000000185548794-0x0000000185548920
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x0000000185548F24-0x000000018554912C
	}

	[AddComponentMenu("Cinemachine/CinemachineBlendListCamera")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExcludeFromPreset]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineBlendListCamera.html")]
	public class CinemachineBlendListCamera : CinemachineVirtualCameraBase // TypeDefIndex: 54360
	{
		// Fields
		[NoSaveDuringPlay]
		[Tooltip("Default object for the camera children to look at (the aim target), if not specified in a child camera.  May be empty if all of the children define targets of their own.")]
		[VcamTargetProperty]
		public Transform m_LookAt; // 0xA8
		[NoSaveDuringPlay]
		[Tooltip("Default object for the camera children wants to move with (the body target), if not specified in a child camera.  May be empty if all of the children define targets of their own.")]
		[VcamTargetProperty]
		public Transform m_Follow; // 0xB0
		[Tooltip("When enabled, the current child camera and blend will be indicated in the game window, for debugging")]
		public bool m_ShowDebugText; // 0xB8
		[Tooltip("When enabled, the child vcams will cycle indefinitely instead of just stopping at the last one")]
		public bool m_Loop; // 0xB9
		[HideInInspector]
		[NoSaveDuringPlay]
		[SerializeField]
		internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0xC0
		[Tooltip("The set of instructions for enabling child cameras.")]
		public Instruction[] m_Instructions; // 0xC8
		private ICinemachineCamera m_TransitioningFrom; // 0xD8
		private CameraState m_State; // 0xE0
		private float mActivationTime; // 0x200
		private int mCurrentInstruction; // 0x204
		private CinemachineBlend mActiveBlend; // 0x208
	
		// Properties
		public override string Description { get => default; } // 0x000000018554A6C8-0x000000018554A7B4 
		public ICinemachineCamera LiveChild { get; set; } // 0x0000000183D50050-0x0000000183D50060 0x000000018554A7E0-0x000000018554A7F4
		public override CameraState State { get => default; } // 0x0000000183D50060-0x0000000183D500E0 
		public override Transform LookAt { get => default; set {} } // 0x000000018554A7D0-0x000000018554A7E0 0x000000018554A7F4-0x000000018554A808
		public override Transform Follow { get => default; set {} } // 0x000000018554A7B4-0x000000018554A7C4 0x0000000182B47080-0x0000000182B470A0
		public CinemachineVirtualCameraBase[] ChildCameras { get => default; } // 0x000000018554A6A8-0x000000018554A6C8 
		public bool IsBlending { get => default; } // 0x000000018554A7C4-0x000000018554A7D0 
	
		// Nested types
		[Serializable]
		public struct Instruction // TypeDefIndex: 54359
		{
			// Fields
			[Tooltip("The virtual camera to activate when this instruction becomes active")]
			public CinemachineVirtualCameraBase m_VirtualCamera; // 0x00
			[Tooltip("How long to wait (in seconds) before activating the next virtual camera in the list (if any)")]
			public float m_Hold; // 0x08
			[CinemachineBlendDefinitionProperty]
			[Tooltip("How to blend to the next virtual camera in the list (if any)")]
			public CinemachineBlendDefinition m_Blend; // 0x10
		}
	
		// Constructors
		public CinemachineBlendListCamera() {} // 0x000000018554A570-0x000000018554A6A8
	
		// Methods
		private void Reset() {} // 0x000000018554A1E8-0x000000018554A24C
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x01FD65EC */) => default; // 0x0000000185549B6C-0x0000000185549B94
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x0000000185549FF4-0x000000018554A0B8
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x0000000185549470-0x0000000185549550
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x000000018554A0C0-0x000000018554A1E8
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x0000000185549550-0x0000000185549B38
		protected override void OnEnable() {} // 0x0000000185549CAC-0x0000000185549EB0
		protected override void OnDisable() {} // 0x0000000185549B94-0x0000000185549CAC
		private void OnTransformChildrenChanged() {} // 0x000000018554A0B8-0x000000018554A0C0
		private void OnGuiHandler() {} // 0x0000000185549EB0-0x0000000185549FF4
		private void InvalidateListOfChildren() {} // 0x0000000185549B38-0x0000000185549B6C
		private void UpdateListOfChildren() {} // 0x000000018554A24C-0x000000018554A3EC
		internal void ValidateInstructions() {} // 0x000000018554A3EC-0x000000018554A570
		private void AdvanceCurrentInstruction(float deltaTime) {} // 0x000000018554926C-0x0000000185549470
	}

	[AddComponentMenu("Cinemachine/CinemachineBrain")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineBrainProperties.html")]
	[SaveDuringPlay]
	public class CinemachineBrain : MonoBehaviour // TypeDefIndex: 54367
	{
		// Fields
		[Tooltip("When enabled, the current camera and blend will be indicated in the game window, for debugging")]
		public bool m_ShowDebugText; // 0x18
		[Tooltip("When enabled, the camera\'s frustum will be shown at all times in the scene view")]
		public bool m_ShowCameraFrustum; // 0x19
		[Tooltip("When enabled, the cameras will always respond in real-time to user input and damping, even if the game is running in slow motion")]
		public bool m_IgnoreTimeScale; // 0x1A
		[Tooltip("If set, this object\'s Y axis will define the worldspace Up vector for all the virtual cameras.  This is useful for instance in top-down game environments.  If not set, Up is worldspace Y.  Setting this appropriately is important, because Virtual Cameras don\'t like looking straight up or straight down.")]
		public Transform m_WorldUpOverride; // 0x20
		[Tooltip("The update time for the vcams.  Use FixedUpdate if all your targets are animated during FixedUpdate (e.g. RigidBodies), LateUpdate if all your targets are animated during the normal Update loop, and SmartUpdate if you want Cinemachine to do the appropriate thing on a per-target basis.  SmartUpdate is the recommended setting")]
		public UpdateMethod m_UpdateMethod; // 0x28
		[Tooltip("The update time for the Brain, i.e. when the blends are evaluated and the brain\'s transform is updated")]
		public BrainUpdateMethod m_BlendUpdateMethod; // 0x2C
		[CinemachineBlendDefinitionProperty]
		[Tooltip("The blend that is used in cases where you haven\'t explicitly defined a blend between two Virtual Cameras")]
		public CinemachineBlendDefinition m_DefaultBlend; // 0x30
		[Tooltip("This is the asset that contains custom settings for blends between specific virtual cameras in your scene")]
		public CinemachineBlenderSettings m_CustomBlends; // 0x48
		private Camera m_OutputCamera; // 0x50
		private HGDepthOfField m_OutputDOF; // 0x58
		[Tooltip("This event will fire whenever a virtual camera goes live and there is no blend")]
		public BrainEvent m_CameraCutEvent; // 0x60
		[Tooltip("This event will fire whenever a virtual camera goes live.  If a blend is involved, then the event will fire on the first frame of the blend.")]
		public VcamActivatedEvent m_CameraActivatedEvent; // 0x68
		private static ICinemachineCamera mSoloCamera; // 0x00
		private Coroutine mPhysicsCoroutine; // 0x70
		private int m_LastFrameUpdated; // 0x78
		private WaitForFixedUpdate mWaitForFixedUpdate; // 0x80
		private List<BrainFrame> mFrameStack; // 0x88
		private int mNextFrameId; // 0x90
		private CinemachineBlend mCurrentLiveCameras; // 0x98
		private static readonly AnimationCurve mDefaultLinearAnimationCurve; // 0x08
		private ICinemachineCamera mActiveCameraPreviousFrame; // 0xA0
		private GameObject mActiveCameraPreviousFrameGameObject; // 0xA8
	
		// Properties
		public Camera OutputCamera { get => default; } // 0x000000018274AEA0-0x000000018274AFC0 
		public HGDepthOfField OutputDOF { get => default; } // 0x000000018274CFA0-0x000000018274D0C0 
		public static ICinemachineCamera SoloCamera { get => default; set {} } // 0x000000018554B244-0x000000018554B294 0x000000018554B30C-0x000000018554B3FC
		public Vector3 DefaultWorldUp { get => default; } // 0x000000018274AD70-0x000000018274AEA0 
		public ICinemachineCamera ActiveVirtualCamera { get => default; } // 0x000000018274B6E0-0x000000018274B820 
		public bool IsBlending { get => default; } // 0x000000018274C110-0x000000018274C180 
		public CinemachineBlend ActiveBlend { get => default; } // 0x000000018274B590-0x000000018274B600 
		public CameraState CurrentCameraState { get; private set; } // 0x0000000183D500E0-0x0000000183D50160 0x000000018554B294-0x000000018554B30C
	
		// Nested types
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum UpdateMethod // TypeDefIndex: 54361
		{
			FixedUpdate = 0,
			LateUpdate = 1,
			SmartUpdate = 2,
			ManualUpdate = 3
		}
	
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum BrainUpdateMethod // TypeDefIndex: 54362
		{
			FixedUpdate = 0,
			LateUpdate = 1
		}
	
		[Serializable]
		public class BrainEvent : UnityEvent<CinemachineBrain> // TypeDefIndex: 54363
		{
			// Constructors
			public BrainEvent() {} // 0x00000001831718F0-0x0000000183171930
		}
	
		[Serializable]
		public class VcamActivatedEvent : UnityEvent<ICinemachineCamera, ICinemachineCamera> // TypeDefIndex: 54364
		{
			// Constructors
			public VcamActivatedEvent() {} // 0x0000000183171930-0x0000000183171970
		}
	
		private class BrainFrame // TypeDefIndex: 54365
		{
			// Fields
			public int id; // 0x10
			public CinemachineBlend blend; // 0x18
			public CinemachineBlend workingBlend; // 0x20
			public BlendSourceVirtualCamera workingBlendSource; // 0x28
			public float deltaTimeOverride; // 0x30
	
			// Properties
			public bool Active { get => default; } // 0x0000000185548774-0x0000000185548794 
	
			// Constructors
			public BrainFrame() {} // 0x0000000183171970-0x0000000183171A90
		}
	
		// Constructors
		public CinemachineBrain() {} // 0x0000000183171500-0x00000001831716F0
		static CinemachineBrain() {} // 0x0000000183D02A80-0x0000000183D02AF0
	
		// Methods
		public static UnityEngine.Color GetSoloGUIColor() => default; // 0x000000018554A914-0x000000018554A970
		private void OnEnable() {} // 0x0000000183170450-0x0000000183170830
		private void OnDisable() {} // 0x000000018554AA38-0x000000018554AC68
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode) {} // 0x000000018554AF28-0x000000018554AF8C
		private void OnSceneUnloaded(Scene scene) {} // 0x0000000183D44A60-0x0000000183D44AA0
		private void Start() {} // 0x0000000183D4C3C0-0x0000000183D4C3E0
		private void OnGuiHandler() {} // 0x000000018554AC68-0x000000018554AF28
		[IteratorStateMachine(typeof(_AfterPhysics_d__36))]
		private IEnumerator AfterPhysics() => default; // 0x0000000183170830-0x0000000183170890
		private void LateUpdate() {} // 0x00000001833E09D0-0x00000001833E09F0
		public void ManualUpdate(float deltaTime = -1f /* Metadata: 0x01FD65ED */) {} // 0x000000018274D5E0-0x000000018274D7C0
		private float GetEffectiveDeltaTime(bool fixedDelta) => default; // 0x000000018274DF40-0x000000018274E040
		private void UpdateVirtualCameras(CinemachineCore.UpdateFilter updateFilter, float deltaTime) {} // 0x000000018274A9C0-0x000000018274AC70
		private static ICinemachineCamera DeepCamBFromBlend(CinemachineBlend blend) => default; // 0x000000018274B820-0x000000018274BA10
		public bool IsLiveInBlend(ICinemachineCamera vcam) => default; // 0x000000018554A970-0x000000018554AA38
		private int GetBrainFrame(int withId) => default; // 0x000000018554A808-0x000000018554A914
		public int SetCameraOverride(int overrideId, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime) => default; // 0x000000018554B044-0x000000018554B244
		public void ReleaseCameraOverride(int overrideId) {} // 0x000000018554AF8C-0x000000018554B044
		private void ProcessActiveCamera(float deltaTime) {} // 0x000000018274C180-0x000000018274C6C0
		private void UpdateFrame0(float deltaTime) {} // 0x000000018274D7C0-0x000000018274DAF0
		public void ComputeCurrentBlend(ref CinemachineBlend outputBlend, int numTopLayersToExclude) {} // 0x000000018274DAF0-0x000000018274DE20
		public bool IsLive(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x01FD65F1 */) => default; // 0x000000018274B600-0x000000018274B6E0
		public ICinemachineCamera TopCameraFromPriorityQueue() => default; // 0x000000018274A2C0-0x000000018274A8E0
		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey) => default; // 0x000000018332D8C0-0x000000018332DBF0
		private void PushStateToUnityCamera(ref CameraState state) {} // 0x000000018274C7D0-0x000000018274CFA0
	}

	[AddComponentMenu("Cinemachine/CinemachineClearShot")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExcludeFromPreset]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineClearShot.html")]
	public class CinemachineClearShot : CinemachineVirtualCameraBase // TypeDefIndex: 54370
	{
		// Fields
		[NoSaveDuringPlay]
		[Tooltip("Default object for the camera children to look at (the aim target), if not specified in a child camera.  May be empty if all children specify targets of their own.")]
		[VcamTargetProperty]
		public Transform m_LookAt; // 0xA8
		[NoSaveDuringPlay]
		[Tooltip("Default object for the camera children wants to move with (the body target), if not specified in a child camera.  May be empty if all children specify targets of their own.")]
		[VcamTargetProperty]
		public Transform m_Follow; // 0xB0
		[NoSaveDuringPlay]
		[Tooltip("When enabled, the current child camera and blend will be indicated in the game window, for debugging")]
		public bool m_ShowDebugText; // 0xB8
		[HideInInspector]
		[NoSaveDuringPlay]
		[SerializeField]
		internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0xC0
		[Tooltip("Wait this many seconds before activating a new child camera")]
		public float m_ActivateAfter; // 0xC8
		[Tooltip("An active camera must be active for at least this many seconds")]
		public float m_MinDuration; // 0xCC
		[Tooltip("If checked, camera choice will be randomized if multiple cameras are equally desirable.  Otherwise, child list order and child camera priority will be used.")]
		public bool m_RandomizeChoice; // 0xD0
		[CinemachineBlendDefinitionProperty]
		[Tooltip("The blend which is used if you don\'t explicitly define a blend between two Virtual Cameras")]
		public CinemachineBlendDefinition m_DefaultBlend; // 0xD8
		[HideInInspector]
		public CinemachineBlenderSettings m_CustomBlends; // 0xF0
		private CameraState m_State; // 0x100
		private float mActivationTime; // 0x220
		private float mPendingActivationTime; // 0x224
		private ICinemachineCamera mPendingCamera; // 0x228
		private CinemachineBlend mActiveBlend; // 0x230
		private bool mRandomizeNow; // 0x238
		private CinemachineVirtualCameraBase[] m_RandomizedChilden; // 0x240
		private ICinemachineCamera m_TransitioningFrom; // 0x248
	
		// Properties
		public override string Description { get => default; } // 0x000000018554D1E8-0x000000018554D2D4 
		public ICinemachineCamera LiveChild { get; set; } // 0x0000000183D50160-0x0000000183D50170 0x000000018554D2E0-0x000000018554D2F4
		public override CameraState State { get => default; } // 0x0000000183D50170-0x0000000183D501F0 
		public override Transform LookAt { get => default; set {} } // 0x000000018554A7D0-0x000000018554A7E0 0x000000018554A7F4-0x000000018554A808
		public override Transform Follow { get => default; set {} } // 0x000000018554A7B4-0x000000018554A7C4 0x0000000182B47080-0x0000000182B470A0
		public bool IsBlending { get => default; } // 0x000000018554D2D4-0x000000018554D2E0 
		public CinemachineVirtualCameraBase[] ChildCameras { get => default; } // 0x000000018554D1C8-0x000000018554D1E8 
	
		// Nested types
		private struct Pair // TypeDefIndex: 54368
		{
			// Fields
			public int a; // 0x00
			public float b; // 0x04
		}
	
		// Constructors
		public CinemachineClearShot() {} // 0x000000018554D050-0x000000018554D1C8
	
		// Methods
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x01FD65F8 */) => default; // 0x000000018554C3E4-0x000000018554C40C
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x000000018554CA30-0x000000018554CAF4
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x000000018554BDC8-0x000000018554BEA8
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x000000018554BEA8-0x000000018554C39C
		protected override void OnEnable() {} // 0x000000018554C6FC-0x000000018554C8EC
		protected override void OnDisable() {} // 0x000000018554C5E4-0x000000018554C6FC
		public void OnTransformChildrenChanged() {} // 0x000000018554CAF4-0x000000018554CB14
		private void OnGuiHandler() {} // 0x000000018554C8EC-0x000000018554CA30
		private void InvalidateListOfChildren() {} // 0x000000018554C39C-0x000000018554C3E4
		public void ResetRandomization() {} // 0x000000018554CE44-0x000000018554CE70
		private void UpdateListOfChildren() {} // 0x000000018554CE70-0x000000018554D050
		private ICinemachineCamera ChooseCurrentCamera(Vector3 worldUp) => default; // 0x000000018554B748-0x000000018554BDC8
		private CinemachineVirtualCameraBase[] Randomize(CinemachineVirtualCameraBase[] src) => default; // 0x000000018554CC0C-0x000000018554CE44
		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey) => default; // 0x000000018554C40C-0x000000018554C5E4
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x000000018554CB14-0x000000018554CC0C
	}

	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineCollider.html")]
	[SaveDuringPlay]
	public class CinemachineCollider : CinemachineExtension // TypeDefIndex: 54373
	{
		// Fields
		[Header("Obstacle Detection")]
		[Tooltip("Objects on these layers will be detected")]
		public LayerMask m_CollideAgainst; // 0x28
		[TagField]
		[Tooltip("Obstacles with this tag will be ignored.  It is a good idea to set this field to the target\'s tag")]
		public string m_IgnoreTag; // 0x30
		[Tooltip("Objects on these layers will never obstruct view of the target")]
		public LayerMask m_TransparentLayers; // 0x38
		[Tooltip("Obstacles closer to the target than this will be ignored")]
		public float m_MinimumDistanceFromTarget; // 0x3C
		[FormerlySerializedAs("m_PreserveLineOfSight")]
		[Space]
		[Tooltip("When enabled, will attempt to resolve situations where the line of sight to the target is blocked by an obstacle")]
		public bool m_AvoidObstacles; // 0x40
		[FormerlySerializedAs("m_LineOfSightFeelerDistance")]
		[Tooltip("The maximum raycast distance when checking if the line of sight to this camera\'s target is clear.  If the setting is 0 or less, the current actual distance to target will be used.")]
		public float m_DistanceLimit; // 0x44
		[Tooltip("Don\'t take action unless occlusion has lasted at least this long.")]
		public float m_MinimumOcclusionTime; // 0x48
		[Tooltip("Camera will try to maintain this distance from any obstacle.  Try to keep this value small.  Increase it if you are seeing inside obstacles due to a large FOV on the camera.")]
		public float m_CameraRadius; // 0x4C
		[Tooltip("The way in which the Collider will attempt to preserve sight of the target.")]
		public ResolutionStrategy m_Strategy; // 0x50
		[Tooltip("Use Follow instead of LookAt to detect collision")]
		public bool m_UseFollowInsteadOfLookAt; // 0x54
		[Range(1f, 10f)]
		[Tooltip("Upper limit on how many obstacle hits to process.  Higher numbers may impact performance.  In most environments, 4 is enough.")]
		public int m_MaximumEffort; // 0x58
		[Range(0f, 2f)]
		[Tooltip("Smoothing to apply to obstruction resolution.  Nearest camera point is held for at least this long")]
		public float m_SmoothingTime; // 0x5C
		[FormerlySerializedAs("m_Smoothing")]
		[Range(0f, 10f)]
		[Tooltip("How gradually the camera returns to its normal position after having been corrected.  Higher numbers will move the camera more gradually back to normal.")]
		public float m_Damping; // 0x60
		[Range(0f, 10f)]
		[Tooltip("How gradually the camera moves to resolve an occlusion.  Higher numbers will move the camera more gradually.")]
		public float m_DampingWhenOccluded; // 0x64
		[Header("Shot Evaluation")]
		[Tooltip("If greater than zero, a higher score will be given to shots when the target is closer to this distance.  Set this to zero to disable this feature.")]
		public float m_OptimalTargetDistance; // 0x68
		private const float k_PrecisionSlush = 0.001f; // Metadata: 0x01FD65F9
		private RaycastHit[] m_CornerBuffer; // 0x70
		private const float k_AngleThreshold = 0.1f; // Metadata: 0x01FD65FD
		private static ECSColliderResultProxy[] s_ColliderBuffer; // 0x00
	
		// Properties
		public List<List<Vector3>> DebugPaths { get => default; } // 0x000000018554F3A0-0x000000018554F568 
	
		// Nested types
		public enum ResolutionStrategy // TypeDefIndex: 54371
		{
			PullCameraForward = 0,
			PreserveCameraHeight = 1,
			PreserveCameraDistance = 2
		}
	
		private class VcamExtraState // TypeDefIndex: 54372
		{
			// Fields
			public Vector3 previousDisplacement; // 0x10
			public float previousLookAt2DisplacedPosLen; // 0x1C
			public bool shouldPerformCollisionDamping; // 0x20
			public bool previousHitSomething; // 0x21
			public bool targetObscured; // 0x22
			public float occlusionStartTime; // 0x24
			public List<Vector3> debugResolutionPath; // 0x28
			private float m_SmoothedDistance; // 0x30
			private float m_SmoothedTime; // 0x34
	
			// Constructors
			public VcamExtraState() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void AddPointToDebugPath(Vector3 p) {} // 0x000000018350B670-0x000000018350B680
			public float ApplyDistanceSmoothing(float distance, float smoothingTime) => default; // 0x00000001827439E0-0x0000000182743A50
			public void UpdateDistanceSmoothing(float distance) {} // 0x0000000185558E3C-0x00000001855590F8
			public void ResetDistanceSmoothing(float smoothingTime) {} // 0x0000000182743AE0-0x0000000182743B50
		}
	
		// Constructors
		public CinemachineCollider() {} // 0x00000001839CB1C0-0x00000001839CB270
		static CinemachineCollider() {} // 0x0000000183D06980-0x0000000183D069F0
	
		// Methods
		public bool IsTargetObscured(ICinemachineCamera vcam) => default; // 0x000000018554E000-0x000000018554E058
		public bool CameraWasDisplaced(ICinemachineCamera vcam) => default; // 0x000000018554D2F4-0x000000018554D310
		public float GetCameraDisplacementDistance(ICinemachineCamera vcam) => default; // 0x000000018554D71C-0x000000018554D778
		private void OnValidate() {} // 0x000000018554E0A0-0x000000018554E0EC
		protected override void OnDestroy() {} // 0x000000018554E058-0x000000018554E0A0
		public override float GetMaxDampTime() => default; // 0x000000018554D778-0x000000018554D790
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x0000000182744D10-0x0000000182744DD0
		public void ResetExtraData(ICinemachineCamera vcam) {} // 0x000000018554E83C-0x000000018554E8DC
		public virtual void GuardedPostPipelineStageCallback(ICinemachineCamera vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x0000000182744DD0-0x00000001827455F0
		private Vector3 PreserveLineOfSight(ref CameraState state, ref VcamExtraState extra) => default; // 0x0000000182743480-0x0000000182743770
		private Vector3 PullCameraInFrontOfNearestObstacle(Vector3 cameraPos, Vector3 lookAtPos, int layerMask, ref RaycastHit hitInfo) => default; // 0x0000000182743770-0x00000001827439E0
		private Vector3 PushCameraBack(Vector3 currentPos, Vector3 pushDir, RaycastHit obstacle, Vector3 lookAtPos, Plane startPlane, float targetDistance, int iterations, ref VcamExtraState extra) => default; // 0x000000018554E0EC-0x000000018554E83C
		private bool GetWalkingDirection(Vector3 pos, Vector3 pushDir, RaycastHit obstacle, ref Vector3 outDir) => default; // 0x000000018554D8F4-0x000000018554E000
		private float GetPushBackDistance(Ray ray, Plane startPlane, float targetDistance, Vector3 lookAtPos) => default; // 0x000000018554D790-0x000000018554D8F4
		private static float ClampRayToBounds(Ray ray, float distance, Bounds bounds) => default; // 0x000000018554D310-0x000000018554D71C
		private Vector3 RespectCameraRadius(Vector3 cameraPos, Vector3 lookAtPos) => default; // 0x000000018554E8DC-0x000000018554F3A0
		private bool CheckForTargetObstructions([IsReadOnly] in CameraState state) => default; // 0x0000000182742CB0-0x0000000182743020
		private static bool IsTargetOffscreen([IsReadOnly] in CameraState state) => default; // 0x0000000182B24CC0-0x0000000182B25350
	}

	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineConfiner.html")]
	[SaveDuringPlay]
	public class CinemachineConfiner : CinemachineExtension // TypeDefIndex: 54376
	{
		// Fields
		[Tooltip("The confiner can operate using a 2D bounding shape or a 3D bounding volume")]
		public Mode m_ConfineMode; // 0x28
		[Tooltip("The volume within which the camera is to be contained")]
		public Collider m_BoundingVolume; // 0x30
		[Tooltip("The 2D shape within which the camera is to be contained")]
		public Collider2D m_BoundingShape2D; // 0x38
		private Collider2D m_BoundingShape2DCache; // 0x40
		[Tooltip("If camera is orthographic, screen edges will be confined to the volume.  If not checked, then only the camera center will be confined")]
		public bool m_ConfineScreenEdges; // 0x48
		[Range(0f, 10f)]
		[Tooltip("How gradually to return the camera to the bounding volume if it goes beyond the borders.  Higher numbers are more gradual.")]
		public float m_Damping; // 0x4C
		private List<List<Vector2>> m_pathCache; // 0x50
		private int m_pathTotalPointCount; // 0x58
	
		// Properties
		public bool IsValid { get => default; } // 0x0000000185550ED4-0x0000000185550FD4 
	
		// Nested types
		public enum Mode // TypeDefIndex: 54374
		{
			Confine2D = 0,
			Confine3D = 1
		}
	
		private class VcamExtraState // TypeDefIndex: 54375
		{
			// Fields
			public Vector3 m_previousDisplacement; // 0x10
			public float confinerDisplacement; // 0x1C
	
			// Constructors
			public VcamExtraState() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public CinemachineConfiner() {} // 0x0000000185550EC8-0x0000000185550ED4
	
		// Methods
		public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam) => default; // 0x000000018554FBCC-0x000000018554FBE8
		public float GetCameraDisplacementDistance(CinemachineVirtualCameraBase vcam) => default; // 0x00000001855506AC-0x0000000185550708
		private void OnValidate() {} // 0x0000000185550730-0x0000000185550740
		protected override void ConnectToVcam(bool connect) {} // 0x00000001855506A4-0x00000001855506AC
		public override float GetMaxDampTime() => default; // 0x0000000183D50200-0x0000000183D50210
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x0000000185550740-0x00000001855509D8
		public void InvalidatePathCache() {} // 0x0000000185550708-0x0000000185550730
		private bool ValidatePathCache() => default; // 0x00000001855509D8-0x0000000185550EC8
		private Vector3 ConfinePoint(Vector3 camPos) => default; // 0x000000018554FBE8-0x0000000185550060
		private Vector3 ConfineScreenEdges(CinemachineVirtualCameraBase vcam, ref CameraState state) => default; // 0x0000000185550060-0x00000001855506A4
	}

	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineConfiner2D.html")]
	[SaveDuringPlay]
	public class CinemachineConfiner2D : CinemachineExtension // TypeDefIndex: 54379
	{
		// Fields
		[Tooltip("The 2D shape within which the camera is to be contained.  Can be a 2D polygon or 2D composite collider.")]
		public Collider2D m_BoundingShape2D; // 0x28
		[Range(0f, 5f)]
		[Tooltip("Damping applied around corners to avoid jumps.  Higher numbers are more gradual.")]
		public float m_Damping; // 0x30
		[Tooltip("To optimize computation and memory costs, set this to the largest view size that the camera is expected to have.  The confiner will not compute a polygon cache for frustum sizes larger than this.  This refers to the size in world units of the frustum at the confiner plane (for orthographic cameras, this is just the orthographic size).  If set to 0, then this parameter is ignored and a polygon cache will be calculated for all potential window sizes.")]
		public float m_MaxWindowSize; // 0x34
		private float m_MaxComputationTimePerFrameInSeconds; // 0x38
		private const float k_cornerAngleTreshold = 10f; // Metadata: 0x01FD6606
		private ShapeCache m_shapeCache; // 0x40
	
		// Nested types
		private class VcamExtraState // TypeDefIndex: 54377
		{
			// Fields
			public Vector3 m_PreviousDisplacement; // 0x10
			public Vector3 m_DampedDisplacement; // 0x1C
			public ConfinerOven.BakedSolution m_BakedSolution; // 0x28
			public CinemachineVirtualCameraBase m_vcam; // 0x30
	
			// Constructors
			public VcamExtraState() {} // 0x000000018350B670-0x000000018350B680
		}
	
		private struct ShapeCache // TypeDefIndex: 54378
		{
			// Fields
			public ConfinerOven m_confinerOven; // 0x00
			public List<List<Vector2>> m_OriginalPath; // 0x08
			public Matrix4x4 m_DeltaWorldToBaked; // 0x10
			public Matrix4x4 m_DeltaBakedToWorld; // 0x50
			private float m_aspectRatio; // 0x90
			private float m_maxWindowSize; // 0x94
			internal float m_maxComputationTimePerFrameInSeconds; // 0x98
			private Matrix4x4 m_bakedToWorld; // 0x9C
			private Collider2D m_boundingShape2D; // 0xE0
	
			// Methods
			public void Invalidate() {} // 0x0000000185558598-0x000000018555863C
			public bool ValidateCache(Collider2D boundingShape2D, float maxWindowSize, float aspectRatio, out bool confinerStateChanged) {
				confinerStateChanged = default;
				return default;
			} // 0x0000000185558754-0x0000000185558D8C
			private bool IsValid([IsReadOnly] in Collider2D boundingShape2D, [IsReadOnly] in float aspectRatio, [IsReadOnly] in float maxOrthoSize) => default; // 0x000000018555863C-0x0000000185558754
			private void CalculateDeltaTransformationMatrix() {} // 0x00000001855583B0-0x0000000185558598
		}
	
		// Constructors
		public CinemachineConfiner2D() {} // 0x000000018554FBBC-0x000000018554FBCC
	
		// Methods
		public void InvalidateCache() {} // 0x000000018554F604-0x000000018554F610
		public bool ValidateCache(float cameraAspectRatio) => default; // 0x000000018554FB80-0x000000018554FBBC
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x000000018554F62C-0x000000018554FB80
		private float CalculateHalfFrustumHeight([IsReadOnly] in CameraState state, [IsReadOnly] in float cameraPosLocalZ) => default; // 0x000000018554F568-0x000000018554F604
		private void OnValidate() {} // 0x000000018554F610-0x000000018554F62C
		private void Reset() {} // 0x0000000183D501F0-0x0000000183D50200
	}

	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineDollyCart.html")]
	public class CinemachineDollyCart : MonoBehaviour // TypeDefIndex: 54381
	{
		// Fields
		[Tooltip("The path to follow")]
		public CinemachinePathBase m_Path; // 0x18
		public bool forbidRotation; // 0x20
		[Tooltip("When to move the cart, if Velocity is non-zero")]
		public UpdateMethod m_UpdateMethod; // 0x24
		[Tooltip("How to interpret the Path Position.  If set to Path Units, values are as follows: 0 represents the first waypoint on the path, 1 is the second, and so on.  Values in-between are points on the path in between the waypoints.  If set to Distance, then Path Position represents distance along the path.")]
		public CinemachinePathBase.PositionUnits m_PositionUnits; // 0x28
		[FormerlySerializedAs("m_Velocity")]
		[Tooltip("Move the cart with this speed along the path.  The value is interpreted according to the Position Units setting.")]
		public float m_Speed; // 0x2C
		[FormerlySerializedAs("m_CurrentDistance")]
		[Tooltip("The position along the path at which the cart will be placed.  This can be animated directly or, if the velocity is non-zero, will be updated automatically.  The value is interpreted according to the Position Units setting.")]
		public float m_Position; // 0x30
	
		// Nested types
		public enum UpdateMethod // TypeDefIndex: 54380
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2
		}
	
		// Constructors
		public CinemachineDollyCart() {} // 0x00000001839CB270-0x00000001839CB280
	
		// Methods
		private void FixedUpdate() {} // 0x0000000185550FD4-0x0000000185551024
		private void Update() {} // 0x00000001855511D0-0x0000000185551230
		private void LateUpdate() {} // 0x0000000185551024-0x0000000185551088
		private void SetCartPosition(float distanceAlongPath) {} // 0x0000000185551088-0x00000001855511D0
	}

	[AddComponentMenu("Cinemachine/CinemachineExternalCamera")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineExternalCamera.html")]
	[RequireComponent(typeof(Camera))]
	public class CinemachineExternalCamera : CinemachineVirtualCameraBase // TypeDefIndex: 54382
	{
		// Fields
		[NoSaveDuringPlay]
		[Tooltip("The object that the camera is looking at.  Setting this will improve the quality of the blends to and from this camera")]
		[VcamTargetProperty]
		public Transform m_LookAt; // 0xA8
		private Camera m_Camera; // 0xB0
		private CameraState m_State; // 0xB8
		[FormerlySerializedAs("m_PositionBlending")]
		[Tooltip("Hint for blending positions to and from this virtual camera")]
		public BlendHint m_BlendHint; // 0x1E0
	
		// Properties
		public override CameraState State { get => default; } // 0x0000000183D50220-0x0000000183D502A0 
		public override Transform LookAt { get => default; set {} } // 0x0000000183D4EB10-0x0000000183D4EB20 0x0000000183D4CCB0-0x0000000183D4CCD0
		public override Transform Follow { get; set; } // 0x0000000183D50210-0x0000000183D50220 0x0000000183D4CCD0-0x0000000183D4CCF0
	
		// Constructors
		public CinemachineExternalCamera() {} // 0x0000000183394E70-0x0000000183394FD0
	
		// Methods
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x0000000185551230-0x00000001855517FC
	}

	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineFollowZoom.html")]
	[SaveDuringPlay]
	public class CinemachineFollowZoom : CinemachineExtension // TypeDefIndex: 54384
	{
		// Fields
		[Tooltip("The shot width to maintain, in world units, at target distance.")]
		public float m_Width; // 0x28
		[Range(0f, 20f)]
		[Tooltip("Increase this value to soften the aggressiveness of the follow-zoom.  Small numbers are more responsive, larger numbers give a more heavy slowly responding camera.")]
		public float m_Damping; // 0x2C
		[Range(1f, 179f)]
		[Tooltip("Lower limit for the FOV that this behaviour will generate.")]
		public float m_MinFOV; // 0x30
		[Range(1f, 179f)]
		[Tooltip("Upper limit for the FOV that this behaviour will generate.")]
		public float m_MaxFOV; // 0x34
	
		// Nested types
		private class VcamExtraState // TypeDefIndex: 54383
		{
			// Fields
			public float m_previousFrameZoom; // 0x10
	
			// Constructors
			public VcamExtraState() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public CinemachineFollowZoom() {} // 0x00000001839CB190-0x00000001839CB1C0
	
		// Methods
		private void OnValidate() {} // 0x00000001855517FC-0x0000000185551858
		public override float GetMaxDampTime() => default; // 0x0000000183D4F3A0-0x0000000183D4F3B0
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x0000000182742760-0x0000000182742A40
	}

	[AddComponentMenu("Cinemachine/CinemachineFreeLook")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExcludeFromPreset]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineFreeLook.html")]
	public class CinemachineFreeLook : CinemachineVirtualCameraBase // TypeDefIndex: 54388
	{
		// Fields
		[NoSaveDuringPlay]
		[Tooltip("Object for the camera children to look at (the aim target).")]
		[VcamTargetProperty]
		public Transform m_LookAt; // 0xA8
		[NoSaveDuringPlay]
		[Tooltip("Object for the camera children wants to move with (the body target).")]
		[VcamTargetProperty]
		public Transform m_Follow; // 0xB0
		[FormerlySerializedAs("m_UseCommonLensSetting")]
		[Tooltip("If enabled, this lens setting will apply to all three child rigs, otherwise the child rig lens settings will be used")]
		public bool m_CommonLens; // 0xB8
		[FormerlySerializedAs("m_LensAttributes")]
		[Tooltip("Specifies the lens properties of this Virtual Camera.  This generally mirrors the Unity Camera\'s lens settings, and will be used to drive the Unity camera when the vcam is active")]
		public LensSettings m_Lens; // 0xBC
		public TransitionParams m_Transitions; // 0xF0
		[FormerlySerializedAs("m_PositionBlending")]
		[FormerlySerializedAs("m_BlendHint")]
		[HideInInspector]
		[SerializeField]
		private BlendHint m_LegacyBlendHint; // 0x100
		[AxisStateProperty]
		[Header("Axis Control")]
		[Tooltip("The Vertical axis.  Value is 0..1.  Chooses how to blend the child rigs")]
		public AxisState m_YAxis; // 0x108
		[Tooltip("Controls how automatic recentering of the Y axis is accomplished")]
		public AxisState.Recentering m_YAxisRecentering; // 0x178
		[AxisStateProperty]
		[Tooltip("The Horizontal axis.  Value is -180...180.  This is passed on to the rigs\' OrbitalTransposer component")]
		public AxisState m_XAxis; // 0x198
		[OrbitalTransposerHeadingProperty]
		[Tooltip("The definition of Forward.  Camera will follow behind.")]
		public CinemachineOrbitalTransposer.Heading m_Heading; // 0x208
		[Tooltip("Controls how automatic recentering of the X axis is accomplished")]
		public AxisState.Recentering m_RecenterToTargetHeading; // 0x214
		[Header("Orbits")]
		[Tooltip("The coordinate space to use when interpreting the offset from the target.  This is also used to set the camera\'s Up vector, which will be maintained when aiming the camera.")]
		public CinemachineTransposer.BindingMode m_BindingMode; // 0x230
		[FormerlySerializedAs("m_SplineTension")]
		[Range(0f, 1f)]
		[Tooltip("Controls how taut is the line that connects the rigs\' orbits, which determines final placement on the Y axis")]
		public float m_SplineCurvature; // 0x234
		[Tooltip("The radius and height of the three orbiting rigs.")]
		public Orbit[] m_Orbits; // 0x238
		[FormerlySerializedAs("m_HeadingBias")]
		[HideInInspector]
		[SerializeField]
		private float m_LegacyHeadingBias; // 0x240
		private bool mUseLegacyRigDefinitions; // 0x244
		private bool mIsDestroyed; // 0x245
		private CameraState m_State; // 0x248
		[HideInInspector]
		[NoSaveDuringPlay]
		[SerializeField]
		private CinemachineVirtualCamera[] m_Rigs; // 0x368
		private CinemachineOrbitalTransposer[] mOrbitals; // 0x370
		private CinemachineBlend mBlendA; // 0x378
		private CinemachineBlend mBlendB; // 0x380
		public static CreateRigDelegate CreateRigOverride; // 0x00
		public static DestroyRigDelegate DestroyRigOverride; // 0x08
		private float m_CachedXAxisHeading; // 0x388
		private Orbit[] m_CachedOrbits; // 0x390
		private float m_CachedTension; // 0x398
		private Vector4[] m_CachedKnots; // 0x3A0
		private Vector4[] m_CachedCtrl1; // 0x3A8
		private Vector4[] m_CachedCtrl2; // 0x3B0
	
		// Properties
		public static string[] RigNames { get => default; } // 0x0000000185555734-0x00000001855557DC 
		public override bool PreviousStateIsValid { get => default; set {} } // 0x0000000183D4F7E0-0x0000000183D4F7F0 0x00000001855557DC-0x00000001855558C4
		public override CameraState State { get => default; } // 0x0000000183D502A0-0x0000000183D50320 
		public override Transform LookAt { get => default; set {} } // 0x000000018554A7D0-0x000000018554A7E0 0x000000018554A7F4-0x000000018554A808
		public override Transform Follow { get => default; set {} } // 0x000000018554A7B4-0x000000018554A7C4 0x0000000182B47080-0x0000000182B470A0
	
		// Nested types
		[Serializable]
		public struct Orbit // TypeDefIndex: 54385
		{
			// Fields
			public float m_Height; // 0x00
			public float m_Radius; // 0x04
	
			// Constructors
			public Orbit(float h, float r) {
				m_Height = default;
				m_Radius = default;
			} // 0x0000000183D50430-0x0000000183D50440
		}
	
		public delegate CinemachineVirtualCamera CreateRigDelegate(CinemachineFreeLook vcam, string name, CinemachineVirtualCamera copyFrom); // TypeDefIndex: 54386; 0x0000000181035ED0-0x0000000181035EF0
	
		public delegate void DestroyRigDelegate(GameObject rig); // TypeDefIndex: 54387; 0x0000000182149960-0x0000000182149970
	
		// Constructors
		public CinemachineFreeLook() {} // 0x0000000185555264-0x0000000185555734
	
		// Methods
		protected override void OnValidate() {} // 0x00000001855541C8-0x0000000185554308
		public CinemachineVirtualCamera GetRig(int i) => default; // 0x0000000185552914-0x0000000185552964
		protected override void OnEnable() {} // 0x0000000185553D40-0x0000000185553D80
		public void UpdateInputAxisProvider() {} // 0x0000000185554E08-0x0000000185554E9C
		protected override void OnDestroy() {} // 0x0000000185553C24-0x0000000185553D40
		private void OnTransformChildrenChanged() {} // 0x0000000185553354-0x000000018555336C
		private void Reset() {} // 0x0000000185554960-0x0000000185554968
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x01FD660D */) => default; // 0x000000018555336C-0x0000000185553478
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x0000000185553D80-0x0000000185553E44
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x00000001855523F4-0x00000001855526D4
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x0000000185552D38-0x0000000185553354
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x0000000185553E44-0x00000001855541C8
		internal override bool RequiresUserInput() => default; // 0x000000018232EB60-0x000000018232EB70
		private float GetYAxisClosestValue(Vector3 cameraPos, Vector3 up) => default; // 0x0000000185552964-0x0000000185552D08
		private void InvalidateRigCache() {} // 0x0000000185553354-0x000000018555336C
		private void DestroyRigs() {} // 0x0000000185551F70-0x00000001855523F4
		private CinemachineVirtualCamera[] CreateRigs(CinemachineVirtualCamera[] copyFrom) => default; // 0x0000000185551B1C-0x0000000185551F70
		private void UpdateRigCache() {} // 0x0000000185554E9C-0x00000001855550D4
		private int LocateExistingRigs(string[] rigNames, bool forceOrbital) => default; // 0x0000000185553478-0x0000000185553C24
		private float UpdateXAxisHeading(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up) => default; // 0x00000001855550D4-0x0000000185555264
		private void PushSettingsToRigs() {} // 0x0000000185554308-0x0000000185554960
		private float GetYAxisValue() => default; // 0x0000000185552D08-0x0000000185552D38
		private CameraState CalculateNewState(Vector3 worldUp, float deltaTime) => default; // 0x0000000185551858-0x0000000185551B1C
		public Vector3 GetLocalPositionForCameraFromInput(float t) => default; // 0x00000001855526D4-0x0000000185552914
		private void UpdateCachedSpline() {} // 0x0000000185554968-0x0000000185554E08
	}

	[AddComponentMenu("Cinemachine/CinemachineMixingCamera")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExcludeFromPreset]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineMixingCamera.html")]
	public class CinemachineMixingCamera : CinemachineVirtualCameraBase // TypeDefIndex: 54389
	{
		// Fields
		public const int MaxCameras = 8; // Metadata: 0x01FD660F
		[Tooltip("The weight of the first tracked camera")]
		public float m_Weight0; // 0xA8
		[Tooltip("The weight of the second tracked camera")]
		public float m_Weight1; // 0xAC
		[Tooltip("The weight of the third tracked camera")]
		public float m_Weight2; // 0xB0
		[Tooltip("The weight of the fourth tracked camera")]
		public float m_Weight3; // 0xB4
		[Tooltip("The weight of the fifth tracked camera")]
		public float m_Weight4; // 0xB8
		[Tooltip("The weight of the sixth tracked camera")]
		public float m_Weight5; // 0xBC
		[Tooltip("The weight of the seventh tracked camera")]
		public float m_Weight6; // 0xC0
		[Tooltip("The weight of the eighth tracked camera")]
		public float m_Weight7; // 0xC4
		private CameraState m_State; // 0xC8
		private CinemachineVirtualCameraBase[] m_ChildCameras; // 0x200
		private Dictionary<CinemachineVirtualCameraBase, int> m_indexMap; // 0x208
	
		// Properties
		private ICinemachineCamera LiveChild { get; set; } // 0x0000000183D50350-0x0000000183D50360 0x0000000185556FCC-0x0000000185556FE0
		public override CameraState State { get => default; } // 0x0000000183D50370-0x0000000183D503F0 
		public override Transform LookAt { get; set; } // 0x0000000183D50360-0x0000000183D50370 0x0000000185556FE0-0x0000000185556FF4
		public override Transform Follow { get; set; } // 0x0000000183D50340-0x0000000183D50350 0x0000000185556FB8-0x0000000185556FCC
		public CinemachineVirtualCameraBase[] ChildCameras { get => default; } // 0x0000000185556F98-0x0000000185556FB8 
	
		// Constructors
		public CinemachineMixingCamera() {} // 0x0000000185556E34-0x0000000185556F98
	
		// Methods
		public float GetWeight(int index) => default; // 0x0000000185556150-0x0000000185556254
		public void SetWeight(int index, float w) {} // 0x0000000185556AF4-0x0000000185556C04
		public float GetWeight(CinemachineVirtualCameraBase vcam) => default; // 0x0000000185556034-0x0000000185556150
		public void SetWeight(CinemachineVirtualCameraBase vcam, float w) {} // 0x00000001855569CC-0x0000000185556AF4
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x0000000185556750-0x0000000185556814
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x0000000185555F54-0x0000000185556034
		protected override void OnEnable() {} // 0x0000000185556730-0x0000000185556750
		public void OnTransformChildrenChanged() {} // 0x0000000185556814-0x000000018555681C
		protected override void OnValidate() {} // 0x0000000185556970-0x00000001855569CC
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x01FD660E */) => default; // 0x0000000185556694-0x0000000185556730
		protected void InvalidateListOfChildren() {} // 0x000000018555664C-0x0000000185556694
		protected void ValidateListOfChildren() {} // 0x0000000185556C04-0x0000000185556E34
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x000000018555681C-0x0000000185556970
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x0000000185556254-0x000000018555664C
	}

	[AddComponentMenu("Cinemachine/CinemachinePath")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachinePath.html")]
	[SaveDuringPlay]
	public class CinemachinePath : CinemachinePathBase // TypeDefIndex: 54391
	{
		// Fields
		[Tooltip("If checked, then the path ends are joined to form a continuous loop.")]
		public bool m_Looped; // 0x48
		[Tooltip("The waypoints that define the path.  They will be interpolated using a bezier curve.")]
		public Waypoint[] m_Waypoints; // 0x50
	
		// Properties
		public override float MinPos { get => default; } // 0x0000000183D503F0-0x0000000183D50400 
		public override float MaxPos { get => default; } // 0x0000000185557944-0x0000000185557980 
		public override bool Looped { get => default; } // 0x0000000183D4EFE0-0x0000000183D4EFF0 
		public override int DistanceCacheSampleStepsPerSegment { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
	
		// Nested types
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct Waypoint // TypeDefIndex: 54390
		{
			// Fields
			[Tooltip("Position in path-local space")]
			public Vector3 position; // 0x00
			[Tooltip("Offset from the position, which defines the tangent of the curve at the waypoint.  The length of the tangent encodes the strength of the bezier handle.  The same handle is used symmetrically on both sides of the waypoint, to ensure smoothness.")]
			public Vector3 tangent; // 0x0C
			[Tooltip("Defines the roll of the path at this waypoint.  The other orientation axes are inferred from the tangent and world up.")]
			public float roll; // 0x18
		}
	
		// Constructors
		public CinemachinePath() {} // 0x00000001855578F4-0x0000000185557944
	
		// Methods
		private void Reset() {} // 0x00000001855577D4-0x00000001855578F4
		private float GetBoundingIndices(float pos, out int indexA, out int indexB) {
			indexA = default;
			indexB = default;
			return default;
		} // 0x00000001855576EC-0x00000001855577C4
		public override Vector3 EvaluatePosition(float pos) => default; // 0x0000000185557284-0x0000000185557494
		public override Vector3 EvaluateTangent(float pos) => default; // 0x0000000185557494-0x00000001855576EC
		public override Quaternion EvaluateOrientation(float pos) => default; // 0x0000000185556FF4-0x0000000185557284
		private void OnValidate() {} // 0x00000001855577C4-0x00000001855577D4
	}

	[AddComponentMenu("")]
	public sealed class CinemachinePipeline : MonoBehaviour // TypeDefIndex: 54392
	{
		// Constructors
		public CinemachinePipeline() {} // 0x000000018426FE60-0x000000018426FE68
	}

	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	public class CinemachinePixelPerfect : MonoBehaviour // TypeDefIndex: 54393
	{
		// Constructors
		public CinemachinePixelPerfect() {} // 0x000000018426FE60-0x000000018426FE68
	}

	[AddComponentMenu("Cinemachine/CinemachineSmoothPath")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineSmoothPath.html")]
	[SaveDuringPlay]
	public class CinemachineSmoothPath : CinemachinePathBase // TypeDefIndex: 54395
	{
		// Fields
		[Tooltip("If checked, then the path ends are joined to form a continuous loop.")]
		public bool m_Looped; // 0x48
		[Tooltip("The waypoints that define the path.  They will be interpolated using a bezier curve.")]
		public Waypoint[] m_Waypoints; // 0x50
		private Waypoint[] m_ControlPoints1; // 0x58
		private Waypoint[] m_ControlPoints2; // 0x60
		private bool m_IsLoopedCache; // 0x68
	
		// Properties
		public override float MinPos { get => default; } // 0x0000000183D503F0-0x0000000183D50400 
		public override float MaxPos { get => default; } // 0x0000000185557944-0x0000000185557980 
		public override bool Looped { get => default; } // 0x0000000183D4EFE0-0x0000000183D4EFF0 
		public override int DistanceCacheSampleStepsPerSegment { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
	
		// Nested types
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct Waypoint // TypeDefIndex: 54394
		{
			// Fields
			[Tooltip("Position in path-local space")]
			public Vector3 position; // 0x00
			[Tooltip("Defines the roll of the path at this waypoint.  The other orientation axes are inferred from the tangent and world up.")]
			public float roll; // 0x0C
	
			// Properties
			internal Vector4 AsVector4 { get => default; } // 0x000000018294BC80-0x000000018294BCA0 
	
			// Methods
			internal static Waypoint FromVector4(Vector4 v) => default; // 0x00000001855670E4-0x0000000185567438
		}
	
		// Constructors
		public CinemachineSmoothPath() {} // 0x000000018556126C-0x00000001855612BC
	
		// Methods
		private void OnValidate() {} // 0x00000001855577C4-0x00000001855577D4
		private void Reset() {} // 0x0000000185560F34-0x000000018556103C
		public override void InvalidateDistanceCache() {} // 0x0000000185560F00-0x0000000185560F34
		private void UpdateControlPoints() {} // 0x000000018556103C-0x000000018556126C
		private float GetBoundingIndices(float pos, out int indexA, out int indexB) {
			indexA = default;
			indexB = default;
			return default;
		} // 0x0000000185560E54-0x0000000185560F00
		public override Vector3 EvaluatePosition(float pos) => default; // 0x0000000185560A00-0x0000000185560BF8
		public override Vector3 EvaluateTangent(float pos) => default; // 0x0000000185560BF8-0x0000000185560E54
		public override Quaternion EvaluateOrientation(float pos) => default; // 0x0000000185560770-0x0000000185560A00
		private Quaternion RollAroundForward(float angle) => default; // 0x0000000183D50720-0x0000000183D50770
	}

	[AddComponentMenu("Cinemachine/CinemachineStateDrivenCamera")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExcludeFromPreset]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineStateDrivenCamera.html")]
	public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase // TypeDefIndex: 54399
	{
		// Fields
		[NoSaveDuringPlay]
		[Tooltip("Default object for the camera children to look at (the aim target), if not specified in a child camera.  May be empty if all of the children define targets of their own.")]
		[VcamTargetProperty]
		public Transform m_LookAt; // 0xA8
		[NoSaveDuringPlay]
		[Tooltip("Default object for the camera children wants to move with (the body target), if not specified in a child camera.  May be empty if all of the children define targets of their own.")]
		[VcamTargetProperty]
		public Transform m_Follow; // 0xB0
		[NoSaveDuringPlay]
		[Space]
		[Tooltip("The state machine whose state changes will drive this camera\'s choice of active child")]
		public Animator m_AnimatedTarget; // 0xB8
		[NoSaveDuringPlay]
		[Tooltip("Which layer in the target state machine to observe")]
		public int m_LayerIndex; // 0xC0
		[Tooltip("When enabled, the current child camera and blend will be indicated in the game window, for debugging")]
		public bool m_ShowDebugText; // 0xC4
		[HideInInspector]
		[NoSaveDuringPlay]
		[SerializeField]
		internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0xC8
		[Tooltip("The set of instructions associating virtual cameras with states.  These instructions are used to choose the live child at any given moment")]
		public Instruction[] m_Instructions; // 0xD0
		[CinemachineBlendDefinitionProperty]
		[Tooltip("The blend which is used if you don\'t explicitly define a blend between two Virtual Camera children")]
		public CinemachineBlendDefinition m_DefaultBlend; // 0xD8
		[Tooltip("This is the asset which contains custom settings for specific child blends")]
		public CinemachineBlenderSettings m_CustomBlends; // 0xF0
		[HideInInspector]
		[SerializeField]
		internal ParentHash[] m_ParentHash; // 0xF8
		private ICinemachineCamera m_TransitioningFrom; // 0x108
		private CameraState m_State; // 0x110
		private Dictionary<AnimationClip, List<HashPair>> mHashCache; // 0x230
		private float mActivationTime; // 0x238
		private Instruction mActiveInstruction; // 0x240
		private float mPendingActivationTime; // 0x258
		private Instruction mPendingInstruction; // 0x260
		private CinemachineBlend mActiveBlend; // 0x278
		private Dictionary<int, int> mInstructionDictionary; // 0x280
		private Dictionary<int, int> mStateParentLookup; // 0x288
		private List<AnimatorClipInfo> m_clipInfoList; // 0x290
	
		// Properties
		public override string Description { get => default; } // 0x0000000185563104-0x00000001855631F0 
		public ICinemachineCamera LiveChild { get; set; } // 0x0000000183D50770-0x0000000183D50780 0x00000001855631FC-0x0000000185563210
		public override CameraState State { get => default; } // 0x0000000183D50780-0x0000000183D50800 
		public override Transform LookAt { get => default; set {} } // 0x000000018554A7D0-0x000000018554A7E0 0x000000018554A7F4-0x000000018554A808
		public override Transform Follow { get => default; set {} } // 0x000000018554A7B4-0x000000018554A7C4 0x0000000182B47080-0x0000000182B470A0
		public CinemachineVirtualCameraBase[] ChildCameras { get => default; } // 0x00000001855630E4-0x0000000185563104 
		public bool IsBlending { get => default; } // 0x00000001855631F0-0x00000001855631FC 
	
		// Nested types
		[Serializable]
		public struct Instruction // TypeDefIndex: 54396
		{
			// Fields
			[Tooltip("The full hash of the animation state")]
			public int m_FullHash; // 0x00
			[Tooltip("The virtual camera to activate when the animation state becomes active")]
			public CinemachineVirtualCameraBase m_VirtualCamera; // 0x08
			[Tooltip("How long to wait (in seconds) before activating the virtual camera. This filters out very short state durations")]
			public float m_ActivateAfter; // 0x10
			[Tooltip("The minimum length of time (in seconds) to keep a virtual camera active")]
			public float m_MinDuration; // 0x14
		}
	
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.Undoc)]
		internal struct ParentHash // TypeDefIndex: 54397
		{
			// Fields
			public int m_Hash; // 0x00
			public int m_ParentHash; // 0x04
		}
	
		private struct HashPair // TypeDefIndex: 54398
		{
			// Fields
			public int parentHash; // 0x00
			public int hash; // 0x04
		}
	
		// Constructors
		public CinemachineStateDrivenCamera() {} // 0x0000000185562F08-0x00000001855630E4
	
		// Methods
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x01FD6610 */) => default; // 0x0000000185562098-0x00000001855620C0
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x0000000185562900-0x00000001855629C4
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x00000001855618E8-0x00000001855619C8
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x00000001855629CC-0x0000000185562A88
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x0000000185561AE4-0x0000000185562064
		protected override void OnEnable() {} // 0x00000001855625CC-0x00000001855627BC
		protected override void OnDisable() {} // 0x00000001855624B4-0x00000001855625CC
		public void OnTransformChildrenChanged() {} // 0x00000001855629C4-0x00000001855629CC
		private void OnGuiHandler() {} // 0x00000001855627BC-0x0000000185562900
		public static int CreateFakeHash(int parentHash, AnimationClip clip) => default; // 0x000000018556186C-0x00000001855618E8
		private int LookupFakeHash(int parentHash, AnimationClip clip) => default; // 0x0000000185562298-0x00000001855624B4
		private void InvalidateListOfChildren() {} // 0x0000000185562064-0x0000000185562098
		private void UpdateListOfChildren() {} // 0x0000000185562A88-0x0000000185562C3C
		internal void ValidateInstructions() {} // 0x0000000185562C3C-0x0000000185562F08
		private CinemachineVirtualCameraBase ChooseCurrentCamera() => default; // 0x00000001855612BC-0x000000018556186C
		private int GetClipHash(int hash, List<AnimatorClipInfo> clips) => default; // 0x00000001855619C8-0x0000000185561AE4
		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey) => default; // 0x00000001855620C0-0x0000000185562298
	}

	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineStoryboard.html")]
	[SaveDuringPlay]
	public class CinemachineStoryboard : CinemachineExtension // TypeDefIndex: 54403
	{
		// Fields
		[Tooltip("If checked, all storyboards are globally muted")]
		public static bool s_StoryboardGlobalMute; // 0x00
		[Tooltip("If checked, the specified image will be displayed as an overlay over the virtual camera\'s output")]
		public bool m_ShowImage; // 0x28
		[Tooltip("The image to display")]
		public Texture m_Image; // 0x30
		[Tooltip("How to handle differences between image aspect and screen aspect")]
		public FillStrategy m_Aspect; // 0x38
		[Range(0f, 1f)]
		[Tooltip("The opacity of the image.  0 is transparent, 1 is opaque")]
		public float m_Alpha; // 0x3C
		[Tooltip("The screen-space position at which to display the image.  Zero is center")]
		public Vector2 m_Center; // 0x40
		[Tooltip("The screen-space rotation to apply to the image")]
		public Vector3 m_Rotation; // 0x48
		[Tooltip("The screen-space scaling to apply to the image")]
		public Vector2 m_Scale; // 0x54
		[Tooltip("If checked, X and Y scale are synchronized")]
		public bool m_SyncScale; // 0x5C
		[Tooltip("If checked, Camera transform will not be controlled by this virtual camera")]
		public bool m_MuteCamera; // 0x5D
		[Range(-1f, 1f)]
		[Tooltip("Wipe the image on and off horizontally")]
		public float m_SplitView; // 0x60
		[Tooltip("The render mode of the canvas on which the storyboard is drawn.")]
		public StoryboardRenderMode m_RenderMode; // 0x64
		[Tooltip("Allows ordering canvases to render on top or below other canvases.")]
		public int m_SortingOrder; // 0x68
		[Tooltip("How far away from the camera is the Canvas generated.")]
		public float m_PlaneDistance; // 0x6C
		private List<CanvasInfo> mCanvasInfo; // 0x70
	
		// Properties
		private string CanvasName { get => default; } // 0x0000000185564914-0x0000000185564980 
	
		// Nested types
		public enum FillStrategy // TypeDefIndex: 54400
		{
			BestFit = 0,
			CropImageToFit = 1,
			StretchToFit = 2
		}
	
		private class CanvasInfo // TypeDefIndex: 54401
		{
			// Fields
			public GameObject mCanvas; // 0x10
			public Canvas mCanvasComponent; // 0x18
			public CinemachineBrain mCanvasParent; // 0x20
			public RectTransform mViewport; // 0x28
			public RawImage mRawImage; // 0x30
	
			// Constructors
			public CanvasInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public enum StoryboardRenderMode // TypeDefIndex: 54402
		{
			ScreenSpaceOverlay = 0,
			ScreenSpaceCamera = 1
		}
	
		// Constructors
		public CinemachineStoryboard() {} // 0x000000018556481C-0x0000000185564914
	
		// Methods
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x000000018556457C-0x0000000185564678
		private void UpdateRenderCanvas() {} // 0x0000000185564678-0x000000018556481C
		protected override void ConnectToVcam(bool connect) {} // 0x00000001855633C0-0x0000000185563524
		private void CameraUpdatedCallback(CinemachineBrain brain) {} // 0x0000000185563210-0x00000001855633C0
		private CanvasInfo LocateMyCanvas(CinemachineBrain parent, bool createIfNotFound) => default; // 0x0000000185563B60-0x0000000185563F44
		private void CreateCanvas(CanvasInfo ci) {} // 0x0000000185563524-0x0000000185563970
		private void DestroyCanvas() {} // 0x0000000185563970-0x0000000185563B60
		private void PlaceImage(CanvasInfo ci, float alpha) {} // 0x0000000185563F44-0x000000018556457C
		private static void StaticBlendingHandler(CinemachineBrain brain) {} // 0x000000018259F8B0-0x000000018259FA10
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule() {} // 0x0000000183411740-0x0000000183411860
	}

	public interface ICinemachineTargetGroup // TypeDefIndex: 54404
	{
		// Properties
		BoundingSphere Sphere { get; }
		bool IsEmpty { get; }
	
		// Methods
		Bounds GetViewSpaceBoundingBox(Matrix4x4 observer);
		void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange);
	}

	[AddComponentMenu("Cinemachine/CinemachineTargetGroup")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineTargetGroup.html")]
	[SaveDuringPlay]
	public class CinemachineTargetGroup : MonoBehaviour, ICinemachineTargetGroup // TypeDefIndex: 54409
	{
		// Fields
		[Tooltip("How the group\'s position is calculated.  Select GroupCenter for the center of the bounding box, and GroupAverage for a weighted average of the positions of the members.")]
		public PositionMode m_PositionMode; // 0x18
		[Tooltip("How the group\'s rotation is calculated.  Select Manual to use the value in the group\'s transform, and GroupAverage for a weighted average of the orientations of the members.")]
		public RotationMode m_RotationMode; // 0x1C
		[Tooltip("When to update the group\'s transform based on the position of the group members")]
		public UpdateMethod m_UpdateMethod; // 0x20
		[NoSaveDuringPlay]
		[Tooltip("The target objects, together with their weights and radii, that will contribute to the group\'s average position, orientation, and size.")]
		public Target[] m_Targets; // 0x28
		private float m_MaxWeight; // 0x48
		private Vector3 m_AveragePos; // 0x4C
		private BoundingSphere m_BoundingSphere; // 0x58
	
		// Properties
		public Transform Transform { get => default; } // 0x0000000184273A88-0x0000000184273A90 
		public Bounds BoundingBox { get; private set; } // 0x0000000183D50800-0x0000000183D50820 0x0000000183D50830-0x0000000183D50850
		public BoundingSphere Sphere { get => default; } // 0x0000000183D50820-0x0000000183D50830 
		public bool IsEmpty { get => default; } // 0x0000000185565FB8-0x0000000185566060 
	
		// Nested types
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct Target // TypeDefIndex: 54405
		{
			// Fields
			[Tooltip("The target objects.  This object\'s position and orientation will contribute to the group\'s average position and orientation, in accordance with its weight")]
			public Transform target; // 0x00
			[Tooltip("How much weight to give the target when averaging.  Cannot be negative")]
			public float weight; // 0x08
			[Tooltip("The radius of the target, used for calculating the bounding box.  Cannot be negative")]
			public float radius; // 0x0C
		}
	
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum PositionMode // TypeDefIndex: 54406
		{
			GroupCenter = 0,
			GroupAverage = 1
		}
	
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum RotationMode // TypeDefIndex: 54407
		{
			Manual = 0,
			GroupAverage = 1
		}
	
		public enum UpdateMethod // TypeDefIndex: 54408
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2
		}
	
		// Constructors
		public CinemachineTargetGroup() {} // 0x0000000183CBAF20-0x0000000183CBAF80
	
		// Methods
		public void AddMember(Transform t, float weight, float radius) {} // 0x0000000185564980-0x0000000185564A98
		public void RemoveMember(Transform t) {} // 0x0000000185565DA0-0x0000000185565E64
		public int FindMember(Transform t) => default; // 0x0000000185565500-0x00000001855655A0
		public BoundingSphere GetWeightedBoundsForMember(int index) => default; // 0x0000000185565C48-0x0000000185565CE0
		public Bounds GetViewSpaceBoundingBox(Matrix4x4 observer) => default; // 0x0000000185565A50-0x0000000185565C48
		private static BoundingSphere WeightedMemberBounds(Target t, Vector3 avgPos, float maxWeight) => default; // 0x0000000185565E94-0x0000000185565FB8
		public void DoUpdate() {} // 0x00000001855653B0-0x0000000185565500
		private BoundingSphere CalculateBoundingSphere(float maxWeight) => default; // 0x00000001855650D4-0x00000001855653B0
		private Vector3 CalculateAveragePosition(out float maxWeight) {
			maxWeight = default;
			return default;
		} // 0x0000000185564C8C-0x0000000185564ED0
		private Quaternion CalculateAverageOrientation() => default; // 0x0000000185564A98-0x0000000185564C8C
		private Bounds CalculateBoundingBox(Vector3 avgPos, float maxWeight) => default; // 0x0000000185564ED0-0x00000001855650D4
		private void OnValidate() {} // 0x0000000185565CF0-0x0000000185565DA0
		private void FixedUpdate() {} // 0x00000001855655A0-0x00000001855655B0
		private void Update() {} // 0x0000000185565E64-0x0000000185565E94
		private void LateUpdate() {} // 0x0000000185565CE0-0x0000000185565CF0
		public void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange) {
			minAngles = default;
			maxAngles = default;
			zRange = default;
		} // 0x00000001855655B0-0x0000000185565A50
	}

	[AddComponentMenu("Cinemachine/CinemachineVirtualCamera")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExcludeFromPreset]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineVirtualCamera.html")]
	public class CinemachineVirtualCamera : CinemachineVirtualCameraBase // TypeDefIndex: 54413
	{
		// Fields
		[NoSaveDuringPlay]
		[Tooltip("The object that the camera wants to look at (the Aim target).  If this is null, then the vcam\'s Transform orientation will define the camera\'s orientation.")]
		[VcamTargetProperty]
		public Transform m_LookAt; // 0xA8
		[NoSaveDuringPlay]
		[Tooltip("The object that the camera wants to move with (the Body target).  If this is null, then the vcam\'s Transform position will define the camera\'s position.")]
		[VcamTargetProperty]
		public Transform m_Follow; // 0xB0
		[FormerlySerializedAs("m_LensAttributes")]
		[Tooltip("Specifies the lens properties of this Virtual Camera.  This generally mirrors the Unity Camera\'s lens settings, and will be used to drive the Unity camera when the vcam is active.")]
		public LensSettings m_Lens; // 0xB8
		public TransitionParams m_Transitions; // 0xE8
		[FormerlySerializedAs("m_BlendHint")]
		[FormerlySerializedAs("m_PositionBlending")]
		[HideInInspector]
		[SerializeField]
		private BlendHint m_LegacyBlendHint; // 0xF8
		public const string PipelineName = "cm"; // Metadata: 0x01FD661D
		public static CreatePipelineDelegate CreatePipelineOverride; // 0x00
		public static DestroyPipelineDelegate DestroyPipelineOverride; // 0x08
		internal bool m_UserIsDragging; // 0xFC
		protected CameraState m_State; // 0x100
		private CinemachineComponentBase[] m_ComponentPipeline; // 0x220
		[HideInInspector]
		[SerializeField]
		private Transform m_ComponentOwner; // 0x228
		private Transform mCachedLookAtTarget; // 0x230
		private CinemachineVirtualCameraBase mCachedLookAtTargetVcam; // 0x238
	
		// Properties
		public override CameraState State { get => default; } // 0x0000000183D50170-0x0000000183D501F0 
		public override Transform LookAt { get => default; set {} } // 0x0000000182747720-0x0000000182747730 0x0000000183D4D0F0-0x0000000183D4D110
		public override Transform Follow { get => default; set {} } // 0x0000000182747AF0-0x0000000182747B00 0x0000000182B47080-0x0000000182B470A0
	
		// Nested types
		public delegate Transform CreatePipelineDelegate(CinemachineVirtualCamera vcam, string name, CinemachineComponentBase[] copyFrom); // TypeDefIndex: 54410; 0x0000000181035ED0-0x0000000181035EF0
	
		public delegate void DestroyPipelineDelegate(GameObject pipeline); // TypeDefIndex: 54411; 0x0000000182149960-0x0000000182149970
	
		// Constructors
		public CinemachineVirtualCamera() {} // 0x0000000183394FD0-0x0000000183395190
	
		// Methods
		public void SetFieldOfView(float fov) {} // 0x0000000183D50850-0x0000000183D50860
		public override float GetMaxDampTime() => default; // 0x00000001855667D4-0x0000000185566860
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x00000001827470F0-0x0000000182747720
		protected override void OnEnable() {} // 0x00000001833183C0-0x0000000183318580
		protected override void OnDestroy() {} // 0x0000000185566860-0x0000000185566A6C
		protected override void OnValidate() {} // 0x0000000185566C40-0x0000000185566CAC
		private void OnTransformChildrenChanged() {} // 0x00000001842760C0-0x00000001842760D8
		private void Reset() {} // 0x0000000185566DE0-0x0000000185566DE8
		private void DestroyPipeline() {} // 0x00000001855661D4-0x0000000185566644
		private Transform CreatePipeline(CinemachineVirtualCamera copyFrom) => default; // 0x0000000185566060-0x00000001855661D4
		public void InvalidateComponentPipeline() {} // 0x00000001842760C0-0x00000001842760D8
		public Transform GetComponentOwner() => default; // 0x00000001855667B4-0x00000001855667D4
		public CinemachineComponentBase[] GetComponentPipeline() => default; // 0x0000000184276AE0-0x0000000184276B00
		public CinemachineComponentBase GetCinemachineComponent(CinemachineCore.Stage stage) => default; // 0x0000000183725D40-0x0000000183725DC0
		public new T GetCinemachineComponent<T>()
			where T : CinemachineComponentBase => default;
		public T AddCinemachineComponent<T>()
			where T : CinemachineComponentBase => default;
		public void DestroyCinemachineComponent<T>()
			where T : CinemachineComponentBase {}
		private void UpdateComponentPipeline() {} // 0x0000000183001400-0x0000000183002450
		internal static void SetFlagsForHiddenChild(GameObject child) {} // 0x00000001830024B0-0x0000000183002580
		protected CameraState CalculateNewState(Vector3 worldUp, float deltaTime) => default; // 0x0000000182747F60-0x00000001827487D0
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x0000000185566A6C-0x0000000185566C40
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x0000000185566644-0x00000001855667B4
		internal void SetStateRawPosition(Vector3 pos) {} // 0x0000000183D50860-0x0000000183D50880
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x0000000183651270-0x0000000183651450
		internal override bool RequiresUserInput() => default; // 0x0000000185566CAC-0x0000000185566DE0
	}

	[AddComponentMenu("")]
	[SaveDuringPlay]
	public class Cinemachine3rdPersonFollow : CinemachineComponentBase // TypeDefIndex: 54414
	{
		// Fields
		[Tooltip("How responsively the camera tracks the target.  Each axis (camera-local) can have its own setting.  Value is the approximate time it takes the camera to catch up to the target\'s new position.  Smaller values give a more rigid effect, larger values give a squishier one")]
		public Vector3 Damping; // 0x20
		[Header("Rig")]
		[Tooltip("Position of the shoulder pivot relative to the Follow target origin.  This offset is in target-local space")]
		public Vector3 ShoulderOffset; // 0x2C
		[Tooltip("Vertical offset of the hand in relation to the shoulder.  Arm length will affect the follow target\'s screen position when the camera rotates vertically")]
		public float VerticalArmLength; // 0x38
		[Range(0f, 1f)]
		[Tooltip("Specifies which shoulder (left, right, or in-between) the camera is on")]
		public float CameraSide; // 0x3C
		[Tooltip("How far baehind the hand the camera will be placed")]
		public float CameraDistance; // 0x40
		[Header("Obstacles")]
		[Tooltip("Camera will avoid obstacles on these layers")]
		public LayerMask CameraCollisionFilter; // 0x44
		[TagField]
		[Tooltip("Obstacles with this tag will be ignored.  It is a good idea to set this field to the target\'s tag")]
		public string IgnoreTag; // 0x48
		[Range(0f, 1f)]
		[Tooltip("Specifies how close the camera can get to obstacles")]
		public float CameraRadius; // 0x50
		[Range(0f, 10f)]
		[Tooltip("How gradually the camera moves to correct for occlusions.  Higher numbers will move the camera more gradually.")]
		public float DampingIntoCollision; // 0x54
		[Range(0f, 10f)]
		[Tooltip("How gradually the camera returns to its normal position after having been corrected by the built-in collision resolution system.  Higher numbers will move the camera more gradually back to normal.")]
		public float DampingFromCollision; // 0x58
		public bool DisableDampingCorrection; // 0x5C
		private Vector3 m_PreviousFollowTargetPosition; // 0x60
		private Vector3 m_DampingCorrection; // 0x6C
		private float m_CamPosCollisionCorrection; // 0x78
	
		// Properties
		public override bool IsValid { get => default; } // 0x000000018322EB50-0x000000018322EBD0 
		public override CinemachineCore.Stage Stage { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public Cinemachine3rdPersonFollow() {} // 0x000000018332EB50-0x000000018332EBB0
	
		// Methods
		private void OnValidate() {} // 0x0000000185559660-0x00000001855596DC
		private void Reset() {} // 0x0000000183D50460-0x0000000183D504D0
		private void OnDestroy() {} // 0x0000000185559560-0x00000001855595A0
		public override float GetMaxDampTime() => default; // 0x0000000185559350-0x0000000185559374
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x0000000182B24230-0x0000000182B242B0
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x00000001855595A0-0x0000000185559660
		private void PositionCamera(ref CameraState curState, float deltaTime) {} // 0x0000000182B24430-0x0000000182B248B0
		public void GetRigPositions(out Vector3 root, out Vector3 shoulder, out Vector3 hand) {
			root = default;
			shoulder = default;
			hand = default;
		} // 0x0000000185559374-0x0000000185559560
		internal static Quaternion GetHeading(Quaternion targetRot, Vector3 up) => default; // 0x0000000182B24AE0-0x0000000182B24CC0
		private void GetRawRigPositions(Vector3 root, Quaternion targetRot, Quaternion heading, out Vector3 shoulder, out Vector3 hand) {
			shoulder = default;
			hand = default;
		} // 0x0000000182B242B0-0x0000000182B24430
		private Vector3 BeyondResolveCollisions(Vector3 root, Vector3 tip, float cameraRadius) => default; // 0x00000001855590F8-0x0000000185559350
		private Vector3 ResolveCollisions(Vector3 root, Vector3 tip, float deltaTime, float cameraRadius, ref float collisionCorrection) => default; // 0x00000001855596DC-0x0000000185559A2C
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase // TypeDefIndex: 54415
	{
		// Fields
		[FormerlySerializedAs("m_Definition")]
		[NoiseSettingsProperty]
		[Tooltip("The asset containing the Noise Profile.  Define the frequencies and amplitudes there to make a characteristic noise profile.  Make your own or just use one of the many presets.")]
		public NoiseSettings m_NoiseProfile; // 0x20
		[Tooltip("When rotating the camera, offset the camera\'s pivot position by this much (camera space)")]
		public Vector3 m_PivotOffset; // 0x28
		[Tooltip("Gain to apply to the amplitudes defined in the NoiseSettings asset.  1 is normal.  Setting this to 0 completely mutes the noise.")]
		public float m_AmplitudeGain; // 0x34
		[Tooltip("Scale factor to apply to the frequencies defined in the NoiseSettings asset.  1 is normal.  Larger magnitudes will make the noise shake more rapidly.")]
		public float m_FrequencyGain; // 0x38
		private bool mInitialized; // 0x3C
		private float mNoiseTime; // 0x40
		[HideInInspector]
		[SerializeField]
		private Vector3 mNoiseOffsets; // 0x44
	
		// Properties
		public override bool IsValid { get => default; } // 0x000000018555A110-0x000000018555A16C 
		public override CinemachineCore.Stage Stage { get => default; } // 0x0000000182102C70-0x0000000182102C80 
	
		// Constructors
		public CinemachineBasicMultiChannelPerlin() {} // 0x000000018555A0B8-0x000000018555A110
	
		// Methods
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x0000000185559AE4-0x000000018555A034
		public void ReSeed() {} // 0x000000018555A034-0x000000018555A0B8
		private void Initialize() {} // 0x0000000185559A2C-0x0000000185559AE4
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineComposer : CinemachineComponentBase // TypeDefIndex: 54417
	{
		// Fields
		[Tooltip("Target offset from the target object\'s center in target-local space. Use this to fine-tune the tracking target position when the desired area is not the tracked object\'s center.")]
		public Vector3 m_TrackedObjectOffset; // 0x20
		[Range(0f, 1f)]
		[Space]
		[Tooltip("This setting will instruct the composer to adjust its target offset based on the motion of the target.  The composer will look at a point where it estimates the target will be this many seconds into the future.  Note that this setting is sensitive to noisy animation, and can amplify the noise, resulting in undesirable camera jitter.  If the camera jitters unacceptably when the target is in motion, turn down this setting, or animate the target more smoothly.")]
		public float m_LookaheadTime; // 0x2C
		[Range(0f, 30f)]
		[Tooltip("Controls the smoothness of the lookahead algorithm.  Larger values smooth out jittery predictions and also increase prediction lag")]
		public float m_LookaheadSmoothing; // 0x30
		[Tooltip("If checked, movement along the Y axis will be ignored for lookahead calculations")]
		public bool m_LookaheadIgnoreY; // 0x34
		[Range(0f, 20f)]
		[Space]
		[Tooltip("How aggressively the camera tries to follow the target in the screen-horizontal direction. Small numbers are more responsive, rapidly orienting the camera to keep the target in the dead zone. Larger numbers give a more heavy slowly responding camera. Using different vertical and horizontal settings can yield a wide range of camera behaviors.")]
		public float m_HorizontalDamping; // 0x38
		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to follow the target in the screen-vertical direction. Small numbers are more responsive, rapidly orienting the camera to keep the target in the dead zone. Larger numbers give a more heavy slowly responding camera. Using different vertical and horizontal settings can yield a wide range of camera behaviors.")]
		public float m_VerticalDamping; // 0x3C
		[Range(-0.5f, 1.5f)]
		[Space]
		[Tooltip("Horizontal screen position for target. The camera will rotate to position the tracked object here.")]
		public float m_ScreenX; // 0x40
		[Range(-0.5f, 1.5f)]
		[Tooltip("Vertical screen position for target, The camera will rotate to position the tracked object here.")]
		public float m_ScreenY; // 0x44
		[Range(0f, 2f)]
		[Tooltip("Camera will not rotate horizontally if the target is within this range of the position.")]
		public float m_DeadZoneWidth; // 0x48
		[Range(0f, 2f)]
		[Tooltip("Camera will not rotate vertically if the target is within this range of the position.")]
		public float m_DeadZoneHeight; // 0x4C
		[Range(0f, 2f)]
		[Tooltip("When target is within this region, camera will gradually rotate horizontally to re-align towards the desired position, depending on the damping speed.")]
		public float m_SoftZoneWidth; // 0x50
		[Range(0f, 2f)]
		[Tooltip("When target is within this region, camera will gradually rotate vertically to re-align towards the desired position, depending on the damping speed.")]
		public float m_SoftZoneHeight; // 0x54
		[Range(-0.5f, 0.5f)]
		[Tooltip("A non-zero bias will move the target position horizontally away from the center of the soft zone.")]
		public float m_BiasX; // 0x58
		[Range(-0.5f, 0.5f)]
		[Tooltip("A non-zero bias will move the target position vertically away from the center of the soft zone.")]
		public float m_BiasY; // 0x5C
		[Tooltip("Force target to center of screen when this camera activates.  If false, will clamp target to the edges of the dead zone")]
		public bool m_CenterOnActivate; // 0x60
		private Vector3 m_CameraPosPrevFrame; // 0x70
		private Vector3 m_LookAtPrevFrame; // 0x7C
		private Vector2 m_ScreenOffsetPrevFrame; // 0x88
		private Quaternion m_CameraOrientationPrevFrame; // 0x90
		internal PositionPredictor m_Predictor; // 0xA0
		private FovCache mCache; // 0xA8
		private Vector2 _lastExtra; // 0xF8
		private Vector2 _lastOriginalRotToRect; // 0x100
		public Vector2 deadZoneDampFactor; // 0x108
	
		// Properties
		public override bool IsValid { get => default; } // 0x00000001827461F0-0x00000001827462E0 
		public override CinemachineCore.Stage Stage { get => default; } // 0x0000000181168950-0x0000000181168960 
		public Vector3 TrackedPoint { get; private set; } // 0x0000000183D50510-0x0000000183D50530 0x0000000183D50530-0x0000000183D50540
		internal Rect SoftGuideRect { get => default; set {} } // 0x00000001827447C0-0x0000000182744810 0x000000018555A420-0x000000018555A4E0
		internal Rect HardGuideRect { get => default; set {} } // 0x0000000182744710-0x00000001827447C0 0x000000018555A2B8-0x000000018555A420
	
		// Nested types
		private struct FovCache // TypeDefIndex: 54416
		{
			// Fields
			public Rect mFovSoftGuideRect; // 0x00
			public Rect mFovHardGuideRect; // 0x10
			public float mFovH; // 0x20
			public float mFov; // 0x24
			private float mOrthoSizeOverDistance; // 0x28
			private float mAspect; // 0x2C
			private Rect mSoftGuideRect; // 0x30
			private Rect mHardGuideRect; // 0x40
	
			// Methods
			public void UpdateCache(LensSettings lens, Rect softGuide, Rect hardGuide, float targetDistance) {} // 0x0000000182743B50-0x0000000182743EB0
			private Rect ScreenToFOV(Rect rScreen, float fov, float fovH, float aspect) => default; // 0x0000000182741F50-0x0000000182742520
		}
	
		// Constructors
		public CinemachineComposer() {} // 0x000000018332EC60-0x000000018332ED80
	
		// Methods
		protected virtual Vector3 GetLookAtPointAndSetTrackedPoint(Vector3 lookAt, Vector3 up, float deltaTime) => default; // 0x0000000182744360-0x0000000182744600
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x000000018555A17C-0x000000018555A2B8
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x0000000183D504F0-0x0000000183D50510
		public override float GetMaxDampTime() => default; // 0x000000018555A16C-0x000000018555A17C
		public override void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime) {} // 0x0000000182744270-0x0000000182744360
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x00000001827458A0-0x0000000182746180
		public void ClearOriginalRotToRect() {} // 0x0000000183D504D0-0x0000000183D504F0
		private void RotateToScreenBounds(ref CameraState state, Rect screenRect, Vector3 trackedPoint, ref Quaternion rigOrientation, float fov, float fovH, float deltaTime) {} // 0x0000000182746400-0x0000000182746AF0
		private bool ClampVerticalBounds(ref Rect r, Vector3 dir, Vector3 up, float fov) => default; // 0x00000001827455F0-0x0000000182745680
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineFramingTransposer : CinemachineComponentBase // TypeDefIndex: 54420
	{
		// Fields
		[Tooltip("Offset from the Follow Target object (in target-local co-ordinates).  The camera will attempt to frame the point which is the target\'s position plus this offset.  Use it to correct for cases when the target\'s origin is not the point of interest for the camera.")]
		public Vector3 m_TrackedObjectOffset; // 0x20
		[Range(0f, 1f)]
		[Space]
		[Tooltip("This setting will instruct the composer to adjust its target offset based on the motion of the target.  The composer will look at a point where it estimates the target will be this many seconds into the future.  Note that this setting is sensitive to noisy animation, and can amplify the noise, resulting in undesirable camera jitter.  If the camera jitters unacceptably when the target is in motion, turn down this setting, or animate the target more smoothly.")]
		public float m_LookaheadTime; // 0x2C
		[Range(0f, 30f)]
		[Tooltip("Controls the smoothness of the lookahead algorithm.  Larger values smooth out jittery predictions and also increase prediction lag")]
		public float m_LookaheadSmoothing; // 0x30
		[Tooltip("If checked, movement along the Y axis will be ignored for lookahead calculations")]
		public bool m_LookaheadIgnoreY; // 0x34
		[Range(0f, 20f)]
		[Space]
		[Tooltip("How aggressively the camera tries to maintain the offset in the X-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target\'s x-axis offset.  Larger numbers give a more heavy slowly responding camera.  Using different settings per axis can yield a wide range of camera behaviors.")]
		public float m_XDamping; // 0x38
		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to maintain the offset in the Y-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target\'s y-axis offset.  Larger numbers give a more heavy slowly responding camera.  Using different settings per axis can yield a wide range of camera behaviors.")]
		public float m_YDamping; // 0x3C
		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to maintain the offset in the Z-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target\'s z-axis offset.  Larger numbers give a more heavy slowly responding camera.  Using different settings per axis can yield a wide range of camera behaviors.")]
		public float m_ZDamping; // 0x40
		[Tooltip("If set, damping will apply  only to target motion, but not to camera rotation changes.  Turn this on to get an instant response when the rotation changes.  ")]
		public bool m_TargetMovementOnly; // 0x44
		[Range(-0.5f, 1.5f)]
		[Space]
		[Tooltip("Horizontal screen position for target. The camera will move to position the tracked object here.")]
		public float m_ScreenX; // 0x48
		[Range(-0.5f, 1.5f)]
		[Tooltip("Vertical screen position for target, The camera will move to position the tracked object here.")]
		public float m_ScreenY; // 0x4C
		[Tooltip("The distance along the camera axis that will be maintained from the Follow target")]
		public float m_CameraDistance; // 0x50
		[Range(0f, 2f)]
		[Space]
		[Tooltip("Camera will not move horizontally if the target is within this range of the position.")]
		public float m_DeadZoneWidth; // 0x54
		[Range(0f, 2f)]
		[Tooltip("Camera will not move vertically if the target is within this range of the position.")]
		public float m_DeadZoneHeight; // 0x58
		[FormerlySerializedAs("m_DistanceDeadZoneSize")]
		[Tooltip("The camera will not move along its z-axis if the Follow target is within this distance of the specified camera distance")]
		public float m_DeadZoneDepth; // 0x5C
		[Space]
		[Tooltip("If checked, then then soft zone will be unlimited in size.")]
		public bool m_UnlimitedSoftZone; // 0x60
		[Range(0f, 2f)]
		[Tooltip("When target is within this region, camera will gradually move horizontally to re-align towards the desired position, depending on the damping speed.")]
		public float m_SoftZoneWidth; // 0x64
		[Range(0f, 2f)]
		[Tooltip("When target is within this region, camera will gradually move vertically to re-align towards the desired position, depending on the damping speed.")]
		public float m_SoftZoneHeight; // 0x68
		[Range(-0.5f, 0.5f)]
		[Tooltip("A non-zero bias will move the target position horizontally away from the center of the soft zone.")]
		public float m_BiasX; // 0x6C
		[Range(-0.5f, 0.5f)]
		[Tooltip("A non-zero bias will move the target position vertically away from the center of the soft zone.")]
		public float m_BiasY; // 0x70
		[Tooltip("Force target to center of screen when this camera activates.  If false, will clamp target to the edges of the dead zone")]
		public bool m_CenterOnActivate; // 0x74
		[FormerlySerializedAs("m_FramingMode")]
		[Space]
		[Tooltip("What screen dimensions to consider when framing.  Can be Horizontal, Vertical, or both")]
		public FramingMode m_GroupFramingMode; // 0x78
		[Tooltip("How to adjust the camera to get the desired framing.  You can zoom, dolly in/out, or do both.")]
		public AdjustmentMode m_AdjustmentMode; // 0x7C
		[Tooltip("The bounding box of the targets should occupy this amount of the screen space.  1 means fill the whole screen.  0.5 means fill half the screen, etc.")]
		public float m_GroupFramingSize; // 0x80
		[Tooltip("The maximum distance toward the target that this behaviour is allowed to move the camera.")]
		public float m_MaxDollyIn; // 0x84
		[Tooltip("The maximum distance away the target that this behaviour is allowed to move the camera.")]
		public float m_MaxDollyOut; // 0x88
		[Tooltip("Set this to limit how close to the target the camera can get.")]
		public float m_MinimumDistance; // 0x8C
		[Tooltip("Set this to limit how far from the target the camera can get.")]
		public float m_MaximumDistance; // 0x90
		[Range(1f, 179f)]
		[Tooltip("If adjusting FOV, will not set the FOV lower than this.")]
		public float m_MinimumFOV; // 0x94
		[Range(1f, 179f)]
		[Tooltip("If adjusting FOV, will not set the FOV higher than this.")]
		public float m_MaximumFOV; // 0x98
		[Tooltip("If adjusting Orthographic Size, will not set it lower than this.")]
		public float m_MinimumOrthoSize; // 0x9C
		[Tooltip("If adjusting Orthographic Size, will not set it higher than this.")]
		public float m_MaximumOrthoSize; // 0xA0
		private const float kMinimumCameraDistance = 0.01f; // Metadata: 0x01FD6620
		private const float kMinimumGroupSize = 0.01f; // Metadata: 0x01FD6624
		private Vector3 m_PreviousCameraPosition; // 0xA4
		internal PositionPredictor m_Predictor; // 0xB0
		private bool m_InheritingPosition; // 0xC4
		private float m_prevFOV; // 0xC8
		private Quaternion m_prevRotation; // 0xCC
	
		// Properties
		internal Rect SoftGuideRect { get => default; set {} } // 0x000000018555C7C8-0x000000018555C810 0x000000018555C978-0x000000018555CA38
		internal Rect HardGuideRect { get => default; set {} } // 0x000000018555C6AC-0x000000018555C764 0x000000018555C810-0x000000018555C978
		public override bool IsValid { get => default; } // 0x000000018555C764-0x000000018555C7C8 
		public override CinemachineCore.Stage Stage { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override bool BodyAppliesAfterAim { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public Vector3 TrackedPoint { get; private set; } // 0x0000000183D505C0-0x0000000183D505E0 0x0000000183D50630-0x0000000183D50650
		public Bounds LastBounds { get; private set; } // 0x0000000183D505A0-0x0000000183D505C0 0x0000000183D50610-0x0000000183D50630
		public Matrix4x4 LastBoundsMatrix { get; private set; } // 0x0000000183D50570-0x0000000183D505A0 0x0000000183D505E0-0x0000000183D50610
	
		// Nested types
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum FramingMode // TypeDefIndex: 54418
		{
			Horizontal = 0,
			Vertical = 1,
			HorizontalAndVertical = 2,
			None = 3
		}
	
		public enum AdjustmentMode // TypeDefIndex: 54419
		{
			ZoomOnly = 0,
			DollyOnly = 1,
			DollyThenZoom = 2
		}
	
		// Constructors
		public CinemachineFramingTransposer() {} // 0x000000018555C5B0-0x000000018555C6AC
	
		// Methods
		private void OnValidate() {} // 0x000000018555C30C-0x000000018555C3F8
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x000000018555C03C-0x000000018555C13C
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x0000000183D50540-0x0000000183D50570
		public override float GetMaxDampTime() => default; // 0x000000018555A96C-0x000000018555A984
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) => default; // 0x000000018555C13C-0x000000018555C30C
		private Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect) => default; // 0x000000018555C4DC-0x000000018555C5B0
		private Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect) => default; // 0x000000018555C3F8-0x000000018555C4DC
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x000000018555AF2C-0x000000018555C03C
		private float GetTargetHeight(Vector2 boundsSize) => default; // 0x000000018555AD90-0x000000018555AF2C
		private Vector3 ComputeGroupBounds(ICinemachineTargetGroup group, ref CameraState curState) => default; // 0x000000018555A4E0-0x000000018555A96C
		private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, ref Vector3 pos, Quaternion orientation) => default; // 0x000000018555A984-0x000000018555AD90
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineGroupComposer : CinemachineComposer // TypeDefIndex: 54423
	{
		// Fields
		[Space]
		[Tooltip("The bounding box of the targets should occupy this amount of the screen space.  1 means fill the whole screen.  0.5 means fill half the screen, etc.")]
		public float m_GroupFramingSize; // 0x110
		[Tooltip("What screen dimensions to consider when framing.  Can be Horizontal, Vertical, or both")]
		public FramingMode m_FramingMode; // 0x114
		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to frame the group. Small numbers are more responsive, rapidly adjusting the camera to keep the group in the frame.  Larger numbers give a more heavy slowly responding camera.")]
		public float m_FrameDamping; // 0x118
		[Tooltip("How to adjust the camera to get the desired framing.  You can zoom, dolly in/out, or do both.")]
		public AdjustmentMode m_AdjustmentMode; // 0x11C
		[Tooltip("The maximum distance toward the target that this behaviour is allowed to move the camera.")]
		public float m_MaxDollyIn; // 0x120
		[Tooltip("The maximum distance away the target that this behaviour is allowed to move the camera.")]
		public float m_MaxDollyOut; // 0x124
		[Tooltip("Set this to limit how close to the target the camera can get.")]
		public float m_MinimumDistance; // 0x128
		[Tooltip("Set this to limit how far from the target the camera can get.")]
		public float m_MaximumDistance; // 0x12C
		[Range(1f, 179f)]
		[Tooltip("If adjusting FOV, will not set the FOV lower than this.")]
		public float m_MinimumFOV; // 0x130
		[Range(1f, 179f)]
		[Tooltip("If adjusting FOV, will not set the FOV higher than this.")]
		public float m_MaximumFOV; // 0x134
		[Tooltip("If adjusting Orthographic Size, will not set it lower than this.")]
		public float m_MinimumOrthoSize; // 0x138
		[Tooltip("If adjusting Orthographic Size, will not set it higher than this.")]
		public float m_MaximumOrthoSize; // 0x13C
		private float m_prevFramingDistance; // 0x140
		private float m_prevFOV; // 0x144
	
		// Properties
		public Bounds LastBounds { get; private set; } // 0x0000000183D50680-0x0000000183D506A0 0x0000000183D506D0-0x0000000183D506F0
		public Matrix4x4 LastBoundsMatrix { get; private set; } // 0x0000000183D50650-0x0000000183D50680 0x0000000183D506A0-0x0000000183D506D0
	
		// Nested types
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum FramingMode // TypeDefIndex: 54421
		{
			Horizontal = 0,
			Vertical = 1,
			HorizontalAndVertical = 2
		}
	
		public enum AdjustmentMode // TypeDefIndex: 54422
		{
			ZoomOnly = 0,
			DollyOnly = 1,
			DollyThenZoom = 2
		}
	
		// Constructors
		public CinemachineGroupComposer() {} // 0x000000018555DAD8-0x000000018555DB50
	
		// Methods
		private void OnValidate() {} // 0x000000018555DA08-0x000000018555DAD8
		public override float GetMaxDampTime() => default; // 0x000000018555CA38-0x000000018555CA50
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x000000018555CEB4-0x000000018555DA08
		private float GetTargetHeight(Vector2 boundsSize) => default; // 0x000000018555CCDC-0x000000018555CEB4
		private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, Matrix4x4 observer, out Vector3 newFwd) {
			newFwd = default;
			return default;
		} // 0x000000018555CA50-0x000000018555CCDC
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineHardLockToTarget : CinemachineComponentBase // TypeDefIndex: 54424
	{
		// Fields
		[Tooltip("How much time it takes for the position to catch up to the target\'s position")]
		public float m_Damping; // 0x20
		private Vector3 m_PreviousTargetPosition; // 0x24
	
		// Properties
		public override bool IsValid { get => default; } // 0x000000018555DCAC-0x000000018555DD10 
		public override CinemachineCore.Stage Stage { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public CinemachineHardLockToTarget() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public override float GetMaxDampTime() => default; // 0x0000000183D4F2E0-0x0000000183D4F2F0
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x000000018555DB50-0x000000018555DCAC
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineHardLookAt : CinemachineComponentBase // TypeDefIndex: 54425
	{
		// Properties
		public override bool IsValid { get => default; } // 0x000000018555DED8-0x000000018555DF3C 
		public override CinemachineCore.Stage Stage { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public CinemachineHardLookAt() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x000000018555DD10-0x000000018555DED8
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineOrbitalTransposer : CinemachineTransposer // TypeDefIndex: 54430
	{
		// Fields
		[OrbitalTransposerHeadingProperty]
		[Space]
		[Tooltip("The definition of Forward.  Camera will follow behind.")]
		public Heading m_Heading; // 0x98
		[Tooltip("Automatic heading recentering.  The settings here defines how the camera will reposition itself in the absence of player input.")]
		public AxisState.Recentering m_RecenterToTargetHeading; // 0xA4
		[AxisStateProperty]
		[Tooltip("Heading Control.  The settings here control the behaviour of the camera in response to the player\'s input.")]
		public AxisState m_XAxis; // 0xC0
		[FormerlySerializedAs("m_Radius")]
		[HideInInspector]
		[SerializeField]
		private float m_LegacyRadius; // 0x130
		[FormerlySerializedAs("m_HeightOffset")]
		[HideInInspector]
		[SerializeField]
		private float m_LegacyHeightOffset; // 0x134
		[FormerlySerializedAs("m_HeadingBias")]
		[HideInInspector]
		[SerializeField]
		private float m_LegacyHeadingBias; // 0x138
		[HideInInspector]
		[NoSaveDuringPlay]
		public bool m_HeadingIsSlave; // 0x13C
		internal UpdateHeadingDelegate HeadingUpdater; // 0x140
		private Vector3 m_LastTargetPosition; // 0x148
		private HeadingTracker mHeadingTracker; // 0x158
		private Rigidbody m_TargetRigidBody; // 0x160
		private Transform m_PreviousTarget; // 0x168
		private Vector3 m_LastCameraPosition; // 0x170
		private float m_LastHeading; // 0x17C
	
		// Properties
		public override bool RequiresUserInput { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Nested types
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct Heading // TypeDefIndex: 54427
		{
			// Fields
			[FormerlySerializedAs("m_HeadingDefinition")]
			[Tooltip("How \'forward\' is defined.  The camera will be placed by default behind the target.  PositionDelta will consider \'forward\' to be the direction in which the target is moving.")]
			public HeadingDefinition m_Definition; // 0x00
			[Range(0f, 10f)]
			[Tooltip("Size of the velocity sampling window for target heading filter.  This filters out irregularities in the target\'s movement.  Used only if deriving heading from target\'s movement (PositionDelta or Velocity)")]
			public int m_VelocityFilterStrength; // 0x04
			[FormerlySerializedAs("m_HeadingBias")]
			[Range(-180f, 180f)]
			[Tooltip("Where the camera is placed when the X-axis value is zero.  This is a rotation in degrees around the Y axis.  When this value is 0, the camera will be placed behind the target.  Nonzero offsets will rotate the zero position around the target.")]
			public float m_Bias; // 0x08
	
			// Nested types
			[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
			public enum HeadingDefinition // TypeDefIndex: 54426
			{
				PositionDelta = 0,
				Velocity = 1,
				TargetForward = 2,
				WorldForward = 3
			}
	
			// Constructors
			public Heading(HeadingDefinition def, int filterStrength, float bias) {
				m_Definition = default;
				m_VelocityFilterStrength = default;
				m_Bias = default;
			} // 0x0000000183D50880-0x0000000183D50890
		}
	
		internal delegate float UpdateHeadingDelegate(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up); // TypeDefIndex: 54428; 0x0000000185566F84-0x0000000185566FBC
	
		// Constructors
		public CinemachineOrbitalTransposer() {} // 0x000000018555F660-0x000000018555F8EC
	
		// Methods
		protected override void OnValidate() {} // 0x000000018555F2D4-0x000000018555F42C
		public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis) => default; // 0x000000018555F42C-0x000000018555F46C
		public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis, ref AxisState.Recentering recentering, bool isLive) => default; // 0x000000018555F46C-0x000000018555F5A0
		private void OnEnable() {} // 0x000000018555EF98-0x000000018555EFE0
		public void UpdateInputAxisProvider() {} // 0x000000018555F5A0-0x000000018555F660
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x000000018555EFE0-0x000000018555F120
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x000000018555DF3C-0x000000018555E07C
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) => default; // 0x000000018555F120-0x000000018555F2D4
		public float GetAxisClosestValue(Vector3 cameraPos, Vector3 up) => default; // 0x000000018555E07C-0x000000018555E39C
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x000000018555E8B8-0x000000018555EF98
		public override Vector3 GetTargetCameraPosition(Vector3 worldUp) => default; // 0x000000018555E39C-0x000000018555E4F8
		private float GetTargetHeading(float currentHeading, Quaternion targetOrientation) => default; // 0x000000018555E4F8-0x000000018555E8B8
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachinePOV : CinemachineComponentBase // TypeDefIndex: 54432
	{
		// Fields
		public RecenterTargetMode m_RecenterTarget; // 0x20
		[AxisStateProperty]
		[Tooltip("The Vertical axis.  Value is -90..90. Controls the vertical orientation")]
		public AxisState m_VerticalAxis; // 0x28
		[Tooltip("Controls how automatic recentering of the Vertical axis is accomplished")]
		public AxisState.Recentering m_VerticalRecentering; // 0x98
		[AxisStateProperty]
		[Tooltip("The Horizontal axis.  Value is -180..180.  Controls the horizontal orientation")]
		public AxisState m_HorizontalAxis; // 0xB8
		[Tooltip("Controls how automatic recentering of the Horizontal axis is accomplished")]
		public AxisState.Recentering m_HorizontalRecentering; // 0x128
		[HideInInspector]
		[Tooltip("Obsolete - no longer used")]
		public bool m_ApplyBeforeBody; // 0x144
	
		// Properties
		public override bool IsValid { get => default; } // 0x0000000185560768-0x0000000185560770 
		public override CinemachineCore.Stage Stage { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override bool RequiresUserInput { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Nested types
		public enum RecenterTargetMode // TypeDefIndex: 54431
		{
			None = 0,
			FollowTargetForward = 1,
			LookAtTargetForward = 2
		}
	
		// Constructors
		public CinemachinePOV() {} // 0x000000018556050C-0x0000000185560768
	
		// Methods
		private void OnValidate() {} // 0x000000018555FF78-0x000000018555FFF8
		private void OnEnable() {} // 0x000000018555FDD0-0x000000018555FDD8
		public void UpdateInputAxisProvider() {} // 0x0000000185560414-0x000000018556050C
		public override void PrePipelineMutateCameraState(ref CameraState state, float deltaTime) {} // 0x000000018350B670-0x000000018350B680
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x000000018555FB3C-0x000000018555FDD0
		public Vector2 GetRecenterTarget() => default; // 0x000000018555F90C-0x000000018555FB3C
		private static float NormalizeAngle(float angle) => default; // 0x0000000183D506F0-0x0000000183D50720
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x000000018555F8EC-0x000000018555F90C
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) => default; // 0x000000018555FDD8-0x000000018555FF78
		private void SetAxesForRotation(Quaternion targetRot) {} // 0x000000018555FFF8-0x0000000185560414
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineSameAsFollowTarget : CinemachineComponentBase // TypeDefIndex: 54433
	{
		// Fields
		[FormerlySerializedAs("m_AngularDamping")]
		[Tooltip("How much time it takes for the aim to catch up to the target\'s rotation")]
		public float m_Damping; // 0x20
		private Quaternion m_PreviousReferenceOrientation; // 0x24
	
		// Properties
		public override bool IsValid { get => default; } // 0x000000018556AF18-0x000000018556AF7C 
		public override CinemachineCore.Stage Stage { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public CinemachineSameAsFollowTarget() {} // 0x000000018332EAA0-0x000000018332EAD0
	
		// Methods
		public override float GetMaxDampTime() => default; // 0x0000000183D4F2E0-0x0000000183D4F2F0
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x000000018556AE20-0x000000018556AF18
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineTrackedDolly : CinemachineComponentBase // TypeDefIndex: 54436
	{
		// Fields
		[Tooltip("The path to which the camera will be constrained.  This must be non-null.")]
		public CinemachinePathBase m_Path; // 0x20
		[Tooltip("The position along the path at which the camera will be placed.  This can be animated directly, or set automatically by the Auto-Dolly feature to get as close as possible to the Follow target.  The value is interpreted according to the Position Units setting.")]
		public float m_PathPosition; // 0x28
		[Tooltip("How to interpret Path Position.  If set to Path Units, values are as follows: 0 represents the first waypoint on the path, 1 is the second, and so on.  Values in-between are points on the path in between the waypoints.  If set to Distance, then Path Position represents distance along the path.")]
		public CinemachinePathBase.PositionUnits m_PositionUnits; // 0x2C
		[Tooltip("Where to put the camera relative to the path position.  X is perpendicular to the path, Y is up, and Z is parallel to the path.  This allows the camera to be offset from the path itself (as if on a tripod, for example).")]
		public Vector3 m_PathOffset; // 0x30
		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to maintain its position in a direction perpendicular to the path.  Small numbers are more responsive, rapidly translating the camera to keep the target\'s x-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
		public float m_XDamping; // 0x3C
		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to maintain its position in the path-local up direction.  Small numbers are more responsive, rapidly translating the camera to keep the target\'s y-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
		public float m_YDamping; // 0x40
		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to maintain its position in a direction parallel to the path.  Small numbers are more responsive, rapidly translating the camera to keep the target\'s z-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
		public float m_ZDamping; // 0x44
		[Tooltip("How to set the virtual camera\'s Up vector.  This will affect the screen composition, because the camera Aim behaviours will always try to respect the Up direction.")]
		public CameraUpMode m_CameraUp; // 0x48
		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to track the target rotation\'s X angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
		public float m_PitchDamping; // 0x4C
		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to track the target rotation\'s Y angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
		public float m_YawDamping; // 0x50
		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to track the target rotation\'s Z angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
		public float m_RollDamping; // 0x54
		[Tooltip("Controls how automatic dollying occurs.  A Follow target is necessary to use this feature.")]
		public AutoDolly m_AutoDolly; // 0x58
		private float m_PreviousPathPosition; // 0x68
		private Quaternion m_PreviousOrientation; // 0x6C
		private Vector3 m_PreviousCameraPosition; // 0x7C
	
		// Properties
		public override bool IsValid { get => default; } // 0x000000018556BAA0-0x000000018556BAFC 
		public override CinemachineCore.Stage Stage { get => default; } // 0x0000000181002730-0x0000000181002740 
		private Vector3 AngularDamping { get => default; } // 0x000000018556BA30-0x000000018556BAA0 
	
		// Nested types
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum CameraUpMode // TypeDefIndex: 54434
		{
			Default = 0,
			Path = 1,
			PathNoRoll = 2,
			FollowTarget = 3,
			FollowTargetNoRoll = 4
		}
	
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct AutoDolly // TypeDefIndex: 54435
		{
			// Fields
			[Tooltip("If checked, will enable automatic dolly, which chooses a path position that is as close as possible to the Follow target.  Note: this can have significant performance impact")]
			public bool m_Enabled; // 0x00
			[Tooltip("Offset, in current position units, from the closest point on the path to the follow target")]
			public float m_PositionOffset; // 0x04
			[Tooltip("Search up to this many waypoints on either side of the current position.  Use 0 for Entire path.")]
			public int m_SearchRadius; // 0x08
			[FormerlySerializedAs("m_StepsPerSegment")]
			[Tooltip("We search between waypoints by dividing the segment into this many straight pieces.  he higher the number, the more accurate the result, but performance is proportionally slower for higher numbers")]
			public int m_SearchResolution; // 0x0C
	
			// Constructors
			public AutoDolly(bool enabled, float positionOffset, int searchRadius, int stepsPerSegment) {
				m_Enabled = default;
				m_PositionOffset = default;
				m_SearchRadius = default;
				m_SearchResolution = default;
			} // 0x0000000183D50910-0x0000000183D50930
		}
	
		// Constructors
		public CinemachineTrackedDolly() {} // 0x000000018332EAD0-0x000000018332EB50
	
		// Methods
		public override float GetMaxDampTime() => default; // 0x000000018556B1B8-0x000000018556B210
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x000000018556B210-0x000000018556BA30
		private Quaternion GetCameraOrientationAtPathPoint(Quaternion pathOrientation, Vector3 up) => default; // 0x000000018556AF7C-0x000000018556B1B8
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineTransposer : CinemachineComponentBase // TypeDefIndex: 54439
	{
		// Fields
		[Tooltip("The coordinate space to use when interpreting the offset from the target.  This is also used to set the camera\'s Up vector, which will be maintained when aiming the camera.")]
		public BindingMode m_BindingMode; // 0x20
		[Tooltip("The distance vector that the transposer will attempt to maintain from the Follow target")]
		public Vector3 m_FollowOffset; // 0x24
		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to maintain the offset in the X-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target\'s x-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
		public float m_XDamping; // 0x30
		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to maintain the offset in the Y-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target\'s y-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
		public float m_YDamping; // 0x34
		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to maintain the offset in the Z-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target\'s z-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
		public float m_ZDamping; // 0x38
		public AngularDampingMode m_AngularDampingMode; // 0x3C
		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to track the target rotation\'s X angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
		public float m_PitchDamping; // 0x40
		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to track the target rotation\'s Y angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
		public float m_YawDamping; // 0x44
		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to track the target rotation\'s Z angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
		public float m_RollDamping; // 0x48
		[Range(0f, 20f)]
		[Tooltip("How aggressively the camera tries to track the target\'s orientation.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
		public float m_AngularDamping; // 0x4C
		private Vector3 m_PreviousTargetPosition; // 0x54
		private Quaternion m_PreviousReferenceOrientation; // 0x60
		private Quaternion m_targetOrientationOnAssign; // 0x70
		private Vector3 m_PreviousOffset; // 0x80
		private Transform m_previousTarget; // 0x90
	
		// Properties
		public bool HideOffsetInInspector { get; set; } // 0x0000000183D4F000-0x0000000183D4F010 0x0000000183D4F030-0x0000000183D4F040
		public Vector3 EffectiveOffset { get => default; } // 0x0000000182B23BC0-0x0000000182B23BE0 
		public override bool IsValid { get => default; } // 0x00000001835FE310-0x00000001835FE390 
		public override CinemachineCore.Stage Stage { get => default; } // 0x0000000181002730-0x0000000181002740 
		protected Vector3 Damping { get => default; } // 0x0000000182B22CC0-0x0000000182B22CF0 
		protected Vector3 AngularDamping { get => default; } // 0x0000000182B22CF0-0x0000000182B22D20 
	
		// Nested types
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum BindingMode // TypeDefIndex: 54437
		{
			LockToTargetOnAssign = 0,
			LockToTargetWithWorldUp = 1,
			LockToTargetNoRoll = 2,
			LockToTarget = 3,
			WorldSpace = 4,
			SimpleFollowWithWorldUp = 5
		}
	
		public enum AngularDampingMode // TypeDefIndex: 54438
		{
			Euler = 0,
			Quaternion = 1
		}
	
		// Constructors
		public CinemachineTransposer() {} // 0x000000018332EBB0-0x000000018332EC60
	
		// Methods
		protected virtual void OnValidate() {} // 0x000000018556BED0-0x000000018556BF00
		public override float GetMaxDampTime() => default; // 0x000000018556BC7C-0x000000018556BCFC
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x0000000182B238A0-0x0000000182B23BC0
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x000000018556BE10-0x000000018556BED0
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x000000018556BAFC-0x000000018556BC7C
		protected void InitPrevFrameStateInfo(ref CameraState curState, float deltaTime) {} // 0x0000000182B22D20-0x0000000182B22EA0
		protected void TrackTarget(float deltaTime, Vector3 up, Vector3 desiredCameraOffset, out Vector3 outTargetPosition, out Quaternion outTargetOrient) {
			outTargetPosition = default;
			outTargetOrient = default;
		} // 0x0000000182B22EA0-0x0000000182B237A0
		protected Vector3 GetOffsetForMinimumTargetDistance(Vector3 dampedTargetPos, Vector3 cameraOffset, Vector3 cameraFwd, Vector3 up, Vector3 actualTargetPos) => default; // 0x0000000182B23C90-0x0000000182B24190
		public virtual Vector3 GetTargetCameraPosition(Vector3 worldUp) => default; // 0x000000018556BCFC-0x000000018556BE10
		public Quaternion GetReferenceOrientation(Vector3 worldUp) => default; // 0x0000000182B237A0-0x0000000182B238A0
	}

	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public struct AxisState // TypeDefIndex: 54443
	{
		// Fields
		[NoSaveDuringPlay]
		[Tooltip("The current value of the axis.")]
		public float Value; // 0x00
		[Tooltip("How to interpret the Max Speed setting: in units/second, or as a direct input value multiplier")]
		public SpeedMode m_SpeedMode; // 0x04
		[Tooltip("The maximum speed of this axis in units/second, or the input value multiplier, depending on the Speed Mode")]
		public float m_MaxSpeed; // 0x08
		[Tooltip("The amount of time in seconds it takes to accelerate to MaxSpeed with the supplied Axis at its maximum value")]
		public float m_AccelTime; // 0x0C
		[Tooltip("The amount of time in seconds it takes to decelerate the axis to zero if the supplied axis is in a neutral position")]
		public float m_DecelTime; // 0x10
		[FormerlySerializedAs("m_AxisName")]
		[Tooltip("The name of this axis as specified in Unity Input manager. Setting to an empty string will disable the automatic updating of this axis")]
		public string m_InputAxisName; // 0x18
		[NoSaveDuringPlay]
		[Tooltip("The value of the input axis.  A value of 0 means no input.  You can drive this directly from a custom input system, or you can set the Axis Name and have the value driven by the internal Input Manager")]
		public float m_InputAxisValue; // 0x20
		[FormerlySerializedAs("m_InvertAxis")]
		[Tooltip("If checked, then the raw value of the input axis will be inverted before it is used")]
		public bool m_InvertInput; // 0x24
		[Tooltip("The minimum value for the axis")]
		public float m_MinValue; // 0x28
		[Tooltip("The maximum value for the axis")]
		public float m_MaxValue; // 0x2C
		[Tooltip("If checked, then the axis will wrap around at the min/max values, forming a loop")]
		public bool m_Wrap; // 0x30
		[Tooltip("Automatic recentering to at-rest position")]
		public Recentering m_Recentering; // 0x34
		private float m_CurrentSpeed; // 0x50
		private float m_LastUpdateTime; // 0x54
		private int m_LastUpdateFrame; // 0x58
		private const float Epsilon = 0.0001f; // Metadata: 0x01FD6649
		private IInputAxisProvider m_InputAxisProvider; // 0x60
		private int m_InputAxisIndex; // 0x68
	
		// Properties
		public bool ValueRangeLocked { get; set; } // 0x0000000183D50950-0x0000000183D50960
		public bool HasRecentering { get; set; } // 0x0000000183D50940-0x0000000183D50950
	
		// Nested types
		public enum SpeedMode // TypeDefIndex: 54440
		{
			MaxSpeed = 0,
			InputValueGain = 1
		}
	
		public interface IInputAxisProvider // TypeDefIndex: 54441
		{
			// Methods
			float GetAxisValue(int axis);
		}
	
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct Recentering // TypeDefIndex: 54442
		{
			// Fields
			[Tooltip("If checked, will enable automatic recentering of the axis. If unchecked, recenting is disabled.")]
			public bool m_enabled; // 0x00
			[Tooltip("If no user input has been detected on the axis, the axis will wait this long in seconds before recentering.")]
			public float m_WaitTime; // 0x04
			[Tooltip("How long it takes to reach destination once recentering has started.")]
			public float m_RecenteringTime; // 0x08
			private float mLastAxisInputTime; // 0x0C
			private float mRecenteringVelocity; // 0x10
			[FormerlySerializedAs("m_HeadingDefinition")]
			[HideInInspector]
			[SerializeField]
			private int m_LegacyHeadingDefinition; // 0x14
			[FormerlySerializedAs("m_VelocityFilterStrength")]
			[HideInInspector]
			[SerializeField]
			private int m_LegacyVelocityFilterStrength; // 0x18
	
			// Constructors
			public Recentering(bool enabled, float waitTime, float recenteringTime) {
				m_enabled = default;
				m_WaitTime = default;
				m_RecenteringTime = default;
				mLastAxisInputTime = default;
				mRecenteringVelocity = default;
				m_LegacyHeadingDefinition = default;
				m_LegacyVelocityFilterStrength = default;
			} // 0x0000000183D50AA0-0x0000000183D50AC0
	
			// Methods
			public void Validate() {} // 0x000000018556E23C-0x000000018556E25C
			public void CancelRecentering() {} // 0x000000018556E024-0x000000018556E078
			public void DoRecentering(ref AxisState axis, float deltaTime, float recenterTarget) {} // 0x000000018556E078-0x000000018556E214
			internal bool LegacyUpgrade(ref int heading, ref int velocityFilter) => default; // 0x000000018556E214-0x000000018556E23C
		}
	
		// Constructors
		public AxisState(float minValue, float maxValue, bool wrap, bool rangeLocked, float maxSpeed, float accelTime, float decelTime, string name, bool invert) : this() {
			Value = default;
			m_SpeedMode = default;
			m_MaxSpeed = default;
			m_AccelTime = default;
			m_DecelTime = default;
			m_InputAxisName = default;
			m_InputAxisValue = default;
			m_InvertInput = default;
			m_MinValue = default;
			m_MaxValue = default;
			m_Wrap = default;
			m_Recentering = default;
			m_CurrentSpeed = default;
			m_LastUpdateTime = default;
			m_LastUpdateFrame = default;
			m_InputAxisProvider = default;
			m_InputAxisIndex = default;
		} // 0x0000000185567DD4-0x0000000185567EB4
	
		// Methods
		public void Validate() {} // 0x0000000185567D8C-0x0000000185567DD4
		public void Reset() {} // 0x0000000183D50930-0x0000000183D50940
		public void SetInputAxisProvider(int axis, IInputAxisProvider provider) {} // 0x00000001855679B0-0x00000001855679C0
		public bool Update(float deltaTime) => default; // 0x00000001855679C0-0x0000000185567D8C
		private float ClampValue(float v) => default; // 0x00000001855676E8-0x0000000185567758
		private bool MaxSpeedUpdate(float input, float deltaTime) => default; // 0x00000001855677D0-0x00000001855679B0
		private float GetMaxSpeed() => default; // 0x0000000185567758-0x00000001855677D0
	}

	public struct CameraState // TypeDefIndex: 54447
	{
		// Fields
		public HGDOFParams DofParams; // 0x00
		public LensSettings Lens; // 0x20
		public Vector3 ReferenceUp; // 0x50
		public Vector3 ReferenceLookAt; // 0x5C
		public Vector3 Pivot; // 0x68
		public Vector3 NoOffsetPivot; // 0x74
		public static Vector3 kNoPoint; // 0x00
		public Vector3 RawPosition; // 0x80
		public Quaternion RawOrientation; // 0x8C
		public Vector3 PositionDampingBypass; // 0x9C
		public float ShotQuality; // 0xA8
		public Vector3 PositionCorrection; // 0xAC
		public Quaternion OrientationCorrection; // 0xB8
		public BlendHintValue BlendHint; // 0xC8
		private CustomBlendable mCustom0; // 0xD0
		private CustomBlendable mCustom1; // 0xE0
		private CustomBlendable mCustom2; // 0xF0
		private CustomBlendable mCustom3; // 0x100
		private List<CustomBlendable> m_CustomOverflow; // 0x110
	
		// Properties
		public bool HasLookAt { get => default; } // 0x00000001842715FC-0x0000000184271650 
		public Vector3 CorrectedPosition { get => default; } // 0x0000000182746180-0x00000001827461F0 
		public Quaternion CorrectedOrientation { get => default; } // 0x000000018274D400-0x000000018274D450 
		public Vector3 FinalPosition { get => default; } // 0x0000000182746180-0x00000001827461F0 
		public Quaternion FinalOrientation { get => default; } // 0x000000018274D360-0x000000018274D400 
		public static CameraState Default { get => default; } // 0x0000000182749660-0x00000001827497E0 
		public int NumCustomBlendables { [IsReadOnly] get; private set; } // 0x0000000183D50A10-0x0000000183D50A20 0x0000000183D50A20-0x0000000183D50A30
	
		// Nested types
		public struct HGDOFParams // TypeDefIndex: 54444
		{
			// Fields
			public bool enabledForVirtualCamera; // 0x00
			public bool enable; // 0x01
			public float nearRadius; // 0x04
			public float nearFocusStart; // 0x08
			public float nearFocusEnd; // 0x0C
			public float farRadius; // 0x10
			public float farFocusStart; // 0x14
			public float farFocusEnd; // 0x18
			public float temporalFactor; // 0x1C
		}
	
		public enum BlendHintValue // TypeDefIndex: 54445
		{
			Nothing = 0,
			NoPosition = 1,
			NoOrientation = 2,
			NoTransform = 3,
			SphericalPositionBlend = 4,
			CylindricalPositionBlend = 8,
			RadialAimBlend = 16,
			IgnoreLookAtTarget = 32,
			NoLens = 64
		}
	
		public struct CustomBlendable // TypeDefIndex: 54446
		{
			// Fields
			public UnityEngine.Object m_Custom; // 0x00
			public float m_Weight; // 0x08
	
			// Constructors
			public CustomBlendable(UnityEngine.Object custom, float weight) {
				m_Custom = default;
				m_Weight = default;
			} // 0x000000018556D9B4-0x000000018556D9D0
		}
	
		// Constructors
		static CameraState() {
			kNoPoint = default;
		} // 0x0000000183D2A840-0x0000000183D2A890
	
		// Methods
		public CustomBlendable GetCustomBlendable(int index) => default; // 0x00000001855692C4-0x00000001855693B0
		private int FindCustomBlendable(UnityEngine.Object custom) => default; // 0x0000000185569140-0x00000001855692C4
		public void AddCustomBlendable(CustomBlendable b) {} // 0x0000000185568F94-0x0000000185569140
		public static CameraState Lerp([IsReadOnly] in CameraState stateA, [IsReadOnly] in CameraState stateB, float t) => default; // 0x000000018257F400-0x00000001825803D0
		private static float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t) => default; // 0x00000001855693B0-0x00000001855694DC
		private static Vector3 ApplyPosBlendHint(Vector3 posA, BlendHintValue hintA, Vector3 posB, BlendHintValue hintB, Vector3 original, Vector3 blended) => default; // 0x0000000182580400-0x0000000182580430
		private static Quaternion ApplyRotBlendHint(Quaternion rotA, BlendHintValue hintA, Quaternion rotB, BlendHintValue hintB, Quaternion original, Quaternion blended) => default; // 0x00000001825803D0-0x0000000182580400
		private Vector3 InterpolatePosition(Vector3 posA, Vector3 pivotA, Vector3 posB, Vector3 pivotB, float t, ref int positionCylindricalDir) => default; // 0x00000001833BF420-0x00000001833BF860
	}

	public class CinemachineBlend // TypeDefIndex: 54448
	{
		// Fields
		private ICinemachineCamera m_CamA; // 0x10
		public ICinemachineCamera CamB; // 0x18
		public bool useSimpleInertialization; // 0x20
		public bool InitStateGot; // 0x21
		public CameraState InitStateA; // 0x28
		public CameraState CurrStateA; // 0x148
		public CameraState InitStateB; // 0x268
		public AnimationCurve BlendCurve; // 0x388
		public float TimeInBlend; // 0x390
		public float Duration; // 0x394
	
		// Properties
		public ICinemachineCamera CamA { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018274DE20-0x000000018274DF30
		public float BlendWeight { get => default; } // 0x00000001855694DC-0x0000000185569554 
		public bool IsValid { get => default; } // 0x0000000185569724-0x000000018556976C 
		public bool IsComplete { get => default; } // 0x00000001855696FC-0x0000000185569724 
		public string Description { get => default; } // 0x0000000185569554-0x00000001855696FC 
		public CameraState State { get => default; } // 0x000000018274D0C0-0x000000018274D360 
	
		// Constructors
		public CinemachineBlend() {} // Dummy constructor
		public CinemachineBlend(ICinemachineCamera a, ICinemachineCamera b, AnimationCurve curve, float duration, float t) {} // 0x0000000183171A90-0x0000000183171B00
	
		// Methods
		public void StartSimpleInertialization() {} // 0x0000000183D50A30-0x0000000183D50A40
		public bool Uses(ICinemachineCamera cam) => default; // 0x000000018274BAE0-0x000000018274BB70
		public void UpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x000000018274C030-0x000000018274C110
	}

	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public struct CinemachineBlendDefinition // TypeDefIndex: 54450
	{
		// Fields
		[Tooltip("Shape of the blend curve")]
		public Style m_Style; // 0x00
		[Tooltip("Duration of the blend, in seconds")]
		public float m_Time; // 0x04
		public AnimationCurve m_CustomCurve; // 0x08
		private static AnimationCurve[] sStandardCurves; // 0x00
		[Tooltip("use of simple inertialization")]
		public bool m_UseSimpleInertialization; // 0x10
	
		// Properties
		public float BlendTime { get => default; } // 0x000000018257D980-0x000000018257D990 
		public AnimationCurve BlendCurve { get => default; } // 0x000000018257E580-0x000000018257E610 
	
		// Nested types
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum Style // TypeDefIndex: 54449
		{
			Cut = 0,
			EaseInOut = 1,
			EaseIn = 2,
			EaseOut = 3,
			HardIn = 4,
			HardOut = 5,
			Linear = 6,
			Custom = 7
		}
	
		// Constructors
		public CinemachineBlendDefinition(Style style, float time) : this() {
			m_Style = default;
			m_Time = default;
			m_CustomCurve = default;
			m_UseSimpleInertialization = default;
		} // 0x0000000184275A64-0x0000000184275A90
	
		// Methods
		private void CreateStandardCurves() {} // 0x000000018257E060-0x000000018257E580
	}

	internal class StaticPointVirtualCamera : ICinemachineCamera // TypeDefIndex: 54451
	{
		// Properties
		public string Name { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public int Priority { get; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public Transform LookAt { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public Transform Follow { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public CameraState State { get; private set; } // 0x0000000183D50990-0x0000000183D50A10 0x0000000185568A70-0x0000000185568AE4
		public GameObject VirtualCameraGameObject { get => default; } // 0x0000000181002730-0x0000000181002740 
		public bool IsValid { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public ICinemachineCamera ParentCamera { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public StaticPointVirtualCamera() {} // Dummy constructor
		public StaticPointVirtualCamera([IsReadOnly] in CameraState state, string name) {} // 0x000000018556EA2C-0x000000018556EB24
	
		// Methods
		public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x01FD6661 */) => default; // 0x000000018115F4C0-0x000000018115F530
		public void UpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x000000018350B670-0x000000018350B680
		public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x000000018350B670-0x000000018350B680
	}

	internal class BlendSourceVirtualCamera : ICinemachineCamera // TypeDefIndex: 54452
	{
		// Properties
		public CinemachineBlend Blend { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public string Name { get => default; } // 0x0000000185568A44-0x0000000185568A70 
		public int Priority { get; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public Transform LookAt { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public Transform Follow { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public CameraState State { get; private set; } // 0x0000000183D50990-0x0000000183D50A10 0x0000000185568A70-0x0000000185568AE4
		public GameObject VirtualCameraGameObject { get => default; } // 0x0000000181002730-0x0000000181002740 
		public bool IsValid { get => default; } // 0x0000000185568A2C-0x0000000185568A44 
		public ICinemachineCamera ParentCamera { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public BlendSourceVirtualCamera() {} // Dummy constructor
		public BlendSourceVirtualCamera(CinemachineBlend blend) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x01FD6662 */) => default; // 0x0000000185568938-0x0000000185568958
		public void UpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x0000000185568958-0x0000000185568A2C
		public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineBlending.html")]
	public sealed class CinemachineBlenderSettings : ScriptableObject // TypeDefIndex: 54455
	{
		// Fields
		[Tooltip("The array containing explicitly defined blends between two Virtual Cameras")]
		public CustomBlend[] m_CustomBlends; // 0x18
		public CustomBlendGroup[] m_CustomBlendGroups; // 0x20
		public const string kBlendFromAnyCameraLabel = "**ANY CAMERA**"; // Metadata: 0x01FD6663
	
		// Nested types
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct CustomBlend // TypeDefIndex: 54453
		{
			// Fields
			[Tooltip("When blending from this camera")]
			public string m_From; // 0x00
			[Tooltip("When blending to this camera")]
			public string m_To; // 0x08
			[CinemachineBlendDefinitionProperty]
			[Tooltip("Blend curve definition")]
			public CinemachineBlendDefinition m_Blend; // 0x10
		}
	
		[Serializable]
		public class CustomBlendGroup // TypeDefIndex: 54454
		{
			// Fields
			[Tooltip("Camera belong to this group")]
			public List<string> cameras; // 0x10
			[CinemachineBlendDefinitionProperty]
			public CinemachineBlendDefinition fromSameCamera; // 0x18
			[CinemachineBlendDefinitionProperty]
			[FormerlySerializedAs("fromGroupInside")]
			public CinemachineBlendDefinition insideGroup; // 0x30
			[CinemachineBlendDefinitionProperty]
			[FormerlySerializedAs("toGroupOutside")]
			public CinemachineBlendDefinition toGroup; // 0x48
			[CinemachineBlendDefinitionProperty]
			[FormerlySerializedAs("fromGroupOutSid")]
			public CinemachineBlendDefinition fromGroup; // 0x60
	
			// Constructors
			public CustomBlendGroup() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public CinemachineBlenderSettings() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		public CinemachineBlendDefinition GetBlendForVirtualCameras(string fromCameraName, string toCameraName, CinemachineBlendDefinition defaultBlend) => default; // 0x000000018332DCF0-0x000000018332E060
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public abstract class CinemachineComponentBase : MonoBehaviour // TypeDefIndex: 54456
	{
		// Fields
		protected const float Epsilon = 0.0001f; // Metadata: 0x01FD6672
		private CinemachineVirtualCameraBase m_vcamOwner; // 0x18
	
		// Properties
		public CinemachineVirtualCameraBase VirtualCamera { get; } // 0x0000000182747860-0x0000000182747AF0 
		public Transform FollowTarget { get; } // 0x0000000182746AF0-0x0000000182746C60 
		public Transform LookAtTarget { get; } // 0x0000000182746C60-0x0000000182746DD0 
		public ICinemachineTargetGroup AbstractFollowTargetGroup { get; } // 0x000000018556976C-0x0000000185569790 
		public CinemachineTargetGroup FollowTargetGroup { get; } // 0x00000001855697B4-0x00000001855697F8 
		public Vector3 FollowTargetPosition { get; } // 0x0000000182B249C0-0x0000000182B24AE0 
		public Quaternion FollowTargetRotation { get; } // 0x0000000182B248B0-0x0000000182B249C0 
		public ICinemachineTargetGroup AbstractLookAtTargetGroup { get; } // 0x0000000185569790-0x00000001855697B4 
		public CinemachineTargetGroup LookAtTargetGroup { get; } // 0x00000001855697F8-0x000000018556983C 
		public Vector3 LookAtTargetPosition { get; } // 0x000000018556983C-0x00000001855699C4 
		public Quaternion LookAtTargetRotation { get; } // 0x0000000182744600-0x0000000182744710 
		public CameraState VcamState { get; } // 0x00000001855699C4-0x0000000185569B2C 
		public abstract bool IsValid { get; }
		public abstract CinemachineCore.Stage Stage { get; }
		public virtual bool BodyAppliesAfterAim { get; } // 0x000000018115F4C0-0x000000018115F530 
		public virtual bool RequiresUserInput { get; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		protected CinemachineComponentBase() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public virtual void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime) {} // 0x000000018350B670-0x000000018350B680
		public abstract void MutateCameraState(ref CameraState curState, float deltaTime);
		public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x000000018350B670-0x000000018350B680
		public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x000000018350B670-0x000000018350B680
		public virtual float GetMaxDampTime() => default; // 0x0000000183D503F0-0x0000000183D50400
	}

	public sealed class CinemachineCore // TypeDefIndex: 54463
	{
		// Fields
		public static readonly int kStreamingVersion; // 0x00
		public static readonly string kVersionString; // 0x08
		private static CinemachineCore sInstance; // 0x10
		public static bool sShowHiddenObjects; // 0x18
		public static AxisInputDelegate GetInputAxis; // 0x20
		public static float UniformDeltaTimeOverride; // 0x28
		public static float CurrentTimeOverride; // 0x2C
		public static GetBlendOverrideDelegate GetBlendOverride; // 0x30
		public static CinemachineBrain.BrainEvent CameraUpdatedEvent; // 0x38
		public static CinemachineBrain.BrainEvent CameraCutEvent; // 0x40
		private List<CinemachineBrain> mActiveBrains; // 0x10
		private List<CinemachineVirtualCameraBase> mActiveCameras; // 0x18
		private bool m_ActiveCamerasAreSorted; // 0x20
		private int m_ActivationSequence; // 0x24
		private List<List<CinemachineVirtualCameraBase>> mAllCameras; // 0x28
		private CinemachineVirtualCameraBase mRoundRobinVcamLastFrame; // 0x30
		private static float s_LastUpdateTime; // 0x48
		private static int s_FixedFrameCount; // 0x4C
		private Dictionary<CinemachineVirtualCameraBase, UpdateStatus> mUpdateStatus; // 0x38
		internal UpdateFilter m_CurrentUpdateFilter; // 0x40
	
		// Properties
		public static CinemachineCore Instance { get => default; } // 0x000000018274AC70-0x000000018274AD70 
		public static float DeltaTime { get => default; } // 0x000000018556A108-0x000000018556A178 
		public static float CurrentTime { get => default; } // 0x000000018274BFC0-0x000000018274C030 
		public int BrainCount { get => default; } // 0x0000000182749D60-0x0000000182749DA0 
		public int VirtualCameraCount { get => default; } // 0x000000018274AFC0-0x000000018274B000 
	
		// Nested types
		public enum Stage // TypeDefIndex: 54457
		{
			Body = 0,
			Aim = 1,
			Noise = 2,
			Finalize = 3
		}
	
		public delegate float AxisInputDelegate(string axisName); // TypeDefIndex: 54458; 0x000000018102B410-0x000000018102B420
	
		public delegate CinemachineBlendDefinition GetBlendOverrideDelegate(ICinemachineCamera fromVcam, ICinemachineCamera toVcam, CinemachineBlendDefinition defaultBlend, MonoBehaviour owner); // TypeDefIndex: 54459; 0x000000018556D9D0-0x000000018556DA40
	
		private class UpdateStatus // TypeDefIndex: 54460
		{
			// Fields
			public int lastUpdateFrame; // 0x10
			public int lastUpdateFixedFrame; // 0x14
			public UpdateTracker.UpdateClock lastUpdateMode; // 0x18
			public float lastUpdateDeltaTime; // 0x1C
	
			// Constructors
			public UpdateStatus() {} // 0x000000018350B670-0x000000018350B680
		}
	
		internal enum UpdateFilter // TypeDefIndex: 54461
		{
			Fixed = 0,
			Late = 1,
			Smart = 8,
			SmartFixed = 8,
			SmartLate = 9
		}
	
		// Constructors
		public CinemachineCore() {} // 0x00000001833182B0-0x00000001833183C0
		static CinemachineCore() {} // 0x00000001831716F0-0x00000001831718F0
	
		// Methods
		public CinemachineBrain GetActiveBrain(int index) => default; // 0x000000018274B000-0x000000018274B070
		internal void AddActiveBrain(CinemachineBrain brain) {} // 0x0000000183171170-0x00000001831711E0
		internal void RemoveActiveBrain(CinemachineBrain brain) {} // 0x00000001831711E0-0x0000000183171240
		public CinemachineVirtualCameraBase GetVirtualCamera(int index) => default; // 0x000000018274A8E0-0x000000018274A9C0
		internal void AddActiveCamera(CinemachineVirtualCameraBase vcam) {} // 0x0000000183318CD0-0x0000000183318D40
		internal void RemoveActiveCamera(CinemachineVirtualCameraBase vcam) {} // 0x0000000183318C40-0x0000000183318CD0
		internal void CameraDestroyed(CinemachineVirtualCameraBase vcam) {} // 0x0000000185569B2C-0x0000000185569BF8
		internal void CameraEnabled(CinemachineVirtualCameraBase vcam) {} // 0x0000000183318D40-0x0000000183318F40
		internal void CameraDisabled(CinemachineVirtualCameraBase vcam) {} // 0x0000000183318A40-0x0000000183318B30
		internal void UpdateAllActiveVirtualCameras(int layerMask, Vector3 worldUp, float deltaTime) {} // 0x000000018274BB70-0x000000018274BFC0
		internal void UpdateVirtualCamera(CinemachineVirtualCameraBase vcam, Vector3 worldUp, float deltaTime) {} // 0x0000000182748CC0-0x0000000182749090
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule() {} // 0x0000000183CB9CF0-0x0000000183CB9DA0
		private static Transform GetUpdateTarget(CinemachineVirtualCameraBase vcam) => default; // 0x0000000185569E40-0x0000000185569F38
		internal UpdateTracker.UpdateClock GetVcamUpdateStatus(CinemachineVirtualCameraBase vcam) => default; // 0x0000000185569F38-0x0000000185569FB4
		public bool IsLive(ICinemachineCamera vcam) => default; // 0x0000000182749AE0-0x0000000182749D60
		public bool IsLiveInBlend(ICinemachineCamera vcam) => default; // 0x0000000185569FB4-0x000000018556A074
		public void GenerateCameraActivationEvent(ICinemachineCamera vcam, ICinemachineCamera vcamFrom) {} // 0x0000000185569BF8-0x0000000185569CF0
		public void GenerateCameraCutEvent(ICinemachineCamera vcam) {} // 0x0000000185569CF0-0x0000000185569E40
		public CinemachineBrain FindPotentialTargetBrain(CinemachineVirtualCameraBase vcam) => default; // 0x0000000182749DA0-0x000000018274A2C0
		public void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x000000018556A074-0x000000018556A108
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public abstract class CinemachineExtension : MonoBehaviour // TypeDefIndex: 54464
	{
		// Fields
		protected const float Epsilon = 0.0001f; // Metadata: 0x01FD667F
		private CinemachineVirtualCameraBase m_vcamOwner; // 0x18
		private Dictionary<ICinemachineCamera, object> mExtraState; // 0x20
	
		// Properties
		public CinemachineVirtualCameraBase VirtualCamera { get; } // 0x0000000182743A50-0x0000000182743AE0 
		public virtual bool RequiresUserInput { get; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		protected CinemachineExtension() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected virtual void Awake() {} // 0x0000000183CA4A50-0x0000000183CA4A60
		protected virtual void OnEnable() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnDestroy() {} // 0x000000018556A178-0x000000018556A188
		internal void EnsureStarted() {} // 0x0000000183CA4A50-0x0000000183CA4A60
		protected virtual void ConnectToVcam(bool connect) {} // 0x0000000182742640-0x0000000182742760
		public virtual void PrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState curState, float deltaTime) {} // 0x000000018350B670-0x000000018350B680
		public void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x0000000184271650-0x0000000184271670
		protected abstract void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime);
		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x000000018350B670-0x000000018350B680
		public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x000000018350B670-0x000000018350B680
		public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual float GetMaxDampTime() => default; // 0x0000000183D503F0-0x0000000183D50400
		protected T GetExtraState<T>(ICinemachineCamera vcam)
			where T : class, new() => default;
		protected List<T> GetAllExtraStates<T>()
			where T : class, new() => default;
	}

	public abstract class CinemachinePathBase : MonoBehaviour // TypeDefIndex: 54467
	{
		// Fields
		[Range(1f, 100f)]
		[Tooltip("Path samples per waypoint.  This is used for calculating path distances.")]
		public int m_Resolution; // 0x18
		[Tooltip("The settings that control how the path will appear in the editor scene view.")]
		public Appearance m_Appearance; // 0x20
		private float[] m_DistanceToPos; // 0x28
		private float[] m_PosToDistance; // 0x30
		private int m_CachedSampleSteps; // 0x38
		private float m_PathLength; // 0x3C
		private float m_cachedPosStepSize; // 0x40
		private float m_cachedDistanceStepSize; // 0x44
	
		// Properties
		public abstract float MinPos { get; }
		public abstract float MaxPos { get; }
		public abstract bool Looped { get; }
		public abstract int DistanceCacheSampleStepsPerSegment { get; }
		public float PathLength { get; } // 0x000000018556ADCC-0x000000018556AE20 
	
		// Nested types
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public class Appearance // TypeDefIndex: 54465
		{
			// Fields
			[Tooltip("The color of the path itself when it is active in the editor")]
			public UnityEngine.Color pathColor; // 0x10
			[Tooltip("The color of the path itself when it is inactive in the editor")]
			public UnityEngine.Color inactivePathColor; // 0x20
			[Range(0f, 10f)]
			[Tooltip("The width of the railroad-tracks that are drawn to represent the path")]
			public float width; // 0x30
	
			// Constructors
			public Appearance() {} // 0x00000001855676B0-0x00000001855676E8
		}
	
		public enum PositionUnits // TypeDefIndex: 54466
		{
			PathUnits = 0,
			Distance = 1,
			Normalized = 2
		}
	
		// Constructors
		protected CinemachinePathBase() {} // 0x000000018556AD54-0x000000018556ADCC
	
		// Methods
		public virtual float StandardizePos(float pos) => default; // 0x000000018556AB1C-0x000000018556ABC0
		public abstract Vector3 EvaluatePosition(float pos);
		public abstract Vector3 EvaluateTangent(float pos);
		public abstract Quaternion EvaluateOrientation(float pos);
		public virtual float FindClosestPoint(Vector3 p, int startSegment, int searchRadius, int stepsPerSegment) => default; // 0x000000018556A2F4-0x000000018556A608
		public float MinUnit(PositionUnits units) => default; // 0x000000018556A76C-0x000000018556A794
		public float MaxUnit(PositionUnits units) => default; // 0x000000018556A734-0x000000018556A76C
		public virtual float StandardizeUnit(float pos, PositionUnits units) => default; // 0x000000018556ABC0-0x000000018556AC38
		public Vector3 EvaluatePositionAtUnit(float pos, PositionUnits units) => default; // 0x000000018556A24C-0x000000018556A2A0
		public Vector3 EvaluateTangentAtUnit(float pos, PositionUnits units) => default; // 0x000000018556A2A0-0x000000018556A2F4
		public Quaternion EvaluateOrientationAtUnit(float pos, PositionUnits units) => default; // 0x000000018556A200-0x000000018556A24C
		public virtual void InvalidateDistanceCache() {} // 0x000000018556A704-0x000000018556A734
		public bool DistanceCacheIsValid() => default; // 0x000000018556A188-0x000000018556A200
		public float StandardizePathDistance(float distance) => default; // 0x000000018556AA88-0x000000018556AB1C
		public float ToNativePathUnits(float pos, PositionUnits units) => default; // 0x000000018556AC38-0x000000018556AD54
		public float FromPathNativeUnits(float pos, PositionUnits units) => default; // 0x000000018556A608-0x000000018556A704
		private void ResamplePath(int stepsPerSegment) {} // 0x000000018556A794-0x000000018556AA88
	}

	public sealed class AxisStatePropertyAttribute : PropertyAttribute // TypeDefIndex: 54468
	{
		// Constructors
		public AxisStatePropertyAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public sealed class OrbitalTransposerHeadingPropertyAttribute : PropertyAttribute // TypeDefIndex: 54469
	{
		// Constructors
		public OrbitalTransposerHeadingPropertyAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public sealed class VcamTargetPropertyAttribute : PropertyAttribute // TypeDefIndex: 54470
	{
		// Constructors
		public VcamTargetPropertyAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public sealed class CinemachineBlendDefinitionPropertyAttribute : PropertyAttribute // TypeDefIndex: 54471
	{
		// Constructors
		public CinemachineBlendDefinitionPropertyAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public sealed class SaveDuringPlayAttribute : Attribute // TypeDefIndex: 54472
	{
		// Constructors
		public SaveDuringPlayAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public sealed class NoSaveDuringPlayAttribute : PropertyAttribute // TypeDefIndex: 54473
	{
		// Constructors
		public NoSaveDuringPlayAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public sealed class TagFieldAttribute : PropertyAttribute // TypeDefIndex: 54474
	{
		// Constructors
		public TagFieldAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public sealed class NoiseSettingsPropertyAttribute : PropertyAttribute // TypeDefIndex: 54475
	{
		// Constructors
		public NoiseSettingsPropertyAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public sealed class CinemachineEmbeddedAssetPropertyAttribute : PropertyAttribute // TypeDefIndex: 54476
	{
		// Fields
		public bool WarnIfNull; // 0x10
	
		// Constructors
		public CinemachineEmbeddedAssetPropertyAttribute() {} // Dummy constructor
		public CinemachineEmbeddedAssetPropertyAttribute(bool warnIfNull = false /* Metadata: 0x01FD6686 */) {} // 0x0000000183D4E960-0x0000000183D4E970
	}

	[DocumentationSorting(Level.Undoc)]
	public sealed class DocumentationSortingAttribute : Attribute // TypeDefIndex: 54478
	{
		// Properties
		private Level Category { get; set; } // 0x00000001810410F0-0x0000000181041100
	
		// Nested types
		public enum Level // TypeDefIndex: 54477
		{
			Undoc = 0,
			API = 1,
			UserRef = 2
		}
	
		// Constructors
		public DocumentationSortingAttribute() {} // Dummy constructor
		public DocumentationSortingAttribute(Level category) {} // 0x00000001810410F0-0x0000000181041100
	}

	[SaveDuringPlay]
	public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera // TypeDefIndex: 54483
	{
		// Fields
		[HideInInspector]
		[NoSaveDuringPlay]
		[SerializeField]
		public string[] m_ExcludedPropertiesInInspector; // 0x18
		[HideInInspector]
		[NoSaveDuringPlay]
		[SerializeField]
		public CinemachineCore.Stage[] m_LockStageInInspector; // 0x20
		private int m_ValidatingStreamVersion; // 0x28
		private bool m_OnValidateCalled; // 0x2C
		[HideInInspector]
		[NoSaveDuringPlay]
		[SerializeField]
		private int m_StreamingVersion; // 0x30
		[NoSaveDuringPlay]
		[Tooltip("The priority will determine which camera becomes active based on the state of other cameras and this camera.  Higher numbers have greater priority.")]
		public int m_Priority; // 0x34
		internal int m_ActivationId; // 0x38
		[NonSerialized]
		public float FollowTargetAttachment; // 0x3C
		[NonSerialized]
		public float LookAtTargetAttachment; // 0x40
		[SerializeField]
		protected bool _ignoreLookAtBlend; // 0x44
		[Tooltip("When the virtual camera is not live, this is how often the virtual camera will be updated.  Set this to tune for performance. Most of the time Never is fine, unless the virtual camera is doing shot evaluation.")]
		public StandbyUpdateMode m_StandbyUpdate; // 0x48
		private bool m_WasStarted; // 0x59
		private bool mSlaveStatusUpdated; // 0x5A
		private CinemachineVirtualCameraBase m_parentVcam; // 0x60
		private int m_QueuePriority; // 0x68
		private Transform m_CachedFollowTarget; // 0x70
		private CinemachineVirtualCameraBase m_CachedFollowTargetVcam; // 0x78
		private ICinemachineTargetGroup m_CachedFollowTargetGroup; // 0x80
		private Transform m_CachedLookAtTarget; // 0x88
		private CinemachineVirtualCameraBase m_CachedLookAtTargetVcam; // 0x90
		private ICinemachineTargetGroup m_CachedLookAtTargetGroup; // 0x98
	
		// Properties
		public int ValidatingStreamVersion { get; private set; } // 0x0000000183318580-0x00000001833185F0 0x0000000183D4EBA0-0x0000000183D4EBB0
		public List<CinemachineExtension> mExtensions { get; private set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public string Name { get; } // 0x0000000184276114-0x000000018427611C 
		public virtual string Description { get; } // 0x000000018556C83C-0x000000018556C868 
		public int Priority { get; set; } // 0x0000000183D4EE00-0x0000000183D4EE10 0x0000000183D4EE40-0x0000000183D4EE50
		public GameObject VirtualCameraGameObject { get; } // 0x000000018274C6C0-0x000000018274C7D0 
		public bool IsValid { get; } // 0x000000018274BA10-0x000000018274BAE0 
		public abstract CameraState State { get; }
		public ICinemachineCamera ParentCamera { get; } // 0x00000001824ADF80-0x00000001824ADFC0 
		public abstract Transform LookAt { get; set; }
		public abstract Transform Follow { get; set; }
		public virtual bool PreviousStateIsValid { get; set; } // 0x0000000183D4F7E0-0x0000000183D4F7F0 0x0000000183D4F7F0-0x0000000183D4F800
		public bool FollowTargetChanged { get; private set; } // 0x0000000183D50A40-0x0000000183D50A50 0x0000000183D50A60-0x0000000183D50A70
		public bool LookAtTargetChanged { get; private set; } // 0x0000000183D50A50-0x0000000183D50A60 0x0000000183D50A70-0x0000000183D50A80
		public ICinemachineTargetGroup AbstractFollowTargetGroup { get; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 
		public CinemachineVirtualCameraBase FollowTargetAsVcam { get; } // 0x0000000183D4EB20-0x0000000183D4EB30 
		public ICinemachineTargetGroup AbstractLookAtTargetGroup { get; } // 0x00000001811AC510-0x00000001811AC520 
		public CinemachineVirtualCameraBase LookAtTargetAsVcam { get; } // 0x0000000183D4EA90-0x0000000183D4EAA0 
	
		// Nested types
		public enum StandbyUpdateMode // TypeDefIndex: 54479
		{
			Never = 0,
			Always = 1,
			RoundRobin = 2
		}
	
		public enum BlendHint // TypeDefIndex: 54480
		{
			None = 0,
			SphericalPosition = 1,
			CylindricalPosition = 2,
			ScreenSpaceAimWhenTargetsDiffer = 3
		}
	
		[Serializable]
		public struct TransitionParams // TypeDefIndex: 54481
		{
			// Fields
			[FormerlySerializedAs("m_PositionBlending")]
			[Tooltip("Hint for blending positions to and from this virtual camera")]
			public BlendHint m_BlendHint; // 0x00
			[Tooltip("When this virtual camera goes Live, attempt to force the position to be the same as the current position of the Unity Camera")]
			public bool m_InheritPosition; // 0x04
			[Tooltip("This event fires when the virtual camera goes Live")]
			public CinemachineBrain.VcamActivatedEvent m_OnCameraLive; // 0x08
		}
	
		// Constructors
		protected CinemachineVirtualCameraBase() {} // 0x0000000183395190-0x0000000183395230
	
		// Methods
		public virtual float GetMaxDampTime() => default; // 0x000000018556C508-0x000000018556C5A4
		public float DetachedFollowTargetDamp(float initial, float dampTime, float deltaTime) => default; // 0x000000018556C1B8-0x000000018556C210
		public Vector3 DetachedFollowTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) => default; // 0x00000001824D9C60-0x00000001824D9EF0
		public Vector3 DetachedFollowTargetDamp(Vector3 initial, float dampTime, float deltaTime) => default; // 0x000000018556C138-0x000000018556C1B8
		public float DetachedLookAtTargetDamp(float initial, float dampTime, float deltaTime) => default; // 0x00000001824DB000-0x00000001824DB130
		public Vector3 DetachedLookAtTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) => default; // 0x000000018556C210-0x000000018556C300
		public Vector3 DetachedLookAtTargetDamp(Vector3 initial, float dampTime, float deltaTime) => default; // 0x000000018556C300-0x000000018556C380
		public virtual void AddExtension(CinemachineExtension extension) {} // 0x0000000182741E70-0x0000000182741F50
		public virtual void RemoveExtension(CinemachineExtension extension) {} // 0x000000018556C6D0-0x000000018556C724
		protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime) {} // 0x00000001827487D0-0x0000000182748CC0
		protected void InvokePrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState newState, float deltaTime) {} // 0x0000000182747C30-0x0000000182747F60
		protected bool InvokeOnTransitionInExtensions(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) => default; // 0x0000000183651490-0x00000001836515F0
		protected void ApplyPositionBlendMethod(ref CameraState state, BlendHint hint) {} // 0x00000001827463F0-0x0000000182746400
		public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x01FD668A */) => default; // 0x000000018115F4C0-0x000000018115F530
		public void UpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x0000000182749090-0x0000000182749130
		public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime);
		public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x0000000183651450-0x0000000183651490
		protected virtual void OnDestroy() {} // 0x000000018556C5AC-0x000000018556C604
		protected virtual void OnTransformParentChanged() {} // 0x00000001833188B0-0x0000000183318980
		protected virtual void Start() {} // 0x0000000183D4D6A0-0x0000000183D4D850
		internal virtual bool RequiresUserInput() => default; // 0x000000018556C724-0x000000018556C83C
		internal void EnsureStarted() {} // 0x000000018556C380-0x000000018556C404
		public AxisState.IInputAxisProvider GetInputAxisProvider() => default; // 0x000000018556C47C-0x000000018556C508
		protected virtual void OnValidate() {} // 0x000000018556C67C-0x000000018556C6D0
		protected virtual void OnEnable() {} // 0x0000000183318660-0x0000000183318830
		protected virtual void OnDisable() {} // 0x00000001833185F0-0x0000000183318660
		protected virtual void Update() {} // 0x000000018336A230-0x000000018336A250
		private void UpdateSlaveStatus() {} // 0x0000000183318980-0x0000000183318A40
		public Transform ResolveLookAt(Transform localLookAt) => default; // 0x0000000182747730-0x0000000182747860
		public Transform ResolveFollow(Transform localFollow) => default; // 0x0000000182747B00-0x0000000182747C30
		private void UpdateVcamPoolStatus() {} // 0x0000000183318B30-0x0000000183318C40
		public void MoveToTopOfPrioritySubqueue() {} // 0x000000018556C5A4-0x000000018556C5AC
		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x000000018556C604-0x000000018556C67C
		public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x000000018556C404-0x000000018556C47C
		protected CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, CinemachineBlendDefinition blendDef, CinemachineBlend activeBlend) => default; // 0x000000018556BF00-0x000000018556C138
		protected CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens) => default; // 0x00000001827497E0-0x0000000182749AE0
		private void InvalidateCachedTargets() {} // 0x0000000183318830-0x00000001833188B0
		protected void UpdateTargetCache() {} // 0x0000000182746DD0-0x00000001827470F0
		public object GetCinemachineComponent<T>() => default;
	}

	internal class ConfinerOven // TypeDefIndex: 54489
	{
		// Fields
		private float m_MinFrustumHeightWithBones; // 0x10
		private List<List<IntPoint>> m_OriginalPolygon; // 0x18
		private List<List<IntPoint>> m_Skeleton; // 0x20
		private const long k_FloatToIntScaler = 100000; // Metadata: 0x01FD6692
		private const float k_IntToFloatScaler = 1E-05f; // Metadata: 0x01FD669A
		private const float k_MinStepSize = 0.005f; // Metadata: 0x01FD669E
		private Rect m_PolygonRect; // 0x28
		private AspectStretcher m_AspectStretcher; // 0x38
		private float m_maxComputationTimeForFullSkeletonBakeInSeconds; // 0x44
		public float m_BakeProgress; // 0x4C
		private BakingStateCache m_Cache; // 0x50
	
		// Properties
		public BakingState State { get; private set; } // 0x0000000183D4EC50-0x0000000183D4EC60 0x0000000183D4ECD0-0x0000000183D4ECE0
	
		// Nested types
		public class BakedSolution // TypeDefIndex: 54484
		{
			// Fields
			private float m_frustumSizeIntSpace; // 0x14
			private readonly AspectStretcher m_AspectStretcher; // 0x18
			private readonly bool m_HasBones; // 0x24
			private readonly double m_SqrPolygonDiagonal; // 0x28
			private List<List<IntPoint>> m_OriginalPolygon; // 0x30
			public List<List<IntPoint>> m_Solution; // 0x38
	
			// Properties
			public float FrustumHeight { get; } // 0x0000000183D4E7A0-0x0000000183D4E7B0 
	
			// Constructors
			public BakedSolution() {} // Dummy constructor
			public BakedSolution(float aspectRatio, float frustumHeight, bool hasBones, Rect polygonBounds, List<List<IntPoint>> originalPolygon, List<List<IntPoint>> solution) {} // 0x0000000185568884-0x0000000185568938
	
			// Methods
			public bool IsValid(float frustumHeight) => default; // 0x000000018556885C-0x0000000185568884
			public Vector2 ConfinePoint([IsReadOnly] in Vector2 pointToConfine) => default; // 0x0000000185567F34-0x0000000185568308
			private bool IsInsideOriginal(IntPoint p) => default; // 0x00000001855687C0-0x000000018556885C
			private static float ClosestPointOnSegment(IntPoint p, IntPoint s0, IntPoint s1) => default; // 0x0000000185567EB4-0x0000000185567F34
			private static IntPoint IntPointLerp(IntPoint a, IntPoint b, float lerp) => default; // 0x000000018556872C-0x00000001855687C0
			private bool DoesIntersectOriginal(IntPoint l1, IntPoint l2) => default; // 0x0000000185568308-0x0000000185568508
			private static int FindIntersection([IsReadOnly] in IntPoint p1, [IsReadOnly] in IntPoint p2, [IsReadOnly] in IntPoint p3, [IsReadOnly] in IntPoint p4) => default; // 0x0000000185568508-0x000000018556872C
			private static double IntPointDiffSqrMagnitude(IntPoint p1, IntPoint p2) => default; // 0x0000000183D50960-0x0000000183D50990
		}
	
		private struct AspectStretcher // TypeDefIndex: 54485
		{
			// Fields
			private readonly float m_InverseAspect; // 0x04
			private readonly float m_CenterX; // 0x08
	
			// Properties
			public float Aspect { [IsReadOnly] get; } // 0x0000000183D4FA00-0x0000000183D4FA10 
	
			// Constructors
			public AspectStretcher(float aspect, float centerX) : this() {
				m_InverseAspect = default;
				m_CenterX = default;
			} // 0x0000000183D508F0-0x0000000183D50910
	
			// Methods
			public Vector2 Stretch(Vector2 p) => default; // 0x0000000183D50890-0x0000000183D508C0
			public Vector2 Unstretch(Vector2 p) => default; // 0x0000000183D508C0-0x0000000183D508F0
		}
	
		private struct PolygonSolution // TypeDefIndex: 54486
		{
			// Fields
			public List<List<IntPoint>> m_Polygons; // 0x00
			public float m_FrustumHeight; // 0x08
	
			// Properties
			public bool IsEmpty { get => default; } // 0x0000000182361C20-0x0000000182361C30 
	
			// Methods
			public bool StateChanged([IsReadOnly] in List<List<IntPoint>> paths) => default; // 0x000000018556DF50-0x000000018556E024
		}
	
		public enum BakingState // TypeDefIndex: 54487
		{
			BAKING = 0,
			BAKED = 1,
			TIMEOUT = 2
		}
	
		private struct BakingStateCache // TypeDefIndex: 54488
		{
			// Fields
			public ClipperOffset offsetter; // 0x00
			public List<PolygonSolution> solutions; // 0x08
			public PolygonSolution rightCandidate; // 0x10
			public PolygonSolution leftCandidate; // 0x20
			public List<List<IntPoint>> maxCandidate; // 0x30
			public float stepSize; // 0x38
			public float maxFrustumHeight; // 0x3C
			public float currentFrustumHeight; // 0x40
			public float bakeTime; // 0x44
		}
	
		// Constructors
		public ConfinerOven() {} // Dummy constructor
		public ConfinerOven([IsReadOnly] in List<List<Vector2>> inputPath, [IsReadOnly] in float aspectRatio, float maxFrustumHeight) {} // 0x000000018556D8DC-0x000000018556D9B4
	
		// Methods
		public BakedSolution GetBakedSolution(float frustumHeight) => default; // 0x000000018556CFB4-0x000000018556D238
		private void Initialize([IsReadOnly] in List<List<Vector2>> inputPath, [IsReadOnly] in float aspectRatio, float maxFrustumHeight) {} // 0x000000018556D3B0-0x000000018556D8DC
		public void BakeConfiner(float maxComputationTimePerFrameInSeconds) {} // 0x000000018556C868-0x000000018556CC2C
		private static Rect GetPolygonBoundingBox([IsReadOnly] in List<List<Vector2>> polygons) => default; // 0x000000018556D238-0x000000018556D3B0
		private void ComputeSkeleton([IsReadOnly] in List<PolygonSolution> solutions) {} // 0x000000018556CC2C-0x000000018556CFB4
	}

	public interface ICinemachineCamera // TypeDefIndex: 54490
	{
		// Properties
		string Name { get; }
		int Priority { get; }
		Transform LookAt { get; }
		Transform Follow { get; }
		CameraState State { get; }
		GameObject VirtualCameraGameObject { get; }
		bool IsValid { get; }
		ICinemachineCamera ParentCamera { get; }
	
		// Methods
		bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x01FD66A5 */);
		void UpdateCameraState(Vector3 worldUp, float deltaTime);
		void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime);
	}

	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public struct LensSettings // TypeDefIndex: 54492
	{
		// Fields
		public static LensSettings Default; // 0x00
		[Range(1f, 179f)]
		[Tooltip("This is the camera view in degrees. Display will be in vertical degress, unless the associated camera has its FOV axis setting set to Horizontal, in which case display will be in horizontal degress.  Internally, it is always vertical degrees.  For cinematic people, a 50mm lens on a super-35mm sensor would equal a 19.6 degree FOV")]
		public float FieldOfView; // 0x00
		[Tooltip("When using an orthographic camera, this defines the half-height, in world coordinates, of the camera view.")]
		public float OrthographicSize; // 0x04
		[Tooltip("This defines the near region in the renderable range of the camera frustum. Raising this value will stop the game from drawing things near the camera, which can sometimes come in handy.  Larger values will also increase your shadow resolution.")]
		public float NearClipPlane; // 0x08
		[Tooltip("This defines the far region of the renderable range of the camera frustum. Typically you want to set this value as low as possible without cutting off desired distant objects")]
		public float FarClipPlane; // 0x0C
		[Range(-180f, 180f)]
		[Tooltip("Camera Z roll, or tilt, in degrees.")]
		public float Dutch; // 0x10
		[Tooltip("Allows you to select a different camera mode to apply to the Camera component when Cinemachine activates this Virtual Camera.  The changes applied to the Camera component through this setting will remain after the Virtual Camera deactivation.")]
		public OverrideModes ModeOverride; // 0x14
		public Vector2 LensShift; // 0x18
		public Camera.GateFitMode GateFit; // 0x20
		[SerializeField]
		private Vector2 m_SensorSize; // 0x24
		private bool m_OrthoFromCamera; // 0x2C
		private bool m_PhysicalFromCamera; // 0x2D
	
		// Properties
		public bool Orthographic { get => default; } // 0x0000000182743FC0-0x0000000182743FE0 
		public Vector2 SensorSize { get => default; } // 0x0000000183D50A80-0x0000000183D50AA0 
		public float Aspect { get => default; } // 0x0000000182743F40-0x0000000182743FC0 
		public bool IsPhysicalCamera { get => default; } // 0x0000000182749440-0x0000000182749460 
	
		// Nested types
		public enum OverrideModes // TypeDefIndex: 54491
		{
			None = 0,
			Orthographic = 1,
			Perspective = 2,
			Physical = 3
		}
	
		// Constructors
		public LensSettings(float verticalFOV, float orthographicSize, float nearClip, float farClip, float dutch) : this() {
			FieldOfView = default;
			OrthographicSize = default;
			NearClipPlane = default;
			FarClipPlane = default;
			Dutch = default;
			ModeOverride = default;
			LensShift = default;
			GateFit = default;
			m_SensorSize = default;
			m_OrthoFromCamera = default;
			m_PhysicalFromCamera = default;
		} // 0x0000000183C8AC40-0x0000000183C8AC90
		static LensSettings() {
			Default = default;
		} // 0x0000000183C8ABA0-0x0000000183C8AC40
	
		// Methods
		public static LensSettings FromCamera(Camera fromCamera) => default; // 0x000000018556DB70-0x000000018556DCA8
		public void SnapshotCameraReadOnlyProperties(Camera camera) {} // 0x0000000182749130-0x0000000182749440
		public static LensSettings Lerp(LensSettings lensA, LensSettings lensB, float t) => default; // 0x000000018257D820-0x000000018257D980
		public void Validate() {} // 0x000000018556DCA8-0x000000018556DD14
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineNoiseProfiles.html")]
	public sealed class NoiseSettings : SignalSourceAsset // TypeDefIndex: 54495
	{
		// Fields
		[FormerlySerializedAs("m_Position")]
		[Tooltip("These are the noise channels for the virtual camera\'s position. Convincing noise setups typically mix low, medium and high frequencies together, so start with a size of 3")]
		public TransformNoiseParams[] PositionNoise; // 0x18
		[FormerlySerializedAs("m_Orientation")]
		[Tooltip("These are the noise channels for the virtual camera\'s orientation. Convincing noise setups typically mix low, medium and high frequencies together, so start with a size of 3")]
		public TransformNoiseParams[] OrientationNoise; // 0x20
	
		// Properties
		public override float SignalDuration { get => default; } // 0x0000000183D503F0-0x0000000183D50400 
	
		// Nested types
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct NoiseParams // TypeDefIndex: 54493
		{
			// Fields
			[Tooltip("The frequency of noise for this channel.  Higher magnitudes vibrate faster.")]
			public float Frequency; // 0x00
			[Tooltip("The amplitude of the noise for this channel.  Larger numbers vibrate higher.")]
			public float Amplitude; // 0x04
			[Tooltip("If checked, then the amplitude and frequency will not be randomized.")]
			public bool Constant; // 0x08
	
			// Methods
			public float GetValueAt(float time, float timeOffset) => default; // 0x000000018556DD14-0x000000018556DD6C
		}
	
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct TransformNoiseParams // TypeDefIndex: 54494
		{
			// Fields
			[Tooltip("Noise definition for X-axis")]
			public NoiseParams X; // 0x00
			[Tooltip("Noise definition for Y-axis")]
			public NoiseParams Y; // 0x0C
			[Tooltip("Noise definition for Z-axis")]
			public NoiseParams Z; // 0x18
	
			// Methods
			public Vector3 GetValueAt(float time, Vector3 timeOffsets) => default; // 0x000000018556ECD8-0x000000018556ED78
		}
	
		// Constructors
		public NoiseSettings() {} // 0x0000000183A1C990-0x0000000183A1CA00
	
		// Methods
		public static Vector3 GetCombinedFilterResults(TransformNoiseParams[] noiseParams, float time, Vector3 timeOffsets) => default; // 0x000000018556DD6C-0x000000018556DE78
		public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) {
			pos = default;
			rot = default;
		} // 0x000000018556DE78-0x000000018556DF50
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.Undoc)]
	public static class RuntimeUtility // TypeDefIndex: 54501
	{
		// Fields
		public static OverlapSphereNonAllocDelegate OverlapSphereNonAlloc; // 0x00
		public static RaycastDelegate Raycast; // 0x08
		public static RaycastNonAllocDelegate RaycastNonAlloc; // 0x10
		public static SphereCastNonAllocDelegate SphereCastNonAlloc; // 0x18
		public static ComputePenetrationDelegate ComputePenetration; // 0x20
		public static int ignoreColliderOption; // 0x28
		private static RaycastHit[] s_HitBuffer; // 0x30
		private static int[] s_PenetrationIndexBuffer; // 0x38
		private static SphereCollider s_ScratchCollider; // 0x40
		private static GameObject s_ScratchColliderGameObject; // 0x48
	
		// Nested types
		public delegate int OverlapSphereNonAllocDelegate(Vector3 position, float radius, ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 54496; 0x000000018500FCCC-0x000000018500FD18
	
		public delegate bool RaycastDelegate(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 54497; 0x000000018500C984-0x000000018500C9D0
	
		public delegate int RaycastNonAllocDelegate(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 54498; 0x000000018500C984-0x000000018500C9D0
	
		public delegate int SphereCastNonAllocDelegate(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 54499; 0x0000000185010C40-0x0000000185010CBC
	
		public delegate bool ComputePenetrationDelegate(ECSColliderResultProxy colliderA, Vector3 positionA, Quaternion rotationA, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance); // TypeDefIndex: 54500; 0x000000018500C584-0x000000018500C648
	
		// Constructors
		static RuntimeUtility() {} // 0x0000000183640D60-0x0000000183641050
	
		// Methods
		public static void DestroyObject(UnityEngine.Object obj) {} // 0x000000018556E25C-0x000000018556E2BC
		public static bool IsPrefab(GameObject gameObject) => default; // 0x000000018115F4C0-0x000000018115F530
		public static bool RaycastIgnoreTag(Ray ray, out RaycastHit hitInfo, float rayLength, int layerMask, [IsReadOnly] in string ignoreTag) {
			hitInfo = default;
			return default;
		} // 0x0000000182742A40-0x0000000182742CB0
		public static int GetColliderOptionsFromHit(RaycastHit hit) => default; // 0x000000018556E430-0x000000018556E498
		public static bool HasIgnoreColliderOptionFromHit(RaycastHit hit) => default; // 0x000000018556E790-0x000000018556E80C
		public static bool HasIgnoreColliderOptionFromCollider(ECSColliderResultProxy collider) => default; // 0x000000018556E720-0x000000018556E790
		public static bool SphereCastIgnoreTag(Vector3 rayStart, float radius, Vector3 dir, out RaycastHit hitInfo, float rayLength, int layerMask, [IsReadOnly] in string ignoreTag) {
			hitInfo = default;
			return default;
		} // 0x0000000182743020-0x0000000182743480
		internal static SphereCollider GetScratchCollider() => default; // 0x000000018556E498-0x000000018556E720
		internal static void DestroyScratchCollider() {} // 0x000000018556E2BC-0x000000018556E430
		public static AnimationCurve NormalizeCurve(AnimationCurve curve, bool normalizeX, bool normalizeY) => default; // 0x000000018556E80C-0x000000018556EA2C
	}

	public interface ISignalSource6D // TypeDefIndex: 54502
	{
		// Methods
		void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot);
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public abstract class SignalSourceAsset : ScriptableObject, ISignalSource6D // TypeDefIndex: 54503
	{
		// Properties
		public abstract float SignalDuration { get; }
	
		// Constructors
		protected SignalSourceAsset() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		public abstract void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot);
	}

	internal class TargetPositionCache // TypeDefIndex: 54510
	{
		// Fields
		public static bool UseCache; // 0x00
		private static Mode m_CacheMode; // 0x04
		public static float CurrentTime; // 0x08
		public static int CurrentFrame; // 0x0C
		public static bool IsCameraCut; // 0x10
		private static Dictionary<Transform, CacheEntry> m_Cache; // 0x18
		private static TimeRange m_CacheTimeRange; // 0x20
	
		// Properties
		public static Mode CacheMode { get => default; } // 0x000000018556EC1C-0x000000018556EC54 
		public static bool HasCurrentTime { get => default; } // 0x000000018556EC54-0x000000018556EC98 
	
		// Nested types
		public enum Mode // TypeDefIndex: 54504
		{
			Disabled = 0,
			Record = 1,
			Playback = 2
		}
	
		private class CacheCurve // TypeDefIndex: 54506
		{
			// Fields
			public float StartTime; // 0x10
			public float StepSize; // 0x14
			private List<Item> m_Cache; // 0x18
	
			// Nested types
			public struct Item // TypeDefIndex: 54505
			{
				// Fields
				public Vector3 Pos; // 0x00
				public Quaternion Rot; // 0x0C
	
				// Properties
				public static Item Empty { get => default; } // 0x000000018556DB48-0x000000018556DB70 
	
				// Methods
				public static Item Lerp(Item a, Item b, float t) => default; // 0x000000018556DA40-0x000000018556DB48
			}
	
			// Constructors
			public CacheCurve() {} // Dummy constructor
	
			// Methods
			public Item Evaluate(float time) => default; // 0x0000000185568AE4-0x0000000185568C84
		}
	
		private class CacheEntry // TypeDefIndex: 54508
		{
			// Fields
			public CacheCurve Curve; // 0x10
			private List<RecordingItem> RawItems; // 0x18
	
			// Nested types
			private struct RecordingItem // TypeDefIndex: 54507
			{
				// Fields
				public float Time; // 0x00
				public bool IsCut; // 0x04
				public CacheCurve.Item Item; // 0x08
			}
	
			// Constructors
			public CacheEntry() {} // 0x0000000185568F1C-0x0000000185568F94
	
			// Methods
			public void AddRawItem(float time, bool isCut, Transform target) {} // 0x0000000185568C84-0x0000000185568F1C
		}
	
		public struct TimeRange // TypeDefIndex: 54509
		{
			// Fields
			public float Start; // 0x00
			public float End; // 0x04
	
			// Properties
			public bool IsEmpty { get => default; } // 0x000000018556ECCC-0x000000018556ECD8 
			public static TimeRange Empty { get => default; } // 0x0000000183D50AC0-0x0000000183D50AE0 
	
			// Methods
			public bool Contains(float time) => default; // 0x000000018556EC98-0x000000018556ECAC
			public void Include(float time) {} // 0x000000018556ECAC-0x000000018556ECCC
		}
	
		// Constructors
		public TargetPositionCache() {} // Dummy constructor
	
		// Methods
		public static void ClearCache() {} // 0x000000018556EB24-0x000000018556EC1C
		public static Vector3 GetTargetPosition(Transform target) => default; // 0x0000000182749460-0x0000000182749550
		public static Quaternion GetTargetRotation(Transform target) => default; // 0x0000000182749550-0x0000000182749660
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.Undoc)]
	internal class UpdateTracker // TypeDefIndex: 54513
	{
		// Fields
		private static Dictionary<Transform, UpdateStatus> mUpdateStatus; // 0x00
		private static List<Transform> sToDelete; // 0x08
		private static float mLastUpdateTime; // 0x10
	
		// Nested types
		public enum UpdateClock // TypeDefIndex: 54511
		{
			Fixed = 0,
			Late = 1
		}
	
		private class UpdateStatus // TypeDefIndex: 54512
		{
			// Fields
			private int windowStart; // 0x10
			private int numWindowLateUpdateMoves; // 0x14
			private int numWindowFixedUpdateMoves; // 0x18
			private int numWindows; // 0x1C
			private int lastFrameUpdated; // 0x20
			private Matrix4x4 lastPos; // 0x24
	
			// Properties
			public UpdateClock PreferredUpdate { get; private set; } // 0x0000000183D50B30-0x0000000183D50B40 0x0000000183D50B40-0x0000000183D50B50
	
			// Constructors
			public UpdateStatus() {} // Dummy constructor
			public UpdateStatus(int currentFrame, Matrix4x4 pos) {} // 0x0000000185575F2C-0x0000000185575F7C
	
			// Methods
			public void OnUpdate(int currentFrame, UpdateClock currentClock, Matrix4x4 pos) {} // 0x0000000185575E1C-0x0000000185575F2C
		}
	
		// Constructors
		public UpdateTracker() {} // Dummy constructor
		static UpdateTracker() {} // 0x0000000183C7A7F0-0x0000000183C7A8E0
	
		// Methods
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule() {} // 0x0000000183D02380-0x0000000183D023F0
		private static void UpdateTargets(UpdateClock currentClock) {} // 0x000000018556F158-0x000000018556F508
		public static UpdateClock GetPreferredUpdate(Transform target) => default; // 0x000000018556EECC-0x000000018556F0BC
		public static void OnUpdate(UpdateClock currentClock) {} // 0x000000018556F0BC-0x000000018556F158
	}

	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineAlternativeInput.html")]
	public class CinemachineInputProvider : MonoBehaviour, AxisState.IInputAxisProvider // TypeDefIndex: 54515
	{
		// Fields
		[Tooltip("Leave this at -1 for single-player games.  For multi-player games, set this to be the player index, and the actions will be read from that player\'s controls")]
		public int PlayerIndex; // 0x18
		[Tooltip("If set, Input Actions will be auto-enabled at start")]
		public bool AutoEnableInputs; // 0x1C
		[Tooltip("Vector2 action for XY movement")]
		public InputActionReference XYAxis; // 0x20
		[Tooltip("Float action for Z movement")]
		public InputActionReference ZAxis; // 0x28
		private const int NUM_AXES = 3; // Metadata: 0x01FD66AF
		private InputAction[] m_cachedActions; // 0x30
	
		// Constructors
		public CinemachineInputProvider() {} // 0x0000000185572D94-0x0000000185572DA8
	
		// Methods
		public virtual float GetAxisValue(int axis) => default; // 0x0000000185572854-0x0000000185572920
		protected InputAction ResolveForPlayer(int axis, InputActionReference actionRef) => default; // 0x0000000185572934-0x0000000185572C9C
		protected virtual void OnDisable() {} // 0x0000000185572920-0x0000000185572934
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/api/Cinemachine.CinemachineTriggerAction.html")]
	[SaveDuringPlay]
	public class CinemachineTriggerAction : MonoBehaviour // TypeDefIndex: 54520
	{
		// Fields
		[Header("Trigger Object Filter")]
		[Tooltip("Only triggers generated by objects on these layers will be considered")]
		public LayerMask m_LayerMask; // 0x18
		[TagField]
		[Tooltip("If set, only triggers generated by objects with this tag will be considered")]
		public string m_WithTag; // 0x20
		[TagField]
		[Tooltip("Triggers generated by objects with this tag will be ignored")]
		public string m_WithoutTag; // 0x28
		[NoSaveDuringPlay]
		[Tooltip("Skip this many trigger entries before taking action")]
		public int m_SkipFirst; // 0x30
		[Tooltip("Repeat the action for all subsequent trigger entries")]
		public bool m_Repeating; // 0x34
		public ActionSettings m_OnObjectEnter; // 0x38
		public ActionSettings m_OnObjectExit; // 0x60
		private HashSet<GameObject> m_ActiveTriggerObjects; // 0x88
	
		// Nested types
		[Serializable]
		public struct ActionSettings // TypeDefIndex: 54519
		{
			// Fields
			[Tooltip("What action to take")]
			public Mode m_Action; // 0x00
			[Tooltip("The target object on which to operate.  If null, then the current behaviour/GameObject will be used")]
			public UnityEngine.Object m_Target; // 0x08
			[Tooltip("If PriorityBoost, this amount will be added to the virtual camera\'s priority")]
			public int m_BoostAmount; // 0x10
			[Tooltip("If playing a timeline, start at this time")]
			public float m_StartTime; // 0x14
			[Tooltip("How to interpret the start time")]
			public TimeMode m_Mode; // 0x18
			[Tooltip("This event will be invoked")]
			public TriggerEvent m_Event; // 0x20
	
			// Nested types
			public enum Mode // TypeDefIndex: 54516
			{
				Custom = 0,
				PriorityBoost = 1,
				Activate = 2,
				Deactivate = 3,
				Enable = 4,
				Disable = 5,
				Play = 6,
				Stop = 7
			}
	
			[Serializable]
			public class TriggerEvent : UnityEvent // TypeDefIndex: 54517
			{
				// Constructors
				public TriggerEvent() {} // 0x0000000184271C98-0x0000000184271CA0
			}
	
			public enum TimeMode // TypeDefIndex: 54518
			{
				FromStart = 0,
				FromEnd = 1,
				BeforeNow = 2,
				AfterNow = 3
			}
	
			// Constructors
			public ActionSettings(Mode action) {
				m_Action = default;
				m_Target = default;
				m_BoostAmount = default;
				m_StartTime = default;
				m_Mode = default;
				m_Event = default;
			} // 0x000000018556F96C-0x000000018556F9F0
	
			// Methods
			public void Invoke() {} // 0x000000018556F508-0x000000018556F96C
		}
	
		// Constructors
		public CinemachineTriggerAction() {} // 0x000000018557309C-0x000000018557320C
	
		// Methods
		private bool Filter(GameObject other) => default; // 0x0000000185572DA8-0x0000000185572E38
		private void InternalDoTriggerEnter(GameObject other) {} // 0x0000000185572E38-0x0000000185572EC8
		private void InternalDoTriggerExit(GameObject other) {} // 0x0000000185572EC8-0x0000000185572F64
		private void OnTriggerEnter(Collider other) {} // 0x0000000185573034-0x0000000185573068
		private void OnTriggerExit(Collider other) {} // 0x0000000185573068-0x000000018557309C
		private void OnCollisionEnter(UnityEngine.Collision other) {} // 0x0000000185572F98-0x0000000185572FCC
		private void OnCollisionExit(UnityEngine.Collision other) {} // 0x0000000185573000-0x0000000185573034
		private void OnTriggerEnter2D(Collider2D other) {} // 0x0000000185573034-0x0000000185573068
		private void OnTriggerExit2D(Collider2D other) {} // 0x0000000185573068-0x000000018557309C
		private void OnCollisionEnter2D(Collision2D other) {} // 0x0000000185572F64-0x0000000185572F98
		private void OnCollisionExit2D(Collision2D other) {} // 0x0000000185572FCC-0x0000000185573000
		private void OnEnable() {} // 0x000000018350B670-0x000000018350B680
	}

	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/api/Cinemachine.GroupWeightManipulator.html")]
	[RequireComponent(typeof(CinemachineTargetGroup))]
	public class GroupWeightManipulator : MonoBehaviour // TypeDefIndex: 54521
	{
		// Fields
		[Tooltip("The weight of the group member at index 0")]
		public float m_Weight0; // 0x18
		[Tooltip("The weight of the group member at index 1")]
		public float m_Weight1; // 0x1C
		[Tooltip("The weight of the group member at index 2")]
		public float m_Weight2; // 0x20
		[Tooltip("The weight of the group member at index 3")]
		public float m_Weight3; // 0x24
		[Tooltip("The weight of the group member at index 4")]
		public float m_Weight4; // 0x28
		[Tooltip("The weight of the group member at index 5")]
		public float m_Weight5; // 0x2C
		[Tooltip("The weight of the group member at index 6")]
		public float m_Weight6; // 0x30
		[Tooltip("The weight of the group member at index 7")]
		public float m_Weight7; // 0x34
		private CinemachineTargetGroup m_group; // 0x38
	
		// Constructors
		public GroupWeightManipulator() {} // 0x0000000185573698-0x00000001855736D8
	
		// Methods
		private void Start() {} // 0x00000001855734BC-0x0000000185573504
		private void OnValidate() {} // 0x0000000185573450-0x00000001855734BC
		private void Update() {} // 0x0000000185573638-0x0000000185573698
		private void UpdateWeights() {} // 0x0000000185573504-0x0000000185573638
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineCollisionImpulseSource.html")]
	[SaveDuringPlay]
	public class CinemachineCollisionImpulseSource : CinemachineImpulseSource // TypeDefIndex: 54522
	{
		// Fields
		[Header("Trigger Object Filter")]
		[Tooltip("Only collisions with objects on these layers will generate Impulse events")]
		public LayerMask m_LayerMask; // 0x30
		[TagField]
		[Tooltip("No Impulse evemts will be generated for collisions with objects having these tags")]
		public string m_IgnoreTag; // 0x38
		[Header("How To Generate The Impulse")]
		[Tooltip("If checked, signal direction will be affected by the direction of impact")]
		public bool m_UseImpactDirection; // 0x40
		[Tooltip("If checked, signal amplitude will be multiplied by the mass of the impacting object")]
		public bool m_ScaleImpactWithMass; // 0x41
		[Tooltip("If checked, signal amplitude will be multiplied by the speed of the impacting object")]
		public bool m_ScaleImpactWithSpeed; // 0x42
		private Rigidbody mRigidBody; // 0x48
		private Rigidbody2D mRigidBody2D; // 0x50
	
		// Constructors
		public CinemachineCollisionImpulseSource() {} // 0x00000001855703A4-0x0000000185570400
	
		// Methods
		private void Start() {} // 0x0000000185570334-0x00000001855703A4
		private void OnEnable() {} // 0x000000018350B670-0x000000018350B680
		private void OnCollisionEnter(UnityEngine.Collision c) {} // 0x00000001855702A4-0x00000001855702DC
		private void OnTriggerEnter(Collider c) {} // 0x0000000185570308-0x0000000185570334
		private float GetMassAndVelocity(Collider other, ref Vector3 vel) => default; // 0x000000018556FFFC-0x0000000185570230
		private void GenerateImpactEvent(Collider other, Vector3 vel) {} // 0x000000018556FBDC-0x000000018556FDC8
		private void OnCollisionEnter2D(Collision2D c) {} // 0x0000000185570230-0x00000001855702A4
		private void OnTriggerEnter2D(Collider2D c) {} // 0x00000001855702DC-0x0000000185570308
		private float GetMassAndVelocity2D(Collider2D other2d, ref Vector3 vel) => default; // 0x000000018556FDC8-0x000000018556FFFC
		private void GenerateImpactEvent2D(Collider2D other2d, Vector3 vel) {} // 0x000000018556F9F0-0x000000018556FBDC
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineImpulseFixedSignals.html")]
	public class CinemachineFixedSignal : SignalSourceAsset // TypeDefIndex: 54523
	{
		// Fields
		[Tooltip("The raw signal shape along the X axis")]
		public AnimationCurve m_XCurve; // 0x18
		[Tooltip("The raw signal shape along the Y axis")]
		public AnimationCurve m_YCurve; // 0x20
		[Tooltip("The raw signal shape along the Z axis")]
		public AnimationCurve m_ZCurve; // 0x28
	
		// Properties
		public override float SignalDuration { get => default; } // 0x0000000185570B48-0x0000000185570BA8 
	
		// Constructors
		public CinemachineFixedSignal() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		private float AxisDuration(AnimationCurve axis) => default; // 0x00000001855709E8-0x0000000185570A68
		public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) {
			pos = default;
			rot = default;
		} // 0x0000000185570AAC-0x0000000185570B48
		private float AxisValue(AnimationCurve axis, float time) => default; // 0x0000000185570A68-0x0000000185570AAC
	}

	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public class CinemachineImpulseDefinition // TypeDefIndex: 54529
	{
		// Fields
		[CinemachineImpulseChannelProperty]
		[Tooltip("Impulse events generated here will appear on the channels included in the mask.")]
		public int m_ImpulseChannel; // 0x10
		[Tooltip("Shape of the impact signal")]
		public ImpulseShapes m_ImpulseShape; // 0x14
		[Tooltip("Defines the custom shape of the impact signal that will be generated.")]
		public AnimationCurve m_CustomImpulseShape; // 0x18
		[Tooltip("The time during which the impact signal will occur.  The signal shape will be stretched to fill that time.")]
		public float m_ImpulseDuration; // 0x20
		[Tooltip("How the impulse travels through space and time.")]
		public ImpulseTypes m_ImpulseType; // 0x24
		[Range(0f, 1f)]
		[Tooltip("This defines how the widely signal will spread within the effect radius before dissipating with distance from the impact point")]
		public float m_DissipationRate; // 0x28
		[CinemachineEmbeddedAssetProperty(true)]
		[Header("Signal Shape")]
		[Tooltip("Legacy mode only: Defines the signal that will be generated.")]
		public SignalSourceAsset m_RawSignal; // 0x30
		[Tooltip("Legacy mode only: Gain to apply to the amplitudes defined in the signal source.  1 is normal.  Setting this to 0 completely mutes the signal.")]
		public float m_AmplitudeGain; // 0x38
		[Tooltip("Legacy mode only: Scale factor to apply to the time axis.  1 is normal.  Larger magnitudes will make the signal progress more rapidly.")]
		public float m_FrequencyGain; // 0x3C
		[Tooltip("Legacy mode only: How to fit the signal into the envelope time")]
		public RepeatMode m_RepeatMode; // 0x40
		[Tooltip("Legacy mode only: Randomize the signal start time")]
		public bool m_Randomize; // 0x44
		[Tooltip("Legacy mode only: This defines the time-envelope of the signal.  The raw signal will be time-scaled to fit in the envelope.")]
		public CinemachineImpulseManager.EnvelopeDefinition m_TimeEnvelope; // 0x48
		[Header("Spatial Range")]
		[Tooltip("Legacy mode only: The signal will have full amplitude in this radius surrounding the impact point.  Beyond that it will dissipate with distance.")]
		public float m_ImpactRadius; // 0x68
		[Tooltip("Legacy mode only: How the signal direction behaves as the listener moves away from the origin.")]
		public CinemachineImpulseManager.ImpulseEvent.DirectionMode m_DirectionMode; // 0x6C
		[Tooltip("Legacy mode only: This defines how the signal will dissipate with distance beyond the impact radius.")]
		public CinemachineImpulseManager.ImpulseEvent.DissipationMode m_DissipationMode; // 0x70
		[Tooltip("The signal will have no effect outside this radius surrounding the impact point.")]
		public float m_DissipationDistance; // 0x74
		[Tooltip("The speed (m/s) at which the impulse propagates through space.  High speeds allow listeners to react instantaneously, while slower speeds allow listeners in the scene to react as if to a wave spreading from the source.")]
		public float m_PropagationSpeed; // 0x78
		private static AnimationCurve[] sStandardShapes; // 0x00
	
		// Properties
		internal AnimationCurve ImpulseCurve { get => default; } // 0x0000000185571C7C-0x0000000185571CD4 
	
		// Nested types
		public enum ImpulseShapes // TypeDefIndex: 54524
		{
			Custom = 0,
			Recoil = 1,
			Bump = 2,
			Explosion = 3,
			Rumble = 4
		}
	
		public enum ImpulseTypes // TypeDefIndex: 54525
		{
			Uniform = 0,
			Dissipating = 1,
			Propagating = 2,
			Legacy = 3
		}
	
		public enum RepeatMode // TypeDefIndex: 54526
		{
			Stretch = 0,
			Loop = 1
		}
	
		private class SignalSource : ISignalSource6D // TypeDefIndex: 54527
		{
			// Fields
			private CinemachineImpulseDefinition m_Def; // 0x10
			private Vector3 m_Velocity; // 0x18
	
			// Properties
			public float SignalDuration { get => default; } // 0x0000000185574930-0x0000000185574950 
	
			// Constructors
			public SignalSource() {} // Dummy constructor
			public SignalSource(CinemachineImpulseDefinition def, Vector3 velocity) {} // 0x0000000185574900-0x0000000185574930
	
			// Methods
			public void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) {
				pos = default;
				rot = default;
			} // 0x0000000185574828-0x0000000185574900
		}
	
		private class LegacySignalSource : ISignalSource6D // TypeDefIndex: 54528
		{
			// Fields
			private CinemachineImpulseDefinition m_Def; // 0x10
			private Vector3 m_Velocity; // 0x18
			private float m_StartTimeOffset; // 0x24
	
			// Properties
			public float SignalDuration { get => default; } // 0x0000000185574590-0x00000001855745BC 
	
			// Constructors
			public LegacySignalSource() {} // Dummy constructor
			public LegacySignalSource(CinemachineImpulseDefinition def, Vector3 velocity) {} // 0x0000000185574510-0x0000000185574590
	
			// Methods
			public void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) {
				pos = default;
				rot = default;
			} // 0x0000000185574304-0x0000000185574510
		}
	
		// Constructors
		public CinemachineImpulseDefinition() {} // 0x0000000182C61F70-0x0000000182C62060
	
		// Methods
		public void OnValidate() {} // 0x0000000185571BA4-0x0000000185571C7C
		private static void CreateStandardShapes() {} // 0x0000000185570DE4-0x0000000185571948
		internal static AnimationCurve GetStandardCurve(ImpulseShapes shape) => default; // 0x0000000185571948-0x00000001855719BC
		public void CreateEvent(Vector3 position, Vector3 velocity) {} // 0x0000000185570DA4-0x0000000185570DE4
		public CinemachineImpulseManager.ImpulseEvent CreateAndReturnEvent(Vector3 position, Vector3 velocity) => default; // 0x0000000185570BA8-0x0000000185570DA4
		private CinemachineImpulseManager.ImpulseEvent LegacyCreateAndReturnEvent(Vector3 position, Vector3 velocity) => default; // 0x00000001855719BC-0x0000000185571BA4
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineImpulseListener.html")]
	[SaveDuringPlay]
	public class CinemachineImpulseListener : CinemachineExtension // TypeDefIndex: 54531
	{
		// Fields
		[Tooltip("When to apply the impulse reaction.  Default is after the Noise stage.  Modify this if necessary to influence the ordering of extension effects")]
		public CinemachineCore.Stage m_ApplyAfter; // 0x28
		[CinemachineImpulseChannelProperty]
		[Tooltip("Impulse events on channels not included in the mask will be ignored.")]
		public int m_ChannelMask; // 0x2C
		[Tooltip("Gain to apply to the Impulse signal.  1 is normal strength.  Setting this to 0 completely mutes the signal.")]
		public float m_Gain; // 0x30
		[Tooltip("Enable this to perform distance calculation in 2D (ignore Z)")]
		public bool m_Use2DDistance; // 0x34
		[Tooltip("Enable this to process all impulse signals in camera space")]
		public bool m_UseCameraSpace; // 0x35
		[Tooltip("This controls the secondary reaction of the listener to the incoming impulse.  The impulse might be for example a sharp shock, and the secondary reaction could be a vibration whose amplitude and duration is controlled by the size of the original impulse.  This allows different listeners to respond in different ways to the same impulse signal.")]
		public ImpulseReaction m_ReactionSettings; // 0x38
	
		// Nested types
		[Serializable]
		public struct ImpulseReaction // TypeDefIndex: 54530
		{
			// Fields
			[NoiseSettingsProperty]
			[Tooltip("Secondary shake that will be triggered by the primary impulse.")]
			public NoiseSettings m_SecondaryNoise; // 0x00
			[Tooltip("Gain to apply to the amplitudes defined in the signal source.  1 is normal.  Setting this to 0 completely mutes the signal.")]
			public float m_AmplitudeGain; // 0x08
			[Tooltip("Scale factor to apply to the time axis.  1 is normal.  Larger magnitudes will make the signal progress more rapidly.")]
			public float m_FrequencyGain; // 0x0C
			[Tooltip("How long the secondary reaction lasts.")]
			public float m_Duration; // 0x10
			private float m_CurrentAmount; // 0x14
			private float m_CurrentTime; // 0x18
			private float m_CurrentDamping; // 0x1C
			private bool m_Initialized; // 0x20
			[HideInInspector]
			[SerializeField]
			private Vector3 m_NoiseOffsets; // 0x24
	
			// Methods
			public void ReSeed() {} // 0x0000000185574280-0x0000000185574304
			public bool GetReaction(float deltaTime, Vector3 impulsePos, out Vector3 pos, out Quaternion rot) {
				pos = default;
				rot = default;
				return default;
			} // 0x0000000182743FE0-0x0000000182744170
		}
	
		// Constructors
		public CinemachineImpulseListener() {} // 0x00000001839CB270-0x00000001839CB280
	
		// Methods
		private void Reset() {} // 0x0000000185571CD4-0x0000000185571D38
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x00000001827448A0-0x0000000182744A90
	}

	public sealed class CinemachineImpulseChannelPropertyAttribute : PropertyAttribute // TypeDefIndex: 54532
	{
		// Constructors
		public CinemachineImpulseChannelPropertyAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public class CinemachineImpulseManager // TypeDefIndex: 54537
	{
		// Fields
		private static CinemachineImpulseManager sInstance; // 0x00
		private List<ImpulseEvent> m_ExpiredEvents; // 0x10
		private List<ImpulseEvent> m_ActiveEvents; // 0x18
		public bool IgnoreTimeScale; // 0x20
	
		// Properties
		public static CinemachineImpulseManager Instance { get => default; } // 0x0000000182744810-0x00000001827448A0 
		public float CurrentTime { get => default; } // 0x0000000185572000-0x0000000185572050 
	
		// Nested types
		[Serializable]
		public struct EnvelopeDefinition // TypeDefIndex: 54533
		{
			// Fields
			[Tooltip("Normalized curve defining the shape of the start of the envelope.  If blank a default curve will be used")]
			public AnimationCurve m_AttackShape; // 0x00
			[Tooltip("Normalized curve defining the shape of the end of the envelope.  If blank a default curve will be used")]
			public AnimationCurve m_DecayShape; // 0x08
			[Tooltip("Duration in seconds of the attack.  Attack curve will be scaled to fit.  Must be >= 0.")]
			public float m_AttackTime; // 0x10
			[Tooltip("Duration in seconds of the central fully-scaled part of the envelope.  Must be >= 0.")]
			public float m_SustainTime; // 0x14
			[Tooltip("Duration in seconds of the decay.  Decay curve will be scaled to fit.  Must be >= 0.")]
			public float m_DecayTime; // 0x18
			[Tooltip("If checked, signal amplitude scaling will also be applied to the time envelope of the signal.  Stronger signals will last longer.")]
			public bool m_ScaleWithImpact; // 0x1C
			[Tooltip("If true, then duration is infinite.")]
			public bool m_HoldForever; // 0x1D
	
			// Properties
			public float Duration { get => default; } // 0x0000000185573430-0x0000000185573450 
	
			// Methods
			public static EnvelopeDefinition Default() => default; // 0x0000000183D50AE0-0x0000000183D50B00
			public float GetValueAt(float offset) => default; // 0x00000001855732E8-0x0000000185573404
			public void ChangeStopTime(float offset, bool forceNoDecay) {} // 0x000000018557328C-0x00000001855732B8
			public void Clear() {} // 0x00000001855732B8-0x00000001855732E8
			public void Validate() {} // 0x0000000185573404-0x0000000185573430
		}
	
		public class ImpulseEvent // TypeDefIndex: 54536
		{
			// Fields
			public float m_StartTime; // 0x10
			public EnvelopeDefinition m_Envelope; // 0x18
			public ISignalSource6D m_SignalSource; // 0x38
			public Vector3 m_Position; // 0x40
			public float m_Radius; // 0x4C
			public DirectionMode m_DirectionMode; // 0x50
			public int m_Channel; // 0x54
			public DissipationMode m_DissipationMode; // 0x58
			public float m_DissipationDistance; // 0x5C
			public float m_CustomDissipation; // 0x60
			public float m_PropagationSpeed; // 0x64
			public bool m_IgnoreDistance; // 0x68
	
			// Properties
			public bool Expired { get => default; } // 0x00000001855741E4-0x0000000185574280 
	
			// Nested types
			public enum DirectionMode // TypeDefIndex: 54534
			{
				Fixed = 0,
				RotateTowardSource = 1
			}
	
			public enum DissipationMode // TypeDefIndex: 54535
			{
				LinearDecay = 0,
				SoftDecay = 1,
				ExponentialDecay = 2
			}
	
			// Constructors
			internal ImpulseEvent() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void Cancel(float time, bool forceNoDecay) {} // 0x0000000185573D1C-0x0000000185573D34
			public float DistanceDecay(float distance) => default; // 0x0000000185573D98-0x0000000185573E84
			public bool GetDecayedSignal(Vector3 listenerPosition, bool use2D, out Vector3 pos, out Quaternion rot) {
				pos = default;
				rot = default;
				return default;
			} // 0x0000000185573E84-0x00000001855741E4
			public void Clear() {} // 0x0000000185573D34-0x0000000185573D98
		}
	
		// Constructors
		private CinemachineImpulseManager() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule() {} // 0x0000000183D417E0-0x0000000183D41820
		internal static float EvaluateDissipationScale(float spread, float normalizedDistance) => default; // 0x0000000185571E9C-0x0000000185571F3C
		public bool GetImpulseAt(Vector3 listenerLocation, bool distance2D, int channelMask, out Vector3 pos, out Quaternion rot) {
			pos = default;
			rot = default;
			return default;
		} // 0x0000000182744170-0x0000000182744270
		public ImpulseEvent NewImpulseEvent() => default; // 0x0000000185571F3C-0x0000000185572000
		public void AddImpulseEvent(ImpulseEvent e) {} // 0x0000000185571D38-0x0000000185571DFC
		public void Clear() {} // 0x0000000185571DFC-0x0000000185571E9C
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineImpulseSourceOverview.html")]
	[SaveDuringPlay]
	public class CinemachineImpulseSource : MonoBehaviour // TypeDefIndex: 54538
	{
		// Fields
		public CinemachineImpulseDefinition m_ImpulseDefinition; // 0x18
		[Header("Default Invocation")]
		[Tooltip("The default direction and force of the Impulse Signal in the absense of any specified overrides.  Overrides can be specified by calling the appropriate GenerateImpulse method in the API.")]
		public Vector3 m_DefaultVelocity; // 0x20
	
		// Constructors
		public CinemachineImpulseSource() {} // 0x0000000183CB4DB0-0x0000000183CB4E40
	
		// Methods
		private void OnValidate() {} // 0x0000000185572248-0x0000000185572268
		private void Reset() {} // 0x0000000185572268-0x000000018557235C
		public void GenerateImpulseAtPositionWithVelocity(Vector3 position, Vector3 velocity) {} // 0x0000000185572050-0x000000018557209C
		public void GenerateImpulseWithVelocity(Vector3 velocity) {} // 0x000000018557217C-0x00000001855721F0
		public void GenerateImpulseWithForce(float force) {} // 0x00000001855720DC-0x000000018557217C
		public void GenerateImpulse() {} // 0x00000001855721F0-0x0000000185572218
		public void GenerateImpulseAt(Vector3 position, Vector3 velocity) {} // 0x000000018557209C-0x00000001855720DC
		public void GenerateImpulse(Vector3 velocity) {} // 0x0000000185572220-0x0000000185572248
		public void GenerateImpulse(float force) {} // 0x0000000185572218-0x0000000185572220
	}

	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/api/Cinemachine.CinemachineIndependentImpulseListener.html")]
	[SaveDuringPlay]
	public class CinemachineIndependentImpulseListener : MonoBehaviour // TypeDefIndex: 54539
	{
		// Fields
		private Vector3 impulsePosLastFrame; // 0x18
		private Quaternion impulseRotLastFrame; // 0x24
		[CinemachineImpulseChannelProperty]
		[Tooltip("Impulse events on channels not included in the mask will be ignored.")]
		public int m_ChannelMask; // 0x34
		[Tooltip("Gain to apply to the Impulse signal.  1 is normal strength.  Setting this to 0 completely mutes the signal.")]
		public float m_Gain; // 0x38
		[Tooltip("Enable this to perform distance calculation in 2D (ignore Z)")]
		public bool m_Use2DDistance; // 0x3C
		[Tooltip("Enable this to process all impulse signals in camera space")]
		public bool m_UseLocalSpace; // 0x3D
		[Tooltip("This controls the secondary reaction of the listener to the incoming impulse.  The impulse might be for example a sharp shock, and the secondary reaction could be a vibration whose amplitude and duration is controlled by the size of the original impulse.  This allows different listeners to respond in different ways to the same impulse signal.")]
		public CinemachineImpulseListener.ImpulseReaction m_ReactionSettings; // 0x40
	
		// Constructors
		public CinemachineIndependentImpulseListener() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Reset() {} // 0x00000001855726C4-0x0000000185572720
		private void OnEnable() {} // 0x0000000185572694-0x00000001855726C4
		private void Update() {} // 0x0000000185572720-0x0000000185572854
		private void LateUpdate() {} // 0x000000018557235C-0x0000000185572694
	}
}

namespace Cinemachine.PostFX
{
	[AddComponentMenu("")]
	[SaveDuringPlay]
	public class CinemachinePostProcessing : CinemachineExtension // TypeDefIndex: 54540
	{
		// Constructors
		public CinemachinePostProcessing() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x000000018350B670-0x000000018350B680
	}

	[AddComponentMenu("")]
	public class CinemachineVolumeSettings : MonoBehaviour // TypeDefIndex: 54541
	{
		// Constructors
		public CinemachineVolumeSettings() {} // 0x000000018426FE60-0x000000018426FE68
	}
}

namespace Cinemachine.Utility
{
	public class CinemachineDebug // TypeDefIndex: 54543
	{
		// Fields
		private static HashSet<UnityEngine.Object> mClients; // 0x00
		public static OnGUIDelegate OnGUIHandlers; // 0x08
		private static List<StringBuilder> mAvailableStringBuilders; // 0x10
	
		// Nested types
		public delegate void OnGUIDelegate(); // TypeDefIndex: 54542; 0x00000001842BE03C-0x00000001842BE04C
	
		// Constructors
		public CinemachineDebug() {} // Dummy constructor
	
		// Methods
		public static void ReleaseScreenPos(UnityEngine.Object client) {} // 0x0000000185570778-0x0000000185570810
		public static Rect GetScreenPos(UnityEngine.Object client, string text, GUIStyle style) => default; // 0x0000000185570400-0x0000000185570778
		public static StringBuilder SBFromPool() => default; // 0x00000001855708F4-0x00000001855709E8
		public static void ReturnToPool(StringBuilder sb) {} // 0x0000000185570810-0x00000001855708F4
	}

	public class PositionPredictor // TypeDefIndex: 54544
	{
		// Fields
		private Vector3 m_Velocity; // 0x10
		private Vector3 m_SmoothDampVelocity; // 0x1C
		private Vector3 m_Pos; // 0x28
		private bool m_HavePos; // 0x34
		public float Smoothing; // 0x38
	
		// Constructors
		public PositionPredictor() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void ApplyTransformDelta(Vector3 positionDelta) {} // 0x000000018557476C-0x00000001855747C0
		public void Reset() {} // 0x0000000185574800-0x0000000185574828
		public void AddPosition(Vector3 pos, float deltaTime, float lookaheadTime) {} // 0x00000001855745BC-0x000000018557476C
		public Vector3 PredictPositionDelta(float lookaheadTime) => default; // 0x00000001855747C0-0x0000000185574800
	}

	public static class Damper // TypeDefIndex: 54545
	{
		// Methods
		public static float Damp(float initial, float dampTime, float deltaTime) => default; // 0x00000001824DB130-0x00000001824DB1B0
		public static Vector3 Damp(Vector3 initial, Vector3 dampTime, float deltaTime) => default; // 0x00000001824DB1B0-0x00000001824DB2F0
		public static Vector3 Damp(Vector3 initial, float dampTime, float deltaTime) => default; // 0x000000018557320C-0x000000018557328C
	}

	public class HeadingTracker // TypeDefIndex: 54547
	{
		// Fields
		private Item[] mHistory; // 0x10
		private int mTop; // 0x18
		private int mBottom; // 0x1C
		private int mCount; // 0x20
		private Vector3 mHeadingSum; // 0x24
		private float mWeightSum; // 0x30
		private float mWeightTime; // 0x34
		private Vector3 mLastGoodHeading; // 0x38
		private static float mDecayExponent; // 0x00
	
		// Properties
		public int FilterSize { get => default; } // 0x00000001842746EC-0x0000000184274708 
	
		// Nested types
		private struct Item // TypeDefIndex: 54546
		{
			// Fields
			public Vector3 velocity; // 0x00
			public float weight; // 0x0C
			public float time; // 0x10
		}
	
		// Constructors
		public HeadingTracker() {} // Dummy constructor
		public HeadingTracker(int filterSize) {} // 0x0000000185573C40-0x0000000185573D1C
	
		// Methods
		private void ClearHistory() {} // 0x0000000185573894-0x00000001855738B4
		private static float Decay(float time) => default; // 0x0000000185573974-0x00000001855739C0
		public void Add(Vector3 velocity) {} // 0x00000001855736D8-0x0000000185573894
		private void PopBottom() {} // 0x0000000185573AB4-0x0000000185573C40
		public void DecayHistory() {} // 0x00000001855738B4-0x0000000185573974
		public Vector3 GetReliableHeading() => default; // 0x00000001855739C0-0x0000000185573AB4
	}

	public static class SplineHelpers // TypeDefIndex: 54548
	{
		// Methods
		public static Vector3 Bezier3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) => default; // 0x00000001855749DC-0x0000000185574B68
		public static Vector3 BezierTangent3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) => default; // 0x0000000185574B68-0x0000000185574EC0
		public static float Bezier1(float t, float p0, float p1, float p2, float p3) => default; // 0x0000000185574950-0x00000001855749DC
		public static void ComputeSmoothControlPoints(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2) {} // 0x000000018557517C-0x00000001855758C0
		public static void ComputeSmoothControlPointsLooped(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2) {} // 0x0000000185574EC0-0x000000018557517C
	}

	public static class UnityVectorExtensions // TypeDefIndex: 54549
	{
		// Methods
		public static float Angle(Vector3 v1, Vector3 v2) => default; // 0x000000018238EB70-0x000000018238F090
		public static float SignedAngle(Vector3 v1, Vector3 v2, Vector3 up) => default; // 0x00000001825884E0-0x00000001825885C0
		public static Quaternion SafeFromToRotation(Vector3 v1, Vector3 v2, Vector3 up) => default; // 0x0000000182B22680-0x0000000182B22790
	
		// Extension methods
		public static bool IsNaN(this Vector3 v) => default; // 0x000000018262E1E0-0x000000018262E210
		public static float ClosestPointOnSegment(this Vector3 p, Vector3 s0, Vector3 s1) => default; // 0x0000000185575CE4-0x0000000185575DC4
		public static float ClosestPointOnSegment(this Vector2 p, Vector2 s0, Vector2 s1) => default; // 0x0000000185575C4C-0x0000000185575CE4
		public static Vector3 ProjectOntoPlane(this Vector3 vector, Vector3 planeNormal) => default; // 0x0000000182B25350-0x0000000182B25410
		public static Vector2 Abs(this Vector2 v) => default; // 0x0000000183D50B00-0x0000000183D50B30
		public static bool IsUniform(this Vector2 v) => default; // 0x0000000185575DC4-0x0000000185575E1C
		public static bool AlmostZero(this Vector3 v) => default; // 0x000000018258B400-0x000000018258B420
	}

	public static class UnityQuaternionExtensions // TypeDefIndex: 54550
	{
		// Methods
		public static Quaternion SlerpWithReferenceUp(Quaternion qA, Quaternion qB, float t, Vector3 up) => default; // 0x000000018557593C-0x0000000185575C4C
	
		// Extension methods
		public static Quaternion Normalized(this Quaternion q) => default; // 0x00000001825A1560-0x00000001825A1770
		public static Vector2 GetCameraRotationToTarget(this Quaternion orient, Vector3 lookAtDir, Vector3 worldUp) => default; // 0x000000018258ADE0-0x000000018258B290
		public static Quaternion ApplyCameraRotation(this Quaternion orient, Vector2 rot, Vector3 worldUp) => default; // 0x0000000182745680-0x00000001827457D0
	}
}
