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

// Image 25: MagicaCloth.dll - Assembly: MagicaCloth, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 81994-82301

namespace MagicaCloth
{
	public abstract class BaseCloth : PhysicsTeam // TypeDefIndex: 82031
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
		public float BlendWeight { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187839DAC-0x0000000187839DC4
		public Vector3 Gravity_GravityDirection { get; set; } // 0x000000018C2F6ED0-0x000000018C2F6EFC 0x000000018C2F732C-0x000000018C2F740C
		public bool DistanceDisable_Active { get; set; } // 0x000000018C2F6E10-0x000000018C2F6E30 0x000000018C2F70E0-0x000000018C2F7100
		public Transform DistanceDisable_ReferenceObject { get; set; } // 0x000000018C2F6E70-0x000000018C2F6E90 0x000000018C2F7150-0x000000018C2F717C
		public float DistanceDisable_Distance { get; set; } // 0x000000018C2F6E30-0x000000018C2F6E50 0x000000018C2F7100-0x000000018C2F7128
		public float DistanceDisable_FadeDistance { get; set; } // 0x000000018C2F6E50-0x000000018C2F6E70 0x000000018C2F7128-0x000000018C2F7150
		public float ExternalForce_WindInfluence { get; set; } // 0x000000018C2F6E90-0x000000018C2F6EB0 0x000000018C2F717C-0x000000018C2F7254
		public float ExternalForce_WindRandomScale { get; set; } // 0x000000018C2F6EB0-0x000000018C2F6ED0 0x000000018C2F7254-0x000000018C2F732C
		public float WorldInfluence_MaxMoveSpeed { get; set; } // 0x000000018C2F6F5C-0x000000018C2F6F7C 0x000000018C2F7674-0x000000018C2F7740
		public bool WorldInfluence_ResetAfterTeleport { get; set; } // 0x000000018C2F6F7C-0x000000018C2F6F9C 0x000000018C2F7740-0x000000018C2F7808
		public float WorldInfluence_TeleportDistance { get; set; } // 0x000000018C2F6FBC-0x000000018C2F6FDC 0x000000018C2F78AC-0x000000018C2F7974
		public float WorldInfluence_TeleportRotation { get; set; } // 0x000000018C2F6FFC-0x000000018C2F701C 0x000000018C2F7A38-0x000000018C2F7B00
		public ClothParams.TeleportMode WorldInfluence_TeleportMode { get; set; } // 0x000000018C2F6FDC-0x000000018C2F6FFC 0x000000018C2F7974-0x000000018C2F7A38
		public float WorldInfluence_StabilizationTime { get; set; } // 0x000000018C2F6F9C-0x000000018C2F6FBC 0x000000018C2F7808-0x000000018C2F78AC
		public bool ColliderCollision_Active { get; set; } // 0x000000018C2F6DF0-0x000000018C2F6E10 0x000000018C2F701C-0x000000018C2F70E0
		public bool Penetration_Active { get; set; } // 0x000000018C2F6EFC-0x000000018C2F6F1C 0x000000018C2F740C-0x000000018C2F74D8
		public bool Spring_Active { get; set; } // 0x000000018C2F6F1C-0x000000018C2F6F3C 0x000000018C2F74D8-0x000000018C2F75A0
		public float Spring_Power { get; set; } // 0x000000018C2F6F3C-0x000000018C2F6F5C 0x000000018C2F75A0-0x000000018C2F7674
		public ClothParams Params { get; } // 0x00000001829CD170-0x00000001829CD180 
		public ClothData ClothData { get; set; } // 0x0000000187232F50-0x0000000187232F60 0x0000000188800C74-0x0000000188800C88
		public SelectionData ClothSelection { get; } // 0x0000000187232C70-0x0000000187232C80 
		public ClothSetup Setup { get; } // 0x0000000187232F90-0x0000000187232FA0 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 82030
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Renderer, bool> __9__106_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018C31F4E0-0x000000018C31F544
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetCullRenderListCount_b__106_0(Renderer x); // 0x000000018C31F110-0x000000018C31F15C
		}
	
		// Constructors
		protected BaseCloth(); // 0x00000001855E0420-0x00000001855E0530
	
		// Methods
		public void ResetCloth(); // 0x000000018C2F6928-0x000000018C2F6958
		public void ResetCloth(float resetStabilizationTime); // 0x000000018C2F68F8-0x000000018C2F6928
		public void ResetCloth(ClothParams.TeleportMode teleportMode, float resetStabilizationTime = -1f /* Metadata: 0x026408DC */); // 0x000000018C2F6958-0x000000018C2F6960
		public void SetTimeScale(float timeScale); // 0x000000018C2F6960-0x000000018C2F69E8
		public float GetTimeScale(); // 0x000000018C2F5F30-0x000000018C2F5FAC
		public void AddForce(Vector3 force, PhysicsManagerTeamData.ForceMode mode); // 0x000000018C2F5504-0x000000018C2F55EC
		public void AddCollider(ColliderComponent collider); // 0x000000018C2F5460-0x000000018C2F5504
		public void RemoveCollider(ColliderComponent collider); // 0x000000018C2F6638-0x000000018C2F66C4
		public void SetUpdateMode(TeamUpdateMode updateMode); // 0x00000001854CCF30-0x00000001854CCF40
		public void SetCullingMode(TeamCullingMode cullingMode); // 0x0000000187233700-0x0000000187233710
		public void Radius_SetRadius(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x026408E0 */); // 0x000000018C2F64AC-0x000000018C2F6638
		public void Mass_SetMass(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x026408E4 */); // 0x000000018C2F61B4-0x000000018C2F6350
		public void ClampPosition_SetPositionLength(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x026408E8 */); // 0x000000018C2F5678-0x000000018C2F5828
		public void Gravity_SetGravity(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x026408EC */); // 0x000000018C2F6028-0x000000018C2F6104
		public void Drag_SetDrag(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x026408F0 */); // 0x000000018C2F5A10-0x000000018C2F5AEC
		public void ExternalForce_DepthInfluence(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x026408F4 */); // 0x000000018C2F5BF0-0x000000018C2F5CC8
		public void WorldInfluence_SetMovementInfluence(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x026408F8 */); // 0x000000018C2F6BF0-0x000000018C2F6CF0
		public void WorldInfluence_SetRotationInfluence(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x026408FC */); // 0x000000018C2F6CF0-0x000000018C2F6DF0
		public void WorldInfluence_ReplaceInfluenceTarget(Transform target); // 0x000000018C2F6AA8-0x000000018C2F6BF0
		public void Penetration_SetMovingRadius(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x02640900 */); // 0x000000018C2F6398-0x000000018C2F64AC
		public override int GetDataHash(); // 0x000000018C2F5E64-0x000000018C2F5F30
		protected virtual void Reset(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnValidate(); // 0x000000018C2F6350-0x000000018C2F6398
		protected override void OnInit(); // 0x00000001853C8CE0-0x00000001853C8D00
		protected override void OnActive(); // 0x00000001853CA370-0x00000001853CA490
		protected override void OnInactive(); // 0x00000001853CA230-0x00000001853CA340
		protected override void OnDispose(); // 0x0000000185D96C00-0x0000000185D96C20
		internal override void UpdateCullingMode(CoreComponent caller); // 0x00000001853CC6E0-0x00000001853CCA80
		protected override void OnChangeCalculation(); // 0x00000001853C8B70-0x00000001853C8C30
		public int GetCullRenderListCount(); // 0x000000018C2F5D44-0x000000018C2F5E64
		private void BaseClothInit(); // 0x00000001853C9970-0x00000001853C9A10
		private void BaseClothDispose(); // 0x0000000185D96CA0-0x0000000185D96D30
		protected virtual void ClothInit(); // 0x0000000185223A90-0x0000000185223B60
		protected virtual void ClothActive(); // 0x00000001853C9A10-0x00000001853C9AA0
		protected virtual void ClothInactive(); // 0x00000001853CA340-0x00000001853CA370
		protected virtual void ClothDispose(); // 0x0000000186805BA0-0x0000000186805BB0
		protected abstract uint UserFlag(int vindex);
		protected abstract Transform UserTransform(int vindex);
		protected abstract float3 UserTransformLocalPosition(int vindex);
		protected abstract quaternion UserTransformLocalRotation(int vindex);
		public abstract bool IsRequiresDeformer();
		public abstract BaseMeshDeformer GetDeformer();
		protected abstract MeshData GetMeshData();
		protected abstract void WorkerInit();
		private void SetUseMesh(bool sw); // 0x00000001853CCA80-0x00000001853CCAE0
		private void SetUseVertex(bool sw); // 0x00000001853CCAE0-0x00000001853CCB30
		protected abstract void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer);
		internal void DeformerForEach(Action<BaseMeshDeformer> act); // 0x000000018C2F59D4-0x000000018C2F5A10
		public void UpdateBlend(); // 0x00000001853C9AA0-0x00000001853C9D10
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict);
		public override HashSet<Transform> GetUsedBones(); // 0x000000018C2F5FAC-0x000000018C2F6028
		protected override void ChangeUseUnityPhysics(bool sw); // 0x000000018C2F55EC-0x000000018C2F5678
		public override void CreateVerifyData(); // 0x000000018C2F5828-0x000000018C2F59D4
		public override Define.Error VerifyData(); // 0x00000001866403B0-0x0000000186640580
		public bool HasChangedParam(ClothParams.ParamType ptype); // 0x000000018C2F6104-0x000000018C2F61B4
		public Define.Error VerifyAlgorithmVersion(); // 0x000000018C2F6A20-0x000000018C2F6AA8
		public override bool UpgradeFormat(); // 0x000000018C2F69E8-0x000000018C2F6A20
		public override List<ShareDataObject> GetAllShareDataObject(); // 0x000000018C2F5CC8-0x000000018C2F5D44
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source); // 0x000000018C2F5AEC-0x000000018C2F5BF0
		private void ResetClothInternal(ClothParams.TeleportMode teleportMode, float resetStabilizationTime); // 0x000000018C2F66C4-0x000000018C2F68F8
	}

	public abstract class CoreComponent : BaseComponent, IShareDataObject, IDataVerify, IEditorMesh, IEditorCloth, IDataHash, IBoneReplace // TypeDefIndex: 82032
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
		public RuntimeStatus Status { get; } // 0x000000018225E800-0x000000018225E810 
		public bool IsVisible { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018225E0B0-0x000000018225E0C0 0x000000018225E0C0-0x000000018225E0D0
		public bool IsCalculate { get; } // 0x00000001853C8CD0-0x00000001853C8CE0 
		public int SaveDataHash { get; } // 0x00000001844AF510-0x00000001844AF520 
		public int SaveDataVersion { get; } // 0x0000000187233000-0x0000000187233010 
	
		// Constructors
		protected CoreComponent(); // 0x00000001855E05B0-0x00000001855E0620
	
		// Methods
		public Dictionary<string, Transform> GetUsedComponentBones(); // 0x000000018C31B000-0x000000018C31B2C8
		public List<string> GetUsedComponentBoneNames(); // 0x000000018C31AF64-0x000000018C31B000
		public void ReplaceComponentBone(Dictionary<Transform, Transform> boneReplaceDict); // 0x000000018C31B33C-0x000000018C31B384
		public void ReplaceComponentBone(Dictionary<string, Transform> boneReplaceDict); // 0x000000018C31B2F4-0x000000018C31B33C
		public abstract int GetDataHash();
		protected virtual void Start(); // 0x0000000186E4C680-0x0000000186E4C690
		public virtual void OnEnable(); // 0x00000001853CB200-0x00000001853CB230
		public virtual void OnDisable(); // 0x00000001853CB230-0x00000001853CB260
		protected virtual void OnDestroy(); // 0x0000000186855710-0x0000000186855790
		public void Init(); // 0x00000001853CA920-0x00000001853CAAD0
		protected abstract void OnInit();
		protected abstract void OnDispose();
		protected abstract void OnUpdate();
		protected abstract void OnActive();
		protected abstract void OnInactive();
		protected virtual void OnUpdateStatus(); // 0x00000001853CCB50-0x00000001853CCBC0
		protected virtual void OnDisconnectedStatus(); // 0x000000018C31B2EC-0x000000018C31B2F4
		public void SetUseUnityPhysics(bool sw); // 0x000000018C31B384-0x000000018C31B3EC
		private void ActiveUseUnityPhysics(); // 0x0000000186C42F80-0x0000000186C42FA0
		private void InactiveUseUnityPhysics(); // 0x0000000186D31DA0-0x0000000186D31DC0
		protected virtual void ChangeUseUnityPhysics(bool sw); // 0x0000000186805BA0-0x0000000186805BB0
		protected bool IsUseUnityPhysics(); // 0x000000018B8A5F60-0x000000018B8A5F68
		public virtual List<ShareDataObject> GetAllShareDataObject(); // 0x000000018C31AD60-0x000000018C31ADC0
		public abstract ShareDataObject DuplicateShareDataObject(ShareDataObject source);
		protected void SetUserEnable(bool sw); // 0x00000001853C9E40-0x00000001853C9E80
		internal virtual void UpdateCullingMode(CoreComponent Caller); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnChangeCalculation(); // 0x0000000186805BA0-0x0000000186805BB0
		public abstract int GetVersion();
		public abstract int GetErrorVersion();
		public virtual Define.Error VerifyData(); // 0x0000000186848530-0x00000001868485C0
		public Define.Error VerifyDataVersion(); // 0x000000018C31B3EC-0x000000018C31B428
		public bool IsOldDataVertion(); // 0x000000018C31B2C8-0x000000018C31B2EC
		public virtual void CreateVerifyData(); // 0x000000018C31AD30-0x000000018C31AD60
		public virtual string GetInformation(); // 0x000000018C31AEA4-0x000000018C31AED0
		public virtual bool UpgradeFormat(); // 0x00000001843FFFF0-0x0000000184400000
		public void ChangeAvatar<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class;
		public virtual void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class;
		public virtual HashSet<Transform> GetUsedBones(); // 0x000000018C31AED0-0x000000018C31AF64
		public virtual int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x000000018C31AE0C-0x000000018C31AE58
		public virtual List<int> GetEditorTriangleList(); // 0x000000018C31AE58-0x000000018C31AEA4
		public virtual List<int> GetEditorLineList(); // 0x000000018C31ADC0-0x000000018C31AE0C
		public virtual List<int> GetSelectionList(); // 0x0000000185829EC0-0x0000000185829ED0
		public virtual List<int> GetUseList(); // 0x0000000185829EC0-0x0000000185829ED0
		[CompilerGenerated]
		private object _Init_b__27_0(); // 0x0000000185BD80B0-0x0000000185BD80C0
	}

	[Serializable]
	public class AvatarPartsAttachEvent : UnityEvent<MagicaCloth.MagicaAvatar, MagicaCloth.MagicaAvatarParts> // TypeDefIndex: 82033
	{
		// Constructors
		public AvatarPartsAttachEvent(); // 0x000000018C30E2C4-0x000000018C30E300
	}

	[Serializable]
	public class AvatarPartsDetachEvent : UnityEvent<MagicaCloth.MagicaAvatar> // TypeDefIndex: 82034
	{
		// Constructors
		public AvatarPartsDetachEvent(); // 0x000000018C30E300-0x000000018C30E33C
	}

	[Serializable]
	public class PhysicsManagerPreUpdateEvent : UnityEvent // TypeDefIndex: 82035
	{
		// Constructors
		public PhysicsManagerPreUpdateEvent(); // 0x000000018548D960-0x000000018548D970
	}

	[Serializable]
	public class PhysicsManagerPostUpdateEvent : UnityEvent // TypeDefIndex: 82036
	{
		// Constructors
		public PhysicsManagerPostUpdateEvent(); // 0x000000018548D960-0x000000018548D970
	}

	[AddComponentMenu("MagicaCloth/MagicaAreaWind")]
	public class MagicaAreaWind : WindComponent // TypeDefIndex: 82037
	{
		// Fields
		[SerializeField]
		private PhysicsManagerWindData.ShapeType shapeType; // 0x58
		[SerializeField]
		private bool isAddition; // 0x5C
	
		// Properties
		public PhysicsManagerWindData.ShapeType ShapeType { get; set; } // 0x00000001872331A0-0x00000001872331B0 0x000000018C31B64C-0x000000018C31B66C
		public bool Addition { get; set; } // 0x000000018225DF90-0x000000018225DFA0 0x000000018C31B62C-0x000000018C31B64C
	
		// Constructors
		public MagicaAreaWind(); // 0x000000018C31B624-0x000000018C31B62C
	
		// Methods
		public override ComponentType GetComponentType(); // 0x0000000187250F50-0x0000000187250F60
		public override PhysicsManagerWindData.WindType GetWindType(); // 0x00000001845AFFB0-0x00000001845AFFC0
		public override PhysicsManagerWindData.ShapeType GetShapeType(); // 0x00000001872331A0-0x00000001872331B0
		public override PhysicsManagerWindData.DirectionType GetDirectionType(); // 0x000000018C31B5B4-0x000000018C31B5C4
		public override bool IsAddition(); // 0x000000018225DF90-0x000000018225DFA0
		public override Vector3 GetAreaSize(); // 0x000000018C31B474-0x000000018C31B50C
		public override float GetAreaVolume(); // 0x000000018C31B50C-0x000000018C31B5B4
		public override float GetAreaLength(); // 0x000000018C31B428-0x000000018C31B474
		protected override void ResetParams(); // 0x000000018C31B5C4-0x000000018C31B624
	}

	[AddComponentMenu("MagicaCloth/MagicaAvatar")]
	[HelpURL("https://magicasoft.jp/avatar/")]
	public class MagicaAvatar : CoreComponent // TypeDefIndex: 82038
	{
		// Fields
		private const int DATA_VERSION = 1; // Metadata: 0x02640904
		[SerializeField]
		private bool dataReset; // 0x38
		private MagicaAvatarRuntime runtime; // 0x40
		public AvatarPartsAttachEvent OnAttachParts; // 0x48
		public AvatarPartsDetachEvent OnDetachParts; // 0x50
	
		// Properties
		public bool DataReset { get; set; } // 0x000000018225E070-0x000000018225E080 0x000000018225E080-0x000000018225E090
		public MagicaAvatarRuntime Runtime { get; } // 0x000000018C31EC30-0x000000018C31EC5C 
	
		// Constructors
		public MagicaAvatar(); // 0x000000018C31EB50-0x000000018C31EC30
	
		// Methods
		public int AttachAvatarParts(GameObject avatarPartsPrefab, Action<GameObject> instanceAction = null); // 0x000000018C31E264-0x000000018C31E32C
		public void DetachAvatarParts(int partsId); // 0x000000018C31E364-0x000000018C31E390
		public void DetachAvatarParts(GameObject avatarPartsObject); // 0x000000018C31E390-0x000000018C31E400
		public void DetachAvatarParts(MagicaAvatarParts parts); // 0x000000018C31E334-0x000000018C31E364
		public override ComponentType GetComponentType(); // 0x0000000187250F70-0x0000000187250F80
		public override int GetDataHash(); // 0x0000000185829EC0-0x0000000185829ED0
		private void Reset(); // 0x000000018723F910-0x000000018723F920
		private void OnValidate(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void OnInit(); // 0x000000018C31EAB0-0x000000018C31EAD8
		protected override void OnDispose(); // 0x000000018C31EA60-0x000000018C31EA88
		protected override void OnUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void OnActive(); // 0x000000018C31EA38-0x000000018C31EA60
		protected override void OnInactive(); // 0x000000018C31EA88-0x000000018C31EAB0
		public override int GetVersion(); // 0x00000001872328C0-0x00000001872328D0
		public override int GetErrorVersion(); // 0x0000000185829EC0-0x0000000185829ED0
		public override void CreateVerifyData(); // 0x000000018C31E32C-0x000000018C31E334
		public override Define.Error VerifyData(); // 0x000000018C31EAD8-0x000000018C31EB50
		public override string GetInformation(); // 0x000000018C31E408-0x000000018C31EA38
		public override List<ShareDataObject> GetAllShareDataObject(); // 0x000000018C31E400-0x000000018C31E408
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source); // 0x0000000185829EC0-0x0000000185829ED0
	}

	[AddComponentMenu("MagicaCloth/MagicaDirectionalWind")]
	[HelpURL("https://magicasoft.jp/directional-wind/")]
	public class MagicaDirectionalWind : WindComponent // TypeDefIndex: 82039
	{
		// Constructors
		public MagicaDirectionalWind(); // 0x000000018C31B624-0x000000018C31B62C
	
		// Methods
		public override ComponentType GetComponentType(); // 0x0000000187250FC0-0x0000000187250FD0
		public override PhysicsManagerWindData.WindType GetWindType(); // 0x00000001872328C0-0x00000001872328D0
		public override PhysicsManagerWindData.ShapeType GetShapeType(); // 0x0000000185829EC0-0x0000000185829ED0
		public override PhysicsManagerWindData.DirectionType GetDirectionType(); // 0x0000000185829EC0-0x0000000185829ED0
		public override bool IsAddition(); // 0x00000001843FFFF0-0x0000000184400000
		public override Vector3 GetAreaSize(); // 0x0000000187250F90-0x0000000187250FB0
		public override float GetAreaVolume(); // 0x0000000187250FB0-0x0000000187250FC0
		public override float GetAreaLength(); // 0x0000000187250F80-0x0000000187250F90
		protected override void ResetParams(); // 0x000000018C31EC5C-0x000000018C31ECBC
	}

	[HelpURL("https://magicasoft.jp/magica-cloth-physics-manager/")]
	public class MagicaPhysicsManager : CreateSingleton<MagicaCloth.MagicaPhysicsManager> // TypeDefIndex: 82042
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
		public UpdateTimeManager.UpdateCount UpdatePerSeccond { get; set; } // 0x000000018C31F044-0x000000018C31F060 0x000000018C31F0AC-0x000000018C31F0C8
		public UpdateTimeManager.UpdateMode UpdateMode { get; set; } // 0x000000018C31F028-0x000000018C31F044 0x000000018C31F090-0x000000018C31F0AC
		public float FuturePredictionRate { get; set; } // 0x000000018C31EE90-0x000000018C31EEB0 0x000000018C31F060-0x000000018C31F088
		public UpdateTimeManager UpdateTime { get; } // 0x0000000182234E30-0x0000000182234E40 
		public PhysicsManagerParticleData Particle { get; } // 0x0000000185155400-0x0000000185155490 
		public PhysicsManagerBoneData Bone { get; } // 0x0000000185153860-0x00000001851538F0 
		public PhysicsManagerMeshData Mesh { get; } // 0x0000000185154C00-0x0000000185154C90 
		public PhysicsManagerTeamData Team { get; } // 0x0000000185155490-0x0000000185155520 
		public PhysicsManagerWindData Wind { get; } // 0x0000000185220290-0x00000001852202C0 
		public PhysicsManagerComponent Component { get; } // 0x0000000185156F10-0x0000000185156F40 
		public PhysicsManagerCompute Compute { get; } // 0x0000000185155370-0x0000000185155400 
		public bool IsDelay { get; } // 0x000000018226EFA0-0x000000018226EFB0 
		public bool IsActive { get; set; } // 0x0000000187235DA0-0x0000000187235DB0 0x000000018C31F088-0x000000018C31F090
		public bool IsFasterWrite { get; } // 0x000000018C31EEB0-0x000000018C31EF64 
		internal ComputeShader MeshWriterShader { get; } // 0x000000018C31EF64-0x000000018C31F028 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 82040
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
			static __c(); // 0x00000001871E60E0-0x00000001871E6140
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _SetCustomGameLoop_b__69_11(); // 0x0000000185153230-0x0000000185153290
			internal void _SetCustomGameLoop_b__69_12(); // 0x00000001851538F0-0x0000000185153A20
			internal void _SetCustomGameLoop_b__69_13(); // 0x0000000185152FC0-0x00000001851530E0
			internal void _SetCustomGameLoop_b__69_14(); // 0x00000001851530E0-0x0000000185153130
			internal void _SetCustomGameLoop_b__69_15(); // 0x0000000185153130-0x0000000185153180
			internal void _SetCustomGameLoop_b__69_16(); // 0x0000000185153180-0x00000001851531D0
			internal void _SetCustomGameLoop_b__69_17(); // 0x00000001851531D0-0x0000000185153230
			internal bool _SetCustomGameLoop_b__69_0(PlayerLoopSystem s); // 0x0000000186672640-0x00000001866726A0
			internal bool _SetCustomGameLoop_b__69_1(PlayerLoopSystem s); // 0x0000000186672530-0x0000000186672590
			internal bool _SetCustomGameLoop_b__69_2(PlayerLoopSystem h); // 0x00000001866724C0-0x0000000186672530
			internal bool _SetCustomGameLoop_b__69_3(PlayerLoopSystem s); // 0x0000000186672460-0x00000001866724C0
			internal bool _SetCustomGameLoop_b__69_4(PlayerLoopSystem h); // 0x00000001866726A0-0x0000000186672710
			internal bool _SetCustomGameLoop_b__69_5(PlayerLoopSystem s); // 0x0000000186672400-0x0000000186672460
			internal bool _SetCustomGameLoop_b__69_6(PlayerLoopSystem h); // 0x00000001866722D0-0x0000000186672340
			internal bool _SetCustomGameLoop_b__69_7(PlayerLoopSystem s); // 0x00000001866723A0-0x0000000186672400
			internal bool _SetCustomGameLoop_b__69_8(PlayerLoopSystem h); // 0x0000000186672590-0x0000000186672600
			internal bool _SetCustomGameLoop_b__69_9(PlayerLoopSystem s); // 0x0000000186672340-0x00000001866723A0
			internal bool _SetCustomGameLoop_b__69_10(PlayerLoopSystem h); // 0x0000000186AEFD80-0x0000000186AEFDF0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass70_0 // TypeDefIndex: 82041
		{
			// Fields
			public System.Type t; // 0x10
			public Func<PlayerLoopSystem, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass70_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _CheckRegist_b__0(PlayerLoopSystem x); // 0x00000001869AE2A0-0x00000001869AE2E0
		}
	
		// Constructors
		public MagicaPhysicsManager(); // 0x0000000186BA1860-0x0000000186BA1AF0
	
		// Methods
		public void SetGlobalTimeScale(float timeScale); // 0x000000018C31EE64-0x000000018C31EE90
		public float GetGlobalTimeScale(); // 0x0000000185221910-0x0000000185221930
		protected override void Awake(); // 0x0000000187216E20-0x0000000187216E60
		protected override void InitSingleton(); // 0x0000000186FA54F0-0x0000000186FA55D0
		protected override void DuplicateDetection(MagicaPhysicsManager duplicate); // 0x000000018C31ECBC-0x000000018C31ED28
		protected void OnEnable(); // 0x0000000187231420-0x0000000187231440
		protected void OnDisable(); // 0x000000018C31EE30-0x000000018C31EE64
		private void Update(); // 0x0000000186320FE0-0x0000000186321010
		private void FixedUpdate(); // 0x00000001861585A0-0x00000001861585D0
		protected override void OnDestroy(); // 0x000000018C31ED28-0x000000018C31EE30
		private void AfterEarlyUpdate(); // 0x0000000185156F40-0x0000000185156F80
		private void AfterFixedUpdate(); // 0x0000000185153AB0-0x0000000185153BA0
		private void AfterUpdate(); // 0x0000000185156E20-0x0000000185156F10
		private void BeforeLateUpdate(); // 0x0000000185152BE0-0x0000000185152C10
		private void AfterLateUpdate(); // 0x0000000185152C10-0x0000000185152C40
		private void DefaultUpdate(); // 0x0000000185154C90-0x0000000185155370
		private void PostLateUpdate(); // 0x0000000185152C70-0x0000000185152C90
		private void AfterRendering(); // 0x0000000185152C40-0x0000000185152C70
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Init(); // 0x0000000187222960-0x0000000187222990
		[RuntimeInitializeOnLoadMethod]
		public static void InitCustomGameLoop(); // 0x0000000186321010-0x00000001863210B0
		public static void SetCustomGameLoop(ref PlayerLoopSystem playerLoop); // 0x0000000185BBCD50-0x0000000185BBE6E0
		private static bool CheckRegist(ref PlayerLoopSystem playerLoop); // 0x0000000185BBB3F0-0x0000000185BBB590
	}

	public abstract class WindComponent : BaseComponent // TypeDefIndex: 82043
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
		public float Main { get; set; } // 0x0000000187233050-0x0000000187233060 0x000000018C320520-0x000000018C320560
		public float Turbulence { get; set; } // 0x0000000187233410-0x0000000187233420 0x000000018C320560-0x000000018C32058C
		public float Frequency { get; set; } // 0x00000001872332C0-0x00000001872332D0 0x000000018C320440-0x000000018C32046C
		public Vector3 MainDirection { get; set; } // 0x000000018C32026C-0x000000018C3202F0 0x000000018C32046C-0x000000018C320520
		public float DirectionAngleX { get; set; } // 0x000000018723CEF0-0x000000018723CF00 0x000000018C3203D8-0x000000018C3203FC
		public float DirectionAngleY { get; set; } // 0x0000000187235380-0x0000000187235390 0x000000018C3203FC-0x000000018C320420
		public Vector3 AreaSize { get; set; } // 0x000000018723E4F0-0x000000018723E510 0x000000018C320324-0x000000018C3203D8
		public float AreaRadius { get; set; } // 0x0000000187233870-0x0000000187233880 0x000000018C3202F0-0x000000018C320324
		public PhysicsManagerWindData.DirectionType DirectionType { get; set; } // 0x000000018226F000-0x000000018226F010 0x000000018C320420-0x000000018C320440
		internal RuntimeStatus Status { get; } // 0x000000018226EBD0-0x000000018226EBE0 
	
		// Constructors
		protected WindComponent(); // 0x000000018C320188-0x000000018C32026C
	
		// Methods
		public void SetAttenuation(float sval, float eval, bool useEval = true /* Metadata: 0x02640905 */, float cval = 0f /* Metadata: 0x02640906 */, bool useCval = false /* Metadata: 0x0264090A */); // 0x000000018C3200D4-0x000000018C32011C
		protected virtual void Reset(); // 0x000000018C3200C4-0x000000018C3200D4
		protected virtual void OnValidate(); // 0x000000018C31FF60-0x000000018C32003C
		private void OnDidApplyAnimationProperties(); // 0x000000018C31FDC0-0x000000018C31FDF0
		protected virtual void Start(); // 0x000000018C32011C-0x000000018C320124
		internal virtual void OnEnable(); // 0x000000018C31FE74-0x000000018C31FEAC
		internal virtual void OnDisable(); // 0x000000018C31FDF0-0x000000018C31FE28
		protected virtual void OnDestroy(); // 0x000000018C31FD94-0x000000018C31FDC0
		protected virtual void Update(); // 0x000000018C320124-0x000000018C320188
		private void Init(); // 0x000000018C31FC40-0x000000018C31FD8C
		protected void OnUpdateStatus(); // 0x000000018C31FEF4-0x000000018C31FF30
		internal virtual bool VerifyData(); // 0x00000001851A4410-0x00000001851A4420
		protected virtual void OnInit(); // 0x000000018C31FEB4-0x000000018C31FEF4
		protected virtual void OnDispose(); // 0x000000018C31FE28-0x000000018C31FE74
		protected virtual void OnUpdate(); // 0x000000018C31FF30-0x000000018C31FF60
		protected virtual void OnActive(); // 0x000000018C31FD8C-0x000000018C31FD94
		protected virtual void OnInactive(); // 0x000000018C31FEAC-0x000000018C31FEB4
		protected void EnableWind(); // 0x000000018C31FB34-0x000000018C31FBC8
		protected void DisableWind(); // 0x000000018C31FA84-0x000000018C31FB34
		private void RemoveWind(); // 0x000000018C32003C-0x000000018C3200C4
		private void CreateWind(); // 0x000000018C31F858-0x000000018C31FA84
		internal Vector3 GetLocalDirection(); // 0x000000018C31FBC8-0x000000018C31FC40
		private void ChangeParameter(); // 0x000000018C31F66C-0x000000018C31F858
		public abstract PhysicsManagerWindData.WindType GetWindType();
		public abstract PhysicsManagerWindData.ShapeType GetShapeType();
		public abstract PhysicsManagerWindData.DirectionType GetDirectionType();
		public abstract bool IsAddition();
		public abstract Vector3 GetAreaSize();
		public abstract float GetAreaVolume();
		public abstract float GetAreaLength();
		protected abstract void ResetParams();
		[CompilerGenerated]
		private object _Init_b__49_0(); // 0x0000000185BD80B0-0x0000000185BD80C0
	}

	public abstract class MagicaAvatarAccess : IDisposable // TypeDefIndex: 82044
	{
		// Fields
		protected MagicaAvatar owner; // 0x10
	
		// Properties
		protected MagicaAvatarRuntime Runtime { get; } // 0x000000018C31B66C-0x000000018C31B68C 
	
		// Constructors
		protected MagicaAvatarAccess(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void SetParent(MagicaAvatar avatar); // 0x0000000184FD2410-0x0000000184FD2420
		public abstract void Create();
		public abstract void Dispose();
		public abstract void Active();
		public abstract void Inactive();
	}

	[AddComponentMenu("MagicaCloth/MagicaAvatarParts")]
	[HelpURL("https://magicasoft.jp/avatar-parts/")]
	public class MagicaAvatarParts : BaseComponent, IDataVerify // TypeDefIndex: 82045
	{
		// Fields
		private MagicaAvatar parentAvatar; // 0x18
		private Dictionary<string, Transform> boneDict; // 0x20
		private List<CoreComponent> magicaComponentList; // 0x28
	
		// Properties
		public MagicaAvatar ParentAvatar { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public bool HasParent { get; } // 0x000000018C31C15C-0x000000018C31C1AC 
		public int PartsId { get; } // 0x000000018C31C1AC-0x000000018C31C1B4 
	
		// Constructors
		public MagicaAvatarParts(); // 0x000000018C31C0DC-0x000000018C31C15C
	
		// Methods
		public override ComponentType GetComponentType(); // 0x0000000187250F60-0x0000000187250F70
		private void OnDestroy(); // 0x000000018C31C06C-0x000000018C31C074
		public void Dispose(); // 0x000000018C31B8B4-0x000000018C31B944
		public List<Transform> CheckOverlappingTransform(); // 0x000000018C31B68C-0x000000018C31B868
		public Dictionary<string, Transform> GetBoneDict(); // 0x000000018C31B944-0x000000018C31BB04
		public List<CoreComponent> GetMagicaComponentList(); // 0x000000018C31BFC0-0x000000018C31C06C
		public int GetVersion(); // 0x00000001872328C0-0x00000001872328D0
		public void CreateVerifyData(); // 0x000000018C31B868-0x000000018C31B8B4
		public Define.Error VerifyData(); // 0x000000018C31C074-0x000000018C31C0DC
		public string GetInformation(); // 0x000000018C31BB04-0x000000018C31BFC0
	}

	public class MagicaAvatarRuntime : MagicaAvatarAccess // TypeDefIndex: 82047
	{
		// Fields
		private Dictionary<string, Transform> boneDict; // 0x18
		private Dictionary<Transform, int> boneReferenceDict; // 0x20
		private List<MagicaAvatarParts> avatarPartsList; // 0x28
		private List<ColliderComponent> colliderList; // 0x30
	
		// Properties
		public int AvatarPartsCount { get; } // 0x000000018C31E224-0x000000018C31E264 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 82046
		{
			// Fields
			public int partsId; // 0x10
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _RemoveAvatarParts_b__0(MagicaAvatarParts p); // 0x000000018C31F4B0-0x000000018C31F4E0
		}
	
		// Constructors
		public MagicaAvatarRuntime(); // 0x000000018C31E0CC-0x000000018C31E224
	
		// Methods
		public override void Create(); // 0x000000018C31D528-0x000000018C31D548
		public override void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void Active(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void Inactive(); // 0x0000000186805BA0-0x0000000186805BB0
		public MagicaAvatarParts GetAvatarParts(int index); // 0x000000018C31D548-0x000000018C31D59C
		private void CreateBoneDict(); // 0x000000018C31D308-0x000000018C31D4B0
		private void CreateColliderList(); // 0x000000018C31D4B0-0x000000018C31D528
		public int GetColliderCount(); // 0x000000018C31D59C-0x000000018C31D608
		public List<Transform> CheckOverlappingTransform(); // 0x000000018C31D118-0x000000018C31D308
		public int AddAvatarParts(MagicaAvatarParts parts); // 0x000000018C31C1B4-0x000000018C31CE4C
		private void AddBone(Transform root, Transform croot, Transform bone); // 0x000000018C31CE4C-0x000000018C31D118
		private void ReplaceSkinMeshRenderer(SkinnedMeshRenderer skinRenderer, Dictionary<Transform, Transform> boneReplaceDict); // 0x000000018C31DFD8-0x000000018C31E0CC
		private void ReplaceMagicaComponent(CoreComponent comp, Dictionary<Transform, Transform> boneReplaceDict); // 0x000000018C31DF84-0x000000018C31DFD8
		public void RemoveAvatarParts(MagicaAvatarParts parts); // 0x000000018C31D608-0x000000018C31DEA8
		public void RemoveAvatarParts(int partsId); // 0x000000018C31DEA8-0x000000018C31DF84
	}

	[Serializable]
	public class BoneClothTarget : IDataHash, IBoneReplace // TypeDefIndex: 82049
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
		public int RootCount { get; } // 0x000000018C30E644-0x000000018C30E684 
		public ConnectionMode Connection { get; } // 0x00000001844AF510-0x00000001844AF520 
		public float SameSurfaceAngle { get; } // 0x0000000187233410-0x0000000187233420 
		public bool IsMeshConnection { get; } // 0x000000018C30E62C-0x000000018C30E644 
	
		// Nested types
		public enum ConnectionMode // TypeDefIndex: 82048
		{
			Line = 0,
			MeshAutomatic = 1,
			MeshSequentialLoop = 2,
			MeshSequentialNoLoop = 3
		}
	
		// Constructors
		public BoneClothTarget(); // 0x00000001855E03C0-0x00000001855E0420
	
		// Methods
		public int GetDataHash(); // 0x000000018C30E404-0x000000018C30E440
		public Transform GetRoot(int index); // 0x000000018C30E494-0x000000018C30E500
		public int GetRootIndex(Transform root); // 0x000000018C30E440-0x000000018C30E494
		public void AddParentTransform(); // 0x0000000185223FE0-0x00000001852244A0
		public void RemoveParentTransform(); // 0x00000001867F6560-0x00000001867F6630
		public void ResetFuturePredictionParentTransform(); // 0x000000018C30E574-0x000000018C30E62C
		public void ChangeUnityPhysicsCount(bool sw); // 0x000000018C30E33C-0x000000018C30E404
		public void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class;
		public HashSet<Transform> GetUsedBones(); // 0x000000018C30E500-0x000000018C30E574
	}

	[Serializable]
	public class ClothData : ShareDataObject // TypeDefIndex: 82058
	{
		// Fields
		private const int DATA_VERSION = 5; // Metadata: 0x0264090F
		public const uint VertexFlag_End = 65536; // Metadata: 0x02640910
		public const uint VertexFlag_TriangleRotation = 131072; // Metadata: 0x02640914
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
		public int VertexUseCount { get; } // 0x00000001852234A0-0x00000001852234C0 
		public int StructDistanceConstraintCount { get; } // 0x00000001852233D0-0x00000001852233F0 
		public int BendDistanceConstraintCount { get; } // 0x000000018C319EF0-0x000000018C319F04 
		public int NearDistanceConstraintCount { get; } // 0x000000018C319F7C-0x000000018C319F94 
		public int ClampDistanceConstraintCount { get; } // 0x00000001852233B0-0x00000001852233D0 
		public int ClampDistance2ConstraintCount { get; } // 0x000000018C319F04-0x000000018C319F1C 
		public int RestoreRotationConstraintCount { get; } // 0x000000018C319FCC-0x000000018C319FE4 
		public int ClampRotationConstraintDataCount { get; } // 0x000000018C319F1C-0x000000018C319F34 
		public int ClampRotationConstraintRootCount { get; } // 0x000000018C319F34-0x000000018C319F4C 
		public int AdjustRotationConstraintCount { get; } // 0x000000018C319EC0-0x000000018C319ED8 
		public int CompositeRotationCount { get; } // 0x0000000185223390-0x00000001852233B0 
		public int TwistConstraintCount { get; } // 0x0000000185223370-0x0000000185223390 
		public int TriangleBendConstraintCount { get; } // 0x0000000186EA8340-0x0000000186EA8360 
		public int EdgeCollisionConstraintCount { get; } // 0x000000018C319F4C-0x000000018C319F64 
		public int VolumeConstraintCount { get; } // 0x000000018C319FFC-0x000000018C31A014 
		public int LineRotationWorkerCount { get; } // 0x000000018C319F64-0x000000018C319F7C 
		public int TriangleRotationWorkerCount { get; } // 0x000000018C319FE4-0x000000018C319FFC 
		public int PenetrationCount { get; } // 0x000000018C319F94-0x000000018C319FCC 
		public int BaseSkinningCount { get; } // 0x000000018C319ED8-0x000000018C319EF0 
	
		// Nested types
		private class RestoreDistanceWork // TypeDefIndex: 82050
		{
			// Fields
			public uint vertexPair; // 0x10
			public float dist; // 0x14
	
			// Constructors
			public RestoreDistanceWork(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private class PenetrationBone // TypeDefIndex: 82051
		{
			// Fields
			public Transform bone; // 0x10
			public Transform childBone; // 0x18
	
			// Constructors
			public PenetrationBone(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private class PenetrationWork // TypeDefIndex: 82052
		{
			// Fields
			public Transform bone; // 0x10
			public Transform childBone; // 0x18
			public int boneIndex; // 0x20
			public float distance; // 0x24
			public float weight; // 0x28
	
			// Constructors
			public PenetrationWork(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private class VertexInfo // TypeDefIndex: 82053
		{
			// Fields
			public int vertexIndex; // 0x10
			public int parentVertexIndex; // 0x14
			public List<int> childVertexList; // 0x18
			public VertexInfo parentInfo; // 0x20
			public List<VertexInfo> childInfoList; // 0x28
	
			// Constructors
			public VertexInfo(); // 0x000000018C31F5A8-0x000000018C31F66C
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 82054
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<RestoreDistanceWork> __9__108_0; // 0x08
			public static Comparison<RestoreDistanceWork> __9__108_1; // 0x10
			public static Comparison<PenetrationConstraint.PenetrationData> __9__108_2; // 0x18
	
			// Constructors
			static __c(); // 0x000000018C31F544-0x000000018C31F5A8
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _CreateConstraintData_b__108_0(RestoreDistanceWork a, RestoreDistanceWork b); // 0x000000018C31F0C8-0x000000018C31F0F8
			internal int _CreateConstraintData_b__108_1(RestoreDistanceWork a, RestoreDistanceWork b); // 0x000000018C31F0C8-0x000000018C31F0F8
			internal int _CreateConstraintData_b__108_2(PenetrationConstraint.PenetrationData a, PenetrationConstraint.PenetrationData b); // 0x000000018C31F0F8-0x000000018C31F110
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass110_0 // TypeDefIndex: 82055
		{
			// Fields
			public List<float> meshVertexDepthList; // 0x10
	
			// Constructors
			public __c__DisplayClass110_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _SortTetra_b__0(int a, int b); // 0x000000018C31F15C-0x000000018C31F1F8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass111_0 // TypeDefIndex: 82056
		{
			// Fields
			public List<float> meshVertexDepthList; // 0x10
	
			// Constructors
			public __c__DisplayClass111_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _CheckTetraDirection_b__0(ulong a, ulong b); // 0x000000018C31F1F8-0x000000018C31F3A4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass114_0 // TypeDefIndex: 82057
		{
			// Fields
			public List<float> depthList; // 0x10
			public List<float> nearFixedDistList; // 0x18
	
			// Constructors
			public __c__DisplayClass114_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetUseParentVertexList_b__0(int a, int b); // 0x000000018C31F3A4-0x000000018C31F4B0
		}
	
		// Constructors
		public ClothData(); // 0x00000001866F1F10-0x00000001866F2070
	
		// Methods
		public override int GetDataHash(); // 0x000000018C317994-0x000000018C317E44
		public int GetClampRotationCount(); // 0x000000018C317958-0x000000018C317994
		public int GetRestoreRotationCount(); // 0x000000018C317FB4-0x000000018C317FF0
		public bool IsInvalidVertex(int vindex); // 0x000000018C31967C-0x000000018C3196D4
		public bool IsFixedVertex(int vindex); // 0x00000001853CE440-0x00000001853CE470
		public bool IsMoveVertex(int vindex); // 0x000000018C3196E4-0x000000018C319740
		public bool IsExtendVertex(int vindex); // 0x00000001853CDCC0-0x00000001853CDCF0
		public bool IsLastLevel(int vindex); // 0x000000018C3196D4-0x000000018C3196E4
		public bool IsFlag(int vindex, uint flag); // 0x00000001853CE380-0x00000001853CE3C0
		public void SetFlag(int vindex, uint flag); // 0x000000018C319CBC-0x000000018C319D40
		public int GetLevel(int vindex); // 0x000000018C317E44-0x000000018C317E9C
		public override int GetVersion(); // 0x0000000187239C70-0x0000000187239C80
		public override Define.Error VerifyData(); // 0x00000001852233F0-0x00000001852234A0
		public void CreateData(PhysicsTeam team, ClothParams clothParams, PhysicsTeamData teamData, MeshData meshData, IEditorMesh editMesh, List<int> selData, Action<List<int>, List<int>, List<Vector3>, List<Vector3>, List<Vector3>, List<int>, List<int>> extensionAction = null); // 0x000000018C317010-0x000000018C317264
		private void CreateVertexData(int vertexCount, List<int> lineList, List<int> triangleList); // 0x000000018C317264-0x000000018C317958
		private void CreateConstraintData(PhysicsTeam team, ClothParams clothParams, PhysicsTeamData teamData, int vertexCount, List<Vector3> wposList, List<Vector3> wnorList, List<Vector3> wtanList, List<int> lineList, List<int> triangleList); // 0x000000018C30ED90-0x000000018C317010
		private void RegistTriangleBend(int v0, int v1, int v2, int v3, List<Vector3> wposList, ClothParams clothParams, List<TriangleBendConstraint.TriangleBendData> triangleBendData); // 0x000000018C319740-0x000000018C319CBC
		private List<int> SortTetra(int v0, int v1, int v2, int v3, List<float> meshVertexDepthList); // 0x000000018C319D40-0x000000018C319EC0
		private List<int> CheckTetraDirection(int v0, int v1, int v2, int v3, HashSet<ulong> trianglePackSet, List<float> meshVertexDepthList); // 0x000000018C30E94C-0x000000018C30ED90
		private bool CalcTriangleBendRestAngle(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, out float restAngle); // 0x000000018C30E684-0x000000018C30E94C
		private List<float> GetMeshVertexDepthList(int vertexCount, List<float> depthList); // 0x000000018C317E9C-0x000000018C317FB4
		private List<int> GetUseParentVertexList(int vertexCount, List<HashSet<int>> vlink, List<Vector3> wposList, List<float> depthList); // 0x000000018C317FF0-0x000000018C318E84
		private List<int> GetUseRootVertexList(List<int> parentVertexList); // 0x000000018C31939C-0x000000018C319498
		private List<VertexInfo> GetUseVertexInfoList(List<int> parentVertexList); // 0x000000018C319498-0x000000018C31967C
		private List<List<int>> GetUseRootLineList(List<int> parentVertexList); // 0x000000018C318E84-0x000000018C31939C
	}

	[Serializable]
	public class ClothParams // TypeDefIndex: 82065
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
		public Algorithm AlgorithmType { get; set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
		public bool UseGravity { get; } // 0x000000018225DF70-0x000000018225DF80 
		public Vector3 GravityDirection { get; set; } // 0x000000018724C790-0x000000018724C7B0 0x000000018724BD80-0x000000018724BD90
		public bool UseDrag { get; } // 0x000000018226ED80-0x000000018226ED90 
		public bool UseMaxVelocity { get; } // 0x000000018225DFF0-0x000000018225E000 
		public float MassInfluence { get; set; } // 0x0000000187235DB0-0x0000000187235DC0 0x000000018723B560-0x000000018723B570
		public float WindInfluence { get; set; } // 0x000000018723DAD0-0x000000018723DAE0 0x000000018723DB10-0x000000018723DB20
		public float WindRandomScale { get; set; } // 0x000000018723CA50-0x000000018723CA60 0x000000018723CA80-0x000000018723CA90
		public float WindSynchronization { get; set; } // 0x000000018723B920-0x000000018723B930 0x000000018723B940-0x000000018723B950
		public float MaxMoveSpeed { get; set; } // 0x000000018723CA40-0x000000018723CA50 0x000000018723CA70-0x000000018723CA80
		public float MaxRotationSpeed { get; set; } // 0x0000000187250E50-0x0000000187250E60 0x0000000187250F20-0x0000000187250F30
		public bool UseResetTeleport { get; set; } // 0x000000018225E0F0-0x000000018225E100 0x000000018225E100-0x000000018225E110
		public float TeleportDistance { get; set; } // 0x000000018723BB10-0x000000018723BB20 0x000000018723BB60-0x000000018723BB70
		public float TeleportRotation { get; set; } // 0x000000018723F570-0x000000018723F580 0x0000000187234DE0-0x0000000187234DF0
		public TeleportMode TeleportResetMode { get; set; } // 0x000000018723BAF0-0x000000018723BB00 0x000000018723BB50-0x000000018723BB60
		public float ResetStabilizationTime { get; set; } // 0x000000018723F5C0-0x000000018723F5D0 0x000000018723F6A0-0x000000018723F6B0
		public bool UseDistanceDisable { get; set; } // 0x0000000187240E10-0x0000000187240E20 0x0000000187240E30-0x0000000187240E40
		public Transform DisableReferenceObject { get; set; } // 0x0000000187232F60-0x0000000187232F70 0x0000000188800C88-0x0000000188800C9C
		public float DisableDistance { get; set; } // 0x0000000187250E40-0x0000000187250E50 0x0000000187250F10-0x0000000187250F20
		public float DisableFadeDistance { get; set; } // 0x000000018723F560-0x000000018723F570 0x000000018723F650-0x000000018723F660
		public bool UseClampDistanceRatio { get; } // 0x000000018723BAD0-0x000000018723BAE0 
		public float ClampDistanceMinRatio { get; } // 0x0000000185223350-0x0000000185223370 
		public float ClampDistanceMaxRatio { get; } // 0x0000000185223330-0x0000000185223350 
		public float ClampDistanceVelocityInfluence { get; } // 0x0000000185223310-0x0000000185223330 
		public bool UseClampPositionLength { get; } // 0x0000000187250600-0x0000000187250610 
		public Vector3 ClampPositionAxisRatio { get; } // 0x0000000187250E20-0x0000000187250E40 
		public float ClampPositionVelocityInfluence { get; } // 0x000000018C31ACF8-0x000000018C31AD14 
		public bool UseClampRotation { get; } // 0x000000018723B8D0-0x000000018723B8E0 
		public float ClampRotationVelocityInfluence { get; } // 0x000000018C31AD14-0x000000018C31AD30 
		public float RestoreDistanceVelocityInfluence { get; } // 0x000000018723B580-0x000000018723B590 
		public bool UseBendDistance { get; } // 0x00000001872406E0-0x00000001872406F0 
		public int BendDistanceMaxCount { get; } // 0x0000000187240800-0x0000000187240810 
		public bool UseNearDistance { get; } // 0x000000018723DC60-0x000000018723DC70 
		public int NearDistanceMaxCount { get; } // 0x0000000187250E60-0x0000000187250E70 
		public float NearDistanceMaxDepth { get; } // 0x0000000187250E70-0x0000000187250E80 
		public bool UseRestoreRotation { get; } // 0x0000000187250B80-0x0000000187250B90 
		public bool UseSpring { get; set; } // 0x000000018723E4A0-0x000000018723E4B0 0x000000018723E4B0-0x000000018723E4C0
		public float SpringPowr { get; set; } // 0x0000000187250E90-0x0000000187250EA0 0x0000000187250F30-0x0000000187250F40
		public float SpringRadius { get; } // 0x000000018723E1C0-0x000000018723E1D0 
		public Vector3 SpringRadiusScale { get; } // 0x0000000187250EA0-0x0000000187250EC0 
		public float SpringIntensity { get; } // 0x0000000187250E80-0x0000000187250E90 
		public AdjustMode AdjustRotationMode { get; } // 0x000000018723D560-0x000000018723D570 
		public Vector3 AdjustRotationVector { get; } // 0x000000018C31ACA4-0x000000018C31ACF8 
		public bool UseTriangleBend { get; } // 0x000000018723DFC0-0x000000018723DFD0 
		internal float TwistRecoveryPower { get; } // 0x0000000187250ED0-0x0000000187250EE0 
		public bool UseVolume { get; } // 0x0000000187240890-0x00000001872408A0 
		public bool UseCollision { get; } // 0x00000001872501E0-0x00000001872501F0 
		public float DynamicFriction { get; } // 0x000000018723EB80-0x000000018723EB90 
		public float StaticFriction { get; } // 0x0000000187250EC0-0x0000000187250ED0 
		public bool UsePenetration { get; set; } // 0x0000000187250F00-0x0000000187250F10 0x0000000187250F40-0x0000000187250F50
		public float PenetrationMaxDepth { get; } // 0x000000018723F0D0-0x000000018723F0E0 
		public bool UseLineAvarageRotation { get; } // 0x0000000187250EF0-0x0000000187250F00 
		public bool UseFixedNonRotation { get; } // 0x0000000187250EE0-0x0000000187250EF0 
	
		// Nested types
		public enum Algorithm // TypeDefIndex: 82059
		{
			Algorithm_1 = 0,
			Algorithm_2 = 1
		}
	
		public enum TeleportMode // TypeDefIndex: 82060
		{
			Reset = 0,
			Keep = 1
		}
	
		public enum AdjustMode // TypeDefIndex: 82061
		{
			Fixed = 0,
			XYMove = 1,
			XZMove = 2,
			YZMove = 3
		}
	
		public enum PenetrationMode // TypeDefIndex: 82062
		{
			SurfacePenetration = 0,
			ColliderPenetration = 1
		}
	
		public enum PenetrationAxis // TypeDefIndex: 82063
		{
			X = 0,
			Y = 1,
			Z = 2,
			InverseX = 3,
			InverseY = 4,
			InverseZ = 5
		}
	
		public enum ParamType // TypeDefIndex: 82064
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
		public ClothParams(); // 0x00000001855E0810-0x00000001855E1080
	
		// Methods
		public void SetChangeParam(ParamType ptype); // 0x000000018C31A808-0x000000018C31A860
		public bool ChangedParam(ParamType ptype); // 0x000000018C31A014-0x000000018C31A06C
		public void ClearChangeParam(); // 0x000000018C31A06C-0x000000018C31A0B4
		public int GetParamHash(BaseCloth cloth, ParamType ptype); // 0x000000018C31A184-0x000000018C31A780
		public void SetRadius(float sval, float eval); // 0x000000018C31AA50-0x000000018C31AA84
		public float GetRadius(float depth); // 0x0000000185D32960-0x0000000185D32980
		public BezierParam GetRadius(); // 0x0000000182234E30-0x0000000182234E40
		public void SetMass(float sval, float eval, bool useEval = true /* Metadata: 0x02640918 */, float cval = 0f /* Metadata: 0x02640919 */, bool useCval = false /* Metadata: 0x0264091D */); // 0x000000018C31A9E0-0x000000018C31AA1C
		public BezierParam GetMass(); // 0x000000018225E800-0x000000018225E810
		public void SetGravity(bool sw, float sval = -9.8f /* Metadata: 0x0264091E */, float eval = -9.8f /* Metadata: 0x02640922 */); // 0x000000018C31A9AC-0x000000018C31A9E0
		public BezierParam GetGravity(); // 0x0000000185223260-0x00000001852232A0
		public void SetDrag(bool sw, float sval = 0.015f /* Metadata: 0x02640926 */, float eval = 0.015f /* Metadata: 0x0264092A */); // 0x000000018C31A978-0x000000018C31A9AC
		public BezierParam GetDrag(); // 0x0000000185223240-0x0000000185223260
		public void SetMaxVelocity(bool sw, float sval = 3f /* Metadata: 0x0264092E */, float eval = 3f /* Metadata: 0x02640932 */); // 0x000000018C31AA1C-0x000000018C31AA50
		public BezierParam GetMaxVelocity(); // 0x00000001852232A0-0x00000001852232F0
		public void SetExternalForce(float massInfluence, float windInfluence, float windRandomScale, float windSynchronization); // 0x0000000187250D70-0x0000000187250DA0
		public BezierParam GetDepthInfluence(); // 0x0000000187232F50-0x0000000187232F60
		public void SetWorldInfluence(float maxspeed, float moveval, float rotval); // 0x000000018C31AC54-0x000000018C31ACA4
		public BezierParam GetWorldMoveInfluence(); // 0x0000000187232FC0-0x0000000187232FD0
		public BezierParam GetWorldRotationInfluence(); // 0x00000001829CD170-0x00000001829CD180
		public Transform GetInfluenceTarget(); // 0x0000000187232FA0-0x0000000187232FB0
		public void SetInfluenceTarget(Transform t); // 0x0000000188800CB0-0x0000000188800CC0
		public void SetTeleport(bool sw, float distance = 0.2f /* Metadata: 0x02640936 */, float rotation = 45f /* Metadata: 0x0264093A */, TeleportMode mode = TeleportMode.Reset /* Metadata: 0x0264093E */); // 0x0000000187250DF0-0x0000000187250E20
		public void SetDistanceDisable(bool sw, float distance = 20f /* Metadata: 0x0264093F */, float fadeDistance = 5f /* Metadata: 0x02640943 */, Transform referenceObject = null); // 0x000000018C31A93C-0x000000018C31A978
		public void SetClampDistanceRatio(bool sw, float minval = 0.1f /* Metadata: 0x02640947 */, float maxval = 1.05f /* Metadata: 0x0264094B */, float influence = 0.2f /* Metadata: 0x0264094F */); // 0x0000000187250D20-0x0000000187250D50
		public void SetClampPositionLength(bool sw, float sval = 0.03f /* Metadata: 0x02640953 */, float eval = 0.2f /* Metadata: 0x02640957 */, float ratioX = 1f /* Metadata: 0x0264095B */, float ratioY = 1f /* Metadata: 0x0264095F */, float ratioZ = 1f /* Metadata: 0x02640963 */, float influence = 0.2f /* Metadata: 0x02640967 */); // 0x000000018C31A860-0x000000018C31A8D4
		public BezierParam GetClampPositionLength(); // 0x0000000187235E40-0x0000000187235E50
		public void SetClampRotationAngle(bool sw, float sval = 0f /* Metadata: 0x0264096B */, float eval = 180f /* Metadata: 0x0264096F */, float influence = 0.2f /* Metadata: 0x02640973 */); // 0x000000018C31A8D4-0x000000018C31A93C
		public BezierParam GetClampRotationAngle(Algorithm algo); // 0x0000000185223200-0x0000000185223220
		public float GetClampRotationVelocityLimit(Algorithm algo); // 0x000000018C31A148-0x000000018C31A16C
		public void SetRestoreDistance(float influence = 1f /* Metadata: 0x02640977 */, float structStiffness = 1f /* Metadata: 0x0264097B */); // 0x000000018C31AA84-0x000000018C31AAC0
		public BezierParam GetStructDistanceStiffness(); // 0x0000000187232D10-0x0000000187232D20
		public BezierParam GetBendDistanceStiffness(); // 0x000000018723B5D0-0x000000018723B5E0
		public BezierParam GetNearDistanceLength(); // 0x000000018723BE50-0x000000018723BE60
		public BezierParam GetNearDistanceStiffness(); // 0x000000018723BEA0-0x000000018723BEB0
		public void SetRestoreRotation(bool sw, float sval = 0.02f /* Metadata: 0x0264097F */, float eval = 0.001f /* Metadata: 0x02640983 */, float influence = 0.3f /* Metadata: 0x02640987 */); // 0x000000018C31AAC0-0x000000018C31AB30
		public BezierParam GetRestoreRotationPower(Algorithm algo); // 0x0000000185223220-0x0000000185223240
		public float GetRestoreRotationVelocityInfluence(Algorithm algo); // 0x00000001852232F0-0x0000000185223310
		public void SetSpring(bool sw, float power = 0f /* Metadata: 0x0264098B */, float r = 0f /* Metadata: 0x0264098F */, float sclx = 1f /* Metadata: 0x02640993 */, float scly = 1f /* Metadata: 0x02640997 */, float sclz = 1f /* Metadata: 0x0264099B */, float intensity = 1f /* Metadata: 0x0264099F */); // 0x0000000187250DA0-0x0000000187250DF0
		public void SetSpringDirectionAtten(float sval, float eval, float cval); // 0x000000018C31AB30-0x000000018C31AB64
		public void SetSpringDistanceAtten(float sval, float eval, float cval); // 0x000000018C31AB64-0x000000018C31AB98
		public float GetSpringPower(); // 0x000000018C31A7C8-0x000000018C31A7E0
		public float GetSpringDirectionAtten(float ratio); // 0x000000018C31A780-0x000000018C31A7A4
		public float GetSpringDistanceAtten(float ratio); // 0x000000018C31A7A4-0x000000018C31A7C8
		public void SetAdjustRotation(AdjustMode amode = AdjustMode.Fixed /* Metadata: 0x026409A3 */, float power = 0f /* Metadata: 0x026409A4 */); // 0x0000000187250D10-0x0000000187250D20
		public void SetTriangleBend(bool sw, float sval = 1f /* Metadata: 0x026409A8 */, float eval = 1f /* Metadata: 0x026409AC */); // 0x000000018C31AB98-0x000000018C31ABF0
		public BezierParam GetTriangleBendStiffness(Algorithm algo); // 0x000000018C31A7E0-0x000000018C31A7F8
		internal bool GetUseTwistCorrection(Algorithm algo); // 0x000000018C31A7F8-0x000000018C31A808
		public void SetVolume(bool sw, float maxLength = 0.05f /* Metadata: 0x026409B0 */, float stiffness = 0.5f /* Metadata: 0x026409B4 */, float shear = 0.5f /* Metadata: 0x026409B8 */); // 0x000000018C31ABF0-0x000000018C31AC54
		public float GetMaxVolumeLength(); // 0x000000018C31A16C-0x000000018C31A184
		public BezierParam GetVolumeStretchStiffness(); // 0x000000018723BC70-0x000000018723BC80
		public BezierParam GetVolumeShearStiffness(); // 0x000000018723BCA0-0x000000018723BCB0
		public void SetCollision(bool sw, float dynamicFriction = 0.1f /* Metadata: 0x026409BC */, float staticFriction = 0.03f /* Metadata: 0x026409C0 */); // 0x0000000187250D50-0x0000000187250D70
		public PenetrationMode GetPenetrationMode(); // 0x00000001872500B0-0x00000001872500C0
		public PenetrationAxis GetPenetrationAxis(); // 0x0000000187250D00-0x0000000187250D10
		public BezierParam GetPenetrationConnectDistance(); // 0x000000018723BE40-0x000000018723BE50
		public BezierParam GetPenetrationRadius(); // 0x0000000187234930-0x0000000187234940
		public BezierParam GetPenetrationDistance(); // 0x0000000187234920-0x0000000187234930
		public void ConvertToLatestAlgorithmParameter(); // 0x000000018C31A0B4-0x000000018C31A148
	}

	public class ClothSetup // TypeDefIndex: 82067
	{
		// Fields
		private int teamBoneIndex; // 0x10
		private float distanceBlendRatio; // 0x14
	
		// Properties
		public float DistanceBlendRatio { get; set; } // 0x0000000187235C60-0x0000000187235C70 0x0000000187235C70-0x0000000187235C80
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 82066
		{
			// Fields
			public ClothData clothData; // 0x10
			public Func<int, uint> funcUserFlag; // 0x18
			public ClothParams param; // 0x20
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal uint _ClothInit_b__0(int i); // 0x00000001853CEEB0-0x00000001853CEF80
			internal float _ClothInit_b__1(int i); // 0x00000001866E7750-0x00000001866E7780
			internal float3 _ClothInit_b__2(int i); // 0x0000000185D328E0-0x0000000185D32960
		}
	
		// Constructors
		public ClothSetup(); // 0x0000000187250FD0-0x0000000187250FE0
	
		// Methods
		public void ClothInit(PhysicsTeam team, MeshData meshData, ClothData clothData, ClothParams param, Func<int, uint> funcUserFlag); // 0x00000001852221C0-0x0000000185223200
		public void ClothDispose(PhysicsTeam team); // 0x0000000185D96D30-0x0000000185D96DA0
		public void ClothActive(PhysicsTeam team, ClothParams param, ClothData clothData); // 0x00000001853C9FB0-0x00000001853CA0F0
		public void ClothInactive(PhysicsTeam team); // 0x00000001853CA800-0x00000001853CA8F0
		internal void ReplaceBone<T>(PhysicsTeam team, ClothParams param, Dictionary<T, Transform> boneReplaceDict)
			where T : class;
		internal HashSet<Transform> GetUsedBones(PhysicsTeam team, ClothParams param); // 0x000000018C3218C0-0x000000018C321950
		public void ChangeUseUnityPhysics(bool sw); // 0x000000018C321854-0x000000018C3218C0
		public void ChangeData(PhysicsTeam team, ClothParams param, ClothData clothData); // 0x000000018C320C2C-0x000000018C321854
	}

	[AddComponentMenu("MagicaCloth/MagicaBoneCloth")]
	[HelpURL("https://magicasoft.jp/magica-cloth-bone-cloth/")]
	public class MagicaBoneCloth : BaseCloth // TypeDefIndex: 82068
	{
		// Fields
		private const int DATA_VERSION = 7; // Metadata: 0x026409EC
		private const int ERR_DATA_VERSION = 3; // Metadata: 0x026409ED
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
		public BoneClothTarget ClothTarget { get; } // 0x0000000187235E40-0x0000000187235E50 
		public MeshData MeshData { get; } // 0x000000018723BB00-0x000000018723BB10 
		private int UseTransformCount { get; } // 0x0000000185B13B50-0x0000000185B13B70 
	
		// Constructors
		public MagicaBoneCloth(); // 0x00000001855E0280-0x00000001855E03C0
	
		// Methods
		public override ComponentType GetComponentType(); // 0x0000000187250FE0-0x0000000187250FF0
		public override int GetDataHash(); // 0x000000018C3220DC-0x000000018C3221F8
		protected override void Reset(); // 0x000000018C323F8C-0x000000018C323F94
		protected override void OnValidate(); // 0x000000018C323C20-0x000000018C323C28
		protected override void ClothInit(); // 0x0000000185223FA0-0x0000000185223FE0
		protected override void ClothDispose(); // 0x00000001867F6530-0x00000001867F6560
		protected override void ClothActive(); // 0x00000001853C9960-0x00000001853C9970
		protected override uint UserFlag(int index); // 0x00000001853CE400-0x00000001853CE440
		protected override Transform UserTransform(int index); // 0x0000000185B17C90-0x0000000185B17CA0
		protected override float3 UserTransformLocalPosition(int vindex); // 0x0000000185D329C0-0x0000000185D32A60
		protected override quaternion UserTransformLocalRotation(int vindex); // 0x00000001864646B0-0x0000000186464770
		public override BaseMeshDeformer GetDeformer(); // 0x0000000185829EC0-0x0000000185829ED0
		protected override MeshData GetMeshData(); // 0x000000018723BB00-0x000000018723BB10
		protected override void WorkerInit(); // 0x0000000186805BA0-0x0000000186805BB0
		public override bool IsRequiresDeformer(); // 0x00000001843FFFF0-0x0000000184400000
		protected override void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void ChangeUseUnityPhysics(bool sw); // 0x000000018C321F0C-0x000000018C321F54
		protected override void OnChangeCalculation(); // 0x00000001853C8C30-0x00000001853C8CD0
		public List<Transform> GetTransformList(); // 0x000000018C323870-0x000000018C323B94
		private Transform GetUseTransform(int index); // 0x0000000185B17CA0-0x0000000185B17CF0
		public List<List<List<Transform>>> GetTransformGrid(out int maxLevel); // 0x000000018C3234C8-0x000000018C323870
		public override int GetVersion(); // 0x0000000187239C90-0x0000000187239CA0
		public override int GetErrorVersion(); // 0x00000001872396E0-0x00000001872396F0
		public override void CreateVerifyData(); // 0x000000018C321F54-0x000000018C321F9C
		public override Define.Error VerifyData(); // 0x0000000185B15880-0x0000000185B15B90
		public override string GetInformation(); // 0x000000018C32273C-0x000000018C323424
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict);
		public override HashSet<Transform> GetUsedBones(); // 0x000000018C323B94-0x000000018C323C20
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x000000018C3222D8-0x000000018C32265C
		public override List<int> GetEditorTriangleList(); // 0x000000018C32265C-0x000000018C32273C
		public override List<int> GetEditorLineList(); // 0x000000018C3221F8-0x000000018C3222D8
		public override List<int> GetSelectionList(); // 0x000000018C323424-0x000000018C3234C8
		public override List<int> GetUseList(); // 0x0000000185829EC0-0x0000000185829ED0
		public override List<ShareDataObject> GetAllShareDataObject(); // 0x000000018C322074-0x000000018C3220DC
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source); // 0x000000018C321F9C-0x000000018C322074
		private void ResetParams(); // 0x000000018C323C28-0x000000018C323F8C
	}

	[AddComponentMenu("MagicaCloth/MagicaBoneSpring")]
	[HelpURL("https://magicasoft.jp/magica-cloth-bone-spring/")]
	public class MagicaBoneSpring : BaseCloth // TypeDefIndex: 82069
	{
		// Fields
		private const int DATA_VERSION = 7; // Metadata: 0x026409EE
		private const int ERR_DATA_VERSION = 3; // Metadata: 0x026409EF
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
		public BoneClothTarget ClothTarget { get; } // 0x0000000187235E40-0x0000000187235E50 
		public MeshData MeshData { get; } // 0x000000018723BB00-0x000000018723BB10 
		private int UseTransformCount { get; } // 0x000000018C325E14-0x000000018C325E54 
	
		// Constructors
		public MagicaBoneSpring(); // 0x000000018C325C74-0x000000018C325E14
	
		// Methods
		public override ComponentType GetComponentType(); // 0x0000000187250FF0-0x0000000187251000
		public override int GetDataHash(); // 0x000000018C324184-0x000000018C3242A0
		protected override void Reset(); // 0x000000018C32577C-0x000000018C325784
		protected override void OnValidate(); // 0x000000018C323C20-0x000000018C323C28
		protected override void ClothInit(); // 0x000000018C323FB8-0x000000018C324044
		protected override void ClothDispose(); // 0x000000018C323F94-0x000000018C323FB8
		protected override void ClothActive(); // 0x00000001853C9960-0x00000001853C9970
		protected override uint UserFlag(int index); // 0x000000018C325784-0x000000018C3257B8
		protected override Transform UserTransform(int index); // 0x000000018C325948-0x000000018C325950
		protected override float3 UserTransformLocalPosition(int vindex); // 0x000000018C3257B8-0x000000018C325888
		protected override quaternion UserTransformLocalRotation(int vindex); // 0x000000018C325888-0x000000018C325948
		public override bool IsRequiresDeformer(); // 0x00000001843FFFF0-0x0000000184400000
		public override BaseMeshDeformer GetDeformer(); // 0x0000000185829EC0-0x0000000185829ED0
		protected override MeshData GetMeshData(); // 0x000000018723BB00-0x000000018723BB10
		protected override void WorkerInit(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void ChangeUseUnityPhysics(bool sw); // 0x000000018C321F0C-0x000000018C321F54
		protected override void OnChangeCalculation(); // 0x000000018C3252E8-0x000000018C325410
		public List<Transform> GetTransformList(); // 0x000000018C324ECC-0x000000018C324FDC
		private Transform GetUseTransform(int index); // 0x000000018C3251D8-0x000000018C32525C
		public override int GetVersion(); // 0x0000000187239C90-0x0000000187239CA0
		public override int GetErrorVersion(); // 0x00000001872396E0-0x00000001872396F0
		public override void CreateVerifyData(); // 0x000000018C321F54-0x000000018C321F9C
		public override Define.Error VerifyData(); // 0x000000018C325950-0x000000018C325C74
		public override string GetInformation(); // 0x000000018C3247E4-0x000000018C324E28
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict);
		public override HashSet<Transform> GetUsedBones(); // 0x000000018C32525C-0x000000018C3252E8
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x000000018C324380-0x000000018C324704
		public override List<int> GetEditorTriangleList(); // 0x000000018C324704-0x000000018C3247E4
		public override List<int> GetEditorLineList(); // 0x000000018C3242A0-0x000000018C324380
		public override List<int> GetSelectionList(); // 0x000000018C324E28-0x000000018C324ECC
		public override List<int> GetUseList(); // 0x000000018C324FDC-0x000000018C3251D8
		public override List<ShareDataObject> GetAllShareDataObject(); // 0x000000018C32411C-0x000000018C324184
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source); // 0x000000018C324044-0x000000018C32411C
		private void ResetParams(); // 0x000000018C325410-0x000000018C32577C
	}

	[AddComponentMenu("MagicaCloth/MagicaMeshCloth", 100)]
	[HelpURL("https://magicasoft.jp/magica-cloth-mesh-cloth/")]
	public class MagicaMeshCloth : BaseCloth // TypeDefIndex: 82070
	{
		// Fields
		private const int DATA_VERSION = 7; // Metadata: 0x026409F0
		private const int ERR_DATA_VERSION = 3; // Metadata: 0x026409F1
		[SerializeField]
		private MagicaVirtualDeformer virtualDeformer; // 0xC8
		[SerializeField]
		private int virtualDeformerHash; // 0xD0
		[SerializeField]
		private int virtualDeformerVersion; // 0xD4
	
		// Properties
		public VirtualMeshDeformer Deformer { get; } // 0x000000018C3276B8-0x000000018C327730 
	
		// Constructors
		public MagicaMeshCloth(); // 0x000000018C3276B0-0x000000018C3276B8
	
		// Methods
		public override ComponentType GetComponentType(); // 0x0000000187251000-0x0000000187251010
		public override int GetDataHash(); // 0x000000018C326020-0x000000018C326060
		protected override void Reset(); // 0x000000018C32732C-0x000000018C327334
		protected override void OnValidate(); // 0x000000018C323C20-0x000000018C323C28
		protected override void OnInit(); // 0x000000018C326FC4-0x000000018C326FCC
		protected override void OnActive(); // 0x000000018C326FAC-0x000000018C326FB4
		protected override void OnInactive(); // 0x000000018C326FBC-0x000000018C326FC4
		protected override void OnDispose(); // 0x000000018C326FB4-0x000000018C326FBC
		protected override uint UserFlag(int index); // 0x0000000185829EC0-0x0000000185829ED0
		protected override Transform UserTransform(int index); // 0x0000000185829EC0-0x0000000185829ED0
		protected override float3 UserTransformLocalPosition(int vindex); // 0x0000000187251010-0x0000000187251030
		protected override quaternion UserTransformLocalRotation(int vindex); // 0x000000018C327424-0x000000018C327468
		public override bool IsRequiresDeformer(); // 0x00000001851A4410-0x00000001851A4420
		public override BaseMeshDeformer GetDeformer(); // 0x000000018C326060-0x000000018C326068
		protected override MeshData GetMeshData(); // 0x000000018C326C0C-0x000000018C326C2C
		protected override void WorkerInit(); // 0x000000018C327554-0x000000018C3276B0
		protected override void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer); // 0x000000018C327334-0x000000018C327424
		protected override void ChangeUseUnityPhysics(bool sw); // 0x000000018C325E54-0x000000018C325E90
		public override int GetVersion(); // 0x0000000187239C90-0x0000000187239CA0
		public override int GetErrorVersion(); // 0x00000001872396E0-0x00000001872396F0
		public override void CreateVerifyData(); // 0x000000018C321F54-0x000000018C321F9C
		public override Define.Error VerifyData(); // 0x000000018C327468-0x000000018C327554
		public override string GetInformation(); // 0x000000018C326104-0x000000018C326C0C
		public bool IsValidPointSelect(); // 0x000000018C326F10-0x000000018C326FAC
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x000000018C326090-0x000000018C3260DC
		public override List<int> GetEditorTriangleList(); // 0x000000018C3260DC-0x000000018C326104
		public override List<int> GetEditorLineList(); // 0x000000018C326068-0x000000018C326090
		public override List<int> GetSelectionList(); // 0x000000018C326C2C-0x000000018C326D40
		public override List<int> GetUseList(); // 0x000000018C326D40-0x000000018C326F10
		public override List<ShareDataObject> GetAllShareDataObject(); // 0x000000018C325FA0-0x000000018C326020
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source); // 0x000000018C325E90-0x000000018C325FA0
		private void ResetParams(); // 0x000000018C326FCC-0x000000018C32732C
	}

	[AddComponentMenu("MagicaCloth/MagicaMeshSpring", 100)]
	[HelpURL("https://magicasoft.jp/magica-cloth-mesh-spring/")]
	public class MagicaMeshSpring : BaseCloth // TypeDefIndex: 82072
	{
		// Fields
		private const int DATA_VERSION = 7; // Metadata: 0x026409F2
		private const int ERR_DATA_VERSION = 3; // Metadata: 0x026409F3
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
		public VirtualMeshDeformer Deformer { get; } // 0x000000018C328CA4-0x000000018C328D1C 
		public SpringData SpringData { get; } // 0x00000001872354B0-0x00000001872354C0 
		public int UseVertexCount { get; } // 0x000000018C328D1C-0x000000018C328D94 
		public Transform CenterTransform { get; set; } // 0x0000000187235E40-0x0000000187235E50 0x0000000188D62F68-0x0000000188D62F7C
		public Axis DirectionAxis { get; set; } // 0x00000001872406F0-0x0000000187240700 0x0000000187240750-0x0000000187240760
		public Vector3 CenterTransformDirection { get; } // 0x000000018C328B10-0x000000018C328CA4 
	
		// Nested types
		public enum Axis // TypeDefIndex: 82071
		{
			X = 0,
			Y = 1,
			Z = 2,
			InverseX = 3,
			InverseY = 4,
			InverseZ = 5
		}
	
		// Constructors
		public MagicaMeshSpring(); // 0x000000018C3276B0-0x000000018C3276B8
	
		// Methods
		public override ComponentType GetComponentType(); // 0x0000000187251030-0x0000000187251040
		public override int GetDataHash(); // 0x000000018C327ABC-0x000000018C327B3C
		public SpringData.DeformerData GetDeformerData(); // 0x000000018C327B3C-0x000000018C327B5C
		protected override void Reset(); // 0x000000018C3286BC-0x000000018C3286C4
		protected override void OnValidate(); // 0x000000018C323C20-0x000000018C323C28
		protected override void ClothInit(); // 0x000000018C327730-0x000000018C32790C
		protected override void ClothActive(); // 0x00000001853C9960-0x00000001853C9970
		protected override uint UserFlag(int index); // 0x0000000187251040-0x0000000187251050
		protected override Transform UserTransform(int index); // 0x0000000187235E40-0x0000000187235E50
		protected override float3 UserTransformLocalPosition(int vindex); // 0x000000018C32876C-0x000000018C3287D0
		protected override quaternion UserTransformLocalRotation(int vindex); // 0x000000018C3287D0-0x000000018C328824
		public override bool IsRequiresDeformer(); // 0x00000001851A4410-0x00000001851A4420
		public override BaseMeshDeformer GetDeformer(); // 0x000000018C327B5C-0x000000018C327BD0
		protected override MeshData GetMeshData(); // 0x0000000185829EC0-0x0000000185829ED0
		protected override void WorkerInit(); // 0x000000018C328990-0x000000018C328B10
		protected override void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer); // 0x000000018C3286C4-0x000000018C32876C
		protected override void ChangeUseUnityPhysics(bool sw); // 0x000000018C325E54-0x000000018C325E90
		protected override void OnChangeCalculation(); // 0x000000018C328268-0x000000018C328304
		public override int GetVersion(); // 0x0000000187239C90-0x0000000187239CA0
		public override int GetErrorVersion(); // 0x00000001872396E0-0x00000001872396F0
		public override void CreateVerifyData(); // 0x000000018C32790C-0x000000018C32797C
		public override Define.Error VerifyData(); // 0x000000018C328824-0x000000018C328990
		public override string GetInformation(); // 0x000000018C327DD4-0x000000018C328200
		public void VerifyDeformer(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict);
		public override HashSet<Transform> GetUsedBones(); // 0x000000018C328200-0x000000018C328268
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x000000018C327BD0-0x000000018C327DD4
		public override List<int> GetEditorTriangleList(); // 0x0000000185829EC0-0x0000000185829ED0
		public override List<int> GetEditorLineList(); // 0x0000000185829EC0-0x0000000185829ED0
		public override List<int> GetSelectionList(); // 0x0000000185829EC0-0x0000000185829ED0
		public override List<int> GetUseList(); // 0x0000000185829EC0-0x0000000185829ED0
		public override List<ShareDataObject> GetAllShareDataObject(); // 0x000000018C327A54-0x000000018C327ABC
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source); // 0x000000018C32797C-0x000000018C327A54
		private void ResetParams(); // 0x000000018C328304-0x000000018C3286BC
	}

	[Serializable]
	public class SelectionData : ShareDataObject // TypeDefIndex: 82074
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x026409FA
		public const int Invalid = 0; // Metadata: 0x026409FB
		public const int Move = 1; // Metadata: 0x026409FC
		public const int Fixed = 2; // Metadata: 0x026409FD
		public const int Extend = 3; // Metadata: 0x026409FE
		public List<DeformerSelection> selectionList; // 0x20
	
		// Properties
		public int DeformerCount { get; } // 0x000000018C32E9FC-0x000000018C32EA3C 
	
		// Nested types
		[Serializable]
		public class DeformerSelection : IDataHash // TypeDefIndex: 82073
		{
			// Fields
			public List<int> selectData; // 0x10
			public List<ulong> vertexHashList; // 0x18
	
			// Constructors
			public DeformerSelection(); // 0x00000001858E30A0-0x00000001858E3120
	
			// Methods
			public int GetDataHash(); // 0x000000018C321ED0-0x000000018C321F0C
			public bool Compare(DeformerSelection data); // 0x000000018C321D7C-0x000000018C321ED0
		}
	
		// Constructors
		public SelectionData(); // 0x00000001866F2070-0x00000001866F20D0
	
		// Methods
		public override int GetDataHash(); // 0x000000018C32D9D0-0x000000018C32DA0C
		public override int GetVersion(); // 0x00000001845AFFB0-0x00000001845AFFC0
		public override Define.Error VerifyData(); // 0x0000000186A36FE0-0x0000000186A37020
		public bool Compare(SelectionData sel); // 0x000000018C32D8F4-0x000000018C32D9D0
		public List<int> GetSelectionData(MeshData meshData, List<MeshData> childMeshDataList); // 0x000000018C32DA0C-0x000000018C32DBCC
		private int GetSelection(MeshData meshData, int vindex, Dictionary<int, List<uint>> dict, List<MeshData> childMeshDataList, List<Dictionary<ulong, int>> hashList); // 0x000000018C32DE40-0x000000018C32E30C
		public void SetSelectionData(MeshData meshData, List<int> selects, List<MeshData> childMeshDataList); // 0x000000018C32E30C-0x000000018C32E9FC
		private List<Dictionary<ulong, int>> GetSelectionVertexHashList(); // 0x000000018C32DBCC-0x000000018C32DE40
	}

	[Serializable]
	public class SpringData : ShareDataObject // TypeDefIndex: 82076
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x026409FF
		public DeformerData deformerData; // 0x20
		public Vector3 initScale; // 0x28
	
		// Properties
		public int UseVertexCount { get; } // 0x000000018C32EA78-0x000000018C32EA94 
	
		// Nested types
		[Serializable]
		public class DeformerData : IDataHash // TypeDefIndex: 82075
		{
			// Fields
			public int deformerDataHash; // 0x10
			public int vertexCount; // 0x14
			public int[] useVertexIndexList; // 0x18
			public float[] weightList; // 0x20
	
			// Properties
			public int UseVertexCount { get; } // 0x000000018C321D68-0x000000018C321D7C 
	
			// Constructors
			public DeformerData(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public int GetDataHash(); // 0x000000018C321CD4-0x000000018C321D68
		}
	
		// Constructors
		public SpringData(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		public override int GetDataHash(); // 0x000000018C32EA3C-0x000000018C32EA5C
		public override int GetVersion(); // 0x00000001845AFFB0-0x00000001845AFFC0
		public override Define.Error VerifyData(); // 0x000000018C32EA5C-0x000000018C32EA78
	}

	public static class Define // TypeDefIndex: 82081
	{
		// Nested types
		public static class Compute // TypeDefIndex: 82077
		{
			// Fields
			public const float Epsilon = 1E-06f; // Metadata: 0x02640A00
			public const float CollisionFrictionRange = 0.03f; // Metadata: 0x02640A04
			public const float FrictionDampingRate = 0.6f; // Metadata: 0x02640A08
			public const float FrictionMoveRatio = 0.5f; // Metadata: 0x02640A0C
			public const float FrictionPower = 4f; // Metadata: 0x02640A10
			public const float ClampPositionMaxVelocity = 1f; // Metadata: 0x02640A14
			public const float GlobalColliderMaxMoveDistance = 0.2f; // Metadata: 0x02640A18
			public const float GlobalColliderMaxRotationAngle = 10f; // Metadata: 0x02640A1C
			public const float ColliderExtrusionMaxPower = 0.4f; // Metadata: 0x02640A20
			public const float ColliderExtrusionDirectionPower = 0.3f; // Metadata: 0x02640A24
			public const float ColliderExtrusionDistPower = 2f; // Metadata: 0x02640A28
			public const float ColliderExtrusionVelocityInfluence = 0.25f; // Metadata: 0x02640A2C
			public const float MaxWindMain = 100f; // Metadata: 0x02640A30
			public const float ClampRotationMaxVelocity = 1f; // Metadata: 0x02640A34
			public const float ClampRotationMaxVelocity2 = 2f; // Metadata: 0x02640A38
			public const float TriangleBendVelocityInfluence = 0.5f; // Metadata: 0x02640A3C
		}
	
		public enum Error // TypeDefIndex: 82078
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
	
		public static class OptimizeMesh // TypeDefIndex: 82079
		{
			// Fields
			public const int Unknown = 0; // Metadata: 0x02640AD2
			public const int Nothing = 1; // Metadata: 0x02640AD3
			public const int Unity2018_On = 16; // Metadata: 0x02640AD4
			public const int Unity2019_PolygonOrder = 256; // Metadata: 0x02640AD5
			public const int Unity2019_VertexOrder = 512; // Metadata: 0x02640AD7
		}
	
		public static class RenderMesh // TypeDefIndex: 82080
		{
			// Fields
			public const int WorkerMultiplesOfVertexCollection = 3; // Metadata: 0x02640AD9
		}
	
		// Methods
		public static bool IsNormal(Error err); // 0x0000000188C30D48-0x0000000188C30D50
		public static bool IsError(Error err); // 0x000000018C321CB4-0x000000018C321CC8
		public static bool IsWarning(Error err); // 0x000000018C321CC8-0x000000018C321CD4
		public static string GetErrorMessage(Error err); // 0x000000018C321950-0x000000018C321CB4
	}

	[Serializable]
	public abstract class BaseMeshDeformer : IEditorMesh, IDataVerify, IDataHash // TypeDefIndex: 82082
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
		public CoreComponent Parent { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public virtual MeshData MeshData { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public GameObject TargetObject { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public RuntimeStatus Status { get; } // 0x0000000182262130-0x0000000182262140 
		public int MeshIndex { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001829600C0-0x00000001829600D0 0x0000000185E3C070-0x0000000185E3C080
		public int VertexCount { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018226F000-0x000000018226F010 0x000000018226F010-0x000000018226F020
		public int SkinningVertexCount { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000182271C50-0x0000000182271C60 0x0000000182271C70-0x0000000182271C80
		public int TriangleCount { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000182271C40-0x0000000182271C50 0x0000000182271C60-0x0000000182271C70
		public bool IsSkinning { get; } // 0x000000018C320B64-0x000000018C320BD0 
		public int BoneCount { get; } // 0x000000018C320AEC-0x000000018C320B64 
		public int SaveDataHash { get; } // 0x000000018226A850-0x000000018226A860 
		public int SaveDataVersion { get; } // 0x0000000182A819B0-0x0000000182A819C0 
	
		// Constructors
		protected BaseMeshDeformer(); // 0x000000018C320A80-0x000000018C320AEC
	
		// Methods
		public virtual void Init(); // 0x000000018C32071C-0x000000018C320870
		protected virtual void OnInit(); // 0x000000018C3208E0-0x000000018C320948
		public virtual void Dispose(); // 0x000000018C3205BC-0x000000018C320644
		public virtual void OnEnable(); // 0x000000018C3208A8-0x000000018C3208E0
		public virtual void OnDisable(); // 0x000000018C320870-0x000000018C3208A8
		public virtual void Update(); // 0x000000018C320984-0x000000018C3209C8
		internal abstract void MeshCalculation(int bufferIndex);
		internal abstract void NormalWriting(int bufferIndex);
		protected void OnUpdateStatus(); // 0x000000018C320948-0x000000018C320984
		protected virtual void OnActive(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnInactive(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual bool IsMeshUse(); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool IsActiveMesh(); // 0x00000001843FFFF0-0x0000000184400000
		public virtual void AddUseMesh(object parent); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void RemoveUseMesh(object parent); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual bool AddUseVertex(int vindex, bool fix); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool RemoveUseVertex(int vindex, bool fix); // 0x00000001843FFFF0-0x0000000184400000
		public virtual void ResetFuturePrediction(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void ChangeUseUnityPhysics(bool sw); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual int GetDataHash(); // 0x000000018C320644-0x000000018C3206F0
		public abstract int GetVersion();
		public virtual Define.Error VerifyData(); // 0x000000018C3209C8-0x000000018C320A80
		public virtual void CreateVerifyData(); // 0x000000018C32058C-0x000000018C3205BC
		public virtual string GetInformation(); // 0x000000018C3206F0-0x000000018C32071C
		public abstract int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList);
		public abstract List<int> GetEditorTriangleList();
		public abstract List<int> GetEditorLineList();
		[CompilerGenerated]
		private object _Init_b__33_0(); // 0x00000001829600D0-0x00000001829600E0
	}

	[AddComponentMenu("MagicaCloth/MagicaRenderDeformer")]
	[HelpURL("https://magicasoft.jp/magica-cloth-render-deformer/")]
	public class MagicaRenderDeformer : CoreComponent // TypeDefIndex: 82083
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x02640ADA
		private const int ERR_DATA_VERSION = 0; // Metadata: 0x02640ADB
		[SerializeField]
		private RenderMeshDeformer deformer; // 0x38
		[SerializeField]
		private int deformerHash; // 0x40
		[SerializeField]
		private int deformerVersion; // 0x44
		[CompilerGenerated]
		private PhysicsTeam.TeamCullingMode _cullModeCash_k__BackingField; // 0x48
	
		// Properties
		internal PhysicsTeam.TeamCullingMode cullModeCash { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872330A0-0x00000001872330B0 0x0000000185E120B0-0x0000000185E120C0
		public RenderMeshDeformer Deformer { get; } // 0x000000018C3297A8-0x000000018C3297D4 
	
		// Constructors
		public MagicaRenderDeformer(); // 0x000000018C329730-0x000000018C3297A8
	
		// Methods
		public override ComponentType GetComponentType(); // 0x0000000187251050-0x0000000187251060
		public override int GetDataHash(); // 0x000000018C328F64-0x000000018C328F8C
		private void OnValidate(); // 0x000000018C3292FC-0x000000018C329320
		protected override void OnInit(); // 0x000000018C3292B4-0x000000018C3292D8
		protected override void OnDispose(); // 0x000000018C329268-0x000000018C329290
		protected override void OnUpdate(); // 0x000000018C3292D8-0x000000018C3292FC
		protected override void OnActive(); // 0x000000018C329110-0x000000018C329134
		protected override void OnInactive(); // 0x000000018C329290-0x000000018C3292B4
		protected void OnBecameVisible(); // 0x000000018C32917C-0x000000018C3291C4
		protected void OnBecameInvisible(); // 0x000000018C329134-0x000000018C32917C
		internal override void UpdateCullingMode(CoreComponent caller); // 0x000000018C329320-0x000000018C329694
		protected override void OnChangeCalculation(); // 0x000000018C3291C4-0x000000018C329268
		public override int GetVersion(); // 0x00000001845AFFB0-0x00000001845AFFC0
		public override int GetErrorVersion(); // 0x0000000185829EC0-0x0000000185829ED0
		public override void CreateVerifyData(); // 0x000000018C328DC8-0x000000018C328E10
		public override Define.Error VerifyData(); // 0x000000018C329694-0x000000018C329730
		public override string GetInformation(); // 0x000000018C329028-0x000000018C329070
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict);
		public override HashSet<Transform> GetUsedBones(); // 0x000000018C329094-0x000000018C329110
		protected override void ChangeUseUnityPhysics(bool sw); // 0x000000018C328D94-0x000000018C328DC8
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x000000018C328FB4-0x000000018C329000
		public override List<int> GetEditorTriangleList(); // 0x000000018C329000-0x000000018C329028
		public override List<int> GetEditorLineList(); // 0x000000018C328F8C-0x000000018C328FB4
		public override List<int> GetUseList(); // 0x000000018C329070-0x000000018C329094
		public override List<ShareDataObject> GetAllShareDataObject(); // 0x000000018C328EF0-0x000000018C328F64
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source); // 0x000000018C328E10-0x000000018C328EF0
	}

	[AddComponentMenu("MagicaCloth/MagicaVirtualDeformer")]
	[HelpURL("https://magicasoft.jp/magica-cloth-virtual-deformer/")]
	public class MagicaVirtualDeformer : CoreComponent // TypeDefIndex: 82084
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x02640ADC
		private const int ERR_DATA_VERSION = 0; // Metadata: 0x02640ADD
		[SerializeField]
		private VirtualMeshDeformer deformer; // 0x38
		[SerializeField]
		private int deformerHash; // 0x40
		[SerializeField]
		private int deformerVersion; // 0x44
		[CompilerGenerated]
		private PhysicsTeam.TeamCullingMode _cullModeCash_k__BackingField; // 0x48
	
		// Properties
		internal PhysicsTeam.TeamCullingMode cullModeCash { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872330A0-0x00000001872330B0 0x0000000185E120B0-0x0000000185E120C0
		public VirtualMeshDeformer Deformer { get; } // 0x000000018C3297A8-0x000000018C3297D4 
	
		// Constructors
		public MagicaVirtualDeformer(); // 0x000000018C32A1D8-0x000000018C32A250
	
		// Methods
		public override ComponentType GetComponentType(); // 0x0000000187251060-0x0000000187251070
		public override int GetDataHash(); // 0x000000018C328F64-0x000000018C328F8C
		private void OnValidate(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void OnInit(); // 0x000000018C329D48-0x000000018C329D80
		protected override void OnDispose(); // 0x000000018C329D0C-0x000000018C329D48
		protected override void OnUpdate(); // 0x000000018C3292D8-0x000000018C3292FC
		protected override void OnActive(); // 0x000000018C329110-0x000000018C329134
		protected override void OnInactive(); // 0x000000018C329290-0x000000018C3292B4
		private void LinkRenderDeformerStatus(bool sw); // 0x000000018C329BCC-0x000000018C329CC8
		protected override void ChangeUseUnityPhysics(bool sw); // 0x000000018C3297D4-0x000000018C329870
		internal override void UpdateCullingMode(CoreComponent caller); // 0x000000018C329D80-0x000000018C32A16C
		protected override void OnChangeCalculation(); // 0x000000018C329CC8-0x000000018C329D0C
		public override int GetVersion(); // 0x00000001845AFFB0-0x00000001845AFFC0
		public override int GetErrorVersion(); // 0x0000000185829EC0-0x0000000185829ED0
		public override void CreateVerifyData(); // 0x000000018C328DC8-0x000000018C328E10
		public override Define.Error VerifyData(); // 0x000000018C32A16C-0x000000018C32A1D8
		public override string GetInformation(); // 0x000000018C329028-0x000000018C329070
		public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict);
		public override HashSet<Transform> GetUsedBones(); // 0x000000018C329B50-0x000000018C329BCC
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x000000018C328FB4-0x000000018C329000
		public override List<int> GetEditorTriangleList(); // 0x000000018C329000-0x000000018C329028
		public override List<int> GetEditorLineList(); // 0x000000018C328F8C-0x000000018C328FB4
		public override List<int> GetUseList(); // 0x000000018C3299C4-0x000000018C329B50
		public override List<ShareDataObject> GetAllShareDataObject(); // 0x000000018C329950-0x000000018C3299C4
		public override ShareDataObject DuplicateShareDataObject(ShareDataObject source); // 0x000000018C329870-0x000000018C329950
	}

	[Serializable]
	public class MeshData : ShareDataObject // TypeDefIndex: 82087
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x02640ADE
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
		public int VertexCount { get; } // 0x0000000182A819B0-0x0000000182A819C0 
		public int VertexHashCount { get; } // 0x000000018C32AD50-0x000000018C32AD64 
		public int WeightCount { get; } // 0x000000018C32AD64-0x000000018C32AD78 
		public int LineCount { get; } // 0x00000001872330A0-0x00000001872330B0 
		public int TriangleCount { get; } // 0x00000001872331A0-0x00000001872331B0 
		public int BoneCount { get; } // 0x0000000182271AE0-0x0000000182271AF0 
		public int ChildCount { get; } // 0x000000018C32AD10-0x000000018C32AD50 
	
		// Nested types
		[Serializable]
		public struct VertexWeight // TypeDefIndex: 82085
		{
			// Fields
			public Vector3 localPos; // 0x00
			public Vector3 localNor; // 0x0C
			public Vector3 localTan; // 0x18
			public int parentIndex; // 0x24
			public float weight; // 0x28
		}
	
		[Serializable]
		public class ChildData : IDataHash // TypeDefIndex: 82086
		{
			// Fields
			public int childDataHash; // 0x10
			public int vertexCount; // 0x14
			public uint[] vertexInfoList; // 0x18
			public VertexWeight[] vertexWeightList; // 0x20
			public int[] parentIndexList; // 0x28
	
			// Properties
			public int VertexCount { get; } // 0x0000000182971EE0-0x0000000182971EF0 
	
			// Constructors
			public ChildData(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public int GetDataHash(); // 0x000000018C320BD0-0x000000018C320C2C
		}
	
		// Constructors
		public MeshData(); // 0x00000001866F20D0-0x00000001866F2130
	
		// Methods
		public override int GetDataHash(); // 0x000000018C32A950-0x000000018C32AB54
		public override int GetVersion(); // 0x00000001845AFFB0-0x00000001845AFFC0
		public override Define.Error VerifyData(); // 0x0000000186AE16B0-0x0000000186AE16D0
		public Dictionary<int, List<uint>> GetVirtualToChildVertexDict(); // 0x000000018C32AB54-0x000000018C32AD10
		public List<int> ExtendSelection(List<int> originalSelection, bool extendNext, bool extendWeight); // 0x000000018C32A250-0x000000018C32A950
	}

	[Serializable]
	public class RenderMeshDeformer : BaseMeshDeformer, IBoneReplace // TypeDefIndex: 82090
	{
		// Fields
		private const int DATA_VERSION = 2; // Metadata: 0x02640ADF
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
		private bool IsChangePosition { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271B80-0x0000000182271B90 0x0000000182271B90-0x0000000182271BA0
		private bool IsChangeNormalTangent { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187248B20-0x0000000187248B30 0x00000001872510D0-0x00000001872510E0
		private bool IsChangeBoneWeights { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187251080-0x0000000187251090 0x00000001872510C0-0x00000001872510D0
		internal bool IsWriteSkip { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187240E10-0x0000000187240E20 0x0000000187240E30-0x0000000187240E40
		internal bool IsFasterWriteUpdate { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187251090-0x00000001872510A0 0x00000001872510E0-0x00000001872510F0
		internal bool IsWriteMeshPosition { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872510B0-0x00000001872510C0 0x0000000187251100-0x0000000187251110
		internal bool IsWriteMeshBoneWeight { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872510A0-0x00000001872510B0 0x00000001872510F0-0x0000000187251100
		public Mesh SharedMesh { get; } // 0x000000018226EBD0-0x000000018226EBE0 
		internal bool IsFasterWrite { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187243310-0x0000000187243320 0x0000000187243330-0x0000000187243360
		public bool IsRendererVisible { get; } // 0x000000018C32D888-0x000000018C32D8F4 
		internal bool HasNormal { get; } // 0x000000018C32D874-0x000000018C32D888 
	
		// Nested types
		public enum RecalculateMode // TypeDefIndex: 82088
		{
			None = 0,
			UpdateNormalPerFrame = 1,
			UpdateNormalAndTangentPerFrame = 2
		}
	
		public enum BoundsMode // TypeDefIndex: 82089
		{
			None = 0,
			ExpandedAtInitialization = 1
		}
	
		// Constructors
		public RenderMeshDeformer(); // 0x000000018C32D864-0x000000018C32D874
	
		// Methods
		public override int GetDataHash(); // 0x000000018C32B3C0-0x000000018C32B444
		public void OnValidate(); // 0x000000018C32D318-0x000000018C32D358
		protected override void OnInit(); // 0x000000018C32CA30-0x000000018C32D318
		protected override void OnActive(); // 0x000000018C32C828-0x000000018C32C938
		protected override void OnInactive(); // 0x000000018C32C938-0x000000018C32CA30
		public override void Dispose(); // 0x000000018C32B17C-0x000000018C32B270
		private void SetRecalculateNormalAndTangentMode(); // 0x000000018C32D644-0x000000018C32D720
		public override void ChangeUseUnityPhysics(bool sw); // 0x000000018C32B0F8-0x000000018C32B17C
		public void ChangeCalculation(bool sw); // 0x000000018C32B064-0x000000018C32B0F8
		public override bool IsMeshUse(); // 0x000000018C32C234-0x000000018C32C2AC
		public override bool IsActiveMesh(); // 0x000000018C32C1BC-0x000000018C32C234
		public override void AddUseMesh(object parent); // 0x000000018C32AD78-0x000000018C32B064
		public override void RemoveUseMesh(object parent); // 0x000000018C32D358-0x000000018C32D644
		internal override void MeshCalculation(int bufferIndex); // 0x000000018C32C2AC-0x000000018C32C6A0
		internal override void NormalWriting(int bufferIndex); // 0x000000018C32C6A0-0x000000018C32C828
		internal bool FasterWriting(int bufferIndex, ComputeShader compute, int kernel, int index, ref int maxVertexCount); // 0x000000018C32B270-0x000000018C32B3C0
		public void ChangeNormalTangentUpdateMode(); // 0x0000000187251070-0x0000000187251080
		public void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class;
		public HashSet<Transform> GetUsedBones(); // 0x000000018C32C0B8-0x000000018C32C1BC
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x000000018C32B444-0x000000018C32B7D4
		public override List<int> GetEditorTriangleList(); // 0x000000018C32B7D4-0x000000018C32B884
		public override List<int> GetEditorLineList(); // 0x0000000185829EC0-0x0000000185829ED0
		public List<int> GetEditorUseList(); // 0x000000018C32B884-0x000000018C32B908
		public override int GetVersion(); // 0x00000001845AFFB0-0x00000001845AFFC0
		public override Define.Error VerifyData(); // 0x000000018C32D720-0x000000018C32D864
		private Mesh GetTargetSharedMesh(); // 0x000000018C32BF80-0x000000018C32C0B8
		public override string GetInformation(); // 0x000000018C32B908-0x000000018C32BF80
	}

	[Serializable]
	public class VirtualMeshDeformer : BaseMeshDeformer, IBoneReplace // TypeDefIndex: 82092
	{
		// Fields
		private const int DATA_VERSION = 1; // Metadata: 0x02640AE5
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
		public float MergeVertexDistance { get; } // 0x00000001826DD0B0-0x00000001826DD0C0 
		public float MergeTriangleDistance { get; } // 0x00000001872352B0-0x00000001872352C0 
		public float SameSurfaceAngle { get; } // 0x00000001872352A0-0x00000001872352B0 
		public int MaxWeightCount { get; } // 0x000000018C330DF8-0x000000018C330E24 
		public float WeightPow { get; } // 0x000000018723E550-0x000000018723E560 
		public int RenderDeformerCount { get; } // 0x000000018C330E24-0x000000018C330E64 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0 // TypeDefIndex: 82091
		{
			// Fields
			public RenderMeshDeformer deformer; // 0x10
	
			// Constructors
			public __c__DisplayClass35_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetRenderMeshDeformerIndex_b__0(MagicaRenderDeformer d); // 0x000000018C33E534-0x000000018C33E564
		}
	
		// Constructors
		public VirtualMeshDeformer(); // 0x000000018C330C88-0x000000018C330DF8
	
		// Methods
		public override int GetDataHash(); // 0x000000018C32F0E8-0x000000018C32F1D0
		protected override void OnInit(); // 0x000000018C33019C-0x000000018C330698
		public override void Dispose(); // 0x000000018C32EEBC-0x000000018C32F0E8
		protected override void OnActive(); // 0x000000018C330030-0x000000018C3300D8
		protected override void OnInactive(); // 0x000000018C3300D8-0x000000018C33019C
		internal override void MeshCalculation(int bufferIndex); // 0x0000000186805BA0-0x0000000186805BB0
		internal override void NormalWriting(int bufferIndex); // 0x0000000186805BA0-0x0000000186805BB0
		public void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class;
		public HashSet<Transform> GetUsedBones(); // 0x000000018C32FECC-0x000000018C32FF40
		public BaseMeshDeformer GetDeformer(); // 0x0000000185BD80B0-0x0000000185BD80C0
		public MagicaRenderDeformer GetRenderDeformer(int index); // 0x000000018C32FDA8-0x000000018C32FDFC
		public int GetRenderMeshDeformerIndex(RenderMeshDeformer deformer); // 0x000000018C32FDFC-0x000000018C32FECC
		public List<MeshData> GetRenderDeformerMeshList(); // 0x000000018C32FC58-0x000000018C32FDA8
		public override bool IsMeshUse(); // 0x000000018C32FFB8-0x000000018C330030
		public override bool IsActiveMesh(); // 0x000000018C32FF40-0x000000018C32FFB8
		public override void AddUseMesh(object parent); // 0x000000018C32EA94-0x000000018C32EB78
		public override void RemoveUseMesh(object parent); // 0x000000018C330698-0x000000018C33077C
		public override bool AddUseVertex(int vindex, bool fix); // 0x000000018C32EB78-0x000000018C32EC14
		public override bool RemoveUseVertex(int vindex, bool fix); // 0x000000018C33077C-0x000000018C330818
		public override void ResetFuturePrediction(); // 0x000000018C330818-0x000000018C330878
		public override void ChangeUseUnityPhysics(bool sw); // 0x000000018C32ECA8-0x000000018C32ED2C
		public void ChangeCalculation(bool sw); // 0x000000018C32EC14-0x000000018C32ECA8
		public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x000000018C32F284-0x000000018C32F5A0
		public override List<int> GetEditorTriangleList(); // 0x000000018C32F5A0-0x000000018C32F654
		public override List<int> GetEditorLineList(); // 0x000000018C32F1D0-0x000000018C32F284
		public override int GetVersion(); // 0x00000001872328C0-0x00000001872328D0
		public override void CreateVerifyData(); // 0x000000018C32ED2C-0x000000018C32EEBC
		public override Define.Error VerifyData(); // 0x000000018C330878-0x000000018C330C88
		public override string GetInformation(); // 0x000000018C32F654-0x000000018C32FC58
	}

	public class ClampDistance2Constraint : PhysicsManagerConstraint // TypeDefIndex: 82097
	{
		// Fields
		private FixedChunkNativeArray<ClampDistance2Data> dataList; // 0x20
		private FixedChunkNativeArray<ClampDistance2RootInfo> rootInfoList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
		private FixedChunkNativeArray<int> rootTeamList; // 0x38
	
		// Nested types
		[Serializable]
		public struct ClampDistance2Data // TypeDefIndex: 82093
		{
			// Fields
			public int vertexIndex; // 0x00
			public int parentVertexIndex; // 0x04
			public float length; // 0x08
		}
	
		[Serializable]
		public struct ClampDistance2RootInfo // TypeDefIndex: 82094
		{
			// Fields
			public ushort startIndex; // 0x00
			public ushort dataLength; // 0x02
		}
	
		public struct GroupData // TypeDefIndex: 82095
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
		private struct ClampDistance2Job : IJobParallelFor // TypeDefIndex: 82096
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
			public void Execute(int rootIndex); // 0x000000018C331F70-0x000000018C3323C8
		}
	
		// Constructors
		public ClampDistance2Constraint(); // 0x0000000187236030-0x0000000187236040
	
		// Methods
		public override void Create(); // 0x000000018C33184C-0x000000018C3319A4
		public override void Release(); // 0x000000018C3319A4-0x000000018C331A4C
		public int AddGroup(int teamId, bool active, float minRatio, float maxRatio, float velocityInfluence, ClampDistance2Data[] dataArray, ClampDistance2RootInfo[] rootInfoArray); // 0x000000018C3313D8-0x000000018C33169C
		public override void RemoveTeam(int teamId); // 0x000000018C331A4C-0x000000018C331C4C
		public void ChangeParam(int teamId, bool active, float minRatio, float maxRatio, float velocityInfluence); // 0x000000018C33169C-0x000000018C33184C
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x000000018C331C4C-0x000000018C331F70
	}

	public class ClampDistanceConstraint : PhysicsManagerConstraint // TypeDefIndex: 82101
	{
		// Fields
		private FixedChunkNativeArray<ClampDistanceData> dataList; // 0x20
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
	
		// Nested types
		[Serializable]
		public struct ClampDistanceData // TypeDefIndex: 82098
		{
			// Fields
			public ushort vertexIndex; // 0x00
			public ushort targetVertexIndex; // 0x02
			public float length; // 0x04
	
			// Methods
			public bool IsValid(); // 0x000000018C332600-0x000000018C332614
		}
	
		public struct GroupData // TypeDefIndex: 82099
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
		private struct ClampDistanceJob : IJobParallelFor // TypeDefIndex: 82100
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
			public void Execute(int index); // 0x000000018C332614-0x000000018C332BB0
		}
	
		// Constructors
		public ClampDistanceConstraint(); // 0x0000000187236030-0x0000000187236040
	
		// Methods
		public override void Create(); // 0x0000000186937140-0x0000000186937250
		public override void Release(); // 0x000000018C332578-0x000000018C332600
		public int AddGroup(int teamId, bool active, float minRatio, float maxRatio, float velocityInfluence, ClampDistanceData[] dataArray, ReferenceDataIndex[] refDataArray); // 0x0000000185221FA0-0x00000001852221C0
		public override void RemoveTeam(int teamId); // 0x000000018674A0C0-0x000000018674A240
		public void ChangeParam(int teamId, bool active, float minRatio, float maxRatio, float velocityInfluence); // 0x000000018C3323C8-0x000000018C332578
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x00000001852202E0-0x0000000185220680
	}

	public class ClampPositionConstraint : PhysicsManagerConstraint // TypeDefIndex: 82104
	{
		// Fields
		public FixedNativeList<GroupData> groupList; // 0x20
	
		// Nested types
		public struct GroupData // TypeDefIndex: 82102
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public CurveParam limitLength; // 0x08
			public float3 axisRatio; // 0x18
			public float velocityInfluence; // 0x24
	
			// Methods
			public bool IsAxisCheck(); // 0x000000018C3383B0-0x000000018C3383D0
		}
	
		[BurstCompile]
		private struct ClampPositionJob : IJobParallelFor // TypeDefIndex: 82103
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
			public void Execute(int index); // 0x000000018C332EF8-0x000000018C333518
		}
	
		// Constructors
		public ClampPositionConstraint(); // 0x0000000187236030-0x0000000187236040
	
		// Methods
		public override void Create(); // 0x00000001871C4BF0-0x00000001871C4C70
		public override void Release(); // 0x000000018C332EB0-0x000000018C332EF8
		public int AddGroup(int teamId, bool active, BezierParam limitLength, float3 axisRatio, float velocityInfluence); // 0x000000018C332BB0-0x000000018C332CDC
		public override void RemoveTeam(int teamId); // 0x000000018688C900-0x000000018688C9E0
		public void ChangeParam(int teamId, bool active, BezierParam limitLength, float3 axisRatio, float velocityInfluence); // 0x000000018C332CDC-0x000000018C332EB0
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x000000018641BC30-0x000000018641BCB0
	}

	public class ClampRotationConstraint : PhysicsManagerConstraint // TypeDefIndex: 82109
	{
		// Fields
		private FixedChunkNativeArray<ClampRotationData> dataList; // 0x20
		private FixedChunkNativeArray<ClampRotationRootInfo> rootInfoList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
		private FixedChunkNativeArray<int> rootTeamList; // 0x38
		private FixedChunkNativeArray<float> lengthBuffer; // 0x40
	
		// Nested types
		[Serializable]
		public struct ClampRotationData // TypeDefIndex: 82105
		{
			// Fields
			public int vertexIndex; // 0x00
			public int parentVertexIndex; // 0x04
			public float3 localPos; // 0x08
			public quaternion localRot; // 0x14
	
			// Methods
			public bool IsValid(); // 0x000000018C333A8C-0x000000018C333A9C
		}
	
		[Serializable]
		public struct ClampRotationRootInfo // TypeDefIndex: 82106
		{
			// Fields
			public ushort startIndex; // 0x00
			public ushort dataLength; // 0x02
		}
	
		public struct GroupData // TypeDefIndex: 82107
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
		private struct ClampRotationJob : IJobParallelFor // TypeDefIndex: 82108
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
			public void Execute(int rootIndex); // 0x000000018C333A9C-0x000000018C33451C
		}
	
		// Constructors
		public ClampRotationConstraint(); // 0x0000000187236030-0x0000000187236040
	
		// Methods
		public override void Create(); // 0x0000000186935340-0x00000001869354E0
		public override void Release(); // 0x000000018C3339C0-0x000000018C333A8C
		public int AddGroup(int teamId, bool active, BezierParam maxAngle, float velocityInfluence, ClampRotationData[] dataArray, ClampRotationRootInfo[] rootInfoArray); // 0x000000018C333518-0x000000018C3337E0
		public override void RemoveTeam(int teamId); // 0x000000018688C820-0x000000018688C900
		public void ChangeParam(int teamId, bool active, BezierParam maxAngle, float velocityInfluence); // 0x000000018C3337E0-0x000000018C3339C0
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x000000018641BBB0-0x000000018641BC30
	}

	public class ColliderCollisionConstraint : PhysicsManagerConstraint // TypeDefIndex: 82111
	{
		// Nested types
		[BurstCompile]
		private struct CollisionJob : IJobParallelFor // TypeDefIndex: 82110
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
			public void Execute(int index); // 0x000000018C334EA0-0x000000018C335374
			private float SphereColliderDetection(ref float3 nextpos, float radius, int cindex, out float3 normal); // 0x000000018C335498-0x000000018C335648
			private float CapsuleColliderDetection(ref float3 nextpos, float radius, int cindex, float3 dir, out float3 normal); // 0x000000018C3349EC-0x000000018C334EA0
			private float PlaneColliderDetection(ref float3 nextpos, float radius, int cindex, out float3 normal); // 0x000000018C335374-0x000000018C335498
		}
	
		// Constructors
		public ColliderCollisionConstraint(); // 0x0000000187236030-0x0000000187236040
	
		// Methods
		public override void Create(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void RemoveTeam(int teamId); // 0x0000000186805BA0-0x0000000186805BB0
		public void ChangeParam(int teamId, bool useCollision); // 0x000000018C33451C-0x000000018C334570
		public override void Release(); // 0x0000000186805BA0-0x0000000186805BB0
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000185156060-0x00000001851565E0
	}

	public class ColliderExtrusionConstraint : PhysicsManagerConstraint // TypeDefIndex: 82113
	{
		// Nested types
		[BurstCompile]
		private struct CollisionExtrusionJob : IJobParallelFor // TypeDefIndex: 82112
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
			public void Execute(int index); // 0x000000018C334570-0x000000018C3349EC
		}
	
		// Constructors
		public ColliderExtrusionConstraint(); // 0x0000000187236030-0x0000000187236040
	
		// Methods
		public override void Create(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void RemoveTeam(int teamId); // 0x0000000186805BA0-0x0000000186805BB0
		public override void Release(); // 0x0000000186805BA0-0x0000000186805BB0
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000185156A00-0x0000000185156E20
	}

	public class CompositeRotationConstraint : PhysicsManagerConstraint // TypeDefIndex: 82118
	{
		// Fields
		private FixedChunkNativeArray<RotationData> dataList; // 0x20
		private FixedChunkNativeArray<RootInfo> rootInfoList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
		private FixedChunkNativeArray<int> rootTeamList; // 0x38
		private FixedChunkNativeArray<float> lengthBuffer; // 0x40
	
		// Nested types
		[Serializable]
		public struct RotationData // TypeDefIndex: 82114
		{
			// Fields
			public int vertexIndex; // 0x00
			public int parentVertexIndex; // 0x04
			public float3 localPos; // 0x08
			public quaternion localRot; // 0x14
	
			// Methods
			public bool IsValid(); // 0x000000018C333A8C-0x000000018C333A9C
		}
	
		[Serializable]
		public struct RootInfo // TypeDefIndex: 82115
		{
			// Fields
			public ushort startIndex; // 0x00
			public ushort dataLength; // 0x02
		}
	
		public struct GroupData // TypeDefIndex: 82116
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
		private struct RotationRootLineJob : IJobParallelFor // TypeDefIndex: 82117
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
			public void Execute(int rootIndex); // 0x000000018C33A7C0-0x000000018C33BE94
			private float GetRotRatio(float3 tv, float3 gravityVector, float gravity, float minRatio = 0.25f /* Metadata: 0x02640AE6 */, float maxRatio = 0.45f /* Metadata: 0x02640AEA */); // 0x000000018C331308-0x000000018C3313D8
		}
	
		// Constructors
		public CompositeRotationConstraint(); // 0x0000000187236030-0x0000000187236040
	
		// Methods
		public override void Create(); // 0x00000001869354E0-0x0000000186935680
		public override void Release(); // 0x000000018C33584C-0x000000018C335918
		public int AddGroup(int teamId, bool useClamp, BezierParam maxAngle, bool useRestore, BezierParam restorePower, float velocityInfluence, RotationData[] dataArray, RootInfo[] rootInfoArray); // 0x00000001852237F0-0x0000000185223A90
		public override void RemoveTeam(int teamId); // 0x00000001866F5830-0x00000001866F59F0
		public void ChangeParam(int teamId, bool useClamp, BezierParam maxAngle, bool useRestore, BezierParam restorePower, float velocityInfluence); // 0x000000018C335648-0x000000018C33584C
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000185220680-0x0000000185220B00
	}

	public class EdgeCollisionConstraint : PhysicsManagerConstraint // TypeDefIndex: 82123
	{
		// Fields
		private FixedChunkNativeArray<EdgeCollisionData> dataList; // 0x20
		private FixedChunkNativeArray<short> groupIndexList; // 0x28
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x30
		private FixedChunkNativeArray<float3> writeBuffer; // 0x38
		private FixedNativeList<GroupData> groupList; // 0x40
	
		// Nested types
		[Serializable]
		public struct EdgeCollisionData // TypeDefIndex: 82119
		{
			// Fields
			public ushort vindex0; // 0x00
			public ushort vindex1; // 0x02
			public int writeIndex0; // 0x04
			public int writeIndex1; // 0x08
	
			// Methods
			public bool IsValid(); // 0x000000018C338058-0x000000018C33806C
		}
	
		public struct GroupData // TypeDefIndex: 82120
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
		private struct EdgeCollisionCalcJob : IJobParallelFor // TypeDefIndex: 82121
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
			public void Execute(int index); // 0x000000018C3367B4-0x000000018C336C94
			private bool SphereColliderDetection(float3 nextpos0, float3 nextpos1, ref float3 corr0, ref float3 corr1, float radius, int cindex); // 0x000000018C336C94-0x000000018C336FDC
			private bool CapsuleColliderDetection(float3 nextpos0, float3 nextpos1, ref float3 corr0, ref float3 corr1, float radius, int cindex, float3 dir); // 0x000000018C336120-0x000000018C3367B4
		}
	
		[BurstCompile]
		private struct EdgeCollisionSumJob : IJobParallelFor // TypeDefIndex: 82122
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
			public void Execute(int pindex); // 0x000000018C33806C-0x000000018C3383B0
		}
	
		// Constructors
		public EdgeCollisionConstraint(); // 0x0000000187236030-0x0000000187236040
	
		// Methods
		public override void Create(); // 0x000000018C3374A8-0x000000018C33764C
		public override void Release(); // 0x000000018C33764C-0x000000018C337718
		public int AddGroup(int teamId, bool active, float edgeRadius, EdgeCollisionData[] dataArray, ReferenceDataIndex[] refDataArray, int writeBufferCount); // 0x000000018C336FDC-0x000000018C337314
		public override void RemoveTeam(int teamId); // 0x000000018C337718-0x000000018C337964
		public void ChangeParam(int teamId, bool active, float edgeRadius); // 0x000000018C337314-0x000000018C3374A8
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x000000018C337964-0x000000018C338058
	}

	public class PenetrationConstraint : PhysicsManagerConstraint // TypeDefIndex: 82127
	{
		// Fields
		private FixedChunkNativeArray<PenetrationData> dataList; // 0x20
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x28
		private FixedChunkNativeArray<float3> bonePenetrationDataList; // 0x30
		public FixedNativeList<GroupData> groupList; // 0x38
	
		// Nested types
		[Serializable]
		public struct PenetrationData // TypeDefIndex: 82124
		{
			// Fields
			public short vertexIndex; // 0x00
			public short colliderIndex; // 0x02
			public float3 localPos; // 0x04
			public float3 localDir; // 0x10
			public float distance; // 0x1C
	
			// Methods
			public bool IsValid(); // 0x000000018C338940-0x000000018C33894C
		}
	
		public struct GroupData // TypeDefIndex: 82125
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
		private struct PenetrationJob : IJobParallelFor // TypeDefIndex: 82126
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
			public void Execute(int index); // 0x000000018C33894C-0x000000018C3394CC
			private float3 InverseSpherePosition(ref PenetrationData data, float teamScale, float3 scaleDirection, float distance, int cindex, float cr); // 0x000000018C3395EC-0x000000018C3397C8
			private float3 InverseSpherePenetration(float3 c, float cr, float3 nextpos); // 0x000000018C3394CC-0x000000018C3395EC
		}
	
		// Constructors
		public PenetrationConstraint(); // 0x0000000187236030-0x0000000187236040
	
		// Methods
		public override void Create(); // 0x0000000186935680-0x00000001869357E0
		public override void Release(); // 0x000000018C338898-0x000000018C338940
		public int AddGroup(int teamId, bool active, ClothParams.PenetrationMode mode, BezierParam distance, BezierParam radius, float maxDepth, PenetrationData[] moveLimitDataList, ReferenceDataIndex[] refDataArray, float3[] bonePenetrationDataArray); // 0x000000018C3383D0-0x000000018C3386A0
		public override void RemoveTeam(int teamId); // 0x000000018688C740-0x000000018688C820
		public void ChangeParam(int teamId, bool active, BezierParam distance, BezierParam radius, float maxDepth); // 0x000000018C3386A0-0x000000018C338898
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000186436E60-0x0000000186436EE0
	}

	public class RestoreDistanceConstraint : PhysicsManagerConstraint // TypeDefIndex: 82131
	{
		// Fields
		public const int StructType = 0; // Metadata: 0x02640AEE
		public const int BendType = 1; // Metadata: 0x02640AEF
		public const int NearType = 2; // Metadata: 0x02640AF0
		public const int TypeCount = 3; // Metadata: 0x02640AF1
		private FixedChunkNativeArray<RestoreDistanceData>[] dataList; // 0x20
		private FixedChunkNativeArray<ReferenceDataIndex>[] refDataList; // 0x28
		public FixedNativeList<RestoreDistanceGroupData> groupList; // 0x30
	
		// Nested types
		[Serializable]
		public struct RestoreDistanceData // TypeDefIndex: 82128
		{
			// Fields
			public ushort vertexIndex; // 0x00
			public ushort targetVertexIndex; // 0x02
			public float length; // 0x04
	
			// Methods
			public bool IsValid(); // 0x000000018C332600-0x000000018C332614
		}
	
		public struct RestoreDistanceGroupData // TypeDefIndex: 82129
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
			public bool IsValid(int type); // 0x000000018C339B84-0x000000018C339BA0
			public CurveParam GetStiffness(int type); // 0x000000018C339B5C-0x000000018C339B84
			public ChunkData GetDataChunk(int type); // 0x0000000185221F70-0x0000000185221FA0
			public ChunkData GetRefChunk(int type); // 0x0000000185221F40-0x0000000185221F70
		}
	
		[BurstCompile]
		private struct DistanceJob : IJobParallelFor // TypeDefIndex: 82130
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
			public void Execute(int index); // 0x000000018C335918-0x000000018C336120
		}
	
		// Constructors
		public RestoreDistanceConstraint(); // 0x0000000187236030-0x0000000187236040
	
		// Methods
		public override void Create(); // 0x0000000186936F50-0x0000000186937140
		public override void Release(); // 0x000000018C339A64-0x000000018C339B5C
		public int AddGroup(int teamId, BezierParam mass, float velocityInfluence, BezierParam structStiffness, RestoreDistanceData[] structDataArray, ReferenceDataIndex[] structRefDataArray, bool useBend, BezierParam bendStiffness, RestoreDistanceData[] bendDataArray, ReferenceDataIndex[] bendRefDataArray, bool useNear, BezierParam nearStiffness, RestoreDistanceData[] nearDataArray, ReferenceDataIndex[] nearRefDataArray); // 0x0000000185221950-0x0000000185221C60
		public override void RemoveTeam(int teamId); // 0x0000000185221C60-0x0000000185221F40
		public void ChangeParam(int teamId, BezierParam mass, float velocityInfluence, BezierParam structStiffness, bool useBend, BezierParam bendStiffness, bool useNear, BezierParam nearStiffness); // 0x000000018C3397C8-0x000000018C339A64
		public override int GetIterationCount(); // 0x00000001828BC2B0-0x00000001828BC2C0
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000185220B00-0x0000000185221040
	}

	public class RestoreRotationConstraint : PhysicsManagerConstraint // TypeDefIndex: 82135
	{
		// Fields
		private FixedChunkNativeArray<RotationData> dataList; // 0x20
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
	
		// Nested types
		[Serializable]
		public struct RotationData // TypeDefIndex: 82132
		{
			// Fields
			public ushort vertexIndex; // 0x00
			public ushort targetVertexIndex; // 0x02
			public float3 localPos; // 0x04
	
			// Methods
			public bool IsValid(); // 0x000000018C332600-0x000000018C332614
		}
	
		public struct GroupData // TypeDefIndex: 82133
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
		private struct RotationJob : IJobParallelFor // TypeDefIndex: 82134
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
			public void Execute(int index); // 0x000000018C33A084-0x000000018C33A7C0
		}
	
		// Constructors
		public RestoreRotationConstraint(); // 0x0000000187236030-0x0000000187236040
	
		// Methods
		public override void Create(); // 0x00000001869357E0-0x00000001869358F0
		public override void Release(); // 0x000000018C339FFC-0x000000018C33A084
		public int AddGroup(int teamId, bool active, BezierParam power, float velocityInfluence, RotationData[] dataArray, ReferenceDataIndex[] refDataArray); // 0x000000018C339BA0-0x000000018C339E1C
		public override void RemoveTeam(int teamId); // 0x000000018688C660-0x000000018688C740
		public void ChangeParam(int teamId, bool active, BezierParam power, float velocityInfluence); // 0x000000018C339E1C-0x000000018C339FFC
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000186436FC0-0x0000000186437030
	}

	public class SpringConstraint : PhysicsManagerConstraint // TypeDefIndex: 82138
	{
		// Fields
		public FixedNativeList<GroupData> groupList; // 0x20
	
		// Nested types
		public struct GroupData // TypeDefIndex: 82136
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public float spring; // 0x08
		}
	
		[BurstCompile]
		private struct SpringJob : IJobParallelFor // TypeDefIndex: 82137
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
			public void Execute(int index); // 0x000000018C33C108-0x000000018C33C350
		}
	
		// Constructors
		public SpringConstraint(); // 0x0000000187236030-0x0000000187236040
	
		// Methods
		public override void Create(); // 0x00000001871C24F0-0x00000001871C2570
		public override void Release(); // 0x000000018C33C0C0-0x000000018C33C108
		public int AddGroup(int teamId, bool active, float spring); // 0x000000018C33BE94-0x000000018C33BF60
		public override void RemoveTeam(int teamId); // 0x000000018688C580-0x000000018688C660
		public void ChangeParam(int teamId, bool active, float spring); // 0x000000018C33BF60-0x000000018C33C0C0
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000186436F50-0x0000000186436FC0
	}

	public class TriangleBendConstraint : PhysicsManagerConstraint // TypeDefIndex: 82143
	{
		// Fields
		private FixedChunkNativeArray<TriangleBendData> dataList; // 0x20
		private FixedChunkNativeArray<short> groupIndexList; // 0x28
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x30
		private FixedChunkNativeArray<float3> writeBuffer; // 0x38
		private FixedNativeList<TriangleBendGroupData> groupList; // 0x40
	
		// Nested types
		[Serializable]
		public struct TriangleBendData // TypeDefIndex: 82139
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
			public bool IsValid(); // 0x000000018C33D67C-0x000000018C33D68C
			public bool IsPositionBend(); // 0x000000018C33D674-0x000000018C33D67C
		}
	
		public struct TriangleBendGroupData // TypeDefIndex: 82140
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
		private struct TriangleBendCalcJob : IJobParallelFor // TypeDefIndex: 82141
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
			public void Execute(int index); // 0x000000018C33C350-0x000000018C33D044
		}
	
		[BurstCompile]
		private struct TriangleBendSumJob : IJobParallelFor // TypeDefIndex: 82142
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
			public void Execute(int pindex); // 0x000000018C33D68C-0x000000018C33DA50
		}
	
		// Constructors
		public TriangleBendConstraint(); // 0x0000000187236030-0x0000000187236040
	
		// Methods
		public override void Create(); // 0x00000001869358F0-0x0000000186935A90
		public override void Release(); // 0x000000018C33D5A8-0x000000018C33D674
		public int AddGroup(int teamId, bool active, ClothParams.Algorithm algorithm, BezierParam stiffness, TriangleBendData[] dataArray, ReferenceDataIndex[] refDataArray, int writeBufferCount); // 0x000000018C33D044-0x000000018C33D3AC
		public override void RemoveTeam(int teamId); // 0x000000018688C2D0-0x000000018688C3C0
		public void ChangeParam(int teamId, bool active, BezierParam stiffness); // 0x000000018C33D3AC-0x000000018C33D5A8
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000186436DD0-0x0000000186436E60
	}

	public class TwistConstraint : PhysicsManagerConstraint // TypeDefIndex: 82147
	{
		// Fields
		private FixedChunkNativeArray<TwistData> dataList; // 0x20
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x28
		public FixedNativeList<GroupData> groupList; // 0x30
	
		// Nested types
		[Serializable]
		public struct TwistData // TypeDefIndex: 82144
		{
			// Fields
			public ushort vertexIndex0; // 0x00
			public ushort vertexIndex1; // 0x02
	
			// Methods
			public bool IsValid(); // 0x000000018C332600-0x000000018C332614
		}
	
		public struct GroupData // TypeDefIndex: 82145
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public float recoveryPower; // 0x08
			public ChunkData dataChunk; // 0x0C
			public ChunkData refChunk; // 0x1C
		}
	
		[BurstCompile]
		private struct TwistJob2 : IJobParallelFor // TypeDefIndex: 82146
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
			public void Execute(int index); // 0x000000018C33DE40-0x000000018C33E534
		}
	
		// Constructors
		public TwistConstraint(); // 0x0000000187236030-0x0000000187236040
	
		// Methods
		public override void Create(); // 0x0000000186936E40-0x0000000186936F50
		public override void Release(); // 0x000000018C33DDB8-0x000000018C33DE40
		public int AddGroup(int teamId, bool active, float recoveryPower, TwistData[] dataArray, ReferenceDataIndex[] refArray); // 0x000000018C33DA50-0x000000018C33DC38
		public override void RemoveTeam(int teamId); // 0x000000018688C3C0-0x000000018688C4A0
		public void ChangeParam(int teamId, bool active, float recoveryPower); // 0x000000018C33DC38-0x000000018C33DDB8
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x0000000186436EE0-0x0000000186436F50
	}

	public class VolumeConstraint : PhysicsManagerConstraint // TypeDefIndex: 82152
	{
		// Fields
		private FixedChunkNativeArray<VolumeData> dataList; // 0x20
		private FixedChunkNativeArray<short> groupIndexList; // 0x28
		private FixedChunkNativeArray<ReferenceDataIndex> refDataList; // 0x30
		private FixedChunkNativeArray<float3> writeBuffer; // 0x38
		private FixedNativeList<GroupData> groupList; // 0x40
	
		// Nested types
		[Serializable]
		public struct VolumeData // TypeDefIndex: 82148
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
			public bool IsValid(); // 0x000000018C33D67C-0x000000018C33D68C
		}
	
		public struct GroupData // TypeDefIndex: 82149
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
		private struct VolumeCalcJob : IJobParallelFor // TypeDefIndex: 82150
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
			public void Execute(int index); // 0x000000018C33E564-0x000000018C33F384
		}
	
		[BurstCompile]
		private struct VolumeSumJob : IJobParallelFor // TypeDefIndex: 82151
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
			public void Execute(int pindex); // 0x000000018C34AD2C-0x000000018C34B064
		}
	
		// Constructors
		public VolumeConstraint(); // 0x0000000187236030-0x0000000187236040
	
		// Methods
		public override void Create(); // 0x000000018C33F90C-0x000000018C33FAB0
		public override void Release(); // 0x000000018C33FAB0-0x000000018C33FB7C
		public int AddGroup(int teamId, bool active, BezierParam stretchStiffness, BezierParam shearStiffness, VolumeData[] dataArray, ReferenceDataIndex[] refDataArray, int writeBufferCount); // 0x000000018C33F384-0x000000018C33F6F8
		public override void RemoveTeam(int teamId); // 0x000000018C33FB7C-0x000000018C33FDB8
		public void ChangeParam(int teamId, bool active, BezierParam stretchStiffness, BezierParam shearStiffness); // 0x000000018C33F6F8-0x000000018C33F90C
		public override int GetIterationCount(); // 0x00000001828BC2B0-0x00000001828BC2C0
		public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle); // 0x000000018C33FDB8-0x000000018C340300
	}

	public struct CurveParam // TypeDefIndex: 82153
	{
		// Fields
		public float sval; // 0x00
		public float eval; // 0x04
		public float cval; // 0x08
		public int useCurve; // 0x0C
	
		// Constructors
		public CurveParam(float value); // 0x0000000187251200-0x0000000187251210
		public CurveParam(float svalue, float evalue); // 0x0000000187251210-0x0000000187251220
		public CurveParam(BezierParam bezier); // 0x0000000187835648-0x000000018783565C
	
		// Methods
		public void Setup(BezierParam bezier); // 0x0000000185D326D0-0x0000000185D327A0
		public float Evaluate(float t); // 0x000000018C34067C-0x000000018C3406E4
	}

	public abstract class BaseComponent : MonoBehaviour // TypeDefIndex: 82154
	{
		// Constructors
		protected BaseComponent(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public abstract ComponentType GetComponentType();
	}

	public enum ComponentType // TypeDefIndex: 82155
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

	public abstract class PhysicsManagerAccess : IDisposable // TypeDefIndex: 82156
	{
		// Fields
		protected MagicaPhysicsManager manager; // 0x10
	
		// Properties
		public UpdateTimeManager UpdateTime { get; } // 0x00000001852202C0-0x00000001852202E0 
		protected PhysicsManagerParticleData Particle { get; } // 0x0000000185154A80-0x0000000185154B00 
		protected PhysicsManagerBoneData Bone { get; } // 0x00000001851537E0-0x0000000185153860 
		protected PhysicsManagerMeshData Mesh { get; } // 0x0000000185154B80-0x0000000185154C00 
		protected PhysicsManagerTeamData Team { get; } // 0x0000000185154B00-0x0000000185154B80 
		protected PhysicsManagerWindData Wind { get; } // 0x0000000185220250-0x0000000185220290 
		protected PhysicsManagerComponent Component { get; } // 0x000000018C341AE4-0x000000018C341B04 
		protected PhysicsManagerCompute Compute { get; } // 0x0000000185220210-0x0000000185220250 
	
		// Constructors
		protected PhysicsManagerAccess(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void SetParent(MagicaPhysicsManager manager); // 0x0000000184FD2410-0x0000000184FD2420
		public abstract void Create();
		public abstract void Dispose();
	}

	public class PhysicsManagerBoneData : PhysicsManagerAccess // TypeDefIndex: 82165
	{
		// Fields
		public const byte Flag_Reset = 1; // Metadata: 0x02640B10
		public const byte Flag_Restore = 16; // Metadata: 0x02640B11
		public const byte Flag_Write = 32; // Metadata: 0x02640B12
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
		public bool hasBoneChanged { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184F560B0-0x0000000184F560C0 0x0000000184F56110-0x0000000184F56120
		private CustomSampler SamplerReadBoneScale { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BB00-0x000000018723BB10 0x0000000188D9C9D0-0x0000000188D9C9E4
		public int RestoreBoneCount { get; } // 0x000000018521E590-0x000000018521E5B0 
		public int ReadBoneCount { get; } // 0x000000018521ECA0-0x000000018521ECC0 
		public int WriteBoneCount { get; } // 0x0000000185152B90-0x0000000185152BC0 
	
		// Nested types
		[BurstCompile]
		private struct RestoreBoneJob : IJobParallelForTransform // TypeDefIndex: 82157
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
			public void Execute(int index, TransformAccess transform); // 0x000000018C34AB70-0x000000018C34AC58
		}
	
		[BurstCompile]
		private struct ReadBoneJob0 : IJobParallelForTransform // TypeDefIndex: 82158
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
			public void Execute(int index, TransformAccess transform); // 0x000000018C34A13C-0x000000018C34A48C
		}
	
		[BurstCompile]
		private struct ReadBoneJob1 : IJobParallelForTransform // TypeDefIndex: 82159
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
			public void Execute(int index, TransformAccess transform); // 0x000000018C34A48C-0x000000018C34A9A8
		}
	
		[BurstCompile]
		private struct ConvertWorldToLocalJob : IJobParallelFor // TypeDefIndex: 82160
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
			public void Execute(int index); // 0x000000018C3403C4-0x000000018C34067C
		}
	
		[BurstCompile]
		private struct WriteBontToTransformJob2 : IJobParallelForTransform // TypeDefIndex: 82161
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
			public void Execute(int index, TransformAccess transform); // 0x000000018C34B064-0x000000018C34B1C0
		}
	
		[BurstCompile]
		private struct CopyBoneJob0 : IJobParallelFor // TypeDefIndex: 82162
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
			public void Execute(int index); // 0x0000000187251110-0x0000000187251160
		}
	
		[BurstCompile]
		private struct CopyBoneJob1 : IJobParallelFor // TypeDefIndex: 82163
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> writeBoneIndexList; // 0x00
			[WriteOnly]
			public NativeArray<int> backWriteBoneIndexList; // 0x10
	
			// Methods
			public void Execute(int index); // 0x0000000187251160-0x0000000187251180
		}
	
		[BurstCompile]
		private struct CopyBoneJob2 : IJobParallelFor // TypeDefIndex: 82164
		{
			// Fields
			[ReadOnly]
			public NativeArray<byte> boneFlagList; // 0x00
			[WriteOnly]
			public NativeArray<byte> backBoneFlagList; // 0x10
	
			// Methods
			public void Execute(int index); // 0x0000000187251180-0x00000001872511A0
		}
	
		// Constructors
		public PhysicsManagerBoneData(); // 0x0000000186BA1AF0-0x0000000186BA1B70
	
		// Methods
		public override void Create(); // 0x0000000185D929B0-0x0000000185D92F00
		public override void Dispose(); // 0x000000018C341E34-0x000000018C34208C
		public int AddRestoreBone(Transform target, float3 lpos, quaternion lrot, int boneIndex); // 0x00000001853CE8E0-0x00000001853CE9D0
		public void RemoveRestoreBone(int restoreBoneIndex); // 0x00000001853CE2E0-0x00000001853CE380
		public int AddBone(Transform target, int pindex = -1 /* Metadata: 0x02640B0D */, bool addParent = false /* Metadata: 0x02640B0E */); // 0x0000000185484DC0-0x0000000185485230
		public bool RemoveBone(int boneIndex, int pindex = -1 /* Metadata: 0x02640B0F */); // 0x0000000185484AF0-0x0000000185484DC0
		public void ChangeUnityPhysicsCount(int boneIndex, bool sw); // 0x000000018C341B04-0x000000018C341B7C
		public void ResetFuturePrediction(int boneIndex); // 0x000000018C34208C-0x000000018C3420F4
		public void ResetBoneFromTransform(bool fixedUpdate); // 0x000000018521ECC0-0x000000018521EEC0
		public void ReadBoneFromTransform(); // 0x000000018521EEC0-0x000000018521F180
		public void ConvertWorldToLocal(); // 0x000000018521F180-0x000000018521F3D0
		public void WriteBoneToTransform(int bufferIndex); // 0x0000000185152920-0x0000000185152B90
		public void CopyBoneBuffer(); // 0x000000018C341B7C-0x000000018C341E34
	}

	public class PhysicsManagerComponent : PhysicsManagerAccess // TypeDefIndex: 82166
	{
		// Fields
		private readonly HashSet<CoreComponent> componentSet; // 0x18
		private HashSet<ParticleComponent> dataUpdateParticleSet; // 0x20
	
		// Properties
		public int ComponentCount { get; } // 0x000000018C342490-0x000000018C3424D0 
	
		// Constructors
		public PhysicsManagerComponent(); // 0x0000000186BA1BF0-0x0000000186BA1CB0
	
		// Methods
		public override void Create(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
		public List<CoreComponent> GetComponentList(); // 0x000000018C342254-0x000000018C3422C8
		public void ComponentAction(Action<CoreComponent> act); // 0x000000018C3420F4-0x000000018C342254
		public void UpdateComponentStatus(); // 0x000000018C34231C-0x000000018C342490
		public void AddComponent(CoreComponent comp); // 0x00000001853CA8F0-0x00000001853CA920
		public void RemoveComponent(CoreComponent comp); // 0x0000000186855790-0x00000001868557F0
		internal void ReserveDataUpdateParticleComponent(ParticleComponent comp); // 0x000000018C3422C8-0x000000018C34231C
		internal void DataUpdateParticleComponent(); // 0x0000000186190140-0x0000000186190240
	}

	public class PhysicsManagerCompute : PhysicsManagerAccess // TypeDefIndex: 82170
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
		public ClampPositionConstraint ClampPosition { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public ClampDistanceConstraint ClampDistance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public ClampRotationConstraint ClampRotation { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		public SpringConstraint Spring { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public RestoreDistanceConstraint RestoreDistance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
		public RestoreRotationConstraint RestoreRotation { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		public TriangleBendConstraint TriangleBend { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232F70-0x0000000187232F80 0x00000001856B9750-0x00000001856B9760
		public ColliderCollisionConstraint Collision { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232FA0-0x0000000187232FB0 0x0000000188800CB0-0x0000000188800CC0
		public PenetrationConstraint Penetration { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232F80-0x0000000187232F90 0x0000000186B19440-0x0000000186B19450
		public ColliderExtrusionConstraint ColliderExtrusion { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232FC0-0x0000000187232FD0 0x0000000188800CD0-0x0000000188800CE0
		public TwistConstraint Twist { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829CD170-0x00000001829CD180 0x0000000188800CC0-0x0000000188800CD0
		public CompositeRotationConstraint CompositeRotation { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001828D49D0-0x00000001828D49E0 0x00000001870EAAE0-0x00000001870EAAF0
		public RenderMeshWorker RenderMeshWorker { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182271B70-0x0000000182271B80 0x0000000188800C9C-0x0000000188800CB0
		public VirtualMeshWorker VirtualMeshWorker { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232C70-0x0000000187232C80 0x00000001887DE51C-0x00000001887DE530
		public MeshParticleWorker MeshParticleWorker { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232F60-0x0000000187232F70 0x0000000188800C88-0x0000000188800C9C
		public SpringMeshWorker SpringMeshWorker { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232FB0-0x0000000187232FC0 0x0000000185017110-0x0000000185017130
		public AdjustRotationWorker AdjustRotationWorker { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232F90-0x0000000187232FA0 0x0000000185017130-0x0000000185017150
		public LineWorker LineWorker { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232C80-0x0000000187232C90 0x0000000188D80C28-0x0000000188D80C3C
		public TriangleWorker TriangleWorker { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187236200-0x0000000187236210 0x0000000188D95540-0x0000000188D95554
		public BaseSkinningWorker BaseSkinningWorker { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723BB00-0x000000018723BB10 0x0000000188D9C9D0-0x0000000188D9C9E4
		public CustomSampler SamplerCalcMesh { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872354B0-0x00000001872354C0 0x0000000188D62F7C-0x0000000188D62F90
		public CustomSampler SamplerWriteMesh { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723C070-0x000000018723C080 0x0000000188DC4AE8-0x0000000188DC4AFC
		public JobHandle MasterJob { get; set; } // 0x000000018724C890-0x000000018724C8A0 0x0000000187233B40-0x0000000187233B50
		public int SwapIndex { get; } // 0x00000001872406B0-0x00000001872406C0 
	
		// Nested types
		[BurstCompile]
		private struct ForceAndVelocityJob : IJobParallelFor // TypeDefIndex: 82167
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
			public void Execute(int index); // 0x000000018C340EE0-0x000000018C3418F0
			private float3 Wind(int teamId, [IsReadOnly] in PhysicsManagerTeamData.TeamData teamData, [IsReadOnly] in float3 pos); // 0x000000018C3418F0-0x000000018C341AE4
		}
	
		[BurstCompile]
		private struct FixPositionJob : IJobParallelFor // TypeDefIndex: 82168
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
			public void Execute(int index); // 0x000000018C3406E4-0x000000018C340EE0
		}
	
		[BurstCompile]
		private struct PostUpdatePhysicsJob : IJobParallelFor // TypeDefIndex: 82169
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
			public void Execute(int index); // 0x000000018C349BA0-0x000000018C34A13C
		}
	
		// Constructors
		public PhysicsManagerCompute(); // 0x0000000186BA1CB0-0x0000000186BA1D80
	
		// Methods
		public override void Create(); // 0x0000000185D959B0-0x0000000185D96BD0
		public override void Dispose(); // 0x000000018C3424D0-0x000000018C3426FC
		public void RemoveTeam(int teamId); // 0x0000000185D96F10-0x0000000185D97140
		internal void UpdateRestoreBone(PhysicsTeam.TeamUpdateMode updateMode); // 0x000000018521E530-0x000000018521E590
		internal void UpdateReadBone(); // 0x0000000185152E20-0x0000000185152E80
		internal void UpdateTeamAlways(); // 0x0000000185152E80-0x0000000185152EC0
		internal void UpdateStartSimulation(UpdateTimeManager update); // 0x0000000185153290-0x00000001851537E0
		internal void UpdateCompleteSimulation(); // 0x0000000185677D90-0x0000000185677E30
		internal void UpdateWriteBone(); // 0x0000000185152DC0-0x0000000185152E20
		internal void MeshCalculation(); // 0x0000000185153A20-0x0000000185153AB0
		internal void NormalWritingMesh(); // 0x0000000185152D50-0x0000000185152DC0
		internal void UpdateReadWriteBone(); // 0x000000018C342704-0x000000018C342784
		internal void UpdateSyncBuffer(); // 0x000000018C342900-0x000000018C342A2C
		internal void UpdateSwapBuffer(); // 0x000000018C342784-0x000000018C342900
		public void InitJob(); // 0x0000000187251220-0x0000000187251230
		public void ScheduleJob(); // 0x000000018C3426FC-0x000000018C342704
		public void CompleteJob(); // 0x0000000185677E60-0x0000000185677EB0
		private void UpdatePhysics(int updateCount, int runCount, float updatePower, float updateDeltaTime); // 0x0000000185153BA0-0x0000000185154A80
		private void PostUpdatePhysics(float updateDeltaTime); // 0x00000001852210C0-0x0000000185221520
		private void WarmupWorker(); // 0x00000001862A44C0-0x00000001862A4540
	}

	public abstract class PhysicsManagerConstraint // TypeDefIndex: 82171
	{
		// Fields
		[Range(1f, 4f)]
		public int iteration; // 0x10
		[CompilerGenerated]
		private MagicaPhysicsManager _Manager_k__BackingField; // 0x18
	
		// Properties
		public MagicaPhysicsManager Manager { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		protected PhysicsManagerConstraint(); // 0x0000000187236030-0x0000000187236040
	
		// Methods
		public void Init(MagicaPhysicsManager manager); // 0x0000000185D96BD0-0x0000000185D96C00
		public abstract void Create();
		public abstract void RemoveTeam(int teamId);
		public abstract void Release();
		public virtual int GetIterationCount(); // 0x00000001828BC2B0-0x00000001828BC2C0
		public abstract JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle);
	}

	public class PhysicsManagerMeshData : PhysicsManagerAccess // TypeDefIndex: 82180
	{
		// Fields
		public const uint MeshFlag_Active = 1; // Metadata: 0x02640B13
		public const uint MeshFlag_Skinning = 4; // Metadata: 0x02640B14
		public const uint Meshflag_CalcNormal = 8; // Metadata: 0x02640B15
		public const uint Meshflag_CalcTangent = 16; // Metadata: 0x02640B16
		public const uint Meshflag_Pause = 32; // Metadata: 0x02640B17
		public const uint MeshFlag_ExistNormals = 65536; // Metadata: 0x02640B18
		public const uint MeshFlag_ExistTangents = 131072; // Metadata: 0x02640B1C
		public const uint MeshFlag_ExistWeights = 262144; // Metadata: 0x02640B20
		public const uint MeshFlag_UpdateUseVertexFront = 16777216; // Metadata: 0x02640B24
		public const uint MeshFlag_UpdateUseVertexBack = 33554432; // Metadata: 0x02640B28
		public const uint MeshFlag_FasterWrite = 67108864; // Metadata: 0x02640B2C
		public const uint MeshFlag_MeshLink = 268435456; // Metadata: 0x02640B30
		public FixedNativeList<SharedVirtualMeshInfo> sharedVirtualMeshInfoList; // 0x18
		public Dictionary<int, int> sharedVirtualMeshIdToIndexDict; // 0x20
		public FixedChunkNativeArray<float2> sharedVirtualUvList; // 0x28
		public FixedChunkNativeArray<uint> sharedVirtualVertexInfoList; // 0x30
		public FixedChunkNativeArray<MeshData.VertexWeight> sharedVirtualWeightList; // 0x38
		public FixedChunkNativeArray<int> sharedVirtualTriangleList; // 0x40
		public FixedChunkNativeArray<uint> sharedVirtualVertexToTriangleInfoList; // 0x48
		public FixedChunkNativeArray<int> sharedVirtualVertexToTriangleIndexList; // 0x50
		public const byte VirtualVertexFlag_Use = 1; // Metadata: 0x02640B34
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
		public const uint RenderVertexFlag_Use = 65536; // Metadata: 0x02640B35
		public const int MaxRenderMeshLinkCount = 4; // Metadata: 0x02640B39
		public FixedNativeList<RenderMeshInfo> renderMeshInfoList; // 0x110
		public const uint RenderStateFlag_Use = 1; // Metadata: 0x02640B3A
		public const uint RenderStateFlag_ExistNormal = 2; // Metadata: 0x02640B3B
		public const uint RenderStateFlag_ExistTangent = 4; // Metadata: 0x02640B3C
		public const uint RenderStateFlag_FasterWrite = 8; // Metadata: 0x02640B3D
		public const uint RenderStateFlag_DelayedCalculated = 256; // Metadata: 0x02640B3E
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
		public int SharedVirtualMeshCount { get; } // 0x000000018C349380-0x000000018C3493C8 
		public int VirtualMeshCount { get; } // 0x0000000185152D20-0x0000000185152D50 
		public int VirtualMeshVertexCount { get; } // 0x000000018C3494E8-0x000000018C349564 
		public int VirtualMeshTriangleCount { get; } // 0x000000018C34946C-0x000000018C3494E8 
		public int VirtualMeshVertexUseCount { get; } // 0x000000018C349564-0x000000018C3495EC 
		public int VirtualMeshUseCount { get; } // 0x000000018603D770-0x000000018603D7D0 
		public int VirtualMeshPauseCount { get; } // 0x000000018C3493C8-0x000000018C34946C 
		public int SharedRenderMeshCount { get; } // 0x000000018C349338-0x000000018C349380 
		public int SharedChildMeshCount { get; } // 0x000000018C3492F0-0x000000018C349338 
		public int RenderMeshCount { get; } // 0x000000018C348DD8-0x000000018C348E20 
		public int RenderMeshVertexCount { get; } // 0x000000018C3490D4-0x000000018C3491AC 
		public int RenderMeshUseCount { get; } // 0x000000018C348F6C-0x000000018C3490D4 
		public int RenderMeshVertexUseCount { get; } // 0x000000018C3491AC-0x000000018C3492F0 
		public int RenderMeshPauseCount { get; } // 0x000000018C348E20-0x000000018C348F6C 
	
		// Nested types
		public struct SharedVirtualMeshInfo // TypeDefIndex: 82172
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
	
		public struct VirtualMeshInfo // TypeDefIndex: 82173
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
			public bool IsFlag(uint flag); // 0x000000018C34AA6C-0x000000018C34AA74
			public void SetFlag(uint flag, bool sw); // 0x000000018C34AB44-0x000000018C34AB58
			public bool IsActive(); // 0x000000018783988C-0x0000000187839894
			public bool IsUse(); // 0x000000018C34AD14-0x000000018C34AD2C
			public bool IsPause(); // 0x0000000188A29B90-0x0000000188A29B98
		}
	
		public struct SharedChildMeshInfo // TypeDefIndex: 82174
		{
			// Fields
			public long cuid; // 0x00
			public int sharedVirtualMeshIndex; // 0x08
			public int virtualMeshIndex; // 0x0C
			public int meshUseCount; // 0x10
			public ChunkData vertexChunk; // 0x14
			public ChunkData weightChunk; // 0x24
		}
	
		public struct SharedRenderMeshInfo // TypeDefIndex: 82175
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
			public bool IsFlag(uint flag); // 0x000000018C34AC58-0x000000018C34AC60
			public void SetFlag(uint flag, bool sw); // 0x000000018C34AC68-0x000000018C34AC80
			public bool IsSkinning(); // 0x000000018C34AC60-0x000000018C34AC68
		}
	
		public struct RenderMeshInfo // TypeDefIndex: 82176
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
			public bool IsFlag(uint flag); // 0x000000018C34AA6C-0x000000018C34AA74
			public void SetFlag(uint flag, bool sw); // 0x000000018C34AB44-0x000000018C34AB58
			public bool IsActive(); // 0x000000018783988C-0x0000000187839894
			public bool IsUse(); // 0x000000018C34AA8C-0x000000018C34AA9C
			public bool IsLinkMesh(int index); // 0x000000018C34AA74-0x000000018C34AA8C
			public bool IsPause(); // 0x0000000188A29B90-0x0000000188A29B98
			public bool IsFasterWrite(); // 0x000000018C34AA60-0x000000018C34AA6C
			public bool IsSkinning(); // 0x0000000188A29B88-0x0000000188A29B90
			public bool AddLinkMesh(int renderMeshIndex, int childMeshVertexStart, int childMeshWeightStart, int virtualMeshVertexStart, int sharedVirtualMeshVertexStart); // 0x000000018C34A9A8-0x000000018C34AA60
			public bool RemoveLinkMesh(int renderMeshIndex, int childMeshVertexStart, int childMeshWeightStart, int virtualMeshVertexStart, int sharedVirtualMeshVertexStart); // 0x000000018C34AA9C-0x000000018C34AB44
		}
	
		public class RenderMeshState // TypeDefIndex: 82177
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
			public RenderMeshState(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public bool IsFlag(uint flag); // 0x0000000189255A10-0x0000000189255A18
			public void SetFlag(uint flag, bool sw); // 0x000000018C34AB58-0x000000018C34AB70
		}
	
		[BurstCompile]
		private struct CopyRenderBuffer : IJobParallelFor // TypeDefIndex: 82178
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
			public void Execute(int index); // 0x00000001872511A0-0x0000000187251200
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 82179
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<RenderMeshDeformer> __9__158_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018C34ACB0-0x000000018C34AD14
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _DispatchWriting_b__158_0(RenderMeshDeformer a, RenderMeshDeformer b); // 0x000000018C34AC80-0x000000018C34ACB0
		}
	
		// Constructors
		public PhysicsManagerMeshData(); // 0x0000000186BA1D80-0x0000000186BA1FF0
	
		// Methods
		public override void Create(); // 0x0000000186935D00-0x00000001869366E0
		public override void Dispose(); // 0x000000018C3453E8-0x000000018C3458AC
		public void AddMesh(BaseMeshDeformer bmesh); // 0x000000018C342A2C-0x000000018C342AA4
		public void RemoveMesh(BaseMeshDeformer bmesh); // 0x000000018C346590-0x000000018C346614
		public int AddVirtualMesh(int uid, int vertexCount, int weightCount, int boneCount, int triangleCount, int vertexToTriangleIndexCount, Transform transform); // 0x000000018C343AD0-0x000000018C34407C
		public bool IsEmptySharedVirtualMesh(int uid); // 0x000000018C345DC8-0x000000018C345E20
		public void SetSharedVirtualMeshData(int virtualMeshIndex, uint[] sharedVertexInfoList, MeshData.VertexWeight[] sharedWeightList, Vector2[] sharedUv, int[] sharedTriangles, uint[] vertexToTriangleInfoList, int[] vertexToTriangleIndexList); // 0x000000018C3483E4-0x000000018C348684
		public void RemoveVirtualMesh(int virtualMeshIndex); // 0x000000018C34738C-0x000000018C347858
		public bool ExistsVirtualMesh(int virtualMeshIndex); // 0x000000018C3458AC-0x000000018C345900
		public VirtualMeshInfo GetVirtualMeshInfo(int virtualMeshIndex); // 0x000000018C345B74-0x000000018C345BFC
		public bool IsUseVirtualMesh(int virtualMeshIndex); // 0x000000018C345F7C-0x000000018C34600C
		public bool IsActiveVirtualMesh(int virtualMeshIndex); // 0x000000018C345CB8-0x000000018C345D14
		public void SetVirtualMeshActive(int virtualMeshIndex, bool sw); // 0x000000018C348684-0x000000018C34876C
		public void AddUseVirtualMesh(int virtualMeshIndex); // 0x000000018C343690-0x000000018C34376C
		public void RemoveUseVirtualMesh(int virtualMeshIndex); // 0x000000018C346F4C-0x000000018C347028
		public bool AddUseVirtualVertex(int virtualMeshIndex, int vindex, bool fix); // 0x000000018C34376C-0x000000018C3438E0
		public bool RemoveUseVirtualVertex(int virtualMeshIndex, int vindex, bool fix); // 0x000000018C347028-0x000000018C34719C
		public void CopyToVirtualMeshWorldData(int virtualMeshIndex, Vector3[] vertices, Vector3[] normals, Vector3[] tangents); // 0x000000018C344D28-0x000000018C344F80
		public void AddVirtualMeshBone(int virtualMeshIndex, List<Transform> boneList); // 0x000000018C3438E0-0x000000018C343AD0
		public void RemoveVirtualMeshBone(int virtualMeshIndex); // 0x000000018C34719C-0x000000018C34738C
		public void ResetFuturePredictionVirtualMeshBone(int virtualMeshIndex); // 0x000000018C347858-0x000000018C347958
		public void ChangeVirtualMeshUseUnityPhysics(int virtualMeshIndex, bool sw); // 0x000000018C3441B8-0x000000018C344304
		public void SetVirtualMeshFlag(int virtualMeshIndex, uint flag, bool sw); // 0x000000018C34876C-0x000000018C348860
		public int AddSharedChildMesh(long cuid, int virtualMeshIndex, int vertexCount, int weightCount); // 0x000000018C34323C-0x000000018C3434D0
		public bool IsEmptySharedChildMesh(long cuid); // 0x000000018C345D14-0x000000018C345D70
		public void SetSharedChildMeshData(int sharedMeshIndex, uint[] sharedVertexInfoList, MeshData.VertexWeight[] sharedVertexWeightList); // 0x000000018C3482CC-0x000000018C3483E4
		public void RemoveSharedChildMesh(int sharedChildMeshIndex); // 0x000000018C346C18-0x000000018C346D8C
		public int AddRenderMesh(int uid, bool isSkinning, bool isFasterWrite, Vector3 baseScale, int vertexCount, int rendererBoneIndex, int boneWeightCount); // 0x000000018C342C18-0x000000018C34323C
		public void UpdateMeshState(int renderMeshIndex); // 0x000000018C348A94-0x000000018C348B4C
		public void AddRenderMeshBone(int renderMeshIndex, Transform rendererTransform); // 0x000000018C342AA4-0x000000018C342C18
		public bool IsEmptySharedRenderMesh(int uid); // 0x000000018C345D70-0x000000018C345DC8
		public void SetRenderSharedMeshData(int renderMeshIndex, bool isSkinning, Vector3[] sharedVertices, Vector3[] sharedNormals, Vector4[] sharedTangents, NativeArray<byte> sharedBonesPerVertex, NativeArray<BoneWeight1> sharedBoneWeights); // 0x000000018C347E4C-0x000000018C3482CC
		public void RemoveRenderMesh(int renderMeshIndex); // 0x000000018C346778-0x000000018C346C18
		public void RemoveRenderMeshBone(int renderMeshIndex); // 0x000000018C346614-0x000000018C346778
		public void ChangeRenderMeshUseUnityPhysics(int renderMeshIndex, bool sw); // 0x000000018C34407C-0x000000018C3441B8
		public bool IsUseRenderMesh(int renderMeshIndex); // 0x000000018C345F18-0x000000018C345F7C
		public bool IsActiveRenderMesh(int renderMeshIndex); // 0x000000018C345BFC-0x000000018C345CB8
		public void SetRenderMeshFlag(int renderMeshIndex, uint flag, bool sw); // 0x000000018C347CCC-0x000000018C347E4C
		public bool IsRenderMeshFlag(int renderMeshIndex, uint flag); // 0x000000018C345E20-0x000000018C345F18
		public void SetRenderMeshActive(int renderMeshIndex, bool sw); // 0x000000018C347AD8-0x000000018C347CCC
		public void AddUseRenderMesh(int renderMeshIndex); // 0x000000018C3434D0-0x000000018C343690
		public void RemoveUseRenderMesh(int renderMeshIndex); // 0x000000018C346D8C-0x000000018C346F4C
		public void LinkRenderMesh(int renderMeshIndex, int childMeshVertexStart, int childMeshWeightStart, int virtualMeshVertexStart, int sharedVirtualMeshVertexStart); // 0x000000018C34600C-0x000000018C346214
		public void UnlinkRenderMesh(int renderMeshIndex, int childMeshVertexStart, int childMeshWeightStart, int virtualMeshVertexStart, int sharedVirtualMeshVertexStart); // 0x000000018C348860-0x000000018C348A94
		internal void CopyToRenderMeshLocalPositionData(int renderMeshIndex, Mesh mesh, int bufferIndex); // 0x000000018C34461C-0x000000018C34470C
		internal void CopyToRenderMeshLocalNormalTangentData(int renderMeshIndex, Mesh mesh, int bufferIndex, bool normal, bool tangent); // 0x000000018C344488-0x000000018C34461C
		internal void CopyToRenderMeshBoneWeightData(int renderMeshIndex, Mesh mesh, Mesh sharedMesh, int bufferIndex); // 0x000000018C344304-0x000000018C344488
		internal void CopyToRenderMeshWorldData(int renderMeshIndex, Transform target, Vector3[] vertices, Vector3[] normals, Vector3[] tangents); // 0x000000018C34470C-0x000000018C344A7C
		internal List<int> GetVertexUseList(int renderMeshIndex); // 0x000000018C3459A8-0x000000018C345B74
		internal void SetDelayedCalculatedFlag(); // 0x000000018C347958-0x000000018C347AD8
		internal void ClearWritingList(); // 0x0000000185152680-0x0000000185152920
		internal void MeshCalculation(int bufferIndex); // 0x000000018C346214-0x000000018C346418
		internal void NormalWriting(int bufferIndex); // 0x000000018C346418-0x000000018C346590
		internal void CopyToRenderVertexBuffer(int renderMeshIndex, int bufferIndex, GraphicsBuffer vertexBuffer, bool normal, ComputeShader compute, int kernel, int index); // 0x000000018C344A7C-0x000000018C344D28
		internal void UpdateVertexBuffer(); // 0x000000018C348B4C-0x000000018C348DD8
		internal void FinishVertexBuffer(); // 0x0000000185677E30-0x0000000185677E60
		internal void FasterWriting(int bufferIndex); // 0x000000018C345900-0x000000018C3459A8
		private void DispatchWriting(int kernel, List<RenderMeshDeformer> rlist, int bufferIndex); // 0x000000018C344F80-0x000000018C3453E8
	}

	public class PhysicsManagerParticleData : PhysicsManagerAccess // TypeDefIndex: 82185
	{
		// Fields
		public const uint Flag_Enable = 1; // Metadata: 0x02640B40
		public const uint Flag_Kinematic = 2; // Metadata: 0x02640B41
		public const uint Flag_Hold = 4; // Metadata: 0x02640B42
		public const uint Flag_Collider = 16; // Metadata: 0x02640B43
		public const uint Flag_Plane = 32; // Metadata: 0x02640B44
		public const uint Flag_CapsuleX = 64; // Metadata: 0x02640B45
		public const uint Flag_CapsuleY = 128; // Metadata: 0x02640B46
		public const uint Flag_CapsuleZ = 256; // Metadata: 0x02640B48
		public const uint Flag_Box = 512; // Metadata: 0x02640B4A
		public const uint Flag_TriangleRotation = 1024; // Metadata: 0x02640B4C
		public const uint Flag_Transform_Read_Pos = 4096; // Metadata: 0x02640B4E
		public const uint Flag_Transform_Read_Rot = 8192; // Metadata: 0x02640B50
		public const uint Flag_Transform_Read_Base = 16384; // Metadata: 0x02640B52
		public const uint Flag_Transform_Read_Local = 32768; // Metadata: 0x02640B56
		public const uint Flag_Transform_Read_Scl = 65536; // Metadata: 0x02640B5A
		public const uint Flag_Transform_Write = 131072; // Metadata: 0x02640B5E
		public const uint Flag_Transform_Restore = 262144; // Metadata: 0x02640B62
		public const uint Flag_Transform_UnityPhysics = 524288; // Metadata: 0x02640B66
		public const uint Flag_Transform_Parent = 1048576; // Metadata: 0x02640B6A
		public const uint Flag_Step_Update = 16777216; // Metadata: 0x02640B6E
		public const uint Flag_Reset_Position = 33554432; // Metadata: 0x02640B72
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
		public int Count { get; } // 0x000000018521EC70-0x000000018521ECA0 
		public int Length { get; } // 0x00000001852210A0-0x00000001852210C0 
		public int ColliderCount { get; } // 0x000000018723D570-0x000000018723D580 
		public FixedChunkNativeArray<float3> InNextPosList { get; } // 0x0000000185221040-0x0000000185221060 
		public FixedChunkNativeArray<float3> OutNextPosList { get; } // 0x0000000185221060-0x0000000185221080 
		public FixedChunkNativeArray<quaternion> InNextRotList { get; } // 0x0000000185221080-0x00000001852210A0 
		public FixedChunkNativeArray<quaternion> OutNextRotList { get; } // 0x000000018C349B84-0x000000018C349BA0 
	
		// Nested types
		public struct ParticleFlag // TypeDefIndex: 82181
		{
			// Fields
			public uint flag; // 0x00
	
			// Constructors
			public ParticleFlag(params uint[] flags); // 0x00000001853CE3C0-0x00000001853CE400
	
			// Methods
			public bool IsFlag(uint flag); // 0x000000018C34AA6C-0x000000018C34AA74
			public void SetFlag(uint flag, bool sw); // 0x00000001853CEE90-0x00000001853CEEB0
			public bool IsValid(); // 0x000000018C351D48-0x000000018C351D50
			public void SetEnable(bool sw); // 0x00000001853CEE40-0x00000001853CEE60
			public bool IsFixed(); // 0x000000018C351D2C-0x000000018C351D34
			public bool IsMove(); // 0x000000018C351D34-0x000000018C351D3C
			public bool IsKinematic(); // 0x0000000188A5B578-0x0000000188A5B580
			public bool IsHold(); // 0x0000000188A29B88-0x0000000188A29B90
			public bool IsCollider(); // 0x00000001853CE8D0-0x00000001853CE8E0
			public bool IsReadTransform(); // 0x00000001853CEE20-0x00000001853CEE30
			public bool IsWriteTransform(); // 0x00000001853CEE60-0x00000001853CEE70
			public bool IsRestoreTransform(); // 0x00000001853CEE30-0x00000001853CEE40
			public bool IsUnityPhysics(); // 0x00000001853CEE70-0x00000001853CEE80
			public bool IsReadSclTransform(); // 0x000000018C351D3C-0x000000018C351D48
			public bool IsParentTransform(); // 0x00000001853CEE80-0x00000001853CEE90
		}
	
		[BurstCompile]
		private struct CopyBoneToParticleJob : IJobParallelFor // TypeDefIndex: 82182
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
			public void Execute(int index); // 0x000000018C34ECEC-0x000000018C34F604
		}
	
		[BurstCompile]
		private struct ResetParticleJob : IJobParallelFor // TypeDefIndex: 82183
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
			public void Execute(int index); // 0x000000018C357AD0-0x000000018C357CB4
		}
	
		[BurstCompile]
		private struct CopyParticleToBoneJob : IJobParallelFor // TypeDefIndex: 82184
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
			public void Execute(int index); // 0x000000018C34F604-0x000000018C34F980
		}
	
		// Constructors
		public PhysicsManagerParticleData(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override void Create(); // 0x00000001869366E0-0x0000000186936E40
		public override void Dispose(); // 0x000000018C3495EC-0x000000018C349908
		public ChunkData CreateParticle(uint flag, int team, float3 wpos, quaternion wrot, float depth, float3 radius, float3 targetLocalPos); // 0x00000001853CD220-0x00000001853CD970
		public ChunkData CreateParticle(int team, int count, Func<int, uint> funcFlag, Func<int, float3> funcWpos, Func<int, quaternion> funcWrot, Func<int, float> funcDepth, Func<int, float3> funcRadius, Func<int, float3> funcTargetLocalPos); // 0x00000001853CEF80-0x00000001853CF8D0
		public void RemoveParticle(ChunkData c); // 0x00000001853CE470-0x00000001853CE8D0
		public void SetEnable(ChunkData c, bool sw, Func<int, Transform> funcTarget, Func<int, float3> funcLpos, Func<int, quaternion> funcLrot); // 0x00000001853CE9D0-0x00000001853CEE20
		public void SetRadius(int index, float3 radius); // 0x000000018C349B14-0x000000018C349B84
		public void SetLocalPos(int index, Vector3 lpos); // 0x000000018C349A80-0x000000018C349B14
		public bool IsValid(int index); // 0x000000018C349958-0x000000018C3499C0
		public int GetTeamId(int index); // 0x000000018C349908-0x000000018C349958
		public void ResetFuturePredictionTransform(int index); // 0x000000018C349A10-0x000000018C349A80
		public void ResetFuturePredictionTransform(ChunkData c); // 0x000000018C3499C0-0x000000018C349A10
		public void SwitchingNextPosList(); // 0x0000000187251230-0x0000000187251250
		public void SwitchingNextRotList(); // 0x0000000187251250-0x0000000187251270
		public void UpdateBoneToParticle(); // 0x000000018521F3D0-0x000000018521F7A0
		public void UpdateResetParticle(); // 0x000000018521F7A0-0x000000018521FAD0
		public bool UpdateParticleToBone(); // 0x000000018521FAD0-0x000000018521FE00
	}

	public class PhysicsManagerTeamData : PhysicsManagerAccess // TypeDefIndex: 82193
	{
		// Fields
		public const uint Flag_Enable = 1; // Metadata: 0x02640B7A
		public const uint Flag_Interpolate = 2; // Metadata: 0x02640B7B
		public const uint Flag_FixedNonRotation = 4; // Metadata: 0x02640B7C
		public const uint Flag_AnimatedPose = 8; // Metadata: 0x02640B7D
		public const uint Flag_IgnoreClampPositionVelocity = 16; // Metadata: 0x02640B7E
		public const uint Flag_Collision = 32; // Metadata: 0x02640B7F
		public const uint Flag_AfterCollision = 64; // Metadata: 0x02640B80
		public const uint Flag_UpdatePhysics = 128; // Metadata: 0x02640B81
		public const uint Flag_Pause = 256; // Metadata: 0x02640B83
		public const uint Flag_Reset_WorldInfluence = 65536; // Metadata: 0x02640B85
		public const uint Flag_Reset_Position = 131072; // Metadata: 0x02640B89
		public const uint Flag_Reset_Keep = 524288; // Metadata: 0x02640B8D
		public const uint Flag_Wind = 1048576; // Metadata: 0x02640B91
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
		public int TeamCount { get; } // 0x000000018C354070-0x000000018C3540B8 
		public int TeamLength { get; } // 0x000000018C3540B8-0x000000018C3540F8 
		public int ActiveTeamCount { get; } // 0x0000000187233370-0x0000000187233380 
		public int ColliderCount { get; } // 0x000000018C353F2C-0x000000018C353F78 
		public int NormalUpdateCount { get; } // 0x0000000187233390-0x00000001872333A0 
		public int PhysicsUpdateCount { get; } // 0x0000000187233090-0x00000001872330A0 
		public int PauseCount { get; } // 0x000000018C353F78-0x000000018C354070 
	
		// Nested types
		public enum ForceMode // TypeDefIndex: 82186
		{
			None = 0,
			VelocityAdd = 1,
			VelocityChange = 2,
			VelocityAddWithoutMass = 10,
			VelocityChangeWithoutMass = 11
		}
	
		public struct TeamData // TypeDefIndex: 82187
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
			public bool IsActive(); // 0x000000018C35826C-0x000000018C358274
			public bool IsRunning(); // 0x000000018C3582A8-0x000000018C3582B4
			public bool IsUpdate(int runCount); // 0x000000018C3582B4-0x000000018C3582C0
			public bool IsInterpolate(); // 0x000000018C35827C-0x000000018C358284
			public bool IsPhysicsUpdate(); // 0x000000018C358290-0x000000018C35829C
			public bool IsFlag(uint flag); // 0x000000018C358274-0x000000018C35827C
			public void SetFlag(uint flag, bool sw); // 0x000000018C3582C0-0x000000018C3582D8
			public bool IsReset(); // 0x000000018C35829C-0x000000018C3582A8
			public bool IsPause(); // 0x000000018C358284-0x000000018C358290
		}
	
		public struct WorldInfluence // TypeDefIndex: 82188
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
	
		public struct WindInfo // TypeDefIndex: 82189
		{
			// Fields
			public int windCount; // 0x00
			public int4 windDataIndexList; // 0x04
			public float3x4 windDirectionList; // 0x14
			public float4 windMainList; // 0x44
		}
	
		[BurstCompile]
		private struct PreProcessTeamDataJob : IJobParallelFor // TypeDefIndex: 82190
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
			public void Execute(int teamId); // 0x000000018C35503C-0x000000018C355EFC
			private void UpdateTime(ref TeamData tdata, bool reset, float dtime); // 0x000000018C355EFC-0x000000018C355FEC
			private void Wind(ref TeamData tdata, float3 pos, int teamId); // 0x000000018C355FEC-0x000000018C3564DC
		}
	
		[BurstCompile]
		private struct PostProcessTeamDataJob : IJobParallelFor // TypeDefIndex: 82191
		{
			// Fields
			public int fixedUpdateCount; // 0x00
			public NativeArray<TeamData> teamData; // 0x08
			public NativeArray<WorldInfluence> teamWorldInfluenceList; // 0x18
	
			// Methods
			public void Execute(int index); // 0x000000018C354D34-0x000000018C35503C
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 82192
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<int> __9__76_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018C358CBC-0x000000018C358D20
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _ResetFuturePredictionCollidere_b__76_0(int pindex); // 0x000000018C358C60-0x000000018C358CBC
		}
	
		// Constructors
		public PhysicsManagerTeamData(); // 0x0000000186BA1B70-0x0000000186BA1BF0
	
		// Methods
		public override void Create(); // 0x0000000186D3F350-0x0000000186D3F610
		public override void Dispose(); // 0x000000018C3528A4-0x000000018C352A18
		public int CreateTeam(PhysicsTeam team, uint flag); // 0x00000001853C8D60-0x00000001853C9310
		public void RemoveTeam(int teamId); // 0x0000000185D96E00-0x0000000185D96F10
		public void SetEnable(int teamId, bool sw); // 0x00000001853CA540-0x00000001853CA570
		public bool IsValid(int teamId); // 0x000000018C352D10-0x000000018C352D1C
		public bool IsValidData(int teamId); // 0x0000000185D97140-0x0000000185D97170
		public bool IsActive(int teamId); // 0x000000018C352C4C-0x000000018C352D10
		public void SetFlag(int teamId, uint flag, bool sw); // 0x00000001853CA570-0x00000001853CA6D0
		public bool IsFlag(int teamId, uint flag); // 0x00000001853CCC40-0x00000001853CCCE0
		public void SetParticleChunk(int teamId, ChunkData chunk); // 0x00000001867DC2B0-0x00000001867DC3C0
		public void SetFriction(int teamId, float dynamicFriction, float staticFriction); // 0x00000001867C6FF0-0x00000001867C7100
		public void SetMass(int teamId, BezierParam mass); // 0x0000000185223C80-0x0000000185223CE0
		public void SetGravity(int teamId, BezierParam gravity); // 0x0000000185223C20-0x0000000185223C80
		public void SetGravityDirection(int teamId, float3 dir); // 0x00000001867343C0-0x00000001867345B0
		public void SetDrag(int teamId, BezierParam drag); // 0x0000000185223BC0-0x0000000185223C20
		public void SetMaxVelocity(int teamId, BezierParam maxVelocity); // 0x0000000185223CE0-0x0000000185223D40
		public void SetExternalForce(int teamId, float massInfluence, float windInfluence, float windRandomScale, float windSynchronization); // 0x0000000186798130-0x0000000186798270
		public void SetDepthInfluence(int teamId, BezierParam depthInfluence); // 0x0000000185223B60-0x0000000185223BC0
		public void SetWorldInfluence(int teamId, float maxSpeed, float maxRotatinSpeed, BezierParam moveInfluence, BezierParam rotInfluence, bool resetTeleport, float teleportDistance, float teleportRotation, float resetStabilizationTime, ClothParams.TeleportMode teleportMode, bool useClampRotation, BezierParam clampRotation); // 0x0000000185223D40-0x0000000185223F30
		private float CalcClampRotationLimit(bool useClampRotation, BezierParam clampRotation); // 0x0000000185223F30-0x0000000185223FA0
		public void SetWorldInfluence(int teamId, float maxSpeed, float maxRotationSpeed, BezierParam moveInfluence, BezierParam rotInfluence); // 0x000000018C353D64-0x000000018C353F2C
		public void SetAfterTeleport(int teamId, bool resetTeleport, float teleportDistance, float teleportRotation, ClothParams.TeleportMode teleportMode); // 0x000000018C3533B4-0x000000018C353548
		public void SetStabilizationTime(int teamId, float resetStabilizationTime); // 0x000000018C353970-0x000000018C353AD0
		public void ResetWorldInfluenceTarget(int teamId, Transform target); // 0x000000018C3531B0-0x000000018C3533B4
		public void SetClampRotation(int teamId, bool useClampRotation, BezierParam clampRotation); // 0x000000018C353548-0x000000018C3536D0
		public void SetSelfCollisionRange(int teamId, float range); // 0x000000018C353830-0x000000018C353970
		public void SetBoneIndex(int teamId, int boneIndex, Vector3 initScale); // 0x00000001853CA0F0-0x00000001853CA230
		internal void AddColliderParticle(int teamId, int particleIndex); // 0x00000001853CC090-0x00000001853CC2B0
		internal void RemoveColliderParticle(int teamId, int particleIndex); // 0x00000001853CC2B0-0x00000001853CC490
		internal void RemoveCollider(int teamId, ColliderComponent collider); // 0x000000018C352D1C-0x000000018C352DE8
		public void ResetFuturePredictionCollidere(int teamId); // 0x000000018C352DE8-0x000000018C352FBC
		public void AddSkinningBoneIndex(int teamId, List<Transform> boneList); // 0x000000018C352188-0x000000018C352580
		public void RemoveSkinningBoneIndex(int teamId); // 0x00000001853CAAD0-0x00000001853CAC10
		public void SetTimeScale(int teamId, float timeScale); // 0x000000018C353AD0-0x000000018C353C18
		public float GetTimeScale(int teamId); // 0x000000018C352B90-0x000000018C352C4C
		public void SetBlendRatio(int teamId, float blendRatio); // 0x00000001853C9E90-0x00000001853C9FB0
		public float GetBlendRatio(int teamId); // 0x000000018C352A18-0x000000018C352AD4
		public void SetOutPhysicsPoseBlendRatio(int teamId, float blendRatio); // 0x00000001853C9D20-0x00000001853C9E40
		public float GetOutPhysicsPoseBlendRatio(int teamId); // 0x000000018C352AD4-0x000000018C352B90
		public void SetImpactForce(int teamId, float3 force, ForceMode mode); // 0x000000018C3536D0-0x000000018C353830
		public void ResetStabilizationTime(int teamId, float resetStabilizationTime = -1f /* Metadata: 0x02640B76 */); // 0x000000018C352FBC-0x000000018C3531B0
		public void SetUpdateMode(int teamId, PhysicsTeam.TeamUpdateMode updateMode); // 0x000000018C353C18-0x000000018C353D64
		public void ChangeUseUnityPhysics(int teamId, bool sw); // 0x000000018C352690-0x000000018C3528A4
		private void ChangeParticleUseUnityPhysics(int pindex, bool unityPhysics); // 0x000000018C352580-0x000000018C352690
		internal void ChangeBoneFlag(int teamId, PhysicsTeam.TeamCullingMode cullingMode, bool isCalculation); // 0x000000018521D6C0-0x000000018521D8A0
		internal void EarlyUpdateTeamAlways(); // 0x0000000185158E00-0x0000000185159070
		internal void PreUpdateTeamAlways(); // 0x0000000185159070-0x0000000185159600
		internal int CalcMaxUpdateCount(int ups, float deltaTime, float physicsDeltaTime, float updateDeltaTime); // 0x0000000185221520-0x0000000185221910
		internal void PreUpdateTeamData(float deltaTime, float physicsDeltaTime, float updateDeltaTime, int ups, int maxUpdateCount); // 0x000000018521FF40-0x0000000185220210
		internal void PostUpdateTeamData(); // 0x000000018521FE00-0x000000018521FF40
	}

	public class PhysicsManagerWindData : PhysicsManagerAccess // TypeDefIndex: 82198
	{
		// Fields
		public const uint Flag_Enable = 1; // Metadata: 0x02640B9A
		public const uint Flag_Addition = 2; // Metadata: 0x02640B9B
		public FixedNativeList<WindData> windDataList; // 0x18
	
		// Properties
		public int Count { get; } // 0x000000018C354928-0x000000018C354974 
	
		// Nested types
		public enum WindType // TypeDefIndex: 82194
		{
			None = 0,
			Direction = 1,
			Area = 2
		}
	
		public enum ShapeType // TypeDefIndex: 82195
		{
			Box = 0,
			Sphere = 1
		}
	
		public enum DirectionType // TypeDefIndex: 82196
		{
			OneDirection = 0,
			Radial = 1
		}
	
		public struct WindData // TypeDefIndex: 82197
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
			public bool IsFlag(uint flag); // 0x000000018C34AA6C-0x000000018C34AA74
			public void SetFlag(uint flag, bool sw); // 0x000000018C34AB44-0x000000018C34AB58
			public void SetEnable(bool sw); // 0x00000001853CEE40-0x00000001853CEE60
			public bool IsActive(); // 0x000000018C351D48-0x000000018C351D50
		}
	
		// Constructors
		public PhysicsManagerWindData(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override void Create(); // 0x00000001871C2D70-0x00000001871C2DF0
		public override void Dispose(); // 0x000000018C354464-0x000000018C3544A8
		public int CreateWind(WindType windType, ShapeType shapeType, float3 areaSize, bool addition, float main, float turbulence, float frequency, float3 direction, DirectionType directinType, float areaVolume, float areaLength, BezierParam attenuation); // 0x000000018C354324-0x000000018C354464
		public void RemoveWind(int windId); // 0x000000018C35450C-0x000000018C354564
		public void SetEnable(int windId, bool sw, Transform target); // 0x000000018C354564-0x000000018C3546E4
		public bool IsActive(int windId); // 0x000000018C3544A8-0x000000018C35450C
		public void SetFlag(int windId, uint flag, bool sw); // 0x000000018C3546E4-0x000000018C3547B8
		public void SetParameter(int windId, float3 areaSize, bool addition, float main, float turbulence, float frequency, float3 direction, float areaVolume, float areaLength, BezierParam attenuation); // 0x000000018C3547B8-0x000000018C354928
		internal static float3 CalcWindForce(float time, float2 noiseBasePos, float3 mainDir, float main, float turbulence, float frequency, float randomScale); // 0x000000018C3540F8-0x000000018C354324
	}

	public abstract class PhysicsManagerWorker // TypeDefIndex: 82199
	{
		// Fields
		[CompilerGenerated]
		private MagicaPhysicsManager _Manager_k__BackingField; // 0x10
	
		// Properties
		public MagicaPhysicsManager Manager { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
	
		// Constructors
		protected PhysicsManagerWorker(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected virtual void Start(); // 0x0000000186805BA0-0x0000000186805BB0
		public void Init(MagicaPhysicsManager manager); // 0x0000000185D97170-0x0000000185D971A0
		public abstract void Create();
		public abstract void RemoveGroup(int group);
		public abstract void Release();
		public abstract void Warmup();
		public abstract JobHandle PreUpdate(JobHandle jobHandle);
		public abstract JobHandle PostUpdate(JobHandle jobHandle);
	}

	public abstract class ColliderComponent : ParticleComponent // TypeDefIndex: 82200
	{
		// Fields
		[SerializeField]
		protected bool isGlobal; // 0x28
		[SerializeField]
		private Vector3 center; // 0x2C
	
		// Properties
		public Vector3 Center { get; set; } // 0x0000000187233AD0-0x0000000187233AF0 0x000000018C34ECD4-0x000000018C34ECEC
	
		// Constructors
		protected ColliderComponent(); // 0x0000000186AC0130-0x0000000186AC0140
	
		// Methods
		protected override void OnInit(); // 0x0000000186D440C0-0x0000000186D440E0
		protected override void OnDispose(); // 0x00000001853CB4C0-0x00000001853CB980
		public override int GetDataHash(); // 0x000000018C34EC88-0x000000018C34ECD4
		public abstract bool CalcNearPoint(Vector3 pos, out Vector3 p, out Vector3 dir, out Vector3 d, bool skinning);
		public Vector3 CalcLocalPos(Vector3 pos); // 0x000000018C34EB78-0x000000018C34EC88
		public Vector3 CalcLocalDir(Vector3 dir); // 0x000000018C34EB0C-0x000000018C34EB78
		public ChunkData CreateColliderParticle(int teamId); // 0x00000001853CC000-0x00000001853CC090
		public void RemoveColliderParticle(int teamId); // 0x00000001853CCF40-0x00000001853CD030
		protected abstract ChunkData CreateColliderParticleReal(int teamId);
	}

	[AddComponentMenu("MagicaCloth/MagicaCapsuleCollider")]
	[HelpURL("https://magicasoft.jp/magica-cloth-capsule-collider/")]
	public class MagicaCapsuleCollider : ColliderComponent // TypeDefIndex: 82202
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
		public Axis AxisMode { get; set; } // 0x00000001829600C0-0x00000001829600D0 0x000000018C350FF0-0x000000018C350FFC
		public float Length { get; set; } // 0x00000001872330B0-0x00000001872330C0 0x000000018C351008-0x000000018C351014
		public float StartRadius { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x000000018C351014-0x000000018C351020
		public float EndRadius { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x000000018C350FFC-0x000000018C351008
	
		// Nested types
		public enum Axis // TypeDefIndex: 82201
		{
			X = 0,
			Y = 1,
			Z = 2
		}
	
		// Constructors
		public MagicaCapsuleCollider(); // 0x0000000186AC0140-0x0000000186AC0210
	
		// Methods
		public override ComponentType GetComponentType(); // 0x000000018723AE30-0x000000018723AE40
		private void OnValidate(); // 0x000000018C350FC4-0x000000018C350FF0
		internal override void DataUpdate(); // 0x000000018C350AB0-0x000000018C350DE4
		public override int GetDataHash(); // 0x000000018C350DE4-0x000000018C350EE8
		protected override ChunkData CreateColliderParticleReal(int teamId); // 0x00000001853CB0E0-0x00000001853CB1E0
		private uint GetCapsuleFlag(); // 0x00000001853CB1E0-0x00000001853CB200
		public Vector3 GetLocalDir(); // 0x000000018C350EE8-0x000000018C350F2C
		public Vector3 GetLocalUp(); // 0x000000018C350F2C-0x000000018C350F68
		public float GetScale(); // 0x000000018C350F68-0x000000018C350FC4
		public override bool CalcNearPoint(Vector3 pos, out Vector3 p, out Vector3 dir, out Vector3 d, bool skinning); // 0x000000018C350334-0x000000018C350AB0
	}

	[AddComponentMenu("MagicaCloth/MagicaPlaneCollider")]
	[HelpURL("https://magicasoft.jp/magica-cloth-plane-collider/")]
	public class MagicaPlaneCollider : ColliderComponent // TypeDefIndex: 82203
	{
		// Constructors
		public MagicaPlaneCollider(); // 0x0000000186AC0130-0x0000000186AC0140
	
		// Methods
		public override ComponentType GetComponentType(); // 0x000000018723AE50-0x000000018723AE60
		private void OnValidate(); // 0x000000018C350FC4-0x000000018C350FF0
		internal override void DataUpdate(); // 0x000000018C3511EC-0x000000018C3513C8
		protected override ChunkData CreateColliderParticleReal(int teamId); // 0x0000000186D480B0-0x0000000186D481C0
		public override bool CalcNearPoint(Vector3 pos, out Vector3 p, out Vector3 dir, out Vector3 d, bool skinning); // 0x000000018C351020-0x000000018C3511EC
	}

	[AddComponentMenu("MagicaCloth/MagicaSphereCollider")]
	[HelpURL("https://magicasoft.jp/magica-cloth-sphere-collider/")]
	public class MagicaSphereCollider : ColliderComponent // TypeDefIndex: 82204
	{
		// Fields
		[Range(0.001f, 0.5f)]
		[SerializeField]
		private float radius; // 0x38
	
		// Properties
		public float Radius { get; set; } // 0x0000000187235380-0x0000000187235390 0x000000018C351964-0x000000018C351970
	
		// Constructors
		public MagicaSphereCollider(); // 0x000000018C351954-0x000000018C351964
	
		// Methods
		public override ComponentType GetComponentType(); // 0x000000018723AE10-0x000000018723AE20
		private void OnValidate(); // 0x000000018C350FC4-0x000000018C350FF0
		internal override void DataUpdate(); // 0x000000018C3516AC-0x000000018C3518EC
		public override int GetDataHash(); // 0x000000018C3518EC-0x000000018C351954
		protected override ChunkData CreateColliderParticleReal(int teamId); // 0x000000018C351580-0x000000018C3516AC
		public float GetScale(); // 0x00000001889D4FA8-0x00000001889D4FD8
		public override bool CalcNearPoint(Vector3 pos, out Vector3 p, out Vector3 dir, out Vector3 d, bool skinning); // 0x000000018C3513C8-0x000000018C351580
	}

	public abstract class ParticleComponent : BaseComponent, IDataHash // TypeDefIndex: 82205
	{
		// Fields
		protected Dictionary<int, ChunkData> particleDict; // 0x18
		protected RuntimeStatus status; // 0x20
	
		// Properties
		public RuntimeStatus Status { get; } // 0x000000018225E800-0x000000018225E810 
		public int CenterParticleIndex { get; } // 0x000000018C351CB4-0x000000018C351D2C 
	
		// Constructors
		protected ParticleComponent(); // 0x00000001855E0620-0x00000001855E06C0
	
		// Methods
		public abstract int GetDataHash();
		protected virtual void Start(); // 0x00000001853CAC10-0x00000001853CAC20
		public virtual void OnEnable(); // 0x00000001853CB200-0x00000001853CB230
		public virtual void OnDisable(); // 0x00000001853CB230-0x00000001853CB260
		protected virtual void OnDestroy(); // 0x0000000186AFE6A0-0x0000000186AFE6D0
		private void Init(); // 0x00000001853CAC20-0x00000001853CAD30
		protected void OnUpdateStatus(); // 0x00000001853CCBC0-0x00000001853CCC00
		public virtual bool VerifyData(); // 0x00000001851A4410-0x00000001851A4420
		protected virtual void OnInit(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnDispose(); // 0x00000001853CAD40-0x00000001853CAD70
		protected virtual void OnUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnActive(); // 0x000000018C351B60-0x000000018C351B68
		protected virtual void OnInactive(); // 0x000000018C351B68-0x000000018C351B70
		protected void EnableParticle(); // 0x00000001853CAD70-0x00000001853CAEE0
		protected void DisableParticle(); // 0x00000001853CB980-0x00000001853CBB00
		protected void EnableTeamParticle(int teamId); // 0x00000001853CD030-0x00000001853CD170
		protected void DisableTeamParticle(int teamId); // 0x00000001853CDAE0-0x00000001853CDC20
		protected void ReserveDataUpdate(); // 0x000000018C351B70-0x000000018C351BEC
		internal virtual void DataUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		internal void UpdateStatus(); // 0x00000001853CCC20-0x00000001853CCC40
		protected ChunkData CreateParticle(uint flag, int teamId, float depth, float3 radius, float3 localPos); // 0x00000001853CCCE0-0x00000001853CCF40
		protected void RemoveTeamParticle(int teamId); // 0x00000001853CD170-0x00000001853CD220
		protected void RemoveParticle(); // 0x00000001853CAEE0-0x00000001853CB0E0
		protected Transform UserTransform(int vindex); // 0x0000000186EB8B50-0x0000000186EB8B60
		protected float3 UserTransformLocalPosition(int vindex); // 0x000000018C351BEC-0x000000018C351C58
		protected quaternion UserTransformLocalRotation(int vindex); // 0x000000018C351C58-0x000000018C351CB4
		[CompilerGenerated]
		private object _Init_b__11_0(); // 0x0000000185BD80B0-0x0000000185BD80C0
	}

	public abstract class PhysicsTeam : CoreComponent // TypeDefIndex: 82209
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
		public int TeamId { get; } // 0x0000000187233600-0x0000000187233610 
		public PhysicsTeamData TeamData { get; } // 0x0000000182986470-0x0000000182986480 
		public ChunkData ParticleChunk { get; } // 0x000000018724F4E0-0x000000018724F4F0 
		public Transform InfluenceTarget { get; set; } // 0x0000000187232FC0-0x0000000187232FD0 0x0000000188800CD0-0x0000000188800CE0
		public float UserBlendWeight { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187839DAC-0x0000000187839DC4
		public float UserPhysicsBlendWeight { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x000000018C354D1C-0x000000018C354D34
		public bool SyncBlendWeightToPoseBlendWeight { get; set; } // 0x000000018223CB60-0x000000018223CB70 0x000000018223CB70-0x000000018223CB80
		public float UserCloseThreshold { get; set; } // 0x0000000187234790-0x00000001872347A0 0x000000018C354D04-0x000000018C354D1C
		public TeamUpdateMode UpdateMode { get; protected set; } // 0x0000000187233280-0x0000000187233290 0x00000001854CCF30-0x00000001854CCF40
		public TeamCullingMode CullingMode { get; set; } // 0x00000001872336F0-0x0000000187233700 0x0000000187233700-0x0000000187233710
		public TeamSkinningMode SkinningMode { get; set; } // 0x00000001872331A0-0x00000001872331B0 0x0000000185B8E8A0-0x0000000185B8EB10
		internal bool UseAnimatedPose { get; } // 0x00000001853C9D10-0x00000001853C9D20 
	
		// Nested types
		public enum TeamUpdateMode // TypeDefIndex: 82206
		{
			Normal = 0,
			UnityPhysics = 1
		}
	
		public enum TeamCullingMode // TypeDefIndex: 82207
		{
			Reset = 0,
			Pause = 10,
			Off = 100
		}
	
		public enum TeamSkinningMode // TypeDefIndex: 82208
		{
			None = 0,
			UserAnimation = 1
		}
	
		// Constructors
		protected PhysicsTeam(); // 0x00000001855E0530-0x00000001855E05B0
	
		// Methods
		public override int GetDataHash(); // 0x000000018C354BE8-0x000000018C354C08
		protected override void OnInit(); // 0x00000001853C8D00-0x00000001853C8D60
		protected override void OnDispose(); // 0x0000000185D96C20-0x0000000185D96CA0
		protected override void OnUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void OnActive(); // 0x00000001853CA4F0-0x00000001853CA540
		protected override void OnInactive(); // 0x00000001853CA490-0x00000001853CA4F0
		public bool IsActive(); // 0x000000018C354C08-0x000000018C354C88
		public bool IsValid(); // 0x000000018C354C88-0x000000018C354D04
		public ChunkData CreateParticle(int team, int count, Func<int, uint> funcFlag, Func<int, float3> funcWpos, Func<int, quaternion> funcWrot, Func<int, float> funcDepth, Func<int, float3> funcRadius, Func<int, float3> funcTargetLocalPos); // 0x00000001852234C0-0x00000001852235B0
		public void RemoveAllParticle(); // 0x0000000185D96DA0-0x0000000185D96E00
		public void EnableParticle(Func<int, Transform> funcTarget, Func<int, float3> funcLpos, Func<int, quaternion> funcLrot); // 0x00000001853CA6D0-0x00000001853CA760
		public void DisableParticle(Func<int, Transform> funcTarget, Func<int, float3> funcLpos, Func<int, quaternion> funcLrot); // 0x00000001853CA760-0x00000001853CA800
		public override Define.Error VerifyData(); // 0x000000018783C578-0x000000018783C580
	}

	[Serializable]
	public class PhysicsTeamData : IDataHash // TypeDefIndex: 82210
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
		public int ColliderCount { get; } // 0x000000018C354BA8-0x000000018C354BE8 
		public List<ColliderComponent> ColliderList { get; } // 0x00000001829260F0-0x0000000182926100 
		public List<ColliderComponent> PenetrationIgnoreColliderList { get; } // 0x0000000182234E30-0x0000000182234E40 
		public bool MergeAvatarCollider { get; } // 0x0000000182246E50-0x0000000182246E60 
	
		// Constructors
		public PhysicsTeamData(); // 0x00000001855E0750-0x00000001855E0810
	
		// Methods
		public int GetDataHash(); // 0x000000018C354A18-0x000000018C354A54
		public void Init(int teamId); // 0x00000001853CBC10-0x00000001853CBD90
		public void Dispose(int teamId); // 0x00000001853CBD90-0x00000001853CC000
		public void AddCollider(ColliderComponent collider); // 0x000000018C354974-0x000000018C354A18
		public void RemoveCollider(ColliderComponent collider); // 0x000000018C354A54-0x000000018C354B6C
		internal void UpdateStatus(); // 0x00000001853CBB00-0x00000001853CBC10
		public void ValidateColliderList(); // 0x000000018C354B6C-0x000000018C354BA8
	}

	public class AdjustRotationWorker : PhysicsManagerWorker // TypeDefIndex: 82214
	{
		// Fields
		private const int AdjustMode_Fixed = 0; // Metadata: 0x02640BAE
		private const int AdjustMode_XYMove = 1; // Metadata: 0x02640BAF
		private const int AdjustMode_XZMove = 2; // Metadata: 0x02640BB0
		private const int AdjustMode_YZMove = 3; // Metadata: 0x02640BB1
		private FixedChunkNativeArray<AdjustRotationData> dataList; // 0x18
		public FixedNativeList<GroupData> groupList; // 0x20
		private ExNativeMultiHashMap<int, int> particleMap; // 0x28
	
		// Nested types
		[Serializable]
		public struct AdjustRotationData // TypeDefIndex: 82211
		{
			// Fields
			public int keyIndex; // 0x00
			public int targetIndex; // 0x04
			public float3 localPos; // 0x08
	
			// Methods
			public bool IsValid(); // 0x000000018C34C804-0x000000018C34C814
		}
	
		public struct GroupData // TypeDefIndex: 82212
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public int adjustMode; // 0x08
			public float3 axisRotationPower; // 0x0C
			public ChunkData chunk; // 0x18
		}
	
		[BurstCompile]
		private struct AdjustRotationJob : IJobParallelFor // TypeDefIndex: 82213
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
			public void Execute(int index); // 0x000000018C34C814-0x000000018C34CC60
		}
	
		// Constructors
		public AdjustRotationWorker(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override void Create(); // 0x0000000186D45E00-0x0000000186D45F10
		public override void Release(); // 0x000000018C34D08C-0x000000018C34D114
		public int AddGroup(int teamId, bool active, int adjustMode, float3 axisRotationPower, AdjustRotationData[] dataArray); // 0x000000018C34CC60-0x000000018C34CEF8
		public override void RemoveGroup(int teamId); // 0x000000018679B3B0-0x000000018679B4B0
		public void ChangeParam(int teamId, bool active, int adjustMode, float3 axisRotationPower); // 0x000000018C34CEF8-0x000000018C34D08C
		public override void Warmup(); // 0x0000000186805BA0-0x0000000186805BB0
		public override JobHandle PreUpdate(JobHandle jobHandle); // 0x0000000187233D20-0x0000000187233D30
		public override JobHandle PostUpdate(JobHandle jobHandle); // 0x000000018603D320-0x000000018603D380
	}

	public class BaseSkinningWorker : PhysicsManagerWorker // TypeDefIndex: 82218
	{
		// Fields
		private FixedChunkNativeArray<BaseSkinningData> dataList; // 0x18
		private FixedChunkNativeArray<float4x4> bindPoseList; // 0x20
		public FixedNativeList<GroupData> groupList; // 0x28
	
		// Nested types
		[Serializable]
		public struct BaseSkinningData // TypeDefIndex: 82215
		{
			// Fields
			public float3 localPos; // 0x00
			public float3 localNor; // 0x0C
			public float3 localTan; // 0x18
			public int4 boneIndices; // 0x24
			public float4 weights; // 0x34
			public short weightCount; // 0x44
	
			// Methods
			public bool IsValid(); // 0x000000018C34D114-0x000000018C34D120
		}
	
		public struct GroupData // TypeDefIndex: 82216
		{
			// Fields
			public int teamId; // 0x00
			public int active; // 0x04
			public int updateFixed; // 0x08
			public ChunkData dataChunk; // 0x0C
			public ChunkData bindPoseChunk; // 0x1C
		}
	
		[BurstCompile]
		private struct BaseSkinningJob : IJobParallelFor // TypeDefIndex: 82217
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
			public void Execute(int index); // 0x000000018C34D120-0x000000018C34DAF4
		}
	
		// Constructors
		public BaseSkinningWorker(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override void Create(); // 0x0000000186FCBAC0-0x0000000186FCBBD0
		public override void Release(); // 0x000000018C34DE30-0x000000018C34DEB8
		public int AddGroup(int teamId, bool active, bool updateFixed, BaseSkinningData[] skinningDataList, float4x4[] skinningBindPoseList); // 0x000000018C34DAF4-0x000000018C34DCD8
		public override void RemoveGroup(int teamId); // 0x000000018688C9E0-0x000000018688CAC0
		public void ChangeParam(int teamId, bool updateFixed); // 0x000000018C34DCD8-0x000000018C34DE30
		public override void Warmup(); // 0x0000000186805BA0-0x0000000186805BB0
		public override JobHandle PreUpdate(JobHandle jobHandle); // 0x000000018603D2C0-0x000000018603D320
		public override JobHandle PostUpdate(JobHandle jobHandle); // 0x0000000187233D20-0x0000000187233D30
	}

	public class LineWorker : PhysicsManagerWorker // TypeDefIndex: 82223
	{
		// Fields
		private FixedChunkNativeArray<LineRotationData> dataList; // 0x18
		private FixedChunkNativeArray<LineRotationRootInfo> rootInfoList; // 0x20
		public FixedNativeList<GroupData> groupList; // 0x28
		private FixedChunkNativeArray<int> rootTeamList; // 0x30
	
		// Nested types
		[Serializable]
		public struct LineRotationData // TypeDefIndex: 82219
		{
			// Fields
			public int vertexIndex; // 0x00
			public int childCount; // 0x04
			public int childStartDataIndex; // 0x08
			public float3 localPos; // 0x0C
			public quaternion localRot; // 0x18
		}
	
		[Serializable]
		public struct LineRotationRootInfo // TypeDefIndex: 82220
		{
			// Fields
			public ushort startIndex; // 0x00
			public ushort dataLength; // 0x02
		}
	
		public struct GroupData // TypeDefIndex: 82221
		{
			// Fields
			public int teamId; // 0x00
			public int avarage; // 0x04
			public ChunkData dataChunk; // 0x08
			public ChunkData rootInfoChunk; // 0x18
		}
	
		[BurstCompile]
		private struct LineRotationJob : IJobParallelFor // TypeDefIndex: 82222
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
			public void Execute(int rootIndex); // 0x000000018C34F980-0x000000018C35012C
		}
	
		// Constructors
		public LineWorker(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override void Create(); // 0x0000000186935A90-0x0000000186935BF0
		public override void Release(); // 0x000000018C35028C-0x000000018C350334
		public int AddGroup(int teamId, bool avarage, LineRotationData[] dataArray, LineRotationRootInfo[] rootInfoArray); // 0x00000001852235B0-0x00000001852237F0
		public override void RemoveGroup(int teamId); // 0x000000018670D3F0-0x000000018670D590
		public void ChangeParam(int teamId, bool avarage); // 0x000000018C35012C-0x000000018C35028C
		public override void Warmup(); // 0x0000000186805BA0-0x0000000186805BB0
		public override JobHandle PreUpdate(JobHandle jobHandle); // 0x0000000187233D20-0x0000000187233D30
		public override JobHandle PostUpdate(JobHandle jobHandle); // 0x000000018603D500-0x000000018603D770
	}

	public class MeshParticleWorker : PhysicsManagerWorker // TypeDefIndex: 82227
	{
		// Fields
		private ExNativeMultiHashMap<int, int> vertexToParticleMap; // 0x18
		private FixedNativeListWithCount<int> vertexToParticleList; // 0x20
		private Dictionary<int, List<CreateData>> groupCreateDict; // 0x28
	
		// Nested types
		private struct CreateData // TypeDefIndex: 82224
		{
			// Fields
			public int vertexIndex; // 0x00
			public int particleIndex; // 0x04
		}
	
		[BurstCompile]
		private struct VertexToParticleJob : IJobParallelFor // TypeDefIndex: 82225
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
			public void Execute(int index); // 0x000000018C358D20-0x000000018C358E9C
		}
	
		[BurstCompile]
		private struct ParticleToVertexJob : IJobParallelFor // TypeDefIndex: 82226
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
			public void Execute(int index); // 0x000000018C351D50-0x000000018C352188
		}
	
		// Constructors
		public MeshParticleWorker(); // 0x0000000185D974C0-0x0000000185D97540
	
		// Methods
		public override void Create(); // 0x0000000186D45F10-0x0000000186D45FF0
		public override void Release(); // 0x000000018C351AF8-0x000000018C351B60
		public void Add(int group, int vindex, int pindex); // 0x000000018C351970-0x000000018C351AF8
		public override void RemoveGroup(int group); // 0x0000000186A86940-0x0000000186A86AC0
		public override void Warmup(); // 0x0000000186805BA0-0x0000000186805BB0
		public override JobHandle PreUpdate(JobHandle jobHandle); // 0x000000018603D260-0x000000018603D2C0
		public override JobHandle PostUpdate(JobHandle jobHandle); // 0x000000018603D200-0x000000018603D260
	}

	public class RenderMeshWorker : PhysicsManagerWorker // TypeDefIndex: 82231
	{
		// Nested types
		[BurstCompile]
		private struct CalcVertexUseFlagJob : IJobParallelFor // TypeDefIndex: 82228
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
			public void Execute(int rmindex); // 0x000000018C34DEB8-0x000000018C34E44C
		}
	
		[BurstCompile]
		private struct CollectLocalPositionNormalTangentForEachMeshJob : IJobParallelFor // TypeDefIndex: 82229
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
			public void Execute(int rmindex); // 0x000000018C34E44C-0x000000018C34E7B0
		}
	
		[BurstCompile]
		private struct CollectLocalPositionNormalTangentForEachVertexJob : IJobParallelFor // TypeDefIndex: 82230
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
			public void Execute(int vindex); // 0x000000018C34E7B0-0x000000018C34EB0C
		}
	
		// Constructors
		public RenderMeshWorker(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override void Create(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void Release(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void RemoveGroup(int group); // 0x0000000186805BA0-0x0000000186805BB0
		private bool IsPerformMeshProcessForEachParticle(); // 0x000000018C357A48-0x000000018C357AD0
		public override void Warmup(); // 0x000000018603D0C0-0x000000018603D140
		public override JobHandle PreUpdate(JobHandle jobHandle); // 0x0000000187233D20-0x0000000187233D30
		public override JobHandle PostUpdate(JobHandle jobHandle); // 0x000000018603D470-0x000000018603D500
		private static void CollectionVertex([IsReadOnly] in PhysicsManagerMeshData.RenderMeshInfo r_minfo, [IsReadOnly] in NativeArray<uint> sharedChildVertexInfoList, [IsReadOnly] in NativeArray<MeshData.VertexWeight> sharedChildVertexWeightList, [IsReadOnly] in NativeArray<float3> virtualPosList, [IsReadOnly] in NativeArray<quaternion> virtualRotList, [IsReadOnly] in float3 tpos, [IsReadOnly] in quaternion trot, [IsReadOnly] in float3 tscl, [IsReadOnly] in quaternion itrot, float scaleRatio, [IsReadOnly] in float3 scaleDirection, bool calcNormal, bool calcTangent, int vindex, int i, uint flag, bool isFasterWrite, ref NativeArray<float3> renderPosList, ref NativeArray<float3> renderNormalList, ref NativeArray<float3> renderPosArray, ref NativeArray<float3> renderNomalArray, ref NativeArray<float4> renderTangentList); // 0x000000018C3564DC-0x000000018C357A48
	}

	public class SpringMeshWorker : PhysicsManagerWorker // TypeDefIndex: 82234
	{
		// Fields
		private ExNativeMultiHashMap<int, SpringData> springMap; // 0x18
		private FixedNativeListWithCount<int> springVertexList; // 0x20
		private Dictionary<int, List<int>> groupIndexDict; // 0x28
	
		// Nested types
		public struct SpringData // TypeDefIndex: 82232
		{
			// Fields
			public int particleIndex; // 0x00
			public float weight; // 0x04
		}
	
		[BurstCompile]
		private struct SpringJob : IJobParallelFor // TypeDefIndex: 82233
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
			public void Execute(int index); // 0x000000018C357CB4-0x000000018C358074
		}
	
		// Constructors
		public SpringMeshWorker(); // 0x00000001855DB800-0x00000001855DB880
	
		// Methods
		public override void Create(); // 0x0000000186D45FF0-0x0000000186D460D0
		public override void Release(); // 0x000000018C358204-0x000000018C35826C
		public void Add(int group, int vertexIndex, int particleIndex, float weight); // 0x000000018C358074-0x000000018C358204
		public override void RemoveGroup(int group); // 0x0000000186A86AC0-0x0000000186A86C30
		public override void Warmup(); // 0x0000000186805BA0-0x0000000186805BB0
		public override JobHandle PreUpdate(JobHandle jobHandle); // 0x0000000187233D20-0x0000000187233D30
		public override JobHandle PostUpdate(JobHandle jobHandle); // 0x000000018603D1A0-0x000000018603D200
	}

	public class TriangleWorker : PhysicsManagerWorker // TypeDefIndex: 82238
	{
		// Fields
		private FixedChunkNativeArray<TriangleRotationData> triangleDataList; // 0x18
		private FixedChunkNativeArray<int> triangleIndexList; // 0x20
		public FixedNativeList<GroupData> groupList; // 0x28
	
		// Nested types
		[Serializable]
		public struct TriangleRotationData // TypeDefIndex: 82235
		{
			// Fields
			public int targetIndex; // 0x00
			public int triangleCount; // 0x04
			public int triangleStartIndex; // 0x08
			public quaternion localRot; // 0x0C
	
			// Methods
			public bool IsValid(); // 0x0000000185B1CEC0-0x0000000185B1CED0
		}
	
		public struct GroupData // TypeDefIndex: 82236
		{
			// Fields
			public int teamId; // 0x00
			public ChunkData triangleDataChunk; // 0x04
			public ChunkData triangleIndexChunk; // 0x14
		}
	
		[BurstCompile]
		private struct TriangleRotationJob : IJobParallelFor // TypeDefIndex: 82237
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
			public void Execute(int index); // 0x000000018C3582D8-0x000000018C3589B4
		}
	
		// Constructors
		public TriangleWorker(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override void Create(); // 0x0000000186935BF0-0x0000000186935D00
		public override void Release(); // 0x000000018C358BD8-0x000000018C358C60
		public int AddGroup(int teamId, TriangleRotationData[] dataArray, int[] indexArray); // 0x000000018C3589B4-0x000000018C358BD8
		public override void RemoveGroup(int teamId); // 0x000000018688C4A0-0x000000018688C580
		public override void Warmup(); // 0x0000000186805BA0-0x0000000186805BB0
		public override JobHandle PreUpdate(JobHandle jobHandle); // 0x0000000187233D20-0x0000000187233D30
		public override JobHandle PostUpdate(JobHandle jobHandle); // 0x000000018603D140-0x000000018603D1A0
	}

	public class VirtualMeshWorker : PhysicsManagerWorker // TypeDefIndex: 82243
	{
		// Nested types
		[BurstCompile]
		private struct ReadMeshPositionJob : IJobParallelFor // TypeDefIndex: 82239
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
			public void Execute(int vindex); // 0x000000018C36AC0C-0x000000018C36B5A8
		}
	
		[BurstCompile]
		private struct CalcMeshTriangleNormalTangentJob : IJobParallelFor // TypeDefIndex: 82240
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
			public void Execute(int tindex); // 0x000000018C359DF0-0x000000018C35A3DC
		}
	
		[BurstCompile]
		private struct CalcVertexNormalTangentFromTriangleJob : IJobParallelFor // TypeDefIndex: 82241
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
			public void Execute(int vindex); // 0x000000018C35A3DC-0x000000018C35A6C8
		}
	
		[BurstCompile]
		private struct CalcMeshTriangleNormalTangentForEachMeshJob : IJobParallelFor // TypeDefIndex: 82242
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
			public void Execute(int mindex); // 0x000000018C3594B4-0x000000018C359DF0
		}
	
		// Constructors
		public VirtualMeshWorker(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override void Create(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void Release(); // 0x0000000186805BA0-0x0000000186805BB0
		public override void RemoveGroup(int group); // 0x0000000186805BA0-0x0000000186805BB0
		private bool IsPerformMeshProcessForEachParticle(); // 0x000000018C36D838-0x000000018C36D8C0
		public override void Warmup(); // 0x0000000186805BA0-0x0000000186805BB0
		public override JobHandle PreUpdate(JobHandle jobHandle); // 0x000000018603D380-0x000000018603D3F0
		public override JobHandle PostUpdate(JobHandle jobHandle); // 0x000000018603D3F0-0x000000018603D470
	}

	public class AutoMove : MonoBehaviour // TypeDefIndex: 82244
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
		public AutoMove(); // 0x000000018C3590CC-0x000000018C35910C
	
		// Methods
		private void Start(); // 0x000000018C358F34-0x000000018C358F74
		private void Update(); // 0x000000018C358F74-0x000000018C3590CC
		public void OnMoveButton(); // 0x000000018C358F0C-0x000000018C358F34
	}

	public class AutoRotate : MonoBehaviour // TypeDefIndex: 82245
	{
		// Fields
		[SerializeField]
		private Vector3 rotateAngle; // 0x18
		[Range(0.1f, 5f)]
		[SerializeField]
		private float interval; // 0x24
		private float time; // 0x28
	
		// Constructors
		public AutoRotate(); // 0x000000018C3591C8-0x000000018C3591F8
	
		// Methods
		private void Start(); // 0x0000000186805BA0-0x0000000186805BB0
		private void Update(); // 0x000000018C35910C-0x000000018C3591C8
		public void OnMoveButton(); // 0x000000018C358F0C-0x000000018C358F34
	}

	public class BlastWaveController : MonoBehaviour // TypeDefIndex: 82247
	{
		// Fields
		public MagicaAreaWind wind; // 0x18
		public float attenuationStartTime; // 0x20
		public float attenuationTime; // 0x24
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__3 : IEnumerator<object> // TypeDefIndex: 82246
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public BlastWaveController __4__this; // 0x20
			private float _main_5__2; // 0x28
			private float _time_5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__3(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018C36D2DC-0x000000018C36D478
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018C36D478-0x000000018C36D4C4
		}
	
		// Constructors
		public BlastWaveController(); // 0x000000018722E6C0-0x000000018722E6F0
	
		// Methods
		[IteratorStateMachine(typeof(_Start_d__3))]
		private IEnumerator Start(); // 0x000000018C359458-0x000000018C3594B4
	}

	public class CameraOrbit : MonoBehaviour // TypeDefIndex: 82249
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
		public enum MoveMode // TypeDefIndex: 82248
		{
			None = 0,
			UpDown = 1,
			Free = 2
		}
	
		// Constructors
		public CameraOrbit(); // 0x000000018C35ADA0-0x000000018C35AE08
	
		// Methods
		private void Start(); // 0x000000018C35ACA8-0x000000018C35ADA0
		private void OnEnable(); // 0x000000018C35A980-0x000000018C35ABC0
		private void OnDisable(); // 0x000000018C35A6D0-0x000000018C35A910
		private void LateUpdate(); // 0x000000018C35A6C8-0x000000018C35A6D0
		private void updateCamera(); // 0x000000018C35AE08-0x000000018C35B0E4
		private void updatePitchYaw(Vector2 speed); // 0x000000018C35B2C0-0x000000018C35B32C
		private void updateOffset(Vector2 speed); // 0x000000018C35B0E4-0x000000018C35B2C0
		private void updateZoom(float speed); // 0x000000018C35B32C-0x000000018C35B3A4
		private void OnTouchMove(int fid, Vector2 screenPos, Vector2 screenVelocity, Vector2 cmVelocity); // 0x000000018C35ABC0-0x000000018C35AC3C
		private void OnDoubleTouchMove(int fid, Vector2 screenPos, Vector2 screenVelocity, Vector2 cmVelocity); // 0x000000018C35A910-0x000000018C35A980
		private void OnTouchPinch(float speedscr, float speedcm); // 0x000000018C35AC3C-0x000000018C35ACA8
	}

	public class CopyObject : MonoBehaviour // TypeDefIndex: 82251
	{
		// Fields
		public int seed; // 0x18
		public int count; // 0x1C
		public float radius; // 0x20
		public GameObject prefab; // 0x28
		public int delayFrame; // 0x30
	
		// Nested types
		[CompilerGenerated]
		private sealed class _CreateObject_d__7 : IEnumerator<object> // TypeDefIndex: 82250
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public CopyObject __4__this; // 0x20
			private int _i_5__2; // 0x28
			private int _j_5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _CreateObject_d__7(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018C36D0A8-0x000000018C36D290
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018C36D290-0x000000018C36D2DC
		}
	
		// Constructors
		public CopyObject(); // 0x000000018C35B5C0-0x000000018C35B5E4
	
		// Methods
		private void Awake(); // 0x0000000186805BA0-0x0000000186805BB0
		private void Start(); // 0x000000018C35B59C-0x000000018C35B5C0
		[IteratorStateMachine(typeof(_CreateObject_d__7))]
		private IEnumerator CreateObject(); // 0x000000018C35B540-0x000000018C35B59C
	}

	public class DressUpControl : MonoBehaviour // TypeDefIndex: 82253
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
		public class AvatarPartsGroup // TypeDefIndex: 82252
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
			public AvatarPartsGroup(); // 0x000000018C3591F8-0x000000018C359270
		}
	
		// Constructors
		public DressUpControl(); // 0x000000018C35C05C-0x000000018C35C0DC
	
		// Methods
		private void Start(); // 0x000000018C35C04C-0x000000018C35C054
		private void Update(); // 0x0000000186805BA0-0x0000000186805BB0
		private void OnDestroy(); // 0x000000018C35C014-0x000000018C35C04C
		private void Init(); // 0x000000018C35BE1C-0x000000018C35C014
		private void ChangeParts(int id, int dir); // 0x000000018C35BBD4-0x000000018C35BCD0
		public void Clear(); // 0x000000018C35BCD0-0x000000018C35BE1C
		[CompilerGenerated]
		private void _Init_b__8_0(int id, int dir); // 0x000000018C35C054-0x000000018C35C05C
	}

	public class ModelController : MonoBehaviour // TypeDefIndex: 82256
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
		private sealed class __c // TypeDefIndex: 82254
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<Animator> __9__7_0; // 0x08
			public static Action<Animator> __9__8_0; // 0x10
			public static Action<BaseCloth> __9__10_0; // 0x18
	
			// Constructors
			static __c(); // 0x000000018C36D660-0x000000018C36D6C4
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _OnNextButton_b__7_0(Animator ani); // 0x000000018C36D568-0x000000018C36D5B0
			internal void _OnBackButton_b__8_0(Animator ani); // 0x000000018C36D520-0x000000018C36D568
			internal void _OnActiveButton_b__10_0(BaseCloth cloth); // 0x000000018C36D4C4-0x000000018C36D520
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 82255
		{
			// Fields
			public float timeScale; // 0x10
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _OnSlowButton_b__0(Animator ani); // 0x000000018C36D618-0x000000018C36D63C
			internal void _OnSlowButton_b__1(BaseCloth cloth); // 0x000000018C36D63C-0x000000018C36D660
		}
	
		// Constructors
		public ModelController(); // 0x000000018C3694EC-0x000000018C369574
	
		// Methods
		private void Start(); // 0x0000000186805BA0-0x0000000186805BB0
		private void Update(); // 0x0000000186805BA0-0x0000000186805BB0
		private void AnimatorAction(Action<Animator> act); // 0x000000018C368D84-0x000000018C368F2C
		private void ClothAction(Action<BaseCloth> act); // 0x000000018C368F2C-0x000000018C3690DC
		public void OnNextButton(); // 0x000000018C3692D4-0x000000018C3693D0
		public void OnBackButton(); // 0x000000018C3691D8-0x000000018C3692D4
		public void OnSlowButton(); // 0x000000018C3693D0-0x000000018C3694EC
		public void OnActiveButton(); // 0x000000018C3690DC-0x000000018C3691D8
	}

	public static class ObjectUtility // TypeDefIndex: 82257
	{
		// Methods
		public static GameObject[] PlaceRandomCubes(int count, Vector3 center, float radius); // 0x000000018C36A8B4-0x000000018C36AA58
		public static GameObject[] PlaceRandomCubes(int count); // 0x000000018C36AA58-0x000000018C36AA84
		public static GameObject MakeStrippedCube(); // 0x000000018C36A808-0x000000018C36A8B4
		public static GameObject[] PlaceRandomGameObject(int count, Vector3 center, float radius, GameObject prefab); // 0x000000018C36AA84-0x000000018C36AC0C
	}

	public class SimpleInputManager : CreateSingleton<MagicaCloth.SimpleInputManager> // TypeDefIndex: 82258
	{
		// Fields
		private const int MaxFinger = 3; // Metadata: 0x02640BB5
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
		public static float ScreenDpi { get; } // 0x000000018C36CDB4-0x000000018C36CDF8 
		public static float ScreenDpc { get; } // 0x000000018C36CD70-0x000000018C36CDB4 
	
		// Constructors
		public SimpleInputManager(); // 0x000000018C36CD10-0x000000018C36CD70
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Init(); // 0x0000000187222570-0x00000001872225A0
		protected override void InitSingleton(); // 0x000000018C36BAB4-0x000000018C36BBC8
		private void Update(); // 0x000000018C36CCF0-0x000000018C36CD10
		private void CalcScreenDpi(); // 0x000000018C36B864-0x000000018C36B8A4
		private void AllResetTouchInfo(); // 0x000000018C36B820-0x000000018C36B864
		public int GetTouchCount(); // 0x000000018C36BAAC-0x000000018C36BAB4
		public bool IsUI(); // 0x000000018C36BBC8-0x000000018C36BC64
		private void UpdateMobile(); // 0x000000018C36BC64-0x000000018C36C510
		private Vector2 CalcScreenRatioVector(Vector2 vec); // 0x000000018C36B8A4-0x000000018C36B8F4
		private bool CheckFlic(int fid, Vector2 oldpos, Vector2 nowpos, Vector2 downpos, float flicktime); // 0x000000018C36B8F4-0x000000018C36BAAC
		private void UpdateMouse(); // 0x000000018C36C510-0x000000018C36CCF0
	}

	public class SliderStart : MonoBehaviour // TypeDefIndex: 82259
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
		public SliderStart(); // 0x000000018C36D040-0x000000018C36D0A8
	
		// Methods
		private void Start(); // 0x000000018C36CEC4-0x000000018C36D040
		private void OnChangeValue(float value); // 0x000000018C36CDF8-0x000000018C36CEC4
	}

	public class UIPartsItem : MonoBehaviour // TypeDefIndex: 82261
	{
		// Fields
		public UnityEngine.UI.Text text; // 0x18
		public UnityEngine.UI.Button prefButton; // 0x20
		public UnityEngine.UI.Button nextButton; // 0x28
		private int id; // 0x30
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 82260
		{
			// Fields
			public Action<int, int> onClick; // 0x10
			public UIPartsItem __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Init_b__0(); // 0x000000018C36D5B0-0x000000018C36D5E4
			internal void _Init_b__1(); // 0x000000018C36D5E4-0x000000018C36D618
		}
	
		// Constructors
		public UIPartsItem(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void Start(); // 0x0000000186805BA0-0x0000000186805BB0
		public void Init(string title, int id, Action<int, int> onClick); // 0x000000018C36D6C4-0x000000018C36D838
	}

	public class WindController : MonoBehaviour // TypeDefIndex: 82262
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
		private MagicaDirectionalWind Wind { get; } // 0x000000018C36DE80-0x000000018C36DEBC 
	
		// Constructors
		public WindController(); // 0x000000018C36DDB8-0x000000018C36DE80
	
		// Methods
		private void Start(); // 0x0000000186805BA0-0x0000000186805BB0
		public void OnDirectionY(float value); // 0x000000018C36DA10-0x000000018C36DA1C
		public void OnDirectionX(float value); // 0x000000018C36DA04-0x000000018C36DA10
		public void OnMain(float value); // 0x000000018C36DA54-0x000000018C36DB9C
		public void OnTurbulence(float value); // 0x000000018C36DB9C-0x000000018C36DBD4
		public void OnFrequency(float value); // 0x000000018C36DA1C-0x000000018C36DA54
		public void OnBlastWave(); // 0x000000018C36D8C0-0x000000018C36DA04
		private void UpdateDirection(); // 0x000000018C36DBD4-0x000000018C36DDB8
	}

	[Serializable]
	public class BezierParam : IDataHash // TypeDefIndex: 82263
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
		public float StartValue { get; } // 0x0000000187232D00-0x0000000187232D10 
		public float EndValue { get; } // 0x0000000185D327A0-0x0000000185D327C0 
		public float CurveValue { get; } // 0x0000000185D327C0-0x0000000185D327E0 
		public bool UseCurve { get; } // 0x0000000185D327E0-0x0000000185D327F0 
	
		// Constructors
		public BezierParam(); // 0x0000000186805BA0-0x0000000186805BB0
		public BezierParam(float val); // 0x00000001872512A0-0x00000001872512C0
		public BezierParam(float sval, float eval); // 0x00000001872512C0-0x00000001872512E0
		public BezierParam(float sval, float eval, bool useEval, float cval, bool useCval); // 0x0000000187251270-0x00000001872512A0
	
		// Methods
		public void SetParam(float sval, float eval, bool useEval = true /* Metadata: 0x02640BB6 */, float cval = 0f /* Metadata: 0x02640BB7 */, bool useCval = false /* Metadata: 0x02640BBB */); // 0x0000000187251270-0x00000001872512A0
		public float Evaluate(float x); // 0x0000000185D327F0-0x0000000185D328E0
		public BezierParam AutoSetup(float startVal, float endVal, float curveVal = 0f /* Metadata: 0x02640BBC */); // 0x000000018C359270-0x000000018C3592D4
		public int GetDataHash(); // 0x000000018C35933C-0x000000018C359458
		public BezierParam Clone(); // 0x000000018C3592D4-0x000000018C35933C
	}

	public interface IBoneReplace // TypeDefIndex: 82264
	{
		// Methods
		HashSet<Transform> GetUsedBones();
		void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
			where T : class;
	}

	public interface IDataVerify // TypeDefIndex: 82265
	{
		// Methods
		int GetVersion();
		void CreateVerifyData();
		Define.Error VerifyData();
		string GetInformation();
	}

	public interface IEditorCloth // TypeDefIndex: 82266
	{
		// Methods
		List<int> GetSelectionList();
		List<int> GetUseList();
	}

	public interface IEditorMesh // TypeDefIndex: 82267
	{
		// Methods
		int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList);
		List<int> GetEditorTriangleList();
		List<int> GetEditorLineList();
	}

	public class RuntimeStatus // TypeDefIndex: 82268
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
		internal HashSet<RuntimeStatus> parentStatusSet { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		internal HashSet<RuntimeStatus> childStatusSet { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public bool IsActive { get; } // 0x00000001853CCC00-0x00000001853CCC20 
		public bool IsInitStart { get; } // 0x00000001829D0800-0x00000001829D0810 
		public bool IsInitComplete { get; } // 0x0000000187235410-0x0000000187235420 
		public bool IsInitSuccess { get; } // 0x00000001853CCB30-0x00000001853CCB50 
		public bool IsInitError { get; } // 0x00000001853CAD30-0x00000001853CAD40 
		public bool IsDispose { get; } // 0x0000000187251390-0x00000001872513A0 
		public bool IsDirty { get; } // 0x000000018225E050-0x000000018225E060 
	
		// Constructors
		public RuntimeStatus(); // 0x00000001855E06C0-0x00000001855E0750
	
		// Methods
		public void SetInitStart(); // 0x00000001829D07F0-0x00000001829D0800
		public void SetInitComplete(); // 0x000000018723CE80-0x000000018723CE90
		public void SetInitError(); // 0x0000000187247950-0x0000000187247960
		public bool SetEnable(bool sw); // 0x00000001853CB260-0x00000001853CB280
		public bool SetUserEnable(bool sw); // 0x00000001853C9E80-0x00000001853C9E90
		public bool SetRuntimeError(bool sw); // 0x000000018C36B7D4-0x000000018C36B7E4
		public void SetDispose(); // 0x0000000187251380-0x0000000187251390
		public void SetDirty(); // 0x0000000187233970-0x0000000187233980
		public void ClearDirty(); // 0x000000018723F9D0-0x000000018723F9E0
		public bool UpdateStatus(); // 0x00000001853CB280-0x00000001853CB3D0
		public void AddParentStatus(RuntimeStatus status); // 0x000000018C36B5FC-0x000000018C36B650
		public void RemoveParentStatus(RuntimeStatus status); // 0x000000018C36B730-0x000000018C36B7D4
		public void AddChildStatus(RuntimeStatus status); // 0x000000018C36B5A8-0x000000018C36B5FC
		public void RemoveChildStatus(RuntimeStatus status); // 0x000000018C36B68C-0x000000018C36B730
		public void LinkParentStatus(RuntimeStatus parent); // 0x000000018C36B650-0x000000018C36B68C
		public void UnlinkParentStatus(RuntimeStatus parent); // 0x000000018C36B7E4-0x000000018C36B820
		private bool IsParentStatusActive(); // 0x00000001853CB3D0-0x00000001853CB4C0
	}

	public static class DataHashExtensions // TypeDefIndex: 82269
	{
		// Fields
		public const int NullHash = 397610387; // Metadata: 0x02640BC0
		public const int NumberHash = 932781045; // Metadata: 0x02640BC5
	
		// Methods
		public static ulong GetVectorDataHash(Vector3 v); // 0x000000018C35B830-0x000000018C35B8D4
	
		// Extension methods
		public static int GetDataHash(this object data); // 0x000000018C35B5E4-0x000000018C35B818
		public static int GetDataHash(this IDataHash data); // 0x000000018C35B818-0x000000018C35B830
		public static int GetDataHash<T>(this T[] data);
		public static int GetDataHash<T>(this List<T> data);
		public static int GetDataCountHash<T>(this T[] data);
		public static int GetDataCountHash<T>(this List<T> data);
	}

	public class GridHash // TypeDefIndex: 82271
	{
		// Fields
		protected Dictionary<uint, List<Point>> gridMap; // 0x10
		protected float gridSize; // 0x18
	
		// Nested types
		public class Point // TypeDefIndex: 82270
		{
			// Fields
			public int id; // 0x10
			public float3 pos; // 0x14
	
			// Constructors
			public Point(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public GridHash(); // 0x0000000187240EF0-0x0000000187240F00
	
		// Methods
		public virtual void Create(float gridSize = 0.1f /* Metadata: 0x02640BCA */); // 0x000000018C35DFC4-0x000000018C35E04C
		public virtual void AddPoint(float3 pos, int id); // 0x000000018C35DDF4-0x000000018C35DF7C
		public virtual void Remove(float3 pos, int id); // 0x000000018C35E134-0x000000018C35E27C
		public void Clear(); // 0x000000018C35DF7C-0x000000018C35DFC4
		public static int3 GetGridPos(float3 pos, float gridSize); // 0x000000018C35E0B0-0x000000018C35E134
		public static uint GetGridHash(int3 pos); // 0x0000000187251350-0x0000000187251380
		public static uint GetGridHash(float3 pos, float gridSize); // 0x000000018C35E04C-0x000000018C35E0B0
	}

	public class NearPointSearch : GridHash // TypeDefIndex: 82272
	{
		// Fields
		private float radius; // 0x20
		private Dictionary<int, int> nearDict; // 0x28
		private Dictionary<int, float> distDict; // 0x30
		private HashSet<uint> lockPairSet; // 0x38
	
		// Constructors
		public NearPointSearch(); // 0x000000018C36A6F4-0x000000018C36A808
	
		// Methods
		public void Create(float3[] positionList, float radius); // 0x000000018C36960C-0x000000018C369698
		public void SearchNearPointAll(); // 0x000000018C3699DC-0x000000018C369C74
		public void SearchNearPoint(int id, float3 pos); // 0x000000018C369C74-0x000000018C36A13C
		public void SearchNearPoint(float3 pos, float r); // 0x000000018C36A13C-0x000000018C36A49C
		public override void AddPoint(float3 pos, int id); // 0x000000018C3695E4-0x000000018C36960C
		public override void Remove(float3 pos, int id); // 0x000000018C36990C-0x000000018C3699DC
		public void AddLockPair(int id1, int id2); // 0x000000018C369574-0x000000018C3695E4
		public bool GetNearPointPair(out int id1, out int id2); // 0x000000018C369698-0x000000018C36990C
		public override string ToString(); // 0x000000018C36A49C-0x000000018C36A6F4
	}

	public struct ChunkData // TypeDefIndex: 82273
	{
		// Fields
		public int chunkNo; // 0x00
		public int startIndex; // 0x04
		public int dataLength; // 0x08
		public int useLength; // 0x0C
	
		// Methods
		public void Clear(); // 0x00000001872512E0-0x00000001872512F0
		public bool IsValid(); // 0x00000001853CC6D0-0x00000001853CC6E0
		public override string ToString(); // 0x000000018C35B3A4-0x000000018C35B540
	}

	public class DoubleComputeBuffer<T> : IDisposable // TypeDefIndex: 82274
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
		public ComputeBuffer GetBuffer(int bufferIndex = 0 /* Metadata: 0x02640BCE */);
	}

	public class ExNativeHashMap<TKey, TValue> // TypeDefIndex: 82275
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

	public class ExNativeMultiHashMap<TKey, TValue> // TypeDefIndex: 82276
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

	public class FixedChunkNativeArray<T> : IDisposable // TypeDefIndex: 82277
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

	public class FixedMultiNativeList<T> : IDisposable // TypeDefIndex: 82278
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

	public class FixedNativeList<T> : IDisposable // TypeDefIndex: 82279
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

	public class FixedNativeListWithCount<T> : IDisposable // TypeDefIndex: 82280
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

	public class FixedTransformAccessArray : IDisposable // TypeDefIndex: 82281
	{
		// Fields
		private TransformAccessArray transformArray; // 0x10
		private int nativeLength; // 0x18
		private Queue<int> emptyStack; // 0x20
		private Dictionary<int, int> useIndexDict; // 0x28
		private Dictionary<int, int> indexDict; // 0x30
		private Dictionary<int, int> referenceDict; // 0x38
	
		// Properties
		public int Count { get; } // 0x0000000185152BC0-0x0000000185152BE0 
		public int Length { get; } // 0x00000001844AF510-0x00000001844AF520 
		public Transform this[int index] { get => default; } // 0x0000000188A6BC64-0x0000000188A6BC74 
	
		// Constructors
		public FixedTransformAccessArray(int desiredJobCount = -1 /* Metadata: 0x02640BCF */); // 0x0000000185D93030-0x0000000185D93190
		public FixedTransformAccessArray(int capacity, int desiredJobCount); // 0x000000018C35C388-0x000000018C35C500
	
		// Methods
		public int Add(Transform element); // 0x0000000185485610-0x0000000185485800
		public void Remove(int index); // 0x0000000185485800-0x0000000185485990
		public bool Exist(int index); // 0x00000001854853C0-0x00000001854853F0
		public bool Exist(Transform element); // 0x00000001854853F0-0x00000001854854A0
		public int GetIndex(Transform element); // 0x00000001863B2AD0-0x00000001863B2BA0
		public void Clear(); // 0x000000018C35C0DC-0x000000018C35C2DC
		public void Dispose(); // 0x000000018C35C2DC-0x000000018C35C388
		public TransformAccessArray GetTransformAccessArray(); // 0x00000001829260F0-0x0000000182926100
	}

	public static class NativeArrayExtension // TypeDefIndex: 82282
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

	public abstract class CreateSingleton<T> : MonoBehaviour // TypeDefIndex: 82283
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

	public static class DataUtility // TypeDefIndex: 82284
	{
		// Methods
		public static uint PackPair(int v0, int v1); // 0x0000000188A6045C-0x0000000188A60474
		public static void UnpackPair(uint pack, out int v0, out int v1); // 0x0000000187250CA0-0x0000000187250CB0
		public static uint Pack16(int hi, int low); // 0x0000000187234120-0x0000000187234130
		public static int Unpack16Hi(uint pack); // 0x0000000187234200-0x0000000187234210
		public static int Unpack16Low(uint pack); // 0x0000000187234210-0x0000000187234220
		public static uint Pack4_28(int hi, int low); // 0x00000001872512F0-0x0000000187251300
		public static int Unpack4_28Hi(uint pack); // 0x0000000187251310-0x0000000187251320
		public static int Unpack4_28Low(uint pack); // 0x0000000187251320-0x0000000187251330
		public static uint Pack8_24(int hi, int low); // 0x0000000187251300-0x0000000187251310
		public static int Unpack8_24Hi(uint pack); // 0x0000000187251330-0x0000000187251340
		public static int Unpack8_24Low(uint pack); // 0x0000000187251340-0x0000000187251350
		public static ulong Pack32(int hi, int low); // 0x000000018723FC20-0x000000018723FC30
		public static int Unpack32Hi(ulong pack); // 0x000000018724B9A0-0x000000018724B9B0
		public static int Unpack32Low(ulong pack); // 0x0000000187235A70-0x0000000187235A80
		public static ulong PackTriple(int v0, int v1, int v2); // 0x000000018C35BA4C-0x000000018C35BB88
		public static void UnpackTriple(ulong pack, out int v0, out int v1, out int v2); // 0x0000000187250CE0-0x0000000187250D00
		public static ulong PackQuater(int v0, int v1, int v2, int v3); // 0x000000018C35B8D4-0x000000018C35BA4C
		public static void UnpackQuater(ulong pack, out int v0, out int v1, out int v2, out int v3); // 0x0000000187250CB0-0x0000000187250CE0
	}

	public static class Develop // TypeDefIndex: 82285
	{
		// Methods
		[Conditional("MAGICACLOTH_DEBUG")]
		public static void Log(string str); // 0x000000018C35BB88-0x000000018C35BBD4
	}

	public static class GizmoUtility // TypeDefIndex: 82286
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
		static GizmoUtility(); // 0x000000018C35DB90-0x000000018C35DDF4
	
		// Methods
		public static void DrawWireCapsule(Vector3 pos, Quaternion rot, Vector3 scl, Vector3 ldir, Vector3 lup, float length, float startRadius, float endRadius, bool resetMatrix = true /* Metadata: 0x02640BD0 */); // 0x000000018C35CF3C-0x000000018C35D3B4
		public static void DrawWireSphere(Vector3 pos, Quaternion rot, Vector3 scl, float radius, bool drawSphere, bool drawAxis, bool resetMatrix = true /* Metadata: 0x02640BD1 */); // 0x000000018C35D8F0-0x000000018C35DB90
		public static void DrawWireCube(Vector3 pos, Quaternion rot, Vector3 size, bool resetMatrix = true /* Metadata: 0x02640BD2 */); // 0x000000018C35D7CC-0x000000018C35D8F0
		public static void DrawWireCone(Vector3 pos, Quaternion rot, float length, float radius, int div = 8 /* Metadata: 0x02640BD3 */); // 0x000000018C35D3B4-0x000000018C35D7CC
		public static void DrawWireArrow(Vector3 pos, Quaternion rot, Vector3 size, bool cross = false /* Metadata: 0x02640BD4 */); // 0x000000018C35CBB4-0x000000018C35CF3C
		public static void DrawAxis(Vector3 pos, Quaternion rot, float size, bool resetMatrix = true /* Metadata: 0x02640BD5 */); // 0x000000018C35C500-0x000000018C35C760
		public static void DrawBone(Vector3 pos, Vector3 tpos, float size); // 0x000000018C35C760-0x000000018C35CBB4
	}

	public static class MathUtility // TypeDefIndex: 82287
	{
		// Methods
		public static float Clamp1(float a); // 0x0000000188A629AC-0x0000000188A629C4
		public static float Clamp01(float a); // 0x000000018C35E3AC-0x000000018C35E3BC
		public static float3 Project(float3 v, float3 n); // 0x000000018C331290-0x000000018C331308
		public static float Angle(float3 v1, float3 v2); // 0x00000001889EBE34-0x00000001889EBF04
		public static float3 ClampVector(float3 v, float minlength, float maxlength); // 0x000000018C330E64-0x000000018C330F38
		public static float3 ClampVector(float3 v, float maxlength); // 0x000000018C35E6D4-0x000000018C35E780
		public static float3 ClampDistance(float3 from, float3 to, float maxlength); // 0x000000018C340300-0x000000018C3403C4
		public static bool ClampAngle(float3 dir, float3 basedir, float maxAngle, out float3 outdir); // 0x000000018C35E3BC-0x000000018C35E63C
		public static quaternion FromToRotation(float3 from, float3 to, float t = 1f /* Metadata: 0x02640BD6 */); // 0x000000018C35F4EC-0x000000018C35F72C
		public static quaternion FromToRotation(quaternion from, quaternion to); // 0x0000000188A1B76C-0x0000000188A1BBE4
		public static float Angle(quaternion a, quaternion b); // 0x000000018C35E27C-0x000000018C35E2E0
		public static quaternion ClampAngle(quaternion from, quaternion to, float maxAngle); // 0x000000018C35E63C-0x000000018C35E6D4
		public static float3 AxisToEuler(float3 axis); // 0x000000018C35E2E0-0x000000018C35E3AC
		public static quaternion AxisQuaternion(float3 dir); // 0x000000018C34B1C0-0x000000018C34C804
		public static float ClosestPtPointSegmentRatio(float3 c, float3 a, float3 b); // 0x000000018C330F38-0x000000018C331020
		public static float ClosestPtPointSegmentRatioNoClamp(float3 c, float3 a, float3 b); // 0x000000018C35E8C8-0x000000018C35E9A4
		public static float3 ClosestPtPointSegment(float3 c, float3 a, float3 b); // 0x000000018C30E08C-0x000000018C30E1E8
		public static float3 ClosestPtPointSegmentNoClamp(float3 c, float3 a, float3 b); // 0x000000018C35E780-0x000000018C35E8C8
		public static bool IntersectPointPlane(float3 planePos, float3 planeDir, float3 pos, out float3 outpos); // 0x000000018C331180-0x000000018C331290
		public static float IntersectPointPlaneDist(float3 planePos, float3 planeDir, float3 pos, out float3 outPos); // 0x000000018C331020-0x000000018C331180
		public static bool IntersectSegmentPlane(float3 a, float3 b, float3 p, float3 pn, out float3 opos); // 0x000000018C361488-0x000000018C361604
		public static bool IntersectPointSphere(float3 sc, float sr, float3 pos, out float3 outPos); // 0x000000018C360C08-0x000000018C360D58
		public static bool IntersectPointSphere(float3 p, float3 sc, float sr); // 0x000000018C358E9C-0x000000018C358F0C
		public static bool IntersectRaySphere(float3 p, float3 d, float3 sc, float sr, out float3 q, out float t); // 0x000000018C3612E0-0x000000018C361488
		public static bool IntersectLineSphare(float3 a, float3 b, float3 sc, float sr, out float3 q); // 0x000000018C360638-0x000000018C3607F0
		public static bool IntersectRayCone(float3 o, float3 d, float3 c, float3 v, float cost, out float t, out float3 p); // 0x000000018C360D58-0x000000018C3612E0
		public static bool IntersectLineConeSurface(float3 a, float3 b, float3 d, float dlen, float3 c, float3 v, float cost, float3 c1, float3 c2, out float3 p); // 0x000000018C35FB78-0x000000018C35FD3C
		public static bool IntersectLineCylinderSurface(float3 sa, float3 sb, float3 p, float3 q, float r, out float t); // 0x000000018C36021C-0x000000018C360638
		public static bool IntersectLineCylinderSurface(float3 a, float3 b, float3 c1, float3 c2, float r1, float r2, out float3 p); // 0x000000018C35FD3C-0x000000018C36021C
		public static bool IntersectLineCapsule(float3 a, float3 b, float3 c1, float3 c2, float r1, float r2, out float3 p); // 0x000000018C35F810-0x000000018C35FB78
		public static bool IntersectTrianglePointDistance(float3 p, float3 p0, float3 p1, float3 p2, float restDist, float compressionStiffness, float stretchStiffness, out float3 corr, out float3 corr0, out float3 corr1, out float3 corr2); // 0x000000018C362A80-0x000000018C363460
		public static bool IntersectTrianglePointDistanceSide(float3 p, float3 p0, float3 p1, float3 p2, float restDist, float compressionStiffness, float stretchStiffness, float side, out float3 corr, out float3 corr0, out float3 corr1, out float3 corr2); // 0x000000018C361FEC-0x000000018C362A80
		public static bool IntersectTrianglePointDistanceSide2(float3 p, float3 p0, float3 p1, float3 p2, float radius, float restDist, float compressionStiffness, float stretchStiffness, float side, out float3 corr, out float3 corr0, out float3 corr1, out float3 corr2); // 0x000000018C361604-0x000000018C361FEC
		public static float DistanceTrianglePoint(float3 p, float3 p0, float3 p1, float3 p2); // 0x000000018C35EEA4-0x000000018C35F4EC
		public static float3 TriangleCenter(float3 p0, float3 p1, float3 p2); // 0x0000000188A66070-0x0000000188A66124
		public static float3 TriangleNormal(float3 p0, float3 p1, float3 p2); // 0x000000018C30E1E8-0x000000018C30E2C4
		public static quaternion TriangleRotation(float3 p0, float3 p1, float3 p2); // 0x000000018C363604-0x000000018C363760
		public static quaternion TriangleCenterRotation(float3 p0, float3 p1, float3 p2, float3 p3); // 0x000000018C363460-0x000000018C363604
		public static float DistanceTriangleCenter(float3 p, float3 p0, float3 p1, float3 p2); // 0x0000000188A636C0-0x0000000188A6378C
		public static float DirectionPointTriangle(float3 p, float3 a, float3 b, float3 c); // 0x0000000188A635A4-0x0000000188A636C0
		public static bool IntersectLineTriangle(float3 p, float3 q, float3 a, float3 b, float3 c, out float3 hitpos, out float t, out float3 n); // 0x000000018C3607F0-0x000000018C360C08
		public static float ClosestPtSegmentSegment(float3 p1, float3 q1, float3 p2, float3 q2, out float s, out float t, out float3 c1, out float3 c2); // 0x000000018C35E9A4-0x000000018C35EEA4
		public static float GetBezierValue(BezierParam bparam, float t); // 0x000000018C35F72C-0x000000018C35F784
		public static float GetBezierValue(float sval, float eval, float curve, float t); // 0x000000018C35F784-0x000000018C35F810
	}

	public static class MeshUtility // TypeDefIndex: 82290
	{
		// Nested types
		private class TetraVertex // TypeDefIndex: 82288
		{
			// Fields
			public int index; // 0x10
			public Vector3 pos; // 0x14
	
			// Constructors
			public TetraVertex(); // 0x0000000186805BA0-0x0000000186805BB0
			public TetraVertex(Vector3 pos, int index); // 0x00000001872513D0-0x00000001872513F0
		}
	
		private class Tetra // TypeDefIndex: 82289
		{
			// Fields
			public List<TetraVertex> vertexList; // 0x10
			public Vector3 circumCenter; // 0x18
			public float circumRadius; // 0x24
			public Vector3 tetraCenter; // 0x28
			public float tetraSize; // 0x34
	
			// Constructors
			public Tetra(); // 0x000000018C36F268-0x000000018C36F2E0
			public Tetra(TetraVertex a, TetraVertex b, TetraVertex c, TetraVertex d); // 0x000000018C36F14C-0x000000018C36F268
	
			// Methods
			public ulong GetTetraHash(); // 0x000000018C36EDFC-0x000000018C36EEF4
			public void CalcCircumcircle(); // 0x000000018C36E3CC-0x000000018C36EA34
			public bool IntersectCircumcircle(Vector3 pos); // 0x000000018C30AEC4-0x000000018C30AF10
			public bool CheckSame(Tetra tri); // 0x000000018C30AC2C-0x000000018C30ACAC
			public bool ContainsPoint(TetraVertex p1); // 0x000000018C36EDA8-0x000000018C36EDFC
			public bool ContainsPoint(TetraVertex p1, TetraVertex p2, TetraVertex p3, TetraVertex p4); // 0x000000018C36ECDC-0x000000018C36EDA8
			public void CalcSize(); // 0x000000018C36EA34-0x000000018C36ECDC
			public bool Verification(); // 0x000000018C36EEF4-0x000000018C36F14C
		}
	
		// Methods
		public static GameObject ReplaceSkinnedMeshRendererToMeshRenderer(SkinnedMeshRenderer sren, bool replaceSkinnedMeshRenderer); // 0x000000018C36890C-0x000000018C368BF0
		public static bool CalcMeshWorldPositionNormalTangent(MeshData meshData, List<Transform> boneList, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x000000018C364548-0x000000018C364B94
		public static bool CalcMeshWorldPositionNormalTangent(Renderer ren, Mesh mesh, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList); // 0x000000018C364B94-0x000000018C365670
		public static bool CalcMeshLocalNormalTangent(List<int> selectList, Vector3[] vlist, Vector2[] uvlist, int[] triangles, out List<Vector3> lnorList, out List<Vector3> ltanList); // 0x000000018C363880-0x000000018C364548
		public static List<HashSet<int>> GetTriangleToVertexLinkList(int vcnt, List<int> lineList, List<int> triangleList); // 0x000000018C367DC0-0x000000018C368134
		public static List<HashSet<int>> GetVertexLinkList(int vcnt, HashSet<uint> lineSet); // 0x000000018C3684D8-0x000000018C368768
		public static Dictionary<int, HashSet<int>> GetVertexToTriangles(List<int> triangleList); // 0x000000018C368768-0x000000018C36890C
		public static int RestTriangleVertex(int tindex, int v0, int v1, List<int> triangleList); // 0x000000018C368CF4-0x000000018C368D84
		public static void RestTriangleVertex(int tindex, int v0, List<int> triangleList, out int v1, out int v2); // 0x000000018C368BF0-0x000000018C368CF4
		public static bool CheckAdjacentTriangle(int tindex0, int tindex1, List<int> triangleList); // 0x000000018C3677A8-0x000000018C36786C
		public static Dictionary<uint, List<int>> GetTriangleEdgePair(List<int> triangleList); // 0x000000018C367B10-0x000000018C367C84
		private static void AddTriangleEdge(int v0, int v1, int tindex, Dictionary<uint, List<int>> triangleEdgeDict); // 0x000000018C363760-0x000000018C363880
		public static List<ulong> GetTrianglePackList(List<int> triangleList); // 0x000000018C367C84-0x000000018C367DC0
		public static float ClosestPtBoneLine(Vector3 pos, Transform bone, float lineWidth, out Vector3 d); // 0x000000018C36786C-0x000000018C367B10
		public static List<Transform> GetUseBoneTransformList(Transform[] bones, Mesh mesh); // 0x000000018C368134-0x000000018C3684D8
		public static void CalcTetraMesh(List<Vector3> posList, out int tetraCount, out List<int> tetraIndexList, out List<float> tetraSizeList); // 0x000000018C365670-0x000000018C3677A8
		public static Transform GetReplaceBone<T>(Transform now, Dictionary<T, Transform> boneReplaceDict)
			where T : class;
	}

	public class StaticStringBuilder // TypeDefIndex: 82291
	{
		// Fields
		private static StringBuilder stringBuilder; // 0x00
	
		// Properties
		public static StringBuilder Instance { get; } // 0x000000018C36E33C-0x000000018C36E38C 
	
		// Constructors
		public StaticStringBuilder(); // 0x0000000186805BA0-0x0000000186805BB0
		static StaticStringBuilder(); // 0x000000018C36E2B8-0x000000018C36E33C
	
		// Methods
		public static void Clear(); // 0x000000018C36E208-0x000000018C36E260
		public static StringBuilder Append(params object[] args); // 0x000000018C36E15C-0x000000018C36E208
		public static StringBuilder AppendLine(params object[] args); // 0x000000018C36DF18-0x000000018C36DFF8
		public static StringBuilder AppendLine(); // 0x000000018C36DFF8-0x000000018C36E074
		public static string AppendToString(params object[] args); // 0x000000018C36E074-0x000000018C36E15C
		public static new string ToString(); // 0x000000018C36E260-0x000000018C36E2B8
	}

	[Serializable]
	public class UpdateTimeManager // TypeDefIndex: 82295
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
		public int FixedUpdateCount { get; } // 0x0000000182271A60-0x0000000182271A70 
		public int UpdatePerSecond { get; } // 0x00000001828BC2B0-0x00000001828BC2C0 
		public float UpdateIntervalTime { get; } // 0x0000000187251420-0x0000000187251440 
		public float UpdatePower { get; } // 0x0000000187251440-0x0000000187251460 
		public float TimeScale { get; set; } // 0x0000000187233410-0x0000000187233420 0x000000018C36F308-0x000000018C36F320
		public float DeltaTime { get; } // 0x0000000187834D7C-0x0000000187834D84 
		public float PhysicsDeltaTime { get; } // 0x0000000185152C90-0x0000000185152CE0 
		public float AverageDeltaTime { get; } // 0x000000018C36F2E0-0x000000018C36F2E8 
		public bool IsUnscaledUpdate { get; } // 0x0000000185221930-0x0000000185221950 
		public bool IsDelay { get; } // 0x000000018521E5B0-0x000000018521EA30 
		public float FuturePredictionRate { get; set; } // 0x00000001872332C0-0x00000001872332D0 0x000000018C36F2F0-0x000000018C36F308
		public bool UpdateBoneScale { get; set; } // 0x000000018223FE80-0x000000018223FE90 0x000000018223FE90-0x000000018223FEA0
		public int WorkerMaximumCount { get; } // 0x000000018C36F2E8-0x000000018C36F2F0 
	
		// Nested types
		public enum UpdateCount // TypeDefIndex: 82292
		{
			_60 = 60,
			_90_Default = 90,
			_120 = 120,
			_150 = 150,
			_180 = 180
		}
	
		public enum UpdateMode // TypeDefIndex: 82293
		{
			UnscaledTime = 0,
			OncePerFrame = 1,
			DelayUnscaledTime = 10
		}
	
		public enum UpdateLocation // TypeDefIndex: 82294
		{
			AfterLateUpdate = 0,
			BeforeLateUpdate = 1
		}
	
		// Constructors
		public UpdateTimeManager(); // 0x0000000187251400-0x0000000187251420
	
		// Methods
		public void ResetFixedUpdateCount(); // 0x00000001872513F0-0x0000000187251400
		public void AddFixedUpdateCount(); // 0x000000018724CCC0-0x000000018724CCD0
		public UpdateMode GetUpdateMode(); // 0x0000000182971EE0-0x0000000182971EF0
		public void SetUpdateMode(UpdateMode mode); // 0x000000018275FD70-0x000000018275FD80
		public UpdateLocation GetUpdateLocation(); // 0x00000001844AF510-0x00000001844AF520
		public void SetUpdateLocation(UpdateLocation location); // 0x000000018442F470-0x000000018442F480
		public void SetUpdatePerSecond(UpdateCount ucount); // 0x0000000182234E90-0x0000000182234EA0
	}

	public class ReferenceDataBuilder<T> // TypeDefIndex: 82296
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
	public struct ReferenceDataIndex // TypeDefIndex: 82297
	{
		// Fields
		public int startIndex; // 0x00
		public int count; // 0x04
	}

	public interface IDataHash // TypeDefIndex: 82298
	{
		// Methods
		int GetDataHash();
	}

	public interface IShareDataObject // TypeDefIndex: 82299
	{
		// Methods
		List<ShareDataObject> GetAllShareDataObject();
		ShareDataObject DuplicateShareDataObject(ShareDataObject source);
	}

	[Serializable]
	public abstract class ShareDataObject : ScriptableObject, IDataVerify, IDataHash // TypeDefIndex: 82300
	{
		// Fields
		[SerializeField]
		protected int dataHash; // 0x18
		[SerializeField]
		protected int dataVersion; // 0x1C
	
		// Properties
		public int SaveDataHash { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public int SaveDataVersion { get; set; } // 0x0000000187233000-0x0000000187233010 0x0000000187233010-0x0000000187233020
	
		// Constructors
		protected ShareDataObject(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		public abstract int GetDataHash();
		public abstract int GetVersion();
		public abstract Define.Error VerifyData();
		public virtual void CreateVerifyData(); // 0x000000018C36DEBC-0x000000018C36DEEC
		public virtual string GetInformation(); // 0x000000018C36DEEC-0x000000018C36DF18
		public static T CreateShareData<T>(string dataName)
			where T : ShareDataObject;
		public static bool RemoveNullAndDuplication<T>(List<T> data);
		public static T Clone<T>(T source)
			where T : ShareDataObject;
	}

	public class StopWatch // TypeDefIndex: 82301
	{
		// Fields
		private float startTime; // 0x10
		private float endTime; // 0x14
	
		// Properties
		public float ElapsedSeconds { get; } // 0x00000001872513C0-0x00000001872513D0 
		public float ElapsedMilliseconds { get; } // 0x00000001872513A0-0x00000001872513C0 
	
		// Constructors
		public StopWatch(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public StopWatch Start(); // 0x000000018C36E38C-0x000000018C36E3AC
		public StopWatch Stop(); // 0x000000018C36E3AC-0x000000018C36E3CC
	}
}

namespace MagicaReductionMesh
{
	public class ReductionMesh // TypeDefIndex: 81998
	{
		// Fields
		[CompilerGenerated]
		private ReductionWeightMode _WeightMode_k__BackingField; // 0x10
		private MeshData meshData; // 0x18
		private ReductionData reductionData; // 0x20
		private DebugData debugData; // 0x28
	
		// Properties
		public ReductionWeightMode WeightMode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
		public MeshData MeshData { get; } // 0x000000018C307AD8-0x000000018C307B04 
		public ReductionData ReductionData { get; } // 0x000000018C307B04-0x000000018C307B30 
		public DebugData DebugData { get; } // 0x000000018C307AAC-0x000000018C307AD8 
	
		// Nested types
		public enum ReductionWeightMode // TypeDefIndex: 81997
		{
			Distance = 0,
			Average = 1,
			DistanceAverage = 2
		}
	
		// Constructors
		public ReductionMesh(); // 0x000000018C3079F4-0x000000018C307AAC
	
		// Methods
		public int AddMesh(bool isSkinning, Mesh mesh, List<Transform> bones, Matrix4x4[] bindPoseList, BoneWeight[] boneWeightList); // 0x000000018C307874-0x000000018C3078CC
		public int AddMesh(Renderer ren); // 0x000000018C3075EC-0x000000018C307874
		public int AddMesh(Transform root, List<Vector3> posList, List<Vector3> norList = null, List<Vector4> tanList = null, List<Vector2> uvList = null, List<int> triangleList = null); // 0x000000018C307594-0x000000018C3075EC
		public void Reduction(float zeroRadius, float radius, float polygonLength, bool createTetra); // 0x000000018C3078FC-0x000000018C3079F4
		public FinalData GetFinalData(Transform root); // 0x000000018C3078CC-0x000000018C3078FC
	}

	public abstract class ReductionMeshAccess // TypeDefIndex: 81999
	{
		// Fields
		protected ReductionMesh parent; // 0x10
	
		// Properties
		protected MeshData MeshData { get; } // 0x000000018C307554-0x000000018C307574 
		protected ReductionData ReductionData { get; } // 0x000000018C307574-0x000000018C307594 
		protected DebugData DebugData { get; } // 0x000000018C307534-0x000000018C307554 
	
		// Constructors
		protected ReductionMeshAccess(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public virtual void SetParent(ReductionMesh parent); // 0x0000000184FD2410-0x0000000184FD2420
	}

	public class DebugData : ReductionMeshAccess // TypeDefIndex: 82000
	{
		// Constructors
		public DebugData(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void DispMeshInfo(string header = "" /* Metadata: 0x026408B3 */); // 0x000000018C2F8B84-0x000000018C2F8E30
		public static void DebugDrawShared(FinalData final, bool drawTriangle = true /* Metadata: 0x026408B4 */, bool drawLine = true /* Metadata: 0x026408B5 */, bool drawTetra = true /* Metadata: 0x026408B6 */, bool drawVertexNormal = true /* Metadata: 0x026408B7 */, bool drawVertexTangent = true /* Metadata: 0x026408B8 */, bool drawNumber = false /* Metadata: 0x026408B9 */, int maxPolygonCount = 2147483647 /* Metadata: 0x026408BA */, int layer = -1 /* Metadata: 0x026408BB */, int tetraIndex = -1 /* Metadata: 0x026408BC */, float tetraSize = 1f /* Metadata: 0x026408BD */, List<int> drawNumberList = null, float axisSize = 0.01f /* Metadata: 0x026408C1 */); // 0x000000018C2F7FBC-0x000000018C2F8B84
		private static void DrawTetra(FinalData final, int tetraIndex, List<Vector3> wposList, float tetraSize); // 0x000000018C2F8E30-0x000000018C2F90D8
		public static void DebugDrawChild(FinalData final, bool drawPosition = false /* Metadata: 0x026408C5 */, bool drawNormal = false /* Metadata: 0x026408C6 */, bool drawTriangle = false /* Metadata: 0x026408C7 */, bool drawNumber = false /* Metadata: 0x026408C8 */, int maxVertexCount = 2147483647 /* Metadata: 0x026408C9 */, float positionSize = 0.001f /* Metadata: 0x026408CA */, float axisSize = 0.01f /* Metadata: 0x026408CE */); // 0x000000018C2F7B00-0x000000018C2F7FBC
	}

	[Serializable]
	public class FinalData // TypeDefIndex: 82003
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
		public bool IsValid { get; } // 0x000000018C2F95B8-0x000000018C2F95FC 
		public int VertexCount { get; } // 0x000000018C2F9714-0x000000018C2F9754 
		public int LineCount { get; } // 0x000000018C2F95FC-0x000000018C2F9640 
		public int TriangleCount { get; } // 0x000000018C2F96C8-0x000000018C2F9714 
		public int TetraCount { get; } // 0x000000018C2F9680-0x000000018C2F96C8 
		public int BoneCount { get; } // 0x000000018C2F9578-0x000000018C2F95B8 
		public bool IsSkinning { get; } // 0x00000001851A4410-0x00000001851A4420 
		public int MeshCount { get; } // 0x000000018C2F9640-0x000000018C2F9680 
	
		// Nested types
		[Serializable]
		public class MeshIndexData // TypeDefIndex: 82001
		{
			// Fields
			public List<uint> meshIndexPackList; // 0x10
	
			// Constructors
			public MeshIndexData(); // 0x000000018C3044C4-0x000000018C30453C
		}
	
		[Serializable]
		public class MeshInfo // TypeDefIndex: 82002
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
			public int VertexCount { get; } // 0x000000018C304740-0x000000018C304780 
	
			// Constructors
			public MeshInfo(); // 0x000000018C30453C-0x000000018C3046C8
		}
	
		// Constructors
		public FinalData(); // 0x000000018C2F90D8-0x000000018C2F9578
	}

	public class MeshData : ReductionMeshAccess // TypeDefIndex: 82023
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
		public int VertexCount { get; } // 0x000000018C304484-0x000000018C3044C4 
		public int LineCount { get; } // 0x000000018C304384-0x000000018C3043C4 
		public int TriangleCount { get; } // 0x000000018C304444-0x000000018C304484 
		public int TetraCount { get; } // 0x000000018C304404-0x000000018C304444 
		public int MeshCount { get; } // 0x000000018C3043C4-0x000000018C304404 
		public float WeightPow { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
		public int MaxWeightCount { get; set; } // 0x00000001872336F0-0x0000000187233700 0x0000000187233700-0x0000000187233710
		public float SameSurfaceAngle { get; set; } // 0x00000001872353B0-0x00000001872353C0 0x00000001872353E0-0x00000001872353F0
		public bool RemoveSameTrianglePair { get; set; } // 0x000000018225DF90-0x000000018225DFA0 0x000000018225DFA0-0x000000018225DFB0
		public float RemoveSameTrianglePairAngle { get; set; } // 0x00000001872352B0-0x00000001872352C0 0x00000001872352D0-0x00000001872352E0
	
		// Nested types
		public class WeightData // TypeDefIndex: 82004
		{
			// Fields
			public int boneIndex; // 0x10
			public float boneWeight; // 0x14
	
			// Constructors
			public WeightData(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public class Vertex // TypeDefIndex: 82005
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
			public Vertex(); // 0x000000018C30DD6C-0x000000018C30E08C
		}
	
		public class MeshInfo // TypeDefIndex: 82006
		{
			// Fields
			public int index; // 0x10
			public Mesh mesh; // 0x18
			public int vertexCount; // 0x20
			public List<Vertex> vertexList; // 0x28
	
			// Constructors
			public MeshInfo(); // 0x000000018C3046C8-0x000000018C304740
		}
	
		public class ShareVertex // TypeDefIndex: 82011
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
			private sealed class __c__DisplayClass20_0 // TypeDefIndex: 82007
			{
				// Fields
				public WeightData w; // 0x10
	
				// Constructors
				public __c__DisplayClass20_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal bool _CalcBoneWeight_DistanceAverage_b__1(WeightData wdata); // 0x000000018C30C15C-0x000000018C30C184
			}
	
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 82008
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Comparison<WeightData> __9__20_0; // 0x08
				public static Comparison<WeightData> __9__21_0; // 0x10
				public static Comparison<WeightData> __9__23_0; // 0x18
	
				// Constructors
				static __c(); // 0x000000018C30C280-0x000000018C30C2E4
				public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal int _CalcBoneWeight_DistanceAverage_b__20_0(WeightData a, WeightData b); // 0x000000018C30C0F4-0x000000018C30C12C
				internal int _CalcBoneWeight_Average_b__21_0(WeightData a, WeightData b); // 0x000000018C30C0F4-0x000000018C30C12C
				internal int _CalcBoneWeight_Distance_b__23_0(WeightData a, WeightData b); // 0x000000018C30C0F4-0x000000018C30C12C
			}
	
			[CompilerGenerated]
			private sealed class __c__DisplayClass21_0 // TypeDefIndex: 82009
			{
				// Fields
				public WeightData w; // 0x10
	
				// Constructors
				public __c__DisplayClass21_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal bool _CalcBoneWeight_Average_b__1(WeightData wdata); // 0x000000018C30C15C-0x000000018C30C184
			}
	
			[CompilerGenerated]
			private sealed class __c__DisplayClass23_0 // TypeDefIndex: 82010
			{
				// Fields
				public WeightData w; // 0x10
	
				// Constructors
				public __c__DisplayClass23_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal bool _CalcBoneWeight_Distance_b__1(WeightData wdata); // 0x000000018C30C15C-0x000000018C30C184
			}
	
			// Constructors
			public ShareVertex(); // 0x000000018C309FAC-0x000000018C30A11C
	
			// Methods
			public void AddLink(ShareVertex mv); // 0x000000018C307B30-0x000000018C307B88
			public void ReplaseLink(ShareVertex old, ShareVertex mv); // 0x000000018C309EF4-0x000000018C309FAC
			public void RecalcCoordinate(); // 0x000000018C309C14-0x000000018C309EF4
			public void CalcNormalTangentFromTriangle(); // 0x000000018C3097C4-0x000000018C309A0C
			public Vector3 CalcLocalPos(Vector3 pos); // 0x000000018C3096D0-0x000000018C3097C4
			public Vector3 CalcLocalDir(Vector3 dir); // 0x000000018C309620-0x000000018C3096D0
			public Matrix4x4 CalcWorldToLocalMatrix(); // 0x000000018C309A0C-0x000000018C309B24
			public void CalcBoneWeight(ReductionMesh.ReductionWeightMode weightMode, float weightPow); // 0x000000018C3095E4-0x000000018C309620
			private void CalcBoneWeight_DistanceAverage(float weightPow); // 0x000000018C308434-0x000000018C308DE8
			private void CalcBoneWeight_Average(); // 0x000000018C307DBC-0x000000018C308434
			private void AdjustWeight(List<WeightData> sumlist); // 0x000000018C307B88-0x000000018C307DBC
			private void CalcBoneWeight_Distance(float weightPow); // 0x000000018C308DE8-0x000000018C3095E4
			public BoneWeight GetBoneWeight(); // 0x000000018C309B24-0x000000018C309C14
		}
	
		public class Triangle // TypeDefIndex: 82013
		{
			// Fields
			public int tindex; // 0x10
			public List<ShareVertex> shareVertexList; // 0x18
			public Vector3 wnor; // 0x20
			public Vector3 wtan; // 0x2C
			public bool flipLock; // 0x38
	
			// Nested types
			[CompilerGenerated]
			private sealed class __c__DisplayClass9_0 // TypeDefIndex: 82012
			{
				// Fields
				public int edgev0; // 0x10
				public int edgev1; // 0x14
	
				// Constructors
				public __c__DisplayClass9_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal bool _GetNonEdgeVertex_b__0(ShareVertex sv); // 0x000000018C30C1F0-0x000000018C30C21C
			}
	
			// Constructors
			public Triangle(); // 0x000000018C30C07C-0x000000018C30C0F4
	
			// Methods
			public void GetEdge(out uint edge0, out uint edge1, out uint edge2); // 0x000000018C30BACC-0x000000018C30BC38
			public Vector3 CalcTriangleNormal(); // 0x000000018C30B2FC-0x000000018C30B650
			public void Flip(); // 0x000000018C30B9D4-0x000000018C30BACC
			public Vector3 CalcTriangleTangent(); // 0x000000018C30B650-0x000000018C30B9D4
			public ShareVertex GetNonEdgeVertex(int edgev0, int edgev1); // 0x000000018C30BC38-0x000000018C30BD0C
			public ulong GetTriangleHash(); // 0x000000018C30BDF4-0x000000018C30BEA8
			public static float GetTriangleArea(ShareVertex sv0, ShareVertex sv1, ShareVertex sv2); // 0x000000018C30BD0C-0x000000018C30BDF4
			public override string ToString(); // 0x000000018C30BEA8-0x000000018C30C07C
		}
	
		private class Line // TypeDefIndex: 82014
		{
			// Fields
			public List<ShareVertex> shareVertexList; // 0x10
	
			// Constructors
			public Line(); // 0x000000018C2F9754-0x000000018C2F97CC
		}
	
		public enum UvWrapMode // TypeDefIndex: 82015
		{
			None = 0,
			Sphere = 1
		}
	
		public class Square // TypeDefIndex: 82016
		{
			// Fields
			public ulong shash; // 0x10
			public List<Triangle> triangleList; // 0x18
			public float angle; // 0x20
	
			// Constructors
			public Square(); // 0x000000018C30A2A4-0x000000018C30A31C
	
			// Methods
			public override string ToString(); // 0x000000018C30A11C-0x000000018C30A2A4
		}
	
		public class Tetra // TypeDefIndex: 82017
		{
			// Fields
			public List<ShareVertex> shareVertexList; // 0x10
			public Vector3 circumCenter; // 0x18
			public float circumRadius; // 0x24
			public Vector3 tetraCenter; // 0x28
			public float tetraSize; // 0x34
	
			// Constructors
			public Tetra(); // 0x000000018C30B168-0x000000018C30B1E0
			public Tetra(ShareVertex a, ShareVertex b, ShareVertex c, ShareVertex d); // 0x000000018C30B1E0-0x000000018C30B2FC
	
			// Methods
			public ulong GetTetraHash(); // 0x000000018C30ADCC-0x000000018C30AEC4
			public void CalcCircumcircle(); // 0x000000018C30A31C-0x000000018C30A984
			public bool IntersectCircumcircle(Vector3 pos); // 0x000000018C30AEC4-0x000000018C30AF10
			public bool CheckSame(Tetra tri); // 0x000000018C30AC2C-0x000000018C30ACAC
			public bool ContainsPoint(ShareVertex p1); // 0x000000018C30ACAC-0x000000018C30AD00
			public bool ContainsPoint(ShareVertex p1, ShareVertex p2, ShareVertex p3, ShareVertex p4); // 0x000000018C30AD00-0x000000018C30ADCC
			public void CalcSize(); // 0x000000018C30A984-0x000000018C30AC2C
			public bool Verification(); // 0x000000018C30AF10-0x000000018C30B168
		}
	
		private class LinkInfo // TypeDefIndex: 82018
		{
			// Fields
			public ShareVertex sv; // 0x10
			public float length; // 0x18
			public int count; // 0x1C
	
			// Constructors
			public LinkInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private class VertexLengthInfo // TypeDefIndex: 82019
		{
			// Fields
			public ShareVertex sv; // 0x10
			public float length; // 0x18
	
			// Constructors
			public VertexLengthInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass65_0 // TypeDefIndex: 82020
		{
			// Fields
			public float weightLength; // 0x10
	
			// Constructors
			public __c__DisplayClass65_0(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass65_1 // TypeDefIndex: 82021
		{
			// Fields
			public Vertex vt; // 0x10
			public __c__DisplayClass65_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass65_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _CreateOriginalMeshInfo_b__0(ShareVertex sv); // 0x000000018C30C184-0x000000018C30C1F0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 82022
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<VertexLengthInfo> __9__69_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018C30C21C-0x000000018C30C280
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _SearchNearPointList_b__69_0(VertexLengthInfo a, VertexLengthInfo b); // 0x000000018C30C12C-0x000000018C30C15C
		}
	
		// Constructors
		public MeshData(); // 0x000000018C304124-0x000000018C304384
	
		// Methods
		public int AddMesh(bool isSkinning, Mesh mesh, List<Transform> bones, Matrix4x4[] bindPoseList, BoneWeight[] boneWeightList); // 0x000000018C2F9F2C-0x000000018C2FAC04
		public int AddMesh(Transform root, List<Vector3> posList, List<Vector3> norList = null, List<Vector4> tanList = null, List<Vector2> uvList = null, List<int> triangleList = null); // 0x000000018C2F97CC-0x000000018C2F9F2C
		public void CombineVertex(ShareVertex sv0, ShareVertex sv1); // 0x000000018C2FD01C-0x000000018C2FD350
		public void UpdateMeshData(bool createTetra); // 0x000000018C3040BC-0x000000018C304124
		private void CalcVertexIndex(); // 0x000000018C2FCC18-0x000000018C2FCDC0
		private void CalcUV(UvWrapMode wrapMode); // 0x000000018C2FC840-0x000000018C2FCC18
		private void CreateTriangleAndLine(); // 0x000000018C2FFC28-0x000000018C30100C
		private void CalcShareVertexWeight(); // 0x000000018C2FC458-0x000000018C2FC594
		private void AdjustTriangleNormal(); // 0x000000018C2FAC9C-0x000000018C2FB768
		private bool CheckTwoTriangleOpen(Triangle tri1, Triangle tri2, uint edge); // 0x000000018C2FCED8-0x000000018C2FD01C
		private float CalcTwoTriangleAngle(Triangle tri1, Triangle tri2, uint edge); // 0x000000018C2FC594-0x000000018C2FC840
		private Dictionary<uint, List<ulong>> GetEdgeToTriangleDict(); // 0x000000018C30100C-0x000000018C30154C
		private void CalcVertexNormalFromTriangle(); // 0x000000018C2FCDC0-0x000000018C2FCED8
		private void RemoveTriangle(ulong thash); // 0x000000018C303728-0x000000018C303940
		private Dictionary<ulong, List<Square>> GetSquareDict(); // 0x000000018C302D78-0x000000018C303604
		private void RemoveOverlappingSquareTriangles(); // 0x000000018C303604-0x000000018C303728
		private void CreateTetraMesh(); // 0x000000018C2FE3D8-0x000000018C2FFC28
		private Bounds CalcBounding(); // 0x000000018C2FB768-0x000000018C2FB980
		public FinalData GetFinalData(Transform root); // 0x000000018C30154C-0x000000018C302D78
		private void CreateOriginalMeshInfo(FinalData final, Transform root, float weightLength); // 0x000000018C2FD350-0x000000018C2FE3D8
		private void AddVertexToMeshIndexData(FinalData final, int sindex, int meshIndex, int meshVertexIndex); // 0x000000018C2FAC04-0x000000018C2FAC9C
		private List<ShareVertex> SearchNearPointList(Vector3 basePos, ShareVertex sv, float weightLength, int maxCount); // 0x000000018C303940-0x000000018C3040BC
		public void CalcMeshWorldPositionNormalTangent(bool isSkinning, Mesh mesh, List<Transform> bones, Matrix4x4[] bindPoseList, BoneWeight[] boneWeightList, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector4> wtanList); // 0x000000018C2FB980-0x000000018C2FC458
	}

	public class ReductionData : ReductionMeshAccess // TypeDefIndex: 82024
	{
		// Constructors
		public ReductionData(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void ReductionZeroDistance(float radius = 0.0001f /* Metadata: 0x026408D4 */); // 0x000000018C3074A8-0x000000018C307534
		public void ReductionRadius(float radius); // 0x000000018C30741C-0x000000018C3074A8
		public void ReductionPolygonLink(float length); // 0x000000018C307390-0x000000018C30741C
		public void ReductionBone(); // 0x000000018C306E9C-0x000000018C307390
	}

	public class NearPointReduction // TypeDefIndex: 82026
	{
		// Fields
		protected MeshData meshData; // 0x10
		private List<Point> pointList; // 0x18
		protected Dictionary<Vector3Int, List<Point>> gridMap; // 0x20
		protected float gridSize; // 0x28
		private float searchRadius; // 0x2C
		private Dictionary<Point, List<Point>> nearPointDict; // 0x30
	
		// Properties
		public int PointCount { get; } // 0x000000018C305F34-0x000000018C305F74 
	
		// Nested types
		public class Point // TypeDefIndex: 82025
		{
			// Fields
			public MeshData.ShareVertex shareVertex; // 0x10
			public Vector3 pos; // 0x18
			public Vector3Int grid; // 0x24
			public Point nearPoint; // 0x30
			public float nearDist; // 0x38
	
			// Constructors
			public Point(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public NearPointReduction(float radius = 0.05f /* Metadata: 0x026408D8 */); // 0x000000018C305E08-0x000000018C305F34
	
		// Methods
		public void Create(MeshData meshData); // 0x000000018C3049CC-0x000000018C304B44
		public void Reduction(); // 0x000000018C304D74-0x000000018C3052D4
		private Point AddPoint(MeshData.ShareVertex sv, Vector3 pos); // 0x000000018C304910-0x000000018C3049CC
		private void AddGrid(Point p); // 0x000000018C304780-0x000000018C304910
		private void RemoveGrid(Point p); // 0x000000018C3052D4-0x000000018C305454
		private void Move(Point p, Vector3 newpos); // 0x000000018C304D1C-0x000000018C304D74
		private void Remove(Point p); // 0x000000018C305454-0x000000018C3054B8
		protected Vector3Int GetGridPos(Vector3 pos); // 0x000000018C304B44-0x000000018C304BBC
		private void SearchNearPointAll(); // 0x000000018C3054B8-0x000000018C305760
		private void SearchNearPoint(Point p, float radius, Point ignorePoint); // 0x000000018C305760-0x000000018C305E08
		private Point GetNearPointPair(); // 0x000000018C304BBC-0x000000018C304D1C
	}

	public class PolygonLinkReduction // TypeDefIndex: 82028
	{
		// Fields
		protected MeshData meshData; // 0x10
		private float reductionLength; // 0x18
		private List<Point> pointList; // 0x20
		private Dictionary<MeshData.ShareVertex, Point> pointDict; // 0x28
	
		// Properties
		public int PointCount { get; } // 0x000000018C306E5C-0x000000018C306E9C 
	
		// Nested types
		public class Point // TypeDefIndex: 82027
		{
			// Fields
			public MeshData.ShareVertex shareVertex; // 0x10
			public Point nearPoint; // 0x18
			public float nearDist; // 0x20
	
			// Constructors
			public Point(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public PolygonLinkReduction(float length); // 0x000000018C306D8C-0x000000018C306E5C
	
		// Methods
		public void Create(MeshData meshData); // 0x000000018C306028-0x000000018C306178
		public void Reduction(); // 0x000000018C30635C-0x000000018C306998
		private void AddPoint(MeshData.ShareVertex sv); // 0x000000018C305F74-0x000000018C306028
		private Point GetPoint(MeshData.ShareVertex sv); // 0x000000018C3062D8-0x000000018C30635C
		private void Remove(Point p); // 0x000000018C306998-0x000000018C306A18
		private void SearchNearPointAll(); // 0x000000018C306A18-0x000000018C306B30
		private void SearchNearPoint(Point p); // 0x000000018C306B30-0x000000018C306D8C
		private Point GetNearPointPair(); // 0x000000018C306178-0x000000018C3062D8
	}

	public class Utility // TypeDefIndex: 82029
	{
		// Constructors
		public Utility(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static uint PackPair(int v0, int v1); // 0x0000000188A6045C-0x0000000188A60474
		public static void UnpackPair(uint pack, out int v0, out int v1); // 0x0000000187250CA0-0x0000000187250CB0
		public static ulong PackTriple(int v0, int v1, int v2); // 0x000000018C30DC30-0x000000018C30DD6C
		public static void UnpackTriple(ulong pack, out int v0, out int v1, out int v2); // 0x0000000187250CE0-0x0000000187250D00
		public static ulong PackQuater(int v0, int v1, int v2, int v3); // 0x000000018C30DAB8-0x000000018C30DC30
		public static void UnpackQuater(ulong pack, out int v0, out int v1, out int v2, out int v3); // 0x0000000187250CB0-0x0000000187250CE0
		public static uint Pack16(int hi, int low); // 0x0000000187234120-0x0000000187234130
		public static int Unpack16Hi(uint pack); // 0x0000000187234200-0x0000000187234210
		public static int Unpack16Low(uint pack); // 0x0000000187234210-0x0000000187234220
		public static ulong Pack32(int hi, int low); // 0x000000018723FC20-0x000000018723FC30
		public static int Unpack32Hi(ulong pack); // 0x000000018724B9A0-0x000000018724B9B0
		public static int Unpack32Low(ulong pack); // 0x0000000187235A70-0x0000000187235A80
		public static void CalcFinalDataWorldPositionNormalTangent(FinalData final, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector4> wtanList); // 0x000000018C30CE74-0x000000018C30D840
		public static void CalcFinalDataChildWorldPositionNormalTangent(FinalData final, int meshIndex, List<Vector3> sposList, List<Vector3> snorList, List<Vector4> stanList, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector4> wtanList); // 0x000000018C30C2E4-0x000000018C30CE74
		public static void CalcLocalPositionNormalTangent(Transform root, List<Vector3> wposList, List<Vector3> wnorList, List<Vector4> wtanList); // 0x000000018C30D840-0x000000018C30DAB8
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 81995
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 81996
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}
