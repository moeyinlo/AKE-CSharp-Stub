/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
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
using UnityEngine.Timeline;
using UnityEngine.UI;

// Image 34: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 55342-55545

public class CinemachineCameraOffset : CinemachineExtension // TypeDefIndex: 55343
{
	// Fields
	public Vector3 m_Offset; // 0x28
	public CinemachineCore.Stage m_ApplyAfter; // 0x34
	public bool m_PreserveComposition; // 0x38

	// Constructors
	public CinemachineCameraOffset() {} // 0x000000018774CCBC-0x000000018774CCE0

	// Methods
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x000000018774C994-0x000000018774CCBC
}

public class CinemachineRecomposer : CinemachineExtension // TypeDefIndex: 55344
{
	// Fields
	public CinemachineCore.Stage m_ApplyAfter; // 0x28
	public float m_Tilt; // 0x2C
	public float m_Pan; // 0x30
	public float m_Dutch; // 0x34
	public float m_ZoomScale; // 0x38
	public float m_FollowAttachment; // 0x3C
	public float m_LookAtAttachment; // 0x40

	// Constructors
	public CinemachineRecomposer() {} // 0x000000018646DB20-0x000000018646DB28

	// Methods
	private void Reset() {} // 0x0000000185FB1940-0x0000000185FB1970
	private void OnValidate() {} // 0x0000000187758F18-0x0000000187758F54
	public override void PrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState curState, float deltaTime) {} // 0x00000001852E0490-0x00000001852E04C0
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x00000001841EFE60-0x00000001841F00E0
}

public static class CinemachineBeyondCommunicator // TypeDefIndex: 55345
{
	// Fields
	private static Func<CinemachineVirtualCameraBase> _GetLevelCamera_k__BackingField; // 0x00

	// Properties
	public static Func<CinemachineVirtualCameraBase> GetLevelCamera { get; set; } // 0x000000018774A77C-0x000000018774A7B4 0x000000018774A7B4-0x000000018774A804
}

public class CinemachineTouchInputMapper : MonoBehaviour // TypeDefIndex: 55346
{
	// Fields
	public float TouchSensitivityX; // 0x18
	public float TouchSensitivityY; // 0x1C
	public string TouchXInputMapTo; // 0x20
	public string TouchYInputMapTo; // 0x28

	// Constructors
	public CinemachineTouchInputMapper() {} // 0x00000001877595AC-0x0000000187759620

	// Methods
	private void Start() {} // 0x00000001877594FC-0x00000001877595AC
	private float GetInputAxis(string axisName) => default; // 0x000000018775945C-0x00000001877594FC
}

internal sealed class CinemachineMixer : PlayableBehaviour // TypeDefIndex: 55347
{
	// Fields
	private CinemachineBrain mBrain; // 0x10
	private int mBrainOverrideId; // 0x18
	private bool mPreviewPlay; // 0x1C

	// Constructors
	public CinemachineMixer() {} // 0x0000000185FB1880-0x0000000185FB1890

	// Methods
	public override void OnPlayableDestroy(Playable playable) {} // 0x0000000187756EAC-0x0000000187756F20
	public override void PrepareFrame(Playable playable, FrameData info) {} // 0x0000000185FB1870-0x0000000185FB1880
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x0000000187756F20-0x00000001877574EC
	private float GetDeltaTime(float deltaTime) => default; // 0x0000000187756E5C-0x0000000187756EAC
}

public sealed class CinemachineShot : PlayableAsset, IPropertyPreview, ITimelineClipAsset // TypeDefIndex: 55348
{
	// Fields
	public bool DisableEvaluateTwiceWhenEnabled; // 0x18
	public bool UseVcamBeforeTimeline; // 0x19
	public bool UseLevelCamera; // 0x1A
	public string DisplayName; // 0x20
	public ExposedReference<CinemachineVirtualCameraBase> VirtualCamera; // 0x28

	// Properties
	public ClipCaps clipCaps { get => default; } // 0x0000000187759448-0x000000018775945C 

	// Constructors
	public CinemachineShot() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0

	// Methods
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x0000000187758FA4-0x00000001877592AC
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver) {} // 0x00000001877592AC-0x0000000187759448
}

internal sealed class CinemachineShotPlayable : PlayableBehaviour // TypeDefIndex: 55349
{
	// Fields
	public CinemachineVirtualCameraBase VirtualCamera; // 0x10

	// Properties
	public bool IsValid { get => default; } // 0x0000000187758F54-0x0000000187758FA4 

	// Constructors
	public CinemachineShotPlayable() {} // 0x0000000185492010-0x0000000185492020
}

[Serializable]
public class CinemachineTrack : TrackAsset // TypeDefIndex: 55350
{
	// Constructors
	public CinemachineTrack() {} // 0x0000000187759700-0x000000018775974C

	// Methods
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) => default; // 0x0000000187759620-0x0000000187759700
}

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 55545
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_12 AA5072B96927F710758B3E5237A84AC68E397BC4E1BF7E864A950696D743CC32; // 0x00 // Static value (base64): AAAAP83MDD+amRk/ - Metadata: 0x0207BEFC

	// Nested types
	private struct __StaticArrayInitTypeSize_12 // TypeDefIndex: 55544
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace Cinemachine
{
	public class Cinemachine3rdPersonAim : CinemachineExtension // TypeDefIndex: 55351
	{
		// Fields
		public LayerMask AimCollisionFilter; // 0x28
		public string IgnoreTag; // 0x30
		public float AimDistance; // 0x38
		public RectTransform AimTargetReticle; // 0x40
		private Vector3 _AimTarget_k__BackingField; // 0x48
	
		// Properties
		private Vector3 AimTarget { get; set; } // 0x0000000185FB1570-0x0000000185FB1590 0x0000000185FB1590-0x0000000185FB15A0
	
		// Constructors
		public Cinemachine3rdPersonAim() {} // 0x000000018774A728-0x000000018774A77C
	
		// Methods
		private void OnValidate() {} // 0x000000018774A4A4-0x000000018774A4BC
		private void Reset() {} // 0x000000018774A6C4-0x000000018774A728
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) => default; // 0x000000018774A378-0x000000018774A4A4
		private void DrawReticle(CinemachineBrain brain) {} // 0x000000018774A1BC-0x000000018774A378
		private Vector3 ComputeLookAtPoint(Vector3 camPos, Transform player) => default; // 0x0000000187749EB8-0x000000018774A1BC
		private Vector3 ComputeAimTarget(Vector3 cameraLookAt, Transform player) => default; // 0x0000000187749D2C-0x0000000187749EB8
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x000000018774A4BC-0x000000018774A6C4
	}

	public class CinemachineBlendListCamera : CinemachineVirtualCameraBase // TypeDefIndex: 55353
	{
		// Fields
		public Transform m_LookAt; // 0xA8
		public Transform m_Follow; // 0xB0
		public bool m_ShowDebugText; // 0xB8
		public bool m_Loop; // 0xB9
		internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0xC0
		public Instruction[] m_Instructions; // 0xC8
		private ICinemachineCamera _LiveChild_k__BackingField; // 0xD0
		private ICinemachineCamera m_TransitioningFrom; // 0xD8
		private CameraState m_State; // 0xE0
		private float mActivationTime; // 0x200
		private int mCurrentInstruction; // 0x204
		private CinemachineBlend mActiveBlend; // 0x208
	
		// Properties
		public override string Description { get => default; } // 0x000000018774BC60-0x000000018774BD4C 
		public ICinemachineCamera LiveChild { get; set; } // 0x0000000185FB15A0-0x0000000185FB15B0 0x000000018774BD78-0x000000018774BD8C
		public override CameraState State { get => default; } // 0x0000000185FB15B0-0x0000000185FB1630 
		public override Transform LookAt { get => default; set {} } // 0x000000018774BD68-0x000000018774BD78 0x000000018774BD8C-0x000000018774BDA0
		public override Transform Follow { get => default; set {} } // 0x000000018774BD4C-0x000000018774BD5C 0x0000000184784C70-0x0000000184784C90
		public CinemachineVirtualCameraBase[] ChildCameras { get => default; } // 0x000000018774BC40-0x000000018774BC60 
		public bool IsBlending { get => default; } // 0x000000018774BD5C-0x000000018774BD68 
	
		// Nested types
		[Serializable]
		public struct Instruction // TypeDefIndex: 55352
		{
			// Fields
			public CinemachineVirtualCameraBase m_VirtualCamera; // 0x00
			public float m_Hold; // 0x08
			public CinemachineBlendDefinition m_Blend; // 0x10
		}
	
		// Constructors
		public CinemachineBlendListCamera() {} // 0x000000018774BB08-0x000000018774BC40
	
		// Methods
		private void Reset() {} // 0x000000018774B780-0x000000018774B7E4
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0207BE18 */) => default; // 0x000000018774B104-0x000000018774B12C
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x000000018774B58C-0x000000018774B650
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x000000018774AA08-0x000000018774AAE8
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x000000018774B658-0x000000018774B780
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x000000018774AAE8-0x000000018774B0D0
		protected override void OnEnable() {} // 0x000000018774B244-0x000000018774B448
		protected override void OnDisable() {} // 0x000000018774B12C-0x000000018774B244
		private void OnTransformChildrenChanged() {} // 0x000000018774B650-0x000000018774B658
		private void OnGuiHandler() {} // 0x000000018774B448-0x000000018774B58C
		private void InvalidateListOfChildren() {} // 0x000000018774B0D0-0x000000018774B104
		private void UpdateListOfChildren() {} // 0x000000018774B7E4-0x000000018774B984
		internal void ValidateInstructions() {} // 0x000000018774B984-0x000000018774BB08
		private void AdvanceCurrentInstruction(float deltaTime) {} // 0x000000018774A804-0x000000018774AA08
	}

	public class CinemachineBrain : MonoBehaviour // TypeDefIndex: 55360
	{
		// Fields
		public bool m_ShowDebugText; // 0x18
		public bool m_ShowCameraFrustum; // 0x19
		public bool m_IgnoreTimeScale; // 0x1A
		public Transform m_WorldUpOverride; // 0x20
		public UpdateMethod m_UpdateMethod; // 0x28
		public BrainUpdateMethod m_BlendUpdateMethod; // 0x2C
		public CinemachineBlendDefinition m_DefaultBlend; // 0x30
		public CinemachineBlenderSettings m_CustomBlends; // 0x48
		private Camera m_OutputCamera; // 0x50
		private HGDepthOfField m_OutputDOF; // 0x58
		public BrainEvent m_CameraCutEvent; // 0x60
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
		private CameraState _CurrentCameraState_k__BackingField; // 0xB0
	
		// Properties
		public Camera OutputCamera { get => default; } // 0x0000000185FADB90-0x0000000185FADBB0 
		public HGDepthOfField OutputDOF { get => default; } // 0x000000018774C200-0x000000018774C4C0 
		public static ICinemachineCamera SoloCamera { get => default; set {} } // 0x000000018508EA60-0x000000018508EAC0 0x00000001853BB930-0x00000001853BB950
		public Vector3 DefaultWorldUp { get => default; } // 0x00000001841FA310-0x00000001841FA410 
		public ICinemachineCamera ActiveVirtualCamera { get => default; } // 0x00000001841F9EC0-0x00000001841FA1F0 
		public bool IsBlending { get => default; } // 0x000000018774C82C-0x000000018774C8A4 
		public CinemachineBlend ActiveBlend { get => default; } // 0x00000001841F6780-0x00000001841F6CB0 
		public CameraState CurrentCameraState { get; private set; } // 0x000000018508E450-0x000000018508E570 0x0000000181378230-0x0000000181378240
	
		// Nested types
		public enum UpdateMethod // TypeDefIndex: 55354
		{
			FixedUpdate = 0,
			LateUpdate = 1,
			SmartUpdate = 2,
			ManualUpdate = 3
		}
	
		public enum BrainUpdateMethod // TypeDefIndex: 55355
		{
			FixedUpdate = 0,
			LateUpdate = 1
		}
	
		[Serializable]
		public class BrainEvent : UnityEvent<CinemachineBrain> // TypeDefIndex: 55356
		{
			// Constructors
			public BrainEvent() {} // 0x00000001841F7270-0x00000001841F7390
		}
	
		[Serializable]
		public class VcamActivatedEvent : UnityEvent<ICinemachineCamera, ICinemachineCamera> // TypeDefIndex: 55357
		{
			// Constructors
			public VcamActivatedEvent() {} // 0x00000001841F9370-0x00000001841F9490
		}
	
		private class BrainFrame // TypeDefIndex: 55358
		{
			// Fields
			public int id; // 0x10
			public CinemachineBlend blend; // 0x18
			public CinemachineBlend workingBlend; // 0x20
			public BlendSourceVirtualCamera workingBlendSource; // 0x28
			public float deltaTimeOverride; // 0x30
	
			// Properties
			public bool Active { get => default; } // 0x000000018774C7DC-0x000000018774C82C 
	
			// Constructors
			public BrainFrame() {} // 0x000000018774C8A4-0x000000018774C994
		}
	
		private sealed class _AfterPhysics_d__36 : IEnumerator<object> // TypeDefIndex: 55359
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public CinemachineBrain __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018774BFD0-0x000000018774C200 
			object IEnumerator.Current { get => default; } // 0x0000000185FA4EE0-0x0000000185FA4F20 
	
			// Constructors
			public _AfterPhysics_d__36() {} // Dummy constructor
			public _AfterPhysics_d__36(int __1__state) {} // 0x000000018774BEAC-0x000000018774BF08
	
			// Methods
			void IDisposable.Dispose() {} // 0x00000001841F7140-0x00000001841F7270
			private bool MoveNext() => default; // 0x000000018508E680-0x000000018508EA60
			void IEnumerator.Reset() {} // 0x000000018774C4C0-0x000000018774C524
		}
	
		// Constructors
		public CinemachineBrain() {} // 0x000000018775A324-0x000000018775A370
		static CinemachineBrain() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public static UnityEngine.Color GetSoloGUIColor() => default; // 0x00000001841F99B0-0x00000001841F9B90
		private void OnEnable() {} // 0x00000001841F6D90-0x00000001841F7040
		private void OnDisable() {} // 0x00000001841F7AB0-0x00000001841F7BF0
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode) {} // 0x00000001841F7BF0-0x00000001841F7DE0
		private void OnSceneUnloaded(Scene scene) {} // 0x000000018774BF08-0x000000018774BFD0
		private void Start() {} // 0x00000001841F84E0-0x00000001841F8550
		private void OnGuiHandler() {} // 0x00000001841F7960-0x00000001841F79D0
		private IEnumerator AfterPhysics() => default; // 0x000000018774BDA0-0x000000018774BEAC
		private void LateUpdate() {} // 0x000000018774C5DC-0x000000018774C7DC
		public void ManualUpdate(float deltaTime = -1f /* Metadata: 0x0207BE19 */) {} // 0x000000018774C524-0x000000018774C5DC
		private float GetEffectiveDeltaTime(bool fixedDelta) => default; // 0x00000001841F8550-0x00000001841F8A90
		private void UpdateVirtualCameras(CinemachineCore.UpdateFilter updateFilter, float deltaTime) {} // 0x00000001841F9B90-0x00000001841F9EC0
		private static ICinemachineCamera DeepCamBFromBlend(CinemachineBlend blend) => default; // 0x00000001841F79D0-0x00000001841F7AB0
		public bool IsLiveInBlend(ICinemachineCamera vcam) => default; // 0x0000000185FB1630-0x0000000185FB16B0
		private int GetBrainFrame(int withId) => default; // 0x00000001858930E0-0x0000000185893410
		public int SetCameraOverride(int overrideId, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime) => default; // 0x00000001841F8BA0-0x00000001841F9370
		public void ReleaseCameraOverride(int overrideId) {} // 0x000000018508DFE0-0x000000018508E1D0
		private void ProcessActiveCamera(float deltaTime) {} // 0x0000000185F61540-0x0000000185F615B0
		private void UpdateFrame0(float deltaTime) {} // 0x000000018508E3D0-0x000000018508E410
		public void ComputeCurrentBlend(ref CinemachineBlend outputBlend, int numTopLayersToExclude) {} // 0x000000018508E410-0x000000018508E450
		public bool IsLive(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0207BE1D */) => default; // 0x0000000187749D0C-0x0000000187749D2C
		public ICinemachineCamera TopCameraFromPriorityQueue() => default; // 0x0000000185492010-0x0000000185492020
		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey) => default; // 0x0000000184E50220-0x0000000184E502D0
		private void PushStateToUnityCamera(ref CameraState state) {} // 0x0000000181377E40-0x0000000181377E50
	}

	public class CinemachineClearShot : CinemachineVirtualCameraBase // TypeDefIndex: 55363
	{
		// Fields
		public Transform m_LookAt; // 0xA8
		public Transform m_Follow; // 0xB0
		public bool m_ShowDebugText; // 0xB8
		internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0xC0
		public float m_ActivateAfter; // 0xC8
		public float m_MinDuration; // 0xCC
		public bool m_RandomizeChoice; // 0xD0
		public CinemachineBlendDefinition m_DefaultBlend; // 0xD8
		public CinemachineBlenderSettings m_CustomBlends; // 0xF0
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
		public override string Description { get => default; } // 0x0000000185FB16C0-0x0000000185FB1740 
		public ICinemachineCamera LiveChild { get; set; } // 0x000000018774D97C-0x000000018774D9A4 0x000000018774BD68-0x000000018774BD78
		public override CameraState State { get => default; } // 0x000000018774BD8C-0x000000018774BDA0 
		public override Transform LookAt { get => default; set {} } // 0x0000000184784C70-0x0000000184784C90 0x000000018774DFC8-0x000000018774E08C
		public override Transform Follow { get => default; set {} } // 0x000000018774D360-0x000000018774D440 0x000000018774D440-0x000000018774D934
		public bool IsBlending { get => default; } // 0x000000018774E3DC-0x000000018774E408 
		public CinemachineVirtualCameraBase[] ChildCameras { get => default; } // 0x000000018774E408-0x000000018774E5E8 
	
		// Nested types
		private struct Pair // TypeDefIndex: 55361
		{
			// Fields
			public int a; // 0x00
			public float b; // 0x04
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 55362
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<Pair> __9__47_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018774E780-0x000000018774E86C
			public __c() {} // 0x0000000185FB16B0-0x0000000185FB16C0
	
			// Methods
			internal int _Randomize_b__47_0(Pair p1, Pair p2) => default; // 0x000000018774E878-0x000000018774E88C
		}
	
		// Constructors
		public CinemachineClearShot() {} // 0x0000000185FB1980-0x0000000185FB19A0
	
		// Methods
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0207BE24 */) => default; // 0x000000018774BD4C-0x000000018774BD5C
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x000000018774DC94-0x000000018774DE84
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x000000018774DB7C-0x000000018774DC94
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x000000018774E08C-0x000000018774E0AC
		protected override void OnEnable() {} // 0x000000018774DE84-0x000000018774DFC8
		protected override void OnDisable() {} // 0x000000018774E86C-0x000000018774E878
		public void OnTransformChildrenChanged() {} // 0x000000018774E760-0x000000018774E780
		private void OnGuiHandler() {} // 0x000000018774D934-0x000000018774D97C
		private void InvalidateListOfChildren() {} // 0x000000018774CCE0-0x000000018774D360
		public void ResetRandomization() {} // 0x000000018774E1A4-0x000000018774E3DC
		private void UpdateListOfChildren() {} // 0x000000018774D9A4-0x000000018774DB7C
		private ICinemachineCamera ChooseCurrentCamera(Vector3 worldUp) => default; // 0x000000018774E0AC-0x000000018774E1A4
		private CinemachineVirtualCameraBase[] Randomize(CinemachineVirtualCameraBase[] src) => default; // 0x000000018774E5E8-0x000000018774E760
		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey) => default; // 0x000000018775A370-0x000000018775A3D4
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x0000000185492010-0x0000000185492020
	}

	public class CinemachineCollider : CinemachineExtension // TypeDefIndex: 55366
	{
		// Fields
		public LayerMask m_CollideAgainst; // 0x28
		public string m_IgnoreTag; // 0x30
		public LayerMask m_TransparentLayers; // 0x38
		public float m_MinimumDistanceFromTarget; // 0x3C
		public bool m_AvoidObstacles; // 0x40
		public float m_DistanceLimit; // 0x44
		public float m_MinimumOcclusionTime; // 0x48
		public float m_CameraRadius; // 0x4C
		public ResolutionStrategy m_Strategy; // 0x50
		public bool m_UseFollowInsteadOfLookAt; // 0x54
		public int m_MaximumEffort; // 0x58
		public float m_SmoothingTime; // 0x5C
		public float m_Damping; // 0x60
		public float m_DampingWhenOccluded; // 0x64
		public float m_OptimalTargetDistance; // 0x68
		private const float k_PrecisionSlush = 0.001f; // Metadata: 0x0207BE25
		private RaycastHit[] m_CornerBuffer; // 0x70
		private const float k_AngleThreshold = 0.1f; // Metadata: 0x0207BE29
		private static ECSColliderResultProxy[] s_ColliderBuffer; // 0x00
	
		// Properties
		public List<List<Vector3>> DebugPaths { get => default; } // 0x00000001841EBCF0-0x00000001841EBFE0 
	
		// Nested types
		public enum ResolutionStrategy // TypeDefIndex: 55364
		{
			PullCameraForward = 0,
			PreserveCameraHeight = 1,
			PreserveCameraDistance = 2
		}
	
		private class VcamExtraState // TypeDefIndex: 55365
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
			public VcamExtraState() {} // 0x000000018774F5F0-0x000000018774F638
	
			// Methods
			public void AddPointToDebugPath(Vector3 p) {} // 0x000000018774F598-0x000000018774F5F0
			public float ApplyDistanceSmoothing(float distance, float smoothingTime) => default; // 0x000000018774E88C-0x000000018774E8A8
			public void UpdateDistanceSmoothing(float distance) {} // 0x000000018774ECB4-0x000000018774ED10
			public void ResetDistanceSmoothing(float smoothingTime) {} // 0x000000018774F638-0x000000018774F684
		}
	
		// Constructors
		public CinemachineCollider() {} // 0x00000001841EBB80-0x00000001841EBBF0
		static CinemachineCollider() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool IsTargetObscured(ICinemachineCamera vcam) => default; // 0x0000000187750938-0x0000000187750B00
		public bool CameraWasDisplaced(ICinemachineCamera vcam) => default; // 0x000000018774ED10-0x000000018774ED28
		public float GetCameraDisplacementDistance(ICinemachineCamera vcam) => default; // 0x00000001841EB2A0-0x00000001841EB360
		private void OnValidate() {} // 0x000000018774FDD4-0x000000018774FE74
		protected override void OnDestroy() {} // 0x00000001841EB360-0x00000001841EBB80
		public override float GetMaxDampTime() => default; // 0x00000001841EBFE0-0x00000001841EC250
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x000000018774F684-0x000000018774FDD4
		public void ResetExtraData(ICinemachineCamera vcam) {} // 0x000000018774EE8C-0x000000018774F598
		public virtual void GuardedPostPipelineStageCallback(ICinemachineCamera vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x000000018774ED28-0x000000018774EE8C
		private Vector3 PreserveLineOfSight(ref CameraState state, ref VcamExtraState extra) => default; // 0x000000018774E8A8-0x000000018774ECB4
		private Vector3 PullCameraInFrontOfNearestObstacle(Vector3 cameraPos, Vector3 lookAtPos, int layerMask, ref RaycastHit hitInfo) => default; // 0x000000018774FE74-0x0000000187750938
		private Vector3 PushCameraBack(Vector3 currentPos, Vector3 pushDir, RaycastHit obstacle, Vector3 lookAtPos, Plane startPlane, float targetDistance, int iterations, ref VcamExtraState extra) => default; // 0x00000001841EACC0-0x00000001841EB030
		private bool GetWalkingDirection(Vector3 pos, Vector3 pushDir, RaycastHit obstacle, ref Vector3 outDir) => default; // 0x00000001841EED30-0x00000001841EF3C0
		private float GetPushBackDistance(Ray ray, Plane startPlane, float targetDistance, Vector3 lookAtPos) => default; // 0x0000000185BB14E0-0x0000000185BB1590
		private static float ClampRayToBounds(Ray ray, float distance, Bounds bounds) => default; // 0x0000000185F65660-0x0000000185F656D0
		private Vector3 RespectCameraRadius(Vector3 cameraPos, Vector3 lookAtPos) => default; // 0x0000000185492010-0x0000000185492020
		private bool CheckForTargetObstructions(in CameraState state) => default; // 0x00000001841EBC80-0x00000001841EBCF0
		private static bool IsTargetOffscreen(in CameraState state) => default; // 0x000000018775A3D4-0x000000018775A690
	}

	public class CinemachineConfiner : CinemachineExtension // TypeDefIndex: 55369
	{
		// Fields
		public Mode m_ConfineMode; // 0x28
		public Collider m_BoundingVolume; // 0x30
		public Collider2D m_BoundingShape2D; // 0x38
		private Collider2D m_BoundingShape2DCache; // 0x40
		public bool m_ConfineScreenEdges; // 0x48
		public float m_Damping; // 0x4C
		private List<List<Vector2>> m_pathCache; // 0x50
		private int m_pathTotalPointCount; // 0x58
	
		// Properties
		public bool IsValid { get => default; } // 0x0000000185FB1750-0x0000000185FB1760 
	
		// Nested types
		public enum Mode // TypeDefIndex: 55367
		{
			Confine2D = 0,
			Confine3D = 1
		}
	
		private class VcamExtraState // TypeDefIndex: 55368
		{
			// Fields
			public Vector3 m_previousDisplacement; // 0x10
			public float confinerDisplacement; // 0x1C
	
			// Constructors
			public VcamExtraState() {} // 0x0000000187751164-0x0000000187751180
		}
	
		// Constructors
		public CinemachineConfiner() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam) => default; // 0x0000000187751C44-0x0000000187751CA0
		public float GetCameraDisplacementDistance(CinemachineVirtualCameraBase vcam) => default; // 0x0000000187751CC8-0x0000000187751CD8
		private void OnValidate() {} // 0x0000000187751C3C-0x0000000187751C44
		protected override void ConnectToVcam(bool connect) {} // 0x000000018775246C-0x000000018775256C
		public override float GetMaxDampTime() => default; // 0x0000000187751CD8-0x0000000187751F70
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x0000000187751CA0-0x0000000187751CC8
		public void InvalidatePathCache() {} // 0x0000000187751F70-0x0000000187752460
		private bool ValidatePathCache() => default; // 0x0000000187751180-0x00000001877515F8
		private Vector3 ConfinePoint(Vector3 camPos) => default; // 0x00000001877515F8-0x0000000187751C3C
		private Vector3 ConfineScreenEdges(CinemachineVirtualCameraBase vcam, ref CameraState state) => default; // 0x0000000187752460-0x000000018775246C
	}

	public class CinemachineConfiner2D : CinemachineExtension // TypeDefIndex: 55372
	{
		// Fields
		public Collider2D m_BoundingShape2D; // 0x28
		public float m_Damping; // 0x30
		public float m_MaxWindowSize; // 0x34
		private float m_MaxComputationTimePerFrameInSeconds; // 0x38
		private const float k_cornerAngleTreshold = 10f; // Metadata: 0x0207BE32
		private ShapeCache m_shapeCache; // 0x40
	
		// Nested types
		private class VcamExtraState // TypeDefIndex: 55370
		{
			// Fields
			public Vector3 m_PreviousDisplacement; // 0x10
			public Vector3 m_DampedDisplacement; // 0x1C
			public ConfinerOven.BakedSolution m_BakedSolution; // 0x28
			public CinemachineVirtualCameraBase m_vcam; // 0x30
	
			// Constructors
			public VcamExtraState() {} // 0x0000000187750B9C-0x0000000187750BA8
		}
	
		private struct ShapeCache // TypeDefIndex: 55371
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
			public void Invalidate() {} // 0x0000000187751118-0x0000000187751154
			public bool ValidateCache(Collider2D boundingShape2D, float maxWindowSize, float aspectRatio, out bool confinerStateChanged) {
				confinerStateChanged = default;
				return default;
			} // 0x0000000187750BC4-0x0000000187751118
			private bool IsValid(in Collider2D boundingShape2D, in float aspectRatio, in float maxOrthoSize) => default; // 0x0000000187750B00-0x0000000187750B9C
			private void CalculateDeltaTransformationMatrix() {} // 0x0000000187750BA8-0x0000000187750BC4
		}
	
		// Constructors
		public CinemachineConfiner2D() {} // 0x0000000187759948-0x0000000187759B30
	
		// Methods
		public void InvalidateCache() {} // 0x0000000185FB1740-0x0000000185FB1750
		public bool ValidateCache(float cameraAspectRatio) => default; // 0x0000000187751154-0x0000000187751164
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x0000000185492010-0x0000000185492020
		private float CalculateHalfFrustumHeight(in CameraState state, in float cameraPosLocalZ) => default; // 0x0000000187759B30-0x0000000187759BD4
		private void OnValidate() {} // 0x0000000187759CEC-0x000000018775A324
		private void Reset() {} // 0x0000000187759BD4-0x0000000187759CEC
	}

	public class CinemachineDollyCart : MonoBehaviour // TypeDefIndex: 55374
	{
		// Fields
		public CinemachinePathBase m_Path; // 0x18
		public bool forbidRotation; // 0x20
		public UpdateMethod m_UpdateMethod; // 0x24
		public CinemachinePathBase.PositionUnits m_PositionUnits; // 0x28
		public float m_Speed; // 0x2C
		public float m_Position; // 0x30
	
		// Nested types
		public enum UpdateMethod // TypeDefIndex: 55373
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2
		}
	
		// Constructors
		public CinemachineDollyCart() {} // 0x0000000185BB1590-0x0000000185BB15A0
	
		// Methods
		private void FixedUpdate() {} // 0x000000018775256C-0x00000001877525BC
		private void Update() {} // 0x0000000187752768-0x00000001877527C8
		private void LateUpdate() {} // 0x00000001877525BC-0x0000000187752620
		private void SetCartPosition(float distanceAlongPath) {} // 0x0000000187752620-0x0000000187752768
	}

	public class CinemachineExternalCamera : CinemachineVirtualCameraBase // TypeDefIndex: 55375
	{
		// Fields
		public Transform m_LookAt; // 0xA8
		private Camera m_Camera; // 0xB0
		private CameraState m_State; // 0xB8
		private Transform _Follow_k__BackingField; // 0x1D8
		public BlendHint m_BlendHint; // 0x1E0
	
		// Properties
		public override CameraState State { get => default; } // 0x0000000185FB1770-0x0000000185FB17F0 
		public override Transform LookAt { get => default; set {} } // 0x000000018349D730-0x000000018349D740 0x0000000185FAE6F0-0x0000000185FAE710
		public override Transform Follow { get; set; } // 0x0000000185FB1760-0x0000000185FB1770 0x0000000185FAE710-0x0000000185FAE730
	
		// Constructors
		public CinemachineExternalCamera() {} // 0x000000018535B230-0x000000018535B390
	
		// Methods
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x00000001877527C8-0x0000000187752D94
	}

	public class CinemachineFollowZoom : CinemachineExtension // TypeDefIndex: 55377
	{
		// Fields
		public float m_Width; // 0x28
		public float m_Damping; // 0x2C
		public float m_MinFOV; // 0x30
		public float m_MaxFOV; // 0x34
	
		// Nested types
		private class VcamExtraState // TypeDefIndex: 55376
		{
			// Fields
			public float m_previousFrameZoom; // 0x10
	
			// Constructors
			public VcamExtraState() {} // 0x0000000187752D94-0x0000000187752DF0
		}
	
		// Constructors
		public CinemachineFollowZoom() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private void OnValidate() {} // 0x0000000185FB09A0-0x0000000185FB09B0
		public override float GetMaxDampTime() => default; // 0x00000001841EA700-0x00000001841EA9E0
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x0000000185BB14B0-0x0000000185BB14E0
	}

	public class CinemachineFreeLook : CinemachineVirtualCameraBase // TypeDefIndex: 55381
	{
		// Fields
		public Transform m_LookAt; // 0xA8
		public Transform m_Follow; // 0xB0
		public bool m_CommonLens; // 0xB8
		public LensSettings m_Lens; // 0xBC
		public TransitionParams m_Transitions; // 0xF0
		private BlendHint m_LegacyBlendHint; // 0x100
		public AxisState m_YAxis; // 0x108
		public AxisState.Recentering m_YAxisRecentering; // 0x178
		public AxisState m_XAxis; // 0x198
		public CinemachineOrbitalTransposer.Heading m_Heading; // 0x208
		public AxisState.Recentering m_RecenterToTargetHeading; // 0x214
		public CinemachineTransposer.BindingMode m_BindingMode; // 0x230
		public float m_SplineCurvature; // 0x234
		public Orbit[] m_Orbits; // 0x238
		private float m_LegacyHeadingBias; // 0x240
		private bool mUseLegacyRigDefinitions; // 0x244
		private bool mIsDestroyed; // 0x245
		private CameraState m_State; // 0x248
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
		public static string[] RigNames { get => default; } // 0x0000000187755EF8-0x0000000187755F00 
		public override bool PreviousStateIsValid { get => default; set {} } // 0x000000018774BD4C-0x000000018774BD5C 0x0000000184784C70-0x0000000184784C90
		public override CameraState State { get => default; } // 0x0000000187754904-0x0000000187754A10 
		public override Transform LookAt { get => default; set {} } // 0x0000000187755318-0x00000001877553DC 0x000000018775398C-0x0000000187753C6C
		public override Transform Follow { get => default; set {} } // 0x00000001877542D0-0x00000001877548EC 0x00000001877553DC-0x0000000187755760
	
		// Nested types
		[Serializable]
		public struct Orbit // TypeDefIndex: 55378
		{
			// Fields
			public float m_Height; // 0x00
			public float m_Radius; // 0x04
	
			// Constructors
			public Orbit(float h, float r) {
				m_Height = default;
				m_Radius = default;
			} // 0x0000000187755760-0x00000001877558A0
		}
	
		public delegate CinemachineVirtualCamera CreateRigDelegate(CinemachineFreeLook vcam, string name, CinemachineVirtualCamera copyFrom); // TypeDefIndex: 55379; 0x0000000187756CCC-0x0000000187756D74
	
		public delegate void DestroyRigDelegate(GameObject rig); // TypeDefIndex: 55380; 0x00000001877563A0-0x0000000187756434
	
		// Constructors
		public CinemachineFreeLook() {} // 0x00000001833EEC70-0x00000001833EEC80
	
		// Methods
		protected override void OnValidate() {} // 0x00000001877551BC-0x00000001877552D8
		public CinemachineVirtualCamera GetRig(int i) => default; // 0x00000001877548EC-0x0000000187754904
		protected override void OnEnable() {} // 0x0000000181BE64B0-0x0000000181BE64C0
		public void UpdateInputAxisProvider() {} // 0x0000000187756D74-0x0000000187756E5C
		protected override void OnDestroy() {} // 0x0000000185FB17F0-0x0000000185FB1870
		private void OnTransformChildrenChanged() {} // 0x000000018774BD68-0x000000018774BD78
		private void Reset() {} // 0x000000018774BD8C-0x000000018774BDA0
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0207BE39 */) => default; // 0x00000001840A27C0-0x00000001840A27D0
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x0000000187753EFC-0x00000001877542A0
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x00000001877548EC-0x0000000187754904
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x0000000187753508-0x000000018775398C
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x00000001877530B4-0x0000000187753508
		internal override bool RequiresUserInput() => default; // 0x0000000187756434-0x000000018775666C
		private float GetYAxisClosestValue(Vector3 cameraPos, Vector3 up) => default; // 0x0000000187754A10-0x00000001877551BC
		private void InvalidateRigCache() {} // 0x000000018775666C-0x00000001877567FC
		private void DestroyRigs() {} // 0x00000001877558A0-0x0000000187755EF8
		private CinemachineVirtualCamera[] CreateRigs(CinemachineVirtualCamera[] copyFrom) => default; // 0x00000001877542A0-0x00000001877542D0
		private void UpdateRigCache() {} // 0x0000000187752DF0-0x00000001877530B4
		private int LocateExistingRigs(string[] rigNames, bool forceOrbital) => default; // 0x0000000187753C6C-0x0000000187753EAC
		private float UpdateXAxisHeading(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up) => default; // 0x0000000187755F00-0x00000001877563A0
		private void PushSettingsToRigs() {} // 0x00000001877567FC-0x0000000187756CCC
		private float GetYAxisValue() => default; // 0x0000000185FB1970-0x0000000185FB1980
		private CameraState CalculateNewState(Vector3 worldUp, float deltaTime) => default; // 0x000000018775974C-0x0000000187759874
		public Vector3 GetLocalPositionForCameraFromInput(float t) => default; // 0x00000001817E31E0-0x00000001817E3200
		private void UpdateCachedSpline() {} // 0x0000000187759874-0x0000000187759948
	}

	public class CinemachineMixingCamera : CinemachineVirtualCameraBase // TypeDefIndex: 55382
	{
		// Fields
		public const int MaxCameras = 8; // Metadata: 0x0207BE3B
		public float m_Weight0; // 0xA8
		public float m_Weight1; // 0xAC
		public float m_Weight2; // 0xB0
		public float m_Weight3; // 0xB4
		public float m_Weight4; // 0xB8
		public float m_Weight5; // 0xBC
		public float m_Weight6; // 0xC0
		public float m_Weight7; // 0xC4
		private CameraState m_State; // 0xC8
		private ICinemachineCamera _LiveChild_k__BackingField; // 0x1E8
		private Transform _LookAt_k__BackingField; // 0x1F0
		private Transform _Follow_k__BackingField; // 0x1F8
		private CinemachineVirtualCameraBase[] m_ChildCameras; // 0x200
		private Dictionary<CinemachineVirtualCameraBase, int> m_indexMap; // 0x208
	
		// Properties
		private ICinemachineCamera LiveChild { get; set; } // 0x0000000185FB18A0-0x0000000185FB18B0 0x0000000187758564-0x0000000187758578
		public override CameraState State { get => default; } // 0x0000000185FB18C0-0x0000000185FB1940 
		public override Transform LookAt { get; set; } // 0x0000000185FB18B0-0x0000000185FB18C0 0x0000000187758578-0x000000018775858C
		public override Transform Follow { get; set; } // 0x0000000185FB1890-0x0000000185FB18A0 0x0000000187758550-0x0000000187758564
		public CinemachineVirtualCameraBase[] ChildCameras { get => default; } // 0x0000000187758530-0x0000000187758550 
	
		// Constructors
		public CinemachineMixingCamera() {} // 0x00000001877583CC-0x0000000187758530
	
		// Methods
		public float GetWeight(int index) => default; // 0x00000001877576E8-0x00000001877577EC
		public void SetWeight(int index, float w) {} // 0x000000018775808C-0x000000018775819C
		public float GetWeight(CinemachineVirtualCameraBase vcam) => default; // 0x00000001877575CC-0x00000001877576E8
		public void SetWeight(CinemachineVirtualCameraBase vcam, float w) {} // 0x0000000187757F64-0x000000018775808C
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x0000000187757CE8-0x0000000187757DAC
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x00000001877574EC-0x00000001877575CC
		protected override void OnEnable() {} // 0x0000000187757CC8-0x0000000187757CE8
		public void OnTransformChildrenChanged() {} // 0x0000000187757DAC-0x0000000187757DB4
		protected override void OnValidate() {} // 0x0000000187757F08-0x0000000187757F64
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0207BE3A */) => default; // 0x0000000187757C2C-0x0000000187757CC8
		protected void InvalidateListOfChildren() {} // 0x0000000187757BE4-0x0000000187757C2C
		protected void ValidateListOfChildren() {} // 0x000000018775819C-0x00000001877583CC
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x0000000187757DB4-0x0000000187757F08
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x00000001877577EC-0x0000000187757BE4
	}

	public class CinemachinePath : CinemachinePathBase // TypeDefIndex: 55384
	{
		// Fields
		public bool m_Looped; // 0x48
		public Waypoint[] m_Waypoints; // 0x50
	
		// Properties
		public override float MinPos { get => default; } // 0x0000000183908D00-0x0000000183908D10 
		public override float MaxPos { get => default; } // 0x0000000187758EDC-0x0000000187758F18 
		public override bool Looped { get => default; } // 0x0000000185FB0750-0x0000000185FB0760 
		public override int DistanceCacheSampleStepsPerSegment { get => default; } // 0x00000001813AE560-0x00000001813AE570 
	
		// Nested types
		[Serializable]
		public struct Waypoint // TypeDefIndex: 55383
		{
			// Fields
			public Vector3 position; // 0x00
			public Vector3 tangent; // 0x0C
			public float roll; // 0x18
		}
	
		// Constructors
		public CinemachinePath() {} // 0x0000000187758E8C-0x0000000187758EDC
	
		// Methods
		private void Reset() {} // 0x0000000187758D6C-0x0000000187758E8C
		private float GetBoundingIndices(float pos, out int indexA, out int indexB) {
			indexA = default;
			indexB = default;
			return default;
		} // 0x0000000187758C84-0x0000000187758D5C
		public override Vector3 EvaluatePosition(float pos) => default; // 0x000000018775881C-0x0000000187758A2C
		public override Vector3 EvaluateTangent(float pos) => default; // 0x0000000187758A2C-0x0000000187758C84
		public override Quaternion EvaluateOrientation(float pos) => default; // 0x000000018775858C-0x000000018775881C
		private void OnValidate() {} // 0x0000000187758D5C-0x0000000187758D6C
	}

	public sealed class CinemachinePipeline : MonoBehaviour // TypeDefIndex: 55385
	{
		// Constructors
		public CinemachinePipeline() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public class CinemachinePixelPerfect : MonoBehaviour // TypeDefIndex: 55386
	{
		// Constructors
		public CinemachinePixelPerfect() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public class CinemachineSmoothPath : CinemachinePathBase // TypeDefIndex: 55388
	{
		// Fields
		public bool m_Looped; // 0x48
		public Waypoint[] m_Waypoints; // 0x50
		private Waypoint[] m_ControlPoints1; // 0x58
		private Waypoint[] m_ControlPoints2; // 0x60
		private bool m_IsLoopedCache; // 0x68
	
		// Properties
		public override float MinPos { get => default; } // 0x0000000185FB0750-0x0000000185FB0760 
		public override float MaxPos { get => default; } // 0x00000001813AE560-0x00000001813AE570 
		public override bool Looped { get => default; } // 0x0000000187758D5C-0x0000000187758D6C 
		public override int DistanceCacheSampleStepsPerSegment { get => default; } // 0x00000001877624CC-0x00000001877625D4 
	
		// Nested types
		[Serializable]
		public struct Waypoint // TypeDefIndex: 55387
		{
			// Fields
			public Vector3 position; // 0x00
			public float roll; // 0x0C
	
			// Properties
			internal Vector4 AsVector4 { get => default; } // 0x0000000183908D00-0x0000000183908D10 
	
			// Methods
			internal static Waypoint FromVector4(Vector4 v) => default; // 0x0000000187758EDC-0x0000000187758F18
		}
	
		// Constructors
		public CinemachineSmoothPath() {} // 0x000000018776867C-0x00000001877689D0
	
		// Methods
		private void OnValidate() {} // 0x0000000187762498-0x00000001877624CC
		private void Reset() {} // 0x00000001877625D4-0x0000000187762804
		public override void InvalidateDistanceCache() {} // 0x00000001877623EC-0x0000000187762498
		private void UpdateControlPoints() {} // 0x0000000187761F98-0x0000000187762190
		private float GetBoundingIndices(float pos, out int indexA, out int indexB) {
			indexA = default;
			indexB = default;
			return default;
		} // 0x0000000187762190-0x00000001877623EC
		public override Vector3 EvaluatePosition(float pos) => default; // 0x0000000187761D08-0x0000000187761F98
		public override Vector3 EvaluateTangent(float pos) => default; // 0x0000000185FB1C60-0x0000000185FB1CB0
		public override Quaternion EvaluateOrientation(float pos) => default; // 0x0000000187762804-0x0000000187762854
		private Quaternion RollAroundForward(float angle) => default; // 0x00000001840F57D0-0x00000001840F57F0
	}

	public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase // TypeDefIndex: 55392
	{
		// Fields
		public Transform m_LookAt; // 0xA8
		public Transform m_Follow; // 0xB0
		public Animator m_AnimatedTarget; // 0xB8
		public int m_LayerIndex; // 0xC0
		public bool m_ShowDebugText; // 0xC4
		internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0xC8
		public Instruction[] m_Instructions; // 0xD0
		public CinemachineBlendDefinition m_DefaultBlend; // 0xD8
		public CinemachineBlenderSettings m_CustomBlends; // 0xF0
		internal ParentHash[] m_ParentHash; // 0xF8
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
		public override string Description { get => default; } // 0x000000018776469C-0x0000000187764788 
		public ICinemachineCamera LiveChild { get; set; } // 0x0000000185FB1CB0-0x0000000185FB1CC0 0x0000000187764794-0x00000001877647A8
		public override CameraState State { get => default; } // 0x0000000185FB1CC0-0x0000000185FB1D40 
		public override Transform LookAt { get => default; set {} } // 0x000000018774BD68-0x000000018774BD78 0x000000018774BD8C-0x000000018774BDA0
		public override Transform Follow { get => default; set {} } // 0x000000018774BD4C-0x000000018774BD5C 0x0000000184784C70-0x0000000184784C90
		public CinemachineVirtualCameraBase[] ChildCameras { get => default; } // 0x000000018776467C-0x000000018776469C 
		public bool IsBlending { get => default; } // 0x0000000187764788-0x0000000187764794 
	
		// Nested types
		[Serializable]
		public struct Instruction // TypeDefIndex: 55389
		{
			// Fields
			public int m_FullHash; // 0x00
			public CinemachineVirtualCameraBase m_VirtualCamera; // 0x08
			public float m_ActivateAfter; // 0x10
			public float m_MinDuration; // 0x14
		}
	
		[Serializable]
		internal struct ParentHash // TypeDefIndex: 55390
		{
			// Fields
			public int m_Hash; // 0x00
			public int m_ParentHash; // 0x04
		}
	
		private struct HashPair // TypeDefIndex: 55391
		{
			// Fields
			public int parentHash; // 0x00
			public int hash; // 0x04
		}
	
		// Constructors
		public CinemachineStateDrivenCamera() {} // 0x00000001877644A0-0x000000018776467C
	
		// Methods
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0207BE3C */) => default; // 0x0000000187763630-0x0000000187763658
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x0000000187763E98-0x0000000187763F5C
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x0000000187762E80-0x0000000187762F60
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x0000000187763F64-0x0000000187764020
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x000000018776307C-0x00000001877635FC
		protected override void OnEnable() {} // 0x0000000187763B64-0x0000000187763D54
		protected override void OnDisable() {} // 0x0000000187763A4C-0x0000000187763B64
		public void OnTransformChildrenChanged() {} // 0x0000000187763F5C-0x0000000187763F64
		private void OnGuiHandler() {} // 0x0000000187763D54-0x0000000187763E98
		public static int CreateFakeHash(int parentHash, AnimationClip clip) => default; // 0x0000000187762E04-0x0000000187762E80
		private int LookupFakeHash(int parentHash, AnimationClip clip) => default; // 0x0000000187763830-0x0000000187763A4C
		private void InvalidateListOfChildren() {} // 0x00000001877635FC-0x0000000187763630
		private void UpdateListOfChildren() {} // 0x0000000187764020-0x00000001877641D4
		internal void ValidateInstructions() {} // 0x00000001877641D4-0x00000001877644A0
		private CinemachineVirtualCameraBase ChooseCurrentCamera() => default; // 0x0000000187762854-0x0000000187762E04
		private int GetClipHash(int hash, List<AnimatorClipInfo> clips) => default; // 0x0000000187762F60-0x000000018776307C
		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey) => default; // 0x0000000187763658-0x0000000187763830
	}

	public class CinemachineStoryboard : CinemachineExtension // TypeDefIndex: 55396
	{
		// Fields
		public static bool s_StoryboardGlobalMute; // 0x00
		public bool m_ShowImage; // 0x28
		public Texture m_Image; // 0x30
		public FillStrategy m_Aspect; // 0x38
		public float m_Alpha; // 0x3C
		public Vector2 m_Center; // 0x40
		public Vector3 m_Rotation; // 0x48
		public Vector2 m_Scale; // 0x54
		public bool m_SyncScale; // 0x5C
		public bool m_MuteCamera; // 0x5D
		public float m_SplitView; // 0x60
		public StoryboardRenderMode m_RenderMode; // 0x64
		public int m_SortingOrder; // 0x68
		public float m_PlaneDistance; // 0x6C
		private List<CanvasInfo> mCanvasInfo; // 0x70
	
		// Properties
		private string CanvasName { get => default; } // 0x00000001877647A8-0x0000000187764958 
	
		// Nested types
		public enum FillStrategy // TypeDefIndex: 55393
		{
			BestFit = 0,
			CropImageToFit = 1,
			StretchToFit = 2
		}
	
		private class CanvasInfo // TypeDefIndex: 55394
		{
			// Fields
			public GameObject mCanvas; // 0x10
			public Canvas mCanvasComponent; // 0x18
			public CinemachineBrain mCanvasParent; // 0x20
			public RectTransform mViewport; // 0x28
			public RawImage mRawImage; // 0x30
	
			// Constructors
			public CanvasInfo() {} // 0x0000000187765B14-0x0000000187765C10
		}
	
		public enum StoryboardRenderMode // TypeDefIndex: 55395
		{
			ScreenSpaceOverlay = 0,
			ScreenSpaceCamera = 1
		}
	
		// Constructors
		public CinemachineStoryboard() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x0000000187765C10-0x0000000187765DB4
		private void UpdateRenderCanvas() {} // 0x0000000187764958-0x0000000187764ABC
		protected override void ConnectToVcam(bool connect) {} // 0x0000000187765EAC-0x0000000187765F18
		private void CameraUpdatedCallback(CinemachineBrain brain) {} // 0x00000001877650F8-0x00000001877654DC
		private CanvasInfo LocateMyCanvas(CinemachineBrain parent, bool createIfNotFound) => default; // 0x0000000187764ABC-0x0000000187764F08
		private void CreateCanvas(CanvasInfo ci) {} // 0x0000000187764F08-0x00000001877650F8
		private void DestroyCanvas() {} // 0x00000001877654DC-0x0000000187765B14
		private void PlaceImage(CanvasInfo ci, float alpha) {} // 0x0000000183F8FBE0-0x0000000183F8FD40
		private static void StaticBlendingHandler(CinemachineBrain brain) {} // 0x00000001852FBBD0-0x00000001852FBCF0
		private static void InitializeModule() {} // 0x0000000187765DB4-0x0000000187765EAC
	}

	public interface ICinemachineTargetGroup // TypeDefIndex: 55397
	{
		// Properties
		BoundingSphere Sphere { get; }
		bool IsEmpty { get; }
	
		// Methods
		Bounds GetViewSpaceBoundingBox(Matrix4x4 observer);
		void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange);
	}

	public class CinemachineTargetGroup : MonoBehaviour, ICinemachineTargetGroup // TypeDefIndex: 55402
	{
		// Fields
		public PositionMode m_PositionMode; // 0x18
		public RotationMode m_RotationMode; // 0x1C
		public UpdateMethod m_UpdateMethod; // 0x20
		public Target[] m_Targets; // 0x28
		private Bounds _BoundingBox_k__BackingField; // 0x30
		private float m_MaxWeight; // 0x48
		private Vector3 m_AveragePos; // 0x4C
		private BoundingSphere m_BoundingSphere; // 0x58
	
		// Properties
		public Transform Transform { get => default; } // 0x000000018646DBCC-0x000000018646DBD4 
		public Bounds BoundingBox { get; private set; } // 0x0000000185FB1D40-0x0000000185FB1D60 0x0000000185FB1D70-0x0000000185FB1D90
		public BoundingSphere Sphere { get => default; } // 0x0000000185FB1D60-0x0000000185FB1D70 
		public bool IsEmpty { get => default; } // 0x0000000187767550-0x00000001877675F8 
	
		// Nested types
		[Serializable]
		public struct Target // TypeDefIndex: 55398
		{
			// Fields
			public Transform target; // 0x00
			public float weight; // 0x08
			public float radius; // 0x0C
		}
	
		public enum PositionMode // TypeDefIndex: 55399
		{
			GroupCenter = 0,
			GroupAverage = 1
		}
	
		public enum RotationMode // TypeDefIndex: 55400
		{
			Manual = 0,
			GroupAverage = 1
		}
	
		public enum UpdateMethod // TypeDefIndex: 55401
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2
		}
	
		// Constructors
		public CinemachineTargetGroup() {} // 0x0000000185F0F020-0x0000000185F0F080
	
		// Methods
		public void AddMember(Transform t, float weight, float radius) {} // 0x0000000187765F18-0x0000000187766030
		public void RemoveMember(Transform t) {} // 0x0000000187767338-0x00000001877673FC
		public int FindMember(Transform t) => default; // 0x0000000187766A98-0x0000000187766B38
		public BoundingSphere GetWeightedBoundsForMember(int index) => default; // 0x00000001877671E0-0x0000000187767278
		public Bounds GetViewSpaceBoundingBox(Matrix4x4 observer) => default; // 0x0000000187766FE8-0x00000001877671E0
		private static BoundingSphere WeightedMemberBounds(Target t, Vector3 avgPos, float maxWeight) => default; // 0x000000018776742C-0x0000000187767550
		public void DoUpdate() {} // 0x0000000187766948-0x0000000187766A98
		private BoundingSphere CalculateBoundingSphere(float maxWeight) => default; // 0x000000018776666C-0x0000000187766948
		private Vector3 CalculateAveragePosition(out float maxWeight) {
			maxWeight = default;
			return default;
		} // 0x0000000187766224-0x0000000187766468
		private Quaternion CalculateAverageOrientation() => default; // 0x0000000187766030-0x0000000187766224
		private Bounds CalculateBoundingBox(Vector3 avgPos, float maxWeight) => default; // 0x0000000187766468-0x000000018776666C
		private void OnValidate() {} // 0x0000000187767288-0x0000000187767338
		private void FixedUpdate() {} // 0x0000000187766B38-0x0000000187766B48
		private void Update() {} // 0x00000001877673FC-0x000000018776742C
		private void LateUpdate() {} // 0x0000000187767278-0x0000000187767288
		public void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange) {
			minAngles = default;
			maxAngles = default;
			zRange = default;
		} // 0x0000000187766B48-0x0000000187766FE8
	}

	public class CinemachineVirtualCamera : CinemachineVirtualCameraBase // TypeDefIndex: 55406
	{
		// Fields
		public Transform m_LookAt; // 0xA8
		public Transform m_Follow; // 0xB0
		public LensSettings m_Lens; // 0xB8
		public TransitionParams m_Transitions; // 0xE8
		private BlendHint m_LegacyBlendHint; // 0xF8
		public const string PipelineName = "cm"; // Metadata: 0x0207BE49
		public static CreatePipelineDelegate CreatePipelineOverride; // 0x00
		public static DestroyPipelineDelegate DestroyPipelineOverride; // 0x08
		internal bool m_UserIsDragging; // 0xFC
		protected CameraState m_State; // 0x100
		private CinemachineComponentBase[] m_ComponentPipeline; // 0x220
		private Transform m_ComponentOwner; // 0x228
		private Transform mCachedLookAtTarget; // 0x230
		private CinemachineVirtualCameraBase mCachedLookAtTargetVcam; // 0x238
	
		// Properties
		public override CameraState State { get => default; } // 0x000000018527EB70-0x000000018527ED30 
		public override Transform LookAt { get => default; set {} } // 0x0000000187767DF8-0x0000000187768004 0x00000001877681D8-0x0000000187768244
		public override Transform Follow { get => default; set {} } // 0x0000000186473908-0x0000000186473920 0x0000000187768378-0x0000000187768380
	
		// Nested types
		public delegate Transform CreatePipelineDelegate(CinemachineVirtualCamera vcam, string name, CinemachineComponentBase[] copyFrom); // TypeDefIndex: 55403; 0x00000001841F3BE0-0x00000001841F3BF0
	
		public delegate void DestroyPipelineDelegate(GameObject pipeline); // TypeDefIndex: 55404; 0x00000001841F3FB0-0x00000001841F3FC0
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 55405
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<CinemachineComponentBase> __9__39_0; // 0x08
			public static Func<CinemachineComponentBase, bool> __9__48_0; // 0x10
	
			// Constructors
			static __c() {} // 0x0000000184784C70-0x0000000184784C90
			public __c() {} // 0x0000000185FB1D90-0x0000000185FB1DA0
	
			// Methods
			internal int _UpdateComponentPipeline_b__39_0(CinemachineComponentBase c1, CinemachineComponentBase c2) => default; // 0x0000000187767D6C-0x0000000187767DF8
			internal bool _RequiresUserInput_b__48_0(CinemachineComponentBase c) => default; // 0x00000001841F35B0-0x00000001841F3BE0
		}
	
		// Constructors
		public CinemachineVirtualCamera() {} // 0x0000000187768380-0x00000001877683E8
	
		// Methods
		public void SetFieldOfView(float fov) {} // 0x000000018776776C-0x0000000187767BDC
		public override float GetMaxDampTime() => default; // 0x00000001877675F8-0x000000018776776C
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x0000000186473908-0x0000000186473920
		protected override void OnEnable() {} // 0x0000000187767D4C-0x0000000187767D6C
		protected override void OnDestroy() {} // 0x000000018647467C-0x000000018647469C
		protected override void OnValidate() {} // 0x000000018582AAA0-0x000000018582AB20
		private void OnTransformChildrenChanged() {}
		private void Reset() {}
		private void DestroyPipeline() {}
		private Transform CreatePipeline(CinemachineVirtualCamera copyFrom) => default; // 0x0000000184FC7070-0x0000000184FC80C0
		public void InvalidateComponentPipeline() {} // 0x0000000184FC8120-0x0000000184FC81F0
		public Transform GetComponentOwner() => default; // 0x00000001841F4420-0x00000001841F4C90
		public CinemachineComponentBase[] GetComponentPipeline() => default; // 0x0000000187768004-0x00000001877681D8
		public CinemachineComponentBase GetCinemachineComponent(CinemachineCore.Stage stage) => default; // 0x0000000187767BDC-0x0000000187767D4C
		public new T GetCinemachineComponent<T>()
			where T : CinemachineComponentBase => default; // 0x0000000185FB1DA0-0x0000000185FB1DC0
		public T AddCinemachineComponent<T>()
			where T : CinemachineComponentBase => default; // 0x0000000185718340-0x0000000185718520
		public void DestroyCinemachineComponent<T>()
			where T : CinemachineComponentBase {} // 0x0000000187768244-0x0000000187768378
		private void UpdateComponentPipeline() {} // 0x000000018535B390-0x000000018535B550
		internal static void SetFlagsForHiddenChild(GameObject child) {} // 0x000000018775974C-0x0000000187759874
		protected CameraState CalculateNewState(Vector3 worldUp, float deltaTime) => default; // 0x00000001817E31E0-0x00000001817E3200
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x0000000187759874-0x0000000187759948
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x00000001833EEC70-0x00000001833EEC80
		internal void SetStateRawPosition(Vector3 pos) {} // 0x0000000185F78010-0x0000000185F78070
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x0000000185492010-0x0000000185492020
		internal override bool RequiresUserInput() => default; // 0x0000000184B7CD10-0x0000000184B7CD60
	}

	public class Cinemachine3rdPersonFollow : CinemachineComponentBase // TypeDefIndex: 55407
	{
		// Fields
		public Vector3 Damping; // 0x20
		public Vector3 ShoulderOffset; // 0x2C
		public float VerticalArmLength; // 0x38
		public float CameraSide; // 0x3C
		public float CameraDistance; // 0x40
		public LayerMask CameraCollisionFilter; // 0x44
		public string IgnoreTag; // 0x48
		public float CameraRadius; // 0x50
		public float DampingIntoCollision; // 0x54
		public float DampingFromCollision; // 0x58
		public bool DisableDampingCorrection; // 0x5C
		private Vector3 m_PreviousFollowTargetPosition; // 0x60
		private Vector3 m_DampingCorrection; // 0x6C
		private float m_CamPosCollisionCorrection; // 0x78
	
		// Properties
		public override bool IsValid { get => default; } // 0x0000000185190E70-0x0000000185190EF0 
		public override CinemachineCore.Stage Stage { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Constructors
		public Cinemachine3rdPersonFollow() {} // 0x0000000184B35C10-0x0000000184B35C70
	
		// Methods
		private void OnValidate() {} // 0x000000018775ABF8-0x000000018775AC74
		private void Reset() {} // 0x0000000185FB19A0-0x0000000185FB1A10
		private void OnDestroy() {} // 0x000000018775AAF8-0x000000018775AB38
		public override float GetMaxDampTime() => default; // 0x000000018775A8E8-0x000000018775A90C
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x00000001850855A0-0x0000000185085620
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x000000018775AB38-0x000000018775ABF8
		private void PositionCamera(ref CameraState curState, float deltaTime) {} // 0x00000001841EE010-0x00000001841EE490
		public void GetRigPositions(out Vector3 root, out Vector3 shoulder, out Vector3 hand) {
			root = default;
			shoulder = default;
			hand = default;
		} // 0x000000018775A90C-0x000000018775AAF8
		internal static Quaternion GetHeading(Quaternion targetRot, Vector3 up) => default; // 0x00000001841EE6C0-0x00000001841EE8A0
		private void GetRawRigPositions(Vector3 root, Quaternion targetRot, Quaternion heading, out Vector3 shoulder, out Vector3 hand) {
			shoulder = default;
			hand = default;
		} // 0x0000000184F10390-0x0000000184F10510
		private Vector3 BeyondResolveCollisions(Vector3 root, Vector3 tip, float cameraRadius) => default; // 0x000000018775A690-0x000000018775A8E8
		private Vector3 ResolveCollisions(Vector3 root, Vector3 tip, float deltaTime, float cameraRadius, ref float collisionCorrection) => default; // 0x000000018775AC74-0x000000018775AFC4
	}

	public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase // TypeDefIndex: 55408
	{
		// Fields
		public NoiseSettings m_NoiseProfile; // 0x20
		public Vector3 m_PivotOffset; // 0x28
		public float m_AmplitudeGain; // 0x34
		public float m_FrequencyGain; // 0x38
		private bool mInitialized; // 0x3C
		private float mNoiseTime; // 0x40
		private Vector3 mNoiseOffsets; // 0x44
	
		// Properties
		public override bool IsValid { get => default; } // 0x000000018775B6A8-0x000000018775B704 
		public override CinemachineCore.Stage Stage { get => default; } // 0x0000000181C6A970-0x0000000181C6A980 
	
		// Constructors
		public CinemachineBasicMultiChannelPerlin() {} // 0x000000018775B650-0x000000018775B6A8
	
		// Methods
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x000000018775B07C-0x000000018775B5CC
		public void ReSeed() {} // 0x000000018775B5CC-0x000000018775B650
		private void Initialize() {} // 0x000000018775AFC4-0x000000018775B07C
	}

	public class CinemachineComposer : CinemachineComponentBase // TypeDefIndex: 55410
	{
		// Fields
		public Vector3 m_TrackedObjectOffset; // 0x20
		public float m_LookaheadTime; // 0x2C
		public float m_LookaheadSmoothing; // 0x30
		public bool m_LookaheadIgnoreY; // 0x34
		public float m_HorizontalDamping; // 0x38
		public float m_VerticalDamping; // 0x3C
		public float m_ScreenX; // 0x40
		public float m_ScreenY; // 0x44
		public float m_DeadZoneWidth; // 0x48
		public float m_DeadZoneHeight; // 0x4C
		public float m_SoftZoneWidth; // 0x50
		public float m_SoftZoneHeight; // 0x54
		public float m_BiasX; // 0x58
		public float m_BiasY; // 0x5C
		public bool m_CenterOnActivate; // 0x60
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
		public override bool IsValid { get => default; } // 0x0000000185FB1A50-0x0000000185FB1A70 
		public override CinemachineCore.Stage Stage { get => default; } // 0x0000000185FB1A70-0x0000000185FB1A80 
		public Vector3 TrackedPoint { get; private set; } // 0x00000001841EC340-0x00000001841EDAA0 0x00000001840A27C0-0x00000001840A27D0
		protected virtual bool useTrackedObjectOffsetCollision { get => default; } // 0x0000000185FB1A30-0x0000000185FB1A50 
		internal Rect SoftGuideRect { get => default; set {} } // 0x0000000185029A00-0x0000000185029AB0 0x000000018775B850-0x000000018775B9B8
		internal Rect HardGuideRect { get => default; set {} } // 0x0000000185FB1A10-0x0000000185FB1A30 0x00000001841F28C0-0x00000001841F2FB0
	
		// Nested types
		private struct FovCache // TypeDefIndex: 55409
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
			public void UpdateCache(LensSettings lens, Rect softGuide, Rect hardGuide, float targetDistance) {} // 0x00000001841F26B0-0x00000001841F27A0
			private Rect ScreenToFOV(Rect rScreen, float fov, float fovH, float aspect) => default; // 0x0000000181B87DE0-0x0000000181B87DF0
		}
	
		// Constructors
		public CinemachineComposer() {} // 0x0000000184CFFD50-0x0000000184D00320
	
		// Methods
		protected virtual Vector3 GetLookAtPointAndSetTrackedPoint(Vector3 lookAt, Vector3 up, float deltaTime) => default; // 0x000000018775B714-0x000000018775B850
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x000000018775B704-0x000000018775B714
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x00000001841EC250-0x00000001841EC340
		public override float GetMaxDampTime() => default; // 0x00000001841F1D60-0x00000001841F2640
		public override void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime) {} // 0x00000001851758A0-0x00000001851758F0
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x000000018775B9B8-0x000000018775BA78
		public void ClearOriginalRotToRect() {} // 0x00000001841F1AB0-0x00000001841F1B40
		private void RotateToScreenBounds(ref CameraState state, Rect screenRect, Vector3 trackedPoint, ref Quaternion rigOrientation, float fov, float fovH, float deltaTime) {} // 0x0000000184B35D20-0x0000000184B35E40
		private bool ClampVerticalBounds(ref Rect r, Vector3 dir, Vector3 up, float fov) => default; // 0x00000001841EE8A0-0x00000001841EEC00
	}

	public class CinemachineFramingTransposer : CinemachineComponentBase // TypeDefIndex: 55413
	{
		// Fields
		public Vector3 m_TrackedObjectOffset; // 0x20
		public float m_LookaheadTime; // 0x2C
		public float m_LookaheadSmoothing; // 0x30
		public bool m_LookaheadIgnoreY; // 0x34
		public float m_XDamping; // 0x38
		public float m_YDamping; // 0x3C
		public float m_ZDamping; // 0x40
		public bool m_TargetMovementOnly; // 0x44
		public float m_ScreenX; // 0x48
		public float m_ScreenY; // 0x4C
		public float m_CameraDistance; // 0x50
		public float m_DeadZoneWidth; // 0x54
		public float m_DeadZoneHeight; // 0x58
		public float m_DeadZoneDepth; // 0x5C
		public bool m_UnlimitedSoftZone; // 0x60
		public float m_SoftZoneWidth; // 0x64
		public float m_SoftZoneHeight; // 0x68
		public float m_BiasX; // 0x6C
		public float m_BiasY; // 0x70
		public bool m_CenterOnActivate; // 0x74
		public FramingMode m_GroupFramingMode; // 0x78
		public AdjustmentMode m_AdjustmentMode; // 0x7C
		public float m_GroupFramingSize; // 0x80
		public float m_MaxDollyIn; // 0x84
		public float m_MaxDollyOut; // 0x88
		public float m_MinimumDistance; // 0x8C
		public float m_MaximumDistance; // 0x90
		public float m_MinimumFOV; // 0x94
		public float m_MaximumFOV; // 0x98
		public float m_MinimumOrthoSize; // 0x9C
		public float m_MaximumOrthoSize; // 0xA0
		private const float kMinimumCameraDistance = 0.01f; // Metadata: 0x0207BE4C
		private const float kMinimumGroupSize = 0.01f; // Metadata: 0x0207BE50
		private Vector3 m_PreviousCameraPosition; // 0xA4
		internal PositionPredictor m_Predictor; // 0xB0
		private Vector3 _TrackedPoint_k__BackingField; // 0xB8
		private bool m_InheritingPosition; // 0xC4
		private float m_prevFOV; // 0xC8
		private Quaternion m_prevRotation; // 0xCC
		private Bounds _LastBounds_k__BackingField; // 0xDC
		private Matrix4x4 _LastBoundsMatrix_k__BackingField; // 0xF4
	
		// Properties
		internal Rect SoftGuideRect { get => default; set {} } // 0x000000018775DD60-0x000000018775DDA8 0x000000018775DF10-0x000000018775DFD0
		internal Rect HardGuideRect { get => default; set {} } // 0x000000018775DC44-0x000000018775DCFC 0x000000018775DDA8-0x000000018775DF10
		public override bool IsValid { get => default; } // 0x000000018775DCFC-0x000000018775DD60 
		public override CinemachineCore.Stage Stage { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override bool BodyAppliesAfterAim { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public Vector3 TrackedPoint { get; private set; } // 0x0000000185FB1B00-0x0000000185FB1B20 0x0000000185FB1B70-0x0000000185FB1B90
		public Bounds LastBounds { get; private set; } // 0x0000000185FB1AE0-0x0000000185FB1B00 0x0000000185FB1B50-0x0000000185FB1B70
		public Matrix4x4 LastBoundsMatrix { get; private set; } // 0x0000000185FB1AB0-0x0000000185FB1AE0 0x0000000185FB1B20-0x0000000185FB1B50
	
		// Nested types
		public enum FramingMode // TypeDefIndex: 55411
		{
			Horizontal = 0,
			Vertical = 1,
			HorizontalAndVertical = 2,
			None = 3
		}
	
		public enum AdjustmentMode // TypeDefIndex: 55412
		{
			ZoomOnly = 0,
			DollyOnly = 1,
			DollyThenZoom = 2
		}
	
		// Constructors
		public CinemachineFramingTransposer() {} // 0x000000018775DB48-0x000000018775DC44
	
		// Methods
		private void OnValidate() {} // 0x000000018775D8A4-0x000000018775D990
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x000000018775D5D4-0x000000018775D6D4
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x0000000185FB1A80-0x0000000185FB1AB0
		public override float GetMaxDampTime() => default; // 0x000000018775BF04-0x000000018775BF1C
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) => default; // 0x000000018775D6D4-0x000000018775D8A4
		private Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect) => default; // 0x000000018775DA74-0x000000018775DB48
		private Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect) => default; // 0x000000018775D990-0x000000018775DA74
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x000000018775C4C4-0x000000018775D5D4
		private float GetTargetHeight(Vector2 boundsSize) => default; // 0x000000018775C328-0x000000018775C4C4
		private Vector3 ComputeGroupBounds(ICinemachineTargetGroup group, ref CameraState curState) => default; // 0x000000018775BA78-0x000000018775BF04
		private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, ref Vector3 pos, Quaternion orientation) => default; // 0x000000018775BF1C-0x000000018775C328
	}

	public class CinemachineGroupComposer : CinemachineComposer // TypeDefIndex: 55416
	{
		// Fields
		public float m_GroupFramingSize; // 0x110
		public FramingMode m_FramingMode; // 0x114
		public float m_FrameDamping; // 0x118
		public AdjustmentMode m_AdjustmentMode; // 0x11C
		public float m_MaxDollyIn; // 0x120
		public float m_MaxDollyOut; // 0x124
		public float m_MinimumDistance; // 0x128
		public float m_MaximumDistance; // 0x12C
		public float m_MinimumFOV; // 0x130
		public float m_MaximumFOV; // 0x134
		public float m_MinimumOrthoSize; // 0x138
		public float m_MaximumOrthoSize; // 0x13C
		private float m_prevFramingDistance; // 0x140
		private float m_prevFOV; // 0x144
		private Bounds _LastBounds_k__BackingField; // 0x148
		private Matrix4x4 _LastBoundsMatrix_k__BackingField; // 0x160
	
		// Properties
		public Bounds LastBounds { get; private set; } // 0x0000000185FB1BC0-0x0000000185FB1BE0 0x0000000185FB1C10-0x0000000185FB1C30
		public Matrix4x4 LastBoundsMatrix { get; private set; } // 0x0000000185FB1B90-0x0000000185FB1BC0 0x0000000185FB1BE0-0x0000000185FB1C10
	
		// Nested types
		public enum FramingMode // TypeDefIndex: 55414
		{
			Horizontal = 0,
			Vertical = 1,
			HorizontalAndVertical = 2
		}
	
		public enum AdjustmentMode // TypeDefIndex: 55415
		{
			ZoomOnly = 0,
			DollyOnly = 1,
			DollyThenZoom = 2
		}
	
		// Constructors
		public CinemachineGroupComposer() {} // 0x000000018775F070-0x000000018775F0E8
	
		// Methods
		private void OnValidate() {} // 0x000000018775EFA0-0x000000018775F070
		public override float GetMaxDampTime() => default; // 0x000000018775DFD0-0x000000018775DFE8
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x000000018775E44C-0x000000018775EFA0
		private float GetTargetHeight(Vector2 boundsSize) => default; // 0x000000018775E274-0x000000018775E44C
		private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, Matrix4x4 observer, out Vector3 newFwd) {
			newFwd = default;
			return default;
		} // 0x000000018775DFE8-0x000000018775E274
	}

	public class CinemachineHardLockToTarget : CinemachineComponentBase // TypeDefIndex: 55417
	{
		// Fields
		public float m_Damping; // 0x20
		private Vector3 m_PreviousTargetPosition; // 0x24
	
		// Properties
		public override bool IsValid { get => default; } // 0x000000018775F244-0x000000018775F2A8 
		public override CinemachineCore.Stage Stage { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Constructors
		public CinemachineHardLockToTarget() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public override float GetMaxDampTime() => default; // 0x0000000181C9AC70-0x0000000181C9AC80
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x000000018775F0E8-0x000000018775F244
	}

	public class CinemachineHardLookAt : CinemachineComponentBase // TypeDefIndex: 55418
	{
		// Properties
		public override bool IsValid { get => default; } // 0x000000018775F470-0x000000018775F4D4 
		public override CinemachineCore.Stage Stage { get => default; } // 0x0000000181B87DE0-0x0000000181B87DF0 
	
		// Constructors
		public CinemachineHardLookAt() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x000000018775F2A8-0x000000018775F470
	}

	public class CinemachineOrbitalTransposer : CinemachineTransposer // TypeDefIndex: 55423
	{
		// Fields
		public Heading m_Heading; // 0x98
		public AxisState.Recentering m_RecenterToTargetHeading; // 0xA4
		public AxisState m_XAxis; // 0xC0
		private float m_LegacyRadius; // 0x130
		private float m_LegacyHeightOffset; // 0x134
		private float m_LegacyHeadingBias; // 0x138
		public bool m_HeadingIsSlave; // 0x13C
		internal UpdateHeadingDelegate HeadingUpdater; // 0x140
		private Vector3 m_LastTargetPosition; // 0x148
		private HeadingTracker mHeadingTracker; // 0x158
		private Rigidbody m_TargetRigidBody; // 0x160
		private Transform m_PreviousTarget; // 0x168
		private Vector3 m_LastCameraPosition; // 0x170
		private float m_LastHeading; // 0x17C
	
		// Properties
		public override bool RequiresUserInput { get => default; } // 0x00000001877684B8-0x000000018776851C 
	
		// Nested types
		[Serializable]
		public struct Heading // TypeDefIndex: 55420
		{
			// Fields
			public HeadingDefinition m_Definition; // 0x00
			public int m_VelocityFilterStrength; // 0x04
			public float m_Bias; // 0x08
	
			// Nested types
			public enum HeadingDefinition // TypeDefIndex: 55419
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
			} // 0x000000018776086C-0x00000001877609C4
		}
	
		internal delegate float UpdateHeadingDelegate(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up); // TypeDefIndex: 55421; 0x0000000187760A04-0x0000000187760B38
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 55422
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static UpdateHeadingDelegate __9__30_0; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000187760530-0x0000000187760578
			public __c() {} // 0x0000000187760B38-0x0000000187760BF8
	
			// Methods
			internal float _.ctor_b__30_0(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up) => default; // 0x0000000187760578-0x00000001877606B8
		}
	
		// Constructors
		public CinemachineOrbitalTransposer() {} // 0x00000001877683E8-0x00000001877684B8
	
		// Methods
		protected override void OnValidate() {} // 0x000000018775F4D4-0x000000018775F614
		public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis) => default; // 0x00000001877606B8-0x000000018776086C
		public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis, ref AxisState.Recentering recentering, bool isLive) => default; // 0x000000018775F614-0x000000018775F934
		private void OnEnable() {} // 0x000000018775FE50-0x0000000187760530
		public void UpdateInputAxisProvider() {} // 0x000000018775F934-0x000000018775FA90
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x00000001840A27C0-0x00000001840A27D0
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x000000018775FA90-0x000000018775FE50
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) => default; // 0x0000000187760BF8-0x0000000187760E84
		public float GetAxisClosestValue(Vector3 cameraPos, Vector3 up) => default; // 0x0000000185FB1DC0-0x0000000185FB1DD0
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x0000000187768554-0x000000018776867C
		public override Vector3 GetTargetCameraPosition(Vector3 worldUp) => default; // 0x000000018776851C-0x0000000187768554
		private float GetTargetHeading(float currentHeading, Quaternion targetOrientation) => default; // 0x0000000185492010-0x0000000185492020
	}

	public class CinemachinePOV : CinemachineComponentBase // TypeDefIndex: 55425
	{
		// Fields
		public RecenterTargetMode m_RecenterTarget; // 0x20
		public AxisState m_VerticalAxis; // 0x28
		public AxisState.Recentering m_VerticalRecentering; // 0x98
		public AxisState m_HorizontalAxis; // 0xB8
		public AxisState.Recentering m_HorizontalRecentering; // 0x128
		public bool m_ApplyBeforeBody; // 0x144
	
		// Properties
		public override bool IsValid { get => default; } // 0x0000000187761D00-0x0000000187761D08 
		public override CinemachineCore.Stage Stage { get => default; } // 0x0000000181B87DE0-0x0000000181B87DF0 
		public override bool RequiresUserInput { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
	
		// Nested types
		public enum RecenterTargetMode // TypeDefIndex: 55424
		{
			None = 0,
			FollowTargetForward = 1,
			LookAtTargetForward = 2
		}
	
		// Constructors
		public CinemachinePOV() {} // 0x0000000187761AA4-0x0000000187761D00
	
		// Methods
		private void OnValidate() {} // 0x0000000187761510-0x0000000187761590
		private void OnEnable() {} // 0x0000000187761368-0x0000000187761370
		public void UpdateInputAxisProvider() {} // 0x00000001877619AC-0x0000000187761AA4
		public override void PrePipelineMutateCameraState(ref CameraState state, float deltaTime) {} // 0x0000000185492010-0x0000000185492020
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x00000001877610D4-0x0000000187761368
		public Vector2 GetRecenterTarget() => default; // 0x0000000187760EA4-0x00000001877610D4
		private static float NormalizeAngle(float angle) => default; // 0x0000000185FB1C30-0x0000000185FB1C60
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x0000000187760E84-0x0000000187760EA4
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) => default; // 0x0000000187761370-0x0000000187761510
		private void SetAxesForRotation(Quaternion targetRot) {} // 0x0000000187761590-0x00000001877619AC
	}

	public class CinemachineSameAsFollowTarget : CinemachineComponentBase // TypeDefIndex: 55426
	{
		// Fields
		public float m_Damping; // 0x20
		private Quaternion m_PreviousReferenceOrientation; // 0x24
	
		// Properties
		public override bool IsValid { get => default; } // 0x000000018776C4B0-0x000000018776C514 
		public override CinemachineCore.Stage Stage { get => default; } // 0x0000000181B87DE0-0x0000000181B87DF0 
	
		// Constructors
		public CinemachineSameAsFollowTarget() {} // 0x0000000184B35B60-0x0000000184B35B90
	
		// Methods
		public override float GetMaxDampTime() => default; // 0x0000000181C9AC70-0x0000000181C9AC80
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x000000018776C3B8-0x000000018776C4B0
	}

	public class CinemachineTrackedDolly : CinemachineComponentBase // TypeDefIndex: 55429
	{
		// Fields
		public CinemachinePathBase m_Path; // 0x20
		public float m_PathPosition; // 0x28
		public CinemachinePathBase.PositionUnits m_PositionUnits; // 0x2C
		public Vector3 m_PathOffset; // 0x30
		public float m_XDamping; // 0x3C
		public float m_YDamping; // 0x40
		public float m_ZDamping; // 0x44
		public CameraUpMode m_CameraUp; // 0x48
		public float m_PitchDamping; // 0x4C
		public float m_YawDamping; // 0x50
		public float m_RollDamping; // 0x54
		public AutoDolly m_AutoDolly; // 0x58
		private float m_PreviousPathPosition; // 0x68
		private Quaternion m_PreviousOrientation; // 0x6C
		private Vector3 m_PreviousCameraPosition; // 0x7C
	
		// Properties
		public override bool IsValid { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override CinemachineCore.Stage Stage { get => default; } // 0x000000018776C750-0x000000018776C7A8 
		private Vector3 AngularDamping { get => default; } // 0x0000000184B35B90-0x0000000184B35C10 
	
		// Nested types
		public enum CameraUpMode // TypeDefIndex: 55427
		{
			Default = 0,
			Path = 1,
			PathNoRoll = 2,
			FollowTarget = 3,
			FollowTargetNoRoll = 4
		}
	
		[Serializable]
		public struct AutoDolly // TypeDefIndex: 55428
		{
			// Fields
			public bool m_Enabled; // 0x00
			public float m_PositionOffset; // 0x04
			public int m_SearchRadius; // 0x08
			public int m_SearchResolution; // 0x0C
	
			// Constructors
			public AutoDolly(bool enabled, float positionOffset, int searchRadius, int stepsPerSegment) {
				m_Enabled = default;
				m_PositionOffset = default;
				m_SearchRadius = default;
				m_SearchResolution = default;
			} // 0x000000018776D038-0x000000018776D094
		}
	
		// Constructors
		public CinemachineTrackedDolly() {} // 0x0000000185FB1E50-0x0000000185FB1E70
	
		// Methods
		public override float GetMaxDampTime() => default; // 0x000000018776C7A8-0x000000018776CFC8
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x000000018776C514-0x000000018776C750
		private Quaternion GetCameraOrientationAtPathPoint(Quaternion pathOrientation, Vector3 up) => default; // 0x000000018776CFC8-0x000000018776D038
	}

	public class CinemachineTransposer : CinemachineComponentBase // TypeDefIndex: 55432
	{
		// Fields
		public BindingMode m_BindingMode; // 0x20
		public Vector3 m_FollowOffset; // 0x24
		public float m_XDamping; // 0x30
		public float m_YDamping; // 0x34
		public float m_ZDamping; // 0x38
		public AngularDampingMode m_AngularDampingMode; // 0x3C
		public float m_PitchDamping; // 0x40
		public float m_YawDamping; // 0x44
		public float m_RollDamping; // 0x48
		public float m_AngularDamping; // 0x4C
		private bool _HideOffsetInInspector_k__BackingField; // 0x50
		private Vector3 m_PreviousTargetPosition; // 0x54
		private Quaternion m_PreviousReferenceOrientation; // 0x60
		private Quaternion m_targetOrientationOnAssign; // 0x70
		private Vector3 m_PreviousOffset; // 0x80
		private Transform m_previousTarget; // 0x90
	
		// Properties
		public bool HideOffsetInInspector { get; set; } // 0x00000001813ECBE0-0x00000001813ECBF0 0x00000001813EE9A0-0x00000001813EE9B0
		public Vector3 EffectiveOffset { get => default; } // 0x00000001841313C0-0x00000001841313E0 
		public override bool IsValid { get => default; } // 0x00000001856A3450-0x00000001856A34D0 
		public override CinemachineCore.Stage Stage { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		protected Vector3 Damping { get => default; } // 0x0000000184131040-0x0000000184131070 
		protected Vector3 AngularDamping { get => default; } // 0x0000000184131070-0x00000001841310A0 
	
		// Nested types
		public enum BindingMode // TypeDefIndex: 55430
		{
			LockToTargetOnAssign = 0,
			LockToTargetWithWorldUp = 1,
			LockToTargetNoRoll = 2,
			LockToTarget = 3,
			WorldSpace = 4,
			SimpleFollowWithWorldUp = 5
		}
	
		public enum AngularDampingMode // TypeDefIndex: 55431
		{
			Euler = 0,
			Quaternion = 1
		}
	
		// Constructors
		public CinemachineTransposer() {} // 0x0000000184B35C70-0x0000000184B35D20
	
		// Methods
		protected virtual void OnValidate() {} // 0x000000018776D468-0x000000018776D498
		public override float GetMaxDampTime() => default; // 0x000000018776D214-0x000000018776D294
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x00000001841310A0-0x00000001841313C0
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x000000018776D3A8-0x000000018776D468
		public override void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x000000018776D094-0x000000018776D214
		protected void InitPrevFrameStateInfo(ref CameraState curState, float deltaTime) {} // 0x00000001841318E0-0x0000000184131A60
		protected void TrackTarget(float deltaTime, Vector3 up, Vector3 desiredCameraOffset, out Vector3 outTargetPosition, out Quaternion outTargetOrient) {
			outTargetPosition = default;
			outTargetOrient = default;
		} // 0x0000000184132170-0x0000000184132A70
		protected Vector3 GetOffsetForMinimumTargetDistance(Vector3 dampedTargetPos, Vector3 cameraOffset, Vector3 cameraFwd, Vector3 up, Vector3 actualTargetPos) => default; // 0x00000001841313E0-0x00000001841318E0
		public virtual Vector3 GetTargetCameraPosition(Vector3 worldUp) => default; // 0x000000018776D294-0x000000018776D3A8
		public Quaternion GetReferenceOrientation(Vector3 worldUp) => default; // 0x0000000184131A60-0x0000000184131B60
	}

	[Serializable]
	public struct AxisState // TypeDefIndex: 55436
	{
		// Fields
		public float Value; // 0x00
		public SpeedMode m_SpeedMode; // 0x04
		public float m_MaxSpeed; // 0x08
		public float m_AccelTime; // 0x0C
		public float m_DecelTime; // 0x10
		public string m_InputAxisName; // 0x18
		public float m_InputAxisValue; // 0x20
		public bool m_InvertInput; // 0x24
		public float m_MinValue; // 0x28
		public float m_MaxValue; // 0x2C
		public bool m_Wrap; // 0x30
		public Recentering m_Recentering; // 0x34
		private float m_CurrentSpeed; // 0x50
		private float m_LastUpdateTime; // 0x54
		private int m_LastUpdateFrame; // 0x58
		private const float Epsilon = 0.0001f; // Metadata: 0x0207BE75
		private IInputAxisProvider m_InputAxisProvider; // 0x60
		private int m_InputAxisIndex; // 0x68
		private bool _ValueRangeLocked_k__BackingField; // 0x6C
		private bool _HasRecentering_k__BackingField; // 0x6D
	
		// Properties
		public bool ValueRangeLocked { get; set; } // 0x000000018776F610-0x000000018776F7AC
		public bool HasRecentering { get; set; } // 0x000000018776F7AC-0x000000018776F7D4
	
		// Nested types
		public enum SpeedMode // TypeDefIndex: 55433
		{
			MaxSpeed = 0,
			InputValueGain = 1
		}
	
		public interface IInputAxisProvider // TypeDefIndex: 55434
		{
			// Methods
			float GetAxisValue(int axis); // 0x000000018776936C-0x000000018776944C
		}
	
		[Serializable]
		public struct Recentering // TypeDefIndex: 55435
		{
			// Fields
			public bool m_enabled; // 0x00
			public float m_WaitTime; // 0x04
			public float m_RecenteringTime; // 0x08
			private float mLastAxisInputTime; // 0x0C
			private float mRecenteringVelocity; // 0x10
			private int m_LegacyHeadingDefinition; // 0x14
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
			} // 0x0000000187769324-0x000000018776936C
	
			// Methods
			public void Validate() {} // 0x0000000185FB1E70-0x0000000185FB1E80
			public void CancelRecentering() {} // 0x0000000187768F48-0x0000000187768F58
			public void DoRecentering(ref AxisState axis, float deltaTime, float recenterTarget) {} // 0x0000000187768F58-0x0000000187769324
			internal bool LegacyUpgrade(ref int heading, ref int velocityFilter) => default; // 0x0000000187768C80-0x0000000187768CF0
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
			<ValueRangeLocked>k__BackingField = default;
			<HasRecentering>k__BackingField = default;
		} // 0x0000000187768D68-0x0000000187768F48
	
		// Methods
		public void Validate() {} // 0x0000000187768CF0-0x0000000187768D68
		public void Reset() {} // 0x0000000185FB1E80-0x0000000185FB1E90
		public void SetInputAxisProvider(int axis, IInputAxisProvider provider) {} // 0x0000000182F7C820-0x0000000182F7C830
		public bool Update(float deltaTime) => default;
		private float ClampValue(float v) => default; // 0x0000000185FB1F90-0x0000000185FB1FB0
		private bool MaxSpeedUpdate(float input, float deltaTime) => default; // 0x000000018776F7D4-0x000000018776F7F4
		private float GetMaxSpeed() => default; // 0x000000018776F5BC-0x000000018776F610
	}

	public struct CameraState // TypeDefIndex: 55440
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
		private int _NumCustomBlendables_k__BackingField; // 0x118
	
		// Properties
		public bool HasLookAt { get => default; } // 0x00000001841F2640-0x00000001841F26B0 
		public Vector3 CorrectedPosition { get => default; } // 0x00000001841F97D0-0x00000001841F9820 
		public Quaternion CorrectedOrientation { get => default; } // 0x00000001841F2640-0x00000001841F26B0 
		public Vector3 FinalPosition { get => default; } // 0x00000001841F9730-0x00000001841F97D0 
		public Quaternion FinalOrientation { get => default; } // 0x00000001841F5B20-0x00000001841F5CA0 
		public static CameraState Default { get => default; } // 0x0000000185FB1F40-0x0000000185FB1F50 
		public int NumCustomBlendables { get; private set; } // 0x0000000185FB1F50-0x0000000185FB1F60 0x000000018776A85C-0x000000018776A948
	
		// Nested types
		public struct HGDOFParams // TypeDefIndex: 55437
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
	
		public enum BlendHintValue // TypeDefIndex: 55438
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
	
		public struct CustomBlendable // TypeDefIndex: 55439
		{
			// Fields
			public UnityEngine.Object m_Custom; // 0x00
			public float m_Weight; // 0x08
	
			// Constructors
			public CustomBlendable(UnityEngine.Object custom, float weight) {
				m_Custom = default;
				m_Weight = default;
			} // 0x000000018646E270-0x000000018646E2C4
		}
	
		// Constructors
		static CameraState() {
			kNoPoint = default;
		} // 0x000000018776EF4C-0x000000018776EF68
	
		// Methods
		public CustomBlendable GetCustomBlendable(int index) => default; // 0x000000018776A6D8-0x000000018776A85C
		private int FindCustomBlendable(UnityEngine.Object custom) => default; // 0x000000018776A52C-0x000000018776A6D8
		public void AddCustomBlendable(CustomBlendable b) {} // 0x0000000184286480-0x0000000184287450
		public static CameraState Lerp(in CameraState stateA, in CameraState stateB, float t) => default; // 0x000000018776A948-0x000000018776AA74
		private static float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t) => default; // 0x0000000184287480-0x00000001842874B0
		private static Vector3 ApplyPosBlendHint(Vector3 posA, BlendHintValue hintA, Vector3 posB, BlendHintValue hintB, Vector3 original, Vector3 blended) => default; // 0x0000000184287450-0x0000000184287480
		private static Quaternion ApplyRotBlendHint(Quaternion rotA, BlendHintValue hintA, Quaternion rotB, BlendHintValue hintB, Quaternion original, Quaternion blended) => default; // 0x0000000184285DB0-0x00000001842861F0
		private Vector3 InterpolatePosition(Vector3 posA, Vector3 pivotA, Vector3 posB, Vector3 pivotB, float t, ref int positionCylindricalDir) => default; // 0x0000000185F89D90-0x0000000185F89DE0
	}

	public class CinemachineBlend // TypeDefIndex: 55441
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
		public ICinemachineCamera CamA { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x00000001841FA1F0-0x00000001841FA300
		public float BlendWeight { get => default; } // 0x000000018776AA74-0x000000018776AAEC 
		public bool IsValid { get => default; } // 0x000000018776ACBC-0x000000018776AD04 
		public bool IsComplete { get => default; } // 0x000000018776AC94-0x000000018776ACBC 
		public string Description { get => default; } // 0x000000018776AAEC-0x000000018776AC94 
		public CameraState State { get => default; } // 0x00000001841F9490-0x00000001841F9730 
	
		// Constructors
		public CinemachineBlend() {} // Dummy constructor
		public CinemachineBlend(ICinemachineCamera a, ICinemachineCamera b, AnimationCurve curve, float duration, float t) {} // 0x000000018508E570-0x000000018508E5E0
	
		// Methods
		public void StartSimpleInertialization() {} // 0x0000000185FB1F60-0x0000000185FB1F70
		public bool Uses(ICinemachineCamera cam) => default; // 0x00000001841F7EB0-0x00000001841F7F40
		public void UpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x00000001841F8400-0x00000001841F84E0
	}

	[Serializable]
	public struct CinemachineBlendDefinition // TypeDefIndex: 55443
	{
		// Fields
		public Style m_Style; // 0x00
		public float m_Time; // 0x04
		public AnimationCurve m_CustomCurve; // 0x08
		private static AnimationCurve[] sStandardCurves; // 0x00
		public bool m_UseSimpleInertialization; // 0x10
	
		// Properties
		public float BlendTime { get => default; } // 0x00000001842862E0-0x00000001842862F0 
		public AnimationCurve BlendCurve { get => default; } // 0x00000001842880A0-0x0000000184288130 
	
		// Nested types
		public enum Style // TypeDefIndex: 55442
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
		} // 0x00000001864731B0-0x00000001864731DC
	
		// Methods
		private void CreateStandardCurves() {} // 0x0000000184287B80-0x00000001842880A0
	}

	internal class StaticPointVirtualCamera : ICinemachineCamera // TypeDefIndex: 55444
	{
		// Fields
		private string _Name_k__BackingField; // 0x10
		private int _Priority_k__BackingField; // 0x18
		private Transform _LookAt_k__BackingField; // 0x20
		private Transform _Follow_k__BackingField; // 0x28
		private CameraState _State_k__BackingField; // 0x30
	
		// Properties
		public string Name { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public int Priority { get; } // 0x00000001813AE560-0x00000001813AE570 
		public Transform LookAt { get; } // 0x00000001813B31A0-0x00000001813B31B0 
		public Transform Follow { get; } // 0x00000001813B8590-0x00000001813B85A0 
		public CameraState State { get; private set; } // 0x0000000185FB1EC0-0x0000000185FB1F40 0x000000018776A008-0x000000018776A07C
		public GameObject VirtualCameraGameObject { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public bool IsValid { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public ICinemachineCamera ParentCamera { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Constructors
		public StaticPointVirtualCamera() {} // Dummy constructor
		public StaticPointVirtualCamera(in CameraState state, string name) {} // 0x000000018776FFC4-0x00000001877700BC
	
		// Methods
		public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0207BE8D */) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public void UpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x0000000185492010-0x0000000185492020
		public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x0000000185492010-0x0000000185492020
	}

	internal class BlendSourceVirtualCamera : ICinemachineCamera // TypeDefIndex: 55445
	{
		// Fields
		private CinemachineBlend _Blend_k__BackingField; // 0x10
		private int _Priority_k__BackingField; // 0x18
		private Transform _LookAt_k__BackingField; // 0x20
		private Transform _Follow_k__BackingField; // 0x28
		private CameraState _State_k__BackingField; // 0x30
	
		// Properties
		public CinemachineBlend Blend { get; set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public string Name { get => default; } // 0x0000000187769FDC-0x000000018776A008 
		public int Priority { get; } // 0x00000001813AE560-0x00000001813AE570 
		public Transform LookAt { get; } // 0x00000001813B31A0-0x00000001813B31B0 
		public Transform Follow { get; } // 0x00000001813B8590-0x00000001813B85A0 
		public CameraState State { get; private set; } // 0x0000000185FB1EC0-0x0000000185FB1F40 0x000000018776A008-0x000000018776A07C
		public GameObject VirtualCameraGameObject { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public bool IsValid { get => default; } // 0x0000000187769FC4-0x0000000187769FDC 
		public ICinemachineCamera ParentCamera { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Constructors
		public BlendSourceVirtualCamera() {} // Dummy constructor
		public BlendSourceVirtualCamera(CinemachineBlend blend) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0207BE8E */) => default; // 0x0000000187769ED0-0x0000000187769EF0
		public void UpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x0000000187769EF0-0x0000000187769FC4
		public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public sealed class CinemachineBlenderSettings : ScriptableObject // TypeDefIndex: 55448
	{
		// Fields
		public CustomBlend[] m_CustomBlends; // 0x18
		public CustomBlendGroup[] m_CustomBlendGroups; // 0x20
		public const string kBlendFromAnyCameraLabel = "**ANY CAMERA**"; // Metadata: 0x0207BE8F
	
		// Nested types
		[Serializable]
		public struct CustomBlend // TypeDefIndex: 55446
		{
			// Fields
			public string m_From; // 0x00
			public string m_To; // 0x08
			public CinemachineBlendDefinition m_Blend; // 0x10
		}
	
		[Serializable]
		public class CustomBlendGroup // TypeDefIndex: 55447
		{
			// Fields
			public List<string> cameras; // 0x10
			public CinemachineBlendDefinition fromSameCamera; // 0x18
			public CinemachineBlendDefinition insideGroup; // 0x30
			public CinemachineBlendDefinition toGroup; // 0x48
			public CinemachineBlendDefinition fromGroup; // 0x60
	
			// Constructors
			public CustomBlendGroup() {} // 0x0000000184E097D0-0x0000000184E09B40
		}
	
		// Constructors
		public CinemachineBlenderSettings() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public CinemachineBlendDefinition GetBlendForVirtualCameras(string fromCameraName, string toCameraName, CinemachineBlendDefinition defaultBlend) => default; // 0x0000000184BBD7B0-0x0000000184BBD7C0
	}

	public abstract class CinemachineComponentBase : MonoBehaviour // TypeDefIndex: 55449
	{
		// Fields
		protected const float Epsilon = 0.0001f; // Metadata: 0x0207BE9E
		private CinemachineVirtualCameraBase m_vcamOwner; // 0x18
	
		// Properties
		public CinemachineVirtualCameraBase VirtualCamera { get; } // 0x00000001841F3D20-0x00000001841F3FB0 
		public Transform FollowTarget { get; } // 0x00000001841F2FB0-0x00000001841F3120 
		public Transform LookAtTarget { get; } // 0x00000001841F3120-0x00000001841F3290 
		public ICinemachineTargetGroup AbstractFollowTargetGroup { get; } // 0x000000018776AD04-0x000000018776AD28 
		public CinemachineTargetGroup FollowTargetGroup { get; } // 0x000000018776AD4C-0x000000018776AD90 
		public Vector3 FollowTargetPosition { get; } // 0x00000001841EE5A0-0x00000001841EE6C0 
		public Quaternion FollowTargetRotation { get; } // 0x00000001841EE490-0x00000001841EE5A0 
		public ICinemachineTargetGroup AbstractLookAtTargetGroup { get; } // 0x000000018776AD28-0x000000018776AD4C 
		public CinemachineTargetGroup LookAtTargetGroup { get; } // 0x000000018776AD90-0x000000018776ADD4 
		public Vector3 LookAtTargetPosition { get; } // 0x000000018776ADD4-0x000000018776AF5C 
		public Quaternion LookAtTargetRotation { get; } // 0x00000001841EDAA0-0x00000001841EDBB0 
		public CameraState VcamState { get; } // 0x000000018776AF5C-0x000000018776B0C4 
		public abstract bool IsValid { get; }
		public abstract CinemachineCore.Stage Stage { get; }
		public virtual bool BodyAppliesAfterAim { get; } // 0x00000001814A81B0-0x00000001814A81C0 
		public virtual bool RequiresUserInput { get; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		protected CinemachineComponentBase() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public virtual void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime) {} // 0x0000000185492010-0x0000000185492020
		public abstract void MutateCameraState(ref CameraState curState, float deltaTime);
		public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x0000000185492010-0x0000000185492020
		public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x0000000185492010-0x0000000185492020
		public virtual float GetMaxDampTime() => default; // 0x0000000183908D00-0x0000000183908D10
	}

	public sealed class CinemachineCore // TypeDefIndex: 55456
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
		public static CinemachineCore Instance { get => default; } // 0x00000001841F6CB0-0x00000001841F6D90 
		public static float DeltaTime { get => default; } // 0x000000018527F480-0x000000018527F4F0 
		public static float CurrentTime { get => default; } // 0x000000018527F3F0-0x000000018527F480 
		public int BrainCount { get => default; } // 0x000000018776B0C4-0x000000018776B190 
		public int VirtualCameraCount { get => default; } // 0x00000001841F5180-0x00000001841F5550 
	
		// Nested types
		public enum Stage // TypeDefIndex: 55450
		{
			Body = 0,
			Aim = 1,
			Noise = 2,
			Finalize = 3
		}
	
		public delegate float AxisInputDelegate(string axisName); // TypeDefIndex: 55451; 0x000000018776B6A0-0x000000018776B710
	
		public delegate CinemachineBlendDefinition GetBlendOverrideDelegate(ICinemachineCamera fromVcam, ICinemachineCamera toVcam, CinemachineBlendDefinition defaultBlend, MonoBehaviour owner); // TypeDefIndex: 55452; 0x00000001841F6220-0x00000001841F6260
	
		private class UpdateStatus // TypeDefIndex: 55453
		{
			// Fields
			public int lastUpdateFrame; // 0x10
			public int lastUpdateFixedFrame; // 0x14
			public UpdateTracker.UpdateClock lastUpdateMode; // 0x18
			public float lastUpdateDeltaTime; // 0x1C
	
			// Constructors
			public UpdateStatus() {} // 0x00000001841F73D0-0x00000001841F7440
		}
	
		internal enum UpdateFilter // TypeDefIndex: 55454
		{
			Fixed = 0,
			Late = 1,
			Smart = 8,
			SmartFixed = 8,
			SmartLate = 9
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 55455
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<CinemachineVirtualCameraBase> __9__30_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018508F3A0-0x000000018508F410
			public __c() {} // 0x000000018508F410-0x000000018508F470
	
			// Methods
			internal int _GetVirtualCamera_b__30_0(CinemachineVirtualCameraBase x, CinemachineVirtualCameraBase y) => default; // 0x00000001841F7390-0x00000001841F73D0
		}
	
		// Constructors
		public CinemachineCore() {} // 0x0000000185492010-0x0000000185492020
		static CinemachineCore() {} // 0x0000000187770310-0x0000000187770344
	
		// Methods
		public CinemachineBrain GetActiveBrain(int index) => default; // 0x000000018527F4F0-0x000000018527F6F0
		internal void AddActiveBrain(CinemachineBrain brain) {} // 0x000000018527F1F0-0x000000018527F2E0
		internal void RemoveActiveBrain(CinemachineBrain brain) {} // 0x00000001841F7F40-0x00000001841F8390
		public CinemachineVirtualCameraBase GetVirtualCamera(int index) => default; // 0x0000000185F0DE00-0x0000000185F0DEB0
		internal void AddActiveCamera(CinemachineVirtualCameraBase vcam) {} // 0x000000018776B3D8-0x000000018776B4D0
		internal void RemoveActiveCamera(CinemachineVirtualCameraBase vcam) {} // 0x000000018776B4D0-0x000000018776B54C
		internal void CameraDestroyed(CinemachineVirtualCameraBase vcam) {} // 0x00000001841F5FA0-0x00000001841F6220
		internal void CameraEnabled(CinemachineVirtualCameraBase vcam) {} // 0x000000018776B54C-0x000000018776B60C
		internal void CameraDisabled(CinemachineVirtualCameraBase vcam) {} // 0x000000018776B190-0x000000018776B288
		internal void UpdateAllActiveVirtualCameras(int layerMask, Vector3 worldUp, float deltaTime) {} // 0x000000018776B288-0x000000018776B3D8
		internal void UpdateVirtualCamera(CinemachineVirtualCameraBase vcam, Vector3 worldUp, float deltaTime) {} // 0x00000001841F6260-0x00000001841F6780
		private static void InitializeModule() {} // 0x000000018776B60C-0x000000018776B6A0
		private static Transform GetUpdateTarget(CinemachineVirtualCameraBase vcam) => default; // 0x000000018527EA60-0x000000018527EB70
		internal UpdateTracker.UpdateClock GetVcamUpdateStatus(CinemachineVirtualCameraBase vcam) => default; // 0x000000018508E1D0-0x000000018508E3D0
		public bool IsLive(ICinemachineCamera vcam) => default; // 0x000000018508E5E0-0x000000018508E670
		public bool IsLiveInBlend(ICinemachineCamera vcam) => default; // 0x00000001817C2F70-0x00000001817C2F80
		public void GenerateCameraActivationEvent(ICinemachineCamera vcam, ICinemachineCamera vcamFrom) {} // 0x00000001852FBE90-0x00000001852FBF10
		public void GenerateCameraCutEvent(ICinemachineCamera vcam) {} // 0x000000018776EF68-0x000000018776EFD8
		public CinemachineBrain FindPotentialTargetBrain(CinemachineVirtualCameraBase vcam) => default; // 0x0000000185492010-0x0000000185492020
		public void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x0000000187770400-0x0000000187770464
	}

	public abstract class CinemachineExtension : MonoBehaviour // TypeDefIndex: 55457
	{
		// Fields
		protected const float Epsilon = 0.0001f; // Metadata: 0x0207BEAB
		private CinemachineVirtualCameraBase m_vcamOwner; // 0x18
		private Dictionary<ICinemachineCamera, object> mExtraState; // 0x20
	
		// Properties
		public CinemachineVirtualCameraBase VirtualCamera { get; } // 0x00000001841EBBF0-0x00000001841EBC80 
		public virtual bool RequiresUserInput { get; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		protected CinemachineExtension() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected virtual void Awake() {} // 0x0000000185EF5F50-0x0000000185EF5F60
		protected virtual void OnEnable() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnDestroy() {} // 0x000000018776B710-0x000000018776B720
		internal void EnsureStarted() {} // 0x0000000185EF5F50-0x0000000185EF5F60
		protected virtual void ConnectToVcam(bool connect) {} // 0x00000001841EA5E0-0x00000001841EA700
		public virtual void PrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState curState, float deltaTime) {} // 0x0000000185492010-0x0000000185492020
		public void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x000000018646E2C4-0x000000018646E2E4
		protected abstract void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime);
		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x0000000185492010-0x0000000185492020
		public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x0000000185492010-0x0000000185492020
		public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual float GetMaxDampTime() => default; // 0x0000000183908D00-0x0000000183908D10
		protected T GetExtraState<T>(ICinemachineCamera vcam)
			where T : class, new() => default;
		protected List<T> GetAllExtraStates<T>()
			where T : class, new() => default;
	}

	public abstract class CinemachinePathBase : MonoBehaviour // TypeDefIndex: 55460
	{
		// Fields
		public int m_Resolution; // 0x18
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
		public abstract bool Looped { get; } // 0x000000018776C0B4-0x000000018776C158 
		public abstract int DistanceCacheSampleStepsPerSegment { get; } // 0x000000018776BC9C-0x000000018776BCCC 
		public float PathLength { get; } // 0x000000018776C020-0x000000018776C0B4 
	
		// Nested types
		[Serializable]
		public class Appearance // TypeDefIndex: 55458
		{
			// Fields
			public UnityEngine.Color pathColor; // 0x10
			public UnityEngine.Color inactivePathColor; // 0x20
			public float width; // 0x30
	
			// Constructors
			public Appearance() {}
		}
	
		public enum PositionUnits // TypeDefIndex: 55459
		{
			PathUnits = 0,
			Distance = 1,
			Normalized = 2
		}
	
		// Constructors
		protected CinemachinePathBase() {} // 0x0000000187768C48-0x0000000187768C80
	
		// Methods
		public virtual float StandardizePos(float pos) => default;
		public abstract Vector3 EvaluatePosition(float pos);
		public abstract Vector3 EvaluateTangent(float pos);
		public abstract Quaternion EvaluateOrientation(float pos); // 0x000000018776B88C-0x000000018776BBA0
		public virtual float FindClosestPoint(Vector3 p, int startSegment, int searchRadius, int stepsPerSegment) => default; // 0x000000018776BD04-0x000000018776BD2C
		public float MinUnit(PositionUnits units) => default; // 0x000000018776BCCC-0x000000018776BD04
		public float MaxUnit(PositionUnits units) => default; // 0x000000018776C158-0x000000018776C1D0
		public virtual float StandardizeUnit(float pos, PositionUnits units) => default; // 0x000000018776B7E4-0x000000018776B838
		public Vector3 EvaluatePositionAtUnit(float pos, PositionUnits units) => default; // 0x000000018776B838-0x000000018776B88C
		public Vector3 EvaluateTangentAtUnit(float pos, PositionUnits units) => default; // 0x000000018776B798-0x000000018776B7E4
		public Quaternion EvaluateOrientationAtUnit(float pos, PositionUnits units) => default;
		public virtual void InvalidateDistanceCache() {} // 0x000000018776B720-0x000000018776B798
		public bool DistanceCacheIsValid() => default; // 0x000000018776C364-0x000000018776C3B8
		public float StandardizePathDistance(float distance) => default; // 0x000000018776C1D0-0x000000018776C2EC
		public float ToNativePathUnits(float pos, PositionUnits units) => default; // 0x000000018776BBA0-0x000000018776BC9C
		public float FromPathNativeUnits(float pos, PositionUnits units) => default; // 0x000000018776BD2C-0x000000018776C020
		private void ResamplePath(int stepsPerSegment) {} // 0x000000018776C2EC-0x000000018776C364
	}

	public sealed class AxisStatePropertyAttribute : PropertyAttribute // TypeDefIndex: 55461
	{
		// Constructors
		public AxisStatePropertyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class OrbitalTransposerHeadingPropertyAttribute : PropertyAttribute // TypeDefIndex: 55462
	{
		// Constructors
		public OrbitalTransposerHeadingPropertyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class VcamTargetPropertyAttribute : PropertyAttribute // TypeDefIndex: 55463
	{
		// Constructors
		public VcamTargetPropertyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class CinemachineBlendDefinitionPropertyAttribute : PropertyAttribute // TypeDefIndex: 55464
	{
		// Constructors
		public CinemachineBlendDefinitionPropertyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class SaveDuringPlayAttribute : Attribute // TypeDefIndex: 55465
	{
		// Constructors
		public SaveDuringPlayAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class NoSaveDuringPlayAttribute : PropertyAttribute // TypeDefIndex: 55466
	{
		// Constructors
		public NoSaveDuringPlayAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class TagFieldAttribute : PropertyAttribute // TypeDefIndex: 55467
	{
		// Constructors
		public TagFieldAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class NoiseSettingsPropertyAttribute : PropertyAttribute // TypeDefIndex: 55468
	{
		// Constructors
		public NoiseSettingsPropertyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class CinemachineEmbeddedAssetPropertyAttribute : PropertyAttribute // TypeDefIndex: 55469
	{
		// Fields
		public bool WarnIfNull; // 0x10
	
		// Constructors
		public CinemachineEmbeddedAssetPropertyAttribute() {} // Dummy constructor
		public CinemachineEmbeddedAssetPropertyAttribute(bool warnIfNull = false /* Metadata: 0x0207BEB2 */) {} // 0x000000018184FBD0-0x000000018184FBE0
	}

	public sealed class DocumentationSortingAttribute : Attribute // TypeDefIndex: 55471
	{
		// Fields
		private Level _Category_k__BackingField; // 0x10
	
		// Properties
		private Level Category { get; set; } // 0x0000000181378230-0x0000000181378240
	
		// Nested types
		public enum Level // TypeDefIndex: 55470
		{
			Undoc = 0,
			API = 1,
			UserRef = 2
		}
	
		// Constructors
		public DocumentationSortingAttribute() {} // Dummy constructor
		public DocumentationSortingAttribute(Level category) {} // 0x0000000181378230-0x0000000181378240
	}

	public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera // TypeDefIndex: 55476
	{
		// Fields
		public string[] m_ExcludedPropertiesInInspector; // 0x18
		public CinemachineCore.Stage[] m_LockStageInInspector; // 0x20
		private int m_ValidatingStreamVersion; // 0x28
		private bool m_OnValidateCalled; // 0x2C
		private int m_StreamingVersion; // 0x30
		public int m_Priority; // 0x34
		internal int m_ActivationId; // 0x38
		[NonSerialized]
		public float FollowTargetAttachment; // 0x3C
		[NonSerialized]
		public float LookAtTargetAttachment; // 0x40
		protected bool _ignoreLookAtBlend; // 0x44
		public StandbyUpdateMode m_StandbyUpdate; // 0x48
		private List<CinemachineExtension> _mExtensions_k__BackingField; // 0x50
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
		private bool _FollowTargetChanged_k__BackingField; // 0xA0
		private bool _LookAtTargetChanged_k__BackingField; // 0xA1
	
		// Properties
		public int ValidatingStreamVersion { get; private set; } // 0x000000018776D750-0x000000018776D7A8 0x0000000184132BD0-0x0000000184132E60
		public List<CinemachineExtension> mExtensions { get; private set; } // 0x00000001841F40F0-0x00000001841F4420 0x0000000185718560-0x00000001857186C0
		public string Name { get; } // 0x0000000185FB07E0-0x0000000185FB07F0 
		public virtual string Description { get; } // 0x00000001841F28B0-0x00000001841F28C0 
		public int Priority { get; set; } // 0x00000001841F8A90-0x00000001841F8BA0 0x00000001841F7DE0-0x00000001841F7EB0
		public GameObject VirtualCameraGameObject { get; } // 0x00000001844394D0-0x0000000184439510 
		public bool IsValid { get; } // 0x00000001814A81B0-0x00000001814A81C0 
		public abstract CameraState State { get; }
		public ICinemachineCamera ParentCamera { get; }
		public abstract Transform LookAt { get; set; } // 0x0000000181BE64B0-0x0000000181BE64C0
		public abstract Transform Follow { get; set; } // 0x0000000181BE64C0-0x0000000181BE64D0 0x00000001841F5550-0x00000001841F55F0
		public virtual bool PreviousStateIsValid { get; set; } // 0x0000000185718520-0x0000000185718560
		public bool FollowTargetChanged { get; private set; } // 0x00000001834A2080-0x00000001834A2090 0x00000001841F3290-0x00000001841F35B0
		public bool LookAtTargetChanged { get; private set; } // 0x000000018140CF50-0x000000018140CF60 0x0000000183060C50-0x0000000183060C60
		public ICinemachineTargetGroup AbstractFollowTargetGroup { get; } // 0x0000000181B5FFD0-0x0000000181B5FFE0 
		public CinemachineVirtualCameraBase FollowTargetAsVcam { get; }
		public ICinemachineTargetGroup AbstractLookAtTargetGroup { get; } // 0x000000018535B550-0x000000018535B5F0 
		public CinemachineVirtualCameraBase LookAtTargetAsVcam { get; } // 0x000000018777039C-0x0000000187770400 
	
		// Nested types
		public enum StandbyUpdateMode // TypeDefIndex: 55472
		{
			Never = 0,
			Always = 1,
			RoundRobin = 2
		}
	
		public enum BlendHint // TypeDefIndex: 55473
		{
			None = 0,
			SphericalPosition = 1,
			CylindricalPosition = 2,
			ScreenSpaceAimWhenTargetsDiffer = 3
		}
	
		[Serializable]
		public struct TransitionParams // TypeDefIndex: 55474
		{
			// Fields
			public BlendHint m_BlendHint; // 0x00
			public bool m_InheritPosition; // 0x04
			public CinemachineBrain.VcamActivatedEvent m_OnCameraLive; // 0x08
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 55475
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<CinemachineExtension, bool> __9__67_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018527ED30-0x000000018527EDA0
			public __c() {} // 0x0000000181C9A5C0-0x0000000181C9A5D0
	
			// Methods
			internal bool _RequiresUserInput_b__67_0(CinemachineExtension extension) => default; // 0x000000018776DAA0-0x000000018776DB3C
		}
	
		// Constructors
		protected CinemachineVirtualCameraBase() {} // 0x0000000187770344-0x000000018777039C
	
		// Methods
		public virtual float GetMaxDampTime() => default; // 0x000000018776D6D0-0x000000018776D750
		public float DetachedFollowTargetDamp(float initial, float dampTime, float deltaTime) => default; // 0x00000001841F00E0-0x00000001841F01E0
		public Vector3 DetachedFollowTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) => default; // 0x000000018776D7A8-0x000000018776D898
		public Vector3 DetachedFollowTargetDamp(Vector3 initial, float dampTime, float deltaTime) => default; // 0x000000018776D898-0x000000018776D918
		public float DetachedLookAtTargetDamp(float initial, float dampTime, float deltaTime) => default; // 0x00000001841EA500-0x00000001841EA5E0
		public Vector3 DetachedLookAtTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) => default; // 0x000000018776DC68-0x000000018776DCBC
		public Vector3 DetachedLookAtTargetDamp(Vector3 initial, float dampTime, float deltaTime) => default; // 0x0000000181460F60-0x0000000181460F70
		public virtual void AddExtension(CinemachineExtension extension) {} // 0x0000000184A4E570-0x0000000184A4E580
		public virtual void RemoveExtension(CinemachineExtension extension) {} // 0x00000001841F4C90-0x00000001841F5180
		protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime) {} // 0x00000001864746E4-0x00000001864746EC
		protected void InvokePrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState newState, float deltaTime) {} // 0x000000018776DDD4-0x000000018776DE00
		protected bool InvokeOnTransitionInExtensions(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) => default; // 0x0000000185FB07C0-0x0000000185FB07D0
		protected void ApplyPositionBlendMethod(ref CameraState state, BlendHint hint) {}
		public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0207BEB6 */) => default;
		public void UpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x000000018776DB44-0x000000018776DB9C
		public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime); // 0x000000018527F060-0x000000018527F130
		public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x0000000185FAF0B0-0x0000000185FAF260
		protected virtual void OnDestroy() {} // 0x000000018776DCBC-0x000000018776DDD4
		protected virtual void OnTransformParentChanged() {} // 0x000000018776D918-0x000000018776D99C
		protected virtual void Start() {} // 0x000000018776DA14-0x000000018776DAA0
		internal virtual bool RequiresUserInput() => default; // 0x000000018776DC14-0x000000018776DC68
		internal void EnsureStarted() {} // 0x000000018527EE10-0x000000018527EFE0
		public AxisState.IInputAxisProvider GetInputAxisProvider() => default; // 0x000000018527EDA0-0x000000018527EE10
		protected virtual void OnValidate() {} // 0x0000000185325BF0-0x0000000185325C10
		protected virtual void OnEnable() {} // 0x000000018527F130-0x000000018527F1F0
		protected virtual void OnDisable() {} // 0x00000001841F3BF0-0x00000001841F3D20
		protected virtual void Update() {} // 0x00000001841F3FC0-0x00000001841F40F0
		private void UpdateSlaveStatus() {} // 0x000000018527F2E0-0x000000018527F3F0
		public Transform ResolveLookAt(Transform localLookAt) => default; // 0x000000018776DB3C-0x000000018776DB44
		public Transform ResolveFollow(Transform localFollow) => default; // 0x000000018776DB9C-0x000000018776DC14
		private void UpdateVcamPoolStatus() {} // 0x000000018776D99C-0x000000018776DA14
		public void MoveToTopOfPrioritySubqueue() {} // 0x000000018776D498-0x000000018776D6D0
		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) {} // 0x00000001841F5CA0-0x00000001841F5FA0
		public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) {} // 0x000000018527EFE0-0x000000018527F060
		protected CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, CinemachineBlendDefinition blendDef, CinemachineBlend activeBlend) => default; // 0x000000018346D900-0x000000018346D910
		protected CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens) => default; // 0x00000001834A2240-0x00000001834A2250
		private void InvalidateCachedTargets() {} // 0x000000018349D660-0x000000018349D670
		protected void UpdateTargetCache() {} // 0x0000000181E336C0-0x0000000181E336D0
		public object GetCinemachineComponent<T>() => default; // 0x0000000185492010-0x0000000185492020
	}

	internal class ConfinerOven // TypeDefIndex: 55482
	{
		// Fields
		private float m_MinFrustumHeightWithBones; // 0x10
		private List<List<IntPoint>> m_OriginalPolygon; // 0x18
		private List<List<IntPoint>> m_Skeleton; // 0x20
		private const long k_FloatToIntScaler = 100000; // Metadata: 0x0207BEBE
		private const float k_IntToFloatScaler = 1E-05f; // Metadata: 0x0207BEC6
		private const float k_MinStepSize = 0.005f; // Metadata: 0x0207BECA
		private Rect m_PolygonRect; // 0x28
		private AspectStretcher m_AspectStretcher; // 0x38
		private float m_maxComputationTimeForFullSkeletonBakeInSeconds; // 0x44
		private BakingState _State_k__BackingField; // 0x48
		public float m_BakeProgress; // 0x4C
		private BakingStateCache m_Cache; // 0x50
	
		// Properties
		public BakingState State { get; private set; } // 0x0000000185FB0F90-0x0000000185FB0FA0 0x0000000185FB1E30-0x0000000185FB1E50
	
		// Nested types
		public class BakedSolution // TypeDefIndex: 55477
		{
			// Fields
			private readonly float _FrustumHeight_k__BackingField; // 0x10
			private float m_frustumSizeIntSpace; // 0x14
			private readonly AspectStretcher m_AspectStretcher; // 0x18
			private readonly bool m_HasBones; // 0x24
			private readonly double m_SqrPolygonDiagonal; // 0x28
			private List<List<IntPoint>> m_OriginalPolygon; // 0x30
			public List<List<IntPoint>> m_Solution; // 0x38
	
			// Properties
			public float FrustumHeight { get; } // 0x000000018776EE74-0x000000018776EF4C 
	
			// Constructors
			public BakedSolution() {} // Dummy constructor
			public BakedSolution(float aspectRatio, float frustumHeight, bool hasBones, Rect polygonBounds, List<List<IntPoint>> originalPolygon, List<List<IntPoint>> solution) {} // 0x000000018776E54C-0x000000018776E7D0
	
			// Methods
			public bool IsValid(float frustumHeight) => default; // 0x0000000185FB0570-0x0000000185FB0580
			public Vector2 ConfinePoint(in Vector2 pointToConfine) => default; // 0x0000000185FB05D0-0x0000000185FB05E0
			private bool IsInsideOriginal(IntPoint p) => default; // 0x000000018776E948-0x000000018776EE74
			private static float ClosestPointOnSegment(IntPoint p, IntPoint s0, IntPoint s1) => default; // 0x000000018776DE00-0x000000018776E1C4
			private static IntPoint IntPointLerp(IntPoint a, IntPoint b, float lerp) => default; // 0x000000018776E7D0-0x000000018776E948
			private bool DoesIntersectOriginal(IntPoint l1, IntPoint l2) => default; // 0x000000018776E1C4-0x000000018776E54C
			private static int FindIntersection(in IntPoint p1, in IntPoint p2, in IntPoint p3, in IntPoint p4) => default; // 0x0000000181DCCCE0-0x0000000181DCCCF0
			private static double IntPointDiffSqrMagnitude(IntPoint p1, IntPoint p2) => default; // 0x0000000187769E1C-0x0000000187769ED0
		}
	
		private struct AspectStretcher // TypeDefIndex: 55478
		{
			// Fields
			private readonly float _Aspect_k__BackingField; // 0x00
			private readonly float m_InverseAspect; // 0x04
			private readonly float m_CenterX; // 0x08
	
			// Properties
			public float Aspect { get; } // 0x0000000187769DF4-0x0000000187769E1C 
	
			// Constructors
			public AspectStretcher(float aspect, float centerX) : this() {
				<Aspect>k__BackingField = default;
				m_InverseAspect = default;
				m_CenterX = default;
			} // 0x00000001877694CC-0x00000001877698A0
	
			// Methods
			public Vector2 Stretch(Vector2 p) => default; // 0x0000000187769D58-0x0000000187769DF4
			public Vector2 Unstretch(Vector2 p) => default; // 0x000000018776944C-0x00000001877694CC
		}
	
		private struct PolygonSolution // TypeDefIndex: 55479
		{
			// Fields
			public List<List<IntPoint>> m_Polygons; // 0x00
			public float m_FrustumHeight; // 0x08
	
			// Properties
			public bool IsEmpty { get => default; } // 0x00000001877698A0-0x0000000187769AA0 
	
			// Methods
			public bool StateChanged(in List<List<IntPoint>> paths) => default; // 0x0000000187769CC4-0x0000000187769D58
		}
	
		public enum BakingState // TypeDefIndex: 55480
		{
			BAKING = 0,
			BAKED = 1,
			TIMEOUT = 2
		}
	
		private struct BakingStateCache // TypeDefIndex: 55481
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
		public ConfinerOven(in List<List<Vector2>> inputPath, in float aspectRatio, float maxFrustumHeight) {} // 0x0000000187769AA0-0x0000000187769CC4
	
		// Methods
		public BakedSolution GetBakedSolution(float frustumHeight) => default; // 0x0000000185FB1E90-0x0000000185FB1EC0
		private void Initialize(in List<List<Vector2>> inputPath, in float aspectRatio, float maxFrustumHeight) {} // 0x0000000185FB1DD0-0x0000000185FB1E00
		public void BakeConfiner(float maxComputationTimePerFrameInSeconds) {} // 0x0000000185FB1E00-0x0000000185FB1E30
		private static Rect GetPolygonBoundingBox(in List<List<Vector2>> polygons) => default; // 0x000000018776F4E8-0x000000018776F5BC
		private void ComputeSkeleton(in List<PolygonSolution> solutions) {} // 0x000000018402E460-0x000000018402E470
	}

	public interface ICinemachineCamera // TypeDefIndex: 55483
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
		bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x0207BED1 */);
		void UpdateCameraState(Vector3 worldUp, float deltaTime);
		void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime);
	}

	[Serializable]
	public struct LensSettings // TypeDefIndex: 55485
	{
		// Fields
		public static LensSettings Default; // 0x00
		public float FieldOfView; // 0x00
		public float OrthographicSize; // 0x04
		public float NearClipPlane; // 0x08
		public float FarClipPlane; // 0x0C
		public float Dutch; // 0x10
		public OverrideModes ModeOverride; // 0x14
		public Vector2 LensShift; // 0x18
		public Camera.GateFitMode GateFit; // 0x20
		private Vector2 m_SensorSize; // 0x24
		private bool m_OrthoFromCamera; // 0x2C
		private bool m_PhysicalFromCamera; // 0x2D
	
		// Properties
		public bool Orthographic { get => default; } // 0x00000001841EED10-0x00000001841EED30 
		public Vector2 SensorSize { get => default; } // 0x0000000185FB1F70-0x0000000185FB1F90 
		public float Aspect { get => default; } // 0x00000001841EEC90-0x00000001841EED10 
		public bool IsPhysicalCamera { get => default; } // 0x00000001841F5900-0x00000001841F5920 
	
		// Nested types
		public enum OverrideModes // TypeDefIndex: 55484
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
		} // 0x0000000185ECACA0-0x0000000185ECACF0
		static LensSettings() {
			Default = default;
		} // 0x0000000185ECAC00-0x0000000185ECACA0
	
		// Methods
		public static LensSettings FromCamera(Camera fromCamera) => default; // 0x000000018776F108-0x000000018776F240
		public void SnapshotCameraReadOnlyProperties(Camera camera) {} // 0x00000001841F55F0-0x00000001841F5900
		public static LensSettings Lerp(LensSettings lensA, LensSettings lensB, float t) => default; // 0x0000000184285BF0-0x0000000184285DB0
		public void Validate() {} // 0x000000018776F240-0x000000018776F2AC
	}

	public sealed class NoiseSettings : SignalSourceAsset // TypeDefIndex: 55488
	{
		// Fields
		public TransformNoiseParams[] PositionNoise; // 0x18
		public TransformNoiseParams[] OrientationNoise; // 0x20
	
		// Properties
		public override float SignalDuration { get => default; } // 0x0000000185C1E7F0-0x0000000185C1E860 
	
		// Nested types
		[Serializable]
		public struct NoiseParams // TypeDefIndex: 55486
		{
			// Fields
			public float Frequency; // 0x00
			public float Amplitude; // 0x04
			public bool Constant; // 0x08
	
			// Methods
			public float GetValueAt(float time, float timeOffset) => default; // 0x000000018776F304-0x000000018776F410
		}
	
		[Serializable]
		public struct TransformNoiseParams // TypeDefIndex: 55487
		{
			// Fields
			public NoiseParams X; // 0x00
			public NoiseParams Y; // 0x0C
			public NoiseParams Z; // 0x18
	
			// Methods
			public Vector3 GetValueAt(float time, Vector3 timeOffsets) => default; // 0x0000000183908D00-0x0000000183908D10
		}
	
		// Constructors
		public NoiseSettings() {} // 0x0000000187770270-0x0000000187770310
	
		// Methods
		public static Vector3 GetCombinedFilterResults(TransformNoiseParams[] noiseParams, float time, Vector3 timeOffsets) => default; // 0x000000018776F410-0x000000018776F4E8
		public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) {
			pos = default;
			rot = default;
		} // 0x000000018776F2AC-0x000000018776F304
	}

	public static class RuntimeUtility // TypeDefIndex: 55494
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
		public delegate int OverlapSphereNonAllocDelegate(Vector3 position, float radius, ECSColliderResultProxy[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 55489; 0x00000001814A81B0-0x00000001814A81C0
	
		public delegate bool RaycastDelegate(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 55490; 0x000000018776F9C8-0x000000018776FA30
	
		public delegate int RaycastNonAllocDelegate(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 55491; 0x000000018776FCB8-0x000000018776FD28
	
		public delegate int SphereCastNonAllocDelegate(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 55492; 0x000000018776FA30-0x000000018776FCB8
	
		public delegate bool ComputePenetrationDelegate(ECSColliderResultProxy colliderA, Vector3 positionA, Quaternion rotationA, ECSColliderResultProxy colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance); // TypeDefIndex: 55493; 0x000000018776FDA4-0x000000018776FFC4
	
		// Constructors
		static RuntimeUtility() {} // 0x0000000187213AC0-0x0000000187213B84
	
		// Methods
		public static void DestroyObject(UnityEngine.Object obj) {} // 0x00000001856FB740-0x00000001856FBA30
		public static bool IsPrefab(GameObject gameObject) => default; // 0x00000001856FBF00-0x00000001856FBF90
		public static bool RaycastIgnoreTag(Ray ray, out RaycastHit hitInfo, float rayLength, int layerMask, in string ignoreTag) {
			hitInfo = default;
			return default;
		} // 0x0000000187216CEC-0x0000000187216D38
		public static int GetColliderOptionsFromHit(RaycastHit hit) => default; // 0x00000001856FBE70-0x00000001856FBF00
		public static bool HasIgnoreColliderOptionFromHit(RaycastHit hit) => default; // 0x0000000187213E54-0x0000000187213EA0
		public static bool HasIgnoreColliderOptionFromCollider(ECSColliderResultProxy collider) => default; // 0x00000001856FBDE0-0x00000001856FBE70
		public static bool SphereCastIgnoreTag(Vector3 rayStart, float radius, Vector3 dir, out RaycastHit hitInfo, float rayLength, int layerMask, in string ignoreTag) {
			hitInfo = default;
			return default;
		} // 0x0000000187213E54-0x0000000187213EA0
		internal static SphereCollider GetScratchCollider() => default; // 0x00000001856FBD50-0x00000001856FBDE0
		internal static void DestroyScratchCollider() {} // 0x0000000187217C60-0x0000000187217CDC
		public static AnimationCurve NormalizeCurve(AnimationCurve curve, bool normalizeX, bool normalizeY) => default; // 0x00000001856FBCC0-0x00000001856FBD50
	}

	public interface ISignalSource6D // TypeDefIndex: 55495
	{
		// Methods
		void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot);
	}

	public abstract class SignalSourceAsset : ScriptableObject, ISignalSource6D // TypeDefIndex: 55496
	{
		// Properties
		public abstract float SignalDuration { get; }
	
		// Constructors
		protected SignalSourceAsset() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		public abstract void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot);
	}

	internal class TargetPositionCache // TypeDefIndex: 55503
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
		public static Mode CacheMode { get => default; } // 0x000000018776A4B4-0x000000018776A52C 
		public static bool HasCurrentTime { get => default; } // 0x0000000187770264-0x0000000187770270 
	
		// Nested types
		public enum Mode // TypeDefIndex: 55497
		{
			Disabled = 0,
			Record = 1,
			Playback = 2
		}
	
		private class CacheCurve // TypeDefIndex: 55499
		{
			// Fields
			public float StartTime; // 0x10
			public float StepSize; // 0x14
			private List<Item> m_Cache; // 0x18
	
			// Nested types
			public struct Item // TypeDefIndex: 55498
			{
				// Fields
				public Vector3 Pos; // 0x00
				public Quaternion Rot; // 0x0C
	
				// Properties
				public static Item Empty { get => default; } // 0x00000001877701EC-0x0000000187770230 
	
				// Methods
				public static Item Lerp(Item a, Item b, float t) => default; // 0x00000001877701B4-0x00000001877701EC
			}
	
			// Constructors
			public CacheCurve() {} // Dummy constructor
	
			// Methods
			public Item Evaluate(float time) => default; // 0x00000001877700BC-0x00000001877701B4
		}
	
		private class CacheEntry // TypeDefIndex: 55501
		{
			// Fields
			public CacheCurve Curve; // 0x10
			private List<RecordingItem> RawItems; // 0x18
	
			// Nested types
			private struct RecordingItem // TypeDefIndex: 55500
			{
				// Fields
				public float Time; // 0x00
				public bool IsCut; // 0x04
				public CacheCurve.Item Item; // 0x08
			}
	
			// Constructors
			public CacheEntry() {} // 0x00000001841F5A10-0x00000001841F5B20
	
			// Methods
			public void AddRawItem(float time, bool isCut, Transform target) {} // 0x00000001841F5920-0x00000001841F5A10
		}
	
		public struct TimeRange // TypeDefIndex: 55502
		{
			// Fields
			public float Start; // 0x00
			public float End; // 0x04
	
			// Properties
			public bool IsEmpty { get => default; } // 0x000000018776A07C-0x000000018776A21C 
			public static TimeRange Empty { get => default; } // 0x000000018776F0E0-0x000000018776F108 
	
			// Methods
			public bool Contains(float time) => default; // 0x000000018776EFD8-0x000000018776F0E0
			public void Include(float time) {} // 0x000000018776A21C-0x000000018776A4B4
		}
	
		// Constructors
		public TargetPositionCache() {} // Dummy constructor
	
		// Methods
		public static void ClearCache() {} // 0x0000000187770230-0x0000000187770244
		public static Vector3 GetTargetPosition(Transform target) => default; // 0x0000000185FB1FB0-0x0000000185FB1FD0
		public static Quaternion GetTargetRotation(Transform target) => default; // 0x0000000187770244-0x0000000187770264
	}

	internal class UpdateTracker // TypeDefIndex: 55506
	{
		// Fields
		private static Dictionary<Transform, UpdateStatus> mUpdateStatus; // 0x00
		private static List<Transform> sToDelete; // 0x08
		private static float mLastUpdateTime; // 0x10
	
		// Nested types
		public enum UpdateClock // TypeDefIndex: 55504
		{
			Fixed = 0,
			Late = 1
		}
	
		private class UpdateStatus // TypeDefIndex: 55505
		{
			// Fields
			private int windowStart; // 0x10
			private int numWindowLateUpdateMoves; // 0x14
			private int numWindowFixedUpdateMoves; // 0x18
			private int numWindows; // 0x1C
			private int lastFrameUpdated; // 0x20
			private Matrix4x4 lastPos; // 0x24
			private UpdateClock _PreferredUpdate_k__BackingField; // 0x64
	
			// Properties
			public UpdateClock PreferredUpdate { get; private set; } // 0x0000000185F60E40-0x0000000185F60EB0 0x00000001877706F0-0x0000000187770AA0
	
			// Constructors
			public UpdateStatus() {} // Dummy constructor
			public UpdateStatus(int currentFrame, Matrix4x4 pos) {} // 0x0000000187770464-0x0000000187770654
	
			// Methods
			public void OnUpdate(int currentFrame, UpdateClock currentClock, Matrix4x4 pos) {} // 0x0000000187770654-0x00000001877706F0
		}
	
		// Constructors
		public UpdateTracker() {} // Dummy constructor
		static UpdateTracker() {} // 0x00000001877773D0-0x00000001877774E0
	
		// Methods
		private static void InitializeModule() {} // 0x0000000185EB7580-0x0000000185EB7670
		private static void UpdateTargets(UpdateClock currentClock) {} // 0x0000000185FB2020-0x0000000185FB2030
		public static UpdateClock GetPreferredUpdate(Transform target) => default; // 0x0000000185FB2030-0x0000000185FB2040
		public static void OnUpdate(UpdateClock currentClock) {} // 0x00000001877774E0-0x0000000187777530
	}

	public class CinemachineInputProvider : MonoBehaviour, AxisState.IInputAxisProvider // TypeDefIndex: 55508
	{
		// Fields
		public int PlayerIndex; // 0x18
		public bool AutoEnableInputs; // 0x1C
		public InputActionReference XYAxis; // 0x20
		public InputActionReference ZAxis; // 0x28
		private const int NUM_AXES = 3; // Metadata: 0x0207BEDB
		private InputAction[] m_cachedActions; // 0x30
	
		// Nested types
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 55507
		{
			// Fields
			public InputActionReference aRef; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0() {} // 0x0000000187773DEC-0x0000000187773EB8
	
			// Methods
			internal bool _ResolveForPlayer_b__1(InputAction x) => default; // 0x0000000187773ECC-0x0000000187774234
		}
	
		// Constructors
		public CinemachineInputProvider() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public virtual float GetAxisValue(int axis) => default; // 0x0000000187773EB8-0x0000000187773ECC
		protected InputAction ResolveForPlayer(int axis, InputActionReference actionRef) => default; // 0x000000018777432C-0x0000000187774340
		protected virtual void OnDisable() {} // 0x0000000187774234-0x000000018777432C
		internal static InputAction _ResolveForPlayer_g__GetFirstMatch_7_0(in InputUser user, InputActionReference aRef) => default; // 0x0000000187776E74-0x0000000187776EF0
	}

	public class CinemachineTriggerAction : MonoBehaviour // TypeDefIndex: 55513
	{
		// Fields
		public LayerMask m_LayerMask; // 0x18
		public string m_WithTag; // 0x20
		public string m_WithoutTag; // 0x28
		public int m_SkipFirst; // 0x30
		public bool m_Repeating; // 0x34
		public ActionSettings m_OnObjectEnter; // 0x38
		public ActionSettings m_OnObjectExit; // 0x60
		private HashSet<GameObject> m_ActiveTriggerObjects; // 0x88
	
		// Nested types
		[Serializable]
		public struct ActionSettings // TypeDefIndex: 55512
		{
			// Fields
			public Mode m_Action; // 0x00
			public UnityEngine.Object m_Target; // 0x08
			public int m_BoostAmount; // 0x10
			public float m_StartTime; // 0x14
			public TimeMode m_Mode; // 0x18
			public TriggerEvent m_Event; // 0x20
	
			// Nested types
			public enum Mode // TypeDefIndex: 55509
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
			public class TriggerEvent : UnityEvent // TypeDefIndex: 55510
			{
				// Constructors
				public TriggerEvent() {} // 0x0000000187774340-0x00000001877743D0
			}
	
			public enum TimeMode // TypeDefIndex: 55511
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
			} // 0x00000001877743D0-0x0000000187774460
	
			// Methods
			public void Invoke() {} // 0x0000000187774460-0x00000001877744FC
		}
	
		// Constructors
		public CinemachineTriggerAction() {} // 0x0000000186470378-0x0000000186470380
	
		// Methods
		private bool Filter(GameObject other) => default; // 0x00000001877745CC-0x0000000187774600
		private void InternalDoTriggerEnter(GameObject other) {} // 0x0000000187774600-0x0000000187774634
		private void InternalDoTriggerExit(GameObject other) {} // 0x0000000187774530-0x0000000187774564
		private void OnTriggerEnter(Collider other) {} // 0x0000000187774598-0x00000001877745CC
		private void OnTriggerExit(Collider other) {} // 0x00000001877745CC-0x0000000187774600
		private void OnCollisionEnter(UnityEngine.Collision other) {} // 0x0000000187774600-0x0000000187774634
		private void OnCollisionExit(UnityEngine.Collision other) {} // 0x00000001877744FC-0x0000000187774530
		private void OnTriggerEnter2D(Collider2D other) {} // 0x0000000187774564-0x0000000187774598
		private void OnTriggerExit2D(Collider2D other) {} // 0x0000000185492010-0x0000000185492020
		private void OnCollisionEnter2D(Collision2D other) {} // 0x0000000187774634-0x00000001877747A4
		private void OnCollisionExit2D(Collision2D other) {} // 0x0000000187770F04-0x0000000187770F88
		private void OnEnable() {} // 0x0000000187770AA0-0x0000000187770F04
	}

	public class GroupWeightManipulator : MonoBehaviour // TypeDefIndex: 55514
	{
		// Fields
		public float m_Weight0; // 0x18
		public float m_Weight1; // 0x1C
		public float m_Weight2; // 0x20
		public float m_Weight3; // 0x24
		public float m_Weight4; // 0x28
		public float m_Weight5; // 0x2C
		public float m_Weight6; // 0x30
		public float m_Weight7; // 0x34
		private CinemachineTargetGroup m_group; // 0x38
	
		// Constructors
		public GroupWeightManipulator() {} // 0x0000000187774C30-0x0000000187774C70
	
		// Methods
		private void Start() {} // 0x0000000187774A54-0x0000000187774A9C
		private void OnValidate() {} // 0x00000001877749E8-0x0000000187774A54
		private void Update() {} // 0x0000000187774BD0-0x0000000187774C30
		private void UpdateWeights() {} // 0x0000000187774A9C-0x0000000187774BD0
	}

	public class CinemachineCollisionImpulseSource : CinemachineImpulseSource // TypeDefIndex: 55515
	{
		// Fields
		public LayerMask m_LayerMask; // 0x30
		public string m_IgnoreTag; // 0x38
		public bool m_UseImpactDirection; // 0x40
		public bool m_ScaleImpactWithMass; // 0x41
		public bool m_ScaleImpactWithSpeed; // 0x42
		private Rigidbody mRigidBody; // 0x48
		private Rigidbody2D mRigidBody2D; // 0x50
	
		// Constructors
		public CinemachineCollisionImpulseSource() {} // 0x000000018777193C-0x0000000187771998
	
		// Methods
		private void Start() {} // 0x00000001877718CC-0x000000018777193C
		private void OnEnable() {} // 0x0000000185492010-0x0000000185492020
		private void OnCollisionEnter(UnityEngine.Collision c) {} // 0x000000018777183C-0x0000000187771874
		private void OnTriggerEnter(Collider c) {} // 0x00000001877718A0-0x00000001877718CC
		private float GetMassAndVelocity(Collider other, ref Vector3 vel) => default; // 0x0000000187771594-0x00000001877717C8
		private void GenerateImpactEvent(Collider other, Vector3 vel) {} // 0x0000000187771174-0x0000000187771360
		private void OnCollisionEnter2D(Collision2D c) {} // 0x00000001877717C8-0x000000018777183C
		private void OnTriggerEnter2D(Collider2D c) {} // 0x0000000187771874-0x00000001877718A0
		private float GetMassAndVelocity2D(Collider2D other2d, ref Vector3 vel) => default; // 0x0000000187771360-0x0000000187771594
		private void GenerateImpactEvent2D(Collider2D other2d, Vector3 vel) {} // 0x0000000187770F88-0x0000000187771174
	}

	public class CinemachineFixedSignal : SignalSourceAsset // TypeDefIndex: 55516
	{
		// Fields
		public AnimationCurve m_XCurve; // 0x18
		public AnimationCurve m_YCurve; // 0x20
		public AnimationCurve m_ZCurve; // 0x28
	
		// Properties
		public override float SignalDuration { get => default; } // 0x00000001877720E0-0x0000000187772140 
	
		// Constructors
		public CinemachineFixedSignal() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		private float AxisDuration(AnimationCurve axis) => default; // 0x0000000187771F80-0x0000000187772000
		public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) {
			pos = default;
			rot = default;
		} // 0x0000000187772044-0x00000001877720E0
		private float AxisValue(AnimationCurve axis, float time) => default; // 0x0000000187772000-0x0000000187772044
	}

	[Serializable]
	public class CinemachineImpulseDefinition // TypeDefIndex: 55522
	{
		// Fields
		public int m_ImpulseChannel; // 0x10
		public ImpulseShapes m_ImpulseShape; // 0x14
		public AnimationCurve m_CustomImpulseShape; // 0x18
		public float m_ImpulseDuration; // 0x20
		public ImpulseTypes m_ImpulseType; // 0x24
		public float m_DissipationRate; // 0x28
		public SignalSourceAsset m_RawSignal; // 0x30
		public float m_AmplitudeGain; // 0x38
		public float m_FrequencyGain; // 0x3C
		public RepeatMode m_RepeatMode; // 0x40
		public bool m_Randomize; // 0x44
		public CinemachineImpulseManager.EnvelopeDefinition m_TimeEnvelope; // 0x48
		public float m_ImpactRadius; // 0x68
		public CinemachineImpulseManager.ImpulseEvent.DirectionMode m_DirectionMode; // 0x6C
		public CinemachineImpulseManager.ImpulseEvent.DissipationMode m_DissipationMode; // 0x70
		public float m_DissipationDistance; // 0x74
		public float m_PropagationSpeed; // 0x78
		private static AnimationCurve[] sStandardShapes; // 0x00
	
		// Properties
		internal AnimationCurve ImpulseCurve { get => default; } // 0x0000000187775EE4-0x0000000187775F04 
	
		// Nested types
		public enum ImpulseShapes // TypeDefIndex: 55517
		{
			Custom = 0,
			Recoil = 1,
			Bump = 2,
			Explosion = 3,
			Rumble = 4
		}
	
		public enum ImpulseTypes // TypeDefIndex: 55518
		{
			Uniform = 0,
			Dissipating = 1,
			Propagating = 2,
			Legacy = 3
		}
	
		public enum RepeatMode // TypeDefIndex: 55519
		{
			Stretch = 0,
			Loop = 1
		}
	
		private class SignalSource : ISignalSource6D // TypeDefIndex: 55520
		{
			// Fields
			private CinemachineImpulseDefinition m_Def; // 0x10
			private Vector3 m_Velocity; // 0x18
	
			// Properties
			public float SignalDuration { get => default; } // 0x000000018777237C-0x0000000187772EE0 
	
			// Constructors
			public SignalSource() {} // Dummy constructor
			public SignalSource(CinemachineImpulseDefinition def, Vector3 velocity) {} // 0x000000018777313C-0x0000000187773214
	
			// Methods
			public void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) {
				pos = default;
				rot = default;
			} // 0x0000000187772EE0-0x0000000187772F54
		}
	
		private class LegacySignalSource : ISignalSource6D // TypeDefIndex: 55521
		{
			// Fields
			private CinemachineImpulseDefinition m_Def; // 0x10
			private Vector3 m_Velocity; // 0x18
			private float m_StartTimeOffset; // 0x24
	
			// Properties
			public float SignalDuration { get => default; } // 0x000000018777233C-0x000000018777237C 
	
			// Constructors
			public LegacySignalSource() {} // Dummy constructor
			public LegacySignalSource(CinemachineImpulseDefinition def, Vector3 velocity) {} // 0x0000000187773214-0x000000018777326C
	
			// Methods
			public void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) {
				pos = default;
				rot = default;
			} // 0x0000000187772140-0x000000018777233C
		}
	
		// Constructors
		public CinemachineImpulseDefinition() {} // 0x00000001877758B8-0x0000000187775AC4
	
		// Methods
		public void OnValidate() {} // 0x0000000187772F54-0x000000018777313C
		private static void CreateStandardShapes() {} // 0x000000018475A660-0x000000018475A750
		internal static AnimationCurve GetStandardCurve(ImpulseShapes shape) => default; // 0x0000000187775EB4-0x0000000187775EE4
		public void CreateEvent(Vector3 position, Vector3 velocity) {} // 0x0000000187775DDC-0x0000000187775EB4
		public CinemachineImpulseManager.ImpulseEvent CreateAndReturnEvent(Vector3 position, Vector3 velocity) => default; // 0x0000000187775AC4-0x0000000187775B44
		private CinemachineImpulseManager.ImpulseEvent LegacyCreateAndReturnEvent(Vector3 position, Vector3 velocity) => default; // 0x0000000187775B44-0x0000000187775B70
	}

	public class CinemachineImpulseListener : CinemachineExtension // TypeDefIndex: 55524
	{
		// Fields
		public CinemachineCore.Stage m_ApplyAfter; // 0x28
		public int m_ChannelMask; // 0x2C
		public float m_Gain; // 0x30
		public bool m_Use2DDistance; // 0x34
		public bool m_UseCameraSpace; // 0x35
		public ImpulseReaction m_ReactionSettings; // 0x38
	
		// Nested types
		[Serializable]
		public struct ImpulseReaction // TypeDefIndex: 55523
		{
			// Fields
			public NoiseSettings m_SecondaryNoise; // 0x00
			public float m_AmplitudeGain; // 0x08
			public float m_FrequencyGain; // 0x0C
			public float m_Duration; // 0x10
			private float m_CurrentAmount; // 0x14
			private float m_CurrentTime; // 0x18
			private float m_CurrentDamping; // 0x1C
			private bool m_Initialized; // 0x20
			private Vector3 m_NoiseOffsets; // 0x24
	
			// Methods
			public void ReSeed() {} // 0x000000018777326C-0x00000001877732D0
			public bool GetReaction(float deltaTime, Vector3 impulsePos, out Vector3 pos, out Quaternion rot) {
				pos = default;
				rot = default;
				return default;
			} // 0x00000001841EFC70-0x00000001841EFE60
		}
	
		// Constructors
		public CinemachineImpulseListener() {} // 0x00000001841EF480-0x00000001841EF610
	
		// Methods
		private void Reset() {} // 0x0000000185BB1590-0x0000000185BB15A0
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x0000000187775834-0x00000001877758B8
	}

	public sealed class CinemachineImpulseChannelPropertyAttribute : PropertyAttribute // TypeDefIndex: 55525
	{
		// Constructors
		public CinemachineImpulseChannelPropertyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class CinemachineImpulseManager // TypeDefIndex: 55530
	{
		// Fields
		private static CinemachineImpulseManager sInstance; // 0x00
		private List<ImpulseEvent> m_ExpiredEvents; // 0x10
		private List<ImpulseEvent> m_ActiveEvents; // 0x18
		public bool IgnoreTimeScale; // 0x20
	
		// Properties
		public static CinemachineImpulseManager Instance { get => default; } // 0x0000000187774850-0x0000000187774880 
		public float CurrentTime { get => default; } // 0x000000018777534C-0x0000000187775438 
	
		// Nested types
		[Serializable]
		public struct EnvelopeDefinition // TypeDefIndex: 55526
		{
			// Fields
			public AnimationCurve m_AttackShape; // 0x00
			public AnimationCurve m_DecayShape; // 0x08
			public float m_AttackTime; // 0x10
			public float m_SustainTime; // 0x14
			public float m_DecayTime; // 0x18
			public bool m_ScaleWithImpact; // 0x1C
			public bool m_HoldForever; // 0x1D
	
			// Properties
			public float Duration { get => default; } // 0x00000001841EF710-0x00000001841EF7A0 
	
			// Methods
			public static EnvelopeDefinition Default() => default; // 0x0000000185492010-0x0000000185492020
			public float GetValueAt(float offset) => default; // 0x0000000185FA15B0-0x0000000185FA15F0
			public void ChangeStopTime(float offset, bool forceNoDecay) {} // 0x0000000187773434-0x00000001877734D4
			public void Clear() {} // 0x00000001841EF610-0x00000001841EF710
			public void Validate() {} // 0x0000000187773598-0x00000001877735E8
		}
	
		public class ImpulseEvent // TypeDefIndex: 55529
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
			public bool Expired { get => default; } // 0x00000001877734D4-0x0000000187773598 
	
			// Nested types
			public enum DirectionMode // TypeDefIndex: 55527
			{
				Fixed = 0,
				RotateTowardSource = 1
			}
	
			public enum DissipationMode // TypeDefIndex: 55528
			{
				LinearDecay = 0,
				SoftDecay = 1,
				ExponentialDecay = 2
			}
	
			// Constructors
			internal ImpulseEvent() {} // 0x0000000187774880-0x000000018777499C
	
			// Methods
			public void Cancel(float time, bool forceNoDecay) {} // 0x00000001877732D0-0x0000000187773394
			public float DistanceDecay(float distance) => default; // 0x0000000187773394-0x0000000187773434
			public bool GetDecayedSignal(Vector3 listenerPosition, bool use2D, out Vector3 pos, out Quaternion rot) {
				pos = default;
				rot = default;
				return default;
			} // 0x0000000185FB1FD0-0x0000000185FB1FF0
			public void Clear() {} // 0x00000001877749C8-0x00000001877749E8
		}
	
		// Constructors
		private CinemachineImpulseManager() {} // 0x0000000187774824-0x0000000187774850
	
		// Methods
		private static void InitializeModule() {} // 0x000000018777499C-0x00000001877749C8
		internal static float EvaluateDissipationScale(float spread, float normalizedDistance) => default; // 0x0000000187775798-0x0000000187775834
		public bool GetImpulseAt(Vector3 listenerLocation, bool distance2D, int channelMask, out Vector3 pos, out Quaternion rot) {
			pos = default;
			rot = default;
			return default;
		} // 0x00000001877752D0-0x00000001877752E8
		public ImpulseEvent NewImpulseEvent() => default; // 0x0000000187775438-0x0000000187775798
		public void AddImpulseEvent(ImpulseEvent e) {} // 0x00000001877752E8-0x000000018777534C
		public void Clear() {} // 0x0000000185492010-0x0000000185492020
	}

	public class CinemachineImpulseSource : MonoBehaviour // TypeDefIndex: 55531
	{
		// Fields
		public CinemachineImpulseDefinition m_ImpulseDefinition; // 0x18
		public Vector3 m_DefaultVelocity; // 0x20
	
		// Constructors
		public CinemachineImpulseSource() {} // 0x0000000185F07CC0-0x0000000185F07D50
	
		// Methods
		private void OnValidate() {} // 0x00000001877737E0-0x0000000187773800
		private void Reset() {} // 0x0000000187773800-0x00000001877738F4
		public void GenerateImpulseAtPositionWithVelocity(Vector3 position, Vector3 velocity) {} // 0x00000001877735E8-0x0000000187773634
		public void GenerateImpulseWithVelocity(Vector3 velocity) {} // 0x0000000187773714-0x0000000187773788
		public void GenerateImpulseWithForce(float force) {} // 0x0000000187773674-0x0000000187773714
		public void GenerateImpulse() {} // 0x0000000187773788-0x00000001877737B0
		public void GenerateImpulseAt(Vector3 position, Vector3 velocity) {} // 0x0000000187773634-0x0000000187773674
		public void GenerateImpulse(Vector3 velocity) {} // 0x00000001877737B8-0x00000001877737E0
		public void GenerateImpulse(float force) {} // 0x00000001877737B0-0x00000001877737B8
	}

	public class CinemachineIndependentImpulseListener : MonoBehaviour // TypeDefIndex: 55532
	{
		// Fields
		private Vector3 impulsePosLastFrame; // 0x18
		private Quaternion impulseRotLastFrame; // 0x24
		public int m_ChannelMask; // 0x34
		public float m_Gain; // 0x38
		public bool m_Use2DDistance; // 0x3C
		public bool m_UseLocalSpace; // 0x3D
		public CinemachineImpulseListener.ImpulseReaction m_ReactionSettings; // 0x40
	
		// Constructors
		public CinemachineIndependentImpulseListener() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Reset() {} // 0x0000000187773C5C-0x0000000187773CB8
		private void OnEnable() {} // 0x0000000187773C2C-0x0000000187773C5C
		private void Update() {} // 0x0000000187773CB8-0x0000000187773DEC
		private void LateUpdate() {} // 0x00000001877738F4-0x0000000187773C2C
	}
}

namespace Cinemachine.PostFX
{
	public class CinemachinePostProcessing : CinemachineExtension // TypeDefIndex: 55533
	{
		// Constructors
		public CinemachinePostProcessing() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x0000000185492010-0x0000000185492020
	}

	public class CinemachineVolumeSettings : MonoBehaviour // TypeDefIndex: 55534
	{
		// Constructors
		public CinemachineVolumeSettings() {} // 0x000000018646DB20-0x000000018646DB28
	}
}

namespace Cinemachine.Utility
{
	public class CinemachineDebug // TypeDefIndex: 55536
	{
		// Fields
		private static HashSet<UnityEngine.Object> mClients; // 0x00
		public static OnGUIDelegate OnGUIHandlers; // 0x08
		private static List<StringBuilder> mAvailableStringBuilders; // 0x10
	
		// Nested types
		public delegate void OnGUIDelegate(); // TypeDefIndex: 55535; 0x0000000187771998-0x0000000187771D10
	
		// Constructors
		public CinemachineDebug() {} // Dummy constructor
	
		// Methods
		public static void ReleaseScreenPos(UnityEngine.Object client) {} // 0x0000000187771E8C-0x0000000187771F80
		public static Rect GetScreenPos(UnityEngine.Object client, string text, GUIStyle style) => default; // 0x0000000187771DA8-0x0000000187771E8C
		public static StringBuilder SBFromPool() => default; // 0x000000018454C420-0x000000018454C490
		public static void ReturnToPool(StringBuilder sb) {} // 0x00000001864BC320-0x00000001864BC330
	}

	public class PositionPredictor // TypeDefIndex: 55537
	{
		// Fields
		private Vector3 m_Velocity; // 0x10
		private Vector3 m_SmoothDampVelocity; // 0x1C
		private Vector3 m_Pos; // 0x28
		private bool m_HavePos; // 0x34
		public float Smoothing; // 0x38
	
		// Constructors
		public PositionPredictor() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void ApplyTransformDelta(Vector3 positionDelta) {} // 0x0000000187775D20-0x0000000187775D74
		public void Reset() {} // 0x0000000187775DB4-0x0000000187775DDC
		public void AddPosition(Vector3 pos, float deltaTime, float lookaheadTime) {} // 0x0000000187775B70-0x0000000187775D20
		public Vector3 PredictPositionDelta(float lookaheadTime) => default; // 0x0000000187775D74-0x0000000187775DB4
	}

	public static class Damper // TypeDefIndex: 55538
	{
		// Methods
		public static float Damp(float initial, float dampTime, float deltaTime) => default; // 0x00000001841F1A00-0x00000001841F1AB0
		public static Vector3 Damp(Vector3 initial, Vector3 dampTime, float deltaTime) => default; // 0x00000001841F01E0-0x00000001841F0320
		public static Vector3 Damp(Vector3 initial, float dampTime, float deltaTime) => default; // 0x00000001877747A4-0x0000000187774824
	}

	public class HeadingTracker // TypeDefIndex: 55540
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
		public int FilterSize { get => default; } // 0x00000001877752B4-0x00000001877752D0 
	
		// Nested types
		private struct Item // TypeDefIndex: 55539
		{
			// Fields
			public Vector3 velocity; // 0x00
			public float weight; // 0x0C
			public float time; // 0x10
		}
	
		// Constructors
		public HeadingTracker() {} // Dummy constructor
		public HeadingTracker(int filterSize) {} // 0x00000001877751D8-0x00000001877752B4
	
		// Methods
		private void ClearHistory() {} // 0x0000000187774E2C-0x0000000187774E4C
		private static float Decay(float time) => default; // 0x0000000187774F0C-0x0000000187774F58
		public void Add(Vector3 velocity) {} // 0x0000000187774C70-0x0000000187774E2C
		private void PopBottom() {} // 0x000000018777504C-0x00000001877751D8
		public void DecayHistory() {} // 0x0000000187774E4C-0x0000000187774F0C
		public Vector3 GetReliableHeading() => default; // 0x0000000187774F58-0x000000018777504C
	}

	public static class SplineHelpers // TypeDefIndex: 55541
	{
		// Methods
		public static Vector3 Bezier3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) => default; // 0x0000000187775F90-0x000000018777611C
		public static Vector3 BezierTangent3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) => default; // 0x000000018777611C-0x0000000187776474
		public static float Bezier1(float t, float p0, float p1, float p2, float p3) => default; // 0x0000000187775F04-0x0000000187775F90
		public static void ComputeSmoothControlPoints(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2) {} // 0x0000000187776730-0x0000000187776E74
		public static void ComputeSmoothControlPointsLooped(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2) {} // 0x0000000187776474-0x0000000187776730
	}

	public static class UnityVectorExtensions // TypeDefIndex: 55542
	{
		// Methods
		public static bool IsNaN(Vector3 v) => default; // 0x000000018428A2E0-0x000000018428A310
		public static float ClosestPointOnSegment(Vector3 p, Vector3 s0, Vector3 s1) => default; // 0x0000000187777298-0x0000000187777378
		public static float ClosestPointOnSegment(Vector2 p, Vector2 s0, Vector2 s1) => default; // 0x0000000187777200-0x0000000187777298
		public static Vector3 ProjectOntoPlane(Vector3 vector, Vector3 planeNormal) => default; // 0x00000001841EF3C0-0x00000001841EF480
		public static Vector2 Abs(Vector2 v) => default; // 0x0000000185FB1FF0-0x0000000185FB2020
		public static bool IsUniform(Vector2 v) => default; // 0x0000000187777378-0x00000001877773D0
		public static bool AlmostZero(Vector3 v) => default; // 0x00000001840D0A00-0x00000001840D13C0
		public static float Angle(Vector3 v1, Vector3 v2) => default; // 0x0000000184215770-0x0000000184215C90
		public static float SignedAngle(Vector3 v1, Vector3 v2, Vector3 up) => default; // 0x00000001840CDCB0-0x00000001840CDD90
		public static Quaternion SafeFromToRotation(Vector3 v1, Vector3 v2, Vector3 up) => default; // 0x00000001841308F0-0x0000000184130A00
	}

	public static class UnityQuaternionExtensions // TypeDefIndex: 55543
	{
		// Methods
		public static Quaternion SlerpWithReferenceUp(Quaternion qA, Quaternion qB, float t, Vector3 up) => default; // 0x0000000187776EF0-0x0000000187777200
		public static Quaternion Normalized(Quaternion q) => default; // 0x0000000183F918D0-0x0000000183F91AE0
		public static Vector2 GetCameraRotationToTarget(Quaternion orient, Vector3 lookAtDir, Vector3 worldUp) => default; // 0x00000001840D03E0-0x00000001840D0890
		public static Quaternion ApplyCameraRotation(Quaternion orient, Vector2 rot, Vector3 worldUp) => default; // 0x00000001841F1B40-0x00000001841F1C90
	}
}
