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

// Image 35: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 57983-58186
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("com.unity.cinemachine.editor")]
[assembly: InternalsVisibleTo("com.unity.cinemachine.Tests")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[AddComponentMenu("")]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/api/Cinemachine.CinemachineCameraOffset.html")]
[SaveDuringPlay]
public class CinemachineCameraOffset : CinemachineExtension // TypeDefIndex: 57984
{
	// Fields
	[Tooltip("Offset the camera\'s position by this much (camera space)")]
	public Vector3 m_Offset; // 0x28
	[Tooltip("When to apply the offset")]
	public CinemachineCore.Stage m_ApplyAfter; // 0x34
	[Tooltip("If applying offset after aim, re-adjust the aim to preserve the screen position of the LookAt target as much as possible")]
	public bool m_PreserveComposition; // 0x38

	// Constructors
	public CinemachineCameraOffset(); // 0x000000018678E6D0-0x000000018678E700

	// Methods
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x000000018678E3A8-0x000000018678E6D0
}

[AddComponentMenu("")]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineRecomposer.html")]
[SaveDuringPlay]
public class CinemachineRecomposer : CinemachineExtension // TypeDefIndex: 57985
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
	public CinemachineRecomposer(); // 0x0000000185393520-0x0000000185393538

	// Methods
	private void Reset(); // 0x0000000184D879E0-0x0000000184D87A10
	private void OnValidate(); // 0x000000018679A754-0x000000018679A790
	public override void PrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState curState, float deltaTime); // 0x0000000184073A30-0x0000000184073A60
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x00000001831FE9B0-0x00000001831FEC00
}

public static class CinemachineBeyondCommunicator // TypeDefIndex: 57986
{
	// Fields
	[CompilerGenerated]
	private static Func<CinemachineVirtualCameraBase> _GetLevelCamera_k__BackingField; // 0x00

	// Properties
	public static Func<CinemachineVirtualCameraBase> GetLevelCamera { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018678C1C0-0x000000018678C1F8 0x000000018678C1F8-0x000000018678C248
}

public class CinemachineTouchInputMapper : MonoBehaviour // TypeDefIndex: 57987
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
	public CinemachineTouchInputMapper(); // 0x000000018679AE00-0x000000018679AE74

	// Methods
	private void Start(); // 0x000000018679AD50-0x000000018679AE00
	private float GetInputAxis(string axisName); // 0x000000018679ACB0-0x000000018679AD50
}

internal sealed class CinemachineMixer : PlayableBehaviour // TypeDefIndex: 57988
{
	// Fields
	private CinemachineBrain mBrain; // 0x10
	private int mBrainOverrideId; // 0x18
	private bool mPreviewPlay; // 0x1C

	// Constructors
	public CinemachineMixer(); // 0x0000000184D87910-0x0000000184D87920

	// Methods
	public override void OnPlayableDestroy(Playable playable); // 0x0000000186798578-0x00000001867985EC
	public override void PrepareFrame(Playable playable, FrameData info); // 0x0000000184D87900-0x0000000184D87910
	public override void ProcessFrame(Playable playable, FrameData info, object playerData); // 0x00000001867985EC-0x0000000186798D28
	private float GetDeltaTime(float deltaTime); // 0x0000000186798528-0x0000000186798578
}

public sealed class CinemachineShot : PlayableAsset, IPropertyPreview, ITimelineClipAsset // TypeDefIndex: 57989
{
	// Fields
	[SerializeField]
	public bool DisableEvaluateTwiceWhenEnabled; // 0x18
	public bool UseVcamBeforeTimeline; // 0x19
	public bool UseLevelCamera; // 0x1A
	public string DisplayName; // 0x20
	public ExposedReference<CinemachineVirtualCameraBase> VirtualCamera; // 0x28

	// Properties
	public ClipCaps clipCaps { get; } // 0x000000018679AC9C-0x000000018679ACB0 

	// Constructors
	public CinemachineShot(); // 0x0000000183573370-0x0000000183573380

	// Methods
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018679A7E0-0x000000018679AB00
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver); // 0x000000018679AB00-0x000000018679AC9C
}

internal sealed class CinemachineShotPlayable : PlayableBehaviour // TypeDefIndex: 57990
{
	// Fields
	public CinemachineVirtualCameraBase VirtualCamera; // 0x10

	// Properties
	public bool IsValid { get; } // 0x000000018679A790-0x000000018679A7E0 

	// Constructors
	public CinemachineShotPlayable(); // 0x00000001841E1670-0x00000001841E1680
}

[Serializable]
[DontAutoBind]
[SupportsChildTracks(null, 2147483647)]
[TrackBindingType(typeof(CinemachineBrain), TrackBindingFlags.None)]
[TrackClipType(typeof(CinemachineShot))]
[TrackColor(0.53f, 0f, 0.08f)]
public class CinemachineTrack : TrackAsset // TypeDefIndex: 57991
{
	// Constructors
	public CinemachineTrack(); // 0x000000018679AF54-0x000000018679AFA0

	// Methods
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount); // 0x000000018679AE74-0x000000018679AF54
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 58186
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_12 AA5072B96927F710758B3E5237A84AC68E397BC4E1BF7E864A950696D743CC32; // 0x00 // Static value (base64): AAAAP83MDD+amRk/ - Metadata: 0x0234BBAC

	// Nested types
	private struct __StaticArrayInitTypeSize_12 // TypeDefIndex: 58185
	{
	}
}

namespace Cinemachine
{
	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[SaveDuringPlay]
	public class Cinemachine3rdPersonAim : CinemachineExtension // TypeDefIndex: 57992
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
		[CompilerGenerated]
		private Vector3 _AimTarget_k__BackingField; // 0x48
	
		// Properties
		private Vector3 AimTarget { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D87680-0x0000000184D876A0 0x0000000184D876A0-0x0000000184D876B0
	
		// Constructors
		public Cinemachine3rdPersonAim(); // 0x000000018678C16C-0x000000018678C1C0
	
		// Methods
		private void OnValidate(); // 0x000000018678BEE8-0x000000018678BF00
		private void Reset(); // 0x000000018678C108-0x000000018678C16C
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x000000018678BDBC-0x000000018678BEE8
		private void DrawReticle(CinemachineBrain brain); // 0x000000018678BC00-0x000000018678BDBC
		private Vector3 ComputeLookAtPoint(Vector3 camPos, Transform player); // 0x000000018678B8FC-0x000000018678BC00
		private Vector3 ComputeAimTarget(Vector3 cameraLookAt, Transform player); // 0x000000018678B770-0x000000018678B8FC
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x000000018678BF00-0x000000018678C108
	}

	[AddComponentMenu("Cinemachine/CinemachineBlendListCamera")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExcludeFromPreset]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineBlendListCamera.html")]
	public class CinemachineBlendListCamera : CinemachineVirtualCameraBase // TypeDefIndex: 57994
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
		[CompilerGenerated]
		private ICinemachineCamera _LiveChild_k__BackingField; // 0xD0
		private ICinemachineCamera m_TransitioningFrom; // 0xD8
		private CameraState m_State; // 0xE0
		private float mActivationTime; // 0x200
		private int mCurrentInstruction; // 0x204
		private CinemachineBlend mActiveBlend; // 0x208
	
		// Properties
		public override string Description { get; } // 0x000000018678D6A4-0x000000018678D790 
		public ICinemachineCamera LiveChild { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D876B0-0x0000000184D876C0 0x000000018678D7BC-0x000000018678D7D0
		public override CameraState State { get; } // 0x0000000184D876C0-0x0000000184D87740 
		public override Transform LookAt { get; set; } // 0x000000018678D7AC-0x000000018678D7BC 0x0000000184D84CC0-0x0000000184D84CE0
		public override Transform Follow { get; set; } // 0x000000018678D790-0x000000018678D7A0 0x0000000184D84CE0-0x0000000184D84D00
		public CinemachineVirtualCameraBase[] ChildCameras { get; } // 0x000000018678D684-0x000000018678D6A4 
		public bool IsBlending { get; } // 0x000000018678D7A0-0x000000018678D7AC 
	
		// Nested types
		[Serializable]
		public struct Instruction // TypeDefIndex: 57993
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
		public CinemachineBlendListCamera(); // 0x000000018678D54C-0x000000018678D684
	
		// Methods
		private void Reset(); // 0x000000018678D1C4-0x000000018678D228
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0234BAC8 */); // 0x000000018678CB48-0x000000018678CB70
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x000000018678CFD0-0x000000018678D094
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x000000018678C44C-0x000000018678C52C
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x000000018678D09C-0x000000018678D1C4
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x000000018678C52C-0x000000018678CB14
		protected override void OnEnable(); // 0x000000018678CC88-0x000000018678CE8C
		protected override void OnDisable(); // 0x000000018678CB70-0x000000018678CC88
		private void OnTransformChildrenChanged(); // 0x000000018678D094-0x000000018678D09C
		private void OnGuiHandler(); // 0x000000018678CE8C-0x000000018678CFD0
		private void InvalidateListOfChildren(); // 0x000000018678CB14-0x000000018678CB48
		private void UpdateListOfChildren(); // 0x000000018678D228-0x000000018678D3C8
		internal void ValidateInstructions(); // 0x000000018678D3C8-0x000000018678D54C
		private void AdvanceCurrentInstruction(float deltaTime); // 0x000000018678C248-0x000000018678C44C
	}

	[AddComponentMenu("Cinemachine/CinemachineBrain")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineBrainProperties.html")]
	[SaveDuringPlay]
	public class CinemachineBrain : MonoBehaviour // TypeDefIndex: 58001
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
		[CompilerGenerated]
		private CameraState _CurrentCameraState_k__BackingField; // 0xB0
	
		// Properties
		public Camera OutputCamera { get; } // 0x00000001833C8A00-0x00000001833C8A80 
		public HGDepthOfField OutputDOF { get; } // 0x00000001833C7310-0x00000001833C7390 
		public static ICinemachineCamera SoloCamera { get; set; } // 0x000000018678E20C-0x000000018678E240 0x000000018678E2B8-0x000000018678E3A8
		public Vector3 DefaultWorldUp { get; } // 0x00000001833C8F90-0x00000001833C9030 
		public ICinemachineCamera ActiveVirtualCamera { get; } // 0x00000001833C9960-0x00000001833C9A50 
		public bool IsBlending { get; } // 0x00000001833C7B70-0x00000001833C7BC0 
		public CinemachineBlend ActiveBlend { get; } // 0x00000001833C9850-0x00000001833C98A0 
		public CameraState CurrentCameraState { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D87740-0x0000000184D877C0 0x000000018678E240-0x000000018678E2B8
	
		// Nested types
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum UpdateMethod // TypeDefIndex: 57995
		{
			FixedUpdate = 0,
			LateUpdate = 1,
			SmartUpdate = 2,
			ManualUpdate = 3
		}
	
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum BrainUpdateMethod // TypeDefIndex: 57996
		{
			FixedUpdate = 0,
			LateUpdate = 1
		}
	
		[Serializable]
		public class BrainEvent : UnityEvent<CinemachineBrain> // TypeDefIndex: 57997
		{
			// Constructors
			public BrainEvent(); // 0x0000000183FCFD10-0x0000000183FCFD50
		}
	
		[Serializable]
		public class VcamActivatedEvent : UnityEvent<ICinemachineCamera, ICinemachineCamera> // TypeDefIndex: 57998
		{
			// Constructors
			public VcamActivatedEvent(); // 0x0000000183FCFB00-0x0000000183FCFB10
		}
	
		private class BrainFrame // TypeDefIndex: 57999
		{
			// Fields
			public int id; // 0x10
			public CinemachineBlend blend; // 0x18
			public CinemachineBlend workingBlend; // 0x20
			public BlendSourceVirtualCamera workingBlendSource; // 0x28
			public float deltaTimeOverride; // 0x30
	
			// Properties
			public bool Active { get; } // 0x000000018678B750-0x000000018678B770 
	
			// Constructors
			public BrainFrame(); // 0x0000000183FCFD50-0x0000000183FCFE70
		}
	
		[CompilerGenerated]
		private sealed class _AfterPhysics_d__36 : IEnumerator<object> // TypeDefIndex: 58000
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public CinemachineBrain __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _AfterPhysics_d__36(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000183D30400-0x0000000183D30490
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018679BB74-0x000000018679BBC0
		}
	
		// Constructors
		public CinemachineBrain(); // 0x0000000183FCF900-0x0000000183FCFB00
		static CinemachineBrain(); // 0x0000000184D34F10-0x0000000184D34F80
	
		// Methods
		public static UnityEngine.Color GetSoloGUIColor(); // 0x000000018678D8DC-0x000000018678D938
		private void OnEnable(); // 0x0000000183FCE9A0-0x0000000183FCED60
		private void OnDisable(); // 0x000000018678DA00-0x000000018678DC30
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode); // 0x000000018678DEF0-0x000000018678DF54
		private void OnSceneUnloaded(Scene scene); // 0x0000000184D7AB90-0x0000000184D7ABD0
		private void Start(); // 0x0000000184D83C20-0x0000000184D83C40
		private void OnGuiHandler(); // 0x000000018678DC30-0x000000018678DEF0
		[IteratorStateMachine(typeof(_AfterPhysics_d__36))]
		private IEnumerator AfterPhysics(); // 0x0000000183FCED60-0x0000000183FCEDC0
		private void LateUpdate(); // 0x00000001841AEA60-0x00000001841AEA80
		public void ManualUpdate(float deltaTime = -1f /* Metadata: 0x0234BAC9 */); // 0x00000001833CA8C0-0x00000001833CAA10
		private float GetEffectiveDeltaTime(bool fixedDelta); // 0x00000001833CAA10-0x00000001833CAAC0
		private void UpdateVirtualCameras(CinemachineCore.UpdateFilter updateFilter, float deltaTime); // 0x00000001833C8B10-0x00000001833C8EA0
		private static ICinemachineCamera DeepCamBFromBlend(CinemachineBlend blend); // 0x00000001833C9A50-0x00000001833C9B80
		public bool IsLiveInBlend(ICinemachineCamera vcam); // 0x000000018678D938-0x000000018678DA00
		private int GetBrainFrame(int withId); // 0x000000018678D7D0-0x000000018678D8DC
		public int SetCameraOverride(int overrideId, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime); // 0x000000018678E00C-0x000000018678E20C
		public void ReleaseCameraOverride(int overrideId); // 0x000000018678DF54-0x000000018678E00C
		private void ProcessActiveCamera(float deltaTime); // 0x00000001833CA000-0x00000001833CA470
		private void UpdateFrame0(float deltaTime); // 0x00000001833C6D10-0x00000001833C7010
		public void ComputeCurrentBlend(ref CinemachineBlend outputBlend, int numTopLayersToExclude); // 0x00000001833C7010-0x00000001833C72F0
		public bool IsLive(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0234BACD */); // 0x00000001833C98A0-0x00000001833C9960
		public ICinemachineCamera TopCameraFromPriorityQueue(); // 0x00000001833C8670-0x00000001833C8A00
		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey); // 0x00000001840F7700-0x00000001840F7A40
		private void PushStateToUnityCamera(ref CameraState state); // 0x00000001833C7390-0x00000001833C7B20
	}

	[AddComponentMenu("Cinemachine/CinemachineClearShot")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExcludeFromPreset]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineClearShot.html")]
	public class CinemachineClearShot : CinemachineVirtualCameraBase // TypeDefIndex: 58004
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
		[CompilerGenerated]
		private ICinemachineCamera _LiveChild_k__BackingField; // 0xF8
		private CameraState m_State; // 0x100
		private float mActivationTime; // 0x220
		private float mPendingActivationTime; // 0x224
		private ICinemachineCamera mPendingCamera; // 0x228
		private CinemachineBlend mActiveBlend; // 0x230
		private bool mRandomizeNow; // 0x238
		private CinemachineVirtualCameraBase[] m_RandomizedChilden; // 0x240
		private ICinemachineCamera m_TransitioningFrom; // 0x248
	
		// Properties
		public override string Description { get; } // 0x00000001867901A0-0x000000018679028C 
		public ICinemachineCamera LiveChild { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D877C0-0x0000000184D877D0 0x0000000186790298-0x00000001867902AC
		public override CameraState State { get; } // 0x0000000184D877D0-0x0000000184D87850 
		public override Transform LookAt { get; set; } // 0x000000018678D7AC-0x000000018678D7BC 0x0000000184D84CC0-0x0000000184D84CE0
		public override Transform Follow { get; set; } // 0x000000018678D790-0x000000018678D7A0 0x0000000184D84CE0-0x0000000184D84D00
		public bool IsBlending { get; } // 0x000000018679028C-0x0000000186790298 
		public CinemachineVirtualCameraBase[] ChildCameras { get; } // 0x0000000186790180-0x00000001867901A0 
	
		// Nested types
		private struct Pair // TypeDefIndex: 58002
		{
			// Fields
			public int a; // 0x00
			public float b; // 0x04
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58003
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<Pair> __9__47_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018679BBC0-0x000000018679BC24
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _Randomize_b__47_0(Pair p1, Pair p2); // 0x0000000184D87A20-0x0000000184D87A40
		}
	
		// Constructors
		public CinemachineClearShot(); // 0x0000000186790008-0x0000000186790180
	
		// Methods
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0234BAD4 */); // 0x000000018678F39C-0x000000018678F3C4
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x000000018678F9E8-0x000000018678FAAC
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x000000018678ED80-0x000000018678EE60
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x000000018678EE60-0x000000018678F354
		protected override void OnEnable(); // 0x000000018678F6B4-0x000000018678F8A4
		protected override void OnDisable(); // 0x000000018678F59C-0x000000018678F6B4
		public void OnTransformChildrenChanged(); // 0x000000018678FAAC-0x000000018678FACC
		private void OnGuiHandler(); // 0x000000018678F8A4-0x000000018678F9E8
		private void InvalidateListOfChildren(); // 0x000000018678F354-0x000000018678F39C
		public void ResetRandomization(); // 0x000000018678FDFC-0x000000018678FE28
		private void UpdateListOfChildren(); // 0x000000018678FE28-0x0000000186790008
		private ICinemachineCamera ChooseCurrentCamera(Vector3 worldUp); // 0x000000018678E700-0x000000018678ED80
		private CinemachineVirtualCameraBase[] Randomize(CinemachineVirtualCameraBase[] src); // 0x000000018678FBC4-0x000000018678FDFC
		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey); // 0x000000018678F3C4-0x000000018678F59C
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x000000018678FACC-0x000000018678FBC4
	}

	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineCollider.html")]
	[SaveDuringPlay]
	public class CinemachineCollider : CinemachineExtension // TypeDefIndex: 58007
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
		private const float k_PrecisionSlush = 0.001f; // Metadata: 0x0234BAD5
		private RaycastHit[] m_CornerBuffer; // 0x70
		private const float k_AngleThreshold = 0.1f; // Metadata: 0x0234BAD9
		private static ECSColliderResultProxy[] s_ColliderBuffer; // 0x00
	
		// Properties
		public List<List<Vector3>> DebugPaths { get; } // 0x0000000186792350-0x0000000186792518 
	
		// Nested types
		public enum ResolutionStrategy // TypeDefIndex: 58005
		{
			PullCameraForward = 0,
			PreserveCameraHeight = 1,
			PreserveCameraDistance = 2
		}
	
		private class VcamExtraState // TypeDefIndex: 58006
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
			public VcamExtraState(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void AddPointToDebugPath(Vector3 p); // 0x00000001841E1670-0x00000001841E1680
			public float ApplyDistanceSmoothing(float distance, float smoothingTime); // 0x000000018403BFB0-0x000000018403C000
			public void UpdateDistanceSmoothing(float distance); // 0x000000018679BC24-0x000000018679BD94
			public void ResetDistanceSmoothing(float smoothingTime); // 0x0000000183FC2820-0x0000000183FC28F0
		}
	
		// Constructors
		public CinemachineCollider(); // 0x00000001849C8EB0-0x00000001849C8F70
		static CinemachineCollider(); // 0x0000000184D38910-0x0000000184D38980
	
		// Methods
		public bool IsTargetObscured(ICinemachineCamera vcam); // 0x0000000186790FB0-0x0000000186791008
		public bool CameraWasDisplaced(ICinemachineCamera vcam); // 0x00000001867902AC-0x00000001867902C8
		public float GetCameraDisplacementDistance(ICinemachineCamera vcam); // 0x00000001867906D4-0x0000000186790730
		private void OnValidate(); // 0x0000000186791050-0x000000018679109C
		protected override void OnDestroy(); // 0x0000000186791008-0x0000000186791050
		public override float GetMaxDampTime(); // 0x0000000186790730-0x0000000186790748
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x0000000183200260-0x0000000183200320
		public void ResetExtraData(ICinemachineCamera vcam); // 0x00000001867917EC-0x000000018679188C
		public virtual void GuardedPostPipelineStageCallback(ICinemachineCamera vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x0000000183200320-0x0000000183200B10
		private Vector3 PreserveLineOfSight(ref CameraState state, ref VcamExtraState extra); // 0x0000000183249DD0-0x000000018324A0D0
		private Vector3 PullCameraInFrontOfNearestObstacle(Vector3 cameraPos, Vector3 lookAtPos, int layerMask, ref RaycastHit hitInfo); // 0x000000018324A0D0-0x000000018324A310
		private Vector3 PushCameraBack(Vector3 currentPos, Vector3 pushDir, RaycastHit obstacle, Vector3 lookAtPos, Plane startPlane, float targetDistance, int iterations, ref VcamExtraState extra); // 0x000000018679109C-0x00000001867917EC
		private bool GetWalkingDirection(Vector3 pos, Vector3 pushDir, RaycastHit obstacle, ref Vector3 outDir); // 0x00000001867908AC-0x0000000186790FB0
		private float GetPushBackDistance(Ray ray, Plane startPlane, float targetDistance, Vector3 lookAtPos); // 0x0000000186790748-0x00000001867908AC
		private static float ClampRayToBounds(Ray ray, float distance, Bounds bounds); // 0x00000001867902C8-0x00000001867906D4
		private Vector3 RespectCameraRadius(Vector3 cameraPos, Vector3 lookAtPos); // 0x000000018679188C-0x0000000186792350
		private bool CheckForTargetObstructions([IsReadOnly] in CameraState state); // 0x0000000183248E30-0x00000001832492D0
		private static bool IsTargetOffscreen([IsReadOnly] in CameraState state); // 0x00000001832492D0-0x0000000183249910
	}

	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineConfiner.html")]
	[SaveDuringPlay]
	public class CinemachineConfiner : CinemachineExtension // TypeDefIndex: 58010
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
		public bool IsValid { get; } // 0x0000000186793EA0-0x0000000186793FA0 
	
		// Nested types
		public enum Mode // TypeDefIndex: 58008
		{
			Confine2D = 0,
			Confine3D = 1
		}
	
		private class VcamExtraState // TypeDefIndex: 58009
		{
			// Fields
			public Vector3 m_previousDisplacement; // 0x10
			public float confinerDisplacement; // 0x1C
	
			// Constructors
			public VcamExtraState(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public CinemachineConfiner(); // 0x0000000186793E84-0x0000000186793EA0
	
		// Methods
		public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam); // 0x0000000186792B88-0x0000000186792BA4
		public float GetCameraDisplacementDistance(CinemachineVirtualCameraBase vcam); // 0x0000000186793668-0x00000001867936C4
		private void OnValidate(); // 0x00000001867936EC-0x00000001867936FC
		protected override void ConnectToVcam(bool connect); // 0x0000000186793660-0x0000000186793668
		public override float GetMaxDampTime(); // 0x0000000184D87860-0x0000000184D87870
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x00000001867936FC-0x0000000186793994
		public void InvalidatePathCache(); // 0x00000001867936C4-0x00000001867936EC
		private bool ValidatePathCache(); // 0x0000000186793994-0x0000000186793E84
		private Vector3 ConfinePoint(Vector3 camPos); // 0x0000000186792BA4-0x000000018679301C
		private Vector3 ConfineScreenEdges(CinemachineVirtualCameraBase vcam, ref CameraState state); // 0x000000018679301C-0x0000000186793660
	}

	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineConfiner2D.html")]
	[SaveDuringPlay]
	public class CinemachineConfiner2D : CinemachineExtension // TypeDefIndex: 58013
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
		private const float k_cornerAngleTreshold = 10f; // Metadata: 0x0234BAE2
		private ShapeCache m_shapeCache; // 0x40
	
		// Nested types
		private class VcamExtraState // TypeDefIndex: 58011
		{
			// Fields
			public Vector3 m_PreviousDisplacement; // 0x10
			public Vector3 m_DampedDisplacement; // 0x1C
			public ConfinerOven.BakedSolution m_BakedSolution; // 0x28
			public CinemachineVirtualCameraBase m_vcam; // 0x30
	
			// Constructors
			public VcamExtraState(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		private struct ShapeCache // TypeDefIndex: 58012
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
			public void Invalidate(); // 0x000000018679B384-0x000000018679B424
			public bool ValidateCache(Collider2D boundingShape2D, float maxWindowSize, float aspectRatio, out bool confinerStateChanged); // 0x000000018679B53C-0x000000018679BB74
			private bool IsValid([IsReadOnly] in Collider2D boundingShape2D, [IsReadOnly] in float aspectRatio, [IsReadOnly] in float maxOrthoSize); // 0x000000018679B424-0x000000018679B53C
			private void CalculateDeltaTransformationMatrix(); // 0x000000018679B19C-0x000000018679B384
		}
	
		// Constructors
		public CinemachineConfiner2D(); // 0x0000000186792B6C-0x0000000186792B88
	
		// Methods
		public void InvalidateCache(); // 0x00000001867925B4-0x00000001867925C0
		public bool ValidateCache(float cameraAspectRatio); // 0x0000000186792B30-0x0000000186792B6C
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x00000001867925DC-0x0000000186792B30
		private float CalculateHalfFrustumHeight([IsReadOnly] in CameraState state, [IsReadOnly] in float cameraPosLocalZ); // 0x0000000186792518-0x00000001867925B4
		private void OnValidate(); // 0x00000001867925C0-0x00000001867925DC
		private void Reset(); // 0x0000000184D87850-0x0000000184D87860
	}

	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineDollyCart.html")]
	public class CinemachineDollyCart : MonoBehaviour // TypeDefIndex: 58015
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
		public enum UpdateMethod // TypeDefIndex: 58014
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2
		}
	
		// Constructors
		public CinemachineDollyCart(); // 0x00000001867941FC-0x0000000186794218
	
		// Methods
		private void FixedUpdate(); // 0x0000000186793FA0-0x0000000186793FF0
		private void Update(); // 0x000000018679419C-0x00000001867941FC
		private void LateUpdate(); // 0x0000000186793FF0-0x0000000186794054
		private void SetCartPosition(float distanceAlongPath); // 0x0000000186794054-0x000000018679419C
	}

	[AddComponentMenu("Cinemachine/CinemachineExternalCamera")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineExternalCamera.html")]
	[RequireComponent(typeof(Camera))]
	public class CinemachineExternalCamera : CinemachineVirtualCameraBase // TypeDefIndex: 58016
	{
		// Fields
		[NoSaveDuringPlay]
		[Tooltip("The object that the camera is looking at.  Setting this will improve the quality of the blends to and from this camera")]
		[VcamTargetProperty]
		public Transform m_LookAt; // 0xA8
		private Camera m_Camera; // 0xB0
		private CameraState m_State; // 0xB8
		[CompilerGenerated]
		private Transform _Follow_k__BackingField; // 0x1D8
		[FormerlySerializedAs("m_PositionBlending")]
		[Tooltip("Hint for blending positions to and from this virtual camera")]
		public BlendHint m_BlendHint; // 0x1E0
	
		// Properties
		public override CameraState State { get; } // 0x000000018441A2B0-0x000000018441A330 
		public override Transform LookAt { get; set; } // 0x0000000184D86290-0x0000000184D862A0 0x0000000184D849C0-0x0000000184D849E0
		public override Transform Follow { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D87870-0x0000000184D87880 0x0000000184D849E0-0x0000000184D84A00
	
		// Constructors
		public CinemachineExternalCamera(); // 0x0000000184220280-0x00000001842203E0
	
		// Methods
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x000000018391CE60-0x000000018391D640
	}

	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineFollowZoom.html")]
	[SaveDuringPlay]
	public class CinemachineFollowZoom : CinemachineExtension // TypeDefIndex: 58018
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
		private class VcamExtraState // TypeDefIndex: 58017
		{
			// Fields
			public float m_previousFrameZoom; // 0x10
	
			// Constructors
			public VcamExtraState(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public CinemachineFollowZoom(); // 0x0000000186794530-0x0000000186794564
	
		// Methods
		private void OnValidate(); // 0x0000000186794218-0x0000000186794274
		public override float GetMaxDampTime(); // 0x0000000184D86AF0-0x0000000184D86B00
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x0000000186794274-0x0000000186794530
	}

	[AddComponentMenu("Cinemachine/CinemachineFreeLook")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExcludeFromPreset]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineFreeLook.html")]
	public class CinemachineFreeLook : CinemachineVirtualCameraBase // TypeDefIndex: 58022
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
		public static string[] RigNames { get; } // 0x0000000186798398-0x0000000186798440 
		public override bool PreviousStateIsValid { get; set; } // 0x0000000184D86F70-0x0000000184D86F80 0x0000000186798440-0x0000000186798528
		public override CameraState State { get; } // 0x0000000184D87880-0x0000000184D87900 
		public override Transform LookAt { get; set; } // 0x000000018678D7AC-0x000000018678D7BC 0x0000000184D84CC0-0x0000000184D84CE0
		public override Transform Follow { get; set; } // 0x000000018678D790-0x000000018678D7A0 0x0000000184D84CE0-0x0000000184D84D00
	
		// Nested types
		[Serializable]
		public struct Orbit // TypeDefIndex: 58019
		{
			// Fields
			public float m_Height; // 0x00
			public float m_Radius; // 0x04
	
			// Constructors
			public Orbit(float h, float r); // 0x0000000184D87A10-0x0000000184D87A20
		}
	
		public delegate CinemachineVirtualCamera CreateRigDelegate(CinemachineFreeLook vcam, string name, CinemachineVirtualCamera copyFrom); // TypeDefIndex: 58020; 0x00000001814F3120-0x00000001814F3140
	
		public delegate void DestroyRigDelegate(GameObject rig); // TypeDefIndex: 58021; 0x0000000182B46B90-0x0000000182B46BA0
	
		// Constructors
		public CinemachineFreeLook(); // 0x0000000186797EC8-0x0000000186798398
	
		// Methods
		protected override void OnValidate(); // 0x0000000186796E2C-0x0000000186796F6C
		public CinemachineVirtualCamera GetRig(int i); // 0x0000000186795620-0x0000000186795670
		protected override void OnEnable(); // 0x00000001867969A4-0x00000001867969E4
		public void UpdateInputAxisProvider(); // 0x0000000186797A6C-0x0000000186797B00
		protected override void OnDestroy(); // 0x0000000186796888-0x00000001867969A4
		private void OnTransformChildrenChanged(); // 0x0000000186796060-0x0000000186796078
		private void Reset(); // 0x00000001867975C4-0x00000001867975CC
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0234BAE9 */); // 0x0000000186796078-0x0000000186796184
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001867969E4-0x0000000186796AA8
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x0000000186795100-0x00000001867953E0
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x0000000186795A44-0x0000000186796060
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x0000000186796AA8-0x0000000186796E2C
		internal override bool RequiresUserInput(); // 0x0000000182FFF600-0x0000000182FFF610
		private float GetYAxisClosestValue(Vector3 cameraPos, Vector3 up); // 0x0000000186795670-0x0000000186795A14
		private void InvalidateRigCache(); // 0x0000000186796060-0x0000000186796078
		private void DestroyRigs(); // 0x0000000186794C7C-0x0000000186795100
		private CinemachineVirtualCamera[] CreateRigs(CinemachineVirtualCamera[] copyFrom); // 0x0000000186794828-0x0000000186794C7C
		private void UpdateRigCache(); // 0x0000000186797B00-0x0000000186797D38
		private int LocateExistingRigs(string[] rigNames, bool forceOrbital); // 0x0000000186796184-0x0000000186796888
		private float UpdateXAxisHeading(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up); // 0x0000000186797D38-0x0000000186797EC8
		private void PushSettingsToRigs(); // 0x0000000186796F6C-0x00000001867975C4
		private float GetYAxisValue(); // 0x0000000186795A14-0x0000000186795A44
		private CameraState CalculateNewState(Vector3 worldUp, float deltaTime); // 0x0000000186794564-0x0000000186794828
		public Vector3 GetLocalPositionForCameraFromInput(float t); // 0x00000001867953E0-0x0000000186795620
		private void UpdateCachedSpline(); // 0x00000001867975CC-0x0000000186797A6C
	}

	[AddComponentMenu("Cinemachine/CinemachineMixingCamera")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExcludeFromPreset]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineMixingCamera.html")]
	public class CinemachineMixingCamera : CinemachineVirtualCameraBase // TypeDefIndex: 58023
	{
		// Fields
		public const int MaxCameras = 8; // Metadata: 0x0234BAEB
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
		[CompilerGenerated]
		private ICinemachineCamera _LiveChild_k__BackingField; // 0x1E8
		[CompilerGenerated]
		private Transform _LookAt_k__BackingField; // 0x1F0
		[CompilerGenerated]
		private Transform _Follow_k__BackingField; // 0x1F8
		private CinemachineVirtualCameraBase[] m_ChildCameras; // 0x200
		private Dictionary<CinemachineVirtualCameraBase, int> m_indexMap; // 0x208
	
		// Properties
		private ICinemachineCamera LiveChild { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D87930-0x0000000184D87940 0x0000000186799DA0-0x0000000186799DB4
		public override CameraState State { get; } // 0x0000000184D87950-0x0000000184D879D0 
		public override Transform LookAt { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D87940-0x0000000184D87950 0x0000000186799DB4-0x0000000186799DC8
		public override Transform Follow { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D87920-0x0000000184D87930 0x0000000186799D8C-0x0000000186799DA0
		public CinemachineVirtualCameraBase[] ChildCameras { get; } // 0x0000000186799D6C-0x0000000186799D8C 
	
		// Constructors
		public CinemachineMixingCamera(); // 0x0000000186799C08-0x0000000186799D6C
	
		// Methods
		public float GetWeight(int index); // 0x0000000186798F24-0x0000000186799028
		public void SetWeight(int index, float w); // 0x00000001867998C8-0x00000001867999D8
		public float GetWeight(CinemachineVirtualCameraBase vcam); // 0x0000000186798E08-0x0000000186798F24
		public void SetWeight(CinemachineVirtualCameraBase vcam, float w); // 0x00000001867997A0-0x00000001867998C8
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x0000000186799524-0x00000001867995E8
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x0000000186798D28-0x0000000186798E08
		protected override void OnEnable(); // 0x0000000186799504-0x0000000186799524
		public void OnTransformChildrenChanged(); // 0x00000001867995E8-0x00000001867995F0
		protected override void OnValidate(); // 0x0000000186799744-0x00000001867997A0
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0234BAEA */); // 0x0000000186799468-0x0000000186799504
		protected void InvalidateListOfChildren(); // 0x0000000186799420-0x0000000186799468
		protected void ValidateListOfChildren(); // 0x00000001867999D8-0x0000000186799C08
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x00000001867995F0-0x0000000186799744
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x0000000186799028-0x0000000186799420
	}

	[AddComponentMenu("Cinemachine/CinemachinePath")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachinePath.html")]
	[SaveDuringPlay]
	public class CinemachinePath : CinemachinePathBase // TypeDefIndex: 58025
	{
		// Fields
		[Tooltip("If checked, then the path ends are joined to form a continuous loop.")]
		public bool m_Looped; // 0x48
		[Tooltip("The waypoints that define the path.  They will be interpolated using a bezier curve.")]
		public Waypoint[] m_Waypoints; // 0x50
	
		// Properties
		public override float MinPos { get; } // 0x0000000184D879D0-0x0000000184D879E0 
		public override float MaxPos { get; } // 0x000000018679A718-0x000000018679A754 
		public override bool Looped { get; } // 0x0000000184D867D0-0x0000000184D867E0 
		public override int DistanceCacheSampleStepsPerSegment { get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
	
		// Nested types
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct Waypoint // TypeDefIndex: 58024
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
		public CinemachinePath(); // 0x000000018679A6C8-0x000000018679A718
	
		// Methods
		private void Reset(); // 0x000000018679A5A8-0x000000018679A6C8
		private float GetBoundingIndices(float pos, out int indexA, out int indexB); // 0x000000018679A4C0-0x000000018679A598
		public override Vector3 EvaluatePosition(float pos); // 0x000000018679A058-0x000000018679A268
		public override Vector3 EvaluateTangent(float pos); // 0x000000018679A268-0x000000018679A4C0
		public override Quaternion EvaluateOrientation(float pos); // 0x0000000186799DC8-0x000000018679A058
		private void OnValidate(); // 0x000000018679A598-0x000000018679A5A8
	}

	[AddComponentMenu("")]
	public sealed class CinemachinePipeline : MonoBehaviour // TypeDefIndex: 58026
	{
		// Constructors
		public CinemachinePipeline(); // 0x0000000183695570-0x0000000183695590
	}

	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	public class CinemachinePixelPerfect : MonoBehaviour // TypeDefIndex: 58027
	{
		// Constructors
		public CinemachinePixelPerfect(); // 0x0000000185393520-0x0000000185393538
	}

	[AddComponentMenu("Cinemachine/CinemachineSmoothPath")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineSmoothPath.html")]
	[SaveDuringPlay]
	public class CinemachineSmoothPath : CinemachinePathBase // TypeDefIndex: 58029
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
		public override float MinPos { get; } // 0x0000000184D879D0-0x0000000184D879E0 
		public override float MaxPos { get; } // 0x000000018679A718-0x000000018679A754 
		public override bool Looped { get; } // 0x0000000184D867D0-0x0000000184D867E0 
		public override int DistanceCacheSampleStepsPerSegment { get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
	
		// Nested types
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct Waypoint // TypeDefIndex: 58028
		{
			// Fields
			[Tooltip("Position in path-local space")]
			public Vector3 position; // 0x00
			[Tooltip("Defines the roll of the path at this waypoint.  The other orientation axes are inferred from the tangent and world up.")]
			public float roll; // 0x0C
	
			// Properties
			internal Vector4 AsVector4 { get; } // 0x000000018328FB00-0x000000018328FB20 
	
			// Methods
			internal static Waypoint FromVector4(Vector4 v); // 0x00000001867A9D14-0x00000001867A9F28
		}
	
		// Constructors
		public CinemachineSmoothPath(); // 0x00000001867A3F2C-0x00000001867A3F60
	
		// Methods
		private void OnValidate(); // 0x000000018679A598-0x000000018679A5A8
		private void Reset(); // 0x00000001867A3C1C-0x00000001867A3D24
		public override void InvalidateDistanceCache(); // 0x00000001867A3BE8-0x00000001867A3C1C
		private void UpdateControlPoints(); // 0x00000001867A3D24-0x00000001867A3F2C
		private float GetBoundingIndices(float pos, out int indexA, out int indexB); // 0x00000001867A3B3C-0x00000001867A3BE8
		public override Vector3 EvaluatePosition(float pos); // 0x00000001867A36E8-0x00000001867A38E0
		public override Vector3 EvaluateTangent(float pos); // 0x00000001867A38E0-0x00000001867A3B3C
		public override Quaternion EvaluateOrientation(float pos); // 0x00000001867A3458-0x00000001867A36E8
		private Quaternion RollAroundForward(float angle); // 0x0000000184D87D00-0x0000000184D87D50
	}

	[AddComponentMenu("Cinemachine/CinemachineStateDrivenCamera")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExcludeFromPreset]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineStateDrivenCamera.html")]
	public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase // TypeDefIndex: 58033
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
		[CompilerGenerated]
		private ICinemachineCamera _LiveChild_k__BackingField; // 0x100
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
		public override string Description { get; } // 0x00000001867A5DA8-0x00000001867A5E94 
		public ICinemachineCamera LiveChild { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D87D50-0x0000000184D87D60 0x00000001867A5EA0-0x00000001867A5EB4
		public override CameraState State { get; } // 0x0000000184D87D60-0x0000000184D87DE0 
		public override Transform LookAt { get; set; } // 0x000000018678D7AC-0x000000018678D7BC 0x0000000184D84CC0-0x0000000184D84CE0
		public override Transform Follow { get; set; } // 0x000000018678D790-0x000000018678D7A0 0x0000000184D84CE0-0x0000000184D84D00
		public CinemachineVirtualCameraBase[] ChildCameras { get; } // 0x00000001867A5D88-0x00000001867A5DA8 
		public bool IsBlending { get; } // 0x00000001867A5E94-0x00000001867A5EA0 
	
		// Nested types
		[Serializable]
		public struct Instruction // TypeDefIndex: 58030
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
		internal struct ParentHash // TypeDefIndex: 58031
		{
			// Fields
			public int m_Hash; // 0x00
			public int m_ParentHash; // 0x04
		}
	
		private struct HashPair // TypeDefIndex: 58032
		{
			// Fields
			public int parentHash; // 0x00
			public int hash; // 0x04
		}
	
		// Constructors
		public CinemachineStateDrivenCamera(); // 0x00000001867A5BAC-0x00000001867A5D88
	
		// Methods
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0234BAEC */); // 0x00000001867A4D3C-0x00000001867A4D64
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001867A55A4-0x00000001867A5668
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x00000001867A458C-0x00000001867A466C
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x00000001867A5670-0x00000001867A572C
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x00000001867A4788-0x00000001867A4D08
		protected override void OnEnable(); // 0x00000001867A5270-0x00000001867A5460
		protected override void OnDisable(); // 0x00000001867A5158-0x00000001867A5270
		public void OnTransformChildrenChanged(); // 0x00000001867A5668-0x00000001867A5670
		private void OnGuiHandler(); // 0x00000001867A5460-0x00000001867A55A4
		public static int CreateFakeHash(int parentHash, AnimationClip clip); // 0x00000001867A4510-0x00000001867A458C
		private int LookupFakeHash(int parentHash, AnimationClip clip); // 0x00000001867A4F3C-0x00000001867A5158
		private void InvalidateListOfChildren(); // 0x00000001867A4D08-0x00000001867A4D3C
		private void UpdateListOfChildren(); // 0x00000001867A572C-0x00000001867A58E0
		internal void ValidateInstructions(); // 0x00000001867A58E0-0x00000001867A5BAC
		private CinemachineVirtualCameraBase ChooseCurrentCamera(); // 0x00000001867A3F60-0x00000001867A4510
		private int GetClipHash(int hash, List<AnimatorClipInfo> clips); // 0x00000001867A466C-0x00000001867A4788
		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey); // 0x00000001867A4D64-0x00000001867A4F3C
	}

	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineStoryboard.html")]
	[SaveDuringPlay]
	public class CinemachineStoryboard : CinemachineExtension // TypeDefIndex: 58037
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
		private string CanvasName { get; } // 0x00000001867A75B8-0x00000001867A7624 
	
		// Nested types
		public enum FillStrategy // TypeDefIndex: 58034
		{
			BestFit = 0,
			CropImageToFit = 1,
			StretchToFit = 2
		}
	
		private class CanvasInfo // TypeDefIndex: 58035
		{
			// Fields
			public GameObject mCanvas; // 0x10
			public Canvas mCanvasComponent; // 0x18
			public CinemachineBrain mCanvasParent; // 0x20
			public RectTransform mViewport; // 0x28
			public RawImage mRawImage; // 0x30
	
			// Constructors
			public CanvasInfo(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public enum StoryboardRenderMode // TypeDefIndex: 58036
		{
			ScreenSpaceOverlay = 0,
			ScreenSpaceCamera = 1
		}
	
		// Constructors
		public CinemachineStoryboard(); // 0x00000001867A74C0-0x00000001867A75B8
	
		// Methods
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x00000001867A7220-0x00000001867A731C
		private void UpdateRenderCanvas(); // 0x00000001867A731C-0x00000001867A74C0
		protected override void ConnectToVcam(bool connect); // 0x00000001867A6064-0x00000001867A61C8
		private void CameraUpdatedCallback(CinemachineBrain brain); // 0x00000001867A5EB4-0x00000001867A6064
		private CanvasInfo LocateMyCanvas(CinemachineBrain parent, bool createIfNotFound); // 0x00000001867A6804-0x00000001867A6BE8
		private void CreateCanvas(CanvasInfo ci); // 0x00000001867A61C8-0x00000001867A6614
		private void DestroyCanvas(); // 0x00000001867A6614-0x00000001867A6804
		private void PlaceImage(CanvasInfo ci, float alpha); // 0x00000001867A6BE8-0x00000001867A7220
		private static void StaticBlendingHandler(CinemachineBrain brain); // 0x00000001831294E0-0x00000001831295D0
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule(); // 0x000000018394EED0-0x000000018394EFF0
	}

	public interface ICinemachineTargetGroup // TypeDefIndex: 58038
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
	public class CinemachineTargetGroup : MonoBehaviour, ICinemachineTargetGroup // TypeDefIndex: 58043
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
		[CompilerGenerated]
		private Bounds _BoundingBox_k__BackingField; // 0x30
		private float m_MaxWeight; // 0x48
		private Vector3 m_AveragePos; // 0x4C
		private BoundingSphere m_BoundingSphere; // 0x58
	
		// Properties
		public Transform Transform { get; } // 0x00000001853953F4-0x00000001853953FC 
		public Bounds BoundingBox { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D87DE0-0x0000000184D87E00 0x0000000184D87E10-0x0000000184D87E30
		public BoundingSphere Sphere { get; } // 0x0000000184D87E00-0x0000000184D87E10 
		public bool IsEmpty { get; } // 0x00000001867A8BE8-0x00000001867A8C90 
	
		// Nested types
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct Target // TypeDefIndex: 58039
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
		public enum PositionMode // TypeDefIndex: 58040
		{
			GroupCenter = 0,
			GroupAverage = 1
		}
	
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum RotationMode // TypeDefIndex: 58041
		{
			Manual = 0,
			GroupAverage = 1
		}
	
		public enum UpdateMethod // TypeDefIndex: 58042
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2
		}
	
		// Constructors
		public CinemachineTargetGroup(); // 0x0000000184CEAC30-0x0000000184CEACA0
	
		// Methods
		public void AddMember(Transform t, float weight, float radius); // 0x00000001867A7624-0x00000001867A773C
		public void RemoveMember(Transform t); // 0x00000001867A89EC-0x00000001867A8AB0
		public int FindMember(Transform t); // 0x00000001867A814C-0x00000001867A81EC
		public BoundingSphere GetWeightedBoundsForMember(int index); // 0x00000001867A8894-0x00000001867A892C
		public Bounds GetViewSpaceBoundingBox(Matrix4x4 observer); // 0x00000001867A869C-0x00000001867A8894
		private static BoundingSphere WeightedMemberBounds(Target t, Vector3 avgPos, float maxWeight); // 0x00000001867A8AE0-0x00000001867A8BE8
		public void DoUpdate(); // 0x00000001867A7FFC-0x00000001867A814C
		private BoundingSphere CalculateBoundingSphere(float maxWeight); // 0x00000001867A7D3C-0x00000001867A7FFC
		private Vector3 CalculateAveragePosition(out float maxWeight); // 0x00000001867A7930-0x00000001867A7B58
		private Quaternion CalculateAverageOrientation(); // 0x00000001867A773C-0x00000001867A7930
		private Bounds CalculateBoundingBox(Vector3 avgPos, float maxWeight); // 0x00000001867A7B58-0x00000001867A7D3C
		private void OnValidate(); // 0x00000001867A893C-0x00000001867A89EC
		private void FixedUpdate(); // 0x00000001867A81EC-0x00000001867A81FC
		private void Update(); // 0x00000001867A8AB0-0x00000001867A8AE0
		private void LateUpdate(); // 0x00000001867A892C-0x00000001867A893C
		public void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange); // 0x00000001867A81FC-0x00000001867A869C
	}

	[AddComponentMenu("Cinemachine/CinemachineVirtualCamera")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExcludeFromPreset]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineVirtualCamera.html")]
	public class CinemachineVirtualCamera : CinemachineVirtualCameraBase // TypeDefIndex: 58047
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
		public const string PipelineName = "cm"; // Metadata: 0x0234BAF9
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
		public override CameraState State { get; } // 0x0000000184D877D0-0x0000000184D87850 
		public override Transform LookAt { get; set; } // 0x00000001831FD680-0x00000001831FD690 0x0000000184D84CC0-0x0000000184D84CE0
		public override Transform Follow { get; set; } // 0x00000001831FE3A0-0x00000001831FE3B0 0x0000000184D84CE0-0x0000000184D84D00
	
		// Nested types
		public delegate Transform CreatePipelineDelegate(CinemachineVirtualCamera vcam, string name, CinemachineComponentBase[] copyFrom); // TypeDefIndex: 58044; 0x00000001814F3120-0x00000001814F3140
	
		public delegate void DestroyPipelineDelegate(GameObject pipeline); // TypeDefIndex: 58045; 0x0000000182B46B90-0x0000000182B46BA0
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58046
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<CinemachineComponentBase> __9__39_0; // 0x08
			public static Func<CinemachineComponentBase, bool> __9__48_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000184D4C1B0-0x0000000184D4C210
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _UpdateComponentPipeline_b__39_0(CinemachineComponentBase c1, CinemachineComponentBase c2); // 0x000000018389DF10-0x000000018389DF60
			internal bool _RequiresUserInput_b__48_0(CinemachineComponentBase c); // 0x00000001867A9A18-0x00000001867A9A80
		}
	
		// Constructors
		public CinemachineVirtualCamera(); // 0x00000001842203E0-0x0000000184220570
	
		// Methods
		public void SetFieldOfView(float fov); // 0x0000000184D87E30-0x0000000184D87E40
		public override float GetMaxDampTime(); // 0x00000001867A9404-0x00000001867A9490
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x00000001831FD040-0x00000001831FD590
		protected override void OnEnable(); // 0x000000018413B3D0-0x000000018413B590
		protected override void OnDestroy(); // 0x00000001867A9490-0x00000001867A969C
		protected override void OnValidate(); // 0x00000001867A9870-0x00000001867A98DC
		private void OnTransformChildrenChanged(); // 0x000000018539700C-0x0000000185397024
		private void Reset(); // 0x00000001867A9A10-0x00000001867A9A18
		private void DestroyPipeline(); // 0x00000001867A8E04-0x00000001867A9274
		private Transform CreatePipeline(CinemachineVirtualCamera copyFrom); // 0x00000001867A8C90-0x00000001867A8E04
		public void InvalidateComponentPipeline(); // 0x000000018539700C-0x0000000185397024
		public Transform GetComponentOwner(); // 0x00000001867A93E4-0x00000001867A9404
		public CinemachineComponentBase[] GetComponentPipeline(); // 0x0000000185397AD4-0x0000000185397AF4
		public CinemachineComponentBase GetCinemachineComponent(CinemachineCore.Stage stage); // 0x0000000184638530-0x00000001846385B0
		public new T GetCinemachineComponent<T>()
			where T : CinemachineComponentBase;
		public T AddCinemachineComponent<T>()
			where T : CinemachineComponentBase;
		public void DestroyCinemachineComponent<T>()
			where T : CinemachineComponentBase;
		private void UpdateComponentPipeline(); // 0x0000000183E69980-0x0000000183E6A460
		internal static void SetFlagsForHiddenChild(GameObject child); // 0x0000000183E6A460-0x0000000183E6A560
		protected CameraState CalculateNewState(Vector3 worldUp, float deltaTime); // 0x00000001831FD930-0x00000001831FE0B0
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001867A969C-0x00000001867A9870
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x00000001867A9274-0x00000001867A93E4
		internal void SetStateRawPosition(Vector3 pos); // 0x0000000184D87E40-0x0000000184D87E60
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x0000000183E695D0-0x0000000183E697B0
		internal override bool RequiresUserInput(); // 0x00000001867A98DC-0x00000001867A9A10
	}

	[AddComponentMenu("")]
	[SaveDuringPlay]
	public class Cinemachine3rdPersonFollow : CinemachineComponentBase // TypeDefIndex: 58048
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
		public override bool IsValid { get; } // 0x00000001831FA930-0x00000001831FA9C0 
		public override CinemachineCore.Stage Stage { get; } // 0x00000001811EC580-0x00000001811EC590 
	
		// Constructors
		public Cinemachine3rdPersonFollow(); // 0x000000018418E850-0x000000018418E8C0
	
		// Methods
		private void OnValidate(); // 0x000000018679C2FC-0x000000018679C378
		private void Reset(); // 0x0000000184D87A40-0x0000000184D87AB0
		private void OnDestroy(); // 0x000000018679C1FC-0x000000018679C23C
		public override float GetMaxDampTime(); // 0x000000018679BFEC-0x000000018679C010
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x0000000183248DB0-0x0000000183248E30
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x000000018679C23C-0x000000018679C2FC
		private void PositionCamera(ref CameraState curState, float deltaTime); // 0x000000018324B240-0x000000018324B6C0
		public void GetRigPositions(out Vector3 root, out Vector3 shoulder, out Vector3 hand); // 0x000000018679C010-0x000000018679C1FC
		internal static Quaternion GetHeading(Quaternion targetRot, Vector3 up); // 0x000000018324B060-0x000000018324B240
		private void GetRawRigPositions(Vector3 root, Quaternion targetRot, Quaternion heading, out Vector3 shoulder, out Vector3 hand); // 0x0000000183D42CA0-0x0000000183D42E20
		private Vector3 BeyondResolveCollisions(Vector3 root, Vector3 tip, float cameraRadius); // 0x000000018679BD94-0x000000018679BFEC
		private Vector3 ResolveCollisions(Vector3 root, Vector3 tip, float deltaTime, float cameraRadius, ref float collisionCorrection); // 0x000000018679C378-0x000000018679C6C8
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase // TypeDefIndex: 58049
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
		public override bool IsValid { get; } // 0x000000018679CDAC-0x000000018679CE08 
		public override CinemachineCore.Stage Stage { get; } // 0x0000000182BBE540-0x0000000182BBE550 
	
		// Constructors
		public CinemachineBasicMultiChannelPerlin(); // 0x000000018679CD54-0x000000018679CDAC
	
		// Methods
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x000000018679C780-0x000000018679CCD0
		public void ReSeed(); // 0x000000018679CCD0-0x000000018679CD54
		private void Initialize(); // 0x000000018679C6C8-0x000000018679C780
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineComposer : CinemachineComponentBase // TypeDefIndex: 58051
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
		[CompilerGenerated]
		private Vector3 _TrackedPoint_k__BackingField; // 0x64
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
		public override bool IsValid { get; } // 0x00000001831FC1A0-0x00000001831FC230 
		public override CinemachineCore.Stage Stage { get; } // 0x0000000184D85B80-0x0000000184D85B90 
		public Vector3 TrackedPoint { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D87AF0-0x0000000184D87B10 0x0000000184D87B10-0x0000000184D87B20
		protected virtual bool useTrackedObjectOffsetCollision { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		internal Rect SoftGuideRect { get; set; } // 0x0000000183F650D0-0x0000000183F65120 0x000000018679D0BC-0x000000018679D17C
		internal Rect HardGuideRect { get; set; } // 0x0000000183E319F0-0x0000000183E31BC0 0x000000018679CF54-0x000000018679D0BC
	
		// Nested types
		private struct FovCache // TypeDefIndex: 58050
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
			public void UpdateCache(LensSettings lens, Rect softGuide, Rect hardGuide, float targetDistance); // 0x00000001832499E0-0x0000000183249D50
			private Rect ScreenToFOV(Rect rScreen, float fov, float fovH, float aspect); // 0x000000018434E5D0-0x000000018434EB50
		}
	
		// Constructors
		public CinemachineComposer(); // 0x000000018418EA10-0x000000018418EB10
	
		// Methods
		protected virtual Vector3 GetLookAtPointAndSetTrackedPoint(Vector3 lookAt, Vector3 up, float deltaTime); // 0x000000018324B6C0-0x000000018324B8D0
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x000000018679CE18-0x000000018679CF54
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x0000000184D87AD0-0x0000000184D87AF0
		public override float GetMaxDampTime(); // 0x000000018679CE08-0x000000018679CE18
		public override void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime); // 0x000000018324AF50-0x000000018324B060
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001831FEC00-0x00000001831FF6B0
		public void ClearOriginalRotToRect(); // 0x0000000184D87AB0-0x0000000184D87AD0
		private void RotateToScreenBounds(ref CameraState state, Rect screenRect, Vector3 trackedPoint, ref Quaternion rigOrientation, float fov, float fovH, float deltaTime); // 0x00000001831FC230-0x00000001831FC8C0
		private bool ClampVerticalBounds(ref Rect r, Vector3 dir, Vector3 up, float fov); // 0x00000001831FC110-0x00000001831FC1A0
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineFramingTransposer : CinemachineComponentBase // TypeDefIndex: 58054
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
		private const float kMinimumCameraDistance = 0.01f; // Metadata: 0x0234BAFC
		private const float kMinimumGroupSize = 0.01f; // Metadata: 0x0234BB00
		private Vector3 m_PreviousCameraPosition; // 0xA4
		internal PositionPredictor m_Predictor; // 0xB0
		[CompilerGenerated]
		private Vector3 _TrackedPoint_k__BackingField; // 0xB8
		private bool m_InheritingPosition; // 0xC4
		private float m_prevFOV; // 0xC8
		private Quaternion m_prevRotation; // 0xCC
		[CompilerGenerated]
		private Bounds _LastBounds_k__BackingField; // 0xDC
		[CompilerGenerated]
		private Matrix4x4 _LastBoundsMatrix_k__BackingField; // 0xF4
	
		// Properties
		internal Rect SoftGuideRect { get; set; } // 0x000000018679F488-0x000000018679F4D0 0x000000018679F638-0x000000018679F6F8
		internal Rect HardGuideRect { get; set; } // 0x000000018679F36C-0x000000018679F424 0x000000018679F4D0-0x000000018679F638
		public override bool IsValid { get; } // 0x000000018679F424-0x000000018679F488 
		public override CinemachineCore.Stage Stage { get; } // 0x00000001811EC580-0x00000001811EC590 
		public override bool BodyAppliesAfterAim { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public Vector3 TrackedPoint { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D87BA0-0x0000000184D87BC0 0x0000000184D87C10-0x0000000184D87C30
		public Bounds LastBounds { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D87B80-0x0000000184D87BA0 0x0000000184D87BF0-0x0000000184D87C10
		public Matrix4x4 LastBoundsMatrix { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D87B50-0x0000000184D87B80 0x0000000184D87BC0-0x0000000184D87BF0
	
		// Nested types
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum FramingMode // TypeDefIndex: 58052
		{
			Horizontal = 0,
			Vertical = 1,
			HorizontalAndVertical = 2,
			None = 3
		}
	
		public enum AdjustmentMode // TypeDefIndex: 58053
		{
			ZoomOnly = 0,
			DollyOnly = 1,
			DollyThenZoom = 2
		}
	
		// Constructors
		public CinemachineFramingTransposer(); // 0x000000018679F270-0x000000018679F36C
	
		// Methods
		private void OnValidate(); // 0x000000018679EFCC-0x000000018679F0B8
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x000000018679ECFC-0x000000018679EDFC
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x0000000184D87B20-0x0000000184D87B50
		public override float GetMaxDampTime(); // 0x000000018679D608-0x000000018679D620
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams); // 0x000000018679EDFC-0x000000018679EFCC
		private Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect); // 0x000000018679F19C-0x000000018679F270
		private Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect); // 0x000000018679F0B8-0x000000018679F19C
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x000000018679DBC8-0x000000018679ECFC
		private float GetTargetHeight(Vector2 boundsSize); // 0x000000018679DA2C-0x000000018679DBC8
		private Vector3 ComputeGroupBounds(ICinemachineTargetGroup group, ref CameraState curState); // 0x000000018679D17C-0x000000018679D608
		private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, ref Vector3 pos, Quaternion orientation); // 0x000000018679D620-0x000000018679DA2C
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineGroupComposer : CinemachineComposer // TypeDefIndex: 58057
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
		[CompilerGenerated]
		private Bounds _LastBounds_k__BackingField; // 0x148
		[CompilerGenerated]
		private Matrix4x4 _LastBoundsMatrix_k__BackingField; // 0x160
	
		// Properties
		public Bounds LastBounds { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D87C60-0x0000000184D87C80 0x0000000184D87CB0-0x0000000184D87CD0
		public Matrix4x4 LastBoundsMatrix { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D87C30-0x0000000184D87C60 0x0000000184D87C80-0x0000000184D87CB0
	
		// Nested types
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum FramingMode // TypeDefIndex: 58055
		{
			Horizontal = 0,
			Vertical = 1,
			HorizontalAndVertical = 2
		}
	
		public enum AdjustmentMode // TypeDefIndex: 58056
		{
			ZoomOnly = 0,
			DollyOnly = 1,
			DollyThenZoom = 2
		}
	
		// Constructors
		public CinemachineGroupComposer(); // 0x00000001867A07C0-0x00000001867A0838
	
		// Methods
		private void OnValidate(); // 0x00000001867A06F0-0x00000001867A07C0
		public override float GetMaxDampTime(); // 0x000000018679F6F8-0x000000018679F710
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x000000018679FB74-0x00000001867A06F0
		private float GetTargetHeight(Vector2 boundsSize); // 0x000000018679F99C-0x000000018679FB74
		private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, Matrix4x4 observer, out Vector3 newFwd); // 0x000000018679F710-0x000000018679F99C
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineHardLockToTarget : CinemachineComponentBase // TypeDefIndex: 58058
	{
		// Fields
		[Tooltip("How much time it takes for the position to catch up to the target\'s position")]
		public float m_Damping; // 0x20
		private Vector3 m_PreviousTargetPosition; // 0x24
	
		// Properties
		public override bool IsValid { get; } // 0x00000001867A0994-0x00000001867A09F8 
		public override CinemachineCore.Stage Stage { get; } // 0x00000001811EC580-0x00000001811EC590 
	
		// Constructors
		public CinemachineHardLockToTarget(); // 0x0000000183695570-0x0000000183695590
	
		// Methods
		public override float GetMaxDampTime(); // 0x00000001811EC8A0-0x00000001811EC8B0
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001867A0838-0x00000001867A0994
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineHardLookAt : CinemachineComponentBase // TypeDefIndex: 58059
	{
		// Properties
		public override bool IsValid { get; } // 0x00000001867A0BC0-0x00000001867A0C24 
		public override CinemachineCore.Stage Stage { get; } // 0x0000000184D85B80-0x0000000184D85B90 
	
		// Constructors
		public CinemachineHardLookAt(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001867A09F8-0x00000001867A0BC0
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineOrbitalTransposer : CinemachineTransposer // TypeDefIndex: 58064
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
		public override bool RequiresUserInput { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	
		// Nested types
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct Heading // TypeDefIndex: 58061
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
			public enum HeadingDefinition // TypeDefIndex: 58060
			{
				PositionDelta = 0,
				Velocity = 1,
				TargetForward = 2,
				WorldForward = 3
			}
	
			// Constructors
			public Heading(HeadingDefinition def, int filterStrength, float bias); // 0x0000000184D87E60-0x0000000184D87E70
		}
	
		internal delegate float UpdateHeadingDelegate(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up); // TypeDefIndex: 58062; 0x00000001867A9BB4-0x00000001867A9BEC
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58063
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static UpdateHeadingDelegate __9__30_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001867A9B50-0x00000001867A9BB4
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _.ctor_b__30_0(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up); // 0x00000001867A9A80-0x00000001867A9B50
		}
	
		// Constructors
		public CinemachineOrbitalTransposer(); // 0x00000001867A2348-0x00000001867A25D4
	
		// Methods
		protected override void OnValidate(); // 0x00000001867A1FBC-0x00000001867A2114
		public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis); // 0x00000001867A2114-0x00000001867A2154
		public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis, ref AxisState.Recentering recentering, bool isLive); // 0x00000001867A2154-0x00000001867A2288
		private void OnEnable(); // 0x00000001867A1C80-0x00000001867A1CC8
		public void UpdateInputAxisProvider(); // 0x00000001867A2288-0x00000001867A2348
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001867A1CC8-0x00000001867A1E08
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x00000001867A0C24-0x00000001867A0D64
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams); // 0x00000001867A1E08-0x00000001867A1FBC
		public float GetAxisClosestValue(Vector3 cameraPos, Vector3 up); // 0x00000001867A0D64-0x00000001867A1084
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001867A15A0-0x00000001867A1C80
		public override Vector3 GetTargetCameraPosition(Vector3 worldUp); // 0x00000001867A1084-0x00000001867A11E0
		private float GetTargetHeading(float currentHeading, Quaternion targetOrientation); // 0x00000001867A11E0-0x00000001867A15A0
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachinePOV : CinemachineComponentBase // TypeDefIndex: 58066
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
		public override bool IsValid { get; } // 0x00000001867A3450-0x00000001867A3458 
		public override CinemachineCore.Stage Stage { get; } // 0x0000000184D85B80-0x0000000184D85B90 
		public override bool RequiresUserInput { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	
		// Nested types
		public enum RecenterTargetMode // TypeDefIndex: 58065
		{
			None = 0,
			FollowTargetForward = 1,
			LookAtTargetForward = 2
		}
	
		// Constructors
		public CinemachinePOV(); // 0x00000001867A31F4-0x00000001867A3450
	
		// Methods
		private void OnValidate(); // 0x00000001867A2C60-0x00000001867A2CE0
		private void OnEnable(); // 0x00000001867A2AB8-0x00000001867A2AC0
		public void UpdateInputAxisProvider(); // 0x00000001867A30FC-0x00000001867A31F4
		public override void PrePipelineMutateCameraState(ref CameraState state, float deltaTime); // 0x00000001841E1670-0x00000001841E1680
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001867A2824-0x00000001867A2AB8
		public Vector2 GetRecenterTarget(); // 0x00000001867A25F4-0x00000001867A2824
		private static float NormalizeAngle(float angle); // 0x0000000184D87CD0-0x0000000184D87D00
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x00000001867A25D4-0x00000001867A25F4
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams); // 0x00000001867A2AC0-0x00000001867A2C60
		private void SetAxesForRotation(Quaternion targetRot); // 0x00000001867A2CE0-0x00000001867A30FC
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineSameAsFollowTarget : CinemachineComponentBase // TypeDefIndex: 58067
	{
		// Fields
		[FormerlySerializedAs("m_AngularDamping")]
		[Tooltip("How much time it takes for the aim to catch up to the target\'s rotation")]
		public float m_Damping; // 0x20
		private Quaternion m_PreviousReferenceOrientation; // 0x24
	
		// Properties
		public override bool IsValid { get; } // 0x00000001867AD968-0x00000001867AD9CC 
		public override CinemachineCore.Stage Stage { get; } // 0x0000000184D85B80-0x0000000184D85B90 
	
		// Constructors
		public CinemachineSameAsFollowTarget(); // 0x000000018418E810-0x000000018418E850
	
		// Methods
		public override float GetMaxDampTime(); // 0x00000001811EC8A0-0x00000001811EC8B0
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001867AD870-0x00000001867AD968
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineTrackedDolly : CinemachineComponentBase // TypeDefIndex: 58070
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
		public override bool IsValid { get; } // 0x00000001867AE4C0-0x00000001867AE508 
		public override CinemachineCore.Stage Stage { get; } // 0x00000001811EC580-0x00000001811EC590 
		private Vector3 AngularDamping { get; } // 0x00000001867AE450-0x00000001867AE4C0 
	
		// Nested types
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum CameraUpMode // TypeDefIndex: 58068
		{
			Default = 0,
			Path = 1,
			PathNoRoll = 2,
			FollowTarget = 3,
			FollowTargetNoRoll = 4
		}
	
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct AutoDolly // TypeDefIndex: 58069
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
			public AutoDolly(bool enabled, float positionOffset, int searchRadius, int stepsPerSegment); // 0x0000000184D87EF0-0x0000000184D87F10
		}
	
		// Constructors
		public CinemachineTrackedDolly(); // 0x000000018418E8C0-0x000000018418E950
	
		// Methods
		public override float GetMaxDampTime(); // 0x00000001867ADBF8-0x00000001867ADC50
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001867ADC50-0x00000001867AE450
		private Quaternion GetCameraOrientationAtPathPoint(Quaternion pathOrientation, Vector3 up); // 0x00000001867AD9CC-0x00000001867ADBF8
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineTransposer : CinemachineComponentBase // TypeDefIndex: 58073
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
		[CompilerGenerated]
		private bool _HideOffsetInInspector_k__BackingField; // 0x50
		private Vector3 m_PreviousTargetPosition; // 0x54
		private Quaternion m_PreviousReferenceOrientation; // 0x60
		private Quaternion m_targetOrientationOnAssign; // 0x70
		private Vector3 m_PreviousOffset; // 0x80
		private Transform m_previousTarget; // 0x90
	
		// Properties
		public bool HideOffsetInInspector { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86800-0x0000000184D86810 0x0000000184D86840-0x0000000184D86850
		public Vector3 EffectiveOffset { get; } // 0x00000001867AFC3C-0x00000001867AFC74 
		public override bool IsValid { get; } // 0x00000001867AFC74-0x00000001867AFCBC 
		public override CinemachineCore.Stage Stage { get; } // 0x00000001811EC580-0x00000001811EC590 
		protected Vector3 Damping { get; } // 0x00000001867AFC1C-0x00000001867AFC3C 
		protected Vector3 AngularDamping { get; } // 0x00000001867AFBA4-0x00000001867AFC1C 
	
		// Nested types
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum BindingMode // TypeDefIndex: 58071
		{
			LockToTargetOnAssign = 0,
			LockToTargetWithWorldUp = 1,
			LockToTargetNoRoll = 2,
			LockToTarget = 3,
			WorldSpace = 4,
			SimpleFollowWithWorldUp = 5
		}
	
		public enum AngularDampingMode // TypeDefIndex: 58072
		{
			Euler = 0,
			Quaternion = 1
		}
	
		// Constructors
		public CinemachineTransposer(); // 0x000000018418E950-0x000000018418EA10
	
		// Methods
		protected virtual void OnValidate(); // 0x00000001867AF3E4-0x00000001867AF414
		public override float GetMaxDampTime(); // 0x00000001867AE688-0x00000001867AE708
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001867AF088-0x00000001867AF324
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001867AF324-0x00000001867AF3E4
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x00000001867AE508-0x00000001867AE688
		protected void InitPrevFrameStateInfo(ref CameraState curState, float deltaTime); // 0x00000001867AEF54-0x00000001867AF088
		protected void TrackTarget(float deltaTime, Vector3 up, Vector3 desiredCameraOffset, out Vector3 outTargetPosition, out Quaternion outTargetOrient); // 0x00000001867AF414-0x00000001867AFBA4
		protected Vector3 GetOffsetForMinimumTargetDistance(Vector3 dampedTargetPos, Vector3 cameraOffset, Vector3 cameraFwd, Vector3 up, Vector3 actualTargetPos); // 0x00000001867AE708-0x00000001867AEAD8
		public virtual Vector3 GetTargetCameraPosition(Vector3 worldUp); // 0x00000001867AEE40-0x00000001867AEF54
		public Quaternion GetReferenceOrientation(Vector3 worldUp); // 0x00000001867AEAD8-0x00000001867AEE40
	}

	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public struct AxisState // TypeDefIndex: 58077
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
		private const float Epsilon = 0.0001f; // Metadata: 0x0234BB25
		private IInputAxisProvider m_InputAxisProvider; // 0x60
		private int m_InputAxisIndex; // 0x68
		[CompilerGenerated]
		private bool _ValueRangeLocked_k__BackingField; // 0x6C
		[CompilerGenerated]
		private bool _HasRecentering_k__BackingField; // 0x6D
	
		// Properties
		public bool ValueRangeLocked { [CompilerGenerated] set; } // 0x0000000184D87F30-0x0000000184D87F40
		public bool HasRecentering { [CompilerGenerated] set; } // 0x0000000184D87F20-0x0000000184D87F30
	
		// Nested types
		public enum SpeedMode // TypeDefIndex: 58074
		{
			MaxSpeed = 0,
			InputValueGain = 1
		}
	
		public interface IInputAxisProvider // TypeDefIndex: 58075
		{
			// Methods
			float GetAxisValue(int axis);
		}
	
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct Recentering // TypeDefIndex: 58076
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
			public Recentering(bool enabled, float waitTime, float recenteringTime); // 0x0000000184D88080-0x0000000184D880A0
	
			// Methods
			public void Validate(); // 0x00000001867B1C84-0x00000001867B1CA4
			public void CancelRecentering(); // 0x00000001867B1A6C-0x00000001867B1AC0
			public void DoRecentering(ref AxisState axis, float deltaTime, float recenterTarget); // 0x00000001867B1AC0-0x00000001867B1C5C
			internal bool LegacyUpgrade(ref int heading, ref int velocityFilter); // 0x00000001867B1C5C-0x00000001867B1C84
		}
	
		// Constructors
		public AxisState(float minValue, float maxValue, bool wrap, bool rangeLocked, float maxSpeed, float accelTime, float decelTime, string name, bool invert); // 0x00000001867AA840-0x00000001867AA920
	
		// Methods
		public void Validate(); // 0x00000001867AA7F8-0x00000001867AA840
		public void Reset(); // 0x0000000184D87F10-0x0000000184D87F20
		public void SetInputAxisProvider(int axis, IInputAxisProvider provider); // 0x00000001867AA3EC-0x00000001867AA3FC
		public bool Update(float deltaTime); // 0x00000001867AA3FC-0x00000001867AA7F8
		private float ClampValue(float v); // 0x00000001867AA124-0x00000001867AA194
		private bool MaxSpeedUpdate(float input, float deltaTime); // 0x00000001867AA20C-0x00000001867AA3EC
		private float GetMaxSpeed(); // 0x00000001867AA194-0x00000001867AA20C
	}

	public struct CameraState // TypeDefIndex: 58081
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
		[CompilerGenerated]
		private int _NumCustomBlendables_k__BackingField; // 0x118
	
		// Properties
		public bool HasLookAt { get; } // 0x0000000185391AA8-0x0000000185391AFC 
		public Vector3 CorrectedPosition { get; } // 0x00000001831FF6B0-0x00000001831FF720 
		public Quaternion CorrectedOrientation { get; } // 0x0000000183249990-0x00000001832499E0 
		public Vector3 FinalPosition { get; } // 0x00000001831FF6B0-0x00000001831FF720 
		public Quaternion FinalOrientation { get; } // 0x0000000183249910-0x0000000183249990 
		public static CameraState Default { get; } // 0x000000018324BFC0-0x000000018324C110 
		public int NumCustomBlendables { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000184D87FF0-0x0000000184D88000 0x0000000184D88000-0x0000000184D88010
	
		// Nested types
		public struct HGDOFParams // TypeDefIndex: 58078
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
	
		public enum BlendHintValue // TypeDefIndex: 58079
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
	
		public struct CustomBlendable // TypeDefIndex: 58080
		{
			// Fields
			public UnityEngine.Object m_Custom; // 0x00
			public float m_Weight; // 0x08
	
			// Constructors
			public CustomBlendable(UnityEngine.Object custom, float weight); // 0x00000001867B1770-0x00000001867B178C
		}
	
		// Constructors
		static CameraState(); // 0x0000000184D59CF0-0x0000000184D59D40
	
		// Methods
		public CustomBlendable GetCustomBlendable(int index); // 0x00000001867ABD30-0x00000001867ABE1C
		private int FindCustomBlendable(UnityEngine.Object custom); // 0x00000001867ABBAC-0x00000001867ABD30
		public void AddCustomBlendable(CustomBlendable b); // 0x00000001867ABA00-0x00000001867ABBAC
		public static CameraState Lerp([IsReadOnly] in CameraState stateA, [IsReadOnly] in CameraState stateB, float t); // 0x0000000183245B00-0x0000000183246C60
		private static float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t); // 0x00000001867ABE1C-0x00000001867ABF48
		private static Vector3 ApplyPosBlendHint(Vector3 posA, BlendHintValue hintA, Vector3 posB, BlendHintValue hintB, Vector3 original, Vector3 blended); // 0x0000000183246C90-0x0000000183246CC0
		private static Quaternion ApplyRotBlendHint(Quaternion rotA, BlendHintValue hintA, Quaternion rotB, BlendHintValue hintB, Quaternion original, Quaternion blended); // 0x0000000183246C60-0x0000000183246C90
		private Vector3 InterpolatePosition(Vector3 posA, Vector3 pivotA, Vector3 posB, Vector3 pivotB, float t, ref int positionCylindricalDir); // 0x0000000183245530-0x0000000183245990
	}

	public class CinemachineBlend // TypeDefIndex: 58082
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
		public ICinemachineCamera CamA { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001833C72F0-0x00000001833C7310
		public float BlendWeight { get; } // 0x00000001867ABF48-0x00000001867ABFC0 
		public bool IsValid { get; } // 0x00000001867AC190-0x00000001867AC1D8 
		public bool IsComplete { get; } // 0x00000001867AC168-0x00000001867AC190 
		public string Description { get; } // 0x00000001867ABFC0-0x00000001867AC168 
		public CameraState State { get; } // 0x00000001833CA470-0x00000001833CA6B0 
	
		// Constructors
		public CinemachineBlend(ICinemachineCamera a, ICinemachineCamera b, AnimationCurve curve, float duration, float t); // 0x0000000183FCFE70-0x0000000183FCFEE0
	
		// Methods
		public void StartSimpleInertialization(); // 0x0000000184D88010-0x0000000184D88020
		public bool Uses(ICinemachineCamera cam); // 0x00000001833C9BF0-0x00000001833C9C60
		public void UpdateCameraState(Vector3 worldUp, float deltaTime); // 0x00000001833C9F50-0x00000001833CA000
	}

	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public struct CinemachineBlendDefinition // TypeDefIndex: 58084
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
		public float BlendTime { get; } // 0x0000000183245AF0-0x0000000183245B00 
		public AnimationCurve BlendCurve { get; } // 0x0000000183247400-0x0000000183247470 
	
		// Nested types
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum Style // TypeDefIndex: 58083
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
		public CinemachineBlendDefinition(Style style, float time); // 0x0000000185396C64-0x0000000185396C90
	
		// Methods
		private void CreateStandardCurves(); // 0x00000001846FFE80-0x00000001847003A0
	}

	internal class StaticPointVirtualCamera : ICinemachineCamera // TypeDefIndex: 58085
	{
		// Fields
		[CompilerGenerated]
		private string _Name_k__BackingField; // 0x10
		[CompilerGenerated]
		private int _Priority_k__BackingField; // 0x18
		[CompilerGenerated]
		private Transform _LookAt_k__BackingField; // 0x20
		[CompilerGenerated]
		private Transform _Follow_k__BackingField; // 0x28
		[CompilerGenerated]
		private CameraState _State_k__BackingField; // 0x30
	
		// Properties
		public string Name { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public int Priority { [CompilerGenerated] get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
		public Transform LookAt { [CompilerGenerated] get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public Transform Follow { [CompilerGenerated] get; } // 0x0000000184D86240-0x0000000184D86250 
		public CameraState State { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D87F70-0x0000000184D87FF0 0x00000001867AB4DC-0x00000001867AB550
		public GameObject VirtualCameraGameObject { get; } // 0x00000001811EC580-0x00000001811EC590 
		public bool IsValid { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public ICinemachineCamera ParentCamera { get; } // 0x00000001811EC580-0x00000001811EC590 
	
		// Constructors
		public StaticPointVirtualCamera([IsReadOnly] in CameraState state, string name); // 0x00000001867B2390-0x00000001867B2488
	
		// Methods
		public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0234BB3D */); // 0x00000001812081B0-0x0000000181208610
		public void UpdateCameraState(Vector3 worldUp, float deltaTime); // 0x00000001841E1670-0x00000001841E1680
		public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x00000001841E1670-0x00000001841E1680
	}

	internal class BlendSourceVirtualCamera : ICinemachineCamera // TypeDefIndex: 58086
	{
		// Fields
		[CompilerGenerated]
		private CinemachineBlend _Blend_k__BackingField; // 0x10
		[CompilerGenerated]
		private int _Priority_k__BackingField; // 0x18
		[CompilerGenerated]
		private Transform _LookAt_k__BackingField; // 0x20
		[CompilerGenerated]
		private Transform _Follow_k__BackingField; // 0x28
		[CompilerGenerated]
		private CameraState _State_k__BackingField; // 0x30
	
		// Properties
		public CinemachineBlend Blend { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public string Name { get; } // 0x00000001867AB4B0-0x00000001867AB4DC 
		public int Priority { [CompilerGenerated] get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
		public Transform LookAt { [CompilerGenerated] get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public Transform Follow { [CompilerGenerated] get; } // 0x0000000184D86240-0x0000000184D86250 
		public CameraState State { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D87F70-0x0000000184D87FF0 0x00000001867AB4DC-0x00000001867AB550
		public GameObject VirtualCameraGameObject { get; } // 0x00000001811EC580-0x00000001811EC590 
		public bool IsValid { get; } // 0x00000001867AB498-0x00000001867AB4B0 
		public ICinemachineCamera ParentCamera { get; } // 0x00000001811EC580-0x00000001811EC590 
	
		// Constructors
		public BlendSourceVirtualCamera(CinemachineBlend blend); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0234BB3E */); // 0x00000001867AB3A4-0x00000001867AB3C4
		public void UpdateCameraState(Vector3 worldUp, float deltaTime); // 0x00000001867AB3C4-0x00000001867AB498
		public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineBlending.html")]
	public sealed class CinemachineBlenderSettings : ScriptableObject // TypeDefIndex: 58089
	{
		// Fields
		[Tooltip("The array containing explicitly defined blends between two Virtual Cameras")]
		public CustomBlend[] m_CustomBlends; // 0x18
		public CustomBlendGroup[] m_CustomBlendGroups; // 0x20
		public const string kBlendFromAnyCameraLabel = "**ANY CAMERA**"; // Metadata: 0x0234BB3F
	
		// Nested types
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct CustomBlend // TypeDefIndex: 58087
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
		public class CustomBlendGroup // TypeDefIndex: 58088
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
			public CustomBlendGroup(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public CinemachineBlenderSettings(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		public CinemachineBlendDefinition GetBlendForVirtualCameras(string fromCameraName, string toCameraName, CinemachineBlendDefinition defaultBlend); // 0x00000001840F7B40-0x00000001840F7EC0
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public abstract class CinemachineComponentBase : MonoBehaviour // TypeDefIndex: 58090
	{
		// Fields
		protected const float Epsilon = 0.0001f; // Metadata: 0x0234BB4E
		private CinemachineVirtualCameraBase m_vcamOwner; // 0x18
	
		// Properties
		public CinemachineVirtualCameraBase VirtualCamera { get; } // 0x00000001831FD750-0x00000001831FD930 
		public Transform FollowTarget { get; } // 0x00000001831FC8C0-0x00000001831FC9B0 
		public Transform LookAtTarget { get; } // 0x00000001831FD590-0x00000001831FD680 
		public ICinemachineTargetGroup AbstractFollowTargetGroup { get; } // 0x00000001867AC1D8-0x00000001867AC1FC 
		public CinemachineTargetGroup FollowTargetGroup { get; } // 0x00000001867AC220-0x00000001867AC264 
		public Vector3 FollowTargetPosition { get; } // 0x000000018324B8D0-0x000000018324BA40 
		public Quaternion FollowTargetRotation { get; } // 0x000000018324BBA0-0x000000018324BD00 
		public ICinemachineTargetGroup AbstractLookAtTargetGroup { get; } // 0x00000001867AC1FC-0x00000001867AC220 
		public CinemachineTargetGroup LookAtTargetGroup { get; } // 0x00000001867AC264-0x00000001867AC2A8 
		public Vector3 LookAtTargetPosition { get; } // 0x00000001867AC2A8-0x00000001867AC430 
		public Quaternion LookAtTargetRotation { get; } // 0x000000018324BA40-0x000000018324BBA0 
		public CameraState VcamState { get; } // 0x00000001867AC430-0x00000001867AC598 
		public abstract bool IsValid { get; }
		public abstract CinemachineCore.Stage Stage { get; }
		public virtual bool BodyAppliesAfterAim { get; } // 0x00000001812081B0-0x0000000181208610 
		public virtual bool RequiresUserInput { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Constructors
		protected CinemachineComponentBase(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public virtual void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001841E1670-0x00000001841E1680
		public abstract void MutateCameraState(ref CameraState curState, float deltaTime);
		public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams); // 0x00000001812081B0-0x0000000181208610
		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001841E1670-0x00000001841E1680
		public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x00000001841E1670-0x00000001841E1680
		public virtual float GetMaxDampTime(); // 0x0000000184D879D0-0x0000000184D879E0
	}

	public sealed class CinemachineCore // TypeDefIndex: 58097
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
		public static CinemachineCore Instance { get; } // 0x00000001833C8EA0-0x00000001833C8F90 
		public static float DeltaTime { get; } // 0x00000001867ACB74-0x00000001867ACBE4 
		public static float CurrentTime { get; } // 0x00000001833C7B20-0x00000001833C7B70 
		public int BrainCount { get; } // 0x0000000183140AD0-0x0000000183140AF0 
		public int VirtualCameraCount { get; } // 0x00000001833C9030-0x00000001833C9050 
	
		// Nested types
		public enum Stage // TypeDefIndex: 58091
		{
			Body = 0,
			Aim = 1,
			Noise = 2,
			Finalize = 3
		}
	
		public delegate float AxisInputDelegate(string axisName); // TypeDefIndex: 58092; 0x00000001814E2060-0x00000001814E2070
	
		public delegate CinemachineBlendDefinition GetBlendOverrideDelegate(ICinemachineCamera fromVcam, ICinemachineCamera toVcam, CinemachineBlendDefinition defaultBlend, MonoBehaviour owner); // TypeDefIndex: 58093; 0x00000001867B178C-0x00000001867B17FC
	
		private class UpdateStatus // TypeDefIndex: 58094
		{
			// Fields
			public int lastUpdateFrame; // 0x10
			public int lastUpdateFixedFrame; // 0x14
			public UpdateTracker.UpdateClock lastUpdateMode; // 0x18
			public float lastUpdateDeltaTime; // 0x1C
	
			// Constructors
			public UpdateStatus(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		internal enum UpdateFilter // TypeDefIndex: 58095
		{
			Fixed = 0,
			Late = 1,
			Smart = 8,
			SmartFixed = 8,
			SmartLate = 9
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58096
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<CinemachineVirtualCameraBase> __9__30_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001867B272C-0x00000001867B2790
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetVirtualCamera_b__30_0(CinemachineVirtualCameraBase x, CinemachineVirtualCameraBase y); // 0x00000001867B263C-0x00000001867B2670
		}
	
		// Constructors
		public CinemachineCore(); // 0x000000018413B2C0-0x000000018413B3D0
		static CinemachineCore(); // 0x0000000183FCFB10-0x0000000183FCFD10
	
		// Methods
		public CinemachineBrain GetActiveBrain(int index); // 0x00000001833C91D0-0x00000001833C9220
		internal void AddActiveBrain(CinemachineBrain brain); // 0x0000000183FCF5F0-0x0000000183FCF660
		internal void RemoveActiveBrain(CinemachineBrain brain); // 0x0000000183FCF660-0x0000000183FCF6C0
		public CinemachineVirtualCameraBase GetVirtualCamera(int index); // 0x00000001833C8A80-0x00000001833C8B10
		internal void AddActiveCamera(CinemachineVirtualCameraBase vcam); // 0x000000018413BBA0-0x000000018413BBE0
		internal void RemoveActiveCamera(CinemachineVirtualCameraBase vcam); // 0x000000018413BB40-0x000000018413BBA0
		internal void CameraDestroyed(CinemachineVirtualCameraBase vcam); // 0x00000001867AC598-0x00000001867AC664
		internal void CameraEnabled(CinemachineVirtualCameraBase vcam); // 0x000000018413BBE0-0x000000018413BD60
		internal void CameraDisabled(CinemachineVirtualCameraBase vcam); // 0x000000018413B8D0-0x000000018413B970
		internal void UpdateAllActiveVirtualCameras(int layerMask, Vector3 worldUp, float deltaTime); // 0x00000001833C7BC0-0x00000001833C8190
		internal void UpdateVirtualCamera(CinemachineVirtualCameraBase vcam, Vector3 worldUp, float deltaTime); // 0x00000001833C9C60-0x00000001833C9F50
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule(); // 0x0000000184CE97C0-0x0000000184CE9870
		private static Transform GetUpdateTarget(CinemachineVirtualCameraBase vcam); // 0x00000001867AC8AC-0x00000001867AC9A4
		internal UpdateTracker.UpdateClock GetVcamUpdateStatus(CinemachineVirtualCameraBase vcam); // 0x00000001867AC9A4-0x00000001867ACA20
		public bool IsLive(ICinemachineCamera vcam); // 0x00000001833C9050-0x00000001833C91D0
		public bool IsLiveInBlend(ICinemachineCamera vcam); // 0x00000001867ACA20-0x00000001867ACAE0
		public void GenerateCameraActivationEvent(ICinemachineCamera vcam, ICinemachineCamera vcamFrom); // 0x00000001867AC664-0x00000001867AC75C
		public void GenerateCameraCutEvent(ICinemachineCamera vcam); // 0x00000001867AC75C-0x00000001867AC8AC
		public CinemachineBrain FindPotentialTargetBrain(CinemachineVirtualCameraBase vcam); // 0x00000001833C8210-0x00000001833C8670
		public void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001867ACAE0-0x00000001867ACB74
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public abstract class CinemachineExtension : MonoBehaviour // TypeDefIndex: 58098
	{
		// Fields
		protected const float Epsilon = 0.0001f; // Metadata: 0x0234BB5B
		private CinemachineVirtualCameraBase m_vcamOwner; // 0x18
		private Dictionary<ICinemachineCamera, object> mExtraState; // 0x20
	
		// Properties
		public CinemachineVirtualCameraBase VirtualCamera { get; } // 0x0000000183FD98F0-0x0000000183FD9990 
		public virtual bool RequiresUserInput { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Constructors
		protected CinemachineExtension(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected virtual void Awake(); // 0x0000000184CAE4D0-0x0000000184CAE4E0
		protected virtual void OnEnable(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnDestroy(); // 0x00000001867ACBE4-0x00000001867ACBF4
		internal void EnsureStarted(); // 0x0000000184CAE4D0-0x0000000184CAE4E0
		protected virtual void ConnectToVcam(bool connect); // 0x0000000183FD9750-0x0000000183FD98F0
		public virtual void PrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState curState, float deltaTime); // 0x00000001841E1670-0x00000001841E1680
		public void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x0000000185391850-0x0000000185391870
		protected abstract void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime);
		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001841E1670-0x00000001841E1680
		public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x00000001841E1670-0x00000001841E1680
		public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x00000001812081B0-0x0000000181208610
		public virtual float GetMaxDampTime(); // 0x0000000184D879D0-0x0000000184D879E0
		protected T GetExtraState<T>(ICinemachineCamera vcam)
			where T : class, new();
		protected List<T> GetAllExtraStates<T>()
			where T : class, new();
	}

	public abstract class CinemachinePathBase : MonoBehaviour // TypeDefIndex: 58101
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
		public float PathLength { get; } // 0x00000001867AD81C-0x00000001867AD870 
	
		// Nested types
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public class Appearance // TypeDefIndex: 58099
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
			public Appearance(); // 0x00000001867AA0EC-0x00000001867AA124
		}
	
		public enum PositionUnits // TypeDefIndex: 58100
		{
			PathUnits = 0,
			Distance = 1,
			Normalized = 2
		}
	
		// Constructors
		protected CinemachinePathBase(); // 0x00000001867AD7C0-0x00000001867AD81C
	
		// Methods
		public virtual float StandardizePos(float pos); // 0x00000001867AD588-0x00000001867AD62C
		public abstract Vector3 EvaluatePosition(float pos);
		public abstract Vector3 EvaluateTangent(float pos);
		public abstract Quaternion EvaluateOrientation(float pos);
		public virtual float FindClosestPoint(Vector3 p, int startSegment, int searchRadius, int stepsPerSegment); // 0x00000001867ACD60-0x00000001867AD074
		public float MinUnit(PositionUnits units); // 0x00000001867AD1D8-0x00000001867AD200
		public float MaxUnit(PositionUnits units); // 0x00000001867AD1A0-0x00000001867AD1D8
		public virtual float StandardizeUnit(float pos, PositionUnits units); // 0x00000001867AD62C-0x00000001867AD6A4
		public Vector3 EvaluatePositionAtUnit(float pos, PositionUnits units); // 0x00000001867ACCB8-0x00000001867ACD0C
		public Vector3 EvaluateTangentAtUnit(float pos, PositionUnits units); // 0x00000001867ACD0C-0x00000001867ACD60
		public Quaternion EvaluateOrientationAtUnit(float pos, PositionUnits units); // 0x00000001867ACC6C-0x00000001867ACCB8
		public virtual void InvalidateDistanceCache(); // 0x00000001867AD170-0x00000001867AD1A0
		public bool DistanceCacheIsValid(); // 0x00000001867ACBF4-0x00000001867ACC6C
		public float StandardizePathDistance(float distance); // 0x00000001867AD4F4-0x00000001867AD588
		public float ToNativePathUnits(float pos, PositionUnits units); // 0x00000001867AD6A4-0x00000001867AD7C0
		public float FromPathNativeUnits(float pos, PositionUnits units); // 0x00000001867AD074-0x00000001867AD170
		private void ResamplePath(int stepsPerSegment); // 0x00000001867AD200-0x00000001867AD4F4
	}

	public sealed class AxisStatePropertyAttribute : PropertyAttribute // TypeDefIndex: 58102
	{
		// Constructors
		public AxisStatePropertyAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public sealed class OrbitalTransposerHeadingPropertyAttribute : PropertyAttribute // TypeDefIndex: 58103
	{
		// Constructors
		public OrbitalTransposerHeadingPropertyAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public sealed class VcamTargetPropertyAttribute : PropertyAttribute // TypeDefIndex: 58104
	{
		// Constructors
		public VcamTargetPropertyAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public sealed class CinemachineBlendDefinitionPropertyAttribute : PropertyAttribute // TypeDefIndex: 58105
	{
		// Constructors
		public CinemachineBlendDefinitionPropertyAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public sealed class SaveDuringPlayAttribute : Attribute // TypeDefIndex: 58106
	{
		// Constructors
		public SaveDuringPlayAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public sealed class NoSaveDuringPlayAttribute : PropertyAttribute // TypeDefIndex: 58107
	{
		// Constructors
		public NoSaveDuringPlayAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public sealed class TagFieldAttribute : PropertyAttribute // TypeDefIndex: 58108
	{
		// Constructors
		public TagFieldAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public sealed class NoiseSettingsPropertyAttribute : PropertyAttribute // TypeDefIndex: 58109
	{
		// Constructors
		public NoiseSettingsPropertyAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public sealed class CinemachineEmbeddedAssetPropertyAttribute : PropertyAttribute // TypeDefIndex: 58110
	{
		// Fields
		public bool WarnIfNull; // 0x10
	
		// Constructors
		public CinemachineEmbeddedAssetPropertyAttribute(bool warnIfNull = false /* Metadata: 0x0234BB62 */); // 0x0000000184D86130-0x0000000184D86140
	}

	[DocumentationSorting(Level.Undoc)]
	public sealed class DocumentationSortingAttribute : Attribute // TypeDefIndex: 58112
	{
		// Fields
		[CompilerGenerated]
		private Level _Category_k__BackingField; // 0x10
	
		// Properties
		private Level Category { [CompilerGenerated] set; } // 0x00000001814F51F0-0x00000001814F5220
	
		// Nested types
		public enum Level // TypeDefIndex: 58111
		{
			Undoc = 0,
			API = 1,
			UserRef = 2
		}
	
		// Constructors
		public DocumentationSortingAttribute(Level category); // 0x00000001814F51F0-0x00000001814F5220
	}

	[SaveDuringPlay]
	public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera // TypeDefIndex: 58117
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
		[CompilerGenerated]
		private List<CinemachineExtension> _mExtensions_k__BackingField; // 0x50
		[CompilerGenerated]
		private bool _PreviousStateIsValid_k__BackingField; // 0x58
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
		[CompilerGenerated]
		private bool _FollowTargetChanged_k__BackingField; // 0xA0
		[CompilerGenerated]
		private bool _LookAtTargetChanged_k__BackingField; // 0xA1
	
		// Properties
		public int ValidatingStreamVersion { get; private set; } // 0x000000018413B590-0x000000018413B600 0x00000001811F2AA0-0x00000001811F2AB0
		public List<CinemachineExtension> mExtensions { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		public string Name { get; } // 0x0000000185396F58-0x0000000185396F60 
		public virtual string Description { get; } // 0x00000001867B05F8-0x00000001867B0624 
		public int Priority { get; set; } // 0x0000000184D86730-0x0000000184D86740 0x0000000184D86760-0x0000000184D86770
		public GameObject VirtualCameraGameObject { get; } // 0x00000001833CA6B0-0x00000001833CA8C0 
		public bool IsValid { get; } // 0x00000001833C9B80-0x00000001833C9BF0 
		public abstract CameraState State { get; }
		public ICinemachineCamera ParentCamera { get; } // 0x00000001831FE360-0x00000001831FE3A0 
		public abstract Transform LookAt { get; set; }
		public abstract Transform Follow { get; set; }
		public virtual bool PreviousStateIsValid { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86F70-0x0000000184D86F80 0x0000000184D86F80-0x0000000184D86F90
		public bool FollowTargetChanged { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88020-0x0000000184D88030 0x0000000184D88040-0x0000000184D88050
		public bool LookAtTargetChanged { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88030-0x0000000184D88040 0x0000000184D88050-0x0000000184D88060
		public ICinemachineTargetGroup AbstractFollowTargetGroup { get; } // 0x0000000184D86260-0x0000000184D86270 
		public CinemachineVirtualCameraBase FollowTargetAsVcam { get; } // 0x0000000184D862A0-0x0000000184D862B0 
		public ICinemachineTargetGroup AbstractLookAtTargetGroup { get; } // 0x0000000184D85EE0-0x0000000184D85EF0 
		public CinemachineVirtualCameraBase LookAtTargetAsVcam { get; } // 0x0000000184D86220-0x0000000184D86230 
	
		// Nested types
		public enum StandbyUpdateMode // TypeDefIndex: 58113
		{
			Never = 0,
			Always = 1,
			RoundRobin = 2
		}
	
		public enum BlendHint // TypeDefIndex: 58114
		{
			None = 0,
			SphericalPosition = 1,
			CylindricalPosition = 2,
			ScreenSpaceAimWhenTargetsDiffer = 3
		}
	
		[Serializable]
		public struct TransitionParams // TypeDefIndex: 58115
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
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58116
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<CinemachineExtension, bool> __9__67_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001867B26C8-0x00000001867B272C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _RequiresUserInput_b__67_0(CinemachineExtension extension); // 0x00000001867B2670-0x00000001867B26C8
		}
	
		// Constructors
		protected CinemachineVirtualCameraBase(); // 0x0000000184220570-0x0000000184220600
	
		// Methods
		public virtual float GetMaxDampTime(); // 0x00000001867B02C4-0x00000001867B0360
		public float DetachedFollowTargetDamp(float initial, float dampTime, float deltaTime); // 0x00000001867AFF74-0x00000001867AFFCC
		public Vector3 DetachedFollowTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime); // 0x00000001831FA6A0-0x00000001831FA930
		public Vector3 DetachedFollowTargetDamp(Vector3 initial, float dampTime, float deltaTime); // 0x00000001867AFEF4-0x00000001867AFF74
		public float DetachedLookAtTargetDamp(float initial, float dampTime, float deltaTime); // 0x00000001831FAEE0-0x00000001831FAFE0
		public Vector3 DetachedLookAtTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime); // 0x00000001867AFFCC-0x00000001867B00BC
		public Vector3 DetachedLookAtTargetDamp(Vector3 initial, float dampTime, float deltaTime); // 0x00000001867B00BC-0x00000001867B013C
		public virtual void AddExtension(CinemachineExtension extension); // 0x0000000183FD9990-0x0000000183FD9A70
		public virtual void RemoveExtension(CinemachineExtension extension); // 0x00000001867B048C-0x00000001867B04E0
		protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime); // 0x00000001831FE0B0-0x00000001831FE360
		protected void InvokePrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState newState, float deltaTime); // 0x00000001831FC9B0-0x00000001831FCBF0
		protected bool InvokeOnTransitionInExtensions(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x0000000183E697F0-0x0000000183E69980
		protected void ApplyPositionBlendMethod(ref CameraState state, BlendHint hint); // 0x000000018391CE50-0x000000018391CE60
		public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0234BB66 */); // 0x00000001812081B0-0x0000000181208610
		public void UpdateCameraState(Vector3 worldUp, float deltaTime); // 0x00000001833C8190-0x00000001833C8210
		public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime);
		public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x0000000183E697B0-0x0000000183E697F0
		protected virtual void OnDestroy(); // 0x00000001867B0368-0x00000001867B03C0
		protected virtual void OnTransformParentChanged(); // 0x000000018413B830-0x000000018413B8D0
		protected virtual void Start(); // 0x0000000184D84E30-0x0000000184D84E40
		internal virtual bool RequiresUserInput(); // 0x00000001867B04E0-0x00000001867B05F8
		internal void EnsureStarted(); // 0x00000001867B013C-0x00000001867B01C0
		public AxisState.IInputAxisProvider GetInputAxisProvider(); // 0x00000001867B0238-0x00000001867B02C4
		protected virtual void OnValidate(); // 0x00000001867B0438-0x00000001867B048C
		protected virtual void OnEnable(); // 0x000000018413B650-0x000000018413B7B0
		protected virtual void OnDisable(); // 0x000000018413B600-0x000000018413B650
		protected virtual void Update(); // 0x00000001841190F0-0x0000000184119110
		private void UpdateSlaveStatus(); // 0x000000018413B970-0x000000018413BA30
		public Transform ResolveLookAt(Transform localLookAt); // 0x00000001831FD690-0x00000001831FD750
		public Transform ResolveFollow(Transform localFollow); // 0x00000001831FE3B0-0x00000001831FE460
		private void UpdateVcamPoolStatus(); // 0x000000018413BA30-0x000000018413BB40
		public void MoveToTopOfPrioritySubqueue(); // 0x00000001867B0360-0x00000001867B0368
		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001867B03C0-0x00000001867B0438
		public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x00000001867B01C0-0x00000001867B0238
		protected CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, CinemachineBlendDefinition blendDef, CinemachineBlend activeBlend); // 0x00000001867AFCBC-0x00000001867AFEF4
		protected CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens); // 0x000000018324BD00-0x000000018324BFC0
		private void InvalidateCachedTargets(); // 0x000000018413B7B0-0x000000018413B830
		protected void UpdateTargetCache(); // 0x00000001831FCBF0-0x00000001831FD040
		public object GetCinemachineComponent<T>();
	}

	internal class ConfinerOven // TypeDefIndex: 58123
	{
		// Fields
		private float m_MinFrustumHeightWithBones; // 0x10
		private List<List<IntPoint>> m_OriginalPolygon; // 0x18
		private List<List<IntPoint>> m_Skeleton; // 0x20
		private const long k_FloatToIntScaler = 100000; // Metadata: 0x0234BB6E
		private const float k_IntToFloatScaler = 1E-05f; // Metadata: 0x0234BB76
		private const float k_MinStepSize = 0.005f; // Metadata: 0x0234BB7A
		private Rect m_PolygonRect; // 0x28
		private AspectStretcher m_AspectStretcher; // 0x38
		private float m_maxComputationTimeForFullSkeletonBakeInSeconds; // 0x44
		[CompilerGenerated]
		private BakingState _State_k__BackingField; // 0x48
		public float m_BakeProgress; // 0x4C
		private BakingStateCache m_Cache; // 0x50
	
		// Properties
		public BakingState State { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D863D0-0x0000000184D863E0 0x0000000184D86450-0x0000000184D86460
	
		// Nested types
		public class BakedSolution // TypeDefIndex: 58118
		{
			// Fields
			[CompilerGenerated]
			private readonly float _FrustumHeight_k__BackingField; // 0x10
			private float m_frustumSizeIntSpace; // 0x14
			private readonly AspectStretcher m_AspectStretcher; // 0x18
			private readonly bool m_HasBones; // 0x24
			private readonly double m_SqrPolygonDiagonal; // 0x28
			private List<List<IntPoint>> m_OriginalPolygon; // 0x30
			public List<List<IntPoint>> m_Solution; // 0x38
	
			// Properties
			public float FrustumHeight { [CompilerGenerated] get; } // 0x0000000184D85F70-0x0000000184D85F80 
	
			// Constructors
			public BakedSolution(float aspectRatio, float frustumHeight, bool hasBones, Rect polygonBounds, List<List<IntPoint>> originalPolygon, List<List<IntPoint>> solution); // 0x00000001867AB2F0-0x00000001867AB3A4
	
			// Methods
			public bool IsValid(float frustumHeight); // 0x00000001867AB2C8-0x00000001867AB2F0
			public Vector2 ConfinePoint([IsReadOnly] in Vector2 pointToConfine); // 0x00000001867AA9A0-0x00000001867AAD74
			private bool IsInsideOriginal(IntPoint p); // 0x00000001867AB22C-0x00000001867AB2C8
			private static float ClosestPointOnSegment(IntPoint p, IntPoint s0, IntPoint s1); // 0x00000001867AA920-0x00000001867AA9A0
			private static IntPoint IntPointLerp(IntPoint a, IntPoint b, float lerp); // 0x00000001867AB198-0x00000001867AB22C
			private bool DoesIntersectOriginal(IntPoint l1, IntPoint l2); // 0x00000001867AAD74-0x00000001867AAF74
			private static int FindIntersection([IsReadOnly] in IntPoint p1, [IsReadOnly] in IntPoint p2, [IsReadOnly] in IntPoint p3, [IsReadOnly] in IntPoint p4); // 0x00000001867AAF74-0x00000001867AB198
			private static double IntPointDiffSqrMagnitude(IntPoint p1, IntPoint p2); // 0x0000000184D87F40-0x0000000184D87F70
		}
	
		private struct AspectStretcher // TypeDefIndex: 58119
		{
			// Fields
			[CompilerGenerated]
			private readonly float _Aspect_k__BackingField; // 0x00
			private readonly float m_InverseAspect; // 0x04
			private readonly float m_CenterX; // 0x08
	
			// Properties
			public float Aspect { [CompilerGenerated] [IsReadOnly] get; } // 0x0000000184D871D0-0x0000000184D871E0 
	
			// Constructors
			public AspectStretcher(float aspect, float centerX); // 0x0000000184D87ED0-0x0000000184D87EF0
	
			// Methods
			public Vector2 Stretch(Vector2 p); // 0x0000000184D87E70-0x0000000184D87EA0
			public Vector2 Unstretch(Vector2 p); // 0x0000000184D87EA0-0x0000000184D87ED0
		}
	
		private struct PolygonSolution // TypeDefIndex: 58120
		{
			// Fields
			public List<List<IntPoint>> m_Polygons; // 0x00
			public float m_FrustumHeight; // 0x08
	
			// Properties
			public bool IsEmpty { get; } // 0x000000018314CD60-0x000000018314CD70 
	
			// Methods
			public bool StateChanged([IsReadOnly] in List<List<IntPoint>> paths); // 0x00000001867B1998-0x00000001867B1A6C
		}
	
		public enum BakingState // TypeDefIndex: 58121
		{
			BAKING = 0,
			BAKED = 1,
			TIMEOUT = 2
		}
	
		private struct BakingStateCache // TypeDefIndex: 58122
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
		public ConfinerOven([IsReadOnly] in List<List<Vector2>> inputPath, [IsReadOnly] in float aspectRatio, float maxFrustumHeight); // 0x00000001867B1698-0x00000001867B1770
	
		// Methods
		public BakedSolution GetBakedSolution(float frustumHeight); // 0x00000001867B0D70-0x00000001867B0FF4
		private void Initialize([IsReadOnly] in List<List<Vector2>> inputPath, [IsReadOnly] in float aspectRatio, float maxFrustumHeight); // 0x00000001867B116C-0x00000001867B1698
		public void BakeConfiner(float maxComputationTimePerFrameInSeconds); // 0x00000001867B0624-0x00000001867B09E8
		private static Rect GetPolygonBoundingBox([IsReadOnly] in List<List<Vector2>> polygons); // 0x00000001867B0FF4-0x00000001867B116C
		private void ComputeSkeleton([IsReadOnly] in List<PolygonSolution> solutions); // 0x00000001867B09E8-0x00000001867B0D70
	}

	public interface ICinemachineCamera // TypeDefIndex: 58124
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
		bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0234BB81 */);
		void UpdateCameraState(Vector3 worldUp, float deltaTime);
		void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime);
	}

	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public struct LensSettings // TypeDefIndex: 58126
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
		public bool Orthographic { get; } // 0x0000000183249DB0-0x0000000183249DD0 
		public Vector2 SensorSize { get; } // 0x0000000184D88060-0x0000000184D88080 
		public float Aspect { get; } // 0x0000000183249D50-0x0000000183249DB0 
		public bool IsPhysicalCamera { get; } // 0x000000018324C270-0x000000018324C290 
	
		// Nested types
		public enum OverrideModes // TypeDefIndex: 58125
		{
			None = 0,
			Orthographic = 1,
			Perspective = 2,
			Physical = 3
		}
	
		// Constructors
		public LensSettings(float verticalFOV, float orthographicSize, float nearClip, float farClip, float dutch); // 0x0000000184CB6510-0x0000000184CB6560
		static LensSettings(); // 0x0000000184CB6470-0x0000000184CB6510
	
		// Methods
		public static LensSettings FromCamera(Camera fromCamera); // 0x000000018391D6D0-0x000000018391D850
		public void SnapshotCameraReadOnlyProperties(Camera camera); // 0x000000018324C290-0x000000018324C4E0
		public static LensSettings Lerp(LensSettings lensA, LensSettings lensB, float t); // 0x0000000183245990-0x0000000183245AF0
		public void Validate(); // 0x00000001867B192C-0x00000001867B1998
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineNoiseProfiles.html")]
	public sealed class NoiseSettings : SignalSourceAsset // TypeDefIndex: 58129
	{
		// Fields
		[FormerlySerializedAs("m_Position")]
		[Tooltip("These are the noise channels for the virtual camera\'s position. Convincing noise setups typically mix low, medium and high frequencies together, so start with a size of 3")]
		public TransformNoiseParams[] PositionNoise; // 0x18
		[FormerlySerializedAs("m_Orientation")]
		[Tooltip("These are the noise channels for the virtual camera\'s orientation. Convincing noise setups typically mix low, medium and high frequencies together, so start with a size of 3")]
		public TransformNoiseParams[] OrientationNoise; // 0x20
	
		// Properties
		public override float SignalDuration { get; } // 0x0000000184D879D0-0x0000000184D879E0 
	
		// Nested types
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct NoiseParams // TypeDefIndex: 58127
		{
			// Fields
			[Tooltip("The frequency of noise for this channel.  Higher magnitudes vibrate faster.")]
			public float Frequency; // 0x00
			[Tooltip("The amplitude of the noise for this channel.  Larger numbers vibrate higher.")]
			public float Amplitude; // 0x04
			[Tooltip("If checked, then the amplitude and frequency will not be randomized.")]
			public bool Constant; // 0x08
	
			// Methods
			public float GetValueAt(float time, float timeOffset); // 0x0000000183C01300-0x0000000183C01360
		}
	
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct TransformNoiseParams // TypeDefIndex: 58128
		{
			// Fields
			[Tooltip("Noise definition for X-axis")]
			public NoiseParams X; // 0x00
			[Tooltip("Noise definition for Y-axis")]
			public NoiseParams Y; // 0x0C
			[Tooltip("Noise definition for Z-axis")]
			public NoiseParams Z; // 0x18
	
			// Methods
			public Vector3 GetValueAt(float time, Vector3 timeOffsets); // 0x0000000183C01260-0x0000000183C01300
		}
	
		// Constructors
		public NoiseSettings(); // 0x0000000184955230-0x00000001849552A0
	
		// Methods
		public static Vector3 GetCombinedFilterResults(TransformNoiseParams[] noiseParams, float time, Vector3 timeOffsets); // 0x0000000183C01150-0x0000000183C01260
		public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot); // 0x0000000183C01010-0x0000000183C01150
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.Undoc)]
	public static class RuntimeUtility // TypeDefIndex: 58135
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
		public delegate int OverlapSphereNonAllocDelegate(Vector3 position, float radius, ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 58130; 0x00000001862248AC-0x00000001862248F8
	
		public delegate bool RaycastDelegate(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 58131; 0x0000000186221374-0x00000001862213C0
	
		public delegate int RaycastNonAllocDelegate(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 58132; 0x0000000186221374-0x00000001862213C0
	
		public delegate int SphereCastNonAllocDelegate(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 58133; 0x0000000186225970-0x00000001862259EC
	
		public delegate bool ComputePenetrationDelegate(ECSColliderResultProxy colliderA, Vector3 positionA, Quaternion rotationA, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance); // TypeDefIndex: 58134; 0x0000000186220F5C-0x0000000186221020
	
		// Constructors
		static RuntimeUtility(); // 0x000000018454DE60-0x000000018454E150
	
		// Methods
		public static void DestroyObject(UnityEngine.Object obj); // 0x00000001867B1CA4-0x00000001867B1D04
		public static bool IsPrefab(GameObject gameObject); // 0x00000001812081B0-0x0000000181208610
		public static bool RaycastIgnoreTag(Ray ray, out RaycastHit hitInfo, float rayLength, int layerMask, [IsReadOnly] in string ignoreTag); // 0x00000001832489A0-0x0000000183248D10
		public static int GetColliderOptionsFromHit(RaycastHit hit); // 0x00000001844C5210-0x00000001844C5260
		public static bool HasIgnoreColliderOptionFromHit(RaycastHit hit); // 0x00000001844C5150-0x00000001844C5210
		public static bool HasIgnoreColliderOptionFromCollider(ECSColliderResultProxy collider); // 0x00000001867B2100-0x00000001867B2170
		public static bool SphereCastIgnoreTag(Vector3 rayStart, float radius, Vector3 dir, out RaycastHit hitInfo, float rayLength, int layerMask, [IsReadOnly] in string ignoreTag); // 0x000000018324A310-0x000000018324A9D0
		internal static SphereCollider GetScratchCollider(); // 0x00000001867B1E78-0x00000001867B2100
		internal static void DestroyScratchCollider(); // 0x00000001867B1D04-0x00000001867B1E78
		public static AnimationCurve NormalizeCurve(AnimationCurve curve, bool normalizeX, bool normalizeY); // 0x00000001867B2170-0x00000001867B2390
	}

	public interface ISignalSource6D // TypeDefIndex: 58136
	{
		// Methods
		void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot);
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public abstract class SignalSourceAsset : ScriptableObject, ISignalSource6D // TypeDefIndex: 58137
	{
		// Properties
		public abstract float SignalDuration { get; }
	
		// Constructors
		protected SignalSourceAsset(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		public abstract void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot);
	}

	internal class TargetPositionCache // TypeDefIndex: 58144
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
		public static Mode CacheMode { get; } // 0x00000001867B2580-0x00000001867B25B8 
		public static bool HasCurrentTime { get; } // 0x00000001867B25B8-0x00000001867B25FC 
	
		// Nested types
		public enum Mode // TypeDefIndex: 58138
		{
			Disabled = 0,
			Record = 1,
			Playback = 2
		}
	
		private class CacheCurve // TypeDefIndex: 58140
		{
			// Fields
			public float StartTime; // 0x10
			public float StepSize; // 0x14
			private List<Item> m_Cache; // 0x18
	
			// Nested types
			public struct Item // TypeDefIndex: 58139
			{
				// Fields
				public Vector3 Pos; // 0x00
				public Quaternion Rot; // 0x0C
	
				// Properties
				public static Item Empty { get; } // 0x00000001867B1904-0x00000001867B192C 
	
				// Methods
				public static Item Lerp(Item a, Item b, float t); // 0x00000001867B17FC-0x00000001867B1904
			}
	
			// Methods
			public Item Evaluate(float time); // 0x00000001867AB550-0x00000001867AB6F0
		}
	
		private class CacheEntry // TypeDefIndex: 58142
		{
			// Fields
			public CacheCurve Curve; // 0x10
			private List<RecordingItem> RawItems; // 0x18
	
			// Nested types
			private struct RecordingItem // TypeDefIndex: 58141
			{
				// Fields
				public float Time; // 0x00
				public bool IsCut; // 0x04
				public CacheCurve.Item Item; // 0x08
			}
	
			// Constructors
			public CacheEntry(); // 0x00000001867AB988-0x00000001867ABA00
	
			// Methods
			public void AddRawItem(float time, bool isCut, Transform target); // 0x00000001867AB6F0-0x00000001867AB988
		}
	
		public struct TimeRange // TypeDefIndex: 58143
		{
			// Fields
			public float Start; // 0x00
			public float End; // 0x04
	
			// Properties
			public bool IsEmpty { get; } // 0x00000001867B2630-0x00000001867B263C 
			public static TimeRange Empty { get; } // 0x0000000184D880A0-0x0000000184D880C0 
	
			// Methods
			public bool Contains(float time); // 0x00000001867B25FC-0x00000001867B2610
			public void Include(float time); // 0x00000001867B2610-0x00000001867B2630
		}
	
		// Methods
		public static void ClearCache(); // 0x00000001867B2488-0x00000001867B2580
		public static Vector3 GetTargetPosition(Transform target); // 0x000000018324C1D0-0x000000018324C270
		public static Quaternion GetTargetRotation(Transform target); // 0x000000018324C110-0x000000018324C1D0
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.Undoc)]
	internal class UpdateTracker // TypeDefIndex: 58147
	{
		// Fields
		private static Dictionary<Transform, UpdateStatus> mUpdateStatus; // 0x00
		private static List<Transform> sToDelete; // 0x08
		private static float mLastUpdateTime; // 0x10
	
		// Nested types
		public enum UpdateClock // TypeDefIndex: 58145
		{
			Fixed = 0,
			Late = 1
		}
	
		private class UpdateStatus // TypeDefIndex: 58146
		{
			// Fields
			private int windowStart; // 0x10
			private int numWindowLateUpdateMoves; // 0x14
			private int numWindowFixedUpdateMoves; // 0x18
			private int numWindows; // 0x1C
			private int lastFrameUpdated; // 0x20
			private Matrix4x4 lastPos; // 0x24
			[CompilerGenerated]
			private UpdateClock _PreferredUpdate_k__BackingField; // 0x64
	
			// Properties
			public UpdateClock PreferredUpdate { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88110-0x0000000184D88120 0x0000000184D88120-0x0000000184D88130
	
			// Constructors
			public UpdateStatus(int currentFrame, Matrix4x4 pos); // 0x00000001867B87C0-0x00000001867B8810
	
			// Methods
			public void OnUpdate(int currentFrame, UpdateClock currentClock, Matrix4x4 pos); // 0x00000001867B86B0-0x00000001867B87C0
		}
	
		// Constructors
		static UpdateTracker(); // 0x0000000184CA3930-0x0000000184CA3A20
	
		// Methods
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule(); // 0x0000000184D34810-0x0000000184D34880
		private static void UpdateTargets(UpdateClock currentClock); // 0x00000001867B2A1C-0x00000001867B2CDC
		public static UpdateClock GetPreferredUpdate(Transform target); // 0x00000001867B2790-0x00000001867B2980
		public static void OnUpdate(UpdateClock currentClock); // 0x00000001867B2980-0x00000001867B2A1C
	}

	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineAlternativeInput.html")]
	public class CinemachineInputProvider : MonoBehaviour, AxisState.IInputAxisProvider // TypeDefIndex: 58149
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
		private const int NUM_AXES = 3; // Metadata: 0x0234BB8B
		private InputAction[] m_cachedActions; // 0x30
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 58148
		{
			// Fields
			public InputActionReference aRef; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _ResolveForPlayer_b__1(InputAction x); // 0x00000001867B8068-0x00000001867B80E4
		}
	
		// Constructors
		public CinemachineInputProvider(); // 0x00000001867B5E74-0x00000001867B5E94
	
		// Methods
		public virtual float GetAxisValue(int axis); // 0x00000001867B5934-0x00000001867B5A00
		protected InputAction ResolveForPlayer(int axis, InputActionReference actionRef); // 0x00000001867B5A14-0x00000001867B5D7C
		protected virtual void OnDisable(); // 0x00000001867B5A00-0x00000001867B5A14
		[CompilerGenerated]
		internal static InputAction _ResolveForPlayer_g__GetFirstMatch_7_0([IsReadOnly] in InputUser user, InputActionReference aRef); // 0x00000001867B5D7C-0x00000001867B5E74
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/api/Cinemachine.CinemachineTriggerAction.html")]
	[SaveDuringPlay]
	public class CinemachineTriggerAction : MonoBehaviour // TypeDefIndex: 58154
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
		public struct ActionSettings // TypeDefIndex: 58153
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
			public enum Mode // TypeDefIndex: 58150
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
			public class TriggerEvent : UnityEvent // TypeDefIndex: 58151
			{
				// Constructors
				public TriggerEvent(); // 0x0000000185393538-0x0000000185393540
			}
	
			public enum TimeMode // TypeDefIndex: 58152
			{
				FromStart = 0,
				FromEnd = 1,
				BeforeNow = 2,
				AfterNow = 3
			}
	
			// Constructors
			public ActionSettings(Mode action); // 0x00000001867B3140-0x00000001867B31C4
	
			// Methods
			public void Invoke(); // 0x00000001867B2CDC-0x00000001867B3140
		}
	
		// Constructors
		public CinemachineTriggerAction(); // 0x00000001867B6188-0x00000001867B62F8
	
		// Methods
		private bool Filter(GameObject other); // 0x00000001867B5E94-0x00000001867B5F24
		private void InternalDoTriggerEnter(GameObject other); // 0x00000001867B5F24-0x00000001867B5FB4
		private void InternalDoTriggerExit(GameObject other); // 0x00000001867B5FB4-0x00000001867B6050
		private void OnTriggerEnter(Collider other); // 0x00000001867B6120-0x00000001867B6154
		private void OnTriggerExit(Collider other); // 0x00000001867B6154-0x00000001867B6188
		private void OnCollisionEnter(UnityEngine.Collision other); // 0x00000001867B6084-0x00000001867B60B8
		private void OnCollisionExit(UnityEngine.Collision other); // 0x00000001867B60EC-0x00000001867B6120
		private void OnTriggerEnter2D(Collider2D other); // 0x00000001867B6120-0x00000001867B6154
		private void OnTriggerExit2D(Collider2D other); // 0x00000001867B6154-0x00000001867B6188
		private void OnCollisionEnter2D(Collision2D other); // 0x00000001867B6050-0x00000001867B6084
		private void OnCollisionExit2D(Collision2D other); // 0x00000001867B60B8-0x00000001867B60EC
		private void OnEnable(); // 0x00000001841E1670-0x00000001841E1680
	}

	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/api/Cinemachine.GroupWeightManipulator.html")]
	[RequireComponent(typeof(CinemachineTargetGroup))]
	public class GroupWeightManipulator : MonoBehaviour // TypeDefIndex: 58155
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
		public GroupWeightManipulator(); // 0x00000001867B6618-0x00000001867B6668
	
		// Methods
		private void Start(); // 0x00000001867B643C-0x00000001867B6484
		private void OnValidate(); // 0x00000001867B63D0-0x00000001867B643C
		private void Update(); // 0x00000001867B65B8-0x00000001867B6618
		private void UpdateWeights(); // 0x00000001867B6484-0x00000001867B65B8
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineCollisionImpulseSource.html")]
	[SaveDuringPlay]
	public class CinemachineCollisionImpulseSource : CinemachineImpulseSource // TypeDefIndex: 58156
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
		public CinemachineCollisionImpulseSource(); // 0x00000001867B3B78-0x00000001867B3BD4
	
		// Methods
		private void Start(); // 0x00000001867B3B08-0x00000001867B3B78
		private void OnEnable(); // 0x00000001841E1670-0x00000001841E1680
		private void OnCollisionEnter(UnityEngine.Collision c); // 0x00000001867B3A78-0x00000001867B3AB0
		private void OnTriggerEnter(Collider c); // 0x00000001867B3ADC-0x00000001867B3B08
		private float GetMassAndVelocity(Collider other, ref Vector3 vel); // 0x00000001867B37D0-0x00000001867B3A04
		private void GenerateImpactEvent(Collider other, Vector3 vel); // 0x00000001867B33B0-0x00000001867B359C
		private void OnCollisionEnter2D(Collision2D c); // 0x00000001867B3A04-0x00000001867B3A78
		private void OnTriggerEnter2D(Collider2D c); // 0x00000001867B3AB0-0x00000001867B3ADC
		private float GetMassAndVelocity2D(Collider2D other2d, ref Vector3 vel); // 0x00000001867B359C-0x00000001867B37D0
		private void GenerateImpactEvent2D(Collider2D other2d, Vector3 vel); // 0x00000001867B31C4-0x00000001867B33B0
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineImpulseFixedSignals.html")]
	public class CinemachineFixedSignal : SignalSourceAsset // TypeDefIndex: 58157
	{
		// Fields
		[Tooltip("The raw signal shape along the X axis")]
		public AnimationCurve m_XCurve; // 0x18
		[Tooltip("The raw signal shape along the Y axis")]
		public AnimationCurve m_YCurve; // 0x20
		[Tooltip("The raw signal shape along the Z axis")]
		public AnimationCurve m_ZCurve; // 0x28
	
		// Properties
		public override float SignalDuration { get; } // 0x0000000183DF0B90-0x0000000183DF0BF0 
	
		// Constructors
		public CinemachineFixedSignal(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		private float AxisDuration(AnimationCurve axis); // 0x0000000183DF0BF0-0x0000000183DF0C70
		public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot); // 0x00000001843F9E10-0x00000001843F9EB0
		private float AxisValue(AnimationCurve axis, float time); // 0x00000001843F9EB0-0x00000001843F9F00
	}

	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public class CinemachineImpulseDefinition // TypeDefIndex: 58163
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
		internal AnimationCurve ImpulseCurve { get; } // 0x00000001867B4EAC-0x00000001867B4F04 
	
		// Nested types
		public enum ImpulseShapes // TypeDefIndex: 58158
		{
			Custom = 0,
			Recoil = 1,
			Bump = 2,
			Explosion = 3,
			Rumble = 4
		}
	
		public enum ImpulseTypes // TypeDefIndex: 58159
		{
			Uniform = 0,
			Dissipating = 1,
			Propagating = 2,
			Legacy = 3
		}
	
		public enum RepeatMode // TypeDefIndex: 58160
		{
			Stretch = 0,
			Loop = 1
		}
	
		private class SignalSource : ISignalSource6D // TypeDefIndex: 58161
		{
			// Fields
			private CinemachineImpulseDefinition m_Def; // 0x10
			private Vector3 m_Velocity; // 0x18
	
			// Properties
			public float SignalDuration { get; } // 0x00000001867B70D8-0x00000001867B70F8 
	
			// Constructors
			public SignalSource(CinemachineImpulseDefinition def, Vector3 velocity); // 0x00000001867B70A8-0x00000001867B70D8
	
			// Methods
			public void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot); // 0x00000001867B6FD0-0x00000001867B70A8
		}
	
		private class LegacySignalSource : ISignalSource6D // TypeDefIndex: 58162
		{
			// Fields
			private CinemachineImpulseDefinition m_Def; // 0x10
			private Vector3 m_Velocity; // 0x18
			private float m_StartTimeOffset; // 0x24
	
			// Properties
			public float SignalDuration { get; } // 0x00000001833CD640-0x00000001833CD670 
	
			// Constructors
			public LegacySignalSource(CinemachineImpulseDefinition def, Vector3 velocity); // 0x00000001833CEB50-0x00000001833CEBD0
	
			// Methods
			public void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot); // 0x00000001833CD430-0x00000001833CD640
		}
	
		// Constructors
		public CinemachineImpulseDefinition(); // 0x000000018395F2B0-0x000000018395F380
	
		// Methods
		public void OnValidate(); // 0x00000001867B4DD4-0x00000001867B4EAC
		private static void CreateStandardShapes(); // 0x00000001867B41FC-0x00000001867B4D60
		internal static AnimationCurve GetStandardCurve(ImpulseShapes shape); // 0x00000001867B4D60-0x00000001867B4DD4
		public void CreateEvent(Vector3 position, Vector3 velocity); // 0x00000001867B41BC-0x00000001867B41FC
		public CinemachineImpulseManager.ImpulseEvent CreateAndReturnEvent(Vector3 position, Vector3 velocity); // 0x00000001833CDDB0-0x00000001833CDE20
		private CinemachineImpulseManager.ImpulseEvent LegacyCreateAndReturnEvent(Vector3 position, Vector3 velocity); // 0x00000001833CD670-0x00000001833CD8A0
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineImpulseListener.html")]
	[SaveDuringPlay]
	public class CinemachineImpulseListener : CinemachineExtension // TypeDefIndex: 58165
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
		public struct ImpulseReaction // TypeDefIndex: 58164
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
			public void ReSeed(); // 0x00000001867B6CE0-0x00000001867B6D64
			public bool GetReaction(float deltaTime, Vector3 impulsePos, out Vector3 pos, out Quaternion rot); // 0x0000000183E32D20-0x0000000183E32EB0
		}
	
		// Constructors
		public CinemachineImpulseListener(); // 0x00000001849C8F70-0x00000001849C8FA0
	
		// Methods
		private void Reset(); // 0x00000001867B4F04-0x00000001867B4F68
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x00000001831FE6C0-0x00000001831FE9B0
	}

	public sealed class CinemachineImpulseChannelPropertyAttribute : PropertyAttribute // TypeDefIndex: 58166
	{
		// Constructors
		public CinemachineImpulseChannelPropertyAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public class CinemachineImpulseManager // TypeDefIndex: 58171
	{
		// Fields
		private static CinemachineImpulseManager sInstance; // 0x00
		private List<ImpulseEvent> m_ExpiredEvents; // 0x10
		private List<ImpulseEvent> m_ActiveEvents; // 0x18
		public bool IgnoreTimeScale; // 0x20
	
		// Properties
		public static CinemachineImpulseManager Instance { get; } // 0x00000001833CD1B0-0x00000001833CD220 
		public float CurrentTime { get; } // 0x00000001833CD240-0x00000001833CD280 
	
		// Nested types
		[Serializable]
		public struct EnvelopeDefinition // TypeDefIndex: 58167
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
			public float Duration { get; } // 0x00000001833CD220-0x00000001833CD240 
	
			// Methods
			public static EnvelopeDefinition Default(); // 0x0000000184D880C0-0x0000000184D880E0
			public float GetValueAt(float offset); // 0x00000001833CD2B0-0x00000001833CD370
			public void ChangeStopTime(float offset, bool forceNoDecay); // 0x00000001867B6378-0x00000001867B63A4
			public void Clear(); // 0x00000001833CEB20-0x00000001833CEB50
			public void Validate(); // 0x00000001867B63A4-0x00000001867B63D0
		}
	
		public class ImpulseEvent // TypeDefIndex: 58170
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
			public bool Expired { get; } // 0x00000001833CD100-0x00000001833CD1B0 
	
			// Nested types
			public enum DirectionMode // TypeDefIndex: 58168
			{
				Fixed = 0,
				RotateTowardSource = 1
			}
	
			public enum DissipationMode // TypeDefIndex: 58169
			{
				LinearDecay = 0,
				SoftDecay = 1,
				ExponentialDecay = 2
			}
	
			// Constructors
			internal ImpulseEvent(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Cancel(float time, bool forceNoDecay); // 0x00000001867B6CC8-0x00000001867B6CE0
			public float DistanceDecay(float distance); // 0x00000001833CD280-0x00000001833CD2B0
			public bool GetDecayedSignal(Vector3 listenerPosition, bool use2D, out Vector3 pos, out Quaternion rot); // 0x00000001833CCC40-0x00000001833CCE90
			public void Clear(); // 0x00000001833CEAC0-0x00000001833CEB20
		}
	
		// Constructors
		private CinemachineImpulseManager(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule(); // 0x0000000184D75DC0-0x0000000184D75E00
		internal static float EvaluateDissipationScale(float spread, float normalizedDistance); // 0x00000001867B5008-0x00000001867B50A8
		public bool GetImpulseAt(Vector3 listenerLocation, bool distance2D, int channelMask, out Vector3 pos, out Quaternion rot); // 0x00000001833CCE90-0x00000001833CD100
		public ImpulseEvent NewImpulseEvent(); // 0x00000001833CDA50-0x00000001833CDAE0
		public void AddImpulseEvent(ImpulseEvent e); // 0x00000001833CDE20-0x00000001833CDEB0
		public void Clear(); // 0x00000001867B4F68-0x00000001867B5008
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineImpulseSourceOverview.html")]
	[SaveDuringPlay]
	public class CinemachineImpulseSource : MonoBehaviour // TypeDefIndex: 58172
	{
		// Fields
		public CinemachineImpulseDefinition m_ImpulseDefinition; // 0x18
		[Header("Default Invocation")]
		[Tooltip("The default direction and force of the Impulse Signal in the absense of any specified overrides.  Overrides can be specified by calling the appropriate GenerateImpulse method in the API.")]
		public Vector3 m_DefaultVelocity; // 0x20
	
		// Constructors
		public CinemachineImpulseSource(); // 0x00000001867B53B4-0x00000001867B543C
	
		// Methods
		private void OnValidate(); // 0x00000001867B52A0-0x00000001867B52C0
		private void Reset(); // 0x00000001867B52C0-0x00000001867B53B4
		public void GenerateImpulseAtPositionWithVelocity(Vector3 position, Vector3 velocity); // 0x00000001867B50A8-0x00000001867B50F4
		public void GenerateImpulseWithVelocity(Vector3 velocity); // 0x00000001867B51D4-0x00000001867B5248
		public void GenerateImpulseWithForce(float force); // 0x00000001867B5134-0x00000001867B51D4
		public void GenerateImpulse(); // 0x00000001867B5248-0x00000001867B5270
		public void GenerateImpulseAt(Vector3 position, Vector3 velocity); // 0x00000001867B50F4-0x00000001867B5134
		public void GenerateImpulse(Vector3 velocity); // 0x00000001867B5278-0x00000001867B52A0
		public void GenerateImpulse(float force); // 0x00000001867B5270-0x00000001867B5278
	}

	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/api/Cinemachine.CinemachineIndependentImpulseListener.html")]
	[SaveDuringPlay]
	public class CinemachineIndependentImpulseListener : MonoBehaviour // TypeDefIndex: 58173
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
		public CinemachineIndependentImpulseListener(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Reset(); // 0x00000001867B57A4-0x00000001867B5800
		private void OnEnable(); // 0x00000001867B5774-0x00000001867B57A4
		private void Update(); // 0x00000001867B5800-0x00000001867B5934
		private void LateUpdate(); // 0x00000001867B543C-0x00000001867B5774
	}
}

namespace Cinemachine.PostFX
{
	[AddComponentMenu("")]
	[SaveDuringPlay]
	public class CinemachinePostProcessing : CinemachineExtension // TypeDefIndex: 58174
	{
		// Constructors
		public CinemachinePostProcessing(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x00000001841E1670-0x00000001841E1680
	}

	[AddComponentMenu("")]
	public class CinemachineVolumeSettings : MonoBehaviour // TypeDefIndex: 58175
	{
		// Constructors
		public CinemachineVolumeSettings(); // 0x0000000185393520-0x0000000185393538
	}
}

namespace Cinemachine.Utility
{
	public class CinemachineDebug // TypeDefIndex: 58177
	{
		// Fields
		private static HashSet<UnityEngine.Object> mClients; // 0x00
		public static OnGUIDelegate OnGUIHandlers; // 0x08
		private static List<StringBuilder> mAvailableStringBuilders; // 0x10
	
		// Nested types
		public delegate void OnGUIDelegate(); // TypeDefIndex: 58176; 0x00000001853DEDB8-0x00000001853DEDC8
	
		// Methods
		public static void ReleaseScreenPos(UnityEngine.Object client); // 0x00000001867B3F4C-0x00000001867B3FE4
		public static Rect GetScreenPos(UnityEngine.Object client, string text, GUIStyle style); // 0x00000001867B3BD4-0x00000001867B3F4C
		public static StringBuilder SBFromPool(); // 0x00000001867B40C8-0x00000001867B41BC
		public static void ReturnToPool(StringBuilder sb); // 0x00000001867B3FE4-0x00000001867B40C8
	}

	public class PositionPredictor // TypeDefIndex: 58178
	{
		// Fields
		private Vector3 m_Velocity; // 0x10
		private Vector3 m_SmoothDampVelocity; // 0x1C
		private Vector3 m_Pos; // 0x28
		private bool m_HavePos; // 0x34
		public float Smoothing; // 0x38
	
		// Constructors
		public PositionPredictor(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void ApplyTransformDelta(Vector3 positionDelta); // 0x00000001867B6F14-0x00000001867B6F68
		public void Reset(); // 0x00000001867B6FA8-0x00000001867B6FD0
		public void AddPosition(Vector3 pos, float deltaTime, float lookaheadTime); // 0x00000001867B6D64-0x00000001867B6F14
		public Vector3 PredictPositionDelta(float lookaheadTime); // 0x00000001867B6F68-0x00000001867B6FA8
	}

	public static class Damper // TypeDefIndex: 58179
	{
		// Methods
		public static float Damp(float initial, float dampTime, float deltaTime); // 0x00000001831FBEF0-0x00000001831FBFA0
		public static Vector3 Damp(Vector3 initial, Vector3 dampTime, float deltaTime); // 0x00000001831FB600-0x00000001831FB740
		public static Vector3 Damp(Vector3 initial, float dampTime, float deltaTime); // 0x00000001867B62F8-0x00000001867B6378
	}

	public class HeadingTracker // TypeDefIndex: 58181
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
		public int FilterSize { get; } // 0x00000001867B6CAC-0x00000001867B6CC8 
	
		// Nested types
		private struct Item // TypeDefIndex: 58180
		{
			// Fields
			public Vector3 velocity; // 0x00
			public float weight; // 0x0C
			public float time; // 0x10
		}
	
		// Constructors
		public HeadingTracker(int filterSize); // 0x00000001867B6BD0-0x00000001867B6CAC
	
		// Methods
		private void ClearHistory(); // 0x00000001867B6824-0x00000001867B6844
		private static float Decay(float time); // 0x00000001867B6904-0x00000001867B6950
		public void Add(Vector3 velocity); // 0x00000001867B6668-0x00000001867B6824
		private void PopBottom(); // 0x00000001867B6A44-0x00000001867B6BD0
		public void DecayHistory(); // 0x00000001867B6844-0x00000001867B6904
		public Vector3 GetReliableHeading(); // 0x00000001867B6950-0x00000001867B6A44
	}

	public static class SplineHelpers // TypeDefIndex: 58182
	{
		// Methods
		public static Vector3 Bezier3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3); // 0x00000001867B7184-0x00000001867B7310
		public static Vector3 BezierTangent3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3); // 0x00000001867B7310-0x00000001867B7668
		public static float Bezier1(float t, float p0, float p1, float p2, float p3); // 0x00000001867B70F8-0x00000001867B7184
		public static void ComputeSmoothControlPoints(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2); // 0x00000001867B7924-0x00000001867B8068
		public static void ComputeSmoothControlPointsLooped(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2); // 0x00000001867B7668-0x00000001867B7924
	}

	public static class UnityVectorExtensions // TypeDefIndex: 58183
	{
		// Methods
		public static float Angle(Vector3 v1, Vector3 v2); // 0x0000000182F9FBB0-0x0000000182FA00A0
		public static float SignedAngle(Vector3 v1, Vector3 v2, Vector3 up); // 0x0000000183202070-0x0000000183202150
		public static Quaternion SafeFromToRotation(Vector3 v1, Vector3 v2, Vector3 up); // 0x00000001867B85C4-0x00000001867B86B0
	
		// Extension methods
		public static bool IsNaN(this Vector3 v); // 0x000000018364D1E0-0x000000018364D210
		public static float ClosestPointOnSegment(this Vector3 p, Vector3 s0, Vector3 s1); // 0x00000001867B848C-0x00000001867B856C
		public static float ClosestPointOnSegment(this Vector2 p, Vector2 s0, Vector2 s1); // 0x00000001867B83F4-0x00000001867B848C
		public static Vector3 ProjectOntoPlane(this Vector3 vector, Vector3 planeNormal); // 0x0000000183201FB0-0x0000000183202070
		public static Vector2 Abs(this Vector2 v); // 0x0000000184D880E0-0x0000000184D88110
		public static bool IsUniform(this Vector2 v); // 0x00000001867B856C-0x00000001867B85C4
		public static bool AlmostZero(this Vector3 v); // 0x0000000183201F90-0x0000000183201FB0
	}

	public static class UnityQuaternionExtensions // TypeDefIndex: 58184
	{
		// Methods
		public static Quaternion SlerpWithReferenceUp(Quaternion qA, Quaternion qB, float t, Vector3 up); // 0x00000001867B80E4-0x00000001867B83F4
	
		// Extension methods
		public static Quaternion Normalized(this Quaternion q); // 0x00000001831CC020-0x00000001831CC1A0
		public static Vector2 GetCameraRotationToTarget(this Quaternion orient, Vector3 lookAtDir, Vector3 worldUp); // 0x0000000183201980-0x0000000183201E20
		public static Quaternion ApplyCameraRotation(this Quaternion orient, Vector2 rot, Vector3 worldUp); // 0x0000000183200080-0x0000000183200190
	}
}
