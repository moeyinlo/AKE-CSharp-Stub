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
using Beyond.PoolCore;
using Beyond.Resource;
using Beyond.UI;
using Beyond.UI.GPUI;
using Beyond.UI.UIState;
using CriWare;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using IFix;
using IFix.Core;
using Sirenix.OdinInspector;
using TMPro;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 21: UI.Gameplay.Beyond.dll - Assembly: UI.Gameplay.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 79983-80462

public class UIEquipRotHelper : TickableUIMono // TypeDefIndex: 79984
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
	[CompilerGenerated]
	private bool _playing_k__BackingField; // 0xBC

	// Properties
	protected override TickType tickOption { get; } // 0x0000000187239CB0-0x0000000187239CC0 
	public bool playing { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187258E80-0x0000000187258E90 0x0000000187258E90-0x0000000187258EA0

	// Constructors
	public UIEquipRotHelper(); // 0x000000018D25DFEC-0x000000018D25E000

	// Methods
	private Vector3 _ClampRot(Vector3 rot); // 0x000000018D25DE14-0x000000018D25DEAC
	private Vector3 _GetNearZero(Vector3 rot); // 0x000000018D25DEAC-0x000000018D25DF08
	private void _Init(); // 0x000000018D25DF08-0x000000018D25DFEC
	protected override void OnAwake(); // 0x000000018D25D704-0x000000018D25D724
	public override void Tick(float deltaTime); // 0x000000018D25D8E4-0x000000018D25DE14
	public void SelectPart(int index); // 0x000000018D25D74C-0x000000018D25D8E4
	protected override void OnRelease(); // 0x000000018D25D724-0x000000018D25D74C
	[CompilerGenerated]
	private void _SelectPart_b__22_0(); // 0x0000000187258E70-0x0000000187258E80
}

[ExecuteAlways]
public class UIWatchPanelCut : TickableUIMono // TypeDefIndex: 79985
{
	// Fields
	private Vector3 m_watchpanelPos; // 0x68
	private Vector3 m_watchpanelDir; // 0x74
	private Vector3 m_watchpanelRadius; // 0x80
	public float minimapRadius; // 0x8C
	public float eclosionRange; // 0x90

	// Properties
	protected override TickType tickOption { get; } // 0x0000000187239CB0-0x0000000187239CC0 

	// Constructors
	public UIWatchPanelCut(); // 0x000000018503EE80-0x000000018503EE90

	// Methods
	public void Start(); // 0x0000000187114300-0x0000000187114390
	public Vector3 GetIntersectWithLineAndPlane(Vector3 point, Vector3 direct, Vector3 planeNormal, Vector3 planePoint); // 0x000000018D25E118-0x000000018D25E27C
	public override void Tick(float deltaTime); // 0x0000000185D7A440-0x0000000185D7A530
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 80232
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_12 _11328A8F924E37E9332EFD9B6E621017D16D4199479DF8ADFCC16A5EB52CB3EB; // 0x00 // Static value (base64): CgAAAAMAAAADAAAA - Metadata: 0x0263C520

	// Nested types
	private struct __StaticArrayInitTypeSize_12 // TypeDefIndex: 80231
	{
	}

	// Methods
	internal static uint ComputeStringHash(string s); // 0x0000000188B56950-0x0000000188B569A4
}

namespace Beyond.PoolCore
{
	public static class ListPoolInitializer_UI_Gameplay_Beyond // TypeDefIndex: 79987
	{
		// Fields
		private static bool s_initialized; // 0x00
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void InitializeAtRuntime(); // 0x00000001870C0440-0x00000001870C0470
		private static void Initialize(); // 0x00000001870C0470-0x00000001870C0530
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 79988
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 79989
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 79990
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
		public bool native; // 0x19
	
		// Constructors
		public DataNAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 79991
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 79992
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class SwapRuntimeStateAttribute : Attribute // TypeDefIndex: 79993
	{
		// Constructors
		public SwapRuntimeStateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class ResetOnSwapAttribute : Attribute // TypeDefIndex: 79994
	{
		// Constructors
		public ResetOnSwapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace Beyond.UI
{
	public abstract class UICharPassiveBase : MonoBehaviour // TypeDefIndex: 79995
	{
		// Fields
		private ObjectPtr<AbilitySystem> m_boundAbilityPtr; // 0x18
		private bool m_buffIconListenerRegistered; // 0x28
		private bool m_destroying; // 0x29
	
		// Properties
		protected virtual bool listenBuffIconChange { get; } // 0x00000001871DDF30-0x00000001871DDF60 
		protected ObjectPtr<AbilitySystem> abilityPtr { get; } // 0x000000018D25A734-0x000000018D25A790 
	
		// Constructors
		protected UICharPassiveBase(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public virtual void OnCreate(bool isMainCharHpBar); // 0x000000018721D4C0-0x000000018721D4F0
		public virtual void OnCharPassiveNumChanged(float num); // 0x000000018D25A68C-0x000000018D25A6C0
		protected virtual void OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason); // 0x000000018D25A634-0x000000018D25A68C
		protected virtual void OnBindBuffEvent(AbilitySystem ability); // 0x000000018D25A5FC-0x000000018D25A634
		protected virtual void OnBound(AbilitySystem ability); // 0x00000001871FD350-0x00000001871FD380
		protected virtual void OnBeforeUnbind(AbilitySystem ability); // 0x000000018722C5C0-0x000000018722C5F0
		protected virtual void OnUnbindBuffEvent(AbilitySystem ability); // 0x000000018D25A6FC-0x000000018D25A734
		public void Bind(AbilitySystem ability); // 0x0000000185FDAFE0-0x0000000185FDB170
		public void Unbind(); // 0x0000000185FDB170-0x0000000185FDB230
		protected virtual void OnDestroy(); // 0x000000018D25A6C0-0x000000018D25A6FC
	}

	public class UICharPassiveCounter : UICharPassiveBase // TypeDefIndex: 79996
	{
		// Fields
		public UIStateController stateController; // 0x30
		public GameObject countTextRoot; // 0x38
		public UIText countText; // 0x40
		public UIImage[] layerImages; // 0x48
		public string normalStateName; // 0x50
		public string activeStateName; // 0x58
		public int activeCount; // 0x60
		private int m_currentCount; // 0x64
	
		// Constructors
		public UICharPassiveCounter(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public override void OnCharPassiveNumChanged(float num); // 0x000000018D25A790-0x000000018D25A90C
		public void __iFixBaseProxy_OnCharPassiveNumChanged(float P0); // 0x000000018D25A90C-0x000000018D25A914
	}

	public class UICharPassiveLiino : UICharPassiveBase // TypeDefIndex: 79999
	{
		// Fields
		public UIStateController stateController; // 0x30
		public string idleStateName; // 0x38
		public string normalStateName; // 0x40
		public UIImage normalProgressImage; // 0x48
		public UIAnimationWrapper normalAnimationWrapper; // 0x50
		public UIAnimationWrapper normalDecoAnimationWrapper; // 0x58
		[Unit(Units.Second)]
		public float normalLoopThreshold; // 0x60
		public string ultimateStateName; // 0x68
		public UIImage ultimateProgressImage; // 0x70
		public UIAnimationWrapper ultimateAnimationWrapper; // 0x78
		public UIAnimationWrapper ultimateDecoAnimationWrapper; // 0x80
		[Unit(Units.Second)]
		public float ultimateLoopThreshold; // 0x88
		public string normalBuffId; // 0x90
		public string ultimateBuffId; // 0x98
		public AnimStateInfo[] animStateInfos; // 0xA0
		private TickFunction m_lateTickFunction; // 0xA8
		private bool m_tickRegistered; // 0xB0
		private bool m_tickRunning; // 0xB1
		private ObjectPtr<Buff> m_normalBuffPtr; // 0xB8
		private ObjectPtr<Buff> m_ultimateBuffPtr; // 0xC8
		private DisplayState m_displayState; // 0xD8
		private bool m_playingOut; // 0xDC
		private bool m_loopStarted; // 0xDD
		private int m_triggeredAnimStateCount; // 0xE0
	
		// Properties
		protected override bool listenBuffIconChange { get; } // 0x000000018D25BD14-0x000000018D25BD54 
	
		// Nested types
		[Serializable]
		public struct AnimStateInfo // TypeDefIndex: 79997
		{
			// Fields
			public int fillAmount; // 0x00
			public string animName; // 0x08
		}
	
		private enum DisplayState // TypeDefIndex: 79998
		{
			Idle = 0,
			Normal = 1,
			Ultimate = 2
		}
	
		// Constructors
		public UICharPassiveLiino(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void Awake(); // 0x000000018D25A914-0x000000018D25AA58
		protected override void OnDestroy(); // 0x000000018D25AF98-0x000000018D25B028
		protected override void OnBound(AbilitySystem ability); // 0x000000018D25AAA8-0x000000018D25ADD0
		protected override void OnBeforeUnbind(AbilitySystem ability); // 0x000000018D25AA58-0x000000018D25AAA8
		protected override void OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason); // 0x000000018D25ADD0-0x000000018D25AF98
		private void _TryTrackBuff(ObjectPtr<Buff> buffPtr, string id); // 0x000000018D25BA60-0x000000018D25BB24
		private void _ForceIdle(); // 0x000000018D25B15C-0x000000018D25B264
		private void _RefreshDisplay(); // 0x000000018D25B64C-0x000000018D25B8DC
		private void _OnLateTick(float deltaTime); // 0x000000018D25B594-0x000000018D25B64C
		private void _CheckLoopThreshold(Buff activeBuff); // 0x000000018D25B0B4-0x000000018D25B15C
		private void _InitDecoThresholds(Buff activeBuff); // 0x000000018D25B348-0x000000018D25B4D0
		private void _UpdateDecoThresholds(float progress); // 0x000000018D25BB24-0x000000018D25BD14
		private Buff _GetActiveBuffForDisplay(); // 0x000000018D25B264-0x000000018D25B324
		private bool _IsBuffValid(ObjectPtr<Buff> ptr); // 0x000000018D25B4D0-0x000000018D25B594
		private static float _CalcProgress(Buff buff); // 0x000000018D24E134-0x000000018D24E320
		private void _SetProgress(Buff activeBuff); // 0x000000018D25B8DC-0x000000018D25B9D0
		private void _SetTickRunning(bool running); // 0x000000018D25B9D0-0x000000018D25BA60
		private UIAnimationWrapper _GetAnimWrapper(DisplayState state); // 0x000000018D25B324-0x000000018D25B334
		private UIAnimationWrapper _GetDecoWrapper(DisplayState state); // 0x000000018D25B334-0x000000018D25B348
		[CompilerGenerated]
		private void __RefreshDisplay_b__35_0(); // 0x000000018D25B06C-0x000000018D25B0B4
		public bool __iFixBaseProxy_get_listenBuffIconChange(); // 0x000000018D25B064-0x000000018D25B06C
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018D25B05C-0x000000018D25B064
		public void __iFixBaseProxy_OnBound(AbilitySystem P0); // 0x000000018D25B030-0x000000018D25B038
		public void __iFixBaseProxy_OnBeforeUnbind(AbilitySystem P0); // 0x000000018D25B028-0x000000018D25B030
		public void __iFixBaseProxy_OnBuffIconChange(ObjectPtr<Buff> P0, bool P1, Buff.FinishReason P2); // 0x000000018D25B038-0x000000018D25B05C
	}

	public class UICharPassiveLizhiyan : UICharPassiveBase // TypeDefIndex: 80000
	{
		// Fields
		public UIStateController stateController; // 0x30
		public UIText countText; // 0x38
		public UICharPassiveMultiStates.StateInfo[] states; // 0x40
		public int fullCount; // 0x48
		private int m_currentCount; // 0x4C
	
		// Constructors
		public UICharPassiveLizhiyan(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public override void OnCharPassiveNumChanged(float num); // 0x000000018D25BD54-0x000000018D25BE9C
		public void __iFixBaseProxy_OnCharPassiveNumChanged(float P0); // 0x000000018D25A90C-0x000000018D25A914
	}

	public class UICharPassiveMultiStates : UICharPassiveBase // TypeDefIndex: 80002
	{
		// Fields
		public UIStateController stateController; // 0x30
		public UIText countText; // 0x38
		public UIText extraCountText; // 0x40
		public StateInfo[] states; // 0x48
		public int fullCount; // 0x50
		private int m_currentCount; // 0x54
	
		// Nested types
		[Serializable]
		public struct StateInfo // TypeDefIndex: 80001
		{
			// Fields
			public int count; // 0x00
			public string stateName; // 0x08
		}
	
		// Constructors
		public UICharPassiveMultiStates(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		public override void OnCharPassiveNumChanged(float num); // 0x000000018596EB00-0x000000018596ECD0
		public void __iFixBaseProxy_OnCharPassiveNumChanged(float P0); // 0x000000018D25A90C-0x000000018D25A914
	}

	public class UICharPassiveTyphoea : UICharPassiveBase // TypeDefIndex: 80003
	{
		// Fields
		private static readonly string ARROW_READY_ANIM; // 0x00
		private static readonly string ARROW_IN_ANIM; // 0x08
		private static readonly string ARROW_FULL_ANIM; // 0x10
		public CanvasGroup canvasGroup; // 0x30
		public LayoutGroup arrowLayoutGroup; // 0x38
		public UIAnimationWrapper arrowAnim; // 0x40
		public LayoutGroup pointLayoutGroup; // 0x48
		public string arrowBuffId; // 0x50
		public string arrowBuffIdBattle; // 0x58
		public string pointBuffId; // 0x60
		public float arrowMaxFillAmount; // 0x68
		public List<UITyphoeaArrow> arrows; // 0x70
		public List<GameObject> points; // 0x78
		private UIHudFadeController m_hudFadeController; // 0x80
		private ObjectPtr<Buff> m_trackedArrowBuff; // 0x88
		private ObjectPtr<Buff> m_trackedBattleBuff; // 0x98
		private int m_lastArrowCount; // 0xA8
		private bool m_arrowFull; // 0xAC
		private bool m_wasBattle; // 0xAD
		private TickFunction m_tickFunction; // 0xB0
		private bool m_tickRegistered; // 0xB8
		private bool m_tickRunning; // 0xB9
	
		// Properties
		protected override bool listenBuffIconChange { get; } // 0x000000018D25D4C8-0x000000018D25D508 
	
		// Constructors
		public UICharPassiveTyphoea(); // 0x000000018D25D3F8-0x000000018D25D4C8
		static UICharPassiveTyphoea(); // 0x000000018D25D324-0x000000018D25D3F8
	
		// Methods
		public override void OnCreate(bool isMainCharHpBar); // 0x000000018D25C944-0x000000018D25C99C
		private void Awake(); // 0x000000018D25BE9C-0x000000018D25C054
		protected override void OnDestroy(); // 0x000000018D25C99C-0x000000018D25CA24
		protected override void OnBindBuffEvent(AbilitySystem ability); // 0x000000018D25C178-0x000000018D25C2E0
		protected override void OnUnbindBuffEvent(AbilitySystem ability); // 0x000000018D25CA24-0x000000018D25CB20
		protected override void OnBound(AbilitySystem ability); // 0x000000018D25C2E0-0x000000018D25C718
		protected override void OnBeforeUnbind(AbilitySystem ability); // 0x000000018D25C054-0x000000018D25C178
		protected override void OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason); // 0x000000018D25C718-0x000000018D25C944
		private void _OnBuffEnhanceChanged(ObjectPtr<Buff> buffPtr); // 0x000000018D25CC10-0x000000018D25CD54
		private int _GetActiveArrowCount(); // 0x000000018D25CB38-0x000000018D25CBB8
		private bool _UseBattleBuff(); // 0x000000018D25D2D4-0x000000018D25D324
		private int _GetArrowBuffIdCount(); // 0x000000018D25CBB8-0x000000018D25CC10
		private void _SetArrowVisibleCount(int visibleCount); // 0x000000018D25CEA8-0x000000018D25D1A4
		private void _OnTick(float deltaTime); // 0x000000018D25CD54-0x000000018D25CEA8
		private void _SetTickRunning(bool running); // 0x000000018D25D1A4-0x000000018D25D218
		private static void _SetVisibleCount(List<GameObject> items, int visibleCount); // 0x000000018D25D218-0x000000018D25D2D4
		public bool __iFixBaseProxy_get_listenBuffIconChange(); // 0x000000018D25B064-0x000000018D25B06C
		public void __iFixBaseProxy_OnCreate(bool P0); // 0x000000018D25CB28-0x000000018D25CB30
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018D25B05C-0x000000018D25B064
		public void __iFixBaseProxy_OnBindBuffEvent(AbilitySystem P0); // 0x000000018D25CB20-0x000000018D25CB28
		public void __iFixBaseProxy_OnUnbindBuffEvent(AbilitySystem P0); // 0x000000018D25CB30-0x000000018D25CB38
		public void __iFixBaseProxy_OnBound(AbilitySystem P0); // 0x000000018D25B030-0x000000018D25B038
		public void __iFixBaseProxy_OnBeforeUnbind(AbilitySystem P0); // 0x000000018D25B028-0x000000018D25B030
		public void __iFixBaseProxy_OnBuffIconChange(ObjectPtr<Buff> P0, bool P1, Buff.FinishReason P2); // 0x000000018D25B038-0x000000018D25B05C
	}

	public class UICharPassiveZhuangfy : UICharPassiveBase // TypeDefIndex: 80004
	{
		// Fields
		public UIStateController stateController; // 0x30
		public UIText countText; // 0x38
		public UICharPassiveMultiStates.StateInfo[] states; // 0x40
		public UIImage[] layerImages; // 0x48
		public int fullCount; // 0x50
		public UnityEngine.Color emptyColor; // 0x54
		public UnityEngine.Color normalColor; // 0x64
		public UnityEngine.Color overloadColor; // 0x74
		private int m_currentCount; // 0x84
	
		// Constructors
		public UICharPassiveZhuangfy(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public override void OnCharPassiveNumChanged(float num); // 0x000000018D25D508-0x000000018D25D704
		public void __iFixBaseProxy_OnCharPassiveNumChanged(float P0); // 0x000000018D25A90C-0x000000018D25A914
	}

	public class UITyphoeaArrow : MonoBehaviour // TypeDefIndex: 80005
	{
		// Fields
		public UIImage fillImage; // 0x18
		public UIAnimationWrapper inAnimWrapper; // 0x20
		public UIAnimationWrapper readyAnimWrapper; // 0x28
		public GameObject[] decos; // 0x30
	
		// Constructors
		public UITyphoeaArrow(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void SetDecosVisible(bool visible); // 0x000000018D25E074-0x000000018D25E118
		public void PlayAnimation(bool isBattle); // 0x000000018D25E000-0x000000018D25E074
	}

	public class LiinoRandomLikeEffect : TickableUIMono // TypeDefIndex: 80008
	{
		// Fields
		public RectTransform leftArea; // 0x68
		public RectTransform centerArea; // 0x70
		public RectTransform rightArea; // 0x78
		public UIAnimationWrapper[] bigEffectAnim; // 0x80
		public UIAnimationWrapper[] smallEffectAnim; // 0x88
		public int highFreqWeight; // 0x90
		public int lowFreqWeight; // 0x94
		[Tooltip("\u5DE6\u53F3\u533A\u57DF\u4E0D\u80FD\u8FDE\u7EED\u547D\u4E2D\u8D85\u8FC7\u6B64\u6B21\u6570")]
		public int maxConsecutiveSameSide; // 0x98
		[Tooltip("\u4E0A\u4E0B\u534A\u533A\u4E0D\u80FD\u8FDE\u7EED\u547D\u4E2D\u8D85\u8FC7\u6B64\u6B21\u6570")]
		public int maxConsecutiveSameHalf; // 0x9C
		public int minSmallCount; // 0xA0
		public int maxSmallCount; // 0xA4
		[Tooltip("\u5C0F\u56FE\u6807\u76F8\u5BF9\u5927\u56FE\u6807\u7684\u968F\u673A\u504F\u79FB(xy)")]
		public Vector2 smallOffsetRange; // 0xA8
		public float smallDelayTime; // 0xB0
		public float effectSpeed; // 0xB4
		private int m_consecutiveLeftCount; // 0xB8
		private int m_consecutiveRightCount; // 0xBC
		private int m_consecutiveUpperCount; // 0xC0
		private int m_consecutiveLowerCount; // 0xC4
		private int m_bigEffectIndex; // 0xC8
		private int m_smallEffectIndex; // 0xCC
		private readonly List<PendingEffect> m_pendingEffects; // 0xD0
		private readonly HashSet<UIAnimationWrapper> m_pendingSmallAnims; // 0xD8
		private readonly Dictionary<UIAnimationWrapper, TweenCallback> m_hideCallbacks; // 0xE0
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018D25A588-0x000000018D25A5CC 
	
		// Nested types
		private struct PendingEffect // TypeDefIndex: 80006
		{
			// Fields
			public UIAnimationWrapper anim; // 0x00
			public Vector3 worldPos; // 0x08
			public float triggerTime; // 0x14
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0 // TypeDefIndex: 80007
		{
			// Fields
			public UIAnimationWrapper cached; // 0x10
	
			// Constructors
			public __c__DisplayClass27_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __CacheHideCallbacks_b__0(); // 0x000000018D25A5CC-0x000000018D25A5FC
		}
	
		// Constructors
		public LiinoRandomLikeEffect(); // 0x000000018D25A408-0x000000018D25A588
	
		// Methods
		protected override void OnAwake(); // 0x000000018D259418-0x000000018D259490
		private void _CacheHideCallbacks(UIAnimationWrapper[] anims); // 0x000000018D259AA0-0x000000018D259BF4
		public void PlayEffect(); // 0x000000018D259560-0x000000018D2598FC
		public override void Tick(float deltaTime); // 0x000000018D2598FC-0x000000018D259AA0
		public void OnHide(); // 0x000000018D259490-0x000000018D259560
		private static void _ClearAnims(UIAnimationWrapper[] anims); // 0x000000018D259BF4-0x000000018D259CA8
		private UIAnimationWrapper _GetNextAvailableBig(); // 0x000000018D259CA8-0x000000018D259D94
		private UIAnimationWrapper _GetNextAvailableSmall(); // 0x000000018D259D94-0x000000018D259EF4
		private RectTransform _SelectArea(); // 0x000000018D25A224-0x000000018D25A338
		private bool _SelectHalf(); // 0x000000018D25A338-0x000000018D25A408
		private Vector3 _GetRandomPointInArea(RectTransform area, bool isUpper); // 0x000000018D259EF4-0x000000018D25A088
		private void _PlayEffectAt(UIAnimationWrapper anim, Vector3 worldPos); // 0x000000018D25A088-0x000000018D25A224
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	public abstract class ComboSpecialNodeBase : MonoBehaviour // TypeDefIndex: 80009
	{
		// Fields
		protected ComboSkillHint m_owner; // 0x18
	
		// Properties
		public abstract bool needTick { get; }
	
		// Constructors
		protected ComboSpecialNodeBase(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public virtual void OnAssignData(ComboSkillHint owner); // 0x000000018D24E320-0x000000018D24E360
		public virtual void OnReady(); // 0x000000018D24E394-0x000000018D24E3C8
		public virtual void OnTick(float deltaTime); // 0x000000018D24E3FC-0x000000018D24E430
		public virtual void OnCast(); // 0x000000018D24E360-0x000000018D24E394
		public virtual void OnRemove(); // 0x000000018D24E3C8-0x000000018D24E3FC
		public abstract void OnRelease();
	}

	public class ComboSpecialNodeRingQte : ComboSpecialNodeBase // TypeDefIndex: 80011
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
		public override bool needTick { get; } // 0x000000018D24F150-0x000000018D24F190 
	
		// Nested types
		private enum RingState // TypeDefIndex: 80010
		{
			None = 0,
			EarlyState = 1,
			PerfectState = 2,
			MissState = 3,
			PressedState = 4
		}
	
		// Constructors
		public ComboSpecialNodeRingQte(); // 0x000000018D24F124-0x000000018D24F150
	
		// Methods
		public override void OnAssignData(ComboSkillHint owner); // 0x000000018D24E430-0x000000018D24E7E4
		public override void OnCast(); // 0x000000018D24E7E4-0x000000018D24E9E0
		public override void OnRemove(); // 0x000000018D24EB10-0x000000018D24EB48
		public override void OnTick(float deltaTime); // 0x000000018D24EB48-0x000000018D24EE20
		public override void OnRelease(); // 0x000000018D24E9E0-0x000000018D24EB10
		private void _OnComboSkillRingQte([IsReadOnly] in EventData<int, float, float> evtData); // 0x000000018D24EF00-0x000000018D24F090
		private float _GetRemainTime(); // 0x000000018D24EE38-0x000000018D24EF00
		private void _Reset(); // 0x000000018D24F090-0x000000018D24F124
		public void __iFixBaseProxy_OnAssignData(ComboSkillHint P0); // 0x0000000187835500-0x0000000187835510
		public void __iFixBaseProxy_OnCast(); // 0x000000018D24EE20-0x000000018D24EE28
		public void __iFixBaseProxy_OnRemove(); // 0x000000018D24EE28-0x000000018D24EE30
		public void __iFixBaseProxy_OnTick(float P0); // 0x000000018D24EE30-0x000000018D24EE38
	}

	public enum DamageTextType // TypeDefIndex: 80012
	{
		Level0Normal = 0,
		Level1Normal = 1,
		Level0Critical = 2,
		Level1Critical = 3,
		Level0Block = 4,
		Level1Block = 5,
		Level1Fixed = 7,
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

	public class DamageTextCtrl : UIPanelBase // TypeDefIndex: 80014
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
		public UnityEngine.Color damageTextColorFixed; // 0x104
		public Vector2 mainChrDmgTxtSpawnOffset; // 0x114
		public Vector2 mainChrDmgTxtMoveSpawnOffset; // 0x11C
		public int mainChrDmgTxtMoveNum; // 0x124
		public float mainChrDmgTxtMoveSpawnWaitTime; // 0x128
		public Vector2 guardDmgTxtSpawnOffset; // 0x12C
		public Vector2 guardDmgTxtSpawnAreaSize; // 0x134
		public float dmgTxtCoalitionMaxTime; // 0x13C
		public bool enableGuardDmgTxtOverwrite; // 0x140
		[Header("\u5F02\u5E38\u3001\u878D\u5408\u8DF3\u5B57")]
		public Vector2 physicalInflictionTextOffset; // 0x144
		public Vector2 spellInflictionTextOffset; // 0x14C
		private static readonly Dictionary<DamageTextType, int> PRE_LOAD_TEXT_COUNTS; // 0x00
		private const string GUARD_OVERWRITE_COALITION_KEY = "guard_overwrite"; // Metadata: 0x0263BC3D
		private const string CRYST_BREAK_TEXT_ID = "ui_bat_elemental_cryst_break"; // Metadata: 0x0263BC4D
		private bool m_isShow; // 0x154
		private readonly Dictionary<DamageTextType, DamageTextBase> m_textPrefabMap; // 0x158
		private readonly List<DamageTextBase> m_showingTextInstances; // 0x160
		private readonly Dictionary<DamageTextType, Queue<DamageTextBase>> m_textPool; // 0x168
		private readonly Dictionary<DamageTextBase, Vector3> m_showingTextPos; // 0x170
		private readonly Dictionary<AbilitySystem, Dictionary<AbilitySystem, Dictionary<string, CoalitionDetail>>> m_entityCoalitionGroupMap; // 0x178
		private readonly Dictionary<AbilitySystem, Dictionary<int, float>> m_entityTextTimeMap; // 0x180
		private readonly Dictionary<ulong, DamageTextLevelUp> m_charLevelUpTextMap; // 0x188
		private readonly List<EventData<ulong, int>> m_charLevelUpTextToShow; // 0x190
		private readonly List<DamageTextBase> m_toRecycleInTick; // 0x198
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000186FD2D00-0x0000000186FD2D30 
		private static Vector3 outOfScreenPos { get; } // 0x000000018D256814-0x000000018D2568A8 
	
		// Nested types
		private struct CoalitionDetail // TypeDefIndex: 80013
		{
			// Fields
			public DamageTextBase instance; // 0x00
			public float time; // 0x08
			public double value; // 0x10
		}
	
		// Constructors
		public DamageTextCtrl(); // 0x0000000186C46FF0-0x0000000186C490B0
		static DamageTextCtrl(); // 0x0000000186E1BA90-0x0000000186E1BC60
	
		// Methods
		public void OnCreate(); // 0x000000018D253470-0x000000018D253CB0
		public void OnClose(); // 0x000000018D253028-0x000000018D253470
		public void DebugChangeImpl(bool disableThis); // 0x000000018D2528A0-0x000000018D253028
		public void OnShow(); // 0x000000018D253CF0-0x000000018D253F3C
		public void OnHide(); // 0x000000018D253CB0-0x000000018D253CF0
		public override void Tick(float deltaTime); // 0x0000000187102FC0-0x0000000187103080
		private void _OnHpChanged([IsReadOnly] in EventData<AbilitySystem.Modifier> eventData); // 0x000000018D25489C-0x000000018D255F28
		private void _OnIgniteBuffText([IsReadOnly] in EventData<AbilitySystem, Vector3, Vector2, string, EnergyShardType> eventData); // 0x000000018D255F28-0x000000018D2561E8
		private void _OnPhysicalInflictionApplied([IsReadOnly] in EventData<AbilitySystem, AbilitySystemForEnemyPart, PhysicalInflictionType> eventData); // 0x000000018D25640C-0x000000018D25654C
		private void _OnImmuneText([IsReadOnly] in EventData<AbilitySystem, Vector3, Vector2, string> eventData); // 0x000000018D2561E8-0x000000018D25640C
		private void _OnSquadInFightChanged([IsReadOnly] in EventData<bool> eventData); // 0x000000018D25654C-0x000000018D25660C
		private void _OnCreateFlowText([IsReadOnly] in EventData<Vector3, string, UnityEngine.Color> eventData); // 0x000000018D254764-0x000000018D25489C
		private void _OnCharLevelUp([IsReadOnly] in EventData<ulong, int> eventData); // 0x000000018D2544D4-0x000000018D254764
		private Vector2 _GetRandomTextOffset(float width, float height); // 0x000000018D2540F4-0x000000018D2541C4
		private bool _IsTextPosValid(Vector3 newPos); // 0x000000018D2542CC-0x000000018D2544D4
		private DamageTextBase _CreateTextInstance(DamageTextType textType); // 0x000000018D253F3C-0x000000018D2540F4
		private DamageTextBase _InstantiateTextInstance(DamageTextType textType); // 0x000000018D2541C4-0x000000018D2542CC
		private void _RecycleTextInstance(DamageTextBase textInstance); // 0x000000018D25660C-0x000000018D256814
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D2519E8-0x000000018D2519F0
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	public class DamageTextCtrlV2 : UIPanelBase // TypeDefIndex: 80018
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
		public float textRandomAreaWorldCameraDistance; // 0x9C
		public Vector2 textMinDist; // 0xA0
		public int textPosMaxRandomTimes; // 0xA8
		public UnityEngine.Color damageTextColorPhysical; // 0xAC
		public UnityEngine.Color damageTextColorReal; // 0xBC
		public UnityEngine.Color damageTextColorFire; // 0xCC
		public UnityEngine.Color damageTextColorPulse; // 0xDC
		public UnityEngine.Color damageTextColorCryst; // 0xEC
		public UnityEngine.Color damageTextColorNatural; // 0xFC
		public UnityEngine.Color damageTextColorEther; // 0x10C
		public UnityEngine.Color damageTextColorFixed; // 0x11C
		[Header("\u4E3B\u63A7\u4F24\u5BB3\u8DF3\u5B57")]
		public Vector2 mainChrDmgTxtSpawnOffset; // 0x12C
		public Vector2 mainChrDmgTxtMoveSpawnOffset; // 0x134
		public int mainChrDmgTxtMoveNum; // 0x13C
		public float mainChrDmgTxtMoveSpawnWaitTime; // 0x140
		public float dmgTxtCoalitionMaxTime; // 0x144
		[Header("\u961F\u53CB\u4F24\u5BB3\u8DF3\u5B57")]
		public Vector2 guardDmgTxtSpawnOffset; // 0x148
		public Vector2 guardDmgTxtSpawnAreaSize; // 0x150
		public bool enableGuardDmgTxtOverwrite; // 0x158
		[Header("\u5F02\u5E38\u8DF3\u5B57")]
		public Vector2 physicalInflictionTextOffset; // 0x15C
		public Vector2 spellInflictionTextOffset; // 0x164
		public float igniteBuffTextCoalitionMaxTime; // 0x16C
		private const string GUARD_OVERWRITE_COALITION_KEY = "guard_overwrite"; // Metadata: 0x0263BC6B
		private const string CRYST_BREAK_TEXT_ID = "ui_bat_elemental_cryst_break"; // Metadata: 0x0263BC7B
		private const string IGNITE_MULTIPLICATION_TEXT_ID = "ui_bat_elemental_multiplication"; // Metadata: 0x0263BC98
		private bool m_isShow; // 0x170
		private readonly Dictionary<DamageTextType, DamageTextBaseV2.DamageTextBaseConfig> m_textConfigMap; // 0x178
		private readonly List<DamageTextBaseV2> m_showingTextInstances; // 0x180
		private readonly Queue<DamageTextBaseV2> m_textPool; // 0x188
		private readonly Dictionary<DamageTextBaseV2, Vector3> m_showingTextPos; // 0x190
		private readonly Dictionary<AbilitySystem, Dictionary<AbilitySystem, Dictionary<string, CoalitionDetail>>> m_entityCoalitionGroupMap; // 0x198
		private readonly Dictionary<AbilitySystem, Dictionary<string, IgniteBuffCoalitionDetail>> m_entityIgniteBuffCoalitionMap; // 0x1A0
		private readonly Dictionary<AbilitySystem, Dictionary<int, float>> m_entityTextTimeMap; // 0x1A8
		private readonly Dictionary<ulong, DamageTextBaseV2> m_charLevelUpTextMap; // 0x1B0
		private readonly List<EventData<ulong, int>> m_charLevelUpTextToShow; // 0x1B8
		private readonly List<DamageTextBaseV2> m_toRecycleInTick; // 0x1C0
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000186FD2D30-0x0000000186FD2D60 
		private static Vector3 outOfScreenPos { get; } // 0x000000018D25280C-0x000000018D2528A0 
	
		// Nested types
		private struct CoalitionDetail // TypeDefIndex: 80015
		{
			// Fields
			public DamageTextBaseV2 instance; // 0x00
			public float time; // 0x08
			public double value; // 0x10
		}
	
		private struct IgniteBuffCoalitionDetail // TypeDefIndex: 80016
		{
			// Fields
			public DamageTextBaseV2 instance; // 0x00
			public float time; // 0x08
			public int count; // 0x0C
		}
	
		[Serializable]
		public class IgnitePrefabOverride // TypeDefIndex: 80017
		{
			// Fields
			public EnergyShardType energyShardType; // 0x10
			public string overrideName; // 0x18
			public bool isCrystBreak; // 0x20
	
			// Constructors
			public IgnitePrefabOverride(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public DamageTextCtrlV2(); // 0x0000000186BC5270-0x0000000186BC7BA0
	
		// Methods
		public void OnCreate(); // 0x0000000186817620-0x0000000186818F10
		public void OnClose(); // 0x000000018D251578-0x000000018D2519E8
		public void DebugChangeImpl(bool disableThis); // 0x000000018D250E2C-0x000000018D251578
		public void OnShow(); // 0x0000000186819110-0x0000000186819360
		public void OnHide(); // 0x0000000186FB8850-0x0000000186FB8880
		public override void Tick(float deltaTime); // 0x000000018550C9E0-0x000000018550CCE0
		private void _OnHpChanged([IsReadOnly] in EventData<AbilitySystem.Modifier> eventData); // 0x0000000185AD73D0-0x0000000185AD9860
		private void _OnIgniteBuffText([IsReadOnly] in EventData<AbilitySystem, Vector3, Vector2, string, EnergyShardType> eventData); // 0x000000018D251D7C-0x000000018D2524D8
		private void _OnPhysicalInflictionApplied([IsReadOnly] in EventData<AbilitySystem, AbilitySystemForEnemyPart, PhysicalInflictionType> eventData); // 0x000000018D2526D0-0x000000018D25280C
		private void _OnImmuneText([IsReadOnly] in EventData<AbilitySystem, Vector3, Vector2, string> eventData); // 0x000000018D2524D8-0x000000018D2526D0
		private void _OnSquadInFightChanged([IsReadOnly] in EventData<bool> eventData); // 0x0000000186819040-0x0000000186819110
		private void _OnCreateFlowText([IsReadOnly] in EventData<Vector3, string, UnityEngine.Color> eventData); // 0x000000018D251C40-0x000000018D251D7C
		private void _OnCharLevelUp([IsReadOnly] in EventData<ulong, int> eventData); // 0x000000018D2519F0-0x000000018D251C40
		private bool _UseWorldSpaceRandomArea(Vector3 textWorldPos); // 0x0000000185AD61F0-0x0000000185AD63E0
		private Vector2 _GetRandomTextOffset(float width, float height, bool useWorldOffset = false /* Metadata: 0x0263BC6A */, Vector3 textWorldPos = default); // 0x0000000185876370-0x00000001858766F0
		private bool _IsTextPosValid(Vector3 newPos); // 0x0000000185AD7120-0x0000000185AD7370
		private DamageTextBaseV2 _CreateTextInstance(DamageTextType textType, string overrideName = null); // 0x0000000185AD7010-0x0000000185AD7120
		private void _RecycleTextInstance(DamageTextBaseV2 textInstance); // 0x000000018544A5F0-0x000000018544A6D0
		private void _RemoveIgniteBuffCoalitionIfMatches(DamageTextBaseV2 textInstance); // 0x000000018544A7A0-0x000000018544AC60
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D2519E8-0x000000018D2519F0
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	public class DamageTextBase : TickableUIMono // TypeDefIndex: 80020
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
		protected override TickType tickOption { get; } // 0x0000000186A2B530-0x0000000186A2B560 
		public bool isFollowingTransform { get; } // 0x000000018D250940-0x000000018D250984 
		public Vector3 worldPosition { get; } // 0x000000018D2509CC-0x000000018D250AB0 
		public Vector2 uiOffset { get; } // 0x000000018D250984-0x000000018D2509CC 
	
		// Nested types
		[Serializable]
		public class SpawnPointConfig // TypeDefIndex: 80019
		{
			// Fields
			public Beyond.Gameplay.Core.ObjectType objectType; // 0x10
			public bool followTarget; // 0x14
			public bool useHitPoint; // 0x15
			[Tooltip("\u5982\u679C\u9009\u62E9\u751F\u6210\u5728\u6253\u51FB\u70B9\uFF0C\u6253\u51FB\u70B9\u4E0D\u5B58\u5728\u65F6\u4E5F\u4F1A\u5728\u6B64\u9AA8\u9ABC\u751F\u6210")]
			public Beyond.Gameplay.MountPoint targetMountPoint; // 0x18
	
			// Constructors
			public SpawnPointConfig(); // 0x0000000187258E60-0x0000000187258E70
		}
	
		// Constructors
		public DamageTextBase(); // 0x0000000186971820-0x0000000186971940
	
		// Methods
		protected override void OnAwake(); // 0x0000000185AD5810-0x0000000185AD58D0
		protected override void OnRelease(); // 0x000000018D24FB9C-0x000000018D24FC60
		public override void TailLateTick(float deltaTime); // 0x000000018D250620-0x000000018D250668
		public void SetFollowTarget(AbilitySystem target, AbilitySystem textTargetWhenTransferred, Vector3? hitPoint); // 0x000000018D24FD84-0x000000018D250338
		public void SetUIOffset(Vector2 offset); // 0x000000018D2505E4-0x000000018D250620
		public void Clear(); // 0x000000018D24FB50-0x000000018D24FB9C
		public virtual void SetColor(UnityEngine.Color color); // 0x000000018D24FD10-0x000000018D24FD84
		public virtual void PlayAnimation(); // 0x000000018D24FC60-0x000000018D24FD10
		private void _UpdatePosition(); // 0x000000018D250668-0x000000018D250940
		[IDTag(2)]
		public void SetText(string newText); // 0x000000018D250430-0x000000018D25050C
		[IDTag(1)]
		public void SetText(int newValue); // 0x000000018D25050C-0x000000018D2505E4
		[IDTag(0)]
		public void SetText(string prefix, int newValue); // 0x000000018D250338-0x000000018D250430
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
		public void __iFixBaseProxy_TailLateTick(float P0); // 0x0000000184167520-0x0000000184167530
	}

	public class DamageTextBaseV2 // TypeDefIndex: 80024
	{
		// Fields
		private static readonly Vector2 INVALID_POS; // 0x00
		private bool m_isFollowingTransform; // 0x10
		private Transform m_followedTransform; // 0x18
		private Vector3 m_followedPosition; // 0x20
		private Vector3 m_followedLocalPosition; // 0x2C
		private bool m_followByLocalPosition; // 0x38
		private bool m_isHitPointPosition; // 0x39
		private float m_followEndTime; // 0x3C
		private Vector2 m_uiOffset; // 0x40
		private GPUIHandle m_uiHandle; // 0x48
		private GPUISystem m_uiSystem; // 0x50
		private DamageTextBaseConfig m_config; // 0x58
		[CompilerGenerated]
		private ulong _targetCharInst_k__BackingField; // 0x60
		protected UnSafeString.UnSafeStringHandle m_textHandle; // 0x68
	
		// Properties
		public ulong targetCharInst { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232FA0-0x0000000187232FB0 0x0000000187233470-0x0000000187233480
		public float textNodeAlpha { get; } // 0x0000000185AD6FD0-0x0000000185AD7010 
		public float showDuration { get; } // 0x0000000185AD5FE0-0x0000000185AD6020 
		public bool isFollowingTransform { get; } // 0x000000018D24FA84-0x000000018D24FAC8 
		public bool isHitPointPosition { get; } // 0x000000018D24FAC8-0x000000018D24FB0C 
		public bool isActive { get; } // 0x000000018550CD10-0x000000018550CDB0 
		public Vector3 worldPosition { get; } // 0x000000018550D410-0x000000018550D460 
		public Vector2 uiOffset { get; } // 0x000000018D24FB0C-0x000000018D24FB50 
	
		// Nested types
		[Serializable]
		public class SpawnPointConfig // TypeDefIndex: 80021
		{
			// Fields
			public Beyond.Gameplay.Core.ObjectType objectType; // 0x10
			public bool followTarget; // 0x14
			public bool useHitPoint; // 0x15
			[Tooltip("\u5982\u679C\u9009\u62E9\u751F\u6210\u5728\u6253\u51FB\u70B9\uFF0C\u6253\u51FB\u70B9\u4E0D\u5B58\u5728\u65F6\u4E5F\u4F1A\u5728\u6B64\u9AA8\u9ABC\u751F\u6210")]
			public Beyond.Gameplay.MountPoint targetMountPoint; // 0x18
	
			// Constructors
			public SpawnPointConfig(); // 0x0000000187258E60-0x0000000187258E70
		}
	
		public enum DamageTextSortingPriority // TypeDefIndex: 80022
		{
			Level0 = 0,
			Level1 = 1,
			Level2 = 2
		}
	
		[Serializable]
		public class DamageTextBaseConfig // TypeDefIndex: 80023
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
			public DamageTextBaseConfig(); // 0x000000018694A3D0-0x000000018694A530
		}
	
		// Constructors
		public DamageTextBaseV2(GPUISystem uiSystem); // 0x0000000185AD58D0-0x0000000185AD5910
		static DamageTextBaseV2(); // 0x000000018721B5A0-0x000000018721B5E0
	
		// Methods
		public void OnRelease(); // 0x000000018D24F190-0x000000018D24F1F8
		public void Assign(DamageTextBaseConfig config, string overrideName = null); // 0x0000000185449F40-0x000000018544A080
		public void Tick(Vector2 screenCenter, float scaleFactor); // 0x000000018550CCE0-0x000000018550CD10
		public void SetFollowTarget(AbilitySystem target, AbilitySystem textTargetWhenTransferred, Vector3? hitPoint, float followDuration = 0f /* Metadata: 0x0263BCB8 */); // 0x0000000185AD63E0-0x0000000185AD68E0
		public void SetUIOffset(Vector2 offset); // 0x000000018D24F9A0-0x000000018D24F9D8
		public void Clear(); // 0x000000018544A6D0-0x000000018544A720
		public void DestroyDisplay(); // 0x0000000185AD57C0-0x0000000185AD5810
		public virtual void SetColor(UnityEngine.Color color); // 0x0000000185AD68E0-0x0000000185AD6CF0
		public virtual void PlayAnimation(bool isLeft = true /* Metadata: 0x0263BCBC */); // 0x0000000185AD6F30-0x0000000185AD6FA0
		private void _UpdatePosition(Vector2 screenCenter, float scaleFactor); // 0x000000018550D0A0-0x000000018550D410
		private Vector3 _GetWorldPosition(); // 0x000000018550D460-0x000000018550D5C0
		private void _SetStaticPosition(Vector3 position); // 0x000000018D24F9D8-0x000000018D24FA84
		private void _SetTransformPosition(Transform followedTransform, bool followForever, float followDuration); // 0x0000000185AD6020-0x0000000185AD61F0
		private void _SetHitPointPosition(Transform rootTransform, Vector3 hitPoint, float followDuration); // 0x0000000185AD5EA0-0x0000000185AD5FE0
		[IDTag(2)]
		public void SetText(string newText); // 0x000000018D24F784-0x000000018D24F9A0
		public void SetTextWithMultiplier(string newText, string multiplierFormat, int multiplier); // 0x000000018D24F1F8-0x000000018D24F540
		[IDTag(1)]
		public void SetText(int newValue); // 0x0000000185445C10-0x0000000185445E60
		[IDTag(0)]
		public void SetText(string prefix, int newValue); // 0x000000018D24F540-0x000000018D24F784
	}

	public class DamageTextBlock : DamageTextDamageBase // TypeDefIndex: 80025
	{
		// Fields
		public UIImage blockIcon; // 0xC0
	
		// Constructors
		public DamageTextBlock(); // 0x0000000186971810-0x0000000186971820
	
		// Methods
		public override void SetColor(UnityEngine.Color color); // 0x000000018D250AB0-0x000000018D250B54
		public void __iFixBaseProxy_SetColor(UnityEngine.Color P0); // 0x000000018D250B54-0x000000018D250B74
	}

	public class DamageTextCriticalLevel0 : DamageTextDamageBase // TypeDefIndex: 80026
	{
		// Fields
		public UIText criticalIcon; // 0xC0
	
		// Constructors
		public DamageTextCriticalLevel0(); // 0x0000000186971810-0x0000000186971820
	
		// Methods
		public override void SetColor(UnityEngine.Color color); // 0x000000018D250B74-0x000000018D250C10
		public void __iFixBaseProxy_SetColor(UnityEngine.Color P0); // 0x000000018D250B54-0x000000018D250B74
	}

	public class DamageTextCriticalLevel1 : DamageTextDamageBase // TypeDefIndex: 80027
	{
		// Fields
		public UIText criticalIcon; // 0xC0
		public UIText criticalIconShadow; // 0xC8
		public UIImage bg01; // 0xD0
		public UIImage bg02; // 0xD8
		private const string ANIM_NAME_CRITICAL_LEFT = "battletext_critical_left"; // Metadata: 0x0263BCC0
		private const string ANIM_NAME_CRITICAL_RIGHT = "battletext_critical_right"; // Metadata: 0x0263BCD9
	
		// Constructors
		public DamageTextCriticalLevel1(); // 0x0000000186971810-0x0000000186971820
	
		// Methods
		public override void SetColor(UnityEngine.Color color); // 0x000000018D250D14-0x000000018D250E24
		public override void PlayAnimation(bool isLeft); // 0x000000018D250C10-0x000000018D250D14
		public void __iFixBaseProxy_SetColor(UnityEngine.Color P0); // 0x000000018D250B54-0x000000018D250B74
		public void __iFixBaseProxy_PlayAnimation(bool P0); // 0x000000018D250E24-0x000000018D250E2C
	}

	public class DamageTextDamageBase : DamageTextBase // TypeDefIndex: 80028
	{
		// Constructors
		public DamageTextDamageBase(); // 0x0000000186971810-0x0000000186971820
	
		// Methods
		public virtual void PlayAnimation(bool isLeft); // 0x000000018D2568A8-0x000000018D25695C
	}

	public class DamageTextIgniteBuff : DamageTextBase // TypeDefIndex: 80029
	{
		// Fields
		public UIImage bg; // 0xC0
		public UIText textDuplication; // 0xC8
		public UIStateController stateController; // 0xD0
	
		// Constructors
		public DamageTextIgniteBuff(); // 0x0000000186971810-0x0000000186971820
	
		// Methods
		protected override void OnAwake(); // 0x000000018710F6B0-0x000000018710F760
		protected override void OnRelease(); // 0x000000018D25695C-0x000000018D256A14
		public void SetUIState(EnergyShardType energyShardType, bool isCrystBreak = false /* Metadata: 0x0263BCF3 */); // 0x000000018D256B18-0x000000018D256C64
		public void SetTextAndDuplication(string newText); // 0x000000018D256A14-0x000000018D256B18
		public void __iFixBaseProxy_OnAwake(); // 0x000000018D256C64-0x000000018D256C6C
		public void __iFixBaseProxy_OnRelease(); // 0x000000018D256C6C-0x000000018D256C74
	}

	public class DamageTextLevelUp : DamageTextBase // TypeDefIndex: 80030
	{
		// Fields
		[CompilerGenerated]
		private ulong _targetCharInst_k__BackingField; // 0xC0
	
		// Properties
		public ulong targetCharInst { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187236200-0x0000000187236210 0x0000000187236220-0x0000000187236230
	
		// Constructors
		public DamageTextLevelUp(); // 0x0000000186971810-0x0000000186971820
	}

	public class DamageTextNormalLevel1 : DamageTextDamageBase // TypeDefIndex: 80031
	{
		// Fields
		private const string ANIM_NAME_NORMAL_LEFT = "battletext_normal_left"; // Metadata: 0x0263BCF4
		private const string ANIM_NAME_NORMAL_RIGHT = "battletext_normal_right"; // Metadata: 0x0263BD0B
	
		// Constructors
		public DamageTextNormalLevel1(); // 0x0000000186971810-0x0000000186971820
	
		// Methods
		public override void PlayAnimation(bool isLeft); // 0x000000018D256C74-0x000000018D256D78
		public void __iFixBaseProxy_PlayAnimation(bool P0); // 0x000000018D250E24-0x000000018D250E2C
	}

	public class FootBarDashCell : MonoBehaviour // TypeDefIndex: 80032
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
		private const int MAX_DASH_COUNT_IN_RING = 8; // Metadata: 0x0263BD23
		private const float FILL_AMOUNT_PER_CELL = 0.125f; // Metadata: 0x0263BD24
		private const float ANGLE_PER_CELL = 45f; // Metadata: 0x0263BD28
		private const float ANGLE_PER_HALF_CELL = 22.5f; // Metadata: 0x0263BD2C
		private const float ANGLE_PER_QUARTER_CELL = 11.25f; // Metadata: 0x0263BD30
	
		// Constructors
		public FootBarDashCell(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void SetIndex(int index); // 0x000000018D256F54-0x000000018D25700C
		public void SetDashCount(float dashFillCount); // 0x000000018D256D78-0x000000018D256F54
		public void StartPlayNotEnoughAnim(); // 0x000000018D25700C-0x000000018D2570BC
		public void StopPlayNotEnoughAnim(); // 0x000000018D2570BC-0x000000018D25716C
	}

	public class HeadBarCtrl : UIPanelBase // TypeDefIndex: 80039
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
		private GameObject _headBuffPrefab; // 0xA0
		[SerializeField]
		private float _hideHeadBarNotInFightDelay; // 0xA8
		[SerializeField]
		private int _headBarInvisibleEnemyCount; // 0xAC
		[SerializeField]
		private float _headBarInvisibleHpNoChangeTime; // 0xB0
		[SerializeField]
		private float _headBarInvisibleScreenEdgeRatio; // 0xB4
		[SerializeField]
		private float _headBarInvisibleDistance; // 0xB8
		private const float TICK_SURROUNDING_INTERVAL = 0.2f; // Metadata: 0x0263BD37
		private const string HEAD_BAR_BROKEN_ANIM = "headbar_broken_in"; // Metadata: 0x0263BD3B
		private static readonly int[] HEAD_BAR_PREWARM_CNT; // 0x00
		private Transform m_worldObjectRoot; // 0xC0
		private static HashSet<ObjectPtr<AbilitySystem>> s_abilitySystemsToShowBar; // 0x08
		private static HashSet<ObjectPtr<AbilitySystem>> s_abilitySystemsToHideBar; // 0x10
		private static HashSet<ObjectPtr<AbilitySystem>> s_surroundingEnemies; // 0x18
		private float m_lastTickSurrounding; // 0xC8
		private bool m_inDialog; // 0xCC
		private Dictionary<ObjectPtr<AbilitySystem>, UIHeadBarFollower> m_headBarDict; // 0xD0
		private Dictionary<ObjectPtr<AbilitySystem>, UIHeadBarFollower> m_headBarWithOutAnimDict; // 0xD8
		private List<UIHeadBarFollower> m_mobHeadBarPool; // 0xE0
		private List<UIHeadBarFollower> m_eliteHeadBarPool; // 0xE8
		private List<UIHeadBarFollower> m_enemyPartHeadBarPool; // 0xF0
		private Dictionary<ObjectPtr<AbilitySystem>, AbilitySystem.Modifier> m_nonFullHpAbilitySystems; // 0xF8
		private Dictionary<ObjectPtr<AbilitySystem>, ValueTuple<AbilitySystem.Modifier, PeriodicTimer>> m_enemyFirstDamageDict; // 0x100
		private HashSet<ObjectPtr<AbilitySystem>> m_enabledEnemyPartsByAction; // 0x108
		private Dictionary<ObjectPtr<AbilitySystem>, UILvInfoBar> m_levelInfoBarDict; // 0x110
		private Dictionary<ObjectPtr<AbilitySystem>, UILvInfoBar> m_levelInfoBarWithOutAnimDict; // 0x118
		private List<UILvInfoBar> m_levelInfoBarPool; // 0x120
		private Dictionary<ObjectPtr<AbilitySystem>, UIVigilanceBar> m_vigilanceBarDict; // 0x128
		private List<UIVigilanceBar> m_vigilanceBarPool; // 0x130
		private Dictionary<ObjectPtr<AbilitySystem>, UITacticalItemBar> m_tacticalItemBarDict; // 0x138
		private Dictionary<ObjectPtr<AbilitySystem>, UITacticalItemBar> m_tacticalItemBarWithOutAnimDict; // 0x140
		private List<UITacticalItemBar> m_tacticalItemBarPool; // 0x148
		private Dictionary<ObjectPtr<AbilitySystem>, UIHeadBuff> m_headBuffDict; // 0x150
		private List<UIHeadBuff> m_headBuffPool; // 0x158
		private Dictionary<ObjectPtr<Buff>, UIHeadBuff> m_directHeadBuffDict; // 0x160
		private Dictionary<ObjectPtr<Buff>, UIHeadBuff> m_directHeadBuffWithOutAnimDict; // 0x168
		private List<ObjectPtr<Buff>> m_directHeadBuffRemoveBuffer; // 0x170
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000186B179D0-0x0000000186B17A00 
		private bool forceHide { get; } // 0x0000000185CE4F80-0x0000000185CE4FE0 
	
		// Nested types
		public enum HeadBarType // TypeDefIndex: 80033
		{
			Mob = 0,
			Elite = 1,
			EnemyPart = 2,
			CNT = 3
		}
	
		private enum HeadBarRefreshReason // TypeDefIndex: 80034
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
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0 // TypeDefIndex: 80035
		{
			// Fields
			public ObjectPtr<AbilitySystem> abilitySystemPtr; // 0x10
			public UIHeadBarFollower bar; // 0x20
			public HeadBarCtrl __4__this; // 0x28
	
			// Constructors
			public __c__DisplayClass58_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __RefreshHeadBar_b__1(); // 0x0000000185CE1000-0x0000000185CE10E0
			internal void __RefreshHeadBar_b__2(); // 0x000000018D260E78-0x000000018D260F00
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_0 // TypeDefIndex: 80036
		{
			// Fields
			public ObjectPtr<AbilitySystem> abilitySystemPtr; // 0x10
			public UILvInfoBar bar; // 0x20
			public HeadBarCtrl __4__this; // 0x28
	
			// Constructors
			public __c__DisplayClass62_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __UpdateLevelInfoBar_b__0(); // 0x0000000185CE0F30-0x0000000185CE0FC0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass64_0 // TypeDefIndex: 80037
		{
			// Fields
			public ObjectPtr<AbilitySystem> abilitySystemPtr; // 0x10
			public UITacticalItemBar bar; // 0x20
			public HeadBarCtrl __4__this; // 0x28
	
			// Constructors
			public __c__DisplayClass64_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __UpdateTacticalItemBar_b__0(); // 0x000000018D260F00-0x000000018D260F88
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass72_0 // TypeDefIndex: 80038
		{
			// Fields
			public HeadBarCtrl __4__this; // 0x10
			public ObjectPtr<Buff> buffPtr; // 0x18
			public UIHeadBuff bar; // 0x28
	
			// Constructors
			public __c__DisplayClass72_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __RemoveDirectHeadBuff_b__0(); // 0x000000018D260F88-0x000000018D261010
		}
	
		// Constructors
		public HeadBarCtrl(); // 0x0000000186579EF0-0x000000018657A580
		static HeadBarCtrl(); // 0x000000018657B740-0x000000018657B8D0
	
		// Methods
		public void OnCreate(Transform worldObjectRoot); // 0x0000000186819360-0x0000000186819900
		public void OnClose(); // 0x000000018D25716C-0x000000018D2584EC
		public void OnShow(); // 0x0000000186947E90-0x00000001869484D0
		public void OnHide(); // 0x00000001870B3030-0x00000001870B3060
		public override void LateTick(float deltaTime); // 0x000000018550A3C0-0x000000018550A440
		private void _OnAddHeadBar([IsReadOnly] in EventData<AbilitySystem> eventData); // 0x0000000185CE17B0-0x0000000185CE17F0
		private void _OnRemoveHeadBar([IsReadOnly] in EventData<AbilitySystem, bool> eventData); // 0x0000000185CE17F0-0x0000000185CE1830
		private void _OnHeadBarShowConfigChanged(); // 0x000000018D2589D0-0x000000018D258A14
		private void _OnHpChanged([IsReadOnly] in EventData<AbilitySystem.Modifier> eventData); // 0x00000001858A5840-0x00000001858A5D30
		private void _OnEnemyPartEnableChanged([IsReadOnly] in EventData<AbilitySystemForEnemyPart, bool> eventData); // 0x000000018D2588C4-0x000000018D2589D0
		private void _RefreshHeadBar(HeadBarRefreshReason reason); // 0x0000000185CE33F0-0x0000000185CE4F40
		private void _PrewarmHeadBar(); // 0x0000000185CE1160-0x0000000185CE14C0
		private static HeadBarType _GetHeadBarType(ObjectPtr<AbilitySystem> abilitySystemPtr); // 0x00000001869DF280-0x00000001869DF3E0
		private void _UpdateHeadBar(float deltaTime); // 0x0000000185508F70-0x000000018550A3C0
		private void _UpdateLevelInfoBar(float deltaTime); // 0x00000001855075D0-0x00000001855083C0
		private void _UpdateVigilanceBar(float deltaTime); // 0x00000001855083C0-0x0000000185508F70
		private void _UpdateTacticalItemBar(float deltaTime); // 0x00000001855065F0-0x0000000185507260
		private void _OnBountyEnemyChanged(); // 0x000000018D2587F4-0x000000018D25882C
		private void _RefreshSeasonTowerHeadBuff(); // 0x000000018D258A5C-0x000000018D2593DC
		private string _FindBountyBuffIcon(ObjectPtr<AbilitySystem> abilitySystemPtr); // 0x000000018D2584EC-0x000000018D2587F4
		private void _RefreshDirectHeadBuff(); // 0x0000000186D40110-0x0000000186D40400
		private void _RemoveInvalidDirectHeadBuff(); // 0x0000000186D40400-0x0000000186D406C0
		private void _OnBuffIconChange([IsReadOnly] in EventData<AbilitySystem, ObjectPtr<Buff>, bool, Buff.FinishReason> eventData); // 0x0000000185CE5200-0x0000000185CE5270
		private bool _TryShowDirectHeadBuff(ObjectPtr<Buff> buffPtr); // 0x0000000185CE50E0-0x0000000185CE5200
		private void _RemoveDirectHeadBuff(ObjectPtr<Buff> buffPtr); // 0x0000000185CE5270-0x0000000185CE5370
		private bool _ShouldShowDirectHeadBuff(ObjectPtr<Buff> buffPtr); // 0x0000000185CE4FE0-0x0000000185CE50E0
		private void _UpdateSurroundingEnemies(float deltaTime); // 0x000000018550A440-0x000000018550A650
		private T _CreateBar<T>(HeadBarType headBarType = HeadBarType.Mob /* Metadata: 0x0263BD34 */)
			where T : UIAbilityTargetFollower;
		private void _RecycleBar<T>(T bar)
			where T : UIAbilityTargetFollower;
		private List<T> _GetBarPool<T>(HeadBarType headBarType = HeadBarType.Mob /* Metadata: 0x0263BD35 */)
			where T : UIAbilityTargetFollower;
		private GameObject _GetBarPrefab<T>(HeadBarType headBarType = HeadBarType.Mob /* Metadata: 0x0263BD36 */)
			where T : UIAbilityTargetFollower;
		private void _OnInteractNpc([IsReadOnly] in EventData<string, Entity> eventData); // 0x000000018D258A14-0x000000018D258A5C
		private void _OnDialogStart([IsReadOnly] in EventData<bool, DialogEnums.DialogType> eventData); // 0x000000018D258874-0x000000018D2588C4
		private void _OnDialogFinish([IsReadOnly] in EventData<bool> eventData); // 0x000000018D25882C-0x000000018D258874
		private void _SetInDialog(bool inDialog); // 0x000000018D2593DC-0x000000018D259418
		[CompilerGenerated]
		internal static bool __RefreshHeadBar_g__ToShow_58_0(AbilitySystem abilitySystem); // 0x0000000185CE4F40-0x0000000185CE4F80
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D2519E8-0x000000018D2519F0
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public class UICountShieldCell : MonoBehaviour // TypeDefIndex: 80040
	{
		// Fields
		private const string SHAKE_ANIMATION = "countshieldstate_shieldcell_shaking"; // Metadata: 0x0263BD5A
		[SerializeField]
		private UIAnimationWrapper _anim; // 0x18
		[SerializeField]
		private CanvasGroup _canvasGroup; // 0x20
	
		// Constructors
		public UICountShieldCell(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		public void SetCellActive(bool active, bool playAnim); // 0x000000018D2610B4-0x000000018D26124C
		public void PlayShakeAnimation(); // 0x000000018D261010-0x000000018D2610B4
		[CompilerGenerated]
		private void _SetCellActive_b__3_0(); // 0x000000018D26124C-0x000000018D261270
	}

	public class UICountShieldNode : MonoBehaviour // TypeDefIndex: 80041
	{
		// Fields
		private const string HP_ONLY_UI_STATE = "HpOnlyState"; // Metadata: 0x0263BD7E
		private const string HP_AND_POISE_UI_STATE = "HpAndPoiseState"; // Metadata: 0x0263BD8A
		private const string NO_COUNT_SHIELD_STATE = "NoCountShieldState"; // Metadata: 0x0263BD9A
		[SerializeField]
		private CanvasGroup _countShieldNode; // 0x18
		[SerializeField]
		private UIAnimationWrapper _countShieldNodeAnim; // 0x20
		[SerializeField]
		private UIStateController _uiState; // 0x28
		[SerializeField]
		private UICountShieldCell _countShieldCell; // 0x30
		[SerializeField]
		private CanvasGroup _countShieldCellLayout; // 0x38
		[SerializeField]
		private CanvasGroup _lockIconCanvasGroup; // 0x40
		[SerializeField]
		private CanvasGroup _removeShieldNodeCanvasGroup; // 0x48
		[SerializeField]
		private UIAnimationWrapper _removeShieldNodeAnim; // 0x50
		private ObjectPtr<AbilitySystem> m_owner; // 0x58
		private List<UICountShieldCell> m_countShieldCellList; // 0x68
		private bool m_isPoiseNodeActive; // 0x70
		private bool m_isCountShieldNodeActive; // 0x71
	
		// Constructors
		public UICountShieldNode(); // 0x0000000186BA3750-0x0000000186BA37E0
	
		// Methods
		public void Init(AbilitySystem owner, bool isPoiseNodeActive); // 0x0000000186960A10-0x0000000186960F00
		public void OnCountShieldUiChange(bool playAnim); // 0x0000000186960F00-0x0000000186962B10
		public void ShakeRightmostActiveCell(); // 0x000000018D261270-0x000000018D261358
		[CompilerGenerated]
		private void _OnCountShieldUiChange_b__16_0(); // 0x000000018D261358-0x000000018D261388
	}

	[Serializable]
	public class HpChangeDisplayData // TypeDefIndex: 80042
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
		public HpChangeDisplayData(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class UIHeadBar : MonoBehaviour // TypeDefIndex: 80044
	{
		// Fields
		private static readonly GameplayTag ONLY_SPECIAL_COUNT_DOWN_BAR_TAG; // 0x00
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
		private int _lvFontSize; // 0x44
		[SerializeField]
		private UIAnimationWrapper _barRootAnim; // 0x48
		[SerializeField]
		private CanvasGroup _contentCanvasGroup; // 0x50
		[SerializeField]
		private UIStateController _lvNodeState; // 0x58
		[SerializeField]
		private UIText _lvText; // 0x60
		[SerializeField]
		private UIText _dangerousLvText; // 0x68
		[SerializeField]
		private UIText _extremeDangerousLvText; // 0x70
		[SerializeField]
		private UIAnimationWrapper _extremeDangerousLvAnim; // 0x78
		[SerializeField]
		private CanvasGroup _focusHighlight; // 0x80
		[SerializeField]
		private List<UIImage> _hpFastFillList; // 0x88
		[SerializeField]
		private List<UIImage> _hpSlowFillList; // 0x90
		[SerializeField]
		private Transform _hpNumberNode; // 0x98
		[SerializeField]
		private UIText _curHpText; // 0xA0
		[SerializeField]
		private UIText _maxHpText; // 0xA8
		[SerializeField]
		private RectTransform _hpParentRect; // 0xB0
		[SerializeField]
		private RectTransform _hpEffectRect; // 0xB8
		[SerializeField]
		private CanvasGroup _hpEffectCanvasGroup; // 0xC0
		[SerializeField]
		private GameObject _hpBrokenNode; // 0xC8
		[SerializeField]
		private UIPoiseBar _poiseBar; // 0xD0
		[SerializeField]
		private UIWeaknessNode _weaknessBar; // 0xD8
		[SerializeField]
		private UICountShieldNode _countShieldNode; // 0xE0
		[SerializeField]
		private UIBuffNode _attachedBuffNode; // 0xE8
		[SerializeField]
		private UIBuffNode _normalBuffNode; // 0xF0
		[SerializeField]
		private GameObject _specialCountDownNode; // 0xF8
		[SerializeField]
		private UIImage _specialCountDownFill; // 0x100
		[SerializeField]
		private UIAnimationWrapper _manualLockFrame; // 0x108
		private readonly LuaResourceLoader m_loader; // 0x110
		private ObjectPtr<AbilitySystem> m_target; // 0x118
		private ObjectPtr<AbilitySystem> m_hpTarget; // 0x128
		private ObjectPtr<AbilitySystem> m_poiseTarget; // 0x138
		private bool m_hasPoise; // 0x148
		private HpChangeDisplayData m_currentHpChangeData; // 0x150
		private HpDisplayState m_hpDisplayState; // 0x158
		private readonly PeriodicTimer m_hpStayTimer; // 0x160
		private float? m_targetFillValue; // 0x168
		private float? m_transferToHighlightScaleTime; // 0x170
		private float? m_transferToOriginalScaleTime; // 0x178
		private Vector3 m_beforeTransferScale; // 0x180
		private TweenCallback m_manualLockFrameOutCallback; // 0x190
		private ObjectPtr<Buff> m_countDownBuff; // 0x198
		public const float EFFECT_OFFSET = -0.5f; // Metadata: 0x0263BDAD
	
		// Nested types
		public enum HpDisplayState // TypeDefIndex: 80043
		{
			Normal = 0,
			Stay = 1,
			Decrease = 2
		}
	
		// Constructors
		public UIHeadBar(); // 0x0000000186AAE550-0x0000000186AAE640
		static UIHeadBar(); // 0x0000000184F10290-0x0000000184F10850
	
		// Methods
		private void OnDestroy(); // 0x000000018D261498-0x000000018D2614F0
		public void OnPreWarm(); // 0x00000001860C1910-0x00000001860C1970
		public void SetTarget(AbilitySystem target); // 0x00000001860C53A0-0x00000001860CA220
		public void RefreshShowConfig(); // 0x000000018D2614F0-0x000000018D261530
		private void _RefreshShowConfig(bool playInAnimation); // 0x0000000186510F50-0x0000000186512710
		public void ShowModifierAfterSetTarget([IsReadOnly] in AbilitySystem.Modifier modifier); // 0x0000000185CE14C0-0x0000000185CE15D0
		public void Clear(); // 0x0000000185AB7AF0-0x0000000185ABB430
		public void Refresh(); // 0x0000000186B555D0-0x0000000186B55660
		private void _OnHpChange(Entity entity, double change, bool isMaxHpChanged); // 0x0000000185355EA0-0x0000000185355FA0
		private void _OnForceSetHp(Entity entity); // 0x000000018D2615F0-0x000000018D2617BC
		private void _CalculateHpChangeDisplay(AbilitySystem target, double deltaValue); // 0x0000000185355AB0-0x0000000185355EA0
		private void _UpdateHpDisplay(float deltaTime); // 0x0000000185A9ED90-0x0000000185A9EFF0
		private void _OnPoiseChange(Entity entity, float change, bool hideUIEffect); // 0x0000000185974F90-0x0000000185974FE0
		private void _OnMultiTimeWeaknessActivate(Entity entity, bool active, int count); // 0x000000018D2617BC-0x000000018D261924
		private void _OnWeaknessCountChanged(Entity entity, int total, int count); // 0x000000018D261924-0x000000018D2619F8
		private void _OnCountShieldUiChange(); // 0x000000018D261530-0x000000018D261598
		private void _OnCountShieldUiShake(); // 0x000000018D261598-0x000000018D2615F0
		private void _OnMainTargetChanged([IsReadOnly] in EventData<AbilitySystem, bool> eventData); // 0x0000000186723250-0x0000000186723380
		private void _OnLockHoldAimChanged([IsReadOnly] in EventData<bool, bool, float, AbilitySystem> eventData); // 0x0000000184F0F6E0-0x0000000184F0FEF0
		private void _OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool isApply, Buff.FinishReason finishReason); // 0x0000000184F0EF50-0x0000000184F0F6E0
		private void _InitSpecialCountDownBuff(); // 0x0000000184F0DD00-0x0000000184F0EF50
		private void _UpdateSpecialCountDown(float deltaTime); // 0x0000000184F0FEF0-0x0000000184F10290
		private void _UpdateScale(float deltaTime); // 0x0000000185A9E8A0-0x0000000185A9ECE0
		private void _SetImageFill(List<UIImage> imageList, float fillValue); // 0x0000000185357180-0x0000000185357290
		public void UpdateData(float deltaTime); // 0x0000000185A9F220-0x0000000185A9F600
		public void OnBeforeHpBroken(); // 0x0000000186ABEEA0-0x0000000186ABEF10
		public void OnAfterHpBroken(); // 0x0000000185CE1120-0x0000000185CE1160
		[CompilerGenerated]
		private void _SetTarget_b__54_0(); // 0x0000000184F0DC50-0x0000000184F0DD00
	}

	public class UIHeadBarFollower : UIAbilityTargetFollower // TypeDefIndex: 80045
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
		protected override bool actualVisible { get; } // 0x0000000186339490-0x00000001863394D0 
	
		// Constructors
		public UIHeadBarFollower(); // 0x00000001860C0EE0-0x00000001860C0EF0
	
		// Methods
		public void OnPreWarm(); // 0x0000000185CE0660-0x0000000185CE06A0
		public override void SetTarget(AbilitySystem target); // 0x0000000185FCB8D0-0x0000000185FCB940
		public void ShowModifierAfterSetTarget([IsReadOnly] in AbilitySystem.Modifier modifier); // 0x0000000185CE15D0-0x0000000185CE17B0
		public override void Clear(); // 0x0000000185AB6E20-0x0000000185AB6E80
		public void Refresh(); // 0x000000018D2613E0-0x000000018D261478
		public void RefreshShowConfig(); // 0x000000018D261388-0x000000018D2613E0
		public void SetHeadBarVisible(bool visible); // 0x000000018642E020-0x000000018642E0B0
		protected override void UpdateData(float deltaTime); // 0x0000000185A9ECE0-0x0000000185A9ED40
		private void _UpdateGuideLine(); // 0x0000000185A9ED40-0x0000000185A9ED90
		public override bool TryGetOriginalFollowPos(out Vector3 followPos); // 0x00000001855E2CF0-0x00000001855E2E40
		public void OnBeforeHpBroken(); // 0x0000000186ABEE60-0x0000000186ABEEA0
		public void OnAfterHpBroken(); // 0x0000000185CE10E0-0x0000000185CE1120
		public bool __iFixBaseProxy_get_actualVisible(); // 0x0000000187258EA0-0x0000000187258EB0
		public void __iFixBaseProxy_SetTarget(AbilitySystem P0); // 0x000000018D261480-0x000000018D261488
		public void __iFixBaseProxy_Clear(); // 0x000000018D261478-0x000000018D261480
		public void __iFixBaseProxy_UpdateData(float P0); // 0x000000018D261490-0x000000018D261498
		public bool __iFixBaseProxy_TryGetOriginalFollowPos(out Vector3 P0); // 0x000000018D261488-0x000000018D261490
	}

	public class UIHeadBuff : UIAbilityTargetFollower // TypeDefIndex: 80046
	{
		// Fields
		private const string SEASON_TOWER_STATE = "seasontower"; // Metadata: 0x0263BDB4
		private const string COMMON_STATE = "common"; // Metadata: 0x0263BDC0
		[SerializeField]
		private UIStateController _rootStateController; // 0x110
		[SerializeField]
		private UIStateController _seasonTowerStateController; // 0x118
		[SerializeField]
		private UIAnimationWrapper _anim; // 0x120
		[SerializeField]
		private UIImage _buffIcon; // 0x128
		[SerializeField]
		private UIImage _lifeTimeMask; // 0x130
		private ObjectPtr<Buff> m_buffPtr; // 0x138
	
		// Properties
		public UIAnimationWrapper anim { get; } // 0x000000018D261F24-0x000000018D261F68 
	
		// Constructors
		public UIHeadBuff(); // 0x00000001860C0350-0x00000001860C0360
	
		// Methods
		public void SetSeasonTowerUiState(string iconName); // 0x000000018D261BD4-0x000000018D261C94
		public void SetBuffIcon(ObjectPtr<Buff> buffPtr); // 0x000000018D261AB0-0x000000018D261BD4
		public override void Clear(); // 0x000000018D2619F8-0x000000018D261AB0
		public override bool TryGetOriginalFollowPos(out Vector3 followPos); // 0x000000018D261C94-0x000000018D261D9C
		protected override void UpdateData(float deltaTime); // 0x000000018D261D9C-0x000000018D261DD8
		private void _UpdateLifeTime(); // 0x000000018D261DD8-0x000000018D261F24
		public void __iFixBaseProxy_Clear(); // 0x000000018D261478-0x000000018D261480
		public bool __iFixBaseProxy_TryGetOriginalFollowPos(out Vector3 P0); // 0x000000018D261488-0x000000018D261490
		public void __iFixBaseProxy_UpdateData(float P0); // 0x000000018D261490-0x000000018D261498
	}

	public class UILvInfoBar : UIAbilityTargetFollower // TypeDefIndex: 80047
	{
		// Fields
		public UIAnimationWrapper anim; // 0x110
		[SerializeField]
		private UIStateController _lvNodeState; // 0x118
		[SerializeField]
		private UIText _lvText; // 0x120
		[SerializeField]
		private UIText _dangerousLvText; // 0x128
		[SerializeField]
		private UIText _extremeDangerousLvText; // 0x130
		[SerializeField]
		private UIAnimationWrapper _extremeDangerousLvAnim; // 0x138
	
		// Constructors
		public UILvInfoBar(); // 0x00000001860C0350-0x00000001860C0360
	
		// Methods
		public override void SetTarget(AbilitySystem target); // 0x0000000185FCDC70-0x0000000185FCDDC0
		public override bool TryGetOriginalFollowPos(out Vector3 followPos); // 0x00000001855E2AD0-0x00000001855E2BA0
		public void __iFixBaseProxy_SetTarget(AbilitySystem P0); // 0x000000018D261480-0x000000018D261488
		public bool __iFixBaseProxy_TryGetOriginalFollowPos(out Vector3 P0); // 0x000000018D261488-0x000000018D261490
	}

	public class UIPoiseBar : MonoBehaviour // TypeDefIndex: 80049
	{
		// Fields
		[SerializeField]
		private UIImage _increaseFill; // 0x18
		[SerializeField]
		private RectTransform _increaseHead; // 0x20
		[SerializeField]
		private CanvasGroup _increaseCanvasGroup; // 0x28
		[SerializeField]
		private UIImage _decreaseFill; // 0x30
		[SerializeField]
		private CanvasGroup _decreaseCanvasGroup; // 0x38
		[SerializeField]
		private UIPoiseKnot _poiseKnot; // 0x40
		[SerializeField]
		private UIAnimationWrapper _poiseBreakAnim; // 0x48
		[SerializeField]
		private CanvasGroup _poiseBreakCanvasGroup; // 0x50
		[SerializeField]
		private RectTransform _poiseParentRect; // 0x58
		[SerializeField]
		private RectTransform _poiseEffectRect; // 0x60
		[SerializeField]
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
		public const float EFFECT_OFFSET = -0.5f; // Metadata: 0x0263BDC7
	
		// Properties
		public AbilitySystem owner { get; } // 0x0000000185A9F840-0x0000000185A9F8A0 
		public float maxPoise { get; } // 0x0000000185973960-0x00000001859739A0 
		public float realPoise { get; } // 0x0000000185973E60-0x0000000185973EB0 
		private bool hidePoiseBar { get; } // 0x0000000185973530-0x0000000185973600 
	
		// Nested types
		public enum PoiseDisplayState // TypeDefIndex: 80048
		{
			Normal = 0,
			Stay = 1,
			Increase = 2
		}
	
		// Constructors
		public UIPoiseBar(); // 0x0000000186A51B60-0x0000000186A51C80
	
		// Methods
		public void Init(AbilitySystem owner, bool hidePoiseBarWhenEmpty, bool showPoiseChangeEffect, List<HpChangeDisplayData> poiseChangeConfig); // 0x0000000185973210-0x0000000185973530
		public void Clear(); // 0x0000000185AB7170-0x0000000185AB7210
		public void OnPoiseChange(Entity entity, float change, bool hideUIEffect); // 0x00000001859739A0-0x0000000185973E60
		public void Refresh(); // 0x0000000186B55660-0x0000000186B556A0
		public void UpdatePoiseBar(float deltaTime); // 0x0000000185A9F760-0x0000000185A9F840
		private void _CalculatePoiseChangeDisplay(double deltaValue); // 0x0000000185973600-0x0000000185973960
		private void _UpdatePoiseDisplay(float deltaTime); // 0x0000000185A9EFF0-0x0000000185A9F220
		private void _TryInitPoiseKnot(AbilitySystem owner); // 0x0000000185973EB0-0x0000000185974350
		private void _ClearPoiseKnot(); // 0x0000000185AB6F20-0x0000000185AB7170
		private UIPoiseKnot _CreatePoiseKnot(); // 0x0000000186ECD920-0x0000000186ECDAD0
	}

	public class UITacticalItemBar : UIAbilityTargetFollower // TypeDefIndex: 80050
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
		private const string UI_SPRITE_ITEM = "ItemIcon"; // Metadata: 0x0263BDCE
		private string m_itemId; // 0x130
	
		// Constructors
		public UITacticalItemBar(); // 0x00000001860C0360-0x00000001860C0380
	
		// Methods
		public override void SetTarget(AbilitySystem target); // 0x000000018D2620E0-0x000000018D2622EC
		public override void Clear(); // 0x000000018D261F68-0x000000018D261FF4
		protected override void UpdateData(float deltaTime); // 0x000000018D2622EC-0x000000018D2623A0
		public bool IsTacticalItemActive(); // 0x000000018D261FF4-0x000000018D2620E0
		public void __iFixBaseProxy_SetTarget(AbilitySystem P0); // 0x000000018D261480-0x000000018D261488
		public void __iFixBaseProxy_Clear(); // 0x000000018D261478-0x000000018D261480
		public void __iFixBaseProxy_UpdateData(float P0); // 0x000000018D261490-0x000000018D261498
	}

	public class UIVigilanceBar : UIAbilityTargetFollower // TypeDefIndex: 80051
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
		private bool m_isVigilanceVisible; // 0x132
	
		// Properties
		protected override bool actualVisible { get; } // 0x0000000186419C50-0x0000000186419C90 
		protected override bool needUpdateTransform { get; } // 0x000000018651A880-0x000000018651A8C0 
	
		// Constructors
		public UIVigilanceBar(); // 0x00000001860C0350-0x00000001860C0360
	
		// Methods
		public override void SetTarget(AbilitySystem target); // 0x0000000185FCC120-0x0000000185FCC290
		public override void Clear(); // 0x0000000185AB6D90-0x0000000185AB6DD0
		public void Refresh(); // 0x000000018D2623A0-0x000000018D2624CC
		protected override void UpdateData(float deltaTime); // 0x00000001853CE0F0-0x00000001853CE120
		private void _UpdateVigilanceNode(); // 0x00000001853CE120-0x00000001853CE270
		private void _SetVigilanceActive(bool active); // 0x000000018D2624CC-0x000000018D262568
		public override bool TryGetOriginalFollowPos(out Vector3 followPos); // 0x00000001855E2BA0-0x00000001855E2CF0
		[CompilerGenerated]
		private void __UpdateVigilanceNode_b__15_0(); // 0x0000000187258EC0-0x0000000187258ED0
		[CompilerGenerated]
		private void __UpdateVigilanceNode_b__15_1(); // 0x0000000187258ED0-0x0000000187258EE0
		public bool __iFixBaseProxy_get_actualVisible(); // 0x0000000187258EA0-0x0000000187258EB0
		public bool __iFixBaseProxy_get_needUpdateTransform(); // 0x0000000187258EB0-0x0000000187258EC0
		public void __iFixBaseProxy_SetTarget(AbilitySystem P0); // 0x000000018D261480-0x000000018D261488
		public void __iFixBaseProxy_Clear(); // 0x000000018D261478-0x000000018D261480
		public void __iFixBaseProxy_UpdateData(float P0); // 0x000000018D261490-0x000000018D261498
		public bool __iFixBaseProxy_TryGetOriginalFollowPos(out Vector3 P0); // 0x000000018D261488-0x000000018D261490
	}

	public class UIWeaknessNode : MonoBehaviour // TypeDefIndex: 80052
	{
		// Fields
		public CanvasGroup weaknessCell; // 0x18
		private readonly List<CanvasGroup> m_weaknessCells; // 0x20
	
		// Constructors
		public UIWeaknessNode(); // 0x0000000186BA36C0-0x0000000186BA3750
	
		// Methods
		private void Awake(); // 0x000000018D262568-0x000000018D262610
		public void SetTotalCellNum(int num); // 0x000000018D2626DC-0x000000018D262974
		public void SetCurrentCellNum(int num); // 0x000000018D262610-0x000000018D2626DC
	}

	public class AtbCell : MonoBehaviour // TypeDefIndex: 80053
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
		public AtbCell(); // 0x000000018548CC60-0x000000018548CC80
	}

	public class AtbNode : UIPanelBase // TypeDefIndex: 80055
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
		private readonly List<float> m_atbCellCapacityList; // 0xC0
		private bool m_atbShowing; // 0xC8
		private float m_showingAtbValue; // 0xCC
		private const float ATB_PRESS_THRESHOLD = 0.03f; // Metadata: 0x0263BDD7
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000186FD2DF0-0x0000000186FD2E20 
		private BattleManager battleManager { get; } // 0x000000018D25E51C-0x000000018D25E598 
		private SkillSetting skillSetting { get; } // 0x0000000185C45590-0x0000000185C45600 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0 // TypeDefIndex: 80054
		{
			// Fields
			public AtbCell cell; // 0x10
	
			// Constructors
			public __c__DisplayClass29_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _OnGainAtb_b__0(); // 0x000000018722E750-0x000000018722E770
		}
	
		// Constructors
		public AtbNode(); // 0x0000000186F88180-0x0000000186F88260
	
		// Methods
		public void OnCreate(); // 0x0000000185C43790-0x0000000185C43A70
		private void _RefreshAtbMax(); // 0x0000000185C43A70-0x0000000185C44B20
		private void _AddAtbCellLayout(float capacity, float flexibleWidth, PooledList<float> atbCellWidthList); // 0x0000000185C44B80-0x0000000185C44C40
		private void _RefreshAtbCellFill(float atbValue); // 0x0000000185C45600-0x0000000185C45770
		private float _GetAtbCellFillAmount(int cellIndex, float atbValue); // 0x0000000185812D40-0x0000000185812E90
		public void OnClose(); // 0x000000018D25E2C0-0x000000018D25E4B0
		public override void LateTick(float deltaTime); // 0x00000001858126B0-0x0000000185812D40
		public void CheckAtbLoopAnim(); // 0x0000000185813090-0x00000001858131F0
		private void _RefreshAtbShowing(); // 0x0000000185812E90-0x0000000185813090
		private void _OnAtbCellOutAnimCallback(); // 0x00000001871DD9D0-0x00000001871DDA70
		public void OnInFightChanged([IsReadOnly] in EventData<bool> eventData); // 0x0000000186818F10-0x0000000186818F40
		public void OnGainAtb([IsReadOnly] in EventData<float> eventData); // 0x0000000186BA5230-0x0000000186BA5690
		private void _OnAtbMaxChanged(); // 0x000000018D25E4B0-0x000000018D25E51C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D2519E8-0x000000018D2519F0
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public class ComboSkillHint : MonoBehaviour // TypeDefIndex: 80056
	{
		// Fields
		public const string SPECIAL_NODE_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Prefabs/Battle/Widgets/ComboSkillSpecialNode/"; // Metadata: 0x0263BDDB
		public CanvasGroup content; // 0x18
		public UIButton button; // 0x20
		public UIImage fill; // 0x28
		public UIImage icon; // 0x30
		public UIImage charHead; // 0x38
		public GameObject maskNode; // 0x40
		public UIImage mask2Img; // 0x48
		public UIAnimationWrapper anim; // 0x50
		public UIStateController animationStateController; // 0x58
		[NonSerialized]
		public ComboSpecialNodeBase specialNode; // 0x60
		[NonSerialized]
		public bool needTick; // 0x68
		[NonSerialized]
		public int charIndex; // 0x6C
		private ComboSkillPanel m_owner; // 0x70
		private Beyond.Gameplay.Core.SkillData m_cachedSkillData; // 0x78
		private string m_lastSpecialNodeName; // 0x80
	
		// Constructors
		public ComboSkillHint(); // 0x0000000186EBF270-0x0000000186EBF2D0
	
		// Methods
		public void Init(ComboSkillPanel owner, int charIndex, bool isDefaultPanel); // 0x0000000185EA3520-0x0000000185EA36A0
		public void OnReady(); // 0x0000000186154080-0x0000000186154150
		public void OnCast(); // 0x00000001854BA8E0-0x00000001854BA920
		public void OnTick(float deltaTime); // 0x000000018D25E598-0x000000018D25E5F4
		public void OnRemove(); // 0x00000001854BA8A0-0x00000001854BA8E0
		public void Release(); // 0x000000018D25E5F4-0x000000018D25E62C
		public void AssignData(AbilitySystem abilityCom); // 0x0000000186C40110-0x0000000186C41670
		public void SetRewardMode(bool isInRewardComboState); // 0x0000000184F09260-0x0000000184F09880
		public void AssignLockData(); // 0x0000000184F08EA0-0x0000000184F09260
		private void _ReleaseAllSpecialNodes(); // 0x0000000184F09880-0x0000000184F09F50
		private void _ReleaseSpecialNode(); // 0x000000018D25E688-0x000000018D25E784
		public void SetVisible(bool visible); // 0x000000018D25E62C-0x000000018D25E688
	}

	public class ComboSkillPanel : UIPanelBase // TypeDefIndex: 80060
	{
		// Fields
		public const string UI_SPRITE_ROUND_CHAR_HEAD = "CharRoundIcon"; // Metadata: 0x0263BE32
		public UIButton buttonCast; // 0x70
		public RectTransform infoNode; // 0x78
		public ComboSkillHint[] comboSkillHints; // 0x80
		public UICustomLayoutElement customLayoutElement; // 0x88
		public UIStateController infoNodeStateController; // 0x90
		public UIStateController buttonCastStateController; // 0x98
		public float comboHintDisableAlpha; // 0xA0
		public float comboHintFirstScale; // 0xA4
		private readonly List<int> m_comboSkillKeyList; // 0xA8
		private readonly Dictionary<int, ComboSkillHint> m_extraHints; // 0xB0
		private UnityAction m_onLayoutDataLoaded; // 0xB8
		private bool m_isDefaultPanel; // 0xC0
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000186FD2D60-0x0000000186FD2D90 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0 // TypeDefIndex: 80057
		{
			// Fields
			public ComboSkillHint hint; // 0x10
			public ComboSkillPanel __4__this; // 0x18
			public int comboSkillKey; // 0x20
	
			// Constructors
			public __c__DisplayClass26_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __RemoveComboSkill_b__0(); // 0x0000000184F0B370-0x0000000184F0C120
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0 // TypeDefIndex: 80058
		{
			// Fields
			public int comboSkillKey; // 0x10
			public ComboSkillHint hint; // 0x18
			public ComboSkillPanel __4__this; // 0x20
	
			// Constructors
			public __c__DisplayClass27_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __OnComboSkillClearAll_b__0(); // 0x0000000184F0C120-0x0000000184F0CEA0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0 // TypeDefIndex: 80059
		{
			// Fields
			public ComboSkillPanel __4__this; // 0x10
			public int comboSkillKey; // 0x18
			public ComboSkillHint hint; // 0x20
	
			// Constructors
			public __c__DisplayClass28_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _CastComboSkill_b__0(); // 0x0000000184F0CEA0-0x0000000184F0DC50
		}
	
		// Constructors
		public ComboSkillPanel(); // 0x0000000186EE2890-0x0000000186EE2980
	
		// Methods
		public void OnCreate(bool isDefaultPanel, bool isControllerPanel); // 0x0000000185EA30A0-0x0000000185EA3520
		public void OnShow(); // 0x0000000186154A90-0x0000000186154AD0
		protected override void OnRelease(); // 0x000000018D25E784-0x000000018D25E898
		private void _UnbindListeners(); // 0x0000000185EA37D0-0x0000000185EA3B60
		public override void PreTick(float deltaTime); // 0x0000000186154E90-0x0000000186155270
		private void _CheckUpdate(); // 0x0000000186151C70-0x0000000186152270
		private void _UpdateButtonCastState(); // 0x0000000184F0A530-0x0000000184F0B370
		private void _OnBattleTeamChanged(); // 0x0000000186154AD0-0x0000000186154C90
		private void _OnActiveSkillDataRefreshed([IsReadOnly] in EventData<ulong, string> eventData); // 0x000000018D25EBDC-0x000000018D25ED60
		private void _OnComboSkillReady([IsReadOnly] in EventData<int> eventData); // 0x0000000186152980-0x0000000186154080
		private void _OnComboSkillRemove([IsReadOnly] in EventData<int> eventData); // 0x00000001854BA870-0x00000001854BA8A0
		private void _RemoveComboSkill(int comboSkillKey); // 0x00000001854BA920-0x00000001854BAAC0
		private void _OnComboSkillClearAll(); // 0x0000000186CB12B0-0x0000000186CB1840
		public void CastComboSkill(PointerEventData eventData = null); // 0x00000001854BAAC0-0x00000001854BADB0
		private ComboSkillHint _GetHint(int comboSkillKey); // 0x0000000186155270-0x0000000186155310
		private void _AssignHintData(int comboSkillKey); // 0x0000000186154150-0x0000000186154A90
		private void _ResortSiblingIndex(); // 0x0000000186154C90-0x0000000186154E90
		private ComboSkillHint _EnsureExtraHint(int comboSkillKey); // 0x000000018D25E9B8-0x000000018D25EBDC
		private void _DestroyLockHint(int comboSkillKey); // 0x00000001871F5D30-0x00000001871F5D60
		private void _DestroyExtraHint(int comboSkillKey); // 0x000000018D25E8A0-0x000000018D25E9B8
		private void _ClearExtraHints(); // 0x0000000185EA2C10-0x0000000185EA2DF0
		[CompilerGenerated]
		private void _OnCreate_b__15_0(); // 0x0000000184F09F50-0x0000000184F0A530
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D2519E8-0x000000018D2519F0
		public void __iFixBaseProxy_OnRelease(); // 0x000000018D25E898-0x000000018D25E8A0
		public void __iFixBaseProxy_PreTick(float P0); // 0x00000001891F0AFC-0x00000001891F0B04
	}

	public class GPUIAttachedBuffCell : GPUIBuffCell // TypeDefIndex: 80061
	{
		// Fields
		[SerializeField]
		private string _buffIconPhantomNodeName; // 0xC0
		[SerializeField]
		private string _buffStackRingNodeName; // 0xC8
		[SerializeField]
		private string _buffStackRingSubRootNodeName; // 0xD0
		[SerializeField]
		private List<string> _buffStackRingConsumeSubroots; // 0xD8
		[SerializeField]
		private string _buffStackRingConsumeAnimationName; // 0xE0
		[SerializeField]
		private float _stackRingFillChangeSpeed; // 0xE8
		[SerializeField]
		private float _igniteFillDelay; // 0xEC
		[SerializeField]
		private float _buffStackRingInitRotZ; // 0xF0
		private const string BUFF_ANIM_IGNITE = "headbar_buff_cell_ignite"; // Metadata: 0x0263BE40
		private int m_maxStackCount; // 0xF4
		private float m_currentStackRingFillAmount; // 0xF8
		private float? m_targetStackRingFillAmount; // 0xFC
		private PeriodicTimer m_igniteFillDelayTimer; // 0x108
		private bool m_isInConsumeAnim; // 0x110
		private float m_consumeAnimEndTime; // 0x114
	
		// Properties
		protected override string defaultBuffIconNodeName { get; } // 0x000000018D25F754-0x000000018D25F7C4 
	
		// Constructors
		public GPUIAttachedBuffCell(); // 0x0000000186556D50-0x0000000186556EE0
	
		// Methods
		protected override void DataInit(ObjectPtr<Buff> buffPtr); // 0x000000018D25EE24-0x000000018D25EF3C
		public override void OnTick(float deltaTime); // 0x000000018D25F000-0x000000018D25F1E8
		public override void BeforePlayOutAnim(); // 0x000000018D25ED60-0x000000018D25EDC0
		public override void SetStackCount(int stackCount, bool playAnim); // 0x000000018D25F27C-0x000000018D25F474
		public override void OnBuffIgnite(); // 0x000000018D25EF3C-0x000000018D25F000
		protected override bool SetBuffIcon(Sprite sprite); // 0x000000018D25F1E8-0x000000018D25F27C
		protected override void ClearBuffIconOverride(); // 0x000000018D25EDC0-0x000000018D25EE24
		protected override void SetStackElementActive(bool showStackCount); // 0x000000018D25F474-0x000000018D25F4FC
		private void _PlayConsumeAnimations(int stackCount); // 0x000000018D25F55C-0x000000018D25F754
		public string __iFixBaseProxy_get_defaultBuffIconNodeName(); // 0x000000018D25F554-0x000000018D25F55C
		public void __iFixBaseProxy_DataInit(ObjectPtr<Buff> P0); // 0x000000018D25F50C-0x000000018D25F52C
		public void __iFixBaseProxy_OnTick(float P0); // 0x000000018D25F534-0x000000018D25F53C
		public void __iFixBaseProxy_BeforePlayOutAnim(); // 0x000000018D25F4FC-0x000000018D25F504
		public void __iFixBaseProxy_SetStackCount(int P0, bool P1); // 0x000000018D25F544-0x000000018D25F54C
		public void __iFixBaseProxy_OnBuffIgnite(); // 0x000000018D25F52C-0x000000018D25F534
		public bool __iFixBaseProxy_SetBuffIcon(Sprite P0); // 0x000000018D25F53C-0x000000018D25F544
		public void __iFixBaseProxy_ClearBuffIconOverride(); // 0x000000018D25F504-0x000000018D25F50C
		public void __iFixBaseProxy_SetStackElementActive(bool P0); // 0x000000018D25F54C-0x000000018D25F554
	}

	public class GPUIBuffCell : MonoBehaviour // TypeDefIndex: 80063
	{
		// Fields
		private const string BUFF_ICON_SET_FAILED_MESSAGE = "BuffIcon\u8BBE\u7F6E\u56FE\u6807\u5931\u8D25\uFF0C\u9700\u8981\u8054\u7CFB\u7A0B\u5E8F\u6269\u5145\u9884\u7559\u5927\u5C0F"; // Metadata: 0x0263BE5A
		[SerializeField]
		private GPUIPrefabProxyBase _gpuiProxy; // 0x18
		[SerializeField]
		private string _buffIconNodeName; // 0x20
		[SerializeField]
		private bool _canShowStackCountText; // 0x28
		[SerializeField]
		private List<string> _stackNodeNames; // 0x30
		[SerializeField]
		private string _stackCountTextNodeName; // 0x38
		[SerializeField]
		private bool _canShowWarningBg; // 0x40
		[SerializeField]
		private List<string> _warningBgNodeNames; // 0x48
		[SerializeField]
		private string _animationInName; // 0x50
		[SerializeField]
		private string _animationOutName; // 0x58
		[SerializeField]
		private string _strongInAnimationName; // 0x60
		[SerializeField]
		private string _igniteOutAnimationName; // 0x68
		[SerializeField]
		private Vector2 _visibleRootScale; // 0x70
		[SerializeField]
		private Vector2 _hiddenRootScale; // 0x78
		protected ObjectPtr<Buff> m_buffPtr; // 0x80
		private Sprite m_currentSprite; // 0x90
		private Action m_animationCompleteCallback; // 0x98
		private float m_animationCompleteTime; // 0xA0
		private bool m_animationCompletePending; // 0xA4
		private bool m_isCleared; // 0xA5
		private bool m_isVisualInited; // 0xA6
		private bool m_isBuffIconOverrideActive; // 0xA7
		private bool m_shouldBuffIconOverrideActive; // 0xA8
		private bool m_visible; // 0xA9
		[CompilerGenerated]
		private ulong _nextInstanceId_k__BackingField; // 0xB0
		[CompilerGenerated]
		private string _curSpritePath_k__BackingField; // 0xB8
	
		// Properties
		protected virtual string defaultBuffIconNodeName { get; } // 0x0000000186B74810-0x0000000186B74840 
		public bool isVisualInited { get; } // 0x000000018D25FB60-0x000000018D25FBA4 
		protected bool canUpdateVisual { get; } // 0x000000018535A9A0-0x000000018535A9F0 
		public ulong nextInstanceId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232F90-0x0000000187232FA0 0x00000001865C0760-0x00000001865C0770
		public string curSpritePath { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232C80-0x0000000187232C90 0x0000000188D80C28-0x0000000188D80C3C
		public BuffData buffData { get; } // 0x0000000185C05CE0-0x0000000185C05D20 
		public int orderPriority { get; } // 0x0000000185C05C90-0x0000000185C05CE0 
		public ulong buffInstanceUid { get; } // 0x0000000186B0EB20-0x0000000186B0EB70 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0 // TypeDefIndex: 80062
		{
			// Fields
			public ulong cachedLoadKey; // 0x10
			public GPUIBuffCell __4__this; // 0x18
			public string inputSpritePath; // 0x20
			public Action onSpriteLoaded; // 0x28
	
			// Constructors
			public __c__DisplayClass45_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Init_b__0(Sprite sprite); // 0x00000001868678D0-0x0000000186867960
		}
	
		// Constructors
		public GPUIBuffCell(); // 0x0000000186556F60-0x0000000186557100
	
		// Methods
		public void SetSyncManager(GPUIProxySyncManager syncManager); // 0x0000000185C066C0-0x0000000185C06720
		public void Init(ObjectPtr<Buff> buffPtr, LuaResourceLoader loader, Action onSpriteLoaded = null); // 0x0000000185C07370-0x0000000185C075D0
		public void Clear(); // 0x0000000185C06FE0-0x0000000185C07080
		public virtual void BeforePlayOutAnim(); // 0x000000018D25F7C4-0x000000018D25F7F8
		public virtual void OnTick(float deltaTime); // 0x000000018535A9F0-0x000000018535AA80
		public virtual void SetVisible(bool visible); // 0x0000000185C05E30-0x0000000185C05E80
		public virtual void SetBuffIconOverrideActive(bool active); // 0x0000000185C05FF0-0x0000000185C06080
		public virtual void SetStackCount(int stackCount, bool playAnim); // 0x0000000185FCE850-0x0000000185FCE8D0
		public virtual void OnBuffIgnite(); // 0x000000018D25F874-0x000000018D25F8A8
		public void ClearAnimation(bool executeOnComplete = false /* Metadata: 0x0263BE59 */); // 0x0000000185C070E0-0x0000000185C07140
		public void PlayInAnimation(Action callback = null); // 0x0000000185CDC4F0-0x0000000185CDC530
		public void PlayOutAnimation(Action callback = null); // 0x00000001860C0DE0-0x00000001860C0E20
		public void PlayStrongInAnimation(Action callback = null); // 0x000000018D25F8EC-0x000000018D25F930
		public void PlayIgniteOutAnimation(Action callback = null); // 0x000000018D25F8A8-0x000000018D25F8EC
		public void SampleToInAnimationEnd(); // 0x0000000185CDC9E0-0x0000000185CDCA40
		public void PlayWithAnimation(string animationName, Action callback = null); // 0x0000000185CDC530-0x0000000185CDC610
		protected virtual void DataInit(ObjectPtr<Buff> buffPtr); // 0x0000000186BFB9A0-0x0000000186BFB9D0
		protected virtual void VisualInit(Sprite sprite); // 0x0000000185C05450-0x0000000185C05570
		protected virtual bool SetBuffIcon(Sprite sprite); // 0x000000018612A8B0-0x000000018612A930
		protected virtual void ClearBuffIconOverride(); // 0x000000018D25F7F8-0x000000018D25F874
		private void _LogSetBuffIconFailure(Sprite sprite); // 0x000000018D25FB28-0x000000018D25FB60
		protected virtual void SetStackElementActive(bool isActive); // 0x0000000185AD5A10-0x0000000185AD5A50
		protected virtual void SetWarningState(bool isWarning); // 0x0000000185AD5A50-0x0000000185AD5A90
		protected bool TrySetSprite(string nodeName, Sprite sprite); // 0x000000018612A970-0x000000018612AA10
		protected bool TrySetText(string nodeName, string text); // 0x0000000185FCE9E0-0x0000000185FCEA80
		protected bool TrySetColor(string nodeName, UnityEngine.Color color); // 0x0000000185AD5CB0-0x0000000185AD5D50
		protected bool TrySetNodeRotZ(string subRoot, float rotz); // 0x000000018D25F930-0x000000018D25FA14
		[IDTag(0)]
		protected bool TrySetNodeVisibility(string nodeName, bool visible); // 0x0000000185AD5B10-0x0000000185AD5BB0
		[IDTag(1)]
		protected void TrySetNodeVisibility(List<string> nodeNames, bool visible); // 0x0000000185AD5A90-0x0000000185AD5B10
		protected bool TrySetImageFillAmount(string nodeName, float fillAmount); // 0x000000018535AF50-0x000000018535B1C0
		protected bool TryStartRootAnimation(string animationName, out float duration); // 0x0000000185CDC610-0x0000000185CDC6D0
		protected bool TryStartSubrootAnimation(string subrootName, string animationName, out float duration); // 0x000000018D25FA14-0x000000018D25FB28
		protected bool TryEnsureGPUIInstance(); // 0x000000018535B590-0x000000018535B7C0
		private bool _TryCreateGPUIInstance(); // 0x0000000185CE0170-0x0000000185CE01F0
		private bool _TryDestroyGpuiInstance(); // 0x0000000185C07080-0x0000000185C070E0
		private bool _TryResolveGpui(out GPUIExtendedSystem targetSystem, out GPUIHandle handle); // 0x000000018535B3B0-0x000000018535B590
		private bool _TryResolveGPUIProxy(); // 0x000000018535B7C0-0x000000018535B860
		private bool _TrySetRootScale(Vector2 scale); // 0x0000000185C05E80-0x0000000185C05EF0
		private void _UpdateAnimationComplete(); // 0x000000018535AA80-0x000000018535AB00
		private string _ResolveNodeName(string configuredNodeName, string defaultNodeName); // 0x000000018612A930-0x000000018612A970
	}

	public class GPUIBuffNode : TickableUIMono // TypeDefIndex: 80072
	{
		// Fields
		[SerializeField]
		private SerializeFieldDictionary<BuffIconConfig.BuffIconStyle, GPUIBuffCell> _buffStyleCellTemplateDict; // 0x68
		[SerializeField]
		private BuffNodeType _buffNodeType; // 0x70
		[SerializeField]
		private int _maxBuffCellCount; // 0x74
		private bool m_isFirstInited; // 0x78
		private bool m_missingGPUIProxySyncManagerLogged; // 0x79
		private GPUIProxySyncManager m_gpuiProxySyncManager; // 0x80
		private readonly LuaResourceLoader m_loader; // 0x88
		private ObjectPtr<AbilitySystem> m_owner; // 0x90
		private readonly DynamicFastLookupCollection<BuffIconConfig.BuffIconStyle, BuffCellGroup> m_buffCellGroupDict; // 0xA0
		private readonly DynamicFastLookupCollection<string, List<ObjectPtr<Buff>>> m_stackBuffsDict; // 0xA8
		private readonly List<GPUIBuffCell> m_orderedBuffCellList; // 0xB0
		private readonly HashSet<ObjectPtr<Buff>> m_addBuffIconBuffer; // 0xB8
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000186B28600-0x0000000186B28630 
	
		// Nested types
		public enum BuffNodeType // TypeDefIndex: 80064
		{
			HeadBarCommon = 0,
			HeadBarAttached = 1,
			SquadIconCommon = 2,
			MainCharHpBarCommon = 3
		}
	
		public class BuffCellGroup // TypeDefIndex: 80065
		{
			// Fields
			public BuffIconConfig.BuffIconStyle buffIconStyle; // 0x10
			public GPUIBuffCell buffCellTemplate; // 0x18
			public List<GPUIBuffCell> buffCellPool; // 0x20
			public DynamicFastLookupCollection<ulong, GPUIBuffCell> buffCellDict; // 0x28
			public DynamicFastLookupCollection<ulong, GPUIBuffCell> buffCellWithOutAnim; // 0x30
	
			// Constructors
			public BuffCellGroup(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public GPUIBuffCell CreateBuffCell(Transform transform, GPUIProxySyncManager syncManager); // 0x0000000185C059D0-0x0000000185C05A80
			public void RemoveBuffCell(GPUIBuffCell buffCell); // 0x00000001860C1020-0x00000001860C10A0
			public void ClearAllBuffCells(); // 0x0000000185C08710-0x0000000185C087F0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0 // TypeDefIndex: 80066
		{
			// Fields
			public GPUIBuffNode __4__this; // 0x10
			public GPUIBuffCell buffCell; // 0x18
			public BuffData buffData; // 0x20
			public bool playAnim; // 0x28
			public ObjectPtr<Buff> buffPtr; // 0x30
	
			// Constructors
			public __c__DisplayClass27_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __AddBuffIconInternal_b__0(); // 0x0000000185CDC2F0-0x0000000185CDC390
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0 // TypeDefIndex: 80067
		{
			// Fields
			public GPUIBuffNode __4__this; // 0x10
			public BuffData buffData; // 0x18
			public List<ObjectPtr<Buff>> stackBuffList; // 0x20
			public bool playAnim; // 0x28
	
			// Constructors
			public __c__DisplayClass28_0(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_1 // TypeDefIndex: 80068
		{
			// Fields
			public GPUIBuffCell newBuffCell; // 0x10
			public __c__DisplayClass28_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass28_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __AddStackBuffIconInternal_b__0(); // 0x000000018D260D14-0x000000018D260DC0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_2 // TypeDefIndex: 80069
		{
			// Fields
			public GPUIBuffCell buffCell; // 0x10
			public __c__DisplayClass28_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass28_2(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __AddStackBuffIconInternal_b__1(); // 0x0000000185CDBE80-0x0000000185CDBF30
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 80070
		{
			// Fields
			public List<ObjectPtr<Buff>> stackBuffList; // 0x10
			public ObjectPtr<Buff> buffPtr; // 0x18
	
			// Constructors
			public __c__DisplayClass31_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __RemoveStackBuffIconInternal_b__0(); // 0x00000001860C0480-0x00000001860C04E0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0 // TypeDefIndex: 80071
		{
			// Fields
			public Action extraRecycleAction; // 0x10
			public BuffCellGroup buffCellGroup; // 0x18
			public ulong buffUid; // 0x20
			public GPUIBuffCell buffCell; // 0x28
			public GPUIBuffNode __4__this; // 0x30
	
			// Constructors
			public __c__DisplayClass32_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __RemoveSingleBuffCell_b__0(); // 0x00000001860C0E20-0x00000001860C0EE0
			internal void __RemoveSingleBuffCell_b__1(); // 0x000000018D260DC0-0x000000018D260E78
		}
	
		// Constructors
		public GPUIBuffNode(); // 0x0000000186B55290-0x0000000186B55510
	
		// Methods
		private void _OnFirstInit(); // 0x00000001860C4D70-0x00000001860C53A0
		public void OnPreWarm(GPUIProxySyncManager syncManager); // 0x0000000185C06290-0x0000000185C066C0
		public void Init(ObjectPtr<AbilitySystem> abilitySystemPtr); // 0x00000001860C3000-0x00000001860C30F0
		public void Refresh(); // 0x0000000185C08050-0x0000000185C086D0
		public void Clear(); // 0x0000000185FDA7D0-0x0000000185FDA9E0
		public override void TailLateTick(float deltaTime); // 0x00000001851D8050-0x00000001851D8610
		protected override void OnRelease(); // 0x000000018D25FBA4-0x000000018D25FC74
		public void OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason); // 0x00000001860C1360-0x00000001860C1400
		private bool _IsBuffIconInThisNode(ObjectPtr<Buff> buffPtr); // 0x00000001860C1400-0x00000001860C14C0
		private void _OnAddBuff(ObjectPtr<Buff> buffPtr); // 0x00000001860C14C0-0x00000001860C1520
		private void _OnRemoveBuff(ObjectPtr<Buff> buffPtr, Buff.FinishReason finishReason); // 0x00000001860C1520-0x00000001860C15B0
		private void _AddBuffIconInternal(ObjectPtr<Buff> buffPtr, bool playAnim); // 0x0000000185C055C0-0x0000000185C05870
		private void _AddStackBuffIconInternal(ObjectPtr<Buff> buffPtr, bool playAnim, BuffData buffData, BuffCellGroup buffCellGroup); // 0x00000001860C04E0-0x00000001860C07D0
		private static void _RemoveInvalidStackBuffPtrs(List<ObjectPtr<Buff>> stackBuffList); // 0x00000001860C0380-0x00000001860C0480
		private void _RemoveBuffIconInternal(ObjectPtr<Buff> buffPtr, Buff.FinishReason finishReason); // 0x00000001860C15B0-0x00000001860C1750
		private void _RemoveStackBuffIconInternal(ObjectPtr<Buff> buffPtr, Buff.FinishReason finishReason, BuffData buffData, BuffCellGroup buffCellGroup); // 0x00000001860C07D0-0x00000001860C0A40
		private void _RemoveSingleBuffCell(ulong buffUid, GPUIBuffCell buffCell, Buff.FinishReason finishReason, BuffCellGroup buffCellGroup, Action extraRecycleAction); // 0x00000001860C1750-0x00000001860C1910
		private void _OnBuffEnhanceChanged(ObjectPtr<Buff> buffPtr); // 0x0000000186B768E0-0x0000000186B76A30
		private void _OnBuffIgnite(ObjectPtr<Buff> buffPtr); // 0x000000018D25FC74-0x000000018D25FDCC
		private void _RegisterAbilityBuffEvent(AbilitySystem abilitySystem); // 0x00000001860C35F0-0x00000001860C37C0
		private void _UnregisterAbilityBuffEvent(AbilitySystem abilitySystem); // 0x00000001860C3490-0x00000001860C35F0
		private BuffIconConfig.BuffIconStyle _GetIconStyle(Buff buff); // 0x0000000185C05870-0x0000000185C05980
		private void _SetBuffCellSiblingInOrder(GPUIBuffCell buffCell); // 0x0000000185C05A80-0x0000000185C05C90
		private void _DealWithBuffCellVisible(); // 0x0000000185C05D50-0x0000000185C05E30
		private void _PlayInAnimation(GPUIBuffCell buffCell, BuffData buffData, bool playAnim); // 0x0000000185CDC390-0x0000000185CDC450
		private bool _IsBuffCellVisibleByLimit(GPUIBuffCell buffCell); // 0x0000000185CDC450-0x0000000185CDC4F0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_TailLateTick(float P0); // 0x0000000184167520-0x0000000184167530
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
	}

	public class GPUILifeTimeBuffCell : GPUIBuffCell // TypeDefIndex: 80073
	{
		// Fields
		[SerializeField]
		private string _buffLifeTimeBarNodeName; // 0xC0
		[SerializeField]
		private UnityEngine.Color _normalLifeTimeBarColor; // 0xC8
		[SerializeField]
		private UnityEngine.Color _warningLifeTimeBarColor; // 0xD8
	
		// Constructors
		public GPUILifeTimeBuffCell(); // 0x0000000186556EE0-0x0000000186556F60
	
		// Methods
		protected override void VisualInit(Sprite sprite); // 0x0000000186AB4F70-0x0000000186AB4FB0
		public override void OnTick(float deltaTime); // 0x000000018535A8A0-0x000000018535A9A0
		protected override void SetWarningState(bool isWarning); // 0x0000000185AD59A0-0x0000000185AD5A10
		private void _UpdateFillAmount(); // 0x000000018535BB40-0x000000018535BF50
		public void __iFixBaseProxy_VisualInit(Sprite P0); // 0x000000018D25FDD4-0x000000018D25FDDC
		public void __iFixBaseProxy_OnTick(float P0); // 0x000000018D25F534-0x000000018D25F53C
		public void __iFixBaseProxy_SetWarningState(bool P0); // 0x000000018D25FDCC-0x000000018D25FDD4
	}

	public class HpBarComboNode : MonoBehaviour // TypeDefIndex: 80074
	{
		// Fields
		public GameObject comboCountLayout; // 0x18
		public UIText comboCountText; // 0x20
		private UIAnimationWrapper m_animationWrapper; // 0x28
		private int m_lastCount; // 0x30
		private const string COMMON_COMBO_GLOBAL_BUFF_ID = "global_buff_combo_trigger"; // Metadata: 0x0263BEA2
	
		// Constructors
		public HpBarComboNode(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void Awake(); // 0x00000001869EAE50-0x00000001869EB020
		private void OnDestroy(); // 0x000000018D25FDDC-0x000000018D25FF60
		private void _OnGlobalBuffStart([IsReadOnly] in EventData<GlobalBuff, string> eventData); // 0x0000000186FB9300-0x0000000186FB9380
		private void _OnGlobalBuffFinish([IsReadOnly] in EventData<GlobalBuff, string, GlobalBuff.FinishReason> eventData); // 0x000000018D260020-0x000000018D2600C0
		private void _RefreshComboCount(bool isEarly = false /* Metadata: 0x0263BEA1 */); // 0x00000001869EB450-0x00000001869EB550
		private void _AnimInCallback(); // 0x000000018D25FF60-0x000000018D25FFC0
		private void _AnimOutCallback(); // 0x000000018D25FFC0-0x000000018D260020
	}

	public class MainCharHpBar : TickableUIMono // TypeDefIndex: 80076
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
		public GPUIBuffNode gpuiBuffNode; // 0xD8
		public UISpellInflictionOnCharNode spellInflictionOnCharNode; // 0xE0
		public UIImage buffIcon; // 0xE8
		public Transform leftLayout; // 0xF0
		public Transform charPassiveNode; // 0xF8
		public GameObject ultimateProgress; // 0x100
		public UIImage ultimateProgressFill; // 0x108
		public float ultimateProgressFillSmoothTime; // 0x110
		public UnityEngine.Color colorDefault; // 0x114
		public UnityEngine.Color colorRed; // 0x124
		public UnityEngine.Color colorYellow; // 0x134
		public UnityEngine.Color colorBlue; // 0x144
		public UnityEngine.Color colorGreen; // 0x154
		[SerializeField]
		private bool _useGPUIBuff; // 0x164
		private const string HP_BLINK_ANIM = "characterfootbar_warninginternal"; // Metadata: 0x0263BEBC
		private bool m_nodeShowing; // 0x165
		private Entity m_mainChar; // 0x168
		private HpChangeDisplayData m_hpChangeConfig; // 0x170
		private UIHeadBar.HpDisplayState m_hpDisplayState; // 0x178
		private float? m_targetHpValue; // 0x17C
		private readonly PeriodicTimer m_hpStayTimer; // 0x188
		private bool m_hpBarShowing; // 0x190
		private bool m_hpBarShaking; // 0x191
		private UIAnimationWrapper m_hpVfxAnimWrapper; // 0x198
		private UIHudFadeController m_hudFadeController; // 0x1A0
		private static readonly HashSet<string> s_tempCurPassiveUIPrefabNames; // 0x00
		private static readonly List<string> s_tempUnusedPassiveUIPrefabNames; // 0x08
		private readonly Dictionary<string, UICharPassiveBase> m_allPassiveBases; // 0x1A8
		private UICharPassiveBase m_curPassiveBase; // 0x1B0
		private UIAnimationWrapper m_buffIconAnimWrapper; // 0x1B8
		private UIAnimationWrapper m_shakeAnimWrapper; // 0x1C0
		private UIAnimationWrapper m_hpWhiteAnimWrapper; // 0x1C8
		private UIAnimationWrapper m_ultimateBuffProgressAnimWrapper; // 0x1D0
		private UnSafeString.UnSafeStringHandle m_hpTextHandle; // 0x1D8
		private readonly LuaResourceLoader m_loader; // 0x1E0
		private float m_lastHpScreenEffectTime; // 0x1E8
		private bool m_ultimateProgressShowing; // 0x1EC
		private ObjectPtr<Buff> m_ultimateBuffPtr; // 0x1F0
		private float m_ultimateBuffProgressShowingFillAmount; // 0x200
		private float m_ultimateBuffProgressSmoothVelocity; // 0x204
		private readonly List<ObjectPtr<AbilitySystem>> m_ultimateBuffProgressRegisteredCharacters; // 0x208
		private readonly List<ObjectPtr<Buff>> m_activeUltimateBuffs; // 0x210
		private readonly List<ObjectPtr<Buff>> m_activeCharHpBarVfxBuffs; // 0x218
		private ObjectPtr<Buff> m_charHpBarVfxBuffPtr; // 0x220
		private GPUIProxySyncManager m_gpuiProxySyncManager; // 0x230
		private bool m_gpuiBuffNodePreWarmed; // 0x238
		private bool m_normalBuffNodePreWarmed; // 0x239
		private bool m_buffModeInitialized; // 0x23A
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000186FD2A60-0x0000000186FD2A90 
	
		// Nested types
		[Serializable]
		public struct HpScreenEffectConfig // TypeDefIndex: 80075
		{
			// Fields
			public float minHpPercent; // 0x00
			public float maxHpPercent; // 0x04
			public string effectName; // 0x08
		}
	
		// Constructors
		public MainCharHpBar(); // 0x000000018657B8D0-0x000000018657BB20
		static MainCharHpBar(); // 0x0000000187082CC0-0x0000000187082DB0
	
		// Methods
		protected override void OnAwake(); // 0x0000000186C98940-0x0000000186C98D40
		public void SetGPUIBuffSync(GPUIProxySyncManager gpuiProxySyncManager); // 0x0000000187224480-0x00000001872244C0
		public void SetGPUIBuffMode(bool enabled); // 0x0000000186FB9380-0x0000000186FB94E0
		protected override void OnEnable(); // 0x0000000185EC4FA0-0x0000000185EC5080
		protected override void OnRelease(); // 0x000000018D2600C0-0x000000018D260644
		public void OnShow(); // 0x0000000186BD2FC0-0x0000000186BD30B0
		public void OnHide(); // 0x0000000186CE0140-0x0000000186CE01A0
		private void _ClearMainChar(); // 0x0000000185FDA230-0x0000000185FDA630
		public override void LateTick(float deltaTime); // 0x0000000185EC5140-0x0000000185EC52B0
		private bool _CheckHpBarShowing(); // 0x0000000185EC52B0-0x0000000185EC5310
		private void _SetHpBarShowing(bool showing, bool animate); // 0x0000000185EC53E0-0x0000000185EC5570
		private void _OnMainCharChange([IsReadOnly] in EventData<SetLeaderReason, Entity, Entity> data); // 0x000000018D260C74-0x000000018D260CB8
		private void _ProcessOnMainCharChange(Entity newMainChar); // 0x0000000185FDC100-0x0000000185FDCE30
		private void _OnTeamChanged(); // 0x0000000185FDD1A0-0x0000000185FDDCC0
		private void _OnHpChange(Entity entity, double change, bool isMaxHpChanged); // 0x0000000185EC5AF0-0x0000000185EC5EB0
		private void _SetHpFillAmount(float hpPct); // 0x0000000185EC5F70-0x0000000185EC60E0
		private void _CalculateHpChangeDisplay(AbilitySystem target, double deltaValue); // 0x0000000185EC60E0-0x0000000185EC6450
		private void _UpdateHpDisplay(float deltaTime); // 0x0000000185EC5570-0x0000000185EC5830
		private void _OnTakeDamage(Entity entity, bool hideMainCharHpScreenEffect); // 0x0000000186016B10-0x00000001860170A0
		private void _OnMainCharHpActiveChange(); // 0x0000000185EC58A0-0x0000000185EC59A0
		private void _OnHideCharHpInfoChanged([IsReadOnly] in EventData<bool> eventData); // 0x000000018D260C38-0x000000018D260C74
		private void _EnsureBuffNodePreWarmed(); // 0x0000000185FDBA70-0x0000000185FDBC80
		private void _InitCurrentBuffNode(AbilitySystem abilitySystem); // 0x0000000185FDB9B0-0x0000000185FDBA70
		[IDTag(1)]
		private void _ClearBuffNode(); // 0x0000000185FDA630-0x0000000185FDA670
		[IDTag(0)]
		private void _ClearBuffNode(bool useGPUIBuff); // 0x0000000185FDA670-0x0000000185FDA6B0
		private bool _IsCharHpBarVfxBuffValid(ObjectPtr<Buff> buffPtr); // 0x000000018D260938-0x000000018D2609FC
		private void _RebuildCharHpBarVfxBuffCache(); // 0x0000000185FDA9E0-0x0000000185FDAD90
		private ObjectPtr<Buff> _GetLatestValidCharHpBarVfxBuffPtrFromCache(); // 0x0000000185FDC060-0x0000000185FDC100
		private void _OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason); // 0x0000000185D72510-0x0000000185D72630
		private void _RefreshBuffChangeCharHpBarVfx(); // 0x0000000185FDAD90-0x0000000185FDAFE0
		private void _HpVfxOutAnimCallback(); // 0x00000001871DD980-0x00000001871DD9D0
		private void _OnCharPassiveNumChanged(float newNum); // 0x0000000186FD0200-0x0000000186FD02E0
		private UICharPassiveBase _GetOrCreateCharPassiveBase(string prefabName); // 0x0000000185FDBC80-0x0000000185FDC060
		private void _OnProgressBarBuffChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason); // 0x0000000186855680-0x0000000186855710
		private void _OnBuffEnhanceChanged(ObjectPtr<Buff> buffPtr); // 0x000000018D260B10-0x000000018D260C38
		private void _BlinkBuffIcon(string spritePath); // 0x000000018D260840-0x000000018D260938
		private void _SetUltimateBuff(ObjectPtr<Buff> buffPtr); // 0x0000000185FDB4E0-0x0000000185FDB610
		private void _UltimateBuffProgressOutAnimCallback(); // 0x000000018D260CB8-0x000000018D260D14
		private void _RebuildUltimateBuffTracking(); // 0x0000000185FDF130-0x0000000185FE04B0
		private bool _IsUltimateBuffValid(ObjectPtr<Buff> buffPtr); // 0x000000018D2609FC-0x000000018D260B10
		private ObjectPtr<Buff> _GetUltimateBuffForAbility(AbilitySystem ability); // 0x0000000185FDB7A0-0x0000000185FDB890
		private void _SelectUltimateBuff(); // 0x0000000185FDB610-0x0000000185FDB7A0
		[IFixIgnore]
		private void _RefreshUltimateBuffProgress(float deltaTime); // 0x0000000185EC5830-0x0000000185EC58A0
		private void _SetUltimateProgressFill(float realFillAmount, float totalDuration); // 0x000000018D25E27C-0x000000018D25E2C0
		[CompilerGenerated]
		private void __SetHpBarShowing_b__76_0(); // 0x000000018D260810-0x000000018D260840
		[CompilerGenerated]
		private void __BlinkBuffIcon_b__101_0(Sprite sprite); // 0x000000018D260644-0x000000018D260748
		[CompilerGenerated]
		private void __BlinkBuffIcon_b__101_1(); // 0x000000018D260748-0x000000018D2607DC
		[CompilerGenerated]
		private void __BlinkBuffIcon_b__101_2(); // 0x000000018D2607DC-0x000000018D260810
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public class OutOfScreenTargetArrow : MonoBehaviour // TypeDefIndex: 80077
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
		public OutOfScreenTargetArrow(); // 0x00000001878364A0-0x00000001878364B8
	}

	public class OutOfScreenTargetsCtrl : UIPanelBase // TypeDefIndex: 80079
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
		private bool m_disabled; // 0xA0
		private static readonly GameplayTag HIDE_ARROW_TAG; // 0x10
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000186FD28B0-0x0000000186FD28E0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 80078
		{
			// Fields
			public OutOfScreenTargetArrow arrow; // 0x10
			public OutOfScreenTargetsCtrl __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass19_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __InitArrowCallbacks_b__0(); // 0x000000018D2670A4-0x000000018D26714C
			internal void __InitArrowCallbacks_b__1(); // 0x000000018D26714C-0x000000018D2671C4
			internal void __InitArrowCallbacks_b__2(); // 0x000000018D2671C4-0x000000018D267200
		}
	
		// Constructors
		public OutOfScreenTargetsCtrl(); // 0x0000000186E628F0-0x0000000186E62A10
		static OutOfScreenTargetsCtrl(); // 0x0000000186D502E0-0x0000000186D50420
	
		// Methods
		public void OnCreate(); // 0x000000018D26308C-0x000000018D2631BC
		public void OnClose(); // 0x000000018D262F88-0x000000018D26308C
		public void OnShow(); // 0x000000018D2631BC-0x000000018D263308
		public void DebugChangeImpl(bool disableThis); // 0x000000018D262D00-0x000000018D262F88
		public override void LateTick(float deltaTime); // 0x000000018615E510-0x000000018615F1E0
		private OutOfScreenTargetArrow _CreateOneArrow(); // 0x000000018D263308-0x000000018D263524
		private void _InitArrowCallbacks(OutOfScreenTargetArrow arrow); // 0x000000018D263524-0x000000018D2636CC
		private ValueTuple<Vector2, float> _ScreenPosToUIPos(Vector3 screenPos); // 0x000000018D263850-0x000000018D2639A8
		private void _OnEnemyCastSkillToMainChar([IsReadOnly] in EventData<AbilitySystem> eventData); // 0x000000018D2636CC-0x000000018D263850
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D2519E8-0x000000018D2519F0
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public class OutOfScreenTargetsCtrlV2 : UIPanelBase // TypeDefIndex: 80081
	{
		// Fields
		private const string ROOT_ANIMATION_IN = "outofscreentargets_in"; // Metadata: 0x0263BEDD
		private const string ROOT_ANIMATION_OUT = "outofscreentargets_out"; // Metadata: 0x0263BEF3
		private const string ROOT_ANIMATION_LOOP = "outofscreentargets_loop"; // Metadata: 0x0263BF0A
		private const string SKILL_SUBROOT = "DecoOff-screen"; // Metadata: 0x0263BF22
		private const string SKILL_ANIMATION_IN = "DecoOff-screen_in"; // Metadata: 0x0263BF31
		public float ellipseXRadius; // 0x70
		public float ellipseYRadius; // 0x74
		public GPUIExtendedSystem gpuiSystem; // 0x78
		public string gpuiConfigGroupName; // 0x80
		public string gpuiPrefabName; // 0x88
		private readonly Dictionary<ObjectPtr<AbilitySystem>, ArrowRuntimeState> m_arrowStates; // 0x90
		private static readonly List<ObjectPtr<AbilitySystem>> s_toRemoveArrowKeys; // 0x00
		private static readonly List<AbilitySystem> s_currentEnemyKeys; // 0x08
		private bool m_isShow; // 0x98
		private bool m_disabled; // 0x99
		private static readonly GameplayTag HIDE_ARROW_TAG; // 0x10
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000186FD28E0-0x0000000186FD2910 
	
		// Nested types
		private sealed class ArrowRuntimeState // TypeDefIndex: 80080
		{
			// Fields
			public GPUIHandle handle; // 0x10
			public bool rootLoopPending; // 0x18
			public float rootLoopAt; // 0x1C
			public bool rootDestroyPending; // 0x20
			public float rootDestroyAt; // 0x24
			public bool skillHidePending; // 0x28
			public float skillHideAt; // 0x2C
	
			// Constructors
			public ArrowRuntimeState(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public OutOfScreenTargetsCtrlV2(); // 0x0000000186F87FB0-0x0000000186F880A0
		static OutOfScreenTargetsCtrlV2(); // 0x0000000186D50420-0x0000000186D50560
	
		// Methods
		public void OnCreate(); // 0x0000000186819A10-0x0000000186819C40
		public void OnClose(); // 0x000000018D2629C4-0x000000018D262AD4
		public void OnShow(); // 0x0000000186F94E10-0x0000000186F94E40
		public void OnHide(); // 0x0000000186FB8730-0x0000000186FB8760
		public void DebugChangeImpl(bool disableThis); // 0x000000018D262974-0x000000018D2629C4
		public override void LateTick(float deltaTime); // 0x0000000185CDCE70-0x0000000185CDE5F0
		private bool _CreateArrowState(out ArrowRuntimeState state); // 0x0000000185CDBF30-0x0000000185CDC130
		private void _RestartVisibleState(ArrowRuntimeState state); // 0x0000000185CDBCB0-0x0000000185CDBDC0
		private void _ScheduleDestroy(ArrowRuntimeState state); // 0x0000000185CDCA40-0x0000000185CDCB50
		private void _UpdateRuntimeStates(); // 0x0000000185CDE5F0-0x0000000185CDEA10
		private void _RecycleAll(); // 0x000000018D262AD4-0x000000018D262D00
		private ValueTuple<Vector2, float> _ScreenPosToUIPos(Vector3 screenPos); // 0x0000000185CDEA90-0x0000000185CDEB80
		private void _OnEnemyCastSkillToMainChar([IsReadOnly] in EventData<AbilitySystem> eventData); // 0x0000000185CE0350-0x0000000185CE05D0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D2519E8-0x000000018D2519F0
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public class SkillButton : UIPanelBase // TypeDefIndex: 80087
	{
		// Fields
		public const string UI_SPRITE_SKILL_ICON = "SkillIcon"; // Metadata: 0x0263BF45
		private const float HIGHLIGHT_CHECK_INTERVAL = 0.1f; // Metadata: 0x0263BF4F
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
		public GameObject disableMask; // 0x100
		public UIImage cdMask; // 0x108
		public UIImage cdBg; // 0x110
		public UIText cdText; // 0x118
		public UIAnimationWrapper cdRefresh; // 0x120
		public CanvasGroup normalCanvasGroup; // 0x128
		public UIAnimationWrapper strengLight; // 0x130
		public GameObject normalMoveEffectsBg; // 0x138
		public UIAnimationWrapper hint; // 0x140
		public UIAnimationWrapper normalButtonAnim; // 0x148
		public Transform normalKeyHint; // 0x150
		public UIImage notRecommendMask; // 0x158
		public UIImage notRecommendIcon; // 0x160
		public UIImage normalPressFill; // 0x168
		public UIImage normalCountdownFill; // 0x170
		public UnityEngine.Color normalCountdownFillWeakColor; // 0x178
		public RectTransform normalCountdownFillTrail; // 0x188
		public UIAnimationWrapper contentAnimWrapper; // 0x190
		public UIButton ultimateButton; // 0x198
		public UIImage ultimateIcon; // 0x1A0
		public UIImage ultimateIconShadow; // 0x1A8
		public UIImage ultimateColorBg; // 0x1B0
		public UIImage uspRing; // 0x1B8
		public UIImage uspRingSmall; // 0x1C0
		public UIImage centerImage; // 0x1C8
		public UIImage glow01; // 0x1D0
		public UIImage outRing; // 0x1D8
		public CanvasGroup ultimateCanvasGroup; // 0x1E0
		public UIImage pressFill; // 0x1E8
		public UIAnimationWrapper ultimateButtonAnim; // 0x1F0
		public GameObject loopDeco; // 0x1F8
		public UIImage ultKeyIcon; // 0x200
		public Transform ultKeyHint; // 0x208
		public float uspFillSpeed; // 0x210
		public UIImage ultimateFillCompleteImage; // 0x218
		public GameObject ultimateBar; // 0x220
		public UIImage ultimateBarFill; // 0x228
		public float ultimateBarFillMin; // 0x230
		public float ultimateBarFillMax; // 0x234
		public UIImage ultimateCdFill; // 0x238
		public UIImage ultimateBarFillFrame; // 0x240
		public GameObject ultimateCountdownNode; // 0x248
		public UIImage ultimateCountdownFill; // 0x250
		public UIImage ultimateCountdownFillBg; // 0x258
		public UIImage ultimateCountdownBarFill; // 0x260
		public UIImage touchPressUspRing; // 0x268
		public RectTransform touchPressIndicator; // 0x270
		private int m_charIndex; // 0x278
		private Beyond.DeviceInfo.InputType m_panelType; // 0x27C
		private Beyond.Gameplay.CharInfo m_charInfo; // 0x280
		private Beyond.Gameplay.Core.SkillData m_ultimateSkillData; // 0x288
		private Beyond.Gameplay.Core.SkillData m_normalSkillData; // 0x290
		private ObjectPtr<AbilitySystem> m_charAbilityPtr; // 0x298
		private Skill m_normalSkill; // 0x2A8
		private Skill m_ultimateSkill; // 0x2B0
		private bool m_isEmpty; // 0x2B8
		private float m_ultimatePressingTime; // 0x2BC
		private bool m_isDeadState; // 0x2C0
		private bool m_normalSkillReady; // 0x2C1
		private float m_lastHighlightCheckTime; // 0x2C4
		private float m_uspTargetFill; // 0x2C8
		private bool m_ultimateReady; // 0x2CC
		private UnityEngine.Color m_normalIconShadowDefaultColor; // 0x2D0
		private bool m_showNotRecommendState; // 0x2E0
		private PressHandler m_pressHandler; // 0x2E8
		private bool m_hasNotRecommendIcon; // 0x2F0
		private UIAnimationWrapper m_ultimateBarAnim; // 0x2F8
		private UIAnimationWrapper m_ultimateCountdownAnim; // 0x300
		private HudFadeType m_hudFadeType; // 0x308
		private string m_actionId; // 0x310
		private string m_curNormalIconName; // 0x318
		private string m_curUltimateIconName; // 0x320
		private ObjectPtr<Buff> m_normalProgressBuffPtr; // 0x328
		private float m_normalProgressOutDuration; // 0x338
		private TweenCallback m_normalProgressOutCallback; // 0x340
		private TweenCallback m_ultCountDownOutCallback; // 0x348
		private UnityEngine.Color m_normalCountdownFillDefaultColor; // 0x350
		private bool m_isNormalCountdownFillWeakStyle; // 0x360
		private ObjectPtr<Buff> m_ultimateProgressBuffPtr; // 0x368
		private UIAnimationWrapper m_disableMaskAnim; // 0x378
		private TweenCallback m_disableMaskOutCallback; // 0x380
		private bool m_disableMaskVisible; // 0x388
		private Skill m_disableMaskNormalSkill; // 0x390
		private static Action<int> s_onPressSkillButtonStart; // 0x00
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018681D300-0x000000018681D330 
		private SkillSetting skillSetting { get; } // 0x000000018D265FB8-0x000000018D266054 
	
		// Nested types
		private enum PressingMode // TypeDefIndex: 80082
		{
			None = 0,
			Normal = 1,
			Ultimate = 2
		}
	
		private abstract class PressHandler // TypeDefIndex: 80083
		{
			// Fields
			protected SkillButton m_owner; // 0x10
	
			// Properties
			protected SkillSetting skillSetting { get; } // 0x0000000185EB3270-0x0000000185EB32E0 
			public virtual bool needUpdate { get; } // 0x000000018D264AAC-0x000000018D264AEC 
	
			// Constructors
			public PressHandler(SkillButton owner); // 0x0000000184FD2410-0x0000000184FD2420
	
			// Methods
			public abstract void OnPressStart();
			public abstract void OnUpdate(float deltaTime);
			public abstract void OnPressEnd();
			public abstract void OnPressCancel();
			public virtual void OnOtherPressSkillButtonStart(); // 0x000000018D264A44-0x000000018D264A78
			public virtual void OnUltimateSkillChanged(); // 0x000000018D264A78-0x000000018D264AAC
		}
	
		private class PressHandlerLongPress : PressHandler // TypeDefIndex: 80084
		{
			// Fields
			private PressingMode m_pressingMode; // 0x18
			private float m_pressingSkillTime; // 0x1C
	
			// Properties
			public override bool needUpdate { get; } // 0x000000018618E3B0-0x000000018618E3E0 
	
			// Constructors
			public PressHandlerLongPress(SkillButton owner); // 0x0000000184FD2410-0x0000000184FD2420
	
			// Methods
			public override void OnPressStart(); // 0x0000000185F10E30-0x0000000185F11040
			public override void OnUpdate(float deltaTime); // 0x0000000185EB3500-0x0000000185EB3630
			public override void OnPressEnd(); // 0x0000000185EB30D0-0x0000000185EB3270
			public override void OnPressCancel(); // 0x0000000185E957D0-0x0000000185E95860
			public override void OnOtherPressSkillButtonStart(); // 0x00000001870EA470-0x00000001870EA4A0
			public override void OnUltimateSkillChanged(); // 0x000000018D2649F0-0x000000018D264A3C
			public bool __iFixBaseProxy_get_needUpdate(); // 0x000000018D264380-0x000000018D264388
			public void __iFixBaseProxy_OnOtherPressSkillButtonStart(); // 0x000000018D264A3C-0x000000018D264A44
			public void __iFixBaseProxy_OnUltimateSkillChanged(); // 0x000000018D264378-0x000000018D264380
		}
	
		private class PressHandlerIndividualUltimate : PressHandler // TypeDefIndex: 80085
		{
			// Fields
			private PressingMode m_pressingMode; // 0x18
			private float m_pressingSkillTime; // 0x1C
	
			// Properties
			public override bool needUpdate { get; } // 0x000000018D2649B4-0x000000018D2649F0 
	
			// Constructors
			public PressHandlerIndividualUltimate(SkillButton owner); // 0x0000000184FD2410-0x0000000184FD2420
	
			// Methods
			public override void OnPressStart(); // 0x000000018D264800-0x000000018D2648E8
			public override void OnUpdate(float deltaTime); // 0x000000018D2648E8-0x000000018D2649B4
			public override void OnPressEnd(); // 0x000000018D2646F8-0x000000018D264800
			public override void OnPressCancel(); // 0x000000018D264634-0x000000018D2646F8
			public bool __iFixBaseProxy_get_needUpdate(); // 0x000000018D264380-0x000000018D264388
		}
	
		private class PressHandlerDrag : PressHandler // TypeDefIndex: 80086
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
			public override bool needUpdate { get; } // 0x000000018D2645F8-0x000000018D264634 
	
			// Constructors
			public PressHandlerDrag(SkillButton owner); // 0x000000018D264420-0x000000018D2645F8
	
			// Methods
			public override void OnPressStart(); // 0x000000018D263CD0-0x000000018D263F20
			public override void OnUpdate(float deltaTime); // 0x000000018D263F6C-0x000000018D264378
			private bool _InCancelArea(); // 0x000000018D264388-0x000000018D264420
			public override void OnPressEnd(); // 0x000000018D263A7C-0x000000018D263CD0
			public override void OnPressCancel(); // 0x000000018D2639A8-0x000000018D263A7C
			public override void OnUltimateSkillChanged(); // 0x000000018D263F20-0x000000018D263F6C
			public bool __iFixBaseProxy_get_needUpdate(); // 0x000000018D264380-0x000000018D264388
			public void __iFixBaseProxy_OnUltimateSkillChanged(); // 0x000000018D264378-0x000000018D264380
		}
	
		// Constructors
		public SkillButton(); // 0x0000000186C4BE30-0x0000000186C4BEF0
	
		// Methods
		protected override void OnAwake(); // 0x0000000185A57DF0-0x0000000185A59300
		protected override void OnEnable(); // 0x0000000186A2A410-0x0000000186A2A4A0
		public void Close(); // 0x000000018D264AEC-0x000000018D2652B4
		public void FirstTimeInit(int charIndex, bool isDefaultPanel, bool isControllerPanel); // 0x0000000185EA3F20-0x0000000185EA4960
		public void RefreshSkillButton(); // 0x0000000185E95FD0-0x0000000185E985F0
		private bool _TryGetAliveAbilitySystem(out AbilitySystem abilitySys); // 0x000000018D265F4C-0x000000018D265FB8
		private bool _MustUpdate(); // 0x000000018D26558C-0x000000018D265650
		private bool _HasDisableNormalSkillWithUITag(AbilitySystem abilitySys); // 0x0000000184F10C30-0x0000000184F11030
		public override void PreTick(float deltaTime); // 0x000000018535A170-0x000000018535A8A0
		public override void TailLateTick(float deltaTime); // 0x0000000184F10850-0x0000000184F109E0
		private void _InitSkillData(); // 0x0000000185E94760-0x0000000185E951E0
		private void _UpdateMainUI(float deltaTime); // 0x0000000185359A70-0x000000018535A0B0
		private void _RefreshDisableMask(AbilitySystem abilitySys); // 0x000000018D265A2C-0x000000018D265ABC
		private void _SetDisableMaskVisible(bool visible, bool playAnimation = true /* Metadata: 0x0263BF43 */); // 0x0000000184F11030-0x0000000184F11540
		private void _RefreshNormalSkillCd(); // 0x00000001853583D0-0x00000001853586B0
		private void _RefreshUltimateSkillCd(bool costAvailable); // 0x00000001853598C0-0x0000000185359A20
		private void _CheckNormalSkillHighlight(); // 0x000000018542F100-0x000000018542F240
		private void _SetNotRecommendState(bool active); // 0x000000018D265CC0-0x000000018D265D44
		public void OnCharacterDie(); // 0x000000018D2652B4-0x000000018D2652F4
		private void _RefreshDeadState(bool anim); // 0x0000000185E95A20-0x0000000185E95EB0
		private void _SetUspFillAmount(float fillAmount); // 0x000000018D265DF4-0x000000018D265F00
		private void _SetPressFillActive(bool active); // 0x0000000185E95860-0x0000000185E95950
		private void _SetPressFillAmount(float fillAmount); // 0x0000000187112B80-0x0000000187112C60
		private void _OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason); // 0x0000000185D70F50-0x0000000185D71010
		[IFixIgnore]
		private void _SetNormalCountdownFillVisible(bool visible); // 0x0000000185A59300-0x0000000185A59430
		private void _ResetNormalCountdownFillStyle(); // 0x000000018D265ABC-0x000000018D265B24
		private void _SetUltimateCountdownFillVisible(bool visible, bool playOutAnim = true /* Metadata: 0x0263BF44 */); // 0x000000018D265D44-0x000000018D265DF4
		private void _RefreshNormalProgressBuff(); // 0x000000018535A0B0-0x000000018535A120
		private void _RefreshUltimateProgressBuff(); // 0x000000018535A120-0x000000018535A170
		public void OnUspChange(Entity entity = null); // 0x0000000185E951E0-0x0000000185E95650
		private void _SetHideUspInfoState(); // 0x000000018D265B24-0x000000018D265CC0
		private bool _ShouldHideSkillCdInfo(); // 0x000000018D265F00-0x000000018D265F4C
		private bool _CanCastSkill(Skill skill); // 0x000000018D2654BC-0x000000018D2654D8
		private bool _CanShowUltimatePress(); // 0x000000018D2654D8-0x000000018D26554C
		public void CastSkill(Skill skill); // 0x0000000185EB32E0-0x0000000185EB3500
		public void OnPressSkillStart(PointerEventData eventData = null); // 0x0000000186E45A80-0x0000000186E45B50
		private void _OnOtherPressSkillButtonStart(int charIndex); // 0x0000000186F8D6C0-0x0000000186F8D710
		public void OnPressSkillEnd(PointerEventData eventData = null); // 0x0000000186EC2D00-0x0000000186EC2DB0
		public void OnPressCancelled(); // 0x0000000185EAD6D0-0x0000000185EAD750
		private void _CastUltimateSkill(); // 0x000000018D26554C-0x000000018D26558C
		public void OnPressUltimateSkillStart(PointerEventData eventData); // 0x000000018D2652F4-0x000000018D265408
		public void ToggleControllerSkillIndicator(bool active); // 0x000000018D265408-0x000000018D2654BC
		private void _OnCharPotentialUnlock([IsReadOnly] in EventData<ulong, uint> eventData); // 0x000000018D2656C0-0x000000018D26572C
		private void _OnCharSkillChange([IsReadOnly] in EventData<ulong, string> eventData); // 0x000000018D26572C-0x000000018D265798
		private void _OnCharUltimateSkillChange([IsReadOnly] in EventData<ulong, string> eventData); // 0x000000018D265798-0x000000018D265824
		private void _OnSkillUpgradeSuccess([IsReadOnly] in EventData<ulong, string, int> eventData); // 0x000000018D2659C0-0x000000018D265A2C
		private void _OnActiveSkillDataRefreshed([IsReadOnly] in EventData<ulong, string> eventData); // 0x000000018D265650-0x000000018D2656C0
		private void _OnSkillCdChanged([IsReadOnly] in EventData<Skill> eventData); // 0x000000018D265924-0x000000018D2659C0
		private void _OnHideCharUspInfoChanged([IsReadOnly] in EventData<bool> eventData); // 0x000000018D265824-0x000000018D265884
		private void _OnSkillButtonActiveConfigChanged(); // 0x0000000185E95950-0x0000000185E95A20
		private void _OnInputActionKeyUpdated([IsReadOnly] in EventData<string> eventData); // 0x000000018D265884-0x000000018D2658EC
		private void _OnKeyboardTypeChanged(); // 0x000000018D2658EC-0x000000018D265924
		private void _UpdateLongPressKeyHint(); // 0x0000000185EA3D50-0x0000000185EA3EA0
		private void _SetGoActive(bool active); // 0x0000000185E95650-0x0000000185E957D0
		public void SetEmpty(bool isEmpty); // 0x0000000185C31FB0-0x0000000185C32050
		public void ClearBtnClick(); // 0x0000000185EAD630-0x0000000185EAD6D0
		[CompilerGenerated]
		private void _OnAwake_b__104_0(); // 0x0000000184F109E0-0x0000000184F10A60
		[CompilerGenerated]
		private void _OnAwake_b__104_1(); // 0x0000000184F10A60-0x0000000184F10B70
		[CompilerGenerated]
		private void _OnAwake_b__104_2(); // 0x0000000184F10B70-0x0000000184F10C30
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D2519E8-0x000000018D2519F0
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_TailLateTick(float P0); // 0x0000000184167520-0x0000000184167530
	}

	public class SquadIcon : UIPanelBase // TypeDefIndex: 80088
	{
		// Fields
		private const string UI_CHAR_HEAD_PREFIX = "icon_"; // Metadata: 0x0263BF59
		private const string UI_SPRITE_DIR_CHAR_HEAD = "CharBattleIcon"; // Metadata: 0x0263BF5F
		private const string UI_SPRITE_DIR_ITEM = "ItemIcon"; // Metadata: 0x0263BF6E
		private const float HP_CHANGE_TOLERANCE = 0.0001f; // Metadata: 0x0263BF77
		public const string CHAR_PASSIVE_UI_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Prefabs/Battle/Widgets/CharPassiveUI/"; // Metadata: 0x0263BF7B
		private const string NRL_COMBO_STATE_NAME = "NrlCombo"; // Metadata: 0x0263BFCA
		private const string REWARD_COMBO_STATE_NAME = "RewardCombo"; // Metadata: 0x0263BFD3
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
		public GameObject leftInfoLayout; // 0xE0
		public GameObject hpAndComboLayout; // 0xE8
		public GameObject hpNode; // 0xF0
		public UIAnimationWrapper hpFlashAnim; // 0xF8
		public RectTransform hpFillRect; // 0x100
		public float hpFlashPercent; // 0x108
		public float hpRedPercent; // 0x10C
		public float hpShakePercent; // 0x110
		public UIImage hpFill; // 0x118
		public UIImage hpRedFill; // 0x120
		public UIAnimationWrapper hpRecoverAnim; // 0x128
		public RectTransform hpVfxNode; // 0x130
		public UIImage[] hpVfxImages; // 0x138
		public SerializeFieldDictionary<SpellInflictionOnCharType, UnityEngine.Color> hpVfXColors; // 0x140
		public GameObject levelNode; // 0x148
		public UIAnimationWrapper levelUpAnim; // 0x150
		public UIText animLevelTxt; // 0x158
		public UIText levelTxt; // 0x160
		public RectTransform comboCdNode; // 0x168
		public UIAnimationWrapper comboCdBarAnim; // 0x170
		public UIImage comboCdFill; // 0x178
		public UIAnimationWrapper comboReadyAnim; // 0x180
		public UIBuffNode buffNode; // 0x188
		public GPUIBuffNode gpuiBuffNode; // 0x190
		public CanvasGroup tacticalCanvasGroup; // 0x198
		public GameObject tacticalCdNode; // 0x1A0
		public GameObject tacticalCastBar; // 0x1A8
		public GameObject tacticalDotNode; // 0x1B0
		public GameObject tacticalProhibitNode; // 0x1B8
		public GameObject tacticalEmptyNode; // 0x1C0
		public UIImage tacticalIcon; // 0x1C8
		public UIImage tacticalCastFill; // 0x1D0
		public float tacticalDeadAlpha; // 0x1D8
		public float tacticalItemUsedUpAlpha; // 0x1DC
		public GameObject fixedIcon; // 0x1E0
		public GameObject trailIcon; // 0x1E8
		public GameObject indieTrailIcon; // 0x1F0
		public CanvasGroup igniteBuffTextNode; // 0x1F8
		public Animation igniteBuffTextAnim; // 0x200
		public UIText igniteBuffText; // 0x208
		public UnityEngine.Color igniteBuffColorPulse; // 0x210
		public UnityEngine.Color igniteBuffColorCryst; // 0x220
		public UnityEngine.Color igniteBuffColorNatural; // 0x230
		public UnityEngine.Color igniteBuffColorFire; // 0x240
		public Transform charPassiveNode; // 0x250
		[CompilerGenerated]
		private bool _isEmpty_k__BackingField; // 0x258
		private Beyond.DeviceInfo.InputType m_panelType; // 0x25C
		private bool m_isMainCharacter; // 0x260
		private bool m_teamSwitchUnlocked; // 0x261
		private int m_charIndex; // 0x264
		private string m_charIndexStr; // 0x268
		private Beyond.Gameplay.CharInfo m_charInfo; // 0x270
		private ObjectPtr<AbilitySystem> m_charAbilityPtr; // 0x278
		private List<TacticalDotCell> m_tacticalDots; // 0x288
		private float m_tacticalCastFillMax; // 0x290
		private int m_lastLevel; // 0x294
		private bool m_indicatorShowing; // 0x298
		private bool m_lastComboCdReady; // 0x299
		private bool m_lastRewardComboState; // 0x29A
		private bool m_comboReadyAnimShowing; // 0x29B
		private bool m_comboIconShowing; // 0x29C
		private UIHudFadeController m_hudFadeController; // 0x2A0
		private UIAnimationWrapper m_hpVfxAnimWrapper; // 0x2A8
		private string m_lastCharPassiveName; // 0x2B0
		private UICharPassiveBase m_charPassiveBase; // 0x2B8
		private DG.Tweening.Sequence m_keyHintFadeSequence; // 0x2C0
		private bool m_inDeadState; // 0x2C8
		private UIAnimationWrapper m_tacticalSwitchAnim; // 0x2D0
		private bool? m_tacticalInProgress; // 0x2D8
		private int m_tacticalItemLastDisplayCount; // 0x2DC
		private float m_comboCdNodeHeight; // 0x2E0
		private readonly List<ObjectPtr<Buff>> m_activeCharHpBarVfxBuffs; // 0x2E8
		private ObjectPtr<Buff> m_charHpBarVfxBuffPtr; // 0x2F0
		private GPUIProxySyncManager m_gpuiProxySyncManager; // 0x300
		private bool m_gpuiBuffNodePreWarmed; // 0x308
		private bool m_normalBuffNodePreWarmed; // 0x309
		private bool m_buffModeInitialized; // 0x30A
		private bool m_useGPUIBuff; // 0x30B
		private UIStateController m_hpAndComboStateController; // 0x310
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018681D2D0-0x000000018681D300 
		public bool isEmpty { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723D020-0x000000018723D030 0x000000018723D100-0x000000018723D110
	
		// Constructors
		public SquadIcon(); // 0x000000018657BB20-0x000000018657BC50
	
		// Methods
		protected override void OnAwake(); // 0x0000000186CE8CD0-0x0000000186CE9800
		public void SetGPUIBuffSync(GPUIProxySyncManager gpuiProxySyncManager); // 0x000000018716D370-0x000000018716D3B0
		public void SetGPUIBuffMode(bool enableGPUIBuff); // 0x0000000185C31AF0-0x0000000185C31CA0
		public void FirstTimeInit(int index, bool isDefaultPanel, bool isControllerPanel); // 0x0000000185EA4A60-0x0000000185EA5060
		public void Close(); // 0x000000018D26620C-0x000000018D2666D4
		public void InitSquadIcon(bool showFixed = false /* Metadata: 0x0263BF56 */, bool showTrail = false /* Metadata: 0x0263BF57 */); // 0x0000000185FCF4A0-0x0000000185FD3710
		private bool _MustUpdate(); // 0x0000000185507430-0x00000001855074C0
		public override void LateTick(float deltaTime); // 0x0000000185505B50-0x0000000185506370
		private bool _TryGetAliveAbilitySystem(out AbilitySystem abilitySys); // 0x000000018D267008-0x000000018D267074
		private void _UpdateComboSkillIcon(bool showAnim = true /* Metadata: 0x0263BF58 */); // 0x0000000185357290-0x00000001853580D0
		private void _PlayComboCdBarInAnimation(); // 0x0000000184F11780-0x0000000184F11E80
		public void SetEmpty(bool empty); // 0x0000000185C32050-0x0000000185C32270
		public void ToggleIndicator(bool isShow); // 0x000000018D266AA4-0x000000018D266AE0
		public void InformKeyHint(); // 0x000000018D2666D4-0x000000018D266884
		private void _OnHpChange(Entity entity, double change, bool isMaxHpChanged); // 0x0000000185279860-0x0000000185279B90
		private void _SetLevelText(); // 0x0000000185FCE780-0x0000000185FCE850
		private void _OnIgniteBuffText([IsReadOnly] in EventData<ulong, string, EnergyShardType> eventData); // 0x000000018D266CC0-0x000000018D266E6C
		public void OnLevelChange(); // 0x000000018D266884-0x000000018D2668DC
		private void _TryShowLevelUpAnim(); // 0x0000000185FCE0F0-0x0000000185FCE190
		public void SetDeadState(bool dead); // 0x0000000185FCE190-0x0000000185FCE390
		private void _EnsureBuffNodePreWarmed(); // 0x0000000185FCE5D0-0x0000000185FCE780
		private void _InitCurrentBuffNode(ObjectPtr<AbilitySystem> abilitySystemPtr); // 0x0000000185FCECC0-0x0000000185FCED30
		private void _ClearBuffNode(); // 0x000000018D266AE0-0x000000018D266B54
		private void _UpdateIconAlpha(); // 0x00000001851324D0-0x0000000185132590
		public bool CanSwitchToCenter(bool showTip); // 0x000000018D266054-0x000000018D26620C
		public void OnPressCharIconStart(PointerEventData eventData); // 0x000000018D2668DC-0x000000018D266A64
		public void OnTacticalItemChange(); // 0x0000000185FCF010-0x0000000185FCF2F0
		private void _UpdateTacticalItemStatus(); // 0x00000001851CF830-0x00000001851CFE60
		public void OnTeamSwitchUnlocked(); // 0x000000018D266A64-0x000000018D266AA4
		private void _OnMainCharChange([IsReadOnly] in EventData<SetLeaderReason, Entity, Entity> data); // 0x000000018D266E6C-0x000000018D267008
		private void _OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason); // 0x0000000185D70EB0-0x0000000185D70F50
		private void _OnHideCharHpInfoChanged([IsReadOnly] in EventData<bool> eventData); // 0x000000018D266C84-0x000000018D266CC0
		private void _RefreshCharHpInfoVisible(); // 0x0000000185EA3B60-0x0000000185EA3D50
		private void _RefreshBuffChangeCharHpBarVfx(); // 0x0000000185FCE390-0x0000000185FCE5D0
		private void _HpVfxOutAnimCallback(); // 0x000000018D266B54-0x000000018D266BC0
		private void _OnCharPassiveNumChanged(float newNum); // 0x0000000186B92330-0x0000000186B92410
		private bool _IsCharHpBarVfxBuffValid(ObjectPtr<Buff> buffPtr); // 0x000000018D266BC0-0x000000018D266C84
		private void _RebuildCharHpBarVfxBuffCache(); // 0x0000000185C07CF0-0x0000000185C08050
		private ObjectPtr<Buff> _GetLatestValidCharHpBarVfxBuffPtrFromCache(); // 0x0000000185FCEF70-0x0000000185FCF010
		[CompilerGenerated]
		private void __UpdateComboSkillIcon_b__114_0(); // 0x0000000184F116D0-0x0000000184F11780
		[CompilerGenerated]
		private void __PlayComboCdBarInAnimation_b__115_0(); // 0x0000000184F115F0-0x0000000184F11620
		[CompilerGenerated]
		private void __OnHpChange_b__119_0(); // 0x0000000184F11540-0x0000000184F115F0
		[CompilerGenerated]
		private void __TryShowLevelUpAnim_b__123_0(); // 0x0000000184F11620-0x0000000184F116D0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D2519E8-0x000000018D2519F0
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public class TacticalDotCell : MonoBehaviour // TypeDefIndex: 80089
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
		public TacticalDotCell(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		public void Init(); // 0x0000000185FCF2F0-0x0000000185FCF320
		public void SetDotActive(bool isActive, bool playAnim = true /* Metadata: 0x0263BFDF */); // 0x00000001851CFE60-0x00000001851CFF00
		public void SetDotUsedUp(bool isUsedUp); // 0x00000001851CF7B0-0x00000001851CF830
		[CompilerGenerated]
		private void _SetDotActive_b__8_0(); // 0x000000018D267074-0x000000018D2670A4
	}

	public class UIAbnormalBuffCell : UIBuffCell // TypeDefIndex: 80090
	{
		// Fields
		[SerializeField]
		private UIImage _buffLifeTimeBar; // 0x78
		[SerializeField]
		private UIStateController _abnormalLevelState; // 0x80
	
		// Constructors
		public UIAbnormalBuffCell(); // 0x0000000185DD4BE0-0x0000000185DD4BF0
	
		// Methods
		public override void OnTick(float deltaTime); // 0x000000018D2672A0-0x000000018D267340
		protected override void VisualInit(Sprite sprite); // 0x000000018D2673F0-0x000000018D26764C
		protected override void SetWarningState(bool isWarning); // 0x000000018D267340-0x000000018D2673D8
		public void __iFixBaseProxy_OnTick(float P0); // 0x000000018D2673D8-0x000000018D2673E0
		public void __iFixBaseProxy_VisualInit(Sprite P0); // 0x000000018D2673E8-0x000000018D2673F0
		public void __iFixBaseProxy_SetWarningState(bool P0); // 0x000000018D2673E0-0x000000018D2673E8
	}

	public class UIAttachedBuffCell : UIBuffCell // TypeDefIndex: 80092
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
		private const string BUFF_ANIM_IGNITE = "headbar_buff_cell_ignite"; // Metadata: 0x0263BFE0
		private int m_maxStackCount; // 0x98
		private float? m_targetStackRingFillAmount; // 0x9C
		private PeriodicTimer m_igniteFillDelayTimer; // 0xA8
		private Dictionary<int, int> m_consumingStackVersions; // 0xB0
		private int m_consumeAnimVersion; // 0xB8
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 80091
		{
			// Fields
			public int consumeStackIndex; // 0x10
			public int consumeAnimVersion; // 0x14
			public UIAttachedBuffCell __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __PlayConsumeAnimations_b__0(); // 0x000000018D267200-0x000000018D2672A0
		}
	
		// Constructors
		public UIAttachedBuffCell(); // 0x0000000185DD4C70-0x0000000185DD4D60
	
		// Methods
		protected override void DataInit(ObjectPtr<Buff> buffPtr); // 0x00000001868AC420-0x00000001868AC530
		public override void OnTick(float deltaTime); // 0x00000001862DBF40-0x00000001862DBFE0
		public override void BeforePlayOutAnim(); // 0x000000018D26764C-0x000000018D2676AC
		private void _SettlePendingStackFillBeforeOut(); // 0x000000018D267CE0-0x000000018D267E14
		protected override void SetBuffIcon(Sprite sprite); // 0x0000000186DB0A00-0x0000000186DB0A60
		protected override void SetStackElementActive(bool showStackCount); // 0x0000000186B1E7A0-0x0000000186B1E810
		public override void SetStackCount(int stackCount, bool playAnim); // 0x00000001869E6B90-0x00000001869E6CD0
		public override void OnBuffIgnite(); // 0x000000018D2676AC-0x000000018D2677B0
		private void _ClearConsumeAnimations(); // 0x00000001869E6CD0-0x00000001869E71A0
		private void _PlayConsumeAnimations(int stackCount, float currentTargetFillAmount); // 0x000000018D267AA8-0x000000018D267CE0
		private void _ClearConsumeAnimationsBelowStackCount(int stackCount); // 0x000000018D2677F8-0x000000018D2678D4
		private float _GetConsumeDecreaseLimitFillAmount(); // 0x000000018D2678D4-0x000000018D267AA8
		public void __iFixBaseProxy_DataInit(ObjectPtr<Buff> P0); // 0x000000018D2677B8-0x000000018D2677D8
		public void __iFixBaseProxy_OnTick(float P0); // 0x000000018D2673D8-0x000000018D2673E0
		public void __iFixBaseProxy_BeforePlayOutAnim(); // 0x000000018D2677B0-0x000000018D2677B8
		public void __iFixBaseProxy_SetBuffIcon(Sprite P0); // 0x000000018D2677E0-0x000000018D2677E8
		public void __iFixBaseProxy_SetStackElementActive(bool P0); // 0x000000018D2677F0-0x000000018D2677F8
		public void __iFixBaseProxy_SetStackCount(int P0, bool P1); // 0x000000018D2677E8-0x000000018D2677F0
		public void __iFixBaseProxy_OnBuffIgnite(); // 0x000000018D2677D8-0x000000018D2677E0
	}

	public class UIBuffCell : MonoBehaviour // TypeDefIndex: 80094
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
		[CompilerGenerated]
		private ulong _nextInstanceId_k__BackingField; // 0x68
		[CompilerGenerated]
		private string _curSpritePath_k__BackingField; // 0x70
	
		// Properties
		public ulong nextInstanceId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232F80-0x0000000187232F90 0x0000000187233460-0x0000000187233470
		public string curSpritePath { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232FC0-0x0000000187232FD0 0x0000000188800CD0-0x0000000188800CE0
		public UIAnimationWrapper anim { get; } // 0x000000018D267E7C-0x000000018D267EBC 
		public BuffData buffData { get; } // 0x00000001857E3F70-0x00000001857E3FE0 
		public int orderPriority { get; } // 0x00000001857E3F20-0x00000001857E3F70 
		public ulong buffInstanceUid { get; } // 0x00000001857E3010-0x00000001857E3090 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 80093
		{
			// Fields
			public UIBuffCell __4__this; // 0x10
			public string inputSpritePath; // 0x18
			public Action onSpriteLoaded; // 0x20
			public ulong cachedLoadKey; // 0x28
	
			// Constructors
			public __c__DisplayClass25_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Init_b__0(Sprite sprite); // 0x0000000186A53C10-0x0000000186A53C80
		}
	
		// Constructors
		public UIBuffCell(); // 0x0000000185DD4C30-0x0000000185DD4C70
	
		// Methods
		public void Init(ObjectPtr<Buff> buffPtr, LuaResourceLoader loader, Action onSpriteLoaded = null); // 0x00000001857E32A0-0x00000001857E34C0
		protected virtual void DataInit(ObjectPtr<Buff> buffPtr); // 0x00000001868AC5B0-0x00000001868AC5E0
		protected virtual void VisualInit(Sprite sprite); // 0x00000001857E3170-0x00000001857E32A0
		public void Clear(); // 0x00000001860C2560-0x00000001860C25D0
		public virtual void BeforePlayOutAnim(); // 0x000000018D267E14-0x000000018D267E48
		public virtual void OnTick(float deltaTime); // 0x00000001862DC0E0-0x00000001862DC110
		public virtual void SetVisible(bool visible); // 0x00000001857E41F0-0x00000001857E42F0
		public virtual void SetStackCount(int stackCount, bool playAnim); // 0x0000000185FCCCD0-0x0000000185FCCDA0
		public virtual void OnBuffIgnite(); // 0x000000018D267E48-0x000000018D267E7C
		protected virtual void SetBuffIcon(Sprite sprite); // 0x0000000186C29080-0x0000000186C290C0
		protected virtual void SetStackElementActive(bool isActive); // 0x0000000186B1E810-0x0000000186B1E860
		protected virtual void SetWarningState(bool isWarning); // 0x00000001869E5330-0x00000001869E5390
	}

	public class UIBuffNode : TickableUIMono // TypeDefIndex: 80104
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
		private const string BUFF_ANIM_STRONG_IN = "headbar_buff_cell_strong_in"; // Metadata: 0x0263BFF9
		private const string BUFF_ANIM_IGNITE_OUT = "headbar_buff_cell_ignite_out"; // Metadata: 0x0263C015
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000186912AC0-0x0000000186912AF0 
	
		// Nested types
		public enum BuffNodeType // TypeDefIndex: 80095
		{
			HeadBarCommon = 0,
			HeadBarAttached = 1,
			SquadIconCommon = 2,
			MainCharHpBarCommon = 3
		}
	
		public class BuffCellGroup // TypeDefIndex: 80096
		{
			// Fields
			public BuffIconConfig.BuffIconStyle buffIconStyle; // 0x10
			public UIBuffCell buffCellTemplate; // 0x18
			public List<UIBuffCell> buffCellPool; // 0x20
			public DynamicFastLookupCollection<ulong, UIBuffCell> buffCellDict; // 0x28
			public DynamicFastLookupCollection<ulong, UIBuffCell> buffCellWithOutAnim; // 0x30
	
			// Constructors
			public BuffCellGroup(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public UIBuffCell CreateBuffCell(Transform transform); // 0x00000001857E3BD0-0x00000001857E3CD0
			public void RemoveBuffCell(UIBuffCell buffCell); // 0x00000001860C10A0-0x00000001860C1160
			public void ClearAllBuffCells(LuaResourceLoader loader); // 0x0000000185AB75F0-0x0000000185AB7690
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0 // TypeDefIndex: 80097
		{
			// Fields
			public UIBuffNode __4__this; // 0x10
			public bool playAnim; // 0x18
			public BuffData buffData; // 0x20
	
			// Constructors
			public __c__DisplayClass27_0(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_1 // TypeDefIndex: 80098
		{
			// Fields
			public UIBuffCell newBuffCell; // 0x10
			public __c__DisplayClass27_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass27_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __AddBuffIconInternal_b__0(); // 0x000000018D2718BC-0x000000018D271908
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_2 // TypeDefIndex: 80099
		{
			// Fields
			public UIBuffCell buffCell; // 0x10
			public __c__DisplayClass27_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass27_2(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __AddBuffIconInternal_b__1(); // 0x00000001857E2F50-0x00000001857E3010
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_3 // TypeDefIndex: 80100
		{
			// Fields
			public UIBuffCell buffCell; // 0x10
			public __c__DisplayClass27_0 CS___8__locals3; // 0x18
	
			// Constructors
			public __c__DisplayClass27_3(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __AddBuffIconInternal_b__2(); // 0x00000001857E3090-0x00000001857E3170
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0 // TypeDefIndex: 80101
		{
			// Fields
			public ObjectPtr<Buff> buffPtr; // 0x10
			public BuffCellGroup buffCellGroup; // 0x20
			public UIBuffNode __4__this; // 0x28
	
			// Constructors
			public __c__DisplayClass28_0(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_1 // TypeDefIndex: 80102
		{
			// Fields
			public List<ObjectPtr<Buff>> stackBuffList; // 0x10
			public UIBuffCell buffCell; // 0x18
			public __c__DisplayClass28_0 CS___8__locals1; // 0x20
	
			// Constructors
			public __c__DisplayClass28_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __RemoveBuffIconInternal_b__0(); // 0x000000018D271908-0x000000018D271A1C
			internal void __RemoveBuffIconInternal_b__1(); // 0x000000018D271A1C-0x000000018D271B30
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_2 // TypeDefIndex: 80103
		{
			// Fields
			public UIBuffCell buffCell; // 0x10
			public __c__DisplayClass28_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass28_2(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __RemoveBuffIconInternal_b__2(); // 0x00000001860C0D00-0x00000001860C0DE0
			internal void __RemoveBuffIconInternal_b__3(); // 0x000000018D271B30-0x000000018D271C04
		}
	
		// Constructors
		public UIBuffNode(); // 0x00000001860C2AE0-0x00000001860C2CB0
	
		// Methods
		private void _OnFirstInit(); // 0x00000001860C25D0-0x00000001860C2AE0
		public void OnPreWarm(); // 0x00000001860C20D0-0x00000001860C2560
		public void Init(ObjectPtr<AbilitySystem> abilitySystemPtr); // 0x00000001860C2F20-0x00000001860C3000
		public void Refresh(); // 0x0000000185C07630-0x0000000185C07CF0
		public void Clear(); // 0x0000000185AB7470-0x0000000185AB75F0
		public override void TailLateTick(float deltaTime); // 0x0000000185AB7690-0x0000000185AB7AF0
		protected override void OnRelease(); // 0x000000018D267EBC-0x000000018D267F8C
		public void OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason); // 0x00000001860C1160-0x00000001860C1200
		private bool _IsBuffIconInThisNode(ObjectPtr<Buff> buffPtr); // 0x00000001860C1200-0x00000001860C12A0
		private void _OnAddBuff(ObjectPtr<Buff> buffPtr); // 0x00000001860C0F00-0x00000001860C0F90
		private void _OnRemoveBuff(ObjectPtr<Buff> buffPtr, Buff.FinishReason finishReason); // 0x00000001860C12A0-0x00000001860C1360
		private void _AddBuffIconInternal(ObjectPtr<Buff> buffPtr, bool playAnim); // 0x00000001857E3500-0x00000001857E3BD0
		private void _RemoveBuffIconInternal(ObjectPtr<Buff> buffPtr, Buff.FinishReason finishReason); // 0x00000001860C1970-0x00000001860C1F60
		private void _OnBuffEnhanceChanged(ObjectPtr<Buff> buffPtr); // 0x000000018D267F8C-0x000000018D2680F8
		private void _OnBuffIgnite(ObjectPtr<Buff> buffPtr); // 0x000000018D2680F8-0x000000018D26826C
		private void _RegisterAbilityBuffEvent(AbilitySystem abilitySystem); // 0x00000001860C30F0-0x00000001860C32C0
		private void _UnregisterAbilityBuffEvent(AbilitySystem abilitySystem); // 0x00000001860C32C0-0x00000001860C3490
		private BuffIconConfig.BuffIconStyle _GetIconStyle(Buff buff); // 0x00000001860C1F60-0x00000001860C2020
		private void _SetBuffCellSiblingInOrder(UIBuffCell buffCell); // 0x00000001857E3CD0-0x00000001857E3F20
		private void _DealWithBuffCellVisible(); // 0x00000001857E3FE0-0x00000001857E4090
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_TailLateTick(float P0); // 0x0000000184167520-0x0000000184167530
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
	}

	public class UILifeTimeBuffCell : UIBuffCell // TypeDefIndex: 80105
	{
		// Fields
		[SerializeField]
		private UIImage _buffLifeTimeBar; // 0x78
	
		// Constructors
		public UILifeTimeBuffCell(); // 0x0000000185DD4BE0-0x0000000185DD4BF0
	
		// Methods
		public override void OnTick(float deltaTime); // 0x00000001862DBFE0-0x00000001862DC0E0
		protected override void SetWarningState(bool isWarning); // 0x00000001869E52B0-0x00000001869E5330
		public void __iFixBaseProxy_OnTick(float P0); // 0x000000018D2673D8-0x000000018D2673E0
		public void __iFixBaseProxy_SetWarningState(bool P0); // 0x000000018D2673E0-0x000000018D2673E8
	}

	public class UISpellInflictionOnCharCell : MonoBehaviour // TypeDefIndex: 80106
	{
		// Fields
		[SerializeField]
		private UIStateController _stateController; // 0x18
		[SerializeField]
		private UIAnimationWrapper _animationWrapper; // 0x20
		private bool m_isActive; // 0x28
	
		// Constructors
		public UISpellInflictionOnCharCell(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void SetCellActive(bool active, bool forceRefresh = false /* Metadata: 0x0263C036 */); // 0x000000018D275F98-0x000000018D2760D0
	}

	public class UISpellInflictionOnCharNode : MonoBehaviour // TypeDefIndex: 80111
	{
		// Fields
		[SerializeField]
		private Transform _attachBuffCellRoot; // 0x18
		[SerializeField]
		private UISpellInflictionOnCharCell _attachBuffCell; // 0x20
		[SerializeField]
		private UIImage _abnormalBuffProgressBar; // 0x28
		[SerializeField]
		private UIAnimationWrapper _abnormalBuffProgressAnim; // 0x30
		private static List<string> s_attachBuffIds; // 0x00
		private static List<string> s_abnormalBuffIds; // 0x08
		private bool m_isFirstInited; // 0x38
		private ObjectPtr<AbilitySystem> m_owner; // 0x40
		private List<ObjectPtr<Buff>> m_attachBuffs; // 0x50
		private List<ObjectPtr<Buff>> m_abnormalBuffs; // 0x58
		private UIListCache<UISpellInflictionOnCharCell> m_attachBuffCellCache; // 0x60
	
		// Properties
		private bool isInCcDungeon { get; } // 0x0000000185D71130-0x0000000185D711C0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 80107
		{
			// Fields
			public Buff attachBuff; // 0x10
	
			// Constructors
			public __c__DisplayClass19_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __DoRefreshUI_b__0(UISpellInflictionOnCharCell cell, int index); // 0x000000018D2717C4-0x000000018D2717FC
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 80108
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<UISpellInflictionOnCharCell, int> __9__19_1; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D271C54-0x000000018D271CB8
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __DoRefreshUI_b__19_1(UISpellInflictionOnCharCell cell, int index); // 0x000000018D27179C-0x000000018D2717C4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 80109
		{
			// Fields
			public Buff buff; // 0x10
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __OnBuffIconChange_b__0(UISpellInflictionOnCharCell cell, int index); // 0x000000018D2717FC-0x000000018D271834
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 80110
		{
			// Fields
			public Buff buff; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __OnBuffEnhanceChanged_b__0(UISpellInflictionOnCharCell cell, int index); // 0x000000018D2717FC-0x000000018D271834
		}
	
		// Constructors
		public UISpellInflictionOnCharNode(); // 0x0000000186EC2540-0x0000000186EC2650
		static UISpellInflictionOnCharNode(); // 0x0000000186FABE00-0x0000000186FABF30
	
		// Methods
		private void _OnFirstInit(); // 0x0000000185FDB390-0x0000000185FDB4E0
		public void OnInit(ObjectPtr<AbilitySystem> abilitySystemPtr); // 0x0000000185FDB890-0x0000000185FDB9B0
		public void OnTick(float deltaTime); // 0x0000000185EC5310-0x0000000185EC53E0
		public void OnClear(); // 0x0000000185FDA6B0-0x0000000185FDA7D0
		private void _RegisterAbilityBuffEvent(AbilitySystem abilitySystem); // 0x0000000185FDB230-0x0000000185FDB390
		private void _UnregisterAbilityBuffEvent(AbilitySystem abilitySystem); // 0x0000000185FD94F0-0x0000000185FD9650
		private void _DoRefreshUI(); // 0x000000018D2760D0-0x000000018D276408
		private void _OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason); // 0x0000000185D71010-0x0000000185D71130
		private void _OnBuffEnhanceChanged(ObjectPtr<Buff> buffPtr); // 0x000000018D276408-0x000000018D2765C8
	}

	public class UIHudFadeBase : MonoBehaviour // TypeDefIndex: 80112
	{
		// Fields
		public UIStyleInputValidType validType; // 0x18
	
		// Properties
		protected bool globalNeedShow { get; } // 0x0000000185C88DC0-0x0000000185C88E20 
	
		// Constructors
		public UIHudFadeBase(); // 0x000000018783D55C-0x000000018783D578
	}

	[RequireComponent(typeof(Animator))]
	public class UIHudFadeConsoleController : UIHudFadeBase // TypeDefIndex: 80113
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
		public UIHudFadeConsoleController(); // 0x000000018D272A04-0x000000018D272A70
	
		// Methods
		private void Awake(); // 0x000000018D2721F4-0x000000018D2723D0
		private void OnDestroy(); // 0x000000018D272560-0x000000018D2726F8
		public void OnShow(); // 0x000000018D2726F8-0x000000018D2727A8
		private void _CheckNeedShow(); // 0x000000018D2727D0-0x000000018D272970
		private void _OnFadeHud(); // 0x000000018D272970-0x000000018D2729A8
		private void _OnInformShow([IsReadOnly] in EventData<UIStyleInputValidTypeMask> eventData); // 0x000000018D2729A8-0x000000018D272A04
		public void InformShow(); // 0x000000018D2723D0-0x000000018D272560
		[CompilerGenerated]
		private void __CheckNeedShow_b__10_0(); // 0x000000018D2727A8-0x000000018D2727D0
		[CompilerGenerated]
		private void _InformShow_b__13_0(); // 0x000000018D2727A8-0x000000018D2727D0
	}

	[RequireComponent(typeof(CanvasGroup))]
	public class UIHudFadeController : UIHudFadeBase // TypeDefIndex: 80114
	{
		// Fields
		private CanvasGroup m_canvasGroup; // 0x20
		private bool m_curShowing; // 0x28
		private DG.Tweening.Sequence m_fadeSequence; // 0x30
		private readonly HashSet<string> m_hudPreventFadeState; // 0x38
	
		// Properties
		private bool needShow { get; } // 0x0000000185C88D70-0x0000000185C88DC0 
		private GameplayMiscSetting setting { get; } // 0x0000000185C89030-0x0000000185C890A0 
	
		// Constructors
		public UIHudFadeController(); // 0x0000000186D2E450-0x0000000186D2E4E0
	
		// Methods
		private void Awake(); // 0x0000000186BFF170-0x0000000186BFF340
		private void OnDestroy(); // 0x000000018D272A70-0x000000018D272C08
		private void _OnFadeHud(); // 0x0000000185C88B10-0x0000000185C88B40
		private void _CheckNeedShow(); // 0x0000000185C88B40-0x0000000185C88D70
		public void SetLocalNeedShow(string state, bool needShowHud); // 0x0000000185279B90-0x0000000185279BF0
		private void _OnInformShow([IsReadOnly] in EventData<UIStyleInputValidTypeMask> eventData); // 0x0000000185EC6450-0x0000000185EC6490
		public void InformShow(); // 0x0000000185EC6490-0x0000000185EC6520
	}

	[RequireComponent(typeof(UIAnimationWrapper))]
	public class UIHudFadeTouchSkill : UIHudFadeBase // TypeDefIndex: 80115
	{
		// Fields
		private UIAnimationWrapper m_animationWrapper; // 0x20
		private bool m_curShowing; // 0x28
		private bool m_animInOrLoop; // 0x29
		private DG.Tweening.Sequence m_fadeSequence; // 0x30
	
		// Constructors
		public UIHudFadeTouchSkill(); // 0x000000018D273508-0x000000018D273514
	
		// Methods
		private void Awake(); // 0x000000018D272C08-0x000000018D272DAC
		private void OnDestroy(); // 0x000000018D272EC4-0x000000018D27305C
		public void OnShow(); // 0x000000018D27305C-0x000000018D27311C
		private void _CheckNeedShow(); // 0x000000018D273284-0x000000018D273474
		private void _OnFadeHud(); // 0x000000018D273474-0x000000018D2734AC
		private void _OnInformShow([IsReadOnly] in EventData<UIStyleInputValidTypeMask> eventData); // 0x000000018D2734AC-0x000000018D273508
		public void InformShow(); // 0x000000018D272DAC-0x000000018D272EC4
		[CompilerGenerated]
		private void __CheckNeedShow_b__7_0(); // 0x000000018D273258-0x000000018D273284
		[CompilerGenerated]
		private void _InformShow_b__10_0(); // 0x000000018D27311C-0x000000018D273230
		[CompilerGenerated]
		private void _InformShow_b__10_1(); // 0x000000018D273230-0x000000018D273258
	}

	public class BattleControllerInputController : IDisposable // TypeDefIndex: 80117
	{
		// Fields
		[CompilerGenerated]
		private static BattleControllerInputController _instance_k__BackingField; // 0x00
		private GamepadKeyCode m_indicatorKey; // 0x10
		private GamepadKeyCode m_attackKey; // 0x14
		[CompilerGenerated]
		private GamepadKeyCode _comboSkillButtonKey_k__BackingField; // 0x18
		private InputManager.DelayedComboBinding[] m_skillTapCombos; // 0x20
		private InputManager.DelayedComboBinding[] m_skillTriggerCombos; // 0x28
	
		// Properties
		public static BattleControllerInputController instance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000186C3DEF0-0x0000000186C3DF30 0x000000018D26875C-0x000000018D2687AC
		public GamepadKeyCode comboSkillButtonKey { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 80116
		{
			// Fields
			public int charIndex; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __RegisterAllCombos_b__0(); // 0x000000018D271834-0x000000018D2718BC
		}
	
		// Constructors
		private BattleControllerInputController(); // 0x000000018696C540-0x000000018696C650
	
		// Methods
		public static void Create(); // 0x000000018696C430-0x000000018696C540
		public static void DestroyInstance(); // 0x000000018D26826C-0x000000018D2682C0
		public void Dispose(); // 0x000000018D2682C0-0x000000018D2683D0
		public bool GetControllerIndicatorState(); // 0x00000001869F7C30-0x00000001869F7CE0
		public bool CheckNormalAttackBtn(); // 0x0000000186BBF9F0-0x0000000186BBFB40
		public int TryPressControllerIndicatorWhenSkillButtonJustPressed(); // 0x000000018D2683D0-0x000000018D2684A4
		private void _RefreshCachedKeys(); // 0x000000018696C650-0x000000018696C770
		private void _RefreshUltimateMode2Available(); // 0x000000018696C770-0x000000018696C8E0
		private void _RegisterAllCombos(); // 0x000000018696C8E0-0x000000018696CB60
		private void _UnregisterAllCombos(); // 0x000000018D268608-0x000000018D26875C
		private void _OnInputActionKeyUpdated([IsReadOnly] in EventData<string> data); // 0x000000018D2684A4-0x000000018D268608
	}

	public class TyphoeaHudCtrl : TickableUIMono // TypeDefIndex: 80118
	{
		// Fields
		public GameObject frame; // 0x68
		public UIAnimationWrapper aimNode; // 0x70
		public GameObject lockingNode; // 0x78
		public List<TyphoeaHudHintCell> hintCells; // 0x80
		public string arrowBuffId; // 0x88
		public string arrowBuffIdBattle; // 0x90
		public UIAnimationWrapper fullAnimWrapper; // 0x98
		public AnimationCurve scaleCurve; // 0xA0
		private static readonly string AIM_ANIM_IN; // 0x00
		private static readonly string AIM_ANIM_OUT; // 0x08
		private static readonly string AIM_ANIM_LOCK; // 0x10
		private static readonly string AIM_ANIM_LOCK_OUT; // 0x18
		private bool m_aimActive; // 0xA8
		private bool m_aimLocked; // 0xA9
		private UIAnimationWrapper m_frameAnimWrapper; // 0xB0
		private TweenCallback m_cachedAimOutCallback; // 0xB8
		private TweenCallback m_cachedFrameOutCallback; // 0xC0
		private RectTransform m_parentRect; // 0xC8
		private readonly Dictionary<ObjectPtr<AbilitySystem>, UITyphoeaLockingNode> m_lockingDict; // 0xD0
		private readonly Dictionary<ObjectPtr<AbilitySystem>, UITyphoeaLockingNode> m_lockingOutAnimDict; // 0xD8
		private readonly List<UITyphoeaLockingNode> m_lockingPool; // 0xE0
		private static readonly List<ObjectPtr<AbilitySystem>> TO_REMOVE; // 0x20
		private static readonly string TYPHOEA_CHAR_ID; // 0x28
		private ObjectPtr<AbilitySystem> m_hintCharPtr; // 0xE8
		private bool m_allArrowsFull; // 0xF8
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018D271640-0x000000018D271684 
	
		// Constructors
		public TyphoeaHudCtrl(); // 0x000000018D2714A0-0x000000018D271640
		static TyphoeaHudCtrl(); // 0x000000018D2712E8-0x000000018D2714A0
	
		// Methods
		public void OnCreate(); // 0x000000018D26ED00-0x000000018D26F0E0
		public void OnShow(); // 0x000000018D26F1E8-0x000000018D26F2B8
		public void OnHide(); // 0x000000018D26F0E0-0x000000018D26F120
		public void OnClose(); // 0x000000018D26EA74-0x000000018D26ED00
		private void _OnMarkTargetActiveChanged([IsReadOnly] in EventData<bool> eventData); // 0x000000018D26FA7C-0x000000018D26FAC0
		private void _SetMarkTargetActive(bool active); // 0x000000018D270AF4-0x000000018D270D04
		private void _PlayOutAllLockingNodes(); // 0x000000018D2705AC-0x000000018D2707C0
		private void _ClearAllLockingNodes(); // 0x000000018D26F4E4-0x000000018D26F7F8
		[IDTag(1)]
		private void _OnMarkTargetChanged([IsReadOnly] in EventData<Dictionary<ObjectPtr<AbilitySystem>, ObjectPtr<Buff>>> eventData); // 0x000000018D26FAC0-0x000000018D26FB04
		[IDTag(0)]
		private void _OnMarkTargetChanged(Dictionary<ObjectPtr<AbilitySystem>, ObjectPtr<Buff>> selectedTargets); // 0x000000018D26FB04-0x000000018D270328
		private UITyphoeaLockingNode _CreateLocking(); // 0x000000018D26F7F8-0x000000018D26F9E0
		internal void OnLockAimOutAnimComplete(ObjectPtr<AbilitySystem> key, UITyphoeaLockingNode node); // 0x000000018D26F120-0x000000018D26F1E8
		private void _RecycleLocking(UITyphoeaLockingNode node); // 0x000000018D2707C0-0x000000018D270898
		public override void TailLateTick(float deltaTime); // 0x000000018D26F2B8-0x000000018D26F490
		private void _UpdateLockingPositions(Dictionary<ObjectPtr<AbilitySystem>, UITyphoeaLockingNode> dict, Camera mainCamera, Camera uiCamera); // 0x000000018D270E8C-0x000000018D2712E8
		private void _OnSquadChanged(); // 0x000000018D270328-0x000000018D2705AC
		private void _SetHintCellsVisible(bool visible); // 0x000000018D270A20-0x000000018D270AF4
		private void _UpdateHintCells(); // 0x000000018D270D04-0x000000018D270E8C
		private void _ResetHintCellsState(); // 0x000000018D270898-0x000000018D270A20
		private int _GetArrowBuffCount(AbilitySystem charAbility); // 0x000000018D26F9E0-0x000000018D26FA7C
		[CompilerGenerated]
		private void _OnCreate_b__27_0(); // 0x000000018D26F490-0x000000018D26F4C0
		[CompilerGenerated]
		private void _OnCreate_b__27_1(); // 0x000000018D26F4C0-0x000000018D26F4E4
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_TailLateTick(float P0); // 0x0000000184167520-0x0000000184167530
	}

	[Obsolete("\u529F\u80FD\u5DF2\u8FC1\u79FB\u81F3 TyphoeaHudCtrl\uFF0C\u8BF7\u52FF\u7EE7\u7EED\u4F7F\u7528\u6B64\u7C7B\u3002")]
	public class TyphoeaHudHint : TickableMono // TypeDefIndex: 80119
	{
		// Fields
		public TyphoeaHudHintCell cell; // 0x68
	
		// Constructors
		public TyphoeaHudHint(); // 0x000000018503EE80-0x000000018503EE90
	}

	public class TyphoeaHudHintCell : MonoBehaviour // TypeDefIndex: 80120
	{
		// Fields
		public UIAnimationWrapper animWrapper; // 0x18
		private bool m_arrowReady; // 0x20
	
		// Constructors
		public TyphoeaHudHintCell(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void SetArrowEnable(bool enable); // 0x000000018D271714-0x000000018D27179C
		public void ResetState(bool enable); // 0x000000018D271684-0x000000018D271714
	}

	public class UITyphoeaLockingNode : MonoBehaviour // TypeDefIndex: 80121
	{
		// Fields
		public UIAnimationWrapper animWrapper; // 0x18
		public RectTransform rectTransform; // 0x20
		public CanvasGroup canvasGroup; // 0x28
		private TyphoeaHudCtrl m_ownerCtrl; // 0x30
		private TweenCallback m_cachedOutAnimCallback; // 0x38
		private ObjectPtr<AbilitySystem> m_target; // 0x40
	
		// Properties
		public TweenCallback cachedOutAnimCallback { get; } // 0x000000018D2767D4-0x000000018D276814 
	
		// Constructors
		public UITyphoeaLockingNode(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void SetOwner(TyphoeaHudCtrl ctrl); // 0x000000018D276600-0x000000018D2766D4
		public void SetTarget(AbilitySystem target); // 0x000000018D2766D4-0x000000018D27676C
		public void Clear(); // 0x000000018D2765C8-0x000000018D276600
		private void _OnOutAnimComplete(); // 0x000000018D27676C-0x000000018D2767D4
	}

	public class UIAbilityTargetFollower : UIPanelBase // TypeDefIndex: 80122
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
		protected override TickType tickOption { get; } // 0x00000001868A4F30-0x00000001868A4F60 
		protected virtual bool actualVisible { get; } // 0x0000000186516E00-0x0000000186516E30 
		protected virtual bool needUpdateTransform { get; } // 0x00000001864B8BE0-0x00000001864B8CB0 
	
		// Constructors
		public UIAbilityTargetFollower(); // 0x00000001860C2020-0x00000001860C20D0
	
		// Methods
		protected override void OnAwake(); // 0x00000001869EB3E0-0x00000001869EB450
		public override void TailLateTick(float deltaTime); // 0x00000001855E3D60-0x00000001855E3E90
		public virtual void SetTarget(AbilitySystem target); // 0x0000000185FCCEF0-0x0000000185FCD080
		public virtual void Clear(); // 0x0000000185AB6E80-0x0000000185AB6F20
		public virtual bool TryGetOriginalFollowPos(out Vector3 followPos); // 0x00000001855E2EC0-0x00000001855E2FD0
		protected virtual void UpdateData(float deltaTime); // 0x00000001866A6A50-0x00000001866A6A80
		private void _TryRefreshFollowTransform(); // 0x00000001855E3E90-0x00000001855E3F40
		private void _TryRefreshHeightFollowTransform(); // 0x0000000186947AE0-0x0000000186947B50
		private void _UpdateSelfTransform(); // 0x00000001855E3F40-0x00000001855E40C0
		private void _CalculatePosition(); // 0x00000001855E4150-0x00000001855E4720
		private void _UpdatePosition(); // 0x00000001855E4AB0-0x00000001855E5300
		private void _UpdateScale(); // 0x00000001855E4720-0x00000001855E4AB0
		private void _SetDistanceVisible(bool visible); // 0x00000001855E40C0-0x00000001855E4150
		protected void OnActualVisibleChange(bool visible, bool forceUpdate = false /* Metadata: 0x0263C037 */); // 0x000000018642E0B0-0x000000018642E260
		protected Vector3 GetAdjustedHeightOffset(AbilitySystem target); // 0x00000001855E2E40-0x00000001855E2EC0
		[CompilerGenerated]
		private void _OnActualVisibleChange_b__45_0(); // 0x000000018722B670-0x000000018722B680
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D2519E8-0x000000018D2519F0
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_TailLateTick(float P0); // 0x0000000184167520-0x0000000184167530
	}

	public class UILockAim : UIAbilityTargetFollower // TypeDefIndex: 80123
	{
		// Fields
		public CanvasGroup aimGroup; // 0x110
		public UIImage aimRingImage; // 0x118
		public CanvasGroup breakingAttackGroup; // 0x120
		private UIAnimationWrapper m_aimGroupAnimWrapper; // 0x128
	
		// Constructors
		public UILockAim(); // 0x00000001860C0350-0x00000001860C0360
	
		// Methods
		protected override void OnAwake(); // 0x00000001869EB020-0x00000001869EB2C0
		protected override void OnRelease(); // 0x000000018D273514-0x000000018D2737A0
		protected void Start(); // 0x0000000186E2A980-0x0000000186E2A9B0
		private void _OnLockTargetFromAutoToManual(); // 0x000000018D2737A8-0x000000018D27384C
		private void _RefreshTarget(AbilitySystem _ = null); // 0x0000000186E2A9B0-0x0000000186E2AB00
		public void __iFixBaseProxy_OnAwake(); // 0x000000018D2737A0-0x000000018D2737A8
		public void __iFixBaseProxy_OnRelease(); // 0x000000018D25E898-0x000000018D25E8A0
	}

	public class UILockCharacter : UIAbilityTargetFollower // TypeDefIndex: 80124
	{
		// Fields
		public UIAnimationWrapper animWrapper; // 0x110
	
		// Constructors
		public UILockCharacter(); // 0x00000001860C0350-0x00000001860C0360
	
		// Methods
		protected override void OnAwake(); // 0x00000001869EB2C0-0x00000001869EB3E0
		protected override void OnRelease(); // 0x000000018D27384C-0x000000018D273980
		private void _RefreshTarget(AbilitySystem abilitySystem); // 0x000000018D273980-0x000000018D273AD0
		public void __iFixBaseProxy_OnAwake(); // 0x000000018D2737A0-0x000000018D2737A8
		public void __iFixBaseProxy_OnRelease(); // 0x000000018D25E898-0x000000018D25E8A0
	}

	public class UIMainCharFootBar : TickableUIMono // TypeDefIndex: 80125
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
		protected override TickType tickOption { get; } // 0x000000018D275EE8-0x000000018D275F2C 
	
		// Constructors
		public UIMainCharFootBar(); // 0x000000018D275E04-0x000000018D275EE8
		static UIMainCharFootBar(); // 0x000000018D275DA0-0x000000018D275E04
	
		// Methods
		protected override void OnAwake(); // 0x000000018D274DBC-0x000000018D2751A0
		protected override void OnEnable(); // 0x000000018D2751A0-0x000000018D275320
		protected override void OnRelease(); // 0x000000018D275320-0x000000018D2756B8
		private void _OnMainCharChange([IsReadOnly] in EventData<SetLeaderReason, Entity, Entity> data); // 0x000000018D275B84-0x000000018D275C2C
		private void _ProcessOnMainCharChange(); // 0x000000018D275C6C-0x000000018D275D04
		public override void LateTick(float deltaTime); // 0x000000018D27444C-0x000000018D274DBC
		private void _OnDashCountChanged(float curCount); // 0x000000018D2756B8-0x000000018D2759E0
		private void _OnDashFailed(); // 0x000000018D2759E0-0x000000018D275AA0
		private void _OnInteractNpc([IsReadOnly] in EventData<string, Entity> eventData); // 0x000000018D275B40-0x000000018D275B84
		private void _OnDialogStart([IsReadOnly] in EventData<bool, DialogEnums.DialogType> eventData); // 0x000000018D275AE4-0x000000018D275B40
		private void _OnDialogFinish([IsReadOnly] in EventData<bool> eventData); // 0x000000018D275AA0-0x000000018D275AE4
		private void _SetInDialog(bool inDialog); // 0x000000018D275D04-0x000000018D275DA0
		private void _OnOutAnimCallback(); // 0x000000018D275C2C-0x000000018D275C6C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public class UIMainCharFootBarArc : TickableUIMono // TypeDefIndex: 80127
	{
		// Fields
		private const string NOT_ENOUGH_ANIM_NAME = "characterfootbararc_greenfootbar_flashingred"; // Metadata: 0x0263C038
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
		[SerializeField]
		private CanvasGroup _splitBarNode; // 0xF0
		[SerializeField]
		private UIStateController _splitBarStateController; // 0xF8
		[SerializeField]
		private UIImage _splitDashFill; // 0x100
		[SerializeField]
		private UIImage _splitDashFillLow; // 0x108
		[SerializeField]
		private UIImage _splitDashFillWhite; // 0x110
		[SerializeField]
		private SplitDashAnimation _splitDashFailedAnimation; // 0x118
		[SerializeField]
		private SplitDashAnimation[] _splitDashRecoverAnimations; // 0x120
		private CanvasGroup m_canvasGroup; // 0x128
		private CanvasGroup m_footBarCanvasGroup; // 0x130
		private Entity m_mainChar; // 0x138
		private bool m_dashBarNeedShow; // 0x140
		private bool m_dashBarShowing; // 0x141
		private Transform m_target; // 0x148
		private Vector3 m_smoothVelocity; // 0x150
		private bool m_notEnoughAnimShowing; // 0x15C
		private float m_originalScale; // 0x160
		private float m_dampingScale; // 0x164
		private readonly PeriodicTimer m_fillWhiteStayTimer; // 0x168
		private readonly PeriodicTimer m_dashFailedAnimTimer; // 0x170
		private readonly HashSet<string> m_disableState; // 0x178
		private TweenCallback m_cachedOnOutAnimCallback; // 0x180
		private float m_curDashCellCount; // 0x188
		private float m_curDashFillAmount; // 0x18C
		private UIHeadBar.HpDisplayState m_dashWhiteState; // 0x190
		private bool m_usingSplitBar; // 0x194
		private float m_lastSplitDashFillCount; // 0x198
		private Dictionary<int, string> m_dashCountStateNames; // 0x1A0
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000186B17940-0x0000000186B17970 
	
		// Nested types
		[Serializable]
		private class SplitDashAnimation // TypeDefIndex: 80126
		{
			// Fields
			[SerializeField]
			private UIAnimationWrapper _animation; // 0x10
			[SerializeField]
			private CanvasGroup _canvasGroup; // 0x18
			private TweenCallback m_onInAnimationFinished; // 0x20
	
			// Constructors
			public SplitDashAnimation(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Play(); // 0x0000000184F11E80-0x0000000184F12640
			public void Stop(); // 0x0000000184F12640-0x0000000184F126F0
			private void _OnInAnimationFinished(); // 0x0000000184F126F0-0x0000000184F12790
		}
	
		// Constructors
		public UIMainCharFootBarArc(); // 0x0000000186BC7BA0-0x0000000186BC9860
	
		// Methods
		protected override void OnAwake(); // 0x0000000186819C40-0x000000018681CEB0
		protected override void OnEnable(); // 0x00000001865ED6E0-0x00000001865EE180
		protected override void OnDisable(); // 0x0000000184F12790-0x0000000184F127F0
		protected override void OnRelease(); // 0x000000018D273AD0-0x000000018D273FC8
		private void _OnMainCharChange([IsReadOnly] in EventData<SetLeaderReason, Entity, Entity> data); // 0x000000018D2742C4-0x000000018D274328
		private void _ProcessOnMainCharChange(); // 0x00000001865EE180-0x00000001865EE200
		public override void TailLateTick(float deltaTime); // 0x00000001857615B0-0x0000000185762DE0
		private void _RefreshBarMode(bool useSplitBar, float dashCount, float dashFillCount); // 0x0000000184F127F0-0x0000000184F13610
		private void _UpdateSplitDashRecoverAnimations(float dashFillCount); // 0x0000000184F136C0-0x0000000184F137E0
		private void _StopSplitDashAnimations(); // 0x0000000184F13610-0x0000000184F136C0
		private void _OnDashCountChanged(float curCount); // 0x000000018709D460-0x000000018709DA40
		private void _OnDashFailed(); // 0x000000018D273FC8-0x000000018D27419C
		private void _OnInteractNpc([IsReadOnly] in EventData<string, Entity> eventData); // 0x000000018D274280-0x000000018D2742C4
		private void _OnDialogStart([IsReadOnly] in EventData<bool, DialogEnums.DialogType> eventData); // 0x000000018D2741E0-0x000000018D27423C
		private void _OnDialogFinish([IsReadOnly] in EventData<bool> eventData); // 0x000000018D27419C-0x000000018D2741E0
		private void _OnPlayCutscene([IsReadOnly] in EventData<CinematicTimelineManagerBase.TimelineHandle> eventData); // 0x000000018D274328-0x000000018D27436C
		private void _OnFinishCutscene([IsReadOnly] in EventData<bool> eventData); // 0x000000018D27423C-0x000000018D274280
		private void _OnForbidSystemChanged([IsReadOnly] in EventData<ForbidType, bool> eventData); // 0x0000000186791B30-0x0000000186791B60
		private void _SetInDialog(bool inDialog); // 0x000000018D27436C-0x000000018D27444C
		public void SetUIDisable(string key, bool disable); // 0x00000001869E4080-0x00000001869E4160
		private void _RefreshDisableState(); // 0x00000001869E4160-0x00000001869E42A0
		private void _OnOutAnimCallback(); // 0x00000001871F9BB0-0x00000001871F9C00
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_OnDisable(); // 0x00000001828D23D0-0x00000001828D23E0
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
		public void __iFixBaseProxy_TailLateTick(float P0); // 0x0000000184167520-0x0000000184167530
	}

	public class UIPoiseKnot : MonoBehaviour // TypeDefIndex: 80128
	{
		// Fields
		[SerializeField]
		private CanvasGroup _canvasGroup; // 0x18
		[SerializeField]
		private UIAnimationWrapper _animationWrapper; // 0x20
	
		// Constructors
		public UIPoiseKnot(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		public void SetVisible(bool visible); // 0x0000000185974F40-0x0000000185974F90
		public void KnotBreak(); // 0x000000018D275F2C-0x000000018D275F98
	}

	public class UIWeakLockAim : UIAbilityTargetFollower // TypeDefIndex: 80129
	{
		// Fields
		public CanvasGroup aimGroup; // 0x110
	
		// Constructors
		public UIWeakLockAim(); // 0x00000001860C0350-0x00000001860C0360
	
		// Methods
		protected override void OnAwake(); // 0x0000000186819900-0x0000000186819A10
		protected void Start(); // 0x00000001871FB8A0-0x00000001871FB8F0
		protected override void OnRelease(); // 0x000000018D276814-0x000000018D276974
		private void _OnMainTargetChanged([IsReadOnly] in EventData<AbilitySystem, bool> data); // 0x0000000185FCB770-0x0000000185FCB7A0
		private void _RefreshTarget(); // 0x0000000185FCB7A0-0x0000000185FCB8D0
		public void __iFixBaseProxy_OnAwake(); // 0x000000018D2737A0-0x000000018D2737A8
		public void __iFixBaseProxy_OnRelease(); // 0x000000018D25E898-0x000000018D25E8A0
	}

	public class BlueprintPreviewHelper // TypeDefIndex: 80130
	{
		// Fields
		private ushort[][] m_data; // 0x10
		private int m_width; // 0x18
		private int m_height; // 0x1C
	
		// Constructors
		public BlueprintPreviewHelper(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void SetSize(int width, int height); // 0x000000018D268BAC-0x000000018D268D44
		public void AddGridValue(int x, int y, byte value); // 0x000000018D2687AC-0x000000018D26891C
		public void BatchAddGridValue(int xMin, int yMin, int width, int height, byte value); // 0x000000018D26891C-0x000000018D268AF8
		public byte GetGridValue(int x, int y, out byte value2); // 0x000000018D268AF8-0x000000018D268BAC
	}

	public class CommonTrackerNodeComp : MonoBehaviour // TypeDefIndex: 80131
	{
		// Fields
		public UIBlackboxTracker blackboxTracker; // 0x18
		public UICampfireTracker campfireTracker; // 0x20
		public UICommonTracker commonTracker; // 0x28
		public UICommonLevelTracker commonLevelTracker; // 0x30
		private const float TOO_FAR_DISTANCE = 15f; // Metadata: 0x0263C065
	
		// Constructors
		public CommonTrackerNodeComp(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		public void ShowStyleType(CommonTrackingPointStyleType styleType, CommonTrackingPointInfoBase trackerData); // 0x00000001861E63C0-0x00000001861E6590
		public void PlayOutAnimation(CommonTrackingPointStyleType styleType); // 0x000000018D268D44-0x000000018D268DD8
		public void UpdatePosition(CommonTrackingPointInfoBase trackerData); // 0x00000001856453D0-0x0000000185645510
	}

	public class CommonTrackerUpdate : MonoBehaviour // TypeDefIndex: 80136
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
		private bool _inFactoryTopView { get; } // 0x0000000185644DC0-0x0000000185644EE0 
	
		// Nested types
		public enum CommonTrackItemState // TypeDefIndex: 80132
		{
			Show = 0,
			Hide = 1,
			ShowToHide = 2
		}
	
		public enum CommonTrackerDataState // TypeDefIndex: 80133
		{
			Active = 0,
			InActive = 1
		}
	
		public class CommonTrackerData // TypeDefIndex: 80134
		{
			// Fields
			public CommonTrackerDataState activeState; // 0x10
			public CommonTrackingPointInfoBase trackData; // 0x18
			public string key; // 0x20
	
			// Constructors
			public CommonTrackerData(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public class CommonTrackerItem // TypeDefIndex: 80135
		{
			// Fields
			public CommonTrackItemState showState; // 0x10
			public GameObject obj; // 0x18
			public CommonTrackerNodeComp commonTrackerNodeComp; // 0x20
	
			// Constructors
			public CommonTrackerItem(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public CommonTrackerUpdate(); // 0x0000000186EA6860-0x0000000186EA6970
		static CommonTrackerUpdate(); // 0x0000000187220970-0x00000001872209B0
	
		// Methods
		public void UpdateCommonTrackers(bool missionHudOpen, int onShowSignal); // 0x0000000185644680-0x0000000185644990
		public void AllTrackersPlayOutAnimation(); // 0x0000000186E79A30-0x0000000186E79AC0
		private bool _InitTrackInfoByIndex(int trackerIdx, string key, CommonTrackingPointInfoBase trackData); // 0x0000000185645120-0x0000000185645240
		private CommonTrackerItem _CreateNewMissionTracker(); // 0x0000000186D1F650-0x0000000186D1F800
		private void _DeleteInvalidTracker(); // 0x0000000185644EE0-0x0000000185645050
		private void _ShowTrackerGo(CommonTrackerItem trackerItem, CommonTrackingPointInfoBase trackerData); // 0x00000001861E6340-0x00000001861E63C0
		private void _HideTrackerGo(CommonTrackerItem trackerItem); // 0x0000000185645380-0x00000001856453D0
		private int _FindTrackIndexByKey(string key); // 0x0000000185645050-0x0000000185645120
	}

	public class UIBlackboxTracker : MonoBehaviour // TypeDefIndex: 80137
	{
		// Fields
		public RectTransform rectTransform; // 0x18
		public RectTransform arrowRotator; // 0x20
		public UIAnimationWrapper animationWrapper; // 0x28
		public UIText distanceTxt; // 0x30
	
		// Constructors
		public UIBlackboxTracker(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		public void UpdatePosition(Vector2 uiPos, float uiAngle, bool isOutBound, float distance, bool needShowDistance); // 0x000000018D271CB8-0x000000018D271F40
	}

	public class UICampfireTracker : MonoBehaviour // TypeDefIndex: 80138
	{
		// Fields
		public RectTransform rectTransform; // 0x18
		public RectTransform arrowRotator; // 0x20
		public UIAnimationWrapper animationWrapper; // 0x28
		public UIImage image; // 0x30
		private const string ORG_ICON = "Map/MarkIconSmall/campfire_icon"; // Metadata: 0x0263C06E
	
		// Constructors
		public UICampfireTracker(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		public void UpdatePosition(Vector2 uiPos, float uiAngle, bool isOutBound, float distance, bool needShowDistance); // 0x00000001856445A0-0x0000000185644680
		public void UpdateImage(CommonTrackingPointInfoBase trackerData); // 0x00000001861E62A0-0x00000001861E6340
	}

	public class UICommonLevelTracker : MonoBehaviour // TypeDefIndex: 80139
	{
		// Fields
		public RectTransform rectTransform; // 0x18
		public RectTransform arrowRotator; // 0x20
		public UIAnimationWrapper animationWrapper; // 0x28
		public UIText distanceTxt; // 0x30
	
		// Constructors
		public UICommonLevelTracker(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		public void UpdatePosition(PosValueState posValueState, bool needShowDistance, Vector2 uiPos, float uiAngle, bool isOutBound, float distance, CommonTrackMapTier mapTier = CommonTrackMapTier.Current /* Metadata: 0x0263C08E */); // 0x000000018D271F40-0x000000018D2721F4
	}

	public class UICommonTracker : MonoBehaviour // TypeDefIndex: 80140
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
		private const string ORG_ICON = "Map/MarkIconSmall/general_track_other_level"; // Metadata: 0x0263C090
	
		// Constructors
		public UICommonTracker(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		public void UpdateImage(CommonTrackingPointInfoBase trackerData); // 0x00000001861E5DF0-0x00000001861E5EA0
		public void UpdatePosition(PosValueState posValueState, bool needShowDistance, Vector2 uiPos, float uiAngle, bool isOutBound, float distance, CommonTrackMapTier mapTier = CommonTrackMapTier.Current /* Metadata: 0x0263C08F */); // 0x00000001865E0340-0x00000001865E1560
	}

	public class CoolerUnitProgressBarUI : WorldUIController // TypeDefIndex: 80141
	{
		// Fields
		private Entity m_targetEntity; // 0xC0
		private CoolerUnitComponent m_coolerUnitComponent; // 0xC8
		private float m_displayProgress; // 0xD0
		private const float LERP_SPEED = 5f; // Metadata: 0x0263C0BC
		private const float MAX_STEP = 0.07f; // Metadata: 0x0263C0C0
		public UIText progressDesc; // 0xD8
		public UIText progressText; // 0xE0
		public UIImage progressImage; // 0xE8
		public Transform progressUIRoot; // 0xF0
		private CanvasGroup m_canvasGroup; // 0xF8
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018D26965C-0x000000018D2696A0 
	
		// Constructors
		public CoolerUnitProgressBarUI(); // 0x000000018503EE80-0x000000018503EE90
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018D268DD8-0x000000018D269048
		public override void SetUIForward(); // 0x000000018D269178-0x000000018D2692F8
		public override void SetPos(); // 0x000000018D269048-0x000000018D269178
		public override void TickUI(float deltaTime); // 0x000000018D2692F8-0x000000018D26936C
		private void _TickCanvasGroup(float deltaTime); // 0x000000018D26939C-0x000000018D2694D0
		private void _UpdateProgress(float deltaTime); // 0x000000018D2694D0-0x000000018D26965C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D269394-0x000000018D26939C
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3); // 0x000000018D26936C-0x000000018D26937C
		public void __iFixBaseProxy_SetUIForward(); // 0x000000018D269384-0x000000018D26938C
		public void __iFixBaseProxy_SetPos(); // 0x000000018D26937C-0x000000018D269384
		public void __iFixBaseProxy_TickUI(float P0); // 0x000000018D26938C-0x000000018D269394
	}

	public class CoolerUnitTemperatureCircleUI : WorldUIController // TypeDefIndex: 80144
	{
		// Fields
		private const string AUDIO_EVENT_SUCCEED = "au_int_forge_iron_success"; // Metadata: 0x0263C0C4
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
		protected override TickType tickOption { get; } // 0x000000018D26A2C8-0x000000018D26A30C 
	
		// Nested types
		public enum ETemperatureState // TypeDefIndex: 80142
		{
			None = 0,
			Low = 1,
			Safe = 2,
			High = 3,
			Finish = 4
		}
	
		public static class CoolerUnitLangKeys // TypeDefIndex: 80143
		{
			// Fields
			public const string TOO_COLD = "lang_int_forgeiron_TempTooCold"; // Metadata: 0x0263C0E3
			public const string GOOD = "lang_int_forgeiron_TempGood"; // Metadata: 0x0263C102
			public const string TOO_HOT = "lang_int_forgeiron_TempTooHot"; // Metadata: 0x0263C11E
			public const string FINISH = "lang_int_forgeiron_Finish"; // Metadata: 0x0263C13C
		}
	
		// Constructors
		public CoolerUnitTemperatureCircleUI(); // 0x000000018503EE80-0x000000018503EE90
		static CoolerUnitTemperatureCircleUI(); // 0x000000018D26A250-0x000000018D26A2C8
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018D2696A0-0x000000018D2699F4
		public override void SetUIForward(); // 0x000000018D269B24-0x000000018D269CA4
		public override void SetPos(); // 0x000000018D2699F4-0x000000018D269B24
		public override void TickUI(float deltaTime); // 0x000000018D269CA4-0x000000018D269D38
		private void _TickCanvasGroup(float deltaTime); // 0x000000018D26A084-0x000000018D26A1B8
		private void _UpdateUIState(); // 0x000000018D26A1B8-0x000000018D26A250
		private void _SetState(ETemperatureState state); // 0x000000018D269D98-0x000000018D26A084
		private string _GetLangKeyOrDefault(LangKey customKey, string defaultKey); // 0x000000018D269D38-0x000000018D269D98
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D269394-0x000000018D26939C
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3); // 0x000000018D26936C-0x000000018D26937C
		public void __iFixBaseProxy_SetUIForward(); // 0x000000018D269384-0x000000018D26938C
		public void __iFixBaseProxy_SetPos(); // 0x000000018D26937C-0x000000018D269384
		public void __iFixBaseProxy_TickUI(float P0); // 0x000000018D26938C-0x000000018D269394
	}

	public class CoolerUnitTemperatureUI : WorldUIController // TypeDefIndex: 80146
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
		private const float COLOR_EPS = 0.02f; // Metadata: 0x0263C156
		private const float SNAP_THRESHOLD = 0.25f; // Metadata: 0x0263C15A
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018D26B370-0x000000018D26B3B4 
	
		// Nested types
		private enum TempColorState // TypeDefIndex: 80145
		{
			Blue = 0,
			Green = 1,
			Red = 2
		}
	
		// Constructors
		public CoolerUnitTemperatureUI(); // 0x000000018D26B35C-0x000000018D26B370
		static CoolerUnitTemperatureUI(); // 0x000000018D26B2BC-0x000000018D26B35C
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018D26A374-0x000000018D26A514
		public override void Clear(); // 0x000000018D26A30C-0x000000018D26A374
		public override void SetUIForward(); // 0x000000018D26A69C-0x000000018D26A81C
		public override void SetPos(); // 0x000000018D26A56C-0x000000018D26A69C
		public override void TickUI(float deltaTime); // 0x000000018D26A81C-0x000000018D26A89C
		private void _TickCanvasGroup(float deltaTime); // 0x000000018D26A8A4-0x000000018D26A9D8
		public void NormalizeRange(ref float min, ref float max); // 0x000000018D26A514-0x000000018D26A56C
		private void _UpdateUIInfo(float deltaTime); // 0x000000018D26A9D8-0x000000018D26AE40
		private void _UpdateUIPos(float deltaTime); // 0x000000018D26AE40-0x000000018D26B2BC
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D269394-0x000000018D26939C
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3); // 0x000000018D26936C-0x000000018D26937C
		public void __iFixBaseProxy_Clear(); // 0x000000018D26A89C-0x000000018D26A8A4
		public void __iFixBaseProxy_SetUIForward(); // 0x000000018D269384-0x000000018D26938C
		public void __iFixBaseProxy_SetPos(); // 0x000000018D26937C-0x000000018D269384
		public void __iFixBaseProxy_TickUI(float P0); // 0x000000018D26938C-0x000000018D269394
	}

	public class CoolerUnitTotalProgressBarUI : WorldUIController // TypeDefIndex: 80147
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
		protected override TickType tickOption { get; } // 0x000000018D26BD50-0x000000018D26BD94 
	
		// Constructors
		public CoolerUnitTotalProgressBarUI(); // 0x000000018D26BD3C-0x000000018D26BD50
		static CoolerUnitTotalProgressBarUI(); // 0x000000018D26BCEC-0x000000018D26BD3C
	
		// Methods
		private static string[] _GeneratePercentStrings(); // 0x000000018D26B6D4-0x000000018D26B7B0
		public override void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018D26B3B4-0x000000018D26B484
		private void _ResetUI(); // 0x000000018D26B848-0x000000018D26B8C8
		private void _GetCanvas(); // 0x000000018D26B7B0-0x000000018D26B848
		private bool _TryGetModule(ulong id); // 0x000000018D26BAE8-0x000000018D26BC08
		public override void SetUIForward(); // 0x000000018D26B520-0x000000018D26B660
		public override void SetPos(); // 0x000000018D26B484-0x000000018D26B520
		public override void TickUI(float deltaTime); // 0x000000018D26B660-0x000000018D26B6D4
		private void _TickCanvasGroup(float deltaTime); // 0x000000018D26B9B4-0x000000018D26BAE8
		private void _UpdateProgress(float deltaTime); // 0x000000018D26BC08-0x000000018D26BCEC
		private void _SetProgressText(int percent); // 0x000000018D26B8C8-0x000000018D26B9B4
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D269394-0x000000018D26939C
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3); // 0x000000018D26936C-0x000000018D26937C
		public void __iFixBaseProxy_SetUIForward(); // 0x000000018D269384-0x000000018D26938C
		public void __iFixBaseProxy_SetPos(); // 0x000000018D26937C-0x000000018D269384
		public void __iFixBaseProxy_TickUI(float P0); // 0x000000018D26938C-0x000000018D269394
	}

	public class DoodadFactoryGasCoreScanUI : WorldUIController // TypeDefIndex: 80148
	{
		// Fields
		private Entity m_targetEntity; // 0xC0
		private FactoryGasCoreComponent m_coreComponent; // 0xC8
		private FactoryGasCoreComponentData m_instanceData; // 0xD0
		private string m_domainId; // 0xD8
		public UIText gasCoreName; // 0xE0
		public Transform icon; // 0xE8
		public Transform high; // 0xF0
		public Transform low; // 0xF8
		private UIText m_lowText; // 0x100
		private UIText m_highText; // 0x108
		public const int LEVEL_ONE = 1; // Metadata: 0x0263C161
		public const int LEVEL_TWO = 2; // Metadata: 0x0263C162
		public const int LEVEL_THREE = 3; // Metadata: 0x0263C163
		public const int LEVEL_FOUR = 4; // Metadata: 0x0263C164
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018D26CB30-0x000000018D26CB74 
	
		// Constructors
		public DoodadFactoryGasCoreScanUI(); // 0x000000018503EE80-0x000000018503EE90
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018D26C0C8-0x000000018D26C158
		public override void DoRelease(); // 0x000000018D26BD94-0x000000018D26BE74
		public override void SetUIForward(); // 0x000000018D26C6C4-0x000000018D26C854
		public override void SetPos(); // 0x000000018D26C4A8-0x000000018D26C6C4
		public override void TickUI(float deltaTime); // 0x000000018D26C854-0x000000018D26C890
		public override void InitUI(); // 0x000000018D26BE74-0x000000018D26C0C8
		public override void RefreshUI(); // 0x000000018D26C158-0x000000018D26C4A8
		private void _BindDomainChange(); // 0x000000018D26C8A8-0x000000018D26C9B0
		private void _UnbindDomainChange(); // 0x000000018D26CA2C-0x000000018D26CB30
		private void _OnDomainDevelopmentChange([IsReadOnly] in EventData<string, uint, ulong> data); // 0x000000018D26C9B0-0x000000018D26CA2C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D269394-0x000000018D26939C
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3); // 0x000000018D26936C-0x000000018D26937C
		public void __iFixBaseProxy_DoRelease(); // 0x000000018D26C890-0x000000018D26C898
		public void __iFixBaseProxy_SetUIForward(); // 0x000000018D269384-0x000000018D26938C
		public void __iFixBaseProxy_SetPos(); // 0x000000018D26937C-0x000000018D269384
		public void __iFixBaseProxy_TickUI(float P0); // 0x000000018D26938C-0x000000018D269394
		public void __iFixBaseProxy_InitUI(); // 0x000000018D26C898-0x000000018D26C8A0
		public void __iFixBaseProxy_RefreshUI(); // 0x000000018D26C8A0-0x000000018D26C8A8
	}

	public class DoodadFactoryGasScanUI : WorldUIController // TypeDefIndex: 80149
	{
		// Fields
		private Entity m_targetEntity; // 0xC0
		private FactoryGasComponent m_coreComponent; // 0xC8
		public UIText gasName; // 0xD0
		private static readonly string X_OFFSET; // 0x00
		private static readonly string Z_OFFSET; // 0x08
		private static readonly string Y_OFFSET; // 0x10
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018D26D330-0x000000018D26D374 
	
		// Constructors
		public DoodadFactoryGasScanUI(); // 0x000000018503EE80-0x000000018503EE90
		static DoodadFactoryGasScanUI(); // 0x000000018D26D25C-0x000000018D26D330
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018D26CCC4-0x000000018D26CD48
		public override void DoRelease(); // 0x000000018D26CB74-0x000000018D26CBEC
		public override void SetUIForward(); // 0x000000018D26D090-0x000000018D26D220
		public override void SetPos(); // 0x000000018D26CD48-0x000000018D26D090
		public override void TickUI(float deltaTime); // 0x000000018D26D220-0x000000018D26D25C
		public override void InitUI(); // 0x000000018D26CBEC-0x000000018D26CCC4
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D269394-0x000000018D26939C
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3); // 0x000000018D26936C-0x000000018D26937C
		public void __iFixBaseProxy_DoRelease(); // 0x000000018D26C890-0x000000018D26C898
		public void __iFixBaseProxy_SetUIForward(); // 0x000000018D269384-0x000000018D26938C
		public void __iFixBaseProxy_SetPos(); // 0x000000018D26937C-0x000000018D269384
		public void __iFixBaseProxy_TickUI(float P0); // 0x000000018D26938C-0x000000018D269394
		public void __iFixBaseProxy_InitUI(); // 0x000000018D26C898-0x000000018D26C8A0
	}

	public class FacLineCell : MonoBehaviour // TypeDefIndex: 80151
	{
		// Fields
		private const float HSV_VALUE_RATIO = 1.6f; // Metadata: 0x0263C165
		[SerializeField]
		private RectTransform _rectTransform; // 0x18
		public RectTransform topAgent; // 0x20
		public RectTransform bottomAgent; // 0x28
		public UIAnimationWrapper lineAnimationWrapper; // 0x30
		public UIAnimationWrapper decoAnimationWrapper; // 0x38
		private List<UIImage> m_imageList; // 0x40
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 80150
		{
			// Fields
			public FacLineCell __4__this; // 0x10
			public TweenCallback callback; // 0x18
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _PlayLineDecoAnimation_b__0(); // 0x000000018D271C04-0x000000018D271C54
		}
	
		// Constructors
		public FacLineCell(); // 0x0000000186D2D620-0x0000000186D2D6B0
	
		// Methods
		private void Awake(); // 0x000000018D26D374-0x000000018D26D4C8
		public void PlayLineAnimation(string animationName, TweenCallback callback = null); // 0x000000018D26D7A8-0x000000018D26D898
		public void PlayLineDecoAnimation(string animationName, TweenCallback callback = null); // 0x000000018D26D898-0x000000018D26DA34
		public void ChangeLineColor(UnityEngine.Color color); // 0x000000018D26D4C8-0x000000018D26D720
		public void ChangeLineWidth(float width); // 0x000000018D26D720-0x000000018D26D7A8
	}

	public class FacLineDrawer : MonoBehaviour, IUIClearable // TypeDefIndex: 80153
	{
		// Fields
		private RectTransform m_rectTransform; // 0x18
		private readonly Dictionary<uint, LineData> m_lineCache; // 0x20
		private readonly List<GameObject> m_instantiatedLineCell; // 0x28
		private uint m_nextLineId; // 0x30
		private const uint INVALID_LINE_ID = 0; // Metadata: 0x0263C169
		public RectTransform startDrawAgent; // 0x38
		public RectTransform endDrawAgent; // 0x40
		public GameObject linkLinePrefab; // 0x48
	
		// Nested types
		private struct LineData // TypeDefIndex: 80152
		{
			// Fields
			public FacLineCell start; // 0x00
			public FacLineCell end; // 0x08
			public FacLineCell link; // 0x10
		}
	
		// Constructors
		public FacLineDrawer(); // 0x0000000186F820B0-0x0000000186F82190
	
		// Methods
		private void Awake(); // 0x000000018D26DA34-0x000000018D26DAB8
		private void OnDestroy(); // 0x000000018D26E358-0x000000018D26E390
		private void _Clear(); // 0x000000018D26E664-0x000000018D26E820
		private GameObject _CloneLineObject(GameObject sourceObject, Transform locateTransform); // 0x000000018D26E820-0x000000018D26E968
		private void _RefreshCopyLineObjectColor(GameObject lineObject, UnityEngine.Color color); // 0x000000018D26E968-0x000000018D26EA74
		public void ClearComponent(); // 0x000000018D26DBE4-0x000000018D26DC1C
		public uint DrawLine(FacLineCell start, FacLineCell end); // 0x000000018D26DC54-0x000000018D26E358
		public void PlayLineAnimation(uint lineId, string animationName, TweenCallback callback = null); // 0x000000018D26E390-0x000000018D26E518
		public void PlayPortLineDecoAnimation(uint lineId, string animationName, bool isStart, TweenCallback callback = null); // 0x000000018D26E518-0x000000018D26E664
		public void ChangeLineColor(uint lineId, UnityEngine.Color color); // 0x000000018D26DAB8-0x000000018D26DBE4
		public void ClearDrawer(); // 0x000000018D26DC1C-0x000000018D26DC54
	}

	public class FacPipeAnimationSetting : MonoBehaviour // TypeDefIndex: 80154
	{
		// Fields
		private const string PIPE_ANIMATION_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Animations/Factory/pipecell"; // Metadata: 0x0263C16A
		public string decoInAnimation; // 0x18
		public string decoOutAnimation; // 0x20
		public string itemAnimation; // 0x28
		public bool needBoldAnimations; // 0x30
		public string boldDecoInAnimation; // 0x38
		public string boldDecoOutAnimation; // 0x40
		public string boldItemAnimation; // 0x48
	
		// Constructors
		public FacPipeAnimationSetting(); // 0x000000018548CC60-0x000000018548CC80
	}

	public class FacRegionUpgradeEffectController : MonoBehaviour // TypeDefIndex: 80155
	{
		// Fields
		[SerializeField]
		private GameObject _waitUpgradeNode; // 0x18
		[SerializeField]
		private GameObject _upgradedRegionNode; // 0x20
		[SerializeField]
		private GameObject _waitUpgradeSelectNode; // 0x28
	
		// Constructors
		public FacRegionUpgradeEffectController(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void _RefreshNodeState(GameObject node, bool active); // 0x000000018D276F58-0x000000018D277014
		public void SetUpgradeState(bool isUpgraded); // 0x000000018D276E64-0x000000018D276EEC
		public void SetSelectState(bool isSelected); // 0x000000018D276DEC-0x000000018D276E64
		public void SetVisibleState(bool isVisible); // 0x000000018D276EEC-0x000000018D276F58
	}

	public class UIFacTechTreePanel : UIPanelBase // TypeDefIndex: 80156
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
		protected override TickType tickOption { get; } // 0x000000018D27BDEC-0x000000018D27BE30 
	
		// Constructors
		public UIFacTechTreePanel(); // 0x000000018D27BD94-0x000000018D27BDEC
	
		// Methods
		protected override void OnRelease(); // 0x000000018D27A69C-0x000000018D27A714
		public override void Tick(float deltaTime); // 0x000000018D27A7C4-0x000000018D27A838
		public void InitData(); // 0x000000018D27A2AC-0x000000018D27A4C4
		private void _OnDrag(Vector2 value); // 0x000000018D27ADDC-0x000000018D27AE84
		private void _OnZoom(float value, bool needTween); // 0x000000018D27AFF0-0x000000018D27B1A0
		private void _SetScale(bool needTween, float zoomTweenTime = 0f /* Metadata: 0x0263C1AF */, AnimationCurve curve = null, TweenCallback onFinish = null); // 0x000000018D27B848-0x000000018D27BB8C
		private void _RefreshAll(); // 0x000000018D27B404-0x000000018D27B490
		private void _PosAdjust(); // 0x000000018D27B1A0-0x000000018D27B404
		private void _RefreshPivotPosition(); // 0x000000018D27B490-0x000000018D27B848
		private void _UpdatePositionOffsetAfterZoomed(); // 0x000000018D27BB8C-0x000000018D27BD94
		public void MoveNode(float dis, float nodeX, float nodeY, bool ignorePos = false /* Metadata: 0x0263C1B3 */); // 0x000000018D27A4C4-0x000000018D27A69C
		public void FocusNode(float nodeX, float nodeY, TweenCallback onComplete); // 0x000000018D27A238-0x000000018D27A2AC
		public void OnUnlockTech(float nodeX, float nodeY, TweenCallback onComplete); // 0x000000018D27A714-0x000000018D27A788
		public void ZoomToFullTechTree(TweenCallback onComplete); // 0x000000018D27A990-0x000000018D27A9FC
		private void _OnUnlockMoveNode(float nodeX, float nodeY); // 0x000000018D27AE84-0x000000018D27AFF0
		private void _ControllerUpdate(); // 0x000000018D27ABEC-0x000000018D27AC98
		private void _ControllerZoomUpdate(); // 0x000000018D27AC98-0x000000018D27ADDC
		private void _ControllerDragUpdate(); // 0x000000018D27A9FC-0x000000018D27ABEC
		public void SetDetailShownState(bool isShown); // 0x000000018D27A788-0x000000018D27A7C4
		[CompilerGenerated]
		private void _InitData_b__39_0(PointerEventData eventData); // 0x000000018D27A838-0x000000018D27A8C4
		[CompilerGenerated]
		private void _InitData_b__39_1(float zoomValue); // 0x000000018D27A8C4-0x000000018D27A934
		[CompilerGenerated]
		private void _InitData_b__39_2(); // 0x000000018D27A934-0x000000018D27A990
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D2519E8-0x000000018D2519F0
		public void __iFixBaseProxy_OnRelease(); // 0x000000018D25E898-0x000000018D25E8A0
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	public class ForgeIronProgressBarUI : WorldUIController // TypeDefIndex: 80157
	{
		// Fields
		public UIText progressDesc; // 0xC0
		public UIText progressText; // 0xC8
		public UIImage progressImage; // 0xD0
		public Transform progressUIRoot; // 0xD8
		private InteractiveLogicForgeIron m_logic; // 0xE0
		private CanvasGroup m_canvasGroup; // 0xE8
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018D277908-0x000000018D27794C 
	
		// Constructors
		public ForgeIronProgressBarUI(); // 0x000000018503EE80-0x000000018503EE90
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018D277014-0x000000018D277140
		public override void SetPos(); // 0x000000018D277140-0x000000018D277284
		public override void SetUIForward(); // 0x000000018D277284-0x000000018D2774D0
		public override void TickUI(float deltaTime); // 0x000000018D2774D0-0x000000018D2775D8
		public void UpdateProgress(); // 0x000000018D2775D8-0x000000018D277908
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D269394-0x000000018D26939C
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3); // 0x000000018D26936C-0x000000018D26937C
		public void __iFixBaseProxy_SetPos(); // 0x000000018D26937C-0x000000018D269384
		public void __iFixBaseProxy_SetUIForward(); // 0x000000018D269384-0x000000018D26938C
		public void __iFixBaseProxy_TickUI(float P0); // 0x000000018D26938C-0x000000018D269394
	}

	public class ForgeIronTemperatureCircleUI : WorldUIController // TypeDefIndex: 80159
	{
		// Fields
		private const string AUDIO_EVENT_SUCCEED = "au_int_forge_iron_success"; // Metadata: 0x0263C1B4
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
		protected override TickType tickOption { get; } // 0x000000018D278608-0x000000018D27864C 
	
		// Nested types
		public enum ETemperatureState // TypeDefIndex: 80158
		{
			None = 0,
			Low = 1,
			Safe = 2,
			High = 3,
			Finish = 4
		}
	
		// Constructors
		public ForgeIronTemperatureCircleUI(); // 0x000000018503EE80-0x000000018503EE90
		static ForgeIronTemperatureCircleUI(); // 0x000000018D278590-0x000000018D278608
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018D2779A0-0x000000018D277A9C
		public override void Clear(); // 0x000000018D27794C-0x000000018D2779A0
		public override void SetPos(); // 0x000000018D277A9C-0x000000018D277BF8
		public override void SetUIForward(); // 0x000000018D277BF8-0x000000018D277F5C
		public override void TickUI(float deltaTime); // 0x000000018D277F5C-0x000000018D2780E0
		public void UpdateUIState(); // 0x000000018D2780E0-0x000000018D2781E8
		private void _SetState(bool max, bool low, bool high, ETemperatureState state); // 0x000000018D2781E8-0x000000018D278590
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D269394-0x000000018D26939C
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3); // 0x000000018D26936C-0x000000018D26937C
		public void __iFixBaseProxy_Clear(); // 0x000000018D26A89C-0x000000018D26A8A4
		public void __iFixBaseProxy_SetPos(); // 0x000000018D26937C-0x000000018D269384
		public void __iFixBaseProxy_SetUIForward(); // 0x000000018D269384-0x000000018D26938C
		public void __iFixBaseProxy_TickUI(float P0); // 0x000000018D26938C-0x000000018D269394
	}

	public class ForgeIronTemperatureUI : WorldUIController // TypeDefIndex: 80160
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
		protected override TickType tickOption { get; } // 0x000000018D2792D0-0x000000018D279314 
	
		// Constructors
		public ForgeIronTemperatureUI(); // 0x000000018D2792BC-0x000000018D2792D0
		static ForgeIronTemperatureUI(); // 0x000000018D279244-0x000000018D2792BC
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018D27864C-0x000000018D278748
		public override void SetPos(); // 0x000000018D278748-0x000000018D27888C
		public override void SetUIForward(); // 0x000000018D27888C-0x000000018D278A00
		public override void TickUI(float deltaTime); // 0x000000018D278A00-0x000000018D278B14
		public void UpdateUIInfo(); // 0x000000018D278B14-0x000000018D278DE0
		public void UpdateUIPos(); // 0x000000018D278DE0-0x000000018D279244
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D269394-0x000000018D26939C
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3); // 0x000000018D26936C-0x000000018D26937C
		public void __iFixBaseProxy_SetPos(); // 0x000000018D26937C-0x000000018D269384
		public void __iFixBaseProxy_SetUIForward(); // 0x000000018D269384-0x000000018D26938C
		public void __iFixBaseProxy_TickUI(float P0); // 0x000000018D26938C-0x000000018D269394
	}

	public class GuideFakeButton : Selectable, IPointerClickHandler, IUIClearable // TypeDefIndex: 80161
	{
		// Fields
		public UIButton targetButton; // 0x190
		public UIToggle targetToggle; // 0x198
		public UIDropdown targetDropdown; // 0x1A0
		public string targetKeyHintActionId; // 0x1A8
		private string m_targetActionId; // 0x1B0
		public Action onClick; // 0x1B8
		private InputBindingGroupMonoTarget m_parent; // 0x1C0
	
		// Constructors
		public GuideFakeButton(); // 0x000000018716D200-0x000000018716D250
	
		// Methods
		public void ForceToggleTargetBinding(bool active, bool forDrag = false /* Metadata: 0x0263C1D3 */); // 0x0000000186842C10-0x0000000186842EB0
		public void CopyTargetBinding(); // 0x0000000186842900-0x0000000186842B10
		private void _OnTriggerPlayerAction([IsReadOnly] in EventData<string> actionId); // 0x00000001871E7F40-0x00000001871E7FA0
		public void ClearTarget(); // 0x0000000186842B10-0x0000000186842C10
		public void ClearBinding(); // 0x0000000186842F50-0x00000001868430A0
		protected override void Awake(); // 0x00000001870A34E0-0x00000001870A3600
		public override void OnPointerDown(PointerEventData eventData); // 0x0000000186C022C0-0x0000000186C02460
		public override void OnPointerUp(PointerEventData eventData); // 0x0000000186C02460-0x0000000186C02600
		public override void OnPointerEnter(PointerEventData eventData); // 0x0000000186C02600-0x0000000186C027A0
		public override void OnPointerExit(PointerEventData eventData); // 0x000000018D27934C-0x000000018D279498
		public void OnPointerClick(PointerEventData eventData); // 0x0000000185032850-0x0000000185032B20
		public void ClearComponent(); // 0x000000018D279314-0x000000018D27934C
		private void _ClearOnClick(); // 0x0000000186842EB0-0x0000000186842F50
		public void __iFixBaseProxy_Awake(); // 0x000000018D1F7518-0x000000018D1F7520
		public void __iFixBaseProxy_OnPointerDown(PointerEventData P0); // 0x000000018D21BBC4-0x000000018D21BBCC
		public void __iFixBaseProxy_OnPointerUp(PointerEventData P0); // 0x000000018D21BBCC-0x000000018D21BBD4
		public void __iFixBaseProxy_OnPointerEnter(PointerEventData P0); // 0x000000018D279498-0x000000018D2794A0
		public void __iFixBaseProxy_OnPointerExit(PointerEventData P0); // 0x000000018D2794A0-0x000000018D2794A8
	}

	public class HeadLabelCtrl : UIPanelBase // TypeDefIndex: 80162
	{
		// Fields
		[SerializeField]
		private HeadLabelViewContext _context; // 0x70
		[SerializeField]
		private GameObject _headLabelPrefab; // 0x78
		[SerializeField]
		private GameObject _headLabelMobilePrefab; // 0x80
		[SerializeField]
		private int _poolLevelCapacity; // 0x88
		[SerializeField]
		private int _poolDialogCapacity; // 0x8C
		private readonly Dictionary<FHeadLabelTargetKey, UIHeadLabel> m_activeViews; // 0x90
		private readonly Stack<UIHeadLabel> m_pool; // 0x98
		private readonly LuaResourceLoader m_loader; // 0xA0
		private readonly List<FHeadLabelTargetKey> m_pendingRemove; // 0xA8
		private Transform m_worldObjectRoot; // 0xB0
		private bool m_preVisible; // 0xB8
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000186B179A0-0x0000000186B179D0 
		private int _poolCapacity { get; } // 0x0000000185275120-0x0000000185275270 
	
		// Constructors
		public HeadLabelCtrl(); // 0x0000000186DF8370-0x0000000186DF8830
	
		// Methods
		public void OnCreate(Transform worldObjectRoot); // 0x000000018709EFB0-0x000000018709F080
		public void OnClose(); // 0x000000018D2797B4-0x000000018D279884
		public void OnShow(); // 0x0000000186C20E40-0x0000000186C20ED0
		public void OnHide(); // 0x0000000185276A60-0x0000000185276D10
		public override void LateTick(float deltaTime); // 0x00000001861C3B90-0x00000001861C3C30
		private void _Reconcile(HeadLabelDataManager manager); // 0x0000000184F137E0-0x0000000184F16720
		private bool _ShouldRender(HeadLabelRecord record); // 0x0000000184F16720-0x0000000184F16B70
		public void ClearAll(); // 0x000000018D2794A8-0x000000018D2797B4
		private UIHeadLabel _TryGetViewFromPool(); // 0x0000000186994DC0-0x0000000186994F60
		private UIHeadLabel _CreateView(); // 0x0000000185274AB0-0x0000000185274CD0
		public void Prewarm(); // 0x0000000185274CD0-0x0000000185274F60
		private void _RecycleAllActiveViews(); // 0x000000018D27996C-0x000000018D279B24
		private void _RecyclePoolObject(UIHeadLabel view); // 0x0000000185274F60-0x0000000185275120
		private static void _DestroyPoolObject(UIHeadLabel view); // 0x000000018D279884-0x000000018D27996C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D2519E8-0x000000018D2519F0
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public class UIHeadLabel : TickableUIMono // TypeDefIndex: 80168
	{
		// Fields
		private const string UI_SPRITE_HEAD_LABEL_ICON = "HeadLabelIcon"; // Metadata: 0x0263C1D4
		private const string EMOJI_PREFAB_PATH_FORMAT = "Assets/Beyond/DynamicAssets/Gameplay/UI/Prefabs/Emoji/{0}.prefab"; // Metadata: 0x0263C1E2
		private const string BUBBLE_OUT_ANIM = "headlabel_bubble_out"; // Metadata: 0x0263C224
		[SerializeField]
		private Transform _emojiNode; // 0x68
		[SerializeField]
		private FloatingUIFitter _rootDis; // 0x70
		[CompilerGenerated]
		private Beyond.Gameplay.Core.ObjectType _targetType_k__BackingField; // 0x78
		[CompilerGenerated]
		private ulong _entityLogicId_k__BackingField; // 0x80
		private string m_headLabelIcon; // 0x88
		private string m_headLabelIconOverwrite; // 0x90
		private Vector3 m_originalPosition; // 0x98
		private bool m_hasFloatingUIRegistered; // 0xA4
		private LuaResourceLoader m_recordLoader; // 0xA8
		private HeadLabelViewContext m_viewContext; // 0xB0
		private bool m_contextVisible; // 0xB4
		private bool m_boundByManager; // 0xB5
		private bool m_refCached; // 0xB6
		[SerializeField]
		private UIText _titleText; // 0xB8
		[SerializeField]
		private UIText _nameText; // 0xC0
		[SerializeField]
		private UIText _bubbleText; // 0xC8
		[SerializeField]
		private UIText _stateText; // 0xD0
		[SerializeField]
		private UIImage _iconImage; // 0xD8
		[SerializeField]
		private UIImage _bgImage; // 0xE0
		[SerializeField]
		private UIImage _iconGiftImage; // 0xE8
		[SerializeField]
		private UIImage _stateIconImage; // 0xF0
		[SerializeField]
		private UIImage _stateLineImage; // 0xF8
		[SerializeField]
		private Component _stateNode; // 0x100
		[SerializeField]
		private Component _bubble; // 0x108
		[SerializeField]
		private Component _emoji; // 0x110
		[SerializeField]
		private UIAnimationWrapper _bubbleNode; // 0x118
		[SerializeField]
		private Canvas _canvas; // 0x120
		[SerializeField]
		private UnityEngine.Color _stateColor1; // 0x128
		[SerializeField]
		private UnityEngine.Color _stateColor2; // 0x138
		[SerializeField]
		private SerializeFieldDictionary<HeadLabelType, HeadLabelRootData> _subRoots; // 0x148
		private Dictionary<HeadLabelType, HeadLabelRootVisibleData> m_subRootsVisible; // 0x150
		private Dictionary<Transform, HeadLabelType> m_subRootsReverse; // 0x158
		private Transform m_camera; // 0x160
		private IHeadLabelAttach m_target; // 0x168
		private Transform m_followTarget; // 0x170
		private NPCAvatarMountPointInfo m_npcMountPointInfo; // 0x178
		private bool m_inited; // 0x180
		private bool m_visibleDirty; // 0x181
	
		// Properties
		protected override TickType tickOption { get; } // 0x00000001866E7CD0-0x00000001866E7D00 
		public Transform iconHolder { get; } // 0x000000018D27C128-0x000000018D27C1D8 
		public Beyond.Gameplay.Core.ObjectType targetType { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233090-0x00000001872330A0 0x0000000187233100-0x0000000187233110
		public ulong entityLogicId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001828D49D0-0x00000001828D49E0 0x0000000187232FD0-0x0000000187232FE0
		public string headLabelIcon { get; set; } // 0x000000018D27C0E4-0x000000018D27C128 0x0000000185277020-0x0000000185277070
		public string missionHeadLabelIcon { get; set; } // 0x000000018D27C1D8-0x000000018D27C21C 0x0000000185277070-0x00000001852770C0
	
		// Nested types
		public enum HeadLabelType // TypeDefIndex: 80163
		{
			Root = 0,
			Bubble = 1,
			Text = 2,
			Icon = 3,
			Count = 4
		}
	
		public enum VisibleSource // TypeDefIndex: 80164
		{
			Comp = 0,
			System = 1,
			FloatingUI = 2,
			Count = 3
		}
	
		[Serializable]
		public class HeadLabelRootData // TypeDefIndex: 80165
		{
			// Fields
			public Transform root; // 0x10
			public HeadLabelType headLabelType; // 0x18
	
			// Constructors
			public HeadLabelRootData(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public class HeadLabelRootVisibleData // TypeDefIndex: 80166
		{
			// Fields
			public Vector3 originalPosition; // 0x10
			public Dictionary<VisibleSource, bool> visibleSource; // 0x20
	
			// Properties
			public bool realVisible { get; } // 0x0000000185277E20-0x0000000185277FF0 
	
			// Constructors
			public HeadLabelRootVisibleData(); // 0x0000000186256050-0x0000000186256160
	
			// Methods
			public void Init(Vector3 position); // 0x000000018D279B24-0x000000018D279B84
			public void UpdateVisible(VisibleSource source, bool visible); // 0x0000000185277950-0x0000000185277990
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass77_0 // TypeDefIndex: 80167
		{
			// Fields
			public HeadLabelType headLabelType; // 0x10
			public UIHeadLabel __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass77_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __UpdateFloatingUIVisibleCallback_b__0(bool visible); // 0x0000000185277770-0x00000001852777B0
		}
	
		// Constructors
		public UIHeadLabel(); // 0x0000000186934350-0x00000001869344B0
	
		// Methods
		private void _OnSubRootsCollectionChanged(); // 0x000000018D27BF48-0x000000018D27C0E4
		public void Bind(HeadLabelRecord record, LuaResourceLoader loader, HeadLabelViewContext context); // 0x0000000184F16B70-0x0000000184F170F0
		public void RefreshTarget(IHeadLabelAttach target); // 0x00000001866D9FB0-0x00000001866D9FE0
		public void Refresh(HeadLabelRecord record, HeadLabelDirty dirty); // 0x0000000184F170F0-0x0000000184F17220
		public void Unbind(); // 0x0000000185276890-0x00000001852769B0
		public void SetContextVisible(bool visible); // 0x00000001852770C0-0x0000000185277240
		private void _TryInitRootData(); // 0x0000000186255260-0x0000000186256050
		public void SetVisibleDirty(); // 0x0000000185277680-0x00000001852776B0
		private void _UpdateVisible(); // 0x0000000185277990-0x0000000185277E20
		public void SetSubRootVisible(HeadLabelType type, VisibleSource source, bool visible, bool updateNow); // 0x0000000185277870-0x0000000185277950
		private void _SetTarget(IHeadLabelAttach target); // 0x0000000185276D10-0x0000000185277020
		private void _TryUpdateVisibleCallback(); // 0x0000000185278300-0x00000001852783E0
		private void _ClearVisibleCallback(); // 0x0000000185278220-0x0000000185278300
		public void Clear(); // 0x00000001852769B0-0x0000000185276A60
		public void SetActive(bool active); // 0x000000018D27BE68-0x000000018D27BF48
		public void ClearEmojis(); // 0x00000001852776B0-0x0000000185277770
		private void _UpdateFloatingUIVisibleCallback(); // 0x000000018527A1D0-0x000000018527A610
		private void _ClearFloatingUIVisibleCallback(); // 0x000000018527A610-0x000000018527A7F0
		private void _UpdatePos(); // 0x0000000185546F40-0x00000001855472F0
		private void _RefreshVisible(bool bubbleRoot, bool textNode, bool iconHolderNode); // 0x00000001852777B0-0x0000000185277870
		private void _TryUpdateVisible(); // 0x0000000185546D30-0x0000000185546F40
		protected override void OnAwake(); // 0x0000000186255190-0x00000001862551D0
		public override void LateTick(float deltaTime); // 0x0000000185546CB0-0x0000000185546D30
		protected override void OnEnable(); // 0x0000000186AB45F0-0x0000000186AB4620
		protected override void OnDisable(); // 0x0000000186AB4620-0x0000000186AB4650
		protected override void OnRelease(); // 0x000000018D27BE30-0x000000018D27BE68
		private static void _TrySetComponentActive(Component component, bool active); // 0x0000000185277560-0x0000000185277680
		private void _RefreshInfo(HeadLabelRecord record); // 0x0000000184F19F40-0x0000000184F1A6A0
		private void _RefreshIcon(HeadLabelRecord record); // 0x0000000184F196B0-0x0000000184F19F40
		private void _RefreshState(HeadLabelRecord record); // 0x0000000184F1A6A0-0x0000000184F1AEC0
		private void _RefreshGift(HeadLabelRecord record); // 0x0000000184F18B50-0x0000000184F196B0
		private void _RefreshBubble(HeadLabelRecord record); // 0x0000000184F17220-0x0000000184F18B50
		private void _HideBubble(bool playOut); // 0x0000000185277240-0x0000000185277420
		private void _SetTextRootSystemVisible(HeadLabelRecord record); // 0x0000000184F1AEC0-0x0000000184F1AF90
		private void _ClearViewContent(); // 0x0000000185277490-0x0000000185277560
		[CompilerGenerated]
		private void __HideBubble_g__HideNow_93_0(); // 0x0000000185277420-0x0000000185277490
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_OnDisable(); // 0x00000001828D23D0-0x00000001828D23E0
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
	}

	[Serializable]
	public class RegionMap3DCfg // TypeDefIndex: 80169
	{
		// Fields
		[NonSerialized]
		public GameObject model; // 0x10
		[NonSerialized]
		public GameObject ground; // 0x18
		[NonSerialized]
		public UIRegionMap3DUICell ui; // 0x20
		public Vector4 uiRect; // 0x28
		[SerializeField]
		private string _ui; // 0x38
		[SerializeField]
		private string _model; // 0x40
		[SerializeField]
		private string _ground; // 0x48
		[CompilerGenerated]
		private bool _isLoaded_k__BackingField; // 0x50
	
		// Properties
		public bool isLoaded { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225DFF0-0x000000018225E000 0x000000018225E000-0x000000018225E010
	
		// Constructors
		public RegionMap3DCfg(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Load(RegionMapSetting regionMapSetting); // 0x0000000185A57350-0x0000000185A57770
	}

	public enum RegionMapShowType // TypeDefIndex: 80170
	{
		Map = 0,
		Watch = 1
	}

	public class RegionMapSetting : UIPanelBase // TypeDefIndex: 80171
	{
		// Fields
		public const string UI_REGION_MAP_TRACK_ICON = "Assets/Beyond/DynamicAssets/Gameplay/UI/Prefabs/Map/Widgets/RegionMapTrackIcon.prefab"; // Metadata: 0x0263C248
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
		private const string OUTER_COLOR_PROPERTY_NAME = "_OuterColor"; // Metadata: 0x0263C29F
		private static MaterialPropertyBlock s_materialPropertyBlock; // 0x00
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000186BD17A0-0x0000000186BD17D0 
		public Dictionary<string, RegionMap3DCfg> cfg { get; } // 0x0000000186DF9A10-0x0000000186DF9A40 
		private static MaterialPropertyBlock m_materialPropertyBlock { get; } // 0x000000018D27A060-0x000000018D27A138 
	
		// Constructors
		public RegionMapSetting(); // 0x0000000186D36D30-0x0000000186D36ED0
	
		// Methods
		protected override void OnDestroy(); // 0x0000000185F2C920-0x0000000185F2CAD0
		private void _InitUI(); // 0x0000000185A549D0-0x0000000185A54D90
		private void _InitPlayerIcon(); // 0x0000000185A52DF0-0x0000000185A53230
		private void _InitTrackIcon(); // 0x0000000185A54D90-0x0000000185A55B90
		private void _InitSelect(); // 0x0000000185A55B90-0x0000000185A55E80
		private void _SetMapPos(RectTransform rect, Vector3 pos, BasicLoadConfigInfo uiLevelMapConfig); // 0x0000000185A52CA0-0x0000000185A52DF0
		private void _RefreshMaterials(); // 0x00000001853A2840-0x00000001853A2A30
		private void _ClearMaterials(); // 0x0000000185F2C540-0x0000000185F2C780
		public void InitData(RegionMapShowType shotType, Transform center = null, Transform moveRoot = null, float watchRadius = 0f /* Metadata: 0x0263C244 */); // 0x0000000185A55E80-0x0000000185A56920
		public void MoveToPlayer(Transform center, Transform moveRoot); // 0x0000000185A57BA0-0x0000000185A57DF0
		public Transform GetNodeTransform(string levelId); // 0x0000000185A594F0-0x0000000185A59630
		public Vector3 GetNodeMoveTargetLocalPosition(string levelId, Camera uiCamera, Transform moveRoot); // 0x0000000185A5AEF0-0x0000000185A5B360
		public RegionMap3DCfg GetCfg(string levelId); // 0x000000018645B5E0-0x000000018645B660
		public static bool IsCircleIntersectingRectangle(Vector2 circleCenter, float circleRadius, UnityEngine.Rect rectangle); // 0x0000000185A57020-0x0000000185A570E0
		public void SetLoadedRegionTransform(Transform regionTransform); // 0x00000001871F5660-0x00000001871F56A0
		public TweenerCore<Quaternion, Quaternion, NoOptions> StartRegionRectTransformMoveRotationTween(float tweenDuration, AnimationCurve tweenCurve); // 0x00000001857F0C80-0x00000001857F0DE0
		public void SetControllerLevelSelectedState(string levelId, bool isSelected); // 0x000000018D279E74-0x000000018D27A060
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D2519E8-0x000000018D2519F0
		public void __iFixBaseProxy_OnDestroy(); // 0x0000000189572D4C-0x0000000189572D54
	}

	[Serializable]
	public class UIFacMainRegionConfig // TypeDefIndex: 80172
	{
		// Fields
		public string levelId; // 0x10
		public int panelIndex; // 0x18
		public List<Sprite> levelSprites; // 0x20
		public List<Vector3> levelPositions; // 0x28
	
		// Constructors
		public UIFacMainRegionConfig(); // 0x00000001855DF430-0x00000001855DF500
	}

	public class UIFacMainRegion : MonoBehaviour, IUIClearable // TypeDefIndex: 80173
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
		public UIFacMainRegion(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		private void _OnMainRegionLevelChanged(string levelId, int panelIndex); // 0x000000018D27A1C4-0x000000018D27A238
		private void _RefreshRegionState(); // 0x00000001860D8AC0-0x00000001860D9270
		private void OnDestroy(); // 0x00000001860D8840-0x00000001860D8870
		public void InitMainRegion(string levelId, int panelIndex); // 0x00000001860D8870-0x00000001860D89B0
		public void ClearComponent(); // 0x00000001860D89B0-0x00000001860D8AC0
	}

	public class UILevelMapCommonStaticElement : MonoBehaviour, IUIClearable // TypeDefIndex: 80174
	{
		// Fields
		private const string SPRITE_FOLDER = "Map/CommonStaticElement/"; // Metadata: 0x0263C2AB
		private UIImage m_image; // 0x18
		private MapStaticElementData m_elementData; // 0x20
		private List<int> m_conditionHandles; // 0x28
		private int m_activeVisibilityIndex; // 0x30
		private int m_activeImageIndex; // 0x34
		private bool m_visibilityInitialized; // 0x38
		private bool m_imageInitialized; // 0x39
	
		// Constructors
		public UILevelMapCommonStaticElement(); // 0x0000000186CE8CA0-0x0000000186CE8CD0
	
		// Methods
		public void InitCommonStaticElement(MapStaticElementData elementData); // 0x00000001861E5660-0x00000001861E57C0
		[IDTag(0)]
		private void _RegisterPhaseConditions(MapManager mapManager, List<CommonElementVisibilityPhaseData> phases); // 0x00000001861E2FC0-0x00000001861E3360
		[IDTag(1)]
		private void _RegisterPhaseConditions(MapManager mapManager, List<CommonElementImagePhaseData> phases); // 0x00000001861E57C0-0x00000001861E59E0
		private void _OnAnyConditionChanged(int handle, bool _); // 0x000000018D27C350-0x000000018D27C39C
		private void _ReevaluateAndApply(); // 0x00000001861E52D0-0x00000001861E5520
		[IDTag(0)]
		private static int _FindMatchingPhaseIndex(MapManager mapManager, List<CommonElementVisibilityPhaseData> phases); // 0x00000001861E55A0-0x00000001861E5660
		[IDTag(1)]
		private static int _FindMatchingPhaseIndex(MapManager mapManager, List<CommonElementImagePhaseData> phases); // 0x00000001861E5520-0x00000001861E55A0
		private void _LoadImage(string imgPath, float imgScale); // 0x00000001861E59E0-0x00000001861E5C60
		private void _UnloadImage(); // 0x00000001861E2C60-0x00000001861E2DB0
		public void ClearComponent(); // 0x00000001861E29D0-0x00000001861E2C60
		private void OnDestroy(); // 0x00000001861E29A0-0x00000001861E29D0
		public static bool EvaluateInitialVisibility(MapStaticElementData elementData); // 0x000000018D27C21C-0x000000018D27C350
	}

	public class UILevelMapCrane : MonoBehaviour, IUIClearable // TypeDefIndex: 80176
	{
		// Fields
		private CombineKey m_eventKey; // 0x18
		private CachedPathAssetLoader m_assetLoader; // 0x20
		private const string CRANE_SPRITE_FOLDER = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/Map/Crane/"; // Metadata: 0x0263C2C4
		private const string CRANE_GAME_VAR_KEY = "lv003_crane_state"; // Metadata: 0x0263C2FF
		[SerializeField]
		private SerializeReferenceDictionary<long, CraneSpritePath> _stateSpriteDict; // 0x28
		[SerializeField]
		private RectTransform _rectTransform; // 0x30
		[SerializeField]
		private UIImage _image; // 0x38
	
		// Nested types
		[Serializable]
		public class CraneSpritePath // TypeDefIndex: 80175
		{
			// Fields
			public string stateSpritePath; // 0x10
	
			// Constructors
			public CraneSpritePath(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public UILevelMapCrane(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		private void OnDestroy(); // 0x000000018D27C3F4-0x000000018D27C44C
		private void _RefreshCraneState(); // 0x000000018D27C690-0x000000018D27C930
		private void _ClearSpriteAsset(); // 0x000000018D27C5F0-0x000000018D27C654
		private void _OnCraneStateChanged([IsReadOnly] in EventData<long, long> eventData); // 0x000000018D27C654-0x000000018D27C690
		private void _BindAll(); // 0x000000018D27C44C-0x000000018D27C5F0
		private void _UnBindAll(); // 0x0000000186B300B0-0x0000000186B30190
		public void InitCrane(); // 0x000000018D27C39C-0x000000018D27C3F4
		public void ClearComponent(); // 0x0000000186B30080-0x0000000186B300B0
	}

	[RequireComponent(typeof(CanvasRenderer))]
	public class UILevelMapFallbackDebugOverlay : MaskableGraphic // TypeDefIndex: 80178
	{
		// Fields
		private const string ROOT_NAME = "FallbackDebugOverlay"; // Metadata: 0x0263C311
		private const int MAX_LINES_PER_AXIS = 128; // Metadata: 0x0263C326
		private const float LINE_THICKNESS = 2f; // Metadata: 0x0263C328
		private const float BORDER_THICKNESS = 3f; // Metadata: 0x0263C32C
		private const float INFO_FONT_SIZE = 26f; // Metadata: 0x0263C330
		private static readonly UnityEngine.Color GRID_COLOR; // 0x00
		private static readonly UnityEngine.Color BORDER_COLOR; // 0x10
		private static readonly UnityEngine.Color INFO_COLOR; // 0x20
		private float m_gridRectLength; // 0xE8
		private float m_gridWorldLength; // 0xEC
		private Vector2 m_worldLeftBottom; // 0xF0
		private Vector2 m_worldRightTop; // 0xF8
		private TextMeshProUGUI m_infoLabel; // 0x100
	
		// Properties
		public override Texture mainTexture { get; } // 0x000000018D27E55C-0x000000018D27E5E4 
	
		// Nested types
		private sealed class LabelScreenScaleKeeper : TickableUIMono // TypeDefIndex: 80177
		{
			// Fields
			public RectTransform scaleReference; // 0x68
			private RectTransform m_rect; // 0x70
	
			// Properties
			protected override TickType tickOption { get; } // 0x000000018D279E30-0x000000018D279E74 
	
			// Constructors
			public LabelScreenScaleKeeper(); // 0x000000018503EE80-0x000000018503EE90
	
			// Methods
			protected override void OnAwake(); // 0x000000018D279D84-0x000000018D279E30
			public override void LateTick(float deltaTime); // 0x000000018D279B84-0x000000018D279D84
			public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
			public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
			public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
		}
	
		// Constructors
		public UILevelMapFallbackDebugOverlay(); // 0x000000018702CD90-0x000000018702CDA0
		static UILevelMapFallbackDebugOverlay(); // 0x000000018D27E4E4-0x000000018D27E55C
	
		// Methods
		public static UILevelMapFallbackDebugOverlay Ensure(RectTransform parent); // 0x000000018D27CA38-0x000000018D27CD9C
		public static void DestroyOn(RectTransform parent); // 0x000000018D27C930-0x000000018D27CA38
		public void Setup(Vector2 worldLeftBottom, Vector2 worldRightTop, float gridWorldLength, float gridRectLength, string levelId, string levelShowName, bool isFallback, TMP_Text fontSource, RectTransform scaleReference); // 0x000000018D27D220-0x000000018D27D368
		protected override void OnRectTransformDimensionsChange(); // 0x000000018D27D1BC-0x000000018D27D220
		protected override void OnPopulateMesh(VertexHelper vh); // 0x000000018D27CD9C-0x000000018D27D1BC
		private void _EnsureLabels(TMP_Text fontSource, RectTransform scaleReference); // 0x000000018D27DC5C-0x000000018D27DD6C
		private TextMeshProUGUI _EnsureLabel(ref TextMeshProUGUI cached, string name, float fontSize, UnityEngine.Color color, TMP_Text fontSource, RectTransform scaleReference, TextAlignmentOptions alignment); // 0x000000018D27D8AC-0x000000018D27DC5C
		private static void _ApplyFont(TMP_Text label, TMP_Text fontSource); // 0x000000018D27D71C-0x000000018D27D8AC
		private void _RefreshLabelTexts(string levelId, string levelShowName, bool isFallback); // 0x000000018D27E010-0x000000018D27E4E4
		private static string _FormatWorld(float x, float z); // 0x000000018D27DD6C-0x000000018D27DE38
		private void _LayoutLabels(); // 0x000000018D27DE38-0x000000018D27E010
		private static void _AddLine(VertexHelper vh, Vector2 start, Vector2 end, float thickness, UnityEngine.Color color); // 0x000000018D27D378-0x000000018D27D71C
		public Texture __iFixBaseProxy_get_mainTexture(); // 0x000000018D27D370-0x000000018D27D378
		public void __iFixBaseProxy_OnRectTransformDimensionsChange(); // 0x000000018D27D368-0x000000018D27D370
		public void __iFixBaseProxy_OnPopulateMesh(VertexHelper P0); // 0x000000018D1F6E38-0x000000018D1F6E40
	}

	public class UILevelMapGameplayArea : MonoBehaviour, IUIClearable // TypeDefIndex: 80179
	{
		// Fields
		private bool m_initialized; // 0x18
		[SerializeField]
		private RectTransform _rectTransform; // 0x20
		[SerializeField]
		private RectTransform _circleRectTransform; // 0x28
	
		// Constructors
		public UILevelMapGameplayArea(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		private void _RefreshGameplayArea(GameplayAreaInstRuntimeData areaData); // 0x0000000185193B10-0x0000000185193C50
		public void Init(GameplayAreaInstRuntimeData areaData); // 0x0000000185193AE0-0x0000000185193B10
		public void ClearComponent(); // 0x00000001870A4380-0x00000001870A43B0
	}

	public class UILevelMapLimitInRect : TickableUIMono, IUIClearable // TypeDefIndex: 80181
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
		protected override TickType tickOption { get; } // 0x000000018695F340-0x000000018695F370 
	
		// Nested types
		public enum MaskShapeType // TypeDefIndex: 80180
		{
			Rectangle = 0,
			Circle = 1
		}
	
		// Constructors
		public UILevelMapLimitInRect(); // 0x000000018503EE80-0x000000018503EE90
	
		// Methods
		public override void LateTick(float deltaTime); // 0x0000000185561FA0-0x0000000185561FE0
		protected override void OnEnable(); // 0x0000000186C0C170-0x0000000186C0C1B0
		protected override void OnRelease(); // 0x0000000186B522E0-0x0000000186B52320
		private void _LimitInRect(); // 0x0000000185561FE0-0x0000000185562CC0
		public void ClearComponent(); // 0x0000000186B52320-0x0000000186B52360
		public void StartLimitMarkInRect(); // 0x0000000186AEF470-0x0000000186AEF510
		public void StopLimitMarkInRect(); // 0x0000000186E0B910-0x0000000186E0B970
		public void ForceRefreshLimitState(); // 0x0000000186D3AA40-0x0000000186D3AA70
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
	}

	public class UILevelMapLine : TickableUIMono, IUIClearable // TypeDefIndex: 80182
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
		protected override TickType tickOption { get; } // 0x000000018625E360-0x000000018625E390 
	
		// Constructors
		public UILevelMapLine(); // 0x000000018503EFF0-0x000000018503F000
	
		// Methods
		protected override void OnEnable(); // 0x00000001864D2430-0x00000001864D2470
		private void _HoldLineSize(); // 0x000000018569FEA0-0x00000001856A00A0
		public override void LateTick(float deltaTime); // 0x000000018569FC80-0x000000018569FEA0
		public void Init(float basicLength); // 0x00000001851ABF50-0x00000001851AC0E0
		public void ClearComponent(); // 0x00000001866DB4A0-0x00000001866DB4D0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public class UILevelMapMissionArea : TickableUIMono, IUIClearable // TypeDefIndex: 80184
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
		protected override TickType tickOption { get; } // 0x0000000186AAD240-0x0000000186AAD270 
		public bool needCheckMissionTrackCoexist { get; } // 0x00000001860F4CE0-0x00000001860F4D30 
		public bool coexistWithMissionTrack { get; } // 0x0000000186D49160-0x0000000186D49190 
		public bool notNeedCheckCoexistBecauseOfRadius { get; } // 0x00000001860F4D30-0x00000001860F4D70 
	
		// Nested types
		public enum DisappearRectShapeType // TypeDefIndex: 80183
		{
			Rectangle = 0,
			Circle = 1
		}
	
		// Constructors
		public UILevelMapMissionArea(); // 0x0000000186BFBF30-0x0000000186BFBFB0
	
		// Methods
		public override void LateTick(float deltaTime); // 0x00000001856C6470-0x00000001856C65B0
		private void _RefreshMissionArea(MissionTrackingMarkInstRuntimeDate missionMarkInstRuntimeData); // 0x0000000185194DC0-0x0000000185194EF0
		private bool _IsCircleOutsideDisappearRect(); // 0x000000018550E730-0x000000018550EC90
		private void _DisappearIfOutRect(); // 0x00000001851CF500-0x00000001851CF640
		public void Init(MissionTrackingMarkInstRuntimeDate missionMarkInstRuntimeData, GameObject associatedTrackingMark); // 0x0000000185194F30-0x0000000185195040
		public void ClearComponent(); // 0x0000000186D370A0-0x0000000186D370E0
		public void ForceRefreshDisappearIfOutRect(); // 0x00000001871EC5F0-0x00000001871EC620
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public class UILevelMapMisty : MonoBehaviour, IUIClearable // TypeDefIndex: 80185
	{
		// Fields
		private CombineKey m_eventKey; // 0x18
		private bool m_needBind; // 0x1C
		private const long INVISIBLE_STATE_VALUE = 1; // Metadata: 0x0263C338
		private const string MISTY_GAME_VAR_KEY = "huanzhuline_game_finish"; // Metadata: 0x0263C340
	
		// Constructors
		public UILevelMapMisty(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		private void OnDestroy(); // 0x000000018D27E700-0x000000018D27E738
		private void _RefreshMistyState(); // 0x000000018D27E93C-0x000000018D27E9B8
		private void _OnMistyStateChanged([IsReadOnly] in EventData<long, long> eventData); // 0x000000018D27E8DC-0x000000018D27E93C
		private void _BindAll(); // 0x000000018D27E738-0x000000018D27E8DC
		private void _UnBindAll(); // 0x000000018D27E9B8-0x000000018D27EA9C
		public void InitMisty(); // 0x000000018D27E5E4-0x000000018D27E644
		public static bool IsMistyVisible(); // 0x000000018D27E644-0x000000018D27E700
		public void ClearComponent(); // 0x00000001870EA2F0-0x00000001870EA320
	}

	public class UILevelMapNarrativeAreaText : MonoBehaviour, IUIClearable // TypeDefIndex: 80186
	{
		// Fields
		private UIText m_text; // 0x18
		private MapStaticElementData m_elementData; // 0x20
		private int m_conditionHandle; // 0x28
		private string m_currentTextId; // 0x30
		private bool m_initialized; // 0x38
	
		// Constructors
		public UILevelMapNarrativeAreaText(); // 0x0000000186A398C0-0x0000000186A398F0
	
		// Methods
		public void InitNarrativeAreaText(MapStaticElementData elementData); // 0x0000000185E80E20-0x0000000185E80EC0
		private void _OnAnyConditionChanged(int handle, bool _); // 0x000000018D27ED74-0x000000018D27EDC0
		private void _ReevaluateAndApply(); // 0x0000000185E80EC0-0x0000000185E810D0
		public void ClearComponent(); // 0x00000001865CD4B0-0x00000001865CD500
		private void OnDestroy(); // 0x00000001865CD480-0x00000001865CD4B0
		private static MapStaticElementConditionExpression _MergeAllConditionExpressions(List<MapNarrativeTextPhaseData> phases); // 0x000000018D27EA9C-0x000000018D27ED74
	}

	public class UILevelMapSwitchBtn : MonoBehaviour, IUIClearable // TypeDefIndex: 80188
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
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 80187
		{
			// Fields
			public string targetLevelId; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _InitSwitchButton_b__0(PointerEventData eventData); // 0x000000018D27A138-0x000000018D27A1C4
		}
	
		// Constructors
		public UILevelMapSwitchBtn(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		public void InitSwitchButton(string targetLevelId, float directionAngle); // 0x0000000185A56960-0x0000000185A56EE0
		public void ClearComponent(); // 0x00000001867FE2D0-0x00000001867FE4B0
	}

	public class UILevelMapTouchPanelWrapper : TickableUIMono // TypeDefIndex: 80189
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
		protected override TickType tickOption { get; } // 0x000000018D27F7D8-0x000000018D27F81C 
	
		// Constructors
		public UILevelMapTouchPanelWrapper(); // 0x000000018D27F750-0x000000018D27F7D8
	
		// Methods
		protected override void OnAwake(); // 0x000000018D27EDC0-0x000000018D27EF20
		public override void Tick(float deltaTime); // 0x000000018D27EF20-0x000000018D27F02C
		private bool _IsFirstRaycastSelectable(PointerEventData pointerEventData); // 0x000000018D27F4D4-0x000000018D27F750
		private void _CheckDrag(); // 0x000000018D27F02C-0x000000018D27F348
		private void _CheckScroll(); // 0x000000018D27F348-0x000000018D27F4D4
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	public class UIRegionMap3DPanel : UIPanelBase // TypeDefIndex: 80190
	{
		// Fields
		public const string HOVER_ANIM_NAME = "regionmap3d_map_hover"; // Metadata: 0x0263C358
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
		protected override TickType tickOption { get; } // 0x0000000187184BE0-0x0000000187184C10 
	
		// Constructors
		public UIRegionMap3DPanel(); // 0x00000001871EC9E0-0x00000001871ECA00
	
		// Methods
		private Transform _GetNodeTransform(string levelId); // 0x000000018D27F81C-0x000000018D27F878
		private Vector3 _GetMoveTargetLocalPosition(string levelId); // 0x0000000185A59430-0x0000000185A594B0
		private void _OnDoMoveTween(); // 0x0000000185E824E0-0x0000000185E82660
		public void InitPanel(RegionMapSetting regionMapSetting); // 0x0000000186DFF220-0x0000000186DFF330
		public void OnClickLevelBtn(string levelId, string insId); // 0x0000000185FBA020-0x0000000185FBA3C0
		public void OnLevelHoverChanged(string levelId, bool isHover); // 0x000000018645B480-0x000000018645B5E0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D2519E8-0x000000018D2519F0
	}

	public class UIRegionMap3DUICell : UIPanelBase // TypeDefIndex: 80191
	{
		// Fields
		public UIText showName; // 0x70
		public RectTransform iconRoot; // 0x78
		public UIButton btn; // 0x80
	
		// Constructors
		public UIRegionMap3DUICell(); // 0x00000001860C0EF0-0x00000001860C0F00
	}

	public class UIRegionMapTrackIcon : UIPanelBase // TypeDefIndex: 80192
	{
		// Fields
		[SerializeField]
		private UIImage _icon; // 0x70
		[SerializeField]
		private UIImage _track; // 0x78
	
		// Constructors
		public UIRegionMapTrackIcon(); // 0x00000001860C0EF0-0x00000001860C0F00
	
		// Methods
		public void InitData(MissionTrackingMarkInstRuntimeDate data); // 0x0000000185E7DC40-0x0000000185E7DE30
	}

	public class UISettlementRegion : MonoBehaviour, IUIClearable // TypeDefIndex: 80195
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
		public const string SETTLEMENT_REGION_SPRITE_FOLDER = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/Map/SettlementRegion/"; // Metadata: 0x0263C36F
	
		// Nested types
		[Serializable]
		public class SettlementRegionSpritePath // TypeDefIndex: 80193
		{
			// Fields
			public string path; // 0x10
	
			// Constructors
			public SettlementRegionSpritePath(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[Serializable]
		public class SettlementRegionSpriteData // TypeDefIndex: 80194
		{
			// Fields
			public SerializeFieldDictionary<int, SettlementRegionSpritePath> spriteWithTier; // 0x10
	
			// Constructors
			public SettlementRegionSpriteData(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public UISettlementRegion(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		private void OnDestroy(); // 0x0000000185640D90-0x0000000185640DC0
		private void _RefreshSpriteWithTier(int tier = 0 /* Metadata: 0x0263C36E */); // 0x000000018637D480-0x000000018637D5B0
		private void _RefreshSettlementRegionState(); // 0x000000018637D330-0x000000018637D480
		private void _OnSettlementUnlocked([IsReadOnly] in EventData<string> param); // 0x000000018D27F8B8-0x000000018D27F918
		private void _BindAll(); // 0x000000018637D5B0-0x000000018637D6B0
		private void _UnBindAll(); // 0x0000000185640E70-0x0000000185640F70
		public void InitSettlementRegion(string settlementId, Vector3 centerPos); // 0x000000018637D2E0-0x000000018637D330
		public bool GetNeedRefreshSettlementRegionTier(); // 0x0000000186B0DBA0-0x0000000186B0DC20
		public void RefreshSettlementRegionWithTier(int tier); // 0x000000018D27F878-0x000000018D27F8B8
		public void ClearComponent(); // 0x0000000185640DC0-0x0000000185640E70
	}

	public class ChessboardDrop : UIBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler, IUIClearable // TypeDefIndex: 80196
	{
		// Fields
		[NonSerialized]
		public UnityEvent<PointerEventData> onDropEvent; // 0x18
		[NonSerialized]
		public UnityEvent<PointerEventData> onPointerEnterEvent; // 0x20
		[NonSerialized]
		public UnityEvent<PointerEventData> onPointerExitEvent; // 0x28
	
		// Constructors
		public ChessboardDrop(); // 0x000000018D276D08-0x000000018D276DEC
	
		// Methods
		public void OnDrop(PointerEventData eventData); // 0x000000018D276A24-0x000000018D276ACC
		public void OnPointerEnter(PointerEventData eventData); // 0x000000018D276ACC-0x000000018D276B74
		public void OnPointerExit(PointerEventData eventData); // 0x000000018D276B74-0x000000018D276C1C
		private bool _CheckEventValid(PointerEventData eventData); // 0x000000018D276C1C-0x000000018D276D08
		public void ClearComponent(); // 0x000000018D276974-0x000000018D2769EC
		protected override void OnDestroy(); // 0x000000018D2769EC-0x000000018D276A24
		public void __iFixBaseProxy_OnDestroy(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class PuzzleCellDrag : UIBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 80197
	{
		// Fields
		private PuzzleDrag m_parent; // 0x18
		[SerializeField]
		private bool _needHovering; // 0x20
	
		// Constructors
		public PuzzleCellDrag(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void Init(PuzzleDrag puzzleDrag); // 0x000000018D283954-0x000000018D283994
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018D283994-0x000000018D2839EC
		public void OnDrag(PointerEventData eventData); // 0x000000018D2839EC-0x000000018D283A44
		public void OnEndDrag(PointerEventData eventData); // 0x000000018D283A44-0x000000018D283A9C
		public void OnPointerDown(PointerEventData eventData); // 0x000000018D283AF4-0x000000018D283B4C
		public void OnPointerUp(PointerEventData eventData); // 0x000000018D283C04-0x000000018D283C5C
		public void OnPointerClick(PointerEventData eventData); // 0x000000018D283A9C-0x000000018D283AF4
		public void OnPointerEnter(PointerEventData eventData); // 0x000000018D283B4C-0x000000018D283BA8
		public void OnPointerExit(PointerEventData eventData); // 0x000000018D283BA8-0x000000018D283C04
	}

	public class PuzzleControllerHelper : UIBehaviour // TypeDefIndex: 80198
	{
		// Fields
		private LuaPanel m_luaPanel; // 0x18
		private PointerEventData m_controllerFocusEventData; // 0x20
		private readonly List<RaycastResult> m_raycastResults; // 0x28
	
		// Properties
		public List<RaycastResult> raycastResults { get; } // 0x000000018D284134-0x000000018D284174 
	
		// Constructors
		public PuzzleControllerHelper(); // 0x000000018D2840B4-0x000000018D284134
	
		// Methods
		protected override void Awake(); // 0x000000018D283C5C-0x000000018D283D4C
		public int TryGetPuzzleSlotIndexByPos(RectTransform gridCell); // 0x000000018D283D4C-0x000000018D2840B4
		public void __iFixBaseProxy_Awake(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class PuzzleDrag : UIBehaviour, IUIClearable, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 80199
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
		public LuaPanel panel { get; } // 0x000000018D284A64-0x000000018D284B18 
		public int luaIndex { get; } // 0x000000018D284A24-0x000000018D284A64 
	
		// Constructors
		public PuzzleDrag(); // 0x000000018D28483C-0x000000018D284A24
	
		// Methods
		protected override void Awake(); // 0x000000018D284174-0x000000018D2841F8
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018D2842C0-0x000000018D284378
		public void OnDrag(PointerEventData eventData); // 0x000000018D2843B0-0x000000018D284454
		public void OnEndDrag(PointerEventData eventData); // 0x000000018D284454-0x000000018D28450C
		public void OnPointerDown(PointerEventData eventData); // 0x000000018D2845A4-0x000000018D28463C
		public void OnPointerUp(PointerEventData eventData); // 0x000000018D28476C-0x000000018D284804
		public void OnPointerClick(PointerEventData eventData); // 0x000000018D28450C-0x000000018D2845A4
		public void OnPointerEnter(PointerEventData eventData); // 0x000000018D28463C-0x000000018D2846D4
		public void OnPointerExit(PointerEventData eventData); // 0x000000018D2846D4-0x000000018D28476C
		public void ClearComponent(); // 0x000000018D2841F8-0x000000018D2842C0
		protected override void OnDestroy(); // 0x000000018D284378-0x000000018D2843B0
		public void SetIndex(int index); // 0x000000018D284804-0x000000018D28483C
		public void __iFixBaseProxy_Awake(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy_OnDestroy(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class ScratchOffLotteryCoating : MonoBehaviour // TypeDefIndex: 80201
	{
		// Fields
		public Texture brushTexture; // 0x18
		public Material renderMat; // 0x20
		public RectTransform rectTransform; // 0x28
		public Canvas canvas; // 0x30
		public int lotteryColumn; // 0x38
		private const float MARK_FIRST = 0.4f; // Metadata: 0x0263C3B6
		private const float MARK_SECOND = 0.8f; // Metadata: 0x0263C3BA
		private bool[] m_scratchedPixels; // 0x40
		private int m_pixelAccount; // 0x48
		private RenderTexture m_renderTexture; // 0x50
		private const int RENDER_TEXTURE_WIDTH = 1024; // Metadata: 0x0263C3BE
		private const int RENDER_TEXTURE_HEIGHT = 512; // Metadata: 0x0263C3C0
		private Vector2 m_lastFramePos; // 0x58
		private Vector2 m_thisFramePos; // 0x60
		private List<AwardMarkPoint> m_awardMarkPoints; // 0x68
	
		// Nested types
		private class AwardMarkPoint // TypeDefIndex: 80200
		{
			// Fields
			public Vector2 markPoint; // 0x10
			public bool markValue; // 0x18
	
			// Constructors
			public AwardMarkPoint(Vector2 point, bool value); // 0x0000000187258EE0-0x0000000187258EF0
		}
	
		// Constructors
		public ScratchOffLotteryCoating(); // 0x000000018D286E04-0x000000018D286E9C
	
		// Methods
		private void Awake(); // 0x000000018D285C84-0x000000018D285CE4
		private void OnDestroy(); // 0x000000018D286198-0x000000018D286200
		private void _DrawBlank(); // 0x000000018D2865A4-0x000000018D2866E0
		private void _InitPixelDic(); // 0x000000018D286B74-0x000000018D286C00
		private static int _GetPixelIndex(int px, int py); // 0x000000018D2869E8-0x000000018D286A2C
		private void _InitMarkPoint(); // 0x000000018D286A2C-0x000000018D286B74
		public void Draw(float x, float y); // 0x000000018D285D20-0x000000018D285FCC
		private static UnityEngine.Rect _ClampDrawRect(float x, float y, float width, float height); // 0x000000018D2863EC-0x000000018D2864D0
		private void _MarkScratchPos(int x, int y, int width, int height); // 0x000000018D286C00-0x000000018D286D1C
		private void _AwardMarkScratchPos(int x, int y, int width, int height); // 0x000000018D286244-0x000000018D2863EC
		public float OutputCompletePercent(); // 0x000000018D286200-0x000000018D286244
		public bool FlagCompleteMarkPoint(); // 0x000000018D286004-0x000000018D286198
		private List<Vector2> _FigureUpCreateRouteLinePoints(Vector2 start, Vector2 end, float thickness); // 0x000000018D2866E0-0x000000018D2869E8
		private Vector2 _ComputeBrushUV(Vector2 localPos); // 0x000000018D2864D0-0x000000018D2865A4
		public void ApplyScratch(Vector2 position); // 0x000000018D2859E8-0x000000018D285C84
		public void BeginScratch(Vector2 position); // 0x000000018D285CE4-0x000000018D285D20
		public void EndScratch(Vector2 position); // 0x000000018D285FCC-0x000000018D286004
		private Vector2 _ScreenPosToUiLocalPos(Vector2 screenPos, RectTransform transform, Camera cam); // 0x000000018D286D1C-0x000000018D286E04
	}

	public class UIMusicVolumeVisual : TickableUIMono // TypeDefIndex: 80202
	{
		// Fields
		private static readonly int FREQUENCY_DATA_ID; // 0x00
		private static readonly int ENABLE_RANDOM_GRAM_ID; // 0x04
		private const int BAND_COUNT = 8; // Metadata: 0x0263C3C2
		private UIImage m_uiImage; // 0x68
		private Material m_material; // 0x70
		private float[] m_bandValues; // 0x78
		private Vector4[] m_bandVectors; // 0x80
		private Graphic m_graphic; // 0x88
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018D289D6C-0x000000018D289DB0 
		public Graphic graphic { get; } // 0x000000018D289CA4-0x000000018D289D6C 
	
		// Constructors
		public UIMusicVolumeVisual(); // 0x000000018D289C20-0x000000018D289CA4
		static UIMusicVolumeVisual(); // 0x000000018D289BA4-0x000000018D289C20
	
		// Methods
		protected void Start(); // 0x000000018D28994C-0x000000018D2899F8
		protected override void OnEnable(); // 0x000000018D289914-0x000000018D28994C
		protected override void OnDisable(); // 0x000000018D2898DC-0x000000018D289914
		public override void Tick(float deltaTime); // 0x000000018D2899F8-0x000000018D289BA4
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_OnDisable(); // 0x00000001828D23D0-0x00000001828D23E0
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	public class RiftScanUI : WorldUIController // TypeDefIndex: 80203
	{
		// Fields
		public const string CONTROLLER_STATE_RELEASE = "Release"; // Metadata: 0x0263C3C3
		public const string CONTROLLER_STATE_SUPPRESS = "Suppress"; // Metadata: 0x0263C3CB
		public const string CONTROLLER_STATE_PROCESSED = "Processed"; // Metadata: 0x0263C3D4
		public const float RIGHT_OFFSET = 1f; // Metadata: 0x0263C3DE
		public const float RIFT_CIRCLE_RADIUS = 11f; // Metadata: 0x0263C3E2
		private Entity m_targetEntity; // 0xC0
		private InteractiveRiftComponent m_riftComponent; // 0xC8
		private InteractiveRiftComponentData m_instanceData; // 0xD0
		public Transform pendingLayout; // 0xD8
		public UIText typeNameText; // 0xE0
		public UIText typePercentageTxtText; // 0xE8
		public UIStateController ctrlState; // 0xF0
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018D2859A4-0x000000018D2859E8 
	
		// Constructors
		public RiftScanUI(); // 0x000000018503EE80-0x000000018503EE90
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018D284CAC-0x000000018D284D30
		public override void DoRelease(); // 0x000000018D284B18-0x000000018D284B9C
		public override void SetUIForward(); // 0x000000018D28522C-0x000000018D2853BC
		public override void SetPos(); // 0x000000018D284DE4-0x000000018D28522C
		public override void TickUI(float deltaTime); // 0x000000018D2853BC-0x000000018D2853F8
		public override void InitUI(); // 0x000000018D284B9C-0x000000018D284CAC
		public override void RefreshUI(); // 0x000000018D284D30-0x000000018D284DE4
		private void _UpdateUI(int currentState); // 0x000000018D285740-0x000000018D2859A4
		private string _GetStateName(); // 0x000000018D2853F8-0x000000018D285524
		private string _GetTypeDesText(int currentState, int state, int amount, int amountMax); // 0x000000018D285524-0x000000018D28564C
		private string _GetTypePercentText(int amount, int amountMax); // 0x000000018D28564C-0x000000018D285740
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018D269394-0x000000018D26939C
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3); // 0x000000018D26936C-0x000000018D26937C
		public void __iFixBaseProxy_DoRelease(); // 0x000000018D26C890-0x000000018D26C898
		public void __iFixBaseProxy_SetUIForward(); // 0x000000018D269384-0x000000018D26938C
		public void __iFixBaseProxy_SetPos(); // 0x000000018D26937C-0x000000018D269384
		public void __iFixBaseProxy_TickUI(float P0); // 0x000000018D26938C-0x000000018D269394
		public void __iFixBaseProxy_InitUI(); // 0x000000018D26C898-0x000000018D26C8A0
		public void __iFixBaseProxy_RefreshUI(); // 0x000000018D26C8A0-0x000000018D26C8A8
	}

	public class TyphoeaArcheryCrosshairComp : MonoBehaviour // TypeDefIndex: 80204
	{
		// Fields
		public RectTransform rect; // 0x18
		public UIAnimationWrapper uiAnimationWrapper; // 0x20
		public UIStateController uiStateController; // 0x28
	
		// Constructors
		public TyphoeaArcheryCrosshairComp(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void UpdateComp(ITyphoeaArcheryLocking target, string animName, RectTransform parentRect); // 0x000000018D286F78-0x000000018D287154
	}

	[RequireComponent(typeof(UIImage))]
	public class UIBrokenLine : MonoBehaviour // TypeDefIndex: 80205
	{
		// Fields
		private Material m_material; // 0x18
		private const int MAX_SET_VALUE_COUNT = 21; // Metadata: 0x0263C3E8
		private const string UI_BROKEN_LINE_SHADER_NAME = "HGRP/UI/BrokenLine"; // Metadata: 0x0263C3E9
		private const string Y_VALUE_PROPERTY_NAME_FORMAT = "_YValue{0}"; // Metadata: 0x0263C3FC
		private const string X_SCALE_PROPERTY_NAME = "_XScale"; // Metadata: 0x0263C407
		private const string LINE_WEIGHT_PROPERTY_NAME = "_LineWidth"; // Metadata: 0x0263C40F
		private List<float> m_tmpList; // 0x20
		private bool m_isInit; // 0x28
		[SerializeField]
		private float _lineWeight; // 0x2C
	
		// Constructors
		public UIBrokenLine(); // 0x0000000186B27A80-0x0000000186B27B20
	
		// Methods
		private void Awake(); // 0x00000001853A17A0-0x00000001853A17E0
		private void _Init(); // 0x00000001853A17E0-0x00000001853A1A00
		private void OnDestroy(); // 0x0000000186C1D960-0x0000000186C1D9E0
		public void SetYValueByArray(float[] yValue, int count = 21 /* Metadata: 0x0263C3E6 */); // 0x000000018D287154-0x000000018D28725C
		public void SetYValue(List<float> yValue, int count = 21 /* Metadata: 0x0263C3E7 */); // 0x00000001853A2E20-0x00000001853A30F0
	}

	public class UICommonScanController : TickableUIMono // TypeDefIndex: 80206
	{
		// Fields
		[CompilerGenerated]
		private ulong _entityLogicId_k__BackingField; // 0x68
		protected Transform m_camera; // 0x70
		protected ObjectPtr<Entity> m_entity; // 0x78
		protected Transform m_followTarget; // 0x88
		public float yOffset; // 0x90
		public static readonly int STATE_ON; // 0x00
		public static readonly int STATE_OFF; // 0x04
		public const int MAX_HP_RATIO = 10000; // Metadata: 0x0263C41A
		public const float TICK_REFRESH_NEED = 0.1f; // Metadata: 0x0263C41E
		public const int DONT_REFRESH = 0; // Metadata: 0x0263C422
		private bool m_uiActive; // 0x94
		protected long m_nextRefreshTime; // 0x98
		protected float m_hpRatio; // 0xA0
		protected Vector3 m_fixedPoint; // 0xA4
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018D287A70-0x000000018D287AB4 
		public ulong entityLogicId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232F80-0x0000000187232F90 0x0000000187233460-0x0000000187233470
		protected bool uiActive { get; set; } // 0x000000018D287AB4-0x000000018D287AF8 0x000000018D287AF8-0x000000018D287B50
	
		// Constructors
		public UICommonScanController(); // 0x000000018503EE80-0x000000018503EE90
		static UICommonScanController(); // 0x000000018D287A20-0x000000018D287A70
	
		// Methods
		public virtual void SetTarget(Entity target, long nextRefresh, float hpRatio); // 0x000000018D28753C-0x000000018D287698
		private void _UpdatePos(); // 0x000000018D28788C-0x000000018D287A20
		public void SetFixPoint(Vector3 pos, ulong waterVolume); // 0x000000018D287354-0x000000018D28753C
		public override void Tick(float deltaTime); // 0x000000018D287698-0x000000018D2876E0
		private void _FaceToCamera(); // 0x000000018D2876E0-0x000000018D28788C
		public virtual void Clear(); // 0x000000018D28725C-0x000000018D287354
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	public class UICountDownBar : TickableUIMono // TypeDefIndex: 80207
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
		protected override TickType tickOption { get; } // 0x000000018D288068-0x000000018D2880AC 
		private bool update { get; set; } // 0x000000018D2880AC-0x000000018D2880F0 0x000000018D2880F0-0x000000018D288148
	
		// Constructors
		public UICountDownBar(); // 0x000000018503EE80-0x000000018503EE90
	
		// Methods
		public void InitData(int id, AbilitySystem target, CountDownShowAction.Data data); // 0x000000018D287BD8-0x000000018D287D2C
		public void Clear(); // 0x000000018D287B50-0x000000018D287BD8
		public override void LateTick(float deltaTime); // 0x000000018D287D2C-0x000000018D287D74
		private void _UpdateData(float deltaTime); // 0x000000018D287D74-0x000000018D287E24
		private void _UpdatePos(); // 0x000000018D287E24-0x000000018D288068
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public class UIDoodadMineCoreScanController : UICommonScanController // TypeDefIndex: 80208
	{
		// Fields
		public GameObject canMineIcon; // 0xB0
		public UIText formingText; // 0xB8
		public UIText purityText; // 0xC0
	
		// Constructors
		public UIDoodadMineCoreScanController(); // 0x000000018D2882CC-0x000000018D288318
	
		// Methods
		public void SyncConditonInfo(bool forming, string condition); // 0x000000018D288224-0x000000018D288278
		public void SetPurity(bool forming, string conditionText); // 0x000000018D288148-0x000000018D288224
		public void UpdateUI(bool forming, string condition); // 0x000000018D288278-0x000000018D2882CC
	}

	public class UIDoodadPlantCoreScanController : UICommonScanController // TypeDefIndex: 80209
	{
		// Fields
		private const uint OFF = 0; // Metadata: 0x0263C42B
		private const uint DARK = 1; // Metadata: 0x0263C42C
		private const uint LIGHT = 2; // Metadata: 0x0263C42D
		private const uint GROW = 4; // Metadata: 0x0263C42E
		public UIText coreNameText; // 0xB0
		public UIText coreSizeText; // 0xB8
		public GameObject refreshTimeRoot; // 0xC0
		public UIText refreshTimeText; // 0xC8
		public List<GameObject> flowerDark; // 0xD0
		public List<GameObject> flowerLight; // 0xD8
		public List<GameObject> flowerGrow; // 0xE0
		private float m_tickTimeSum; // 0xE8
	
		// Constructors
		public UIDoodadPlantCoreScanController(); // 0x000000018D2889F4-0x000000018D288B04
	
		// Methods
		public override void Tick(float deltaTime); // 0x000000018D2886B0-0x000000018D28875C
		public void SetCoreInfo(string coreName, string coreSize); // 0x000000018D288350-0x000000018D2883DC
		public void SetRefreshInfo(long nextRefreshTime = 0 /* Metadata: 0x0263C423 */); // 0x000000018D28853C-0x000000018D2885A4
		public void RefreshTextNow(); // 0x000000018D288318-0x000000018D288350
		public void SetQuantityInfo(int current, int nextRefresh, int maxCount); // 0x000000018D2883DC-0x000000018D28853C
		public void SetSingle(int index, uint state); // 0x000000018D2885A4-0x000000018D2886B0
		private void _SyncTimeText(); // 0x000000018D288764-0x000000018D2889F4
		public void __iFixBaseProxy_Tick(float P0); // 0x000000018D28875C-0x000000018D288764
	}

	public class UIDoodadScanController : UICommonScanController // TypeDefIndex: 80210
	{
		// Fields
		public UIText timeCom; // 0xB0
		public Transform refreshFull; // 0xB8
		public Transform refreshProgress; // 0xC0
		private float m_tickTimeSum; // 0xC8
	
		// Constructors
		public UIDoodadScanController(); // 0x000000018D2890E8-0x000000018D28913C
	
		// Methods
		public void SyncRefreshInfo(long nextRefresh, float hpRatio); // 0x000000018D288B04-0x000000018D288C00
		public override void Tick(float deltaTime); // 0x000000018D288C00-0x000000018D288CAC
		private void _RefreshCountDown(); // 0x000000018D288D44-0x000000018D2890E8
		public void UpdateUI(long nextRefresh, float hpRatio); // 0x000000018D288CAC-0x000000018D288D44
		public void __iFixBaseProxy_Tick(float P0); // 0x000000018D28875C-0x000000018D288764
	}

	public class UIGeneralTracker : MonoBehaviour // TypeDefIndex: 80211
	{
		// Fields
		[SerializeField]
		private Transform _arrowRotator; // 0x18
		private RectTransform m_rect; // 0x20
	
		// Properties
		private RectTransform rect { get; } // 0x000000018D289244-0x000000018D2892EC 
	
		// Constructors
		public UIGeneralTracker(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void UpdatePosition(Vector2 uiPos, float uiAngle, bool isOutBound); // 0x000000018D28913C-0x000000018D289244
	}

	public class UILiquidPoolScanController : UICommonScanController // TypeDefIndex: 80212
	{
		// Fields
		public GameObject unLimitGroup; // 0xB0
		public GameObject limitedGroup; // 0xB8
		public UIText currentAmountText; // 0xC0
		public UIText maxAmountText; // 0xC8
		public UIText waterNameText; // 0xD0
		private const string EMPTY_LIQUID = "ui_liquid_pool_scan_text_empty"; // Metadata: 0x0263C42F
		private LangKey m_key; // 0xD8
	
		// Constructors
		public UILiquidPoolScanController(); // 0x000000018D289858-0x000000018D2898DC
	
		// Methods
		public void SetWaterInfo(ulong waterId, int x, int y, int z); // 0x000000018D2892EC-0x000000018D289858
	}

	public class UIPanelBase : TickableUIMono // TypeDefIndex: 80213
	{
		// Fields
		public const string UI_SPRITE_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/{0}.png"; // Metadata: 0x0263C44E
		private LuaResourceLoader m_loader; // 0x68
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000186A712A0-0x0000000186A712D0 
	
		// Constructors
		public UIPanelBase(); // 0x00000001860C2CB0-0x00000001860C2D10
	
		// Methods
		protected override void OnRelease(); // 0x0000000186B8E670-0x0000000186B8E6C0
		public Sprite LoadSprite(string path, string name); // 0x0000000185FCF320-0x0000000185FCF3B0
		public Sprite LoadSpriteWithOutFormat(string path); // 0x0000000185EA3EA0-0x0000000185EA3F20
		public GameObject LoadGameObject(string path); // 0x0000000185A53230-0x0000000185A532B0
		protected string GetSpritePath(string path, string name); // 0x0000000185FCF3E0-0x0000000185FCF4A0
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
	}

	public class UIPowerPoleAutoConnectTracker : UIGeneralTracker // TypeDefIndex: 80216
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
		private IconGroup _udpipeLoaderIcon; // 0xA8
		[SerializeField]
		private IconGroup _udpipeUnloaderIcon; // 0xB0
		[SerializeField]
		private StatusHintGroup _statusHintGroup; // 0xB8
		private PowerAutoConnectStatus? m_currentStatus; // 0xC0
		private bool? m_currentUdpipeError; // 0xC8
	
		// Nested types
		[Serializable]
		public class IconGroup // TypeDefIndex: 80214
		{
			// Fields
			public GameObject root; // 0x10
			public Image normal; // 0x18
			public Image error; // 0x20
	
			// Properties
			public bool activeSelf { get; } // 0x000000018D2838B8-0x000000018D283900 
	
			// Constructors
			public IconGroup(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void SetActiveIfNecessary(bool active); // 0x000000018D283710-0x000000018D283760
			public void Switch(bool err); // 0x000000018D2837A0-0x000000018D283828
		}
	
		[Serializable]
		public class StatusHintGroup // TypeDefIndex: 80215
		{
			// Fields
			public GameObject root; // 0x10
			public GameObject localLinkHint; // 0x18
			public GameObject globalLinkHint; // 0x20
			public GameObject outageHint; // 0x28
			public GameObject distLimitHint; // 0x30
	
			// Constructors
			public StatusHintGroup(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Switch(PowerAutoConnectStatus status); // 0x000000018D286EDC-0x000000018D286F78
		}
	
		// Constructors
		public UIPowerPoleAutoConnectTracker(); // 0x000000018D28A79C-0x000000018D28A7F8
	
		// Methods
		public void UpdateDistance(float distance); // 0x000000018D289DF0-0x000000018D289EC8
		public void SetDistanceTextVisible(bool value); // 0x000000018D289DB0-0x000000018D289DF0
		private void _ActualUpdateStatus(PowerAutoConnectStatus status); // 0x000000018D28A514-0x000000018D28A79C
		public void UpdateStatus(PowerAutoConnectStatus status); // 0x000000018D28A03C-0x000000018D28A0EC
		public void UpdateStatusNormal(); // 0x000000018D289FB8-0x000000018D289FF8
		public void UpdateStatusTooFar(); // 0x000000018D289FF8-0x000000018D28A03C
		private void _ActualUdpipeError(bool error); // 0x000000018D28A1A0-0x000000018D28A3F4
		public void UpdateUdpipeError(bool error); // 0x000000018D28A0EC-0x000000018D28A1A0
		private void _ActualUpdateIcon(IconGroup img); // 0x000000018D28A3F4-0x000000018D28A514
		public void UpdateNodeType(int nodeType); // 0x000000018D289EC8-0x000000018D289FB8
	}

	public class UIPowerPoleFastTravelTracker : UIGeneralTracker // TypeDefIndex: 80218
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
		private bool isWarning { get; } // 0x000000018D28B56C-0x000000018D28B5B4 
		private bool isDisabled { get; } // 0x000000018D28B510-0x000000018D28B56C 
		public bool allowToHighlight { get; } // 0x000000018D28B1B0-0x000000018D28B214 
		private TravelPoleBrain.TravelPoleIcon iconStatus { get; set; } // 0x000000018D28B274-0x000000018D28B2B8 0x000000018D28B5F8-0x000000018D28B690
		private TravelPoleBrain.TravelPoleStatus status { get; set; } // 0x000000018D28B5B4-0x000000018D28B5F8 0x000000018D28B690-0x000000018D28B6E4
		private UIAnimationWrapper animationWrapper { get; } // 0x000000018D28B214-0x000000018D28B274 
		private GameObject imageNormal { get; } // 0x000000018D28B448-0x000000018D28B4AC 
		private GameObject imageWarning { get; } // 0x000000018D28B4AC-0x000000018D28B510 
		private GameObject imageDisabled { get; } // 0x000000018D28B2B8-0x000000018D28B31C 
		private GameObject imageHighlighted { get; } // 0x000000018D28B380-0x000000018D28B3E4 
		private GameObject imageNormalOther { get; } // 0x000000018D28B3E4-0x000000018D28B448 
		private GameObject imageHighlightedOther { get; } // 0x000000018D28B31C-0x000000018D28B380 
	
		// Nested types
		[Serializable]
		private struct TravelPoleStatusSetting // TypeDefIndex: 80217
		{
			// Fields
			[SerializeField]
			public bool showTextInfoBg; // 0x00
			[SerializeField]
			public GameObject textToShow; // 0x08
		}
	
		// Constructors
		public UIPowerPoleFastTravelTracker(); // 0x000000018D28B148-0x000000018D28B1B0
	
		// Methods
		public void PlayFocus(); // 0x000000018D28A83C-0x000000018D28A8B0
		public void UpdateIconStatus(TravelPoleBrain.TravelPoleIcon value); // 0x000000018D28A990-0x000000018D28A9D0
		public void UpdateStatus(TravelPoleBrain.TravelPoleStatus value); // 0x000000018D28AA50-0x000000018D28AA90
		public void UpdateIsHighlighted(bool value); // 0x000000018D28A9D0-0x000000018D28AA10
		public void UpdateIsOtherSocial(bool value); // 0x000000018D28AA10-0x000000018D28AA50
		public void UpdateDistance(Vector3 value); // 0x000000018D28A8B0-0x000000018D28A990
		private void _OnStatusChanged(); // 0x000000018D28AA90-0x000000018D28AD28
		private void _UpdateIcon(); // 0x000000018D28AD28-0x000000018D28B148
		private void OnEnable(); // 0x000000018D28A7F8-0x000000018D28A83C
	}

	public class UIRaceModuleRankController : TickableUIMono // TypeDefIndex: 80220
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
		public const string FIRST_ICON = "icon_racemodule_rank_1.png"; // Metadata: 0x0263C487
		public const string SECOND_ICON = "icon_racemodule_rank_2.png"; // Metadata: 0x0263C4A2
		public const string THIRD_ICON = "icon_racemodule_rank_3.png"; // Metadata: 0x0263C4BD
		public const string FOURTH_ICON = "icon_racemodule_rank_4.png"; // Metadata: 0x0263C4D8
		public const string FIFTH_ICON = "icon_racemodule_rank_5.png"; // Metadata: 0x0263C4F3
		private Sprite m_sprite1; // 0x90
		private Sprite m_sprite2; // 0x98
		private Sprite m_sprite3; // 0xA0
		private Sprite m_sprite4; // 0xA8
		private Sprite m_sprite5; // 0xB0
		private ERank m_rankEnum; // 0xB8
		private float m_restTime; // 0xBC
		private bool m_begin; // 0xC0
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018D28C18C-0x000000018D28C1D0 
	
		// Nested types
		public enum ERank // TypeDefIndex: 80219
		{
			None = 0,
			First = 1,
			Second = 2,
			Third = 3,
			Fourth = 4,
			Fifth = 5
		}
	
		// Constructors
		public UIRaceModuleRankController(); // 0x000000018D28C11C-0x000000018D28C18C
	
		// Methods
		private void _ResetData(); // 0x000000018D28BE7C-0x000000018D28BEC0
		protected override void OnAwake(); // 0x000000018D28B6E4-0x000000018D28B81C
		protected override void OnRelease(); // 0x000000018D28B81C-0x000000018D28B954
		private void _ShowBaseTrans(bool show = true /* Metadata: 0x0263C486 */); // 0x000000018D28BEC0-0x000000018D28BF7C
		private void _LoadAllSprite(); // 0x000000018D28BC18-0x000000018D28BE7C
		private void _UpdateRaceModuleRank([IsReadOnly] in EventData<int, float> rankData); // 0x000000018D28BF7C-0x000000018D28C11C
		public override void Tick(float deltaTime); // 0x000000018D28B954-0x000000018D28BC18
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	public class UIUdpipeConnectTracker : UIGeneralTracker // TypeDefIndex: 80223
	{
		// Fields
		[SerializeField]
		private GameObject _rootDistance; // 0x28
		[SerializeField]
		private UIText _textDistance; // 0x30
		[SerializeField]
		private UnityEngine.Color _textColorNormal; // 0x38
		[SerializeField]
		private UnityEngine.Color _textColorError; // 0x48
		[SerializeField]
		private float _activeScale; // 0x58
		[SerializeField]
		private IconGroup _defaultIcon; // 0x60
		[SerializeField]
		private IconGroup _udpipeLoaderIcon; // 0x68
		[SerializeField]
		private IconGroup _udpipeUnloaderIcon; // 0x70
		[SerializeField]
		private StatusHintGroup _statusHintGroup; // 0x78
		private bool? m_currentOutofRange; // 0x80
	
		// Nested types
		[Serializable]
		public class IconGroup // TypeDefIndex: 80221
		{
			// Fields
			public GameObject root; // 0x10
			public Image normal; // 0x18
			public Image error; // 0x20
	
			// Properties
			public bool activeSelf { get; } // 0x000000018D283900-0x000000018D283954 
	
			// Constructors
			public IconGroup(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void SetActiveIfNecessary(bool active); // 0x000000018D283760-0x000000018D2837A0
			public void Switch(bool err); // 0x000000018D283828-0x000000018D2838B8
		}
	
		[Serializable]
		public class StatusHintGroup // TypeDefIndex: 80222
		{
			// Fields
			public GameObject root; // 0x10
	
			// Constructors
			public StatusHintGroup(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Switch(bool outOfRange); // 0x000000018D286E9C-0x000000018D286EDC
		}
	
		// Constructors
		public UIUdpipeConnectTracker(); // 0x000000018D28C590-0x000000018D28C5E0
	
		// Methods
		public void UpdateDistance(float distance); // 0x000000018D28C1D0-0x000000018D28C2A8
		private void _ActualUpdateStatus(bool outOfRange); // 0x000000018D28C484-0x000000018D28C590
		public void UpdateStatus(bool outOfRange); // 0x000000018D28C334-0x000000018D28C3E8
		private void _ActualUpdateIcon(IconGroup img); // 0x000000018D28C3E8-0x000000018D28C484
		public void UpdateNodeType(int nodeType); // 0x000000018D28C2A8-0x000000018D28C334
	}

	public class UIVideoHelper : MonoBehaviour // TypeDefIndex: 80224
	{
		// Fields
		public CriManaMovieControllerForUI criMovieController; // 0x18
		public string videoPath; // 0x20
		public bool restartOnEnable; // 0x28
		private UIImage m_image; // 0x30
	
		// Constructors
		public UIVideoHelper(); // 0x000000018D28C818-0x000000018D28C864
	
		// Methods
		private void Reset(); // 0x000000018D28C794-0x000000018D28C818
		public void ResetVideo(); // 0x000000018D28C718-0x000000018D28C794
		private void Awake(); // 0x000000018D28C5E0-0x000000018D28C6B8
		private void OnEnable(); // 0x000000018D28C6B8-0x000000018D28C718
	}

	public class UIWorldCanvasResolutionScaleFit : MonoBehaviour, DeviceInfoManager.IScreenSizeListener // TypeDefIndex: 80225
	{
		// Fields
		private Vector3 m_authoredScale; // 0x18
		private bool m_isAuthoredScaleCached; // 0x24
	
		// Constructors
		public UIWorldCanvasResolutionScaleFit(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void Awake(); // 0x000000018D28E1D0-0x000000018D28E24C
		private void OnEnable(); // 0x000000018D28E374-0x000000018D28E4A8
		private void OnDisable(); // 0x000000018D28E24C-0x000000018D28E374
		public void OnScreenSizeChanged(int width, int height); // 0x000000018D28E4A8-0x000000018D28E4F4
		private void _ApplyScale(); // 0x000000018D28E4F4-0x000000018D28E63C
	}

	public class UIWaterDroneBar : TickableUIMono // TypeDefIndex: 80226
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
		public const float SLIDER_MAX_VALUE = 0.8277f; // Metadata: 0x0263C514
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
		protected override TickType tickOption { get; } // 0x000000018D28E18C-0x000000018D28E1D0 
	
		// Constructors
		public UIWaterDroneBar(); // 0x00000001871D5000-0x00000001871D5040
		static UIWaterDroneBar(); // 0x00000001871DCA70-0x00000001871DCAD0
	
		// Methods
		protected override void OnAwake(); // 0x000000018D28CE14-0x000000018D28D36C
		private void _OnWaterDroneInfinityLiquidChanged([IsReadOnly] in EventData<bool> data); // 0x000000018D28DB78-0x000000018D28DBD4
		private void _OnWaterDroneEmptyChanged([IsReadOnly] in EventData<bool> data); // 0x000000018D28DA10-0x000000018D28DA6C
		private void _OnWaterDroneInteractiveChanged([IsReadOnly] in EventData<string> data); // 0x000000018D28DBD4-0x000000018D28DC30
		private void _OnWaterDroneSourceTypeChanged([IsReadOnly] in EventData<WaterDroneSourceType> data); // 0x000000018D28DC9C-0x000000018D28DCF8
		private void _OnWaterDroneRelaxChanged([IsReadOnly] in EventData<bool> data); // 0x000000018D28DC30-0x000000018D28DC9C
		[IDTag(1)]
		private void _OnWaterDroneHydrantStateChanged([IsReadOnly] in EventData<CustomAbilityComponent.WaterDroneByHydrantState> data); // 0x000000018D28DB34-0x000000018D28DB78
		[IDTag(0)]
		private void _OnWaterDroneHydrantStateChanged(CustomAbilityComponent.WaterDroneByHydrantState state); // 0x000000018D28DA6C-0x000000018D28DB34
		protected override void OnEnable(); // 0x000000018D28D36C-0x000000018D28D4BC
		protected override void OnRelease(); // 0x000000018D28D4BC-0x000000018D28D830
		private void _OnWaterDroneChange(ObjectPtr<Entity> waterDronePtr); // 0x000000018D28D8BC-0x000000018D28DA10
		private void _ClearWaterDrone(); // 0x000000018D28D830-0x000000018D28D8BC
		public override void LateTick(float deltaTime); // 0x000000018D28C864-0x000000018D28CE14
		private void _UpdateState(); // 0x000000018D28DE54-0x000000018D28E18C
		private void _SetIconStateController(string stateName); // 0x000000018D28DCF8-0x000000018D28DDA0
		private void _UpdateSlider(); // 0x000000018D28DDA0-0x000000018D28DE54
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public class WaterDroneJoystickCtrl : MonoBehaviour // TypeDefIndex: 80227
	{
		// Fields
		[SerializeField]
		private UIJoystick _joystick; // 0x18
		public float cameraInputScaleX; // 0x20
		public float cameraInputScaleY; // 0x24
	
		// Constructors
		public WaterDroneJoystickCtrl(); // 0x000000018722E6C0-0x000000018722E6F0
	}

	public class WorldUIController : TickableMono // TypeDefIndex: 80228
	{
		// Fields
		[CompilerGenerated]
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
		public ulong entityLogicId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232F80-0x0000000187232F90 0x0000000187233460-0x0000000187233470
		protected override TickType tickOption { get; } // 0x000000018D28EC48-0x000000018D28EC8C 
		protected bool uiActive { get; set; } // 0x000000018D28EC8C-0x000000018D28ECD0 0x000000018D28ECD0-0x000000018D28ED28
	
		// Constructors
		public WorldUIController(); // 0x000000018503EE80-0x000000018503EE90
	
		// Methods
		public virtual void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018D28E890-0x000000018D28E9F4
		public virtual void TryGetNeedComponent(); // 0x000000018D28EB7C-0x000000018D28EC48
		public virtual void SetPos(); // 0x000000018D28EA90-0x000000018D28EAC4
		public virtual void SetUIForward(); // 0x000000018D28EAC4-0x000000018D28EAF8
		public virtual void FaceToCamera(); // 0x000000018D28E6B0-0x000000018D28E85C
		public virtual void InitUI(); // 0x000000018D28E85C-0x000000018D28E890
		public virtual void RefreshUI(); // 0x000000018D28EA5C-0x000000018D28EA90
		public override void Tick(float deltaTime); // 0x000000018D28EB2C-0x000000018D28EB7C
		public virtual void TickUI(float deltaTime); // 0x000000018D28EAF8-0x000000018D28EB2C
		public virtual void Clear(); // 0x000000018D28E63C-0x000000018D28E67C
		protected override void OnRelease(); // 0x000000018D28E9F4-0x000000018D28EA5C
		public virtual void DoRelease(); // 0x000000018D28E67C-0x000000018D28E6B0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
	}

	public class WorldUIFollowAndFaceCamera : TickableUIMono // TypeDefIndex: 80229
	{
		// Fields
		public Transform followTarget; // 0x68
		public Vector3 followOffset; // 0x70
		[Tooltip("\u9759\u6B62\u76EE\u6807\u53EA\u5728\u521D\u59CB\u5316\u65F6\u66F4\u65B0\u4F4D\u7F6E\uFF0C\u4E4B\u540E\u4EC5\u66F4\u65B0\u671D\u5411")]
		public bool isTargetStatic; // 0x7C
		[Tooltip("\u52FE\u9009\u540E\u5FFD\u7565 followTarget\uFF0C\u4F7F\u7528 followPosition \u4F5C\u4E3A\u8DDF\u968F\u4F4D\u7F6E")]
		public bool useFixedPosition; // 0x7D
		public Vector3 followPosition; // 0x80
		private Transform m_camera; // 0x90
		private bool m_posInited; // 0x98
		private NPCAvatarMountPointInfo m_npcMountPointInfo; // 0xA0
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018D28F700-0x000000018D28F744 
	
		// Constructors
		public WorldUIFollowAndFaceCamera(); // 0x000000018D28F6AC-0x000000018D28F700
	
		// Methods
		protected override void OnAwake(); // 0x000000018D28EDFC-0x000000018D28EE54
		protected override void OnEnable(); // 0x000000018D28EE54-0x000000018D28EEB4
		public override void LateTick(float deltaTime); // 0x000000018D28ED28-0x000000018D28EDFC
		private void _TryCacheCamera(); // 0x000000018D28F418-0x000000018D28F524
		private void _UpdatePosition(); // 0x000000018D28F524-0x000000018D28F6AC
		private void _FaceCamera(); // 0x000000018D28F338-0x000000018D28F418
		public void SetFollowTarget(Transform target, Vector3 offset, bool isStatic = false /* Metadata: 0x0263C518 */); // 0x000000018D28F204-0x000000018D28F338
		public void SetFollowPosition(Vector3 position, Vector3 offset = default); // 0x000000018D28F100-0x000000018D28F204
		public void SetFollowNpcHeadLabel(Entity entity, Vector3 offset = default); // 0x000000018D28EEB4-0x000000018D28F100
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}
}

namespace Beyond.UI.Mission
{
	public class MissionHudBGSizeUpdater : TickableUIMono // TypeDefIndex: 80230
	{
		// Fields
		public RectTransform bgTransform; // 0x68
		public RectTransform objectiveList; // 0x70
		public RectTransform objectiveContent; // 0x78
		public RectTransform leftLayoutTransform; // 0x80
		public VerticalLayoutGroup leftNodeVerticalLayoutGroup; // 0x88
		public float bgSizeGetterDeltaY; // 0x90
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000186E1B010-0x0000000186E1B040 
	
		// Constructors
		public MissionHudBGSizeUpdater(); // 0x00000001872210A0-0x00000001872210C0
	
		// Methods
		public override void LateTick(float deltaTime); // 0x00000001856A4EC0-0x00000001856A4EF0
		public void UpdateBgSize(); // 0x00000001856A4D90-0x00000001856A4EC0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 79986
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 80233
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x000000018D2836AC-0x000000018D283710
	
		// Methods
		public void __Gen_Wrap_0(); // 0x00000001887ED074-0x00000001887ED104
		public bool __Gen_Wrap_1(object P0); // 0x0000000188B46E14-0x0000000188B46ED4
		public ObjectPtr<AbilitySystem> __Gen_Wrap_2(object P0); // 0x000000018D280980-0x000000018D280A78
		public void __Gen_Wrap_3(object P0, bool P1); // 0x000000018936C508-0x000000018936C5D8
		public void __Gen_Wrap_4(object P0, float P1); // 0x000000018936ABF4-0x000000018936ACC4
		public void __Gen_Wrap_5(object P0, ObjectPtr<Buff> P1, bool P2, Buff.FinishReason P3); // 0x000000018D282508-0x000000018D282638
		public void __Gen_Wrap_6(object P0, object P1); // 0x0000000188B47220-0x0000000188B472F0
		public void __Gen_Wrap_7(object P0); // 0x00000001887ED758-0x00000001887ED80C
		public bool __Gen_Wrap_8(object P0, ObjectPtr<Buff> P1); // 0x000000018D2834B8-0x000000018D2835CC
		public Buff __Gen_Wrap_9(object P0); // 0x000000018D2835CC-0x000000018D2836AC
		public void __Gen_Wrap_10(object P0, ObjectPtr<Buff> P1, object P2); // 0x000000018D27F918-0x000000018D27FA38
		public GameplayMiscSetting __Gen_Wrap_11(object P0); // 0x000000018D27FA38-0x000000018D27FB18
		public void __Gen_Wrap_12(object P0, object P1, bool P2); // 0x000000018936C33C-0x000000018936C428
		public void __Gen_Wrap_13(object P0, int P1); // 0x0000000188B4D6D0-0x0000000188B4D7A0
		public void __Gen_Wrap_14(object P0, ObjectPtr<Buff> P1); // 0x000000018D27FB18-0x000000018D27FC1C
		public TickType __Gen_Wrap_15(object P0); // 0x00000001887EBA14-0x00000001887EBAD4
		public RectTransform __Gen_Wrap_16(object P0); // 0x000000018D27FC1C-0x000000018D27FCFC
		public Vector3 __Gen_Wrap_17(object P0, object P1, bool P2); // 0x000000018D27FCFC-0x000000018D27FE30
		public UIAnimationWrapper __Gen_Wrap_18(object P0); // 0x000000018D27FE30-0x000000018D27FF10
		public void __Gen_Wrap_19(object P0, object P1, Vector3 P2); // 0x000000018D27FF10-0x000000018D280038
		public void __Gen_Wrap_20(object P0, in EventData<int, float, float> P1); // 0x000000018D280038-0x000000018D280154
		public Vector3 __Gen_Wrap_21(); // 0x000000018D280154-0x000000018D28023C
		public DamageTextBase __Gen_Wrap_22(object P0, DamageTextType P1); // 0x000000018D28023C-0x000000018D280338
		public void __Gen_Wrap_23(object P0, object P1, int P2); // 0x000000018C0C2668-0x000000018C0C2750
		public void __Gen_Wrap_24(object P0, UnityEngine.Color P1); // 0x000000018D280338-0x000000018D28043C
		public void __Gen_Wrap_25(object P0, object P1, object P2, Vector3? P3); // 0x000000018D28043C-0x000000018D280570
		public Vector2 __Gen_Wrap_26(object P0); // 0x000000018D280570-0x000000018D280650
		public void __Gen_Wrap_27(object P0, Vector2 P1); // 0x000000018D280650-0x000000018D28075C
		public Vector3 __Gen_Wrap_28(object P0); // 0x000000018D28075C-0x000000018D280864
		public Vector2 __Gen_Wrap_29(object P0, float P1, float P2); // 0x000000018D280864-0x000000018D280980
		public bool __Gen_Wrap_30(object P0, Vector3 P1); // 0x000000018D280A78-0x000000018D280B94
		public void __Gen_Wrap_31(object P0, in EventData<AbilitySystem.Modifier> P1); // 0x000000018D280B94-0x000000018D280D2C
		public void __Gen_Wrap_32(object P0, EnergyShardType P1, bool P2); // 0x000000018C0CA6D4-0x000000018C0CA7BC
		public void __Gen_Wrap_33(object P0, in EventData<AbilitySystem, Vector3, Vector2, string, EnergyShardType> P1); // 0x000000018D280D2C-0x000000018D280E50
		public void __Gen_Wrap_34(object P0, in EventData<AbilitySystem, Vector3, Vector2, string> P1); // 0x000000018D280E50-0x000000018D280F78
		public void __Gen_Wrap_35(object P0, in EventData<AbilitySystem, AbilitySystemForEnemyPart, PhysicalInflictionType> P1); // 0x000000018D280F78-0x000000018D281098
		public void __Gen_Wrap_36(object P0, in EventData<bool> P1); // 0x000000018D281098-0x000000018D2811B0
		public void __Gen_Wrap_37(object P0, in EventData<Vector3, string, UnityEngine.Color> P1); // 0x000000018D2811B0-0x000000018D2812D8
		public void __Gen_Wrap_38(object P0, in EventData<ulong, int> P1); // 0x000000018D2812D8-0x000000018D2813EC
		public void __Gen_Wrap_39(object P0, object P1, object P2); // 0x00000001887EF660-0x00000001887EF74C
		public DamageTextBaseV2 __Gen_Wrap_40(object P0, DamageTextType P1, object P2); // 0x000000018D2813EC-0x000000018D281504
		public float __Gen_Wrap_41(object P0); // 0x000000018936AA54-0x000000018936AB14
		public void __Gen_Wrap_42(object P0, Vector3 P1); // 0x000000018D281504-0x000000018D281610
		public void __Gen_Wrap_43(object P0, object P1, Vector3 P2, float P3); // 0x000000018D281610-0x000000018D28174C
		public void __Gen_Wrap_44(object P0, object P1, bool P2, float P3); // 0x000000018936B640-0x000000018936B740
		public void __Gen_Wrap_45(object P0, object P1, object P2, Vector3? P3, float P4); // 0x000000018D28174C-0x000000018D281894
		public Vector2 __Gen_Wrap_46(object P0, float P1, float P2, bool P3, Vector3 P4); // 0x000000018D281894-0x000000018D281A00
		public void __Gen_Wrap_47(object P0, object P1, object P2, int P3); // 0x000000018C0DDA8C-0x000000018C0DDB8C
		public void __Gen_Wrap_48(object P0, Vector2 P1, float P2); // 0x000000018D281A00-0x000000018D281B28
		public HeadBarCtrl.HeadBarType __Gen_Wrap_49(ObjectPtr<AbilitySystem> P0); // 0x000000018D281B28-0x000000018D281C20
		public bool __Gen_Wrap_50(object P0, out Vector3 P1); // 0x000000018D281C20-0x000000018D281D54
		public void __Gen_Wrap_51(object P0, bool P1, bool P2); // 0x000000018D281D54-0x000000018D281E40
		public void __Gen_Wrap_52(object P0, object P1, float P2); // 0x0000000188B4B9A8-0x0000000188B4BA94
		public void __Gen_Wrap_53(object P0, object P1, double P2); // 0x000000018D281E40-0x000000018D281F2C
		public void __Gen_Wrap_54(object P0, object P1, double P2, bool P3); // 0x000000018D281F2C-0x000000018D28202C
		public void __Gen_Wrap_55(object P0, in AbilitySystem.Modifier P1); // 0x000000018D28202C-0x000000018D2821C4
		public void __Gen_Wrap_56(object P0, HeadBarCtrl.HeadBarRefreshReason P1); // 0x0000000188B4D6D0-0x0000000188B4D7A0
		public void __Gen_Wrap_57(object P0, in EventData<string, Entity> P1); // 0x000000018D2821C4-0x000000018D2822D8
		public void __Gen_Wrap_58(object P0, in EventData<bool, DialogEnums.DialogType> P1); // 0x000000018D2822D8-0x000000018D2823F0
		public void __Gen_Wrap_59(object P0, in EventData<AbilitySystem> P1); // 0x000000018D2823F0-0x000000018D282508
		public void __Gen_Wrap_60(object P0, in EventData<AbilitySystem, bool> P1); // 0x000000018D282638-0x000000018D28274C
		public void __Gen_Wrap_61(object P0, in EventData<AbilitySystemForEnemyPart, bool> P1); // 0x000000018D28274C-0x000000018D282860
		public void __Gen_Wrap_62(object P0, in EventData<AbilitySystem, ObjectPtr<Buff>, bool, Buff.FinishReason> P1); // 0x000000018D282860-0x000000018D28297C
		public string __Gen_Wrap_63(object P0, ObjectPtr<AbilitySystem> P1); // 0x000000018D28297C-0x000000018D282AA0
		public BuffIconConfig.BuffIconStyle __Gen_Wrap_64(object P0, object P1); // 0x0000000188B4BB74-0x0000000188B4BC54
		public BuffData __Gen_Wrap_65(object P0); // 0x000000018D282AA0-0x000000018D282B80
		public void __Gen_Wrap_66(Sprite P0); // 0x00000001887ED758-0x00000001887ED80C
		public void __Gen_Wrap_67(object P0, ObjectPtr<Buff> P1, object P2, object P3); // 0x000000018D282B80-0x000000018D282CB4
		public void __Gen_Wrap_68(object P0, int P1, bool P2); // 0x000000018C0CA6D4-0x000000018C0CA7BC
		public int __Gen_Wrap_69(object P0); // 0x00000001887EBA14-0x00000001887EBAD4
		public ulong __Gen_Wrap_70(object P0); // 0x0000000188AB6D9C-0x0000000188AB6E5C
		public UIBuffCell __Gen_Wrap_71(object P0, object P1); // 0x000000018D282CB4-0x000000018D282DB4
		public void __Gen_Wrap_72(object P0, ObjectPtr<Buff> P1, bool P2); // 0x000000018D282DB4-0x000000018D282ED4
		public UIPoiseKnot __Gen_Wrap_73(object P0); // 0x000000018D282ED4-0x000000018D282FB4
		public AbilitySystem __Gen_Wrap_74(object P0); // 0x000000018D282FB4-0x000000018D283094
		public void __Gen_Wrap_75(object P0, object P1, bool P2, bool P3, object P4); // 0x000000018C0C9A50-0x000000018C0C9B64
		public void __Gen_Wrap_76(object P0, ObjectPtr<Buff> P1, Buff.FinishReason P2); // 0x000000018D283094-0x000000018D2831B4
		public void __Gen_Wrap_77(object P0, ObjectPtr<AbilitySystem> P1); // 0x000000018D2831B4-0x000000018D2832B8
		public void __Gen_Wrap_78(object P0, double P1); // 0x000000018C0E03C0-0x000000018C0E0490
		public void __Gen_Wrap_79(object P0, object P1, float P2, bool P3); // 0x000000018D2832B8-0x000000018D2833B8
		public void __Gen_Wrap_80(object P0, object P1, bool P2, int P3); // 0x000000018D2833B8-0x000000018D2834B8
		public void __Gen_Wrap_81(object P0, object P1, int P2, int P3); // 0x000000018C0CA7BC-0x000000018C0CA8B8
		public void __Gen_Wrap_82(object P0, in EventData<bool, bool, float, AbilitySystem> P1); // 0x0000000184F434A0-0x0000000184F43B20
		public Vector3 __Gen_Wrap_83(object P0, object P1); // 0x0000000184F43B20-0x0000000184F444E0
		public string __Gen_Wrap_84(object P0, object P1, object P2); // 0x0000000184F444E0-0x0000000184F44FD0
		public Sprite __Gen_Wrap_85(object P0, object P1, object P2); // 0x0000000184F44FD0-0x0000000184F45AC0
		public BattleManager __Gen_Wrap_86(object P0); // 0x0000000184F45AC0-0x0000000184F463E0
		public SkillSetting __Gen_Wrap_87(object P0); // 0x0000000184F463E0-0x0000000184F46D00
		public float __Gen_Wrap_88(object P0, int P1, float P2); // 0x0000000182DF45F0-0x0000000182DF48F0
		public void __Gen_Wrap_89(object P0, in EventData<float> P1); // 0x0000000184F46D00-0x0000000184F47390
		public void __Gen_Wrap_90(object P0, float P1, float P2, object P3); // 0x00000001837E4A80-0x00000001837E4E50
		public ComboSkillHint __Gen_Wrap_91(object P0, int P1); // 0x0000000184F47390-0x0000000184F47CE0
		public void __Gen_Wrap_92(object P0, object P1, int P2, bool P3); // 0x000000018247CB50-0x000000018247CF10
		public GameObject __Gen_Wrap_93(object P0, object P1); // 0x0000000184F47CE0-0x0000000184F486E0
		public void __Gen_Wrap_94(object P0, in EventData<int> P1); // 0x0000000184F486E0-0x0000000184F48D60
		public void __Gen_Wrap_95(object P0, in EventData<ulong, string> P1); // 0x0000000184F48D60-0x0000000184F493E0
		public string __Gen_Wrap_96(object P0); // 0x0000000184F493E0-0x0000000184F49D00
		public bool __Gen_Wrap_97(object P0, out GPUIExtendedSystem P1, out GPUIHandle P2); // 0x0000000184F49D00-0x0000000184F4AA10
		public bool __Gen_Wrap_98(object P0, object P1, float P2); // 0x0000000182EB8C60-0x0000000182EB9010
		public bool __Gen_Wrap_99(object P0, object P1, object P2); // 0x000000018252A430-0x000000018252A890
		public bool __Gen_Wrap_100(object P0, object P1, out float P2); // 0x0000000182E1E3D0-0x0000000182E1E7A0
		public bool __Gen_Wrap_101(object P0, object P1, object P2, out float P3); // 0x0000000184F1AF90-0x0000000184F1B430
		public bool __Gen_Wrap_102(object P0, object P1); // 0x00000001827B9DC0-0x00000001827BA150
		public bool __Gen_Wrap_103(object P0, object P1, bool P2); // 0x00000001826B7CB0-0x00000001826B8050
		public bool __Gen_Wrap_104(object P0, Vector2 P1); // 0x0000000184F1B430-0x0000000184F1BAC0
		public bool __Gen_Wrap_105(object P0, object P1, UnityEngine.Color P2); // 0x0000000184F1BAC0-0x0000000184F1C210
		public void __Gen_Wrap_106(object P0, ulong P1, object P2, Buff.FinishReason P3, object P4, object P5); // 0x0000000184F1C210-0x0000000184F1C780
		public void __Gen_Wrap_107(object P0, ObjectPtr<Buff> P1, Buff.FinishReason P2, object P3, object P4); // 0x0000000184F1C780-0x0000000184F1CFD0
		public void __Gen_Wrap_108(object P0, object P1, object P2, bool P3); // 0x00000001827A62D0-0x00000001827A6740
		public GPUIBuffCell __Gen_Wrap_109(object P0, object P1, object P2); // 0x0000000184F1CFD0-0x0000000184F1DAC0
		public void __Gen_Wrap_110(object P0, ObjectPtr<Buff> P1, bool P2, object P3, object P4); // 0x0000000184F1DAC0-0x0000000184F1E310
		public void __Gen_Wrap_111(object P0, in EventData<GlobalBuff, string> P1); // 0x0000000184F1E310-0x0000000184F1E990
		public void __Gen_Wrap_112(object P0, in EventData<GlobalBuff, string, GlobalBuff.FinishReason> P1); // 0x0000000184F1E990-0x0000000184F1F020
		public ObjectPtr<Buff> __Gen_Wrap_113(object P0); // 0x0000000184F1F020-0x0000000184F1F900
		public void __Gen_Wrap_114(UISpellInflictionOnCharCell P0, int P1); // 0x00000001824828A0-0x0000000182482B70
		public ObjectPtr<Buff> __Gen_Wrap_115(object P0, object P1); // 0x0000000184F1F900-0x0000000184F202C0
		public UICharPassiveBase __Gen_Wrap_116(object P0, object P1); // 0x0000000184F202C0-0x0000000184F20CC0
		public void __Gen_Wrap_117(object P0, in EventData<SetLeaderReason, Entity, Entity> P1); // 0x0000000184F20CC0-0x0000000184F21350
		public OutOfScreenTargetArrow __Gen_Wrap_118(object P0); // 0x0000000184F21350-0x0000000184F21C70
		public ValueTuple<Vector2, float> __Gen_Wrap_119(object P0, Vector3 P1); // 0x0000000184F21C70-0x0000000184F228D0
		public bool __Gen_Wrap_120(object P0, out OutOfScreenTargetsCtrlV2.ArrowRuntimeState P1); // 0x0000000184F228D0-0x0000000184F232E0
		public void __Gen_Wrap_121(object P0, in EventData<ulong, uint> P1); // 0x0000000184F232E0-0x0000000184F23960
		public void __Gen_Wrap_122(object P0, in EventData<ulong, string, int> P1); // 0x0000000184F23960-0x0000000184F23FF0
		public void __Gen_Wrap_123(object P0, in EventData<Skill> P1); // 0x0000000184F23FF0-0x0000000184F24670
		public Sprite __Gen_Wrap_124(object P0, object P1); // 0x0000000184F24670-0x0000000184F25070
		public void __Gen_Wrap_125(object P0, in EventData<string> P1); // 0x0000000184F25070-0x0000000184F256F0
		public void __Gen_Wrap_126(object P0, int P1, bool P2, bool P3); // 0x0000000182466F50-0x0000000182467260
		public bool __Gen_Wrap_127(object P0, bool P1); // 0x000000018251D250-0x000000018251D540
		public void __Gen_Wrap_128(object P0, in EventData<ulong, string, EnergyShardType> P1); // 0x0000000184F256F0-0x0000000184F25D80
		public void __Gen_Wrap_129(object P0, int P1, float P2); // 0x0000000182EEEE90-0x0000000182EEF180
		public void __Gen_Wrap_130(object P0, in EventData<UIStyleInputValidTypeMask> P1); // 0x0000000184F25D80-0x0000000184F26400
		public TweenCallback __Gen_Wrap_131(object P0); // 0x0000000184F26400-0x0000000184F26D20
		public void __Gen_Wrap_132(object P0, ObjectPtr<AbilitySystem> P1, object P2); // 0x0000000184F26D20-0x0000000184F27470
		public UITyphoeaLockingNode __Gen_Wrap_133(object P0); // 0x0000000184F27470-0x0000000184F27D90
		public void __Gen_Wrap_134(object P0, in EventData<Dictionary<ObjectPtr<AbilitySystem>, ObjectPtr<Buff>>> P1); // 0x0000000184F27D90-0x0000000184F28410
		public int __Gen_Wrap_135(object P0, object P1); // 0x0000000182224290-0x0000000182224620
		public void __Gen_Wrap_136(object P0, object P1, object P2, object P3); // 0x0000000182558BB0-0x00000001825590D0
		public void __Gen_Wrap_137(object P0, bool P1, float P2, float P3); // 0x0000000183C8EDE0-0x0000000183C8F100
		public void __Gen_Wrap_138(object P0, in EventData<CinematicTimelineManagerBase.TimelineHandle> P1); // 0x0000000184F28410-0x0000000184F28A90
		public void __Gen_Wrap_139(object P0, in EventData<ForbidType, bool> P1); // 0x0000000184F28A90-0x0000000184F29110
		public void __Gen_Wrap_140(object P0, int P1, int P2); // 0x00000001824F9690-0x00000001824F9980
		public void __Gen_Wrap_141(object P0, int P1, int P2, byte P3); // 0x0000000183C46AA0-0x0000000183C46DA0
		public void __Gen_Wrap_142(object P0, int P1, int P2, int P3, int P4, byte P5); // 0x0000000184F29110-0x0000000184F29440
		public byte __Gen_Wrap_143(object P0, int P1, int P2, out byte P3); // 0x0000000184F29440-0x0000000184F29760
		public void __Gen_Wrap_144(object P0, CommonTrackingPointStyleType P1, object P2); // 0x00000001824EC440-0x00000001824EC7E0
		public void __Gen_Wrap_145(object P0, CommonTrackingPointStyleType P1); // 0x00000001824828A0-0x0000000182482B70
		public void __Gen_Wrap_146(object P0, Vector2 P1, float P2, bool P3, float P4, bool P5); // 0x0000000184F29760-0x0000000184F29E60
		public void __Gen_Wrap_147(object P0, PosValueState P1, bool P2, Vector2 P3, float P4, bool P5, float P6, CommonTrackMapTier P7); // 0x0000000184F29E60-0x0000000184F2A5A0
		public CommonTrackerUpdate.CommonTrackerItem __Gen_Wrap_148(object P0); // 0x0000000184F2A5A0-0x0000000184F2AEC0
		public bool __Gen_Wrap_149(object P0, int P1, object P2, object P3); // 0x000000018334D810-0x000000018334DC90
		public void __Gen_Wrap_150(object P0, bool P1, int P2); // 0x0000000183041590-0x0000000183041880
		public void __Gen_Wrap_151(object P0, object P1, object P2, ulong P3, int P4); // 0x0000000182CB6B30-0x0000000182CB6FB0
		public string __Gen_Wrap_152(object P0, LangKey P1, object P2); // 0x0000000184F2AEC0-0x0000000184F2BC30
		public void __Gen_Wrap_153(object P0, CoolerUnitTemperatureCircleUI.ETemperatureState P1); // 0x00000001824828A0-0x0000000182482B70
		public void __Gen_Wrap_154(object P0, ref float P1, ref float P2); // 0x000000018400E500-0x000000018400E840
		public string[] __Gen_Wrap_155(); // 0x0000000184F2BC30-0x0000000184F2C450
		public bool __Gen_Wrap_156(object P0, ulong P1); // 0x0000000183952BF0-0x0000000183952ED0
		public void __Gen_Wrap_157(object P0, in EventData<string, uint, ulong> P1); // 0x0000000184F2C450-0x0000000184F2CAE0
		public GameObject __Gen_Wrap_158(object P0, object P1, object P2); // 0x0000000184F2CAE0-0x0000000184F2D5D0
		public void __Gen_Wrap_159(object P0, object P1, UnityEngine.Color P2); // 0x0000000184F2D5D0-0x0000000184F2DD10
		public uint __Gen_Wrap_160(object P0, object P1, object P2); // 0x0000000182BBDB10-0x0000000182BBDF70
		public void __Gen_Wrap_161(object P0, uint P1, object P2, object P3); // 0x0000000182541100-0x0000000182541570
		public void __Gen_Wrap_162(object P0, uint P1, object P2, bool P3, object P4); // 0x0000000183655F40-0x00000001836563D0
		public void __Gen_Wrap_163(object P0, uint P1, UnityEngine.Color P2); // 0x0000000184F2DD10-0x0000000184F2E380
		public void __Gen_Wrap_164(object P0, bool P1, float P2, object P3, object P4); // 0x0000000184E80E30-0x0000000184E812D0
		public void __Gen_Wrap_165(object P0, float P1, bool P2); // 0x0000000183F97130-0x0000000183F97430
		public void __Gen_Wrap_166(PointerEventData P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_167(float P0); // 0x0000000182541570-0x0000000182541760
		public void __Gen_Wrap_168(object P0, float P1, float P2, float P3, bool P4); // 0x0000000183C34E20-0x0000000183C35160
		public void __Gen_Wrap_169(object P0, float P1, float P2); // 0x0000000183E99C30-0x0000000183E99F30
		public void __Gen_Wrap_170(object P0, bool P1, bool P2, bool P3, ForgeIronTemperatureCircleUI.ETemperatureState P4); // 0x0000000184F2E380-0x0000000184F2E6B0
		public UIHeadLabel __Gen_Wrap_171(object P0); // 0x0000000184F2E6B0-0x0000000184F2EFD0
		public void __Gen_Wrap_172(object P0, UIHeadLabel.VisibleSource P1, bool P2); // 0x000000018258AE50-0x000000018258B140
		public void __Gen_Wrap_173(object P0, UIHeadLabel.HeadLabelType P1, UIHeadLabel.VisibleSource P2, bool P3, bool P4); // 0x0000000183090190-0x00000001830904C0
		public void __Gen_Wrap_174(object P0, bool P1, bool P2, bool P3); // 0x00000001835F5B00-0x00000001835F5E10
		public void __Gen_Wrap_175(bool P0); // 0x0000000182521C80-0x0000000182521E70
		public void __Gen_Wrap_176(object P0, object P1, HeadLabelDirty P2); // 0x0000000182528040-0x00000001825283D0
		public void __Gen_Wrap_177(object P0, object P1, object P2, HeadLabelViewContext P3); // 0x0000000182661FF0-0x0000000182662450
		public Transform __Gen_Wrap_178(object P0); // 0x0000000184F2EFD0-0x0000000184F2F8F0
		public Dictionary<string, RegionMap3DCfg> __Gen_Wrap_179(object P0); // 0x0000000184F2F8F0-0x0000000184F30210
		public void __Gen_Wrap_180(object P0, object P1, Vector3 P2, object P3); // 0x0000000184F30210-0x0000000184F30A30
		public bool __Gen_Wrap_181(Vector2 P0, float P1, UnityEngine.Rect P2); // 0x0000000184F30A30-0x0000000184F31360
		public void __Gen_Wrap_182(object P0, RegionMapShowType P1, object P2, object P3, float P4); // 0x0000000183F806C0-0x0000000183F80B40
		public Transform __Gen_Wrap_183(object P0, object P1); // 0x0000000184F31360-0x0000000184F31D60
		public Vector3 __Gen_Wrap_184(object P0, object P1, object P2, object P3); // 0x0000000184F31D60-0x0000000184F328D0
		public RegionMap3DCfg __Gen_Wrap_185(object P0, object P1); // 0x0000000184F328D0-0x0000000184F332D0
		public TweenerCore<Quaternion, Quaternion, NoOptions> __Gen_Wrap_186(object P0, float P1, object P2); // 0x0000000184F332D0-0x0000000184F33D00
		public MaterialPropertyBlock __Gen_Wrap_187(); // 0x0000000184F33D00-0x0000000184F34520
		public void __Gen_Wrap_188(object P0, in EventData<long, long> P1); // 0x0000000184F34520-0x0000000184F34BA0
		public Texture __Gen_Wrap_189(object P0); // 0x0000000184F34BA0-0x0000000184F354C0
		public UILevelMapFallbackDebugOverlay __Gen_Wrap_190(object P0); // 0x0000000184F354C0-0x0000000184F35DE0
		public TextMeshProUGUI __Gen_Wrap_191(object P0, ref TextMeshProUGUI P1, object P2, float P3, UnityEngine.Color P4, object P5, object P6, TextAlignmentOptions P7); // 0x0000000184F35DE0-0x0000000184F36EB0
		public string __Gen_Wrap_192(float P0, float P1); // 0x0000000184F36EB0-0x0000000184F37750
		public void __Gen_Wrap_193(object P0, Vector2 P1, Vector2 P2, float P3, float P4, object P5, object P6, bool P7, object P8, object P9); // 0x0000000184F37750-0x0000000184F38270
		public void __Gen_Wrap_194(object P0, Vector2 P1, Vector2 P2, float P3, UnityEngine.Color P4); // 0x0000000184F38270-0x0000000184F38D50
		public bool __Gen_Wrap_195(); // 0x0000000182541760-0x0000000182541930
		public MapStaticElementConditionExpression __Gen_Wrap_196(object P0); // 0x0000000184F38D50-0x0000000184F39670
		public List<RaycastResult> __Gen_Wrap_197(object P0); // 0x0000000184F39670-0x0000000184F39F90
		public LuaPanel __Gen_Wrap_198(object P0); // 0x0000000184F39F90-0x0000000184F3A8B0
		public int __Gen_Wrap_199(int P0, int P1); // 0x00000001825DB8C0-0x00000001825DBAD0
		public void __Gen_Wrap_200(object P0, int P1, int P2, int P3, int P4); // 0x00000001824EA8B0-0x00000001824EABD0
		public UnityEngine.Rect __Gen_Wrap_201(float P0, float P1, float P2, float P3); // 0x0000000184F3A8B0-0x0000000184F3B140
		public List<Vector2> __Gen_Wrap_202(object P0, Vector2 P1, Vector2 P2, float P3); // 0x0000000184F3B140-0x0000000184F3BEF0
		public Vector2 __Gen_Wrap_203(object P0, Vector2 P1); // 0x0000000184F3BEF0-0x0000000184F3CB30
		public Vector2 __Gen_Wrap_204(object P0, Vector2 P1, object P2, object P3); // 0x0000000184F3CB30-0x0000000184F3D930
		public Graphic __Gen_Wrap_205(object P0); // 0x0000000184F3D930-0x0000000184F3E250
		public string __Gen_Wrap_206(object P0, int P1, int P2, int P3, int P4); // 0x0000000184F3E250-0x0000000184F3EBE0
		public string __Gen_Wrap_207(object P0, int P1, int P2); // 0x0000000184F3EBE0-0x0000000184F3F550
		public void __Gen_Wrap_208(object P0, object P1, long P2, float P3); // 0x0000000183E96860-0x0000000183E96C20
		public void __Gen_Wrap_209(object P0, Vector3 P1, ulong P2); // 0x0000000184F3F550-0x0000000184F3FBE0
		public void __Gen_Wrap_210(object P0, int P1, object P2, object P3); // 0x0000000182541100-0x0000000182541570
		public void __Gen_Wrap_211(object P0, bool P1, object P2); // 0x00000001824FB4E0-0x00000001824FB880
		public void __Gen_Wrap_212(object P0, long P1); // 0x0000000182618CC0-0x0000000182618F90
		public void __Gen_Wrap_213(object P0, int P1, uint P2); // 0x00000001824F9690-0x00000001824F9980
		public void __Gen_Wrap_214(object P0, int P1, int P2, int P3); // 0x0000000182582090-0x0000000182582390
		public void __Gen_Wrap_215(object P0, long P1, float P2); // 0x0000000183BB8300-0x0000000183BB85F0
		public void __Gen_Wrap_216(object P0, Vector2 P1, float P2, bool P3); // 0x0000000184F3FBE0-0x0000000184F402A0
		public void __Gen_Wrap_217(object P0, ulong P1, int P2, int P3, int P4); // 0x000000018366CAB0-0x000000018366CDD0
		public void __Gen_Wrap_218(object P0, PowerAutoConnectStatus P1); // 0x00000001824828A0-0x0000000182482B70
		public TravelPoleBrain.TravelPoleIcon __Gen_Wrap_219(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public GameObject __Gen_Wrap_220(object P0); // 0x0000000184F402A0-0x0000000184F40BC0
		public void __Gen_Wrap_221(object P0, TravelPoleBrain.TravelPoleIcon P1); // 0x00000001824828A0-0x0000000182482B70
		public TravelPoleBrain.TravelPoleStatus __Gen_Wrap_222(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public void __Gen_Wrap_223(object P0, TravelPoleBrain.TravelPoleStatus P1); // 0x00000001824828A0-0x0000000182482B70
		public void __Gen_Wrap_224(object P0, in EventData<int, float> P1); // 0x0000000184F40BC0-0x0000000184F41240
		public void __Gen_Wrap_225(object P0, in EventData<WaterDroneSourceType> P1); // 0x0000000184F41240-0x0000000184F418C0
		public void __Gen_Wrap_226(object P0, CustomAbilityComponent.WaterDroneByHydrantState P1); // 0x00000001824828A0-0x0000000182482B70
		public void __Gen_Wrap_227(object P0, in EventData<CustomAbilityComponent.WaterDroneByHydrantState> P1); // 0x0000000184F418C0-0x0000000184F41F40
		public void __Gen_Wrap_228(object P0, ObjectPtr<Entity> P1); // 0x0000000184F41F40-0x0000000184F425B0
		public void __Gen_Wrap_229(object P0, object P1, Vector3 P2, bool P3); // 0x0000000184F425B0-0x0000000184F42D20
		public void __Gen_Wrap_230(object P0, Vector3 P1, Vector3 P2); // 0x0000000184F42D20-0x0000000184F434A0
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 80234
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018D28F744-0x000000018D28F7DC
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 80235
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018D28F9C8-0x000000018D28FA2C
		public static bool IsPatched(int id); // 0x000000018D28FAB8-0x000000018D28FB34
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018D28F880-0x000000018D28F94C
		public object CreateWrapper(int id); // 0x000000018D28F94C-0x000000018D28F9C8
		public object InitWrapperArray(int len); // 0x000000018D28FA2C-0x000000018D28FAB8
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018D28F7DC-0x000000018D28F880
	}

	public delegate void __HotPatchDelegate_0(); // TypeDefIndex: 80236; 0x0000000185B44B70-0x0000000185B44B80

	public enum HotPatchIDMAP0 // TypeDefIndex: 80237
	{
		Beyond-PoolCore-ListPoolInitializer_UI_Gameplay_Beyond-Initialize0 = 0,
		Beyond-PoolCore-ListPoolInitializer_UI_Gameplay_Beyond-InitializeAtRuntime0 = 0,
		Beyond-UI-BattleControllerInputController-Create0 = 0,
		Beyond-UI-BattleControllerInputController-DestroyInstance0 = 0,
		Beyond-UI-UICharPassiveBase-get_listenBuffIconChange0 = 1,
		Beyond-UI-UICharPassiveLiino-get_listenBuffIconChange0 = 1,
		Beyond-UI-UICharPassiveTyphoea-get_listenBuffIconChange0 = 1,
		Beyond-UI-UIHudFadeBase-get_globalNeedShow0 = 1,
		Beyond-UI-UIHudFadeController-get_needShow0 = 1,
		Beyond-UI-LiinoRandomLikeEffect-_SelectHalf0 = 1,
		Beyond-UI-ComboSpecialNodeRingQte-get_needTick0 = 1,
		Beyond-UI-DamageTextBase-get_isFollowingTransform0 = 1,
		Beyond-UI-DamageTextBaseV2-get_isFollowingTransform0 = 1,
		Beyond-UI-DamageTextBaseV2-get_isHitPointPosition0 = 1,
		Beyond-UI-DamageTextBaseV2-get_isActive0 = 1,
		Beyond-UI-HeadBarCtrl-get_forceHide0 = 1,
		Beyond-UI-UIAbilityTargetFollower-get_actualVisible0 = 1,
		Beyond-UI-UIAbilityTargetFollower-get_needUpdateTransform0 = 1,
		Beyond-UI-UITacticalItemBar-IsTacticalItemActive0 = 1,
		Beyond-UI-UIPoiseBar-get_hidePoiseBar0 = 1,
		Beyond-UI-UIHeadBarFollower-get_actualVisible0 = 1,
		Beyond-UI-UIVigilanceBar-get_actualVisible0 = 1,
		Beyond-UI-UIVigilanceBar-get_needUpdateTransform0 = 1,
		Beyond-UI-BattleControllerInputController-GetControllerIndicatorState0 = 1,
		Beyond-UI-GPUIBuffCell-get_canUpdateVisual0 = 1,
		Beyond-UI-GPUIBuffCell-_TryResolveGPUIProxy0 = 1,
		Beyond-UI-GPUIBuffCell-TryEnsureGPUIInstance0 = 1,
		Beyond-UI-GPUIBuffCell-get_isVisualInited0 = 1,
		Beyond-UI-GPUIBuffCell-_TryCreateGPUIInstance0 = 1,
		Beyond-UI-GPUIBuffCell-_TryDestroyGpuiInstance0 = 1,
		Beyond-UI-UISpellInflictionOnCharNode-get_isInCcDungeon0 = 1,
		Beyond-UI-MainCharHpBar-_CheckHpBarShowing0 = 1,
		Beyond-UI-SkillButton-PressHandler-get_needUpdate0 = 1,
		Beyond-UI-SkillButton-PressHandlerLongPress-get_needUpdate0 = 1,
		Beyond-UI-SkillButton-PressHandlerIndividualUltimate-get_needUpdate0 = 1,
		Beyond-UI-SkillButton-PressHandlerDrag-get_needUpdate0 = 1,
		Beyond-UI-SquadIcon-_MustUpdate0 = 1,
		Beyond-UI-BattleControllerInputController-CheckNormalAttackBtn0 = 1,
		Beyond-UI-CommonTrackerUpdate-get__inFactoryTopView0 = 1,
		Beyond-UI-UIHeadLabel-HeadLabelRootVisibleData-get_realVisible0 = 1,
		Beyond-UI-UILevelMapCommonStaticElement-EvaluateInitialVisibility0 = 1,
		Beyond-UI-UILevelMapMissionArea-get_coexistWithMissionTrack0 = 1,
		Beyond-UI-UILevelMapMissionArea-get_notNeedCheckCoexistBecauseOfRadius0 = 1,
		Beyond-UI-UILevelMapMissionArea-get_needCheckMissionTrackCoexist0 = 1,
		Beyond-UI-UILevelMapMissionArea-_IsCircleOutsideDisappearRect0 = 1,
		Beyond-UI-UISettlementRegion-GetNeedRefreshSettlementRegionTier0 = 1,
		Beyond-UI-ScratchOffLotteryCoating-FlagCompleteMarkPoint0 = 1,
		Beyond-UI-UICommonScanController-get_uiActive0 = 1,
		Beyond-UI-UICountDownBar-get_update0 = 1,
		Beyond-UI-UIPowerPoleAutoConnectTracker-IconGroup-get_activeSelf0 = 1,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_isWarning0 = 1,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_isDisabled0 = 1,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_allowToHighlight0 = 1,
		Beyond-UI-UIUdpipeConnectTracker-IconGroup-get_activeSelf0 = 1,
		Beyond-UI-WorldUIController-get_uiActive0 = 1,
		Beyond-UI-UICharPassiveBase-get_abilityPtr0 = 2,
		Beyond-UI-UICharPassiveBase-OnCreate0 = 3,
		Beyond-UI-UICharPassiveLiino-_SetTickRunning0 = 3,
		Beyond-UI-UICharPassiveTyphoea-OnCreate0 = 3,
		Beyond-UI-UICharPassiveTyphoea-_SetTickRunning0 = 3,
		Beyond-UI-UITyphoeaArrow-SetDecosVisible0 = 3,
		Beyond-UI-UITyphoeaArrow-PlayAnimation0 = 3,
		Beyond-UI-DamageTextDamageBase-PlayAnimation0 = 3,
		Beyond-UI-DamageTextCtrl-DebugChangeImpl0 = 3,
		Beyond-UI-DamageTextBaseV2-PlayAnimation0 = 3,
		Beyond-UI-DamageTextCtrlV2-DebugChangeImpl0 = 3,
		Beyond-UI-DamageTextCriticalLevel1-PlayAnimation0 = 3,
		Beyond-UI-DamageTextNormalLevel1-PlayAnimation0 = 3,
		Beyond-UI-HeadBarCtrl-_SetInDialog0 = 3,
		Beyond-UI-UIAbilityTargetFollower-_SetDistanceVisible0 = 3,
		Beyond-UI-UIBuffCell-SetStackElementActive0 = 3,
		Beyond-UI-UIBuffCell-SetWarningState0 = 3,
		Beyond-UI-UIBuffCell-SetVisible0 = 3,
		Beyond-UI-UIHeadBarFollower-SetHeadBarVisible0 = 3,
		Beyond-UI-UICountShieldNode-OnCountShieldUiChange0 = 3,
		Beyond-UI-UIHeadBar-_RefreshShowConfig0 = 3,
		Beyond-UI-UIPoiseKnot-SetVisible0 = 3,
		Beyond-UI-UIVigilanceBar-_SetVigilanceActive0 = 3,
		Beyond-UI-ComboSkillHint-SetRewardMode0 = 3,
		Beyond-UI-GPUIBuffCell-ClearAnimation0 = 3,
		Beyond-UI-GPUIBuffCell-SetStackElementActive0 = 3,
		Beyond-UI-GPUIAttachedBuffCell-SetStackElementActive0 = 3,
		Beyond-UI-GPUIBuffCell-SetWarningState0 = 3,
		Beyond-UI-GPUIBuffCell-SetVisible0 = 3,
		Beyond-UI-GPUIBuffCell-SetBuffIconOverrideActive0 = 3,
		Beyond-UI-GPUILifeTimeBuffCell-SetWarningState0 = 3,
		Beyond-UI-HpBarComboNode-_RefreshComboCount0 = 3,
		Beyond-UI-MainCharHpBar-_ClearBuffNode0 = 3,
		Beyond-UI-MainCharHpBar-SetGPUIBuffMode0 = 3,
		Beyond-UI-OutOfScreenTargetsCtrl-DebugChangeImpl0 = 3,
		Beyond-UI-OutOfScreenTargetsCtrlV2-DebugChangeImpl0 = 3,
		Beyond-UI-SkillButton-_RefreshDeadState0 = 3,
		Beyond-UI-SkillButton-_RefreshUltimateSkillCd0 = 3,
		Beyond-UI-SkillButton-_SetPressFillActive0 = 3,
		Beyond-UI-SkillButton-_SetGoActive0 = 3,
		Beyond-UI-SkillButton-ToggleControllerSkillIndicator0 = 3,
		Beyond-UI-SkillButton-SetEmpty0 = 3,
		Beyond-UI-SquadIcon-SetGPUIBuffMode0 = 3,
		Beyond-UI-SquadIcon-SetDeadState0 = 3,
		Beyond-UI-SquadIcon-_UpdateComboSkillIcon0 = 3,
		Beyond-UI-TacticalDotCell-SetDotUsedUp0 = 3,
		Beyond-UI-SquadIcon-SetEmpty0 = 3,
		Beyond-UI-SquadIcon-ToggleIndicator0 = 3,
		Beyond-UI-UIAbnormalBuffCell-SetWarningState0 = 3,
		Beyond-UI-UIAttachedBuffCell-SetStackElementActive0 = 3,
		Beyond-UI-UILifeTimeBuffCell-SetWarningState0 = 3,
		Beyond-UI-TyphoeaHudHintCell-ResetState0 = 3,
		Beyond-UI-TyphoeaHudCtrl-_SetMarkTargetActive0 = 3,
		Beyond-UI-TyphoeaHudCtrl-_SetHintCellsVisible0 = 3,
		Beyond-UI-TyphoeaHudHintCell-SetArrowEnable0 = 3,
		Beyond-UI-UIMainCharFootBar-_SetInDialog0 = 3,
		Beyond-UI-UIMainCharFootBarArc-_SetInDialog0 = 3,
		Beyond-UI-WorldUIController-set_uiActive0 = 3,
		Beyond-UI-FacRegionUpgradeEffectController-SetUpgradeState0 = 3,
		Beyond-UI-FacRegionUpgradeEffectController-SetSelectState0 = 3,
		Beyond-UI-FacRegionUpgradeEffectController-SetVisibleState0 = 3,
		Beyond-UI-UIFacTechTreePanel-SetDetailShownState0 = 3,
		Beyond-UI-UIHeadLabel-_TrySetComponentActive0 = 3,
		Beyond-UI-UIHeadLabel-_HideBubble0 = 3,
		Beyond-UI-UIHeadLabel-SetContextVisible0 = 3,
		Beyond-UI-UIHeadLabel-SetActive0 = 3,
		Beyond-UI-UICommonScanController-set_uiActive0 = 3,
		Beyond-UI-UICountDownBar-set_update0 = 3,
		Beyond-UI-UIPowerPoleAutoConnectTracker-SetDistanceTextVisible0 = 3,
		Beyond-UI-UIPowerPoleAutoConnectTracker-IconGroup-Switch0 = 3,
		Beyond-UI-UIPowerPoleAutoConnectTracker-_ActualUdpipeError0 = 3,
		Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateUdpipeError0 = 3,
		Beyond-UI-UIPowerPoleAutoConnectTracker-IconGroup-SetActiveIfNecessary0 = 3,
		Beyond-UI-UIPowerPoleFastTravelTracker-UpdateIsHighlighted0 = 3,
		Beyond-UI-UIPowerPoleFastTravelTracker-UpdateIsOtherSocial0 = 3,
		Beyond-UI-UIRaceModuleRankController-_ShowBaseTrans0 = 3,
		Beyond-UI-UIUdpipeConnectTracker-IconGroup-Switch0 = 3,
		Beyond-UI-UIUdpipeConnectTracker-StatusHintGroup-Switch0 = 3,
		Beyond-UI-UIUdpipeConnectTracker-_ActualUpdateStatus0 = 3,
		Beyond-UI-UIUdpipeConnectTracker-UpdateStatus0 = 3,
		Beyond-UI-UIUdpipeConnectTracker-IconGroup-SetActiveIfNecessary0 = 3,
		Beyond-UI-UICharPassiveBase-OnCharPassiveNumChanged0 = 4,
		Beyond-UI-UICharPassiveCounter-OnCharPassiveNumChanged0 = 4,
		Beyond-UI-UICharPassiveLiino-_UpdateDecoThresholds0 = 4,
		Beyond-UI-UICharPassiveLiino-_OnLateTick0 = 4,
		Beyond-UI-UICharPassiveLizhiyan-OnCharPassiveNumChanged0 = 4,
		Beyond-UI-UICharPassiveMultiStates-OnCharPassiveNumChanged0 = 4,
		Beyond-UI-UICharPassiveTyphoea-_OnTick0 = 4,
		Beyond-UI-UICharPassiveZhuangfy-OnCharPassiveNumChanged0 = 4,
		Beyond-UI-LiinoRandomLikeEffect-Tick0 = 4,
		Beyond-UI-ComboSpecialNodeBase-OnTick0 = 4,
		Beyond-UI-ComboSpecialNodeRingQte-OnTick0 = 4,
		Beyond-UI-DamageTextCtrl-Tick0 = 4,
		Beyond-UI-DamageTextCtrlV2-Tick0 = 4,
		Beyond-UI-DamageTextBase-TailLateTick0 = 4,
		Beyond-UI-FootBarDashCell-SetDashCount0 = 4,
		Beyond-UI-HeadBarCtrl-_UpdateSurroundingEnemies0 = 4,
		Beyond-UI-HeadBarCtrl-_UpdateHeadBar0 = 4,
		Beyond-UI-HeadBarCtrl-_UpdateLevelInfoBar0 = 4,
		Beyond-UI-HeadBarCtrl-_UpdateVigilanceBar0 = 4,
		Beyond-UI-HeadBarCtrl-_UpdateTacticalItemBar0 = 4,
		Beyond-UI-HeadBarCtrl-LateTick0 = 4,
		Beyond-UI-UIHeadBar-_UpdateHpDisplay0 = 4,
		Beyond-UI-UIHeadBar-_UpdateSpecialCountDown0 = 4,
		Beyond-UI-UIHeadBar-_UpdateScale0 = 4,
		Beyond-UI-UIPoiseBar-_UpdatePoiseDisplay0 = 4,
		Beyond-UI-UIPoiseBar-UpdatePoiseBar0 = 4,
		Beyond-UI-UIHeadBar-UpdateData0 = 4,
		Beyond-UI-UIHeadBarFollower-UpdateData0 = 4,
		Beyond-UI-UIHeadBuff-UpdateData0 = 4,
		Beyond-UI-UITacticalItemBar-UpdateData0 = 4,
		Beyond-UI-UIVigilanceBar-UpdateData0 = 4,
		Beyond-UI-AtbNode-_RefreshAtbCellFill0 = 4,
		Beyond-UI-AtbNode-LateTick0 = 4,
		Beyond-UI-ComboSkillHint-OnTick0 = 4,
		Beyond-UI-ComboSkillPanel-PreTick0 = 4,
		Beyond-UI-GPUIBuffCell-OnTick0 = 4,
		Beyond-UI-GPUIAttachedBuffCell-OnTick0 = 4,
		Beyond-UI-GPUIBuffNode-TailLateTick0 = 4,
		Beyond-UI-GPUILifeTimeBuffCell-OnTick0 = 4,
		Beyond-UI-MainCharHpBar-_SetHpFillAmount0 = 4,
		Beyond-UI-MainCharHpBar-_OnCharPassiveNumChanged0 = 4,
		Beyond-UI-MainCharHpBar-_UpdateHpDisplay0 = 4,
		Beyond-UI-UISpellInflictionOnCharNode-OnTick0 = 4,
		Beyond-UI-MainCharHpBar-LateTick0 = 4,
		Beyond-UI-OutOfScreenTargetsCtrl-LateTick0 = 4,
		Beyond-UI-OutOfScreenTargetsCtrlV2-LateTick0 = 4,
		Beyond-UI-SkillButton-_UpdateMainUI0 = 4,
		Beyond-UI-SkillButton-TailLateTick0 = 4,
		Beyond-UI-SkillButton-_SetPressFillAmount0 = 4,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnUpdate0 = 4,
		Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnUpdate0 = 4,
		Beyond-UI-SkillButton-PressHandlerDrag-OnUpdate0 = 4,
		Beyond-UI-SquadIcon-_OnCharPassiveNumChanged0 = 4,
		Beyond-UI-SquadIcon-LateTick0 = 4,
		Beyond-UI-UIBuffCell-OnTick0 = 4,
		Beyond-UI-UIAbnormalBuffCell-OnTick0 = 4,
		Beyond-UI-UIAttachedBuffCell-OnTick0 = 4,
		Beyond-UI-UIBuffNode-TailLateTick0 = 4,
		Beyond-UI-UILifeTimeBuffCell-OnTick0 = 4,
		Beyond-UI-TyphoeaHudCtrl-TailLateTick0 = 4,
		Beyond-UI-UIAbilityTargetFollower-UpdateData0 = 4,
		Beyond-UI-UIAbilityTargetFollower-TailLateTick0 = 4,
		Beyond-UI-UIMainCharFootBar-_OnDashCountChanged0 = 4,
		Beyond-UI-UIMainCharFootBar-LateTick0 = 4,
		Beyond-UI-UIMainCharFootBarArc-_OnDashCountChanged0 = 4,
		Beyond-UI-UIMainCharFootBarArc-_UpdateSplitDashRecoverAnimations0 = 4,
		Beyond-UI-UIMainCharFootBarArc-TailLateTick0 = 4,
		Beyond-UI-CoolerUnitProgressBarUI-_TickCanvasGroup0 = 4,
		Beyond-UI-CoolerUnitProgressBarUI-_UpdateProgress0 = 4,
		Beyond-UI-CoolerUnitProgressBarUI-TickUI0 = 4,
		Beyond-UI-CoolerUnitTemperatureCircleUI-_TickCanvasGroup0 = 4,
		Beyond-UI-CoolerUnitTemperatureCircleUI-TickUI0 = 4,
		Beyond-UI-CoolerUnitTemperatureUI-_TickCanvasGroup0 = 4,
		Beyond-UI-CoolerUnitTemperatureUI-_UpdateUIInfo0 = 4,
		Beyond-UI-CoolerUnitTemperatureUI-_UpdateUIPos0 = 4,
		Beyond-UI-CoolerUnitTemperatureUI-TickUI0 = 4,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_TickCanvasGroup0 = 4,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_UpdateProgress0 = 4,
		Beyond-UI-CoolerUnitTotalProgressBarUI-TickUI0 = 4,
		Beyond-UI-DoodadFactoryGasCoreScanUI-TickUI0 = 4,
		Beyond-UI-DoodadFactoryGasScanUI-TickUI0 = 4,
		Beyond-UI-FacLineCell-ChangeLineWidth0 = 4,
		Beyond-UI-UIFacTechTreePanel-Tick0 = 4,
		Beyond-UI-ForgeIronProgressBarUI-TickUI0 = 4,
		Beyond-UI-ForgeIronTemperatureCircleUI-TickUI0 = 4,
		Beyond-UI-ForgeIronTemperatureUI-TickUI0 = 4,
		Beyond-UI-HeadLabelCtrl-LateTick0 = 4,
		Beyond-UI-UIHeadLabel-LateTick0 = 4,
		Beyond-UI-UILevelMapFallbackDebugOverlay-LabelScreenScaleKeeper-LateTick0 = 4,
		Beyond-UI-UILevelMapLimitInRect-LateTick0 = 4,
		Beyond-UI-UILevelMapLine-LateTick0 = 4,
		Beyond-UI-UILevelMapLine-Init0 = 4,
		Beyond-UI-UILevelMapMissionArea-LateTick0 = 4,
		Beyond-UI-UILevelMapTouchPanelWrapper-Tick0 = 4,
		Beyond-UI-UIMusicVolumeVisual-Tick0 = 4,
		Beyond-UI-RiftScanUI-TickUI0 = 4,
		Beyond-UI-UICommonScanController-Tick0 = 4,
		Beyond-UI-UICountDownBar-_UpdateData0 = 4,
		Beyond-UI-UICountDownBar-LateTick0 = 4,
		Beyond-UI-UIDoodadPlantCoreScanController-Tick0 = 4,
		Beyond-UI-UIDoodadScanController-Tick0 = 4,
		Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateDistance0 = 4,
		Beyond-UI-UIRaceModuleRankController-Tick0 = 4,
		Beyond-UI-UIUdpipeConnectTracker-UpdateDistance0 = 4,
		Beyond-UI-UIWaterDroneBar-LateTick0 = 4,
		Beyond-UI-WorldUIController-TickUI0 = 4,
		Beyond-UI-WorldUIController-Tick0 = 4,
		Beyond-UI-WorldUIFollowAndFaceCamera-LateTick0 = 4,
		Beyond-UI-Mission-MissionHudBGSizeUpdater-LateTick0 = 4,
		Beyond-UI-UICharPassiveBase-OnBuffIconChange0 = 5,
		Beyond-UI-UICharPassiveLiino-OnBuffIconChange0 = 5,
		Beyond-UI-UICharPassiveTyphoea-OnBuffIconChange0 = 5,
		Beyond-UI-UIBuffNode-OnBuffIconChange0 = 5,
		Beyond-UI-UIHeadBar-_OnBuffIconChange0 = 5,
		Beyond-UI-GPUIBuffNode-OnBuffIconChange0 = 5,
		Beyond-UI-MainCharHpBar-_OnBuffIconChange0 = 5,
		Beyond-UI-UISpellInflictionOnCharNode-_OnBuffIconChange0 = 5,
		Beyond-UI-MainCharHpBar-_OnProgressBarBuffChange0 = 5,
		Beyond-UI-SkillButton-_OnBuffIconChange0 = 5,
		Beyond-UI-SquadIcon-_OnBuffIconChange0 = 5,
		Beyond-UI-UICharPassiveBase-OnBindBuffEvent0 = 6,
		Beyond-UI-UICharPassiveBase-OnBound0 = 6,
		Beyond-UI-UICharPassiveBase-OnBeforeUnbind0 = 6,
		Beyond-UI-UICharPassiveBase-OnUnbindBuffEvent0 = 6,
		Beyond-UI-UICharPassiveBase-Bind0 = 6,
		Beyond-UI-UICharPassiveLiino-_SetProgress0 = 6,
		Beyond-UI-UICharPassiveLiino-_CheckLoopThreshold0 = 6,
		Beyond-UI-UICharPassiveLiino-_InitDecoThresholds0 = 6,
		Beyond-UI-UICharPassiveLiino-OnBound0 = 6,
		Beyond-UI-UICharPassiveLiino-OnBeforeUnbind0 = 6,
		Beyond-UI-UICharPassiveTyphoea-OnBindBuffEvent0 = 6,
		Beyond-UI-UICharPassiveTyphoea-OnUnbindBuffEvent0 = 6,
		Beyond-UI-UICharPassiveTyphoea-OnBound0 = 6,
		Beyond-UI-UICharPassiveTyphoea-OnBeforeUnbind0 = 6,
		Beyond-UI-LiinoRandomLikeEffect-_CacheHideCallbacks0 = 6,
		Beyond-UI-ComboSpecialNodeBase-OnAssignData0 = 6,
		Beyond-UI-ComboSpecialNodeRingQte-OnAssignData0 = 6,
		Beyond-UI-DamageTextCtrl-_RecycleTextInstance0 = 6,
		Beyond-UI-DamageTextIgniteBuff-SetTextAndDuplication0 = 6,
		Beyond-UI-DamageTextBase-SetText2 = 6,
		Beyond-UI-DamageTextBaseV2-SetText2 = 6,
		Beyond-UI-DamageTextCtrlV2-_RemoveIgniteBuffCoalitionIfMatches0 = 6,
		Beyond-UI-DamageTextCtrlV2-_RecycleTextInstance0 = 6,
		Beyond-UI-UIAbilityTargetFollower-SetTarget0 = 6,
		Beyond-UI-UIHeadBuff-SetSeasonTowerUiState0 = 6,
		Beyond-UI-HeadBarCtrl-OnCreate0 = 6,
		Beyond-UI-UIBuffNode-BuffCellGroup-RemoveBuffCell0 = 6,
		Beyond-UI-UIBuffNode-BuffCellGroup-ClearAllBuffCells0 = 6,
		Beyond-UI-UIBuffCell-SetBuffIcon0 = 6,
		Beyond-UI-UIBuffCell-VisualInit0 = 6,
		Beyond-UI-UIBuffNode-_SetBuffCellSiblingInOrder0 = 6,
		Beyond-UI-UIPoiseBar-_TryInitPoiseKnot0 = 6,
		Beyond-UI-UIBuffNode-_UnregisterAbilityBuffEvent0 = 6,
		Beyond-UI-UIBuffNode-_RegisterAbilityBuffEvent0 = 6,
		Beyond-UI-UIHeadBar-_OnForceSetHp0 = 6,
		Beyond-UI-UIHeadBar-SetTarget0 = 6,
		Beyond-UI-UIHeadBarFollower-SetTarget0 = 6,
		Beyond-UI-UILvInfoBar-SetTarget0 = 6,
		Beyond-UI-UITacticalItemBar-SetTarget0 = 6,
		Beyond-UI-UIVigilanceBar-SetTarget0 = 6,
		Beyond-UI-ComboSkillPanel-CastComboSkill0 = 6,
		Beyond-UI-ComboSkillHint-AssignData0 = 6,
		Beyond-UI-GPUIBuffCell-_LogSetBuffIconFailure0 = 6,
		Beyond-UI-GPUIBuffCell-SetSyncManager0 = 6,
		Beyond-UI-GPUIBuffCell-VisualInit0 = 6,
		Beyond-UI-GPUIBuffCell-PlayInAnimation0 = 6,
		Beyond-UI-GPUIBuffCell-PlayOutAnimation0 = 6,
		Beyond-UI-GPUIBuffCell-PlayStrongInAnimation0 = 6,
		Beyond-UI-GPUIBuffCell-PlayIgniteOutAnimation0 = 6,
		Beyond-UI-GPUIBuffNode-OnPreWarm0 = 6,
		Beyond-UI-GPUIBuffNode-BuffCellGroup-RemoveBuffCell0 = 6,
		Beyond-UI-GPUIBuffNode-_UnregisterAbilityBuffEvent0 = 6,
		Beyond-UI-GPUIBuffNode-_RegisterAbilityBuffEvent0 = 6,
		Beyond-UI-GPUIBuffNode-_SetBuffCellSiblingInOrder0 = 6,
		Beyond-UI-GPUILifeTimeBuffCell-VisualInit0 = 6,
		Beyond-UI-MainCharHpBar-_BlinkBuffIcon0 = 6,
		Beyond-UI-UISpellInflictionOnCharNode-_UnregisterAbilityBuffEvent0 = 6,
		Beyond-UI-MainCharHpBar-_InitCurrentBuffNode0 = 6,
		Beyond-UI-UISpellInflictionOnCharNode-_RegisterAbilityBuffEvent0 = 6,
		Beyond-UI-MainCharHpBar-_ProcessOnMainCharChange0 = 6,
		Beyond-UI-MainCharHpBar-SetGPUIBuffSync0 = 6,
		Beyond-UI-OutOfScreenTargetsCtrl-_InitArrowCallbacks0 = 6,
		Beyond-UI-OutOfScreenTargetsCtrlV2-_ScheduleDestroy0 = 6,
		Beyond-UI-OutOfScreenTargetsCtrlV2-_RestartVisibleState0 = 6,
		Beyond-UI-SkillButton-OnUspChange0 = 6,
		Beyond-UI-SkillButton-OnPressSkillStart0 = 6,
		Beyond-UI-SkillButton-OnPressSkillEnd0 = 6,
		Beyond-UI-SkillButton-OnPressUltimateSkillStart0 = 6,
		Beyond-UI-SkillButton-CastSkill0 = 6,
		Beyond-UI-SquadIcon-SetGPUIBuffSync0 = 6,
		Beyond-UI-SquadIcon-OnPressCharIconStart0 = 6,
		Beyond-UI-UIAbnormalBuffCell-VisualInit0 = 6,
		Beyond-UI-UIAttachedBuffCell-SetBuffIcon0 = 6,
		Beyond-UI-TyphoeaHudCtrl-_RecycleLocking0 = 6,
		Beyond-UI-UITyphoeaLockingNode-SetOwner0 = 6,
		Beyond-UI-UITyphoeaLockingNode-SetTarget0 = 6,
		Beyond-UI-TyphoeaHudCtrl-_OnMarkTargetChanged0 = 6,
		Beyond-UI-UILockAim-_RefreshTarget0 = 6,
		Beyond-UI-UILockCharacter-_RefreshTarget0 = 6,
		Beyond-UI-UICampfireTracker-UpdateImage0 = 6,
		Beyond-UI-UICommonTracker-UpdateImage0 = 6,
		Beyond-UI-CommonTrackerNodeComp-UpdatePosition0 = 6,
		Beyond-UI-CommonTrackerUpdate-_HideTrackerGo0 = 6,
		Beyond-UI-UIFacTechTreePanel-ZoomToFullTechTree0 = 6,
		Beyond-UI-GuideFakeButton-OnPointerDown0 = 6,
		Beyond-UI-GuideFakeButton-OnPointerUp0 = 6,
		Beyond-UI-GuideFakeButton-OnPointerEnter0 = 6,
		Beyond-UI-GuideFakeButton-OnPointerExit0 = 6,
		Beyond-UI-GuideFakeButton-OnPointerClick0 = 6,
		Beyond-UI-HeadLabelCtrl-OnCreate0 = 6,
		Beyond-UI-UIHeadLabel-set_missionHeadLabelIcon0 = 6,
		Beyond-UI-UIHeadLabel-set_headLabelIcon0 = 6,
		Beyond-UI-HeadLabelCtrl-_RecyclePoolObject0 = 6,
		Beyond-UI-UIHeadLabel-_SetTarget0 = 6,
		Beyond-UI-UIHeadLabel-_SetTextRootSystemVisible0 = 6,
		Beyond-UI-UIHeadLabel-_RefreshInfo0 = 6,
		Beyond-UI-UIHeadLabel-_RefreshIcon0 = 6,
		Beyond-UI-UIHeadLabel-_RefreshState0 = 6,
		Beyond-UI-UIHeadLabel-_RefreshGift0 = 6,
		Beyond-UI-UIHeadLabel-_RefreshBubble0 = 6,
		Beyond-UI-UIHeadLabel-RefreshTarget0 = 6,
		Beyond-UI-HeadLabelCtrl-_Reconcile0 = 6,
		Beyond-UI-RegionMap3DCfg-Load0 = 6,
		Beyond-UI-UIRegionMapTrackIcon-InitData0 = 6,
		Beyond-UI-RegionMapSetting-SetLoadedRegionTransform0 = 6,
		Beyond-UI-UILevelMapCommonStaticElement-InitCommonStaticElement0 = 6,
		Beyond-UI-UILevelMapFallbackDebugOverlay-_ApplyFont0 = 6,
		Beyond-UI-UILevelMapFallbackDebugOverlay-OnPopulateMesh0 = 6,
		Beyond-UI-UILevelMapGameplayArea-_RefreshGameplayArea0 = 6,
		Beyond-UI-UILevelMapGameplayArea-Init0 = 6,
		Beyond-UI-UILevelMapMissionArea-_RefreshMissionArea0 = 6,
		Beyond-UI-UILevelMapNarrativeAreaText-InitNarrativeAreaText0 = 6,
		Beyond-UI-UIRegionMap3DPanel-InitPanel0 = 6,
		Beyond-UI-ChessboardDrop-OnDrop0 = 6,
		Beyond-UI-ChessboardDrop-OnPointerEnter0 = 6,
		Beyond-UI-ChessboardDrop-OnPointerExit0 = 6,
		Beyond-UI-PuzzleCellDrag-Init0 = 6,
		Beyond-UI-PuzzleDrag-OnBeginDrag0 = 6,
		Beyond-UI-PuzzleCellDrag-OnBeginDrag0 = 6,
		Beyond-UI-PuzzleDrag-OnDrag0 = 6,
		Beyond-UI-PuzzleCellDrag-OnDrag0 = 6,
		Beyond-UI-PuzzleDrag-OnEndDrag0 = 6,
		Beyond-UI-PuzzleCellDrag-OnEndDrag0 = 6,
		Beyond-UI-PuzzleDrag-OnPointerDown0 = 6,
		Beyond-UI-PuzzleCellDrag-OnPointerDown0 = 6,
		Beyond-UI-PuzzleDrag-OnPointerUp0 = 6,
		Beyond-UI-PuzzleCellDrag-OnPointerUp0 = 6,
		Beyond-UI-PuzzleDrag-OnPointerClick0 = 6,
		Beyond-UI-PuzzleCellDrag-OnPointerClick0 = 6,
		Beyond-UI-PuzzleDrag-OnPointerEnter0 = 6,
		Beyond-UI-PuzzleCellDrag-OnPointerEnter0 = 6,
		Beyond-UI-PuzzleDrag-OnPointerExit0 = 6,
		Beyond-UI-PuzzleCellDrag-OnPointerExit0 = 6,
		Beyond-UI-UIPowerPoleAutoConnectTracker-_ActualUpdateIcon0 = 6,
		Beyond-UI-UIUdpipeConnectTracker-_ActualUpdateIcon0 = 6,
		Beyond-UI-UIWaterDroneBar-_SetIconStateController0 = 6,
		Beyond-UI-UICharPassiveBase-Unbind0 = 7,
		Beyond-UI-UICharPassiveBase-OnDestroy0 = 7,
		Beyond-UI-UICharPassiveLiino-Awake0 = 7,
		Beyond-UI-UICharPassiveLiino-OnDestroy0 = 7,
		Beyond-UI-UICharPassiveLiino-_ForceIdle0 = 7,
		Beyond-UI-UICharPassiveLiino-_RefreshDisplay0 = 7,
		Beyond-UI-UICharPassiveTyphoea-Awake0 = 7,
		Beyond-UI-UICharPassiveTyphoea-OnDestroy0 = 7,
		Beyond-UI-UIHudFadeController-_CheckNeedShow0 = 7,
		Beyond-UI-LiinoRandomLikeEffect-OnAwake0 = 7,
		Beyond-UI-LiinoRandomLikeEffect-PlayEffect0 = 7,
		Beyond-UI-LiinoRandomLikeEffect-_ClearAnims0 = 7,
		Beyond-UI-LiinoRandomLikeEffect-OnHide0 = 7,
		Beyond-UI-ComboSpecialNodeBase-OnReady0 = 7,
		Beyond-UI-ComboSpecialNodeBase-OnCast0 = 7,
		Beyond-UI-ComboSpecialNodeBase-OnRemove0 = 7,
		Beyond-UI-ComboSpecialNodeRingQte-_Reset0 = 7,
		Beyond-UI-ComboSpecialNodeRingQte-OnCast0 = 7,
		Beyond-UI-ComboSpecialNodeRingQte-OnRemove0 = 7,
		Beyond-UI-ComboSpecialNodeRingQte-OnRelease0 = 7,
		Beyond-UI-DamageTextBase-Clear0 = 7,
		Beyond-UI-DamageTextBase-PlayAnimation0 = 7,
		Beyond-UI-DamageTextCtrl-OnCreate0 = 7,
		Beyond-UI-DamageTextCtrl-OnClose0 = 7,
		Beyond-UI-DamageTextCtrl-OnShow0 = 7,
		Beyond-UI-DamageTextCtrl-OnHide0 = 7,
		Beyond-UI-DamageTextBaseV2-DestroyDisplay0 = 7,
		Beyond-UI-DamageTextBaseV2-Clear0 = 7,
		Beyond-UI-DamageTextCtrlV2-OnCreate0 = 7,
		Beyond-UI-DamageTextCtrlV2-OnClose0 = 7,
		Beyond-UI-DamageTextCtrlV2-OnShow0 = 7,
		Beyond-UI-DamageTextCtrlV2-OnHide0 = 7,
		Beyond-UI-DamageTextBase-OnAwake0 = 7,
		Beyond-UI-DamageTextBase-OnRelease0 = 7,
		Beyond-UI-DamageTextBase-_UpdatePosition0 = 7,
		Beyond-UI-DamageTextBaseV2-OnRelease0 = 7,
		Beyond-UI-DamageTextIgniteBuff-OnAwake0 = 7,
		Beyond-UI-DamageTextIgniteBuff-OnRelease0 = 7,
		Beyond-UI-FootBarDashCell-StartPlayNotEnoughAnim0 = 7,
		Beyond-UI-FootBarDashCell-StopPlayNotEnoughAnim0 = 7,
		Beyond-UI-UIAbilityTargetFollower-_TryRefreshHeightFollowTransform0 = 7,
		Beyond-UI-UIAbilityTargetFollower-_TryRefreshFollowTransform0 = 7,
		Beyond-UI-UIAbilityTargetFollower-_CalculatePosition0 = 7,
		Beyond-UI-UIAbilityTargetFollower-_UpdatePosition0 = 7,
		Beyond-UI-UIAbilityTargetFollower-_UpdateScale0 = 7,
		Beyond-UI-UIAbilityTargetFollower-_UpdateSelfTransform0 = 7,
		Beyond-UI-UIHeadBar-OnAfterHpBroken0 = 7,
		Beyond-UI-UIHeadBarFollower-OnAfterHpBroken0 = 7,
		Beyond-UI-UIHeadBar-OnBeforeHpBroken0 = 7,
		Beyond-UI-UIHeadBarFollower-OnBeforeHpBroken0 = 7,
		Beyond-UI-HeadBarCtrl-_OnHeadBarShowConfigChanged0 = 7,
		Beyond-UI-UIHeadBuff-_UpdateLifeTime0 = 7,
		Beyond-UI-HeadBarCtrl-_RefreshSeasonTowerHeadBuff0 = 7,
		Beyond-UI-HeadBarCtrl-_OnBountyEnemyChanged0 = 7,
		Beyond-UI-UIBuffNode-_OnFirstInit0 = 7,
		Beyond-UI-UIBuffCell-Clear0 = 7,
		Beyond-UI-UIBuffNode-OnPreWarm0 = 7,
		Beyond-UI-UIHeadBar-OnPreWarm0 = 7,
		Beyond-UI-UIHeadBarFollower-OnPreWarm0 = 7,
		Beyond-UI-HeadBarCtrl-_PrewarmHeadBar0 = 7,
		Beyond-UI-HeadBarCtrl-_RemoveInvalidDirectHeadBuff0 = 7,
		Beyond-UI-HeadBarCtrl-_RefreshDirectHeadBuff0 = 7,
		Beyond-UI-HeadBarCtrl-OnClose0 = 7,
		Beyond-UI-UIPoiseBar-Refresh0 = 7,
		Beyond-UI-UIBuffNode-_DealWithBuffCellVisible0 = 7,
		Beyond-UI-UIBuffNode-Refresh0 = 7,
		Beyond-UI-UIHeadBar-Refresh0 = 7,
		Beyond-UI-UIHeadBarFollower-Refresh0 = 7,
		Beyond-UI-UIVigilanceBar-Refresh0 = 7,
		Beyond-UI-HeadBarCtrl-OnShow0 = 7,
		Beyond-UI-HeadBarCtrl-OnHide0 = 7,
		Beyond-UI-UICountShieldCell-PlayShakeAnimation0 = 7,
		Beyond-UI-UICountShieldNode-ShakeRightmostActiveCell0 = 7,
		Beyond-UI-UIHeadBar-OnDestroy0 = 7,
		Beyond-UI-UIPoiseBar-_ClearPoiseKnot0 = 7,
		Beyond-UI-UIBuffCell-BeforePlayOutAnim0 = 7,
		Beyond-UI-UIBuffCell-OnBuffIgnite0 = 7,
		Beyond-UI-UIHeadBar-_InitSpecialCountDownBuff0 = 7,
		Beyond-UI-UIPoiseKnot-KnotBreak0 = 7,
		Beyond-UI-UIHeadBar-RefreshShowConfig0 = 7,
		Beyond-UI-UIHeadBar-_OnCountShieldUiChange0 = 7,
		Beyond-UI-UIHeadBar-_OnCountShieldUiShake0 = 7,
		Beyond-UI-UIPoiseBar-Clear0 = 7,
		Beyond-UI-UIBuffNode-Clear0 = 7,
		Beyond-UI-UIHeadBar-Clear0 = 7,
		Beyond-UI-UIHeadBarFollower-_UpdateGuideLine0 = 7,
		Beyond-UI-UIAbilityTargetFollower-Clear0 = 7,
		Beyond-UI-UIHeadBarFollower-Clear0 = 7,
		Beyond-UI-UIHeadBarFollower-RefreshShowConfig0 = 7,
		Beyond-UI-UIHeadBuff-Clear0 = 7,
		Beyond-UI-UITacticalItemBar-Clear0 = 7,
		Beyond-UI-UIVigilanceBar-Clear0 = 7,
		Beyond-UI-UIVigilanceBar-_UpdateVigilanceNode0 = 7,
		Beyond-UI-UIWeaknessNode-Awake0 = 7,
		Beyond-UI-AtbNode-_OnAtbCellOutAnimCallback0 = 7,
		Beyond-UI-AtbNode-CheckAtbLoopAnim0 = 7,
		Beyond-UI-AtbNode-_RefreshAtbShowing0 = 7,
		Beyond-UI-AtbNode-_RefreshAtbMax0 = 7,
		Beyond-UI-AtbNode-_OnAtbMaxChanged0 = 7,
		Beyond-UI-AtbNode-OnCreate0 = 7,
		Beyond-UI-AtbNode-OnClose0 = 7,
		Beyond-UI-ComboSkillHint-_ReleaseSpecialNode0 = 7,
		Beyond-UI-ComboSkillHint-Release0 = 7,
		Beyond-UI-ComboSkillPanel-_ResortSiblingIndex0 = 7,
		Beyond-UI-ComboSkillHint-OnCast0 = 7,
		Beyond-UI-ComboSkillPanel-_UpdateButtonCastState0 = 7,
		Beyond-UI-ComboSkillPanel-_CheckUpdate0 = 7,
		Beyond-UI-ComboSkillHint-OnReady0 = 7,
		Beyond-UI-ComboSkillHint-OnRemove0 = 7,
		Beyond-UI-ComboSkillHint-_ReleaseAllSpecialNodes0 = 7,
		Beyond-UI-ComboSkillHint-AssignLockData0 = 7,
		Beyond-UI-ComboSkillPanel-_OnBattleTeamChanged0 = 7,
		Beyond-UI-ComboSkillPanel-_OnComboSkillClearAll0 = 7,
		Beyond-UI-ComboSkillPanel-_UnbindListeners0 = 7,
		Beyond-UI-ComboSkillPanel-_ClearExtraHints0 = 7,
		Beyond-UI-ComboSkillPanel-OnShow0 = 7,
		Beyond-UI-UIPanelBase-OnRelease0 = 7,
		Beyond-UI-ComboSkillPanel-OnRelease0 = 7,
		Beyond-UI-GPUIBuffCell-_UpdateAnimationComplete0 = 7,
		Beyond-UI-GPUIBuffCell-BeforePlayOutAnim0 = 7,
		Beyond-UI-GPUIAttachedBuffCell-BeforePlayOutAnim0 = 7,
		Beyond-UI-GPUIAttachedBuffCell-OnBuffIgnite0 = 7,
		Beyond-UI-GPUIBuffCell-ClearBuffIconOverride0 = 7,
		Beyond-UI-GPUIAttachedBuffCell-ClearBuffIconOverride0 = 7,
		Beyond-UI-GPUIBuffCell-Clear0 = 7,
		Beyond-UI-GPUIBuffCell-OnBuffIgnite0 = 7,
		Beyond-UI-GPUIBuffCell-SampleToInAnimationEnd0 = 7,
		Beyond-UI-GPUIBuffNode-_OnFirstInit0 = 7,
		Beyond-UI-GPUIBuffNode-_RemoveInvalidStackBuffPtrs0 = 7,
		Beyond-UI-GPUIBuffNode-_DealWithBuffCellVisible0 = 7,
		Beyond-UI-GPUIBuffNode-BuffCellGroup-ClearAllBuffCells0 = 7,
		Beyond-UI-GPUIBuffNode-Refresh0 = 7,
		Beyond-UI-GPUIBuffNode-Clear0 = 7,
		Beyond-UI-GPUIBuffNode-OnRelease0 = 7,
		Beyond-UI-GPUILifeTimeBuffCell-_UpdateFillAmount0 = 7,
		Beyond-UI-HpBarComboNode-_AnimOutCallback0 = 7,
		Beyond-UI-HpBarComboNode-_AnimInCallback0 = 7,
		Beyond-UI-HpBarComboNode-Awake0 = 7,
		Beyond-UI-HpBarComboNode-OnDestroy0 = 7,
		Beyond-UI-UIHudFadeController-InformShow0 = 7,
		Beyond-UI-MainCharHpBar-_HpVfxOutAnimCallback0 = 7,
		Beyond-UI-MainCharHpBar-_RefreshBuffChangeCharHpBarVfx0 = 7,
		Beyond-UI-MainCharHpBar-_ClearBuffNode1 = 7,
		Beyond-UI-UISpellInflictionOnCharNode-OnClear0 = 7,
		Beyond-UI-MainCharHpBar-_ClearMainChar0 = 7,
		Beyond-UI-MainCharHpBar-_RebuildCharHpBarVfxBuffCache0 = 7,
		Beyond-UI-MainCharHpBar-_EnsureBuffNodePreWarmed0 = 7,
		Beyond-UI-UISpellInflictionOnCharNode-_OnFirstInit0 = 7,
		Beyond-UI-UISpellInflictionOnCharNode-_DoRefreshUI0 = 7,
		Beyond-UI-MainCharHpBar-_UltimateBuffProgressOutAnimCallback0 = 7,
		Beyond-UI-MainCharHpBar-_SelectUltimateBuff0 = 7,
		Beyond-UI-MainCharHpBar-_RebuildUltimateBuffTracking0 = 7,
		Beyond-UI-MainCharHpBar-_OnTeamChanged0 = 7,
		Beyond-UI-MainCharHpBar-_OnMainCharHpActiveChange0 = 7,
		Beyond-UI-MainCharHpBar-OnAwake0 = 7,
		Beyond-UI-MainCharHpBar-OnEnable0 = 7,
		Beyond-UI-MainCharHpBar-OnRelease0 = 7,
		Beyond-UI-MainCharHpBar-OnShow0 = 7,
		Beyond-UI-MainCharHpBar-OnHide0 = 7,
		Beyond-UI-OutOfScreenTargetsCtrl-OnCreate0 = 7,
		Beyond-UI-OutOfScreenTargetsCtrl-OnClose0 = 7,
		Beyond-UI-OutOfScreenTargetsCtrl-OnShow0 = 7,
		Beyond-UI-OutOfScreenTargetsCtrlV2-OnCreate0 = 7,
		Beyond-UI-OutOfScreenTargetsCtrlV2-_RecycleAll0 = 7,
		Beyond-UI-OutOfScreenTargetsCtrlV2-OnClose0 = 7,
		Beyond-UI-OutOfScreenTargetsCtrlV2-OnShow0 = 7,
		Beyond-UI-OutOfScreenTargetsCtrlV2-OnHide0 = 7,
		Beyond-UI-OutOfScreenTargetsCtrlV2-_UpdateRuntimeStates0 = 7,
		Beyond-UI-SkillButton-OnAwake0 = 7,
		Beyond-UI-SkillButton-OnEnable0 = 7,
		Beyond-UI-SkillButton-PressHandler-OnOtherPressSkillButtonStart0 = 7,
		Beyond-UI-SkillButton-_SetHideUspInfoState0 = 7,
		Beyond-UI-SkillButton-_RefreshNormalProgressBuff0 = 7,
		Beyond-UI-SkillButton-_RefreshUltimateProgressBuff0 = 7,
		Beyond-UI-SkillButton-_InitSkillData0 = 7,
		Beyond-UI-SkillButton-OnPressCancelled0 = 7,
		Beyond-UI-SkillButton-_CheckNormalSkillHighlight0 = 7,
		Beyond-UI-SkillButton-_RefreshNormalSkillCd0 = 7,
		Beyond-UI-SkillButton-_OnSkillButtonActiveConfigChanged0 = 7,
		Beyond-UI-SkillButton-RefreshSkillButton0 = 7,
		Beyond-UI-SkillButton-PressHandler-OnUltimateSkillChanged0 = 7,
		Beyond-UI-SkillButton-_UpdateLongPressKeyHint0 = 7,
		Beyond-UI-SkillButton-_OnKeyboardTypeChanged0 = 7,
		Beyond-UI-SkillButton-Close0 = 7,
		Beyond-UI-SkillButton-OnCharacterDie0 = 7,
		Beyond-UI-SkillButton-ClearBtnClick0 = 7,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnPressStart0 = 7,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnPressEnd0 = 7,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnPressCancel0 = 7,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnOtherPressSkillButtonStart0 = 7,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnUltimateSkillChanged0 = 7,
		Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnPressStart0 = 7,
		Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnPressEnd0 = 7,
		Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnPressCancel0 = 7,
		Beyond-UI-SkillButton-PressHandlerDrag-OnPressStart0 = 7,
		Beyond-UI-SkillButton-PressHandlerDrag-OnPressEnd0 = 7,
		Beyond-UI-SkillButton-PressHandlerDrag-OnPressCancel0 = 7,
		Beyond-UI-SkillButton-PressHandlerDrag-OnUltimateSkillChanged0 = 7,
		Beyond-UI-SquadIcon-OnAwake0 = 7,
		Beyond-UI-SquadIcon-_ClearBuffNode0 = 7,
		Beyond-UI-SquadIcon-_EnsureBuffNodePreWarmed0 = 7,
		Beyond-UI-SquadIcon-_RefreshCharHpInfoVisible0 = 7,
		Beyond-UI-SquadIcon-_HpVfxOutAnimCallback0 = 7,
		Beyond-UI-SquadIcon-_RefreshBuffChangeCharHpBarVfx0 = 7,
		Beyond-UI-SquadIcon-Close0 = 7,
		Beyond-UI-SquadIcon-_RebuildCharHpBarVfxBuffCache0 = 7,
		Beyond-UI-SquadIcon-_PlayComboCdBarInAnimation0 = 7,
		Beyond-UI-SquadIcon-_TryShowLevelUpAnim0 = 7,
		Beyond-UI-SquadIcon-_SetLevelText0 = 7,
		Beyond-UI-TacticalDotCell-Init0 = 7,
		Beyond-UI-SquadIcon-OnTacticalItemChange0 = 7,
		Beyond-UI-SquadIcon-_UpdateIconAlpha0 = 7,
		Beyond-UI-SquadIcon-_UpdateTacticalItemStatus0 = 7,
		Beyond-UI-SquadIcon-InformKeyHint0 = 7,
		Beyond-UI-SquadIcon-OnLevelChange0 = 7,
		Beyond-UI-SquadIcon-OnTeamSwitchUnlocked0 = 7,
		Beyond-UI-UIAttachedBuffCell-_SettlePendingStackFillBeforeOut0 = 7,
		Beyond-UI-UIAttachedBuffCell-_ClearConsumeAnimations0 = 7,
		Beyond-UI-UIAttachedBuffCell-BeforePlayOutAnim0 = 7,
		Beyond-UI-UIAttachedBuffCell-OnBuffIgnite0 = 7,
		Beyond-UI-UIBuffNode-OnRelease0 = 7,
		Beyond-UI-UIHudFadeConsoleController-_CheckNeedShow0 = 7,
		Beyond-UI-UIHudFadeConsoleController-_OnFadeHud0 = 7,
		Beyond-UI-UIHudFadeConsoleController-InformShow0 = 7,
		Beyond-UI-UIHudFadeConsoleController-Awake0 = 7,
		Beyond-UI-UIHudFadeConsoleController-OnDestroy0 = 7,
		Beyond-UI-UIHudFadeConsoleController-OnShow0 = 7,
		Beyond-UI-UIHudFadeController-_OnFadeHud0 = 7,
		Beyond-UI-UIHudFadeController-Awake0 = 7,
		Beyond-UI-UIHudFadeController-OnDestroy0 = 7,
		Beyond-UI-UIHudFadeTouchSkill-_CheckNeedShow0 = 7,
		Beyond-UI-UIHudFadeTouchSkill-_OnFadeHud0 = 7,
		Beyond-UI-UIHudFadeTouchSkill-InformShow0 = 7,
		Beyond-UI-UIHudFadeTouchSkill-Awake0 = 7,
		Beyond-UI-UIHudFadeTouchSkill-OnDestroy0 = 7,
		Beyond-UI-UIHudFadeTouchSkill-OnShow0 = 7,
		Beyond-UI-BattleControllerInputController-_RefreshUltimateMode2Available0 = 7,
		Beyond-UI-BattleControllerInputController-_RefreshCachedKeys0 = 7,
		Beyond-UI-BattleControllerInputController-_UnregisterAllCombos0 = 7,
		Beyond-UI-BattleControllerInputController-Dispose0 = 7,
		Beyond-UI-BattleControllerInputController-_RegisterAllCombos0 = 7,
		Beyond-UI-UITyphoeaLockingNode-Clear0 = 7,
		Beyond-UI-UITyphoeaLockingNode-_OnOutAnimComplete0 = 7,
		Beyond-UI-TyphoeaHudCtrl-_ResetHintCellsState0 = 7,
		Beyond-UI-TyphoeaHudCtrl-_PlayOutAllLockingNodes0 = 7,
		Beyond-UI-TyphoeaHudCtrl-_UpdateHintCells0 = 7,
		Beyond-UI-TyphoeaHudCtrl-_OnSquadChanged0 = 7,
		Beyond-UI-TyphoeaHudCtrl-OnCreate0 = 7,
		Beyond-UI-TyphoeaHudCtrl-OnShow0 = 7,
		Beyond-UI-TyphoeaHudCtrl-OnHide0 = 7,
		Beyond-UI-TyphoeaHudCtrl-_ClearAllLockingNodes0 = 7,
		Beyond-UI-TyphoeaHudCtrl-OnClose0 = 7,
		Beyond-UI-UIAbilityTargetFollower-OnAwake0 = 7,
		Beyond-UI-UILockAim-_OnLockTargetFromAutoToManual0 = 7,
		Beyond-UI-UILockAim-OnAwake0 = 7,
		Beyond-UI-UILockAim-OnRelease0 = 7,
		Beyond-UI-UILockAim-Start0 = 7,
		Beyond-UI-UILockCharacter-OnAwake0 = 7,
		Beyond-UI-UILockCharacter-OnRelease0 = 7,
		Beyond-UI-UIMainCharFootBar-_OnDashFailed0 = 7,
		Beyond-UI-UIMainCharFootBar-_ProcessOnMainCharChange0 = 7,
		Beyond-UI-UIMainCharFootBar-OnAwake0 = 7,
		Beyond-UI-UIMainCharFootBar-OnEnable0 = 7,
		Beyond-UI-UIMainCharFootBar-OnRelease0 = 7,
		Beyond-UI-UIMainCharFootBar-_OnOutAnimCallback0 = 7,
		Beyond-UI-UIMainCharFootBarArc-_OnOutAnimCallback0 = 7,
		Beyond-UI-UIMainCharFootBarArc-SplitDashAnimation-Stop0 = 7,
		Beyond-UI-UIMainCharFootBarArc-_StopSplitDashAnimations0 = 7,
		Beyond-UI-UIMainCharFootBarArc-SplitDashAnimation-_OnInAnimationFinished0 = 7,
		Beyond-UI-UIMainCharFootBarArc-SplitDashAnimation-Play0 = 7,
		Beyond-UI-UIMainCharFootBarArc-_OnDashFailed0 = 7,
		Beyond-UI-UIMainCharFootBarArc-_ProcessOnMainCharChange0 = 7,
		Beyond-UI-UIMainCharFootBarArc-_RefreshDisableState0 = 7,
		Beyond-UI-UIMainCharFootBarArc-OnAwake0 = 7,
		Beyond-UI-UIMainCharFootBarArc-OnEnable0 = 7,
		Beyond-UI-UIMainCharFootBarArc-OnDisable0 = 7,
		Beyond-UI-UIMainCharFootBarArc-OnRelease0 = 7,
		Beyond-UI-UIWeakLockAim-_RefreshTarget0 = 7,
		Beyond-UI-UIWeakLockAim-OnAwake0 = 7,
		Beyond-UI-UIWeakLockAim-Start0 = 7,
		Beyond-UI-UIWeakLockAim-OnRelease0 = 7,
		Beyond-UI-CommonTrackerUpdate-_DeleteInvalidTracker0 = 7,
		Beyond-UI-CommonTrackerUpdate-AllTrackersPlayOutAnimation0 = 7,
		Beyond-UI-WorldUIController-TryGetNeedComponent0 = 7,
		Beyond-UI-WorldUIController-SetUIForward0 = 7,
		Beyond-UI-WorldUIController-SetPos0 = 7,
		Beyond-UI-CoolerUnitProgressBarUI-SetUIForward0 = 7,
		Beyond-UI-CoolerUnitProgressBarUI-SetPos0 = 7,
		Beyond-UI-CoolerUnitTemperatureCircleUI-SetUIForward0 = 7,
		Beyond-UI-CoolerUnitTemperatureCircleUI-SetPos0 = 7,
		Beyond-UI-CoolerUnitTemperatureCircleUI-_UpdateUIState0 = 7,
		Beyond-UI-WorldUIController-Clear0 = 7,
		Beyond-UI-CoolerUnitTemperatureUI-Clear0 = 7,
		Beyond-UI-CoolerUnitTemperatureUI-SetUIForward0 = 7,
		Beyond-UI-CoolerUnitTemperatureUI-SetPos0 = 7,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_ResetUI0 = 7,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_GetCanvas0 = 7,
		Beyond-UI-CoolerUnitTotalProgressBarUI-SetUIForward0 = 7,
		Beyond-UI-CoolerUnitTotalProgressBarUI-SetPos0 = 7,
		Beyond-UI-WorldUIController-RefreshUI0 = 7,
		Beyond-UI-DoodadFactoryGasCoreScanUI-_BindDomainChange0 = 7,
		Beyond-UI-WorldUIController-InitUI0 = 7,
		Beyond-UI-DoodadFactoryGasCoreScanUI-_UnbindDomainChange0 = 7,
		Beyond-UI-WorldUIController-DoRelease0 = 7,
		Beyond-UI-DoodadFactoryGasCoreScanUI-DoRelease0 = 7,
		Beyond-UI-DoodadFactoryGasCoreScanUI-SetUIForward0 = 7,
		Beyond-UI-DoodadFactoryGasCoreScanUI-SetPos0 = 7,
		Beyond-UI-WorldUIController-FaceToCamera0 = 7,
		Beyond-UI-DoodadFactoryGasCoreScanUI-InitUI0 = 7,
		Beyond-UI-DoodadFactoryGasCoreScanUI-RefreshUI0 = 7,
		Beyond-UI-DoodadFactoryGasScanUI-DoRelease0 = 7,
		Beyond-UI-DoodadFactoryGasScanUI-SetUIForward0 = 7,
		Beyond-UI-DoodadFactoryGasScanUI-SetPos0 = 7,
		Beyond-UI-DoodadFactoryGasScanUI-InitUI0 = 7,
		Beyond-UI-FacLineCell-Awake0 = 7,
		Beyond-UI-FacLineDrawer-Awake0 = 7,
		Beyond-UI-FacLineDrawer-_Clear0 = 7,
		Beyond-UI-FacLineDrawer-OnDestroy0 = 7,
		Beyond-UI-FacLineDrawer-ClearComponent0 = 7,
		Beyond-UI-FacLineDrawer-ClearDrawer0 = 7,
		Beyond-UI-UIFacTechTreePanel-OnRelease0 = 7,
		Beyond-UI-UIFacTechTreePanel-_PosAdjust0 = 7,
		Beyond-UI-UIFacTechTreePanel-_UpdatePositionOffsetAfterZoomed0 = 7,
		Beyond-UI-UIFacTechTreePanel-_RefreshPivotPosition0 = 7,
		Beyond-UI-UIFacTechTreePanel-_ControllerZoomUpdate0 = 7,
		Beyond-UI-UIFacTechTreePanel-_ControllerDragUpdate0 = 7,
		Beyond-UI-UIFacTechTreePanel-_ControllerUpdate0 = 7,
		Beyond-UI-UIFacTechTreePanel-_RefreshAll0 = 7,
		Beyond-UI-UIFacTechTreePanel-InitData0 = 7,
		Beyond-UI-ForgeIronProgressBarUI-SetPos0 = 7,
		Beyond-UI-ForgeIronProgressBarUI-SetUIForward0 = 7,
		Beyond-UI-ForgeIronProgressBarUI-UpdateProgress0 = 7,
		Beyond-UI-ForgeIronTemperatureCircleUI-Clear0 = 7,
		Beyond-UI-ForgeIronTemperatureCircleUI-SetPos0 = 7,
		Beyond-UI-ForgeIronTemperatureCircleUI-SetUIForward0 = 7,
		Beyond-UI-ForgeIronTemperatureCircleUI-UpdateUIState0 = 7,
		Beyond-UI-ForgeIronTemperatureUI-SetPos0 = 7,
		Beyond-UI-ForgeIronTemperatureUI-SetUIForward0 = 7,
		Beyond-UI-ForgeIronTemperatureUI-UpdateUIInfo0 = 7,
		Beyond-UI-ForgeIronTemperatureUI-UpdateUIPos0 = 7,
		Beyond-UI-GuideFakeButton-CopyTargetBinding0 = 7,
		Beyond-UI-GuideFakeButton-ClearBinding0 = 7,
		Beyond-UI-GuideFakeButton-_ClearOnClick0 = 7,
		Beyond-UI-GuideFakeButton-ClearTarget0 = 7,
		Beyond-UI-GuideFakeButton-Awake0 = 7,
		Beyond-UI-GuideFakeButton-ClearComponent0 = 7,
		Beyond-UI-HeadLabelCtrl-Prewarm0 = 7,
		Beyond-UI-UIHeadLabel-_UpdateVisible0 = 7,
		Beyond-UI-UIHeadLabel-ClearEmojis0 = 7,
		Beyond-UI-UIHeadLabel-SetVisibleDirty0 = 7,
		Beyond-UI-UIHeadLabel-_ClearFloatingUIVisibleCallback0 = 7,
		Beyond-UI-UIHeadLabel-_ClearVisibleCallback0 = 7,
		Beyond-UI-UIHeadLabel-Clear0 = 7,
		Beyond-UI-UIHeadLabel-_ClearViewContent0 = 7,
		Beyond-UI-UIHeadLabel-Unbind0 = 7,
		Beyond-UI-HeadLabelCtrl-_DestroyPoolObject0 = 7,
		Beyond-UI-HeadLabelCtrl-ClearAll0 = 7,
		Beyond-UI-HeadLabelCtrl-OnClose0 = 7,
		Beyond-UI-HeadLabelCtrl-OnShow0 = 7,
		Beyond-UI-UIHeadLabel-_UpdatePos0 = 7,
		Beyond-UI-HeadLabelCtrl-OnHide0 = 7,
		Beyond-UI-HeadLabelCtrl-_RecycleAllActiveViews0 = 7,
		Beyond-UI-UIHeadLabel-_TryInitRootData0 = 7,
		Beyond-UI-UIHeadLabel-_UpdateFloatingUIVisibleCallback0 = 7,
		Beyond-UI-UIHeadLabel-_TryUpdateVisibleCallback0 = 7,
		Beyond-UI-UIHeadLabel-_OnSubRootsCollectionChanged0 = 7,
		Beyond-UI-UIHeadLabel-_TryUpdateVisible0 = 7,
		Beyond-UI-UIHeadLabel-OnAwake0 = 7,
		Beyond-UI-UIHeadLabel-OnEnable0 = 7,
		Beyond-UI-UIHeadLabel-OnDisable0 = 7,
		Beyond-UI-UIHeadLabel-OnRelease0 = 7,
		Beyond-UI-RegionMapSetting-_ClearMaterials0 = 7,
		Beyond-UI-RegionMapSetting-OnDestroy0 = 7,
		Beyond-UI-RegionMapSetting-_InitTrackIcon0 = 7,
		Beyond-UI-RegionMapSetting-_InitUI0 = 7,
		Beyond-UI-RegionMapSetting-_InitPlayerIcon0 = 7,
		Beyond-UI-RegionMapSetting-_InitSelect0 = 7,
		Beyond-UI-RegionMapSetting-_RefreshMaterials0 = 7,
		Beyond-UI-UIFacMainRegion-_RefreshRegionState0 = 7,
		Beyond-UI-UIFacMainRegion-ClearComponent0 = 7,
		Beyond-UI-UIFacMainRegion-OnDestroy0 = 7,
		Beyond-UI-UILevelMapCommonStaticElement-_UnloadImage0 = 7,
		Beyond-UI-UILevelMapCommonStaticElement-_ReevaluateAndApply0 = 7,
		Beyond-UI-UILevelMapCommonStaticElement-ClearComponent0 = 7,
		Beyond-UI-UILevelMapCommonStaticElement-OnDestroy0 = 7,
		Beyond-UI-UILevelMapCrane-_ClearSpriteAsset0 = 7,
		Beyond-UI-UILevelMapCrane-_RefreshCraneState0 = 7,
		Beyond-UI-UILevelMapCrane-_UnBindAll0 = 7,
		Beyond-UI-UILevelMapCrane-ClearComponent0 = 7,
		Beyond-UI-UILevelMapCrane-OnDestroy0 = 7,
		Beyond-UI-UILevelMapCrane-_BindAll0 = 7,
		Beyond-UI-UILevelMapCrane-InitCrane0 = 7,
		Beyond-UI-UILevelMapFallbackDebugOverlay-DestroyOn0 = 7,
		Beyond-UI-UILevelMapFallbackDebugOverlay-_LayoutLabels0 = 7,
		Beyond-UI-UILevelMapFallbackDebugOverlay-OnRectTransformDimensionsChange0 = 7,
		Beyond-UI-UILevelMapFallbackDebugOverlay-LabelScreenScaleKeeper-OnAwake0 = 7,
		Beyond-UI-UILevelMapGameplayArea-ClearComponent0 = 7,
		Beyond-UI-UILevelMapLimitInRect-_LimitInRect0 = 7,
		Beyond-UI-UILevelMapLimitInRect-OnEnable0 = 7,
		Beyond-UI-UILevelMapLimitInRect-ClearComponent0 = 7,
		Beyond-UI-UILevelMapLimitInRect-OnRelease0 = 7,
		Beyond-UI-UILevelMapLimitInRect-StartLimitMarkInRect0 = 7,
		Beyond-UI-UILevelMapLimitInRect-StopLimitMarkInRect0 = 7,
		Beyond-UI-UILevelMapLimitInRect-ForceRefreshLimitState0 = 7,
		Beyond-UI-UILevelMapLine-_HoldLineSize0 = 7,
		Beyond-UI-UILevelMapLine-OnEnable0 = 7,
		Beyond-UI-UILevelMapLine-ClearComponent0 = 7,
		Beyond-UI-UILevelMapMissionArea-_DisappearIfOutRect0 = 7,
		Beyond-UI-UILevelMapMissionArea-ClearComponent0 = 7,
		Beyond-UI-UILevelMapMissionArea-ForceRefreshDisappearIfOutRect0 = 7,
		Beyond-UI-UILevelMapMisty-_RefreshMistyState0 = 7,
		Beyond-UI-UILevelMapMisty-_UnBindAll0 = 7,
		Beyond-UI-UILevelMapMisty-ClearComponent0 = 7,
		Beyond-UI-UILevelMapMisty-OnDestroy0 = 7,
		Beyond-UI-UILevelMapMisty-_BindAll0 = 7,
		Beyond-UI-UILevelMapMisty-InitMisty0 = 7,
		Beyond-UI-UILevelMapNarrativeAreaText-_ReevaluateAndApply0 = 7,
		Beyond-UI-UILevelMapNarrativeAreaText-ClearComponent0 = 7,
		Beyond-UI-UILevelMapNarrativeAreaText-OnDestroy0 = 7,
		Beyond-UI-UILevelMapSwitchBtn-ClearComponent0 = 7,
		Beyond-UI-UILevelMapTouchPanelWrapper-OnAwake0 = 7,
		Beyond-UI-UILevelMapTouchPanelWrapper-_CheckDrag0 = 7,
		Beyond-UI-UILevelMapTouchPanelWrapper-_CheckScroll0 = 7,
		Beyond-UI-UIRegionMap3DPanel-_OnDoMoveTween0 = 7,
		Beyond-UI-UISettlementRegion-_RefreshSettlementRegionState0 = 7,
		Beyond-UI-UISettlementRegion-_UnBindAll0 = 7,
		Beyond-UI-UISettlementRegion-ClearComponent0 = 7,
		Beyond-UI-UISettlementRegion-OnDestroy0 = 7,
		Beyond-UI-UISettlementRegion-_BindAll0 = 7,
		Beyond-UI-ChessboardDrop-ClearComponent0 = 7,
		Beyond-UI-ChessboardDrop-OnDestroy0 = 7,
		Beyond-UI-PuzzleControllerHelper-Awake0 = 7,
		Beyond-UI-PuzzleDrag-Awake0 = 7,
		Beyond-UI-PuzzleDrag-ClearComponent0 = 7,
		Beyond-UI-PuzzleDrag-OnDestroy0 = 7,
		Beyond-UI-ScratchOffLotteryCoating-_DrawBlank0 = 7,
		Beyond-UI-ScratchOffLotteryCoating-_InitPixelDic0 = 7,
		Beyond-UI-ScratchOffLotteryCoating-_InitMarkPoint0 = 7,
		Beyond-UI-ScratchOffLotteryCoating-Awake0 = 7,
		Beyond-UI-ScratchOffLotteryCoating-OnDestroy0 = 7,
		Beyond-UI-UIMusicVolumeVisual-Start0 = 7,
		Beyond-UI-UIMusicVolumeVisual-OnEnable0 = 7,
		Beyond-UI-UIMusicVolumeVisual-OnDisable0 = 7,
		Beyond-UI-RiftScanUI-DoRelease0 = 7,
		Beyond-UI-RiftScanUI-SetUIForward0 = 7,
		Beyond-UI-RiftScanUI-SetPos0 = 7,
		Beyond-UI-RiftScanUI-InitUI0 = 7,
		Beyond-UI-RiftScanUI-RefreshUI0 = 7,
		Beyond-UI-UIBrokenLine-_Init0 = 7,
		Beyond-UI-UIBrokenLine-Awake0 = 7,
		Beyond-UI-UIBrokenLine-OnDestroy0 = 7,
		Beyond-UI-UICommonScanController-_UpdatePos0 = 7,
		Beyond-UI-UICommonScanController-_FaceToCamera0 = 7,
		Beyond-UI-UICommonScanController-Clear0 = 7,
		Beyond-UI-UICountDownBar-_UpdatePos0 = 7,
		Beyond-UI-UICountDownBar-Clear0 = 7,
		Beyond-UI-UIDoodadPlantCoreScanController-_SyncTimeText0 = 7,
		Beyond-UI-UIDoodadPlantCoreScanController-RefreshTextNow0 = 7,
		Beyond-UI-UIDoodadScanController-_RefreshCountDown0 = 7,
		Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateStatusNormal0 = 7,
		Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateStatusTooFar0 = 7,
		Beyond-UI-UIPowerPoleFastTravelTracker-_UpdateIcon0 = 7,
		Beyond-UI-UIPowerPoleFastTravelTracker-_OnStatusChanged0 = 7,
		Beyond-UI-UIPowerPoleFastTravelTracker-PlayFocus0 = 7,
		Beyond-UI-UIPowerPoleFastTravelTracker-OnEnable0 = 7,
		Beyond-UI-UIRaceModuleRankController-_ResetData0 = 7,
		Beyond-UI-UIRaceModuleRankController-_LoadAllSprite0 = 7,
		Beyond-UI-UIRaceModuleRankController-OnAwake0 = 7,
		Beyond-UI-UIRaceModuleRankController-OnRelease0 = 7,
		Beyond-UI-UIVideoHelper-Reset0 = 7,
		Beyond-UI-UIVideoHelper-ResetVideo0 = 7,
		Beyond-UI-UIVideoHelper-Awake0 = 7,
		Beyond-UI-UIVideoHelper-OnEnable0 = 7,
		Beyond-UI-UIWorldCanvasResolutionScaleFit-Awake0 = 7,
		Beyond-UI-UIWorldCanvasResolutionScaleFit-_ApplyScale0 = 7,
		Beyond-UI-UIWorldCanvasResolutionScaleFit-OnEnable0 = 7,
		Beyond-UI-UIWorldCanvasResolutionScaleFit-OnDisable0 = 7,
		Beyond-UI-UIWaterDroneBar-OnAwake0 = 7,
		Beyond-UI-UIWaterDroneBar-_ClearWaterDrone0 = 7,
		Beyond-UI-UIWaterDroneBar-OnEnable0 = 7,
		Beyond-UI-UIWaterDroneBar-OnRelease0 = 7,
		Beyond-UI-UIWaterDroneBar-_UpdateState0 = 7,
		Beyond-UI-UIWaterDroneBar-_UpdateSlider0 = 7,
		Beyond-UI-WorldUIController-OnRelease0 = 7,
		Beyond-UI-WorldUIFollowAndFaceCamera-_TryCacheCamera0 = 7,
		Beyond-UI-WorldUIFollowAndFaceCamera-OnAwake0 = 7,
		Beyond-UI-WorldUIFollowAndFaceCamera-OnEnable0 = 7,
		Beyond-UI-WorldUIFollowAndFaceCamera-_UpdatePosition0 = 7,
		Beyond-UI-WorldUIFollowAndFaceCamera-_FaceCamera0 = 7,
		Beyond-UI-Mission-MissionHudBGSizeUpdater-UpdateBgSize0 = 7,
		Beyond-UI-UICharPassiveLiino-_IsBuffValid0 = 8,
		Beyond-UI-HeadBarCtrl-_ShouldShowDirectHeadBuff0 = 8,
		Beyond-UI-HeadBarCtrl-_TryShowDirectHeadBuff0 = 8,
		Beyond-UI-UIBuffNode-_IsBuffIconInThisNode0 = 8,
		Beyond-UI-GPUIBuffNode-_IsBuffIconInThisNode0 = 8,
		Beyond-UI-MainCharHpBar-_IsCharHpBarVfxBuffValid0 = 8,
		Beyond-UI-MainCharHpBar-_IsUltimateBuffValid0 = 8,
		Beyond-UI-SquadIcon-_IsCharHpBarVfxBuffValid0 = 8,
		Beyond-UI-UICharPassiveLiino-_GetActiveBuffForDisplay0 = 9,
		Beyond-UI-UICharPassiveLiino-_TryTrackBuff0 = 10,
		Beyond-UI-UIHudFadeController-get_setting0 = 11,
		Beyond-UI-UIHudFadeController-SetLocalNeedShow0 = 12,
		Beyond-UI-UICountShieldNode-Init0 = 12,
		Beyond-UI-GPUIBuffCell-TrySetNodeVisibility1 = 12,
		Beyond-UI-MainCharHpBar-_OnTakeDamage0 = 12,
		Beyond-UI-UIMainCharFootBarArc-SetUIDisable0 = 12,
		Beyond-UI-FacRegionUpgradeEffectController-_RefreshNodeState0 = 12,
		Beyond-UI-RegionMapSetting-SetControllerLevelSelectedState0 = 12,
		Beyond-UI-UIRegionMap3DPanel-OnLevelHoverChanged0 = 12,
		Beyond-UI-UICharPassiveTyphoea-_SetArrowVisibleCount0 = 13,
		Beyond-UI-UICharPassiveTyphoea-_SetVisibleCount0 = 13,
		Beyond-UI-DamageTextBase-SetText1 = 13,
		Beyond-UI-DamageTextBaseV2-SetText1 = 13,
		Beyond-UI-FootBarDashCell-SetIndex0 = 13,
		Beyond-UI-UIWeaknessNode-SetTotalCellNum0 = 13,
		Beyond-UI-UIWeaknessNode-SetCurrentCellNum0 = 13,
		Beyond-UI-ComboSkillPanel-_DestroyExtraHint0 = 13,
		Beyond-UI-ComboSkillPanel-_DestroyLockHint0 = 13,
		Beyond-UI-ComboSkillPanel-_AssignHintData0 = 13,
		Beyond-UI-ComboSkillPanel-_RemoveComboSkill0 = 13,
		Beyond-UI-GPUIAttachedBuffCell-_PlayConsumeAnimations0 = 13,
		Beyond-UI-SkillButton-_OnOtherPressSkillButtonStart0 = 13,
		Beyond-UI-UIAttachedBuffCell-_ClearConsumeAnimationsBelowStackCount0 = 13,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_SetProgressText0 = 13,
		Beyond-UI-UISettlementRegion-_RefreshSpriteWithTier0 = 13,
		Beyond-UI-UISettlementRegion-RefreshSettlementRegionWithTier0 = 13,
		Beyond-UI-PuzzleDrag-SetIndex0 = 13,
		Beyond-UI-RiftScanUI-_UpdateUI0 = 13,
		Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateNodeType0 = 13,
		Beyond-UI-UIUdpipeConnectTracker-UpdateNodeType0 = 13,
		Beyond-UI-UICharPassiveTyphoea-_OnBuffEnhanceChanged0 = 14,
		Beyond-UI-UIHeadBuff-SetBuffIcon0 = 14,
		Beyond-UI-HeadBarCtrl-_RemoveDirectHeadBuff0 = 14,
		Beyond-UI-UIBuffCell-DataInit0 = 14,
		Beyond-UI-UIBuffNode-_OnAddBuff0 = 14,
		Beyond-UI-UIBuffNode-_OnBuffEnhanceChanged0 = 14,
		Beyond-UI-UIBuffNode-_OnBuffIgnite0 = 14,
		Beyond-UI-GPUIBuffCell-DataInit0 = 14,
		Beyond-UI-GPUIAttachedBuffCell-DataInit0 = 14,
		Beyond-UI-GPUIBuffNode-_OnAddBuff0 = 14,
		Beyond-UI-GPUIBuffNode-_OnBuffEnhanceChanged0 = 14,
		Beyond-UI-GPUIBuffNode-_OnBuffIgnite0 = 14,
		Beyond-UI-MainCharHpBar-_OnBuffEnhanceChanged0 = 14,
		Beyond-UI-UISpellInflictionOnCharNode-_OnBuffEnhanceChanged0 = 14,
		Beyond-UI-MainCharHpBar-_SetUltimateBuff0 = 14,
		Beyond-UI-UIAttachedBuffCell-DataInit0 = 14,
		Beyond-UI-LiinoRandomLikeEffect-get_tickOption0 = 15,
		Beyond-UI-DamageTextCtrl-get_tickOption0 = 15,
		Beyond-UI-DamageTextCtrlV2-get_tickOption0 = 15,
		Beyond-UI-DamageTextBase-get_tickOption0 = 15,
		Beyond-UI-HeadBarCtrl-get_tickOption0 = 15,
		Beyond-UI-AtbNode-get_tickOption0 = 15,
		Beyond-UI-ComboSkillPanel-get_tickOption0 = 15,
		Beyond-UI-GPUIBuffNode-get_tickOption0 = 15,
		Beyond-UI-MainCharHpBar-get_tickOption0 = 15,
		Beyond-UI-OutOfScreenTargetsCtrl-get_tickOption0 = 15,
		Beyond-UI-OutOfScreenTargetsCtrlV2-get_tickOption0 = 15,
		Beyond-UI-SkillButton-get_tickOption0 = 15,
		Beyond-UI-SquadIcon-get_tickOption0 = 15,
		Beyond-UI-UIBuffNode-get_tickOption0 = 15,
		Beyond-UI-TyphoeaHudCtrl-get_tickOption0 = 15,
		Beyond-UI-UIAbilityTargetFollower-get_tickOption0 = 15,
		Beyond-UI-UIMainCharFootBar-get_tickOption0 = 15,
		Beyond-UI-UIMainCharFootBarArc-get_tickOption0 = 15,
		Beyond-UI-CoolerUnitProgressBarUI-get_tickOption0 = 15,
		Beyond-UI-CoolerUnitTemperatureCircleUI-get_tickOption0 = 15,
		Beyond-UI-CoolerUnitTemperatureUI-get_tickOption0 = 15,
		Beyond-UI-CoolerUnitTotalProgressBarUI-get_tickOption0 = 15,
		Beyond-UI-DoodadFactoryGasCoreScanUI-get_tickOption0 = 15,
		Beyond-UI-DoodadFactoryGasScanUI-get_tickOption0 = 15,
		Beyond-UI-UIFacTechTreePanel-get_tickOption0 = 15,
		Beyond-UI-ForgeIronProgressBarUI-get_tickOption0 = 15,
		Beyond-UI-ForgeIronTemperatureCircleUI-get_tickOption0 = 15,
		Beyond-UI-ForgeIronTemperatureUI-get_tickOption0 = 15,
		Beyond-UI-HeadLabelCtrl-get_tickOption0 = 15,
		Beyond-UI-UIHeadLabel-get_tickOption0 = 15,
		Beyond-UI-RegionMapSetting-get_tickOption0 = 15,
		Beyond-UI-UILevelMapFallbackDebugOverlay-LabelScreenScaleKeeper-get_tickOption0 = 15,
		Beyond-UI-UILevelMapLimitInRect-get_tickOption0 = 15,
		Beyond-UI-UILevelMapLine-get_tickOption0 = 15,
		Beyond-UI-UILevelMapMissionArea-get_tickOption0 = 15,
		Beyond-UI-UILevelMapTouchPanelWrapper-get_tickOption0 = 15,
		Beyond-UI-UIRegionMap3DPanel-get_tickOption0 = 15,
		Beyond-UI-UIMusicVolumeVisual-get_tickOption0 = 15,
		Beyond-UI-RiftScanUI-get_tickOption0 = 15,
		Beyond-UI-UICommonScanController-get_tickOption0 = 15,
		Beyond-UI-UICountDownBar-get_tickOption0 = 15,
		Beyond-UI-UIPanelBase-get_tickOption0 = 15,
		Beyond-UI-UIRaceModuleRankController-get_tickOption0 = 15,
		Beyond-UI-UIWaterDroneBar-get_tickOption0 = 15,
		Beyond-UI-WorldUIController-get_tickOption0 = 15,
		Beyond-UI-WorldUIFollowAndFaceCamera-get_tickOption0 = 15,
		Beyond-UI-Mission-MissionHudBGSizeUpdater-get_tickOption0 = 15,
		Beyond-UI-LiinoRandomLikeEffect-_SelectArea0 = 16,
		Beyond-UI-UIGeneralTracker-get_rect0 = 16,
		Beyond-UI-LiinoRandomLikeEffect-_GetRandomPointInArea0 = 17,
		Beyond-UI-LiinoRandomLikeEffect-_GetNextAvailableBig0 = 18,
		Beyond-UI-LiinoRandomLikeEffect-_GetNextAvailableSmall0 = 18,
		Beyond-UI-UIHeadBuff-get_anim0 = 18,
		Beyond-UI-UIBuffCell-get_anim0 = 18,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_animationWrapper0 = 18,
		Beyond-UI-LiinoRandomLikeEffect-_PlayEffectAt0 = 19,
		Beyond-UI-UISettlementRegion-InitSettlementRegion0 = 19,
		Beyond-UI-WorldUIFollowAndFaceCamera-SetFollowNpcHeadLabel0 = 19,
		Beyond-UI-ComboSpecialNodeRingQte-_OnComboSkillRingQte0 = 20,
		Beyond-UI-DamageTextCtrl-get_outOfScreenPos0 = 21,
		Beyond-UI-DamageTextCtrlV2-get_outOfScreenPos0 = 21,
		Beyond-UI-DamageTextCtrl-_InstantiateTextInstance0 = 22,
		Beyond-UI-DamageTextCtrl-_CreateTextInstance0 = 22,
		Beyond-UI-DamageTextBase-SetText0 = 23,
		Beyond-UI-DamageTextBaseV2-SetText0 = 23,
		Beyond-UI-UIFacMainRegion-_OnMainRegionLevelChanged0 = 23,
		Beyond-UI-UIFacMainRegion-InitMainRegion0 = 23,
		Beyond-UI-UIBrokenLine-SetYValue0 = 23,
		Beyond-UI-UIBrokenLine-SetYValueByArray0 = 23,
		Beyond-UI-DamageTextBase-SetColor0 = 24,
		Beyond-UI-DamageTextBaseV2-SetColor0 = 24,
		Beyond-UI-DamageTextBlock-SetColor0 = 24,
		Beyond-UI-DamageTextCriticalLevel0-SetColor0 = 24,
		Beyond-UI-DamageTextCriticalLevel1-SetColor0 = 24,
		Beyond-UI-FacLineCell-ChangeLineColor0 = 24,
		Beyond-UI-DamageTextBase-SetFollowTarget0 = 25,
		Beyond-UI-DamageTextBase-get_uiOffset0 = 26,
		Beyond-UI-DamageTextBaseV2-get_uiOffset0 = 26,
		Beyond-UI-DamageTextBase-SetUIOffset0 = 27,
		Beyond-UI-DamageTextBaseV2-SetUIOffset0 = 27,
		Beyond-UI-UIFacTechTreePanel-_OnDrag0 = 27,
		Beyond-UI-ScratchOffLotteryCoating-ApplyScratch0 = 27,
		Beyond-UI-ScratchOffLotteryCoating-BeginScratch0 = 27,
		Beyond-UI-ScratchOffLotteryCoating-EndScratch0 = 27,
		Beyond-UI-DamageTextBase-get_worldPosition0 = 28,
		Beyond-UI-DamageTextBaseV2-_GetWorldPosition0 = 28,
		Beyond-UI-DamageTextBaseV2-get_worldPosition0 = 28,
		Beyond-UI-DamageTextCtrl-_GetRandomTextOffset0 = 29,
		Beyond-UI-DamageTextCtrl-_IsTextPosValid0 = 30,
		Beyond-UI-DamageTextCtrlV2-_UseWorldSpaceRandomArea0 = 30,
		Beyond-UI-DamageTextCtrlV2-_IsTextPosValid0 = 30,
		Beyond-UI-DamageTextCtrl-_OnHpChanged0 = 31,
		Beyond-UI-DamageTextCtrlV2-_OnHpChanged0 = 31,
		Beyond-UI-HeadBarCtrl-_OnHpChanged0 = 31,
		Beyond-UI-DamageTextIgniteBuff-SetUIState0 = 32,
		Beyond-UI-DamageTextCtrl-_OnIgniteBuffText0 = 33,
		Beyond-UI-DamageTextCtrlV2-_OnIgniteBuffText0 = 33,
		Beyond-UI-DamageTextCtrl-_OnImmuneText0 = 34,
		Beyond-UI-DamageTextCtrlV2-_OnImmuneText0 = 34,
		Beyond-UI-DamageTextCtrl-_OnPhysicalInflictionApplied0 = 35,
		Beyond-UI-DamageTextCtrlV2-_OnPhysicalInflictionApplied0 = 35,
		Beyond-UI-DamageTextCtrl-_OnSquadInFightChanged0 = 36,
		Beyond-UI-DamageTextCtrlV2-_OnSquadInFightChanged0 = 36,
		Beyond-UI-HeadBarCtrl-_OnDialogFinish0 = 36,
		Beyond-UI-AtbNode-OnInFightChanged0 = 36,
		Beyond-UI-MainCharHpBar-_OnHideCharHpInfoChanged0 = 36,
		Beyond-UI-SkillButton-_OnHideCharUspInfoChanged0 = 36,
		Beyond-UI-SquadIcon-_OnHideCharHpInfoChanged0 = 36,
		Beyond-UI-TyphoeaHudCtrl-_OnMarkTargetActiveChanged0 = 36,
		Beyond-UI-UIMainCharFootBar-_OnDialogFinish0 = 36,
		Beyond-UI-UIMainCharFootBarArc-_OnDialogFinish0 = 36,
		Beyond-UI-UIMainCharFootBarArc-_OnFinishCutscene0 = 36,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneInfinityLiquidChanged0 = 36,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneEmptyChanged0 = 36,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneRelaxChanged0 = 36,
		Beyond-UI-DamageTextCtrl-_OnCreateFlowText0 = 37,
		Beyond-UI-DamageTextCtrlV2-_OnCreateFlowText0 = 37,
		Beyond-UI-DamageTextCtrl-_OnCharLevelUp0 = 38,
		Beyond-UI-DamageTextCtrlV2-_OnCharLevelUp0 = 38,
		Beyond-UI-DamageTextBaseV2-Assign0 = 39,
		Beyond-UI-GPUIBuffCell-PlayWithAnimation0 = 39,
		Beyond-UI-CommonTrackerUpdate-_ShowTrackerGo0 = 39,
		Beyond-UI-FacLineCell-PlayLineAnimation0 = 39,
		Beyond-UI-FacLineCell-PlayLineDecoAnimation0 = 39,
		Beyond-UI-RegionMapSetting-MoveToPlayer0 = 39,
		Beyond-UI-UILevelMapCommonStaticElement-_RegisterPhaseConditions0 = 39,
		Beyond-UI-UILevelMapCommonStaticElement-_RegisterPhaseConditions1 = 39,
		Beyond-UI-UILevelMapFallbackDebugOverlay-_EnsureLabels0 = 39,
		Beyond-UI-UILevelMapMissionArea-Init0 = 39,
		Beyond-UI-UIRegionMap3DPanel-OnClickLevelBtn0 = 39,
		Beyond-UI-UIDoodadPlantCoreScanController-SetCoreInfo0 = 39,
		Beyond-UI-DamageTextCtrlV2-_CreateTextInstance0 = 40,
		Beyond-UI-DamageTextBaseV2-get_showDuration0 = 41,
		Beyond-UI-DamageTextBaseV2-get_textNodeAlpha0 = 41,
		Beyond-UI-UIPoiseBar-get_realPoise0 = 41,
		Beyond-UI-UIPoiseBar-get_maxPoise0 = 41,
		Beyond-UI-UIAttachedBuffCell-_GetConsumeDecreaseLimitFillAmount0 = 41,
		Beyond-UI-ScratchOffLotteryCoating-OutputCompletePercent0 = 41,
		Beyond-UI-DamageTextBaseV2-_SetStaticPosition0 = 42,
		Beyond-UI-UIHeadLabel-HeadLabelRootVisibleData-Init0 = 42,
		Beyond-UI-UIPowerPoleFastTravelTracker-UpdateDistance0 = 42,
		Beyond-UI-DamageTextBaseV2-_SetHitPointPosition0 = 43,
		Beyond-UI-DamageTextBaseV2-_SetTransformPosition0 = 44,
		Beyond-UI-DamageTextBaseV2-SetFollowTarget0 = 45,
		Beyond-UI-DamageTextCtrlV2-_GetRandomTextOffset0 = 46,
		Beyond-UI-DamageTextBaseV2-SetTextWithMultiplier0 = 47,
		Beyond-UI-DamageTextBaseV2-_UpdatePosition0 = 48,
		Beyond-UI-DamageTextBaseV2-Tick0 = 48,
		Beyond-UI-HeadBarCtrl-_GetHeadBarType0 = 49,
		Beyond-UI-UIAbilityTargetFollower-TryGetOriginalFollowPos0 = 50,
		Beyond-UI-UIHeadBarFollower-TryGetOriginalFollowPos0 = 50,
		Beyond-UI-UIHeadBuff-TryGetOriginalFollowPos0 = 50,
		Beyond-UI-UILvInfoBar-TryGetOriginalFollowPos0 = 50,
		Beyond-UI-UIVigilanceBar-TryGetOriginalFollowPos0 = 50,
		Beyond-UI-UIAbilityTargetFollower-OnActualVisibleChange0 = 51,
		Beyond-UI-UICountShieldCell-SetCellActive0 = 51,
		Beyond-UI-ComboSkillPanel-OnCreate0 = 51,
		Beyond-UI-UISpellInflictionOnCharCell-SetCellActive0 = 51,
		Beyond-UI-MainCharHpBar-_SetHpBarShowing0 = 51,
		Beyond-UI-SkillButton-_SetDisableMaskVisible0 = 51,
		Beyond-UI-SquadIcon-InitSquadIcon0 = 51,
		Beyond-UI-TacticalDotCell-SetDotActive0 = 51,
		Beyond-UI-GuideFakeButton-ForceToggleTargetBinding0 = 51,
		Beyond-UI-UIHeadBar-_SetImageFill0 = 52,
		Beyond-UI-UILevelMapCommonStaticElement-_LoadImage0 = 52,
		Beyond-UI-UILevelMapSwitchBtn-InitSwitchButton0 = 52,
		Beyond-UI-UIHeadBar-_CalculateHpChangeDisplay0 = 53,
		Beyond-UI-MainCharHpBar-_CalculateHpChangeDisplay0 = 53,
		Beyond-UI-UIHeadBar-_OnHpChange0 = 54,
		Beyond-UI-MainCharHpBar-_OnHpChange0 = 54,
		Beyond-UI-SquadIcon-_OnHpChange0 = 54,
		Beyond-UI-UIHeadBar-ShowModifierAfterSetTarget0 = 55,
		Beyond-UI-UIHeadBarFollower-ShowModifierAfterSetTarget0 = 55,
		Beyond-UI-HeadBarCtrl-_RefreshHeadBar0 = 56,
		Beyond-UI-HeadBarCtrl-_OnInteractNpc0 = 57,
		Beyond-UI-UIMainCharFootBar-_OnInteractNpc0 = 57,
		Beyond-UI-UIMainCharFootBarArc-_OnInteractNpc0 = 57,
		Beyond-UI-HeadBarCtrl-_OnDialogStart0 = 58,
		Beyond-UI-UIMainCharFootBar-_OnDialogStart0 = 58,
		Beyond-UI-UIMainCharFootBarArc-_OnDialogStart0 = 58,
		Beyond-UI-HeadBarCtrl-_OnAddHeadBar0 = 59,
		Beyond-UI-OutOfScreenTargetsCtrl-_OnEnemyCastSkillToMainChar0 = 59,
		Beyond-UI-OutOfScreenTargetsCtrlV2-_OnEnemyCastSkillToMainChar0 = 59,
		Beyond-UI-HeadBarCtrl-_OnRemoveHeadBar0 = 60,
		Beyond-UI-UIHeadBar-_OnMainTargetChanged0 = 60,
		Beyond-UI-UIWeakLockAim-_OnMainTargetChanged0 = 60,
		Beyond-UI-HeadBarCtrl-_OnEnemyPartEnableChanged0 = 61,
		Beyond-UI-HeadBarCtrl-_OnBuffIconChange0 = 62,
		Beyond-UI-HeadBarCtrl-_FindBountyBuffIcon0 = 63,
		Beyond-UI-UIBuffNode-_GetIconStyle0 = 64,
		Beyond-UI-GPUIBuffNode-_GetIconStyle0 = 64,
		Beyond-UI-UIBuffCell-get_buffData0 = 65,
		Beyond-UI-GPUIBuffCell-get_buffData0 = 65,
		Beyond-UI-UIBuffCell-Init0 = 66,
		Beyond-UI-GPUIBuffCell-Init0 = 66,
		Beyond-UI-UIBuffCell-SetStackCount0 = 67,
		Beyond-UI-GPUIBuffCell-SetStackCount0 = 67,
		Beyond-UI-GPUIAttachedBuffCell-SetStackCount0 = 67,
		Beyond-UI-UIAttachedBuffCell-SetStackCount0 = 67,
		Beyond-UI-UILevelMapCommonStaticElement-_OnAnyConditionChanged0 = 67,
		Beyond-UI-UILevelMapNarrativeAreaText-_OnAnyConditionChanged0 = 67,
		Beyond-UI-UIBuffCell-get_orderPriority0 = 68,
		Beyond-UI-GPUIBuffCell-get_orderPriority0 = 68,
		Beyond-UI-BattleControllerInputController-TryPressControllerIndicatorWhenSkillButtonJustPressed0 = 68,
		Beyond-UI-HeadLabelCtrl-get__poolCapacity0 = 68,
		Beyond-UI-PuzzleDrag-get_luaIndex0 = 68,
		Beyond-UI-UIBuffCell-get_buffInstanceUid0 = 69,
		Beyond-UI-GPUIBuffCell-get_buffInstanceUid0 = 69,
		Beyond-UI-UIBuffNode-BuffCellGroup-CreateBuffCell0 = 70,
		Beyond-UI-UIBuffNode-_AddBuffIconInternal0 = 71,
		Beyond-UI-GPUIBuffNode-_AddBuffIconInternal0 = 71,
		Beyond-UI-UIPoiseBar-_CreatePoiseKnot0 = 72,
		Beyond-UI-UIPoiseBar-get_owner0 = 73,
		Beyond-UI-UIPoiseBar-Init0 = 74,
		Beyond-UI-UIBuffNode-_RemoveBuffIconInternal0 = 75,
		Beyond-UI-UIBuffNode-_OnRemoveBuff0 = 75,
		Beyond-UI-GPUIBuffNode-_RemoveBuffIconInternal0 = 75,
		Beyond-UI-GPUIBuffNode-_OnRemoveBuff0 = 75,
		Beyond-UI-UIBuffNode-Init0 = 76,
		Beyond-UI-GPUIBuffNode-Init0 = 76,
		Beyond-UI-UISpellInflictionOnCharNode-OnInit0 = 76,
		Beyond-UI-SquadIcon-_InitCurrentBuffNode0 = 76,
		Beyond-UI-UIPoiseBar-_CalculatePoiseChangeDisplay0 = 77,
		Beyond-UI-UIPoiseBar-OnPoiseChange0 = 78,
		Beyond-UI-UIHeadBar-_OnPoiseChange0 = 78,
		Beyond-UI-UIHeadBar-_OnMultiTimeWeaknessActivate0 = 79,
		Beyond-UI-UIHeadBar-_OnWeaknessCountChanged0 = 80,
		Beyond-UI-UIHeadBar-_OnLockHoldAimChanged0 = 81,
		Beyond-UI-UIAbilityTargetFollower-GetAdjustedHeightOffset0 = 82,
		Beyond-UI-UIRegionMap3DPanel-_GetMoveTargetLocalPosition0 = 82,
		Beyond-UI-UIPanelBase-GetSpritePath0 = 83,
		Beyond-UI-GPUIBuffCell-_ResolveNodeName0 = 83,
		Beyond-UI-UIPanelBase-LoadSprite0 = 84,
		Beyond-UI-AtbNode-get_battleManager0 = 85,
		Beyond-UI-AtbNode-get_skillSetting0 = 86,
		Beyond-UI-SkillButton-get_skillSetting0 = 86,
		Beyond-UI-SkillButton-PressHandler-get_skillSetting0 = 86,
		Beyond-UI-AtbNode-_GetAtbCellFillAmount0 = 87,
		Beyond-UI-AtbNode-OnGainAtb0 = 88,
		Beyond-UI-AtbNode-_AddAtbCellLayout0 = 89,
		Beyond-UI-UIFacTechTreePanel-FocusNode0 = 89,
		Beyond-UI-UIFacTechTreePanel-OnUnlockTech0 = 89,
		Beyond-UI-ComboSkillPanel-_EnsureExtraHint0 = 90,
		Beyond-UI-ComboSkillPanel-_GetHint0 = 90,
		Beyond-UI-ComboSkillHint-Init0 = 91,
		Beyond-UI-UIPanelBase-LoadGameObject0 = 92,
		Beyond-UI-ComboSkillPanel-_OnComboSkillReady0 = 93,
		Beyond-UI-ComboSkillPanel-_OnComboSkillRemove0 = 93,
		Beyond-UI-ComboSkillPanel-_OnActiveSkillDataRefreshed0 = 94,
		Beyond-UI-SkillButton-_OnCharSkillChange0 = 94,
		Beyond-UI-SkillButton-_OnCharUltimateSkillChange0 = 94,
		Beyond-UI-SkillButton-_OnActiveSkillDataRefreshed0 = 94,
		Beyond-UI-GPUIAttachedBuffCell-get_defaultBuffIconNodeName0 = 95,
		Beyond-UI-GPUIBuffCell-get_defaultBuffIconNodeName0 = 95,
		Beyond-UI-UIHeadLabel-get_headLabelIcon0 = 95,
		Beyond-UI-UIHeadLabel-get_missionHeadLabelIcon0 = 95,
		Beyond-UI-RiftScanUI-_GetStateName0 = 95,
		Beyond-UI-GPUIBuffCell-_TryResolveGpui0 = 96,
		Beyond-UI-GPUIBuffCell-TrySetImageFillAmount0 = 97,
		Beyond-UI-GPUIBuffCell-TrySetNodeRotZ0 = 97,
		Beyond-UI-GPUIBuffCell-TrySetText0 = 98,
		Beyond-UI-GPUIBuffCell-TrySetSprite0 = 98,
		Beyond-UI-GPUIBuffCell-TryStartRootAnimation0 = 99,
		Beyond-UI-GPUIBuffCell-TryStartSubrootAnimation0 = 100,
		Beyond-UI-GPUIBuffCell-SetBuffIcon0 = 101,
		Beyond-UI-GPUIAttachedBuffCell-SetBuffIcon0 = 101,
		Beyond-UI-GPUIBuffNode-_IsBuffCellVisibleByLimit0 = 101,
		Beyond-UI-SkillButton-_HasDisableNormalSkillWithUITag0 = 101,
		Beyond-UI-HeadLabelCtrl-_ShouldRender0 = 101,
		Beyond-UI-UILevelMapTouchPanelWrapper-_IsFirstRaycastSelectable0 = 101,
		Beyond-UI-ChessboardDrop-_CheckEventValid0 = 101,
		Beyond-UI-GPUIBuffCell-TrySetNodeVisibility0 = 102,
		Beyond-UI-GPUIBuffCell-_TrySetRootScale0 = 103,
		Beyond-UI-GPUIBuffCell-TrySetColor0 = 104,
		Beyond-UI-GPUIBuffNode-_RemoveSingleBuffCell0 = 105,
		Beyond-UI-GPUIBuffNode-_RemoveStackBuffIconInternal0 = 106,
		Beyond-UI-GPUIBuffNode-_PlayInAnimation0 = 107,
		Beyond-UI-UILevelMapFallbackDebugOverlay-_RefreshLabelTexts0 = 107,
		Beyond-UI-GPUIBuffNode-BuffCellGroup-CreateBuffCell0 = 108,
		Beyond-UI-GPUIBuffNode-_AddStackBuffIconInternal0 = 109,
		Beyond-UI-HpBarComboNode-_OnGlobalBuffStart0 = 110,
		Beyond-UI-HpBarComboNode-_OnGlobalBuffFinish0 = 111,
		Beyond-UI-MainCharHpBar-_GetLatestValidCharHpBarVfxBuffPtrFromCache0 = 112,
		Beyond-UI-SquadIcon-_GetLatestValidCharHpBarVfxBuffPtrFromCache0 = 112,
		Beyond-UI-MainCharHpBar-_GetUltimateBuffForAbility0 = 113,
		Beyond-UI-MainCharHpBar-_GetOrCreateCharPassiveBase0 = 114,
		Beyond-UI-MainCharHpBar-_OnMainCharChange0 = 115,
		Beyond-UI-SquadIcon-_OnMainCharChange0 = 115,
		Beyond-UI-UIMainCharFootBar-_OnMainCharChange0 = 115,
		Beyond-UI-UIMainCharFootBarArc-_OnMainCharChange0 = 115,
		Beyond-UI-OutOfScreenTargetsCtrl-_CreateOneArrow0 = 116,
		Beyond-UI-OutOfScreenTargetsCtrl-_ScreenPosToUIPos0 = 117,
		Beyond-UI-OutOfScreenTargetsCtrlV2-_ScreenPosToUIPos0 = 117,
		Beyond-UI-OutOfScreenTargetsCtrlV2-_CreateArrowState0 = 118,
		Beyond-UI-SkillButton-_OnCharPotentialUnlock0 = 119,
		Beyond-UI-SkillButton-_OnSkillUpgradeSuccess0 = 120,
		Beyond-UI-SkillButton-_OnSkillCdChanged0 = 121,
		Beyond-UI-UIPanelBase-LoadSpriteWithOutFormat0 = 122,
		Beyond-UI-SkillButton-_OnInputActionKeyUpdated0 = 123,
		Beyond-UI-BattleControllerInputController-_OnInputActionKeyUpdated0 = 123,
		Beyond-UI-GuideFakeButton-_OnTriggerPlayerAction0 = 123,
		Beyond-UI-UISettlementRegion-_OnSettlementUnlocked0 = 123,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneInteractiveChanged0 = 123,
		Beyond-UI-SkillButton-FirstTimeInit0 = 124,
		Beyond-UI-SquadIcon-FirstTimeInit0 = 124,
		Beyond-UI-SquadIcon-CanSwitchToCenter0 = 125,
		Beyond-UI-SquadIcon-_OnIgniteBuffText0 = 126,
		Beyond-UI-UIAttachedBuffCell-_PlayConsumeAnimations0 = 127,
		Beyond-UI-UIHudFadeConsoleController-_OnInformShow0 = 128,
		Beyond-UI-UIHudFadeController-_OnInformShow0 = 128,
		Beyond-UI-UIHudFadeTouchSkill-_OnInformShow0 = 128,
		Beyond-UI-UITyphoeaLockingNode-get_cachedOutAnimCallback0 = 129,
		Beyond-UI-TyphoeaHudCtrl-OnLockAimOutAnimComplete0 = 130,
		Beyond-UI-TyphoeaHudCtrl-_CreateLocking0 = 131,
		Beyond-UI-TyphoeaHudCtrl-_OnMarkTargetChanged1 = 132,
		Beyond-UI-TyphoeaHudCtrl-_GetArrowBuffCount0 = 133,
		Beyond-UI-CommonTrackerUpdate-_FindTrackIndexByKey0 = 133,
		Beyond-UI-UILevelMapCommonStaticElement-_FindMatchingPhaseIndex0 = 133,
		Beyond-UI-UILevelMapCommonStaticElement-_FindMatchingPhaseIndex1 = 133,
		Beyond-UI-PuzzleControllerHelper-TryGetPuzzleSlotIndexByPos0 = 133,
		Beyond-UI-TyphoeaHudCtrl-_UpdateLockingPositions0 = 134,
		Beyond-UI-TyphoeaArcheryCrosshairComp-UpdateComp0 = 134,
		Beyond-UI-UIMainCharFootBarArc-_RefreshBarMode0 = 135,
		Beyond-UI-UIMainCharFootBarArc-_OnPlayCutscene0 = 136,
		Beyond-UI-UIMainCharFootBarArc-_OnForbidSystemChanged0 = 137,
		Beyond-UI-BlueprintPreviewHelper-SetSize0 = 138,
		Beyond-UI-UIWorldCanvasResolutionScaleFit-OnScreenSizeChanged0 = 138,
		Beyond-UI-BlueprintPreviewHelper-AddGridValue0 = 139,
		Beyond-UI-BlueprintPreviewHelper-BatchAddGridValue0 = 140,
		Beyond-UI-BlueprintPreviewHelper-GetGridValue0 = 141,
		Beyond-UI-CommonTrackerNodeComp-ShowStyleType0 = 142,
		Beyond-UI-CommonTrackerNodeComp-PlayOutAnimation0 = 143,
		Beyond-UI-UIBlackboxTracker-UpdatePosition0 = 144,
		Beyond-UI-UICampfireTracker-UpdatePosition0 = 144,
		Beyond-UI-UICommonLevelTracker-UpdatePosition0 = 145,
		Beyond-UI-UICommonTracker-UpdatePosition0 = 145,
		Beyond-UI-CommonTrackerUpdate-_CreateNewMissionTracker0 = 146,
		Beyond-UI-CommonTrackerUpdate-_InitTrackInfoByIndex0 = 147,
		Beyond-UI-CommonTrackerUpdate-UpdateCommonTrackers0 = 148,
		Beyond-UI-WorldUIController-Init0 = 149,
		Beyond-UI-CoolerUnitProgressBarUI-Init0 = 149,
		Beyond-UI-CoolerUnitTemperatureCircleUI-Init0 = 149,
		Beyond-UI-CoolerUnitTemperatureUI-Init0 = 149,
		Beyond-UI-CoolerUnitTotalProgressBarUI-Init0 = 149,
		Beyond-UI-DoodadFactoryGasCoreScanUI-Init0 = 149,
		Beyond-UI-DoodadFactoryGasScanUI-Init0 = 149,
		Beyond-UI-ForgeIronProgressBarUI-Init0 = 149,
		Beyond-UI-ForgeIronTemperatureCircleUI-Init0 = 149,
		Beyond-UI-ForgeIronTemperatureUI-Init0 = 149,
		Beyond-UI-RiftScanUI-Init0 = 149,
		Beyond-UI-CoolerUnitTemperatureCircleUI-_GetLangKeyOrDefault0 = 150,
		Beyond-UI-CoolerUnitTemperatureCircleUI-_SetState0 = 151,
		Beyond-UI-CoolerUnitTemperatureUI-NormalizeRange0 = 152,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_GeneratePercentStrings0 = 153,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_TryGetModule0 = 154,
		Beyond-UI-DoodadFactoryGasCoreScanUI-_OnDomainDevelopmentChange0 = 155,
		Beyond-UI-FacLineDrawer-_CloneLineObject0 = 156,
		Beyond-UI-FacLineDrawer-_RefreshCopyLineObjectColor0 = 157,
		Beyond-UI-FacLineDrawer-DrawLine0 = 158,
		Beyond-UI-FacLineDrawer-PlayLineAnimation0 = 159,
		Beyond-UI-FacLineDrawer-PlayPortLineDecoAnimation0 = 160,
		Beyond-UI-FacLineDrawer-ChangeLineColor0 = 161,
		Beyond-UI-UIFacTechTreePanel-_SetScale0 = 162,
		Beyond-UI-UIFacTechTreePanel-_OnZoom0 = 163,
		Beyond-UI-UIFacTechTreePanel-MoveNode0 = 164,
		Beyond-UI-UIFacTechTreePanel-_OnUnlockMoveNode0 = 165,
		Beyond-UI-ScratchOffLotteryCoating-Draw0 = 165,
		Beyond-UI-ForgeIronTemperatureCircleUI-_SetState0 = 166,
		Beyond-UI-HeadLabelCtrl-_CreateView0 = 167,
		Beyond-UI-HeadLabelCtrl-_TryGetViewFromPool0 = 167,
		Beyond-UI-UIHeadLabel-HeadLabelRootVisibleData-UpdateVisible0 = 168,
		Beyond-UI-UIHeadLabel-SetSubRootVisible0 = 169,
		Beyond-UI-UIHeadLabel-_RefreshVisible0 = 170,
		Beyond-UI-UIHeadLabel-Refresh0 = 171,
		Beyond-UI-UIHeadLabel-Bind0 = 172,
		Beyond-UI-UIHeadLabel-get_iconHolder0 = 173,
		Beyond-UI-RegionMapSetting-get_cfg0 = 174,
		Beyond-UI-RegionMapSetting-_SetMapPos0 = 175,
		Beyond-UI-RegionMapSetting-IsCircleIntersectingRectangle0 = 176,
		Beyond-UI-RegionMapSetting-InitData0 = 177,
		Beyond-UI-RegionMapSetting-GetNodeTransform0 = 178,
		Beyond-UI-UIRegionMap3DPanel-_GetNodeTransform0 = 178,
		Beyond-UI-RegionMapSetting-GetNodeMoveTargetLocalPosition0 = 179,
		Beyond-UI-RegionMapSetting-GetCfg0 = 180,
		Beyond-UI-RegionMapSetting-StartRegionRectTransformMoveRotationTween0 = 181,
		Beyond-UI-RegionMapSetting-get_m_materialPropertyBlock0 = 182,
		Beyond-UI-UILevelMapCrane-_OnCraneStateChanged0 = 183,
		Beyond-UI-UILevelMapMisty-_OnMistyStateChanged0 = 183,
		Beyond-UI-UILevelMapFallbackDebugOverlay-get_mainTexture0 = 184,
		Beyond-UI-UILevelMapFallbackDebugOverlay-Ensure0 = 185,
		Beyond-UI-UILevelMapFallbackDebugOverlay-_EnsureLabel0 = 186,
		Beyond-UI-UILevelMapFallbackDebugOverlay-_FormatWorld0 = 187,
		Beyond-UI-UILevelMapFallbackDebugOverlay-Setup0 = 188,
		Beyond-UI-UILevelMapFallbackDebugOverlay-_AddLine0 = 189,
		Beyond-UI-UILevelMapMisty-IsMistyVisible0 = 190,
		Beyond-UI-UILevelMapNarrativeAreaText-_MergeAllConditionExpressions0 = 191,
		Beyond-UI-PuzzleControllerHelper-get_raycastResults0 = 192,
		Beyond-UI-PuzzleDrag-get_panel0 = 193,
		Beyond-UI-ScratchOffLotteryCoating-_GetPixelIndex0 = 194,
		Beyond-UI-ScratchOffLotteryCoating-_MarkScratchPos0 = 195,
		Beyond-UI-ScratchOffLotteryCoating-_AwardMarkScratchPos0 = 195,
		Beyond-UI-ScratchOffLotteryCoating-_ClampDrawRect0 = 196,
		Beyond-UI-ScratchOffLotteryCoating-_FigureUpCreateRouteLinePoints0 = 197,
		Beyond-UI-ScratchOffLotteryCoating-_ComputeBrushUV0 = 198,
		Beyond-UI-ScratchOffLotteryCoating-_ScreenPosToUiLocalPos0 = 199,
		Beyond-UI-UIMusicVolumeVisual-get_graphic0 = 200,
		Beyond-UI-RiftScanUI-_GetTypeDesText0 = 201,
		Beyond-UI-RiftScanUI-_GetTypePercentText0 = 202,
		Beyond-UI-UICommonScanController-SetTarget0 = 203,
		Beyond-UI-UICommonScanController-SetFixPoint0 = 204,
		Beyond-UI-UICountDownBar-InitData0 = 205,
		Beyond-UI-UIDoodadMineCoreScanController-SetPurity0 = 206,
		Beyond-UI-UIDoodadMineCoreScanController-SyncConditonInfo0 = 206,
		Beyond-UI-UIDoodadMineCoreScanController-UpdateUI0 = 206,
		Beyond-UI-UIDoodadPlantCoreScanController-SetRefreshInfo0 = 207,
		Beyond-UI-UIDoodadPlantCoreScanController-SetSingle0 = 208,
		Beyond-UI-UIDoodadPlantCoreScanController-SetQuantityInfo0 = 209,
		Beyond-UI-UIDoodadScanController-SyncRefreshInfo0 = 210,
		Beyond-UI-UIDoodadScanController-UpdateUI0 = 210,
		Beyond-UI-UIGeneralTracker-UpdatePosition0 = 211,
		Beyond-UI-UILiquidPoolScanController-SetWaterInfo0 = 212,
		Beyond-UI-UIPowerPoleAutoConnectTracker-StatusHintGroup-Switch0 = 213,
		Beyond-UI-UIPowerPoleAutoConnectTracker-_ActualUpdateStatus0 = 213,
		Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateStatus0 = 213,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_iconStatus0 = 214,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageNormal0 = 215,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageNormalOther0 = 215,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageWarning0 = 215,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageHighlighted0 = 215,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageHighlightedOther0 = 215,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageDisabled0 = 215,
		Beyond-UI-UIPowerPoleFastTravelTracker-set_iconStatus0 = 216,
		Beyond-UI-UIPowerPoleFastTravelTracker-UpdateIconStatus0 = 216,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_status0 = 217,
		Beyond-UI-UIPowerPoleFastTravelTracker-set_status0 = 218,
		Beyond-UI-UIPowerPoleFastTravelTracker-UpdateStatus0 = 218,
		Beyond-UI-UIRaceModuleRankController-_UpdateRaceModuleRank0 = 219,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneSourceTypeChanged0 = 220,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneHydrantStateChanged0 = 221,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneHydrantStateChanged1 = 222,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneChange0 = 223,
		Beyond-UI-WorldUIFollowAndFaceCamera-SetFollowTarget0 = 224,
		Beyond-UI-WorldUIFollowAndFaceCamera-SetFollowPosition0 = 225
	}

	public delegate bool __HotPatchDelegate_1(object P0); // TypeDefIndex: 80238; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate ObjectPtr<AbilitySystem> __HotPatchDelegate_2(object P0); // TypeDefIndex: 80239; 0x0000000186464680-0x00000001864646B0

	public delegate void __HotPatchDelegate_3(object P0, bool P1); // TypeDefIndex: 80240; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_4(object P0, float P1); // TypeDefIndex: 80241; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_5(object P0, ObjectPtr<Buff> P1, bool P2, Buff.FinishReason P3); // TypeDefIndex: 80242; 0x00000001826E9FD0-0x00000001826EA010

	public delegate void __HotPatchDelegate_6(object P0, object P1); // TypeDefIndex: 80243; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_7(object P0); // TypeDefIndex: 80244; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_8(object P0, ObjectPtr<Buff> P1); // TypeDefIndex: 80245; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate Buff __HotPatchDelegate_9(object P0); // TypeDefIndex: 80246; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_10(object P0, ObjectPtr<Buff> P1, object P2); // TypeDefIndex: 80247; 0x0000000181256E30-0x0000000181256E60

	public delegate GameplayMiscSetting __HotPatchDelegate_11(object P0); // TypeDefIndex: 80248; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_12(object P0, object P1, bool P2); // TypeDefIndex: 80249; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_13(object P0, int P1); // TypeDefIndex: 80250; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_14(object P0, ObjectPtr<Buff> P1); // TypeDefIndex: 80251; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate TickType __HotPatchDelegate_15(object P0); // TypeDefIndex: 80252; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate RectTransform __HotPatchDelegate_16(object P0); // TypeDefIndex: 80253; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Vector3 __HotPatchDelegate_17(object P0, object P1, bool P2); // TypeDefIndex: 80254; 0x00000001826EA620-0x00000001826EA670

	public delegate UIAnimationWrapper __HotPatchDelegate_18(object P0); // TypeDefIndex: 80255; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_19(object P0, object P1, Vector3 P2); // TypeDefIndex: 80256; 0x0000000181271010-0x0000000181271050

	public delegate void __HotPatchDelegate_20(object P0, in EventData<int, float, float> P1); // TypeDefIndex: 80257; 0x00000001859B7730-0x00000001859B7740

	public delegate Vector3 __HotPatchDelegate_21(); // TypeDefIndex: 80258; 0x000000018691BF80-0x000000018691BFC0

	public delegate DamageTextBase __HotPatchDelegate_22(object P0, DamageTextType P1); // TypeDefIndex: 80259; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_23(object P0, object P1, int P2); // TypeDefIndex: 80260; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_24(object P0, UnityEngine.Color P1); // TypeDefIndex: 80261; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate void __HotPatchDelegate_25(object P0, object P1, object P2, Vector3? P3); // TypeDefIndex: 80262; 0x000000018415EC50-0x000000018415EC90

	public delegate Vector2 __HotPatchDelegate_26(object P0); // TypeDefIndex: 80263; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_27(object P0, Vector2 P1); // TypeDefIndex: 80264; 0x00000001859B7730-0x00000001859B7740

	public delegate Vector3 __HotPatchDelegate_28(object P0); // TypeDefIndex: 80265; 0x0000000185D32980-0x0000000185D329C0

	public delegate Vector2 __HotPatchDelegate_29(object P0, float P1, float P2); // TypeDefIndex: 80266; 0x000000018238E680-0x000000018238E6A0

	public delegate bool __HotPatchDelegate_30(object P0, Vector3 P1); // TypeDefIndex: 80267; 0x0000000186036470-0x00000001860364A0

	public delegate void __HotPatchDelegate_31(object P0, in EventData<AbilitySystem.Modifier> P1); // TypeDefIndex: 80268; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_32(object P0, EnergyShardType P1, bool P2); // TypeDefIndex: 80269; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_33(object P0, in EventData<AbilitySystem, Vector3, Vector2, string, EnergyShardType> P1); // TypeDefIndex: 80270; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_34(object P0, in EventData<AbilitySystem, Vector3, Vector2, string> P1); // TypeDefIndex: 80271; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_35(object P0, in EventData<AbilitySystem, AbilitySystemForEnemyPart, PhysicalInflictionType> P1); // TypeDefIndex: 80272; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_36(object P0, in EventData<bool> P1); // TypeDefIndex: 80273; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_37(object P0, in EventData<Vector3, string, UnityEngine.Color> P1); // TypeDefIndex: 80274; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_38(object P0, in EventData<ulong, int> P1); // TypeDefIndex: 80275; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_39(object P0, object P1, object P2); // TypeDefIndex: 80276; 0x00000001811DF7F0-0x00000001811DF810

	public delegate DamageTextBaseV2 __HotPatchDelegate_40(object P0, DamageTextType P1, object P2); // TypeDefIndex: 80277; 0x00000001811DF7F0-0x00000001811DF810

	public delegate float __HotPatchDelegate_41(object P0); // TypeDefIndex: 80278; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_42(object P0, Vector3 P1); // TypeDefIndex: 80279; 0x0000000186036470-0x00000001860364A0

	public delegate void __HotPatchDelegate_43(object P0, object P1, Vector3 P2, float P3); // TypeDefIndex: 80280; 0x000000018416DEB0-0x000000018416DF00

	public delegate void __HotPatchDelegate_44(object P0, object P1, bool P2, float P3); // TypeDefIndex: 80281; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_45(object P0, object P1, object P2, Vector3? P3, float P4); // TypeDefIndex: 80282; 0x00000001841756F0-0x0000000184175740

	public delegate Vector2 __HotPatchDelegate_46(object P0, float P1, float P2, bool P3, Vector3 P4); // TypeDefIndex: 80283; 0x0000000187A965C4-0x0000000187A96610

	public delegate void __HotPatchDelegate_47(object P0, object P1, object P2, int P3); // TypeDefIndex: 80284; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_48(object P0, Vector2 P1, float P2); // TypeDefIndex: 80285; 0x000000018124EAD0-0x000000018124EAF0

	public delegate HeadBarCtrl.HeadBarType __HotPatchDelegate_49(ObjectPtr<AbilitySystem> P0); // TypeDefIndex: 80286; 0x0000000186A4F2D0-0x0000000186A4F300

	public delegate bool __HotPatchDelegate_50(object P0, out Vector3 P1); // TypeDefIndex: 80287; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_51(object P0, bool P1, bool P2); // TypeDefIndex: 80288; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_52(object P0, object P1, float P2); // TypeDefIndex: 80289; 0x000000018124EAD0-0x000000018124EAF0

	public delegate void __HotPatchDelegate_53(object P0, object P1, double P2); // TypeDefIndex: 80290; 0x000000018124EAD0-0x000000018124EAF0

	public delegate void __HotPatchDelegate_54(object P0, object P1, double P2, bool P3); // TypeDefIndex: 80291; 0x00000001826DF730-0x00000001826DF750

	public delegate void __HotPatchDelegate_55(object P0, in AbilitySystem.Modifier P1); // TypeDefIndex: 80292; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_56(object P0, HeadBarCtrl.HeadBarRefreshReason P1); // TypeDefIndex: 80293; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_57(object P0, in EventData<string, Entity> P1); // TypeDefIndex: 80294; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_58(object P0, in EventData<bool, DialogEnums.DialogType> P1); // TypeDefIndex: 80295; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_59(object P0, in EventData<AbilitySystem> P1); // TypeDefIndex: 80296; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_60(object P0, in EventData<AbilitySystem, bool> P1); // TypeDefIndex: 80297; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_61(object P0, in EventData<AbilitySystemForEnemyPart, bool> P1); // TypeDefIndex: 80298; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_62(object P0, in EventData<AbilitySystem, ObjectPtr<Buff>, bool, Buff.FinishReason> P1); // TypeDefIndex: 80299; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_63(object P0, ObjectPtr<AbilitySystem> P1); // TypeDefIndex: 80300; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate BuffIconConfig.BuffIconStyle __HotPatchDelegate_64(object P0, object P1); // TypeDefIndex: 80301; 0x00000001859B7730-0x00000001859B7740

	public delegate BuffData __HotPatchDelegate_65(object P0); // TypeDefIndex: 80302; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_66(object P0, ObjectPtr<Buff> P1, object P2, object P3); // TypeDefIndex: 80303; 0x00000001826E9F90-0x00000001826E9FD0

	public delegate void __HotPatchDelegate_67(object P0, int P1, bool P2); // TypeDefIndex: 80304; 0x00000001811DF7F0-0x00000001811DF810

	public delegate int __HotPatchDelegate_68(object P0); // TypeDefIndex: 80305; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate ulong __HotPatchDelegate_69(object P0); // TypeDefIndex: 80306; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UIBuffCell __HotPatchDelegate_70(object P0, object P1); // TypeDefIndex: 80307; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_71(object P0, ObjectPtr<Buff> P1, bool P2); // TypeDefIndex: 80308; 0x0000000181256E30-0x0000000181256E60

	public delegate UIPoiseKnot __HotPatchDelegate_72(object P0); // TypeDefIndex: 80309; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate AbilitySystem __HotPatchDelegate_73(object P0); // TypeDefIndex: 80310; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_74(object P0, object P1, bool P2, bool P3, object P4); // TypeDefIndex: 80311; 0x00000001826EA060-0x00000001826EA080

	public delegate void __HotPatchDelegate_75(object P0, ObjectPtr<Buff> P1, Buff.FinishReason P2); // TypeDefIndex: 80312; 0x0000000181256E30-0x0000000181256E60

	public delegate void __HotPatchDelegate_76(object P0, ObjectPtr<AbilitySystem> P1); // TypeDefIndex: 80313; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate void __HotPatchDelegate_77(object P0, double P1); // TypeDefIndex: 80314; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_78(object P0, object P1, float P2, bool P3); // TypeDefIndex: 80315; 0x00000001826DF730-0x00000001826DF750

	public delegate void __HotPatchDelegate_79(object P0, object P1, bool P2, int P3); // TypeDefIndex: 80316; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_80(object P0, object P1, int P2, int P3); // TypeDefIndex: 80317; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_81(object P0, in EventData<bool, bool, float, AbilitySystem> P1); // TypeDefIndex: 80318; 0x00000001859B7730-0x00000001859B7740

	public delegate Vector3 __HotPatchDelegate_82(object P0, object P1); // TypeDefIndex: 80319; 0x0000000186AEB300-0x0000000186AEB340

	public delegate string __HotPatchDelegate_83(object P0, object P1, object P2); // TypeDefIndex: 80320; 0x00000001811DF7F0-0x00000001811DF810

	public delegate Sprite __HotPatchDelegate_84(object P0, object P1, object P2); // TypeDefIndex: 80321; 0x00000001811DF7F0-0x00000001811DF810

	public delegate BattleManager __HotPatchDelegate_85(object P0); // TypeDefIndex: 80322; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate SkillSetting __HotPatchDelegate_86(object P0); // TypeDefIndex: 80323; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate float __HotPatchDelegate_87(object P0, int P1, float P2); // TypeDefIndex: 80324; 0x000000018124EAD0-0x000000018124EAF0

	public delegate void __HotPatchDelegate_88(object P0, in EventData<float> P1); // TypeDefIndex: 80325; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_89(object P0, float P1, float P2, object P3); // TypeDefIndex: 80326; 0x00000001812250A0-0x00000001812250C0

	public delegate ComboSkillHint __HotPatchDelegate_90(object P0, int P1); // TypeDefIndex: 80327; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_91(object P0, object P1, int P2, bool P3); // TypeDefIndex: 80328; 0x0000000181217F60-0x0000000181217F80

	public delegate GameObject __HotPatchDelegate_92(object P0, object P1); // TypeDefIndex: 80329; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_93(object P0, in EventData<int> P1); // TypeDefIndex: 80330; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_94(object P0, in EventData<ulong, string> P1); // TypeDefIndex: 80331; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_95(object P0); // TypeDefIndex: 80332; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_96(object P0, out GPUIExtendedSystem P1, out GPUIHandle P2); // TypeDefIndex: 80333; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_97(object P0, object P1, float P2); // TypeDefIndex: 80334; 0x000000018124EAD0-0x000000018124EAF0

	public delegate bool __HotPatchDelegate_98(object P0, object P1, object P2); // TypeDefIndex: 80335; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_99(object P0, object P1, out float P2); // TypeDefIndex: 80336; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_100(object P0, object P1, object P2, out float P3); // TypeDefIndex: 80337; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_101(object P0, object P1); // TypeDefIndex: 80338; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_102(object P0, object P1, bool P2); // TypeDefIndex: 80339; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_103(object P0, Vector2 P1); // TypeDefIndex: 80340; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_104(object P0, object P1, UnityEngine.Color P2); // TypeDefIndex: 80341; 0x0000000181499900-0x0000000181499930

	public delegate void __HotPatchDelegate_105(object P0, ulong P1, object P2, Buff.FinishReason P3, object P4, object P5); // TypeDefIndex: 80342; 0x0000000181256340-0x0000000181256360

	public delegate void __HotPatchDelegate_106(object P0, ObjectPtr<Buff> P1, Buff.FinishReason P2, object P3, object P4); // TypeDefIndex: 80343; 0x00000001826EA980-0x00000001826EA9D0

	public delegate void __HotPatchDelegate_107(object P0, object P1, object P2, bool P3); // TypeDefIndex: 80344; 0x0000000181217F60-0x0000000181217F80

	public delegate GPUIBuffCell __HotPatchDelegate_108(object P0, object P1, object P2); // TypeDefIndex: 80345; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_109(object P0, ObjectPtr<Buff> P1, bool P2, object P3, object P4); // TypeDefIndex: 80346; 0x00000001826EA980-0x00000001826EA9D0

	public delegate void __HotPatchDelegate_110(object P0, in EventData<GlobalBuff, string> P1); // TypeDefIndex: 80347; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_111(object P0, in EventData<GlobalBuff, string, GlobalBuff.FinishReason> P1); // TypeDefIndex: 80348; 0x00000001859B7730-0x00000001859B7740

	public delegate ObjectPtr<Buff> __HotPatchDelegate_112(object P0); // TypeDefIndex: 80349; 0x0000000186464680-0x00000001864646B0

	public delegate ObjectPtr<Buff> __HotPatchDelegate_113(object P0, object P1); // TypeDefIndex: 80350; 0x00000001812C43A0-0x00000001812C43E0

	public delegate UICharPassiveBase __HotPatchDelegate_114(object P0, object P1); // TypeDefIndex: 80351; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_115(object P0, in EventData<SetLeaderReason, Entity, Entity> P1); // TypeDefIndex: 80352; 0x00000001859B7730-0x00000001859B7740

	public delegate OutOfScreenTargetArrow __HotPatchDelegate_116(object P0); // TypeDefIndex: 80353; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate ValueTuple<Vector2, float> __HotPatchDelegate_117(object P0, Vector3 P1); // TypeDefIndex: 80354; 0x00000001826E9AE0-0x00000001826E9B40

	public delegate bool __HotPatchDelegate_118(object P0, out OutOfScreenTargetsCtrlV2.ArrowRuntimeState P1); // TypeDefIndex: 80355; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_119(object P0, in EventData<ulong, uint> P1); // TypeDefIndex: 80356; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_120(object P0, in EventData<ulong, string, int> P1); // TypeDefIndex: 80357; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_121(object P0, in EventData<Skill> P1); // TypeDefIndex: 80358; 0x00000001859B7730-0x00000001859B7740

	public delegate Sprite __HotPatchDelegate_122(object P0, object P1); // TypeDefIndex: 80359; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_123(object P0, in EventData<string> P1); // TypeDefIndex: 80360; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_124(object P0, int P1, bool P2, bool P3); // TypeDefIndex: 80361; 0x0000000181217F60-0x0000000181217F80

	public delegate bool __HotPatchDelegate_125(object P0, bool P1); // TypeDefIndex: 80362; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_126(object P0, in EventData<ulong, string, EnergyShardType> P1); // TypeDefIndex: 80363; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_127(object P0, int P1, float P2); // TypeDefIndex: 80364; 0x000000018124EAD0-0x000000018124EAF0

	public delegate void __HotPatchDelegate_128(object P0, in EventData<UIStyleInputValidTypeMask> P1); // TypeDefIndex: 80365; 0x00000001859B7730-0x00000001859B7740

	public delegate TweenCallback __HotPatchDelegate_129(object P0); // TypeDefIndex: 80366; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_130(object P0, ObjectPtr<AbilitySystem> P1, object P2); // TypeDefIndex: 80367; 0x0000000181256E30-0x0000000181256E60

	public delegate UITyphoeaLockingNode __HotPatchDelegate_131(object P0); // TypeDefIndex: 80368; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_132(object P0, in EventData<Dictionary<ObjectPtr<AbilitySystem>, ObjectPtr<Buff>>> P1); // TypeDefIndex: 80369; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_133(object P0, object P1); // TypeDefIndex: 80370; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_134(object P0, object P1, object P2, object P3); // TypeDefIndex: 80371; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_135(object P0, bool P1, float P2, float P3); // TypeDefIndex: 80372; 0x000000018129E8F0-0x000000018129E910

	public delegate void __HotPatchDelegate_136(object P0, in EventData<CinematicTimelineManagerBase.TimelineHandle> P1); // TypeDefIndex: 80373; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_137(object P0, in EventData<ForbidType, bool> P1); // TypeDefIndex: 80374; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_138(object P0, int P1, int P2); // TypeDefIndex: 80375; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_139(object P0, int P1, int P2, byte P3); // TypeDefIndex: 80376; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_140(object P0, int P1, int P2, int P3, int P4, byte P5); // TypeDefIndex: 80377; 0x000000018121C6C0-0x000000018121C6E0

	public delegate byte __HotPatchDelegate_141(object P0, int P1, int P2, out byte P3); // TypeDefIndex: 80378; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_142(object P0, CommonTrackingPointStyleType P1, object P2); // TypeDefIndex: 80379; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_143(object P0, CommonTrackingPointStyleType P1); // TypeDefIndex: 80380; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_144(object P0, Vector2 P1, float P2, bool P3, float P4, bool P5); // TypeDefIndex: 80381; 0x0000000184F4AA10-0x0000000184F4AA40

	public delegate void __HotPatchDelegate_145(object P0, PosValueState P1, bool P2, Vector2 P3, float P4, bool P5, float P6, CommonTrackMapTier P7); // TypeDefIndex: 80382; 0x0000000184F4AA40-0x0000000184F4AA70

	public delegate CommonTrackerUpdate.CommonTrackerItem __HotPatchDelegate_146(object P0); // TypeDefIndex: 80383; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_147(object P0, int P1, object P2, object P3); // TypeDefIndex: 80384; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_148(object P0, bool P1, int P2); // TypeDefIndex: 80385; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_149(object P0, object P1, object P2, ulong P3, int P4); // TypeDefIndex: 80386; 0x00000001812083C0-0x00000001812083E0

	public delegate string __HotPatchDelegate_150(object P0, LangKey P1, object P2); // TypeDefIndex: 80387; 0x0000000181256E30-0x0000000181256E60

	public delegate void __HotPatchDelegate_151(object P0, CoolerUnitTemperatureCircleUI.ETemperatureState P1); // TypeDefIndex: 80388; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_152(object P0, ref float P1, ref float P2); // TypeDefIndex: 80389; 0x00000001811DF7F0-0x00000001811DF810

	public delegate string[] __HotPatchDelegate_153(); // TypeDefIndex: 80390; 0x0000000185B44B70-0x0000000185B44B80

	public delegate bool __HotPatchDelegate_154(object P0, ulong P1); // TypeDefIndex: 80391; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_155(object P0, in EventData<string, uint, ulong> P1); // TypeDefIndex: 80392; 0x00000001859B7730-0x00000001859B7740

	public delegate GameObject __HotPatchDelegate_156(object P0, object P1, object P2); // TypeDefIndex: 80393; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_157(object P0, object P1, UnityEngine.Color P2); // TypeDefIndex: 80394; 0x0000000181499900-0x0000000181499930

	public delegate uint __HotPatchDelegate_158(object P0, object P1, object P2); // TypeDefIndex: 80395; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_159(object P0, uint P1, object P2, object P3); // TypeDefIndex: 80396; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_160(object P0, uint P1, object P2, bool P3, object P4); // TypeDefIndex: 80397; 0x00000001826EA060-0x00000001826EA080

	public delegate void __HotPatchDelegate_161(object P0, uint P1, UnityEngine.Color P2); // TypeDefIndex: 80398; 0x0000000181499900-0x0000000181499930

	public delegate void __HotPatchDelegate_162(object P0, bool P1, float P2, object P3, object P4); // TypeDefIndex: 80399; 0x00000001811DB3F0-0x00000001811DB410

	public delegate void __HotPatchDelegate_163(object P0, float P1, bool P2); // TypeDefIndex: 80400; 0x000000018238E680-0x000000018238E6A0

	public delegate void __HotPatchDelegate_164(object P0, float P1, float P2, float P3, bool P4); // TypeDefIndex: 80401; 0x00000001826DFD40-0x00000001826DFD60

	public delegate void __HotPatchDelegate_165(object P0, float P1, float P2); // TypeDefIndex: 80402; 0x000000018238E680-0x000000018238E6A0

	public delegate void __HotPatchDelegate_166(object P0, bool P1, bool P2, bool P3, ForgeIronTemperatureCircleUI.ETemperatureState P4); // TypeDefIndex: 80403; 0x00000001826EA060-0x00000001826EA080

	public delegate UIHeadLabel __HotPatchDelegate_167(object P0); // TypeDefIndex: 80404; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_168(object P0, UIHeadLabel.VisibleSource P1, bool P2); // TypeDefIndex: 80405; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_169(object P0, UIHeadLabel.HeadLabelType P1, UIHeadLabel.VisibleSource P2, bool P3, bool P4); // TypeDefIndex: 80406; 0x00000001826DF690-0x00000001826DF6C0

	public delegate void __HotPatchDelegate_170(object P0, bool P1, bool P2, bool P3); // TypeDefIndex: 80407; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_171(object P0, object P1, HeadLabelDirty P2); // TypeDefIndex: 80408; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_172(object P0, object P1, object P2, HeadLabelViewContext P3); // TypeDefIndex: 80409; 0x00000001811CDB70-0x00000001811CDB90

	public delegate Transform __HotPatchDelegate_173(object P0); // TypeDefIndex: 80410; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Dictionary<string, RegionMap3DCfg> __HotPatchDelegate_174(object P0); // TypeDefIndex: 80411; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_175(object P0, object P1, Vector3 P2, object P3); // TypeDefIndex: 80412; 0x00000001826E8E10-0x00000001826E8E50

	public delegate bool __HotPatchDelegate_176(Vector2 P0, float P1, UnityEngine.Rect P2); // TypeDefIndex: 80413; 0x0000000184183EF0-0x0000000184183F20

	public delegate void __HotPatchDelegate_177(object P0, RegionMapShowType P1, object P2, object P3, float P4); // TypeDefIndex: 80414; 0x00000001812083C0-0x00000001812083E0

	public delegate Transform __HotPatchDelegate_178(object P0, object P1); // TypeDefIndex: 80415; 0x00000001859B7730-0x00000001859B7740

	public delegate Vector3 __HotPatchDelegate_179(object P0, object P1, object P2, object P3); // TypeDefIndex: 80416; 0x00000001841613B0-0x0000000184161410

	public delegate RegionMap3DCfg __HotPatchDelegate_180(object P0, object P1); // TypeDefIndex: 80417; 0x00000001859B7730-0x00000001859B7740

	public delegate TweenerCore<Quaternion, Quaternion, NoOptions> __HotPatchDelegate_181(object P0, float P1, object P2); // TypeDefIndex: 80418; 0x000000018238E680-0x000000018238E6A0

	public delegate MaterialPropertyBlock __HotPatchDelegate_182(); // TypeDefIndex: 80419; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_183(object P0, in EventData<long, long> P1); // TypeDefIndex: 80420; 0x00000001859B7730-0x00000001859B7740

	public delegate Texture __HotPatchDelegate_184(object P0); // TypeDefIndex: 80421; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UILevelMapFallbackDebugOverlay __HotPatchDelegate_185(object P0); // TypeDefIndex: 80422; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate TextMeshProUGUI __HotPatchDelegate_186(object P0, ref TextMeshProUGUI P1, object P2, float P3, UnityEngine.Color P4, object P5, object P6, TextAlignmentOptions P7); // TypeDefIndex: 80423; 0x0000000184F4AA70-0x0000000184F4AAE0

	public delegate string __HotPatchDelegate_187(float P0, float P1); // TypeDefIndex: 80424; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_188(object P0, Vector2 P1, Vector2 P2, float P3, float P4, object P5, object P6, bool P7, object P8, object P9); // TypeDefIndex: 80425; 0x0000000184F4AAE0-0x0000000184F4AB00

	public delegate void __HotPatchDelegate_189(object P0, Vector2 P1, Vector2 P2, float P3, UnityEngine.Color P4); // TypeDefIndex: 80426; 0x00000001849021C0-0x0000000184902210

	public delegate bool __HotPatchDelegate_190(); // TypeDefIndex: 80427; 0x0000000185B44B70-0x0000000185B44B80

	public delegate MapStaticElementConditionExpression __HotPatchDelegate_191(object P0); // TypeDefIndex: 80428; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate List<RaycastResult> __HotPatchDelegate_192(object P0); // TypeDefIndex: 80429; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate LuaPanel __HotPatchDelegate_193(object P0); // TypeDefIndex: 80430; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_194(int P0, int P1); // TypeDefIndex: 80431; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_195(object P0, int P1, int P2, int P3, int P4); // TypeDefIndex: 80432; 0x00000001812083C0-0x00000001812083E0

	public delegate UnityEngine.Rect __HotPatchDelegate_196(float P0, float P1, float P2, float P3); // TypeDefIndex: 80433; 0x00000001848FE740-0x00000001848FE790

	public delegate List<Vector2> __HotPatchDelegate_197(object P0, Vector2 P1, Vector2 P2, float P3); // TypeDefIndex: 80434; 0x00000001811CDB70-0x00000001811CDB90

	public delegate Vector2 __HotPatchDelegate_198(object P0, Vector2 P1); // TypeDefIndex: 80435; 0x00000001859B7730-0x00000001859B7740

	public delegate Vector2 __HotPatchDelegate_199(object P0, Vector2 P1, object P2, object P3); // TypeDefIndex: 80436; 0x00000001811CDB70-0x00000001811CDB90

	public delegate Graphic __HotPatchDelegate_200(object P0); // TypeDefIndex: 80437; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_201(object P0, int P1, int P2, int P3, int P4); // TypeDefIndex: 80438; 0x00000001812083C0-0x00000001812083E0

	public delegate string __HotPatchDelegate_202(object P0, int P1, int P2); // TypeDefIndex: 80439; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_203(object P0, object P1, long P2, float P3); // TypeDefIndex: 80440; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_204(object P0, Vector3 P1, ulong P2); // TypeDefIndex: 80441; 0x0000000181289520-0x0000000181289560

	public delegate void __HotPatchDelegate_205(object P0, int P1, object P2, object P3); // TypeDefIndex: 80442; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_206(object P0, bool P1, object P2); // TypeDefIndex: 80443; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_207(object P0, long P1); // TypeDefIndex: 80444; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_208(object P0, int P1, uint P2); // TypeDefIndex: 80445; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_209(object P0, int P1, int P2, int P3); // TypeDefIndex: 80446; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_210(object P0, long P1, float P2); // TypeDefIndex: 80447; 0x000000018124EAD0-0x000000018124EAF0

	public delegate void __HotPatchDelegate_211(object P0, Vector2 P1, float P2, bool P3); // TypeDefIndex: 80448; 0x00000001826DF730-0x00000001826DF750

	public delegate void __HotPatchDelegate_212(object P0, ulong P1, int P2, int P3, int P4); // TypeDefIndex: 80449; 0x00000001812083C0-0x00000001812083E0

	public delegate void __HotPatchDelegate_213(object P0, PowerAutoConnectStatus P1); // TypeDefIndex: 80450; 0x00000001859B7730-0x00000001859B7740

	public delegate TravelPoleBrain.TravelPoleIcon __HotPatchDelegate_214(object P0); // TypeDefIndex: 80451; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate GameObject __HotPatchDelegate_215(object P0); // TypeDefIndex: 80452; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_216(object P0, TravelPoleBrain.TravelPoleIcon P1); // TypeDefIndex: 80453; 0x00000001859B7730-0x00000001859B7740

	public delegate TravelPoleBrain.TravelPoleStatus __HotPatchDelegate_217(object P0); // TypeDefIndex: 80454; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_218(object P0, TravelPoleBrain.TravelPoleStatus P1); // TypeDefIndex: 80455; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_219(object P0, in EventData<int, float> P1); // TypeDefIndex: 80456; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_220(object P0, in EventData<WaterDroneSourceType> P1); // TypeDefIndex: 80457; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_221(object P0, CustomAbilityComponent.WaterDroneByHydrantState P1); // TypeDefIndex: 80458; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_222(object P0, in EventData<CustomAbilityComponent.WaterDroneByHydrantState> P1); // TypeDefIndex: 80459; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_223(object P0, ObjectPtr<Entity> P1); // TypeDefIndex: 80460; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate void __HotPatchDelegate_224(object P0, object P1, Vector3 P2, bool P3); // TypeDefIndex: 80461; 0x000000018127ACF0-0x000000018127AD30

	public delegate void __HotPatchDelegate_225(object P0, Vector3 P1, Vector3 P2); // TypeDefIndex: 80462; 0x0000000184160360-0x00000001841603B0
}
