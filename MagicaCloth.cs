/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Jobs;
using UnityEngine.LowLevel;
using UnityEngine.Profiling;
using UnityEngine.UI;

// Image 22: MagicaCloth.dll - Assembly: MagicaCloth, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 51286-51593
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace MagicaCloth
{
	public abstract class BaseCloth : PhysicsTeam // TypeDefIndex: 51323
	{
		// Fields
		[SerializeField]
		protected ClothParams clothParams; // 0x78
		[SerializeField]
		protected List<int> clothParamDataHashList; // 0x80
		[SerializeField]
		private ClothData clothData; // 0x88
		[SerializeField]
		protected int clothDataHash; // 0x90
		[SerializeField]
		protected int clothDataVersion; // 0x94
		[SerializeField]
		private SelectionData clothSelection; // 0x98
		[SerializeField]
		private int clothSelectionHash; // 0xA0
		[SerializeField]
		private int clothSelectionVersion; // 0xA4
		[SerializeField]
		private List<Renderer> cullRendererList; // 0xA8
		protected ClothSetup setup; // 0xB0
		private float oldBlendRatio; // 0xB8
		private TeamUpdateMode oldUpdateMode; // 0xBC
		private TeamCullingMode oldCullingMode; // 0xC0
		private bool oldUseAnimatedDistance; // 0xC4
	
		// Properties
		public float BlendWeight { get; set; } // 0x0000000183D4EC70-0x0000000183D4EC80 0x00000001889438C4-0x00000001889438DC
		public Vector3 Gravity_GravityDirection { get; set; } // 0x0000000188943778-0x00000001889437A4 0x0000000188943BE4-0x0000000188943CC4
		public bool DistanceDisable_Active { get; set; } // 0x00000001889436B8-0x00000001889436D8 0x00000001889439A0-0x00000001889439C0
		public Transform DistanceDisable_ReferenceObject { get; set; } // 0x0000000188943718-0x0000000188943738 0x0000000188943A10-0x0000000188943A3C
		public float DistanceDisable_Distance { get; set; } // 0x00000001889436D8-0x00000001889436F8 0x00000001889439C0-0x00000001889439E8
		public float DistanceDisable_FadeDistance { get; set; } // 0x00000001889436F8-0x0000000188943718 0x00000001889439E8-0x0000000188943A10
		public float ExternalForce_WindInfluence { get; set; } // 0x0000000188943738-0x0000000188943758 0x0000000188943A3C-0x0000000188943B10
		public float ExternalForce_WindRandomScale { get; set; } // 0x0000000188943758-0x0000000188943778 0x0000000188943B10-0x0000000188943BE4
		public float WorldInfluence_MaxMoveSpeed { get; set; } // 0x0000000188943804-0x0000000188943824 0x0000000188943F1C-0x0000000188943FE4
		public bool WorldInfluence_ResetAfterTeleport { get; set; } // 0x0000000188943824-0x0000000188943844 0x0000000188943FE4-0x00000001889440A8
		public float WorldInfluence_TeleportDistance { get; set; } // 0x0000000188943864-0x0000000188943884 0x000000018894414C-0x0000000188944210
		public float WorldInfluence_TeleportRotation { get; set; } // 0x00000001889438A4-0x00000001889438C4 0x00000001889442D0-0x0000000188944394
		public ClothParams.TeleportMode WorldInfluence_TeleportMode { get; set; } // 0x0000000188943884-0x00000001889438A4 0x0000000188944210-0x00000001889442D0
		public float WorldInfluence_StabilizationTime { get; set; } // 0x0000000188943844-0x0000000188943864 0x00000001889440A8-0x000000018894414C
		public bool ColliderCollision_Active { get; set; } // 0x0000000188943698-0x00000001889436B8 0x00000001889438DC-0x00000001889439A0
		public bool Penetration_Active { get; set; } // 0x00000001889437A4-0x00000001889437C4 0x0000000188943CC4-0x0000000188943D8C
		public bool Spring_Active { get; set; } // 0x00000001889437C4-0x00000001889437E4 0x0000000188943D8C-0x0000000188943E4C
		public float Spring_Power { get; set; } // 0x00000001889437E4-0x0000000188943804 0x0000000188943E4C-0x0000000188943F1C
		public ClothParams Params { get; } // 0x0000000183D4EB20-0x0000000183D4EB30 
		public ClothData ClothData { get; set; } // 0x0000000183D4EA60-0x0000000183D4EA70 0x0000000184274DA0-0x0000000184274DB4
		public SelectionData ClothSelection { get; } // 0x00000001811AC510-0x00000001811AC520 
		public ClothSetup Setup { get; } // 0x0000000183D4EAD0-0x0000000183D4EAE0 
	
		// Constructors
		protected BaseCloth() {} // 0x0000000188943540-0x0000000188943698
	
		// Methods
		public void ResetCloth() {} // 0x0000000188942910-0x0000000188942940
		public void ResetCloth(float resetStabilizationTime) {} // 0x00000001889428E0-0x0000000188942910
		public void ResetCloth(ClothParams.TeleportMode teleportMode, float resetStabilizationTime = -1f /* Metadata: 0x01FD0DFC */) {} // 0x0000000188942940-0x0000000188942948
		public void SetTimeScale(float timeScale) {} // 0x0000000188942948-0x00000001889429D0
		public float GetTimeScale() => default; // 0x0000000188941B58-0x0000000188941BD4
		public void AddForce(Vector3 force, PhysicsManagerTeamData.ForceMode mode) {} // 0x0000000188940DF0-0x0000000188940ED0
		public void AddCollider(ColliderComponent collider) {} // 0x0000000188940D4C-0x0000000188940DF0
		public void RemoveCollider(ColliderComponent collider) {} // 0x0000000188942630-0x00000001889426BC
		public void SetUpdateMode(TeamUpdateMode updateMode) {} // 0x0000000183D4EF20-0x0000000183D4EF30
		public void SetCullingMode(TeamCullingMode cullingMode) {} // 0x0000000183D4EF10-0x0000000183D4EF20
		public void Radius_SetRadius(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x01FD0E00 */) {} // 0x00000001889424A8-0x0000000188942630
		public void Mass_SetMass(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x01FD0E04 */) {} // 0x0000000188941DD8-0x0000000188941F70
		public void ClampPosition_SetPositionLength(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x01FD0E08 */) {} // 0x000000018894110C-0x00000001889412B8
		public void Gravity_SetGravity(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x01FD0E0C */) {} // 0x0000000188941C50-0x0000000188941D28
		public void Drag_SetDrag(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x01FD0E10 */) {} // 0x0000000188941644-0x000000018894171C
		public void ExternalForce_DepthInfluence(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x01FD0E14 */) {} // 0x0000000188941820-0x00000001889418F0
		public void WorldInfluence_SetMovementInfluence(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x01FD0E18 */) {} // 0x0000000188943348-0x0000000188943444
		public void WorldInfluence_SetRotationInfluence(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x01FD0E1C */) {} // 0x0000000188943444-0x0000000188943540
		public void WorldInfluence_ReplaceInfluenceTarget(Transform target) {} // 0x0000000188943200-0x0000000188943348
		public void Penetration_SetMovingRadius(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x01FD0E20 */) {} // 0x0000000188942398-0x00000001889424A8
		public override int GetDataHash() => default; // 0x0000000188941A8C-0x0000000188941B58
		protected virtual void Reset() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnValidate() {} // 0x0000000188942350-0x0000000188942398
		protected override void OnInit() {} // 0x0000000188942330-0x0000000188942350
		protected override void OnActive() {} // 0x0000000188941F70-0x00000001889420C0
		protected override void OnInactive() {} // 0x00000001889421F4-0x0000000188942330
		protected override void OnDispose() {} // 0x00000001889421D4-0x00000001889421F4
		internal override void UpdateCullingMode(CoreComponent caller) {} // 0x0000000188942CCC-0x0000000188943008
		protected override void OnChangeCalculation() {} // 0x00000001889420C0-0x00000001889421D4
		public int GetCullRenderListCount() => default; // 0x000000018894196C-0x0000000188941A8C
		private void BaseClothInit() {} // 0x0000000188940F84-0x0000000188941080
		private void BaseClothDispose() {} // 0x0000000188940ED0-0x0000000188940F84
		protected virtual void ClothInit() {} // 0x0000000188941378-0x000000018894145C
		protected virtual void ClothActive() {} // 0x00000001889412B8-0x0000000188941350
		protected virtual void ClothInactive() {} // 0x0000000188941350-0x0000000188941378
		protected virtual void ClothDispose() {} // 0x000000018350B670-0x000000018350B680
		protected abstract uint UserFlag(int vindex);
		protected abstract Transform UserTransform(int vindex);
		protected abstract float3 UserTransformLocalPosition(int vindex);
		protected abstract quaternion UserTransformLocalRotation(int vindex);
		public abstract bool IsRequiresDeformer();
		public abstract BaseMeshDeformer GetDeformer();
		protected abstract MeshData GetMeshData();
		protected abstract void WorkerInit();
		private void SetUseMesh(bool sw) {} // 0x00000001889429D0-0x0000000188942A58
		private void SetUseVertex(bool sw) {} // 0x0000000188942A58-0x0000000188942ADC
		protected abstract void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer);
		internal void DeformerForEach(Action<BaseMeshDeformer> act) {} // 0x0000000188941608-0x0000000188941644
		public void UpdateBlend() {} // 0x0000000188942ADC-0x0000000188942CCC
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict) {}
		public override HashSet<Transform> GetUsedBones() => default; // 0x0000000188941BD4-0x0000000188941C50
		protected override void ChangeUseUnityPhysics(bool sw) {} // 0x0000000188941080-0x000000018894110C
		public override void CreateVerifyData() {} // 0x000000018894145C-0x0000000188941608
		public override Define.Error VerifyData() => default; // 0x00000001889430C8-0x0000000188943200
		public bool HasChangedParam(ClothParams.ParamType ptype) => default; // 0x0000000188941D28-0x0000000188941DD8
		public Define.Error VerifyAlgorithmVersion() => default; // 0x0000000188943040-0x00000001889430C8
		public override bool UpgradeFormat() => default; // 0x0000000188943008-0x0000000188943040
		public override List<ShareDataObject> GetAllShareDataObject() => default; // 0x00000001889418F0-0x000000018894196C
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source) => default; // 0x000000018894171C-0x0000000188941820
		private void ResetClothInternal(ClothParams.TeleportMode teleportMode, float resetStabilizationTime) {} // 0x00000001889426BC-0x00000001889428E0
	}

	public abstract class CoreComponent : BaseComponent, IShareDataObject, IDataVerify, IEditorMesh, IEditorCloth, IDataHash, IBoneReplace // TypeDefIndex: 51324
	{
		// Fields
		[SerializeField]
		protected int dataHash; // 0x18
		[SerializeField]
		protected int dataVersion; // 0x1C
		protected RuntimeStatus status; // 0x20
		private int useUnityPhysicsCount; // 0x28
		private bool nowUseUnityPhysics; // 0x2C
		protected int calculateValue; // 0x30
	
		// Properties
		public RuntimeStatus Status { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public bool IsVisible { get; protected set; } // 0x0000000183D4F4C0-0x0000000183D4F4D0 0x0000000183D4F4F0-0x0000000183D4F500
		public bool IsCalculate { get; } // 0x00000001856B62D4-0x00000001856B62DC 
		public int SaveDataHash { get; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public int SaveDataVersion { get; } // 0x0000000183D4EBB0-0x0000000183D4EBC0 
	
		// Constructors
		protected CoreComponent() {} // 0x0000000188969F44-0x0000000188969FB8
	
		// Methods
		public Dictionary<string, Transform> GetUsedComponentBones() => default; // 0x00000001889696E0-0x00000001889699A4
		public List<string> GetUsedComponentBoneNames() => default; // 0x0000000188969644-0x00000001889696E0
		public void ReplaceComponentBone(Dictionary<Transform, Transform> boneReplaceDict) {} // 0x0000000188969D9C-0x0000000188969DE4
		public void ReplaceComponentBone(Dictionary<string, Transform> boneReplaceDict) {} // 0x0000000188969D54-0x0000000188969D9C
		public abstract int GetDataHash();
		protected virtual void Start() {} // 0x0000000188969E7C-0x0000000188969E84
		public virtual void OnEnable() {} // 0x0000000188969CBC-0x0000000188969CE8
		public virtual void OnDisable() {} // 0x0000000188969C88-0x0000000188969CB4
		protected virtual void OnDestroy() {} // 0x0000000188969BEC-0x0000000188969C88
		public void Init() {} // 0x00000001889699C0-0x0000000188969BC8
		protected abstract void OnInit();
		protected abstract void OnDispose();
		protected abstract void OnUpdate();
		protected abstract void OnActive();
		protected abstract void OnInactive();
		protected virtual void OnUpdateStatus() {} // 0x0000000188969CE8-0x0000000188969D54
		protected virtual void OnDisconnectedStatus() {} // 0x0000000188969CB4-0x0000000188969CBC
		public void SetUseUnityPhysics(bool sw) {} // 0x0000000188969DE4-0x0000000188969E48
		private void ActiveUseUnityPhysics() {} // 0x00000001889693EC-0x0000000188969410
		private void InactiveUseUnityPhysics() {} // 0x00000001889699A4-0x00000001889699C0
		protected virtual void ChangeUseUnityPhysics(bool sw) {} // 0x000000018350B670-0x000000018350B680
		protected bool IsUseUnityPhysics() => default; // 0x0000000187D5D124-0x0000000187D5D12C
		public virtual List<ShareDataObject> GetAllShareDataObject() => default; // 0x0000000188969440-0x00000001889694A0
		public abstract ShareDataObject DuplicateShareDataObject(ShareDataObject source);
		protected void SetUserEnable(bool sw) {} // 0x0000000188969E48-0x0000000188969E7C
		internal virtual void UpdateCullingMode(CoreComponent Caller) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnChangeCalculation() {} // 0x000000018350B670-0x000000018350B680
		public abstract int GetVersion();
		public abstract int GetErrorVersion();
		public virtual Define.Error VerifyData() => default; // 0x0000000188969EC0-0x0000000188969F44
		public Define.Error VerifyDataVersion() => default; // 0x0000000188969E84-0x0000000188969EC0
		public bool IsOldDataVertion() => default; // 0x0000000188969BC8-0x0000000188969BEC
		public virtual void CreateVerifyData() {} // 0x0000000188969410-0x0000000188969440
		public virtual string GetInformation() => default; // 0x0000000188969584-0x00000001889695B0
		public virtual bool UpgradeFormat() => default; // 0x000000018115F4C0-0x000000018115F530
		public void ChangeAvatar<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class {}
		public virtual void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class {}
		public virtual HashSet<Transform> GetUsedBones() => default; // 0x00000001889695B0-0x0000000188969644
		public virtual int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x00000001889694EC-0x0000000188969538
		public virtual List<int> GetEditorTriangleList() => default; // 0x0000000188969538-0x0000000188969584
		public virtual List<int> GetEditorLineList() => default; // 0x00000001889694A0-0x00000001889694EC
		public virtual List<int> GetSelectionList() => default; // 0x0000000181002730-0x0000000181002740
		public virtual List<int> GetUseList() => default; // 0x0000000181002730-0x0000000181002740
	}

	[Serializable]
	public class AvatarPartsAttachEvent : UnityEvent<MagicaCloth.MagicaAvatar, MagicaCloth.MagicaAvatarParts> // TypeDefIndex: 51325
	{
		// Constructors
		public AvatarPartsAttachEvent() {} // 0x000000018895B444-0x000000018895B480
	}

	[Serializable]
	public class AvatarPartsDetachEvent : UnityEvent<MagicaCloth.MagicaAvatar> // TypeDefIndex: 51326
	{
		// Constructors
		public AvatarPartsDetachEvent() {} // 0x000000018895B480-0x000000018895B4BC
	}

	[Serializable]
	public class PhysicsManagerPreUpdateEvent : UnityEvent // TypeDefIndex: 51327
	{
		// Constructors
		public PhysicsManagerPreUpdateEvent() {} // 0x0000000184271C98-0x0000000184271CA0
	}

	[Serializable]
	public class PhysicsManagerPostUpdateEvent : UnityEvent // TypeDefIndex: 51328
	{
		// Constructors
		public PhysicsManagerPostUpdateEvent() {} // 0x0000000184271C98-0x0000000184271CA0
	}

	[AddComponentMenu("MagicaCloth/MagicaAreaWind")]
	public class MagicaAreaWind : WindComponent // TypeDefIndex: 51329
	{
		// Fields
		[SerializeField]
		private PhysicsManagerWindData.ShapeType shapeType; // 0x58
		[SerializeField]
		private bool isAddition; // 0x5C
	
		// Properties
		public PhysicsManagerWindData.ShapeType ShapeType { get => default; set {} } // 0x0000000183D4EF00-0x0000000183D4EF10 0x000000018896A1DC-0x000000018896A1FC
		public bool Addition { get => default; set {} } // 0x0000000183D4F600-0x0000000183D4F610 0x000000018896A1BC-0x000000018896A1DC
	
		// Constructors
		public MagicaAreaWind() {} // 0x000000018896A1B4-0x000000018896A1BC
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000183D6DF90-0x0000000183D6DFA0
		public override PhysicsManagerWindData.WindType GetWindType() => default; // 0x0000000182102C70-0x0000000182102C80
		public override PhysicsManagerWindData.ShapeType GetShapeType() => default; // 0x0000000183D4EF00-0x0000000183D4EF10
		public override PhysicsManagerWindData.DirectionType GetDirectionType() => default; // 0x000000018896A144-0x000000018896A154
		public override bool IsAddition() => default; // 0x0000000183D4F600-0x0000000183D4F610
		public override Vector3 GetAreaSize() => default; // 0x000000018896A004-0x000000018896A09C
		public override float GetAreaVolume() => default; // 0x000000018896A09C-0x000000018896A144
		public override float GetAreaLength() => default; // 0x0000000188969FB8-0x000000018896A004
		protected override void ResetParams() {} // 0x000000018896A154-0x000000018896A1B4
	}

	[AddComponentMenu("MagicaCloth/MagicaAvatar")]
	[HelpURL("https://magicasoft.jp/avatar/")]
	public class MagicaAvatar : CoreComponent // TypeDefIndex: 51330
	{
		// Fields
		private const int DATA_VERSION = 1; // Metadata: 0x01FD0E24
		[SerializeField]
		private bool dataReset; // 0x38
		private MagicaAvatarRuntime runtime; // 0x40
		public AvatarPartsAttachEvent OnAttachParts; // 0x48
		public AvatarPartsDetachEvent OnDetachParts; // 0x50
	
		// Properties
		public bool DataReset { get => default; set {} } // 0x0000000183D4F190-0x0000000183D4F1A0 0x0000000183D4E280-0x0000000183D4E290
		public MagicaAvatarRuntime Runtime { get => default; } // 0x0000000183A46A20-0x0000000183A46A50 
	
		// Constructors
		public MagicaAvatar() {} // 0x000000018896D684-0x000000018896D764
	
		// Methods
		public int AttachAvatarParts(GameObject avatarPartsPrefab, Action<GameObject> instanceAction = null) => default; // 0x000000018896CD9C-0x000000018896CE64
		public void DetachAvatarParts(int partsId) {} // 0x000000018896CE9C-0x000000018896CEC8
		public void DetachAvatarParts(GameObject avatarPartsObject) {} // 0x000000018896CEC8-0x000000018896CF38
		public void DetachAvatarParts(MagicaAvatarParts parts) {} // 0x000000018896CE6C-0x000000018896CE9C
		public override ComponentType GetComponentType() => default; // 0x0000000183D5D090-0x0000000183D5D0A0
		public override int GetDataHash() => default; // 0x0000000181002730-0x0000000181002740
		private void Reset() {} // 0x0000000183D5C330-0x0000000183D5C340
		private void OnValidate() {} // 0x000000018350B670-0x000000018350B680
		protected override void OnInit() {} // 0x000000018896D5E4-0x000000018896D60C
		protected override void OnDispose() {} // 0x000000018896D594-0x000000018896D5BC
		protected override void OnUpdate() {} // 0x000000018350B670-0x000000018350B680
		protected override void OnActive() {} // 0x000000018896D56C-0x000000018896D594
		protected override void OnInactive() {} // 0x000000018896D5BC-0x000000018896D5E4
		public override int GetVersion() => default; // 0x0000000181168950-0x0000000181168960
		public override int GetErrorVersion() => default; // 0x0000000181002730-0x0000000181002740
		public override void CreateVerifyData() {} // 0x000000018896CE64-0x000000018896CE6C
		public override Define.Error VerifyData() => default; // 0x000000018896D60C-0x000000018896D684
		public override string GetInformation() => default; // 0x000000018896CF40-0x000000018896D56C
		public override List<ShareDataObject> GetAllShareDataObject() => default; // 0x000000018896CF38-0x000000018896CF40
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source) => default; // 0x0000000181002730-0x0000000181002740
	}

	[AddComponentMenu("MagicaCloth/MagicaDirectionalWind")]
	[HelpURL("https://magicasoft.jp/directional-wind/")]
	public class MagicaDirectionalWind : WindComponent // TypeDefIndex: 51331
	{
		// Constructors
		public MagicaDirectionalWind() {} // 0x000000018896A1B4-0x000000018896A1BC
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000183D6DFF0-0x0000000183D6E000
		public override PhysicsManagerWindData.WindType GetWindType() => default; // 0x0000000181168950-0x0000000181168960
		public override PhysicsManagerWindData.ShapeType GetShapeType() => default; // 0x0000000181002730-0x0000000181002740
		public override PhysicsManagerWindData.DirectionType GetDirectionType() => default; // 0x0000000181002730-0x0000000181002740
		public override bool IsAddition() => default; // 0x000000018115F4C0-0x000000018115F530
		public override Vector3 GetAreaSize() => default; // 0x0000000183D6DFC0-0x0000000183D6DFE0
		public override float GetAreaVolume() => default; // 0x0000000183D6DFE0-0x0000000183D6DFF0
		public override float GetAreaLength() => default; // 0x0000000183D6DFB0-0x0000000183D6DFC0
		protected override void ResetParams() {} // 0x000000018896D764-0x000000018896D7C4
	}

	[HelpURL("https://magicasoft.jp/magica-cloth-physics-manager/")]
	public class MagicaPhysicsManager : CreateSingleton<MagicaCloth.MagicaPhysicsManager> // TypeDefIndex: 51334
	{
		// Fields
		[SerializeField]
		private UpdateTimeManager updateTime; // 0x18
		private PhysicsManagerParticleData particle; // 0x20
		private PhysicsManagerBoneData bone; // 0x28
		private PhysicsManagerMeshData mesh; // 0x30
		private PhysicsManagerTeamData team; // 0x38
		private PhysicsManagerWindData wind; // 0x40
		private PhysicsManagerComponent component; // 0x48
		private PhysicsManagerCompute compute; // 0x50
		[SerializeField]
		private bool useFasterWrite; // 0x58
		private ComputeShader meshWriter; // 0x60
		public PhysicsManagerPreUpdateEvent OnPreUpdate; // 0x68
		public PhysicsManagerPostUpdateEvent OnPostUpdate; // 0x70
		private bool useDelay; // 0x78
		private bool updatePlayerLoop; // 0x79
		private bool isActive; // 0x7A
	
		// Properties
		public UpdateTimeManager.UpdateCount UpdatePerSeccond { get => default; set {} } // 0x0000000184273240-0x000000018427325C 0x0000000185F30838-0x0000000185F30854
		public UpdateTimeManager.UpdateMode UpdateMode { get => default; set {} } // 0x000000018896DB10-0x000000018896DB2C 0x000000018896DB5C-0x000000018896DB78
		public float FuturePredictionRate { get => default; set {} } // 0x0000000184274B54-0x0000000184274B74 0x000000018896DB2C-0x000000018896DB54
		public UpdateTimeManager UpdateTime { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public PhysicsManagerParticleData Particle { get => default; } // 0x0000000183A46A50-0x0000000183A46A80 
		public PhysicsManagerBoneData Bone { get => default; } // 0x0000000182313050-0x0000000182313080 
		public PhysicsManagerMeshData Mesh { get => default; } // 0x0000000182313BD0-0x0000000182313C60 
		public PhysicsManagerTeamData Team { get => default; } // 0x0000000182313C60-0x0000000182313CF0 
		public PhysicsManagerWindData Wind { get => default; } // 0x0000000183A46A20-0x0000000183A46A50 
		public PhysicsManagerComponent Component { get => default; } // 0x0000000182313080-0x00000001823130B0 
		public PhysicsManagerCompute Compute { get => default; } // 0x00000001823141E0-0x0000000182314270 
		public bool IsDelay { get => default; } // 0x0000000183D4F800-0x0000000183D4F810 
		public bool IsActive { get => default; set {} } // 0x0000000183D51AF0-0x0000000183D51B00 0x000000018896DB54-0x000000018896DB5C
		public bool IsFasterWrite { get => default; } // 0x000000018896D998-0x000000018896DA4C 
		internal ComputeShader MeshWriterShader { get => default; } // 0x000000018896DA4C-0x000000018896DB10 
	
		// Constructors
		public MagicaPhysicsManager() {} // 0x00000001837707F0-0x0000000183770A70
	
		// Methods
		public void SetGlobalTimeScale(float timeScale) {} // 0x000000018896D96C-0x000000018896D998
		public float GetGlobalTimeScale() => default; // 0x0000000184273220-0x0000000184273240
		protected override void Awake() {} // 0x0000000183D3DC20-0x0000000183D3DC60
		protected override void InitSingleton() {} // 0x0000000183A46940-0x0000000183A46A20
		protected override void DuplicateDetection(MagicaPhysicsManager duplicate) {} // 0x000000018896D7C4-0x000000018896D830
		protected void OnEnable() {} // 0x0000000183D4D8B0-0x0000000183D4D8D0
		protected void OnDisable() {} // 0x000000018896D938-0x000000018896D96C
		private void Update() {} // 0x00000001832BAA90-0x00000001832BAAC0
		private void FixedUpdate() {} // 0x000000018310B760-0x000000018310B940
		protected override void OnDestroy() {} // 0x000000018896D830-0x000000018896D938
		private void AfterEarlyUpdate() {} // 0x0000000182312BF0-0x0000000182312C30
		private void AfterFixedUpdate() {} // 0x00000001823139B0-0x00000001823139F0
		private void AfterUpdate() {} // 0x0000000182312C30-0x0000000182312C70
		private void BeforeLateUpdate() {} // 0x0000000182312A50-0x0000000182312A80
		private void AfterLateUpdate() {} // 0x0000000182312A80-0x0000000182312AB0
		private void DefaultUpdate() {} // 0x0000000182313CF0-0x00000001823141E0
		private void PostLateUpdate() {} // 0x0000000182312AE0-0x0000000182312B00
		private void AfterRendering() {} // 0x0000000182312AB0-0x0000000182312AE0
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Init() {} // 0x0000000183D47740-0x0000000183D47770
		[RuntimeInitializeOnLoadMethod]
		public static void InitCustomGameLoop() {} // 0x00000001832BAAC0-0x00000001832BAB60
		public static void SetCustomGameLoop(ref PlayerLoopSystem playerLoop) {} // 0x0000000182D95DA0-0x0000000182D97710
		private static bool CheckRegist(ref PlayerLoopSystem playerLoop) => default; // 0x0000000182D94370-0x0000000182D94500
	}

	public abstract class WindComponent : BaseComponent // TypeDefIndex: 51335
	{
		// Fields
		[Range(0f, 100f)]
		[SerializeField]
		protected float main; // 0x18
		[Range(0f, 1f)]
		[SerializeField]
		protected float turbulence; // 0x1C
		[Range(0f, 1f)]
		[SerializeField]
		protected float frequency; // 0x20
		[SerializeField]
		protected Vector3 areaSize; // 0x24
		[SerializeField]
		protected float areaRadius; // 0x30
		[Range(-180f, 180f)]
		[SerializeField]
		protected float directionAngleX; // 0x34
		[Range(-180f, 180f)]
		[SerializeField]
		protected float directionAngleY; // 0x38
		[SerializeField]
		protected PhysicsManagerWindData.DirectionType directionType; // 0x3C
		[SerializeField]
		protected BezierParam attenuation; // 0x40
		protected int windId; // 0x48
		protected RuntimeStatus status; // 0x50
	
		// Properties
		public float Main { get; set; } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x000000018896EFA0-0x000000018896EFE0
		public float Turbulence { get; set; } // 0x0000000183D4F110-0x0000000183D4F120 0x000000018896EFE0-0x000000018896F00C
		public float Frequency { get; set; } // 0x0000000183D4F2E0-0x0000000183D4F2F0 0x000000018896EEC0-0x000000018896EEEC
		public Vector3 MainDirection { get; set; } // 0x000000018896ECEC-0x000000018896ED70 0x000000018896EEEC-0x000000018896EFA0
		public float DirectionAngleX { get; set; } // 0x0000000183D56CA0-0x0000000183D56CB0 0x000000018896EE58-0x000000018896EE7C
		public float DirectionAngleY { get; set; } // 0x0000000183D51000-0x0000000183D51010 0x000000018896EE7C-0x000000018896EEA0
		public Vector3 AreaSize { get; set; } // 0x0000000183D59780-0x0000000183D597A0 0x000000018896EDA4-0x000000018896EE58
		public float AreaRadius { get; set; } // 0x0000000183D4F5D0-0x0000000183D4F5E0 0x000000018896ED70-0x000000018896EDA4
		public PhysicsManagerWindData.DirectionType DirectionType { get; set; } // 0x0000000183D4ED90-0x0000000183D4EDA0 0x000000018896EEA0-0x000000018896EEC0
		internal RuntimeStatus Status { get; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
	
		// Constructors
		protected WindComponent() {} // 0x000000018896EC10-0x000000018896ECEC
	
		// Methods
		public void SetAttenuation(float sval, float eval, bool useEval = true /* Metadata: 0x01FD0E25 */, float cval = 0f /* Metadata: 0x01FD0E26 */, bool useCval = false /* Metadata: 0x01FD0E2A */) {} // 0x000000018896EB5C-0x000000018896EBA4
		protected virtual void Reset() {} // 0x000000018896EB4C-0x000000018896EB5C
		protected virtual void OnValidate() {} // 0x000000018896E9E8-0x000000018896EAC4
		private void OnDidApplyAnimationProperties() {} // 0x000000018896E860-0x000000018896E890
		protected virtual void Start() {} // 0x000000018896EBA4-0x000000018896EBAC
		internal virtual void OnEnable() {} // 0x000000018896E908-0x000000018896E934
		internal virtual void OnDisable() {} // 0x000000018896E890-0x000000018896E8BC
		protected virtual void OnDestroy() {} // 0x000000018896E834-0x000000018896E860
		protected virtual void Update() {} // 0x000000018896EBAC-0x000000018896EC10
		private void Init() {} // 0x000000018896E6E0-0x000000018896E82C
		protected void OnUpdateStatus() {} // 0x000000018896E97C-0x000000018896E9B8
		internal virtual bool VerifyData() => default; // 0x000000018232EB60-0x000000018232EB70
		protected virtual void OnInit() {} // 0x000000018896E93C-0x000000018896E97C
		protected virtual void OnDispose() {} // 0x000000018896E8BC-0x000000018896E908
		protected virtual void OnUpdate() {} // 0x000000018896E9B8-0x000000018896E9E8
		protected virtual void OnActive() {} // 0x000000018896E82C-0x000000018896E834
		protected virtual void OnInactive() {} // 0x000000018896E934-0x000000018896E93C
		protected void EnableWind() {} // 0x000000018896E5D8-0x000000018896E668
		protected void DisableWind() {} // 0x000000018896E52C-0x000000018896E5D8
		private void RemoveWind() {} // 0x000000018896EAC4-0x000000018896EB4C
		private void CreateWind() {} // 0x000000018896E304-0x000000018896E52C
		internal Vector3 GetLocalDirection() => default; // 0x000000018896E668-0x000000018896E6E0
		private void ChangeParameter() {} // 0x000000018896E11C-0x000000018896E304
		public abstract PhysicsManagerWindData.WindType GetWindType();
		public abstract PhysicsManagerWindData.ShapeType GetShapeType();
		public abstract PhysicsManagerWindData.DirectionType GetDirectionType();
		public abstract bool IsAddition();
		public abstract Vector3 GetAreaSize();
		public abstract float GetAreaVolume();
		public abstract float GetAreaLength();
		protected abstract void ResetParams();
	}

	public abstract class MagicaAvatarAccess : IDisposable // TypeDefIndex: 51336
	{
		// Fields
		protected MagicaAvatar owner; // 0x10
	
		// Properties
		protected MagicaAvatarRuntime Runtime { get; } // 0x000000018896A1FC-0x000000018896A21C 
	
		// Constructors
		protected MagicaAvatarAccess() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void SetParent(MagicaAvatar avatar) {} // 0x000000018426FEE0-0x000000018426FEF0
		public abstract void Create();
		public abstract void Dispose();
		public abstract void Active();
		public abstract void Inactive();
	}

	[AddComponentMenu("MagicaCloth/MagicaAvatarParts")]
	[HelpURL("https://magicasoft.jp/avatar-parts/")]
	public class MagicaAvatarParts : BaseComponent, IDataVerify // TypeDefIndex: 51337
	{
		// Fields
		private MagicaAvatar parentAvatar; // 0x18
		private Dictionary<string, Transform> boneDict; // 0x20
		private List<CoreComponent> magicaComponentList; // 0x28
	
		// Properties
		public MagicaAvatar ParentAvatar { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public bool HasParent { get => default; } // 0x000000018896ACD4-0x000000018896AD24 
		public int PartsId { get => default; } // 0x000000018896AD24-0x000000018896AD2C 
	
		// Constructors
		public MagicaAvatarParts() {} // 0x000000018896AC54-0x000000018896ACD4
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000183D6DFA0-0x0000000183D6DFB0
		private void OnDestroy() {} // 0x000000018896ABE4-0x000000018896ABEC
		public void Dispose() {} // 0x000000018896A434-0x000000018896A4C0
		public List<Transform> CheckOverlappingTransform() => default; // 0x000000018896A21C-0x000000018896A3E8
		public Dictionary<string, Transform> GetBoneDict() => default; // 0x000000018896A4C0-0x000000018896A680
		public List<CoreComponent> GetMagicaComponentList() => default; // 0x000000018896AB38-0x000000018896ABE4
		public int GetVersion() => default; // 0x0000000181168950-0x0000000181168960
		public void CreateVerifyData() {} // 0x000000018896A3E8-0x000000018896A434
		public Define.Error VerifyData() => default; // 0x000000018896ABEC-0x000000018896AC54
		public string GetInformation() => default; // 0x000000018896A680-0x000000018896AB38
	}

	public class MagicaAvatarRuntime : MagicaAvatarAccess // TypeDefIndex: 51339
	{
		// Fields
		private Dictionary<string, Transform> boneDict; // 0x18
		private Dictionary<Transform, int> boneReferenceDict; // 0x20
		private List<MagicaAvatarParts> avatarPartsList; // 0x28
		private List<ColliderComponent> colliderList; // 0x30
	
		// Properties
		public int AvatarPartsCount { get => default; } // 0x000000018896CD5C-0x000000018896CD9C 
	
		// Constructors
		public MagicaAvatarRuntime() {} // 0x000000018896CC04-0x000000018896CD5C
	
		// Methods
		public override void Create() {} // 0x000000018896C070-0x000000018896C090
		public override void Dispose() {} // 0x000000018350B670-0x000000018350B680
		public override void Active() {} // 0x000000018350B670-0x000000018350B680
		public override void Inactive() {} // 0x000000018350B670-0x000000018350B680
		public MagicaAvatarParts GetAvatarParts(int index) => default; // 0x000000018896C090-0x000000018896C0E4
		private void CreateBoneDict() {} // 0x000000018896BE50-0x000000018896BFF8
		private void CreateColliderList() {} // 0x000000018896BFF8-0x000000018896C070
		public int GetColliderCount() => default; // 0x000000018896C0E4-0x000000018896C150
		public List<Transform> CheckOverlappingTransform() => default; // 0x000000018896BC74-0x000000018896BE50
		public int AddAvatarParts(MagicaAvatarParts parts) => default; // 0x000000018896AD2C-0x000000018896B9A8
		private void AddBone(Transform root, Transform croot, Transform bone) {} // 0x000000018896B9A8-0x000000018896BC74
		private void ReplaceSkinMeshRenderer(SkinnedMeshRenderer skinRenderer, Dictionary<Transform, Transform> boneReplaceDict) {} // 0x000000018896CB10-0x000000018896CC04
		private void ReplaceMagicaComponent(CoreComponent comp, Dictionary<Transform, Transform> boneReplaceDict) {} // 0x000000018896CABC-0x000000018896CB10
		public void RemoveAvatarParts(MagicaAvatarParts parts) {} // 0x000000018896C150-0x000000018896C9E0
		public void RemoveAvatarParts(int partsId) {} // 0x000000018896C9E0-0x000000018896CABC
	}

	[Serializable]
	public class BoneClothTarget : IDataHash, IBoneReplace // TypeDefIndex: 51341
	{
		// Fields
		[SerializeField]
		private List<Transform> rootList; // 0x10
		[SerializeField]
		private ConnectionMode connection; // 0x18
		[Range(10f, 90f)]
		[SerializeField]
		private float sameSurfaceAngle; // 0x1C
		private int[] parentIndexList; // 0x20
	
		// Properties
		public int RootCount { get => default; } // 0x000000018895BD4C-0x000000018895BD8C 
		public ConnectionMode Connection { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public float SameSurfaceAngle { get => default; } // 0x0000000183D4F110-0x0000000183D4F120 
		public bool IsMeshConnection { get => default; } // 0x000000018895BD34-0x000000018895BD4C 
	
		// Nested types
		public enum ConnectionMode // TypeDefIndex: 51340
		{
			Line = 0,
			MeshAutomatic = 1,
			MeshSequentialLoop = 2,
			MeshSequentialNoLoop = 3
		}
	
		// Constructors
		public BoneClothTarget() {} // 0x000000018895BCB4-0x000000018895BD34
	
		// Methods
		public int GetDataHash() => default; // 0x000000018895B9B8-0x000000018895B9F4
		public Transform GetRoot(int index) => default; // 0x000000018895BA48-0x000000018895BAB4
		public int GetRootIndex(Transform root) => default; // 0x000000018895B9F4-0x000000018895BA48
		public void AddParentTransform() {} // 0x000000018895B4BC-0x000000018895B8F8
		public void RemoveParentTransform() {} // 0x000000018895BB28-0x000000018895BC04
		public void ResetFuturePredictionParentTransform() {} // 0x000000018895BC04-0x000000018895BCB4
		public void ChangeUnityPhysicsCount(bool sw) {} // 0x000000018895B8F8-0x000000018895B9B8
		public void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class {}
		public HashSet<Transform> GetUsedBones() => default; // 0x000000018895BAB4-0x000000018895BB28
	}

	[Serializable]
	public class ClothData : ShareDataObject // TypeDefIndex: 51350
	{
		// Fields
		private const int DATA_VERSION = 5; // Metadata: 0x01FD0E2F
		public const uint VertexFlag_End = 65536; // Metadata: 0x01FD0E30
		public const uint VertexFlag_TriangleRotation = 131072; // Metadata: 0x01FD0E34
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
		public int VertexUseCount { get => default; } // 0x0000000188967C70-0x0000000188967CB0 
		public int StructDistanceConstraintCount { get => default; } // 0x0000000188967C14-0x0000000188967C28 
		public int BendDistanceConstraintCount { get => default; } // 0x0000000188967AF0-0x0000000188967B04 
		public int NearDistanceConstraintCount { get => default; } // 0x0000000188967BAC-0x0000000188967BC4 
		public int ClampDistanceConstraintCount { get => default; } // 0x0000000188967B1C-0x0000000188967B34 
		public int ClampDistance2ConstraintCount { get => default; } // 0x0000000188967B04-0x0000000188967B1C 
		public int RestoreRotationConstraintCount { get => default; } // 0x0000000188967BFC-0x0000000188967C14 
		public int ClampRotationConstraintDataCount { get => default; } // 0x0000000188967B34-0x0000000188967B4C 
		public int ClampRotationConstraintRootCount { get => default; } // 0x0000000188967B4C-0x0000000188967B64 
		public int AdjustRotationConstraintCount { get => default; } // 0x0000000188967AC0-0x0000000188967AD8 
		public int CompositeRotationCount { get => default; } // 0x0000000188967B64-0x0000000188967B7C 
		public int TwistConstraintCount { get => default; } // 0x0000000188967C58-0x0000000188967C70 
		public int TriangleBendConstraintCount { get => default; } // 0x0000000188967C28-0x0000000188967C40 
		public int EdgeCollisionConstraintCount { get => default; } // 0x0000000188967B7C-0x0000000188967B94 
		public int VolumeConstraintCount { get => default; } // 0x0000000188967CB0-0x0000000188967CC8 
		public int LineRotationWorkerCount { get => default; } // 0x0000000188967B94-0x0000000188967BAC 
		public int TriangleRotationWorkerCount { get => default; } // 0x0000000188967C40-0x0000000188967C58 
		public int PenetrationCount { get => default; } // 0x0000000188967BC4-0x0000000188967BFC 
		public int BaseSkinningCount { get => default; } // 0x0000000188967AD8-0x0000000188967AF0 
	
		// Nested types
		private class RestoreDistanceWork // TypeDefIndex: 51342
		{
			// Fields
			public uint vertexPair; // 0x10
			public float dist; // 0x14
	
			// Constructors
			public RestoreDistanceWork() {} // 0x000000018350B670-0x000000018350B680
		}
	
		private class PenetrationBone // TypeDefIndex: 51343
		{
			// Fields
			public Transform bone; // 0x10
			public Transform childBone; // 0x18
	
			// Constructors
			public PenetrationBone() {} // 0x000000018350B670-0x000000018350B680
		}
	
		private class PenetrationWork // TypeDefIndex: 51344
		{
			// Fields
			public Transform bone; // 0x10
			public Transform childBone; // 0x18
			public int boneIndex; // 0x20
			public float distance; // 0x24
			public float weight; // 0x28
	
			// Constructors
			public PenetrationWork() {} // 0x000000018350B670-0x000000018350B680
		}
	
		private class VertexInfo // TypeDefIndex: 51345
		{
			// Fields
			public int vertexIndex; // 0x10
			public int parentVertexIndex; // 0x14
			public List<int> childVertexList; // 0x18
			public VertexInfo parentInfo; // 0x20
			public List<VertexInfo> childInfoList; // 0x28
	
			// Constructors
			public VertexInfo() {} // 0x000000018896E058-0x000000018896E11C
		}
	
		// Constructors
		public ClothData() {} // 0x0000000188967910-0x0000000188967AC0
	
		// Methods
		public override int GetDataHash() => default; // 0x0000000188965068-0x0000000188965518
		public int GetClampRotationCount() => default; // 0x000000018896502C-0x0000000188965068
		public int GetRestoreRotationCount() => default; // 0x0000000188965688-0x00000001889656C4
		public bool IsInvalidVertex(int vindex) => default; // 0x0000000188966FF4-0x000000018896704C
		public bool IsFixedVertex(int vindex) => default; // 0x0000000188966F30-0x0000000188966F8C
		public bool IsMoveVertex(int vindex) => default; // 0x000000018896705C-0x00000001889670B8
		public bool IsExtendVertex(int vindex) => default; // 0x0000000188966ED4-0x0000000188966F30
		public bool IsLastLevel(int vindex) => default; // 0x000000018896704C-0x000000018896705C
		public bool IsFlag(int vindex, uint flag) => default; // 0x0000000188966F8C-0x0000000188966FF4
		public void SetFlag(int vindex, uint flag) {} // 0x000000018896762C-0x00000001889676B0
		public int GetLevel(int vindex) => default; // 0x0000000188965518-0x0000000188965570
		public override int GetVersion() => default; // 0x0000000183D51100-0x0000000183D51110
		public override Define.Error VerifyData() => default; // 0x0000000188967830-0x0000000188967910
		public void CreateData(PhysicsTeam team, ClothParams clothParams, PhysicsTeamData teamData, MeshData meshData, IEditorMesh editMesh, List<int> selData, Action<List<int>, List<int>, List<Vector3>, List<Vector3>, List<Vector3>, List<int>, List<int>> extensionAction = null) {} // 0x000000018896470C-0x0000000188964954
		private void CreateVertexData(int vertexCount, List<int> lineList, List<int> triangleList) {} // 0x0000000188964954-0x000000018896502C
		private void CreateConstraintData(PhysicsTeam team, ClothParams clothParams, PhysicsTeamData teamData, int vertexCount, List<Vector3> wposList, List<Vector3> wnorList, List<Vector3> wtanList, List<int> lineList, List<int> triangleList) {} // 0x000000018895C498-0x000000018896470C
		private void RegistTriangleBend(int v0, int v1, int v2, int v3, List<Vector3> wposList, ClothParams clothParams, List<TriangleBendConstraint.TriangleBendData> triangleBendData) {} // 0x00000001889670B8-0x000000018896762C
		private List<int> SortTetra(int v0, int v1, int v2, int v3, List<float> meshVertexDepthList) => default; // 0x00000001889676B0-0x0000000188967830
		private List<int> CheckTetraDirection(int v0, int v1, int v2, int v3, HashSet<ulong> trianglePackSet, List<float> meshVertexDepthList) => default; // 0x000000018895C054-0x000000018895C498
		private bool CalcTriangleBendRestAngle(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, out float restAngle) {
			restAngle = default;
			return default;
		} // 0x000000018895BD8C-0x000000018895C054
		private List<float> GetMeshVertexDepthList(int vertexCount, List<float> depthList) => default; // 0x0000000188965570-0x0000000188965688
		private List<int> GetUseParentVertexList(int vertexCount, List<HashSet<int>> vlink, List<Vector3> wposList, List<float> depthList) => default; // 0x00000001889656C4-0x00000001889666F4
		private List<int> GetUseRootVertexList(List<int> parentVertexList) => default; // 0x0000000188966BF4-0x0000000188966CF0
		private List<VertexInfo> GetUseVertexInfoList(List<int> parentVertexList) => default; // 0x0000000188966CF0-0x0000000188966ED4
		private List<List<int>> GetUseRootLineList(List<int> parentVertexList) => default; // 0x00000001889666F4-0x0000000188966BF4
	}

	[Serializable]
	public class ClothParams // TypeDefIndex: 51357
	{
		// Fields
		[SerializeField]
		private Algorithm algorithm; // 0x10
		[SerializeField]
		private BezierParam radius; // 0x18
		[SerializeField]
		private BezierParam mass; // 0x20
		[SerializeField]
		private bool useGravity; // 0x28
		[SerializeField]
		private BezierParam gravity; // 0x30
		[SerializeField]
		private Vector3 gravityDirection; // 0x38
		[SerializeField]
		private bool useDrag; // 0x44
		[SerializeField]
		private BezierParam drag; // 0x48
		[SerializeField]
		private bool useMaxVelocity; // 0x50
		[SerializeField]
		private BezierParam maxVelocity; // 0x58
		[SerializeField]
		private Transform influenceTarget; // 0x60
		[SerializeField]
		private float maxMoveSpeed; // 0x68
		[SerializeField]
		private float maxRotationSpeed; // 0x6C
		[SerializeField]
		private BezierParam worldMoveInfluence; // 0x70
		[SerializeField]
		private BezierParam worldRotationInfluence; // 0x78
		[SerializeField]
		private float massInfluence; // 0x80
		[SerializeField]
		private BezierParam depthInfluence; // 0x88
		[SerializeField]
		private float windInfluence; // 0x90
		[SerializeField]
		private float windRandomScale; // 0x94
		[SerializeField]
		private float windSynchronization; // 0x98
		[SerializeField]
		private bool useDistanceDisable; // 0x9C
		[SerializeField]
		private Transform disableReferenceObject; // 0xA0
		[SerializeField]
		private float disableDistance; // 0xA8
		[SerializeField]
		private float disableFadeDistance; // 0xAC
		[SerializeField]
		private bool useResetTeleport; // 0xB0
		[SerializeField]
		private float teleportDistance; // 0xB4
		[SerializeField]
		private float teleportRotation; // 0xB8
		[SerializeField]
		private TeleportMode teleportMode; // 0xBC
		[SerializeField]
		private float resetStabilizationTime; // 0xC0
		[SerializeField]
		private bool useClampDistanceRatio; // 0xC4
		[SerializeField]
		private float clampDistanceMinRatio; // 0xC8
		[SerializeField]
		private float clampDistanceMaxRatio; // 0xCC
		[SerializeField]
		private float clampDistanceVelocityInfluence; // 0xD0
		[SerializeField]
		private bool useClampPositionLength; // 0xD4
		[SerializeField]
		private BezierParam clampPositionLength; // 0xD8
		[SerializeField]
		private float clampPositionRatioX; // 0xE0
		[SerializeField]
		private float clampPositionRatioY; // 0xE4
		[SerializeField]
		private float clampPositionRatioZ; // 0xE8
		[SerializeField]
		private float clampPositionVelocityInfluence; // 0xEC
		[SerializeField]
		private bool useClampRotation; // 0xF0
		[SerializeField]
		private BezierParam clampRotationAngle; // 0xF8
		[SerializeField]
		private BezierParam clampRotationAngle2; // 0x100
		[SerializeField]
		private float clampRotationVelocityLimit; // 0x108
		[SerializeField]
		private float clampRotationVelocityInfluence; // 0x10C
		[SerializeField]
		private float restoreDistanceVelocityInfluence; // 0x110
		[SerializeField]
		private BezierParam structDistanceStiffness; // 0x118
		[SerializeField]
		private bool useBendDistance; // 0x120
		[SerializeField]
		private int bendDistanceMaxCount; // 0x124
		[SerializeField]
		private BezierParam bendDistanceStiffness; // 0x128
		[SerializeField]
		private bool useNearDistance; // 0x130
		[SerializeField]
		private int nearDistanceMaxCount; // 0x134
		[SerializeField]
		private float nearDistanceMaxDepth; // 0x138
		[SerializeField]
		private BezierParam nearDistanceLength; // 0x140
		[SerializeField]
		private BezierParam nearDistanceStiffness; // 0x148
		[SerializeField]
		private bool useRestoreRotation; // 0x150
		[SerializeField]
		private BezierParam restoreRotation; // 0x158
		[SerializeField]
		private BezierParam restoreRotation2; // 0x160
		[SerializeField]
		private float restoreRotationVelocityInfluence; // 0x168
		[SerializeField]
		private float restoreRotationVelocityInfluence2; // 0x16C
		[SerializeField]
		private bool useSpring; // 0x170
		[SerializeField]
		private float springPower; // 0x174
		[SerializeField]
		private float springRadius; // 0x178
		[SerializeField]
		private float springScaleX; // 0x17C
		[SerializeField]
		private float springScaleY; // 0x180
		[SerializeField]
		private float springScaleZ; // 0x184
		[SerializeField]
		private float springIntensity; // 0x188
		[SerializeField]
		private BezierParam springDirectionAtten; // 0x190
		[SerializeField]
		private BezierParam springDistanceAtten; // 0x198
		[SerializeField]
		private AdjustMode adjustMode; // 0x1A0
		[SerializeField]
		private float adjustRotationPower; // 0x1A4
		[SerializeField]
		private bool useTriangleBend; // 0x1A8
		[SerializeField]
		private BezierParam triangleBend; // 0x1B0
		[SerializeField]
		private BezierParam triangleBend2; // 0x1B8
		[SerializeField]
		private bool useTwistCorrection; // 0x1C0
		[SerializeField]
		private float twistRecoveryPower; // 0x1C4
		[SerializeField]
		private bool useVolume; // 0x1C8
		[SerializeField]
		private float maxVolumeLength; // 0x1CC
		[SerializeField]
		private BezierParam volumeStretchStiffness; // 0x1D0
		[SerializeField]
		private BezierParam volumeShearStiffness; // 0x1D8
		[SerializeField]
		private bool useCollision; // 0x1E0
		[SerializeField]
		private float friction; // 0x1E4
		[SerializeField]
		private float staticFriction; // 0x1E8
		[SerializeField]
		private bool usePenetration; // 0x1EC
		[SerializeField]
		private PenetrationMode penetrationMode; // 0x1F0
		[SerializeField]
		private PenetrationAxis penetrationAxis; // 0x1F4
		[SerializeField]
		private float penetrationMaxDepth; // 0x1F8
		[SerializeField]
		private BezierParam penetrationConnectDistance; // 0x200
		[SerializeField]
		private BezierParam penetrationDistance; // 0x208
		[SerializeField]
		private BezierParam penetrationRadius; // 0x210
		[SerializeField]
		private bool useLineAvarageRotation; // 0x218
		[SerializeField]
		private bool useFixedNonRotation; // 0x219
		private HashSet<ParamType> changeSet; // 0x220
	
		// Properties
		public Algorithm AlgorithmType { get => default; set {} } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
		public bool UseGravity { get => default; } // 0x0000000183D4ED50-0x0000000183D4ED60 
		public Vector3 GravityDirection { get => default; set {} } // 0x0000000183D69690-0x0000000183D696B0 0x0000000183D68D90-0x0000000183D68DA0
		public bool UseDrag { get => default; } // 0x0000000183D4F170-0x0000000183D4F180 
		public bool UseMaxVelocity { get => default; } // 0x0000000183D4F000-0x0000000183D4F010 
		public float MassInfluence { get => default; set {} } // 0x0000000183D51B00-0x0000000183D51B10 0x0000000183D56E80-0x0000000183D56E90
		public float WindInfluence { get => default; set {} } // 0x0000000183D58560-0x0000000183D58570 0x0000000183D5C110-0x0000000183D5C120
		public float WindRandomScale { get => default; set {} } // 0x0000000183D58E90-0x0000000183D58EA0 0x0000000183D59120-0x0000000183D59130
		public float WindSynchronization { get => default; set {} } // 0x0000000183D57D90-0x0000000183D57DA0 0x0000000183D57DB0-0x0000000183D57DC0
		public float MaxMoveSpeed { get => default; set {} } // 0x0000000183D56A40-0x0000000183D56A50 0x0000000183D59110-0x0000000183D59120
		public float MaxRotationSpeed { get => default; set {} } // 0x0000000183D56C50-0x0000000183D56C60 0x0000000183D5B680-0x0000000183D5B690
		public bool UseResetTeleport { get => default; set {} } // 0x0000000181151530-0x0000000181151540 0x0000000181151540-0x0000000181151550
		public float TeleportDistance { get => default; set {} } // 0x0000000183D57F30-0x0000000183D57F40 0x0000000183D57FB0-0x0000000183D57FC0
		public float TeleportRotation { get => default; set {} } // 0x0000000183D599C0-0x0000000183D599D0 0x0000000183D50850-0x0000000183D50860
		public TeleportMode TeleportResetMode { get => default; set {} } // 0x0000000183D57F20-0x0000000183D57F30 0x0000000183D57FA0-0x0000000183D57FB0
		public float ResetStabilizationTime { get => default; set {} } // 0x0000000183D5D790-0x0000000183D5D7A0 0x0000000183D5D7B0-0x0000000183D5D7C0
		public bool UseDistanceDisable { get => default; set {} } // 0x0000000183D5E1C0-0x0000000183D5E1D0 0x0000000183D5E200-0x0000000183D5E210
		public Transform DisableReferenceObject { get => default; set {} } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000184270264-0x0000000184270278
		public float DisableDistance { get => default; set {} } // 0x0000000183D58510-0x0000000183D58520 0x0000000183D6DF40-0x0000000183D6DF50
		public float DisableFadeDistance { get => default; set {} } // 0x0000000183D58380-0x0000000183D58390 0x0000000183D6DF50-0x0000000183D6DF60
		public bool UseClampDistanceRatio { get => default; } // 0x0000000183D57F00-0x0000000183D57F10 
		public float ClampDistanceMinRatio { get => default; } // 0x0000000188969380-0x0000000188969398 
		public float ClampDistanceMaxRatio { get => default; } // 0x0000000188969368-0x0000000188969380 
		public float ClampDistanceVelocityInfluence { get => default; } // 0x0000000188969398-0x00000001889693B4 
		public bool UseClampPositionLength { get => default; } // 0x0000000183D6D690-0x0000000183D6D6A0 
		public Vector3 ClampPositionAxisRatio { get => default; } // 0x0000000183D6DEE0-0x0000000183D6DF00 
		public float ClampPositionVelocityInfluence { get => default; } // 0x00000001889693B4-0x00000001889693D0 
		public bool UseClampRotation { get => default; } // 0x0000000183D57D50-0x0000000183D57D60 
		public float ClampRotationVelocityInfluence { get => default; } // 0x00000001889693D0-0x00000001889693EC 
		public float RestoreDistanceVelocityInfluence { get => default; } // 0x0000000183D56EA0-0x0000000183D56EB0 
		public bool UseBendDistance { get => default; } // 0x0000000183D57B30-0x0000000183D57B40 
		public int BendDistanceMaxCount { get => default; } // 0x0000000183D6DED0-0x0000000183D6DEE0 
		public bool UseNearDistance { get => default; } // 0x0000000183D57B50-0x0000000183D57B60 
		public int NearDistanceMaxCount { get => default; } // 0x0000000183D4FC40-0x0000000183D4FC50 
		public float NearDistanceMaxDepth { get => default; } // 0x0000000183D57590-0x0000000183D575A0 
		public bool UseRestoreRotation { get => default; } // 0x0000000183D56A80-0x0000000183D56A90 
		public bool UseSpring { get => default; set {} } // 0x0000000183D57C60-0x0000000183D57C70 0x0000000183D6DF80-0x0000000183D6DF90
		public float SpringPowr { get => default; set {} } // 0x0000000183D57CF0-0x0000000183D57D00 0x0000000183D6DF60-0x0000000183D6DF70
		public float SpringRadius { get => default; } // 0x0000000183D575D0-0x0000000183D575E0 
		public Vector3 SpringRadiusScale { get => default; } // 0x0000000183D6DF00-0x0000000183D6DF20 
		public float SpringIntensity { get => default; } // 0x0000000183D58240-0x0000000183D58250 
		public AdjustMode AdjustRotationMode { get => default; } // 0x0000000183D586D0-0x0000000183D586E0 
		public Vector3 AdjustRotationVector { get => default; } // 0x0000000188969314-0x0000000188969368 
		public bool UseTriangleBend { get => default; } // 0x0000000183D58E80-0x0000000183D58E90 
		internal float TwistRecoveryPower { get => default; } // 0x0000000183D579D0-0x0000000183D579E0 
		public bool UseVolume { get => default; } // 0x0000000183D57C80-0x0000000183D57C90 
		public bool UseCollision { get => default; } // 0x0000000183D58E20-0x0000000183D58E30 
		public float DynamicFriction { get => default; } // 0x0000000183D58CE0-0x0000000183D58CF0 
		public float StaticFriction { get => default; } // 0x0000000183D59990-0x0000000183D599A0 
		public bool UsePenetration { get => default; set {} } // 0x0000000183D6DF30-0x0000000183D6DF40 0x0000000183D6DF70-0x0000000183D6DF80
		public float PenetrationMaxDepth { get => default; } // 0x0000000183D58CC0-0x0000000183D58CD0 
		public bool UseLineAvarageRotation { get => default; } // 0x0000000183D57B20-0x0000000183D57B30 
		public bool UseFixedNonRotation { get => default; } // 0x0000000183D6DF20-0x0000000183D6DF30 
	
		// Nested types
		public enum Algorithm // TypeDefIndex: 51351
		{
			Algorithm_1 = 0,
			Algorithm_2 = 1
		}
	
		public enum TeleportMode // TypeDefIndex: 51352
		{
			Reset = 0,
			Keep = 1
		}
	
		public enum AdjustMode // TypeDefIndex: 51353
		{
			Fixed = 0,
			XYMove = 1,
			XZMove = 2,
			YZMove = 3
		}
	
		public enum PenetrationMode // TypeDefIndex: 51354
		{
			SurfacePenetration = 0,
			ColliderPenetration = 1
		}
	
		public enum PenetrationAxis // TypeDefIndex: 51355
		{
			X = 0,
			Y = 1,
			Z = 2,
			InverseX = 3,
			InverseY = 4,
			InverseZ = 5
		}
	
		public enum ParamType // TypeDefIndex: 51356
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
		public ClothParams() {} // 0x0000000188968B00-0x0000000188969314
	
		// Methods
		public void SetChangeParam(ParamType ptype) {} // 0x0000000188968668-0x00000001889686C0
		public bool ChangedParam(ParamType ptype) => default; // 0x0000000188967CC8-0x0000000188967D20
		public void ClearChangeParam() {} // 0x0000000188967D20-0x0000000188967D68
		public int GetParamHash(BaseCloth cloth, ParamType ptype) => default; // 0x0000000188967F80-0x0000000188968590
		public void SetRadius(float sval, float eval) {} // 0x00000001889688AC-0x00000001889688E0
		public float GetRadius(float depth) => default; // 0x0000000188968590-0x00000001889685B0
		public BezierParam GetRadius() => default; // 0x0000000181041090-0x00000001810410A0
		public void SetMass(float sval, float eval, bool useEval = true /* Metadata: 0x01FD0E38 */, float cval = 0f /* Metadata: 0x01FD0E39 */, bool useCval = false /* Metadata: 0x01FD0E3D */) {} // 0x000000018896883C-0x0000000188968878
		public BezierParam GetMass() => default; // 0x0000000183D4EB40-0x0000000183D4EB50
		public void SetGravity(bool sw, float sval = -9.8f /* Metadata: 0x01FD0E3E */, float eval = -9.8f /* Metadata: 0x01FD0E42 */) {} // 0x0000000188968808-0x000000018896883C
		public BezierParam GetGravity() => default; // 0x0000000188967E9C-0x0000000188967F00
		public void SetDrag(bool sw, float sval = 0.015f /* Metadata: 0x01FD0E46 */, float eval = 0.015f /* Metadata: 0x01FD0E4A */) {} // 0x00000001889687D4-0x0000000188968808
		public BezierParam GetDrag() => default; // 0x0000000188967E38-0x0000000188967E9C
		public void SetMaxVelocity(bool sw, float sval = 3f /* Metadata: 0x01FD0E4E */, float eval = 3f /* Metadata: 0x01FD0E52 */) {} // 0x0000000188968878-0x00000001889688AC
		public BezierParam GetMaxVelocity() => default; // 0x0000000188967F00-0x0000000188967F68
		public void SetExternalForce(float massInfluence, float windInfluence, float windRandomScale, float windSynchronization) {} // 0x0000000183D6DE20-0x0000000183D6DE50
		public BezierParam GetDepthInfluence() => default; // 0x0000000183D4EA60-0x0000000183D4EA70
		public void SetWorldInfluence(float maxspeed, float moveval, float rotval) {} // 0x0000000188968AB0-0x0000000188968B00
		public BezierParam GetWorldMoveInfluence() => default; // 0x0000000183D4EB30-0x0000000183D4EB40
		public BezierParam GetWorldRotationInfluence() => default; // 0x0000000183D4EB20-0x0000000183D4EB30
		public Transform GetInfluenceTarget() => default; // 0x0000000183D4EB00-0x0000000183D4EB10
		public void SetInfluenceTarget(Transform t) {} // 0x00000001839274B0-0x00000001839274C0
		public void SetTeleport(bool sw, float distance = 0.2f /* Metadata: 0x01FD0E56 */, float rotation = 45f /* Metadata: 0x01FD0E5A */, TeleportMode mode = TeleportMode.Reset /* Metadata: 0x01FD0E5E */) {} // 0x0000000183D6DEA0-0x0000000183D6DED0
		public void SetDistanceDisable(bool sw, float distance = 20f /* Metadata: 0x01FD0E5F */, float fadeDistance = 5f /* Metadata: 0x01FD0E63 */, Transform referenceObject = null) {} // 0x0000000188968798-0x00000001889687D4
		public void SetClampDistanceRatio(bool sw, float minval = 0.1f /* Metadata: 0x01FD0E67 */, float maxval = 1.05f /* Metadata: 0x01FD0E6B */, float influence = 0.2f /* Metadata: 0x01FD0E6F */) {} // 0x0000000183D6DDD0-0x0000000183D6DE00
		public void SetClampPositionLength(bool sw, float sval = 0.03f /* Metadata: 0x01FD0E73 */, float eval = 0.2f /* Metadata: 0x01FD0E77 */, float ratioX = 1f /* Metadata: 0x01FD0E7B */, float ratioY = 1f /* Metadata: 0x01FD0E7F */, float ratioZ = 1f /* Metadata: 0x01FD0E83 */, float influence = 0.2f /* Metadata: 0x01FD0E87 */) {} // 0x00000001889686C0-0x0000000188968730
		public BezierParam GetClampPositionLength() => default; // 0x0000000183D4E7B0-0x0000000183D4E7C0
		public void SetClampRotationAngle(bool sw, float sval = 0f /* Metadata: 0x01FD0E8B */, float eval = 180f /* Metadata: 0x01FD0E8F */, float influence = 0.2f /* Metadata: 0x01FD0E93 */) {} // 0x0000000188968730-0x0000000188968798
		public BezierParam GetClampRotationAngle(Algorithm algo) => default; // 0x0000000188967DFC-0x0000000188967E14
		public float GetClampRotationVelocityLimit(Algorithm algo) => default; // 0x0000000188967E14-0x0000000188967E38
		public void SetRestoreDistance(float influence = 1f /* Metadata: 0x01FD0E97 */, float structStiffness = 1f /* Metadata: 0x01FD0E9B */) {} // 0x00000001889688E0-0x000000018896891C
		public BezierParam GetStructDistanceStiffness() => default; // 0x0000000183D571F0-0x0000000183D57200
		public BezierParam GetBendDistanceStiffness() => default; // 0x0000000183D56F00-0x0000000183D56F10
		public BezierParam GetNearDistanceLength() => default; // 0x0000000183D57300-0x0000000183D57310
		public BezierParam GetNearDistanceStiffness() => default; // 0x0000000183D571B0-0x0000000183D571C0
		public void SetRestoreRotation(bool sw, float sval = 0.02f /* Metadata: 0x01FD0E9F */, float eval = 0.001f /* Metadata: 0x01FD0EA3 */, float influence = 0.3f /* Metadata: 0x01FD0EA7 */) {} // 0x000000018896891C-0x000000018896898C
		public BezierParam GetRestoreRotationPower(Algorithm algo) => default; // 0x00000001889685B0-0x00000001889685C8
		public float GetRestoreRotationVelocityInfluence(Algorithm algo) => default; // 0x00000001889685C8-0x00000001889685E0
		public void SetSpring(bool sw, float power = 0f /* Metadata: 0x01FD0EAB */, float r = 0f /* Metadata: 0x01FD0EAF */, float sclx = 1f /* Metadata: 0x01FD0EB3 */, float scly = 1f /* Metadata: 0x01FD0EB7 */, float sclz = 1f /* Metadata: 0x01FD0EBB */, float intensity = 1f /* Metadata: 0x01FD0EBF */) {} // 0x0000000183D6DE50-0x0000000183D6DEA0
		public void SetSpringDirectionAtten(float sval, float eval, float cval) {} // 0x000000018896898C-0x00000001889689C0
		public void SetSpringDistanceAtten(float sval, float eval, float cval) {} // 0x00000001889689C0-0x00000001889689F4
		public float GetSpringPower() => default; // 0x0000000188968628-0x0000000188968640
		public float GetSpringDirectionAtten(float ratio) => default; // 0x00000001889685E0-0x0000000188968604
		public float GetSpringDistanceAtten(float ratio) => default; // 0x0000000188968604-0x0000000188968628
		public void SetAdjustRotation(AdjustMode amode = AdjustMode.Fixed /* Metadata: 0x01FD0EC3 */, float power = 0f /* Metadata: 0x01FD0EC4 */) {} // 0x0000000183D6DDC0-0x0000000183D6DDD0
		public void SetTriangleBend(bool sw, float sval = 1f /* Metadata: 0x01FD0EC8 */, float eval = 1f /* Metadata: 0x01FD0ECC */) {} // 0x00000001889689F4-0x0000000188968A4C
		public BezierParam GetTriangleBendStiffness(Algorithm algo) => default; // 0x0000000188968640-0x0000000188968658
		internal bool GetUseTwistCorrection(Algorithm algo) => default; // 0x0000000188968658-0x0000000188968668
		public void SetVolume(bool sw, float maxLength = 0.05f /* Metadata: 0x01FD0ED0 */, float stiffness = 0.5f /* Metadata: 0x01FD0ED4 */, float shear = 0.5f /* Metadata: 0x01FD0ED8 */) {} // 0x0000000188968A4C-0x0000000188968AB0
		public float GetMaxVolumeLength() => default; // 0x0000000188967F68-0x0000000188967F80
		public BezierParam GetVolumeStretchStiffness() => default; // 0x0000000183D57000-0x0000000183D57010
		public BezierParam GetVolumeShearStiffness() => default; // 0x0000000183D50210-0x0000000183D50220
		public void SetCollision(bool sw, float dynamicFriction = 0.1f /* Metadata: 0x01FD0EDC */, float staticFriction = 0.03f /* Metadata: 0x01FD0EE0 */) {} // 0x0000000183D6DE00-0x0000000183D6DE20
		public PenetrationMode GetPenetrationMode() => default; // 0x0000000183D6D130-0x0000000183D6D140
		public PenetrationAxis GetPenetrationAxis() => default; // 0x0000000183D6DDB0-0x0000000183D6DDC0
		public BezierParam GetPenetrationConnectDistance() => default; // 0x0000000183D56BB0-0x0000000183D56BC0
		public BezierParam GetPenetrationRadius() => default; // 0x0000000183D570C0-0x0000000183D570D0
		public BezierParam GetPenetrationDistance() => default; // 0x0000000183D57190-0x0000000183D571A0
		public void ConvertToLatestAlgorithmParameter() {} // 0x0000000188967D68-0x0000000188967DFC
	}

	public class ClothSetup // TypeDefIndex: 51359
	{
		// Fields
		private int teamBoneIndex; // 0x10
		private float distanceBlendRatio; // 0x14
	
		// Properties
		public float DistanceBlendRatio { get => default; set {} } // 0x0000000183D51930-0x0000000183D51940 0x0000000183D51940-0x0000000183D51950
	
		// Constructors
		public ClothSetup() {} // 0x0000000183D6E000-0x0000000183D6E010
	
		// Methods
		public void ClothInit(PhysicsTeam team, MeshData meshData, ClothData clothData, ClothParams param, Func<int, uint> funcUserFlag) {} // 0x0000000188970600-0x0000000188972600
		public void ClothDispose(PhysicsTeam team) {} // 0x0000000188970464-0x00000001889704F0
		public void ClothActive(PhysicsTeam team, ClothParams param, ClothData clothData) {} // 0x0000000188970314-0x0000000188970464
		public void ClothInactive(PhysicsTeam team) {} // 0x00000001889704F0-0x0000000188970600
		internal void ReplaceBone<T>(PhysicsTeam team, ClothParams param, Dictionary<T, Transform> boneReplaceDict)
			where T : class {}
		internal HashSet<Transform> GetUsedBones(PhysicsTeam team, ClothParams param) => default; // 0x0000000188972600-0x0000000188972690
		public void ChangeUseUnityPhysics(bool sw) {} // 0x00000001889702A8-0x0000000188970314
		public void ChangeData(PhysicsTeam team, ClothParams param, ClothData clothData) {} // 0x000000018896F690-0x00000001889702A8
	}

	[AddComponentMenu("MagicaCloth/MagicaBoneCloth")]
	[HelpURL("https://magicasoft.jp/magica-cloth-bone-cloth/")]
	public class MagicaBoneCloth : BaseCloth // TypeDefIndex: 51360
	{
		// Fields
		private const int DATA_VERSION = 7; // Metadata: 0x01FD0F0C
		private const int ERR_DATA_VERSION = 3; // Metadata: 0x01FD0F0D
		[SerializeField]
		private MeshData meshData; // 0xC8
		[SerializeField]
		private int meshDataHash; // 0xD0
		[SerializeField]
		private int meshDataVersion; // 0xD4
		[SerializeField]
		private BoneClothTarget clothTarget; // 0xD8
		[SerializeField]
		private List<Transform> useTransformList; // 0xE0
		[SerializeField]
		private List<Vector3> useTransformPositionList; // 0xE8
		[SerializeField]
		private List<Quaternion> useTransformRotationList; // 0xF0
		[SerializeField]
		private List<Vector3> useTransformScaleList; // 0xF8
	
		// Properties
		public BoneClothTarget ClothTarget { get => default; } // 0x0000000183D4E7B0-0x0000000183D4E7C0 
		public MeshData MeshData { get => default; } // 0x0000000183D4E7C0-0x0000000183D4E7D0 
		private int UseTransformCount { get => default; } // 0x0000000188975560-0x00000001889755A0 
	
		// Constructors
		public MagicaBoneCloth() {} // 0x00000001889753C0-0x0000000188975560
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000183D5A950-0x0000000183D5A960
		public override int GetDataHash() => default; // 0x0000000188972F38-0x0000000188973054
		protected override void Reset() {} // 0x0000000188974F50-0x0000000188974F58
		protected override void OnValidate() {} // 0x0000000188974BE4-0x0000000188974BEC
		protected override void ClothInit() {} // 0x0000000188972D7C-0x0000000188972DB0
		protected override void ClothDispose() {} // 0x0000000188972D58-0x0000000188972D7C
		protected override void ClothActive() {} // 0x0000000188972D50-0x0000000188972D58
		protected override uint UserFlag(int index) => default; // 0x0000000188974F58-0x0000000188974F8C
		protected override Transform UserTransform(int index) => default; // 0x000000018897511C-0x0000000188975124
		protected override float3 UserTransformLocalPosition(int vindex) => default; // 0x0000000188974F8C-0x000000018897505C
		protected override quaternion UserTransformLocalRotation(int vindex) => default; // 0x000000018897505C-0x000000018897511C
		public override BaseMeshDeformer GetDeformer() => default; // 0x0000000181002730-0x0000000181002740
		protected override MeshData GetMeshData() => default; // 0x0000000183D4E7C0-0x0000000183D4E7D0
		protected override void WorkerInit() {} // 0x000000018350B670-0x000000018350B680
		public override bool IsRequiresDeformer() => default; // 0x000000018115F4C0-0x000000018115F530
		protected override void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer) {} // 0x000000018350B670-0x000000018350B680
		protected override void ChangeUseUnityPhysics(bool sw) {} // 0x0000000188972D08-0x0000000188972D50
		protected override void OnChangeCalculation() {} // 0x0000000188974ADC-0x0000000188974BE4
		public List<Transform> GetTransformList() => default; // 0x00000001889746CC-0x00000001889749CC
		private Transform GetUseTransform(int index) => default; // 0x00000001889749CC-0x0000000188974A50
		public List<List<List<Transform>>> GetTransformGrid(out int maxLevel) {
			maxLevel = default;
			return default;
		} // 0x0000000188974328-0x00000001889746CC
		public override int GetVersion() => default; // 0x0000000183D55AA0-0x0000000183D55AB0
		public override int GetErrorVersion() => default; // 0x0000000183D555E0-0x0000000183D555F0
		public override void CreateVerifyData() {} // 0x0000000188972DB0-0x0000000188972DF8
		public override Define.Error VerifyData() => default; // 0x0000000188975124-0x00000001889753C0
		public override string GetInformation() => default; // 0x00000001889735A4-0x0000000188974284
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict) {}
		public override HashSet<Transform> GetUsedBones() => default; // 0x0000000188974A50-0x0000000188974ADC
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x0000000188973134-0x00000001889734C4
		public override List<int> GetEditorTriangleList() => default; // 0x00000001889734C4-0x00000001889735A4
		public override List<int> GetEditorLineList() => default; // 0x0000000188973054-0x0000000188973134
		public override List<int> GetSelectionList() => default; // 0x0000000188974284-0x0000000188974328
		public override List<int> GetUseList() => default; // 0x0000000181002730-0x0000000181002740
		public override List<ShareDataObject> GetAllShareDataObject() => default; // 0x0000000188972ED0-0x0000000188972F38
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source) => default; // 0x0000000188972DF8-0x0000000188972ED0
		private void ResetParams() {} // 0x0000000188974BEC-0x0000000188974F50
	}

	[AddComponentMenu("MagicaCloth/MagicaBoneSpring")]
	[HelpURL("https://magicasoft.jp/magica-cloth-bone-spring/")]
	public class MagicaBoneSpring : BaseCloth // TypeDefIndex: 51361
	{
		// Fields
		private const int DATA_VERSION = 7; // Metadata: 0x01FD0F0E
		private const int ERR_DATA_VERSION = 3; // Metadata: 0x01FD0F0F
		[SerializeField]
		private MeshData meshData; // 0xC8
		[SerializeField]
		private int meshDataHash; // 0xD0
		[SerializeField]
		private int meshDataVersion; // 0xD4
		[SerializeField]
		private BoneClothTarget clothTarget; // 0xD8
		[SerializeField]
		private List<Transform> useTransformList; // 0xE0
		[SerializeField]
		private List<Vector3> useTransformPositionList; // 0xE8
		[SerializeField]
		private List<Quaternion> useTransformRotationList; // 0xF0
		[SerializeField]
		private List<Vector3> useTransformScaleList; // 0xF8
	
		// Properties
		public BoneClothTarget ClothTarget { get => default; } // 0x0000000183D4E7B0-0x0000000183D4E7C0 
		public MeshData MeshData { get => default; } // 0x0000000183D4E7C0-0x0000000183D4E7D0 
		private int UseTransformCount { get => default; } // 0x0000000188977394-0x00000001889773D4 
	
		// Constructors
		public MagicaBoneSpring() {} // 0x00000001889771F4-0x0000000188977394
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000183D5A5F0-0x0000000183D5A600
		public override int GetDataHash() => default; // 0x0000000188975768-0x0000000188975884
		protected override void Reset() {} // 0x0000000188976D34-0x0000000188976D3C
		protected override void OnValidate() {} // 0x0000000188974BE4-0x0000000188974BEC
		protected override void ClothInit() {} // 0x00000001889755A0-0x0000000188975628
		protected override void ClothDispose() {} // 0x0000000188972D58-0x0000000188972D7C
		protected override void ClothActive() {} // 0x0000000188972D50-0x0000000188972D58
		protected override uint UserFlag(int index) => default; // 0x0000000188974F58-0x0000000188974F8C
		protected override Transform UserTransform(int index) => default; // 0x0000000188976ECC-0x0000000188976ED4
		protected override float3 UserTransformLocalPosition(int vindex) => default; // 0x0000000188976D3C-0x0000000188976E0C
		protected override quaternion UserTransformLocalRotation(int vindex) => default; // 0x0000000188976E0C-0x0000000188976ECC
		public override bool IsRequiresDeformer() => default; // 0x000000018115F4C0-0x000000018115F530
		public override BaseMeshDeformer GetDeformer() => default; // 0x0000000181002730-0x0000000181002740
		protected override MeshData GetMeshData() => default; // 0x0000000183D4E7C0-0x0000000183D4E7D0
		protected override void WorkerInit() {} // 0x000000018350B670-0x000000018350B680
		protected override void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer) {} // 0x000000018350B670-0x000000018350B680
		protected override void ChangeUseUnityPhysics(bool sw) {} // 0x0000000188972D08-0x0000000188972D50
		protected override void OnChangeCalculation() {} // 0x00000001889768C0-0x00000001889769C8
		public List<Transform> GetTransformList() => default; // 0x00000001889764B8-0x00000001889765C8
		private Transform GetUseTransform(int index) => default; // 0x00000001889767B0-0x0000000188976834
		public override int GetVersion() => default; // 0x0000000183D55AA0-0x0000000183D55AB0
		public override int GetErrorVersion() => default; // 0x0000000183D555E0-0x0000000183D555F0
		public override void CreateVerifyData() {} // 0x0000000188972DB0-0x0000000188972DF8
		public override Define.Error VerifyData() => default; // 0x0000000188976ED4-0x00000001889771F4
		public override string GetInformation() => default; // 0x0000000188975DD4-0x0000000188976414
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict) {}
		public override HashSet<Transform> GetUsedBones() => default; // 0x0000000188976834-0x00000001889768C0
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x0000000188975964-0x0000000188975CF4
		public override List<int> GetEditorTriangleList() => default; // 0x0000000188975CF4-0x0000000188975DD4
		public override List<int> GetEditorLineList() => default; // 0x0000000188975884-0x0000000188975964
		public override List<int> GetSelectionList() => default; // 0x0000000188976414-0x00000001889764B8
		public override List<int> GetUseList() => default; // 0x00000001889765C8-0x00000001889767B0
		public override List<ShareDataObject> GetAllShareDataObject() => default; // 0x0000000188975700-0x0000000188975768
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source) => default; // 0x0000000188975628-0x0000000188975700
		private void ResetParams() {} // 0x00000001889769C8-0x0000000188976D34
	}

	[AddComponentMenu("MagicaCloth/MagicaMeshCloth", 100)]
	[HelpURL("https://magicasoft.jp/magica-cloth-mesh-cloth/")]
	public class MagicaMeshCloth : BaseCloth // TypeDefIndex: 51362
	{
		// Fields
		private const int DATA_VERSION = 7; // Metadata: 0x01FD0F10
		private const int ERR_DATA_VERSION = 3; // Metadata: 0x01FD0F11
		[SerializeField]
		private MagicaVirtualDeformer virtualDeformer; // 0xC8
		[SerializeField]
		private int virtualDeformerHash; // 0xD0
		[SerializeField]
		private int virtualDeformerVersion; // 0xD4
	
		// Properties
		public VirtualMeshDeformer Deformer { get => default; } // 0x0000000188978C2C-0x0000000188978CA4 
	
		// Constructors
		public MagicaMeshCloth() {} // 0x0000000188978C24-0x0000000188978C2C
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000183D5A720-0x0000000183D5A730
		public override int GetDataHash() => default; // 0x00000001889775A0-0x00000001889775E0
		protected override void Reset() {} // 0x00000001889788A8-0x00000001889788B0
		protected override void OnValidate() {} // 0x0000000188974BE4-0x0000000188974BEC
		protected override void OnInit() {} // 0x0000000188978540-0x0000000188978548
		protected override void OnActive() {} // 0x0000000188978528-0x0000000188978530
		protected override void OnInactive() {} // 0x0000000188978538-0x0000000188978540
		protected override void OnDispose() {} // 0x0000000188978530-0x0000000188978538
		protected override uint UserFlag(int index) => default; // 0x0000000181002730-0x0000000181002740
		protected override Transform UserTransform(int index) => default; // 0x0000000181002730-0x0000000181002740
		protected override float3 UserTransformLocalPosition(int vindex) => default; // 0x0000000183D6E010-0x0000000183D6E030
		protected override quaternion UserTransformLocalRotation(int vindex) => default; // 0x000000018897899C-0x00000001889789E0
		public override bool IsRequiresDeformer() => default; // 0x000000018232EB60-0x000000018232EB70
		public override BaseMeshDeformer GetDeformer() => default; // 0x00000001889775E0-0x00000001889775E8
		protected override MeshData GetMeshData() => default; // 0x0000000188978188-0x00000001889781A8
		protected override void WorkerInit() {} // 0x0000000188978ACC-0x0000000188978C24
		protected override void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer) {} // 0x00000001889788B0-0x000000018897899C
		protected override void ChangeUseUnityPhysics(bool sw) {} // 0x00000001889773D4-0x0000000188977410
		public override int GetVersion() => default; // 0x0000000183D55AA0-0x0000000183D55AB0
		public override int GetErrorVersion() => default; // 0x0000000183D555E0-0x0000000183D555F0
		public override void CreateVerifyData() {} // 0x0000000188972DB0-0x0000000188972DF8
		public override Define.Error VerifyData() => default; // 0x00000001889789E0-0x0000000188978ACC
		public override string GetInformation() => default; // 0x0000000188977684-0x0000000188978188
		public bool IsValidPointSelect() => default; // 0x000000018897848C-0x0000000188978528
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x0000000188977610-0x000000018897765C
		public override List<int> GetEditorTriangleList() => default; // 0x000000018897765C-0x0000000188977684
		public override List<int> GetEditorLineList() => default; // 0x00000001889775E8-0x0000000188977610
		public override List<int> GetSelectionList() => default; // 0x00000001889781A8-0x00000001889782BC
		public override List<int> GetUseList() => default; // 0x00000001889782BC-0x000000018897848C
		public override List<ShareDataObject> GetAllShareDataObject() => default; // 0x0000000188977520-0x00000001889775A0
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source) => default; // 0x0000000188977410-0x0000000188977520
		private void ResetParams() {} // 0x0000000188978548-0x00000001889788A8
	}

	[AddComponentMenu("MagicaCloth/MagicaMeshSpring", 100)]
	[HelpURL("https://magicasoft.jp/magica-cloth-mesh-spring/")]
	public class MagicaMeshSpring : BaseCloth // TypeDefIndex: 51364
	{
		// Fields
		private const int DATA_VERSION = 7; // Metadata: 0x01FD0F12
		private const int ERR_DATA_VERSION = 3; // Metadata: 0x01FD0F13
		[SerializeField]
		private MagicaVirtualDeformer virtualDeformer; // 0xC8
		[SerializeField]
		private int virtualDeformerHash; // 0xD0
		[SerializeField]
		private int virtualDeformerVersion; // 0xD4
		[SerializeField]
		private Transform centerTransform; // 0xD8
		[SerializeField]
		private Axis directionAxis; // 0xE0
		[SerializeField]
		private SpringData springData; // 0xE8
		[SerializeField]
		private int springDataHash; // 0xF0
		[SerializeField]
		private int springDataVersion; // 0xF4
	
		// Properties
		public VirtualMeshDeformer Deformer { get => default; } // 0x000000018897A204-0x000000018897A27C 
		public SpringData SpringData { get => default; } // 0x0000000183D50EA0-0x0000000183D50EB0 
		public int UseVertexCount { get => default; } // 0x000000018897A27C-0x000000018897A2F4 
		public Transform CenterTransform { get => default; set {} } // 0x0000000183D4E7B0-0x0000000183D4E7C0 0x0000000185142FC4-0x0000000185142FD8
		public Axis DirectionAxis { get => default; set {} } // 0x0000000183D50ED0-0x0000000183D50EE0 0x0000000183D50FB0-0x0000000183D50FC0
		public Vector3 CenterTransformDirection { get => default; } // 0x000000018897A070-0x000000018897A204 
	
		// Nested types
		public enum Axis // TypeDefIndex: 51363
		{
			X = 0,
			Y = 1,
			Z = 2,
			InverseX = 3,
			InverseY = 4,
			InverseZ = 5
		}
	
		// Constructors
		public MagicaMeshSpring() {} // 0x0000000188978C24-0x0000000188978C2C
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000183D6E030-0x0000000183D6E040
		public override int GetDataHash() => default; // 0x0000000188979030-0x00000001889790B0
		public SpringData.DeformerData GetDeformerData() => default; // 0x00000001889790B0-0x00000001889790D0
		protected override void Reset() {} // 0x0000000188979C24-0x0000000188979C2C
		protected override void OnValidate() {} // 0x0000000188974BE4-0x0000000188974BEC
		protected override void ClothInit() {} // 0x0000000188978CA4-0x0000000188978E80
		protected override void ClothActive() {} // 0x0000000188972D50-0x0000000188972D58
		protected override uint UserFlag(int index) => default; // 0x0000000183D6E040-0x0000000183D6E050
		protected override Transform UserTransform(int index) => default; // 0x0000000183D4E7B0-0x0000000183D4E7C0
		protected override float3 UserTransformLocalPosition(int vindex) => default; // 0x0000000188979CD0-0x0000000188979D34
		protected override quaternion UserTransformLocalRotation(int vindex) => default; // 0x0000000188979D34-0x0000000188979D88
		public override bool IsRequiresDeformer() => default; // 0x000000018232EB60-0x000000018232EB70
		public override BaseMeshDeformer GetDeformer() => default; // 0x00000001889790D0-0x0000000188979144
		protected override MeshData GetMeshData() => default; // 0x0000000181002730-0x0000000181002740
		protected override void WorkerInit() {} // 0x0000000188979EF4-0x000000018897A070
		protected override void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer) {} // 0x0000000188979C2C-0x0000000188979CD0
		protected override void ChangeUseUnityPhysics(bool sw) {} // 0x00000001889773D4-0x0000000188977410
		protected override void OnChangeCalculation() {} // 0x00000001889797D8-0x000000018897986C
		public override int GetVersion() => default; // 0x0000000183D55AA0-0x0000000183D55AB0
		public override int GetErrorVersion() => default; // 0x0000000183D555E0-0x0000000183D555F0
		public override void CreateVerifyData() {} // 0x0000000188978E80-0x0000000188978EF0
		public override Define.Error VerifyData() => default; // 0x0000000188979D88-0x0000000188979EF4
		public override string GetInformation() => default; // 0x0000000188979348-0x0000000188979770
		public void VerifyDeformer() {} // 0x000000018350B670-0x000000018350B680
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict) {}
		public override HashSet<Transform> GetUsedBones() => default; // 0x0000000188979770-0x00000001889797D8
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x0000000188979144-0x0000000188979348
		public override List<int> GetEditorTriangleList() => default; // 0x0000000181002730-0x0000000181002740
		public override List<int> GetEditorLineList() => default; // 0x0000000181002730-0x0000000181002740
		public override List<int> GetSelectionList() => default; // 0x0000000181002730-0x0000000181002740
		public override List<int> GetUseList() => default; // 0x0000000181002730-0x0000000181002740
		public override List<ShareDataObject> GetAllShareDataObject() => default; // 0x0000000188978FC8-0x0000000188979030
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source) => default; // 0x0000000188978EF0-0x0000000188978FC8
		private void ResetParams() {} // 0x000000018897986C-0x0000000188979C24
	}

	[Serializable]
	public class SelectionData : ShareDataObject // TypeDefIndex: 51366
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x01FD0F1A
		public const int Invalid = 0; // Metadata: 0x01FD0F1B
		public const int Move = 1; // Metadata: 0x01FD0F1C
		public const int Fixed = 2; // Metadata: 0x01FD0F1D
		public const int Extend = 3; // Metadata: 0x01FD0F1E
		public List<DeformerSelection> selectionList; // 0x20
	
		// Properties
		public int DeformerCount { get => default; } // 0x0000000188980098-0x00000001889800D8 
	
		// Nested types
		[Serializable]
		public class DeformerSelection : IDataHash // TypeDefIndex: 51365
		{
			// Fields
			public List<int> selectData; // 0x10
			public List<ulong> vertexHashList; // 0x18
	
			// Constructors
			public DeformerSelection() {} // 0x0000000188972C48-0x0000000188972D08
	
			// Methods
			public int GetDataHash() => default; // 0x0000000188972C0C-0x0000000188972C48
			public bool Compare(DeformerSelection data) => default; // 0x0000000188972AB8-0x0000000188972C0C
		}
	
		// Constructors
		public SelectionData() {} // 0x0000000188980018-0x0000000188980098
	
		// Methods
		public override int GetDataHash() => default; // 0x000000018897EFB4-0x000000018897EFF0
		public override int GetVersion() => default; // 0x0000000182102C70-0x0000000182102C80
		public override Define.Error VerifyData() => default; // 0x000000018897FFC0-0x0000000188980018
		public bool Compare(SelectionData sel) => default; // 0x000000018897EED8-0x000000018897EFB4
		public List<int> GetSelectionData(MeshData meshData, List<MeshData> childMeshDataList) => default; // 0x000000018897EFF0-0x000000018897F1A8
		private int GetSelection(MeshData meshData, int vindex, Dictionary<int, List<uint>> dict, List<MeshData> childMeshDataList, List<Dictionary<ulong, int>> hashList) => default; // 0x000000018897F408-0x000000018897F8D4
		public void SetSelectionData(MeshData meshData, List<int> selects, List<MeshData> childMeshDataList) {} // 0x000000018897F8D4-0x000000018897FFC0
		private List<Dictionary<ulong, int>> GetSelectionVertexHashList() => default; // 0x000000018897F1A8-0x000000018897F408
	}

	[Serializable]
	public class SpringData : ShareDataObject // TypeDefIndex: 51368
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x01FD0F1F
		public DeformerData deformerData; // 0x20
		public Vector3 initScale; // 0x28
	
		// Properties
		public int UseVertexCount { get => default; } // 0x0000000188980114-0x0000000188980130 
	
		// Nested types
		[Serializable]
		public class DeformerData : IDataHash // TypeDefIndex: 51367
		{
			// Fields
			public int deformerDataHash; // 0x10
			public int vertexCount; // 0x14
			public int[] useVertexIndexList; // 0x18
			public float[] weightList; // 0x20
	
			// Properties
			public int UseVertexCount { get => default; } // 0x0000000188972AA4-0x0000000188972AB8 
	
			// Constructors
			public DeformerData() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public int GetDataHash() => default; // 0x0000000188972A10-0x0000000188972AA4
		}
	
		// Constructors
		public SpringData() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		public override int GetDataHash() => default; // 0x00000001889800D8-0x00000001889800F8
		public override int GetVersion() => default; // 0x0000000182102C70-0x0000000182102C80
		public override Define.Error VerifyData() => default; // 0x00000001889800F8-0x0000000188980114
	}

	public static class Define // TypeDefIndex: 51373
	{
		// Nested types
		public static class Compute // TypeDefIndex: 51369
		{
			// Fields
			public const float Epsilon = 1E-06f; // Metadata: 0x01FD0F20
			public const float CollisionFrictionRange = 0.03f; // Metadata: 0x01FD0F24
			public const float FrictionDampingRate = 0.6f; // Metadata: 0x01FD0F28
			public const float FrictionMoveRatio = 0.5f; // Metadata: 0x01FD0F2C
			public const float FrictionPower = 4f; // Metadata: 0x01FD0F30
			public const float ClampPositionMaxVelocity = 1f; // Metadata: 0x01FD0F34
			public const float GlobalColliderMaxMoveDistance = 0.2f; // Metadata: 0x01FD0F38
			public const float GlobalColliderMaxRotationAngle = 10f; // Metadata: 0x01FD0F3C
			public const float ColliderExtrusionMaxPower = 0.4f; // Metadata: 0x01FD0F40
			public const float ColliderExtrusionDirectionPower = 0.3f; // Metadata: 0x01FD0F44
			public const float ColliderExtrusionDistPower = 2f; // Metadata: 0x01FD0F48
			public const float ColliderExtrusionVelocityInfluence = 0.25f; // Metadata: 0x01FD0F4C
			public const float MaxWindMain = 100f; // Metadata: 0x01FD0F50
			public const float ClampRotationMaxVelocity = 1f; // Metadata: 0x01FD0F54
			public const float ClampRotationMaxVelocity2 = 2f; // Metadata: 0x01FD0F58
			public const float TriangleBendVelocityInfluence = 0.5f; // Metadata: 0x01FD0F5C
		}
	
		public enum Error // TypeDefIndex: 51370
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
	
		public static class OptimizeMesh // TypeDefIndex: 51371
		{
			// Fields
			public const int Unknown = 0; // Metadata: 0x01FD0FF2
			public const int Nothing = 1; // Metadata: 0x01FD0FF3
			public const int Unity2018_On = 16; // Metadata: 0x01FD0FF4
			public const int Unity2019_PolygonOrder = 256; // Metadata: 0x01FD0FF5
			public const int Unity2019_VertexOrder = 512; // Metadata: 0x01FD0FF7
		}
	
		public static class RenderMesh // TypeDefIndex: 51372
		{
			// Fields
			public const int WorkerMultiplesOfVertexCollection = 3; // Metadata: 0x01FD0FF9
		}
	
		// Methods
		public static bool IsNormal(Error err) => default; // 0x00000001856F529C-0x00000001856F52A4
		public static bool IsError(Error err) => default; // 0x00000001889729F0-0x0000000188972A04
		public static bool IsWarning(Error err) => default; // 0x0000000188972A04-0x0000000188972A10
		public static string GetErrorMessage(Error err) => default; // 0x0000000188972690-0x00000001889729F0
	}

	[Serializable]
	public abstract class BaseMeshDeformer : IEditorMesh, IDataVerify, IDataHash // TypeDefIndex: 51374
	{
		// Fields
		[SerializeField]
		private MeshData meshData; // 0x10
		[SerializeField]
		private GameObject targetObject; // 0x18
		[SerializeField]
		protected int dataHash; // 0x20
		[SerializeField]
		protected int dataVersion; // 0x24
		protected RuntimeStatus status; // 0x28
		private CoreComponent parent; // 0x30
	
		// Properties
		public CoreComponent Parent { get; set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public virtual MeshData MeshData { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public GameObject TargetObject { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public RuntimeStatus Status { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public int MeshIndex { get; protected set; } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000183D4ECB0-0x0000000183D4ECC0
		public int VertexCount { get; protected set; } // 0x0000000183D4ED90-0x0000000183D4EDA0 0x0000000183D4EDC0-0x0000000183D4EDD0
		public int SkinningVertexCount { get; protected set; } // 0x0000000183D4ED80-0x0000000183D4ED90 0x0000000183D4EDB0-0x0000000183D4EDC0
		public int TriangleCount { get; protected set; } // 0x0000000183D4EE80-0x0000000183D4EE90 0x0000000183D4EEA0-0x0000000183D4EEB0
		public bool IsSkinning { get; } // 0x000000018896F5C8-0x000000018896F634 
		public int BoneCount { get; } // 0x000000018896F550-0x000000018896F5C8 
		public int SaveDataHash { get; } // 0x0000000181003B50-0x0000000181003B60 
		public int SaveDataVersion { get; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
	
		// Constructors
		protected BaseMeshDeformer() {} // 0x000000018896F4E4-0x000000018896F550
	
		// Methods
		public virtual void Init() {} // 0x000000018896F19C-0x000000018896F2F0
		protected virtual void OnInit() {} // 0x000000018896F348-0x000000018896F3AC
		public virtual void Dispose() {} // 0x000000018896F03C-0x000000018896F0C4
		public virtual void OnEnable() {} // 0x000000018896F31C-0x000000018896F348
		public virtual void OnDisable() {} // 0x000000018896F2F0-0x000000018896F31C
		public virtual void Update() {} // 0x000000018896F3E8-0x000000018896F42C
		internal abstract void MeshCalculation(int bufferIndex);
		internal abstract void NormalWriting(int bufferIndex);
		protected void OnUpdateStatus() {} // 0x000000018896F3AC-0x000000018896F3E8
		protected virtual void OnActive() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnInactive() {} // 0x000000018350B670-0x000000018350B680
		public virtual bool IsMeshUse() => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool IsActiveMesh() => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual void AddUseMesh(object parent) {} // 0x000000018350B670-0x000000018350B680
		public virtual void RemoveUseMesh(object parent) {} // 0x000000018350B670-0x000000018350B680
		public virtual bool AddUseVertex(int vindex, bool fix) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool RemoveUseVertex(int vindex, bool fix) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual void ResetFuturePrediction() {} // 0x000000018350B670-0x000000018350B680
		public virtual void ChangeUseUnityPhysics(bool sw) {} // 0x000000018350B670-0x000000018350B680
		public virtual int GetDataHash() => default; // 0x000000018896F0C4-0x000000018896F170
		public abstract int GetVersion();
		public virtual Define.Error VerifyData() => default; // 0x000000018896F42C-0x000000018896F4E4
		public virtual void CreateVerifyData() {} // 0x000000018896F00C-0x000000018896F03C
		public virtual string GetInformation() => default; // 0x000000018896F170-0x000000018896F19C
		public abstract int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList);
		public abstract List<int> GetEditorTriangleList();
		public abstract List<int> GetEditorLineList();
	}

	[AddComponentMenu("MagicaCloth/MagicaRenderDeformer")]
	[HelpURL("https://magicasoft.jp/magica-cloth-render-deformer/")]
	public class MagicaRenderDeformer : CoreComponent // TypeDefIndex: 51375
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x01FD0FFA
		private const int ERR_DATA_VERSION = 0; // Metadata: 0x01FD0FFB
		[SerializeField]
		private RenderMeshDeformer deformer; // 0x38
		[SerializeField]
		private int deformerHash; // 0x40
		[SerializeField]
		private int deformerVersion; // 0x44
	
		// Properties
		internal PhysicsTeam.TeamCullingMode cullModeCash { get; private set; } // 0x0000000183D4EC50-0x0000000183D4EC60 0x0000000183D4ECD0-0x0000000183D4ECE0
		public RenderMeshDeformer Deformer { get => default; } // 0x000000018897ACE4-0x000000018897AD10 
	
		// Constructors
		public MagicaRenderDeformer() {} // 0x000000018897AC70-0x000000018897ACE4
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000183D5AB50-0x0000000183D5AB60
		public override int GetDataHash() => default; // 0x000000018897A4C4-0x000000018897A4EC
		private void OnValidate() {} // 0x000000018897A844-0x000000018897A868
		protected override void OnInit() {} // 0x000000018897A7FC-0x000000018897A820
		protected override void OnDispose() {} // 0x000000018897A7B0-0x000000018897A7D8
		protected override void OnUpdate() {} // 0x000000018897A820-0x000000018897A844
		protected override void OnActive() {} // 0x000000018897A670-0x000000018897A694
		protected override void OnInactive() {} // 0x000000018897A7D8-0x000000018897A7FC
		protected void OnBecameVisible() {} // 0x000000018897A6DC-0x000000018897A724
		protected void OnBecameInvisible() {} // 0x000000018897A694-0x000000018897A6DC
		internal override void UpdateCullingMode(CoreComponent caller) {} // 0x000000018897A868-0x000000018897ABD4
		protected override void OnChangeCalculation() {} // 0x000000018897A724-0x000000018897A7B0
		public override int GetVersion() => default; // 0x0000000182102C70-0x0000000182102C80
		public override int GetErrorVersion() => default; // 0x0000000181002730-0x0000000181002740
		public override void CreateVerifyData() {} // 0x000000018897A328-0x000000018897A370
		public override Define.Error VerifyData() => default; // 0x000000018897ABD4-0x000000018897AC70
		public override string GetInformation() => default; // 0x000000018897A588-0x000000018897A5D0
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict) {}
		public override HashSet<Transform> GetUsedBones() => default; // 0x000000018897A5F4-0x000000018897A670
		protected override void ChangeUseUnityPhysics(bool sw) {} // 0x000000018897A2F4-0x000000018897A328
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x000000018897A514-0x000000018897A560
		public override List<int> GetEditorTriangleList() => default; // 0x000000018897A560-0x000000018897A588
		public override List<int> GetEditorLineList() => default; // 0x000000018897A4EC-0x000000018897A514
		public override List<int> GetUseList() => default; // 0x000000018897A5D0-0x000000018897A5F4
		public override List<ShareDataObject> GetAllShareDataObject() => default; // 0x000000018897A450-0x000000018897A4C4
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source) => default; // 0x000000018897A370-0x000000018897A450
	}

	[AddComponentMenu("MagicaCloth/MagicaVirtualDeformer")]
	[HelpURL("https://magicasoft.jp/magica-cloth-virtual-deformer/")]
	public class MagicaVirtualDeformer : CoreComponent // TypeDefIndex: 51376
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x01FD0FFC
		private const int ERR_DATA_VERSION = 0; // Metadata: 0x01FD0FFD
		[SerializeField]
		private VirtualMeshDeformer deformer; // 0x38
		[SerializeField]
		private int deformerHash; // 0x40
		[SerializeField]
		private int deformerVersion; // 0x44
	
		// Properties
		internal PhysicsTeam.TeamCullingMode cullModeCash { get; private set; } // 0x0000000183D4EC50-0x0000000183D4EC60 0x0000000183D4ECD0-0x0000000183D4ECE0
		public VirtualMeshDeformer Deformer { get => default; } // 0x000000018897ACE4-0x000000018897AD10 
	
		// Constructors
		public MagicaVirtualDeformer() {} // 0x000000018897B6FC-0x000000018897B770
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000183D6E050-0x0000000183D6E060
		public override int GetDataHash() => default; // 0x000000018897A4C4-0x000000018897A4EC
		private void OnValidate() {} // 0x000000018350B670-0x000000018350B680
		protected override void OnInit() {} // 0x000000018897B274-0x000000018897B2AC
		protected override void OnDispose() {} // 0x000000018897B238-0x000000018897B274
		protected override void OnUpdate() {} // 0x000000018897A820-0x000000018897A844
		protected override void OnActive() {} // 0x000000018897A670-0x000000018897A694
		protected override void OnInactive() {} // 0x000000018897A7D8-0x000000018897A7FC
		private void LinkRenderDeformerStatus(bool sw) {} // 0x000000018897B108-0x000000018897B204
		protected override void ChangeUseUnityPhysics(bool sw) {} // 0x000000018897AD10-0x000000018897ADAC
		internal override void UpdateCullingMode(CoreComponent caller) {} // 0x000000018897B2AC-0x000000018897B690
		protected override void OnChangeCalculation() {} // 0x000000018897B204-0x000000018897B238
		public override int GetVersion() => default; // 0x0000000182102C70-0x0000000182102C80
		public override int GetErrorVersion() => default; // 0x0000000181002730-0x0000000181002740
		public override void CreateVerifyData() {} // 0x000000018897A328-0x000000018897A370
		public override Define.Error VerifyData() => default; // 0x000000018897B690-0x000000018897B6FC
		public override string GetInformation() => default; // 0x000000018897A588-0x000000018897A5D0
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict) {}
		public override HashSet<Transform> GetUsedBones() => default; // 0x000000018897B08C-0x000000018897B108
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x000000018897A514-0x000000018897A560
		public override List<int> GetEditorTriangleList() => default; // 0x000000018897A560-0x000000018897A588
		public override List<int> GetEditorLineList() => default; // 0x000000018897A4EC-0x000000018897A514
		public override List<int> GetUseList() => default; // 0x000000018897AF00-0x000000018897B08C
		public override List<ShareDataObject> GetAllShareDataObject() => default; // 0x000000018897AE8C-0x000000018897AF00
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source) => default; // 0x000000018897ADAC-0x000000018897AE8C
	}

	[Serializable]
	public class MeshData : ShareDataObject // TypeDefIndex: 51379
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x01FD0FFE
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
		public int VertexCount { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public int VertexHashCount { get => default; } // 0x000000018897C334-0x000000018897C348 
		public int WeightCount { get => default; } // 0x000000018897C348-0x000000018897C35C 
		public int LineCount { get => default; } // 0x0000000183D4EC50-0x0000000183D4EC60 
		public int TriangleCount { get => default; } // 0x0000000183D4EF00-0x0000000183D4EF10 
		public int BoneCount { get => default; } // 0x0000000183D4EEE0-0x0000000183D4EEF0 
		public int ChildCount { get => default; } // 0x000000018897C2F4-0x000000018897C334 
	
		// Nested types
		[Serializable]
		public struct VertexWeight // TypeDefIndex: 51377
		{
			// Fields
			public Vector3 localPos; // 0x00
			public Vector3 localNor; // 0x0C
			public Vector3 localTan; // 0x18
			public int parentIndex; // 0x24
			public float weight; // 0x28
		}
	
		[Serializable]
		public class ChildData : IDataHash // TypeDefIndex: 51378
		{
			// Fields
			public int childDataHash; // 0x10
			public int vertexCount; // 0x14
			public uint[] vertexInfoList; // 0x18
			public VertexWeight[] vertexWeightList; // 0x20
			public int[] parentIndexList; // 0x28
	
			// Properties
			public int VertexCount { get => default; } // 0x0000000183D50CC0-0x0000000183D50CD0 
	
			// Constructors
			public ChildData() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public int GetDataHash() => default; // 0x000000018896F634-0x000000018896F690
		}
	
		// Constructors
		public MeshData() {} // 0x000000018897C26C-0x000000018897C2F4
	
		// Methods
		public override int GetDataHash() => default; // 0x000000018897BE8C-0x000000018897C090
		public override int GetVersion() => default; // 0x0000000182102C70-0x0000000182102C80
		public override Define.Error VerifyData() => default; // 0x000000018897C250-0x000000018897C26C
		public Dictionary<int, List<uint>> GetVirtualToChildVertexDict() => default; // 0x000000018897C090-0x000000018897C250
		public List<int> ExtendSelection(List<int> originalSelection, bool extendNext, bool extendWeight) => default; // 0x000000018897B770-0x000000018897BE8C
	}

	[Serializable]
	public class RenderMeshDeformer : BaseMeshDeformer, IBoneReplace // TypeDefIndex: 51382
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x01FD0FFF
		[SerializeField]
		private RecalculateMode normalAndTangentUpdateMode; // 0x48
		[SerializeField]
		private BoundsMode boundsUpdateMode; // 0x4C
		[SerializeField]
		private Mesh sharedMesh; // 0x50
		[SerializeField]
		private int meshOptimize; // 0x58
		private Renderer renderer; // 0x60
		private MeshFilter meshFilter; // 0x68
		private SkinnedMeshRenderer skinMeshRenderer; // 0x70
		private Transform[] originalBones; // 0x78
		private Transform[] boneList; // 0x80
		private Mesh cloneMesh; // 0x88
		private GraphicsBuffer vertexBuffer; // 0x90
		private bool oldUse; // 0x9B
		private bool IsWriteMeshNormal; // 0xA0
		private bool IsWriteMeshTangent; // 0xA1
	
		// Properties
		private bool IsChangePosition { get; set; } // 0x0000000183D58690-0x0000000183D586A0 0x0000000183D5CE20-0x0000000183D5CE30
		private bool IsChangeNormalTangent { get; set; } // 0x0000000183D6E080-0x0000000183D6E090 0x0000000183D6E0D0-0x0000000183D6E0E0
		private bool IsChangeBoneWeights { get; set; } // 0x0000000183D6E070-0x0000000183D6E080 0x0000000183D6E0C0-0x0000000183D6E0D0
		internal bool IsWriteSkip { get; set; } // 0x0000000183D5E1C0-0x0000000183D5E1D0 0x0000000183D5E200-0x0000000183D5E210
		internal bool IsFasterWriteUpdate { get; private set; } // 0x0000000183D6E090-0x0000000183D6E0A0 0x0000000183D6E0E0-0x0000000183D6E0F0
		internal bool IsWriteMeshPosition { get; private set; } // 0x0000000183D6E0B0-0x0000000183D6E0C0 0x0000000183D6E100-0x0000000183D6E110
		internal bool IsWriteMeshBoneWeight { get; private set; } // 0x0000000183D6E0A0-0x0000000183D6E0B0 0x0000000183D6E0F0-0x0000000183D6E100
		public Mesh SharedMesh { get => default; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		internal bool IsFasterWrite { get; private set; } // 0x0000000183D5B390-0x0000000183D5B3A0 0x0000000183D5B3C0-0x0000000183D5B3D0
		public bool IsRendererVisible { get => default; } // 0x000000018897EE6C-0x000000018897EED8 
		internal bool HasNormal { get => default; } // 0x000000018897EE58-0x000000018897EE6C 
	
		// Nested types
		public enum RecalculateMode // TypeDefIndex: 51380
		{
			None = 0,
			UpdateNormalPerFrame = 1,
			UpdateNormalAndTangentPerFrame = 2
		}
	
		public enum BoundsMode // TypeDefIndex: 51381
		{
			None = 0,
			ExpandedAtInitialization = 1
		}
	
		// Constructors
		public RenderMeshDeformer() {} // 0x000000018897EE48-0x000000018897EE58
	
		// Methods
		public override int GetDataHash() => default; // 0x000000018897C9A0-0x000000018897CA24
		public void OnValidate() {} // 0x000000018897E8FC-0x000000018897E93C
		protected override void OnInit() {} // 0x000000018897DFFC-0x000000018897E8FC
		protected override void OnActive() {} // 0x000000018897DDF8-0x000000018897DF08
		protected override void OnInactive() {} // 0x000000018897DF08-0x000000018897DFFC
		public override void Dispose() {} // 0x000000018897C760-0x000000018897C854
		private void SetRecalculateNormalAndTangentMode() {} // 0x000000018897EC2C-0x000000018897ED04
		public override void ChangeUseUnityPhysics(bool sw) {} // 0x000000018897C6DC-0x000000018897C760
		public void ChangeCalculation(bool sw) {} // 0x000000018897C64C-0x000000018897C6DC
		public override bool IsMeshUse() => default; // 0x000000018897D814-0x000000018897D88C
		public override bool IsActiveMesh() => default; // 0x000000018897D79C-0x000000018897D814
		public override void AddUseMesh(object parent) {} // 0x000000018897C35C-0x000000018897C64C
		public override void RemoveUseMesh(object parent) {} // 0x000000018897E93C-0x000000018897EC2C
		internal override void MeshCalculation(int bufferIndex) {} // 0x000000018897D88C-0x000000018897DC80
		internal override void NormalWriting(int bufferIndex) {} // 0x000000018897DC80-0x000000018897DDF8
		internal bool FasterWriting(int bufferIndex, ComputeShader compute, int kernel, int index, ref int maxVertexCount) => default; // 0x000000018897C854-0x000000018897C9A0
		public void ChangeNormalTangentUpdateMode() {} // 0x0000000183D6E060-0x0000000183D6E070
		public void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class {}
		public HashSet<Transform> GetUsedBones() => default; // 0x000000018897D698-0x000000018897D79C
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x000000018897CA24-0x000000018897CDB4
		public override List<int> GetEditorTriangleList() => default; // 0x000000018897CDB4-0x000000018897CE64
		public override List<int> GetEditorLineList() => default; // 0x0000000181002730-0x0000000181002740
		public List<int> GetEditorUseList() => default; // 0x000000018897CE64-0x000000018897CEE8
		public override int GetVersion() => default; // 0x0000000182102C70-0x0000000182102C80
		public override Define.Error VerifyData() => default; // 0x000000018897ED04-0x000000018897EE48
		private Mesh GetTargetSharedMesh() => default; // 0x000000018897D560-0x000000018897D698
		public override string GetInformation() => default; // 0x000000018897CEE8-0x000000018897D560
	}

	[Serializable]
	public class VirtualMeshDeformer : BaseMeshDeformer, IBoneReplace // TypeDefIndex: 51384
	{
		// Fields
		private const int DATA_VERSION = 1; // Metadata: 0x01FD1005
		[SerializeField]
		private List<MagicaRenderDeformer> renderDeformerList; // 0x48
		[SerializeField]
		private List<int> renderDeformerHashList; // 0x50
		[SerializeField]
		private int renderDeformerVersion; // 0x58
		[Range(0f, 0.3f)]
		[SerializeField]
		private float mergeVertexDistance; // 0x5C
		[Range(0f, 0.3f)]
		[SerializeField]
		private float mergeTriangleDistance; // 0x60
		[Range(10f, 90f)]
		[SerializeField]
		private float sameSurfaceAngle; // 0x64
		[SerializeField]
		private bool useSkinning; // 0x68
		[Range(1f, 4f)]
		[SerializeField]
		private int maxWeightCount; // 0x6C
		[Range(1f, 5f)]
		[SerializeField]
		private float weightPow; // 0x70
		[SerializeField]
		private List<Transform> boneList; // 0x78
		private List<int> sharedChildMeshIndexList; // 0x80
	
		// Properties
		public float MergeVertexDistance { get => default; } // 0x0000000183D56C10-0x0000000183D56C20 
		public float MergeTriangleDistance { get => default; } // 0x0000000183D50D50-0x0000000183D50D60 
		public float SameSurfaceAngle { get => default; } // 0x0000000183D50D60-0x0000000183D50D70 
		public int MaxWeightCount { get => default; } // 0x000000018898260C-0x0000000188982638 
		public float WeightPow { get => default; } // 0x0000000183D56C00-0x0000000183D56C10 
		public int RenderDeformerCount { get => default; } // 0x0000000188982638-0x0000000188982678 
	
		// Constructors
		public VirtualMeshDeformer() {} // 0x000000018898249C-0x000000018898260C
	
		// Methods
		public override int GetDataHash() => default; // 0x0000000188980918-0x0000000188980A00
		protected override void OnInit() {} // 0x00000001889819C4-0x0000000188981EC0
		public override void Dispose() {} // 0x00000001889806F0-0x0000000188980918
		protected override void OnActive() {} // 0x0000000188981858-0x0000000188981900
		protected override void OnInactive() {} // 0x0000000188981900-0x00000001889819C4
		internal override void MeshCalculation(int bufferIndex) {} // 0x000000018350B670-0x000000018350B680
		internal override void NormalWriting(int bufferIndex) {} // 0x000000018350B670-0x000000018350B680
		public void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class {}
		public HashSet<Transform> GetUsedBones() => default; // 0x00000001889816F4-0x0000000188981768
		public BaseMeshDeformer GetDeformer() => default; // 0x000000018339AE90-0x000000018339AEA0
		public MagicaRenderDeformer GetRenderDeformer(int index) => default; // 0x00000001889815D0-0x0000000188981624
		public int GetRenderMeshDeformerIndex(RenderMeshDeformer deformer) => default; // 0x0000000188981624-0x00000001889816F4
		public List<MeshData> GetRenderDeformerMeshList() => default; // 0x0000000188981480-0x00000001889815D0
		public override bool IsMeshUse() => default; // 0x00000001889817E0-0x0000000188981858
		public override bool IsActiveMesh() => default; // 0x0000000188981768-0x00000001889817E0
		public override void AddUseMesh(object parent) {} // 0x00000001889802DC-0x00000001889803C0
		public override void RemoveUseMesh(object parent) {} // 0x0000000188981EC0-0x0000000188981FA4
		public override bool AddUseVertex(int vindex, bool fix) => default; // 0x00000001889803C0-0x0000000188980458
		public override bool RemoveUseVertex(int vindex, bool fix) => default; // 0x0000000188981FA4-0x000000018898203C
		public override void ResetFuturePrediction() {} // 0x000000018898203C-0x000000018898209C
		public override void ChangeUseUnityPhysics(bool sw) {} // 0x00000001889804E8-0x000000018898056C
		public void ChangeCalculation(bool sw) {} // 0x0000000188980458-0x00000001889804E8
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x0000000188980AB4-0x0000000188980DCC
		public override List<int> GetEditorTriangleList() => default; // 0x0000000188980DCC-0x0000000188980E80
		public override List<int> GetEditorLineList() => default; // 0x0000000188980A00-0x0000000188980AB4
		public override int GetVersion() => default; // 0x0000000181168950-0x0000000181168960
		public override void CreateVerifyData() {} // 0x000000018898056C-0x00000001889806F0
		public override Define.Error VerifyData() => default; // 0x000000018898209C-0x000000018898249C
		public override string GetInformation() => default; // 0x0000000188980E80-0x0000000188981480
	}

	public class ClampDistance2Constraint : PhysicsManagerConstraint // TypeDefIndex: 51389
	{
		// Fields
		private FixedChunkNativeArray<ClampDistance2Data> dataList; // 0x20
		private FixedChunkNativeArray<ClampDistance2RootInfo> rootInfoList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
		private FixedChunkNativeArray<int> rootTeamList; // 0x38
	
		// Nested types
		[Serializable]
		public struct ClampDistance2Data // TypeDefIndex: 51385
		{
			// Fields
			public int vertexIndex; // 0x00
			public int parentVertexIndex; // 0x04
			public float length; // 0x08
		}
	
		[Serializable]
		public struct ClampDistance2RootInfo // TypeDefIndex: 51386
		{
			// Fields
			public ushort startIndex; // 0x00
			public ushort dataLength; // 0x02
		}
	
		public struct GroupData // TypeDefIndex: 51387
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
	
		[BurstCompile]
		private struct ClampDistance2Job : IJobParallelFor // TypeDefIndex: 51388
		{
			// Fields
			public int runCount; // 0x00
			[ReadOnly]
			public NativeArray<ClampDistance2Data> dataList; // 0x08
			[ReadOnly]
			public NativeArray<ClampDistance2RootInfo> rootInfoList; // 0x18
			[ReadOnly]
			public NativeArray<int> rootTeamList; // 0x28
			[ReadOnly]
			public NativeArray<GroupData> groupList; // 0x38
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x48
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x58
			[ReadOnly]
			public NativeArray<float> frictionList; // 0x68
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> nextPosList; // 0x78
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> posList; // 0x88
	
			// Methods
			public void Execute(int rootIndex) {} // 0x0000000188983788-0x0000000188983BE8
		}
	
		// Constructors
		public ClampDistance2Constraint() {} // 0x0000000183D51DD0-0x0000000183D51DE0
	
		// Methods
		public override void Create() {} // 0x0000000188983064-0x00000001889831BC
		public override void Release() {} // 0x00000001889831BC-0x0000000188983264
		public int AddGroup(int teamId, bool active, float minRatio, float maxRatio, float velocityInfluence, ClampDistance2Data[] dataArray, ClampDistance2RootInfo[] rootInfoArray) => default; // 0x0000000188982BF0-0x0000000188982EB4
		public override void RemoveTeam(int teamId) {} // 0x0000000188983264-0x0000000188983464
		public void ChangeParam(int teamId, bool active, float minRatio, float maxRatio, float velocityInfluence) {} // 0x0000000188982EB4-0x0000000188983064
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x0000000188983464-0x0000000188983788
	}

	public class ClampDistanceConstraint : PhysicsManagerConstraint // TypeDefIndex: 51393
	{
		// Fields
		private FixedChunkNativeArray<ClampDistanceData> dataList; // 0x20
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
	
		// Nested types
		[Serializable]
		public struct ClampDistanceData // TypeDefIndex: 51390
		{
			// Fields
			public ushort vertexIndex; // 0x00
			public ushort targetVertexIndex; // 0x02
			public float length; // 0x04
	
			// Methods
			public bool IsValid() => default; // 0x00000001889845CC-0x00000001889845E0
		}
	
		public struct GroupData // TypeDefIndex: 51391
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
	
		[BurstCompile]
		private struct ClampDistanceJob : IJobParallelFor // TypeDefIndex: 51392
		{
			// Fields
			public int runCount; // 0x00
			[ReadOnly]
			public NativeArray<ClampDistanceData> clampDistanceList; // 0x08
			[ReadOnly]
			public NativeArray<GroupData> groupList; // 0x18
			[ReadOnly]
			public NativeArray<ReferenceDataIndex> refDataList; // 0x28
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x38
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x48
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x58
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> nextPosList; // 0x68
			[ReadOnly]
			public NativeArray<float3> basePosList; // 0x78
			public NativeArray<float3> posList; // 0x88
			[ReadOnly]
			public NativeArray<float> frictionList; // 0x98
	
			// Methods
			public void Execute(int index) {} // 0x00000001889845E0-0x0000000188984B7C
		}
	
		// Constructors
		public ClampDistanceConstraint() {} // 0x0000000183D51DD0-0x0000000183D51DE0
	
		// Methods
		public override void Create() {} // 0x00000001835406C0-0x00000001835407D0
		public override void Release() {} // 0x0000000188983FF4-0x000000018898407C
		public int AddGroup(int teamId, bool active, float minRatio, float maxRatio, float velocityInfluence, ClampDistanceData[] dataArray, ReferenceDataIndex[] refDataArray) => default; // 0x0000000188983BE8-0x0000000188983E44
		public override void RemoveTeam(int teamId) {} // 0x000000018898407C-0x0000000188984244
		public void ChangeParam(int teamId, bool active, float minRatio, float maxRatio, float velocityInfluence) {} // 0x0000000188983E44-0x0000000188983FF4
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x0000000188984244-0x00000001889845CC
	}

	public class ClampPositionConstraint : PhysicsManagerConstraint // TypeDefIndex: 51396
	{
		// Fields
		public FixedNativeList<GroupData> groupList; // 0x20
	
		// Nested types
		public struct GroupData // TypeDefIndex: 51394
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public CurveParam limitLength; // 0x08
			public float3 axisRatio; // 0x18
			public float velocityInfluence; // 0x24
	
			// Methods
			public bool IsAxisCheck() => default; // 0x000000018898C0CC-0x000000018898C0EC
		}
	
		[BurstCompile]
		private struct ClampPositionJob : IJobParallelFor // TypeDefIndex: 51395
		{
			// Fields
			public int runCount; // 0x00
			public float maxMoveLength; // 0x04
			[ReadOnly]
			public NativeArray<GroupData> clampPositionGroupList; // 0x08
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x18
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x28
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x38
			[ReadOnly]
			public NativeArray<float> depthList; // 0x48
			[ReadOnly]
			public NativeArray<float3> basePosList; // 0x58
			[ReadOnly]
			public NativeArray<quaternion> baseRotList; // 0x68
			[ReadOnly]
			public NativeArray<float> frictionList; // 0x78
			public NativeArray<float3> nextPosList; // 0x88
			public NativeArray<float3> posList; // 0x98
	
			// Methods
			public void Execute(int index) {} // 0x00000001889853A4-0x00000001889859C4
		}
	
		// Constructors
		public ClampPositionConstraint() {} // 0x0000000183D51DD0-0x0000000183D51DE0
	
		// Methods
		public override void Create() {} // 0x0000000183CFD970-0x0000000183CFD9F0
		public override void Release() {} // 0x0000000188984E7C-0x0000000188984EC4
		public int AddGroup(int teamId, bool active, BezierParam limitLength, float3 axisRatio, float velocityInfluence) => default; // 0x0000000188984B7C-0x0000000188984CA8
		public override void RemoveTeam(int teamId) {} // 0x0000000188984EC4-0x0000000188984FDC
		public void ChangeParam(int teamId, bool active, BezierParam limitLength, float3 axisRatio, float velocityInfluence) {} // 0x0000000188984CA8-0x0000000188984E7C
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x0000000188984FDC-0x00000001889853A4
	}

	public class ClampRotationConstraint : PhysicsManagerConstraint // TypeDefIndex: 51401
	{
		// Fields
		private FixedChunkNativeArray<ClampRotationData> dataList; // 0x20
		private FixedChunkNativeArray<ClampRotationRootInfo> rootInfoList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
		private FixedChunkNativeArray<int> rootTeamList; // 0x38
		private FixedChunkNativeArray<float> lengthBuffer; // 0x40
	
		// Nested types
		[Serializable]
		public struct ClampRotationData // TypeDefIndex: 51397
		{
			// Fields
			public int vertexIndex; // 0x00
			public int parentVertexIndex; // 0x04
			public float3 localPos; // 0x08
			public quaternion localRot; // 0x14
	
			// Methods
			public bool IsValid() => default; // 0x000000018898656C-0x000000018898657C
		}
	
		[Serializable]
		public struct ClampRotationRootInfo // TypeDefIndex: 51398
		{
			// Fields
			public ushort startIndex; // 0x00
			public ushort dataLength; // 0x02
		}
	
		public struct GroupData // TypeDefIndex: 51399
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public CurveParam maxAngle; // 0x08
			public float velocityInfluence; // 0x18
			public ChunkData dataChunk; // 0x1C
			public ChunkData rootInfoChunk; // 0x2C
		}
	
		[BurstCompile]
		private struct ClampRotationJob : IJobParallelFor // TypeDefIndex: 51400
		{
			// Fields
			public int runCount; // 0x00
			public float maxMoveLength; // 0x04
			[ReadOnly]
			public NativeArray<ClampRotationData> dataList; // 0x08
			[ReadOnly]
			public NativeArray<ClampRotationRootInfo> rootInfoList; // 0x18
			[ReadOnly]
			public NativeArray<int> rootTeamList; // 0x28
			[ReadOnly]
			public NativeArray<GroupData> groupList; // 0x38
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x48
			[ReadOnly]
			public NativeArray<float> depthList; // 0x58
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x68
			[ReadOnly]
			public NativeArray<float> frictionList; // 0x78
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> nextPosList; // 0x88
			[NativeDisableParallelForRestriction]
			public NativeArray<quaternion> nextRotList; // 0x98
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> posList; // 0xA8
			[NativeDisableParallelForRestriction]
			public NativeArray<float> lengthBuffer; // 0xB8
	
			// Methods
			public void Execute(int rootIndex) {} // 0x000000018898657C-0x0000000188986FEC
		}
	
		// Constructors
		public ClampRotationConstraint() {} // 0x0000000183D51DD0-0x0000000183D51DE0
	
		// Methods
		public override void Create() {} // 0x00000001835407D0-0x0000000183540970
		public override void Release() {} // 0x0000000188985E6C-0x0000000188985F38
		public int AddGroup(int teamId, bool active, BezierParam maxAngle, float velocityInfluence, ClampRotationData[] dataArray, ClampRotationRootInfo[] rootInfoArray) => default; // 0x00000001889859C4-0x0000000188985C8C
		public override void RemoveTeam(int teamId) {} // 0x0000000188985F38-0x0000000188986184
		public void ChangeParam(int teamId, bool active, BezierParam maxAngle, float velocityInfluence) {} // 0x0000000188985C8C-0x0000000188985E6C
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x0000000188986184-0x000000018898656C
	}

	public class ColliderCollisionConstraint : PhysicsManagerConstraint // TypeDefIndex: 51403
	{
		// Nested types
		[BurstCompile]
		private struct CollisionJob : IJobParallelFor // TypeDefIndex: 51402
		{
			// Fields
			public int runCount; // 0x00
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x08
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x18
			[ReadOnly]
			public NativeArray<float3> radiusList; // 0x28
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> nextPosList; // 0x38
			[ReadOnly]
			public NativeArray<quaternion> nextRotList; // 0x48
			[ReadOnly]
			public NativeArray<float3> posList; // 0x58
			[ReadOnly]
			public NativeArray<quaternion> rotList; // 0x68
			[ReadOnly]
			public NativeArray<float3> localPosList; // 0x78
			[ReadOnly]
			public NativeArray<float3> basePosList; // 0x88
			[ReadOnly]
			public NativeArray<quaternion> baseRotList; // 0x98
			[ReadOnly]
			public NativeArray<int> transformIndexList; // 0xA8
			[ReadOnly]
			public NativeArray<int> colliderList; // 0xB8
			[ReadOnly]
			public NativeArray<float3> boneSclList; // 0xC8
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0xD8
			public NativeArray<float> frictionList; // 0xE8
			[WriteOnly]
			public NativeArray<int> collisionLinkIdList; // 0xF8
			[WriteOnly]
			public NativeArray<float3> collisionNormalList; // 0x108
	
			// Methods
			public void Execute(int index) {} // 0x0000000188988290-0x0000000188988750
			private float SphereColliderDetection(ref float3 nextpos, float radius, int cindex, out float3 normal) {
				normal = default;
				return default;
			} // 0x0000000188988874-0x0000000188988A24
			private float CapsuleColliderDetection(ref float3 nextpos, float radius, int cindex, float3 dir, out float3 normal) {
				normal = default;
				return default;
			} // 0x0000000188987DDC-0x0000000188988290
			private float PlaneColliderDetection(ref float3 nextpos, float radius, int cindex, out float3 normal) {
				normal = default;
				return default;
			} // 0x0000000188988750-0x0000000188988874
		}
	
		// Constructors
		public ColliderCollisionConstraint() {} // 0x0000000183D51DD0-0x0000000183D51DE0
	
		// Methods
		public override void Create() {} // 0x000000018350B670-0x000000018350B680
		public override void RemoveTeam(int teamId) {} // 0x000000018350B670-0x000000018350B680
		public void ChangeParam(int teamId, bool useCollision) {} // 0x0000000188986FEC-0x000000018898703C
		public override void Release() {} // 0x000000018350B670-0x000000018350B680
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x000000018898703C-0x0000000188987590
	}

	public class ColliderExtrusionConstraint : PhysicsManagerConstraint // TypeDefIndex: 51405
	{
		// Nested types
		[BurstCompile]
		private struct CollisionExtrusionJob : IJobParallelFor // TypeDefIndex: 51404
		{
			// Fields
			public int runCount; // 0x00
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x08
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x18
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> nextPosList; // 0x28
			[ReadOnly]
			public NativeArray<quaternion> nextRotList; // 0x38
			public NativeArray<int> collisionLinkIdList; // 0x48
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> posList; // 0x58
			[ReadOnly]
			public NativeArray<quaternion> rotList; // 0x68
			[ReadOnly]
			public NativeArray<float> frictionList; // 0x78
			[ReadOnly]
			public NativeArray<float3> collisionNormalList; // 0x88
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x98
	
			// Methods
			public void Execute(int index) {} // 0x0000000188987960-0x0000000188987DDC
		}
	
		// Constructors
		public ColliderExtrusionConstraint() {} // 0x0000000183D51DD0-0x0000000183D51DE0
	
		// Methods
		public override void Create() {} // 0x000000018350B670-0x000000018350B680
		public override void RemoveTeam(int teamId) {} // 0x000000018350B670-0x000000018350B680
		public override void Release() {} // 0x000000018350B670-0x000000018350B680
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x0000000188987590-0x0000000188987960
	}

	public class CompositeRotationConstraint : PhysicsManagerConstraint // TypeDefIndex: 51410
	{
		// Fields
		private FixedChunkNativeArray<RotationData> dataList; // 0x20
		private FixedChunkNativeArray<RootInfo> rootInfoList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
		private FixedChunkNativeArray<int> rootTeamList; // 0x38
		private FixedChunkNativeArray<float> lengthBuffer; // 0x40
	
		// Nested types
		[Serializable]
		public struct RotationData // TypeDefIndex: 51406
		{
			// Fields
			public int vertexIndex; // 0x00
			public int parentVertexIndex; // 0x04
			public float3 localPos; // 0x08
			public quaternion localRot; // 0x14
	
			// Methods
			public bool IsValid() => default; // 0x000000018898656C-0x000000018898657C
		}
	
		[Serializable]
		public struct RootInfo // TypeDefIndex: 51407
		{
			// Fields
			public ushort startIndex; // 0x00
			public ushort dataLength; // 0x02
		}
	
		public struct GroupData // TypeDefIndex: 51408
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
	
		[BurstCompile]
		private struct RotationRootLineJob : IJobParallelFor // TypeDefIndex: 51409
		{
			// Fields
			public float updatePower; // 0x00
			public int runCount; // 0x04
			public float maxMoveSpeed; // 0x08
			[ReadOnly]
			public NativeArray<RotationData> dataList; // 0x10
			[ReadOnly]
			public NativeArray<RootInfo> rootInfoList; // 0x20
			[ReadOnly]
			public NativeArray<int> rootTeamList; // 0x30
			[ReadOnly]
			public NativeArray<GroupData> groupList; // 0x40
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x50
			[ReadOnly]
			public NativeArray<CurveParam> teamGravityList; // 0x60
			[ReadOnly]
			public NativeArray<float> depthList; // 0x70
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x80
			[ReadOnly]
			public NativeArray<float> frictionList; // 0x90
			[ReadOnly]
			public NativeArray<float3> basePosList; // 0xA0
			[ReadOnly]
			public NativeArray<quaternion> baseRotList; // 0xB0
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> nextPosList; // 0xC0
			[NativeDisableParallelForRestriction]
			public NativeArray<quaternion> nextRotList; // 0xD0
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> posList; // 0xE0
			[NativeDisableParallelForRestriction]
			public NativeArray<float> lengthBuffer; // 0xF0
	
			// Methods
			public void Execute(int rootIndex) {} // 0x00000001889900C8-0x0000000188991790
			private float GetRotRatio(float3 tv, float3 gravityVector, float gravity, float minRatio = 0.25f /* Metadata: 0x01FD1006 */, float maxRatio = 0.45f /* Metadata: 0x01FD100A */) => default; // 0x0000000188982B1C-0x0000000188982BF0
		}
	
		// Constructors
		public CompositeRotationConstraint() {} // 0x0000000183D51DD0-0x0000000183D51DE0
	
		// Methods
		public override void Create() {} // 0x0000000183540970-0x0000000183540B10
		public override void Release() {} // 0x0000000188988EF8-0x0000000188988FC4
		public int AddGroup(int teamId, bool useClamp, BezierParam maxAngle, bool useRestore, BezierParam restorePower, float velocityInfluence, RotationData[] dataArray, RootInfo[] rootInfoArray) => default; // 0x0000000188988A24-0x0000000188988CF4
		public override void RemoveTeam(int teamId) {} // 0x0000000188988FC4-0x00000001889891D4
		public void ChangeParam(int teamId, bool useClamp, BezierParam maxAngle, bool useRestore, BezierParam restorePower, float velocityInfluence) {} // 0x0000000188988CF4-0x0000000188988EF8
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x00000001889891D4-0x0000000188989654
	}

	public class EdgeCollisionConstraint : PhysicsManagerConstraint // TypeDefIndex: 51415
	{
		// Fields
		private FixedChunkNativeArray<EdgeCollisionData> dataList; // 0x20
		private FixedChunkNativeArray<short> groupIndexList; // 0x28
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x30
		private FixedChunkNativeArray<float3> writeBuffer; // 0x38
		private FixedNativeList<GroupData> groupList; // 0x40
	
		// Nested types
		[Serializable]
		public struct EdgeCollisionData // TypeDefIndex: 51411
		{
			// Fields
			public ushort vindex0; // 0x00
			public ushort vindex1; // 0x02
			public int writeIndex0; // 0x04
			public int writeIndex1; // 0x08
	
			// Methods
			public bool IsValid() => default; // 0x000000018898BD74-0x000000018898BD88
		}
	
		public struct GroupData // TypeDefIndex: 51412
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
	
		[BurstCompile]
		private struct EdgeCollisionCalcJob : IJobParallelFor // TypeDefIndex: 51413
		{
			// Fields
			public float updatePower; // 0x00
			public int runCount; // 0x04
			[ReadOnly]
			public NativeArray<GroupData> groupDataList; // 0x08
			[ReadOnly]
			public NativeArray<EdgeCollisionData> dataList; // 0x18
			[ReadOnly]
			public NativeArray<short> groupIndexList; // 0x28
			[ReadOnly]
			public NativeArray<int> colliderList; // 0x38
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x48
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x58
			[ReadOnly]
			public NativeArray<float3> radiusList; // 0x68
			[ReadOnly]
			public NativeArray<float3> posList; // 0x78
			[ReadOnly]
			public NativeArray<quaternion> rotList; // 0x88
			[ReadOnly]
			public NativeArray<float3> nextPosList; // 0x98
			[ReadOnly]
			public NativeArray<quaternion> nextRotList; // 0xA8
			[ReadOnly]
			public NativeArray<float3> localPosList; // 0xB8
			[ReadOnly]
			public NativeArray<int> transformIndexList; // 0xC8
			[ReadOnly]
			public NativeArray<float3> boneSclList; // 0xD8
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> writeBuffer; // 0xE8
	
			// Methods
			public void Execute(int index) {} // 0x000000018898A4E0-0x000000018898A9B4
			private bool SphereColliderDetection(float3 nextpos0, float3 nextpos1, ref float3 corr0, ref float3 corr1, float radius, int cindex) => default; // 0x000000018898A9B4-0x000000018898ACFC
			private bool CapsuleColliderDetection(float3 nextpos0, float3 nextpos1, ref float3 corr0, ref float3 corr1, float radius, int cindex, float3 dir) => default; // 0x0000000188989E4C-0x000000018898A4E0
		}
	
		[BurstCompile]
		private struct EdgeCollisionSumJob : IJobParallelFor // TypeDefIndex: 51414
		{
			// Fields
			public int runCount; // 0x00
			[ReadOnly]
			public NativeArray<GroupData> groupDataList; // 0x08
			[ReadOnly]
			public NativeArray<ReferenceDataIndex> refDataList; // 0x18
			[ReadOnly]
			public NativeArray<float3> writeBuffer; // 0x28
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x38
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x48
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x58
			public NativeArray<float3> inoutNextPosList; // 0x68
			public NativeArray<float> frictionList; // 0x78
	
			// Methods
			public void Execute(int pindex) {} // 0x000000018898BD88-0x000000018898C0CC
		}
	
		// Constructors
		public EdgeCollisionConstraint() {} // 0x0000000183D51DD0-0x0000000183D51DE0
	
		// Methods
		public override void Create() {} // 0x000000018898B1C4-0x000000018898B368
		public override void Release() {} // 0x000000018898B368-0x000000018898B434
		public int AddGroup(int teamId, bool active, float edgeRadius, EdgeCollisionData[] dataArray, ReferenceDataIndex[] refDataArray, int writeBufferCount) => default; // 0x000000018898ACFC-0x000000018898B030
		public override void RemoveTeam(int teamId) {} // 0x000000018898B434-0x000000018898B680
		public void ChangeParam(int teamId, bool active, float edgeRadius) {} // 0x000000018898B030-0x000000018898B1C4
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x000000018898B680-0x000000018898BD74
	}

	public class PenetrationConstraint : PhysicsManagerConstraint // TypeDefIndex: 51419
	{
		// Fields
		private FixedChunkNativeArray<PenetrationData> dataList; // 0x20
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x28
		private FixedChunkNativeArray<float3> bonePenetrationDataList; // 0x30
		public FixedNativeList<GroupData> groupList; // 0x38
	
		// Nested types
		[Serializable]
		public struct PenetrationData // TypeDefIndex: 51416
		{
			// Fields
			public short vertexIndex; // 0x00
			public short colliderIndex; // 0x02
			public float3 localPos; // 0x04
			public float3 localDir; // 0x10
			public float distance; // 0x1C
	
			// Methods
			public bool IsValid() => default; // 0x000000018898CE54-0x000000018898CE60
		}
	
		public struct GroupData // TypeDefIndex: 51417
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
	
		[BurstCompile]
		private struct PenetrationJob : IJobParallelFor // TypeDefIndex: 51418
		{
			// Fields
			public int runCount; // 0x00
			[ReadOnly]
			public NativeArray<GroupData> groupList; // 0x08
			[ReadOnly]
			public NativeArray<PenetrationData> dataList; // 0x18
			[ReadOnly]
			public NativeArray<ReferenceDataIndex> refDataList; // 0x28
			[ReadOnly]
			public NativeArray<float3> bonePenetrationDataList; // 0x38
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x48
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x58
			[ReadOnly]
			public NativeArray<float3> nextPosList; // 0x68
			[ReadOnly]
			public NativeArray<quaternion> nextRotList; // 0x78
			[ReadOnly]
			public NativeArray<int> transformIndexList; // 0x88
			[ReadOnly]
			public NativeArray<float> depthList; // 0x98
			[ReadOnly]
			public NativeArray<float3> basePosList; // 0xA8
			[ReadOnly]
			public NativeArray<quaternion> baseRotList; // 0xB8
			[ReadOnly]
			public NativeArray<int> colliderList; // 0xC8
			[ReadOnly]
			public NativeArray<float3> bonePosList; // 0xD8
			[ReadOnly]
			public NativeArray<quaternion> boneRotList; // 0xE8
			[ReadOnly]
			public NativeArray<float3> boneSclList; // 0xF8
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x108
			[ReadOnly]
			public NativeArray<int> skinningBoneList; // 0x118
			[WriteOnly]
			public NativeArray<float3> outNextPosList; // 0x128
			public NativeArray<float3> posList; // 0x138
	
			// Methods
			public void Execute(int index) {} // 0x000000018898CE60-0x000000018898D9E0
			private float3 InverseSpherePosition(ref PenetrationData data, float teamScale, float3 scaleDirection, float distance, int cindex, float cr) => default; // 0x000000018898DB00-0x000000018898DCDC
			private float3 InverseSpherePenetration(float3 c, float cr, float3 nextpos) => default; // 0x000000018898D9E0-0x000000018898DB00
		}
	
		// Constructors
		public PenetrationConstraint() {} // 0x0000000183D51DD0-0x0000000183D51DE0
	
		// Methods
		public override void Create() {} // 0x0000000183540B10-0x0000000183540C70
		public override void Release() {} // 0x000000018898C5B4-0x000000018898C65C
		public int AddGroup(int teamId, bool active, ClothParams.PenetrationMode mode, BezierParam distance, BezierParam radius, float maxDepth, PenetrationData[] moveLimitDataList, ReferenceDataIndex[] refDataArray, float3[] bonePenetrationDataArray) => default; // 0x000000018898C0EC-0x000000018898C3BC
		public override void RemoveTeam(int teamId) {} // 0x000000018898C65C-0x000000018898C848
		public void ChangeParam(int teamId, bool active, BezierParam distance, BezierParam radius, float maxDepth) {} // 0x000000018898C3BC-0x000000018898C5B4
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x000000018898C848-0x000000018898CE54
	}

	public class RestoreDistanceConstraint : PhysicsManagerConstraint // TypeDefIndex: 51423
	{
		// Fields
		public const int StructType = 0; // Metadata: 0x01FD100E
		public const int BendType = 1; // Metadata: 0x01FD100F
		public const int NearType = 2; // Metadata: 0x01FD1010
		public const int TypeCount = 3; // Metadata: 0x01FD1011
		private FixedChunkNativeArray<RestoreDistanceData>[] dataList; // 0x20
		private FixedChunkNativeArray<ReferenceDataIndex>[] refDataList; // 0x28
		public FixedNativeList<RestoreDistanceGroupData> groupList; // 0x30
	
		// Nested types
		[Serializable]
		public struct RestoreDistanceData // TypeDefIndex: 51420
		{
			// Fields
			public ushort vertexIndex; // 0x00
			public ushort targetVertexIndex; // 0x02
			public float length; // 0x04
	
			// Methods
			public bool IsValid() => default; // 0x00000001889845CC-0x00000001889845E0
		}
	
		public struct RestoreDistanceGroupData // TypeDefIndex: 51421
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
			public bool IsValid(int type) => default; // 0x000000018898EE5C-0x000000018898EE78
			public CurveParam GetStiffness(int type) => default; // 0x000000018898EE34-0x000000018898EE5C
			public ChunkData GetDataChunk(int type) => default; // 0x000000018898EDE4-0x000000018898EE0C
			public ChunkData GetRefChunk(int type) => default; // 0x000000018898EE0C-0x000000018898EE34
		}
	
		[BurstCompile]
		private struct DistanceJob : IJobParallelFor // TypeDefIndex: 51422
		{
			// Fields
			public float updatePower; // 0x00
			public int runCount; // 0x04
			public int type; // 0x08
			[ReadOnly]
			public NativeArray<RestoreDistanceData> restoreDistanceDataList; // 0x10
			[ReadOnly]
			public NativeArray<RestoreDistanceGroupData> restoreDistanceGroupDataList; // 0x20
			[ReadOnly]
			public NativeArray<ReferenceDataIndex> refDataList; // 0x30
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x40
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x50
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x60
			[ReadOnly]
			public NativeArray<float> depthList; // 0x70
			[ReadOnly]
			public NativeArray<float> frictionList; // 0x80
			[ReadOnly]
			public NativeArray<float3> basePosList; // 0x90
			[ReadOnly]
			public NativeArray<float3> nextPosList; // 0xA0
			[WriteOnly]
			public NativeArray<float3> outNextPosList; // 0xB0
			public NativeArray<float3> posList; // 0xC0
	
			// Methods
			public void Execute(int index) {} // 0x0000000188989654-0x0000000188989E4C
		}
	
		// Constructors
		public RestoreDistanceConstraint() {} // 0x0000000183D51DD0-0x0000000183D51DE0
	
		// Methods
		public override void Create() {} // 0x0000000183540E90-0x0000000183541070
		public override void Release() {} // 0x000000018898E544-0x000000018898E628
		public int AddGroup(int teamId, BezierParam mass, float velocityInfluence, BezierParam structStiffness, RestoreDistanceData[] structDataArray, ReferenceDataIndex[] structRefDataArray, bool useBend, BezierParam bendStiffness, RestoreDistanceData[] bendDataArray, ReferenceDataIndex[] bendRefDataArray, bool useNear, BezierParam nearStiffness, RestoreDistanceData[] nearDataArray, ReferenceDataIndex[] nearRefDataArray) => default; // 0x000000018898DCDC-0x000000018898E2A8
		public override void RemoveTeam(int teamId) {} // 0x000000018898E628-0x000000018898E8D4
		public void ChangeParam(int teamId, BezierParam mass, float velocityInfluence, BezierParam structStiffness, bool useBend, BezierParam bendStiffness, bool useNear, BezierParam nearStiffness) {} // 0x000000018898E2A8-0x000000018898E544
		public override int GetIterationCount() => default; // 0x0000000183D4E340-0x0000000183D4E350
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x000000018898E8D4-0x000000018898EDE4
	}

	public class RestoreRotationConstraint : PhysicsManagerConstraint // TypeDefIndex: 51427
	{
		// Fields
		private FixedChunkNativeArray<RotationData> dataList; // 0x20
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
	
		// Nested types
		[Serializable]
		public struct RotationData // TypeDefIndex: 51424
		{
			// Fields
			public ushort vertexIndex; // 0x00
			public ushort targetVertexIndex; // 0x02
			public float3 localPos; // 0x04
	
			// Methods
			public bool IsValid() => default; // 0x00000001889845CC-0x00000001889845E0
		}
	
		public struct GroupData // TypeDefIndex: 51425
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public CurveParam restorePower; // 0x08
			public float velocityInfluence; // 0x18
			public ChunkData dataChunk; // 0x1C
			public ChunkData refChunk; // 0x2C
		}
	
		[BurstCompile]
		private struct RotationJob : IJobParallelFor // TypeDefIndex: 51426
		{
			// Fields
			public float updatePower; // 0x00
			public int runCount; // 0x04
			[ReadOnly]
			public NativeArray<RotationData> dataList; // 0x08
			[ReadOnly]
			public NativeArray<GroupData> groupList; // 0x18
			[ReadOnly]
			public NativeArray<ReferenceDataIndex> refDataList; // 0x28
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x38
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x48
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x58
			[ReadOnly]
			public NativeArray<float> depthList; // 0x68
			[ReadOnly]
			public NativeArray<quaternion> baseRotList; // 0x78
			[ReadOnly]
			public NativeArray<float3> nextPosList; // 0x88
			[ReadOnly]
			public NativeArray<float> frictionList; // 0x98
			[WriteOnly]
			public NativeArray<float3> outNextPosList; // 0xA8
			public NativeArray<float3> posList; // 0xB8
	
			// Methods
			public void Execute(int index) {} // 0x000000018898F990-0x00000001889900C8
		}
	
		// Constructors
		public RestoreRotationConstraint() {} // 0x0000000183D51DD0-0x0000000183D51DE0
	
		// Methods
		public override void Create() {} // 0x0000000183540C70-0x0000000183540D80
		public override void Release() {} // 0x000000018898F2D4-0x000000018898F35C
		public int AddGroup(int teamId, bool active, BezierParam power, float velocityInfluence, RotationData[] dataArray, ReferenceDataIndex[] refDataArray) => default; // 0x000000018898EE78-0x000000018898F0F4
		public override void RemoveTeam(int teamId) {} // 0x000000018898F35C-0x000000018898F534
		public void ChangeParam(int teamId, bool active, BezierParam power, float velocityInfluence) {} // 0x000000018898F0F4-0x000000018898F2D4
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x000000018898F534-0x000000018898F990
	}

	public class SpringConstraint : PhysicsManagerConstraint // TypeDefIndex: 51430
	{
		// Fields
		public FixedNativeList<GroupData> groupList; // 0x20
	
		// Nested types
		public struct GroupData // TypeDefIndex: 51428
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public float spring; // 0x08
		}
	
		[BurstCompile]
		private struct SpringJob : IJobParallelFor // TypeDefIndex: 51429
		{
			// Fields
			public float updatePower; // 0x00
			public int runCount; // 0x04
			[ReadOnly]
			public NativeArray<GroupData> groupList; // 0x08
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x18
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x28
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x38
			[ReadOnly]
			public NativeArray<float3> basePosList; // 0x48
			public NativeArray<float3> nextPosList; // 0x58
	
			// Methods
			public void Execute(int index) {} // 0x0000000188991DCC-0x0000000188992034
		}
	
		// Constructors
		public SpringConstraint() {} // 0x0000000183D51DD0-0x0000000183D51DE0
	
		// Methods
		public override void Create() {} // 0x0000000183CFC2F0-0x0000000183CFC370
		public override void Release() {} // 0x00000001889919BC-0x0000000188991A04
		public int AddGroup(int teamId, bool active, float spring) => default; // 0x0000000188991790-0x000000018899185C
		public override void RemoveTeam(int teamId) {} // 0x0000000188991A04-0x0000000188991B1C
		public void ChangeParam(int teamId, bool active, float spring) {} // 0x000000018899185C-0x00000001889919BC
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x0000000188991B1C-0x0000000188991DCC
	}

	public class TriangleBendConstraint : PhysicsManagerConstraint // TypeDefIndex: 51435
	{
		// Fields
		private FixedChunkNativeArray<TriangleBendData> dataList; // 0x20
		private FixedChunkNativeArray<short> groupIndexList; // 0x28
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x30
		private FixedChunkNativeArray<float3> writeBuffer; // 0x38
		private FixedNativeList<TriangleBendGroupData> groupList; // 0x40
	
		// Nested types
		[Serializable]
		public struct TriangleBendData // TypeDefIndex: 51431
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
			public bool IsValid() => default; // 0x0000000188993A6C-0x0000000188993A7C
			public bool IsPositionBend() => default; // 0x0000000188993A64-0x0000000188993A6C
		}
	
		public struct TriangleBendGroupData // TypeDefIndex: 51432
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
	
		[BurstCompile]
		private struct TriangleBendCalcJob : IJobParallelFor // TypeDefIndex: 51433
		{
			// Fields
			public float updatePower; // 0x00
			public int runCount; // 0x04
			[ReadOnly]
			public NativeArray<TriangleBendGroupData> triangleBendGroupDataList; // 0x08
			[ReadOnly]
			public NativeArray<TriangleBendData> triangleBendList; // 0x18
			[ReadOnly]
			public NativeArray<short> groupIndexList; // 0x28
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x38
			[ReadOnly]
			public NativeArray<float3> nextPosList; // 0x48
			[ReadOnly]
			public NativeArray<float3> basePosList; // 0x58
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> writeBuffer; // 0x68
	
			// Methods
			public void Execute(int index) {} // 0x0000000188992034-0x0000000188992D28
		}
	
		[BurstCompile]
		private struct TriangleBendSumJob : IJobParallelFor // TypeDefIndex: 51434
		{
			// Fields
			public int runCount; // 0x00
			[ReadOnly]
			public NativeArray<TriangleBendGroupData> triangleBendGroupDataList; // 0x08
			[ReadOnly]
			public NativeArray<ReferenceDataIndex> refDataList; // 0x18
			[ReadOnly]
			public NativeArray<float3> writeBuffer; // 0x28
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x38
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x48
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x58
			public NativeArray<float3> inoutNextPosList; // 0x68
			public NativeArray<float3> posList; // 0x78
	
			// Methods
			public void Execute(int pindex) {} // 0x0000000188993A7C-0x0000000188993E40
		}
	
		// Constructors
		public TriangleBendConstraint() {} // 0x0000000183D51DD0-0x0000000183D51DE0
	
		// Methods
		public override void Create() {} // 0x0000000183541070-0x0000000183541210
		public override void Release() {} // 0x000000018899328C-0x0000000188993358
		public int AddGroup(int teamId, bool active, ClothParams.Algorithm algorithm, BezierParam stiffness, TriangleBendData[] dataArray, ReferenceDataIndex[] refDataArray, int writeBufferCount) => default; // 0x0000000188992D28-0x0000000188993090
		public override void RemoveTeam(int teamId) {} // 0x0000000188993358-0x00000001889935A4
		public void ChangeParam(int teamId, bool active, BezierParam stiffness) {} // 0x0000000188993090-0x000000018899328C
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x00000001889935A4-0x0000000188993A64
	}

	public class TwistConstraint : PhysicsManagerConstraint // TypeDefIndex: 51439
	{
		// Fields
		private FixedChunkNativeArray<TwistData> dataList; // 0x20
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
	
		// Nested types
		[Serializable]
		public struct TwistData // TypeDefIndex: 51436
		{
			// Fields
			public ushort vertexIndex0; // 0x00
			public ushort vertexIndex1; // 0x02
	
			// Methods
			public bool IsValid() => default; // 0x00000001889845CC-0x00000001889845E0
		}
	
		public struct GroupData // TypeDefIndex: 51437
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public float recoveryPower; // 0x08
			public ChunkData dataChunk; // 0x0C
			public ChunkData refChunk; // 0x1C
		}
	
		[BurstCompile]
		private struct TwistJob2 : IJobParallelFor // TypeDefIndex: 51438
		{
			// Fields
			public int runCount; // 0x00
			public float updatePower; // 0x04
			[ReadOnly]
			public NativeArray<TwistData> dataList; // 0x08
			[ReadOnly]
			public NativeArray<ReferenceDataIndex> refDataList; // 0x18
			[ReadOnly]
			public NativeArray<GroupData> groupList; // 0x28
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x38
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x48
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x58
			[ReadOnly]
			public NativeArray<float3> basePosList; // 0x68
			[ReadOnly]
			public NativeArray<float3> nextPosList; // 0x78
			[ReadOnly]
			public NativeArray<float> frictionList; // 0x88
			[WriteOnly]
			public NativeArray<float3> outNextPosList; // 0x98
			public NativeArray<float3> posList; // 0xA8
	
			// Methods
			public void Execute(int index) {} // 0x0000000188994818-0x0000000188994F0C
		}
	
		// Constructors
		public TwistConstraint() {} // 0x0000000183D51DD0-0x0000000183D51DE0
	
		// Methods
		public override void Create() {} // 0x0000000183540D80-0x0000000183540E90
		public override void Release() {} // 0x00000001889941A8-0x0000000188994230
		public int AddGroup(int teamId, bool active, float recoveryPower, TwistData[] dataArray, ReferenceDataIndex[] refArray) => default; // 0x0000000188993E40-0x0000000188994028
		public override void RemoveTeam(int teamId) {} // 0x0000000188994230-0x0000000188994408
		public void ChangeParam(int teamId, bool active, float recoveryPower) {} // 0x0000000188994028-0x00000001889941A8
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x0000000188994408-0x0000000188994818
	}

	public class VolumeConstraint : PhysicsManagerConstraint // TypeDefIndex: 51444
	{
		// Fields
		private FixedChunkNativeArray<VolumeData> dataList; // 0x20
		private FixedChunkNativeArray<short> groupIndexList; // 0x28
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x30
		private FixedChunkNativeArray<float3> writeBuffer; // 0x38
		private FixedNativeList<GroupData> groupList; // 0x40
	
		// Nested types
		[Serializable]
		public struct VolumeData // TypeDefIndex: 51440
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
			public bool IsValid() => default; // 0x0000000188993A6C-0x0000000188993A7C
		}
	
		public struct GroupData // TypeDefIndex: 51441
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
	
		[BurstCompile]
		private struct VolumeCalcJob : IJobParallelFor // TypeDefIndex: 51442
		{
			// Fields
			public float updatePower; // 0x00
			public int runCount; // 0x04
			[ReadOnly]
			public NativeArray<GroupData> groupDataList; // 0x08
			[ReadOnly]
			public NativeArray<VolumeData> dataList; // 0x18
			[ReadOnly]
			public NativeArray<short> groupIndexList; // 0x28
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x38
			[ReadOnly]
			public NativeArray<float3> nextPosList; // 0x48
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> writeBuffer; // 0x58
	
			// Methods
			public void Execute(int index) {} // 0x0000000188994F3C-0x0000000188995D88
		}
	
		[BurstCompile]
		private struct VolumeSumJob : IJobParallelFor // TypeDefIndex: 51443
		{
			// Fields
			public int runCount; // 0x00
			[ReadOnly]
			public NativeArray<GroupData> groupDataList; // 0x08
			[ReadOnly]
			public NativeArray<ReferenceDataIndex> refDataList; // 0x18
			[ReadOnly]
			public NativeArray<float3> writeBuffer; // 0x28
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x38
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x48
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x58
			public NativeArray<float3> inoutNextPosList; // 0x68
	
			// Methods
			public void Execute(int pindex) {} // 0x00000001889A5CB4-0x00000001889A5FEC
		}
	
		// Constructors
		public VolumeConstraint() {} // 0x0000000183D51DD0-0x0000000183D51DE0
	
		// Methods
		public override void Create() {} // 0x0000000188996310-0x00000001889964B4
		public override void Release() {} // 0x00000001889964B4-0x0000000188996580
		public int AddGroup(int teamId, bool active, BezierParam stretchStiffness, BezierParam shearStiffness, VolumeData[] dataArray, ReferenceDataIndex[] refDataArray, int writeBufferCount) => default; // 0x0000000188995D88-0x00000001889960FC
		public override void RemoveTeam(int teamId) {} // 0x0000000188996580-0x00000001889967BC
		public void ChangeParam(int teamId, bool active, BezierParam stretchStiffness, BezierParam shearStiffness) {} // 0x00000001889960FC-0x0000000188996310
		public override int GetIterationCount() => default; // 0x0000000183D4E340-0x0000000183D4E350
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle) => default; // 0x00000001889967BC-0x0000000188996D04
	}

	public struct CurveParam // TypeDefIndex: 51445
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
		} // 0x0000000183D6E200-0x0000000183D6E210
		public CurveParam(float svalue, float evalue) {
			sval = default;
			eval = default;
			cval = default;
			useCurve = default;
		} // 0x0000000183D6E210-0x0000000183D6E220
		public CurveParam(BezierParam bezier) {
			sval = default;
			eval = default;
			cval = default;
			useCurve = default;
		} // 0x0000000188997188-0x000000018899719C
	
		// Methods
		public void Setup(BezierParam bezier) {} // 0x00000001889970E8-0x0000000188997188
		public float Evaluate(float t) => default; // 0x0000000188997080-0x00000001889970E8
	}

	public abstract class BaseComponent : MonoBehaviour // TypeDefIndex: 51446
	{
		// Constructors
		protected BaseComponent() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public abstract ComponentType GetComponentType();
	}

	public enum ComponentType // TypeDefIndex: 51447
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

	public abstract class PhysicsManagerAccess : IDisposable // TypeDefIndex: 51448
	{
		// Fields
		protected MagicaPhysicsManager manager; // 0x10
	
		// Properties
		public UpdateTimeManager UpdateTime { get; } // 0x00000001856B3E18-0x00000001856B3E34 
		protected PhysicsManagerParticleData Particle { get; } // 0x0000000188954478-0x0000000188954498 
		protected PhysicsManagerBoneData Bone { get; } // 0x0000000182312EC0-0x0000000182312F00 
		protected PhysicsManagerMeshData Mesh { get; } // 0x0000000182313B50-0x0000000182313BD0 
		protected PhysicsManagerTeamData Team { get; } // 0x0000000182313AD0-0x0000000182313B50 
		protected PhysicsManagerWindData Wind { get; } // 0x000000018896A1FC-0x000000018896A21C 
		protected PhysicsManagerComponent Component { get; } // 0x0000000188998590-0x00000001889985B0 
		protected PhysicsManagerCompute Compute { get; } // 0x00000001889985B0-0x00000001889985D0 
	
		// Constructors
		protected PhysicsManagerAccess() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void SetParent(MagicaPhysicsManager manager) {} // 0x000000018426FEE0-0x000000018426FEF0
		public abstract void Create();
		public abstract void Dispose();
	}

	public class PhysicsManagerBoneData : PhysicsManagerAccess // TypeDefIndex: 51457
	{
		// Fields
		public const byte Flag_Reset = 1; // Metadata: 0x01FD1030
		public const byte Flag_Restore = 16; // Metadata: 0x01FD1031
		public const byte Flag_Write = 32; // Metadata: 0x01FD1032
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
	
		// Properties
		public bool hasBoneChanged { get; private set; } // 0x0000000183D583F0-0x0000000183D58400 0x0000000183D5A1B0-0x0000000183D5A1C0
		private CustomSampler SamplerReadBoneScale { get; set; } // 0x0000000183D4E7C0-0x0000000183D4E7D0 0x00000001858B4280-0x00000001858B4294
		public int RestoreBoneCount { get => default; } // 0x0000000188999FA0-0x0000000188999FC0 
		public int ReadBoneCount { get => default; } // 0x0000000188999F80-0x0000000188999FA0 
		public int WriteBoneCount { get => default; } // 0x0000000182312880-0x00000001823128D0 
	
		// Nested types
		[BurstCompile]
		private struct RestoreBoneJob : IJobParallelForTransform // TypeDefIndex: 51449
		{
			// Fields
			public bool fixedUpdate; // 0x00
			[ReadOnly]
			public NativeArray<short> boneUnityPhysicsList; // 0x08
			[ReadOnly]
			public NativeArray<byte> boneFlagList; // 0x18
			[ReadOnly]
			public NativeArray<float3> restoreBoneLocalPosList; // 0x28
			[ReadOnly]
			public NativeArray<quaternion> restoreBoneLocalRotList; // 0x38
			[ReadOnly]
			public NativeArray<int> restoreBoneIndexList; // 0x48
	
			// Methods
			public void Execute(int index, TransformAccess transform) {} // 0x00000001889A5AF8-0x00000001889A5BE0
		}
	
		[BurstCompile]
		private struct ReadBoneJob0 : IJobParallelForTransform // TypeDefIndex: 51450
		{
			// Fields
			public int fixedUpdateCount; // 0x00
			[WriteOnly]
			public NativeArray<float3> bonePosList; // 0x08
			[WriteOnly]
			public NativeArray<quaternion> boneRotList; // 0x18
			[WriteOnly]
			public NativeArray<float3> boneSclList; // 0x28
			public NativeArray<float3> basePosList; // 0x38
			public NativeArray<quaternion> baseRotList; // 0x48
			[WriteOnly]
			public NativeArray<float3> futurePosList; // 0x58
			[WriteOnly]
			public NativeArray<quaternion> futureRotList; // 0x68
			[ReadOnly]
			public NativeArray<short> boneUnityPhysicsList; // 0x78
			public NativeArray<byte> boneFlagList; // 0x88
	
			// Methods
			public void Execute(int index, TransformAccess transform) {} // 0x00000001889A50C0-0x00000001889A541C
		}
	
		[BurstCompile]
		private struct ReadBoneJob1 : IJobParallelForTransform // TypeDefIndex: 51451
		{
			// Fields
			public int fixedUpdateCount; // 0x00
			public float normalFutureRatio; // 0x04
			public float fixedFutureRatio; // 0x08
			public float normalDeltaTime; // 0x0C
			public float fixedDeltaTime; // 0x10
			[WriteOnly]
			public NativeArray<float3> bonePosList; // 0x18
			[WriteOnly]
			public NativeArray<quaternion> boneRotList; // 0x28
			[WriteOnly]
			public NativeArray<float3> boneSclList; // 0x38
			public NativeArray<float3> basePosList; // 0x48
			public NativeArray<quaternion> baseRotList; // 0x58
			[ReadOnly]
			public NativeArray<short> boneUnityPhysicsList; // 0x68
			public NativeArray<float3> futurePosList; // 0x78
			public NativeArray<quaternion> futureRotList; // 0x88
			public NativeArray<byte> boneFlagList; // 0x98
	
			// Methods
			public void Execute(int index, TransformAccess transform) {} // 0x00000001889A541C-0x00000001889A5930
		}
	
		[BurstCompile]
		private struct ConvertWorldToLocalJob : IJobParallelFor // TypeDefIndex: 51452
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> writeBoneIndexList; // 0x00
			[ReadOnly]
			public NativeArray<byte> boneFlagList; // 0x10
			[ReadOnly]
			public NativeArray<float3> bonePosList; // 0x20
			[ReadOnly]
			public NativeArray<quaternion> boneRotList; // 0x30
			[ReadOnly]
			public NativeArray<float3> boneSclList; // 0x40
			[ReadOnly]
			public NativeArray<int> boneParentIndexList; // 0x50
			[WriteOnly]
			public NativeArray<float3> writeBonePosList; // 0x60
			[WriteOnly]
			public NativeArray<quaternion> writeBoneRotList; // 0x70
	
			// Methods
			public void Execute(int index) {} // 0x0000000188996DC8-0x0000000188997080
		}
	
		[BurstCompile]
		private struct WriteBontToTransformJob2 : IJobParallelForTransform // TypeDefIndex: 51453
		{
			// Fields
			public int fixedUpdateCount; // 0x00
			[ReadOnly]
			public NativeArray<byte> boneFlagList; // 0x08
			[ReadOnly]
			public NativeArray<int> writeBoneIndexList; // 0x18
			[ReadOnly]
			public NativeArray<int> boneParentIndexList; // 0x28
			[ReadOnly]
			public NativeArray<float3> writeBonePosList; // 0x38
			[ReadOnly]
			public NativeArray<quaternion> writeBoneRotList; // 0x48
			[ReadOnly]
			public NativeArray<short> boneUnityPhysicsList; // 0x58
	
			// Methods
			public void Execute(int index, TransformAccess transform) {} // 0x00000001889A5FEC-0x00000001889A6148
		}
	
		[BurstCompile]
		private struct CopyBoneJob0 : IJobParallelFor // TypeDefIndex: 51454
		{
			// Fields
			[ReadOnly]
			public NativeArray<float3> bonePosList; // 0x00
			[ReadOnly]
			public NativeArray<quaternion> boneRotList; // 0x10
			[WriteOnly]
			public NativeArray<float3> backBonePosList; // 0x20
			[WriteOnly]
			public NativeArray<quaternion> backBoneRotList; // 0x30
	
			// Methods
			public void Execute(int index) {} // 0x0000000183D6E110-0x0000000183D6E160
		}
	
		[BurstCompile]
		private struct CopyBoneJob1 : IJobParallelFor // TypeDefIndex: 51455
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> writeBoneIndexList; // 0x00
			[WriteOnly]
			public NativeArray<int> backWriteBoneIndexList; // 0x10
	
			// Methods
			public void Execute(int index) {} // 0x0000000183D6E160-0x0000000183D6E180
		}
	
		[BurstCompile]
		private struct CopyBoneJob2 : IJobParallelFor // TypeDefIndex: 51456
		{
			// Fields
			[ReadOnly]
			public NativeArray<byte> boneFlagList; // 0x00
			[WriteOnly]
			public NativeArray<byte> backBoneFlagList; // 0x10
	
			// Methods
			public void Execute(int index) {} // 0x0000000183D6E180-0x0000000183D6E1A0
		}
	
		// Constructors
		public PhysicsManagerBoneData() {} // 0x0000000183770A70-0x0000000183770AF0
	
		// Methods
		public override void Create() {} // 0x0000000182E11160-0x0000000182E116B0
		public override void Dispose() {} // 0x00000001889991A4-0x00000001889993FC
		public int AddRestoreBone(Transform target, float3 lpos, quaternion lrot, int boneIndex) => default; // 0x0000000188998B00-0x0000000188998C2C
		public void RemoveRestoreBone(int restoreBoneIndex) {} // 0x0000000188999C64-0x0000000188999D34
		public int AddBone(Transform target, int pindex = -1 /* Metadata: 0x01FD102D */, bool addParent = false /* Metadata: 0x01FD102E */) => default; // 0x00000001889985D0-0x0000000188998B00
		public bool RemoveBone(int boneIndex, int pindex = -1 /* Metadata: 0x01FD102F */) => default; // 0x0000000188999934-0x0000000188999C64
		public void ChangeUnityPhysicsCount(int boneIndex, bool sw) {} // 0x0000000188998C2C-0x0000000188998CA4
		public void ResetFuturePrediction(int boneIndex) {} // 0x0000000188999F18-0x0000000188999F80
		public void ResetBoneFromTransform(bool fixedUpdate) {} // 0x0000000188999D34-0x0000000188999F18
		public void ReadBoneFromTransform() {} // 0x00000001889993FC-0x0000000188999934
		public void ConvertWorldToLocal() {} // 0x0000000188998CA4-0x0000000188998EF0
		public void WriteBoneToTransform(int bufferIndex) {} // 0x0000000182312780-0x0000000182312880
		public void CopyBoneBuffer() {} // 0x0000000188998EF0-0x00000001889991A4
	}

	public class PhysicsManagerComponent : PhysicsManagerAccess // TypeDefIndex: 51458
	{
		// Fields
		private readonly HashSet<CoreComponent> componentSet; // 0x18
		private HashSet<ParticleComponent> dataUpdateParticleSet; // 0x20
	
		// Properties
		public int ComponentCount { get => default; } // 0x000000018899A410-0x000000018899A450 
	
		// Constructors
		public PhysicsManagerComponent() {} // 0x0000000183770B70-0x0000000183770C30
	
		// Methods
		public override void Create() {} // 0x000000018350B670-0x000000018350B680
		public override void Dispose() {} // 0x000000018350B670-0x000000018350B680
		public List<CoreComponent> GetComponentList() => default; // 0x000000018899A164-0x000000018899A1D8
		public void ComponentAction(Action<CoreComponent> act) {} // 0x000000018899A014-0x000000018899A164
		public void UpdateComponentStatus() {} // 0x000000018899A2AC-0x000000018899A410
		public void AddComponent(CoreComponent comp) {} // 0x0000000188999FC0-0x000000018899A014
		public void RemoveComponent(CoreComponent comp) {} // 0x000000018899A1D8-0x000000018899A258
		internal void ReserveDataUpdateParticleComponent(ParticleComponent comp) {} // 0x000000018899A258-0x000000018899A2AC
		internal void DataUpdateParticleComponent() {} // 0x0000000182312630-0x0000000182312780
	}

	public class PhysicsManagerCompute : PhysicsManagerAccess // TypeDefIndex: 51462
	{
		// Fields
		private int solverIteration; // 0x18
		private List<PhysicsManagerConstraint> constraints; // 0x20
		private List<PhysicsManagerWorker> workers; // 0x88
		private JobHandle jobHandle; // 0xD0
		private bool runMasterJob; // 0xE0
		private int swapIndex; // 0xE4
	
		// Properties
		public ClampPositionConstraint ClampPosition { get; private set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public ClampDistanceConstraint ClampDistance { get; private set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public ClampRotationConstraint ClampRotation { get; private set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		public SpringConstraint Spring { get; private set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public RestoreDistanceConstraint RestoreDistance { get; private set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public RestoreRotationConstraint RestoreRotation { get; private set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public TriangleBendConstraint TriangleBend { get; private set; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000183081D30-0x0000000183081D40
		public ColliderCollisionConstraint Collision { get; private set; } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
		public PenetrationConstraint Penetration { get; private set; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
		public ColliderExtrusionConstraint ColliderExtrusion { get; private set; } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
		public TwistConstraint Twist { get; private set; } // 0x0000000183D4EB20-0x0000000183D4EB30 0x00000001851DFCA4-0x00000001851DFCB4
		public CompositeRotationConstraint CompositeRotation { get; private set; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 0x00000001851DFC94-0x00000001851DFCA4
		public RenderMeshWorker RenderMeshWorker { get; private set; } // 0x0000000183D4EA90-0x0000000183D4EAA0 0x00000001851DFCB4-0x00000001851DFCC8
		public VirtualMeshWorker VirtualMeshWorker { get; private set; } // 0x00000001811AC510-0x00000001811AC520 0x00000001851417AC-0x00000001851417C0
		public MeshParticleWorker MeshParticleWorker { get; private set; } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000184270264-0x0000000184270278
		public SpringMeshWorker SpringMeshWorker { get; private set; } // 0x0000000183D4EB10-0x0000000183D4EB20 0x000000018554A7F4-0x000000018554A808
		public AdjustRotationWorker AdjustRotationWorker { get; private set; } // 0x0000000183D4EAD0-0x0000000183D4EAE0 0x0000000182B47080-0x0000000182B470A0
		public LineWorker LineWorker { get; private set; } // 0x0000000183D4E750-0x0000000183D4E760 0x00000001858AAF64-0x00000001858AAF78
		public TriangleWorker TriangleWorker { get; private set; } // 0x0000000183D50E60-0x0000000183D50E70 0x00000001858B426C-0x00000001858B4280
		public BaseSkinningWorker BaseSkinningWorker { get; private set; } // 0x0000000183D4E7C0-0x0000000183D4E7D0 0x00000001858B4280-0x00000001858B4294
		public CustomSampler SamplerCalcMesh { get; set; } // 0x0000000183D50EA0-0x0000000183D50EB0 0x00000001856A2B64-0x00000001856A2B78
		public CustomSampler SamplerWriteMesh { get; set; } // 0x0000000183D51950-0x0000000183D51960 0x00000001858B408C-0x00000001858B40A0
		public JobHandle MasterJob { get => default; set {} } // 0x0000000183D5B210-0x0000000183D5B220 0x0000000183D5B220-0x0000000183D5B230
		public int SwapIndex { get => default; } // 0x0000000183D50E70-0x0000000183D50E80 
	
		// Nested types
		[BurstCompile]
		private struct ForceAndVelocityJob : IJobParallelFor // TypeDefIndex: 51459
		{
			// Fields
			public float updateDeltaTime; // 0x00
			public float updatePower; // 0x04
			public int runCount; // 0x08
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x10
			[ReadOnly]
			public NativeArray<CurveParam> teamMassList; // 0x20
			[ReadOnly]
			public NativeArray<CurveParam> teamGravityList; // 0x30
			[ReadOnly]
			public NativeArray<CurveParam> teamDragList; // 0x40
			[ReadOnly]
			public NativeArray<CurveParam> teamDepthInfluenceList; // 0x50
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.WindInfo> teamWindInfoList; // 0x60
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x70
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x80
			[ReadOnly]
			public NativeArray<float> depthList; // 0x90
			[ReadOnly]
			public NativeArray<float3> snapBasePosList; // 0xA0
			[ReadOnly]
			public NativeArray<quaternion> snapBaseRotList; // 0xB0
			[WriteOnly]
			public NativeArray<float3> basePosList; // 0xC0
			[WriteOnly]
			public NativeArray<quaternion> baseRotList; // 0xD0
			[ReadOnly]
			public NativeArray<float3> oldBasePosList; // 0xE0
			[ReadOnly]
			public NativeArray<quaternion> oldBaseRotList; // 0xF0
			public NativeArray<float3> nextPosList; // 0x100
			public NativeArray<quaternion> nextRotList; // 0x110
			public NativeArray<float> frictionList; // 0x120
			[WriteOnly]
			public NativeArray<float3> posList; // 0x130
			[WriteOnly]
			public NativeArray<quaternion> rotList; // 0x140
			[ReadOnly]
			public NativeArray<float3> oldPosList; // 0x150
			[ReadOnly]
			public NativeArray<quaternion> oldRotList; // 0x160
			[ReadOnly]
			public NativeArray<float3> velocityList; // 0x170
			[ReadOnly]
			public NativeArray<PhysicsManagerWindData.WindData> windDataList; // 0x180
			[ReadOnly]
			public NativeArray<float3> bonePosList; // 0x190
			[ReadOnly]
			public NativeArray<quaternion> boneRotList; // 0x1A0
	
			// Methods
			public void Execute(int index) {} // 0x0000000188997998-0x00000001889983A0
			private float3 Wind(int teamId, [IsReadOnly] in PhysicsManagerTeamData.TeamData teamData, [IsReadOnly] in float3 pos) => default; // 0x00000001889983A0-0x0000000188998590
		}
	
		[BurstCompile]
		private struct FixPositionJob : IJobParallelFor // TypeDefIndex: 51460
		{
			// Fields
			public float updatePower; // 0x00
			public float updateDeltaTime; // 0x04
			public int runCount; // 0x08
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x10
			[ReadOnly]
			public NativeArray<CurveParam> teamMaxVelocityList; // 0x20
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x30
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x40
			[ReadOnly]
			public NativeArray<float> depthList; // 0x50
			[ReadOnly]
			public NativeArray<float3> nextPosList; // 0x60
			[ReadOnly]
			public NativeArray<quaternion> nextRotList; // 0x70
			[ReadOnly]
			public NativeArray<float> frictionList; // 0x80
			public NativeArray<float3> velocityList; // 0x90
			[WriteOnly]
			public NativeArray<quaternion> rotList; // 0xA0
			public NativeArray<float3> oldPosList; // 0xB0
			public NativeArray<quaternion> oldRotList; // 0xC0
			public NativeArray<float3> posList; // 0xD0
			[WriteOnly]
			public NativeArray<float3> localPosList; // 0xE0
			[ReadOnly]
			public NativeArray<float3> collisionNormalList; // 0xF0
			public NativeArray<float> staticFrictionList; // 0x100
	
			// Methods
			public void Execute(int index) {} // 0x000000018899719C-0x0000000188997998
		}
	
		[BurstCompile]
		private struct PostUpdatePhysicsJob : IJobParallelFor // TypeDefIndex: 51461
		{
			// Fields
			public float updateDeltaTime; // 0x00
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x08
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x18
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x28
			[ReadOnly]
			public NativeArray<float3> snapBasePosList; // 0x38
			[ReadOnly]
			public NativeArray<quaternion> snapBaseRotList; // 0x48
			[ReadOnly]
			public NativeArray<float3> basePosList; // 0x58
			[ReadOnly]
			public NativeArray<quaternion> baseRotList; // 0x68
			[WriteOnly]
			public NativeArray<float3> oldBasePosList; // 0x78
			[WriteOnly]
			public NativeArray<quaternion> oldBaseRotList; // 0x88
			[ReadOnly]
			public NativeArray<float3> velocityList; // 0x98
			[ReadOnly]
			public NativeArray<float3> localPosList; // 0xA8
			public NativeArray<float3> oldPosList; // 0xB8
			public NativeArray<quaternion> oldRotList; // 0xC8
			[WriteOnly]
			public NativeArray<float3> posList; // 0xD8
			[WriteOnly]
			public NativeArray<quaternion> rotList; // 0xE8
			[ReadOnly]
			public NativeArray<float3> nextPosList; // 0xF8
			[ReadOnly]
			public NativeArray<quaternion> nextRotList; // 0x108
			public NativeArray<float3> oldSlowPosList; // 0x118
	
			// Methods
			public void Execute(int index) {} // 0x00000001889A4B24-0x00000001889A50C0
		}
	
		// Constructors
		public PhysicsManagerCompute() {} // 0x0000000183770C30-0x0000000183770D00
	
		// Methods
		public override void Create() {} // 0x0000000182E13DB0-0x0000000182E153B0
		public override void Dispose() {} // 0x000000018899A450-0x000000018899A674
		public void RemoveTeam(int teamId) {} // 0x000000018899AB04-0x000000018899ADAC
		internal void UpdateRestoreBone(PhysicsTeam.TeamUpdateMode updateMode) {} // 0x000000018899BC00-0x000000018899BC54
		internal void UpdateReadBone() {} // 0x0000000182312DD0-0x0000000182312E20
		internal void UpdateTeamAlways() {} // 0x0000000182312E20-0x0000000182312E60
		internal void UpdateStartSimulation(UpdateTimeManager update) {} // 0x0000000182312F00-0x0000000182313050
		internal void UpdateCompleteSimulation() {} // 0x0000000182312D10-0x0000000182312DD0
		internal void UpdateWriteBone() {} // 0x0000000182312E60-0x0000000182312EC0
		internal void MeshCalculation() {} // 0x00000001823139F0-0x0000000182313AD0
		internal void NormalWritingMesh() {} // 0x0000000182312C70-0x0000000182312D10
		internal void UpdateReadWriteBone() {} // 0x000000018899BB80-0x000000018899BC00
		internal void UpdateSyncBuffer() {} // 0x000000018899BDD0-0x000000018899BEFC
		internal void UpdateSwapBuffer() {} // 0x000000018899BC54-0x000000018899BDD0
		public void InitJob() {} // 0x0000000183D6E220-0x0000000183D6E230
		public void ScheduleJob() {} // 0x000000018899ADAC-0x000000018899ADB4
		public void CompleteJob() {} // 0x0000000182312920-0x0000000182312970
		private void UpdatePhysics(int updateCount, int runCount, float updatePower, float updateDeltaTime) {} // 0x000000018899ADB4-0x000000018899BB80
		private void PostUpdatePhysics(float updateDeltaTime) {} // 0x000000018899A674-0x000000018899AB04
		private void WarmupWorker() {} // 0x000000018899BEFC-0x000000018899BF94
	}

	public abstract class PhysicsManagerConstraint // TypeDefIndex: 51463
	{
		// Fields
		[Range(1f, 4f)]
		public int iteration; // 0x10
	
		// Properties
		public MagicaPhysicsManager Manager { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		protected PhysicsManagerConstraint() {} // 0x0000000183D51DD0-0x0000000183D51DE0
	
		// Methods
		public void Init(MagicaPhysicsManager manager) {} // 0x0000000182E153B0-0x0000000182E153E0
		public abstract void Create();
		public abstract void RemoveTeam(int teamId);
		public abstract void Release();
		public virtual int GetIterationCount() => default; // 0x0000000183D4E340-0x0000000183D4E350
		public abstract JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle);
	}

	public class PhysicsManagerMeshData : PhysicsManagerAccess // TypeDefIndex: 51472
	{
		// Fields
		public const uint MeshFlag_Active = 1; // Metadata: 0x01FD1033
		public const uint MeshFlag_Skinning = 4; // Metadata: 0x01FD1034
		public const uint Meshflag_CalcNormal = 8; // Metadata: 0x01FD1035
		public const uint Meshflag_CalcTangent = 16; // Metadata: 0x01FD1036
		public const uint Meshflag_Pause = 32; // Metadata: 0x01FD1037
		public const uint MeshFlag_ExistNormals = 65536; // Metadata: 0x01FD1038
		public const uint MeshFlag_ExistTangents = 131072; // Metadata: 0x01FD103C
		public const uint MeshFlag_ExistWeights = 262144; // Metadata: 0x01FD1040
		public const uint MeshFlag_UpdateUseVertexFront = 16777216; // Metadata: 0x01FD1044
		public const uint MeshFlag_UpdateUseVertexBack = 33554432; // Metadata: 0x01FD1048
		public const uint MeshFlag_FasterWrite = 67108864; // Metadata: 0x01FD104C
		public const uint MeshFlag_MeshLink = 268435456; // Metadata: 0x01FD1050
		public FixedNativeList<SharedVirtualMeshInfo> sharedVirtualMeshInfoList; // 0x18
		public Dictionary<int, int> sharedVirtualMeshIdToIndexDict; // 0x20
		public FixedChunkNativeArray<float2> sharedVirtualUvList; // 0x28
		public FixedChunkNativeArray<uint> sharedVirtualVertexInfoList; // 0x30
		public FixedChunkNativeArray<MeshData.VertexWeight> sharedVirtualWeightList; // 0x38
		public FixedChunkNativeArray<int> sharedVirtualTriangleList; // 0x40
		public FixedChunkNativeArray<uint> sharedVirtualVertexToTriangleInfoList; // 0x48
		public FixedChunkNativeArray<int> sharedVirtualVertexToTriangleIndexList; // 0x50
		public const byte VirtualVertexFlag_Use = 1; // Metadata: 0x01FD1054
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
		public const uint RenderVertexFlag_Use = 65536; // Metadata: 0x01FD1055
		public const int MaxRenderMeshLinkCount = 4; // Metadata: 0x01FD1059
		public FixedNativeList<RenderMeshInfo> renderMeshInfoList; // 0x110
		public const uint RenderStateFlag_Use = 1; // Metadata: 0x01FD105A
		public const uint RenderStateFlag_ExistNormal = 2; // Metadata: 0x01FD105B
		public const uint RenderStateFlag_ExistTangent = 4; // Metadata: 0x01FD105C
		public const uint RenderStateFlag_FasterWrite = 8; // Metadata: 0x01FD105D
		public const uint RenderStateFlag_DelayedCalculated = 256; // Metadata: 0x01FD105E
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
		public int SharedVirtualMeshCount { get => default; } // 0x00000001889A2880-0x00000001889A28C8 
		public int VirtualMeshCount { get => default; } // 0x0000000182312B10-0x0000000182312B80 
		public int VirtualMeshVertexCount { get => default; } // 0x00000001889A2A8C-0x00000001889A2B08 
		public int VirtualMeshTriangleCount { get => default; } // 0x00000001889A296C-0x00000001889A29E8 
		public int VirtualMeshVertexUseCount { get => default; } // 0x00000001889A2B08-0x00000001889A2B90 
		public int VirtualMeshUseCount { get => default; } // 0x00000001889A29E8-0x00000001889A2A8C 
		public int VirtualMeshPauseCount { get => default; } // 0x00000001889A28C8-0x00000001889A296C 
		public int SharedRenderMeshCount { get => default; } // 0x00000001889A2838-0x00000001889A2880 
		public int SharedChildMeshCount { get => default; } // 0x00000001889A27F0-0x00000001889A2838 
		public int RenderMeshCount { get => default; } // 0x00000001889A22E8-0x00000001889A2330 
		public int RenderMeshVertexCount { get => default; } // 0x00000001889A25D4-0x00000001889A26AC 
		public int RenderMeshUseCount { get => default; } // 0x00000001889A247C-0x00000001889A25D4 
		public int RenderMeshVertexUseCount { get => default; } // 0x00000001889A26AC-0x00000001889A27F0 
		public int RenderMeshPauseCount { get => default; } // 0x00000001889A2330-0x00000001889A247C 
	
		// Nested types
		public struct SharedVirtualMeshInfo // TypeDefIndex: 51464
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
	
		public struct VirtualMeshInfo // TypeDefIndex: 51465
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
			public bool IsFlag(uint flag) => default; // 0x00000001889A59FC-0x00000001889A5A04
			public void SetFlag(uint flag, bool sw) {} // 0x00000001889A5ACC-0x00000001889A5AE0
			public bool IsActive() => default; // 0x0000000184275E20-0x0000000184275E28
			public bool IsUse() => default; // 0x00000001889A5C9C-0x00000001889A5CB4
			public bool IsPause() => default; // 0x00000001854E505C-0x00000001854E5064
		}
	
		public struct SharedChildMeshInfo // TypeDefIndex: 51466
		{
			// Fields
			public long cuid; // 0x00
			public int sharedVirtualMeshIndex; // 0x08
			public int virtualMeshIndex; // 0x0C
			public int meshUseCount; // 0x10
			public ChunkData vertexChunk; // 0x14
			public ChunkData weightChunk; // 0x24
		}
	
		public struct SharedRenderMeshInfo // TypeDefIndex: 51467
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
			public bool IsFlag(uint flag) => default; // 0x00000001889A5BE0-0x00000001889A5BE8
			public void SetFlag(uint flag, bool sw) {} // 0x00000001889A5BF0-0x00000001889A5C08
			public bool IsSkinning() => default; // 0x00000001889A5BE8-0x00000001889A5BF0
		}
	
		public struct RenderMeshInfo // TypeDefIndex: 51468
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
			public bool IsFlag(uint flag) => default; // 0x00000001889A59FC-0x00000001889A5A04
			public void SetFlag(uint flag, bool sw) {} // 0x00000001889A5ACC-0x00000001889A5AE0
			public bool IsActive() => default; // 0x0000000184275E20-0x0000000184275E28
			public bool IsUse() => default; // 0x00000001889A5A1C-0x00000001889A5A2C
			public bool IsLinkMesh(int index) => default; // 0x00000001889A5A04-0x00000001889A5A1C
			public bool IsPause() => default; // 0x00000001854E505C-0x00000001854E5064
			public bool IsFasterWrite() => default; // 0x00000001889A59F0-0x00000001889A59FC
			public bool IsSkinning() => default; // 0x00000001854E5054-0x00000001854E505C
			public bool AddLinkMesh(int renderMeshIndex, int childMeshVertexStart, int childMeshWeightStart, int virtualMeshVertexStart, int sharedVirtualMeshVertexStart) => default; // 0x00000001889A5930-0x00000001889A59F0
			public bool RemoveLinkMesh(int renderMeshIndex, int childMeshVertexStart, int childMeshWeightStart, int virtualMeshVertexStart, int sharedVirtualMeshVertexStart) => default; // 0x00000001889A5A2C-0x00000001889A5ACC
		}
	
		public class RenderMeshState // TypeDefIndex: 51469
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
			public RenderMeshState() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public bool IsFlag(uint flag) => default; // 0x0000000185D623EC-0x0000000185D623F4
			public void SetFlag(uint flag, bool sw) {} // 0x00000001889A5AE0-0x00000001889A5AF8
		}
	
		[BurstCompile]
		private struct CopyRenderBuffer : IJobParallelFor // TypeDefIndex: 51470
		{
			// Fields
			[ReadOnly]
			public NativeArray<float3> renderPosList; // 0x00
			[ReadOnly]
			public NativeArray<float3> renderNormalList; // 0x10
			[WriteOnly]
			public NativeArray<float3> renderPosArray; // 0x20
			[WriteOnly]
			public NativeArray<float3> renderNormalArray; // 0x30
	
			// Methods
			public void Execute(int index) {} // 0x0000000183D6E1A0-0x0000000183D6E200
		}
	
		// Constructors
		public PhysicsManagerMeshData() {} // 0x0000000183770D00-0x0000000183770F70
	
		// Methods
		public override void Create() {} // 0x0000000183541480-0x0000000183541E60
		public override void Dispose() {} // 0x000000018899E940-0x000000018899EE04
		public void AddMesh(BaseMeshDeformer bmesh) {} // 0x000000018899BF94-0x000000018899C00C
		public void RemoveMesh(BaseMeshDeformer bmesh) {} // 0x000000018899FAC0-0x000000018899FB44
		public int AddVirtualMesh(int uid, int vertexCount, int weightCount, int boneCount, int triangleCount, int vertexToTriangleIndexCount, Transform transform) => default; // 0x000000018899D02C-0x000000018899D5D4
		public bool IsEmptySharedVirtualMesh(int uid) => default; // 0x000000018899F31C-0x000000018899F374
		public void SetSharedVirtualMeshData(int virtualMeshIndex, uint[] sharedVertexInfoList, MeshData.VertexWeight[] sharedWeightList, Vector2[] sharedUv, int[] sharedTriangles, uint[] vertexToTriangleInfoList, int[] vertexToTriangleIndexList) {} // 0x00000001889A18F8-0x00000001889A1B98
		public void RemoveVirtualMesh(int virtualMeshIndex) {} // 0x00000001889A08BC-0x00000001889A0D88
		public bool ExistsVirtualMesh(int virtualMeshIndex) => default; // 0x000000018899EE04-0x000000018899EE58
		public VirtualMeshInfo GetVirtualMeshInfo(int virtualMeshIndex) => default; // 0x000000018899F0C8-0x000000018899F150
		public bool IsUseVirtualMesh(int virtualMeshIndex) => default; // 0x000000018899F4D0-0x000000018899F560
		public bool IsActiveVirtualMesh(int virtualMeshIndex) => default; // 0x000000018899F20C-0x000000018899F268
		public void SetVirtualMeshActive(int virtualMeshIndex, bool sw) {} // 0x00000001889A1B98-0x00000001889A1C80
		public void AddUseVirtualMesh(int virtualMeshIndex) {} // 0x000000018899CBEC-0x000000018899CCC8
		public void RemoveUseVirtualMesh(int virtualMeshIndex) {} // 0x00000001889A047C-0x00000001889A0558
		public bool AddUseVirtualVertex(int virtualMeshIndex, int vindex, bool fix) => default; // 0x000000018899CCC8-0x000000018899CE3C
		public bool RemoveUseVirtualVertex(int virtualMeshIndex, int vindex, bool fix) => default; // 0x00000001889A0558-0x00000001889A06CC
		public void CopyToVirtualMeshWorldData(int virtualMeshIndex, Vector3[] vertices, Vector3[] normals, Vector3[] tangents) {} // 0x000000018899E27C-0x000000018899E4D8
		public void AddVirtualMeshBone(int virtualMeshIndex, List<Transform> boneList) {} // 0x000000018899CE3C-0x000000018899D02C
		public void RemoveVirtualMeshBone(int virtualMeshIndex) {} // 0x00000001889A06CC-0x00000001889A08BC
		public void ResetFuturePredictionVirtualMeshBone(int virtualMeshIndex) {} // 0x00000001889A0D88-0x00000001889A0E88
		public void ChangeVirtualMeshUseUnityPhysics(int virtualMeshIndex, bool sw) {} // 0x000000018899D710-0x000000018899D85C
		public void SetVirtualMeshFlag(int virtualMeshIndex, uint flag, bool sw) {} // 0x00000001889A1C80-0x00000001889A1D74
		public int AddSharedChildMesh(long cuid, int virtualMeshIndex, int vertexCount, int weightCount) => default; // 0x000000018899C79C-0x000000018899CA2C
		public bool IsEmptySharedChildMesh(long cuid) => default; // 0x000000018899F268-0x000000018899F2C4
		public void SetSharedChildMeshData(int sharedMeshIndex, uint[] sharedVertexInfoList, MeshData.VertexWeight[] sharedVertexWeightList) {} // 0x00000001889A17E0-0x00000001889A18F8
		public void RemoveSharedChildMesh(int sharedChildMeshIndex) {} // 0x00000001889A0148-0x00000001889A02BC
		public int AddRenderMesh(int uid, bool isSkinning, bool isFasterWrite, Vector3 baseScale, int vertexCount, int rendererBoneIndex, int boneWeightCount) => default; // 0x000000018899C17C-0x000000018899C79C
		public void UpdateMeshState(int renderMeshIndex) {} // 0x00000001889A1FA4-0x00000001889A205C
		public void AddRenderMeshBone(int renderMeshIndex, Transform rendererTransform) {} // 0x000000018899C00C-0x000000018899C17C
		public bool IsEmptySharedRenderMesh(int uid) => default; // 0x000000018899F2C4-0x000000018899F31C
		public void SetRenderSharedMeshData(int renderMeshIndex, bool isSkinning, Vector3[] sharedVertices, Vector3[] sharedNormals, Vector4[] sharedTangents, NativeArray<byte> sharedBonesPerVertex, NativeArray<BoneWeight1> sharedBoneWeights) {} // 0x00000001889A1364-0x00000001889A17E0
		public void RemoveRenderMesh(int renderMeshIndex) {} // 0x000000018899FCA8-0x00000001889A0148
		public void RemoveRenderMeshBone(int renderMeshIndex) {} // 0x000000018899FB44-0x000000018899FCA8
		public void ChangeRenderMeshUseUnityPhysics(int renderMeshIndex, bool sw) {} // 0x000000018899D5D4-0x000000018899D710
		public bool IsUseRenderMesh(int renderMeshIndex) => default; // 0x000000018899F46C-0x000000018899F4D0
		public bool IsActiveRenderMesh(int renderMeshIndex) => default; // 0x000000018899F150-0x000000018899F20C
		public void SetRenderMeshFlag(int renderMeshIndex, uint flag, bool sw) {} // 0x00000001889A11E4-0x00000001889A1364
		public bool IsRenderMeshFlag(int renderMeshIndex, uint flag) => default; // 0x000000018899F374-0x000000018899F46C
		public void SetRenderMeshActive(int renderMeshIndex, bool sw) {} // 0x00000001889A0FF0-0x00000001889A11E4
		public void AddUseRenderMesh(int renderMeshIndex) {} // 0x000000018899CA2C-0x000000018899CBEC
		public void RemoveUseRenderMesh(int renderMeshIndex) {} // 0x00000001889A02BC-0x00000001889A047C
		public void LinkRenderMesh(int renderMeshIndex, int childMeshVertexStart, int childMeshWeightStart, int virtualMeshVertexStart, int sharedVirtualMeshVertexStart) {} // 0x000000018899F560-0x000000018899F764
		public void UnlinkRenderMesh(int renderMeshIndex, int childMeshVertexStart, int childMeshWeightStart, int virtualMeshVertexStart, int sharedVirtualMeshVertexStart) {} // 0x00000001889A1D74-0x00000001889A1FA4
		internal void CopyToRenderMeshLocalPositionData(int renderMeshIndex, Mesh mesh, int bufferIndex) {} // 0x000000018899DB74-0x000000018899DC64
		internal void CopyToRenderMeshLocalNormalTangentData(int renderMeshIndex, Mesh mesh, int bufferIndex, bool normal, bool tangent) {} // 0x000000018899D9E0-0x000000018899DB74
		internal void CopyToRenderMeshBoneWeightData(int renderMeshIndex, Mesh mesh, Mesh sharedMesh, int bufferIndex) {} // 0x000000018899D85C-0x000000018899D9E0
		internal void CopyToRenderMeshWorldData(int renderMeshIndex, Transform target, Vector3[] vertices, Vector3[] normals, Vector3[] tangents) {} // 0x000000018899DC64-0x000000018899DFD4
		internal List<int> GetVertexUseList(int renderMeshIndex) => default; // 0x000000018899EEFC-0x000000018899F0C8
		internal void SetDelayedCalculatedFlag() {} // 0x00000001889A0E88-0x00000001889A0FF0
		internal void ClearWritingList() {} // 0x0000000182312340-0x0000000182312630
		internal void MeshCalculation(int bufferIndex) {} // 0x000000018899F764-0x000000018899F958
		internal void NormalWriting(int bufferIndex) {} // 0x000000018899F958-0x000000018899FAC0
		internal void CopyToRenderVertexBuffer(int renderMeshIndex, int bufferIndex, GraphicsBuffer vertexBuffer, bool normal, ComputeShader compute, int kernel, int index) {} // 0x000000018899DFD4-0x000000018899E27C
		internal void UpdateVertexBuffer() {} // 0x00000001889A205C-0x00000001889A22E8
		internal void FinishVertexBuffer() {} // 0x0000000182312A00-0x0000000182312A50
		internal void FasterWriting(int bufferIndex) {} // 0x000000018899EE58-0x000000018899EEFC
		private void DispatchWriting(int kernel, List<RenderMeshDeformer> rlist, int bufferIndex) {} // 0x000000018899E4D8-0x000000018899E940
	}

	public class PhysicsManagerParticleData : PhysicsManagerAccess // TypeDefIndex: 51477
	{
		// Fields
		public const uint Flag_Enable = 1; // Metadata: 0x01FD1060
		public const uint Flag_Kinematic = 2; // Metadata: 0x01FD1061
		public const uint Flag_Hold = 4; // Metadata: 0x01FD1062
		public const uint Flag_Collider = 16; // Metadata: 0x01FD1063
		public const uint Flag_Plane = 32; // Metadata: 0x01FD1064
		public const uint Flag_CapsuleX = 64; // Metadata: 0x01FD1065
		public const uint Flag_CapsuleY = 128; // Metadata: 0x01FD1066
		public const uint Flag_CapsuleZ = 256; // Metadata: 0x01FD1068
		public const uint Flag_Box = 512; // Metadata: 0x01FD106A
		public const uint Flag_TriangleRotation = 1024; // Metadata: 0x01FD106C
		public const uint Flag_Transform_Read_Pos = 4096; // Metadata: 0x01FD106E
		public const uint Flag_Transform_Read_Rot = 8192; // Metadata: 0x01FD1070
		public const uint Flag_Transform_Read_Base = 16384; // Metadata: 0x01FD1072
		public const uint Flag_Transform_Read_Local = 32768; // Metadata: 0x01FD1076
		public const uint Flag_Transform_Read_Scl = 65536; // Metadata: 0x01FD107A
		public const uint Flag_Transform_Write = 131072; // Metadata: 0x01FD107E
		public const uint Flag_Transform_Restore = 262144; // Metadata: 0x01FD1082
		public const uint Flag_Transform_UnityPhysics = 524288; // Metadata: 0x01FD1086
		public const uint Flag_Transform_Parent = 1048576; // Metadata: 0x01FD108A
		public const uint Flag_Step_Update = 16777216; // Metadata: 0x01FD108E
		public const uint Flag_Reset_Position = 33554432; // Metadata: 0x01FD1092
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
		public int Count { get => default; } // 0x00000001889A4A1C-0x00000001889A4A74 
		public int Length { get => default; } // 0x00000001889A4AAC-0x00000001889A4AEC 
		public int ColliderCount { get => default; } // 0x0000000183D59CE0-0x0000000183D59CF0 
		public FixedChunkNativeArray<float3> InNextPosList { get => default; } // 0x00000001889A4A74-0x00000001889A4A90 
		public FixedChunkNativeArray<float3> OutNextPosList { get => default; } // 0x00000001889A4AEC-0x00000001889A4B08 
		public FixedChunkNativeArray<quaternion> InNextRotList { get => default; } // 0x00000001889A4A90-0x00000001889A4AAC 
		public FixedChunkNativeArray<quaternion> OutNextRotList { get => default; } // 0x00000001889A4B08-0x00000001889A4B24 
	
		// Nested types
		public struct ParticleFlag // TypeDefIndex: 51473
		{
			// Fields
			public uint flag; // 0x00
	
			// Constructors
			public ParticleFlag(params uint[] flags) {
				flag = default;
			} // 0x0000000183542BB0-0x0000000183542BF0
	
			// Methods
			public bool IsFlag(uint flag) => default; // 0x00000001889A59FC-0x00000001889A5A04
			public void SetFlag(uint flag, bool sw) {} // 0x00000001889A5ACC-0x00000001889A5AE0
			public bool IsValid() => default; // 0x00000001889AFF0C-0x00000001889AFF14
			public void SetEnable(bool sw) {} // 0x0000000183542D60-0x0000000183542D80
			public bool IsFixed() => default; // 0x00000001889AFED0-0x00000001889AFED8
			public bool IsMove() => default; // 0x00000001889AFEE0-0x00000001889AFEE8
			public bool IsKinematic() => default; // 0x00000001889AFED8-0x00000001889AFEE0
			public bool IsHold() => default; // 0x00000001854E5054-0x00000001854E505C
			public bool IsCollider() => default; // 0x0000000183542BA0-0x0000000183542BB0
			public bool IsReadTransform() => default; // 0x0000000183542D40-0x0000000183542D50
			public bool IsWriteTransform() => default; // 0x00000001889AFF14-0x00000001889AFF20
			public bool IsRestoreTransform() => default; // 0x0000000183542D50-0x0000000183542D60
			public bool IsUnityPhysics() => default; // 0x00000001889AFF00-0x00000001889AFF0C
			public bool IsReadSclTransform() => default; // 0x00000001889AFEF4-0x00000001889AFF00
			public bool IsParentTransform() => default; // 0x00000001889AFEE8-0x00000001889AFEF4
		}
	
		[BurstCompile]
		private struct CopyBoneToParticleJob : IJobParallelFor // TypeDefIndex: 51474
		{
			// Fields
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamData; // 0x00
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.WorldInfluence> teamWorldInfluenceList; // 0x10
			[ReadOnly]
			public NativeArray<ParticleFlag> flagList; // 0x20
			[ReadOnly]
			public NativeArray<float> depthList; // 0x30
			[ReadOnly]
			public NativeArray<int> transformIndexList; // 0x40
			[ReadOnly]
			public NativeArray<float3> localPosList; // 0x50
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x60
			public NativeArray<float3> velocityList; // 0x70
			[ReadOnly]
			public NativeArray<float3> bonePosList; // 0x80
			[ReadOnly]
			public NativeArray<quaternion> boneRotList; // 0x90
			[ReadOnly]
			public NativeArray<float3> boneSclList; // 0xA0
			public NativeArray<float3> posList; // 0xB0
			public NativeArray<float3> oldPosList; // 0xC0
			public NativeArray<quaternion> oldRotList; // 0xD0
			public NativeArray<float3> oldSlowPosList; // 0xE0
			[WriteOnly]
			public NativeArray<quaternion> rotList; // 0xF0
			[WriteOnly]
			public NativeArray<float3> snapBasePosList; // 0x100
			[WriteOnly]
			public NativeArray<quaternion> snapBaseRotList; // 0x110
			public NativeArray<float3> oldBasePosList; // 0x120
			public NativeArray<quaternion> oldBaseRotList; // 0x130
			[WriteOnly]
			public NativeArray<float3> nextPosList; // 0x140
	
			// Methods
			public void Execute(int index) {} // 0x00000001889AAD64-0x00000001889AB674
		}
	
		[BurstCompile]
		private struct ResetParticleJob : IJobParallelFor // TypeDefIndex: 51475
		{
			// Fields
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamData; // 0x00
			public NativeArray<ParticleFlag> flagList; // 0x10
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x20
			[ReadOnly]
			public NativeArray<float3> snapBasePosList; // 0x30
			[ReadOnly]
			public NativeArray<quaternion> snapBaseRotList; // 0x40
			[WriteOnly]
			public NativeArray<float3> basePosList; // 0x50
			[WriteOnly]
			public NativeArray<quaternion> baseRotList; // 0x60
			[WriteOnly]
			public NativeArray<float3> oldBasePosList; // 0x70
			[WriteOnly]
			public NativeArray<quaternion> oldBaseRotList; // 0x80
			[WriteOnly]
			public NativeArray<float3> posList; // 0x90
			[WriteOnly]
			public NativeArray<quaternion> rotList; // 0xA0
			[WriteOnly]
			public NativeArray<float3> oldPosList; // 0xB0
			[WriteOnly]
			public NativeArray<quaternion> oldRotList; // 0xC0
			[WriteOnly]
			public NativeArray<float3> oldSlowPosList; // 0xD0
			[WriteOnly]
			public NativeArray<float3> velocityList; // 0xE0
			[WriteOnly]
			public NativeArray<float3> nextPosList; // 0xF0
			[WriteOnly]
			public NativeArray<quaternion> nextRotList; // 0x100
			[WriteOnly]
			public NativeArray<float3> localPosList; // 0x110
	
			// Methods
			public void Execute(int index) {} // 0x00000001889B9C48-0x00000001889B9E2C
		}
	
		[BurstCompile]
		private struct CopyParticleToBoneJob : IJobParallelFor // TypeDefIndex: 51476
		{
			// Fields
			[ReadOnly]
			public NativeArray<ParticleFlag> flagList; // 0x00
			[ReadOnly]
			public NativeArray<float3> posList; // 0x10
			[ReadOnly]
			public NativeArray<quaternion> rotList; // 0x20
			[ReadOnly]
			public NativeArray<float3> boneBasePosList; // 0x30
			[ReadOnly]
			public NativeArray<quaternion> boneBaseRotList; // 0x40
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x50
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x60
			[ReadOnly]
			public NativeParallelMultiHashMap<int, int> transformParticleIndexMap; // 0x70
			[ReadOnly]
			public NativeArray<int> writeBoneIndexList; // 0x80
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> bonePosList; // 0x90
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<quaternion> boneRotList; // 0xA0
	
			// Methods
			public void Execute(int index) {} // 0x00000001889AB674-0x00000001889AB9EC
		}
	
		// Constructors
		public PhysicsManagerParticleData() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void Create() {} // 0x0000000183541E60-0x00000001835425C0
		public override void Dispose() {} // 0x00000001889A3564-0x00000001889A3880
		public ChunkData CreateParticle(uint flag, int team, float3 wpos, quaternion wrot, float depth, float3 radius, float3 targetLocalPos) => default; // 0x00000001835425C0-0x0000000183542BA0
		public ChunkData CreateParticle(int team, int count, Func<int, uint> funcFlag, Func<int, float3> funcWpos, Func<int, quaternion> funcWrot, Func<int, float> funcDepth, Func<int, float3> funcRadius, Func<int, float3> funcTargetLocalPos) => default; // 0x00000001889A2B90-0x00000001889A3564
		public void RemoveParticle(ChunkData c) {} // 0x00000001889A3938-0x00000001889A3D40
		public void SetEnable(ChunkData c, bool sw, Func<int, Transform> funcTarget, Func<int, float3> funcLpos, Func<int, quaternion> funcLrot) {} // 0x0000000183542BF0-0x0000000183542D40
		public void SetRadius(int index, float3 radius) {} // 0x00000001889A3E94-0x00000001889A3F04
		public void SetLocalPos(int index, Vector3 lpos) {} // 0x00000001889A3E00-0x00000001889A3E94
		public bool IsValid(int index) => default; // 0x00000001889A38D0-0x00000001889A3938
		public int GetTeamId(int index) => default; // 0x00000001889A3880-0x00000001889A38D0
		public void ResetFuturePredictionTransform(int index) {} // 0x00000001889A3D90-0x00000001889A3E00
		public void ResetFuturePredictionTransform(ChunkData c) {} // 0x00000001889A3D40-0x00000001889A3D90
		public void SwitchingNextPosList() {} // 0x0000000183D6E230-0x0000000183D6E250
		public void SwitchingNextRotList() {} // 0x0000000183D6E250-0x0000000183D6E270
		public void UpdateBoneToParticle() {} // 0x00000001889A3F04-0x00000001889A4338
		public void UpdateResetParticle() {} // 0x00000001889A46C8-0x00000001889A4A1C
		public bool UpdateParticleToBone() => default; // 0x00000001889A4338-0x00000001889A46C8
	}

	public class PhysicsManagerTeamData : PhysicsManagerAccess // TypeDefIndex: 51485
	{
		// Fields
		public const uint Flag_Enable = 1; // Metadata: 0x01FD109A
		public const uint Flag_Interpolate = 2; // Metadata: 0x01FD109B
		public const uint Flag_FixedNonRotation = 4; // Metadata: 0x01FD109C
		public const uint Flag_AnimatedPose = 8; // Metadata: 0x01FD109D
		public const uint Flag_IgnoreClampPositionVelocity = 16; // Metadata: 0x01FD109E
		public const uint Flag_Collision = 32; // Metadata: 0x01FD109F
		public const uint Flag_AfterCollision = 64; // Metadata: 0x01FD10A0
		public const uint Flag_UpdatePhysics = 128; // Metadata: 0x01FD10A1
		public const uint Flag_Pause = 256; // Metadata: 0x01FD10A3
		public const uint Flag_Reset_WorldInfluence = 65536; // Metadata: 0x01FD10A5
		public const uint Flag_Reset_Position = 131072; // Metadata: 0x01FD10A9
		public const uint Flag_Reset_Keep = 524288; // Metadata: 0x01FD10AD
		public const uint Flag_Wind = 1048576; // Metadata: 0x01FD10B1
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
		public int TeamCount { get => default; } // 0x00000001889B46B8-0x00000001889B4700 
		public int TeamLength { get => default; } // 0x00000001889B4700-0x00000001889B4740 
		public int ActiveTeamCount { get => default; } // 0x0000000183D4F0C0-0x0000000183D4F0D0 
		public int ColliderCount { get => default; } // 0x00000001889B4574-0x00000001889B45C0 
		public int NormalUpdateCount { get => default; } // 0x0000000183D4F0D0-0x0000000183D4F0E0 
		public int PhysicsUpdateCount { get => default; } // 0x0000000183D4EC40-0x0000000183D4EC50 
		public int PauseCount { get => default; } // 0x00000001889B45C0-0x00000001889B46B8 
	
		// Nested types
		public enum ForceMode // TypeDefIndex: 51478
		{
			None = 0,
			VelocityAdd = 1,
			VelocityChange = 2,
			VelocityAddWithoutMass = 10,
			VelocityChangeWithoutMass = 11
		}
	
		public struct TeamData // TypeDefIndex: 51479
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
			public bool IsActive() => default; // 0x00000001859CF6F8-0x00000001859CF700
			public bool IsRunning() => default; // 0x00000001889BA9E0-0x00000001889BA9EC
			public bool IsUpdate(int runCount) => default; // 0x00000001889BA9EC-0x00000001889BA9F8
			public bool IsInterpolate() => default; // 0x00000001859CF700-0x00000001859CF708
			public bool IsPhysicsUpdate() => default; // 0x00000001889BA9C8-0x00000001889BA9D4
			public bool IsFlag(uint flag) => default; // 0x00000001889BA9B4-0x00000001889BA9BC
			public void SetFlag(uint flag, bool sw) {} // 0x00000001889BA9F8-0x00000001889BAA10
			public bool IsReset() => default; // 0x00000001889BA9D4-0x00000001889BA9E0
			public bool IsPause() => default; // 0x00000001889BA9BC-0x00000001889BA9C8
		}
	
		public struct WorldInfluence // TypeDefIndex: 51480
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
	
		public struct WindInfo // TypeDefIndex: 51481
		{
			// Fields
			public int windCount; // 0x00
			public int4 windDataIndexList; // 0x04
			public float3x4 windDirectionList; // 0x14
			public float4 windMainList; // 0x44
		}
	
		[BurstCompile]
		private struct PreProcessTeamDataJob : IJobParallelFor // TypeDefIndex: 51482
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
			[ReadOnly]
			public NativeArray<float3> bonePosList; // 0x50
			[ReadOnly]
			public NativeArray<quaternion> boneRotList; // 0x60
			[ReadOnly]
			public NativeArray<float3> boneSclList; // 0x70
			public int windCount; // 0x80
			[ReadOnly]
			public NativeArray<PhysicsManagerWindData.WindData> windData; // 0x88
	
			// Methods
			public void Execute(int teamId) {} // 0x00000001889B620C-0x00000001889B70B0
			private void UpdateTime(ref TeamData tdata, bool reset, float dtime) {} // 0x00000001889B70B0-0x00000001889B71A4
			private void Wind(ref TeamData tdata, float3 pos, int teamId) {} // 0x00000001889B71A4-0x00000001889B7680
		}
	
		[BurstCompile]
		private struct PostProcessTeamDataJob : IJobParallelFor // TypeDefIndex: 51483
		{
			// Fields
			public int fixedUpdateCount; // 0x00
			public NativeArray<TeamData> teamData; // 0x08
			public NativeArray<WorldInfluence> teamWorldInfluenceList; // 0x18
	
			// Methods
			public void Execute(int index) {} // 0x00000001889B5F08-0x00000001889B620C
		}
	
		// Constructors
		public PhysicsManagerTeamData() {} // 0x0000000183770AF0-0x0000000183770B70
	
		// Methods
		public override void Create() {} // 0x000000018243DC60-0x000000018243DF20
		public override void Dispose() {} // 0x00000001889B1340-0x00000001889B14B4
		public int CreateTeam(PhysicsTeam team, uint flag) => default; // 0x000000018243DF20-0x000000018243E420
		public void RemoveTeam(int teamId) {} // 0x00000001889B22D0-0x00000001889B2424
		public void SetEnable(int teamId, bool sw) {} // 0x00000001889B30E0-0x00000001889B3108
		public bool IsValid(int teamId) => default; // 0x00000001889B18D8-0x00000001889B18E4
		public bool IsValidData(int teamId) => default; // 0x00000001889B187C-0x00000001889B18D8
		public bool IsActive(int teamId) => default; // 0x00000001889B16E8-0x00000001889B17AC
		public void SetFlag(int teamId, uint flag, bool sw) {} // 0x00000001889B3284-0x00000001889B33FC
		public bool IsFlag(int teamId, uint flag) => default; // 0x00000001889B17AC-0x00000001889B187C
		public void SetParticleChunk(int teamId, ChunkData chunk) {} // 0x00000001889B3B2C-0x00000001889B3C6C
		public void SetFriction(int teamId, float dynamicFriction, float staticFriction) {} // 0x00000001889B33FC-0x00000001889B354C
		public void SetMass(int teamId, BezierParam mass) {} // 0x00000001889B38E4-0x00000001889B3964
		public void SetGravity(int teamId, BezierParam gravity) {} // 0x00000001889B3704-0x00000001889B3784
		public void SetGravityDirection(int teamId, float3 dir) {} // 0x00000001889B354C-0x00000001889B3704
		public void SetDrag(int teamId, BezierParam drag) {} // 0x00000001889B3060-0x00000001889B30E0
		public void SetMaxVelocity(int teamId, BezierParam maxVelocity) {} // 0x00000001889B3964-0x00000001889B39E4
		public void SetExternalForce(int teamId, float massInfluence, float windInfluence, float windRandomScale, float windSynchronization) {} // 0x00000001889B3108-0x00000001889B3284
		public void SetDepthInfluence(int teamId, BezierParam depthInfluence) {} // 0x00000001889B2FE0-0x00000001889B3060
		public void SetWorldInfluence(int teamId, float maxSpeed, float maxRotatinSpeed, BezierParam moveInfluence, BezierParam rotInfluence, bool resetTeleport, float teleportDistance, float teleportRotation, float resetStabilizationTime, ClothParams.TeleportMode teleportMode, bool useClampRotation, BezierParam clampRotation) {} // 0x00000001889B41A0-0x00000001889B43AC
		private float CalcClampRotationLimit(bool useClampRotation, BezierParam clampRotation) => default; // 0x00000001889B0970-0x00000001889B09CC
		public void SetWorldInfluence(int teamId, float maxSpeed, float maxRotationSpeed, BezierParam moveInfluence, BezierParam rotInfluence) {} // 0x00000001889B43AC-0x00000001889B4574
		public void SetAfterTeleport(int teamId, bool resetTeleport, float teleportDistance, float teleportRotation, ClothParams.TeleportMode teleportMode) {} // 0x00000001889B29F0-0x00000001889B2B84
		public void SetStabilizationTime(int teamId, float resetStabilizationTime) {} // 0x00000001889B3DAC-0x00000001889B3F0C
		public void ResetWorldInfluenceTarget(int teamId, Transform target) {} // 0x00000001889B27EC-0x00000001889B29F0
		public void SetClampRotation(int teamId, bool useClampRotation, BezierParam clampRotation) {} // 0x00000001889B2E58-0x00000001889B2FE0
		public void SetSelfCollisionRange(int teamId, float range) {} // 0x00000001889B3C6C-0x00000001889B3DAC
		public void SetBoneIndex(int teamId, int boneIndex, Vector3 initScale) {} // 0x00000001889B2CCC-0x00000001889B2E58
		internal void AddColliderParticle(int teamId, int particleIndex) {} // 0x00000001889B0354-0x00000001889B057C
		internal void RemoveColliderParticle(int teamId, int particleIndex) {} // 0x00000001889B1DA8-0x00000001889B1FA4
		internal void RemoveCollider(int teamId, ColliderComponent collider) {} // 0x00000001889B1FA4-0x00000001889B2070
		public void ResetFuturePredictionCollidere(int teamId) {} // 0x00000001889B2424-0x00000001889B25F8
		public void AddSkinningBoneIndex(int teamId, List<Transform> boneList) {} // 0x00000001889B057C-0x00000001889B0970
		public void RemoveSkinningBoneIndex(int teamId) {} // 0x00000001889B2070-0x00000001889B22D0
		public void SetTimeScale(int teamId, float timeScale) {} // 0x00000001889B3F0C-0x00000001889B4054
		public float GetTimeScale(int teamId) => default; // 0x00000001889B162C-0x00000001889B16E8
		public void SetBlendRatio(int teamId, float blendRatio) {} // 0x00000001889B2B84-0x00000001889B2CCC
		public float GetBlendRatio(int teamId) => default; // 0x00000001889B14B4-0x00000001889B1570
		public void SetOutPhysicsPoseBlendRatio(int teamId, float blendRatio) {} // 0x00000001889B39E4-0x00000001889B3B2C
		public float GetOutPhysicsPoseBlendRatio(int teamId) => default; // 0x00000001889B1570-0x00000001889B162C
		public void SetImpactForce(int teamId, float3 force, ForceMode mode) {} // 0x00000001889B3784-0x00000001889B38E4
		public void ResetStabilizationTime(int teamId, float resetStabilizationTime = -1f /* Metadata: 0x01FD1096 */) {} // 0x00000001889B25F8-0x00000001889B27EC
		public void SetUpdateMode(int teamId, PhysicsTeam.TeamUpdateMode updateMode) {} // 0x00000001889B4054-0x00000001889B41A0
		public void ChangeUseUnityPhysics(int teamId, bool sw) {} // 0x00000001889B112C-0x00000001889B1340
		private void ChangeParticleUseUnityPhysics(int pindex, bool unityPhysics) {} // 0x00000001889B1010-0x00000001889B112C
		internal void ChangeBoneFlag(int teamId, PhysicsTeam.TeamCullingMode cullingMode, bool isCalculation) {} // 0x00000001889B0DB8-0x00000001889B1010
		internal void EarlyUpdateTeamAlways() {} // 0x0000000182639760-0x0000000182639F30
		internal void PreUpdateTeamAlways() {} // 0x0000000182639F30-0x000000018263AAE0
		internal int CalcMaxUpdateCount(int ups, float deltaTime, float physicsDeltaTime, float updateDeltaTime) => default; // 0x00000001889B09CC-0x00000001889B0DB8
		internal void PreUpdateTeamData(float deltaTime, float physicsDeltaTime, float updateDeltaTime, int ups, int maxUpdateCount) {} // 0x00000001889B1A48-0x00000001889B1DA8
		internal void PostUpdateTeamData() {} // 0x00000001889B18E4-0x00000001889B1A48
	}

	public class PhysicsManagerWindData : PhysicsManagerAccess // TypeDefIndex: 51490
	{
		// Fields
		public const uint Flag_Enable = 1; // Metadata: 0x01FD10BA
		public const uint Flag_Addition = 2; // Metadata: 0x01FD10BB
		public FixedNativeList<WindData> windDataList; // 0x18
	
		// Properties
		public int Count { get => default; } // 0x00000001889B4F78-0x00000001889B4FC4 
	
		// Nested types
		public enum WindType // TypeDefIndex: 51486
		{
			None = 0,
			Direction = 1,
			Area = 2
		}
	
		public enum ShapeType // TypeDefIndex: 51487
		{
			Box = 0,
			Sphere = 1
		}
	
		public enum DirectionType // TypeDefIndex: 51488
		{
			OneDirection = 0,
			Radial = 1
		}
	
		public struct WindData // TypeDefIndex: 51489
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
			public bool IsFlag(uint flag) => default; // 0x00000001889A59FC-0x00000001889A5A04
			public void SetFlag(uint flag, bool sw) {} // 0x00000001889A5ACC-0x00000001889A5AE0
			public void SetEnable(bool sw) {} // 0x00000001889BBA94-0x00000001889BBAAC
			public bool IsActive() => default; // 0x00000001889AFF0C-0x00000001889AFF14
		}
	
		// Constructors
		public PhysicsManagerWindData() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void Create() {} // 0x0000000183CFCE70-0x0000000183CFCEF0
		public override void Dispose() {} // 0x00000001889B4AB8-0x00000001889B4AFC
		public int CreateWind(WindType windType, ShapeType shapeType, float3 areaSize, bool addition, float main, float turbulence, float frequency, float3 direction, DirectionType directinType, float areaVolume, float areaLength, BezierParam attenuation) => default; // 0x00000001889B497C-0x00000001889B4AB8
		public void RemoveWind(int windId) {} // 0x00000001889B4B60-0x00000001889B4BB8
		public void SetEnable(int windId, bool sw, Transform target) {} // 0x00000001889B4BB8-0x00000001889B4D34
		public bool IsActive(int windId) => default; // 0x00000001889B4AFC-0x00000001889B4B60
		public void SetFlag(int windId, uint flag, bool sw) {} // 0x00000001889B4D34-0x00000001889B4E08
		public void SetParameter(int windId, float3 areaSize, bool addition, float main, float turbulence, float frequency, float3 direction, float areaVolume, float areaLength, BezierParam attenuation) {} // 0x00000001889B4E08-0x00000001889B4F78
		internal static float3 CalcWindForce(float time, float2 noiseBasePos, float3 mainDir, float main, float turbulence, float frequency, float randomScale) => default; // 0x00000001889B4740-0x00000001889B497C
	}

	public abstract class PhysicsManagerWorker // TypeDefIndex: 51491
	{
		// Properties
		public MagicaPhysicsManager Manager { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
	
		// Constructors
		protected PhysicsManagerWorker() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected virtual void Start() {} // 0x000000018350B670-0x000000018350B680
		public void Init(MagicaPhysicsManager manager) {} // 0x0000000182E153E0-0x0000000182E15410
		public abstract void Create();
		public abstract void RemoveGroup(int group);
		public abstract void Release();
		public abstract void Warmup();
		public abstract JobHandle PreUpdate(JobHandle jobHandle);
		public abstract JobHandle PostUpdate(JobHandle jobHandle);
	}

	public abstract class ColliderComponent : ParticleComponent // TypeDefIndex: 51492
	{
		// Fields
		[SerializeField]
		protected bool isGlobal; // 0x28
		[SerializeField]
		private Vector3 center; // 0x2C
	
		// Properties
		public Vector3 Center { get; set; } // 0x0000000183D59800-0x0000000183D59820 0x00000001889AAD4C-0x00000001889AAD64
	
		// Constructors
		protected ColliderComponent() {} // 0x00000001889AAD44-0x00000001889AAD4C
	
		// Methods
		protected override void OnInit() {} // 0x00000001889AABF4-0x00000001889AAC18
		protected override void OnDispose() {} // 0x00000001889AA910-0x00000001889AABF4
		public override int GetDataHash() => default; // 0x00000001889AA8C4-0x00000001889AA910
		public abstract bool CalcNearPoint(Vector3 pos, out Vector3 p, out Vector3 dir, out Vector3 d, bool skinning);
		public Vector3 CalcLocalPos(Vector3 pos) => default; // 0x00000001889AA728-0x00000001889AA838
		public Vector3 CalcLocalDir(Vector3 dir) => default; // 0x00000001889AA6BC-0x00000001889AA728
		public ChunkData CreateColliderParticle(int teamId) => default; // 0x00000001889AA838-0x00000001889AA8C4
		public void RemoveColliderParticle(int teamId) {} // 0x00000001889AAC18-0x00000001889AAD44
		protected abstract ChunkData CreateColliderParticleReal(int teamId);
	}

	[AddComponentMenu("MagicaCloth/MagicaCapsuleCollider")]
	[HelpURL("https://magicasoft.jp/magica-cloth-capsule-collider/")]
	public class MagicaCapsuleCollider : ColliderComponent // TypeDefIndex: 51494
	{
		// Fields
		[SerializeField]
		private Axis axis; // 0x38
		[Range(0f, 1f)]
		[SerializeField]
		private float length; // 0x3C
		[Range(0f, 0.5f)]
		[SerializeField]
		private float startRadius; // 0x40
		[Range(0f, 0.5f)]
		[SerializeField]
		private float endRadius; // 0x44
	
		// Properties
		public Axis AxisMode { get => default; set {} } // 0x0000000183D4EC30-0x0000000183D4EC40 0x00000001889AD958-0x00000001889AD964
		public float Length { get => default; set {} } // 0x0000000183D4EC60-0x0000000183D4EC70 0x00000001889AD970-0x00000001889AD97C
		public float StartRadius { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x00000001889AD97C-0x00000001889AD988
		public float EndRadius { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x00000001889AD964-0x00000001889AD970
	
		// Nested types
		public enum Axis // TypeDefIndex: 51493
		{
			X = 0,
			Y = 1,
			Z = 2
		}
	
		// Constructors
		public MagicaCapsuleCollider() {} // 0x00000001889AD93C-0x00000001889AD958
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000183D562A0-0x0000000183D562B0
		private void OnValidate() {} // 0x00000001889AD910-0x00000001889AD93C
		internal override void DataUpdate() {} // 0x00000001889AD3E0-0x00000001889AD710
		public override int GetDataHash() => default; // 0x00000001889AD730-0x00000001889AD834
		protected override ChunkData CreateColliderParticleReal(int teamId) => default; // 0x00000001889AD290-0x00000001889AD3E0
		private uint GetCapsuleFlag() => default; // 0x00000001889AD710-0x00000001889AD730
		public Vector3 GetLocalDir() => default; // 0x00000001889AD834-0x00000001889AD878
		public Vector3 GetLocalUp() => default; // 0x00000001889AD878-0x00000001889AD8B4
		public float GetScale() => default; // 0x00000001889AD8B4-0x00000001889AD910
		public override bool CalcNearPoint(Vector3 pos, out Vector3 p, out Vector3 dir, out Vector3 d, bool skinning) {
			p = default;
			dir = default;
			d = default;
			return default;
		} // 0x00000001889ACB14-0x00000001889AD290
	}

	[AddComponentMenu("MagicaCloth/MagicaPlaneCollider")]
	[HelpURL("https://magicasoft.jp/magica-cloth-plane-collider/")]
	public class MagicaPlaneCollider : ColliderComponent // TypeDefIndex: 51495
	{
		// Constructors
		public MagicaPlaneCollider() {} // 0x00000001889AAD44-0x00000001889AAD4C
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000183D563D0-0x0000000183D563E0
		private void OnValidate() {} // 0x00000001889AD910-0x00000001889AD93C
		internal override void DataUpdate() {} // 0x00000001889ADC80-0x00000001889ADE4C
		protected override ChunkData CreateColliderParticleReal(int teamId) => default; // 0x00000001889ADB54-0x00000001889ADC80
		public override bool CalcNearPoint(Vector3 pos, out Vector3 p, out Vector3 dir, out Vector3 d, bool skinning) {
			p = default;
			dir = default;
			d = default;
			return default;
		} // 0x00000001889AD988-0x00000001889ADB54
	}

	[AddComponentMenu("MagicaCloth/MagicaSphereCollider")]
	[HelpURL("https://magicasoft.jp/magica-cloth-sphere-collider/")]
	public class MagicaSphereCollider : ColliderComponent // TypeDefIndex: 51496
	{
		// Fields
		[Range(0.001f, 0.5f)]
		[SerializeField]
		private float radius; // 0x38
	
		// Properties
		public float Radius { get => default; set {} } // 0x0000000183D51000-0x0000000183D51010 0x00000001889AE410-0x00000001889AE41C
	
		// Constructors
		public MagicaSphereCollider() {} // 0x00000001889AE400-0x00000001889AE410
	
		// Methods
		public override ComponentType GetComponentType() => default; // 0x0000000183D563F0-0x0000000183D56400
		private void OnValidate() {} // 0x00000001889AD910-0x00000001889AD93C
		internal override void DataUpdate() {} // 0x00000001889AE12C-0x00000001889AE368
		public override int GetDataHash() => default; // 0x00000001889AE368-0x00000001889AE3D0
		protected override ChunkData CreateColliderParticleReal(int teamId) => default; // 0x00000001889AE004-0x00000001889AE12C
		public float GetScale() => default; // 0x00000001889AE3D0-0x00000001889AE400
		public override bool CalcNearPoint(Vector3 pos, out Vector3 p, out Vector3 dir, out Vector3 d, bool skinning) {
			p = default;
			dir = default;
			d = default;
			return default;
		} // 0x00000001889ADE4C-0x00000001889AE004
	}

	public abstract class ParticleComponent : BaseComponent, IDataHash // TypeDefIndex: 51497
	{
		// Fields
		protected Dictionary<int, ChunkData> particleDict; // 0x18
		protected RuntimeStatus status; // 0x20
	
		// Properties
		public RuntimeStatus Status { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public int CenterParticleIndex { get; } // 0x00000001889AFE58-0x00000001889AFED0 
	
		// Constructors
		protected ParticleComponent() {} // 0x00000001889AFDA0-0x00000001889AFE58
	
		// Methods
		public abstract int GetDataHash();
		protected virtual void Start() {} // 0x00000001889AFCB0-0x00000001889AFCB8
		public virtual void OnEnable() {} // 0x0000000188969CBC-0x0000000188969CE8
		public virtual void OnDisable() {} // 0x0000000188969C88-0x0000000188969CB4
		protected virtual void OnDestroy() {} // 0x00000001889AF8F0-0x00000001889AF920
		private void Init() {} // 0x00000001889AF79C-0x00000001889AF8E8
		protected void OnUpdateStatus() {} // 0x00000001889AF974-0x00000001889AF9B0
		public virtual bool VerifyData() => default; // 0x000000018232EB60-0x000000018232EB70
		protected virtual void OnInit() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnDispose() {} // 0x00000001889AF920-0x00000001889AF96C
		protected virtual void OnUpdate() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnActive() {} // 0x00000001889AF8E8-0x00000001889AF8F0
		protected virtual void OnInactive() {} // 0x00000001889AF96C-0x00000001889AF974
		protected void EnableParticle() {} // 0x00000001889AF4B4-0x00000001889AF5F4
		protected void DisableParticle() {} // 0x00000001889AF1AC-0x00000001889AF30C
		protected void EnableTeamParticle(int teamId) {} // 0x00000001889AF5F4-0x00000001889AF79C
		protected void DisableTeamParticle(int teamId) {} // 0x00000001889AF30C-0x00000001889AF4B4
		protected void ReserveDataUpdate() {} // 0x00000001889AFC34-0x00000001889AFCB0
		internal virtual void DataUpdate() {} // 0x000000018350B670-0x000000018350B680
		internal void UpdateStatus() {} // 0x00000001889AFCB8-0x00000001889AFCD8
		protected ChunkData CreateParticle(uint flag, int teamId, float depth, float3 radius, float3 localPos) => default; // 0x00000001889AEF4C-0x00000001889AF1AC
		protected void RemoveTeamParticle(int teamId) {} // 0x00000001889AFB44-0x00000001889AFC34
		protected void RemoveParticle() {} // 0x00000001889AF9B0-0x00000001889AFB44
		protected Transform UserTransform(int vindex) => default; // 0x0000000184273A88-0x0000000184273A90
		protected float3 UserTransformLocalPosition(int vindex) => default; // 0x00000001889AFCD8-0x00000001889AFD44
		protected quaternion UserTransformLocalRotation(int vindex) => default; // 0x00000001889AFD44-0x00000001889AFDA0
	}

	public abstract class PhysicsTeam : CoreComponent // TypeDefIndex: 51501
	{
		// Fields
		[SerializeField]
		protected PhysicsTeamData teamData; // 0x38
		[SerializeField]
		private float userBlendWeight; // 0x40
		[SerializeField]
		private float userPhysicsBlendWeight; // 0x44
		[SerializeField]
		private bool syncBlendWeightToPoseBlendWeight; // 0x48
		[SerializeField]
		private float userCloseThreshold; // 0x4C
		[SerializeField]
		private TeamUpdateMode updateMode; // 0x50
		[SerializeField]
		private TeamCullingMode cullingMode; // 0x54
		[SerializeField]
		private TeamSkinningMode skinningMode; // 0x58
		protected int teamId; // 0x5C
		protected ChunkData particleChunk; // 0x60
		protected Transform influenceTarget; // 0x70
	
		// Properties
		public int TeamId { get; } // 0x0000000183D4EEF0-0x0000000183D4EF00 
		public PhysicsTeamData TeamData { get; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public ChunkData ParticleChunk { get; } // 0x0000000183D5A130-0x0000000183D5A140 
		public Transform InfluenceTarget { get; set; } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
		public float UserBlendWeight { get; set; } // 0x0000000183D4EC70-0x0000000183D4EC80 0x00000001889438C4-0x00000001889438DC
		public float UserPhysicsBlendWeight { get; set; } // 0x0000000183D4EC80-0x0000000183D4EC90 0x00000001889B5EF0-0x00000001889B5F08
		public bool SyncBlendWeightToPoseBlendWeight { get; set; } // 0x0000000183D4EFE0-0x0000000183D4EFF0 0x0000000183D4F010-0x0000000183D4F020
		public float UserCloseThreshold { get; set; } // 0x0000000183D50200-0x0000000183D50210 0x00000001889B5ED8-0x00000001889B5EF0
		public TeamUpdateMode UpdateMode { get; protected set; } // 0x0000000183D4EED0-0x0000000183D4EEE0 0x0000000183D4EF20-0x0000000183D4EF30
		public TeamCullingMode CullingMode { get; set; } // 0x0000000183D4EEC0-0x0000000183D4EED0 0x0000000183D4EF10-0x0000000183D4EF20
		public TeamSkinningMode SkinningMode { get; set; } // 0x0000000183D4EF00-0x0000000183D4EF10 0x0000000183D4EF50-0x0000000183D4EF60
		internal bool UseAnimatedPose { get; } // 0x00000001889B5ED0-0x00000001889B5ED8 
	
		// Nested types
		public enum TeamUpdateMode // TypeDefIndex: 51498
		{
			Normal = 0,
			UnityPhysics = 1
		}
	
		public enum TeamCullingMode // TypeDefIndex: 51499
		{
			Reset = 0,
			Pause = 10,
			Off = 100
		}
	
		public enum TeamSkinningMode // TypeDefIndex: 51500
		{
			None = 0,
			UserAnimation = 1
		}
	
		// Constructors
		protected PhysicsTeam() {} // 0x00000001889B5E40-0x00000001889B5ED0
	
		// Methods
		public override int GetDataHash() => default; // 0x00000001889B5AAC-0x00000001889B5ACC
		protected override void OnInit() {} // 0x00000001889B5D44-0x00000001889B5DBC
		protected override void OnDispose() {} // 0x00000001889B5C2C-0x00000001889B5CC4
		protected override void OnUpdate() {} // 0x000000018350B670-0x000000018350B680
		protected override void OnActive() {} // 0x00000001889B5BC8-0x00000001889B5C2C
		protected override void OnInactive() {} // 0x00000001889B5CC4-0x00000001889B5D44
		public bool IsActive() => default; // 0x00000001889B5ACC-0x00000001889B5B4C
		public bool IsValid() => default; // 0x00000001889B5B4C-0x00000001889B5BC8
		public ChunkData CreateParticle(int team, int count, Func<int, uint> funcFlag, Func<int, float3> funcWpos, Func<int, quaternion> funcWrot, Func<int, float> funcDepth, Func<int, float3> funcRadius, Func<int, float3> funcTargetLocalPos) => default; // 0x00000001889B584C-0x00000001889B5948
		public void RemoveAllParticle() {} // 0x00000001889B5DBC-0x00000001889B5E38
		public void EnableParticle(Func<int, Transform> funcTarget, Func<int, float3> funcLpos, Func<int, quaternion> funcLrot) {} // 0x00000001889B5A08-0x00000001889B5AAC
		public void DisableParticle(Func<int, Transform> funcTarget, Func<int, float3> funcLpos, Func<int, quaternion> funcLrot) {} // 0x00000001889B5948-0x00000001889B5A08
		public override Define.Error VerifyData() => default; // 0x00000001889B5E38-0x00000001889B5E40
	}

	[Serializable]
	public class PhysicsTeamData : IDataHash // TypeDefIndex: 51502
	{
		// Fields
		[SerializeField]
		private List<ColliderComponent> colliderList; // 0x10
		[SerializeField]
		private List<ColliderComponent> penetrationIgnoreColliderList; // 0x18
		[SerializeField]
		private bool mergeAvatarCollider; // 0x20
		private List<ColliderComponent> addColliderList; // 0x28
	
		// Properties
		public int ColliderCount { get => default; } // 0x00000001889B580C-0x00000001889B584C 
		public List<ColliderComponent> ColliderList { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public List<ColliderComponent> PenetrationIgnoreColliderList { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public bool MergeAvatarCollider { get => default; } // 0x0000000183D4EF90-0x0000000183D4EFA0 
	
		// Constructors
		public PhysicsTeamData() {} // 0x00000001889B572C-0x00000001889B580C
	
		// Methods
		public int GetDataHash() => default; // 0x00000001889B5300-0x00000001889B533C
		public void Init(int teamId) {} // 0x00000001889B533C-0x00000001889B5494
		public void Dispose(int teamId) {} // 0x00000001889B5068-0x00000001889B5300
		public void AddCollider(ColliderComponent collider) {} // 0x00000001889B4FC4-0x00000001889B5068
		public void RemoveCollider(ColliderComponent collider) {} // 0x00000001889B5494-0x00000001889B55AC
		internal void UpdateStatus() {} // 0x00000001889B55AC-0x00000001889B56F0
		public void ValidateColliderList() {} // 0x00000001889B56F0-0x00000001889B572C
	}

	public class AdjustRotationWorker : PhysicsManagerWorker // TypeDefIndex: 51506
	{
		// Fields
		private const int AdjustMode_Fixed = 0; // Metadata: 0x01FD10CE
		private const int AdjustMode_XYMove = 1; // Metadata: 0x01FD10CF
		private const int AdjustMode_XZMove = 2; // Metadata: 0x01FD10D0
		private const int AdjustMode_YZMove = 3; // Metadata: 0x01FD10D1
		private FixedChunkNativeArray<AdjustRotationData> dataList; // 0x18
		public FixedNativeList<GroupData> groupList; // 0x20
		private ExNativeMultiHashMap<int, int> particleMap; // 0x28
	
		// Nested types
		[Serializable]
		public struct AdjustRotationData // TypeDefIndex: 51503
		{
			// Fields
			public int keyIndex; // 0x00
			public int targetIndex; // 0x04
			public float3 localPos; // 0x08
	
			// Methods
			public bool IsValid() => default; // 0x00000001889A7794-0x00000001889A77A4
		}
	
		public struct GroupData // TypeDefIndex: 51504
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public int adjustMode; // 0x08
			public float3 axisRotationPower; // 0x0C
			public ChunkData chunk; // 0x18
		}
	
		[BurstCompile]
		private struct AdjustRotationJob : IJobParallelFor // TypeDefIndex: 51505
		{
			// Fields
			[ReadOnly]
			public NativeArray<AdjustRotationData> dataList; // 0x00
			[ReadOnly]
			public NativeArray<GroupData> groupList; // 0x10
			[ReadOnly]
			public NativeParallelMultiHashMap<int, int> particleMap; // 0x20
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x30
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x40
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x50
			[ReadOnly]
			public NativeArray<float3> snapBasePosList; // 0x60
			[ReadOnly]
			public NativeArray<quaternion> snapBaseRotList; // 0x70
			[ReadOnly]
			public NativeArray<float3> posList; // 0x80
			[WriteOnly]
			public NativeArray<quaternion> rotList; // 0x90
	
			// Methods
			public void Execute(int index) {} // 0x00000001889A77A4-0x00000001889A7BF0
		}
	
		// Constructors
		public AdjustRotationWorker() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void Create() {} // 0x0000000182E0FCF0-0x0000000182E0FE00
		public override void Release() {} // 0x00000001889A837C-0x00000001889A8404
		public int AddGroup(int teamId, bool active, int adjustMode, float3 axisRotationPower, AdjustRotationData[] dataArray) => default; // 0x00000001889A7BF0-0x00000001889A7E7C
		public override void RemoveGroup(int teamId) {} // 0x00000001889A8404-0x00000001889A86F0
		public void ChangeParam(int teamId, bool active, int adjustMode, float3 axisRotationPower) {} // 0x00000001889A7E7C-0x00000001889A8010
		public override void Warmup() {} // 0x000000018350B670-0x000000018350B680
		public override JobHandle PreUpdate(JobHandle jobHandle) => default; // 0x0000000183D65E70-0x0000000183D65E80
		public override JobHandle PostUpdate(JobHandle jobHandle) => default; // 0x00000001889A8010-0x00000001889A837C
	}

	public class BaseSkinningWorker : PhysicsManagerWorker // TypeDefIndex: 51510
	{
		// Fields
		private FixedChunkNativeArray<BaseSkinningData> dataList; // 0x18
		private FixedChunkNativeArray<float4x4> bindPoseList; // 0x20
		public FixedNativeList<GroupData> groupList; // 0x28
	
		// Nested types
		[Serializable]
		public struct BaseSkinningData // TypeDefIndex: 51507
		{
			// Fields
			public float3 localPos; // 0x00
			public float3 localNor; // 0x0C
			public float3 localTan; // 0x18
			public int4 boneIndices; // 0x24
			public float4 weights; // 0x34
			public short weightCount; // 0x44
	
			// Methods
			public bool IsValid() => default; // 0x00000001889A86F0-0x00000001889A86FC
		}
	
		public struct GroupData // TypeDefIndex: 51508
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public int updateFixed; // 0x08
			public ChunkData dataChunk; // 0x0C
			public ChunkData bindPoseChunk; // 0x1C
		}
	
		[BurstCompile]
		private struct BaseSkinningJob : IJobParallelFor // TypeDefIndex: 51509
		{
			// Fields
			[ReadOnly]
			public NativeArray<GroupData> groupList; // 0x00
			[ReadOnly]
			public NativeArray<BaseSkinningData> dataList; // 0x10
			[ReadOnly]
			public NativeArray<float4x4> bindPoseList; // 0x20
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x30
			[ReadOnly]
			public NativeArray<int> skinningBoneList; // 0x40
			[ReadOnly]
			public NativeArray<float3> bonePosList; // 0x50
			[ReadOnly]
			public NativeArray<quaternion> boneRotList; // 0x60
			[ReadOnly]
			public NativeArray<float3> boneSclList; // 0x70
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x80
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x90
			[WriteOnly]
			public NativeArray<float3> snapBasePosList; // 0xA0
			[WriteOnly]
			public NativeArray<quaternion> snapBaseRotList; // 0xB0
	
			// Methods
			public void Execute(int index) {} // 0x00000001889A86FC-0x00000001889A90C8
		}
	
		// Constructors
		public BaseSkinningWorker() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void Create() {} // 0x0000000183B40AC0-0x0000000183B40BD0
		public override void Release() {} // 0x00000001889A9808-0x00000001889A9890
		public int AddGroup(int teamId, bool active, bool updateFixed, BaseSkinningData[] skinningDataList, float4x4[] skinningBindPoseList) => default; // 0x00000001889A90C8-0x00000001889A92AC
		public override void RemoveGroup(int teamId) {} // 0x00000001889A9890-0x00000001889A9A70
		public void ChangeParam(int teamId, bool updateFixed) {} // 0x00000001889A92AC-0x00000001889A9404
		public override void Warmup() {} // 0x000000018350B670-0x000000018350B680
		public override JobHandle PreUpdate(JobHandle jobHandle) => default; // 0x00000001889A9404-0x00000001889A9808
		public override JobHandle PostUpdate(JobHandle jobHandle) => default; // 0x0000000183D65E70-0x0000000183D65E80
	}

	public class LineWorker : PhysicsManagerWorker // TypeDefIndex: 51515
	{
		// Fields
		private FixedChunkNativeArray<LineRotationData> dataList; // 0x18
		private FixedChunkNativeArray<LineRotationRootInfo> rootInfoList; // 0x20
		public FixedNativeList<GroupData> groupList; // 0x28
		private FixedChunkNativeArray<int> rootTeamList; // 0x30
	
		// Nested types
		[Serializable]
		public struct LineRotationData // TypeDefIndex: 51511
		{
			// Fields
			public int vertexIndex; // 0x00
			public int childCount; // 0x04
			public int childStartDataIndex; // 0x08
			public float3 localPos; // 0x0C
			public quaternion localRot; // 0x18
		}
	
		[Serializable]
		public struct LineRotationRootInfo // TypeDefIndex: 51512
		{
			// Fields
			public ushort startIndex; // 0x00
			public ushort dataLength; // 0x02
		}
	
		public struct GroupData // TypeDefIndex: 51513
		{
			// Fields
			public int teamId; // 0x00
			public int avarage; // 0x04
			public ChunkData dataChunk; // 0x08
			public ChunkData rootInfoChunk; // 0x18
		}
	
		[BurstCompile]
		private struct LineRotationJob : IJobParallelFor // TypeDefIndex: 51514
		{
			// Fields
			public int fixedUpdateCount; // 0x00
			[ReadOnly]
			public NativeArray<LineRotationData> dataList; // 0x08
			[ReadOnly]
			public NativeArray<LineRotationRootInfo> rootInfoList; // 0x18
			[ReadOnly]
			public NativeArray<int> rootTeamList; // 0x28
			[ReadOnly]
			public NativeArray<GroupData> groupList; // 0x38
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x48
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x58
			[ReadOnly]
			public NativeArray<float3> posList; // 0x68
			[NativeDisableParallelForRestriction]
			public NativeArray<quaternion> rotList; // 0x78
	
			// Methods
			public void Execute(int rootIndex) {} // 0x00000001889AB9EC-0x00000001889AC190
		}
	
		// Constructors
		public LineWorker() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void Create() {} // 0x0000000183541210-0x0000000183541370
		public override void Release() {} // 0x00000001889AC868-0x00000001889AC910
		public int AddGroup(int teamId, bool avarage, LineRotationData[] dataArray, LineRotationRootInfo[] rootInfoArray) => default; // 0x00000001889AC190-0x00000001889AC41C
		public override void RemoveGroup(int teamId) {} // 0x00000001889AC910-0x00000001889ACB14
		public void ChangeParam(int teamId, bool avarage) {} // 0x00000001889AC41C-0x00000001889AC57C
		public override void Warmup() {} // 0x000000018350B670-0x000000018350B680
		public override JobHandle PreUpdate(JobHandle jobHandle) => default; // 0x0000000183D65E70-0x0000000183D65E80
		public override JobHandle PostUpdate(JobHandle jobHandle) => default; // 0x00000001889AC57C-0x00000001889AC868
	}

	public class MeshParticleWorker : PhysicsManagerWorker // TypeDefIndex: 51519
	{
		// Fields
		private ExNativeMultiHashMap<int, int> vertexToParticleMap; // 0x18
		private FixedNativeListWithCount<int> vertexToParticleList; // 0x20
		private Dictionary<int, List<CreateData>> groupCreateDict; // 0x28
	
		// Nested types
		private struct CreateData // TypeDefIndex: 51516
		{
			// Fields
			public int vertexIndex; // 0x00
			public int particleIndex; // 0x04
		}
	
		[BurstCompile]
		private struct VertexToParticleJob : IJobParallelFor // TypeDefIndex: 51517
		{
			// Fields
			[ReadOnly]
			public NativeArray<PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList; // 0x00
			[ReadOnly]
			public NativeArray<int> vertexToParticleList; // 0x10
			[ReadOnly]
			public NativeParallelMultiHashMap<int, int> vertexToParticleMap; // 0x20
			[ReadOnly]
			public NativeArray<float3> posList; // 0x30
			[ReadOnly]
			public NativeArray<quaternion> rotList; // 0x40
			[ReadOnly]
			public NativeArray<short> virtualVertexMeshIndexList; // 0x50
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> snapBasePosList; // 0x60
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<quaternion> snapBaseRotList; // 0x70
			private NativeParallelMultiHashMapIterator<int> iterator; // 0x80
	
			// Methods
			public void Execute(int index) {} // 0x00000001889BB91C-0x00000001889BBA94
		}
	
		[BurstCompile]
		private struct ParticleToVertexJob : IJobParallelFor // TypeDefIndex: 51518
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> vertexToParticleList; // 0x00
			[ReadOnly]
			public NativeParallelMultiHashMap<int, int> vertexToParticleMap; // 0x10
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> virtualPosList; // 0x20
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<quaternion> virtualRotList; // 0x30
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<byte> virtualVertexFlagList; // 0x40
			[ReadOnly]
			public NativeArray<short> virtualVertexMeshIndexList; // 0x50
			[ReadOnly]
			public NativeArray<PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList; // 0x60
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x70
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x80
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> particleFlagList; // 0x90
			[ReadOnly]
			public NativeArray<float3> particlePosList; // 0xA0
			[ReadOnly]
			public NativeArray<quaternion> particleRotList; // 0xB0
			private NativeParallelMultiHashMapIterator<int> iterator; // 0xC0
	
			// Methods
			public void Execute(int index) {} // 0x00000001889AFF20-0x00000001889B0354
		}
	
		// Constructors
		public MeshParticleWorker() {} // 0x0000000183CFD270-0x0000000183CFD2F0
	
		// Methods
		public override void Create() {} // 0x0000000182E0FE00-0x0000000182E0FEE0
		public override void Release() {} // 0x00000001889AECD0-0x00000001889AED38
		public void Add(int group, int vindex, int pindex) {} // 0x00000001889AE41C-0x00000001889AE5A4
		public override void RemoveGroup(int group) {} // 0x00000001889AED38-0x00000001889AEF4C
		public override void Warmup() {} // 0x000000018350B670-0x000000018350B680
		public override JobHandle PreUpdate(JobHandle jobHandle) => default; // 0x00000001889AE9CC-0x00000001889AECD0
		public override JobHandle PostUpdate(JobHandle jobHandle) => default; // 0x00000001889AE5A4-0x00000001889AE9CC
	}

	public class RenderMeshWorker : PhysicsManagerWorker // TypeDefIndex: 51523
	{
		// Nested types
		[BurstCompile]
		private struct CalcVertexUseFlagJob : IJobParallelFor // TypeDefIndex: 51520
		{
			// Fields
			public uint updateFlag; // 0x00
			public NativeArray<PhysicsManagerMeshData.RenderMeshInfo> renderMeshInfoList; // 0x08
			[ReadOnly]
			public NativeArray<PhysicsManagerMeshData.SharedRenderMeshInfo> sharedRenderMeshInfoList; // 0x18
			[ReadOnly]
			public NativeArray<byte> virtualVertexUseList; // 0x28
			[ReadOnly]
			public NativeArray<byte> virtualVertexFixList; // 0x38
			[ReadOnly]
			public NativeArray<uint> sharedChildVertexInfoList; // 0x48
			[ReadOnly]
			public NativeArray<MeshData.VertexWeight> sharedChildVertexWeightList; // 0x58
			[ReadOnly]
			public NativeArray<float3> sharedRenderVertices; // 0x68
			[ReadOnly]
			public NativeArray<float3> sharedRenderNormals; // 0x78
			[ReadOnly]
			public NativeArray<float4> sharedRenderTangents; // 0x88
			[ReadOnly]
			public NativeArray<byte> sharedBonesPerVertexList; // 0x98
			[ReadOnly]
			public NativeArray<int> sharedBonesPerVertexStartList; // 0xA8
			[ReadOnly]
			public NativeArray<BoneWeight1> sharedBoneWeightList; // 0xB8
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> renderPosList; // 0xC8
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> renderNormalList; // 0xD8
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float4> renderTangentList; // 0xE8
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<BoneWeight1> renderBoneWeightList; // 0xF8
			[NativeDisableParallelForRestriction]
			public NativeArray<uint> renderVertexFlagList; // 0x108
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> renderPosArray; // 0x118
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> renderNormalArray; // 0x128
	
			// Methods
			public void Execute(int rmindex) {} // 0x00000001889A9A70-0x00000001889AA00C
		}
	
		[BurstCompile]
		private struct CollectLocalPositionNormalTangentForEachMeshJob : IJobParallelFor // TypeDefIndex: 51521
		{
			// Fields
			[ReadOnly]
			public NativeArray<PhysicsManagerMeshData.RenderMeshInfo> renderMeshInfoList; // 0x00
			[ReadOnly]
			public NativeArray<float3> transformPosList; // 0x10
			[ReadOnly]
			public NativeArray<quaternion> transformRotList; // 0x20
			[ReadOnly]
			public NativeArray<float3> transformSclList; // 0x30
			[ReadOnly]
			public NativeArray<uint> sharedChildVertexInfoList; // 0x40
			[ReadOnly]
			public NativeArray<MeshData.VertexWeight> sharedChildVertexWeightList; // 0x50
			[ReadOnly]
			public NativeArray<float3> virtualPosList; // 0x60
			[ReadOnly]
			public NativeArray<quaternion> virtualRotList; // 0x70
			[ReadOnly]
			public NativeArray<uint> renderVertexFlagList; // 0x80
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> renderPosList; // 0x90
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> renderNormalList; // 0xA0
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float4> renderTangentList; // 0xB0
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> renderPosArray; // 0xC0
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> renderNormalArray; // 0xD0
	
			// Methods
			public void Execute(int rmindex) {} // 0x00000001889AA00C-0x00000001889AA368
		}
	
		[BurstCompile]
		private struct CollectLocalPositionNormalTangentForEachVertexJob : IJobParallelFor // TypeDefIndex: 51522
		{
			// Fields
			[ReadOnly]
			public NativeArray<PhysicsManagerMeshData.RenderMeshInfo> renderMeshInfoList; // 0x00
			[ReadOnly]
			public NativeArray<float3> transformPosList; // 0x10
			[ReadOnly]
			public NativeArray<quaternion> transformRotList; // 0x20
			[ReadOnly]
			public NativeArray<float3> transformSclList; // 0x30
			[ReadOnly]
			public NativeArray<uint> sharedChildVertexInfoList; // 0x40
			[ReadOnly]
			public NativeArray<MeshData.VertexWeight> sharedChildVertexWeightList; // 0x50
			[ReadOnly]
			public NativeArray<float3> virtualPosList; // 0x60
			[ReadOnly]
			public NativeArray<quaternion> virtualRotList; // 0x70
			[ReadOnly]
			public NativeArray<uint> renderVertexFlagList; // 0x80
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> renderPosList; // 0x90
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> renderNormalList; // 0xA0
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float4> renderTangentList; // 0xB0
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> renderPosArray; // 0xC0
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> renderNormalArray; // 0xD0
	
			// Methods
			public void Execute(int vindex) {} // 0x00000001889AA368-0x00000001889AA6BC
		}
	
		// Constructors
		public RenderMeshWorker() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void Create() {} // 0x000000018350B670-0x000000018350B680
		public override void Release() {} // 0x000000018350B670-0x000000018350B680
		public override void RemoveGroup(int group) {} // 0x000000018350B670-0x000000018350B680
		private bool IsPerformMeshProcessForEachParticle() => default; // 0x00000001889B8BF8-0x00000001889B8C80
		public override void Warmup() {} // 0x00000001889B958C-0x00000001889B9C48
		public override JobHandle PreUpdate(JobHandle jobHandle) => default; // 0x0000000183D65E70-0x0000000183D65E80
		public override JobHandle PostUpdate(JobHandle jobHandle) => default; // 0x00000001889B8C80-0x00000001889B958C
		private static void CollectionVertex([IsReadOnly] in PhysicsManagerMeshData.RenderMeshInfo r_minfo, [IsReadOnly] in NativeArray<uint> sharedChildVertexInfoList, [IsReadOnly] in NativeArray<MeshData.VertexWeight> sharedChildVertexWeightList, [IsReadOnly] in NativeArray<float3> virtualPosList, [IsReadOnly] in NativeArray<quaternion> virtualRotList, [IsReadOnly] in float3 tpos, [IsReadOnly] in quaternion trot, [IsReadOnly] in float3 tscl, [IsReadOnly] in quaternion itrot, float scaleRatio, [IsReadOnly] in float3 scaleDirection, bool calcNormal, bool calcTangent, int vindex, int i, uint flag, bool isFasterWrite, ref NativeArray<float3> renderPosList, ref NativeArray<float3> renderNormalList, ref NativeArray<float3> renderPosArray, ref NativeArray<float3> renderNomalArray, ref NativeArray<float4> renderTangentList) {} // 0x00000001889B7680-0x00000001889B8BF8
	}

	public class SpringMeshWorker : PhysicsManagerWorker // TypeDefIndex: 51526
	{
		// Fields
		private ExNativeMultiHashMap<int, SpringData> springMap; // 0x18
		private FixedNativeListWithCount<int> springVertexList; // 0x20
		private Dictionary<int, List<int>> groupIndexDict; // 0x28
	
		// Nested types
		public struct SpringData // TypeDefIndex: 51524
		{
			// Fields
			public int particleIndex; // 0x00
			public float weight; // 0x04
		}
	
		[BurstCompile]
		private struct SpringJob : IJobParallelFor // TypeDefIndex: 51525
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> springVertexList; // 0x00
			[ReadOnly]
			public NativeParallelMultiHashMap<int, SpringData> springMap; // 0x10
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x20
			[ReadOnly]
			public NativeArray<float3> particlePosList; // 0x30
			[ReadOnly]
			public NativeArray<quaternion> particleRotList; // 0x40
			[ReadOnly]
			public NativeArray<float3> snapBasePosList; // 0x50
			[ReadOnly]
			public NativeArray<quaternion> snapBaseRotList; // 0x60
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> virtualPosList; // 0x70
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<byte> virtualVertexFlagList; // 0x80
			[ReadOnly]
			public NativeArray<short> virtualVertexMeshIndexList; // 0x90
			[ReadOnly]
			public NativeArray<PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList; // 0xA0
			private NativeParallelMultiHashMapIterator<int> iterator; // 0xB0
	
			// Methods
			public void Execute(int index) {} // 0x00000001889B9E2C-0x00000001889BA1E8
		}
	
		// Constructors
		public SpringMeshWorker() {} // 0x0000000183CFC270-0x0000000183CFC2F0
	
		// Methods
		public override void Create() {} // 0x0000000182E0FEE0-0x0000000182E0FFC0
		public override void Release() {} // 0x00000001889BA740-0x00000001889BA7A8
		public void Add(int group, int vertexIndex, int particleIndex, float weight) {} // 0x00000001889BA1E8-0x00000001889BA378
		public override void RemoveGroup(int group) {} // 0x00000001889BA7A8-0x00000001889BA9B4
		public override void Warmup() {} // 0x000000018350B670-0x000000018350B680
		public override JobHandle PreUpdate(JobHandle jobHandle) => default; // 0x0000000183D65E70-0x0000000183D65E80
		public override JobHandle PostUpdate(JobHandle jobHandle) => default; // 0x00000001889BA378-0x00000001889BA740
	}

	public class TriangleWorker : PhysicsManagerWorker // TypeDefIndex: 51530
	{
		// Fields
		private FixedChunkNativeArray<TriangleRotationData> triangleDataList; // 0x18
		private FixedChunkNativeArray<int> triangleIndexList; // 0x20
		public FixedNativeList<GroupData> groupList; // 0x28
	
		// Nested types
		[Serializable]
		public struct TriangleRotationData // TypeDefIndex: 51527
		{
			// Fields
			public int targetIndex; // 0x00
			public int triangleCount; // 0x04
			public int triangleStartIndex; // 0x08
			public quaternion localRot; // 0x0C
	
			// Methods
			public bool IsValid() => default; // 0x0000000182BB8B20-0x0000000182BB8B30
		}
	
		public struct GroupData // TypeDefIndex: 51528
		{
			// Fields
			public int teamId; // 0x00
			public ChunkData triangleDataChunk; // 0x04
			public ChunkData triangleIndexChunk; // 0x14
		}
	
		[BurstCompile]
		private struct TriangleRotationJob : IJobParallelFor // TypeDefIndex: 51529
		{
			// Fields
			[ReadOnly]
			public NativeArray<TriangleRotationData> triangleDataList; // 0x00
			[ReadOnly]
			public NativeArray<int> triangleIndexList; // 0x10
			[ReadOnly]
			public NativeArray<GroupData> groupList; // 0x20
			[ReadOnly]
			public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList; // 0x30
			[ReadOnly]
			public NativeArray<int> teamIdList; // 0x40
			[ReadOnly]
			public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList; // 0x50
			[ReadOnly]
			public NativeArray<float3> posList; // 0x60
			[WriteOnly]
			public NativeArray<quaternion> rotList; // 0x70
	
			// Methods
			public void Execute(int index) {} // 0x00000001889BAA10-0x00000001889BB0EC
		}
	
		// Constructors
		public TriangleWorker() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void Create() {} // 0x0000000183541370-0x0000000183541480
		public override void Release() {} // 0x00000001889BB60C-0x00000001889BB694
		public int AddGroup(int teamId, TriangleRotationData[] dataArray, int[] indexArray) => default; // 0x00000001889BB0EC-0x00000001889BB310
		public override void RemoveGroup(int teamId) {} // 0x00000001889BB694-0x00000001889BB85C
		public override void Warmup() {} // 0x000000018350B670-0x000000018350B680
		public override JobHandle PreUpdate(JobHandle jobHandle) => default; // 0x0000000183D65E70-0x0000000183D65E80
		public override JobHandle PostUpdate(JobHandle jobHandle) => default; // 0x00000001889BB310-0x00000001889BB60C
	}

	public class VirtualMeshWorker : PhysicsManagerWorker // TypeDefIndex: 51535
	{
		// Nested types
		[BurstCompile]
		private struct ReadMeshPositionJob : IJobParallelFor // TypeDefIndex: 51531
		{
			// Fields
			[ReadOnly]
			public NativeArray<PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList; // 0x00
			[ReadOnly]
			public NativeArray<PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList; // 0x10
			[ReadOnly]
			public NativeArray<short> virtualVertexMeshIndexList; // 0x20
			[ReadOnly]
			public NativeArray<byte> virtualVertexUseList; // 0x30
			[ReadOnly]
			public NativeArray<int> virtualTransformIndexList; // 0x40
			[ReadOnly]
			public NativeArray<uint> sharedVirtualVertexInfoList; // 0x50
			[ReadOnly]
			public NativeArray<MeshData.VertexWeight> sharedVirtualWeightList; // 0x60
			[ReadOnly]
			public NativeArray<float3> transformPosList; // 0x70
			[ReadOnly]
			public NativeArray<quaternion> transformRotList; // 0x80
			[ReadOnly]
			public NativeArray<float3> transformSclList; // 0x90
			[WriteOnly]
			public NativeArray<float3> virtualPosList; // 0xA0
			[WriteOnly]
			public NativeArray<quaternion> virtualRotList; // 0xB0
			[WriteOnly]
			public NativeArray<byte> virtualVertexFlagList; // 0xC0
	
			// Methods
			public void Execute(int vindex) {} // 0x00000001889CDBEC-0x00000001889CE588
		}
	
		[BurstCompile]
		private struct CalcMeshTriangleNormalTangentJob : IJobParallelFor // TypeDefIndex: 51532
		{
			// Fields
			[ReadOnly]
			public NativeArray<PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList; // 0x00
			[ReadOnly]
			public NativeArray<PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList; // 0x10
			[ReadOnly]
			public NativeArray<ushort> virtualTriangleMeshIndexList; // 0x20
			[ReadOnly]
			public NativeArray<byte> virtualVertexUseList; // 0x30
			[ReadOnly]
			public NativeArray<float3> virtualPosList; // 0x40
			[ReadOnly]
			public NativeArray<int> sharedTriangles; // 0x50
			[ReadOnly]
			public NativeArray<float2> sharedMeshUv; // 0x60
			[WriteOnly]
			public NativeArray<float3> virtualTriangleNormalList; // 0x70
			[WriteOnly]
			public NativeArray<float3> virtualTriangleTangentList; // 0x80
			[ReadOnly]
			public NativeArray<float3> transformSclList; // 0x90
	
			// Methods
			public void Execute(int tindex) {} // 0x00000001889BCB10-0x00000001889BD0FC
		}
	
		[BurstCompile]
		private struct CalcVertexNormalTangentFromTriangleJob : IJobParallelFor // TypeDefIndex: 51533
		{
			// Fields
			[ReadOnly]
			public NativeArray<PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList; // 0x00
			[ReadOnly]
			public NativeArray<PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList; // 0x10
			[ReadOnly]
			public NativeArray<short> virtualVertexMeshIndexList; // 0x20
			[ReadOnly]
			public NativeArray<byte> virtualVertexUseList; // 0x30
			[ReadOnly]
			public NativeArray<byte> virtualVertexFlagList; // 0x40
			[ReadOnly]
			public NativeArray<uint> sharedVirtualVertexToTriangleInfoList; // 0x50
			[ReadOnly]
			public NativeArray<int> sharedVirtualVertexToTriangleIndexList; // 0x60
			[ReadOnly]
			public NativeArray<float3> virtualTriangleNormalList; // 0x70
			[ReadOnly]
			public NativeArray<float3> virtualTriangleTangentList; // 0x80
			[WriteOnly]
			public NativeArray<quaternion> virtualRotList; // 0x90
	
			// Methods
			public void Execute(int vindex) {} // 0x00000001889BD0FC-0x00000001889BD3E8
		}
	
		[BurstCompile]
		private struct CalcMeshTriangleNormalTangentForEachMeshJob : IJobParallelFor // TypeDefIndex: 51534
		{
			// Fields
			[ReadOnly]
			public NativeArray<PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList; // 0x00
			[ReadOnly]
			public NativeArray<PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList; // 0x10
			[ReadOnly]
			public NativeArray<byte> virtualVertexUseList; // 0x20
			[ReadOnly]
			public NativeArray<byte> virtualVertexFlagList; // 0x30
			[ReadOnly]
			public NativeArray<float3> virtualPosList; // 0x40
			[ReadOnly]
			public NativeArray<int> sharedTriangles; // 0x50
			[ReadOnly]
			public NativeArray<float2> sharedMeshUv; // 0x60
			[ReadOnly]
			public NativeArray<uint> sharedVirtualVertexToTriangleInfoList; // 0x70
			[ReadOnly]
			public NativeArray<int> sharedVirtualVertexToTriangleIndexList; // 0x80
			[ReadOnly]
			public NativeArray<float3> transformSclList; // 0x90
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> virtualTriangleNormalList; // 0xA0
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> virtualTriangleTangentList; // 0xB0
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<quaternion> virtualRotList; // 0xC0
	
			// Methods
			public void Execute(int mindex) {} // 0x00000001889BC1D4-0x00000001889BCB10
		}
	
		// Constructors
		public VirtualMeshWorker() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override void Create() {} // 0x000000018350B670-0x000000018350B680
		public override void Release() {} // 0x000000018350B670-0x000000018350B680
		public override void RemoveGroup(int group) {} // 0x000000018350B670-0x000000018350B680
		private bool IsPerformMeshProcessForEachParticle() => default; // 0x00000001889D0C44-0x00000001889D0CCC
		public override void Warmup() {} // 0x000000018350B670-0x000000018350B680
		public override JobHandle PreUpdate(JobHandle jobHandle) => default; // 0x00000001889D1780-0x00000001889D1C34
		public override JobHandle PostUpdate(JobHandle jobHandle) => default; // 0x00000001889D0CCC-0x00000001889D1780
	}

	public class AutoMove : MonoBehaviour // TypeDefIndex: 51536
	{
		// Fields
		[SerializeField]
		private Vector3 direction; // 0x18
		[SerializeField]
		private float length; // 0x24
		[Range(0.1f, 10f)]
		[SerializeField]
		private float interval; // 0x28
		private Vector3 startPosition; // 0x2C
		private float time; // 0x38
	
		// Constructors
		public AutoMove() {} // 0x00000001889BBD68-0x00000001889BBD98
	
		// Methods
		private void Start() {} // 0x00000001889BBBD0-0x00000001889BBC10
		private void Update() {} // 0x00000001889BBC10-0x00000001889BBD68
		public void OnMoveButton() {} // 0x00000001889BBBA8-0x00000001889BBBD0
	}

	public class AutoRotate : MonoBehaviour // TypeDefIndex: 51537
	{
		// Fields
		[SerializeField]
		private Vector3 rotateAngle; // 0x18
		[Range(0.1f, 5f)]
		[SerializeField]
		private float interval; // 0x24
		private float time; // 0x28
	
		// Constructors
		public AutoRotate() {} // 0x00000001889BBE54-0x00000001889BBE78
	
		// Methods
		private void Start() {} // 0x000000018350B670-0x000000018350B680
		private void Update() {} // 0x00000001889BBD98-0x00000001889BBE54
		public void OnMoveButton() {} // 0x00000001889BBBA8-0x00000001889BBBD0
	}

	public class BlastWaveController : MonoBehaviour // TypeDefIndex: 51539
	{
		// Fields
		public MagicaAreaWind wind; // 0x18
		public float attenuationStartTime; // 0x20
		public float attenuationTime; // 0x24
	
		// Constructors
		public BlastWaveController() {} // 0x0000000183D4CC10-0x0000000183D4CC30
	
		// Methods
		[IteratorStateMachine(typeof(_Start_d__3))]
		private IEnumerator Start() => default; // 0x00000001889BC178-0x00000001889BC1D4
	}

	public class CameraOrbit : MonoBehaviour // TypeDefIndex: 51541
	{
		// Fields
		[SerializeField]
		private Transform cameraTransform; // 0x18
		[Header("Camera Target")]
		public Transform cameraTarget; // 0x20
		public Vector3 cameraTargetPos; // 0x28
		public Vector3 cameraTargetOffset; // 0x34
		[Header("Now Position")]
		[SerializeField]
		private float cameraDist; // 0x40
		[SerializeField]
		private float cameraPitch; // 0x44
		[SerializeField]
		private float cameraYaw; // 0x48
		[Header("Parameter")]
		[SerializeField]
		private float cameraDistHokanTime; // 0x4C
		[SerializeField]
		private float cameraAngleHokanTime; // 0x50
		[SerializeField]
		private float cameraDistSpeed; // 0x54
		[SerializeField]
		private float cameraDistMax; // 0x58
		[SerializeField]
		private float cameraDistMin; // 0x5C
		[SerializeField]
		private float cameraYawSpeed; // 0x60
		[SerializeField]
		private float cameraPitchSpeed; // 0x64
		[SerializeField]
		private float cameraMaxAngleSpeed; // 0x68
		[SerializeField]
		private float cameraPitchMax; // 0x6C
		[SerializeField]
		private float cameraPitchMin; // 0x70
		[SerializeField]
		private MoveMode moveMode; // 0x74
		[SerializeField]
		private float moveSpeed; // 0x78
		private float setCameraDist; // 0x7C
		private float setCameraPitch; // 0x80
		private float setCameraYaw; // 0x84
		private float cameraDistVelocity; // 0x88
		private float cameraPitchVelocity; // 0x8C
		private float cameraYawVelocity; // 0x90
	
		// Nested types
		public enum MoveMode // TypeDefIndex: 51540
		{
			None = 0,
			UpDown = 1,
			Free = 2
		}
	
		// Constructors
		public CameraOrbit() {} // 0x00000001889BDAC0-0x00000001889BDB28
	
		// Methods
		private void Start() {} // 0x00000001889BD9C8-0x00000001889BDAC0
		private void OnEnable() {} // 0x00000001889BD6A0-0x00000001889BD8E0
		private void OnDisable() {} // 0x00000001889BD3F0-0x00000001889BD630
		private void LateUpdate() {} // 0x00000001889BD3E8-0x00000001889BD3F0
		private void updateCamera() {} // 0x00000001889BDB28-0x00000001889BDE04
		private void updatePitchYaw(Vector2 speed) {} // 0x00000001889BDFE0-0x00000001889BE04C
		private void updateOffset(Vector2 speed) {} // 0x00000001889BDE04-0x00000001889BDFE0
		private void updateZoom(float speed) {} // 0x00000001889BE04C-0x00000001889BE0C4
		private void OnTouchMove(int fid, Vector2 screenPos, Vector2 screenVelocity, Vector2 cmVelocity) {} // 0x00000001889BD8E0-0x00000001889BD95C
		private void OnDoubleTouchMove(int fid, Vector2 screenPos, Vector2 screenVelocity, Vector2 cmVelocity) {} // 0x00000001889BD630-0x00000001889BD6A0
		private void OnTouchPinch(float speedscr, float speedcm) {} // 0x00000001889BD95C-0x00000001889BD9C8
	}

	public class CopyObject : MonoBehaviour // TypeDefIndex: 51543
	{
		// Fields
		public int seed; // 0x18
		public int count; // 0x1C
		public float radius; // 0x20
		public GameObject prefab; // 0x28
		public int delayFrame; // 0x30
	
		// Constructors
		public CopyObject() {} // 0x00000001889BE2E0-0x00000001889BE2F8
	
		// Methods
		private void Awake() {} // 0x000000018350B670-0x000000018350B680
		private void Start() {} // 0x00000001889BE2BC-0x00000001889BE2E0
		[IteratorStateMachine(typeof(_CreateObject_d__7))]
		private IEnumerator CreateObject() => default; // 0x00000001889BE260-0x00000001889BE2BC
	}

	public class DressUpControl : MonoBehaviour // TypeDefIndex: 51545
	{
		// Fields
		[SerializeField]
		private GameObject partsItemPrefab; // 0x18
		[SerializeField]
		private VerticalLayoutGroup verticalLayoutGroup; // 0x20
		[SerializeField]
		[Space]
		private MagicaAvatar avatar; // 0x28
		[SerializeField]
		public List<AvatarPartsGroup> avatarPartsGroupList; // 0x30
	
		// Nested types
		[Serializable]
		public class AvatarPartsGroup // TypeDefIndex: 51544
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
			public AvatarPartsGroup() {} // 0x00000001889BBE78-0x00000001889BBEF0
		}
	
		// Constructors
		public DressUpControl() {} // 0x00000001889BED64-0x00000001889BEDE4
	
		// Methods
		private void Start() {} // 0x00000001889BED54-0x00000001889BED5C
		private void Update() {} // 0x000000018350B670-0x000000018350B680
		private void OnDestroy() {} // 0x00000001889BED1C-0x00000001889BED54
		private void Init() {} // 0x00000001889BEB28-0x00000001889BED1C
		private void ChangeParts(int id, int dir) {} // 0x00000001889BE8E8-0x00000001889BE9E4
		public void Clear() {} // 0x00000001889BE9E4-0x00000001889BEB28
	}

	public class ModelController : MonoBehaviour // TypeDefIndex: 51548
	{
		// Fields
		[SerializeField]
		private List<GameObject> characterList; // 0x18
		[SerializeField]
		private float slowTime; // 0x20
		private bool slow; // 0x24
	
		// Constructors
		public ModelController() {} // 0x00000001889CC508-0x00000001889CC590
	
		// Methods
		private void Start() {} // 0x000000018350B670-0x000000018350B680
		private void Update() {} // 0x000000018350B670-0x000000018350B680
		private void AnimatorAction(Action<Animator> act) {} // 0x00000001889CBDA8-0x00000001889CBF4C
		private void ClothAction(Action<BaseCloth> act) {} // 0x00000001889CBF4C-0x00000001889CC0F8
		public void OnNextButton() {} // 0x00000001889CC2F0-0x00000001889CC3EC
		public void OnBackButton() {} // 0x00000001889CC1F4-0x00000001889CC2F0
		public void OnSlowButton() {} // 0x00000001889CC3EC-0x00000001889CC508
		public void OnActiveButton() {} // 0x00000001889CC0F8-0x00000001889CC1F4
	}

	public static class ObjectUtility // TypeDefIndex: 51549
	{
		// Methods
		public static GameObject[] PlaceRandomCubes(int count, Vector3 center, float radius) => default; // 0x00000001889CD894-0x00000001889CDA38
		public static GameObject[] PlaceRandomCubes(int count) => default; // 0x00000001889CDA38-0x00000001889CDA64
		public static GameObject MakeStrippedCube() => default; // 0x00000001889CD7E8-0x00000001889CD894
		public static GameObject[] PlaceRandomGameObject(int count, Vector3 center, float radius, GameObject prefab) => default; // 0x00000001889CDA64-0x00000001889CDBEC
	}

	public class SimpleInputManager : CreateSingleton<MagicaCloth.SimpleInputManager> // TypeDefIndex: 51550
	{
		// Fields
		private const int MaxFinger = 3; // Metadata: 0x01FD10D5
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
		public static float ScreenDpi { get => default; } // 0x00000001889D01D0-0x00000001889D0214 
		public static float ScreenDpc { get => default; } // 0x00000001889D018C-0x00000001889D01D0 
	
		// Constructors
		public SimpleInputManager() {} // 0x00000001889D0130-0x00000001889D018C
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Init() {} // 0x0000000183D474A0-0x0000000183D474D0
		protected override void InitSingleton() {} // 0x00000001889CEE78-0x00000001889CEF8C
		private void Update() {} // 0x00000001889D0110-0x00000001889D0130
		private void CalcScreenDpi() {} // 0x00000001889CEC44-0x00000001889CEC84
		private void AllResetTouchInfo() {} // 0x00000001889CEC04-0x00000001889CEC44
		public int GetTouchCount() => default; // 0x00000001889CEE70-0x00000001889CEE78
		public bool IsUI() => default; // 0x00000001889CEF8C-0x00000001889CF028
		private void UpdateMobile() {} // 0x00000001889CF028-0x00000001889CF8B4
		private Vector2 CalcScreenRatioVector(Vector2 vec) => default; // 0x00000001889CEC84-0x00000001889CECD4
		private bool CheckFlic(int fid, Vector2 oldpos, Vector2 nowpos, Vector2 downpos, float flicktime) => default; // 0x00000001889CECD4-0x00000001889CEE70
		private void UpdateMouse() {} // 0x00000001889CF8B4-0x00000001889D0110
	}

	public class SliderStart : MonoBehaviour // TypeDefIndex: 51551
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text text; // 0x18
		[SerializeField]
		private string lable; // 0x20
		[SerializeField]
		private string format; // 0x28
		private string formatString; // 0x30
	
		// Constructors
		public SliderStart() {} // 0x00000001889D045C-0x00000001889D04C4
	
		// Methods
		private void Start() {} // 0x00000001889D02E0-0x00000001889D045C
		private void OnChangeValue(float value) {} // 0x00000001889D0214-0x00000001889D02E0
	}

	public class UIPartsItem : MonoBehaviour // TypeDefIndex: 51553
	{
		// Fields
		public UnityEngine.UI.Text text; // 0x18
		public UnityEngine.UI.Button prefButton; // 0x20
		public UnityEngine.UI.Button nextButton; // 0x28
		private int id; // 0x30
	
		// Constructors
		public UIPartsItem() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Start() {} // 0x000000018350B670-0x000000018350B680
		public void Init(string title, int id, Action<int, int> onClick) {} // 0x00000001889D0AD0-0x00000001889D0C44
	}

	public class WindController : MonoBehaviour // TypeDefIndex: 51554
	{
		// Fields
		[SerializeField]
		private WindZone unityWindZone; // 0x18
		[SerializeField]
		private float unityWindZoneScale; // 0x20
		[SerializeField]
		private Renderer arrowRenderer; // 0x28
		[SerializeField]
		private Gradient arrowGradient; // 0x30
		[SerializeField]
		private List<Transform> rotationTransforms; // 0x38
		[SerializeField]
		private GameObject blastWavePrefab; // 0x40
		[SerializeField]
		private float blastWaveSpawnRadius; // 0x48
		private float angleY; // 0x4C
		private float angleX; // 0x50
	
		// Properties
		private MagicaDirectionalWind Wind { get => default; } // 0x00000001889D21EC-0x00000001889D2228 
	
		// Constructors
		public WindController() {} // 0x00000001889D2124-0x00000001889D21EC
	
		// Methods
		private void Start() {} // 0x000000018350B670-0x000000018350B680
		public void OnDirectionY(float value) {} // 0x00000001889D1D80-0x00000001889D1D8C
		public void OnDirectionX(float value) {} // 0x00000001889D1D74-0x00000001889D1D80
		public void OnMain(float value) {} // 0x00000001889D1DC4-0x00000001889D1F0C
		public void OnTurbulence(float value) {} // 0x00000001889D1F0C-0x00000001889D1F44
		public void OnFrequency(float value) {} // 0x00000001889D1D8C-0x00000001889D1DC4
		public void OnBlastWave() {} // 0x00000001889D1C34-0x00000001889D1D74
		private void UpdateDirection() {} // 0x00000001889D1F44-0x00000001889D2124
	}

	[Serializable]
	public class BezierParam : IDataHash // TypeDefIndex: 51555
	{
		// Fields
		[SerializeField]
		private float startValue; // 0x10
		[SerializeField]
		private float endValue; // 0x14
		[SerializeField]
		private bool useEndValue; // 0x18
		[SerializeField]
		private float curveValue; // 0x1C
		[SerializeField]
		private bool useCurveValue; // 0x20
	
		// Properties
		public float StartValue { get => default; } // 0x0000000183D4E7A0-0x0000000183D4E7B0 
		public float EndValue { get => default; } // 0x00000001889BC154-0x00000001889BC168 
		public float CurveValue { get => default; } // 0x00000001889BC13C-0x00000001889BC154 
		public bool UseCurve { get => default; } // 0x00000001889BC168-0x00000001889BC178 
	
		// Constructors
		public BezierParam() {} // 0x000000018350B670-0x000000018350B680
		public BezierParam(float val) {} // 0x0000000183D6E2A0-0x0000000183D6E2C0
		public BezierParam(float sval, float eval) {} // 0x0000000183D6E2C0-0x0000000183D6E2E0
		public BezierParam(float sval, float eval, bool useEval, float cval, bool useCval) {} // 0x0000000183D6E270-0x0000000183D6E2A0
	
		// Methods
		public void SetParam(float sval, float eval, bool useEval = true /* Metadata: 0x01FD10D6 */, float cval = 0f /* Metadata: 0x01FD10D7 */, bool useCval = false /* Metadata: 0x01FD10DB */) {} // 0x0000000183D6E270-0x0000000183D6E2A0
		public float Evaluate(float x) => default; // 0x00000001889BBFC8-0x00000001889BC020
		public BezierParam AutoSetup(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x01FD10DC */) => default; // 0x00000001889BBEF0-0x00000001889BBF54
		public int GetDataHash() => default; // 0x00000001889BC020-0x00000001889BC13C
		public BezierParam Clone() => default; // 0x00000001889BBF54-0x00000001889BBFC8
	}

	public interface IBoneReplace // TypeDefIndex: 51556
	{
		// Methods
		HashSet<Transform> GetUsedBones();
		void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class;
	}

	public interface IDataVerify // TypeDefIndex: 51557
	{
		// Methods
		int GetVersion();
		void CreateVerifyData();
		Define.Error VerifyData();
		string GetInformation();
	}

	public interface IEditorCloth // TypeDefIndex: 51558
	{
		// Methods
		List<int> GetSelectionList();
		List<int> GetUseList();
	}

	public interface IEditorMesh // TypeDefIndex: 51559
	{
		// Methods
		int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList);
		List<int> GetEditorTriangleList();
		List<int> GetEditorLineList();
	}

	public class RuntimeStatus // TypeDefIndex: 51560
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
		internal Action UpdateStatusAction; // 0x30
		internal Action DisconnectedAction; // 0x38
		internal Func<object> OwnerFunc; // 0x40
	
		// Properties
		internal HashSet<RuntimeStatus> parentStatusSet { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		internal HashSet<RuntimeStatus> childStatusSet { get; private set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public bool IsActive { get => default; } // 0x00000001889CEBCC-0x00000001889CEBE0 
		public bool IsInitStart { get => default; } // 0x00000001811797F0-0x0000000181179800 
		public bool IsInitComplete { get => default; } // 0x0000000183D510E0-0x0000000183D510F0 
		public bool IsInitSuccess { get => default; } // 0x00000001889CEBF0-0x00000001889CEC04 
		public bool IsInitError { get => default; } // 0x00000001889CEBE0-0x00000001889CEBF0 
		public bool IsDispose { get => default; } // 0x0000000183D6DC60-0x0000000183D6DC70 
		public bool IsDirty { get => default; } // 0x0000000181002A50-0x0000000181002A60 
	
		// Constructors
		public RuntimeStatus() {} // 0x00000001889CEB20-0x00000001889CEBCC
	
		// Methods
		public void SetInitStart() {} // 0x0000000181168960-0x0000000181168970
		public void SetInitComplete() {} // 0x0000000183D58960-0x0000000183D58970
		public void SetInitError() {} // 0x0000000183D64CD0-0x0000000183D64CE0
		public bool SetEnable(bool sw) => default; // 0x00000001889CE8F4-0x00000001889CE904
		public bool SetUserEnable(bool sw) => default; // 0x00000001889CE914-0x00000001889CE924
		public bool SetRuntimeError(bool sw) => default; // 0x00000001889CE904-0x00000001889CE914
		public void SetDispose() {} // 0x0000000183D6E380-0x0000000183D6E390
		public void SetDirty() {} // 0x0000000183D587A0-0x0000000183D587B0
		public void ClearDirty() {} // 0x0000000183D566B0-0x0000000183D566C0
		public bool UpdateStatus() => default; // 0x00000001889CE960-0x00000001889CEB20
		public void AddParentStatus(RuntimeStatus status) {} // 0x00000001889CE5DC-0x00000001889CE630
		public void RemoveParentStatus(RuntimeStatus status) {} // 0x00000001889CE850-0x00000001889CE8F4
		public void AddChildStatus(RuntimeStatus status) {} // 0x00000001889CE588-0x00000001889CE5DC
		public void RemoveChildStatus(RuntimeStatus status) {} // 0x00000001889CE7AC-0x00000001889CE850
		public void LinkParentStatus(RuntimeStatus parent) {} // 0x00000001889CE770-0x00000001889CE7AC
		public void UnlinkParentStatus(RuntimeStatus parent) {} // 0x00000001889CE924-0x00000001889CE960
		private bool IsParentStatusActive() => default; // 0x00000001889CE630-0x00000001889CE770
	}

	public static class DataHashExtensions // TypeDefIndex: 51561
	{
		// Fields
		public const int NullHash = 397610387; // Metadata: 0x01FD10E0
		public const int NumberHash = 932781045; // Metadata: 0x01FD10E5
	
		// Methods
		public static ulong GetVectorDataHash(Vector3 v) => default; // 0x00000001889BE544-0x00000001889BE5E8
	
		// Extension methods
		public static int GetDataHash(this object data) => default; // 0x00000001889BE2F8-0x00000001889BE52C
		public static int GetDataHash(this IDataHash data) => default; // 0x00000001889BE52C-0x00000001889BE544
		public static int GetDataHash<T>(this T[] data) => default;
		public static int GetDataHash<T>(this List<T> data) => default;
		public static int GetDataCountHash<T>(this T[] data) => default;
		public static int GetDataCountHash<T>(this List<T> data) => default;
	}

	public class GridHash // TypeDefIndex: 51563
	{
		// Fields
		protected Dictionary<uint, List<Point>> gridMap; // 0x10
		protected float gridSize; // 0x18
	
		// Nested types
		public class Point // TypeDefIndex: 51562
		{
			// Fields
			public int id; // 0x10
			public float3 pos; // 0x14
	
			// Constructors
			public Point() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public GridHash() {} // 0x0000000183D56A30-0x0000000183D56A40
	
		// Methods
		public virtual void Create(float gridSize = 0.1f /* Metadata: 0x01FD10EA */) {} // 0x00000001889C1148-0x00000001889C11D0
		public virtual void AddPoint(float3 pos, int id) {} // 0x00000001889C0F78-0x00000001889C1100
		public virtual void Remove(float3 pos, int id) {} // 0x00000001889C12B8-0x00000001889C1400
		public void Clear() {} // 0x00000001889C1100-0x00000001889C1148
		public static int3 GetGridPos(float3 pos, float gridSize) => default; // 0x00000001889C1234-0x00000001889C12B8
		public static uint GetGridHash(int3 pos) => default; // 0x0000000183D6E350-0x0000000183D6E380
		public static uint GetGridHash(float3 pos, float gridSize) => default; // 0x00000001889C11D0-0x00000001889C1234
	}

	public class NearPointSearch : GridHash // TypeDefIndex: 51564
	{
		// Fields
		private float radius; // 0x20
		private Dictionary<int, int> nearDict; // 0x28
		private Dictionary<int, float> distDict; // 0x30
		private HashSet<uint> lockPairSet; // 0x38
	
		// Constructors
		public NearPointSearch() {} // 0x00000001889CD6D4-0x00000001889CD7E8
	
		// Methods
		public void Create(float3[] positionList, float radius) {} // 0x00000001889CC628-0x00000001889CC6B4
		public void SearchNearPointAll() {} // 0x00000001889CC9E4-0x00000001889CCC64
		public void SearchNearPoint(int id, float3 pos) {} // 0x00000001889CCC64-0x00000001889CD130
		public void SearchNearPoint(float3 pos, float r) {} // 0x00000001889CD130-0x00000001889CD48C
		public override void AddPoint(float3 pos, int id) {} // 0x00000001889CC600-0x00000001889CC628
		public override void Remove(float3 pos, int id) {} // 0x00000001889CC914-0x00000001889CC9E4
		public void AddLockPair(int id1, int id2) {} // 0x00000001889CC590-0x00000001889CC600
		public bool GetNearPointPair(out int id1, out int id2) {
			id1 = default;
			id2 = default;
			return default;
		} // 0x00000001889CC6B4-0x00000001889CC914
		public override string ToString() => default; // 0x00000001889CD48C-0x00000001889CD6D4
	}

	public struct ChunkData // TypeDefIndex: 51565
	{
		// Fields
		public int chunkNo; // 0x00
		public int startIndex; // 0x04
		public int dataLength; // 0x08
		public int useLength; // 0x0C
	
		// Methods
		public void Clear() {} // 0x0000000183D6E2E0-0x0000000183D6E2F0
		public bool IsValid() => default; // 0x0000000184278130-0x0000000184278138
		public override string ToString() => default; // 0x00000001889BE0C4-0x00000001889BE260
	}

	public class DoubleComputeBuffer<T> : IDisposable // TypeDefIndex: 51566
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
		public ComputeBuffer GetBuffer(int bufferIndex = 0 /* Metadata: 0x01FD10EE */) => default;
	}

	public class ExNativeHashMap<TKey, TValue> // TypeDefIndex: 51567
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

	public class ExNativeMultiHashMap<TKey, TValue> // TypeDefIndex: 51568
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

	public class FixedChunkNativeArray<T> : IDisposable // TypeDefIndex: 51569
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

	public class FixedMultiNativeList<T> : IDisposable // TypeDefIndex: 51570
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

	public class FixedNativeList<T> : IDisposable // TypeDefIndex: 51571
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

	public class FixedNativeListWithCount<T> : IDisposable // TypeDefIndex: 51572
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

	public class FixedTransformAccessArray : IDisposable // TypeDefIndex: 51573
	{
		// Fields
		private TransformAccessArray transformArray; // 0x10
		private int nativeLength; // 0x18
		private Queue<int> emptyStack; // 0x20
		private Dictionary<int, int> useIndexDict; // 0x28
		private Dictionary<int, int> indexDict; // 0x30
		private Dictionary<int, int> referenceDict; // 0x38
	
		// Properties
		public int Count { get => default; } // 0x00000001823128D0-0x0000000182312920 
		public int Length { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public Transform this[int index] { get => default; } // 0x00000001854694D8-0x00000001854694E4 
	
		// Constructors
		public FixedTransformAccessArray() {} // Dummy constructor
		public FixedTransformAccessArray(int desiredJobCount = -1 /* Metadata: 0x01FD10EF */) {} // 0x0000000182E117E0-0x0000000182E11940
		public FixedTransformAccessArray(int capacity, int desiredJobCount) {} // 0x00000001889BF56C-0x00000001889BF6E0
	
		// Methods
		public int Add(Transform element) => default; // 0x00000001889BEDE4-0x00000001889BEFBC
		public void Remove(int index) {} // 0x00000001889BF3F4-0x00000001889BF56C
		public bool Exist(int index) => default; // 0x00000001889BF2E4-0x00000001889BF338
		public bool Exist(Transform element) => default; // 0x00000001889BF250-0x00000001889BF2E4
		public int GetIndex(Transform element) => default; // 0x00000001889BF338-0x00000001889BF3F4
		public void Clear() {} // 0x00000001889BEFBC-0x00000001889BF1A8
		public void Dispose() {} // 0x00000001889BF1A8-0x00000001889BF250
		public TransformAccessArray GetTransformAccessArray() => default; // 0x00000001820B7B20-0x00000001820B7B30
	}

	public static class NativeArrayExtension // TypeDefIndex: 51574
	{
		// Extension methods
		public static void CopyToFast<T, T2>(this NativeArray<T> nativeArray, int startIndex, T2[] array)
			where T : struct
			where T2 : struct {}
		public static void CopyToFast<T>(this NativeArray<T> nativeArray, int startIndex, NativeArray<T> array)
			where T : struct {}
		public static void CopyBlock<T>(this NativeArray<T> nativeArray, int sourceIndex, int destinationIndex, int count)
			where T : struct {}
		public static void CopyFromFast<T>(this NativeArray<T> nativeArray, NativeArray<T> array)
			where T : struct {}
		public static void CopyFromFast<T, T2>(this NativeArray<T> nativeArray, int startIndex, T2[] array)
			where T : struct
			where T2 : struct {}
		public static void SetValue<T>(this NativeArray<T> nativeArray, int startIndex, int count, T value)
			where T : struct {}
	}

	public abstract class CreateSingleton<T> : MonoBehaviour // TypeDefIndex: 51575
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

	public static class DataUtility // TypeDefIndex: 51576
	{
		// Methods
		public static uint PackPair(int v0, int v1) => default; // 0x000000018553DFA0-0x000000018553DFB8
		public static void UnpackPair(uint pack, out int v0, out int v1) {
			v0 = default;
			v1 = default;
		} // 0x0000000183D6DD50-0x0000000183D6DD60
		public static uint Pack16(int hi, int low) => default; // 0x0000000183D4FDB0-0x0000000183D4FDC0
		public static int Unpack16Hi(uint pack) => default; // 0x0000000183D4FE90-0x0000000183D4FEA0
		public static int Unpack16Low(uint pack) => default; // 0x0000000183D4FEA0-0x0000000183D4FEB0
		public static uint Pack4_28(int hi, int low) => default; // 0x0000000183D6E2F0-0x0000000183D6E300
		public static int Unpack4_28Hi(uint pack) => default; // 0x0000000183D6E310-0x0000000183D6E320
		public static int Unpack4_28Low(uint pack) => default; // 0x0000000183D6E320-0x0000000183D6E330
		public static uint Pack8_24(int hi, int low) => default; // 0x0000000183D6E300-0x0000000183D6E310
		public static int Unpack8_24Hi(uint pack) => default; // 0x0000000183D6E330-0x0000000183D6E340
		public static int Unpack8_24Low(uint pack) => default; // 0x0000000183D6E340-0x0000000183D6E350
		public static ulong Pack32(int hi, int low) => default; // 0x0000000183D5C690-0x0000000183D5C6A0
		public static int Unpack32Hi(ulong pack) => default; // 0x0000000183D68B20-0x0000000183D68B30
		public static int Unpack32Low(ulong pack) => default; // 0x0000000183D517B0-0x0000000183D517C0
		public static ulong PackTriple(int v0, int v1, int v2) => default; // 0x00000001889BE760-0x00000001889BE89C
		public static void UnpackTriple(ulong pack, out int v0, out int v1, out int v2) {
			v0 = default;
			v1 = default;
			v2 = default;
		} // 0x0000000183D6DD90-0x0000000183D6DDB0
		public static ulong PackQuater(int v0, int v1, int v2, int v3) => default; // 0x00000001889BE5E8-0x00000001889BE760
		public static void UnpackQuater(ulong pack, out int v0, out int v1, out int v2, out int v3) {
			v0 = default;
			v1 = default;
			v2 = default;
			v3 = default;
		} // 0x0000000183D6DD60-0x0000000183D6DD90
	}

	public static class Develop // TypeDefIndex: 51577
	{
		// Methods
		[Conditional("MAGICACLOTH_DEBUG")]
		public static void Log(string str) {} // 0x00000001889BE89C-0x00000001889BE8E8
	}

	public static class GizmoUtility // TypeDefIndex: 51578
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
		static GizmoUtility() {} // 0x00000001889C0D14-0x00000001889C0F78
	
		// Methods
		public static void DrawWireCapsule(Vector3 pos, Quaternion rot, Vector3 scl, Vector3 ldir, Vector3 lup, float length, float startRadius, float endRadius, bool resetMatrix = true /* Metadata: 0x01FD10F0 */) {} // 0x00000001889C00DC-0x00000001889C054C
		public static void DrawWireSphere(Vector3 pos, Quaternion rot, Vector3 scl, float radius, bool drawSphere, bool drawAxis, bool resetMatrix = true /* Metadata: 0x01FD10F1 */) {} // 0x00000001889C0A7C-0x00000001889C0D14
		public static void DrawWireCube(Vector3 pos, Quaternion rot, Vector3 size, bool resetMatrix = true /* Metadata: 0x01FD10F2 */) {} // 0x00000001889C0960-0x00000001889C0A7C
		public static void DrawWireCone(Vector3 pos, Quaternion rot, float length, float radius, int div = 8 /* Metadata: 0x01FD10F3 */) {} // 0x00000001889C054C-0x00000001889C0960
		public static void DrawWireArrow(Vector3 pos, Quaternion rot, Vector3 size, bool cross = false /* Metadata: 0x01FD10F4 */) {} // 0x00000001889BFD60-0x00000001889C00DC
		public static void DrawAxis(Vector3 pos, Quaternion rot, float size, bool resetMatrix = true /* Metadata: 0x01FD10F5 */) {} // 0x00000001889BF6E0-0x00000001889BF934
		public static void DrawBone(Vector3 pos, Vector3 tpos, float size) {} // 0x00000001889BF934-0x00000001889BFD60
	}

	public static class MathUtility // TypeDefIndex: 51579
	{
		// Methods
		public static float Clamp1(float a) => default; // 0x0000000185540454-0x000000018554046C
		public static float Clamp01(float a) => default; // 0x00000001889C152C-0x00000001889C153C
		public static float3 Project(float3 v, float3 n) => default; // 0x0000000188982AA4-0x0000000188982B1C
		public static float Angle(float3 v1, float3 v2) => default; // 0x0000000185467B08-0x0000000185467BD8
		public static float3 ClampVector(float3 v, float minlength, float maxlength) => default; // 0x0000000188982678-0x000000018898274C
		public static float3 ClampVector(float3 v, float maxlength) => default; // 0x00000001889C1854-0x00000001889C1900
		public static float3 ClampDistance(float3 from, float3 to, float maxlength) => default; // 0x0000000188996D04-0x0000000188996DC8
		public static bool ClampAngle(float3 dir, float3 basedir, float maxAngle, out float3 outdir) {
			outdir = default;
			return default;
		} // 0x00000001889C153C-0x00000001889C17BC
		public static quaternion FromToRotation(float3 from, float3 to, float t = 1f /* Metadata: 0x01FD10F6 */) => default; // 0x00000001889C2650-0x00000001889C2890
		public static quaternion FromToRotation(quaternion from, quaternion to) => default; // 0x00000001854D91BC-0x00000001854D9520
		public static float Angle(quaternion a, quaternion b) => default; // 0x00000001889C1400-0x00000001889C1464
		public static quaternion ClampAngle(quaternion from, quaternion to, float maxAngle) => default; // 0x00000001889C17BC-0x00000001889C1854
		public static float3 AxisToEuler(float3 axis) => default; // 0x00000001889C1464-0x00000001889C152C
		public static quaternion AxisQuaternion(float3 dir) => default; // 0x00000001889A6148-0x00000001889A7794
		public static float ClosestPtPointSegmentRatio(float3 c, float3 a, float3 b) => default; // 0x000000018898274C-0x0000000188982834
		public static float ClosestPtPointSegmentRatioNoClamp(float3 c, float3 a, float3 b) => default; // 0x00000001889C1A48-0x00000001889C1B24
		public static float3 ClosestPtPointSegment(float3 c, float3 a, float3 b) => default; // 0x000000018895B20C-0x000000018895B368
		public static float3 ClosestPtPointSegmentNoClamp(float3 c, float3 a, float3 b) => default; // 0x00000001889C1900-0x00000001889C1A48
		public static bool IntersectPointPlane(float3 planePos, float3 planeDir, float3 pos, out float3 outpos) {
			outpos = default;
			return default;
		} // 0x0000000188982994-0x0000000188982AA4
		public static float IntersectPointPlaneDist(float3 planePos, float3 planeDir, float3 pos, out float3 outPos) {
			outPos = default;
			return default;
		} // 0x0000000188982834-0x0000000188982994
		public static bool IntersectSegmentPlane(float3 a, float3 b, float3 p, float3 pn, out float3 opos) {
			opos = default;
			return default;
		} // 0x00000001889C4510-0x00000001889C468C
		public static bool IntersectPointSphere(float3 sc, float sr, float3 pos, out float3 outPos) {
			outPos = default;
			return default;
		} // 0x00000001889C3CAC-0x00000001889C3DFC
		public static bool IntersectPointSphere(float3 p, float3 sc, float sr) => default; // 0x00000001889BBB38-0x00000001889BBBA8
		public static bool IntersectRaySphere(float3 p, float3 d, float3 sc, float sr, out float3 q, out float t) {
			q = default;
			t = default;
			return default;
		} // 0x00000001889C4374-0x00000001889C4510
		public static bool IntersectLineSphare(float3 a, float3 b, float3 sc, float sr, out float3 q) {
			q = default;
			return default;
		} // 0x00000001889C36EC-0x00000001889C389C
		public static bool IntersectRayCone(float3 o, float3 d, float3 c, float3 v, float cost, out float t, out float3 p) {
			t = default;
			p = default;
			return default;
		} // 0x00000001889C3DFC-0x00000001889C4374
		public static bool IntersectLineConeSurface(float3 a, float3 b, float3 d, float dlen, float3 c, float3 v, float cost, float3 c1, float3 c2, out float3 p) {
			p = default;
			return default;
		} // 0x00000001889C2C48-0x00000001889C2E04
		public static bool IntersectLineCylinderSurface(float3 sa, float3 sb, float3 p, float3 q, float r, out float t) {
			t = default;
			return default;
		} // 0x00000001889C32D4-0x00000001889C36EC
		public static bool IntersectLineCylinderSurface(float3 a, float3 b, float3 c1, float3 c2, float r1, float r2, out float3 p) {
			p = default;
			return default;
		} // 0x00000001889C2E04-0x00000001889C32D4
		public static bool IntersectLineCapsule(float3 a, float3 b, float3 c1, float3 c2, float r1, float r2, out float3 p) {
			p = default;
			return default;
		} // 0x00000001889C28E8-0x00000001889C2C48
		public static bool IntersectTrianglePointDistance(float3 p, float3 p0, float3 p1, float3 p2, float restDist, float compressionStiffness, float stretchStiffness, out float3 corr, out float3 corr0, out float3 corr1, out float3 corr2) {
			corr = default;
			corr0 = default;
			corr1 = default;
			corr2 = default;
			return default;
		} // 0x00000001889C5AF4-0x00000001889C64C8
		public static bool IntersectTrianglePointDistanceSide(float3 p, float3 p0, float3 p1, float3 p2, float restDist, float compressionStiffness, float stretchStiffness, float side, out float3 corr, out float3 corr0, out float3 corr1, out float3 corr2) {
			corr = default;
			corr0 = default;
			corr1 = default;
			corr2 = default;
			return default;
		} // 0x00000001889C5068-0x00000001889C5AF4
		public static bool IntersectTrianglePointDistanceSide2(float3 p, float3 p0, float3 p1, float3 p2, float radius, float restDist, float compressionStiffness, float stretchStiffness, float side, out float3 corr, out float3 corr0, out float3 corr1, out float3 corr2) {
			corr = default;
			corr0 = default;
			corr1 = default;
			corr2 = default;
			return default;
		} // 0x00000001889C468C-0x00000001889C5068
		public static float DistanceTrianglePoint(float3 p, float3 p0, float3 p1, float3 p2) => default; // 0x00000001889C2010-0x00000001889C2650
		public static float3 TriangleCenter(float3 p0, float3 p1, float3 p2) => default; // 0x0000000185543D84-0x0000000185543E38
		public static float3 TriangleNormal(float3 p0, float3 p1, float3 p2) => default; // 0x000000018895B368-0x000000018895B444
		public static quaternion TriangleRotation(float3 p0, float3 p1, float3 p2) => default; // 0x00000001889C666C-0x00000001889C67C8
		public static quaternion TriangleCenterRotation(float3 p0, float3 p1, float3 p2, float3 p3) => default; // 0x00000001889C64C8-0x00000001889C666C
		public static float DistanceTriangleCenter(float3 p, float3 p0, float3 p1, float3 p2) => default; // 0x00000001855411AC-0x0000000185541278
		public static float DirectionPointTriangle(float3 p, float3 a, float3 b, float3 c) => default; // 0x0000000185541090-0x00000001855411AC
		public static bool IntersectLineTriangle(float3 p, float3 q, float3 a, float3 b, float3 c, out float3 hitpos, out float t, out float3 n) {
			hitpos = default;
			t = default;
			n = default;
			return default;
		} // 0x00000001889C389C-0x00000001889C3CAC
		public static float ClosestPtSegmentSegment(float3 p1, float3 q1, float3 p2, float3 q2, out float s, out float t, out float3 c1, out float3 c2) {
			s = default;
			t = default;
			c1 = default;
			c2 = default;
			return default;
		} // 0x00000001889C1B24-0x00000001889C2010
		public static float GetBezierValue(BezierParam bparam, float t) => default; // 0x00000001889C2890-0x00000001889C28E8
		public static float GetBezierValue(float sval, float eval, float curve, float t) => default; // 0x00000001889BBAAC-0x00000001889BBB38
	}

	public static class MeshUtility // TypeDefIndex: 51582
	{
		// Nested types
		private class TetraVertex // TypeDefIndex: 51580
		{
			// Fields
			public int index; // 0x10
			public Vector3 pos; // 0x14
	
			// Constructors
			public TetraVertex() {} // 0x000000018350B670-0x000000018350B680
			public TetraVertex(Vector3 pos, int index) {} // 0x0000000183D6E3C0-0x0000000183D6E3E0
		}
	
		private class Tetra // TypeDefIndex: 51581
		{
			// Fields
			public List<TetraVertex> vertexList; // 0x10
			public Vector3 circumCenter; // 0x18
			public float circumRadius; // 0x24
			public Vector3 tetraCenter; // 0x28
			public float tetraSize; // 0x34
	
			// Constructors
			public Tetra() {} // 0x00000001889D35AC-0x00000001889D3624
			public Tetra(TetraVertex a, TetraVertex b, TetraVertex c, TetraVertex d) {} // 0x00000001889D3490-0x00000001889D35AC
	
			// Methods
			public ulong GetTetraHash() => default; // 0x00000001889D3144-0x00000001889D3238
			public void CalcCircumcircle() {} // 0x00000001889D2714-0x00000001889D2D7C
			public bool IntersectCircumcircle(Vector3 pos) => default; // 0x0000000188957FC0-0x000000018895800C
			public bool CheckSame(Tetra tri) => default; // 0x0000000188957D2C-0x0000000188957DAC
			public bool ContainsPoint(TetraVertex p1) => default; // 0x00000001889D30F0-0x00000001889D3144
			public bool ContainsPoint(TetraVertex p1, TetraVertex p2, TetraVertex p3, TetraVertex p4) => default; // 0x00000001889D3024-0x00000001889D30F0
			public void CalcSize() {} // 0x00000001889D2D7C-0x00000001889D3024
			public bool Verification() => default; // 0x00000001889D3238-0x00000001889D3490
		}
	
		// Methods
		public static GameObject ReplaceSkinnedMeshRendererToMeshRenderer(SkinnedMeshRenderer sren, bool replaceSkinnedMeshRenderer) => default; // 0x00000001889CB930-0x00000001889CBC14
		public static bool CalcMeshWorldPositionNormalTangent(MeshData meshData, List<Transform> boneList, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x00000001889C7590-0x00000001889C7BD0
		public static bool CalcMeshWorldPositionNormalTangent(Renderer ren, Mesh mesh, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
			return default;
		} // 0x00000001889C7BD0-0x00000001889C864C
		public static bool CalcMeshLocalNormalTangent(List<int> selectList, Vector3[] vlist, Vector2[] uvlist, int[] triangles, out List<Vector3> lnorList, out List<Vector3> ltanList) {
			lnorList = default;
			ltanList = default;
			return default;
		} // 0x00000001889C68E8-0x00000001889C7590
		public static List<HashSet<int>> GetTriangleToVertexLinkList(int vcnt, List<int> lineList, List<int> triangleList) => default; // 0x00000001889CADF8-0x00000001889CB16C
		public static List<HashSet<int>> GetVertexLinkList(int vcnt, HashSet<uint> lineSet) => default; // 0x00000001889CB50C-0x00000001889CB78C
		public static Dictionary<int, HashSet<int>> GetVertexToTriangles(List<int> triangleList) => default; // 0x00000001889CB78C-0x00000001889CB930
		public static int RestTriangleVertex(int tindex, int v0, int v1, List<int> triangleList) => default; // 0x00000001889CBD18-0x00000001889CBDA8
		public static void RestTriangleVertex(int tindex, int v0, List<int> triangleList, out int v1, out int v2) {
			v1 = default;
			v2 = default;
		} // 0x00000001889CBC14-0x00000001889CBD18
		public static bool CheckAdjacentTriangle(int tindex0, int tindex1, List<int> triangleList) => default; // 0x00000001889CA7E8-0x00000001889CA8AC
		public static Dictionary<uint, List<int>> GetTriangleEdgePair(List<int> triangleList) => default; // 0x00000001889CAB50-0x00000001889CACBC
		private static void AddTriangleEdge(int v0, int v1, int tindex, Dictionary<uint, List<int>> triangleEdgeDict) {} // 0x00000001889C67C8-0x00000001889C68E8
		public static List<ulong> GetTrianglePackList(List<int> triangleList) => default; // 0x00000001889CACBC-0x00000001889CADF8
		public static float ClosestPtBoneLine(Vector3 pos, Transform bone, float lineWidth, out Vector3 d) {
			d = default;
			return default;
		} // 0x00000001889CA8AC-0x00000001889CAB50
		public static List<Transform> GetUseBoneTransformList(Transform[] bones, Mesh mesh) => default; // 0x00000001889CB16C-0x00000001889CB50C
		public static void CalcTetraMesh(List<Vector3> posList, out int tetraCount, out List<int> tetraIndexList, out List<float> tetraSizeList) {
			tetraCount = default;
			tetraIndexList = default;
			tetraSizeList = default;
		} // 0x00000001889C864C-0x00000001889CA7E8
		public static Transform GetReplaceBone<T>(Transform now, Dictionary<T, Transform> boneReplaceDict)
			where T : class => default;
	}

	public class StaticStringBuilder // TypeDefIndex: 51583
	{
		// Fields
		private static StringBuilder stringBuilder; // 0x00
	
		// Properties
		public static StringBuilder Instance { get => default; } // 0x00000001889D2684-0x00000001889D26D4 
	
		// Constructors
		public StaticStringBuilder() {} // 0x000000018350B670-0x000000018350B680
		static StaticStringBuilder() {} // 0x00000001889D2600-0x00000001889D2684
	
		// Methods
		public static void Clear() {} // 0x00000001889D2550-0x00000001889D25A8
		public static StringBuilder Append(params object[] args) => default; // 0x00000001889D24B0-0x00000001889D2550
		public static StringBuilder AppendLine(params object[] args) => default; // 0x00000001889D2284-0x00000001889D2358
		public static StringBuilder AppendLine() => default; // 0x00000001889D2358-0x00000001889D23D4
		public static string AppendToString(params object[] args) => default; // 0x00000001889D23D4-0x00000001889D24B0
		public static new string ToString() => default; // 0x00000001889D25A8-0x00000001889D2600
	}

	[Serializable]
	public class UpdateTimeManager // TypeDefIndex: 51587
	{
		// Fields
		[SerializeField]
		private UpdateCount updatePerSeccond; // 0x10
		[SerializeField]
		private UpdateMode updateMode; // 0x14
		[SerializeField]
		private UpdateLocation updateLocation; // 0x18
		private float timeScale; // 0x1C
		[Range(0f, 1f)]
		[SerializeField]
		private float futurePredictionRate; // 0x20
		[SerializeField]
		private bool updateBoneScale; // 0x24
		private int fixedUpdateCount; // 0x28
	
		// Properties
		public int FixedUpdateCount { get => default; } // 0x0000000183D4EB90-0x0000000183D4EBA0 
		public int UpdatePerSecond { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
		public float UpdateIntervalTime { get => default; } // 0x0000000183D6E410-0x0000000183D6E430 
		public float UpdatePower { get => default; } // 0x0000000183D6E430-0x0000000183D6E450 
		public float TimeScale { get => default; set {} } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000184270578-0x0000000184270590
		public float DeltaTime { get => default; } // 0x000000018426F800-0x000000018426F808 
		public float PhysicsDeltaTime { get => default; } // 0x0000000182312BC0-0x0000000182312BF0 
		public float AverageDeltaTime { get => default; } // 0x00000001889D3624-0x00000001889D362C 
		public bool IsUnscaledUpdate { get => default; } // 0x00000001889D362C-0x00000001889D3640 
		public bool IsDelay { get => default; } // 0x0000000182312B00-0x0000000182312B10 
		public float FuturePredictionRate { get => default; set {} } // 0x0000000183D4F2E0-0x0000000183D4F2F0 0x00000001889D3648-0x00000001889D3660
		public bool UpdateBoneScale { get => default; set {} } // 0x0000000183D4F090-0x0000000183D4F0A0 0x0000000183D4F0A0-0x0000000183D4F0B0
		public int WorkerMaximumCount { get => default; } // 0x00000001889D3640-0x00000001889D3648 
	
		// Nested types
		public enum UpdateCount // TypeDefIndex: 51584
		{
			_60 = 60,
			_90_Default = 90,
			_120 = 120,
			_150 = 150,
			_180 = 180
		}
	
		public enum UpdateMode // TypeDefIndex: 51585
		{
			UnscaledTime = 0,
			OncePerFrame = 1,
			DelayUnscaledTime = 10
		}
	
		public enum UpdateLocation // TypeDefIndex: 51586
		{
			AfterLateUpdate = 0,
			BeforeLateUpdate = 1
		}
	
		// Constructors
		public UpdateTimeManager() {} // 0x0000000183D6E3F0-0x0000000183D6E410
	
		// Methods
		public void ResetFixedUpdateCount() {} // 0x0000000183D6E3E0-0x0000000183D6E3F0
		public void AddFixedUpdateCount() {} // 0x0000000183D69B30-0x0000000183D69B40
		public UpdateMode GetUpdateMode() => default; // 0x0000000183D50CC0-0x0000000183D50CD0
		public void SetUpdateMode(UpdateMode mode) {} // 0x0000000183D595B0-0x0000000183D595C0
		public UpdateLocation GetUpdateLocation() => default; // 0x00000001820D1AC0-0x00000001820D1AD0
		public void SetUpdateLocation(UpdateLocation location) {} // 0x0000000183D4E9C0-0x0000000183D4E9D0
		public void SetUpdatePerSecond(UpdateCount ucount) {} // 0x00000001810410F0-0x0000000181041100
	}

	public class ReferenceDataBuilder<T> // TypeDefIndex: 51588
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
		public void AddData(T data, params int[] indexes) {}
		public ValueTuple<List<ReferenceDataIndex>, List<T>> GetDirectReferenceData() => default;
		public ValueTuple<List<ReferenceDataIndex>, List<int>, List<List<int>>> GetIndirectReferenceData() => default;
	}

	[Serializable]
	public struct ReferenceDataIndex // TypeDefIndex: 51589
	{
		// Fields
		public int startIndex; // 0x00
		public int count; // 0x04
	}

	public interface IDataHash // TypeDefIndex: 51590
	{
		// Methods
		int GetDataHash();
	}

	public interface IShareDataObject // TypeDefIndex: 51591
	{
		// Methods
		List<ShareDataObject> GetAllShareDataObject();
		ShareDataObject DuplicateShareDataObject(ShareDataObject source);
	}

	[Serializable]
	public abstract class ShareDataObject : ScriptableObject, IDataVerify, IDataHash // TypeDefIndex: 51592
	{
		// Fields
		[SerializeField]
		protected int dataHash; // 0x18
		[SerializeField]
		protected int dataVersion; // 0x1C
	
		// Properties
		public int SaveDataHash { get; set; } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public int SaveDataVersion { get; set; } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
	
		// Constructors
		protected ShareDataObject() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		public abstract int GetDataHash();
		public abstract int GetVersion();
		public abstract Define.Error VerifyData();
		public virtual void CreateVerifyData() {} // 0x00000001889D2228-0x00000001889D2258
		public virtual string GetInformation() => default; // 0x00000001889D2258-0x00000001889D2284
		public static T CreateShareData<T>(string dataName)
			where T : ShareDataObject => default;
		public static bool RemoveNullAndDuplication<T>(List<T> data) => default;
		public static T Clone<T>(T source)
			where T : ShareDataObject => default;
	}

	public class StopWatch // TypeDefIndex: 51593
	{
		// Fields
		private float startTime; // 0x10
		private float endTime; // 0x14
	
		// Properties
		public float ElapsedSeconds { get => default; } // 0x0000000183D6E3B0-0x0000000183D6E3C0 
		public float ElapsedMilliseconds { get => default; } // 0x0000000183D6E390-0x0000000183D6E3B0 
	
		// Constructors
		public StopWatch() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public StopWatch Start() => default; // 0x00000001889D26D4-0x00000001889D26F4
		public StopWatch Stop() => default; // 0x00000001889D26F4-0x00000001889D2714
	}
}

namespace MagicaReductionMesh
{
	public class ReductionMesh // TypeDefIndex: 51290
	{
		// Fields
		private MeshData meshData; // 0x18
		private ReductionData reductionData; // 0x20
		private DebugData debugData; // 0x28
	
		// Properties
		public ReductionWeightMode WeightMode { get; set; } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
		public MeshData MeshData { get => default; } // 0x00000001889549FC-0x0000000188954A28 
		public ReductionData ReductionData { get => default; } // 0x0000000183A46A50-0x0000000183A46A80 
		public DebugData DebugData { get => default; } // 0x00000001889549D0-0x00000001889549FC 
	
		// Nested types
		public enum ReductionWeightMode // TypeDefIndex: 51289
		{
			Distance = 0,
			Average = 1,
			DistanceAverage = 2
		}
	
		// Constructors
		public ReductionMesh() {} // 0x0000000188954918-0x00000001889549D0
	
		// Methods
		public int AddMesh(bool isSkinning, Mesh mesh, List<Transform> bones, Matrix4x4[] bindPoseList, BoneWeight[] boneWeightList) => default; // 0x0000000188954788-0x00000001889547F0
		public int AddMesh(Renderer ren) => default; // 0x000000018895450C-0x0000000188954788
		public int AddMesh(Transform root, List<Vector3> posList, List<Vector3> norList = null, List<Vector4> tanList = null, List<Vector2> uvList = null, List<int> triangleList = null) => default; // 0x0000000188954498-0x000000018895450C
		public void Reduction(float zeroRadius, float radius, float polygonLength, bool createTetra) {} // 0x0000000188954820-0x0000000188954918
		public FinalData GetFinalData(Transform root) => default; // 0x00000001889547F0-0x0000000188954820
	}

	public abstract class ReductionMeshAccess // TypeDefIndex: 51291
	{
		// Fields
		protected ReductionMesh parent; // 0x10
	
		// Properties
		protected MeshData MeshData { get; } // 0x0000000188954458-0x0000000188954478 
		protected ReductionData ReductionData { get; } // 0x0000000188954478-0x0000000188954498 
		protected DebugData DebugData { get; } // 0x0000000188954438-0x0000000188954458 
	
		// Constructors
		protected ReductionMeshAccess() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual void SetParent(ReductionMesh parent) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	public class DebugData : ReductionMeshAccess // TypeDefIndex: 51292
	{
		// Constructors
		public DebugData() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void DispMeshInfo(string header = "" /* Metadata: 0x01FD0DD3 */) {} // 0x000000018894540C-0x00000001889456B8
		public static void DebugDrawShared(FinalData final, bool drawTriangle = true /* Metadata: 0x01FD0DD4 */, bool drawLine = true /* Metadata: 0x01FD0DD5 */, bool drawTetra = true /* Metadata: 0x01FD0DD6 */, bool drawVertexNormal = true /* Metadata: 0x01FD0DD7 */, bool drawVertexTangent = true /* Metadata: 0x01FD0DD8 */, bool drawNumber = false /* Metadata: 0x01FD0DD9 */, int maxPolygonCount = 2147483647 /* Metadata: 0x01FD0DDA */, int layer = -1 /* Metadata: 0x01FD0DDB */, int tetraIndex = -1 /* Metadata: 0x01FD0DDC */, float tetraSize = 1f /* Metadata: 0x01FD0DDD */, List<int> drawNumberList = null, float axisSize = 0.01f /* Metadata: 0x01FD0DE1 */) {} // 0x0000000188944848-0x000000018894540C
		private static void DrawTetra(FinalData final, int tetraIndex, List<Vector3> wposList, float tetraSize) {} // 0x00000001889456B8-0x0000000188945978
		public static void DebugDrawChild(FinalData final, bool drawPosition = false /* Metadata: 0x01FD0DE5 */, bool drawNormal = false /* Metadata: 0x01FD0DE6 */, bool drawTriangle = false /* Metadata: 0x01FD0DE7 */, bool drawNumber = false /* Metadata: 0x01FD0DE8 */, int maxVertexCount = 2147483647 /* Metadata: 0x01FD0DE9 */, float positionSize = 0.001f /* Metadata: 0x01FD0DEA */, float axisSize = 0.01f /* Metadata: 0x01FD0DEE */) {} // 0x0000000188944394-0x0000000188944848
	}

	[Serializable]
	public class FinalData // TypeDefIndex: 51295
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
		public bool IsValid { get => default; } // 0x0000000188945E58-0x0000000188945E9C 
		public int VertexCount { get => default; } // 0x0000000188945FB4-0x0000000188945FF4 
		public int LineCount { get => default; } // 0x0000000188945E9C-0x0000000188945EE0 
		public int TriangleCount { get => default; } // 0x0000000188945F68-0x0000000188945FB4 
		public int TetraCount { get => default; } // 0x0000000188945F20-0x0000000188945F68 
		public int BoneCount { get => default; } // 0x0000000188945E18-0x0000000188945E58 
		public bool IsSkinning { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public int MeshCount { get => default; } // 0x0000000188945EE0-0x0000000188945F20 
	
		// Nested types
		[Serializable]
		public class MeshIndexData // TypeDefIndex: 51293
		{
			// Fields
			public List<uint> meshIndexPackList; // 0x10
	
			// Constructors
			public MeshIndexData() {} // 0x000000018895132C-0x00000001889513A4
		}
	
		[Serializable]
		public class MeshInfo // TypeDefIndex: 51294
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
			public int VertexCount { get => default; } // 0x00000001889515A8-0x00000001889515E8 
	
			// Constructors
			public MeshInfo() {} // 0x00000001889513A4-0x0000000188951530
		}
	
		// Constructors
		public FinalData() {} // 0x0000000188945978-0x0000000188945E18
	}

	public class MeshData : ReductionMeshAccess // TypeDefIndex: 51315
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
		public int VertexCount { get => default; } // 0x00000001889512EC-0x000000018895132C 
		public int LineCount { get => default; } // 0x00000001889511EC-0x000000018895122C 
		public int TriangleCount { get => default; } // 0x00000001889512AC-0x00000001889512EC 
		public int TetraCount { get => default; } // 0x000000018895126C-0x00000001889512AC 
		public int MeshCount { get => default; } // 0x000000018895122C-0x000000018895126C 
		public float WeightPow { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
		public int MaxWeightCount { get => default; set {} } // 0x0000000183D4EEC0-0x0000000183D4EED0 0x0000000183D4EF10-0x0000000183D4EF20
		public float SameSurfaceAngle { get => default; set {} } // 0x0000000183D51080-0x0000000183D51090 0x0000000183D510B0-0x0000000183D510C0
		public bool RemoveSameTrianglePair { get => default; set {} } // 0x0000000183D4F600-0x0000000183D4F610 0x0000000183D4F620-0x0000000183D4F630
		public float RemoveSameTrianglePairAngle { get => default; set {} } // 0x0000000183D50D50-0x0000000183D50D60 0x0000000183D50D80-0x0000000183D50D90
	
		// Nested types
		public class WeightData // TypeDefIndex: 51296
		{
			// Fields
			public int boneIndex; // 0x10
			public float boneWeight; // 0x14
	
			// Constructors
			public WeightData() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public class Vertex // TypeDefIndex: 51297
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
			public Vertex() {} // 0x000000018895ADDC-0x000000018895B20C
		}
	
		public class MeshInfo // TypeDefIndex: 51298
		{
			// Fields
			public int index; // 0x10
			public Mesh mesh; // 0x18
			public int vertexCount; // 0x20
			public List<Vertex> vertexList; // 0x28
	
			// Constructors
			public MeshInfo() {} // 0x0000000188951530-0x00000001889515A8
		}
	
		public class ShareVertex // TypeDefIndex: 51303
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
	
			// Constructors
			public ShareVertex() {} // 0x00000001889570AC-0x000000018895721C
	
			// Methods
			public void AddLink(ShareVertex mv) {} // 0x0000000188954A28-0x0000000188954A80
			public void ReplaseLink(ShareVertex old, ShareVertex mv) {} // 0x0000000188956FF4-0x00000001889570AC
			public void RecalcCoordinate() {} // 0x0000000188956D0C-0x0000000188956FF4
			public void CalcNormalTangentFromTriangle() {} // 0x00000001889568CC-0x0000000188956B08
			public Vector3 CalcLocalPos(Vector3 pos) => default; // 0x00000001889567D8-0x00000001889568CC
			public Vector3 CalcLocalDir(Vector3 dir) => default; // 0x0000000188956728-0x00000001889567D8
			public Matrix4x4 CalcWorldToLocalMatrix() => default; // 0x0000000188956B08-0x0000000188956C1C
			public void CalcBoneWeight(ReductionMesh.ReductionWeightMode weightMode, float weightPow) {} // 0x00000001889566EC-0x0000000188956728
			private void CalcBoneWeight_DistanceAverage(float weightPow) {} // 0x0000000188955324-0x0000000188955E08
			private void CalcBoneWeight_Average() {} // 0x0000000188954CB0-0x0000000188955324
			private void AdjustWeight(List<WeightData> sumlist) {} // 0x0000000188954A80-0x0000000188954CB0
			private void CalcBoneWeight_Distance(float weightPow) {} // 0x0000000188955E08-0x00000001889566EC
			public BoneWeight GetBoneWeight() => default; // 0x0000000188956C1C-0x0000000188956D0C
		}
	
		public class Triangle // TypeDefIndex: 51305
		{
			// Fields
			public int tindex; // 0x10
			public List<ShareVertex> shareVertexList; // 0x18
			public Vector3 wnor; // 0x20
			public Vector3 wtan; // 0x2C
			public bool flipLock; // 0x38
	
			// Constructors
			public Triangle() {} // 0x0000000188959160-0x00000001889591D8
	
			// Methods
			public void GetEdge(out uint edge0, out uint edge1, out uint edge2) {
				edge0 = default;
				edge1 = default;
				edge2 = default;
			} // 0x0000000188958BB0-0x0000000188958D1C
			public Vector3 CalcTriangleNormal() => default; // 0x00000001889583F8-0x0000000188958744
			public void Flip() {} // 0x0000000188958AB8-0x0000000188958BB0
			public Vector3 CalcTriangleTangent() => default; // 0x0000000188958744-0x0000000188958AB8
			public ShareVertex GetNonEdgeVertex(int edgev0, int edgev1) => default; // 0x0000000188958D1C-0x0000000188958DF0
			public ulong GetTriangleHash() => default; // 0x0000000188958ED8-0x0000000188958F8C
			public static float GetTriangleArea(ShareVertex sv0, ShareVertex sv1, ShareVertex sv2) => default; // 0x0000000188958DF0-0x0000000188958ED8
			public override string ToString() => default; // 0x0000000188958F8C-0x0000000188959160
		}
	
		private class Line // TypeDefIndex: 51306
		{
			// Fields
			public List<ShareVertex> shareVertexList; // 0x10
	
			// Constructors
			public Line() {} // 0x0000000188945FF4-0x000000018894606C
		}
	
		public enum UvWrapMode // TypeDefIndex: 51307
		{
			None = 0,
			Sphere = 1
		}
	
		public class Square // TypeDefIndex: 51308
		{
			// Fields
			public ulong shash; // 0x10
			public List<Triangle> triangleList; // 0x18
			public float angle; // 0x20
	
			// Constructors
			public Square() {} // 0x00000001889573A4-0x000000018895741C
	
			// Methods
			public override string ToString() => default; // 0x000000018895721C-0x00000001889573A4
		}
	
		public class Tetra // TypeDefIndex: 51309
		{
			// Fields
			public List<ShareVertex> shareVertexList; // 0x10
			public Vector3 circumCenter; // 0x18
			public float circumRadius; // 0x24
			public Vector3 tetraCenter; // 0x28
			public float tetraSize; // 0x34
	
			// Constructors
			public Tetra() {} // 0x0000000188958264-0x00000001889582DC
			public Tetra(ShareVertex a, ShareVertex b, ShareVertex c, ShareVertex d) {} // 0x00000001889582DC-0x00000001889583F8
	
			// Methods
			public ulong GetTetraHash() => default; // 0x0000000188957ECC-0x0000000188957FC0
			public void CalcCircumcircle() {} // 0x000000018895741C-0x0000000188957A84
			public bool IntersectCircumcircle(Vector3 pos) => default; // 0x0000000188957FC0-0x000000018895800C
			public bool CheckSame(Tetra tri) => default; // 0x0000000188957D2C-0x0000000188957DAC
			public bool ContainsPoint(ShareVertex p1) => default; // 0x0000000188957DAC-0x0000000188957E00
			public bool ContainsPoint(ShareVertex p1, ShareVertex p2, ShareVertex p3, ShareVertex p4) => default; // 0x0000000188957E00-0x0000000188957ECC
			public void CalcSize() {} // 0x0000000188957A84-0x0000000188957D2C
			public bool Verification() => default; // 0x000000018895800C-0x0000000188958264
		}
	
		private class LinkInfo // TypeDefIndex: 51310
		{
			// Fields
			public ShareVertex sv; // 0x10
			public float length; // 0x18
			public int count; // 0x1C
	
			// Constructors
			public LinkInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		private class VertexLengthInfo // TypeDefIndex: 51311
		{
			// Fields
			public ShareVertex sv; // 0x10
			public float length; // 0x18
	
			// Constructors
			public VertexLengthInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public MeshData() {} // 0x0000000188950F8C-0x00000001889511EC
	
		// Methods
		public int AddMesh(bool isSkinning, Mesh mesh, List<Transform> bones, Matrix4x4[] bindPoseList, BoneWeight[] boneWeightList) => default; // 0x00000001889467CC-0x000000018894761C
		public int AddMesh(Transform root, List<Vector3> posList, List<Vector3> norList = null, List<Vector4> tanList = null, List<Vector2> uvList = null, List<int> triangleList = null) => default; // 0x000000018894606C-0x00000001889467CC
		public void CombineVertex(ShareVertex sv0, ShareVertex sv1) {} // 0x00000001889499B4-0x0000000188949CE4
		public void UpdateMeshData(bool createTetra) {} // 0x0000000188950F24-0x0000000188950F8C
		private void CalcVertexIndex() {} // 0x00000001889495B4-0x000000018894975C
		private void CalcUV(UvWrapMode wrapMode) {} // 0x00000001889491DC-0x00000001889495B4
		private void CreateTriangleAndLine() {} // 0x000000018894C68C-0x000000018894DA84
		private void CalcShareVertexWeight() {} // 0x0000000188948DF8-0x0000000188948F30
		private void AdjustTriangleNormal() {} // 0x00000001889476B4-0x0000000188948160
		private bool CheckTwoTriangleOpen(Triangle tri1, Triangle tri2, uint edge) => default; // 0x0000000188949870-0x00000001889499B4
		private float CalcTwoTriangleAngle(Triangle tri1, Triangle tri2, uint edge) => default; // 0x0000000188948F30-0x00000001889491DC
		private Dictionary<uint, List<ulong>> GetEdgeToTriangleDict() => default; // 0x000000018894DA84-0x000000018894DFAC
		private void CalcVertexNormalFromTriangle() {} // 0x000000018894975C-0x0000000188949870
		private void RemoveTriangle(ulong thash) {} // 0x0000000188950350-0x0000000188950568
		private Dictionary<ulong, List<Square>> GetSquareDict() => default; // 0x000000018894F9D0-0x0000000188950240
		private void RemoveOverlappingSquareTriangles() {} // 0x0000000188950240-0x0000000188950350
		private void CreateTetraMesh() {} // 0x000000018894ADE0-0x000000018894C68C
		private Bounds CalcBounding() => default; // 0x0000000188948160-0x0000000188948374
		public FinalData GetFinalData(Transform root) => default; // 0x000000018894DFAC-0x000000018894F9D0
		private void CreateOriginalMeshInfo(FinalData final, Transform root, float weightLength) {} // 0x0000000188949CE4-0x000000018894ADE0
		private void AddVertexToMeshIndexData(FinalData final, int sindex, int meshIndex, int meshVertexIndex) {} // 0x000000018894761C-0x00000001889476B4
		private List<ShareVertex> SearchNearPointList(Vector3 basePos, ShareVertex sv, float weightLength, int maxCount) => default; // 0x0000000188950568-0x0000000188950F24
		public void CalcMeshWorldPositionNormalTangent(bool isSkinning, Mesh mesh, List<Transform> bones, Matrix4x4[] bindPoseList, BoneWeight[] boneWeightList, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector4> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
		} // 0x0000000188948374-0x0000000188948DF8
	}

	public class ReductionData : ReductionMeshAccess // TypeDefIndex: 51316
	{
		// Constructors
		public ReductionData() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void ReductionZeroDistance(float radius = 0.0001f /* Metadata: 0x01FD0DF4 */) {} // 0x00000001889543AC-0x0000000188954438
		public void ReductionRadius(float radius) {} // 0x0000000188954320-0x00000001889543AC
		public void ReductionPolygonLink(float length) {} // 0x0000000188954294-0x0000000188954320
		public void ReductionBone() {} // 0x0000000188953DC8-0x0000000188954294
	}

	public class NearPointReduction // TypeDefIndex: 51318
	{
		// Fields
		protected MeshData meshData; // 0x10
		private List<Point> pointList; // 0x18
		protected Dictionary<Vector3Int, List<Point>> gridMap; // 0x20
		protected float gridSize; // 0x28
		private float searchRadius; // 0x2C
		private Dictionary<Point, List<Point>> nearPointDict; // 0x30
	
		// Properties
		public int PointCount { get => default; } // 0x0000000188952E60-0x0000000188952EA0 
	
		// Nested types
		public class Point // TypeDefIndex: 51317
		{
			// Fields
			public MeshData.ShareVertex shareVertex; // 0x10
			public Vector3 pos; // 0x18
			public Vector3Int grid; // 0x24
			public Point nearPoint; // 0x30
			public float nearDist; // 0x38
	
			// Constructors
			public Point() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public NearPointReduction() {} // Dummy constructor
		public NearPointReduction(float radius = 0.05f /* Metadata: 0x01FD0DF8 */) {} // 0x0000000188952D34-0x0000000188952E60
	
		// Methods
		public void Create(MeshData meshData) {} // 0x0000000188951834-0x00000001889519A8
		public void Reduction() {} // 0x0000000188951BD8-0x000000018895211C
		private Point AddPoint(MeshData.ShareVertex sv, Vector3 pos) => default; // 0x0000000188951778-0x0000000188951834
		private void AddGrid(Point p) {} // 0x00000001889515E8-0x0000000188951778
		private void RemoveGrid(Point p) {} // 0x000000018895211C-0x0000000188952298
		private void Move(Point p, Vector3 newpos) {} // 0x0000000188951B80-0x0000000188951BD8
		private void Remove(Point p) {} // 0x0000000188952298-0x00000001889522FC
		protected Vector3Int GetGridPos(Vector3 pos) => default; // 0x00000001889519A8-0x0000000188951A20
		private void SearchNearPointAll() {} // 0x00000001889522FC-0x0000000188952590
		private void SearchNearPoint(Point p, float radius, Point ignorePoint) {} // 0x0000000188952590-0x0000000188952D34
		private Point GetNearPointPair() => default; // 0x0000000188951A20-0x0000000188951B80
	}

	public class PolygonLinkReduction // TypeDefIndex: 51320
	{
		// Fields
		protected MeshData meshData; // 0x10
		private float reductionLength; // 0x18
		private List<Point> pointList; // 0x20
		private Dictionary<MeshData.ShareVertex, Point> pointDict; // 0x28
	
		// Properties
		public int PointCount { get => default; } // 0x0000000188953D88-0x0000000188953DC8 
	
		// Nested types
		public class Point // TypeDefIndex: 51319
		{
			// Fields
			public MeshData.ShareVertex shareVertex; // 0x10
			public Point nearPoint; // 0x18
			public float nearDist; // 0x20
	
			// Constructors
			public Point() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public PolygonLinkReduction() {} // Dummy constructor
		public PolygonLinkReduction(float length) {} // 0x0000000188953CB8-0x0000000188953D88
	
		// Methods
		public void Create(MeshData meshData) {} // 0x0000000188952F54-0x00000001889530A0
		public void Reduction() {} // 0x0000000188953284-0x00000001889538BC
		private void AddPoint(MeshData.ShareVertex sv) {} // 0x0000000188952EA0-0x0000000188952F54
		private Point GetPoint(MeshData.ShareVertex sv) => default; // 0x0000000188953200-0x0000000188953284
		private void Remove(Point p) {} // 0x00000001889538BC-0x000000018895393C
		private void SearchNearPointAll() {} // 0x000000018895393C-0x0000000188953A50
		private void SearchNearPoint(Point p) {} // 0x0000000188953A50-0x0000000188953CB8
		private Point GetNearPointPair() => default; // 0x00000001889530A0-0x0000000188953200
	}

	public class Utility // TypeDefIndex: 51321
	{
		// Constructors
		public Utility() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static uint PackPair(int v0, int v1) => default; // 0x000000018553DFA0-0x000000018553DFB8
		public static void UnpackPair(uint pack, out int v0, out int v1) {
			v0 = default;
			v1 = default;
		} // 0x0000000183D6DD50-0x0000000183D6DD60
		public static ulong PackTriple(int v0, int v1, int v2) => default; // 0x000000018895ACA0-0x000000018895ADDC
		public static void UnpackTriple(ulong pack, out int v0, out int v1, out int v2) {
			v0 = default;
			v1 = default;
			v2 = default;
		} // 0x0000000183D6DD90-0x0000000183D6DDB0
		public static ulong PackQuater(int v0, int v1, int v2, int v3) => default; // 0x000000018895AB28-0x000000018895ACA0
		public static void UnpackQuater(ulong pack, out int v0, out int v1, out int v2, out int v3) {
			v0 = default;
			v1 = default;
			v2 = default;
			v3 = default;
		} // 0x0000000183D6DD60-0x0000000183D6DD90
		public static uint Pack16(int hi, int low) => default; // 0x0000000183D4FDB0-0x0000000183D4FDC0
		public static int Unpack16Hi(uint pack) => default; // 0x0000000183D4FE90-0x0000000183D4FEA0
		public static int Unpack16Low(uint pack) => default; // 0x0000000183D4FEA0-0x0000000183D4FEB0
		public static ulong Pack32(int hi, int low) => default; // 0x0000000183D5C690-0x0000000183D5C6A0
		public static int Unpack32Hi(ulong pack) => default; // 0x0000000183D68B20-0x0000000183D68B30
		public static int Unpack32Low(ulong pack) => default; // 0x0000000183D517B0-0x0000000183D517C0
		public static void CalcFinalDataWorldPositionNormalTangent(FinalData final, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector4> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
		} // 0x0000000188959F1C-0x000000018895A8B0
		public static void CalcFinalDataChildWorldPositionNormalTangent(FinalData final, int meshIndex, List<Vector3> sposList, List<Vector3> snorList, List<Vector4> stanList, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector4> wtanList) {
			wposList = default;
			wnorList = default;
			wtanList = default;
		} // 0x00000001889593C8-0x0000000188959F1C
		public static void CalcLocalPositionNormalTangent(Transform root, List<Vector3> wposList, List<Vector3> wnorList, List<Vector4> wtanList) {} // 0x000000018895A8B0-0x000000018895AB28
	}
}
