/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Beyond;
using Beyond.Gameplay;
using Beyond.Gameplay.Core;
using Beyond.Gameplay.Core.GameMech;
using Beyond.Gameplay.Factory;
using Beyond.GEnums;
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
using Sirenix.OdinInspector;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 26: UI.Gameplay.Beyond.dll - Assembly: UI.Gameplay.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 52406-52596
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

public class UIEquipRotHelper : TickableUIMono // TypeDefIndex: 52407
{
	// Fields
	[SerializeField]
	[Tooltip("\u5706\u76D8\u65CB\u8F6C\u4E2D\u5FC3")]
	private Transform _rotParent; // 0x68
	[SerializeField]
	[Tooltip("\u9009\u4E2D\u6001\u7684panel")]
	private Transform _rotTarget; // 0x70
	[SerializeField]
	[Tooltip("\u8BA1\u7B97\u4E0E\u9009\u4E2D\u6001\u8DDD\u79BB\u7684panel")]
	private Transform _posTarget; // 0x78
	[SerializeField]
	[Tooltip("\u8DDD\u79BB\u9009\u4E2D\u6001\u591A\u8FDC\u5F00\u59CBlerp")]
	private float _maxLength; // 0x80
	[SerializeField]
	[Tooltip("\u4E0E\u5706\u76D8\u65CB\u8F6C\u8C03\u6B63\u7684\u81EA\u8F6Croot")]
	private List<Transform> _slots; // 0x88
	[SerializeField]
	[Tooltip("\u9009\u4E2D\u6001\u7684lerp\u8282\u70B9")]
	private List<Transform> _rotRoots; // 0x90
	[SerializeField]
	[Tooltip("\u6BCF\u6B21\u65CB\u8F6Ctween\u65F6\u95F4")]
	private float _tweenTime; // 0x98
	private Vector3 m_desRot; // 0x9C
	private Vector3 m_desZero; // 0xA8
	private int m_curIndex; // 0xB4
	private int m_maxNum; // 0xB8

	// Properties
	protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	public bool playing { get; set; } // 0x0000000183D5B230-0x0000000183D5B240 0x0000000183D5B240-0x0000000183D5B250

	// Constructors
	public UIEquipRotHelper() {} // 0x0000000189B1B044-0x0000000189B1B058

	// Methods
	private Vector3 _ClampRot(Vector3 rot) => default; // 0x0000000189B1AE7C-0x0000000189B1AF04
	private Vector3 _GetNearZero(Vector3 rot) => default; // 0x0000000189B1AF04-0x0000000189B1AF60
	private void _Init() {} // 0x0000000189B1AF60-0x0000000189B1B044
	protected override void OnAwake() {} // 0x0000000189B1A778-0x0000000189B1A798
	public override void Tick(float deltaTime) {} // 0x0000000189B1A954-0x0000000189B1AE7C
	public void SelectPart(int index) {} // 0x0000000189B1A7C0-0x0000000189B1A954
	protected override void OnRelease() {} // 0x0000000189B1A798-0x0000000189B1A7C0
}

[ExecuteAlways]
public class UIWatchPanelCut : TickableUIMono // TypeDefIndex: 52408
{
	// Fields
	private Vector3 m_watchpanelPos; // 0x68
	private Vector3 m_watchpanelDir; // 0x74
	private Vector3 m_watchpanelRadius; // 0x80
	public float minimapRadius; // 0x8C
	public float eclosionRange; // 0x90

	// Properties
	protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 

	// Constructors
	public UIWatchPanelCut() {} // 0x0000000182846010-0x0000000182846020

	// Methods
	public void Start() {} // 0x000000018359F0E0-0x000000018359F170
	public Vector3 GetIntersectWithLineAndPlane(Vector3 point, Vector3 direct, Vector3 planeNormal, Vector3 planePoint) => default; // 0x0000000189B1B058-0x0000000189B1B1BC
	public override void Tick(float deltaTime) {} // 0x000000018359F170-0x000000018359F250
}

namespace Beyond.PoolCore
{
	public static class ListPoolInitializer_UI_Gameplay_Beyond // TypeDefIndex: 52410
	{
		// Fields
		private static bool s_initialized; // 0x00
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void InitializeAtRuntime() {} // 0x0000000183CB2B30-0x0000000183CB2B60
		private static void Initialize() {} // 0x0000000183CB2B60-0x0000000183CB2BE0
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 52411
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 52412
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 52413
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 52414
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 52415
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace Beyond.UI
{
	public abstract class UICharPassiveBase : MonoBehaviour // TypeDefIndex: 52416
	{
		// Constructors
		protected UICharPassiveBase() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public abstract void OnCharPassiveNumChanged(float num);
	}

	public class UICharPassiveCounter : UICharPassiveBase // TypeDefIndex: 52417
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
		public UICharPassiveCounter() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public override void OnCharPassiveNumChanged(float num) {} // 0x0000000189B1A400-0x0000000189B1A5AC
	}

	public class UICharPassiveMultiStates : UICharPassiveBase // TypeDefIndex: 52419
	{
		// Fields
		public UIStateController stateController; // 0x18
		public UIText countText; // 0x20
		public StateInfo[] states; // 0x28
		public int fullCount; // 0x30
		private int m_currentCount; // 0x34
	
		// Nested types
		[Serializable]
		public struct StateInfo // TypeDefIndex: 52418
		{
			// Fields
			public int count; // 0x00
			public string stateName; // 0x08
		}
	
		// Constructors
		public UICharPassiveMultiStates() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public override void OnCharPassiveNumChanged(float num) {} // 0x0000000182CD15E0-0x0000000182CD16E0
	}

	public class UICharPassiveZhuangfy : UICharPassiveBase // TypeDefIndex: 52420
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
		public UICharPassiveZhuangfy() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public override void OnCharPassiveNumChanged(float num) {} // 0x0000000189B1A5AC-0x0000000189B1A778
	}

	public abstract class ComboSpecialNodeBase : MonoBehaviour // TypeDefIndex: 52421
	{
		// Fields
		protected ComboSkillHint m_owner; // 0x18
	
		// Properties
		public abstract bool needTick { get; }
	
		// Constructors
		protected ComboSpecialNodeBase() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public virtual void OnAssignData(ComboSkillHint owner) {} // 0x0000000189B0D164-0x0000000189B0D1C4
		public virtual void OnReady() {} // 0x0000000189B0D204-0x0000000189B0D244
		public virtual void OnTick(float deltaTime) {} // 0x0000000189B0D284-0x0000000189B0D2D4
		public virtual void OnCast() {} // 0x0000000189B0D1C4-0x0000000189B0D204
		public virtual void OnRemove() {} // 0x0000000189B0D244-0x0000000189B0D284
		public abstract void OnRelease();
	}

	public class ComboSpecialNodeRingQte : ComboSpecialNodeBase // TypeDefIndex: 52423
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
		public override bool needTick { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Nested types
		private enum RingState // TypeDefIndex: 52422
		{
			None = 0,
			EarlyState = 1,
			PerfectState = 2,
			MissState = 3,
			PressedState = 4
		}
	
		// Constructors
		public ComboSpecialNodeRingQte() {} // 0x0000000189B0E128-0x0000000189B0E144
	
		// Methods
		public override void OnAssignData(ComboSkillHint owner) {} // 0x0000000189B0D2D4-0x0000000189B0D860
		public override void OnCast() {} // 0x0000000189B0D860-0x0000000189B0DA28
		public override void OnRemove() {} // 0x0000000189B0DB58-0x0000000189B0DBA8
		public override void OnTick(float deltaTime) {} // 0x0000000189B0DBA8-0x0000000189B0DE4C
		public override void OnRelease() {} // 0x0000000189B0DA28-0x0000000189B0DB58
		private void _OnComboSkillRingQte([IsReadOnly] in EventData<int, float, float> evtData) {} // 0x0000000189B0DF30-0x0000000189B0E09C
		private float _GetRemainTime() => default; // 0x0000000189B0DE6C-0x0000000189B0DF30
		private void _Reset() {} // 0x0000000189B0E09C-0x0000000189B0E128
		public void __iFixBaseProxy_OnAssignData(ComboSkillHint P0) {} // 0x0000000189B0DE4C-0x0000000189B0DE54
		public void __iFixBaseProxy_OnCast() {} // 0x0000000189B0DE54-0x0000000189B0DE5C
		public void __iFixBaseProxy_OnRemove() {} // 0x0000000189B0DE5C-0x0000000189B0DE64
		public void __iFixBaseProxy_OnTick(float P0) {} // 0x0000000189B0DE64-0x0000000189B0DE6C
	}

	public enum DamageTextType // TypeDefIndex: 52424
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

	public class DamageTextCtrl : UIPanelBase // TypeDefIndex: 52426
	{
		// Fields
		[Header("\u8282\u70B9\u7D22\u5F15")]
		public RectTransform content; // 0x70
		public RectTransform prefabNode; // 0x78
		[Header("\u901A\u7528\u8DF3\u5B57")]
		public Vector2 textRandomAreaSize; // 0x80
		public Vector2 textMinDist; // 0x88
		public int textPosMaxRandomTimes; // 0x90
		[Header("\u4F24\u5BB3\u8DF3\u5B57")]
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
		[Header("\u5F02\u5E38\u3001\u878D\u5408\u8DF3\u5B57")]
		public Vector2 physicalInflictionTextOffset; // 0x134
		public Vector2 spellInflictionTextOffset; // 0x13C
		private static readonly Dictionary<DamageTextType, int> PRE_LOAD_TEXT_COUNTS; // 0x00
		private const string GUARD_OVERWRITE_COALITION_KEY = "guard_overwrite"; // Metadata: 0x01FD1E74
		private const string CRYST_BREAK_TEXT_ID = "ui_bat_elemental_cryst_break"; // Metadata: 0x01FD1E84
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
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
		private static Vector3 outOfScreenPos { get => default; } // 0x0000000189B180B8-0x0000000189B18110 
	
		// Nested types
		private struct CoalitionDetail // TypeDefIndex: 52425
		{
			// Fields
			public DamageTextBase instance; // 0x00
			public float time; // 0x08
			public double value; // 0x10
		}
	
		// Constructors
		public DamageTextCtrl() {} // 0x00000001836D44B0-0x00000001836D47B0
		static DamageTextCtrl() {} // 0x00000001839BB420-0x00000001839BB5F0
	
		// Methods
		public void OnCreate() {} // 0x0000000189B149E0-0x0000000189B156DC
		public void OnClose() {} // 0x0000000189B1459C-0x0000000189B149E0
		public void DebugChangeImpl(bool disableThis) {} // 0x0000000189B13E10-0x0000000189B1459C
		public void OnShow() {} // 0x0000000189B15728-0x0000000189B1595C
		public void OnHide() {} // 0x0000000189B156DC-0x0000000189B15728
		public override void Tick(float deltaTime) {} // 0x0000000183CAC410-0x0000000183CAC4D0
		private void _OnHpChanged([IsReadOnly] in EventData<AbilitySystem.Modifier> eventData) {} // 0x0000000189B1627C-0x0000000189B177F8
		private void _OnIgniteBuffText([IsReadOnly] in EventData<AbilitySystem, Vector3, Vector2, string, EnergyShardType> eventData) {} // 0x0000000189B177F8-0x0000000189B17A9C
		private void _OnPhysicalInflictionApplied([IsReadOnly] in EventData<AbilitySystem, AbilitySystemForEnemyPart, PhysicalInflictionType> eventData) {} // 0x0000000189B17CBC-0x0000000189B17E04
		private void _OnImmuneText([IsReadOnly] in EventData<AbilitySystem, Vector3, Vector2, string> eventData) {} // 0x0000000189B17A9C-0x0000000189B17CBC
		private void _OnSquadInFightChanged([IsReadOnly] in EventData<bool> eventData) {} // 0x0000000189B17E04-0x0000000189B17EB4
		private void _OnCreateFlowText([IsReadOnly] in EventData<Vector3, string, UnityEngine.Color> eventData) {} // 0x0000000189B16148-0x0000000189B1627C
		private void _OnCharLevelUp([IsReadOnly] in EventData<ulong, int> eventData) {} // 0x0000000189B15EC4-0x0000000189B16148
		private Vector2 _GetRandomTextOffset(float width, float height) => default; // 0x0000000189B15B10-0x0000000189B15BD8
		private bool _IsTextPosValid(Vector3 newPos) => default; // 0x0000000189B15CCC-0x0000000189B15EC4
		private DamageTextBase _CreateTextInstance(DamageTextType textType) => default; // 0x0000000189B1595C-0x0000000189B15B10
		private DamageTextBase _InstantiateTextInstance(DamageTextType textType) => default; // 0x0000000189B15BD8-0x0000000189B15CCC
		private void _RecycleTextInstance(DamageTextBase textInstance) {} // 0x0000000189B17EB4-0x0000000189B180B8
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
	}

	public class DamageTextCtrlV2 : UIPanelBase // TypeDefIndex: 52429
	{
		// Fields
		[Header("\u8282\u70B9\u7D22\u5F15")]
		public GPUISystem gpuiSystem; // 0x70
		[Header("\u8DF3\u5B57\u914D\u7F6E")]
		public List<DamageTextBaseV2.DamageTextBaseConfig> damageTextConfigs; // 0x78
		public List<IgnitePrefabOverride> ignitePrefabConfig; // 0x80
		[Header("\u901A\u7528\u4F24\u5BB3\u3001\u6CBB\u7597\u8DF3\u5B57")]
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
		[Header("\u4E3B\u63A7\u4F24\u5BB3\u8DF3\u5B57")]
		public Vector2 mainChrDmgTxtSpawnOffset; // 0x118
		public Vector2 mainChrDmgTxtMoveSpawnOffset; // 0x120
		public int mainChrDmgTxtMoveNum; // 0x128
		public float mainChrDmgTxtMoveSpawnWaitTime; // 0x12C
		public float dmgTxtCoalitionMaxTime; // 0x130
		[Header("\u961F\u53CB\u4F24\u5BB3\u8DF3\u5B57")]
		public Vector2 guardDmgTxtSpawnOffset; // 0x134
		public Vector2 guardDmgTxtSpawnAreaSize; // 0x13C
		public bool enableGuardDmgTxtOverwrite; // 0x144
		[Header("\u5F02\u5E38\u8DF3\u5B57")]
		public Vector2 physicalInflictionTextOffset; // 0x148
		public Vector2 spellInflictionTextOffset; // 0x150
		private const string GUARD_OVERWRITE_COALITION_KEY = "guard_overwrite"; // Metadata: 0x01FD1EA2
		private const string CRYST_BREAK_TEXT_ID = "ui_bat_elemental_cryst_break"; // Metadata: 0x01FD1EB2
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
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
		private static Vector3 outOfScreenPos { get => default; } // 0x0000000189B13DB8-0x0000000189B13E10 
	
		// Nested types
		private struct CoalitionDetail // TypeDefIndex: 52427
		{
			// Fields
			public DamageTextBaseV2 instance; // 0x00
			public float time; // 0x08
			public double value; // 0x10
		}
	
		[Serializable]
		public class IgnitePrefabOverride // TypeDefIndex: 52428
		{
			// Fields
			public EnergyShardType energyShardType; // 0x10
			public string overrideName; // 0x18
			public bool isCrystBreak; // 0x20
	
			// Constructors
			public IgnitePrefabOverride() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public DamageTextCtrlV2() {} // 0x00000001836D47B0-0x00000001836D4B50
	
		// Methods
		public void OnCreate() {} // 0x00000001834D96C0-0x00000001834DC160
		public void OnClose() {} // 0x0000000189B10F78-0x0000000189B113BC
		public void DebugChangeImpl(bool disableThis) {} // 0x0000000189B10860-0x0000000189B10F78
		public void OnShow() {} // 0x0000000183A27B40-0x0000000183A27D50
		public void OnHide() {} // 0x0000000183D01280-0x0000000183D012B0
		public override void Tick(float deltaTime) {} // 0x0000000183C917F0-0x0000000183C918F0
		private void _OnHpChanged([IsReadOnly] in EventData<AbilitySystem.Modifier> eventData) {} // 0x0000000189B11E78-0x0000000189B134B8
		private void _OnIgniteBuffText([IsReadOnly] in EventData<AbilitySystem, Vector3, Vector2, string, EnergyShardType> eventData) {} // 0x0000000189B134B8-0x0000000189B13878
		private void _OnPhysicalInflictionApplied([IsReadOnly] in EventData<AbilitySystem, AbilitySystemForEnemyPart, PhysicalInflictionType> eventData) {} // 0x0000000189B13A70-0x0000000189B13BBC
		private void _OnImmuneText([IsReadOnly] in EventData<AbilitySystem, Vector3, Vector2, string> eventData) {} // 0x0000000189B13878-0x0000000189B13A70
		private void _OnSquadInFightChanged([IsReadOnly] in EventData<bool> eventData) {} // 0x0000000189B13BBC-0x0000000189B13C6C
		private void _OnCreateFlowText([IsReadOnly] in EventData<Vector3, string, UnityEngine.Color> eventData) {} // 0x0000000189B11D48-0x0000000189B11E78
		private void _OnCharLevelUp([IsReadOnly] in EventData<ulong, int> eventData) {} // 0x0000000189B11B00-0x0000000189B11D48
		private Vector2 _GetRandomTextOffset(float width, float height, bool useWorldOffset = false /* Metadata: 0x01FD1EA1 */, Vector3 textWorldPos = default) => default; // 0x0000000189B115D0-0x0000000189B11908
		private bool _IsTextPosValid(Vector3 newPos) => default; // 0x0000000189B11908-0x0000000189B11B00
		private DamageTextBaseV2 _CreateTextInstance(DamageTextType textType, string overrideName = null) => default; // 0x0000000189B113BC-0x0000000189B115D0
		private void _RecycleTextInstance(DamageTextBaseV2 textInstance) {} // 0x0000000189B13C6C-0x0000000189B13DB8
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
	}

	public class DamageTextBase : TickableUIMono // TypeDefIndex: 52431
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
		protected override TickType tickOption { get => default; } // 0x0000000183D567A0-0x0000000183D567B0 
		public bool isFollowingTransform { get => default; } // 0x0000000183D51D10-0x0000000183D51D20 
		public Vector3 worldPosition { get => default; } // 0x0000000189B10418-0x0000000189B104F8 
		public Vector2 uiOffset { get => default; } // 0x0000000183D76290-0x0000000183D762B0 
	
		// Nested types
		[Serializable]
		public class SpawnPointConfig // TypeDefIndex: 52430
		{
			// Fields
			public Beyond.Gameplay.Core.ObjectType objectType; // 0x10
			public bool followTarget; // 0x14
			public bool useHitPoint; // 0x15
			[Tooltip("\u5982\u679C\u9009\u62E9\u751F\u6210\u5728\u6253\u51FB\u70B9\uFF0C\u6253\u51FB\u70B9\u4E0D\u5B58\u5728\u65F6\u4E5F\u4F1A\u5728\u6B64\u9AA8\u9ABC\u751F\u6210")]
			public Beyond.Gameplay.MountPoint targetMountPoint; // 0x18
	
			// Constructors
			public SpawnPointConfig() {} // 0x0000000183D762B0-0x0000000183D762C0
		}
	
		// Constructors
		public DamageTextBase() {} // 0x0000000182846CE0-0x0000000182846E00
	
		// Methods
		protected override void OnAwake() {} // 0x0000000182BDCCC0-0x0000000182BDCD80
		protected override void OnRelease() {} // 0x0000000189B0F674-0x0000000189B0F730
		public override void TailLateTick(float deltaTime) {} // 0x0000000189B10118-0x0000000189B10194
		public void SetFollowTarget(AbilitySystem target, AbilitySystem textTargetWhenTransferred, Vector3? hitPoint) {} // 0x0000000189B0F860-0x0000000189B0FE1C
		public void SetUIOffset(Vector2 offset) {} // 0x0000000189B100B8-0x0000000189B10118
		public void Clear() {} // 0x0000000189B0F614-0x0000000189B0F674
		public virtual void SetColor(UnityEngine.Color color) {} // 0x0000000189B0F7E0-0x0000000189B0F860
		public virtual void PlayAnimation() {} // 0x0000000189B0F730-0x0000000189B0F7E0
		private void _UpdatePosition() {} // 0x0000000189B10194-0x0000000189B10418
		[IDTag(2)]
		public void SetText(string newText) {} // 0x0000000189B0FF10-0x0000000189B0FFE4
		[IDTag(1)]
		public void SetText(int newValue) {} // 0x0000000189B0FFE4-0x0000000189B100B8
		[IDTag(0)]
		public void SetText(string prefix, int newValue) {} // 0x0000000189B0FE1C-0x0000000189B0FF10
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
		public void __iFixBaseProxy_TailLateTick(float P0) {} // 0x0000000185826E68-0x0000000185826E70
	}

	public class DamageTextBaseV2 // TypeDefIndex: 52435
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
		protected UnSafeString.UnSafeStringHandle m_textHandle; // 0x58
	
		// Properties
		public ulong targetCharInst { get; set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000183D4F060-0x0000000183D4F070
		public float textNodeAlpha { get => default; } // 0x0000000189B0F524-0x0000000189B0F544 
		public float showDuration { get => default; } // 0x0000000189B0F504-0x0000000189B0F524 
		public bool isFollowingTransform { get => default; } // 0x00000001811797F0-0x0000000181179800 
		public bool isActive { get => default; } // 0x0000000189B0F4DC-0x0000000189B0F504 
		public Vector3 worldPosition { get => default; } // 0x0000000189B0F544-0x0000000189B0F614 
		public Vector2 uiOffset { get => default; } // 0x0000000183D76270-0x0000000183D76290 
	
		// Nested types
		[Serializable]
		public class SpawnPointConfig // TypeDefIndex: 52432
		{
			// Fields
			public Beyond.Gameplay.Core.ObjectType objectType; // 0x10
			public bool followTarget; // 0x14
			public bool useHitPoint; // 0x15
			[Tooltip("\u5982\u679C\u9009\u62E9\u751F\u6210\u5728\u6253\u51FB\u70B9\uFF0C\u6253\u51FB\u70B9\u4E0D\u5B58\u5728\u65F6\u4E5F\u4F1A\u5728\u6B64\u9AA8\u9ABC\u751F\u6210")]
			public Beyond.Gameplay.MountPoint targetMountPoint; // 0x18
	
			// Constructors
			public SpawnPointConfig() {} // 0x0000000183D762B0-0x0000000183D762C0
		}
	
		public enum DamageTextSortingPriority // TypeDefIndex: 52433
		{
			Level0 = 0,
			Level1 = 1,
			Level2 = 2
		}
	
		[Serializable]
		public class DamageTextBaseConfig // TypeDefIndex: 52434
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
			public DamageTextBaseConfig() {} // 0x0000000183585FF0-0x0000000183586150
		}
	
		// Constructors
		public DamageTextBaseV2() {} // Dummy constructor
		public DamageTextBaseV2(GPUISystem uiSystem) {} // 0x0000000189B0F4A8-0x0000000189B0F4DC
		static DamageTextBaseV2() {} // 0x0000000189B0F468-0x0000000189B0F4A8
	
		// Methods
		public void OnRelease() {} // 0x0000000189B0E358-0x0000000189B0E3BC
		public void Assign(DamageTextBaseConfig config, string overrideName = null) {} // 0x0000000189B0E144-0x0000000189B0E2A0
		public void Tick(Vector2 screenCenter, float scaleFactor) {} // 0x0000000189B0F218-0x0000000189B0F294
		public void SetFollowTarget(AbilitySystem target, AbilitySystem textTargetWhenTransferred, Vector3? hitPoint) {} // 0x0000000189B0E5F8-0x0000000189B0EB7C
		public void SetUIOffset(Vector2 offset) {} // 0x0000000189B0F1BC-0x0000000189B0F218
		public void Clear() {} // 0x0000000189B0E2A0-0x0000000189B0E2FC
		public void DestroyDisplay() {} // 0x0000000189B0E2FC-0x0000000189B0E358
		public virtual void SetColor(UnityEngine.Color color) {} // 0x0000000189B0E44C-0x0000000189B0E5F8
		public virtual void PlayAnimation(bool isLeft = true /* Metadata: 0x01FD1ECF */) {} // 0x0000000189B0E3BC-0x0000000189B0E44C
		private void _UpdatePosition(Vector2 screenCenter, float scaleFactor) {} // 0x0000000189B0F294-0x0000000189B0F468
		[IDTag(2)]
		public void SetText(string newText) {} // 0x0000000189B0EFB4-0x0000000189B0F1BC
		[IDTag(1)]
		public void SetText(int newValue) {} // 0x0000000189B0EDAC-0x0000000189B0EFB4
		[IDTag(0)]
		public void SetText(string prefix, int newValue) {} // 0x0000000189B0EB7C-0x0000000189B0EDAC
	}

	public class DamageTextBlock : DamageTextDamageBase // TypeDefIndex: 52436
	{
		// Fields
		public UIImage blockIcon; // 0xC0
	
		// Constructors
		public DamageTextBlock() {} // 0x0000000183CB5C70-0x0000000183CB5C80
	
		// Methods
		public override void SetColor(UnityEngine.Color color) {} // 0x0000000189B104F8-0x0000000189B1059C
		public void __iFixBaseProxy_SetColor(UnityEngine.Color P0) {} // 0x0000000189B1059C-0x0000000189B105BC
	}

	public class DamageTextCriticalLevel0 : DamageTextDamageBase // TypeDefIndex: 52437
	{
		// Fields
		public UIText criticalIcon; // 0xC0
	
		// Constructors
		public DamageTextCriticalLevel0() {} // 0x0000000183CB5C70-0x0000000183CB5C80
	
		// Methods
		public override void SetColor(UnityEngine.Color color) {} // 0x0000000189B105BC-0x0000000189B10658
		public void __iFixBaseProxy_SetColor(UnityEngine.Color P0) {} // 0x0000000189B1059C-0x0000000189B105BC
	}

	public class DamageTextCriticalLevel1 : DamageTextDamageBase // TypeDefIndex: 52438
	{
		// Fields
		public UIText criticalIcon; // 0xC0
		public UIText criticalIconShadow; // 0xC8
		public UIImage bg01; // 0xD0
		public UIImage bg02; // 0xD8
		private const string ANIM_NAME_CRITICAL_LEFT = "battletext_critical_left"; // Metadata: 0x01FD1ED3
		private const string ANIM_NAME_CRITICAL_RIGHT = "battletext_critical_right"; // Metadata: 0x01FD1EEC
	
		// Constructors
		public DamageTextCriticalLevel1() {} // 0x0000000183CB5C70-0x0000000183CB5C80
	
		// Methods
		public override void SetColor(UnityEngine.Color color) {} // 0x0000000189B10748-0x0000000189B10858
		public override void PlayAnimation(bool isLeft) {} // 0x0000000189B10658-0x0000000189B10748
		public void __iFixBaseProxy_SetColor(UnityEngine.Color P0) {} // 0x0000000189B1059C-0x0000000189B105BC
		public void __iFixBaseProxy_PlayAnimation(bool P0) {} // 0x0000000189B10858-0x0000000189B10860
	}

	public class DamageTextDamageBase : DamageTextBase // TypeDefIndex: 52439
	{
		// Constructors
		public DamageTextDamageBase() {} // 0x0000000183CB5C70-0x0000000183CB5C80
	
		// Methods
		public virtual void PlayAnimation(bool isLeft) {} // 0x0000000189B18110-0x0000000189B181C4
	}

	public class DamageTextIgniteBuff : DamageTextBase // TypeDefIndex: 52440
	{
		// Fields
		public UIImage bg; // 0xC0
		public UIText textDuplication; // 0xC8
		public UIStateController stateController; // 0xD0
	
		// Constructors
		public DamageTextIgniteBuff() {} // 0x0000000183CB5C70-0x0000000183CB5C80
	
		// Methods
		protected override void OnAwake() {} // 0x0000000182BDCBE0-0x0000000182BDCC90
		protected override void OnRelease() {} // 0x0000000189B181C4-0x0000000189B18278
		public void SetUIState(EnergyShardType energyShardType, bool isCrystBreak = false /* Metadata: 0x01FD1F06 */) {} // 0x0000000189B18378-0x0000000189B184BC
		public void SetTextAndDuplication(string newText) {} // 0x0000000189B18278-0x0000000189B18378
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000189B184BC-0x0000000189B184C4
		public void __iFixBaseProxy_OnRelease() {} // 0x0000000189B184C4-0x0000000189B184CC
	}

	public class DamageTextLevelUp : DamageTextBase // TypeDefIndex: 52441
	{
		// Properties
		public ulong targetCharInst { get; set; } // 0x0000000183D50E60-0x0000000183D50E70 0x0000000183D50F30-0x0000000183D50F40
	
		// Constructors
		public DamageTextLevelUp() {} // 0x0000000183CB5C70-0x0000000183CB5C80
	}

	public class DamageTextNormalLevel1 : DamageTextDamageBase // TypeDefIndex: 52442
	{
		// Fields
		private const string ANIM_NAME_NORMAL_LEFT = "battletext_normal_left"; // Metadata: 0x01FD1F07
		private const string ANIM_NAME_NORMAL_RIGHT = "battletext_normal_right"; // Metadata: 0x01FD1F1E
	
		// Constructors
		public DamageTextNormalLevel1() {} // 0x0000000183CB5C70-0x0000000183CB5C80
	
		// Methods
		public override void PlayAnimation(bool isLeft) {} // 0x0000000189B184CC-0x0000000189B185BC
		public void __iFixBaseProxy_PlayAnimation(bool P0) {} // 0x0000000189B10858-0x0000000189B10860
	}

	public class FootBarDashCell : MonoBehaviour // TypeDefIndex: 52443
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
		private const int MAX_DASH_COUNT_IN_RING = 8; // Metadata: 0x01FD1F36
		private const float FILL_AMOUNT_PER_CELL = 0.125f; // Metadata: 0x01FD1F37
		private const float ANGLE_PER_CELL = 45f; // Metadata: 0x01FD1F3B
		private const float ANGLE_PER_HALF_CELL = 22.5f; // Metadata: 0x01FD1F3F
		private const float ANGLE_PER_QUARTER_CELL = 11.25f; // Metadata: 0x01FD1F43
	
		// Constructors
		public FootBarDashCell() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void SetIndex(int index) {} // 0x0000000189B1870C-0x0000000189B187CC
		public void SetDashCount(float dashFillCount) {} // 0x0000000189B185BC-0x0000000189B1870C
		public void StartPlayNotEnoughAnim() {} // 0x0000000189B187CC-0x0000000189B18878
		public void StopPlayNotEnoughAnim() {} // 0x0000000189B18878-0x0000000189B18924
	}

	public class HeadBarCtrl : UIPanelBase // TypeDefIndex: 52449
	{
		// Fields
		[SerializeField]
		private GameObject _mobHeadBarPrefab; // 0x70
		[SerializeField]
		private GameObject _eliteHeadBarPrefab; // 0x78
		[SerializeField]
		private GameObject _enemyPartHeadBarPrefab; // 0x80
		[SerializeField]
		private GameObject _levelInfoBarPrefab; // 0x88
		[SerializeField]
		private GameObject _vigilanceBarPrefab; // 0x90
		[SerializeField]
		private GameObject _tacticalItemBarPrefab; // 0x98
		[SerializeField]
		private float _hideHeadBarNotInFightDelay; // 0xA0
		[SerializeField]
		private int _headBarInvisibleEnemyCount; // 0xA4
		[SerializeField]
		private float _headBarInvisibleHpNoChangeTime; // 0xA8
		[SerializeField]
		private float _headBarInvisibleScreenEdgeRatio; // 0xAC
		[SerializeField]
		private float _headBarInvisibleDistance; // 0xB0
		private const float TICK_SURROUNDING_INTERVAL = 0.2f; // Metadata: 0x01FD1F4A
		private const string HEAD_BAR_BROKEN_ANIM = "headbar_broken_in"; // Metadata: 0x01FD1F4E
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
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
		private bool forceHide { get => default; } // 0x0000000182404DB0-0x0000000182404E10 
	
		// Nested types
		public enum HeadBarType // TypeDefIndex: 52444
		{
			Mob = 0,
			Elite = 1,
			EnemyPart = 2,
			CNT = 3
		}
	
		private enum HeadBarRefreshReason // TypeDefIndex: 52445
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
	
		// Constructors
		public HeadBarCtrl() {} // 0x00000001832B6760-0x00000001832B6C70
		static HeadBarCtrl() {} // 0x00000001832B6C70-0x00000001832B6E00
	
		// Methods
		public void OnCreate(Transform worldObjectRoot) {} // 0x00000001834D9110-0x00000001834D95C0
		public void OnClose() {} // 0x0000000189B18924-0x0000000189B19768
		public void OnShow() {} // 0x0000000182404770-0x0000000182404DB0
		public void OnHide() {} // 0x0000000183D07AC0-0x0000000183D07AF0
		public override void LateTick(float deltaTime) {} // 0x0000000182404E10-0x0000000182404E90
		private void _OnAddHeadBar([IsReadOnly] in EventData<AbilitySystem> eventData) {} // 0x0000000189B19988-0x0000000189B199E8
		private void _OnRemoveHeadBar([IsReadOnly] in EventData<AbilitySystem, bool> eventData) {} // 0x0000000182402820-0x0000000182402860
		private void _OnHeadBarShowConfigChanged() {} // 0x0000000189B19BDC-0x0000000189B19C30
		private void _OnHpChanged([IsReadOnly] in EventData<AbilitySystem.Modifier> eventData) {} // 0x0000000189B19C30-0x0000000189B1A338
		private void _OnEnemyPartEnableChanged([IsReadOnly] in EventData<AbilitySystemForEnemyPart, bool> eventData) {} // 0x0000000189B19AD0-0x0000000189B19BDC
		private void _RefreshHeadBar(HeadBarRefreshReason reason) {} // 0x0000000182402860-0x0000000182404770
		private void _PrewarmHeadBar() {} // 0x00000001834D8360-0x00000001834D8B90
		private static HeadBarType _GetHeadBarType(ObjectPtr<AbilitySystem> abilitySystemPtr) => default; // 0x0000000189B197A0-0x0000000189B19988
		private void _UpdateHeadBar(float deltaTime) {} // 0x0000000182405080-0x0000000182406410
		private void _UpdateLevelInfoBar(float deltaTime) {} // 0x0000000182406780-0x0000000182407690
		private void _UpdateVigilanceBar(float deltaTime) {} // 0x0000000182407690-0x00000001824083E0
		private void _UpdateTacticalItemBar(float deltaTime) {} // 0x0000000182408640-0x0000000182409570
		private void _UpdateSurroundingEnemies(float deltaTime) {} // 0x0000000182404E90-0x0000000182405080
		private T _CreateBar<T>(HeadBarType headBarType = HeadBarType.Mob /* Metadata: 0x01FD1F47 */)
			where T : UIAbilityTargetFollower => default;
		private void _RecycleBar<T>(T bar)
			where T : UIAbilityTargetFollower {}
		private List<T> _GetBarPool<T>(HeadBarType headBarType = HeadBarType.Mob /* Metadata: 0x01FD1F48 */)
			where T : UIAbilityTargetFollower => default;
		private GameObject _GetBarPrefab<T>(HeadBarType headBarType = HeadBarType.Mob /* Metadata: 0x01FD1F49 */)
			where T : UIAbilityTargetFollower => default;
		private void _OnInteractNpc([IsReadOnly] in EventData<string, Entity> eventData) {} // 0x0000000189B1A338-0x0000000189B1A3A8
		private void _OnDialogStart([IsReadOnly] in EventData<bool, DialogEnums.DialogType> eventData) {} // 0x0000000189B19A58-0x0000000189B19AD0
		private void _OnDialogFinish([IsReadOnly] in EventData<bool> eventData) {} // 0x0000000189B199E8-0x0000000189B19A58
		private void _SetInDialog(bool inDialog) {} // 0x0000000189B1A3A8-0x0000000189B1A400
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	[Serializable]
	public class HpChangeDisplayData // TypeDefIndex: 52450
	{
		// Fields
		[Tooltip("\u4F18\u5148\u7EA7\uFF0C\u6389\u8840\u671F\u95F4\u53C8\u89E6\u53D1\u5176\u4ED6\u6389\u8840\u65F6\uFF0C\u7528\u8C01\u7684stay time\u548Cdecrease time\uFF0C\u8D8A\u9AD8\u8D8A\u4F18\u5148")]
		public int priority; // 0x10
		[Tooltip("\u6B64\u4F18\u5148\u7EA7\u7684\u6700\u5C0F\u4F24\u5BB3\u8303\u56F4(\u6700\u5927\u751F\u547D\u767E\u5206\u6BD4)")]
		public float minDamagePercent; // 0x14
		[Tooltip("\u6B64\u4F18\u5148\u7EA7\u7684\u6700\u5927\u4F24\u5BB3\u8303\u56F4(\u6700\u5927\u751F\u547D\u767E\u5206\u6BD4)")]
		public float maxDamagePercent; // 0x18
		[Tooltip("\u767D\u6761\u7EF4\u6301\u4E0D\u52A8\u7684\u65F6\u95F4")]
		public float stayTime; // 0x1C
		[Tooltip("\u767D\u6761\u6D88\u9000\u7684\u901F\u5EA6(\u8840\u91CF\u767E\u5206\u6BD4/\u79D2)")]
		public float decreaseSpeed; // 0x20
	
		// Constructors
		public HpChangeDisplayData() {} // 0x000000018350B670-0x000000018350B680
	}

	public class UIHeadBar : MonoBehaviour // TypeDefIndex: 52452
	{
		// Fields
		[SerializeField]
		private bool _showHpNumber; // 0x18
		[SerializeField]
		private bool _showHpChangeEffect; // 0x19
		[SerializeField]
		private List<HpChangeDisplayData> _hpChangeConfig; // 0x20
		[SerializeField]
		private bool _hidePoiseBarWhenEmpty; // 0x28
		[SerializeField]
		private bool _showPoiseChangeEffect; // 0x29
		[SerializeField]
		private List<HpChangeDisplayData> _poiseChangeConfig; // 0x30
		[SerializeField]
		private bool _highlightWhenWeakLock; // 0x38
		[SerializeField]
		private float _weakLockHighlightScale; // 0x3C
		[SerializeField]
		private float _weakLockScaleTransitionTime; // 0x40
		[SerializeField]
		private UIAnimationWrapper _barRootAnim; // 0x48
		[SerializeField]
		private CanvasGroup _lvNode; // 0x50
		[SerializeField]
		private UIText _lvText; // 0x58
		[SerializeField]
		private CanvasGroup _dangerousLvNode; // 0x60
		[SerializeField]
		private UIText _dangerousLvText; // 0x68
		[SerializeField]
		private CanvasGroup _focusHighlight; // 0x70
		[SerializeField]
		private List<UIImage> _hpFastFillList; // 0x78
		[SerializeField]
		private List<UIImage> _hpSlowFillList; // 0x80
		[SerializeField]
		private Transform _hpNumberNode; // 0x88
		[SerializeField]
		private UIText _curHpText; // 0x90
		[SerializeField]
		private UIText _maxHpText; // 0x98
		[SerializeField]
		private RectTransform _hpParentRect; // 0xA0
		[SerializeField]
		private RectTransform _hpEffectRect; // 0xA8
		[SerializeField]
		private CanvasGroup _hpEffectCanvasGroup; // 0xB0
		[SerializeField]
		private UIPoiseBar _poiseBar; // 0xB8
		[SerializeField]
		private UIWeaknessNode _weaknessBar; // 0xC0
		[SerializeField]
		private UIBuffNode _attachedBuffNode; // 0xC8
		[SerializeField]
		private UIBuffNode _normalBuffNode; // 0xD0
		private readonly LuaResourceLoader m_loader; // 0xD8
		private ObjectPtr<AbilitySystem> m_target; // 0xE0
		private bool m_hasPoise; // 0xF0
		private HpChangeDisplayData m_currentHpChangeData; // 0xF8
		private HpDisplayState m_hpDisplayState; // 0x100
		private readonly PeriodicTimer m_hpStayTimer; // 0x108
		private float? m_targetFillValue; // 0x110
		private float? m_transferToHighlightScaleTime; // 0x118
		private float? m_transferToOriginalScaleTime; // 0x120
		private Vector3 m_beforeTransferScale; // 0x128
		public const float EFFECT_OFFSET = -0.5f; // Metadata: 0x01FD1F6D
	
		// Nested types
		public enum HpDisplayState // TypeDefIndex: 52451
		{
			Normal = 0,
			Stay = 1,
			Decrease = 2
		}
	
		// Constructors
		public UIHeadBar() {} // 0x000000018369DF50-0x000000018369E020
	
		// Methods
		private void OnDestroy() {} // 0x0000000189B1E9A4-0x0000000189B1EA00
		public void OnPreWarm() {} // 0x00000001834D8BE0-0x00000001834D8C40
		public void SetTarget(AbilitySystem target) {} // 0x0000000189B1EA00-0x0000000189B1F680
		public void ShowModifierAfterSetTarget([IsReadOnly] in AbilitySystem.Modifier modifier) {} // 0x0000000189B1F680-0x0000000189B1F7A4
		public void Clear() {} // 0x0000000182B721C0-0x0000000182B72410
		public void Refresh() {} // 0x00000001839B8090-0x00000001839B8110
		private void _OnHpChange(Entity entity, double change) {} // 0x0000000189B1FCEC-0x0000000189B20038
		private void _OnForceSetHp(Entity entity) {} // 0x0000000189B1FB24-0x0000000189B1FCEC
		private void _CalculateHpChangeDisplay(AbilitySystem target, double deltaValue) {} // 0x0000000189B1F86C-0x0000000189B1FB24
		private void _UpdateHpDisplay(float deltaTime) {} // 0x0000000189B20614-0x0000000189B20950
		private void _OnPoiseChange(Entity entity, float change, bool hideUIEffect) {} // 0x0000000189B2032C-0x0000000189B203C8
		private void _OnMultiTimeWeaknessActivate(Entity entity, bool active, int count) {} // 0x0000000189B201B8-0x0000000189B2032C
		private void _OnWeaknessCountChanged(Entity entity, int total, int count) {} // 0x0000000189B203C8-0x0000000189B20494
		private void _OnMainTargetChanged([IsReadOnly] in EventData<AbilitySystem, bool> eventData) {} // 0x0000000189B20038-0x0000000189B201B8
		private void _UpdateScale(float deltaTime) {} // 0x0000000189B20950-0x0000000189B20CA4
		private void _SetImageFill(List<UIImage> imageList, float fillValue) {} // 0x0000000189B20494-0x0000000189B20614
		public void UpdateData(float deltaTime) {} // 0x0000000189B1F7A4-0x0000000189B1F86C
	}

	public class UIHeadBarFollower : UIAbilityTargetFollower // TypeDefIndex: 52453
	{
		// Fields
		public HeadBarCtrl.HeadBarType headBarType; // 0x110
		[SerializeField]
		private bool _haveGuideLine; // 0x114
		public UIAnimationWrapper anim; // 0x118
		[SerializeField]
		private UIHeadBar _headBar; // 0x120
		[SerializeField]
		private GameObject _guideLineNode; // 0x128
		[SerializeField]
		private RectTransform _guideLine; // 0x130
		[SerializeField]
		private RectTransform _followTargetEndPoint; // 0x138
		[SerializeField]
		private RectTransform _headBarEndPoint; // 0x140
		private bool m_headBarVisible; // 0x148
	
		// Properties
		protected override bool actualVisible { get => default; } // 0x0000000189B1E990-0x0000000189B1E9A4 
	
		// Constructors
		public UIHeadBarFollower() {} // 0x0000000183B3AEE0-0x0000000183B3AEF0
	
		// Methods
		public void OnPreWarm() {} // 0x00000001834D8B90-0x00000001834D8BE0
		public override void SetTarget(AbilitySystem target) {} // 0x0000000189B1E314-0x0000000189B1E3DC
		public void ShowModifierAfterSetTarget([IsReadOnly] in AbilitySystem.Modifier modifier) {} // 0x0000000189B1E3DC-0x0000000189B1E444
		public override void Clear() {} // 0x0000000182B71CE0-0x0000000182B71D30
		public void Refresh() {} // 0x0000000189B1E1E4-0x0000000189B1E274
		public void SetHeadBarVisible(bool visible) {} // 0x0000000189B1E274-0x0000000189B1E314
		protected override void UpdateData(float deltaTime) {} // 0x0000000189B1E48C-0x0000000189B1E504
		private void _UpdateGuideLine() {} // 0x0000000189B1E504-0x0000000189B1E990
		protected override Vector3 GetOriginFollowPos() => default; // 0x0000000189B1E0DC-0x0000000189B1E1E4
		public void __iFixBaseProxy_SetTarget(AbilitySystem P0) {} // 0x0000000189B1E47C-0x0000000189B1E484
		public void __iFixBaseProxy_Clear() {} // 0x0000000189B1E444-0x0000000189B1E44C
		public void __iFixBaseProxy_UpdateData(float P0) {} // 0x0000000189B1E484-0x0000000189B1E48C
		public Vector3 __iFixBaseProxy_GetOriginFollowPos() => default; // 0x0000000189B1E44C-0x0000000189B1E47C
	}

	public class UIHeadLabel : TickableUIMono // TypeDefIndex: 52459
	{
		// Fields
		[SerializeField]
		private Transform _emojiNode; // 0x68
		[SerializeField]
		private FloatingUIFitter _rootDis; // 0x70
		private string m_headLabelIcon; // 0x88
		private string m_headLabelIconOverwrite; // 0x90
		private Vector3 m_originalPosition; // 0x98
		private bool m_hasBindEvent; // 0xA4
		private bool m_hasBindTargetEvent; // 0xA5
		[SerializeField]
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
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
		public Transform iconHolder { get => default; } // 0x0000000189B20FD4-0x0000000189B21044 
		public Beyond.Gameplay.Core.ObjectType targetType { get; set; } // 0x0000000183D4EC40-0x0000000183D4EC50 0x0000000183D4ECC0-0x0000000183D4ECD0
		public ulong entityLogicId { get; set; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 0x0000000183D4EB60-0x0000000183D4EB70
		public string headLabelIcon { get => default; set {} } // 0x0000000183D4EA60-0x0000000183D4EA70 0x0000000182C73980-0x0000000182C739B0
		public string missionHeadLabelIcon { get => default; set {} } // 0x0000000183D4EA90-0x0000000183D4EAA0 0x0000000182C739B0-0x0000000182C739E0
	
		// Nested types
		public enum HeadLabelType // TypeDefIndex: 52454
		{
			Root = 0,
			Bubble = 1,
			Text = 2,
			Icon = 3,
			Count = 4
		}
	
		public enum VisibleSource // TypeDefIndex: 52455
		{
			Comp = 0,
			System = 1,
			FloatingUI = 2,
			Count = 3
		}
	
		[Serializable]
		public class HeadLabelRootData // TypeDefIndex: 52456
		{
			// Fields
			public Transform root; // 0x10
			public HeadLabelType headLabelType; // 0x18
	
			// Constructors
			public HeadLabelRootData() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public class HeadLabelRootVisibleData // TypeDefIndex: 52457
		{
			// Fields
			public Vector3 originalPosition; // 0x10
			public Dictionary<VisibleSource, bool> visibleSource; // 0x20
	
			// Properties
			public bool realVisible { get => default; } // 0x0000000182C74400-0x0000000182C74600 
	
			// Constructors
			public HeadLabelRootVisibleData() {} // 0x00000001832948D0-0x00000001832949E0
	
			// Methods
			public void Init(Vector3 position) {} // 0x0000000183294890-0x00000001832948D0
			public void UpdateVisible(VisibleSource source, bool visible) {} // 0x0000000182C73E70-0x0000000182C73EF0
		}
	
		// Constructors
		public UIHeadLabel() {} // 0x0000000182846E10-0x0000000182846F40
	
		// Methods
		private void _OnSubRootsCollectionChanged() {} // 0x0000000189B20E4C-0x0000000189B20FD4
		private void _TryInitRootData() {} // 0x00000001832937A0-0x0000000183294890
		public void SetVisibleDirty() {} // 0x0000000182C74770-0x0000000182C747A0
		private void _UpdateVisible() {} // 0x0000000182C73EF0-0x0000000182C74400
		public void SetSubRootVisible(HeadLabelType type, VisibleSource source, bool visible, bool updateNow) {} // 0x0000000182C73DA0-0x0000000182C73E70
		public void SetTarget(Entity target) {} // 0x0000000182C739E0-0x0000000182C73CA0
		private void _TryUpdateVisibleCallback() {} // 0x0000000182C757F0-0x0000000182C758C0
		private void _ClearVisibleCallback() {} // 0x0000000182C762D0-0x0000000182C763A0
		public void Clear() {} // 0x0000000182C76180-0x0000000182C762D0
		public void SetActive(bool active) {} // 0x000000018365EBB0-0x000000018365EC90
		public void ClearEmojis() {} // 0x0000000182BA2160-0x0000000182BA21E0
		private void _UpdateFloatingUIVisibleCallback() {} // 0x00000001829FD240-0x00000001829FE0F0
		private void _ClearFloatingUIVisibleCallback() {} // 0x00000001829FE8B0-0x00000001829FEF50
		private void _OnMissionTypeIconChanged([IsReadOnly] in EventData<string> data) {} // 0x0000000189B20D08-0x0000000189B20E4C
		private void _BindMissionTracking() {} // 0x0000000182C722C0-0x0000000182C72450
		private void _UnBindMissionTracking() {} // 0x0000000182C76540-0x0000000182C766C0
		private void _BindTargetEvent() {} // 0x0000000182C72450-0x0000000182C72570
		private void _UnBindTargetEvent() {} // 0x0000000182C763A0-0x0000000182C764C0
		private void _OnNpcVisibleChanged([IsReadOnly] in EventData<string> eventData) {} // 0x0000000182F0C2E0-0x0000000182F0C4D0
		private void _UpdatePos() {} // 0x000000018262C0C0-0x000000018262C570
		private void _RefreshVisible(bool bubbleRoot, bool textNode, bool iconHolderNode) {} // 0x0000000182C73CE0-0x0000000182C73DA0
		private void _TryUpdateVisible() {} // 0x000000018262C6C0-0x000000018262C9F0
		protected override void OnAwake() {} // 0x0000000183293650-0x0000000183293690
		public override void LateTick(float deltaTime) {} // 0x000000018262C5E0-0x000000018262C6C0
		protected override void OnEnable() {} // 0x00000001835EA180-0x00000001835EA200
		protected override void OnDisable() {} // 0x0000000182C764C0-0x0000000182C76540
		protected override void OnRelease() {} // 0x0000000189B20CA4-0x0000000189B20D08
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_OnDisable() {} // 0x00000001858DD8A4-0x00000001858DD8AC
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
	}

	public class UILvInfoBar : UIAbilityTargetFollower // TypeDefIndex: 52460
	{
		// Fields
		public UIAnimationWrapper anim; // 0x110
		[SerializeField]
		private Transform _lvNode; // 0x118
		[SerializeField]
		private UIText _lvText; // 0x120
		[SerializeField]
		private Transform _dangerousLvNode; // 0x128
		[SerializeField]
		private UIText _dangerousLvText; // 0x130
	
		// Constructors
		public UILvInfoBar() {} // 0x0000000183D4CD70-0x0000000183D4CD80
	
		// Methods
		public override void SetTarget(AbilitySystem target) {} // 0x0000000189B2114C-0x0000000189B213F0
		protected override Vector3 GetOriginFollowPos() => default; // 0x0000000189B21044-0x0000000189B2114C
		public void __iFixBaseProxy_SetTarget(AbilitySystem P0) {} // 0x0000000189B1E47C-0x0000000189B1E484
		public Vector3 __iFixBaseProxy_GetOriginFollowPos() => default; // 0x0000000189B1E44C-0x0000000189B1E47C
	}

	public class UIPoiseBar : MonoBehaviour // TypeDefIndex: 52462
	{
		// Fields
		[SerializeField]
		private UISlider _increaseSlider; // 0x18
		[SerializeField]
		private CanvasGroup _increaseCanvasGroup; // 0x20
		[SerializeField]
		private UISlider _decreaseSlider; // 0x28
		[SerializeField]
		private CanvasGroup _decreaseCanvasGroup; // 0x30
		[SerializeField]
		private UIPoiseKnot _poiseKnot; // 0x38
		[SerializeField]
		private Animation _poiseBreakAnim; // 0x40
		[SerializeField]
		private CanvasGroup _poiseBreakCanvasGroup; // 0x48
		[SerializeField]
		private RectTransform _poiseParentRect; // 0x50
		[SerializeField]
		private RectTransform _poiseEffectRect; // 0x58
		[SerializeField]
		private CanvasGroup _poiseEffectCanvasGroup; // 0x60
		private ObjectPtr<AbilitySystem> m_owner; // 0x68
		private bool m_isInPoiseRecovery; // 0x78
		private bool m_hidePoiseBarWhenEmpty; // 0x79
		private bool m_showPoiseChangeEffect; // 0x7A
		private List<HpChangeDisplayData> m_poiseChangeConfig; // 0x80
		private HpChangeDisplayData m_currentPoiseChangeData; // 0x88
		private PoiseDisplayState m_poiseDisplayState; // 0x90
		private readonly PeriodicTimer m_poiseStayTimer; // 0x98
		private float? m_targetFillValue; // 0xA0
		private float m_slowFillValue; // 0xA8
		private bool m_enemyPartHide; // 0xAC
		private List<UIPoiseKnot> m_poiseKnotList; // 0xB0
		private List<UIPoiseKnot> m_poiseKnotPool; // 0xB8
		private bool m_isPoiseKnotInited; // 0xC0
		public const float EFFECT_OFFSET = -0.5f; // Metadata: 0x01FD1F7D
	
		// Properties
		public AbilitySystem owner { get => default; } // 0x0000000189B22690-0x0000000189B226CC 
		public float maxPoise { get => default; } // 0x0000000189B2266C-0x0000000189B22690 
		public float realPoise { get => default; } // 0x0000000189B226CC-0x0000000189B226F4 
		private bool hidePoiseBar { get => default; } // 0x0000000189B2259C-0x0000000189B2266C 
	
		// Nested types
		public enum PoiseDisplayState // TypeDefIndex: 52461
		{
			Normal = 0,
			Stay = 1,
			Increase = 2
		}
	
		// Constructors
		public UIPoiseBar() {} // 0x000000018364CA90-0x000000018364CBA0
	
		// Methods
		public void Init(AbilitySystem owner, bool hidePoiseBarWhenEmpty, bool showPoiseChangeEffect, List<HpChangeDisplayData> poiseChangeConfig) {} // 0x0000000189B213F0-0x0000000189B21674
		public void Clear() {} // 0x0000000182B71FB0-0x0000000182B72060
		public void OnPoiseChange(Entity entity, float change, bool hideUIEffect) {} // 0x0000000189B21674-0x0000000189B21B28
		public void Refresh() {} // 0x00000001839B8110-0x00000001839B8160
		public void UpdatePoiseBar(float deltaTime) {} // 0x0000000189B21B28-0x0000000189B21C50
		private void _CalculatePoiseChangeDisplay(double deltaValue) {} // 0x0000000189B21C50-0x0000000189B21F08
		private void _UpdatePoiseDisplay(float deltaTime) {} // 0x0000000189B22360-0x0000000189B2259C
		private void _TryInitPoiseKnot(AbilitySystem owner) {} // 0x0000000189B220C0-0x0000000189B22360
		private void _ClearPoiseKnot() {} // 0x0000000182B71E00-0x0000000182B71FB0
		private UIPoiseKnot _CreatePoiseKnot() => default; // 0x0000000189B21F08-0x0000000189B220C0
	}

	public class UITacticalItemBar : UIAbilityTargetFollower // TypeDefIndex: 52463
	{
		// Fields
		[SerializeField]
		private float _castFillMin; // 0x110
		[SerializeField]
		private float _castFillMax; // 0x114
		public UIAnimationWrapper anim; // 0x118
		[SerializeField]
		private UIImage _castFill; // 0x120
		[SerializeField]
		private UIImage _itemIcon; // 0x128
		private const string UI_SPRITE_ITEM = "ItemIcon"; // Metadata: 0x01FD1F84
	
		// Constructors
		public UITacticalItemBar() {} // 0x0000000183D4D070-0x0000000183D4D090
	
		// Methods
		public override void SetTarget(AbilitySystem target) {} // 0x0000000189B226F4-0x0000000189B228E4
		protected override void UpdateData(float deltaTime) {} // 0x0000000189B228E4-0x0000000189B229B8
		public void __iFixBaseProxy_SetTarget(AbilitySystem P0) {} // 0x0000000189B1E47C-0x0000000189B1E484
		public void __iFixBaseProxy_UpdateData(float P0) {} // 0x0000000189B1E484-0x0000000189B1E48C
	}

	public class UIVigilanceBar : UIAbilityTargetFollower // TypeDefIndex: 52464
	{
		// Fields
		[SerializeField]
		private UIAnimationWrapper _vigilanceNode; // 0x110
		[SerializeField]
		private UIImage _vigilanceFill; // 0x118
		[SerializeField]
		private CanvasGroup _vigilanceDim; // 0x120
		[SerializeField]
		private CanvasGroup _vigilanceLight; // 0x128
		private bool m_isVigilanceActive; // 0x130
		private bool m_isVigilanceFull; // 0x131
	
		// Constructors
		public UIVigilanceBar() {} // 0x0000000183D4CD70-0x0000000183D4CD80
	
		// Methods
		public override void SetTarget(AbilitySystem target) {} // 0x0000000189B22C78-0x0000000189B22DEC
		public override void Clear() {} // 0x0000000189B229B8-0x0000000189B22A14
		public void Refresh() {} // 0x0000000189B22B1C-0x0000000189B22C78
		protected override void UpdateData(float deltaTime) {} // 0x0000000189B22DEC-0x0000000189B22E4C
		private void _UpdateVigilanceNode() {} // 0x0000000189B22E4C-0x0000000189B230F4
		protected override Vector3 GetOriginFollowPos() => default; // 0x0000000189B22A14-0x0000000189B22B1C
		public void __iFixBaseProxy_SetTarget(AbilitySystem P0) {} // 0x0000000189B1E47C-0x0000000189B1E484
		public void __iFixBaseProxy_Clear() {} // 0x0000000189B1E444-0x0000000189B1E44C
		public void __iFixBaseProxy_UpdateData(float P0) {} // 0x0000000189B1E484-0x0000000189B1E48C
		public Vector3 __iFixBaseProxy_GetOriginFollowPos() => default; // 0x0000000189B1E44C-0x0000000189B1E47C
	}

	public class UIWeaknessNode : MonoBehaviour // TypeDefIndex: 52465
	{
		// Fields
		public CanvasGroup weaknessCell; // 0x18
		private readonly List<CanvasGroup> m_weaknessCells; // 0x20
	
		// Constructors
		public UIWeaknessNode() {} // 0x0000000182848C10-0x0000000182848CA0
	
		// Methods
		private void Awake() {} // 0x0000000189B230F4-0x0000000189B23194
		public void SetTotalCellNum(int num) {} // 0x0000000189B23260-0x0000000189B235EC
		public void SetCurrentCellNum(int num) {} // 0x0000000189B23194-0x0000000189B23260
	}

	public class AtbCell : MonoBehaviour // TypeDefIndex: 52466
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
		public AtbCell() {} // 0x000000018426FE60-0x000000018426FE68
	}

	public class AtbNode : UIPanelBase // TypeDefIndex: 52468
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
		private const float ATB_PRESS_THRESHOLD = 0.03f; // Metadata: 0x01FD1F8D
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
		private BattleManager battleManager { get => default; } // 0x0000000189B1B870-0x0000000189B1B8A8 
		private SkillSetting skillSetting { get => default; } // 0x0000000183197D40-0x0000000183197DB0 
	
		// Constructors
		public AtbNode() {} // 0x0000000183C8AE30-0x0000000183C8AEC0
	
		// Methods
		public void OnCreate() {} // 0x0000000183197400-0x0000000183197A10
		public void OnClose() {} // 0x0000000189B1B200-0x0000000189B1B384
		public override void LateTick(float deltaTime) {} // 0x0000000183197B70-0x0000000183197D40
		public void CheckAtbLoopAnim() {} // 0x000000018373E980-0x000000018373EC50
		private void _RefreshAtbShowing() {} // 0x0000000183197A70-0x0000000183197B70
		private void _OnAtbCellOutAnimCallback() {} // 0x0000000189B1B804-0x0000000189B1B870
		public void OnInFightChanged([IsReadOnly] in EventData<bool> eventData) {} // 0x0000000189B1B7A4-0x0000000189B1B804
		public void OnGainAtb([IsReadOnly] in EventData<float> eventData) {} // 0x0000000189B1B384-0x0000000189B1B7A4
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	public class ComboSkillHint : MonoBehaviour // TypeDefIndex: 52469
	{
		// Fields
		public const string SPECIAL_NODE_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Prefabs/Battle/Widgets/ComboSkillSpecialNode/"; // Metadata: 0x01FD1F91
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
		public ComboSkillHint() {} // 0x0000000183A2D3A0-0x0000000183A2D3F0
	
		// Methods
		public void Init(ComboSkillPanel owner, int charIndex, bool isDefaultPanel) {} // 0x00000001829766D0-0x0000000182976870
		public void OnReady() {} // 0x0000000189B1B914-0x0000000189B1B97C
		public void OnCast() {} // 0x0000000189B1B8A8-0x0000000189B1B914
		public void OnTick(float deltaTime) {} // 0x0000000189B1B9E8-0x0000000189B1BA54
		public void OnRemove() {} // 0x0000000189B1B97C-0x0000000189B1B9E8
		public void Release() {} // 0x0000000189B1BA54-0x0000000189B1BAC0
		public void AssignData(AbilitySystem abilityCom) {} // 0x0000000182976540-0x00000001829766D0
		public void SetVisible(bool visible) {} // 0x0000000189B1BAC0-0x0000000189B1BB1C
	}

	public class ComboSkillPanel : UIPanelBase // TypeDefIndex: 52473
	{
		// Fields
		public const string UI_SPRITE_ROUND_CHAR_HEAD = "CharRoundIcon"; // Metadata: 0x01FD1FE8
		public UIButton buttonCast; // 0x70
		public RectTransform infoNode; // 0x78
		public ComboSkillHint[] comboSkillHints; // 0x80
		public UICustomLayoutElement customLayoutElement; // 0x88
		public UIStateController infoNodeStateController; // 0x90
		public float comboHintDisableAlpha; // 0x98
		public float comboHintFirstScale; // 0x9C
		private readonly List<int> m_charIndexList; // 0xA0
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000182102C70-0x0000000182102C80 
	
		// Constructors
		public ComboSkillPanel() {} // 0x0000000183C7FB80-0x0000000183C7FC20
	
		// Methods
		public void OnCreate(bool isDefaultPanel, bool isControllerPanel) {} // 0x0000000182976070-0x0000000182976410
		public void OnShow() {} // 0x0000000182975F90-0x0000000182975FD0
		protected override void OnRelease() {} // 0x0000000189B1BE70-0x0000000189B1C108
		public override void PreTick(float deltaTime) {} // 0x0000000189B1C108-0x0000000189B1C32C
		private void _CheckUpdate() {} // 0x0000000182CD5920-0x0000000182CD5A50
		private void _OnBattleTeamChanged() {} // 0x0000000182976410-0x0000000182976540
		private void _OnComboSkillReady([IsReadOnly] in EventData<int> eventData) {} // 0x0000000189B1C3A8-0x0000000189B1C544
		private void _OnComboSkillRemove([IsReadOnly] in EventData<int> eventData) {} // 0x0000000189B1C544-0x0000000189B1C5A8
		private void _RemoveComboSkill(int charIndex) {} // 0x0000000189B1C5A8-0x0000000189B1C758
		private void _OnComboSkillClearAll() {} // 0x0000000182CD55F0-0x0000000182CD5920
		public void CastComboSkill(PointerEventData eventData = null) {} // 0x0000000189B1BB1C-0x0000000189B1BE70
		private void _ResortSiblingIndex() {} // 0x0000000182975FD0-0x0000000182976070
		public void __iFixBaseProxy_OnRelease() {} // 0x0000000189B1C3A0-0x0000000189B1C3A8
		public void __iFixBaseProxy_PreTick(float P0) {} // 0x0000000185C99784-0x0000000185C9978C
	}

	public class HpBarComboNode : MonoBehaviour // TypeDefIndex: 52474
	{
		// Fields
		public GameObject comboCountLayout; // 0x18
		public UIText comboCountText; // 0x20
		private UIAnimationWrapper m_animationWrapper; // 0x28
		private int m_lastCount; // 0x30
		private const string COMMON_COMBO_GLOBAL_BUFF_ID = "global_buff_combo_trigger"; // Metadata: 0x01FD1FF7
	
		// Constructors
		public HpBarComboNode() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Awake() {} // 0x00000001834D8C40-0x00000001834D8E10
		private void OnDestroy() {} // 0x0000000189B1C758-0x0000000189B1C8DC
		private void _OnGlobalBuffStart([IsReadOnly] in EventData<GlobalBuff, string> eventData) {} // 0x0000000183B3E650-0x0000000183B3E6C0
		private void _OnGlobalBuffFinish([IsReadOnly] in EventData<GlobalBuff, string, GlobalBuff.FinishReason> eventData) {} // 0x0000000189B1C998-0x0000000189B1CA34
		private void _RefreshComboCount(bool isEarly = false /* Metadata: 0x01FD1FF6 */) {} // 0x00000001833F22B0-0x00000001833F23B0
		private void _AnimInCallback() {} // 0x0000000189B1C8DC-0x0000000189B1C934
		private void _AnimOutCallback() {} // 0x0000000189B1C934-0x0000000189B1C998
	}

	public class MainCharHpBar : TickableUIMono // TypeDefIndex: 52476
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
		public UIImage buffIcon; // 0xD8
		public Transform leftLayout; // 0xE0
		public Transform charPassiveNode; // 0xE8
		public GameObject ultimateProgress; // 0xF0
		public UIImage ultimateProgressFill; // 0xF8
		public float ultimateProgressFillSmoothTime; // 0x100
		public UnityEngine.Color colorDefault; // 0x104
		public UnityEngine.Color colorRed; // 0x114
		public UnityEngine.Color colorYellow; // 0x124
		public UnityEngine.Color colorBlue; // 0x134
		public UnityEngine.Color colorGreen; // 0x144
		private const string HP_BLINK_ANIM = "characterfootbar_warninginternal"; // Metadata: 0x01FD2011
		private bool m_nodeShowing; // 0x154
		private Entity m_mainChar; // 0x158
		private HpChangeDisplayData m_hpChangeConfig; // 0x160
		private UIHeadBar.HpDisplayState m_hpDisplayState; // 0x168
		private float? m_targetHpValue; // 0x16C
		private readonly PeriodicTimer m_hpStayTimer; // 0x178
		private bool m_hpBarShowing; // 0x180
		private bool m_hpBarShaking; // 0x181
		private UIAnimationWrapper m_hpVfxAnimWrapper; // 0x188
		private UIHudFadeController m_hudFadeController; // 0x190
		private static readonly HashSet<string> s_tempCurPassiveUIPrefabNames; // 0x00
		private static readonly List<string> s_tempUnusedPassiveUIPrefabNames; // 0x08
		private readonly Dictionary<string, UICharPassiveBase> m_allPassiveBases; // 0x198
		private UICharPassiveBase m_curPassiveBase; // 0x1A0
		private UIAnimationWrapper m_buffIconAnimWrapper; // 0x1A8
		private UIAnimationWrapper m_shakeAnimWrapper; // 0x1B0
		private UIAnimationWrapper m_hpWhiteAnimWrapper; // 0x1B8
		private UIAnimationWrapper m_ultimateBuffProgressAnimWrapper; // 0x1C0
		private UnSafeString.UnSafeStringHandle m_hpTextHandle; // 0x1C8
		private readonly LuaResourceLoader m_loader; // 0x1D0
		private float m_lastHpScreenEffectTime; // 0x1D8
		private bool m_ultimateProgressShowing; // 0x1DC
		private ObjectPtr<Buff> m_ultimateBuffPtr; // 0x1E0
		private float m_ultimateBuffProgressShowingFillAmount; // 0x1F0
		private float m_ultimateBuffProgressSmoothVelocity; // 0x1F4
		private readonly List<ObjectPtr<AbilitySystem>> m_ultimateBuffProgressRegisteredCharacters; // 0x1F8
		private readonly List<ObjectPtr<Buff>> m_activeUltimateBuffs; // 0x200
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
	
		// Nested types
		[Serializable]
		public struct HpScreenEffectConfig // TypeDefIndex: 52475
		{
			// Fields
			public float minHpPercent; // 0x00
			public float maxHpPercent; // 0x04
			public string effectName; // 0x08
		}
	
		// Constructors
		public MainCharHpBar() {} // 0x000000018375CFE0-0x000000018375D200
		static MainCharHpBar() {} // 0x0000000183C7AD90-0x0000000183C7AE80
	
		// Methods
		protected override void OnAwake() {} // 0x0000000182BDD880-0x0000000182BDDC10
		protected override void OnEnable() {} // 0x000000018309A0A0-0x000000018309A180
		protected override void OnRelease() {} // 0x0000000189B1CA34-0x0000000189B1CF20
		public void OnShow() {} // 0x0000000183A381C0-0x0000000183A38270
		public void OnHide() {} // 0x0000000183B5AFF0-0x0000000183B5B050
		private void _ClearMainChar() {} // 0x00000001838B8440-0x00000001838B8800
		public override void LateTick(float deltaTime) {} // 0x000000018309A240-0x000000018309A2B0
		private bool _CheckHpBarShowing() => default; // 0x000000018309A2B0-0x000000018309A310
		private void _SetHpBarShowing(bool showing, bool animate) {} // 0x000000018309A420-0x000000018309A5D0
		private void _OnMainCharChange([IsReadOnly] in EventData<SetLeaderReason, Entity, Entity> data) {} // 0x0000000189B1D498-0x0000000189B1D4FC
		private void _ProcessOnMainCharChange(Entity newMainChar) {} // 0x0000000182CB5DF0-0x0000000182CB6ED0
		private void _OnTeamChanged() {} // 0x0000000182B79FF0-0x0000000182B7AEF0
		private void _OnHpChange(Entity entity, double change) {} // 0x0000000182CB4BF0-0x0000000182CB50C0
		private void _SetHpFillAmount(float hpPct) {} // 0x0000000182CB5920-0x0000000182CB5A80
		private void _CalculateHpChangeDisplay(AbilitySystem target, double deltaValue) {} // 0x0000000182967720-0x0000000182967810
		private void _UpdateHpDisplay(float deltaTime) {} // 0x000000018309A310-0x000000018309A420
		private void _OnTakeDamage(Entity entity, bool hideMainCharHpScreenEffect) {} // 0x0000000189B1D4FC-0x0000000189B1D8D0
		private void _OnMainCharHpActiveChange() {} // 0x000000018309A5D0-0x000000018309A6D0
		private void _OnBuffChangeCharHpBarVfx(SpellInflictionOnCharType? type) {} // 0x0000000182CB5A80-0x0000000182CB5C10
		private void _HpVfxOutAnimCallback() {} // 0x0000000183D00620-0x0000000183D00680
		private void _OnCharPassiveNumChanged(float newNum) {} // 0x0000000189B1D3E0-0x0000000189B1D498
		private UICharPassiveBase _GetOrCreateCharPassiveBase(string prefabName) => default; // 0x000000018229F350-0x000000018229F6E0
		private void _OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason) {} // 0x0000000183CA8030-0x0000000183CA80F0
		private void _OnProgressBarBuffChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason) {} // 0x0000000183872300-0x00000001838723E0
		private void _OnBuffEnhanceChanged(ObjectPtr<Buff> buffPtr) {} // 0x0000000189B1D304-0x0000000189B1D3E0
		private void _BlinkBuffIcon(string spritePath) {} // 0x0000000189B1D10C-0x0000000189B1D1FC
		private void _SetUltimateBuff(ObjectPtr<Buff> buffPtr) {} // 0x0000000182CB8030-0x0000000182CB80F0
		private void _UltimateBuffProgressOutAnimCallback() {} // 0x0000000189B1DA44-0x0000000189B1DAA4
		private void _RebuildUltimateBuffTracking() {} // 0x0000000182B752F0-0x0000000182B765B0
		private bool _IsUltimateBuffValid(ObjectPtr<Buff> buffPtr) => default; // 0x0000000189B1D1FC-0x0000000189B1D304
		private ObjectPtr<Buff> _GetUltimateBuffForAbility(AbilitySystem ability) => default; // 0x0000000182CB7F40-0x0000000182CB8030
		private void _SelectUltimateBuff() {} // 0x0000000182CB6ED0-0x0000000182CB7F40
		private void _RefreshUltimateBuffProgress(float deltaTime) {} // 0x0000000189B1D8D0-0x0000000189B1DA44
		private void _SetUltimateProgressFill(float realFillAmount, float totalDuration) {} // 0x0000000189B1B1BC-0x0000000189B1B200
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	public class OutOfScreenTargetsCtrl : UIPanelBase // TypeDefIndex: 52479
	{
		// Fields
		public float ellipseXRadius; // 0x70
		public float ellipseYRadius; // 0x74
		public RectTransform main; // 0x78
		public RectTransform arrowModel; // 0x80
		private readonly List<Arrow> m_arrows; // 0x88
		private readonly List<Arrow> m_arrowsCache; // 0x90
		private readonly List<Arrow> m_arrowsWithOutAnimation; // 0x98
		private readonly List<Vector3> m_targetScrPoses; // 0xA0
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
	
		// Nested types
		private class Arrow // TypeDefIndex: 52477
		{
			// Fields
			public GameObject obj; // 0x10
			public RectTransform rect; // 0x18
			public UIAnimationWrapper anim; // 0x20
	
			// Constructors
			public Arrow() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public OutOfScreenTargetsCtrl() {} // 0x00000001839B3370-0x00000001839B34D0
	
		// Methods
		public void OnCreate() {} // 0x0000000183D00560-0x0000000183D005C0
		public void OnShow() {} // 0x0000000183A20900-0x0000000183A209E0
		public override void LateTick(float deltaTime) {} // 0x0000000182406410-0x0000000182406630
		private Arrow _CreateOneArrow() => default; // 0x0000000189B1DAA4-0x0000000189B1DCA8
		private ValueTuple<Vector2, float> _ScreenPosToUIPos(Vector3 screenPos) => default; // 0x0000000189B1DCA8-0x0000000189B1DE00
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	public class SkillButton : UIPanelBase // TypeDefIndex: 52485
	{
		// Fields
		public const string UI_SPRITE_SKILL_ICON = "SkillIcon"; // Metadata: 0x01FD2032
		private const float HIGHLIGHT_CHECK_INTERVAL = 0.1f; // Metadata: 0x01FD203C
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
		public UIButton ultimateButton; // 0x168
		public UIImage ultimateIcon; // 0x170
		public UIImage ultimateIconShadow; // 0x178
		public UIImage ultimateColorBg; // 0x180
		public UIImage uspRing; // 0x188
		public UIImage uspRingSmall; // 0x190
		public UIImage centerImage; // 0x198
		public UIImage glow01; // 0x1A0
		public UIImage outRing; // 0x1A8
		public CanvasGroup ultimateCanvasGroup; // 0x1B0
		public UIImage pressFill; // 0x1B8
		public UIAnimationWrapper ultimateButtonAnim; // 0x1C0
		public UIImage ultKeyIcon; // 0x1C8
		public Transform ultKeyHint; // 0x1D0
		public float uspFillSpeed; // 0x1D8
		public UIImage ultimateFillCompleteImage; // 0x1E0
		public GameObject ultimateBar; // 0x1E8
		public UIImage ultimateBarFill; // 0x1F0
		public float ultimateBarFillMin; // 0x1F8
		public float ultimateBarFillMax; // 0x1FC
		public UIImage ultimateCdFill; // 0x200
		public UIImage ultimateBarFillFrame; // 0x208
		public UIImage touchPressUspRing; // 0x210
		public RectTransform touchPressIndicator; // 0x218
		private int m_charIndex; // 0x220
		private Beyond.DeviceInfo.InputType m_panelType; // 0x224
		private Beyond.Gameplay.CharInfo m_charInfo; // 0x228
		private Beyond.Gameplay.Core.SkillData m_ultimateSkillData; // 0x230
		private Beyond.Gameplay.Core.SkillData m_normalSkillData; // 0x238
		private ObjectPtr<AbilitySystem> m_charAbilityPtr; // 0x240
		private Skill m_normalSkill; // 0x250
		private Skill m_ultimateSkill; // 0x258
		private bool m_isEmpty; // 0x260
		private float m_ultimatePressingTime; // 0x264
		private bool m_isDeadState; // 0x268
		private bool m_normalSkillReady; // 0x269
		private float m_lastHighlightCheckTime; // 0x26C
		private float m_uspTargetFill; // 0x270
		private UnityEngine.Color m_normalIconShadowDefaultColor; // 0x274
		private bool m_showNotRecommendState; // 0x284
		private PressHandler m_pressHandler; // 0x288
		private bool m_hasNotRecommendIcon; // 0x290
		private UIAnimationWrapper m_ultimateBarAnim; // 0x298
		private HudFadeType m_hudFadeType; // 0x2A0
		private string m_actionId; // 0x2A8
		private string m_curNormalIconName; // 0x2B0
		private string m_curUltimateIconName; // 0x2B8
		private static Action<int> s_onPressSkillButtonStart; // 0x00
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000182102C70-0x0000000182102C80 
		private SkillSetting skillSetting { get => default; } // 0x0000000189B25CB0-0x0000000189B25D14 
	
		// Nested types
		private enum PressingMode // TypeDefIndex: 52480
		{
			None = 0,
			Normal = 1,
			Ultimate = 2
		}
	
		private abstract class PressHandler // TypeDefIndex: 52481
		{
			// Fields
			protected SkillButton m_owner; // 0x10
	
			// Properties
			protected SkillSetting skillSetting { get; } // 0x0000000189B24B94-0x0000000189B24BF8 
			public virtual bool needUpdate { get; } // 0x000000018115F4C0-0x000000018115F530 
	
			// Constructors
			protected PressHandler() {} // Dummy constructor
			public PressHandler(SkillButton owner) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public abstract void OnPressStart();
			public abstract void OnUpdate(float deltaTime);
			public abstract void OnPressEnd();
			public abstract void OnPressCancel();
			public virtual void OnOtherPressSkillButtonStart() {} // 0x0000000189B24B50-0x0000000189B24B94
		}
	
		private class PressHandlerLongPress : PressHandler // TypeDefIndex: 52482
		{
			// Fields
			private PressingMode m_pressingMode; // 0x18
			private float m_pressingSkillTime; // 0x1C
	
			// Properties
			public override bool needUpdate { get => default; } // 0x000000018338DE50-0x000000018338DE60 
	
			// Constructors
			public PressHandlerLongPress() {} // Dummy constructor
			public PressHandlerLongPress(SkillButton owner) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override void OnPressStart() {} // 0x0000000189B248D0-0x0000000189B24B48
			public override void OnUpdate(float deltaTime) {} // 0x00000001833B2BC0-0x00000001833B2C30
			public override void OnPressEnd() {} // 0x0000000189B246CC-0x0000000189B248D0
			public override void OnPressCancel() {} // 0x0000000182B78970-0x0000000182B78A10
			public override void OnOtherPressSkillButtonStart() {} // 0x0000000189B24660-0x0000000189B246CC
			public void __iFixBaseProxy_OnOtherPressSkillButtonStart() {} // 0x0000000189B24B48-0x0000000189B24B50
		}
	
		private class PressHandlerIndividualUltimate : PressHandler // TypeDefIndex: 52483
		{
			// Fields
			private PressingMode m_pressingMode; // 0x18
			private float m_pressingSkillTime; // 0x1C
	
			// Properties
			public override bool needUpdate { get => default; } // 0x0000000185925600-0x0000000185925608 
	
			// Constructors
			public PressHandlerIndividualUltimate() {} // Dummy constructor
			public PressHandlerIndividualUltimate(SkillButton owner) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override void OnPressStart() {} // 0x0000000189B244D8-0x0000000189B245A0
			public override void OnUpdate(float deltaTime) {} // 0x0000000189B245A0-0x0000000189B24660
			public override void OnPressEnd() {} // 0x0000000189B243E0-0x0000000189B244D8
			public override void OnPressCancel() {} // 0x0000000189B2432C-0x0000000189B243E0
		}
	
		private class PressHandlerDrag : PressHandler // TypeDefIndex: 52484
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
			public override bool needUpdate { get => default; } // 0x0000000185925600-0x0000000185925608 
	
			// Constructors
			public PressHandlerDrag() {} // Dummy constructor
			public PressHandlerDrag(SkillButton owner) {} // 0x0000000189B24030-0x0000000189B2432C
	
			// Methods
			public override void OnPressStart() {} // 0x0000000189B239B8-0x0000000189B23BE4
			public override void OnUpdate(float deltaTime) {} // 0x0000000189B23BE4-0x0000000189B23F98
			private bool _InCancelArea() => default; // 0x0000000189B23F98-0x0000000189B24030
			public override void OnPressEnd() {} // 0x0000000189B23774-0x0000000189B239B8
			public override void OnPressCancel() {} // 0x0000000189B236AC-0x0000000189B23774
		}
	
		// Constructors
		public SkillButton() {} // 0x00000001838A12E0-0x00000001838A1370
	
		// Methods
		protected override void OnAwake() {} // 0x0000000182F67E90-0x0000000182F67F30
		protected override void OnEnable() {} // 0x0000000182B77C60-0x0000000182B77CE0
		public void Close() {} // 0x0000000189B24E54-0x0000000189B25324
		public void FirstTimeInit(int charIndex, bool isDefaultPanel, bool isControllerPanel) {} // 0x000000018341C9E0-0x000000018341D1E0
		public void RefreshSkillButton() {} // 0x0000000182B78C20-0x0000000182B797F0
		private bool _TryGetAliveAbilitySystem(out AbilitySystem abilitySys) {
			abilitySys = default;
			return default;
		} // 0x0000000189B25C44-0x0000000189B25CB0
		private bool _MustUpdate() => default; // 0x0000000189B2571C-0x0000000189B25780
		public override void PreTick(float deltaTime) {} // 0x000000018304E080-0x000000018304E1B0
		private void _InitSkillData() {} // 0x0000000182A225C0-0x0000000182A23030
		private void _UpdateMainUI(float deltaTime) {} // 0x0000000182A1F2B0-0x0000000182A1F570
		private void _CheckNormalSkillHighlight() {} // 0x0000000182A25B60-0x0000000182A25C10
		private void _SetNotRecommendState(bool active) {} // 0x0000000189B259E0-0x0000000189B25A6C
		public void OnCharacterDie() {} // 0x0000000189B25324-0x0000000189B25380
		private void _RefreshDeadState(bool anim) {} // 0x0000000182B79930-0x0000000182B799D0
		private void _SetUspFillAmount(float fillAmount) {} // 0x0000000189B25B38-0x0000000189B25C44
		private void _SetPressFillActive(bool active) {} // 0x0000000182B78B40-0x0000000182B78C20
		private void _SetPressFillAmount(float fillAmount) {} // 0x0000000189B25A6C-0x0000000189B25B38
		public void OnUspChange(Entity entity = null) {} // 0x0000000182B77CE0-0x0000000182B77E70
		private bool _CanCastSkill(Skill skill) => default; // 0x0000000189B256C0-0x0000000189B256DC
		public void CastSkill(Skill skill) {} // 0x0000000189B24BF8-0x0000000189B24E54
		public void OnPressSkillStart(PointerEventData eventData = null) {} // 0x0000000189B25434-0x0000000189B25508
		private void _OnOtherPressSkillButtonStart(int charIndex) {} // 0x0000000189B258F0-0x0000000189B25964
		public void OnPressSkillEnd(PointerEventData eventData = null) {} // 0x0000000189B25380-0x0000000189B25434
		public void OnPressCancelled() {} // 0x0000000182BF8300-0x0000000182BF8390
		private void _CastUltimateSkill() {} // 0x0000000189B256DC-0x0000000189B2571C
		public void OnPressUltimateSkillStart(PointerEventData eventData) {} // 0x0000000189B25508-0x0000000189B2560C
		public void ToggleControllerSkillIndicator(bool active) {} // 0x0000000189B2560C-0x0000000189B256C0
		private void _OnCharPotentialUnlock([IsReadOnly] in EventData<ulong, uint> eventData) {} // 0x0000000189B257FC-0x0000000189B25878
		private void _OnCharNormalSkillChange([IsReadOnly] in EventData<ulong, string> eventData) {} // 0x0000000189B25780-0x0000000189B257FC
		private void _OnSkillUpgradeSuccess([IsReadOnly] in EventData<ulong, string, int> eventData) {} // 0x0000000189B25964-0x0000000189B259E0
		private void _OnSkillButtonActiveConfigChanged() {} // 0x0000000182B799D0-0x0000000182B79BD0
		private void _OnInputActionKeyUpdated([IsReadOnly] in EventData<string> eventData) {} // 0x0000000189B25878-0x0000000189B258F0
		private void _UpdateLongPressKeyHint() {} // 0x000000018341D330-0x000000018341D480
		private void _SetGoActive(bool active) {} // 0x0000000182B79BD0-0x0000000182B79D30
		public void SetEmpty(bool isEmpty) {} // 0x000000018278AA30-0x000000018278AB20
		public void ClearBtnClick() {} // 0x0000000182BF8270-0x0000000182BF8300
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
	}

	public class SquadIcon : UIPanelBase // TypeDefIndex: 52486
	{
		// Fields
		private const string UI_CHAR_HEAD_PREFIX = "icon_"; // Metadata: 0x01FD2046
		private const string UI_SPRITE_DIR_CHAR_HEAD = "CharBattleIcon"; // Metadata: 0x01FD204C
		private const string UI_SPRITE_DIR_ITEM = "ItemIcon"; // Metadata: 0x01FD205B
		private const float HP_CHANGE_TOLERANCE = 0.0001f; // Metadata: 0x01FD2064
		public const string CHAR_PASSIVE_UI_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Prefabs/Battle/Widgets/CharPassiveUI/"; // Metadata: 0x01FD2068
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
		public UISlider hpSlider; // 0xF0
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
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
		public bool isEmpty { get; private set; } // 0x0000000183D579F0-0x0000000183D57A00 0x0000000183D762E0-0x0000000183D762F0
	
		// Constructors
		public SquadIcon() {} // 0x000000018375D200-0x000000018375D2E0
	
		// Methods
		protected override void OnAwake() {} // 0x0000000182BDDC10-0x0000000182BDDD20
		public void FirstTimeInit(int index, bool isDefaultPanel, bool isControllerPanel) {} // 0x000000018341C470-0x000000018341C9E0
		public void Close() {} // 0x0000000189B25EC0-0x0000000189B26248
		public void InitSquadIcon(bool showFixed = false /* Metadata: 0x01FD2043 */, bool showTrail = false /* Metadata: 0x01FD2044 */) {} // 0x0000000182B77E70-0x0000000182B78970
		private bool _MustUpdate() => default; // 0x0000000182409970-0x0000000182409A50
		public override void LateTick(float deltaTime) {} // 0x00000001824083E0-0x0000000182408610
		private bool _TryGetAliveAbilitySystem(out AbilitySystem abilitySys) {
			abilitySys = default;
			return default;
		} // 0x0000000189B26A78-0x0000000189B26AE4
		private void _UpdateComboSkillIcon(bool showAnim = true /* Metadata: 0x01FD2045 */) {} // 0x0000000182A213C0-0x0000000182A21580
		public void SetEmpty(bool empty) {} // 0x000000018278AB20-0x000000018278ABB0
		public void ToggleIndicator(bool isShow) {} // 0x0000000189B26600-0x0000000189B2665C
		public void InformKeyHint() {} // 0x0000000189B26248-0x0000000189B263CC
		private void _OnHpChange(Entity entity, double change) {} // 0x0000000182CB5460-0x0000000182CB57C0
		private void _SetLevelText() {} // 0x0000000182B79DE0-0x0000000182B79EA0
		private void _OnIgniteBuffText([IsReadOnly] in EventData<ulong, string, EnergyShardType> eventData) {} // 0x0000000189B26758-0x0000000189B26908
		public void OnLevelChange() {} // 0x0000000189B263CC-0x0000000189B26428
		private void _TryShowLevelUpAnim() {} // 0x000000018399EF40-0x000000018399EFE0
		public void SetDeadState(bool dead) {} // 0x0000000182B7AEF0-0x0000000182B7C240
		private void _UpdateIconAlpha() {} // 0x0000000182A29340-0x0000000182A293D0
		public bool CanSwitchToCenter(bool showTip) => default; // 0x0000000189B25D14-0x0000000189B25EC0
		public void OnPressCharIconStart(PointerEventData eventData) {} // 0x0000000189B26428-0x0000000189B265A4
		public void OnTacticalItemChange() {} // 0x0000000182B777B0-0x0000000182B77A90
		private void _UpdateTacticalItemStatus() {} // 0x00000001825C0260-0x00000001825C0760
		public void OnTeamSwitchUnlocked() {} // 0x0000000189B265A4-0x0000000189B26600
		private void _OnMainCharChange([IsReadOnly] in EventData<SetLeaderReason, Entity, Entity> data) {} // 0x0000000189B26908-0x0000000189B26A78
		private void _OnBuffChangeCharHpBarVfx(SpellInflictionOnCharType? type) {} // 0x00000001836CDC90-0x00000001836CDEB0
		private void _HpVfxOutAnimCallback() {} // 0x0000000189B266E8-0x0000000189B26758
		private void _OnCharPassiveNumChanged(float newNum) {} // 0x0000000183A37630-0x0000000183A376E0
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	public class TacticalDotCell : MonoBehaviour // TypeDefIndex: 52487
	{
		// Fields
		public UIImage dotBg; // 0x18
		public UIImage dot; // 0x20
		public UIImage dotWarning; // 0x28
		[SerializeField]
		private UIAnimationWrapper _anim; // 0x30
		[SerializeField]
		private bool _showDotWarning; // 0x38
		private bool m_markInit; // 0x39
		private bool m_isDotActive; // 0x3A
	
		// Constructors
		public TacticalDotCell() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void Init() {} // 0x0000000182B77A90-0x0000000182B77AC0
		public void SetDotActive(bool isActive, bool playAnim = true /* Metadata: 0x01FD20B7 */) {} // 0x00000001825C0830-0x00000001825C0950
		public void SetDotUsedUp(bool isUsedUp) {} // 0x00000001825C0760-0x00000001825C0830
	}

	public class UIAbnormalBuffCell : UIBuffCell // TypeDefIndex: 52488
	{
		// Fields
		[SerializeField]
		private UIImage _buffLifeTimeBar; // 0x78
		[SerializeField]
		private UIStateController _abnormalLevelState; // 0x80
	
		// Constructors
		public UIAbnormalBuffCell() {} // 0x00000001833E9BC0-0x00000001833E9BD0
	
		// Methods
		public override void OnTick(float deltaTime) {} // 0x0000000189B270D8-0x0000000189B271AC
		protected override void VisualInit(Sprite sprite) {} // 0x0000000189B27260-0x0000000189B274BC
		protected override void SetWarningState(bool isWarning) {} // 0x0000000189B271AC-0x0000000189B27248
		public void __iFixBaseProxy_OnTick(float P0) {} // 0x0000000189B27248-0x0000000189B27250
		public void __iFixBaseProxy_VisualInit(Sprite P0) {} // 0x0000000189B27258-0x0000000189B27260
		public void __iFixBaseProxy_SetWarningState(bool P0) {} // 0x0000000189B27250-0x0000000189B27258
	}

	public class UIAttachedBuffCell : UIBuffCell // TypeDefIndex: 52489
	{
		// Fields
		[SerializeField]
		private UIImage _buffIconPhantom; // 0x78
		[SerializeField]
		private UIImage _buffStackRing; // 0x80
		[SerializeField]
		private List<UIAnimationWrapper> _buffStackRingConsumeAnims; // 0x88
		[SerializeField]
		private float _stackRingFillChangeSpeed; // 0x90
		[SerializeField]
		private float _igniteFillDelay; // 0x94
		private const string BUFF_ANIM_IGNITE = "headbar_buff_cell_ignite"; // Metadata: 0x01FD20B8
		private int m_maxStackCount; // 0x98
		private float? m_targetStackRingFillAmount; // 0x9C
		private PeriodicTimer m_igniteFillDelayTimer; // 0xA8
		private bool m_isInConsumeAnim; // 0xB0
	
		// Constructors
		public UIAttachedBuffCell() {} // 0x00000001833E9BD0-0x00000001833E9C60
	
		// Methods
		protected override void DataInit(ObjectPtr<Buff> buffPtr) {} // 0x0000000189B27620-0x0000000189B27720
		public override void OnTick(float deltaTime) {} // 0x0000000189B277E4-0x0000000189B279C8
		public override void BeforePlayOutAnim() {} // 0x0000000189B274BC-0x0000000189B27620
		protected override void SetBuffIcon(Sprite sprite) {} // 0x0000000189B279C8-0x0000000189B27A48
		protected override void SetStackElementActive(bool showStackCount) {} // 0x0000000189B28008-0x0000000189B28090
		public override void SetStackCount(int stackCount, bool playAnim) {} // 0x0000000189B27A48-0x0000000189B28008
		public override void OnBuffIgnite() {} // 0x0000000189B27720-0x0000000189B277E4
		public void __iFixBaseProxy_DataInit(ObjectPtr<Buff> P0) {} // 0x0000000189B28098-0x0000000189B280B8
		public void __iFixBaseProxy_OnTick(float P0) {} // 0x0000000189B27248-0x0000000189B27250
		public void __iFixBaseProxy_BeforePlayOutAnim() {} // 0x0000000189B28090-0x0000000189B28098
		public void __iFixBaseProxy_SetBuffIcon(Sprite P0) {} // 0x0000000189B280C0-0x0000000189B280C8
		public void __iFixBaseProxy_SetStackElementActive(bool P0) {} // 0x0000000189B280D0-0x0000000189B280D8
		public void __iFixBaseProxy_SetStackCount(int P0, bool P1) {} // 0x0000000189B280C8-0x0000000189B280D0
		public void __iFixBaseProxy_OnBuffIgnite() {} // 0x0000000189B280B8-0x0000000189B280C0
	}

	public class UIBuffCell : MonoBehaviour // TypeDefIndex: 52491
	{
		// Fields
		[SerializeField]
		protected UIImage _buffIcon; // 0x18
		[SerializeField]
		protected bool _canShowStackCountText; // 0x20
		[SerializeField]
		protected GameObject _stackCountTextNode; // 0x28
		[SerializeField]
		protected UIText _buffStackCountText; // 0x30
		[SerializeField]
		protected UIAnimationWrapper _anim; // 0x38
		[SerializeField]
		protected CanvasGroup _canvasGroup; // 0x40
		[SerializeField]
		protected bool _canShowWarningBg; // 0x48
		[SerializeField]
		protected UIImage _warningBg; // 0x50
		protected ObjectPtr<Buff> m_buffPtr; // 0x58
	
		// Properties
		public ulong nextInstanceId { get; private set; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x0000000183D4F040-0x0000000183D4F050
		public string curSpritePath { get; private set; } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
		public UIAnimationWrapper anim { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public BuffData buffData { get => default; } // 0x0000000182B5D200-0x0000000182B5D250 
		public int orderPriority { get => default; } // 0x0000000182B5D1C0-0x0000000182B5D200 
		public ulong buffInstanceUid { get => default; } // 0x0000000182B5D4C0-0x0000000182B5D510 
	
		// Constructors
		public UIBuffCell() {} // 0x00000001833E9C60-0x00000001833E9CC0
	
		// Methods
		public void Init(ObjectPtr<Buff> buffPtr, LuaResourceLoader loader, Action onSpriteLoaded = null) {} // 0x0000000182B5D6F0-0x0000000182B5D8E0
		protected virtual void DataInit(ObjectPtr<Buff> buffPtr) {} // 0x0000000183CBB6D0-0x0000000183CBB700
		protected virtual void VisualInit(Sprite sprite) {} // 0x0000000182B5CCA0-0x0000000182B5CDD0
		public void Clear() {} // 0x00000001825CF3B0-0x00000001825CF420
		public virtual void BeforePlayOutAnim() {} // 0x0000000189B280D8-0x0000000189B2811C
		public virtual void OnTick(float deltaTime) {} // 0x0000000182409C10-0x0000000182409C90
		public virtual void SetVisible(bool visible) {} // 0x0000000182B5D400-0x0000000182B5D4C0
		public virtual void SetStackCount(int stackCount, bool playAnim) {} // 0x0000000183999500-0x00000001839995A0
		public virtual void OnBuffIgnite() {} // 0x0000000189B2811C-0x0000000189B28160
		protected virtual void SetBuffIcon(Sprite sprite) {} // 0x0000000183B0EFF0-0x0000000183B0F040
		protected virtual void SetStackElementActive(bool isActive) {} // 0x0000000183A29770-0x0000000183A297C0
		protected virtual void SetWarningState(bool isWarning) {} // 0x0000000183824DA0-0x0000000183824E00
	}

	public class UIBuffNode : TickableUIMono // TypeDefIndex: 52501
	{
		// Fields
		[SerializeField]
		private SerializeFieldDictionary<BuffIconConfig.BuffIconStyle, UIBuffCell> _buffStyleCellTemplateDict; // 0x68
		[SerializeField]
		private BuffNodeType _buffNodeType; // 0x70
		[SerializeField]
		private int _maxBuffCellCount; // 0x74
		private bool m_isFirstInited; // 0x78
		private readonly LuaResourceLoader m_loader; // 0x80
		private ObjectPtr<AbilitySystem> m_owner; // 0x88
		private readonly DynamicFastLookupCollection<BuffIconConfig.BuffIconStyle, BuffCellGroup> m_buffCellGroupDict; // 0x98
		private readonly DynamicFastLookupCollection<string, List<ObjectPtr<Buff>>> m_stackBuffsDict; // 0xA0
		private readonly List<UIBuffCell> m_orderedBuffCellList; // 0xA8
		private readonly HashSet<ObjectPtr<Buff>> m_addBuffIconBuffer; // 0xB0
		private const string BUFF_ANIM_STRONG_IN = "headbar_buff_cell_strong_in"; // Metadata: 0x01FD20D1
		private const string BUFF_ANIM_IGNITE_OUT = "headbar_buff_cell_ignite_out"; // Metadata: 0x01FD20ED
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D567A0-0x0000000183D567B0 
	
		// Nested types
		public enum BuffNodeType // TypeDefIndex: 52492
		{
			HeadBarCommon = 0,
			HeadBarAttached = 1,
			SquadIconCommon = 2,
			MainCharHpBarCommon = 3
		}
	
		public class BuffCellGroup // TypeDefIndex: 52493
		{
			// Fields
			public BuffIconConfig.BuffIconStyle buffIconStyle; // 0x10
			public UIBuffCell buffCellTemplate; // 0x18
			public List<UIBuffCell> buffCellPool; // 0x20
			public DynamicFastLookupCollection<ulong, UIBuffCell> buffCellDict; // 0x28
			public DynamicFastLookupCollection<ulong, UIBuffCell> buffCellWithOutAnim; // 0x30
	
			// Constructors
			public BuffCellGroup() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public UIBuffCell CreateBuffCell(Transform transform) => default; // 0x0000000182B5CDD0-0x0000000182B5CEC0
			public void RemoveBuffCell(UIBuffCell buffCell) {} // 0x0000000189B235EC-0x0000000189B236AC
			public void ClearAllBuffCells(LuaResourceLoader loader) {} // 0x0000000182B725E0-0x0000000182B726D0
		}
	
		// Constructors
		public UIBuffNode() {} // 0x00000001828464D0-0x00000001828466A0
	
		// Methods
		private void _OnFirstInit() {} // 0x00000001828466A0-0x0000000182846CE0
		public void OnPreWarm() {} // 0x00000001825CE950-0x00000001825CF3B0
		public void Init(ObjectPtr<AbilitySystem> abilitySystemPtr) {} // 0x0000000182B76950-0x0000000182B76A40
		public void Refresh() {} // 0x0000000182B73450-0x0000000182B74620
		public void Clear() {} // 0x0000000182B72410-0x0000000182B725E0
		public override void TailLateTick(float deltaTime) {} // 0x0000000182853420-0x0000000182853B30
		protected override void OnRelease() {} // 0x0000000189B28160-0x0000000189B28228
		public void OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason) {} // 0x00000001836B8E30-0x00000001836B8EC0
		private bool _IsBuffIconInThisNode(ObjectPtr<Buff> buffPtr) => default; // 0x00000001836B8F40-0x00000001836B9030
		private void _OnAddBuff(ObjectPtr<Buff> buffPtr) {} // 0x00000001836B8EC0-0x00000001836B8F40
		private void _OnRemoveBuff(ObjectPtr<Buff> buffPtr, Buff.FinishReason finishReason) {} // 0x0000000189B28504-0x0000000189B285D8
		private void _AddBuffIconInternal(ObjectPtr<Buff> buffPtr, bool playAnim) {} // 0x0000000182B5C870-0x0000000182B5CCA0
		private void _RemoveBuffIconInternal(ObjectPtr<Buff> buffPtr, Buff.FinishReason finishReason) {} // 0x0000000189B285D8-0x0000000189B28EDC
		private void _OnBuffEnhanceChanged(ObjectPtr<Buff> buffPtr) {} // 0x0000000189B28228-0x0000000189B28390
		private void _OnBuffIgnite(ObjectPtr<Buff> buffPtr) {} // 0x0000000189B28390-0x0000000189B28504
		private void _RegisterAbilityBuffEvent(AbilitySystem abilitySystem) {} // 0x0000000182B76780-0x0000000182B76950
		private void _UnregisterAbilityBuffEvent(AbilitySystem abilitySystem) {} // 0x0000000182B765B0-0x0000000182B76780
		private BuffIconConfig.BuffIconStyle _GetIconStyle(BuffData buffData) => default; // 0x0000000182B5D510-0x0000000182B5D5B0
		private void _SetBuffCellSiblingInOrder(UIBuffCell buffCell) {} // 0x0000000182B5CF70-0x0000000182B5D1C0
		private void _DealWithBuffCellVisible() {} // 0x0000000182B5CEC0-0x0000000182B5CF70
		public void __iFixBaseProxy_TailLateTick(float P0) {} // 0x0000000185826E68-0x0000000185826E70
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
	}

	public class UILifeTimeBuffCell : UIBuffCell // TypeDefIndex: 52502
	{
		// Fields
		[SerializeField]
		private UIImage _buffLifeTimeBar; // 0x78
	
		// Constructors
		public UILifeTimeBuffCell() {} // 0x00000001833E9BC0-0x00000001833E9BD0
	
		// Methods
		public override void OnTick(float deltaTime) {} // 0x0000000182409A50-0x0000000182409C10
		protected override void SetWarningState(bool isWarning) {} // 0x0000000183824D20-0x0000000183824DA0
		public void __iFixBaseProxy_OnTick(float P0) {} // 0x0000000189B27248-0x0000000189B27250
		public void __iFixBaseProxy_SetWarningState(bool P0) {} // 0x0000000189B27250-0x0000000189B27258
	}

	public class UIHudFadeBase : MonoBehaviour // TypeDefIndex: 52503
	{
		// Fields
		public UIStyleInputValidType validType; // 0x18
	
		// Properties
		protected bool globalNeedShow { get => default; } // 0x0000000182D4DA90-0x0000000182D4DAF0 
	
		// Constructors
		public UIHudFadeBase() {} // 0x0000000184276C90-0x0000000184276CA0
	}

	[RequireComponent(typeof(Animator))]
	public class UIHudFadeConsoleController : UIHudFadeBase // TypeDefIndex: 52504
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
		public UIHudFadeConsoleController() {} // 0x0000000189B296F0-0x0000000189B2975C
	
		// Methods
		private void Awake() {} // 0x0000000189B28EDC-0x0000000189B29098
		private void OnDestroy() {} // 0x0000000189B29228-0x0000000189B293BC
		public void OnShow() {} // 0x0000000189B293BC-0x0000000189B2946C
		private void _CheckNeedShow() {} // 0x0000000189B29494-0x0000000189B29634
		private void _OnFadeHud() {} // 0x0000000189B29634-0x0000000189B29684
		private void _OnInformShow([IsReadOnly] in EventData<UIStyleInputValidTypeMask> eventData) {} // 0x0000000189B29684-0x0000000189B296F0
		public void InformShow() {} // 0x0000000189B29098-0x0000000189B29228
	}

	[RequireComponent(typeof(CanvasGroup))]
	public class UIHudFadeController : UIHudFadeBase // TypeDefIndex: 52505
	{
		// Fields
		private CanvasGroup m_canvasGroup; // 0x20
		private bool m_curShowing; // 0x28
		private DG.Tweening.Sequence m_fadeSequence; // 0x30
		private readonly HashSet<string> m_hudPreventFadeState; // 0x38
	
		// Properties
		private bool needShow { get => default; } // 0x0000000182D4DA30-0x0000000182D4DA90 
		private GameplayMiscSetting setting { get => default; } // 0x0000000182D4DF40-0x0000000182D4DFB0 
	
		// Constructors
		public UIHudFadeController() {} // 0x00000001839AA420-0x00000001839AA4B0
	
		// Methods
		private void Awake() {} // 0x0000000182D4CA00-0x0000000182D4CBB0
		private void OnDestroy() {} // 0x0000000189B33958-0x0000000189B33AEC
		private void _OnFadeHud() {} // 0x0000000182D4D840-0x0000000182D4D880
		private void _CheckNeedShow() {} // 0x0000000182D4D880-0x0000000182D4DA30
		public void SetLocalNeedShow(string state, bool needShowHud) {} // 0x0000000182CB57C0-0x0000000182CB5860
		private void _OnInformShow([IsReadOnly] in EventData<UIStyleInputValidTypeMask> eventData) {} // 0x0000000189B33AEC-0x0000000189B33B58
		public void InformShow() {} // 0x0000000183D2B610-0x0000000183D2B680
	}

	[RequireComponent(typeof(UIAnimationWrapper))]
	public class UIHudFadeTouchSkill : UIHudFadeBase // TypeDefIndex: 52506
	{
		// Fields
		private UIAnimationWrapper m_animationWrapper; // 0x20
		private bool m_curShowing; // 0x28
		private bool m_animInOrLoop; // 0x29
		private DG.Tweening.Sequence m_fadeSequence; // 0x30
	
		// Constructors
		public UIHudFadeTouchSkill() {} // 0x0000000189B34458-0x0000000189B3446C
	
		// Methods
		private void Awake() {} // 0x0000000189B33B58-0x0000000189B33CF8
		private void OnDestroy() {} // 0x0000000189B33E00-0x0000000189B33F94
		public void OnShow() {} // 0x0000000189B33F94-0x0000000189B34050
		private void _CheckNeedShow() {} // 0x0000000189B341B8-0x0000000189B3439C
		private void _OnFadeHud() {} // 0x0000000189B3439C-0x0000000189B343EC
		private void _OnInformShow([IsReadOnly] in EventData<UIStyleInputValidTypeMask> eventData) {} // 0x0000000189B343EC-0x0000000189B34458
		public void InformShow() {} // 0x0000000189B33CF8-0x0000000189B33E00
	}

	public class UIAbilityTargetFollower : UIPanelBase // TypeDefIndex: 52507
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
		protected bool m_distanceVisible; // 0x10C
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D567A0-0x0000000183D567B0 
		protected virtual bool actualVisible { get => default; } // 0x0000000183D762F0-0x0000000183D76300 
		public Vector3? followPosition { get => default; } // 0x0000000189B31258-0x0000000189B31314 
	
		// Constructors
		public UIAbilityTargetFollower() {} // 0x0000000182846F40-0x0000000182846FF0
	
		// Methods
		protected override void OnAwake() {} // 0x00000001834D90A0-0x00000001834D9110
		public override void TailLateTick(float deltaTime) {} // 0x00000001837D4650-0x00000001837D46E0
		public virtual void SetTarget(AbilitySystem target) {} // 0x0000000189B3064C-0x0000000189B307E8
		public virtual void Clear() {} // 0x0000000182B71D30-0x0000000182B71E00
		protected virtual void UpdateData(float deltaTime) {} // 0x0000000183D48D10-0x0000000183D48D40
		private void _TryRefreshFollowTransform() {} // 0x0000000189B30884-0x0000000189B30958
		private void _TryRefreshHeightFollowTransform() {} // 0x0000000189B30958-0x0000000189B30A98
		private void _UpdateSelfTransform() {} // 0x0000000189B31148-0x0000000189B31258
		private void _UpdatePos() {} // 0x0000000189B30A98-0x0000000189B30F0C
		protected virtual Vector3 GetOriginFollowPos() => default; // 0x0000000189B304C0-0x0000000189B30540
		private void _UpdateScale() {} // 0x0000000189B30F0C-0x0000000189B31148
		private void _SetDistanceVisible(bool visible) {} // 0x0000000189B307E8-0x0000000189B30884
		protected void SetActualVisible(bool visible) {} // 0x0000000189B30540-0x0000000189B3064C
		protected Vector3 GetAdjustedHeightOffset(AbilitySystem target) => default; // 0x0000000189B3035C-0x0000000189B304C0
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_TailLateTick(float P0) {} // 0x0000000185826E68-0x0000000185826E70
	}

	public class UILockAim : UIAbilityTargetFollower // TypeDefIndex: 52508
	{
		// Fields
		public float showCancelProgressRatio; // 0x110
		public CanvasGroup aimGroup; // 0x118
		public UIImage aimRingImage; // 0x120
		public UIImage rotateImage; // 0x128
		public CanvasGroup breakingAttackGroup; // 0x130
		private UIAnimationWrapper m_aimGroupAnimWrapper; // 0x138
	
		// Constructors
		public UILockAim() {} // 0x0000000183D4B840-0x0000000183D4B860
	
		// Methods
		protected override void OnAwake() {} // 0x00000001834D8E10-0x00000001834D90A0
		protected override void OnRelease() {} // 0x0000000189B3446C-0x0000000189B346F4
		protected void Start() {} // 0x0000000182FE1FF0-0x0000000182FE2040
		protected override void UpdateData(float deltaTime) {} // 0x0000000183B5C140-0x0000000183B5C1E0
		private void _OnLockTargetFromAutoToManual() {} // 0x0000000189B346FC-0x0000000189B34798
		private void _RefreshTarget(AbilitySystem _ = null) {} // 0x0000000182FE2120-0x0000000182FE2270
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000189B346F4-0x0000000189B346FC
		public void __iFixBaseProxy_OnRelease() {} // 0x0000000189B1C3A0-0x0000000189B1C3A8
		public void __iFixBaseProxy_UpdateData(float P0) {} // 0x0000000189B1E484-0x0000000189B1E48C
	}

	public class UIMainCharFootBar : TickableUIMono // TypeDefIndex: 52509
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
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
	
		// Constructors
		public UIMainCharFootBar() {} // 0x0000000189B369FC-0x0000000189B36AE0
		static UIMainCharFootBar() {} // 0x0000000189B3699C-0x0000000189B369FC
	
		// Methods
		protected override void OnAwake() {} // 0x0000000189B359AC-0x0000000189B35D8C
		protected override void OnEnable() {} // 0x0000000189B35D8C-0x0000000189B35F14
		protected override void OnRelease() {} // 0x0000000189B35F14-0x0000000189B362A8
		private void _OnMainCharChange([IsReadOnly] in EventData<SetLeaderReason, Entity, Entity> data) {} // 0x0000000189B36778-0x0000000189B3681C
		private void _ProcessOnMainCharChange() {} // 0x0000000189B3686C-0x0000000189B36904
		public override void LateTick(float deltaTime) {} // 0x0000000189B3508C-0x0000000189B359AC
		private void _OnDashCountChanged(float curCount) {} // 0x0000000189B362A8-0x0000000189B3658C
		private void _OnDashFailed() {} // 0x0000000189B3658C-0x0000000189B36644
		private void _OnInteractNpc([IsReadOnly] in EventData<string, Entity> eventData) {} // 0x0000000189B36714-0x0000000189B36778
		private void _OnDialogStart([IsReadOnly] in EventData<bool, DialogEnums.DialogType> eventData) {} // 0x0000000189B366A8-0x0000000189B36714
		private void _OnDialogFinish([IsReadOnly] in EventData<bool> eventData) {} // 0x0000000189B36644-0x0000000189B366A8
		private void _SetInDialog(bool inDialog) {} // 0x0000000189B36904-0x0000000189B3699C
		private void _OnOutAnimCallback() {} // 0x0000000189B3681C-0x0000000189B3686C
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	public class UIMainCharFootBarArc : TickableUIMono // TypeDefIndex: 52510
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
		[Unit(Units.Second)]
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
		private float m_curDashCellCount; // 0x138
		private float m_curDashFillAmount; // 0x13C
		private UIHeadBar.HpDisplayState m_dashWhiteState; // 0x140
		private Dictionary<int, string> m_dashCountStateNames; // 0x148
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D567A0-0x0000000183D567B0 
	
		// Constructors
		public UIMainCharFootBarArc() {} // 0x00000001837E2E30-0x00000001837E3110
	
		// Methods
		protected override void OnAwake() {} // 0x0000000182974430-0x00000001829749B0
		protected override void OnEnable() {} // 0x0000000182CD5A50-0x0000000182CD5C90
		protected override void OnRelease() {} // 0x0000000189B34798-0x0000000189B34C8C
		private void _OnMainCharChange([IsReadOnly] in EventData<SetLeaderReason, Entity, Entity> data) {} // 0x0000000189B34EDC-0x0000000189B34F54
		private void _ProcessOnMainCharChange() {} // 0x0000000182CD5C90-0x0000000182CD5D10
		public override void TailLateTick(float deltaTime) {} // 0x0000000182B4A640-0x0000000182B4AF50
		private void _OnDashCountChanged(float curCount) {} // 0x0000000182B4A1D0-0x0000000182B4A2A0
		private void _OnDashFailed() {} // 0x0000000189B34C8C-0x0000000189B34D44
		private void _OnInteractNpc([IsReadOnly] in EventData<string, Entity> eventData) {} // 0x0000000189B34E78-0x0000000189B34EDC
		private void _OnDialogStart([IsReadOnly] in EventData<bool, DialogEnums.DialogType> eventData) {} // 0x0000000189B34DA8-0x0000000189B34E14
		private void _OnDialogFinish([IsReadOnly] in EventData<bool> eventData) {} // 0x0000000189B34D44-0x0000000189B34DA8
		private void _OnPlayCutscene([IsReadOnly] in EventData<CinematicTimelineManagerBase.TimelineHandle> eventData) {} // 0x0000000189B34F54-0x0000000189B34FB8
		private void _OnFinishCutscene([IsReadOnly] in EventData<bool> eventData) {} // 0x0000000189B34E14-0x0000000189B34E78
		private void _OnForbidSystemChanged([IsReadOnly] in EventData<ForbidType, bool> eventData) {} // 0x00000001839E0FC0-0x00000001839E1000
		private void _SetInDialog(bool inDialog) {} // 0x0000000189B34FB8-0x0000000189B3508C
		public void SetUIDisable(string key, bool disable) {} // 0x00000001836D7950-0x00000001836D7A20
		private void _RefreshDisableState() {} // 0x00000001836D7A20-0x00000001836D7B60
		private void _OnOutAnimCallback() {} // 0x0000000183D48350-0x0000000183D483A0
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
		public void __iFixBaseProxy_TailLateTick(float P0) {} // 0x0000000185826E68-0x0000000185826E70
	}

	public class UIPoiseKnot : MonoBehaviour // TypeDefIndex: 52511
	{
		// Fields
		[SerializeField]
		private CanvasGroup _canvasGroup; // 0x18
		[SerializeField]
		private UIAnimationWrapper _animationWrapper; // 0x20
	
		// Constructors
		public UIPoiseKnot() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void SetVisible(bool visible) {} // 0x0000000189B36B40-0x0000000189B36BB0
		public void KnotBreak() {} // 0x0000000189B36AE0-0x0000000189B36B40
	}

	public class UIWeakLockAim : UIAbilityTargetFollower // TypeDefIndex: 52512
	{
		// Fields
		public CanvasGroup aimGroup; // 0x110
	
		// Constructors
		public UIWeakLockAim() {} // 0x0000000183D4CD70-0x0000000183D4CD80
	
		// Methods
		protected override void OnAwake() {} // 0x00000001834D95C0-0x00000001834D96C0
		protected void Start() {} // 0x0000000183B72380-0x0000000183B723D0
		protected override void OnRelease() {} // 0x0000000189B36BB0-0x0000000189B36CBC
		private void _OnMainTargetChanged([IsReadOnly] in EventData<AbilitySystem, bool> data) {} // 0x0000000189B36CBC-0x0000000189B36D1C
		private void _RefreshTarget() {} // 0x0000000183B723D0-0x0000000183B72480
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000189B346F4-0x0000000189B346FC
		public void __iFixBaseProxy_OnRelease() {} // 0x0000000189B1C3A0-0x0000000189B1C3A8
	}

	public class BlueprintPreviewHelper // TypeDefIndex: 52513
	{
		// Fields
		private ushort[][] m_data; // 0x10
		private int m_width; // 0x18
		private int m_height; // 0x1C
	
		// Constructors
		public BlueprintPreviewHelper() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void SetSize(int width, int height) {} // 0x0000000189B29B7C-0x0000000189B29CFC
		public void AddGridValue(int x, int y, byte value) {} // 0x0000000189B2975C-0x0000000189B298D4
		public void BatchAddGridValue(int xMin, int yMin, int width, int height, byte value) {} // 0x0000000189B298D4-0x0000000189B29AAC
		public byte GetGridValue(int x, int y, out byte value2) {
			value2 = default;
			return default;
		} // 0x0000000189B29AAC-0x0000000189B29B7C
	}

	public class CommonTrackerNodeComp : MonoBehaviour // TypeDefIndex: 52514
	{
		// Fields
		public UIBlackboxTracker blackboxTracker; // 0x18
		public UICampfireTracker campfireTracker; // 0x20
		public UICommonTracker commonTracker; // 0x28
		public UICommonLevelTracker commonLevelTracker; // 0x30
		private const float TOO_FAR_DISTANCE = 15f; // Metadata: 0x01FD210E
	
		// Constructors
		public CommonTrackerNodeComp() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void ShowStyleType(CommonTrackingPointStyleType styleType, CommonTrackingPointInfoBase trackerData) {} // 0x0000000189B29D9C-0x0000000189B29FDC
		public void PlayOutAnimation(CommonTrackingPointStyleType styleType) {} // 0x0000000189B29CFC-0x0000000189B29D9C
		public void UpdatePosition(CommonTrackingPointInfoBase trackerData) {} // 0x0000000189B29FDC-0x0000000189B2A178
	}

	public class CommonTrackerUpdate : MonoBehaviour // TypeDefIndex: 52519
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
		private bool _inFactoryTopView { get => default; } // 0x00000001825C0B60-0x00000001825C0CB0 
	
		// Nested types
		public enum CommonTrackItemState // TypeDefIndex: 52515
		{
			Show = 0,
			Hide = 1,
			ShowToHide = 2
		}
	
		public enum CommonTrackerDataState // TypeDefIndex: 52516
		{
			Active = 0,
			InActive = 1
		}
	
		public class CommonTrackerData // TypeDefIndex: 52517
		{
			// Fields
			public CommonTrackerDataState activeState; // 0x10
			public CommonTrackingPointInfoBase trackData; // 0x18
			public string key; // 0x20
	
			// Constructors
			public CommonTrackerData() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public class CommonTrackerItem // TypeDefIndex: 52518
		{
			// Fields
			public CommonTrackItemState showState; // 0x10
			public GameObject obj; // 0x18
			public CommonTrackerNodeComp commonTrackerNodeComp; // 0x20
	
			// Constructors
			public CommonTrackerItem() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public CommonTrackerUpdate() {} // 0x0000000183A1C150-0x0000000183A1C250
		static CommonTrackerUpdate() {} // 0x0000000183D44960-0x0000000183D449A0
	
		// Methods
		public void UpdateCommonTrackers(bool missionHudOpen, int onShowSignal) {} // 0x00000001825C0950-0x00000001825C0AB0
		public void AllTrackersPlayOutAnimation() {} // 0x0000000183C7FE40-0x0000000183C7FED0
		private bool _InitTrackInfoByIndex(int trackerIdx, string key, CommonTrackingPointInfoBase trackData) => default; // 0x0000000189B2A45C-0x0000000189B2A5C8
		private CommonTrackerItem _CreateNewMissionTracker() => default; // 0x0000000189B2A178-0x0000000189B2A31C
		private void _DeleteInvalidTracker() {} // 0x00000001825C0AB0-0x00000001825C0B60
		private void _ShowTrackerGo(CommonTrackerItem trackerItem, CommonTrackingPointInfoBase trackerData) {} // 0x0000000189B2A5C8-0x0000000189B2A668
		private void _HideTrackerGo(CommonTrackerItem trackerItem) {} // 0x0000000189B2A3E8-0x0000000189B2A45C
		private int _FindTrackIndexByKey(string key) => default; // 0x0000000189B2A31C-0x0000000189B2A3E8
	}

	public class UIBlackboxTracker : MonoBehaviour // TypeDefIndex: 52520
	{
		// Fields
		public RectTransform rectTransform; // 0x18
		public RectTransform arrowRotator; // 0x20
		public UIAnimationWrapper animationWrapper; // 0x28
		public UIText distanceTxt; // 0x30
	
		// Constructors
		public UIBlackboxTracker() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void UpdatePosition(Vector2 uiPos, float uiAngle, bool isOutBound, float distance, bool needShowDistance) {} // 0x0000000189B31314-0x0000000189B31570
	}

	public class UICampfireTracker : MonoBehaviour // TypeDefIndex: 52521
	{
		// Fields
		public RectTransform rectTransform; // 0x18
		public RectTransform arrowRotator; // 0x20
		public UIAnimationWrapper animationWrapper; // 0x28
		public UIImage image; // 0x30
	
		// Constructors
		public UICampfireTracker() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void UpdatePosition(Vector2 uiPos, float uiAngle, bool isOutBound, float distance, bool needShowDistance) {} // 0x0000000189B315F0-0x0000000189B31700
		public void UpdateImage(CommonTrackingPointInfoBase trackerData) {} // 0x0000000189B31570-0x0000000189B315F0
	}

	public class UICommonLevelTracker : MonoBehaviour // TypeDefIndex: 52522
	{
		// Fields
		public RectTransform rectTransform; // 0x18
		public RectTransform arrowRotator; // 0x20
		public UIAnimationWrapper animationWrapper; // 0x28
		public UIText distanceTxt; // 0x30
	
		// Constructors
		public UICommonLevelTracker() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void UpdatePosition(PosValueState posValueState, bool needShowDistance, Vector2 uiPos, float uiAngle, bool isOutBound, float distance, CommonTrackMapTier mapTier = CommonTrackMapTier.Current /* Metadata: 0x01FD2117 */) {} // 0x0000000189B31700-0x0000000189B3196C
	}

	public class UICommonTracker : MonoBehaviour // TypeDefIndex: 52523
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
	
		// Constructors
		public UICommonTracker() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void UpdateImage(CommonTrackingPointInfoBase trackerData) {} // 0x0000000189B3196C-0x0000000189B31A04
		public void UpdatePosition(PosValueState posValueState, bool needShowDistance, Vector2 uiPos, float uiAngle, bool isOutBound, float distance, CommonTrackMapTier mapTier = CommonTrackMapTier.Current /* Metadata: 0x01FD2118 */) {} // 0x0000000189B31A04-0x0000000189B31D50
	}

	public class CoolerUnitProgressBarUI : WorldUIController // TypeDefIndex: 52524
	{
		// Fields
		private Entity m_targetEntity; // 0xC0
		private CoolerUnitComponent m_coolerUnitComponent; // 0xC8
		private float m_displayProgress; // 0xD0
		private const float LERP_SPEED = 5f; // Metadata: 0x01FD2119
		private const float MAX_STEP = 0.07f; // Metadata: 0x01FD211D
		public UIText progressDesc; // 0xD8
		public UIText progressText; // 0xE0
		public UIImage progressImage; // 0xE8
		public Transform progressUIRoot; // 0xF0
		private CanvasGroup m_canvasGroup; // 0xF8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Constructors
		public CoolerUnitProgressBarUI() {} // 0x0000000182846010-0x0000000182846020
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment) {} // 0x0000000189B2A668-0x0000000189B2A8C4
		public override void SetUIForward() {} // 0x0000000189B2A9F0-0x0000000189B2AB70
		public override void SetPos() {} // 0x0000000189B2A8C4-0x0000000189B2A9F0
		public override void TickUI(float deltaTime) {} // 0x0000000189B2AB70-0x0000000189B2ABEC
		private void _TickCanvasGroup(float deltaTime) {} // 0x0000000189B2AC14-0x0000000189B2ACF8
		private void _UpdateProgress(float deltaTime) {} // 0x0000000189B2ACF8-0x0000000189B2AE84
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3) {} // 0x0000000189B2ABEC-0x0000000189B2ABFC
		public void __iFixBaseProxy_SetUIForward() {} // 0x0000000189B2AC04-0x0000000189B2AC0C
		public void __iFixBaseProxy_SetPos() {} // 0x0000000189B2ABFC-0x0000000189B2AC04
		public void __iFixBaseProxy_TickUI(float P0) {} // 0x0000000189B2AC0C-0x0000000189B2AC14
	}

	public class CoolerUnitTemperatureCircleUI : WorldUIController // TypeDefIndex: 52527
	{
		// Fields
		private const string AUDIO_EVENT_SUCCEED = "au_int_forge_iron_success"; // Metadata: 0x01FD2121
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
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Nested types
		public enum ETemperatureState // TypeDefIndex: 52525
		{
			None = 0,
			Low = 1,
			Safe = 2,
			High = 3,
			Finish = 4
		}
	
		public static class CoolerUnitLangKeys // TypeDefIndex: 52526
		{
			// Fields
			public const string TOO_COLD = "lang_int_forgeiron_TempTooCold"; // Metadata: 0x01FD2140
			public const string GOOD = "lang_int_forgeiron_TempGood"; // Metadata: 0x01FD215F
			public const string TOO_HOT = "lang_int_forgeiron_TempTooHot"; // Metadata: 0x01FD217B
			public const string FINISH = "lang_int_forgeiron_Finish"; // Metadata: 0x01FD2199
		}
	
		// Constructors
		public CoolerUnitTemperatureCircleUI() {} // 0x0000000182846010-0x0000000182846020
		static CoolerUnitTemperatureCircleUI() {} // 0x0000000189B2BA14-0x0000000189B2BA8C
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment) {} // 0x0000000189B2AE84-0x0000000189B2B1D4
		public override void SetUIForward() {} // 0x0000000189B2B300-0x0000000189B2B480
		public override void SetPos() {} // 0x0000000189B2B1D4-0x0000000189B2B300
		public override void TickUI(float deltaTime) {} // 0x0000000189B2B480-0x0000000189B2B520
		private void _TickCanvasGroup(float deltaTime) {} // 0x0000000189B2B884-0x0000000189B2B968
		private void _UpdateUIState() {} // 0x0000000189B2B968-0x0000000189B2BA14
		private void _SetState(ETemperatureState state) {} // 0x0000000189B2B5A4-0x0000000189B2B884
		private string _GetLangKeyOrDefault(LangKey customKey, string defaultKey) => default; // 0x0000000189B2B520-0x0000000189B2B5A4
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3) {} // 0x0000000189B2ABEC-0x0000000189B2ABFC
		public void __iFixBaseProxy_SetUIForward() {} // 0x0000000189B2AC04-0x0000000189B2AC0C
		public void __iFixBaseProxy_SetPos() {} // 0x0000000189B2ABFC-0x0000000189B2AC04
		public void __iFixBaseProxy_TickUI(float P0) {} // 0x0000000189B2AC0C-0x0000000189B2AC14
	}

	public class CoolerUnitTemperatureUI : WorldUIController // TypeDefIndex: 52529
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
		private const float COLOR_EPS = 0.02f; // Metadata: 0x01FD21B3
		private const float SNAP_THRESHOLD = 0.25f; // Metadata: 0x01FD21B7
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Nested types
		private enum TempColorState // TypeDefIndex: 52528
		{
			Blue = 0,
			Green = 1,
			Red = 2
		}
	
		// Constructors
		public CoolerUnitTemperatureUI() {} // 0x0000000189B2CAB0-0x0000000189B2CAC4
		static CoolerUnitTemperatureUI() {} // 0x0000000189B2CA10-0x0000000189B2CAB0
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment) {} // 0x0000000189B2BAFC-0x0000000189B2BC94
		public override void Clear() {} // 0x0000000189B2BA8C-0x0000000189B2BAFC
		public override void SetUIForward() {} // 0x0000000189B2BE3C-0x0000000189B2BFBC
		public override void SetPos() {} // 0x0000000189B2BD10-0x0000000189B2BE3C
		public override void TickUI(float deltaTime) {} // 0x0000000189B2BFBC-0x0000000189B2C048
		private void _TickCanvasGroup(float deltaTime) {} // 0x0000000189B2C050-0x0000000189B2C134
		public void NormalizeRange(ref float min, ref float max) {} // 0x0000000189B2BC94-0x0000000189B2BD10
		private void _UpdateUIInfo(float deltaTime) {} // 0x0000000189B2C134-0x0000000189B2C57C
		private void _UpdateUIPos(float deltaTime) {} // 0x0000000189B2C57C-0x0000000189B2CA10
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3) {} // 0x0000000189B2ABEC-0x0000000189B2ABFC
		public void __iFixBaseProxy_Clear() {} // 0x0000000189B2C048-0x0000000189B2C050
		public void __iFixBaseProxy_SetUIForward() {} // 0x0000000189B2AC04-0x0000000189B2AC0C
		public void __iFixBaseProxy_SetPos() {} // 0x0000000189B2ABFC-0x0000000189B2AC04
		public void __iFixBaseProxy_TickUI(float P0) {} // 0x0000000189B2AC0C-0x0000000189B2AC14
	}

	public class CoolerUnitTotalProgressBarUI : WorldUIController // TypeDefIndex: 52530
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
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Constructors
		public CoolerUnitTotalProgressBarUI() {} // 0x0000000189B2D3DC-0x0000000189B2D3F0
		static CoolerUnitTotalProgressBarUI() {} // 0x0000000189B2D38C-0x0000000189B2D3DC
	
		// Methods
		private static string[] _GeneratePercentStrings() => default; // 0x0000000189B2CDE0-0x0000000189B2CEB8
		public override void Init(Entity target, string path, ulong id, int typeSegment) {} // 0x0000000189B2CAC4-0x0000000189B2CB94
		private void _ResetUI() {} // 0x0000000189B2CF48-0x0000000189B2CFC4
		private void _GetCanvas() {} // 0x0000000189B2CEB8-0x0000000189B2CF48
		private bool _TryGetModule(ulong id) => default; // 0x0000000189B2D18C-0x0000000189B2D2A4
		public override void SetUIForward() {} // 0x0000000189B2CC34-0x0000000189B2CD64
		public override void SetPos() {} // 0x0000000189B2CB94-0x0000000189B2CC34
		public override void TickUI(float deltaTime) {} // 0x0000000189B2CD64-0x0000000189B2CDE0
		private void _TickCanvasGroup(float deltaTime) {} // 0x0000000189B2D0A8-0x0000000189B2D18C
		private void _UpdateProgress(float deltaTime) {} // 0x0000000189B2D2A4-0x0000000189B2D38C
		private void _SetProgressText(int percent) {} // 0x0000000189B2CFC4-0x0000000189B2D0A8
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3) {} // 0x0000000189B2ABEC-0x0000000189B2ABFC
		public void __iFixBaseProxy_SetUIForward() {} // 0x0000000189B2AC04-0x0000000189B2AC0C
		public void __iFixBaseProxy_SetPos() {} // 0x0000000189B2ABFC-0x0000000189B2AC04
		public void __iFixBaseProxy_TickUI(float P0) {} // 0x0000000189B2AC0C-0x0000000189B2AC14
	}

	public class FacLineCell : MonoBehaviour // TypeDefIndex: 52532
	{
		// Fields
		private const float HSV_VALUE_RATIO = 1.6f; // Metadata: 0x01FD21BE
		[SerializeField]
		private RectTransform _rectTransform; // 0x18
		public RectTransform topAgent; // 0x20
		public RectTransform bottomAgent; // 0x28
		public UIAnimationWrapper lineAnimationWrapper; // 0x30
		public UIAnimationWrapper decoAnimationWrapper; // 0x38
		private List<UIImage> m_imageList; // 0x40
	
		// Constructors
		public FacLineCell() {} // 0x00000001838DD690-0x00000001838DD720
	
		// Methods
		private void Awake() {} // 0x0000000189B2D3F0-0x0000000189B2D534
		public void PlayLineAnimation(string animationName, TweenCallback callback = null) {} // 0x0000000189B2D818-0x0000000189B2D8F0
		public void PlayLineDecoAnimation(string animationName, TweenCallback callback = null) {} // 0x0000000189B2D8F0-0x0000000189B2DA74
		public void ChangeLineColor(UnityEngine.Color color) {} // 0x0000000189B2D534-0x0000000189B2D784
		public void ChangeLineWidth(float width) {} // 0x0000000189B2D784-0x0000000189B2D818
	}

	public class FacLineDrawer : MonoBehaviour, IUIClearable // TypeDefIndex: 52534
	{
		// Fields
		private RectTransform m_rectTransform; // 0x18
		private readonly Dictionary<uint, LineData> m_lineCache; // 0x20
		private readonly List<GameObject> m_instantiatedLineCell; // 0x28
		private uint m_nextLineId; // 0x30
		private const uint INVALID_LINE_ID = 0; // Metadata: 0x01FD21C2
		public RectTransform startDrawAgent; // 0x38
		public RectTransform endDrawAgent; // 0x40
		public GameObject linkLinePrefab; // 0x48
	
		// Nested types
		private struct LineData // TypeDefIndex: 52533
		{
			// Fields
			public FacLineCell start; // 0x00
			public FacLineCell end; // 0x08
			public FacLineCell link; // 0x10
		}
	
		// Constructors
		public FacLineDrawer() {} // 0x0000000183A93C30-0x0000000183A93D00
	
		// Methods
		private void Awake() {} // 0x0000000189B2DA74-0x0000000189B2DAF4
		private void OnDestroy() {} // 0x0000000189B2E3B4-0x0000000189B2E404
		private void _Clear() {} // 0x0000000189B2E6D4-0x0000000189B2E890
		private GameObject _CloneLineObject(GameObject sourceObject, Transform locateTransform) => default; // 0x0000000189B2E890-0x0000000189B2E9CC
		private void _RefreshCopyLineObjectColor(GameObject lineObject, UnityEngine.Color color) {} // 0x0000000189B2E9CC-0x0000000189B2EAC8
		public void ClearComponent() {} // 0x0000000189B2DC20-0x0000000189B2DC70
		public uint DrawLine(FacLineCell start, FacLineCell end) => default; // 0x0000000189B2DCC0-0x0000000189B2E3B4
		public void PlayLineAnimation(uint lineId, string animationName, TweenCallback callback = null) {} // 0x0000000189B2E404-0x0000000189B2E58C
		public void PlayPortLineDecoAnimation(uint lineId, string animationName, bool isStart, TweenCallback callback = null) {} // 0x0000000189B2E58C-0x0000000189B2E6D4
		public void ChangeLineColor(uint lineId, UnityEngine.Color color) {} // 0x0000000189B2DAF4-0x0000000189B2DC20
		public void ClearDrawer() {} // 0x0000000189B2DC70-0x0000000189B2DCC0
	}

	public class FacPipeAnimationSetting : MonoBehaviour // TypeDefIndex: 52535
	{
		// Fields
		private const string PIPE_ANIMATION_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Animations/Factory/pipecell"; // Metadata: 0x01FD21C3
		public string decoInAnimation; // 0x18
		public string decoOutAnimation; // 0x20
		public string itemAnimation; // 0x28
		public bool needBoldAnimations; // 0x30
		public string boldDecoInAnimation; // 0x38
		public string boldDecoOutAnimation; // 0x40
		public string boldItemAnimation; // 0x48
	
		// Constructors
		public FacPipeAnimationSetting() {} // 0x000000018426FE60-0x000000018426FE68
	}

	public class FacRegionUpgradeEffectController : MonoBehaviour // TypeDefIndex: 52536
	{
		// Fields
		[SerializeField]
		private GameObject _waitUpgradeNode; // 0x18
		[SerializeField]
		private GameObject _upgradedRegionNode; // 0x20
		[SerializeField]
		private GameObject _waitUpgradeSelectNode; // 0x28
	
		// Constructors
		public FacRegionUpgradeEffectController() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void _RefreshNodeState(GameObject node, bool active) {} // 0x0000000189B2EC48-0x0000000189B2ECFC
		public void SetUpgradeState(bool isUpgraded) {} // 0x0000000189B2EB48-0x0000000189B2EBD8
		public void SetSelectState(bool isSelected) {} // 0x0000000189B2EAC8-0x0000000189B2EB48
		public void SetVisibleState(bool isVisible) {} // 0x0000000189B2EBD8-0x0000000189B2EC48
	}

	public class UIFacTechTreePanel : UIPanelBase // TypeDefIndex: 52537
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
		[SerializeField]
		private LuaPanel _techTreeLuaPanel; // 0xB8
		[SerializeField]
		private UITouchPanel _touchPanel; // 0xC0
		[SerializeField]
		private RectTransform _techTreeRectTransform; // 0xC8
		[SerializeField]
		private RectTransform _techTreePanel; // 0xD0
		[SerializeField]
		private float _titleHight; // 0xD8
		[SerializeField]
		private float _moveSpeed; // 0xDC
		[SerializeField]
		private float _zoomSpeed; // 0xE0
		[SerializeField]
		private float _zoomDefault; // 0xE4
		[SerializeField]
		private float _zoomRangeMin; // 0xE8
		[SerializeField]
		private float _zoomRangeMax; // 0xEC
		[SerializeField]
		private float _showNameScale; // 0xF0
		[SerializeField]
		private float _zoomTweenTime; // 0xF4
		[SerializeField]
		private float _moveNodeXOffset; // 0xF8
		[SerializeField]
		private float _moveNodeYOffset; // 0xFC
		[SerializeField]
		private float _startZoomTweenTime; // 0x100
		[SerializeField]
		private AnimationCurve _openUICurve; // 0x108
		[SerializeField]
		private float _movePosTime; // 0x110
		[SerializeField]
		private AnimationCurve _movePosCurve; // 0x118
		[SerializeField]
		private float _movePanelTime; // 0x120
		[SerializeField]
		private AnimationCurve _movePanelCurve; // 0x128
		[SerializeField]
		private float _unlockNodeTime; // 0x130
		[SerializeField]
		private AnimationCurve _unlockNodeCurve; // 0x138
		private bool m_controllerInitialized; // 0x140
		private bool m_isDetailShown; // 0x141
		[SerializeField]
		private float _controllerDragSpeed; // 0x144
		[SerializeField]
		private float _controllerZoomSpeed; // 0x148
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Constructors
		public UIFacTechTreePanel() {} // 0x0000000189B33900-0x0000000189B33958
	
		// Methods
		protected override void OnRelease() {} // 0x0000000189B321DC-0x0000000189B3225C
		public override void Tick(float deltaTime) {} // 0x0000000189B3235C-0x0000000189B323E0
		public void InitData() {} // 0x0000000189B31DF4-0x0000000189B3200C
		private void _OnDrag(Vector2 value) {} // 0x0000000189B32980-0x0000000189B32A28
		private void _OnZoom(float value, bool needTween) {} // 0x0000000189B32B8C-0x0000000189B32D34
		private void _SetScale(bool needTween, float zoomTweenTime = 0f /* Metadata: 0x01FD2208 */, AnimationCurve curve = null, TweenCallback onFinish = null) {} // 0x0000000189B333F4-0x0000000189B33734
		private void _RefreshAll() {} // 0x0000000189B32F98-0x0000000189B33024
		private void _PosAdjust() {} // 0x0000000189B32D34-0x0000000189B32F98
		private void _RefreshPivotPosition() {} // 0x0000000189B33024-0x0000000189B333F4
		private void _UpdatePositionOffsetAfterZoomed() {} // 0x0000000189B33734-0x0000000189B33900
		public void MoveNode(float dis, float nodeX, float nodeY, bool ignorePos = false /* Metadata: 0x01FD220C */) {} // 0x0000000189B3200C-0x0000000189B321DC
		public void FocusNode(float nodeX, float nodeY, TweenCallback onComplete) {} // 0x0000000189B31D50-0x0000000189B31DF4
		public void OnUnlockTech(float nodeX, float nodeY, TweenCallback onComplete) {} // 0x0000000189B3225C-0x0000000189B32300
		public void ZoomToFullTechTree(TweenCallback onComplete) {} // 0x0000000189B32550-0x0000000189B325D4
		private void _OnUnlockMoveNode(float nodeX, float nodeY) {} // 0x0000000189B32A28-0x0000000189B32B8C
		private void _ControllerUpdate() {} // 0x0000000189B327BC-0x0000000189B32860
		private void _ControllerZoomUpdate() {} // 0x0000000189B32860-0x0000000189B32980
		private void _ControllerDragUpdate() {} // 0x0000000189B325D4-0x0000000189B327BC
		public void SetDetailShownState(bool isShown) {} // 0x0000000189B32300-0x0000000189B3235C
		public void __iFixBaseProxy_OnRelease() {} // 0x0000000189B1C3A0-0x0000000189B1C3A8
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
	}

	public class ForgeIronProgressBarUI : WorldUIController // TypeDefIndex: 52538
	{
		// Fields
		public UIText progressDesc; // 0xC0
		public UIText progressText; // 0xC8
		public UIImage progressImage; // 0xD0
		public Transform progressUIRoot; // 0xD8
		private InteractiveLogicForgeIron m_logic; // 0xE0
		private CanvasGroup m_canvasGroup; // 0xE8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Constructors
		public ForgeIronProgressBarUI() {} // 0x0000000182846010-0x0000000182846020
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment) {} // 0x0000000189B2ECFC-0x0000000189B2EE20
		public override void SetPos() {} // 0x0000000189B2EE20-0x0000000189B2EF5C
		public override void SetUIForward() {} // 0x0000000189B2EF5C-0x0000000189B2F198
		public override void TickUI(float deltaTime) {} // 0x0000000189B2F198-0x0000000189B2F2AC
		public void UpdateProgress() {} // 0x0000000189B2F2AC-0x0000000189B2F5E0
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3) {} // 0x0000000189B2ABEC-0x0000000189B2ABFC
		public void __iFixBaseProxy_SetPos() {} // 0x0000000189B2ABFC-0x0000000189B2AC04
		public void __iFixBaseProxy_SetUIForward() {} // 0x0000000189B2AC04-0x0000000189B2AC0C
		public void __iFixBaseProxy_TickUI(float P0) {} // 0x0000000189B2AC0C-0x0000000189B2AC14
	}

	public class ForgeIronTemperatureCircleUI : WorldUIController // TypeDefIndex: 52540
	{
		// Fields
		private const string AUDIO_EVENT_SUCCEED = "au_int_forge_iron_success"; // Metadata: 0x01FD220D
		private static readonly UnityEngine.Color COLOR_BLUE; // 0x00
		private static readonly UnityEngine.Color COLOR_GREEN; // 0x10
		private static readonly UnityEngine.Color COLOR_RED; // 0x20
		public UIImage bg; // 0xC0
		public UIImage warningBg; // 0xC8
		public UIText desc; // 0xD0
		public Transform tempCircleRoot; // 0xD8
		[SerializeField]
		public int belongRound; // 0xE0
		private InteractiveLogicForgeIron m_logic; // 0xE8
		private CanvasGroup m_canvasGroup; // 0xF0
		private string m_customDesc; // 0xF8
		private string m_highTempDesc; // 0x100
		private string m_lowTempDesc; // 0x108
		private string m_goodTempDesc; // 0x110
		private bool m_hasPlaySuccessAudio; // 0x118
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Nested types
		public enum ETemperatureState // TypeDefIndex: 52539
		{
			None = 0,
			Low = 1,
			Safe = 2,
			High = 3,
			Finish = 4
		}
	
		// Constructors
		public ForgeIronTemperatureCircleUI() {} // 0x0000000182846010-0x0000000182846020
		static ForgeIronTemperatureCircleUI() {} // 0x0000000189B30294-0x0000000189B3030C
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment) {} // 0x0000000189B2F638-0x0000000189B2F730
		public override void Clear() {} // 0x0000000189B2F5E0-0x0000000189B2F638
		public override void SetPos() {} // 0x0000000189B2F730-0x0000000189B2F888
		public override void SetUIForward() {} // 0x0000000189B2F888-0x0000000189B2FBE0
		public override void TickUI(float deltaTime) {} // 0x0000000189B2FBE0-0x0000000189B2FD6C
		public void UpdateUIState() {} // 0x0000000189B2FD6C-0x0000000189B2FEC4
		private void _SetState(bool max, bool low, bool high, ETemperatureState state) {} // 0x0000000189B2FEC4-0x0000000189B30294
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3) {} // 0x0000000189B2ABEC-0x0000000189B2ABFC
		public void __iFixBaseProxy_Clear() {} // 0x0000000189B2C048-0x0000000189B2C050
		public void __iFixBaseProxy_SetPos() {} // 0x0000000189B2ABFC-0x0000000189B2AC04
		public void __iFixBaseProxy_SetUIForward() {} // 0x0000000189B2AC04-0x0000000189B2AC0C
		public void __iFixBaseProxy_TickUI(float P0) {} // 0x0000000189B2AC0C-0x0000000189B2AC14
	}

	public class ForgeIronTemperatureUI : WorldUIController // TypeDefIndex: 52541
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
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Constructors
		public ForgeIronTemperatureUI() {} // 0x0000000189B37E20-0x0000000189B37E34
		static ForgeIronTemperatureUI() {} // 0x0000000189B37DA8-0x0000000189B37E20
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment) {} // 0x0000000189B3717C-0x0000000189B37274
		public override void SetPos() {} // 0x0000000189B37274-0x0000000189B373B0
		public override void SetUIForward() {} // 0x0000000189B373B0-0x0000000189B3751C
		public override void TickUI(float deltaTime) {} // 0x0000000189B3751C-0x0000000189B3763C
		public void UpdateUIInfo() {} // 0x0000000189B3763C-0x0000000189B3792C
		public void UpdateUIPos() {} // 0x0000000189B3792C-0x0000000189B37DA8
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3) {} // 0x0000000189B2ABEC-0x0000000189B2ABFC
		public void __iFixBaseProxy_SetPos() {} // 0x0000000189B2ABFC-0x0000000189B2AC04
		public void __iFixBaseProxy_SetUIForward() {} // 0x0000000189B2AC04-0x0000000189B2AC0C
		public void __iFixBaseProxy_TickUI(float P0) {} // 0x0000000189B2AC0C-0x0000000189B2AC14
	}

	public class GuideFakeButton : Selectable, IPointerClickHandler, IUIClearable // TypeDefIndex: 52542
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
		public GuideFakeButton() {} // 0x0000000183D2C3A0-0x0000000183D2C3F0
	
		// Methods
		public void ForceToggleTargetBinding(bool active, bool forDrag = false /* Metadata: 0x01FD222C */) {} // 0x0000000189B38464-0x0000000189B38634
		public void CopyTargetBinding() {} // 0x0000000189B3817C-0x0000000189B38464
		private void _OnTriggerPlayerAction([IsReadOnly] in EventData<string> actionId) {} // 0x0000000189B38EC4-0x0000000189B38F50
		public void ClearTarget() {} // 0x0000000189B3806C-0x0000000189B3817C
		public void ClearBinding() {} // 0x0000000189B37ECC-0x0000000189B3801C
		protected override void Awake() {} // 0x0000000189B37E34-0x0000000189B37ECC
		public override void OnPointerDown(PointerEventData eventData) {} // 0x0000000189B388D4-0x0000000189B38A20
		public override void OnPointerUp(PointerEventData eventData) {} // 0x0000000189B38CB8-0x0000000189B38E04
		public override void OnPointerEnter(PointerEventData eventData) {} // 0x0000000189B38A20-0x0000000189B38B6C
		public override void OnPointerExit(PointerEventData eventData) {} // 0x0000000189B38B6C-0x0000000189B38CB8
		public void OnPointerClick(PointerEventData eventData) {} // 0x0000000189B38634-0x0000000189B388D4
		public void ClearComponent() {} // 0x0000000189B3801C-0x0000000189B3806C
		private void _ClearOnClick() {} // 0x0000000189B38E14-0x0000000189B38EC4
		public void __iFixBaseProxy_Awake() {} // 0x0000000189AAE8DC-0x0000000189AAE8E4
		public void __iFixBaseProxy_OnPointerDown(PointerEventData P0) {} // 0x0000000189ACB964-0x0000000189ACB96C
		public void __iFixBaseProxy_OnPointerUp(PointerEventData P0) {} // 0x0000000189ACB96C-0x0000000189ACB974
		public void __iFixBaseProxy_OnPointerEnter(PointerEventData P0) {} // 0x0000000189B38E04-0x0000000189B38E0C
		public void __iFixBaseProxy_OnPointerExit(PointerEventData P0) {} // 0x0000000189B38E0C-0x0000000189B38E14
	}

	[Serializable]
	public class RegionMap3DCfg // TypeDefIndex: 52543
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
		[SerializeField]
		private string _ui; // 0x40
		[SerializeField]
		private string _model; // 0x48
		[SerializeField]
		private string _ground; // 0x50
	
		// Properties
		public bool isLoaded { get; private set; } // 0x0000000183D4F7E0-0x0000000183D4F7F0 0x0000000183D4F7F0-0x0000000183D4F800
	
		// Constructors
		public RegionMap3DCfg() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Load(RegionMapSetting regionMapSetting) {} // 0x0000000182F679D0-0x0000000182F67CF0
	}

	public enum RegionMapShowType // TypeDefIndex: 52544
	{
		Map = 0,
		Watch = 1
	}

	public class RegionMapSetting : UIPanelBase // TypeDefIndex: 52545
	{
		// Fields
		public const string UI_REGION_MAP_TRACK_ICON = "Assets/Beyond/DynamicAssets/Gameplay/UI/Prefabs/Map/Widgets/RegionMapTrackIcon.prefab"; // Metadata: 0x01FD2233
		public Transform uiRoot; // 0x70
		public Transform buildingRoot; // 0x78
		public Transform groundRoot; // 0x80
		[SerializeField]
		private Transform _modelNode; // 0x88
		[SerializeField]
		private Transform _uiNode; // 0x90
		[SerializeField]
		private RectTransform _uiPlayerMark; // 0x98
		[SerializeField]
		private UnityEngine.Color _normalModelOuterColor; // 0xA0
		[SerializeField]
		private UnityEngine.Color _selectedModelOuterColor; // 0xB0
		[SerializeField]
		private Vector3 _moveFinalRotation; // 0xC0
		[SerializeField]
		private SerializeFieldDictionary<string, RegionMap3DCfg> _cfg; // 0xD0
		private Transform m_currLoadedRegionTransform; // 0xD8
		private RegionMapShowType m_curShowType; // 0xE0
		private float m_animTimer; // 0xE4
		private float m_animDuration; // 0xE8
		private bool m_playAnim; // 0xEC
		private readonly List<RectTransform> m_trackIconList; // 0xF0
		private readonly Dictionary<Renderer, Material[]> m_refreshedMaterials; // 0xF8
		private UnityEngine.Color m_normalLevelModelColor; // 0x100
		private const string OUTER_COLOR_PROPERTY_NAME = "_OuterColor"; // Metadata: 0x01FD228A
		private static MaterialPropertyBlock s_materialPropertyBlock; // 0x00
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181002730-0x0000000181002740 
		public Dictionary<string, RegionMap3DCfg> cfg { get => default; } // 0x0000000182F679A0-0x0000000182F679D0 
		private static MaterialPropertyBlock m_materialPropertyBlock { get => default; } // 0x0000000189B3AD08-0x0000000189B3ADAC 
	
		// Constructors
		public RegionMapSetting() {} // 0x000000018284A770-0x000000018284A850
	
		// Methods
		protected override void OnDestroy() {} // 0x0000000189B3A738-0x0000000189B3A794
		private void _InitUI() {} // 0x0000000182F6AD30-0x0000000182F6B480
		private void _InitPlayerIcon() {} // 0x0000000182F6B5F0-0x0000000182F6B970
		private void _InitTrackIcon() {} // 0x0000000182F69860-0x0000000182F6AD30
		private void _InitSelect() {} // 0x0000000182F67F30-0x0000000182F68390
		private void _SetMapPos(RectTransform rect, Vector3 pos, BasicLoadConfigInfo uiLevelMapConfig) {} // 0x0000000182F6B480-0x0000000182F6B5F0
		private void _RefreshMaterials() {} // 0x0000000182A71FE0-0x0000000182A721C0
		private void _ClearMaterials() {} // 0x0000000189B3AB08-0x0000000189B3AD08
		public void InitData(RegionMapShowType shotType, Transform center = null, Transform moveRoot = null, float watchRadius = 0f /* Metadata: 0x01FD222F */) {} // 0x0000000182F68390-0x0000000182F69860
		public void MoveToPlayer(Transform center, Transform moveRoot) {} // 0x0000000182F677B0-0x0000000182F679A0
		public Transform GetNodeTransform(string levelId) => default; // 0x0000000189B3A67C-0x0000000189B3A738
		public Vector3 GetNodeMoveTargetLocalPosition(string levelId, Camera uiCamera, Transform moveRoot) => default; // 0x0000000189B3A320-0x0000000189B3A67C
		public RegionMap3DCfg GetCfg(string levelId) => default; // 0x0000000189B3A298-0x0000000189B3A320
		public static bool IsCircleIntersectingRectangle(Vector2 circleCenter, float circleRadius, UnityEngine.Rect rectangle) => default; // 0x0000000182F67DD0-0x0000000182F67E90
		public void SetLoadedRegionTransform(Transform regionTransform) {} // 0x0000000189B3A980-0x0000000189B3A9E8
		public TweenerCore<Quaternion, Quaternion, NoOptions> StartRegionRectTransformMoveRotationTween(float tweenDuration, AnimationCurve tweenCurve) => default; // 0x0000000189B3A9E8-0x0000000189B3AB08
		public void SetControllerLevelSelectedState(string levelId, bool isSelected) {} // 0x0000000189B3A794-0x0000000189B3A980
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000185F2CFD8-0x0000000185F2CFE0
	}

	[Serializable]
	public class UIFacMainRegionConfig // TypeDefIndex: 52546
	{
		// Fields
		public string levelId; // 0x10
		public int panelIndex; // 0x18
		public List<Sprite> levelSprites; // 0x20
		public List<Vector3> levelPositions; // 0x28
	
		// Constructors
		public UIFacMainRegionConfig() {} // 0x00000001837CAFF0-0x00000001837CB0C0
	}

	public class UIFacMainRegion : MonoBehaviour, IUIClearable // TypeDefIndex: 52547
	{
		// Fields
		private string m_levelId; // 0x18
		private int m_panelIndex; // 0x20
		[SerializeField]
		private List<UIFacMainRegionConfig> _configList; // 0x28
		[SerializeField]
		private RectTransform _rectTransform; // 0x30
		[SerializeField]
		private UIImage _image; // 0x38
	
		// Constructors
		public UIFacMainRegion() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void _OnMainRegionLevelChanged(string levelId, int panelIndex) {} // 0x0000000189B3D560-0x0000000189B3D5EC
		private void _RefreshRegionState() {} // 0x000000018346AEB0-0x000000018346B900
		private void OnDestroy() {} // 0x000000018346AA80-0x000000018346AAC0
		public void InitMainRegion(string levelId, int panelIndex) {} // 0x000000018346AC90-0x000000018346ADA0
		public void ClearComponent() {} // 0x000000018346ADA0-0x000000018346AEB0
	}

	public class UILevelMapCrane : MonoBehaviour, IUIClearable // TypeDefIndex: 52549
	{
		// Fields
		private CombineKey m_eventKey; // 0x18
		private CachedPathAssetLoader m_assetLoader; // 0x20
		private const string CRANE_SPRITE_FOLDER = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/Map/Crane/"; // Metadata: 0x01FD2296
		private const string CRANE_GAME_VAR_KEY = "lv003_crane_state"; // Metadata: 0x01FD22D1
		[SerializeField]
		private SerializeReferenceDictionary<long, CraneSpritePath> _stateSpriteDict; // 0x28
		[SerializeField]
		private RectTransform _rectTransform; // 0x30
		[SerializeField]
		private UIImage _image; // 0x38
	
		// Nested types
		[Serializable]
		public class CraneSpritePath // TypeDefIndex: 52548
		{
			// Fields
			public string stateSpritePath; // 0x10
	
			// Constructors
			public CraneSpritePath() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public UILevelMapCrane() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void OnDestroy() {} // 0x0000000189B3D818-0x0000000189B3D874
		private void _RefreshCraneState() {} // 0x0000000189B3DADC-0x0000000189B3DD60
		private void _ClearSpriteAsset() {} // 0x0000000189B3DA14-0x0000000189B3DA7C
		private void _OnCraneStateChanged([IsReadOnly] in EventData<long, long> eventData) {} // 0x0000000189B3DA7C-0x0000000189B3DADC
		private void _BindAll() {} // 0x0000000189B3D874-0x0000000189B3DA14
		private void _UnBindAll() {} // 0x0000000183CF07A0-0x0000000183CF0870
		public void InitCrane() {} // 0x0000000189B3D7BC-0x0000000189B3D818
		public void ClearComponent() {} // 0x0000000183CF0760-0x0000000183CF07A0
	}

	public class UILevelMapGameplayArea : MonoBehaviour, IUIClearable // TypeDefIndex: 52550
	{
		// Fields
		private bool m_initialized; // 0x18
		[SerializeField]
		private RectTransform _rectTransform; // 0x20
		[SerializeField]
		private RectTransform _circleRectTransform; // 0x28
	
		// Constructors
		public UILevelMapGameplayArea() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void _RefreshGameplayArea(GameplayAreaInstRuntimeData areaData) {} // 0x0000000189B3DDC4-0x0000000189B3DEFC
		public void Init(GameplayAreaInstRuntimeData areaData) {} // 0x0000000189B3DD60-0x0000000189B3DDC4
		public void ClearComponent() {} // 0x0000000183D4CBB0-0x0000000183D4CBE0
	}

	public class UILevelMapLimitInRect : TickableUIMono, IUIClearable // TypeDefIndex: 52552
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
		[SerializeField]
		private RectTransform _rectTransform; // 0x90
		[SerializeField]
		private RectTransform _limitRectTransform; // 0x98
		[SerializeField]
		private MaskShapeType _maskShapeType; // 0xA0
		[SerializeField]
		private float _circleLimitRadius; // 0xA4
		[SerializeField]
		private List<GameObject> _limitActiveNodes; // 0xA8
		[SerializeField]
		private List<GameObject> _limitInactiveNodes; // 0xB0
		[SerializeField]
		private List<RectTransform> _limitDirectionNodes; // 0xB8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
	
		// Nested types
		public enum MaskShapeType // TypeDefIndex: 52551
		{
			Rectangle = 0,
			Circle = 1
		}
	
		// Constructors
		public UILevelMapLimitInRect() {} // 0x0000000182846010-0x0000000182846020
	
		// Methods
		public override void LateTick(float deltaTime) {} // 0x0000000182584F80-0x0000000182584FD0
		protected override void OnEnable() {} // 0x0000000183A92890-0x0000000183A928D0
		protected override void OnRelease() {} // 0x0000000183B42380-0x0000000183B423C0
		private void _LimitInRect() {} // 0x00000001825857F0-0x00000001825863D0
		public void ClearComponent() {} // 0x0000000183B423C0-0x0000000183B42400
		public void StartLimitMarkInRect() {} // 0x00000001839C1340-0x00000001839C13D0
		public void StopLimitMarkInRect() {} // 0x0000000183D42D80-0x0000000183D42DE0
		public void ForceRefreshLimitState() {} // 0x0000000183C902F0-0x0000000183C90330
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
	}

	public class UILevelMapLine : TickableUIMono, IUIClearable // TypeDefIndex: 52553
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
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
	
		// Constructors
		public UILevelMapLine() {} // 0x0000000182846020-0x0000000182846030
	
		// Methods
		protected override void OnEnable() {} // 0x0000000183553030-0x0000000183553070
		private void _HoldLineSize() {} // 0x000000018262C9F0-0x000000018262CD10
		public override void LateTick(float deltaTime) {} // 0x000000018262CDC0-0x000000018262D2D0
		public void Init(float basicLength) {} // 0x000000018338E820-0x000000018338E990
		public void ClearComponent() {} // 0x0000000182C72290-0x0000000182C722C0
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	public class UILevelMapMissionArea : TickableUIMono, IUIClearable // TypeDefIndex: 52555
	{
		// Fields
		private GameObject m_associatedTrackingMark; // 0x68
		private bool m_initialized; // 0x70
		private readonly Vector3[] m_disappearWorldCorners; // 0x78
		private readonly Vector3[] m_circleWorldCorners; // 0x80
		private float m_missionGuideArea; // 0x88
		public bool needUseCenterPosition; // 0x8C
		[SerializeField]
		private LuaPanel _luaPanel; // 0x90
		[SerializeField]
		private RectTransform _rectTransform; // 0x98
		[SerializeField]
		private RectTransform _circleRectTransform; // 0xA0
		[SerializeField]
		private CanvasGroup _canvasGroup; // 0xA8
		[SerializeField]
		private bool _coexistWithMissionTrack; // 0xB0
		[SerializeField]
		private float _notCoexistGuideAreaRadius; // 0xB4
		[SerializeField]
		private RectTransform _disappearRect; // 0xB8
		[SerializeField]
		private DisappearRectShapeType _disappearRectShape; // 0xC0
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
		public bool needCheckMissionTrackCoexist { get => default; } // 0x00000001828AF1D0-0x00000001828AF1F0 
		public bool coexistWithMissionTrack { get => default; } // 0x0000000181151530-0x0000000181151540 
		public bool notNeedCheckCoexistBecauseOfRadius { get => default; } // 0x00000001828AF1F0-0x00000001828AF210 
	
		// Nested types
		public enum DisappearRectShapeType // TypeDefIndex: 52554
		{
			Rectangle = 0,
			Circle = 1
		}
	
		// Constructors
		public UILevelMapMissionArea() {} // 0x0000000183A293A0-0x0000000183A29420
	
		// Methods
		public override void LateTick(float deltaTime) {} // 0x00000001828AF0D0-0x00000001828AF110
		private void _RefreshMissionArea(MissionTrackingMarkInstRuntimeDate missionMarkInstRuntimeData) {} // 0x00000001837BEEA0-0x00000001837BEFC0
		private bool _IsCircleOutsideDisappearRect() => default; // 0x00000001828AF210-0x00000001828AF5C0
		private void _DisappearIfOutRect() {} // 0x00000001828AF110-0x00000001828AF1D0
		public void Init(MissionTrackingMarkInstRuntimeDate missionMarkInstRuntimeData, GameObject associatedTrackingMark) {} // 0x00000001837BEDE0-0x00000001837BEEA0
		public void ClearComponent() {} // 0x0000000183CDE7B0-0x0000000183CDE7F0
		public void ForceRefreshDisappearIfOutRect() {} // 0x0000000183D00CF0-0x0000000183D00D30
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	public class UILevelMapMisty : MonoBehaviour, IUIClearable // TypeDefIndex: 52556
	{
		// Fields
		private CombineKey m_eventKey; // 0x18
		private bool m_needBind; // 0x1C
		private const long INVISIBLE_STATE_VALUE = 1; // Metadata: 0x01FD22E7
		private const string MISTY_GAME_VAR_KEY = "huanzhuline_game_finish"; // Metadata: 0x01FD22EF
	
		// Constructors
		public UILevelMapMisty() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void OnDestroy() {} // 0x0000000189B3E018-0x0000000189B3E068
		private void _RefreshMistyState() {} // 0x0000000189B3E278-0x0000000189B3E2F4
		private void _OnMistyStateChanged([IsReadOnly] in EventData<long, long> eventData) {} // 0x0000000189B3E208-0x0000000189B3E278
		private void _BindAll() {} // 0x0000000189B3E068-0x0000000189B3E208
		private void _UnBindAll() {} // 0x0000000189B3E2F4-0x0000000189B3E3D8
		public void InitMisty() {} // 0x0000000189B3DEFC-0x0000000189B3DF60
		public static bool IsMistyVisible() => default; // 0x0000000189B3DF60-0x0000000189B3E018
		public void ClearComponent() {} // 0x0000000183D4CB80-0x0000000183D4CBB0
	}

	public class UILevelMapSwitchBtn : MonoBehaviour, IUIClearable // TypeDefIndex: 52558
	{
		// Fields
		[SerializeField]
		private UIButton _button; // 0x18
		[SerializeField]
		private UIText _text; // 0x20
		[SerializeField]
		private GameObject _mainContent; // 0x28
		[SerializeField]
		private RectTransform _direction; // 0x30
	
		// Constructors
		public UILevelMapSwitchBtn() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void InitSwitchButton(string targetLevelId, float directionAngle) {} // 0x0000000182CDFAA0-0x0000000182CDFEF0
		public void ClearComponent() {} // 0x0000000183873990-0x0000000183873A50
	}

	public class UILevelMapTouchPanelWrapper : TickableUIMono // TypeDefIndex: 52559
	{
		// Fields
		[SerializeField]
		private UITouchPanel _touchPanel; // 0x68
		[SerializeField]
		private float _scrollCorrectionCoefficient; // 0x70
		[SerializeField]
		private Transform _raycastRoot; // 0x78
		private int m_lastTouchCount; // 0x80
		private PointerEventData m_dragPointerEventData; // 0x88
		private PointerEventData m_scrollPointerEventData; // 0x90
		private bool m_inWrapperDragging; // 0x98
		private Vector2 m_lastPointerPos; // 0x9C
		private readonly List<RaycastResult> m_raycastResults; // 0xA8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Constructors
		public UILevelMapTouchPanelWrapper() {} // 0x0000000189B3EDA0-0x0000000189B3EE28
	
		// Methods
		protected override void OnAwake() {} // 0x0000000189B3E3D8-0x0000000189B3E530
		public override void Tick(float deltaTime) {} // 0x0000000189B3E530-0x0000000189B3E63C
		private bool _IsFirstRaycastSelectable(PointerEventData pointerEventData) => default; // 0x0000000189B3EB2C-0x0000000189B3EDA0
		private void _CheckDrag() {} // 0x0000000189B3E63C-0x0000000189B3E984
		private void _CheckScroll() {} // 0x0000000189B3E984-0x0000000189B3EB2C
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
	}

	public class UIRegionMap3DPanel : UIPanelBase // TypeDefIndex: 52560
	{
		// Fields
		public const string HOVER_ANIM_NAME = "regionmap3d_map_hover"; // Metadata: 0x01FD2307
		[SerializeField]
		private LuaPanel _luaPanel; // 0x70
		[SerializeField]
		private UIAnimationWrapper _panelAnimationWrapper; // 0x78
		[SerializeField]
		private Transform _zoomRoot; // 0x80
		[SerializeField]
		private Transform _moveRoot; // 0x88
		[SerializeField]
		private float _moveDuration; // 0x90
		[SerializeField]
		private float _completeRatio; // 0x94
		[SerializeField]
		private AnimationCurve _moveCurve; // 0x98
		[SerializeField]
		private AnimationCurve _rotationCurve; // 0xA0
		[SerializeField]
		private float _zoomDistance; // 0xA8
		[SerializeField]
		private AnimationCurve _zoomCurve; // 0xB0
		private RegionMapSetting m_regionMapSetting; // 0xB8
		private string m_toLevel; // 0xC0
		private string m_toInsId; // 0xC8
		private TweenerCore<Vector3, Vector3, VectorOptions> m_moveTween; // 0xD0
		private TweenerCore<Quaternion, Quaternion, NoOptions> m_rotateTween; // 0xD8
		private TweenerCore<Vector3, Vector3, VectorOptions> m_zoomTween; // 0xE0
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public UIRegionMap3DPanel() {} // 0x0000000189B41D10-0x0000000189B41D2C
	
		// Methods
		private Transform _GetNodeTransform(string levelId) => default; // 0x0000000189B41B24-0x0000000189B41B90
		private Vector3 _GetMoveTargetLocalPosition(string levelId) => default; // 0x0000000189B41A70-0x0000000189B41B24
		private void _OnDoMoveTween() {} // 0x0000000189B41B90-0x0000000189B41D10
		public void InitPanel(RegionMapSetting regionMapSetting) {} // 0x0000000189B4148C-0x0000000189B415A4
		public void OnClickLevelBtn(string levelId, string insId) {} // 0x0000000189B415A4-0x0000000189B418EC
		public void OnLevelHoverChanged(string levelId, bool isHover) {} // 0x0000000189B418EC-0x0000000189B41A70
	}

	public class UIRegionMap3DUICell : UIPanelBase // TypeDefIndex: 52561
	{
		// Fields
		public UIText showName; // 0x70
		public RectTransform iconRoot; // 0x78
		public UIButton btn; // 0x80
	
		// Constructors
		public UIRegionMap3DUICell() {} // 0x0000000183D47C80-0x0000000183D47C90
	}

	public class UIRegionMapTrackIcon : UIPanelBase // TypeDefIndex: 52562
	{
		// Fields
		[SerializeField]
		private UIImage _icon; // 0x70
		[SerializeField]
		private UIImage _track; // 0x78
	
		// Constructors
		public UIRegionMapTrackIcon() {} // 0x0000000183D47C80-0x0000000183D47C90
	
		// Methods
		public void InitData(MissionTrackingMarkInstRuntimeDate data) {} // 0x0000000183A2C0D0-0x0000000183A2C250
	}

	public class UISettlementRegion : MonoBehaviour, IUIClearable // TypeDefIndex: 52565
	{
		// Fields
		private string m_settlementId; // 0x18
		private SettlementRegionSpriteData m_settlementSpriteData; // 0x20
		private bool m_needBind; // 0x28
		private CombineKey m_bindKey; // 0x2C
		[SerializeField]
		private SerializeFieldDictionary<string, SettlementRegionSpriteData> _spriteDict; // 0x30
		[SerializeField]
		private RectTransform _rectTransform; // 0x38
		[SerializeField]
		private UIImage _image; // 0x40
		public const string SETTLEMENT_REGION_SPRITE_FOLDER = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/Map/SettlementRegion/"; // Metadata: 0x01FD231E
	
		// Nested types
		[Serializable]
		public class SettlementRegionSpritePath // TypeDefIndex: 52563
		{
			// Fields
			public string path; // 0x10
	
			// Constructors
			public SettlementRegionSpritePath() {} // 0x000000018350B670-0x000000018350B680
		}
	
		[Serializable]
		public class SettlementRegionSpriteData // TypeDefIndex: 52564
		{
			// Fields
			public SerializeFieldDictionary<int, SettlementRegionSpritePath> spriteWithTier; // 0x10
	
			// Constructors
			public SettlementRegionSpriteData() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public UISettlementRegion() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void OnDestroy() {} // 0x0000000183A4E710-0x0000000183A4E750
		private void _RefreshSpriteWithTier(int tier = 0 /* Metadata: 0x01FD231D */) {} // 0x0000000182F43660-0x0000000182F43760
		private void _RefreshSettlementRegionState() {} // 0x0000000182F42050-0x0000000182F42170
		private void _OnSettlementUnlocked([IsReadOnly] in EventData<string> param) {} // 0x0000000189B41E8C-0x0000000189B41EFC
		private void _BindAll() {} // 0x0000000189B41D90-0x0000000189B41E8C
		private void _UnBindAll() {} // 0x0000000189B41EFC-0x0000000189B41FF0
		public void InitSettlementRegion(string settlementId, Vector3 centerPos) {} // 0x0000000182F41FF0-0x0000000182F42050
		public bool GetNeedRefreshSettlementRegionTier() => default; // 0x0000000183B13160-0x0000000183B131D0
		public void RefreshSettlementRegionWithTier(int tier) {} // 0x0000000189B41D2C-0x0000000189B41D90
		public void ClearComponent() {} // 0x0000000183A4E750-0x0000000183A4E7F0
	}

	public class ChessboardDrop : UIBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler, IUIClearable // TypeDefIndex: 52566
	{
		// Fields
		[NonSerialized]
		public UnityEvent<PointerEventData> onDropEvent; // 0x18
		[NonSerialized]
		public UnityEvent<PointerEventData> onPointerEnterEvent; // 0x20
		[NonSerialized]
		public UnityEvent<PointerEventData> onPointerExitEvent; // 0x28
	
		// Constructors
		public ChessboardDrop() {} // 0x0000000189B37098-0x0000000189B3717C
	
		// Methods
		public void OnDrop(PointerEventData eventData) {} // 0x0000000189B36DE4-0x0000000189B36E80
		public void OnPointerEnter(PointerEventData eventData) {} // 0x0000000189B36E80-0x0000000189B36F1C
		public void OnPointerExit(PointerEventData eventData) {} // 0x0000000189B36F1C-0x0000000189B36FB8
		private bool _CheckEventValid(PointerEventData eventData) => default; // 0x0000000189B36FB8-0x0000000189B37098
		public void ClearComponent() {} // 0x0000000189B36D1C-0x0000000189B36D94
		protected override void OnDestroy() {} // 0x0000000189B36D94-0x0000000189B36DE4
		public void __iFixBaseProxy_OnDestroy() {} // 0x000000018350B670-0x000000018350B680
	}

	public class PuzzleCellDrag : UIBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 52567
	{
		// Fields
		private PuzzleDrag m_parent; // 0x18
		[SerializeField]
		private bool _needHovering; // 0x20
	
		// Constructors
		public PuzzleCellDrag() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void Init(PuzzleDrag puzzleDrag) {} // 0x0000000189B39060-0x0000000189B390C4
		public void OnBeginDrag(PointerEventData eventData) {} // 0x0000000189B390C4-0x0000000189B39130
		public void OnDrag(PointerEventData eventData) {} // 0x0000000189B39130-0x0000000189B3919C
		public void OnEndDrag(PointerEventData eventData) {} // 0x0000000189B3919C-0x0000000189B39208
		public void OnPointerDown(PointerEventData eventData) {} // 0x0000000189B39274-0x0000000189B392E0
		public void OnPointerUp(PointerEventData eventData) {} // 0x0000000189B393C0-0x0000000189B3942C
		public void OnPointerClick(PointerEventData eventData) {} // 0x0000000189B39208-0x0000000189B39274
		public void OnPointerEnter(PointerEventData eventData) {} // 0x0000000189B392E0-0x0000000189B39350
		public void OnPointerExit(PointerEventData eventData) {} // 0x0000000189B39350-0x0000000189B393C0
	}

	public class PuzzleControllerHelper : UIBehaviour // TypeDefIndex: 52568
	{
		// Fields
		private LuaPanel m_luaPanel; // 0x18
		private PointerEventData m_controllerFocusEventData; // 0x20
		private readonly List<RaycastResult> m_raycastResults; // 0x28
	
		// Properties
		public List<RaycastResult> raycastResults { get => default; } // 0x0000000189B39904-0x0000000189B39954 
	
		// Constructors
		public PuzzleControllerHelper() {} // 0x0000000189B39884-0x0000000189B39904
	
		// Methods
		protected override void Awake() {} // 0x0000000189B3942C-0x0000000189B3951C
		public int TryGetPuzzleSlotIndexByPos(RectTransform gridCell) => default; // 0x0000000189B3951C-0x0000000189B39884
		public void __iFixBaseProxy_Awake() {} // 0x000000018350B670-0x000000018350B680
	}

	public class PuzzleDrag : UIBehaviour, IUIClearable, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 52569
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
		public LuaPanel panel { get => default; } // 0x0000000189B3A1E0-0x0000000189B3A298 
		public int luaIndex { get => default; } // 0x0000000183D4EB90-0x0000000183D4EBA0 
	
		// Constructors
		public PuzzleDrag() {} // 0x0000000189B39FF8-0x0000000189B3A1E0
	
		// Methods
		protected override void Awake() {} // 0x0000000189B39954-0x0000000189B399D4
		public void OnBeginDrag(PointerEventData eventData) {} // 0x0000000189B39AA4-0x0000000189B39B50
		public void OnDrag(PointerEventData eventData) {} // 0x0000000189B39BA0-0x0000000189B39C38
		public void OnEndDrag(PointerEventData eventData) {} // 0x0000000189B39C38-0x0000000189B39CE4
		public void OnPointerDown(PointerEventData eventData) {} // 0x0000000189B39D70-0x0000000189B39DFC
		public void OnPointerUp(PointerEventData eventData) {} // 0x0000000189B39F14-0x0000000189B39FA0
		public void OnPointerClick(PointerEventData eventData) {} // 0x0000000189B39CE4-0x0000000189B39D70
		public void OnPointerEnter(PointerEventData eventData) {} // 0x0000000189B39DFC-0x0000000189B39E88
		public void OnPointerExit(PointerEventData eventData) {} // 0x0000000189B39E88-0x0000000189B39F14
		public void ClearComponent() {} // 0x0000000189B399D4-0x0000000189B39AA4
		protected override void OnDestroy() {} // 0x0000000189B39B50-0x0000000189B39BA0
		public void SetIndex(int index) {} // 0x0000000189B39FA0-0x0000000189B39FF8
		public void __iFixBaseProxy_Awake() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy_OnDestroy() {} // 0x000000018350B670-0x000000018350B680
	}

	[RequireComponent(typeof(UIImage))]
	public class UIBrokenLine : MonoBehaviour // TypeDefIndex: 52570
	{
		// Fields
		private Material m_material; // 0x18
		private const int MAX_SET_VALUE_COUNT = 21; // Metadata: 0x01FD2367
		private const string UI_BROKEN_LINE_SHADER_NAME = "HGRP/UI/BrokenLine"; // Metadata: 0x01FD2368
		private const string Y_VALUE_PROPERTY_NAME_FORMAT = "_YValue{0}"; // Metadata: 0x01FD237B
		private const string X_SCALE_PROPERTY_NAME = "_XScale"; // Metadata: 0x01FD2386
		private const string LINE_WEIGHT_PROPERTY_NAME = "_LineWidth"; // Metadata: 0x01FD238E
		private List<float> m_tmpList; // 0x20
		private bool m_isInit; // 0x28
		[SerializeField]
		private float _lineWeight; // 0x2C
	
		// Constructors
		public UIBrokenLine() {} // 0x0000000189B3B594-0x0000000189B3B61C
	
		// Methods
		private void Awake() {} // 0x0000000189B3AEDC-0x0000000189B3AF34
		private void _Init() {} // 0x0000000189B3B398-0x0000000189B3B594
		private void OnDestroy() {} // 0x0000000189B3AF34-0x0000000189B3AFB4
		public void SetYValueByArray(float[] yValue, int count = 21 /* Metadata: 0x01FD2365 */) {} // 0x0000000189B3AFB4-0x0000000189B3B0AC
		public void SetYValue(List<float> yValue, int count = 21 /* Metadata: 0x01FD2366 */) {} // 0x0000000189B3B0AC-0x0000000189B3B398
	}

	public class UICommonScanController : TickableUIMono // TypeDefIndex: 52571
	{
		// Fields
		protected Transform m_camera; // 0x70
		protected ObjectPtr<Entity> m_entity; // 0x78
		protected Transform m_followTarget; // 0x88
		public float yOffset; // 0x90
		public static readonly int STATE_ON; // 0x00
		public static readonly int STATE_OFF; // 0x04
		public const int MAX_HP_RATIO = 10000; // Metadata: 0x01FD2399
		public const float TICK_REFRESH_NEED = 0.1f; // Metadata: 0x01FD239D
		public const int DONT_REFRESH = 0; // Metadata: 0x01FD23A1
		private bool m_uiActive; // 0x94
		protected long m_nextRefreshTime; // 0x98
		protected float m_hpRatio; // 0xA0
		protected Vector3 m_fixedPoint; // 0xA4
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
		public ulong entityLogicId { get; set; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x0000000183D4F040-0x0000000183D4F050
		protected bool uiActive { get => default; set {} } // 0x0000000183D6CD80-0x0000000183D6CD90 0x0000000189B3BE64-0x0000000189B3BED8
	
		// Constructors
		public UICommonScanController() {} // 0x0000000182846010-0x0000000182846020
		static UICommonScanController() {} // 0x0000000189B3BE14-0x0000000189B3BE64
	
		// Methods
		public virtual void SetTarget(Entity target, long nextRefresh, float hpRatio) {} // 0x0000000189B3B8EC-0x0000000189B3BA48
		private void _UpdatePos() {} // 0x0000000189B3BC74-0x0000000189B3BE14
		public void SetFixPoint(Vector3 pos, ulong waterVolume) {} // 0x0000000189B3B70C-0x0000000189B3B8EC
		public override void Tick(float deltaTime) {} // 0x0000000189B3BA48-0x0000000189B3BAC8
		private void _FaceToCamera() {} // 0x0000000189B3BAC8-0x0000000189B3BC74
		public virtual void Clear() {} // 0x0000000189B3B61C-0x0000000189B3B70C
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
	}

	public class UICountDownBar : TickableUIMono // TypeDefIndex: 52572
	{
		// Fields
		[SerializeField]
		private UIText _countDownTxt; // 0x68
		private float m_countDownTime; // 0x70
		private int m_id; // 0x74
		private Transform m_target; // 0x78
		private CountDownShowAction.Data m_data; // 0x80
		private Transform m_camera; // 0x88
		private bool m_update; // 0x90
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
		private bool update { get => default; set {} } // 0x0000000183D58A70-0x0000000183D58A80 0x0000000189B3C434-0x0000000189B3C4A8
	
		// Constructors
		public UICountDownBar() {} // 0x0000000182846010-0x0000000182846020
	
		// Methods
		public void InitData(int id, AbilitySystem target, CountDownShowAction.Data data) {} // 0x0000000189B3BF68-0x0000000189B3C0B8
		public void Clear() {} // 0x0000000189B3BED8-0x0000000189B3BF68
		public override void LateTick(float deltaTime) {} // 0x0000000189B3C0B8-0x0000000189B3C13C
		private void _UpdateData(float deltaTime) {} // 0x0000000189B3C13C-0x0000000189B3C1F8
		private void _UpdatePos() {} // 0x0000000189B3C1F8-0x0000000189B3C434
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	public class UIDoodadMineCoreScanController : UICommonScanController // TypeDefIndex: 52573
	{
		// Fields
		public GameObject canMineIcon; // 0xB0
		public UIText formingText; // 0xB8
		public UIText purityText; // 0xC0
	
		// Constructors
		public UIDoodadMineCoreScanController() {} // 0x0000000189B3C684-0x0000000189B3C6D0
	
		// Methods
		public void SyncConditonInfo(bool forming, string condition) {} // 0x0000000189B3C58C-0x0000000189B3C608
		public void SetPurity(bool forming, string conditionText) {} // 0x0000000189B3C4A8-0x0000000189B3C58C
		public void UpdateUI(bool forming, string condition) {} // 0x0000000189B3C608-0x0000000189B3C684
	}

	public class UIDoodadPlantCoreScanController : UICommonScanController // TypeDefIndex: 52574
	{
		// Fields
		private const uint OFF = 0; // Metadata: 0x01FD23AA
		private const uint DARK = 1; // Metadata: 0x01FD23AB
		private const uint LIGHT = 2; // Metadata: 0x01FD23AC
		private const uint GROW = 4; // Metadata: 0x01FD23AD
		public UIText coreNameText; // 0xB0
		public UIText coreSizeText; // 0xB8
		public GameObject refreshTimeRoot; // 0xC0
		public UIText refreshTimeText; // 0xC8
		public List<GameObject> flowerDark; // 0xD0
		public List<GameObject> flowerLight; // 0xD8
		public List<GameObject> flowerGrow; // 0xE0
		private float m_tickTimeSum; // 0xE8
	
		// Constructors
		public UIDoodadPlantCoreScanController() {} // 0x0000000189B3CDE0-0x0000000189B3CEF0
	
		// Methods
		public override void Tick(float deltaTime) {} // 0x0000000189B3CA94-0x0000000189B3CB58
		public void SetCoreInfo(string coreName, string coreSize) {} // 0x0000000189B3C720-0x0000000189B3C7BC
		public void SetRefreshInfo(long nextRefreshTime = 0 /* Metadata: 0x01FD23A2 */) {} // 0x0000000189B3C91C-0x0000000189B3C98C
		public void RefreshTextNow() {} // 0x0000000189B3C6D0-0x0000000189B3C720
		public void SetQuantityInfo(int current, int nextRefresh, int maxCount) {} // 0x0000000189B3C7BC-0x0000000189B3C91C
		public void SetSingle(int index, uint state) {} // 0x0000000189B3C98C-0x0000000189B3CA94
		private void _SyncTimeText() {} // 0x0000000189B3CB60-0x0000000189B3CDE0
		public void __iFixBaseProxy_Tick(float P0) {} // 0x0000000189B3CB58-0x0000000189B3CB60
	}

	public class UIDoodadScanController : UICommonScanController // TypeDefIndex: 52575
	{
		// Fields
		public UIText timeCom; // 0xB0
		public Transform refreshFull; // 0xB8
		public Transform refreshProgress; // 0xC0
		private float m_tickTimeSum; // 0xC8
	
		// Constructors
		public UIDoodadScanController() {} // 0x0000000189B3D50C-0x0000000189B3D560
	
		// Methods
		public void SyncRefreshInfo(long nextRefresh, float hpRatio) {} // 0x0000000189B3CEF0-0x0000000189B3D000
		public override void Tick(float deltaTime) {} // 0x0000000189B3D000-0x0000000189B3D0C4
		private void _RefreshCountDown() {} // 0x0000000189B3D174-0x0000000189B3D50C
		public void UpdateUI(long nextRefresh, float hpRatio) {} // 0x0000000189B3D0C4-0x0000000189B3D174
		public void __iFixBaseProxy_Tick(float P0) {} // 0x0000000189B3CB58-0x0000000189B3CB60
	}

	public class UIGeneralTracker : MonoBehaviour // TypeDefIndex: 52576
	{
		// Fields
		[SerializeField]
		private Transform _arrowRotator; // 0x18
		private RectTransform m_rect; // 0x20
	
		// Properties
		private RectTransform rect { get => default; } // 0x0000000189B3D6E8-0x0000000189B3D7BC 
	
		// Constructors
		public UIGeneralTracker() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void UpdatePosition(Vector2 uiPos, float uiAngle, bool isOutBound) {} // 0x0000000189B3D5EC-0x0000000189B3D6E8
	}

	public class UILiquidPoolScanController : UICommonScanController // TypeDefIndex: 52577
	{
		// Fields
		public GameObject unLimitGroup; // 0xB0
		public GameObject limitedGroup; // 0xB8
		public UIText currentAmountText; // 0xC0
		public UIText maxAmountText; // 0xC8
		public UIText waterNameText; // 0xD0
		private const string EMPTY_LIQUID = "ui_liquid_pool_scan_text_empty"; // Metadata: 0x01FD23AE
		private LangKey m_key; // 0xD8
	
		// Constructors
		public UILiquidPoolScanController() {} // 0x0000000189B3F388-0x0000000189B3F40C
	
		// Methods
		public void SetWaterInfo(ulong waterId, int x, int y, int z) {} // 0x0000000189B3EE28-0x0000000189B3F388
	}

	public class UIPanelBase : TickableUIMono // TypeDefIndex: 52578
	{
		// Fields
		public const string UI_SPRITE_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/{0}.png"; // Metadata: 0x01FD23CD
		private LuaResourceLoader m_loader; // 0x68
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public UIPanelBase() {} // 0x0000000182845F80-0x0000000182845FF0
	
		// Methods
		protected override void OnRelease() {} // 0x0000000189B3F40C-0x0000000189B3F470
		public Sprite LoadSprite(string path, string name) => default; // 0x0000000182B77AC0-0x0000000182B77B50
		public Sprite LoadSpriteWithOutFormat(string path) => default; // 0x000000018341D480-0x000000018341D4F0
		public GameObject LoadGameObject(string path) => default; // 0x0000000182F67CF0-0x0000000182F67D60
		protected string GetSpritePath(string path, string name) => default; // 0x0000000182B77BC0-0x0000000182B77C60
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
	}

	public class UIPowerPoleAutoConnectTracker : UIGeneralTracker // TypeDefIndex: 52581
	{
		// Fields
		[SerializeField]
		private GameObject _rootDistance; // 0x28
		[SerializeField]
		private UIText _textDistance; // 0x30
		[SerializeField]
		private UnityEngine.Color _textColorNormal; // 0x38
		[SerializeField]
		private UnityEngine.Color _textColorDisable; // 0x48
		[SerializeField]
		private UnityEngine.Color _textColorError; // 0x58
		[SerializeField]
		private CanvasGroup _colorScaleControlGroup; // 0x68
		[SerializeField]
		private float _activeScale; // 0x70
		[SerializeField]
		private IconGroup _defaultIcon; // 0x78
		[SerializeField]
		private IconGroup _diffuserIcon; // 0x80
		[SerializeField]
		private IconGroup _hubIcon; // 0x88
		[SerializeField]
		private IconGroup _subhubIcon; // 0x90
		[SerializeField]
		private IconGroup _terminalIcon; // 0x98
		[SerializeField]
		private IconGroup _stationIcon; // 0xA0
		[SerializeField]
		private StatusHintGroup _statusHintGroup; // 0xA8
		private PowerAutoConnectStatus? m_currentStatus; // 0xB0
	
		// Nested types
		[Serializable]
		public class IconGroup // TypeDefIndex: 52579
		{
			// Fields
			public GameObject root; // 0x10
			public Image normal; // 0x18
			public Image error; // 0x20
	
			// Properties
			public bool activeSelf { get => default; } // 0x0000000189B39040-0x0000000189B39060 
	
			// Constructors
			public IconGroup() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void SetActiveIfNecessary(bool active) {} // 0x0000000189B38F50-0x0000000189B38FB0
			public void Switch(bool err) {} // 0x0000000189B38FB0-0x0000000189B39040
		}
	
		[Serializable]
		public class StatusHintGroup // TypeDefIndex: 52580
		{
			// Fields
			public GameObject root; // 0x10
			public GameObject localLinkHint; // 0x18
			public GameObject globalLinkHint; // 0x20
			public GameObject outageHint; // 0x28
			public GameObject distLimitHint; // 0x30
	
			// Constructors
			public StatusHintGroup() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void Switch(PowerAutoConnectStatus status) {} // 0x0000000189B3ADAC-0x0000000189B3AE50
		}
	
		// Constructors
		public UIPowerPoleAutoConnectTracker() {} // 0x0000000189B3F9FC-0x0000000189B3FA58
	
		// Methods
		public void UpdateDistance(float distance) {} // 0x0000000189B3F470-0x0000000189B3F53C
		private void _ActualUpdateStatus(PowerAutoConnectStatus status) {} // 0x0000000189B3F7A4-0x0000000189B3F9FC
		public void UpdateStatus(PowerAutoConnectStatus status) {} // 0x0000000189B3F600-0x0000000189B3F6A8
		private void _ActualUpdateIcon(IconGroup img) {} // 0x0000000189B3F6A8-0x0000000189B3F7A4
		public void UpdateNodeType(int nodeType) {} // 0x0000000189B3F53C-0x0000000189B3F600
	}

	public class UIPowerPoleFastTravelTracker : UIGeneralTracker // TypeDefIndex: 52583
	{
		// Fields
		[SerializeField]
		private UIText _textDistance; // 0x28
		[SerializeField]
		private UnityEngine.Color _textColorNormal; // 0x30
		[SerializeField]
		private UnityEngine.Color _textColorWarning; // 0x40
		[SerializeField]
		private UnityEngine.Color _textColorHighlighted; // 0x50
		[SerializeField]
		private UnityEngine.Color _textColorDisabled; // 0x60
		[SerializeField]
		private GameObject _parentNormal; // 0x70
		[SerializeField]
		private UIAnimationWrapper _animationWrapperNormal; // 0x78
		[SerializeField]
		private GameObject _imageNormal; // 0x80
		[SerializeField]
		private GameObject _imageNormalOther; // 0x88
		[SerializeField]
		private GameObject _imageWarning; // 0x90
		[SerializeField]
		private GameObject _imageHighlighted; // 0x98
		[SerializeField]
		private GameObject _imageHighlightedOther; // 0xA0
		[SerializeField]
		private GameObject _imageDisabled; // 0xA8
		[SerializeField]
		private GameObject _parentUpgraded; // 0xB0
		[SerializeField]
		private UIAnimationWrapper _animationWrapperUpgraded; // 0xB8
		[SerializeField]
		private GameObject _imageNormalUpgraded; // 0xC0
		[SerializeField]
		private GameObject _imageNormalUpgradedOther; // 0xC8
		[SerializeField]
		private GameObject _imageWarningUpgraded; // 0xD0
		[SerializeField]
		private GameObject _imageHighlightedUpgraded; // 0xD8
		[SerializeField]
		private GameObject _imageHighlightedUpgradedOther; // 0xE0
		[SerializeField]
		private GameObject _imageDisabledUpgraded; // 0xE8
		[SerializeField]
		private GameObject _parentDefaultNext; // 0xF0
		[SerializeField]
		private UIAnimationWrapper _animationWrapperNext; // 0xF8
		[SerializeField]
		private GameObject _imageNormalDefaultNext; // 0x100
		[SerializeField]
		private GameObject _imageNormalDefaultNextOther; // 0x108
		[SerializeField]
		private GameObject _imageWarningDefaultNext; // 0x110
		[SerializeField]
		private GameObject _imageHighlightedDefaultNext; // 0x118
		[SerializeField]
		private GameObject _imageHighlightedDefaultNextOther; // 0x120
		[SerializeField]
		private GameObject _imageDisabledDefaultNext; // 0x128
		[SerializeField]
		private GameObject _textInfoBg; // 0x130
		[SerializeField]
		private SerializeFieldDictionary<TravelPoleBrain.TravelPoleStatus, TravelPoleStatusSetting> _statusSettingDict; // 0x138
		private TravelPoleBrain.TravelPoleIcon m_iconStatus; // 0x140
		private TravelPoleBrain.TravelPoleStatus m_status; // 0x144
		private bool m_isHighlighted; // 0x148
		private bool m_isOtherSocial; // 0x149
		private string m_distanceFormatText; // 0x150
	
		// Properties
		private bool isWarning { get => default; } // 0x0000000189B4090C-0x0000000189B40924 
		private bool isDisabled { get => default; } // 0x0000000189B40898-0x0000000189B4090C 
		public bool allowToHighlight { get => default; } // 0x0000000189B404F0-0x0000000189B4051C 
		private TravelPoleBrain.TravelPoleIcon iconStatus { get => default; set {} } // 0x00000001811B8720-0x00000001811B8730 0x0000000189B40924-0x0000000189B409C4
		private TravelPoleBrain.TravelPoleStatus status { get => default; set {} } // 0x0000000183D76300-0x0000000183D76310 0x0000000189B409C4-0x0000000189B409DC
		private UIAnimationWrapper animationWrapper { get => default; } // 0x0000000189B4051C-0x0000000189B40598 
		private GameObject imageNormal { get => default; } // 0x0000000189B40798-0x0000000189B40818 
		private GameObject imageWarning { get => default; } // 0x0000000189B40818-0x0000000189B40898 
		private GameObject imageDisabled { get => default; } // 0x0000000189B40598-0x0000000189B40618 
		private GameObject imageHighlighted { get => default; } // 0x0000000189B40698-0x0000000189B40718 
		private GameObject imageNormalOther { get => default; } // 0x0000000189B40718-0x0000000189B40798 
		private GameObject imageHighlightedOther { get => default; } // 0x0000000189B40618-0x0000000189B40698 
	
		// Nested types
		[Serializable]
		private struct TravelPoleStatusSetting // TypeDefIndex: 52582
		{
			// Fields
			[SerializeField]
			public bool showTextInfoBg; // 0x00
			[SerializeField]
			public GameObject textToShow; // 0x08
		}
	
		// Constructors
		public UIPowerPoleFastTravelTracker() {} // 0x0000000189B40488-0x0000000189B404F0
	
		// Methods
		public void PlayFocus() {} // 0x0000000189B3FAB8-0x0000000189B3FB20
		public void UpdateIconStatus(TravelPoleBrain.TravelPoleIcon value) {} // 0x0000000189B3FC34-0x0000000189B3FC98
		public void UpdateStatus(TravelPoleBrain.TravelPoleStatus value) {} // 0x0000000189B3FD60-0x0000000189B3FDC4
		public void UpdateIsHighlighted(bool value) {} // 0x0000000189B3FC98-0x0000000189B3FCFC
		public void UpdateIsOtherSocial(bool value) {} // 0x0000000189B3FCFC-0x0000000189B3FD60
		public void UpdateDistance(Vector3 value) {} // 0x0000000189B3FB20-0x0000000189B3FC34
		private void _OnStatusChanged() {} // 0x0000000189B3FDC4-0x0000000189B4004C
		private void _UpdateIcon() {} // 0x0000000189B4004C-0x0000000189B40488
		private void OnEnable() {} // 0x0000000189B3FA58-0x0000000189B3FAB8
	}

	public class UIRaceModuleRankController : TickableUIMono // TypeDefIndex: 52585
	{
		// Fields
		private readonly LuaResourceLoader m_loader; // 0x68
		[SerializeField]
		public UIImage image; // 0x70
		[SerializeField]
		public Transform greyNode; // 0x78
		[SerializeField]
		public Transform lightNode; // 0x80
		[SerializeField]
		public UIText text; // 0x88
		public const string FIRST_ICON = "icon_racemodule_rank_1.png"; // Metadata: 0x01FD2406
		public const string SECOND_ICON = "icon_racemodule_rank_2.png"; // Metadata: 0x01FD2421
		public const string THIRD_ICON = "icon_racemodule_rank_3.png"; // Metadata: 0x01FD243C
		public const string FOURTH_ICON = "icon_racemodule_rank_4.png"; // Metadata: 0x01FD2457
		public const string FIFTH_ICON = "icon_racemodule_rank_5.png"; // Metadata: 0x01FD2472
		private Sprite m_sprite1; // 0x90
		private Sprite m_sprite2; // 0x98
		private Sprite m_sprite3; // 0xA0
		private Sprite m_sprite4; // 0xA8
		private Sprite m_sprite5; // 0xB0
		private ERank m_rankEnum; // 0xB8
		private float m_restTime; // 0xBC
		private bool m_begin; // 0xC0
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Nested types
		public enum ERank // TypeDefIndex: 52584
		{
			None = 0,
			First = 1,
			Second = 2,
			Third = 3,
			Fourth = 4,
			Fifth = 5
		}
	
		// Constructors
		public UIRaceModuleRankController() {} // 0x0000000189B4141C-0x0000000189B4148C
	
		// Methods
		private void _ResetData() {} // 0x0000000189B41164-0x0000000189B411C4
		protected override void OnAwake() {} // 0x0000000189B409DC-0x0000000189B40B10
		protected override void OnRelease() {} // 0x0000000189B40B10-0x0000000189B40C48
		private void _ShowBaseTrans(bool show = true /* Metadata: 0x01FD2405 */) {} // 0x0000000189B411C4-0x0000000189B41280
		private void _LoadAllSprite() {} // 0x0000000189B40F04-0x0000000189B41164
		private void _UpdateRaceModuleRank([IsReadOnly] in EventData<int, float> rankData) {} // 0x0000000189B41280-0x0000000189B4141C
		public override void Tick(float deltaTime) {} // 0x0000000189B40C48-0x0000000189B40F04
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
	}

	public class UIVideoHelper : MonoBehaviour // TypeDefIndex: 52586
	{
		// Fields
		public CriManaMovieControllerForUI criMovieController; // 0x18
		public string videoPath; // 0x20
		public bool restartOnEnable; // 0x28
		private UIImage m_image; // 0x30
	
		// Constructors
		public UIVideoHelper() {} // 0x0000000189B4221C-0x0000000189B42268
	
		// Methods
		private void Reset() {} // 0x0000000189B4219C-0x0000000189B4221C
		public void ResetVideo() {} // 0x0000000189B42120-0x0000000189B4219C
		private void Awake() {} // 0x0000000189B41FF0-0x0000000189B420B8
		private void OnEnable() {} // 0x0000000189B420B8-0x0000000189B42120
	}

	public class UIWaterDroneBar : TickableUIMono // TypeDefIndex: 52587
	{
		// Fields
		public Beyond.Gameplay.MountPoint mountPoint; // 0x68
		public Transform waterDroneBarParent; // 0x70
		public Vector3 waterDroneBarLocalOffset; // 0x78
		public float smoothTime; // 0x84
		public UISlider slider; // 0x88
		private ObjectPtr<Entity> m_waterDronePtr; // 0x90
		[SerializeField]
		private Transform _waterDroneTrans; // 0xA0
		private Vector3 m_smoothVelocity; // 0xA8
		public UIStateController waterStateController; // 0xB8
		public UIStateController iconStateController; // 0xC0
		private static readonly ProfilerMarker PROFILER_MARKER_UPDATE; // 0x00
		public const float SLIDER_MAX_VALUE = 0.8277f; // Metadata: 0x01FD2493
		public UIAnimationWrapper uiAnimationWrapper; // 0xC8
		[SerializeField]
		private Animation _animation; // 0xD0
		[SerializeField]
		private AnimationClip _switchStateClip; // 0xD8
		[SerializeField]
		private AnimationClip _farLoopClip; // 0xE0
		[SerializeField]
		private AnimationClip _emptyLoopClip; // 0xE8
		private string m_switchStateClipName; // 0xF0
		private string m_farLoopClipName; // 0xF8
		private string m_emptyLoopClipName; // 0x100
		[SerializeField]
		private float _clampedYawAngle; // 0x108
		[SerializeField]
		private float _clampedPitchAngle; // 0x10C
		[SerializeField]
		private List<string> _hydrantTemplateIds; // 0x110
		[SerializeField]
		private List<string> _tankTemplateIds; // 0x118
		private bool m_isInfinityLiquid; // 0x120
		private bool m_isBagEmpty; // 0x121
		private bool m_noRemainLiquid; // 0x122
		private bool m_isBagEmptyAndNoRemainLiquid; // 0x123
		private int m_stateChangeFrame; // 0x124
		private bool m_stateDirty; // 0x128
		private bool m_isPlayingFarLoop; // 0x129
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
	
		// Constructors
		public UIWaterDroneBar() {} // 0x0000000183D02FE0-0x0000000183D03020
		static UIWaterDroneBar() {} // 0x0000000183D06AD0-0x0000000183D06B30
	
		// Methods
		protected override void OnAwake() {} // 0x0000000189B4280C-0x0000000189B42D60
		private void _OnWaterDroneInfinityLiquidChanged([IsReadOnly] in EventData<bool> data) {} // 0x0000000189B43564-0x0000000189B435D0
		private void _OnWaterDroneEmptyChanged([IsReadOnly] in EventData<bool> data) {} // 0x0000000189B433E4-0x0000000189B43450
		private void _OnWaterDroneInteractiveChanged([IsReadOnly] in EventData<string> data) {} // 0x0000000189B435D0-0x0000000189B4363C
		private void _OnWaterDroneSourceTypeChanged([IsReadOnly] in EventData<WaterDroneSourceType> data) {} // 0x0000000189B436B0-0x0000000189B4371C
		private void _OnWaterDroneRelaxChanged([IsReadOnly] in EventData<bool> data) {} // 0x0000000189B4363C-0x0000000189B436B0
		[IDTag(1)]
		private void _OnWaterDroneHydrantStateChanged([IsReadOnly] in EventData<CustomAbilityComponent.WaterDroneByHydrantState> data) {} // 0x0000000189B43500-0x0000000189B43564
		[IDTag(0)]
		private void _OnWaterDroneHydrantStateChanged(CustomAbilityComponent.WaterDroneByHydrantState state) {} // 0x0000000189B43450-0x0000000189B43500
		protected override void OnEnable() {} // 0x0000000189B42D60-0x0000000189B42EA0
		protected override void OnRelease() {} // 0x0000000189B42EA0-0x0000000189B4320C
		private void _OnWaterDroneChange(ObjectPtr<Entity> waterDronePtr) {} // 0x0000000189B43294-0x0000000189B433E4
		private void _ClearWaterDrone() {} // 0x0000000189B4320C-0x0000000189B43294
		public override void LateTick(float deltaTime) {} // 0x0000000189B42268-0x0000000189B4280C
		private void _UpdateState() {} // 0x0000000189B4387C-0x0000000189B43BA0
		private void _SetIconStateController(string stateName) {} // 0x0000000189B4371C-0x0000000189B437C8
		private void _UpdateSlider() {} // 0x0000000189B437C8-0x0000000189B4387C
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	public class WaterDroneJoystickCtrl : MonoBehaviour // TypeDefIndex: 52588
	{
		// Fields
		[SerializeField]
		private UIJoystick _joystick; // 0x18
		public float cameraInputScaleX; // 0x20
		public float cameraInputScaleY; // 0x24
	
		// Constructors
		public WaterDroneJoystickCtrl() {} // 0x0000000183D4CC10-0x0000000183D4CC30
	}

	public class WorldUIController : TickableMono // TypeDefIndex: 52589
	{
		// Fields
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
		public ulong entityLogicId { get; set; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x0000000183D4F040-0x0000000183D4F050
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
		protected bool uiActive { get => default; set {} } // 0x0000000183D5B230-0x0000000183D5B240 0x0000000189B4B2D0-0x0000000189B4B344
	
		// Constructors
		public WorldUIController() {} // 0x0000000182846010-0x0000000182846020
	
		// Methods
		public virtual void Init(Entity target, string path, ulong id, int typeSegment) {} // 0x0000000189B4AEE4-0x0000000189B4B044
		public virtual void TryGetNeedComponent() {} // 0x0000000189B4B204-0x0000000189B4B2D0
		public virtual void SetPos() {} // 0x0000000189B4B0A4-0x0000000189B4B0E8
		public virtual void SetUIForward() {} // 0x0000000189B4B0E8-0x0000000189B4B12C
		public override void Tick(float deltaTime) {} // 0x0000000189B4B180-0x0000000189B4B204
		public virtual void TickUI(float deltaTime) {} // 0x0000000189B4B12C-0x0000000189B4B180
		public virtual void Clear() {} // 0x0000000189B4AE8C-0x0000000189B4AEE4
		protected override void OnRelease() {} // 0x0000000189B4B044-0x0000000189B4B0A4
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
	}
}

namespace Beyond.UI.Mission
{
	public class MissionHudBGSizeUpdater : TickableUIMono // TypeDefIndex: 52590
	{
		// Fields
		public RectTransform bgTransform; // 0x68
		public RectTransform objectiveList; // 0x70
		public RectTransform objectiveContent; // 0x78
		public RectTransform leftLayoutTransform; // 0x80
		public VerticalLayoutGroup leftNodeVerticalLayoutGroup; // 0x88
		public float bgSizeGetterDeltaY; // 0x90
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
	
		// Constructors
		public MissionHudBGSizeUpdater() {} // 0x0000000183D4B8C0-0x0000000183D4B8E0
	
		// Methods
		public override void LateTick(float deltaTime) {} // 0x00000001824A53A0-0x00000001824A53E0
		public void UpdateBgSize() {} // 0x00000001824A5BC0-0x00000001824A5CB0
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 52409
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 52593
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D05CD0-0x0000000183D05D40
	
		// Methods
		public void __Gen_Wrap_0() {} // 0x00000001851624BC-0x0000000185162544
		public void __Gen_Wrap_1(object P0, float P1) {} // 0x00000001850F0008-0x00000001850F00E8
		public void __Gen_Wrap_2(object P0, object P1) {} // 0x0000000185163BA0-0x0000000185163C7C
		public void __Gen_Wrap_3(object P0) {} // 0x0000000184274234-0x00000001842742F4
		public void __Gen_Wrap_4(object P0, in EventData<int, float, float> P1) {} // 0x0000000189B48338-0x0000000189B48454
		public DamageTextBase __Gen_Wrap_5(object P0, DamageTextType P1) => default; // 0x0000000189B48AC0-0x0000000189B48BB8
		public void __Gen_Wrap_6(object P0, object P1, int P2) {} // 0x000000018516413C-0x0000000185164220
		public void __Gen_Wrap_7(object P0, int P1) {} // 0x000000018549D548-0x000000018549D624
		public void __Gen_Wrap_8(object P0, UnityEngine.Color P1) {} // 0x0000000189B4A3E8-0x0000000189B4A4E8
		public void __Gen_Wrap_9(object P0, object P1, object P2, Vector3? P3) {} // 0x0000000189B4ACB8-0x0000000189B4ADF8
		public void __Gen_Wrap_10(object P0, Vector2 P1) {} // 0x0000000189B442DC-0x0000000189B443E4
		public Vector3 __Gen_Wrap_11(object P0) => default; // 0x0000000189B44814-0x0000000189B44928
		public void __Gen_Wrap_12(object P0, bool P1) {} // 0x0000000185477860-0x000000018547793C
		public Vector2 __Gen_Wrap_13(object P0, float P1, float P2) => default; // 0x0000000189B45908-0x0000000189B45A20
		public bool __Gen_Wrap_14(object P0, Vector3 P1) => default; // 0x0000000189B45FD0-0x0000000189B460E8
		public void __Gen_Wrap_15(object P0, in EventData<AbilitySystem.Modifier> P1) {} // 0x0000000189B46528-0x0000000189B466C4
		public void __Gen_Wrap_16(object P0, EnergyShardType P1, bool P2) {} // 0x0000000185610058-0x000000018561013C
		public void __Gen_Wrap_17(object P0, in EventData<AbilitySystem, Vector3, Vector2, string, EnergyShardType> P1) {} // 0x0000000189B466C4-0x0000000189B467E8
		public void __Gen_Wrap_18(object P0, in EventData<AbilitySystem, Vector3, Vector2, string> P1) {} // 0x0000000189B467E8-0x0000000189B4690C
		public void __Gen_Wrap_19(object P0, in EventData<AbilitySystem, AbilitySystemForEnemyPart, PhysicalInflictionType> P1) {} // 0x0000000189B4690C-0x0000000189B46A28
		public void __Gen_Wrap_20(object P0, in EventData<bool> P1) {} // 0x0000000189B46A28-0x0000000189B46B3C
		public void __Gen_Wrap_21(object P0, in EventData<Vector3, string, UnityEngine.Color> P1) {} // 0x0000000189B46B3C-0x0000000189B46C60
		public void __Gen_Wrap_22(object P0, in EventData<ulong, int> P1) {} // 0x0000000189B46C60-0x0000000189B46D84
		public void __Gen_Wrap_23(object P0, object P1, object P2) {} // 0x0000000185150B1C-0x0000000185150C14
		public DamageTextBaseV2 __Gen_Wrap_24(object P0, DamageTextType P1, object P2) => default; // 0x0000000189B46D84-0x0000000189B46EA8
		public Vector2 __Gen_Wrap_25(object P0, float P1, float P2, bool P3, Vector3 P4) => default; // 0x0000000189B46EA8-0x0000000189B4700C
		public void __Gen_Wrap_26(object P0, Vector2 P1, float P2) {} // 0x0000000189B4700C-0x0000000189B4713C
		public HeadBarCtrl.HeadBarType __Gen_Wrap_27(ObjectPtr<AbilitySystem> P0) => default; // 0x0000000189B4713C-0x0000000189B47244
		public void __Gen_Wrap_28(object P0, object P1, float P2) {} // 0x0000000185E7B3B0-0x0000000185E7B4AC
		public void __Gen_Wrap_29(object P0, object P1, double P2) {} // 0x0000000185E6E454-0x0000000185E6E550
		public void __Gen_Wrap_30(object P0, in AbilitySystem.Modifier P1) {} // 0x0000000189B47244-0x0000000189B473FC
		public void __Gen_Wrap_31(object P0, HeadBarCtrl.HeadBarRefreshReason P1) {} // 0x000000018549D548-0x000000018549D624
		public void __Gen_Wrap_32(object P0, in EventData<string, Entity> P1) {} // 0x0000000189B473FC-0x0000000189B4750C
		public void __Gen_Wrap_33(object P0, in EventData<bool, DialogEnums.DialogType> P1) {} // 0x0000000189B4750C-0x0000000189B47624
		public void __Gen_Wrap_34(object P0, in EventData<AbilitySystem> P1) {} // 0x0000000189B47624-0x0000000189B4773C
		public void __Gen_Wrap_35(object P0, in EventData<AbilitySystem, bool> P1) {} // 0x0000000189B4773C-0x0000000189B47860
		public void __Gen_Wrap_36(object P0, in EventData<AbilitySystemForEnemyPart, bool> P1) {} // 0x0000000189B47860-0x0000000189B47970
		public bool __Gen_Wrap_37(object P0, ObjectPtr<Buff> P1) => default; // 0x0000000189B47970-0x0000000189B47A90
		public BuffIconConfig.BuffIconStyle __Gen_Wrap_38(object P0, object P1) => default; // 0x0000000185152714-0x0000000185152800
		public void __Gen_Wrap_39(object P0, ObjectPtr<Buff> P1) {} // 0x0000000189B47A90-0x0000000189B47BA4
		public void __Gen_Wrap_40(Sprite P0) {} // 0x00000001850EE850-0x00000001850EE8FC
		public void __Gen_Wrap_41(object P0, ObjectPtr<Buff> P1, object P2, object P3) {} // 0x0000000189B47BA4-0x0000000189B47CE0
		public void __Gen_Wrap_42(object P0, int P1, bool P2) {} // 0x0000000185477648-0x0000000185477740
		public UIBuffCell __Gen_Wrap_43(object P0, object P1) => default; // 0x0000000189B47CE0-0x0000000189B47DEC
		public void __Gen_Wrap_44(object P0, ObjectPtr<Buff> P1, bool P2) {} // 0x0000000189B47DEC-0x0000000189B47F18
		public Vector3? __Gen_Wrap_45(object P0) => default; // 0x0000000189B47F18-0x0000000189B48024
		public UIPoiseKnot __Gen_Wrap_46(object P0) => default; // 0x0000000189B48024-0x0000000189B48100
		public bool __Gen_Wrap_47(object P0) => default; // 0x000000018514EF5C-0x000000018514F02C
		public void __Gen_Wrap_48(object P0, object P1, bool P2, bool P3, object P4) {} // 0x0000000189B48100-0x0000000189B4820C
		public void __Gen_Wrap_49(object P0, ObjectPtr<Buff> P1, Buff.FinishReason P2) {} // 0x0000000189B4820C-0x0000000189B48338
		public void __Gen_Wrap_50(object P0, ObjectPtr<Buff> P1, bool P2, Buff.FinishReason P3) {} // 0x0000000189B48454-0x0000000189B48590
		public void __Gen_Wrap_51(object P0, ObjectPtr<AbilitySystem> P1) {} // 0x0000000189B48590-0x0000000189B486A4
		public void __Gen_Wrap_52(object P0, double P1) {} // 0x0000000189B486A4-0x0000000189B48770
		public void __Gen_Wrap_53(object P0, object P1, float P2, bool P3) {} // 0x00000001856239AC-0x0000000185623AA4
		public void __Gen_Wrap_54(object P0, object P1, bool P2, int P3) {} // 0x00000001886FA5D4-0x00000001886FA6CC
		public void __Gen_Wrap_55(object P0, object P1, int P2, int P3) {} // 0x00000001856277FC-0x00000001856278F4
		public Vector3 __Gen_Wrap_56(object P0, object P1) => default; // 0x0000000189B48770-0x0000000189B48890
		public void __Gen_Wrap_57(object P0, Vector3 P1) {} // 0x0000000189B48890-0x0000000189B489AC
		public void __Gen_Wrap_58(object P0, UIHeadLabel.VisibleSource P1, bool P2) {} // 0x0000000185477648-0x0000000185477740
		public void __Gen_Wrap_59(object P0, UIHeadLabel.HeadLabelType P1, UIHeadLabel.VisibleSource P2, bool P3, bool P4) {} // 0x0000000189B489AC-0x0000000189B48AC0
		public void __Gen_Wrap_60(object P0, in EventData<string> P1) {} // 0x0000000189B48BB8-0x0000000189B48CDC
		public void __Gen_Wrap_61(bool P0) {} // 0x00000001850F0C14-0x00000001850F0CC0
		public void __Gen_Wrap_62(object P0, bool P1, bool P2, bool P3) {} // 0x0000000185E5ABBC-0x0000000185E5ACC4
		public string __Gen_Wrap_63(object P0, object P1, object P2) => default; // 0x0000000189B48CDC-0x0000000189B48E04
		public Sprite __Gen_Wrap_64(object P0, object P1, object P2) => default; // 0x0000000189B48E04-0x0000000189B48F2C
		public void __Gen_Wrap_65(object P0, in EventData<float> P1) {} // 0x0000000189B48F2C-0x0000000189B49044
		public void __Gen_Wrap_66(object P0, object P1, int P2, bool P3) {} // 0x00000001854794D8-0x00000001854795D0
		public GameObject __Gen_Wrap_67(object P0, object P1) => default; // 0x0000000189B49044-0x0000000189B49150
		public void __Gen_Wrap_68(object P0, in EventData<int> P1) {} // 0x0000000189B49150-0x0000000189B49264
		public void __Gen_Wrap_69(object P0, bool P1, bool P2) {} // 0x0000000185E3DBF4-0x0000000185E3DCEC
		public void __Gen_Wrap_70(object P0, in EventData<GlobalBuff, string> P1) {} // 0x0000000189B49264-0x0000000189B49388
		public void __Gen_Wrap_71(object P0, in EventData<GlobalBuff, string, GlobalBuff.FinishReason> P1) {} // 0x0000000189B49388-0x0000000189B494A4
		public void __Gen_Wrap_72(object P0, object P1, bool P2) {} // 0x00000001854790D0-0x00000001854791C8
		public void __Gen_Wrap_73(object P0, SpellInflictionOnCharType? P1) {} // 0x0000000189B494A4-0x0000000189B495B4
		public ObjectPtr<Buff> __Gen_Wrap_74(object P0, object P1) => default; // 0x0000000189B495B4-0x0000000189B496D4
		public UICharPassiveBase __Gen_Wrap_75(object P0, object P1) => default; // 0x0000000189B496D4-0x0000000189B497E0
		public void __Gen_Wrap_76(object P0, in EventData<SetLeaderReason, Entity, Entity> P1) {} // 0x0000000189B497E0-0x0000000189B498FC
		public OutOfScreenTargetsCtrl.Arrow __Gen_Wrap_77(object P0) => default; // 0x0000000189B498FC-0x0000000189B499EC
		public ValueTuple<Vector2, float> __Gen_Wrap_78(object P0, Vector3 P1) => default; // 0x0000000189B499EC-0x0000000189B49B48
		public void __Gen_Wrap_79(object P0, in EventData<ulong, uint> P1) {} // 0x0000000189B49B48-0x0000000189B49C58
		public void __Gen_Wrap_80(object P0, in EventData<ulong, string> P1) {} // 0x0000000189B49C58-0x0000000189B49D68
		public void __Gen_Wrap_81(object P0, in EventData<ulong, string, int> P1) {} // 0x0000000189B49D68-0x0000000189B49E84
		public Sprite __Gen_Wrap_82(object P0, object P1) => default; // 0x0000000189B49E84-0x0000000189B49F7C
		public void __Gen_Wrap_83(object P0, int P1, bool P2, bool P3) {} // 0x00000001856214F0-0x00000001856215E8
		public bool __Gen_Wrap_84(object P0, bool P1) => default; // 0x00000001886E71DC-0x00000001886E72B4
		public void __Gen_Wrap_85(object P0, in EventData<ulong, string, EnergyShardType> P1) {} // 0x0000000189B49F7C-0x0000000189B4A098
		public void __Gen_Wrap_86(object P0, in EventData<UIStyleInputValidTypeMask> P1) {} // 0x0000000189B4A098-0x0000000189B4A1AC
		public void __Gen_Wrap_87(object P0, in EventData<CinematicTimelineManagerBase.TimelineHandle> P1) {} // 0x0000000189B4A1AC-0x0000000189B4A2C4
		public void __Gen_Wrap_88(object P0, in EventData<ForbidType, bool> P1) {} // 0x0000000189B4A2C4-0x0000000189B4A3E8
		public void __Gen_Wrap_89(object P0, int P1, int P2) {} // 0x00000001887040F0-0x00000001887041D4
		public void __Gen_Wrap_90(object P0, int P1, int P2, byte P3) {} // 0x0000000189B4A4E8-0x0000000189B4A5E0
		public void __Gen_Wrap_91(object P0, int P1, int P2, int P3, int P4, byte P5) {} // 0x0000000189B4A5E0-0x0000000189B4A6F4
		public byte __Gen_Wrap_92(object P0, int P1, int P2, out byte P3) {
			P3 = default;
			return default;
		} // 0x0000000189B4A6F4-0x0000000189B4A81C
		public void __Gen_Wrap_93(object P0, CommonTrackingPointStyleType P1, object P2) {} // 0x000000018560138C-0x0000000185601470
		public void __Gen_Wrap_94(object P0, CommonTrackingPointStyleType P1) {} // 0x000000018549D548-0x000000018549D624
		public void __Gen_Wrap_95(object P0, Vector2 P1, float P2, bool P3, float P4, bool P5) {} // 0x0000000189B4A81C-0x0000000189B4A968
		public void __Gen_Wrap_96(object P0, PosValueState P1, bool P2, Vector2 P3, float P4, bool P5, float P6, CommonTrackMapTier P7) {} // 0x0000000189B4A968-0x0000000189B4AAD4
		public int __Gen_Wrap_97(object P0, object P1) => default; // 0x00000001850EF354-0x00000001850EF42C
		public CommonTrackerUpdate.CommonTrackerItem __Gen_Wrap_98(object P0) => default; // 0x0000000189B4AAD4-0x0000000189B4ABB0
		public bool __Gen_Wrap_99(object P0, int P1, object P2, object P3) => default; // 0x0000000189B4ABB0-0x0000000189B4ACB8
		public void __Gen_Wrap_100(object P0, bool P1, int P2) {} // 0x000000018872224C-0x0000000188722330
		public void __Gen_Wrap_101(object P0, object P1, object P2, ulong P3, int P4) {} // 0x0000000189B43BA0-0x0000000189B43CAC
		public string __Gen_Wrap_102(object P0, LangKey P1, object P2) => default; // 0x0000000189B43CAC-0x0000000189B43DE8
		public void __Gen_Wrap_103(object P0, CoolerUnitTemperatureCircleUI.ETemperatureState P1) {} // 0x00000001855FFD60-0x00000001855FFE28
		public void __Gen_Wrap_104(object P0, ref float P1, ref float P2) {} // 0x0000000189B43DE8-0x0000000189B43F1C
		public string[] __Gen_Wrap_105() => default; // 0x0000000189B43F1C-0x0000000189B43FD4
		public bool __Gen_Wrap_106(object P0, ulong P1) => default; // 0x0000000189B43FD4-0x0000000189B440AC
		public GameObject __Gen_Wrap_107(object P0, object P1, object P2) => default; // 0x0000000189B440AC-0x0000000189B441C0
		public void __Gen_Wrap_108(object P0, object P1, UnityEngine.Color P2) {} // 0x0000000189B441C0-0x0000000189B442DC
		public uint __Gen_Wrap_109(object P0, object P1, object P2) => default; // 0x00000001856106A4-0x0000000185610798
		public void __Gen_Wrap_110(object P0, uint P1, object P2, object P3) {} // 0x0000000189B443E4-0x0000000189B444DC
		public void __Gen_Wrap_111(object P0, uint P1, object P2, bool P3, object P4) {} // 0x0000000189B444DC-0x0000000189B445E8
		public void __Gen_Wrap_112(object P0, uint P1, UnityEngine.Color P2) {} // 0x0000000189B445E8-0x0000000189B44704
		public void __Gen_Wrap_113(object P0, bool P1, float P2, object P3, object P4) {} // 0x0000000189B44704-0x0000000189B44814
		public void __Gen_Wrap_114(object P0, float P1, bool P2) {} // 0x000000018870BD64-0x000000018870BE48
		public void __Gen_Wrap_115(PointerEventData P0) {} // 0x00000001850EE850-0x00000001850EE8FC
		public void __Gen_Wrap_116(float P0) {} // 0x00000001850F0B68-0x00000001850F0C14
		public void __Gen_Wrap_117(object P0, float P1, float P2, float P3, bool P4) {} // 0x00000001854873B8-0x00000001854874C8
		public void __Gen_Wrap_118(object P0, float P1, float P2) {} // 0x00000001854A1120-0x00000001854A1208
		public void __Gen_Wrap_119(object P0, float P1, float P2, object P3) {} // 0x0000000189AFB88C-0x0000000189AFB988
		public void __Gen_Wrap_120(object P0, bool P1, bool P2, bool P3, ForgeIronTemperatureCircleUI.ETemperatureState P4) {} // 0x0000000189B44928-0x0000000189B44A34
		public Dictionary<string, RegionMap3DCfg> __Gen_Wrap_121(object P0) => default; // 0x0000000189B44A34-0x0000000189B44B24
		public void __Gen_Wrap_122(object P0, object P1, Vector3 P2, object P3) {} // 0x0000000189B44B24-0x0000000189B44C58
		public bool __Gen_Wrap_123(Vector2 P0, float P1, UnityEngine.Rect P2) => default; // 0x0000000189B44C58-0x0000000189B44DA8
		public void __Gen_Wrap_124(object P0, RegionMapShowType P1, object P2, object P3, float P4) {} // 0x0000000189B44DA8-0x0000000189B44EB8
		public Transform __Gen_Wrap_125(object P0, object P1) => default; // 0x0000000189B44EB8-0x0000000189B44FB0
		public Vector3 __Gen_Wrap_126(object P0, object P1, object P2, object P3) => default; // 0x0000000189B44FB0-0x0000000189B450F0
		public RegionMap3DCfg __Gen_Wrap_127(object P0, object P1) => default; // 0x0000000189B450F0-0x0000000189B451E8
		public TweenerCore<Quaternion, Quaternion, NoOptions> __Gen_Wrap_128(object P0, float P1, object P2) => default; // 0x0000000189B451E8-0x0000000189B452FC
		public void __Gen_Wrap_129(object P0, in EventData<long, long> P1) {} // 0x0000000189B452FC-0x0000000189B4540C
		public bool __Gen_Wrap_130() => default; // 0x00000001850F1D3C-0x00000001850F1DD4
		public bool __Gen_Wrap_131(object P0, object P1) => default; // 0x0000000185153920-0x0000000185153A0C
		public void __Gen_Wrap_132(object P0, object P1, Vector3 P2) {} // 0x0000000189B4540C-0x0000000189B45530
		public List<RaycastResult> __Gen_Wrap_133(object P0) => default; // 0x0000000189B45530-0x0000000189B4560C
		public LuaPanel __Gen_Wrap_134(object P0) => default; // 0x0000000189B4560C-0x0000000189B456E8
		public void __Gen_Wrap_135(object P0, object P1, long P2, float P3) {} // 0x0000000189B456E8-0x0000000189B457E4
		public void __Gen_Wrap_136(object P0, Vector3 P1, ulong P2) {} // 0x0000000189B457E4-0x0000000189B45908
		public void __Gen_Wrap_137(object P0, int P1, object P2, object P3) {} // 0x0000000189B443E4-0x0000000189B444DC
		public void __Gen_Wrap_138(object P0, bool P1, object P2) {} // 0x00000001855FE324-0x00000001855FE408
		public void __Gen_Wrap_139(object P0, long P1) {} // 0x0000000185606C1C-0x0000000185606CE4
		public void __Gen_Wrap_140(object P0, int P1, uint P2) {} // 0x00000001887040F0-0x00000001887041D4
		public void __Gen_Wrap_141(object P0, int P1, int P2, int P3) {} // 0x0000000188739D18-0x0000000188739E10
		public void __Gen_Wrap_142(object P0, long P1, float P2) {} // 0x0000000189B45A20-0x0000000189B45B04
		public RectTransform __Gen_Wrap_143(object P0) => default; // 0x0000000189B45B04-0x0000000189B45BE0
		public void __Gen_Wrap_144(object P0, Vector2 P1, float P2, bool P3) {} // 0x0000000189B45BE0-0x0000000189B45D0C
		public void __Gen_Wrap_145(object P0, ulong P1, int P2, int P3, int P4) {} // 0x0000000189B45D0C-0x0000000189B45E18
		public void __Gen_Wrap_146(object P0, PowerAutoConnectStatus P1) {} // 0x00000001855FFD60-0x00000001855FFE28
		public GameObject __Gen_Wrap_147(object P0) => default; // 0x0000000189B45E18-0x0000000189B45EF4
		public void __Gen_Wrap_148(object P0, TravelPoleBrain.TravelPoleIcon P1) {} // 0x00000001855FFD60-0x00000001855FFE28
		public UIAnimationWrapper __Gen_Wrap_149(object P0) => default; // 0x0000000189B45EF4-0x0000000189B45FD0
		public void __Gen_Wrap_150(object P0, TravelPoleBrain.TravelPoleStatus P1) {} // 0x00000001855FFD60-0x00000001855FFE28
		public void __Gen_Wrap_151(object P0, in EventData<int, float> P1) {} // 0x0000000189B460E8-0x0000000189B46200
		public void __Gen_Wrap_152(object P0, in EventData<WaterDroneSourceType> P1) {} // 0x0000000189B46200-0x0000000189B46314
		public void __Gen_Wrap_153(object P0, CustomAbilityComponent.WaterDroneByHydrantState P1) {} // 0x00000001855FFD60-0x00000001855FFE28
		public void __Gen_Wrap_154(object P0, in EventData<CustomAbilityComponent.WaterDroneByHydrantState> P1) {} // 0x0000000189B46314-0x0000000189B46428
		public void __Gen_Wrap_155(object P0, ObjectPtr<Entity> P1) {} // 0x0000000189B46428-0x0000000189B46528
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 52594
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x0000000189B4ADF8-0x0000000189B4AE8C
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 52595
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x0000000189B4B52C-0x0000000189B4B590
		public static bool IsPatched(int id) => default; // 0x000000018262C570-0x000000018262C5E0
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x0000000189B4B3E8-0x0000000189B4B4B4
		public object CreateWrapper(int id) => default; // 0x0000000189B4B4B4-0x0000000189B4B52C
		public object InitWrapperArray(int len) => default; // 0x0000000189B4B590-0x0000000189B4BBA0
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x0000000189B4B344-0x0000000189B4B3E8
	}

	public enum IDMAP0 // TypeDefIndex: 52596
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
		Beyond-UI-UIAbilityTargetFollower-_UpdatePos0 = 107,
		Beyond-UI-UIAbilityTargetFollower-GetOriginFollowPos0 = 108,
		Beyond-UI-UIAbilityTargetFollower-_SetDistanceVisible0 = 109,
		Beyond-UI-UIAbilityTargetFollower-SetActualVisible0 = 110,
		Beyond-UI-UIAbilityTargetFollower-_UpdateScale0 = 111,
		Beyond-UI-UIHeadBarFollower-ShowModifierAfterSetTarget0 = 112,
		Beyond-UI-UIHeadBar-ShowModifierAfterSetTarget0 = 113,
		Beyond-UI-UIHeadBar-_SetImageFill0 = 114,
		Beyond-UI-UIHeadBar-_OnHpChange0 = 115,
		Beyond-UI-UIHeadBar-_CalculateHpChangeDisplay0 = 116,
		Beyond-UI-HeadBarCtrl-_OnDialogStart0 = 120,
		Beyond-UI-HeadBarCtrl-_OnDialogFinish0 = 121,
		Beyond-UI-HeadBarCtrl-_OnAddHeadBar0 = 122,
		Beyond-UI-HeadBarCtrl-_OnRemoveHeadBar0 = 123,
		Beyond-UI-HeadBarCtrl-_OnHeadBarShowConfigChanged0 = 124,
		Beyond-UI-HeadBarCtrl-_OnHpChanged0 = 125,
		Beyond-UI-HeadBarCtrl-_OnEnemyPartEnableChanged0 = 126,
		Beyond-UI-HeadBarCtrl-_PrewarmHeadBar0 = 127,
		Beyond-UI-UIHeadBarFollower-OnPreWarm0 = 128,
		Beyond-UI-UIHeadBar-OnPreWarm0 = 129,
		Beyond-UI-UIBuffNode-OnPreWarm0 = 130,
		Beyond-UI-UIBuffNode-_OnFirstInit0 = 131,
		Beyond-UI-UIBuffCell-Clear0 = 132,
		Beyond-UI-HeadBarCtrl-OnClose0 = 135,
		Beyond-UI-HeadBarCtrl-OnShow0 = 136,
		Beyond-UI-UIHeadBarFollower-Refresh0 = 137,
		Beyond-UI-UIHeadBar-Refresh0 = 138,
		Beyond-UI-UIPoiseBar-Refresh0 = 139,
		Beyond-UI-UIBuffNode-Refresh0 = 140,
		Beyond-UI-UIBuffNode-BuffCellGroup-ClearAllBuffCells0 = 141,
		Beyond-UI-UIBuffNode-BuffCellGroup-RemoveBuffCell0 = 142,
		Beyond-UI-UIBuffNode-_IsBuffIconInThisNode0 = 143,
		Beyond-UI-UIBuffNode-_AddBuffIconInternal0 = 144,
		Beyond-UI-UIBuffNode-_GetIconStyle0 = 146,
		Beyond-UI-UIBuffCell-Init0 = 147,
		Beyond-UI-UIBuffCell-VisualInit0 = 150,
		Beyond-UI-UIBuffCell-SetBuffIcon0 = 151,
		Beyond-UI-UIBuffCell-SetStackElementActive0 = 152,
		Beyond-UI-UIBuffCell-SetWarningState0 = 153,
		Beyond-UI-UIBuffCell-SetVisible0 = 154,
		Beyond-UI-UIBuffCell-DataInit0 = 156,
		Beyond-UI-UIBuffCell-SetStackCount0 = 158,
		Beyond-UI-UIBuffNode-_SetBuffCellSiblingInOrder0 = 161,
		Beyond-UI-UIBuffNode-_DealWithBuffCellVisible0 = 162,
		Beyond-UI-UIBuffNode-BuffCellGroup-CreateBuffCell0 = 163,
		Beyond-UI-UIVigilanceBar-Refresh0 = 168,
		Beyond-UI-HeadBarCtrl-OnHide0 = 169,
		Beyond-UI-HeadBarCtrl-LateTick0 = 170,
		Beyond-UI-HeadBarCtrl-_UpdateSurroundingEnemies0 = 171,
		Beyond-UI-HeadBarCtrl-_UpdateHeadBar0 = 172,
		Beyond-UI-UIAbilityTargetFollower-get_followPosition0 = 173,
		Beyond-UI-UIHeadBarFollower-SetHeadBarVisible0 = 174,
		Beyond-UI-HeadBarCtrl-_UpdateLevelInfoBar0 = 175,
		Beyond-UI-HeadBarCtrl-_UpdateVigilanceBar0 = 178,
		Beyond-UI-HeadBarCtrl-_UpdateTacticalItemBar0 = 179,
		Beyond-UI-UIHeadBar-OnDestroy0 = 182,
		Beyond-UI-UIHeadBar-SetTarget0 = 183,
		Beyond-UI-UIPoiseBar-Init0 = 184,
		Beyond-UI-UIPoiseKnot-SetVisible0 = 185,
		Beyond-UI-UIPoiseBar-_ClearPoiseKnot0 = 186,
		Beyond-UI-UIPoiseBar-_TryInitPoiseKnot0 = 187,
		Beyond-UI-UIPoiseBar-_CreatePoiseKnot0 = 188,
		Beyond-UI-UIPoiseBar-get_hidePoiseBar0 = 189,
		Beyond-UI-UIBuffNode-Init0 = 190,
		Beyond-UI-UIBuffNode-_UnregisterAbilityBuffEvent0 = 191,
		Beyond-UI-UIBuffNode-OnBuffIconChange0 = 192,
		Beyond-UI-UIBuffNode-_OnAddBuff0 = 193,
		Beyond-UI-UIBuffNode-_OnRemoveBuff0 = 194,
		Beyond-UI-UIBuffNode-_RemoveBuffIconInternal0 = 195,
		Beyond-UI-UIBuffCell-BeforePlayOutAnim0 = 200,
		Beyond-UI-UIBuffNode-_OnBuffEnhanceChanged0 = 204,
		Beyond-UI-UIBuffNode-_OnBuffIgnite0 = 205,
		Beyond-UI-UIBuffCell-OnBuffIgnite0 = 206,
		Beyond-UI-UIBuffNode-_RegisterAbilityBuffEvent0 = 207,
		Beyond-UI-UIHeadBar-_OnForceSetHp0 = 208,
		Beyond-UI-UIHeadBar-_OnPoiseChange0 = 209,
		Beyond-UI-UIPoiseBar-OnPoiseChange0 = 210,
		Beyond-UI-UIPoiseKnot-KnotBreak0 = 211,
		Beyond-UI-UIPoiseBar-_CalculatePoiseChangeDisplay0 = 212,
		Beyond-UI-UIHeadBar-_OnMultiTimeWeaknessActivate0 = 213,
		Beyond-UI-UIWeaknessNode-SetTotalCellNum0 = 214,
		Beyond-UI-UIHeadBar-_OnWeaknessCountChanged0 = 215,
		Beyond-UI-UIWeaknessNode-SetCurrentCellNum0 = 216,
		Beyond-UI-UIHeadBar-_OnMainTargetChanged0 = 217,
		Beyond-UI-UIHeadBar-Clear0 = 218,
		Beyond-UI-UIPoiseBar-Clear0 = 219,
		Beyond-UI-UIBuffNode-Clear0 = 220,
		Beyond-UI-UIHeadBar-_UpdateHpDisplay0 = 221,
		Beyond-UI-UIHeadBar-_UpdateScale0 = 222,
		Beyond-UI-UIHeadBar-UpdateData0 = 223,
		Beyond-UI-UIPoiseBar-UpdatePoiseBar0 = 224,
		Beyond-UI-UIPoiseBar-_UpdatePoiseDisplay0 = 225,
		Beyond-UI-UIHeadBarFollower-SetTarget0 = 226,
		Beyond-UI-UIHeadBarFollower-_UpdateGuideLine0 = 227,
		Beyond-UI-UIHeadBarFollower-Clear0 = 228,
		Beyond-UI-UIAbilityTargetFollower-Clear0 = 229,
		Beyond-UI-UIHeadBarFollower-UpdateData0 = 230,
		Beyond-UI-UIHeadBarFollower-GetOriginFollowPos0 = 231,
		Beyond-UI-UIAbilityTargetFollower-GetAdjustedHeightOffset0 = 232,
		Beyond-UI-UIHeadLabel-_OnSubRootsCollectionChanged0 = 233,
		Beyond-UI-UIHeadLabel-_TryInitRootData0 = 234,
		Beyond-UI-UIHeadLabel-HeadLabelRootVisibleData-Init0 = 235,
		Beyond-UI-UIHeadLabel-SetVisibleDirty0 = 236,
		Beyond-UI-UIHeadLabel-_UpdateVisible0 = 237,
		Beyond-UI-UIHeadLabel-HeadLabelRootVisibleData-get_realVisible0 = 238,
		Beyond-UI-UIHeadLabel-SetSubRootVisible0 = 239,
		Beyond-UI-UIHeadLabel-HeadLabelRootVisibleData-UpdateVisible0 = 240,
		Beyond-UI-UIHeadLabel-SetTarget0 = 241,
		Beyond-UI-UIHeadLabel-_BindTargetEvent0 = 243,
		Beyond-UI-UIHeadLabel-_OnNpcVisibleChanged0 = 244,
		Beyond-UI-UIHeadLabel-_TryUpdateVisibleCallback0 = 246,
		Beyond-UI-UIHeadLabel-_UpdateFloatingUIVisibleCallback0 = 247,
		Beyond-UI-UIHeadLabel-_UpdatePos0 = 250,
		Beyond-UI-UIHeadLabel-_BindMissionTracking0 = 251,
		Beyond-UI-UIHeadLabel-_OnMissionTypeIconChanged0 = 252,
		Beyond-UI-UIHeadLabel-_ClearVisibleCallback0 = 254,
		Beyond-UI-UIHeadLabel-_ClearFloatingUIVisibleCallback0 = 255,
		Beyond-UI-UIHeadLabel-Clear0 = 256,
		Beyond-UI-UIHeadLabel-_RefreshVisible0 = 257,
		Beyond-UI-UIHeadLabel-ClearEmojis0 = 258,
		Beyond-UI-UIHeadLabel-_UnBindMissionTracking0 = 259,
		Beyond-UI-UIHeadLabel-_UnBindTargetEvent0 = 260,
		Beyond-UI-UIHeadLabel-SetActive0 = 261,
		Beyond-UI-UIHeadLabel-_TryUpdateVisible0 = 262,
		Beyond-UI-UIHeadLabel-OnAwake0 = 263,
		Beyond-UI-UIHeadLabel-LateTick0 = 264,
		Beyond-UI-UIHeadLabel-OnEnable0 = 265,
		Beyond-UI-UIHeadLabel-OnDisable0 = 266,
		Beyond-UI-UIHeadLabel-OnRelease0 = 267,
		Beyond-UI-UILvInfoBar-SetTarget0 = 268,
		Beyond-UI-UILvInfoBar-GetOriginFollowPos0 = 269,
		Beyond-UI-UITacticalItemBar-SetTarget0 = 270,
		Beyond-UI-UIPanelBase-LoadSprite0 = 271,
		Beyond-UI-UIPanelBase-GetSpritePath0 = 272,
		Beyond-UI-UITacticalItemBar-UpdateData0 = 273,
		Beyond-UI-UIVigilanceBar-SetTarget0 = 274,
		Beyond-UI-UIVigilanceBar-Clear0 = 275,
		Beyond-UI-UIVigilanceBar-UpdateData0 = 276,
		Beyond-UI-UIVigilanceBar-_UpdateVigilanceNode0 = 277,
		Beyond-UI-UIVigilanceBar-GetOriginFollowPos0 = 279,
		Beyond-UI-UIWeaknessNode-Awake0 = 280,
		Beyond-UI-AtbNode-OnCreate0 = 281,
		Beyond-UI-AtbNode-OnInFightChanged0 = 282,
		Beyond-UI-AtbNode-_RefreshAtbShowing0 = 283,
		Beyond-UI-AtbNode-_OnAtbCellOutAnimCallback0 = 284,
		Beyond-UI-AtbNode-CheckAtbLoopAnim0 = 285,
		Beyond-UI-AtbNode-OnGainAtb0 = 286,
		Beyond-UI-AtbNode-OnClose0 = 289,
		Beyond-UI-AtbNode-LateTick0 = 290,
		Beyond-UI-ComboSkillHint-Init0 = 291,
		Beyond-UI-ComboSkillPanel-CastComboSkill0 = 292,
		Beyond-UI-ComboSkillPanel-_ResortSiblingIndex0 = 295,
		Beyond-UI-ComboSkillHint-OnCast0 = 296,
		Beyond-UI-ComboSkillPanel-_CheckUpdate0 = 297,
		Beyond-UI-ComboSkillHint-OnReady0 = 298,
		Beyond-UI-ComboSkillHint-OnTick0 = 299,
		Beyond-UI-ComboSkillHint-OnRemove0 = 300,
		Beyond-UI-ComboSkillHint-Release0 = 301,
		Beyond-UI-ComboSkillHint-AssignData0 = 302,
		Beyond-UI-UIPanelBase-LoadGameObject0 = 303,
		Beyond-UI-ComboSkillPanel-OnCreate0 = 304,
		Beyond-UI-ComboSkillPanel-_OnComboSkillReady0 = 306,
		Beyond-UI-ComboSkillPanel-_OnComboSkillRemove0 = 307,
		Beyond-UI-ComboSkillPanel-_RemoveComboSkill0 = 308,
		Beyond-UI-ComboSkillPanel-_OnBattleTeamChanged0 = 311,
		Beyond-UI-ComboSkillPanel-_OnComboSkillClearAll0 = 312,
		Beyond-UI-ComboSkillPanel-OnShow0 = 315,
		Beyond-UI-ComboSkillPanel-OnRelease0 = 316,
		Beyond-UI-UIPanelBase-OnRelease0 = 317,
		Beyond-UI-ComboSkillPanel-PreTick0 = 318,
		Beyond-UI-HpBarComboNode-Awake0 = 319,
		Beyond-UI-HpBarComboNode-_OnGlobalBuffStart0 = 320,
		Beyond-UI-HpBarComboNode-_RefreshComboCount0 = 321,
		Beyond-UI-HpBarComboNode-_AnimOutCallback0 = 322,
		Beyond-UI-HpBarComboNode-_AnimInCallback0 = 323,
		Beyond-UI-HpBarComboNode-_OnGlobalBuffFinish0 = 324,
		Beyond-UI-HpBarComboNode-OnDestroy0 = 325,
		Beyond-UI-MainCharHpBar-OnAwake0 = 326,
		Beyond-UI-MainCharHpBar-_OnMainCharChange0 = 327,
		Beyond-UI-MainCharHpBar-_ProcessOnMainCharChange0 = 328,
		Beyond-UI-MainCharHpBar-_ClearMainChar0 = 329,
		Beyond-UI-MainCharHpBar-_OnHpChange0 = 330,
		Beyond-UI-MainCharHpBar-_SetHpFillAmount0 = 331,
		Beyond-UI-MainCharHpBar-_CalculateHpChangeDisplay0 = 332,
		Beyond-UI-UIHudFadeController-SetLocalNeedShow0 = 333,
		Beyond-UI-UIHudFadeController-_CheckNeedShow0 = 334,
		Beyond-UI-UIHudFadeController-InformShow0 = 335,
		Beyond-UI-MainCharHpBar-_OnTakeDamage0 = 336,
		Beyond-UI-MainCharHpBar-_OnBuffChangeCharHpBarVfx0 = 337,
		Beyond-UI-MainCharHpBar-_HpVfxOutAnimCallback0 = 338,
		Beyond-UI-MainCharHpBar-_OnCharPassiveNumChanged0 = 339,
		Beyond-UI-MainCharHpBar-_OnBuffIconChange0 = 340,
		Beyond-UI-MainCharHpBar-_BlinkBuffIcon0 = 341,
		Beyond-UI-MainCharHpBar-_OnBuffEnhanceChanged0 = 345,
		Beyond-UI-MainCharHpBar-_SelectUltimateBuff0 = 346,
		Beyond-UI-MainCharHpBar-_GetUltimateBuffForAbility0 = 347,
		Beyond-UI-MainCharHpBar-_IsUltimateBuffValid0 = 348,
		Beyond-UI-MainCharHpBar-_SetUltimateBuff0 = 349,
		Beyond-UI-MainCharHpBar-_UltimateBuffProgressOutAnimCallback0 = 350,
		Beyond-UI-MainCharHpBar-_GetOrCreateCharPassiveBase0 = 351,
		Beyond-UI-MainCharHpBar-_OnTeamChanged0 = 352,
		Beyond-UI-MainCharHpBar-_RebuildUltimateBuffTracking0 = 353,
		Beyond-UI-MainCharHpBar-_OnProgressBarBuffChange0 = 354,
		Beyond-UI-MainCharHpBar-_OnMainCharHpActiveChange0 = 355,
		Beyond-UI-MainCharHpBar-OnEnable0 = 356,
		Beyond-UI-MainCharHpBar-_CheckHpBarShowing0 = 357,
		Beyond-UI-MainCharHpBar-_SetHpBarShowing0 = 358,
		Beyond-UI-MainCharHpBar-OnRelease0 = 360,
		Beyond-UI-MainCharHpBar-OnShow0 = 361,
		Beyond-UI-MainCharHpBar-OnHide0 = 362,
		Beyond-UI-MainCharHpBar-LateTick0 = 363,
		Beyond-UI-MainCharHpBar-_UpdateHpDisplay0 = 364,
		Beyond-UI-OutOfScreenTargetsCtrl-OnCreate0 = 365,
		Beyond-UI-OutOfScreenTargetsCtrl-OnShow0 = 366,
		Beyond-UI-OutOfScreenTargetsCtrl-LateTick0 = 367,
		Beyond-UI-OutOfScreenTargetsCtrl-_CreateOneArrow0 = 370,
		Beyond-UI-OutOfScreenTargetsCtrl-_ScreenPosToUIPos0 = 371,
		Beyond-UI-SkillButton-OnAwake0 = 372,
		Beyond-UI-SkillButton-OnEnable0 = 373,
		Beyond-UI-SkillButton-Close0 = 374,
		Beyond-UI-SkillButton-_OnOtherPressSkillButtonStart0 = 375,
		Beyond-UI-SkillButton-PressHandler-OnOtherPressSkillButtonStart0 = 376,
		Beyond-UI-SkillButton-OnUspChange0 = 377,
		Beyond-UI-SkillButton-_OnCharPotentialUnlock0 = 378,
		Beyond-UI-SkillButton-RefreshSkillButton0 = 379,
		Beyond-UI-SkillButton-_InitSkillData0 = 380,
		Beyond-UI-SkillButton-_UpdateMainUI0 = 381,
		Beyond-UI-SkillButton-_RefreshDeadState0 = 382,
		Beyond-UI-SkillButton-OnPressCancelled0 = 383,
		Beyond-UI-SkillButton-_CheckNormalSkillHighlight0 = 384,
		Beyond-UI-SkillButton-_SetPressFillActive0 = 385,
		Beyond-UI-SkillButton-_OnSkillButtonActiveConfigChanged0 = 386,
		Beyond-UI-SkillButton-_SetGoActive0 = 387,
		Beyond-UI-SkillButton-_OnCharNormalSkillChange0 = 388,
		Beyond-UI-SkillButton-_OnSkillUpgradeSuccess0 = 389,
		Beyond-UI-SkillButton-_OnInputActionKeyUpdated0 = 390,
		Beyond-UI-SkillButton-_UpdateLongPressKeyHint0 = 391,
		Beyond-UI-UIPanelBase-LoadSpriteWithOutFormat0 = 392,
		Beyond-UI-SkillButton-FirstTimeInit0 = 393,
		Beyond-UI-SkillButton-OnPressSkillStart0 = 394,
		Beyond-UI-SkillButton-OnPressSkillEnd0 = 395,
		Beyond-UI-SkillButton-OnPressUltimateSkillStart0 = 396,
		Beyond-UI-SkillButton-OnCharacterDie0 = 397,
		Beyond-UI-SkillButton-_SetPressFillAmount0 = 398,
		Beyond-UI-SkillButton-CastSkill0 = 399,
		Beyond-UI-SkillButton-ToggleControllerSkillIndicator0 = 400,
		Beyond-UI-SkillButton-SetEmpty0 = 401,
		Beyond-UI-SkillButton-ClearBtnClick0 = 402,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnPressStart0 = 403,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnUpdate0 = 404,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnPressEnd0 = 405,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnPressCancel0 = 406,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnOtherPressSkillButtonStart0 = 407,
		Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnPressStart0 = 408,
		Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnUpdate0 = 409,
		Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnPressEnd0 = 410,
		Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnPressCancel0 = 411,
		Beyond-UI-SkillButton-PressHandlerDrag-OnPressStart0 = 412,
		Beyond-UI-SkillButton-PressHandlerDrag-OnUpdate0 = 413,
		Beyond-UI-SkillButton-PressHandlerDrag-OnPressEnd0 = 414,
		Beyond-UI-SkillButton-PressHandlerDrag-OnPressCancel0 = 415,
		Beyond-UI-SquadIcon-OnAwake0 = 416,
		Beyond-UI-SquadIcon-FirstTimeInit0 = 417,
		Beyond-UI-SquadIcon-OnPressCharIconStart0 = 418,
		Beyond-UI-SquadIcon-CanSwitchToCenter0 = 419,
		Beyond-UI-SquadIcon-_OnMainCharChange0 = 422,
		Beyond-UI-SquadIcon-_OnIgniteBuffText0 = 423,
		Beyond-UI-SquadIcon-Close0 = 424,
		Beyond-UI-SquadIcon-_OnHpChange0 = 425,
		Beyond-UI-SquadIcon-_OnBuffChangeCharHpBarVfx0 = 427,
		Beyond-UI-SquadIcon-_HpVfxOutAnimCallback0 = 428,
		Beyond-UI-SquadIcon-_OnCharPassiveNumChanged0 = 429,
		Beyond-UI-SquadIcon-InitSquadIcon0 = 430,
		Beyond-UI-SquadIcon-SetDeadState0 = 431,
		Beyond-UI-SquadIcon-_UpdateComboSkillIcon0 = 432,
		Beyond-UI-SquadIcon-_TryShowLevelUpAnim0 = 435,
		Beyond-UI-SquadIcon-_SetLevelText0 = 437,
		Beyond-UI-SquadIcon-OnTacticalItemChange0 = 438,
		Beyond-UI-TacticalDotCell-Init0 = 439,
		Beyond-UI-SquadIcon-_MustUpdate0 = 440,
		Beyond-UI-SquadIcon-LateTick0 = 441,
		Beyond-UI-SquadIcon-_UpdateIconAlpha0 = 442,
		Beyond-UI-SquadIcon-_UpdateTacticalItemStatus0 = 443,
		Beyond-UI-TacticalDotCell-SetDotActive0 = 444,
		Beyond-UI-TacticalDotCell-SetDotUsedUp0 = 446,
		Beyond-UI-SquadIcon-SetEmpty0 = 447,
		Beyond-UI-SquadIcon-ToggleIndicator0 = 448,
		Beyond-UI-SquadIcon-InformKeyHint0 = 449,
		Beyond-UI-SquadIcon-OnLevelChange0 = 450,
		Beyond-UI-SquadIcon-OnTeamSwitchUnlocked0 = 451,
		Beyond-UI-UIAbnormalBuffCell-OnTick0 = 452,
		Beyond-UI-UIBuffCell-OnTick0 = 453,
		Beyond-UI-UIAbnormalBuffCell-VisualInit0 = 454,
		Beyond-UI-UIAbnormalBuffCell-SetWarningState0 = 455,
		Beyond-UI-UIAttachedBuffCell-DataInit0 = 456,
		Beyond-UI-UIAttachedBuffCell-OnTick0 = 457,
		Beyond-UI-UIAttachedBuffCell-BeforePlayOutAnim0 = 458,
		Beyond-UI-UIAttachedBuffCell-SetBuffIcon0 = 459,
		Beyond-UI-UIAttachedBuffCell-SetStackElementActive0 = 460,
		Beyond-UI-UIAttachedBuffCell-SetStackCount0 = 461,
		Beyond-UI-UIAttachedBuffCell-OnBuffIgnite0 = 463,
		Beyond-UI-UIBuffNode-TailLateTick0 = 464,
		Beyond-UI-UIBuffNode-OnRelease0 = 465,
		Beyond-UI-UILifeTimeBuffCell-OnTick0 = 466,
		Beyond-UI-UILifeTimeBuffCell-SetWarningState0 = 467,
		Beyond-UI-UIHudFadeConsoleController-Awake0 = 468,
		Beyond-UI-UIHudFadeConsoleController-_OnFadeHud0 = 469,
		Beyond-UI-UIHudFadeConsoleController-_CheckNeedShow0 = 470,
		Beyond-UI-UIHudFadeConsoleController-_OnInformShow0 = 472,
		Beyond-UI-UIHudFadeConsoleController-InformShow0 = 473,
		Beyond-UI-UIHudFadeConsoleController-OnDestroy0 = 475,
		Beyond-UI-UIHudFadeConsoleController-OnShow0 = 476,
		Beyond-UI-UIHudFadeController-Awake0 = 477,
		Beyond-UI-UIHudFadeController-_OnFadeHud0 = 478,
		Beyond-UI-UIHudFadeController-_OnInformShow0 = 479,
		Beyond-UI-UIHudFadeController-OnDestroy0 = 480,
		Beyond-UI-UIHudFadeTouchSkill-Awake0 = 481,
		Beyond-UI-UIHudFadeTouchSkill-_OnFadeHud0 = 482,
		Beyond-UI-UIHudFadeTouchSkill-_CheckNeedShow0 = 483,
		Beyond-UI-UIHudFadeTouchSkill-_OnInformShow0 = 485,
		Beyond-UI-UIHudFadeTouchSkill-InformShow0 = 486,
		Beyond-UI-UIHudFadeTouchSkill-OnDestroy0 = 489,
		Beyond-UI-UIHudFadeTouchSkill-OnShow0 = 490,
		Beyond-UI-UIAbilityTargetFollower-OnAwake0 = 491,
		Beyond-UI-UIAbilityTargetFollower-TailLateTick0 = 492,
		Beyond-UI-UIAbilityTargetFollower-UpdateData0 = 493,
		Beyond-UI-UILockAim-OnAwake0 = 494,
		Beyond-UI-UILockAim-_RefreshTarget0 = 495,
		Beyond-UI-UILockAim-_OnLockTargetFromAutoToManual0 = 496,
		Beyond-UI-UILockAim-OnRelease0 = 497,
		Beyond-UI-UILockAim-Start0 = 498,
		Beyond-UI-UILockAim-UpdateData0 = 499,
		Beyond-UI-UIMainCharFootBar-OnAwake0 = 500,
		Beyond-UI-UIMainCharFootBar-_OnDashFailed0 = 501,
		Beyond-UI-UIMainCharFootBar-_OnMainCharChange0 = 502,
		Beyond-UI-UIMainCharFootBar-_ProcessOnMainCharChange0 = 503,
		Beyond-UI-UIMainCharFootBar-_OnInteractNpc0 = 504,
		Beyond-UI-UIMainCharFootBar-_SetInDialog0 = 505,
		Beyond-UI-UIMainCharFootBar-_OnDialogStart0 = 506,
		Beyond-UI-UIMainCharFootBar-_OnDialogFinish0 = 507,
		Beyond-UI-UIMainCharFootBar-OnEnable0 = 508,
		Beyond-UI-UIMainCharFootBar-OnRelease0 = 509,
		Beyond-UI-UIMainCharFootBar-LateTick0 = 510,
		Beyond-UI-UIMainCharFootBar-_OnDashCountChanged0 = 511,
		Beyond-UI-UIMainCharFootBar-_OnOutAnimCallback0 = 512,
		Beyond-UI-UIMainCharFootBarArc-OnAwake0 = 513,
		Beyond-UI-UIMainCharFootBarArc-_OnDashFailed0 = 514,
		Beyond-UI-UIMainCharFootBarArc-_OnMainCharChange0 = 515,
		Beyond-UI-UIMainCharFootBarArc-_ProcessOnMainCharChange0 = 516,
		Beyond-UI-UIMainCharFootBarArc-_OnInteractNpc0 = 517,
		Beyond-UI-UIMainCharFootBarArc-_SetInDialog0 = 518,
		Beyond-UI-UIMainCharFootBarArc-_RefreshDisableState0 = 519,
		Beyond-UI-UIMainCharFootBarArc-_OnDialogStart0 = 520,
		Beyond-UI-UIMainCharFootBarArc-_OnDialogFinish0 = 521,
		Beyond-UI-UIMainCharFootBarArc-_OnPlayCutscene0 = 522,
		Beyond-UI-UIMainCharFootBarArc-_OnFinishCutscene0 = 523,
		Beyond-UI-UIMainCharFootBarArc-_OnForbidSystemChanged0 = 524,
		Beyond-UI-UIMainCharFootBarArc-OnEnable0 = 525,
		Beyond-UI-UIMainCharFootBarArc-OnRelease0 = 526,
		Beyond-UI-UIMainCharFootBarArc-TailLateTick0 = 527,
		Beyond-UI-UIMainCharFootBarArc-_OnDashCountChanged0 = 528,
		Beyond-UI-UIMainCharFootBarArc-_OnOutAnimCallback0 = 529,
		Beyond-UI-UIMainCharFootBarArc-SetUIDisable0 = 530,
		Beyond-UI-UIWeakLockAim-OnAwake0 = 531,
		Beyond-UI-UIWeakLockAim-_OnMainTargetChanged0 = 532,
		Beyond-UI-UIWeakLockAim-_RefreshTarget0 = 533,
		Beyond-UI-UIWeakLockAim-Start0 = 534,
		Beyond-UI-UIWeakLockAim-OnRelease0 = 535,
		Beyond-UI-BlueprintPreviewHelper-SetSize0 = 536,
		Beyond-UI-BlueprintPreviewHelper-AddGridValue0 = 537,
		Beyond-UI-BlueprintPreviewHelper-BatchAddGridValue0 = 538,
		Beyond-UI-BlueprintPreviewHelper-GetGridValue0 = 539,
		Beyond-UI-CommonTrackerNodeComp-ShowStyleType0 = 540,
		Beyond-UI-UICampfireTracker-UpdateImage0 = 541,
		Beyond-UI-UICommonTracker-UpdateImage0 = 542,
		Beyond-UI-CommonTrackerNodeComp-PlayOutAnimation0 = 543,
		Beyond-UI-CommonTrackerNodeComp-UpdatePosition0 = 544,
		Beyond-UI-UIBlackboxTracker-UpdatePosition0 = 545,
		Beyond-UI-UICampfireTracker-UpdatePosition0 = 546,
		Beyond-UI-UICommonLevelTracker-UpdatePosition0 = 547,
		Beyond-UI-UICommonTracker-UpdatePosition0 = 548,
		Beyond-UI-CommonTrackerUpdate-get__inFactoryTopView0 = 549,
		Beyond-UI-CommonTrackerUpdate-UpdateCommonTrackers0 = 550,
		Beyond-UI-CommonTrackerUpdate-_FindTrackIndexByKey0 = 551,
		Beyond-UI-CommonTrackerUpdate-_InitTrackInfoByIndex0 = 552,
		Beyond-UI-CommonTrackerUpdate-_CreateNewMissionTracker0 = 553,
		Beyond-UI-CommonTrackerUpdate-_DeleteInvalidTracker0 = 554,
		Beyond-UI-CommonTrackerUpdate-_HideTrackerGo0 = 555,
		Beyond-UI-CommonTrackerUpdate-_ShowTrackerGo0 = 556,
		Beyond-UI-CommonTrackerUpdate-AllTrackersPlayOutAnimation0 = 557,
		Beyond-UI-CoolerUnitProgressBarUI-Init0 = 558,
		Beyond-UI-WorldUIController-Init0 = 559,
		Beyond-UI-WorldUIController-TryGetNeedComponent0 = 561,
		Beyond-UI-WorldUIController-SetUIForward0 = 562,
		Beyond-UI-WorldUIController-SetPos0 = 563,
		Beyond-UI-CoolerUnitProgressBarUI-SetUIForward0 = 564,
		Beyond-UI-CoolerUnitProgressBarUI-SetPos0 = 565,
		Beyond-UI-CoolerUnitProgressBarUI-TickUI0 = 566,
		Beyond-UI-CoolerUnitProgressBarUI-_TickCanvasGroup0 = 567,
		Beyond-UI-CoolerUnitProgressBarUI-_UpdateProgress0 = 568,
		Beyond-UI-CoolerUnitTemperatureCircleUI-Init0 = 569,
		Beyond-UI-CoolerUnitTemperatureCircleUI-SetUIForward0 = 570,
		Beyond-UI-CoolerUnitTemperatureCircleUI-SetPos0 = 571,
		Beyond-UI-CoolerUnitTemperatureCircleUI-TickUI0 = 572,
		Beyond-UI-CoolerUnitTemperatureCircleUI-_TickCanvasGroup0 = 573,
		Beyond-UI-CoolerUnitTemperatureCircleUI-_SetState0 = 574,
		Beyond-UI-CoolerUnitTemperatureCircleUI-_GetLangKeyOrDefault0 = 575,
		Beyond-UI-CoolerUnitTemperatureCircleUI-_UpdateUIState0 = 576,
		Beyond-UI-CoolerUnitTemperatureUI-Init0 = 577,
		Beyond-UI-WorldUIController-Clear0 = 578,
		Beyond-UI-WorldUIController-set_uiActive0 = 579,
		Beyond-UI-CoolerUnitTemperatureUI-Clear0 = 580,
		Beyond-UI-CoolerUnitTemperatureUI-SetUIForward0 = 581,
		Beyond-UI-CoolerUnitTemperatureUI-SetPos0 = 582,
		Beyond-UI-CoolerUnitTemperatureUI-TickUI0 = 583,
		Beyond-UI-CoolerUnitTemperatureUI-_TickCanvasGroup0 = 584,
		Beyond-UI-CoolerUnitTemperatureUI-_UpdateUIInfo0 = 585,
		Beyond-UI-CoolerUnitTemperatureUI-NormalizeRange0 = 586,
		Beyond-UI-CoolerUnitTemperatureUI-_UpdateUIPos0 = 587,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_GeneratePercentStrings0 = 588,
		Beyond-UI-CoolerUnitTotalProgressBarUI-Init0 = 589,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_ResetUI0 = 590,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_GetCanvas0 = 591,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_TryGetModule0 = 592,
		Beyond-UI-CoolerUnitTotalProgressBarUI-SetUIForward0 = 593,
		Beyond-UI-CoolerUnitTotalProgressBarUI-SetPos0 = 594,
		Beyond-UI-CoolerUnitTotalProgressBarUI-TickUI0 = 595,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_TickCanvasGroup0 = 596,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_UpdateProgress0 = 597,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_SetProgressText0 = 598,
		Beyond-UI-FacLineCell-Awake0 = 599,
		Beyond-UI-FacLineCell-PlayLineAnimation0 = 600,
		Beyond-UI-FacLineCell-PlayLineDecoAnimation0 = 601,
		Beyond-UI-FacLineCell-ChangeLineColor0 = 604,
		Beyond-UI-FacLineCell-ChangeLineWidth0 = 605,
		Beyond-UI-FacLineDrawer-Awake0 = 606,
		Beyond-UI-FacLineDrawer-OnDestroy0 = 607,
		Beyond-UI-FacLineDrawer-_Clear0 = 608,
		Beyond-UI-FacLineDrawer-_CloneLineObject0 = 609,
		Beyond-UI-FacLineDrawer-_RefreshCopyLineObjectColor0 = 610,
		Beyond-UI-FacLineDrawer-ClearComponent0 = 611,
		Beyond-UI-FacLineDrawer-DrawLine0 = 612,
		Beyond-UI-FacLineDrawer-PlayLineAnimation0 = 613,
		Beyond-UI-FacLineDrawer-PlayPortLineDecoAnimation0 = 614,
		Beyond-UI-FacLineDrawer-ChangeLineColor0 = 615,
		Beyond-UI-FacLineDrawer-ClearDrawer0 = 616,
		Beyond-UI-FacRegionUpgradeEffectController-_RefreshNodeState0 = 617,
		Beyond-UI-FacRegionUpgradeEffectController-SetUpgradeState0 = 618,
		Beyond-UI-FacRegionUpgradeEffectController-SetSelectState0 = 619,
		Beyond-UI-FacRegionUpgradeEffectController-SetVisibleState0 = 620,
		Beyond-UI-UIFacTechTreePanel-OnRelease0 = 621,
		Beyond-UI-UIFacTechTreePanel-Tick0 = 622,
		Beyond-UI-UIFacTechTreePanel-_PosAdjust0 = 623,
		Beyond-UI-UIFacTechTreePanel-_UpdatePositionOffsetAfterZoomed0 = 624,
		Beyond-UI-UIFacTechTreePanel-_ControllerUpdate0 = 625,
		Beyond-UI-UIFacTechTreePanel-_ControllerZoomUpdate0 = 626,
		Beyond-UI-UIFacTechTreePanel-_OnZoom0 = 627,
		Beyond-UI-UIFacTechTreePanel-_RefreshPivotPosition0 = 628,
		Beyond-UI-UIFacTechTreePanel-_SetScale0 = 629,
		Beyond-UI-UIFacTechTreePanel-_ControllerDragUpdate0 = 630,
		Beyond-UI-UIFacTechTreePanel-InitData0 = 631,
		Beyond-UI-UIFacTechTreePanel-_OnDrag0 = 633,
		Beyond-UI-UIFacTechTreePanel-_RefreshAll0 = 635,
		Beyond-UI-UIFacTechTreePanel-MoveNode0 = 637,
		Beyond-UI-UIFacTechTreePanel-FocusNode0 = 638,
		Beyond-UI-UIFacTechTreePanel-_OnUnlockMoveNode0 = 639,
		Beyond-UI-UIFacTechTreePanel-OnUnlockTech0 = 640,
		Beyond-UI-UIFacTechTreePanel-ZoomToFullTechTree0 = 641,
		Beyond-UI-UIFacTechTreePanel-SetDetailShownState0 = 642,
		Beyond-UI-ForgeIronProgressBarUI-Init0 = 643,
		Beyond-UI-ForgeIronProgressBarUI-SetPos0 = 644,
		Beyond-UI-ForgeIronProgressBarUI-SetUIForward0 = 645,
		Beyond-UI-ForgeIronProgressBarUI-TickUI0 = 646,
		Beyond-UI-ForgeIronProgressBarUI-UpdateProgress0 = 647,
		Beyond-UI-ForgeIronTemperatureCircleUI-Init0 = 648,
		Beyond-UI-ForgeIronTemperatureCircleUI-Clear0 = 649,
		Beyond-UI-ForgeIronTemperatureCircleUI-SetPos0 = 650,
		Beyond-UI-ForgeIronTemperatureCircleUI-SetUIForward0 = 651,
		Beyond-UI-ForgeIronTemperatureCircleUI-TickUI0 = 652,
		Beyond-UI-ForgeIronTemperatureCircleUI-_SetState0 = 653,
		Beyond-UI-ForgeIronTemperatureCircleUI-UpdateUIState0 = 654,
		Beyond-UI-ForgeIronTemperatureUI-Init0 = 655,
		Beyond-UI-ForgeIronTemperatureUI-SetPos0 = 656,
		Beyond-UI-ForgeIronTemperatureUI-SetUIForward0 = 657,
		Beyond-UI-ForgeIronTemperatureUI-TickUI0 = 658,
		Beyond-UI-ForgeIronTemperatureUI-UpdateUIInfo0 = 659,
		Beyond-UI-ForgeIronTemperatureUI-UpdateUIPos0 = 660,
		Beyond-UI-GuideFakeButton-ForceToggleTargetBinding0 = 661,
		Beyond-UI-GuideFakeButton-CopyTargetBinding0 = 662,
		Beyond-UI-GuideFakeButton-_OnTriggerPlayerAction0 = 663,
		Beyond-UI-GuideFakeButton-ClearTarget0 = 664,
		Beyond-UI-GuideFakeButton-ClearBinding0 = 665,
		Beyond-UI-GuideFakeButton-_ClearOnClick0 = 666,
		Beyond-UI-GuideFakeButton-Awake0 = 667,
		Beyond-UI-GuideFakeButton-OnPointerDown0 = 668,
		Beyond-UI-GuideFakeButton-OnPointerUp0 = 669,
		Beyond-UI-GuideFakeButton-OnPointerEnter0 = 670,
		Beyond-UI-GuideFakeButton-OnPointerExit0 = 671,
		Beyond-UI-GuideFakeButton-OnPointerClick0 = 672,
		Beyond-UI-GuideFakeButton-ClearComponent0 = 673,
		Beyond-UI-RegionMap3DCfg-Load0 = 674,
		Beyond-UI-RegionMapSetting-get_cfg0 = 677,
		Beyond-UI-RegionMapSetting-OnDestroy0 = 678,
		Beyond-UI-RegionMapSetting-_ClearMaterials0 = 679,
		Beyond-UI-RegionMapSetting-_InitUI0 = 680,
		Beyond-UI-RegionMapSetting-_InitTrackIcon0 = 681,
		Beyond-UI-UIRegionMapTrackIcon-InitData0 = 682,
		Beyond-UI-RegionMapSetting-_SetMapPos0 = 683,
		Beyond-UI-RegionMapSetting-_InitPlayerIcon0 = 684,
		Beyond-UI-RegionMapSetting-_InitSelect0 = 685,
		Beyond-UI-RegionMapSetting-_RefreshMaterials0 = 686,
		Beyond-UI-RegionMapSetting-InitData0 = 687,
		Beyond-UI-RegionMapSetting-MoveToPlayer0 = 688,
		Beyond-UI-RegionMapSetting-IsCircleIntersectingRectangle0 = 689,
		Beyond-UI-RegionMapSetting-GetNodeTransform0 = 690,
		Beyond-UI-RegionMapSetting-GetNodeMoveTargetLocalPosition0 = 691,
		Beyond-UI-RegionMapSetting-GetCfg0 = 692,
		Beyond-UI-RegionMapSetting-SetLoadedRegionTransform0 = 693,
		Beyond-UI-RegionMapSetting-StartRegionRectTransformMoveRotationTween0 = 694,
		Beyond-UI-RegionMapSetting-SetControllerLevelSelectedState0 = 695,
		Beyond-UI-UIFacMainRegion-_OnMainRegionLevelChanged0 = 696,
		Beyond-UI-UIFacMainRegion-_RefreshRegionState0 = 697,
		Beyond-UI-UIFacMainRegion-OnDestroy0 = 698,
		Beyond-UI-UIFacMainRegion-ClearComponent0 = 699,
		Beyond-UI-UIFacMainRegion-InitMainRegion0 = 700,
		Beyond-UI-UILevelMapCrane-OnDestroy0 = 701,
		Beyond-UI-UILevelMapCrane-_ClearSpriteAsset0 = 702,
		Beyond-UI-UILevelMapCrane-ClearComponent0 = 703,
		Beyond-UI-UILevelMapCrane-_UnBindAll0 = 704,
		Beyond-UI-UILevelMapCrane-_OnCraneStateChanged0 = 705,
		Beyond-UI-UILevelMapCrane-_RefreshCraneState0 = 706,
		Beyond-UI-UILevelMapCrane-_BindAll0 = 707,
		Beyond-UI-UILevelMapCrane-InitCrane0 = 708,
		Beyond-UI-UILevelMapGameplayArea-_RefreshGameplayArea0 = 709,
		Beyond-UI-UILevelMapGameplayArea-Init0 = 710,
		Beyond-UI-UILevelMapGameplayArea-ClearComponent0 = 711,
		Beyond-UI-UILevelMapLimitInRect-LateTick0 = 712,
		Beyond-UI-UILevelMapLimitInRect-_LimitInRect0 = 713,
		Beyond-UI-UILevelMapLimitInRect-OnEnable0 = 714,
		Beyond-UI-UILevelMapLimitInRect-OnRelease0 = 715,
		Beyond-UI-UILevelMapLimitInRect-ClearComponent0 = 716,
		Beyond-UI-UILevelMapLimitInRect-StartLimitMarkInRect0 = 717,
		Beyond-UI-UILevelMapLimitInRect-StopLimitMarkInRect0 = 718,
		Beyond-UI-UILevelMapLimitInRect-ForceRefreshLimitState0 = 719,
		Beyond-UI-UILevelMapLine-OnEnable0 = 720,
		Beyond-UI-UILevelMapLine-_HoldLineSize0 = 721,
		Beyond-UI-UILevelMapLine-LateTick0 = 722,
		Beyond-UI-UILevelMapLine-Init0 = 723,
		Beyond-UI-UILevelMapLine-ClearComponent0 = 724,
		Beyond-UI-UILevelMapMissionArea-LateTick0 = 725,
		Beyond-UI-UILevelMapMissionArea-_DisappearIfOutRect0 = 726,
		Beyond-UI-UILevelMapMissionArea-_IsCircleOutsideDisappearRect0 = 727,
		Beyond-UI-UILevelMapMissionArea-_RefreshMissionArea0 = 728,
		Beyond-UI-UILevelMapMissionArea-Init0 = 729,
		Beyond-UI-UILevelMapMissionArea-ClearComponent0 = 730,
		Beyond-UI-UILevelMapMissionArea-ForceRefreshDisappearIfOutRect0 = 731,
		Beyond-UI-UILevelMapMisty-OnDestroy0 = 732,
		Beyond-UI-UILevelMapMisty-ClearComponent0 = 733,
		Beyond-UI-UILevelMapMisty-_UnBindAll0 = 734,
		Beyond-UI-UILevelMapMisty-_OnMistyStateChanged0 = 735,
		Beyond-UI-UILevelMapMisty-_RefreshMistyState0 = 736,
		Beyond-UI-UILevelMapMisty-IsMistyVisible0 = 737,
		Beyond-UI-UILevelMapMisty-_BindAll0 = 738,
		Beyond-UI-UILevelMapMisty-InitMisty0 = 739,
		Beyond-UI-UILevelMapSwitchBtn-InitSwitchButton0 = 740,
		Beyond-UI-UILevelMapSwitchBtn-ClearComponent0 = 743,
		Beyond-UI-UILevelMapTouchPanelWrapper-OnAwake0 = 744,
		Beyond-UI-UILevelMapTouchPanelWrapper-Tick0 = 745,
		Beyond-UI-UILevelMapTouchPanelWrapper-_CheckDrag0 = 746,
		Beyond-UI-UILevelMapTouchPanelWrapper-_IsFirstRaycastSelectable0 = 747,
		Beyond-UI-UILevelMapTouchPanelWrapper-_CheckScroll0 = 748,
		Beyond-UI-UIRegionMap3DPanel-_GetNodeTransform0 = 749,
		Beyond-UI-UIRegionMap3DPanel-_GetMoveTargetLocalPosition0 = 750,
		Beyond-UI-UIRegionMap3DPanel-_OnDoMoveTween0 = 751,
		Beyond-UI-UIRegionMap3DPanel-InitPanel0 = 752,
		Beyond-UI-UIRegionMap3DPanel-OnClickLevelBtn0 = 753,
		Beyond-UI-UIRegionMap3DPanel-OnLevelHoverChanged0 = 754,
		Beyond-UI-UISettlementRegion-OnDestroy0 = 755,
		Beyond-UI-UISettlementRegion-ClearComponent0 = 756,
		Beyond-UI-UISettlementRegion-_UnBindAll0 = 757,
		Beyond-UI-UISettlementRegion-_OnSettlementUnlocked0 = 758,
		Beyond-UI-UISettlementRegion-_RefreshSettlementRegionState0 = 759,
		Beyond-UI-UISettlementRegion-_RefreshSpriteWithTier0 = 760,
		Beyond-UI-UISettlementRegion-_BindAll0 = 761,
		Beyond-UI-UISettlementRegion-InitSettlementRegion0 = 762,
		Beyond-UI-UISettlementRegion-GetNeedRefreshSettlementRegionTier0 = 763,
		Beyond-UI-UISettlementRegion-RefreshSettlementRegionWithTier0 = 764,
		Beyond-UI-ChessboardDrop-OnDrop0 = 765,
		Beyond-UI-ChessboardDrop-_CheckEventValid0 = 766,
		Beyond-UI-ChessboardDrop-OnPointerEnter0 = 767,
		Beyond-UI-ChessboardDrop-OnPointerExit0 = 768,
		Beyond-UI-ChessboardDrop-ClearComponent0 = 769,
		Beyond-UI-ChessboardDrop-OnDestroy0 = 770,
		Beyond-UI-PuzzleCellDrag-Init0 = 771,
		Beyond-UI-PuzzleCellDrag-OnBeginDrag0 = 772,
		Beyond-UI-PuzzleDrag-OnBeginDrag0 = 773,
		Beyond-UI-PuzzleCellDrag-OnDrag0 = 774,
		Beyond-UI-PuzzleDrag-OnDrag0 = 775,
		Beyond-UI-PuzzleCellDrag-OnEndDrag0 = 776,
		Beyond-UI-PuzzleDrag-OnEndDrag0 = 777,
		Beyond-UI-PuzzleCellDrag-OnPointerDown0 = 778,
		Beyond-UI-PuzzleDrag-OnPointerDown0 = 779,
		Beyond-UI-PuzzleCellDrag-OnPointerUp0 = 780,
		Beyond-UI-PuzzleDrag-OnPointerUp0 = 781,
		Beyond-UI-PuzzleCellDrag-OnPointerClick0 = 782,
		Beyond-UI-PuzzleDrag-OnPointerClick0 = 783,
		Beyond-UI-PuzzleCellDrag-OnPointerEnter0 = 784,
		Beyond-UI-PuzzleDrag-OnPointerEnter0 = 785,
		Beyond-UI-PuzzleCellDrag-OnPointerExit0 = 786,
		Beyond-UI-PuzzleDrag-OnPointerExit0 = 787,
		Beyond-UI-PuzzleControllerHelper-get_raycastResults0 = 788,
		Beyond-UI-PuzzleControllerHelper-Awake0 = 789,
		Beyond-UI-PuzzleControllerHelper-TryGetPuzzleSlotIndexByPos0 = 790,
		Beyond-UI-PuzzleDrag-get_panel0 = 791,
		Beyond-UI-PuzzleDrag-Awake0 = 792,
		Beyond-UI-PuzzleDrag-ClearComponent0 = 793,
		Beyond-UI-PuzzleDrag-OnDestroy0 = 794,
		Beyond-UI-PuzzleDrag-SetIndex0 = 795,
		Beyond-UI-UIBrokenLine-Awake0 = 796,
		Beyond-UI-UIBrokenLine-_Init0 = 797,
		Beyond-UI-UIBrokenLine-OnDestroy0 = 798,
		Beyond-UI-UIBrokenLine-SetYValueByArray0 = 799,
		Beyond-UI-UIBrokenLine-SetYValue0 = 800,
		Beyond-UI-UICommonScanController-set_uiActive0 = 801,
		Beyond-UI-UICommonScanController-SetTarget0 = 802,
		Beyond-UI-UICommonScanController-_UpdatePos0 = 804,
		Beyond-UI-UICommonScanController-SetFixPoint0 = 805,
		Beyond-UI-UICommonScanController-Tick0 = 806,
		Beyond-UI-UICommonScanController-_FaceToCamera0 = 807,
		Beyond-UI-UICommonScanController-Clear0 = 808,
		Beyond-UI-UICountDownBar-set_update0 = 809,
		Beyond-UI-UICountDownBar-InitData0 = 810,
		Beyond-UI-UICountDownBar-_UpdateData0 = 811,
		Beyond-UI-UICountDownBar-_UpdatePos0 = 812,
		Beyond-UI-UICountDownBar-Clear0 = 813,
		Beyond-UI-UICountDownBar-LateTick0 = 814,
		Beyond-UI-UIDoodadMineCoreScanController-SyncConditonInfo0 = 815,
		Beyond-UI-UIDoodadMineCoreScanController-SetPurity0 = 816,
		Beyond-UI-UIDoodadMineCoreScanController-UpdateUI0 = 817,
		Beyond-UI-UIDoodadPlantCoreScanController-Tick0 = 818,
		Beyond-UI-UIDoodadPlantCoreScanController-_SyncTimeText0 = 819,
		Beyond-UI-UIDoodadPlantCoreScanController-SetCoreInfo0 = 820,
		Beyond-UI-UIDoodadPlantCoreScanController-SetRefreshInfo0 = 821,
		Beyond-UI-UIDoodadPlantCoreScanController-RefreshTextNow0 = 822,
		Beyond-UI-UIDoodadPlantCoreScanController-SetQuantityInfo0 = 823,
		Beyond-UI-UIDoodadPlantCoreScanController-SetSingle0 = 824,
		Beyond-UI-UIDoodadScanController-SyncRefreshInfo0 = 825,
		Beyond-UI-UIDoodadScanController-Tick0 = 826,
		Beyond-UI-UIDoodadScanController-_RefreshCountDown0 = 827,
		Beyond-UI-UIDoodadScanController-UpdateUI0 = 828,
		Beyond-UI-UIGeneralTracker-get_rect0 = 829,
		Beyond-UI-UIGeneralTracker-UpdatePosition0 = 830,
		Beyond-UI-UILiquidPoolScanController-SetWaterInfo0 = 831,
		Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateDistance0 = 832,
		Beyond-UI-UIPowerPoleAutoConnectTracker-_ActualUpdateStatus0 = 833,
		Beyond-UI-UIPowerPoleAutoConnectTracker-IconGroup-Switch0 = 834,
		Beyond-UI-UIPowerPoleAutoConnectTracker-StatusHintGroup-Switch0 = 835,
		Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateStatus0 = 836,
		Beyond-UI-UIPowerPoleAutoConnectTracker-_ActualUpdateIcon0 = 837,
		Beyond-UI-UIPowerPoleAutoConnectTracker-IconGroup-SetActiveIfNecessary0 = 838,
		Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateNodeType0 = 839,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_isDisabled0 = 840,
		Beyond-UI-UIPowerPoleFastTravelTracker-set_iconStatus0 = 841,
		Beyond-UI-UIPowerPoleFastTravelTracker-_UpdateIcon0 = 842,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageNormal0 = 843,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageNormalOther0 = 844,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageWarning0 = 845,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageHighlighted0 = 846,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageHighlightedOther0 = 847,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageDisabled0 = 848,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_animationWrapper0 = 849,
		Beyond-UI-UIPowerPoleFastTravelTracker-PlayFocus0 = 850,
		Beyond-UI-UIPowerPoleFastTravelTracker-UpdateIconStatus0 = 851,
		Beyond-UI-UIPowerPoleFastTravelTracker-UpdateStatus0 = 852,
		Beyond-UI-UIPowerPoleFastTravelTracker-UpdateIsHighlighted0 = 853,
		Beyond-UI-UIPowerPoleFastTravelTracker-UpdateIsOtherSocial0 = 854,
		Beyond-UI-UIPowerPoleFastTravelTracker-UpdateDistance0 = 855,
		Beyond-UI-UIPowerPoleFastTravelTracker-_OnStatusChanged0 = 856,
		Beyond-UI-UIPowerPoleFastTravelTracker-OnEnable0 = 857,
		Beyond-UI-UIRaceModuleRankController-_ResetData0 = 858,
		Beyond-UI-UIRaceModuleRankController-OnAwake0 = 859,
		Beyond-UI-UIRaceModuleRankController-_ShowBaseTrans0 = 860,
		Beyond-UI-UIRaceModuleRankController-_LoadAllSprite0 = 861,
		Beyond-UI-UIRaceModuleRankController-_UpdateRaceModuleRank0 = 862,
		Beyond-UI-UIRaceModuleRankController-OnRelease0 = 863,
		Beyond-UI-UIRaceModuleRankController-Tick0 = 864,
		Beyond-UI-UIVideoHelper-Reset0 = 865,
		Beyond-UI-UIVideoHelper-ResetVideo0 = 866,
		Beyond-UI-UIVideoHelper-Awake0 = 867,
		Beyond-UI-UIVideoHelper-OnEnable0 = 868,
		Beyond-UI-UIWaterDroneBar-OnAwake0 = 869,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneInfinityLiquidChanged0 = 870,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneEmptyChanged0 = 871,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneInteractiveChanged0 = 872,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneSourceTypeChanged0 = 873,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneRelaxChanged0 = 874,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneHydrantStateChanged1 = 875,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneHydrantStateChanged0 = 876,
		Beyond-UI-UIWaterDroneBar-OnEnable0 = 877,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneChange0 = 878,
		Beyond-UI-UIWaterDroneBar-_ClearWaterDrone0 = 879,
		Beyond-UI-UIWaterDroneBar-OnRelease0 = 880,
		Beyond-UI-UIWaterDroneBar-LateTick0 = 881,
		Beyond-UI-UIWaterDroneBar-_UpdateState0 = 882,
		Beyond-UI-UIWaterDroneBar-_SetIconStateController0 = 883,
		Beyond-UI-UIWaterDroneBar-_UpdateSlider0 = 884,
		Beyond-UI-WorldUIController-Tick0 = 885,
		Beyond-UI-WorldUIController-TickUI0 = 886,
		Beyond-UI-WorldUIController-OnRelease0 = 887,
		Beyond-UI-Mission-MissionHudBGSizeUpdater-LateTick0 = 888,
		Beyond-UI-Mission-MissionHudBGSizeUpdater-UpdateBgSize0 = 889
	}
}
