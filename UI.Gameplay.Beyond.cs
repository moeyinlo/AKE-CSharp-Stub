/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Beyond;
using Beyond.GEnums;
using Beyond.Gameplay;
using Beyond.Gameplay.Core;
using Beyond.Gameplay.Core.GameMech;
using Beyond.Gameplay.Factory;
using Beyond.Input;
using Beyond.NPC.Avatar;
using Beyond.Resource;
using Beyond.UI;
using Beyond.UI.GPUI;
using Beyond.UI.UIState;
using CriWare;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using IFix.Core;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 24: UI.Gameplay.Beyond.dll - Assembly: UI.Gameplay.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 52882-53078

public class UIEquipRotHelper : TickableUIMono // TypeDefIndex: 52883
{
	// Fields
	private Transform _rotParent; // 0x68
	private Transform _rotTarget; // 0x70
	private Transform _posTarget; // 0x78
	private float _maxLength; // 0x80
	private List<Transform> _slots; // 0x88
	private List<Transform> _rotRoots; // 0x90
	private float _tweenTime; // 0x98
	private Vector3 m_desRot; // 0x9C
	private Vector3 m_desZero; // 0xA8
	private int m_curIndex; // 0xB4
	private int m_maxNum; // 0xB8
	private bool _playing_k__BackingField; // 0xBC

	// Properties
	protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	public bool playing { get; set; } // 0x0000000185FD6F30-0x0000000185FD6F40 0x0000000185FD6F40-0x0000000185FD6F50

	// Constructors
	public UIEquipRotHelper() {} // 0x000000018BC3A804-0x000000018BC3A818

	// Methods
	private Vector3 _ClampRot(Vector3 rot) => default; // 0x000000018BC3A63C-0x000000018BC3A6C4
	private Vector3 _GetNearZero(Vector3 rot) => default; // 0x000000018BC3A6C4-0x000000018BC3A720
	private void _Init() {} // 0x000000018BC3A720-0x000000018BC3A804
	protected override void OnAwake() {} // 0x000000018BC39F38-0x000000018BC39F58
	public override void Tick(float deltaTime) {} // 0x000000018BC3A114-0x000000018BC3A63C
	public void SelectPart(int index) {} // 0x000000018BC39F80-0x000000018BC3A114
	protected override void OnRelease() {} // 0x000000018BC39F58-0x000000018BC39F80
	private void _SelectPart_b__22_0() {} // 0x0000000185FD6F20-0x0000000185FD6F30
}

public class UIWatchPanelCut : TickableUIMono // TypeDefIndex: 52884
{
	// Fields
	private Vector3 m_watchpanelPos; // 0x68
	private Vector3 m_watchpanelDir; // 0x74
	private Vector3 m_watchpanelRadius; // 0x80
	public float minimapRadius; // 0x8C
	public float eclosionRange; // 0x90

	// Properties
	protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 

	// Constructors
	public UIWatchPanelCut() {} // 0x0000000184814DE0-0x0000000184814DF0

	// Methods
	public void Start() {} // 0x0000000185621A70-0x0000000185621B00
	public Vector3 GetIntersectWithLineAndPlane(Vector3 point, Vector3 direct, Vector3 planeNormal, Vector3 planePoint) => default; // 0x000000018BC3A818-0x000000018BC3A97C
	public override void Tick(float deltaTime) {} // 0x0000000185621B00-0x0000000185621BE0
}

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 53074
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_12 _11328A8F924E37E9332EFD9B6E621017D16D4199479DF8ADFCC16A5EB52CB3EB; // 0x00 // Static value (base64): CgAAAAMAAAADAAAA - Metadata: 0x02077424

	// Nested types
	private struct __StaticArrayInitTypeSize_12 // TypeDefIndex: 53073
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace Beyond.PoolCore
{
	public static class ListPoolInitializer_UI_Gameplay_Beyond // TypeDefIndex: 52886
	{
		// Fields
		private static bool s_initialized; // 0x00
	
		// Methods
		private static void InitializeAtRuntime() {} // 0x0000000185F05A00-0x0000000185F05A30
		private static void Initialize() {} // 0x0000000185F05A30-0x0000000185F05AB0
	}
}

namespace Beyond.SourceGenerator
{
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 52887
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 52888
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 52889
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class DataNAttribute : Attribute // TypeDefIndex: 52890
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 52891
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Beyond.UI
{
	public abstract class UICharPassiveBase : MonoBehaviour // TypeDefIndex: 52892
	{
		// Constructors
		protected UICharPassiveBase() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public abstract void OnCharPassiveNumChanged(float num);
	}

	public class UICharPassiveCounter : UICharPassiveBase // TypeDefIndex: 52893
	{
		// Fields
		public UIStateController stateController; // 0x18
		public GameObject countTextRoot; // 0x20
		public UIText countText; // 0x28
		public UIImage[] layerImages; // 0x30
		public string normalStateName; // 0x38
		public string activeStateName; // 0x40
		public int activeCount; // 0x48
		private int m_currentCount; // 0x4C
	
		// Constructors
		public UICharPassiveCounter() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public override void OnCharPassiveNumChanged(float num) {} // 0x000000018BC39BC0-0x000000018BC39D6C
	}

	public class UICharPassiveMultiStates : UICharPassiveBase // TypeDefIndex: 52895
	{
		// Fields
		public UIStateController stateController; // 0x18
		public UIText countText; // 0x20
		public UIText extraCountText; // 0x28
		public StateInfo[] states; // 0x30
		public int fullCount; // 0x38
		private int m_currentCount; // 0x3C
	
		// Nested types
		[Serializable]
		public struct StateInfo // TypeDefIndex: 52894
		{
			// Fields
			public int count; // 0x00
			public string stateName; // 0x08
		}
	
		// Constructors
		public UICharPassiveMultiStates() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public override void OnCharPassiveNumChanged(float num) {} // 0x0000000185822E20-0x0000000185823D50
	}

	public class UICharPassiveZhuangfy : UICharPassiveBase // TypeDefIndex: 52896
	{
		// Fields
		public UIStateController stateController; // 0x18
		public UIText countText; // 0x20
		public UICharPassiveMultiStates.StateInfo[] states; // 0x28
		public UIImage[] layerImages; // 0x30
		public int fullCount; // 0x38
		public UnityEngine.Color emptyColor; // 0x3C
		public UnityEngine.Color normalColor; // 0x4C
		public UnityEngine.Color overloadColor; // 0x5C
		private int m_currentCount; // 0x6C
	
		// Constructors
		public UICharPassiveZhuangfy() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public override void OnCharPassiveNumChanged(float num) {} // 0x000000018BC39D6C-0x000000018BC39F38
	}

	public abstract class ComboSpecialNodeBase : MonoBehaviour // TypeDefIndex: 52897
	{
		// Fields
		protected ComboSkillHint m_owner; // 0x18
	
		// Properties
		public abstract bool needTick { get; }
	
		// Constructors
		protected ComboSpecialNodeBase() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public virtual void OnAssignData(ComboSkillHint owner) {} // 0x000000018BC2B8B8-0x000000018BC2B918
		public virtual void OnReady() {} // 0x000000018BC2B958-0x000000018BC2B998
		public virtual void OnTick(float deltaTime) {} // 0x000000018BC2B9D8-0x000000018BC2BA28
		public virtual void OnCast() {} // 0x000000018BC2B918-0x000000018BC2B958
		public virtual void OnRemove() {} // 0x000000018BC2B998-0x000000018BC2B9D8
		public abstract void OnRelease();
	}

	public class ComboSpecialNodeRingQte : ComboSpecialNodeBase // TypeDefIndex: 52899
	{
		// Fields
		public RectTransform ring; // 0x20
		public RectTransform perfectRegion; // 0x28
		public UIStateController ringStateController; // 0x30
		public UIAnimationWrapper anim; // 0x38
		private float m_initialWidth; // 0x40
		private float m_perfectWidth; // 0x44
		private float m_missWidth; // 0x48
		private float m_totalTime; // 0x4C
		private float m_activeStartTime; // 0x50
		private float m_remainTimeWhenStart; // 0x54
		private RingState m_currentState; // 0x58
		private GameObject m_bgRing01; // 0x60
		private GameObject m_bgRing02; // 0x68
	
		// Properties
		public override bool needTick { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
	
		// Nested types
		private enum RingState // TypeDefIndex: 52898
		{
			None = 0,
			EarlyState = 1,
			PerfectState = 2,
			MissState = 3,
			PressedState = 4
		}
	
		// Constructors
		public ComboSpecialNodeRingQte() {} // 0x000000018BC2C898-0x000000018BC2C8B4
	
		// Methods
		public override void OnAssignData(ComboSkillHint owner) {} // 0x000000018BC2BA28-0x000000018BC2BFB4
		public override void OnCast() {} // 0x000000018BC2BFB4-0x000000018BC2C184
		public override void OnRemove() {} // 0x000000018BC2C2B4-0x000000018BC2C304
		public override void OnTick(float deltaTime) {} // 0x000000018BC2C304-0x000000018BC2C5B8
		public override void OnRelease() {} // 0x000000018BC2C184-0x000000018BC2C2B4
		private void _OnComboSkillRingQte(in EventData<int, float, float> evtData) {} // 0x000000018BC2C69C-0x000000018BC2C80C
		private float _GetRemainTime() => default; // 0x000000018BC2C5D8-0x000000018BC2C69C
		private void _Reset() {} // 0x000000018BC2C80C-0x000000018BC2C898
		public void __iFixBaseProxy_OnAssignData(ComboSkillHint P0) {} // 0x000000018BC2C5B8-0x000000018BC2C5C0
		public void __iFixBaseProxy_OnCast() {} // 0x000000018BC2C5C0-0x000000018BC2C5C8
		public void __iFixBaseProxy_OnRemove() {} // 0x000000018BC2C5C8-0x000000018BC2C5D0
		public void __iFixBaseProxy_OnTick(float P0) {} // 0x000000018BC2C5D0-0x000000018BC2C5D8
	}

	public enum DamageTextType // TypeDefIndex: 52900
	{
		Level0Normal = 0,
		Level1Normal = 1,
		Level0Critical = 2,
		Level1Critical = 3,
		Level0Block = 4,
		Level1Block = 5,
		EnemyDamage = 20,
		Heal = 30,
		IgniteBuff = 50,
		Airborne = 60,
		Crush = 61,
		KnockDown = 62,
		Fracture = 63,
		Immune = 100,
		CommonFlowText = 201,
		LevelUpText = 202
	}

	public class DamageTextCtrl : UIPanelBase // TypeDefIndex: 52902
	{
		// Fields
		public RectTransform content; // 0x70
		public RectTransform prefabNode; // 0x78
		public Vector2 textRandomAreaSize; // 0x80
		public Vector2 textMinDist; // 0x88
		public int textPosMaxRandomTimes; // 0x90
		public UnityEngine.Color damageTextColorPhysical; // 0x94
		public UnityEngine.Color damageTextColorReal; // 0xA4
		public UnityEngine.Color damageTextColorFire; // 0xB4
		public UnityEngine.Color damageTextColorPulse; // 0xC4
		public UnityEngine.Color damageTextColorCryst; // 0xD4
		public UnityEngine.Color damageTextColorNatural; // 0xE4
		public UnityEngine.Color damageTextColorEther; // 0xF4
		public Vector2 mainChrDmgTxtSpawnOffset; // 0x104
		public Vector2 mainChrDmgTxtMoveSpawnOffset; // 0x10C
		public int mainChrDmgTxtMoveNum; // 0x114
		public float mainChrDmgTxtMoveSpawnWaitTime; // 0x118
		public Vector2 guardDmgTxtSpawnOffset; // 0x11C
		public Vector2 guardDmgTxtSpawnAreaSize; // 0x124
		public float dmgTxtCoalitionMaxTime; // 0x12C
		public bool enableGuardDmgTxtOverwrite; // 0x130
		public Vector2 physicalInflictionTextOffset; // 0x134
		public Vector2 spellInflictionTextOffset; // 0x13C
		private static readonly Dictionary<DamageTextType, int> PRE_LOAD_TEXT_COUNTS; // 0x00
		private const string GUARD_OVERWRITE_COALITION_KEY = "guard_overwrite"; // Metadata: 0x02076DAC
		private const string CRYST_BREAK_TEXT_ID = "ui_bat_elemental_cryst_break"; // Metadata: 0x02076DBC
		private bool m_isShow; // 0x144
		private readonly Dictionary<DamageTextType, DamageTextBase> m_textPrefabMap; // 0x148
		private readonly List<DamageTextBase> m_showingTextInstances; // 0x150
		private readonly Dictionary<DamageTextType, Queue<DamageTextBase>> m_textPool; // 0x158
		private readonly Dictionary<DamageTextBase, Vector3> m_showingTextPos; // 0x160
		private readonly Dictionary<AbilitySystem, Dictionary<AbilitySystem, Dictionary<string, CoalitionDetail>>> m_entityCoalitionGroupMap; // 0x168
		private readonly Dictionary<AbilitySystem, Dictionary<int, float>> m_entityTextTimeMap; // 0x170
		private readonly Dictionary<ulong, DamageTextLevelUp> m_charLevelUpTextMap; // 0x178
		private readonly List<EventData<ulong, int>> m_charLevelUpTextToShow; // 0x180
		private readonly List<DamageTextBase> m_toRecycleInTick; // 0x188
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
		private static Vector3 outOfScreenPos { get => default; } // 0x000000018BC37514-0x000000018BC3756C 
	
		// Nested types
		private struct CoalitionDetail // TypeDefIndex: 52901
		{
			// Fields
			public DamageTextBase instance; // 0x00
			public float time; // 0x08
			public double value; // 0x10
		}
	
		// Constructors
		public DamageTextCtrl() {} // 0x00000001857C29E0-0x00000001857C2CE0
		static DamageTextCtrl() {} // 0x0000000185B9F7E0-0x0000000185B9F9B0
	
		// Methods
		public void OnCreate() {} // 0x000000018BC33E44-0x000000018BC34B38
		public void OnClose() {} // 0x000000018BC338EC-0x000000018BC33E44
		public void DebugChangeImpl(bool disableThis) {} // 0x000000018BC32C90-0x000000018BC338EC
		public void OnShow() {} // 0x000000018BC34B84-0x000000018BC34DB8
		public void OnHide() {} // 0x000000018BC34B38-0x000000018BC34B84
		public override void Tick(float deltaTime) {} // 0x0000000185EFF540-0x0000000185EFF600
		private void _OnHpChanged(in EventData<AbilitySystem.Modifier> eventData) {} // 0x000000018BC356D8-0x000000018BC36C54
		private void _OnIgniteBuffText(in EventData<AbilitySystem, Vector3, Vector2, string, EnergyShardType> eventData) {} // 0x000000018BC36C54-0x000000018BC36EF8
		private void _OnPhysicalInflictionApplied(in EventData<AbilitySystem, AbilitySystemForEnemyPart, PhysicalInflictionType> eventData) {} // 0x000000018BC37118-0x000000018BC37260
		private void _OnImmuneText(in EventData<AbilitySystem, Vector3, Vector2, string> eventData) {} // 0x000000018BC36EF8-0x000000018BC37118
		private void _OnSquadInFightChanged(in EventData<bool> eventData) {} // 0x000000018BC37260-0x000000018BC37310
		private void _OnCreateFlowText(in EventData<Vector3, string, UnityEngine.Color> eventData) {} // 0x000000018BC355A4-0x000000018BC356D8
		private void _OnCharLevelUp(in EventData<ulong, int> eventData) {} // 0x000000018BC35320-0x000000018BC355A4
		private Vector2 _GetRandomTextOffset(float width, float height) => default; // 0x000000018BC34F6C-0x000000018BC35034
		private bool _IsTextPosValid(Vector3 newPos) => default; // 0x000000018BC35128-0x000000018BC35320
		private DamageTextBase _CreateTextInstance(DamageTextType textType) => default; // 0x000000018BC34DB8-0x000000018BC34F6C
		private DamageTextBase _InstantiateTextInstance(DamageTextType textType) => default; // 0x000000018BC35034-0x000000018BC35128
		private void _RecycleTextInstance(DamageTextBase textInstance) {} // 0x000000018BC37310-0x000000018BC37514
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
	}

	public class DamageTextCtrlV2 : UIPanelBase // TypeDefIndex: 52905
	{
		// Fields
		public GPUISystem gpuiSystem; // 0x70
		public List<DamageTextBaseV2.DamageTextBaseConfig> damageTextConfigs; // 0x78
		public List<IgnitePrefabOverride> ignitePrefabConfig; // 0x80
		public bool useWorldRandomArea; // 0x88
		public Vector2 textRandomAreaSize; // 0x8C
		public Vector2 textRandomAreaSizeWorld; // 0x94
		public Vector2 textMinDist; // 0x9C
		public int textPosMaxRandomTimes; // 0xA4
		public UnityEngine.Color damageTextColorPhysical; // 0xA8
		public UnityEngine.Color damageTextColorReal; // 0xB8
		public UnityEngine.Color damageTextColorFire; // 0xC8
		public UnityEngine.Color damageTextColorPulse; // 0xD8
		public UnityEngine.Color damageTextColorCryst; // 0xE8
		public UnityEngine.Color damageTextColorNatural; // 0xF8
		public UnityEngine.Color damageTextColorEther; // 0x108
		public Vector2 mainChrDmgTxtSpawnOffset; // 0x118
		public Vector2 mainChrDmgTxtMoveSpawnOffset; // 0x120
		public int mainChrDmgTxtMoveNum; // 0x128
		public float mainChrDmgTxtMoveSpawnWaitTime; // 0x12C
		public float dmgTxtCoalitionMaxTime; // 0x130
		public Vector2 guardDmgTxtSpawnOffset; // 0x134
		public Vector2 guardDmgTxtSpawnAreaSize; // 0x13C
		public bool enableGuardDmgTxtOverwrite; // 0x144
		public Vector2 physicalInflictionTextOffset; // 0x148
		public Vector2 spellInflictionTextOffset; // 0x150
		private const string GUARD_OVERWRITE_COALITION_KEY = "guard_overwrite"; // Metadata: 0x02076DDA
		private const string CRYST_BREAK_TEXT_ID = "ui_bat_elemental_cryst_break"; // Metadata: 0x02076DEA
		private bool m_isShow; // 0x158
		private readonly Dictionary<DamageTextType, DamageTextBaseV2.DamageTextBaseConfig> m_textConfigMap; // 0x160
		private readonly List<DamageTextBaseV2> m_showingTextInstances; // 0x168
		private readonly Queue<DamageTextBaseV2> m_textPool; // 0x170
		private readonly Dictionary<DamageTextBaseV2, Vector3> m_showingTextPos; // 0x178
		private readonly Dictionary<AbilitySystem, Dictionary<AbilitySystem, Dictionary<string, CoalitionDetail>>> m_entityCoalitionGroupMap; // 0x180
		private readonly Dictionary<AbilitySystem, Dictionary<int, float>> m_entityTextTimeMap; // 0x188
		private readonly Dictionary<ulong, DamageTextBaseV2> m_charLevelUpTextMap; // 0x190
		private readonly List<EventData<ulong, int>> m_charLevelUpTextToShow; // 0x198
		private readonly List<DamageTextBaseV2> m_toRecycleInTick; // 0x1A0
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x000000018BC32C38-0x000000018BC32C90 
		private static Vector3 outOfScreenPos { get => default; } // 0x0000000185792B70-0x0000000185795720 
	
		// Nested types
		private struct CoalitionDetail // TypeDefIndex: 52903
		{
			// Fields
			public DamageTextBaseV2 instance; // 0x00
			public float time; // 0x08
			public double value; // 0x10
		}
	
		[Serializable]
		public class IgnitePrefabOverride // TypeDefIndex: 52904
		{
			// Fields
			public EnergyShardType energyShardType; // 0x10
			public string overrideName; // 0x18
			public bool isCrystBreak; // 0x20
	
			// Constructors
			public IgnitePrefabOverride() {} // 0x0000000181E1B510-0x0000000181E1B520
		}
	
		// Constructors
		public DamageTextCtrlV2() {} // 0x000000018311B6C0-0x000000018311B6D0
	
		// Methods
		public void OnCreate() {} // 0x000000018BC2FBA4-0x000000018BC300FC
		public void OnClose() {} // 0x000000018BC2EFD0-0x000000018BC2FBA4
		public void DebugChangeImpl(bool disableThis) {} // 0x0000000185C2B980-0x0000000185C2BB90
		public void OnShow() {} // 0x0000000185F5FE60-0x0000000185F5FE90
		public void OnHide() {} // 0x0000000185EDD180-0x0000000185EDD280
		public override void Tick(float deltaTime) {} // 0x000000018BC30BB8-0x000000018BC32338
		private void _OnHpChanged(in EventData<AbilitySystem.Modifier> eventData) {} // 0x000000018BC32338-0x000000018BC326F8
		private void _OnIgniteBuffText(in EventData<AbilitySystem, Vector3, Vector2, string, EnergyShardType> eventData) {} // 0x000000018BC328F0-0x000000018BC32A3C
		private void _OnPhysicalInflictionApplied(in EventData<AbilitySystem, AbilitySystemForEnemyPart, PhysicalInflictionType> eventData) {} // 0x000000018BC326F8-0x000000018BC328F0
		private void _OnImmuneText(in EventData<AbilitySystem, Vector3, Vector2, string> eventData) {} // 0x000000018BC32A3C-0x000000018BC32AEC
		private void _OnSquadInFightChanged(in EventData<bool> eventData) {} // 0x000000018BC30A88-0x000000018BC30BB8
		private void _OnCreateFlowText(in EventData<Vector3, string, UnityEngine.Color> eventData) {} // 0x000000018BC30840-0x000000018BC30A88
		private void _OnCharLevelUp(in EventData<ulong, int> eventData) {} // 0x000000018BC30310-0x000000018BC30648
		private Vector2 _GetRandomTextOffset(float width, float height, bool useWorldOffset = false /* Metadata: 0x02076DD9 */, Vector3 textWorldPos = default) => default; // 0x000000018BC30648-0x000000018BC30840
		private bool _IsTextPosValid(Vector3 newPos) => default; // 0x000000018BC300FC-0x000000018BC30310
		private DamageTextBaseV2 _CreateTextInstance(DamageTextType textType, string overrideName = null) => default; // 0x000000018BC32AEC-0x000000018BC32C38
		private void _RecycleTextInstance(DamageTextBaseV2 textInstance) {} // 0x00000001857C2CE0-0x00000001857C3080
		public void __iFixBaseProxy_Tick(float P0) {} // 0x0000000185492010-0x0000000185492020
	}

	public class DamageTextBase : TickableUIMono // TypeDefIndex: 52907
	{
		// Fields
		public DamageTextType type; // 0x68
		public float showDuration; // 0x6C
		public List<SpawnPointConfig> spawnPointConfigs; // 0x70
		public UIText text; // 0x78
		public Animation anim; // 0x80
		private bool m_isActive; // 0x88
		private bool m_isFollowingTransform; // 0x89
		private Transform m_followedTransform; // 0x90
		private Vector3 m_followedPosition; // 0x98
		private Vector2 m_uiOffset; // 0xA4
		public PeriodicTimer durationTimer; // 0xB0
		protected UnSafeString.UnSafeStringHandle m_textHandle; // 0xB8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB3080-0x0000000185FB3090 
		public bool isFollowingTransform { get => default; } // 0x000000018BC2EB88-0x000000018BC2EC68 
		public Vector3 worldPosition { get => default; } // 0x0000000185FD6EF0-0x0000000185FD6F10 
		public Vector2 uiOffset { get => default; } // 0x0000000185729580-0x0000000185729640 
	
		// Nested types
		[Serializable]
		public class SpawnPointConfig // TypeDefIndex: 52906
		{
			// Fields
			public Beyond.Gameplay.Core.ObjectType objectType; // 0x10
			public bool followTarget; // 0x14
			public bool useHitPoint; // 0x15
			public Beyond.Gameplay.MountPoint targetMountPoint; // 0x18
	
			// Constructors
			public SpawnPointConfig() {} // 0x0000000185FB7DE0-0x0000000185FB7DF0
		}
	
		// Constructors
		public DamageTextBase() {} // 0x0000000187AB03B8-0x0000000187AB03C0
	
		// Methods
		protected override void OnAwake() {} // 0x000000018BC2DDE4-0x000000018BC2DEA0
		protected override void OnRelease() {} // 0x000000018BC2E888-0x000000018BC2E904
		public override void TailLateTick(float deltaTime) {} // 0x000000018BC2DFD0-0x000000018BC2E58C
		public void SetFollowTarget(AbilitySystem target, AbilitySystem textTargetWhenTransferred, Vector3? hitPoint) {} // 0x000000018BC2E828-0x000000018BC2E888
		public void SetUIOffset(Vector2 offset) {} // 0x000000018BC2DD84-0x000000018BC2DDE4
		public void Clear() {} // 0x000000018BC2DF50-0x000000018BC2DFD0
		public virtual void SetColor(UnityEngine.Color color) {} // 0x000000018BC2DEA0-0x000000018BC2DF50
		public virtual void PlayAnimation() {} // 0x000000018BC2E904-0x000000018BC2EB88
		private void _UpdatePosition() {} // 0x000000018BC2E680-0x000000018BC2E754
		public void SetText(string newText) {} // 0x000000018BC2E754-0x000000018BC2E828
		public void SetText(int newValue) {} // 0x000000018BC2E58C-0x000000018BC2E680
		public void SetText(string prefix, int newValue) {} // 0x0000000184815AB0-0x0000000184815BD0
		public void __iFixBaseProxy_OnAwake() {} // 0x000000018792FE0C-0x000000018792FE14
		public void __iFixBaseProxy_OnRelease() {} // 0x00000001879BDE2C-0x00000001879BDE34
		public void __iFixBaseProxy_TailLateTick(float P0) {} // 0x0000000185FD6F10-0x0000000185FD6F20
	}

	public class DamageTextBaseV2 // TypeDefIndex: 52911
	{
		// Fields
		private static readonly Vector2 INVALID_POS; // 0x00
		private bool m_isFollowingTransform; // 0x10
		private Transform m_followedTransform; // 0x18
		private Vector3 m_followedPosition; // 0x20
		private Vector2 m_uiOffset; // 0x2C
		private GPUIHandle m_uiHandle; // 0x34
		private GPUISystem m_uiSystem; // 0x40
		private DamageTextBaseConfig m_config; // 0x48
		private ulong _targetCharInst_k__BackingField; // 0x50
		protected UnSafeString.UnSafeStringHandle m_textHandle; // 0x58
	
		// Properties
		public ulong targetCharInst { get; set; } // 0x000000018BC2DC94-0x000000018BC2DCB4 0x000000018BC2DC74-0x000000018BC2DC94
		public float textNodeAlpha { get => default; } // 0x0000000181C2FD60-0x0000000181C2FD70 
		public float showDuration { get => default; } // 0x000000018BC2DC4C-0x000000018BC2DC74 
		public bool isFollowingTransform { get => default; } // 0x000000018BC2DCB4-0x000000018BC2DD84 
		public bool isActive { get => default; } // 0x0000000185FD6ED0-0x0000000185FD6EF0 
		public Vector3 worldPosition { get => default; } // 0x000000018BC2DC18-0x000000018BC2DC4C 
		public Vector2 uiOffset { get => default; } // 0x000000018BC2CAC8-0x000000018BC2CB2C 
	
		// Nested types
		[Serializable]
		public class SpawnPointConfig // TypeDefIndex: 52908
		{
			// Fields
			public Beyond.Gameplay.Core.ObjectType objectType; // 0x10
			public bool followTarget; // 0x14
			public bool useHitPoint; // 0x15
			public Beyond.Gameplay.MountPoint targetMountPoint; // 0x18
	
			// Constructors
			public SpawnPointConfig() {} // 0x0000000181460F60-0x0000000181460F70
		}
	
		public enum DamageTextSortingPriority // TypeDefIndex: 52909
		{
			Level0 = 0,
			Level1 = 1,
			Level2 = 2
		}
	
		[Serializable]
		public class DamageTextBaseConfig // TypeDefIndex: 52910
		{
			// Fields
			public DamageTextType type; // 0x10
			public float showDuration; // 0x14
			public List<SpawnPointConfig> spawnPointConfigs; // 0x18
			public DamageTextSortingPriority sortingPriority; // 0x20
			public string prefabName; // 0x28
			public float textNodeAlpha; // 0x30
			public List<string> textNodeName; // 0x38
			public List<string> colorNodeName; // 0x40
			public string leftAnimation; // 0x48
			public string rightAnimation; // 0x50
	
			// Constructors
			public DamageTextBaseConfig() {} // 0x0000000185FB0800-0x0000000185FB0810
		}
	
		// Constructors
		public DamageTextBaseV2() {} // Dummy constructor
		public DamageTextBaseV2(GPUISystem uiSystem) {} // 0x000000018BC2C8B4-0x000000018BC2CA10
		static DamageTextBaseV2() {} // 0x0000000185607380-0x00000001856074E0
	
		// Methods
		public void OnRelease() {} // 0x000000018BC2D988-0x000000018BC2DA04
		public void Assign(DamageTextBaseConfig config, string overrideName = null) {} // 0x000000018BC2CD68-0x000000018BC2D2EC
		public void Tick(Vector2 screenCenter, float scaleFactor) {} // 0x000000018BC2D92C-0x000000018BC2D988
		public void SetFollowTarget(AbilitySystem target, AbilitySystem textTargetWhenTransferred, Vector3? hitPoint) {} // 0x000000018BC2CA10-0x000000018BC2CA6C
		public void SetUIOffset(Vector2 offset) {} // 0x000000018BC2CA6C-0x000000018BC2CAC8
		public void Clear() {} // 0x000000018BC2CBBC-0x000000018BC2CD68
		public void DestroyDisplay() {} // 0x000000018BC2CB2C-0x000000018BC2CBBC
		public virtual void SetColor(UnityEngine.Color color) {} // 0x000000018BC2DA04-0x000000018BC2DBD8
		public virtual void PlayAnimation(bool isLeft = true /* Metadata: 0x02076E07 */) {} // 0x000000018BC2D724-0x000000018BC2D92C
		private void _UpdatePosition(Vector2 screenCenter, float scaleFactor) {} // 0x000000018BC2D51C-0x000000018BC2D724
		public void SetText(string newText) {} // 0x000000018BC2D2EC-0x000000018BC2D51C
		public void SetText(int newValue) {} // 0x000000018BC2DBD8-0x000000018BC2DC18
		public void SetText(string prefix, int newValue) {} // 0x0000000185FD6F10-0x0000000185FD6F20
	}

	public class DamageTextBlock : DamageTextDamageBase // TypeDefIndex: 52912
	{
		// Fields
		public UIImage blockIcon; // 0xC0
	
		// Constructors
		public DamageTextBlock() {} // 0x0000000185F08A00-0x0000000185F08A10
	
		// Methods
		public override void SetColor(UnityEngine.Color color) {} // 0x000000018BC2EC68-0x000000018BC2ED0C
		public void __iFixBaseProxy_SetColor(UnityEngine.Color P0) {} // 0x000000018BC2ED0C-0x000000018BC2ED2C
	}

	public class DamageTextCriticalLevel0 : DamageTextDamageBase // TypeDefIndex: 52913
	{
		// Fields
		public UIText criticalIcon; // 0xC0
	
		// Constructors
		public DamageTextCriticalLevel0() {} // 0x0000000185F08A00-0x0000000185F08A10
	
		// Methods
		public override void SetColor(UnityEngine.Color color) {} // 0x000000018BC2ED2C-0x000000018BC2EDC8
		public void __iFixBaseProxy_SetColor(UnityEngine.Color P0) {} // 0x000000018BC2ED0C-0x000000018BC2ED2C
	}

	public class DamageTextCriticalLevel1 : DamageTextDamageBase // TypeDefIndex: 52914
	{
		// Fields
		public UIText criticalIcon; // 0xC0
		public UIText criticalIconShadow; // 0xC8
		public UIImage bg01; // 0xD0
		public UIImage bg02; // 0xD8
		private const string ANIM_NAME_CRITICAL_LEFT = "battletext_critical_left"; // Metadata: 0x02076E0B
		private const string ANIM_NAME_CRITICAL_RIGHT = "battletext_critical_right"; // Metadata: 0x02076E24
	
		// Constructors
		public DamageTextCriticalLevel1() {} // 0x0000000185F08A00-0x0000000185F08A10
	
		// Methods
		public override void SetColor(UnityEngine.Color color) {} // 0x000000018BC2EEB8-0x000000018BC2EFC8
		public override void PlayAnimation(bool isLeft) {} // 0x000000018BC2EDC8-0x000000018BC2EEB8
		public void __iFixBaseProxy_SetColor(UnityEngine.Color P0) {} // 0x000000018BC2ED0C-0x000000018BC2ED2C
		public void __iFixBaseProxy_PlayAnimation(bool P0) {} // 0x000000018BC2EFC8-0x000000018BC2EFD0
	}

	public class DamageTextDamageBase : DamageTextBase // TypeDefIndex: 52915
	{
		// Constructors
		public DamageTextDamageBase() {} // 0x0000000185F08A00-0x0000000185F08A10
	
		// Methods
		public virtual void PlayAnimation(bool isLeft) {} // 0x000000018BC3756C-0x000000018BC37620
	}

	public class DamageTextIgniteBuff : DamageTextBase // TypeDefIndex: 52916
	{
		// Fields
		public UIImage bg; // 0xC0
		public UIText textDuplication; // 0xC8
		public UIStateController stateController; // 0xD0
	
		// Constructors
		public DamageTextIgniteBuff() {} // 0x0000000185F08A00-0x0000000185F08A10
	
		// Methods
		protected override void OnAwake() {} // 0x00000001857294D0-0x0000000185729580
		protected override void OnRelease() {} // 0x000000018BC37620-0x000000018BC376D4
		public void SetUIState(EnergyShardType energyShardType, bool isCrystBreak = false /* Metadata: 0x02076E3E */) {} // 0x000000018BC377D4-0x000000018BC37918
		public void SetTextAndDuplication(string newText) {} // 0x000000018BC376D4-0x000000018BC377D4
		public void __iFixBaseProxy_OnAwake() {} // 0x000000018BC37918-0x000000018BC37920
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018BC37920-0x000000018BC37928
	}

	public class DamageTextLevelUp : DamageTextBase // TypeDefIndex: 52917
	{
		// Fields
		private ulong _targetCharInst_k__BackingField; // 0xC0
	
		// Properties
		public ulong targetCharInst { get; set; } // 0x0000000181B388F0-0x0000000181B38900 0x00000001835FC740-0x00000001835FC750
	
		// Constructors
		public DamageTextLevelUp() {} // 0x0000000185F08A00-0x0000000185F08A10
	}

	public class DamageTextNormalLevel1 : DamageTextDamageBase // TypeDefIndex: 52918
	{
		// Fields
		private const string ANIM_NAME_NORMAL_LEFT = "battletext_normal_left"; // Metadata: 0x02076E3F
		private const string ANIM_NAME_NORMAL_RIGHT = "battletext_normal_right"; // Metadata: 0x02076E56
	
		// Constructors
		public DamageTextNormalLevel1() {} // 0x0000000185F08A00-0x0000000185F08A10
	
		// Methods
		public override void PlayAnimation(bool isLeft) {} // 0x000000018BC37928-0x000000018BC37A18
		public void __iFixBaseProxy_PlayAnimation(bool P0) {} // 0x000000018BC2EFC8-0x000000018BC2EFD0
	}

	public class FootBarDashCell : MonoBehaviour // TypeDefIndex: 52919
	{
		// Fields
		public bool isHalfCell; // 0x18
		public UIImage bgImage; // 0x20
		public RectTransform cellTrans; // 0x28
		public UIImage grayImage; // 0x30
		public UIImage whiteImage; // 0x38
		public UIAnimationWrapper animWrapper; // 0x40
		[NonSerialized]
		private int m_index; // 0x48
		private const int MAX_DASH_COUNT_IN_RING = 8; // Metadata: 0x02076E6E
		private const float FILL_AMOUNT_PER_CELL = 0.125f; // Metadata: 0x02076E6F
		private const float ANGLE_PER_CELL = 45f; // Metadata: 0x02076E73
		private const float ANGLE_PER_HALF_CELL = 22.5f; // Metadata: 0x02076E77
		private const float ANGLE_PER_QUARTER_CELL = 11.25f; // Metadata: 0x02076E7B
	
		// Constructors
		public FootBarDashCell() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void SetIndex(int index) {} // 0x000000018BC37B68-0x000000018BC37C28
		public void SetDashCount(float dashFillCount) {} // 0x000000018BC37A18-0x000000018BC37B68
		public void StartPlayNotEnoughAnim() {} // 0x000000018BC37C28-0x000000018BC37CD4
		public void StopPlayNotEnoughAnim() {} // 0x000000018BC37CD4-0x000000018BC37D80
	}

	public class HeadBarCtrl : UIPanelBase // TypeDefIndex: 52925
	{
		// Fields
		private GameObject _mobHeadBarPrefab; // 0x70
		private GameObject _eliteHeadBarPrefab; // 0x78
		private GameObject _enemyPartHeadBarPrefab; // 0x80
		private GameObject _levelInfoBarPrefab; // 0x88
		private GameObject _vigilanceBarPrefab; // 0x90
		private GameObject _tacticalItemBarPrefab; // 0x98
		private float _hideHeadBarNotInFightDelay; // 0xA0
		private int _headBarInvisibleEnemyCount; // 0xA4
		private float _headBarInvisibleHpNoChangeTime; // 0xA8
		private float _headBarInvisibleScreenEdgeRatio; // 0xAC
		private float _headBarInvisibleDistance; // 0xB0
		private const float TICK_SURROUNDING_INTERVAL = 0.2f; // Metadata: 0x02076E82
		private const string HEAD_BAR_BROKEN_ANIM = "headbar_broken_in"; // Metadata: 0x02076E86
		private static readonly int[] HEAD_BAR_PREWARM_CNT; // 0x00
		private Transform m_worldObjectRoot; // 0xB8
		private static HashSet<ObjectPtr<AbilitySystem>> s_abilitySystemsToShowBar; // 0x08
		private static HashSet<ObjectPtr<AbilitySystem>> s_abilitySystemsToHideBar; // 0x10
		private static HashSet<ObjectPtr<AbilitySystem>> s_surroundingEnemies; // 0x18
		private float m_lastTickSurrounding; // 0xC0
		private bool m_inDialog; // 0xC4
		private Dictionary<ObjectPtr<AbilitySystem>, UIHeadBarFollower> m_headBarDict; // 0xC8
		private Dictionary<ObjectPtr<AbilitySystem>, UIHeadBarFollower> m_headBarWithOutAnimDict; // 0xD0
		private List<UIHeadBarFollower> m_mobHeadBarPool; // 0xD8
		private List<UIHeadBarFollower> m_eliteHeadBarPool; // 0xE0
		private List<UIHeadBarFollower> m_enemyPartHeadBarPool; // 0xE8
		private Dictionary<ObjectPtr<AbilitySystem>, AbilitySystem.Modifier> m_nonFullHpAbilitySystems; // 0xF0
		private Dictionary<ObjectPtr<AbilitySystem>, ValueTuple<AbilitySystem.Modifier, PeriodicTimer>> m_enemyFirstDamageDict; // 0xF8
		private HashSet<ObjectPtr<AbilitySystem>> m_enabledEnemyPartsByAction; // 0x100
		private Dictionary<ObjectPtr<AbilitySystem>, UILvInfoBar> m_levelInfoBarDict; // 0x108
		private Dictionary<ObjectPtr<AbilitySystem>, UILvInfoBar> m_levelInfoBarWithOutAnimDict; // 0x110
		private List<UILvInfoBar> m_levelInfoBarPool; // 0x118
		private Dictionary<ObjectPtr<AbilitySystem>, UIVigilanceBar> m_vigilanceBarDict; // 0x120
		private List<UIVigilanceBar> m_vigilanceBarPool; // 0x128
		private Dictionary<ObjectPtr<AbilitySystem>, UITacticalItemBar> m_tacticalItemBarDict; // 0x130
		private Dictionary<ObjectPtr<AbilitySystem>, UITacticalItemBar> m_tacticalItemBarWithOutAnimDict; // 0x138
		private List<UITacticalItemBar> m_tacticalItemBarPool; // 0x140
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x000000018BC38DE4-0x000000018BC38E48 
		private bool forceHide { get => default; } // 0x000000018578AA40-0x000000018578AA80 
	
		// Nested types
		public enum HeadBarType // TypeDefIndex: 52920
		{
			Mob = 0,
			Elite = 1,
			EnemyPart = 2,
			CNT = 3
		}
	
		private enum HeadBarRefreshReason // TypeDefIndex: 52921
		{
			OnCreate = 0,
			OnAddHeadBar = 1,
			OnRemoveHeadBar = 2,
			OnHeadBarShowConfigChanged = 3,
			TakeDamage = 4,
			FullHpOrZeroHp = 5,
			EnemyPartEnableChanged = 6,
			LateUpdate = 7,
			Dialog = 8
		}
	
		private sealed class __c__DisplayClass52_0 // TypeDefIndex: 52922
		{
			// Fields
			public ObjectPtr<AbilitySystem> abilitySystemPtr; // 0x10
			public UIHeadBarFollower bar; // 0x20
			public HeadBarCtrl __4__this; // 0x28
	
			// Constructors
			public __c__DisplayClass52_0() {} // 0x0000000185FB6DA0-0x0000000185FB6DB0
	
			// Methods
			internal void __RefreshHeadBar_b__1() {} // 0x00000001848E0A80-0x00000001848E0B80
			internal void __RefreshHeadBar_b__2() {} // 0x00000001850A9AE0-0x00000001850A9F90
		}
	
		private sealed class __c__DisplayClass56_0 // TypeDefIndex: 52923
		{
			// Fields
			public ObjectPtr<AbilitySystem> abilitySystemPtr; // 0x10
			public UILvInfoBar bar; // 0x20
			public HeadBarCtrl __4__this; // 0x28
	
			// Constructors
			public __c__DisplayClass56_0() {} // 0x000000018BC37D80-0x000000018BC38BC4
	
			// Methods
			internal void __UpdateLevelInfoBar_b__0() {} // 0x0000000184D8BB90-0x0000000184D8C1D0
		}
	
		private sealed class __c__DisplayClass58_0 // TypeDefIndex: 52924
		{
			// Fields
			public ObjectPtr<AbilitySystem> abilitySystemPtr; // 0x10
			public UITacticalItemBar bar; // 0x20
			public HeadBarCtrl __4__this; // 0x28
	
			// Constructors
			public __c__DisplayClass58_0() {} // 0x0000000185F66630-0x0000000185F66660
	
			// Methods
			internal void __UpdateTacticalItemBar_b__0() {} // 0x0000000184D8C1D0-0x0000000184D8C250
		}
	
		// Constructors
		public HeadBarCtrl() {} // 0x0000000185492010-0x0000000185492020
		static HeadBarCtrl() {} // 0x000000018BC3D0CC-0x000000018BC3D154
	
		// Methods
		public void OnCreate(Transform worldObjectRoot) {} // 0x000000018BC3903C-0x000000018BC39094
		public void OnClose() {} // 0x000000018BC39094-0x000000018BC39AF8
		public void OnShow() {} // 0x000000018BC38F30-0x000000018BC3903C
		public void OnHide() {} // 0x000000018578AA80-0x000000018578EA90
		public override void LateTick(float deltaTime) {} // 0x00000001856152D0-0x0000000185615B00
		private void _OnAddHeadBar(in EventData<AbilitySystem> eventData) {} // 0x000000018BC38BFC-0x000000018BC38DE4
		private void _OnRemoveHeadBar(in EventData<AbilitySystem, bool> eventData) {} // 0x0000000184DE2330-0x0000000184DE5D00
		private void _OnHeadBarShowConfigChanged() {} // 0x0000000184E0D790-0x0000000184E10AD0
		private void _OnHpChanged(in EventData<AbilitySystem.Modifier> eventData) {} // 0x0000000184D8D630-0x0000000184D90290
		private void _OnEnemyPartEnableChanged(in EventData<AbilitySystemForEnemyPart, bool> eventData) {} // 0x00000001848E2670-0x00000001848E5B70
		private void _RefreshHeadBar(HeadBarRefreshReason reason) {} // 0x0000000184D8C250-0x0000000184D8D630
		private void _PrewarmHeadBar() {}
		private static HeadBarType _GetHeadBarType(ObjectPtr<AbilitySystem> abilitySystemPtr) => default;
		private void _UpdateHeadBar(float deltaTime) {}
		private void _UpdateLevelInfoBar(float deltaTime) {}
		private void _UpdateVigilanceBar(float deltaTime) {} // 0x000000018BC39AF8-0x000000018BC39B68
		private void _UpdateTacticalItemBar(float deltaTime) {} // 0x000000018BC38EB8-0x000000018BC38F30
		private void _UpdateSurroundingEnemies(float deltaTime) {} // 0x000000018BC38E48-0x000000018BC38EB8
		private T _CreateBar<T>(HeadBarType headBarType = HeadBarType.Mob /* Metadata: 0x02076E7F */)
			where T : UIAbilityTargetFollower => default; // 0x000000018BC39B68-0x000000018BC39BC0
		private void _RecycleBar<T>(T bar)
			where T : UIAbilityTargetFollower {} // 0x00000001852C05F0-0x00000001852C0B00
		private List<T> _GetBarPool<T>(HeadBarType headBarType = HeadBarType.Mob /* Metadata: 0x02076E80 */)
			where T : UIAbilityTargetFollower => default; // 0x00000001852C0B00-0x00000001852C0C90
		private GameObject _GetBarPrefab<T>(HeadBarType headBarType = HeadBarType.Mob /* Metadata: 0x02076E81 */)
			where T : UIAbilityTargetFollower => default; // 0x000000018BC38BC4-0x000000018BC38BFC
		private void _OnInteractNpc(in EventData<string, Entity> eventData) {} // 0x0000000187A742A0-0x0000000187A742A8
		private void _OnDialogStart(in EventData<bool, DialogEnums.DialogType> eventData) {} // 0x0000000185492010-0x0000000185492020
		private void _OnDialogFinish(in EventData<bool> eventData) {} // 0x000000018BC3CF78-0x000000018BC3D04C
		private void _SetInDialog(bool inDialog) {} // 0x000000018BC3D04C-0x000000018BC3D0CC
		internal static bool __RefreshHeadBar_g__ToShow_52_0(AbilitySystem abilitySystem) => default; // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018BC3D154-0x000000018BC3D1DC
	}

	[Serializable]
	public class HpChangeDisplayData // TypeDefIndex: 52926
	{
		// Fields
		public int priority; // 0x10
		public float minDamagePercent; // 0x14
		public float maxDamagePercent; // 0x18
		public float stayTime; // 0x1C
		public float decreaseSpeed; // 0x20
	
		// Constructors
		public HpChangeDisplayData() {} // 0x0000000185492010-0x0000000185492020
	}

	public class UIHeadBar : MonoBehaviour // TypeDefIndex: 52928
	{
		// Fields
		private bool _showHpNumber; // 0x18
		private bool _showHpChangeEffect; // 0x19
		private List<HpChangeDisplayData> _hpChangeConfig; // 0x20
		private bool _hidePoiseBarWhenEmpty; // 0x28
		private bool _showPoiseChangeEffect; // 0x29
		private List<HpChangeDisplayData> _poiseChangeConfig; // 0x30
		private bool _highlightWhenWeakLock; // 0x38
		private float _weakLockHighlightScale; // 0x3C
		private float _weakLockScaleTransitionTime; // 0x40
		private int _lvFontSize; // 0x44
		private UIAnimationWrapper _barRootAnim; // 0x48
		private CanvasGroup _lvNode; // 0x50
		private UIText _lvText; // 0x58
		private CanvasGroup _dangerousLvNode; // 0x60
		private UIText _dangerousLvText; // 0x68
		private CanvasGroup _focusHighlight; // 0x70
		private List<UIImage> _hpFastFillList; // 0x78
		private List<UIImage> _hpSlowFillList; // 0x80
		private Transform _hpNumberNode; // 0x88
		private UIText _curHpText; // 0x90
		private UIText _maxHpText; // 0x98
		private RectTransform _hpParentRect; // 0xA0
		private RectTransform _hpEffectRect; // 0xA8
		private CanvasGroup _hpEffectCanvasGroup; // 0xB0
		private GameObject _hpBrokenNode; // 0xB8
		private UIPoiseBar _poiseBar; // 0xC0
		private UIWeaknessNode _weaknessBar; // 0xC8
		private UIBuffNode _attachedBuffNode; // 0xD0
		private UIBuffNode _normalBuffNode; // 0xD8
		private readonly LuaResourceLoader m_loader; // 0xE0
		private ObjectPtr<AbilitySystem> m_target; // 0xE8
		private bool m_hasPoise; // 0xF8
		private HpChangeDisplayData m_currentHpChangeData; // 0x100
		private HpDisplayState m_hpDisplayState; // 0x108
		private readonly PeriodicTimer m_hpStayTimer; // 0x110
		private float? m_targetFillValue; // 0x118
		private float? m_transferToHighlightScaleTime; // 0x120
		private float? m_transferToOriginalScaleTime; // 0x128
		private Vector3 m_beforeTransferScale; // 0x130
		public const float EFFECT_OFFSET = -0.5f; // Metadata: 0x02076EA5
	
		// Nested types
		public enum HpDisplayState // TypeDefIndex: 52927
		{
			Normal = 0,
			Stay = 1,
			Decrease = 2
		}
	
		// Constructors
		public UIHeadBar() {} // 0x00000001857813E0-0x00000001857814B0
	
		// Methods
		private void OnDestroy() {} // 0x000000018BC3D960-0x000000018BC3D9BC
		public void OnPreWarm() {} // 0x0000000185615B50-0x0000000185615BB0
		public void SetTarget(AbilitySystem target) {} // 0x000000018BC3D9BC-0x000000018BC3EB30
		public void ShowModifierAfterSetTarget(in AbilitySystem.Modifier modifier) {} // 0x000000018BC3EB30-0x000000018BC3EC58
		public void Clear() {} // 0x00000001850AB7D0-0x00000001850AC170
		public void Refresh() {} // 0x0000000185B9AC60-0x0000000185B9ACE0
		private void _OnHpChange(Entity entity, double change, bool isMaxHpChanged) {} // 0x0000000183F25790-0x0000000183F26910
		private void _OnForceSetHp(Entity entity) {} // 0x000000018BC3EFD8-0x000000018BC3F1A0
		private void _CalculateHpChangeDisplay(AbilitySystem target, double deltaValue) {} // 0x000000018BC3ED20-0x000000018BC3EFD8
		private void _UpdateHpDisplay(float deltaTime) {} // 0x000000018BC3F77C-0x000000018BC3FAB8
		private void _OnPoiseChange(Entity entity, float change, bool hideUIEffect) {} // 0x000000018BC3F494-0x000000018BC3F530
		private void _OnMultiTimeWeaknessActivate(Entity entity, bool active, int count) {} // 0x000000018BC3F320-0x000000018BC3F494
		private void _OnWeaknessCountChanged(Entity entity, int total, int count) {} // 0x000000018BC3F530-0x000000018BC3F5FC
		private void _OnMainTargetChanged(in EventData<AbilitySystem, bool> eventData) {} // 0x000000018BC3F1A0-0x000000018BC3F320
		private void _UpdateScale(float deltaTime) {} // 0x000000018BC3FAB8-0x000000018BC3FE0C
		private void _SetImageFill(List<UIImage> imageList, float fillValue) {} // 0x000000018BC3F5FC-0x000000018BC3F77C
		public void UpdateData(float deltaTime) {} // 0x000000018BC3EC58-0x000000018BC3ED20
		public void OnBeforeHpBroken() {} // 0x0000000183F250E0-0x0000000183F25790
		public void OnAfterHpBroken() {} // 0x0000000183F24A30-0x0000000183F250E0
	}

	public class UIHeadBarFollower : UIAbilityTargetFollower // TypeDefIndex: 52929
	{
		// Fields
		public HeadBarCtrl.HeadBarType headBarType; // 0x110
		private bool _haveGuideLine; // 0x114
		public UIAnimationWrapper anim; // 0x118
		private UIHeadBar _headBar; // 0x120
		private GameObject _guideLineNode; // 0x128
		private RectTransform _guideLine; // 0x130
		private RectTransform _followTargetEndPoint; // 0x138
		private RectTransform _headBarEndPoint; // 0x140
		private bool m_headBarVisible; // 0x148
	
		// Properties
		protected override bool actualVisible { get => default; } // 0x000000018BC3D94C-0x000000018BC3D960 
	
		// Constructors
		public UIHeadBarFollower() {} // 0x0000000185D6D880-0x0000000185D6D890
	
		// Methods
		public void OnPreWarm() {} // 0x0000000185615B00-0x0000000185615B50
		public override void SetTarget(AbilitySystem target) {} // 0x000000018BC3D310-0x000000018BC3D3D0
		public void ShowModifierAfterSetTarget(in AbilitySystem.Modifier modifier) {} // 0x000000018BC3D3D0-0x000000018BC3D438
		public override void Clear() {} // 0x00000001850AB440-0x00000001850AB4A0
		public void Refresh() {} // 0x000000018BC3D1DC-0x000000018BC3D26C
		public void SetHeadBarVisible(bool visible) {} // 0x000000018BC3D26C-0x000000018BC3D310
		protected override void UpdateData(float deltaTime) {} // 0x000000018BC3D448-0x000000018BC3D4C0
		private void _UpdateGuideLine() {} // 0x000000018BC3D4C0-0x000000018BC3D94C
		public override bool TryGetOriginalFollowPos(out Vector3 followPos) {
			followPos = default;
			return default;
		} // 0x0000000183F24020-0x0000000183F24A20
		public void OnBeforeHpBroken() {} // 0x0000000183F239A0-0x0000000183F24020
		public void OnAfterHpBroken() {} // 0x0000000183F23320-0x0000000183F239A0
		public void __iFixBaseProxy_SetTarget(AbilitySystem P0) {} // 0x000000018BC3D438-0x000000018BC3D440
		public void __iFixBaseProxy_Clear() {} // 0x0000000183F28930-0x0000000183F28940
		public void __iFixBaseProxy_UpdateData(float P0) {} // 0x000000018BC3D440-0x000000018BC3D448
		public bool __iFixBaseProxy_TryGetOriginalFollowPos(out Vector3 P0) {
			P0 = default;
			return default;
		} // 0x0000000183F24A20-0x0000000183F24A30
	}

	public class UIHeadLabel : TickableUIMono // TypeDefIndex: 52935
	{
		// Fields
		private Transform _emojiNode; // 0x68
		private FloatingUIFitter _rootDis; // 0x70
		private Beyond.Gameplay.Core.ObjectType _targetType_k__BackingField; // 0x78
		private ulong _entityLogicId_k__BackingField; // 0x80
		private string m_headLabelIcon; // 0x88
		private string m_headLabelIconOverwrite; // 0x90
		private Vector3 m_originalPosition; // 0x98
		private bool m_hasBindEvent; // 0xA4
		private bool m_hasBindTargetEvent; // 0xA5
		private SerializeFieldDictionary<HeadLabelType, HeadLabelRootData> _subRoots; // 0xA8
		private Dictionary<HeadLabelType, HeadLabelRootVisibleData> m_subRootsVisible; // 0xB0
		private Dictionary<Transform, HeadLabelType> m_subRootsReverse; // 0xB8
		private Transform m_camera; // 0xC0
		private ObjectPtr<Entity> m_target; // 0xC8
		private Transform m_followTarget; // 0xD8
		private NPCAvatarMountPointInfo m_npcMountPointInfo; // 0xE0
		private bool m_inited; // 0xE8
		private bool m_visibleDirty; // 0xE9
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB0510-0x0000000185FB0520 
		public Transform iconHolder { get => default; } // 0x0000000184605CF0-0x0000000184605D20 
		public Beyond.Gameplay.Core.ObjectType targetType { get; set; } // 0x0000000181B5FFD0-0x0000000181B5FFE0 0x0000000184605CC0-0x0000000184605CF0
		public ulong entityLogicId { get; set; } // 0x0000000185218E40-0x0000000185219F30 0x0000000184605C90-0x0000000184605CC0
		public string headLabelIcon { get => default; set {} } // 0x00000001846052C0-0x0000000184605390 0x0000000184604F00-0x00000001846051C0
		public string missionHeadLabelIcon { get => default; set {} } // 0x00000001848D4460-0x00000001848D4530 0x00000001848D4140-0x00000001848D4210
	
		// Nested types
		public enum HeadLabelType // TypeDefIndex: 52930
		{
			Root = 0,
			Bubble = 1,
			Text = 2,
			Icon = 3,
			Count = 4
		}
	
		public enum VisibleSource // TypeDefIndex: 52931
		{
			Comp = 0,
			System = 1,
			FloatingUI = 2,
			Count = 3
		}
	
		[Serializable]
		public class HeadLabelRootData // TypeDefIndex: 52932
		{
			// Fields
			public Transform root; // 0x10
			public HeadLabelType headLabelType; // 0x18
	
			// Constructors
			public HeadLabelRootData() {} // 0x0000000185FB6DA0-0x0000000185FB6DB0
		}
	
		public class HeadLabelRootVisibleData // TypeDefIndex: 52933
		{
			// Fields
			public Vector3 originalPosition; // 0x10
			public Dictionary<VisibleSource, bool> visibleSource; // 0x20
	
			// Properties
			public bool realVisible { get => default; } // 0x000000018BC4013C-0x000000018BC401AC 
	
			// Constructors
			public HeadLabelRootVisibleData() {} // 0x000000018140CF50-0x000000018140CF60
	
			// Methods
			public void Init(Vector3 position) {} // 0x0000000185FB0560-0x0000000185FB0570
			public void UpdateVisible(VisibleSource source, bool visible) {} // 0x0000000185FB05C0-0x0000000185FB05D0
		}
	
		private sealed class __c__DisplayClass49_0 // TypeDefIndex: 52934
		{
			// Fields
			public HeadLabelType headLabelType; // 0x10
			public UIHeadLabel __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass49_0() {} // 0x0000000185FB0540-0x0000000185FB0550
	
			// Methods
			internal void __UpdateFloatingUIVisibleCallback_b__0(bool visible) {} // 0x000000018BC3FFB4-0x000000018BC4013C
		}
	
		// Constructors
		public UIHeadLabel() {} // 0x0000000184605920-0x0000000184605B20
	
		// Methods
		private void _OnSubRootsCollectionChanged() {} // 0x0000000184605410-0x0000000184605920
		private void _TryInitRootData() {} // 0x00000001848D3FF0-0x00000001848D4140
		public void SetVisibleDirty() {} // 0x00000001857292B0-0x0000000185729390
		private void _UpdateVisible() {} // 0x00000001848D3F70-0x00000001848D3FF0
		public void SetSubRootVisible(HeadLabelType type, VisibleSource source, bool visible, bool updateNow) {} // 0x000000018446ED70-0x000000018446FC20
		public void SetTarget(Entity target) {} // 0x00000001844703E0-0x0000000184470A80
		private void _TryUpdateVisibleCallback() {} // 0x000000018BC3FE70-0x000000018BC3FFB4
		private void _ClearVisibleCallback() {} // 0x00000001854F5EB0-0x00000001854F6040
		public void Clear() {} // 0x00000001846C8790-0x00000001846C8910
		public void SetActive(bool active) {} // 0x0000000185679360-0x0000000185679480
		public void ClearEmojis() {} // 0x00000001848D4210-0x00000001848D4330
		private void _UpdateFloatingUIVisibleCallback() {} // 0x0000000184D97790-0x0000000184D97980
		private void _ClearFloatingUIVisibleCallback() {} // 0x00000001844C3F90-0x00000001844C4440
		private void _OnMissionTypeIconChanged(in EventData<string> data) {} // 0x0000000184605200-0x00000001846052C0
		private void _BindMissionTracking() {} // 0x00000001844C3B10-0x00000001844C3E40
		private void _UnBindMissionTracking() {} // 0x0000000185218CF0-0x0000000185218D30
		private void _BindTargetEvent() {} // 0x00000001844C3E40-0x00000001844C3F20
		private void _UnBindTargetEvent() {} // 0x00000001854F5E30-0x00000001854F5EB0
		private void _OnNpcVisibleChanged(in EventData<string> eventData) {} // 0x00000001846C8710-0x00000001846C8790
		private void _UpdatePos() {} // 0x000000018BC3FE0C-0x000000018BC3FE70
		private void _RefreshVisible(bool bubbleRoot, bool textNode, bool iconHolderNode) {} // 0x0000000184815BE0-0x0000000184815D10
		private void _TryUpdateVisible() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		protected override void OnAwake() {} // 0x0000000187A742A0-0x0000000187A742A8
		public override void LateTick(float deltaTime) {} // 0x0000000187AAA40C-0x0000000187AAA414
		protected override void OnEnable() {} // 0x0000000187AAA404-0x0000000187AAA40C
		protected override void OnDisable() {} // 0x000000018792FE0C-0x000000018792FE14
		protected override void OnRelease() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000185219F30-0x0000000185219F70
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000184605390-0x0000000184605410
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000185219F70-0x000000018521A080
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnRelease() {} // 0x00000001846051C0-0x0000000184605200
	}

	public class UILvInfoBar : UIAbilityTargetFollower // TypeDefIndex: 52936
	{
		// Fields
		public UIAnimationWrapper anim; // 0x110
		private Transform _lvNode; // 0x118
		private UIText _lvText; // 0x120
		private Transform _dangerousLvNode; // 0x128
		private UIText _dangerousLvText; // 0x130
	
		// Constructors
		public UILvInfoBar() {} // 0x0000000185FAE7B0-0x0000000185FAE7C0
	
		// Methods
		public override void SetTarget(AbilitySystem target) {} // 0x000000018BC401AC-0x000000018BC40450
		public override bool TryGetOriginalFollowPos(out Vector3 followPos) {
			followPos = default;
			return default;
		} // 0x0000000183F26910-0x0000000183F27310
		public void __iFixBaseProxy_SetTarget(AbilitySystem P0) {} // 0x000000018BC3D438-0x000000018BC3D440
		public bool __iFixBaseProxy_TryGetOriginalFollowPos(out Vector3 P0) {
			P0 = default;
			return default;
		} // 0x0000000183F24A20-0x0000000183F24A30
	}

	public class UIPoiseBar : MonoBehaviour // TypeDefIndex: 52938
	{
		// Fields
		private UIImage _increaseFill; // 0x18
		private RectTransform _increaseHead; // 0x20
		private CanvasGroup _increaseCanvasGroup; // 0x28
		private UIImage _decreaseFill; // 0x30
		private CanvasGroup _decreaseCanvasGroup; // 0x38
		private UIPoiseKnot _poiseKnot; // 0x40
		private UIAnimationWrapper _poiseBreakAnim; // 0x48
		private CanvasGroup _poiseBreakCanvasGroup; // 0x50
		private RectTransform _poiseParentRect; // 0x58
		private RectTransform _poiseEffectRect; // 0x60
		private CanvasGroup _poiseEffectCanvasGroup; // 0x68
		private ObjectPtr<AbilitySystem> m_owner; // 0x70
		private bool m_isInPoiseRecovery; // 0x80
		private bool m_hidePoiseBarWhenEmpty; // 0x81
		private bool m_showPoiseChangeEffect; // 0x82
		private List<HpChangeDisplayData> m_poiseChangeConfig; // 0x88
		private HpChangeDisplayData m_currentPoiseChangeData; // 0x90
		private PoiseDisplayState m_poiseDisplayState; // 0x98
		private readonly PeriodicTimer m_poiseStayTimer; // 0xA0
		private float? m_targetFillValue; // 0xA8
		private float m_slowFillValue; // 0xB0
		private bool m_enemyPartHide; // 0xB4
		private List<UIPoiseKnot> m_poiseKnotList; // 0xB8
		private List<UIPoiseKnot> m_poiseKnotPool; // 0xC0
		private bool m_isPoiseKnotInited; // 0xC8
		public const float EFFECT_OFFSET = -0.5f; // Metadata: 0x02076EB5
	
		// Properties
		public AbilitySystem owner { get => default; } // 0x000000018BC4197C-0x000000018BC419B8 
		public float maxPoise { get => default; } // 0x000000018BC41958-0x000000018BC4197C 
		public float realPoise { get => default; } // 0x000000018BC419B8-0x000000018BC419E0 
		private bool hidePoiseBar { get => default; } // 0x000000018BC41884-0x000000018BC41958 
	
		// Nested types
		public enum PoiseDisplayState // TypeDefIndex: 52937
		{
			Normal = 0,
			Stay = 1,
			Increase = 2
		}
	
		// Constructors
		public UIPoiseBar() {} // 0x0000000185712D40-0x0000000185712E50
	
		// Methods
		public void Init(AbilitySystem owner, bool hidePoiseBarWhenEmpty, bool showPoiseChangeEffect, List<HpChangeDisplayData> poiseChangeConfig) {} // 0x000000018BC40450-0x000000018BC40858
		public void Clear() {} // 0x00000001850AB720-0x00000001850AB7D0
		public void OnPoiseChange(Entity entity, float change, bool hideUIEffect) {} // 0x000000018BC40858-0x000000018BC40E14
		public void Refresh() {} // 0x0000000185B9ACE0-0x0000000185B9AD30
		public void UpdatePoiseBar(float deltaTime) {} // 0x000000018BC40E14-0x000000018BC40F3C
		private void _CalculatePoiseChangeDisplay(double deltaValue) {} // 0x000000018BC40F3C-0x000000018BC411F4
		private void _UpdatePoiseDisplay(float deltaTime) {} // 0x000000018BC4164C-0x000000018BC41884
		private void _TryInitPoiseKnot(AbilitySystem owner) {} // 0x000000018BC413AC-0x000000018BC4164C
		private void _ClearPoiseKnot() {} // 0x00000001850AB570-0x00000001850AB720
		private UIPoiseKnot _CreatePoiseKnot() => default; // 0x000000018BC411F4-0x000000018BC413AC
	}

	public class UITacticalItemBar : UIAbilityTargetFollower // TypeDefIndex: 52939
	{
		// Fields
		private float _castFillMin; // 0x110
		private float _castFillMax; // 0x114
		public UIAnimationWrapper anim; // 0x118
		private UIImage _castFill; // 0x120
		private UIImage _itemIcon; // 0x128
		private const string UI_SPRITE_ITEM = "ItemIcon"; // Metadata: 0x02076EBC
		private string m_itemId; // 0x130
	
		// Constructors
		public UITacticalItemBar() {} // 0x0000000185FAEA60-0x0000000185FAEA80
	
		// Methods
		public override void SetTarget(AbilitySystem target) {} // 0x000000018BC419E0-0x000000018BC41C28
		public override void Clear() {} // 0x0000000183F27310-0x0000000183F27CA0
		protected override void UpdateData(float deltaTime) {} // 0x000000018BC41C28-0x000000018BC41CFC
		public bool IsTacticalItemActive() => default; // 0x0000000183F27CA0-0x0000000183F28930
		public void __iFixBaseProxy_SetTarget(AbilitySystem P0) {} // 0x000000018BC3D438-0x000000018BC3D440
		public void __iFixBaseProxy_Clear() {} // 0x0000000183F28930-0x0000000183F28940
		public void __iFixBaseProxy_UpdateData(float P0) {} // 0x000000018BC3D440-0x000000018BC3D448
	}

	public class UIVigilanceBar : UIAbilityTargetFollower // TypeDefIndex: 52940
	{
		// Fields
		private UIAnimationWrapper _vigilanceNode; // 0x110
		private UIImage _vigilanceFill; // 0x118
		private CanvasGroup _vigilanceDim; // 0x120
		private CanvasGroup _vigilanceLight; // 0x128
		private bool m_isVigilanceActive; // 0x130
		private bool m_isVigilanceFull; // 0x131
		private bool m_isVigilanceVisible; // 0x132
	
		// Properties
		protected override bool actualVisible { get => default; } // 0x0000000183F29A30-0x0000000183F29A50 
		protected override bool needUpdateTransform { get => default; } // 0x0000000183F29A50-0x0000000183F29A70 
	
		// Constructors
		public UIVigilanceBar() {} // 0x0000000185FAE7B0-0x0000000185FAE7C0
	
		// Methods
		public override void SetTarget(AbilitySystem target) {} // 0x000000018BC41E80-0x000000018BC41FB8
		public override void Clear() {} // 0x000000018BC41CFC-0x000000018BC41D5C
		public void Refresh() {} // 0x000000018BC41D5C-0x000000018BC41E80
		protected override void UpdateData(float deltaTime) {} // 0x000000018BC41FB8-0x000000018BC42018
		private void _UpdateVigilanceNode() {} // 0x000000018BC42018-0x000000018BC42318
		private void _SetVigilanceActive(bool active) {} // 0x0000000183F29360-0x0000000183F29A30
		public override bool TryGetOriginalFollowPos(out Vector3 followPos) {
			followPos = default;
			return default;
		} // 0x0000000183F28940-0x0000000183F29340
		private void __UpdateVigilanceNode_b__15_0() {} // 0x0000000183F29340-0x0000000183F29350
		private void __UpdateVigilanceNode_b__15_1() {} // 0x0000000183F29350-0x0000000183F29360
		public void __iFixBaseProxy_SetTarget(AbilitySystem P0) {} // 0x000000018BC3D438-0x000000018BC3D440
		public void __iFixBaseProxy_Clear() {} // 0x0000000183F28930-0x0000000183F28940
		public void __iFixBaseProxy_UpdateData(float P0) {} // 0x000000018BC3D440-0x000000018BC3D448
		public bool __iFixBaseProxy_TryGetOriginalFollowPos(out Vector3 P0) {
			P0 = default;
			return default;
		} // 0x0000000183F24A20-0x0000000183F24A30
	}

	public class UIWeaknessNode : MonoBehaviour // TypeDefIndex: 52941
	{
		// Fields
		public CanvasGroup weaknessCell; // 0x18
		private readonly List<CanvasGroup> m_weaknessCells; // 0x20
	
		// Constructors
		public UIWeaknessNode() {} // 0x00000001848179E0-0x0000000184817A70
	
		// Methods
		private void Awake() {} // 0x000000018BC42318-0x000000018BC423B8
		public void SetTotalCellNum(int num) {} // 0x000000018BC42484-0x000000018BC42724
		public void SetCurrentCellNum(int num) {} // 0x000000018BC423B8-0x000000018BC42484
	}

	public class AtbCell : MonoBehaviour // TypeDefIndex: 52942
	{
		// Fields
		public UIImage fill; // 0x18
		public UIAnimationWrapper fillLoop; // 0x20
		public RectTransform blinkRect; // 0x28
		public UIAnimationWrapper recover; // 0x30
		public UIAnimationWrapper anim; // 0x38
		public LayoutElement layoutElement; // 0x40
		[NonSerialized]
		public float recoverInitFillAmount; // 0x48
		[NonSerialized]
		public bool atbRecovering; // 0x4C
	
		// Constructors
		public AtbCell() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public class AtbNode : UIPanelBase // TypeDefIndex: 52944
	{
		// Fields
		public AtbCell atbCell; // 0x70
		public RectTransform atbGroup; // 0x78
		public UIAnimationWrapper atbSkillHint; // 0x80
		public UnityEngine.Color atbColorFull; // 0x88
		public UnityEngine.Color atbColorNotFull; // 0x98
		public float atbFillSpeed; // 0xA8
		public string atbHintFillOnEvent; // 0xB0
		private readonly List<AtbCell> m_atbValueCellList; // 0xB8
		private bool m_atbShowing; // 0xC0
		private float m_showingAtbValue; // 0xC4
		private const float ATB_PRESS_THRESHOLD = 0.03f; // Metadata: 0x02076EC5
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x00000001850D4ED0-0x00000001850D4F40 
		private BattleManager battleManager { get => default; } // 0x00000001850D4590-0x00000001850D4BA0 
		private SkillSetting skillSetting { get => default; } // 0x000000018BC3A9C0-0x000000018BC3AB44 
	
		// Nested types
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 52943
		{
			// Fields
			public AtbCell cell; // 0x10
	
			// Constructors
			public __c__DisplayClass24_0() {} // 0x0000000185FB6DA0-0x0000000185FB6DB0
	
			// Methods
			internal void _OnGainAtb_b__0() {} // 0x000000018BC3B034-0x000000018BC3B06C
		}
	
		// Constructors
		public AtbNode() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void OnCreate() {} // 0x00000001850D4D00-0x00000001850D4ED0
		public void OnClose() {} // 0x0000000185841940-0x0000000185841C10
		public override void LateTick(float deltaTime) {} // 0x00000001850D4C00-0x00000001850D4D00
		public void CheckAtbLoopAnim() {} // 0x000000018BC3AFC8-0x000000018BC3B034
		private void _RefreshAtbShowing() {} // 0x000000018BC3AF68-0x000000018BC3AFC8
		private void _OnAtbCellOutAnimCallback() {} // 0x000000018BC3AB44-0x000000018BC3AF68
		public void OnInFightChanged(in EventData<bool> eventData) {} // 0x0000000185ECAE90-0x0000000185ECAF20
		public void OnGainAtb(in EventData<float> eventData) {} // 0x0000000187A742A0-0x0000000187A742A8
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018BC3CF5C-0x000000018BC3CF78
	}

	public class ComboSkillHint : MonoBehaviour // TypeDefIndex: 52945
	{
		// Fields
		public const string SPECIAL_NODE_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Prefabs/Battle/Widgets/ComboSkillSpecialNode/"; // Metadata: 0x02076EC9
		public CanvasGroup content; // 0x18
		public UIButton button; // 0x20
		public UIImage fill; // 0x28
		public UIImage icon; // 0x30
		public UIImage charHead; // 0x38
		public GameObject maskNode; // 0x40
		public UIImage mask2Img; // 0x48
		public UIAnimationWrapper anim; // 0x50
		[NonSerialized]
		public ComboSpecialNodeBase specialNode; // 0x58
		[NonSerialized]
		public bool needTick; // 0x60
		[NonSerialized]
		public int charIndex; // 0x64
		private ComboSkillPanel m_owner; // 0x68
		private Beyond.Gameplay.Core.SkillData m_cachedSkillData; // 0x70
		private string m_lastSpecialNodeName; // 0x78
	
		// Constructors
		public ComboSkillHint() {} // 0x0000000185C31A90-0x0000000185C31AE0
	
		// Methods
		public void Init(ComboSkillPanel owner, int charIndex, bool isDefaultPanel) {} // 0x0000000184A0FE70-0x0000000184A11110
		public void OnReady() {} // 0x000000018BC3B0D8-0x000000018BC3B140
		public void OnCast() {} // 0x000000018BC3B06C-0x000000018BC3B0D8
		public void OnTick(float deltaTime) {} // 0x000000018BC3B1AC-0x000000018BC3B218
		public void OnRemove() {} // 0x000000018BC3B140-0x000000018BC3B1AC
		public void Release() {} // 0x000000018BC3B218-0x000000018BC3B284
		public void AssignData(AbilitySystem abilityCom) {} // 0x0000000184A0DD50-0x0000000184A0DEE0
		public void SetVisible(bool visible) {} // 0x000000018BC3B284-0x000000018BC3B2E0
	}

	public class ComboSkillPanel : UIPanelBase // TypeDefIndex: 52949
	{
		// Fields
		public const string UI_SPRITE_ROUND_CHAR_HEAD = "CharRoundIcon"; // Metadata: 0x02076F20
		public UIButton buttonCast; // 0x70
		public RectTransform infoNode; // 0x78
		public ComboSkillHint[] comboSkillHints; // 0x80
		public UICustomLayoutElement customLayoutElement; // 0x88
		public UIStateController infoNodeStateController; // 0x90
		public float comboHintDisableAlpha; // 0x98
		public float comboHintFirstScale; // 0x9C
		private readonly List<int> m_charIndexList; // 0xA0
		private UnityAction m_onLayoutDataLoaded; // 0xA8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x00000001858ED500-0x00000001858ED630 
	
		// Nested types
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 52946
		{
			// Fields
			public ComboSkillHint hint; // 0x10
			public ComboSkillPanel __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass21_0() {} // 0x0000000181C6A970-0x0000000181C6A980
	
			// Methods
			internal void __RemoveComboSkill_b__0() {} // 0x0000000184A0DEE0-0x0000000184A0FE70
		}
	
		private sealed class __c__DisplayClass22_0 // TypeDefIndex: 52947
		{
			// Fields
			public ComboSkillHint hint; // 0x10
	
			// Constructors
			public __c__DisplayClass22_0() {} // 0x0000000184A0DB40-0x0000000184A0DB80
	
			// Methods
			internal void __OnComboSkillClearAll_b__0() {} // 0x000000018BC3B644-0x000000018BC3B6F4
		}
	
		private sealed class __c__DisplayClass23_0 // TypeDefIndex: 52948
		{
			// Fields
			public ComboSkillPanel __4__this; // 0x10
			public ComboSkillHint hint; // 0x18
	
			// Constructors
			public __c__DisplayClass23_0() {} // 0x0000000183F193F0-0x0000000183F1C050
	
			// Methods
			internal void _CastComboSkill_b__0() {} // 0x000000018BC3B6F4-0x000000018BC3B918
		}
	
		// Constructors
		public ComboSkillPanel() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void OnCreate(bool isDefaultPanel, bool isControllerPanel) {} // 0x0000000184A0DC20-0x0000000184A0DD50
		public void OnShow() {} // 0x000000018BC3B920-0x000000018BC3BAC4
		protected override void OnRelease() {} // 0x000000018BC3BAC4-0x000000018BC3BB28
		private void _UnbindListeners() {} // 0x000000018BC3BB28-0x000000018BC3BCE0
		public override void PreTick(float deltaTime) {} // 0x00000001858ED1E0-0x00000001858ED500
		private void _CheckUpdate() {} // 0x000000018BC3B2E0-0x000000018BC3B644
		private void _OnBattleTeamChanged() {} // 0x0000000184A0DB80-0x0000000184A0DC20
		private void _OnComboSkillReady(in EventData<int> eventData) {} // 0x0000000185EBD870-0x0000000185EBD910
		private void _OnComboSkillRemove(in EventData<int> eventData) {} // 0x0000000183F18E00-0x0000000183F193F0
		private void _RemoveComboSkill(int charIndex) {} // 0x000000018BC3B918-0x000000018BC3B920
		private void _OnComboSkillClearAll() {} // 0x0000000187E9B658-0x0000000187E9B660
		public void CastComboSkill(PointerEventData eventData = null) {} // 0x0000000185492010-0x0000000185492020
		private void _ResortSiblingIndex() {} // 0x0000000183F23070-0x0000000183F23160
		private void _OnCreate_b__12_0() {} // 0x0000000183F23160-0x0000000183F23230
		public void __iFixBaseProxy_OnRelease() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_PreTick(float P0) {} // 0x0000000183F23230-0x0000000183F23320
	}

	public class HpBarComboNode : MonoBehaviour // TypeDefIndex: 52950
	{
		// Fields
		public GameObject comboCountLayout; // 0x18
		public UIText comboCountText; // 0x20
		private UIAnimationWrapper m_animationWrapper; // 0x28
		private int m_lastCount; // 0x30
		private const string COMMON_COMBO_GLOBAL_BUFF_ID = "global_buff_combo_trigger"; // Metadata: 0x02076F2F
	
		// Constructors
		public HpBarComboNode() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Awake() {} // 0x00000001850A9610-0x00000001850A97E0
		private void OnDestroy() {} // 0x000000018BC3BCE0-0x000000018BC3BE64
		private void _OnGlobalBuffStart(in EventData<GlobalBuff, string> eventData) {} // 0x0000000185D70C60-0x0000000185D70CD0
		private void _OnGlobalBuffFinish(in EventData<GlobalBuff, string, GlobalBuff.FinishReason> eventData) {} // 0x000000018BC3BF20-0x000000018BC3BFBC
		private void _RefreshComboCount(bool isEarly = false /* Metadata: 0x02076F2E */) {} // 0x00000001850A7CF0-0x00000001850A7DF0
		private void _AnimInCallback() {} // 0x000000018BC3BE64-0x000000018BC3BEBC
		private void _AnimOutCallback() {} // 0x000000018BC3BEBC-0x000000018BC3BF20
	}

	public class MainCharHpBar : TickableUIMono // TypeDefIndex: 52952
	{
		// Fields
		public UIAnimationWrapper hpBar; // 0x68
		public UIText hpText; // 0x70
		public UIImage hpWhiteFill; // 0x78
		public GameObject blinkAnimObject; // 0x80
		public float hpBlinkPercent; // 0x88
		public float hpChangeColorPercent; // 0x8C
		public UIImage hpFillHigh; // 0x90
		public UIImage hpFillLow; // 0x98
		public RectTransform hpVfxNode; // 0xA0
		public UIImage[] hpVfxImages; // 0xA8
		public SerializeFieldDictionary<SpellInflictionOnCharType, UnityEngine.Color> hpVfXColors; // 0xB0
		public List<HpChangeDisplayData> hpChangeConfigList; // 0xB8
		public List<HpScreenEffectConfig> hpScreenEffectConfigList; // 0xC0
		public float hpScreenEffectCd; // 0xC8
		public UIBuffNode buffNode; // 0xD0
		public UISpellInflictionOnCharNode spellInflictionOnCharNode; // 0xD8
		public UIImage buffIcon; // 0xE0
		public Transform leftLayout; // 0xE8
		public Transform charPassiveNode; // 0xF0
		public GameObject ultimateProgress; // 0xF8
		public UIImage ultimateProgressFill; // 0x100
		public float ultimateProgressFillSmoothTime; // 0x108
		public UnityEngine.Color colorDefault; // 0x10C
		public UnityEngine.Color colorRed; // 0x11C
		public UnityEngine.Color colorYellow; // 0x12C
		public UnityEngine.Color colorBlue; // 0x13C
		public UnityEngine.Color colorGreen; // 0x14C
		private const string HP_BLINK_ANIM = "characterfootbar_warninginternal"; // Metadata: 0x02076F49
		private bool m_nodeShowing; // 0x15C
		private Entity m_mainChar; // 0x160
		private HpChangeDisplayData m_hpChangeConfig; // 0x168
		private UIHeadBar.HpDisplayState m_hpDisplayState; // 0x170
		private float? m_targetHpValue; // 0x174
		private readonly PeriodicTimer m_hpStayTimer; // 0x180
		private bool m_hpBarShowing; // 0x188
		private bool m_hpBarShaking; // 0x189
		private UIAnimationWrapper m_hpVfxAnimWrapper; // 0x190
		private UIHudFadeController m_hudFadeController; // 0x198
		private static readonly HashSet<string> s_tempCurPassiveUIPrefabNames; // 0x00
		private static readonly List<string> s_tempUnusedPassiveUIPrefabNames; // 0x08
		private readonly Dictionary<string, UICharPassiveBase> m_allPassiveBases; // 0x1A0
		private UICharPassiveBase m_curPassiveBase; // 0x1A8
		private UIAnimationWrapper m_buffIconAnimWrapper; // 0x1B0
		private UIAnimationWrapper m_shakeAnimWrapper; // 0x1B8
		private UIAnimationWrapper m_hpWhiteAnimWrapper; // 0x1C0
		private UIAnimationWrapper m_ultimateBuffProgressAnimWrapper; // 0x1C8
		private UnSafeString.UnSafeStringHandle m_hpTextHandle; // 0x1D0
		private readonly LuaResourceLoader m_loader; // 0x1D8
		private float m_lastHpScreenEffectTime; // 0x1E0
		private bool m_ultimateProgressShowing; // 0x1E4
		private ObjectPtr<Buff> m_ultimateBuffPtr; // 0x1E8
		private float m_ultimateBuffProgressShowingFillAmount; // 0x1F8
		private float m_ultimateBuffProgressSmoothVelocity; // 0x1FC
		private readonly List<ObjectPtr<AbilitySystem>> m_ultimateBuffProgressRegisteredCharacters; // 0x200
		private readonly List<ObjectPtr<Buff>> m_activeUltimateBuffs; // 0x208
		private readonly List<ObjectPtr<Buff>> m_activeCharHpBarVfxBuffs; // 0x210
		private ObjectPtr<Buff> m_charHpBarVfxBuffPtr; // 0x218
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
	
		// Nested types
		[Serializable]
		public struct HpScreenEffectConfig // TypeDefIndex: 52951
		{
			// Fields
			public float minHpPercent; // 0x00
			public float maxHpPercent; // 0x04
			public string effectName; // 0x08
		}
	
		// Constructors
		public MainCharHpBar() {} // 0x000000018586CD90-0x000000018586E400
		static MainCharHpBar() {} // 0x0000000185EB7C10-0x0000000185EB7D00
	
		// Methods
		protected override void OnAwake() {} // 0x00000001845A7800-0x00000001845A7B90
		protected override void OnEnable() {} // 0x00000001848F8BA0-0x00000001848F8C80
		protected override void OnRelease() {} // 0x000000018BC3BFBC-0x000000018BC3C57C
		public void OnShow() {} // 0x0000000185C3C790-0x0000000185C3C840
		public void OnHide() {} // 0x0000000185D8F300-0x0000000185D8F360
		private void _ClearMainChar() {} // 0x0000000185A48D80-0x0000000185A4B8E0
		public override void LateTick(float deltaTime) {} // 0x00000001848F9600-0x00000001848FA340
		private bool _CheckHpBarShowing() => default; // 0x00000001848FA340-0x00000001848FA3A0
		private void _SetHpBarShowing(bool showing, bool animate) {} // 0x00000001848F9340-0x00000001848F94F0
		private void _OnMainCharChange(in EventData<SetLeaderReason, Entity, Entity> data) {} // 0x000000018BC3C950-0x000000018BC3C9B4
		private void _ProcessOnMainCharChange(Entity newMainChar) {} // 0x0000000185655F70-0x000000018565A510
		private void _OnTeamChanged() {} // 0x000000018507AC60-0x000000018507BB60
		private void _OnHpChange(Entity entity, double change, bool isMaxHpChanged) {} // 0x0000000183F1EBB0-0x0000000183F20100
		private void _SetHpFillAmount(float hpPct) {} // 0x0000000185B8A6E0-0x0000000185B8A840
		private void _CalculateHpChangeDisplay(AbilitySystem target, double deltaValue) {} // 0x0000000184D3E830-0x0000000184D3E920
		private void _UpdateHpDisplay(float deltaTime) {} // 0x00000001848F94F0-0x00000001848F9600
		private void _OnTakeDamage(Entity entity, bool hideMainCharHpScreenEffect) {} // 0x000000018BC3C9B4-0x000000018BC3CD88
		private void _OnMainCharHpActiveChange() {} // 0x00000001848F8B10-0x00000001848F8BA0
		private bool _IsCharHpBarVfxBuffValid(ObjectPtr<Buff> buffPtr) => default; // 0x0000000183F1DF60-0x0000000183F1EBB0
		private void _RebuildCharHpBarVfxBuffCache() {} // 0x0000000183F20100-0x0000000183F21560
		private ObjectPtr<Buff> _GetLatestValidCharHpBarVfxBuffPtrFromCache() => default; // 0x0000000183F1D030-0x0000000183F1DF60
		private void _OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason) {} // 0x000000018599C830-0x000000018599DD00
		private void _RefreshBuffChangeCharHpBarVfx() {} // 0x0000000183F21560-0x0000000183F23070
		private void _HpVfxOutAnimCallback() {} // 0x0000000185F5F180-0x0000000185F5F1E0
		private void _OnCharPassiveNumChanged(float newNum) {} // 0x000000018BC3C898-0x000000018BC3C950
		private UICharPassiveBase _GetOrCreateCharPassiveBase(string prefabName) => default; // 0x00000001850790E0-0x0000000185079470
		private void _OnProgressBarBuffChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason) {} // 0x000000018599C750-0x000000018599C830
		private void _OnBuffEnhanceChanged(ObjectPtr<Buff> buffPtr) {} // 0x000000018BC3C774-0x000000018BC3C898
		private void _BlinkBuffIcon(string spritePath) {} // 0x000000018BC3C57C-0x000000018BC3C66C
		private void _SetUltimateBuff(ObjectPtr<Buff> buffPtr) {} // 0x0000000185655BD0-0x0000000185655C90
		private void _UltimateBuffProgressOutAnimCallback() {} // 0x000000018BC3CEFC-0x000000018BC3CF5C
		private void _RebuildUltimateBuffTracking() {} // 0x00000001850AD6D0-0x00000001850AE990
		private bool _IsUltimateBuffValid(ObjectPtr<Buff> buffPtr) => default; // 0x000000018BC3C66C-0x000000018BC3C774
		private ObjectPtr<Buff> _GetUltimateBuffForAbility(AbilitySystem ability) => default; // 0x0000000185655AE0-0x0000000185655BD0
		private void _SelectUltimateBuff() {} // 0x0000000185654A70-0x0000000185655AE0
		private void _RefreshUltimateBuffProgress(float deltaTime) {} // 0x000000018BC3CD88-0x000000018BC3CEFC
		private void _SetUltimateProgressFill(float realFillAmount, float totalDuration) {} // 0x000000018BC3A97C-0x000000018BC3A9C0
		private void __SetHpBarShowing_b__68_0() {} // 0x0000000183F1CF80-0x0000000183F1D030
		private void __BlinkBuffIcon_b__88_0(Sprite sprite) {} // 0x0000000183F1C050-0x0000000183F1C800
		private void __BlinkBuffIcon_b__88_1() {} // 0x0000000183F1C800-0x0000000183F1CED0
		private void __BlinkBuffIcon_b__88_2() {} // 0x0000000183F1CED0-0x0000000183F1CF80
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018792FE0C-0x000000018792FE14
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
	}

	public class OutOfScreenTargetArrow : MonoBehaviour // TypeDefIndex: 52953
	{
		// Fields
		public RectTransform rect; // 0x18
		public UIAnimationWrapper anim; // 0x20
		public UIAnimationWrapper inSkillAnim; // 0x28
		[NonSerialized]
		public TweenCallback cachedRemoveCallback; // 0x30
		[NonSerialized]
		public TweenCallback cachedHideCallback; // 0x38
		[NonSerialized]
		public TweenCallback cachedInSkillCallback; // 0x40
	
		// Constructors
		public OutOfScreenTargetArrow() {} // 0x000000018317B060-0x000000018317B360
	}

	public class OutOfScreenTargetsCtrl : UIPanelBase // TypeDefIndex: 52955
	{
		// Fields
		public float ellipseXRadius; // 0x70
		public float ellipseYRadius; // 0x74
		public RectTransform main; // 0x78
		public OutOfScreenTargetArrow arrowModel; // 0x80
		private readonly Dictionary<ObjectPtr<AbilitySystem>, OutOfScreenTargetArrow> m_arrows; // 0x88
		private readonly List<OutOfScreenTargetArrow> m_arrowsCache; // 0x90
		private readonly List<OutOfScreenTargetArrow> m_arrowsWithOutAnimation; // 0x98
		private static readonly List<ObjectPtr<AbilitySystem>> s_toRemoveArrowKeys; // 0x00
		private static readonly List<AbilitySystem> s_currentEnemyKeys; // 0x08
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000184F70610-0x0000000184F73E40 
	
		// Nested types
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 52954
		{
			// Fields
			public OutOfScreenTargetArrow arrow; // 0x10
			public OutOfScreenTargetsCtrl __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass16_0() {} // 0x0000000185FB6DA0-0x0000000185FB6DB0
	
			// Methods
			internal void __InitArrowCallbacks_b__0() {} // 0x0000000185F5B130-0x0000000185F5C130
			internal void __InitArrowCallbacks_b__1() {} // 0x0000000183F2A880-0x0000000183F2B850
			internal void __InitArrowCallbacks_b__2() {} // 0x0000000185C22D70-0x0000000185C23CC0
		}
	
		// Constructors
		public OutOfScreenTargetsCtrl() {} // 0x0000000183F392A0-0x0000000183F39940
		static OutOfScreenTargetsCtrl() {} // 0x0000000183F39940-0x0000000183F39CF0
	
		// Methods
		public void OnCreate() {} // 0x0000000183F2B850-0x0000000183F2CA90
		public void OnClose() {} // 0x0000000183F2CA90-0x0000000183F2DC60
		public void OnShow() {} // 0x000000018BC42724-0x000000018BC4287C
		public override void LateTick(float deltaTime) {} // 0x0000000183F2DC60-0x0000000183F2E9A0
		private OutOfScreenTargetArrow _CreateOneArrow() => default; // 0x0000000185B94560-0x0000000185B95240
		private void _InitArrowCallbacks(OutOfScreenTargetArrow arrow) {} // 0x0000000183F2E9A0-0x0000000183F2F810
		private ValueTuple<Vector2, float> _ScreenPosToUIPos(Vector3 screenPos) => default; // 0x0000000187A742A0-0x0000000187A742A8
		private void _OnEnemyCastSkillToMainChar(in EventData<AbilitySystem> eventData) {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000183F39CF0-0x0000000183F39DA0
	}

	public class SkillButton : UIPanelBase // TypeDefIndex: 52961
	{
		// Fields
		public const string UI_SPRITE_SKILL_ICON = "SkillIcon"; // Metadata: 0x02076F6A
		private const float HIGHLIGHT_CHECK_INTERVAL = 0.1f; // Metadata: 0x02076F74
		public CanvasGroup viewNodeCanvasGroup; // 0x70
		public UIAnimationWrapper deadNode; // 0x78
		public GameObject emptyNode; // 0x80
		public float deadAlpha; // 0x88
		public UnityEngine.Color colorDefault; // 0x8C
		public UnityEngine.Color colorRed; // 0x9C
		public UnityEngine.Color colorYellow; // 0xAC
		public UnityEngine.Color colorBlue; // 0xBC
		public UnityEngine.Color colorGreen; // 0xCC
		public float cantCastSkillAlpha; // 0xDC
		public UIButton normalButton; // 0xE0
		public UIImage normalIcon; // 0xE8
		public UIImage normalIconShadow; // 0xF0
		public UIImage normalColorBg; // 0xF8
		public UIImage cdMask; // 0x100
		public UIImage cdBg; // 0x108
		public UIText cdText; // 0x110
		public UIAnimationWrapper cdRefresh; // 0x118
		public CanvasGroup normalCanvasGroup; // 0x120
		public UIAnimationWrapper strengLight; // 0x128
		public GameObject normalMoveEffectsBg; // 0x130
		public UIAnimationWrapper hint; // 0x138
		public UIAnimationWrapper normalButtonAnim; // 0x140
		public Transform normalKeyHint; // 0x148
		public UIImage notRecommendMask; // 0x150
		public UIImage notRecommendIcon; // 0x158
		public UIImage normalPressFill; // 0x160
		public UIImage normalCountdownFill; // 0x168
		public RectTransform normalCountdownFillTrail; // 0x170
		public UIAnimationWrapper contentAnimWrapper; // 0x178
		public UIButton ultimateButton; // 0x180
		public UIImage ultimateIcon; // 0x188
		public UIImage ultimateIconShadow; // 0x190
		public UIImage ultimateColorBg; // 0x198
		public UIImage uspRing; // 0x1A0
		public UIImage uspRingSmall; // 0x1A8
		public UIImage centerImage; // 0x1B0
		public UIImage glow01; // 0x1B8
		public UIImage outRing; // 0x1C0
		public CanvasGroup ultimateCanvasGroup; // 0x1C8
		public UIImage pressFill; // 0x1D0
		public UIAnimationWrapper ultimateButtonAnim; // 0x1D8
		public UIImage ultKeyIcon; // 0x1E0
		public Transform ultKeyHint; // 0x1E8
		public float uspFillSpeed; // 0x1F0
		public UIImage ultimateFillCompleteImage; // 0x1F8
		public GameObject ultimateBar; // 0x200
		public UIImage ultimateBarFill; // 0x208
		public float ultimateBarFillMin; // 0x210
		public float ultimateBarFillMax; // 0x214
		public UIImage ultimateCdFill; // 0x218
		public UIImage ultimateBarFillFrame; // 0x220
		public UIImage touchPressUspRing; // 0x228
		public RectTransform touchPressIndicator; // 0x230
		private int m_charIndex; // 0x238
		private Beyond.DeviceInfo.InputType m_panelType; // 0x23C
		private Beyond.Gameplay.CharInfo m_charInfo; // 0x240
		private Beyond.Gameplay.Core.SkillData m_ultimateSkillData; // 0x248
		private Beyond.Gameplay.Core.SkillData m_normalSkillData; // 0x250
		private ObjectPtr<AbilitySystem> m_charAbilityPtr; // 0x258
		private Skill m_normalSkill; // 0x268
		private Skill m_ultimateSkill; // 0x270
		private bool m_isEmpty; // 0x278
		private float m_ultimatePressingTime; // 0x27C
		private bool m_isDeadState; // 0x280
		private bool m_normalSkillReady; // 0x281
		private float m_lastHighlightCheckTime; // 0x284
		private float m_uspTargetFill; // 0x288
		private UnityEngine.Color m_normalIconShadowDefaultColor; // 0x28C
		private bool m_showNotRecommendState; // 0x29C
		private PressHandler m_pressHandler; // 0x2A0
		private bool m_hasNotRecommendIcon; // 0x2A8
		private UIAnimationWrapper m_ultimateBarAnim; // 0x2B0
		private HudFadeType m_hudFadeType; // 0x2B8
		private string m_actionId; // 0x2C0
		private string m_curNormalIconName; // 0x2C8
		private string m_curUltimateIconName; // 0x2D0
		private ObjectPtr<Buff> m_normalProgressBuffPtr; // 0x2D8
		private float m_normalProgressOutDuration; // 0x2E8
		private TweenCallback m_normalProgressOutCallback; // 0x2F0
		private static Action<int> s_onPressSkillButtonStart; // 0x00
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x000000018BC44D28-0x000000018BC44D68 
		private SkillSetting skillSetting { get => default; } // 0x000000018BC44B54-0x000000018BC44C58 
	
		// Nested types
		private enum PressingMode // TypeDefIndex: 52956
		{
			None = 0,
			Normal = 1,
			Ultimate = 2
		}
	
		private abstract class PressHandler // TypeDefIndex: 52957
		{
			// Fields
			protected SkillButton m_owner; // 0x10
	
			// Properties
			protected SkillSetting skillSetting { get; } // 0x0000000181C6A970-0x0000000181C6A980 
			public virtual bool needUpdate { get; } // 0x0000000184D86AB0-0x0000000184D87A10 
	
			// Constructors
			protected PressHandler() {} // Dummy constructor
			public PressHandler(SkillButton owner) {} // 0x000000018BC45330-0x000000018BC45394
	
			// Methods
			public abstract void OnPressStart(); // 0x0000000185915860-0x00000001859158E0
			public abstract void OnUpdate(float deltaTime); // 0x000000018BC4408C-0x000000018BC44970
			public abstract void OnPressEnd(); // 0x0000000185024F80-0x0000000185028DB0
			public abstract void OnPressCancel(); // 0x00000001850F4500-0x00000001850F85C0
			public virtual void OnOtherPressSkillButtonStart() {} // 0x000000018BC452C4-0x000000018BC45330
		}
	
		private class PressHandlerLongPress : PressHandler // TypeDefIndex: 52958
		{
			// Fields
			private PressingMode m_pressingMode; // 0x18
			private float m_pressingSkillTime; // 0x1C
	
			// Properties
			public override bool needUpdate { get => default; } // 0x000000018BC44D68-0x000000018BC44E00 
	
			// Constructors
			public PressHandlerLongPress() {} // Dummy constructor
			public PressHandlerLongPress(SkillButton owner) {} // 0x0000000184EEE6C0-0x0000000184EEEB10
	
			// Methods
			public override void OnPressStart() {} // 0x00000001850F3890-0x00000001850F4300
			public override void OnUpdate(float deltaTime) {} // 0x0000000184963150-0x00000001849643B0
			public override void OnPressEnd() {} // 0x000000018440EA70-0x000000018440EB20
			public override void OnPressCancel() {} // 0x000000018BC45060-0x000000018BC450EC
			public override void OnOtherPressSkillButtonStart() {} // 0x000000018BC44970-0x000000018BC449CC
			public void __iFixBaseProxy_OnOtherPressSkillButtonStart() {} // 0x00000001850F37F0-0x00000001850F3890
		}
	
		private class PressHandlerIndividualUltimate : PressHandler // TypeDefIndex: 52959
		{
			// Fields
			private PressingMode m_pressingMode; // 0x18
			private float m_pressingSkillTime; // 0x1C
	
			// Properties
			public override bool needUpdate { get => default; } // 0x000000018BC451B8-0x000000018BC452C4 
	
			// Constructors
			public PressHandlerIndividualUltimate() {} // Dummy constructor
			public PressHandlerIndividualUltimate(SkillButton owner) {} // 0x00000001850F3660-0x00000001850F37F0
	
			// Methods
			public override void OnPressStart() {} // 0x000000018BC450EC-0x000000018BC451B8
			public override void OnUpdate(float deltaTime) {} // 0x0000000183F2F8C0-0x0000000183F30890
			public override void OnPressEnd() {} // 0x0000000183F29A70-0x0000000183F2A880
			public override void OnPressCancel() {} // 0x0000000183F30F00-0x0000000183F31C60
		}
	
		private class PressHandlerDrag : PressHandler // TypeDefIndex: 52960
		{
			// Fields
			private PressingMode m_pressingMode; // 0x18
			private float m_pressingSkillTime; // 0x1C
			private RectTransform m_indicatorRoot; // 0x20
			private float m_cancelRadiusSqr; // 0x28
			private UIAnimationWrapper m_indicatorAnim; // 0x30
			private bool m_inCancelArea; // 0x38
			private UIText m_ultimateName; // 0x40
			private UIImage m_ultimateIcon; // 0x48
	
			// Properties
			public override bool needUpdate { get => default; } // 0x00000001850F4300-0x00000001850F4500 
	
			// Constructors
			public PressHandlerDrag() {} // Dummy constructor
			public PressHandlerDrag(SkillButton owner) {} // 0x000000018BC44D0C-0x000000018BC44D28
	
			// Methods
			public override void OnPressStart() {} // 0x000000018BC43DE0-0x000000018BC4408C
			public override void OnUpdate(float deltaTime) {} // 0x000000018BC44A80-0x000000018BC44B54
			private bool _InCancelArea() => default; // 0x000000018BC44F70-0x000000018BC44FE4
			public override void OnPressEnd() {} // 0x000000018BC449CC-0x000000018BC44A80
			public override void OnPressCancel() {} // 0x00000001850F30B0-0x00000001850F3140
		}
	
		// Constructors
		public SkillButton() {} // 0x000000018BC42DC4-0x000000018BC43178
	
		// Methods
		protected override void OnAwake() {} // 0x000000018BC44C58-0x000000018BC44D0C
		protected override void OnEnable() {} // 0x000000018BC44E7C-0x000000018BC44EF8
		public void Close() {} // 0x000000018BC44E00-0x000000018BC44E7C
		public void FirstTimeInit(int charIndex, bool isDefaultPanel, bool isControllerPanel) {} // 0x000000018BC44FE4-0x000000018BC45060
		public void RefreshSkillButton() {} // 0x00000001850F34D0-0x00000001850F35C0
		private bool _TryGetAliveAbilitySystem(out AbilitySystem abilitySys) {
			abilitySys = default;
			return default;
		} // 0x000000018BC44EF8-0x000000018BC44F70
		private bool _MustUpdate() => default; // 0x0000000183F30890-0x0000000183F30F00
		public override void PreTick(float deltaTime) {} // 0x0000000185912CB0-0x0000000185912E00
		private void _InitSkillData() {} // 0x00000001850F3260-0x00000001850F34D0
		private void _UpdateMainUI(float deltaTime) {} // 0x0000000185088550-0x0000000185089FE0
		private void _CheckNormalSkillHighlight() {} // 0x00000001850F3020-0x00000001850F30B0
		private void _SetNotRecommendState(bool active) {} // 0x0000000185A2B9D0-0x0000000185A2BA60
		public void OnCharacterDie() {} // 0x0000000183F2F810-0x0000000183F2F8C0
		private void _RefreshDeadState(bool anim) {} // 0x0000000187AB03B8-0x0000000187AB03C0
		private void _SetUspFillAmount(float fillAmount) {} // 0x0000000187AAA40C-0x0000000187AAA414
		private void _SetPressFillActive(bool active) {} // 0x000000018BC43D7C-0x000000018BC43DE0
		private void _SetPressFillAmount(float fillAmount) {} // 0x0000000184096E30-0x0000000184096EF0
		private void _OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason) {} // 0x00000001814A81B0-0x00000001814A81C0
		private void _SetNormalCountdownFillVisible(bool visible) {}
		private void _RefreshNormalProgressBuff() {}
		public void OnUspChange(Entity entity = null) {}
		private bool _CanCastSkill(Skill skill) => default;
		public void CastSkill(Skill skill) {} // 0x000000018BC43D38-0x000000018BC43D7C
		public void OnPressSkillStart(PointerEventData eventData = null) {} // 0x0000000185350170-0x0000000185350180
		private void _OnOtherPressSkillButtonStart(int charIndex) {} // 0x0000000184096E30-0x0000000184096EF0
		public void OnPressSkillEnd(PointerEventData eventData = null) {} // 0x000000018BC43AB4-0x000000018BC43D30
		public void OnPressCancelled() {} // 0x000000018536F200-0x000000018536F270
		private void _CastUltimateSkill() {} // 0x000000018BC438B0-0x000000018BC43AB4
		public void OnPressUltimateSkillStart(PointerEventData eventData) {} // 0x00000001850F35C0-0x00000001850F3660
		public void ToggleControllerSkillIndicator(bool active) {} // 0x000000018BC43844-0x000000018BC438B0
		private void _OnCharPotentialUnlock(in EventData<ulong, uint> eventData) {} // 0x000000018BC43D30-0x000000018BC43D38
		private void _OnCharNormalSkillChange(in EventData<ulong, string> eventData) {} // 0x0000000187B4A52C-0x0000000187B4A534
		private void _OnSkillUpgradeSuccess(in EventData<ulong, string, int> eventData) {} // 0x0000000184096E30-0x0000000184096EF0
		private void _OnSkillButtonActiveConfigChanged() {} // 0x000000018BC436B8-0x000000018BC43784
		private void _OnInputActionKeyUpdated(in EventData<string> eventData) {} // 0x000000018BC43784-0x000000018BC43844
		private void _OnKeyboardTypeChanged() {} // 0x000000018BC435C0-0x000000018BC436B8
		private void _UpdateLongPressKeyHint() {} // 0x000000018BC4350C-0x000000018BC435C0
		private void _SetGoActive(bool active) {} // 0x0000000187B4A52C-0x0000000187B4A534
		public void SetEmpty(bool isEmpty) {} // 0x000000018BC43210-0x000000018BC4350C
		public void ClearBtnClick() {} // 0x000000018BC42B88-0x000000018BC42DC4
		private void _OnAwake_b__87_0() {} // 0x000000018BC43178-0x000000018BC43210
		public void __iFixBaseProxy_OnAwake() {} // 0x000000018BC42944-0x000000018BC42B88
		public void __iFixBaseProxy_OnEnable() {} // 0x000000018BC4287C-0x000000018BC42944
	}

	public class SquadIcon : UIPanelBase // TypeDefIndex: 52962
	{
		// Fields
		private const string UI_CHAR_HEAD_PREFIX = "icon_"; // Metadata: 0x02076F7E
		private const string UI_SPRITE_DIR_CHAR_HEAD = "CharBattleIcon"; // Metadata: 0x02076F84
		private const string UI_SPRITE_DIR_ITEM = "ItemIcon"; // Metadata: 0x02076F93
		private const float HP_CHANGE_TOLERANCE = 0.0001f; // Metadata: 0x02076F9C
		public const string CHAR_PASSIVE_UI_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Prefabs/Battle/Widgets/CharPassiveUI/"; // Metadata: 0x02076FA0
		public UIButton button; // 0x70
		public CanvasGroup canvasGroup; // 0x78
		public UIAnimationWrapper charIconNode; // 0x80
		public CanvasGroup keyHint; // 0x88
		public GameObject viewNode; // 0x90
		public GameObject emptyNode; // 0x98
		public UIAnimationWrapper viewAnimationWrapper; // 0xA0
		public UIAnimationWrapper layoutAnimationWrapper; // 0xA8
		public float cantSwitchAlpha; // 0xB0
		public UIImage characterIcon; // 0xB8
		public UIImage characterIconDead; // 0xC0
		public UIImage charCdMask; // 0xC8
		public UIAnimationWrapper charMainEffectNode; // 0xD0
		public UIAnimationWrapper charDeadNode; // 0xD8
		public GameObject hpNode; // 0xE0
		public UIAnimationWrapper hpFlashAnim; // 0xE8
		public RectTransform hpFillRect; // 0xF0
		public float hpFlashPercent; // 0xF8
		public float hpRedPercent; // 0xFC
		public float hpShakePercent; // 0x100
		public UIImage hpFill; // 0x108
		public UIImage hpRedFill; // 0x110
		public UIAnimationWrapper hpRecoverAnim; // 0x118
		public RectTransform hpVfxNode; // 0x120
		public UIImage[] hpVfxImages; // 0x128
		public SerializeFieldDictionary<SpellInflictionOnCharType, UnityEngine.Color> hpVfXColors; // 0x130
		public GameObject levelNode; // 0x138
		public UIAnimationWrapper levelUpAnim; // 0x140
		public UIText animLevelTxt; // 0x148
		public UIText levelTxt; // 0x150
		public RectTransform comboCdNode; // 0x158
		public UIAnimationWrapper comboCdBarAnim; // 0x160
		public UIImage comboCdFill; // 0x168
		public UIAnimationWrapper comboReadyAnim; // 0x170
		public UIBuffNode buffNode; // 0x178
		public CanvasGroup tacticalCanvasGroup; // 0x180
		public GameObject tacticalCdNode; // 0x188
		public GameObject tacticalCastBar; // 0x190
		public GameObject tacticalDotNode; // 0x198
		public GameObject tacticalProhibitNode; // 0x1A0
		public GameObject tacticalEmptyNode; // 0x1A8
		public UIImage tacticalIcon; // 0x1B0
		public UIImage tacticalCastFill; // 0x1B8
		public float tacticalDeadAlpha; // 0x1C0
		public float tacticalItemUsedUpAlpha; // 0x1C4
		public GameObject fixedIcon; // 0x1C8
		public GameObject trailIcon; // 0x1D0
		public GameObject indieTrailIcon; // 0x1D8
		public CanvasGroup igniteBuffTextNode; // 0x1E0
		public Animation igniteBuffTextAnim; // 0x1E8
		public UIText igniteBuffText; // 0x1F0
		public UnityEngine.Color igniteBuffColorPulse; // 0x1F8
		public UnityEngine.Color igniteBuffColorCryst; // 0x208
		public UnityEngine.Color igniteBuffColorNatural; // 0x218
		public UnityEngine.Color igniteBuffColorFire; // 0x228
		public Transform charPassiveNode; // 0x238
		private bool _isEmpty_k__BackingField; // 0x240
		private Beyond.DeviceInfo.InputType m_panelType; // 0x244
		private bool m_isMainCharacter; // 0x248
		private bool m_teamSwitchUnlocked; // 0x249
		private int m_charIndex; // 0x24C
		private string m_charIndexStr; // 0x250
		private Beyond.Gameplay.CharInfo m_charInfo; // 0x258
		private ObjectPtr<AbilitySystem> m_charAbilityPtr; // 0x260
		private List<TacticalDotCell> m_tacticalDots; // 0x270
		private float m_tacticalCastFillMax; // 0x278
		private int m_lastLevel; // 0x27C
		private bool m_indicatorShowing; // 0x280
		private bool m_lastComboCdReady; // 0x281
		private bool m_comboReadyAnimShowing; // 0x282
		private bool m_comboIconShowing; // 0x283
		private UIHudFadeController m_hudFadeController; // 0x288
		private UIAnimationWrapper m_hpVfxAnimWrapper; // 0x290
		private string m_lastCharPassiveName; // 0x298
		private UICharPassiveBase m_charPassiveBase; // 0x2A0
		private DG.Tweening.Sequence m_keyHintFadeSequence; // 0x2A8
		private bool m_inDeadState; // 0x2B0
		private UIAnimationWrapper m_tacticalSwitchAnim; // 0x2B8
		private bool? m_tacticalInProgress; // 0x2C0
		private int m_tacticalItemLastDisplayCount; // 0x2C4
		private float m_comboCdNodeHeight; // 0x2C8
		private readonly List<ObjectPtr<Buff>> m_activeCharHpBarVfxBuffs; // 0x2D0
		private ObjectPtr<Buff> m_charHpBarVfxBuffPtr; // 0x2D8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
		public bool isEmpty { get; private set; } // 0x0000000185FB91E0-0x0000000185FB91F0 0x0000000185FD6F50-0x0000000185FD6F60
	
		// Constructors
		public SquadIcon() {} // 0x000000018586C180-0x000000018586CD90
	
		// Methods
		protected override void OnAwake() {} // 0x00000001845A7B90-0x00000001845A7CA0
		public void FirstTimeInit(int index, bool isDefaultPanel, bool isControllerPanel) {} // 0x0000000184FC6570-0x0000000184FC6AE0
		public void Close() {} // 0x000000018BC45540-0x000000018BC45B1C
		public void InitSquadIcon(bool showFixed = false /* Metadata: 0x02076F7B */, bool showTrail = false /* Metadata: 0x02076F7C */) {} // 0x00000001850AFAB0-0x00000001850B3B90
		private bool _MustUpdate() => default; // 0x00000001848E1DF0-0x00000001848E1F70
		public override void LateTick(float deltaTime) {} // 0x00000001848E1F70-0x00000001848E21A0
		private bool _TryGetAliveAbilitySystem(out AbilitySystem abilitySys) {
			abilitySys = default;
			return default;
		} // 0x000000018BC462C4-0x000000018BC46330
		private void _UpdateComboSkillIcon(bool showAnim = true /* Metadata: 0x02076F7D */) {} // 0x0000000184960AD0-0x0000000184960C90
		public void SetEmpty(bool empty) {} // 0x0000000185089FE0-0x000000018508A070
		public void ToggleIndicator(bool isShow) {} // 0x000000018BC45ED4-0x000000018BC45F30
		public void InformKeyHint() {} // 0x000000018BC45B1C-0x000000018BC45CA0
		private void _OnHpChange(Entity entity, double change, bool isMaxHpChanged) {} // 0x0000000183F34D40-0x0000000183F36060
		private void _SetLevelText() {} // 0x00000001850AEFB0-0x00000001850AF070
		private void _OnIgniteBuffText(in EventData<ulong, string, EnergyShardType> eventData) {} // 0x000000018BC45FA0-0x000000018BC46150
		public void OnLevelChange() {} // 0x000000018BC45CA0-0x000000018BC45CFC
		private void _TryShowLevelUpAnim() {} // 0x0000000185B6CFC0-0x0000000185B6D060
		public void SetDeadState(bool dead) {} // 0x0000000184A02D60-0x0000000184A040F0
		private void _UpdateIconAlpha() {} // 0x00000001848E09F0-0x00000001848E0A80
		public bool CanSwitchToCenter(bool showTip) => default; // 0x000000018BC45394-0x000000018BC45540
		public void OnPressCharIconStart(PointerEventData eventData) {} // 0x000000018BC45CFC-0x000000018BC45E78
		public void OnTacticalItemChange() {} // 0x00000001850AF600-0x00000001850AF8E0
		private void _UpdateTacticalItemStatus() {} // 0x00000001840416E0-0x0000000184041BF0
		public void OnTeamSwitchUnlocked() {} // 0x000000018BC45E78-0x000000018BC45ED4
		private void _OnMainCharChange(in EventData<SetLeaderReason, Entity, Entity> data) {} // 0x000000018BC46150-0x000000018BC462C4
		private void _OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason) {} // 0x0000000183F33A20-0x0000000183F34D40
		private void _RefreshBuffChangeCharHpBarVfx() {} // 0x0000000183F37700-0x0000000183F392A0
		private void _HpVfxOutAnimCallback() {} // 0x000000018BC45F30-0x000000018BC45FA0
		private void _OnCharPassiveNumChanged(float newNum) {} // 0x0000000185C3BCA0-0x0000000185C3BD50
		private bool _IsCharHpBarVfxBuffValid(ObjectPtr<Buff> buffPtr) => default; // 0x0000000183F32DD0-0x0000000183F33A20
		private void _RebuildCharHpBarVfxBuffCache() {} // 0x0000000183F36060-0x0000000183F37700
		private ObjectPtr<Buff> _GetLatestValidCharHpBarVfxBuffPtrFromCache() => default; // 0x0000000183F31EA0-0x0000000183F32DD0
		private void __UpdateComboSkillIcon_b__100_0() {} // 0x0000000183F31DC0-0x0000000183F31DF0
		private void __UpdateComboSkillIcon_b__100_1() {} // 0x0000000183F31DF0-0x0000000183F31EA0
		private void __OnHpChange_b__104_0() {} // 0x0000000183F31C60-0x0000000183F31D10
		private void __TryShowLevelUpAnim_b__108_0() {} // 0x0000000183F31D10-0x0000000183F31DC0
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
	}

	public class TacticalDotCell : MonoBehaviour // TypeDefIndex: 52963
	{
		// Fields
		public UIImage dotBg; // 0x18
		public UIImage dot; // 0x20
		public UIImage dotWarning; // 0x28
		private UIAnimationWrapper _anim; // 0x30
		private bool _showDotWarning; // 0x38
		private bool m_markInit; // 0x39
		private bool m_isDotActive; // 0x3A
	
		// Constructors
		public TacticalDotCell() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void Init() {} // 0x00000001850AF8E0-0x00000001850AF910
		public void SetDotActive(bool isActive, bool playAnim = true /* Metadata: 0x02076FEF */) {} // 0x0000000184041CC0-0x0000000184041DE0
		public void SetDotUsedUp(bool isUsedUp) {} // 0x0000000184041BF0-0x0000000184041CC0
		private void _SetDotActive_b__8_0() {} // 0x000000018BC46330-0x000000018BC46360
	}

	public class UIAbnormalBuffCell : UIBuffCell // TypeDefIndex: 52964
	{
		// Fields
		private UIImage _buffLifeTimeBar; // 0x78
		private UIStateController _abnormalLevelState; // 0x80
	
		// Constructors
		public UIAbnormalBuffCell() {} // 0x000000018455F410-0x000000018455F420
	
		// Methods
		public override void OnTick(float deltaTime) {} // 0x000000018BC46360-0x000000018BC46434
		protected override void VisualInit(Sprite sprite) {} // 0x000000018BC464E8-0x000000018BC46744
		protected override void SetWarningState(bool isWarning) {} // 0x000000018BC46434-0x000000018BC464D0
		public void __iFixBaseProxy_OnTick(float P0) {} // 0x000000018BC464D0-0x000000018BC464D8
		public void __iFixBaseProxy_VisualInit(Sprite P0) {} // 0x000000018BC464E0-0x000000018BC464E8
		public void __iFixBaseProxy_SetWarningState(bool P0) {} // 0x000000018BC464D8-0x000000018BC464E0
	}

	public class UIAttachedBuffCell : UIBuffCell // TypeDefIndex: 52965
	{
		// Fields
		private UIImage _buffIconPhantom; // 0x78
		private UIImage _buffStackRing; // 0x80
		private List<UIAnimationWrapper> _buffStackRingConsumeAnims; // 0x88
		private float _stackRingFillChangeSpeed; // 0x90
		private float _igniteFillDelay; // 0x94
		private const string BUFF_ANIM_IGNITE = "headbar_buff_cell_ignite"; // Metadata: 0x02076FF0
		private int m_maxStackCount; // 0x98
		private float? m_targetStackRingFillAmount; // 0x9C
		private PeriodicTimer m_igniteFillDelayTimer; // 0xA8
		private bool m_isInConsumeAnim; // 0xB0
	
		// Constructors
		public UIAttachedBuffCell() {} // 0x0000000184560720-0x00000001845607B0
	
		// Methods
		protected override void DataInit(ObjectPtr<Buff> buffPtr) {} // 0x000000018BC468A8-0x000000018BC469A8
		public override void OnTick(float deltaTime) {} // 0x000000018BC46A70-0x000000018BC46C54
		public override void BeforePlayOutAnim() {} // 0x000000018BC46744-0x000000018BC468A8
		protected override void SetBuffIcon(Sprite sprite) {} // 0x000000018BC46C54-0x000000018BC46CD4
		protected override void SetStackElementActive(bool showStackCount) {} // 0x000000018BC472A8-0x000000018BC47330
		public override void SetStackCount(int stackCount, bool playAnim) {} // 0x000000018BC46CD4-0x000000018BC472A8
		public override void OnBuffIgnite() {} // 0x000000018BC469A8-0x000000018BC46A70
		private void _SetStackCount_b__15_0() {} // 0x0000000185FD27D0-0x0000000185FD27E0
		public void __iFixBaseProxy_DataInit(ObjectPtr<Buff> P0) {} // 0x000000018BC47338-0x000000018BC47358
		public void __iFixBaseProxy_OnTick(float P0) {} // 0x000000018BC464D0-0x000000018BC464D8
		public void __iFixBaseProxy_BeforePlayOutAnim() {} // 0x000000018BC47330-0x000000018BC47338
		public void __iFixBaseProxy_SetBuffIcon(Sprite P0) {} // 0x000000018BC47360-0x000000018BC47368
		public void __iFixBaseProxy_SetStackElementActive(bool P0) {} // 0x000000018BC47370-0x000000018BC47378
		public void __iFixBaseProxy_SetStackCount(int P0, bool P1) {} // 0x000000018BC47368-0x000000018BC47370
		public void __iFixBaseProxy_OnBuffIgnite() {} // 0x000000018BC47358-0x000000018BC47360
	}

	public class UIBuffCell : MonoBehaviour // TypeDefIndex: 52967
	{
		// Fields
		protected UIImage _buffIcon; // 0x18
		protected bool _canShowStackCountText; // 0x20
		protected GameObject _stackCountTextNode; // 0x28
		protected UIText _buffStackCountText; // 0x30
		protected UIAnimationWrapper _anim; // 0x38
		protected CanvasGroup _canvasGroup; // 0x40
		protected bool _canShowWarningBg; // 0x48
		protected UIImage _warningBg; // 0x50
		protected ObjectPtr<Buff> m_buffPtr; // 0x58
		private ulong _nextInstanceId_k__BackingField; // 0x68
		private string _curSpritePath_k__BackingField; // 0x70
	
		// Properties
		public ulong nextInstanceId { get; private set; } // 0x0000000181460F70-0x0000000181460F80 0x00000001874BE90C-0x00000001874BE91C
		public string curSpritePath { get; private set; } // 0x00000001813ECBC0-0x00000001813ECBD0 0x00000001850AAAB0-0x00000001850AAB00
		public UIAnimationWrapper anim { get => default; } // 0x00000001850AAA70-0x00000001850AAAB0 
		public BuffData buffData { get => default; } // 0x00000001850AAD70-0x00000001850AADC0 
		public int orderPriority { get => default; } // 0x00000001850AB1A0-0x00000001850AB390 
		public ulong buffInstanceUid { get => default; } // 0x0000000185F0F780-0x0000000185F0F7B0 
	
		// Nested types
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 52966
		{
			// Fields
			public UIBuffCell __4__this; // 0x10
			public string inputSpritePath; // 0x18
			public Action onSpriteLoaded; // 0x20
			public ulong cachedLoadKey; // 0x28
	
			// Constructors
			public __c__DisplayClass25_0() {} // 0x00000001813AC280-0x00000001813AC290
	
			// Methods
			internal void _Init_b__0(Sprite sprite) {} // 0x0000000185FB07B0-0x0000000185FB07C0
		}
	
		// Constructors
		public UIBuffCell() {} // 0x0000000185AE5060-0x0000000185AE50D0
	
		// Methods
		public void Init(ObjectPtr<Buff> buffPtr, LuaResourceLoader loader, Action onSpriteLoaded = null) {} // 0x00000001850AA550-0x00000001850AA680
		protected virtual void DataInit(ObjectPtr<Buff> buffPtr) {} // 0x00000001844AAFE0-0x00000001844AB050
		protected virtual void VisualInit(Sprite sprite) {} // 0x000000018BC47378-0x000000018BC473BC
		public void Clear() {} // 0x00000001848E1C40-0x00000001848E1CC0
		public virtual void BeforePlayOutAnim() {} // 0x00000001850AACB0-0x00000001850AAD70
		public virtual void OnTick(float deltaTime) {} // 0x0000000185B65D30-0x0000000185B65DD0
		public virtual void SetVisible(bool visible) {} // 0x000000018BC473BC-0x000000018BC47400
		public virtual void SetStackCount(int stackCount, bool playAnim) {} // 0x0000000185D22760-0x0000000185D227B0
		public virtual void OnBuffIgnite() {} // 0x0000000185C2D070-0x0000000185C2D0C0
		protected virtual void SetBuffIcon(Sprite sprite) {} // 0x00000001859953C0-0x0000000185995420
		protected virtual void SetStackElementActive(bool isActive) {} // 0x0000000184560840-0x00000001845608A0
		protected virtual void SetWarningState(bool isWarning) {} // 0x0000000185492010-0x0000000185492020
	}

	public class UIBuffNode : TickableUIMono // TypeDefIndex: 52977
	{
		// Fields
		private SerializeFieldDictionary<BuffIconConfig.BuffIconStyle, UIBuffCell> _buffStyleCellTemplateDict; // 0x68
		private BuffNodeType _buffNodeType; // 0x70
		private int _maxBuffCellCount; // 0x74
		private bool m_isFirstInited; // 0x78
		private readonly LuaResourceLoader m_loader; // 0x80
		private ObjectPtr<AbilitySystem> m_owner; // 0x88
		private readonly DynamicFastLookupCollection<BuffIconConfig.BuffIconStyle, BuffCellGroup> m_buffCellGroupDict; // 0x98
		private readonly DynamicFastLookupCollection<string, List<ObjectPtr<Buff>>> m_stackBuffsDict; // 0xA0
		private readonly List<UIBuffCell> m_orderedBuffCellList; // 0xA8
		private readonly HashSet<ObjectPtr<Buff>> m_addBuffIconBuffer; // 0xB0
		private const string BUFF_ANIM_STRONG_IN = "headbar_buff_cell_strong_in"; // Metadata: 0x02077009
		private const string BUFF_ANIM_IGNITE_OUT = "headbar_buff_cell_ignite_out"; // Metadata: 0x02077025
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x00000001850AADC0-0x00000001850AAE60 
	
		// Nested types
		public enum BuffNodeType // TypeDefIndex: 52968
		{
			HeadBarCommon = 0,
			HeadBarAttached = 1,
			SquadIconCommon = 2,
			MainCharHpBarCommon = 3
		}
	
		public class BuffCellGroup // TypeDefIndex: 52969
		{
			// Fields
			public BuffIconConfig.BuffIconStyle buffIconStyle; // 0x10
			public UIBuffCell buffCellTemplate; // 0x18
			public List<UIBuffCell> buffCellPool; // 0x20
			public DynamicFastLookupCollection<ulong, UIBuffCell> buffCellDict; // 0x28
			public DynamicFastLookupCollection<ulong, UIBuffCell> buffCellWithOutAnim; // 0x30
	
			// Constructors
			public BuffCellGroup() {} // 0x00000001850AED30-0x00000001850AEE20
	
			// Methods
			public UIBuffCell CreateBuffCell(Transform transform) => default; // 0x0000000185FB7DE0-0x0000000185FB7DF0
			public void RemoveBuffCell(UIBuffCell buffCell) {} // 0x0000000184815470-0x0000000184815AB0
			public void ClearAllBuffCells(LuaResourceLoader loader) {} // 0x00000001844AA580-0x00000001844AAFE0
		}
	
		private sealed class __c__DisplayClass27_0 // TypeDefIndex: 52970
		{
			// Fields
			public UIBuffNode __4__this; // 0x10
			public bool playAnim; // 0x18
			public BuffData buffData; // 0x20
	
			// Constructors
			public __c__DisplayClass27_0() {} // 0x00000001850AC220-0x00000001850AD3F0
		}
	
		private sealed class __c__DisplayClass27_1 // TypeDefIndex: 52971
		{
			// Fields
			public UIBuffCell newBuffCell; // 0x10
			public __c__DisplayClass27_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass27_1() {} // 0x00000001850AD410-0x00000001850AD5E0
	
			// Methods
			internal void __AddBuffIconInternal_b__0() {} // 0x0000000184335FC0-0x0000000184336660
		}
	
		private sealed class __c__DisplayClass27_2 // TypeDefIndex: 52972
		{
			// Fields
			public UIBuffCell buffCell; // 0x10
			public __c__DisplayClass27_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass27_2() {} // 0x000000018BC47400-0x000000018BC474C8
	
			// Methods
			internal void __AddBuffIconInternal_b__1() {} // 0x00000001850AAF00-0x00000001850AAF90
		}
	
		private sealed class __c__DisplayClass27_3 // TypeDefIndex: 52973
		{
			// Fields
			public UIBuffCell buffCell; // 0x10
			public __c__DisplayClass27_0 CS___8__locals3; // 0x18
	
			// Constructors
			public __c__DisplayClass27_3() {} // 0x00000001850AB010-0x00000001850AB100
	
			// Methods
			internal void __AddBuffIconInternal_b__2() {} // 0x00000001850AAF90-0x00000001850AB010
		}
	
		private sealed class __c__DisplayClass28_0 // TypeDefIndex: 52974
		{
			// Fields
			public ObjectPtr<Buff> buffPtr; // 0x10
			public BuffCellGroup buffCellGroup; // 0x20
			public UIBuffNode __4__this; // 0x28
	
			// Constructors
			public __c__DisplayClass28_0() {} // 0x000000018BC477A4-0x000000018BC47878
		}
	
		private sealed class __c__DisplayClass28_1 // TypeDefIndex: 52975
		{
			// Fields
			public List<ObjectPtr<Buff>> stackBuffList; // 0x10
			public UIBuffCell buffCell; // 0x18
			public __c__DisplayClass28_0 CS___8__locals1; // 0x20
	
			// Constructors
			public __c__DisplayClass28_1() {} // 0x00000001850AA120-0x00000001850AA550
	
			// Methods
			internal void __RemoveBuffIconInternal_b__0() {} // 0x000000018BC47878-0x000000018BC4826C
			internal void __RemoveBuffIconInternal_b__1() {} // 0x000000018BC474C8-0x000000018BC47630
		}
	
		private sealed class __c__DisplayClass28_2 // TypeDefIndex: 52976
		{
			// Fields
			public UIBuffCell buffCell; // 0x10
			public __c__DisplayClass28_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass28_2() {} // 0x000000018BC47630-0x000000018BC477A4
	
			// Methods
			internal void __RemoveBuffIconInternal_b__2() {} // 0x00000001850AEB60-0x00000001850AED30
			internal void __RemoveBuffIconInternal_b__3() {} // 0x00000001850AE990-0x00000001850AEB60
		}
	
		// Constructors
		public UIBuffNode() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private void _OnFirstInit() {} // 0x00000001850AA820-0x00000001850AAA70
		public void OnPreWarm() {} // 0x00000001850AA770-0x00000001850AA820
		public void Init(ObjectPtr<AbilitySystem> abilitySystemPtr) {} // 0x00000001848152A0-0x0000000184815470
		public void Refresh() {} // 0x00000001879BDE2C-0x00000001879BDE34
		public void Clear() {} // 0x000000018792FE0C-0x000000018792FE14
		public override void TailLateTick(float deltaTime) {} // 0x00000001850AA680-0x00000001850AA770
		protected override void OnRelease() {} // 0x000000018BC4880C-0x000000018BC488CC
		public void OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason) {} // 0x00000001850AD5E0-0x00000001850AD6D0
		private bool _IsBuffIconInThisNode(ObjectPtr<Buff> buffPtr) => default; // 0x0000000185492010-0x0000000185492020
		private void _OnAddBuff(ObjectPtr<Buff> buffPtr) {} // 0x0000000185492010-0x0000000185492020
		private void _OnRemoveBuff(ObjectPtr<Buff> buffPtr, Buff.FinishReason finishReason) {} // 0x0000000185492010-0x0000000185492020
		private void _AddBuffIconInternal(ObjectPtr<Buff> buffPtr, bool playAnim) {} // 0x000000018BC4D8D8-0x000000018BC4D924
		private void _RemoveBuffIconInternal(ObjectPtr<Buff> buffPtr, Buff.FinishReason finishReason) {} // 0x0000000185492010-0x0000000185492020
		private void _OnBuffEnhanceChanged(ObjectPtr<Buff> buffPtr) {} // 0x000000018BC4D924-0x000000018BC4DA2C
		private void _OnBuffIgnite(ObjectPtr<Buff> buffPtr) {} // 0x0000000185492010-0x0000000185492020
		private void _RegisterAbilityBuffEvent(AbilitySystem abilitySystem) {} // 0x00000001850AA090-0x00000001850AA120
		private void _UnregisterAbilityBuffEvent(AbilitySystem abilitySystem) {} // 0x0000000185492010-0x0000000185492020
		private BuffIconConfig.BuffIconStyle _GetIconStyle(BuffData buffData) => default; // 0x0000000185492010-0x0000000185492020
		private void _SetBuffCellSiblingInOrder(UIBuffCell buffCell) {} // 0x000000018BC4DA2C-0x000000018BC4DB40
		private void _DealWithBuffCellVisible() {} // 0x000000018BC4DB40-0x000000018BC4DC54
		public void __iFixBaseProxy_TailLateTick(float P0) {} // 0x000000018BC4DC54-0x000000018BC4DD28
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018BC4DD28-0x000000018BC4DDFC
	}

	public class UILifeTimeBuffCell : UIBuffCell // TypeDefIndex: 52978
	{
		// Fields
		private UIImage _buffLifeTimeBar; // 0x78
	
		// Constructors
		public UILifeTimeBuffCell() {} // 0x000000018455F410-0x000000018455F420
	
		// Methods
		public override void OnTick(float deltaTime) {} // 0x00000001848E1920-0x00000001848E1AE0
		protected override void SetWarningState(bool isWarning) {} // 0x0000000185995340-0x00000001859953C0
		public void __iFixBaseProxy_OnTick(float P0) {} // 0x000000018BC464D0-0x000000018BC464D8
		public void __iFixBaseProxy_SetWarningState(bool P0) {} // 0x000000018BC464D8-0x000000018BC464E0
	}

	public class UISpellInflictionOnCharCell : MonoBehaviour // TypeDefIndex: 52979
	{
		// Fields
		private UIStateController _stateController; // 0x18
		private UIAnimationWrapper _animationWrapper; // 0x20
		private bool m_isActive; // 0x28
	
		// Constructors
		public UISpellInflictionOnCharCell() {} // 0x000000018317B060-0x000000018317B360
	
		// Methods
		public void SetCellActive(bool active, bool forceRefresh = false /* Metadata: 0x02077046 */) {} // 0x0000000183F3DA60-0x0000000183F3E6D0
	}

	public class UISpellInflictionOnCharNode : MonoBehaviour // TypeDefIndex: 52984
	{
		// Fields
		private Transform _attachBuffCellRoot; // 0x18
		private UISpellInflictionOnCharCell _attachBuffCell; // 0x20
		private UIImage _abnormalBuffProgressBar; // 0x28
		private UIAnimationWrapper _abnormalBuffProgressAnim; // 0x30
		private static List<string> s_attachBuffIds; // 0x00
		private static List<string> s_abnormalBuffIds; // 0x08
		private bool m_isFirstInited; // 0x38
		private ObjectPtr<AbilitySystem> m_owner; // 0x40
		private List<ObjectPtr<Buff>> m_attachBuffs; // 0x50
		private List<ObjectPtr<Buff>> m_abnormalBuffs; // 0x58
		private UIListCache<UISpellInflictionOnCharCell> m_attachBuffCellCache; // 0x60
	
		// Properties
		private bool isInCcDungeon { get => default; } // 0x0000000183F42C50-0x0000000183F44120 
	
		// Nested types
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 52980
		{
			// Fields
			public Buff attachBuff; // 0x10
	
			// Constructors
			public __c__DisplayClass19_0() {} // 0x0000000183F4B420-0x0000000183F4BA30
	
			// Methods
			internal void __DoRefreshUI_b__0(UISpellInflictionOnCharCell cell, int index) {} // 0x0000000183F45D40-0x0000000183F46BD0
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 52981
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<UISpellInflictionOnCharCell, int> __9__19_1; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000183F3F5B0-0x0000000183F40780
			public __c() {} // 0x0000000183F40780-0x0000000183F41450
	
			// Methods
			internal void __DoRefreshUI_b__19_1(UISpellInflictionOnCharCell cell, int index) {} // 0x0000000183F3E6D0-0x0000000183F3F5B0
		}
	
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 52982
		{
			// Fields
			public Buff buff; // 0x10
	
			// Constructors
			public __c__DisplayClass20_0() {} // 0x0000000183F46BD0-0x0000000183F481F0
	
			// Methods
			internal void __OnBuffIconChange_b__0(UISpellInflictionOnCharCell cell, int index) {} // 0x0000000183F481F0-0x0000000183F49810
		}
	
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 52983
		{
			// Fields
			public Buff buff; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0() {} // 0x0000000183F41450-0x0000000183F42C50
	
			// Methods
			internal void __OnBuffEnhanceChanged_b__0(UISpellInflictionOnCharCell cell, int index) {} // 0x0000000183F44120-0x0000000183F45D40
		}
	
		// Constructors
		public UISpellInflictionOnCharNode() {} // 0x0000000185492010-0x0000000185492020
		static UISpellInflictionOnCharNode() {} // 0x0000000183F39E10-0x0000000183F39E50
	
		// Methods
		private void _OnFirstInit() {} // 0x0000000183F4A7E0-0x0000000183F4B420
		public void OnInit(ObjectPtr<AbilitySystem> abilitySystemPtr) {} // 0x0000000183F49810-0x0000000183F4A7E0
		public void OnTick(float deltaTime) {} // 0x0000000185492010-0x0000000185492020
		public void OnClear() {} // 0x0000000183F39DD0-0x0000000183F39E10
		private void _RegisterAbilityBuffEvent(AbilitySystem abilitySystem) {} // 0x0000000183F39E50-0x0000000183F3A1B0
		private void _UnregisterAbilityBuffEvent(AbilitySystem abilitySystem) {} // 0x0000000185492010-0x0000000185492020
		private void _DoRefreshUI() {} // 0x0000000183F39DA0-0x0000000183F39DD0
		private void _OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason) {} // 0x0000000185492010-0x0000000185492020
		private void _OnBuffEnhanceChanged(ObjectPtr<Buff> buffPtr) {} // 0x0000000183F39E10-0x0000000183F39E50
	}

	public class UIHudFadeBase : MonoBehaviour // TypeDefIndex: 52985
	{
		// Fields
		public UIStyleInputValidType validType; // 0x18
	
		// Properties
		protected bool globalNeedShow { get => default; } // 0x00000001844A4F00-0x00000001844A4F60 
	
		// Constructors
		public UIHudFadeBase() {} // 0x0000000186474FDC-0x0000000186474FEC
	}

	public class UIHudFadeConsoleController : UIHudFadeBase // TypeDefIndex: 52986
	{
		// Fields
		public string key; // 0x20
		public string foldState; // 0x28
		private Animator m_animator; // 0x30
		private bool m_curShowing; // 0x38
		private DG.Tweening.Sequence m_fadeSequence; // 0x40
		private int m_keyHash; // 0x48
		private int m_foldStateHash; // 0x4C
	
		// Constructors
		public UIHudFadeConsoleController() {} // 0x000000018BC516B8-0x000000018BC51724
	
		// Methods
		private void Awake() {} // 0x000000018BC50EA4-0x000000018BC51060
		private void OnDestroy() {} // 0x000000018BC511F0-0x000000018BC51384
		public void OnShow() {} // 0x000000018BC51384-0x000000018BC51434
		private void _CheckNeedShow() {} // 0x000000018BC5145C-0x000000018BC515FC
		private void _OnFadeHud() {} // 0x000000018BC515FC-0x000000018BC5164C
		private void _OnInformShow(in EventData<UIStyleInputValidTypeMask> eventData) {} // 0x000000018BC5164C-0x000000018BC516B8
		public void InformShow() {} // 0x000000018BC51060-0x000000018BC511F0
		private void __CheckNeedShow_b__10_0() {} // 0x000000018BC51434-0x000000018BC5145C
		private void _InformShow_b__13_0() {} // 0x000000018BC51434-0x000000018BC5145C
	}

	public class UIHudFadeController : UIHudFadeBase // TypeDefIndex: 52987
	{
		// Fields
		private CanvasGroup m_canvasGroup; // 0x20
		private bool m_curShowing; // 0x28
		private DG.Tweening.Sequence m_fadeSequence; // 0x30
		private readonly HashSet<string> m_hudPreventFadeState; // 0x38
	
		// Properties
		private bool needShow { get => default; } // 0x00000001844A4EA0-0x00000001844A4F00 
		private GameplayMiscSetting setting { get => default; } // 0x00000001844A53B0-0x00000001844A5420 
	
		// Constructors
		public UIHudFadeController() {} // 0x0000000185B88C40-0x0000000185B88CD0
	
		// Methods
		private void Awake() {} // 0x00000001844A4440-0x00000001844A45F0
		private void OnDestroy() {} // 0x000000018BC51724-0x000000018BC518B8
		private void _OnFadeHud() {} // 0x00000001844A4CB0-0x00000001844A4CF0
		private void _CheckNeedShow() {} // 0x00000001844A4CF0-0x00000001844A4EA0
		public void SetLocalNeedShow(string state, bool needShowHud) {} // 0x0000000184E5B530-0x0000000184E5B5D0
		private void _OnInformShow(in EventData<UIStyleInputValidTypeMask> eventData) {} // 0x000000018BC518B8-0x000000018BC51924
		public void InformShow() {} // 0x0000000185F8A940-0x0000000185F8A9B0
	}

	public class UIHudFadeTouchSkill : UIHudFadeBase // TypeDefIndex: 52988
	{
		// Fields
		private UIAnimationWrapper m_animationWrapper; // 0x20
		private bool m_curShowing; // 0x28
		private bool m_animInOrLoop; // 0x29
		private DG.Tweening.Sequence m_fadeSequence; // 0x30
	
		// Constructors
		public UIHudFadeTouchSkill() {} // 0x000000018BC52224-0x000000018BC52238
	
		// Methods
		private void Awake() {} // 0x000000018BC51924-0x000000018BC51AC4
		private void OnDestroy() {} // 0x000000018BC51BCC-0x000000018BC51D60
		public void OnShow() {} // 0x000000018BC51D60-0x000000018BC51E1C
		private void _CheckNeedShow() {} // 0x000000018BC51F84-0x000000018BC52168
		private void _OnFadeHud() {} // 0x000000018BC52168-0x000000018BC521B8
		private void _OnInformShow(in EventData<UIStyleInputValidTypeMask> eventData) {} // 0x000000018BC521B8-0x000000018BC52224
		public void InformShow() {} // 0x000000018BC51AC4-0x000000018BC51BCC
		private void __CheckNeedShow_b__7_0() {} // 0x000000018BC51F58-0x000000018BC51F84
		private void _InformShow_b__10_0() {} // 0x000000018BC51E1C-0x000000018BC51F30
		private void _InformShow_b__10_1() {} // 0x000000018BC51F30-0x000000018BC51F58
	}

	public class UIAbilityTargetFollower : UIPanelBase // TypeDefIndex: 52989
	{
		// Fields
		public Beyond.Gameplay.MountPoint mountPoint; // 0x70
		public float minDistance; // 0x74
		public float maxDistance; // 0x78
		public AnimationCurve scaleCurve; // 0x80
		public float deltaTowardCamera; // 0x88
		public bool applyHeadBar2DOffset; // 0x8C
		public bool outOfScreenCorrection; // 0x8D
		public float startCorrectionScreenHeight; // 0x90
		public float endCorrectionScreenHeight; // 0x94
		public Canvas canvas; // 0x98
		public CanvasGroup canvasGroup; // 0xA0
		public UIAnimationWrapper animationWrapper; // 0xA8
		protected ObjectPtr<AbilitySystem> m_target; // 0xB0
		protected Transform m_followTransform; // 0xC0
		protected Transform m_heightFollowTransform; // 0xC8
		protected Transform m_heightBaseTransform; // 0xD0
		protected float m_heightRangeMin; // 0xD8
		protected float m_heightRangeMax; // 0xDC
		private Transform m_cameraTransform; // 0xE0
		private Vector3 m_preDeltaPosition; // 0xE8
		private float m_preDeltaDistance; // 0xF4
		private bool m_needReassignFollowTransform; // 0xF8
		private float m_deltaTowardCamera; // 0xFC
		private Vector3 m_originalScale; // 0x100
		private bool m_distanceVisible; // 0x10C
		private bool m_finalVisibleForUpdate; // 0x10D
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB7DE0-0x0000000185FB7DF0 
		protected virtual bool actualVisible { get => default; } // 0x0000000185FD6F60-0x0000000185FD6F70 
		protected virtual bool needUpdateTransform { get => default; } // 0x0000000183F3DA50-0x0000000183F3DA60 
	
		// Constructors
		public UIAbilityTargetFollower() {} // 0x0000000184815D10-0x0000000184815DC0
	
		// Methods
		protected override void OnAwake() {} // 0x00000001850A9A70-0x00000001850A9AE0
		public override void TailLateTick(float deltaTime) {} // 0x0000000185917EA0-0x0000000185917F30
		public virtual void SetTarget(AbilitySystem target) {} // 0x000000018BC4DFB0-0x000000018BC4E1F8
		public virtual void Clear() {} // 0x00000001850AB4A0-0x00000001850AB570
		public virtual bool TryGetOriginalFollowPos(out Vector3 followPos) {
			followPos = default;
			return default;
		} // 0x0000000183F3B170-0x0000000183F3C000
		protected virtual void UpdateData(float deltaTime) {} // 0x0000000185FA8F70-0x0000000185FA8FA0
		private void _TryRefreshFollowTransform() {} // 0x000000018BC4E298-0x000000018BC4E36C
		private void _TryRefreshHeightFollowTransform() {} // 0x000000018BC4E36C-0x000000018BC4E4AC
		private void _UpdateSelfTransform() {} // 0x000000018BC4E6E8-0x000000018BC4E7C0
		private void _CalculatePosition() {} // 0x0000000183F3C010-0x0000000183F3D0C0
		private void _UpdatePosition() {} // 0x0000000183F3D0C0-0x0000000183F3DA50
		private void _UpdateScale() {} // 0x000000018BC4E4AC-0x000000018BC4E6E8
		private void _SetDistanceVisible(bool visible) {} // 0x000000018BC4E1F8-0x000000018BC4E298
		protected void OnActualVisibleChange(bool visible, bool forceUpdate = false /* Metadata: 0x02077047 */) {} // 0x0000000183F3A1B0-0x0000000183F3B170
		protected Vector3 GetAdjustedHeightOffset(AbilitySystem target) => default; // 0x000000018BC4DE4C-0x000000018BC4DFB0
		private void _OnActualVisibleChange_b__45_0() {} // 0x0000000183F3C000-0x0000000183F3C010
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_TailLateTick(float P0) {} // 0x00000001879BDE2C-0x00000001879BDE34
	}

	public class UILockAim : UIAbilityTargetFollower // TypeDefIndex: 52990
	{
		// Fields
		public float showCancelProgressRatio; // 0x110
		public CanvasGroup aimGroup; // 0x118
		public UIImage aimRingImage; // 0x120
		public UIImage rotateImage; // 0x128
		public CanvasGroup breakingAttackGroup; // 0x130
		private UIAnimationWrapper m_aimGroupAnimWrapper; // 0x138
	
		// Constructors
		public UILockAim() {} // 0x0000000185FACC90-0x0000000185FACCB0
	
		// Methods
		protected override void OnAwake() {} // 0x00000001850A97E0-0x00000001850A9A70
		protected override void OnRelease() {} // 0x000000018BC52238-0x000000018BC524C0
		protected void Start() {} // 0x00000001850F2B40-0x00000001850F2B90
		protected override void UpdateData(float deltaTime) {} // 0x0000000185D90660-0x0000000185D90700
		private void _OnLockTargetFromAutoToManual() {} // 0x000000018BC524C8-0x000000018BC52564
		private void _RefreshTarget(AbilitySystem _ = null) {} // 0x00000001850F2B90-0x00000001850F2CE0
		public void __iFixBaseProxy_OnAwake() {} // 0x000000018BC524C0-0x000000018BC524C8
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018BC3B918-0x000000018BC3B920
		public void __iFixBaseProxy_UpdateData(float P0) {} // 0x000000018BC3D440-0x000000018BC3D448
	}

	public class UIMainCharFootBar : TickableUIMono // TypeDefIndex: 52991
	{
		// Fields
		public Beyond.Gameplay.MountPoint mountPoint; // 0x68
		public Vector3 worldOffset; // 0x6C
		public UIAnimationWrapper dashBar; // 0x78
		public Transform dashBarParent; // 0x80
		public Transform dashBarTransform; // 0x88
		public Vector3 dashBarWorldOffset; // 0x90
		public float dashBarScale; // 0x9C
		public float dashBarScaleMobile; // 0xA0
		public FootBarDashCell dashFillFull; // 0xA8
		public FootBarDashCell dashFillHalf; // 0xB0
		public float smoothTime; // 0xB8
		private Entity m_mainChar; // 0xC0
		private bool m_dashBarNeedShow; // 0xC8
		private bool m_dashBarShowing; // 0xC9
		private Transform m_target; // 0xD0
		private Vector3 m_smoothVelocity; // 0xD8
		private bool m_notEnoughAnimShowing; // 0xE4
		private float m_curDashCellCount; // 0xE8
		private float m_curDashFillCount; // 0xEC
		private List<FootBarDashCell> m_dashFillList; // 0xF0
		private static readonly ProfilerMarker PROFILER_MARKER_UPDATE; // 0x00
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
	
		// Constructors
		public UIMainCharFootBar() {} // 0x000000018BC547C8-0x000000018BC548AC
		static UIMainCharFootBar() {} // 0x000000018BC54768-0x000000018BC547C8
	
		// Methods
		protected override void OnAwake() {} // 0x000000018BC53778-0x000000018BC53B58
		protected override void OnEnable() {} // 0x000000018BC53B58-0x000000018BC53CE0
		protected override void OnRelease() {} // 0x000000018BC53CE0-0x000000018BC54074
		private void _OnMainCharChange(in EventData<SetLeaderReason, Entity, Entity> data) {} // 0x000000018BC54544-0x000000018BC545E8
		private void _ProcessOnMainCharChange() {} // 0x000000018BC54638-0x000000018BC546D0
		public override void LateTick(float deltaTime) {} // 0x000000018BC52E58-0x000000018BC53778
		private void _OnDashCountChanged(float curCount) {} // 0x000000018BC54074-0x000000018BC54358
		private void _OnDashFailed() {} // 0x000000018BC54358-0x000000018BC54410
		private void _OnInteractNpc(in EventData<string, Entity> eventData) {} // 0x000000018BC544E0-0x000000018BC54544
		private void _OnDialogStart(in EventData<bool, DialogEnums.DialogType> eventData) {} // 0x000000018BC54474-0x000000018BC544E0
		private void _OnDialogFinish(in EventData<bool> eventData) {} // 0x000000018BC54410-0x000000018BC54474
		private void _SetInDialog(bool inDialog) {} // 0x000000018BC546D0-0x000000018BC54768
		private void _OnOutAnimCallback() {} // 0x000000018BC545E8-0x000000018BC54638
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018792FE0C-0x000000018792FE14
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
	}

	public class UIMainCharFootBarArc : TickableUIMono // TypeDefIndex: 52992
	{
		// Fields
		public Beyond.Gameplay.MountPoint mountPoint; // 0x68
		public Vector3 worldOffset; // 0x6C
		public UIAnimationWrapper dashBar; // 0x78
		public UIStateController dashBarStateController; // 0x80
		public Transform dashBarParent; // 0x88
		public RectTransform dashBarTransform; // 0x90
		public UIImage dashFill; // 0x98
		public UIImage dashFillLow; // 0xA0
		public UIImage dashFillWhite; // 0xA8
		public UIAnimationWrapper notEnoughAnim; // 0xB0
		public Vector3 dashBarWorldOffset; // 0xB8
		public float dashBarScale; // 0xC4
		public float dashBarScaleMobile; // 0xC8
		public float smoothTime; // 0xCC
		public int dashCountMin; // 0xD0
		public int dashCountMax; // 0xD4
		public float fillWhiteHoldTime; // 0xD8
		public float fillWhiteDecreaseSpeed; // 0xDC
		public AnimationCurve scaleCurve; // 0xE0
		public float scaleSmoothTime; // 0xE8
		private CanvasGroup m_canvasGroup; // 0xF0
		private Entity m_mainChar; // 0xF8
		private bool m_dashBarNeedShow; // 0x100
		private bool m_dashBarShowing; // 0x101
		private Transform m_target; // 0x108
		private Vector3 m_smoothVelocity; // 0x110
		private bool m_notEnoughAnimShowing; // 0x11C
		private float m_originalScale; // 0x120
		private float m_dampingScale; // 0x124
		private readonly PeriodicTimer m_fillWhiteStayTimer; // 0x128
		private readonly HashSet<string> m_disableState; // 0x130
		private TweenCallback m_cachedOnOutAnimCallback; // 0x138
		private float m_curDashCellCount; // 0x140
		private float m_curDashFillAmount; // 0x144
		private UIHeadBar.HpDisplayState m_dashWhiteState; // 0x148
		private Dictionary<int, string> m_dashCountStateNames; // 0x150
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB7DE0-0x0000000185FB7DF0 
	
		// Constructors
		public UIMainCharFootBarArc() {} // 0x0000000185926350-0x0000000185926630
	
		// Methods
		protected override void OnAwake() {} // 0x00000001850D66D0-0x00000001850D9F10
		protected override void OnEnable() {} // 0x0000000184A11110-0x0000000184A11350
		protected override void OnRelease() {} // 0x000000018BC52564-0x000000018BC52A58
		private void _OnMainCharChange(in EventData<SetLeaderReason, Entity, Entity> data) {} // 0x000000018BC52CA8-0x000000018BC52D20
		private void _ProcessOnMainCharChange() {} // 0x0000000184A11350-0x0000000184A113D0
		public override void TailLateTick(float deltaTime) {} // 0x0000000184F9DC10-0x0000000184F9F370
		private void _OnDashCountChanged(float curCount) {} // 0x0000000184F9F650-0x0000000184F9F720
		private void _OnDashFailed() {} // 0x000000018BC52A58-0x000000018BC52B10
		private void _OnInteractNpc(in EventData<string, Entity> eventData) {} // 0x000000018BC52C44-0x000000018BC52CA8
		private void _OnDialogStart(in EventData<bool, DialogEnums.DialogType> eventData) {} // 0x000000018BC52B74-0x000000018BC52BE0
		private void _OnDialogFinish(in EventData<bool> eventData) {} // 0x000000018BC52B10-0x000000018BC52B74
		private void _OnPlayCutscene(in EventData<CinematicTimelineManagerBase.TimelineHandle> eventData) {} // 0x000000018BC52D20-0x000000018BC52D84
		private void _OnFinishCutscene(in EventData<bool> eventData) {} // 0x000000018BC52BE0-0x000000018BC52C44
		private void _OnForbidSystemChanged(in EventData<ForbidType, bool> eventData) {} // 0x0000000185BC9900-0x0000000185BC9940
		private void _SetInDialog(bool inDialog) {} // 0x000000018BC52D84-0x000000018BC52E58
		public void SetUIDisable(string key, bool disable) {} // 0x0000000184E5BD90-0x0000000184E5BE60
		private void _RefreshDisableState() {} // 0x0000000184E5BE60-0x0000000184E5BFA0
		private void _OnOutAnimCallback() {} // 0x0000000185FA8740-0x0000000185FA8790
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018792FE0C-0x000000018792FE14
		public void __iFixBaseProxy_TailLateTick(float P0) {} // 0x00000001879BDE2C-0x00000001879BDE34
	}

	public class UIPoiseKnot : MonoBehaviour // TypeDefIndex: 52993
	{
		// Fields
		private CanvasGroup _canvasGroup; // 0x18
		private UIAnimationWrapper _animationWrapper; // 0x20
	
		// Constructors
		public UIPoiseKnot() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void SetVisible(bool visible) {} // 0x000000018BC5490C-0x000000018BC5497C
		public void KnotBreak() {} // 0x000000018BC548AC-0x000000018BC5490C
	}

	public class UIWeakLockAim : UIAbilityTargetFollower // TypeDefIndex: 52994
	{
		// Fields
		public CanvasGroup aimGroup; // 0x110
	
		// Constructors
		public UIWeakLockAim() {} // 0x0000000185FAE7B0-0x0000000185FAE7C0
	
		// Methods
		protected override void OnAwake() {} // 0x00000001850A9F90-0x00000001850AA090
		protected void Start() {} // 0x0000000185DAEE70-0x0000000185DAEEC0
		protected override void OnRelease() {} // 0x000000018BC5497C-0x000000018BC54A88
		private void _OnMainTargetChanged(in EventData<AbilitySystem, bool> data) {} // 0x000000018BC54A88-0x000000018BC54AE8
		private void _RefreshTarget() {} // 0x0000000185DAEEC0-0x0000000185DAEF70
		public void __iFixBaseProxy_OnAwake() {} // 0x000000018BC524C0-0x000000018BC524C8
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018BC3B918-0x000000018BC3B920
	}

	public class BlueprintPreviewHelper // TypeDefIndex: 52995
	{
		// Fields
		private ushort[][] m_data; // 0x10
		private int m_width; // 0x18
		private int m_height; // 0x1C
	
		// Constructors
		public BlueprintPreviewHelper() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void SetSize(int width, int height) {} // 0x000000018BC4868C-0x000000018BC4880C
		public void AddGridValue(int x, int y, byte value) {} // 0x000000018BC4826C-0x000000018BC483E4
		public void BatchAddGridValue(int xMin, int yMin, int width, int height, byte value) {} // 0x000000018BC483E4-0x000000018BC485BC
		public byte GetGridValue(int x, int y, out byte value2) {
			value2 = default;
			return default;
		} // 0x000000018BC485BC-0x000000018BC4868C
	}

	public class CommonTrackerNodeComp : MonoBehaviour // TypeDefIndex: 52996
	{
		// Fields
		public UIBlackboxTracker blackboxTracker; // 0x18
		public UICampfireTracker campfireTracker; // 0x20
		public UICommonTracker commonTracker; // 0x28
		public UICommonLevelTracker commonLevelTracker; // 0x30
		private const float TOO_FAR_DISTANCE = 15f; // Metadata: 0x02077048
	
		// Constructors
		public CommonTrackerNodeComp() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void ShowStyleType(CommonTrackingPointStyleType styleType, CommonTrackingPointInfoBase trackerData) {} // 0x000000018BC4896C-0x000000018BC48BAC
		public void PlayOutAnimation(CommonTrackingPointStyleType styleType) {} // 0x000000018BC488CC-0x000000018BC4896C
		public void UpdatePosition(CommonTrackingPointInfoBase trackerData) {} // 0x000000018BC48BAC-0x000000018BC48D48
	}

	public class CommonTrackerUpdate : MonoBehaviour // TypeDefIndex: 53001
	{
		// Fields
		[NonSerialized]
		public RectTransform rootTransform; // 0x18
		[NonSerialized]
		public GameObject templateTrackerGo; // 0x20
		[NonSerialized]
		public Transform trackerParentTransform; // 0x28
		private List<CommonTrackerItem> m_trackerItemCache; // 0x30
		private List<CommonTrackerData> m_trackerDatas; // 0x38
		private List<CommonTrackerItem> m_trackerItems; // 0x40
		public static readonly int PLAY_ANIM_IN_SIGNAL; // 0x00
	
		// Properties
		private bool _inFactoryTopView { get => default; } // 0x0000000185EBDA90-0x0000000185EBDB20 
	
		// Nested types
		public enum CommonTrackItemState // TypeDefIndex: 52997
		{
			Show = 0,
			Hide = 1,
			ShowToHide = 2
		}
	
		public enum CommonTrackerDataState // TypeDefIndex: 52998
		{
			Active = 0,
			InActive = 1
		}
	
		public class CommonTrackerData // TypeDefIndex: 52999
		{
			// Fields
			public CommonTrackerDataState activeState; // 0x10
			public CommonTrackingPointInfoBase trackData; // 0x18
			public string key; // 0x20
	
			// Constructors
			public CommonTrackerData() {} // 0x00000001846B2F60-0x00000001846B30B0
		}
	
		public class CommonTrackerItem // TypeDefIndex: 53000
		{
			// Fields
			public CommonTrackItemState showState; // 0x10
			public GameObject obj; // 0x18
			public CommonTrackerNodeComp commonTrackerNodeComp; // 0x20
	
			// Constructors
			public CommonTrackerItem() {} // 0x00000001846B2D50-0x00000001846B2EB0
		}
	
		// Constructors
		public CommonTrackerUpdate() {} // 0x0000000185492010-0x0000000185492020
		static CommonTrackerUpdate() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void UpdateCommonTrackers(bool missionHudOpen, int onShowSignal) {} // 0x000000018BC4902C-0x000000018BC49198
		public void AllTrackersPlayOutAnimation() {} // 0x000000018BC48D48-0x000000018BC48EEC
		private bool _InitTrackInfoByIndex(int trackerIdx, string key, CommonTrackingPointInfoBase trackData) => default; // 0x00000001846B2EB0-0x00000001846B2F60
		private CommonTrackerItem _CreateNewMissionTracker() => default; // 0x000000018BC49198-0x000000018BC49238
		private void _DeleteInvalidTracker() {} // 0x000000018BC48FB8-0x000000018BC4902C
		private void _ShowTrackerGo(CommonTrackerItem trackerItem, CommonTrackingPointInfoBase trackerData) {} // 0x000000018BC48EEC-0x000000018BC48FB8
		private void _HideTrackerGo(CommonTrackerItem trackerItem) {} // 0x0000000185C1DAF0-0x0000000185C1DBF0
		private int _FindTrackIndexByKey(string key) => default; // 0x0000000185FA4DE0-0x0000000185FA4E20
	}

	public class UIBlackboxTracker : MonoBehaviour // TypeDefIndex: 53002
	{
		// Fields
		public RectTransform rectTransform; // 0x18
		public RectTransform arrowRotator; // 0x20
		public UIAnimationWrapper animationWrapper; // 0x28
		public UIText distanceTxt; // 0x30
	
		// Constructors
		public UIBlackboxTracker() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void UpdatePosition(Vector2 uiPos, float uiAngle, bool isOutBound, float distance, bool needShowDistance) {} // 0x000000018BC4E7C0-0x000000018BC4EA1C
	}

	public class UICampfireTracker : MonoBehaviour // TypeDefIndex: 53003
	{
		// Fields
		public RectTransform rectTransform; // 0x18
		public RectTransform arrowRotator; // 0x20
		public UIAnimationWrapper animationWrapper; // 0x28
		public UIImage image; // 0x30
		private const string ORG_ICON = "Map/MarkIconSmall/campfire_icon"; // Metadata: 0x02077051
	
		// Constructors
		public UICampfireTracker() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void UpdatePosition(Vector2 uiPos, float uiAngle, bool isOutBound, float distance, bool needShowDistance) {} // 0x000000018BC4EADC-0x000000018BC4EBEC
		public void UpdateImage(CommonTrackingPointInfoBase trackerData) {} // 0x000000018BC4EA1C-0x000000018BC4EADC
	}

	public class UICommonLevelTracker : MonoBehaviour // TypeDefIndex: 53004
	{
		// Fields
		public RectTransform rectTransform; // 0x18
		public RectTransform arrowRotator; // 0x20
		public UIAnimationWrapper animationWrapper; // 0x28
		public UIText distanceTxt; // 0x30
	
		// Constructors
		public UICommonLevelTracker() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void UpdatePosition(PosValueState posValueState, bool needShowDistance, Vector2 uiPos, float uiAngle, bool isOutBound, float distance, CommonTrackMapTier mapTier = CommonTrackMapTier.Current /* Metadata: 0x02077071 */) {} // 0x000000018BC4EBEC-0x000000018BC4EE58
	}

	public class UICommonTracker : MonoBehaviour // TypeDefIndex: 53005
	{
		// Fields
		public RectTransform rectTransform; // 0x18
		public RectTransform arrowRotator; // 0x20
		public UIText distanceTxt; // 0x28
		public UIAnimationWrapper animationWrapper; // 0x30
		public UIImage levelImage; // 0x38
		public RectTransform normalNode; // 0x40
		public UIImage normalShadowImage; // 0x48
		public UIImage normalImage; // 0x50
		public UIImage arrowUpImage; // 0x58
		public RectTransform arrowUpRectTransform; // 0x60
		private const string ORG_ICON = "Map/MarkIconSmall/general_track_other_level"; // Metadata: 0x02077073
	
		// Constructors
		public UICommonTracker() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void UpdateImage(CommonTrackingPointInfoBase trackerData) {} // 0x000000018BC4EE58-0x000000018BC4EF50
		public void UpdatePosition(PosValueState posValueState, bool needShowDistance, Vector2 uiPos, float uiAngle, bool isOutBound, float distance, CommonTrackMapTier mapTier = CommonTrackMapTier.Current /* Metadata: 0x02077072 */) {} // 0x000000018BC4EF50-0x000000018BC4F29C
	}

	public class CoolerUnitProgressBarUI : WorldUIController // TypeDefIndex: 53006
	{
		// Fields
		private Entity m_targetEntity; // 0xC0
		private CoolerUnitComponent m_coolerUnitComponent; // 0xC8
		private float m_displayProgress; // 0xD0
		private const float LERP_SPEED = 5f; // Metadata: 0x0207709F
		private const float MAX_STEP = 0.07f; // Metadata: 0x020770A3
		public UIText progressDesc; // 0xD8
		public UIText progressText; // 0xE0
		public UIImage progressImage; // 0xE8
		public Transform progressUIRoot; // 0xF0
		private CanvasGroup m_canvasGroup; // 0xF8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Constructors
		public CoolerUnitProgressBarUI() {} // 0x0000000184814DE0-0x0000000184814DF0
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment) {} // 0x000000018BC49238-0x000000018BC49494
		public override void SetUIForward() {} // 0x000000018BC495C0-0x000000018BC49740
		public override void SetPos() {} // 0x000000018BC49494-0x000000018BC495C0
		public override void TickUI(float deltaTime) {} // 0x000000018BC49740-0x000000018BC497BC
		private void _TickCanvasGroup(float deltaTime) {} // 0x000000018BC497E4-0x000000018BC498C8
		private void _UpdateProgress(float deltaTime) {} // 0x000000018BC498C8-0x000000018BC49A54
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3) {} // 0x000000018BC497BC-0x000000018BC497CC
		public void __iFixBaseProxy_SetUIForward() {} // 0x000000018BC497D4-0x000000018BC497DC
		public void __iFixBaseProxy_SetPos() {} // 0x000000018BC497CC-0x000000018BC497D4
		public void __iFixBaseProxy_TickUI(float P0) {} // 0x000000018BC497DC-0x000000018BC497E4
	}

	public class CoolerUnitTemperatureCircleUI : WorldUIController // TypeDefIndex: 53009
	{
		// Fields
		private const string AUDIO_EVENT_SUCCEED = "au_int_forge_iron_success"; // Metadata: 0x020770A7
		private static readonly UnityEngine.Color COLOR_BLUE; // 0x00
		private static readonly UnityEngine.Color COLOR_GREEN; // 0x10
		private static readonly UnityEngine.Color COLOR_RED; // 0x20
		private Entity m_targetEntity; // 0xC0
		private CoolerUnitComponent m_coolerUnitComponent; // 0xC8
		public UIImage bg; // 0xD0
		public UIImage warningBg; // 0xD8
		public UIText desc; // 0xE0
		public Transform tempCircleRoot; // 0xE8
		private CanvasGroup m_canvasGroup; // 0xF0
		private LangKey m_customDesc; // 0xF8
		private LangKey m_highTempDesc; // 0x108
		private LangKey m_lowTempDesc; // 0x118
		private LangKey m_goodTempDesc; // 0x128
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Nested types
		public enum ETemperatureState // TypeDefIndex: 53007
		{
			None = 0,
			Low = 1,
			Safe = 2,
			High = 3,
			Finish = 4
		}
	
		public static class CoolerUnitLangKeys // TypeDefIndex: 53008
		{
			// Fields
			public const string TOO_COLD = "lang_int_forgeiron_TempTooCold"; // Metadata: 0x020770C6
			public const string GOOD = "lang_int_forgeiron_TempGood"; // Metadata: 0x020770E5
			public const string TOO_HOT = "lang_int_forgeiron_TempTooHot"; // Metadata: 0x02077101
			public const string FINISH = "lang_int_forgeiron_Finish"; // Metadata: 0x0207711F
		}
	
		// Constructors
		public CoolerUnitTemperatureCircleUI() {} // 0x0000000184814DE0-0x0000000184814DF0
		static CoolerUnitTemperatureCircleUI() {} // 0x000000018BC4A5E4-0x000000018BC4A65C
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment) {} // 0x000000018BC49A54-0x000000018BC49DA4
		public override void SetUIForward() {} // 0x000000018BC49ED0-0x000000018BC4A050
		public override void SetPos() {} // 0x000000018BC49DA4-0x000000018BC49ED0
		public override void TickUI(float deltaTime) {} // 0x000000018BC4A050-0x000000018BC4A0F0
		private void _TickCanvasGroup(float deltaTime) {} // 0x000000018BC4A454-0x000000018BC4A538
		private void _UpdateUIState() {} // 0x000000018BC4A538-0x000000018BC4A5E4
		private void _SetState(ETemperatureState state) {} // 0x000000018BC4A174-0x000000018BC4A454
		private string _GetLangKeyOrDefault(LangKey customKey, string defaultKey) => default; // 0x000000018BC4A0F0-0x000000018BC4A174
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3) {} // 0x000000018BC497BC-0x000000018BC497CC
		public void __iFixBaseProxy_SetUIForward() {} // 0x000000018BC497D4-0x000000018BC497DC
		public void __iFixBaseProxy_SetPos() {} // 0x000000018BC497CC-0x000000018BC497D4
		public void __iFixBaseProxy_TickUI(float P0) {} // 0x000000018BC497DC-0x000000018BC497E4
	}

	public class CoolerUnitTemperatureUI : WorldUIController // TypeDefIndex: 53011
	{
		// Fields
		private static readonly float MIN_Y_POS; // 0x00
		private static readonly float MAX_HEIGHT; // 0x04
		private static readonly UnityEngine.Color COLOR_BLUE; // 0x08
		private static readonly UnityEngine.Color COLOR_GREEN; // 0x18
		private static readonly UnityEngine.Color COLOR_RED; // 0x28
		private Entity m_targetEntity; // 0xC0
		private CoolerUnitComponent m_coolerUnitComponent; // 0xC8
		public float greenBarTotalHeight; // 0xD0
		public float initBarPosY; // 0xD4
		public float totalBarPosY; // 0xD8
		public float initHandPosY; // 0xDC
		public float totalHandPosY; // 0xE0
		private float m_greenBarCurHeight; // 0xE4
		public UIImage progressImage; // 0xE8
		public RectTransform greenBar; // 0xF0
		public RectTransform goodHand; // 0xF8
		public Transform temperatureUI; // 0x100
		private CanvasGroup m_canvasGroup; // 0x108
		private bool m_initBarSize; // 0x110
		private bool m_initPosSynced; // 0x111
		private float m_lastMount; // 0x114
		private TempColorState m_colorState; // 0x118
		private bool m_colorStateInited; // 0x11C
		private const float COLOR_EPS = 0.02f; // Metadata: 0x02077139
		private const float SNAP_THRESHOLD = 0.25f; // Metadata: 0x0207713D
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Nested types
		private enum TempColorState // TypeDefIndex: 53010
		{
			Blue = 0,
			Green = 1,
			Red = 2
		}
	
		// Constructors
		public CoolerUnitTemperatureUI() {} // 0x000000018BC4B680-0x000000018BC4B694
		static CoolerUnitTemperatureUI() {} // 0x000000018BC4B5E0-0x000000018BC4B680
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment) {} // 0x000000018BC4A6CC-0x000000018BC4A864
		public override void Clear() {} // 0x000000018BC4A65C-0x000000018BC4A6CC
		public override void SetUIForward() {} // 0x000000018BC4AA0C-0x000000018BC4AB8C
		public override void SetPos() {} // 0x000000018BC4A8E0-0x000000018BC4AA0C
		public override void TickUI(float deltaTime) {} // 0x000000018BC4AB8C-0x000000018BC4AC18
		private void _TickCanvasGroup(float deltaTime) {} // 0x000000018BC4AC20-0x000000018BC4AD04
		public void NormalizeRange(ref float min, ref float max) {} // 0x000000018BC4A864-0x000000018BC4A8E0
		private void _UpdateUIInfo(float deltaTime) {} // 0x000000018BC4AD04-0x000000018BC4B14C
		private void _UpdateUIPos(float deltaTime) {} // 0x000000018BC4B14C-0x000000018BC4B5E0
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3) {} // 0x000000018BC497BC-0x000000018BC497CC
		public void __iFixBaseProxy_Clear() {} // 0x000000018BC4AC18-0x000000018BC4AC20
		public void __iFixBaseProxy_SetUIForward() {} // 0x000000018BC497D4-0x000000018BC497DC
		public void __iFixBaseProxy_SetPos() {} // 0x000000018BC497CC-0x000000018BC497D4
		public void __iFixBaseProxy_TickUI(float P0) {} // 0x000000018BC497DC-0x000000018BC497E4
	}

	public class CoolerUnitTotalProgressBarUI : WorldUIController // TypeDefIndex: 53012
	{
		// Fields
		private float m_displayProgress; // 0xC0
		private int m_lastDisplayPercent; // 0xC4
		private static readonly string[] S_PERCENT_STRING; // 0x00
		public UIText progressDesc; // 0xC8
		public UIText progressText; // 0xD0
		public UIImage progressImage; // 0xD8
		public Transform progressUIRoot; // 0xE0
		private CanvasGroup m_canvasGroup; // 0xE8
		private WaterAbsorbedImpactController m_module; // 0xF0
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Constructors
		public CoolerUnitTotalProgressBarUI() {} // 0x000000018BC4BFAC-0x000000018BC4BFC0
		static CoolerUnitTotalProgressBarUI() {} // 0x000000018BC4BF5C-0x000000018BC4BFAC
	
		// Methods
		private static string[] _GeneratePercentStrings() => default; // 0x000000018BC4B9B0-0x000000018BC4BA88
		public override void Init(Entity target, string path, ulong id, int typeSegment) {} // 0x000000018BC4B694-0x000000018BC4B764
		private void _ResetUI() {} // 0x000000018BC4BB18-0x000000018BC4BB94
		private void _GetCanvas() {} // 0x000000018BC4BA88-0x000000018BC4BB18
		private bool _TryGetModule(ulong id) => default; // 0x000000018BC4BD5C-0x000000018BC4BE74
		public override void SetUIForward() {} // 0x000000018BC4B804-0x000000018BC4B934
		public override void SetPos() {} // 0x000000018BC4B764-0x000000018BC4B804
		public override void TickUI(float deltaTime) {} // 0x000000018BC4B934-0x000000018BC4B9B0
		private void _TickCanvasGroup(float deltaTime) {} // 0x000000018BC4BC78-0x000000018BC4BD5C
		private void _UpdateProgress(float deltaTime) {} // 0x000000018BC4BE74-0x000000018BC4BF5C
		private void _SetProgressText(int percent) {} // 0x000000018BC4BB94-0x000000018BC4BC78
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3) {} // 0x000000018BC497BC-0x000000018BC497CC
		public void __iFixBaseProxy_SetUIForward() {} // 0x000000018BC497D4-0x000000018BC497DC
		public void __iFixBaseProxy_SetPos() {} // 0x000000018BC497CC-0x000000018BC497D4
		public void __iFixBaseProxy_TickUI(float P0) {} // 0x000000018BC497DC-0x000000018BC497E4
	}

	public class FacLineCell : MonoBehaviour // TypeDefIndex: 53014
	{
		// Fields
		private const float HSV_VALUE_RATIO = 1.6f; // Metadata: 0x02077144
		private RectTransform _rectTransform; // 0x18
		public RectTransform topAgent; // 0x20
		public RectTransform bottomAgent; // 0x28
		public UIAnimationWrapper lineAnimationWrapper; // 0x30
		public UIAnimationWrapper decoAnimationWrapper; // 0x38
		private List<UIImage> m_imageList; // 0x40
	
		// Nested types
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 53013
		{
			// Fields
			public FacLineCell __4__this; // 0x10
			public TweenCallback callback; // 0x18
	
			// Constructors
			public __c__DisplayClass9_0() {} // 0x000000018BC4BFC0-0x000000018BC4C104
	
			// Methods
			internal void _PlayLineDecoAnimation_b__0() {} // 0x000000018BC4C3E8-0x000000018BC4C4C4
		}
	
		// Constructors
		public FacLineCell() {} // 0x000000018BC4DDFC-0x000000018BC4DE4C
	
		// Methods
		private void Awake() {} // 0x000000018BC4C4C4-0x000000018BC4C650
		public void PlayLineAnimation(string animationName, TweenCallback callback = null) {} // 0x000000018BC4C104-0x000000018BC4C354
		public void PlayLineDecoAnimation(string animationName, TweenCallback callback = null) {} // 0x000000018BC4C354-0x000000018BC4C3E8
		public void ChangeLineColor(UnityEngine.Color color) {} // 0x0000000185A81150-0x0000000185A811E0
		public void ChangeLineWidth(float width) {} // 0x0000000185492010-0x0000000185492020
	}

	public class FacLineDrawer : MonoBehaviour, IUIClearable // TypeDefIndex: 53016
	{
		// Fields
		private RectTransform m_rectTransform; // 0x18
		private readonly Dictionary<uint, LineData> m_lineCache; // 0x20
		private readonly List<GameObject> m_instantiatedLineCell; // 0x28
		private uint m_nextLineId; // 0x30
		private const uint INVALID_LINE_ID = 0; // Metadata: 0x02077148
		public RectTransform startDrawAgent; // 0x38
		public RectTransform endDrawAgent; // 0x40
		public GameObject linkLinePrefab; // 0x48
	
		// Nested types
		private struct LineData // TypeDefIndex: 53015
		{
			// Fields
			public FacLineCell start; // 0x00
			public FacLineCell end; // 0x08
			public FacLineCell link; // 0x10
		}
	
		// Constructors
		public FacLineDrawer() {} // 0x0000000185CA79C0-0x0000000185CA7A90
	
		// Methods
		private void Awake() {} // 0x000000018BC4C650-0x000000018BC4C6D0
		private void OnDestroy() {} // 0x000000018BC4CF90-0x000000018BC4CFE0
		private void _Clear() {} // 0x000000018BC4D2B0-0x000000018BC4D46C
		private GameObject _CloneLineObject(GameObject sourceObject, Transform locateTransform) => default; // 0x000000018BC4D46C-0x000000018BC4D5A8
		private void _RefreshCopyLineObjectColor(GameObject lineObject, UnityEngine.Color color) {} // 0x000000018BC4D5A8-0x000000018BC4D6A4
		public void ClearComponent() {} // 0x000000018BC4C7FC-0x000000018BC4C84C
		public uint DrawLine(FacLineCell start, FacLineCell end) => default; // 0x000000018BC4C89C-0x000000018BC4CF90
		public void PlayLineAnimation(uint lineId, string animationName, TweenCallback callback = null) {} // 0x000000018BC4CFE0-0x000000018BC4D168
		public void PlayPortLineDecoAnimation(uint lineId, string animationName, bool isStart, TweenCallback callback = null) {} // 0x000000018BC4D168-0x000000018BC4D2B0
		public void ChangeLineColor(uint lineId, UnityEngine.Color color) {} // 0x000000018BC4C6D0-0x000000018BC4C7FC
		public void ClearDrawer() {} // 0x000000018BC4C84C-0x000000018BC4C89C
	}

	public class FacPipeAnimationSetting : MonoBehaviour // TypeDefIndex: 53017
	{
		// Fields
		private const string PIPE_ANIMATION_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Animations/Factory/pipecell"; // Metadata: 0x02077149
		public string decoInAnimation; // 0x18
		public string decoOutAnimation; // 0x20
		public string itemAnimation; // 0x28
		public bool needBoldAnimations; // 0x30
		public string boldDecoInAnimation; // 0x38
		public string boldDecoOutAnimation; // 0x40
		public string boldItemAnimation; // 0x48
	
		// Constructors
		public FacPipeAnimationSetting() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public class FacRegionUpgradeEffectController : MonoBehaviour // TypeDefIndex: 53018
	{
		// Fields
		private GameObject _waitUpgradeNode; // 0x18
		private GameObject _upgradedRegionNode; // 0x20
		private GameObject _waitUpgradeSelectNode; // 0x28
	
		// Constructors
		public FacRegionUpgradeEffectController() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void _RefreshNodeState(GameObject node, bool active) {} // 0x000000018BC4D824-0x000000018BC4D8D8
		public void SetUpgradeState(bool isUpgraded) {} // 0x000000018BC4D724-0x000000018BC4D7B4
		public void SetSelectState(bool isSelected) {} // 0x000000018BC4D6A4-0x000000018BC4D724
		public void SetVisibleState(bool isVisible) {} // 0x000000018BC4D7B4-0x000000018BC4D824
	}

	public class UIFacTechTreePanel : UIPanelBase // TypeDefIndex: 53019
	{
		// Fields
		private bool m_inited; // 0x70
		private float m_zoom; // 0x74
		private float m_zoomValue; // 0x78
		private Vector2 m_oriSize; // 0x7C
		private TweenerCore<Vector3, Vector3, VectorOptions> m_zoomTween; // 0x88
		private float m_moveLeft; // 0x90
		private float m_oldMoveLeft; // 0x94
		private float m_moveTime; // 0x98
		private bool m_openTweenFinished; // 0x9C
		private Vector2 m_anchoredPosOffset; // 0xA0
		private float m_horizontalOffset; // 0xA8
		private float m_verticalOffset; // 0xAC
		private Vector2 m_lastScale; // 0xB0
		private LuaPanel _techTreeLuaPanel; // 0xB8
		private UITouchPanel _touchPanel; // 0xC0
		private RectTransform _techTreeRectTransform; // 0xC8
		private RectTransform _techTreePanel; // 0xD0
		private float _titleHight; // 0xD8
		private float _moveSpeed; // 0xDC
		private float _zoomSpeed; // 0xE0
		private float _zoomDefault; // 0xE4
		private float _zoomRangeMin; // 0xE8
		private float _zoomRangeMax; // 0xEC
		private float _showNameScale; // 0xF0
		private float _zoomTweenTime; // 0xF4
		private float _moveNodeXOffset; // 0xF8
		private float _moveNodeYOffset; // 0xFC
		private float _startZoomTweenTime; // 0x100
		private AnimationCurve _openUICurve; // 0x108
		private float _movePosTime; // 0x110
		private AnimationCurve _movePosCurve; // 0x118
		private float _movePanelTime; // 0x120
		private AnimationCurve _movePanelCurve; // 0x128
		private float _unlockNodeTime; // 0x130
		private AnimationCurve _unlockNodeCurve; // 0x138
		private bool m_controllerInitialized; // 0x140
		private bool m_isDetailShown; // 0x141
		private float _controllerDragSpeed; // 0x144
		private float _controllerZoomSpeed; // 0x148
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Constructors
		public UIFacTechTreePanel() {} // 0x000000018BC50E4C-0x000000018BC50EA4
	
		// Methods
		protected override void OnRelease() {} // 0x000000018BC4F728-0x000000018BC4F7A8
		public override void Tick(float deltaTime) {} // 0x000000018BC4F8A8-0x000000018BC4F92C
		public void InitData() {} // 0x000000018BC4F340-0x000000018BC4F558
		private void _OnDrag(Vector2 value) {} // 0x000000018BC4FECC-0x000000018BC4FF74
		private void _OnZoom(float value, bool needTween) {} // 0x000000018BC500D8-0x000000018BC50280
		private void _SetScale(bool needTween, float zoomTweenTime = 0f /* Metadata: 0x0207718E */, AnimationCurve curve = null, TweenCallback onFinish = null) {} // 0x000000018BC50940-0x000000018BC50C80
		private void _RefreshAll() {} // 0x000000018BC504E4-0x000000018BC50570
		private void _PosAdjust() {} // 0x000000018BC50280-0x000000018BC504E4
		private void _RefreshPivotPosition() {} // 0x000000018BC50570-0x000000018BC50940
		private void _UpdatePositionOffsetAfterZoomed() {} // 0x000000018BC50C80-0x000000018BC50E4C
		public void MoveNode(float dis, float nodeX, float nodeY, bool ignorePos = false /* Metadata: 0x02077192 */) {} // 0x000000018BC4F558-0x000000018BC4F728
		public void FocusNode(float nodeX, float nodeY, TweenCallback onComplete) {} // 0x000000018BC4F29C-0x000000018BC4F340
		public void OnUnlockTech(float nodeX, float nodeY, TweenCallback onComplete) {} // 0x000000018BC4F7A8-0x000000018BC4F84C
		public void ZoomToFullTechTree(TweenCallback onComplete) {} // 0x000000018BC4FA9C-0x000000018BC4FB20
		private void _OnUnlockMoveNode(float nodeX, float nodeY) {} // 0x000000018BC4FF74-0x000000018BC500D8
		private void _ControllerUpdate() {} // 0x000000018BC4FD08-0x000000018BC4FDAC
		private void _ControllerZoomUpdate() {} // 0x000000018BC4FDAC-0x000000018BC4FECC
		private void _ControllerDragUpdate() {} // 0x000000018BC4FB20-0x000000018BC4FD08
		public void SetDetailShownState(bool isShown) {} // 0x000000018BC4F84C-0x000000018BC4F8A8
		private void _InitData_b__39_0(PointerEventData eventData) {} // 0x000000018BC4F92C-0x000000018BC4F9B8
		private void _InitData_b__39_1(float zoomValue) {} // 0x000000018BC4F9B8-0x000000018BC4FA28
		private void _InitData_b__39_2() {} // 0x000000018BC4FA28-0x000000018BC4FA9C
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018BC3B918-0x000000018BC3B920
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
	}

	public class ForgeIronProgressBarUI : WorldUIController // TypeDefIndex: 53020
	{
		// Fields
		public UIText progressDesc; // 0xC0
		public UIText progressText; // 0xC8
		public UIImage progressImage; // 0xD0
		public Transform progressUIRoot; // 0xD8
		private InteractiveLogicForgeIron m_logic; // 0xE0
		private CanvasGroup m_canvasGroup; // 0xE8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Constructors
		public ForgeIronProgressBarUI() {} // 0x0000000184814DE0-0x0000000184814DF0
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment) {} // 0x000000018BC54F48-0x000000018BC5506C
		public override void SetPos() {} // 0x000000018BC5506C-0x000000018BC551A8
		public override void SetUIForward() {} // 0x000000018BC551A8-0x000000018BC553E4
		public override void TickUI(float deltaTime) {} // 0x000000018BC553E4-0x000000018BC554F8
		public void UpdateProgress() {} // 0x000000018BC554F8-0x000000018BC5582C
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3) {} // 0x000000018BC497BC-0x000000018BC497CC
		public void __iFixBaseProxy_SetPos() {} // 0x000000018BC497CC-0x000000018BC497D4
		public void __iFixBaseProxy_SetUIForward() {} // 0x000000018BC497D4-0x000000018BC497DC
		public void __iFixBaseProxy_TickUI(float P0) {} // 0x000000018BC497DC-0x000000018BC497E4
	}

	public class ForgeIronTemperatureCircleUI : WorldUIController // TypeDefIndex: 53022
	{
		// Fields
		private const string AUDIO_EVENT_SUCCEED = "au_int_forge_iron_success"; // Metadata: 0x02077193
		private static readonly UnityEngine.Color COLOR_BLUE; // 0x00
		private static readonly UnityEngine.Color COLOR_GREEN; // 0x10
		private static readonly UnityEngine.Color COLOR_RED; // 0x20
		public UIImage bg; // 0xC0
		public UIImage warningBg; // 0xC8
		public UIText desc; // 0xD0
		public Transform tempCircleRoot; // 0xD8
		public int belongRound; // 0xE0
		private InteractiveLogicForgeIron m_logic; // 0xE8
		private CanvasGroup m_canvasGroup; // 0xF0
		private string m_customDesc; // 0xF8
		private string m_highTempDesc; // 0x100
		private string m_lowTempDesc; // 0x108
		private string m_goodTempDesc; // 0x110
		private bool m_hasPlaySuccessAudio; // 0x118
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Nested types
		public enum ETemperatureState // TypeDefIndex: 53021
		{
			None = 0,
			Low = 1,
			Safe = 2,
			High = 3,
			Finish = 4
		}
	
		// Constructors
		public ForgeIronTemperatureCircleUI() {} // 0x0000000184814DE0-0x0000000184814DF0
		static ForgeIronTemperatureCircleUI() {} // 0x000000018BC564E0-0x000000018BC56558
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment) {} // 0x000000018BC55884-0x000000018BC5597C
		public override void Clear() {} // 0x000000018BC5582C-0x000000018BC55884
		public override void SetPos() {} // 0x000000018BC5597C-0x000000018BC55AD4
		public override void SetUIForward() {} // 0x000000018BC55AD4-0x000000018BC55E2C
		public override void TickUI(float deltaTime) {} // 0x000000018BC55E2C-0x000000018BC55FB8
		public void UpdateUIState() {} // 0x000000018BC55FB8-0x000000018BC56110
		private void _SetState(bool max, bool low, bool high, ETemperatureState state) {} // 0x000000018BC56110-0x000000018BC564E0
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3) {} // 0x000000018BC497BC-0x000000018BC497CC
		public void __iFixBaseProxy_Clear() {} // 0x000000018BC4AC18-0x000000018BC4AC20
		public void __iFixBaseProxy_SetPos() {} // 0x000000018BC497CC-0x000000018BC497D4
		public void __iFixBaseProxy_SetUIForward() {} // 0x000000018BC497D4-0x000000018BC497DC
		public void __iFixBaseProxy_TickUI(float P0) {} // 0x000000018BC497DC-0x000000018BC497E4
	}

	public class ForgeIronTemperatureUI : WorldUIController // TypeDefIndex: 53023
	{
		// Fields
		private static readonly UnityEngine.Color COLOR_BLUE; // 0x00
		private static readonly UnityEngine.Color COLOR_GREEN; // 0x10
		private static readonly UnityEngine.Color COLOR_RED; // 0x20
		public float greenBarTotalHeight; // 0xC0
		public float initBarPosY; // 0xC4
		public float totalBarPosY; // 0xC8
		public float initHandPosY; // 0xCC
		public float totalHandPosY; // 0xD0
		private float m_greenBarCurHeight; // 0xD4
		public UIImage progressImage; // 0xD8
		public RectTransform greenBar; // 0xE0
		public RectTransform goodHand; // 0xE8
		public Transform temperatureUI; // 0xF0
		private InteractiveLogicForgeIron m_logic; // 0xF8
		private CanvasGroup m_canvasGroup; // 0x100
		private bool m_initBarSize; // 0x108
		private float m_lastMount; // 0x10C
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Constructors
		public ForgeIronTemperatureUI() {} // 0x000000018BC571FC-0x000000018BC57210
		static ForgeIronTemperatureUI() {} // 0x000000018BC57184-0x000000018BC571FC
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment) {} // 0x000000018BC56558-0x000000018BC56650
		public override void SetPos() {} // 0x000000018BC56650-0x000000018BC5678C
		public override void SetUIForward() {} // 0x000000018BC5678C-0x000000018BC568F8
		public override void TickUI(float deltaTime) {} // 0x000000018BC568F8-0x000000018BC56A18
		public void UpdateUIInfo() {} // 0x000000018BC56A18-0x000000018BC56D08
		public void UpdateUIPos() {} // 0x000000018BC56D08-0x000000018BC57184
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3) {} // 0x000000018BC497BC-0x000000018BC497CC
		public void __iFixBaseProxy_SetPos() {} // 0x000000018BC497CC-0x000000018BC497D4
		public void __iFixBaseProxy_SetUIForward() {} // 0x000000018BC497D4-0x000000018BC497DC
		public void __iFixBaseProxy_TickUI(float P0) {} // 0x000000018BC497DC-0x000000018BC497E4
	}

	public class GuideFakeButton : Selectable, IPointerClickHandler, IUIClearable // TypeDefIndex: 53024
	{
		// Fields
		public UIButton targetButton; // 0x180
		public UIToggle targetToggle; // 0x188
		public UIDropdown targetDropdown; // 0x190
		public string targetKeyHintActionId; // 0x198
		private string m_targetActionId; // 0x1A0
		public Action onClick; // 0x1A8
		private InputBindingGroupMonoTarget m_parent; // 0x1B0
	
		// Constructors
		public GuideFakeButton() {} // 0x0000000185F8B690-0x0000000185F8B6E0
	
		// Methods
		public void ForceToggleTargetBinding(bool active, bool forDrag = false /* Metadata: 0x020771B2 */) {} // 0x000000018BC57840-0x000000018BC57A10
		public void CopyTargetBinding() {} // 0x000000018BC57558-0x000000018BC57840
		private void _OnTriggerPlayerAction(in EventData<string> actionId) {} // 0x000000018BC582A0-0x000000018BC5832C
		public void ClearTarget() {} // 0x000000018BC57448-0x000000018BC57558
		public void ClearBinding() {} // 0x000000018BC572A8-0x000000018BC573F8
		protected override void Awake() {} // 0x000000018BC57210-0x000000018BC572A8
		public override void OnPointerDown(PointerEventData eventData) {} // 0x000000018BC57CB0-0x000000018BC57DFC
		public override void OnPointerUp(PointerEventData eventData) {} // 0x000000018BC58094-0x000000018BC581E0
		public override void OnPointerEnter(PointerEventData eventData) {} // 0x000000018BC57DFC-0x000000018BC57F48
		public override void OnPointerExit(PointerEventData eventData) {} // 0x000000018BC57F48-0x000000018BC58094
		public void OnPointerClick(PointerEventData eventData) {} // 0x000000018BC57A10-0x000000018BC57CB0
		public void ClearComponent() {} // 0x000000018BC573F8-0x000000018BC57448
		private void _ClearOnClick() {} // 0x000000018BC581F0-0x000000018BC582A0
		public void __iFixBaseProxy_Awake() {} // 0x000000018BBD59E0-0x000000018BBD59E8
		public void __iFixBaseProxy_OnPointerDown(PointerEventData P0) {} // 0x000000018BBF36D4-0x000000018BBF36DC
		public void __iFixBaseProxy_OnPointerUp(PointerEventData P0) {} // 0x000000018BBF36DC-0x000000018BBF36E4
		public void __iFixBaseProxy_OnPointerEnter(PointerEventData P0) {} // 0x000000018BC581E0-0x000000018BC581E8
		public void __iFixBaseProxy_OnPointerExit(PointerEventData P0) {} // 0x000000018BC581E8-0x000000018BC581F0
	}

	[Serializable]
	public class RegionMap3DCfg // TypeDefIndex: 53025
	{
		// Fields
		[NonSerialized]
		public GameObject model; // 0x10
		[NonSerialized]
		public GameObject ground; // 0x18
		[NonSerialized]
		public UIRegionMap3DUICell ui; // 0x20
		public GameObject glitch; // 0x28
		public Vector4 uiRect; // 0x30
		private string _ui; // 0x40
		private string _model; // 0x48
		private string _ground; // 0x50
		private bool _isLoaded_k__BackingField; // 0x58
	
		// Properties
		public bool isLoaded { get; private set; } // 0x0000000181BE64B0-0x0000000181BE64C0 0x0000000181BE64C0-0x0000000181BE64D0
	
		// Constructors
		public RegionMap3DCfg() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Load(RegionMapSetting regionMapSetting) {} // 0x00000001845A8090-0x00000001845A83B0
	}

	public enum RegionMapShowType // TypeDefIndex: 53026
	{
		Map = 0,
		Watch = 1
	}

	public class RegionMapSetting : UIPanelBase // TypeDefIndex: 53027
	{
		// Fields
		public const string UI_REGION_MAP_TRACK_ICON = "Assets/Beyond/DynamicAssets/Gameplay/UI/Prefabs/Map/Widgets/RegionMapTrackIcon.prefab"; // Metadata: 0x020771B9
		public Transform uiRoot; // 0x70
		public Transform buildingRoot; // 0x78
		public Transform groundRoot; // 0x80
		private Transform _modelNode; // 0x88
		private Transform _uiNode; // 0x90
		private RectTransform _uiPlayerMark; // 0x98
		private UnityEngine.Color _normalModelOuterColor; // 0xA0
		private UnityEngine.Color _selectedModelOuterColor; // 0xB0
		private Vector3 _moveFinalRotation; // 0xC0
		private SerializeFieldDictionary<string, RegionMap3DCfg> _cfg; // 0xD0
		private Transform m_currLoadedRegionTransform; // 0xD8
		private RegionMapShowType m_curShowType; // 0xE0
		private float m_animTimer; // 0xE4
		private float m_animDuration; // 0xE8
		private bool m_playAnim; // 0xEC
		private readonly List<RectTransform> m_trackIconList; // 0xF0
		private readonly Dictionary<Renderer, Material[]> m_refreshedMaterials; // 0xF8
		private UnityEngine.Color m_normalLevelModelColor; // 0x100
		private const string OUTER_COLOR_PROPERTY_NAME = "_OuterColor"; // Metadata: 0x02077210
		private static MaterialPropertyBlock s_materialPropertyBlock; // 0x00
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public Dictionary<string, RegionMap3DCfg> cfg { get => default; } // 0x0000000184D869C0-0x0000000184D869F0 
		private static MaterialPropertyBlock m_materialPropertyBlock { get => default; } // 0x000000018BC5A214-0x000000018BC5A2B8 
	
		// Constructors
		public RegionMapSetting() {} // 0x0000000184DBE6F0-0x0000000184DBE7D0
	
		// Methods
		protected override void OnDestroy() {} // 0x000000018BC59B14-0x000000018BC59CA0
		private void _InitUI() {} // 0x0000000184D8AC90-0x0000000184D8B3E0
		private void _InitPlayerIcon() {} // 0x0000000184D8B550-0x0000000184D8B8D0
		private void _InitTrackIcon() {} // 0x0000000184D89990-0x0000000184D8AC90
		private void _InitSelect() {} // 0x0000000184D87A10-0x0000000184D87E70
		private void _SetMapPos(RectTransform rect, Vector3 pos, BasicLoadConfigInfo uiLevelMapConfig) {} // 0x0000000184D8B3E0-0x0000000184D8B550
		private void _RefreshMaterials() {} // 0x0000000184A751E0-0x0000000184A753C0
		private void _ClearMaterials() {} // 0x000000018BC5A014-0x000000018BC5A214
		public void InitData(RegionMapShowType shotType, Transform center = null, Transform moveRoot = null, float watchRadius = 0f /* Metadata: 0x020771B5 */) {} // 0x0000000184D87E70-0x0000000184D89990
		public void MoveToPlayer(Transform center, Transform moveRoot) {} // 0x0000000184D867D0-0x0000000184D869C0
		public Transform GetNodeTransform(string levelId) => default; // 0x000000018BC59A58-0x000000018BC59B14
		public Vector3 GetNodeMoveTargetLocalPosition(string levelId, Camera uiCamera, Transform moveRoot) => default; // 0x000000018BC596FC-0x000000018BC59A58
		public RegionMap3DCfg GetCfg(string levelId) => default; // 0x000000018BC59674-0x000000018BC596FC
		public static bool IsCircleIntersectingRectangle(Vector2 circleCenter, float circleRadius, UnityEngine.Rect rectangle) => default; // 0x0000000184D869F0-0x0000000184D86AB0
		public void SetLoadedRegionTransform(Transform regionTransform) {} // 0x000000018BC59E8C-0x000000018BC59EF4
		public TweenerCore<Quaternion, Quaternion, NoOptions> StartRegionRectTransformMoveRotationTween(float tweenDuration, AnimationCurve tweenCurve) => default; // 0x000000018BC59EF4-0x000000018BC5A014
		public void SetControllerLevelSelectedState(string levelId, bool isSelected) {} // 0x000000018BC59CA0-0x000000018BC59E8C
		public void __iFixBaseProxy_OnDestroy() {} // 0x00000001880AA28C-0x00000001880AA294
	}

	[Serializable]
	public class UIFacMainRegionConfig // TypeDefIndex: 53028
	{
		// Fields
		public string levelId; // 0x10
		public int panelIndex; // 0x18
		public List<Sprite> levelSprites; // 0x20
		public List<Vector3> levelPositions; // 0x28
	
		// Constructors
		public UIFacMainRegionConfig() {} // 0x00000001859084C0-0x00000001859085E0
	}

	public class UIFacMainRegion : MonoBehaviour, IUIClearable // TypeDefIndex: 53029
	{
		// Fields
		private string m_levelId; // 0x18
		private int m_panelIndex; // 0x20
		private List<UIFacMainRegionConfig> _configList; // 0x28
		private RectTransform _rectTransform; // 0x30
		private UIImage _image; // 0x38
	
		// Constructors
		public UIFacMainRegion() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void _OnMainRegionLevelChanged(string levelId, int panelIndex) {} // 0x000000018BC5CA6C-0x000000018BC5CAF8
		private void _RefreshRegionState() {} // 0x00000001853F5260-0x00000001853F5CB0
		private void OnDestroy() {} // 0x00000001853F4E30-0x00000001853F4E70
		public void InitMainRegion(string levelId, int panelIndex) {} // 0x00000001853F5040-0x00000001853F5150
		public void ClearComponent() {} // 0x00000001853F5150-0x00000001853F5260
	}

	public class UILevelMapCrane : MonoBehaviour, IUIClearable // TypeDefIndex: 53031
	{
		// Fields
		private CombineKey m_eventKey; // 0x18
		private CachedPathAssetLoader m_assetLoader; // 0x20
		private const string CRANE_SPRITE_FOLDER = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/Map/Crane/"; // Metadata: 0x0207721C
		private const string CRANE_GAME_VAR_KEY = "lv003_crane_state"; // Metadata: 0x02077257
		private SerializeReferenceDictionary<long, CraneSpritePath> _stateSpriteDict; // 0x28
		private RectTransform _rectTransform; // 0x30
		private UIImage _image; // 0x38
	
		// Nested types
		[Serializable]
		public class CraneSpritePath // TypeDefIndex: 53030
		{
			// Fields
			public string stateSpritePath; // 0x10
	
			// Constructors
			public CraneSpritePath() {} // 0x000000018BC5CD24-0x000000018BC5CD80
		}
	
		// Constructors
		public UILevelMapCrane() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private void OnDestroy() {} // 0x000000018BC5CFE8-0x000000018BC5D26C
		private void _RefreshCraneState() {} // 0x000000018BC5CF20-0x000000018BC5CF88
		private void _ClearSpriteAsset() {} // 0x000000018BC5CF88-0x000000018BC5CFE8
		private void _OnCraneStateChanged(in EventData<long, long> eventData) {} // 0x000000018BC5CD80-0x000000018BC5CF20
		private void _BindAll() {} // 0x0000000185F4CDF0-0x0000000185F4CEC0
		private void _UnBindAll() {} // 0x000000018BC5CCC8-0x000000018BC5CD24
		public void InitCrane() {} // 0x0000000185F4CDB0-0x0000000185F4CDF0
		public void ClearComponent() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public class UILevelMapGameplayArea : MonoBehaviour, IUIClearable // TypeDefIndex: 53032
	{
		// Fields
		private bool m_initialized; // 0x18
		private RectTransform _rectTransform; // 0x20
		private RectTransform _circleRectTransform; // 0x28
	
		// Constructors
		public UILevelMapGameplayArea() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void _RefreshGameplayArea(GameplayAreaInstRuntimeData areaData) {} // 0x000000018BC5D2D0-0x000000018BC5D408
		public void Init(GameplayAreaInstRuntimeData areaData) {} // 0x000000018BC5D26C-0x000000018BC5D2D0
		public void ClearComponent() {} // 0x0000000185FAE600-0x0000000185FAE630
	}

	public class UILevelMapLimitInRect : TickableUIMono, IUIClearable // TypeDefIndex: 53034
	{
		// Fields
		private bool m_needLimitedInRect; // 0x68
		[NonSerialized]
		public Vector2 originalRectPosition; // 0x6C
		[NonSerialized]
		public Vector3 originalWorldPosition; // 0x74
		[NonSerialized]
		public bool isLimitedInRect; // 0x80
		public UnityEvent<bool> onIsLimitedInRectChanged; // 0x88
		private RectTransform _rectTransform; // 0x90
		private RectTransform _limitRectTransform; // 0x98
		private MaskShapeType _maskShapeType; // 0xA0
		private float _circleLimitRadius; // 0xA4
		private List<GameObject> _limitActiveNodes; // 0xA8
		private List<GameObject> _limitInactiveNodes; // 0xB0
		private List<RectTransform> _limitDirectionNodes; // 0xB8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
	
		// Nested types
		public enum MaskShapeType // TypeDefIndex: 53033
		{
			Rectangle = 0,
			Circle = 1
		}
	
		// Constructors
		public UILevelMapLimitInRect() {} // 0x0000000184814DE0-0x0000000184814DF0
	
		// Methods
		public override void LateTick(float deltaTime) {} // 0x00000001840F59C0-0x00000001840F5A10
		protected override void OnEnable() {} // 0x0000000185CA5B20-0x0000000185CA5B60
		protected override void OnRelease() {} // 0x0000000185D75110-0x0000000185D75150
		private void _LimitInRect() {} // 0x00000001840F6230-0x00000001840F72D0
		public void ClearComponent() {} // 0x0000000185D75150-0x0000000185D75190
		public void StartLimitMarkInRect() {} // 0x0000000185BA55B0-0x0000000185BA5640
		public void StopLimitMarkInRect() {} // 0x0000000185FA2CA0-0x0000000185FA2D00
		public void ForceRefreshLimitState() {} // 0x0000000185EDBE30-0x0000000185EDBE70
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018792FE0C-0x000000018792FE14
	}

	public class UILevelMapLine : TickableUIMono, IUIClearable // TypeDefIndex: 53035
	{
		// Fields
		private bool m_initialized; // 0x68
		private float m_basicWidth; // 0x6C
		private float m_basicHeight; // 0x70
		private float m_extraScale; // 0x74
		public RectTransform rectTransform; // 0x78
		public RectTransform referenceTransform; // 0x80
		public bool onlyHoldOnEnable; // 0x88
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
	
		// Constructors
		public UILevelMapLine() {} // 0x0000000184814DF0-0x0000000184814E00
	
		// Methods
		protected override void OnEnable() {} // 0x00000001855B3E90-0x00000001855B3ED0
		private void _HoldLineSize() {} // 0x00000001844C37F0-0x00000001844C3B10
		public override void LateTick(float deltaTime) {} // 0x00000001844C3680-0x00000001844C3740
		public void Init(float basicLength) {} // 0x0000000185350B40-0x0000000185350CB0
		public void ClearComponent() {} // 0x00000001849D60A0-0x00000001849D60D0
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
	}

	public class UILevelMapMissionArea : TickableUIMono, IUIClearable // TypeDefIndex: 53037
	{
		// Fields
		private GameObject m_associatedTrackingMark; // 0x68
		private bool m_initialized; // 0x70
		private readonly Vector3[] m_disappearWorldCorners; // 0x78
		private readonly Vector3[] m_circleWorldCorners; // 0x80
		private float m_missionGuideArea; // 0x88
		public bool needUseCenterPosition; // 0x8C
		private LuaPanel _luaPanel; // 0x90
		private RectTransform _rectTransform; // 0x98
		private RectTransform _circleRectTransform; // 0xA0
		private CanvasGroup _canvasGroup; // 0xA8
		private bool _coexistWithMissionTrack; // 0xB0
		private float _notCoexistGuideAreaRadius; // 0xB4
		private RectTransform _disappearRect; // 0xB8
		private DisappearRectShapeType _disappearRectShape; // 0xC0
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
		public bool needCheckMissionTrackCoexist { get => default; } // 0x0000000184233F70-0x0000000184233F90 
		public bool coexistWithMissionTrack { get => default; } // 0x0000000181B10450-0x0000000181B10460 
		public bool notNeedCheckCoexistBecauseOfRadius { get => default; } // 0x0000000184233F90-0x0000000184233FB0 
	
		// Nested types
		public enum DisappearRectShapeType // TypeDefIndex: 53036
		{
			Rectangle = 0,
			Circle = 1
		}
	
		// Constructors
		public UILevelMapMissionArea() {} // 0x0000000185C2CCA0-0x0000000185C2CD20
	
		// Methods
		public override void LateTick(float deltaTime) {} // 0x0000000184233E70-0x0000000184233EB0
		private void _RefreshMissionArea(MissionTrackingMarkInstRuntimeDate missionMarkInstRuntimeData) {} // 0x00000001845E40F0-0x00000001845E4210
		private bool _IsCircleOutsideDisappearRect() => default; // 0x0000000184234140-0x00000001842344F0
		private void _DisappearIfOutRect() {} // 0x0000000184233EB0-0x0000000184233F70
		public void Init(MissionTrackingMarkInstRuntimeDate missionMarkInstRuntimeData, GameObject associatedTrackingMark) {} // 0x00000001845E4270-0x00000001845E4330
		public void ClearComponent() {} // 0x0000000185F39B10-0x0000000185F39B50
		public void ForceRefreshDisappearIfOutRect() {} // 0x0000000185F5F9C0-0x0000000185F5FA00
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
	}

	public class UILevelMapMisty : MonoBehaviour, IUIClearable // TypeDefIndex: 53038
	{
		// Fields
		private CombineKey m_eventKey; // 0x18
		private bool m_needBind; // 0x1C
		private const long INVISIBLE_STATE_VALUE = 1; // Metadata: 0x0207726D
		private const string MISTY_GAME_VAR_KEY = "huanzhuline_game_finish"; // Metadata: 0x02077275
	
		// Constructors
		public UILevelMapMisty() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void OnDestroy() {} // 0x000000018BC5D524-0x000000018BC5D574
		private void _RefreshMistyState() {} // 0x000000018BC5D784-0x000000018BC5D800
		private void _OnMistyStateChanged(in EventData<long, long> eventData) {} // 0x000000018BC5D714-0x000000018BC5D784
		private void _BindAll() {} // 0x000000018BC5D574-0x000000018BC5D714
		private void _UnBindAll() {} // 0x000000018BC5D800-0x000000018BC5D8E4
		public void InitMisty() {} // 0x000000018BC5D408-0x000000018BC5D46C
		public static bool IsMistyVisible() => default; // 0x000000018BC5D46C-0x000000018BC5D524
		public void ClearComponent() {} // 0x0000000185FAE5D0-0x0000000185FAE600
	}

	public class UILevelMapSwitchBtn : MonoBehaviour, IUIClearable // TypeDefIndex: 53040
	{
		// Fields
		private UIButton _button; // 0x18
		private UIText _text; // 0x20
		private GameObject _mainContent; // 0x28
		private RectTransform _direction; // 0x30
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 53039
		{
			// Fields
			public string targetLevelId; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x000000018494C790-0x000000018494CBE0
	
			// Methods
			internal void _InitSwitchButton_b__0(PointerEventData eventData) {} // 0x00000001859F0F60-0x00000001859F1020
		}
	
		// Constructors
		public UILevelMapSwitchBtn() {} // 0x000000018BC5A35C-0x000000018BC5A3E8
	
		// Methods
		public void InitSwitchButton(string targetLevelId, float directionAngle) {} // 0x000000018646DB20-0x000000018646DB28
		public void ClearComponent() {} // 0x0000000185492010-0x0000000185492020
	}

	public class UILevelMapTouchPanelWrapper : TickableUIMono // TypeDefIndex: 53041
	{
		// Fields
		private UITouchPanel _touchPanel; // 0x68
		private float _scrollCorrectionCoefficient; // 0x70
		private Transform _raycastRoot; // 0x78
		private int m_lastTouchCount; // 0x80
		private PointerEventData m_dragPointerEventData; // 0x88
		private PointerEventData m_scrollPointerEventData; // 0x90
		private bool m_inWrapperDragging; // 0x98
		private Vector2 m_lastPointerPos; // 0x9C
		private readonly List<RaycastResult> m_raycastResults; // 0xA8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Constructors
		public UILevelMapTouchPanelWrapper() {} // 0x000000018BC5E2AC-0x000000018BC5E334
	
		// Methods
		protected override void OnAwake() {} // 0x000000018BC5D8E4-0x000000018BC5DA3C
		public override void Tick(float deltaTime) {} // 0x000000018BC5DA3C-0x000000018BC5DB48
		private bool _IsFirstRaycastSelectable(PointerEventData pointerEventData) => default; // 0x000000018BC5E038-0x000000018BC5E2AC
		private void _CheckDrag() {} // 0x000000018BC5DB48-0x000000018BC5DE90
		private void _CheckScroll() {} // 0x000000018BC5DE90-0x000000018BC5E038
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
	}

	public class UIRegionMap3DPanel : UIPanelBase // TypeDefIndex: 53042
	{
		// Fields
		public const string HOVER_ANIM_NAME = "regionmap3d_map_hover"; // Metadata: 0x0207728D
		private LuaPanel _luaPanel; // 0x70
		private UIAnimationWrapper _panelAnimationWrapper; // 0x78
		private Transform _zoomRoot; // 0x80
		private Transform _moveRoot; // 0x88
		private float _moveDuration; // 0x90
		private float _completeRatio; // 0x94
		private AnimationCurve _moveCurve; // 0x98
		private AnimationCurve _rotationCurve; // 0xA0
		private float _zoomDistance; // 0xA8
		private AnimationCurve _zoomCurve; // 0xB0
		private RegionMapSetting m_regionMapSetting; // 0xB8
		private string m_toLevel; // 0xC0
		private string m_toInsId; // 0xC8
		private TweenerCore<Vector3, Vector3, VectorOptions> m_moveTween; // 0xD0
		private TweenerCore<Quaternion, Quaternion, NoOptions> m_rotateTween; // 0xD8
		private TweenerCore<Vector3, Vector3, VectorOptions> m_zoomTween; // 0xE0
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Constructors
		public UIRegionMap3DPanel() {} // 0x000000018BC6076C-0x000000018BC60788
	
		// Methods
		private Transform _GetNodeTransform(string levelId) => default; // 0x000000018BC60580-0x000000018BC605EC
		private Vector3 _GetMoveTargetLocalPosition(string levelId) => default; // 0x000000018BC604CC-0x000000018BC60580
		private void _OnDoMoveTween() {} // 0x000000018BC605EC-0x000000018BC6076C
		public void InitPanel(RegionMapSetting regionMapSetting) {} // 0x000000018BC5FEE8-0x000000018BC60000
		public void OnClickLevelBtn(string levelId, string insId) {} // 0x000000018BC60000-0x000000018BC60348
		public void OnLevelHoverChanged(string levelId, bool isHover) {} // 0x000000018BC60348-0x000000018BC604CC
	}

	public class UIRegionMap3DUICell : UIPanelBase // TypeDefIndex: 53043
	{
		// Fields
		public UIText showName; // 0x70
		public RectTransform iconRoot; // 0x78
		public UIButton btn; // 0x80
	
		// Constructors
		public UIRegionMap3DUICell() {} // 0x0000000185FA8070-0x0000000185FA8080
	}

	public class UIRegionMapTrackIcon : UIPanelBase // TypeDefIndex: 53044
	{
		// Fields
		private UIImage _icon; // 0x70
		private UIImage _track; // 0x78
	
		// Constructors
		public UIRegionMapTrackIcon() {} // 0x0000000185FA8070-0x0000000185FA8080
	
		// Methods
		public void InitData(MissionTrackingMarkInstRuntimeDate data) {} // 0x0000000184D8B8D0-0x0000000184D8BA50
	}

	public class UISettlementRegion : MonoBehaviour, IUIClearable // TypeDefIndex: 53047
	{
		// Fields
		private string m_settlementId; // 0x18
		private SettlementRegionSpriteData m_settlementSpriteData; // 0x20
		private bool m_needBind; // 0x28
		private CombineKey m_bindKey; // 0x2C
		private SerializeFieldDictionary<string, SettlementRegionSpriteData> _spriteDict; // 0x30
		private RectTransform _rectTransform; // 0x38
		private UIImage _image; // 0x40
		public const string SETTLEMENT_REGION_SPRITE_FOLDER = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/Map/SettlementRegion/"; // Metadata: 0x020772A4
	
		// Nested types
		[Serializable]
		public class SettlementRegionSpritePath // TypeDefIndex: 53045
		{
			// Fields
			public string path; // 0x10
	
			// Constructors
			public SettlementRegionSpritePath() {} // 0x0000000185C550B0-0x0000000185C550F0
		}
	
		[Serializable]
		public class SettlementRegionSpriteData // TypeDefIndex: 53046
		{
			// Fields
			public SerializeFieldDictionary<int, SettlementRegionSpritePath> spriteWithTier; // 0x10
	
			// Constructors
			public SettlementRegionSpriteData() {} // 0x0000000185AEEDB0-0x0000000185AEEEB0
		}
	
		// Constructors
		public UISettlementRegion() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private void OnDestroy() {} // 0x0000000185AEEC90-0x0000000185AEEDB0
		private void _RefreshSpriteWithTier(int tier = 0 /* Metadata: 0x020772A3 */) {} // 0x000000018BC608E8-0x000000018BC60958
		private void _RefreshSettlementRegionState() {} // 0x000000018BC607EC-0x000000018BC608E8
		private void _OnSettlementUnlocked(in EventData<string> param) {} // 0x000000018BC60958-0x000000018BC60A4C
		private void _BindAll() {} // 0x0000000185AEEC30-0x0000000185AEEC90
		private void _UnBindAll() {} // 0x0000000185D2A100-0x0000000185D2A170
		public void InitSettlementRegion(string settlementId, Vector3 centerPos) {} // 0x000000018BC60788-0x000000018BC607EC
		public bool GetNeedRefreshSettlementRegionTier() => default; // 0x0000000185C550F0-0x0000000185C55190
		public void RefreshSettlementRegionWithTier(int tier) {} // 0x000000018646DB20-0x000000018646DB28
		public void ClearComponent() {} // 0x0000000185492010-0x0000000185492020
	}

	public class ChessboardDrop : UIBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler, IUIClearable // TypeDefIndex: 53048
	{
		// Fields
		[NonSerialized]
		public UnityEvent<PointerEventData> onDropEvent; // 0x18
		[NonSerialized]
		public UnityEvent<PointerEventData> onPointerEnterEvent; // 0x20
		[NonSerialized]
		public UnityEvent<PointerEventData> onPointerExitEvent; // 0x28
	
		// Constructors
		public ChessboardDrop() {} // 0x000000018BC54E64-0x000000018BC54F48
	
		// Methods
		public void OnDrop(PointerEventData eventData) {} // 0x000000018BC54BB0-0x000000018BC54C4C
		public void OnPointerEnter(PointerEventData eventData) {} // 0x000000018BC54C4C-0x000000018BC54CE8
		public void OnPointerExit(PointerEventData eventData) {} // 0x000000018BC54CE8-0x000000018BC54D84
		private bool _CheckEventValid(PointerEventData eventData) => default; // 0x000000018BC54D84-0x000000018BC54E64
		public void ClearComponent() {} // 0x000000018BC54AE8-0x000000018BC54B60
		protected override void OnDestroy() {} // 0x000000018BC54B60-0x000000018BC54BB0
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000185492010-0x0000000185492020
	}

	public class PuzzleCellDrag : UIBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 53049
	{
		// Fields
		private PuzzleDrag m_parent; // 0x18
		private bool _needHovering; // 0x20
	
		// Constructors
		public PuzzleCellDrag() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void Init(PuzzleDrag puzzleDrag) {} // 0x000000018BC5843C-0x000000018BC584A0
		public void OnBeginDrag(PointerEventData eventData) {} // 0x000000018BC584A0-0x000000018BC5850C
		public void OnDrag(PointerEventData eventData) {} // 0x000000018BC5850C-0x000000018BC58578
		public void OnEndDrag(PointerEventData eventData) {} // 0x000000018BC58578-0x000000018BC585E4
		public void OnPointerDown(PointerEventData eventData) {} // 0x000000018BC58650-0x000000018BC586BC
		public void OnPointerUp(PointerEventData eventData) {} // 0x000000018BC5879C-0x000000018BC58808
		public void OnPointerClick(PointerEventData eventData) {} // 0x000000018BC585E4-0x000000018BC58650
		public void OnPointerEnter(PointerEventData eventData) {} // 0x000000018BC586BC-0x000000018BC5872C
		public void OnPointerExit(PointerEventData eventData) {} // 0x000000018BC5872C-0x000000018BC5879C
	}

	public class PuzzleControllerHelper : UIBehaviour // TypeDefIndex: 53050
	{
		// Fields
		private LuaPanel m_luaPanel; // 0x18
		private PointerEventData m_controllerFocusEventData; // 0x20
		private readonly List<RaycastResult> m_raycastResults; // 0x28
	
		// Properties
		public List<RaycastResult> raycastResults { get => default; } // 0x000000018BC58CE0-0x000000018BC58D30 
	
		// Constructors
		public PuzzleControllerHelper() {} // 0x000000018BC58C60-0x000000018BC58CE0
	
		// Methods
		protected override void Awake() {} // 0x000000018BC58808-0x000000018BC588F8
		public int TryGetPuzzleSlotIndexByPos(RectTransform gridCell) => default; // 0x000000018BC588F8-0x000000018BC58C60
		public void __iFixBaseProxy_Awake() {} // 0x0000000185492010-0x0000000185492020
	}

	public class PuzzleDrag : UIBehaviour, IUIClearable, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 53051
	{
		// Fields
		private CanvasGroup m_canvasGroup; // 0x18
		private LuaPanel m_panel; // 0x20
		private int m_luaIndex; // 0x28
		[NonSerialized]
		public UnityEvent<PointerEventData> onBeginDragEvent; // 0x30
		[NonSerialized]
		public UnityEvent<PointerEventData> onDragEvent; // 0x38
		[NonSerialized]
		public UnityEvent<PointerEventData> onEndDragEvent; // 0x40
		[NonSerialized]
		public UnityEvent<PointerEventData> onPointerDownEvent; // 0x48
		[NonSerialized]
		public UnityEvent<PointerEventData> onPointerUpEvent; // 0x50
		[NonSerialized]
		public UnityEvent<PointerEventData> onPointerClickEvent; // 0x58
		[NonSerialized]
		public UnityEvent<PointerEventData> onPointerEnterEvent; // 0x60
		[NonSerialized]
		public UnityEvent<PointerEventData> onPointerExitEvent; // 0x68
	
		// Properties
		public LuaPanel panel { get => default; } // 0x000000018BC595BC-0x000000018BC59674 
		public int luaIndex { get => default; } // 0x0000000181C9AC80-0x0000000181C9AC90 
	
		// Constructors
		public PuzzleDrag() {} // 0x000000018BC593D4-0x000000018BC595BC
	
		// Methods
		protected override void Awake() {} // 0x000000018BC58D30-0x000000018BC58DB0
		public void OnBeginDrag(PointerEventData eventData) {} // 0x000000018BC58E80-0x000000018BC58F2C
		public void OnDrag(PointerEventData eventData) {} // 0x000000018BC58F7C-0x000000018BC59014
		public void OnEndDrag(PointerEventData eventData) {} // 0x000000018BC59014-0x000000018BC590C0
		public void OnPointerDown(PointerEventData eventData) {} // 0x000000018BC5914C-0x000000018BC591D8
		public void OnPointerUp(PointerEventData eventData) {} // 0x000000018BC592F0-0x000000018BC5937C
		public void OnPointerClick(PointerEventData eventData) {} // 0x000000018BC590C0-0x000000018BC5914C
		public void OnPointerEnter(PointerEventData eventData) {} // 0x000000018BC591D8-0x000000018BC59264
		public void OnPointerExit(PointerEventData eventData) {} // 0x000000018BC59264-0x000000018BC592F0
		public void ClearComponent() {} // 0x000000018BC58DB0-0x000000018BC58E80
		protected override void OnDestroy() {} // 0x000000018BC58F2C-0x000000018BC58F7C
		public void SetIndex(int index) {} // 0x000000018BC5937C-0x000000018BC593D4
		public void __iFixBaseProxy_Awake() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000185492010-0x0000000185492020
	}

	public class UIBrokenLine : MonoBehaviour // TypeDefIndex: 53052
	{
		// Fields
		private Material m_material; // 0x18
		private const int MAX_SET_VALUE_COUNT = 21; // Metadata: 0x020772ED
		private const string UI_BROKEN_LINE_SHADER_NAME = "HGRP/UI/BrokenLine"; // Metadata: 0x020772EE
		private const string Y_VALUE_PROPERTY_NAME_FORMAT = "_YValue{0}"; // Metadata: 0x02077301
		private const string X_SCALE_PROPERTY_NAME = "_XScale"; // Metadata: 0x0207730C
		private const string LINE_WEIGHT_PROPERTY_NAME = "_LineWidth"; // Metadata: 0x02077314
		private List<float> m_tmpList; // 0x20
		private bool m_isInit; // 0x28
		private float _lineWeight; // 0x2C
	
		// Constructors
		public UIBrokenLine() {} // 0x000000018BC5AAA0-0x000000018BC5AB28
	
		// Methods
		private void Awake() {} // 0x000000018BC5A3E8-0x000000018BC5A440
		private void _Init() {} // 0x000000018BC5A8A4-0x000000018BC5AAA0
		private void OnDestroy() {} // 0x000000018BC5A440-0x000000018BC5A4C0
		public void SetYValueByArray(float[] yValue, int count = 21 /* Metadata: 0x020772EB */) {} // 0x000000018BC5A4C0-0x000000018BC5A5B8
		public void SetYValue(List<float> yValue, int count = 21 /* Metadata: 0x020772EC */) {} // 0x000000018BC5A5B8-0x000000018BC5A8A4
	}

	public class UICommonScanController : TickableUIMono // TypeDefIndex: 53053
	{
		// Fields
		private ulong _entityLogicId_k__BackingField; // 0x68
		protected Transform m_camera; // 0x70
		protected ObjectPtr<Entity> m_entity; // 0x78
		protected Transform m_followTarget; // 0x88
		public float yOffset; // 0x90
		public static readonly int STATE_ON; // 0x00
		public static readonly int STATE_OFF; // 0x04
		public const int MAX_HP_RATIO = 10000; // Metadata: 0x0207731F
		public const float TICK_REFRESH_NEED = 0.1f; // Metadata: 0x02077323
		public const int DONT_REFRESH = 0; // Metadata: 0x02077327
		private bool m_uiActive; // 0x94
		protected long m_nextRefreshTime; // 0x98
		protected float m_hpRatio; // 0xA0
		protected Vector3 m_fixedPoint; // 0xA4
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
		public ulong entityLogicId { get; set; } // 0x00000001813AC280-0x00000001813AC290 0x0000000185FB07B0-0x0000000185FB07C0
		protected bool uiActive { get => default; set {} } // 0x0000000185FCD9D0-0x0000000185FCD9E0 0x000000018BC5B370-0x000000018BC5B3E4
	
		// Constructors
		public UICommonScanController() {} // 0x0000000184814DE0-0x0000000184814DF0
		static UICommonScanController() {} // 0x000000018BC5B320-0x000000018BC5B370
	
		// Methods
		public virtual void SetTarget(Entity target, long nextRefresh, float hpRatio) {} // 0x000000018BC5ADF8-0x000000018BC5AF54
		private void _UpdatePos() {} // 0x000000018BC5B180-0x000000018BC5B320
		public void SetFixPoint(Vector3 pos, ulong waterVolume) {} // 0x000000018BC5AC18-0x000000018BC5ADF8
		public override void Tick(float deltaTime) {} // 0x000000018BC5AF54-0x000000018BC5AFD4
		private void _FaceToCamera() {} // 0x000000018BC5AFD4-0x000000018BC5B180
		public virtual void Clear() {} // 0x000000018BC5AB28-0x000000018BC5AC18
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
	}

	public class UICountDownBar : TickableUIMono // TypeDefIndex: 53054
	{
		// Fields
		private UIText _countDownTxt; // 0x68
		private float m_countDownTime; // 0x70
		private int m_id; // 0x74
		private Transform m_target; // 0x78
		private CountDownShowAction.Data m_data; // 0x80
		private Transform m_camera; // 0x88
		private bool m_update; // 0x90
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
		private bool update { get => default; set {} } // 0x0000000185FB2250-0x0000000185FB2260 0x000000018BC5B940-0x000000018BC5B9B4
	
		// Constructors
		public UICountDownBar() {} // 0x0000000184814DE0-0x0000000184814DF0
	
		// Methods
		public void InitData(int id, AbilitySystem target, CountDownShowAction.Data data) {} // 0x000000018BC5B474-0x000000018BC5B5C4
		public void Clear() {} // 0x000000018BC5B3E4-0x000000018BC5B474
		public override void LateTick(float deltaTime) {} // 0x000000018BC5B5C4-0x000000018BC5B648
		private void _UpdateData(float deltaTime) {} // 0x000000018BC5B648-0x000000018BC5B704
		private void _UpdatePos() {} // 0x000000018BC5B704-0x000000018BC5B940
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
	}

	public class UIDoodadMineCoreScanController : UICommonScanController // TypeDefIndex: 53055
	{
		// Fields
		public GameObject canMineIcon; // 0xB0
		public UIText formingText; // 0xB8
		public UIText purityText; // 0xC0
	
		// Constructors
		public UIDoodadMineCoreScanController() {} // 0x000000018BC5BB90-0x000000018BC5BBDC
	
		// Methods
		public void SyncConditonInfo(bool forming, string condition) {} // 0x000000018BC5BA98-0x000000018BC5BB14
		public void SetPurity(bool forming, string conditionText) {} // 0x000000018BC5B9B4-0x000000018BC5BA98
		public void UpdateUI(bool forming, string condition) {} // 0x000000018BC5BB14-0x000000018BC5BB90
	}

	public class UIDoodadPlantCoreScanController : UICommonScanController // TypeDefIndex: 53056
	{
		// Fields
		private const uint OFF = 0; // Metadata: 0x02077330
		private const uint DARK = 1; // Metadata: 0x02077331
		private const uint LIGHT = 2; // Metadata: 0x02077332
		private const uint GROW = 4; // Metadata: 0x02077333
		public UIText coreNameText; // 0xB0
		public UIText coreSizeText; // 0xB8
		public GameObject refreshTimeRoot; // 0xC0
		public UIText refreshTimeText; // 0xC8
		public List<GameObject> flowerDark; // 0xD0
		public List<GameObject> flowerLight; // 0xD8
		public List<GameObject> flowerGrow; // 0xE0
		private float m_tickTimeSum; // 0xE8
	
		// Constructors
		public UIDoodadPlantCoreScanController() {} // 0x000000018BC5C2EC-0x000000018BC5C3FC
	
		// Methods
		public override void Tick(float deltaTime) {} // 0x000000018BC5BFA0-0x000000018BC5C064
		public void SetCoreInfo(string coreName, string coreSize) {} // 0x000000018BC5BC2C-0x000000018BC5BCC8
		public void SetRefreshInfo(long nextRefreshTime = 0 /* Metadata: 0x02077328 */) {} // 0x000000018BC5BE28-0x000000018BC5BE98
		public void RefreshTextNow() {} // 0x000000018BC5BBDC-0x000000018BC5BC2C
		public void SetQuantityInfo(int current, int nextRefresh, int maxCount) {} // 0x000000018BC5BCC8-0x000000018BC5BE28
		public void SetSingle(int index, uint state) {} // 0x000000018BC5BE98-0x000000018BC5BFA0
		private void _SyncTimeText() {} // 0x000000018BC5C06C-0x000000018BC5C2EC
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018BC5C064-0x000000018BC5C06C
	}

	public class UIDoodadScanController : UICommonScanController // TypeDefIndex: 53057
	{
		// Fields
		public UIText timeCom; // 0xB0
		public Transform refreshFull; // 0xB8
		public Transform refreshProgress; // 0xC0
		private float m_tickTimeSum; // 0xC8
	
		// Constructors
		public UIDoodadScanController() {} // 0x000000018BC5CA18-0x000000018BC5CA6C
	
		// Methods
		public void SyncRefreshInfo(long nextRefresh, float hpRatio) {} // 0x000000018BC5C3FC-0x000000018BC5C50C
		public override void Tick(float deltaTime) {} // 0x000000018BC5C50C-0x000000018BC5C5D0
		private void _RefreshCountDown() {} // 0x000000018BC5C680-0x000000018BC5CA18
		public void UpdateUI(long nextRefresh, float hpRatio) {} // 0x000000018BC5C5D0-0x000000018BC5C680
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018BC5C064-0x000000018BC5C06C
	}

	public class UIGeneralTracker : MonoBehaviour // TypeDefIndex: 53058
	{
		// Fields
		private Transform _arrowRotator; // 0x18
		private RectTransform m_rect; // 0x20
	
		// Properties
		private RectTransform rect { get => default; } // 0x000000018BC5CBF4-0x000000018BC5CCC8 
	
		// Constructors
		public UIGeneralTracker() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void UpdatePosition(Vector2 uiPos, float uiAngle, bool isOutBound) {} // 0x000000018BC5CAF8-0x000000018BC5CBF4
	}

	public class UILiquidPoolScanController : UICommonScanController // TypeDefIndex: 53059
	{
		// Fields
		public GameObject unLimitGroup; // 0xB0
		public GameObject limitedGroup; // 0xB8
		public UIText currentAmountText; // 0xC0
		public UIText maxAmountText; // 0xC8
		public UIText waterNameText; // 0xD0
		private const string EMPTY_LIQUID = "ui_liquid_pool_scan_text_empty"; // Metadata: 0x02077334
		private LangKey m_key; // 0xD8
	
		// Constructors
		public UILiquidPoolScanController() {} // 0x000000018BC5E894-0x000000018BC5E918
	
		// Methods
		public void SetWaterInfo(ulong waterId, int x, int y, int z) {} // 0x000000018BC5E334-0x000000018BC5E894
	}

	public class UIPanelBase : TickableUIMono // TypeDefIndex: 53060
	{
		// Fields
		public const string UI_SPRITE_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/{0}.png"; // Metadata: 0x02077353
		private LuaResourceLoader m_loader; // 0x68
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Constructors
		public UIPanelBase() {} // 0x0000000184814D50-0x0000000184814DC0
	
		// Methods
		protected override void OnRelease() {} // 0x000000018BC5E918-0x000000018BC5E97C
		public Sprite LoadSprite(string path, string name) => default; // 0x00000001850AF910-0x00000001850AF9A0
		public Sprite LoadSpriteWithOutFormat(string path) => default; // 0x0000000185912E00-0x0000000185912F50
		public GameObject LoadGameObject(string path) => default; // 0x00000001845A7FB0-0x00000001845A8020
		protected string GetSpritePath(string path, string name) => default; // 0x00000001850AFA10-0x00000001850AFAB0
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018792FE0C-0x000000018792FE14
	}

	public class UIPowerPoleAutoConnectTracker : UIGeneralTracker // TypeDefIndex: 53063
	{
		// Fields
		private GameObject _rootDistance; // 0x28
		private UIText _textDistance; // 0x30
		private UnityEngine.Color _textColorNormal; // 0x38
		private UnityEngine.Color _textColorDisable; // 0x48
		private UnityEngine.Color _textColorError; // 0x58
		private CanvasGroup _colorScaleControlGroup; // 0x68
		private float _activeScale; // 0x70
		private IconGroup _defaultIcon; // 0x78
		private IconGroup _diffuserIcon; // 0x80
		private IconGroup _hubIcon; // 0x88
		private IconGroup _subhubIcon; // 0x90
		private IconGroup _terminalIcon; // 0x98
		private IconGroup _stationIcon; // 0xA0
		private StatusHintGroup _statusHintGroup; // 0xA8
		private PowerAutoConnectStatus? m_currentStatus; // 0xB0
	
		// Nested types
		[Serializable]
		public class IconGroup // TypeDefIndex: 53061
		{
			// Fields
			public GameObject root; // 0x10
			public Image normal; // 0x18
			public Image error; // 0x20
	
			// Properties
			public bool activeSelf { get => default; } // 0x000000018BC5EB0C-0x000000018BC5EBB4 
	
			// Constructors
			public IconGroup() {} // 0x000000018BC5EBB4-0x000000018BC5ECB0
	
			// Methods
			public void SetActiveIfNecessary(bool active) {} // 0x000000018BC5E97C-0x000000018BC5EA48
			public void Switch(bool err) {} // 0x000000018BC5ECB0-0x000000018BC5EF08
		}
	
		[Serializable]
		public class StatusHintGroup // TypeDefIndex: 53062
		{
			// Fields
			public GameObject root; // 0x10
			public GameObject localLinkHint; // 0x18
			public GameObject globalLinkHint; // 0x20
			public GameObject outageHint; // 0x28
			public GameObject distLimitHint; // 0x30
	
			// Constructors
			public StatusHintGroup() {} // 0x000000018BC5EF08-0x000000018BC5EF64
	
			// Methods
			public void Switch(PowerAutoConnectStatus status) {} // 0x000000018BC5EA48-0x000000018BC5EB0C
		}
	
		// Constructors
		public UIPowerPoleAutoConnectTracker() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void UpdateDistance(float distance) {} // 0x000000018BC5832C-0x000000018BC5838C
		private void _ActualUpdateStatus(PowerAutoConnectStatus status) {} // 0x000000018BC5838C-0x000000018BC5841C
		public void UpdateStatus(PowerAutoConnectStatus status) {} // 0x000000018BC5841C-0x000000018BC5843C
		private void _ActualUpdateIcon(IconGroup img) {} // 0x0000000185492010-0x0000000185492020
		public void UpdateNodeType(int nodeType) {} // 0x000000018BC5A2B8-0x000000018BC5A35C
	}

	public class UIPowerPoleFastTravelTracker : UIGeneralTracker // TypeDefIndex: 53065
	{
		// Fields
		private UIText _textDistance; // 0x28
		private UnityEngine.Color _textColorNormal; // 0x30
		private UnityEngine.Color _textColorWarning; // 0x40
		private UnityEngine.Color _textColorHighlighted; // 0x50
		private UnityEngine.Color _textColorDisabled; // 0x60
		private GameObject _parentNormal; // 0x70
		private UIAnimationWrapper _animationWrapperNormal; // 0x78
		private GameObject _imageNormal; // 0x80
		private GameObject _imageNormalOther; // 0x88
		private GameObject _imageWarning; // 0x90
		private GameObject _imageHighlighted; // 0x98
		private GameObject _imageHighlightedOther; // 0xA0
		private GameObject _imageDisabled; // 0xA8
		private GameObject _parentUpgraded; // 0xB0
		private UIAnimationWrapper _animationWrapperUpgraded; // 0xB8
		private GameObject _imageNormalUpgraded; // 0xC0
		private GameObject _imageNormalUpgradedOther; // 0xC8
		private GameObject _imageWarningUpgraded; // 0xD0
		private GameObject _imageHighlightedUpgraded; // 0xD8
		private GameObject _imageHighlightedUpgradedOther; // 0xE0
		private GameObject _imageDisabledUpgraded; // 0xE8
		private GameObject _parentDefaultNext; // 0xF0
		private UIAnimationWrapper _animationWrapperNext; // 0xF8
		private GameObject _imageNormalDefaultNext; // 0x100
		private GameObject _imageNormalDefaultNextOther; // 0x108
		private GameObject _imageWarningDefaultNext; // 0x110
		private GameObject _imageHighlightedDefaultNext; // 0x118
		private GameObject _imageHighlightedDefaultNextOther; // 0x120
		private GameObject _imageDisabledDefaultNext; // 0x128
		private GameObject _textInfoBg; // 0x130
		private SerializeFieldDictionary<TravelPoleBrain.TravelPoleStatus, TravelPoleStatusSetting> _statusSettingDict; // 0x138
		private TravelPoleBrain.TravelPoleIcon m_iconStatus; // 0x140
		private TravelPoleBrain.TravelPoleStatus m_status; // 0x144
		private bool m_isHighlighted; // 0x148
		private bool m_isOtherSocial; // 0x149
		private string m_distanceFormatText; // 0x150
	
		// Properties
		private bool isWarning { get => default; } // 0x000000018BC5FE18-0x000000018BC5FE30 
		private bool isDisabled { get => default; } // 0x000000018BC5FDA4-0x000000018BC5FE18 
		public bool allowToHighlight { get => default; } // 0x000000018BC5F9FC-0x000000018BC5FA28 
		private TravelPoleBrain.TravelPoleIcon iconStatus { get => default; set {} } // 0x0000000181E8C3C0-0x0000000181E8C3D0 0x000000018BC5FE30-0x000000018BC5FED0
		private TravelPoleBrain.TravelPoleStatus status { get => default; set {} } // 0x0000000185FD6F70-0x0000000185FD6F80 0x000000018BC5FED0-0x000000018BC5FEE8
		private UIAnimationWrapper animationWrapper { get => default; } // 0x000000018BC5FA28-0x000000018BC5FAA4 
		private GameObject imageNormal { get => default; } // 0x000000018BC5FCA4-0x000000018BC5FD24 
		private GameObject imageWarning { get => default; } // 0x000000018BC5FD24-0x000000018BC5FDA4 
		private GameObject imageDisabled { get => default; } // 0x000000018BC5FAA4-0x000000018BC5FB24 
		private GameObject imageHighlighted { get => default; } // 0x000000018BC5FBA4-0x000000018BC5FC24 
		private GameObject imageNormalOther { get => default; } // 0x000000018BC5FC24-0x000000018BC5FCA4 
		private GameObject imageHighlightedOther { get => default; } // 0x000000018BC5FB24-0x000000018BC5FBA4 
	
		// Nested types
		[Serializable]
		private struct TravelPoleStatusSetting // TypeDefIndex: 53064
		{
			// Fields
			public bool showTextInfoBg; // 0x00
			public GameObject textToShow; // 0x08
		}
	
		// Constructors
		public UIPowerPoleFastTravelTracker() {} // 0x000000018BC5F994-0x000000018BC5F9FC
	
		// Methods
		public void PlayFocus() {} // 0x000000018BC5EFC4-0x000000018BC5F02C
		public void UpdateIconStatus(TravelPoleBrain.TravelPoleIcon value) {} // 0x000000018BC5F140-0x000000018BC5F1A4
		public void UpdateStatus(TravelPoleBrain.TravelPoleStatus value) {} // 0x000000018BC5F26C-0x000000018BC5F2D0
		public void UpdateIsHighlighted(bool value) {} // 0x000000018BC5F1A4-0x000000018BC5F208
		public void UpdateIsOtherSocial(bool value) {} // 0x000000018BC5F208-0x000000018BC5F26C
		public void UpdateDistance(Vector3 value) {} // 0x000000018BC5F02C-0x000000018BC5F140
		private void _OnStatusChanged() {} // 0x000000018BC5F2D0-0x000000018BC5F558
		private void _UpdateIcon() {} // 0x000000018BC5F558-0x000000018BC5F994
		private void OnEnable() {} // 0x000000018BC5EF64-0x000000018BC5EFC4
	}

	public class UIRaceModuleRankController : TickableUIMono // TypeDefIndex: 53067
	{
		// Fields
		private readonly LuaResourceLoader m_loader; // 0x68
		public UIImage image; // 0x70
		public Transform greyNode; // 0x78
		public Transform lightNode; // 0x80
		public UIText text; // 0x88
		public const string FIRST_ICON = "icon_racemodule_rank_1.png"; // Metadata: 0x0207738C
		public const string SECOND_ICON = "icon_racemodule_rank_2.png"; // Metadata: 0x020773A7
		public const string THIRD_ICON = "icon_racemodule_rank_3.png"; // Metadata: 0x020773C2
		public const string FOURTH_ICON = "icon_racemodule_rank_4.png"; // Metadata: 0x020773DD
		public const string FIFTH_ICON = "icon_racemodule_rank_5.png"; // Metadata: 0x020773F8
		private Sprite m_sprite1; // 0x90
		private Sprite m_sprite2; // 0x98
		private Sprite m_sprite3; // 0xA0
		private Sprite m_sprite4; // 0xA8
		private Sprite m_sprite5; // 0xB0
		private ERank m_rankEnum; // 0xB8
		private float m_restTime; // 0xBC
		private bool m_begin; // 0xC0
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Nested types
		public enum ERank // TypeDefIndex: 53066
		{
			None = 0,
			First = 1,
			Second = 2,
			Third = 3,
			Fourth = 4,
			Fifth = 5
		}
	
		// Constructors
		public UIRaceModuleRankController() {} // 0x000000018BC62ADC-0x000000018BC62B4C
	
		// Methods
		private void _ResetData() {} // 0x000000018BC62824-0x000000018BC62884
		protected override void OnAwake() {} // 0x000000018BC6209C-0x000000018BC621D0
		protected override void OnRelease() {} // 0x000000018BC621D0-0x000000018BC62308
		private void _ShowBaseTrans(bool show = true /* Metadata: 0x0207738B */) {} // 0x000000018BC62884-0x000000018BC62940
		private void _LoadAllSprite() {} // 0x000000018BC625C4-0x000000018BC62824
		private void _UpdateRaceModuleRank(in EventData<int, float> rankData) {} // 0x000000018BC62940-0x000000018BC62ADC
		public override void Tick(float deltaTime) {} // 0x000000018BC62308-0x000000018BC625C4
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018792FE0C-0x000000018792FE14
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
	}

	public class UIVideoHelper : MonoBehaviour // TypeDefIndex: 53068
	{
		// Fields
		public CriManaMovieControllerForUI criMovieController; // 0x18
		public string videoPath; // 0x20
		public bool restartOnEnable; // 0x28
		private UIImage m_image; // 0x30
	
		// Constructors
		public UIVideoHelper() {} // 0x000000018BC62D78-0x000000018BC62DC4
	
		// Methods
		private void Reset() {} // 0x000000018BC62CF8-0x000000018BC62D78
		public void ResetVideo() {} // 0x000000018BC62C7C-0x000000018BC62CF8
		private void Awake() {} // 0x000000018BC62B4C-0x000000018BC62C14
		private void OnEnable() {} // 0x000000018BC62C14-0x000000018BC62C7C
	}

	public class UIWaterDroneBar : TickableUIMono // TypeDefIndex: 53069
	{
		// Fields
		public Beyond.Gameplay.MountPoint mountPoint; // 0x68
		public Transform waterDroneBarParent; // 0x70
		public Vector3 waterDroneBarLocalOffset; // 0x78
		public float smoothTime; // 0x84
		public UISlider slider; // 0x88
		private ObjectPtr<Entity> m_waterDronePtr; // 0x90
		private Transform _waterDroneTrans; // 0xA0
		private Vector3 m_smoothVelocity; // 0xA8
		public UIStateController waterStateController; // 0xB8
		public UIStateController iconStateController; // 0xC0
		private static readonly ProfilerMarker PROFILER_MARKER_UPDATE; // 0x00
		public const float SLIDER_MAX_VALUE = 0.8277f; // Metadata: 0x02077419
		public UIAnimationWrapper uiAnimationWrapper; // 0xC8
		private Animation _animation; // 0xD0
		private AnimationClip _switchStateClip; // 0xD8
		private AnimationClip _farLoopClip; // 0xE0
		private AnimationClip _emptyLoopClip; // 0xE8
		private string m_switchStateClipName; // 0xF0
		private string m_farLoopClipName; // 0xF8
		private string m_emptyLoopClipName; // 0x100
		private float _clampedYawAngle; // 0x108
		private float _clampedPitchAngle; // 0x10C
		private List<string> _hydrantTemplateIds; // 0x110
		private List<string> _tankTemplateIds; // 0x118
		private bool m_isInfinityLiquid; // 0x120
		private bool m_isBagEmpty; // 0x121
		private bool m_noRemainLiquid; // 0x122
		private bool m_isBagEmptyAndNoRemainLiquid; // 0x123
		private int m_stateChangeFrame; // 0x124
		private bool m_stateDirty; // 0x128
		private bool m_isPlayingFarLoop; // 0x129
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
	
		// Constructors
		public UIWaterDroneBar() {} // 0x0000000185F61AA0-0x0000000185F61AE0
		static UIWaterDroneBar() {} // 0x0000000185F657B0-0x0000000185F65810
	
		// Methods
		protected override void OnAwake() {} // 0x000000018BC63368-0x000000018BC638BC
		private void _OnWaterDroneInfinityLiquidChanged(in EventData<bool> data) {} // 0x000000018BC640C4-0x000000018BC64130
		private void _OnWaterDroneEmptyChanged(in EventData<bool> data) {} // 0x000000018BC63F40-0x000000018BC63FAC
		private void _OnWaterDroneInteractiveChanged(in EventData<string> data) {} // 0x000000018BC64130-0x000000018BC6419C
		private void _OnWaterDroneSourceTypeChanged(in EventData<WaterDroneSourceType> data) {} // 0x000000018BC64210-0x000000018BC6427C
		private void _OnWaterDroneRelaxChanged(in EventData<bool> data) {} // 0x000000018BC6419C-0x000000018BC64210
		private void _OnWaterDroneHydrantStateChanged(in EventData<CustomAbilityComponent.WaterDroneByHydrantState> data) {} // 0x000000018BC64060-0x000000018BC640C4
		private void _OnWaterDroneHydrantStateChanged(CustomAbilityComponent.WaterDroneByHydrantState state) {} // 0x000000018BC63FAC-0x000000018BC64060
		protected override void OnEnable() {} // 0x000000018BC638BC-0x000000018BC639FC
		protected override void OnRelease() {} // 0x000000018BC639FC-0x000000018BC63D68
		private void _OnWaterDroneChange(ObjectPtr<Entity> waterDronePtr) {} // 0x000000018BC63DF0-0x000000018BC63F40
		private void _ClearWaterDrone() {} // 0x000000018BC63D68-0x000000018BC63DF0
		public override void LateTick(float deltaTime) {} // 0x000000018BC62DC4-0x000000018BC63368
		private void _UpdateState() {} // 0x000000018BC643DC-0x000000018BC64700
		private void _SetIconStateController(string stateName) {} // 0x000000018BC6427C-0x000000018BC64328
		private void _UpdateSlider() {} // 0x000000018BC64328-0x000000018BC643DC
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018792FE0C-0x000000018792FE14
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
	}

	public class WaterDroneJoystickCtrl : MonoBehaviour // TypeDefIndex: 53070
	{
		// Fields
		private UIJoystick _joystick; // 0x18
		public float cameraInputScaleX; // 0x20
		public float cameraInputScaleY; // 0x24
	
		// Constructors
		public WaterDroneJoystickCtrl() {} // 0x0000000185FAE630-0x0000000185FAE650
	}

	public class WorldUIController : TickableMono // TypeDefIndex: 53071
	{
		// Fields
		private ulong _entityLogicId_k__BackingField; // 0x68
		protected Transform m_camera; // 0x70
		protected ObjectPtr<Entity> m_entity; // 0x78
		protected Vector3 m_parentPos; // 0x88
		protected InteractiveLogicController m_logicController; // 0x98
		protected GameObject m_postModel; // 0xA0
		protected InteractiveLogicBaseComponent m_logicBaseComponent; // 0xA8
		protected ulong m_id; // 0xB0
		protected int m_typeSegment; // 0xB8
		protected bool m_uiActive; // 0xBC
	
		// Properties
		public ulong entityLogicId { get; set; } // 0x00000001813AC280-0x00000001813AC290 0x0000000185FB07B0-0x0000000185FB07C0
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
		protected bool uiActive { get => default; set {} } // 0x0000000185FD6F30-0x0000000185FD6F40 0x000000018BC64B44-0x000000018BC64BB8
	
		// Constructors
		public WorldUIController() {} // 0x0000000184814DE0-0x0000000184814DF0
	
		// Methods
		public virtual void Init(Entity target, string path, ulong id, int typeSegment) {} // 0x000000018BC64758-0x000000018BC648B8
		public virtual void TryGetNeedComponent() {} // 0x000000018BC64A78-0x000000018BC64B44
		public virtual void SetPos() {} // 0x000000018BC64918-0x000000018BC6495C
		public virtual void SetUIForward() {} // 0x000000018BC6495C-0x000000018BC649A0
		public override void Tick(float deltaTime) {} // 0x000000018BC649F4-0x000000018BC64A78
		public virtual void TickUI(float deltaTime) {} // 0x000000018BC649A0-0x000000018BC649F4
		public virtual void Clear() {} // 0x000000018BC64700-0x000000018BC64758
		protected override void OnRelease() {} // 0x000000018BC648B8-0x000000018BC64918
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018792FE0C-0x000000018792FE14
	}
}

namespace Beyond.UI.Mission
{
	public class MissionHudBGSizeUpdater : TickableUIMono // TypeDefIndex: 53072
	{
		// Fields
		public RectTransform bgTransform; // 0x68
		public RectTransform objectiveList; // 0x70
		public RectTransform objectiveContent; // 0x78
		public RectTransform leftLayoutTransform; // 0x80
		public VerticalLayoutGroup leftNodeVerticalLayoutGroup; // 0x88
		public float bgSizeGetterDeltaY; // 0x90
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
	
		// Constructors
		public MissionHudBGSizeUpdater() {} // 0x0000000185FACD10-0x0000000185FACD30
	
		// Methods
		public override void LateTick(float deltaTime) {} // 0x00000001844309D0-0x0000000184430A10
		public void UpdateBgSize() {} // 0x00000001844311F0-0x00000001844312E0
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
	}
}

namespace HG.Rendering.Runtime
{
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 52885
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 53075
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F645C0-0x0000000185F64630
	
		// Methods
		public void __Gen_Wrap_0() {} // 0x0000000187350FD4-0x000000018735105C
		public void __Gen_Wrap_1(object P0, float P1) {} // 0x0000000187678884-0x0000000187678964
		public void __Gen_Wrap_2(object P0, object P1) {} // 0x00000001873527E8-0x00000001873528C4
		public void __Gen_Wrap_3(object P0) {} // 0x000000018646FFC0-0x0000000186470080
		public void __Gen_Wrap_4(object P0, in EventData<int, float, float> P1) {} // 0x000000018BC61BB4-0x000000018BC61CD0
		public DamageTextBase __Gen_Wrap_5(object P0, DamageTextType P1) => default; // 0x000000018BC61CD0-0x000000018BC61DC8
		public void __Gen_Wrap_6(object P0, object P1, int P2) {} // 0x0000000187352D84-0x0000000187352E68
		public void __Gen_Wrap_7(object P0, int P1) {} // 0x000000018769E90C-0x000000018769E9E8
		public void __Gen_Wrap_8(object P0, UnityEngine.Color P1) {} // 0x000000018BC61DC8-0x000000018BC61EC8
		public void __Gen_Wrap_9(object P0, object P1, object P2, Vector3? P3) {} // 0x000000018BC61EC8-0x000000018BC62008
		public void __Gen_Wrap_10(object P0, Vector2 P1) {} // 0x000000018BC60A4C-0x000000018BC60B54
		public Vector3 __Gen_Wrap_11(object P0) => default; // 0x000000018BC60B54-0x000000018BC60C68
		public void __Gen_Wrap_12(object P0, bool P1) {} // 0x0000000187678A10-0x0000000187678AEC
		public Vector2 __Gen_Wrap_13(object P0, float P1, float P2) => default; // 0x000000018BC60C68-0x000000018BC60D80
		public bool __Gen_Wrap_14(object P0, Vector3 P1) => default; // 0x000000018BC60D80-0x000000018BC60E98
		public void __Gen_Wrap_15(object P0, in EventData<AbilitySystem.Modifier> P1) {} // 0x000000018BC60E98-0x000000018BC61034
		public void __Gen_Wrap_16(object P0, EnergyShardType P1, bool P2) {} // 0x000000018A82F260-0x000000018A82F344
		public void __Gen_Wrap_17(object P0, in EventData<AbilitySystem, Vector3, Vector2, string, EnergyShardType> P1) {} // 0x000000018BC61034-0x000000018BC61158
		public void __Gen_Wrap_18(object P0, in EventData<AbilitySystem, Vector3, Vector2, string> P1) {} // 0x000000018BC61158-0x000000018BC6127C
		public void __Gen_Wrap_19(object P0, in EventData<AbilitySystem, AbilitySystemForEnemyPart, PhysicalInflictionType> P1) {} // 0x000000018BC6127C-0x000000018BC61398
		public void __Gen_Wrap_20(object P0, in EventData<bool> P1) {} // 0x000000018BC61398-0x000000018BC614AC
		public void __Gen_Wrap_21(object P0, in EventData<Vector3, string, UnityEngine.Color> P1) {} // 0x000000018BC614AC-0x000000018BC615D0
		public void __Gen_Wrap_22(object P0, in EventData<ulong, int> P1) {} // 0x000000018BC615D0-0x000000018BC616F4
		public void __Gen_Wrap_23(object P0, object P1, object P2) {} // 0x0000000187340E48-0x0000000187340F40
		public DamageTextBaseV2 __Gen_Wrap_24(object P0, DamageTextType P1, object P2) => default; // 0x000000018BC616F4-0x000000018BC61818
		public Vector2 __Gen_Wrap_25(object P0, float P1, float P2, bool P3, Vector3 P4) => default; // 0x000000018BC61818-0x000000018BC6197C
		public void __Gen_Wrap_26(object P0, Vector2 P1, float P2) {} // 0x000000018BC6197C-0x000000018BC61AAC
		public HeadBarCtrl.HeadBarType __Gen_Wrap_27(ObjectPtr<AbilitySystem> P0) => default; // 0x000000018BC61AAC-0x000000018BC61BB4
		public bool __Gen_Wrap_28(object P0, out Vector3 P1) {
			P1 = default;
			return default;
		} // 0x0000000183F5AD20-0x0000000183F5B680
		public void __Gen_Wrap_29(object P0, bool P1, bool P2) {} // 0x000000018203EF20-0x000000018203F220
		public void __Gen_Wrap_30(object P0, object P1, float P2) {} // 0x0000000183EA4210-0x0000000183EA45E0
		public void __Gen_Wrap_31(object P0, object P1, double P2) {} // 0x0000000183F5B680-0x0000000183F5BA50
		public void __Gen_Wrap_32(object P0, object P1, double P2, bool P3) {} // 0x0000000183F5BA50-0x0000000183F5BE50
		public void __Gen_Wrap_33(object P0, in AbilitySystem.Modifier P1) {} // 0x0000000183F5BE50-0x0000000183F5C5B0
		public void __Gen_Wrap_34(object P0, HeadBarCtrl.HeadBarRefreshReason P1) {} // 0x0000000181566ED0-0x00000001815671B0
		public void __Gen_Wrap_35(object P0, in EventData<string, Entity> P1) {} // 0x0000000183F5C5B0-0x0000000183F5CC30
		public void __Gen_Wrap_36(object P0, in EventData<bool, DialogEnums.DialogType> P1) {} // 0x0000000183F5CC30-0x0000000183F5D2B0
		public void __Gen_Wrap_37(object P0, in EventData<AbilitySystem> P1) {} // 0x0000000183F5D2B0-0x0000000183F5D930
		public void __Gen_Wrap_38(object P0, in EventData<AbilitySystem, bool> P1) {} // 0x0000000183F5D930-0x0000000183F5DFD0
		public void __Gen_Wrap_39(object P0, in EventData<AbilitySystemForEnemyPart, bool> P1) {} // 0x0000000183F5DFD0-0x0000000183F5E650
		public bool __Gen_Wrap_40(object P0, ObjectPtr<Buff> P1) => default; // 0x0000000183F5E650-0x0000000183F5ECF0
		public BuffIconConfig.BuffIconStyle __Gen_Wrap_41(object P0, object P1) => default; // 0x0000000181385520-0x00000001813858D0
		public void __Gen_Wrap_42(object P0, ObjectPtr<Buff> P1) {} // 0x0000000183F5ECF0-0x0000000183F5F370
		public void __Gen_Wrap_43(Sprite P0) {} // 0x0000000181354D40-0x0000000181355000
		public void __Gen_Wrap_44(object P0, ObjectPtr<Buff> P1, object P2, object P3) {} // 0x0000000183F5F370-0x0000000183F5FBD0
		public void __Gen_Wrap_45(object P0, int P1, bool P2) {} // 0x0000000181F2E230-0x0000000181F2E520
		public UIBuffCell __Gen_Wrap_46(object P0, object P1) => default; // 0x0000000183F5FBD0-0x0000000183F60600
		public void __Gen_Wrap_47(object P0, ObjectPtr<Buff> P1, bool P2) {} // 0x0000000183F60600-0x0000000183F60CA0
		public bool __Gen_Wrap_48(object P0) => default; // 0x0000000181370BF0-0x0000000181370EB0
		public UIPoiseKnot __Gen_Wrap_49(object P0) => default; // 0x0000000183F60CA0-0x0000000183F615D0
		public void __Gen_Wrap_50(object P0, object P1, bool P2, bool P3, object P4) {} // 0x0000000183F615D0-0x0000000183F61A60
		public void __Gen_Wrap_51(object P0, ObjectPtr<Buff> P1, Buff.FinishReason P2) {} // 0x0000000183F61A60-0x0000000183F62100
		public void __Gen_Wrap_52(object P0, ObjectPtr<Buff> P1, bool P2, Buff.FinishReason P3) {} // 0x0000000183F62100-0x0000000183F627D0
		public void __Gen_Wrap_53(object P0, ObjectPtr<AbilitySystem> P1) {} // 0x0000000183F627D0-0x0000000183F62E50
		public void __Gen_Wrap_54(object P0, double P1) {} // 0x0000000183F62E50-0x0000000183F63130
		public void __Gen_Wrap_55(object P0, object P1, float P2, bool P3) {} // 0x0000000181703340-0x0000000181703700
		public void __Gen_Wrap_56(object P0, object P1, bool P2, int P3) {} // 0x00000001823B3E70-0x00000001823B4220
		public void __Gen_Wrap_57(object P0, object P1, int P2, int P3) {} // 0x000000018169FCB0-0x00000001816A0060
		public Vector3 __Gen_Wrap_58(object P0, object P1) => default; // 0x0000000183F63130-0x0000000183F63B00
		public void __Gen_Wrap_59(object P0, Vector3 P1) {} // 0x0000000183F63B00-0x0000000183F64190
		public void __Gen_Wrap_60(object P0, UIHeadLabel.VisibleSource P1, bool P2) {} // 0x0000000181F2E230-0x0000000181F2E520
		public void __Gen_Wrap_61(object P0, UIHeadLabel.HeadLabelType P1, UIHeadLabel.VisibleSource P2, bool P3, bool P4) {} // 0x00000001821B2C90-0x00000001821B2FD0
		public void __Gen_Wrap_62(object P0, in EventData<string> P1) {} // 0x0000000183F64190-0x0000000183F64830
		public void __Gen_Wrap_63(bool P0) {} // 0x00000001813641A0-0x0000000181364390
		public void __Gen_Wrap_64(object P0, bool P1, bool P2, bool P3) {} // 0x00000001825895D0-0x00000001825898F0
		public string __Gen_Wrap_65(object P0, object P1, object P2) => default; // 0x0000000183F64830-0x0000000183F65350
		public Sprite __Gen_Wrap_66(object P0, object P1, object P2) => default; // 0x0000000183F65350-0x0000000183F65E70
		public void __Gen_Wrap_67(object P0, in EventData<float> P1) {} // 0x0000000183F65E70-0x0000000183F66500
		public void __Gen_Wrap_68(object P0, object P1, int P2, bool P3) {} // 0x00000001817083A0-0x0000000181708760
		public GameObject __Gen_Wrap_69(object P0, object P1) => default; // 0x0000000183F66500-0x0000000183F66F30
		public void __Gen_Wrap_70(object P0, in EventData<int> P1) {} // 0x0000000183F66F30-0x0000000183F675B0
		public void __Gen_Wrap_71(object P0, in EventData<GlobalBuff, string> P1) {} // 0x0000000183F675B0-0x0000000183F67C50
		public void __Gen_Wrap_72(object P0, in EventData<GlobalBuff, string, GlobalBuff.FinishReason> P1) {} // 0x0000000183F67C50-0x0000000183F682D0
		public void __Gen_Wrap_73(object P0, object P1, bool P2) {} // 0x0000000181570C20-0x0000000181570FE0
		public ObjectPtr<Buff> __Gen_Wrap_74(object P0) => default; // 0x0000000183F682D0-0x0000000183F68BB0
		public void __Gen_Wrap_75(UISpellInflictionOnCharCell P0, int P1) {} // 0x000000018155EB40-0x000000018155EE10
		public ObjectPtr<Buff> __Gen_Wrap_76(object P0, object P1) => default; // 0x0000000183F68BB0-0x0000000183F69590
		public UICharPassiveBase __Gen_Wrap_77(object P0, object P1) => default; // 0x0000000183F69590-0x0000000183F69FC0
		public void __Gen_Wrap_78(object P0, in EventData<SetLeaderReason, Entity, Entity> P1) {} // 0x0000000183F69FC0-0x0000000183F6A640
		public OutOfScreenTargetArrow __Gen_Wrap_79(object P0) => default; // 0x0000000183F6A640-0x0000000183F6AF80
		public ValueTuple<Vector2, float> __Gen_Wrap_80(object P0, Vector3 P1) => default; // 0x0000000183F6AF80-0x0000000183F6BC30
		public void __Gen_Wrap_81(object P0, in EventData<ulong, uint> P1) {} // 0x0000000183F6BC30-0x0000000183F6C2B0
		public void __Gen_Wrap_82(object P0, in EventData<ulong, string> P1) {} // 0x0000000183F6C2B0-0x0000000183F6C930
		public void __Gen_Wrap_83(object P0, in EventData<ulong, string, int> P1) {} // 0x0000000183F6C930-0x0000000183F6CFB0
		public Sprite __Gen_Wrap_84(object P0, object P1) => default; // 0x0000000183F6CFB0-0x0000000183F6D9D0
		public void __Gen_Wrap_85(object P0, int P1, bool P2, bool P3) {} // 0x00000001816EC3E0-0x00000001816EC6F0
		public bool __Gen_Wrap_86(object P0, bool P1) => default; // 0x0000000183F6D9D0-0x0000000183F6DCC0
		public void __Gen_Wrap_87(object P0, in EventData<ulong, string, EnergyShardType> P1) {} // 0x0000000183F6DCC0-0x0000000183F6E340
		public void __Gen_Wrap_88(object P0, in EventData<UIStyleInputValidTypeMask> P1) {} // 0x0000000183F6E340-0x0000000183F6E9C0
		public void __Gen_Wrap_89(object P0, in EventData<CinematicTimelineManagerBase.TimelineHandle> P1) {} // 0x0000000183F6E9C0-0x0000000183F6F040
		public void __Gen_Wrap_90(object P0, in EventData<ForbidType, bool> P1) {} // 0x0000000183F6F040-0x0000000183F6F6E0
		public void __Gen_Wrap_91(object P0, int P1, int P2) {} // 0x0000000181F55370-0x0000000181F55660
		public void __Gen_Wrap_92(object P0, int P1, int P2, byte P3) {} // 0x00000001829DEF10-0x00000001829DF210
		public void __Gen_Wrap_93(object P0, int P1, int P2, int P3, int P4, byte P5) {} // 0x0000000183F6F6E0-0x0000000183F6FA10
		public byte __Gen_Wrap_94(object P0, int P1, int P2, out byte P3) {
			P3 = default;
			return default;
		} // 0x0000000183F6FA10-0x0000000183F6FD30
		public void __Gen_Wrap_95(object P0, CommonTrackingPointStyleType P1, object P2) {} // 0x000000018156A670-0x000000018156AA00
		public void __Gen_Wrap_96(object P0, CommonTrackingPointStyleType P1) {} // 0x0000000181566ED0-0x00000001815671B0
		public void __Gen_Wrap_97(object P0, Vector2 P1, float P2, bool P3, float P4, bool P5) {} // 0x0000000183F6FD30-0x0000000183F70430
		public void __Gen_Wrap_98(object P0, PosValueState P1, bool P2, Vector2 P3, float P4, bool P5, float P6, CommonTrackMapTier P7) {} // 0x0000000183F70430-0x0000000183F70B70
		public int __Gen_Wrap_99(object P0, object P1) => default; // 0x000000018135A390-0x000000018135A720
		public CommonTrackerUpdate.CommonTrackerItem __Gen_Wrap_100(object P0) => default; // 0x0000000183F4BA30-0x0000000183F4C360
		public bool __Gen_Wrap_101(object P0, int P1, object P2, object P3) => default; // 0x0000000182A8C4B0-0x0000000182A8C920
		public void __Gen_Wrap_102(object P0, bool P1, int P2) {} // 0x00000001821369B0-0x0000000182136CA0
		public void __Gen_Wrap_103(object P0, object P1, object P2, ulong P3, int P4) {} // 0x0000000183F4C360-0x0000000183F4C7E0
		public string __Gen_Wrap_104(object P0, LangKey P1, object P2) => default; // 0x0000000183F4C7E0-0x0000000183F4D560
		public void __Gen_Wrap_105(object P0, CoolerUnitTemperatureCircleUI.ETemperatureState P1) {} // 0x000000018155EB40-0x000000018155EE10
		public void __Gen_Wrap_106(object P0, ref float P1, ref float P2) {} // 0x0000000182C90E60-0x0000000182C91190
		public string[] __Gen_Wrap_107() => default; // 0x0000000183F4D560-0x0000000183F4DDA0
		public bool __Gen_Wrap_108(object P0, ulong P1) => default; // 0x0000000182A57AC0-0x0000000182A57DA0
		public GameObject __Gen_Wrap_109(object P0, object P1, object P2) => default; // 0x0000000183F4DDA0-0x0000000183F4E8A0
		public void __Gen_Wrap_110(object P0, object P1, UnityEngine.Color P2) {} // 0x0000000183F4E8A0-0x0000000183F4EFE0
		public uint __Gen_Wrap_111(object P0, object P1, object P2) => default; // 0x00000001815EE570-0x00000001815EE9D0
		public void __Gen_Wrap_112(object P0, uint P1, object P2, object P3) {} // 0x00000001817A1D10-0x00000001817A2260
		public void __Gen_Wrap_113(object P0, uint P1, object P2, bool P3, object P4) {} // 0x00000001825628A0-0x0000000182562D30
		public void __Gen_Wrap_114(object P0, uint P1, UnityEngine.Color P2) {} // 0x0000000183F4EFE0-0x0000000183F4F650
		public void __Gen_Wrap_115(object P0, bool P1, float P2, object P3, object P4) {} // 0x0000000183F4F650-0x0000000183F4FAE0
		public void __Gen_Wrap_116(object P0, float P1, bool P2) {} // 0x0000000183E9F9C0-0x0000000183E9FCC0
		public void __Gen_Wrap_117(PointerEventData P0) {} // 0x0000000181354D40-0x0000000181355000
		public void __Gen_Wrap_118(float P0) {} // 0x0000000181363FB0-0x00000001813641A0
		public void __Gen_Wrap_119(object P0, float P1, float P2, float P3, bool P4) {} // 0x0000000182A3DD80-0x0000000182A3E0C0
		public void __Gen_Wrap_120(object P0, float P1, float P2) {} // 0x00000001817989E0-0x0000000181798CE0
		public void __Gen_Wrap_121(object P0, float P1, float P2, object P3) {} // 0x000000018268C020-0x000000018268C3F0
		public void __Gen_Wrap_122(object P0, bool P1, bool P2, bool P3, ForgeIronTemperatureCircleUI.ETemperatureState P4) {} // 0x0000000183F4FAE0-0x0000000183F4FE10
		public Dictionary<string, RegionMap3DCfg> __Gen_Wrap_123(object P0) => default; // 0x0000000183F4FE10-0x0000000183F50750
		public void __Gen_Wrap_124(object P0, object P1, Vector3 P2, object P3) {} // 0x0000000183F50750-0x0000000183F50F70
		public bool __Gen_Wrap_125(Vector2 P0, float P1, UnityEngine.Rect P2) => default; // 0x0000000183F50F70-0x0000000183F518B0
		public void __Gen_Wrap_126(object P0, RegionMapShowType P1, object P2, object P3, float P4) {} // 0x0000000183F518B0-0x0000000183F51D30
		public Transform __Gen_Wrap_127(object P0, object P1) => default; // 0x0000000183F51D30-0x0000000183F52750
		public Vector3 __Gen_Wrap_128(object P0, object P1, object P2, object P3) => default; // 0x0000000183F52750-0x0000000183F532E0
		public RegionMap3DCfg __Gen_Wrap_129(object P0, object P1) => default; // 0x0000000183F532E0-0x0000000183F53D00
		public TweenerCore<Quaternion, Quaternion, NoOptions> __Gen_Wrap_130(object P0, float P1, object P2) => default; // 0x0000000183F53D00-0x0000000183F54740
		public void __Gen_Wrap_131(object P0, in EventData<long, long> P1) {} // 0x0000000183F54740-0x0000000183F54DC0
		public bool __Gen_Wrap_132() => default; // 0x000000018136AAC0-0x000000018136ACA0
		public bool __Gen_Wrap_133(object P0, object P1) => default; // 0x00000001815D5950-0x00000001815D5D10
		public void __Gen_Wrap_134(object P0, object P1, Vector3 P2) {} // 0x0000000183F54DC0-0x0000000183F55500
		public List<RaycastResult> __Gen_Wrap_135(object P0) => default; // 0x0000000183F55500-0x0000000183F55E30
		public LuaPanel __Gen_Wrap_136(object P0) => default; // 0x0000000183F55E30-0x0000000183F56760
		public void __Gen_Wrap_137(object P0, object P1, long P2, float P3) {} // 0x0000000182B85E80-0x0000000182B86240
		public void __Gen_Wrap_138(object P0, Vector3 P1, ulong P2) {} // 0x0000000183F56760-0x0000000183F56DF0
		public void __Gen_Wrap_139(object P0, int P1, object P2, object P3) {} // 0x00000001817A1D10-0x00000001817A2260
		public void __Gen_Wrap_140(object P0, bool P1, object P2) {} // 0x00000001815521B0-0x0000000181552550
		public void __Gen_Wrap_141(object P0, long P1) {} // 0x00000001815A3C10-0x00000001815A3EE0
		public void __Gen_Wrap_142(object P0, int P1, uint P2) {} // 0x0000000181F55370-0x0000000181F55660
		public void __Gen_Wrap_143(object P0, int P1, int P2, int P3) {} // 0x0000000182242DC0-0x00000001822430C0
		public void __Gen_Wrap_144(object P0, long P1, float P2) {} // 0x0000000183F56DF0-0x0000000183F570E0
		public RectTransform __Gen_Wrap_145(object P0) => default; // 0x0000000183F570E0-0x0000000183F57A10
		public void __Gen_Wrap_146(object P0, Vector2 P1, float P2, bool P3) {} // 0x0000000183F57A10-0x0000000183F580D0
		public void __Gen_Wrap_147(object P0, ulong P1, int P2, int P3, int P4) {} // 0x0000000182577540-0x0000000182577860
		public void __Gen_Wrap_148(object P0, PowerAutoConnectStatus P1) {} // 0x000000018155EB40-0x000000018155EE10
		public GameObject __Gen_Wrap_149(object P0) => default; // 0x0000000183F580D0-0x0000000183F58A00
		public void __Gen_Wrap_150(object P0, TravelPoleBrain.TravelPoleIcon P1) {} // 0x000000018155EB40-0x000000018155EE10
		public UIAnimationWrapper __Gen_Wrap_151(object P0) => default; // 0x0000000183F58A00-0x0000000183F59330
		public void __Gen_Wrap_152(object P0, TravelPoleBrain.TravelPoleStatus P1) {} // 0x000000018155EB40-0x000000018155EE10
		public void __Gen_Wrap_153(object P0, in EventData<int, float> P1) {} // 0x0000000183F59330-0x0000000183F599B0
		public void __Gen_Wrap_154(object P0, in EventData<WaterDroneSourceType> P1) {} // 0x0000000183F599B0-0x0000000183F5A030
		public void __Gen_Wrap_155(object P0, CustomAbilityComponent.WaterDroneByHydrantState P1) {} // 0x000000018155EB40-0x000000018155EE10
		public void __Gen_Wrap_156(object P0, in EventData<CustomAbilityComponent.WaterDroneByHydrantState> P1) {} // 0x0000000183F5A030-0x0000000183F5A6B0
		public void __Gen_Wrap_157(object P0, ObjectPtr<Entity> P1) {} // 0x0000000183F5A6B0-0x0000000183F5AD20
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 53076
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018BC62008-0x000000018BC6209C
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 53077
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018BC64DA0-0x000000018BC64E04
		public static bool IsPatched(int id) => default; // 0x00000001844C3F20-0x00000001844C3F90
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018BC64C5C-0x000000018BC64D28
		public object CreateWrapper(int id) => default; // 0x000000018BC64D28-0x000000018BC64DA0
		public object InitWrapperArray(int len) => default; // 0x000000018BC64E04-0x000000018BC65414
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018BC64BB8-0x000000018BC64C5C
	}

	public enum IDMAP0 // TypeDefIndex: 53078
	{
		Beyond-PoolCore-ListPoolInitializer_UI_Gameplay_Beyond-InitializeAtRuntime0 = 0,
		Beyond-PoolCore-ListPoolInitializer_UI_Gameplay_Beyond-Initialize0 = 1,
		Beyond-UI-UICharPassiveCounter-OnCharPassiveNumChanged0 = 2,
		Beyond-UI-UICharPassiveMultiStates-OnCharPassiveNumChanged0 = 3,
		Beyond-UI-UICharPassiveZhuangfy-OnCharPassiveNumChanged0 = 4,
		Beyond-UI-ComboSpecialNodeBase-OnAssignData0 = 5,
		Beyond-UI-ComboSpecialNodeBase-OnReady0 = 6,
		Beyond-UI-ComboSpecialNodeBase-OnTick0 = 7,
		Beyond-UI-ComboSpecialNodeBase-OnCast0 = 8,
		Beyond-UI-ComboSpecialNodeBase-OnRemove0 = 9,
		Beyond-UI-ComboSpecialNodeRingQte-OnAssignData0 = 10,
		Beyond-UI-ComboSpecialNodeRingQte-_OnComboSkillRingQte0 = 11,
		Beyond-UI-ComboSpecialNodeRingQte-OnCast0 = 12,
		Beyond-UI-ComboSpecialNodeRingQte-_Reset0 = 13,
		Beyond-UI-ComboSpecialNodeRingQte-OnRemove0 = 14,
		Beyond-UI-ComboSpecialNodeRingQte-OnTick0 = 15,
		Beyond-UI-ComboSpecialNodeRingQte-OnRelease0 = 16,
		Beyond-UI-DamageTextCtrl-OnCreate0 = 17,
		Beyond-UI-DamageTextCtrl-_InstantiateTextInstance0 = 18,
		Beyond-UI-DamageTextCtrl-_RecycleTextInstance0 = 19,
		Beyond-UI-DamageTextBase-Clear0 = 21,
		Beyond-UI-DamageTextCtrl-_OnHpChanged0 = 22,
		Beyond-UI-DamageTextCtrl-_CreateTextInstance0 = 23,
		Beyond-UI-DamageTextBase-SetText0 = 24,
		Beyond-UI-DamageTextBase-SetText1 = 25,
		Beyond-UI-DamageTextBase-SetColor0 = 26,
		Beyond-UI-DamageTextBase-SetFollowTarget0 = 27,
		Beyond-UI-DamageTextBase-SetUIOffset0 = 28,
		Beyond-UI-DamageTextBase-get_worldPosition0 = 29,
		Beyond-UI-DamageTextDamageBase-PlayAnimation0 = 30,
		Beyond-UI-DamageTextCtrl-_GetRandomTextOffset0 = 31,
		Beyond-UI-DamageTextCtrl-_IsTextPosValid0 = 32,
		Beyond-UI-DamageTextBase-PlayAnimation0 = 33,
		Beyond-UI-DamageTextCtrl-_OnIgniteBuffText0 = 34,
		Beyond-UI-DamageTextIgniteBuff-SetUIState0 = 35,
		Beyond-UI-DamageTextIgniteBuff-SetTextAndDuplication0 = 36,
		Beyond-UI-DamageTextCtrl-_OnImmuneText0 = 37,
		Beyond-UI-DamageTextBase-SetText2 = 38,
		Beyond-UI-DamageTextCtrl-_OnPhysicalInflictionApplied0 = 39,
		Beyond-UI-DamageTextCtrl-_OnSquadInFightChanged0 = 40,
		Beyond-UI-DamageTextCtrl-_OnCreateFlowText0 = 41,
		Beyond-UI-DamageTextCtrl-_OnCharLevelUp0 = 42,
		Beyond-UI-DamageTextCtrl-OnClose0 = 44,
		Beyond-UI-DamageTextCtrl-DebugChangeImpl0 = 45,
		Beyond-UI-DamageTextCtrl-OnShow0 = 46,
		Beyond-UI-DamageTextCtrl-OnHide0 = 47,
		Beyond-UI-DamageTextCtrl-Tick0 = 48,
		Beyond-UI-DamageTextCtrlV2-OnCreate0 = 49,
		Beyond-UI-DamageTextCtrlV2-_OnHpChanged0 = 50,
		Beyond-UI-DamageTextCtrlV2-_CreateTextInstance0 = 51,
		Beyond-UI-DamageTextBaseV2-Assign0 = 52,
		Beyond-UI-DamageTextBaseV2-SetText0 = 53,
		Beyond-UI-DamageTextBaseV2-SetText1 = 54,
		Beyond-UI-DamageTextBaseV2-SetColor0 = 55,
		Beyond-UI-DamageTextBaseV2-SetFollowTarget0 = 56,
		Beyond-UI-DamageTextBaseV2-get_worldPosition0 = 57,
		Beyond-UI-DamageTextBaseV2-SetUIOffset0 = 58,
		Beyond-UI-DamageTextBaseV2-PlayAnimation0 = 59,
		Beyond-UI-DamageTextCtrlV2-_GetRandomTextOffset0 = 60,
		Beyond-UI-DamageTextCtrlV2-_IsTextPosValid0 = 61,
		Beyond-UI-DamageTextBaseV2-DestroyDisplay0 = 62,
		Beyond-UI-DamageTextCtrlV2-_OnIgniteBuffText0 = 63,
		Beyond-UI-DamageTextBaseV2-SetText2 = 64,
		Beyond-UI-DamageTextCtrlV2-_OnImmuneText0 = 65,
		Beyond-UI-DamageTextCtrlV2-_OnPhysicalInflictionApplied0 = 66,
		Beyond-UI-DamageTextCtrlV2-_OnSquadInFightChanged0 = 67,
		Beyond-UI-DamageTextCtrlV2-_OnCreateFlowText0 = 68,
		Beyond-UI-DamageTextCtrlV2-_OnCharLevelUp0 = 69,
		Beyond-UI-DamageTextCtrlV2-_RecycleTextInstance0 = 70,
		Beyond-UI-DamageTextBaseV2-Clear0 = 72,
		Beyond-UI-DamageTextCtrlV2-OnClose0 = 74,
		Beyond-UI-DamageTextCtrlV2-DebugChangeImpl0 = 75,
		Beyond-UI-DamageTextCtrlV2-OnShow0 = 76,
		Beyond-UI-DamageTextCtrlV2-OnHide0 = 77,
		Beyond-UI-DamageTextCtrlV2-Tick0 = 78,
		Beyond-UI-DamageTextBaseV2-Tick0 = 79,
		Beyond-UI-DamageTextBaseV2-_UpdatePosition0 = 80,
		Beyond-UI-DamageTextBase-OnAwake0 = 81,
		Beyond-UI-DamageTextBase-OnRelease0 = 82,
		Beyond-UI-DamageTextBase-TailLateTick0 = 83,
		Beyond-UI-DamageTextBase-_UpdatePosition0 = 84,
		Beyond-UI-DamageTextBaseV2-OnRelease0 = 85,
		Beyond-UI-DamageTextBlock-SetColor0 = 86,
		Beyond-UI-DamageTextCriticalLevel0-SetColor0 = 87,
		Beyond-UI-DamageTextCriticalLevel1-SetColor0 = 88,
		Beyond-UI-DamageTextCriticalLevel1-PlayAnimation0 = 89,
		Beyond-UI-DamageTextIgniteBuff-OnAwake0 = 90,
		Beyond-UI-DamageTextIgniteBuff-OnRelease0 = 91,
		Beyond-UI-DamageTextNormalLevel1-PlayAnimation0 = 92,
		Beyond-UI-FootBarDashCell-SetIndex0 = 93,
		Beyond-UI-FootBarDashCell-SetDashCount0 = 94,
		Beyond-UI-FootBarDashCell-StartPlayNotEnoughAnim0 = 95,
		Beyond-UI-FootBarDashCell-StopPlayNotEnoughAnim0 = 96,
		Beyond-UI-HeadBarCtrl-OnCreate0 = 97,
		Beyond-UI-HeadBarCtrl-_OnInteractNpc0 = 98,
		Beyond-UI-HeadBarCtrl-_SetInDialog0 = 99,
		Beyond-UI-HeadBarCtrl-_RefreshHeadBar0 = 100,
		Beyond-UI-HeadBarCtrl-_GetHeadBarType0 = 102,
		Beyond-UI-UIAbilityTargetFollower-SetTarget0 = 103,
		Beyond-UI-UIAbilityTargetFollower-_TryRefreshFollowTransform0 = 104,
		Beyond-UI-UIAbilityTargetFollower-_TryRefreshHeightFollowTransform0 = 105,
		Beyond-UI-UIAbilityTargetFollower-_UpdateSelfTransform0 = 106,
		Beyond-UI-UIAbilityTargetFollower-_CalculatePosition0 = 107,
		Beyond-UI-UIAbilityTargetFollower-TryGetOriginalFollowPos0 = 108,
		Beyond-UI-UIAbilityTargetFollower-_SetDistanceVisible0 = 109,
		Beyond-UI-UIAbilityTargetFollower-OnActualVisibleChange0 = 110,
		Beyond-UI-UIAbilityTargetFollower-_UpdatePosition0 = 112,
		Beyond-UI-UIAbilityTargetFollower-_UpdateScale0 = 113,
		Beyond-UI-UIHeadBarFollower-ShowModifierAfterSetTarget0 = 114,
		Beyond-UI-UIHeadBar-ShowModifierAfterSetTarget0 = 115,
		Beyond-UI-UIHeadBar-_SetImageFill0 = 116,
		Beyond-UI-UIHeadBar-_OnHpChange0 = 117,
		Beyond-UI-UIHeadBar-_CalculateHpChangeDisplay0 = 118,
		Beyond-UI-UIHeadBarFollower-OnAfterHpBroken0 = 121,
		Beyond-UI-UIHeadBar-OnAfterHpBroken0 = 122,
		Beyond-UI-UIHeadBarFollower-OnBeforeHpBroken0 = 124,
		Beyond-UI-UIHeadBar-OnBeforeHpBroken0 = 125,
		Beyond-UI-HeadBarCtrl-_OnDialogStart0 = 126,
		Beyond-UI-HeadBarCtrl-_OnDialogFinish0 = 127,
		Beyond-UI-HeadBarCtrl-_OnAddHeadBar0 = 128,
		Beyond-UI-HeadBarCtrl-_OnRemoveHeadBar0 = 129,
		Beyond-UI-HeadBarCtrl-_OnHeadBarShowConfigChanged0 = 130,
		Beyond-UI-HeadBarCtrl-_OnHpChanged0 = 131,
		Beyond-UI-HeadBarCtrl-_OnEnemyPartEnableChanged0 = 132,
		Beyond-UI-HeadBarCtrl-_PrewarmHeadBar0 = 133,
		Beyond-UI-UIHeadBarFollower-OnPreWarm0 = 134,
		Beyond-UI-UIHeadBar-OnPreWarm0 = 135,
		Beyond-UI-UIBuffNode-OnPreWarm0 = 136,
		Beyond-UI-UIBuffNode-_OnFirstInit0 = 137,
		Beyond-UI-UIBuffCell-Clear0 = 138,
		Beyond-UI-HeadBarCtrl-OnClose0 = 141,
		Beyond-UI-HeadBarCtrl-OnShow0 = 142,
		Beyond-UI-UIHeadBarFollower-Refresh0 = 143,
		Beyond-UI-UIHeadBar-Refresh0 = 144,
		Beyond-UI-UIPoiseBar-Refresh0 = 145,
		Beyond-UI-UIBuffNode-Refresh0 = 146,
		Beyond-UI-UIBuffNode-BuffCellGroup-ClearAllBuffCells0 = 147,
		Beyond-UI-UIBuffNode-BuffCellGroup-RemoveBuffCell0 = 148,
		Beyond-UI-UIBuffNode-_IsBuffIconInThisNode0 = 149,
		Beyond-UI-UIBuffNode-_AddBuffIconInternal0 = 150,
		Beyond-UI-UIBuffNode-_GetIconStyle0 = 152,
		Beyond-UI-UIBuffCell-Init0 = 153,
		Beyond-UI-UIBuffCell-VisualInit0 = 156,
		Beyond-UI-UIBuffCell-SetBuffIcon0 = 157,
		Beyond-UI-UIBuffCell-SetStackElementActive0 = 158,
		Beyond-UI-UIBuffCell-SetWarningState0 = 159,
		Beyond-UI-UIBuffCell-SetVisible0 = 160,
		Beyond-UI-UIBuffCell-DataInit0 = 162,
		Beyond-UI-UIBuffCell-SetStackCount0 = 164,
		Beyond-UI-UIBuffNode-_SetBuffCellSiblingInOrder0 = 167,
		Beyond-UI-UIBuffNode-_DealWithBuffCellVisible0 = 168,
		Beyond-UI-UIBuffNode-BuffCellGroup-CreateBuffCell0 = 169,
		Beyond-UI-UIVigilanceBar-Refresh0 = 174,
		Beyond-UI-HeadBarCtrl-OnHide0 = 175,
		Beyond-UI-HeadBarCtrl-LateTick0 = 176,
		Beyond-UI-HeadBarCtrl-_UpdateSurroundingEnemies0 = 177,
		Beyond-UI-HeadBarCtrl-_UpdateHeadBar0 = 178,
		Beyond-UI-UIHeadBarFollower-SetHeadBarVisible0 = 179,
		Beyond-UI-HeadBarCtrl-_UpdateLevelInfoBar0 = 180,
		Beyond-UI-HeadBarCtrl-_UpdateVigilanceBar0 = 183,
		Beyond-UI-HeadBarCtrl-_UpdateTacticalItemBar0 = 184,
		Beyond-UI-UITacticalItemBar-IsTacticalItemActive0 = 187,
		Beyond-UI-UIHeadBar-OnDestroy0 = 188,
		Beyond-UI-UIHeadBar-SetTarget0 = 189,
		Beyond-UI-UIPoiseBar-Init0 = 190,
		Beyond-UI-UIPoiseKnot-SetVisible0 = 191,
		Beyond-UI-UIPoiseBar-_ClearPoiseKnot0 = 192,
		Beyond-UI-UIPoiseBar-_TryInitPoiseKnot0 = 193,
		Beyond-UI-UIPoiseBar-_CreatePoiseKnot0 = 194,
		Beyond-UI-UIPoiseBar-get_hidePoiseBar0 = 195,
		Beyond-UI-UIBuffNode-Init0 = 196,
		Beyond-UI-UIBuffNode-_UnregisterAbilityBuffEvent0 = 197,
		Beyond-UI-UIBuffNode-OnBuffIconChange0 = 198,
		Beyond-UI-UIBuffNode-_OnAddBuff0 = 199,
		Beyond-UI-UIBuffNode-_OnRemoveBuff0 = 200,
		Beyond-UI-UIBuffNode-_RemoveBuffIconInternal0 = 201,
		Beyond-UI-UIBuffCell-BeforePlayOutAnim0 = 206,
		Beyond-UI-UIBuffNode-_OnBuffEnhanceChanged0 = 210,
		Beyond-UI-UIBuffNode-_OnBuffIgnite0 = 211,
		Beyond-UI-UIBuffCell-OnBuffIgnite0 = 212,
		Beyond-UI-UIBuffNode-_RegisterAbilityBuffEvent0 = 213,
		Beyond-UI-UIHeadBar-_OnForceSetHp0 = 214,
		Beyond-UI-UIHeadBar-_OnPoiseChange0 = 215,
		Beyond-UI-UIPoiseBar-OnPoiseChange0 = 216,
		Beyond-UI-UIPoiseKnot-KnotBreak0 = 217,
		Beyond-UI-UIPoiseBar-_CalculatePoiseChangeDisplay0 = 218,
		Beyond-UI-UIHeadBar-_OnMultiTimeWeaknessActivate0 = 219,
		Beyond-UI-UIWeaknessNode-SetTotalCellNum0 = 220,
		Beyond-UI-UIHeadBar-_OnWeaknessCountChanged0 = 221,
		Beyond-UI-UIWeaknessNode-SetCurrentCellNum0 = 222,
		Beyond-UI-UIHeadBar-_OnMainTargetChanged0 = 223,
		Beyond-UI-UIHeadBar-Clear0 = 224,
		Beyond-UI-UIPoiseBar-Clear0 = 225,
		Beyond-UI-UIBuffNode-Clear0 = 226,
		Beyond-UI-UIHeadBar-_UpdateHpDisplay0 = 227,
		Beyond-UI-UIHeadBar-_UpdateScale0 = 228,
		Beyond-UI-UIHeadBar-UpdateData0 = 229,
		Beyond-UI-UIPoiseBar-UpdatePoiseBar0 = 230,
		Beyond-UI-UIPoiseBar-_UpdatePoiseDisplay0 = 231,
		Beyond-UI-UIHeadBarFollower-SetTarget0 = 232,
		Beyond-UI-UIHeadBarFollower-_UpdateGuideLine0 = 233,
		Beyond-UI-UIHeadBarFollower-Clear0 = 234,
		Beyond-UI-UIAbilityTargetFollower-Clear0 = 235,
		Beyond-UI-UIHeadBarFollower-UpdateData0 = 236,
		Beyond-UI-UIHeadBarFollower-TryGetOriginalFollowPos0 = 237,
		Beyond-UI-UIAbilityTargetFollower-GetAdjustedHeightOffset0 = 238,
		Beyond-UI-UIHeadLabel-_OnSubRootsCollectionChanged0 = 239,
		Beyond-UI-UIHeadLabel-_TryInitRootData0 = 240,
		Beyond-UI-UIHeadLabel-HeadLabelRootVisibleData-Init0 = 241,
		Beyond-UI-UIHeadLabel-SetVisibleDirty0 = 242,
		Beyond-UI-UIHeadLabel-_UpdateVisible0 = 243,
		Beyond-UI-UIHeadLabel-HeadLabelRootVisibleData-get_realVisible0 = 244,
		Beyond-UI-UIHeadLabel-SetSubRootVisible0 = 245,
		Beyond-UI-UIHeadLabel-HeadLabelRootVisibleData-UpdateVisible0 = 246,
		Beyond-UI-UIHeadLabel-SetTarget0 = 247,
		Beyond-UI-UIHeadLabel-_BindTargetEvent0 = 249,
		Beyond-UI-UIHeadLabel-_OnNpcVisibleChanged0 = 250,
		Beyond-UI-UIHeadLabel-_TryUpdateVisibleCallback0 = 252,
		Beyond-UI-UIHeadLabel-_UpdateFloatingUIVisibleCallback0 = 253,
		Beyond-UI-UIHeadLabel-_UpdatePos0 = 256,
		Beyond-UI-UIHeadLabel-_BindMissionTracking0 = 257,
		Beyond-UI-UIHeadLabel-_OnMissionTypeIconChanged0 = 258,
		Beyond-UI-UIHeadLabel-_ClearVisibleCallback0 = 260,
		Beyond-UI-UIHeadLabel-_ClearFloatingUIVisibleCallback0 = 261,
		Beyond-UI-UIHeadLabel-Clear0 = 262,
		Beyond-UI-UIHeadLabel-_RefreshVisible0 = 263,
		Beyond-UI-UIHeadLabel-ClearEmojis0 = 264,
		Beyond-UI-UIHeadLabel-_UnBindMissionTracking0 = 265,
		Beyond-UI-UIHeadLabel-_UnBindTargetEvent0 = 266,
		Beyond-UI-UIHeadLabel-SetActive0 = 267,
		Beyond-UI-UIHeadLabel-_TryUpdateVisible0 = 268,
		Beyond-UI-UIHeadLabel-OnAwake0 = 269,
		Beyond-UI-UIHeadLabel-LateTick0 = 270,
		Beyond-UI-UIHeadLabel-OnEnable0 = 271,
		Beyond-UI-UIHeadLabel-OnDisable0 = 272,
		Beyond-UI-UIHeadLabel-OnRelease0 = 273,
		Beyond-UI-UILvInfoBar-SetTarget0 = 274,
		Beyond-UI-UILvInfoBar-TryGetOriginalFollowPos0 = 275,
		Beyond-UI-UITacticalItemBar-SetTarget0 = 276,
		Beyond-UI-UIPanelBase-LoadSprite0 = 277,
		Beyond-UI-UIPanelBase-GetSpritePath0 = 278,
		Beyond-UI-UITacticalItemBar-Clear0 = 279,
		Beyond-UI-UITacticalItemBar-UpdateData0 = 280,
		Beyond-UI-UIVigilanceBar-SetTarget0 = 281,
		Beyond-UI-UIVigilanceBar-Clear0 = 282,
		Beyond-UI-UIVigilanceBar-UpdateData0 = 283,
		Beyond-UI-UIVigilanceBar-_UpdateVigilanceNode0 = 284,
		Beyond-UI-UIVigilanceBar-_SetVigilanceActive0 = 285,
		Beyond-UI-UIVigilanceBar-TryGetOriginalFollowPos0 = 288,
		Beyond-UI-UIWeaknessNode-Awake0 = 289,
		Beyond-UI-AtbNode-OnCreate0 = 290,
		Beyond-UI-AtbNode-OnInFightChanged0 = 291,
		Beyond-UI-AtbNode-_RefreshAtbShowing0 = 292,
		Beyond-UI-AtbNode-_OnAtbCellOutAnimCallback0 = 293,
		Beyond-UI-AtbNode-CheckAtbLoopAnim0 = 294,
		Beyond-UI-AtbNode-OnGainAtb0 = 295,
		Beyond-UI-AtbNode-OnClose0 = 298,
		Beyond-UI-AtbNode-LateTick0 = 299,
		Beyond-UI-ComboSkillHint-Init0 = 300,
		Beyond-UI-ComboSkillPanel-CastComboSkill0 = 301,
		Beyond-UI-ComboSkillPanel-_ResortSiblingIndex0 = 304,
		Beyond-UI-ComboSkillHint-OnCast0 = 305,
		Beyond-UI-ComboSkillPanel-_CheckUpdate0 = 306,
		Beyond-UI-ComboSkillHint-OnReady0 = 307,
		Beyond-UI-ComboSkillHint-OnTick0 = 308,
		Beyond-UI-ComboSkillHint-OnRemove0 = 309,
		Beyond-UI-ComboSkillHint-Release0 = 310,
		Beyond-UI-ComboSkillHint-AssignData0 = 311,
		Beyond-UI-UIPanelBase-LoadGameObject0 = 312,
		Beyond-UI-ComboSkillPanel-OnCreate0 = 313,
		Beyond-UI-ComboSkillPanel-_UnbindListeners0 = 314,
		Beyond-UI-ComboSkillPanel-_OnComboSkillReady0 = 315,
		Beyond-UI-ComboSkillPanel-_OnComboSkillRemove0 = 316,
		Beyond-UI-ComboSkillPanel-_RemoveComboSkill0 = 317,
		Beyond-UI-ComboSkillPanel-_OnBattleTeamChanged0 = 320,
		Beyond-UI-ComboSkillPanel-_OnComboSkillClearAll0 = 321,
		Beyond-UI-ComboSkillPanel-OnShow0 = 325,
		Beyond-UI-ComboSkillPanel-OnRelease0 = 326,
		Beyond-UI-UIPanelBase-OnRelease0 = 327,
		Beyond-UI-ComboSkillPanel-PreTick0 = 328,
		Beyond-UI-HpBarComboNode-Awake0 = 329,
		Beyond-UI-HpBarComboNode-_OnGlobalBuffStart0 = 330,
		Beyond-UI-HpBarComboNode-_RefreshComboCount0 = 331,
		Beyond-UI-HpBarComboNode-_AnimOutCallback0 = 332,
		Beyond-UI-HpBarComboNode-_AnimInCallback0 = 333,
		Beyond-UI-HpBarComboNode-_OnGlobalBuffFinish0 = 334,
		Beyond-UI-HpBarComboNode-OnDestroy0 = 335,
		Beyond-UI-MainCharHpBar-OnAwake0 = 336,
		Beyond-UI-MainCharHpBar-_OnMainCharChange0 = 337,
		Beyond-UI-MainCharHpBar-_ProcessOnMainCharChange0 = 338,
		Beyond-UI-MainCharHpBar-_ClearMainChar0 = 339,
		Beyond-UI-MainCharHpBar-_OnHpChange0 = 340,
		Beyond-UI-MainCharHpBar-_SetHpFillAmount0 = 341,
		Beyond-UI-MainCharHpBar-_CalculateHpChangeDisplay0 = 342,
		Beyond-UI-UIHudFadeController-SetLocalNeedShow0 = 343,
		Beyond-UI-UIHudFadeController-_CheckNeedShow0 = 344,
		Beyond-UI-UIHudFadeController-InformShow0 = 345,
		Beyond-UI-MainCharHpBar-_OnTakeDamage0 = 346,
		Beyond-UI-MainCharHpBar-_OnCharPassiveNumChanged0 = 347,
		Beyond-UI-MainCharHpBar-_OnBuffIconChange0 = 348,
		Beyond-UI-MainCharHpBar-_BlinkBuffIcon0 = 349,
		Beyond-UI-MainCharHpBar-_RefreshBuffChangeCharHpBarVfx0 = 353,
		Beyond-UI-MainCharHpBar-_IsCharHpBarVfxBuffValid0 = 354,
		Beyond-UI-MainCharHpBar-_HpVfxOutAnimCallback0 = 355,
		Beyond-UI-MainCharHpBar-_GetLatestValidCharHpBarVfxBuffPtrFromCache0 = 356,
		Beyond-UI-MainCharHpBar-_OnBuffEnhanceChanged0 = 357,
		Beyond-UI-UISpellInflictionOnCharNode-OnClear0 = 358,
		Beyond-UI-UISpellInflictionOnCharNode-_UnregisterAbilityBuffEvent0 = 359,
		Beyond-UI-UISpellInflictionOnCharNode-_OnBuffIconChange0 = 360,
		Beyond-UI-UISpellInflictionOnCharCell-SetCellActive0 = 363,
		Beyond-UI-UISpellInflictionOnCharNode-_OnBuffEnhanceChanged0 = 364,
		Beyond-UI-MainCharHpBar-_RebuildCharHpBarVfxBuffCache0 = 367,
		Beyond-UI-UISpellInflictionOnCharNode-OnInit0 = 368,
		Beyond-UI-UISpellInflictionOnCharNode-_OnFirstInit0 = 369,
		Beyond-UI-UISpellInflictionOnCharNode-_RegisterAbilityBuffEvent0 = 370,
		Beyond-UI-UISpellInflictionOnCharNode-_DoRefreshUI0 = 371,
		Beyond-UI-MainCharHpBar-_SelectUltimateBuff0 = 377,
		Beyond-UI-MainCharHpBar-_GetUltimateBuffForAbility0 = 378,
		Beyond-UI-MainCharHpBar-_IsUltimateBuffValid0 = 379,
		Beyond-UI-MainCharHpBar-_SetUltimateBuff0 = 380,
		Beyond-UI-MainCharHpBar-_UltimateBuffProgressOutAnimCallback0 = 381,
		Beyond-UI-MainCharHpBar-_GetOrCreateCharPassiveBase0 = 382,
		Beyond-UI-MainCharHpBar-_OnTeamChanged0 = 383,
		Beyond-UI-MainCharHpBar-_RebuildUltimateBuffTracking0 = 384,
		Beyond-UI-MainCharHpBar-_OnProgressBarBuffChange0 = 385,
		Beyond-UI-MainCharHpBar-_OnMainCharHpActiveChange0 = 386,
		Beyond-UI-MainCharHpBar-OnEnable0 = 387,
		Beyond-UI-MainCharHpBar-_CheckHpBarShowing0 = 388,
		Beyond-UI-MainCharHpBar-_SetHpBarShowing0 = 389,
		Beyond-UI-MainCharHpBar-OnRelease0 = 391,
		Beyond-UI-MainCharHpBar-OnShow0 = 392,
		Beyond-UI-MainCharHpBar-OnHide0 = 393,
		Beyond-UI-MainCharHpBar-LateTick0 = 394,
		Beyond-UI-MainCharHpBar-_UpdateHpDisplay0 = 395,
		Beyond-UI-UISpellInflictionOnCharNode-OnTick0 = 396,
		Beyond-UI-OutOfScreenTargetsCtrl-OnCreate0 = 397,
		Beyond-UI-OutOfScreenTargetsCtrl-_OnEnemyCastSkillToMainChar0 = 398,
		Beyond-UI-OutOfScreenTargetsCtrl-OnClose0 = 399,
		Beyond-UI-OutOfScreenTargetsCtrl-OnShow0 = 400,
		Beyond-UI-OutOfScreenTargetsCtrl-LateTick0 = 401,
		Beyond-UI-OutOfScreenTargetsCtrl-_CreateOneArrow0 = 402,
		Beyond-UI-OutOfScreenTargetsCtrl-_InitArrowCallbacks0 = 403,
		Beyond-UI-OutOfScreenTargetsCtrl-_ScreenPosToUIPos0 = 408,
		Beyond-UI-SkillButton-OnAwake0 = 409,
		Beyond-UI-SkillButton-OnEnable0 = 411,
		Beyond-UI-SkillButton-Close0 = 412,
		Beyond-UI-SkillButton-_OnOtherPressSkillButtonStart0 = 413,
		Beyond-UI-SkillButton-PressHandler-OnOtherPressSkillButtonStart0 = 414,
		Beyond-UI-SkillButton-OnUspChange0 = 415,
		Beyond-UI-SkillButton-_OnBuffIconChange0 = 416,
		Beyond-UI-SkillButton-_RefreshNormalProgressBuff0 = 417,
		Beyond-UI-SkillButton-_OnCharPotentialUnlock0 = 418,
		Beyond-UI-SkillButton-RefreshSkillButton0 = 419,
		Beyond-UI-SkillButton-_InitSkillData0 = 420,
		Beyond-UI-SkillButton-_UpdateMainUI0 = 421,
		Beyond-UI-SkillButton-_RefreshDeadState0 = 422,
		Beyond-UI-SkillButton-OnPressCancelled0 = 423,
		Beyond-UI-SkillButton-_CheckNormalSkillHighlight0 = 424,
		Beyond-UI-SkillButton-_SetPressFillActive0 = 425,
		Beyond-UI-SkillButton-_OnSkillButtonActiveConfigChanged0 = 426,
		Beyond-UI-SkillButton-_SetGoActive0 = 427,
		Beyond-UI-SkillButton-_OnCharNormalSkillChange0 = 428,
		Beyond-UI-SkillButton-_OnSkillUpgradeSuccess0 = 429,
		Beyond-UI-SkillButton-_OnInputActionKeyUpdated0 = 430,
		Beyond-UI-SkillButton-_UpdateLongPressKeyHint0 = 431,
		Beyond-UI-UIPanelBase-LoadSpriteWithOutFormat0 = 432,
		Beyond-UI-SkillButton-_OnKeyboardTypeChanged0 = 433,
		Beyond-UI-SkillButton-FirstTimeInit0 = 434,
		Beyond-UI-SkillButton-OnPressSkillStart0 = 435,
		Beyond-UI-SkillButton-OnPressSkillEnd0 = 436,
		Beyond-UI-SkillButton-OnPressUltimateSkillStart0 = 437,
		Beyond-UI-SkillButton-OnCharacterDie0 = 438,
		Beyond-UI-SkillButton-_SetPressFillAmount0 = 439,
		Beyond-UI-SkillButton-CastSkill0 = 440,
		Beyond-UI-SkillButton-ToggleControllerSkillIndicator0 = 441,
		Beyond-UI-SkillButton-SetEmpty0 = 442,
		Beyond-UI-SkillButton-ClearBtnClick0 = 443,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnPressStart0 = 444,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnUpdate0 = 445,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnPressEnd0 = 446,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnPressCancel0 = 447,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnOtherPressSkillButtonStart0 = 448,
		Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnPressStart0 = 449,
		Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnUpdate0 = 450,
		Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnPressEnd0 = 451,
		Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnPressCancel0 = 452,
		Beyond-UI-SkillButton-PressHandlerDrag-OnPressStart0 = 453,
		Beyond-UI-SkillButton-PressHandlerDrag-OnUpdate0 = 454,
		Beyond-UI-SkillButton-PressHandlerDrag-OnPressEnd0 = 455,
		Beyond-UI-SkillButton-PressHandlerDrag-OnPressCancel0 = 456,
		Beyond-UI-SquadIcon-OnAwake0 = 457,
		Beyond-UI-SquadIcon-FirstTimeInit0 = 458,
		Beyond-UI-SquadIcon-OnPressCharIconStart0 = 459,
		Beyond-UI-SquadIcon-CanSwitchToCenter0 = 460,
		Beyond-UI-SquadIcon-_OnMainCharChange0 = 463,
		Beyond-UI-SquadIcon-_OnIgniteBuffText0 = 464,
		Beyond-UI-SquadIcon-Close0 = 465,
		Beyond-UI-SquadIcon-_OnHpChange0 = 466,
		Beyond-UI-SquadIcon-_OnBuffIconChange0 = 468,
		Beyond-UI-SquadIcon-_RefreshBuffChangeCharHpBarVfx0 = 469,
		Beyond-UI-SquadIcon-_IsCharHpBarVfxBuffValid0 = 470,
		Beyond-UI-SquadIcon-_HpVfxOutAnimCallback0 = 471,
		Beyond-UI-SquadIcon-_GetLatestValidCharHpBarVfxBuffPtrFromCache0 = 472,
		Beyond-UI-SquadIcon-_OnCharPassiveNumChanged0 = 473,
		Beyond-UI-SquadIcon-InitSquadIcon0 = 474,
		Beyond-UI-SquadIcon-SetDeadState0 = 475,
		Beyond-UI-SquadIcon-_RebuildCharHpBarVfxBuffCache0 = 476,
		Beyond-UI-SquadIcon-_UpdateComboSkillIcon0 = 477,
		Beyond-UI-SquadIcon-_TryShowLevelUpAnim0 = 480,
		Beyond-UI-SquadIcon-_SetLevelText0 = 482,
		Beyond-UI-SquadIcon-OnTacticalItemChange0 = 483,
		Beyond-UI-TacticalDotCell-Init0 = 484,
		Beyond-UI-SquadIcon-_MustUpdate0 = 485,
		Beyond-UI-SquadIcon-LateTick0 = 486,
		Beyond-UI-SquadIcon-_UpdateIconAlpha0 = 487,
		Beyond-UI-SquadIcon-_UpdateTacticalItemStatus0 = 488,
		Beyond-UI-TacticalDotCell-SetDotActive0 = 489,
		Beyond-UI-TacticalDotCell-SetDotUsedUp0 = 491,
		Beyond-UI-SquadIcon-SetEmpty0 = 492,
		Beyond-UI-SquadIcon-ToggleIndicator0 = 493,
		Beyond-UI-SquadIcon-InformKeyHint0 = 494,
		Beyond-UI-SquadIcon-OnLevelChange0 = 495,
		Beyond-UI-SquadIcon-OnTeamSwitchUnlocked0 = 496,
		Beyond-UI-UIAbnormalBuffCell-OnTick0 = 497,
		Beyond-UI-UIBuffCell-OnTick0 = 498,
		Beyond-UI-UIAbnormalBuffCell-VisualInit0 = 499,
		Beyond-UI-UIAbnormalBuffCell-SetWarningState0 = 500,
		Beyond-UI-UIAttachedBuffCell-DataInit0 = 501,
		Beyond-UI-UIAttachedBuffCell-OnTick0 = 502,
		Beyond-UI-UIAttachedBuffCell-BeforePlayOutAnim0 = 503,
		Beyond-UI-UIAttachedBuffCell-SetBuffIcon0 = 504,
		Beyond-UI-UIAttachedBuffCell-SetStackElementActive0 = 505,
		Beyond-UI-UIAttachedBuffCell-SetStackCount0 = 506,
		Beyond-UI-UIAttachedBuffCell-OnBuffIgnite0 = 508,
		Beyond-UI-UIBuffNode-TailLateTick0 = 509,
		Beyond-UI-UIBuffNode-OnRelease0 = 510,
		Beyond-UI-UILifeTimeBuffCell-OnTick0 = 511,
		Beyond-UI-UILifeTimeBuffCell-SetWarningState0 = 512,
		Beyond-UI-UIHudFadeConsoleController-Awake0 = 513,
		Beyond-UI-UIHudFadeConsoleController-_OnFadeHud0 = 514,
		Beyond-UI-UIHudFadeConsoleController-_CheckNeedShow0 = 515,
		Beyond-UI-UIHudFadeConsoleController-_OnInformShow0 = 517,
		Beyond-UI-UIHudFadeConsoleController-InformShow0 = 518,
		Beyond-UI-UIHudFadeConsoleController-OnDestroy0 = 520,
		Beyond-UI-UIHudFadeConsoleController-OnShow0 = 521,
		Beyond-UI-UIHudFadeController-Awake0 = 522,
		Beyond-UI-UIHudFadeController-_OnFadeHud0 = 523,
		Beyond-UI-UIHudFadeController-_OnInformShow0 = 524,
		Beyond-UI-UIHudFadeController-OnDestroy0 = 525,
		Beyond-UI-UIHudFadeTouchSkill-Awake0 = 526,
		Beyond-UI-UIHudFadeTouchSkill-_OnFadeHud0 = 527,
		Beyond-UI-UIHudFadeTouchSkill-_CheckNeedShow0 = 528,
		Beyond-UI-UIHudFadeTouchSkill-_OnInformShow0 = 530,
		Beyond-UI-UIHudFadeTouchSkill-InformShow0 = 531,
		Beyond-UI-UIHudFadeTouchSkill-OnDestroy0 = 534,
		Beyond-UI-UIHudFadeTouchSkill-OnShow0 = 535,
		Beyond-UI-UIAbilityTargetFollower-OnAwake0 = 536,
		Beyond-UI-UIAbilityTargetFollower-TailLateTick0 = 537,
		Beyond-UI-UIAbilityTargetFollower-UpdateData0 = 538,
		Beyond-UI-UILockAim-OnAwake0 = 539,
		Beyond-UI-UILockAim-_RefreshTarget0 = 540,
		Beyond-UI-UILockAim-_OnLockTargetFromAutoToManual0 = 541,
		Beyond-UI-UILockAim-OnRelease0 = 542,
		Beyond-UI-UILockAim-Start0 = 543,
		Beyond-UI-UILockAim-UpdateData0 = 544,
		Beyond-UI-UIMainCharFootBar-OnAwake0 = 545,
		Beyond-UI-UIMainCharFootBar-_OnDashFailed0 = 546,
		Beyond-UI-UIMainCharFootBar-_OnMainCharChange0 = 547,
		Beyond-UI-UIMainCharFootBar-_ProcessOnMainCharChange0 = 548,
		Beyond-UI-UIMainCharFootBar-_OnInteractNpc0 = 549,
		Beyond-UI-UIMainCharFootBar-_SetInDialog0 = 550,
		Beyond-UI-UIMainCharFootBar-_OnDialogStart0 = 551,
		Beyond-UI-UIMainCharFootBar-_OnDialogFinish0 = 552,
		Beyond-UI-UIMainCharFootBar-OnEnable0 = 553,
		Beyond-UI-UIMainCharFootBar-OnRelease0 = 554,
		Beyond-UI-UIMainCharFootBar-LateTick0 = 555,
		Beyond-UI-UIMainCharFootBar-_OnDashCountChanged0 = 556,
		Beyond-UI-UIMainCharFootBar-_OnOutAnimCallback0 = 557,
		Beyond-UI-UIMainCharFootBarArc-OnAwake0 = 558,
		Beyond-UI-UIMainCharFootBarArc-_OnOutAnimCallback0 = 559,
		Beyond-UI-UIMainCharFootBarArc-_OnDashFailed0 = 560,
		Beyond-UI-UIMainCharFootBarArc-_OnMainCharChange0 = 561,
		Beyond-UI-UIMainCharFootBarArc-_ProcessOnMainCharChange0 = 562,
		Beyond-UI-UIMainCharFootBarArc-_OnInteractNpc0 = 563,
		Beyond-UI-UIMainCharFootBarArc-_SetInDialog0 = 564,
		Beyond-UI-UIMainCharFootBarArc-_RefreshDisableState0 = 565,
		Beyond-UI-UIMainCharFootBarArc-_OnDialogStart0 = 566,
		Beyond-UI-UIMainCharFootBarArc-_OnDialogFinish0 = 567,
		Beyond-UI-UIMainCharFootBarArc-_OnPlayCutscene0 = 568,
		Beyond-UI-UIMainCharFootBarArc-_OnFinishCutscene0 = 569,
		Beyond-UI-UIMainCharFootBarArc-_OnForbidSystemChanged0 = 570,
		Beyond-UI-UIMainCharFootBarArc-OnEnable0 = 571,
		Beyond-UI-UIMainCharFootBarArc-OnRelease0 = 572,
		Beyond-UI-UIMainCharFootBarArc-TailLateTick0 = 573,
		Beyond-UI-UIMainCharFootBarArc-_OnDashCountChanged0 = 574,
		Beyond-UI-UIMainCharFootBarArc-SetUIDisable0 = 575,
		Beyond-UI-UIWeakLockAim-OnAwake0 = 576,
		Beyond-UI-UIWeakLockAim-_OnMainTargetChanged0 = 577,
		Beyond-UI-UIWeakLockAim-_RefreshTarget0 = 578,
		Beyond-UI-UIWeakLockAim-Start0 = 579,
		Beyond-UI-UIWeakLockAim-OnRelease0 = 580,
		Beyond-UI-BlueprintPreviewHelper-SetSize0 = 581,
		Beyond-UI-BlueprintPreviewHelper-AddGridValue0 = 582,
		Beyond-UI-BlueprintPreviewHelper-BatchAddGridValue0 = 583,
		Beyond-UI-BlueprintPreviewHelper-GetGridValue0 = 584,
		Beyond-UI-CommonTrackerNodeComp-ShowStyleType0 = 585,
		Beyond-UI-UICampfireTracker-UpdateImage0 = 586,
		Beyond-UI-UICommonTracker-UpdateImage0 = 587,
		Beyond-UI-CommonTrackerNodeComp-PlayOutAnimation0 = 588,
		Beyond-UI-CommonTrackerNodeComp-UpdatePosition0 = 589,
		Beyond-UI-UIBlackboxTracker-UpdatePosition0 = 590,
		Beyond-UI-UICampfireTracker-UpdatePosition0 = 591,
		Beyond-UI-UICommonLevelTracker-UpdatePosition0 = 592,
		Beyond-UI-UICommonTracker-UpdatePosition0 = 593,
		Beyond-UI-CommonTrackerUpdate-get__inFactoryTopView0 = 594,
		Beyond-UI-CommonTrackerUpdate-UpdateCommonTrackers0 = 595,
		Beyond-UI-CommonTrackerUpdate-_FindTrackIndexByKey0 = 596,
		Beyond-UI-CommonTrackerUpdate-_InitTrackInfoByIndex0 = 597,
		Beyond-UI-CommonTrackerUpdate-_CreateNewMissionTracker0 = 598,
		Beyond-UI-CommonTrackerUpdate-_DeleteInvalidTracker0 = 599,
		Beyond-UI-CommonTrackerUpdate-_HideTrackerGo0 = 600,
		Beyond-UI-CommonTrackerUpdate-_ShowTrackerGo0 = 601,
		Beyond-UI-CommonTrackerUpdate-AllTrackersPlayOutAnimation0 = 602,
		Beyond-UI-CoolerUnitProgressBarUI-Init0 = 603,
		Beyond-UI-WorldUIController-Init0 = 604,
		Beyond-UI-WorldUIController-TryGetNeedComponent0 = 606,
		Beyond-UI-WorldUIController-SetUIForward0 = 607,
		Beyond-UI-WorldUIController-SetPos0 = 608,
		Beyond-UI-CoolerUnitProgressBarUI-SetUIForward0 = 609,
		Beyond-UI-CoolerUnitProgressBarUI-SetPos0 = 610,
		Beyond-UI-CoolerUnitProgressBarUI-TickUI0 = 611,
		Beyond-UI-CoolerUnitProgressBarUI-_TickCanvasGroup0 = 612,
		Beyond-UI-CoolerUnitProgressBarUI-_UpdateProgress0 = 613,
		Beyond-UI-CoolerUnitTemperatureCircleUI-Init0 = 614,
		Beyond-UI-CoolerUnitTemperatureCircleUI-SetUIForward0 = 615,
		Beyond-UI-CoolerUnitTemperatureCircleUI-SetPos0 = 616,
		Beyond-UI-CoolerUnitTemperatureCircleUI-TickUI0 = 617,
		Beyond-UI-CoolerUnitTemperatureCircleUI-_TickCanvasGroup0 = 618,
		Beyond-UI-CoolerUnitTemperatureCircleUI-_SetState0 = 619,
		Beyond-UI-CoolerUnitTemperatureCircleUI-_GetLangKeyOrDefault0 = 620,
		Beyond-UI-CoolerUnitTemperatureCircleUI-_UpdateUIState0 = 621,
		Beyond-UI-CoolerUnitTemperatureUI-Init0 = 622,
		Beyond-UI-WorldUIController-Clear0 = 623,
		Beyond-UI-WorldUIController-set_uiActive0 = 624,
		Beyond-UI-CoolerUnitTemperatureUI-Clear0 = 625,
		Beyond-UI-CoolerUnitTemperatureUI-SetUIForward0 = 626,
		Beyond-UI-CoolerUnitTemperatureUI-SetPos0 = 627,
		Beyond-UI-CoolerUnitTemperatureUI-TickUI0 = 628,
		Beyond-UI-CoolerUnitTemperatureUI-_TickCanvasGroup0 = 629,
		Beyond-UI-CoolerUnitTemperatureUI-_UpdateUIInfo0 = 630,
		Beyond-UI-CoolerUnitTemperatureUI-NormalizeRange0 = 631,
		Beyond-UI-CoolerUnitTemperatureUI-_UpdateUIPos0 = 632,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_GeneratePercentStrings0 = 633,
		Beyond-UI-CoolerUnitTotalProgressBarUI-Init0 = 634,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_ResetUI0 = 635,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_GetCanvas0 = 636,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_TryGetModule0 = 637,
		Beyond-UI-CoolerUnitTotalProgressBarUI-SetUIForward0 = 638,
		Beyond-UI-CoolerUnitTotalProgressBarUI-SetPos0 = 639,
		Beyond-UI-CoolerUnitTotalProgressBarUI-TickUI0 = 640,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_TickCanvasGroup0 = 641,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_UpdateProgress0 = 642,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_SetProgressText0 = 643,
		Beyond-UI-FacLineCell-Awake0 = 644,
		Beyond-UI-FacLineCell-PlayLineAnimation0 = 645,
		Beyond-UI-FacLineCell-PlayLineDecoAnimation0 = 646,
		Beyond-UI-FacLineCell-ChangeLineColor0 = 649,
		Beyond-UI-FacLineCell-ChangeLineWidth0 = 650,
		Beyond-UI-FacLineDrawer-Awake0 = 651,
		Beyond-UI-FacLineDrawer-OnDestroy0 = 652,
		Beyond-UI-FacLineDrawer-_Clear0 = 653,
		Beyond-UI-FacLineDrawer-_CloneLineObject0 = 654,
		Beyond-UI-FacLineDrawer-_RefreshCopyLineObjectColor0 = 655,
		Beyond-UI-FacLineDrawer-ClearComponent0 = 656,
		Beyond-UI-FacLineDrawer-DrawLine0 = 657,
		Beyond-UI-FacLineDrawer-PlayLineAnimation0 = 658,
		Beyond-UI-FacLineDrawer-PlayPortLineDecoAnimation0 = 659,
		Beyond-UI-FacLineDrawer-ChangeLineColor0 = 660,
		Beyond-UI-FacLineDrawer-ClearDrawer0 = 661,
		Beyond-UI-FacRegionUpgradeEffectController-_RefreshNodeState0 = 662,
		Beyond-UI-FacRegionUpgradeEffectController-SetUpgradeState0 = 663,
		Beyond-UI-FacRegionUpgradeEffectController-SetSelectState0 = 664,
		Beyond-UI-FacRegionUpgradeEffectController-SetVisibleState0 = 665,
		Beyond-UI-UIFacTechTreePanel-OnRelease0 = 666,
		Beyond-UI-UIFacTechTreePanel-Tick0 = 667,
		Beyond-UI-UIFacTechTreePanel-_PosAdjust0 = 668,
		Beyond-UI-UIFacTechTreePanel-_UpdatePositionOffsetAfterZoomed0 = 669,
		Beyond-UI-UIFacTechTreePanel-_ControllerUpdate0 = 670,
		Beyond-UI-UIFacTechTreePanel-_ControllerZoomUpdate0 = 671,
		Beyond-UI-UIFacTechTreePanel-_OnZoom0 = 672,
		Beyond-UI-UIFacTechTreePanel-_RefreshPivotPosition0 = 673,
		Beyond-UI-UIFacTechTreePanel-_SetScale0 = 674,
		Beyond-UI-UIFacTechTreePanel-_ControllerDragUpdate0 = 675,
		Beyond-UI-UIFacTechTreePanel-InitData0 = 676,
		Beyond-UI-UIFacTechTreePanel-_OnDrag0 = 678,
		Beyond-UI-UIFacTechTreePanel-_RefreshAll0 = 680,
		Beyond-UI-UIFacTechTreePanel-MoveNode0 = 682,
		Beyond-UI-UIFacTechTreePanel-FocusNode0 = 683,
		Beyond-UI-UIFacTechTreePanel-_OnUnlockMoveNode0 = 684,
		Beyond-UI-UIFacTechTreePanel-OnUnlockTech0 = 685,
		Beyond-UI-UIFacTechTreePanel-ZoomToFullTechTree0 = 686,
		Beyond-UI-UIFacTechTreePanel-SetDetailShownState0 = 687,
		Beyond-UI-ForgeIronProgressBarUI-Init0 = 688,
		Beyond-UI-ForgeIronProgressBarUI-SetPos0 = 689,
		Beyond-UI-ForgeIronProgressBarUI-SetUIForward0 = 690,
		Beyond-UI-ForgeIronProgressBarUI-TickUI0 = 691,
		Beyond-UI-ForgeIronProgressBarUI-UpdateProgress0 = 692,
		Beyond-UI-ForgeIronTemperatureCircleUI-Init0 = 693,
		Beyond-UI-ForgeIronTemperatureCircleUI-Clear0 = 694,
		Beyond-UI-ForgeIronTemperatureCircleUI-SetPos0 = 695,
		Beyond-UI-ForgeIronTemperatureCircleUI-SetUIForward0 = 696,
		Beyond-UI-ForgeIronTemperatureCircleUI-TickUI0 = 697,
		Beyond-UI-ForgeIronTemperatureCircleUI-_SetState0 = 698,
		Beyond-UI-ForgeIronTemperatureCircleUI-UpdateUIState0 = 699,
		Beyond-UI-ForgeIronTemperatureUI-Init0 = 700,
		Beyond-UI-ForgeIronTemperatureUI-SetPos0 = 701,
		Beyond-UI-ForgeIronTemperatureUI-SetUIForward0 = 702,
		Beyond-UI-ForgeIronTemperatureUI-TickUI0 = 703,
		Beyond-UI-ForgeIronTemperatureUI-UpdateUIInfo0 = 704,
		Beyond-UI-ForgeIronTemperatureUI-UpdateUIPos0 = 705,
		Beyond-UI-GuideFakeButton-ForceToggleTargetBinding0 = 706,
		Beyond-UI-GuideFakeButton-CopyTargetBinding0 = 707,
		Beyond-UI-GuideFakeButton-_OnTriggerPlayerAction0 = 708,
		Beyond-UI-GuideFakeButton-ClearTarget0 = 709,
		Beyond-UI-GuideFakeButton-ClearBinding0 = 710,
		Beyond-UI-GuideFakeButton-_ClearOnClick0 = 711,
		Beyond-UI-GuideFakeButton-Awake0 = 712,
		Beyond-UI-GuideFakeButton-OnPointerDown0 = 713,
		Beyond-UI-GuideFakeButton-OnPointerUp0 = 714,
		Beyond-UI-GuideFakeButton-OnPointerEnter0 = 715,
		Beyond-UI-GuideFakeButton-OnPointerExit0 = 716,
		Beyond-UI-GuideFakeButton-OnPointerClick0 = 717,
		Beyond-UI-GuideFakeButton-ClearComponent0 = 718,
		Beyond-UI-RegionMap3DCfg-Load0 = 719,
		Beyond-UI-RegionMapSetting-get_cfg0 = 722,
		Beyond-UI-RegionMapSetting-OnDestroy0 = 723,
		Beyond-UI-RegionMapSetting-_ClearMaterials0 = 724,
		Beyond-UI-RegionMapSetting-_InitUI0 = 725,
		Beyond-UI-RegionMapSetting-_InitTrackIcon0 = 726,
		Beyond-UI-UIRegionMapTrackIcon-InitData0 = 727,
		Beyond-UI-RegionMapSetting-_SetMapPos0 = 728,
		Beyond-UI-RegionMapSetting-_InitPlayerIcon0 = 729,
		Beyond-UI-RegionMapSetting-_InitSelect0 = 730,
		Beyond-UI-RegionMapSetting-_RefreshMaterials0 = 731,
		Beyond-UI-RegionMapSetting-InitData0 = 732,
		Beyond-UI-RegionMapSetting-MoveToPlayer0 = 733,
		Beyond-UI-RegionMapSetting-IsCircleIntersectingRectangle0 = 734,
		Beyond-UI-RegionMapSetting-GetNodeTransform0 = 735,
		Beyond-UI-RegionMapSetting-GetNodeMoveTargetLocalPosition0 = 736,
		Beyond-UI-RegionMapSetting-GetCfg0 = 737,
		Beyond-UI-RegionMapSetting-SetLoadedRegionTransform0 = 738,
		Beyond-UI-RegionMapSetting-StartRegionRectTransformMoveRotationTween0 = 739,
		Beyond-UI-RegionMapSetting-SetControllerLevelSelectedState0 = 740,
		Beyond-UI-UIFacMainRegion-_OnMainRegionLevelChanged0 = 741,
		Beyond-UI-UIFacMainRegion-_RefreshRegionState0 = 742,
		Beyond-UI-UIFacMainRegion-OnDestroy0 = 743,
		Beyond-UI-UIFacMainRegion-ClearComponent0 = 744,
		Beyond-UI-UIFacMainRegion-InitMainRegion0 = 745,
		Beyond-UI-UILevelMapCrane-OnDestroy0 = 746,
		Beyond-UI-UILevelMapCrane-_ClearSpriteAsset0 = 747,
		Beyond-UI-UILevelMapCrane-ClearComponent0 = 748,
		Beyond-UI-UILevelMapCrane-_UnBindAll0 = 749,
		Beyond-UI-UILevelMapCrane-_OnCraneStateChanged0 = 750,
		Beyond-UI-UILevelMapCrane-_RefreshCraneState0 = 751,
		Beyond-UI-UILevelMapCrane-_BindAll0 = 752,
		Beyond-UI-UILevelMapCrane-InitCrane0 = 753,
		Beyond-UI-UILevelMapGameplayArea-_RefreshGameplayArea0 = 754,
		Beyond-UI-UILevelMapGameplayArea-Init0 = 755,
		Beyond-UI-UILevelMapGameplayArea-ClearComponent0 = 756,
		Beyond-UI-UILevelMapLimitInRect-LateTick0 = 757,
		Beyond-UI-UILevelMapLimitInRect-_LimitInRect0 = 758,
		Beyond-UI-UILevelMapLimitInRect-OnEnable0 = 759,
		Beyond-UI-UILevelMapLimitInRect-OnRelease0 = 760,
		Beyond-UI-UILevelMapLimitInRect-ClearComponent0 = 761,
		Beyond-UI-UILevelMapLimitInRect-StartLimitMarkInRect0 = 762,
		Beyond-UI-UILevelMapLimitInRect-StopLimitMarkInRect0 = 763,
		Beyond-UI-UILevelMapLimitInRect-ForceRefreshLimitState0 = 764,
		Beyond-UI-UILevelMapLine-OnEnable0 = 765,
		Beyond-UI-UILevelMapLine-_HoldLineSize0 = 766,
		Beyond-UI-UILevelMapLine-LateTick0 = 767,
		Beyond-UI-UILevelMapLine-Init0 = 768,
		Beyond-UI-UILevelMapLine-ClearComponent0 = 769,
		Beyond-UI-UILevelMapMissionArea-LateTick0 = 770,
		Beyond-UI-UILevelMapMissionArea-_DisappearIfOutRect0 = 771,
		Beyond-UI-UILevelMapMissionArea-_IsCircleOutsideDisappearRect0 = 772,
		Beyond-UI-UILevelMapMissionArea-_RefreshMissionArea0 = 773,
		Beyond-UI-UILevelMapMissionArea-Init0 = 774,
		Beyond-UI-UILevelMapMissionArea-ClearComponent0 = 775,
		Beyond-UI-UILevelMapMissionArea-ForceRefreshDisappearIfOutRect0 = 776,
		Beyond-UI-UILevelMapMisty-OnDestroy0 = 777,
		Beyond-UI-UILevelMapMisty-ClearComponent0 = 778,
		Beyond-UI-UILevelMapMisty-_UnBindAll0 = 779,
		Beyond-UI-UILevelMapMisty-_OnMistyStateChanged0 = 780,
		Beyond-UI-UILevelMapMisty-_RefreshMistyState0 = 781,
		Beyond-UI-UILevelMapMisty-IsMistyVisible0 = 782,
		Beyond-UI-UILevelMapMisty-_BindAll0 = 783,
		Beyond-UI-UILevelMapMisty-InitMisty0 = 784,
		Beyond-UI-UILevelMapSwitchBtn-InitSwitchButton0 = 785,
		Beyond-UI-UILevelMapSwitchBtn-ClearComponent0 = 788,
		Beyond-UI-UILevelMapTouchPanelWrapper-OnAwake0 = 789,
		Beyond-UI-UILevelMapTouchPanelWrapper-Tick0 = 790,
		Beyond-UI-UILevelMapTouchPanelWrapper-_CheckDrag0 = 791,
		Beyond-UI-UILevelMapTouchPanelWrapper-_IsFirstRaycastSelectable0 = 792,
		Beyond-UI-UILevelMapTouchPanelWrapper-_CheckScroll0 = 793,
		Beyond-UI-UIRegionMap3DPanel-_GetNodeTransform0 = 794,
		Beyond-UI-UIRegionMap3DPanel-_GetMoveTargetLocalPosition0 = 795,
		Beyond-UI-UIRegionMap3DPanel-_OnDoMoveTween0 = 796,
		Beyond-UI-UIRegionMap3DPanel-InitPanel0 = 797,
		Beyond-UI-UIRegionMap3DPanel-OnClickLevelBtn0 = 798,
		Beyond-UI-UIRegionMap3DPanel-OnLevelHoverChanged0 = 799,
		Beyond-UI-UISettlementRegion-OnDestroy0 = 800,
		Beyond-UI-UISettlementRegion-ClearComponent0 = 801,
		Beyond-UI-UISettlementRegion-_UnBindAll0 = 802,
		Beyond-UI-UISettlementRegion-_OnSettlementUnlocked0 = 803,
		Beyond-UI-UISettlementRegion-_RefreshSettlementRegionState0 = 804,
		Beyond-UI-UISettlementRegion-_RefreshSpriteWithTier0 = 805,
		Beyond-UI-UISettlementRegion-_BindAll0 = 806,
		Beyond-UI-UISettlementRegion-InitSettlementRegion0 = 807,
		Beyond-UI-UISettlementRegion-GetNeedRefreshSettlementRegionTier0 = 808,
		Beyond-UI-UISettlementRegion-RefreshSettlementRegionWithTier0 = 809,
		Beyond-UI-ChessboardDrop-OnDrop0 = 810,
		Beyond-UI-ChessboardDrop-_CheckEventValid0 = 811,
		Beyond-UI-ChessboardDrop-OnPointerEnter0 = 812,
		Beyond-UI-ChessboardDrop-OnPointerExit0 = 813,
		Beyond-UI-ChessboardDrop-ClearComponent0 = 814,
		Beyond-UI-ChessboardDrop-OnDestroy0 = 815,
		Beyond-UI-PuzzleCellDrag-Init0 = 816,
		Beyond-UI-PuzzleCellDrag-OnBeginDrag0 = 817,
		Beyond-UI-PuzzleDrag-OnBeginDrag0 = 818,
		Beyond-UI-PuzzleCellDrag-OnDrag0 = 819,
		Beyond-UI-PuzzleDrag-OnDrag0 = 820,
		Beyond-UI-PuzzleCellDrag-OnEndDrag0 = 821,
		Beyond-UI-PuzzleDrag-OnEndDrag0 = 822,
		Beyond-UI-PuzzleCellDrag-OnPointerDown0 = 823,
		Beyond-UI-PuzzleDrag-OnPointerDown0 = 824,
		Beyond-UI-PuzzleCellDrag-OnPointerUp0 = 825,
		Beyond-UI-PuzzleDrag-OnPointerUp0 = 826,
		Beyond-UI-PuzzleCellDrag-OnPointerClick0 = 827,
		Beyond-UI-PuzzleDrag-OnPointerClick0 = 828,
		Beyond-UI-PuzzleCellDrag-OnPointerEnter0 = 829,
		Beyond-UI-PuzzleDrag-OnPointerEnter0 = 830,
		Beyond-UI-PuzzleCellDrag-OnPointerExit0 = 831,
		Beyond-UI-PuzzleDrag-OnPointerExit0 = 832,
		Beyond-UI-PuzzleControllerHelper-get_raycastResults0 = 833,
		Beyond-UI-PuzzleControllerHelper-Awake0 = 834,
		Beyond-UI-PuzzleControllerHelper-TryGetPuzzleSlotIndexByPos0 = 835,
		Beyond-UI-PuzzleDrag-get_panel0 = 836,
		Beyond-UI-PuzzleDrag-Awake0 = 837,
		Beyond-UI-PuzzleDrag-ClearComponent0 = 838,
		Beyond-UI-PuzzleDrag-OnDestroy0 = 839,
		Beyond-UI-PuzzleDrag-SetIndex0 = 840,
		Beyond-UI-UIBrokenLine-Awake0 = 841,
		Beyond-UI-UIBrokenLine-_Init0 = 842,
		Beyond-UI-UIBrokenLine-OnDestroy0 = 843,
		Beyond-UI-UIBrokenLine-SetYValueByArray0 = 844,
		Beyond-UI-UIBrokenLine-SetYValue0 = 845,
		Beyond-UI-UICommonScanController-set_uiActive0 = 846,
		Beyond-UI-UICommonScanController-SetTarget0 = 847,
		Beyond-UI-UICommonScanController-_UpdatePos0 = 849,
		Beyond-UI-UICommonScanController-SetFixPoint0 = 850,
		Beyond-UI-UICommonScanController-Tick0 = 851,
		Beyond-UI-UICommonScanController-_FaceToCamera0 = 852,
		Beyond-UI-UICommonScanController-Clear0 = 853,
		Beyond-UI-UICountDownBar-set_update0 = 854,
		Beyond-UI-UICountDownBar-InitData0 = 855,
		Beyond-UI-UICountDownBar-_UpdateData0 = 856,
		Beyond-UI-UICountDownBar-_UpdatePos0 = 857,
		Beyond-UI-UICountDownBar-Clear0 = 858,
		Beyond-UI-UICountDownBar-LateTick0 = 859,
		Beyond-UI-UIDoodadMineCoreScanController-SyncConditonInfo0 = 860,
		Beyond-UI-UIDoodadMineCoreScanController-SetPurity0 = 861,
		Beyond-UI-UIDoodadMineCoreScanController-UpdateUI0 = 862,
		Beyond-UI-UIDoodadPlantCoreScanController-Tick0 = 863,
		Beyond-UI-UIDoodadPlantCoreScanController-_SyncTimeText0 = 864,
		Beyond-UI-UIDoodadPlantCoreScanController-SetCoreInfo0 = 865,
		Beyond-UI-UIDoodadPlantCoreScanController-SetRefreshInfo0 = 866,
		Beyond-UI-UIDoodadPlantCoreScanController-RefreshTextNow0 = 867,
		Beyond-UI-UIDoodadPlantCoreScanController-SetQuantityInfo0 = 868,
		Beyond-UI-UIDoodadPlantCoreScanController-SetSingle0 = 869,
		Beyond-UI-UIDoodadScanController-SyncRefreshInfo0 = 870,
		Beyond-UI-UIDoodadScanController-Tick0 = 871,
		Beyond-UI-UIDoodadScanController-_RefreshCountDown0 = 872,
		Beyond-UI-UIDoodadScanController-UpdateUI0 = 873,
		Beyond-UI-UIGeneralTracker-get_rect0 = 874,
		Beyond-UI-UIGeneralTracker-UpdatePosition0 = 875,
		Beyond-UI-UILiquidPoolScanController-SetWaterInfo0 = 876,
		Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateDistance0 = 877,
		Beyond-UI-UIPowerPoleAutoConnectTracker-_ActualUpdateStatus0 = 878,
		Beyond-UI-UIPowerPoleAutoConnectTracker-IconGroup-Switch0 = 879,
		Beyond-UI-UIPowerPoleAutoConnectTracker-StatusHintGroup-Switch0 = 880,
		Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateStatus0 = 881,
		Beyond-UI-UIPowerPoleAutoConnectTracker-_ActualUpdateIcon0 = 882,
		Beyond-UI-UIPowerPoleAutoConnectTracker-IconGroup-SetActiveIfNecessary0 = 883,
		Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateNodeType0 = 884,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_isDisabled0 = 885,
		Beyond-UI-UIPowerPoleFastTravelTracker-set_iconStatus0 = 886,
		Beyond-UI-UIPowerPoleFastTravelTracker-_UpdateIcon0 = 887,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageNormal0 = 888,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageNormalOther0 = 889,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageWarning0 = 890,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageHighlighted0 = 891,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageHighlightedOther0 = 892,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageDisabled0 = 893,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_animationWrapper0 = 894,
		Beyond-UI-UIPowerPoleFastTravelTracker-PlayFocus0 = 895,
		Beyond-UI-UIPowerPoleFastTravelTracker-UpdateIconStatus0 = 896,
		Beyond-UI-UIPowerPoleFastTravelTracker-UpdateStatus0 = 897,
		Beyond-UI-UIPowerPoleFastTravelTracker-UpdateIsHighlighted0 = 898,
		Beyond-UI-UIPowerPoleFastTravelTracker-UpdateIsOtherSocial0 = 899,
		Beyond-UI-UIPowerPoleFastTravelTracker-UpdateDistance0 = 900,
		Beyond-UI-UIPowerPoleFastTravelTracker-_OnStatusChanged0 = 901,
		Beyond-UI-UIPowerPoleFastTravelTracker-OnEnable0 = 902,
		Beyond-UI-UIRaceModuleRankController-_ResetData0 = 903,
		Beyond-UI-UIRaceModuleRankController-OnAwake0 = 904,
		Beyond-UI-UIRaceModuleRankController-_ShowBaseTrans0 = 905,
		Beyond-UI-UIRaceModuleRankController-_LoadAllSprite0 = 906,
		Beyond-UI-UIRaceModuleRankController-_UpdateRaceModuleRank0 = 907,
		Beyond-UI-UIRaceModuleRankController-OnRelease0 = 908,
		Beyond-UI-UIRaceModuleRankController-Tick0 = 909,
		Beyond-UI-UIVideoHelper-Reset0 = 910,
		Beyond-UI-UIVideoHelper-ResetVideo0 = 911,
		Beyond-UI-UIVideoHelper-Awake0 = 912,
		Beyond-UI-UIVideoHelper-OnEnable0 = 913,
		Beyond-UI-UIWaterDroneBar-OnAwake0 = 914,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneInfinityLiquidChanged0 = 915,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneEmptyChanged0 = 916,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneInteractiveChanged0 = 917,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneSourceTypeChanged0 = 918,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneRelaxChanged0 = 919,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneHydrantStateChanged1 = 920,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneHydrantStateChanged0 = 921,
		Beyond-UI-UIWaterDroneBar-OnEnable0 = 922,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneChange0 = 923,
		Beyond-UI-UIWaterDroneBar-_ClearWaterDrone0 = 924,
		Beyond-UI-UIWaterDroneBar-OnRelease0 = 925,
		Beyond-UI-UIWaterDroneBar-LateTick0 = 926,
		Beyond-UI-UIWaterDroneBar-_UpdateState0 = 927,
		Beyond-UI-UIWaterDroneBar-_SetIconStateController0 = 928,
		Beyond-UI-UIWaterDroneBar-_UpdateSlider0 = 929,
		Beyond-UI-WorldUIController-Tick0 = 930,
		Beyond-UI-WorldUIController-TickUI0 = 931,
		Beyond-UI-WorldUIController-OnRelease0 = 932,
		Beyond-UI-Mission-MissionHudBGSizeUpdater-LateTick0 = 933,
		Beyond-UI-Mission-MissionHudBGSizeUpdater-UpdateBgSize0 = 934
	}
}
