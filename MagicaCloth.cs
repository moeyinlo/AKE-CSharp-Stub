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
using Microsoft.CodeAnalysis;
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

// Image 23: MagicaCloth.dll - Assembly: MagicaCloth, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 54947-55254
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace MagicaCloth
{
	public abstract class BaseCloth : PhysicsTeam // TypeDefIndex: 54984
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
		public float BlendWeight { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000189EC1054-0x0000000189EC106C
		public Vector3 Gravity_GravityDirection { get; set; } // 0x0000000189EC0F08-0x0000000189EC0F34 0x0000000189EC1374-0x0000000189EC1454
		public bool DistanceDisable_Active { get; set; } // 0x0000000189EC0E48-0x0000000189EC0E68 0x0000000189EC1130-0x0000000189EC1150
		public Transform DistanceDisable_ReferenceObject { get; set; } // 0x0000000189EC0EA8-0x0000000189EC0EC8 0x0000000189EC11A0-0x0000000189EC11CC
		public float DistanceDisable_Distance { get; set; } // 0x0000000189EC0E68-0x0000000189EC0E88 0x0000000189EC1150-0x0000000189EC1178
		public float DistanceDisable_FadeDistance { get; set; } // 0x0000000189EC0E88-0x0000000189EC0EA8 0x0000000189EC1178-0x0000000189EC11A0
		public float ExternalForce_WindInfluence { get; set; } // 0x0000000189EC0EC8-0x0000000189EC0EE8 0x0000000189EC11CC-0x0000000189EC12A0
		public float ExternalForce_WindRandomScale { get; set; } // 0x0000000189EC0EE8-0x0000000189EC0F08 0x0000000189EC12A0-0x0000000189EC1374
		public float WorldInfluence_MaxMoveSpeed { get; set; } // 0x0000000189EC0F94-0x0000000189EC0FB4 0x0000000189EC16AC-0x0000000189EC1774
		public bool WorldInfluence_ResetAfterTeleport { get; set; } // 0x0000000189EC0FB4-0x0000000189EC0FD4 0x0000000189EC1774-0x0000000189EC1838
		public float WorldInfluence_TeleportDistance { get; set; } // 0x0000000189EC0FF4-0x0000000189EC1014 0x0000000189EC18DC-0x0000000189EC19A0
		public float WorldInfluence_TeleportRotation { get; set; } // 0x0000000189EC1034-0x0000000189EC1054 0x0000000189EC1A60-0x0000000189EC1B24
		public ClothParams.TeleportMode WorldInfluence_TeleportMode { get; set; } // 0x0000000189EC1014-0x0000000189EC1034 0x0000000189EC19A0-0x0000000189EC1A60
		public float WorldInfluence_StabilizationTime { get; set; } // 0x0000000189EC0FD4-0x0000000189EC0FF4 0x0000000189EC1838-0x0000000189EC18DC
		public bool ColliderCollision_Active { get; set; } // 0x0000000189EC0E28-0x0000000189EC0E48 0x0000000189EC106C-0x0000000189EC1130
		public bool Penetration_Active { get; set; } // 0x0000000189EC0F34-0x0000000189EC0F54 0x0000000189EC1454-0x0000000189EC151C
		public bool Spring_Active { get; set; } // 0x0000000189EC0F54-0x0000000189EC0F74 0x0000000189EC151C-0x0000000189EC15DC
		public float Spring_Power { get; set; } // 0x0000000189EC0F74-0x0000000189EC0F94 0x0000000189EC15DC-0x0000000189EC16AC
		public ClothParams Params { get; } // 0x0000000184D862A0-0x0000000184D862B0 
		public ClothData ClothData { get; set; } // 0x0000000184D861F0-0x0000000184D86200 0x0000000185395D30-0x0000000185395D44
		public SelectionData ClothSelection { get; } // 0x0000000184D85EE0-0x0000000184D85EF0 
		public ClothSetup Setup { get; } // 0x0000000184D86250-0x0000000184D86260 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 54983
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Renderer, bool> __9__106_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000189EEA808-0x0000000189EEA86C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetCullRenderListCount_b__106_0(Renderer x); // 0x0000000189EEA438-0x0000000189EEA484
		}
	
		// Constructors
		protected BaseCloth(); // 0x0000000189EC0D28-0x0000000189EC0E28
	
		// Methods
		public void ResetCloth(); // 0x0000000189EC01C0-0x0000000189EC01F0
		public void ResetCloth(float resetStabilizationTime); // 0x0000000189EC0190-0x0000000189EC01C0
		public void ResetCloth(ClothParams.TeleportMode teleportMode, float resetStabilizationTime = -1f /* Metadata: 0x02346840 */); // 0x0000000189EC01F0-0x0000000189EC01F8
		public void SetTimeScale(float timeScale); // 0x0000000189EC01F8-0x0000000189EC0280
		public float GetTimeScale(); // 0x0000000189EBF494-0x0000000189EBF510
		public void AddForce(Vector3 force, PhysicsManagerTeamData.ForceMode mode); // 0x0000000189EBE780-0x0000000189EBE860
		public void AddCollider(ColliderComponent collider); // 0x0000000189EBE6DC-0x0000000189EBE780
		public void RemoveCollider(ColliderComponent collider); // 0x0000000189EBFEE0-0x0000000189EBFF6C
		public void SetUpdateMode(TeamUpdateMode updateMode); // 0x0000000184D865A0-0x0000000184D865B0
		public void SetCullingMode(TeamCullingMode cullingMode); // 0x0000000184D86590-0x0000000184D865A0
		public void Radius_SetRadius(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x02346844 */); // 0x0000000189EBFD58-0x0000000189EBFEE0
		public void Mass_SetMass(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x02346848 */); // 0x0000000189EBF714-0x0000000189EBF8AC
		public void ClampPosition_SetPositionLength(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x0234684C */); // 0x0000000189EBEA80-0x0000000189EBEC2C
		public void Gravity_SetGravity(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x02346850 */); // 0x0000000189EBF58C-0x0000000189EBF664
		public void Drag_SetDrag(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x02346854 */); // 0x0000000189EBEF80-0x0000000189EBF058
		public void ExternalForce_DepthInfluence(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x02346858 */); // 0x0000000189EBF15C-0x0000000189EBF22C
		public void WorldInfluence_SetMovementInfluence(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x0234685C */); // 0x0000000189EC0B30-0x0000000189EC0C2C
		public void WorldInfluence_SetRotationInfluence(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x02346860 */); // 0x0000000189EC0C2C-0x0000000189EC0D28
		public void WorldInfluence_ReplaceInfluenceTarget(Transform target); // 0x0000000189EC09E8-0x0000000189EC0B30
		public void Penetration_SetMovingRadius(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x02346864 */); // 0x0000000189EBFC48-0x0000000189EBFD58
		public override int GetDataHash(); // 0x0000000189EBF3C8-0x0000000189EBF494
		protected virtual void Reset(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnValidate(); // 0x0000000189EBFC00-0x0000000189EBFC48
		protected override void OnInit(); // 0x0000000189EBFBE0-0x0000000189EBFC00
		protected override void OnActive(); // 0x0000000189EBF8AC-0x0000000189EBF9C4
		protected override void OnInactive(); // 0x0000000189EBFADC-0x0000000189EBFBE0
		protected override void OnDispose(); // 0x0000000189EBFABC-0x0000000189EBFADC
		internal override void UpdateCullingMode(CoreComponent caller); // 0x0000000189EC0528-0x0000000189EC080C
		protected override void OnChangeCalculation(); // 0x0000000189EBF9C4-0x0000000189EBFABC
		public int GetCullRenderListCount(); // 0x0000000189EBF2A8-0x0000000189EBF3C8
		private void BaseClothInit(); // 0x0000000189EBE8F8-0x0000000189EBE9F4
		private void BaseClothDispose(); // 0x0000000189EBE860-0x0000000189EBE8F8
		protected virtual void ClothInit(); // 0x0000000189EBECD0-0x0000000189EBED98
		protected virtual void ClothActive(); // 0x0000000189EBEC2C-0x0000000189EBECA8
		protected virtual void ClothInactive(); // 0x0000000189EBECA8-0x0000000189EBECD0
		protected virtual void ClothDispose(); // 0x00000001841E1670-0x00000001841E1680
		protected abstract uint UserFlag(int vindex);
		protected abstract Transform UserTransform(int vindex);
		protected abstract float3 UserTransformLocalPosition(int vindex);
		protected abstract quaternion UserTransformLocalRotation(int vindex);
		public abstract bool IsRequiresDeformer();
		public abstract BaseMeshDeformer GetDeformer();
		protected abstract MeshData GetMeshData();
		protected abstract void WorkerInit();
		private void SetUseMesh(bool sw); // 0x0000000189EC0280-0x0000000189EC02EC
		private void SetUseVertex(bool sw); // 0x0000000189EC02EC-0x0000000189EC0354
		protected abstract void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer);
		internal void DeformerForEach(Action<BaseMeshDeformer> act); // 0x0000000189EBEF44-0x0000000189EBEF80
		public void UpdateBlend(); // 0x0000000189EC0354-0x0000000189EC0528
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict);
		public override HashSet<Transform> GetUsedBones(); // 0x0000000189EBF510-0x0000000189EBF58C
		protected override void ChangeUseUnityPhysics(bool sw); // 0x0000000189EBE9F4-0x0000000189EBEA80
		public override void CreateVerifyData(); // 0x0000000189EBED98-0x0000000189EBEF44
		public override Define.Error VerifyData(); // 0x0000000189EC08CC-0x0000000189EC09E8
		public bool HasChangedParam(ClothParams.ParamType ptype); // 0x0000000189EBF664-0x0000000189EBF714
		public Define.Error VerifyAlgorithmVersion(); // 0x0000000189EC0844-0x0000000189EC08CC
		public override bool UpgradeFormat(); // 0x0000000189EC080C-0x0000000189EC0844
		public override List<ShareDataObject> GetAllShareDataObject(); // 0x0000000189EBF22C-0x0000000189EBF2A8
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source); // 0x0000000189EBF058-0x0000000189EBF15C
		private void ResetClothInternal(ClothParams.TeleportMode teleportMode, float resetStabilizationTime); // 0x0000000189EBFF6C-0x0000000189EC0190
	}

	public abstract class CoreComponent : BaseComponent, IShareDataObject, IDataVerify, IEditorMesh, IEditorCloth, IDataHash, IBoneReplace // TypeDefIndex: 54985
	{
		// Fields
		[SerializeField]
		protected int dataHash; // 0x18
		[SerializeField]
		protected int dataVersion; // 0x1C
		protected RuntimeStatus status; // 0x20
		private int useUnityPhysicsCount; // 0x28
		private bool nowUseUnityPhysics; // 0x2C
		[CompilerGenerated]
		private bool _IsVisible_k__BackingField; // 0x2D
		protected int calculateValue; // 0x30
	
		// Properties
		public RuntimeStatus Status { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public bool IsVisible { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D86CB0-0x0000000184D86CC0 0x0000000184D86CE0-0x0000000184D86CF0
		public bool IsCalculate { get; } // 0x00000001868D2DA0-0x00000001868D2DA8 
		public int SaveDataHash { get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
		public int SaveDataVersion { get; } // 0x0000000184D86310-0x0000000184D86320 
	
		// Constructors
		protected CoreComponent(); // 0x0000000189EE6760-0x0000000189EE67B8
	
		// Methods
		public Dictionary<string, Transform> GetUsedComponentBones(); // 0x0000000189EE5F4C-0x0000000189EE6210
		public List<string> GetUsedComponentBoneNames(); // 0x0000000189EE5EB0-0x0000000189EE5F4C
		public void ReplaceComponentBone(Dictionary<Transform, Transform> boneReplaceDict); // 0x0000000189EE65B8-0x0000000189EE6600
		public void ReplaceComponentBone(Dictionary<string, Transform> boneReplaceDict); // 0x0000000189EE6570-0x0000000189EE65B8
		public abstract int GetDataHash();
		protected virtual void Start(); // 0x0000000189EE6698-0x0000000189EE66A0
		public virtual void OnEnable(); // 0x0000000189EE64CC-0x0000000189EE6504
		public virtual void OnDisable(); // 0x0000000189EE648C-0x0000000189EE64C4
		protected virtual void OnDestroy(); // 0x0000000189EE6418-0x0000000189EE648C
		public void Init(); // 0x0000000189EE622C-0x0000000189EE63F4
		protected abstract void OnInit();
		protected abstract void OnDispose();
		protected abstract void OnUpdate();
		protected abstract void OnActive();
		protected abstract void OnInactive();
		protected virtual void OnUpdateStatus(); // 0x0000000189EE6504-0x0000000189EE6570
		protected virtual void OnDisconnectedStatus(); // 0x0000000189EE64C4-0x0000000189EE64CC
		public void SetUseUnityPhysics(bool sw); // 0x0000000189EE6600-0x0000000189EE6664
		private void ActiveUseUnityPhysics(); // 0x0000000189EE5C58-0x0000000189EE5C7C
		private void InactiveUseUnityPhysics(); // 0x0000000189EE6210-0x0000000189EE622C
		protected virtual void ChangeUseUnityPhysics(bool sw); // 0x00000001841E1670-0x00000001841E1680
		protected bool IsUseUnityPhysics(); // 0x000000018931FCE4-0x000000018931FCEC
		public virtual List<ShareDataObject> GetAllShareDataObject(); // 0x0000000189EE5CAC-0x0000000189EE5D0C
		public abstract ShareDataObject DuplicateShareDataObject(ShareDataObject source);
		protected void SetUserEnable(bool sw); // 0x0000000189EE6664-0x0000000189EE6698
		internal virtual void UpdateCullingMode(CoreComponent Caller); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnChangeCalculation(); // 0x00000001841E1670-0x00000001841E1680
		public abstract int GetVersion();
		public abstract int GetErrorVersion();
		public virtual Define.Error VerifyData(); // 0x0000000189EE66DC-0x0000000189EE6760
		public Define.Error VerifyDataVersion(); // 0x0000000189EE66A0-0x0000000189EE66DC
		public bool IsOldDataVertion(); // 0x0000000189EE63F4-0x0000000189EE6418
		public virtual void CreateVerifyData(); // 0x0000000189EE5C7C-0x0000000189EE5CAC
		public virtual string GetInformation(); // 0x0000000189EE5DF0-0x0000000189EE5E1C
		public virtual bool UpgradeFormat(); // 0x00000001812081B0-0x0000000181208610
		public void ChangeAvatar<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class;
		public virtual void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class;
		public virtual HashSet<Transform> GetUsedBones(); // 0x0000000189EE5E1C-0x0000000189EE5EB0
		public virtual int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x0000000189EE5D58-0x0000000189EE5DA4
		public virtual List<int> GetEditorTriangleList(); // 0x0000000189EE5DA4-0x0000000189EE5DF0
		public virtual List<int> GetEditorLineList(); // 0x0000000189EE5D0C-0x0000000189EE5D58
		public virtual List<int> GetSelectionList(); // 0x00000001811EC580-0x00000001811EC590
		public virtual List<int> GetUseList(); // 0x00000001811EC580-0x00000001811EC590
		[CompilerGenerated]
		private object _Init_b__27_0(); // 0x000000018464E630-0x000000018464E640
	}

	[Serializable]
	public class AvatarPartsAttachEvent : UnityEvent<MagicaCloth.MagicaAvatar, MagicaCloth.MagicaAvatarParts> // TypeDefIndex: 54986
	{
		// Constructors
		public AvatarPartsAttachEvent(); // 0x0000000189ED815C-0x0000000189ED8198
	}

	[Serializable]
	public class AvatarPartsDetachEvent : UnityEvent<MagicaCloth.MagicaAvatar> // TypeDefIndex: 54987
	{
		// Constructors
		public AvatarPartsDetachEvent(); // 0x0000000189ED8198-0x0000000189ED81D4
	}

	[Serializable]
	public class PhysicsManagerPreUpdateEvent : UnityEvent // TypeDefIndex: 54988
	{
		// Constructors
		public PhysicsManagerPreUpdateEvent(); // 0x0000000185393538-0x0000000185393540
	}

	[Serializable]
	public class PhysicsManagerPostUpdateEvent : UnityEvent // TypeDefIndex: 54989
	{
		// Constructors
		public PhysicsManagerPostUpdateEvent(); // 0x0000000185393538-0x0000000185393540
	}

	[AddComponentMenu("MagicaCloth/MagicaAreaWind")]
	public class MagicaAreaWind : WindComponent // TypeDefIndex: 54990
	{
		// Fields
		[SerializeField]
		private PhysicsManagerWindData.ShapeType shapeType; // 0x58
		[SerializeField]
		private bool isAddition; // 0x5C
	
		// Properties
		public PhysicsManagerWindData.ShapeType ShapeType { get; set; } // 0x0000000184D86570-0x0000000184D86580 0x0000000189EE69DC-0x0000000189EE69FC
		public bool Addition { get; set; } // 0x0000000184D86D90-0x0000000184D86DA0 0x0000000189EE69BC-0x0000000189EE69DC
	
		// Constructors
		public MagicaAreaWind(); // 0x0000000189EE69B4-0x0000000189EE69BC
	
		// Methods
		public override ComponentType GetComponentType(); // 0x0000000184DA3370-0x0000000184DA3380
		public override PhysicsManagerWindData.WindType GetWindType(); // 0x0000000182BBE540-0x0000000182BBE550
		public override PhysicsManagerWindData.ShapeType GetShapeType(); // 0x0000000184D86570-0x0000000184D86580
		public override PhysicsManagerWindData.DirectionType GetDirectionType(); // 0x0000000189EE6944-0x0000000189EE6954
		public override bool IsAddition(); // 0x0000000184D86D90-0x0000000184D86DA0
		public override Vector3 GetAreaSize(); // 0x0000000189EE6804-0x0000000189EE689C
		public override float GetAreaVolume(); // 0x0000000189EE689C-0x0000000189EE6944
		public override float GetAreaLength(); // 0x0000000189EE67B8-0x0000000189EE6804
		protected override void ResetParams(); // 0x0000000189EE6954-0x0000000189EE69B4
	}

	[AddComponentMenu("MagicaCloth/MagicaAvatar")]
	[HelpURL("https://magicasoft.jp/avatar/")]
	public class MagicaAvatar : CoreComponent // TypeDefIndex: 54991
	{
		// Fields
		private const int DATA_VERSION = 1; // Metadata: 0x02346868
		[SerializeField]
		private bool dataReset; // 0x38
		private MagicaAvatarRuntime runtime; // 0x40
		public AvatarPartsAttachEvent OnAttachParts; // 0x48
		public AvatarPartsDetachEvent OnDetachParts; // 0x50
	
		// Properties
		public bool DataReset { get; set; } // 0x00000001811F2A70-0x00000001811F2A80 0x00000001811F2A80-0x00000001811F2A90
		public MagicaAvatarRuntime Runtime { get; } // 0x0000000184A37980-0x0000000184A379B0 
	
		// Constructors
		public MagicaAvatar(); // 0x0000000189EE9E84-0x0000000189EE9F64
	
		// Methods
		public int AttachAvatarParts(GameObject avatarPartsPrefab, Action<GameObject> instanceAction = null); // 0x0000000189EE959C-0x0000000189EE9664
		public void DetachAvatarParts(int partsId); // 0x0000000189EE969C-0x0000000189EE96C8
		public void DetachAvatarParts(GameObject avatarPartsObject); // 0x0000000189EE96C8-0x0000000189EE9738
		public void DetachAvatarParts(MagicaAvatarParts parts); // 0x0000000189EE966C-0x0000000189EE969C
		public override ComponentType GetComponentType(); // 0x0000000184DA3390-0x0000000184DA33A0
		public override int GetDataHash(); // 0x00000001811EC580-0x00000001811EC590
		private void Reset(); // 0x0000000184D919E0-0x0000000184D919F0
		private void OnValidate(); // 0x00000001841E1670-0x00000001841E1680
		protected override void OnInit(); // 0x0000000189EE9DE4-0x0000000189EE9E0C
		protected override void OnDispose(); // 0x0000000189EE9D94-0x0000000189EE9DBC
		protected override void OnUpdate(); // 0x00000001841E1670-0x00000001841E1680
		protected override void OnActive(); // 0x0000000189EE9D6C-0x0000000189EE9D94
		protected override void OnInactive(); // 0x0000000189EE9DBC-0x0000000189EE9DE4
		public override int GetVersion(); // 0x0000000184D85B80-0x0000000184D85B90
		public override int GetErrorVersion(); // 0x00000001811EC580-0x00000001811EC590
		public override void CreateVerifyData(); // 0x0000000189EE9664-0x0000000189EE966C
		public override Define.Error VerifyData(); // 0x0000000189EE9E0C-0x0000000189EE9E84
		public override string GetInformation(); // 0x0000000189EE9740-0x0000000189EE9D6C
		public override List<ShareDataObject> GetAllShareDataObject(); // 0x0000000189EE9738-0x0000000189EE9740
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source); // 0x00000001811EC580-0x00000001811EC590
	}

	[AddComponentMenu("MagicaCloth/MagicaDirectionalWind")]
	[HelpURL("https://magicasoft.jp/directional-wind/")]
	public class MagicaDirectionalWind : WindComponent // TypeDefIndex: 54992
	{
		// Constructors
		public MagicaDirectionalWind(); // 0x0000000189EE69B4-0x0000000189EE69BC
	
		// Methods
		public override ComponentType GetComponentType(); // 0x0000000184DA33E0-0x0000000184DA33F0
		public override PhysicsManagerWindData.WindType GetWindType(); // 0x0000000184D85B80-0x0000000184D85B90
		public override PhysicsManagerWindData.ShapeType GetShapeType(); // 0x00000001811EC580-0x00000001811EC590
		public override PhysicsManagerWindData.DirectionType GetDirectionType(); // 0x00000001811EC580-0x00000001811EC590
		public override bool IsAddition(); // 0x00000001812081B0-0x0000000181208610
		public override Vector3 GetAreaSize(); // 0x0000000184DA33B0-0x0000000184DA33D0
		public override float GetAreaVolume(); // 0x0000000184DA33D0-0x0000000184DA33E0
		public override float GetAreaLength(); // 0x0000000184DA33A0-0x0000000184DA33B0
		protected override void ResetParams(); // 0x0000000189EE9F64-0x0000000189EE9FC4
	}

	[HelpURL("https://magicasoft.jp/magica-cloth-physics-manager/")]
	public class MagicaPhysicsManager : CreateSingleton<MagicaCloth.MagicaPhysicsManager> // TypeDefIndex: 54995
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
		public UpdateTimeManager.UpdateCount UpdatePerSeccond { get; set; } // 0x0000000189EEA36C-0x0000000189EEA388 0x0000000189EEA3D4-0x0000000189EEA3F0
		public UpdateTimeManager.UpdateMode UpdateMode { get; set; } // 0x0000000189EEA350-0x0000000189EEA36C 0x0000000189EEA3B8-0x0000000189EEA3D4
		public float FuturePredictionRate { get; set; } // 0x0000000189EEA1B8-0x0000000189EEA1D8 0x0000000189EEA388-0x0000000189EEA3B0
		public UpdateTimeManager UpdateTime { get; } // 0x000000018385B100-0x000000018385B110 
		public PhysicsManagerParticleData Particle { get; } // 0x0000000184A379B0-0x0000000184A379E0 
		public PhysicsManagerBoneData Bone { get; } // 0x0000000183233960-0x0000000183233990 
		public PhysicsManagerMeshData Mesh { get; } // 0x0000000183235430-0x00000001832354C0 
		public PhysicsManagerTeamData Team { get; } // 0x00000001832354C0-0x0000000183235550 
		public PhysicsManagerWindData Wind { get; } // 0x0000000184A37980-0x0000000184A379B0 
		public PhysicsManagerComponent Component { get; } // 0x0000000183233E50-0x0000000183233E80 
		public PhysicsManagerCompute Compute { get; } // 0x0000000183235C30-0x0000000183235E80 
		public bool IsDelay { get; } // 0x0000000184D86F90-0x0000000184D86FA0 
		public bool IsActive { get; set; } // 0x0000000184D88E50-0x0000000184D88E60 0x0000000189EEA3B0-0x0000000189EEA3B8
		public bool IsFasterWrite { get; } // 0x0000000189EEA1D8-0x0000000189EEA28C 
		internal ComputeShader MeshWriterShader { get; } // 0x0000000189EEA28C-0x0000000189EEA350 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 54993
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
			static __c(); // 0x0000000184D46B10-0x0000000184D46B70
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _SetCustomGameLoop_b__69_11(); // 0x0000000183234FB0-0x0000000183235010
			internal void _SetCustomGameLoop_b__69_12(); // 0x0000000183235010-0x0000000183235170
			internal void _SetCustomGameLoop_b__69_13(); // 0x0000000183234DF0-0x0000000183234E60
			internal void _SetCustomGameLoop_b__69_14(); // 0x0000000183234E60-0x0000000183234EB0
			internal void _SetCustomGameLoop_b__69_15(); // 0x0000000183234EB0-0x0000000183234F00
			internal void _SetCustomGameLoop_b__69_16(); // 0x0000000183234F00-0x0000000183234F50
			internal void _SetCustomGameLoop_b__69_17(); // 0x0000000183234F50-0x0000000183234FB0
			internal bool _SetCustomGameLoop_b__69_0(PlayerLoopSystem s); // 0x0000000184294250-0x00000001842942B0
			internal bool _SetCustomGameLoop_b__69_1(PlayerLoopSystem s); // 0x0000000184294140-0x00000001842941A0
			internal bool _SetCustomGameLoop_b__69_2(PlayerLoopSystem h); // 0x00000001842940D0-0x0000000184294140
			internal bool _SetCustomGameLoop_b__69_3(PlayerLoopSystem s); // 0x0000000184294070-0x00000001842940D0
			internal bool _SetCustomGameLoop_b__69_4(PlayerLoopSystem h); // 0x00000001842942B0-0x0000000184294320
			internal bool _SetCustomGameLoop_b__69_5(PlayerLoopSystem s); // 0x0000000184294010-0x0000000184294070
			internal bool _SetCustomGameLoop_b__69_6(PlayerLoopSystem h); // 0x0000000184293E70-0x0000000184293EE0
			internal bool _SetCustomGameLoop_b__69_7(PlayerLoopSystem s); // 0x0000000184293FB0-0x0000000184294010
			internal bool _SetCustomGameLoop_b__69_8(PlayerLoopSystem h); // 0x00000001842941A0-0x0000000184294210
			internal bool _SetCustomGameLoop_b__69_9(PlayerLoopSystem s); // 0x0000000184293F50-0x0000000184293FB0
			internal bool _SetCustomGameLoop_b__69_10(PlayerLoopSystem h); // 0x00000001845F40F0-0x00000001845F4160
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass70_0 // TypeDefIndex: 54994
		{
			// Fields
			public System.Type t; // 0x10
			public Func<PlayerLoopSystem, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass70_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _CheckRegist_b__0(PlayerLoopSystem x); // 0x00000001844E7120-0x00000001844E7160
		}
	
		// Constructors
		public MagicaPhysicsManager(); // 0x00000001846D73A0-0x00000001846D7630
	
		// Methods
		public void SetGlobalTimeScale(float timeScale); // 0x0000000189EEA18C-0x0000000189EEA1B8
		public float GetGlobalTimeScale(); // 0x0000000189EEA030-0x0000000189EEA050
		protected override void Awake(); // 0x0000000184D71DC0-0x0000000184D71E00
		protected override void InitSingleton(); // 0x0000000184A378A0-0x0000000184A37980
		protected override void DuplicateDetection(MagicaPhysicsManager duplicate); // 0x0000000189EE9FC4-0x0000000189EEA030
		protected void OnEnable(); // 0x0000000184D84EB0-0x0000000184D84ED0
		protected void OnDisable(); // 0x0000000189EEA158-0x0000000189EEA18C
		private void Update(); // 0x0000000183FF1BE0-0x0000000183FF1C10
		private void FixedUpdate(); // 0x0000000183E626F0-0x0000000183E62720
		protected override void OnDestroy(); // 0x0000000189EEA050-0x0000000189EEA158
		private void AfterEarlyUpdate(); // 0x0000000183233B20-0x0000000183233B60
		private void AfterFixedUpdate(); // 0x0000000183235170-0x00000001832352A0
		private void AfterUpdate(); // 0x0000000183233B60-0x0000000183233BA0
		private void BeforeLateUpdate(); // 0x0000000183233990-0x00000001832339C0
		private void AfterLateUpdate(); // 0x00000001832339C0-0x00000001832339F0
		private void DefaultUpdate(); // 0x0000000183235550-0x0000000183235C30
		private void PostLateUpdate(); // 0x0000000183233A50-0x0000000183233A70
		private void AfterRendering(); // 0x00000001832339F0-0x0000000183233A20
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Init(); // 0x0000000184D7D2E0-0x0000000184D7D310
		[RuntimeInitializeOnLoadMethod]
		public static void InitCustomGameLoop(); // 0x0000000183FF1C10-0x0000000183FF1CB0
		public static void SetCustomGameLoop(ref PlayerLoopSystem playerLoop); // 0x0000000183326620-0x0000000183327FC0
		private static bool CheckRegist(ref PlayerLoopSystem playerLoop); // 0x0000000183324CC0-0x0000000183324E50
	}

	public abstract class WindComponent : BaseComponent // TypeDefIndex: 54996
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
		public float Main { get; set; } // 0x0000000184D86380-0x0000000184D86390 0x0000000189EEB830-0x0000000189EEB870
		public float Turbulence { get; set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000189EEB870-0x0000000189EEB89C
		public float Frequency { get; set; } // 0x00000001811EC8A0-0x00000001811EC8B0 0x0000000189EEB750-0x0000000189EEB77C
		public Vector3 MainDirection { get; set; } // 0x0000000189EEB57C-0x0000000189EEB600 0x0000000189EEB77C-0x0000000189EEB830
		public float DirectionAngleX { get; set; } // 0x0000000184D8E050-0x0000000184D8E060 0x0000000189EEB6E8-0x0000000189EEB70C
		public float DirectionAngleY { get; set; } // 0x0000000184D88360-0x0000000184D88370 0x0000000189EEB70C-0x0000000189EEB730
		public Vector3 AreaSize { get; set; } // 0x0000000184D905E0-0x0000000184D90600 0x0000000189EEB634-0x0000000189EEB6E8
		public float AreaRadius { get; set; } // 0x0000000184D86E20-0x0000000184D86E30 0x0000000189EEB600-0x0000000189EEB634
		public PhysicsManagerWindData.DirectionType DirectionType { get; set; } // 0x0000000184D86640-0x0000000184D86650 0x0000000189EEB730-0x0000000189EEB750
		internal RuntimeStatus Status { get; } // 0x0000000184D86270-0x0000000184D86280 
	
		// Constructors
		protected WindComponent(); // 0x0000000189EEB4A0-0x0000000189EEB57C
	
		// Methods
		public void SetAttenuation(float sval, float eval, bool useEval = true /* Metadata: 0x02346869 */, float cval = 0f /* Metadata: 0x0234686A */, bool useCval = false /* Metadata: 0x0234686E */); // 0x0000000189EEB3EC-0x0000000189EEB434
		protected virtual void Reset(); // 0x0000000189EEB3DC-0x0000000189EEB3EC
		protected virtual void OnValidate(); // 0x0000000189EEB278-0x0000000189EEB354
		private void OnDidApplyAnimationProperties(); // 0x0000000189EEB0D8-0x0000000189EEB108
		protected virtual void Start(); // 0x0000000189EEB434-0x0000000189EEB43C
		internal virtual void OnEnable(); // 0x0000000189EEB18C-0x0000000189EEB1C4
		internal virtual void OnDisable(); // 0x0000000189EEB108-0x0000000189EEB140
		protected virtual void OnDestroy(); // 0x0000000189EEB0AC-0x0000000189EEB0D8
		protected virtual void Update(); // 0x0000000189EEB43C-0x0000000189EEB4A0
		private void Init(); // 0x0000000189EEAF58-0x0000000189EEB0A4
		protected void OnUpdateStatus(); // 0x0000000189EEB20C-0x0000000189EEB248
		internal virtual bool VerifyData(); // 0x0000000182FFF600-0x0000000182FFF610
		protected virtual void OnInit(); // 0x0000000189EEB1CC-0x0000000189EEB20C
		protected virtual void OnDispose(); // 0x0000000189EEB140-0x0000000189EEB18C
		protected virtual void OnUpdate(); // 0x0000000189EEB248-0x0000000189EEB278
		protected virtual void OnActive(); // 0x0000000189EEB0A4-0x0000000189EEB0AC
		protected virtual void OnInactive(); // 0x0000000189EEB1C4-0x0000000189EEB1CC
		protected void EnableWind(); // 0x0000000189EEAE50-0x0000000189EEAEE0
		protected void DisableWind(); // 0x0000000189EEADA4-0x0000000189EEAE50
		private void RemoveWind(); // 0x0000000189EEB354-0x0000000189EEB3DC
		private void CreateWind(); // 0x0000000189EEAB7C-0x0000000189EEADA4
		internal Vector3 GetLocalDirection(); // 0x0000000189EEAEE0-0x0000000189EEAF58
		private void ChangeParameter(); // 0x0000000189EEA994-0x0000000189EEAB7C
		public abstract PhysicsManagerWindData.WindType GetWindType();
		public abstract PhysicsManagerWindData.ShapeType GetShapeType();
		public abstract PhysicsManagerWindData.DirectionType GetDirectionType();
		public abstract bool IsAddition();
		public abstract Vector3 GetAreaSize();
		public abstract float GetAreaVolume();
		public abstract float GetAreaLength();
		protected abstract void ResetParams();
		[CompilerGenerated]
		private object _Init_b__49_0(); // 0x000000018464E630-0x000000018464E640
	}

	public abstract class MagicaAvatarAccess : IDisposable // TypeDefIndex: 54997
	{
		// Fields
		protected MagicaAvatar owner; // 0x10
	
		// Properties
		protected MagicaAvatarRuntime Runtime { get; } // 0x0000000189EE69FC-0x0000000189EE6A1C 
	
		// Constructors
		protected MagicaAvatarAccess(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void SetParent(MagicaAvatar avatar); // 0x00000001853908C0-0x00000001853908D0
		public abstract void Create();
		public abstract void Dispose();
		public abstract void Active();
		public abstract void Inactive();
	}

	[AddComponentMenu("MagicaCloth/MagicaAvatarParts")]
	[HelpURL("https://magicasoft.jp/avatar-parts/")]
	public class MagicaAvatarParts : BaseComponent, IDataVerify // TypeDefIndex: 54998
	{
		// Fields
		private MagicaAvatar parentAvatar; // 0x18
		private Dictionary<string, Transform> boneDict; // 0x20
		private List<CoreComponent> magicaComponentList; // 0x28
	
		// Properties
		public MagicaAvatar ParentAvatar { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public bool HasParent { get; } // 0x0000000189EE74D4-0x0000000189EE7524 
		public int PartsId { get; } // 0x0000000189EE7524-0x0000000189EE752C 
	
		// Constructors
		public MagicaAvatarParts(); // 0x0000000189EE7454-0x0000000189EE74D4
	
		// Methods
		public override ComponentType GetComponentType(); // 0x0000000184DA3380-0x0000000184DA3390
		private void OnDestroy(); // 0x0000000189EE73E4-0x0000000189EE73EC
		public void Dispose(); // 0x0000000189EE6C34-0x0000000189EE6CC0
		public List<Transform> CheckOverlappingTransform(); // 0x0000000189EE6A1C-0x0000000189EE6BE8
		public Dictionary<string, Transform> GetBoneDict(); // 0x0000000189EE6CC0-0x0000000189EE6E80
		public List<CoreComponent> GetMagicaComponentList(); // 0x0000000189EE7338-0x0000000189EE73E4
		public int GetVersion(); // 0x0000000184D85B80-0x0000000184D85B90
		public void CreateVerifyData(); // 0x0000000189EE6BE8-0x0000000189EE6C34
		public Define.Error VerifyData(); // 0x0000000189EE73EC-0x0000000189EE7454
		public string GetInformation(); // 0x0000000189EE6E80-0x0000000189EE7338
	}

	public class MagicaAvatarRuntime : MagicaAvatarAccess // TypeDefIndex: 55000
	{
		// Fields
		private Dictionary<string, Transform> boneDict; // 0x18
		private Dictionary<Transform, int> boneReferenceDict; // 0x20
		private List<MagicaAvatarParts> avatarPartsList; // 0x28
		private List<ColliderComponent> colliderList; // 0x30
	
		// Properties
		public int AvatarPartsCount { get; } // 0x0000000189EE955C-0x0000000189EE959C 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 54999
		{
			// Fields
			public int partsId; // 0x10
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _RemoveAvatarParts_b__0(MagicaAvatarParts p); // 0x0000000189EEA7D8-0x0000000189EEA808
		}
	
		// Constructors
		public MagicaAvatarRuntime(); // 0x0000000189EE9404-0x0000000189EE955C
	
		// Methods
		public override void Create(); // 0x0000000189EE8870-0x0000000189EE8890
		public override void Dispose(); // 0x00000001841E1670-0x00000001841E1680
		public override void Active(); // 0x00000001841E1670-0x00000001841E1680
		public override void Inactive(); // 0x00000001841E1670-0x00000001841E1680
		public MagicaAvatarParts GetAvatarParts(int index); // 0x0000000189EE8890-0x0000000189EE88E4
		private void CreateBoneDict(); // 0x0000000189EE8650-0x0000000189EE87F8
		private void CreateColliderList(); // 0x0000000189EE87F8-0x0000000189EE8870
		public int GetColliderCount(); // 0x0000000189EE88E4-0x0000000189EE8950
		public List<Transform> CheckOverlappingTransform(); // 0x0000000189EE8474-0x0000000189EE8650
		public int AddAvatarParts(MagicaAvatarParts parts); // 0x0000000189EE752C-0x0000000189EE81A8
		private void AddBone(Transform root, Transform croot, Transform bone); // 0x0000000189EE81A8-0x0000000189EE8474
		private void ReplaceSkinMeshRenderer(SkinnedMeshRenderer skinRenderer, Dictionary<Transform, Transform> boneReplaceDict); // 0x0000000189EE9310-0x0000000189EE9404
		private void ReplaceMagicaComponent(CoreComponent comp, Dictionary<Transform, Transform> boneReplaceDict); // 0x0000000189EE92BC-0x0000000189EE9310
		public void RemoveAvatarParts(MagicaAvatarParts parts); // 0x0000000189EE8950-0x0000000189EE91E0
		public void RemoveAvatarParts(int partsId); // 0x0000000189EE91E0-0x0000000189EE92BC
	}

	[Serializable]
	public class BoneClothTarget : IDataHash, IBoneReplace // TypeDefIndex: 55002
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
		public int RootCount { get; } // 0x0000000189ED893C-0x0000000189ED897C 
		public ConnectionMode Connection { get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
		public float SameSurfaceAngle { get; } // 0x0000000184D868F0-0x0000000184D86900 
		public bool IsMeshConnection { get; } // 0x0000000189ED8924-0x0000000189ED893C 
	
		// Nested types
		public enum ConnectionMode // TypeDefIndex: 55001
		{
			Line = 0,
			MeshAutomatic = 1,
			MeshSequentialLoop = 2,
			MeshSequentialNoLoop = 3
		}
	
		// Constructors
		public BoneClothTarget(); // 0x0000000189ED88CC-0x0000000189ED8924
	
		// Methods
		public int GetDataHash(); // 0x0000000189ED85F8-0x0000000189ED8634
		public Transform GetRoot(int index); // 0x0000000189ED8688-0x0000000189ED86F4
		public int GetRootIndex(Transform root); // 0x0000000189ED8634-0x0000000189ED8688
		public void AddParentTransform(); // 0x0000000189ED81D4-0x0000000189ED8538
		public void RemoveParentTransform(); // 0x0000000189ED8768-0x0000000189ED881C
		public void ResetFuturePredictionParentTransform(); // 0x0000000189ED881C-0x0000000189ED88CC
		public void ChangeUnityPhysicsCount(bool sw); // 0x0000000189ED8538-0x0000000189ED85F8
		public void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class;
		public HashSet<Transform> GetUsedBones(); // 0x0000000189ED86F4-0x0000000189ED8768
	}

	[Serializable]
	public class ClothData : ShareDataObject // TypeDefIndex: 55011
	{
		// Fields
		private const int DATA_VERSION = 5; // Metadata: 0x02346873
		public const uint VertexFlag_End = 65536; // Metadata: 0x02346874
		public const uint VertexFlag_TriangleRotation = 131072; // Metadata: 0x02346878
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
		public int VertexUseCount { get; } // 0x0000000189EE45A0-0x0000000189EE45BC 
		public int StructDistanceConstraintCount { get; } // 0x0000000189EE4544-0x0000000189EE4558 
		public int BendDistanceConstraintCount { get; } // 0x0000000189EE4420-0x0000000189EE4434 
		public int NearDistanceConstraintCount { get; } // 0x0000000189EE44DC-0x0000000189EE44F4 
		public int ClampDistanceConstraintCount { get; } // 0x0000000189EE444C-0x0000000189EE4464 
		public int ClampDistance2ConstraintCount { get; } // 0x0000000189EE4434-0x0000000189EE444C 
		public int RestoreRotationConstraintCount { get; } // 0x0000000189EE452C-0x0000000189EE4544 
		public int ClampRotationConstraintDataCount { get; } // 0x0000000189EE4464-0x0000000189EE447C 
		public int ClampRotationConstraintRootCount { get; } // 0x0000000189EE447C-0x0000000189EE4494 
		public int AdjustRotationConstraintCount { get; } // 0x0000000189EE43F0-0x0000000189EE4408 
		public int CompositeRotationCount { get; } // 0x0000000189EE4494-0x0000000189EE44AC 
		public int TwistConstraintCount { get; } // 0x0000000189EE4588-0x0000000189EE45A0 
		public int TriangleBendConstraintCount { get; } // 0x0000000189EE4558-0x0000000189EE4570 
		public int EdgeCollisionConstraintCount { get; } // 0x0000000189EE44AC-0x0000000189EE44C4 
		public int VolumeConstraintCount { get; } // 0x0000000189EE45BC-0x0000000189EE45D4 
		public int LineRotationWorkerCount { get; } // 0x0000000189EE44C4-0x0000000189EE44DC 
		public int TriangleRotationWorkerCount { get; } // 0x0000000189EE4570-0x0000000189EE4588 
		public int PenetrationCount { get; } // 0x0000000189EE44F4-0x0000000189EE452C 
		public int BaseSkinningCount { get; } // 0x0000000189EE4408-0x0000000189EE4420 
	
		// Nested types
		private class RestoreDistanceWork // TypeDefIndex: 55003
		{
			// Fields
			public uint vertexPair; // 0x10
			public float dist; // 0x14
	
			// Constructors
			public RestoreDistanceWork(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		private class PenetrationBone // TypeDefIndex: 55004
		{
			// Fields
			public Transform bone; // 0x10
			public Transform childBone; // 0x18
	
			// Constructors
			public PenetrationBone(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		private class PenetrationWork // TypeDefIndex: 55005
		{
			// Fields
			public Transform bone; // 0x10
			public Transform childBone; // 0x18
			public int boneIndex; // 0x20
			public float distance; // 0x24
			public float weight; // 0x28
	
			// Constructors
			public PenetrationWork(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		private class VertexInfo // TypeDefIndex: 55006
		{
			// Fields
			public int vertexIndex; // 0x10
			public int parentVertexIndex; // 0x14
			public List<int> childVertexList; // 0x18
			public VertexInfo parentInfo; // 0x20
			public List<VertexInfo> childInfoList; // 0x28
	
			// Constructors
			public VertexInfo(); // 0x0000000189EEA8D0-0x0000000189EEA994
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55007
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<RestoreDistanceWork> __9__108_0; // 0x08
			public static Comparison<RestoreDistanceWork> __9__108_1; // 0x10
			public static Comparison<PenetrationConstraint.PenetrationData> __9__108_2; // 0x18
	
			// Constructors
			static __c(); // 0x0000000189EEA86C-0x0000000189EEA8D0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _CreateConstraintData_b__108_0(RestoreDistanceWork a, RestoreDistanceWork b); // 0x0000000189EEA3F0-0x0000000189EEA420
			internal int _CreateConstraintData_b__108_1(RestoreDistanceWork a, RestoreDistanceWork b); // 0x0000000189EEA3F0-0x0000000189EEA420
			internal int _CreateConstraintData_b__108_2(PenetrationConstraint.PenetrationData a, PenetrationConstraint.PenetrationData b); // 0x0000000189EEA420-0x0000000189EEA438
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass110_0 // TypeDefIndex: 55008
		{
			// Fields
			public List<float> meshVertexDepthList; // 0x10
	
			// Constructors
			public __c__DisplayClass110_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _SortTetra_b__0(int a, int b); // 0x0000000189EEA484-0x0000000189EEA520
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass111_0 // TypeDefIndex: 55009
		{
			// Fields
			public List<float> meshVertexDepthList; // 0x10
	
			// Constructors
			public __c__DisplayClass111_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _CheckTetraDirection_b__0(ulong a, ulong b); // 0x0000000189EEA520-0x0000000189EEA6CC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass114_0 // TypeDefIndex: 55010
		{
			// Fields
			public List<float> depthList; // 0x10
			public List<float> nearFixedDistList; // 0x18
	
			// Constructors
			public __c__DisplayClass114_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetUseParentVertexList_b__0(int a, int b); // 0x0000000189EEA6CC-0x0000000189EEA7D8
		}
	
		// Constructors
		public ClothData(); // 0x0000000189EE4298-0x0000000189EE43F0
	
		// Methods
		public override int GetDataHash(); // 0x0000000189EE1C58-0x0000000189EE2108
		public int GetClampRotationCount(); // 0x0000000189EE1C1C-0x0000000189EE1C58
		public int GetRestoreRotationCount(); // 0x0000000189EE2278-0x0000000189EE22B4
		public bool IsInvalidVertex(int vindex); // 0x0000000189EE39B4-0x0000000189EE3A0C
		public bool IsFixedVertex(int vindex); // 0x0000000189EE3958-0x0000000189EE3984
		public bool IsMoveVertex(int vindex); // 0x0000000189EE3A1C-0x0000000189EE3A78
		public bool IsExtendVertex(int vindex); // 0x0000000189EE392C-0x0000000189EE3958
		public bool IsLastLevel(int vindex); // 0x0000000189EE3A0C-0x0000000189EE3A1C
		public bool IsFlag(int vindex, uint flag); // 0x0000000189EE3984-0x0000000189EE39B4
		public void SetFlag(int vindex, uint flag); // 0x0000000189EE3FEC-0x0000000189EE4070
		public int GetLevel(int vindex); // 0x0000000189EE2108-0x0000000189EE2160
		public override int GetVersion(); // 0x0000000184D9EC50-0x0000000184D9EC60
		public override Define.Error VerifyData(); // 0x0000000189EE41F0-0x0000000189EE4298
		public void CreateData(PhysicsTeam team, ClothParams clothParams, PhysicsTeamData teamData, MeshData meshData, IEditorMesh editMesh, List<int> selData, Action<List<int>, List<int>, List<Vector3>, List<Vector3>, List<Vector3>, List<int>, List<int>> extensionAction = null); // 0x0000000189EE12FC-0x0000000189EE1544
		private void CreateVertexData(int vertexCount, List<int> lineList, List<int> triangleList); // 0x0000000189EE1544-0x0000000189EE1C1C
		private void CreateConstraintData(PhysicsTeam team, ClothParams clothParams, PhysicsTeamData teamData, int vertexCount, List<Vector3> wposList, List<Vector3> wnorList, List<Vector3> wtanList, List<int> lineList, List<int> triangleList); // 0x0000000189ED9088-0x0000000189EE12FC
		private void RegistTriangleBend(int v0, int v1, int v2, int v3, List<Vector3> wposList, ClothParams clothParams, List<TriangleBendConstraint.TriangleBendData> triangleBendData); // 0x0000000189EE3A78-0x0000000189EE3FEC
		private List<int> SortTetra(int v0, int v1, int v2, int v3, List<float> meshVertexDepthList); // 0x0000000189EE4070-0x0000000189EE41F0
		private List<int> CheckTetraDirection(int v0, int v1, int v2, int v3, HashSet<ulong> trianglePackSet, List<float> meshVertexDepthList); // 0x0000000189ED8C44-0x0000000189ED9088
		private bool CalcTriangleBendRestAngle(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, out float restAngle); // 0x0000000189ED897C-0x0000000189ED8C44
		private List<float> GetMeshVertexDepthList(int vertexCount, List<float> depthList); // 0x0000000189EE2160-0x0000000189EE2278
		private List<int> GetUseParentVertexList(int vertexCount, List<HashSet<int>> vlink, List<Vector3> wposList, List<float> depthList); // 0x0000000189EE22B4-0x0000000189EE314C
		private List<int> GetUseRootVertexList(List<int> parentVertexList); // 0x0000000189EE364C-0x0000000189EE3748
		private List<VertexInfo> GetUseVertexInfoList(List<int> parentVertexList); // 0x0000000189EE3748-0x0000000189EE392C
		private List<List<int>> GetUseRootLineList(List<int> parentVertexList); // 0x0000000189EE314C-0x0000000189EE364C
	}

	[Serializable]
	public class ClothParams // TypeDefIndex: 55018
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
		public Algorithm AlgorithmType { get; set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
		public bool UseGravity { get; } // 0x00000001811F33C0-0x00000001811F33D0 
		public Vector3 GravityDirection { get; set; } // 0x0000000184D9E700-0x0000000184D9E720 0x0000000184D9DB00-0x0000000184D9DB10
		public bool UseDrag { get; } // 0x0000000184D86A30-0x0000000184D86A40 
		public bool UseMaxVelocity { get; } // 0x0000000184D86800-0x0000000184D86810 
		public float MassInfluence { get; set; } // 0x0000000184D88E60-0x0000000184D88E70 0x0000000184D8E240-0x0000000184D8E250
		public float WindInfluence { get; set; } // 0x0000000184D8FD30-0x0000000184D8FD40 0x0000000184D8FD60-0x0000000184D8FD70
		public float WindRandomScale { get; set; } // 0x0000000184D8F070-0x0000000184D8F080 0x0000000184D8F0A0-0x0000000184D8F0B0
		public float WindSynchronization { get; set; } // 0x0000000184D8E570-0x0000000184D8E580 0x0000000184D8E590-0x0000000184D8E5A0
		public float MaxMoveSpeed { get; set; } // 0x0000000184D8F060-0x0000000184D8F070 0x0000000184D8F090-0x0000000184D8F0A0
		public float MaxRotationSpeed { get; set; } // 0x0000000184DA3230-0x0000000184DA3240 0x0000000184DA3330-0x0000000184DA3340
		public bool UseResetTeleport { get; set; } // 0x0000000184D88CC0-0x0000000184D88CD0 0x0000000184D88D20-0x0000000184D88D30
		public float TeleportDistance { get; set; } // 0x0000000184DA32B0-0x0000000184DA32C0 0x0000000184DA3350-0x0000000184DA3360
		public float TeleportRotation { get; set; } // 0x0000000184DA32D0-0x0000000184DA32E0 0x0000000184D87E30-0x0000000184D87E40
		public TeleportMode TeleportResetMode { get; set; } // 0x0000000184DA32C0-0x0000000184DA32D0 0x0000000184DA3360-0x0000000184DA3370
		public float ResetStabilizationTime { get; set; } // 0x0000000184D9DF30-0x0000000184D9DF40 0x0000000184D9DFF0-0x0000000184D9E000
		public bool UseDistanceDisable { get; set; } // 0x0000000184D92ED0-0x0000000184D92EE0 0x0000000184D92F60-0x0000000184D92F70
		public Transform DisableReferenceObject { get; set; } // 0x0000000184D86210-0x0000000184D86220 0x0000000185391334-0x0000000185391348
		public float DisableDistance { get; set; } // 0x0000000184D8E650-0x0000000184D8E660 0x0000000184D8E680-0x0000000184D8E690
		public float DisableFadeDistance { get; set; } // 0x0000000184D8E660-0x0000000184D8E670 0x0000000184D8E690-0x0000000184D8E6A0
		public bool UseClampDistanceRatio { get; } // 0x0000000184DA32F0-0x0000000184DA3300 
		public float ClampDistanceMinRatio { get; } // 0x0000000189EE5BEC-0x0000000189EE5C04 
		public float ClampDistanceMaxRatio { get; } // 0x0000000189EE5BD4-0x0000000189EE5BEC 
		public float ClampDistanceVelocityInfluence { get; } // 0x0000000189EE5C04-0x0000000189EE5C20 
		public bool UseClampPositionLength { get; } // 0x0000000184DA2990-0x0000000184DA29A0 
		public Vector3 ClampPositionAxisRatio { get; } // 0x0000000184DA3210-0x0000000184DA3230 
		public float ClampPositionVelocityInfluence { get; } // 0x0000000189EE5C20-0x0000000189EE5C3C 
		public bool UseClampRotation { get; } // 0x0000000184D8E520-0x0000000184D8E530 
		public float ClampRotationVelocityInfluence { get; } // 0x0000000189EE5C3C-0x0000000189EE5C58 
		public float RestoreDistanceVelocityInfluence { get; } // 0x0000000184D8E170-0x0000000184D8E180 
		public bool UseBendDistance { get; } // 0x0000000184D8FE70-0x0000000184D8FE80 
		public int BendDistanceMaxCount { get; } // 0x0000000184D90A80-0x0000000184D90A90 
		public bool UseNearDistance { get; } // 0x0000000184D92620-0x0000000184D92630 
		public int NearDistanceMaxCount { get; } // 0x0000000184DA3240-0x0000000184DA3250 
		public float NearDistanceMaxDepth { get; } // 0x0000000184DA3250-0x0000000184DA3260 
		public bool UseRestoreRotation { get; } // 0x0000000184DA2F60-0x0000000184DA2F70 
		public bool UseSpring { get; set; } // 0x0000000184D905A0-0x0000000184D905B0 0x0000000184D905B0-0x0000000184D905C0
		public float SpringPowr { get; set; } // 0x0000000184DA3270-0x0000000184DA3280 0x0000000184DA3340-0x0000000184DA3350
		public float SpringRadius { get; } // 0x0000000184D902D0-0x0000000184D902E0 
		public Vector3 SpringRadiusScale { get; } // 0x0000000184DA3280-0x0000000184DA32A0 
		public float SpringIntensity { get; } // 0x0000000184DA3260-0x0000000184DA3270 
		public AdjustMode AdjustRotationMode { get; } // 0x0000000184DA3200-0x0000000184DA3210 
		public Vector3 AdjustRotationVector { get; } // 0x0000000189EE5B80-0x0000000189EE5BD4 
		public bool UseTriangleBend { get; } // 0x0000000184DA3310-0x0000000184DA3320 
		internal float TwistRecoveryPower { get; } // 0x0000000184DA32E0-0x0000000184DA32F0 
		public bool UseVolume { get; } // 0x0000000184DA3320-0x0000000184DA3330 
		public bool UseCollision { get; } // 0x0000000184D91ED0-0x0000000184D91EE0 
		public float DynamicFriction { get; } // 0x0000000184D90D10-0x0000000184D90D20 
		public float StaticFriction { get; } // 0x0000000184DA32A0-0x0000000184DA32B0 
		public bool UsePenetration { get; set; } // 0x0000000184D90680-0x0000000184D90690 0x0000000184D90690-0x0000000184D906A0
		public float PenetrationMaxDepth { get; } // 0x0000000184D911D0-0x0000000184D911E0 
		public bool UseLineAvarageRotation { get; } // 0x0000000184D8EDA0-0x0000000184D8EDB0 
		public bool UseFixedNonRotation { get; } // 0x0000000184DA3300-0x0000000184DA3310 
	
		// Nested types
		public enum Algorithm // TypeDefIndex: 55012
		{
			Algorithm_1 = 0,
			Algorithm_2 = 1
		}
	
		public enum TeleportMode // TypeDefIndex: 55013
		{
			Reset = 0,
			Keep = 1
		}
	
		public enum AdjustMode // TypeDefIndex: 55014
		{
			Fixed = 0,
			XYMove = 1,
			XZMove = 2,
			YZMove = 3
		}
	
		public enum PenetrationMode // TypeDefIndex: 55015
		{
			SurfacePenetration = 0,
			ColliderPenetration = 1
		}
	
		public enum PenetrationAxis // TypeDefIndex: 55016
		{
			X = 0,
			Y = 1,
			Z = 2,
			InverseX = 3,
			InverseY = 4,
			InverseZ = 5
		}
	
		public enum ParamType // TypeDefIndex: 55017
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
		public ClothParams(); // 0x0000000189EE53A0-0x0000000189EE5B80
	
		// Methods
		public void SetChangeParam(ParamType ptype); // 0x0000000189EE4F08-0x0000000189EE4F60
		public bool ChangedParam(ParamType ptype); // 0x0000000189EE45D4-0x0000000189EE462C
		public void ClearChangeParam(); // 0x0000000189EE462C-0x0000000189EE4674
		public int GetParamHash(BaseCloth cloth, ParamType ptype); // 0x0000000189EE4820-0x0000000189EE4E30
		public void SetRadius(float sval, float eval); // 0x0000000189EE514C-0x0000000189EE5180
		public float GetRadius(float depth); // 0x0000000189EE4E30-0x0000000189EE4E50
		public BezierParam GetRadius(); // 0x000000018385B100-0x000000018385B110
		public void SetMass(float sval, float eval, bool useEval = true /* Metadata: 0x0234687C */, float cval = 0f /* Metadata: 0x0234687D */, bool useCval = false /* Metadata: 0x02346881 */); // 0x0000000189EE50DC-0x0000000189EE5118
		public BezierParam GetMass(); // 0x0000000184D862C0-0x0000000184D862D0
		public void SetGravity(bool sw, float sval = -9.8f /* Metadata: 0x02346882 */, float eval = -9.8f /* Metadata: 0x02346886 */); // 0x0000000189EE50A8-0x0000000189EE50DC
		public BezierParam GetGravity(); // 0x0000000189EE4784-0x0000000189EE47C4
		public void SetDrag(bool sw, float sval = 0.015f /* Metadata: 0x0234688A */, float eval = 0.015f /* Metadata: 0x0234688E */); // 0x0000000189EE5074-0x0000000189EE50A8
		public BezierParam GetDrag(); // 0x0000000189EE4744-0x0000000189EE4784
		public void SetMaxVelocity(bool sw, float sval = 3f /* Metadata: 0x02346892 */, float eval = 3f /* Metadata: 0x02346896 */); // 0x0000000189EE5118-0x0000000189EE514C
		public BezierParam GetMaxVelocity(); // 0x0000000189EE47C4-0x0000000189EE4808
		public void SetExternalForce(float massInfluence, float windInfluence, float windRandomScale, float windSynchronization); // 0x0000000184DA3150-0x0000000184DA3180
		public BezierParam GetDepthInfluence(); // 0x0000000184D861F0-0x0000000184D86200
		public void SetWorldInfluence(float maxspeed, float moveval, float rotval); // 0x0000000189EE5350-0x0000000189EE53A0
		public BezierParam GetWorldMoveInfluence(); // 0x0000000184D862B0-0x0000000184D862C0
		public BezierParam GetWorldRotationInfluence(); // 0x0000000184D862A0-0x0000000184D862B0
		public Transform GetInfluenceTarget(); // 0x0000000184D86280-0x0000000184D86290
		public void SetInfluenceTarget(Transform t); // 0x00000001863CC164-0x00000001863CC174
		public void SetTeleport(bool sw, float distance = 0.2f /* Metadata: 0x0234689A */, float rotation = 45f /* Metadata: 0x0234689E */, TeleportMode mode = TeleportMode.Reset /* Metadata: 0x023468A2 */); // 0x0000000184DA31D0-0x0000000184DA3200
		public void SetDistanceDisable(bool sw, float distance = 20f /* Metadata: 0x023468A3 */, float fadeDistance = 5f /* Metadata: 0x023468A7 */, Transform referenceObject = null); // 0x0000000189EE5038-0x0000000189EE5074
		public void SetClampDistanceRatio(bool sw, float minval = 0.1f /* Metadata: 0x023468AB */, float maxval = 1.05f /* Metadata: 0x023468AF */, float influence = 0.2f /* Metadata: 0x023468B3 */); // 0x0000000184DA3100-0x0000000184DA3130
		public void SetClampPositionLength(bool sw, float sval = 0.03f /* Metadata: 0x023468B7 */, float eval = 0.2f /* Metadata: 0x023468BB */, float ratioX = 1f /* Metadata: 0x023468BF */, float ratioY = 1f /* Metadata: 0x023468C3 */, float ratioZ = 1f /* Metadata: 0x023468C7 */, float influence = 0.2f /* Metadata: 0x023468CB */); // 0x0000000189EE4F60-0x0000000189EE4FD0
		public BezierParam GetClampPositionLength(); // 0x0000000184D88EF0-0x0000000184D88F00
		public void SetClampRotationAngle(bool sw, float sval = 0f /* Metadata: 0x023468CF */, float eval = 180f /* Metadata: 0x023468D3 */, float influence = 0.2f /* Metadata: 0x023468D7 */); // 0x0000000189EE4FD0-0x0000000189EE5038
		public BezierParam GetClampRotationAngle(Algorithm algo); // 0x0000000189EE4708-0x0000000189EE4720
		public float GetClampRotationVelocityLimit(Algorithm algo); // 0x0000000189EE4720-0x0000000189EE4744
		public void SetRestoreDistance(float influence = 1f /* Metadata: 0x023468DB */, float structStiffness = 1f /* Metadata: 0x023468DF */); // 0x0000000189EE5180-0x0000000189EE51BC
		public BezierParam GetStructDistanceStiffness(); // 0x0000000184D85F80-0x0000000184D85F90
		public BezierParam GetBendDistanceStiffness(); // 0x0000000184D8D910-0x0000000184D8D920
		public BezierParam GetNearDistanceLength(); // 0x0000000184D8DA60-0x0000000184D8DA70
		public BezierParam GetNearDistanceStiffness(); // 0x0000000184D8DAC0-0x0000000184D8DAD0
		public void SetRestoreRotation(bool sw, float sval = 0.02f /* Metadata: 0x023468E3 */, float eval = 0.001f /* Metadata: 0x023468E7 */, float influence = 0.3f /* Metadata: 0x023468EB */); // 0x0000000189EE51BC-0x0000000189EE522C
		public BezierParam GetRestoreRotationPower(Algorithm algo); // 0x0000000189EE4E50-0x0000000189EE4E68
		public float GetRestoreRotationVelocityInfluence(Algorithm algo); // 0x0000000189EE4E68-0x0000000189EE4E80
		public void SetSpring(bool sw, float power = 0f /* Metadata: 0x023468EF */, float r = 0f /* Metadata: 0x023468F3 */, float sclx = 1f /* Metadata: 0x023468F7 */, float scly = 1f /* Metadata: 0x023468FB */, float sclz = 1f /* Metadata: 0x023468FF */, float intensity = 1f /* Metadata: 0x02346903 */); // 0x0000000184DA3180-0x0000000184DA31D0
		public void SetSpringDirectionAtten(float sval, float eval, float cval); // 0x0000000189EE522C-0x0000000189EE5260
		public void SetSpringDistanceAtten(float sval, float eval, float cval); // 0x0000000189EE5260-0x0000000189EE5294
		public float GetSpringPower(); // 0x0000000189EE4EC8-0x0000000189EE4EE0
		public float GetSpringDirectionAtten(float ratio); // 0x0000000189EE4E80-0x0000000189EE4EA4
		public float GetSpringDistanceAtten(float ratio); // 0x0000000189EE4EA4-0x0000000189EE4EC8
		public void SetAdjustRotation(AdjustMode amode = AdjustMode.Fixed /* Metadata: 0x02346907 */, float power = 0f /* Metadata: 0x02346908 */); // 0x0000000184DA30F0-0x0000000184DA3100
		public void SetTriangleBend(bool sw, float sval = 1f /* Metadata: 0x0234690C */, float eval = 1f /* Metadata: 0x02346910 */); // 0x0000000189EE5294-0x0000000189EE52EC
		public BezierParam GetTriangleBendStiffness(Algorithm algo); // 0x0000000189EE4EE0-0x0000000189EE4EF8
		internal bool GetUseTwistCorrection(Algorithm algo); // 0x0000000189EE4EF8-0x0000000189EE4F08
		public void SetVolume(bool sw, float maxLength = 0.05f /* Metadata: 0x02346914 */, float stiffness = 0.5f /* Metadata: 0x02346918 */, float shear = 0.5f /* Metadata: 0x0234691C */); // 0x0000000189EE52EC-0x0000000189EE5350
		public float GetMaxVolumeLength(); // 0x0000000189EE4808-0x0000000189EE4820
		public BezierParam GetVolumeStretchStiffness(); // 0x0000000184D8D7B0-0x0000000184D8D7C0
		public BezierParam GetVolumeShearStiffness(); // 0x0000000184D87870-0x0000000184D87880
		public void SetCollision(bool sw, float dynamicFriction = 0.1f /* Metadata: 0x02346920 */, float staticFriction = 0.03f /* Metadata: 0x02346924 */); // 0x0000000184DA3130-0x0000000184DA3150
		public PenetrationMode GetPenetrationMode(); // 0x0000000184DA23C0-0x0000000184DA23D0
		public PenetrationAxis GetPenetrationAxis(); // 0x0000000184DA30E0-0x0000000184DA30F0
		public BezierParam GetPenetrationConnectDistance(); // 0x0000000184D8DA40-0x0000000184D8DA50
		public BezierParam GetPenetrationRadius(); // 0x0000000184D8D8B0-0x0000000184D8D8C0
		public BezierParam GetPenetrationDistance(); // 0x0000000184D8D8C0-0x0000000184D8D8D0
		public void ConvertToLatestAlgorithmParameter(); // 0x0000000189EE4674-0x0000000189EE4708
	}

	public class ClothSetup // TypeDefIndex: 55020
	{
		// Fields
		private int teamBoneIndex; // 0x10
		private float distanceBlendRatio; // 0x14
	
		// Properties
		public float DistanceBlendRatio { get; set; } // 0x0000000184D88D40-0x0000000184D88D50 0x0000000184D88D50-0x0000000184D88D60
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 55019
		{
			// Fields
			public ClothData clothData; // 0x10
			public Func<int, uint> funcUserFlag; // 0x18
			public ClothParams param; // 0x20
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal uint _ClothInit_b__0(int i); // 0x0000000189EFC63C-0x0000000189EFC6FC
			internal float _ClothInit_b__1(int i); // 0x0000000189EFC6FC-0x0000000189EFC728
			internal float3 _ClothInit_b__2(int i); // 0x0000000189EFC728-0x0000000189EFC794
		}
	
		// Constructors
		public ClothSetup(); // 0x0000000184DA33F0-0x0000000184DA3400
	
		// Methods
		public void ClothInit(PhysicsTeam team, MeshData meshData, ClothData clothData, ClothParams param, Func<int, uint> funcUserFlag); // 0x0000000189EECE30-0x0000000189EEED7C
		public void ClothDispose(PhysicsTeam team); // 0x0000000189EECCE4-0x0000000189EECD48
		public void ClothActive(PhysicsTeam team, ClothParams param, ClothData clothData); // 0x0000000189EECBBC-0x0000000189EECCE4
		public void ClothInactive(PhysicsTeam team); // 0x0000000189EECD48-0x0000000189EECE30
		internal void ReplaceBone<T>(PhysicsTeam team, ClothParams param, Dictionary<T, Transform> boneReplaceDict)
			where T : class;
		internal HashSet<Transform> GetUsedBones(PhysicsTeam team, ClothParams param); // 0x0000000189EEED7C-0x0000000189EEEE0C
		public void ChangeUseUnityPhysics(bool sw); // 0x0000000189EECB50-0x0000000189EECBBC
		public void ChangeData(PhysicsTeam team, ClothParams param, ClothData clothData); // 0x0000000189EEBF38-0x0000000189EECB50
	}

	[AddComponentMenu("MagicaCloth/MagicaBoneCloth")]
	[HelpURL("https://magicasoft.jp/magica-cloth-bone-cloth/")]
	public class MagicaBoneCloth : BaseCloth // TypeDefIndex: 55021
	{
		// Fields
		private const int DATA_VERSION = 7; // Metadata: 0x02346950
		private const int ERR_DATA_VERSION = 3; // Metadata: 0x02346951
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
		public BoneClothTarget ClothTarget { get; } // 0x0000000184D88EF0-0x0000000184D88F00 
		public MeshData MeshData { get; } // 0x0000000184D8D1D0-0x0000000184D8D1E0 
		private int UseTransformCount { get; } // 0x0000000189EF1B1C-0x0000000189EF1B3C 
	
		// Constructors
		public MagicaBoneCloth(); // 0x0000000189EF19E0-0x0000000189EF1B1C
	
		// Methods
		public override ComponentType GetComponentType(); // 0x0000000184DA3400-0x0000000184DA3410
		public override int GetDataHash(); // 0x0000000189EEF674-0x0000000189EEF790
		protected override void Reset(); // 0x0000000189EF162C-0x0000000189EF1634
		protected override void OnValidate(); // 0x0000000189EF12C0-0x0000000189EF12C8
		protected override void ClothInit(); // 0x0000000189EEF4B8-0x0000000189EEF4EC
		protected override void ClothDispose(); // 0x0000000189EEF494-0x0000000189EEF4B8
		protected override void ClothActive(); // 0x0000000189EEF48C-0x0000000189EEF494
		protected override uint UserFlag(int index); // 0x0000000189EF1634-0x0000000189EF1668
		protected override Transform UserTransform(int index); // 0x0000000189EF1798-0x0000000189EF17A0
		protected override float3 UserTransformLocalPosition(int vindex); // 0x0000000189EF1668-0x0000000189EF1708
		protected override quaternion UserTransformLocalRotation(int vindex); // 0x0000000189EF1708-0x0000000189EF1798
		public override BaseMeshDeformer GetDeformer(); // 0x00000001811EC580-0x00000001811EC590
		protected override MeshData GetMeshData(); // 0x0000000184D8D1D0-0x0000000184D8D1E0
		protected override void WorkerInit(); // 0x00000001841E1670-0x00000001841E1680
		public override bool IsRequiresDeformer(); // 0x00000001812081B0-0x0000000181208610
		protected override void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer); // 0x00000001841E1670-0x00000001841E1680
		protected override void ChangeUseUnityPhysics(bool sw); // 0x0000000189EEF444-0x0000000189EEF48C
		protected override void OnChangeCalculation(); // 0x0000000189EF11E4-0x0000000189EF12C0
		public List<Transform> GetTransformList(); // 0x0000000189EF0E08-0x0000000189EF1108
		private Transform GetUseTransform(int index); // 0x0000000189EF1108-0x0000000189EF1158
		public List<List<List<Transform>>> GetTransformGrid(out int maxLevel); // 0x0000000189EF0A64-0x0000000189EF0E08
		public override int GetVersion(); // 0x0000000184D9BE00-0x0000000184D9BE10
		public override int GetErrorVersion(); // 0x0000000184D8C9E0-0x0000000184D8C9F0
		public override void CreateVerifyData(); // 0x0000000189EEF4EC-0x0000000189EEF534
		public override Define.Error VerifyData(); // 0x0000000189EF17A0-0x0000000189EF19E0
		public override string GetInformation(); // 0x0000000189EEFCE0-0x0000000189EF09C0
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict);
		public override HashSet<Transform> GetUsedBones(); // 0x0000000189EF1158-0x0000000189EF11E4
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x0000000189EEF870-0x0000000189EEFC00
		public override List<int> GetEditorTriangleList(); // 0x0000000189EEFC00-0x0000000189EEFCE0
		public override List<int> GetEditorLineList(); // 0x0000000189EEF790-0x0000000189EEF870
		public override List<int> GetSelectionList(); // 0x0000000189EF09C0-0x0000000189EF0A64
		public override List<int> GetUseList(); // 0x00000001811EC580-0x00000001811EC590
		public override List<ShareDataObject> GetAllShareDataObject(); // 0x0000000189EEF60C-0x0000000189EEF674
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source); // 0x0000000189EEF534-0x0000000189EEF60C
		private void ResetParams(); // 0x0000000189EF12C8-0x0000000189EF162C
	}

	[AddComponentMenu("MagicaCloth/MagicaBoneSpring")]
	[HelpURL("https://magicasoft.jp/magica-cloth-bone-spring/")]
	public class MagicaBoneSpring : BaseCloth // TypeDefIndex: 55022
	{
		// Fields
		private const int DATA_VERSION = 7; // Metadata: 0x02346952
		private const int ERR_DATA_VERSION = 3; // Metadata: 0x02346953
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
		public BoneClothTarget ClothTarget { get; } // 0x0000000184D88EF0-0x0000000184D88F00 
		public MeshData MeshData { get; } // 0x0000000184D8D1D0-0x0000000184D8D1E0 
		private int UseTransformCount { get; } // 0x0000000189EF3930-0x0000000189EF3970 
	
		// Constructors
		public MagicaBoneSpring(); // 0x0000000189EF3790-0x0000000189EF3930
	
		// Methods
		public override ComponentType GetComponentType(); // 0x0000000184DA3410-0x0000000184DA3420
		public override int GetDataHash(); // 0x0000000189EF1D04-0x0000000189EF1E20
		protected override void Reset(); // 0x0000000189EF32D0-0x0000000189EF32D8
		protected override void OnValidate(); // 0x0000000189EF12C0-0x0000000189EF12C8
		protected override void ClothInit(); // 0x0000000189EF1B3C-0x0000000189EF1BC4
		protected override void ClothDispose(); // 0x0000000189EEF494-0x0000000189EEF4B8
		protected override void ClothActive(); // 0x0000000189EEF48C-0x0000000189EEF494
		protected override uint UserFlag(int index); // 0x0000000189EF1634-0x0000000189EF1668
		protected override Transform UserTransform(int index); // 0x0000000189EF3468-0x0000000189EF3470
		protected override float3 UserTransformLocalPosition(int vindex); // 0x0000000189EF32D8-0x0000000189EF33A8
		protected override quaternion UserTransformLocalRotation(int vindex); // 0x0000000189EF33A8-0x0000000189EF3468
		public override bool IsRequiresDeformer(); // 0x00000001812081B0-0x0000000181208610
		public override BaseMeshDeformer GetDeformer(); // 0x00000001811EC580-0x00000001811EC590
		protected override MeshData GetMeshData(); // 0x0000000184D8D1D0-0x0000000184D8D1E0
		protected override void WorkerInit(); // 0x00000001841E1670-0x00000001841E1680
		protected override void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer); // 0x00000001841E1670-0x00000001841E1680
		protected override void ChangeUseUnityPhysics(bool sw); // 0x0000000189EEF444-0x0000000189EEF48C
		protected override void OnChangeCalculation(); // 0x0000000189EF2E5C-0x0000000189EF2F64
		public List<Transform> GetTransformList(); // 0x0000000189EF2A54-0x0000000189EF2B64
		private Transform GetUseTransform(int index); // 0x0000000189EF2D4C-0x0000000189EF2DD0
		public override int GetVersion(); // 0x0000000184D9BE00-0x0000000184D9BE10
		public override int GetErrorVersion(); // 0x0000000184D8C9E0-0x0000000184D8C9F0
		public override void CreateVerifyData(); // 0x0000000189EEF4EC-0x0000000189EEF534
		public override Define.Error VerifyData(); // 0x0000000189EF3470-0x0000000189EF3790
		public override string GetInformation(); // 0x0000000189EF2370-0x0000000189EF29B0
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict);
		public override HashSet<Transform> GetUsedBones(); // 0x0000000189EF2DD0-0x0000000189EF2E5C
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x0000000189EF1F00-0x0000000189EF2290
		public override List<int> GetEditorTriangleList(); // 0x0000000189EF2290-0x0000000189EF2370
		public override List<int> GetEditorLineList(); // 0x0000000189EF1E20-0x0000000189EF1F00
		public override List<int> GetSelectionList(); // 0x0000000189EF29B0-0x0000000189EF2A54
		public override List<int> GetUseList(); // 0x0000000189EF2B64-0x0000000189EF2D4C
		public override List<ShareDataObject> GetAllShareDataObject(); // 0x0000000189EF1C9C-0x0000000189EF1D04
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source); // 0x0000000189EF1BC4-0x0000000189EF1C9C
		private void ResetParams(); // 0x0000000189EF2F64-0x0000000189EF32D0
	}

	[AddComponentMenu("MagicaCloth/MagicaMeshCloth", 100)]
	[HelpURL("https://magicasoft.jp/magica-cloth-mesh-cloth/")]
	public class MagicaMeshCloth : BaseCloth // TypeDefIndex: 55023
	{
		// Fields
		private const int DATA_VERSION = 7; // Metadata: 0x02346954
		private const int ERR_DATA_VERSION = 3; // Metadata: 0x02346955
		[SerializeField]
		private MagicaVirtualDeformer virtualDeformer; // 0xC8
		[SerializeField]
		private int virtualDeformerHash; // 0xD0
		[SerializeField]
		private int virtualDeformerVersion; // 0xD4
	
		// Properties
		public VirtualMeshDeformer Deformer { get; } // 0x0000000189EF51C8-0x0000000189EF5240 
	
		// Constructors
		public MagicaMeshCloth(); // 0x0000000189EF51C0-0x0000000189EF51C8
	
		// Methods
		public override ComponentType GetComponentType(); // 0x0000000184DA3420-0x0000000184DA3430
		public override int GetDataHash(); // 0x0000000189EF3B3C-0x0000000189EF3B7C
		protected override void Reset(); // 0x0000000189EF4E44-0x0000000189EF4E4C
		protected override void OnValidate(); // 0x0000000189EF12C0-0x0000000189EF12C8
		protected override void OnInit(); // 0x0000000189EF4ADC-0x0000000189EF4AE4
		protected override void OnActive(); // 0x0000000189EF4AC4-0x0000000189EF4ACC
		protected override void OnInactive(); // 0x0000000189EF4AD4-0x0000000189EF4ADC
		protected override void OnDispose(); // 0x0000000189EF4ACC-0x0000000189EF4AD4
		protected override uint UserFlag(int index); // 0x00000001811EC580-0x00000001811EC590
		protected override Transform UserTransform(int index); // 0x00000001811EC580-0x00000001811EC590
		protected override float3 UserTransformLocalPosition(int vindex); // 0x0000000184DA3430-0x0000000184DA3450
		protected override quaternion UserTransformLocalRotation(int vindex); // 0x0000000189EF4F38-0x0000000189EF4F7C
		public override bool IsRequiresDeformer(); // 0x0000000182FFF600-0x0000000182FFF610
		public override BaseMeshDeformer GetDeformer(); // 0x0000000189EF3B7C-0x0000000189EF3B84
		protected override MeshData GetMeshData(); // 0x0000000189EF4724-0x0000000189EF4744
		protected override void WorkerInit(); // 0x0000000189EF5068-0x0000000189EF51C0
		protected override void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer); // 0x0000000189EF4E4C-0x0000000189EF4F38
		protected override void ChangeUseUnityPhysics(bool sw); // 0x0000000189EF3970-0x0000000189EF39AC
		public override int GetVersion(); // 0x0000000184D9BE00-0x0000000184D9BE10
		public override int GetErrorVersion(); // 0x0000000184D8C9E0-0x0000000184D8C9F0
		public override void CreateVerifyData(); // 0x0000000189EEF4EC-0x0000000189EEF534
		public override Define.Error VerifyData(); // 0x0000000189EF4F7C-0x0000000189EF5068
		public override string GetInformation(); // 0x0000000189EF3C20-0x0000000189EF4724
		public bool IsValidPointSelect(); // 0x0000000189EF4A28-0x0000000189EF4AC4
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x0000000189EF3BAC-0x0000000189EF3BF8
		public override List<int> GetEditorTriangleList(); // 0x0000000189EF3BF8-0x0000000189EF3C20
		public override List<int> GetEditorLineList(); // 0x0000000189EF3B84-0x0000000189EF3BAC
		public override List<int> GetSelectionList(); // 0x0000000189EF4744-0x0000000189EF4858
		public override List<int> GetUseList(); // 0x0000000189EF4858-0x0000000189EF4A28
		public override List<ShareDataObject> GetAllShareDataObject(); // 0x0000000189EF3ABC-0x0000000189EF3B3C
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source); // 0x0000000189EF39AC-0x0000000189EF3ABC
		private void ResetParams(); // 0x0000000189EF4AE4-0x0000000189EF4E44
	}

	[AddComponentMenu("MagicaCloth/MagicaMeshSpring", 100)]
	[HelpURL("https://magicasoft.jp/magica-cloth-mesh-spring/")]
	public class MagicaMeshSpring : BaseCloth // TypeDefIndex: 55025
	{
		// Fields
		private const int DATA_VERSION = 7; // Metadata: 0x02346956
		private const int ERR_DATA_VERSION = 3; // Metadata: 0x02346957
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
		public VirtualMeshDeformer Deformer { get; } // 0x0000000189EF67A0-0x0000000189EF6818 
		public SpringData SpringData { get; } // 0x0000000184D88590-0x0000000184D885A0 
		public int UseVertexCount { get; } // 0x0000000189EF6818-0x0000000189EF6890 
		public Transform CenterTransform { get; set; } // 0x0000000184D88EF0-0x0000000184D88F00 0x0000000186902698-0x00000001869026AC
		public Axis DirectionAxis { get; set; } // 0x0000000184D9A880-0x0000000184D9A890 0x0000000184DA3470-0x0000000184DA3480
		public Vector3 CenterTransformDirection { get; } // 0x0000000189EF660C-0x0000000189EF67A0 
	
		// Nested types
		public enum Axis // TypeDefIndex: 55024
		{
			X = 0,
			Y = 1,
			Z = 2,
			InverseX = 3,
			InverseY = 4,
			InverseZ = 5
		}
	
		// Constructors
		public MagicaMeshSpring(); // 0x0000000189EF51C0-0x0000000189EF51C8
	
		// Methods
		public override ComponentType GetComponentType(); // 0x0000000184DA3450-0x0000000184DA3460
		public override int GetDataHash(); // 0x0000000189EF55CC-0x0000000189EF564C
		public SpringData.DeformerData GetDeformerData(); // 0x0000000189EF564C-0x0000000189EF566C
		protected override void Reset(); // 0x0000000189EF61C0-0x0000000189EF61C8
		protected override void OnValidate(); // 0x0000000189EF12C0-0x0000000189EF12C8
		protected override void ClothInit(); // 0x0000000189EF5240-0x0000000189EF541C
		protected override void ClothActive(); // 0x0000000189EEF48C-0x0000000189EEF494
		protected override uint UserFlag(int index); // 0x0000000184DA3460-0x0000000184DA3470
		protected override Transform UserTransform(int index); // 0x0000000184D88EF0-0x0000000184D88F00
		protected override float3 UserTransformLocalPosition(int vindex); // 0x0000000189EF626C-0x0000000189EF62D0
		protected override quaternion UserTransformLocalRotation(int vindex); // 0x0000000189EF62D0-0x0000000189EF6324
		public override bool IsRequiresDeformer(); // 0x0000000182FFF600-0x0000000182FFF610
		public override BaseMeshDeformer GetDeformer(); // 0x0000000189EF566C-0x0000000189EF56E0
		protected override MeshData GetMeshData(); // 0x00000001811EC580-0x00000001811EC590
		protected override void WorkerInit(); // 0x0000000189EF6490-0x0000000189EF660C
		protected override void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer); // 0x0000000189EF61C8-0x0000000189EF626C
		protected override void ChangeUseUnityPhysics(bool sw); // 0x0000000189EF3970-0x0000000189EF39AC
		protected override void OnChangeCalculation(); // 0x0000000189EF5D74-0x0000000189EF5E08
		public override int GetVersion(); // 0x0000000184D9BE00-0x0000000184D9BE10
		public override int GetErrorVersion(); // 0x0000000184D8C9E0-0x0000000184D8C9F0
		public override void CreateVerifyData(); // 0x0000000189EF541C-0x0000000189EF548C
		public override Define.Error VerifyData(); // 0x0000000189EF6324-0x0000000189EF6490
		public override string GetInformation(); // 0x0000000189EF58E4-0x0000000189EF5D0C
		public void VerifyDeformer(); // 0x00000001841E1670-0x00000001841E1680
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict);
		public override HashSet<Transform> GetUsedBones(); // 0x0000000189EF5D0C-0x0000000189EF5D74
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x0000000189EF56E0-0x0000000189EF58E4
		public override List<int> GetEditorTriangleList(); // 0x00000001811EC580-0x00000001811EC590
		public override List<int> GetEditorLineList(); // 0x00000001811EC580-0x00000001811EC590
		public override List<int> GetSelectionList(); // 0x00000001811EC580-0x00000001811EC590
		public override List<int> GetUseList(); // 0x00000001811EC580-0x00000001811EC590
		public override List<ShareDataObject> GetAllShareDataObject(); // 0x0000000189EF5564-0x0000000189EF55CC
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source); // 0x0000000189EF548C-0x0000000189EF5564
		private void ResetParams(); // 0x0000000189EF5E08-0x0000000189EF61C0
	}

	[Serializable]
	public class SelectionData : ShareDataObject // TypeDefIndex: 55027
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x0234695E
		public const int Invalid = 0; // Metadata: 0x0234695F
		public const int Move = 1; // Metadata: 0x02346960
		public const int Fixed = 2; // Metadata: 0x02346961
		public const int Extend = 3; // Metadata: 0x02346962
		public List<DeformerSelection> selectionList; // 0x20
	
		// Properties
		public int DeformerCount { get; } // 0x0000000189EFC5A4-0x0000000189EFC5E4 
	
		// Nested types
		[Serializable]
		public class DeformerSelection : IDataHash // TypeDefIndex: 55026
		{
			// Fields
			public List<int> selectData; // 0x10
			public List<ulong> vertexHashList; // 0x18
	
			// Constructors
			public DeformerSelection(); // 0x0000000189EEF3C4-0x0000000189EEF444
	
			// Methods
			public int GetDataHash(); // 0x0000000189EEF388-0x0000000189EEF3C4
			public bool Compare(DeformerSelection data); // 0x0000000189EEF234-0x0000000189EEF388
		}
	
		// Constructors
		public SelectionData(); // 0x0000000189EFC54C-0x0000000189EFC5A4
	
		// Methods
		public override int GetDataHash(); // 0x0000000189EFB50C-0x0000000189EFB548
		public override int GetVersion(); // 0x0000000182BBE540-0x0000000182BBE550
		public override Define.Error VerifyData(); // 0x0000000189EFC518-0x0000000189EFC54C
		public bool Compare(SelectionData sel); // 0x0000000189EFB430-0x0000000189EFB50C
		public List<int> GetSelectionData(MeshData meshData, List<MeshData> childMeshDataList); // 0x0000000189EFB548-0x0000000189EFB700
		private int GetSelection(MeshData meshData, int vindex, Dictionary<int, List<uint>> dict, List<MeshData> childMeshDataList, List<Dictionary<ulong, int>> hashList); // 0x0000000189EFB960-0x0000000189EFBE2C
		public void SetSelectionData(MeshData meshData, List<int> selects, List<MeshData> childMeshDataList); // 0x0000000189EFBE2C-0x0000000189EFC518
		private List<Dictionary<ulong, int>> GetSelectionVertexHashList(); // 0x0000000189EFB700-0x0000000189EFB960
	}

	[Serializable]
	public class SpringData : ShareDataObject // TypeDefIndex: 55029
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x02346963
		public DeformerData deformerData; // 0x20
		public Vector3 initScale; // 0x28
	
		// Properties
		public int UseVertexCount { get; } // 0x0000000189EFC620-0x0000000189EFC63C 
	
		// Nested types
		[Serializable]
		public class DeformerData : IDataHash // TypeDefIndex: 55028
		{
			// Fields
			public int deformerDataHash; // 0x10
			public int vertexCount; // 0x14
			public int[] useVertexIndexList; // 0x18
			public float[] weightList; // 0x20
	
			// Properties
			public int UseVertexCount { get; } // 0x0000000189EEF220-0x0000000189EEF234 
	
			// Constructors
			public DeformerData(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public int GetDataHash(); // 0x0000000189EEF18C-0x0000000189EEF220
		}
	
		// Constructors
		public SpringData(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		public override int GetDataHash(); // 0x0000000189EFC5E4-0x0000000189EFC604
		public override int GetVersion(); // 0x0000000182BBE540-0x0000000182BBE550
		public override Define.Error VerifyData(); // 0x0000000189EFC604-0x0000000189EFC620
	}

	public static class Define // TypeDefIndex: 55034
	{
		// Nested types
		public static class Compute // TypeDefIndex: 55030
		{
			// Fields
			public const float Epsilon = 1E-06f; // Metadata: 0x02346964
			public const float CollisionFrictionRange = 0.03f; // Metadata: 0x02346968
			public const float FrictionDampingRate = 0.6f; // Metadata: 0x0234696C
			public const float FrictionMoveRatio = 0.5f; // Metadata: 0x02346970
			public const float FrictionPower = 4f; // Metadata: 0x02346974
			public const float ClampPositionMaxVelocity = 1f; // Metadata: 0x02346978
			public const float GlobalColliderMaxMoveDistance = 0.2f; // Metadata: 0x0234697C
			public const float GlobalColliderMaxRotationAngle = 10f; // Metadata: 0x02346980
			public const float ColliderExtrusionMaxPower = 0.4f; // Metadata: 0x02346984
			public const float ColliderExtrusionDirectionPower = 0.3f; // Metadata: 0x02346988
			public const float ColliderExtrusionDistPower = 2f; // Metadata: 0x0234698C
			public const float ColliderExtrusionVelocityInfluence = 0.25f; // Metadata: 0x02346990
			public const float MaxWindMain = 100f; // Metadata: 0x02346994
			public const float ClampRotationMaxVelocity = 1f; // Metadata: 0x02346998
			public const float ClampRotationMaxVelocity2 = 2f; // Metadata: 0x0234699C
			public const float TriangleBendVelocityInfluence = 0.5f; // Metadata: 0x023469A0
		}
	
		public enum Error // TypeDefIndex: 55031
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
	
		public static class OptimizeMesh // TypeDefIndex: 55032
		{
			// Fields
			public const int Unknown = 0; // Metadata: 0x02346A36
			public const int Nothing = 1; // Metadata: 0x02346A37
			public const int Unity2018_On = 16; // Metadata: 0x02346A38
			public const int Unity2019_PolygonOrder = 256; // Metadata: 0x02346A39
			public const int Unity2019_VertexOrder = 512; // Metadata: 0x02346A3B
		}
	
		public static class RenderMesh // TypeDefIndex: 55033
		{
			// Fields
			public const int WorkerMultiplesOfVertexCollection = 3; // Metadata: 0x02346A3D
		}
	
		// Methods
		public static bool IsNormal(Error err); // 0x0000000186911EF8-0x0000000186911F00
		public static bool IsError(Error err); // 0x0000000189EEF16C-0x0000000189EEF180
		public static bool IsWarning(Error err); // 0x0000000189EEF180-0x0000000189EEF18C
		public static string GetErrorMessage(Error err); // 0x0000000189EEEE0C-0x0000000189EEF16C
	}

	[Serializable]
	public abstract class BaseMeshDeformer : IEditorMesh, IDataVerify, IDataHash // TypeDefIndex: 55035
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
		[CompilerGenerated]
		private int _MeshIndex_k__BackingField; // 0x38
		[CompilerGenerated]
		private int _VertexCount_k__BackingField; // 0x3C
		[CompilerGenerated]
		private int _SkinningVertexCount_k__BackingField; // 0x40
		[CompilerGenerated]
		private int _TriangleCount_k__BackingField; // 0x44
	
		// Properties
		public CoreComponent Parent { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public virtual MeshData MeshData { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public GameObject TargetObject { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public RuntimeStatus Status { get; } // 0x0000000184D86240-0x0000000184D86250 
		public int MeshIndex { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D863B0-0x0000000184D863C0 0x0000000184D86430-0x0000000184D86440
		public int VertexCount { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D86640-0x0000000184D86650 0x0000000184D86670-0x0000000184D86680
		public int SkinningVertexCount { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D865E0-0x0000000184D865F0 0x0000000184D86610-0x0000000184D86620
		public int TriangleCount { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D86530-0x0000000184D86540 0x0000000184D86580-0x0000000184D86590
		public bool IsSkinning { get; } // 0x0000000189EEBE70-0x0000000189EEBEDC 
		public int BoneCount { get; } // 0x0000000189EEBDF8-0x0000000189EEBE70 
		public int SaveDataHash { get; } // 0x0000000182B70F90-0x0000000182B70FA0 
		public int SaveDataVersion { get; } // 0x00000001811F0020-0x00000001811F0030 
	
		// Constructors
		protected BaseMeshDeformer(); // 0x0000000189EEBD8C-0x0000000189EEBDF8
	
		// Methods
		public virtual void Init(); // 0x0000000189EEBA2C-0x0000000189EEBB80
		protected virtual void OnInit(); // 0x0000000189EEBBF0-0x0000000189EEBC54
		public virtual void Dispose(); // 0x0000000189EEB8CC-0x0000000189EEB954
		public virtual void OnEnable(); // 0x0000000189EEBBB8-0x0000000189EEBBF0
		public virtual void OnDisable(); // 0x0000000189EEBB80-0x0000000189EEBBB8
		public virtual void Update(); // 0x0000000189EEBC90-0x0000000189EEBCD4
		internal abstract void MeshCalculation(int bufferIndex);
		internal abstract void NormalWriting(int bufferIndex);
		protected void OnUpdateStatus(); // 0x0000000189EEBC54-0x0000000189EEBC90
		protected virtual void OnActive(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnInactive(); // 0x00000001841E1670-0x00000001841E1680
		public virtual bool IsMeshUse(); // 0x00000001812081B0-0x0000000181208610
		public virtual bool IsActiveMesh(); // 0x00000001812081B0-0x0000000181208610
		public virtual void AddUseMesh(object parent); // 0x00000001841E1670-0x00000001841E1680
		public virtual void RemoveUseMesh(object parent); // 0x00000001841E1670-0x00000001841E1680
		public virtual bool AddUseVertex(int vindex, bool fix); // 0x00000001812081B0-0x0000000181208610
		public virtual bool RemoveUseVertex(int vindex, bool fix); // 0x00000001812081B0-0x0000000181208610
		public virtual void ResetFuturePrediction(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void ChangeUseUnityPhysics(bool sw); // 0x00000001841E1670-0x00000001841E1680
		public virtual int GetDataHash(); // 0x0000000189EEB954-0x0000000189EEBA00
		public abstract int GetVersion();
		public virtual Define.Error VerifyData(); // 0x0000000189EEBCD4-0x0000000189EEBD8C
		public virtual void CreateVerifyData(); // 0x0000000189EEB89C-0x0000000189EEB8CC
		public virtual string GetInformation(); // 0x0000000189EEBA00-0x0000000189EEBA2C
		public abstract int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList);
		public abstract List<int> GetEditorTriangleList();
		public abstract List<int> GetEditorLineList();
		[CompilerGenerated]
		private object _Init_b__33_0(); // 0x00000001811F36E0-0x00000001811F36F0
	}

	[AddComponentMenu("MagicaCloth/MagicaRenderDeformer")]
	[HelpURL("https://magicasoft.jp/magica-cloth-render-deformer/")]
	public class MagicaRenderDeformer : CoreComponent // TypeDefIndex: 55036
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x02346A3E
		private const int ERR_DATA_VERSION = 0; // Metadata: 0x02346A3F
		[SerializeField]
		private RenderMeshDeformer deformer; // 0x38
		[SerializeField]
		private int deformerHash; // 0x40
		[SerializeField]
		private int deformerVersion; // 0x44
		[CompilerGenerated]
		private PhysicsTeam.TeamCullingMode _cullModeCash_k__BackingField; // 0x48
	
		// Properties
		internal PhysicsTeam.TeamCullingMode cullModeCash { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D863D0-0x0000000184D863E0 0x0000000184D86450-0x0000000184D86460
		public RenderMeshDeformer Deformer { get; } // 0x0000000189EF7280-0x0000000189EF72AC 
	
		// Constructors
		public MagicaRenderDeformer(); // 0x0000000189EF720C-0x0000000189EF7280
	
		// Methods
		public override ComponentType GetComponentType(); // 0x0000000184DA3480-0x0000000184DA3490
		public override int GetDataHash(); // 0x0000000189EF6A60-0x0000000189EF6A88
		private void OnValidate(); // 0x0000000189EF6DE0-0x0000000189EF6E04
		protected override void OnInit(); // 0x0000000189EF6D98-0x0000000189EF6DBC
		protected override void OnDispose(); // 0x0000000189EF6D4C-0x0000000189EF6D74
		protected override void OnUpdate(); // 0x0000000189EF6DBC-0x0000000189EF6DE0
		protected override void OnActive(); // 0x0000000189EF6C0C-0x0000000189EF6C30
		protected override void OnInactive(); // 0x0000000189EF6D74-0x0000000189EF6D98
		protected void OnBecameVisible(); // 0x0000000189EF6C78-0x0000000189EF6CC0
		protected void OnBecameInvisible(); // 0x0000000189EF6C30-0x0000000189EF6C78
		internal override void UpdateCullingMode(CoreComponent caller); // 0x0000000189EF6E04-0x0000000189EF7170
		protected override void OnChangeCalculation(); // 0x0000000189EF6CC0-0x0000000189EF6D4C
		public override int GetVersion(); // 0x0000000182BBE540-0x0000000182BBE550
		public override int GetErrorVersion(); // 0x00000001811EC580-0x00000001811EC590
		public override void CreateVerifyData(); // 0x0000000189EF68C4-0x0000000189EF690C
		public override Define.Error VerifyData(); // 0x0000000189EF7170-0x0000000189EF720C
		public override string GetInformation(); // 0x0000000189EF6B24-0x0000000189EF6B6C
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict);
		public override HashSet<Transform> GetUsedBones(); // 0x0000000189EF6B90-0x0000000189EF6C0C
		protected override void ChangeUseUnityPhysics(bool sw); // 0x0000000189EF6890-0x0000000189EF68C4
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x0000000189EF6AB0-0x0000000189EF6AFC
		public override List<int> GetEditorTriangleList(); // 0x0000000189EF6AFC-0x0000000189EF6B24
		public override List<int> GetEditorLineList(); // 0x0000000189EF6A88-0x0000000189EF6AB0
		public override List<int> GetUseList(); // 0x0000000189EF6B6C-0x0000000189EF6B90
		public override List<ShareDataObject> GetAllShareDataObject(); // 0x0000000189EF69EC-0x0000000189EF6A60
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source); // 0x0000000189EF690C-0x0000000189EF69EC
	}

	[AddComponentMenu("MagicaCloth/MagicaVirtualDeformer")]
	[HelpURL("https://magicasoft.jp/magica-cloth-virtual-deformer/")]
	public class MagicaVirtualDeformer : CoreComponent // TypeDefIndex: 55037
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x02346A40
		private const int ERR_DATA_VERSION = 0; // Metadata: 0x02346A41
		[SerializeField]
		private VirtualMeshDeformer deformer; // 0x38
		[SerializeField]
		private int deformerHash; // 0x40
		[SerializeField]
		private int deformerVersion; // 0x44
		[CompilerGenerated]
		private PhysicsTeam.TeamCullingMode _cullModeCash_k__BackingField; // 0x48
	
		// Properties
		internal PhysicsTeam.TeamCullingMode cullModeCash { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D863D0-0x0000000184D863E0 0x0000000184D86450-0x0000000184D86460
		public VirtualMeshDeformer Deformer { get; } // 0x0000000189EF7280-0x0000000189EF72AC 
	
		// Constructors
		public MagicaVirtualDeformer(); // 0x0000000189EF7C98-0x0000000189EF7D0C
	
		// Methods
		public override ComponentType GetComponentType(); // 0x0000000184DA3490-0x0000000184DA34A0
		public override int GetDataHash(); // 0x0000000189EF6A60-0x0000000189EF6A88
		private void OnValidate(); // 0x00000001841E1670-0x00000001841E1680
		protected override void OnInit(); // 0x0000000189EF7810-0x0000000189EF7848
		protected override void OnDispose(); // 0x0000000189EF77D4-0x0000000189EF7810
		protected override void OnUpdate(); // 0x0000000189EF6DBC-0x0000000189EF6DE0
		protected override void OnActive(); // 0x0000000189EF6C0C-0x0000000189EF6C30
		protected override void OnInactive(); // 0x0000000189EF6D74-0x0000000189EF6D98
		private void LinkRenderDeformerStatus(bool sw); // 0x0000000189EF76A4-0x0000000189EF77A0
		protected override void ChangeUseUnityPhysics(bool sw); // 0x0000000189EF72AC-0x0000000189EF7348
		internal override void UpdateCullingMode(CoreComponent caller); // 0x0000000189EF7848-0x0000000189EF7C2C
		protected override void OnChangeCalculation(); // 0x0000000189EF77A0-0x0000000189EF77D4
		public override int GetVersion(); // 0x0000000182BBE540-0x0000000182BBE550
		public override int GetErrorVersion(); // 0x00000001811EC580-0x00000001811EC590
		public override void CreateVerifyData(); // 0x0000000189EF68C4-0x0000000189EF690C
		public override Define.Error VerifyData(); // 0x0000000189EF7C2C-0x0000000189EF7C98
		public override string GetInformation(); // 0x0000000189EF6B24-0x0000000189EF6B6C
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict);
		public override HashSet<Transform> GetUsedBones(); // 0x0000000189EF7628-0x0000000189EF76A4
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x0000000189EF6AB0-0x0000000189EF6AFC
		public override List<int> GetEditorTriangleList(); // 0x0000000189EF6AFC-0x0000000189EF6B24
		public override List<int> GetEditorLineList(); // 0x0000000189EF6A88-0x0000000189EF6AB0
		public override List<int> GetUseList(); // 0x0000000189EF749C-0x0000000189EF7628
		public override List<ShareDataObject> GetAllShareDataObject(); // 0x0000000189EF7428-0x0000000189EF749C
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source); // 0x0000000189EF7348-0x0000000189EF7428
	}

	[Serializable]
	public class MeshData : ShareDataObject // TypeDefIndex: 55040
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x02346A42
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
		public int VertexCount { get; } // 0x00000001811F0020-0x00000001811F0030 
		public int VertexHashCount { get; } // 0x0000000189EF88A8-0x0000000189EF88BC 
		public int WeightCount { get; } // 0x0000000189EF88BC-0x0000000189EF88D0 
		public int LineCount { get; } // 0x0000000184D863D0-0x0000000184D863E0 
		public int TriangleCount { get; } // 0x0000000184D86570-0x0000000184D86580 
		public int BoneCount { get; } // 0x0000000184D86CF0-0x0000000184D86D00 
		public int ChildCount { get; } // 0x0000000189EF8868-0x0000000189EF88A8 
	
		// Nested types
		[Serializable]
		public struct VertexWeight // TypeDefIndex: 55038
		{
			// Fields
			public Vector3 localPos; // 0x00
			public Vector3 localNor; // 0x0C
			public Vector3 localTan; // 0x18
			public int parentIndex; // 0x24
			public float weight; // 0x28
		}
	
		[Serializable]
		public class ChildData : IDataHash // TypeDefIndex: 55039
		{
			// Fields
			public int childDataHash; // 0x10
			public int vertexCount; // 0x14
			public uint[] vertexInfoList; // 0x18
			public VertexWeight[] vertexWeightList; // 0x20
			public int[] parentIndexList; // 0x28
	
			// Properties
			public int VertexCount { get; } // 0x0000000184D882A0-0x0000000184D882B0 
	
			// Constructors
			public ChildData(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public int GetDataHash(); // 0x0000000189EEBEDC-0x0000000189EEBF38
		}
	
		// Constructors
		public MeshData(); // 0x0000000189EF8808-0x0000000189EF8868
	
		// Methods
		public override int GetDataHash(); // 0x0000000189EF8428-0x0000000189EF862C
		public override int GetVersion(); // 0x0000000182BBE540-0x0000000182BBE550
		public override Define.Error VerifyData(); // 0x0000000189EF87EC-0x0000000189EF8808
		public Dictionary<int, List<uint>> GetVirtualToChildVertexDict(); // 0x0000000189EF862C-0x0000000189EF87EC
		public List<int> ExtendSelection(List<int> originalSelection, bool extendNext, bool extendWeight); // 0x0000000189EF7D0C-0x0000000189EF8428
	}

	[Serializable]
	public class RenderMeshDeformer : BaseMeshDeformer, IBoneReplace // TypeDefIndex: 55043
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x02346A43
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
		[CompilerGenerated]
		private bool _IsChangePosition_k__BackingField; // 0x98
		[CompilerGenerated]
		private bool _IsChangeNormalTangent_k__BackingField; // 0x99
		[CompilerGenerated]
		private bool _IsChangeBoneWeights_k__BackingField; // 0x9A
		private bool oldUse; // 0x9B
		[CompilerGenerated]
		private bool _IsWriteSkip_k__BackingField; // 0x9C
		[CompilerGenerated]
		private bool _IsFasterWriteUpdate_k__BackingField; // 0x9D
		[CompilerGenerated]
		private bool _IsWriteMeshPosition_k__BackingField; // 0x9E
		[CompilerGenerated]
		private bool _IsWriteMeshBoneWeight_k__BackingField; // 0x9F
		private bool IsWriteMeshNormal; // 0xA0
		private bool IsWriteMeshTangent; // 0xA1
		[CompilerGenerated]
		private bool _IsFasterWrite_k__BackingField; // 0xA2
	
		// Properties
		private bool IsChangePosition { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86C50-0x0000000184D86C60 0x0000000184D86C70-0x0000000184D86C80
		private bool IsChangeNormalTangent { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA34C0-0x0000000184DA34D0 0x0000000184DA3510-0x0000000184DA3520
		private bool IsChangeBoneWeights { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA34B0-0x0000000184DA34C0 0x0000000184DA3500-0x0000000184DA3510
		internal bool IsWriteSkip { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D92ED0-0x0000000184D92EE0 0x0000000184D92F60-0x0000000184D92F70
		internal bool IsFasterWriteUpdate { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA34D0-0x0000000184DA34E0 0x0000000184DA3520-0x0000000184DA3530
		internal bool IsWriteMeshPosition { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA34F0-0x0000000184DA3500 0x0000000184DA3540-0x0000000184DA3550
		internal bool IsWriteMeshBoneWeight { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA34E0-0x0000000184DA34F0 0x0000000184DA3530-0x0000000184DA3540
		public Mesh SharedMesh { get; } // 0x0000000184D86270-0x0000000184D86280 
		internal bool IsFasterWrite { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D90800-0x0000000184D90810 0x0000000184D90810-0x0000000184D90820
		public bool IsRendererVisible { get; } // 0x0000000189EFB3C4-0x0000000189EFB430 
		internal bool HasNormal { get; } // 0x0000000189EFB3B0-0x0000000189EFB3C4 
	
		// Nested types
		public enum RecalculateMode // TypeDefIndex: 55041
		{
			None = 0,
			UpdateNormalPerFrame = 1,
			UpdateNormalAndTangentPerFrame = 2
		}
	
		public enum BoundsMode // TypeDefIndex: 55042
		{
			None = 0,
			ExpandedAtInitialization = 1
		}
	
		// Constructors
		public RenderMeshDeformer(); // 0x0000000189EFB3A0-0x0000000189EFB3B0
	
		// Methods
		public override int GetDataHash(); // 0x0000000189EF8F14-0x0000000189EF8F98
		public void OnValidate(); // 0x0000000189EFAE54-0x0000000189EFAE94
		protected override void OnInit(); // 0x0000000189EFA570-0x0000000189EFAE54
		protected override void OnActive(); // 0x0000000189EFA36C-0x0000000189EFA47C
		protected override void OnInactive(); // 0x0000000189EFA47C-0x0000000189EFA570
		public override void Dispose(); // 0x0000000189EF8CD4-0x0000000189EF8DC8
		private void SetRecalculateNormalAndTangentMode(); // 0x0000000189EFB184-0x0000000189EFB25C
		public override void ChangeUseUnityPhysics(bool sw); // 0x0000000189EF8C50-0x0000000189EF8CD4
		public void ChangeCalculation(bool sw); // 0x0000000189EF8BC0-0x0000000189EF8C50
		public override bool IsMeshUse(); // 0x0000000189EF9D88-0x0000000189EF9E00
		public override bool IsActiveMesh(); // 0x0000000189EF9D10-0x0000000189EF9D88
		public override void AddUseMesh(object parent); // 0x0000000189EF88D0-0x0000000189EF8BC0
		public override void RemoveUseMesh(object parent); // 0x0000000189EFAE94-0x0000000189EFB184
		internal override void MeshCalculation(int bufferIndex); // 0x0000000189EF9E00-0x0000000189EFA1F4
		internal override void NormalWriting(int bufferIndex); // 0x0000000189EFA1F4-0x0000000189EFA36C
		internal bool FasterWriting(int bufferIndex, ComputeShader compute, int kernel, int index, ref int maxVertexCount); // 0x0000000189EF8DC8-0x0000000189EF8F14
		public void ChangeNormalTangentUpdateMode(); // 0x0000000184DA34A0-0x0000000184DA34B0
		public void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class;
		public HashSet<Transform> GetUsedBones(); // 0x0000000189EF9C0C-0x0000000189EF9D10
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x0000000189EF8F98-0x0000000189EF9328
		public override List<int> GetEditorTriangleList(); // 0x0000000189EF9328-0x0000000189EF93D8
		public override List<int> GetEditorLineList(); // 0x00000001811EC580-0x00000001811EC590
		public List<int> GetEditorUseList(); // 0x0000000189EF93D8-0x0000000189EF945C
		public override int GetVersion(); // 0x0000000182BBE540-0x0000000182BBE550
		public override Define.Error VerifyData(); // 0x0000000189EFB25C-0x0000000189EFB3A0
		private Mesh GetTargetSharedMesh(); // 0x0000000189EF9AD4-0x0000000189EF9C0C
		public override string GetInformation(); // 0x0000000189EF945C-0x0000000189EF9AD4
	}

	[Serializable]
	public class VirtualMeshDeformer : BaseMeshDeformer, IBoneReplace // TypeDefIndex: 55045
	{
		// Fields
		private const int DATA_VERSION = 1; // Metadata: 0x02346A49
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
		public float MergeVertexDistance { get; } // 0x0000000184D91500-0x0000000184D91510 
		public float MergeTriangleDistance { get; } // 0x0000000184D88480-0x0000000184D88490 
		public float SameSurfaceAngle { get; } // 0x0000000184D88470-0x0000000184D88480 
		public int MaxWeightCount { get; } // 0x0000000189EFEAC4-0x0000000189EFEAF0 
		public float WeightPow { get; } // 0x0000000184D90610-0x0000000184D90620 
		public int RenderDeformerCount { get; } // 0x0000000189EFEAF0-0x0000000189EFEB30 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0 // TypeDefIndex: 55044
		{
			// Fields
			public RenderMeshDeformer deformer; // 0x10
	
			// Constructors
			public __c__DisplayClass35_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetRenderMeshDeformerIndex_b__0(MagicaRenderDeformer d); // 0x0000000189F10814-0x0000000189F10844
		}
	
		// Constructors
		public VirtualMeshDeformer(); // 0x0000000189EFE954-0x0000000189EFEAC4
	
		// Methods
		public override int GetDataHash(); // 0x0000000189EFCDD0-0x0000000189EFCEB8
		protected override void OnInit(); // 0x0000000189EFDE7C-0x0000000189EFE378
		public override void Dispose(); // 0x0000000189EFCBA8-0x0000000189EFCDD0
		protected override void OnActive(); // 0x0000000189EFDD10-0x0000000189EFDDB8
		protected override void OnInactive(); // 0x0000000189EFDDB8-0x0000000189EFDE7C
		internal override void MeshCalculation(int bufferIndex); // 0x00000001841E1670-0x00000001841E1680
		internal override void NormalWriting(int bufferIndex); // 0x00000001841E1670-0x00000001841E1680
		public void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class;
		public HashSet<Transform> GetUsedBones(); // 0x0000000189EFDBAC-0x0000000189EFDC20
		public BaseMeshDeformer GetDeformer(); // 0x000000018464E630-0x000000018464E640
		public MagicaRenderDeformer GetRenderDeformer(int index); // 0x0000000189EFDA88-0x0000000189EFDADC
		public int GetRenderMeshDeformerIndex(RenderMeshDeformer deformer); // 0x0000000189EFDADC-0x0000000189EFDBAC
		public List<MeshData> GetRenderDeformerMeshList(); // 0x0000000189EFD938-0x0000000189EFDA88
		public override bool IsMeshUse(); // 0x0000000189EFDC98-0x0000000189EFDD10
		public override bool IsActiveMesh(); // 0x0000000189EFDC20-0x0000000189EFDC98
		public override void AddUseMesh(object parent); // 0x0000000189EFC794-0x0000000189EFC878
		public override void RemoveUseMesh(object parent); // 0x0000000189EFE378-0x0000000189EFE45C
		public override bool AddUseVertex(int vindex, bool fix); // 0x0000000189EFC878-0x0000000189EFC910
		public override bool RemoveUseVertex(int vindex, bool fix); // 0x0000000189EFE45C-0x0000000189EFE4F4
		public override void ResetFuturePrediction(); // 0x0000000189EFE4F4-0x0000000189EFE554
		public override void ChangeUseUnityPhysics(bool sw); // 0x0000000189EFC9A0-0x0000000189EFCA24
		public void ChangeCalculation(bool sw); // 0x0000000189EFC910-0x0000000189EFC9A0
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x0000000189EFCF6C-0x0000000189EFD284
		public override List<int> GetEditorTriangleList(); // 0x0000000189EFD284-0x0000000189EFD338
		public override List<int> GetEditorLineList(); // 0x0000000189EFCEB8-0x0000000189EFCF6C
		public override int GetVersion(); // 0x0000000184D85B80-0x0000000184D85B90
		public override void CreateVerifyData(); // 0x0000000189EFCA24-0x0000000189EFCBA8
		public override Define.Error VerifyData(); // 0x0000000189EFE554-0x0000000189EFE954
		public override string GetInformation(); // 0x0000000189EFD338-0x0000000189EFD938
	}

	public class ClampDistance2Constraint : PhysicsManagerConstraint // TypeDefIndex: 55050
	{
		// Fields
		private FixedChunkNativeArray<ClampDistance2Data> dataList; // 0x20
		private FixedChunkNativeArray<ClampDistance2RootInfo> rootInfoList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
		private FixedChunkNativeArray<int> rootTeamList; // 0x38
	
		// Nested types
		[Serializable]
		public struct ClampDistance2Data // TypeDefIndex: 55046
		{
			// Fields
			public int vertexIndex; // 0x00
			public int parentVertexIndex; // 0x04
			public float length; // 0x08
		}
	
		[Serializable]
		public struct ClampDistance2RootInfo // TypeDefIndex: 55047
		{
			// Fields
			public ushort startIndex; // 0x00
			public ushort dataLength; // 0x02
		}
	
		public struct GroupData // TypeDefIndex: 55048
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
		private struct ClampDistance2Job : IJobParallelFor // TypeDefIndex: 55049
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
			public void Execute(int rootIndex); // 0x0000000189EFFC40-0x0000000189F000A0
		}
	
		// Constructors
		public ClampDistance2Constraint(); // 0x0000000184D89110-0x0000000184D89120
	
		// Methods
		public override void Create(); // 0x0000000189EFF51C-0x0000000189EFF674
		public override void Release(); // 0x0000000189EFF674-0x0000000189EFF71C
		public int AddGroup(int teamId, bool active, float minRatio, float maxRatio, float velocityInfluence, ClampDistance2Data[] dataArray, ClampDistance2RootInfo[] rootInfoArray); // 0x0000000189EFF0A8-0x0000000189EFF36C
		public override void RemoveTeam(int teamId); // 0x0000000189EFF71C-0x0000000189EFF91C
		public void ChangeParam(int teamId, bool active, float minRatio, float maxRatio, float velocityInfluence); // 0x0000000189EFF36C-0x0000000189EFF51C
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000189EFF91C-0x0000000189EFFC40
	}

	public class ClampDistanceConstraint : PhysicsManagerConstraint // TypeDefIndex: 55054
	{
		// Fields
		private FixedChunkNativeArray<ClampDistanceData> dataList; // 0x20
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
	
		// Nested types
		[Serializable]
		public struct ClampDistanceData // TypeDefIndex: 55051
		{
			// Fields
			public ushort vertexIndex; // 0x00
			public ushort targetVertexIndex; // 0x02
			public float length; // 0x04
	
			// Methods
			public bool IsValid(); // 0x0000000189F00928-0x0000000189F0093C
		}
	
		public struct GroupData // TypeDefIndex: 55052
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
		private struct ClampDistanceJob : IJobParallelFor // TypeDefIndex: 55053
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
			public void Execute(int index); // 0x0000000189F0093C-0x0000000189F00ED8
		}
	
		// Constructors
		public ClampDistanceConstraint(); // 0x0000000184D89110-0x0000000184D89120
	
		// Methods
		public override void Create(); // 0x000000018442E0A0-0x000000018442E1B0
		public override void Release(); // 0x0000000189F00430-0x0000000189F004B8
		public int AddGroup(int teamId, bool active, float minRatio, float maxRatio, float velocityInfluence, ClampDistanceData[] dataArray, ReferenceDataIndex[] refDataArray); // 0x0000000189F000A0-0x0000000189F00280
		public override void RemoveTeam(int teamId); // 0x0000000189F004B8-0x0000000189F00628
		public void ChangeParam(int teamId, bool active, float minRatio, float maxRatio, float velocityInfluence); // 0x0000000189F00280-0x0000000189F00430
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000189F00628-0x0000000189F00928
	}

	public class ClampPositionConstraint : PhysicsManagerConstraint // TypeDefIndex: 55057
	{
		// Fields
		public FixedNativeList<GroupData> groupList; // 0x20
	
		// Nested types
		public struct GroupData // TypeDefIndex: 55055
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public CurveParam limitLength; // 0x08
			public float3 axisRatio; // 0x18
			public float velocityInfluence; // 0x24
	
			// Methods
			public bool IsAxisCheck(); // 0x0000000189F07FDC-0x0000000189F07FFC
		}
	
		[BurstCompile]
		private struct ClampPositionJob : IJobParallelFor // TypeDefIndex: 55056
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
			public void Execute(int index); // 0x0000000189F01650-0x0000000189F01C70
		}
	
		// Constructors
		public ClampPositionConstraint(); // 0x0000000184D89110-0x0000000184D89120
	
		// Methods
		public override void Create(); // 0x0000000184D2FE20-0x0000000184D2FEA0
		public override void Release(); // 0x0000000189F011D8-0x0000000189F01220
		public int AddGroup(int teamId, bool active, BezierParam limitLength, float3 axisRatio, float velocityInfluence); // 0x0000000189F00ED8-0x0000000189F01004
		public override void RemoveTeam(int teamId); // 0x0000000189F01220-0x0000000189F01304
		public void ChangeParam(int teamId, bool active, BezierParam limitLength, float3 axisRatio, float velocityInfluence); // 0x0000000189F01004-0x0000000189F011D8
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000189F01304-0x0000000189F01650
	}

	public class ClampRotationConstraint : PhysicsManagerConstraint // TypeDefIndex: 55062
	{
		// Fields
		private FixedChunkNativeArray<ClampRotationData> dataList; // 0x20
		private FixedChunkNativeArray<ClampRotationRootInfo> rootInfoList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
		private FixedChunkNativeArray<int> rootTeamList; // 0x38
		private FixedChunkNativeArray<float> lengthBuffer; // 0x40
	
		// Nested types
		[Serializable]
		public struct ClampRotationData // TypeDefIndex: 55058
		{
			// Fields
			public int vertexIndex; // 0x00
			public int parentVertexIndex; // 0x04
			public float3 localPos; // 0x08
			public quaternion localRot; // 0x14
	
			// Methods
			public bool IsValid(); // 0x0000000189F02704-0x0000000189F02714
		}
	
		[Serializable]
		public struct ClampRotationRootInfo // TypeDefIndex: 55059
		{
			// Fields
			public ushort startIndex; // 0x00
			public ushort dataLength; // 0x02
		}
	
		public struct GroupData // TypeDefIndex: 55060
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
		private struct ClampRotationJob : IJobParallelFor // TypeDefIndex: 55061
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
			public void Execute(int rootIndex); // 0x0000000189F02714-0x0000000189F03184
		}
	
		// Constructors
		public ClampRotationConstraint(); // 0x0000000184D89110-0x0000000184D89120
	
		// Methods
		public override void Create(); // 0x000000018442E1B0-0x000000018442E350
		public override void Release(); // 0x0000000189F02118-0x0000000189F021E4
		public int AddGroup(int teamId, bool active, BezierParam maxAngle, float velocityInfluence, ClampRotationData[] dataArray, ClampRotationRootInfo[] rootInfoArray); // 0x0000000189F01C70-0x0000000189F01F38
		public override void RemoveTeam(int teamId); // 0x0000000189F021E4-0x0000000189F023C0
		public void ChangeParam(int teamId, bool active, BezierParam maxAngle, float velocityInfluence); // 0x0000000189F01F38-0x0000000189F02118
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000189F023C0-0x0000000189F02704
	}

	public class ColliderCollisionConstraint : PhysicsManagerConstraint // TypeDefIndex: 55064
	{
		// Nested types
		[BurstCompile]
		private struct CollisionJob : IJobParallelFor // TypeDefIndex: 55063
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
			public void Execute(int index); // 0x0000000189F04348-0x0000000189F04808
			private float SphereColliderDetection(ref float3 nextpos, float radius, int cindex, out float3 normal); // 0x0000000189F0492C-0x0000000189F04ADC
			private float CapsuleColliderDetection(ref float3 nextpos, float radius, int cindex, float3 dir, out float3 normal); // 0x0000000189F03E94-0x0000000189F04348
			private float PlaneColliderDetection(ref float3 nextpos, float radius, int cindex, out float3 normal); // 0x0000000189F04808-0x0000000189F0492C
		}
	
		// Constructors
		public ColliderCollisionConstraint(); // 0x0000000184D89110-0x0000000184D89120
	
		// Methods
		public override void Create(); // 0x00000001841E1670-0x00000001841E1680
		public override void RemoveTeam(int teamId); // 0x00000001841E1670-0x00000001841E1680
		public void ChangeParam(int teamId, bool useCollision); // 0x0000000189F03184-0x0000000189F031D4
		public override void Release(); // 0x00000001841E1670-0x00000001841E1680
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000189F031D4-0x0000000189F036AC
	}

	public class ColliderExtrusionConstraint : PhysicsManagerConstraint // TypeDefIndex: 55066
	{
		// Nested types
		[BurstCompile]
		private struct CollisionExtrusionJob : IJobParallelFor // TypeDefIndex: 55065
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
			public void Execute(int index); // 0x0000000189F03A18-0x0000000189F03E94
		}
	
		// Constructors
		public ColliderExtrusionConstraint(); // 0x0000000184D89110-0x0000000184D89120
	
		// Methods
		public override void Create(); // 0x00000001841E1670-0x00000001841E1680
		public override void RemoveTeam(int teamId); // 0x00000001841E1670-0x00000001841E1680
		public override void Release(); // 0x00000001841E1670-0x00000001841E1680
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000189F036AC-0x0000000189F03A18
	}

	public class CompositeRotationConstraint : PhysicsManagerConstraint // TypeDefIndex: 55071
	{
		// Fields
		private FixedChunkNativeArray<RotationData> dataList; // 0x20
		private FixedChunkNativeArray<RootInfo> rootInfoList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
		private FixedChunkNativeArray<int> rootTeamList; // 0x38
		private FixedChunkNativeArray<float> lengthBuffer; // 0x40
	
		// Nested types
		[Serializable]
		public struct RotationData // TypeDefIndex: 55067
		{
			// Fields
			public int vertexIndex; // 0x00
			public int parentVertexIndex; // 0x04
			public float3 localPos; // 0x08
			public quaternion localRot; // 0x14
	
			// Methods
			public bool IsValid(); // 0x0000000189F02704-0x0000000189F02714
		}
	
		[Serializable]
		public struct RootInfo // TypeDefIndex: 55068
		{
			// Fields
			public ushort startIndex; // 0x00
			public ushort dataLength; // 0x02
		}
	
		public struct GroupData // TypeDefIndex: 55069
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
		private struct RotationRootLineJob : IJobParallelFor // TypeDefIndex: 55070
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
			public void Execute(int rootIndex); // 0x0000000189F0BC5C-0x0000000189F0D324
			private float GetRotRatio(float3 tv, float3 gravityVector, float gravity, float minRatio = 0.25f /* Metadata: 0x02346A4A */, float maxRatio = 0.45f /* Metadata: 0x02346A4E */); // 0x0000000189EFEFD4-0x0000000189EFF0A8
		}
	
		// Constructors
		public CompositeRotationConstraint(); // 0x0000000184D89110-0x0000000184D89120
	
		// Methods
		public override void Create(); // 0x000000018442E350-0x000000018442E4F0
		public override void Release(); // 0x0000000189F04F28-0x0000000189F04FF4
		public int AddGroup(int teamId, bool useClamp, BezierParam maxAngle, bool useRestore, BezierParam restorePower, float velocityInfluence, RotationData[] dataArray, RootInfo[] rootInfoArray); // 0x0000000189F04ADC-0x0000000189F04D24
		public override void RemoveTeam(int teamId); // 0x0000000189F04FF4-0x0000000189F05194
		public void ChangeParam(int teamId, bool useClamp, BezierParam maxAngle, bool useRestore, BezierParam restorePower, float velocityInfluence); // 0x0000000189F04D24-0x0000000189F04F28
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000189F05194-0x0000000189F05564
	}

	public class EdgeCollisionConstraint : PhysicsManagerConstraint // TypeDefIndex: 55076
	{
		// Fields
		private FixedChunkNativeArray<EdgeCollisionData> dataList; // 0x20
		private FixedChunkNativeArray<short> groupIndexList; // 0x28
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x30
		private FixedChunkNativeArray<float3> writeBuffer; // 0x38
		private FixedNativeList<GroupData> groupList; // 0x40
	
		// Nested types
		[Serializable]
		public struct EdgeCollisionData // TypeDefIndex: 55072
		{
			// Fields
			public ushort vindex0; // 0x00
			public ushort vindex1; // 0x02
			public int writeIndex0; // 0x04
			public int writeIndex1; // 0x08
	
			// Methods
			public bool IsValid(); // 0x0000000189F07C84-0x0000000189F07C98
		}
	
		public struct GroupData // TypeDefIndex: 55073
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
		private struct EdgeCollisionCalcJob : IJobParallelFor // TypeDefIndex: 55074
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
			public void Execute(int index); // 0x0000000189F063F0-0x0000000189F068C4
			private bool SphereColliderDetection(float3 nextpos0, float3 nextpos1, ref float3 corr0, ref float3 corr1, float radius, int cindex); // 0x0000000189F068C4-0x0000000189F06C0C
			private bool CapsuleColliderDetection(float3 nextpos0, float3 nextpos1, ref float3 corr0, ref float3 corr1, float radius, int cindex, float3 dir); // 0x0000000189F05D5C-0x0000000189F063F0
		}
	
		[BurstCompile]
		private struct EdgeCollisionSumJob : IJobParallelFor // TypeDefIndex: 55075
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
			public void Execute(int pindex); // 0x0000000189F07C98-0x0000000189F07FDC
		}
	
		// Constructors
		public EdgeCollisionConstraint(); // 0x0000000184D89110-0x0000000184D89120
	
		// Methods
		public override void Create(); // 0x0000000189F070D4-0x0000000189F07278
		public override void Release(); // 0x0000000189F07278-0x0000000189F07344
		public int AddGroup(int teamId, bool active, float edgeRadius, EdgeCollisionData[] dataArray, ReferenceDataIndex[] refDataArray, int writeBufferCount); // 0x0000000189F06C0C-0x0000000189F06F40
		public override void RemoveTeam(int teamId); // 0x0000000189F07344-0x0000000189F07590
		public void ChangeParam(int teamId, bool active, float edgeRadius); // 0x0000000189F06F40-0x0000000189F070D4
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000189F07590-0x0000000189F07C84
	}

	public class PenetrationConstraint : PhysicsManagerConstraint // TypeDefIndex: 55080
	{
		// Fields
		private FixedChunkNativeArray<PenetrationData> dataList; // 0x20
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x28
		private FixedChunkNativeArray<float3> bonePenetrationDataList; // 0x30
		public FixedNativeList<GroupData> groupList; // 0x38
	
		// Nested types
		[Serializable]
		public struct PenetrationData // TypeDefIndex: 55077
		{
			// Fields
			public short vertexIndex; // 0x00
			public short colliderIndex; // 0x02
			public float3 localPos; // 0x04
			public float3 localDir; // 0x10
			public float distance; // 0x1C
	
			// Methods
			public bool IsValid(); // 0x0000000189F08C44-0x0000000189F08C50
		}
	
		public struct GroupData // TypeDefIndex: 55078
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
		private struct PenetrationJob : IJobParallelFor // TypeDefIndex: 55079
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
			public void Execute(int index); // 0x0000000189F08C50-0x0000000189F097D0
			private float3 InverseSpherePosition(ref PenetrationData data, float teamScale, float3 scaleDirection, float distance, int cindex, float cr); // 0x0000000189F098F0-0x0000000189F09ACC
			private float3 InverseSpherePenetration(float3 c, float cr, float3 nextpos); // 0x0000000189F097D0-0x0000000189F098F0
		}
	
		// Constructors
		public PenetrationConstraint(); // 0x0000000184D89110-0x0000000184D89120
	
		// Methods
		public override void Create(); // 0x000000018442E4F0-0x000000018442E650
		public override void Release(); // 0x0000000189F084C4-0x0000000189F0856C
		public int AddGroup(int teamId, bool active, ClothParams.PenetrationMode mode, BezierParam distance, BezierParam radius, float maxDepth, PenetrationData[] moveLimitDataList, ReferenceDataIndex[] refDataArray, float3[] bonePenetrationDataArray); // 0x0000000189F07FFC-0x0000000189F082CC
		public override void RemoveTeam(int teamId); // 0x0000000189F0856C-0x0000000189F086F4
		public void ChangeParam(int teamId, bool active, BezierParam distance, BezierParam radius, float maxDepth); // 0x0000000189F082CC-0x0000000189F084C4
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000189F086F4-0x0000000189F08C44
	}

	public class RestoreDistanceConstraint : PhysicsManagerConstraint // TypeDefIndex: 55084
	{
		// Fields
		public const int StructType = 0; // Metadata: 0x02346A52
		public const int BendType = 1; // Metadata: 0x02346A53
		public const int NearType = 2; // Metadata: 0x02346A54
		public const int TypeCount = 3; // Metadata: 0x02346A55
		private FixedChunkNativeArray<RestoreDistanceData>[] dataList; // 0x20
		private FixedChunkNativeArray<ReferenceDataIndex>[] refDataList; // 0x28
		public FixedNativeList<RestoreDistanceGroupData> groupList; // 0x30
	
		// Nested types
		[Serializable]
		public struct RestoreDistanceData // TypeDefIndex: 55081
		{
			// Fields
			public ushort vertexIndex; // 0x00
			public ushort targetVertexIndex; // 0x02
			public float length; // 0x04
	
			// Methods
			public bool IsValid(); // 0x0000000189F00928-0x0000000189F0093C
		}
	
		public struct RestoreDistanceGroupData // TypeDefIndex: 55082
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
			public bool IsValid(int type); // 0x0000000189F0AAE0-0x0000000189F0AAFC
			public CurveParam GetStiffness(int type); // 0x0000000189F0AAB8-0x0000000189F0AAE0
			public ChunkData GetDataChunk(int type); // 0x0000000189F0AA68-0x0000000189F0AA90
			public ChunkData GetRefChunk(int type); // 0x0000000189F0AA90-0x0000000189F0AAB8
		}
	
		[BurstCompile]
		private struct DistanceJob : IJobParallelFor // TypeDefIndex: 55083
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
			public void Execute(int index); // 0x0000000189F05564-0x0000000189F05D5C
		}
	
		// Constructors
		public RestoreDistanceConstraint(); // 0x0000000184D89110-0x0000000184D89120
	
		// Methods
		public override void Create(); // 0x000000018442E870-0x000000018442EA50
		public override void Release(); // 0x0000000189F0A2B8-0x0000000189F0A39C
		public int AddGroup(int teamId, BezierParam mass, float velocityInfluence, BezierParam structStiffness, RestoreDistanceData[] structDataArray, ReferenceDataIndex[] structRefDataArray, bool useBend, BezierParam bendStiffness, RestoreDistanceData[] bendDataArray, ReferenceDataIndex[] bendRefDataArray, bool useNear, BezierParam nearStiffness, RestoreDistanceData[] nearDataArray, ReferenceDataIndex[] nearRefDataArray); // 0x0000000189F09ACC-0x0000000189F0A01C
		public override void RemoveTeam(int teamId); // 0x0000000189F0A39C-0x0000000189F0A5F0
		public void ChangeParam(int teamId, BezierParam mass, float velocityInfluence, BezierParam structStiffness, bool useBend, BezierParam bendStiffness, bool useNear, BezierParam nearStiffness); // 0x0000000189F0A01C-0x0000000189F0A2B8
		public override int GetIterationCount(); // 0x0000000182B2E2D0-0x0000000182B2E2E0
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000189F0A5F0-0x0000000189F0AA68
	}

	public class RestoreRotationConstraint : PhysicsManagerConstraint // TypeDefIndex: 55088
	{
		// Fields
		private FixedChunkNativeArray<RotationData> dataList; // 0x20
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
	
		// Nested types
		[Serializable]
		public struct RotationData // TypeDefIndex: 55085
		{
			// Fields
			public ushort vertexIndex; // 0x00
			public ushort targetVertexIndex; // 0x02
			public float3 localPos; // 0x04
	
			// Methods
			public bool IsValid(); // 0x0000000189F00928-0x0000000189F0093C
		}
	
		public struct GroupData // TypeDefIndex: 55086
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
		private struct RotationJob : IJobParallelFor // TypeDefIndex: 55087
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
			public void Execute(int index); // 0x0000000189F0B524-0x0000000189F0BC5C
		}
	
		// Constructors
		public RestoreRotationConstraint(); // 0x0000000184D89110-0x0000000184D89120
	
		// Methods
		public override void Create(); // 0x000000018442E650-0x000000018442E760
		public override void Release(); // 0x0000000189F0AF58-0x0000000189F0AFE0
		public int AddGroup(int teamId, bool active, BezierParam power, float velocityInfluence, RotationData[] dataArray, ReferenceDataIndex[] refDataArray); // 0x0000000189F0AAFC-0x0000000189F0AD78
		public override void RemoveTeam(int teamId); // 0x0000000189F0AFE0-0x0000000189F0B160
		public void ChangeParam(int teamId, bool active, BezierParam power, float velocityInfluence); // 0x0000000189F0AD78-0x0000000189F0AF58
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000189F0B160-0x0000000189F0B524
	}

	public class SpringConstraint : PhysicsManagerConstraint // TypeDefIndex: 55091
	{
		// Fields
		public FixedNativeList<GroupData> groupList; // 0x20
	
		// Nested types
		public struct GroupData // TypeDefIndex: 55089
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public float spring; // 0x08
		}
	
		[BurstCompile]
		private struct SpringJob : IJobParallelFor // TypeDefIndex: 55090
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
			public void Execute(int index); // 0x0000000189F0D8C8-0x0000000189F0DB30
		}
	
		// Constructors
		public SpringConstraint(); // 0x0000000184D89110-0x0000000184D89120
	
		// Methods
		public override void Create(); // 0x0000000184D2DE20-0x0000000184D2DEA0
		public override void Release(); // 0x0000000189F0D550-0x0000000189F0D598
		public int AddGroup(int teamId, bool active, float spring); // 0x0000000189F0D324-0x0000000189F0D3F0
		public override void RemoveTeam(int teamId); // 0x0000000189F0D598-0x0000000189F0D67C
		public void ChangeParam(int teamId, bool active, float spring); // 0x0000000189F0D3F0-0x0000000189F0D550
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000189F0D67C-0x0000000189F0D8C8
	}

	public class TriangleBendConstraint : PhysicsManagerConstraint // TypeDefIndex: 55096
	{
		// Fields
		private FixedChunkNativeArray<TriangleBendData> dataList; // 0x20
		private FixedChunkNativeArray<short> groupIndexList; // 0x28
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x30
		private FixedChunkNativeArray<float3> writeBuffer; // 0x38
		private FixedNativeList<TriangleBendGroupData> groupList; // 0x40
	
		// Nested types
		[Serializable]
		public struct TriangleBendData // TypeDefIndex: 55092
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
			public bool IsValid(); // 0x0000000189F0F454-0x0000000189F0F464
			public bool IsPositionBend(); // 0x0000000189F0F44C-0x0000000189F0F454
		}
	
		public struct TriangleBendGroupData // TypeDefIndex: 55093
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
		private struct TriangleBendCalcJob : IJobParallelFor // TypeDefIndex: 55094
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
			public void Execute(int index); // 0x0000000189F0DB30-0x0000000189F0E824
		}
	
		[BurstCompile]
		private struct TriangleBendSumJob : IJobParallelFor // TypeDefIndex: 55095
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
			public void Execute(int pindex); // 0x0000000189F0F464-0x0000000189F0F828
		}
	
		// Constructors
		public TriangleBendConstraint(); // 0x0000000184D89110-0x0000000184D89120
	
		// Methods
		public override void Create(); // 0x000000018442EA50-0x000000018442EBF0
		public override void Release(); // 0x0000000189F0ED88-0x0000000189F0EE54
		public int AddGroup(int teamId, bool active, ClothParams.Algorithm algorithm, BezierParam stiffness, TriangleBendData[] dataArray, ReferenceDataIndex[] refDataArray, int writeBufferCount); // 0x0000000189F0E824-0x0000000189F0EB8C
		public override void RemoveTeam(int teamId); // 0x0000000189F0EE54-0x0000000189F0F030
		public void ChangeParam(int teamId, bool active, BezierParam stiffness); // 0x0000000189F0EB8C-0x0000000189F0ED88
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000189F0F030-0x0000000189F0F44C
	}

	public class TwistConstraint : PhysicsManagerConstraint // TypeDefIndex: 55100
	{
		// Fields
		private FixedChunkNativeArray<TwistData> dataList; // 0x20
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
	
		// Nested types
		[Serializable]
		public struct TwistData // TypeDefIndex: 55097
		{
			// Fields
			public ushort vertexIndex0; // 0x00
			public ushort vertexIndex1; // 0x02
	
			// Methods
			public bool IsValid(); // 0x0000000189F00928-0x0000000189F0093C
		}
	
		public struct GroupData // TypeDefIndex: 55098
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public float recoveryPower; // 0x08
			public ChunkData dataChunk; // 0x0C
			public ChunkData refChunk; // 0x1C
		}
	
		[BurstCompile]
		private struct TwistJob2 : IJobParallelFor // TypeDefIndex: 55099
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
			public void Execute(int index); // 0x0000000189F10120-0x0000000189F10814
		}
	
		// Constructors
		public TwistConstraint(); // 0x0000000184D89110-0x0000000184D89120
	
		// Methods
		public override void Create(); // 0x000000018442E760-0x000000018442E870
		public override void Release(); // 0x0000000189F0FB90-0x0000000189F0FC18
		public int AddGroup(int teamId, bool active, float recoveryPower, TwistData[] dataArray, ReferenceDataIndex[] refArray); // 0x0000000189F0F828-0x0000000189F0FA10
		public override void RemoveTeam(int teamId); // 0x0000000189F0FC18-0x0000000189F0FD98
		public void ChangeParam(int teamId, bool active, float recoveryPower); // 0x0000000189F0FA10-0x0000000189F0FB90
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000189F0FD98-0x0000000189F10120
	}

	public class VolumeConstraint : PhysicsManagerConstraint // TypeDefIndex: 55105
	{
		// Fields
		private FixedChunkNativeArray<VolumeData> dataList; // 0x20
		private FixedChunkNativeArray<short> groupIndexList; // 0x28
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x30
		private FixedChunkNativeArray<float3> writeBuffer; // 0x38
		private FixedNativeList<GroupData> groupList; // 0x40
	
		// Nested types
		[Serializable]
		public struct VolumeData // TypeDefIndex: 55101
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
			public bool IsValid(); // 0x0000000189F0F454-0x0000000189F0F464
		}
	
		public struct GroupData // TypeDefIndex: 55102
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
		private struct VolumeCalcJob : IJobParallelFor // TypeDefIndex: 55103
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
			public void Execute(int index); // 0x0000000189F10844-0x0000000189F11690
		}
	
		[BurstCompile]
		private struct VolumeSumJob : IJobParallelFor // TypeDefIndex: 55104
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
			public void Execute(int pindex); // 0x0000000189F20DCC-0x0000000189F21104
		}
	
		// Constructors
		public VolumeConstraint(); // 0x0000000184D89110-0x0000000184D89120
	
		// Methods
		public override void Create(); // 0x0000000189F11C18-0x0000000189F11DBC
		public override void Release(); // 0x0000000189F11DBC-0x0000000189F11E88
		public int AddGroup(int teamId, bool active, BezierParam stretchStiffness, BezierParam shearStiffness, VolumeData[] dataArray, ReferenceDataIndex[] refDataArray, int writeBufferCount); // 0x0000000189F11690-0x0000000189F11A04
		public override void RemoveTeam(int teamId); // 0x0000000189F11E88-0x0000000189F120C4
		public void ChangeParam(int teamId, bool active, BezierParam stretchStiffness, BezierParam shearStiffness); // 0x0000000189F11A04-0x0000000189F11C18
		public override int GetIterationCount(); // 0x0000000182B2E2D0-0x0000000182B2E2E0
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000189F120C4-0x0000000189F1260C
	}

	public struct CurveParam // TypeDefIndex: 55106
	{
		// Fields
		public float sval; // 0x00
		public float eval; // 0x04
		public float cval; // 0x08
		public int useCurve; // 0x0C
	
		// Constructors
		public CurveParam(float value); // 0x0000000184DA3640-0x0000000184DA3650
		public CurveParam(float svalue, float evalue); // 0x0000000184DA3650-0x0000000184DA3660
		public CurveParam(BezierParam bezier); // 0x0000000189F12A90-0x0000000189F12AA4
	
		// Methods
		public void Setup(BezierParam bezier); // 0x0000000189F129F0-0x0000000189F12A90
		public float Evaluate(float t); // 0x0000000189F12988-0x0000000189F129F0
	}

	public abstract class BaseComponent : MonoBehaviour // TypeDefIndex: 55107
	{
		// Constructors
		protected BaseComponent(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public abstract ComponentType GetComponentType();
	}

	public enum ComponentType // TypeDefIndex: 55108
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

	public abstract class PhysicsManagerAccess : IDisposable // TypeDefIndex: 55109
	{
		// Fields
		protected MagicaPhysicsManager manager; // 0x10
	
		// Properties
		public UpdateTimeManager UpdateTime { get; } // 0x000000018861D7BC-0x000000018861D7D8 
		protected PhysicsManagerParticleData Particle { get; } // 0x0000000189ED14C0-0x0000000189ED14E0 
		protected PhysicsManagerBoneData Bone { get; } // 0x0000000183233920-0x0000000183233960 
		protected PhysicsManagerMeshData Mesh { get; } // 0x00000001832353B0-0x0000000183235430 
		protected PhysicsManagerTeamData Team { get; } // 0x0000000183235330-0x00000001832353B0 
		protected PhysicsManagerWindData Wind { get; } // 0x0000000189EE69FC-0x0000000189EE6A1C 
		protected PhysicsManagerComponent Component { get; } // 0x0000000189F13E98-0x0000000189F13EB8 
		protected PhysicsManagerCompute Compute { get; } // 0x0000000189F13EB8-0x0000000189F13ED8 
	
		// Constructors
		protected PhysicsManagerAccess(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void SetParent(MagicaPhysicsManager manager); // 0x00000001853908C0-0x00000001853908D0
		public abstract void Create();
		public abstract void Dispose();
	}

	public class PhysicsManagerBoneData : PhysicsManagerAccess // TypeDefIndex: 55118
	{
		// Fields
		public const byte Flag_Reset = 1; // Metadata: 0x02346A74
		public const byte Flag_Restore = 16; // Metadata: 0x02346A75
		public const byte Flag_Write = 32; // Metadata: 0x02346A76
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
		[CompilerGenerated]
		private bool _hasBoneChanged_k__BackingField; // 0xC0
		[CompilerGenerated]
		private CustomSampler _SamplerReadBoneScale_k__BackingField; // 0xC8
	
		// Properties
		public bool hasBoneChanged { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D91920-0x0000000184D91930 0x0000000184D91990-0x0000000184D919A0
		private CustomSampler SamplerReadBoneScale { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D1D0-0x0000000184D8D1E0 0x0000000186AC5B30-0x0000000186AC5B44
		public int RestoreBoneCount { get; } // 0x0000000189F155E8-0x0000000189F15608 
		public int ReadBoneCount { get; } // 0x0000000189F155C8-0x0000000189F155E8 
		public int WriteBoneCount { get; } // 0x0000000183233870-0x00000001832338A0 
	
		// Nested types
		[BurstCompile]
		private struct RestoreBoneJob : IJobParallelForTransform // TypeDefIndex: 55110
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
			public void Execute(int index, TransformAccess transform); // 0x0000000189F20C10-0x0000000189F20CF8
		}
	
		[BurstCompile]
		private struct ReadBoneJob0 : IJobParallelForTransform // TypeDefIndex: 55111
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
			public void Execute(int index, TransformAccess transform); // 0x0000000189F201C0-0x0000000189F2051C
		}
	
		[BurstCompile]
		private struct ReadBoneJob1 : IJobParallelForTransform // TypeDefIndex: 55112
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
			public void Execute(int index, TransformAccess transform); // 0x0000000189F2051C-0x0000000189F20A30
		}
	
		[BurstCompile]
		private struct ConvertWorldToLocalJob : IJobParallelFor // TypeDefIndex: 55113
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
			public void Execute(int index); // 0x0000000189F126D0-0x0000000189F12988
		}
	
		[BurstCompile]
		private struct WriteBontToTransformJob2 : IJobParallelForTransform // TypeDefIndex: 55114
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
			public void Execute(int index, TransformAccess transform); // 0x0000000189F21104-0x0000000189F21260
		}
	
		[BurstCompile]
		private struct CopyBoneJob0 : IJobParallelFor // TypeDefIndex: 55115
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
			public void Execute(int index); // 0x0000000184DA3550-0x0000000184DA35A0
		}
	
		[BurstCompile]
		private struct CopyBoneJob1 : IJobParallelFor // TypeDefIndex: 55116
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> writeBoneIndexList; // 0x00
			[WriteOnly]
			public NativeArray<int> backWriteBoneIndexList; // 0x10
	
			// Methods
			public void Execute(int index); // 0x0000000184DA35A0-0x0000000184DA35C0
		}
	
		[BurstCompile]
		private struct CopyBoneJob2 : IJobParallelFor // TypeDefIndex: 55117
		{
			// Fields
			[ReadOnly]
			public NativeArray<byte> boneFlagList; // 0x00
			[WriteOnly]
			public NativeArray<byte> backBoneFlagList; // 0x10
	
			// Methods
			public void Execute(int index); // 0x0000000184DA35C0-0x0000000184DA35E0
		}
	
		// Constructors
		public PhysicsManagerBoneData(); // 0x00000001846D7630-0x00000001846D76B0
	
		// Methods
		public override void Create(); // 0x0000000183E876D0-0x0000000183E87C20
		public override void Dispose(); // 0x0000000189F14958-0x0000000189F14BB0
		public int AddRestoreBone(Transform target, float3 lpos, quaternion lrot, int boneIndex); // 0x0000000189F14348-0x0000000189F1443C
		public void RemoveRestoreBone(int restoreBoneIndex); // 0x0000000189F1533C-0x0000000189F153D8
		public int AddBone(Transform target, int pindex = -1 /* Metadata: 0x02346A71 */, bool addParent = false /* Metadata: 0x02346A72 */); // 0x0000000189F13ED8-0x0000000189F14348
		public bool RemoveBone(int boneIndex, int pindex = -1 /* Metadata: 0x02346A73 */); // 0x0000000189F1508C-0x0000000189F1533C
		public void ChangeUnityPhysicsCount(int boneIndex, bool sw); // 0x0000000189F1443C-0x0000000189F144B4
		public void ResetFuturePrediction(int boneIndex); // 0x0000000189F15560-0x0000000189F155C8
		public void ResetBoneFromTransform(bool fixedUpdate); // 0x0000000189F153D8-0x0000000189F15560
		public void ReadBoneFromTransform(); // 0x0000000189F14BB0-0x0000000189F1508C
		public void ConvertWorldToLocal(); // 0x0000000189F144B4-0x0000000189F146A4
		public void WriteBoneToTransform(int bufferIndex); // 0x0000000183233800-0x0000000183233870
		public void CopyBoneBuffer(); // 0x0000000189F146A4-0x0000000189F14958
	}

	public class PhysicsManagerComponent : PhysicsManagerAccess // TypeDefIndex: 55119
	{
		// Fields
		private readonly HashSet<CoreComponent> componentSet; // 0x18
		private HashSet<ParticleComponent> dataUpdateParticleSet; // 0x20
	
		// Properties
		public int ComponentCount { get; } // 0x0000000189F159FC-0x0000000189F15A3C 
	
		// Constructors
		public PhysicsManagerComponent(); // 0x00000001846D7730-0x00000001846D77F0
	
		// Methods
		public override void Create(); // 0x00000001841E1670-0x00000001841E1680
		public override void Dispose(); // 0x00000001841E1670-0x00000001841E1680
		public List<CoreComponent> GetComponentList(); // 0x0000000189F1577C-0x0000000189F157F0
		public void ComponentAction(Action<CoreComponent> act); // 0x0000000189F1562C-0x0000000189F1577C
		public void UpdateComponentStatus(); // 0x0000000189F15898-0x0000000189F159FC
		public void AddComponent(CoreComponent comp); // 0x0000000189F15608-0x0000000189F1562C
		public void RemoveComponent(CoreComponent comp); // 0x0000000189F157F0-0x0000000189F15844
		internal void ReserveDataUpdateParticleComponent(ParticleComponent comp); // 0x0000000189F15844-0x0000000189F15898
		internal void DataUpdateParticleComponent(); // 0x0000000183233710-0x0000000183233800
	}

	public class PhysicsManagerCompute : PhysicsManagerAccess // TypeDefIndex: 55123
	{
		// Fields
		private int solverIteration; // 0x18
		private List<PhysicsManagerConstraint> constraints; // 0x20
		[CompilerGenerated]
		private ClampPositionConstraint _ClampPosition_k__BackingField; // 0x28
		[CompilerGenerated]
		private ClampDistanceConstraint _ClampDistance_k__BackingField; // 0x30
		[CompilerGenerated]
		private ClampRotationConstraint _ClampRotation_k__BackingField; // 0x38
		[CompilerGenerated]
		private SpringConstraint _Spring_k__BackingField; // 0x40
		[CompilerGenerated]
		private RestoreDistanceConstraint _RestoreDistance_k__BackingField; // 0x48
		[CompilerGenerated]
		private RestoreRotationConstraint _RestoreRotation_k__BackingField; // 0x50
		[CompilerGenerated]
		private TriangleBendConstraint _TriangleBend_k__BackingField; // 0x58
		[CompilerGenerated]
		private ColliderCollisionConstraint _Collision_k__BackingField; // 0x60
		[CompilerGenerated]
		private PenetrationConstraint _Penetration_k__BackingField; // 0x68
		[CompilerGenerated]
		private ColliderExtrusionConstraint _ColliderExtrusion_k__BackingField; // 0x70
		[CompilerGenerated]
		private TwistConstraint _Twist_k__BackingField; // 0x78
		[CompilerGenerated]
		private CompositeRotationConstraint _CompositeRotation_k__BackingField; // 0x80
		private List<PhysicsManagerWorker> workers; // 0x88
		[CompilerGenerated]
		private RenderMeshWorker _RenderMeshWorker_k__BackingField; // 0x90
		[CompilerGenerated]
		private VirtualMeshWorker _VirtualMeshWorker_k__BackingField; // 0x98
		[CompilerGenerated]
		private MeshParticleWorker _MeshParticleWorker_k__BackingField; // 0xA0
		[CompilerGenerated]
		private SpringMeshWorker _SpringMeshWorker_k__BackingField; // 0xA8
		[CompilerGenerated]
		private AdjustRotationWorker _AdjustRotationWorker_k__BackingField; // 0xB0
		[CompilerGenerated]
		private LineWorker _LineWorker_k__BackingField; // 0xB8
		[CompilerGenerated]
		private TriangleWorker _TriangleWorker_k__BackingField; // 0xC0
		[CompilerGenerated]
		private BaseSkinningWorker _BaseSkinningWorker_k__BackingField; // 0xC8
		private JobHandle jobHandle; // 0xD0
		private bool runMasterJob; // 0xE0
		private int swapIndex; // 0xE4
		[CompilerGenerated]
		private CustomSampler _SamplerCalcMesh_k__BackingField; // 0xE8
		[CompilerGenerated]
		private CustomSampler _SamplerWriteMesh_k__BackingField; // 0xF0
	
		// Properties
		public ClampPositionConstraint ClampPosition { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public ClampDistanceConstraint ClampDistance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public ClampRotationConstraint ClampRotation { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		public SpringConstraint Spring { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public RestoreDistanceConstraint RestoreDistance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
		public RestoreRotationConstraint RestoreRotation { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		public TriangleBendConstraint TriangleBend { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182E56440-0x0000000182E56460 0x00000001836E5590-0x00000001836E55A0
		public ColliderCollisionConstraint Collision { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86280-0x0000000184D86290 0x00000001863CC164-0x00000001863CC174
		public PenetrationConstraint Penetration { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86230-0x0000000184D86240 0x000000018485F170-0x000000018485F180
		public ColliderExtrusionConstraint ColliderExtrusion { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862B0-0x0000000184D862C0 0x00000001863AD760-0x00000001863AD770
		public TwistConstraint Twist { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862A0-0x0000000184D862B0 0x0000000186402320-0x0000000186402330
		public CompositeRotationConstraint CompositeRotation { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86260-0x0000000184D86270 0x0000000184CD9970-0x0000000184CD9980
		public RenderMeshWorker RenderMeshWorker { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86220-0x0000000184D86230 0x0000000186402330-0x0000000186402344
		public VirtualMeshWorker VirtualMeshWorker { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x0000000186352D0C-0x0000000186352D20
		public MeshParticleWorker MeshParticleWorker { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86210-0x0000000184D86220 0x0000000185391334-0x0000000185391348
		public SpringMeshWorker SpringMeshWorker { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86290-0x0000000184D862A0 0x0000000184D84CC0-0x0000000184D84CE0
		public AdjustRotationWorker AdjustRotationWorker { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86250-0x0000000184D86260 0x0000000184D84CE0-0x0000000184D84D00
		public LineWorker LineWorker { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85EF0-0x0000000184D85F00 0x0000000186AC5AF4-0x0000000186AC5B08
		public TriangleWorker TriangleWorker { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D892F0-0x0000000184D89300 0x0000000186AC5ACC-0x0000000186AC5AE0
		public BaseSkinningWorker BaseSkinningWorker { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8D1D0-0x0000000184D8D1E0 0x0000000186AC5B30-0x0000000186AC5B44
		public CustomSampler SamplerCalcMesh { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D88590-0x0000000184D885A0 0x0000000186AC5B1C-0x0000000186AC5B30
		public CustomSampler SamplerWriteMesh { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8D1A0-0x0000000184D8D1B0 0x0000000186AC5AE0-0x0000000186AC5AF4
		public JobHandle MasterJob { get; set; } // 0x0000000184D9E7C0-0x0000000184D9E7D0 0x0000000184DA12C0-0x0000000184DA12D0
		public int SwapIndex { get; } // 0x0000000184DA3670-0x0000000184DA3680 
	
		// Nested types
		[BurstCompile]
		private struct ForceAndVelocityJob : IJobParallelFor // TypeDefIndex: 55120
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
			public void Execute(int index); // 0x0000000189F132A0-0x0000000189F13CA8
			private float3 Wind(int teamId, [IsReadOnly] in PhysicsManagerTeamData.TeamData teamData, [IsReadOnly] in float3 pos); // 0x0000000189F13CA8-0x0000000189F13E98
		}
	
		[BurstCompile]
		private struct FixPositionJob : IJobParallelFor // TypeDefIndex: 55121
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
			public void Execute(int index); // 0x0000000189F12AA4-0x0000000189F132A0
		}
	
		[BurstCompile]
		private struct PostUpdatePhysicsJob : IJobParallelFor // TypeDefIndex: 55122
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
			public void Execute(int index); // 0x0000000189F1FC24-0x0000000189F201C0
		}
	
		// Constructors
		public PhysicsManagerCompute(); // 0x00000001846D77F0-0x00000001846D78C0
	
		// Methods
		public override void Create(); // 0x0000000183B92860-0x0000000183B93E60
		public override void Dispose(); // 0x0000000189F15A3C-0x0000000189F15C60
		public void RemoveTeam(int teamId); // 0x0000000189F16098-0x0000000189F162C4
		internal void UpdateRestoreBone(PhysicsTeam.TeamUpdateMode updateMode); // 0x0000000189F17034-0x0000000189F17088
		internal void UpdateReadBone(); // 0x0000000183233CB0-0x0000000183233D00
		internal void UpdateTeamAlways(); // 0x0000000183233D00-0x0000000183233D40
		internal void UpdateStartSimulation(UpdateTimeManager update); // 0x0000000183233D40-0x0000000183233E50
		internal void UpdateCompleteSimulation(); // 0x0000000183233C10-0x0000000183233CB0
		internal void UpdateWriteBone(); // 0x00000001832338C0-0x0000000183233920
		internal void MeshCalculation(); // 0x00000001832352A0-0x0000000183235330
		internal void NormalWritingMesh(); // 0x0000000183233BA0-0x0000000183233C10
		internal void UpdateReadWriteBone(); // 0x0000000189F16FB4-0x0000000189F17034
		internal void UpdateSyncBuffer(); // 0x0000000189F17204-0x0000000189F17330
		internal void UpdateSwapBuffer(); // 0x0000000189F17088-0x0000000189F17204
		public void InitJob(); // 0x0000000184DA3660-0x0000000184DA3670
		public void ScheduleJob(); // 0x0000000189F162C4-0x0000000189F162CC
		public void CompleteJob(); // 0x00000001835BC9F0-0x00000001835BCA40
		private void UpdatePhysics(int updateCount, int runCount, float updatePower, float updateDeltaTime); // 0x0000000189F162CC-0x0000000189F16FB4
		private void PostUpdatePhysics(float updateDeltaTime); // 0x0000000189F15C60-0x0000000189F16098
		private void WarmupWorker(); // 0x0000000189F17330-0x0000000189F173A0
	}

	public abstract class PhysicsManagerConstraint // TypeDefIndex: 55124
	{
		// Fields
		[Range(1f, 4f)]
		public int iteration; // 0x10
		[CompilerGenerated]
		private MagicaPhysicsManager _Manager_k__BackingField; // 0x18
	
		// Properties
		public MagicaPhysicsManager Manager { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		protected PhysicsManagerConstraint(); // 0x0000000184D89110-0x0000000184D89120
	
		// Methods
		public void Init(MagicaPhysicsManager manager); // 0x0000000183B93E60-0x0000000183B93E90
		public abstract void Create();
		public abstract void RemoveTeam(int teamId);
		public abstract void Release();
		public virtual int GetIterationCount(); // 0x0000000182B2E2D0-0x0000000182B2E2E0
		public abstract JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle);
	}

	public class PhysicsManagerMeshData : PhysicsManagerAccess // TypeDefIndex: 55133
	{
		// Fields
		public const uint MeshFlag_Active = 1; // Metadata: 0x02346A77
		public const uint MeshFlag_Skinning = 4; // Metadata: 0x02346A78
		public const uint Meshflag_CalcNormal = 8; // Metadata: 0x02346A79
		public const uint Meshflag_CalcTangent = 16; // Metadata: 0x02346A7A
		public const uint Meshflag_Pause = 32; // Metadata: 0x02346A7B
		public const uint MeshFlag_ExistNormals = 65536; // Metadata: 0x02346A7C
		public const uint MeshFlag_ExistTangents = 131072; // Metadata: 0x02346A80
		public const uint MeshFlag_ExistWeights = 262144; // Metadata: 0x02346A84
		public const uint MeshFlag_UpdateUseVertexFront = 16777216; // Metadata: 0x02346A88
		public const uint MeshFlag_UpdateUseVertexBack = 33554432; // Metadata: 0x02346A8C
		public const uint MeshFlag_FasterWrite = 67108864; // Metadata: 0x02346A90
		public const uint MeshFlag_MeshLink = 268435456; // Metadata: 0x02346A94
		public FixedNativeList<SharedVirtualMeshInfo> sharedVirtualMeshInfoList; // 0x18
		public Dictionary<int, int> sharedVirtualMeshIdToIndexDict; // 0x20
		public FixedChunkNativeArray<float2> sharedVirtualUvList; // 0x28
		public FixedChunkNativeArray<uint> sharedVirtualVertexInfoList; // 0x30
		public FixedChunkNativeArray<MeshData.VertexWeight> sharedVirtualWeightList; // 0x38
		public FixedChunkNativeArray<int> sharedVirtualTriangleList; // 0x40
		public FixedChunkNativeArray<uint> sharedVirtualVertexToTriangleInfoList; // 0x48
		public FixedChunkNativeArray<int> sharedVirtualVertexToTriangleIndexList; // 0x50
		public const byte VirtualVertexFlag_Use = 1; // Metadata: 0x02346A98
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
		public const uint RenderVertexFlag_Use = 65536; // Metadata: 0x02346A99
		public const int MaxRenderMeshLinkCount = 4; // Metadata: 0x02346A9D
		public FixedNativeList<RenderMeshInfo> renderMeshInfoList; // 0x110
		public const uint RenderStateFlag_Use = 1; // Metadata: 0x02346A9E
		public const uint RenderStateFlag_ExistNormal = 2; // Metadata: 0x02346A9F
		public const uint RenderStateFlag_ExistTangent = 4; // Metadata: 0x02346AA0
		public const uint RenderStateFlag_FasterWrite = 8; // Metadata: 0x02346AA1
		public const uint RenderStateFlag_DelayedCalculated = 256; // Metadata: 0x02346AA2
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
		public int SharedVirtualMeshCount { get; } // 0x0000000189F1DC8C-0x0000000189F1DCD4 
		public int VirtualMeshCount { get; } // 0x0000000183233AC0-0x0000000183233AF0 
		public int VirtualMeshVertexCount { get; } // 0x0000000189F1DE68-0x0000000189F1DEE4 
		public int VirtualMeshTriangleCount { get; } // 0x0000000189F1DD78-0x0000000189F1DDF4 
		public int VirtualMeshVertexUseCount { get; } // 0x0000000189F1DEE4-0x0000000189F1DF6C 
		public int VirtualMeshUseCount { get; } // 0x0000000189F1DDF4-0x0000000189F1DE68 
		public int VirtualMeshPauseCount { get; } // 0x0000000189F1DCD4-0x0000000189F1DD78 
		public int SharedRenderMeshCount { get; } // 0x0000000189F1DC44-0x0000000189F1DC8C 
		public int SharedChildMeshCount { get; } // 0x0000000189F1DBFC-0x0000000189F1DC44 
		public int RenderMeshCount { get; } // 0x0000000189F1D6F4-0x0000000189F1D73C 
		public int RenderMeshVertexCount { get; } // 0x0000000189F1D9E0-0x0000000189F1DAB8 
		public int RenderMeshUseCount { get; } // 0x0000000189F1D888-0x0000000189F1D9E0 
		public int RenderMeshVertexUseCount { get; } // 0x0000000189F1DAB8-0x0000000189F1DBFC 
		public int RenderMeshPauseCount { get; } // 0x0000000189F1D73C-0x0000000189F1D888 
	
		// Nested types
		public struct SharedVirtualMeshInfo // TypeDefIndex: 55125
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
	
		public struct VirtualMeshInfo // TypeDefIndex: 55126
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
			public bool IsFlag(uint flag); // 0x0000000189F20B04-0x0000000189F20B0C
			public void SetFlag(uint flag, bool sw); // 0x0000000189F20BE4-0x0000000189F20BF8
			public bool IsActive(); // 0x0000000189F20AF0-0x0000000189F20AF8
			public bool IsUse(); // 0x0000000189F20DB4-0x0000000189F20DCC
			public bool IsPause(); // 0x0000000189F20B24-0x0000000189F20B2C
		}
	
		public struct SharedChildMeshInfo // TypeDefIndex: 55127
		{
			// Fields
			public long cuid; // 0x00
			public int sharedVirtualMeshIndex; // 0x08
			public int virtualMeshIndex; // 0x0C
			public int meshUseCount; // 0x10
			public ChunkData vertexChunk; // 0x14
			public ChunkData weightChunk; // 0x24
		}
	
		public struct SharedRenderMeshInfo // TypeDefIndex: 55128
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
			public bool IsFlag(uint flag); // 0x0000000189F20CF8-0x0000000189F20D00
			public void SetFlag(uint flag, bool sw); // 0x0000000189F20D08-0x0000000189F20D20
			public bool IsSkinning(); // 0x0000000189F20D00-0x0000000189F20D08
		}
	
		public struct RenderMeshInfo // TypeDefIndex: 55129
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
			public bool IsFlag(uint flag); // 0x0000000189F20B04-0x0000000189F20B0C
			public void SetFlag(uint flag, bool sw); // 0x0000000189F20BE4-0x0000000189F20BF8
			public bool IsActive(); // 0x0000000189F20AF0-0x0000000189F20AF8
			public bool IsUse(); // 0x0000000189F20B34-0x0000000189F20B44
			public bool IsLinkMesh(int index); // 0x0000000189F20B0C-0x0000000189F20B24
			public bool IsPause(); // 0x0000000189F20B24-0x0000000189F20B2C
			public bool IsFasterWrite(); // 0x0000000189F20AF8-0x0000000189F20B04
			public bool IsSkinning(); // 0x0000000189F20B2C-0x0000000189F20B34
			public bool AddLinkMesh(int renderMeshIndex, int childMeshVertexStart, int childMeshWeightStart, int virtualMeshVertexStart, int sharedVirtualMeshVertexStart); // 0x0000000189F20A30-0x0000000189F20AF0
			public bool RemoveLinkMesh(int renderMeshIndex, int childMeshVertexStart, int childMeshWeightStart, int virtualMeshVertexStart, int sharedVirtualMeshVertexStart); // 0x0000000189F20B44-0x0000000189F20BE4
		}
	
		public class RenderMeshState // TypeDefIndex: 55130
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
			public RenderMeshState(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public bool IsFlag(uint flag); // 0x000000018709EC80-0x000000018709EC88
			public void SetFlag(uint flag, bool sw); // 0x0000000189F20BF8-0x0000000189F20C10
		}
	
		[BurstCompile]
		private struct CopyRenderBuffer : IJobParallelFor // TypeDefIndex: 55131
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
			public void Execute(int index); // 0x0000000184DA35E0-0x0000000184DA3640
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55132
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<RenderMeshDeformer> __9__158_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000189F20D50-0x0000000189F20DB4
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _DispatchWriting_b__158_0(RenderMeshDeformer a, RenderMeshDeformer b); // 0x0000000189F20D20-0x0000000189F20D50
		}
	
		// Constructors
		public PhysicsManagerMeshData(); // 0x00000001846D78C0-0x00000001846D7B30
	
		// Methods
		public override void Create(); // 0x000000018442EE60-0x000000018442F840
		public override void Dispose(); // 0x0000000189F19D4C-0x0000000189F1A210
		public void AddMesh(BaseMeshDeformer bmesh); // 0x0000000189F173A0-0x0000000189F17418
		public void RemoveMesh(BaseMeshDeformer bmesh); // 0x0000000189F1AECC-0x0000000189F1AF50
		public int AddVirtualMesh(int uid, int vertexCount, int weightCount, int boneCount, int triangleCount, int vertexToTriangleIndexCount, Transform transform); // 0x0000000189F18438-0x0000000189F189E0
		public bool IsEmptySharedVirtualMesh(int uid); // 0x0000000189F1A728-0x0000000189F1A780
		public void SetSharedVirtualMeshData(int virtualMeshIndex, uint[] sharedVertexInfoList, MeshData.VertexWeight[] sharedWeightList, Vector2[] sharedUv, int[] sharedTriangles, uint[] vertexToTriangleInfoList, int[] vertexToTriangleIndexList); // 0x0000000189F1CD04-0x0000000189F1CFA4
		public void RemoveVirtualMesh(int virtualMeshIndex); // 0x0000000189F1BCC8-0x0000000189F1C194
		public bool ExistsVirtualMesh(int virtualMeshIndex); // 0x0000000189F1A210-0x0000000189F1A264
		public VirtualMeshInfo GetVirtualMeshInfo(int virtualMeshIndex); // 0x0000000189F1A4D4-0x0000000189F1A55C
		public bool IsUseVirtualMesh(int virtualMeshIndex); // 0x0000000189F1A8DC-0x0000000189F1A96C
		public bool IsActiveVirtualMesh(int virtualMeshIndex); // 0x0000000189F1A618-0x0000000189F1A674
		public void SetVirtualMeshActive(int virtualMeshIndex, bool sw); // 0x0000000189F1CFA4-0x0000000189F1D08C
		public void AddUseVirtualMesh(int virtualMeshIndex); // 0x0000000189F17FF8-0x0000000189F180D4
		public void RemoveUseVirtualMesh(int virtualMeshIndex); // 0x0000000189F1B888-0x0000000189F1B964
		public bool AddUseVirtualVertex(int virtualMeshIndex, int vindex, bool fix); // 0x0000000189F180D4-0x0000000189F18248
		public bool RemoveUseVirtualVertex(int virtualMeshIndex, int vindex, bool fix); // 0x0000000189F1B964-0x0000000189F1BAD8
		public void CopyToVirtualMeshWorldData(int virtualMeshIndex, Vector3[] vertices, Vector3[] normals, Vector3[] tangents); // 0x0000000189F19688-0x0000000189F198E4
		public void AddVirtualMeshBone(int virtualMeshIndex, List<Transform> boneList); // 0x0000000189F18248-0x0000000189F18438
		public void RemoveVirtualMeshBone(int virtualMeshIndex); // 0x0000000189F1BAD8-0x0000000189F1BCC8
		public void ResetFuturePredictionVirtualMeshBone(int virtualMeshIndex); // 0x0000000189F1C194-0x0000000189F1C294
		public void ChangeVirtualMeshUseUnityPhysics(int virtualMeshIndex, bool sw); // 0x0000000189F18B1C-0x0000000189F18C68
		public void SetVirtualMeshFlag(int virtualMeshIndex, uint flag, bool sw); // 0x0000000189F1D08C-0x0000000189F1D180
		public int AddSharedChildMesh(long cuid, int virtualMeshIndex, int vertexCount, int weightCount); // 0x0000000189F17BA8-0x0000000189F17E38
		public bool IsEmptySharedChildMesh(long cuid); // 0x0000000189F1A674-0x0000000189F1A6D0
		public void SetSharedChildMeshData(int sharedMeshIndex, uint[] sharedVertexInfoList, MeshData.VertexWeight[] sharedVertexWeightList); // 0x0000000189F1CBEC-0x0000000189F1CD04
		public void RemoveSharedChildMesh(int sharedChildMeshIndex); // 0x0000000189F1B554-0x0000000189F1B6C8
		public int AddRenderMesh(int uid, bool isSkinning, bool isFasterWrite, Vector3 baseScale, int vertexCount, int rendererBoneIndex, int boneWeightCount); // 0x0000000189F17588-0x0000000189F17BA8
		public void UpdateMeshState(int renderMeshIndex); // 0x0000000189F1D3B0-0x0000000189F1D468
		public void AddRenderMeshBone(int renderMeshIndex, Transform rendererTransform); // 0x0000000189F17418-0x0000000189F17588
		public bool IsEmptySharedRenderMesh(int uid); // 0x0000000189F1A6D0-0x0000000189F1A728
		public void SetRenderSharedMeshData(int renderMeshIndex, bool isSkinning, Vector3[] sharedVertices, Vector3[] sharedNormals, Vector4[] sharedTangents, NativeArray<byte> sharedBonesPerVertex, NativeArray<BoneWeight1> sharedBoneWeights); // 0x0000000189F1C770-0x0000000189F1CBEC
		public void RemoveRenderMesh(int renderMeshIndex); // 0x0000000189F1B0B4-0x0000000189F1B554
		public void RemoveRenderMeshBone(int renderMeshIndex); // 0x0000000189F1AF50-0x0000000189F1B0B4
		public void ChangeRenderMeshUseUnityPhysics(int renderMeshIndex, bool sw); // 0x0000000189F189E0-0x0000000189F18B1C
		public bool IsUseRenderMesh(int renderMeshIndex); // 0x0000000189F1A878-0x0000000189F1A8DC
		public bool IsActiveRenderMesh(int renderMeshIndex); // 0x0000000189F1A55C-0x0000000189F1A618
		public void SetRenderMeshFlag(int renderMeshIndex, uint flag, bool sw); // 0x0000000189F1C5F0-0x0000000189F1C770
		public bool IsRenderMeshFlag(int renderMeshIndex, uint flag); // 0x0000000189F1A780-0x0000000189F1A878
		public void SetRenderMeshActive(int renderMeshIndex, bool sw); // 0x0000000189F1C3FC-0x0000000189F1C5F0
		public void AddUseRenderMesh(int renderMeshIndex); // 0x0000000189F17E38-0x0000000189F17FF8
		public void RemoveUseRenderMesh(int renderMeshIndex); // 0x0000000189F1B6C8-0x0000000189F1B888
		public void LinkRenderMesh(int renderMeshIndex, int childMeshVertexStart, int childMeshWeightStart, int virtualMeshVertexStart, int sharedVirtualMeshVertexStart); // 0x0000000189F1A96C-0x0000000189F1AB70
		public void UnlinkRenderMesh(int renderMeshIndex, int childMeshVertexStart, int childMeshWeightStart, int virtualMeshVertexStart, int sharedVirtualMeshVertexStart); // 0x0000000189F1D180-0x0000000189F1D3B0
		internal void CopyToRenderMeshLocalPositionData(int renderMeshIndex, Mesh mesh, int bufferIndex); // 0x0000000189F18F80-0x0000000189F19070
		internal void CopyToRenderMeshLocalNormalTangentData(int renderMeshIndex, Mesh mesh, int bufferIndex, bool normal, bool tangent); // 0x0000000189F18DEC-0x0000000189F18F80
		internal void CopyToRenderMeshBoneWeightData(int renderMeshIndex, Mesh mesh, Mesh sharedMesh, int bufferIndex); // 0x0000000189F18C68-0x0000000189F18DEC
		internal void CopyToRenderMeshWorldData(int renderMeshIndex, Transform target, Vector3[] vertices, Vector3[] normals, Vector3[] tangents); // 0x0000000189F19070-0x0000000189F193E0
		internal List<int> GetVertexUseList(int renderMeshIndex); // 0x0000000189F1A308-0x0000000189F1A4D4
		internal void SetDelayedCalculatedFlag(); // 0x0000000189F1C294-0x0000000189F1C3FC
		internal void ClearWritingList(); // 0x0000000183233470-0x0000000183233710
		internal void MeshCalculation(int bufferIndex); // 0x0000000189F1AB70-0x0000000189F1AD64
		internal void NormalWriting(int bufferIndex); // 0x0000000189F1AD64-0x0000000189F1AECC
		internal void CopyToRenderVertexBuffer(int renderMeshIndex, int bufferIndex, GraphicsBuffer vertexBuffer, bool normal, ComputeShader compute, int kernel, int index); // 0x0000000189F193E0-0x0000000189F19688
		internal void UpdateVertexBuffer(); // 0x0000000189F1D468-0x0000000189F1D6F4
		internal void FinishVertexBuffer(); // 0x0000000183233A20-0x0000000183233A50
		internal void FasterWriting(int bufferIndex); // 0x0000000189F1A264-0x0000000189F1A308
		private void DispatchWriting(int kernel, List<RenderMeshDeformer> rlist, int bufferIndex); // 0x0000000189F198E4-0x0000000189F19D4C
	}

	public class PhysicsManagerParticleData : PhysicsManagerAccess // TypeDefIndex: 55138
	{
		// Fields
		public const uint Flag_Enable = 1; // Metadata: 0x02346AA4
		public const uint Flag_Kinematic = 2; // Metadata: 0x02346AA5
		public const uint Flag_Hold = 4; // Metadata: 0x02346AA6
		public const uint Flag_Collider = 16; // Metadata: 0x02346AA7
		public const uint Flag_Plane = 32; // Metadata: 0x02346AA8
		public const uint Flag_CapsuleX = 64; // Metadata: 0x02346AA9
		public const uint Flag_CapsuleY = 128; // Metadata: 0x02346AAA
		public const uint Flag_CapsuleZ = 256; // Metadata: 0x02346AAC
		public const uint Flag_Box = 512; // Metadata: 0x02346AAE
		public const uint Flag_TriangleRotation = 1024; // Metadata: 0x02346AB0
		public const uint Flag_Transform_Read_Pos = 4096; // Metadata: 0x02346AB2
		public const uint Flag_Transform_Read_Rot = 8192; // Metadata: 0x02346AB4
		public const uint Flag_Transform_Read_Base = 16384; // Metadata: 0x02346AB6
		public const uint Flag_Transform_Read_Local = 32768; // Metadata: 0x02346ABA
		public const uint Flag_Transform_Read_Scl = 65536; // Metadata: 0x02346ABE
		public const uint Flag_Transform_Write = 131072; // Metadata: 0x02346AC2
		public const uint Flag_Transform_Restore = 262144; // Metadata: 0x02346AC6
		public const uint Flag_Transform_UnityPhysics = 524288; // Metadata: 0x02346ACA
		public const uint Flag_Transform_Parent = 1048576; // Metadata: 0x02346ACE
		public const uint Flag_Step_Update = 16777216; // Metadata: 0x02346AD2
		public const uint Flag_Reset_Position = 33554432; // Metadata: 0x02346AD6
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
		public int Count { get; } // 0x0000000189F1FB70-0x0000000189F1FBA0 
		public int Length { get; } // 0x0000000189F1FBD8-0x0000000189F1FBEC 
		public int ColliderCount { get; } // 0x0000000184D8F940-0x0000000184D8F950 
		public FixedChunkNativeArray<float3> InNextPosList { get; } // 0x0000000189F1FBA0-0x0000000189F1FBBC 
		public FixedChunkNativeArray<float3> OutNextPosList { get; } // 0x0000000189F1FBEC-0x0000000189F1FC08 
		public FixedChunkNativeArray<quaternion> InNextRotList { get; } // 0x0000000189F1FBBC-0x0000000189F1FBD8 
		public FixedChunkNativeArray<quaternion> OutNextRotList { get; } // 0x0000000189F1FC08-0x0000000189F1FC24 
	
		// Nested types
		public struct ParticleFlag // TypeDefIndex: 55134
		{
			// Fields
			public uint flag; // 0x00
	
			// Constructors
			public ParticleFlag(params uint[] flags); // 0x0000000184430530-0x0000000184430570
	
			// Methods
			public bool IsFlag(uint flag); // 0x0000000189F20B04-0x0000000189F20B0C
			public void SetFlag(uint flag, bool sw); // 0x0000000189F20BE4-0x0000000189F20BF8
			public bool IsValid(); // 0x0000000189F2A3F0-0x0000000189F2A3F8
			public void SetEnable(bool sw); // 0x0000000184430680-0x00000001844306A0
			public bool IsFixed(); // 0x0000000189F2A3B4-0x0000000189F2A3BC
			public bool IsMove(); // 0x0000000189F2A3C4-0x0000000189F2A3CC
			public bool IsKinematic(); // 0x0000000189F2A3BC-0x0000000189F2A3C4
			public bool IsHold(); // 0x0000000189F20B2C-0x0000000189F20B34
			public bool IsCollider(); // 0x0000000184430520-0x0000000184430530
			public bool IsReadTransform(); // 0x0000000184430660-0x0000000184430670
			public bool IsWriteTransform(); // 0x0000000189F2A3F8-0x0000000189F2A404
			public bool IsRestoreTransform(); // 0x0000000184430670-0x0000000184430680
			public bool IsUnityPhysics(); // 0x0000000189F2A3E4-0x0000000189F2A3F0
			public bool IsReadSclTransform(); // 0x0000000189F2A3D8-0x0000000189F2A3E4
			public bool IsParentTransform(); // 0x0000000189F2A3CC-0x0000000189F2A3D8
		}
	
		[BurstCompile]
		private struct CopyBoneToParticleJob : IJobParallelFor // TypeDefIndex: 55135
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
			public void Execute(int index); // 0x0000000189F25B74-0x0000000189F26484
		}
	
		[BurstCompile]
		private struct ResetParticleJob : IJobParallelFor // TypeDefIndex: 55136
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
			public void Execute(int index); // 0x0000000189F337CC-0x0000000189F339B0
		}
	
		[BurstCompile]
		private struct CopyParticleToBoneJob : IJobParallelFor // TypeDefIndex: 55137
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
			public void Execute(int index); // 0x0000000189F26484-0x0000000189F267FC
		}
	
		// Constructors
		public PhysicsManagerParticleData(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override void Create(); // 0x000000018442F840-0x000000018442FFA0
		public override void Dispose(); // 0x0000000189F1E87C-0x0000000189F1EB98
		public ChunkData CreateParticle(uint flag, int team, float3 wpos, quaternion wrot, float depth, float3 radius, float3 targetLocalPos); // 0x000000018442FFA0-0x0000000184430520
		public ChunkData CreateParticle(int team, int count, Func<int, uint> funcFlag, Func<int, float3> funcWpos, Func<int, quaternion> funcWrot, Func<int, float> funcDepth, Func<int, float3> funcRadius, Func<int, float3> funcTargetLocalPos); // 0x0000000189F1DF6C-0x0000000189F1E87C
		public void RemoveParticle(ChunkData c); // 0x0000000189F1EC50-0x0000000189F1F004
		public void SetEnable(ChunkData c, bool sw, Func<int, Transform> funcTarget, Func<int, float3> funcLpos, Func<int, quaternion> funcLrot); // 0x0000000184430570-0x0000000184430660
		public void SetRadius(int index, float3 radius); // 0x0000000189F1F158-0x0000000189F1F1C8
		public void SetLocalPos(int index, Vector3 lpos); // 0x0000000189F1F0C4-0x0000000189F1F158
		public bool IsValid(int index); // 0x0000000189F1EBE8-0x0000000189F1EC50
		public int GetTeamId(int index); // 0x0000000189F1EB98-0x0000000189F1EBE8
		public void ResetFuturePredictionTransform(int index); // 0x0000000189F1F054-0x0000000189F1F0C4
		public void ResetFuturePredictionTransform(ChunkData c); // 0x0000000189F1F004-0x0000000189F1F054
		public void SwitchingNextPosList(); // 0x0000000184DA3680-0x0000000184DA36A0
		public void SwitchingNextRotList(); // 0x0000000184DA36A0-0x0000000184DA36C0
		public void UpdateBoneToParticle(); // 0x0000000189F1F1C8-0x0000000189F1F570
		public void UpdateResetParticle(); // 0x0000000189F1F878-0x0000000189F1FB70
		public bool UpdateParticleToBone(); // 0x0000000189F1F570-0x0000000189F1F878
	}

	public class PhysicsManagerTeamData : PhysicsManagerAccess // TypeDefIndex: 55146
	{
		// Fields
		public const uint Flag_Enable = 1; // Metadata: 0x02346ADE
		public const uint Flag_Interpolate = 2; // Metadata: 0x02346ADF
		public const uint Flag_FixedNonRotation = 4; // Metadata: 0x02346AE0
		public const uint Flag_AnimatedPose = 8; // Metadata: 0x02346AE1
		public const uint Flag_IgnoreClampPositionVelocity = 16; // Metadata: 0x02346AE2
		public const uint Flag_Collision = 32; // Metadata: 0x02346AE3
		public const uint Flag_AfterCollision = 64; // Metadata: 0x02346AE4
		public const uint Flag_UpdatePhysics = 128; // Metadata: 0x02346AE5
		public const uint Flag_Pause = 256; // Metadata: 0x02346AE7
		public const uint Flag_Reset_WorldInfluence = 65536; // Metadata: 0x02346AE9
		public const uint Flag_Reset_Position = 131072; // Metadata: 0x02346AED
		public const uint Flag_Reset_Keep = 524288; // Metadata: 0x02346AF1
		public const uint Flag_Wind = 1048576; // Metadata: 0x02346AF5
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
		public int TeamCount { get; } // 0x0000000189F2E5F4-0x0000000189F2E63C 
		public int TeamLength { get; } // 0x0000000189F2E63C-0x0000000189F2E67C 
		public int ActiveTeamCount { get; } // 0x0000000184D868A0-0x0000000184D868B0 
		public int ColliderCount { get; } // 0x0000000189F2E4B0-0x0000000189F2E4FC 
		public int NormalUpdateCount { get; } // 0x0000000184D868B0-0x0000000184D868C0 
		public int PhysicsUpdateCount { get; } // 0x0000000184D863C0-0x0000000184D863D0 
		public int PauseCount { get; } // 0x0000000189F2E4FC-0x0000000189F2E5F4 
	
		// Nested types
		public enum ForceMode // TypeDefIndex: 55139
		{
			None = 0,
			VelocityAdd = 1,
			VelocityChange = 2,
			VelocityAddWithoutMass = 10,
			VelocityChangeWithoutMass = 11
		}
	
		public struct TeamData // TypeDefIndex: 55140
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
			public bool IsActive(); // 0x0000000189F34424-0x0000000189F3442C
			public bool IsRunning(); // 0x0000000189F34460-0x0000000189F3446C
			public bool IsUpdate(int runCount); // 0x0000000189F3446C-0x0000000189F34478
			public bool IsInterpolate(); // 0x0000000189F34434-0x0000000189F3443C
			public bool IsPhysicsUpdate(); // 0x0000000189F34448-0x0000000189F34454
			public bool IsFlag(uint flag); // 0x0000000189F3442C-0x0000000189F34434
			public void SetFlag(uint flag, bool sw); // 0x0000000189F34478-0x0000000189F34490
			public bool IsReset(); // 0x0000000189F34454-0x0000000189F34460
			public bool IsPause(); // 0x0000000189F3443C-0x0000000189F34448
		}
	
		public struct WorldInfluence // TypeDefIndex: 55141
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
	
		public struct WindInfo // TypeDefIndex: 55142
		{
			// Fields
			public int windCount; // 0x00
			public int4 windDataIndexList; // 0x04
			public float3x4 windDirectionList; // 0x14
			public float4 windMainList; // 0x44
		}
	
		[BurstCompile]
		private struct PreProcessTeamDataJob : IJobParallelFor // TypeDefIndex: 55143
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
			public void Execute(int teamId); // 0x0000000189F2FEFC-0x0000000189F30DA0
			private void UpdateTime(ref TeamData tdata, bool reset, float dtime); // 0x0000000189F30DA0-0x0000000189F30E94
			private void Wind(ref TeamData tdata, float3 pos, int teamId); // 0x0000000189F30E94-0x0000000189F31370
		}
	
		[BurstCompile]
		private struct PostProcessTeamDataJob : IJobParallelFor // TypeDefIndex: 55144
		{
			// Fields
			public int fixedUpdateCount; // 0x00
			public NativeArray<TeamData> teamData; // 0x08
			public NativeArray<WorldInfluence> teamWorldInfluenceList; // 0x18
	
			// Methods
			public void Execute(int index); // 0x0000000189F2FBF8-0x0000000189F2FEFC
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55145
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<int> __9__76_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000189F3526C-0x0000000189F352D0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _ResetFuturePredictionCollidere_b__76_0(int pindex); // 0x0000000189F35210-0x0000000189F3526C
		}
	
		// Constructors
		public PhysicsManagerTeamData(); // 0x00000001846D76B0-0x00000001846D7730
	
		// Methods
		public override void Create(); // 0x0000000182FC1070-0x0000000182FC1330
		public override void Dispose(); // 0x0000000189F2B738-0x0000000189F2B8AC
		public int CreateTeam(PhysicsTeam team, uint flag); // 0x0000000182FC1330-0x0000000182FC18F0
		public void RemoveTeam(int teamId); // 0x0000000189F2C534-0x0000000189F2C63C
		public void SetEnable(int teamId, bool sw); // 0x0000000189F2D238-0x0000000189F2D260
		public bool IsValid(int teamId); // 0x0000000189F2BC68-0x0000000189F2BC74
		public bool IsValidData(int teamId); // 0x0000000189F2BC38-0x0000000189F2BC68
		public bool IsActive(int teamId); // 0x0000000189F2BAE0-0x0000000189F2BBA4
		public void SetFlag(int teamId, uint flag, bool sw); // 0x0000000189F2D38C-0x0000000189F2D4CC
		public bool IsFlag(int teamId, uint flag); // 0x0000000189F2BBA4-0x0000000189F2BC38
		public void SetParticleChunk(int teamId, ChunkData chunk); // 0x0000000189F2DAD4-0x0000000189F2DBD8
		public void SetFriction(int teamId, float dynamicFriction, float staticFriction); // 0x0000000189F2D4CC-0x0000000189F2D5CC
		public void SetMass(int teamId, BezierParam mass); // 0x0000000189F2D91C-0x0000000189F2D974
		public void SetGravity(int teamId, BezierParam gravity); // 0x0000000189F2D764-0x0000000189F2D7BC
		public void SetGravityDirection(int teamId, float3 dir); // 0x0000000189F2D5CC-0x0000000189F2D764
		public void SetDrag(int teamId, BezierParam drag); // 0x0000000189F2D1E0-0x0000000189F2D238
		public void SetMaxVelocity(int teamId, BezierParam maxVelocity); // 0x0000000189F2D974-0x0000000189F2D9CC
		public void SetExternalForce(int teamId, float massInfluence, float windInfluence, float windRandomScale, float windSynchronization); // 0x0000000189F2D260-0x0000000189F2D38C
		public void SetDepthInfluence(int teamId, BezierParam depthInfluence); // 0x0000000189F2D188-0x0000000189F2D1E0
		public void SetWorldInfluence(int teamId, float maxSpeed, float maxRotatinSpeed, BezierParam moveInfluence, BezierParam rotInfluence, bool resetTeleport, float teleportDistance, float teleportRotation, float resetStabilizationTime, ClothParams.TeleportMode teleportMode, bool useClampRotation, BezierParam clampRotation); // 0x0000000189F2E10C-0x0000000189F2E2E8
		private float CalcClampRotationLimit(bool useClampRotation, BezierParam clampRotation); // 0x0000000189F2AE20-0x0000000189F2AE7C
		public void SetWorldInfluence(int teamId, float maxSpeed, float maxRotationSpeed, BezierParam moveInfluence, BezierParam rotInfluence); // 0x0000000189F2E2E8-0x0000000189F2E4B0
		public void SetAfterTeleport(int teamId, bool resetTeleport, float teleportDistance, float teleportRotation, ClothParams.TeleportMode teleportMode); // 0x0000000189F2CC08-0x0000000189F2CD9C
		public void SetStabilizationTime(int teamId, float resetStabilizationTime); // 0x0000000189F2DD18-0x0000000189F2DE78
		public void ResetWorldInfluenceTarget(int teamId, Transform target); // 0x0000000189F2CA04-0x0000000189F2CC08
		public void SetClampRotation(int teamId, bool useClampRotation, BezierParam clampRotation); // 0x0000000189F2D000-0x0000000189F2D188
		public void SetSelfCollisionRange(int teamId, float range); // 0x0000000189F2DBD8-0x0000000189F2DD18
		public void SetBoneIndex(int teamId, int boneIndex, Vector3 initScale); // 0x0000000189F2CEA4-0x0000000189F2D000
		internal void AddColliderParticle(int teamId, int particleIndex); // 0x0000000189F2A838-0x0000000189F2AA2C
		internal void RemoveColliderParticle(int teamId, int particleIndex); // 0x0000000189F2C078-0x0000000189F2C240
		internal void RemoveCollider(int teamId, ColliderComponent collider); // 0x0000000189F2C240-0x0000000189F2C30C
		public void ResetFuturePredictionCollidere(int teamId); // 0x0000000189F2C63C-0x0000000189F2C810
		public void AddSkinningBoneIndex(int teamId, List<Transform> boneList); // 0x0000000189F2AA2C-0x0000000189F2AE20
		public void RemoveSkinningBoneIndex(int teamId); // 0x0000000189F2C30C-0x0000000189F2C534
		public void SetTimeScale(int teamId, float timeScale); // 0x0000000189F2DE78-0x0000000189F2DFC0
		public float GetTimeScale(int teamId); // 0x0000000189F2BA24-0x0000000189F2BAE0
		public void SetBlendRatio(int teamId, float blendRatio); // 0x0000000189F2CD9C-0x0000000189F2CEA4
		public float GetBlendRatio(int teamId); // 0x0000000189F2B8AC-0x0000000189F2B968
		public void SetOutPhysicsPoseBlendRatio(int teamId, float blendRatio); // 0x0000000189F2D9CC-0x0000000189F2DAD4
		public float GetOutPhysicsPoseBlendRatio(int teamId); // 0x0000000189F2B968-0x0000000189F2BA24
		public void SetImpactForce(int teamId, float3 force, ForceMode mode); // 0x0000000189F2D7BC-0x0000000189F2D91C
		public void ResetStabilizationTime(int teamId, float resetStabilizationTime = -1f /* Metadata: 0x02346ADA */); // 0x0000000189F2C810-0x0000000189F2CA04
		public void SetUpdateMode(int teamId, PhysicsTeam.TeamUpdateMode updateMode); // 0x0000000189F2DFC0-0x0000000189F2E10C
		public void ChangeUseUnityPhysics(int teamId, bool sw); // 0x0000000189F2B524-0x0000000189F2B738
		private void ChangeParticleUseUnityPhysics(int pindex, bool unityPhysics); // 0x0000000189F2B408-0x0000000189F2B524
		internal void ChangeBoneFlag(int teamId, PhysicsTeam.TeamCullingMode cullingMode, bool isCalculation); // 0x0000000189F2B1F8-0x0000000189F2B408
		internal void EarlyUpdateTeamAlways(); // 0x00000001833362D0-0x00000001833364E0
		internal void PreUpdateTeamAlways(); // 0x00000001833364E0-0x0000000183336A30
		internal int CalcMaxUpdateCount(int ups, float deltaTime, float physicsDeltaTime, float updateDeltaTime); // 0x0000000189F2AE7C-0x0000000189F2B1F8
		internal void PreUpdateTeamData(float deltaTime, float physicsDeltaTime, float updateDeltaTime, int ups, int maxUpdateCount); // 0x0000000189F2BD94-0x0000000189F2C078
		internal void PostUpdateTeamData(); // 0x0000000189F2BC74-0x0000000189F2BD94
	}

	public class PhysicsManagerWindData : PhysicsManagerAccess // TypeDefIndex: 55151
	{
		// Fields
		public const uint Flag_Enable = 1; // Metadata: 0x02346AFE
		public const uint Flag_Addition = 2; // Metadata: 0x02346AFF
		public FixedNativeList<WindData> windDataList; // 0x18
	
		// Properties
		public int Count { get; } // 0x0000000189F2EEB4-0x0000000189F2EF00 
	
		// Nested types
		public enum WindType // TypeDefIndex: 55147
		{
			None = 0,
			Direction = 1,
			Area = 2
		}
	
		public enum ShapeType // TypeDefIndex: 55148
		{
			Box = 0,
			Sphere = 1
		}
	
		public enum DirectionType // TypeDefIndex: 55149
		{
			OneDirection = 0,
			Radial = 1
		}
	
		public struct WindData // TypeDefIndex: 55150
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
			public bool IsFlag(uint flag); // 0x0000000189F20B04-0x0000000189F20B0C
			public void SetFlag(uint flag, bool sw); // 0x0000000189F20BE4-0x0000000189F20BF8
			public void SetEnable(bool sw); // 0x0000000189F35448-0x0000000189F35460
			public bool IsActive(); // 0x0000000189F2A3F0-0x0000000189F2A3F8
		}
	
		// Constructors
		public PhysicsManagerWindData(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override void Create(); // 0x0000000184D2EDA0-0x0000000184D2EE20
		public override void Dispose(); // 0x0000000189F2E9F4-0x0000000189F2EA38
		public int CreateWind(WindType windType, ShapeType shapeType, float3 areaSize, bool addition, float main, float turbulence, float frequency, float3 direction, DirectionType directinType, float areaVolume, float areaLength, BezierParam attenuation); // 0x0000000189F2E8B8-0x0000000189F2E9F4
		public void RemoveWind(int windId); // 0x0000000189F2EA9C-0x0000000189F2EAF4
		public void SetEnable(int windId, bool sw, Transform target); // 0x0000000189F2EAF4-0x0000000189F2EC70
		public bool IsActive(int windId); // 0x0000000189F2EA38-0x0000000189F2EA9C
		public void SetFlag(int windId, uint flag, bool sw); // 0x0000000189F2EC70-0x0000000189F2ED44
		public void SetParameter(int windId, float3 areaSize, bool addition, float main, float turbulence, float frequency, float3 direction, float areaVolume, float areaLength, BezierParam attenuation); // 0x0000000189F2ED44-0x0000000189F2EEB4
		internal static float3 CalcWindForce(float time, float2 noiseBasePos, float3 mainDir, float main, float turbulence, float frequency, float randomScale); // 0x0000000189F2E67C-0x0000000189F2E8B8
	}

	public abstract class PhysicsManagerWorker // TypeDefIndex: 55152
	{
		// Fields
		[CompilerGenerated]
		private MagicaPhysicsManager _Manager_k__BackingField; // 0x10
	
		// Properties
		public MagicaPhysicsManager Manager { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	
		// Constructors
		protected PhysicsManagerWorker(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected virtual void Start(); // 0x00000001841E1670-0x00000001841E1680
		public void Init(MagicaPhysicsManager manager); // 0x0000000183B93E90-0x0000000183B93EC0
		public abstract void Create();
		public abstract void RemoveGroup(int group);
		public abstract void Release();
		public abstract void Warmup();
		public abstract JobHandle PreUpdate(JobHandle jobHandle);
		public abstract JobHandle PostUpdate(JobHandle jobHandle);
	}

	public abstract class ColliderComponent : ParticleComponent // TypeDefIndex: 55153
	{
		// Fields
		[SerializeField]
		protected bool isGlobal; // 0x28
		[SerializeField]
		private Vector3 center; // 0x2C
	
		// Properties
		public Vector3 Center { get; set; } // 0x0000000184D90540-0x0000000184D90560 0x0000000189F25B5C-0x0000000189F25B74
	
		// Constructors
		protected ColliderComponent(); // 0x00000001853982BC-0x00000001853982C4
	
		// Methods
		protected override void OnInit(); // 0x0000000184D84ED0-0x0000000184D84EF0
		protected override void OnDispose(); // 0x0000000189F25834-0x0000000189F25A70
		public override int GetDataHash(); // 0x0000000189F257E8-0x0000000189F25834
		public abstract bool CalcNearPoint(Vector3 pos, out Vector3 p, out Vector3 dir, out Vector3 d, bool skinning);
		public Vector3 CalcLocalPos(Vector3 pos); // 0x0000000189F2564C-0x0000000189F2575C
		public Vector3 CalcLocalDir(Vector3 dir); // 0x0000000189F255E0-0x0000000189F2564C
		public ChunkData CreateColliderParticle(int teamId); // 0x0000000189F2575C-0x0000000189F257E8
		public void RemoveColliderParticle(int teamId); // 0x0000000189F25A70-0x0000000189F25B5C
		protected abstract ChunkData CreateColliderParticleReal(int teamId);
	}

	[AddComponentMenu("MagicaCloth/MagicaCapsuleCollider")]
	[HelpURL("https://magicasoft.jp/magica-cloth-capsule-collider/")]
	public class MagicaCapsuleCollider : ColliderComponent // TypeDefIndex: 55155
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
		public Axis AxisMode { get; set; } // 0x0000000184D863B0-0x0000000184D863C0 0x0000000189F2859C-0x0000000189F285A8
		public float Length { get; set; } // 0x0000000184D863E0-0x0000000184D863F0 0x0000000189F285B4-0x0000000189F285C0
		public float StartRadius { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000189F285C0-0x0000000189F285CC
		public float EndRadius { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000189F285A8-0x0000000189F285B4
	
		// Nested types
		public enum Axis // TypeDefIndex: 55154
		{
			X = 0,
			Y = 1,
			Z = 2
		}
	
		// Constructors
		public MagicaCapsuleCollider(); // 0x0000000184D778B0-0x0000000184D778D0
	
		// Methods
		public override ComponentType GetComponentType(); // 0x0000000184DA36C0-0x0000000184DA36D0
		private void OnValidate(); // 0x0000000189F28570-0x0000000189F2859C
		internal override void DataUpdate(); // 0x0000000189F28040-0x0000000189F28370
		public override int GetDataHash(); // 0x0000000189F28390-0x0000000189F28494
		protected override ChunkData CreateColliderParticleReal(int teamId); // 0x0000000189F27F0C-0x0000000189F28040
		private uint GetCapsuleFlag(); // 0x0000000189F28370-0x0000000189F28390
		public Vector3 GetLocalDir(); // 0x0000000189F28494-0x0000000189F284D8
		public Vector3 GetLocalUp(); // 0x0000000189F284D8-0x0000000189F28514
		public float GetScale(); // 0x0000000189F28514-0x0000000189F28570
		public override bool CalcNearPoint(Vector3 pos, out Vector3 p, out Vector3 dir, out Vector3 d, bool skinning); // 0x0000000189F27790-0x0000000189F27F0C
	}

	[AddComponentMenu("MagicaCloth/MagicaPlaneCollider")]
	[HelpURL("https://magicasoft.jp/magica-cloth-plane-collider/")]
	public class MagicaPlaneCollider : ColliderComponent // TypeDefIndex: 55156
	{
		// Constructors
		public MagicaPlaneCollider(); // 0x00000001853982BC-0x00000001853982C4
	
		// Methods
		public override ComponentType GetComponentType(); // 0x0000000184DA36D0-0x0000000184DA36E0
		private void OnValidate(); // 0x0000000189F28570-0x0000000189F2859C
		internal override void DataUpdate(); // 0x0000000189F288C4-0x0000000189F28A90
		protected override ChunkData CreateColliderParticleReal(int teamId); // 0x0000000189F28798-0x0000000189F288C4
		public override bool CalcNearPoint(Vector3 pos, out Vector3 p, out Vector3 dir, out Vector3 d, bool skinning); // 0x0000000189F285CC-0x0000000189F28798
	}

	[AddComponentMenu("MagicaCloth/MagicaSphereCollider")]
	[HelpURL("https://magicasoft.jp/magica-cloth-sphere-collider/")]
	public class MagicaSphereCollider : ColliderComponent // TypeDefIndex: 55157
	{
		// Fields
		[Range(0.001f, 0.5f)]
		[SerializeField]
		private float radius; // 0x38
	
		// Properties
		public float Radius { get; set; } // 0x0000000184D88360-0x0000000184D88370 0x0000000189F29054-0x0000000189F29060
	
		// Constructors
		public MagicaSphereCollider(); // 0x0000000189F29044-0x0000000189F29054
	
		// Methods
		public override ComponentType GetComponentType(); // 0x0000000184D91C30-0x0000000184D91C40
		private void OnValidate(); // 0x0000000189F28570-0x0000000189F2859C
		internal override void DataUpdate(); // 0x0000000189F28D70-0x0000000189F28FAC
		public override int GetDataHash(); // 0x0000000189F28FAC-0x0000000189F29014
		protected override ChunkData CreateColliderParticleReal(int teamId); // 0x0000000189F28C48-0x0000000189F28D70
		public float GetScale(); // 0x0000000189F29014-0x0000000189F29044
		public override bool CalcNearPoint(Vector3 pos, out Vector3 p, out Vector3 dir, out Vector3 d, bool skinning); // 0x0000000189F28A90-0x0000000189F28C48
	}

	public abstract class ParticleComponent : BaseComponent, IDataHash // TypeDefIndex: 55158
	{
		// Fields
		protected Dictionary<int, ChunkData> particleDict; // 0x18
		protected RuntimeStatus status; // 0x20
	
		// Properties
		public RuntimeStatus Status { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public int CenterParticleIndex { get; } // 0x0000000189F2A33C-0x0000000189F2A3B4 
	
		// Constructors
		protected ParticleComponent(); // 0x00000001849E11B0-0x00000001849E1240
	
		// Methods
		public abstract int GetDataHash();
		protected virtual void Start(); // 0x00000001847FE3A0-0x00000001847FE3B0
		public virtual void OnEnable(); // 0x00000001847FE350-0x00000001847FE380
		public virtual void OnDisable(); // 0x0000000189EE648C-0x0000000189EE64C4
		protected virtual void OnDestroy(); // 0x0000000189F29F90-0x0000000189F29FC0
		private void Init(); // 0x00000001847FE3B0-0x00000001847FE4C0
		protected void OnUpdateStatus(); // 0x0000000184D396C0-0x0000000184D39700
		public virtual bool VerifyData(); // 0x0000000182FFF600-0x0000000182FFF610
		protected virtual void OnInit(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnDispose(); // 0x0000000189F29FC0-0x0000000189F29FF0
		protected virtual void OnUpdate(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnActive(); // 0x000000018539824C-0x0000000185398254
		protected virtual void OnInactive(); // 0x0000000189F29FF0-0x0000000189F29FF8
		protected void EnableParticle(); // 0x0000000184CA5CE0-0x0000000184CA5E40
		protected void DisableParticle(); // 0x0000000189F29C18-0x0000000189F29D20
		protected void EnableTeamParticle(int teamId); // 0x0000000189F29E58-0x0000000189F29F90
		protected void DisableTeamParticle(int teamId); // 0x0000000189F29D20-0x0000000189F29E58
		protected void ReserveDataUpdate(); // 0x0000000189F2A1D8-0x0000000189F2A254
		internal virtual void DataUpdate(); // 0x00000001841E1670-0x00000001841E1680
		internal void UpdateStatus(); // 0x0000000189F2A254-0x0000000189F2A274
		protected ChunkData CreateParticle(uint flag, int teamId, float depth, float3 radius, float3 localPos); // 0x0000000189F299E8-0x0000000189F29C18
		protected void RemoveTeamParticle(int teamId); // 0x0000000189F2A128-0x0000000189F2A1D8
		protected void RemoveParticle(); // 0x0000000189F29FF8-0x0000000189F2A128
		protected Transform UserTransform(int vindex); // 0x00000001853953F4-0x00000001853953FC
		protected float3 UserTransformLocalPosition(int vindex); // 0x0000000189F2A274-0x0000000189F2A2E0
		protected quaternion UserTransformLocalRotation(int vindex); // 0x0000000189F2A2E0-0x0000000189F2A33C
		[CompilerGenerated]
		private object _Init_b__11_0(); // 0x000000018464E630-0x000000018464E640
	}

	public abstract class PhysicsTeam : CoreComponent // TypeDefIndex: 55162
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
		public int TeamId { get; } // 0x0000000184D86560-0x0000000184D86570 
		public PhysicsTeamData TeamData { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		public ChunkData ParticleChunk { get; } // 0x0000000184DA1280-0x0000000184DA1290 
		public Transform InfluenceTarget { get; set; } // 0x0000000184D862B0-0x0000000184D862C0 0x00000001863AD760-0x00000001863AD770
		public float UserBlendWeight { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000189EC1054-0x0000000189EC106C
		public float UserPhysicsBlendWeight { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000189F2FBE0-0x0000000189F2FBF8
		public bool SyncBlendWeightToPoseBlendWeight { get; set; } // 0x0000000184D867D0-0x0000000184D867E0 0x0000000184D86810-0x0000000184D86820
		public float UserCloseThreshold { get; set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000189F2FBC8-0x0000000189F2FBE0
		public TeamUpdateMode UpdateMode { get; protected set; } // 0x0000000184D86550-0x0000000184D86560 0x0000000184D865A0-0x0000000184D865B0
		public TeamCullingMode CullingMode { get; set; } // 0x0000000184D86540-0x0000000184D86550 0x0000000184D86590-0x0000000184D865A0
		public TeamSkinningMode SkinningMode { get; set; } // 0x0000000184D86570-0x0000000184D86580 0x0000000184D865D0-0x0000000184D865E0
		internal bool UseAnimatedPose { get; } // 0x0000000189F2FBC0-0x0000000189F2FBC8 
	
		// Nested types
		public enum TeamUpdateMode // TypeDefIndex: 55159
		{
			Normal = 0,
			UnityPhysics = 1
		}
	
		public enum TeamCullingMode // TypeDefIndex: 55160
		{
			Reset = 0,
			Pause = 10,
			Off = 100
		}
	
		public enum TeamSkinningMode // TypeDefIndex: 55161
		{
			None = 0,
			UserAnimation = 1
		}
	
		// Constructors
		protected PhysicsTeam(); // 0x0000000189F2FB4C-0x0000000189F2FBC0
	
		// Methods
		public override int GetDataHash(); // 0x0000000189F2F85C-0x0000000189F2F87C
		protected override void OnInit(); // 0x0000000189F2FA88-0x0000000189F2FAE4
		protected override void OnDispose(); // 0x0000000189F2F9C0-0x0000000189F2FA30
		protected override void OnUpdate(); // 0x00000001841E1670-0x00000001841E1680
		protected override void OnActive(); // 0x0000000189F2F978-0x0000000189F2F9C0
		protected override void OnInactive(); // 0x0000000189F2FA30-0x0000000189F2FA88
		public bool IsActive(); // 0x0000000189F2F87C-0x0000000189F2F8FC
		public bool IsValid(); // 0x0000000189F2F8FC-0x0000000189F2F978
		public ChunkData CreateParticle(int team, int count, Func<int, uint> funcFlag, Func<int, float3> funcWpos, Func<int, quaternion> funcWrot, Func<int, float> funcDepth, Func<int, float3> funcRadius, Func<int, float3> funcTargetLocalPos); // 0x0000000189F2F65C-0x0000000189F2F73C
		public void RemoveAllParticle(); // 0x0000000189F2FAE4-0x0000000189F2FB44
		public void EnableParticle(Func<int, Transform> funcTarget, Func<int, float3> funcLpos, Func<int, quaternion> funcLrot); // 0x0000000189F2F7D4-0x0000000189F2F85C
		public void DisableParticle(Func<int, Transform> funcTarget, Func<int, float3> funcLpos, Func<int, quaternion> funcLrot); // 0x0000000189F2F73C-0x0000000189F2F7D4
		public override Define.Error VerifyData(); // 0x0000000189F2FB44-0x0000000189F2FB4C
	}

	[Serializable]
	public class PhysicsTeamData : IDataHash // TypeDefIndex: 55163
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
		public int ColliderCount { get; } // 0x0000000189F2F61C-0x0000000189F2F65C 
		public List<ColliderComponent> ColliderList { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public List<ColliderComponent> PenetrationIgnoreColliderList { get; } // 0x000000018385B100-0x000000018385B110 
		public bool MergeAvatarCollider { get; } // 0x0000000184D866B0-0x0000000184D866C0 
	
		// Constructors
		public PhysicsTeamData(); // 0x0000000189F2F564-0x0000000189F2F61C
	
		// Methods
		public int GetDataHash(); // 0x0000000189F2F1D8-0x0000000189F2F214
		public void Init(int teamId); // 0x0000000189F2F214-0x0000000189F2F31C
		public void Dispose(int teamId); // 0x0000000189F2EFA4-0x0000000189F2F1D8
		public void AddCollider(ColliderComponent collider); // 0x0000000189F2EF00-0x0000000189F2EFA4
		public void RemoveCollider(ColliderComponent collider); // 0x0000000189F2F31C-0x0000000189F2F434
		internal void UpdateStatus(); // 0x0000000189F2F434-0x0000000189F2F528
		public void ValidateColliderList(); // 0x0000000189F2F528-0x0000000189F2F564
	}

	public class AdjustRotationWorker : PhysicsManagerWorker // TypeDefIndex: 55167
	{
		// Fields
		private const int AdjustMode_Fixed = 0; // Metadata: 0x02346B12
		private const int AdjustMode_XYMove = 1; // Metadata: 0x02346B13
		private const int AdjustMode_XZMove = 2; // Metadata: 0x02346B14
		private const int AdjustMode_YZMove = 3; // Metadata: 0x02346B15
		private FixedChunkNativeArray<AdjustRotationData> dataList; // 0x18
		public FixedNativeList<GroupData> groupList; // 0x20
		private ExNativeMultiHashMap<int, int> particleMap; // 0x28
	
		// Nested types
		[Serializable]
		public struct AdjustRotationData // TypeDefIndex: 55164
		{
			// Fields
			public int keyIndex; // 0x00
			public int targetIndex; // 0x04
			public float3 localPos; // 0x08
	
			// Methods
			public bool IsValid(); // 0x0000000189F228AC-0x0000000189F228BC
		}
	
		public struct GroupData // TypeDefIndex: 55165
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public int adjustMode; // 0x08
			public float3 axisRotationPower; // 0x0C
			public ChunkData chunk; // 0x18
		}
	
		[BurstCompile]
		private struct AdjustRotationJob : IJobParallelFor // TypeDefIndex: 55166
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
			public void Execute(int index); // 0x0000000189F228BC-0x0000000189F22D08
		}
	
		// Constructors
		public AdjustRotationWorker(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override void Create(); // 0x0000000183E87400-0x0000000183E87510
		public override void Release(); // 0x0000000189F2340C-0x0000000189F23494
		public int AddGroup(int teamId, bool active, int adjustMode, float3 axisRotationPower, AdjustRotationData[] dataArray); // 0x0000000189F22D08-0x0000000189F22F94
		public override void RemoveGroup(int teamId); // 0x0000000189F23494-0x0000000189F2371C
		public void ChangeParam(int teamId, bool active, int adjustMode, float3 axisRotationPower); // 0x0000000189F22F94-0x0000000189F23128
		public override void Warmup(); // 0x00000001841E1670-0x00000001841E1680
		public override JobHandle PreUpdate(JobHandle jobHandle); // 0x0000000184D9A8E0-0x0000000184D9A8F0
		public override JobHandle PostUpdate(JobHandle jobHandle); // 0x0000000189F23128-0x0000000189F2340C
	}

	public class BaseSkinningWorker : PhysicsManagerWorker // TypeDefIndex: 55171
	{
		// Fields
		private FixedChunkNativeArray<BaseSkinningData> dataList; // 0x18
		private FixedChunkNativeArray<float4x4> bindPoseList; // 0x20
		public FixedNativeList<GroupData> groupList; // 0x28
	
		// Nested types
		[Serializable]
		public struct BaseSkinningData // TypeDefIndex: 55168
		{
			// Fields
			public float3 localPos; // 0x00
			public float3 localNor; // 0x0C
			public float3 localTan; // 0x18
			public int4 boneIndices; // 0x24
			public float4 weights; // 0x34
			public short weightCount; // 0x44
	
			// Methods
			public bool IsValid(); // 0x0000000189F2371C-0x0000000189F23728
		}
	
		public struct GroupData // TypeDefIndex: 55169
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public int updateFixed; // 0x08
			public ChunkData dataChunk; // 0x0C
			public ChunkData bindPoseChunk; // 0x1C
		}
	
		[BurstCompile]
		private struct BaseSkinningJob : IJobParallelFor // TypeDefIndex: 55170
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
			public void Execute(int index); // 0x0000000189F23728-0x0000000189F240F4
		}
	
		// Constructors
		public BaseSkinningWorker(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override void Create(); // 0x0000000184B4E220-0x0000000184B4E330
		public override void Release(); // 0x0000000189F24784-0x0000000189F2480C
		public int AddGroup(int teamId, bool active, bool updateFixed, BaseSkinningData[] skinningDataList, float4x4[] skinningBindPoseList); // 0x0000000189F240F4-0x0000000189F242D8
		public override void RemoveGroup(int teamId); // 0x0000000189F2480C-0x0000000189F24994
		public void ChangeParam(int teamId, bool updateFixed); // 0x0000000189F242D8-0x0000000189F24430
		public override void Warmup(); // 0x00000001841E1670-0x00000001841E1680
		public override JobHandle PreUpdate(JobHandle jobHandle); // 0x0000000189F24430-0x0000000189F24784
		public override JobHandle PostUpdate(JobHandle jobHandle); // 0x0000000184D9A8E0-0x0000000184D9A8F0
	}

	public class LineWorker : PhysicsManagerWorker // TypeDefIndex: 55176
	{
		// Fields
		private FixedChunkNativeArray<LineRotationData> dataList; // 0x18
		private FixedChunkNativeArray<LineRotationRootInfo> rootInfoList; // 0x20
		public FixedNativeList<GroupData> groupList; // 0x28
		private FixedChunkNativeArray<int> rootTeamList; // 0x30
	
		// Nested types
		[Serializable]
		public struct LineRotationData // TypeDefIndex: 55172
		{
			// Fields
			public int vertexIndex; // 0x00
			public int childCount; // 0x04
			public int childStartDataIndex; // 0x08
			public float3 localPos; // 0x0C
			public quaternion localRot; // 0x18
		}
	
		[Serializable]
		public struct LineRotationRootInfo // TypeDefIndex: 55173
		{
			// Fields
			public ushort startIndex; // 0x00
			public ushort dataLength; // 0x02
		}
	
		public struct GroupData // TypeDefIndex: 55174
		{
			// Fields
			public int teamId; // 0x00
			public int avarage; // 0x04
			public ChunkData dataChunk; // 0x08
			public ChunkData rootInfoChunk; // 0x18
		}
	
		[BurstCompile]
		private struct LineRotationJob : IJobParallelFor // TypeDefIndex: 55175
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
			public void Execute(int rootIndex); // 0x0000000189F267FC-0x0000000189F26FA0
		}
	
		// Constructors
		public LineWorker(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override void Create(); // 0x000000018442EBF0-0x000000018442ED50
		public override void Release(); // 0x0000000189F27548-0x0000000189F275F0
		public int AddGroup(int teamId, bool avarage, LineRotationData[] dataArray, LineRotationRootInfo[] rootInfoArray); // 0x0000000189F26FA0-0x0000000189F27194
		public override void RemoveGroup(int teamId); // 0x0000000189F275F0-0x0000000189F27790
		public void ChangeParam(int teamId, bool avarage); // 0x0000000189F27194-0x0000000189F272F4
		public override void Warmup(); // 0x00000001841E1670-0x00000001841E1680
		public override JobHandle PreUpdate(JobHandle jobHandle); // 0x0000000184D9A8E0-0x0000000184D9A8F0
		public override JobHandle PostUpdate(JobHandle jobHandle); // 0x0000000189F272F4-0x0000000189F27548
	}

	public class MeshParticleWorker : PhysicsManagerWorker // TypeDefIndex: 55180
	{
		// Fields
		private ExNativeMultiHashMap<int, int> vertexToParticleMap; // 0x18
		private FixedNativeListWithCount<int> vertexToParticleList; // 0x20
		private Dictionary<int, List<CreateData>> groupCreateDict; // 0x28
	
		// Nested types
		private struct CreateData // TypeDefIndex: 55177
		{
			// Fields
			public int vertexIndex; // 0x00
			public int particleIndex; // 0x04
		}
	
		[BurstCompile]
		private struct VertexToParticleJob : IJobParallelFor // TypeDefIndex: 55178
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
			public void Execute(int index); // 0x0000000189F352D0-0x0000000189F35448
		}
	
		[BurstCompile]
		private struct ParticleToVertexJob : IJobParallelFor // TypeDefIndex: 55179
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
			public void Execute(int index); // 0x0000000189F2A404-0x0000000189F2A838
		}
	
		// Constructors
		public MeshParticleWorker(); // 0x0000000183B927E0-0x0000000183B92860
	
		// Methods
		public override void Create(); // 0x0000000183E87510-0x0000000183E875F0
		public override void Release(); // 0x0000000189F297E8-0x0000000189F29850
		public void Add(int group, int vindex, int pindex); // 0x0000000189F29060-0x0000000189F291E8
		public override void RemoveGroup(int group); // 0x0000000189F29850-0x0000000189F299E8
		public override void Warmup(); // 0x00000001841E1670-0x00000001841E1680
		public override JobHandle PreUpdate(JobHandle jobHandle); // 0x0000000189F29560-0x0000000189F297E8
		public override JobHandle PostUpdate(JobHandle jobHandle); // 0x0000000189F291E8-0x0000000189F29560
	}

	public class RenderMeshWorker : PhysicsManagerWorker // TypeDefIndex: 55184
	{
		// Nested types
		[BurstCompile]
		private struct CalcVertexUseFlagJob : IJobParallelFor // TypeDefIndex: 55181
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
			public void Execute(int rmindex); // 0x0000000189F24994-0x0000000189F24F30
		}
	
		[BurstCompile]
		private struct CollectLocalPositionNormalTangentForEachMeshJob : IJobParallelFor // TypeDefIndex: 55182
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
			public void Execute(int rmindex); // 0x0000000189F24F30-0x0000000189F2528C
		}
	
		[BurstCompile]
		private struct CollectLocalPositionNormalTangentForEachVertexJob : IJobParallelFor // TypeDefIndex: 55183
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
			public void Execute(int vindex); // 0x0000000189F2528C-0x0000000189F255E0
		}
	
		// Constructors
		public RenderMeshWorker(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override void Create(); // 0x00000001841E1670-0x00000001841E1680
		public override void Release(); // 0x00000001841E1670-0x00000001841E1680
		public override void RemoveGroup(int group); // 0x00000001841E1670-0x00000001841E1680
		private bool IsPerformMeshProcessForEachParticle(); // 0x0000000189F328E8-0x0000000189F32970
		public override void Warmup(); // 0x0000000189F331C0-0x0000000189F337CC
		public override JobHandle PreUpdate(JobHandle jobHandle); // 0x0000000184D9A8E0-0x0000000184D9A8F0
		public override JobHandle PostUpdate(JobHandle jobHandle); // 0x0000000189F32970-0x0000000189F331C0
		private static void CollectionVertex([IsReadOnly] in PhysicsManagerMeshData.RenderMeshInfo r_minfo, [IsReadOnly] in NativeArray<uint> sharedChildVertexInfoList, [IsReadOnly] in NativeArray<MeshData.VertexWeight> sharedChildVertexWeightList, [IsReadOnly] in NativeArray<float3> virtualPosList, [IsReadOnly] in NativeArray<quaternion> virtualRotList, [IsReadOnly] in float3 tpos, [IsReadOnly] in quaternion trot, [IsReadOnly] in float3 tscl, [IsReadOnly] in quaternion itrot, float scaleRatio, [IsReadOnly] in float3 scaleDirection, bool calcNormal, bool calcTangent, int vindex, int i, uint flag, bool isFasterWrite, ref NativeArray<float3> renderPosList, ref NativeArray<float3> renderNormalList, ref NativeArray<float3> renderPosArray, ref NativeArray<float3> renderNomalArray, ref NativeArray<float4> renderTangentList); // 0x0000000189F31370-0x0000000189F328E8
	}

	public class SpringMeshWorker : PhysicsManagerWorker // TypeDefIndex: 55187
	{
		// Fields
		private ExNativeMultiHashMap<int, SpringData> springMap; // 0x18
		private FixedNativeListWithCount<int> springVertexList; // 0x20
		private Dictionary<int, List<int>> groupIndexDict; // 0x28
	
		// Nested types
		public struct SpringData // TypeDefIndex: 55185
		{
			// Fields
			public int particleIndex; // 0x00
			public float weight; // 0x04
		}
	
		[BurstCompile]
		private struct SpringJob : IJobParallelFor // TypeDefIndex: 55186
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
			public void Execute(int index); // 0x0000000189F339B0-0x0000000189F33D6C
		}
	
		// Constructors
		public SpringMeshWorker(); // 0x0000000183B92760-0x0000000183B927E0
	
		// Methods
		public override void Create(); // 0x0000000183E875F0-0x0000000183E876D0
		public override void Release(); // 0x0000000189F34230-0x0000000189F34298
		public void Add(int group, int vertexIndex, int particleIndex, float weight); // 0x0000000189F33D6C-0x0000000189F33EFC
		public override void RemoveGroup(int group); // 0x0000000189F34298-0x0000000189F34424
		public override void Warmup(); // 0x00000001841E1670-0x00000001841E1680
		public override JobHandle PreUpdate(JobHandle jobHandle); // 0x0000000184D9A8E0-0x0000000184D9A8F0
		public override JobHandle PostUpdate(JobHandle jobHandle); // 0x0000000189F33EFC-0x0000000189F34230
	}

	public class TriangleWorker : PhysicsManagerWorker // TypeDefIndex: 55191
	{
		// Fields
		private FixedChunkNativeArray<TriangleRotationData> triangleDataList; // 0x18
		private FixedChunkNativeArray<int> triangleIndexList; // 0x20
		public FixedNativeList<GroupData> groupList; // 0x28
	
		// Nested types
		[Serializable]
		public struct TriangleRotationData // TypeDefIndex: 55188
		{
			// Fields
			public int targetIndex; // 0x00
			public int triangleCount; // 0x04
			public int triangleStartIndex; // 0x08
			public quaternion localRot; // 0x0C
	
			// Methods
			public bool IsValid(); // 0x0000000189F34490-0x0000000189F34498
		}
	
		public struct GroupData // TypeDefIndex: 55189
		{
			// Fields
			public int teamId; // 0x00
			public ChunkData triangleDataChunk; // 0x04
			public ChunkData triangleIndexChunk; // 0x14
		}
	
		[BurstCompile]
		private struct TriangleRotationJob : IJobParallelFor // TypeDefIndex: 55190
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
			public void Execute(int index); // 0x0000000189F34498-0x0000000189F34B74
		}
	
		// Constructors
		public TriangleWorker(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override void Create(); // 0x000000018442ED50-0x000000018442EE60
		public override void Release(); // 0x0000000189F35018-0x0000000189F350A0
		public int AddGroup(int teamId, TriangleRotationData[] dataArray, int[] indexArray); // 0x0000000189F34B74-0x0000000189F34D98
		public override void RemoveGroup(int teamId); // 0x0000000189F350A0-0x0000000189F35210
		public override void Warmup(); // 0x00000001841E1670-0x00000001841E1680
		public override JobHandle PreUpdate(JobHandle jobHandle); // 0x0000000184D9A8E0-0x0000000184D9A8F0
		public override JobHandle PostUpdate(JobHandle jobHandle); // 0x0000000189F34D98-0x0000000189F35018
	}

	public class VirtualMeshWorker : PhysicsManagerWorker // TypeDefIndex: 55196
	{
		// Nested types
		[BurstCompile]
		private struct ReadMeshPositionJob : IJobParallelFor // TypeDefIndex: 55192
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
			public void Execute(int vindex); // 0x0000000189F474E0-0x0000000189F47E7C
		}
	
		[BurstCompile]
		private struct CalcMeshTriangleNormalTangentJob : IJobParallelFor // TypeDefIndex: 55193
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
			public void Execute(int tindex); // 0x0000000189F364E0-0x0000000189F36ACC
		}
	
		[BurstCompile]
		private struct CalcVertexNormalTangentFromTriangleJob : IJobParallelFor // TypeDefIndex: 55194
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
			public void Execute(int vindex); // 0x0000000189F36ACC-0x0000000189F36DB8
		}
	
		[BurstCompile]
		private struct CalcMeshTriangleNormalTangentForEachMeshJob : IJobParallelFor // TypeDefIndex: 55195
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
			public void Execute(int mindex); // 0x0000000189F35BA4-0x0000000189F364E0
		}
	
		// Constructors
		public VirtualMeshWorker(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public override void Create(); // 0x00000001841E1670-0x00000001841E1680
		public override void Release(); // 0x00000001841E1670-0x00000001841E1680
		public override void RemoveGroup(int group); // 0x00000001841E1670-0x00000001841E1680
		private bool IsPerformMeshProcessForEachParticle(); // 0x0000000189F4A15C-0x0000000189F4A1E4
		public override void Warmup(); // 0x00000001841E1670-0x00000001841E1680
		public override JobHandle PreUpdate(JobHandle jobHandle); // 0x0000000189F4ABB8-0x0000000189F4AFBC
		public override JobHandle PostUpdate(JobHandle jobHandle); // 0x0000000189F4A1E4-0x0000000189F4ABB8
	}

	public class AutoMove : MonoBehaviour // TypeDefIndex: 55197
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
		public AutoMove(); // 0x0000000189F3571C-0x0000000189F3575C
	
		// Methods
		private void Start(); // 0x0000000189F35584-0x0000000189F355C4
		private void Update(); // 0x0000000189F355C4-0x0000000189F3571C
		public void OnMoveButton(); // 0x0000000189F3555C-0x0000000189F35584
	}

	public class AutoRotate : MonoBehaviour // TypeDefIndex: 55198
	{
		// Fields
		[SerializeField]
		private Vector3 rotateAngle; // 0x18
		[Range(0.1f, 5f)]
		[SerializeField]
		private float interval; // 0x24
		private float time; // 0x28
	
		// Constructors
		public AutoRotate(); // 0x0000000189F35818-0x0000000189F35848
	
		// Methods
		private void Start(); // 0x00000001841E1670-0x00000001841E1680
		private void Update(); // 0x0000000189F3575C-0x0000000189F35818
		public void OnMoveButton(); // 0x0000000189F3555C-0x0000000189F35584
	}

	public class BlastWaveController : MonoBehaviour // TypeDefIndex: 55200
	{
		// Fields
		public MagicaAreaWind wind; // 0x18
		public float attenuationStartTime; // 0x20
		public float attenuationTime; // 0x24
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__3 : IEnumerator<object> // TypeDefIndex: 55199
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public BlastWaveController __4__this; // 0x20
			private float _main_5__2; // 0x28
			private float _time_5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__3(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000189F49C0C-0x0000000189F49D9C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189F49D9C-0x0000000189F49DE8
		}
	
		// Constructors
		public BlastWaveController(); // 0x0000000184D848C0-0x0000000184D848F0
	
		// Methods
		[IteratorStateMachine(typeof(_Start_d__3))]
		private IEnumerator Start(); // 0x0000000189F35B48-0x0000000189F35BA4
	}

	public class CameraOrbit : MonoBehaviour // TypeDefIndex: 55202
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
		public enum MoveMode // TypeDefIndex: 55201
		{
			None = 0,
			UpDown = 1,
			Free = 2
		}
	
		// Constructors
		public CameraOrbit(); // 0x0000000189F37490-0x0000000189F374F8
	
		// Methods
		private void Start(); // 0x0000000189F37398-0x0000000189F37490
		private void OnEnable(); // 0x0000000189F37070-0x0000000189F372B0
		private void OnDisable(); // 0x0000000189F36DC0-0x0000000189F37000
		private void LateUpdate(); // 0x0000000189F36DB8-0x0000000189F36DC0
		private void updateCamera(); // 0x0000000189F374F8-0x0000000189F377D4
		private void updatePitchYaw(Vector2 speed); // 0x0000000189F379B0-0x0000000189F37A1C
		private void updateOffset(Vector2 speed); // 0x0000000189F377D4-0x0000000189F379B0
		private void updateZoom(float speed); // 0x0000000189F37A1C-0x0000000189F37A94
		private void OnTouchMove(int fid, Vector2 screenPos, Vector2 screenVelocity, Vector2 cmVelocity); // 0x0000000189F372B0-0x0000000189F3732C
		private void OnDoubleTouchMove(int fid, Vector2 screenPos, Vector2 screenVelocity, Vector2 cmVelocity); // 0x0000000189F37000-0x0000000189F37070
		private void OnTouchPinch(float speedscr, float speedcm); // 0x0000000189F3732C-0x0000000189F37398
	}

	public class CopyObject : MonoBehaviour // TypeDefIndex: 55204
	{
		// Fields
		public int seed; // 0x18
		public int count; // 0x1C
		public float radius; // 0x20
		public GameObject prefab; // 0x28
		public int delayFrame; // 0x30
	
		// Nested types
		[CompilerGenerated]
		private sealed class _CreateObject_d__7 : IEnumerator<object> // TypeDefIndex: 55203
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public CopyObject __4__this; // 0x20
			private int _i_5__2; // 0x28
			private int _j_5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _CreateObject_d__7(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000189F499DC-0x0000000189F49BC0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000189F49BC0-0x0000000189F49C0C
		}
	
		// Constructors
		public CopyObject(); // 0x0000000189F37CB0-0x0000000189F37CD4
	
		// Methods
		private void Awake(); // 0x00000001841E1670-0x00000001841E1680
		private void Start(); // 0x0000000189F37C8C-0x0000000189F37CB0
		[IteratorStateMachine(typeof(_CreateObject_d__7))]
		private IEnumerator CreateObject(); // 0x0000000189F37C30-0x0000000189F37C8C
	}

	public class DressUpControl : MonoBehaviour // TypeDefIndex: 55206
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
		public class AvatarPartsGroup // TypeDefIndex: 55205
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
			public AvatarPartsGroup(); // 0x0000000189F35848-0x0000000189F358C0
		}
	
		// Constructors
		public DressUpControl(); // 0x0000000189F38740-0x0000000189F387C0
	
		// Methods
		private void Start(); // 0x0000000189F38730-0x0000000189F38738
		private void Update(); // 0x00000001841E1670-0x00000001841E1680
		private void OnDestroy(); // 0x0000000189F386F8-0x0000000189F38730
		private void Init(); // 0x0000000189F38504-0x0000000189F386F8
		private void ChangeParts(int id, int dir); // 0x0000000189F382C4-0x0000000189F383C0
		public void Clear(); // 0x0000000189F383C0-0x0000000189F38504
		[CompilerGenerated]
		private void _Init_b__8_0(int id, int dir); // 0x0000000189F38738-0x0000000189F38740
	}

	public class ModelController : MonoBehaviour // TypeDefIndex: 55209
	{
		// Fields
		[SerializeField]
		private List<GameObject> characterList; // 0x18
		[SerializeField]
		private float slowTime; // 0x20
		private bool slow; // 0x24
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 55207
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<Animator> __9__7_0; // 0x08
			public static Action<Animator> __9__8_0; // 0x10
			public static Action<BaseCloth> __9__10_0; // 0x18
	
			// Constructors
			static __c(); // 0x0000000189F49F84-0x0000000189F49FE8
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _OnNextButton_b__7_0(Animator ani); // 0x0000000189F49E8C-0x0000000189F49ED4
			internal void _OnBackButton_b__8_0(Animator ani); // 0x0000000189F49E44-0x0000000189F49E8C
			internal void _OnActiveButton_b__10_0(BaseCloth cloth); // 0x0000000189F49DE8-0x0000000189F49E44
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 55208
		{
			// Fields
			public float timeScale; // 0x10
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _OnSlowButton_b__0(Animator ani); // 0x0000000189F49F3C-0x0000000189F49F60
			internal void _OnSlowButton_b__1(BaseCloth cloth); // 0x0000000189F49F60-0x0000000189F49F84
		}
	
		// Constructors
		public ModelController(); // 0x0000000189F45DFC-0x0000000189F45E84
	
		// Methods
		private void Start(); // 0x00000001841E1670-0x00000001841E1680
		private void Update(); // 0x00000001841E1670-0x00000001841E1680
		private void AnimatorAction(Action<Animator> act); // 0x0000000189F4569C-0x0000000189F45840
		private void ClothAction(Action<BaseCloth> act); // 0x0000000189F45840-0x0000000189F459EC
		public void OnNextButton(); // 0x0000000189F45BE4-0x0000000189F45CE0
		public void OnBackButton(); // 0x0000000189F45AE8-0x0000000189F45BE4
		public void OnSlowButton(); // 0x0000000189F45CE0-0x0000000189F45DFC
		public void OnActiveButton(); // 0x0000000189F459EC-0x0000000189F45AE8
	}

	public static class ObjectUtility // TypeDefIndex: 55210
	{
		// Methods
		public static GameObject[] PlaceRandomCubes(int count, Vector3 center, float radius); // 0x0000000189F47188-0x0000000189F4732C
		public static GameObject[] PlaceRandomCubes(int count); // 0x0000000189F4732C-0x0000000189F47358
		public static GameObject MakeStrippedCube(); // 0x0000000189F470DC-0x0000000189F47188
		public static GameObject[] PlaceRandomGameObject(int count, Vector3 center, float radius, GameObject prefab); // 0x0000000189F47358-0x0000000189F474E0
	}

	public class SimpleInputManager : CreateSingleton<MagicaCloth.SimpleInputManager> // TypeDefIndex: 55211
	{
		// Fields
		private const int MaxFinger = 3; // Metadata: 0x02346B19
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
		public static float ScreenDpi { get; } // 0x0000000189F496E8-0x0000000189F4972C 
		public static float ScreenDpc { get; } // 0x0000000189F496A4-0x0000000189F496E8 
	
		// Constructors
		public SimpleInputManager(); // 0x0000000189F49644-0x0000000189F496A4
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Init(); // 0x0000000184D7CA40-0x0000000184D7CA70
		protected override void InitSingleton(); // 0x0000000189F4838C-0x0000000189F484A0
		private void Update(); // 0x0000000189F49624-0x0000000189F49644
		private void CalcScreenDpi(); // 0x0000000189F48158-0x0000000189F48198
		private void AllResetTouchInfo(); // 0x0000000189F48118-0x0000000189F48158
		public int GetTouchCount(); // 0x0000000189F48384-0x0000000189F4838C
		public bool IsUI(); // 0x0000000189F484A0-0x0000000189F4853C
		private void UpdateMobile(); // 0x0000000189F4853C-0x0000000189F48DC8
		private Vector2 CalcScreenRatioVector(Vector2 vec); // 0x0000000189F48198-0x0000000189F481E8
		private bool CheckFlic(int fid, Vector2 oldpos, Vector2 nowpos, Vector2 downpos, float flicktime); // 0x0000000189F481E8-0x0000000189F48384
		private void UpdateMouse(); // 0x0000000189F48DC8-0x0000000189F49624
	}

	public class SliderStart : MonoBehaviour // TypeDefIndex: 55212
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
		public SliderStart(); // 0x0000000189F49974-0x0000000189F499DC
	
		// Methods
		private void Start(); // 0x0000000189F497F8-0x0000000189F49974
		private void OnChangeValue(float value); // 0x0000000189F4972C-0x0000000189F497F8
	}

	public class UIPartsItem : MonoBehaviour // TypeDefIndex: 55214
	{
		// Fields
		public UnityEngine.UI.Text text; // 0x18
		public UnityEngine.UI.Button prefButton; // 0x20
		public UnityEngine.UI.Button nextButton; // 0x28
		private int id; // 0x30
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 55213
		{
			// Fields
			public Action<int, int> onClick; // 0x10
			public UIPartsItem __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Init_b__0(); // 0x0000000189F49ED4-0x0000000189F49F08
			internal void _Init_b__1(); // 0x0000000189F49F08-0x0000000189F49F3C
		}
	
		// Constructors
		public UIPartsItem(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Start(); // 0x00000001841E1670-0x00000001841E1680
		public void Init(string title, int id, Action<int, int> onClick); // 0x0000000189F49FE8-0x0000000189F4A15C
	}

	public class WindController : MonoBehaviour // TypeDefIndex: 55215
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
		private MagicaDirectionalWind Wind { get; } // 0x0000000189F4B574-0x0000000189F4B5B0 
	
		// Constructors
		public WindController(); // 0x0000000189F4B4AC-0x0000000189F4B574
	
		// Methods
		private void Start(); // 0x00000001841E1670-0x00000001841E1680
		public void OnDirectionY(float value); // 0x0000000189F4B108-0x0000000189F4B114
		public void OnDirectionX(float value); // 0x0000000189F4B0FC-0x0000000189F4B108
		public void OnMain(float value); // 0x0000000189F4B14C-0x0000000189F4B294
		public void OnTurbulence(float value); // 0x0000000189F4B294-0x0000000189F4B2CC
		public void OnFrequency(float value); // 0x0000000189F4B114-0x0000000189F4B14C
		public void OnBlastWave(); // 0x0000000189F4AFBC-0x0000000189F4B0FC
		private void UpdateDirection(); // 0x0000000189F4B2CC-0x0000000189F4B4AC
	}

	[Serializable]
	public class BezierParam : IDataHash // TypeDefIndex: 55216
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
		public float StartValue { get; } // 0x0000000184D85F70-0x0000000184D85F80 
		public float EndValue { get; } // 0x0000000189F35B24-0x0000000189F35B38 
		public float CurveValue { get; } // 0x0000000189F35B0C-0x0000000189F35B24 
		public bool UseCurve { get; } // 0x0000000189F35B38-0x0000000189F35B48 
	
		// Constructors
		public BezierParam(); // 0x00000001841E1670-0x00000001841E1680
		public BezierParam(float val); // 0x0000000184DA3710-0x0000000184DA3730
		public BezierParam(float sval, float eval); // 0x0000000184DA3730-0x0000000184DA3750
		public BezierParam(float sval, float eval, bool useEval, float cval, bool useCval); // 0x0000000184DA36E0-0x0000000184DA3710
	
		// Methods
		public void SetParam(float sval, float eval, bool useEval = true /* Metadata: 0x02346B1A */, float cval = 0f /* Metadata: 0x02346B1B */, bool useCval = false /* Metadata: 0x02346B1F */); // 0x0000000184DA36E0-0x0000000184DA3710
		public float Evaluate(float x); // 0x0000000189F35998-0x0000000189F359F0
		public BezierParam AutoSetup(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x02346B20 */); // 0x0000000189F358C0-0x0000000189F35924
		public int GetDataHash(); // 0x0000000189F359F0-0x0000000189F35B0C
		public BezierParam Clone(); // 0x0000000189F35924-0x0000000189F35998
	}

	public interface IBoneReplace // TypeDefIndex: 55217
	{
		// Methods
		HashSet<Transform> GetUsedBones();
		void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class;
	}

	public interface IDataVerify // TypeDefIndex: 55218
	{
		// Methods
		int GetVersion();
		void CreateVerifyData();
		Define.Error VerifyData();
		string GetInformation();
	}

	public interface IEditorCloth // TypeDefIndex: 55219
	{
		// Methods
		List<int> GetSelectionList();
		List<int> GetUseList();
	}

	public interface IEditorMesh // TypeDefIndex: 55220
	{
		// Methods
		int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList);
		List<int> GetEditorTriangleList();
		List<int> GetEditorLineList();
	}

	public class RuntimeStatus // TypeDefIndex: 55221
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
		[CompilerGenerated]
		private HashSet<RuntimeStatus> _parentStatusSet_k__BackingField; // 0x20
		[CompilerGenerated]
		private HashSet<RuntimeStatus> _childStatusSet_k__BackingField; // 0x28
		internal Action UpdateStatusAction; // 0x30
		internal Action DisconnectedAction; // 0x38
		internal Func<object> OwnerFunc; // 0x40
	
		// Properties
		internal HashSet<RuntimeStatus> parentStatusSet { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		internal HashSet<RuntimeStatus> childStatusSet { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public bool IsActive { get; } // 0x0000000184D39700-0x0000000184D39720 
		public bool IsInitStart { get; } // 0x00000001815EFCE0-0x00000001815EFCF0 
		public bool IsInitComplete { get; } // 0x0000000184D88380-0x0000000184D88390 
		public bool IsInitSuccess { get; } // 0x0000000189F48104-0x0000000189F48118 
		public bool IsInitError { get; } // 0x00000001847FE4C0-0x00000001847FE4D0 
		public bool IsDispose { get; } // 0x0000000184DA2FA0-0x0000000184DA2FB0 
		public bool IsDirty { get; } // 0x0000000184D86340-0x0000000184D86350 
	
		// Constructors
		public RuntimeStatus(); // 0x00000001849E1240-0x00000001849E12D0
	
		// Methods
		public void SetInitStart(); // 0x00000001815EFCD0-0x00000001815EFCE0
		public void SetInitComplete(); // 0x0000000184D8ECC0-0x0000000184D8ECD0
		public void SetInitError(); // 0x0000000184D99700-0x0000000184D99710
		public bool SetEnable(bool sw); // 0x00000001847FE380-0x00000001847FE3A0
		public bool SetUserEnable(bool sw); // 0x0000000189F480B8-0x0000000189F480C8
		public bool SetRuntimeError(bool sw); // 0x0000000189F480A8-0x0000000189F480B8
		public void SetDispose(); // 0x0000000184DA37F0-0x0000000184DA3800
		public void SetDirty(); // 0x0000000184D8EB60-0x0000000184D8EB70
		public void ClearDirty(); // 0x0000000184D91AA0-0x0000000184D91AB0
		public bool UpdateStatus(); // 0x00000001847FE4D0-0x00000001847FE620
		public void AddParentStatus(RuntimeStatus status); // 0x0000000189F47ED0-0x0000000189F47F24
		public void RemoveParentStatus(RuntimeStatus status); // 0x0000000189F48004-0x0000000189F480A8
		public void AddChildStatus(RuntimeStatus status); // 0x0000000189F47E7C-0x0000000189F47ED0
		public void RemoveChildStatus(RuntimeStatus status); // 0x0000000189F47F60-0x0000000189F48004
		public void LinkParentStatus(RuntimeStatus parent); // 0x0000000189F47F24-0x0000000189F47F60
		public void UnlinkParentStatus(RuntimeStatus parent); // 0x0000000189F480C8-0x0000000189F48104
		private bool IsParentStatusActive(); // 0x00000001847FE620-0x00000001847FE700
	}

	public static class DataHashExtensions // TypeDefIndex: 55222
	{
		// Fields
		public const int NullHash = 397610387; // Metadata: 0x02346B24
		public const int NumberHash = 932781045; // Metadata: 0x02346B29
	
		// Methods
		public static ulong GetVectorDataHash(Vector3 v); // 0x0000000189F37F20-0x0000000189F37FC4
	
		// Extension methods
		public static int GetDataHash(this object data); // 0x0000000189F37CD4-0x0000000189F37F08
		public static int GetDataHash(this IDataHash data); // 0x0000000189F37F08-0x0000000189F37F20
		public static int GetDataHash<T>(this T[] data);
		public static int GetDataHash<T>(this List<T> data);
		public static int GetDataCountHash<T>(this T[] data);
		public static int GetDataCountHash<T>(this List<T> data);
	}

	public class GridHash // TypeDefIndex: 55224
	{
		// Fields
		protected Dictionary<uint, List<Point>> gridMap; // 0x10
		protected float gridSize; // 0x18
	
		// Nested types
		public class Point // TypeDefIndex: 55223
		{
			// Fields
			public int id; // 0x10
			public float3 pos; // 0x14
	
			// Constructors
			public Point(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public GridHash(); // 0x0000000184D8D240-0x0000000184D8D250
	
		// Methods
		public virtual void Create(float gridSize = 0.1f /* Metadata: 0x02346B2E */); // 0x0000000189F3AA3C-0x0000000189F3AAC4
		public virtual void AddPoint(float3 pos, int id); // 0x0000000189F3A86C-0x0000000189F3A9F4
		public virtual void Remove(float3 pos, int id); // 0x0000000189F3ABAC-0x0000000189F3ACF4
		public void Clear(); // 0x0000000189F3A9F4-0x0000000189F3AA3C
		public static int3 GetGridPos(float3 pos, float gridSize); // 0x0000000189F3AB28-0x0000000189F3ABAC
		public static uint GetGridHash(int3 pos); // 0x0000000184DA37C0-0x0000000184DA37F0
		public static uint GetGridHash(float3 pos, float gridSize); // 0x0000000189F3AAC4-0x0000000189F3AB28
	}

	public class NearPointSearch : GridHash // TypeDefIndex: 55225
	{
		// Fields
		private float radius; // 0x20
		private Dictionary<int, int> nearDict; // 0x28
		private Dictionary<int, float> distDict; // 0x30
		private HashSet<uint> lockPairSet; // 0x38
	
		// Constructors
		public NearPointSearch(); // 0x0000000189F46FC8-0x0000000189F470DC
	
		// Methods
		public void Create(float3[] positionList, float radius); // 0x0000000189F45F1C-0x0000000189F45FA8
		public void SearchNearPointAll(); // 0x0000000189F462D8-0x0000000189F46558
		public void SearchNearPoint(int id, float3 pos); // 0x0000000189F46558-0x0000000189F46A24
		public void SearchNearPoint(float3 pos, float r); // 0x0000000189F46A24-0x0000000189F46D80
		public override void AddPoint(float3 pos, int id); // 0x0000000189F45EF4-0x0000000189F45F1C
		public override void Remove(float3 pos, int id); // 0x0000000189F46208-0x0000000189F462D8
		public void AddLockPair(int id1, int id2); // 0x0000000189F45E84-0x0000000189F45EF4
		public bool GetNearPointPair(out int id1, out int id2); // 0x0000000189F45FA8-0x0000000189F46208
		public override string ToString(); // 0x0000000189F46D80-0x0000000189F46FC8
	}

	public struct ChunkData // TypeDefIndex: 55226
	{
		// Fields
		public int chunkNo; // 0x00
		public int startIndex; // 0x04
		public int dataLength; // 0x08
		public int useLength; // 0x0C
	
		// Methods
		public void Clear(); // 0x0000000184DA3750-0x0000000184DA3760
		public bool IsValid(); // 0x000000018423A5F0-0x000000018423A600
		public override string ToString(); // 0x0000000189F37A94-0x0000000189F37C30
	}

	public class DoubleComputeBuffer<T> : IDisposable // TypeDefIndex: 55227
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
		public int Count { get; }
	
		// Constructors
		public DoubleComputeBuffer();
	
		// Methods
		public void Dispose();
		public void Swap();
		public void Create(int size, ComputeBufferType type, ComputeBufferMode usage);
		public void BeginWrite(int length);
		public void EndWrite(int length);
		public NativeArray<T> GetNativeArray();
		public ComputeBuffer GetBuffer(int bufferIndex = 0 /* Metadata: 0x02346B32 */);
	}

	public class ExNativeHashMap<TKey, TValue> // TypeDefIndex: 55228
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Fields
		private NativeParallelHashMap<TKey, TValue> nativeHashMap;
		private int nativeLength;
		private HashSet<TKey> useKeySet;
	
		// Properties
		private int NativeCount { get; }
		public int Count { get; }
		public NativeParallelHashMap<TKey, TValue> Map { get; }
		public HashSet<TKey> UseKeySet { get; }
	
		// Constructors
		public ExNativeHashMap();
	
		// Methods
		public void Dispose();
		public void Add(TKey key, TValue value);
		public TValue Get(TKey key);
		public void Remove(Func<TKey, TValue, bool> func);
		public void Replace(Func<TKey, TValue, bool> func, Func<TValue, TValue> datafunc);
		public void Remove(TKey key);
		public void Clear();
	}

	public class ExNativeMultiHashMap<TKey, TValue> // TypeDefIndex: 55229
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Fields
		private NativeParallelMultiHashMap<TKey, TValue> nativeMultiHashMap;
		private int nativeLength;
		private Dictionary<TKey, int> useKeyDict;
	
		// Properties
		private int NativeCount { get; }
		public bool IsCreated { get; }
		public int Count { get; }
		public NativeParallelMultiHashMap<TKey, TValue> Map { get; }
	
		// Constructors
		public ExNativeMultiHashMap();
	
		// Methods
		public void Dispose();
		public void Add(TKey key, TValue value);
		public void Remove(TKey key, TValue value);
		public void Remove(Func<TKey, TValue, bool> func);
		public void Replace(Func<TKey, TValue, bool> func, Func<TValue, TValue> datafunc);
		public void Process(Action<TKey, TValue> act);
		public void Process(TKey key, Action<TValue> act);
		public bool Contains(TKey key, TValue value);
		public bool Contains(TKey key);
		public void Remove(TKey key);
		public void Clear();
	}

	public class FixedChunkNativeArray<T> : IDisposable // TypeDefIndex: 55230
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
		public int Length { get; }
		public int ChunkCount { get; }
		public int Count { get; }
		public T this[int index] { get => default; set {} }
	
		// Constructors
		public FixedChunkNativeArray();
	
		// Methods
		public void Dispose();
		public void SetEmptyElement(T empty);
		public ChunkData AddChunk(int length);
		public ChunkData Add(T data);
		public void RemoveChunk(int chunkNo);
		public void RemoveChunk(ChunkData chunk);
		public void Fill(ChunkData chunk, T data);
		public NativeArray<T> ToJobArray();
		public NativeArray<T> ToJobArray(int bufferIndex);
		public void SwapBuffer();
		public override string ToString();
	}

	public class FixedMultiNativeList<T> : IDisposable // TypeDefIndex: 55231
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
		public int Length { get; }
		public int ChunkCount { get; }
		public int Count { get; }
		public T this[int index] { get => default; }
	
		// Constructors
		public FixedMultiNativeList();
	
		// Methods
		public void Dispose();
		public void SetEmptyElement(T empty);
		public ChunkData AddChunk(int length);
		public void RemoveChunk(int chunkNo);
		public void RemoveChunk(ChunkData chunk);
		public ChunkData AddData(ChunkData chunk, T data);
		public ChunkData RemoveData(ChunkData chunk, T data);
		public ChunkData ClearData(ChunkData chunk);
		public void Process(ChunkData chunk, Action<T> act);
		public NativeArray<T> ToJobArray();
		public override string ToString();
	}

	public class FixedNativeList<T> : IDisposable // TypeDefIndex: 55232
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
		public int Length { get; }
		public int Count { get; }
		public T this[int index] { get => default; set {} }
	
		// Constructors
		public FixedNativeList();
	
		// Methods
		public void Dispose();
		public int Add(T element);
		public void Remove(int index);
		public bool Exists(int index);
		public void Clear();
		public NativeArray<T> ToJobArray();
		public NativeArray<T> ToJobArray(int bufferIndex);
		public void SyncBuffer();
	}

	public class FixedNativeListWithCount<T> : IDisposable // TypeDefIndex: 55233
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
		public int Length { get; }
		public int Count { get; }
		public T this[int index] { get => default; set {} }
	
		// Constructors
		public FixedNativeListWithCount();
		public FixedNativeListWithCount(int capacity);
	
		// Methods
		public void Dispose();
		public void SetEmptyElement(T empty);
		public int Add(T element);
		public void Remove(T element);
		public bool Exist(T element);
		public int GetUseCount(T element);
		public void Clear();
		public T[] ToArray();
		public NativeArray<T> ToJobArray();
	}

	public class FixedTransformAccessArray : IDisposable // TypeDefIndex: 55234
	{
		// Fields
		private TransformAccessArray transformArray; // 0x10
		private int nativeLength; // 0x18
		private Queue<int> emptyStack; // 0x20
		private Dictionary<int, int> useIndexDict; // 0x28
		private Dictionary<int, int> indexDict; // 0x30
		private Dictionary<int, int> referenceDict; // 0x38
	
		// Properties
		public int Count { get; } // 0x00000001832338A0-0x00000001832338C0 
		public int Length { get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
		public Transform this[int index] { get => default; } // 0x0000000189F38F88-0x0000000189F38F94 
	
		// Constructors
		public FixedTransformAccessArray(int desiredJobCount = -1 /* Metadata: 0x02346B33 */); // 0x0000000183E87C20-0x0000000183E87D80
		public FixedTransformAccessArray(int capacity, int desiredJobCount); // 0x0000000189F38E14-0x0000000189F38F88
	
		// Methods
		public int Add(Transform element); // 0x0000000189F387C0-0x0000000189F38940
		public void Remove(int index); // 0x0000000189F38CEC-0x0000000189F38E14
		public bool Exist(int index); // 0x0000000189F38C40-0x0000000189F38C64
		public bool Exist(Transform element); // 0x0000000189F38BD4-0x0000000189F38C40
		public int GetIndex(Transform element); // 0x0000000189F38C64-0x0000000189F38CEC
		public void Clear(); // 0x0000000189F38940-0x0000000189F38B2C
		public void Dispose(); // 0x0000000189F38B2C-0x0000000189F38BD4
		public TransformAccessArray GetTransformAccessArray(); // 0x0000000182B2ECC0-0x0000000182B2ECD0
	}

	public static class NativeArrayExtension // TypeDefIndex: 55235
	{
		// Extension methods
		public static void CopyToFast<T, T2>(this NativeArray<T> nativeArray, int startIndex, T2[] array)
			where T : struct
			where T2 : struct;
		public static void CopyToFast<T>(this NativeArray<T> nativeArray, int startIndex, NativeArray<T> array)
			where T : struct;
		public static void CopyBlock<T>(this NativeArray<T> nativeArray, int sourceIndex, int destinationIndex, int count)
			where T : struct;
		public static void CopyFromFast<T>(this NativeArray<T> nativeArray, NativeArray<T> array)
			where T : struct;
		public static void CopyFromFast<T, T2>(this NativeArray<T> nativeArray, int startIndex, T2[] array)
			where T : struct
			where T2 : struct;
		public static void SetValue<T>(this NativeArray<T> nativeArray, int startIndex, int count, T value)
			where T : struct;
	}

	public abstract class CreateSingleton<T> : MonoBehaviour // TypeDefIndex: 55236
		where T : MonoBehaviour
	{
		// Fields
		private static T instance;
		private static T initInstance;
		private static bool isDestroy;
	
		// Properties
		public static T Instance { get; }
	
		// Constructors
		protected CreateSingleton();
	
		// Methods
		protected static void InitMember();
		private static void InitInstance();
		public static bool IsInstance();
		protected virtual void Awake();
		protected virtual void OnDestroy();
		protected virtual void DuplicateDetection(T duplicate);
		protected abstract void InitSingleton();
	}

	public static class DataUtility // TypeDefIndex: 55237
	{
		// Methods
		public static uint PackPair(int v0, int v1); // 0x000000018677F488-0x000000018677F4A0
		public static void UnpackPair(uint pack, out int v0, out int v1); // 0x0000000184DA3080-0x0000000184DA3090
		public static uint Pack16(int hi, int low); // 0x0000000184D874D0-0x0000000184D874E0
		public static int Unpack16Hi(uint pack); // 0x0000000184D875B0-0x0000000184D875C0
		public static int Unpack16Low(uint pack); // 0x0000000184D875C0-0x0000000184D875D0
		public static uint Pack4_28(int hi, int low); // 0x0000000184DA3760-0x0000000184DA3770
		public static int Unpack4_28Hi(uint pack); // 0x0000000184DA3780-0x0000000184DA3790
		public static int Unpack4_28Low(uint pack); // 0x0000000184DA3790-0x0000000184DA37A0
		public static uint Pack8_24(int hi, int low); // 0x0000000184DA3770-0x0000000184DA3780
		public static int Unpack8_24Hi(uint pack); // 0x0000000184DA37A0-0x0000000184DA37B0
		public static int Unpack8_24Low(uint pack); // 0x0000000184DA37B0-0x0000000184DA37C0
		public static ulong Pack32(int hi, int low); // 0x0000000184D91CF0-0x0000000184D91D00
		public static int Unpack32Hi(ulong pack); // 0x0000000184D9D8A0-0x0000000184D9D8B0
		public static int Unpack32Low(ulong pack); // 0x0000000184D88BE0-0x0000000184D88BF0
		public static ulong PackTriple(int v0, int v1, int v2); // 0x0000000189F3813C-0x0000000189F38278
		public static void UnpackTriple(ulong pack, out int v0, out int v1, out int v2); // 0x0000000184DA30C0-0x0000000184DA30E0
		public static ulong PackQuater(int v0, int v1, int v2, int v3); // 0x0000000189F37FC4-0x0000000189F3813C
		public static void UnpackQuater(ulong pack, out int v0, out int v1, out int v2, out int v3); // 0x0000000184DA3090-0x0000000184DA30C0
	}

	public static class Develop // TypeDefIndex: 55238
	{
		// Methods
		[Conditional("MAGICACLOTH_DEBUG")]
		public static void Log(string str); // 0x0000000189F38278-0x0000000189F382C4
	}

	public static class GizmoUtility // TypeDefIndex: 55239
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
		static GizmoUtility(); // 0x0000000189F3A608-0x0000000189F3A86C
	
		// Methods
		public static void DrawWireCapsule(Vector3 pos, Quaternion rot, Vector3 scl, Vector3 ldir, Vector3 lup, float length, float startRadius, float endRadius, bool resetMatrix = true /* Metadata: 0x02346B34 */); // 0x0000000189F399C4-0x0000000189F39E38
		public static void DrawWireSphere(Vector3 pos, Quaternion rot, Vector3 scl, float radius, bool drawSphere, bool drawAxis, bool resetMatrix = true /* Metadata: 0x02346B35 */); // 0x0000000189F3A36C-0x0000000189F3A608
		public static void DrawWireCube(Vector3 pos, Quaternion rot, Vector3 size, bool resetMatrix = true /* Metadata: 0x02346B36 */); // 0x0000000189F3A24C-0x0000000189F3A36C
		public static void DrawWireCone(Vector3 pos, Quaternion rot, float length, float radius, int div = 8 /* Metadata: 0x02346B37 */); // 0x0000000189F39E38-0x0000000189F3A24C
		public static void DrawWireArrow(Vector3 pos, Quaternion rot, Vector3 size, bool cross = false /* Metadata: 0x02346B38 */); // 0x0000000189F39640-0x0000000189F399C4
		public static void DrawAxis(Vector3 pos, Quaternion rot, float size, bool resetMatrix = true /* Metadata: 0x02346B39 */); // 0x0000000189F38F94-0x0000000189F391F0
		public static void DrawBone(Vector3 pos, Vector3 tpos, float size); // 0x0000000189F391F0-0x0000000189F39640
	}

	public static class MathUtility // TypeDefIndex: 55240
	{
		// Methods
		public static float Clamp1(float a); // 0x00000001866AD86C-0x00000001866AD884
		public static float Clamp01(float a); // 0x0000000189F3AE20-0x0000000189F3AE30
		public static float3 Project(float3 v, float3 n); // 0x0000000189EFEF5C-0x0000000189EFEFD4
		public static float Angle(float3 v1, float3 v2); // 0x00000001866A85BC-0x00000001866A868C
		public static float3 ClampVector(float3 v, float minlength, float maxlength); // 0x0000000189EFEB30-0x0000000189EFEC04
		public static float3 ClampVector(float3 v, float maxlength); // 0x0000000189F3B148-0x0000000189F3B1F4
		public static float3 ClampDistance(float3 from, float3 to, float maxlength); // 0x0000000189F1260C-0x0000000189F126D0
		public static bool ClampAngle(float3 dir, float3 basedir, float maxAngle, out float3 outdir); // 0x0000000189F3AE30-0x0000000189F3B0B0
		public static quaternion FromToRotation(float3 from, float3 to, float t = 1f /* Metadata: 0x02346B3A */); // 0x0000000189F3BF44-0x0000000189F3C184
		public static quaternion FromToRotation(quaternion from, quaternion to); // 0x00000001866AEEC4-0x00000001866AEF20
		public static float Angle(quaternion a, quaternion b); // 0x0000000189F3ACF4-0x0000000189F3AD58
		public static quaternion ClampAngle(quaternion from, quaternion to, float maxAngle); // 0x0000000189F3B0B0-0x0000000189F3B148
		public static float3 AxisToEuler(float3 axis); // 0x0000000189F3AD58-0x0000000189F3AE20
		public static quaternion AxisQuaternion(float3 dir); // 0x0000000189F21260-0x0000000189F228AC
		public static float ClosestPtPointSegmentRatio(float3 c, float3 a, float3 b); // 0x0000000189EFEC04-0x0000000189EFECEC
		public static float ClosestPtPointSegmentRatioNoClamp(float3 c, float3 a, float3 b); // 0x0000000189F3B33C-0x0000000189F3B418
		public static float3 ClosestPtPointSegment(float3 c, float3 a, float3 b); // 0x0000000189ED7F24-0x0000000189ED8080
		public static float3 ClosestPtPointSegmentNoClamp(float3 c, float3 a, float3 b); // 0x0000000189F3B1F4-0x0000000189F3B33C
		public static bool IntersectPointPlane(float3 planePos, float3 planeDir, float3 pos, out float3 outpos); // 0x0000000189EFEE4C-0x0000000189EFEF5C
		public static float IntersectPointPlaneDist(float3 planePos, float3 planeDir, float3 pos, out float3 outPos); // 0x0000000189EFECEC-0x0000000189EFEE4C
		public static bool IntersectSegmentPlane(float3 a, float3 b, float3 p, float3 pn, out float3 opos); // 0x0000000189F3DE04-0x0000000189F3DF80
		public static bool IntersectPointSphere(float3 sc, float sr, float3 pos, out float3 outPos); // 0x0000000189F3D5A0-0x0000000189F3D6F0
		public static bool IntersectPointSphere(float3 p, float3 sc, float sr); // 0x0000000189F354EC-0x0000000189F3555C
		public static bool IntersectRaySphere(float3 p, float3 d, float3 sc, float sr, out float3 q, out float t); // 0x0000000189F3DC68-0x0000000189F3DE04
		public static bool IntersectLineSphare(float3 a, float3 b, float3 sc, float sr, out float3 q); // 0x0000000189F3CFE0-0x0000000189F3D190
		public static bool IntersectRayCone(float3 o, float3 d, float3 c, float3 v, float cost, out float t, out float3 p); // 0x0000000189F3D6F0-0x0000000189F3DC68
		public static bool IntersectLineConeSurface(float3 a, float3 b, float3 d, float dlen, float3 c, float3 v, float cost, float3 c1, float3 c2, out float3 p); // 0x0000000189F3C53C-0x0000000189F3C6F8
		public static bool IntersectLineCylinderSurface(float3 sa, float3 sb, float3 p, float3 q, float r, out float t); // 0x0000000189F3CBC8-0x0000000189F3CFE0
		public static bool IntersectLineCylinderSurface(float3 a, float3 b, float3 c1, float3 c2, float r1, float r2, out float3 p); // 0x0000000189F3C6F8-0x0000000189F3CBC8
		public static bool IntersectLineCapsule(float3 a, float3 b, float3 c1, float3 c2, float r1, float r2, out float3 p); // 0x0000000189F3C1DC-0x0000000189F3C53C
		public static bool IntersectTrianglePointDistance(float3 p, float3 p0, float3 p1, float3 p2, float restDist, float compressionStiffness, float stretchStiffness, out float3 corr, out float3 corr0, out float3 corr1, out float3 corr2); // 0x0000000189F3F3E8-0x0000000189F3FDBC
		public static bool IntersectTrianglePointDistanceSide(float3 p, float3 p0, float3 p1, float3 p2, float restDist, float compressionStiffness, float stretchStiffness, float side, out float3 corr, out float3 corr0, out float3 corr1, out float3 corr2); // 0x0000000189F3E95C-0x0000000189F3F3E8
		public static bool IntersectTrianglePointDistanceSide2(float3 p, float3 p0, float3 p1, float3 p2, float radius, float restDist, float compressionStiffness, float stretchStiffness, float side, out float3 corr, out float3 corr0, out float3 corr1, out float3 corr2); // 0x0000000189F3DF80-0x0000000189F3E95C
		public static float DistanceTrianglePoint(float3 p, float3 p0, float3 p1, float3 p2); // 0x0000000189F3B904-0x0000000189F3BF44
		public static float3 TriangleCenter(float3 p0, float3 p1, float3 p2); // 0x00000001866B2454-0x00000001866B2508
		public static float3 TriangleNormal(float3 p0, float3 p1, float3 p2); // 0x0000000189ED8080-0x0000000189ED815C
		public static quaternion TriangleRotation(float3 p0, float3 p1, float3 p2); // 0x0000000189F3FF60-0x0000000189F400BC
		public static quaternion TriangleCenterRotation(float3 p0, float3 p1, float3 p2, float3 p3); // 0x0000000189F3FDBC-0x0000000189F3FF60
		public static float DistanceTriangleCenter(float3 p, float3 p0, float3 p1, float3 p2); // 0x00000001866AEDF8-0x00000001866AEEC4
		public static float DirectionPointTriangle(float3 p, float3 a, float3 b, float3 c); // 0x00000001866AECDC-0x00000001866AEDF8
		public static bool IntersectLineTriangle(float3 p, float3 q, float3 a, float3 b, float3 c, out float3 hitpos, out float t, out float3 n); // 0x0000000189F3D190-0x0000000189F3D5A0
		public static float ClosestPtSegmentSegment(float3 p1, float3 q1, float3 p2, float3 q2, out float s, out float t, out float3 c1, out float3 c2); // 0x0000000189F3B418-0x0000000189F3B904
		public static float GetBezierValue(BezierParam bparam, float t); // 0x0000000189F3C184-0x0000000189F3C1DC
		public static float GetBezierValue(float sval, float eval, float curve, float t); // 0x0000000189F35460-0x0000000189F354EC
	}

	public static class MeshUtility // TypeDefIndex: 55243
	{
		// Nested types
		private class TetraVertex // TypeDefIndex: 55241
		{
			// Fields
			public int index; // 0x10
			public Vector3 pos; // 0x14
	
			// Constructors
			public TetraVertex(); // 0x00000001841E1670-0x00000001841E1680
			public TetraVertex(Vector3 pos, int index); // 0x0000000184DA3830-0x0000000184DA3850
		}
	
		private class Tetra // TypeDefIndex: 55242
		{
			// Fields
			public List<TetraVertex> vertexList; // 0x10
			public Vector3 circumCenter; // 0x18
			public float circumRadius; // 0x24
			public Vector3 tetraCenter; // 0x28
			public float tetraSize; // 0x34
	
			// Constructors
			public Tetra(); // 0x0000000189F4C934-0x0000000189F4C9AC
			public Tetra(TetraVertex a, TetraVertex b, TetraVertex c, TetraVertex d); // 0x0000000189F4C818-0x0000000189F4C934
	
			// Methods
			public ulong GetTetraHash(); // 0x0000000189F4C4CC-0x0000000189F4C5C0
			public void CalcCircumcircle(); // 0x0000000189F4BA9C-0x0000000189F4C104
			public bool IntersectCircumcircle(Vector3 pos); // 0x0000000189ED4E1C-0x0000000189ED4E68
			public bool CheckSame(Tetra tri); // 0x0000000189ED4B88-0x0000000189ED4C08
			public bool ContainsPoint(TetraVertex p1); // 0x0000000189F4C478-0x0000000189F4C4CC
			public bool ContainsPoint(TetraVertex p1, TetraVertex p2, TetraVertex p3, TetraVertex p4); // 0x0000000189F4C3AC-0x0000000189F4C478
			public void CalcSize(); // 0x0000000189F4C104-0x0000000189F4C3AC
			public bool Verification(); // 0x0000000189F4C5C0-0x0000000189F4C818
		}
	
		// Methods
		public static GameObject ReplaceSkinnedMeshRendererToMeshRenderer(SkinnedMeshRenderer sren, bool replaceSkinnedMeshRenderer); // 0x0000000189F45224-0x0000000189F45508
		public static bool CalcMeshWorldPositionNormalTangent(MeshData meshData, List<Transform> boneList, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x0000000189F40E84-0x0000000189F414C4
		public static bool CalcMeshWorldPositionNormalTangent(Renderer ren, Mesh mesh, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x0000000189F414C4-0x0000000189F41F40
		public static bool CalcMeshLocalNormalTangent(List<int> selectList, Vector3[] vlist, Vector2[] uvlist, int[] triangles, out List<Vector3> lnorList, out List<Vector3> ltanList); // 0x0000000189F401DC-0x0000000189F40E84
		public static List<HashSet<int>> GetTriangleToVertexLinkList(int vcnt, List<int> lineList, List<int> triangleList); // 0x0000000189F446EC-0x0000000189F44A60
		public static List<HashSet<int>> GetVertexLinkList(int vcnt, HashSet<uint> lineSet); // 0x0000000189F44E00-0x0000000189F45080
		public static Dictionary<int, HashSet<int>> GetVertexToTriangles(List<int> triangleList); // 0x0000000189F45080-0x0000000189F45224
		public static int RestTriangleVertex(int tindex, int v0, int v1, List<int> triangleList); // 0x0000000189F4560C-0x0000000189F4569C
		public static void RestTriangleVertex(int tindex, int v0, List<int> triangleList, out int v1, out int v2); // 0x0000000189F45508-0x0000000189F4560C
		public static bool CheckAdjacentTriangle(int tindex0, int tindex1, List<int> triangleList); // 0x0000000189F440DC-0x0000000189F441A0
		public static Dictionary<uint, List<int>> GetTriangleEdgePair(List<int> triangleList); // 0x0000000189F44444-0x0000000189F445B0
		private static void AddTriangleEdge(int v0, int v1, int tindex, Dictionary<uint, List<int>> triangleEdgeDict); // 0x0000000189F400BC-0x0000000189F401DC
		public static List<ulong> GetTrianglePackList(List<int> triangleList); // 0x0000000189F445B0-0x0000000189F446EC
		public static float ClosestPtBoneLine(Vector3 pos, Transform bone, float lineWidth, out Vector3 d); // 0x0000000189F441A0-0x0000000189F44444
		public static List<Transform> GetUseBoneTransformList(Transform[] bones, Mesh mesh); // 0x0000000189F44A60-0x0000000189F44E00
		public static void CalcTetraMesh(List<Vector3> posList, out int tetraCount, out List<int> tetraIndexList, out List<float> tetraSizeList); // 0x0000000189F41F40-0x0000000189F440DC
		public static Transform GetReplaceBone<T>(Transform now, Dictionary<T, Transform> boneReplaceDict)
			where T : class;
	}

	public class StaticStringBuilder // TypeDefIndex: 55244
	{
		// Fields
		private static StringBuilder stringBuilder; // 0x00
	
		// Properties
		public static StringBuilder Instance { get; } // 0x0000000189F4BA0C-0x0000000189F4BA5C 
	
		// Constructors
		public StaticStringBuilder(); // 0x00000001841E1670-0x00000001841E1680
		static StaticStringBuilder(); // 0x0000000189F4B988-0x0000000189F4BA0C
	
		// Methods
		public static void Clear(); // 0x0000000189F4B8D8-0x0000000189F4B930
		public static StringBuilder Append(params object[] args); // 0x0000000189F4B838-0x0000000189F4B8D8
		public static StringBuilder AppendLine(params object[] args); // 0x0000000189F4B60C-0x0000000189F4B6E0
		public static StringBuilder AppendLine(); // 0x0000000189F4B6E0-0x0000000189F4B75C
		public static string AppendToString(params object[] args); // 0x0000000189F4B75C-0x0000000189F4B838
		public static new string ToString(); // 0x0000000189F4B930-0x0000000189F4B988
	}

	[Serializable]
	public class UpdateTimeManager // TypeDefIndex: 55248
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
		public int FixedUpdateCount { get; } // 0x00000001811F2A90-0x00000001811F2AA0 
		public int UpdatePerSecond { get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 
		public float UpdateIntervalTime { get; } // 0x0000000184DA3880-0x0000000184DA38A0 
		public float UpdatePower { get; } // 0x0000000184DA38A0-0x0000000184DA38C0 
		public float TimeScale { get; set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000189F4C9E8-0x0000000189F4CA00
		public float DeltaTime { get; } // 0x0000000185391A8C-0x0000000185391A94 
		public float PhysicsDeltaTime { get; } // 0x0000000183233AF0-0x0000000183233B20 
		public float AverageDeltaTime { get; } // 0x0000000189F4C9AC-0x0000000189F4C9B4 
		public bool IsUnscaledUpdate { get; } // 0x0000000189F4C9B4-0x0000000189F4C9C8 
		public bool IsDelay { get; } // 0x0000000183233A70-0x0000000183233A80 
		public float FuturePredictionRate { get; set; } // 0x00000001811EC8A0-0x00000001811EC8B0 0x0000000189F4C9D0-0x0000000189F4C9E8
		public bool UpdateBoneScale { get; set; } // 0x0000000184D86870-0x0000000184D86880 0x0000000184D86880-0x0000000184D86890
		public int WorkerMaximumCount { get; } // 0x0000000189F4C9C8-0x0000000189F4C9D0 
	
		// Nested types
		public enum UpdateCount // TypeDefIndex: 55245
		{
			_60 = 60,
			_90_Default = 90,
			_120 = 120,
			_150 = 150,
			_180 = 180
		}
	
		public enum UpdateMode // TypeDefIndex: 55246
		{
			UnscaledTime = 0,
			OncePerFrame = 1,
			DelayUnscaledTime = 10
		}
	
		public enum UpdateLocation // TypeDefIndex: 55247
		{
			AfterLateUpdate = 0,
			BeforeLateUpdate = 1
		}
	
		// Constructors
		public UpdateTimeManager(); // 0x0000000184DA3860-0x0000000184DA3880
	
		// Methods
		public void ResetFixedUpdateCount(); // 0x0000000184DA3850-0x0000000184DA3860
		public void AddFixedUpdateCount(); // 0x0000000184D9EBD0-0x0000000184D9EBE0
		public UpdateMode GetUpdateMode(); // 0x0000000184D882A0-0x0000000184D882B0
		public void SetUpdateMode(UpdateMode mode); // 0x0000000184D8F540-0x0000000184D8F550
		public UpdateLocation GetUpdateLocation(); // 0x00000001811EF5B0-0x00000001811EF5C0
		public void SetUpdateLocation(UpdateLocation location); // 0x00000001811EF9B0-0x00000001811EF9C0
		public void SetUpdatePerSecond(UpdateCount ucount); // 0x00000001814F51F0-0x00000001814F5220
	}

	public class ReferenceDataBuilder<T> // TypeDefIndex: 55249
		where T : struct
	{
		// Fields
		private int indexCount;
		private List<T> dataList;
		private List<List<int>> indexToDataIndexList;
		private List<List<int>> dataIndexToIndexList;
	
		// Constructors
		public ReferenceDataBuilder();
	
		// Methods
		public void Init(int indexCount);
		public void AddData(T data, params int[] indexes);
		public ValueTuple<List<ReferenceDataIndex>, List<T>> GetDirectReferenceData();
		public ValueTuple<List<ReferenceDataIndex>, List<int>, List<List<int>>> GetIndirectReferenceData();
	}

	[Serializable]
	public struct ReferenceDataIndex // TypeDefIndex: 55250
	{
		// Fields
		public int startIndex; // 0x00
		public int count; // 0x04
	}

	public interface IDataHash // TypeDefIndex: 55251
	{
		// Methods
		int GetDataHash();
	}

	public interface IShareDataObject // TypeDefIndex: 55252
	{
		// Methods
		List<ShareDataObject> GetAllShareDataObject();
		ShareDataObject DuplicateShareDataObject(ShareDataObject source);
	}

	[Serializable]
	public abstract class ShareDataObject : ScriptableObject, IDataVerify, IDataHash // TypeDefIndex: 55253
	{
		// Fields
		[SerializeField]
		protected int dataHash; // 0x18
		[SerializeField]
		protected int dataVersion; // 0x1C
	
		// Properties
		public int SaveDataHash { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public int SaveDataVersion { get; set; } // 0x0000000184D86310-0x0000000184D86320 0x0000000184D86320-0x0000000184D86330
	
		// Constructors
		protected ShareDataObject(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		public abstract int GetDataHash();
		public abstract int GetVersion();
		public abstract Define.Error VerifyData();
		public virtual void CreateVerifyData(); // 0x0000000189F4B5B0-0x0000000189F4B5E0
		public virtual string GetInformation(); // 0x0000000189F4B5E0-0x0000000189F4B60C
		public static T CreateShareData<T>(string dataName)
			where T : ShareDataObject;
		public static bool RemoveNullAndDuplication<T>(List<T> data);
		public static T Clone<T>(T source)
			where T : ShareDataObject;
	}

	public class StopWatch // TypeDefIndex: 55254
	{
		// Fields
		private float startTime; // 0x10
		private float endTime; // 0x14
	
		// Properties
		public float ElapsedSeconds { get; } // 0x0000000184DA3820-0x0000000184DA3830 
		public float ElapsedMilliseconds { get; } // 0x0000000184DA3800-0x0000000184DA3820 
	
		// Constructors
		public StopWatch(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public StopWatch Start(); // 0x0000000189F4BA5C-0x0000000189F4BA7C
		public StopWatch Stop(); // 0x0000000189F4BA7C-0x0000000189F4BA9C
	}
}

namespace MagicaReductionMesh
{
	public class ReductionMesh // TypeDefIndex: 54951
	{
		// Fields
		[CompilerGenerated]
		private ReductionWeightMode _WeightMode_k__BackingField; // 0x10
		private MeshData meshData; // 0x18
		private ReductionData reductionData; // 0x20
		private DebugData debugData; // 0x28
	
		// Properties
		public ReductionWeightMode WeightMode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
		public MeshData MeshData { get; } // 0x0000000189ED1A44-0x0000000189ED1A70 
		public ReductionData ReductionData { get; } // 0x0000000184A379B0-0x0000000184A379E0 
		public DebugData DebugData { get; } // 0x0000000189ED1A18-0x0000000189ED1A44 
	
		// Nested types
		public enum ReductionWeightMode // TypeDefIndex: 54950
		{
			Distance = 0,
			Average = 1,
			DistanceAverage = 2
		}
	
		// Constructors
		public ReductionMesh(); // 0x0000000189ED1960-0x0000000189ED1A18
	
		// Methods
		public int AddMesh(bool isSkinning, Mesh mesh, List<Transform> bones, Matrix4x4[] bindPoseList, BoneWeight[] boneWeightList); // 0x0000000189ED17D0-0x0000000189ED1838
		public int AddMesh(Renderer ren); // 0x0000000189ED1554-0x0000000189ED17D0
		public int AddMesh(Transform root, List<Vector3> posList, List<Vector3> norList = null, List<Vector4> tanList = null, List<Vector2> uvList = null, List<int> triangleList = null); // 0x0000000189ED14E0-0x0000000189ED1554
		public void Reduction(float zeroRadius, float radius, float polygonLength, bool createTetra); // 0x0000000189ED1868-0x0000000189ED1960
		public FinalData GetFinalData(Transform root); // 0x0000000189ED1838-0x0000000189ED1868
	}

	public abstract class ReductionMeshAccess // TypeDefIndex: 54952
	{
		// Fields
		protected ReductionMesh parent; // 0x10
	
		// Properties
		protected MeshData MeshData { get; } // 0x0000000189ED14A0-0x0000000189ED14C0 
		protected ReductionData ReductionData { get; } // 0x0000000189ED14C0-0x0000000189ED14E0 
		protected DebugData DebugData { get; } // 0x0000000189ED1480-0x0000000189ED14A0 
	
		// Constructors
		protected ReductionMeshAccess(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public virtual void SetParent(ReductionMesh parent); // 0x00000001853908C0-0x00000001853908D0
	}

	public class DebugData : ReductionMeshAccess // TypeDefIndex: 54953
	{
		// Constructors
		public DebugData(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void DispMeshInfo(string header = "" /* Metadata: 0x02346817 */); // 0x0000000189EC2B90-0x0000000189EC2E3C
		public static void DebugDrawShared(FinalData final, bool drawTriangle = true /* Metadata: 0x02346818 */, bool drawLine = true /* Metadata: 0x02346819 */, bool drawTetra = true /* Metadata: 0x0234681A */, bool drawVertexNormal = true /* Metadata: 0x0234681B */, bool drawVertexTangent = true /* Metadata: 0x0234681C */, bool drawNumber = false /* Metadata: 0x0234681D */, int maxPolygonCount = 2147483647 /* Metadata: 0x0234681E */, int layer = -1 /* Metadata: 0x0234681F */, int tetraIndex = -1 /* Metadata: 0x02346820 */, float tetraSize = 1f /* Metadata: 0x02346821 */, List<int> drawNumberList = null, float axisSize = 0.01f /* Metadata: 0x02346825 */); // 0x0000000189EC1FCC-0x0000000189EC2B90
		private static void DrawTetra(FinalData final, int tetraIndex, List<Vector3> wposList, float tetraSize); // 0x0000000189EC2E3C-0x0000000189EC30E4
		public static void DebugDrawChild(FinalData final, bool drawPosition = false /* Metadata: 0x02346829 */, bool drawNormal = false /* Metadata: 0x0234682A */, bool drawTriangle = false /* Metadata: 0x0234682B */, bool drawNumber = false /* Metadata: 0x0234682C */, int maxVertexCount = 2147483647 /* Metadata: 0x0234682D */, float positionSize = 0.001f /* Metadata: 0x0234682E */, float axisSize = 0.01f /* Metadata: 0x02346832 */); // 0x0000000189EC1B24-0x0000000189EC1FCC
	}

	[Serializable]
	public class FinalData // TypeDefIndex: 54956
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
		public bool IsValid { get; } // 0x0000000189EC35C4-0x0000000189EC3608 
		public int VertexCount { get; } // 0x0000000189EC3720-0x0000000189EC3760 
		public int LineCount { get; } // 0x0000000189EC3608-0x0000000189EC364C 
		public int TriangleCount { get; } // 0x0000000189EC36D4-0x0000000189EC3720 
		public int TetraCount { get; } // 0x0000000189EC368C-0x0000000189EC36D4 
		public int BoneCount { get; } // 0x0000000189EC3584-0x0000000189EC35C4 
		public bool IsSkinning { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public int MeshCount { get; } // 0x0000000189EC364C-0x0000000189EC368C 
	
		// Nested types
		[Serializable]
		public class MeshIndexData // TypeDefIndex: 54954
		{
			// Fields
			public List<uint> meshIndexPackList; // 0x10
	
			// Constructors
			public MeshIndexData(); // 0x0000000189ECE46C-0x0000000189ECE4E4
		}
	
		[Serializable]
		public class MeshInfo // TypeDefIndex: 54955
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
			public int VertexCount { get; } // 0x0000000189ECE6E8-0x0000000189ECE728 
	
			// Constructors
			public MeshInfo(); // 0x0000000189ECE4E4-0x0000000189ECE670
		}
	
		// Constructors
		public FinalData(); // 0x0000000189EC30E4-0x0000000189EC3584
	}

	public class MeshData : ReductionMeshAccess // TypeDefIndex: 54976
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
		public int VertexCount { get; } // 0x0000000189ECE42C-0x0000000189ECE46C 
		public int LineCount { get; } // 0x0000000189ECE32C-0x0000000189ECE36C 
		public int TriangleCount { get; } // 0x0000000189ECE3EC-0x0000000189ECE42C 
		public int TetraCount { get; } // 0x0000000189ECE3AC-0x0000000189ECE3EC 
		public int MeshCount { get; } // 0x0000000189ECE36C-0x0000000189ECE3AC 
		public float WeightPow { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
		public int MaxWeightCount { get; set; } // 0x0000000184D86540-0x0000000184D86550 0x0000000184D86590-0x0000000184D865A0
		public float SameSurfaceAngle { get; set; } // 0x0000000184D88400-0x0000000184D88410 0x0000000184D88430-0x0000000184D88440
		public bool RemoveSameTrianglePair { get; set; } // 0x0000000184D86D90-0x0000000184D86DA0 0x0000000184D86DB0-0x0000000184D86DC0
		public float RemoveSameTrianglePairAngle { get; set; } // 0x0000000184D88480-0x0000000184D88490 0x0000000184D884A0-0x0000000184D884B0
	
		// Nested types
		public class WeightData // TypeDefIndex: 54957
		{
			// Fields
			public int boneIndex; // 0x10
			public float boneWeight; // 0x14
	
			// Constructors
			public WeightData(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public class Vertex // TypeDefIndex: 54958
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
			public Vertex(); // 0x0000000189ED7C38-0x0000000189ED7F24
		}
	
		public class MeshInfo // TypeDefIndex: 54959
		{
			// Fields
			public int index; // 0x10
			public Mesh mesh; // 0x18
			public int vertexCount; // 0x20
			public List<Vertex> vertexList; // 0x28
	
			// Constructors
			public MeshInfo(); // 0x0000000189ECE670-0x0000000189ECE6E8
		}
	
		public class ShareVertex // TypeDefIndex: 54964
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
			[CompilerGenerated]
			private sealed class __c__DisplayClass20_0 // TypeDefIndex: 54960
			{
				// Fields
				public WeightData w; // 0x10
	
				// Constructors
				public __c__DisplayClass20_0(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal bool _CalcBoneWeight_DistanceAverage_b__1(WeightData wdata); // 0x0000000189ED609C-0x0000000189ED60C4
			}
	
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 54961
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Comparison<WeightData> __9__20_0; // 0x08
				public static Comparison<WeightData> __9__21_0; // 0x10
				public static Comparison<WeightData> __9__23_0; // 0x18
	
				// Constructors
				static __c(); // 0x0000000189ED61C0-0x0000000189ED6224
				public __c(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal int _CalcBoneWeight_DistanceAverage_b__20_0(WeightData a, WeightData b); // 0x0000000189ED6034-0x0000000189ED606C
				internal int _CalcBoneWeight_Average_b__21_0(WeightData a, WeightData b); // 0x0000000189ED6034-0x0000000189ED606C
				internal int _CalcBoneWeight_Distance_b__23_0(WeightData a, WeightData b); // 0x0000000189ED6034-0x0000000189ED606C
			}
	
			[CompilerGenerated]
			private sealed class __c__DisplayClass21_0 // TypeDefIndex: 54962
			{
				// Fields
				public WeightData w; // 0x10
	
				// Constructors
				public __c__DisplayClass21_0(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal bool _CalcBoneWeight_Average_b__1(WeightData wdata); // 0x0000000189ED609C-0x0000000189ED60C4
			}
	
			[CompilerGenerated]
			private sealed class __c__DisplayClass23_0 // TypeDefIndex: 54963
			{
				// Fields
				public WeightData w; // 0x10
	
				// Constructors
				public __c__DisplayClass23_0(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal bool _CalcBoneWeight_Distance_b__1(WeightData wdata); // 0x0000000189ED609C-0x0000000189ED60C4
			}
	
			// Constructors
			public ShareVertex(); // 0x0000000189ED3F08-0x0000000189ED4078
	
			// Methods
			public void AddLink(ShareVertex mv); // 0x0000000189ED1A70-0x0000000189ED1AC8
			public void ReplaseLink(ShareVertex old, ShareVertex mv); // 0x0000000189ED3E50-0x0000000189ED3F08
			public void RecalcCoordinate(); // 0x0000000189ED3B68-0x0000000189ED3E50
			public void CalcNormalTangentFromTriangle(); // 0x0000000189ED3728-0x0000000189ED3964
			public Vector3 CalcLocalPos(Vector3 pos); // 0x0000000189ED3634-0x0000000189ED3728
			public Vector3 CalcLocalDir(Vector3 dir); // 0x0000000189ED3584-0x0000000189ED3634
			public Matrix4x4 CalcWorldToLocalMatrix(); // 0x0000000189ED3964-0x0000000189ED3A78
			public void CalcBoneWeight(ReductionMesh.ReductionWeightMode weightMode, float weightPow); // 0x0000000189ED3548-0x0000000189ED3584
			private void CalcBoneWeight_DistanceAverage(float weightPow); // 0x0000000189ED236C-0x0000000189ED2D54
			private void CalcBoneWeight_Average(); // 0x0000000189ED1CF8-0x0000000189ED236C
			private void AdjustWeight(List<WeightData> sumlist); // 0x0000000189ED1AC8-0x0000000189ED1CF8
			private void CalcBoneWeight_Distance(float weightPow); // 0x0000000189ED2D54-0x0000000189ED3548
			public BoneWeight GetBoneWeight(); // 0x0000000189ED3A78-0x0000000189ED3B68
		}
	
		public class Triangle // TypeDefIndex: 54966
		{
			// Fields
			public int tindex; // 0x10
			public List<ShareVertex> shareVertexList; // 0x18
			public Vector3 wnor; // 0x20
			public Vector3 wtan; // 0x2C
			public bool flipLock; // 0x38
	
			// Nested types
			[CompilerGenerated]
			private sealed class __c__DisplayClass9_0 // TypeDefIndex: 54965
			{
				// Fields
				public int edgev0; // 0x10
				public int edgev1; // 0x14
	
				// Constructors
				public __c__DisplayClass9_0(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal bool _GetNonEdgeVertex_b__0(ShareVertex sv); // 0x0000000189ED6130-0x0000000189ED615C
			}
	
			// Constructors
			public Triangle(); // 0x0000000189ED5FBC-0x0000000189ED6034
	
			// Methods
			public void GetEdge(out uint edge0, out uint edge1, out uint edge2); // 0x0000000189ED5A0C-0x0000000189ED5B78
			public Vector3 CalcTriangleNormal(); // 0x0000000189ED5254-0x0000000189ED55A0
			public void Flip(); // 0x0000000189ED5914-0x0000000189ED5A0C
			public Vector3 CalcTriangleTangent(); // 0x0000000189ED55A0-0x0000000189ED5914
			public ShareVertex GetNonEdgeVertex(int edgev0, int edgev1); // 0x0000000189ED5B78-0x0000000189ED5C4C
			public ulong GetTriangleHash(); // 0x0000000189ED5D34-0x0000000189ED5DE8
			public static float GetTriangleArea(ShareVertex sv0, ShareVertex sv1, ShareVertex sv2); // 0x0000000189ED5C4C-0x0000000189ED5D34
			public override string ToString(); // 0x0000000189ED5DE8-0x0000000189ED5FBC
		}
	
		private class Line // TypeDefIndex: 54967
		{
			// Fields
			public List<ShareVertex> shareVertexList; // 0x10
	
			// Constructors
			public Line(); // 0x0000000189EC3760-0x0000000189EC37D8
		}
	
		public enum UvWrapMode // TypeDefIndex: 54968
		{
			None = 0,
			Sphere = 1
		}
	
		public class Square // TypeDefIndex: 54969
		{
			// Fields
			public ulong shash; // 0x10
			public List<Triangle> triangleList; // 0x18
			public float angle; // 0x20
	
			// Constructors
			public Square(); // 0x0000000189ED4200-0x0000000189ED4278
	
			// Methods
			public override string ToString(); // 0x0000000189ED4078-0x0000000189ED4200
		}
	
		public class Tetra // TypeDefIndex: 54970
		{
			// Fields
			public List<ShareVertex> shareVertexList; // 0x10
			public Vector3 circumCenter; // 0x18
			public float circumRadius; // 0x24
			public Vector3 tetraCenter; // 0x28
			public float tetraSize; // 0x34
	
			// Constructors
			public Tetra(); // 0x0000000189ED50C0-0x0000000189ED5138
			public Tetra(ShareVertex a, ShareVertex b, ShareVertex c, ShareVertex d); // 0x0000000189ED5138-0x0000000189ED5254
	
			// Methods
			public ulong GetTetraHash(); // 0x0000000189ED4D28-0x0000000189ED4E1C
			public void CalcCircumcircle(); // 0x0000000189ED4278-0x0000000189ED48E0
			public bool IntersectCircumcircle(Vector3 pos); // 0x0000000189ED4E1C-0x0000000189ED4E68
			public bool CheckSame(Tetra tri); // 0x0000000189ED4B88-0x0000000189ED4C08
			public bool ContainsPoint(ShareVertex p1); // 0x0000000189ED4C08-0x0000000189ED4C5C
			public bool ContainsPoint(ShareVertex p1, ShareVertex p2, ShareVertex p3, ShareVertex p4); // 0x0000000189ED4C5C-0x0000000189ED4D28
			public void CalcSize(); // 0x0000000189ED48E0-0x0000000189ED4B88
			public bool Verification(); // 0x0000000189ED4E68-0x0000000189ED50C0
		}
	
		private class LinkInfo // TypeDefIndex: 54971
		{
			// Fields
			public ShareVertex sv; // 0x10
			public float length; // 0x18
			public int count; // 0x1C
	
			// Constructors
			public LinkInfo(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		private class VertexLengthInfo // TypeDefIndex: 54972
		{
			// Fields
			public ShareVertex sv; // 0x10
			public float length; // 0x18
	
			// Constructors
			public VertexLengthInfo(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass65_0 // TypeDefIndex: 54973
		{
			// Fields
			public float weightLength; // 0x10
	
			// Constructors
			public __c__DisplayClass65_0(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass65_1 // TypeDefIndex: 54974
		{
			// Fields
			public Vertex vt; // 0x10
			public __c__DisplayClass65_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass65_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _CreateOriginalMeshInfo_b__0(ShareVertex sv); // 0x0000000189ED60C4-0x0000000189ED6130
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 54975
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<VertexLengthInfo> __9__69_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000189ED615C-0x0000000189ED61C0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _SearchNearPointList_b__69_0(VertexLengthInfo a, VertexLengthInfo b); // 0x0000000189ED606C-0x0000000189ED609C
		}
	
		// Constructors
		public MeshData(); // 0x0000000189ECE0CC-0x0000000189ECE32C
	
		// Methods
		public int AddMesh(bool isSkinning, Mesh mesh, List<Transform> bones, Matrix4x4[] bindPoseList, BoneWeight[] boneWeightList); // 0x0000000189EC3F38-0x0000000189EC4BE4
		public int AddMesh(Transform root, List<Vector3> posList, List<Vector3> norList = null, List<Vector4> tanList = null, List<Vector2> uvList = null, List<int> triangleList = null); // 0x0000000189EC37D8-0x0000000189EC3F38
		public void CombineVertex(ShareVertex sv0, ShareVertex sv1); // 0x0000000189EC6F7C-0x0000000189EC72AC
		public void UpdateMeshData(bool createTetra); // 0x0000000189ECE064-0x0000000189ECE0CC
		private void CalcVertexIndex(); // 0x0000000189EC6B7C-0x0000000189EC6D24
		private void CalcUV(UvWrapMode wrapMode); // 0x0000000189EC67A4-0x0000000189EC6B7C
		private void CreateTriangleAndLine(); // 0x0000000189EC9C54-0x0000000189ECB04C
		private void CalcShareVertexWeight(); // 0x0000000189EC63C0-0x0000000189EC64F8
		private void AdjustTriangleNormal(); // 0x0000000189EC4C7C-0x0000000189EC5728
		private bool CheckTwoTriangleOpen(Triangle tri1, Triangle tri2, uint edge); // 0x0000000189EC6E38-0x0000000189EC6F7C
		private float CalcTwoTriangleAngle(Triangle tri1, Triangle tri2, uint edge); // 0x0000000189EC64F8-0x0000000189EC67A4
		private Dictionary<uint, List<ulong>> GetEdgeToTriangleDict(); // 0x0000000189ECB04C-0x0000000189ECB574
		private void CalcVertexNormalFromTriangle(); // 0x0000000189EC6D24-0x0000000189EC6E38
		private void RemoveTriangle(ulong thash); // 0x0000000189ECD6D4-0x0000000189ECD8EC
		private Dictionary<ulong, List<Square>> GetSquareDict(); // 0x0000000189ECCD54-0x0000000189ECD5C4
		private void RemoveOverlappingSquareTriangles(); // 0x0000000189ECD5C4-0x0000000189ECD6D4
		private void CreateTetraMesh(); // 0x0000000189EC83A8-0x0000000189EC9C54
		private Bounds CalcBounding(); // 0x0000000189EC5728-0x0000000189EC593C
		public FinalData GetFinalData(Transform root); // 0x0000000189ECB574-0x0000000189ECCD54
		private void CreateOriginalMeshInfo(FinalData final, Transform root, float weightLength); // 0x0000000189EC72AC-0x0000000189EC83A8
		private void AddVertexToMeshIndexData(FinalData final, int sindex, int meshIndex, int meshVertexIndex); // 0x0000000189EC4BE4-0x0000000189EC4C7C
		private List<ShareVertex> SearchNearPointList(Vector3 basePos, ShareVertex sv, float weightLength, int maxCount); // 0x0000000189ECD8EC-0x0000000189ECE064
		public void CalcMeshWorldPositionNormalTangent(bool isSkinning, Mesh mesh, List<Transform> bones, Matrix4x4[] bindPoseList, BoneWeight[] boneWeightList, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector4> wtanList); // 0x0000000189EC593C-0x0000000189EC63C0
	}

	public class ReductionData : ReductionMeshAccess // TypeDefIndex: 54977
	{
		// Constructors
		public ReductionData(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void ReductionZeroDistance(float radius = 0.0001f /* Metadata: 0x02346838 */); // 0x0000000189ED13F4-0x0000000189ED1480
		public void ReductionRadius(float radius); // 0x0000000189ED1368-0x0000000189ED13F4
		public void ReductionPolygonLink(float length); // 0x0000000189ED12DC-0x0000000189ED1368
		public void ReductionBone(); // 0x0000000189ED0E10-0x0000000189ED12DC
	}

	public class NearPointReduction // TypeDefIndex: 54979
	{
		// Fields
		protected MeshData meshData; // 0x10
		private List<Point> pointList; // 0x18
		protected Dictionary<Vector3Int, List<Point>> gridMap; // 0x20
		protected float gridSize; // 0x28
		private float searchRadius; // 0x2C
		private Dictionary<Point, List<Point>> nearPointDict; // 0x30
	
		// Properties
		public int PointCount { get; } // 0x0000000189ECFEA8-0x0000000189ECFEE8 
	
		// Nested types
		public class Point // TypeDefIndex: 54978
		{
			// Fields
			public MeshData.ShareVertex shareVertex; // 0x10
			public Vector3 pos; // 0x18
			public Vector3Int grid; // 0x24
			public Point nearPoint; // 0x30
			public float nearDist; // 0x38
	
			// Constructors
			public Point(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public NearPointReduction(float radius = 0.05f /* Metadata: 0x0234683C */); // 0x0000000189ECFD7C-0x0000000189ECFEA8
	
		// Methods
		public void Create(MeshData meshData); // 0x0000000189ECE974-0x0000000189ECEAE8
		public void Reduction(); // 0x0000000189ECED18-0x0000000189ECF25C
		private Point AddPoint(MeshData.ShareVertex sv, Vector3 pos); // 0x0000000189ECE8B8-0x0000000189ECE974
		private void AddGrid(Point p); // 0x0000000189ECE728-0x0000000189ECE8B8
		private void RemoveGrid(Point p); // 0x0000000189ECF25C-0x0000000189ECF3DC
		private void Move(Point p, Vector3 newpos); // 0x0000000189ECECC0-0x0000000189ECED18
		private void Remove(Point p); // 0x0000000189ECF3DC-0x0000000189ECF440
		protected Vector3Int GetGridPos(Vector3 pos); // 0x0000000189ECEAE8-0x0000000189ECEB60
		private void SearchNearPointAll(); // 0x0000000189ECF440-0x0000000189ECF6D4
		private void SearchNearPoint(Point p, float radius, Point ignorePoint); // 0x0000000189ECF6D4-0x0000000189ECFD7C
		private Point GetNearPointPair(); // 0x0000000189ECEB60-0x0000000189ECECC0
	}

	public class PolygonLinkReduction // TypeDefIndex: 54981
	{
		// Fields
		protected MeshData meshData; // 0x10
		private float reductionLength; // 0x18
		private List<Point> pointList; // 0x20
		private Dictionary<MeshData.ShareVertex, Point> pointDict; // 0x28
	
		// Properties
		public int PointCount { get; } // 0x0000000189ED0DD0-0x0000000189ED0E10 
	
		// Nested types
		public class Point // TypeDefIndex: 54980
		{
			// Fields
			public MeshData.ShareVertex shareVertex; // 0x10
			public Point nearPoint; // 0x18
			public float nearDist; // 0x20
	
			// Constructors
			public Point(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public PolygonLinkReduction(float length); // 0x0000000189ED0D00-0x0000000189ED0DD0
	
		// Methods
		public void Create(MeshData meshData); // 0x0000000189ECFF9C-0x0000000189ED00E8
		public void Reduction(); // 0x0000000189ED02CC-0x0000000189ED0904
		private void AddPoint(MeshData.ShareVertex sv); // 0x0000000189ECFEE8-0x0000000189ECFF9C
		private Point GetPoint(MeshData.ShareVertex sv); // 0x0000000189ED0248-0x0000000189ED02CC
		private void Remove(Point p); // 0x0000000189ED0904-0x0000000189ED0984
		private void SearchNearPointAll(); // 0x0000000189ED0984-0x0000000189ED0A98
		private void SearchNearPoint(Point p); // 0x0000000189ED0A98-0x0000000189ED0D00
		private Point GetNearPointPair(); // 0x0000000189ED00E8-0x0000000189ED0248
	}

	public class Utility // TypeDefIndex: 54982
	{
		// Constructors
		public Utility(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static uint PackPair(int v0, int v1); // 0x000000018677F488-0x000000018677F4A0
		public static void UnpackPair(uint pack, out int v0, out int v1); // 0x0000000184DA3080-0x0000000184DA3090
		public static ulong PackTriple(int v0, int v1, int v2); // 0x0000000189ED7AFC-0x0000000189ED7C38
		public static void UnpackTriple(ulong pack, out int v0, out int v1, out int v2); // 0x0000000184DA30C0-0x0000000184DA30E0
		public static ulong PackQuater(int v0, int v1, int v2, int v3); // 0x0000000189ED7984-0x0000000189ED7AFC
		public static void UnpackQuater(ulong pack, out int v0, out int v1, out int v2, out int v3); // 0x0000000184DA3090-0x0000000184DA30C0
		public static uint Pack16(int hi, int low); // 0x0000000184D874D0-0x0000000184D874E0
		public static int Unpack16Hi(uint pack); // 0x0000000184D875B0-0x0000000184D875C0
		public static int Unpack16Low(uint pack); // 0x0000000184D875C0-0x0000000184D875D0
		public static ulong Pack32(int hi, int low); // 0x0000000184D91CF0-0x0000000184D91D00
		public static int Unpack32Hi(ulong pack); // 0x0000000184D9D8A0-0x0000000184D9D8B0
		public static int Unpack32Low(ulong pack); // 0x0000000184D88BE0-0x0000000184D88BF0
		public static void CalcFinalDataWorldPositionNormalTangent(FinalData final, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector4> wtanList); // 0x0000000189ED6D78-0x0000000189ED770C
		public static void CalcFinalDataChildWorldPositionNormalTangent(FinalData final, int meshIndex, List<Vector3> sposList, List<Vector3> snorList, List<Vector4> stanList, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector4> wtanList); // 0x0000000189ED6224-0x0000000189ED6D78
		public static void CalcLocalPositionNormalTangent(Transform root, List<Vector3> wposList, List<Vector3> wnorList, List<Vector4> wtanList); // 0x0000000189ED770C-0x0000000189ED7984
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 54948
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 54949
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}
