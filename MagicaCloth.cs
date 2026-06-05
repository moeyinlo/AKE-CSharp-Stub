/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Jobs;
using UnityEngine.LowLevel;
using UnityEngine.Profiling;
using UnityEngine.UI;

// Image 22: MagicaCloth.dll - Assembly: MagicaCloth, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 52265-52572

namespace MagicaCloth
{
	public abstract class BaseCloth : PhysicsTeam // TypeDefIndex: 52302
	{
		// Fields
		protected ClothParams clothParams; // 0x78
		protected List<int> clothParamDataHashList; // 0x80
		private ClothData clothData; // 0x88
		protected int clothDataHash; // 0x90
		protected int clothDataVersion; // 0x94
		private SelectionData clothSelection; // 0x98
		private int clothSelectionHash; // 0xA0
		private int clothSelectionVersion; // 0xA4
		private List<Renderer> cullRendererList; // 0xA8
		protected ClothSetup setup; // 0xB0
		private float oldBlendRatio; // 0xB8
		private TeamUpdateMode oldUpdateMode; // 0xBC
		private TeamCullingMode oldCullingMode; // 0xC0
		private bool oldUseAnimatedDistance; // 0xC4
	
		// Properties
		public float BlendWeight { get; set; } // 0x000000018AA55740-0x000000018AA557CC 0x0000000185FB06B0-0x0000000185FB06C0
		public Vector3 Gravity_GravityDirection { get; set; } // 0x000000018AA567C8-0x000000018AA567E8 0x000000018AA56AB0-0x000000018AA56AD0
		public bool DistanceDisable_Active { get; set; } // 0x000000018AA56B20-0x000000018AA56B4C 0x000000018AA567E8-0x000000018AA56808
		public Transform DistanceDisable_ReferenceObject { get; set; } // 0x000000018AA56AD0-0x000000018AA56AF8 0x000000018AA56808-0x000000018AA56828
		public float DistanceDisable_Distance { get; set; } // 0x000000018AA56AF8-0x000000018AA56B20 0x000000018AA54930-0x000000018AA54A00
		public float DistanceDisable_FadeDistance { get; set; } // 0x000000018AA56848-0x000000018AA56868 0x000000018AA56B4C-0x000000018AA56C20
		public float ExternalForce_WindInfluence { get; set; } // 0x000000018AA56C20-0x000000018AA56CF4 0x000000018AA56458-0x000000018AA56554
		public float ExternalForce_WindRandomScale { get; set; } // 0x000000018AA56554-0x000000018AA56650 0x000000018AA56914-0x000000018AA56934
		public float WorldInfluence_MaxMoveSpeed { get; set; } // 0x000000018AA570F4-0x000000018AA571B8 0x000000018AA56974-0x000000018AA56994
		public bool WorldInfluence_ResetAfterTeleport { get; set; } // 0x000000018AA5725C-0x000000018AA57320 0x000000018AA569B4-0x000000018AA569D4
		public float WorldInfluence_TeleportDistance { get; set; } // 0x000000018AA573E0-0x000000018AA574A4 0x000000018AA56994-0x000000018AA569B4
		public float WorldInfluence_TeleportRotation { get; set; } // 0x000000018AA57320-0x000000018AA573E0 0x000000018AA56954-0x000000018AA56974
		public ClothParams.TeleportMode WorldInfluence_TeleportMode { get; set; } // 0x000000018AA571B8-0x000000018AA5725C 0x000000018AA56310-0x000000018AA56458
		public float WorldInfluence_StabilizationTime { get; set; } // 0x000000018AA567A8-0x000000018AA567C8 0x000000018AA569EC-0x000000018AA56AB0
		public bool ColliderCollision_Active { get; set; } // 0x000000018AA56DD4-0x000000018AA56E9C 0x000000018AA554A8-0x000000018AA555B8
		public bool Penetration_Active { get; set; } // 0x000000018AA568D4-0x000000018AA568F4 0x000000018AA56E9C-0x000000018AA56F5C
		public bool Spring_Active { get; set; } // 0x000000018AA56F5C-0x000000018AA5702C 0x000000018AA54B9C-0x000000018AA54C68
		public float Spring_Power { get; set; } // 0x0000000183060C50-0x0000000183060C60 0x0000000185FB0510-0x0000000185FB0520
		public ClothParams Params { get; } // 0x0000000181E336C0-0x0000000181E336D0 
		public ClothData ClothData { get; set; } // 0x000000018346D8F0-0x000000018346D900 0x0000000185492010-0x0000000185492020
		public SelectionData ClothSelection { get; } // 0x000000018AA55460-0x000000018AA554A8 
		public ClothSetup Setup { get; } // 0x000000018AA55440-0x000000018AA55460 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 52301
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Renderer, bool> __9__106_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018AA55A20-0x000000018AA55A50
			public __c() {} // 0x000000018AA559F0-0x000000018AA55A20
	
			// Methods
			internal bool _GetCullRenderListCount_b__106_0(Renderer x) => default; // 0x000000018AA55A50-0x000000018AA55A58
		}
	
		// Constructors
		protected BaseCloth() {} // 0x000000018AA80CF4-0x000000018AA80D40
	
		// Methods
		public void ResetCloth() {} // 0x000000018AA55A58-0x000000018AA55AE0
		public void ResetCloth(float resetStabilizationTime) {} // 0x000000018AA54C68-0x000000018AA54CE4
		public void ResetCloth(ClothParams.TeleportMode teleportMode, float resetStabilizationTime = -1f /* Metadata: 0x02076548 */) {} // 0x000000018AA53F00-0x000000018AA53FE0
		public void SetTimeScale(float timeScale) {} // 0x0000000185FB0590-0x0000000185FB05A0
		public float GetTimeScale() => default; // 0x000000018AA569D4-0x000000018AA569EC
		public void AddForce(Vector3 force, PhysicsManagerTeamData.ForceMode mode) {} // 0x000000018AA53E5C-0x000000018AA53F00
		public void AddCollider(ColliderComponent collider) {} // 0x0000000185FB06A0-0x0000000185FB06B0
		public void RemoveCollider(ColliderComponent collider) {} // 0x000000018AA555B8-0x000000018AA55740
		public void SetUpdateMode(TeamUpdateMode updateMode) {} // 0x000000018AA54EE8-0x000000018AA55080
		public void SetCullingMode(TeamCullingMode cullingMode) {} // 0x000000018AA5421C-0x000000018AA543C8
		public void Radius_SetRadius(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x0207654C */) {} // 0x000000018AA54D60-0x000000018AA54E38
		public void Mass_SetMass(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x02076550 */) {} // 0x000000018AA56888-0x000000018AA568B4
		public void ClampPosition_SetPositionLength(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x02076554 */) {} // 0x000000018AA56CF4-0x000000018AA56DD4
		public void Gravity_SetGravity(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x02076558 */) {} // 0x000000018AA54754-0x000000018AA5482C
		public void Drag_SetDrag(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x0207655C */) {} // 0x000000018AA56828-0x000000018AA56848
		public void ExternalForce_DepthInfluence(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x02076560 */) {} // 0x000000018AA56868-0x000000018AA56888
		public void WorldInfluence_SetMovementInfluence(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x02076564 */) {} // 0x000000018AA5702C-0x000000018AA570F4
		public void WorldInfluence_SetRotationInfluence(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x02076568 */) {} // 0x000000018AA56934-0x000000018AA56954
		public void WorldInfluence_ReplaceInfluenceTarget(Transform target) {} // 0x000000018AA568B4-0x000000018AA568D4
		public void Penetration_SetMovingRadius(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x0207656C */) {} // 0x000000018AA568F4-0x000000018AA56914
		public override int GetDataHash() => default; // 0x0000000186472AA8-0x0000000186472ABC
		protected virtual void Reset() {} // 0x000000018AA55080-0x000000018AA551D0
		protected virtual void OnValidate() {} // 0x000000018AA55304-0x000000018AA55440
		protected override void OnInit() {} // 0x000000018AA552E4-0x000000018AA55304
		protected override void OnActive() {} // 0x000000018AA55DDC-0x000000018AA56118
		protected override void OnInactive() {} // 0x000000018AA551D0-0x000000018AA552E4
		protected override void OnDispose() {} // 0x000000018AA54A7C-0x000000018AA54B9C
		internal override void UpdateCullingMode(CoreComponent caller) {} // 0x000000018AA54094-0x000000018AA54190
		protected override void OnChangeCalculation() {} // 0x000000018AA53FE0-0x000000018AA54094
		public int GetCullRenderListCount() => default; // 0x000000018AA54488-0x000000018AA5456C
		private void BaseClothInit() {} // 0x000000018AA543C8-0x000000018AA54460
		private void BaseClothDispose() {} // 0x000000018AA54460-0x000000018AA54488
		protected virtual void ClothInit() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void ClothActive() {}
		protected virtual void ClothInactive() {}
		protected virtual void ClothDispose() {}
		protected abstract uint UserFlag(int vindex);
		protected abstract Transform UserTransform(int vindex);
		protected abstract float3 UserTransformLocalPosition(int vindex);
		protected abstract quaternion UserTransformLocalRotation(int vindex);
		public abstract bool IsRequiresDeformer();
		public abstract BaseMeshDeformer GetDeformer(); // 0x000000018AA55AE0-0x000000018AA55B68
		protected abstract MeshData GetMeshData(); // 0x000000018AA55B68-0x000000018AA55BEC
		protected abstract void WorkerInit();
		private void SetUseMesh(bool sw) {} // 0x000000018AA54718-0x000000018AA54754
		private void SetUseVertex(bool sw) {} // 0x000000018AA55BEC-0x000000018AA55DDC
		protected abstract void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer);
		internal void DeformerForEach(Action<BaseMeshDeformer> act) {} // 0x000000018AA54CE4-0x000000018AA54D60
		public void UpdateBlend() {} // 0x000000018AA54190-0x000000018AA5421C
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict) {} // 0x000000018AA5456C-0x000000018AA54718
		public override HashSet<Transform> GetUsedBones() => default; // 0x000000018AA561D8-0x000000018AA56310
		protected override void ChangeUseUnityPhysics(bool sw) {} // 0x000000018AA54E38-0x000000018AA54EE8
		public override void CreateVerifyData() {} // 0x000000018AA56150-0x000000018AA561D8
		public override Define.Error VerifyData() => default; // 0x000000018AA56118-0x000000018AA56150
		public bool HasChangedParam(ClothParams.ParamType ptype) => default; // 0x000000018AA54A00-0x000000018AA54A7C
		public Define.Error VerifyAlgorithmVersion() => default; // 0x000000018AA5482C-0x000000018AA54930
		public override bool UpgradeFormat() => default; // 0x000000018AA557CC-0x000000018AA559F0
		public override List<ShareDataObject> GetAllShareDataObject() => default; // 0x000000018AA56650-0x000000018AA567A8
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source) => default; // 0x000000018AA810C4-0x000000018AA81128
		private void ResetClothInternal(ClothParams.TeleportMode teleportMode, float resetStabilizationTime) {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class CoreComponent : BaseComponent, IShareDataObject, IDataVerify, IEditorMesh, IEditorCloth, IDataHash, IBoneReplace // TypeDefIndex: 52303
	{
		// Fields
		protected int dataHash; // 0x18
		protected int dataVersion; // 0x1C
		protected RuntimeStatus status; // 0x20
		private int useUnityPhysicsCount; // 0x28
		private bool nowUseUnityPhysics; // 0x2C
		private bool _IsVisible_k__BackingField; // 0x2D
		protected int calculateValue; // 0x30
	
		// Properties
		public RuntimeStatus Status { get; } // 0x00000001813B31A0-0x00000001813B31B0 
		public bool IsVisible { get; protected set; } // 0x0000000185FB0AD0-0x0000000185FB0AE0 0x0000000185FB0AF0-0x0000000185FB0B00
		public bool IsCalculate { get; } // 0x0000000187868D70-0x0000000187868D78 
		public int SaveDataHash { get; } // 0x00000001813AE560-0x00000001813AE570 
		public int SaveDataVersion { get; } // 0x00000001813AE570-0x00000001813AE580 
	
		// Constructors
		protected CoreComponent() {} // 0x000000018AA7D078-0x000000018AA7D0EC
	
		// Methods
		public Dictionary<string, Transform> GetUsedComponentBones() => default; // 0x000000018AA7C814-0x000000018AA7CAD8
		public List<string> GetUsedComponentBoneNames() => default; // 0x000000018AA7C778-0x000000018AA7C814
		public void ReplaceComponentBone(Dictionary<Transform, Transform> boneReplaceDict) {} // 0x000000018AA7CED0-0x000000018AA7CF18
		public void ReplaceComponentBone(Dictionary<string, Transform> boneReplaceDict) {} // 0x000000018AA7CE88-0x000000018AA7CED0
		public abstract int GetDataHash();
		protected virtual void Start() {} // 0x000000018AA7CFB0-0x000000018AA7CFB8
		public virtual void OnEnable() {} // 0x000000018AA7CDF0-0x000000018AA7CE1C
		public virtual void OnDisable() {} // 0x000000018AA7CDBC-0x000000018AA7CDE8
		protected virtual void OnDestroy() {} // 0x000000018AA7CD20-0x000000018AA7CDBC
		public void Init() {} // 0x000000018AA7CAF4-0x000000018AA7CCFC
		protected abstract void OnInit();
		protected abstract void OnDispose();
		protected abstract void OnUpdate();
		protected abstract void OnActive();
		protected abstract void OnInactive();
		protected virtual void OnUpdateStatus() {} // 0x000000018AA7CE1C-0x000000018AA7CE88
		protected virtual void OnDisconnectedStatus() {} // 0x000000018AA7CDE8-0x000000018AA7CDF0
		public void SetUseUnityPhysics(bool sw) {} // 0x000000018AA7CF18-0x000000018AA7CF7C
		private void ActiveUseUnityPhysics() {} // 0x000000018AA7C520-0x000000018AA7C544
		private void InactiveUseUnityPhysics() {} // 0x000000018AA7CAD8-0x000000018AA7CAF4
		protected virtual void ChangeUseUnityPhysics(bool sw) {} // 0x0000000185492010-0x0000000185492020
		protected bool IsUseUnityPhysics() => default; // 0x0000000189ECD678-0x0000000189ECD680
		public virtual List<ShareDataObject> GetAllShareDataObject() => default; // 0x000000018AA7C574-0x000000018AA7C5D4
		public abstract ShareDataObject DuplicateShareDataObject(ShareDataObject source);
		protected void SetUserEnable(bool sw) {} // 0x000000018AA7CF7C-0x000000018AA7CFB0
		internal virtual void UpdateCullingMode(CoreComponent Caller) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnChangeCalculation() {} // 0x0000000185492010-0x0000000185492020
		public abstract int GetVersion();
		public abstract int GetErrorVersion();
		public virtual Define.Error VerifyData() => default; // 0x000000018AA7CFF4-0x000000018AA7D078
		public Define.Error VerifyDataVersion() => default; // 0x000000018AA7CFB8-0x000000018AA7CFF4
		public bool IsOldDataVertion() => default; // 0x000000018AA7CCFC-0x000000018AA7CD20
		public virtual void CreateVerifyData() {} // 0x000000018AA7C544-0x000000018AA7C574
		public virtual string GetInformation() => default; // 0x000000018AA7C6B8-0x000000018AA7C6E4
		public virtual bool UpgradeFormat() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public void ChangeAvatar<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class {}
		public virtual void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class {}
		public virtual HashSet<Transform> GetUsedBones() => default; // 0x000000018AA7C6E4-0x000000018AA7C778
		public virtual int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x000000018AA7C620-0x000000018AA7C66C
		public virtual List<int> GetEditorTriangleList() => default; // 0x000000018AA7C66C-0x000000018AA7C6B8
		public virtual List<int> GetEditorLineList() => default; // 0x000000018AA7C5D4-0x000000018AA7C620
		public virtual List<int> GetSelectionList() => default; // 0x00000001813AE580-0x00000001813AE590
		public virtual List<int> GetUseList() => default; // 0x00000001813AE580-0x00000001813AE590
		private object _Init_b__27_0() => default; // 0x0000000185779060-0x0000000185779070
	}

	[Serializable]
	public class AvatarPartsAttachEvent : UnityEvent<MagicaCloth.MagicaAvatar, MagicaCloth.MagicaAvatarParts> // TypeDefIndex: 52304
	{
		// Constructors
		public AvatarPartsAttachEvent() {} // 0x000000018AA6E578-0x000000018AA6E5B4
	}

	[Serializable]
	public class AvatarPartsDetachEvent : UnityEvent<MagicaCloth.MagicaAvatar> // TypeDefIndex: 52305
	{
		// Constructors
		public AvatarPartsDetachEvent() {} // 0x000000018AA6E5B4-0x000000018AA6E5F0
	}

	[Serializable]
	public class PhysicsManagerPreUpdateEvent : UnityEvent // TypeDefIndex: 52306
	{
		// Constructors
		public PhysicsManagerPreUpdateEvent() {} // 0x0000000186470378-0x0000000186470380
	}

	[Serializable]
	public class PhysicsManagerPostUpdateEvent : UnityEvent // TypeDefIndex: 52307
	{
		// Constructors
		public PhysicsManagerPostUpdateEvent() {} // 0x0000000186470378-0x0000000186470380
	}

	public class MagicaAreaWind : WindComponent // TypeDefIndex: 52308
	{
		// Fields
		private PhysicsManagerWindData.ShapeType shapeType; // 0x58
		private bool isAddition; // 0x5C
	
		// Properties
		public PhysicsManagerWindData.ShapeType ShapeType { get => default; set {} } // 0x0000000183F80450-0x0000000183F80460 0x000000018AA7D310-0x000000018AA7D330
		public bool Addition { get => default; set {} } // 0x0000000185FB0C10-0x0000000185FB0C20 0x000000018AA7D2F0-0x000000018AA7D310
	
		// Constructors
		public MagicaAreaWind() {} // 0x000000018AA7D2E8-0x000000018AA7D2F0
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000185FCEBC0-0x0000000185FCEBD0
		public override PhysicsManagerWindData.WindType GetWindType() => default; // 0x0000000181C6A970-0x0000000181C6A980
		public override PhysicsManagerWindData.ShapeType GetShapeType() => default; // 0x0000000183F80450-0x0000000183F80460
		public override PhysicsManagerWindData.DirectionType GetDirectionType() => default; // 0x000000018AA7D278-0x000000018AA7D288
		public override bool IsAddition() => default; // 0x0000000185FB0C10-0x0000000185FB0C20
		public override Vector3 GetAreaSize() => default; // 0x000000018AA7D138-0x000000018AA7D1D0
		public override float GetAreaVolume() => default; // 0x000000018AA7D1D0-0x000000018AA7D278
		public override float GetAreaLength() => default; // 0x000000018AA7D0EC-0x000000018AA7D138
		protected override void ResetParams() {} // 0x000000018AA7D288-0x000000018AA7D2E8
	}

	public class MagicaAvatar : CoreComponent // TypeDefIndex: 52309
	{
		// Fields
		private const int DATA_VERSION = 1; // Metadata: 0x02076570
		private bool dataReset; // 0x38
		private MagicaAvatarRuntime runtime; // 0x40
		public AvatarPartsAttachEvent OnAttachParts; // 0x48
		public AvatarPartsDetachEvent OnDetachParts; // 0x50
	
		// Properties
		public bool DataReset { get => default; set {} } // 0x0000000185FB0700-0x0000000185FB0710 0x0000000185FAFE20-0x0000000185FAFE30
		public MagicaAvatarRuntime Runtime { get => default; } // 0x0000000185C4D720-0x0000000185C4D750 
	
		// Constructors
		public MagicaAvatar() {} // 0x000000018AA807B8-0x000000018AA80898
	
		// Methods
		public int AttachAvatarParts(GameObject avatarPartsPrefab, Action<GameObject> instanceAction = null) => default; // 0x000000018AA7FED0-0x000000018AA7FF98
		public void DetachAvatarParts(int partsId) {} // 0x000000018AA7FFD0-0x000000018AA7FFFC
		public void DetachAvatarParts(GameObject avatarPartsObject) {} // 0x000000018AA7FFFC-0x000000018AA8006C
		public void DetachAvatarParts(MagicaAvatarParts parts) {} // 0x000000018AA7FFA0-0x000000018AA7FFD0
		public override ComponentType GetComponentType() => default; // 0x0000000185FBE5C0-0x0000000185FBE5D0
		public override int GetDataHash() => default; // 0x00000001813AE580-0x00000001813AE590
		private void Reset() {} // 0x0000000185FB8040-0x0000000185FB8050
		private void OnValidate() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnInit() {} // 0x000000018AA80718-0x000000018AA80740
		protected override void OnDispose() {} // 0x000000018AA806C8-0x000000018AA806F0
		protected override void OnUpdate() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnActive() {} // 0x000000018AA806A0-0x000000018AA806C8
		protected override void OnInactive() {} // 0x000000018AA806F0-0x000000018AA80718
		public override int GetVersion() => default; // 0x0000000181B87DE0-0x0000000181B87DF0
		public override int GetErrorVersion() => default; // 0x00000001813AE580-0x00000001813AE590
		public override void CreateVerifyData() {} // 0x000000018AA7FF98-0x000000018AA7FFA0
		public override Define.Error VerifyData() => default; // 0x000000018AA80740-0x000000018AA807B8
		public override string GetInformation() => default; // 0x000000018AA80074-0x000000018AA806A0
		public override List<ShareDataObject> GetAllShareDataObject() => default; // 0x000000018AA8006C-0x000000018AA80074
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source) => default; // 0x00000001813AE580-0x00000001813AE590
	}

	public class MagicaDirectionalWind : WindComponent // TypeDefIndex: 52310
	{
		// Constructors
		public MagicaDirectionalWind() {} // 0x000000018AA7D2E8-0x000000018AA7D2F0
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000185FCEC20-0x0000000185FCEC30
		public override PhysicsManagerWindData.WindType GetWindType() => default; // 0x0000000181B87DE0-0x0000000181B87DF0
		public override PhysicsManagerWindData.ShapeType GetShapeType() => default; // 0x00000001813AE580-0x00000001813AE590
		public override PhysicsManagerWindData.DirectionType GetDirectionType() => default; // 0x00000001813AE580-0x00000001813AE590
		public override bool IsAddition() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override Vector3 GetAreaSize() => default; // 0x0000000185FCEBF0-0x0000000185FCEC10
		public override float GetAreaVolume() => default; // 0x0000000185FCEC10-0x0000000185FCEC20
		public override float GetAreaLength() => default; // 0x0000000185FCEBE0-0x0000000185FCEBF0
		protected override void ResetParams() {} // 0x000000018AA80898-0x000000018AA808F8
	}

	public class MagicaPhysicsManager : CreateSingleton<MagicaCloth.MagicaPhysicsManager> // TypeDefIndex: 52313
	{
		// Fields
		private UpdateTimeManager updateTime; // 0x18
		private PhysicsManagerParticleData particle; // 0x20
		private PhysicsManagerBoneData bone; // 0x28
		private PhysicsManagerMeshData mesh; // 0x30
		private PhysicsManagerTeamData team; // 0x38
		private PhysicsManagerWindData wind; // 0x40
		private PhysicsManagerComponent component; // 0x48
		private PhysicsManagerCompute compute; // 0x50
		private bool useFasterWrite; // 0x58
		private ComputeShader meshWriter; // 0x60
		public PhysicsManagerPreUpdateEvent OnPreUpdate; // 0x68
		public PhysicsManagerPostUpdateEvent OnPostUpdate; // 0x70
		private bool useDelay; // 0x78
		private bool updatePlayerLoop; // 0x79
		private bool isActive; // 0x7A
	
		// Properties
		public UpdateTimeManager.UpdateCount UpdatePerSeccond { get => default; set {} } // 0x0000000185C4D640-0x0000000185C4D720 0x000000018AA808F8-0x000000018AA80964
		public UpdateTimeManager.UpdateMode UpdateMode { get => default; set {} } // 0x0000000185FAF300-0x0000000185FAF320 0x000000018AA80A6C-0x000000018AA80AA0
		public float FuturePredictionRate { get => default; set {} } // 0x000000018AA80964-0x000000018AA80A6C 0x0000000184407AB0-0x0000000184407AF0
		public UpdateTimeManager UpdateTime { get => default; } // 0x0000000184409480-0x00000001844094C0 
		public PhysicsManagerParticleData Particle { get => default; } // 0x0000000184407AF0-0x0000000184407B30 
		public PhysicsManagerBoneData Bone { get => default; } // 0x000000018440ABC0-0x000000018440ABF0 
		public PhysicsManagerMeshData Mesh { get => default; } // 0x000000018440AB90-0x000000018440ABC0 
		public PhysicsManagerTeamData Team { get => default; } // 0x00000001844097C0-0x0000000184409CB0 
		public PhysicsManagerWindData Wind { get => default; } // 0x000000018440AB40-0x000000018440AB60 
		public PhysicsManagerComponent Component { get => default; } // 0x000000018440AB60-0x000000018440AB90 
		public PhysicsManagerCompute Compute { get => default; } // 0x0000000185FA7B40-0x0000000185FA7B70 
		public bool IsDelay { get => default; } // 0x000000018522BC40-0x000000018522BCE0 
		public bool IsActive { get => default; set {} } // 0x0000000184B29120-0x0000000184B2AA90 0x0000000184B276F0-0x0000000184B27880
		public bool IsFasterWrite { get => default; } // 0x000000018588C580-0x000000018588C800 
		internal ComputeShader MeshWriterShader { get => default; } // 0x0000000185F73090-0x0000000185F730F0 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 52311
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static PlayerLoopSystem.UpdateFunction __9__69_11; // 0x08
			public static PlayerLoopSystem.UpdateFunction __9__69_12; // 0x10
			public static PlayerLoopSystem.UpdateFunction __9__69_13; // 0x18
			public static PlayerLoopSystem.UpdateFunction __9__69_14; // 0x20
			public static PlayerLoopSystem.UpdateFunction __9__69_15; // 0x28
			public static PlayerLoopSystem.UpdateFunction __9__69_16; // 0x30
			public static PlayerLoopSystem.UpdateFunction __9__69_17; // 0x38
			public static Predicate<PlayerLoopSystem> __9__69_0; // 0x40
			public static Predicate<PlayerLoopSystem> __9__69_1; // 0x48
			public static Predicate<PlayerLoopSystem> __9__69_2; // 0x50
			public static Predicate<PlayerLoopSystem> __9__69_3; // 0x58
			public static Predicate<PlayerLoopSystem> __9__69_4; // 0x60
			public static Predicate<PlayerLoopSystem> __9__69_5; // 0x68
			public static Predicate<PlayerLoopSystem> __9__69_6; // 0x70
			public static Predicate<PlayerLoopSystem> __9__69_7; // 0x78
			public static Predicate<PlayerLoopSystem> __9__69_8; // 0x80
			public static Predicate<PlayerLoopSystem> __9__69_9; // 0x88
			public static Predicate<PlayerLoopSystem> __9__69_10; // 0x90
	
			// Constructors
			static __c() {} // 0x0000000186471858-0x0000000186471874
			public __c() {} // 0x00000001880ADBC4-0x00000001880ADBE0
	
			// Methods
			internal void _SetCustomGameLoop_b__69_11() {} // 0x000000018AA80C44-0x000000018AA80C60
			internal void _SetCustomGameLoop_b__69_12() {} // 0x000000018AA80C90-0x000000018AA80CAC
			internal void _SetCustomGameLoop_b__69_13() {} // 0x000000018AA80AA0-0x000000018AA80ACC
			internal void _SetCustomGameLoop_b__69_14() {} // 0x0000000186471838-0x0000000186471858
			internal void _SetCustomGameLoop_b__69_15() {} // 0x0000000186473E44-0x0000000186473E64
			internal void _SetCustomGameLoop_b__69_16() {} // 0x000000018AA80C60-0x000000018AA80C88
			internal void _SetCustomGameLoop_b__69_17() {} // 0x0000000181377E40-0x0000000181377E50
			internal bool _SetCustomGameLoop_b__69_0(PlayerLoopSystem s) => default; // 0x0000000185C4D750-0x0000000185C4D780
			internal bool _SetCustomGameLoop_b__69_1(PlayerLoopSystem s) => default; // 0x000000018440A9F0-0x000000018440AA20
			internal bool _SetCustomGameLoop_b__69_2(PlayerLoopSystem h) => default; // 0x00000001844096A0-0x0000000184409730
			internal bool _SetCustomGameLoop_b__69_3(PlayerLoopSystem s) => default; // 0x0000000184409730-0x00000001844097C0
			internal bool _SetCustomGameLoop_b__69_4(PlayerLoopSystem h) => default; // 0x0000000185C4D720-0x0000000185C4D750
			internal bool _SetCustomGameLoop_b__69_5(PlayerLoopSystem s) => default; // 0x000000018440A9C0-0x000000018440A9F0
			internal bool _SetCustomGameLoop_b__69_6(PlayerLoopSystem h) => default; // 0x0000000184409CB0-0x0000000184409D40
			internal bool _SetCustomGameLoop_b__69_7(PlayerLoopSystem s) => default; // 0x0000000185FB0DA0-0x0000000185FB0DB0
			internal bool _SetCustomGameLoop_b__69_8(PlayerLoopSystem h) => default; // 0x0000000185FB2E60-0x0000000185FB2E70
			internal bool _SetCustomGameLoop_b__69_9(PlayerLoopSystem s) => default; // 0x000000018AA80C88-0x000000018AA80C90
			internal bool _SetCustomGameLoop_b__69_10(PlayerLoopSystem h) => default; // 0x000000018AA80ACC-0x000000018AA80B80
		}
	
		private sealed class __c__DisplayClass70_0 // TypeDefIndex: 52312
		{
			// Fields
			public System.Type t; // 0x10
			public Func<PlayerLoopSystem, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass70_0() {} // 0x000000018AA80B80-0x000000018AA80C44
	
			// Methods
			internal bool _CheckRegist_b__0(PlayerLoopSystem x) => default; // 0x0000000185F9DAB0-0x0000000185F9DAF0
		}
	
		// Constructors
		public MagicaPhysicsManager() {} // 0x00000001855DB750-0x00000001855DB7B0
	
		// Methods
		public void SetGlobalTimeScale(float timeScale) {} // 0x000000018522BC10-0x000000018522BC40
		public float GetGlobalTimeScale() => default; // 0x0000000185032F70-0x0000000185033150
		protected override void Awake() {} // 0x0000000185492010-0x0000000185492020
		protected override void InitSingleton() {} // 0x0000000184409350-0x00000001844093E0
		protected override void DuplicateDetection(MagicaPhysicsManager duplicate) {} // 0x00000001844093E0-0x0000000184409480
		protected void OnEnable() {} // 0x00000001844090B0-0x0000000184409150
		protected void OnDisable() {} // 0x0000000184409150-0x00000001844091C0
		private void Update() {} // 0x00000001844091C0-0x0000000184409240
		private void FixedUpdate() {} // 0x0000000184409240-0x00000001844092C0
		protected override void OnDestroy() {} // 0x00000001844092C0-0x0000000184409350
		private void AfterEarlyUpdate() {} // 0x00000001853DB4F0-0x00000001853DB550
		private void AfterFixedUpdate() {} // 0x00000001853DB3E0-0x00000001853DB440
		private void AfterUpdate() {} // 0x00000001853DB370-0x00000001853DB3E0
		private void BeforeLateUpdate() {} // 0x00000001853DB310-0x00000001853DB370
		private void AfterLateUpdate() {} // 0x00000001853DB550-0x00000001853DB5C0
		private void DefaultUpdate() {} // 0x00000001853DB2B0-0x00000001853DB310
		private void PostLateUpdate() {} // 0x00000001853DB110-0x00000001853DB180
		private void AfterRendering() {} // 0x00000001853DB250-0x00000001853DB2B0
		private static void Init() {} // 0x00000001853DB440-0x00000001853DB4B0
		public static void InitCustomGameLoop() {} // 0x00000001853DB1F0-0x00000001853DB250
		public static void SetCustomGameLoop(ref PlayerLoopSystem playerLoop) {} // 0x00000001857B43B0-0x00000001857B4420
		private static bool CheckRegist(ref PlayerLoopSystem playerLoop) => default; // 0x0000000185492010-0x0000000185492020
	}

	public abstract class WindComponent : BaseComponent // TypeDefIndex: 52314
	{
		// Fields
		protected float main; // 0x18
		protected float turbulence; // 0x1C
		protected float frequency; // 0x20
		protected Vector3 areaSize; // 0x24
		protected float areaRadius; // 0x30
		protected float directionAngleX; // 0x34
		protected float directionAngleY; // 0x38
		protected PhysicsManagerWindData.DirectionType directionType; // 0x3C
		protected BezierParam attenuation; // 0x40
		protected int windId; // 0x48
		protected RuntimeStatus status; // 0x50
	
		// Properties
		public float Main { get; set; } // 0x0000000181C9AC50-0x0000000181C9AC60 0x000000018AA820D4-0x000000018AA82114
		public float Turbulence { get; set; } // 0x0000000185FB0850-0x0000000185FB0860 0x000000018AA82114-0x000000018AA82140
		public float Frequency { get; set; } // 0x0000000181C9AC70-0x0000000181C9AC80 0x000000018AA81FF4-0x000000018AA82020
		public Vector3 MainDirection { get; set; } // 0x000000018AA81E20-0x000000018AA81EA4 0x000000018AA82020-0x000000018AA820D4
		public float DirectionAngleX { get; set; } // 0x0000000185FB8060-0x0000000185FB8070 0x000000018AA81F8C-0x000000018AA81FB0
		public float DirectionAngleY { get; set; } // 0x0000000185FB24B0-0x0000000185FB24C0 0x000000018AA81FB0-0x000000018AA81FD4
		public Vector3 AreaSize { get; set; } // 0x0000000185FB8980-0x0000000185FB89A0 0x000000018AA81ED8-0x000000018AA81F8C
		public float AreaRadius { get; set; } // 0x0000000185FB0BE0-0x0000000185FB0BF0 0x000000018AA81EA4-0x000000018AA81ED8
		public PhysicsManagerWindData.DirectionType DirectionType { get; set; } // 0x0000000185FB0790-0x0000000185FB07A0 0x000000018AA81FD4-0x000000018AA81FF4
		internal RuntimeStatus Status { get; } // 0x0000000181460F60-0x0000000181460F70 
	
		// Constructors
		protected WindComponent() {} // 0x000000018AA81D44-0x000000018AA81E20
	
		// Methods
		public void SetAttenuation(float sval, float eval, bool useEval = true /* Metadata: 0x02076571 */, float cval = 0f /* Metadata: 0x02076572 */, bool useCval = false /* Metadata: 0x02076576 */) {} // 0x000000018AA81C90-0x000000018AA81CD8
		protected virtual void Reset() {} // 0x000000018AA81C80-0x000000018AA81C90
		protected virtual void OnValidate() {} // 0x000000018AA81B1C-0x000000018AA81BF8
		private void OnDidApplyAnimationProperties() {} // 0x000000018AA81994-0x000000018AA819C4
		protected virtual void Start() {} // 0x000000018AA81CD8-0x000000018AA81CE0
		internal virtual void OnEnable() {} // 0x000000018AA81A3C-0x000000018AA81A68
		internal virtual void OnDisable() {} // 0x000000018AA819C4-0x000000018AA819F0
		protected virtual void OnDestroy() {} // 0x000000018AA81968-0x000000018AA81994
		protected virtual void Update() {} // 0x000000018AA81CE0-0x000000018AA81D44
		private void Init() {} // 0x000000018AA81814-0x000000018AA81960
		protected void OnUpdateStatus() {} // 0x000000018AA81AB0-0x000000018AA81AEC
		internal virtual bool VerifyData() => default; // 0x00000001840A27C0-0x00000001840A27D0
		protected virtual void OnInit() {} // 0x000000018AA81A70-0x000000018AA81AB0
		protected virtual void OnDispose() {} // 0x000000018AA819F0-0x000000018AA81A3C
		protected virtual void OnUpdate() {} // 0x000000018AA81AEC-0x000000018AA81B1C
		protected virtual void OnActive() {} // 0x000000018AA81960-0x000000018AA81968
		protected virtual void OnInactive() {} // 0x000000018AA81A68-0x000000018AA81A70
		protected void EnableWind() {} // 0x000000018AA8170C-0x000000018AA8179C
		protected void DisableWind() {} // 0x000000018AA81660-0x000000018AA8170C
		private void RemoveWind() {} // 0x000000018AA81BF8-0x000000018AA81C80
		private void CreateWind() {} // 0x000000018AA81438-0x000000018AA81660
		internal Vector3 GetLocalDirection() => default; // 0x000000018AA8179C-0x000000018AA81814
		private void ChangeParameter() {} // 0x000000018AA81250-0x000000018AA81438
		public abstract PhysicsManagerWindData.WindType GetWindType();
		public abstract PhysicsManagerWindData.ShapeType GetShapeType();
		public abstract PhysicsManagerWindData.DirectionType GetDirectionType();
		public abstract bool IsAddition();
		public abstract Vector3 GetAreaSize();
		public abstract float GetAreaVolume();
		public abstract float GetAreaLength();
		protected abstract void ResetParams();
		private object _Init_b__49_0() => default; // 0x0000000185779060-0x0000000185779070
	}

	public abstract class MagicaAvatarAccess : IDisposable // TypeDefIndex: 52315
	{
		// Fields
		protected MagicaAvatar owner; // 0x10
	
		// Properties
		protected MagicaAvatarRuntime Runtime { get; } // 0x000000018AA7D330-0x000000018AA7D350 
	
		// Constructors
		protected MagicaAvatarAccess() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void SetParent(MagicaAvatar avatar) {} // 0x0000000184096E30-0x0000000184096EF0
		public abstract void Create();
		public abstract void Dispose();
		public abstract void Active();
		public abstract void Inactive();
	}

	public class MagicaAvatarParts : BaseComponent, IDataVerify // TypeDefIndex: 52316
	{
		// Fields
		private MagicaAvatar parentAvatar; // 0x18
		private Dictionary<string, Transform> boneDict; // 0x20
		private List<CoreComponent> magicaComponentList; // 0x28
	
		// Properties
		public MagicaAvatar ParentAvatar { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public bool HasParent { get => default; } // 0x000000018AA7DE08-0x000000018AA7DE58 
		public int PartsId { get => default; } // 0x000000018AA7DE58-0x000000018AA7DE60 
	
		// Constructors
		public MagicaAvatarParts() {} // 0x000000018AA7DD88-0x000000018AA7DE08
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000185FCEBD0-0x0000000185FCEBE0
		private void OnDestroy() {} // 0x000000018AA7DD18-0x000000018AA7DD20
		public void Dispose() {} // 0x000000018AA7D568-0x000000018AA7D5F4
		public List<Transform> CheckOverlappingTransform() => default; // 0x000000018AA7D350-0x000000018AA7D51C
		public Dictionary<string, Transform> GetBoneDict() => default; // 0x000000018AA7D5F4-0x000000018AA7D7B4
		public List<CoreComponent> GetMagicaComponentList() => default; // 0x000000018AA7DC6C-0x000000018AA7DD18
		public int GetVersion() => default; // 0x0000000181B87DE0-0x0000000181B87DF0
		public void CreateVerifyData() {} // 0x000000018AA7D51C-0x000000018AA7D568
		public Define.Error VerifyData() => default; // 0x000000018AA7DD20-0x000000018AA7DD88
		public string GetInformation() => default; // 0x000000018AA7D7B4-0x000000018AA7DC6C
	}

	public class MagicaAvatarRuntime : MagicaAvatarAccess // TypeDefIndex: 52318
	{
		// Fields
		private Dictionary<string, Transform> boneDict; // 0x18
		private Dictionary<Transform, int> boneReferenceDict; // 0x20
		private List<MagicaAvatarParts> avatarPartsList; // 0x28
		private List<ColliderComponent> colliderList; // 0x30
	
		// Properties
		public int AvatarPartsCount { get => default; } // 0x000000018AA7EF84-0x000000018AA7F12C 
	
		// Nested types
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 52317
		{
			// Fields
			public int partsId; // 0x10
	
			// Constructors
			public __c__DisplayClass20_0() {} // 0x000000018AA7F1A4-0x000000018AA7F1C4
	
			// Methods
			internal bool _RemoveAvatarParts_b__0(MagicaAvatarParts p) => default; // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public MagicaAvatarRuntime() {} // 0x000000018AA81094-0x000000018AA810C4
	
		// Methods
		public override void Create() {} // 0x0000000185492010-0x0000000185492020
		public override void Dispose() {} // 0x0000000185492010-0x0000000185492020
		public override void Active() {} // 0x000000018AA7FE90-0x000000018AA7FED0
		public override void Inactive() {} // 0x000000018AA7F1C4-0x000000018AA7F218
		public MagicaAvatarParts GetAvatarParts(int index) => default; // 0x000000018AA7F12C-0x000000018AA7F1A4
		private void CreateBoneDict() {} // 0x000000018AA7F218-0x000000018AA7F284
		private void CreateColliderList() {} // 0x000000018AA7EDA8-0x000000018AA7EF84
		public int GetColliderCount() => default; // 0x000000018AA7DE60-0x000000018AA7EADC
		public List<Transform> CheckOverlappingTransform() => default; // 0x000000018AA7EADC-0x000000018AA7EDA8
		public int AddAvatarParts(MagicaAvatarParts parts) => default; // 0x000000018AA7FC44-0x000000018AA7FD38
		private void AddBone(Transform root, Transform croot, Transform bone) {} // 0x000000018AA7FBF0-0x000000018AA7FC44
		private void ReplaceSkinMeshRenderer(SkinnedMeshRenderer skinRenderer, Dictionary<Transform, Transform> boneReplaceDict) {} // 0x000000018AA7F284-0x000000018AA7FB14
		private void ReplaceMagicaComponent(CoreComponent comp, Dictionary<Transform, Transform> boneReplaceDict) {} // 0x000000018AA7FB14-0x000000018AA7FBF0
		public void RemoveAvatarParts(MagicaAvatarParts parts) {} // 0x000000018AA7FD38-0x000000018AA7FE90
		public void RemoveAvatarParts(int partsId) {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class BoneClothTarget : IDataHash, IBoneReplace // TypeDefIndex: 52320
	{
		// Fields
		private List<Transform> rootList; // 0x10
		private ConnectionMode connection; // 0x18
		private float sameSurfaceAngle; // 0x1C
		private int[] parentIndexList; // 0x20
	
		// Properties
		public int RootCount { get => default; } // 0x000000018AA6EE80-0x000000018AA6EEC0 
		public ConnectionMode Connection { get => default; } // 0x00000001813AE560-0x00000001813AE570 
		public float SameSurfaceAngle { get => default; } // 0x0000000185FB0850-0x0000000185FB0860 
		public bool IsMeshConnection { get => default; } // 0x000000018AA6EE68-0x000000018AA6EE80 
	
		// Nested types
		public enum ConnectionMode // TypeDefIndex: 52319
		{
			Line = 0,
			MeshAutomatic = 1,
			MeshSequentialLoop = 2,
			MeshSequentialNoLoop = 3
		}
	
		// Constructors
		public BoneClothTarget() {} // 0x000000018AA6EDE8-0x000000018AA6EE68
	
		// Methods
		public int GetDataHash() => default; // 0x000000018AA6EAEC-0x000000018AA6EB28
		public Transform GetRoot(int index) => default; // 0x000000018AA6EB7C-0x000000018AA6EBE8
		public int GetRootIndex(Transform root) => default; // 0x000000018AA6EB28-0x000000018AA6EB7C
		public void AddParentTransform() {} // 0x000000018AA6E5F0-0x000000018AA6EA2C
		public void RemoveParentTransform() {} // 0x000000018AA6EC5C-0x000000018AA6ED38
		public void ResetFuturePredictionParentTransform() {} // 0x000000018AA6ED38-0x000000018AA6EDE8
		public void ChangeUnityPhysicsCount(bool sw) {} // 0x000000018AA6EA2C-0x000000018AA6EAEC
		public void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class {}
		public HashSet<Transform> GetUsedBones() => default; // 0x000000018AA6EBE8-0x000000018AA6EC5C
	}

	[Serializable]
	public class ClothData : ShareDataObject // TypeDefIndex: 52329
	{
		// Fields
		private const int DATA_VERSION = 5; // Metadata: 0x0207657B
		public const uint VertexFlag_End = 65536; // Metadata: 0x0207657C
		public const uint VertexFlag_TriangleRotation = 131072; // Metadata: 0x02076580
		public ClothParams.Algorithm triangleBendAlgorithm; // 0x20
		public ClothParams.Algorithm restoreRotationAlgorithm; // 0x24
		public ClothParams.Algorithm clampRotationAlgorithm; // 0x28
		public List<int> useVertexList; // 0x30
		public List<int> selectionData; // 0x38
		public uint maxLevel; // 0x40
		public List<uint> vertexFlagLevelList; // 0x48
		public List<float> vertexDepthList; // 0x50
		public List<int> rootList; // 0x58
		public List<int> parentList; // 0x60
		public RestoreDistanceConstraint.RestoreDistanceData[] structDistanceDataList; // 0x68
		public ReferenceDataIndex[] structDistanceReferenceList; // 0x70
		public RestoreDistanceConstraint.RestoreDistanceData[] bendDistanceDataList; // 0x78
		public ReferenceDataIndex[] bendDistanceReferenceList; // 0x80
		public RestoreDistanceConstraint.RestoreDistanceData[] nearDistanceDataList; // 0x88
		public ReferenceDataIndex[] nearDistanceReferenceList; // 0x90
		public ClampDistanceConstraint.ClampDistanceData[] rootDistanceDataList; // 0x98
		public ReferenceDataIndex[] rootDistanceReferenceList; // 0xA0
		public ClampDistance2Constraint.ClampDistance2Data[] clampDistance2DataList; // 0xA8
		public ClampDistance2Constraint.ClampDistance2RootInfo[] clampDistance2RootInfoList; // 0xB0
		public RestoreRotationConstraint.RotationData[] restoreRotationDataList; // 0xB8
		public ReferenceDataIndex[] restoreRotationReferenceList; // 0xC0
		public ClampRotationConstraint.ClampRotationData[] clampRotationDataList; // 0xC8
		public ClampRotationConstraint.ClampRotationRootInfo[] clampRotationRootInfoList; // 0xD0
		public CompositeRotationConstraint.RotationData[] compositeRotationDataList; // 0xD8
		public CompositeRotationConstraint.RootInfo[] compositeRotationRootInfoList; // 0xE0
		public TwistConstraint.TwistData[] twistDataList; // 0xE8
		public ReferenceDataIndex[] twistReferenceList; // 0xF0
		public AdjustRotationWorker.AdjustRotationData[] adjustRotationDataList; // 0xF8
		public TriangleBendConstraint.TriangleBendData[] triangleBendDataList; // 0x100
		public ReferenceDataIndex[] triangleBendReferenceList; // 0x108
		public int triangleBendWriteBufferCount; // 0x110
		public VolumeConstraint.VolumeData[] volumeDataList; // 0x118
		public ReferenceDataIndex[] volumeReferenceList; // 0x120
		public int volumeWriteBufferCount; // 0x128
		public LineWorker.LineRotationData[] lineRotationDataList; // 0x130
		public LineWorker.LineRotationRootInfo[] lineRotationRootInfoList; // 0x138
		public TriangleWorker.TriangleRotationData[] triangleRotationDataList; // 0x140
		public int[] triangleRotationIndexList; // 0x148
		public EdgeCollisionConstraint.EdgeCollisionData[] edgeCollisionDataList; // 0x150
		public ReferenceDataIndex[] edgeCollisionReferenceList; // 0x158
		public int edgeCollisionWriteBufferCount; // 0x160
		public PenetrationConstraint.PenetrationData[] penetrationDataList; // 0x168
		public ReferenceDataIndex[] penetrationReferenceList; // 0x170
		public float3[] penetrationDirectionDataList; // 0x178
		public ClothParams.PenetrationMode penetrationMode; // 0x180
		public BaseSkinningWorker.BaseSkinningData[] baseSkinningDataList; // 0x188
		public float4x4[] baseSkinningBindPoseList; // 0x190
		public Vector3 initScale; // 0x198
	
		// Properties
		public int VertexUseCount { get => default; } // 0x000000018AA7ACC8-0x000000018AA7ACE0 
		public int StructDistanceConstraintCount { get => default; } // 0x000000018AA7AD74-0x000000018AA7AD8C 
		public int BendDistanceConstraintCount { get => default; } // 0x000000018AA7ACF8-0x000000018AA7AD30 
		public int NearDistanceConstraintCount { get => default; } // 0x000000018AA7AC0C-0x000000018AA7AC24 
		public int ClampDistanceConstraintCount { get => default; } // 0x000000018AA78160-0x000000018AA7819C 
		public int ClampDistance2ConstraintCount { get => default; } // 0x000000018AA787BC-0x000000018AA787F8 
		public int RestoreRotationConstraintCount { get => default; } // 0x000000018AA7A128-0x000000018AA7A180 
		public int ClampRotationConstraintDataCount { get => default; } // 0x000000018AA7A064-0x000000018AA7A0C0 
		public int ClampRotationConstraintRootCount { get => default; } // 0x000000018AA7A190-0x000000018AA7A1EC 
		public int AdjustRotationConstraintCount { get => default; } // 0x000000018AA7A008-0x000000018AA7A064 
		public int CompositeRotationCount { get => default; } // 0x000000018AA7A180-0x000000018AA7A190 
		public int TwistConstraintCount { get => default; } // 0x000000018AA7A0C0-0x000000018AA7A128 
		public int TriangleBendConstraintCount { get => default; } // 0x000000018AA7A760-0x000000018AA7A7E4 
		public int EdgeCollisionConstraintCount { get => default; } // 0x000000018AA7864C-0x000000018AA786A4 
		public int VolumeConstraintCount { get => default; } // 0x0000000181D27740-0x0000000181D27750 
		public int LineRotationWorkerCount { get => default; } // 0x000000018AA7A964-0x000000018AA7AA44 
		public int TriangleRotationWorkerCount { get => default; } // 0x000000018AA77840-0x000000018AA77A88 
		public int PenetrationCount { get => default; } // 0x000000018AA77A88-0x000000018AA78160 
		public int BaseSkinningCount { get => default; } // 0x000000018AA6F5CC-0x000000018AA77840 
	
		// Nested types
		private class RestoreDistanceWork // TypeDefIndex: 52321
		{
			// Fields
			public uint vertexPair; // 0x10
			public float dist; // 0x14
	
			// Constructors
			public RestoreDistanceWork() {} // 0x000000018AA7819C-0x000000018AA7864C
		}
	
		private class PenetrationBone // TypeDefIndex: 52322
		{
			// Fields
			public Transform bone; // 0x10
			public Transform childBone; // 0x18
	
			// Constructors
			public PenetrationBone() {} // 0x000000018AA7ADA4-0x000000018AA7ADE4
		}
	
		private class PenetrationWork // TypeDefIndex: 52323
		{
			// Fields
			public Transform bone; // 0x10
			public Transform childBone; // 0x18
			public int boneIndex; // 0x20
			public float distance; // 0x24
			public float weight; // 0x28
	
			// Constructors
			public PenetrationWork() {} // 0x000000018AA7AD48-0x000000018AA7AD5C
		}
	
		private class VertexInfo // TypeDefIndex: 52324
		{
			// Fields
			public int vertexIndex; // 0x10
			public int parentVertexIndex; // 0x14
			public List<int> childVertexList; // 0x18
			public VertexInfo parentInfo; // 0x20
			public List<VertexInfo> childInfoList; // 0x28
	
			// Constructors
			public VertexInfo() {} // 0x000000018AA7AC24-0x000000018AA7AC38
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 52325
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<RestoreDistanceWork> __9__108_0; // 0x08
			public static Comparison<RestoreDistanceWork> __9__108_1; // 0x10
			public static Comparison<PenetrationConstraint.PenetrationData> __9__108_2; // 0x18
	
			// Constructors
			static __c() {} // 0x000000018AA7ACE0-0x000000018AA7ACF8
			public __c() {} // 0x000000018AA7AC50-0x000000018AA7AC68
	
			// Methods
			internal int _CreateConstraintData_b__108_0(RestoreDistanceWork a, RestoreDistanceWork b) => default; // 0x000000018AA7AC38-0x000000018AA7AC50
			internal int _CreateConstraintData_b__108_1(RestoreDistanceWork a, RestoreDistanceWork b) => default; // 0x000000018AA7AD30-0x000000018AA7AD48
			internal int _CreateConstraintData_b__108_2(PenetrationConstraint.PenetrationData a, PenetrationConstraint.PenetrationData b) => default; // 0x000000018AA7AC68-0x000000018AA7AC80
		}
	
		private sealed class __c__DisplayClass110_0 // TypeDefIndex: 52326
		{
			// Fields
			public List<float> meshVertexDepthList; // 0x10
	
			// Constructors
			public __c__DisplayClass110_0() {} // 0x000000018AA7AC80-0x000000018AA7AC98
	
			// Methods
			internal int _SortTetra_b__0(int a, int b) => default; // 0x000000018AA7ABF4-0x000000018AA7AC0C
		}
	
		private sealed class __c__DisplayClass111_0 // TypeDefIndex: 52327
		{
			// Fields
			public List<float> meshVertexDepthList; // 0x10
	
			// Constructors
			public __c__DisplayClass111_0() {} // 0x000000018AA7AC98-0x000000018AA7ACB0
	
			// Methods
			internal int _CheckTetraDirection_b__0(ulong a, ulong b) => default; // 0x000000018AA7AD8C-0x000000018AA7ADA4
		}
	
		private sealed class __c__DisplayClass114_0 // TypeDefIndex: 52328
		{
			// Fields
			public List<float> depthList; // 0x10
			public List<float> nearFixedDistList; // 0x18
	
			// Constructors
			public __c__DisplayClass114_0() {} // 0x000000018AA7AD5C-0x000000018AA7AD74
	
			// Methods
			internal int _GetUseParentVertexList_b__0(int a, int b) => default; // 0x000000018AA7ACB0-0x000000018AA7ACC8
		}
	
		// Constructors
		public ClothData() {} // 0x000000018AA80F88-0x000000018AA81094
	
		// Methods
		public override int GetDataHash() => default; // 0x000000018AA7ADE4-0x000000018AA7ADFC
		public int GetClampRotationCount() => default; // 0x000000018AA7A1EC-0x000000018AA7A760
		public int GetRestoreRotationCount() => default; // 0x000000018AA7A7E4-0x000000018AA7A964
		public bool IsInvalidVertex(int vindex) => default; // 0x000000018AA6F188-0x000000018AA6F5CC
		public bool IsFixedVertex(int vindex) => default; // 0x000000018AA6EEC0-0x000000018AA6F188
		public bool IsMoveVertex(int vindex) => default; // 0x000000018AA786A4-0x000000018AA787BC
		public bool IsExtendVertex(int vindex) => default; // 0x000000018AA787F8-0x000000018AA79828
		public bool IsLastLevel(int vindex) => default; // 0x000000018AA79D28-0x000000018AA79E24
		public bool IsFlag(int vindex, uint flag) => default; // 0x000000018AA79E24-0x000000018AA7A008
		public void SetFlag(int vindex, uint flag) {} // 0x000000018AA79828-0x000000018AA79D28
		public int GetLevel(int vindex) => default; // 0x000000018AA7AA44-0x000000018AA7ABF4
		public override int GetVersion() => default; // 0x0000000185492010-0x0000000185492020
		public override Define.Error VerifyData() => default; // 0x0000000185492010-0x0000000185492020
		public void CreateData(PhysicsTeam team, ClothParams clothParams, PhysicsTeamData teamData, MeshData meshData, IEditorMesh editMesh, List<int> selData, Action<List<int>, List<int>, List<Vector3>, List<Vector3>, List<Vector3>, List<int>, List<int>> extensionAction = null) {} // 0x0000000185492010-0x0000000185492020
		private void CreateVertexData(int vertexCount, List<int> lineList, List<int> triangleList) {} // 0x000000018AA8118C-0x000000018AA81250
		private void CreateConstraintData(PhysicsTeam team, ClothParams clothParams, PhysicsTeamData teamData, int vertexCount, List<Vector3> wposList, List<Vector3> wnorList, List<Vector3> wtanList, List<int> lineList, List<int> triangleList) {} // 0x000000018AA81128-0x000000018AA8118C
		private void RegistTriangleBend(int v0, int v1, int v2, int v3, List<Vector3> wposList, ClothParams clothParams, List<TriangleBendConstraint.TriangleBendData> triangleBendData) {} // 0x0000000185492010-0x0000000185492020
		private List<int> SortTetra(int v0, int v1, int v2, int v3, List<float> meshVertexDepthList) => default; // 0x000000018AA80CAC-0x000000018AA80CDC
		private List<int> CheckTetraDirection(int v0, int v1, int v2, int v3, HashSet<ulong> trianglePackSet, List<float> meshVertexDepthList) => default; // 0x000000018AA80CAC-0x000000018AA80CDC
		private bool CalcTriangleBendRestAngle(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, out float restAngle) {
			restAngle = default;
			return default;
		} // 0x000000018AA80CDC-0x000000018AA80CF4
		private List<float> GetMeshVertexDepthList(int vertexCount, List<float> depthList) => default; // 0x0000000185492010-0x0000000185492020
		private List<int> GetUseParentVertexList(int vertexCount, List<HashSet<int>> vlink, List<Vector3> wposList, List<float> depthList) => default; // 0x000000018AA80D40-0x000000018AA80DDC
		private List<int> GetUseRootVertexList(List<int> parentVertexList) => default; // 0x0000000185492010-0x0000000185492020
		private List<VertexInfo> GetUseVertexInfoList(List<int> parentVertexList) => default; // 0x000000018AA80DDC-0x000000018AA80F88
		private List<List<int>> GetUseRootLineList(List<int> parentVertexList) => default; // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class ClothParams // TypeDefIndex: 52336
	{
		// Fields
		private Algorithm algorithm; // 0x10
		private BezierParam radius; // 0x18
		private BezierParam mass; // 0x20
		private bool useGravity; // 0x28
		private BezierParam gravity; // 0x30
		private Vector3 gravityDirection; // 0x38
		private bool useDrag; // 0x44
		private BezierParam drag; // 0x48
		private bool useMaxVelocity; // 0x50
		private BezierParam maxVelocity; // 0x58
		private Transform influenceTarget; // 0x60
		private float maxMoveSpeed; // 0x68
		private float maxRotationSpeed; // 0x6C
		private BezierParam worldMoveInfluence; // 0x70
		private BezierParam worldRotationInfluence; // 0x78
		private float massInfluence; // 0x80
		private BezierParam depthInfluence; // 0x88
		private float windInfluence; // 0x90
		private float windRandomScale; // 0x94
		private float windSynchronization; // 0x98
		private bool useDistanceDisable; // 0x9C
		private Transform disableReferenceObject; // 0xA0
		private float disableDistance; // 0xA8
		private float disableFadeDistance; // 0xAC
		private bool useResetTeleport; // 0xB0
		private float teleportDistance; // 0xB4
		private float teleportRotation; // 0xB8
		private TeleportMode teleportMode; // 0xBC
		private float resetStabilizationTime; // 0xC0
		private bool useClampDistanceRatio; // 0xC4
		private float clampDistanceMinRatio; // 0xC8
		private float clampDistanceMaxRatio; // 0xCC
		private float clampDistanceVelocityInfluence; // 0xD0
		private bool useClampPositionLength; // 0xD4
		private BezierParam clampPositionLength; // 0xD8
		private float clampPositionRatioX; // 0xE0
		private float clampPositionRatioY; // 0xE4
		private float clampPositionRatioZ; // 0xE8
		private float clampPositionVelocityInfluence; // 0xEC
		private bool useClampRotation; // 0xF0
		private BezierParam clampRotationAngle; // 0xF8
		private BezierParam clampRotationAngle2; // 0x100
		private float clampRotationVelocityLimit; // 0x108
		private float clampRotationVelocityInfluence; // 0x10C
		private float restoreDistanceVelocityInfluence; // 0x110
		private BezierParam structDistanceStiffness; // 0x118
		private bool useBendDistance; // 0x120
		private int bendDistanceMaxCount; // 0x124
		private BezierParam bendDistanceStiffness; // 0x128
		private bool useNearDistance; // 0x130
		private int nearDistanceMaxCount; // 0x134
		private float nearDistanceMaxDepth; // 0x138
		private BezierParam nearDistanceLength; // 0x140
		private BezierParam nearDistanceStiffness; // 0x148
		private bool useRestoreRotation; // 0x150
		private BezierParam restoreRotation; // 0x158
		private BezierParam restoreRotation2; // 0x160
		private float restoreRotationVelocityInfluence; // 0x168
		private float restoreRotationVelocityInfluence2; // 0x16C
		private bool useSpring; // 0x170
		private float springPower; // 0x174
		private float springRadius; // 0x178
		private float springScaleX; // 0x17C
		private float springScaleY; // 0x180
		private float springScaleZ; // 0x184
		private float springIntensity; // 0x188
		private BezierParam springDirectionAtten; // 0x190
		private BezierParam springDistanceAtten; // 0x198
		private AdjustMode adjustMode; // 0x1A0
		private float adjustRotationPower; // 0x1A4
		private bool useTriangleBend; // 0x1A8
		private BezierParam triangleBend; // 0x1B0
		private BezierParam triangleBend2; // 0x1B8
		private bool useTwistCorrection; // 0x1C0
		private float twistRecoveryPower; // 0x1C4
		private bool useVolume; // 0x1C8
		private float maxVolumeLength; // 0x1CC
		private BezierParam volumeStretchStiffness; // 0x1D0
		private BezierParam volumeShearStiffness; // 0x1D8
		private bool useCollision; // 0x1E0
		private float friction; // 0x1E4
		private float staticFriction; // 0x1E8
		private bool usePenetration; // 0x1EC
		private PenetrationMode penetrationMode; // 0x1F0
		private PenetrationAxis penetrationAxis; // 0x1F4
		private float penetrationMaxDepth; // 0x1F8
		private BezierParam penetrationConnectDistance; // 0x200
		private BezierParam penetrationDistance; // 0x208
		private BezierParam penetrationRadius; // 0x210
		private bool useLineAvarageRotation; // 0x218
		private bool useFixedNonRotation; // 0x219
		private HashSet<ParamType> changeSet; // 0x220
	
		// Properties
		public Algorithm AlgorithmType { get => default; set {} } // 0x0000000181C0BBD0-0x0000000181C0BBE0 0x0000000181378230-0x0000000181378240
		public bool UseGravity { get => default; } // 0x00000001813B31B0-0x00000001813B31C0 
		public Vector3 GravityDirection { get => default; set {} } // 0x0000000185FCA320-0x0000000185FCA340 0x0000000185FC9A60-0x0000000185FC9A70
		public bool UseDrag { get => default; } // 0x0000000185FB08A0-0x0000000185FB08B0 
		public bool UseMaxVelocity { get => default; } // 0x00000001813ECBE0-0x00000001813ECBF0 
		public float MassInfluence { get => default; set {} } // 0x0000000185FB2E70-0x0000000185FB2E80 0x0000000185FB8BD0-0x0000000185FB8BE0
		public float WindInfluence { get => default; set {} } // 0x0000000185FB9D70-0x0000000185FB9D80 0x0000000185FBB8B0-0x0000000185FBB8C0
		public float WindRandomScale { get => default; set {} } // 0x0000000185FBA420-0x0000000185FBA430 0x0000000185FBA6A0-0x0000000185FBA6B0
		public float WindSynchronization { get => default; set {} } // 0x0000000181B74C40-0x0000000181B74C50 0x0000000185FB9580-0x0000000185FB9590
		public float MaxMoveSpeed { get => default; set {} } // 0x0000000185FB8230-0x0000000185FB8240 0x0000000185FBA690-0x0000000185FBA6A0
		public float MaxRotationSpeed { get => default; set {} } // 0x0000000185FB8A10-0x0000000185FB8A20 0x0000000185FBCAD0-0x0000000185FBCAE0
		public bool UseResetTeleport { get => default; set {} } // 0x0000000181B10450-0x0000000181B10460 0x0000000181B10460-0x0000000181B10470
		public float TeleportDistance { get => default; set {} } // 0x0000000185FB9BA0-0x0000000185FB9BB0 0x0000000185FBE100-0x0000000185FBE110
		public float TeleportRotation { get => default; set {} } // 0x0000000185FBAC60-0x0000000185FBAC70 0x0000000185FB1D90-0x0000000185FB1DA0
		public TeleportMode TeleportResetMode { get => default; set {} } // 0x0000000185FBEB50-0x0000000185FBEB60 0x0000000185FCEB90-0x0000000185FCEBA0
		public float ResetStabilizationTime { get => default; set {} } // 0x0000000185FBECC0-0x0000000185FBECD0 0x0000000185FBECF0-0x0000000185FBED00
		public bool UseDistanceDisable { get => default; set {} } // 0x0000000185FBF7D0-0x0000000185FBF7E0 0x0000000185FBF810-0x0000000185FBF820
		public Transform DisableReferenceObject { get => default; set {} } // 0x0000000185FB0520-0x0000000185FB0530 0x000000018646EBCC-0x000000018646EBE0
		public float DisableDistance { get => default; set {} } // 0x0000000185FB9D40-0x0000000185FB9D50 0x0000000185FCEB60-0x0000000185FCEB70
		public float DisableFadeDistance { get => default; set {} } // 0x0000000185FB9BB0-0x0000000185FB9BC0 0x0000000185FCEB70-0x0000000185FCEB80
		public bool UseClampDistanceRatio { get => default; } // 0x0000000185FB99D0-0x0000000185FB99E0 
		public float ClampDistanceMinRatio { get => default; } // 0x000000018AA7C4B4-0x000000018AA7C4CC 
		public float ClampDistanceMaxRatio { get => default; } // 0x000000018AA7C49C-0x000000018AA7C4B4 
		public float ClampDistanceVelocityInfluence { get => default; } // 0x000000018AA7C4CC-0x000000018AA7C4E8 
		public bool UseClampPositionLength { get => default; } // 0x0000000185FBC890-0x0000000185FBC8A0 
		public Vector3 ClampPositionAxisRatio { get => default; } // 0x0000000185FCEB00-0x0000000185FCEB20 
		public float ClampPositionVelocityInfluence { get => default; } // 0x000000018AA7C4E8-0x000000018AA7C504 
		public bool UseClampRotation { get => default; } // 0x0000000185FB9520-0x0000000185FB9530 
		public float ClampRotationVelocityInfluence { get => default; } // 0x000000018AA7C504-0x000000018AA7C520 
		public float RestoreDistanceVelocityInfluence { get => default; } // 0x0000000185FB8BF0-0x0000000185FB8C00 
		public bool UseBendDistance { get => default; } // 0x0000000185FB9310-0x0000000185FB9320 
		public int BendDistanceMaxCount { get => default; } // 0x0000000185FCEAF0-0x0000000185FCEB00 
		public bool UseNearDistance { get => default; } // 0x0000000185FB9330-0x0000000185FB9340 
		public int NearDistanceMaxCount { get => default; } // 0x0000000185FB11A0-0x0000000185FB11B0 
		public float NearDistanceMaxDepth { get => default; } // 0x0000000185FB8E20-0x0000000185FB8E30 
		public bool UseRestoreRotation { get => default; } // 0x0000000185FB8290-0x0000000185FB82A0 
		public bool UseSpring { get => default; set {} } // 0x0000000185FB9420-0x0000000185FB9430 0x0000000185FCEBB0-0x0000000185FCEBC0
		public float SpringPowr { get => default; set {} } // 0x0000000185FB94B0-0x0000000185FB94C0 0x0000000185FCEB80-0x0000000185FCEB90
		public float SpringRadius { get => default; } // 0x0000000185FB8E60-0x0000000185FB8E70 
		public Vector3 SpringRadiusScale { get => default; } // 0x0000000185FCEB20-0x0000000185FCEB40 
		public float SpringIntensity { get => default; } // 0x0000000181B2AFC0-0x0000000181B2AFD0 
		public AdjustMode AdjustRotationMode { get => default; } // 0x0000000185FB9EC0-0x0000000185FB9ED0 
		public Vector3 AdjustRotationVector { get => default; } // 0x000000018AA7C448-0x000000018AA7C49C 
		public bool UseTriangleBend { get => default; } // 0x0000000185FBA410-0x0000000185FBA420 
		internal float TwistRecoveryPower { get => default; } // 0x0000000185FB91C0-0x0000000185FB91D0 
		public bool UseVolume { get => default; } // 0x0000000185FB9440-0x0000000185FB9450 
		public bool UseCollision { get => default; } // 0x0000000185FBA3A0-0x0000000185FBA3B0 
		public float DynamicFriction { get => default; } // 0x0000000185FBA270-0x0000000185FBA280 
		public float StaticFriction { get => default; } // 0x0000000185FBAC30-0x0000000185FBAC40 
		public bool UsePenetration { get => default; set {} } // 0x0000000185FCEB50-0x0000000185FCEB60 0x0000000185FCEBA0-0x0000000185FCEBB0
		public float PenetrationMaxDepth { get => default; } // 0x0000000185FBA250-0x0000000185FBA260 
		public bool UseLineAvarageRotation { get => default; } // 0x0000000185FB9300-0x0000000185FB9310 
		public bool UseFixedNonRotation { get => default; } // 0x0000000185FCEB40-0x0000000185FCEB50 
	
		// Nested types
		public enum Algorithm // TypeDefIndex: 52330
		{
			Algorithm_1 = 0,
			Algorithm_2 = 1
		}
	
		public enum TeleportMode // TypeDefIndex: 52331
		{
			Reset = 0,
			Keep = 1
		}
	
		public enum AdjustMode // TypeDefIndex: 52332
		{
			Fixed = 0,
			XYMove = 1,
			XZMove = 2,
			YZMove = 3
		}
	
		public enum PenetrationMode // TypeDefIndex: 52333
		{
			SurfacePenetration = 0,
			ColliderPenetration = 1
		}
	
		public enum PenetrationAxis // TypeDefIndex: 52334
		{
			X = 0,
			Y = 1,
			Z = 2,
			InverseX = 3,
			InverseY = 4,
			InverseZ = 5
		}
	
		public enum ParamType // TypeDefIndex: 52335
		{
			Radius = 0,
			Mass = 1,
			Gravity = 2,
			Drag = 3,
			MaxVelocity = 4,
			WorldInfluence = 5,
			ClampDistance = 6,
			ClampPosition = 7,
			ClampRotation = 8,
			RestoreDistance = 9,
			RestoreRotation = 10,
			Spring = 11,
			AdjustRotation = 12,
			AirLine = 13,
			TriangleBend = 14,
			Volume = 15,
			ColliderCollision = 16,
			RotationInterpolation = 17,
			DistanceDisable = 18,
			ExternalForce = 19,
			Penetration = 20,
			Algorithm = 21,
			BaseSkinning = 22,
			Max = 23
		}
	
		// Constructors
		public ClothParams() {} // 0x000000018AA7BC34-0x000000018AA7C448
	
		// Methods
		public void SetChangeParam(ParamType ptype) {} // 0x000000018AA7B79C-0x000000018AA7B7F4
		public bool ChangedParam(ParamType ptype) => default; // 0x000000018AA7ADFC-0x000000018AA7AE54
		public void ClearChangeParam() {} // 0x000000018AA7AE54-0x000000018AA7AE9C
		public int GetParamHash(BaseCloth cloth, ParamType ptype) => default; // 0x000000018AA7B0B4-0x000000018AA7B6C4
		public void SetRadius(float sval, float eval) {} // 0x000000018AA7B9E0-0x000000018AA7BA14
		public float GetRadius(float depth) => default; // 0x000000018AA7B6C4-0x000000018AA7B6E4
		public BezierParam GetRadius() => default; // 0x0000000181377E40-0x0000000181377E50
		public void SetMass(float sval, float eval, bool useEval = true /* Metadata: 0x02076584 */, float cval = 0f /* Metadata: 0x02076585 */, bool useCval = false /* Metadata: 0x02076589 */) {} // 0x000000018AA7B970-0x000000018AA7B9AC
		public BezierParam GetMass() => default; // 0x00000001813B31A0-0x00000001813B31B0
		public void SetGravity(bool sw, float sval = -9.8f /* Metadata: 0x0207658A */, float eval = -9.8f /* Metadata: 0x0207658E */) {} // 0x000000018AA7B93C-0x000000018AA7B970
		public BezierParam GetGravity() => default; // 0x000000018AA7AFD0-0x000000018AA7B034
		public void SetDrag(bool sw, float sval = 0.015f /* Metadata: 0x02076592 */, float eval = 0.015f /* Metadata: 0x02076596 */) {} // 0x000000018AA7B908-0x000000018AA7B93C
		public BezierParam GetDrag() => default; // 0x000000018AA7AF6C-0x000000018AA7AFD0
		public void SetMaxVelocity(bool sw, float sval = 3f /* Metadata: 0x0207659A */, float eval = 3f /* Metadata: 0x0207659E */) {} // 0x000000018AA7B9AC-0x000000018AA7B9E0
		public BezierParam GetMaxVelocity() => default; // 0x000000018AA7B034-0x000000018AA7B09C
		public void SetExternalForce(float massInfluence, float windInfluence, float windRandomScale, float windSynchronization) {} // 0x0000000185FCEA40-0x0000000185FCEA70
		public BezierParam GetDepthInfluence() => default; // 0x0000000185FB0510-0x0000000185FB0520
		public void SetWorldInfluence(float maxspeed, float moveval, float rotval) {} // 0x000000018AA7BBE4-0x000000018AA7BC34
		public BezierParam GetWorldMoveInfluence() => default; // 0x0000000181460F70-0x0000000181460F80
		public BezierParam GetWorldRotationInfluence() => default; // 0x0000000183060C50-0x0000000183060C60
		public Transform GetInfluenceTarget() => default; // 0x0000000185FB0530-0x0000000185FB0540
		public void SetInfluenceTarget(Transform t) {} // 0x0000000185AE8FE0-0x0000000185AE8FF0
		public void SetTeleport(bool sw, float distance = 0.2f /* Metadata: 0x020765A2 */, float rotation = 45f /* Metadata: 0x020765A6 */, TeleportMode mode = TeleportMode.Reset /* Metadata: 0x020765AA */) {} // 0x0000000185FCEAC0-0x0000000185FCEAF0
		public void SetDistanceDisable(bool sw, float distance = 20f /* Metadata: 0x020765AB */, float fadeDistance = 5f /* Metadata: 0x020765AF */, Transform referenceObject = null) {} // 0x000000018AA7B8CC-0x000000018AA7B908
		public void SetClampDistanceRatio(bool sw, float minval = 0.1f /* Metadata: 0x020765B3 */, float maxval = 1.05f /* Metadata: 0x020765B7 */, float influence = 0.2f /* Metadata: 0x020765BB */) {} // 0x0000000185FCE9F0-0x0000000185FCEA20
		public void SetClampPositionLength(bool sw, float sval = 0.03f /* Metadata: 0x020765BF */, float eval = 0.2f /* Metadata: 0x020765C3 */, float ratioX = 1f /* Metadata: 0x020765C7 */, float ratioY = 1f /* Metadata: 0x020765CB */, float ratioZ = 1f /* Metadata: 0x020765CF */, float influence = 0.2f /* Metadata: 0x020765D3 */) {} // 0x000000018AA7B7F4-0x000000018AA7B864
		public BezierParam GetClampPositionLength() => default; // 0x0000000185FB02F0-0x0000000185FB0300
		public void SetClampRotationAngle(bool sw, float sval = 0f /* Metadata: 0x020765D7 */, float eval = 180f /* Metadata: 0x020765DB */, float influence = 0.2f /* Metadata: 0x020765DF */) {} // 0x000000018AA7B864-0x000000018AA7B8CC
		public BezierParam GetClampRotationAngle(Algorithm algo) => default; // 0x000000018AA7AF30-0x000000018AA7AF48
		public float GetClampRotationVelocityLimit(Algorithm algo) => default; // 0x000000018AA7AF48-0x000000018AA7AF6C
		public void SetRestoreDistance(float influence = 1f /* Metadata: 0x020765E3 */, float structStiffness = 1f /* Metadata: 0x020765E7 */) {} // 0x000000018AA7BA14-0x000000018AA7BA50
		public BezierParam GetStructDistanceStiffness() => default; // 0x0000000185FB8540-0x0000000185FB8550
		public BezierParam GetBendDistanceStiffness() => default; // 0x0000000185FB8550-0x0000000185FB8560
		public BezierParam GetNearDistanceLength() => default; // 0x0000000185FB85F0-0x0000000185FB8600
		public BezierParam GetNearDistanceStiffness() => default; // 0x0000000185FB8610-0x0000000185FB8620
		public void SetRestoreRotation(bool sw, float sval = 0.02f /* Metadata: 0x020765EB */, float eval = 0.001f /* Metadata: 0x020765EF */, float influence = 0.3f /* Metadata: 0x020765F3 */) {} // 0x000000018AA7BA50-0x000000018AA7BAC0
		public BezierParam GetRestoreRotationPower(Algorithm algo) => default; // 0x000000018AA7B6E4-0x000000018AA7B6FC
		public float GetRestoreRotationVelocityInfluence(Algorithm algo) => default; // 0x000000018AA7B6FC-0x000000018AA7B714
		public void SetSpring(bool sw, float power = 0f /* Metadata: 0x020765F7 */, float r = 0f /* Metadata: 0x020765FB */, float sclx = 1f /* Metadata: 0x020765FF */, float scly = 1f /* Metadata: 0x02076603 */, float sclz = 1f /* Metadata: 0x02076607 */, float intensity = 1f /* Metadata: 0x0207660B */) {} // 0x0000000185FCEA70-0x0000000185FCEAC0
		public void SetSpringDirectionAtten(float sval, float eval, float cval) {} // 0x000000018AA7BAC0-0x000000018AA7BAF4
		public void SetSpringDistanceAtten(float sval, float eval, float cval) {} // 0x000000018AA7BAF4-0x000000018AA7BB28
		public float GetSpringPower() => default; // 0x000000018AA7B75C-0x000000018AA7B774
		public float GetSpringDirectionAtten(float ratio) => default; // 0x000000018AA7B714-0x000000018AA7B738
		public float GetSpringDistanceAtten(float ratio) => default; // 0x000000018AA7B738-0x000000018AA7B75C
		public void SetAdjustRotation(AdjustMode amode = AdjustMode.Fixed /* Metadata: 0x0207660F */, float power = 0f /* Metadata: 0x02076610 */) {} // 0x0000000185FCE9E0-0x0000000185FCE9F0
		public void SetTriangleBend(bool sw, float sval = 1f /* Metadata: 0x02076614 */, float eval = 1f /* Metadata: 0x02076618 */) {} // 0x000000018AA7BB28-0x000000018AA7BB80
		public BezierParam GetTriangleBendStiffness(Algorithm algo) => default; // 0x000000018AA7B774-0x000000018AA7B78C
		internal bool GetUseTwistCorrection(Algorithm algo) => default; // 0x000000018AA7B78C-0x000000018AA7B79C
		public void SetVolume(bool sw, float maxLength = 0.05f /* Metadata: 0x0207661C */, float stiffness = 0.5f /* Metadata: 0x02076620 */, float shear = 0.5f /* Metadata: 0x02076624 */) {} // 0x000000018AA7BB80-0x000000018AA7BBE4
		public float GetMaxVolumeLength() => default; // 0x000000018AA7B09C-0x000000018AA7B0B4
		public BezierParam GetVolumeStretchStiffness() => default; // 0x0000000185FB8030-0x0000000185FB8040
		public BezierParam GetVolumeShearStiffness() => default; // 0x0000000185FB1760-0x0000000185FB1770
		public void SetCollision(bool sw, float dynamicFriction = 0.1f /* Metadata: 0x02076628 */, float staticFriction = 0.03f /* Metadata: 0x0207662C */) {} // 0x0000000185FCEA20-0x0000000185FCEA40
		public PenetrationMode GetPenetrationMode() => default; // 0x0000000185FCDDA0-0x0000000185FCDDB0
		public PenetrationAxis GetPenetrationAxis() => default; // 0x0000000185FCE9D0-0x0000000185FCE9E0
		public BezierParam GetPenetrationConnectDistance() => default; // 0x0000000185FB85D0-0x0000000185FB85E0
		public BezierParam GetPenetrationRadius() => default; // 0x0000000185FB83A0-0x0000000185FB83B0
		public BezierParam GetPenetrationDistance() => default; // 0x0000000185FB84F0-0x0000000185FB8500
		public void ConvertToLatestAlgorithmParameter() {} // 0x000000018AA7AE9C-0x000000018AA7AF30
	}

	public class ClothSetup // TypeDefIndex: 52338
	{
		// Fields
		private int teamBoneIndex; // 0x10
		private float distanceBlendRatio; // 0x14
	
		// Properties
		public float DistanceBlendRatio { get => default; set {} } // 0x0000000185492010-0x0000000185492020 0x000000018AA93264-0x000000018AA93324
	
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 52337
		{
			// Fields
			public ClothData clothData; // 0x10
			public Func<int, uint> funcUserFlag; // 0x18
			public ClothParams param; // 0x20
	
			// Constructors
			public __c__DisplayClass2_0() {} // 0x000000018AA83734-0x000000018AA85734
	
			// Methods
			internal uint _ClothInit_b__0(int i) => default; // 0x000000018AA83598-0x000000018AA83624
			internal float _ClothInit_b__1(int i) => default; // 0x000000018AA83448-0x000000018AA83598
			internal float3 _ClothInit_b__2(int i) => default; // 0x000000018AA83624-0x000000018AA83734
		}
	
		// Constructors
		public ClothSetup() {} // 0x000000018AA93380-0x000000018AA93410
	
		// Methods
		public void ClothInit(PhysicsTeam team, MeshData meshData, ClothData clothData, ClothParams param, Func<int, uint> funcUserFlag) {}
		public void ClothDispose(PhysicsTeam team) {} // 0x000000018AA85734-0x000000018AA857C4
		public void ClothActive(PhysicsTeam team, ClothParams param, ClothData clothData) {} // 0x000000018AA833DC-0x000000018AA83448
		public void ClothInactive(PhysicsTeam team) {} // 0x0000000185FB2D80-0x0000000185FB2D90
		internal void ReplaceBone<T>(PhysicsTeam team, ClothParams param, Dictionary<T, Transform> boneReplaceDict)
			where T : class {} // 0x0000000181A6E390-0x0000000181A6FA00
		internal HashSet<Transform> GetUsedBones(PhysicsTeam team, ClothParams param) => default; // 0x000000018AA827C4-0x000000018AA833DC
		public void ChangeUseUnityPhysics(bool sw) {} // 0x0000000185FCEC30-0x0000000185FCEC40
		public void ChangeData(PhysicsTeam team, ClothParams param, ClothData clothData) {} // 0x000000018AA93324-0x000000018AA93380
	}

	public class MagicaBoneCloth : BaseCloth // TypeDefIndex: 52339
	{
		// Fields
		private const int DATA_VERSION = 7; // Metadata: 0x02076658
		private const int ERR_DATA_VERSION = 3; // Metadata: 0x02076659
		private MeshData meshData; // 0xC8
		private int meshDataHash; // 0xD0
		private int meshDataVersion; // 0xD4
		private BoneClothTarget clothTarget; // 0xD8
		private List<Transform> useTransformList; // 0xE0
		private List<Vector3> useTransformPositionList; // 0xE8
		private List<Quaternion> useTransformRotationList; // 0xF0
		private List<Vector3> useTransformScaleList; // 0xF8
	
		// Properties
		public BoneClothTarget ClothTarget { get => default; } // 0x0000000185FB02F0-0x0000000185FB0300 
		public MeshData MeshData { get => default; } // 0x0000000185FB0300-0x0000000185FB0310 
		private int UseTransformCount { get => default; } // 0x000000018AA88694-0x000000018AA886D4 
	
		// Constructors
		public MagicaBoneCloth() {} // 0x000000018AA884F4-0x000000018AA88694
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000185FBBF90-0x0000000185FBBFA0
		public override int GetDataHash() => default; // 0x000000018AA8606C-0x000000018AA86188
		protected override void Reset() {} // 0x000000018AA88084-0x000000018AA8808C
		protected override void OnValidate() {} // 0x000000018AA87D18-0x000000018AA87D20
		protected override void ClothInit() {} // 0x000000018AA85EB0-0x000000018AA85EE4
		protected override void ClothDispose() {} // 0x000000018AA85E8C-0x000000018AA85EB0
		protected override void ClothActive() {} // 0x000000018AA85E84-0x000000018AA85E8C
		protected override uint UserFlag(int index) => default; // 0x000000018AA8808C-0x000000018AA880C0
		protected override Transform UserTransform(int index) => default; // 0x000000018AA88250-0x000000018AA88258
		protected override float3 UserTransformLocalPosition(int vindex) => default; // 0x000000018AA880C0-0x000000018AA88190
		protected override quaternion UserTransformLocalRotation(int vindex) => default; // 0x000000018AA88190-0x000000018AA88250
		public override BaseMeshDeformer GetDeformer() => default; // 0x00000001813AE580-0x00000001813AE590
		protected override MeshData GetMeshData() => default; // 0x0000000185FB0300-0x0000000185FB0310
		protected override void WorkerInit() {} // 0x0000000185492010-0x0000000185492020
		public override bool IsRequiresDeformer() => default; // 0x00000001814A81B0-0x00000001814A81C0
		protected override void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer) {} // 0x0000000185492010-0x0000000185492020
		protected override void ChangeUseUnityPhysics(bool sw) {} // 0x000000018AA85E3C-0x000000018AA85E84
		protected override void OnChangeCalculation() {} // 0x000000018AA87C10-0x000000018AA87D18
		public List<Transform> GetTransformList() => default; // 0x000000018AA87800-0x000000018AA87B00
		private Transform GetUseTransform(int index) => default; // 0x000000018AA87B00-0x000000018AA87B84
		public List<List<List<Transform>>> GetTransformGrid(out int maxLevel) {
			maxLevel = default;
			return default;
		} // 0x000000018AA8745C-0x000000018AA87800
		public override int GetVersion() => default; // 0x0000000181B9FE80-0x0000000181B9FE90
		public override int GetErrorVersion() => default; // 0x0000000181D1CE70-0x0000000181D1CE80
		public override void CreateVerifyData() {} // 0x000000018AA85EE4-0x000000018AA85F2C
		public override Define.Error VerifyData() => default; // 0x000000018AA88258-0x000000018AA884F4
		public override string GetInformation() => default; // 0x000000018AA866D8-0x000000018AA873B8
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict) {}
		public override HashSet<Transform> GetUsedBones() => default; // 0x000000018AA87B84-0x000000018AA87C10
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x000000018AA86268-0x000000018AA865F8
		public override List<int> GetEditorTriangleList() => default; // 0x000000018AA865F8-0x000000018AA866D8
		public override List<int> GetEditorLineList() => default; // 0x000000018AA86188-0x000000018AA86268
		public override List<int> GetSelectionList() => default; // 0x000000018AA873B8-0x000000018AA8745C
		public override List<int> GetUseList() => default; // 0x00000001813AE580-0x00000001813AE590
		public override List<ShareDataObject> GetAllShareDataObject() => default; // 0x000000018AA86004-0x000000018AA8606C
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source) => default; // 0x000000018AA85F2C-0x000000018AA86004
		private void ResetParams() {} // 0x000000018AA87D20-0x000000018AA88084
	}

	public class MagicaBoneSpring : BaseCloth // TypeDefIndex: 52340
	{
		// Fields
		private const int DATA_VERSION = 7; // Metadata: 0x0207665A
		private const int ERR_DATA_VERSION = 3; // Metadata: 0x0207665B
		private MeshData meshData; // 0xC8
		private int meshDataHash; // 0xD0
		private int meshDataVersion; // 0xD4
		private BoneClothTarget clothTarget; // 0xD8
		private List<Transform> useTransformList; // 0xE0
		private List<Vector3> useTransformPositionList; // 0xE8
		private List<Quaternion> useTransformRotationList; // 0xF0
		private List<Vector3> useTransformScaleList; // 0xF8
	
		// Properties
		public BoneClothTarget ClothTarget { get => default; } // 0x0000000185FB02F0-0x0000000185FB0300 
		public MeshData MeshData { get => default; } // 0x0000000185FB0300-0x0000000185FB0310 
		private int UseTransformCount { get => default; } // 0x000000018AA8A4C8-0x000000018AA8A508 
	
		// Constructors
		public MagicaBoneSpring() {} // 0x000000018AA8A328-0x000000018AA8A4C8
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000185FBC2B0-0x0000000185FBC2C0
		public override int GetDataHash() => default; // 0x000000018AA8889C-0x000000018AA889B8
		protected override void Reset() {} // 0x000000018AA89E68-0x000000018AA89E70
		protected override void OnValidate() {} // 0x000000018AA87D18-0x000000018AA87D20
		protected override void ClothInit() {} // 0x000000018AA886D4-0x000000018AA8875C
		protected override void ClothDispose() {} // 0x000000018AA85E8C-0x000000018AA85EB0
		protected override void ClothActive() {} // 0x000000018AA85E84-0x000000018AA85E8C
		protected override uint UserFlag(int index) => default; // 0x000000018AA8808C-0x000000018AA880C0
		protected override Transform UserTransform(int index) => default; // 0x000000018AA8A000-0x000000018AA8A008
		protected override float3 UserTransformLocalPosition(int vindex) => default; // 0x000000018AA89E70-0x000000018AA89F40
		protected override quaternion UserTransformLocalRotation(int vindex) => default; // 0x000000018AA89F40-0x000000018AA8A000
		public override bool IsRequiresDeformer() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override BaseMeshDeformer GetDeformer() => default; // 0x00000001813AE580-0x00000001813AE590
		protected override MeshData GetMeshData() => default; // 0x0000000185FB0300-0x0000000185FB0310
		protected override void WorkerInit() {} // 0x0000000185492010-0x0000000185492020
		protected override void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer) {} // 0x0000000185492010-0x0000000185492020
		protected override void ChangeUseUnityPhysics(bool sw) {} // 0x000000018AA85E3C-0x000000018AA85E84
		protected override void OnChangeCalculation() {} // 0x000000018AA899F4-0x000000018AA89AFC
		public List<Transform> GetTransformList() => default; // 0x000000018AA895EC-0x000000018AA896FC
		private Transform GetUseTransform(int index) => default; // 0x000000018AA898E4-0x000000018AA89968
		public override int GetVersion() => default; // 0x0000000181B9FE80-0x0000000181B9FE90
		public override int GetErrorVersion() => default; // 0x0000000181D1CE70-0x0000000181D1CE80
		public override void CreateVerifyData() {} // 0x000000018AA85EE4-0x000000018AA85F2C
		public override Define.Error VerifyData() => default; // 0x000000018AA8A008-0x000000018AA8A328
		public override string GetInformation() => default; // 0x000000018AA88F08-0x000000018AA89548
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict) {}
		public override HashSet<Transform> GetUsedBones() => default; // 0x000000018AA89968-0x000000018AA899F4
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x000000018AA88A98-0x000000018AA88E28
		public override List<int> GetEditorTriangleList() => default; // 0x000000018AA88E28-0x000000018AA88F08
		public override List<int> GetEditorLineList() => default; // 0x000000018AA889B8-0x000000018AA88A98
		public override List<int> GetSelectionList() => default; // 0x000000018AA89548-0x000000018AA895EC
		public override List<int> GetUseList() => default; // 0x000000018AA896FC-0x000000018AA898E4
		public override List<ShareDataObject> GetAllShareDataObject() => default; // 0x000000018AA88834-0x000000018AA8889C
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source) => default; // 0x000000018AA8875C-0x000000018AA88834
		private void ResetParams() {} // 0x000000018AA89AFC-0x000000018AA89E68
	}

	public class MagicaMeshCloth : BaseCloth // TypeDefIndex: 52341
	{
		// Fields
		private const int DATA_VERSION = 7; // Metadata: 0x0207665C
		private const int ERR_DATA_VERSION = 3; // Metadata: 0x0207665D
		private MagicaVirtualDeformer virtualDeformer; // 0xC8
		private int virtualDeformerHash; // 0xD0
		private int virtualDeformerVersion; // 0xD4
	
		// Properties
		public VirtualMeshDeformer Deformer { get => default; } // 0x000000018AA8BD60-0x000000018AA8BDD8 
	
		// Constructors
		public MagicaMeshCloth() {} // 0x000000018AA8BD58-0x000000018AA8BD60
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000185FBBD80-0x0000000185FBBD90
		public override int GetDataHash() => default; // 0x000000018AA8A6D4-0x000000018AA8A714
		protected override void Reset() {} // 0x000000018AA8B9DC-0x000000018AA8B9E4
		protected override void OnValidate() {} // 0x000000018AA87D18-0x000000018AA87D20
		protected override void OnInit() {} // 0x000000018AA8B674-0x000000018AA8B67C
		protected override void OnActive() {} // 0x000000018AA8B65C-0x000000018AA8B664
		protected override void OnInactive() {} // 0x000000018AA8B66C-0x000000018AA8B674
		protected override void OnDispose() {} // 0x000000018AA8B664-0x000000018AA8B66C
		protected override uint UserFlag(int index) => default; // 0x00000001813AE580-0x00000001813AE590
		protected override Transform UserTransform(int index) => default; // 0x00000001813AE580-0x00000001813AE590
		protected override float3 UserTransformLocalPosition(int vindex) => default; // 0x0000000185FCEC40-0x0000000185FCEC60
		protected override quaternion UserTransformLocalRotation(int vindex) => default; // 0x000000018AA8BAD0-0x000000018AA8BB14
		public override bool IsRequiresDeformer() => default; // 0x00000001840A27C0-0x00000001840A27D0
		public override BaseMeshDeformer GetDeformer() => default; // 0x000000018AA8A714-0x000000018AA8A71C
		protected override MeshData GetMeshData() => default; // 0x000000018AA8B2BC-0x000000018AA8B2DC
		protected override void WorkerInit() {} // 0x000000018AA8BC00-0x000000018AA8BD58
		protected override void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer) {} // 0x000000018AA8B9E4-0x000000018AA8BAD0
		protected override void ChangeUseUnityPhysics(bool sw) {} // 0x000000018AA8A508-0x000000018AA8A544
		public override int GetVersion() => default; // 0x0000000181B9FE80-0x0000000181B9FE90
		public override int GetErrorVersion() => default; // 0x0000000181D1CE70-0x0000000181D1CE80
		public override void CreateVerifyData() {} // 0x000000018AA85EE4-0x000000018AA85F2C
		public override Define.Error VerifyData() => default; // 0x000000018AA8BB14-0x000000018AA8BC00
		public override string GetInformation() => default; // 0x000000018AA8A7B8-0x000000018AA8B2BC
		public bool IsValidPointSelect() => default; // 0x000000018AA8B5C0-0x000000018AA8B65C
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x000000018AA8A744-0x000000018AA8A790
		public override List<int> GetEditorTriangleList() => default; // 0x000000018AA8A790-0x000000018AA8A7B8
		public override List<int> GetEditorLineList() => default; // 0x000000018AA8A71C-0x000000018AA8A744
		public override List<int> GetSelectionList() => default; // 0x000000018AA8B2DC-0x000000018AA8B3F0
		public override List<int> GetUseList() => default; // 0x000000018AA8B3F0-0x000000018AA8B5C0
		public override List<ShareDataObject> GetAllShareDataObject() => default; // 0x000000018AA8A654-0x000000018AA8A6D4
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source) => default; // 0x000000018AA8A544-0x000000018AA8A654
		private void ResetParams() {} // 0x000000018AA8B67C-0x000000018AA8B9DC
	}

	public class MagicaMeshSpring : BaseCloth // TypeDefIndex: 52343
	{
		// Fields
		private const int DATA_VERSION = 7; // Metadata: 0x0207665E
		private const int ERR_DATA_VERSION = 3; // Metadata: 0x0207665F
		private MagicaVirtualDeformer virtualDeformer; // 0xC8
		private int virtualDeformerHash; // 0xD0
		private int virtualDeformerVersion; // 0xD4
		private Transform centerTransform; // 0xD8
		private Axis directionAxis; // 0xE0
		private SpringData springData; // 0xE8
		private int springDataHash; // 0xF0
		private int springDataVersion; // 0xF4
	
		// Properties
		public VirtualMeshDeformer Deformer { get => default; } // 0x000000018AA8D338-0x000000018AA8D3B0 
		public SpringData SpringData { get => default; } // 0x0000000185FB2360-0x0000000185FB2370 
		public int UseVertexCount { get => default; } // 0x000000018AA8D3B0-0x000000018AA8D428 
		public Transform CenterTransform { get => default; set {} } // 0x0000000185FB02F0-0x0000000185FB0300 0x00000001873368EC-0x0000000187336900
		public Axis DirectionAxis { get => default; set {} } // 0x0000000185FB2390-0x0000000185FB23A0 0x0000000185FB2460-0x0000000185FB2470
		public Vector3 CenterTransformDirection { get => default; } // 0x000000018AA8D1A4-0x000000018AA8D338 
	
		// Nested types
		public enum Axis // TypeDefIndex: 52342
		{
			X = 0,
			Y = 1,
			Z = 2,
			InverseX = 3,
			InverseY = 4,
			InverseZ = 5
		}
	
		// Constructors
		public MagicaMeshSpring() {} // 0x000000018AA8BD58-0x000000018AA8BD60
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000185FCEC60-0x0000000185FCEC70
		public override int GetDataHash() => default; // 0x000000018AA8C164-0x000000018AA8C1E4
		public SpringData.DeformerData GetDeformerData() => default; // 0x000000018AA8C1E4-0x000000018AA8C204
		protected override void Reset() {} // 0x000000018AA8CD58-0x000000018AA8CD60
		protected override void OnValidate() {} // 0x000000018AA87D18-0x000000018AA87D20
		protected override void ClothInit() {} // 0x000000018AA8BDD8-0x000000018AA8BFB4
		protected override void ClothActive() {} // 0x000000018AA85E84-0x000000018AA85E8C
		protected override uint UserFlag(int index) => default; // 0x0000000185FCEC70-0x0000000185FCEC80
		protected override Transform UserTransform(int index) => default; // 0x0000000185FB02F0-0x0000000185FB0300
		protected override float3 UserTransformLocalPosition(int vindex) => default; // 0x000000018AA8CE04-0x000000018AA8CE68
		protected override quaternion UserTransformLocalRotation(int vindex) => default; // 0x000000018AA8CE68-0x000000018AA8CEBC
		public override bool IsRequiresDeformer() => default; // 0x00000001840A27C0-0x00000001840A27D0
		public override BaseMeshDeformer GetDeformer() => default; // 0x000000018AA8C204-0x000000018AA8C278
		protected override MeshData GetMeshData() => default; // 0x00000001813AE580-0x00000001813AE590
		protected override void WorkerInit() {} // 0x000000018AA8D028-0x000000018AA8D1A4
		protected override void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer) {} // 0x000000018AA8CD60-0x000000018AA8CE04
		protected override void ChangeUseUnityPhysics(bool sw) {} // 0x000000018AA8A508-0x000000018AA8A544
		protected override void OnChangeCalculation() {} // 0x000000018AA8C90C-0x000000018AA8C9A0
		public override int GetVersion() => default; // 0x0000000181B9FE80-0x0000000181B9FE90
		public override int GetErrorVersion() => default; // 0x0000000181D1CE70-0x0000000181D1CE80
		public override void CreateVerifyData() {} // 0x000000018AA8BFB4-0x000000018AA8C024
		public override Define.Error VerifyData() => default; // 0x000000018AA8CEBC-0x000000018AA8D028
		public override string GetInformation() => default; // 0x000000018AA8C47C-0x000000018AA8C8A4
		public void VerifyDeformer() {} // 0x0000000185492010-0x0000000185492020
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict) {}
		public override HashSet<Transform> GetUsedBones() => default; // 0x000000018AA8C8A4-0x000000018AA8C90C
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x000000018AA8C278-0x000000018AA8C47C
		public override List<int> GetEditorTriangleList() => default; // 0x00000001813AE580-0x00000001813AE590
		public override List<int> GetEditorLineList() => default; // 0x00000001813AE580-0x00000001813AE590
		public override List<int> GetSelectionList() => default; // 0x00000001813AE580-0x00000001813AE590
		public override List<int> GetUseList() => default; // 0x00000001813AE580-0x00000001813AE590
		public override List<ShareDataObject> GetAllShareDataObject() => default; // 0x000000018AA8C0FC-0x000000018AA8C164
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source) => default; // 0x000000018AA8C024-0x000000018AA8C0FC
		private void ResetParams() {} // 0x000000018AA8C9A0-0x000000018AA8CD58
	}

	[Serializable]
	public class SelectionData : ShareDataObject // TypeDefIndex: 52345
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x02076666
		public const int Invalid = 0; // Metadata: 0x02076667
		public const int Move = 1; // Metadata: 0x02076668
		public const int Fixed = 2; // Metadata: 0x02076669
		public const int Extend = 3; // Metadata: 0x0207666A
		public List<DeformerSelection> selectionList; // 0x20
	
		// Properties
		public int DeformerCount { get => default; } // 0x000000018AA930F4-0x000000018AA9314C 
	
		// Nested types
		[Serializable]
		public class DeformerSelection : IDataHash // TypeDefIndex: 52344
		{
			// Fields
			public List<int> selectData; // 0x10
			public List<ulong> vertexHashList; // 0x18
	
			// Constructors
			public DeformerSelection() {} // 0x0000000181C6A970-0x0000000181C6A980
	
			// Methods
			public int GetDataHash() => default; // 0x000000018AA931CC-0x000000018AA9320C
			public bool Compare(DeformerSelection data) => default; // 0x000000018AA920E8-0x000000018AA92124
		}
	
		// Constructors
		public SelectionData() {} // 0x000000018AA85D7C-0x000000018AA85E3C
	
		// Methods
		public override int GetDataHash() => default; // 0x000000018AA9200C-0x000000018AA920E8
		public override int GetVersion() => default; // 0x000000018AA92124-0x000000018AA922DC
		public override Define.Error VerifyData() => default; // 0x000000018AA9253C-0x000000018AA92A08
		public bool Compare(SelectionData sel) => default; // 0x000000018AA92A08-0x000000018AA930F4
		public List<int> GetSelectionData(MeshData meshData, List<MeshData> childMeshDataList) => default; // 0x000000018AA922DC-0x000000018AA9253C
		private int GetSelection(MeshData meshData, int vindex, Dictionary<int, List<uint>> dict, List<MeshData> childMeshDataList, List<Dictionary<ulong, int>> hashList) => default; // 0x000000018AA9314C-0x000000018AA931CC
		public void SetSelectionData(MeshData meshData, List<int> selects, List<MeshData> childMeshDataList) {} // 0x000000018AA85D40-0x000000018AA85D7C
		private List<Dictionary<ulong, int>> GetSelectionVertexHashList() => default; // 0x000000018AA85BEC-0x000000018AA85D40
	}

	[Serializable]
	public class SpringData : ShareDataObject // TypeDefIndex: 52347
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x0207666B
		public DeformerData deformerData; // 0x20
		public Vector3 initScale; // 0x28
	
		// Properties
		public int UseVertexCount { get => default; } // 0x0000000184BBD7B0-0x0000000184BBD7C0 
	
		// Nested types
		[Serializable]
		public class DeformerData : IDataHash // TypeDefIndex: 52346
		{
			// Fields
			public int deformerDataHash; // 0x10
			public int vertexCount; // 0x14
			public int[] useVertexIndexList; // 0x18
			public float[] weightList; // 0x20
	
			// Properties
			public int UseVertexCount { get => default; } // 0x000000018AA9320C-0x000000018AA9322C 
	
			// Constructors
			public DeformerData() {} // 0x0000000181C6A970-0x0000000181C6A980
	
			// Methods
			public int GetDataHash() => default; // 0x000000018AA93248-0x000000018AA93264
		}
	
		// Constructors
		public SpringData() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override int GetDataHash() => default; // 0x000000018AA9322C-0x000000018AA93248
		public override int GetVersion() => default; // 0x000000018AA85BD8-0x000000018AA85BEC
		public override Define.Error VerifyData() => default; // 0x000000018AA85B44-0x000000018AA85BD8
	}

	public static class Define // TypeDefIndex: 52352
	{
		// Nested types
		public static class Compute // TypeDefIndex: 52348
		{
			// Fields
			public const float Epsilon = 1E-06f; // Metadata: 0x0207666C
			public const float CollisionFrictionRange = 0.03f; // Metadata: 0x02076670
			public const float FrictionDampingRate = 0.6f; // Metadata: 0x02076674
			public const float FrictionMoveRatio = 0.5f; // Metadata: 0x02076678
			public const float FrictionPower = 4f; // Metadata: 0x0207667C
			public const float ClampPositionMaxVelocity = 1f; // Metadata: 0x02076680
			public const float GlobalColliderMaxMoveDistance = 0.2f; // Metadata: 0x02076684
			public const float GlobalColliderMaxRotationAngle = 10f; // Metadata: 0x02076688
			public const float ColliderExtrusionMaxPower = 0.4f; // Metadata: 0x0207668C
			public const float ColliderExtrusionDirectionPower = 0.3f; // Metadata: 0x02076690
			public const float ColliderExtrusionDistPower = 2f; // Metadata: 0x02076694
			public const float ColliderExtrusionVelocityInfluence = 0.25f; // Metadata: 0x02076698
			public const float MaxWindMain = 100f; // Metadata: 0x0207669C
			public const float ClampRotationMaxVelocity = 1f; // Metadata: 0x020766A0
			public const float ClampRotationMaxVelocity2 = 2f; // Metadata: 0x020766A4
			public const float TriangleBendVelocityInfluence = 0.5f; // Metadata: 0x020766A8
		}
	
		public enum Error // TypeDefIndex: 52349
		{
			None = 0,
			Cancel = 1,
			EmptyData = 100,
			InvalidDataHash = 101,
			TooOldDataVersion = 102,
			HigherDataVersion = 103,
			MeshDataNull = 200,
			MeshDataHashMismatch = 201,
			MeshDataVersionMismatch = 202,
			ClothDataNull = 300,
			ClothDataHashMismatch = 301,
			ClothDataVersionMismatch = 302,
			ClothSelectionHashMismatch = 400,
			ClothSelectionVersionMismatch = 401,
			ClothTargetRootCountMismatch = 500,
			UseTransformNull = 600,
			UseTransformCountZero = 601,
			UseTransformCountMismatch = 602,
			DeformerNull = 700,
			DeformerHashMismatch = 701,
			DeformerVersionMismatch = 702,
			DeformerCountZero = 703,
			DeformerCountMismatch = 704,
			VertexCountZero = 800,
			VertexUseCountZero = 801,
			VertexCountMismatch = 802,
			RootListCountMismatch = 900,
			SelectionDataCountMismatch = 1000,
			SelectionCountZero = 1001,
			CenterTransformNull = 1100,
			SpringDataNull = 1200,
			SpringDataHashMismatch = 1201,
			SpringDataVersionMismatch = 1202,
			TargetObjectNull = 1300,
			SharedMeshNull = 1400,
			SharedMeshCannotRead = 1401,
			SharedMeshDifferent = 1402,
			SharedMeshDifferentVertexCount = 1403,
			MeshOptimizeMismatch = 1500,
			MeshVertexCount65535Over = 1501,
			MeshKeepQuads = 1502,
			BoneListZero = 1600,
			BoneListNull = 1601,
			RendererNotFound = 1700,
			MeshFilterNotFound = 1701,
			BuildNoTransformList = 8000,
			BuildReadOnlyPrefab = 8001,
			BuildFailedSaveAssets = 8002,
			BuildPrefabCannotSaved = 8003,
			BuildNotSceneObject = 8004,
			BuildInvalidComponent = 8100,
			BuildInvalidData = 8101,
			BuildInvalidMeshData = 8102,
			BuildInvalidGameObject = 8103,
			BuildInvalidPrefab = 8104,
			BuildInvalidRenderDeformer = 8105,
			BuildInvalidScene = 8106,
			BuildInvalidSelection = 8107,
			BuildMissingDeformer = 8200,
			BuildMissingSelection = 8201,
			BuildMissingMesh = 8202,
			BuildMissingScriptOnPrefab = 8203,
			OverlappingTransform = 20000,
			AddOverlappingTransform = 20001,
			OldDataVersion = 20002,
			OldAlgorithm = 20003
		}
	
		public static class OptimizeMesh // TypeDefIndex: 52350
		{
			// Fields
			public const int Unknown = 0; // Metadata: 0x0207673E
			public const int Nothing = 1; // Metadata: 0x0207673F
			public const int Unity2018_On = 16; // Metadata: 0x02076740
			public const int Unity2019_PolygonOrder = 256; // Metadata: 0x02076741
			public const int Unity2019_VertexOrder = 512; // Metadata: 0x02076743
		}
	
		public static class RenderMesh // TypeDefIndex: 52351
		{
			// Fields
			public const int WorkerMultiplesOfVertexCollection = 3; // Metadata: 0x02076745
		}
	
		// Methods
		public static bool IsNormal(Error err) => default; // 0x00000001878A7D38-0x00000001878A7D40
		public static bool IsError(Error err) => default; // 0x000000018AA85B24-0x000000018AA85B38
		public static bool IsWarning(Error err) => default; // 0x000000018AA85B38-0x000000018AA85B44
		public static string GetErrorMessage(Error err) => default; // 0x000000018AA857C4-0x000000018AA85B24
	}

	[Serializable]
	public abstract class BaseMeshDeformer : IEditorMesh, IDataVerify, IDataHash // TypeDefIndex: 52353
	{
		// Fields
		private MeshData meshData; // 0x10
		private GameObject targetObject; // 0x18
		protected int dataHash; // 0x20
		protected int dataVersion; // 0x24
		protected RuntimeStatus status; // 0x28
		private CoreComponent parent; // 0x30
		private int _MeshIndex_k__BackingField; // 0x38
		private int _VertexCount_k__BackingField; // 0x3C
		private int _SkinningVertexCount_k__BackingField; // 0x40
		private int _TriangleCount_k__BackingField; // 0x44
	
		// Properties
		public CoreComponent Parent { get; set; } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		public virtual MeshData MeshData { get; set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public GameObject TargetObject { get; set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public RuntimeStatus Status { get; } // 0x00000001813B8590-0x00000001813B85A0 
		public int MeshIndex { get; protected set; } // 0x00000001813E5E30-0x00000001813E5E40 0x00000001813E6F50-0x00000001813E6F60
		public int VertexCount { get; protected set; } // 0x0000000185FB0790-0x0000000185FB07A0 0x0000000185FB07A0-0x0000000185FB07B0
		public int SkinningVertexCount { get; protected set; } // 0x00000001813ECF10-0x00000001813ECF20 0x00000001813EE9C0-0x00000001813EE9D0
		public int TriangleCount { get; protected set; } // 0x0000000183908D10-0x0000000183908D20 0x0000000183909010-0x0000000183909020
		public bool IsSkinning { get; } // 0x000000018AA826FC-0x000000018AA82768 
		public int BoneCount { get; } // 0x000000018AA82684-0x000000018AA826FC 
		public int SaveDataHash { get; } // 0x00000001813B88B0-0x00000001813B88C0 
		public int SaveDataVersion { get; } // 0x0000000181424480-0x0000000181424490 
	
		// Constructors
		protected BaseMeshDeformer() {} // 0x000000018AA82618-0x000000018AA82684
	
		// Methods
		public virtual void Init() {} // 0x000000018AA822D0-0x000000018AA82424
		protected virtual void OnInit() {} // 0x000000018AA8247C-0x000000018AA824E0
		public virtual void Dispose() {} // 0x000000018AA82170-0x000000018AA821F8
		public virtual void OnEnable() {} // 0x000000018AA82450-0x000000018AA8247C
		public virtual void OnDisable() {} // 0x000000018AA82424-0x000000018AA82450
		public virtual void Update() {} // 0x000000018AA8251C-0x000000018AA82560
		internal abstract void MeshCalculation(int bufferIndex);
		internal abstract void NormalWriting(int bufferIndex);
		protected void OnUpdateStatus() {} // 0x000000018AA824E0-0x000000018AA8251C
		protected virtual void OnActive() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnInactive() {} // 0x0000000185492010-0x0000000185492020
		public virtual bool IsMeshUse() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool IsActiveMesh() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual void AddUseMesh(object parent) {} // 0x0000000185492010-0x0000000185492020
		public virtual void RemoveUseMesh(object parent) {} // 0x0000000185492010-0x0000000185492020
		public virtual bool AddUseVertex(int vindex, bool fix) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool RemoveUseVertex(int vindex, bool fix) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual void ResetFuturePrediction() {} // 0x0000000185492010-0x0000000185492020
		public virtual void ChangeUseUnityPhysics(bool sw) {} // 0x0000000185492010-0x0000000185492020
		public virtual int GetDataHash() => default; // 0x000000018AA821F8-0x000000018AA822A4
		public abstract int GetVersion();
		public virtual Define.Error VerifyData() => default; // 0x000000018AA82560-0x000000018AA82618
		public virtual void CreateVerifyData() {} // 0x000000018AA82140-0x000000018AA82170
		public virtual string GetInformation() => default; // 0x000000018AA822A4-0x000000018AA822D0
		public abstract int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList);
		public abstract List<int> GetEditorTriangleList();
		public abstract List<int> GetEditorLineList();
		private object _Init_b__33_0() => default; // 0x00000001813B51D0-0x00000001813B51E0
	}

	public class MagicaRenderDeformer : CoreComponent // TypeDefIndex: 52354
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x02076746
		private const int ERR_DATA_VERSION = 0; // Metadata: 0x02076747
		private RenderMeshDeformer deformer; // 0x38
		private int deformerHash; // 0x40
		private int deformerVersion; // 0x44
		private PhysicsTeam.TeamCullingMode _cullModeCash_k__BackingField; // 0x48
	
		// Properties
		internal PhysicsTeam.TeamCullingMode cullModeCash { get; private set; } // 0x0000000185FB0570-0x0000000185FB0580 0x0000000185FB05D0-0x0000000185FB05E0
		public RenderMeshDeformer Deformer { get => default; } // 0x000000018AA8DE18-0x000000018AA8DE44 
	
		// Constructors
		public MagicaRenderDeformer() {} // 0x000000018AA8DDA4-0x000000018AA8DE18
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000185FBC180-0x0000000185FBC190
		public override int GetDataHash() => default; // 0x000000018AA8D5F8-0x000000018AA8D620
		private void OnValidate() {} // 0x000000018AA8D978-0x000000018AA8D99C
		protected override void OnInit() {} // 0x000000018AA8D930-0x000000018AA8D954
		protected override void OnDispose() {} // 0x000000018AA8D8E4-0x000000018AA8D90C
		protected override void OnUpdate() {} // 0x000000018AA8D954-0x000000018AA8D978
		protected override void OnActive() {} // 0x000000018AA8D7A4-0x000000018AA8D7C8
		protected override void OnInactive() {} // 0x000000018AA8D90C-0x000000018AA8D930
		protected void OnBecameVisible() {} // 0x000000018AA8D810-0x000000018AA8D858
		protected void OnBecameInvisible() {} // 0x000000018AA8D7C8-0x000000018AA8D810
		internal override void UpdateCullingMode(CoreComponent caller) {} // 0x000000018AA8D99C-0x000000018AA8DD08
		protected override void OnChangeCalculation() {} // 0x000000018AA8D858-0x000000018AA8D8E4
		public override int GetVersion() => default; // 0x0000000181C6A970-0x0000000181C6A980
		public override int GetErrorVersion() => default; // 0x00000001813AE580-0x00000001813AE590
		public override void CreateVerifyData() {} // 0x000000018AA8D45C-0x000000018AA8D4A4
		public override Define.Error VerifyData() => default; // 0x000000018AA8DD08-0x000000018AA8DDA4
		public override string GetInformation() => default; // 0x000000018AA8D6BC-0x000000018AA8D704
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict) {}
		public override HashSet<Transform> GetUsedBones() => default; // 0x000000018AA8D728-0x000000018AA8D7A4
		protected override void ChangeUseUnityPhysics(bool sw) {} // 0x000000018AA8D428-0x000000018AA8D45C
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x000000018AA8D648-0x000000018AA8D694
		public override List<int> GetEditorTriangleList() => default; // 0x000000018AA8D694-0x000000018AA8D6BC
		public override List<int> GetEditorLineList() => default; // 0x000000018AA8D620-0x000000018AA8D648
		public override List<int> GetUseList() => default; // 0x000000018AA8D704-0x000000018AA8D728
		public override List<ShareDataObject> GetAllShareDataObject() => default; // 0x000000018AA8D584-0x000000018AA8D5F8
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source) => default; // 0x000000018AA8D4A4-0x000000018AA8D584
	}

	public class MagicaVirtualDeformer : CoreComponent // TypeDefIndex: 52355
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x02076748
		private const int ERR_DATA_VERSION = 0; // Metadata: 0x02076749
		private VirtualMeshDeformer deformer; // 0x38
		private int deformerHash; // 0x40
		private int deformerVersion; // 0x44
		private PhysicsTeam.TeamCullingMode _cullModeCash_k__BackingField; // 0x48
	
		// Properties
		internal PhysicsTeam.TeamCullingMode cullModeCash { get; private set; } // 0x0000000185FB0570-0x0000000185FB0580 0x0000000185FB05D0-0x0000000185FB05E0
		public VirtualMeshDeformer Deformer { get => default; } // 0x000000018AA8DE18-0x000000018AA8DE44 
	
		// Constructors
		public MagicaVirtualDeformer() {} // 0x000000018AA8E830-0x000000018AA8E8A4
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000185FCEC80-0x0000000185FCEC90
		public override int GetDataHash() => default; // 0x000000018AA8D5F8-0x000000018AA8D620
		private void OnValidate() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnInit() {} // 0x000000018AA8E3A8-0x000000018AA8E3E0
		protected override void OnDispose() {} // 0x000000018AA8E36C-0x000000018AA8E3A8
		protected override void OnUpdate() {} // 0x000000018AA8D954-0x000000018AA8D978
		protected override void OnActive() {} // 0x000000018AA8D7A4-0x000000018AA8D7C8
		protected override void OnInactive() {} // 0x000000018AA8D90C-0x000000018AA8D930
		private void LinkRenderDeformerStatus(bool sw) {} // 0x000000018AA8E23C-0x000000018AA8E338
		protected override void ChangeUseUnityPhysics(bool sw) {} // 0x000000018AA8DE44-0x000000018AA8DEE0
		internal override void UpdateCullingMode(CoreComponent caller) {} // 0x000000018AA8E3E0-0x000000018AA8E7C4
		protected override void OnChangeCalculation() {} // 0x000000018AA8E338-0x000000018AA8E36C
		public override int GetVersion() => default; // 0x0000000181C6A970-0x0000000181C6A980
		public override int GetErrorVersion() => default; // 0x00000001813AE580-0x00000001813AE590
		public override void CreateVerifyData() {} // 0x000000018AA8D45C-0x000000018AA8D4A4
		public override Define.Error VerifyData() => default; // 0x000000018AA8E7C4-0x000000018AA8E830
		public override string GetInformation() => default; // 0x000000018AA8D6BC-0x000000018AA8D704
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict) {}
		public override HashSet<Transform> GetUsedBones() => default; // 0x000000018AA8E1C0-0x000000018AA8E23C
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x000000018AA8D648-0x000000018AA8D694
		public override List<int> GetEditorTriangleList() => default; // 0x000000018AA8D694-0x000000018AA8D6BC
		public override List<int> GetEditorLineList() => default; // 0x000000018AA8D620-0x000000018AA8D648
		public override List<int> GetUseList() => default; // 0x000000018AA8E034-0x000000018AA8E1C0
		public override List<ShareDataObject> GetAllShareDataObject() => default; // 0x000000018AA8DFC0-0x000000018AA8E034
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source) => default; // 0x000000018AA8DEE0-0x000000018AA8DFC0
	}

	[Serializable]
	public class MeshData : ShareDataObject // TypeDefIndex: 52358
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x0207674A
		public bool isSkinning; // 0x20
		public int vertexCount; // 0x24
		public uint[] vertexInfoList; // 0x28
		public VertexWeight[] vertexWeightList; // 0x30
		public ulong[] vertexHashList; // 0x38
		public Vector2[] uvList; // 0x40
		public int lineCount; // 0x48
		public int[] lineList; // 0x50
		public int triangleCount; // 0x58
		public int[] triangleList; // 0x60
		public int boneCount; // 0x68
		public uint[] vertexToTriangleInfoList; // 0x70
		public int[] vertexToTriangleIndexList; // 0x78
		public List<ChildData> childDataList; // 0x80
		public Vector3 baseScale; // 0x88
	
		// Properties
		public int VertexCount { get => default; } // 0x0000000185FB0570-0x0000000185FB0580 
		public int VertexHashCount { get => default; } // 0x0000000183F80450-0x0000000183F80460 
		public int WeightCount { get => default; } // 0x0000000185FB0B00-0x0000000185FB0B10 
		public int LineCount { get => default; } // 0x000000018AA8F428-0x000000018AA8F468 
		public int TriangleCount { get => default; } // 0x000000018AA8EFC0-0x000000018AA8F1C4 
		public int BoneCount { get => default; } // 0x0000000181C6A970-0x0000000181C6A980 
		public int ChildCount { get => default; } // 0x000000018AA8F384-0x000000018AA8F3A0 
	
		// Nested types
		[Serializable]
		public struct VertexWeight // TypeDefIndex: 52356
		{
			// Fields
			public Vector3 localPos; // 0x00
			public Vector3 localNor; // 0x0C
			public Vector3 localTan; // 0x18
			public int parentIndex; // 0x24
			public float weight; // 0x28
		}
	
		[Serializable]
		public class ChildData : IDataHash // TypeDefIndex: 52357
		{
			// Fields
			public int childDataHash; // 0x10
			public int vertexCount; // 0x14
			public uint[] vertexInfoList; // 0x18
			public VertexWeight[] vertexWeightList; // 0x20
			public int[] parentIndexList; // 0x28
	
			// Properties
			public int VertexCount { get => default; } // 0x0000000181424480-0x0000000181424490 
	
			// Constructors
			public ChildData() {} // 0x000000018AA8F47C-0x000000018AA8F490
	
			// Methods
			public int GetDataHash() => default; // 0x000000018AA8F468-0x000000018AA8F47C
		}
	
		// Constructors
		public MeshData() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override int GetDataHash() => default; // 0x000000018AA8F1C4-0x000000018AA8F384
		public override int GetVersion() => default; // 0x000000018AA8E8A4-0x000000018AA8EFC0
		public override Define.Error VerifyData() => default; // 0x000000018AA8F3A0-0x000000018AA8F428
		public Dictionary<int, List<uint>> GetVirtualToChildVertexDict() => default; // 0x0000000185FB21A0-0x0000000185FB21B0
		public List<int> ExtendSelection(List<int> originalSelection, bool extendNext, bool extendWeight) => default; // 0x000000018AA82768-0x000000018AA827C4
	}

	[Serializable]
	public class RenderMeshDeformer : BaseMeshDeformer, IBoneReplace // TypeDefIndex: 52361
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x0207674B
		private RecalculateMode normalAndTangentUpdateMode; // 0x48
		private BoundsMode boundsUpdateMode; // 0x4C
		private Mesh sharedMesh; // 0x50
		private int meshOptimize; // 0x58
		private Renderer renderer; // 0x60
		private MeshFilter meshFilter; // 0x68
		private SkinnedMeshRenderer skinMeshRenderer; // 0x70
		private Transform[] originalBones; // 0x78
		private Transform[] boneList; // 0x80
		private Mesh cloneMesh; // 0x88
		private GraphicsBuffer vertexBuffer; // 0x90
		private bool _IsChangePosition_k__BackingField; // 0x98
		private bool _IsChangeNormalTangent_k__BackingField; // 0x99
		private bool _IsChangeBoneWeights_k__BackingField; // 0x9A
		private bool oldUse; // 0x9B
		private bool _IsWriteSkip_k__BackingField; // 0x9C
		private bool _IsFasterWriteUpdate_k__BackingField; // 0x9D
		private bool _IsWriteMeshPosition_k__BackingField; // 0x9E
		private bool _IsWriteMeshBoneWeight_k__BackingField; // 0x9F
		private bool IsWriteMeshNormal; // 0xA0
		private bool IsWriteMeshTangent; // 0xA1
		private bool _IsFasterWrite_k__BackingField; // 0xA2
	
		// Properties
		private bool IsChangePosition { get; set; } // 0x0000000185FB9E80-0x0000000185FB9E90 0x0000000185FBE380-0x0000000185FBE390
		private bool IsChangeNormalTangent { get; set; } // 0x0000000185FCECB0-0x0000000185FCECC0 0x0000000185FCED00-0x0000000185FCED10
		private bool IsChangeBoneWeights { get; set; } // 0x0000000185FCECA0-0x0000000185FCECB0 0x0000000185FCECF0-0x0000000185FCED00
		internal bool IsWriteSkip { get; set; } // 0x0000000185FBF7D0-0x0000000185FBF7E0 0x0000000185FBF810-0x0000000185FBF820
		internal bool IsFasterWriteUpdate { get; private set; } // 0x0000000185FCECC0-0x0000000185FCECD0 0x0000000185FCED10-0x0000000185FCED20
		internal bool IsWriteMeshPosition { get; private set; } // 0x0000000185FCECE0-0x0000000185FCECF0 0x0000000185FCED30-0x0000000185FCED40
		internal bool IsWriteMeshBoneWeight { get; private set; } // 0x0000000185FCECD0-0x0000000185FCECE0 0x0000000185FCED20-0x0000000185FCED30
		public Mesh SharedMesh { get => default; } // 0x0000000181460F60-0x0000000181460F70 
		internal bool IsFasterWrite { get; private set; } // 0x000000018349D750-0x000000018349D760 0x00000001834A2230-0x00000001834A2240
		public bool IsRendererVisible { get => default; } // 0x000000018AA91FA0-0x000000018AA9200C 
		internal bool HasNormal { get => default; } // 0x000000018AA91F8C-0x000000018AA91FA0 
	
		// Nested types
		public enum RecalculateMode // TypeDefIndex: 52359
		{
			None = 0,
			UpdateNormalPerFrame = 1,
			UpdateNormalAndTangentPerFrame = 2
		}
	
		public enum BoundsMode // TypeDefIndex: 52360
		{
			None = 0,
			ExpandedAtInitialization = 1
		}
	
		// Constructors
		public RenderMeshDeformer() {} // 0x000000018AA91F7C-0x000000018AA91F8C
	
		// Methods
		public override int GetDataHash() => default; // 0x000000018AA8FAD4-0x000000018AA8FB58
		public void OnValidate() {} // 0x000000018AA91A30-0x000000018AA91A70
		protected override void OnInit() {} // 0x000000018AA91130-0x000000018AA91A30
		protected override void OnActive() {} // 0x000000018AA90F2C-0x000000018AA9103C
		protected override void OnInactive() {} // 0x000000018AA9103C-0x000000018AA91130
		public override void Dispose() {} // 0x000000018AA8F894-0x000000018AA8F988
		private void SetRecalculateNormalAndTangentMode() {} // 0x000000018AA91D60-0x000000018AA91E38
		public override void ChangeUseUnityPhysics(bool sw) {} // 0x000000018AA8F810-0x000000018AA8F894
		public void ChangeCalculation(bool sw) {} // 0x000000018AA8F780-0x000000018AA8F810
		public override bool IsMeshUse() => default; // 0x000000018AA90948-0x000000018AA909C0
		public override bool IsActiveMesh() => default; // 0x000000018AA908D0-0x000000018AA90948
		public override void AddUseMesh(object parent) {} // 0x000000018AA8F490-0x000000018AA8F780
		public override void RemoveUseMesh(object parent) {} // 0x000000018AA91A70-0x000000018AA91D60
		internal override void MeshCalculation(int bufferIndex) {} // 0x000000018AA909C0-0x000000018AA90DB4
		internal override void NormalWriting(int bufferIndex) {} // 0x000000018AA90DB4-0x000000018AA90F2C
		internal bool FasterWriting(int bufferIndex, ComputeShader compute, int kernel, int index, ref int maxVertexCount) => default; // 0x000000018AA8F988-0x000000018AA8FAD4
		public void ChangeNormalTangentUpdateMode() {} // 0x0000000185FCEC90-0x0000000185FCECA0
		public void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class {}
		public HashSet<Transform> GetUsedBones() => default; // 0x000000018AA907CC-0x000000018AA908D0
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x000000018AA8FB58-0x000000018AA8FEE8
		public override List<int> GetEditorTriangleList() => default; // 0x000000018AA8FEE8-0x000000018AA8FF98
		public override List<int> GetEditorLineList() => default; // 0x00000001813AE580-0x00000001813AE590
		public List<int> GetEditorUseList() => default; // 0x000000018AA8FF98-0x000000018AA9001C
		public override int GetVersion() => default; // 0x0000000181C6A970-0x0000000181C6A980
		public override Define.Error VerifyData() => default; // 0x000000018AA91E38-0x000000018AA91F7C
		private Mesh GetTargetSharedMesh() => default; // 0x000000018AA90694-0x000000018AA907CC
		public override string GetInformation() => default; // 0x000000018AA9001C-0x000000018AA90694
	}

	[Serializable]
	public class VirtualMeshDeformer : BaseMeshDeformer, IBoneReplace // TypeDefIndex: 52363
	{
		// Fields
		private const int DATA_VERSION = 1; // Metadata: 0x02076751
		private List<MagicaRenderDeformer> renderDeformerList; // 0x48
		private List<int> renderDeformerHashList; // 0x50
		private int renderDeformerVersion; // 0x58
		private float mergeVertexDistance; // 0x5C
		private float mergeTriangleDistance; // 0x60
		private float sameSurfaceAngle; // 0x64
		private bool useSkinning; // 0x68
		private int maxWeightCount; // 0x6C
		private float weightPow; // 0x70
		private List<Transform> boneList; // 0x78
		private List<int> sharedChildMeshIndexList; // 0x80
	
		// Properties
		public float MergeVertexDistance { get => default; } // 0x0000000185FB2210-0x0000000185FB2220 
		public float MergeTriangleDistance { get => default; } // 0x000000018AA95740-0x000000018AA9576C 
		public float SameSurfaceAngle { get => default; } // 0x0000000185FB89C0-0x0000000185FB89D0 
		public int MaxWeightCount { get => default; } // 0x000000018AA9576C-0x000000018AA957AC 
		public float WeightPow { get => default; } // 0x000000018AA94704-0x000000018AA94758 
		public int RenderDeformerCount { get => default; } // 0x000000018AA94758-0x000000018AA94828 
	
		// Nested types
		private sealed class __c__DisplayClass35_0 // TypeDefIndex: 52362
		{
			// Fields
			public RenderMeshDeformer deformer; // 0x10
	
			// Constructors
			public __c__DisplayClass35_0() {} // 0x000000018AA93A4C-0x000000018AA93B34
	
			// Methods
			internal bool _GetRenderMeshDeformerIndex_b__0(MagicaRenderDeformer d) => default; // 0x000000018AA94AF8-0x000000018AA94FF4
		}
	
		// Constructors
		public VirtualMeshDeformer() {} // 0x000000018AAA8040-0x000000018AAA8070
	
		// Methods
		public override int GetDataHash() => default; // 0x000000018AA93824-0x000000018AA93A4C
		protected override void OnInit() {} // 0x000000018AA9498C-0x000000018AA94A34
		public override void Dispose() {} // 0x000000018AA94A34-0x000000018AA94AF8
		protected override void OnActive() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnInactive() {} // 0x0000000185492010-0x0000000185492020
		internal override void MeshCalculation(int bufferIndex) {}
		internal override void NormalWriting(int bufferIndex) {} // 0x000000018AA94828-0x000000018AA9489C
		public void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class {} // 0x0000000185779060-0x0000000185779070
		public HashSet<Transform> GetUsedBones() => default; // 0x0000000185FB89D0-0x0000000185FB89E0
		public BaseMeshDeformer GetDeformer() => default; // 0x0000000185FB2200-0x0000000185FB2210
		public MagicaRenderDeformer GetRenderDeformer(int index) => default; // 0x000000018AA945B4-0x000000018AA94704
		public int GetRenderMeshDeformerIndex(RenderMeshDeformer deformer) => default; // 0x000000018AA94914-0x000000018AA9498C
		public List<MeshData> GetRenderDeformerMeshList() => default; // 0x000000018AA9489C-0x000000018AA94914
		public override bool IsMeshUse() => default; // 0x000000018AA93410-0x000000018AA934F4
		public override bool IsActiveMesh() => default; // 0x000000018AA94FF4-0x000000018AA950D8
		public override void AddUseMesh(object parent) {} // 0x000000018AA934F4-0x000000018AA9358C
		public override void RemoveUseMesh(object parent) {} // 0x000000018AA950D8-0x000000018AA95170
		public override bool AddUseVertex(int vindex, bool fix) => default; // 0x000000018AA95170-0x000000018AA951D0
		public override bool RemoveUseVertex(int vindex, bool fix) => default; // 0x000000018AA9361C-0x000000018AA936A0
		public override void ResetFuturePrediction() {} // 0x000000018AA9358C-0x000000018AA9361C
		public override void ChangeUseUnityPhysics(bool sw) {} // 0x000000018AA93BE8-0x000000018AA93F00
		public void ChangeCalculation(bool sw) {} // 0x000000018AA93F00-0x000000018AA93FB4
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x000000018AA93B34-0x000000018AA93BE8
		public override List<int> GetEditorTriangleList() => default; // 0x0000000181B87DE0-0x0000000181B87DF0
		public override List<int> GetEditorLineList() => default; // 0x000000018AA936A0-0x000000018AA93824
		public override int GetVersion() => default; // 0x000000018AA951D0-0x000000018AA955D0
		public override void CreateVerifyData() {} // 0x000000018AA93FB4-0x000000018AA945B4
		public override Define.Error VerifyData() => default; // 0x000000018AA955D0-0x000000018AA95740
		public override string GetInformation() => default; // 0x0000000185492010-0x0000000185492020
	}

	public class ClampDistance2Constraint : PhysicsManagerConstraint // TypeDefIndex: 52368
	{
		// Fields
		private FixedChunkNativeArray<ClampDistance2Data> dataList; // 0x20
		private FixedChunkNativeArray<ClampDistance2RootInfo> rootInfoList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
		private FixedChunkNativeArray<int> rootTeamList; // 0x38
	
		// Nested types
		[Serializable]
		public struct ClampDistance2Data // TypeDefIndex: 52364
		{
			// Fields
			public int vertexIndex; // 0x00
			public int parentVertexIndex; // 0x04
			public float length; // 0x08
		}
	
		[Serializable]
		public struct ClampDistance2RootInfo // TypeDefIndex: 52365
		{
			// Fields
			public ushort startIndex; // 0x00
			public ushort dataLength; // 0x02
		}
	
		public struct GroupData // TypeDefIndex: 52366
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public float minRatio; // 0x08
			public float maxRatio; // 0x0C
			public float velocityInfluence; // 0x10
			public ChunkData dataChunk; // 0x14
			public ChunkData rootInfoChunk; // 0x24
		}
	
		private struct ClampDistance2Job : IJobParallelFor // TypeDefIndex: 52367
		{
			// Fields
			public int runCount; // 0x00
			public NativeArray<ClampDistance2Data> dataList; // 0x08
			public NativeArray<ClampDistance2RootInfo> rootInfoList; // 0x18
			public NativeArray<int> rootTeamList; // 0x28
			public NativeArray<GroupData> groupList; // 0x38
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x48
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x58
			public NativeArray<float> frictionList; // 0x68
			public NativeArray<float3> nextPosList; // 0x78
			public NativeArray<float3> posList; // 0x88
	
			// Methods
			public void Execute(int rootIndex) {} // 0x000000018AA96198-0x000000018AA962F0
		}
	
		// Constructors
		public ClampDistance2Constraint() {} // 0x000000018AA968BC-0x000000018AA96D1C
	
		// Methods
		public override void Create() {} // 0x000000018AA962F0-0x000000018AA96398
		public override void Release() {} // 0x000000018AA95D24-0x000000018AA95FE8
		public int AddGroup(int teamId, bool active, float minRatio, float maxRatio, float velocityInfluence, ClampDistance2Data[] dataArray, ClampDistance2RootInfo[] rootInfoArray) => default; // 0x000000018AA96398-0x000000018AA96598
		public override void RemoveTeam(int teamId) {} // 0x000000018AA95FE8-0x000000018AA96198
		public void ChangeParam(int teamId, bool active, float minRatio, float maxRatio, float velocityInfluence) {} // 0x000000018AA96598-0x000000018AA968BC
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x00000001830836C0-0x00000001830836D0
	}

	public class ClampDistanceConstraint : PhysicsManagerConstraint // TypeDefIndex: 52372
	{
		// Fields
		private FixedChunkNativeArray<ClampDistanceData> dataList; // 0x20
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
	
		// Nested types
		[Serializable]
		public struct ClampDistanceData // TypeDefIndex: 52369
		{
			// Fields
			public ushort vertexIndex; // 0x00
			public ushort targetVertexIndex; // 0x02
			public float length; // 0x04
	
			// Methods
			public bool IsValid() => default; // 0x000000018558DE20-0x000000018558DF30
		}
	
		public struct GroupData // TypeDefIndex: 52370
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public float minRatio; // 0x08
			public float maxRatio; // 0x0C
			public float velocityInfluence; // 0x10
			public ChunkData dataChunk; // 0x14
			public ChunkData refChunk; // 0x24
		}
	
		private struct ClampDistanceJob : IJobParallelFor // TypeDefIndex: 52371
		{
			// Fields
			public int runCount; // 0x00
			public NativeArray<ClampDistanceData> clampDistanceList; // 0x08
			public NativeArray<GroupData> groupList; // 0x18
			public NativeArray<ReferenceDataIndex> refDataList; // 0x28
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x38
			public NativeArray<int> teamIdList; // 0x48
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x58
			public NativeArray<float3> nextPosList; // 0x68
			public NativeArray<float3> basePosList; // 0x78
			public NativeArray<float3> posList; // 0x88
			public NativeArray<float> frictionList; // 0x98
	
			// Methods
			public void Execute(int index) {} // 0x000000018AA97128-0x000000018AA971B0
		}
	
		// Constructors
		public ClampDistanceConstraint() {} // 0x000000018AA97714-0x000000018AA97CB0
	
		// Methods
		public override void Create() {} // 0x000000018AA96D1C-0x000000018AA96F78
		public override void Release() {} // 0x000000018AA971B0-0x000000018AA97378
		public int AddGroup(int teamId, bool active, float minRatio, float maxRatio, float velocityInfluence, ClampDistanceData[] dataArray, ReferenceDataIndex[] refDataArray) => default; // 0x000000018AA96F78-0x000000018AA97128
		public override void RemoveTeam(int teamId) {} // 0x000000018AA97378-0x000000018AA97700
		public void ChangeParam(int teamId, bool active, float minRatio, float maxRatio, float velocityInfluence) {} // 0x00000001830836C0-0x00000001830836D0
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x000000018AA97700-0x000000018AA97714
	}

	public class ClampPositionConstraint : PhysicsManagerConstraint // TypeDefIndex: 52375
	{
		// Fields
		public FixedNativeList<GroupData> groupList; // 0x20
	
		// Nested types
		public struct GroupData // TypeDefIndex: 52373
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public CurveParam limitLength; // 0x08
			public float3 axisRatio; // 0x18
			public float velocityInfluence; // 0x24
	
			// Methods
			public bool IsAxisCheck() => default; // 0x0000000185F59AF0-0x0000000185F59B70
		}
	
		private struct ClampPositionJob : IJobParallelFor // TypeDefIndex: 52374
		{
			// Fields
			public int runCount; // 0x00
			public float maxMoveLength; // 0x04
			public NativeArray<GroupData> clampPositionGroupList; // 0x08
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x18
			public NativeArray<int> teamIdList; // 0x28
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x38
			public NativeArray<float> depthList; // 0x48
			public NativeArray<float3> basePosList; // 0x58
			public NativeArray<quaternion> baseRotList; // 0x68
			public NativeArray<float> frictionList; // 0x78
			public NativeArray<float3> nextPosList; // 0x88
			public NativeArray<float3> posList; // 0x98
	
			// Methods
			public void Execute(int index) {} // 0x000000018AA97FB0-0x000000018AA97FF8
		}
	
		// Constructors
		public ClampPositionConstraint() {} // 0x000000018AA984D8-0x000000018AA98AF8
	
		// Methods
		public override void Create() {} // 0x000000018AA97CB0-0x000000018AA97DDC
		public override void Release() {} // 0x000000018AA97FF8-0x000000018AA98110
		public int AddGroup(int teamId, bool active, BezierParam limitLength, float3 axisRatio, float velocityInfluence) => default; // 0x000000018AA97DDC-0x000000018AA97FB0
		public override void RemoveTeam(int teamId) {} // 0x000000018AA98110-0x000000018AA984D8
		public void ChangeParam(int teamId, bool active, BezierParam limitLength, float3 axisRatio, float velocityInfluence) {} // 0x00000001830836C0-0x00000001830836D0
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x000000018AA9F200-0x000000018AA9F220
	}

	public class ClampRotationConstraint : PhysicsManagerConstraint // TypeDefIndex: 52380
	{
		// Fields
		private FixedChunkNativeArray<ClampRotationData> dataList; // 0x20
		private FixedChunkNativeArray<ClampRotationRootInfo> rootInfoList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
		private FixedChunkNativeArray<int> rootTeamList; // 0x38
		private FixedChunkNativeArray<float> lengthBuffer; // 0x40
	
		// Nested types
		[Serializable]
		public struct ClampRotationData // TypeDefIndex: 52376
		{
			// Fields
			public int vertexIndex; // 0x00
			public int parentVertexIndex; // 0x04
			public float3 localPos; // 0x08
			public quaternion localRot; // 0x14
	
			// Methods
			public bool IsValid() => default; // 0x000000018558DF30-0x000000018558E0D0
		}
	
		[Serializable]
		public struct ClampRotationRootInfo // TypeDefIndex: 52377
		{
			// Fields
			public ushort startIndex; // 0x00
			public ushort dataLength; // 0x02
		}
	
		public struct GroupData // TypeDefIndex: 52378
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public CurveParam maxAngle; // 0x08
			public float velocityInfluence; // 0x18
			public ChunkData dataChunk; // 0x1C
			public ChunkData rootInfoChunk; // 0x2C
		}
	
		private struct ClampRotationJob : IJobParallelFor // TypeDefIndex: 52379
		{
			// Fields
			public int runCount; // 0x00
			public float maxMoveLength; // 0x04
			public NativeArray<ClampRotationData> dataList; // 0x08
			public NativeArray<ClampRotationRootInfo> rootInfoList; // 0x18
			public NativeArray<int> rootTeamList; // 0x28
			public NativeArray<GroupData> groupList; // 0x38
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x48
			public NativeArray<float> depthList; // 0x58
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x68
			public NativeArray<float> frictionList; // 0x78
			public NativeArray<float3> nextPosList; // 0x88
			public NativeArray<quaternion> nextRotList; // 0x98
			public NativeArray<float3> posList; // 0xA8
			public NativeArray<float> lengthBuffer; // 0xB8
	
			// Methods
			public void Execute(int rootIndex) {} // 0x000000018AA98FA0-0x000000018AA9906C
		}
	
		// Constructors
		public ClampRotationConstraint() {} // 0x000000018AA996B0-0x000000018AA9A120
	
		// Methods
		public override void Create() {} // 0x000000018AA98AF8-0x000000018AA98DC0
		public override void Release() {} // 0x000000018AA9906C-0x000000018AA992B8
		public int AddGroup(int teamId, bool active, BezierParam maxAngle, float velocityInfluence, ClampRotationData[] dataArray, ClampRotationRootInfo[] rootInfoArray) => default; // 0x000000018AA98DC0-0x000000018AA98FA0
		public override void RemoveTeam(int teamId) {} // 0x000000018AA992B8-0x000000018AA996A0
		public void ChangeParam(int teamId, bool active, BezierParam maxAngle, float velocityInfluence) {} // 0x00000001830836C0-0x00000001830836D0
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x000000018AA996A0-0x000000018AA996B0
	}

	public class ColliderCollisionConstraint : PhysicsManagerConstraint // TypeDefIndex: 52382
	{
		// Nested types
		private struct CollisionJob : IJobParallelFor // TypeDefIndex: 52381
		{
			// Fields
			public int runCount; // 0x00
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x08
			public NativeArray<int> teamIdList; // 0x18
			public NativeArray<float3> radiusList; // 0x28
			public NativeArray<float3> nextPosList; // 0x38
			public NativeArray<quaternion> nextRotList; // 0x48
			public NativeArray<float3> posList; // 0x58
			public NativeArray<quaternion> rotList; // 0x68
			public NativeArray<float3> localPosList; // 0x78
			public NativeArray<float3> basePosList; // 0x88
			public NativeArray<quaternion> baseRotList; // 0x98
			public NativeArray<int> transformIndexList; // 0xA8
			public NativeArray<int> colliderList; // 0xB8
			public NativeArray<float3> boneSclList; // 0xC8
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0xD8
			public NativeArray<float> frictionList; // 0xE8
			public NativeArray<int> collisionLinkIdList; // 0xF8
			public NativeArray<float3> collisionNormalList; // 0x108
	
			// Methods
			public void Execute(int index) {} // 0x0000000185492010-0x0000000185492020
			private float SphereColliderDetection(ref float3 nextpos, float radius, int cindex, out float3 normal) {
				normal = default;
				return default;
			} // 0x0000000185492010-0x0000000185492020
			private float CapsuleColliderDetection(ref float3 nextpos, float radius, int cindex, float3 dir, out float3 normal) {
				normal = default;
				return default;
			} // 0x000000018AA9A120-0x000000018AA9A170
			private float PlaneColliderDetection(ref float3 nextpos, float radius, int cindex, out float3 normal) {
				normal = default;
				return default;
			} // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public ColliderCollisionConstraint() {} // 0x000000018AA9B884-0x000000018AA9B9A8
	
		// Methods
		public override void Create() {} // 0x000000018AA9A170-0x000000018AA9A6C4
		public override void RemoveTeam(int teamId) {} // 0x00000001830836C0-0x00000001830836D0
		public void ChangeParam(int teamId, bool useCollision) {} // 0x000000018AA9B3C4-0x000000018AA9B884
		public override void Release() {} // 0x000000018AA9B9A8-0x000000018AA9BB58
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x000000018AA9AF10-0x000000018AA9B3C4
	}

	public class ColliderExtrusionConstraint : PhysicsManagerConstraint // TypeDefIndex: 52384
	{
		// Nested types
		private struct CollisionExtrusionJob : IJobParallelFor // TypeDefIndex: 52383
		{
			// Fields
			public int runCount; // 0x00
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x08
			public NativeArray<int> teamIdList; // 0x18
			public NativeArray<float3> nextPosList; // 0x28
			public NativeArray<quaternion> nextRotList; // 0x38
			public NativeArray<int> collisionLinkIdList; // 0x48
			public NativeArray<float3> posList; // 0x58
			public NativeArray<quaternion> rotList; // 0x68
			public NativeArray<float> frictionList; // 0x78
			public NativeArray<float3> collisionNormalList; // 0x88
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x98
	
			// Methods
			public void Execute(int index) {} // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public ColliderExtrusionConstraint() {} // 0x000000018AA9AA94-0x000000018AA9AF10
	
		// Methods
		public override void Create() {} // 0x0000000185492010-0x0000000185492020
		public override void RemoveTeam(int teamId) {} // 0x0000000185492010-0x0000000185492020
		public override void Release() {} // 0x000000018AA9A6C4-0x000000018AA9AA94
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x00000001830836C0-0x00000001830836D0
	}

	public class CompositeRotationConstraint : PhysicsManagerConstraint // TypeDefIndex: 52389
	{
		// Fields
		private FixedChunkNativeArray<RotationData> dataList; // 0x20
		private FixedChunkNativeArray<RootInfo> rootInfoList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
		private FixedChunkNativeArray<int> rootTeamList; // 0x38
		private FixedChunkNativeArray<float> lengthBuffer; // 0x40
	
		// Nested types
		[Serializable]
		public struct RotationData // TypeDefIndex: 52385
		{
			// Fields
			public int vertexIndex; // 0x00
			public int parentVertexIndex; // 0x04
			public float3 localPos; // 0x08
			public quaternion localRot; // 0x14
	
			// Methods
			public bool IsValid() => default; // 0x000000018558E0D0-0x000000018558E270
		}
	
		[Serializable]
		public struct RootInfo // TypeDefIndex: 52386
		{
			// Fields
			public ushort startIndex; // 0x00
			public ushort dataLength; // 0x02
		}
	
		public struct GroupData // TypeDefIndex: 52387
		{
			// Fields
			public int teamId; // 0x00
			public int useClamp; // 0x04
			public int useRestore; // 0x08
			public CurveParam maxAngle; // 0x0C
			public CurveParam restorePower; // 0x1C
			public float restoreVelocityInfluence; // 0x2C
			public ChunkData dataChunk; // 0x30
			public ChunkData rootInfoChunk; // 0x40
		}
	
		private struct RotationRootLineJob : IJobParallelFor // TypeDefIndex: 52388
		{
			// Fields
			public float updatePower; // 0x00
			public int runCount; // 0x04
			public float maxMoveSpeed; // 0x08
			public NativeArray<RotationData> dataList; // 0x10
			public NativeArray<RootInfo> rootInfoList; // 0x20
			public NativeArray<int> rootTeamList; // 0x30
			public NativeArray<GroupData> groupList; // 0x40
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x50
			public NativeArray<CurveParam> teamGravityList; // 0x60
			public NativeArray<float> depthList; // 0x70
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x80
			public NativeArray<float> frictionList; // 0x90
			public NativeArray<float3> basePosList; // 0xA0
			public NativeArray<quaternion> baseRotList; // 0xB0
			public NativeArray<float3> nextPosList; // 0xC0
			public NativeArray<quaternion> nextRotList; // 0xD0
			public NativeArray<float3> posList; // 0xE0
			public NativeArray<float> lengthBuffer; // 0xF0
	
			// Methods
			public void Execute(int rootIndex) {} // 0x000000018AA9C02C-0x000000018AA9C0F8
			private float GetRotRatio(float3 tv, float3 gravityVector, float gravity, float minRatio = 0.25f /* Metadata: 0x02076752 */, float maxRatio = 0.45f /* Metadata: 0x02076756 */) => default; // 0x000000018AA9BB58-0x000000018AA9BE28
		}
	
		// Constructors
		public CompositeRotationConstraint() {} // 0x000000018AA95C50-0x000000018AA95D24
	
		// Methods
		public override void Create() {} // 0x000000018AA9C0F8-0x000000018AA9C308
		public override void Release() {} // 0x000000018AA9BE28-0x000000018AA9C02C
		public int AddGroup(int teamId, bool useClamp, BezierParam maxAngle, bool useRestore, BezierParam restorePower, float velocityInfluence, RotationData[] dataArray, RootInfo[] rootInfoArray) => default; // 0x000000018AA9C308-0x000000018AA9C788
		public override void RemoveTeam(int teamId) {} // 0x00000001830836C0-0x00000001830836D0
		public void ChangeParam(int teamId, bool useClamp, BezierParam maxAngle, bool useRestore, BezierParam restorePower, float velocityInfluence) {} // 0x000000018AA996A0-0x000000018AA996B0
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x000000018AAA31FC-0x000000018AAA48C4
	}

	public class EdgeCollisionConstraint : PhysicsManagerConstraint // TypeDefIndex: 52394
	{
		// Fields
		private FixedChunkNativeArray<EdgeCollisionData> dataList; // 0x20
		private FixedChunkNativeArray<short> groupIndexList; // 0x28
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x30
		private FixedChunkNativeArray<float3> writeBuffer; // 0x38
		private FixedNativeList<GroupData> groupList; // 0x40
	
		// Nested types
		[Serializable]
		public struct EdgeCollisionData // TypeDefIndex: 52390
		{
			// Fields
			public ushort vindex0; // 0x00
			public ushort vindex1; // 0x02
			public int writeIndex0; // 0x04
			public int writeIndex1; // 0x08
	
			// Methods
			public bool IsValid() => default; // 0x000000018AA9E2F8-0x000000018AA9E49C
		}
	
		public struct GroupData // TypeDefIndex: 52391
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public float edgeRadius; // 0x08
			public ChunkData dataChunk; // 0x0C
			public ChunkData groupIndexChunk; // 0x1C
			public ChunkData refDataChunk; // 0x2C
			public ChunkData writeDataChunk; // 0x3C
		}
	
		private struct EdgeCollisionCalcJob : IJobParallelFor // TypeDefIndex: 52392
		{
			// Fields
			public float updatePower; // 0x00
			public int runCount; // 0x04
			public NativeArray<GroupData> groupDataList; // 0x08
			public NativeArray<EdgeCollisionData> dataList; // 0x18
			public NativeArray<short> groupIndexList; // 0x28
			public NativeArray<int> colliderList; // 0x38
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x48
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x58
			public NativeArray<float3> radiusList; // 0x68
			public NativeArray<float3> posList; // 0x78
			public NativeArray<quaternion> rotList; // 0x88
			public NativeArray<float3> nextPosList; // 0x98
			public NativeArray<quaternion> nextRotList; // 0xA8
			public NativeArray<float3> localPosList; // 0xB8
			public NativeArray<int> transformIndexList; // 0xC8
			public NativeArray<float3> boneSclList; // 0xD8
			public NativeArray<float3> writeBuffer; // 0xE8
	
			// Methods
			public void Execute(int index) {} // 0x000000018AA9E49C-0x000000018AA9E568
			private bool SphereColliderDetection(float3 nextpos0, float3 nextpos1, ref float3 corr0, ref float3 corr1, float radius, int cindex) => default; // 0x000000018AA9DE30-0x000000018AA9E164
			private bool CapsuleColliderDetection(float3 nextpos0, float3 nextpos1, ref float3 corr0, ref float3 corr1, float radius, int cindex, float3 dir) => default; // 0x000000018AA9E568-0x000000018AA9E7B4
		}
	
		private struct EdgeCollisionSumJob : IJobParallelFor // TypeDefIndex: 52393
		{
			// Fields
			public int runCount; // 0x00
			public NativeArray<GroupData> groupDataList; // 0x08
			public NativeArray<ReferenceDataIndex> refDataList; // 0x18
			public NativeArray<float3> writeBuffer; // 0x28
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x38
			public NativeArray<int> teamIdList; // 0x48
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x58
			public NativeArray<float3> inoutNextPosList; // 0x68
			public NativeArray<float> frictionList; // 0x78
	
			// Methods
			public void Execute(int pindex) {} // 0x000000018AA9E164-0x000000018AA9E2F8
		}
	
		// Constructors
		public EdgeCollisionConstraint() {} // 0x000000018AA9EEBC-0x000000018AA9F200
	
		// Methods
		public override void Create() {} // 0x000000018AA9E7B4-0x000000018AA9EEA8
		public override void Release() {} // 0x00000001830836C0-0x00000001830836D0
		public int AddGroup(int teamId, bool active, float edgeRadius, EdgeCollisionData[] dataArray, ReferenceDataIndex[] refDataArray, int writeBufferCount) => default; // 0x000000018AA9EEA8-0x000000018AA9EEBC
		public override void RemoveTeam(int teamId) {} // 0x000000018AA9D614-0x000000018AA9DAE8
		public void ChangeParam(int teamId, bool active, float edgeRadius) {} // 0x000000018AA9DAE8-0x000000018AA9DE30
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x000000018AA9CF80-0x000000018AA9D614
	}

	public class PenetrationConstraint : PhysicsManagerConstraint // TypeDefIndex: 52398
	{
		// Fields
		private FixedChunkNativeArray<PenetrationData> dataList; // 0x20
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x28
		private FixedChunkNativeArray<float3> bonePenetrationDataList; // 0x30
		public FixedNativeList<GroupData> groupList; // 0x38
	
		// Nested types
		[Serializable]
		public struct PenetrationData // TypeDefIndex: 52395
		{
			// Fields
			public short vertexIndex; // 0x00
			public short colliderIndex; // 0x02
			public float3 localPos; // 0x04
			public float3 localDir; // 0x10
			public float distance; // 0x1C
	
			// Methods
			public bool IsValid() => default; // 0x000000018558E270-0x000000018558E3D0
		}
	
		public struct GroupData // TypeDefIndex: 52396
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public int mode; // 0x08
			public float maxDepth; // 0x0C
			public CurveParam radius; // 0x10
			public CurveParam distance; // 0x20
			public ChunkData dataChunk; // 0x30
			public ChunkData refDataChunk; // 0x40
			public ChunkData bonePenetrationDataChunk; // 0x50
		}
	
		private struct PenetrationJob : IJobParallelFor // TypeDefIndex: 52397
		{
			// Fields
			public int runCount; // 0x00
			public NativeArray<GroupData> groupList; // 0x08
			public NativeArray<PenetrationData> dataList; // 0x18
			public NativeArray<ReferenceDataIndex> refDataList; // 0x28
			public NativeArray<float3> bonePenetrationDataList; // 0x38
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x48
			public NativeArray<int> teamIdList; // 0x58
			public NativeArray<float3> nextPosList; // 0x68
			public NativeArray<quaternion> nextRotList; // 0x78
			public NativeArray<int> transformIndexList; // 0x88
			public NativeArray<float> depthList; // 0x98
			public NativeArray<float3> basePosList; // 0xA8
			public NativeArray<quaternion> baseRotList; // 0xB8
			public NativeArray<int> colliderList; // 0xC8
			public NativeArray<float3> bonePosList; // 0xD8
			public NativeArray<quaternion> boneRotList; // 0xE8
			public NativeArray<float3> boneSclList; // 0xF8
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x108
			public NativeArray<int> skinningBoneList; // 0x118
			public NativeArray<float3> outNextPosList; // 0x128
			public NativeArray<float3> posList; // 0x138
	
			// Methods
			public void Execute(int index) {} // 0x000000018AA9F6E8-0x000000018AA9F790
			private float3 InverseSpherePosition(ref PenetrationData data, float teamScale, float3 scaleDirection, float distance, int cindex, float cr) => default; // 0x000000018AA9F220-0x000000018AA9F4F0
			private float3 InverseSpherePenetration(float3 c, float cr, float3 nextpos) => default; // 0x000000018AA9F790-0x000000018AA9F97C
		}
	
		// Constructors
		public PenetrationConstraint() {} // 0x000000018AAA0B14-0x000000018AAA0C34
	
		// Methods
		public override void Create() {} // 0x000000018AA9F4F0-0x000000018AA9F6E8
		public override void Release() {} // 0x000000018AA9F97C-0x000000018AA9FF88
		public int AddGroup(int teamId, bool active, ClothParams.PenetrationMode mode, BezierParam distance, BezierParam radius, float maxDepth, PenetrationData[] moveLimitDataList, ReferenceDataIndex[] refDataArray, float3[] bonePenetrationDataArray) => default; // 0x00000001830836C0-0x00000001830836D0
		public override void RemoveTeam(int teamId) {} // 0x000000018AA9FF88-0x000000018AA9FF94
		public void ChangeParam(int teamId, bool active, BezierParam distance, BezierParam radius, float maxDepth) {} // 0x000000018AA9FF94-0x000000018AAA0B14
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x000000018AAA0C34-0x000000018AAA0E10
	}

	public class RestoreDistanceConstraint : PhysicsManagerConstraint // TypeDefIndex: 52402
	{
		// Fields
		public const int StructType = 0; // Metadata: 0x0207675A
		public const int BendType = 1; // Metadata: 0x0207675B
		public const int NearType = 2; // Metadata: 0x0207675C
		public const int TypeCount = 3; // Metadata: 0x0207675D
		private FixedChunkNativeArray<RestoreDistanceData>[] dataList; // 0x20
		private FixedChunkNativeArray<ReferenceDataIndex>[] refDataList; // 0x28
		public FixedNativeList<RestoreDistanceGroupData> groupList; // 0x30
	
		// Nested types
		[Serializable]
		public struct RestoreDistanceData // TypeDefIndex: 52399
		{
			// Fields
			public ushort vertexIndex; // 0x00
			public ushort targetVertexIndex; // 0x02
			public float length; // 0x04
	
			// Methods
			public bool IsValid() => default; // 0x000000018558E5F0-0x000000018558E7D0
		}
	
		public struct RestoreDistanceGroupData // TypeDefIndex: 52400
		{
			// Fields
			public int teamId; // 0x00
			public CurveParam mass; // 0x04
			public float velocityInfluence; // 0x14
			public CurveParam structStiffness; // 0x18
			public ChunkData structDataChunk; // 0x28
			public ChunkData structRefChunk; // 0x38
			public int useBend; // 0x48
			public CurveParam bendStiffness; // 0x4C
			public ChunkData bendDataChunk; // 0x5C
			public ChunkData bendRefChunk; // 0x6C
			public int useNear; // 0x7C
			public CurveParam nearStiffness; // 0x80
			public ChunkData nearDataChunk; // 0x90
			public ChunkData nearRefChunk; // 0xA0
	
			// Methods
			public bool IsValid(int type) => default; // 0x000000018AAA1678-0x000000018AAA175C
			public CurveParam GetStiffness(int type) => default; // 0x000000018AAA0E10-0x000000018AAA13DC
			public ChunkData GetDataChunk(int type) => default; // 0x000000018AAA175C-0x000000018AAA1A08
			public ChunkData GetRefChunk(int type) => default; // 0x000000018AAA13DC-0x000000018AAA1678
		}
	
		private struct DistanceJob : IJobParallelFor // TypeDefIndex: 52401
		{
			// Fields
			public float updatePower; // 0x00
			public int runCount; // 0x04
			public int type; // 0x08
			public NativeArray<RestoreDistanceData> restoreDistanceDataList; // 0x10
			public NativeArray<RestoreDistanceGroupData> restoreDistanceGroupDataList; // 0x20
			public NativeArray<ReferenceDataIndex> refDataList; // 0x30
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x40
			public NativeArray<int> teamIdList; // 0x50
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x60
			public NativeArray<float> depthList; // 0x70
			public NativeArray<float> frictionList; // 0x80
			public NativeArray<float3> basePosList; // 0x90
			public NativeArray<float3> nextPosList; // 0xA0
			public NativeArray<float3> outNextPosList; // 0xB0
			public NativeArray<float3> posList; // 0xC0
	
			// Methods
			public void Execute(int index) {} // 0x0000000181C0BBD0-0x0000000181C0BBE0
		}
	
		// Constructors
		public RestoreDistanceConstraint() {} // 0x000000018AA9C788-0x000000018AA9CF80
	
		// Methods
		public override void Create() {} // 0x000000018AAA1A08-0x000000018AAA1F18
		public override void Release() {} // 0x00000001830836C0-0x00000001830836D0
		public int AddGroup(int teamId, BezierParam mass, float velocityInfluence, BezierParam structStiffness, RestoreDistanceData[] structDataArray, ReferenceDataIndex[] structRefDataArray, bool useBend, BezierParam bendStiffness, RestoreDistanceData[] bendDataArray, ReferenceDataIndex[] bendRefDataArray, bool useNear, BezierParam nearStiffness, RestoreDistanceData[] nearDataArray, ReferenceDataIndex[] nearRefDataArray) => default; // 0x000000018AA97700-0x000000018AA97714
		public override void RemoveTeam(int teamId) {} // 0x000000018AAA1F90-0x000000018AAA1FAC
		public void ChangeParam(int teamId, BezierParam mass, float velocityInfluence, BezierParam structStiffness, bool useBend, BezierParam bendStiffness, bool useNear, BezierParam nearStiffness) {} // 0x000000018AAA1F68-0x000000018AAA1F90
		public override int GetIterationCount() => default; // 0x000000018AAA1F18-0x000000018AAA1F40
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x000000018AAA1F40-0x000000018AAA1F68
	}

	public class RestoreRotationConstraint : PhysicsManagerConstraint // TypeDefIndex: 52406
	{
		// Fields
		private FixedChunkNativeArray<RotationData> dataList; // 0x20
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
	
		// Nested types
		[Serializable]
		public struct RotationData // TypeDefIndex: 52403
		{
			// Fields
			public ushort vertexIndex; // 0x00
			public ushort targetVertexIndex; // 0x02
			public float3 localPos; // 0x04
	
			// Methods
			public bool IsValid() => default; // 0x000000018558E3D0-0x000000018558E4E0
		}
	
		public struct GroupData // TypeDefIndex: 52404
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public CurveParam restorePower; // 0x08
			public float velocityInfluence; // 0x18
			public ChunkData dataChunk; // 0x1C
			public ChunkData refChunk; // 0x2C
		}
	
		private struct RotationJob : IJobParallelFor // TypeDefIndex: 52405
		{
			// Fields
			public float updatePower; // 0x00
			public int runCount; // 0x04
			public NativeArray<RotationData> dataList; // 0x08
			public NativeArray<GroupData> groupList; // 0x18
			public NativeArray<ReferenceDataIndex> refDataList; // 0x28
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x38
			public NativeArray<int> teamIdList; // 0x48
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x58
			public NativeArray<float> depthList; // 0x68
			public NativeArray<quaternion> baseRotList; // 0x78
			public NativeArray<float3> nextPosList; // 0x88
			public NativeArray<float> frictionList; // 0x98
			public NativeArray<float3> outNextPosList; // 0xA8
			public NativeArray<float3> posList; // 0xB8
	
			// Methods
			public void Execute(int index) {} // 0x000000018AAA2408-0x000000018AAA2490
		}
	
		// Constructors
		public RestoreRotationConstraint() {} // 0x000000018AAA2AC4-0x000000018AAA31FC
	
		// Methods
		public override void Create() {} // 0x000000018AAA1FAC-0x000000018AAA2228
		public override void Release() {} // 0x000000018AAA2490-0x000000018AAA2668
		public int AddGroup(int teamId, bool active, BezierParam power, float velocityInfluence, RotationData[] dataArray, ReferenceDataIndex[] refDataArray) => default; // 0x000000018AAA2228-0x000000018AAA2408
		public override void RemoveTeam(int teamId) {} // 0x000000018AAA2668-0x000000018AAA2AC4
		public void ChangeParam(int teamId, bool active, BezierParam power, float velocityInfluence) {} // 0x00000001830836C0-0x00000001830836D0
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x000000018AA97700-0x000000018AA97714
	}

	public class SpringConstraint : PhysicsManagerConstraint // TypeDefIndex: 52409
	{
		// Fields
		public FixedNativeList<GroupData> groupList; // 0x20
	
		// Nested types
		public struct GroupData // TypeDefIndex: 52407
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public float spring; // 0x08
		}
	
		private struct SpringJob : IJobParallelFor // TypeDefIndex: 52408
		{
			// Fields
			public float updatePower; // 0x00
			public int runCount; // 0x04
			public NativeArray<GroupData> groupList; // 0x08
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x18
			public NativeArray<int> teamIdList; // 0x28
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x38
			public NativeArray<float3> basePosList; // 0x48
			public NativeArray<float3> nextPosList; // 0x58
	
			// Methods
			public void Execute(int index) {} // 0x0000000185F58370-0x0000000185F583F0
		}
	
		// Constructors
		public SpringConstraint() {} // 0x000000018AAA4F00-0x000000018AAA5168
	
		// Methods
		public override void Create() {} // 0x000000018AAA4AF0-0x000000018AAA4B38
		public override void Release() {} // 0x000000018AAA48C4-0x000000018AAA4990
		public int AddGroup(int teamId, bool active, float spring) => default; // 0x000000018AAA4B38-0x000000018AAA4C50
		public override void RemoveTeam(int teamId) {} // 0x000000018AAA4990-0x000000018AAA4AF0
		public void ChangeParam(int teamId, bool active, float spring) {} // 0x000000018AAA4C50-0x000000018AAA4F00
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x00000001830836C0-0x00000001830836D0
	}

	public class TriangleBendConstraint : PhysicsManagerConstraint // TypeDefIndex: 52414
	{
		// Fields
		private FixedChunkNativeArray<TriangleBendData> dataList; // 0x20
		private FixedChunkNativeArray<short> groupIndexList; // 0x28
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x30
		private FixedChunkNativeArray<float3> writeBuffer; // 0x38
		private FixedNativeList<TriangleBendGroupData> groupList; // 0x40
	
		// Nested types
		[Serializable]
		public struct TriangleBendData // TypeDefIndex: 52410
		{
			// Fields
			public int vindex0; // 0x00
			public int vindex1; // 0x04
			public int vindex2; // 0x08
			public int vindex3; // 0x0C
			public float restAngle; // 0x10
			public float direction; // 0x14
			public float depth; // 0x18
			public int writeIndex0; // 0x1C
			public int writeIndex1; // 0x20
			public int writeIndex2; // 0x24
			public int writeIndex3; // 0x28
	
			// Methods
			public bool IsValid() => default; // 0x000000018558E7D0-0x000000018558E970
			public bool IsPositionBend() => default; // 0x000000018AAA63C0-0x000000018AAA648C
		}
	
		public struct TriangleBendGroupData // TypeDefIndex: 52411
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public int algorithm; // 0x08
			public CurveParam stiffness; // 0x0C
			public ChunkData dataChunk; // 0x1C
			public ChunkData groupIndexChunk; // 0x2C
			public ChunkData refDataChunk; // 0x3C
			public ChunkData writeDataChunk; // 0x4C
		}
	
		private struct TriangleBendCalcJob : IJobParallelFor // TypeDefIndex: 52412
		{
			// Fields
			public float updatePower; // 0x00
			public int runCount; // 0x04
			public NativeArray<TriangleBendGroupData> triangleBendGroupDataList; // 0x08
			public NativeArray<TriangleBendData> triangleBendList; // 0x18
			public NativeArray<short> groupIndexList; // 0x28
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x38
			public NativeArray<float3> nextPosList; // 0x48
			public NativeArray<float3> basePosList; // 0x58
			public NativeArray<float3> writeBuffer; // 0x68
	
			// Methods
			public void Execute(int index) {} // 0x000000018AAA5E5C-0x000000018AAA61C4
		}
	
		private struct TriangleBendSumJob : IJobParallelFor // TypeDefIndex: 52413
		{
			// Fields
			public int runCount; // 0x00
			public NativeArray<TriangleBendGroupData> triangleBendGroupDataList; // 0x08
			public NativeArray<ReferenceDataIndex> refDataList; // 0x18
			public NativeArray<float3> writeBuffer; // 0x28
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x38
			public NativeArray<int> teamIdList; // 0x48
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x58
			public NativeArray<float3> inoutNextPosList; // 0x68
			public NativeArray<float3> posList; // 0x78
	
			// Methods
			public void Execute(int pindex) {} // 0x000000018AAA648C-0x000000018AAA66D8
		}
	
		// Constructors
		public TriangleBendConstraint() {} // 0x000000018AAA6BB0-0x000000018AAA6F74
	
		// Methods
		public override void Create() {} // 0x000000018AAA61C4-0x000000018AAA63C0
		public override void Release() {} // 0x000000018AAA66D8-0x000000018AAA6B98
		public int AddGroup(int teamId, bool active, ClothParams.Algorithm algorithm, BezierParam stiffness, TriangleBendData[] dataArray, ReferenceDataIndex[] refDataArray, int writeBufferCount) => default; // 0x00000001830836C0-0x00000001830836D0
		public override void RemoveTeam(int teamId) {} // 0x000000018AAA6BA0-0x000000018AAA6BB0
		public void ChangeParam(int teamId, bool active, BezierParam stiffness) {} // 0x000000018AAA6B98-0x000000018AAA6BA0
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x000000018AAA5168-0x000000018AAA5E5C
	}

	public class TwistConstraint : PhysicsManagerConstraint // TypeDefIndex: 52418
	{
		// Fields
		private FixedChunkNativeArray<TwistData> dataList; // 0x20
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
	
		// Nested types
		[Serializable]
		public struct TwistData // TypeDefIndex: 52415
		{
			// Fields
			public ushort vertexIndex0; // 0x00
			public ushort vertexIndex1; // 0x02
	
			// Methods
			public bool IsValid() => default; // 0x000000018558E4E0-0x000000018558E5F0
		}
	
		public struct GroupData // TypeDefIndex: 52416
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public float recoveryPower; // 0x08
			public ChunkData dataChunk; // 0x0C
			public ChunkData refChunk; // 0x1C
		}
	
		private struct TwistJob2 : IJobParallelFor // TypeDefIndex: 52417
		{
			// Fields
			public int runCount; // 0x00
			public float updatePower; // 0x04
			public NativeArray<TwistData> dataList; // 0x08
			public NativeArray<ReferenceDataIndex> refDataList; // 0x18
			public NativeArray<GroupData> groupList; // 0x28
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x38
			public NativeArray<int> teamIdList; // 0x48
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x58
			public NativeArray<float3> basePosList; // 0x68
			public NativeArray<float3> nextPosList; // 0x78
			public NativeArray<float> frictionList; // 0x88
			public NativeArray<float3> outNextPosList; // 0x98
			public NativeArray<float3> posList; // 0xA8
	
			// Methods
			public void Execute(int index) {} // 0x000000018AAA72DC-0x000000018AAA7364
		}
	
		// Constructors
		public TwistConstraint() {} // 0x000000018AAA794C-0x000000018AAA8040
	
		// Methods
		public override void Create() {} // 0x000000018AAA6F74-0x000000018AAA715C
		public override void Release() {} // 0x000000018AAA7364-0x000000018AAA753C
		public int AddGroup(int teamId, bool active, float recoveryPower, TwistData[] dataArray, ReferenceDataIndex[] refArray) => default; // 0x000000018AAA715C-0x000000018AAA72DC
		public override void RemoveTeam(int teamId) {} // 0x000000018AAA753C-0x000000018AAA794C
		public void ChangeParam(int teamId, bool active, float recoveryPower) {} // 0x00000001830836C0-0x00000001830836D0
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x000000018AA97700-0x000000018AA97714
	}

	public class VolumeConstraint : PhysicsManagerConstraint // TypeDefIndex: 52423
	{
		// Fields
		private FixedChunkNativeArray<VolumeData> dataList; // 0x20
		private FixedChunkNativeArray<short> groupIndexList; // 0x28
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x30
		private FixedChunkNativeArray<float3> writeBuffer; // 0x38
		private FixedNativeList<GroupData> groupList; // 0x40
	
		// Nested types
		[Serializable]
		public struct VolumeData // TypeDefIndex: 52419
		{
			// Fields
			public int vindex0; // 0x00
			public int vindex1; // 0x04
			public int vindex2; // 0x08
			public int vindex3; // 0x0C
			public float3x3 ivMat; // 0x10
			public float depth; // 0x34
			public int direction; // 0x38
			public int writeIndex0; // 0x3C
			public int writeIndex1; // 0x40
			public int writeIndex2; // 0x44
			public int writeIndex3; // 0x48
	
			// Methods
			public bool IsValid() => default; // 0x000000018AAA9444-0x000000018AAA95E8
		}
	
		public struct GroupData // TypeDefIndex: 52420
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public CurveParam stretchStiffness; // 0x08
			public CurveParam shearStiffness; // 0x18
			public ChunkData dataChunk; // 0x28
			public ChunkData groupIndexChunk; // 0x38
			public ChunkData refDataChunk; // 0x48
			public ChunkData writeDataChunk; // 0x58
		}
	
		private struct VolumeCalcJob : IJobParallelFor // TypeDefIndex: 52421
		{
			// Fields
			public float updatePower; // 0x00
			public int runCount; // 0x04
			public NativeArray<GroupData> groupDataList; // 0x08
			public NativeArray<VolumeData> dataList; // 0x18
			public NativeArray<short> groupIndexList; // 0x28
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x38
			public NativeArray<float3> nextPosList; // 0x48
			public NativeArray<float3> writeBuffer; // 0x58
	
			// Methods
			public void Execute(int index) {} // 0x000000018AAA95E8-0x000000018AAA96B4
		}
	
		private struct VolumeSumJob : IJobParallelFor // TypeDefIndex: 52422
		{
			// Fields
			public int runCount; // 0x00
			public NativeArray<GroupData> groupDataList; // 0x08
			public NativeArray<ReferenceDataIndex> refDataList; // 0x18
			public NativeArray<float3> writeBuffer; // 0x28
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x38
			public NativeArray<int> teamIdList; // 0x48
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x58
			public NativeArray<float3> inoutNextPosList; // 0x68
	
			// Methods
			public void Execute(int pindex) {} // 0x000000018AAA8EBC-0x000000018AAA9230
		}
	
		// Constructors
		public VolumeConstraint() {} // 0x000000018AAB8DE8-0x000000018AAB9120
	
		// Methods
		public override void Create() {} // 0x000000018AAA96B4-0x000000018AAA98F0
		public override void Release() {} // 0x000000018AAA9230-0x000000018AAA9444
		public int AddGroup(int teamId, bool active, BezierParam stretchStiffness, BezierParam shearStiffness, VolumeData[] dataArray, ReferenceDataIndex[] refDataArray, int writeBufferCount) => default; // 0x0000000181C0BBD0-0x0000000181C0BBE0
		public override void RemoveTeam(int teamId) {} // 0x000000018AAA98F0-0x000000018AAA9E38
		public void ChangeParam(int teamId, bool active, BezierParam stretchStiffness, BezierParam shearStiffness) {} // 0x00000001830836C0-0x00000001830836D0
		public override int GetIterationCount() => default; // 0x000000018AAA6BA0-0x000000018AAA6BB0
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x000000018AAA8070-0x000000018AAA8EBC
	}

	public struct CurveParam // TypeDefIndex: 52424
	{
		// Fields
		public float sval; // 0x00
		public float eval; // 0x04
		public float cval; // 0x08
		public int useCurve; // 0x0C
	
		// Constructors
		public CurveParam(float value) {
			sval = default;
			eval = default;
			cval = default;
			useCurve = default;
		} // 0x0000000185FCEE30-0x0000000185FCEE40
		public CurveParam(float svalue, float evalue) {
			sval = default;
			eval = default;
			cval = default;
			useCurve = default;
		} // 0x0000000185FCEE40-0x0000000185FCEE50
		public CurveParam(BezierParam bezier) {
			sval = default;
			eval = default;
			cval = default;
			useCurve = default;
		} // 0x000000018AAAA2BC-0x000000018AAAA2D0
	
		// Methods
		public void Setup(BezierParam bezier) {} // 0x000000018AAAA21C-0x000000018AAAA2BC
		public float Evaluate(float t) => default; // 0x000000018AAAA1B4-0x000000018AAAA21C
	}

	public abstract class BaseComponent : MonoBehaviour // TypeDefIndex: 52425
	{
		// Constructors
		protected BaseComponent() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public abstract ComponentType GetComponentType();
	}

	public enum ComponentType // TypeDefIndex: 52426
	{
		None = 0,
		SphereCollider = 100,
		CapsuleCollider = 101,
		PlaneCollider = 102,
		DirectionalWind = 200,
		AreaWind = 201,
		RenderDeformer = 500,
		VirtualDeformer = 600,
		BoneCloth = 1000,
		BoneSpring = 1001,
		MeshCloth = 2000,
		MeshSpring = 2001,
		Avatar = 4000,
		AvatarParts = 4001
	}

	public abstract class PhysicsManagerAccess : IDisposable // TypeDefIndex: 52427
	{
		// Fields
		protected MagicaPhysicsManager manager; // 0x10
	
		// Properties
		public UpdateTimeManager UpdateTime { get; } // 0x00000001877A0E24-0x00000001877A0E40 
		protected PhysicsManagerParticleData Particle { get; } // 0x000000018AA675AC-0x000000018AA675CC 
		protected PhysicsManagerBoneData Bone { get; } // 0x000000018440AA20-0x000000018440AA60 
		protected PhysicsManagerMeshData Mesh { get; } // 0x0000000184409620-0x00000001844096A0 
		protected PhysicsManagerTeamData Team { get; } // 0x00000001844095A0-0x0000000184409620 
		protected PhysicsManagerWindData Wind { get; } // 0x000000018AA7D330-0x000000018AA7D350 
		protected PhysicsManagerComponent Component { get; } // 0x000000018AAAB6C4-0x000000018AAAB6E4 
		protected PhysicsManagerCompute Compute { get; } // 0x000000018AAAB6E4-0x000000018AAAB704 
	
		// Constructors
		protected PhysicsManagerAccess() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void SetParent(MagicaPhysicsManager manager) {} // 0x0000000184096E30-0x0000000184096EF0
		public abstract void Create();
		public abstract void Dispose();
	}

	public class PhysicsManagerBoneData : PhysicsManagerAccess // TypeDefIndex: 52436
	{
		// Fields
		public const byte Flag_Reset = 1; // Metadata: 0x0207677C
		public const byte Flag_Restore = 16; // Metadata: 0x0207677D
		public const byte Flag_Write = 32; // Metadata: 0x0207677E
		public FixedTransformAccessArray boneList; // 0x18
		public FixedNativeList<byte> boneFlagList; // 0x20
		public FixedNativeList<float3> bonePosList; // 0x28
		public FixedNativeList<quaternion> boneRotList; // 0x30
		public FixedNativeList<float3> boneSclList; // 0x38
		public FixedNativeList<int> boneParentIndexList; // 0x40
		public FixedNativeList<float3> basePosList; // 0x48
		public FixedNativeList<quaternion> baseRotList; // 0x50
		public FixedNativeList<short> boneUnityPhysicsList; // 0x58
		public FixedNativeList<float3> futurePosList; // 0x60
		public FixedNativeList<quaternion> futureRotList; // 0x68
		public FixedTransformAccessArray restoreBoneList; // 0x70
		public FixedNativeList<float3> restoreBoneLocalPosList; // 0x78
		public FixedNativeList<quaternion> restoreBoneLocalRotList; // 0x80
		public FixedNativeList<int> restoreBoneIndexList; // 0x88
		public FixedTransformAccessArray writeBoneList; // 0x90
		public FixedNativeList<int> writeBoneIndexList; // 0x98
		public ExNativeMultiHashMap<int, int> writeBoneParticleIndexMap; // 0xA0
		private Dictionary<int, int> boneToWriteIndexDict; // 0xA8
		public FixedNativeList<float3> writeBonePosList; // 0xB0
		public FixedNativeList<quaternion> writeBoneRotList; // 0xB8
		private bool _hasBoneChanged_k__BackingField; // 0xC0
		private CustomSampler _SamplerReadBoneScale_k__BackingField; // 0xC8
	
		// Properties
		public bool hasBoneChanged { get; private set; } // 0x000000018AAAD0D4-0x000000018AAAD0F4 0x000000018AAAB704-0x000000018AAABC34
		private CustomSampler SamplerReadBoneScale { get; set; } // 0x000000018AAACA68-0x000000018AAACD98 0x000000018AAABD60-0x000000018AAABDD8
		public int RestoreBoneCount { get => default; } // 0x000000018AAAC530-0x000000018AAACA68 
		public int ReadBoneCount { get => default; } // 0x000000018AAB8C2C-0x000000018AAB8D14 
		public int WriteBoneCount { get => default; } // 0x000000018AAB81F4-0x000000018AAB8550 
	
		// Nested types
		private struct RestoreBoneJob : IJobParallelForTransform // TypeDefIndex: 52428
		{
			// Fields
			public bool fixedUpdate; // 0x00
			public NativeArray<short> boneUnityPhysicsList; // 0x08
			public NativeArray<byte> boneFlagList; // 0x18
			public NativeArray<float3> restoreBoneLocalPosList; // 0x28
			public NativeArray<quaternion> restoreBoneLocalRotList; // 0x38
			public NativeArray<int> restoreBoneIndexList; // 0x48
	
			// Methods
			public void Execute(int index, TransformAccess transform) {} // 0x0000000185FB9C20-0x0000000185FB9C30
		}
	
		private struct ReadBoneJob0 : IJobParallelForTransform // TypeDefIndex: 52429
		{
			// Fields
			public int fixedUpdateCount; // 0x00
			public NativeArray<float3> bonePosList; // 0x08
			public NativeArray<quaternion> boneRotList; // 0x18
			public NativeArray<float3> boneSclList; // 0x28
			public NativeArray<float3> basePosList; // 0x38
			public NativeArray<quaternion> baseRotList; // 0x48
			public NativeArray<float3> futurePosList; // 0x58
			public NativeArray<quaternion> futureRotList; // 0x68
			public NativeArray<short> boneUnityPhysicsList; // 0x78
			public NativeArray<byte> boneFlagList; // 0x88
	
			// Methods
			public void Execute(int index, TransformAccess transform) {} // 0x0000000185FBB900-0x0000000185FBB910
		}
	
		private struct ReadBoneJob1 : IJobParallelForTransform // TypeDefIndex: 52430
		{
			// Fields
			public int fixedUpdateCount; // 0x00
			public float normalFutureRatio; // 0x04
			public float fixedFutureRatio; // 0x08
			public float normalDeltaTime; // 0x0C
			public float fixedDeltaTime; // 0x10
			public NativeArray<float3> bonePosList; // 0x18
			public NativeArray<quaternion> boneRotList; // 0x28
			public NativeArray<float3> boneSclList; // 0x38
			public NativeArray<float3> basePosList; // 0x48
			public NativeArray<quaternion> baseRotList; // 0x58
			public NativeArray<short> boneUnityPhysicsList; // 0x68
			public NativeArray<float3> futurePosList; // 0x78
			public NativeArray<quaternion> futureRotList; // 0x88
			public NativeArray<byte> boneFlagList; // 0x98
	
			// Methods
			public void Execute(int index, TransformAccess transform) {} // 0x0000000185FB0300-0x0000000185FB0310
		}
	
		private struct ConvertWorldToLocalJob : IJobParallelFor // TypeDefIndex: 52431
		{
			// Fields
			public NativeArray<int> writeBoneIndexList; // 0x00
			public NativeArray<byte> boneFlagList; // 0x10
			public NativeArray<float3> bonePosList; // 0x20
			public NativeArray<quaternion> boneRotList; // 0x30
			public NativeArray<float3> boneSclList; // 0x40
			public NativeArray<int> boneParentIndexList; // 0x50
			public NativeArray<float3> writeBonePosList; // 0x60
			public NativeArray<quaternion> writeBoneRotList; // 0x70
	
			// Methods
			public void Execute(int index) {} // 0x0000000187A47C30-0x0000000187A47C44
		}
	
		private struct WriteBontToTransformJob2 : IJobParallelForTransform // TypeDefIndex: 52432
		{
			// Fields
			public int fixedUpdateCount; // 0x00
			public NativeArray<byte> boneFlagList; // 0x08
			public NativeArray<int> writeBoneIndexList; // 0x18
			public NativeArray<int> boneParentIndexList; // 0x28
			public NativeArray<float3> writeBonePosList; // 0x38
			public NativeArray<quaternion> writeBoneRotList; // 0x48
			public NativeArray<short> boneUnityPhysicsList; // 0x58
	
			// Methods
			public void Execute(int index, TransformAccess transform) {} // 0x0000000184B341C0-0x0000000184B34710
		}
	
		private struct CopyBoneJob0 : IJobParallelFor // TypeDefIndex: 52433
		{
			// Fields
			public NativeArray<float3> bonePosList; // 0x00
			public NativeArray<quaternion> boneRotList; // 0x10
			public NativeArray<float3> backBonePosList; // 0x20
			public NativeArray<quaternion> backBoneRotList; // 0x30
	
			// Methods
			public void Execute(int index) {} // 0x000000018AAAC2D8-0x000000018AAAC530
		}
	
		private struct CopyBoneJob1 : IJobParallelFor // TypeDefIndex: 52434
		{
			// Fields
			public NativeArray<int> writeBoneIndexList; // 0x00
			public NativeArray<int> backWriteBoneIndexList; // 0x10
	
			// Methods
			public void Execute(int index) {} // 0x000000018AAABC34-0x000000018AAABD60
		}
	
		private struct CopyBoneJob2 : IJobParallelFor // TypeDefIndex: 52435
		{
			// Fields
			public NativeArray<byte> boneFlagList; // 0x00
			public NativeArray<byte> backBoneFlagList; // 0x10
	
			// Methods
			public void Execute(int index) {} // 0x000000018AAACD98-0x000000018AAACE68
		}
	
		// Constructors
		public PhysicsManagerBoneData() {} // 0x0000000185FCEDB0-0x0000000185FCEDD0
	
		// Methods
		public override void Create() {} // 0x000000018AAAD04C-0x000000018AAAD0B4
		public override void Dispose() {} // 0x000000018AAAD0B4-0x000000018AAAD0D4
		public int AddRestoreBone(Transform target, float3 lpos, quaternion lrot, int boneIndex) => default; // 0x000000018440ACF0-0x000000018440AD40
		public void RemoveRestoreBone(int restoreBoneIndex) {} // 0x000000018AAACE68-0x000000018AAAD04C
		public int AddBone(Transform target, int pindex = -1 /* Metadata: 0x02076779 */, bool addParent = false /* Metadata: 0x0207677A */) => default; // 0x000000018AAABDD8-0x000000018AAAC024
		public bool RemoveBone(int boneIndex, int pindex = -1 /* Metadata: 0x0207677B */) => default; // 0x000000018440ABF0-0x000000018440ACF0
		public void ChangeUnityPhysicsCount(int boneIndex, bool sw) {} // 0x000000018AAAC024-0x000000018AAAC2D8
		public void ResetFuturePrediction(int boneIndex) {} // 0x000000018588C800-0x000000018588C880
		public void ResetBoneFromTransform(bool fixedUpdate) {} // 0x000000018AAB8550-0x000000018AAB8A64
		public void ReadBoneFromTransform() {} // 0x000000018AAA9EFC-0x000000018AAAA1B4
		public void ConvertWorldToLocal() {} // 0x000000018AAB9120-0x000000018AAB927C
		public void WriteBoneToTransform(int bufferIndex) {} // 0x0000000185FCED40-0x0000000185FCED90
		public void CopyBoneBuffer() {} // 0x0000000185FCED90-0x0000000185FCEDB0
	}

	public class PhysicsManagerComponent : PhysicsManagerAccess // TypeDefIndex: 52437
	{
		// Fields
		private readonly HashSet<CoreComponent> componentSet; // 0x18
		private HashSet<ParticleComponent> dataUpdateParticleSet; // 0x20
	
		// Properties
		public int ComponentCount { get => default; } // 0x000000018AAAD544-0x000000018AAAD584 
	
		// Constructors
		public PhysicsManagerComponent() {} // 0x000000018588C900-0x000000018588C9C0
	
		// Methods
		public override void Create() {} // 0x0000000185492010-0x0000000185492020
		public override void Dispose() {} // 0x0000000185492010-0x0000000185492020
		public List<CoreComponent> GetComponentList() => default; // 0x000000018AAAD298-0x000000018AAAD30C
		public void ComponentAction(Action<CoreComponent> act) {} // 0x000000018AAAD148-0x000000018AAAD298
		public void UpdateComponentStatus() {} // 0x000000018AAAD3E0-0x000000018AAAD544
		public void AddComponent(CoreComponent comp) {} // 0x000000018AAAD0F4-0x000000018AAAD148
		public void RemoveComponent(CoreComponent comp) {} // 0x000000018AAAD30C-0x000000018AAAD38C
		internal void ReserveDataUpdateParticleComponent(ParticleComponent comp) {} // 0x000000018AAAD38C-0x000000018AAAD3E0
		internal void DataUpdateParticleComponent() {} // 0x000000018440AD90-0x000000018440AEE0
	}

	public class PhysicsManagerCompute : PhysicsManagerAccess // TypeDefIndex: 52441
	{
		// Fields
		private int solverIteration; // 0x18
		private List<PhysicsManagerConstraint> constraints; // 0x20
		private ClampPositionConstraint _ClampPosition_k__BackingField; // 0x28
		private ClampDistanceConstraint _ClampDistance_k__BackingField; // 0x30
		private ClampRotationConstraint _ClampRotation_k__BackingField; // 0x38
		private SpringConstraint _Spring_k__BackingField; // 0x40
		private RestoreDistanceConstraint _RestoreDistance_k__BackingField; // 0x48
		private RestoreRotationConstraint _RestoreRotation_k__BackingField; // 0x50
		private TriangleBendConstraint _TriangleBend_k__BackingField; // 0x58
		private ColliderCollisionConstraint _Collision_k__BackingField; // 0x60
		private PenetrationConstraint _Penetration_k__BackingField; // 0x68
		private ColliderExtrusionConstraint _ColliderExtrusion_k__BackingField; // 0x70
		private TwistConstraint _Twist_k__BackingField; // 0x78
		private CompositeRotationConstraint _CompositeRotation_k__BackingField; // 0x80
		private List<PhysicsManagerWorker> workers; // 0x88
		private RenderMeshWorker _RenderMeshWorker_k__BackingField; // 0x90
		private VirtualMeshWorker _VirtualMeshWorker_k__BackingField; // 0x98
		private MeshParticleWorker _MeshParticleWorker_k__BackingField; // 0xA0
		private SpringMeshWorker _SpringMeshWorker_k__BackingField; // 0xA8
		private AdjustRotationWorker _AdjustRotationWorker_k__BackingField; // 0xB0
		private LineWorker _LineWorker_k__BackingField; // 0xB8
		private TriangleWorker _TriangleWorker_k__BackingField; // 0xC0
		private BaseSkinningWorker _BaseSkinningWorker_k__BackingField; // 0xC8
		private JobHandle jobHandle; // 0xD0
		private bool runMasterJob; // 0xE0
		private int swapIndex; // 0xE4
		private CustomSampler _SamplerCalcMesh_k__BackingField; // 0xE8
		private CustomSampler _SamplerWriteMesh_k__BackingField; // 0xF0
	
		// Properties
		public ClampPositionConstraint ClampPosition { get; private set; } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
		public ClampDistanceConstraint ClampDistance { get; private set; } // 0x00000001813FF010-0x00000001813FF020 0x0000000185F05C80-0x0000000185F05C90
		public ClampRotationConstraint ClampRotation { get; private set; } // 0x00000001813ECF20-0x00000001813ECF30 0x000000018571FEC0-0x000000018571FED0
		public SpringConstraint Spring { get; private set; } // 0x0000000181460F60-0x0000000181460F70 0x0000000184A4E570-0x0000000184A4E580
		public RestoreDistanceConstraint RestoreDistance { get; private set; } // 0x00000001813F1630-0x00000001813F1640 0x0000000186472DB0-0x0000000186472DC0
		public RestoreRotationConstraint RestoreRotation { get; private set; } // 0x0000000185FB0530-0x0000000185FB0540 0x0000000185AE8FE0-0x0000000185AE8FF0
		public TriangleBendConstraint TriangleBend { get; private set; } // 0x00000001813AC280-0x00000001813AC290 0x0000000185A62990-0x0000000185A629A0
		public ColliderCollisionConstraint Collision { get; private set; } // 0x0000000181460F70-0x0000000181460F80 0x00000001874BE90C-0x00000001874BE91C
		public PenetrationConstraint Penetration { get; private set; } // 0x0000000183060C50-0x0000000183060C60 0x000000018738A324-0x000000018738A334
		public ColliderExtrusionConstraint ColliderExtrusion { get; private set; } // 0x000000018140CF50-0x000000018140CF60 0x00000001873CBE98-0x00000001873CBEA8
		public TwistConstraint Twist { get; private set; } // 0x0000000181B5FFD0-0x0000000181B5FFE0 0x00000001873CBEA8-0x00000001873CBEBC
		public CompositeRotationConstraint CompositeRotation { get; private set; } // 0x0000000181E336C0-0x0000000181E336D0 0x00000001873350D4-0x00000001873350E8
		public RenderMeshWorker RenderMeshWorker { get; private set; } // 0x0000000185FB0520-0x0000000185FB0530 0x000000018646EBCC-0x000000018646EBE0
		public VirtualMeshWorker VirtualMeshWorker { get; private set; } // 0x000000018349D730-0x000000018349D740 0x000000018774BD8C-0x000000018774BDA0
		public MeshParticleWorker MeshParticleWorker { get; private set; } // 0x000000018346D8F0-0x000000018346D900 0x0000000184784C70-0x0000000184784C90
		public SpringMeshWorker SpringMeshWorker { get; private set; } // 0x000000018349D710-0x000000018349D720 0x0000000187A47500-0x0000000187A47514
		public AdjustRotationWorker AdjustRotationWorker { get; private set; } // 0x0000000181B388F0-0x0000000181B38900 0x0000000187A47C1C-0x0000000187A47C30
		public LineWorker LineWorker { get; private set; } // 0x0000000185FB0300-0x0000000185FB0310 0x0000000187A47C30-0x0000000187A47C44
		public TriangleWorker TriangleWorker { get; private set; } // 0x0000000185FB2360-0x0000000185FB2370 0x0000000187A47730-0x0000000187A47744
		public BaseSkinningWorker BaseSkinningWorker { get; private set; } // 0x0000000185FB87A0-0x0000000185FB87B0 0x0000000187A47A14-0x0000000187A47A28
		public CustomSampler SamplerCalcMesh { get; set; } // 0x0000000184B2F490-0x0000000184B30A90 0x000000018AAAD584-0x000000018AAAD7A8
		public CustomSampler SamplerWriteMesh { get; set; } // 0x000000018AAADC38-0x000000018AAADEE0 0x000000018AAAED34-0x000000018AAAED88
		public JobHandle MasterJob { get => default; set {} } // 0x0000000184407910-0x0000000184407960 0x0000000185FB2330-0x0000000185FB2340
		public int SwapIndex { get => default; } // 0x000000018588C9C0-0x000000018588CA90 
	
		// Nested types
		private struct ForceAndVelocityJob : IJobParallelFor // TypeDefIndex: 52438
		{
			// Fields
			public float updateDeltaTime; // 0x00
			public float updatePower; // 0x04
			public int runCount; // 0x08
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x10
			public NativeArray<CurveParam> teamMassList; // 0x20
			public NativeArray<CurveParam> teamGravityList; // 0x30
			public NativeArray<CurveParam> teamDragList; // 0x40
			public NativeArray<CurveParam> teamDepthInfluenceList; // 0x50
			public NativeArray<PhysicsManagerTeamData.WindInfo> teamWindInfoList; // 0x60
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x70
			public NativeArray<int> teamIdList; // 0x80
			public NativeArray<float> depthList; // 0x90
			public NativeArray<float3> snapBasePosList; // 0xA0
			public NativeArray<quaternion> snapBaseRotList; // 0xB0
			public NativeArray<float3> basePosList; // 0xC0
			public NativeArray<quaternion> baseRotList; // 0xD0
			public NativeArray<float3> oldBasePosList; // 0xE0
			public NativeArray<quaternion> oldBaseRotList; // 0xF0
			public NativeArray<float3> nextPosList; // 0x100
			public NativeArray<quaternion> nextRotList; // 0x110
			public NativeArray<float> frictionList; // 0x120
			public NativeArray<float3> posList; // 0x130
			public NativeArray<quaternion> rotList; // 0x140
			public NativeArray<float3> oldPosList; // 0x150
			public NativeArray<quaternion> oldRotList; // 0x160
			public NativeArray<float3> velocityList; // 0x170
			public NativeArray<PhysicsManagerWindData.WindData> windDataList; // 0x180
			public NativeArray<float3> bonePosList; // 0x190
			public NativeArray<quaternion> boneRotList; // 0x1A0
	
			// Methods
			public void Execute(int index) {} // 0x00000001813B8590-0x00000001813B85A0
			private float3 Wind(int teamId, in PhysicsManagerTeamData.TeamData teamData, in float3 pos) => default; // 0x0000000184A4EDC0-0x0000000184A4EDD0
		}
	
		private struct FixPositionJob : IJobParallelFor // TypeDefIndex: 52439
		{
			// Fields
			public float updatePower; // 0x00
			public float updateDeltaTime; // 0x04
			public int runCount; // 0x08
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x10
			public NativeArray<CurveParam> teamMaxVelocityList; // 0x20
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x30
			public NativeArray<int> teamIdList; // 0x40
			public NativeArray<float> depthList; // 0x50
			public NativeArray<float3> nextPosList; // 0x60
			public NativeArray<quaternion> nextRotList; // 0x70
			public NativeArray<float> frictionList; // 0x80
			public NativeArray<float3> velocityList; // 0x90
			public NativeArray<quaternion> rotList; // 0xA0
			public NativeArray<float3> oldPosList; // 0xB0
			public NativeArray<quaternion> oldRotList; // 0xC0
			public NativeArray<float3> posList; // 0xD0
			public NativeArray<float3> localPosList; // 0xE0
			public NativeArray<float3> collisionNormalList; // 0xF0
			public NativeArray<float> staticFrictionList; // 0x100
	
			// Methods
			public void Execute(int index) {} // 0x00000001813B51D0-0x00000001813B51E0
		}
	
		private struct PostUpdatePhysicsJob : IJobParallelFor // TypeDefIndex: 52440
		{
			// Fields
			public float updateDeltaTime; // 0x00
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x08
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x18
			public NativeArray<int> teamIdList; // 0x28
			public NativeArray<float3> snapBasePosList; // 0x38
			public NativeArray<quaternion> snapBaseRotList; // 0x48
			public NativeArray<float3> basePosList; // 0x58
			public NativeArray<quaternion> baseRotList; // 0x68
			public NativeArray<float3> oldBasePosList; // 0x78
			public NativeArray<quaternion> oldBaseRotList; // 0x88
			public NativeArray<float3> velocityList; // 0x98
			public NativeArray<float3> localPosList; // 0xA8
			public NativeArray<float3> oldPosList; // 0xB8
			public NativeArray<quaternion> oldRotList; // 0xC8
			public NativeArray<float3> posList; // 0xD8
			public NativeArray<quaternion> rotList; // 0xE8
			public NativeArray<float3> nextPosList; // 0xF8
			public NativeArray<quaternion> nextRotList; // 0x108
			public NativeArray<float3> oldSlowPosList; // 0x118
	
			// Methods
			public void Execute(int index) {} // 0x00000001864721F0-0x0000000186472200
		}
	
		// Constructors
		public PhysicsManagerCompute() {} // 0x000000018AAB7C58-0x000000018AAB81F4
	
		// Methods
		public override void Create() {} // 0x0000000184407C90-0x0000000184407CE0
		public override void Dispose() {} // 0x0000000184407CE0-0x0000000184407D20
		public void RemoveTeam(int teamId) {} // 0x0000000184407D20-0x0000000184407E70
		internal void UpdateRestoreBone(PhysicsTeam.TeamUpdateMode updateMode) {} // 0x0000000184407BD0-0x0000000184407C90
		internal void UpdateReadBone() {} // 0x000000018440AA60-0x000000018440AAC0
		internal void UpdateTeamAlways() {} // 0x00000001844094C0-0x00000001844095A0
		internal void UpdateStartSimulation(UpdateTimeManager update) {} // 0x0000000184407B30-0x0000000184407BD0
		internal void UpdateCompleteSimulation() {} // 0x000000018AAAECB4-0x000000018AAAED34
		internal void UpdateWriteBone() {} // 0x000000018AAAEF04-0x000000018AAAF030
		internal void MeshCalculation() {} // 0x000000018AAAED88-0x000000018AAAEF04
		internal void NormalWritingMesh() {} // 0x0000000185FBC8B0-0x0000000185FBC8C0
		internal void UpdateReadWriteBone() {} // 0x0000000185FBC8C0-0x0000000185FBC8D0
		internal void UpdateSyncBuffer() {} // 0x0000000185FCEE50-0x0000000185FCEE60
		internal void UpdateSwapBuffer() {} // 0x000000018AAADEE0-0x000000018AAADEE8
		public void InitJob() {} // 0x000000018AAADEE8-0x000000018AAAECB4
		public void ScheduleJob() {} // 0x000000018AAAD7A8-0x000000018AAADC38
		public void CompleteJob() {} // 0x000000018AAAF030-0x000000018AAAF0C8
		private void UpdatePhysics(int updateCount, int runCount, float updatePower, float updateDeltaTime) {} // 0x000000018AAAAACC-0x000000018AAAB4D4
		private void PostUpdatePhysics(float updateDeltaTime) {} // 0x000000018AAAB4D4-0x000000018AAAB6C4
		private void WarmupWorker() {} // 0x000000018AAAA2D0-0x000000018AAAAACC
	}

	public abstract class PhysicsManagerConstraint // TypeDefIndex: 52442
	{
		// Fields
		public int iteration; // 0x10
		private MagicaPhysicsManager _Manager_k__BackingField; // 0x18
	
		// Properties
		public MagicaPhysicsManager Manager { get; set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		protected PhysicsManagerConstraint() {} // 0x00000001830836C0-0x00000001830836D0
	
		// Methods
		public void Init(MagicaPhysicsManager manager) {} // 0x0000000184B30A90-0x0000000184B30AC0
		public abstract void Create();
		public abstract void RemoveTeam(int teamId);
		public abstract void Release();
		public virtual int GetIterationCount() => default; // 0x0000000181C0BBD0-0x0000000181C0BBE0
		public abstract JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle);
	}

	public class PhysicsManagerMeshData : PhysicsManagerAccess // TypeDefIndex: 52451
	{
		// Fields
		public const uint MeshFlag_Active = 1; // Metadata: 0x0207677F
		public const uint MeshFlag_Skinning = 4; // Metadata: 0x02076780
		public const uint Meshflag_CalcNormal = 8; // Metadata: 0x02076781
		public const uint Meshflag_CalcTangent = 16; // Metadata: 0x02076782
		public const uint Meshflag_Pause = 32; // Metadata: 0x02076783
		public const uint MeshFlag_ExistNormals = 65536; // Metadata: 0x02076784
		public const uint MeshFlag_ExistTangents = 131072; // Metadata: 0x02076788
		public const uint MeshFlag_ExistWeights = 262144; // Metadata: 0x0207678C
		public const uint MeshFlag_UpdateUseVertexFront = 16777216; // Metadata: 0x02076790
		public const uint MeshFlag_UpdateUseVertexBack = 33554432; // Metadata: 0x02076794
		public const uint MeshFlag_FasterWrite = 67108864; // Metadata: 0x02076798
		public const uint MeshFlag_MeshLink = 268435456; // Metadata: 0x0207679C
		public FixedNativeList<SharedVirtualMeshInfo> sharedVirtualMeshInfoList; // 0x18
		public Dictionary<int, int> sharedVirtualMeshIdToIndexDict; // 0x20
		public FixedChunkNativeArray<float2> sharedVirtualUvList; // 0x28
		public FixedChunkNativeArray<uint> sharedVirtualVertexInfoList; // 0x30
		public FixedChunkNativeArray<MeshData.VertexWeight> sharedVirtualWeightList; // 0x38
		public FixedChunkNativeArray<int> sharedVirtualTriangleList; // 0x40
		public FixedChunkNativeArray<uint> sharedVirtualVertexToTriangleInfoList; // 0x48
		public FixedChunkNativeArray<int> sharedVirtualVertexToTriangleIndexList; // 0x50
		public const byte VirtualVertexFlag_Use = 1; // Metadata: 0x020767A0
		public FixedNativeList<VirtualMeshInfo> virtualMeshInfoList; // 0x58
		public FixedChunkNativeArray<short> virtualVertexMeshIndexList; // 0x60
		public FixedChunkNativeArray<byte> virtualVertexUseList; // 0x68
		public FixedChunkNativeArray<byte> virtualVertexFixList; // 0x70
		public FixedChunkNativeArray<byte> virtualVertexFlagList; // 0x78
		public FixedChunkNativeArray<float3> virtualPosList; // 0x80
		public FixedChunkNativeArray<quaternion> virtualRotList; // 0x88
		public FixedChunkNativeArray<int> virtualTransformIndexList; // 0x90
		public FixedChunkNativeArray<float3> virtualTriangleNormalList; // 0x98
		public FixedChunkNativeArray<float3> virtualTriangleTangentList; // 0xA0
		public FixedChunkNativeArray<ushort> virtualTriangleMeshIndexList; // 0xA8
		public FixedNativeList<SharedChildMeshInfo> sharedChildMeshInfoList; // 0xB0
		public Dictionary<long, int> sharedChildMeshIdToSharedVirtualMeshIndexDict; // 0xB8
		public FixedChunkNativeArray<uint> sharedChildVertexInfoList; // 0xC0
		public FixedChunkNativeArray<MeshData.VertexWeight> sharedChildWeightList; // 0xC8
		public FixedNativeList<SharedRenderMeshInfo> sharedRenderMeshInfoList; // 0xD0
		public Dictionary<int, int> sharedRenderMeshIdToIndexDict; // 0xD8
		public FixedChunkNativeArray<float3> sharedRenderVertices; // 0xE0
		public FixedChunkNativeArray<float3> sharedRenderNormals; // 0xE8
		public FixedChunkNativeArray<float4> sharedRenderTangents; // 0xF0
		public FixedChunkNativeArray<byte> sharedBonesPerVertexList; // 0xF8
		public FixedChunkNativeArray<int> sharedBonesPerVertexStartList; // 0x100
		public FixedChunkNativeArray<BoneWeight1> sharedBoneWeightList; // 0x108
		public const uint RenderVertexFlag_Use = 65536; // Metadata: 0x020767A1
		public const int MaxRenderMeshLinkCount = 4; // Metadata: 0x020767A5
		public FixedNativeList<RenderMeshInfo> renderMeshInfoList; // 0x110
		public const uint RenderStateFlag_Use = 1; // Metadata: 0x020767A6
		public const uint RenderStateFlag_ExistNormal = 2; // Metadata: 0x020767A7
		public const uint RenderStateFlag_ExistTangent = 4; // Metadata: 0x020767A8
		public const uint RenderStateFlag_FasterWrite = 8; // Metadata: 0x020767A9
		public const uint RenderStateFlag_DelayedCalculated = 256; // Metadata: 0x020767AA
		public Dictionary<int, RenderMeshState> renderMeshStateDict; // 0x118
		public FixedChunkNativeArray<uint> renderVertexFlagList; // 0x120
		public FixedChunkNativeArray<float3> renderPosList; // 0x128
		public FixedChunkNativeArray<float3> renderNormalList; // 0x130
		public FixedChunkNativeArray<float4> renderTangentList; // 0x138
		public FixedChunkNativeArray<BoneWeight1> renderBoneWeightList; // 0x140
		internal DoubleComputeBuffer<float3> renderPosBuffer; // 0x148
		internal DoubleComputeBuffer<float3> renderNormalBuffer; // 0x150
		internal ComputeBuffer emptyByteAddressBuffer; // 0x158
		private bool isBeginWrite; // 0x160
		private HashSet<BaseMeshDeformer> renderMeshSet; // 0x168
		private List<RenderMeshDeformer> normalWriteList; // 0x170
		private List<RenderMeshDeformer> fasterWritePositionList; // 0x178
		private List<RenderMeshDeformer> fasterWritePositionNormalList; // 0x180
	
		// Properties
		public int SharedVirtualMeshCount { get => default; } // 0x000000018AAB4124-0x000000018AAB4318 
		public int VirtualMeshCount { get => default; } // 0x000000018AAAFB60-0x000000018AAAFD20 
		public int VirtualMeshVertexCount { get => default; } // 0x000000018AAB33F0-0x000000018AAB35B0 
		public int VirtualMeshTriangleCount { get => default; } // 0x000000018AAB2694-0x000000018AAB2898 
		public int VirtualMeshVertexUseCount { get => default; } // 0x000000018AAB4EA8-0x000000018AAB50D8 
		public int VirtualMeshUseCount { get => default; } // 0x000000018AAB0CA8-0x000000018AAB0D98 
		public int VirtualMeshPauseCount { get => default; } // 0x000000018AAB0B14-0x000000018AAB0CA8 
		public int SharedRenderMeshCount { get => default; } // 0x000000018AAB5708-0x000000018AAB57E0 
		public int SharedChildMeshCount { get => default; } // 0x000000018AAB55B0-0x000000018AAB5708 
		public int RenderMeshCount { get => default; } // 0x00000001864726A8-0x00000001864726B0 
		public int RenderMeshVertexCount { get => default; } // 0x000000018AAB8B50-0x000000018AAB8B60 
		public int RenderMeshUseCount { get => default; } // 0x000000018AAB8B38-0x000000018AAB8B50 
		public int RenderMeshVertexUseCount { get => default; } // 0x00000001876E65D4-0x00000001876E65DC 
		public int RenderMeshPauseCount { get => default; } // 0x000000018AAB8B24-0x000000018AAB8B30 
	
		// Nested types
		public struct SharedVirtualMeshInfo // TypeDefIndex: 52443
		{
			// Fields
			public int uid; // 0x00
			public int useCount; // 0x04
			public int sharedChildMeshStartIndex; // 0x08
			public int sharedChildMeshCount; // 0x0C
			public ChunkData vertexChunk; // 0x10
			public ChunkData weightChunk; // 0x20
			public ChunkData triangleChunk; // 0x30
			public ChunkData vertexToTriangleChunk; // 0x40
		}
	
		public struct VirtualMeshInfo // TypeDefIndex: 52444
		{
			// Fields
			public uint flag; // 0x00
			public int sharedVirtualMeshIndex; // 0x04
			public int meshUseCount; // 0x08
			public int vertexUseCount; // 0x0C
			public ChunkData vertexChunk; // 0x10
			public ChunkData boneChunk; // 0x20
			public ChunkData triangleChunk; // 0x30
			public int transformIndex; // 0x40
	
			// Methods
			public bool IsFlag(uint flag) => default; // 0x000000018558EBE0-0x000000018558F5C0
			public void SetFlag(uint flag, bool sw) {} // 0x000000018AAB1A74-0x000000018AAB1F38
			public bool IsActive() => default; // 0x000000018AAAF0C8-0x000000018AAAF140
			public bool IsUse() => default; // 0x000000018AAB2BF4-0x000000018AAB2C78
			public bool IsPause() => default; // 0x000000018AAB0160-0x000000018AAB0708
		}
	
		public struct SharedChildMeshInfo // TypeDefIndex: 52445
		{
			// Fields
			public long cuid; // 0x00
			public int sharedVirtualMeshIndex; // 0x08
			public int virtualMeshIndex; // 0x0C
			public int meshUseCount; // 0x10
			public ChunkData vertexChunk; // 0x14
			public ChunkData weightChunk; // 0x24
		}
	
		public struct SharedRenderMeshInfo // TypeDefIndex: 52446
		{
			// Fields
			public int uid; // 0x00
			public int useCount; // 0x04
			public uint flag; // 0x08
			public ChunkData vertexChunk; // 0x0C
			public ChunkData bonePerVertexChunk; // 0x1C
			public ChunkData boneWeightsChunk; // 0x2C
			public int rendererBoneIndex; // 0x3C
	
			// Methods
			public bool IsFlag(uint flag) => default; // 0x000000018AAB2450-0x000000018AAB24A8
			public void SetFlag(uint flag, bool sw) {} // 0x000000018AAB4A2C-0x000000018AAB4CCC
			public bool IsSkinning() => default; // 0x000000018AAB39F0-0x000000018AAB3EBC
		}
	
		public struct RenderMeshInfo // TypeDefIndex: 52447
		{
			// Fields
			public uint flag; // 0x00
			public int renderSharedMeshIndex; // 0x04
			public int sharedRenderMeshVertexStartIndex; // 0x08
			public int meshUseCount; // 0x0C
			public int4 childMeshVertexStartIndex; // 0x10
			public int4 childMeshWeightStartIndex; // 0x20
			public int4 virtualMeshVertexStartIndex; // 0x30
			public int4 sharedVirtualMeshVertexStartIndex; // 0x40
			public int4 linkMeshCount; // 0x50
			public ChunkData vertexChunk; // 0x60
			public ChunkData boneWeightsChunk; // 0x70
			public int transformIndex; // 0x80
			public float baseScale; // 0x84
	
			// Methods
			public bool IsFlag(uint flag) => default; // 0x000000018AAB1F38-0x000000018AAB1F8C
			public void SetFlag(uint flag, bool sw) {} // 0x000000018AAB21FC-0x000000018AAB2284
			public bool IsActive() => default; // 0x000000018AAB2604-0x000000018AAB2694
			public bool IsUse() => default; // 0x000000018AAB2340-0x000000018AAB239C
			public bool IsLinkMesh(int index) => default; // 0x000000018AAB4CCC-0x000000018AAB4DB4
			public bool IsPause() => default; // 0x000000018AAAFD20-0x000000018AAAFDFC
			public bool IsFasterWrite() => default; // 0x000000018AAB35B0-0x000000018AAB368C
			public bool IsSkinning() => default; // 0x000000018AAAFDFC-0x000000018AAAFF70
			public bool AddLinkMesh(int renderMeshIndex, int childMeshVertexStart, int childMeshWeightStart, int virtualMeshVertexStart, int sharedVirtualMeshVertexStart) => default; // 0x000000018AAB368C-0x000000018AAB3800
			public bool RemoveLinkMesh(int renderMeshIndex, int childMeshVertexStart, int childMeshWeightStart, int virtualMeshVertexStart, int sharedVirtualMeshVertexStart) => default; // 0x000000018AAB13B0-0x000000018AAB160C
		}
	
		public class RenderMeshState // TypeDefIndex: 52448
		{
			// Fields
			public uint flag; // 0x10
			public int RenderSharedMeshIndex; // 0x14
			public int RenderSharedMeshId; // 0x18
			public int VertexChunkStart; // 0x1C
			public int VertexChunkLength; // 0x20
			public int BoneWeightChunkStart; // 0x24
			public int BoneWeightChunkLength; // 0x28
	
			// Constructors
			public RenderMeshState() {} // 0x000000018AAB3EBC-0x000000018AAB3FBC
	
			// Methods
			public bool IsFlag(uint flag) => default; // 0x000000018AAAFF70-0x000000018AAB0160
			public void SetFlag(uint flag, bool sw) {} // 0x000000018AAB3800-0x000000018AAB39F0
		}
	
		private struct CopyRenderBuffer : IJobParallelFor // TypeDefIndex: 52449
		{
			// Fields
			public NativeArray<float3> renderPosList; // 0x00
			public NativeArray<float3> renderNormalList; // 0x10
			public NativeArray<float3> renderPosArray; // 0x20
			public NativeArray<float3> renderNormalArray; // 0x30
	
			// Methods
			public void Execute(int index) {} // 0x000000018AAB0844-0x000000018AAB0990
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 52450
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<RenderMeshDeformer> __9__158_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018AAB4DB4-0x000000018AAB4EA8
			public __c() {} // 0x000000018AAB59B4-0x000000018AAB59FC
	
			// Methods
			internal int _DispatchWriting_b__158_0(RenderMeshDeformer a, RenderMeshDeformer b) => default; // 0x000000018440AAC0-0x000000018440AB30
		}
	
		// Constructors
		public PhysicsManagerMeshData() {} // 0x000000018AAB8D3C-0x000000018AAB8D6C
	
		// Methods
		public override void Create() {} // 0x000000018AAB5BC0-0x000000018AAB5C3C
		public override void Dispose() {} // 0x000000018AAB5AA0-0x000000018AAB5B1C
		public void AddMesh(BaseMeshDeformer bmesh) {} // 0x000000018AAB5C3C-0x000000018AAB5CC4
		public void RemoveMesh(BaseMeshDeformer bmesh) {} // 0x000000018AAB5B1C-0x000000018AAB5BC0
		public int AddVirtualMesh(int uid, int vertexCount, int weightCount, int boneCount, int triangleCount, int vertexToTriangleIndexCount, Transform transform) => default; // 0x000000018AAB59FC-0x000000018AAB5AA0
		public bool IsEmptySharedVirtualMesh(int uid) => default; // 0x000000018AAAF8D0-0x000000018AAAFB60
		public void SetSharedVirtualMeshData(int virtualMeshIndex, uint[] sharedVertexInfoList, MeshData.VertexWeight[] sharedWeightList, Vector2[] sharedUv, int[] sharedTriangles, uint[] vertexToTriangleInfoList, int[] vertexToTriangleIndexList) {} // 0x000000018AAB239C-0x000000018AAB23F8
		public void RemoveVirtualMesh(int virtualMeshIndex) {} // 0x000000018AAB4914-0x000000018AAB4A2C
		public bool ExistsVirtualMesh(int virtualMeshIndex) => default; // 0x000000018AAB327C-0x000000018AAB33F0
		public VirtualMeshInfo GetVirtualMeshInfo(int virtualMeshIndex) => default; // 0x000000018AAB596C-0x000000018AAB59B4
		public bool IsUseVirtualMesh(int virtualMeshIndex) => default; // 0x000000018AAB5924-0x000000018AAB596C
		public bool IsActiveVirtualMesh(int virtualMeshIndex) => default; // 0x000000018AAAF2B0-0x000000018AAAF8D0
		public void SetVirtualMeshActive(int virtualMeshIndex, bool sw) {} // 0x000000018AAB50D8-0x000000018AAB5190
		public void AddUseVirtualMesh(int virtualMeshIndex) {} // 0x000000018AAAF140-0x000000018AAAF2B0
		public void RemoveUseVirtualMesh(int virtualMeshIndex) {} // 0x000000018AAB23F8-0x000000018AAB2450
		public bool AddUseVirtualVertex(int virtualMeshIndex, int vindex, bool fix) => default; // 0x000000018AAB4498-0x000000018AAB4914
		public bool RemoveUseVirtualVertex(int virtualMeshIndex, int vindex, bool fix) => default; // 0x000000018AAB2DDC-0x000000018AAB327C
		public void CopyToVirtualMeshWorldData(int virtualMeshIndex, Vector3[] vertices, Vector3[] normals, Vector3[] tangents) {} // 0x000000018AAB2C78-0x000000018AAB2DDC
		public void AddVirtualMeshBone(int virtualMeshIndex, List<Transform> boneList) {} // 0x000000018AAB0708-0x000000018AAB0844
		public void RemoveVirtualMeshBone(int virtualMeshIndex) {} // 0x000000018AAB25A0-0x000000018AAB2604
		public void ResetFuturePredictionVirtualMeshBone(int virtualMeshIndex) {} // 0x000000018AAB2284-0x000000018AAB2340
		public void ChangeVirtualMeshUseUnityPhysics(int virtualMeshIndex, bool sw) {} // 0x000000018AAB4318-0x000000018AAB4498
		public void SetVirtualMeshFlag(int virtualMeshIndex, uint flag, bool sw) {} // 0x000000018AAB24A8-0x000000018AAB25A0
		public int AddSharedChildMesh(long cuid, int virtualMeshIndex, int vertexCount, int weightCount) => default; // 0x000000018AAB0990-0x000000018AAB0B14
		public bool IsEmptySharedChildMesh(long cuid) => default; // 0x000000018AAB0D98-0x000000018AAB1108
		public void SetSharedChildMeshData(int sharedMeshIndex, uint[] sharedVertexInfoList, MeshData.VertexWeight[] sharedVertexWeightList) {} // 0x000000018AAB2030-0x000000018AAB21FC
		public void RemoveSharedChildMesh(int sharedChildMeshIndex) {} // 0x000000018AAB541C-0x000000018AAB5464
		public int AddRenderMesh(int uid, bool isSkinning, bool isFasterWrite, Vector3 baseScale, int vertexCount, int rendererBoneIndex, int boneWeightCount) => default; // 0x000000018AAB57E0-0x000000018AAB5924
		public void UpdateMeshState(int renderMeshIndex) {} // 0x000000018AAB5464-0x000000018AAB55B0
		public void AddRenderMeshBone(int renderMeshIndex, Transform rendererTransform) {} // 0x000000018AAB3FBC-0x000000018AAB4124
		public bool IsEmptySharedRenderMesh(int uid) => default; // 0x000000018440AEE0-0x000000018440B1D0
		public void SetRenderSharedMeshData(int renderMeshIndex, bool isSkinning, Vector3[] sharedVertices, Vector3[] sharedNormals, Vector4[] sharedTangents, NativeArray<byte> sharedBonesPerVertex, NativeArray<BoneWeight1> sharedBoneWeights) {} // 0x000000018AAB2898-0x000000018AAB2A8C
		public void RemoveRenderMesh(int renderMeshIndex) {} // 0x000000018AAB2A8C-0x000000018AAB2BF4
		public void RemoveRenderMeshBone(int renderMeshIndex) {} // 0x000000018AAB1108-0x000000018AAB13B0
		public void ChangeRenderMeshUseUnityPhysics(int renderMeshIndex, bool sw) {} // 0x000000018AAB5190-0x000000018AAB541C
		public bool IsUseRenderMesh(int renderMeshIndex) => default; // 0x00000001844079F0-0x0000000184407A40
		public bool IsActiveRenderMesh(int renderMeshIndex) => default; // 0x000000018AAB1F8C-0x000000018AAB2030
		public void SetRenderMeshFlag(int renderMeshIndex, uint flag, bool sw) {} // 0x000000018AAB160C-0x000000018AAB1A74
		public bool IsRenderMeshFlag(int renderMeshIndex, uint flag) => default; // 0x000000018588CA90-0x000000018588CD00
		public void SetRenderMeshActive(int renderMeshIndex, bool sw) {} // 0x000000018AAB8B30-0x000000018AAB8B38
		public void AddUseRenderMesh(int renderMeshIndex) {} // 0x000000018AAB8C00-0x000000018AAB8C14
		public void RemoveUseRenderMesh(int renderMeshIndex) {} // 0x00000001864726A8-0x00000001864726B0
		public void LinkRenderMesh(int renderMeshIndex, int childMeshVertexStart, int childMeshWeightStart, int virtualMeshVertexStart, int sharedVirtualMeshVertexStart) {} // 0x000000018AAB8DD0-0x000000018AAB8DE8
		public void UnlinkRenderMesh(int renderMeshIndex, int childMeshVertexStart, int childMeshWeightStart, int virtualMeshVertexStart, int sharedVirtualMeshVertexStart) {} // 0x00000001876E65D4-0x00000001876E65DC
		internal void CopyToRenderMeshLocalPositionData(int renderMeshIndex, Mesh mesh, int bufferIndex) {} // 0x000000018AAB8D14-0x000000018AAB8D1C
		internal void CopyToRenderMeshLocalNormalTangentData(int renderMeshIndex, Mesh mesh, int bufferIndex, bool normal, bool tangent) {} // 0x000000018AAB8D24-0x000000018AAB8D3C
		internal void CopyToRenderMeshBoneWeightData(int renderMeshIndex, Mesh mesh, Mesh sharedMesh, int bufferIndex) {} // 0x000000018AAB8D1C-0x000000018AAB8D24
		internal void CopyToRenderMeshWorldData(int renderMeshIndex, Transform target, Vector3[] vertices, Vector3[] normals, Vector3[] tangents) {} // 0x000000018AAB8B30-0x000000018AAB8B38
		internal List<int> GetVertexUseList(int renderMeshIndex) => default; // 0x000000018AAB8C00-0x000000018AAB8C14
		internal void SetDelayedCalculatedFlag() {} // 0x00000001876E65CC-0x00000001876E65D4
		internal void ClearWritingList() {} // 0x000000018AAB8A64-0x000000018AAB8B24
		internal void MeshCalculation(int bufferIndex) {} // 0x000000018AAB8B60-0x000000018AAB8C00
		internal void NormalWriting(int bufferIndex) {} // 0x0000000187F2115C-0x0000000187F21164
		internal void CopyToRenderVertexBuffer(int renderMeshIndex, int bufferIndex, GraphicsBuffer vertexBuffer, bool normal, ComputeShader compute, int kernel, int index) {} // 0x000000018AAB8C14-0x000000018AAB8C2C
		internal void UpdateVertexBuffer() {} // 0x0000000185492010-0x0000000185492020
		internal void FinishVertexBuffer() {} // 0x0000000185FCEDD0-0x0000000185FCEE30
		internal void FasterWriting(int bufferIndex) {} // 0x000000018AAB8D6C-0x000000018AAB8DD0
		private void DispatchWriting(int kernel, List<RenderMeshDeformer> rlist, int bufferIndex) {} // 0x0000000185492010-0x0000000185492020
	}

	public class PhysicsManagerParticleData : PhysicsManagerAccess // TypeDefIndex: 52456
	{
		// Fields
		public const uint Flag_Enable = 1; // Metadata: 0x020767AC
		public const uint Flag_Kinematic = 2; // Metadata: 0x020767AD
		public const uint Flag_Hold = 4; // Metadata: 0x020767AE
		public const uint Flag_Collider = 16; // Metadata: 0x020767AF
		public const uint Flag_Plane = 32; // Metadata: 0x020767B0
		public const uint Flag_CapsuleX = 64; // Metadata: 0x020767B1
		public const uint Flag_CapsuleY = 128; // Metadata: 0x020767B2
		public const uint Flag_CapsuleZ = 256; // Metadata: 0x020767B4
		public const uint Flag_Box = 512; // Metadata: 0x020767B6
		public const uint Flag_TriangleRotation = 1024; // Metadata: 0x020767B8
		public const uint Flag_Transform_Read_Pos = 4096; // Metadata: 0x020767BA
		public const uint Flag_Transform_Read_Rot = 8192; // Metadata: 0x020767BC
		public const uint Flag_Transform_Read_Base = 16384; // Metadata: 0x020767BE
		public const uint Flag_Transform_Read_Local = 32768; // Metadata: 0x020767C2
		public const uint Flag_Transform_Read_Scl = 65536; // Metadata: 0x020767C6
		public const uint Flag_Transform_Write = 131072; // Metadata: 0x020767CA
		public const uint Flag_Transform_Restore = 262144; // Metadata: 0x020767CE
		public const uint Flag_Transform_UnityPhysics = 524288; // Metadata: 0x020767D2
		public const uint Flag_Transform_Parent = 1048576; // Metadata: 0x020767D6
		public const uint Flag_Step_Update = 16777216; // Metadata: 0x020767DA
		public const uint Flag_Reset_Position = 33554432; // Metadata: 0x020767DE
		public FixedChunkNativeArray<ParticleFlag> flagList; // 0x18
		public FixedChunkNativeArray<int> teamIdList; // 0x20
		public FixedChunkNativeArray<float3> posList; // 0x28
		public FixedChunkNativeArray<quaternion> rotList; // 0x30
		public FixedChunkNativeArray<float3> oldPosList; // 0x38
		public FixedChunkNativeArray<quaternion> oldRotList; // 0x40
		public FixedChunkNativeArray<float3> oldSlowPosList; // 0x48
		public FixedChunkNativeArray<float3> localPosList; // 0x50
		public FixedChunkNativeArray<float3> basePosList; // 0x58
		public FixedChunkNativeArray<quaternion> baseRotList; // 0x60
		public FixedChunkNativeArray<float3> snapBasePosList; // 0x68
		public FixedChunkNativeArray<quaternion> snapBaseRotList; // 0x70
		public FixedChunkNativeArray<float3> oldBasePosList; // 0x78
		public FixedChunkNativeArray<quaternion> oldBaseRotList; // 0x80
		public FixedChunkNativeArray<float> depthList; // 0x88
		public FixedChunkNativeArray<float3> radiusList; // 0x90
		public FixedChunkNativeArray<int> restoreTransformIndexList; // 0x98
		public FixedChunkNativeArray<int> transformIndexList; // 0xA0
		public FixedChunkNativeArray<float> frictionList; // 0xA8
		public FixedChunkNativeArray<float> staticFrictionList; // 0xB0
		public FixedChunkNativeArray<float3> velocityList; // 0xB8
		public FixedChunkNativeArray<int> collisionLinkIdList; // 0xC0
		public FixedChunkNativeArray<float3> collisionNormalList; // 0xC8
		private FixedChunkNativeArray<float3> nextPos0List; // 0xD0
		private FixedChunkNativeArray<float3> nextPos1List; // 0xD8
		private int nextPosSwitch; // 0xE0
		private FixedChunkNativeArray<quaternion> nextRot0List; // 0xE8
		private FixedChunkNativeArray<quaternion> nextRot1List; // 0xF0
		private int nextRotSwitch; // 0xF8
		private int colliderCount; // 0xFC
	
		// Properties
		public int Count { get => default; } // 0x000000018AAB8C00-0x000000018AAB8C14 
		public int Length { get => default; } // 0x000000018AAC3040-0x000000018AAC3048 
		public int ColliderCount { get => default; } // 0x00000001855904C0-0x00000001855904E0 
		public FixedChunkNativeArray<float3> InNextPosList { get => default; } // 0x0000000185590300-0x0000000185590310 
		public FixedChunkNativeArray<float3> OutNextPosList { get => default; } // 0x00000001855904A0-0x00000001855904B0 
		public FixedChunkNativeArray<quaternion> InNextRotList { get => default; } // 0x00000001855904B0-0x00000001855904C0 
		public FixedChunkNativeArray<quaternion> OutNextRotList { get => default; } // 0x000000018AAC3034-0x000000018AAC3040 
	
		// Nested types
		public struct ParticleFlag // TypeDefIndex: 52452
		{
			// Fields
			public uint flag; // 0x00
	
			// Constructors
			public ParticleFlag(uint[] flags) {
				flag = default;
			} // 0x000000018558F5C0-0x000000018558FD20
	
			// Methods
			public bool IsFlag(uint flag) => default; // 0x000000018AAB6698-0x000000018AAB69B4
			public void SetFlag(uint flag, bool sw) {} // 0x000000018558FD20-0x0000000185590300
			public bool IsValid() => default; // 0x000000018AAB5CC4-0x000000018AAB6698
			public void SetEnable(bool sw) {} // 0x000000018AAB6A6C-0x000000018AAB6E74
			public bool IsFixed() => default; // 0x0000000185590350-0x00000001855904A0
			public bool IsMove() => default; // 0x000000018AAB6FC8-0x000000018AAB7038
			public bool IsKinematic() => default; // 0x000000018AAB6F34-0x000000018AAB6FC8
			public bool IsHold() => default; // 0x000000018AAB7B50-0x000000018AAB7BA8
			public bool IsCollider() => default; // 0x000000018AAB7BE0-0x000000018AAB7C20
			public bool IsReadTransform() => default; // 0x0000000185FBB490-0x0000000185FBB4A0
			public bool IsWriteTransform() => default; // 0x000000018AAB6A04-0x000000018AAB6A6C
			public bool IsRestoreTransform() => default; // 0x000000018AAB69B4-0x000000018AAB6A04
			public bool IsUnityPhysics() => default; // 0x000000018AAB6EC4-0x000000018AAB6F34
			public bool IsReadSclTransform() => default; // 0x000000018AAB6E74-0x000000018AAB6EC4
			public bool IsParentTransform() => default; // 0x000000018AAB7BA8-0x000000018AAB7BC4
		}
	
		private struct CopyBoneToParticleJob : IJobParallelFor // TypeDefIndex: 52453
		{
			// Fields
			public NativeArray<PhysicsManagerTeamData.TeamData> teamData; // 0x00
			public NativeArray<PhysicsManagerTeamData.WorldInfluence> teamWorldInfluenceList; // 0x10
			public NativeArray<ParticleFlag> flagList; // 0x20
			public NativeArray<float> depthList; // 0x30
			public NativeArray<int> transformIndexList; // 0x40
			public NativeArray<float3> localPosList; // 0x50
			public NativeArray<int> teamIdList; // 0x60
			public NativeArray<float3> velocityList; // 0x70
			public NativeArray<float3> bonePosList; // 0x80
			public NativeArray<quaternion> boneRotList; // 0x90
			public NativeArray<float3> boneSclList; // 0xA0
			public NativeArray<float3> posList; // 0xB0
			public NativeArray<float3> oldPosList; // 0xC0
			public NativeArray<quaternion> oldRotList; // 0xD0
			public NativeArray<float3> oldSlowPosList; // 0xE0
			public NativeArray<quaternion> rotList; // 0xF0
			public NativeArray<float3> snapBasePosList; // 0x100
			public NativeArray<quaternion> snapBaseRotList; // 0x110
			public NativeArray<float3> oldBasePosList; // 0x120
			public NativeArray<quaternion> oldBaseRotList; // 0x130
			public NativeArray<float3> nextPosList; // 0x140
	
			// Methods
			public void Execute(int index) {} // 0x000000018AAB7C20-0x000000018AAB7C3C
		}
	
		private struct ResetParticleJob : IJobParallelFor // TypeDefIndex: 52454
		{
			// Fields
			public NativeArray<PhysicsManagerTeamData.TeamData> teamData; // 0x00
			public NativeArray<ParticleFlag> flagList; // 0x10
			public NativeArray<int> teamIdList; // 0x20
			public NativeArray<float3> snapBasePosList; // 0x30
			public NativeArray<quaternion> snapBaseRotList; // 0x40
			public NativeArray<float3> basePosList; // 0x50
			public NativeArray<quaternion> baseRotList; // 0x60
			public NativeArray<float3> oldBasePosList; // 0x70
			public NativeArray<quaternion> oldBaseRotList; // 0x80
			public NativeArray<float3> posList; // 0x90
			public NativeArray<quaternion> rotList; // 0xA0
			public NativeArray<float3> oldPosList; // 0xB0
			public NativeArray<quaternion> oldRotList; // 0xC0
			public NativeArray<float3> oldSlowPosList; // 0xD0
			public NativeArray<float3> velocityList; // 0xE0
			public NativeArray<float3> nextPosList; // 0xF0
			public NativeArray<quaternion> nextRotList; // 0x100
			public NativeArray<float3> localPosList; // 0x110
	
			// Methods
			public void Execute(int index) {} // 0x0000000185FCEE60-0x0000000185FCEE80
		}
	
		private struct CopyParticleToBoneJob : IJobParallelFor // TypeDefIndex: 52455
		{
			// Fields
			public NativeArray<ParticleFlag> flagList; // 0x00
			public NativeArray<float3> posList; // 0x10
			public NativeArray<quaternion> rotList; // 0x20
			public NativeArray<float3> boneBasePosList; // 0x30
			public NativeArray<quaternion> boneBaseRotList; // 0x40
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x50
			public NativeArray<int> teamIdList; // 0x60
			public NativeParallelMultiHashMap<int, int> transformParticleIndexMap; // 0x70
			public NativeArray<int> writeBoneIndexList; // 0x80
			public NativeArray<float3> bonePosList; // 0x90
			public NativeArray<quaternion> boneRotList; // 0xA0
	
			// Methods
			public void Execute(int index) {} // 0x000000018AAB7BC4-0x000000018AAB7BE0
		}
	
		// Constructors
		public PhysicsManagerParticleData() {} // 0x000000018AABE7A8-0x000000018AABEB20
	
		// Methods
		public override void Create() {} // 0x000000018AAB7C3C-0x000000018AAB7C58
		public override void Dispose() {} // 0x0000000185FCEE80-0x0000000185FCEEA0
		public ChunkData CreateParticle(uint flag, int team, float3 wpos, quaternion wrot, float depth, float3 radius, float3 targetLocalPos) => default; // 0x000000018AAB7038-0x000000018AAB746C
		public ChunkData CreateParticle(int team, int count, Func<int, uint> funcFlag, Func<int, float3> funcWpos, Func<int, quaternion> funcWrot, Func<int, float> funcDepth, Func<int, float3> funcRadius, Func<int, float3> funcTargetLocalPos) => default; // 0x000000018AAB77FC-0x000000018AAB7B50
		public void RemoveParticle(ChunkData c) {} // 0x000000018AAB746C-0x000000018AAB77FC
		public void SetEnable(ChunkData c, bool sw, Func<int, Transform> funcTarget, Func<int, float3> funcLpos, Func<int, quaternion> funcLrot) {} // 0x0000000185492010-0x0000000185492020
		public void SetRadius(int index, float3 radius) {} // 0x0000000185590310-0x0000000185590350
		public void SetLocalPos(int index, Vector3 lpos) {} // 0x000000018AAB8B30-0x000000018AAB8B38
		public bool IsValid(int index) => default; // 0x000000018AAC3004-0x000000018AAC300C
		public int GetTeamId(int index) => default; // 0x000000018AAC3014-0x000000018AAC301C
		public void ResetFuturePredictionTransform(int index) {} // 0x000000018AAC300C-0x000000018AAC3014
		public void ResetFuturePredictionTransform(ChunkData c) {} // 0x00000001876E65CC-0x00000001876E65D4
		public void SwitchingNextPosList() {} // 0x000000018AAC3048-0x000000018AAC3054
		public void SwitchingNextRotList() {} // 0x000000018AAC3028-0x000000018AAC3034
		public void UpdateBoneToParticle() {} // 0x000000018AAC301C-0x000000018AAC3028
		public void UpdateResetParticle() {} // 0x000000018AABDE98-0x000000018AABE7A8
		public bool UpdateParticleToBone() => default; // 0x000000018AACCD7C-0x000000018AACCF60
	}

	public class PhysicsManagerTeamData : PhysicsManagerAccess // TypeDefIndex: 52464
	{
		// Fields
		public const uint Flag_Enable = 1; // Metadata: 0x020767E6
		public const uint Flag_Interpolate = 2; // Metadata: 0x020767E7
		public const uint Flag_FixedNonRotation = 4; // Metadata: 0x020767E8
		public const uint Flag_AnimatedPose = 8; // Metadata: 0x020767E9
		public const uint Flag_IgnoreClampPositionVelocity = 16; // Metadata: 0x020767EA
		public const uint Flag_Collision = 32; // Metadata: 0x020767EB
		public const uint Flag_AfterCollision = 64; // Metadata: 0x020767EC
		public const uint Flag_UpdatePhysics = 128; // Metadata: 0x020767ED
		public const uint Flag_Pause = 256; // Metadata: 0x020767EF
		public const uint Flag_Reset_WorldInfluence = 65536; // Metadata: 0x020767F1
		public const uint Flag_Reset_Position = 131072; // Metadata: 0x020767F5
		public const uint Flag_Reset_Keep = 524288; // Metadata: 0x020767F9
		public const uint Flag_Wind = 1048576; // Metadata: 0x020767FD
		public FixedNativeList<TeamData> teamDataList; // 0x18
		public FixedNativeList<CurveParam> teamMassList; // 0x20
		public FixedNativeList<CurveParam> teamGravityList; // 0x28
		public FixedNativeList<CurveParam> teamDragList; // 0x30
		public FixedNativeList<CurveParam> teamMaxVelocityList; // 0x38
		public FixedNativeList<CurveParam> teamDepthInfluenceList; // 0x40
		public FixedNativeList<WorldInfluence> teamWorldInfluenceList; // 0x48
		public FixedNativeList<WindInfo> teamWindInfoList; // 0x50
		public FixedMultiNativeList<int> colliderList; // 0x58
		public FixedMultiNativeList<int> skinningBoneList; // 0x60
		private Dictionary<int, PhysicsTeam> teamComponentDict; // 0x68
		private int activeTeamCount; // 0x70
		private int normalUpdateCount; // 0x74
		private int physicsUpdateCount; // 0x78
	
		// Properties
		public int TeamCount { get => default; } // 0x000000018AAC6530-0x000000018AAC6680 
		public int TeamLength { get => default; } // 0x000000018AAC6A18-0x000000018AAC6A98 
		public int ActiveTeamCount { get => default; } // 0x000000018AAC6838-0x000000018AAC68B8 
		public int ColliderCount { get => default; } // 0x000000018AAC6680-0x000000018AAC6838 
		public int NormalUpdateCount { get => default; } // 0x000000018AAC6194-0x000000018AAC6214 
		public int PhysicsUpdateCount { get => default; } // 0x000000018AAC6A98-0x000000018AAC6B18 
		public int PauseCount { get => default; } // 0x000000018AAC623C-0x000000018AAC63B8 
	
		// Nested types
		public enum ForceMode // TypeDefIndex: 52457
		{
			None = 0,
			VelocityAdd = 1,
			VelocityChange = 2,
			VelocityAddWithoutMass = 10,
			VelocityChangeWithoutMass = 11
		}
	
		public struct TeamData // TypeDefIndex: 52458
		{
			// Fields
			public ChunkData particleChunk; // 0x00
			public ChunkData colliderChunk; // 0x10
			public ChunkData skinningBoneChunk; // 0x20
			public uint flag; // 0x30
			public float dynamicFriction; // 0x34
			public float staticFriction; // 0x38
			public float selfCollisionRange; // 0x3C
			public int boneIndex; // 0x40
			public float3 initScale; // 0x44
			public float scaleRatio; // 0x50
			public float3 scaleDirection; // 0x54
			public float4 quaternionScale; // 0x60
			public float time; // 0x70
			public float oldTime; // 0x74
			public float addTime; // 0x78
			public float timeScale; // 0x7C
			public float nowTime; // 0x80
			public float startTime; // 0x84
			public int updateCount; // 0x88
			public float blendRatio; // 0x8C
			public float outPhysicsPoseBlendRatio; // 0x90
			public float3 externalForce; // 0x94
			public float forceMassInfluence; // 0xA0
			public float forceWindInfluence; // 0xA4
			public float forceWindRandomScale; // 0xA8
			public float forceWindSynchronization; // 0xAC
			public float velocityWeight; // 0xB0
			public float velocityRecoverySpeed; // 0xB4
			public float3 gravityDirection; // 0xB8
			public MagicaCloth.PhysicsManagerTeamData.ForceMode forceMode; // 0xC4
			public float3 impactForce; // 0xC8
			public int calcCount; // 0xD4
			public short restoreDistanceGroupIndex; // 0xD8
			public short triangleBendGroupIndex; // 0xDA
			public short clampDistanceGroupIndex; // 0xDC
			public short clampDistance2GroupIndex; // 0xDE
			public short clampPositionGroupIndex; // 0xE0
			public short clampRotationGroupIndex; // 0xE2
			public short restoreRotationGroupIndex; // 0xE4
			public short adjustRotationGroupIndex; // 0xE6
			public short springGroupIndex; // 0xE8
			public short volumeGroupIndex; // 0xEA
			public short airLineGroupIndex; // 0xEC
			public short lineWorkerGroupIndex; // 0xEE
			public short triangleWorkerGroupIndex; // 0xF0
			public short selfCollisionGroupIndex; // 0xF2
			public short edgeCollisionGroupIndex; // 0xF4
			public short penetrationGroupIndex; // 0xF6
			public short baseSkinningGroupIndex; // 0xF8
			public short twistGroupIndex; // 0xFA
			public short compositeRotationGroupIndex; // 0xFC
	
			// Methods
			public bool IsActive() => default; // 0x00000001840FB370-0x00000001840FB630
			public bool IsRunning() => default; // 0x000000018AAC4474-0x000000018AAC45E8
			public bool IsUpdate(int runCount) => default; // 0x000000018AAC77EC-0x000000018AAC7834
			public bool IsInterpolate() => default; // 0x000000018AAC7834-0x000000018AAC7874
			public bool IsPhysicsUpdate() => default; // 0x0000000185FB0690-0x0000000185FB06A0
			public bool IsFlag(uint flag) => default; // 0x000000018AAC76A8-0x000000018AAC76F4
			public void SetFlag(uint flag, bool sw) {} // 0x0000000185FB0830-0x0000000185FB0840
			public bool IsReset() => default; // 0x0000000185FB0560-0x0000000185FB0570
			public bool IsPause() => default; // 0x000000018AAC76F4-0x000000018AAC77EC
		}
	
		public struct WorldInfluence // TypeDefIndex: 52459
		{
			// Fields
			public CurveParam moveInfluence; // 0x00
			public CurveParam rotInfluence; // 0x10
			public float maxMoveSpeed; // 0x20
			public float maxRotationSpeed; // 0x24
			public float3 nowPosition; // 0x28
			public float3 oldPosition; // 0x34
			public float3 moveOffset; // 0x40
			public float moveIgnoreRatio; // 0x4C
			public quaternion nowRotation; // 0x50
			public quaternion oldRotation; // 0x60
			public quaternion rotationOffset; // 0x70
			public float rotationIgnoreRatio; // 0x80
			public int resetTeleport; // 0x84
			public float teleportDistance; // 0x88
			public float teleportRotation; // 0x8C
			public ClothParams.TeleportMode teleportMode; // 0x90
			public float stabilizationTime; // 0x94
			public float clampRotationLimit; // 0x98
		}
	
		public struct WindInfo // TypeDefIndex: 52460
		{
			// Fields
			public int windCount; // 0x00
			public int4 windDataIndexList; // 0x04
			public float3x4 windDirectionList; // 0x14
			public float4 windMainList; // 0x44
		}
	
		private struct PreProcessTeamDataJob : IJobParallelFor // TypeDefIndex: 52461
		{
			// Fields
			public float deltaTime; // 0x00
			public float physicsDeltaTime; // 0x04
			public float updateDeltaTime; // 0x08
			public float globalTimeScale; // 0x0C
			public int maxUpdateCount; // 0x10
			public float unityTimeScale; // 0x14
			public float elapsedTime; // 0x18
			public NativeArray<TeamData> teamData; // 0x20
			public NativeArray<WorldInfluence> teamWorldInfluenceList; // 0x30
			public NativeArray<WindInfo> teamWindInfoList; // 0x40
			public NativeArray<float3> bonePosList; // 0x50
			public NativeArray<quaternion> boneRotList; // 0x60
			public NativeArray<float3> boneSclList; // 0x70
			public int windCount; // 0x80
			public NativeArray<PhysicsManagerWindData.WindData> windData; // 0x88
	
			// Methods
			public void Execute(int teamId) {} // 0x00000001840FB630-0x00000001840FBB30
			private void UpdateTime(ref TeamData tdata, bool reset, float dtime) {} // 0x000000018AAC5404-0x000000018AAC5558
			private void Wind(ref TeamData tdata, float3 pos, int teamId) {} // 0x000000018AAC6214-0x000000018AAC623C
		}
	
		private struct PostProcessTeamDataJob : IJobParallelFor // TypeDefIndex: 52462
		{
			// Fields
			public int fixedUpdateCount; // 0x00
			public NativeArray<TeamData> teamData; // 0x08
			public NativeArray<WorldInfluence> teamWorldInfluenceList; // 0x18
	
			// Methods
			public void Execute(int index) {} // 0x000000018AAC4A0C-0x000000018AAC4A18
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 52463
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<int> __9__76_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018AAC49B0-0x000000018AAC4A0C
			public __c() {} // 0x000000018AAC481C-0x000000018AAC48E0
	
			// Methods
			internal void _ResetFuturePredictionCollidere_b__76_0(int pindex) {} // 0x000000018AAC63B8-0x000000018AAC6530
		}
	
		// Constructors
		public PhysicsManagerTeamData() {} // 0x000000018AACE990-0x000000018AACE9EC
	
		// Methods
		public override void Create() {} // 0x000000018AAC48E0-0x000000018AAC49B0
		public override void Dispose() {} // 0x000000018AAC6C60-0x000000018AAC6DA0
		public int CreateTeam(PhysicsTeam team, uint flag) => default; // 0x000000018AAC6114-0x000000018AAC6194
		public void RemoveTeam(int teamId) {} // 0x000000018AAC72D4-0x000000018AAC74E0
		public void SetEnable(int teamId, bool sw) {} // 0x000000018AAC3AA4-0x000000018AAC3B00
		public bool IsValid(int teamId) => default; // 0x000000018AAC74E0-0x000000018AAC76A8
		public bool IsValidData(int teamId) => default; // 0x000000018AAC5B24-0x000000018AAC5CB8
		public bool IsActive(int teamId) => default; // 0x000000018AAC6EE0-0x000000018AAC7040
		public void SetFlag(int teamId, uint flag, bool sw) {} // 0x000000018AAC5920-0x000000018AAC5B24
		public bool IsFlag(int teamId, uint flag) => default; // 0x000000018AAC5F8C-0x000000018AAC6114
		public void SetParticleChunk(int teamId, ChunkData chunk) {} // 0x000000018AAC6DA0-0x000000018AAC6EE0
		public void SetFriction(int teamId, float dynamicFriction, float staticFriction) {} // 0x000000018AAC5E00-0x000000018AAC5F8C
		public void SetMass(int teamId, BezierParam mass) {} // 0x000000018AAC3488-0x000000018AAC36B0
		public void SetGravity(int teamId, BezierParam gravity) {} // 0x000000018AAC4EDC-0x000000018AAC50D8
		public void SetGravityDirection(int teamId, float3 dir) {} // 0x000000018AAC50D8-0x000000018AAC51A4
		public void SetDrag(int teamId, BezierParam drag) {} // 0x000000018AAC5558-0x000000018AAC572C
		public void SetMaxVelocity(int teamId, BezierParam maxVelocity) {} // 0x000000018AAC36B0-0x000000018AAC3AA4
		public void SetExternalForce(int teamId, float massInfluence, float windInfluence, float windRandomScale, float windSynchronization) {} // 0x000000018AAC51A4-0x000000018AAC5404
		public void SetDepthInfluence(int teamId, BezierParam depthInfluence) {} // 0x000000018AAC7040-0x000000018AAC7188
		public void SetWorldInfluence(int teamId, float maxSpeed, float maxRotatinSpeed, BezierParam moveInfluence, BezierParam rotInfluence, bool resetTeleport, float teleportDistance, float teleportRotation, float resetStabilizationTime, ClothParams.TeleportMode teleportMode, bool useClampRotation, BezierParam clampRotation) {} // 0x000000018AAC4760-0x000000018AAC481C
		private float CalcClampRotationLimit(bool useClampRotation, BezierParam clampRotation) => default; // 0x000000018AAC5CB8-0x000000018AAC5E00
		public void SetWorldInfluence(int teamId, float maxSpeed, float maxRotationSpeed, BezierParam moveInfluence, BezierParam rotInfluence) {} // 0x000000018AAC45E8-0x000000018AAC46A4
		public void SetAfterTeleport(int teamId, bool resetTeleport, float teleportDistance, float teleportRotation, ClothParams.TeleportMode teleportMode) {} // 0x000000018AAC6B18-0x000000018AAC6C60
		public void SetStabilizationTime(int teamId, float resetStabilizationTime) {} // 0x000000018AAC46A4-0x000000018AAC4760
		public void ResetWorldInfluenceTarget(int teamId, Transform target) {} // 0x000000018AAC68B8-0x000000018AAC6A18
		public void SetClampRotation(int teamId, bool useClampRotation, BezierParam clampRotation) {} // 0x000000018AAC572C-0x000000018AAC5920
		public void SetSelfCollisionRange(int teamId, float range) {} // 0x000000018AAC7188-0x000000018AAC72D4
		public void SetBoneIndex(int teamId, int boneIndex, Vector3 initScale) {} // 0x000000018AAC4260-0x000000018AAC4474
		internal void AddColliderParticle(int teamId, int particleIndex) {} // 0x000000018AAC4144-0x000000018AAC4260
		internal void RemoveColliderParticle(int teamId, int particleIndex) {} // 0x000000018AAC3EEC-0x000000018AAC4144
		internal void RemoveCollider(int teamId, ColliderComponent collider) {} // 0x0000000184406590-0x0000000184406D60
		public void ResetFuturePredictionCollidere(int teamId) {} // 0x0000000184406D60-0x0000000184407910
		public void AddSkinningBoneIndex(int teamId, List<Transform> boneList) {} // 0x000000018AAC3B00-0x000000018AAC3EEC
		public void RemoveSkinningBoneIndex(int teamId) {} // 0x000000018AAC4B7C-0x000000018AAC4EDC
		public void SetTimeScale(int teamId, float timeScale) {} // 0x000000018AAC4A18-0x000000018AAC4B7C
		public float GetTimeScale(int teamId) => default; // 0x000000018588C880-0x000000018588C900
		public void SetBlendRatio(int teamId, float blendRatio) {} // 0x0000000187B974B0-0x0000000187B974B8
		public float GetBlendRatio(int teamId) => default; // 0x000000018AACDB14-0x000000018AACDB20
		public void SetOutPhysicsPoseBlendRatio(int teamId, float blendRatio) {} // 0x000000018AACDB20-0x000000018AACDB2C
		public float GetOutPhysicsPoseBlendRatio(int teamId) => default; // 0x0000000187B974B8-0x0000000187B974C0
		public void SetImpactForce(int teamId, float3 force, ForceMode mode) {} // 0x000000018AACDAFC-0x000000018AACDB08
		public void ResetStabilizationTime(int teamId, float resetStabilizationTime = -1f /* Metadata: 0x020767E2 */) {} // 0x000000018AACDAE8-0x000000018AACDAF0
		public void SetUpdateMode(int teamId, PhysicsTeam.TeamUpdateMode updateMode) {} // 0x000000018AACDB2C-0x000000018AACDB44
		public void ChangeUseUnityPhysics(int teamId, bool sw) {} // 0x000000018AACDB08-0x000000018AACDB14
		private void ChangeParticleUseUnityPhysics(int pindex, bool unityPhysics) {} // 0x000000018AACDAF0-0x000000018AACDAFC
		internal void ChangeBoneFlag(int teamId, PhysicsTeam.TeamCullingMode cullingMode, bool isCalculation) {} // 0x000000018AAC9340-0x000000018AACA1E4
		internal void EarlyUpdateTeamAlways() {} // 0x000000018AACA1E4-0x000000018AACA2D8
		internal void PreUpdateTeamAlways() {} // 0x000000018AACA2D8-0x000000018AACA7B4
		internal int CalcMaxUpdateCount(int ups, float deltaTime, float physicsDeltaTime, float updateDeltaTime) => default; // 0x000000018AAC903C-0x000000018AAC9340
		internal void PreUpdateTeamData(float deltaTime, float physicsDeltaTime, float updateDeltaTime, int ups, int maxUpdateCount) {} // 0x000000018AACE9EC-0x000000018AACEA50
		internal void PostUpdateTeamData() {} // 0x0000000185492010-0x0000000185492020
	}

	public class PhysicsManagerWindData : PhysicsManagerAccess // TypeDefIndex: 52469
	{
		// Fields
		public const uint Flag_Enable = 1; // Metadata: 0x02076806
		public const uint Flag_Addition = 2; // Metadata: 0x02076807
		public FixedNativeList<WindData> windDataList; // 0x18
	
		// Properties
		public int Count { get => default; } // 0x000000018AAB8C00-0x000000018AAB8C14 
	
		// Nested types
		public enum WindType // TypeDefIndex: 52465
		{
			None = 0,
			Direction = 1,
			Area = 2
		}
	
		public enum ShapeType // TypeDefIndex: 52466
		{
			Box = 0,
			Sphere = 1
		}
	
		public enum DirectionType // TypeDefIndex: 52467
		{
			OneDirection = 0,
			Radial = 1
		}
	
		public struct WindData // TypeDefIndex: 52468
		{
			// Fields
			public uint flag; // 0x00
			public WindType windType; // 0x04
			public ShapeType shapeType; // 0x08
			public int transformIndex; // 0x0C
			public float3 areaSize; // 0x10
			public float main; // 0x1C
			public float turbulence; // 0x20
			public float frequency; // 0x24
			public float3 direction; // 0x28
			public DirectionType directionType; // 0x34
			public float areaVolume; // 0x38
			public float areaLength; // 0x3C
			public CurveParam attenuation; // 0x40
	
			// Methods
			public bool IsFlag(uint flag) => default; // 0x0000000185F58FF0-0x0000000185F59070
			public void SetFlag(uint flag, bool sw) {} // 0x000000018AAC7BEC-0x000000018AAC7C30
			public void SetEnable(bool sw) {} // 0x000000018AAC7AB0-0x000000018AAC7BEC
			public bool IsActive() => default; // 0x000000018AAC7C94-0x000000018AAC7CEC
		}
	
		// Constructors
		public PhysicsManagerWindData() {} // 0x000000018AAC3040-0x000000018AAC3048
	
		// Methods
		public override void Create() {} // 0x000000018AAC7CEC-0x000000018AAC7E68
		public override void Dispose() {} // 0x000000018AAC7C30-0x000000018AAC7C94
		public int CreateWind(WindType windType, ShapeType shapeType, float3 areaSize, bool addition, float main, float turbulence, float frequency, float3 direction, DirectionType directinType, float areaVolume, float areaLength, BezierParam attenuation) => default; // 0x000000018AAC7E68-0x000000018AAC7F3C
		public void RemoveWind(int windId) {} // 0x000000018AAC7F3C-0x000000018AAC80AC
		public void SetEnable(int windId, bool sw, Transform target) {} // 0x000000018AAC80AC-0x000000018AAC80F8
		public bool IsActive(int windId) => default; // 0x000000018AAC7874-0x000000018AAC7AB0
		public void SetFlag(int windId, uint flag, bool sw) {} // 0x0000000185492010-0x0000000185492020
		public void SetParameter(int windId, float3 areaSize, bool addition, float main, float turbulence, float frequency, float3 direction, float areaVolume, float areaLength, BezierParam attenuation) {} // 0x000000018AAB8B30-0x000000018AAB8B38
		internal static float3 CalcWindForce(float time, float2 noiseBasePos, float3 mainDir, float main, float turbulence, float frequency, float randomScale) => default; // 0x000000018AACEBC8-0x000000018AACEBE0
	}

	public abstract class PhysicsManagerWorker // TypeDefIndex: 52470
	{
		// Fields
		private MagicaPhysicsManager _Manager_k__BackingField; // 0x10
	
		// Properties
		public MagicaPhysicsManager Manager { get; set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
	
		// Constructors
		protected PhysicsManagerWorker() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected virtual void Start() {} // 0x0000000185492010-0x0000000185492020
		public void Init(MagicaPhysicsManager manager) {} // 0x0000000184B30AC0-0x0000000184B30AF0
		public abstract void Create();
		public abstract void RemoveGroup(int group);
		public abstract void Release();
		public abstract void Warmup();
		public abstract JobHandle PreUpdate(JobHandle jobHandle);
		public abstract JobHandle PostUpdate(JobHandle jobHandle);
	}

	public abstract class ColliderComponent : ParticleComponent // TypeDefIndex: 52471
	{
		// Fields
		protected bool isGlobal; // 0x28
		private Vector3 center; // 0x2C
	
		// Properties
		public Vector3 Center { get; set; } // 0x0000000185FBAA80-0x0000000185FBAAA0 0x000000018AABDE80-0x000000018AABDE98
	
		// Constructors
		protected ColliderComponent() {} // 0x000000018AABDE78-0x000000018AABDE80
	
		// Methods
		protected override void OnInit() {} // 0x000000018AABDD28-0x000000018AABDD4C
		protected override void OnDispose() {} // 0x000000018AABDA44-0x000000018AABDD28
		public override int GetDataHash() => default; // 0x000000018AABD9F8-0x000000018AABDA44
		public abstract bool CalcNearPoint(Vector3 pos, out Vector3 p, out Vector3 dir, out Vector3 d, bool skinning);
		public Vector3 CalcLocalPos(Vector3 pos) => default; // 0x000000018AABD85C-0x000000018AABD96C
		public Vector3 CalcLocalDir(Vector3 dir) => default; // 0x000000018AABD7F0-0x000000018AABD85C
		public ChunkData CreateColliderParticle(int teamId) => default; // 0x000000018AABD96C-0x000000018AABD9F8
		public void RemoveColliderParticle(int teamId) {} // 0x000000018AABDD4C-0x000000018AABDE78
		protected abstract ChunkData CreateColliderParticleReal(int teamId);
	}

	public class MagicaCapsuleCollider : ColliderComponent // TypeDefIndex: 52473
	{
		// Fields
		private Axis axis; // 0x38
		private float length; // 0x3C
		private float startRadius; // 0x40
		private float endRadius; // 0x44
	
		// Properties
		public Axis AxisMode { get => default; set {} } // 0x00000001813E5E30-0x00000001813E5E40 0x000000018AAC0A8C-0x000000018AAC0A98
		public float Length { get => default; set {} } // 0x0000000185FB0580-0x0000000185FB0590 0x000000018AAC0AA4-0x000000018AAC0AB0
		public float StartRadius { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x000000018AAC0AB0-0x000000018AAC0ABC
		public float EndRadius { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x000000018AAC0A98-0x000000018AAC0AA4
	
		// Nested types
		public enum Axis // TypeDefIndex: 52472
		{
			X = 0,
			Y = 1,
			Z = 2
		}
	
		// Constructors
		public MagicaCapsuleCollider() {} // 0x000000018AAC0A70-0x000000018AAC0A8C
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000185FB7430-0x0000000185FB7440
		private void OnValidate() {} // 0x000000018AAC0A44-0x000000018AAC0A70
		internal override void DataUpdate() {} // 0x000000018AAC0514-0x000000018AAC0844
		public override int GetDataHash() => default; // 0x000000018AAC0864-0x000000018AAC0968
		protected override ChunkData CreateColliderParticleReal(int teamId) => default; // 0x000000018AAC03C4-0x000000018AAC0514
		private uint GetCapsuleFlag() => default; // 0x000000018AAC0844-0x000000018AAC0864
		public Vector3 GetLocalDir() => default; // 0x000000018AAC0968-0x000000018AAC09AC
		public Vector3 GetLocalUp() => default; // 0x000000018AAC09AC-0x000000018AAC09E8
		public float GetScale() => default; // 0x000000018AAC09E8-0x000000018AAC0A44
		public override bool CalcNearPoint(Vector3 pos, out Vector3 p, out Vector3 dir, out Vector3 d, bool skinning) {
			p = default;
			dir = default;
			d = default;
			return default;
		} // 0x000000018AABFC48-0x000000018AAC03C4
	}

	public class MagicaPlaneCollider : ColliderComponent // TypeDefIndex: 52474
	{
		// Constructors
		public MagicaPlaneCollider() {} // 0x000000018AABDE78-0x000000018AABDE80
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000185FB7550-0x0000000185FB7560
		private void OnValidate() {} // 0x000000018AAC0A44-0x000000018AAC0A70
		internal override void DataUpdate() {} // 0x000000018AAC0DB4-0x000000018AAC0F80
		protected override ChunkData CreateColliderParticleReal(int teamId) => default; // 0x000000018AAC0C88-0x000000018AAC0DB4
		public override bool CalcNearPoint(Vector3 pos, out Vector3 p, out Vector3 dir, out Vector3 d, bool skinning) {
			p = default;
			dir = default;
			d = default;
			return default;
		} // 0x000000018AAC0ABC-0x000000018AAC0C88
	}

	public class MagicaSphereCollider : ColliderComponent // TypeDefIndex: 52475
	{
		// Fields
		private float radius; // 0x38
	
		// Properties
		public float Radius { get => default; set {} } // 0x0000000185FB24B0-0x0000000185FB24C0 0x000000018AAC1544-0x000000018AAC1550
	
		// Constructors
		public MagicaSphereCollider() {} // 0x000000018AAC1534-0x000000018AAC1544
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000185FB7570-0x0000000185FB7580
		private void OnValidate() {} // 0x000000018AAC0A44-0x000000018AAC0A70
		internal override void DataUpdate() {} // 0x000000018AAC1260-0x000000018AAC149C
		public override int GetDataHash() => default; // 0x000000018AAC149C-0x000000018AAC1504
		protected override ChunkData CreateColliderParticleReal(int teamId) => default; // 0x000000018AAC1138-0x000000018AAC1260
		public float GetScale() => default; // 0x000000018AAC1504-0x000000018AAC1534
		public override bool CalcNearPoint(Vector3 pos, out Vector3 p, out Vector3 dir, out Vector3 d, bool skinning) {
			p = default;
			dir = default;
			d = default;
			return default;
		} // 0x000000018AAC0F80-0x000000018AAC1138
	}

	public abstract class ParticleComponent : BaseComponent, IDataHash // TypeDefIndex: 52476
	{
		// Fields
		protected Dictionary<int, ChunkData> particleDict; // 0x18
		protected RuntimeStatus status; // 0x20
	
		// Properties
		public RuntimeStatus Status { get; } // 0x00000001813B31A0-0x00000001813B31B0 
		public int CenterParticleIndex { get; } // 0x000000018AAC2F8C-0x000000018AAC3004 
	
		// Constructors
		protected ParticleComponent() {} // 0x000000018AAC2ED4-0x000000018AAC2F8C
	
		// Methods
		public abstract int GetDataHash();
		protected virtual void Start() {} // 0x000000018AAC2DE4-0x000000018AAC2DEC
		public virtual void OnEnable() {} // 0x000000018AA7CDF0-0x000000018AA7CE1C
		public virtual void OnDisable() {} // 0x000000018AA7CDBC-0x000000018AA7CDE8
		protected virtual void OnDestroy() {} // 0x000000018AAC2A24-0x000000018AAC2A54
		private void Init() {} // 0x000000018AAC28D0-0x000000018AAC2A1C
		protected void OnUpdateStatus() {} // 0x000000018AAC2AA8-0x000000018AAC2AE4
		public virtual bool VerifyData() => default; // 0x00000001840A27C0-0x00000001840A27D0
		protected virtual void OnInit() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnDispose() {} // 0x000000018AAC2A54-0x000000018AAC2AA0
		protected virtual void OnUpdate() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnActive() {} // 0x000000018AAC2A1C-0x000000018AAC2A24
		protected virtual void OnInactive() {} // 0x000000018AAC2AA0-0x000000018AAC2AA8
		protected void EnableParticle() {} // 0x000000018AAC25E8-0x000000018AAC2728
		protected void DisableParticle() {} // 0x000000018AAC22E0-0x000000018AAC2440
		protected void EnableTeamParticle(int teamId) {} // 0x000000018AAC2728-0x000000018AAC28D0
		protected void DisableTeamParticle(int teamId) {} // 0x000000018AAC2440-0x000000018AAC25E8
		protected void ReserveDataUpdate() {} // 0x000000018AAC2D68-0x000000018AAC2DE4
		internal virtual void DataUpdate() {} // 0x0000000185492010-0x0000000185492020
		internal void UpdateStatus() {} // 0x000000018AAC2DEC-0x000000018AAC2E0C
		protected ChunkData CreateParticle(uint flag, int teamId, float depth, float3 radius, float3 localPos) => default; // 0x000000018AAC2080-0x000000018AAC22E0
		protected void RemoveTeamParticle(int teamId) {} // 0x000000018AAC2C78-0x000000018AAC2D68
		protected void RemoveParticle() {} // 0x000000018AAC2AE4-0x000000018AAC2C78
		protected Transform UserTransform(int vindex) => default; // 0x000000018646DBCC-0x000000018646DBD4
		protected float3 UserTransformLocalPosition(int vindex) => default; // 0x000000018AAC2E0C-0x000000018AAC2E78
		protected quaternion UserTransformLocalRotation(int vindex) => default; // 0x000000018AAC2E78-0x000000018AAC2ED4
		private object _Init_b__11_0() => default; // 0x0000000185779060-0x0000000185779070
	}

	public abstract class PhysicsTeam : CoreComponent // TypeDefIndex: 52480
	{
		// Fields
		protected PhysicsTeamData teamData; // 0x38
		private float userBlendWeight; // 0x40
		private float userPhysicsBlendWeight; // 0x44
		private bool syncBlendWeightToPoseBlendWeight; // 0x48
		private float userCloseThreshold; // 0x4C
		private TeamUpdateMode updateMode; // 0x50
		private TeamCullingMode cullingMode; // 0x54
		private TeamSkinningMode skinningMode; // 0x58
		protected int teamId; // 0x5C
		protected ChunkData particleChunk; // 0x60
		protected Transform influenceTarget; // 0x70
	
		// Properties
		public int TeamId { get; } // 0x0000000183F80460-0x0000000183F80470 
		public PhysicsTeamData TeamData { get; } // 0x00000001813ECBC0-0x00000001813ECBD0 
		public ChunkData ParticleChunk { get; } // 0x0000000185FCCD00-0x0000000185FCCD10 
		public Transform InfluenceTarget { get; set; } // 0x0000000181460F70-0x0000000181460F80 0x00000001874BE90C-0x00000001874BE91C
		public float UserBlendWeight { get; set; } // 0x0000000185FB0590-0x0000000185FB05A0 0x000000018AA569D4-0x000000018AA569EC
		public float UserPhysicsBlendWeight { get; set; } // 0x0000000185FB05A0-0x0000000185FB05B0 0x000000018AAC9024-0x000000018AAC903C
		public bool SyncBlendWeightToPoseBlendWeight { get; set; } // 0x0000000185FB0750-0x0000000185FB0760 0x0000000185FB0770-0x0000000185FB0780
		public float UserCloseThreshold { get; set; } // 0x0000000185FB1750-0x0000000185FB1760 0x000000018AAC900C-0x000000018AAC9024
		public TeamUpdateMode UpdateMode { get; protected set; } // 0x0000000185FB0680-0x0000000185FB0690 0x0000000185FB06B0-0x0000000185FB06C0
		public TeamCullingMode CullingMode { get; set; } // 0x0000000185FB0670-0x0000000185FB0680 0x0000000185FB06A0-0x0000000185FB06B0
		public TeamSkinningMode SkinningMode { get; set; } // 0x0000000183F80450-0x0000000183F80460 0x0000000183F804E0-0x0000000183F804F0
		internal bool UseAnimatedPose { get; } // 0x000000018AAC9004-0x000000018AAC900C 
	
		// Nested types
		public enum TeamUpdateMode // TypeDefIndex: 52477
		{
			Normal = 0,
			UnityPhysics = 1
		}
	
		public enum TeamCullingMode // TypeDefIndex: 52478
		{
			Reset = 0,
			Pause = 10,
			Off = 100
		}
	
		public enum TeamSkinningMode // TypeDefIndex: 52479
		{
			None = 0,
			UserAnimation = 1
		}
	
		// Constructors
		protected PhysicsTeam() {} // 0x000000018AAC8F74-0x000000018AAC9004
	
		// Methods
		public override int GetDataHash() => default; // 0x000000018AAC8BE0-0x000000018AAC8C00
		protected override void OnInit() {} // 0x000000018AAC8E78-0x000000018AAC8EF0
		protected override void OnDispose() {} // 0x000000018AAC8D60-0x000000018AAC8DF8
		protected override void OnUpdate() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnActive() {} // 0x000000018AAC8CFC-0x000000018AAC8D60
		protected override void OnInactive() {} // 0x000000018AAC8DF8-0x000000018AAC8E78
		public bool IsActive() => default; // 0x000000018AAC8C00-0x000000018AAC8C80
		public bool IsValid() => default; // 0x000000018AAC8C80-0x000000018AAC8CFC
		public ChunkData CreateParticle(int team, int count, Func<int, uint> funcFlag, Func<int, float3> funcWpos, Func<int, quaternion> funcWrot, Func<int, float> funcDepth, Func<int, float3> funcRadius, Func<int, float3> funcTargetLocalPos) => default; // 0x000000018AAC8980-0x000000018AAC8A7C
		public void RemoveAllParticle() {} // 0x000000018AAC8EF0-0x000000018AAC8F6C
		public void EnableParticle(Func<int, Transform> funcTarget, Func<int, float3> funcLpos, Func<int, quaternion> funcLrot) {} // 0x000000018AAC8B3C-0x000000018AAC8BE0
		public void DisableParticle(Func<int, Transform> funcTarget, Func<int, float3> funcLpos, Func<int, quaternion> funcLrot) {} // 0x000000018AAC8A7C-0x000000018AAC8B3C
		public override Define.Error VerifyData() => default; // 0x000000018AAC8F6C-0x000000018AAC8F74
	}

	[Serializable]
	public class PhysicsTeamData : IDataHash // TypeDefIndex: 52481
	{
		// Fields
		private List<ColliderComponent> colliderList; // 0x10
		private List<ColliderComponent> penetrationIgnoreColliderList; // 0x18
		private bool mergeAvatarCollider; // 0x20
		private List<ColliderComponent> addColliderList; // 0x28
	
		// Properties
		public int ColliderCount { get => default; } // 0x000000018AAC8940-0x000000018AAC8980 
		public List<ColliderComponent> ColliderList { get => default; } // 0x000000018346D130-0x000000018346D140 
		public List<ColliderComponent> PenetrationIgnoreColliderList { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public bool MergeAvatarCollider { get => default; } // 0x00000001813ECBF0-0x00000001813ECC00 
	
		// Constructors
		public PhysicsTeamData() {} // 0x000000018AAC8860-0x000000018AAC8940
	
		// Methods
		public int GetDataHash() => default; // 0x000000018AAC8434-0x000000018AAC8470
		public void Init(int teamId) {} // 0x000000018AAC8470-0x000000018AAC85C8
		public void Dispose(int teamId) {} // 0x000000018AAC819C-0x000000018AAC8434
		public void AddCollider(ColliderComponent collider) {} // 0x000000018AAC80F8-0x000000018AAC819C
		public void RemoveCollider(ColliderComponent collider) {} // 0x000000018AAC85C8-0x000000018AAC86E0
		internal void UpdateStatus() {} // 0x000000018AAC86E0-0x000000018AAC8824
		public void ValidateColliderList() {} // 0x000000018AAC8824-0x000000018AAC8860
	}

	public class AdjustRotationWorker : PhysicsManagerWorker // TypeDefIndex: 52485
	{
		// Fields
		private const int AdjustMode_Fixed = 0; // Metadata: 0x0207681A
		private const int AdjustMode_XYMove = 1; // Metadata: 0x0207681B
		private const int AdjustMode_XZMove = 2; // Metadata: 0x0207681C
		private const int AdjustMode_YZMove = 3; // Metadata: 0x0207681D
		private FixedChunkNativeArray<AdjustRotationData> dataList; // 0x18
		public FixedNativeList<GroupData> groupList; // 0x20
		private ExNativeMultiHashMap<int, int> particleMap; // 0x28
	
		// Nested types
		[Serializable]
		public struct AdjustRotationData // TypeDefIndex: 52482
		{
			// Fields
			public int keyIndex; // 0x00
			public int targetIndex; // 0x04
			public float3 localPos; // 0x08
	
			// Methods
			public bool IsValid() => default; // 0x0000000185AE4A20-0x0000000185AE4B30
		}
	
		public struct GroupData // TypeDefIndex: 52483
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public int adjustMode; // 0x08
			public float3 axisRotationPower; // 0x0C
			public ChunkData chunk; // 0x18
		}
	
		private struct AdjustRotationJob : IJobParallelFor // TypeDefIndex: 52484
		{
			// Fields
			public NativeArray<AdjustRotationData> dataList; // 0x00
			public NativeArray<GroupData> groupList; // 0x10
			public NativeParallelMultiHashMap<int, int> particleMap; // 0x20
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x30
			public NativeArray<int> teamIdList; // 0x40
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x50
			public NativeArray<float3> snapBasePosList; // 0x60
			public NativeArray<quaternion> snapBaseRotList; // 0x70
			public NativeArray<float3> posList; // 0x80
			public NativeArray<quaternion> rotList; // 0x90
	
			// Methods
			public void Execute(int index) {} // 0x000000018AABB4B0-0x000000018AABB538
		}
	
		// Constructors
		public AdjustRotationWorker() {} // 0x000000018AABA8D8-0x000000018AABAD24
	
		// Methods
		public override void Create() {} // 0x000000018AABAD24-0x000000018AABAFB0
		public override void Release() {} // 0x000000018AABB538-0x000000018AABB824
		public int AddGroup(int teamId, bool active, int adjustMode, float3 axisRotationPower, AdjustRotationData[] dataArray) => default; // 0x000000018AABAFB0-0x000000018AABB144
		public override void RemoveGroup(int teamId) {} // 0x0000000185492010-0x0000000185492020
		public void ChangeParam(int teamId, bool active, int adjustMode, float3 axisRotationPower) {} // 0x0000000185FC6CA0-0x0000000185FC6CB0
		public override void Warmup() {} // 0x000000018AABB144-0x000000018AABB4B0
		public override JobHandle PreUpdate(JobHandle jobHandle) => default; // 0x0000000185492010-0x0000000185492020
		public override JobHandle PostUpdate(JobHandle jobHandle) => default; // 0x000000018AABA8C8-0x000000018AABA8D8
	}

	public class BaseSkinningWorker : PhysicsManagerWorker // TypeDefIndex: 52489
	{
		// Fields
		private FixedChunkNativeArray<BaseSkinningData> dataList; // 0x18
		private FixedChunkNativeArray<float4x4> bindPoseList; // 0x20
		public FixedNativeList<GroupData> groupList; // 0x28
	
		// Nested types
		[Serializable]
		public struct BaseSkinningData // TypeDefIndex: 52486
		{
			// Fields
			public float3 localPos; // 0x00
			public float3 localNor; // 0x0C
			public float3 localTan; // 0x18
			public int4 boneIndices; // 0x24
			public float4 weights; // 0x34
			public short weightCount; // 0x44
	
			// Methods
			public bool IsValid() => default; // 0x0000000185D73640-0x0000000185D73750
		}
	
		public struct GroupData // TypeDefIndex: 52487
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public int updateFixed; // 0x08
			public ChunkData dataChunk; // 0x0C
			public ChunkData bindPoseChunk; // 0x1C
		}
	
		private struct BaseSkinningJob : IJobParallelFor // TypeDefIndex: 52488
		{
			// Fields
			public NativeArray<GroupData> groupList; // 0x00
			public NativeArray<BaseSkinningData> dataList; // 0x10
			public NativeArray<float4x4> bindPoseList; // 0x20
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x30
			public NativeArray<int> skinningBoneList; // 0x40
			public NativeArray<float3> bonePosList; // 0x50
			public NativeArray<quaternion> boneRotList; // 0x60
			public NativeArray<float3> boneSclList; // 0x70
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x80
			public NativeArray<int> teamIdList; // 0x90
			public NativeArray<float3> snapBasePosList; // 0xA0
			public NativeArray<quaternion> snapBaseRotList; // 0xB0
	
			// Methods
			public void Execute(int index) {} // 0x000000018AABC93C-0x000000018AABC9C4
		}
	
		// Constructors
		public BaseSkinningWorker() {} // 0x000000018AABB830-0x000000018AABC1FC
	
		// Methods
		public override void Create() {} // 0x000000018AABC1FC-0x000000018AABC3E0
		public override void Release() {} // 0x000000018AABC9C4-0x000000018AABCBA4
		public int AddGroup(int teamId, bool active, bool updateFixed, BaseSkinningData[] skinningDataList, float4x4[] skinningBindPoseList) => default; // 0x000000018AABC3E0-0x000000018AABC538
		public override void RemoveGroup(int teamId) {} // 0x0000000185492010-0x0000000185492020
		public void ChangeParam(int teamId, bool updateFixed) {} // 0x000000018AABC538-0x000000018AABC93C
		public override void Warmup() {} // 0x0000000185FC6CA0-0x0000000185FC6CB0
		public override JobHandle PreUpdate(JobHandle jobHandle) => default; // 0x0000000185492010-0x0000000185492020
		public override JobHandle PostUpdate(JobHandle jobHandle) => default; // 0x000000018AABB824-0x000000018AABB830
	}

	public class LineWorker : PhysicsManagerWorker // TypeDefIndex: 52494
	{
		// Fields
		private FixedChunkNativeArray<LineRotationData> dataList; // 0x18
		private FixedChunkNativeArray<LineRotationRootInfo> rootInfoList; // 0x20
		public FixedNativeList<GroupData> groupList; // 0x28
		private FixedChunkNativeArray<int> rootTeamList; // 0x30
	
		// Nested types
		[Serializable]
		public struct LineRotationData // TypeDefIndex: 52490
		{
			// Fields
			public int vertexIndex; // 0x00
			public int childCount; // 0x04
			public int childStartDataIndex; // 0x08
			public float3 localPos; // 0x0C
			public quaternion localRot; // 0x18
		}
	
		[Serializable]
		public struct LineRotationRootInfo // TypeDefIndex: 52491
		{
			// Fields
			public ushort startIndex; // 0x00
			public ushort dataLength; // 0x02
		}
	
		public struct GroupData // TypeDefIndex: 52492
		{
			// Fields
			public int teamId; // 0x00
			public int avarage; // 0x04
			public ChunkData dataChunk; // 0x08
			public ChunkData rootInfoChunk; // 0x18
		}
	
		private struct LineRotationJob : IJobParallelFor // TypeDefIndex: 52493
		{
			// Fields
			public int fixedUpdateCount; // 0x00
			public NativeArray<LineRotationData> dataList; // 0x08
			public NativeArray<LineRotationRootInfo> rootInfoList; // 0x18
			public NativeArray<int> rootTeamList; // 0x28
			public NativeArray<GroupData> groupList; // 0x38
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x48
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x58
			public NativeArray<float3> posList; // 0x68
			public NativeArray<quaternion> rotList; // 0x78
	
			// Methods
			public void Execute(int rootIndex) {} // 0x000000018558E970-0x000000018558EAD0
		}
	
		// Constructors
		public LineWorker() {} // 0x000000018AABEB20-0x000000018AABF2C4
	
		// Methods
		public override void Create() {} // 0x000000018AABF99C-0x000000018AABFA44
		public override void Release() {} // 0x000000018AABF2C4-0x000000018AABF550
		public int AddGroup(int teamId, bool avarage, LineRotationData[] dataArray, LineRotationRootInfo[] rootInfoArray) => default; // 0x000000018AABFA44-0x000000018AABFC48
		public override void RemoveGroup(int teamId) {} // 0x000000018AABF550-0x000000018AABF6B0
		public void ChangeParam(int teamId, bool avarage) {} // 0x0000000185492010-0x0000000185492020
		public override void Warmup() {} // 0x0000000185FC6CA0-0x0000000185FC6CB0
		public override JobHandle PreUpdate(JobHandle jobHandle) => default; // 0x000000018AABF6B0-0x000000018AABF99C
		public override JobHandle PostUpdate(JobHandle jobHandle) => default; // 0x0000000185492010-0x0000000185492020
	}

	public class MeshParticleWorker : PhysicsManagerWorker // TypeDefIndex: 52498
	{
		// Fields
		private ExNativeMultiHashMap<int, int> vertexToParticleMap; // 0x18
		private FixedNativeListWithCount<int> vertexToParticleList; // 0x20
		private Dictionary<int, List<CreateData>> groupCreateDict; // 0x28
	
		// Nested types
		private struct CreateData // TypeDefIndex: 52495
		{
			// Fields
			public int vertexIndex; // 0x00
			public int particleIndex; // 0x04
		}
	
		private struct VertexToParticleJob : IJobParallelFor // TypeDefIndex: 52496
		{
			// Fields
			public NativeArray<PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList; // 0x00
			public NativeArray<int> vertexToParticleList; // 0x10
			public NativeParallelMultiHashMap<int, int> vertexToParticleMap; // 0x20
			public NativeArray<float3> posList; // 0x30
			public NativeArray<quaternion> rotList; // 0x40
			public NativeArray<short> virtualVertexMeshIndexList; // 0x50
			public NativeArray<float3> snapBasePosList; // 0x60
			public NativeArray<quaternion> snapBaseRotList; // 0x70
			private NativeParallelMultiHashMapIterator<int> iterator; // 0x80
	
			// Methods
			public void Execute(int index) {} // 0x0000000185AE4B30-0x0000000185AE4C10
		}
	
		private struct ParticleToVertexJob : IJobParallelFor // TypeDefIndex: 52497
		{
			// Fields
			public NativeArray<int> vertexToParticleList; // 0x00
			public NativeParallelMultiHashMap<int, int> vertexToParticleMap; // 0x10
			public NativeArray<float3> virtualPosList; // 0x20
			public NativeArray<quaternion> virtualRotList; // 0x30
			public NativeArray<byte> virtualVertexFlagList; // 0x40
			public NativeArray<short> virtualVertexMeshIndexList; // 0x50
			public NativeArray<PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList; // 0x60
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x70
			public NativeArray<int> teamIdList; // 0x80
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> particleFlagList; // 0x90
			public NativeArray<float3> particlePosList; // 0xA0
			public NativeArray<quaternion> particleRotList; // 0xB0
			private NativeParallelMultiHashMapIterator<int> iterator; // 0xC0
	
			// Methods
			public void Execute(int index) {} // 0x000000018AAC1E04-0x000000018AAC1E6C
		}
	
		// Constructors
		public MeshParticleWorker() {} // 0x000000018AAC3054-0x000000018AAC3488
	
		// Methods
		public override void Create() {} // 0x000000018AAC1550-0x000000018AAC16D8
		public override void Release() {} // 0x000000018AAC1E6C-0x000000018AAC2080
		public void Add(int group, int vindex, int pindex) {} // 0x0000000185492010-0x0000000185492020
		public override void RemoveGroup(int group) {} // 0x000000018AAC1B00-0x000000018AAC1E04
		public override void Warmup() {} // 0x000000018AAC16D8-0x000000018AAC1B00
		public override JobHandle PreUpdate(JobHandle jobHandle) => default; // 0x0000000184B2F370-0x0000000184B2F3F0
		public override JobHandle PostUpdate(JobHandle jobHandle) => default; // 0x000000018AACEA50-0x000000018AACEBC8
	}

	public class RenderMeshWorker : PhysicsManagerWorker // TypeDefIndex: 52502
	{
		// Nested types
		private struct CalcVertexUseFlagJob : IJobParallelFor // TypeDefIndex: 52499
		{
			// Fields
			public uint updateFlag; // 0x00
			public NativeArray<PhysicsManagerMeshData.RenderMeshInfo> renderMeshInfoList; // 0x08
			public NativeArray<PhysicsManagerMeshData.SharedRenderMeshInfo> sharedRenderMeshInfoList; // 0x18
			public NativeArray<byte> virtualVertexUseList; // 0x28
			public NativeArray<byte> virtualVertexFixList; // 0x38
			public NativeArray<uint> sharedChildVertexInfoList; // 0x48
			public NativeArray<MeshData.VertexWeight> sharedChildVertexWeightList; // 0x58
			public NativeArray<float3> sharedRenderVertices; // 0x68
			public NativeArray<float3> sharedRenderNormals; // 0x78
			public NativeArray<float4> sharedRenderTangents; // 0x88
			public NativeArray<byte> sharedBonesPerVertexList; // 0x98
			public NativeArray<int> sharedBonesPerVertexStartList; // 0xA8
			public NativeArray<BoneWeight1> sharedBoneWeightList; // 0xB8
			public NativeArray<float3> renderPosList; // 0xC8
			public NativeArray<float3> renderNormalList; // 0xD8
			public NativeArray<float4> renderTangentList; // 0xE8
			public NativeArray<BoneWeight1> renderBoneWeightList; // 0xF8
			public NativeArray<uint> renderVertexFlagList; // 0x108
			public NativeArray<float3> renderPosArray; // 0x118
			public NativeArray<float3> renderNormalArray; // 0x128
	
			// Methods
			public void Execute(int rmindex) {} // 0x0000000185492010-0x0000000185492020
		}
	
		private struct CollectLocalPositionNormalTangentForEachMeshJob : IJobParallelFor // TypeDefIndex: 52500
		{
			// Fields
			public NativeArray<PhysicsManagerMeshData.RenderMeshInfo> renderMeshInfoList; // 0x00
			public NativeArray<float3> transformPosList; // 0x10
			public NativeArray<quaternion> transformRotList; // 0x20
			public NativeArray<float3> transformSclList; // 0x30
			public NativeArray<uint> sharedChildVertexInfoList; // 0x40
			public NativeArray<MeshData.VertexWeight> sharedChildVertexWeightList; // 0x50
			public NativeArray<float3> virtualPosList; // 0x60
			public NativeArray<quaternion> virtualRotList; // 0x70
			public NativeArray<uint> renderVertexFlagList; // 0x80
			public NativeArray<float3> renderPosList; // 0x90
			public NativeArray<float3> renderNormalList; // 0xA0
			public NativeArray<float4> renderTangentList; // 0xB0
			public NativeArray<float3> renderPosArray; // 0xC0
			public NativeArray<float3> renderNormalArray; // 0xD0
	
			// Methods
			public void Execute(int rmindex) {} // 0x0000000185492010-0x0000000185492020
		}
	
		private struct CollectLocalPositionNormalTangentForEachVertexJob : IJobParallelFor // TypeDefIndex: 52501
		{
			// Fields
			public NativeArray<PhysicsManagerMeshData.RenderMeshInfo> renderMeshInfoList; // 0x00
			public NativeArray<float3> transformPosList; // 0x10
			public NativeArray<quaternion> transformRotList; // 0x20
			public NativeArray<float3> transformSclList; // 0x30
			public NativeArray<uint> sharedChildVertexInfoList; // 0x40
			public NativeArray<MeshData.VertexWeight> sharedChildVertexWeightList; // 0x50
			public NativeArray<float3> virtualPosList; // 0x60
			public NativeArray<quaternion> virtualRotList; // 0x70
			public NativeArray<uint> renderVertexFlagList; // 0x80
			public NativeArray<float3> renderPosList; // 0x90
			public NativeArray<float3> renderNormalList; // 0xA0
			public NativeArray<float4> renderTangentList; // 0xB0
			public NativeArray<float3> renderPosArray; // 0xC0
			public NativeArray<float3> renderNormalArray; // 0xD0
	
			// Methods
			public void Execute(int vindex) {} // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public RenderMeshWorker() {} // 0x000000018AABD49C-0x000000018AABD7F0
	
		// Methods
		public override void Create() {} // 0x000000018AACBD2C-0x000000018AACBDB4
		public override void Release() {} // 0x000000018AACC6C0-0x000000018AACCD7C
		public override void RemoveGroup(int group) {} // 0x0000000185FC6CA0-0x0000000185FC6CB0
		private bool IsPerformMeshProcessForEachParticle() => default; // 0x000000018AACBDB4-0x000000018AACC6C0
		public override void Warmup() {} // 0x000000018AACA7B4-0x000000018AACBD2C
		public override JobHandle PreUpdate(JobHandle jobHandle) => default; // 0x0000000185492010-0x0000000185492020
		public override JobHandle PostUpdate(JobHandle jobHandle) => default; // 0x000000018AABCBA4-0x000000018AABD140
		private static void CollectionVertex(in PhysicsManagerMeshData.RenderMeshInfo r_minfo, in NativeArray<uint> sharedChildVertexInfoList, in NativeArray<MeshData.VertexWeight> sharedChildVertexWeightList, in NativeArray<float3> virtualPosList, in NativeArray<quaternion> virtualRotList, in float3 tpos, in quaternion trot, in float3 tscl, in quaternion itrot, float scaleRatio, in float3 scaleDirection, bool calcNormal, bool calcTangent, int vindex, int i, uint flag, bool isFasterWrite, ref NativeArray<float3> renderPosList, ref NativeArray<float3> renderNormalList, ref NativeArray<float3> renderPosArray, ref NativeArray<float3> renderNomalArray, ref NativeArray<float4> renderTangentList) {} // 0x000000018AABD140-0x000000018AABD49C
	}

	public class SpringMeshWorker : PhysicsManagerWorker // TypeDefIndex: 52505
	{
		// Fields
		private ExNativeMultiHashMap<int, SpringData> springMap; // 0x18
		private FixedNativeListWithCount<int> springVertexList; // 0x20
		private Dictionary<int, List<int>> groupIndexDict; // 0x28
	
		// Nested types
		public struct SpringData // TypeDefIndex: 52503
		{
			// Fields
			public int particleIndex; // 0x00
			public float weight; // 0x04
		}
	
		private struct SpringJob : IJobParallelFor // TypeDefIndex: 52504
		{
			// Fields
			public NativeArray<int> springVertexList; // 0x00
			public NativeParallelMultiHashMap<int, SpringData> springMap; // 0x10
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x20
			public NativeArray<float3> particlePosList; // 0x30
			public NativeArray<quaternion> particleRotList; // 0x40
			public NativeArray<float3> snapBasePosList; // 0x50
			public NativeArray<quaternion> snapBaseRotList; // 0x60
			public NativeArray<float3> virtualPosList; // 0x70
			public NativeArray<byte> virtualVertexFlagList; // 0x80
			public NativeArray<short> virtualVertexMeshIndexList; // 0x90
			public NativeArray<PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList; // 0xA0
			private NativeParallelMultiHashMapIterator<int> iterator; // 0xB0
	
			// Methods
			public void Execute(int index) {} // 0x0000000185AE4C10-0x0000000185AE4CF0
		}
	
		// Constructors
		public SpringMeshWorker() {} // 0x000000018AACCF60-0x000000018AACD31C
	
		// Methods
		public override void Create() {} // 0x000000018AACD874-0x000000018AACD8DC
		public override void Release() {} // 0x000000018AACD31C-0x000000018AACD4AC
		public void Add(int group, int vertexIndex, int particleIndex, float weight) {} // 0x000000018AACD8DC-0x000000018AACDAE8
		public override void RemoveGroup(int group) {} // 0x0000000185492010-0x0000000185492020
		public override void Warmup() {} // 0x0000000185FC6CA0-0x0000000185FC6CB0
		public override JobHandle PreUpdate(JobHandle jobHandle) => default; // 0x000000018AACD4AC-0x000000018AACD874
		public override JobHandle PostUpdate(JobHandle jobHandle) => default; // 0x0000000184B2F2F0-0x0000000184B2F370
	}

	public class TriangleWorker : PhysicsManagerWorker // TypeDefIndex: 52509
	{
		// Fields
		private FixedChunkNativeArray<TriangleRotationData> triangleDataList; // 0x18
		private FixedChunkNativeArray<int> triangleIndexList; // 0x20
		public FixedNativeList<GroupData> groupList; // 0x28
	
		// Nested types
		[Serializable]
		public struct TriangleRotationData // TypeDefIndex: 52506
		{
			// Fields
			public int targetIndex; // 0x00
			public int triangleCount; // 0x04
			public int triangleStartIndex; // 0x08
			public quaternion localRot; // 0x0C
	
			// Methods
			public bool IsValid() => default; // 0x000000018558EAD0-0x000000018558EBE0
		}
	
		public struct GroupData // TypeDefIndex: 52507
		{
			// Fields
			public int teamId; // 0x00
			public ChunkData triangleDataChunk; // 0x04
			public ChunkData triangleIndexChunk; // 0x14
		}
	
		private struct TriangleRotationJob : IJobParallelFor // TypeDefIndex: 52508
		{
			// Fields
			public NativeArray<TriangleRotationData> triangleDataList; // 0x00
			public NativeArray<int> triangleIndexList; // 0x10
			public NativeArray<GroupData> groupList; // 0x20
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x30
			public NativeArray<int> teamIdList; // 0x40
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x50
			public NativeArray<float3> posList; // 0x60
			public NativeArray<quaternion> rotList; // 0x70
	
			// Methods
			public void Execute(int index) {} // 0x000000018AACE740-0x000000018AACE7C8
		}
	
		// Constructors
		public TriangleWorker() {} // 0x000000018AACDB44-0x000000018AACE220
	
		// Methods
		public override void Create() {} // 0x000000018AACE220-0x000000018AACE444
		public override void Release() {} // 0x000000018AACE7C8-0x000000018AACE990
		public int AddGroup(int teamId, TriangleRotationData[] dataArray, int[] indexArray) => default; // 0x0000000185492010-0x0000000185492020
		public override void RemoveGroup(int teamId) {} // 0x0000000185FC6CA0-0x0000000185FC6CB0
		public override void Warmup() {} // 0x000000018AACE444-0x000000018AACE740
		public override JobHandle PreUpdate(JobHandle jobHandle) => default; // 0x0000000185492010-0x0000000185492020
		public override JobHandle PostUpdate(JobHandle jobHandle) => default; // 0x0000000184091260-0x0000000184091270
	}

	public class VirtualMeshWorker : PhysicsManagerWorker // TypeDefIndex: 52514
	{
		// Nested types
		private struct ReadMeshPositionJob : IJobParallelFor // TypeDefIndex: 52510
		{
			// Fields
			public NativeArray<PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList; // 0x00
			public NativeArray<PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList; // 0x10
			public NativeArray<short> virtualVertexMeshIndexList; // 0x20
			public NativeArray<byte> virtualVertexUseList; // 0x30
			public NativeArray<int> virtualTransformIndexList; // 0x40
			public NativeArray<uint> sharedVirtualVertexInfoList; // 0x50
			public NativeArray<MeshData.VertexWeight> sharedVirtualWeightList; // 0x60
			public NativeArray<float3> transformPosList; // 0x70
			public NativeArray<quaternion> transformRotList; // 0x80
			public NativeArray<float3> transformSclList; // 0x90
			public NativeArray<float3> virtualPosList; // 0xA0
			public NativeArray<quaternion> virtualRotList; // 0xB0
			public NativeArray<byte> virtualVertexFlagList; // 0xC0
	
			// Methods
			public void Execute(int vindex) {} // 0x0000000185492010-0x0000000185492020
		}
	
		private struct CalcMeshTriangleNormalTangentJob : IJobParallelFor // TypeDefIndex: 52511
		{
			// Fields
			public NativeArray<PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList; // 0x00
			public NativeArray<PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList; // 0x10
			public NativeArray<ushort> virtualTriangleMeshIndexList; // 0x20
			public NativeArray<byte> virtualVertexUseList; // 0x30
			public NativeArray<float3> virtualPosList; // 0x40
			public NativeArray<int> sharedTriangles; // 0x50
			public NativeArray<float2> sharedMeshUv; // 0x60
			public NativeArray<float3> virtualTriangleNormalList; // 0x70
			public NativeArray<float3> virtualTriangleTangentList; // 0x80
			public NativeArray<float3> transformSclList; // 0x90
	
			// Methods
			public void Execute(int tindex) {} // 0x0000000185492010-0x0000000185492020
		}
	
		private struct CalcVertexNormalTangentFromTriangleJob : IJobParallelFor // TypeDefIndex: 52512
		{
			// Fields
			public NativeArray<PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList; // 0x00
			public NativeArray<PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList; // 0x10
			public NativeArray<short> virtualVertexMeshIndexList; // 0x20
			public NativeArray<byte> virtualVertexUseList; // 0x30
			public NativeArray<byte> virtualVertexFlagList; // 0x40
			public NativeArray<uint> sharedVirtualVertexToTriangleInfoList; // 0x50
			public NativeArray<int> sharedVirtualVertexToTriangleIndexList; // 0x60
			public NativeArray<float3> virtualTriangleNormalList; // 0x70
			public NativeArray<float3> virtualTriangleTangentList; // 0x80
			public NativeArray<quaternion> virtualRotList; // 0x90
	
			// Methods
			public void Execute(int vindex) {} // 0x0000000185492010-0x0000000185492020
		}
	
		private struct CalcMeshTriangleNormalTangentForEachMeshJob : IJobParallelFor // TypeDefIndex: 52513
		{
			// Fields
			public NativeArray<PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList; // 0x00
			public NativeArray<PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList; // 0x10
			public NativeArray<byte> virtualVertexUseList; // 0x20
			public NativeArray<byte> virtualVertexFlagList; // 0x30
			public NativeArray<float3> virtualPosList; // 0x40
			public NativeArray<int> sharedTriangles; // 0x50
			public NativeArray<float2> sharedMeshUv; // 0x60
			public NativeArray<uint> sharedVirtualVertexToTriangleInfoList; // 0x70
			public NativeArray<int> sharedVirtualVertexToTriangleIndexList; // 0x80
			public NativeArray<float3> transformSclList; // 0x90
			public NativeArray<float3> virtualTriangleNormalList; // 0xA0
			public NativeArray<float3> virtualTriangleTangentList; // 0xB0
			public NativeArray<quaternion> virtualRotList; // 0xC0
	
			// Methods
			public void Execute(int mindex) {} // 0x000000018AAE3D78-0x000000018AAE3E00
		}
	
		// Constructors
		public VirtualMeshWorker() {} // 0x000000018AACF308-0x000000018AACFC44
	
		// Methods
		public override void Create() {} // 0x0000000185492010-0x0000000185492020
		public override void Release() {} // 0x000000018AAE48B4-0x000000018AAE4D68
		public override void RemoveGroup(int group) {} // 0x000000018AAE3E00-0x000000018AAE48B4
		private bool IsPerformMeshProcessForEachParticle() => default; // 0x0000000185492010-0x0000000185492020
		public override void Warmup() {} // 0x000000018AAE0D20-0x000000018AAE16BC
		public override JobHandle PreUpdate(JobHandle jobHandle) => default; // 0x000000018AACFC44-0x000000018AAD0230
		public override JobHandle PostUpdate(JobHandle jobHandle) => default; // 0x000000018AAD0230-0x000000018AAD051C
	}

	public class AutoMove : MonoBehaviour // TypeDefIndex: 52515
	{
		// Fields
		private Vector3 direction; // 0x18
		private float length; // 0x24
		private float interval; // 0x28
		private Vector3 startPosition; // 0x2C
		private float time; // 0x38
	
		// Constructors
		public AutoMove() {} // 0x000000018AACEE9C-0x000000018AACEECC
	
		// Methods
		private void Start() {} // 0x000000018AACED04-0x000000018AACED44
		private void Update() {} // 0x000000018AACED44-0x000000018AACEE9C
		public void OnMoveButton() {} // 0x000000018AACECDC-0x000000018AACED04
	}

	public class AutoRotate : MonoBehaviour // TypeDefIndex: 52516
	{
		// Fields
		private Vector3 rotateAngle; // 0x18
		private float interval; // 0x24
		private float time; // 0x28
	
		// Constructors
		public AutoRotate() {} // 0x000000018AACEF88-0x000000018AACEFAC
	
		// Methods
		private void Start() {} // 0x0000000185492010-0x0000000185492020
		private void Update() {} // 0x000000018AACEECC-0x000000018AACEF88
		public void OnMoveButton() {} // 0x000000018AACECDC-0x000000018AACED04
	}

	public class BlastWaveController : MonoBehaviour // TypeDefIndex: 52518
	{
		// Fields
		public MagicaAreaWind wind; // 0x18
		public float attenuationStartTime; // 0x20
		public float attenuationTime; // 0x24
	
		// Nested types
		private sealed class _Start_d__3 : IEnumerator<object> // TypeDefIndex: 52517
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public BlastWaveController __4__this; // 0x20
			private float _main_5__2; // 0x28
			private float _time_5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public _Start_d__3() {} // Dummy constructor
			public _Start_d__3(int __1__state) {} // 0x000000018AACF2AC-0x000000018AACF308
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FAE630-0x0000000185FAE650
			private bool MoveNext() => default; // 0x0000000181378230-0x0000000181378240
			void IEnumerator.Reset() {} // 0x000000018AAE3828-0x000000018AAE39B8
		}
	
		// Constructors
		public BlastWaveController() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		private IEnumerator Start() => default; // 0x000000018AAE39B8-0x000000018AAE3A04
	}

	public class CameraOrbit : MonoBehaviour // TypeDefIndex: 52520
	{
		// Fields
		private Transform cameraTransform; // 0x18
		public Transform cameraTarget; // 0x20
		public Vector3 cameraTargetPos; // 0x28
		public Vector3 cameraTargetOffset; // 0x34
		private float cameraDist; // 0x40
		private float cameraPitch; // 0x44
		private float cameraYaw; // 0x48
		private float cameraDistHokanTime; // 0x4C
		private float cameraAngleHokanTime; // 0x50
		private float cameraDistSpeed; // 0x54
		private float cameraDistMax; // 0x58
		private float cameraDistMin; // 0x5C
		private float cameraYawSpeed; // 0x60
		private float cameraPitchSpeed; // 0x64
		private float cameraMaxAngleSpeed; // 0x68
		private float cameraPitchMax; // 0x6C
		private float cameraPitchMin; // 0x70
		private MoveMode moveMode; // 0x74
		private float moveSpeed; // 0x78
		private float setCameraDist; // 0x7C
		private float setCameraPitch; // 0x80
		private float setCameraYaw; // 0x84
		private float cameraDistVelocity; // 0x88
		private float cameraPitchVelocity; // 0x8C
		private float cameraYawVelocity; // 0x90
	
		// Nested types
		public enum MoveMode // TypeDefIndex: 52519
		{
			None = 0,
			UpDown = 1,
			Free = 2
		}
	
		// Constructors
		public CameraOrbit() {} // 0x000000018AAD0BF4-0x000000018AAD0C5C
	
		// Methods
		private void Start() {} // 0x000000018AAD0AFC-0x000000018AAD0BF4
		private void OnEnable() {} // 0x000000018AAD07D4-0x000000018AAD0A14
		private void OnDisable() {} // 0x000000018AAD0524-0x000000018AAD0764
		private void LateUpdate() {} // 0x000000018AAD051C-0x000000018AAD0524
		private void updateCamera() {} // 0x000000018AAD0C5C-0x000000018AAD0F38
		private void updatePitchYaw(Vector2 speed) {} // 0x000000018AAD1114-0x000000018AAD1180
		private void updateOffset(Vector2 speed) {} // 0x000000018AAD0F38-0x000000018AAD1114
		private void updateZoom(float speed) {} // 0x000000018AAD1180-0x000000018AAD11F8
		private void OnTouchMove(int fid, Vector2 screenPos, Vector2 screenVelocity, Vector2 cmVelocity) {} // 0x000000018AAD0A14-0x000000018AAD0A90
		private void OnDoubleTouchMove(int fid, Vector2 screenPos, Vector2 screenVelocity, Vector2 cmVelocity) {} // 0x000000018AAD0764-0x000000018AAD07D4
		private void OnTouchPinch(float speedscr, float speedcm) {} // 0x000000018AAD0A90-0x000000018AAD0AFC
	}

	public class CopyObject : MonoBehaviour // TypeDefIndex: 52522
	{
		// Fields
		public int seed; // 0x18
		public int count; // 0x1C
		public float radius; // 0x20
		public GameObject prefab; // 0x28
		public int delayFrame; // 0x30
	
		// Nested types
		private sealed class _CreateObject_d__7 : IEnumerator<object> // TypeDefIndex: 52521
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public CopyObject __4__this; // 0x20
			private int _i_5__2; // 0x28
			private int _j_5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018AAD1414-0x000000018AAD142C 
			object IEnumerator.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Constructors
			public _CreateObject_d__7() {} // Dummy constructor
			public _CreateObject_d__7(int __1__state) {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018AAD13F0-0x000000018AAD1414
			private bool MoveNext() => default; // 0x000000018AAD1394-0x000000018AAD13F0
			void IEnumerator.Reset() {} // 0x0000000181378230-0x0000000181378240
		}
	
		// Constructors
		public CopyObject() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		private void Awake() {} // 0x000000018AAE35F8-0x000000018AAE37DC
		private void Start() {} // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator CreateObject() => default; // 0x000000018AAE37DC-0x000000018AAE3828
	}

	public class DressUpControl : MonoBehaviour // TypeDefIndex: 52524
	{
		// Fields
		private GameObject partsItemPrefab; // 0x18
		private VerticalLayoutGroup verticalLayoutGroup; // 0x20
		private MagicaAvatar avatar; // 0x28
		public List<AvatarPartsGroup> avatarPartsGroupList; // 0x30
	
		// Nested types
		[Serializable]
		public class AvatarPartsGroup // TypeDefIndex: 52523
		{
			// Fields
			public string groupName; // 0x10
			public List<GameObject> partsPrefabList; // 0x18
			[NonSerialized]
			public int id; // 0x20
			[NonSerialized]
			public int handle; // 0x24
			[NonSerialized]
			public int index; // 0x28
	
			// Constructors
			public AvatarPartsGroup() {} // 0x000000018AAD1E88-0x000000018AAD1E90
		}
	
		// Constructors
		public DressUpControl() {} // 0x000000018AAD1E90-0x000000018AAD1E98
	
		// Methods
		private void Start() {} // 0x0000000185492010-0x0000000185492020
		private void Update() {} // 0x000000018AAD1E50-0x000000018AAD1E88
		private void OnDestroy() {} // 0x000000018AAD1C5C-0x000000018AAD1E50
		private void Init() {} // 0x000000018AAD1A1C-0x000000018AAD1B18
		private void ChangeParts(int id, int dir) {} // 0x000000018AAD1B18-0x000000018AAD1C5C
		public void Clear() {} // 0x000000018AAD1E98-0x000000018AAD1F18
		private void _Init_b__8_0(int id, int dir) {} // 0x000000018AACEFAC-0x000000018AACF024
	}

	public class ModelController : MonoBehaviour // TypeDefIndex: 52527
	{
		// Fields
		private List<GameObject> characterList; // 0x18
		private float slowTime; // 0x20
		private bool slow; // 0x24
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 52525
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<Animator> __9__7_0; // 0x08
			public static Action<Animator> __9__8_0; // 0x10
			public static Action<BaseCloth> __9__10_0; // 0x18
	
			// Constructors
			static __c() {} // 0x0000000185492010-0x0000000185492020
			public __c() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal void _OnNextButton_b__7_0(Animator ani) {} // 0x000000018AADEEDC-0x000000018AADF080
			internal void _OnBackButton_b__8_0(Animator ani) {} // 0x000000018AADF080-0x000000018AADF22C
			internal void _OnActiveButton_b__10_0(BaseCloth cloth) {} // 0x000000018AADF424-0x000000018AADF520
		}
	
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 52526
		{
			// Fields
			public float timeScale; // 0x10
	
			// Constructors
			public __c__DisplayClass9_0() {} // 0x000000018AADF328-0x000000018AADF424
	
			// Methods
			internal void _OnSlowButton_b__0(Animator ani) {} // 0x000000018AADF520-0x000000018AADF63C
			internal void _OnSlowButton_b__1(BaseCloth cloth) {} // 0x000000018AADF22C-0x000000018AADF328
		}
	
		// Constructors
		public ModelController() {} // 0x000000018AAE3B7C-0x000000018AAE3BA0
	
		// Methods
		private void Start() {} // 0x000000018AADF63C-0x000000018AADF6C4
		private void Update() {} // 0x000000018AAE3BA0-0x000000018AAE3C04
		private void AnimatorAction(Action<Animator> act) {} // 0x0000000185492010-0x0000000185492020
		private void ClothAction(Action<BaseCloth> act) {} // 0x000000018AAE3AA8-0x000000018AAE3AF0
		public void OnNextButton() {} // 0x000000018AAE3A60-0x000000018AAE3AA8
		public void OnBackButton() {} // 0x000000018AAE3A04-0x000000018AAE3A60
		public void OnSlowButton() {} // 0x0000000185492010-0x0000000185492020
		public void OnActiveButton() {} // 0x000000018AAE3B58-0x000000018AAE3B7C
	}

	public static class ObjectUtility // TypeDefIndex: 52528
	{
		// Methods
		public static GameObject[] PlaceRandomCubes(int count, Vector3 center, float radius) => default; // 0x000000018AAE09C8-0x000000018AAE0B6C
		public static GameObject[] PlaceRandomCubes(int count) => default; // 0x000000018AAE0B6C-0x000000018AAE0B98
		public static GameObject MakeStrippedCube() => default; // 0x000000018AAE091C-0x000000018AAE09C8
		public static GameObject[] PlaceRandomGameObject(int count, Vector3 center, float radius, GameObject prefab) => default; // 0x000000018AAE0B98-0x000000018AAE0D20
	}

	public class SimpleInputManager : CreateSingleton<MagicaCloth.SimpleInputManager> // TypeDefIndex: 52529
	{
		// Fields
		private const int MaxFinger = 3; // Metadata: 0x02076821
		public float tapRadiusCm; // 0x18
		public float flickRangeCm; // 0x1C
		public float flickCheckSpeed; // 0x20
		public float mouseWheelSpeed; // 0x24
		private int mainFingerId; // 0x28
		private int subFingerId; // 0x2C
		private Vector2[] downPos; // 0x30
		private Vector2[] lastPos; // 0x38
		private Vector2[] flickDownPos; // 0x40
		private float[] flickDownTime; // 0x48
		private float lastTime; // 0x50
		private bool mobilePlatform; // 0x54
		private bool[] mouseDown; // 0x58
		private Vector2[] mouseOldMovePos; // 0x60
		private float screenDpi; // 0x68
		private float screenDpc; // 0x6C
		public static UnityAction<int, Vector2> OnTouchDown; // 0x00
		public static UnityAction<int, Vector2, Vector2, Vector2> OnTouchMove; // 0x08
		public static UnityAction<int, Vector2, Vector2, Vector2> OnDoubleTouchMove; // 0x10
		public static UnityAction<int, Vector2> OnTouchUp; // 0x18
		public static UnityAction<int, Vector2> OnTouchMoveCancel; // 0x20
		public static UnityAction<int, Vector2> OnTouchTap; // 0x28
		public static UnityAction<int, Vector2, Vector2, Vector2> OnTouchFlick; // 0x30
		public static UnityAction<float, float> OnTouchPinch; // 0x38
		public static UnityAction OnBackButton; // 0x40
	
		// Properties
		public static float ScreenDpi { get => default; } // 0x000000018AAE3304-0x000000018AAE3348 
		public static float ScreenDpc { get => default; } // 0x000000018AAE32C0-0x000000018AAE3304 
	
		// Constructors
		public SimpleInputManager() {} // 0x000000018AAE3264-0x000000018AAE32C0
	
		// Methods
		private static void Init() {} // 0x0000000185FA7900-0x0000000185FA7930
		protected override void InitSingleton() {} // 0x000000018AAE1FAC-0x000000018AAE20C0
		private void Update() {} // 0x000000018AAE3244-0x000000018AAE3264
		private void CalcScreenDpi() {} // 0x000000018AAE1D78-0x000000018AAE1DB8
		private void AllResetTouchInfo() {} // 0x000000018AAE1D38-0x000000018AAE1D78
		public int GetTouchCount() => default; // 0x000000018AAE1FA4-0x000000018AAE1FAC
		public bool IsUI() => default; // 0x000000018AAE20C0-0x000000018AAE215C
		private void UpdateMobile() {} // 0x000000018AAE215C-0x000000018AAE29E8
		private Vector2 CalcScreenRatioVector(Vector2 vec) => default; // 0x000000018AAE1DB8-0x000000018AAE1E08
		private bool CheckFlic(int fid, Vector2 oldpos, Vector2 nowpos, Vector2 downpos, float flicktime) => default; // 0x000000018AAE1E08-0x000000018AAE1FA4
		private void UpdateMouse() {} // 0x000000018AAE29E8-0x000000018AAE3244
	}

	public class SliderStart : MonoBehaviour // TypeDefIndex: 52530
	{
		// Fields
		private UnityEngine.UI.Text text; // 0x18
		private string lable; // 0x20
		private string format; // 0x28
		private string formatString; // 0x30
	
		// Constructors
		public SliderStart() {} // 0x000000018AAE3590-0x000000018AAE35F8
	
		// Methods
		private void Start() {} // 0x000000018AAE3414-0x000000018AAE3590
		private void OnChangeValue(float value) {} // 0x000000018AAE3348-0x000000018AAE3414
	}

	public class UIPartsItem : MonoBehaviour // TypeDefIndex: 52532
	{
		// Fields
		public UnityEngine.UI.Text text; // 0x18
		public UnityEngine.UI.Button prefButton; // 0x20
		public UnityEngine.UI.Button nextButton; // 0x28
		private int id; // 0x30
	
		// Nested types
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 52531
		{
			// Fields
			public Action<int, int> onClick; // 0x10
			public UIPartsItem __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass5_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal void _Init_b__0() {} // 0x000000018AAE3C04-0x000000018AAE3D78
			internal void _Init_b__1() {} // 0x000000018646DB20-0x000000018646DB28
		}
	
		// Constructors
		public UIPartsItem() {} // 0x000000018AAE3B24-0x000000018AAE3B58
	
		// Methods
		private void Start() {} // 0x0000000185492010-0x0000000185492020
		public void Init(string title, int id, Action<int, int> onClick) {} // 0x000000018AAE3AF0-0x000000018AAE3B24
	}

	public class WindController : MonoBehaviour // TypeDefIndex: 52533
	{
		// Fields
		private WindZone unityWindZone; // 0x18
		private float unityWindZoneScale; // 0x20
		private Renderer arrowRenderer; // 0x28
		private Gradient arrowGradient; // 0x30
		private List<Transform> rotationTransforms; // 0x38
		private GameObject blastWavePrefab; // 0x40
		private float blastWaveSpawnRadius; // 0x48
		private float angleY; // 0x4C
		private float angleX; // 0x50
	
		// Properties
		private MagicaDirectionalWind Wind { get => default; } // 0x000000018AAE5320-0x000000018AAE535C 
	
		// Constructors
		public WindController() {} // 0x000000018AAE5258-0x000000018AAE5320
	
		// Methods
		private void Start() {} // 0x0000000185492010-0x0000000185492020
		public void OnDirectionY(float value) {} // 0x000000018AAE4EB4-0x000000018AAE4EC0
		public void OnDirectionX(float value) {} // 0x000000018AAE4EA8-0x000000018AAE4EB4
		public void OnMain(float value) {} // 0x000000018AAE4EF8-0x000000018AAE5040
		public void OnTurbulence(float value) {} // 0x000000018AAE5040-0x000000018AAE5078
		public void OnFrequency(float value) {} // 0x000000018AAE4EC0-0x000000018AAE4EF8
		public void OnBlastWave() {} // 0x000000018AAE4D68-0x000000018AAE4EA8
		private void UpdateDirection() {} // 0x000000018AAE5078-0x000000018AAE5258
	}

	[Serializable]
	public class BezierParam : IDataHash // TypeDefIndex: 52534
	{
		// Fields
		private float startValue; // 0x10
		private float endValue; // 0x14
		private bool useEndValue; // 0x18
		private float curveValue; // 0x1C
		private bool useCurveValue; // 0x20
	
		// Properties
		public float StartValue { get => default; } // 0x0000000181DCCCE0-0x0000000181DCCCF0 
		public float EndValue { get => default; } // 0x000000018AACF288-0x000000018AACF29C 
		public float CurveValue { get => default; } // 0x000000018AACF270-0x000000018AACF288 
		public bool UseCurve { get => default; } // 0x000000018AACF29C-0x000000018AACF2AC 
	
		// Constructors
		public BezierParam() {} // 0x0000000185492010-0x0000000185492020
		public BezierParam(float val) {} // 0x0000000185FCEED0-0x0000000185FCEEF0
		public BezierParam(float sval, float eval) {} // 0x0000000185FCEEF0-0x0000000185FCEF10
		public BezierParam(float sval, float eval, bool useEval, float cval, bool useCval) {} // 0x0000000185FCEEA0-0x0000000185FCEED0
	
		// Methods
		public void SetParam(float sval, float eval, bool useEval = true /* Metadata: 0x02076822 */, float cval = 0f /* Metadata: 0x02076823 */, bool useCval = false /* Metadata: 0x02076827 */) {} // 0x0000000185FCEEA0-0x0000000185FCEED0
		public float Evaluate(float x) => default; // 0x000000018AACF0FC-0x000000018AACF154
		public BezierParam AutoSetup(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x02076828 */) => default; // 0x000000018AACF024-0x000000018AACF088
		public int GetDataHash() => default; // 0x000000018AACF154-0x000000018AACF270
		public BezierParam Clone() => default; // 0x000000018AACF088-0x000000018AACF0FC
	}

	public interface IBoneReplace // TypeDefIndex: 52535
	{
		// Methods
		HashSet<Transform> GetUsedBones();
		void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class;
	}

	public interface IDataVerify // TypeDefIndex: 52536
	{
		// Methods
		int GetVersion();
		void CreateVerifyData();
		Define.Error VerifyData();
		string GetInformation();
	}

	public interface IEditorCloth // TypeDefIndex: 52537
	{
		// Methods
		List<int> GetSelectionList();
		List<int> GetUseList();
	}

	public interface IEditorMesh // TypeDefIndex: 52538
	{
		// Methods
		int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList);
		List<int> GetEditorTriangleList();
		List<int> GetEditorLineList();
	}

	public class RuntimeStatus // TypeDefIndex: 52539
	{
		// Fields
		private bool initStart; // 0x10
		private bool init; // 0x11
		private bool initError; // 0x12
		private bool enable; // 0x13
		private bool userEnable; // 0x14
		private bool runtimeError; // 0x15
		private bool dispose; // 0x16
		private bool isActive; // 0x17
		private bool isDirty; // 0x18
		private HashSet<RuntimeStatus> _parentStatusSet_k__BackingField; // 0x20
		private HashSet<RuntimeStatus> _childStatusSet_k__BackingField; // 0x28
		internal Action UpdateStatusAction; // 0x30
		internal Action DisconnectedAction; // 0x38
		internal Func<object> OwnerFunc; // 0x40
	
		// Properties
		internal HashSet<RuntimeStatus> parentStatusSet { get; private set; } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		internal HashSet<RuntimeStatus> childStatusSet { get; private set; } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public bool IsActive { get => default; } // 0x000000018AAE1D00-0x000000018AAE1D14 
		public bool IsInitStart { get => default; } // 0x0000000181C2FD60-0x0000000181C2FD70 
		public bool IsInitComplete { get => default; } // 0x0000000185FB22C0-0x0000000185FB22D0 
		public bool IsInitSuccess { get => default; } // 0x000000018AAE1D24-0x000000018AAE1D38 
		public bool IsInitError { get => default; } // 0x000000018AAE1D14-0x000000018AAE1D24 
		public bool IsDispose { get => default; } // 0x0000000185FCE890-0x0000000185FCE8A0 
		public bool IsDirty { get => default; } // 0x00000001813C0430-0x00000001813C0440 
	
		// Constructors
		public RuntimeStatus() {} // 0x000000018AAE1C54-0x000000018AAE1D00
	
		// Methods
		public void SetInitStart() {} // 0x0000000181B9A230-0x0000000181B9A240
		public void SetInitComplete() {} // 0x0000000185FBAD90-0x0000000185FBADA0
		public void SetInitError() {} // 0x0000000185FC5B90-0x0000000185FC5BA0
		public bool SetEnable(bool sw) => default; // 0x000000018AAE1A28-0x000000018AAE1A38
		public bool SetUserEnable(bool sw) => default; // 0x000000018AAE1A48-0x000000018AAE1A58
		public bool SetRuntimeError(bool sw) => default; // 0x000000018AAE1A38-0x000000018AAE1A48
		public void SetDispose() {} // 0x0000000185FCEFB0-0x0000000185FCEFC0
		public void SetDirty() {} // 0x0000000181B75280-0x0000000181B75290
		public void ClearDirty() {} // 0x0000000185FBD8D0-0x0000000185FBD8E0
		public bool UpdateStatus() => default; // 0x000000018AAE1A94-0x000000018AAE1C54
		public void AddParentStatus(RuntimeStatus status) {} // 0x000000018AAE1710-0x000000018AAE1764
		public void RemoveParentStatus(RuntimeStatus status) {} // 0x000000018AAE1984-0x000000018AAE1A28
		public void AddChildStatus(RuntimeStatus status) {} // 0x000000018AAE16BC-0x000000018AAE1710
		public void RemoveChildStatus(RuntimeStatus status) {} // 0x000000018AAE18E0-0x000000018AAE1984
		public void LinkParentStatus(RuntimeStatus parent) {} // 0x000000018AAE18A4-0x000000018AAE18E0
		public void UnlinkParentStatus(RuntimeStatus parent) {} // 0x000000018AAE1A58-0x000000018AAE1A94
		private bool IsParentStatusActive() => default; // 0x000000018AAE1764-0x000000018AAE18A4
	}

	public static class DataHashExtensions // TypeDefIndex: 52540
	{
		// Fields
		public const int NullHash = 397610387; // Metadata: 0x0207682C
		public const int NumberHash = 932781045; // Metadata: 0x02076831
	
		// Methods
		public static int GetDataHash(object data) => default; // 0x000000018AAD142C-0x000000018AAD1660
		public static int GetDataHash(IDataHash data) => default; // 0x000000018AAD1660-0x000000018AAD1678
		public static int GetDataHash<T>(T[] data) => default;
		public static int GetDataHash<T>(List<T> data) => default;
		public static int GetDataCountHash<T>(T[] data) => default;
		public static int GetDataCountHash<T>(List<T> data) => default;
		public static ulong GetVectorDataHash(Vector3 v) => default; // 0x000000018AAD1678-0x000000018AAD171C
	}

	public class GridHash // TypeDefIndex: 52542
	{
		// Fields
		protected Dictionary<uint, List<Point>> gridMap; // 0x10
		protected float gridSize; // 0x18
	
		// Nested types
		public class Point // TypeDefIndex: 52541
		{
			// Fields
			public int id; // 0x10
			public float3 pos; // 0x14
	
			// Constructors
			public Point() {} // 0x000000018AAD427C-0x000000018AAD4304
		}
	
		// Constructors
		public GridHash() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public virtual void Create(float gridSize = 0.1f /* Metadata: 0x02076836 */) {} // 0x000000018AAD40AC-0x000000018AAD4234
		public virtual void AddPoint(float3 pos, int id) {} // 0x000000018AAD43EC-0x000000018AAD4534
		public virtual void Remove(float3 pos, int id) {} // 0x000000018AAD4234-0x000000018AAD427C
		public void Clear() {} // 0x000000018AAD4368-0x000000018AAD43EC
		public static int3 GetGridPos(float3 pos, float gridSize) => default; // 0x0000000185FCEF80-0x0000000185FCEFB0
		public static uint GetGridHash(int3 pos) => default; // 0x000000018AAD4304-0x000000018AAD4368
		public static uint GetGridHash(float3 pos, float gridSize) => default; // 0x0000000185FB8130-0x0000000185FB8140
	}

	public class NearPointSearch : GridHash // TypeDefIndex: 52543
	{
		// Fields
		private float radius; // 0x20
		private Dictionary<int, int> nearDict; // 0x28
		private Dictionary<int, float> distDict; // 0x30
		private HashSet<uint> lockPairSet; // 0x38
	
		// Constructors
		public NearPointSearch() {} // 0x000000018AAE0808-0x000000018AAE091C
	
		// Methods
		public void Create(float3[] positionList, float radius) {} // 0x000000018AADF75C-0x000000018AADF7E8
		public void SearchNearPointAll() {} // 0x000000018AADFB18-0x000000018AADFD98
		public void SearchNearPoint(int id, float3 pos) {} // 0x000000018AADFD98-0x000000018AAE0264
		public void SearchNearPoint(float3 pos, float r) {} // 0x000000018AAE0264-0x000000018AAE05C0
		public override void AddPoint(float3 pos, int id) {} // 0x000000018AADF734-0x000000018AADF75C
		public override void Remove(float3 pos, int id) {} // 0x000000018AADFA48-0x000000018AADFB18
		public void AddLockPair(int id1, int id2) {} // 0x000000018AADF6C4-0x000000018AADF734
		public bool GetNearPointPair(out int id1, out int id2) {
			id1 = default;
			id2 = default;
			return default;
		} // 0x000000018AADF7E8-0x000000018AADFA48
		public override string ToString() => default; // 0x000000018AAE05C0-0x000000018AAE0808
	}

	public struct ChunkData // TypeDefIndex: 52544
	{
		// Fields
		public int chunkNo; // 0x00
		public int startIndex; // 0x04
		public int dataLength; // 0x08
		public int useLength; // 0x0C
	
		// Methods
		public void Clear() {} // 0x0000000185FCEF10-0x0000000185FCEF20
		public bool IsValid() => default; // 0x0000000186476414-0x000000018647641C
		public override string ToString() => default; // 0x000000018AAD11F8-0x000000018AAD1394
	}

	public class DoubleComputeBuffer<T> : IDisposable // TypeDefIndex: 52545
		where T : struct
	{
		// Fields
		private ComputeBuffer buffer0;
		private ComputeBuffer buffer1;
		private NativeArray<T> nativeArrya;
		public uint bufferID;
		public uint bufferOffset;
		public int bufferCount;
	
		// Properties
		public int Count { get => default; }
	
		// Constructors
		public DoubleComputeBuffer() {}
	
		// Methods
		public void Dispose() {}
		public void Swap() {}
		public void Create(int size, ComputeBufferType type, ComputeBufferMode usage) {}
		public void BeginWrite(int length) {}
		public void EndWrite(int length) {}
		public NativeArray<T> GetNativeArray() => default;
		public ComputeBuffer GetBuffer(int bufferIndex = 0 /* Metadata: 0x0207683A */) => default;
	}

	public class ExNativeHashMap<TKey, TValue> // TypeDefIndex: 52546
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Fields
		private NativeParallelHashMap<TKey, TValue> nativeHashMap;
		private int nativeLength;
		private HashSet<TKey> useKeySet;
	
		// Properties
		private int NativeCount { get => default; }
		public int Count { get => default; }
		public NativeParallelHashMap<TKey, TValue> Map { get => default; }
		public HashSet<TKey> UseKeySet { get => default; }
	
		// Constructors
		public ExNativeHashMap() {}
	
		// Methods
		public void Dispose() {}
		public void Add(TKey key, TValue value) {}
		public TValue Get(TKey key) => default;
		public void Remove(Func<TKey, TValue, bool> func) {}
		public void Replace(Func<TKey, TValue, bool> func, Func<TValue, TValue> datafunc) {}
		public void Remove(TKey key) {}
		public void Clear() {}
	}

	public class ExNativeMultiHashMap<TKey, TValue> // TypeDefIndex: 52547
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Fields
		private NativeParallelMultiHashMap<TKey, TValue> nativeMultiHashMap;
		private int nativeLength;
		private Dictionary<TKey, int> useKeyDict;
	
		// Properties
		private int NativeCount { get => default; }
		public bool IsCreated { get => default; }
		public int Count { get => default; }
		public NativeParallelMultiHashMap<TKey, TValue> Map { get => default; }
	
		// Constructors
		public ExNativeMultiHashMap() {}
	
		// Methods
		public void Dispose() {}
		public void Add(TKey key, TValue value) {}
		public void Remove(TKey key, TValue value) {}
		public void Remove(Func<TKey, TValue, bool> func) {}
		public void Replace(Func<TKey, TValue, bool> func, Func<TValue, TValue> datafunc) {}
		public void Process(Action<TKey, TValue> act) {}
		public void Process(TKey key, Action<TValue> act) {}
		public bool Contains(TKey key, TValue value) => default;
		public bool Contains(TKey key) => default;
		public void Remove(TKey key) {}
		public void Clear() {}
	}

	public class FixedChunkNativeArray<T> : IDisposable // TypeDefIndex: 52548
		where T : struct
	{
		// Fields
		private NativeArray<T> nativeArray0;
		private NativeArray<T> nativeArray1;
		private int nativeLength;
		private List<ChunkData> emptyChunkList;
		private List<ChunkData> useChunkList;
		private int chunkSeed;
		private int initLength;
		private T emptyElement;
		private int useLength;
	
		// Properties
		public int Length { get => default; }
		public int ChunkCount { get => default; }
		public int Count { get => default; }
		public T this[int index] { get => default; set {} }
	
		// Constructors
		public FixedChunkNativeArray() {}
	
		// Methods
		public void Dispose() {}
		public void SetEmptyElement(T empty) {}
		public ChunkData AddChunk(int length) => default;
		public ChunkData Add(T data) => default;
		public void RemoveChunk(int chunkNo) {}
		public void RemoveChunk(ChunkData chunk) {}
		public void Fill(ChunkData chunk, T data) {}
		public NativeArray<T> ToJobArray() => default;
		public NativeArray<T> ToJobArray(int bufferIndex) => default;
		public void SwapBuffer() {}
		public override string ToString() => default;
	}

	public class FixedMultiNativeList<T> : IDisposable // TypeDefIndex: 52549
		where T : struct
	{
		// Fields
		private NativeArray<T> nativeArray;
		private int nativeLength;
		private List<ChunkData> emptyChunkList;
		private List<ChunkData> useChunkList;
		private int chunkSeed;
		private int initLength;
		private T emptyElement;
		private int useLength;
	
		// Properties
		public int Length { get => default; }
		public int ChunkCount { get => default; }
		public int Count { get => default; }
		public T this[int index] { get => default; }
	
		// Constructors
		public FixedMultiNativeList() {}
	
		// Methods
		public void Dispose() {}
		public void SetEmptyElement(T empty) {}
		public ChunkData AddChunk(int length) => default;
		public void RemoveChunk(int chunkNo) {}
		public void RemoveChunk(ChunkData chunk) {}
		public ChunkData AddData(ChunkData chunk, T data) => default;
		public ChunkData RemoveData(ChunkData chunk, T data) => default;
		public ChunkData ClearData(ChunkData chunk) => default;
		public void Process(ChunkData chunk, Action<T> act) {}
		public NativeArray<T> ToJobArray() => default;
		public override string ToString() => default;
	}

	public class FixedNativeList<T> : IDisposable // TypeDefIndex: 52550
		where T : struct
	{
		// Fields
		private NativeArray<T> nativeArray0;
		private NativeArray<T> nativeArray1;
		private int nativeLength;
		private Queue<int> emptyStack;
		private HashSet<int> useIndexSet;
		private int useLength;
	
		// Properties
		public int Length { get => default; }
		public int Count { get => default; }
		public T this[int index] { get => default; set {} }
	
		// Constructors
		public FixedNativeList() {}
	
		// Methods
		public void Dispose() {}
		public int Add(T element) => default;
		public void Remove(int index) {}
		public bool Exists(int index) => default;
		public void Clear() {}
		public NativeArray<T> ToJobArray() => default;
		public NativeArray<T> ToJobArray(int bufferIndex) => default;
		public void SyncBuffer() {}
	}

	public class FixedNativeListWithCount<T> : IDisposable // TypeDefIndex: 52551
		where T : struct
	{
		// Fields
		private NativeList<T> nativeList;
		private int nativeLength;
		private Queue<int> emptyStack;
		private HashSet<int> useIndexSet;
		private Dictionary<T, int> indexDict;
		private Dictionary<T, int> countDict;
		private T emptyElement;
	
		// Properties
		public int Length { get => default; }
		public int Count { get => default; }
		public T this[int index] { get => default; set {} }
	
		// Constructors
		public FixedNativeListWithCount() {}
		public FixedNativeListWithCount(int capacity) {}
	
		// Methods
		public void Dispose() {}
		public void SetEmptyElement(T empty) {}
		public int Add(T element) => default;
		public void Remove(T element) {}
		public bool Exist(T element) => default;
		public int GetUseCount(T element) => default;
		public void Clear() {}
		public T[] ToArray() => default;
		public NativeArray<T> ToJobArray() => default;
	}

	public class FixedTransformAccessArray : IDisposable // TypeDefIndex: 52552
	{
		// Fields
		private TransformAccessArray transformArray; // 0x10
		private int nativeLength; // 0x18
		private Queue<int> emptyStack; // 0x20
		private Dictionary<int, int> useIndexDict; // 0x28
		private Dictionary<int, int> indexDict; // 0x30
		private Dictionary<int, int> referenceDict; // 0x38
	
		// Properties
		public int Count { get => default; } // 0x000000018440AD40-0x000000018440AD90 
		public int Length { get => default; } // 0x00000001813AE560-0x00000001813AE570 
		public Transform this[int index] { get => default; } // 0x000000018766A460-0x000000018766A46C 
	
		// Constructors
		public FixedTransformAccessArray() {} // Dummy constructor
		public FixedTransformAccessArray(int desiredJobCount = -1 /* Metadata: 0x0207683B */) {} // 0x0000000184B34840-0x0000000184B349A0
		public FixedTransformAccessArray(int capacity, int desiredJobCount) {} // 0x000000018AAD26A0-0x000000018AAD2814
	
		// Methods
		public int Add(Transform element) => default; // 0x000000018AAD1F18-0x000000018AAD20F0
		public void Remove(int index) {} // 0x000000018AAD2528-0x000000018AAD26A0
		public bool Exist(int index) => default; // 0x000000018AAD2418-0x000000018AAD246C
		public bool Exist(Transform element) => default; // 0x000000018AAD2384-0x000000018AAD2418
		public int GetIndex(Transform element) => default; // 0x000000018AAD246C-0x000000018AAD2528
		public void Clear() {} // 0x000000018AAD20F0-0x000000018AAD22DC
		public void Dispose() {} // 0x000000018AAD22DC-0x000000018AAD2384
		public TransformAccessArray GetTransformAccessArray() => default; // 0x000000018346D130-0x000000018346D140
	}

	public static class NativeArrayExtension // TypeDefIndex: 52553
	{
		// Methods
		public static void CopyToFast<T, T2>(NativeArray<T> nativeArray, int startIndex, T2[] array)
			where T : struct
			where T2 : struct {}
		public static void CopyToFast<T>(NativeArray<T> nativeArray, int startIndex, NativeArray<T> array)
			where T : struct {}
		public static void CopyBlock<T>(NativeArray<T> nativeArray, int sourceIndex, int destinationIndex, int count)
			where T : struct {}
		public static void CopyFromFast<T>(NativeArray<T> nativeArray, NativeArray<T> array)
			where T : struct {}
		public static void CopyFromFast<T, T2>(NativeArray<T> nativeArray, int startIndex, T2[] array)
			where T : struct
			where T2 : struct {}
		public static void SetValue<T>(NativeArray<T> nativeArray, int startIndex, int count, T value)
			where T : struct {}
	}

	public abstract class CreateSingleton<T> : MonoBehaviour // TypeDefIndex: 52554
		where T : MonoBehaviour
	{
		// Fields
		private static T instance;
		private static T initInstance;
		private static bool isDestroy;
	
		// Properties
		public static T Instance { get; }
	
		// Constructors
		protected CreateSingleton() {}
	
		// Methods
		protected static void InitMember() {}
		private static void InitInstance() {}
		public static bool IsInstance() => default;
		protected virtual void Awake() {}
		protected virtual void OnDestroy() {}
		protected virtual void DuplicateDetection(T duplicate) {}
		protected abstract void InitSingleton();
	}

	public static class DataUtility // TypeDefIndex: 52555
	{
		// Methods
		public static uint PackPair(int v0, int v1) => default; // 0x000000018773F538-0x000000018773F550
		public static void UnpackPair(uint pack, out int v0, out int v1) {
			v0 = default;
			v1 = default;
		} // 0x0000000185FCE970-0x0000000185FCE980
		public static uint Pack16(int hi, int low) => default; // 0x0000000185FB1310-0x0000000185FB1320
		public static int Unpack16Hi(uint pack) => default; // 0x0000000185FB13F0-0x0000000185FB1400
		public static int Unpack16Low(uint pack) => default; // 0x0000000185FB1400-0x0000000185FB1410
		public static uint Pack4_28(int hi, int low) => default; // 0x0000000185FCEF20-0x0000000185FCEF30
		public static int Unpack4_28Hi(uint pack) => default; // 0x0000000185FCEF40-0x0000000185FCEF50
		public static int Unpack4_28Low(uint pack) => default; // 0x0000000185FCEF50-0x0000000185FCEF60
		public static uint Pack8_24(int hi, int low) => default; // 0x0000000185FCEF30-0x0000000185FCEF40
		public static int Unpack8_24Hi(uint pack) => default; // 0x0000000185FCEF60-0x0000000185FCEF70
		public static int Unpack8_24Low(uint pack) => default; // 0x0000000185FCEF70-0x0000000185FCEF80
		public static ulong Pack32(int hi, int low) => default; // 0x0000000185FBDD60-0x0000000185FBDD70
		public static int Unpack32Hi(ulong pack) => default; // 0x0000000185FC9980-0x0000000185FC9990
		public static int Unpack32Low(ulong pack) => default; // 0x0000000185FB2C30-0x0000000185FB2C40
		public static ulong PackTriple(int v0, int v1, int v2) => default; // 0x000000018AAD1894-0x000000018AAD19D0
		public static void UnpackTriple(ulong pack, out int v0, out int v1, out int v2) {
			v0 = default;
			v1 = default;
			v2 = default;
		} // 0x0000000185FCE9B0-0x0000000185FCE9D0
		public static ulong PackQuater(int v0, int v1, int v2, int v3) => default; // 0x000000018AAD171C-0x000000018AAD1894
		public static void UnpackQuater(ulong pack, out int v0, out int v1, out int v2, out int v3) {
			v0 = default;
			v1 = default;
			v2 = default;
			v3 = default;
		} // 0x0000000185FCE980-0x0000000185FCE9B0
	}

	public static class Develop // TypeDefIndex: 52556
	{
		// Methods
		public static void Log(string str) {} // 0x000000018AAD19D0-0x000000018AAD1A1C
	}

	public static class GizmoUtility // TypeDefIndex: 52557
	{
		// Fields
		public static readonly UnityEngine.Color ColorDynamic; // 0x00
		public static readonly UnityEngine.Color ColorKinematic; // 0x10
		public static readonly UnityEngine.Color ColorInvalid; // 0x20
		public static readonly UnityEngine.Color ColorCollider; // 0x30
		public static readonly UnityEngine.Color ColorNonSelectedCollider; // 0x40
		public static readonly UnityEngine.Color ColorTriangle; // 0x50
		public static readonly UnityEngine.Color ColorStructLine; // 0x60
		public static readonly UnityEngine.Color ColorBendLine; // 0x70
		public static readonly UnityEngine.Color ColorNearLine; // 0x80
		public static readonly UnityEngine.Color ColorRotationLine; // 0x90
		public static readonly UnityEngine.Color ColorAdjustLine; // 0xA0
		public static readonly UnityEngine.Color ColorAirLine; // 0xB0
		public static readonly UnityEngine.Color ColorBasePosition; // 0xC0
		public static readonly UnityEngine.Color ColorDirectionMoveLimit; // 0xD0
		public static readonly UnityEngine.Color ColorPenetration; // 0xE0
		public static readonly UnityEngine.Color ColorCollisionNormal; // 0xF0
		public static readonly UnityEngine.Color ColorVelocity; // 0x100
		public static readonly UnityEngine.Color ColorSkinningBone; // 0x110
		public static readonly UnityEngine.Color ColorDeformerPoint; // 0x120
		public static readonly UnityEngine.Color ColorDeformerPointRange; // 0x130
		public static readonly UnityEngine.Color ColorWind; // 0x140
	
		// Constructors
		static GizmoUtility() {} // 0x000000018AAD3E48-0x000000018AAD40AC
	
		// Methods
		public static void DrawWireCapsule(Vector3 pos, Quaternion rot, Vector3 scl, Vector3 ldir, Vector3 lup, float length, float startRadius, float endRadius, bool resetMatrix = true /* Metadata: 0x0207683C */) {} // 0x000000018AAD3210-0x000000018AAD3680
		public static void DrawWireSphere(Vector3 pos, Quaternion rot, Vector3 scl, float radius, bool drawSphere, bool drawAxis, bool resetMatrix = true /* Metadata: 0x0207683D */) {} // 0x000000018AAD3BB0-0x000000018AAD3E48
		public static void DrawWireCube(Vector3 pos, Quaternion rot, Vector3 size, bool resetMatrix = true /* Metadata: 0x0207683E */) {} // 0x000000018AAD3A94-0x000000018AAD3BB0
		public static void DrawWireCone(Vector3 pos, Quaternion rot, float length, float radius, int div = 8 /* Metadata: 0x0207683F */) {} // 0x000000018AAD3680-0x000000018AAD3A94
		public static void DrawWireArrow(Vector3 pos, Quaternion rot, Vector3 size, bool cross = false /* Metadata: 0x02076840 */) {} // 0x000000018AAD2E94-0x000000018AAD3210
		public static void DrawAxis(Vector3 pos, Quaternion rot, float size, bool resetMatrix = true /* Metadata: 0x02076841 */) {} // 0x000000018AAD2814-0x000000018AAD2A68
		public static void DrawBone(Vector3 pos, Vector3 tpos, float size) {} // 0x000000018AAD2A68-0x000000018AAD2E94
	}

	public static class MathUtility // TypeDefIndex: 52558
	{
		// Methods
		public static float Clamp1(float a) => default; // 0x00000001877419EC-0x0000000187741A04
		public static float Clamp01(float a) => default; // 0x000000018AAD4660-0x000000018AAD4670
		public static float3 Project(float3 v, float3 n) => default; // 0x000000018AA95BD8-0x000000018AA95C50
		public static float Angle(float3 v1, float3 v2) => default; // 0x0000000187668A90-0x0000000187668B60
		public static float3 ClampVector(float3 v, float minlength, float maxlength) => default; // 0x000000018AA957AC-0x000000018AA95880
		public static float3 ClampVector(float3 v, float maxlength) => default; // 0x000000018AAD4988-0x000000018AAD4A34
		public static float3 ClampDistance(float3 from, float3 to, float maxlength) => default; // 0x000000018AAA9E38-0x000000018AAA9EFC
		public static bool ClampAngle(float3 dir, float3 basedir, float maxAngle, out float3 outdir) {
			outdir = default;
			return default;
		} // 0x000000018AAD4670-0x000000018AAD48F0
		public static quaternion FromToRotation(float3 from, float3 to, float t = 1f /* Metadata: 0x02076842 */) => default; // 0x000000018AAD5784-0x000000018AAD59C4
		public static quaternion FromToRotation(quaternion from, quaternion to) => default; // 0x00000001876DA734-0x00000001876DAA98
		public static float Angle(quaternion a, quaternion b) => default; // 0x000000018AAD4534-0x000000018AAD4598
		public static quaternion ClampAngle(quaternion from, quaternion to, float maxAngle) => default; // 0x000000018AAD48F0-0x000000018AAD4988
		public static float3 AxisToEuler(float3 axis) => default; // 0x000000018AAD4598-0x000000018AAD4660
		public static quaternion AxisQuaternion(float3 dir) => default; // 0x000000018AAB927C-0x000000018AABA8C8
		public static float ClosestPtPointSegmentRatio(float3 c, float3 a, float3 b) => default; // 0x000000018AA95880-0x000000018AA95968
		public static float ClosestPtPointSegmentRatioNoClamp(float3 c, float3 a, float3 b) => default; // 0x000000018AAD4B7C-0x000000018AAD4C58
		public static float3 ClosestPtPointSegment(float3 c, float3 a, float3 b) => default; // 0x000000018AA6E340-0x000000018AA6E49C
		public static float3 ClosestPtPointSegmentNoClamp(float3 c, float3 a, float3 b) => default; // 0x000000018AAD4A34-0x000000018AAD4B7C
		public static bool IntersectPointPlane(float3 planePos, float3 planeDir, float3 pos, out float3 outpos) {
			outpos = default;
			return default;
		} // 0x000000018AA95AC8-0x000000018AA95BD8
		public static float IntersectPointPlaneDist(float3 planePos, float3 planeDir, float3 pos, out float3 outPos) {
			outPos = default;
			return default;
		} // 0x000000018AA95968-0x000000018AA95AC8
		public static bool IntersectSegmentPlane(float3 a, float3 b, float3 p, float3 pn, out float3 opos) {
			opos = default;
			return default;
		} // 0x000000018AAD7644-0x000000018AAD77C0
		public static bool IntersectPointSphere(float3 sc, float sr, float3 pos, out float3 outPos) {
			outPos = default;
			return default;
		} // 0x000000018AAD6DE0-0x000000018AAD6F30
		public static bool IntersectPointSphere(float3 p, float3 sc, float sr) => default; // 0x000000018AACEC6C-0x000000018AACECDC
		public static bool IntersectRaySphere(float3 p, float3 d, float3 sc, float sr, out float3 q, out float t) {
			q = default;
			t = default;
			return default;
		} // 0x000000018AAD74A8-0x000000018AAD7644
		public static bool IntersectLineSphare(float3 a, float3 b, float3 sc, float sr, out float3 q) {
			q = default;
			return default;
		} // 0x000000018AAD6820-0x000000018AAD69D0
		public static bool IntersectRayCone(float3 o, float3 d, float3 c, float3 v, float cost, out float t, out float3 p) {
			t = default;
			p = default;
			return default;
		} // 0x000000018AAD6F30-0x000000018AAD74A8
		public static bool IntersectLineConeSurface(float3 a, float3 b, float3 d, float dlen, float3 c, float3 v, float cost, float3 c1, float3 c2, out float3 p) {
			p = default;
			return default;
		} // 0x000000018AAD5D7C-0x000000018AAD5F38
		public static bool IntersectLineCylinderSurface(float3 sa, float3 sb, float3 p, float3 q, float r, out float t) {
			t = default;
			return default;
		} // 0x000000018AAD6408-0x000000018AAD6820
		public static bool IntersectLineCylinderSurface(float3 a, float3 b, float3 c1, float3 c2, float r1, float r2, out float3 p) {
			p = default;
			return default;
		} // 0x000000018AAD5F38-0x000000018AAD6408
		public static bool IntersectLineCapsule(float3 a, float3 b, float3 c1, float3 c2, float r1, float r2, out float3 p) {
			p = default;
			return default;
		} // 0x000000018AAD5A1C-0x000000018AAD5D7C
		public static bool IntersectTrianglePointDistance(float3 p, float3 p0, float3 p1, float3 p2, float restDist, float compressionStiffness, float stretchStiffness, out float3 corr, out float3 corr0, out float3 corr1, out float3 corr2) {
			corr = default;
			corr0 = default;
			corr1 = default;
			corr2 = default;
			return default;
		} // 0x000000018AAD8C28-0x000000018AAD95FC
		public static bool IntersectTrianglePointDistanceSide(float3 p, float3 p0, float3 p1, float3 p2, float restDist, float compressionStiffness, float stretchStiffness, float side, out float3 corr, out float3 corr0, out float3 corr1, out float3 corr2) {
			corr = default;
			corr0 = default;
			corr1 = default;
			corr2 = default;
			return default;
		} // 0x000000018AAD819C-0x000000018AAD8C28
		public static bool IntersectTrianglePointDistanceSide2(float3 p, float3 p0, float3 p1, float3 p2, float radius, float restDist, float compressionStiffness, float stretchStiffness, float side, out float3 corr, out float3 corr0, out float3 corr1, out float3 corr2) {
			corr = default;
			corr0 = default;
			corr1 = default;
			corr2 = default;
			return default;
		} // 0x000000018AAD77C0-0x000000018AAD819C
		public static float DistanceTrianglePoint(float3 p, float3 p0, float3 p1, float3 p2) => default; // 0x000000018AAD5144-0x000000018AAD5784
		public static float3 TriangleCenter(float3 p0, float3 p1, float3 p2) => default; // 0x000000018774531C-0x00000001877453D0
		public static float3 TriangleNormal(float3 p0, float3 p1, float3 p2) => default; // 0x000000018AA6E49C-0x000000018AA6E578
		public static quaternion TriangleRotation(float3 p0, float3 p1, float3 p2) => default; // 0x000000018AAD97A0-0x000000018AAD98FC
		public static quaternion TriangleCenterRotation(float3 p0, float3 p1, float3 p2, float3 p3) => default; // 0x000000018AAD95FC-0x000000018AAD97A0
		public static float DistanceTriangleCenter(float3 p, float3 p0, float3 p1, float3 p2) => default; // 0x0000000187742744-0x0000000187742810
		public static float DirectionPointTriangle(float3 p, float3 a, float3 b, float3 c) => default; // 0x0000000187742628-0x0000000187742744
		public static bool IntersectLineTriangle(float3 p, float3 q, float3 a, float3 b, float3 c, out float3 hitpos, out float t, out float3 n) {
			hitpos = default;
			t = default;
			n = default;
			return default;
		} // 0x000000018AAD69D0-0x000000018AAD6DE0
		public static float ClosestPtSegmentSegment(float3 p1, float3 q1, float3 p2, float3 q2, out float s, out float t, out float3 c1, out float3 c2) {
			s = default;
			t = default;
			c1 = default;
			c2 = default;
			return default;
		} // 0x000000018AAD4C58-0x000000018AAD5144
		public static float GetBezierValue(BezierParam bparam, float t) => default; // 0x000000018AAD59C4-0x000000018AAD5A1C
		public static float GetBezierValue(float sval, float eval, float curve, float t) => default; // 0x000000018AACEBE0-0x000000018AACEC6C
	}

	public static class MeshUtility // TypeDefIndex: 52561
	{
		// Nested types
		private class TetraVertex // TypeDefIndex: 52559
		{
			// Fields
			public int index; // 0x10
			public Vector3 pos; // 0x14
	
			// Constructors
			public TetraVertex() {} // 0x000000018AADEA64-0x000000018AADED48
			public TetraVertex(Vector3 pos, int index) {} // 0x000000018AADA6C4-0x000000018AADAD04
		}
	
		private class Tetra // TypeDefIndex: 52560
		{
			// Fields
			public List<TetraVertex> vertexList; // 0x10
			public Vector3 circumCenter; // 0x18
			public float circumRadius; // 0x24
			public Vector3 tetraCenter; // 0x28
			public float tetraSize; // 0x34
	
			// Constructors
			public Tetra() {} // 0x000000018AADAD04-0x000000018AADB780
			public Tetra(TetraVertex a, TetraVertex b, TetraVertex c, TetraVertex d) {} // 0x000000018AAD9A1C-0x000000018AADA6C4
	
			// Methods
			public ulong GetTetraHash() => default; // 0x000000018AADDF2C-0x000000018AADE2A0
			public void CalcCircumcircle() {} // 0x000000018AADE640-0x000000018AADE8C0
			public bool IntersectCircumcircle(Vector3 pos) => default; // 0x000000018AADE8C0-0x000000018AADEA64
			public bool CheckSame(Tetra tri) => default; // 0x000000018AADEE4C-0x000000018AADEEDC
			public bool ContainsPoint(TetraVertex p1) => default; // 0x000000018AADED48-0x000000018AADEE4C
			public bool ContainsPoint(TetraVertex p1, TetraVertex p2, TetraVertex p3, TetraVertex p4) => default; // 0x000000018AADD91C-0x000000018AADD9E0
			public void CalcSize() {} // 0x000000018AADDC84-0x000000018AADDDF0
			public bool Verification() => default; // 0x000000018AAD98FC-0x000000018AAD9A1C
		}
	
		// Methods
		public static GameObject ReplaceSkinnedMeshRendererToMeshRenderer(SkinnedMeshRenderer sren, bool replaceSkinnedMeshRenderer) => default; // 0x000000018AADDDF0-0x000000018AADDF2C
		public static bool CalcMeshWorldPositionNormalTangent(MeshData meshData, List<Transform> boneList, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x000000018AADD9E0-0x000000018AADDC84
		public static bool CalcMeshWorldPositionNormalTangent(Renderer ren, Mesh mesh, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x000000018AADE2A0-0x000000018AADE640
		public static bool CalcMeshLocalNormalTangent(List<int> selectList, Vector3[] vlist, Vector2[] uvlist, int[] triangles, out List<Vector3> lnorList, out List<Vector3> ltanList) {
			lnorList = default;
			ltanList = default;
			return default;
		} // 0x000000018AADB780-0x000000018AADD91C
		public static List<HashSet<int>> GetTriangleToVertexLinkList(int vcnt, List<int> lineList, List<int> triangleList) => default;
		public static List<HashSet<int>> GetVertexLinkList(int vcnt, HashSet<uint> lineSet) => default; // 0x0000000185492010-0x0000000185492020
		public static Dictionary<int, HashSet<int>> GetVertexToTriangles(List<int> triangleList) => default; // 0x0000000185FCEFF0-0x0000000185FCF010
		public static int RestTriangleVertex(int tindex, int v0, int v1, List<int> triangleList) => default; // 0x000000018AAE66E0-0x000000018AAE6758
		public static void RestTriangleVertex(int tindex, int v0, List<int> triangleList, out int v1, out int v2) {
			v1 = default;
			v2 = default;
		} // 0x000000018AAE65C4-0x000000018AAE66E0
		public static bool CheckAdjacentTriangle(int tindex0, int tindex1, List<int> triangleList) => default; // 0x000000018AAE6278-0x000000018AAE636C
		public static Dictionary<uint, List<int>> GetTriangleEdgePair(List<int> triangleList) => default; // 0x000000018AAE5848-0x000000018AAE5EB0
		private static void AddTriangleEdge(int v0, int v1, int tindex, Dictionary<uint, List<int>> triangleEdgeDict) {} // 0x000000018AA6B0F4-0x000000018AA6B140
		public static List<ulong> GetTrianglePackList(List<int> triangleList) => default; // 0x000000018AA6AE60-0x000000018AA6AEE0
		public static float ClosestPtBoneLine(Vector3 pos, Transform bone, float lineWidth, out Vector3 d) {
			d = default;
			return default;
		} // 0x000000018AAE6224-0x000000018AAE6278
		public static List<Transform> GetUseBoneTransformList(Transform[] bones, Mesh mesh) => default; // 0x000000018AAE6158-0x000000018AAE6224
		public static void CalcTetraMesh(List<Vector3> posList, out int tetraCount, out List<int> tetraIndexList, out List<float> tetraSizeList) {
			tetraCount = default;
			tetraIndexList = default;
			tetraSizeList = default;
		} // 0x000000018AAE5EB0-0x000000018AAE6158
		public static Transform GetReplaceBone<T>(Transform now, Dictionary<T, Transform> boneReplaceDict)
			where T : class => default; // 0x000000018AAE636C-0x000000018AAE65C4
	}

	public class StaticStringBuilder // TypeDefIndex: 52562
	{
		// Fields
		private static StringBuilder stringBuilder; // 0x00
	
		// Properties
		public static StringBuilder Instance { get => default; } // 0x000000018AAE57B8-0x000000018AAE5808 
	
		// Constructors
		public StaticStringBuilder() {} // 0x0000000185492010-0x0000000185492020
		static StaticStringBuilder() {} // 0x000000018AAE5734-0x000000018AAE57B8
	
		// Methods
		public static void Clear() {} // 0x000000018AAE5684-0x000000018AAE56DC
		public static StringBuilder Append(object[] args) => default; // 0x000000018AAE55E4-0x000000018AAE5684
		public static StringBuilder AppendLine(object[] args) => default; // 0x000000018AAE53B8-0x000000018AAE548C
		public static StringBuilder AppendLine() => default; // 0x000000018AAE548C-0x000000018AAE5508
		public static string AppendToString(object[] args) => default; // 0x000000018AAE5508-0x000000018AAE55E4
		public static new string ToString() => default; // 0x000000018AAE56DC-0x000000018AAE5734
	}

	[Serializable]
	public class UpdateTimeManager // TypeDefIndex: 52566
	{
		// Fields
		private UpdateCount updatePerSeccond; // 0x10
		private UpdateMode updateMode; // 0x14
		private UpdateLocation updateLocation; // 0x18
		private float timeScale; // 0x1C
		private float futurePredictionRate; // 0x20
		private bool updateBoneScale; // 0x24
		private int fixedUpdateCount; // 0x28
	
		// Properties
		public int FixedUpdateCount { get => default; } // 0x0000000181C9AC80-0x0000000181C9AC90 
		public int UpdatePerSecond { get => default; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 
		public float UpdateIntervalTime { get => default; } // 0x0000000185FCF040-0x0000000185FCF060 
		public float UpdatePower { get => default; } // 0x0000000185FCF060-0x0000000185FCF080 
		public float TimeScale { get => default; set {} } // 0x0000000185FB0850-0x0000000185FB0860 0x0000000186470D94-0x0000000186470DAC
		public float DeltaTime { get => default; } // 0x000000018646ED20-0x000000018646ED28 
		public float PhysicsDeltaTime { get => default; } // 0x0000000184407A80-0x0000000184407AB0 
		public float AverageDeltaTime { get => default; } // 0x000000018AAE6758-0x000000018AAE6760 
		public bool IsUnscaledUpdate { get => default; } // 0x000000018AAE6760-0x000000018AAE6774 
		public bool IsDelay { get => default; } // 0x000000018440AB30-0x000000018440AB40 
		public float FuturePredictionRate { get => default; set {} } // 0x0000000181C9AC70-0x0000000181C9AC80 0x000000018AAE677C-0x000000018AAE6794
		public bool UpdateBoneScale { get => default; set {} } // 0x0000000185FB0810-0x0000000185FB0820 0x0000000185FB0820-0x0000000185FB0830
		public int WorkerMaximumCount { get => default; } // 0x000000018AAE6774-0x000000018AAE677C 
	
		// Nested types
		public enum UpdateCount // TypeDefIndex: 52563
		{
			_60 = 60,
			_90_Default = 90,
			_120 = 120,
			_150 = 150,
			_180 = 180
		}
	
		public enum UpdateMode // TypeDefIndex: 52564
		{
			UnscaledTime = 0,
			OncePerFrame = 1,
			DelayUnscaledTime = 10
		}
	
		public enum UpdateLocation // TypeDefIndex: 52565
		{
			AfterLateUpdate = 0,
			BeforeLateUpdate = 1
		}
	
		// Constructors
		public UpdateTimeManager() {} // 0x0000000185FCF020-0x0000000185FCF040
	
		// Methods
		public void ResetFixedUpdateCount() {} // 0x0000000185FCF010-0x0000000185FCF020
		public void AddFixedUpdateCount() {} // 0x0000000185FCA7D0-0x0000000185FCA7E0
		public UpdateMode GetUpdateMode() => default; // 0x0000000185FB21A0-0x0000000185FB21B0
		public void SetUpdateMode(UpdateMode mode) {} // 0x0000000185FBB0B0-0x0000000185FBB0C0
		public UpdateLocation GetUpdateLocation() => default; // 0x00000001813AE560-0x00000001813AE570
		public void SetUpdateLocation(UpdateLocation location) {} // 0x00000001813AE9C0-0x00000001813AE9D0
		public void SetUpdatePerSecond(UpdateCount ucount) {} // 0x0000000181378230-0x0000000181378240
	}

	public class ReferenceDataBuilder<T> // TypeDefIndex: 52567
		where T : struct
	{
		// Fields
		private int indexCount;
		private List<T> dataList;
		private List<List<int>> indexToDataIndexList;
		private List<List<int>> dataIndexToIndexList;
	
		// Constructors
		public ReferenceDataBuilder() {}
	
		// Methods
		public void Init(int indexCount) {}
		public void AddData(T data, int[] indexes) {}
		public ValueTuple<List<ReferenceDataIndex>, List<T>> GetDirectReferenceData() => default;
		public ValueTuple<List<ReferenceDataIndex>, List<int>, List<List<int>>> GetIndirectReferenceData() => default;
	}

	[Serializable]
	public struct ReferenceDataIndex // TypeDefIndex: 52568
	{
		// Fields
		public int startIndex; // 0x00
		public int count; // 0x04
	}

	public interface IDataHash // TypeDefIndex: 52569
	{
		// Methods
		int GetDataHash();
	}

	public interface IShareDataObject // TypeDefIndex: 52570
	{
		// Methods
		List<ShareDataObject> GetAllShareDataObject();
		ShareDataObject DuplicateShareDataObject(ShareDataObject source);
	}

	[Serializable]
	public abstract class ShareDataObject : ScriptableObject, IDataVerify, IDataHash // TypeDefIndex: 52571
	{
		// Fields
		protected int dataHash; // 0x18
		protected int dataVersion; // 0x1C
	
		// Properties
		public int SaveDataHash { get; set; } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public int SaveDataVersion { get; set; } // 0x00000001813AE570-0x00000001813AE580 0x00000001813AE9D0-0x00000001813AE9E0
	
		// Constructors
		protected ShareDataObject() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		public abstract int GetDataHash();
		public abstract int GetVersion();
		public abstract Define.Error VerifyData();
		public virtual void CreateVerifyData() {} // 0x000000018AAE535C-0x000000018AAE538C
		public virtual string GetInformation() => default; // 0x000000018AAE538C-0x000000018AAE53B8
		public static T CreateShareData<T>(string dataName)
			where T : ShareDataObject => default;
		public static bool RemoveNullAndDuplication<T>(List<T> data) => default;
		public static T Clone<T>(T source)
			where T : ShareDataObject => default;
	}

	public class StopWatch // TypeDefIndex: 52572
	{
		// Fields
		private float startTime; // 0x10
		private float endTime; // 0x14
	
		// Properties
		public float ElapsedSeconds { get => default; } // 0x0000000185FCEFE0-0x0000000185FCEFF0 
		public float ElapsedMilliseconds { get => default; } // 0x0000000185FCEFC0-0x0000000185FCEFE0 
	
		// Constructors
		public StopWatch() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public StopWatch Start() => default; // 0x000000018AAE5808-0x000000018AAE5828
		public StopWatch Stop() => default; // 0x000000018AAE5828-0x000000018AAE5848
	}
}

namespace MagicaReductionMesh
{
	public class ReductionMesh // TypeDefIndex: 52269
	{
		// Fields
		private ReductionWeightMode _WeightMode_k__BackingField; // 0x10
		private MeshData meshData; // 0x18
		private ReductionData reductionData; // 0x20
		private DebugData debugData; // 0x28
	
		// Properties
		public ReductionWeightMode WeightMode { get; set; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 0x0000000181378230-0x0000000181378240
		public MeshData MeshData { get => default; } // 0x000000018AA67B30-0x000000018AA67B5C 
		public ReductionData ReductionData { get => default; } // 0x0000000185C4D750-0x0000000185C4D780 
		public DebugData DebugData { get => default; } // 0x000000018AA67B04-0x000000018AA67B30 
	
		// Nested types
		public enum ReductionWeightMode // TypeDefIndex: 52268
		{
			Distance = 0,
			Average = 1,
			DistanceAverage = 2
		}
	
		// Constructors
		public ReductionMesh() {} // 0x000000018AA67A4C-0x000000018AA67B04
	
		// Methods
		public int AddMesh(bool isSkinning, Mesh mesh, List<Transform> bones, Matrix4x4[] bindPoseList, BoneWeight[] boneWeightList) => default; // 0x000000018AA678BC-0x000000018AA67924
		public int AddMesh(Renderer ren) => default; // 0x000000018AA67640-0x000000018AA678BC
		public int AddMesh(Transform root, List<Vector3> posList, List<Vector3> norList = null, List<Vector4> tanList = null, List<Vector2> uvList = null, List<int> triangleList = null) => default; // 0x000000018AA675CC-0x000000018AA67640
		public void Reduction(float zeroRadius, float radius, float polygonLength, bool createTetra) {} // 0x000000018AA67954-0x000000018AA67A4C
		public FinalData GetFinalData(Transform root) => default; // 0x000000018AA67924-0x000000018AA67954
	}

	public abstract class ReductionMeshAccess // TypeDefIndex: 52270
	{
		// Fields
		protected ReductionMesh parent; // 0x10
	
		// Properties
		protected MeshData MeshData { get; } // 0x000000018AA6758C-0x000000018AA675AC 
		protected ReductionData ReductionData { get; } // 0x000000018AA675AC-0x000000018AA675CC 
		protected DebugData DebugData { get; } // 0x000000018AA6756C-0x000000018AA6758C 
	
		// Constructors
		protected ReductionMeshAccess() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public virtual void SetParent(ReductionMesh parent) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class DebugData : ReductionMeshAccess // TypeDefIndex: 52271
	{
		// Constructors
		public DebugData() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void DispMeshInfo(string header = "" /* Metadata: 0x0207651F */) {} // 0x000000018AA5851C-0x000000018AA587C8
		public static void DebugDrawShared(FinalData final, bool drawTriangle = true /* Metadata: 0x02076520 */, bool drawLine = true /* Metadata: 0x02076521 */, bool drawTetra = true /* Metadata: 0x02076522 */, bool drawVertexNormal = true /* Metadata: 0x02076523 */, bool drawVertexTangent = true /* Metadata: 0x02076524 */, bool drawNumber = false /* Metadata: 0x02076525 */, int maxPolygonCount = 2147483647 /* Metadata: 0x02076526 */, int layer = -1 /* Metadata: 0x02076527 */, int tetraIndex = -1 /* Metadata: 0x02076528 */, float tetraSize = 1f /* Metadata: 0x02076529 */, List<int> drawNumberList = null, float axisSize = 0.01f /* Metadata: 0x0207652D */) {} // 0x000000018AA57958-0x000000018AA5851C
		private static void DrawTetra(FinalData final, int tetraIndex, List<Vector3> wposList, float tetraSize) {} // 0x000000018AA587C8-0x000000018AA58A88
		public static void DebugDrawChild(FinalData final, bool drawPosition = false /* Metadata: 0x02076531 */, bool drawNormal = false /* Metadata: 0x02076532 */, bool drawTriangle = false /* Metadata: 0x02076533 */, bool drawNumber = false /* Metadata: 0x02076534 */, int maxVertexCount = 2147483647 /* Metadata: 0x02076535 */, float positionSize = 0.001f /* Metadata: 0x02076536 */, float axisSize = 0.01f /* Metadata: 0x0207653A */) {} // 0x000000018AA574A4-0x000000018AA57958
	}

	[Serializable]
	public class FinalData // TypeDefIndex: 52274
	{
		// Fields
		public List<Vector3> vertices; // 0x10
		public List<Vector3> normals; // 0x18
		public List<Vector4> tangents; // 0x20
		public List<Vector2> uvs; // 0x28
		public List<BoneWeight> boneWeights; // 0x30
		public List<Matrix4x4> bindPoses; // 0x38
		public List<Transform> bones; // 0x40
		public List<int> lines; // 0x48
		public List<int> triangles; // 0x50
		public List<int> tetras; // 0x58
		public List<float> tetraSizes; // 0x60
		public List<Matrix4x4> vertexBindPoses; // 0x68
		public List<MeshIndexData> vertexToMeshIndexList; // 0x70
		public List<int> vertexToTriangleCountList; // 0x78
		public List<int> vertexToTriangleStartList; // 0x80
		public List<int> vertexToTriangleIndexList; // 0x88
		public List<MeshInfo> meshList; // 0x90
	
		// Properties
		public bool IsValid { get => default; } // 0x000000018AA59078-0x000000018AA590C4 
		public int VertexCount { get => default; } // 0x000000018AA59030-0x000000018AA59078 
		public int LineCount { get => default; } // 0x000000018AA58F28-0x000000018AA58F68 
		public int TriangleCount { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public int TetraCount { get => default; } // 0x000000018AA58FF0-0x000000018AA59030 
		public int BoneCount { get => default; } // 0x000000018AA58A88-0x000000018AA58F28 
		public bool IsSkinning { get => default; } // 0x000000018AA6443C-0x000000018AA644B4 
		public int MeshCount { get => default; } // 0x000000018AA646B8-0x000000018AA646F8 
	
		// Nested types
		[Serializable]
		public class MeshIndexData // TypeDefIndex: 52272
		{
			// Fields
			public List<uint> meshIndexPackList; // 0x10
	
			// Constructors
			public MeshIndexData() {} // 0x000000018AA58F68-0x000000018AA58FAC
		}
	
		[Serializable]
		public class MeshInfo // TypeDefIndex: 52273
		{
			// Fields
			public int meshIndex; // 0x10
			public Mesh mesh; // 0x18
			public List<Vector3> vertices; // 0x20
			public List<Vector3> normals; // 0x28
			public List<Vector4> tangents; // 0x30
			public List<BoneWeight> boneWeights; // 0x38
			public List<int> parents; // 0x40
	
			// Properties
			public int VertexCount { get => default; } // 0x000000018AA590C4-0x000000018AA59104 
	
			// Constructors
			public MeshInfo() {} // 0x000000018AA58FAC-0x000000018AA58FF0
		}
	
		// Constructors
		public FinalData() {} // 0x000000018AA644B4-0x000000018AA64640
	}

	public class MeshData : ReductionMeshAccess // TypeDefIndex: 52294
	{
		// Fields
		public List<Vertex> originalVertexList; // 0x18
		public List<MeshInfo> meshInfoList; // 0x20
		public List<ShareVertex> shareVertexList; // 0x28
		private Dictionary<ulong, Triangle> triangleDict; // 0x30
		private Dictionary<uint, Line> lineDict; // 0x38
		public List<Transform> boneList; // 0x40
		private List<Tetra> tetraList; // 0x48
		private float weightPow; // 0x50
		private int maxWeightCount; // 0x54
		private float sameSurfaceAngle; // 0x58
		private bool removeSameTrianglePair; // 0x5C
		private float removeSameTrianglePairAngle; // 0x60
	
		// Properties
		public int VertexCount { get => default; } // 0x000000018AA6C30C-0x000000018AA6C344 
		public int LineCount { get => default; } // 0x000000018AA6C30C-0x000000018AA6C344 
		public int TriangleCount { get => default; } // 0x000000018AA6C30C-0x000000018AA6C344 
		public int TetraCount { get => default; } // 0x0000000185492010-0x0000000185492020 
		public int MeshCount { get => default; } // 0x000000018AA6C374-0x000000018AA6C39C 
		public float WeightPow { get => default; set {} } // 0x0000000185492010-0x0000000185492020 0x000000018AA6C374-0x000000018AA6C39C
		public int MaxWeightCount { get => default; set {} } // 0x000000018AA6BCE4-0x000000018AA6BE50 0x000000018AA6B52C-0x000000018AA6B878
		public float SameSurfaceAngle { get => default; set {} } // 0x000000018AA6BBEC-0x000000018AA6BCE4 0x000000018AA6B878-0x000000018AA6BBEC
		public bool RemoveSameTrianglePair { get => default; set {} } // 0x000000018AA6BE50-0x000000018AA6BF24 0x000000018AA6C00C-0x000000018AA6C0C0
		public float RemoveSameTrianglePairAngle { get => default; set {} } // 0x000000018AA6BF24-0x000000018AA6C00C 0x000000018AA6C0C0-0x000000018AA6C294
	
		// Nested types
		public class WeightData // TypeDefIndex: 52275
		{
			// Fields
			public int boneIndex; // 0x10
			public float boneWeight; // 0x14
	
			// Constructors
			public WeightData() {} // 0x000000018AA643FC-0x000000018AA6443C
		}
	
		public class Vertex // TypeDefIndex: 52276
		{
			// Fields
			public int meshIndex; // 0x10
			public int vertexIndex; // 0x14
			public Vector3 wpos; // 0x18
			public Vector3 wnor; // 0x24
			public Vector3 wtan; // 0x30
			public float tanw; // 0x3C
			public Vector2 uv; // 0x40
			public int parentIndex; // 0x48
			public List<WeightData> boneWeightList; // 0x50
	
			// Constructors
			public Vertex() {} // 0x000000018AA642FC-0x000000018AA6433C
		}
	
		public class MeshInfo // TypeDefIndex: 52277
		{
			// Fields
			public int index; // 0x10
			public Mesh mesh; // 0x18
			public int vertexCount; // 0x20
			public List<Vertex> vertexList; // 0x28
	
			// Constructors
			public MeshInfo() {} // 0x000000018AA643BC-0x000000018AA643FC
		}
	
		public class ShareVertex // TypeDefIndex: 52282
		{
			// Fields
			public int sindex; // 0x10
			public Vector3 wpos; // 0x14
			public Vector3 wnor; // 0x20
			public Vector3 wtan; // 0x2C
			public float tanw; // 0x38
			public Vector2 uv; // 0x3C
			public Matrix4x4 worldToLocalMatrix; // 0x44
			public Matrix4x4 bindpose; // 0x84
			public List<WeightData> boneWeightList; // 0xC8
			public List<Vertex> vertexList; // 0xD0
			public HashSet<ShareVertex> linkShareVertexSet; // 0xD8
			public HashSet<Triangle> linkTriangleSet; // 0xE0
	
			// Nested types
			private sealed class __c__DisplayClass20_0 // TypeDefIndex: 52278
			{
				// Fields
				public WeightData w; // 0x10
	
				// Constructors
				public __c__DisplayClass20_0() {} // 0x000000018AA6437C-0x000000018AA643BC
	
				// Methods
				internal bool _CalcBoneWeight_DistanceAverage_b__1(WeightData wdata) => default; // 0x000000018AA6433C-0x000000018AA6437C
			}
	
			[Serializable]
			private sealed class __c // TypeDefIndex: 52279
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Comparison<WeightData> __9__20_0; // 0x08
				public static Comparison<WeightData> __9__21_0; // 0x10
				public static Comparison<WeightData> __9__23_0; // 0x18
	
				// Constructors
				static __c() {} // 0x0000000185FB3000-0x0000000185FB3010
				public __c() {} // 0x0000000185FB3010-0x0000000185FB3020
	
				// Methods
				internal int _CalcBoneWeight_DistanceAverage_b__20_0(WeightData a, WeightData b) => default; // 0x0000000185FB0670-0x0000000185FB0680
				internal int _CalcBoneWeight_Average_b__21_0(WeightData a, WeightData b) => default; // 0x0000000185FB06A0-0x0000000185FB06B0
				internal int _CalcBoneWeight_Distance_b__23_0(WeightData a, WeightData b) => default; // 0x0000000181DE2580-0x0000000181DE2590
			}
	
			private sealed class __c__DisplayClass21_0 // TypeDefIndex: 52280
			{
				// Fields
				public WeightData w; // 0x10
	
				// Constructors
				public __c__DisplayClass21_0() {} // 0x0000000181DE28C0-0x0000000181DE28D0
	
				// Methods
				internal bool _CalcBoneWeight_Average_b__1(WeightData wdata) => default; // 0x0000000185FB0C10-0x0000000185FB0C20
			}
	
			private sealed class __c__DisplayClass23_0 // TypeDefIndex: 52281
			{
				// Fields
				public WeightData w; // 0x10
	
				// Constructors
				public __c__DisplayClass23_0() {} // 0x0000000185FB0C30-0x0000000185FB0C40
	
				// Methods
				internal bool _CalcBoneWeight_Distance_b__1(WeightData wdata) => default; // 0x0000000185FB2200-0x0000000185FB2210
			}
	
			// Constructors
			public ShareVertex() {} // 0x000000018AA5C86C-0x000000018AA5C980
	
			// Methods
			public void AddLink(ShareVertex mv) {} // 0x0000000185FB2230-0x0000000185FB2240
			public void ReplaseLink(ShareVertex old, ShareVertex mv) {} // 0x000000018AA598DC-0x000000018AA5A72C
			public void RecalcCoordinate() {} // 0x000000018AA5917C-0x000000018AA598DC
			public void CalcNormalTangentFromTriangle() {} // 0x000000018AA5CAC4-0x000000018AA5CDF4
			public Vector3 CalcLocalPos(Vector3 pos) => default; // 0x000000018AA64034-0x000000018AA6409C
			public Vector3 CalcLocalDir(Vector3 dir) => default; // 0x000000018AA5C6C4-0x000000018AA5C86C
			public Matrix4x4 CalcWorldToLocalMatrix() => default; // 0x000000018AA5C2EC-0x000000018AA5C6C4
			public void CalcBoneWeight(ReductionMesh.ReductionWeightMode weightMode, float weightPow) {} // 0x000000018AA5F79C-0x000000018AA60B94
			private void CalcBoneWeight_DistanceAverage(float weightPow) {} // 0x000000018AA5BF08-0x000000018AA5C040
			private void CalcBoneWeight_Average() {} // 0x000000018AA5A7C4-0x000000018AA5B270
			private void AdjustWeight(List<WeightData> sumlist) {} // 0x000000018AA5C980-0x000000018AA5CAC4
			private void CalcBoneWeight_Distance(float weightPow) {} // 0x000000018AA5C040-0x000000018AA5C2EC
			public BoneWeight GetBoneWeight() => default; // 0x000000018AA60B94-0x000000018AA610BC
		}
	
		public class Triangle // TypeDefIndex: 52284
		{
			// Fields
			public int tindex; // 0x10
			public List<ShareVertex> shareVertexList; // 0x18
			public Vector3 wnor; // 0x20
			public Vector3 wtan; // 0x2C
			public bool flipLock; // 0x38
	
			// Nested types
			private sealed class __c__DisplayClass9_0 // TypeDefIndex: 52283
			{
				// Fields
				public int edgev0; // 0x10
				public int edgev1; // 0x14
	
				// Constructors
				public __c__DisplayClass9_0() {} // 0x000000018AA63460-0x000000018AA63678
	
				// Methods
				internal bool _GetNonEdgeVertex_b__0(ShareVertex sv) => default; // 0x000000018AA62AE0-0x000000018AA63350
			}
	
			// Constructors
			public Triangle() {} // 0x000000018AA6409C-0x000000018AA642FC
	
			// Methods
			public void GetEdge(out uint edge0, out uint edge1, out uint edge2) {
				edge0 = default;
				edge1 = default;
				edge2 = default;
			} // 0x000000018AA63350-0x000000018AA63460
			public Vector3 CalcTriangleNormal() => default; // 0x000000018AA5DEF0-0x000000018AA5F79C
			public void Flip() {} // 0x000000018AA5B270-0x000000018AA5B484
			public Vector3 CalcTriangleTangent() => default; // 0x000000018AA610BC-0x000000018AA62AE0
			public ShareVertex GetNonEdgeVertex(int edgev0, int edgev1) => default; // 0x000000018AA5CDF4-0x000000018AA5DEF0
			public ulong GetTriangleHash() => default; // 0x000000018AA5A72C-0x000000018AA5A7C4
			public static float GetTriangleArea(ShareVertex sv0, ShareVertex sv1, ShareVertex sv2) => default; // 0x000000018AA63678-0x000000018AA64034
			public override string ToString() => default; // 0x000000018AA5B484-0x000000018AA5BF08
		}
	
		private class Line // TypeDefIndex: 52285
		{
			// Fields
			public List<ShareVertex> shareVertexList; // 0x10
	
			// Constructors
			public Line() {} // 0x0000000185492010-0x0000000185492020
		}
	
		public enum UvWrapMode // TypeDefIndex: 52286
		{
			None = 0,
			Sphere = 1
		}
	
		public class Square // TypeDefIndex: 52287
		{
			// Fields
			public ulong shash; // 0x10
			public List<Triangle> triangleList; // 0x18
			public float angle; // 0x20
	
			// Constructors
			public Square() {} // 0x000000018AA64640-0x000000018AA646B8
	
			// Methods
			public override string ToString() => default; // 0x000000018AA6DF10-0x000000018AA6E340
		}
	
		public class Tetra // TypeDefIndex: 52288
		{
			// Fields
			public List<ShareVertex> shareVertexList; // 0x10
			public Vector3 circumCenter; // 0x18
			public float circumRadius; // 0x24
			public Vector3 tetraCenter; // 0x28
			public float tetraSize; // 0x34
	
			// Constructors
			public Tetra() {} // 0x000000018AA67B5C-0x000000018AA67BB4
			public Tetra(ShareVertex a, ShareVertex b, ShareVertex c, ShareVertex d) {} // 0x000000018AA6A128-0x000000018AA6A1E0
	
			// Methods
			public ulong GetTetraHash() => default; // 0x000000018AA69E40-0x000000018AA6A128
			public void CalcCircumcircle() {} // 0x000000018AA69A00-0x000000018AA69C3C
			public bool IntersectCircumcircle(Vector3 pos) => default; // 0x000000018AA6990C-0x000000018AA69A00
			public bool CheckSame(Tetra tri) => default; // 0x000000018AA6985C-0x000000018AA6990C
			public bool ContainsPoint(ShareVertex p1) => default; // 0x000000018AA69C3C-0x000000018AA69D50
			public bool ContainsPoint(ShareVertex p1, ShareVertex p2, ShareVertex p3, ShareVertex p4) => default; // 0x000000018AA69820-0x000000018AA6985C
			public void CalcSize() {} // 0x000000018AA68458-0x000000018AA68F3C
			public bool Verification() => default; // 0x000000018AA67DE4-0x000000018AA68458
		}
	
		private class LinkInfo // TypeDefIndex: 52289
		{
			// Fields
			public ShareVertex sv; // 0x10
			public float length; // 0x18
			public int count; // 0x1C
	
			// Constructors
			public LinkInfo() {} // 0x000000018AA67BB4-0x000000018AA67DE4
		}
	
		private class VertexLengthInfo // TypeDefIndex: 52290
		{
			// Fields
			public ShareVertex sv; // 0x10
			public float length; // 0x18
	
			// Constructors
			public VertexLengthInfo() {} // 0x000000018AA68F3C-0x000000018AA69820
		}
	
		private sealed class __c__DisplayClass65_0 // TypeDefIndex: 52291
		{
			// Fields
			public float weightLength; // 0x10
	
			// Constructors
			public __c__DisplayClass65_0() {} // 0x000000018AA69D50-0x000000018AA69E40
		}
	
		private sealed class __c__DisplayClass65_1 // TypeDefIndex: 52292
		{
			// Fields
			public Vertex vt; // 0x10
			public __c__DisplayClass65_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass65_1() {} // 0x000000018AA6A1E0-0x000000018AA6A350
	
			// Methods
			internal bool _CreateOriginalMeshInfo_b__0(ShareVertex sv) => default; // 0x0000000185492010-0x0000000185492020
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 52293
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<VertexLengthInfo> __9__69_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018AA6C374-0x000000018AA6C39C
			public __c() {} // 0x000000018AA6C498-0x000000018AA6C4FC
	
			// Methods
			internal int _SearchNearPointList_b__69_0(VertexLengthInfo a, VertexLengthInfo b) => default; // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public MeshData() {} // 0x000000018AA6C344-0x000000018AA6C374
	
		// Methods
		public int AddMesh(bool isSkinning, Mesh mesh, List<Transform> bones, Matrix4x4[] bindPoseList, BoneWeight[] boneWeightList) => default; // 0x000000018AA6C294-0x000000018AA6C30C
		public int AddMesh(Transform root, List<Vector3> posList, List<Vector3> norList = null, List<Vector4> tanList = null, List<Vector2> uvList = null, List<int> triangleList = null) => default; // 0x0000000185492010-0x0000000185492020
		public void CombineVertex(ShareVertex sv0, ShareVertex sv1) {} // 0x000000018AA6C408-0x000000018AA6C434
		public void UpdateMeshData(bool createTetra) {} // 0x000000018AA59104-0x000000018AA5917C
		private void CalcVertexIndex() {} // 0x000000018AA6A350-0x000000018AA6A4D8
		private void CalcUV(UvWrapMode wrapMode) {} // 0x000000018AA6A4D8-0x000000018AA6A550
		private void CreateTriangleAndLine() {} // 0x000000018AA6B398-0x000000018AA6B410
		private void CalcShareVertexWeight() {} // 0x000000018AA6B410-0x000000018AA6B52C
		private void AdjustTriangleNormal() {} // 0x000000018AA6B000-0x000000018AA6B0F4
		private bool CheckTwoTriangleOpen(Triangle tri1, Triangle tri2, uint edge) => default; // 0x000000018AA6A550-0x000000018AA6ABB8
		private float CalcTwoTriangleAngle(Triangle tri1, Triangle tri2, uint edge) => default; // 0x000000018AA6B0F4-0x000000018AA6B140
		private Dictionary<uint, List<ulong>> GetEdgeToTriangleDict() => default; // 0x000000018AA6AE60-0x000000018AA6AEE0
		private void CalcVertexNormalFromTriangle() {} // 0x000000018AA6AEE0-0x000000018AA6AF34
		private void RemoveTriangle(ulong thash) {} // 0x000000018AA6AF34-0x000000018AA6B000
		private Dictionary<ulong, List<Square>> GetSquareDict() => default; // 0x000000018AA6ABB8-0x000000018AA6AE60
		private void RemoveOverlappingSquareTriangles() {} // 0x000000018AA6B140-0x000000018AA6B398
		private void CreateTetraMesh() {} // 0x0000000185492010-0x0000000185492020
		private Bounds CalcBounding() => default; // 0x0000000185492010-0x0000000185492020
		public FinalData GetFinalData(Transform root) => default; // 0x0000000185492010-0x0000000185492020
		private void CreateOriginalMeshInfo(FinalData final, Transform root, float weightLength) {} // 0x0000000185492010-0x0000000185492020
		private void AddVertexToMeshIndexData(FinalData final, int sindex, int meshIndex, int meshVertexIndex) {} // 0x000000018AA6C39C-0x000000018AA6C408
		private List<ShareVertex> SearchNearPointList(Vector3 basePos, ShareVertex sv, float weightLength, int maxCount) => default; // 0x000000018AA6C434-0x000000018AA6C498
		public void CalcMeshWorldPositionNormalTangent(bool isSkinning, Mesh mesh, List<Transform> bones, Matrix4x4[] bindPoseList, BoneWeight[] boneWeightList, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector4> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
		} // 0x0000000185492010-0x0000000185492020
	}

	public class ReductionData : ReductionMeshAccess // TypeDefIndex: 52295
	{
		// Constructors
		public ReductionData() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void ReductionZeroDistance(float radius = 0.0001f /* Metadata: 0x02076540 */) {} // 0x000000018AA674E0-0x000000018AA6756C
		public void ReductionRadius(float radius) {} // 0x000000018AA67454-0x000000018AA674E0
		public void ReductionPolygonLink(float length) {} // 0x000000018AA673C8-0x000000018AA67454
		public void ReductionBone() {} // 0x000000018AA66ED8-0x000000018AA673C8
	}

	public class NearPointReduction // TypeDefIndex: 52297
	{
		// Fields
		protected MeshData meshData; // 0x10
		private List<Point> pointList; // 0x18
		protected Dictionary<Vector3Int, List<Point>> gridMap; // 0x20
		protected float gridSize; // 0x28
		private float searchRadius; // 0x2C
		private Dictionary<Point, List<Point>> nearPointDict; // 0x30
	
		// Properties
		public int PointCount { get => default; } // 0x000000018AA64944-0x000000018AA64AB8 
	
		// Nested types
		public class Point // TypeDefIndex: 52296
		{
			// Fields
			public MeshData.ShareVertex shareVertex; // 0x10
			public Vector3 pos; // 0x18
			public Vector3Int grid; // 0x24
			public Point nearPoint; // 0x30
			public float nearDist; // 0x38
	
			// Constructors
			public Point() {} // 0x000000018AA65E44-0x000000018AA65F70
		}
	
		// Constructors
		public NearPointReduction() {} // Dummy constructor
		public NearPointReduction(float radius = 0.05f /* Metadata: 0x02076544 */) {} // 0x000000018AA65F70-0x000000018AA65FB0
	
		// Methods
		public void Create(MeshData meshData) {} // 0x000000018AA64CE8-0x000000018AA6522C
		public void Reduction() {} // 0x000000018AA64888-0x000000018AA64944
		private Point AddPoint(MeshData.ShareVertex sv, Vector3 pos) => default; // 0x000000018AA646F8-0x000000018AA64888
		private void AddGrid(Point p) {} // 0x000000018AA6522C-0x000000018AA653A8
		private void RemoveGrid(Point p) {} // 0x000000018AA64C90-0x000000018AA64CE8
		private void Move(Point p, Vector3 newpos) {} // 0x000000018AA653A8-0x000000018AA6540C
		private void Remove(Point p) {} // 0x000000018AA64AB8-0x000000018AA64B30
		protected Vector3Int GetGridPos(Vector3 pos) => default; // 0x000000018AA6540C-0x000000018AA656A0
		private void SearchNearPointAll() {} // 0x000000018AA656A0-0x000000018AA65E44
		private void SearchNearPoint(Point p, float radius, Point ignorePoint) {} // 0x000000018AA64B30-0x000000018AA64C90
		private Point GetNearPointPair() => default; // 0x0000000185492010-0x0000000185492020
	}

	public class PolygonLinkReduction // TypeDefIndex: 52299
	{
		// Fields
		protected MeshData meshData; // 0x10
		private float reductionLength; // 0x18
		private List<Point> pointList; // 0x20
		private Dictionary<MeshData.ShareVertex, Point> pointDict; // 0x28
	
		// Properties
		public int PointCount { get => default; } // 0x000000018AA66064-0x000000018AA661B0 
	
		// Nested types
		public class Point // TypeDefIndex: 52298
		{
			// Fields
			public MeshData.ShareVertex shareVertex; // 0x10
			public Point nearPoint; // 0x18
			public float nearDist; // 0x20
	
			// Constructors
			public Point() {} // 0x000000018AA66DC8-0x000000018AA66E98
		}
	
		// Constructors
		public PolygonLinkReduction() {} // Dummy constructor
		public PolygonLinkReduction(float length) {} // 0x000000018AA66E98-0x000000018AA66ED8
	
		// Methods
		public void Create(MeshData meshData) {} // 0x000000018AA66394-0x000000018AA669CC
		public void Reduction() {} // 0x000000018AA65FB0-0x000000018AA66064
		private void AddPoint(MeshData.ShareVertex sv) {} // 0x000000018AA66310-0x000000018AA66394
		private Point GetPoint(MeshData.ShareVertex sv) => default; // 0x000000018AA669CC-0x000000018AA66A4C
		private void Remove(Point p) {} // 0x000000018AA66A4C-0x000000018AA66B60
		private void SearchNearPointAll() {} // 0x000000018AA66B60-0x000000018AA66DC8
		private void SearchNearPoint(Point p) {} // 0x000000018AA661B0-0x000000018AA66310
		private Point GetNearPointPair() => default; // 0x0000000185492010-0x0000000185492020
	}

	public class Utility // TypeDefIndex: 52300
	{
		// Constructors
		public Utility() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static uint PackPair(int v0, int v1) => default; // 0x000000018773F538-0x000000018773F550
		public static void UnpackPair(uint pack, out int v0, out int v1) {
			v0 = default;
			v1 = default;
		} // 0x0000000185FCE970-0x0000000185FCE980
		public static ulong PackTriple(int v0, int v1, int v2) => default; // 0x000000018AA6DDD4-0x000000018AA6DF10
		public static void UnpackTriple(ulong pack, out int v0, out int v1, out int v2) {
			v0 = default;
			v1 = default;
			v2 = default;
		} // 0x0000000185FCE9B0-0x0000000185FCE9D0
		public static ulong PackQuater(int v0, int v1, int v2, int v3) => default; // 0x000000018AA6DC5C-0x000000018AA6DDD4
		public static void UnpackQuater(ulong pack, out int v0, out int v1, out int v2, out int v3) {
			v0 = default;
			v1 = default;
			v2 = default;
			v3 = default;
		} // 0x0000000185FCE980-0x0000000185FCE9B0
		public static uint Pack16(int hi, int low) => default; // 0x0000000185FB1310-0x0000000185FB1320
		public static int Unpack16Hi(uint pack) => default; // 0x0000000185FB13F0-0x0000000185FB1400
		public static int Unpack16Low(uint pack) => default; // 0x0000000185FB1400-0x0000000185FB1410
		public static ulong Pack32(int hi, int low) => default; // 0x0000000185FBDD60-0x0000000185FBDD70
		public static int Unpack32Hi(ulong pack) => default; // 0x0000000185FC9980-0x0000000185FC9990
		public static int Unpack32Low(ulong pack) => default; // 0x0000000185FB2C30-0x0000000185FB2C40
		public static void CalcFinalDataWorldPositionNormalTangent(FinalData final, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector4> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
		} // 0x000000018AA6D050-0x000000018AA6D9E4
		public static void CalcFinalDataChildWorldPositionNormalTangent(FinalData final, int meshIndex, List<Vector3> sposList, List<Vector3> snorList, List<Vector4> stanList, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector4> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
		} // 0x000000018AA6C4FC-0x000000018AA6D050
		public static void CalcLocalPositionNormalTangent(Transform root, List<Vector3> wposList, List<Vector3> wnorList, List<Vector4> wtanList) {} // 0x000000018AA6D9E4-0x000000018AA6DC5C
	}
}

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 52266
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 52267
	{
		// Constructors
		public IsUnmanagedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}
