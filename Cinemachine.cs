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

// Image 34: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 84500-84704

[AddComponentMenu("")]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/api/Cinemachine.CinemachineCameraOffset.html")]
[SaveDuringPlay]
public class CinemachineCameraOffset : CinemachineExtension // TypeDefIndex: 84501
{
	// Fields
	[Tooltip("Offset the camera\'s position by this much (camera space)")]
	public Vector3 m_Offset; // 0x28
	[Tooltip("When to apply the offset")]
	public CinemachineCore.Stage m_ApplyAfter; // 0x34
	[Tooltip("If applying offset after aim, re-adjust the aim to preserve the screen position of the LookAt target as much as possible")]
	public bool m_PreserveComposition; // 0x38

	// Constructors
	public CinemachineCameraOffset(); // 0x0000000186C6D200-0x0000000186C6D230

	// Methods
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x0000000186639F90-0x000000018663A110
}

[AddComponentMenu("")]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineRecomposer.html")]
[SaveDuringPlay]
public class CinemachineRecomposer : CinemachineExtension // TypeDefIndex: 84502
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
	public CinemachineRecomposer(); // 0x00000001878364A0-0x00000001878364B8

	// Methods
	private void Reset(); // 0x00000001872349E0-0x0000000187234A10
	private void OnValidate(); // 0x0000000188A865F8-0x0000000188A86634
	public override void PrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState curState, float deltaTime); // 0x0000000186289670-0x00000001862896A0
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x000000018560AC90-0x000000018560AEE0
}

public static class CinemachineBeyondCommunicator // TypeDefIndex: 84503
{
	// Fields
	[CompilerGenerated]
	private static Func<CinemachineVirtualCameraBase> _GetLevelCamera_k__BackingField; // 0x00

	// Properties
	public static Func<CinemachineVirtualCameraBase> GetLevelCamera { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000188A7839C-0x0000000188A783D4 0x0000000188A783D4-0x0000000188A78424
}

public class CinemachineTouchInputMapper : MonoBehaviour // TypeDefIndex: 84504
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
	public CinemachineTouchInputMapper(); // 0x0000000188A86CAC-0x0000000188A86D20

	// Methods
	private void Start(); // 0x0000000188A86BFC-0x0000000188A86CAC
	private float GetInputAxis(string axisName); // 0x0000000188A86B5C-0x0000000188A86BFC
}

internal sealed class CinemachineMixer : PlayableBehaviour // TypeDefIndex: 84505
{
	// Fields
	private CinemachineBrain mBrain; // 0x10
	private int mBrainOverrideId; // 0x18
	private bool mPreviewPlay; // 0x1C

	// Constructors
	public CinemachineMixer(); // 0x0000000187234900-0x0000000187234910

	// Methods
	public override void OnPlayableDestroy(Playable playable); // 0x0000000188A84E00-0x0000000188A84E78
	public override void PrepareFrame(Playable playable, FrameData info); // 0x00000001872348F0-0x0000000187234900
	public override void ProcessFrame(Playable playable, FrameData info, object playerData); // 0x0000000188A84E78-0x0000000188A8549C
	private float GetDeltaTime(float deltaTime); // 0x0000000188A84DB0-0x0000000188A84E00
}

public sealed class CinemachineShot : PlayableAsset, IPropertyPreview, ITimelineClipAsset // TypeDefIndex: 84506
{
	// Fields
	[SerializeField]
	public bool DisableEvaluateTwiceWhenEnabled; // 0x18
	public bool UseVcamBeforeTimeline; // 0x19
	public bool UseLevelCamera; // 0x1A
	public string DisplayName; // 0x20
	public ExposedReference<CinemachineVirtualCameraBase> VirtualCamera; // 0x28

	// Properties
	public ClipCaps clipCaps { get; } // 0x0000000188A86B48-0x0000000188A86B5C 

	// Constructors
	public CinemachineShot(); // 0x0000000185DD6260-0x0000000185DD6270

	// Methods
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x0000000188A86684-0x0000000188A869AC
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver); // 0x0000000188A869AC-0x0000000188A86B48
}

internal sealed class CinemachineShotPlayable : PlayableBehaviour // TypeDefIndex: 84507
{
	// Fields
	public CinemachineVirtualCameraBase VirtualCamera; // 0x10

	// Properties
	public bool IsValid { get; } // 0x0000000188A86634-0x0000000188A86684 

	// Constructors
	public CinemachineShotPlayable(); // 0x0000000186805BA0-0x0000000186805BB0
}

[Serializable]
[DontAutoBind]
[SupportsChildTracks(null, 2147483647)]
[TrackBindingType(typeof(CinemachineBrain), TrackBindingFlags.None)]
[TrackClipType(typeof(CinemachineShot))]
[TrackColor(0.53f, 0f, 0.08f)]
public class CinemachineTrack : TrackAsset // TypeDefIndex: 84508
{
	// Constructors
	public CinemachineTrack(); // 0x0000000188A86E00-0x0000000188A86E4C

	// Methods
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount); // 0x0000000188A86D20-0x0000000188A86E00
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 84704
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_12 AA5072B96927F710758B3E5237A84AC68E397BC4E1BF7E864A950696D743CC32; // 0x00 // Static value (base64): AAAAP83MDD+amRk/ - Metadata: 0x02644678

	// Nested types
	private struct __StaticArrayInitTypeSize_12 // TypeDefIndex: 84703
	{
	}
}

namespace Cinemachine
{
	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[SaveDuringPlay]
	public class Cinemachine3rdPersonAim : CinemachineExtension // TypeDefIndex: 84509
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
		private Vector3 AimTarget { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187234550-0x0000000187234570 0x0000000187234570-0x0000000187234580
	
		// Constructors
		public Cinemachine3rdPersonAim(); // 0x0000000188A78348-0x0000000188A7839C
	
		// Methods
		private void OnValidate(); // 0x0000000188A780AC-0x0000000188A780C4
		private void Reset(); // 0x0000000188A782E0-0x0000000188A78348
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x0000000188A77F80-0x0000000188A780AC
		private void DrawReticle(CinemachineBrain brain); // 0x0000000188A77DC4-0x0000000188A77F80
		private Vector3 ComputeLookAtPoint(Vector3 camPos, Transform player); // 0x0000000188A77AC0-0x0000000188A77DC4
		private Vector3 ComputeAimTarget(Vector3 cameraLookAt, Transform player); // 0x0000000188A77930-0x0000000188A77AC0
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x0000000188A780C4-0x0000000188A782E0
	}

	[AddComponentMenu("Cinemachine/CinemachineBlendListCamera")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExcludeFromPreset]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineBlendListCamera.html")]
	public class CinemachineBlendListCamera : CinemachineVirtualCameraBase // TypeDefIndex: 84511
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
		private float mActivationTime; // 0x220
		private int mCurrentInstruction; // 0x224
		private CinemachineBlend mActiveBlend; // 0x228
	
		// Properties
		public override string Description { get; } // 0x0000000188A798F4-0x0000000188A799E0 
		public ICinemachineCamera LiveChild { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187234580-0x0000000187234590 0x0000000188A79A0C-0x0000000188A79A20
		public override CameraState State { get; } // 0x0000000187234590-0x0000000187234630 
		public override Transform LookAt { get; set; } // 0x0000000188A799FC-0x0000000188A79A0C 0x0000000185017110-0x0000000185017130
		public override Transform Follow { get; set; } // 0x0000000188A799E0-0x0000000188A799F0 0x0000000185017130-0x0000000185017150
		public CinemachineVirtualCameraBase[] ChildCameras { get; } // 0x0000000188A798D4-0x0000000188A798F4 
		public bool IsBlending { get; } // 0x0000000188A799F0-0x0000000188A799FC 
	
		// Nested types
		[Serializable]
		public struct Instruction // TypeDefIndex: 84510
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
		public CinemachineBlendListCamera(); // 0x0000000188A7977C-0x0000000188A798D4
	
		// Methods
		private void Reset(); // 0x0000000188A793EC-0x0000000188A79450
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x02644594 */); // 0x0000000188A78D5C-0x0000000188A78D84
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x0000000188A791EC-0x0000000188A792AC
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x0000000188A78628-0x0000000188A78708
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x0000000188A792B4-0x0000000188A793EC
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x0000000188A78708-0x0000000188A78D28
		protected override void OnEnable(); // 0x0000000188A78E9C-0x0000000188A790A8
		protected override void OnDisable(); // 0x0000000188A78D84-0x0000000188A78E9C
		private void OnTransformChildrenChanged(); // 0x0000000188A792AC-0x0000000188A792B4
		private void OnGuiHandler(); // 0x0000000188A790A8-0x0000000188A791EC
		private void InvalidateListOfChildren(); // 0x0000000188A78D28-0x0000000188A78D5C
		private void UpdateListOfChildren(); // 0x0000000188A79450-0x0000000188A795F0
		internal void ValidateInstructions(); // 0x0000000188A795F0-0x0000000188A7977C
		private void AdvanceCurrentInstruction(float deltaTime); // 0x0000000188A78424-0x0000000188A78628
	}

	[AddComponentMenu("Cinemachine/CinemachineBrain")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineBrainProperties.html")]
	[SaveDuringPlay]
	public class CinemachineBrain : MonoBehaviour // TypeDefIndex: 84518
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
		public Camera OutputCamera { get; } // 0x0000000185605840-0x00000001856058D0 
		public HGDepthOfField OutputDOF { get; } // 0x0000000185609170-0x0000000185609200 
		public static ICinemachineCamera SoloCamera { get; set; } // 0x0000000188A7A460-0x0000000188A7A494 0x0000000188A7A51C-0x0000000188A7A60C
		public Vector3 DefaultWorldUp { get; } // 0x0000000185605D80-0x0000000185605E30 
		public ICinemachineCamera ActiveVirtualCamera { get; } // 0x0000000185606EA0-0x0000000185606F90 
		public bool IsBlending { get; } // 0x0000000185607820-0x00000001856078E0 
		public CinemachineBlend ActiveBlend { get; } // 0x0000000185606CC0-0x0000000185606D70 
		public CameraState CurrentCameraState { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187234630-0x00000001872346D0 0x0000000188A7A494-0x0000000188A7A51C
	
		// Nested types
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum UpdateMethod // TypeDefIndex: 84512
		{
			FixedUpdate = 0,
			LateUpdate = 1,
			SmartUpdate = 2,
			ManualUpdate = 3
		}
	
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum BrainUpdateMethod // TypeDefIndex: 84513
		{
			FixedUpdate = 0,
			LateUpdate = 1
		}
	
		[Serializable]
		public class BrainEvent : UnityEvent<CinemachineBrain> // TypeDefIndex: 84514
		{
			// Constructors
			public BrainEvent(); // 0x0000000185518820-0x0000000185518860
		}
	
		[Serializable]
		public class VcamActivatedEvent : UnityEvent<ICinemachineCamera, ICinemachineCamera> // TypeDefIndex: 84515
		{
			// Constructors
			public VcamActivatedEvent(); // 0x0000000185518610-0x0000000185518620
		}
	
		private class BrainFrame // TypeDefIndex: 84516
		{
			// Fields
			public int id; // 0x10
			public CinemachineBlend blend; // 0x18
			public CinemachineBlend workingBlend; // 0x20
			public BlendSourceVirtualCamera workingBlendSource; // 0x28
			public float deltaTimeOverride; // 0x30
	
			// Properties
			public bool Active { get; } // 0x0000000188A77910-0x0000000188A77930 
	
			// Constructors
			public BrainFrame(); // 0x0000000185518860-0x0000000185518980
		}
	
		[CompilerGenerated]
		private sealed class _AfterPhysics_d__36 : IEnumerator<object> // TypeDefIndex: 84517
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public CinemachineBrain __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _AfterPhysics_d__36(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000185F85270-0x0000000185F853C0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000188A8794C-0x0000000188A87998
		}
	
		// Constructors
		public CinemachineBrain(); // 0x0000000185518410-0x0000000185518610
		static CinemachineBrain(); // 0x00000001871D42C0-0x00000001871D4330
	
		// Methods
		public static UnityEngine.Color GetSoloGUIColor(); // 0x0000000188A79B2C-0x0000000188A79B88
		private void OnEnable(); // 0x00000001861B2810-0x00000001861B2BD0
		private void OnDisable(); // 0x0000000188A79C50-0x0000000188A79E80
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode); // 0x0000000188A7A144-0x0000000188A7A1A8
		private void OnSceneUnloaded(Scene scene); // 0x0000000187220A30-0x0000000187220A70
		private void Start(); // 0x000000018722DB20-0x000000018722DB40
		private void OnGuiHandler(); // 0x0000000188A79E80-0x0000000188A7A144
		[IteratorStateMachine(typeof(_AfterPhysics_d__36))]
		private IEnumerator AfterPhysics(); // 0x00000001861B2BD0-0x00000001861B2C30
		private void LateUpdate(); // 0x0000000186437210-0x0000000186437230
		public void ManualUpdate(float deltaTime = -1f /* Metadata: 0x02644595 */); // 0x0000000185607F30-0x0000000185608080
		private float GetEffectiveDeltaTime(bool fixedDelta); // 0x0000000185609800-0x00000001856098B0
		private void UpdateVirtualCameras(CinemachineCore.UpdateFilter updateFilter, float deltaTime); // 0x00000001856058D0-0x0000000185605C90
		private static ICinemachineCamera DeepCamBFromBlend(CinemachineBlend blend); // 0x0000000185606F90-0x00000001856070B0
		public bool IsLiveInBlend(ICinemachineCamera vcam); // 0x0000000188A79B88-0x0000000188A79C50
		private int GetBrainFrame(int withId); // 0x0000000188A79A20-0x0000000188A79B2C
		public int SetCameraOverride(int overrideId, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime); // 0x0000000188A7A260-0x0000000188A7A460
		public void ReleaseCameraOverride(int overrideId); // 0x0000000188A7A1A8-0x0000000188A7A260
		private void ProcessActiveCamera(float deltaTime); // 0x00000001856078E0-0x0000000185607EA0
		private void UpdateFrame0(float deltaTime); // 0x0000000185608080-0x00000001856084A0
		public void ComputeCurrentBlend(ref CinemachineBlend outputBlend, int numTopLayersToExclude); // 0x00000001856084A0-0x00000001856087D0
		public bool IsLive(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x02644599 */); // 0x0000000185606D70-0x0000000185606EA0
		public ICinemachineCamera TopCameraFromPriorityQueue(); // 0x0000000185605390-0x0000000185605840
		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey); // 0x0000000185228880-0x0000000185228BE0
		private void PushStateToUnityCamera(ref CameraState state); // 0x0000000185608830-0x0000000185609170
	}

	[AddComponentMenu("Cinemachine/CinemachineClearShot")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExcludeFromPreset]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineClearShot.html")]
	public class CinemachineClearShot : CinemachineVirtualCameraBase // TypeDefIndex: 84521
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
		private float mActivationTime; // 0x240
		private float mPendingActivationTime; // 0x244
		private ICinemachineCamera mPendingCamera; // 0x248
		private CinemachineBlend mActiveBlend; // 0x250
		private bool mRandomizeNow; // 0x258
		private CinemachineVirtualCameraBase[] m_RandomizedChilden; // 0x260
		private ICinemachineCamera m_TransitioningFrom; // 0x268
	
		// Properties
		public override string Description { get; } // 0x0000000188A7C194-0x0000000188A7C280 
		public ICinemachineCamera LiveChild { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872346D0-0x00000001872346E0 0x0000000188A7C28C-0x0000000188A7C2A0
		public override CameraState State { get; } // 0x00000001872346E0-0x0000000187234780 
		public override Transform LookAt { get; set; } // 0x0000000188A799FC-0x0000000188A79A0C 0x0000000185017110-0x0000000185017130
		public override Transform Follow { get; set; } // 0x0000000188A799E0-0x0000000188A799F0 0x0000000185017130-0x0000000185017150
		public bool IsBlending { get; } // 0x0000000188A7C280-0x0000000188A7C28C 
		public CinemachineVirtualCameraBase[] ChildCameras { get; } // 0x0000000188A7C174-0x0000000188A7C194 
	
		// Nested types
		private struct Pair // TypeDefIndex: 84519
		{
			// Fields
			public int a; // 0x00
			public float b; // 0x04
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 84520
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<Pair> __9__47_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000188A87998-0x0000000188A87B04
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _Randomize_b__47_0(Pair p1, Pair p2); // 0x0000000187234A20-0x0000000187234A40
		}
	
		// Constructors
		public CinemachineClearShot(); // 0x0000000188A7BFDC-0x0000000188A7C174
	
		// Methods
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x026445A0 */); // 0x0000000188A7B354-0x0000000188A7B37C
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x0000000188A7B9A8-0x0000000188A7BA68
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x0000000188A7AD08-0x0000000188A7ADE8
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x0000000188A7ADE8-0x0000000188A7B30C
		protected override void OnEnable(); // 0x0000000188A7B670-0x0000000188A7B864
		protected override void OnDisable(); // 0x0000000188A7B558-0x0000000188A7B670
		public void OnTransformChildrenChanged(); // 0x0000000188A7BA68-0x0000000188A7BA88
		private void OnGuiHandler(); // 0x0000000188A7B864-0x0000000188A7B9A8
		private void InvalidateListOfChildren(); // 0x0000000188A7B30C-0x0000000188A7B354
		public void ResetRandomization(); // 0x0000000188A7BDD4-0x0000000188A7BE00
		private void UpdateListOfChildren(); // 0x0000000188A7BE00-0x0000000188A7BFDC
		private ICinemachineCamera ChooseCurrentCamera(Vector3 worldUp); // 0x0000000188A7A60C-0x0000000188A7AD08
		private CinemachineVirtualCameraBase[] Randomize(CinemachineVirtualCameraBase[] src); // 0x0000000188A7BB8C-0x0000000188A7BDD4
		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey); // 0x0000000188A7B37C-0x0000000188A7B558
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x0000000188A7BA88-0x0000000188A7BB8C
	}

	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineCollider.html")]
	[SaveDuringPlay]
	public class CinemachineCollider : CinemachineExtension // TypeDefIndex: 84524
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
		private const float k_PrecisionSlush = 0.001f; // Metadata: 0x026445A1
		private RaycastHit[] m_CornerBuffer; // 0x70
		private const float k_AngleThreshold = 0.1f; // Metadata: 0x026445A5
		private static ECSColliderResultProxy[] s_ColliderBuffer; // 0x00
	
		// Properties
		public List<List<Vector3>> DebugPaths { get; } // 0x0000000188A7E4D0-0x0000000188A7E6AC 
	
		// Nested types
		public enum ResolutionStrategy // TypeDefIndex: 84522
		{
			PullCameraForward = 0,
			PreserveCameraHeight = 1,
			PreserveCameraDistance = 2
		}
	
		private class VcamExtraState // TypeDefIndex: 84523
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
			public VcamExtraState(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void AddPointToDebugPath(Vector3 p); // 0x0000000186805BA0-0x0000000186805BB0
			public float ApplyDistanceSmoothing(float distance, float smoothingTime); // 0x0000000185602570-0x00000001856025F0
			public void UpdateDistanceSmoothing(float distance); // 0x00000001856024F0-0x0000000185602570
			public void ResetDistanceSmoothing(float smoothingTime); // 0x0000000185602BE0-0x0000000185602C30
		}
	
		// Constructors
		public CinemachineCollider(); // 0x0000000186C6D230-0x0000000186C6D300
		static CinemachineCollider(); // 0x00000001871DBD60-0x00000001871DBDD0
	
		// Methods
		public bool IsTargetObscured(ICinemachineCamera vcam); // 0x0000000188A7D10C-0x0000000188A7D164
		public bool CameraWasDisplaced(ICinemachineCamera vcam); // 0x0000000188A7C2A0-0x0000000188A7C2BC
		public float GetCameraDisplacementDistance(ICinemachineCamera vcam); // 0x0000000188A7C828-0x0000000188A7C884
		private void OnValidate(); // 0x0000000188A7D1AC-0x0000000188A7D1F8
		protected override void OnDestroy(); // 0x0000000188A7D164-0x0000000188A7D1AC
		public override float GetMaxDampTime(); // 0x0000000188A7C884-0x0000000188A7C89C
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x000000018522FA10-0x000000018522FAE0
		public void ResetExtraData(ICinemachineCamera vcam); // 0x0000000188A7D950-0x0000000188A7D9F8
		public virtual void GuardedPostPipelineStageCallback(ICinemachineCamera vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x000000018522FAE0-0x0000000185230B30
		private Vector3 PreserveLineOfSight(ref CameraState state, ref VcamExtraState extra); // 0x0000000184FB2070-0x0000000184FB2600
		private Vector3 PullCameraInFrontOfNearestObstacle(Vector3 cameraPos, Vector3 lookAtPos, int layerMask, ref RaycastHit hitInfo); // 0x0000000184FB2600-0x0000000184FB2970
		private Vector3 PushCameraBack(Vector3 currentPos, Vector3 pushDir, RaycastHit obstacle, Vector3 lookAtPos, Plane startPlane, float targetDistance, int iterations, ref VcamExtraState extra); // 0x0000000188A7D1F8-0x0000000188A7D950
		private bool GetWalkingDirection(Vector3 pos, Vector3 pushDir, RaycastHit obstacle, ref Vector3 outDir); // 0x0000000188A7CA04-0x0000000188A7D10C
		private float GetPushBackDistance(Ray ray, Plane startPlane, float targetDistance, Vector3 lookAtPos); // 0x0000000188A7C89C-0x0000000188A7CA04
		private static float ClampRayToBounds(Ray ray, float distance, Bounds bounds); // 0x0000000188A7C2BC-0x0000000188A7C828
		private Vector3 RespectCameraRadius(Vector3 cameraPos, Vector3 lookAtPos); // 0x0000000188A7D9F8-0x0000000188A7E4D0
		private bool CheckForTargetObstructions([IsReadOnly] in CameraState state); // 0x0000000184FB38F0-0x0000000184FB3E10
		private static bool IsTargetOffscreen([IsReadOnly] in CameraState state); // 0x0000000184FB1560-0x0000000184FB1BE0
	}

	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineConfiner.html")]
	[SaveDuringPlay]
	public class CinemachineConfiner : CinemachineExtension // TypeDefIndex: 84527
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
		public bool IsValid { get; } // 0x0000000188A80020-0x0000000188A80120 
	
		// Nested types
		public enum Mode // TypeDefIndex: 84525
		{
			Confine2D = 0,
			Confine3D = 1
		}
	
		private class VcamExtraState // TypeDefIndex: 84526
		{
			// Fields
			public Vector3 m_previousDisplacement; // 0x10
			public float confinerDisplacement; // 0x1C
	
			// Constructors
			public VcamExtraState(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public CinemachineConfiner(); // 0x0000000188A80004-0x0000000188A80020
	
		// Methods
		public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam); // 0x0000000188A7ED08-0x0000000188A7ED24
		public float GetCameraDisplacementDistance(CinemachineVirtualCameraBase vcam); // 0x0000000188A7F7E4-0x0000000188A7F840
		private void OnValidate(); // 0x0000000188A7F868-0x0000000188A7F878
		protected override void ConnectToVcam(bool connect); // 0x0000000188A7F7DC-0x0000000188A7F7E4
		public override float GetMaxDampTime(); // 0x0000000187234790-0x00000001872347A0
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x0000000188A7F878-0x0000000188A7FB14
		public void InvalidatePathCache(); // 0x0000000188A7F840-0x0000000188A7F868
		private bool ValidatePathCache(); // 0x0000000188A7FB14-0x0000000188A80004
		private Vector3 ConfinePoint(Vector3 camPos); // 0x0000000188A7ED24-0x0000000188A7F198
		private Vector3 ConfineScreenEdges(CinemachineVirtualCameraBase vcam, ref CameraState state); // 0x0000000188A7F198-0x0000000188A7F7DC
	}

	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineConfiner2D.html")]
	[SaveDuringPlay]
	public class CinemachineConfiner2D : CinemachineExtension // TypeDefIndex: 84530
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
		private const float k_cornerAngleTreshold = 10f; // Metadata: 0x026445AE
		private ShapeCache m_shapeCache; // 0x40
	
		// Nested types
		private class VcamExtraState // TypeDefIndex: 84528
		{
			// Fields
			public Vector3 m_PreviousDisplacement; // 0x10
			public Vector3 m_DampedDisplacement; // 0x1C
			public ConfinerOven.BakedSolution m_BakedSolution; // 0x28
			public CinemachineVirtualCameraBase m_vcam; // 0x30
	
			// Constructors
			public VcamExtraState(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private struct ShapeCache // TypeDefIndex: 84529
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
			public void Invalidate(); // 0x0000000188A87150-0x0000000188A871F0
			public bool ValidateCache(Collider2D boundingShape2D, float maxWindowSize, float aspectRatio, out bool confinerStateChanged); // 0x0000000188A87308-0x0000000188A8794C
			private bool IsValid([IsReadOnly] in Collider2D boundingShape2D, [IsReadOnly] in float aspectRatio, [IsReadOnly] in float maxOrthoSize); // 0x0000000188A871F0-0x0000000188A87308
			private void CalculateDeltaTransformationMatrix(); // 0x0000000188A86F68-0x0000000188A87150
		}
	
		// Constructors
		public CinemachineConfiner2D(); // 0x0000000188A7ECEC-0x0000000188A7ED08
	
		// Methods
		public void InvalidateCache(); // 0x0000000188A7E748-0x0000000188A7E754
		public bool ValidateCache(float cameraAspectRatio); // 0x0000000188A7ECB0-0x0000000188A7ECEC
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x0000000188A7E770-0x0000000188A7ECB0
		private float CalculateHalfFrustumHeight([IsReadOnly] in CameraState state, [IsReadOnly] in float cameraPosLocalZ); // 0x0000000188A7E6AC-0x0000000188A7E748
		private void OnValidate(); // 0x0000000188A7E754-0x0000000188A7E770
		private void Reset(); // 0x0000000187234780-0x0000000187234790
	}

	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineDollyCart.html")]
	public class CinemachineDollyCart : MonoBehaviour // TypeDefIndex: 84532
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
		public enum UpdateMethod // TypeDefIndex: 84531
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2
		}
	
		// Constructors
		public CinemachineDollyCart(); // 0x0000000188A80380-0x0000000188A8039C
	
		// Methods
		private void FixedUpdate(); // 0x0000000188A80120-0x0000000188A80170
		private void Update(); // 0x0000000188A80320-0x0000000188A80380
		private void LateUpdate(); // 0x0000000188A80170-0x0000000188A801D4
		private void SetCartPosition(float distanceAlongPath); // 0x0000000188A801D4-0x0000000188A80320
	}

	[AddComponentMenu("Cinemachine/CinemachineExternalCamera")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineExternalCamera.html")]
	[RequireComponent(typeof(Camera))]
	public class CinemachineExternalCamera : CinemachineVirtualCameraBase // TypeDefIndex: 84533
	{
		// Fields
		[NoSaveDuringPlay]
		[Tooltip("The object that the camera is looking at.  Setting this will improve the quality of the blends to and from this camera")]
		[VcamTargetProperty]
		public Transform m_LookAt; // 0xA8
		private Camera m_Camera; // 0xB0
		private CameraState m_State; // 0xB8
		[CompilerGenerated]
		private Transform _Follow_k__BackingField; // 0x1F8
		[FormerlySerializedAs("m_PositionBlending")]
		[Tooltip("Hint for blending positions to and from this virtual camera")]
		public BlendHint m_BlendHint; // 0x200
	
		// Properties
		public override CameraState State { get; } // 0x00000001872347B0-0x0000000187234850 
		public override Transform LookAt { get; set; } // 0x0000000187232FB0-0x0000000187232FC0 0x000000018722E870-0x000000018722E890
		public override Transform Follow { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872347A0-0x00000001872347B0 0x000000018722E890-0x000000018722E8B0
	
		// Constructors
		public CinemachineExternalCamera(); // 0x00000001864CDA80-0x00000001864CDC00
	
		// Methods
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x0000000188A8039C-0x0000000188A80974
	}

	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineFollowZoom.html")]
	[SaveDuringPlay]
	public class CinemachineFollowZoom : CinemachineExtension // TypeDefIndex: 84535
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
		private class VcamExtraState // TypeDefIndex: 84534
		{
			// Fields
			public float m_previousFrameZoom; // 0x10
	
			// Constructors
			public VcamExtraState(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public CinemachineFollowZoom(); // 0x0000000188A80C94-0x0000000188A80CC8
	
		// Methods
		private void OnValidate(); // 0x0000000188A80974-0x0000000188A809D0
		public override float GetMaxDampTime(); // 0x0000000187233330-0x0000000187233340
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x0000000188A809D0-0x0000000188A80C94
	}

	[AddComponentMenu("Cinemachine/CinemachineFreeLook")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExcludeFromPreset]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineFreeLook.html")]
	public class CinemachineFreeLook : CinemachineVirtualCameraBase // TypeDefIndex: 84539
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
		[FormerlySerializedAs("m_BlendHint")]
		[FormerlySerializedAs("m_PositionBlending")]
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
		private CinemachineVirtualCamera[] m_Rigs; // 0x388
		private CinemachineOrbitalTransposer[] mOrbitals; // 0x390
		private CinemachineBlend mBlendA; // 0x398
		private CinemachineBlend mBlendB; // 0x3A0
		public static CreateRigDelegate CreateRigOverride; // 0x00
		public static DestroyRigDelegate DestroyRigOverride; // 0x08
		private float m_CachedXAxisHeading; // 0x3A8
		private Orbit[] m_CachedOrbits; // 0x3B0
		private float m_CachedTension; // 0x3B8
		private Vector4[] m_CachedKnots; // 0x3C0
		private Vector4[] m_CachedCtrl1; // 0x3C8
		private Vector4[] m_CachedCtrl2; // 0x3D0
	
		// Properties
		public static string[] RigNames { get; } // 0x0000000188A84C1C-0x0000000188A84CC4 
		public override bool PreviousStateIsValid { get; set; } // 0x000000018226EBE0-0x000000018226EBF0 0x0000000188A84CC4-0x0000000188A84DB0
		public override CameraState State { get; } // 0x0000000187234850-0x00000001872348F0 
		public override Transform LookAt { get; set; } // 0x0000000188A799FC-0x0000000188A79A0C 0x0000000185017110-0x0000000185017130
		public override Transform Follow { get; set; } // 0x0000000188A799E0-0x0000000188A799F0 0x0000000185017130-0x0000000185017150
	
		// Nested types
		[Serializable]
		public struct Orbit // TypeDefIndex: 84536
		{
			// Fields
			public float m_Height; // 0x00
			public float m_Radius; // 0x04
	
			// Constructors
			public Orbit(float h, float r); // 0x0000000187234A10-0x0000000187234A20
		}
	
		public delegate CinemachineVirtualCamera CreateRigDelegate(CinemachineFreeLook vcam, string name, CinemachineVirtualCamera copyFrom); // TypeDefIndex: 84537; 0x00000001811DF7F0-0x00000001811DF810
	
		public delegate void DestroyRigDelegate(GameObject rig); // TypeDefIndex: 84538; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Constructors
		public CinemachineFreeLook(); // 0x0000000188A8472C-0x0000000188A84C1C
	
		// Methods
		protected override void OnValidate(); // 0x0000000188A83688-0x0000000188A837CC
		public CinemachineVirtualCamera GetRig(int i); // 0x0000000188A81DF4-0x0000000188A81E44
		protected override void OnEnable(); // 0x0000000188A831D4-0x0000000188A83214
		public void UpdateInputAxisProvider(); // 0x0000000188A842B4-0x0000000188A84354
		protected override void OnDestroy(); // 0x0000000188A830B8-0x0000000188A831D4
		private void OnTransformChildrenChanged(); // 0x0000000188A82888-0x0000000188A828A0
		private void Reset(); // 0x0000000188A83DF8-0x0000000188A83E00
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x026445B5 */); // 0x0000000188A828A0-0x0000000188A829AC
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x0000000188A83214-0x0000000188A832D8
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x0000000188A818B0-0x0000000188A81BB4
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x0000000188A82218-0x0000000188A82888
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x0000000188A832D8-0x0000000188A83688
		internal override bool RequiresUserInput(); // 0x00000001851A4410-0x00000001851A4420
		private float GetYAxisClosestValue(Vector3 cameraPos, Vector3 up); // 0x0000000188A81E44-0x0000000188A821E8
		private void InvalidateRigCache(); // 0x0000000188A82888-0x0000000188A828A0
		private void DestroyRigs(); // 0x0000000188A8142C-0x0000000188A818B0
		private CinemachineVirtualCamera[] CreateRigs(CinemachineVirtualCamera[] copyFrom); // 0x0000000188A80FBC-0x0000000188A8142C
		private void UpdateRigCache(); // 0x0000000188A84354-0x0000000188A84598
		private int LocateExistingRigs(string[] rigNames, bool forceOrbital); // 0x0000000188A829AC-0x0000000188A830B8
		private float UpdateXAxisHeading(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up); // 0x0000000188A84598-0x0000000188A8472C
		private void PushSettingsToRigs(); // 0x0000000188A837CC-0x0000000188A83DF8
		private float GetYAxisValue(); // 0x0000000188A821E8-0x0000000188A82218
		private CameraState CalculateNewState(Vector3 worldUp, float deltaTime); // 0x0000000188A80CC8-0x0000000188A80FBC
		public Vector3 GetLocalPositionForCameraFromInput(float t); // 0x0000000188A81BB4-0x0000000188A81DF4
		private void UpdateCachedSpline(); // 0x0000000188A83E00-0x0000000188A842B4
	}

	[AddComponentMenu("Cinemachine/CinemachineMixingCamera")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExcludeFromPreset]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineMixingCamera.html")]
	public class CinemachineMixingCamera : CinemachineVirtualCameraBase // TypeDefIndex: 84540
	{
		// Fields
		public const int MaxCameras = 8; // Metadata: 0x026445B7
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
		private ICinemachineCamera _LiveChild_k__BackingField; // 0x208
		[CompilerGenerated]
		private Transform _LookAt_k__BackingField; // 0x210
		[CompilerGenerated]
		private Transform _Follow_k__BackingField; // 0x218
		private CinemachineVirtualCameraBase[] m_ChildCameras; // 0x220
		private Dictionary<CinemachineVirtualCameraBase, int> m_indexMap; // 0x228
	
		// Properties
		private ICinemachineCamera LiveChild { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187234920-0x0000000187234930 0x0000000188A865D0-0x0000000188A865E4
		public override CameraState State { get; } // 0x0000000187234940-0x00000001872349E0 
		public override Transform LookAt { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187234930-0x0000000187234940 0x0000000188A865E4-0x0000000188A865F8
		public override Transform Follow { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187234910-0x0000000187234920 0x0000000188A865BC-0x0000000188A865D0
		public CinemachineVirtualCameraBase[] ChildCameras { get; } // 0x0000000188A8659C-0x0000000188A865BC 
	
		// Constructors
		public CinemachineMixingCamera(); // 0x0000000188A86418-0x0000000188A8659C
	
		// Methods
		public float GetWeight(int index); // 0x0000000188A8569C-0x0000000188A857A0
		public void SetWeight(int index, float w); // 0x0000000188A860D4-0x0000000188A861E4
		public float GetWeight(CinemachineVirtualCameraBase vcam); // 0x0000000188A8557C-0x0000000188A8569C
		public void SetWeight(CinemachineVirtualCameraBase vcam, float w); // 0x0000000188A85FA8-0x0000000188A860D4
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x0000000188A85D28-0x0000000188A85DE8
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x0000000188A8549C-0x0000000188A8557C
		protected override void OnEnable(); // 0x0000000188A85D08-0x0000000188A85D28
		public void OnTransformChildrenChanged(); // 0x0000000188A85DE8-0x0000000188A85DF0
		protected override void OnValidate(); // 0x0000000188A85F4C-0x0000000188A85FA8
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x026445B6 */); // 0x0000000188A85C64-0x0000000188A85D08
		protected void InvalidateListOfChildren(); // 0x0000000188A85C1C-0x0000000188A85C64
		protected void ValidateListOfChildren(); // 0x0000000188A861E4-0x0000000188A86418
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x0000000188A85DF0-0x0000000188A85F4C
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x0000000188A857A0-0x0000000188A85C1C
	}

	[AddComponentMenu("Cinemachine/CinemachinePath")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachinePath.html")]
	[SaveDuringPlay]
	public class CinemachinePath : CinemachinePathBase // TypeDefIndex: 84542
	{
		// Fields
		[Tooltip("If checked, then the path ends are joined to form a continuous loop.")]
		public bool m_Looped; // 0x48
		[Tooltip("The waypoints that define the path.  They will be interpolated using a bezier curve.")]
		public Waypoint[] m_Waypoints; // 0x50
	
		// Properties
		public override float MinPos { get; } // 0x0000000187234CD0-0x0000000187234CE0 
		public override float MaxPos { get; } // 0x0000000188A8ED74-0x0000000188A8EDB0 
		public override bool Looped { get; } // 0x000000018223CB60-0x000000018223CB70 
		public override int DistanceCacheSampleStepsPerSegment { get; } // 0x00000001844AF510-0x00000001844AF520 
	
		// Nested types
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct Waypoint // TypeDefIndex: 84541
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
		public CinemachinePath(); // 0x0000000188A8ED24-0x0000000188A8ED74
	
		// Methods
		private void Reset(); // 0x0000000188A8EBFC-0x0000000188A8ED24
		private float GetBoundingIndices(float pos, out int indexA, out int indexB); // 0x0000000188A8EB14-0x0000000188A8EBEC
		public override Vector3 EvaluatePosition(float pos); // 0x0000000188A8E694-0x0000000188A8E8B0
		public override Vector3 EvaluateTangent(float pos); // 0x0000000188A8E8B0-0x0000000188A8EB14
		public override Quaternion EvaluateOrientation(float pos); // 0x0000000188A8E408-0x0000000188A8E694
		private void OnValidate(); // 0x0000000188A8EBEC-0x0000000188A8EBFC
	}

	[AddComponentMenu("")]
	public sealed class CinemachinePipeline : MonoBehaviour // TypeDefIndex: 84543
	{
		// Constructors
		public CinemachinePipeline(); // 0x000000018548CC60-0x000000018548CC80
	}

	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	public class CinemachinePixelPerfect : MonoBehaviour // TypeDefIndex: 84544
	{
		// Constructors
		public CinemachinePixelPerfect(); // 0x00000001878364A0-0x00000001878364B8
	}

	[AddComponentMenu("Cinemachine/CinemachineSmoothPath")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineSmoothPath.html")]
	[SaveDuringPlay]
	public class CinemachineSmoothPath : CinemachinePathBase // TypeDefIndex: 84546
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
		public override float MinPos { get; } // 0x0000000187234CD0-0x0000000187234CE0 
		public override float MaxPos { get; } // 0x000000018625BB50-0x000000018625BB90 
		public override bool Looped { get; } // 0x000000018223CB60-0x000000018223CB70 
		public override int DistanceCacheSampleStepsPerSegment { get; } // 0x00000001844AF510-0x00000001844AF520 
	
		// Nested types
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct Waypoint // TypeDefIndex: 84545
		{
			// Fields
			[Tooltip("Position in path-local space")]
			public Vector3 position; // 0x00
			[Tooltip("Defines the roll of the path at this waypoint.  The other orientation axes are inferred from the tangent and world up.")]
			public float roll; // 0x0C
	
			// Properties
			internal Vector4 AsVector4 { get; } // 0x0000000185483D20-0x0000000185483D40 
	
			// Methods
			internal static Waypoint FromVector4(Vector4 v); // 0x000000018587F380-0x000000018587F3B0
		}
	
		// Constructors
		public CinemachineSmoothPath(); // 0x0000000186674290-0x00000001866742D0
	
		// Methods
		private void OnValidate(); // 0x0000000188A8EBEC-0x0000000188A8EBFC
		private void Reset(); // 0x0000000188A8EDB0-0x0000000188A8EEB8
		public override void InvalidateDistanceCache(); // 0x0000000186D3A9D0-0x0000000186D3AA10
		private void UpdateControlPoints(); // 0x000000018587EA50-0x000000018587ECE0
		private float GetBoundingIndices(float pos, out int indexA, out int indexB); // 0x000000018587E7B0-0x000000018587E850
		public override Vector3 EvaluatePosition(float pos); // 0x000000018587E460-0x000000018587E7B0
		public override Vector3 EvaluateTangent(float pos); // 0x000000018587DE60-0x000000018587E150
		public override Quaternion EvaluateOrientation(float pos); // 0x000000018587E150-0x000000018587E460
		private Quaternion RollAroundForward(float angle); // 0x000000018587EF00-0x000000018587EF50
	}

	[AddComponentMenu("Cinemachine/CinemachineStateDrivenCamera")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExcludeFromPreset]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineStateDrivenCamera.html")]
	public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase // TypeDefIndex: 84550
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
		private Dictionary<AnimationClip, List<HashPair>> mHashCache; // 0x250
		private float mActivationTime; // 0x258
		private Instruction mActiveInstruction; // 0x260
		private float mPendingActivationTime; // 0x278
		private Instruction mPendingInstruction; // 0x280
		private CinemachineBlend mActiveBlend; // 0x298
		private Dictionary<int, int> mInstructionDictionary; // 0x2A0
		private Dictionary<int, int> mStateParentLookup; // 0x2A8
		private List<AnimatorClipInfo> m_clipInfoList; // 0x2B0
	
		// Properties
		public override string Description { get; } // 0x0000000188A90D98-0x0000000188A90E84 
		public ICinemachineCamera LiveChild { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187234CE0-0x0000000187234CF0 0x0000000188A90E90-0x0000000188A90EA4
		public override CameraState State { get; } // 0x0000000187234CF0-0x0000000187234D90 
		public override Transform LookAt { get; set; } // 0x0000000188A799FC-0x0000000188A79A0C 0x0000000185017110-0x0000000185017130
		public override Transform Follow { get; set; } // 0x0000000188A799E0-0x0000000188A799F0 0x0000000185017130-0x0000000185017150
		public CinemachineVirtualCameraBase[] ChildCameras { get; } // 0x0000000188A90D78-0x0000000188A90D98 
		public bool IsBlending { get; } // 0x0000000188A90E84-0x0000000188A90E90 
	
		// Nested types
		[Serializable]
		public struct Instruction // TypeDefIndex: 84547
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
		internal struct ParentHash // TypeDefIndex: 84548
		{
			// Fields
			public int m_Hash; // 0x00
			public int m_ParentHash; // 0x04
		}
	
		private struct HashPair // TypeDefIndex: 84549
		{
			// Fields
			public int parentHash; // 0x00
			public int hash; // 0x04
		}
	
		// Constructors
		public CinemachineStateDrivenCamera(); // 0x0000000188A90B7C-0x0000000188A90D78
	
		// Methods
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x026445B8 */); // 0x0000000188A8FCD4-0x0000000188A8FCFC
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x0000000188A90550-0x0000000188A90610
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x0000000188A8F4F4-0x0000000188A8F5D4
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x0000000188A90618-0x0000000188A906D8
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x0000000188A8F6F0-0x0000000188A8FCA0
		protected override void OnEnable(); // 0x0000000188A90218-0x0000000188A9040C
		protected override void OnDisable(); // 0x0000000188A90100-0x0000000188A90218
		public void OnTransformChildrenChanged(); // 0x0000000188A90610-0x0000000188A90618
		private void OnGuiHandler(); // 0x0000000188A9040C-0x0000000188A90550
		public static int CreateFakeHash(int parentHash, AnimationClip clip); // 0x0000000188A8F45C-0x0000000188A8F4F4
		private int LookupFakeHash(int parentHash, AnimationClip clip); // 0x0000000188A8FED8-0x0000000188A90100
		private void InvalidateListOfChildren(); // 0x0000000188A8FCA0-0x0000000188A8FCD4
		private void UpdateListOfChildren(); // 0x0000000188A906D8-0x0000000188A9088C
		internal void ValidateInstructions(); // 0x0000000188A9088C-0x0000000188A90B7C
		private CinemachineVirtualCameraBase ChooseCurrentCamera(); // 0x0000000188A8EEB8-0x0000000188A8F45C
		private int GetClipHash(int hash, List<AnimatorClipInfo> clips); // 0x0000000188A8F5D4-0x0000000188A8F6F0
		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey); // 0x0000000188A8FCFC-0x0000000188A8FED8
	}

	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineStoryboard.html")]
	[SaveDuringPlay]
	public class CinemachineStoryboard : CinemachineExtension // TypeDefIndex: 84554
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
		private string CanvasName { get; } // 0x0000000188A92574-0x0000000188A925E0 
	
		// Nested types
		public enum FillStrategy // TypeDefIndex: 84551
		{
			BestFit = 0,
			CropImageToFit = 1,
			StretchToFit = 2
		}
	
		private class CanvasInfo // TypeDefIndex: 84552
		{
			// Fields
			public GameObject mCanvas; // 0x10
			public Canvas mCanvasComponent; // 0x18
			public CinemachineBrain mCanvasParent; // 0x20
			public RectTransform mViewport; // 0x28
			public RawImage mRawImage; // 0x30
	
			// Constructors
			public CanvasInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public enum StoryboardRenderMode // TypeDefIndex: 84553
		{
			ScreenSpaceOverlay = 0,
			ScreenSpaceCamera = 1
		}
	
		// Constructors
		public CinemachineStoryboard(); // 0x0000000188A92494-0x0000000188A92574
	
		// Methods
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x0000000188A921F4-0x0000000188A922F0
		private void UpdateRenderCanvas(); // 0x0000000188A922F0-0x0000000188A92494
		protected override void ConnectToVcam(bool connect); // 0x0000000188A91054-0x0000000188A911B8
		private void CameraUpdatedCallback(CinemachineBrain brain); // 0x0000000188A90EA4-0x0000000188A91054
		private CanvasInfo LocateMyCanvas(CinemachineBrain parent, bool createIfNotFound); // 0x0000000188A917F4-0x0000000188A91BD8
		private void CreateCanvas(CanvasInfo ci); // 0x0000000188A911B8-0x0000000188A91604
		private void DestroyCanvas(); // 0x0000000188A91604-0x0000000188A917F4
		private void PlaceImage(CanvasInfo ci, float alpha); // 0x0000000188A91BD8-0x0000000188A921F4
		private static void StaticBlendingHandler(CinemachineBrain brain); // 0x00000001856A56C0-0x00000001856A57C0
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule(); // 0x0000000186382F90-0x00000001863830B0
	}

	public interface ICinemachineTargetGroup // TypeDefIndex: 84555
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
	public class CinemachineTargetGroup : MonoBehaviour, ICinemachineTargetGroup // TypeDefIndex: 84560
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
		public Transform Transform { get; } // 0x0000000187834814-0x000000018783481C 
		public Bounds BoundingBox { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187234D90-0x0000000187234DB0 0x0000000187234DC0-0x0000000187234DE0
		public BoundingSphere Sphere { get; } // 0x0000000187234DB0-0x0000000187234DC0 
		public bool IsEmpty { get; } // 0x0000000188A9323C-0x0000000188A932E4 
	
		// Nested types
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct Target // TypeDefIndex: 84556
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
		public enum PositionMode // TypeDefIndex: 84557
		{
			GroupCenter = 0,
			GroupAverage = 1
		}
	
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum RotationMode // TypeDefIndex: 84558
		{
			Manual = 0,
			GroupAverage = 1
		}
	
		public enum UpdateMethod // TypeDefIndex: 84559
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2
		}
	
		// Constructors
		public CinemachineTargetGroup(); // 0x0000000186FC5190-0x0000000186FC5200
	
		// Methods
		public void AddMember(Transform t, float weight, float radius); // 0x0000000188A925E0-0x0000000188A926F8
		public void RemoveMember(Transform t); // 0x0000000188A93174-0x0000000188A9323C
		public int FindMember(Transform t); // 0x0000000188A928F4-0x0000000188A92994
		public BoundingSphere GetWeightedBoundsForMember(int index); // 0x0000000188A9302C-0x0000000188A930C4
		public Bounds GetViewSpaceBoundingBox(Matrix4x4 observer); // 0x0000000188A92E38-0x0000000188A9302C
		private static BoundingSphere WeightedMemberBounds(Target t, Vector3 avgPos, float maxWeight); // 0x00000001854A9F60-0x00000001854AA120
		public void DoUpdate(); // 0x00000001854AAA70-0x00000001854AAB60
		private BoundingSphere CalculateBoundingSphere(float maxWeight); // 0x00000001854AA460-0x00000001854AA690
		private Vector3 CalculateAveragePosition(out float maxWeight); // 0x00000001854AA690-0x00000001854AA8E0
		private Quaternion CalculateAverageOrientation(); // 0x0000000188A926F8-0x0000000188A928F4
		private Bounds CalculateBoundingBox(Vector3 avgPos, float maxWeight); // 0x00000001854AA1E0-0x00000001854AA460
		private void OnValidate(); // 0x0000000188A930C4-0x0000000188A93174
		private void FixedUpdate(); // 0x000000018676A070-0x000000018676A090
		private void Update(); // 0x0000000186637E80-0x0000000186637EB0
		private void LateUpdate(); // 0x00000001854AAB60-0x00000001854AAB70
		public void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange); // 0x0000000188A92994-0x0000000188A92E38
	}

	[AddComponentMenu("Cinemachine/CinemachineVirtualCamera")]
	[DisallowMultipleComponent]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExcludeFromPreset]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineVirtualCamera.html")]
	public class CinemachineVirtualCamera : CinemachineVirtualCameraBase // TypeDefIndex: 84564
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
		public const string PipelineName = "cm"; // Metadata: 0x026445C5
		public static CreatePipelineDelegate CreatePipelineOverride; // 0x00
		public static DestroyPipelineDelegate DestroyPipelineOverride; // 0x08
		internal bool m_UserIsDragging; // 0xFC
		protected CameraState m_State; // 0x100
		private CinemachineComponentBase[] m_ComponentPipeline; // 0x240
		[HideInInspector]
		[SerializeField]
		private Transform m_ComponentOwner; // 0x248
		private Transform mCachedLookAtTarget; // 0x250
		private CinemachineVirtualCameraBase mCachedLookAtTargetVcam; // 0x258
	
		// Properties
		public override CameraState State { get; } // 0x00000001872346E0-0x0000000187234780 
		public override Transform LookAt { get; set; } // 0x000000018522E9F0-0x000000018522EA00 0x0000000185017110-0x0000000185017130
		public override Transform Follow { get; set; } // 0x000000018522ED40-0x000000018522ED50 0x0000000185017130-0x0000000185017150
	
		// Nested types
		public delegate Transform CreatePipelineDelegate(CinemachineVirtualCamera vcam, string name, CinemachineComponentBase[] copyFrom); // TypeDefIndex: 84561; 0x00000001811DF7F0-0x00000001811DF810
	
		public delegate void DestroyPipelineDelegate(GameObject pipeline); // TypeDefIndex: 84562; 0x0000000185B78EA0-0x0000000185B78EB0
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 84563
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<CinemachineComponentBase> __9__39_0; // 0x08
			public static Func<CinemachineComponentBase, bool> __9__48_0; // 0x10
	
			// Constructors
			static __c(); // 0x00000001871E7340-0x00000001871E73A0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _UpdateComponentPipeline_b__39_0(CinemachineComponentBase c1, CinemachineComponentBase c2); // 0x0000000186ACEF90-0x0000000186ACEFE0
			internal bool _RequiresUserInput_b__48_0(CinemachineComponentBase c); // 0x0000000188A93E74-0x0000000188A93FAC
		}
	
		// Constructors
		public CinemachineVirtualCamera(); // 0x00000001864CDC00-0x00000001864CDDB0
	
		// Methods
		public void SetFieldOfView(float fov); // 0x0000000187234DE0-0x0000000187234DF0
		public override float GetMaxDampTime(); // 0x0000000188A93A60-0x0000000188A93AF4
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x000000018522D430-0x000000018522DAA0
		protected override void OnEnable(); // 0x00000001852270B0-0x0000000185227290
		protected override void OnDestroy(); // 0x0000000185226150-0x0000000185226820
		protected override void OnValidate(); // 0x0000000188A93CC8-0x0000000188A93D38
		private void OnTransformChildrenChanged(); // 0x000000018783565C-0x0000000187835674
		private void Reset(); // 0x0000000188A93E6C-0x0000000188A93E74
		private void DestroyPipeline(); // 0x0000000188A93458-0x0000000188A938D0
		private Transform CreatePipeline(CinemachineVirtualCamera copyFrom); // 0x0000000188A932E4-0x0000000188A93458
		public void InvalidateComponentPipeline(); // 0x000000018783565C-0x0000000187835674
		public Transform GetComponentOwner(); // 0x0000000188A93A40-0x0000000188A93A60
		public CinemachineComponentBase[] GetComponentPipeline(); // 0x000000018783C9F0-0x000000018783CA10
		public CinemachineComponentBase GetCinemachineComponent(CinemachineCore.Stage stage); // 0x0000000186901E00-0x0000000186901E90
		public new T GetCinemachineComponent<T>()
			where T : CinemachineComponentBase;
		public T AddCinemachineComponent<T>()
			where T : CinemachineComponentBase;
		public void DestroyCinemachineComponent<T>()
			where T : CinemachineComponentBase;
		private void UpdateComponentPipeline(); // 0x0000000185275630-0x0000000185276240
		internal static void SetFlagsForHiddenChild(GameObject child); // 0x00000001852766F0-0x0000000185276800
		protected CameraState CalculateNewState(Vector3 worldUp, float deltaTime); // 0x00000001853A6AE0-0x00000001853A7720
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x0000000188A93AF4-0x0000000188A93CC8
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x0000000188A938D0-0x0000000188A93A40
		internal void SetStateRawPosition(Vector3 pos); // 0x0000000187234DF0-0x0000000187234E10
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x0000000185275270-0x0000000185275460
		internal override bool RequiresUserInput(); // 0x0000000188A93D38-0x0000000188A93E6C
	}

	[AddComponentMenu("")]
	[SaveDuringPlay]
	public class Cinemachine3rdPersonFollow : CinemachineComponentBase // TypeDefIndex: 84565
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
		public override bool IsValid { get; } // 0x00000001861A7F30-0x00000001861A7FC0 
		public override CinemachineCore.Stage Stage { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	
		// Constructors
		public Cinemachine3rdPersonFollow(); // 0x0000000185D914B0-0x0000000185D91520
	
		// Methods
		private void OnValidate(); // 0x0000000188A88088-0x0000000188A88104
		private void Reset(); // 0x0000000187234A40-0x0000000187234AB0
		private void OnDestroy(); // 0x0000000188A87F88-0x0000000188A87FC8
		public override float GetMaxDampTime(); // 0x0000000188A87D5C-0x0000000188A87D80
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001854A6160-0x00000001854A61E0
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x0000000188A87FC8-0x0000000188A88088
		private void PositionCamera(ref CameraState curState, float deltaTime); // 0x00000001854A61E0-0x00000001854A6C30
		public void GetRigPositions(out Vector3 root, out Vector3 shoulder, out Vector3 hand); // 0x0000000188A87D80-0x0000000188A87F88
		internal static Quaternion GetHeading(Quaternion targetRot, Vector3 up); // 0x00000001854A7520-0x00000001854A7700
		private void GetRawRigPositions(Vector3 root, Quaternion targetRot, Quaternion heading, out Vector3 shoulder, out Vector3 hand); // 0x00000001854A7760-0x00000001854A78E0
		private Vector3 BeyondResolveCollisions(Vector3 root, Vector3 tip, float cameraRadius); // 0x0000000188A87B04-0x0000000188A87D5C
		private Vector3 ResolveCollisions(Vector3 root, Vector3 tip, float deltaTime, float cameraRadius, ref float collisionCorrection); // 0x0000000188A88104-0x0000000188A88448
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase // TypeDefIndex: 84566
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
		public override bool IsValid { get; } // 0x0000000188A88B28-0x0000000188A88B84 
		public override CinemachineCore.Stage Stage { get; } // 0x00000001845AFFB0-0x00000001845AFFC0 
	
		// Constructors
		public CinemachineBasicMultiChannelPerlin(); // 0x0000000188A88AD0-0x0000000188A88B28
	
		// Methods
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x0000000188A88500-0x0000000188A88A4C
		public void ReSeed(); // 0x0000000188A88A4C-0x0000000188A88AD0
		private void Initialize(); // 0x0000000188A88448-0x0000000188A88500
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineComposer : CinemachineComponentBase // TypeDefIndex: 84568
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
		public override bool IsValid { get; } // 0x000000018522CE70-0x000000018522CF00 
		public override CinemachineCore.Stage Stage { get; } // 0x00000001872328C0-0x00000001872328D0 
		public Vector3 TrackedPoint { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187234AF0-0x0000000187234B10 0x0000000187234B10-0x0000000187234B20
		protected virtual bool useTrackedObjectOffsetCollision { get; } // 0x00000001851A4410-0x00000001851A4420 
		internal Rect SoftGuideRect { get; set; } // 0x0000000186165EA0-0x0000000186165EF0 0x0000000188A88E38-0x0000000188A88EF8
		internal Rect HardGuideRect { get; set; } // 0x0000000185FFBE00-0x0000000185FFBEB0 0x0000000188A88CD0-0x0000000188A88E38
	
		// Nested types
		private struct FovCache // TypeDefIndex: 84567
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
			public void UpdateCache(LensSettings lens, Rect softGuide, Rect hardGuide, float targetDistance); // 0x0000000184FB1BE0-0x0000000184FB1F60
			private Rect ScreenToFOV(Rect rScreen, float fov, float fovH, float aspect); // 0x0000000185DCC720-0x0000000185DCCB20
		}
	
		// Constructors
		public CinemachineComposer(); // 0x0000000185D91670-0x0000000185D91770
	
		// Methods
		protected virtual Vector3 GetLookAtPointAndSetTrackedPoint(Vector3 lookAt, Vector3 up, float deltaTime); // 0x0000000184FB2A90-0x0000000184FB2F00
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x0000000188A88B94-0x0000000188A88CD0
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x0000000187234AD0-0x0000000187234AF0
		public override float GetMaxDampTime(); // 0x0000000188A88B84-0x0000000188A88B94
		public override void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime); // 0x0000000184FB2970-0x0000000184FB2A90
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x000000018522EE70-0x000000018522F9A0
		public void ClearOriginalRotToRect(); // 0x0000000187234AB0-0x0000000187234AD0
		private void RotateToScreenBounds(ref CameraState state, Rect screenRect, Vector3 trackedPoint, ref Quaternion rigOrientation, float fov, float fovH, float deltaTime); // 0x000000018522DAA0-0x000000018522E310
		private bool ClampVerticalBounds(ref Rect r, Vector3 dir, Vector3 up, float fov); // 0x000000018522CDE0-0x000000018522CE70
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineFramingTransposer : CinemachineComponentBase // TypeDefIndex: 84571
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
		private const float kMinimumCameraDistance = 0.01f; // Metadata: 0x026445C8
		private const float kMinimumGroupSize = 0.01f; // Metadata: 0x026445CC
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
		internal Rect SoftGuideRect { get; set; } // 0x0000000188A8B238-0x0000000188A8B280 0x0000000188A8B3E8-0x0000000188A8B4A8
		internal Rect HardGuideRect { get; set; } // 0x0000000188A8B128-0x0000000188A8B1D4 0x0000000188A8B280-0x0000000188A8B3E8
		public override bool IsValid { get; } // 0x0000000188A8B1D4-0x0000000188A8B238 
		public override CinemachineCore.Stage Stage { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public override bool BodyAppliesAfterAim { get; } // 0x00000001851A4410-0x00000001851A4420 
		public Vector3 TrackedPoint { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187234BA0-0x0000000187234BC0 0x0000000187234C10-0x0000000187234C30
		public Bounds LastBounds { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187234B80-0x0000000187234BA0 0x0000000187234BF0-0x0000000187234C10
		public Matrix4x4 LastBoundsMatrix { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187234B50-0x0000000187234B80 0x0000000187234BC0-0x0000000187234BF0
	
		// Nested types
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum FramingMode // TypeDefIndex: 84569
		{
			Horizontal = 0,
			Vertical = 1,
			HorizontalAndVertical = 2,
			None = 3
		}
	
		public enum AdjustmentMode // TypeDefIndex: 84570
		{
			ZoomOnly = 0,
			DollyOnly = 1,
			DollyThenZoom = 2
		}
	
		// Constructors
		public CinemachineFramingTransposer(); // 0x0000000188A8B02C-0x0000000188A8B128
	
		// Methods
		private void OnValidate(); // 0x0000000188A8AD88-0x0000000188A8AE74
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x0000000188A8AA98-0x0000000188A8AB98
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x0000000187234B20-0x0000000187234B50
		public override float GetMaxDampTime(); // 0x0000000188A89388-0x0000000188A893A0
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams); // 0x0000000188A8AB98-0x0000000188A8AD88
		private Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect); // 0x0000000188A8AF58-0x0000000188A8B02C
		private Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect); // 0x0000000188A8AE74-0x0000000188A8AF58
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x0000000188A8996C-0x0000000188A8AA98
		private float GetTargetHeight(Vector2 boundsSize); // 0x0000000188A897B0-0x0000000188A8996C
		private Vector3 ComputeGroupBounds(ICinemachineTargetGroup group, ref CameraState curState); // 0x0000000188A88EF8-0x0000000188A89388
		private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, ref Vector3 pos, Quaternion orientation); // 0x0000000188A893A0-0x0000000188A897B0
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineGroupComposer : CinemachineComposer // TypeDefIndex: 84574
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
		public Bounds LastBounds { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187234C60-0x0000000187234C80 0x0000000187234CB0-0x0000000187234CD0
		public Matrix4x4 LastBoundsMatrix { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187234C30-0x0000000187234C60 0x0000000187234C80-0x0000000187234CB0
	
		// Nested types
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum FramingMode // TypeDefIndex: 84572
		{
			Horizontal = 0,
			Vertical = 1,
			HorizontalAndVertical = 2
		}
	
		public enum AdjustmentMode // TypeDefIndex: 84573
		{
			ZoomOnly = 0,
			DollyOnly = 1,
			DollyThenZoom = 2
		}
	
		// Constructors
		public CinemachineGroupComposer(); // 0x0000000188A8C598-0x0000000188A8C610
	
		// Methods
		private void OnValidate(); // 0x0000000188A8C4C8-0x0000000188A8C598
		public override float GetMaxDampTime(); // 0x0000000188A8B4A8-0x0000000188A8B4C0
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x0000000188A8B948-0x0000000188A8C4C8
		private float GetTargetHeight(Vector2 boundsSize); // 0x0000000188A8B750-0x0000000188A8B948
		private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, Matrix4x4 observer, out Vector3 newFwd); // 0x0000000188A8B4C0-0x0000000188A8B750
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineHardLockToTarget : CinemachineComponentBase // TypeDefIndex: 84575
	{
		// Fields
		[Tooltip("How much time it takes for the position to catch up to the target\'s position")]
		public float m_Damping; // 0x20
		private Vector3 m_PreviousTargetPosition; // 0x24
	
		// Properties
		public override bool IsValid { get; } // 0x0000000188A8C770-0x0000000188A8C7D4 
		public override CinemachineCore.Stage Stage { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	
		// Constructors
		public CinemachineHardLockToTarget(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		public override float GetMaxDampTime(); // 0x00000001872332C0-0x00000001872332D0
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x0000000188A8C610-0x0000000188A8C770
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineHardLookAt : CinemachineComponentBase // TypeDefIndex: 84576
	{
		// Properties
		public override bool IsValid { get; } // 0x0000000188A8C9A4-0x0000000188A8CA08 
		public override CinemachineCore.Stage Stage { get; } // 0x00000001872328C0-0x00000001872328D0 
	
		// Constructors
		public CinemachineHardLookAt(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x0000000188A8C7D4-0x0000000188A8C9A4
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineOrbitalTransposer : CinemachineTransposer // TypeDefIndex: 84581
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
		public override bool RequiresUserInput { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Nested types
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct Heading // TypeDefIndex: 84578
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
			public enum HeadingDefinition // TypeDefIndex: 84577
			{
				PositionDelta = 0,
				Velocity = 1,
				TargetForward = 2,
				WorldForward = 3
			}
	
			// Constructors
			public Heading(HeadingDefinition def, int filterStrength, float bias); // 0x0000000187235020-0x0000000187235030
		}
	
		internal delegate float UpdateHeadingDelegate(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up); // TypeDefIndex: 84579; 0x0000000184172C20-0x0000000184172C60
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 84580
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static UpdateHeadingDelegate __9__30_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000188A9B1A0-0x0000000188A9B204
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _.ctor_b__30_0(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up); // 0x0000000188A9B068-0x0000000188A9B13C
		}
	
		// Constructors
		public CinemachineOrbitalTransposer(); // 0x0000000188A8E17C-0x0000000188A8E408
	
		// Methods
		protected override void OnValidate(); // 0x0000000188A8DDD8-0x0000000188A8DF30
		public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis); // 0x0000000188A8DF30-0x0000000188A8DF70
		public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis, ref AxisState.Recentering recentering, bool isLive); // 0x0000000188A8DF70-0x0000000188A8E0B0
		private void OnEnable(); // 0x0000000188A8DA88-0x0000000188A8DAD0
		public void UpdateInputAxisProvider(); // 0x0000000188A8E0B0-0x0000000188A8E17C
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x0000000188A8DAD0-0x0000000188A8DC10
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x0000000188A8CA08-0x0000000188A8CB60
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams); // 0x0000000188A8DC10-0x0000000188A8DDD8
		public float GetAxisClosestValue(Vector3 cameraPos, Vector3 up); // 0x0000000188A8CB60-0x0000000188A8CE80
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x0000000188A8D39C-0x0000000188A8DA88
		public override Vector3 GetTargetCameraPosition(Vector3 worldUp); // 0x0000000188A8CE80-0x0000000188A8CFDC
		private float GetTargetHeading(float currentHeading, Quaternion targetOrientation); // 0x0000000188A8CFDC-0x0000000188A8D39C
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachinePOV : CinemachineComponentBase // TypeDefIndex: 84583
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
		public override bool IsValid { get; } // 0x0000000188A97410-0x0000000188A97418 
		public override CinemachineCore.Stage Stage { get; } // 0x00000001872328C0-0x00000001872328D0 
		public override bool RequiresUserInput { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Nested types
		public enum RecenterTargetMode // TypeDefIndex: 84582
		{
			None = 0,
			FollowTargetForward = 1,
			LookAtTargetForward = 2
		}
	
		// Constructors
		public CinemachinePOV(); // 0x0000000188A971A8-0x0000000188A97410
	
		// Methods
		private void OnValidate(); // 0x0000000188A96BE8-0x0000000188A96C68
		private void OnEnable(); // 0x0000000188A96A28-0x0000000188A96A30
		public void UpdateInputAxisProvider(); // 0x0000000188A970A4-0x0000000188A971A8
		public override void PrePipelineMutateCameraState(ref CameraState state, float deltaTime); // 0x0000000186805BA0-0x0000000186805BB0
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x0000000188A9678C-0x0000000188A96A28
		public Vector2 GetRecenterTarget(); // 0x0000000188A9655C-0x0000000188A9678C
		private static float NormalizeAngle(float angle); // 0x0000000187234FD0-0x0000000187235000
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x0000000188A9653C-0x0000000188A9655C
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams); // 0x0000000188A96A30-0x0000000188A96BE8
		private void SetAxesForRotation(Quaternion targetRot); // 0x0000000188A96C68-0x0000000188A970A4
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineSameAsFollowTarget : CinemachineComponentBase // TypeDefIndex: 84584
	{
		// Fields
		[FormerlySerializedAs("m_AngularDamping")]
		[Tooltip("How much time it takes for the aim to catch up to the target\'s rotation")]
		public float m_Damping; // 0x20
		private Quaternion m_PreviousReferenceOrientation; // 0x24
	
		// Properties
		public override bool IsValid { get; } // 0x0000000188A979A4-0x0000000188A97A08 
		public override CinemachineCore.Stage Stage { get; } // 0x00000001872328C0-0x00000001872328D0 
	
		// Constructors
		public CinemachineSameAsFollowTarget(); // 0x0000000185D91470-0x0000000185D914B0
	
		// Methods
		public override float GetMaxDampTime(); // 0x00000001872332C0-0x00000001872332D0
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x0000000188A978A4-0x0000000188A979A4
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineTrackedDolly : CinemachineComponentBase // TypeDefIndex: 84587
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
		public override bool IsValid { get; } // 0x000000018668A290-0x000000018668A310 
		public override CinemachineCore.Stage Stage { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		private Vector3 AngularDamping { get; } // 0x000000018587EED0-0x000000018587EF00 
	
		// Nested types
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum CameraUpMode // TypeDefIndex: 84585
		{
			Default = 0,
			Path = 1,
			PathNoRoll = 2,
			FollowTarget = 3,
			FollowTargetNoRoll = 4
		}
	
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct AutoDolly // TypeDefIndex: 84586
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
			public AutoDolly(bool enabled, float positionOffset, int searchRadius, int stepsPerSegment); // 0x0000000187234E90-0x0000000187234EB0
		}
	
		// Constructors
		public CinemachineTrackedDolly(); // 0x0000000185D91520-0x0000000185D915B0
	
		// Methods
		public override float GetMaxDampTime(); // 0x0000000188A97A08-0x0000000188A97A60
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x000000018587D080-0x000000018587D8E0
		private Quaternion GetCameraOrientationAtPathPoint(Quaternion pathOrientation, Vector3 up); // 0x000000018587ED70-0x000000018587EEB0
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineTransposer : CinemachineComponentBase // TypeDefIndex: 84590
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
		public bool HideOffsetInInspector { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225DFF0-0x000000018225E000 0x000000018225E000-0x000000018225E010
		public Vector3 EffectiveOffset { get; } // 0x0000000188A98A9C-0x0000000188A98AD4 
		public override bool IsValid { get; } // 0x000000018662AB20-0x000000018662ABA0 
		public override CinemachineCore.Stage Stage { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		protected Vector3 Damping { get; } // 0x0000000188A98A78-0x0000000188A98A9C 
		protected Vector3 AngularDamping { get; } // 0x0000000188A98A00-0x0000000188A98A78 
	
		// Nested types
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum BindingMode // TypeDefIndex: 84588
		{
			LockToTargetOnAssign = 0,
			LockToTargetWithWorldUp = 1,
			LockToTargetNoRoll = 2,
			LockToTarget = 3,
			WorldSpace = 4,
			SimpleFollowWithWorldUp = 5
		}
	
		public enum AngularDampingMode // TypeDefIndex: 84589
		{
			Euler = 0,
			Quaternion = 1
		}
	
		// Constructors
		public CinemachineTransposer(); // 0x0000000185D915B0-0x0000000185D91670
	
		// Methods
		protected virtual void OnValidate(); // 0x0000000188A9821C-0x0000000188A9824C
		public override float GetMaxDampTime(); // 0x0000000188A97BF8-0x0000000188A97C78
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x0000000186436B30-0x0000000186436BA0
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x0000000188A9815C-0x0000000188A9821C
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x0000000188A97A60-0x0000000188A97BF8
		protected void InitPrevFrameStateInfo(ref CameraState curState, float deltaTime); // 0x0000000186436BA0-0x0000000186436CF0
		protected void TrackTarget(float deltaTime, Vector3 up, Vector3 desiredCameraOffset, out Vector3 outTargetPosition, out Quaternion outTargetOrient); // 0x0000000188A9824C-0x0000000188A98A00
		protected Vector3 GetOffsetForMinimumTargetDistance(Vector3 dampedTargetPos, Vector3 cameraOffset, Vector3 cameraFwd, Vector3 up, Vector3 actualTargetPos); // 0x0000000188A97C78-0x0000000188A98048
		public virtual Vector3 GetTargetCameraPosition(Vector3 worldUp); // 0x0000000188A98048-0x0000000188A9815C
		public Quaternion GetReferenceOrientation(Vector3 worldUp); // 0x0000000186436CF0-0x0000000186436DD0
	}

	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public struct AxisState // TypeDefIndex: 84594
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
		private const float Epsilon = 0.0001f; // Metadata: 0x026445F1
		private IInputAxisProvider m_InputAxisProvider; // 0x60
		private int m_InputAxisIndex; // 0x68
		[CompilerGenerated]
		private bool _ValueRangeLocked_k__BackingField; // 0x6C
		[CompilerGenerated]
		private bool _HasRecentering_k__BackingField; // 0x6D
	
		// Properties
		public bool ValueRangeLocked { [CompilerGenerated] set; } // 0x0000000187234ED0-0x0000000187234EE0
		public bool HasRecentering { [CompilerGenerated] set; } // 0x0000000187234EC0-0x0000000187234ED0
	
		// Nested types
		public enum SpeedMode // TypeDefIndex: 84591
		{
			MaxSpeed = 0,
			InputValueGain = 1
		}
	
		public interface IInputAxisProvider // TypeDefIndex: 84592
		{
			// Methods
			float GetAxisValue(int axis);
		}
	
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct Recentering // TypeDefIndex: 84593
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
			public Recentering(bool enabled, float waitTime, float recenteringTime); // 0x0000000187235050-0x0000000187235070
	
			// Methods
			public void Validate(); // 0x0000000188A9A7E4-0x0000000188A9A804
			public void CancelRecentering(); // 0x0000000188A9A5C8-0x0000000188A9A61C
			public void DoRecentering(ref AxisState axis, float deltaTime, float recenterTarget); // 0x0000000188A9A61C-0x0000000188A9A7BC
			internal bool LegacyUpgrade(ref int heading, ref int velocityFilter); // 0x0000000188A9A7BC-0x0000000188A9A7E4
		}
	
		// Constructors
		public AxisState(float minValue, float maxValue, bool wrap, bool rangeLocked, float maxSpeed, float accelTime, float decelTime, string name, bool invert); // 0x0000000188A94894-0x0000000188A94974
	
		// Methods
		public void Validate(); // 0x0000000188A9484C-0x0000000188A94894
		public void Reset(); // 0x0000000187234EB0-0x0000000187234EC0
		public void SetInputAxisProvider(int axis, IInputAxisProvider provider); // 0x0000000188A94428-0x0000000188A94438
		public bool Update(float deltaTime); // 0x0000000188A94438-0x0000000188A9484C
		private float ClampValue(float v); // 0x0000000188A9415C-0x0000000188A941CC
		private bool MaxSpeedUpdate(float input, float deltaTime); // 0x0000000188A94244-0x0000000188A94428
		private float GetMaxSpeed(); // 0x0000000188A941CC-0x0000000188A94244
	}

	public struct CameraState // TypeDefIndex: 84598
	{
		// Fields
		public HGDOFParams DofParams; // 0x00
		public HGDOFParams DofOverrideParams; // 0x20
		public float DofOverrideWeight; // 0x40
		public LensSettings Lens; // 0x44
		public Vector3 ReferenceUp; // 0x74
		public Vector3 ReferenceLookAt; // 0x80
		public Vector3 Pivot; // 0x8C
		public Vector3 NoOffsetPivot; // 0x98
		public static Vector3 kNoPoint; // 0x00
		public Vector3 RawPosition; // 0xA4
		public Quaternion RawOrientation; // 0xB0
		public Vector3 PositionDampingBypass; // 0xC0
		public float ShotQuality; // 0xCC
		public Vector3 PositionCorrection; // 0xD0
		public Quaternion OrientationCorrection; // 0xDC
		public BlendHintValue BlendHint; // 0xEC
		private CustomBlendable mCustom0; // 0xF0
		private CustomBlendable mCustom1; // 0x100
		private CustomBlendable mCustom2; // 0x110
		private CustomBlendable mCustom3; // 0x120
		private List<CustomBlendable> m_CustomOverflow; // 0x130
		[CompilerGenerated]
		private int _NumCustomBlendables_k__BackingField; // 0x138
	
		// Properties
		public bool HasLookAt { get; } // 0x0000000187834518-0x0000000187834570 
		public Vector3 CorrectedPosition { get; } // 0x000000018522F9A0-0x000000018522FA10 
		public Quaternion CorrectedOrientation { get; } // 0x0000000185231ED0-0x0000000185231F20 
		public Vector3 FinalPosition { get; } // 0x000000018522F9A0-0x000000018522FA10 
		public Quaternion FinalOrientation { get; } // 0x0000000185609200-0x0000000185609280 
		public static CameraState Default { get; } // 0x0000000185606000-0x0000000185606150 
		public int NumCustomBlendables { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233DE0-0x0000000187233DF0 0x0000000187234FB0-0x0000000187234FC0
	
		// Nested types
		public struct HGDOFParams // TypeDefIndex: 84595
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
	
		public enum BlendHintValue // TypeDefIndex: 84596
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
	
		public struct CustomBlendable // TypeDefIndex: 84597
		{
			// Fields
			public UnityEngine.Object m_Custom; // 0x00
			public float m_Weight; // 0x08
	
			// Constructors
			public CustomBlendable(UnityEngine.Object custom, float weight); // 0x0000000187835DCC-0x0000000187835DE8
		}
	
		// Constructors
		static CameraState(); // 0x00000001871FA3D0-0x00000001871FA420
	
		// Methods
		internal void ResolveDOFOverride(); // 0x0000000188A95A08-0x0000000188A95B08
		public CustomBlendable GetCustomBlendable(int index); // 0x0000000188A9591C-0x0000000188A95A08
		private int FindCustomBlendable(UnityEngine.Object custom); // 0x0000000188A95798-0x0000000188A9591C
		public void AddCustomBlendable(CustomBlendable b); // 0x0000000188A955EC-0x0000000188A95798
		public static CameraState Lerp([IsReadOnly] in CameraState stateA, [IsReadOnly] in CameraState stateB, float t); // 0x0000000184FB4350-0x0000000184FB5CA0
		private static float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t); // 0x0000000186865210-0x00000001868653A0
		private static Vector3 ApplyPosBlendHint(Vector3 posA, BlendHintValue hintA, Vector3 posB, BlendHintValue hintB, Vector3 original, Vector3 blended); // 0x0000000184FB5CD0-0x0000000184FB5D00
		private static Quaternion ApplyRotBlendHint(Quaternion rotA, BlendHintValue hintA, Quaternion rotB, BlendHintValue hintB, Quaternion original, Quaternion blended); // 0x0000000184FB5CA0-0x0000000184FB5CD0
		private Vector3 InterpolatePosition(Vector3 posA, Vector3 pivotA, Vector3 posB, Vector3 pivotB, float t, ref int positionCylindricalDir); // 0x0000000184FB6810-0x0000000184FB6C70
	}

	public class CinemachineBlend // TypeDefIndex: 84599
	{
		// Fields
		private ICinemachineCamera m_CamA; // 0x10
		public ICinemachineCamera CamB; // 0x18
		public bool useSimpleInertialization; // 0x20
		public bool InitStateGot; // 0x21
		public CameraState InitStateA; // 0x28
		public CameraState CurrStateA; // 0x168
		public CameraState InitStateB; // 0x2A8
		public AnimationCurve BlendCurve; // 0x3E8
		public float TimeInBlend; // 0x3F0
		public float Duration; // 0x3F4
	
		// Properties
		public ICinemachineCamera CamA { get; set; } // 0x00000001829260F0-0x0000000182926100 0x00000001856087D0-0x0000000185608830
		public float BlendWeight { get; } // 0x0000000185227C20-0x0000000185227CA0 
		public bool IsValid { get; } // 0x0000000185227CD0-0x0000000185227D00 
		public bool IsComplete { get; } // 0x0000000185227CA0-0x0000000185227CD0 
		public string Description { get; } // 0x0000000188A95B08-0x0000000188A95CB0 
		public CameraState State { get; } // 0x00000001856071B0-0x0000000185607820 
	
		// Constructors
		public CinemachineBlend(ICinemachineCamera a, ICinemachineCamera b, AnimationCurve curve, float duration, float t); // 0x0000000185518980-0x00000001855189F0
	
		// Methods
		public void StartSimpleInertialization(); // 0x0000000187234FC0-0x0000000187234FD0
		public bool Uses(ICinemachineCamera cam); // 0x0000000185607120-0x00000001856071B0
		public void UpdateCameraState(Vector3 worldUp, float deltaTime); // 0x0000000185603560-0x0000000185603E00
	}

	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public struct CinemachineBlendDefinition // TypeDefIndex: 84601
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
		public float BlendTime { get; } // 0x00000001852296F0-0x0000000185229700 
		public AnimationCurve BlendCurve { get; } // 0x000000018522A730-0x000000018522A7B0 
	
		// Nested types
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum Style // TypeDefIndex: 84600
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
		public CinemachineBlendDefinition(Style style, float time); // 0x0000000187836774-0x00000001878367A0
	
		// Methods
		private void CreateStandardCurves(); // 0x00000001852290C0-0x00000001852295E0
	}

	internal class StaticPointVirtualCamera : ICinemachineCamera // TypeDefIndex: 84602
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
		public string Name { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public int Priority { [CompilerGenerated] get; } // 0x00000001844AF510-0x00000001844AF520 
		public Transform LookAt { [CompilerGenerated] get; } // 0x000000018225E800-0x000000018225E810 
		public Transform Follow { [CompilerGenerated] get; } // 0x0000000182262130-0x0000000182262140 
		public CameraState State { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187234F10-0x0000000187234FB0 0x0000000188A95568-0x0000000188A955EC
		public GameObject VirtualCameraGameObject { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public bool IsValid { get; } // 0x00000001851A4410-0x00000001851A4420 
		public ICinemachineCamera ParentCamera { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	
		// Constructors
		public StaticPointVirtualCamera([IsReadOnly] in CameraState state, string name); // 0x0000000188A9AEF8-0x0000000188A9B010
	
		// Methods
		public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x02644609 */); // 0x00000001843FFFF0-0x0000000184400000
		public void UpdateCameraState(Vector3 worldUp, float deltaTime); // 0x0000000186805BA0-0x0000000186805BB0
		public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal class BlendSourceVirtualCamera : ICinemachineCamera // TypeDefIndex: 84603
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
		public CinemachineBlend Blend { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public string Name { get; } // 0x0000000188A9553C-0x0000000188A95568 
		public int Priority { [CompilerGenerated] get; } // 0x00000001844AF510-0x00000001844AF520 
		public Transform LookAt { [CompilerGenerated] get; } // 0x000000018225E800-0x000000018225E810 
		public Transform Follow { [CompilerGenerated] get; } // 0x0000000182262130-0x0000000182262140 
		public CameraState State { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187234F10-0x0000000187234FB0 0x0000000188A95568-0x0000000188A955EC
		public GameObject VirtualCameraGameObject { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public bool IsValid { get; } // 0x0000000188A95524-0x0000000188A9553C 
		public ICinemachineCamera ParentCamera { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	
		// Constructors
		public BlendSourceVirtualCamera(CinemachineBlend blend); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0264460A */); // 0x0000000188A95420-0x0000000188A95440
		public void UpdateCameraState(Vector3 worldUp, float deltaTime); // 0x0000000188A95440-0x0000000188A95524
		public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineBlending.html")]
	public sealed class CinemachineBlenderSettings : ScriptableObject // TypeDefIndex: 84606
	{
		// Fields
		[Tooltip("The array containing explicitly defined blends between two Virtual Cameras")]
		public CustomBlend[] m_CustomBlends; // 0x18
		public CustomBlendGroup[] m_CustomBlendGroups; // 0x20
		public const string kBlendFromAnyCameraLabel = "**ANY CAMERA**"; // Metadata: 0x0264460B
	
		// Nested types
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct CustomBlend // TypeDefIndex: 84604
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
		public class CustomBlendGroup // TypeDefIndex: 84605
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
			public CustomBlendGroup(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public CinemachineBlenderSettings(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		public CinemachineBlendDefinition GetBlendForVirtualCameras(string fromCameraName, string toCameraName, CinemachineBlendDefinition defaultBlend); // 0x0000000185228D40-0x00000001852290C0
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public abstract class CinemachineComponentBase : MonoBehaviour // TypeDefIndex: 84607
	{
		// Fields
		protected const float Epsilon = 0.0001f; // Metadata: 0x0264461A
		private CinemachineVirtualCameraBase m_vcamOwner; // 0x18
	
		// Properties
		public CinemachineVirtualCameraBase VirtualCamera { get; } // 0x000000018522EB20-0x000000018522ED40 
		public Transform FollowTarget { get; } // 0x000000018522E310-0x000000018522E680 
		public Transform LookAtTarget { get; } // 0x000000018522E680-0x000000018522E9F0 
		public ICinemachineTargetGroup AbstractFollowTargetGroup { get; } // 0x0000000188A95CB0-0x0000000188A95CD4 
		public CinemachineTargetGroup FollowTargetGroup { get; } // 0x0000000188A95CF8-0x0000000188A95D3C 
		public Vector3 FollowTargetPosition { get; } // 0x00000001854A6DA0-0x00000001854A6F20 
		public Quaternion FollowTargetRotation { get; } // 0x00000001854A6C30-0x00000001854A6DA0 
		public ICinemachineTargetGroup AbstractLookAtTargetGroup { get; } // 0x0000000188A95CD4-0x0000000188A95CF8 
		public CinemachineTargetGroup LookAtTargetGroup { get; } // 0x0000000188A95D3C-0x0000000188A95D80 
		public Vector3 LookAtTargetPosition { get; } // 0x0000000188A95D80-0x0000000188A95F1C 
		public Quaternion LookAtTargetRotation { get; } // 0x0000000184FB2F00-0x0000000184FB3070 
		public CameraState VcamState { get; } // 0x0000000188A95F1C-0x0000000188A96098 
		public abstract bool IsValid { get; }
		public abstract CinemachineCore.Stage Stage { get; }
		public virtual bool BodyAppliesAfterAim { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public virtual bool RequiresUserInput { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		protected CinemachineComponentBase(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public virtual void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime); // 0x0000000186805BA0-0x0000000186805BB0
		public abstract void MutateCameraState(ref CameraState curState, float deltaTime);
		public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams); // 0x00000001843FFFF0-0x0000000184400000
		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual float GetMaxDampTime(); // 0x0000000187234CD0-0x0000000187234CE0
	}

	public interface ICinemachineDOFOverrideSource // TypeDefIndex: 84608
	{
		// Methods
		bool TryGetDOFOverride(out CameraState.HGDOFParams dofParams, out float weight);
	}

	public sealed class CinemachineCore // TypeDefIndex: 84615
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
		private ICinemachineDOFOverrideSource mDOFOverrideSource; // 0x10
		private List<CinemachineBrain> mActiveBrains; // 0x18
		private List<CinemachineVirtualCameraBase> mActiveCameras; // 0x20
		private bool m_ActiveCamerasAreSorted; // 0x28
		private int m_ActivationSequence; // 0x2C
		private List<List<CinemachineVirtualCameraBase>> mAllCameras; // 0x30
		private CinemachineVirtualCameraBase mRoundRobinVcamLastFrame; // 0x38
		private static float s_LastUpdateTime; // 0x48
		private static int s_FixedFrameCount; // 0x4C
		private Dictionary<CinemachineVirtualCameraBase, UpdateStatus> mUpdateStatus; // 0x40
		internal UpdateFilter m_CurrentUpdateFilter; // 0x48
	
		// Properties
		public static CinemachineCore Instance { get; } // 0x0000000185605C90-0x0000000185605D80 
		public static float DeltaTime { get; } // 0x0000000188A964CC-0x0000000188A9653C 
		public static float CurrentTime { get; } // 0x0000000185603500-0x0000000185603560 
		public int BrainCount { get; } // 0x0000000185606360-0x0000000185606380 
		public int VirtualCameraCount { get; } // 0x0000000185605F90-0x0000000185605FB0 
	
		// Nested types
		public enum Stage // TypeDefIndex: 84609
		{
			Body = 0,
			Aim = 1,
			Noise = 2,
			Finalize = 3
		}
	
		public delegate float AxisInputDelegate(string axisName); // TypeDefIndex: 84610; 0x0000000185B78EA0-0x0000000185B78EB0
	
		public delegate CinemachineBlendDefinition GetBlendOverrideDelegate(ICinemachineCamera fromVcam, ICinemachineCamera toVcam, CinemachineBlendDefinition defaultBlend, MonoBehaviour owner); // TypeDefIndex: 84611; 0x0000000188A9A308-0x0000000188A9A378
	
		private class UpdateStatus // TypeDefIndex: 84612
		{
			// Fields
			public int lastUpdateFrame; // 0x10
			public int lastUpdateFixedFrame; // 0x14
			public UpdateTracker.UpdateClock lastUpdateMode; // 0x18
			public float lastUpdateDeltaTime; // 0x1C
	
			// Constructors
			public UpdateStatus(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		internal enum UpdateFilter // TypeDefIndex: 84613
		{
			Fixed = 0,
			Late = 1,
			Smart = 8,
			SmartFixed = 8,
			SmartLate = 9
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 84614
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<CinemachineVirtualCameraBase> __9__34_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E5C60-0x00000001871E5CC0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetVirtualCamera_b__34_0(CinemachineVirtualCameraBase x, CinemachineVirtualCameraBase y); // 0x0000000186B0EC10-0x0000000186B0EC50
		}
	
		// Constructors
		public CinemachineCore(); // 0x0000000186FCB9B0-0x0000000186FCBAC0
		static CinemachineCore(); // 0x0000000185518620-0x0000000185518820
	
		// Methods
		public void SetDOFOverrideSource(ICinemachineDOFOverrideSource source); // 0x0000000184FD2410-0x0000000184FD2420
		public void ClearDOFOverrideSource(ICinemachineDOFOverrideSource source); // 0x0000000188A96098-0x0000000188A960B0
		internal bool TryGetDOFOverride(out CameraState.HGDOFParams dofParams, out float weight); // 0x0000000185609410-0x0000000185609480
		public CinemachineBrain GetActiveBrain(int index); // 0x0000000185605FB0-0x0000000185606000
		internal void AddActiveBrain(CinemachineBrain brain); // 0x00000001861B34A0-0x00000001861B3510
		internal void RemoveActiveBrain(CinemachineBrain brain); // 0x00000001861B3510-0x00000001861B3570
		public CinemachineVirtualCameraBase GetVirtualCamera(int index); // 0x0000000185605E30-0x0000000185605F90
		internal void AddActiveCamera(CinemachineVirtualCameraBase vcam); // 0x0000000185227070-0x00000001852270B0
		internal void RemoveActiveCamera(CinemachineVirtualCameraBase vcam); // 0x00000001852278C0-0x0000000185227920
		internal void CameraDestroyed(CinemachineVirtualCameraBase vcam); // 0x0000000185226890-0x0000000185226950
		internal void CameraEnabled(CinemachineVirtualCameraBase vcam); // 0x00000001852276C0-0x00000001852277B0
		internal void CameraDisabled(CinemachineVirtualCameraBase vcam); // 0x0000000185227350-0x0000000185227410
		internal void UpdateAllActiveVirtualCameras(int layerMask, Vector3 worldUp, float deltaTime); // 0x0000000185604860-0x0000000185604EA0
		internal void UpdateVirtualCamera(CinemachineVirtualCameraBase vcam, Vector3 worldUp, float deltaTime); // 0x0000000185603E00-0x00000001856040B0
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule(); // 0x000000018710F760-0x000000018710F810
		private static Transform GetUpdateTarget(CinemachineVirtualCameraBase vcam); // 0x0000000188A96200-0x0000000188A962F8
		internal UpdateTracker.UpdateClock GetVcamUpdateStatus(CinemachineVirtualCameraBase vcam); // 0x0000000188A962F8-0x0000000188A96378
		public bool IsLive(ICinemachineCamera vcam); // 0x0000000185606150-0x0000000185606360
		public bool IsLiveInBlend(ICinemachineCamera vcam); // 0x0000000188A96378-0x0000000188A96438
		public void GenerateCameraActivationEvent(ICinemachineCamera vcam, ICinemachineCamera vcamFrom); // 0x0000000185227D40-0x0000000185227E60
		public void GenerateCameraCutEvent(ICinemachineCamera vcam); // 0x0000000188A960B0-0x0000000188A96200
		public CinemachineBrain FindPotentialTargetBrain(CinemachineVirtualCameraBase vcam); // 0x0000000185604EA0-0x0000000185605390
		public void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x0000000188A96438-0x0000000188A964CC
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public abstract class CinemachineExtension : MonoBehaviour // TypeDefIndex: 84616
	{
		// Fields
		protected const float Epsilon = 0.0001f; // Metadata: 0x02644627
		private CinemachineVirtualCameraBase m_vcamOwner; // 0x18
		private Dictionary<ICinemachineCamera, object> mExtraState; // 0x20
	
		// Properties
		public CinemachineVirtualCameraBase VirtualCamera { get; } // 0x00000001851AE040-0x00000001851AE0E0 
		public virtual bool RequiresUserInput { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		protected CinemachineExtension(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		protected virtual void Awake(); // 0x0000000186EA5B10-0x0000000186EA5B20
		protected virtual void OnEnable(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnDestroy(); // 0x00000001870B4880-0x00000001870B4890
		internal void EnsureStarted(); // 0x0000000186EA5B10-0x0000000186EA5B20
		protected virtual void ConnectToVcam(bool connect); // 0x00000001851ADE80-0x00000001851AE040
		public virtual void PrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState curState, float deltaTime); // 0x0000000186805BA0-0x0000000186805BB0
		public void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x0000000187835DF8-0x0000000187835E18
		protected abstract void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime);
		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x00000001843FFFF0-0x0000000184400000
		public virtual float GetMaxDampTime(); // 0x0000000187234CD0-0x0000000187234CE0
		protected T GetExtraState<T>(ICinemachineCamera vcam)
			where T : class, new();
		protected List<T> GetAllExtraStates<T>()
			where T : class, new();
	}

	public abstract class CinemachinePathBase : MonoBehaviour // TypeDefIndex: 84619
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
		public float PathLength { get; } // 0x000000018587DB20-0x000000018587DBD0 
	
		// Nested types
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public class Appearance // TypeDefIndex: 84617
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
			public Appearance(); // 0x0000000186674340-0x0000000186674380
		}
	
		public enum PositionUnits // TypeDefIndex: 84618
		{
			PathUnits = 0,
			Distance = 1,
			Normalized = 2
		}
	
		// Constructors
		protected CinemachinePathBase(); // 0x00000001866742D0-0x0000000186674340
	
		// Methods
		public virtual float StandardizePos(float pos); // 0x000000018587E850-0x000000018587E8C0
		public abstract Vector3 EvaluatePosition(float pos);
		public abstract Vector3 EvaluateTangent(float pos);
		public abstract Quaternion EvaluateOrientation(float pos);
		public virtual float FindClosestPoint(Vector3 p, int startSegment, int searchRadius, int stepsPerSegment); // 0x0000000188A9746C-0x0000000188A97780
		public float MinUnit(PositionUnits units); // 0x0000000188A9787C-0x0000000188A978A4
		public float MaxUnit(PositionUnits units); // 0x000000018587EEB0-0x000000018587EED0
		public virtual float StandardizeUnit(float pos, PositionUnits units); // 0x000000018587D8E0-0x000000018587D960
		public Vector3 EvaluatePositionAtUnit(float pos, PositionUnits units); // 0x000000018587DD80-0x000000018587DDF0
		public Vector3 EvaluateTangentAtUnit(float pos, PositionUnits units); // 0x0000000188A97418-0x0000000188A9746C
		public Quaternion EvaluateOrientationAtUnit(float pos, PositionUnits units); // 0x000000018587DDF0-0x000000018587DE60
		public virtual void InvalidateDistanceCache(); // 0x0000000186D3AA10-0x0000000186D3AA40
		public bool DistanceCacheIsValid(); // 0x000000018587DBD0-0x000000018587DC50
		public float StandardizePathDistance(float distance); // 0x000000018587D960-0x000000018587D9E0
		public float ToNativePathUnits(float pos, PositionUnits units); // 0x000000018587D9E0-0x000000018587DB20
		public float FromPathNativeUnits(float pos, PositionUnits units); // 0x0000000188A97780-0x0000000188A9787C
		private void ResamplePath(int stepsPerSegment); // 0x000000018587EF50-0x000000018587F380
	}

	public sealed class AxisStatePropertyAttribute : PropertyAttribute // TypeDefIndex: 84620
	{
		// Constructors
		public AxisStatePropertyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public sealed class OrbitalTransposerHeadingPropertyAttribute : PropertyAttribute // TypeDefIndex: 84621
	{
		// Constructors
		public OrbitalTransposerHeadingPropertyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public sealed class VcamTargetPropertyAttribute : PropertyAttribute // TypeDefIndex: 84622
	{
		// Constructors
		public VcamTargetPropertyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public sealed class CinemachineBlendDefinitionPropertyAttribute : PropertyAttribute // TypeDefIndex: 84623
	{
		// Constructors
		public CinemachineBlendDefinitionPropertyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public sealed class SaveDuringPlayAttribute : Attribute // TypeDefIndex: 84624
	{
		// Constructors
		public SaveDuringPlayAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public sealed class NoSaveDuringPlayAttribute : PropertyAttribute // TypeDefIndex: 84625
	{
		// Constructors
		public NoSaveDuringPlayAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public sealed class TagFieldAttribute : PropertyAttribute // TypeDefIndex: 84626
	{
		// Constructors
		public TagFieldAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public sealed class NoiseSettingsPropertyAttribute : PropertyAttribute // TypeDefIndex: 84627
	{
		// Constructors
		public NoiseSettingsPropertyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public sealed class CinemachineEmbeddedAssetPropertyAttribute : PropertyAttribute // TypeDefIndex: 84628
	{
		// Fields
		public bool WarnIfNull; // 0x10
	
		// Constructors
		public CinemachineEmbeddedAssetPropertyAttribute(bool warnIfNull = false /* Metadata: 0x0264462E */); // 0x0000000182A819C0-0x0000000182A819D0
	}

	[DocumentationSorting(Level.Undoc)]
	public sealed class DocumentationSortingAttribute : Attribute // TypeDefIndex: 84630
	{
		// Fields
		[CompilerGenerated]
		private Level _Category_k__BackingField; // 0x10
	
		// Properties
		private Level Category { [CompilerGenerated] set; } // 0x0000000182234E90-0x0000000182234EA0
	
		// Nested types
		public enum Level // TypeDefIndex: 84629
		{
			Undoc = 0,
			API = 1,
			UserRef = 2
		}
	
		// Constructors
		public DocumentationSortingAttribute(Level category); // 0x0000000182234E90-0x0000000182234EA0
	}

	[SaveDuringPlay]
	public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera // TypeDefIndex: 84635
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
		[CompilerGenerated]
		private bool _PreserveAimContinuity_k__BackingField; // 0x59
		private bool m_WasStarted; // 0x5A
		private bool mSlaveStatusUpdated; // 0x5B
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
		public int ValidatingStreamVersion { get; private set; } // 0x0000000185227290-0x0000000185227300 0x0000000182271A90-0x0000000182271AA0
		public List<CinemachineExtension> mExtensions { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		public string Name { get; } // 0x0000000187835674-0x000000018783567C 
		public virtual string Description { get; } // 0x0000000188A99158-0x0000000188A99184 
		public int Priority { get; set; } // 0x0000000182271A70-0x0000000182271A80 0x0000000182271AA0-0x0000000182271AB0
		public GameObject VirtualCameraGameObject { get; } // 0x0000000185607EA0-0x0000000185607F30 
		public bool IsValid { get; } // 0x00000001856070B0-0x0000000185607120 
		public abstract CameraState State { get; }
		public ICinemachineCamera ParentCamera { get; } // 0x00000001853A8060-0x00000001853A80A0 
		public abstract Transform LookAt { get; set; }
		public abstract Transform Follow { get; set; }
		public virtual bool PreviousStateIsValid { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EBE0-0x000000018226EBF0 0x000000018226EBF0-0x000000018226EC00
		public bool PreserveAimContinuity { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271B50-0x0000000182271B60 0x0000000182271B60-0x0000000182271B70
		public bool AimPreviousStateIsValid { get; } // 0x00000001861B0650-0x00000001861B0680 
		public bool FollowTargetChanged { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182271B00-0x0000000182271B10 0x0000000182271B10-0x0000000182271B20
		public bool LookAtTargetChanged { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187235000-0x0000000187235010 0x0000000187235010-0x0000000187235020
		public ICinemachineTargetGroup AbstractFollowTargetGroup { get; } // 0x00000001828D49D0-0x00000001828D49E0 
		public CinemachineVirtualCameraBase FollowTargetAsVcam { get; } // 0x00000001829CD170-0x00000001829CD180 
		public ICinemachineTargetGroup AbstractLookAtTargetGroup { get; } // 0x0000000187232C70-0x0000000187232C80 
		public CinemachineVirtualCameraBase LookAtTargetAsVcam { get; } // 0x0000000182271B70-0x0000000182271B80 
	
		// Nested types
		public enum StandbyUpdateMode // TypeDefIndex: 84631
		{
			Never = 0,
			Always = 1,
			RoundRobin = 2
		}
	
		public enum BlendHint // TypeDefIndex: 84632
		{
			None = 0,
			SphericalPosition = 1,
			CylindricalPosition = 2,
			ScreenSpaceAimWhenTargetsDiffer = 3
		}
	
		[Serializable]
		public struct TransitionParams // TypeDefIndex: 84633
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
		private sealed class __c // TypeDefIndex: 84634
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<CinemachineExtension, bool> __9__73_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000188A9B13C-0x0000000188A9B1A0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _RequiresUserInput_b__73_0(CinemachineExtension extension); // 0x0000000188A9B010-0x0000000188A9B068
		}
	
		// Constructors
		protected CinemachineVirtualCameraBase(); // 0x00000001864CDDB0-0x00000001864CDE40
	
		// Methods
		public virtual float GetMaxDampTime(); // 0x0000000188A98ED0-0x0000000188A98F6C
		public float DetachedFollowTargetDamp(float initial, float dampTime, float deltaTime); // 0x0000000188A98B5C-0x0000000188A98BB4
		public Vector3 DetachedFollowTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime); // 0x00000001854A78E0-0x00000001854A7B70
		public Vector3 DetachedFollowTargetDamp(Vector3 initial, float dampTime, float deltaTime); // 0x0000000188A98AD4-0x0000000188A98B5C
		public float DetachedLookAtTargetDamp(float initial, float dampTime, float deltaTime); // 0x000000018522B890-0x000000018522B990
		public Vector3 DetachedLookAtTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime); // 0x0000000188A98BB4-0x0000000188A98CA8
		public Vector3 DetachedLookAtTargetDamp(Vector3 initial, float dampTime, float deltaTime); // 0x0000000188A98CA8-0x0000000188A98D30
		public virtual void AddExtension(CinemachineExtension extension); // 0x00000001851AE0E0-0x00000001851AE1C0
		public virtual void RemoveExtension(CinemachineExtension extension); // 0x00000001851ADE20-0x00000001851ADE80
		protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime); // 0x00000001853A7720-0x00000001853A7AB0
		protected void InvokePrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState newState, float deltaTime); // 0x00000001853A5240-0x00000001853A5490
		protected bool InvokeOnTransitionInExtensions(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x00000001852754A0-0x0000000185275630
		protected void ApplyPositionBlendMethod(ref CameraState state, BlendHint hint); // 0x000000018522B6D0-0x000000018522B6E0
		public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x02644632 */); // 0x00000001843FFFF0-0x0000000184400000
		public void UpdateCameraState(Vector3 worldUp, float deltaTime); // 0x00000001856040B0-0x0000000185604130
		public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime);
		public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime); // 0x0000000185275460-0x00000001852754A0
		protected virtual void OnDestroy(); // 0x0000000185226820-0x0000000185226890
		protected virtual void OnTransformParentChanged(); // 0x0000000185226950-0x00000001852269F0
		protected virtual void Start(); // 0x0000000187188E50-0x0000000187188E60
		internal virtual bool RequiresUserInput(); // 0x0000000188A99040-0x0000000188A99158
		internal void EnsureStarted(); // 0x0000000188A98D30-0x0000000188A98DC0
		public AxisState.IInputAxisProvider GetInputAxisProvider(); // 0x0000000188A98E38-0x0000000188A98ED0
		protected virtual void OnValidate(); // 0x0000000188A98FEC-0x0000000188A99040
		protected virtual void OnEnable(); // 0x0000000185227410-0x0000000185227580
		protected virtual void OnDisable(); // 0x0000000185227300-0x0000000185227350
		protected virtual void Update(); // 0x0000000186365420-0x0000000186365440
		private void UpdateSlaveStatus(); // 0x0000000185227600-0x00000001852276C0
		public Transform ResolveLookAt(Transform localLookAt); // 0x000000018522EA00-0x000000018522EB20
		public Transform ResolveFollow(Transform localFollow); // 0x000000018522ED50-0x000000018522EE70
		private void UpdateVcamPoolStatus(); // 0x00000001852277B0-0x00000001852278C0
		public void MoveToTopOfPrioritySubqueue(); // 0x0000000188A98F6C-0x0000000188A98F74
		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x0000000188A98F74-0x0000000188A98FEC
		public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot); // 0x0000000188A98DC0-0x0000000188A98E38
		protected CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, CinemachineBlendDefinition blendDef, CinemachineBlend activeBlend); // 0x0000000185228720-0x0000000185228880
		protected CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens); // 0x0000000185604480-0x0000000185604860
		private void InvalidateCachedTargets(); // 0x0000000185227580-0x0000000185227600
		protected void UpdateTargetCache(); // 0x000000018522CF00-0x000000018522D430
		public object GetCinemachineComponent<T>();
	}

	internal class ConfinerOven // TypeDefIndex: 84641
	{
		// Fields
		private float m_MinFrustumHeightWithBones; // 0x10
		private List<List<IntPoint>> m_OriginalPolygon; // 0x18
		private List<List<IntPoint>> m_Skeleton; // 0x20
		private const long k_FloatToIntScaler = 100000; // Metadata: 0x0264463A
		private const float k_IntToFloatScaler = 1E-05f; // Metadata: 0x02644642
		private const float k_MinStepSize = 0.005f; // Metadata: 0x02644646
		private Rect m_PolygonRect; // 0x28
		private AspectStretcher m_AspectStretcher; // 0x38
		private float m_maxComputationTimeForFullSkeletonBakeInSeconds; // 0x44
		[CompilerGenerated]
		private BakingState _State_k__BackingField; // 0x48
		public float m_BakeProgress; // 0x4C
		private BakingStateCache m_Cache; // 0x50
	
		// Properties
		public BakingState State { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872330A0-0x00000001872330B0 0x0000000185E120B0-0x0000000185E120C0
	
		// Nested types
		public class BakedSolution // TypeDefIndex: 84636
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
			public float FrustumHeight { [CompilerGenerated] get; } // 0x0000000187232D00-0x0000000187232D10 
	
			// Constructors
			public BakedSolution(float aspectRatio, float frustumHeight, bool hasBones, Rect polygonBounds, List<List<IntPoint>> originalPolygon, List<List<IntPoint>> solution); // 0x0000000188A95364-0x0000000188A95420
	
			// Methods
			public bool IsValid(float frustumHeight); // 0x0000000188A9533C-0x0000000188A95364
			public Vector2 ConfinePoint([IsReadOnly] in Vector2 pointToConfine); // 0x0000000188A949F4-0x0000000188A94DE0
			private bool IsInsideOriginal(IntPoint p); // 0x0000000188A952A0-0x0000000188A9533C
			private static float ClosestPointOnSegment(IntPoint p, IntPoint s0, IntPoint s1); // 0x0000000188A94974-0x0000000188A949F4
			private static IntPoint IntPointLerp(IntPoint a, IntPoint b, float lerp); // 0x0000000188A9520C-0x0000000188A952A0
			private bool DoesIntersectOriginal(IntPoint l1, IntPoint l2); // 0x0000000188A94DE0-0x0000000188A94FE8
			private static int FindIntersection([IsReadOnly] in IntPoint p1, [IsReadOnly] in IntPoint p2, [IsReadOnly] in IntPoint p3, [IsReadOnly] in IntPoint p4); // 0x0000000188A94FE8-0x0000000188A9520C
			private static double IntPointDiffSqrMagnitude(IntPoint p1, IntPoint p2); // 0x0000000187234EE0-0x0000000187234F10
		}
	
		private struct AspectStretcher // TypeDefIndex: 84637
		{
			// Fields
			[CompilerGenerated]
			private readonly float _Aspect_k__BackingField; // 0x00
			private readonly float m_InverseAspect; // 0x04
			private readonly float m_CenterX; // 0x08
	
			// Properties
			public float Aspect { [CompilerGenerated] [IsReadOnly] get; } // 0x00000001872342D0-0x00000001872342E0 
	
			// Constructors
			public AspectStretcher(float aspect, float centerX); // 0x0000000187234E70-0x0000000187234E90
	
			// Methods
			public Vector2 Stretch(Vector2 p); // 0x0000000187234E10-0x0000000187234E40
			public Vector2 Unstretch(Vector2 p); // 0x0000000187234E40-0x0000000187234E70
		}
	
		private struct PolygonSolution // TypeDefIndex: 84638
		{
			// Fields
			public List<List<IntPoint>> m_Polygons; // 0x00
			public float m_FrustumHeight; // 0x08
	
			// Properties
			public bool IsEmpty { get; } // 0x00000001850BC1F0-0x00000001850BC200 
	
			// Methods
			public bool StateChanged([IsReadOnly] in List<List<IntPoint>> paths); // 0x0000000188A9A4F4-0x0000000188A9A5C8
		}
	
		public enum BakingState // TypeDefIndex: 84639
		{
			BAKING = 0,
			BAKED = 1,
			TIMEOUT = 2
		}
	
		private struct BakingStateCache // TypeDefIndex: 84640
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
		public ConfinerOven([IsReadOnly] in List<List<Vector2>> inputPath, [IsReadOnly] in float aspectRatio, float maxFrustumHeight); // 0x0000000188A9A230-0x0000000188A9A308
	
		// Methods
		public BakedSolution GetBakedSolution(float frustumHeight); // 0x0000000188A998E4-0x0000000188A99B80
		private void Initialize([IsReadOnly] in List<List<Vector2>> inputPath, [IsReadOnly] in float aspectRatio, float maxFrustumHeight); // 0x0000000188A99CF8-0x0000000188A9A230
		public void BakeConfiner(float maxComputationTimePerFrameInSeconds); // 0x0000000188A99184-0x0000000188A9954C
		private static Rect GetPolygonBoundingBox([IsReadOnly] in List<List<Vector2>> polygons); // 0x0000000188A99B80-0x0000000188A99CF8
		private void ComputeSkeleton([IsReadOnly] in List<PolygonSolution> solutions); // 0x0000000188A9954C-0x0000000188A998E4
	}

	public interface ICinemachineCamera // TypeDefIndex: 84642
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
		bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0264464D */);
		void UpdateCameraState(Vector3 worldUp, float deltaTime);
		void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime);
	}

	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public struct LensSettings // TypeDefIndex: 84644
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
		public bool Orthographic { get; } // 0x0000000184FB2050-0x0000000184FB2070 
		public Vector2 SensorSize { get; } // 0x0000000187235030-0x0000000187235050 
		public float Aspect { get; } // 0x0000000184FB1FF0-0x0000000184FB2050 
		public bool IsPhysicalCamera { get; } // 0x0000000185604460-0x0000000185604480 
	
		// Nested types
		public enum OverrideModes // TypeDefIndex: 84643
		{
			None = 0,
			Orthographic = 1,
			Perspective = 2,
			Physical = 3
		}
	
		// Constructors
		public LensSettings(float verticalFOV, float orthographicSize, float nearClip, float farClip, float dutch); // 0x00000001870ACEB0-0x00000001870ACF00
		static LensSettings(); // 0x00000001870ACE10-0x00000001870ACEB0
	
		// Methods
		public static LensSettings FromCamera(Camera fromCamera); // 0x0000000188A9A378-0x0000000188A9A48C
		public void SnapshotCameraReadOnlyProperties(Camera camera); // 0x0000000185604130-0x0000000185604460
		public static LensSettings Lerp(LensSettings lensA, LensSettings lensB, float t); // 0x0000000184FB5DF0-0x0000000184FB5F50
		public void Validate(); // 0x0000000188A9A48C-0x0000000188A9A4F4
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineNoiseProfiles.html")]
	public sealed class NoiseSettings : SignalSourceAsset // TypeDefIndex: 84647
	{
		// Fields
		[FormerlySerializedAs("m_Position")]
		[Tooltip("These are the noise channels for the virtual camera\'s position. Convincing noise setups typically mix low, medium and high frequencies together, so start with a size of 3")]
		public TransformNoiseParams[] PositionNoise; // 0x18
		[FormerlySerializedAs("m_Orientation")]
		[Tooltip("These are the noise channels for the virtual camera\'s orientation. Convincing noise setups typically mix low, medium and high frequencies together, so start with a size of 3")]
		public TransformNoiseParams[] OrientationNoise; // 0x20
	
		// Properties
		public override float SignalDuration { get; } // 0x0000000187234CD0-0x0000000187234CE0 
	
		// Nested types
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct NoiseParams // TypeDefIndex: 84645
		{
			// Fields
			[Tooltip("The frequency of noise for this channel.  Higher magnitudes vibrate faster.")]
			public float Frequency; // 0x00
			[Tooltip("The amplitude of the noise for this channel.  Larger numbers vibrate higher.")]
			public float Amplitude; // 0x04
			[Tooltip("If checked, then the amplitude and frequency will not be randomized.")]
			public bool Constant; // 0x08
	
			// Methods
			public float GetValueAt(float time, float timeOffset); // 0x00000001857F05E0-0x00000001857F0620
		}
	
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct TransformNoiseParams // TypeDefIndex: 84646
		{
			// Fields
			[Tooltip("Noise definition for X-axis")]
			public NoiseParams X; // 0x00
			[Tooltip("Noise definition for Y-axis")]
			public NoiseParams Y; // 0x0C
			[Tooltip("Noise definition for Z-axis")]
			public NoiseParams Z; // 0x18
	
			// Methods
			public Vector3 GetValueAt(float time, Vector3 timeOffsets); // 0x00000001857F0540-0x00000001857F05E0
		}
	
		// Constructors
		public NoiseSettings(); // 0x0000000186EBEF10-0x0000000186EBEF80
	
		// Methods
		public static Vector3 GetCombinedFilterResults(TransformNoiseParams[] noiseParams, float time, Vector3 timeOffsets); // 0x00000001857F03F0-0x00000001857F0540
		public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot); // 0x00000001857F02B0-0x00000001857F03F0
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.Undoc)]
	public static class RuntimeUtility // TypeDefIndex: 84653
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
		public delegate int OverlapSphereNonAllocDelegate(Vector3 position, float radius, ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 84648; 0x0000000184162450-0x00000001841624A0
	
		public delegate bool RaycastDelegate(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 84649; 0x0000000184160490-0x00000001841604E0
	
		public delegate int RaycastNonAllocDelegate(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 84650; 0x0000000184160490-0x00000001841604E0
	
		public delegate int SphereCastNonAllocDelegate(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 84651; 0x0000000187996BC8-0x0000000187996C44
	
		public delegate bool ComputePenetrationDelegate(ECSColliderResultProxy colliderA, Vector3 positionA, Quaternion rotationA, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance); // TypeDefIndex: 84652; 0x00000001879966D8-0x000000018799679C
	
		// Constructors
		static RuntimeUtility(); // 0x0000000186A25BF0-0x0000000186A25EE0
	
		// Methods
		public static void DestroyObject(UnityEngine.Object obj); // 0x0000000188A9A804-0x0000000188A9A864
		public static bool IsPrefab(GameObject gameObject); // 0x00000001843FFFF0-0x0000000184400000
		public static bool RaycastIgnoreTag(Ray ray, out RaycastHit hitInfo, float rayLength, int layerMask, [IsReadOnly] in string ignoreTag); // 0x0000000184FB3E10-0x0000000184FB4240
		public static int GetColliderOptionsFromHit(RaycastHit hit); // 0x0000000184FB4300-0x0000000184FB4350
		public static bool HasIgnoreColliderOptionFromHit(RaycastHit hit); // 0x0000000184FB4240-0x0000000184FB4300
		public static bool HasIgnoreColliderOptionFromCollider(ECSColliderResultProxy collider); // 0x0000000188A9AC68-0x0000000188A9ACD8
		public static bool SphereCastIgnoreTag(Vector3 rayStart, float radius, Vector3 dir, out RaycastHit hitInfo, float rayLength, int layerMask, [IsReadOnly] in string ignoreTag); // 0x0000000184FB3070-0x0000000184FB38F0
		internal static SphereCollider GetScratchCollider(); // 0x0000000188A9A9E0-0x0000000188A9AC68
		internal static void DestroyScratchCollider(); // 0x0000000188A9A864-0x0000000188A9A9E0
		public static AnimationCurve NormalizeCurve(AnimationCurve curve, bool normalizeX, bool normalizeY); // 0x0000000188A9ACD8-0x0000000188A9AEF8
	}

	public interface ISignalSource6D // TypeDefIndex: 84654
	{
		// Methods
		void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot);
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public abstract class SignalSourceAsset : ScriptableObject, ISignalSource6D // TypeDefIndex: 84655
	{
		// Properties
		public abstract float SignalDuration { get; }
	
		// Constructors
		protected SignalSourceAsset(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		public abstract void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot);
	}

	internal class TargetPositionCache // TypeDefIndex: 84662
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
		public static Mode CacheMode { get; } // 0x0000000188AA00B0-0x0000000188AA00E8 
		public static bool HasCurrentTime { get; } // 0x0000000188AA00E8-0x0000000188AA012C 
	
		// Nested types
		public enum Mode // TypeDefIndex: 84656
		{
			Disabled = 0,
			Record = 1,
			Playback = 2
		}
	
		private class CacheCurve // TypeDefIndex: 84658
		{
			// Fields
			public float StartTime; // 0x10
			public float StepSize; // 0x14
			private List<Item> m_Cache; // 0x18
	
			// Nested types
			public struct Item // TypeDefIndex: 84657
			{
				// Fields
				public Vector3 Pos; // 0x00
				public Quaternion Rot; // 0x0C
	
				// Properties
				public static Item Empty { get; } // 0x0000000188A9F924-0x0000000188A9F94C 
	
				// Methods
				public static Item Lerp(Item a, Item b, float t); // 0x0000000188A9F818-0x0000000188A9F924
			}
	
			// Methods
			public Item Evaluate(float time); // 0x0000000188A9B8D8-0x0000000188A9BA7C
		}
	
		private class CacheEntry // TypeDefIndex: 84660
		{
			// Fields
			public CacheCurve Curve; // 0x10
			private List<RecordingItem> RawItems; // 0x18
	
			// Nested types
			private struct RecordingItem // TypeDefIndex: 84659
			{
				// Fields
				public float Time; // 0x00
				public bool IsCut; // 0x04
				public CacheCurve.Item Item; // 0x08
			}
	
			// Constructors
			public CacheEntry(); // 0x0000000188A9BD14-0x0000000188A9BD8C
	
			// Methods
			public void AddRawItem(float time, bool isCut, Transform target); // 0x0000000188A9BA7C-0x0000000188A9BD14
		}
	
		public struct TimeRange // TypeDefIndex: 84661
		{
			// Fields
			public float Start; // 0x00
			public float End; // 0x04
	
			// Properties
			public bool IsEmpty { get; } // 0x0000000188AA0160-0x0000000188AA016C 
			public static TimeRange Empty { get; } // 0x0000000187235090-0x00000001872350B0 
	
			// Methods
			public bool Contains(float time); // 0x0000000188AA012C-0x0000000188AA0140
			public void Include(float time); // 0x0000000188AA0140-0x0000000188AA0160
		}
	
		// Methods
		public static void ClearCache(); // 0x0000000188A9FFB0-0x0000000188AA00B0
		public static Vector3 GetTargetPosition(Transform target); // 0x0000000185606380-0x0000000185606420
		public static Quaternion GetTargetRotation(Transform target); // 0x0000000185606420-0x0000000185606510
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.Undoc)]
	internal class UpdateTracker // TypeDefIndex: 84665
	{
		// Fields
		private static Dictionary<Transform, UpdateStatus> mUpdateStatus; // 0x00
		private static List<Transform> sToDelete; // 0x08
		private static float mLastUpdateTime; // 0x10
	
		// Nested types
		public enum UpdateClock // TypeDefIndex: 84663
		{
			Fixed = 0,
			Late = 1
		}
	
		private class UpdateStatus // TypeDefIndex: 84664
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
			public UpdateClock PreferredUpdate { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233670-0x0000000187233680 0x0000000187233690-0x00000001872336A0
	
			// Constructors
			public UpdateStatus(int currentFrame, Matrix4x4 pos); // 0x0000000188AA0908-0x0000000188AA0958
	
			// Methods
			public void OnUpdate(int currentFrame, UpdateClock currentClock, Matrix4x4 pos); // 0x0000000188AA07F8-0x0000000188AA0908
		}
	
		// Constructors
		static UpdateTracker(); // 0x0000000187082540-0x0000000187082630
	
		// Methods
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule(); // 0x00000001871D3C30-0x00000001871D3CA0
		private static void UpdateTargets(UpdateClock currentClock); // 0x0000000188AA0BE8-0x0000000188AA0EBC
		public static UpdateClock GetPreferredUpdate(Transform target); // 0x0000000188AA0958-0x0000000188AA0B4C
		public static void OnUpdate(UpdateClock currentClock); // 0x0000000188AA0B4C-0x0000000188AA0BE8
	}

	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineAlternativeInput.html")]
	public class CinemachineInputProvider : MonoBehaviour, AxisState.IInputAxisProvider // TypeDefIndex: 84667
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
		private const int NUM_AXES = 3; // Metadata: 0x02644657
		private InputAction[] m_cachedActions; // 0x30
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 84666
		{
			// Fields
			public InputActionReference aRef; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _ResolveForPlayer_b__1(InputAction x); // 0x0000000188AA016C-0x0000000188AA0228
		}
	
		// Constructors
		public CinemachineInputProvider(); // 0x0000000188A9E990-0x0000000188A9E9B0
	
		// Methods
		public virtual float GetAxisValue(int axis); // 0x0000000188A9E418-0x0000000188A9E4F8
		protected InputAction ResolveForPlayer(int axis, InputActionReference actionRef); // 0x0000000188A9E50C-0x0000000188A9E898
		protected virtual void OnDisable(); // 0x0000000188A9E4F8-0x0000000188A9E50C
		[CompilerGenerated]
		internal static InputAction _ResolveForPlayer_g__GetFirstMatch_7_0([IsReadOnly] in InputUser user, InputActionReference aRef); // 0x0000000188A9E898-0x0000000188A9E990
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/api/Cinemachine.CinemachineTriggerAction.html")]
	[SaveDuringPlay]
	public class CinemachineTriggerAction : MonoBehaviour // TypeDefIndex: 84672
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
		public struct ActionSettings // TypeDefIndex: 84671
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
			public enum Mode // TypeDefIndex: 84668
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
			public class TriggerEvent : UnityEvent // TypeDefIndex: 84669
			{
				// Constructors
				public TriggerEvent(); // 0x000000018548D960-0x000000018548D970
			}
	
			public enum TimeMode // TypeDefIndex: 84670
			{
				FromStart = 0,
				FromEnd = 1,
				BeforeNow = 2,
				AfterNow = 3
			}
	
			// Constructors
			public ActionSettings(Mode action); // 0x0000000188A9B850-0x0000000188A9B8D8
	
			// Methods
			public void Invoke(); // 0x0000000188A9B3E8-0x0000000188A9B850
		}
	
		// Constructors
		public CinemachineTriggerAction(); // 0x0000000188A9ECA4-0x0000000188A9EE14
	
		// Methods
		private bool Filter(GameObject other); // 0x0000000188A9E9B0-0x0000000188A9EA40
		private void InternalDoTriggerEnter(GameObject other); // 0x0000000188A9EA40-0x0000000188A9EAD0
		private void InternalDoTriggerExit(GameObject other); // 0x0000000188A9EAD0-0x0000000188A9EB6C
		private void OnTriggerEnter(Collider other); // 0x0000000188A9EC3C-0x0000000188A9EC70
		private void OnTriggerExit(Collider other); // 0x0000000188A9EC70-0x0000000188A9ECA4
		private void OnCollisionEnter(UnityEngine.Collision other); // 0x0000000188A9EBA0-0x0000000188A9EBD4
		private void OnCollisionExit(UnityEngine.Collision other); // 0x0000000188A9EC08-0x0000000188A9EC3C
		private void OnTriggerEnter2D(Collider2D other); // 0x0000000188A9EC3C-0x0000000188A9EC70
		private void OnTriggerExit2D(Collider2D other); // 0x0000000188A9EC70-0x0000000188A9ECA4
		private void OnCollisionEnter2D(Collision2D other); // 0x0000000188A9EB6C-0x0000000188A9EBA0
		private void OnCollisionExit2D(Collision2D other); // 0x0000000188A9EBD4-0x0000000188A9EC08
		private void OnEnable(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/api/Cinemachine.GroupWeightManipulator.html")]
	[RequireComponent(typeof(CinemachineTargetGroup))]
	public class GroupWeightManipulator : MonoBehaviour // TypeDefIndex: 84673
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
		public GroupWeightManipulator(); // 0x0000000188A9F0B4-0x0000000188A9F104
	
		// Methods
		private void Start(); // 0x0000000188A9EED8-0x0000000188A9EF20
		private void OnValidate(); // 0x0000000188A9EE6C-0x0000000188A9EED8
		private void Update(); // 0x0000000188A9F054-0x0000000188A9F0B4
		private void UpdateWeights(); // 0x0000000188A9EF20-0x0000000188A9F054
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineCollisionImpulseSource.html")]
	[SaveDuringPlay]
	public class CinemachineCollisionImpulseSource : CinemachineImpulseSource // TypeDefIndex: 84674
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
		public CinemachineCollisionImpulseSource(); // 0x0000000188A9C740-0x0000000188A9C79C
	
		// Methods
		private void Start(); // 0x0000000188A9C6D0-0x0000000188A9C740
		private void OnEnable(); // 0x0000000186805BA0-0x0000000186805BB0
		private void OnCollisionEnter(UnityEngine.Collision c); // 0x0000000188A9C640-0x0000000188A9C678
		private void OnTriggerEnter(Collider c); // 0x0000000188A9C6A4-0x0000000188A9C6D0
		private float GetMassAndVelocity(Collider other, ref Vector3 vel); // 0x0000000188A9C398-0x0000000188A9C5CC
		private void GenerateImpactEvent(Collider other, Vector3 vel); // 0x0000000188A9BF78-0x0000000188A9C164
		private void OnCollisionEnter2D(Collision2D c); // 0x0000000188A9C5CC-0x0000000188A9C640
		private void OnTriggerEnter2D(Collider2D c); // 0x0000000188A9C678-0x0000000188A9C6A4
		private float GetMassAndVelocity2D(Collider2D other2d, ref Vector3 vel); // 0x0000000188A9C164-0x0000000188A9C398
		private void GenerateImpactEvent2D(Collider2D other2d, Vector3 vel); // 0x0000000188A9BD8C-0x0000000188A9BF78
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineImpulseFixedSignals.html")]
	public class CinemachineFixedSignal : SignalSourceAsset // TypeDefIndex: 84675
	{
		// Fields
		[Tooltip("The raw signal shape along the X axis")]
		public AnimationCurve m_XCurve; // 0x18
		[Tooltip("The raw signal shape along the Y axis")]
		public AnimationCurve m_YCurve; // 0x20
		[Tooltip("The raw signal shape along the Z axis")]
		public AnimationCurve m_ZCurve; // 0x28
	
		// Properties
		public override float SignalDuration { get; } // 0x0000000185930A60-0x0000000185930AC0 
	
		// Constructors
		public CinemachineFixedSignal(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		private float AxisDuration(AnimationCurve axis); // 0x0000000185930AC0-0x0000000185930B40
		public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot); // 0x00000001869D26C0-0x00000001869D2760
		private float AxisValue(AnimationCurve axis, float time); // 0x00000001869D2760-0x00000001869D27B0
	}

	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public class CinemachineImpulseDefinition // TypeDefIndex: 84681
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
		internal AnimationCurve ImpulseCurve { get; } // 0x0000000188A9D990-0x0000000188A9D9E8 
	
		// Nested types
		public enum ImpulseShapes // TypeDefIndex: 84676
		{
			Custom = 0,
			Recoil = 1,
			Bump = 2,
			Explosion = 3,
			Rumble = 4
		}
	
		public enum ImpulseTypes // TypeDefIndex: 84677
		{
			Uniform = 0,
			Dissipating = 1,
			Propagating = 2,
			Legacy = 3
		}
	
		public enum RepeatMode // TypeDefIndex: 84678
		{
			Stretch = 0,
			Loop = 1
		}
	
		private class SignalSource : ISignalSource6D // TypeDefIndex: 84679
		{
			// Fields
			private CinemachineImpulseDefinition m_Def; // 0x10
			private Vector3 m_Velocity; // 0x18
	
			// Properties
			public float SignalDuration { get; } // 0x0000000188A9FCC0-0x0000000188A9FCE0 
	
			// Constructors
			public SignalSource(CinemachineImpulseDefinition def, Vector3 velocity); // 0x0000000188A9FC90-0x0000000188A9FCC0
	
			// Methods
			public void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot); // 0x0000000188A9FBB8-0x0000000188A9FC90
		}
	
		private class LegacySignalSource : ISignalSource6D // TypeDefIndex: 84680
		{
			// Fields
			private CinemachineImpulseDefinition m_Def; // 0x10
			private Vector3 m_Velocity; // 0x18
			private float m_StartTimeOffset; // 0x24
	
			// Properties
			public float SignalDuration { get; } // 0x00000001856024C0-0x00000001856024F0 
	
			// Constructors
			public LegacySignalSource(CinemachineImpulseDefinition def, Vector3 velocity); // 0x0000000185600EC0-0x0000000185600F40
	
			// Methods
			public void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot); // 0x00000001856022B0-0x00000001856024C0
		}
	
		// Constructors
		public CinemachineImpulseDefinition(); // 0x0000000185CF2A70-0x0000000185CF2B40
	
		// Methods
		public void OnValidate(); // 0x0000000188A9D8B8-0x0000000188A9D990
		private static void CreateStandardShapes(); // 0x0000000188A9CDD4-0x0000000188A9D844
		internal static AnimationCurve GetStandardCurve(ImpulseShapes shape); // 0x0000000188A9D844-0x0000000188A9D8B8
		public void CreateEvent(Vector3 position, Vector3 velocity); // 0x0000000188A9CD94-0x0000000188A9CDD4
		public CinemachineImpulseManager.ImpulseEvent CreateAndReturnEvent(Vector3 position, Vector3 velocity); // 0x0000000185601F80-0x0000000185601FF0
		private CinemachineImpulseManager.ImpulseEvent LegacyCreateAndReturnEvent(Vector3 position, Vector3 velocity); // 0x0000000185601FF0-0x0000000185602220
	}

	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineImpulseListener.html")]
	[SaveDuringPlay]
	public class CinemachineImpulseListener : CinemachineExtension // TypeDefIndex: 84683
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
		public struct ImpulseReaction // TypeDefIndex: 84682
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
			public void ReSeed(); // 0x0000000188A9F794-0x0000000188A9F818
			public bool GetReaction(float deltaTime, Vector3 impulsePos, out Vector3 pos, out Quaternion rot); // 0x000000018560AF50-0x000000018560B0E0
		}
	
		// Constructors
		public CinemachineImpulseListener(); // 0x0000000186C6D300-0x0000000186C6D330
	
		// Methods
		private void Reset(); // 0x0000000188A9D9E8-0x0000000188A9DA4C
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x000000018560A9A0-0x000000018560AC90
	}

	public sealed class CinemachineImpulseChannelPropertyAttribute : PropertyAttribute // TypeDefIndex: 84684
	{
		// Constructors
		public CinemachineImpulseChannelPropertyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public class CinemachineImpulseManager // TypeDefIndex: 84689
	{
		// Fields
		private static CinemachineImpulseManager sInstance; // 0x00
		private List<ImpulseEvent> m_ExpiredEvents; // 0x10
		private List<ImpulseEvent> m_ActiveEvents; // 0x18
		public bool IgnoreTimeScale; // 0x20
	
		// Properties
		public static CinemachineImpulseManager Instance { get; } // 0x000000018560AEE0-0x000000018560AF50 
		public float CurrentTime { get; } // 0x0000000185602BA0-0x0000000185602BE0 
	
		// Nested types
		[Serializable]
		public struct EnvelopeDefinition // TypeDefIndex: 84685
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
			public float Duration { get; } // 0x0000000185602AA0-0x0000000185602AC0 
	
			// Methods
			public static EnvelopeDefinition Default(); // 0x0000000187235070-0x0000000187235090
			public float GetValueAt(float offset); // 0x00000001856025F0-0x00000001856026E0
			public void ChangeStopTime(float offset, bool forceNoDecay); // 0x0000000188A9EE14-0x0000000188A9EE40
			public void Clear(); // 0x00000001867F2FE0-0x00000001867F30E0
			public void Validate(); // 0x0000000188A9EE40-0x0000000188A9EE6C
		}
	
		public class ImpulseEvent // TypeDefIndex: 84688
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
			public bool Expired { get; } // 0x00000001856029F0-0x0000000185602AA0 
	
			// Nested types
			public enum DirectionMode // TypeDefIndex: 84686
			{
				Fixed = 0,
				RotateTowardSource = 1
			}
	
			public enum DissipationMode // TypeDefIndex: 84687
			{
				LinearDecay = 0,
				SoftDecay = 1,
				ExponentialDecay = 2
			}
	
			// Constructors
			internal ImpulseEvent(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Cancel(float time, bool forceNoDecay); // 0x0000000188A9F77C-0x0000000188A9F794
			public float DistanceDecay(float distance); // 0x00000001856029C0-0x00000001856029F0
			public bool GetDecayedSignal(Vector3 listenerPosition, bool use2D, out Vector3 pos, out Quaternion rot); // 0x00000001856026E0-0x00000001856029C0
			public void Clear(); // 0x00000001867F2F80-0x00000001867F2FE0
		}
	
		// Constructors
		private CinemachineImpulseManager(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule(); // 0x000000018721B8E0-0x000000018721B920
		internal static float EvaluateDissipationScale(float spread, float normalizedDistance); // 0x0000000188A9DAE8-0x0000000188A9DB88
		public bool GetImpulseAt(Vector3 listenerLocation, bool distance2D, int channelMask, out Vector3 pos, out Quaternion rot); // 0x000000018560B0E0-0x000000018560B350
		public ImpulseEvent NewImpulseEvent(); // 0x0000000185602220-0x00000001856022B0
		public void AddImpulseEvent(ImpulseEvent e); // 0x0000000185601C20-0x0000000185601CB0
		public void Clear(); // 0x0000000188A9DA4C-0x0000000188A9DAE8
	}

	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineImpulseSourceOverview.html")]
	[SaveDuringPlay]
	public class CinemachineImpulseSource : MonoBehaviour // TypeDefIndex: 84690
	{
		// Fields
		public CinemachineImpulseDefinition m_ImpulseDefinition; // 0x18
		[Header("Default Invocation")]
		[Tooltip("The default direction and force of the Impulse Signal in the absense of any specified overrides.  Overrides can be specified by calling the appropriate GenerateImpulse method in the API.")]
		public Vector3 m_DefaultVelocity; // 0x20
	
		// Constructors
		public CinemachineImpulseSource(); // 0x0000000188A9DE90-0x0000000188A9DF18
	
		// Methods
		private void OnValidate(); // 0x0000000188A9DD80-0x0000000188A9DDA0
		private void Reset(); // 0x0000000188A9DDA0-0x0000000188A9DE90
		public void GenerateImpulseAtPositionWithVelocity(Vector3 position, Vector3 velocity); // 0x0000000188A9DB88-0x0000000188A9DBD4
		public void GenerateImpulseWithVelocity(Vector3 velocity); // 0x0000000188A9DCB4-0x0000000188A9DD28
		public void GenerateImpulseWithForce(float force); // 0x0000000188A9DC14-0x0000000188A9DCB4
		public void GenerateImpulse(); // 0x0000000188A9DD28-0x0000000188A9DD50
		public void GenerateImpulseAt(Vector3 position, Vector3 velocity); // 0x0000000188A9DBD4-0x0000000188A9DC14
		public void GenerateImpulse(Vector3 velocity); // 0x0000000188A9DD58-0x0000000188A9DD80
		public void GenerateImpulse(float force); // 0x0000000188A9DD50-0x0000000188A9DD58
	}

	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/api/Cinemachine.CinemachineIndependentImpulseListener.html")]
	[SaveDuringPlay]
	public class CinemachineIndependentImpulseListener : MonoBehaviour // TypeDefIndex: 84691
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
		public CinemachineIndependentImpulseListener(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void Reset(); // 0x0000000188A9E288-0x0000000188A9E2E4
		private void OnEnable(); // 0x0000000188A9E258-0x0000000188A9E288
		private void Update(); // 0x0000000188A9E2E4-0x0000000188A9E418
		private void LateUpdate(); // 0x0000000188A9DF18-0x0000000188A9E258
	}
}

namespace Cinemachine.PostFX
{
	[AddComponentMenu("")]
	[SaveDuringPlay]
	public class CinemachinePostProcessing : CinemachineExtension // TypeDefIndex: 84692
	{
		// Constructors
		public CinemachinePostProcessing(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AddComponentMenu("")]
	public class CinemachineVolumeSettings : MonoBehaviour // TypeDefIndex: 84693
	{
		// Constructors
		public CinemachineVolumeSettings(); // 0x00000001878364A0-0x00000001878364B8
	}
}

namespace Cinemachine.Utility
{
	public class CinemachineDebug // TypeDefIndex: 84695
	{
		// Fields
		private static HashSet<UnityEngine.Object> mClients; // 0x00
		public static OnGUIDelegate OnGUIHandlers; // 0x08
		private static List<StringBuilder> mAvailableStringBuilders; // 0x10
	
		// Nested types
		public delegate void OnGUIDelegate(); // TypeDefIndex: 84694; 0x0000000185B44B70-0x0000000185B44B80
	
		// Methods
		public static void ReleaseScreenPos(UnityEngine.Object client); // 0x0000000188A9CB24-0x0000000188A9CBBC
		public static Rect GetScreenPos(UnityEngine.Object client, string text, GUIStyle style); // 0x0000000188A9C79C-0x0000000188A9CB24
		public static StringBuilder SBFromPool(); // 0x0000000188A9CCA0-0x0000000188A9CD94
		public static void ReturnToPool(StringBuilder sb); // 0x0000000188A9CBBC-0x0000000188A9CCA0
	}

	public class PositionPredictor // TypeDefIndex: 84696
	{
		// Fields
		private Vector3 m_Velocity; // 0x10
		private Vector3 m_SmoothDampVelocity; // 0x1C
		private Vector3 m_Pos; // 0x28
		private bool m_HavePos; // 0x34
		public float Smoothing; // 0x38
	
		// Constructors
		public PositionPredictor(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void ApplyTransformDelta(Vector3 positionDelta); // 0x0000000188A9FAFC-0x0000000188A9FB50
		public void Reset(); // 0x0000000188A9FB90-0x0000000188A9FBB8
		public void AddPosition(Vector3 pos, float deltaTime, float lookaheadTime); // 0x0000000188A9F94C-0x0000000188A9FAFC
		public Vector3 PredictPositionDelta(float lookaheadTime); // 0x0000000188A9FB50-0x0000000188A9FB90
	}

	public static class Damper // TypeDefIndex: 84697
	{
		// Methods
		public static float Damp(float initial, float dampTime, float deltaTime); // 0x000000018522CBC0-0x000000018522CC70
		public static Vector3 Damp(Vector3 initial, Vector3 dampTime, float deltaTime); // 0x000000018522C380-0x000000018522C4B0
		public static Vector3 Damp(Vector3 initial, float dampTime, float deltaTime); // 0x000000018587DC50-0x000000018587DD80
	}

	public class HeadingTracker // TypeDefIndex: 84699
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
		public int FilterSize { get; } // 0x0000000188A9F760-0x0000000188A9F77C 
	
		// Nested types
		private struct Item // TypeDefIndex: 84698
		{
			// Fields
			public Vector3 velocity; // 0x00
			public float weight; // 0x0C
			public float time; // 0x10
		}
	
		// Constructors
		public HeadingTracker(int filterSize); // 0x0000000188A9F680-0x0000000188A9F760
	
		// Methods
		private void ClearHistory(); // 0x0000000188A9F2C4-0x0000000188A9F2E4
		private static float Decay(float time); // 0x0000000188A9F3AC-0x0000000188A9F3F8
		public void Add(Vector3 velocity); // 0x0000000188A9F104-0x0000000188A9F2C4
		private void PopBottom(); // 0x0000000188A9F4EC-0x0000000188A9F680
		public void DecayHistory(); // 0x0000000188A9F2E4-0x0000000188A9F3AC
		public Vector3 GetReliableHeading(); // 0x0000000188A9F3F8-0x0000000188A9F4EC
	}

	public static class SplineHelpers // TypeDefIndex: 84700
	{
		// Methods
		public static Vector3 Bezier3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3); // 0x000000018587E8C0-0x000000018587EA50
		public static Vector3 BezierTangent3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3); // 0x000000018587C1F0-0x000000018587C550
		public static float Bezier1(float t, float p0, float p1, float p2, float p3); // 0x000000018587ECE0-0x000000018587ED70
		public static void ComputeSmoothControlPoints(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2); // 0x000000018587F3B0-0x000000018587FC10
		public static void ComputeSmoothControlPointsLooped(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2); // 0x0000000188A9FCE0-0x0000000188A9FFB0
	}

	public static class UnityVectorExtensions // TypeDefIndex: 84701
	{
		// Methods
		public static float Angle(Vector3 v1, Vector3 v2); // 0x0000000185231AD0-0x0000000185231E20
		public static float SignedAngle(Vector3 v1, Vector3 v2, Vector3 up); // 0x00000001852316F0-0x0000000185231AB0
		public static Quaternion SafeFromToRotation(Vector3 v1, Vector3 v2, Vector3 up); // 0x0000000188AA070C-0x0000000188AA07F8
	
		// Extension methods
		public static bool IsNaN(this Vector3 v); // 0x0000000185547640-0x00000001855476B0
		public static float ClosestPointOnSegment(this Vector3 p, Vector3 s0, Vector3 s1); // 0x0000000188AA05D4-0x0000000188AA06B4
		public static float ClosestPointOnSegment(this Vector2 p, Vector2 s0, Vector2 s1); // 0x0000000188AA053C-0x0000000188AA05D4
		public static Vector3 ProjectOntoPlane(this Vector3 vector, Vector3 planeNormal); // 0x0000000185231630-0x00000001852316F0
		public static Vector2 Abs(this Vector2 v); // 0x00000001872350B0-0x00000001872350E0
		public static bool IsUniform(this Vector2 v); // 0x0000000188AA06B4-0x0000000188AA070C
		public static bool AlmostZero(this Vector3 v); // 0x0000000185231610-0x0000000185231630
	}

	public static class UnityQuaternionExtensions // TypeDefIndex: 84702
	{
		// Methods
		public static Quaternion SlerpWithReferenceUp(Quaternion qA, Quaternion qB, float t, Vector3 up); // 0x0000000188AA0228-0x0000000188AA053C
	
		// Extension methods
		public static Quaternion Normalized(this Quaternion q); // 0x00000001856BFD10-0x00000001856BFF90
		public static Vector2 GetCameraRotationToTarget(this Quaternion orient, Vector3 lookAtDir, Vector3 worldUp); // 0x0000000185230B30-0x0000000185231610
		public static Quaternion ApplyCameraRotation(this Quaternion orient, Vector2 rot, Vector3 worldUp); // 0x0000000185231F20-0x0000000185232030
	}
}
